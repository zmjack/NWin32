using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: MMRESULT->UINT->unsigned int
        ///uJoyID: UINT->unsigned int
        ///uThreshold: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "joySetThreshold")]
        public static extern uint joySetThreshold(uint uJoyID, uint uThreshold);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///uJoyID: UINT->unsigned int
        ///uPeriod: UINT->unsigned int
        ///fChanged: BOOL->int
        [DllImport("winmm.dll", EntryPoint = "joySetCapture")]
        public static extern uint joySetCapture(IntPtr hwnd, uint uJoyID, uint uPeriod, [MarshalAs(UnmanagedType.Bool)] bool fChanged);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uJoyID: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "joyReleaseCapture")]
        public static extern uint joyReleaseCapture(uint uJoyID);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uJoyID: UINT->unsigned int
        ///puThreshold: LPUINT->UINT*
        [DllImport("winmm.dll", EntryPoint = "joyGetThreshold")]
        public static extern uint joyGetThreshold(uint uJoyID, ref uint puThreshold);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uJoyID: UINT->unsigned int
        ///pji: LPJOYINFOEX->joyinfoex_tag*
        [DllImport("winmm.dll", EntryPoint = "joyGetPosEx")]
        public static extern uint joyGetPosEx(uint uJoyID, ref joyinfoex_tag pji);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uJoyID: UINT->unsigned int
        ///pji: LPJOYINFO->joyinfo_tag*
        [DllImport("winmm.dll", EntryPoint = "joyGetPos")]
        public static extern uint joyGetPos(uint uJoyID, ref joyinfo_tag pji);


        /// Return Type: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "joyGetNumDevs")]
        public static extern uint joyGetNumDevs();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uJoyID: UINT_PTR->unsigned int
        ///pjc: LPJOYCAPSW->tagJOYCAPSW*
        ///cbjc: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "joyGetDevCapsW")]
        public static extern uint joyGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uJoyID, ref tagJOYCAPSW pjc, uint cbjc);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uJoyID: UINT_PTR->unsigned int
        ///pjc: LPJOYCAPSA->tagJOYCAPSA*
        ///cbjc: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "joyGetDevCapsA")]
        public static extern uint joyGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uJoyID, ref tagJOYCAPSA pjc, uint cbjc);

    }

}
