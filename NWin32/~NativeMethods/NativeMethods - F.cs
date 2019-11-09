using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;
using FILETIME = NWin32.NativeTypes.FILETIME;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///NumberOfPages: PULONG_PTR->unsigned int*
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "FreeUserPhysicalPages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeUserPhysicalPages([In] IntPtr hProcess, ref uint NumberOfPages, [In] IntPtr PageArray);


        /// Return Type: PVOID->void*
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "FreeSid")]
        public static extern IntPtr FreeSid([In] IntPtr pSid);


        /// Return Type: BOOL->int
        ///hResData: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FreeResource")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeResource([In] IntPtr hResData);


        /// Return Type: HRESULT->LONG->int
        ///cVariants: ULONG->unsigned int
        ///rgvars: PROPVARIANT*
        [DllImport("ole32.dll", EntryPoint = "FreePropVariantArray", CallingConvention = CallingConvention.StdCall)]
        public static extern int FreePropVariantArray(uint cVariants, ref tagPROPVARIANT rgvars);


        /// Return Type: BOOL->int
        ///pPrinterNotifyInfo: PPRINTER_NOTIFY_INFO->_PRINTER_NOTIFY_INFO*
        [DllImport("<Unknown>", EntryPoint = "FreePrinterNotifyInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreePrinterNotifyInfo([In] ref PRINTER_NOTIFY_INFO pPrinterNotifyInfo);


        /// Return Type: void
        ///hLibModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///dwExitCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FreeLibraryAndExitThread")]
        public static extern void FreeLibraryAndExitThread([In] IntPtr hLibModule, uint dwExitCode);


        /// Return Type: BOOL->int
        ///hLibModule: HMODULE->HINSTANCE->HINSTANCE__*
        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary([In] IntPtr hLibModule);


        /// Return Type: BOOL->int
        ///param0: LPWCH->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FreeEnvironmentStringsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStringsW([In] [MarshalAs(UnmanagedType.LPWStr)] string param0);


        /// Return Type: BOOL->int
        ///param0: LPCH->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FreeEnvironmentStringsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeEnvironmentStringsA([In] [MarshalAs(UnmanagedType.LPStr)] string param0);


        /// Return Type: void
        ///pHashes: PENCRYPTION_CERTIFICATE_HASH_LIST->_ENCRYPTION_CERTIFICATE_HASH_LIST*
        [DllImport("advapi32.dll", EntryPoint = "FreeEncryptionCertificateHashList")]
        public static extern void FreeEncryptionCertificateHashList([In] IntPtr pHashes);


        /// Return Type: BOOL->int
        ///msg: UINT->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "FreeDDElParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "FreeConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeConsole();


        /// Return Type: void
        ///_Memory: void*
        [DllImport("msvcr80.dll", EntryPoint = "free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void free(IntPtr _Memory);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///hbr: HBRUSH->HBRUSH__*
        ///w: int
        ///h: int
        [DllImport("gdi32.dll", EntryPoint = "FrameRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FrameRgn([In] IntPtr hdc, [In] IntPtr hrgn, [In] IntPtr hbr, int w, int h);


        /// Return Type: int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        ///hbr: HBRUSH->HBRUSH__*
        [DllImport("user32.dll", EntryPoint = "FrameRect")]
        public static extern int FrameRect([In] IntPtr hDC, [In] ref tagRECT lprc, [In] IntPtr hbr);


        /// Return Type: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpSource: LPCVOID->void*
        ///dwMessageId: DWORD->unsigned int
        ///dwLanguageId: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///Arguments: va_list*
        [DllImport("kernel32.dll", EntryPoint = "FormatMessageW")]
        public static extern uint FormatMessageW(uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, uint nSize, ref IntPtr Arguments);


        /// Return Type: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpSource: LPCVOID->void*
        ///dwMessageId: DWORD->unsigned int
        ///dwLanguageId: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///Arguments: va_list*
        [DllImport("kernel32.dll", EntryPoint = "FormatMessageA")]
        public static extern uint FormatMessageA(uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, uint nSize, ref IntPtr Arguments);


        /// Return Type: int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpDestStr: LPWSTR->WCHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "FoldStringW")]
        public static extern int FoldStringW(uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpDestStr, int cchDest);


        /// Return Type: int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpDestStr: LPSTR->CHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "FoldStringA")]
        public static extern int FoldStringA(uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpDestStr, int cchDest);


        /// Return Type: HRESULT->LONG->int
        ///pfmtid: FMTID*
        ///oszName: LPOLESTR->OLECHAR*
        [DllImport("ole32.dll", EntryPoint = "FmtIdToPropStgName", CallingConvention = CallingConvention.StdCall)]
        public static extern int FmtIdToPropStgName(ref GUID pfmtid, IntPtr oszName);


        /// Return Type: BOOL->int
        ///lpBaseAddress: LPCVOID->void*
        ///dwNumberOfBytesToFlush: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FlushViewOfFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushViewOfFile([In] IntPtr lpBaseAddress, uint dwNumberOfBytesToFlush);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pBuf: LPVOID->void*
        ///cbBuf: DWORD->unsigned int
        ///pcWritten: LPDWORD->DWORD*
        ///cSleep: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "FlushPrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushPrinter([In] IntPtr hPrinter, [In] IntPtr pBuf, uint cbBuf, [Out] out uint pcWritten, uint cSleep);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpBaseAddress: LPCVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FlushInstructionCache")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushInstructionCache([In] IntPtr hProcess, [In] IntPtr lpBaseAddress, uint dwSize);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FlushFileBuffers")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushFileBuffers([In] IntPtr hFile);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FlushConsoleInputBuffer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushConsoleInputBuffer(IntPtr hConsoleInput);


        /// Return Type: BOOL->int
        ///dwFlsIndex: DWORD->unsigned int
        ///lpFlsData: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "FlsSetValue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlsSetValue(uint dwFlsIndex, [In] IntPtr lpFlsData);


        /// Return Type: PVOID->void*
        ///dwFlsIndex: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FlsGetValue")]
        public static extern IntPtr FlsGetValue(uint dwFlsIndex);


        /// Return Type: BOOL->int
        ///dwFlsIndex: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FlsFree")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlsFree(uint dwFlsIndex);


        /// Return Type: DWORD->unsigned int
        ///lpCallback: PFLS_CALLBACK_FUNCTION
        [DllImport("kernel32.dll", EntryPoint = "FlsAlloc")]
        public static extern uint FlsAlloc(PFLS_CALLBACK_FUNCTION lpCallback);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "FloodFill")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FloodFill([In] IntPtr hdc, int x, int y, uint color);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "FlattenPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlattenPath([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///pfwi: PFLASHWINFO->Anonymous_d4dee27f_56a5_4822_8f80_a508c7dc0851*
        [DllImport("user32.dll", EntryPoint = "FlashWindowEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindowEx([In] ref FLASHWINFO pfwi);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///bInvert: BOOL->int
        [DllImport("user32.dll", EntryPoint = "FlashWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindow([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bInvert);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: FLAG_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "FLAG_STGMEDIUM_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FLAG_STGMEDIUM_UserUnmarshal(ref uint param0, IntPtr param1, ref FLAG_STGMEDIUM param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: FLAG_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "FLAG_STGMEDIUM_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint FLAG_STGMEDIUM_UserSize(ref uint param0, uint param1, ref FLAG_STGMEDIUM param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: FLAG_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "FLAG_STGMEDIUM_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FLAG_STGMEDIUM_UserMarshal(ref uint param0, IntPtr param1, ref FLAG_STGMEDIUM param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: FLAG_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "FLAG_STGMEDIUM_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void FLAG_STGMEDIUM_UserFree(ref uint param0, ref FLAG_STGMEDIUM param1);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///ptl: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "FixBrushOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FixBrushOrgEx([In] IntPtr hdc, int x, int y, [In] IntPtr ptl);


        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowW")]
        public static extern IntPtr FindWindowW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);


        /// Return Type: HWND->HWND__*
        ///hWndParent: HWND->HWND__*
        ///hWndChildAfter: HWND->HWND__*
        ///lpszClass: LPCWSTR->WCHAR*
        ///lpszWindow: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowExW")]
        public static extern IntPtr FindWindowExW([In] IntPtr hWndParent, [In] IntPtr hWndChildAfter, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszWindow);


        /// Return Type: HWND->HWND__*
        ///hWndParent: HWND->HWND__*
        ///hWndChildAfter: HWND->HWND__*
        ///lpszClass: LPCSTR->CHAR*
        ///lpszWindow: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowExA")]
        public static extern IntPtr FindWindowExA([In] IntPtr hWndParent, [In] IntPtr hWndChildAfter, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszClass, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszWindow);


        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCSTR->CHAR*
        ///lpWindowName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "FindWindowA")]
        public static extern IntPtr FindWindowA([In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName);


        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindVolumeMountPointClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindVolumeMountPointClose([In] IntPtr hFindVolumeMountPoint);


        /// Return Type: BOOL->int
        ///hFindVolume: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindVolumeClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindVolumeClose([In] IntPtr hFindVolume);


        /// Return Type: HWND->HWND__*
        ///param0: LPFINDREPLACEW->tagFINDREPLACEW*
        [DllImport("comdlg32.dll", EntryPoint = "FindTextW")]
        public static extern IntPtr FindTextW(ref tagFINDREPLACEW param0);


        /// Return Type: HWND->HWND__*
        ///param0: LPFINDREPLACEA->tagFINDREPLACEA*
        [DllImport("comdlg32.dll", EntryPoint = "FindTextA")]
        public static extern IntPtr FindTextA(ref tagFINDREPLACEA param0);


        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpName: LPCWSTR->WCHAR*
        ///lpType: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindResourceW")]
        public static extern IntPtr FindResourceW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType);


        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///wLanguage: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "FindResourceExW")]
        public static extern IntPtr FindResourceExW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, ushort wLanguage);


        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpType: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///wLanguage: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "FindResourceExA")]
        public static extern IntPtr FindResourceExA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, ushort wLanguage);


        /// Return Type: HRSRC->HRSRC__*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpName: LPCSTR->CHAR*
        ///lpType: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindResourceA")]
        public static extern IntPtr FindResourceA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType);


        /// Return Type: BOOL->int
        ///hFindVolume: HANDLE->void*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeW(IntPtr hFindVolume, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszVolumeName, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        ///lpszVolumeMountPoint: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeMountPointW([In] IntPtr hFindVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszVolumeMountPoint, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///hFindVolumeMountPoint: HANDLE->void*
        ///lpszVolumeMountPoint: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeMountPointA([In] IntPtr hFindVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszVolumeMountPoint, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///hFindVolume: HANDLE->void*
        ///lpszVolumeName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindNextVolumeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextVolumeA(IntPtr hFindVolume, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszVolumeName, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///hFindStream: HANDLE->void*
        ///lpFindStreamData: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "FindNextStreamW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextStreamW([In] IntPtr hFindStream, IntPtr lpFindStreamData);


        /// Return Type: BOOL->int
        ///hChange: HANDLE->void*
        ///pdwChange: PDWORD->DWORD*
        ///pPrinterNotifyOptions: LPVOID->void*
        ///ppPrinterNotifyInfo: LPVOID*
        [DllImport("<Unknown>", EntryPoint = "FindNextPrinterChangeNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextPrinterChangeNotification([In] IntPtr hChange, IntPtr pdwChange, [In] IntPtr pPrinterNotifyOptions, ref IntPtr ppPrinterNotifyInfo);


        /// Return Type: BOOL->int
        ///hFindFile: HANDLE->void*
        ///lpFindFileData: LPWIN32_FIND_DATAW->_WIN32_FIND_DATAW*
        [DllImport("kernel32.dll", EntryPoint = "FindNextFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextFileW([In] IntPtr hFindFile, [Out] out WIN32_FIND_DATAW lpFindFileData);


        /// Return Type: BOOL->int
        ///hFindFile: HANDLE->void*
        ///lpFindFileData: LPWIN32_FIND_DATAA->_WIN32_FIND_DATAA*
        [DllImport("kernel32.dll", EntryPoint = "FindNextFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextFileA([In] IntPtr hFindFile, [Out] out WIN32_FIND_DATAA lpFindFileData);


        /// Return Type: BOOL->int
        ///hChangeHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindNextChangeNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindNextChangeNotification([In] IntPtr hChangeHandle);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///pwzUrl: LPCWSTR->WCHAR*
        ///pBuffer: LPVOID->void*
        ///cbSize: DWORD->unsigned int
        ///pwzMimeProposed: LPCWSTR->WCHAR*
        ///dwMimeFlags: DWORD->unsigned int
        ///ppwzMimeOut: LPWSTR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "FindMimeFromData", CallingConvention = CallingConvention.StdCall)]
        public static extern int FindMimeFromData(ref IBindCtx pBC, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, IntPtr pBuffer, uint cbSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzMimeProposed, uint dwMimeFlags, ref IntPtr ppwzMimeOut, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///szType: LPCSTR->CHAR*
        ///pclsID: CLSID*
        ///reserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "FindMediaTypeClass", CallingConvention = CallingConvention.StdCall)]
        public static extern int FindMediaTypeClass(ref IBindCtx pBC, [In] [MarshalAs(UnmanagedType.LPStr)] string szType, ref GUID pclsID, uint reserved);


        /// Return Type: HRESULT->LONG->int
        ///rgszTypes: LPCSTR->CHAR*
        ///rgcfTypes: CLIPFORMAT*
        [DllImport("urlmon.dll", EntryPoint = "FindMediaType", CallingConvention = CallingConvention.StdCall)]
        public static extern int FindMediaType([In] [MarshalAs(UnmanagedType.LPStr)] string rgszTypes, ref ushort rgcfTypes);


        /// Return Type: HANDLE->void*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeW")]
        public static extern IntPtr FindFirstVolumeW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszVolumeName, uint cchBufferLength);


        /// Return Type: HANDLE->void*
        ///lpszRootPathName: LPCWSTR->WCHAR*
        ///lpszVolumeMountPoint: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeMountPointW")]
        public static extern IntPtr FindFirstVolumeMountPointW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszRootPathName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszVolumeMountPoint, uint cchBufferLength);


        /// Return Type: HANDLE->void*
        ///lpszRootPathName: LPCSTR->CHAR*
        ///lpszVolumeMountPoint: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeMountPointA")]
        public static extern IntPtr FindFirstVolumeMountPointA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszRootPathName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszVolumeMountPoint, uint cchBufferLength);


        /// Return Type: HANDLE->void*
        ///lpszVolumeName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstVolumeA")]
        public static extern IntPtr FindFirstVolumeA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszVolumeName, uint cchBufferLength);


        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///InfoLevel: STREAM_INFO_LEVELS->_STREAM_INFO_LEVELS
        ///lpFindStreamData: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstStreamW")]
        public static extern IntPtr FindFirstStreamW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, STREAM_INFO_LEVELS InfoLevel, IntPtr lpFindStreamData, uint dwFlags);


        /// Return Type: HANDLE->void*
        ///hPrinter: HANDLE->void*
        ///fdwFlags: DWORD->unsigned int
        ///fdwOptions: DWORD->unsigned int
        ///pPrinterNotifyOptions: LPVOID->void*
        [DllImport("<Unknown>", EntryPoint = "FindFirstPrinterChangeNotification")]
        public static extern IntPtr FindFirstPrinterChangeNotification([In] IntPtr hPrinter, uint fdwFlags, uint fdwOptions, [In] IntPtr pPrinterNotifyOptions);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///pAce: LPVOID*
        [DllImport("advapi32.dll", EntryPoint = "FindFirstFreeAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindFirstFreeAce([In] ref ACL pAcl, out IntPtr pAce);


        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpFindFileData: LPWIN32_FIND_DATAW->_WIN32_FIND_DATAW*
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileW")]
        public static extern IntPtr FindFirstFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [Out] out WIN32_FIND_DATAW lpFindFileData);


        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///fInfoLevelId: FINDEX_INFO_LEVELS->_FINDEX_INFO_LEVELS
        ///lpFindFileData: LPVOID->void*
        ///fSearchOp: FINDEX_SEARCH_OPS->_FINDEX_SEARCH_OPS
        ///lpSearchFilter: LPVOID->void*
        ///dwAdditionalFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileExW")]
        public static extern IntPtr FindFirstFileExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, uint dwAdditionalFlags);


        /// Return Type: HANDLE->void*
        ///lpFileName: LPCSTR->CHAR*
        ///fInfoLevelId: FINDEX_INFO_LEVELS->_FINDEX_INFO_LEVELS
        ///lpFindFileData: LPVOID->void*
        ///fSearchOp: FINDEX_SEARCH_OPS->_FINDEX_SEARCH_OPS
        ///lpSearchFilter: LPVOID->void*
        ///dwAdditionalFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileExA")]
        public static extern IntPtr FindFirstFileExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, IntPtr lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, uint dwAdditionalFlags);


        /// Return Type: HANDLE->void*
        ///lpFileName: LPCSTR->CHAR*
        ///lpFindFileData: LPWIN32_FIND_DATAA->_WIN32_FIND_DATAA*
        [DllImport("kernel32.dll", EntryPoint = "FindFirstFileA")]
        public static extern IntPtr FindFirstFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [Out] out WIN32_FIND_DATAA lpFindFileData);


        /// Return Type: HANDLE->void*
        ///lpPathName: LPCWSTR->WCHAR*
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstChangeNotificationW")]
        public static extern IntPtr FindFirstChangeNotificationW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter);


        /// Return Type: HANDLE->void*
        ///lpPathName: LPCSTR->CHAR*
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "FindFirstChangeNotificationA")]
        public static extern IntPtr FindFirstChangeNotificationA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter);


        /// Return Type: HINSTANCE->HINSTANCE__*
        ///lpFile: LPCWSTR->WCHAR*
        ///lpDirectory: LPCWSTR->WCHAR*
        ///lpResult: LPWSTR->WCHAR*
        [DllImport("shell32.dll", EntryPoint = "FindExecutableW", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FindExecutableW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFile, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDirectory, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpResult);


        /// Return Type: HINSTANCE->HINSTANCE__*
        ///lpFile: LPCSTR->CHAR*
        ///lpDirectory: LPCSTR->CHAR*
        ///lpResult: LPSTR->CHAR*
        [DllImport("shell32.dll", EntryPoint = "FindExecutableA", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FindExecutableA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDirectory, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpResult);


        /// Return Type: BOOL->int
        ///hChange: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "FindClosePrinterChangeNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindClosePrinterChangeNotification([In] IntPtr hChange);


        /// Return Type: BOOL->int
        ///hChangeHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindCloseChangeNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindCloseChangeNotification([In] IntPtr hChangeHandle);


        /// Return Type: BOOL->int
        ///hFindFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FindClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindClose(IntPtr hFindFile);


        /// Return Type: HRESULT->LONG->int
        ///pCertChains: PCERT_CHAIN->_CERT_CHAIN*
        ///pcbCertChains: DWORD*
        ///pcCertChains: DWORD*
        ///pbEncodedIssuerName: BYTE*
        ///cbEncodedIssuerName: DWORD->unsigned int
        ///pwszPurpose: LPCWSTR->WCHAR*
        ///dwKeySpec: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "FindCertsByIssuer")]
        public static extern int FindCertsByIssuer(ref CERT_CHAIN pCertChains, ref uint pcbCertChains, ref uint pcCertChains, ref byte pbEncodedIssuerName, uint cbEncodedIssuerName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszPurpose, uint dwKeySpec);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindAtomW")]
        public static extern ushort FindAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FindAtomA")]
        public static extern ushort FindAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpExtensionGuid: GUID*
        ///ulSectionId: ULONG->unsigned int
        ///lpStringToFind: LPCWSTR->WCHAR*
        ///ReturnedData: PACTCTX_SECTION_KEYED_DATA->tagACTCTX_SECTION_KEYED_DATA*
        [DllImport("kernel32.dll", EntryPoint = "FindActCtxSectionStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindActCtxSectionStringW(uint dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpStringToFind, [Out] out tagACTCTX_SECTION_KEYED_DATA ReturnedData);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpExtensionGuid: GUID*
        ///ulSectionId: ULONG->unsigned int
        ///lpStringToFind: LPCSTR->CHAR*
        ///ReturnedData: PACTCTX_SECTION_KEYED_DATA->tagACTCTX_SECTION_KEYED_DATA*
        [DllImport("kernel32.dll", EntryPoint = "FindActCtxSectionStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindActCtxSectionStringA(uint dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] [MarshalAs(UnmanagedType.LPStr)] string lpStringToFind, [Out] out tagACTCTX_SECTION_KEYED_DATA ReturnedData);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpExtensionGuid: GUID*
        ///ulSectionId: ULONG->unsigned int
        ///lpGuidToFind: GUID*
        ///ReturnedData: PACTCTX_SECTION_KEYED_DATA->tagACTCTX_SECTION_KEYED_DATA*
        [DllImport("kernel32.dll", EntryPoint = "FindActCtxSectionGuid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FindActCtxSectionGuid(uint dwFlags, IntPtr lpExtensionGuid, uint ulSectionId, [In] IntPtr lpGuidToFind, [Out] out tagACTCTX_SECTION_KEYED_DATA ReturnedData);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///hbr: HBRUSH->HBRUSH__*
        [DllImport("gdi32.dll", EntryPoint = "FillRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillRgn([In] IntPtr hdc, [In] IntPtr hrgn, [In] IntPtr hbr);


        /// Return Type: int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        ///hbr: HBRUSH->HBRUSH__*
        [DllImport("user32.dll", EntryPoint = "FillRect")]
        public static extern int FillRect([In] IntPtr hDC, [In] ref tagRECT lprc, [In] IntPtr hbr);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "FillPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillPath([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///cCharacter: WCHAR->wchar_t->unsigned short
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputCharacterW(IntPtr hConsoleOutput, char cCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///cCharacter: CHAR->char
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputCharacterA(IntPtr hConsoleOutput, byte cCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///wAttribute: WORD->unsigned short
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfAttrsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputAttribute(IntPtr hConsoleOutput, ushort wAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);


        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "FileTimeToSystemTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileTimeToSystemTime([In] ref FILETIME lpFileTime, [Out] out SYSTEMTIME lpSystemTime);


        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpLocalFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "FileTimeToLocalFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileTimeToLocalFileTime([In] ref FILETIME lpFileTime, [Out] out FILETIME lpLocalFileTime);


        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpFatDate: LPWORD->WORD*
        ///lpFatTime: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "FileTimeToDosDateTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileTimeToDosDateTime([In] ref FILETIME lpFileTime, [Out] out ushort lpFatDate, [Out] out ushort lpFatTime);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpStatus: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "FileEncryptionStatusW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileEncryptionStatusW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [Out] out uint lpStatus);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///lpStatus: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "FileEncryptionStatusA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FileEncryptionStatusA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [Out] out uint lpStatus);


        /// Return Type: HRESULT->LONG->int
        ///hWnd: HWND->HWND__*
        ///pClassSpec: uCLSSPEC*
        ///pQuery: QUERYCONTEXT*
        ///dwFlags: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "FaultInIEFeature", CallingConvention = CallingConvention.StdCall)]
        public static extern int FaultInIEFeature(IntPtr hWnd, ref uCLSSPEC pClassSpec, ref tagQUERYCONTEXT pQuery, uint dwFlags);


        /// Return Type: void
        ///ExitCode: int
        [DllImport("kernel32.dll", EntryPoint = "FatalExit")]
        public static extern void FatalExit(int ExitCode);


        /// Return Type: void
        ///uAction: UINT->unsigned int
        ///lpMessageText: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "FatalAppExitW")]
        public static extern void FatalAppExitW(uint uAction, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpMessageText);


        /// Return Type: void
        ///uAction: UINT->unsigned int
        ///lpMessageText: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "FatalAppExitA")]
        public static extern void FatalAppExitA(uint uAction, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMessageText);

    }

}
