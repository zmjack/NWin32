using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///lpDef: LPCWSTR->WCHAR*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpDef, [Out] out DCB lpDCB);


        /// Return Type: BOOL->int
        ///lpDef: LPCWSTR->WCHAR*
        ///lpDCB: LPDCB->_DCB*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBAndTimeoutsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBAndTimeoutsW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpDef, [Out] out DCB lpDCB, [Out] out COMMTIMEOUTS lpCommTimeouts);


        /// Return Type: BOOL->int
        ///lpDef: LPCSTR->CHAR*
        ///lpDCB: LPDCB->_DCB*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBAndTimeoutsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBAndTimeoutsA([In] [MarshalAs(UnmanagedType.LPStr)] string lpDef, [Out] out DCB lpDCB, [Out] out COMMTIMEOUTS lpCommTimeouts);


        /// Return Type: BOOL->int
        ///lpDef: LPCSTR->CHAR*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "BuildCommDCBA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BuildCommDCBA([In] [MarshalAs(UnmanagedType.LPStr)] string lpDef, [Out] out DCB lpDCB);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "BSTR_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr BSTR_UserUnmarshal(ref uint param0, IntPtr param1, [MarshalAs(UnmanagedType.BStr)] ref string param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "BSTR_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint BSTR_UserSize(ref uint param0, uint param1, [MarshalAs(UnmanagedType.BStr)] ref string param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "BSTR_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr BSTR_UserMarshal(ref uint param0, IntPtr param1, [MarshalAs(UnmanagedType.BStr)] ref string param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "BSTR_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void BSTR_UserFree(ref uint param0, [MarshalAs(UnmanagedType.BStr)] ref string param1);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///pbstr: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "BstrFromVector", CallingConvention = CallingConvention.StdCall)]
        public static extern int BstrFromVector(ref tagSAFEARRAY psa, [MarshalAs(UnmanagedType.BStr)] ref string pbstr);


        /// Return Type: void*
        ///_Key: void*
        ///_Base: void*
        ///_NumOfElements: rsize_t->size_t->unsigned int
        ///_SizeOfElements: rsize_t->size_t->unsigned int
        ///_PtFuncCompare: Anonymous_82879911_f429_4373_bb0c_5e75913076ff
        ///_Context: void*
        [DllImport("msvcr80.dll", EntryPoint = "bsearch_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bsearch_s([In] IntPtr _Key, [In] IntPtr _Base, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _NumOfElements, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeOfElements, Anonymous_82879911_f429_4373_bb0c_5e75913076ff _PtFuncCompare, IntPtr _Context);


        /// Return Type: void*
        ///_Key: void*
        ///_Base: void*
        ///_NumOfElements: size_t->unsigned int
        ///_SizeOfElements: size_t->unsigned int
        ///_PtFuncCompare: Anonymous_89cfe1e1_00b8_469c_88c3_21e3caf5899b
        [DllImport("ntdll.dll", EntryPoint = "bsearch", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bsearch([In] IntPtr _Key, [In] IntPtr _Base, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _NumOfElements, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeOfElements, Anonymous_89cfe1e1_00b8_469c_88c3_21e3caf5899b _PtFuncCompare);


        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageW")]
        public static extern int BroadcastSystemMessageW(uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///pbsmInfo: PBSMINFO->Anonymous_5d2ef610_55e9_4d35_a7f7_233f11c0e96c*
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageExW")]
        public static extern int BroadcastSystemMessageExW(uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, IntPtr pbsmInfo);


        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///pbsmInfo: PBSMINFO->Anonymous_5d2ef610_55e9_4d35_a7f7_233f11c0e96c*
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageExA")]
        public static extern int BroadcastSystemMessageExA(uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, IntPtr pbsmInfo);


        /// Return Type: int
        ///flags: DWORD->unsigned int
        ///lpInfo: LPDWORD->DWORD*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "BroadcastSystemMessageA")]
        public static extern int BroadcastSystemMessageA(uint flags, IntPtr lpInfo, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "BringWindowToTop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BringWindowToTop([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///hdcSrc: HDC->HDC__*
        ///x1: int
        ///y1: int
        ///rop: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "BitBlt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BitBlt([In] IntPtr hdc, int x, int y, int cx, int cy, [In] IntPtr hdcSrc, int x1, int y1, uint rop);


        /// Return Type: HRESULT->LONG->int
        ///pmk: LPMONIKER->IMoniker*
        ///grfOpt: DWORD->unsigned int
        ///iidResult: IID*
        ///ppvResult: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "BindMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int BindMoniker(ref IMoniker pmk, uint grfOpt, ref GUID iidResult, ref IntPtr ppvResult);


        /// Return Type: BOOL->int
        ///FileHandle: HANDLE->void*
        ///Function: LPOVERLAPPED_COMPLETION_ROUTINE
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "BindIoCompletionCallback")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BindIoCompletionCallback([In] IntPtr FileHandle, LPOVERLAPPED_COMPLETION_ROUTINE Function, uint Flags);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///addr: sockaddr*
        ///namelen: int
        [DllImport("ws2_32.dll", EntryPoint = "bind", CallingConvention = CallingConvention.StdCall)]
        public static extern int bind([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, ref sockaddr addr, int namelen);


        /// Return Type: HANDLE->void*
        ///pFileName: LPCWSTR->WCHAR*
        ///bDeleteExistingResources: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResourceW")]
        public static extern IntPtr BeginUpdateResourceW([In] [MarshalAs(UnmanagedType.LPWStr)] string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);


        /// Return Type: HANDLE->void*
        ///pFileName: LPCSTR->CHAR*
        ///bDeleteExistingResources: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResourceA")]
        public static extern IntPtr BeginUpdateResourceA([In] [MarshalAs(UnmanagedType.LPStr)] string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "BeginPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BeginPath([In] IntPtr hdc);


        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        ///lpPaint: LPPAINTSTRUCT->tagPAINTSTRUCT*
        [DllImport("user32.dll", EntryPoint = "BeginPaint")]
        public static extern IntPtr BeginPaint([In] IntPtr hWnd, [Out] out tagPAINTSTRUCT lpPaint);


        /// Return Type: HDWP->HANDLE->void*
        ///nNumWindows: int
        [DllImport("user32.dll", EntryPoint = "BeginDeferWindowPos")]
        public static extern IntPtr BeginDeferWindowPos(int nNumWindows);


        /// Return Type: BOOL->int
        ///dwFreq: DWORD->unsigned int
        ///dwDuration: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "Beep")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Beep(uint dwFreq, uint dwDuration);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPBYTE->BYTE*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpNumberOfBytesWritten: LPDWORD->DWORD*
        ///bAbort: BOOL->int
        ///bProcessSecurity: BOOL->int
        ///lpContext: LPVOID*
        [DllImport("kernel32.dll", EntryPoint = "BackupWrite")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupWrite([In] IntPtr hFile, [In] IntPtr lpBuffer, uint nNumberOfBytesToWrite, [Out] out uint lpNumberOfBytesWritten, [MarshalAs(UnmanagedType.Bool)] bool bAbort, [MarshalAs(UnmanagedType.Bool)] bool bProcessSecurity, ref IntPtr lpContext);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwLowBytesToSeek: DWORD->unsigned int
        ///dwHighBytesToSeek: DWORD->unsigned int
        ///lpdwLowByteSeeked: LPDWORD->DWORD*
        ///lpdwHighByteSeeked: LPDWORD->DWORD*
        ///lpContext: LPVOID*
        [DllImport("kernel32.dll", EntryPoint = "BackupSeek")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupSeek([In] IntPtr hFile, uint dwLowBytesToSeek, uint dwHighBytesToSeek, [Out] out uint lpdwLowByteSeeked, [Out] out uint lpdwHighByteSeeked, ref IntPtr lpContext);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPBYTE->BYTE*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpNumberOfBytesRead: LPDWORD->DWORD*
        ///bAbort: BOOL->int
        ///bProcessSecurity: BOOL->int
        ///lpContext: LPVOID*
        [DllImport("kernel32.dll", EntryPoint = "BackupRead")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupRead([In] IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, [Out] out uint lpNumberOfBytesRead, [MarshalAs(UnmanagedType.Bool)] bool bAbort, [MarshalAs(UnmanagedType.Bool)] bool bProcessSecurity, ref IntPtr lpContext);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///lpBackupFileName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "BackupEventLogW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupEventLogW([In] IntPtr hEventLog, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///lpBackupFileName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "BackupEventLogA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BackupEventLogA([In] IntPtr hEventLog, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName);

    }

}
