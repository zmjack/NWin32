using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///lpTimeZoneInformation: LPTIME_ZONE_INFORMATION->_TIME_ZONE_INFORMATION*
        ///lpLocalTime: LPSYSTEMTIME->_SYSTEMTIME*
        ///lpUniversalTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "TzSpecificLocalTimeToSystemTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TzSpecificLocalTimeToSystemTime([In] IntPtr lpTimeZoneInformation, [In] ref SYSTEMTIME lpLocalTime, [Out] out SYSTEMTIME lpUniversalTime);


        /// Return Type: BOOL->int
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "TryEnterCriticalSection")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TryEnterCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///xoriginDest: int
        ///yoriginDest: int
        ///wDest: int
        ///hDest: int
        ///hdcSrc: HDC->HDC__*
        ///xoriginSrc: int
        ///yoriginSrc: int
        ///wSrc: int
        ///hSrc: int
        ///crTransparent: UINT->unsigned int
        [DllImport("msimg32.dll", EntryPoint = "TransparentBlt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TransparentBlt([In] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [In] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, uint crTransparent);


        /// Return Type: BOOL->int
        ///hSocket: SOCKET->UINT_PTR->unsigned int
        ///hFile: HANDLE->void*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///nNumberOfBytesPerSend: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpTransmitBuffers: LPTRANSMIT_FILE_BUFFERS->_TRANSMIT_FILE_BUFFERS*
        ///dwReserved: DWORD->unsigned int
        [DllImport("mswsock.dll", EntryPoint = "TransmitFile", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TransmitFile([MarshalAs(UnmanagedType.SysUInt)] UIntPtr hSocket, IntPtr hFile, uint nNumberOfBytesToWrite, uint nNumberOfBytesPerSend, ref OVERLAPPED lpOverlapped, ref TRANSMIT_FILE_BUFFERS lpTransmitBuffers, uint dwReserved);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///cChar: char
        [DllImport("kernel32.dll", EntryPoint = "TransmitCommChar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TransmitCommChar([In] IntPtr hFile, byte cChar);


        /// Return Type: BOOL->int
        ///lpMsg: MSG*
        [DllImport("user32.dll", EntryPoint = "TranslateMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage([In] ref tagMSG lpMsg);


        /// Return Type: BOOL->int
        ///hWndClient: HWND->HWND__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "TranslateMDISysAccel")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMDISysAccel([In] IntPtr hWndClient, [In] ref tagMSG lpMsg);


        /// Return Type: BOOL->int
        ///lpSrc: DWORD*
        ///lpCs: LPCHARSETINFO->tagCHARSETINFO*
        ///dwFlags: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "TranslateCharsetInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateCharsetInfo(ref uint lpSrc, [Out] out tagCHARSETINFO lpCs, uint dwFlags);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hAccTable: HACCEL->HACCEL__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "TranslateAcceleratorW")]
        public static extern int TranslateAcceleratorW([In] IntPtr hWnd, [In] IntPtr hAccTable, [In] ref tagMSG lpMsg);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hAccTable: HACCEL->HACCEL__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "TranslateAcceleratorA")]
        public static extern int TranslateAcceleratorA([In] IntPtr hWnd, [In] IntPtr hAccTable, [In] ref tagMSG lpMsg);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "TransactNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TransactNamedPipe([In] IntPtr hNamedPipe, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, [Out] out uint lpBytesRead, IntPtr lpOverlapped);


        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: UINT->unsigned int
        ///param2: int
        ///param3: int
        ///param4: HWND->HWND__*
        ///param5: LPTPMPARAMS->TPMPARAMS*
        [DllImport("user32.dll", EntryPoint = "TrackPopupMenuEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackPopupMenuEx([In] IntPtr param0, uint param1, int param2, int param3, [In] IntPtr param4, [In] IntPtr param5);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///x: int
        ///y: int
        ///nReserved: int
        ///hWnd: HWND->HWND__*
        ///prcRect: RECT*
        [DllImport("user32.dll", EntryPoint = "TrackPopupMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackPopupMenu([In] IntPtr hMenu, uint uFlags, int x, int y, int nReserved, [In] IntPtr hWnd, [In] IntPtr prcRect);


        /// Return Type: BOOL->int
        ///lpEventTrack: LPTRACKMOUSEEVENT->tagTRACKMOUSEEVENT*
        [DllImport("user32.dll", EntryPoint = "TrackMouseEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackMouseEvent(ref tagTRACKMOUSEEVENT lpEventTrack);


        /// Return Type: wint_t->unsigned short
        ///_C: wint_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "towupper", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort towupper(ushort _C);


        /// Return Type: wint_t->unsigned short
        ///_C: wint_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "towlower", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort towlower(ushort _C);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "toupper", CallingConvention = CallingConvention.Cdecl)]
        public static extern int toupper(int _C);


        /// Return Type: int
        ///wVirtKey: UINT->unsigned int
        ///wScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///pwszBuff: LPWSTR->WCHAR*
        ///cchBuff: int
        ///wFlags: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "ToUnicodeEx")]
        public static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pwszBuff, int cchBuff, uint wFlags, [In] IntPtr dwhkl);


        /// Return Type: int
        ///wVirtKey: UINT->unsigned int
        ///wScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///pwszBuff: LPWSTR->WCHAR*
        ///cchBuff: int
        ///wFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ToUnicode")]
        public static extern int ToUnicode(uint wVirtKey, uint wScanCode, [In] IntPtr lpKeyState, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pwszBuff, int cchBuff, uint wFlags);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "tolower", CallingConvention = CallingConvention.Cdecl)]
        public static extern int tolower(int _C);


        /// Return Type: int
        ///uVirtKey: UINT->unsigned int
        ///uScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///lpChar: LPWORD->WORD*
        ///uFlags: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "ToAsciiEx")]
        public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, uint uFlags, [In] IntPtr dwhkl);


        /// Return Type: int
        ///uVirtKey: UINT->unsigned int
        ///uScanCode: UINT->unsigned int
        ///lpKeyState: BYTE*
        ///lpChar: LPWORD->WORD*
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ToAscii")]
        public static extern int ToAscii(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, uint uFlags);


        /// Return Type: BOOL->int
        ///dwTlsIndex: DWORD->unsigned int
        ///lpTlsValue: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "TlsSetValue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TlsSetValue(uint dwTlsIndex, [In] IntPtr lpTlsValue);


        /// Return Type: LPVOID->void*
        ///dwTlsIndex: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TlsGetValue")]
        public static extern IntPtr TlsGetValue(uint dwTlsIndex);


        /// Return Type: BOOL->int
        ///dwTlsIndex: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TlsFree")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TlsFree(uint dwTlsIndex);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TlsAlloc")]
        public static extern uint TlsAlloc();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDelay: UINT->unsigned int
        ///uResolution: UINT->unsigned int
        ///fptc: LPTIMECALLBACK->TIMECALLBACK*
        ///dwUser: DWORD_PTR->ULONG_PTR->unsigned int
        ///fuEvent: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "timeSetEvent")]
        public static extern uint timeSetEvent(uint uDelay, uint uResolution, ref TIMECALLBACK fptc, uint dwUser, uint fuEvent);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uTimerID: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "timeKillEvent")]
        public static extern uint timeKillEvent(uint uTimerID);


        /// Return Type: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "timeGetTime")]
        public static extern uint timeGetTime();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///pmmt: LPMMTIME->mmtime_tag*
        ///cbmmt: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "timeGetSystemTime")]
        public static extern uint timeGetSystemTime(ref mmtime_tag pmmt, uint cbmmt);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///ptc: LPTIMECAPS->timecaps_tag*
        ///cbtc: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "timeGetDevCaps")]
        public static extern uint timeGetDevCaps(ref timecaps_tag ptc, uint cbtc);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uPeriod: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod")]
        public static extern uint timeEndPeriod(uint uPeriod);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uPeriod: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod")]
        public static extern uint timeBeginPeriod(uint uPeriod);


        /// Return Type: WORD->unsigned short
        ///hwndParent: HWND->HWND__*
        ///wHow: UINT->unsigned int
        ///lpRect: RECT*
        ///cKids: UINT->unsigned int
        ///lpKids: HWND*
        [DllImport("user32.dll", EntryPoint = "TileWindows")]
        public static extern ushort TileWindows([In] IntPtr hwndParent, uint wHow, [In] IntPtr lpRect, uint cKids, ref IntPtr lpKids);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCWSTR->WCHAR*
        ///c: int
        [DllImport("gdi32.dll", EntryPoint = "TextOutW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TextOutW([In] IntPtr hdc, int x, int y, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int c);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCSTR->CHAR*
        ///c: int
        [DllImport("gdi32.dll", EntryPoint = "TextOutA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TextOutA([In] IntPtr hdc, int x, int y, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int c);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///dwExitCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TerminateThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateThread([In] IntPtr hThread, uint dwExitCode);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///uExitCode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TerminateProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateProcess([In] IntPtr hProcess, uint uExitCode);


        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///uExitCode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "TerminateJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateJobObject([In] IntPtr hJob, uint uExitCode);


        /// Return Type: LONG->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCWSTR->WCHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        ///nTabOrigin: int
        [DllImport("user32.dll", EntryPoint = "TabbedTextOutW")]
        public static extern int TabbedTextOutW([In] IntPtr hdc, int x, int y, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions, int nTabOrigin);


        /// Return Type: LONG->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpString: LPCSTR->CHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        ///nTabOrigin: int
        [DllImport("user32.dll", EntryPoint = "TabbedTextOutA")]
        public static extern int TabbedTextOutA([In] IntPtr hdc, int x, int y, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions, int nTabOrigin);

    }

}
