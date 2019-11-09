using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///options: UINT->unsigned int
        ///lprect: RECT*
        ///lpString: LPCWSTR->WCHAR*
        ///c: UINT->unsigned int
        ///lpDx: INT*
        [DllImport("gdi32.dll", EntryPoint = "ExtTextOutW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ExtTextOutW([In] IntPtr hdc, int x, int y, uint options, [In] IntPtr lprect, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, uint c, [In] IntPtr lpDx);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///options: UINT->unsigned int
        ///lprect: RECT*
        ///lpString: LPCSTR->CHAR*
        ///c: UINT->unsigned int
        ///lpDx: INT*
        [DllImport("gdi32.dll", EntryPoint = "ExtTextOutA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ExtTextOutA([In] IntPtr hdc, int x, int y, uint options, [In] IntPtr lprect, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, uint c, [In] IntPtr lpDx);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///mode: int
        [DllImport("gdi32.dll", EntryPoint = "ExtSelectClipRgn")]
        public static extern int ExtSelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn, int mode);


        /// Return Type: HICON->HICON__*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///lpszExeFileName: LPCWSTR->WCHAR*
        ///nIconIndex: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "ExtractIconW", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ExtractIconW(IntPtr hInst, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszExeFileName, uint nIconIndex);


        /// Return Type: UINT->unsigned int
        ///lpszFile: LPCWSTR->WCHAR*
        ///nIconIndex: int
        ///phiconLarge: HICON*
        ///phiconSmall: HICON*
        ///nIcons: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "ExtractIconExW", CallingConvention = CallingConvention.StdCall)]
        public static extern uint ExtractIconExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFile, int nIconIndex, ref IntPtr phiconLarge, ref IntPtr phiconSmall, uint nIcons);


        /// Return Type: UINT->unsigned int
        ///lpszFile: LPCSTR->CHAR*
        ///nIconIndex: int
        ///phiconLarge: HICON*
        ///phiconSmall: HICON*
        ///nIcons: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "ExtractIconExA", CallingConvention = CallingConvention.StdCall)]
        public static extern uint ExtractIconExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszFile, int nIconIndex, ref IntPtr phiconLarge, ref IntPtr phiconSmall, uint nIcons);


        /// Return Type: HICON->HICON__*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///lpszExeFileName: LPCSTR->CHAR*
        ///nIconIndex: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "ExtractIconA", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ExtractIconA(IntPtr hInst, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszExeFileName, uint nIconIndex);


        /// Return Type: HICON->HICON__*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///lpIconPath: LPWSTR->WCHAR*
        ///lpiIcon: LPWORD->WORD*
        [DllImport("shell32.dll", EntryPoint = "ExtractAssociatedIconW", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ExtractAssociatedIconW(IntPtr hInst, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpIconPath, ref ushort lpiIcon);


        /// Return Type: HICON->HICON__*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///lpIconPath: LPSTR->CHAR*
        ///lpiIcon: LPWORD->WORD*
        [DllImport("shell32.dll", EntryPoint = "ExtractAssociatedIconA", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ExtractAssociatedIconA(IntPtr hInst, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpIconPath, ref ushort lpiIcon);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        ///type: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "ExtFloodFill")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ExtFloodFill([In] IntPtr hdc, int x, int y, uint color, uint type);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iEscape: int
        ///cjInput: int
        ///lpInData: LPCSTR->CHAR*
        ///cjOutput: int
        ///lpOutData: LPSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "ExtEscape")]
        public static extern int ExtEscape([In] IntPtr hdc, int iEscape, int cjInput, [In] [MarshalAs(UnmanagedType.LPStr)] string lpInData, int cjOutput, IntPtr lpOutData);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///hInst: HANDLE->void*
        ///pDevModeOutput: LPDEVMODEA->_devicemodeA*
        ///pDeviceName: LPSTR->CHAR*
        ///pPort: LPSTR->CHAR*
        ///pDevModeInput: LPDEVMODEA->_devicemodeA*
        ///pProfile: LPSTR->CHAR*
        ///fMode: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ExtDeviceMode")]
        public static extern int ExtDeviceMode([In] IntPtr hWnd, [In] IntPtr hInst, IntPtr pDevModeOutput, [In] [MarshalAs(UnmanagedType.LPStr)] string pDeviceName, [In] [MarshalAs(UnmanagedType.LPStr)] string pPort, [In] IntPtr pDevModeInput, [In] [MarshalAs(UnmanagedType.LPStr)] string pProfile, uint fMode);


        /// Return Type: HRGN->HRGN__*
        ///lpx: XFORM*
        ///nCount: DWORD->unsigned int
        ///lpData: RGNDATA*
        [DllImport("gdi32.dll", EntryPoint = "ExtCreateRegion")]
        public static extern IntPtr ExtCreateRegion([In] IntPtr lpx, uint nCount, [In] IntPtr lpData);


        /// Return Type: HPEN->HPEN__*
        ///iPenStyle: DWORD->unsigned int
        ///cWidth: DWORD->unsigned int
        ///plbrush: LOGBRUSH*
        ///cStyle: DWORD->unsigned int
        ///pstyle: DWORD*
        [DllImport("gdi32.dll", EntryPoint = "ExtCreatePen")]
        public static extern IntPtr ExtCreatePen(uint iPenStyle, uint cWidth, [In] ref tagLOGBRUSH plbrush, uint cStyle, [In] IntPtr pstyle);


        /// Return Type: DWORD->unsigned int
        ///lpSrc: LPCWSTR->WCHAR*
        ///lpDst: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExpandEnvironmentStringsW")]
        public static extern uint ExpandEnvironmentStringsW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpDst, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpSrc: LPCSTR->CHAR*
        ///lpDst: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExpandEnvironmentStringsA")]
        public static extern uint ExpandEnvironmentStringsA([In] [MarshalAs(UnmanagedType.LPStr)] string lpSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpDst, uint nSize);


        /// Return Type: BOOL->int
        ///uFlags: UINT->unsigned int
        ///dwReason: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);


        /// Return Type: void
        ///dwExitCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExitThread")]
        public static extern void ExitThread(uint dwExitCode);


        /// Return Type: void
        ///uExitCode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ExitProcess")]
        public static extern void ExitProcess(uint uExitCode);


        /// Return Type: void
        ///_Code: int
        [DllImport("msvcr80.dll", EntryPoint = "exit", CallingConvention = CallingConvention.Cdecl)]
        public static extern void exit(int _Code);


        /// Return Type: int
        ///hDC: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ExcludeUpdateRgn")]
        public static extern int ExcludeUpdateRgn([In] IntPtr hDC, [In] IntPtr hWnd);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImport("gdi32.dll", EntryPoint = "ExcludeClipRect")]
        public static extern int ExcludeClipRect([In] IntPtr hdc, int left, int top, int right, int bottom);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFunc: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EscapeCommFunction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EscapeCommFunction([In] IntPtr hFile, uint dwFunc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iEscape: int
        ///cjIn: int
        ///pvIn: LPCSTR->CHAR*
        ///pvOut: LPVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "Escape")]
        public static extern int Escape([In] IntPtr hdc, int iEscape, int cjIn, [In] [MarshalAs(UnmanagedType.LPStr)] string pvIn, IntPtr pvOut);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwEraseType: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "EraseTape")]
        public static extern uint EraseTape([In] IntPtr hDevice, uint dwEraseType, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);


        /// Return Type: BOOL->int
        ///pSid1: PSID->PVOID->void*
        ///pSid2: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "EqualSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EqualSid([In] IntPtr pSid1, [In] IntPtr pSid2);


        /// Return Type: BOOL->int
        ///hrgn1: HRGN->HRGN__*
        ///hrgn2: HRGN->HRGN__*
        [DllImport("gdi32.dll", EntryPoint = "EqualRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EqualRgn([In] IntPtr hrgn1, [In] IntPtr hrgn2);


        /// Return Type: BOOL->int
        ///lprc1: RECT*
        ///lprc2: RECT*
        [DllImport("user32.dll", EntryPoint = "EqualRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EqualRect([In] ref tagRECT lprc1, [In] ref tagRECT lprc2);


        /// Return Type: BOOL->int
        ///pSid1: PSID->PVOID->void*
        ///pSid2: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "EqualPrefixSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EqualPrefixSid([In] IntPtr pSid1, [In] IntPtr pSid2);


        /// Return Type: BOOL->int
        ///pSid1: PSID->PVOID->void*
        ///pSid2: PSID->PVOID->void*
        ///pfEqual: BOOL*
        [DllImport("advapi32.dll", EntryPoint = "EqualDomainSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EqualDomainSid([In] IntPtr pSid1, [In] IntPtr pSid2, [Out] out int pfEqual);


        /// Return Type: BOOL->int
        ///lpEnumFunc: WINSTAENUMPROCW->NAMEENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumWindowStationsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindowStationsW(NAMEENUMPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpEnumFunc: WINSTAENUMPROCA->NAMEENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumWindowStationsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindowStationsA(NAMEENUMPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpEnumFunc: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpUILanguageEnumProc: UILANGUAGE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumUILanguagesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumUILanguagesW(UILANGUAGE_ENUMPROCW lpUILanguageEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpUILanguageEnumProc: UILANGUAGE_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumUILanguagesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumUILanguagesA(UILANGUAGE_ENUMPROCA lpUILanguageEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpTimeFmtEnumProc: TIMEFMT_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumTimeFormatsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumTimeFormatsW(TIMEFMT_ENUMPROCW lpTimeFmtEnumProc, uint Locale, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpTimeFmtEnumProc: TIMEFMT_ENUMPROCA
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumTimeFormatsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumTimeFormatsA(TIMEFMT_ENUMPROCA lpTimeFmtEnumProc, uint Locale, uint dwFlags);


        /// Return Type: BOOL->int
        ///dwThreadId: DWORD->unsigned int
        ///lpfn: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumThreadWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumThreadWindows(uint dwThreadId, WNDENUMPROC lpfn, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpLocaleEnumProc: LOCALE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLocalesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLocalesW(LOCALE_ENUMPROCW lpLocaleEnumProc, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpLocaleEnumProc: LOCALE_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLocalesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLocalesA(LOCALE_ENUMPROCA lpLocaleEnumProc, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpLanguageGroupEnumProc: LANGUAGEGROUP_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLanguageGroupsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLanguageGroupsW(LANGUAGEGROUP_ENUMPROCW lpLanguageGroupEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpLanguageGroupEnumProc: LANGUAGEGROUP_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemLanguageGroupsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemLanguageGroupsA(LANGUAGEGROUP_ENUMPROCA lpLanguageGroupEnumProc, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///GeoClass: GEOCLASS->DWORD->unsigned int
        ///ParentGeoId: GEOID->LONG->int
        ///lpGeoEnumProc: GEO_ENUMPROC
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemGeoID")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemGeoID(uint GeoClass, int ParentGeoId, GEO_ENUMPROC lpGeoEnumProc);


        /// Return Type: UINT->unsigned int
        ///FirmwareTableProviderSignature: DWORD->unsigned int
        ///pFirmwareTableEnumBuffer: PVOID->void*
        ///BufferSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemFirmwareTables")]
        public static extern uint EnumSystemFirmwareTables(uint FirmwareTableProviderSignature, IntPtr pFirmwareTableEnumBuffer, uint BufferSize);


        /// Return Type: BOOL->int
        ///lpCodePageEnumProc: CODEPAGE_ENUMPROCW
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemCodePagesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemCodePagesW(CODEPAGE_ENUMPROCW lpCodePageEnumProc, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpCodePageEnumProc: CODEPAGE_ENUMPROCA
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumSystemCodePagesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumSystemCodePagesA(CODEPAGE_ENUMPROCA lpCodePageEnumProc, uint dwFlags);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///dwServiceType: DWORD->unsigned int
        ///dwServiceState: DWORD->unsigned int
        ///lpServices: LPENUM_SERVICE_STATUSW->_ENUM_SERVICE_STATUSW*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        ///lpServicesReturned: LPDWORD->DWORD*
        ///lpResumeHandle: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "EnumServicesStatusW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumServicesStatusW([In] ref SC_HANDLE__ hSCManager, uint dwServiceType, uint dwServiceState, IntPtr lpServices, uint cbBufSize, [Out] out uint pcbBytesNeeded, [Out] out uint lpServicesReturned, IntPtr lpResumeHandle);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///InfoLevel: SC_ENUM_TYPE->_SC_ENUM_TYPE
        ///dwServiceType: DWORD->unsigned int
        ///dwServiceState: DWORD->unsigned int
        ///lpServices: LPBYTE->BYTE*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        ///lpServicesReturned: LPDWORD->DWORD*
        ///lpResumeHandle: LPDWORD->DWORD*
        ///pszGroupName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "EnumServicesStatusExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumServicesStatusExW([In] ref SC_HANDLE__ hSCManager, SC_ENUM_TYPE InfoLevel, uint dwServiceType, uint dwServiceState, IntPtr lpServices, uint cbBufSize, [Out] out uint pcbBytesNeeded, [Out] out uint lpServicesReturned, IntPtr lpResumeHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszGroupName);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///InfoLevel: SC_ENUM_TYPE->_SC_ENUM_TYPE
        ///dwServiceType: DWORD->unsigned int
        ///dwServiceState: DWORD->unsigned int
        ///lpServices: LPBYTE->BYTE*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        ///lpServicesReturned: LPDWORD->DWORD*
        ///lpResumeHandle: LPDWORD->DWORD*
        ///pszGroupName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "EnumServicesStatusExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumServicesStatusExA([In] ref SC_HANDLE__ hSCManager, SC_ENUM_TYPE InfoLevel, uint dwServiceType, uint dwServiceState, IntPtr lpServices, uint cbBufSize, [Out] out uint pcbBytesNeeded, [Out] out uint lpServicesReturned, IntPtr lpResumeHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string pszGroupName);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///dwServiceType: DWORD->unsigned int
        ///dwServiceState: DWORD->unsigned int
        ///lpServices: LPENUM_SERVICE_STATUSA->_ENUM_SERVICE_STATUSA*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        ///lpServicesReturned: LPDWORD->DWORD*
        ///lpResumeHandle: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "EnumServicesStatusA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumServicesStatusA([In] ref SC_HANDLE__ hSCManager, uint dwServiceType, uint dwServiceState, IntPtr lpServices, uint cbBufSize, [Out] out uint pcbBytesNeeded, [Out] out uint lpServicesReturned, IntPtr lpResumeHandle);


        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpEnumFunc: ENUMRESTYPEPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceTypesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceTypesW([In] IntPtr hModule, ENUMRESTYPEPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpEnumFunc: ENUMRESTYPEPROCA
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceTypesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceTypesA([In] IntPtr hModule, ENUMRESTYPEPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpEnumFunc: ENUMRESNAMEPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceNamesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceNamesW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, ENUMRESNAMEPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCSTR->CHAR*
        ///lpEnumFunc: ENUMRESNAMEPROCA
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceNamesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceNamesA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, ENUMRESNAMEPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///lpEnumFunc: ENUMRESLANGPROCW
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceLanguagesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceLanguagesW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, ENUMRESLANGPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///lpEnumFunc: ENUMRESLANGPROCA
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumResourceLanguagesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumResourceLanguagesA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, ENUMRESLANGPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCW
        [DllImport("user32.dll", EntryPoint = "EnumPropsW")]
        public static extern int EnumPropsW([In] IntPtr hWnd, PROPENUMPROCW lpEnumFunc);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCEXW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumPropsExW")]
        public static extern int EnumPropsExW([In] IntPtr hWnd, PROPENUMPROCEXW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCEXA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumPropsExA")]
        public static extern int EnumPropsExA([In] IntPtr hWnd, PROPENUMPROCEXA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpEnumFunc: PROPENUMPROCA
        [DllImport("user32.dll", EntryPoint = "EnumPropsA")]
        public static extern int EnumPropsA([In] IntPtr hWnd, PROPENUMPROCA lpEnumFunc);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pPrintProcessorInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrintProcessorsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrintProcessorsW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, uint Level, IntPtr pPrintProcessorInfo, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pPrintProcessorInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrintProcessorsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrintProcessorsA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, uint Level, IntPtr pPrintProcessorInfo, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pPrintProcessorName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pDatatypes: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrintProcessorDatatypesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrintProcessorDatatypesW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPrintProcessorName, uint Level, IntPtr pDatatypes, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pPrintProcessorName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pDatatypes: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrintProcessorDatatypesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrintProcessorDatatypesA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pPrintProcessorName, uint Level, IntPtr pDatatypes, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///Flags: DWORD->unsigned int
        ///Name: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pPrinterEnum: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrintersW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrintersW(uint Flags, [In] [MarshalAs(UnmanagedType.LPWStr)] string Name, uint Level, IntPtr pPrinterEnum, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///Flags: DWORD->unsigned int
        ///Name: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pPrinterEnum: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrintersA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrintersA(uint Flags, [In] [MarshalAs(UnmanagedType.LPStr)] string Name, uint Level, IntPtr pPrinterEnum, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCWSTR->WCHAR*
        ///pSubkey: LPWSTR->WCHAR*
        ///cbSubkey: DWORD->unsigned int
        ///pcbSubkey: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterKeyW")]
        public static extern uint EnumPrinterKeyW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pKeyName, IntPtr pSubkey, uint cbSubkey, [Out] out uint pcbSubkey);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCSTR->CHAR*
        ///pSubkey: LPSTR->CHAR*
        ///cbSubkey: DWORD->unsigned int
        ///pcbSubkey: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterKeyA")]
        public static extern uint EnumPrinterKeyA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pKeyName, IntPtr pSubkey, uint cbSubkey, [Out] out uint pcbSubkey);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterDriversW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrinterDriversW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, uint Level, IntPtr pDriverInfo, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterDriversA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPrinterDriversA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, uint Level, IntPtr pDriverInfo, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///dwIndex: DWORD->unsigned int
        ///pValueName: LPWSTR->WCHAR*
        ///cbValueName: DWORD->unsigned int
        ///pcbValueName: LPDWORD->DWORD*
        ///pType: LPDWORD->DWORD*
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        ///pcbData: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterDataW")]
        public static extern uint EnumPrinterDataW([In] IntPtr hPrinter, uint dwIndex, IntPtr pValueName, uint cbValueName, [Out] out uint pcbValueName, IntPtr pType, IntPtr pData, uint cbData, [Out] out uint pcbData);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCWSTR->WCHAR*
        ///pEnumValues: LPBYTE->BYTE*
        ///cbEnumValues: DWORD->unsigned int
        ///pcbEnumValues: LPDWORD->DWORD*
        ///pnEnumValues: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterDataExW")]
        public static extern uint EnumPrinterDataExW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pKeyName, IntPtr pEnumValues, uint cbEnumValues, [Out] out uint pcbEnumValues, [Out] out uint pnEnumValues);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCSTR->CHAR*
        ///pEnumValues: LPBYTE->BYTE*
        ///cbEnumValues: DWORD->unsigned int
        ///pcbEnumValues: LPDWORD->DWORD*
        ///pnEnumValues: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterDataExA")]
        public static extern uint EnumPrinterDataExA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pKeyName, IntPtr pEnumValues, uint cbEnumValues, [Out] out uint pcbEnumValues, [Out] out uint pnEnumValues);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///dwIndex: DWORD->unsigned int
        ///pValueName: LPSTR->CHAR*
        ///cbValueName: DWORD->unsigned int
        ///pcbValueName: LPDWORD->DWORD*
        ///pType: LPDWORD->DWORD*
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        ///pcbData: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPrinterDataA")]
        public static extern uint EnumPrinterDataA([In] IntPtr hPrinter, uint dwIndex, IntPtr pValueName, uint cbValueName, [Out] out uint pcbValueName, IntPtr pType, IntPtr pData, uint cbData, [Out] out uint pcbData);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pPorts: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPortsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPortsW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, uint Level, IntPtr pPorts, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pPorts: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumPortsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumPortsA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, uint Level, IntPtr pPorts, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///nType: int
        ///lpFunc: GOBJENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumObjects")]
        public static extern int EnumObjects([In] IntPtr hdc, int nType, GOBJENUMPROC lpFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pMonitor: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumMonitorsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumMonitorsW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, uint Level, IntPtr pMonitor, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pMonitor: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumMonitorsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumMonitorsA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, uint Level, IntPtr pMonitor, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HMETAFILE->HMETAFILE__*
        ///proc: MFENUMPROC
        ///param: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumMetaFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumMetaFile([In] IntPtr hdc, [In] IntPtr hmf, MFENUMPROC proc, [MarshalAs(UnmanagedType.SysInt)] IntPtr param);


        /// Return Type: BOOL->int
        ///lpLangGroupLocaleEnumProc: LANGGROUPLOCALE_ENUMPROCW
        ///LanguageGroup: LGRPID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumLanguageGroupLocalesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumLanguageGroupLocalesW(LANGGROUPLOCALE_ENUMPROCW lpLangGroupLocaleEnumProc, uint LanguageGroup, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpLangGroupLocaleEnumProc: LANGGROUPLOCALE_ENUMPROCA
        ///LanguageGroup: LGRPID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lParam: LONG_PTR->int
        [DllImport("kernel32.dll", EntryPoint = "EnumLanguageGroupLocalesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumLanguageGroupLocalesA(LANGGROUPLOCALE_ENUMPROCA lpLangGroupLocaleEnumProc, uint LanguageGroup, uint dwFlags, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///FirstJob: DWORD->unsigned int
        ///NoJobs: DWORD->unsigned int
        ///Level: DWORD->unsigned int
        ///pJob: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumJobsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumJobsW([In] IntPtr hPrinter, uint FirstJob, uint NoJobs, uint Level, IntPtr pJob, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///FirstJob: DWORD->unsigned int
        ///NoJobs: DWORD->unsigned int
        ///Level: DWORD->unsigned int
        ///pJob: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumJobsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumJobsA([In] IntPtr hPrinter, uint FirstJob, uint NoJobs, uint Level, IntPtr pJob, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///proc: ICMENUMPROCW
        ///param: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumICMProfilesW")]
        public static extern int EnumICMProfilesW([In] IntPtr hdc, ICMENUMPROCW proc, [MarshalAs(UnmanagedType.SysInt)] IntPtr param);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///proc: ICMENUMPROCA
        ///param: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumICMProfilesA")]
        public static extern int EnumICMProfilesA([In] IntPtr hdc, ICMENUMPROCA proc, [MarshalAs(UnmanagedType.SysInt)] IntPtr param);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumFormsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumFormsW([In] IntPtr hPrinter, uint Level, IntPtr pForm, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        ///pcReturned: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "EnumFormsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumFormsA([In] IntPtr hPrinter, uint Level, IntPtr pForm, uint cbBuf, [Out] out uint pcbNeeded, [Out] out uint pcReturned);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCWSTR->WCHAR*
        ///lpProc: FONTENUMPROCW->OLDFONTENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumFontsW")]
        public static extern int EnumFontsW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpLogfont, OLDFONTENUMPROCW lpProc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCSTR->CHAR*
        ///lpProc: FONTENUMPROCA->OLDFONTENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumFontsA")]
        public static extern int EnumFontsA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpLogfont, OLDFONTENUMPROCA lpProc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCWSTR->WCHAR*
        ///lpProc: FONTENUMPROCW->OLDFONTENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumFontFamiliesW")]
        public static extern int EnumFontFamiliesW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpLogfont, OLDFONTENUMPROCW lpProc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPLOGFONTW->tagLOGFONTW*
        ///lpProc: FONTENUMPROCW->OLDFONTENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        ///dwFlags: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "EnumFontFamiliesExW")]
        public static extern int EnumFontFamiliesExW([In] IntPtr hdc, [In] ref tagLOGFONTW lpLogfont, OLDFONTENUMPROCW lpProc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, uint dwFlags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPLOGFONTA->tagLOGFONTA*
        ///lpProc: FONTENUMPROCA->OLDFONTENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        ///dwFlags: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "EnumFontFamiliesExA")]
        public static extern int EnumFontFamiliesExA([In] IntPtr hdc, [In] ref tagLOGFONTA lpLogfont, OLDFONTENUMPROCA lpProc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, uint dwFlags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpLogfont: LPCSTR->CHAR*
        ///lpProc: FONTENUMPROCA->OLDFONTENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "EnumFontFamiliesA")]
        public static extern int EnumFontFamiliesA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpLogfont, OLDFONTENUMPROCA lpProc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HENHMETAFILE->HENHMETAFILE__*
        ///proc: ENHMFENUMPROC
        ///param: LPVOID->void*
        ///lpRect: RECT*
        [DllImport("gdi32.dll", EntryPoint = "EnumEnhMetaFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumEnhMetaFile([In] IntPtr hdc, [In] IntPtr hmf, ENHMFENUMPROC proc, [In] IntPtr param, [In] IntPtr lpRect);


        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCWSTR->WCHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEW lpDevMode);


        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCWSTR->WCHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEW lpDevMode, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCSTR->CHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEA lpDevMode, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpszDeviceName: LPCSTR->CHAR*
        ///iModeNum: DWORD->unsigned int
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        [DllImport("user32.dll", EntryPoint = "EnumDisplaySettingsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, uint iModeNum, [Out] out DEVMODEA lpDevMode);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lprcClip: LPCRECT->RECT*
        ///lpfnEnum: MONITORENUMPROC
        ///dwData: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayMonitors([In] IntPtr hdc, [In] IntPtr lprcClip, MONITORENUMPROC lpfnEnum, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwData);


        /// Return Type: BOOL->int
        ///lpDevice: LPCWSTR->WCHAR*
        ///iDevNum: DWORD->unsigned int
        ///lpDisplayDevice: PDISPLAY_DEVICEW->_DISPLAY_DEVICEW*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplayDevicesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevicesW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpDevice, uint iDevNum, ref DISPLAY_DEVICEW lpDisplayDevice, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpDevice: LPCSTR->CHAR*
        ///iDevNum: DWORD->unsigned int
        ///lpDisplayDevice: PDISPLAY_DEVICEA->_DISPLAY_DEVICEA*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumDisplayDevicesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevicesA([In] [MarshalAs(UnmanagedType.LPStr)] string lpDevice, uint iDevNum, ref DISPLAY_DEVICEA lpDisplayDevice, uint dwFlags);


        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        ///lpfn: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktopWindows([In] IntPtr hDesktop, WNDENUMPROC lpfn, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hwinsta: HWINSTA->HWINSTA__*
        ///lpEnumFunc: DESKTOPENUMPROCW->NAMEENUMPROCW
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDesktopsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktopsW([In] IntPtr hwinsta, NAMEENUMPROCW lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hwinsta: HWINSTA->HWINSTA__*
        ///lpEnumFunc: DESKTOPENUMPROCA->NAMEENUMPROCA
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumDesktopsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktopsA([In] IntPtr hwinsta, NAMEENUMPROCA lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwServiceState: DWORD->unsigned int
        ///lpServices: LPENUM_SERVICE_STATUSW->_ENUM_SERVICE_STATUSW*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        ///lpServicesReturned: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "EnumDependentServicesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDependentServicesW([In] ref SC_HANDLE__ hService, uint dwServiceState, IntPtr lpServices, uint cbBufSize, [Out] out uint pcbBytesNeeded, [Out] out uint lpServicesReturned);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwServiceState: DWORD->unsigned int
        ///lpServices: LPENUM_SERVICE_STATUSA->_ENUM_SERVICE_STATUSA*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        ///lpServicesReturned: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "EnumDependentServicesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDependentServicesA([In] ref SC_HANDLE__ hService, uint dwServiceState, IntPtr lpServices, uint cbBufSize, [Out] out uint pcbBytesNeeded, [Out] out uint lpServicesReturned);


        /// Return Type: BOOL->int
        ///lpDateFmtEnumProc: DATEFMT_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsW(DATEFMT_ENUMPROCW lpDateFmtEnumProc, uint Locale, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpDateFmtEnumProcEx: DATEFMT_ENUMPROCEXW
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsExW(DATEFMT_ENUMPROCEXW lpDateFmtEnumProcEx, uint Locale, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpDateFmtEnumProcEx: DATEFMT_ENUMPROCEXA
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsExA(DATEFMT_ENUMPROCEXA lpDateFmtEnumProcEx, uint Locale, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpDateFmtEnumProc: DATEFMT_ENUMPROCA
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumDateFormatsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDateFormatsA(DATEFMT_ENUMPROCA lpDateFmtEnumProc, uint Locale, uint dwFlags);


        /// Return Type: UINT->unsigned int
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnumClipboardFormats")]
        public static extern uint EnumClipboardFormats(uint format);


        /// Return Type: BOOL->int
        ///hWndParent: HWND->HWND__*
        ///lpEnumFunc: WNDENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "EnumChildWindows")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows([In] IntPtr hWndParent, WNDENUMPROC lpEnumFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpCalInfoEnumProc: CALINFO_ENUMPROCW
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoW(CALINFO_ENUMPROCW lpCalInfoEnumProc, uint Locale, uint Calendar, uint CalType);


        /// Return Type: BOOL->int
        ///lpCalInfoEnumProcEx: CALINFO_ENUMPROCEXW
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoExW(CALINFO_ENUMPROCEXW lpCalInfoEnumProcEx, uint Locale, uint Calendar, uint CalType);


        /// Return Type: BOOL->int
        ///lpCalInfoEnumProcEx: CALINFO_ENUMPROCEXA
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoExA(CALINFO_ENUMPROCEXA lpCalInfoEnumProcEx, uint Locale, uint Calendar, uint CalType);


        /// Return Type: BOOL->int
        ///lpCalInfoEnumProc: CALINFO_ENUMPROCA
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumCalendarInfoA(CALINFO_ENUMPROCA lpCalInfoEnumProc, uint Locale, uint Calendar, uint CalType);


        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "EnterCriticalSection")]
        public static extern void EnterCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);


        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///fDiscard: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "EndUpdateResourceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndUpdateResourceW([In] IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool fDiscard);


        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///fDiscard: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "EndUpdateResourceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndUpdateResourceA([In] IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool fDiscard);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "EndPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPath([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpPaint: PAINTSTRUCT*
        [DllImport("user32.dll", EntryPoint = "EndPaint")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPaint([In] IntPtr hWnd, [In] ref tagPAINTSTRUCT lpPaint);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "EndPagePrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPagePrinter([In] IntPtr hPrinter);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "EndPage")]
        public static extern int EndPage([In] IntPtr hdc);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EndMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndMenu();


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "EndDocPrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndDocPrinter([In] IntPtr hPrinter);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "EndDoc")]
        public static extern int EndDoc([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nResult: INT_PTR->int
        [DllImport("user32.dll", EntryPoint = "EndDialog")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndDialog([In] IntPtr hDlg, int nResult);


        /// Return Type: BOOL->int
        ///hWinPosInfo: HDWP->HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "EndDeferWindowPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndDeferWindowPos([In] IntPtr hWinPosInfo);


        /// Return Type: BOOL->int
        ///DirPath: LPCWSTR->WCHAR*
        ///Disable: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "EncryptionDisable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EncryptionDisable([In] [MarshalAs(UnmanagedType.LPWStr)] string DirPath, [MarshalAs(UnmanagedType.Bool)] bool Disable);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "EncryptFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EncryptFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "EncryptFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EncryptFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "EncodeSystemPointer")]
        public static extern IntPtr EncodeSystemPointer([In] IntPtr Ptr);


        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "EncodePointer")]
        public static extern IntPtr EncodePointer([In] IntPtr Ptr);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///bEnable: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EnableWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///wSBflags: UINT->unsigned int
        ///wArrows: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnableScrollBar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableScrollBar([In] IntPtr hWnd, uint wSBflags, uint wArrows);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uIDEnableItem: UINT->unsigned int
        ///uEnable: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "EnableMenuItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableMenuItem([In] IntPtr hMenu, uint uIDEnableItem, uint uEnable);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "EmptyClipboard")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EmptyClipboard();


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImport("gdi32.dll", EntryPoint = "Ellipse")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Ellipse([In] IntPtr hdc, int left, int top, int right, int bottom);

    }
}
