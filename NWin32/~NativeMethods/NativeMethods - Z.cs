using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hActCtx: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ZombifyActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ZombifyActCtx(IntPtr hActCtx);

    }

}
