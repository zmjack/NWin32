using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NWin32
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class XProcess
    {
        public static IntPtr[] GetWinThreadWindows(this Process @this)
        {
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
                throw new NotSupportedException("Only Win32NT is supported.");

            var threads = @this.Threads.OfType<ProcessThread>();
            var hWndList = new List<IntPtr>();

            foreach (var thread in threads)
            {
                NativeMethods.EnumThreadWindows((uint)thread.Id, (hWnd, lParam) =>
                {
                    hWndList.Add(hWnd);
                    return 1;
                }, IntPtr.Zero);
            }

            return hWndList.ToArray();
        }

    }
}
