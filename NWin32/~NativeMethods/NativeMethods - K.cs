using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///uIDEvent: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "KillTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uIDEvent);


        /// Return Type: void
        ///bVk: BYTE->unsigned char
        ///bScan: BYTE->unsigned char
        ///dwFlags: DWORD->unsigned int
        ///dwExtraInfo: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

    }

}
