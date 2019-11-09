using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: RPC_STATUS->int
        ///Uuid: UUID*
        ///StringUuid: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidToStringW", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidToStringW([In] ref GUID Uuid, out IntPtr StringUuid);


        /// Return Type: RPC_STATUS->int
        ///Uuid: UUID*
        ///StringUuid: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidToStringA", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidToStringA([In] ref GUID Uuid, out IntPtr StringUuid);


        /// Return Type: int
        ///Uuid: UUID*
        ///Status: RPC_STATUS*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidIsNil", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidIsNil(ref GUID Uuid, ref int Status);


        /// Return Type: unsigned short
        ///Uuid: UUID*
        ///Status: RPC_STATUS*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidHash", CallingConvention = CallingConvention.StdCall)]
        public static extern ushort UuidHash(ref GUID Uuid, ref int Status);


        /// Return Type: RPC_STATUS->int
        ///StringUuid: RPC_WSTR->unsigned short*
        ///Uuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidFromStringW", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidFromStringW([In] IntPtr StringUuid, [Out] out GUID Uuid);


        /// Return Type: RPC_STATUS->int
        ///StringUuid: RPC_CSTR->unsigned char*
        ///Uuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidFromStringA", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidFromStringA([In] [MarshalAs(UnmanagedType.LPStr)] string StringUuid, [Out] out GUID Uuid);


        /// Return Type: int
        ///Uuid1: UUID*
        ///Uuid2: UUID*
        ///Status: RPC_STATUS*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidEqual", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidEqual(ref GUID Uuid1, ref GUID Uuid2, ref int Status);


        /// Return Type: RPC_STATUS->int
        ///Uuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidCreateSequential", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidCreateSequential(ref GUID Uuid);


        /// Return Type: RPC_STATUS->int
        ///NilUuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidCreateNil", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidCreateNil(ref GUID NilUuid);


        /// Return Type: RPC_STATUS->int
        ///Uuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidCreate", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidCreate(ref GUID Uuid);


        /// Return Type: int
        ///Uuid1: UUID*
        ///Uuid2: UUID*
        ///Status: RPC_STATUS*
        [DllImport("rpcrt4.dll", EntryPoint = "UuidCompare", CallingConvention = CallingConvention.StdCall)]
        public static extern int UuidCompare(ref GUID Uuid1, ref GUID Uuid2, ref int Status);


        /// Return Type: BOOL->int
        ///hUserHandle: HANDLE->void*
        ///hJob: HANDLE->void*
        ///bGrant: BOOL->int
        [DllImport("user32.dll", EntryPoint = "UserHandleGrantAccess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UserHandleGrantAccess([In] IntPtr hUserHandle, [In] IntPtr hJob, [MarshalAs(UnmanagedType.Bool)] bool bGrant);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCWSTR->WCHAR*
        ///param2: DWORD->unsigned int
        ///param3: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLOpenStreamW", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLOpenStreamW(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, uint param2, ref IBindStatusCallback param3);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCSTR->CHAR*
        ///param2: DWORD->unsigned int
        ///param3: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLOpenStreamA", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLOpenStreamA(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, uint param2, ref IBindStatusCallback param3);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCWSTR->WCHAR*
        ///param2: DWORD->unsigned int
        ///param3: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLOpenPullStreamW", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLOpenPullStreamW(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, uint param2, ref IBindStatusCallback param3);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCSTR->CHAR*
        ///param2: DWORD->unsigned int
        ///param3: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLOpenPullStreamA", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLOpenPullStreamA(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, uint param2, ref IBindStatusCallback param3);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCWSTR->WCHAR*
        ///param2: LPSTREAM*
        ///param3: DWORD->unsigned int
        ///param4: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLOpenBlockingStreamW", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLOpenBlockingStreamW(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, ref IntPtr param2, uint param3, ref IBindStatusCallback param4);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCSTR->CHAR*
        ///param2: LPSTREAM*
        ///param3: DWORD->unsigned int
        ///param4: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLOpenBlockingStreamA", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLOpenBlockingStreamA(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, ref IntPtr param2, uint param3, ref IBindStatusCallback param4);


        /// Return Type: HRESULT->LONG->int
        ///dwOption: DWORD->unsigned int
        ///pBuffer: LPVOID->void*
        ///dwBufferLength: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "UrlMkSetSessionOption", CallingConvention = CallingConvention.StdCall)]
        public static extern int UrlMkSetSessionOption(uint dwOption, IntPtr pBuffer, uint dwBufferLength, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///dwOption: DWORD->unsigned int
        ///pBuffer: LPVOID->void*
        ///dwBufferLength: DWORD->unsigned int
        ///pdwBufferLength: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "UrlMkGetSessionOption", CallingConvention = CallingConvention.StdCall)]
        public static extern int UrlMkGetSessionOption(uint dwOption, IntPtr pBuffer, uint dwBufferLength, ref uint pdwBufferLength, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCWSTR->WCHAR*
        ///param2: LPCWSTR->WCHAR*
        ///param3: DWORD->unsigned int
        ///param4: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLDownloadToFileW", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLDownloadToFileW(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, [In] [MarshalAs(UnmanagedType.LPWStr)] string param2, uint param3, ref IBindStatusCallback param4);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCSTR->CHAR*
        ///param2: LPCSTR->CHAR*
        ///param3: DWORD->unsigned int
        ///param4: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLDownloadToFileA", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLDownloadToFileA(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, [In] [MarshalAs(UnmanagedType.LPStr)] string param2, uint param3, ref IBindStatusCallback param4);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCWSTR->WCHAR*
        ///param2: LPWSTR->WCHAR*
        ///param3: DWORD->unsigned int
        ///param4: DWORD->unsigned int
        ///param5: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLDownloadToCacheFileW", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLDownloadToCacheFileW(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param2, uint param3, uint param4, ref IBindStatusCallback param5);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPUNKNOWN->IUnknown*
        ///param1: LPCSTR->CHAR*
        ///param2: LPTSTR->LPWSTR->WCHAR*
        ///param3: DWORD->unsigned int
        ///param4: DWORD->unsigned int
        ///param5: LPBINDSTATUSCALLBACK->IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "URLDownloadToCacheFileA", CallingConvention = CallingConvention.StdCall)]
        public static extern int URLDownloadToCacheFileA(ref IUnknown param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param2, uint param3, uint param4, ref IBindStatusCallback param5);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "UpdateWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateWindow([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///lpType: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///wLanguage: WORD->unsigned short
        ///lpData: LPVOID->void*
        ///cb: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "UpdateResourceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateResourceW([In] IntPtr hUpdate, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, ushort wLanguage, [In] IntPtr lpData, uint cb);


        /// Return Type: BOOL->int
        ///hUpdate: HANDLE->void*
        ///lpType: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///wLanguage: WORD->unsigned short
        ///lpData: LPVOID->void*
        ///cb: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "UpdateResourceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateResourceA([In] IntPtr hUpdate, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, ushort wLanguage, [In] IntPtr lpData, uint cb);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///pULWInfo: UPDATELAYEREDWINDOWINFO*
        [DllImport("user32.dll", EntryPoint = "UpdateLayeredWindowIndirect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateLayeredWindowIndirect([In] IntPtr hWnd, [In] IntPtr pULWInfo);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hdcDst: HDC->HDC__*
        ///pptDst: POINT*
        ///psize: SIZE*
        ///hdcSrc: HDC->HDC__*
        ///pptSrc: POINT*
        ///crKey: COLORREF->DWORD->unsigned int
        ///pblend: BLENDFUNCTION*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "UpdateLayeredWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateLayeredWindow([In] IntPtr hWnd, [In] IntPtr hdcDst, [In] IntPtr pptDst, [In] IntPtr psize, [In] IntPtr hdcSrc, [In] IntPtr pptSrc, uint crKey, [In] IntPtr pblend, uint dwFlags);


        /// Return Type: BOOL->int
        ///reserved: DWORD->unsigned int
        ///lpszCMID: LPWSTR->WCHAR*
        ///lpszFileName: LPWSTR->WCHAR*
        ///command: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "UpdateICMRegKeyW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateICMRegKeyW(uint reserved, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszCMID, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, uint command);


        /// Return Type: BOOL->int
        ///reserved: DWORD->unsigned int
        ///lpszCMID: LPSTR->CHAR*
        ///lpszFileName: LPSTR->CHAR*
        ///command: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "UpdateICMRegKeyA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateICMRegKeyA(uint reserved, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszCMID, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszFileName, uint command);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "UpdateColors")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateColors([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///WaitHandle: HANDLE->void*
        ///CompletionEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "UnregisterWaitEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterWaitEx([In] IntPtr WaitHandle, [In] IntPtr CompletionEvent);


        /// Return Type: BOOL->int
        ///WaitHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "UnregisterWait")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterWait([In] IntPtr WaitHandle);


        /// Return Type: HRESULT->LONG->int
        ///libID: GUID*
        ///wVerMajor: WORD->unsigned short
        ///wVerMinor: WORD->unsigned short
        ///lcid: LCID->DWORD->unsigned int
        ///syskind: SYSKIND->tagSYSKIND
        [DllImport("oleaut32.dll", EntryPoint = "UnRegisterTypeLib", CallingConvention = CallingConvention.StdCall)]
        public static extern int UnRegisterTypeLib(ref GUID libID, ushort wVerMajor, ushort wVerMinor, uint lcid, tagSYSKIND syskind);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///id: int
        [DllImport("user32.dll", EntryPoint = "UnregisterHotKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterHotKey([In] IntPtr hWnd, int id);


        /// Return Type: BOOL->int
        ///Handle: HDEVNOTIFY->PVOID->void*
        [DllImport("user32.dll", EntryPoint = "UnregisterDeviceNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterDeviceNotification([In] IntPtr Handle);


        /// Return Type: BOOL->int
        ///lpClassName: LPCWSTR->WCHAR*
        ///hInstance: HINSTANCE->HINSTANCE__*
        [DllImport("user32.dll", EntryPoint = "UnregisterClassW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterClassW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] IntPtr hInstance);


        /// Return Type: BOOL->int
        ///lpClassName: LPCSTR->CHAR*
        ///hInstance: HINSTANCE->HINSTANCE__*
        [DllImport("user32.dll", EntryPoint = "UnregisterClassA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterClassA([In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] IntPtr hInstance);


        /// Return Type: BOOL->int
        ///h: HGDIOBJ->void*
        [DllImport("gdi32.dll", EntryPoint = "UnrealizeObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnrealizeObject([In] IntPtr h);


        /// Return Type: BOOL->int
        ///msg: UINT->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///puiLo: PUINT_PTR->unsigned int*
        ///puiHi: PUINT_PTR->unsigned int*
        [DllImport("user32.dll", EntryPoint = "UnpackDDElParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnpackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, ref uint puiLo, ref uint puiHi);


        /// Return Type: BOOL->int
        ///lpBaseAddress: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "UnmapViewOfFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnmapViewOfFile([In] IntPtr lpBaseAddress);


        /// Return Type: BOOL->int
        ///ScLock: SC_LOCK->LPVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "UnlockServiceDatabase")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnlockServiceDatabase([In] IntPtr ScLock);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwReserved: DWORD->unsigned int
        ///nNumberOfBytesToUnlockLow: DWORD->unsigned int
        ///nNumberOfBytesToUnlockHigh: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "UnlockFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnlockFileEx([In] IntPtr hFile, uint dwReserved, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh, ref OVERLAPPED lpOverlapped);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///nNumberOfBytesToUnlockLow: DWORD->unsigned int
        ///nNumberOfBytesToUnlockHigh: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "UnlockFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnlockFile([In] IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh);


        /// Return Type: BOOL->int
        ///hkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "UnloadKeyboardLayout")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnloadKeyboardLayout([In] IntPtr hkl);


        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc1: RECT*
        ///lprcSrc2: RECT*
        [DllImport("user32.dll", EntryPoint = "UnionRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnionRect([Out] out tagRECT lprcDst, [In] ref tagRECT lprcSrc1, [In] ref tagRECT lprcSrc2);


        /// Return Type: BOOL->int
        ///hWinEventHook: HWINEVENTHOOK->HWINEVENTHOOK__*
        [DllImport("user32.dll", EntryPoint = "UnhookWinEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWinEvent([In] IntPtr hWinEventHook);


        /// Return Type: BOOL->int
        ///hhk: HHOOK->HHOOK__*
        [DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx([In] IntPtr hhk);


        /// Return Type: BOOL->int
        ///nCode: int
        ///pfnFilterProc: HOOKPROC
        [DllImport("user32.dll", EntryPoint = "UnhookWindowsHook")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHook(int nCode, HOOKPROC pfnFilterProc);


        /// Return Type: LONG->int
        ///ExceptionInfo: _EXCEPTION_POINTERS*
        [DllImport("kernel32.dll", EntryPoint = "UnhandledExceptionFilter")]
        public static extern int UnhandledExceptionFilter([In] ref EXCEPTION_POINTERS ExceptionInfo);

    }

}
