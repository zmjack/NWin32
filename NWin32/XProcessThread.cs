using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NWin32
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class XProcessThread
    {
        public static IntPtr[] GetWinThreadWindows(this ProcessThread @this)
        {
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
                throw new NotSupportedException("Only Win32NT is supported.");

            var hWndList = new List<IntPtr>();
            NativeMethods.EnumThreadWindows((uint)@this.Id, (hWnd, lParam) =>
            {
                hWndList.Add(hWnd);
                return 1;
            }, IntPtr.Zero);

            return hWndList.ToArray();
        }

    }
}
