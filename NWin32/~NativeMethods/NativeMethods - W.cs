using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPCWSTR->WCHAR*
        ///arglist: va_list->char*
        [DllImport("user32.dll", EntryPoint = "wvsprintfW")]
        public static extern int wvsprintfW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, [In] [MarshalAs(UnmanagedType.LPStr)] string arglist);


        /// Return Type: int
        ///param0: LPSTR->CHAR*
        ///param1: LPCSTR->CHAR*
        ///arglist: va_list->char*
        [DllImport("user32.dll", EntryPoint = "wvsprintfA")]
        public static extern int wvsprintfA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, [In] [MarshalAs(UnmanagedType.LPStr)] string arglist);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WTSGetActiveConsoleSessionId")]
        public static extern uint WTSGetActiveConsoleSessionId();


        /// Return Type: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAUnhookBlockingHook", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSAUnhookBlockingHook();


        /// Return Type: int
        ///wVersionRequired: WORD->unsigned short
        ///lpWSAData: LPWSADATA->WSADATA*
        [DllImport("ws2_32.dll", EntryPoint = "WSAStartup", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSAStartup(ushort wVersionRequired, ref WSAData lpWSAData);


        /// Return Type: void
        ///iError: int
        [DllImport("ws2_32.dll", EntryPoint = "WSASetLastError", CallingConvention = CallingConvention.StdCall)]
        public static extern void WSASetLastError(int iError);


        /// Return Type: FARPROC
        ///lpBlockFunc: FARPROC
        [DllImport("ws2_32.dll", EntryPoint = "WSASetBlockingHook", CallingConvention = CallingConvention.StdCall)]
        public static extern FARPROC WSASetBlockingHook(FARPROC lpBlockFunc);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///buf: char*
        ///len: int
        ///flags: int*
        [DllImport("mswsock.dll", EntryPoint = "WSARecvEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSARecvEx([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, IntPtr buf, int len, ref int flags);


        /// Return Type: BOOL->int
        [DllImport("ws2_32.dll", EntryPoint = "WSAIsBlocking", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WSAIsBlocking();


        /// Return Type: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAGetLastError", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSAGetLastError();


        /// Return Type: int
        [DllImport("ws2_32.dll", EntryPoint = "WSACleanup", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSACleanup();


        /// Return Type: int
        [DllImport("ws2_32.dll", EntryPoint = "WSACancelBlockingCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSACancelBlockingCall();


        /// Return Type: int
        ///hAsyncTaskHandle: HANDLE->void*
        [DllImport("ws2_32.dll", EntryPoint = "WSACancelAsyncRequest", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSACancelAsyncRequest(IntPtr hAsyncTaskHandle);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///hWnd: HWND->HWND__*
        ///wMsg: u_int->unsigned int
        ///lEvent: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAAsyncSelect", CallingConvention = CallingConvention.StdCall)]
        public static extern int WSAAsyncSelect([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, IntPtr hWnd, uint wMsg, int lEvent);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///wMsg: u_int->unsigned int
        ///port: int
        ///proto: char*
        ///buf: char*
        ///buflen: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAAsyncGetServByPort", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr WSAAsyncGetServByPort(IntPtr hWnd, uint wMsg, int port, [In] [MarshalAs(UnmanagedType.LPStr)] string proto, IntPtr buf, int buflen);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///wMsg: u_int->unsigned int
        ///name: char*
        ///proto: char*
        ///buf: char*
        ///buflen: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAAsyncGetServByName", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr WSAAsyncGetServByName(IntPtr hWnd, uint wMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string name, [In] [MarshalAs(UnmanagedType.LPStr)] string proto, IntPtr buf, int buflen);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///wMsg: u_int->unsigned int
        ///number: int
        ///buf: char*
        ///buflen: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAAsyncGetProtoByNumber", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr WSAAsyncGetProtoByNumber(IntPtr hWnd, uint wMsg, int number, IntPtr buf, int buflen);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///wMsg: u_int->unsigned int
        ///name: char*
        ///buf: char*
        ///buflen: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAAsyncGetProtoByName", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr WSAAsyncGetProtoByName(IntPtr hWnd, uint wMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr buf, int buflen);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///wMsg: u_int->unsigned int
        ///name: char*
        ///buf: char*
        ///buflen: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAAsyncGetHostByName", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr WSAAsyncGetHostByName(IntPtr hWnd, uint wMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string name, IntPtr buf, int buflen);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///wMsg: u_int->unsigned int
        ///addr: char*
        ///len: int
        ///type: int
        ///buf: char*
        ///buflen: int
        [DllImport("ws2_32.dll", EntryPoint = "WSAAsyncGetHostByAddr", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr WSAAsyncGetHostByAddr(IntPtr hWnd, uint wMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string addr, int len, int type, IntPtr buf, int buflen);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwTapemarkType: DWORD->unsigned int
        ///dwTapemarkCount: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "WriteTapemark")]
        public static extern uint WriteTapemark([In] IntPtr hDevice, uint dwTapemarkType, uint dwTapemarkCount, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);


        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileStringW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileStringA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileSectionW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileSectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WriteProfileSectionA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProfileSectionA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpBaseAddress: LPVOID->void*
        ///lpBuffer: LPCVOID->void*
        ///nSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpNumberOfBytesWritten: SIZE_T*
        [DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProcessMemory([In] IntPtr hProcess, [In] IntPtr lpBaseAddress, [In] IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesWritten);


        /// Return Type: BOOL->int
        ///lpszSection: LPCWSTR->WCHAR*
        ///lpszKey: LPCWSTR->WCHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStructW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStructW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, [In] IntPtr lpStruct, uint uSizeStruct, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFile);


        /// Return Type: BOOL->int
        ///lpszSection: LPCSTR->CHAR*
        ///lpszKey: LPCSTR->CHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStructA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStructA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszKey, [In] IntPtr lpStruct, uint uSizeStruct, [In] [MarshalAs(UnmanagedType.LPStr)] string szFile);


        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStringW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileStringA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpString: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSectionW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileSectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpAppName: LPCSTR->CHAR*
        ///lpString: LPCSTR->CHAR*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSectionA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrivateProfileSectionA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pBuf: LPVOID->void*
        ///cbBuf: DWORD->unsigned int
        ///pcWritten: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "WritePrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WritePrinter([In] IntPtr hPrinter, [In] IntPtr pBuf, uint cbBuf, [Out] out uint pcWritten);


        /// Return Type: BOOL->int
        ///lpLogginginfo: LPHIT_LOGGING_INFO->_tagHIT_LOGGING_INFO*
        [DllImport("urlmon.dll", EntryPoint = "WriteHitLogging")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteHitLogging(ref HIT_LOGGING_INFO lpLogginginfo);


        /// Return Type: HRESULT->LONG->int
        ///pstg: LPSTORAGE->IStorage*
        ///cf: CLIPFORMAT->WORD->unsigned short
        ///lpszUserType: LPOLESTR->OLECHAR*
        [DllImport("ole32.dll", EntryPoint = "WriteFmtUserTypeStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteFmtUserTypeStg(ref IStorage pstg, ushort cf, IntPtr lpszUserType);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///aSegmentArray: FILE_SEGMENT_ELEMENT*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpReserved: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "WriteFileGather")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteFileGather([In] IntPtr hFile, [In] ref FILE_SEGMENT_ELEMENT aSegmentArray, uint nNumberOfBytesToWrite, IntPtr lpReserved, ref OVERLAPPED lpOverlapped);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPCVOID->void*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpCompletionRoutine: LPOVERLAPPED_COMPLETION_ROUTINE
        [DllImport("kernel32.dll", EntryPoint = "WriteFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteFileEx([In] IntPtr hFile, [In] IntPtr lpBuffer, uint nNumberOfBytesToWrite, ref OVERLAPPED lpOverlapped, LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPCVOID->void*
        ///nNumberOfBytesToWrite: DWORD->unsigned int
        ///lpNumberOfBytesWritten: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "WriteFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteFile([In] IntPtr hFile, [In] IntPtr lpBuffer, uint nNumberOfBytesToWrite, IntPtr lpNumberOfBytesWritten, IntPtr lpOverlapped);


        /// Return Type: DWORD->unsigned int
        ///pfImportCallback: PFE_IMPORT_FUNC
        ///pvCallbackContext: PVOID->void*
        ///pvContext: PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "WriteEncryptedFileRaw")]
        public static extern uint WriteEncryptedFileRaw(PFE_IMPORT_FUNC pfImportCallback, [In] IntPtr pvCallbackContext, [In] IntPtr pvContext);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: void*
        ///nNumberOfCharsToWrite: DWORD->unsigned int
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleW(IntPtr hConsoleOutput, IntPtr lpBuffer, uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpWriteRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputW(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPCWSTR->WCHAR*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputCharacterW(IntPtr hConsoleOutput, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPCSTR->CHAR*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputCharacterA(IntPtr hConsoleOutput, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpAttribute: WORD*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfAttrsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputAttribute(IntPtr hConsoleOutput, ref ushort lpAttribute, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpWriteRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputA(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsWritten);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: void*
        ///nNumberOfCharsToWrite: DWORD->unsigned int
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleA(IntPtr hConsoleOutput, IntPtr lpBuffer, uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        ///rclsid: IID*
        [DllImport("ole32.dll", EntryPoint = "WriteClassStm", CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteClassStm(ref IStream pStm, ref GUID rclsid);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        ///rclsid: IID*
        [DllImport("ole32.dll", EntryPoint = "WriteClassStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteClassStg(ref IStorage pStg, ref GUID rclsid);


        /// Return Type: LONG->int
        ///dwFuncNumber: DWORD->unsigned int
        ///dwFlag: DWORD->unsigned int
        ///dwRes: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "Wow64Win32ApiEntry")]
        public static extern int Wow64Win32ApiEntry(uint dwFuncNumber, uint dwFlag, uint dwRes);


        /// Return Type: BOOL->int
        ///OlValue: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "Wow64RevertWow64FsRedirection")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Wow64RevertWow64FsRedirection([In] IntPtr OlValue);


        /// Return Type: BOOLEAN->BYTE->unsigned char
        ///Wow64FsEnableRedirection: BOOLEAN->BYTE->unsigned char
        [DllImport("kernel32.dll", EntryPoint = "Wow64EnableWow64FsRedirection")]
        public static extern byte Wow64EnableWow64FsRedirection(byte Wow64FsEnableRedirection);


        /// Return Type: BOOL->int
        ///OldValue: PVOID*
        [DllImport("kernel32.dll", EntryPoint = "Wow64DisableWow64FsRedirection")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr OldValue);


        /// Return Type: DWORD->unsigned int
        ///hwndOwner: HWND->HWND__*
        ///lpNetResource: LPNETRESOURCEW->_NETRESOURCEW*
        ///lpPassword: LPCWSTR->WCHAR*
        ///lpUserID: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///lpAccessName: LPWSTR->WCHAR*
        ///lpBufferSize: LPDWORD->DWORD*
        ///lpResult: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetUseConnectionW")]
        public static extern uint WNetUseConnectionW(IntPtr hwndOwner, ref NETRESOURCEW lpNetResource, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpUserID, uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpAccessName, ref uint lpBufferSize, ref uint lpResult);


        /// Return Type: DWORD->unsigned int
        ///hwndOwner: HWND->HWND__*
        ///lpNetResource: LPNETRESOURCEA->_NETRESOURCEA*
        ///lpPassword: LPCSTR->CHAR*
        ///lpUserID: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///lpAccessName: LPSTR->CHAR*
        ///lpBufferSize: LPDWORD->DWORD*
        ///lpResult: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetUseConnectionA")]
        public static extern uint WNetUseConnectionA(IntPtr hwndOwner, ref NETRESOURCEA lpNetResource, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPStr)] string lpUserID, uint dwFlags, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpAccessName, ref uint lpBufferSize, ref uint lpResult);


        /// Return Type: DWORD->unsigned int
        ///hwndParent: HWND->HWND__*
        ///lpDevice: LPCWSTR->WCHAR*
        [DllImport("mpr.dll", EntryPoint = "WNetRestoreConnectionW")]
        public static extern uint WNetRestoreConnectionW(IntPtr hwndParent, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDevice);


        /// Return Type: DWORD->unsigned int
        ///hwndParent: HWND->HWND__*
        ///lpDevice: LPCSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "WNetRestoreConnectionA")]
        public static extern uint WNetRestoreConnectionA(IntPtr hwndParent, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDevice);


        /// Return Type: DWORD->unsigned int
        ///dwScope: DWORD->unsigned int
        ///dwType: DWORD->unsigned int
        ///dwUsage: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEW->_NETRESOURCEW*
        ///lphEnum: LPHANDLE->HANDLE*
        [DllImport("mpr.dll", EntryPoint = "WNetOpenEnumW")]
        public static extern uint WNetOpenEnumW(uint dwScope, uint dwType, uint dwUsage, ref NETRESOURCEW lpNetResource, ref IntPtr lphEnum);


        /// Return Type: DWORD->unsigned int
        ///dwScope: DWORD->unsigned int
        ///dwType: DWORD->unsigned int
        ///dwUsage: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEA->_NETRESOURCEA*
        ///lphEnum: LPHANDLE->HANDLE*
        [DllImport("mpr.dll", EntryPoint = "WNetOpenEnumA")]
        public static extern uint WNetOpenEnumA(uint dwScope, uint dwType, uint dwUsage, ref NETRESOURCEA lpNetResource, ref IntPtr lphEnum);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///lpUserName: LPWSTR->WCHAR*
        ///lpnLength: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetUserW")]
        public static extern uint WNetGetUserW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpUserName, ref uint lpnLength);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        ///lpUserName: LPSTR->CHAR*
        ///lpnLength: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetUserA")]
        public static extern uint WNetGetUserA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpUserName, ref uint lpnLength);


        /// Return Type: DWORD->unsigned int
        ///lpLocalPath: LPCWSTR->WCHAR*
        ///dwInfoLevel: DWORD->unsigned int
        ///lpBuffer: LPVOID->void*
        ///lpBufferSize: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetUniversalNameW")]
        public static extern uint WNetGetUniversalNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpLocalPath, uint dwInfoLevel, IntPtr lpBuffer, ref uint lpBufferSize);


        /// Return Type: DWORD->unsigned int
        ///lpLocalPath: LPCSTR->CHAR*
        ///dwInfoLevel: DWORD->unsigned int
        ///lpBuffer: LPVOID->void*
        ///lpBufferSize: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetUniversalNameA")]
        public static extern uint WNetGetUniversalNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpLocalPath, uint dwInfoLevel, IntPtr lpBuffer, ref uint lpBufferSize);


        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEW->_NETRESOURCEW*
        ///lpBuffer: LPVOID->void*
        ///lpcbBuffer: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetResourceParentW")]
        public static extern uint WNetGetResourceParentW(ref NETRESOURCEW lpNetResource, IntPtr lpBuffer, ref uint lpcbBuffer);


        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEA->_NETRESOURCEA*
        ///lpBuffer: LPVOID->void*
        ///lpcbBuffer: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetResourceParentA")]
        public static extern uint WNetGetResourceParentA(ref NETRESOURCEA lpNetResource, IntPtr lpBuffer, ref uint lpcbBuffer);


        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEW->_NETRESOURCEW*
        ///lpBuffer: LPVOID->void*
        ///lpcbBuffer: LPDWORD->DWORD*
        ///lplpSystem: LPWSTR*
        [DllImport("mpr.dll", EntryPoint = "WNetGetResourceInformationW")]
        public static extern uint WNetGetResourceInformationW(ref NETRESOURCEW lpNetResource, IntPtr lpBuffer, ref uint lpcbBuffer, ref IntPtr lplpSystem);


        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEA->_NETRESOURCEA*
        ///lpBuffer: LPVOID->void*
        ///lpcbBuffer: LPDWORD->DWORD*
        ///lplpSystem: LPSTR*
        [DllImport("mpr.dll", EntryPoint = "WNetGetResourceInformationA")]
        public static extern uint WNetGetResourceInformationA(ref NETRESOURCEA lpNetResource, IntPtr lpBuffer, ref uint lpcbBuffer, ref IntPtr lplpSystem);


        /// Return Type: DWORD->unsigned int
        ///dwNetType: DWORD->unsigned int
        ///lpProviderName: LPWSTR->WCHAR*
        ///lpBufferSize: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetProviderNameW")]
        public static extern uint WNetGetProviderNameW(uint dwNetType, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpProviderName, ref uint lpBufferSize);


        /// Return Type: DWORD->unsigned int
        ///dwNetType: DWORD->unsigned int
        ///lpProviderName: LPSTR->CHAR*
        ///lpBufferSize: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetProviderNameA")]
        public static extern uint WNetGetProviderNameA(uint dwNetType, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpProviderName, ref uint lpBufferSize);


        /// Return Type: DWORD->unsigned int
        ///lpProvider: LPCWSTR->WCHAR*
        ///lpNetInfoStruct: LPNETINFOSTRUCT->_NETINFOSTRUCT*
        [DllImport("mpr.dll", EntryPoint = "WNetGetNetworkInformationW")]
        public static extern uint WNetGetNetworkInformationW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpProvider, ref NETINFOSTRUCT lpNetInfoStruct);


        /// Return Type: DWORD->unsigned int
        ///lpProvider: LPCSTR->CHAR*
        ///lpNetInfoStruct: LPNETINFOSTRUCT->_NETINFOSTRUCT*
        [DllImport("mpr.dll", EntryPoint = "WNetGetNetworkInformationA")]
        public static extern uint WNetGetNetworkInformationA([In] [MarshalAs(UnmanagedType.LPStr)] string lpProvider, ref NETINFOSTRUCT lpNetInfoStruct);


        /// Return Type: DWORD->unsigned int
        ///lpError: LPDWORD->DWORD*
        ///lpErrorBuf: LPWSTR->WCHAR*
        ///nErrorBufSize: DWORD->unsigned int
        ///lpNameBuf: LPWSTR->WCHAR*
        ///nNameBufSize: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetGetLastErrorW")]
        public static extern uint WNetGetLastErrorW(ref uint lpError, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpErrorBuf, uint nErrorBufSize, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpNameBuf, uint nNameBufSize);


        /// Return Type: DWORD->unsigned int
        ///lpError: LPDWORD->DWORD*
        ///lpErrorBuf: LPSTR->CHAR*
        ///nErrorBufSize: DWORD->unsigned int
        ///lpNameBuf: LPSTR->CHAR*
        ///nNameBufSize: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetGetLastErrorA")]
        public static extern uint WNetGetLastErrorA(ref uint lpError, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpErrorBuf, uint nErrorBufSize, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpNameBuf, uint nNameBufSize);


        /// Return Type: DWORD->unsigned int
        ///lpLocalName: LPCWSTR->WCHAR*
        ///lpRemoteName: LPWSTR->WCHAR*
        ///lpnLength: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetConnectionW")]
        public static extern uint WNetGetConnectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpLocalName, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpRemoteName, ref uint lpnLength);


        /// Return Type: DWORD->unsigned int
        ///lpLocalName: LPCSTR->CHAR*
        ///lpRemoteName: LPSTR->CHAR*
        ///lpnLength: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetGetConnectionA")]
        public static extern uint WNetGetConnectionA([In] [MarshalAs(UnmanagedType.LPStr)] string lpLocalName, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpRemoteName, ref uint lpnLength);


        /// Return Type: DWORD->unsigned int
        ///hEnum: HANDLE->void*
        ///lpcCount: LPDWORD->DWORD*
        ///lpBuffer: LPVOID->void*
        ///lpBufferSize: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetEnumResourceW")]
        public static extern uint WNetEnumResourceW(IntPtr hEnum, ref uint lpcCount, IntPtr lpBuffer, ref uint lpBufferSize);


        /// Return Type: DWORD->unsigned int
        ///hEnum: HANDLE->void*
        ///lpcCount: LPDWORD->DWORD*
        ///lpBuffer: LPVOID->void*
        ///lpBufferSize: LPDWORD->DWORD*
        [DllImport("mpr.dll", EntryPoint = "WNetEnumResourceA")]
        public static extern uint WNetEnumResourceA(IntPtr hEnum, ref uint lpcCount, IntPtr lpBuffer, ref uint lpBufferSize);


        /// Return Type: DWORD->unsigned int
        ///lpConnDlgStruct: LPDISCDLGSTRUCTW->_DISCDLGSTRUCTW*
        [DllImport("mpr.dll", EntryPoint = "WNetDisconnectDialog1W")]
        public static extern uint WNetDisconnectDialog1W(ref DISCDLGSTRUCTW lpConnDlgStruct);


        /// Return Type: DWORD->unsigned int
        ///lpConnDlgStruct: LPDISCDLGSTRUCTA->_DISCDLGSTRUCTA*
        [DllImport("mpr.dll", EntryPoint = "WNetDisconnectDialog1A")]
        public static extern uint WNetDisconnectDialog1A(ref DISCDLGSTRUCTA lpConnDlgStruct);


        /// Return Type: DWORD->unsigned int
        ///hwnd: HWND->HWND__*
        ///dwType: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetDisconnectDialog")]
        public static extern uint WNetDisconnectDialog(IntPtr hwnd, uint dwType);


        /// Return Type: DWORD->unsigned int
        ///lpConnDlgStruct: LPCONNECTDLGSTRUCTW->_CONNECTDLGSTRUCTW*
        [DllImport("mpr.dll", EntryPoint = "WNetConnectionDialog1W")]
        public static extern uint WNetConnectionDialog1W(ref CONNECTDLGSTRUCTW lpConnDlgStruct);


        /// Return Type: DWORD->unsigned int
        ///lpConnDlgStruct: LPCONNECTDLGSTRUCTA->_CONNECTDLGSTRUCTA*
        [DllImport("mpr.dll", EntryPoint = "WNetConnectionDialog1A")]
        public static extern uint WNetConnectionDialog1A(ref CONNECTDLGSTRUCTA lpConnDlgStruct);


        /// Return Type: DWORD->unsigned int
        ///hwnd: HWND->HWND__*
        ///dwType: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetConnectionDialog")]
        public static extern uint WNetConnectionDialog(IntPtr hwnd, uint dwType);


        /// Return Type: DWORD->unsigned int
        ///hEnum: HANDLE->void*
        [DllImport("mpr.dll", EntryPoint = "WNetCloseEnum")]
        public static extern uint WNetCloseEnum(IntPtr hEnum);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///fForce: BOOL->int
        [DllImport("mpr.dll", EntryPoint = "WNetCancelConnectionW")]
        public static extern uint WNetCancelConnectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [MarshalAs(UnmanagedType.Bool)] bool fForce);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        ///fForce: BOOL->int
        [DllImport("mpr.dll", EntryPoint = "WNetCancelConnectionA")]
        public static extern uint WNetCancelConnectionA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [MarshalAs(UnmanagedType.Bool)] bool fForce);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///fForce: BOOL->int
        [DllImport("mpr.dll", EntryPoint = "WNetCancelConnection2W")]
        public static extern uint WNetCancelConnection2W([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fForce);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///fForce: BOOL->int
        [DllImport("mpr.dll", EntryPoint = "WNetCancelConnection2A")]
        public static extern uint WNetCancelConnection2A([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fForce);


        /// Return Type: DWORD->unsigned int
        ///lpRemoteName: LPCWSTR->WCHAR*
        ///lpPassword: LPCWSTR->WCHAR*
        ///lpLocalName: LPCWSTR->WCHAR*
        [DllImport("mpr.dll", EntryPoint = "WNetAddConnectionW")]
        public static extern uint WNetAddConnectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpRemoteName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpLocalName);


        /// Return Type: DWORD->unsigned int
        ///lpRemoteName: LPCSTR->CHAR*
        ///lpPassword: LPCSTR->CHAR*
        ///lpLocalName: LPCSTR->CHAR*
        [DllImport("mpr.dll", EntryPoint = "WNetAddConnectionA")]
        public static extern uint WNetAddConnectionA([In] [MarshalAs(UnmanagedType.LPStr)] string lpRemoteName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPStr)] string lpLocalName);


        /// Return Type: DWORD->unsigned int
        ///hwndOwner: HWND->HWND__*
        ///lpNetResource: LPNETRESOURCEW->_NETRESOURCEW*
        ///lpPassword: LPCWSTR->WCHAR*
        ///lpUserName: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetAddConnection3W")]
        public static extern uint WNetAddConnection3W(IntPtr hwndOwner, ref NETRESOURCEW lpNetResource, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpUserName, uint dwFlags);


        /// Return Type: DWORD->unsigned int
        ///hwndOwner: HWND->HWND__*
        ///lpNetResource: LPNETRESOURCEA->_NETRESOURCEA*
        ///lpPassword: LPCSTR->CHAR*
        ///lpUserName: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetAddConnection3A")]
        public static extern uint WNetAddConnection3A(IntPtr hwndOwner, ref NETRESOURCEA lpNetResource, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPStr)] string lpUserName, uint dwFlags);


        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEW->_NETRESOURCEW*
        ///lpPassword: LPCWSTR->WCHAR*
        ///lpUserName: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetAddConnection2W")]
        public static extern uint WNetAddConnection2W(ref NETRESOURCEW lpNetResource, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpUserName, uint dwFlags);


        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEA->_NETRESOURCEA*
        ///lpPassword: LPCSTR->CHAR*
        ///lpUserName: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("mpr.dll", EntryPoint = "WNetAddConnection2A")]
        public static extern uint WNetAddConnection2A(ref NETRESOURCEA lpNetResource, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPStr)] string lpUserName, uint dwFlags);


        /// Return Type: int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///hPrevInstance: HINSTANCE->HINSTANCE__*
        ///lpCmdLine: LPSTR->CHAR*
        ///nShowCmd: int
        [DllImport("<Unknown>", EntryPoint = "WinMain")]
        public static extern int WinMain([In] IntPtr hInstance, [In] IntPtr hPrevInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCmdLine, int nShowCmd);


        /// Return Type: BOOL->int
        ///hWndMain: HWND->HWND__*
        ///lpszHelp: LPCWSTR->WCHAR*
        ///uCommand: UINT->unsigned int
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "WinHelpW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WinHelpW([In] IntPtr hWndMain, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszHelp, uint uCommand, uint dwData);


        /// Return Type: BOOL->int
        ///hWndMain: HWND->HWND__*
        ///lpszHelp: LPCSTR->CHAR*
        ///uCommand: UINT->unsigned int
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "WinHelpA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WinHelpA([In] IntPtr hWndMain, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszHelp, uint uCommand, uint dwData);


        /// Return Type: void
        ///hwnd: HWND->HWND__*
        ///error: int
        ///lpstrFileName: LPCWSTR->WCHAR*
        ///lpstrTitle: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "WinExecErrorW", CallingConvention = CallingConvention.StdCall)]
        public static extern void WinExecErrorW(IntPtr hwnd, int error, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpstrFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpstrTitle);


        /// Return Type: void
        ///hwnd: HWND->HWND__*
        ///error: int
        ///lpstrFileName: LPCSTR->CHAR*
        ///lpstrTitle: LPCSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "WinExecErrorA", CallingConvention = CallingConvention.StdCall)]
        public static extern void WinExecErrorA(IntPtr hwnd, int error, [In] [MarshalAs(UnmanagedType.LPStr)] string lpstrFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpstrTitle);


        /// Return Type: UINT->unsigned int
        ///lpCmdLine: LPCSTR->CHAR*
        ///uCmdShow: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WinExec")]
        public static extern uint WinExec([In] [MarshalAs(UnmanagedType.LPStr)] string lpCmdLine, uint uCmdShow);


        /// Return Type: HWND->HWND__*
        ///Point: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
        public static extern IntPtr WindowFromPoint(Point Point);


        /// Return Type: HWND->HWND__*
        ///hDC: HDC->HDC__*
        [DllImport("user32.dll", EntryPoint = "WindowFromDC")]
        public static extern IntPtr WindowFromDC([In] IntPtr hDC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "WidenPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WidenPath([In] IntPtr hdc);


        /// Return Type: int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpWideCharStr: LPCWSTR->WCHAR*
        ///cchWideChar: int
        ///lpMultiByteStr: LPSTR->CHAR*
        ///cbMultiByte: int
        ///lpDefaultChar: LPCSTR->CHAR*
        ///lpUsedDefaultChar: LPBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "WideCharToMultiByte")]
        public static extern int WideCharToMultiByte(uint CodePage, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, IntPtr lpMultiByteStr, int cbMultiByte, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDefaultChar, IntPtr lpUsedDefaultChar);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: DWORD->unsigned int
        ///param2: DWORD->unsigned int
        ///param3: DWORD->unsigned int
        ///param4: FLOAT->float
        ///param5: FLOAT->float
        ///param6: int
        ///param7: LPGLYPHMETRICSFLOAT->_GLYPHMETRICSFLOAT*
        [DllImport("opengl32.dll", EntryPoint = "wglUseFontOutlinesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglUseFontOutlinesW(IntPtr param0, uint param1, uint param2, uint param3, float param4, float param5, int param6, ref GLYPHMETRICSFLOAT param7);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: DWORD->unsigned int
        ///param2: DWORD->unsigned int
        ///param3: DWORD->unsigned int
        ///param4: FLOAT->float
        ///param5: FLOAT->float
        ///param6: int
        ///param7: LPGLYPHMETRICSFLOAT->_GLYPHMETRICSFLOAT*
        [DllImport("opengl32.dll", EntryPoint = "wglUseFontOutlinesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglUseFontOutlinesA(IntPtr param0, uint param1, uint param2, uint param3, float param4, float param5, int param6, ref GLYPHMETRICSFLOAT param7);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: DWORD->unsigned int
        ///param2: DWORD->unsigned int
        ///param3: DWORD->unsigned int
        [DllImport("opengl32.dll", EntryPoint = "wglUseFontBitmapsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglUseFontBitmapsW(IntPtr param0, uint param1, uint param2, uint param3);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: DWORD->unsigned int
        ///param2: DWORD->unsigned int
        ///param3: DWORD->unsigned int
        [DllImport("opengl32.dll", EntryPoint = "wglUseFontBitmapsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglUseFontBitmapsA(IntPtr param0, uint param1, uint param2, uint param3);


        /// Return Type: DWORD->unsigned int
        ///param0: UINT->unsigned int
        ///param1: WGLSWAP*
        [DllImport("opengl32.dll", EntryPoint = "wglSwapMultipleBuffers")]
        public static extern uint wglSwapMultipleBuffers(uint param0, ref WGLSWAP param1);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: UINT->unsigned int
        [DllImport("opengl32.dll", EntryPoint = "wglSwapLayerBuffers")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglSwapLayerBuffers(IntPtr param0, uint param1);


        /// Return Type: BOOL->int
        ///param0: HGLRC->HGLRC__*
        ///param1: HGLRC->HGLRC__*
        [DllImport("opengl32.dll", EntryPoint = "wglShareLists")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglShareLists(IntPtr param0, IntPtr param1);


        /// Return Type: int
        ///param0: HDC->HDC__*
        ///param1: int
        ///param2: int
        ///param3: int
        ///param4: COLORREF*
        [DllImport("opengl32.dll", EntryPoint = "wglSetLayerPaletteEntries")]
        public static extern int wglSetLayerPaletteEntries(IntPtr param0, int param1, int param2, int param3, ref uint param4);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: int
        ///param2: BOOL->int
        [DllImport("opengl32.dll", EntryPoint = "wglRealizeLayerPalette")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglRealizeLayerPalette(IntPtr param0, int param1, [MarshalAs(UnmanagedType.Bool)] bool param2);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: HGLRC->HGLRC__*
        [DllImport("opengl32.dll", EntryPoint = "wglMakeCurrent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglMakeCurrent(IntPtr param0, IntPtr param1);


        /// Return Type: PROC
        ///param0: LPCSTR->CHAR*
        [DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress")]
        public static extern PROC wglGetProcAddress([In] [MarshalAs(UnmanagedType.LPStr)] string param0);


        /// Return Type: int
        ///param0: HDC->HDC__*
        ///param1: int
        ///param2: int
        ///param3: int
        ///param4: COLORREF*
        [DllImport("opengl32.dll", EntryPoint = "wglGetLayerPaletteEntries")]
        public static extern int wglGetLayerPaletteEntries(IntPtr param0, int param1, int param2, int param3, ref uint param4);


        /// Return Type: HDC->HDC__*
        [DllImport("opengl32.dll", EntryPoint = "wglGetCurrentDC")]
        public static extern IntPtr wglGetCurrentDC();


        /// Return Type: HGLRC->HGLRC__*
        [DllImport("opengl32.dll", EntryPoint = "wglGetCurrentContext")]
        public static extern IntPtr wglGetCurrentContext();


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: int
        ///param2: int
        ///param3: UINT->unsigned int
        ///param4: LPLAYERPLANEDESCRIPTOR->tagLAYERPLANEDESCRIPTOR*
        [DllImport("opengl32.dll", EntryPoint = "wglDescribeLayerPlane")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglDescribeLayerPlane(IntPtr param0, int param1, int param2, uint param3, ref tagLAYERPLANEDESCRIPTOR param4);


        /// Return Type: BOOL->int
        ///param0: HGLRC->HGLRC__*
        [DllImport("opengl32.dll", EntryPoint = "wglDeleteContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglDeleteContext(IntPtr param0);


        /// Return Type: HGLRC->HGLRC__*
        ///param0: HDC->HDC__*
        ///param1: int
        [DllImport("opengl32.dll", EntryPoint = "wglCreateLayerContext")]
        public static extern IntPtr wglCreateLayerContext(IntPtr param0, int param1);


        /// Return Type: HGLRC->HGLRC__*
        ///param0: HDC->HDC__*
        [DllImport("opengl32.dll", EntryPoint = "wglCreateContext")]
        public static extern IntPtr wglCreateContext(IntPtr param0);


        /// Return Type: BOOL->int
        ///param0: HGLRC->HGLRC__*
        ///param1: HGLRC->HGLRC__*
        ///param2: UINT->unsigned int
        [DllImport("opengl32.dll", EntryPoint = "wglCopyContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglCopyContext(IntPtr param0, IntPtr param1, uint param2);


        /// Return Type: errno_t->int
        ///_SizeConverted: int*
        ///_MbCh: char*
        ///_SizeInBytes: rsize_t->size_t->unsigned int
        ///_WCh: wchar_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "wctomb_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wctomb_s(IntPtr _SizeConverted, IntPtr _MbCh, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInBytes, char _WCh);


        /// Return Type: int
        ///_MbCh: char*
        ///_WCh: wchar_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "wctomb", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wctomb(IntPtr _MbCh, char _WCh);


        /// Return Type: size_t->unsigned int
        ///_Dst: wchar_t*
        ///_Src: wchar_t*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "wcsxfrm", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint wcsxfrm([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dst, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: unsigned int
        ///_Str: wchar_t*
        ///_EndPtr: wchar_t**
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "wcstoul", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint wcstoul([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, ref IntPtr _EndPtr, int _Radix);


        /// Return Type: errno_t->int
        ///_PtNumOfCharConverted: size_t*
        ///_Dst: char*
        ///_DstSizeInBytes: size_t->unsigned int
        ///_Src: wchar_t*
        ///_MaxCountInBytes: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "wcstombs_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcstombs_s(IntPtr _PtNumOfCharConverted, IntPtr _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSizeInBytes, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCountInBytes);


        /// Return Type: size_t->unsigned int
        ///_Dest: char*
        ///_Source: wchar_t*
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "wcstombs", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint wcstombs([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dest, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_Str: wchar_t*
        ///_EndPtr: wchar_t**
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "wcstol", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcstol([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, ref IntPtr _EndPtr, int _Radix);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_Delim: wchar_t*
        ///_Context: wchar_t**
        [DllImport("msvcr80.dll", EntryPoint = "wcstok_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcstok_s(IntPtr _Str, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Delim, ref IntPtr _Context);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_Delim: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "wcstok", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcstok(IntPtr _Str, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Delim);


        /// Return Type: double
        ///_Str: wchar_t*
        ///_EndPtr: wchar_t**
        [DllImport("msvcr80.dll", EntryPoint = "wcstod", CallingConvention = CallingConvention.Cdecl)]
        public static extern double wcstod([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, ref IntPtr _EndPtr);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_SubStr: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcsstr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcsstr([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPWStr)] string _SubStr);


        /// Return Type: size_t->unsigned int
        ///_Str: wchar_t*
        ///_Control: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcsspn", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint wcsspn([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Control);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_Ch: wchar_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "wcsrchr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcsrchr([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, char _Ch);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_Control: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcspbrk", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcspbrk([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Control);


        /// Return Type: size_t->unsigned int
        ///_Src: wchar_t*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "wcsnlen", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint wcsnlen([In] [MarshalAs(UnmanagedType.LPWStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: errno_t->int
        ///_Dst: wchar_t*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: wchar_t*
        ///_MaxCount: rsize_t->size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "wcsncpy_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcsncpy_s([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: wchar_t*
        ///_Dest: wchar_t*
        ///_Source: wchar_t*
        ///_Count: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "wcsncpy", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcsncpy([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dest, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "wcsncmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcsncmp([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: errno_t->int
        ///_Dst: wchar_t*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: wchar_t*
        ///_MaxCount: rsize_t->size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "wcsncat_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcsncat_s([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: wchar_t*
        ///_Dest: wchar_t*
        ///_Source: wchar_t*
        ///_Count: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "wcsncat", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcsncat(IntPtr _Dest, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count);


        /// Return Type: size_t->unsigned int
        ///_Str: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcslen", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint wcslen([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str);


        /// Return Type: size_t->unsigned int
        ///_Str: wchar_t*
        ///_Control: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcscspn", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint wcscspn([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Control);


        /// Return Type: errno_t->int
        ///_Dst: wchar_t*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "wcscpy_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcscpy_s([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src);


        /// Return Type: wchar_t*
        ///_Dest: wchar_t*
        ///_Source: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcscpy", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcscpy(IntPtr _Dest, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Source);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "wcscoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcscoll([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcscmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcscmp([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_Ch: wchar_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "wcschr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcschr([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, char _Ch);


        /// Return Type: errno_t->int
        ///_Dst: wchar_t*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "wcscat_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int wcscat_s([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src);


        /// Return Type: wchar_t*
        ///_Dest: wchar_t*
        ///_Source: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "wcscat", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wcscat(IntPtr _Dest, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Source);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///pwh: LPWAVEHDR->wavehdr_tag*
        ///cbwh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutWrite")]
        public static extern uint waveOutWrite(IntPtr hwo, ref wavehdr_tag pwh, uint cbwh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///pwh: LPWAVEHDR->wavehdr_tag*
        ///cbwh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutUnprepareHeader")]
        public static extern uint waveOutUnprepareHeader(IntPtr hwo, ref wavehdr_tag pwh, uint cbwh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///dwVolume: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume")]
        public static extern uint waveOutSetVolume(IntPtr hwo, uint dwVolume);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///dwRate: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutSetPlaybackRate")]
        public static extern uint waveOutSetPlaybackRate(IntPtr hwo, uint dwRate);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///dwPitch: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutSetPitch")]
        public static extern uint waveOutSetPitch(IntPtr hwo, uint dwPitch);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        [DllImport("winmm.dll", EntryPoint = "waveOutRestart")]
        public static extern uint waveOutRestart(IntPtr hwo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        [DllImport("winmm.dll", EntryPoint = "waveOutReset")]
        public static extern uint waveOutReset(IntPtr hwo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///pwh: LPWAVEHDR->wavehdr_tag*
        ///cbwh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutPrepareHeader")]
        public static extern uint waveOutPrepareHeader(IntPtr hwo, ref wavehdr_tag pwh, uint cbwh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        [DllImport("winmm.dll", EntryPoint = "waveOutPause")]
        public static extern uint waveOutPause(IntPtr hwo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///phwo: LPHWAVEOUT->HWAVEOUT*
        ///uDeviceID: UINT->unsigned int
        ///pwfx: LPCWAVEFORMATEX->WAVEFORMATEX*
        ///dwCallback: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwInstance: DWORD_PTR->ULONG_PTR->unsigned int
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutOpen")]
        public static extern uint waveOutOpen(ref IntPtr phwo, uint uDeviceID, ref tWAVEFORMATEX pwfx, uint dwCallback, uint dwInstance, uint fdwOpen);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///uMsg: UINT->unsigned int
        ///dw1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dw2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutMessage")]
        public static extern uint waveOutMessage(IntPtr hwo, uint uMsg, uint dw1, uint dw2);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///pdwVolume: LPDWORD->DWORD*
        [DllImport("winmm.dll", EntryPoint = "waveOutGetVolume")]
        public static extern uint waveOutGetVolume(IntPtr hwo, ref uint pdwVolume);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///pmmt: LPMMTIME->mmtime_tag*
        ///cbmmt: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutGetPosition")]
        public static extern uint waveOutGetPosition(IntPtr hwo, ref mmtime_tag pmmt, uint cbmmt);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///pdwRate: LPDWORD->DWORD*
        [DllImport("winmm.dll", EntryPoint = "waveOutGetPlaybackRate")]
        public static extern uint waveOutGetPlaybackRate(IntPtr hwo, ref uint pdwRate);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///pdwPitch: LPDWORD->DWORD*
        [DllImport("winmm.dll", EntryPoint = "waveOutGetPitch")]
        public static extern uint waveOutGetPitch(IntPtr hwo, ref uint pdwPitch);


        /// Return Type: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutGetNumDevs")]
        public static extern uint waveOutGetNumDevs();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        ///puDeviceID: LPUINT->UINT*
        [DllImport("winmm.dll", EntryPoint = "waveOutGetID")]
        public static extern uint waveOutGetID(IntPtr hwo, ref uint puDeviceID);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPWSTR->WCHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutGetErrorTextW")]
        public static extern uint waveOutGetErrorTextW(uint mmrError, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPSTR->CHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutGetErrorTextA")]
        public static extern uint waveOutGetErrorTextA(uint mmrError, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pwoc: LPWAVEOUTCAPSW->tagWAVEOUTCAPSW*
        ///cbwoc: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutGetDevCapsW")]
        public static extern uint waveOutGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagWAVEOUTCAPSW pwoc, uint cbwoc);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pwoc: LPWAVEOUTCAPSA->tagWAVEOUTCAPSA*
        ///cbwoc: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveOutGetDevCapsA")]
        public static extern uint waveOutGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagWAVEOUTCAPSA pwoc, uint cbwoc);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        [DllImport("winmm.dll", EntryPoint = "waveOutClose")]
        public static extern uint waveOutClose(IntPtr hwo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwo: HWAVEOUT->HWAVEOUT__*
        [DllImport("winmm.dll", EntryPoint = "waveOutBreakLoop")]
        public static extern uint waveOutBreakLoop(IntPtr hwo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        ///pwh: LPWAVEHDR->wavehdr_tag*
        ///cbwh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInUnprepareHeader")]
        public static extern uint waveInUnprepareHeader(IntPtr hwi, ref wavehdr_tag pwh, uint cbwh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        [DllImport("winmm.dll", EntryPoint = "waveInStop")]
        public static extern uint waveInStop(IntPtr hwi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        [DllImport("winmm.dll", EntryPoint = "waveInStart")]
        public static extern uint waveInStart(IntPtr hwi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        [DllImport("winmm.dll", EntryPoint = "waveInReset")]
        public static extern uint waveInReset(IntPtr hwi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        ///pwh: LPWAVEHDR->wavehdr_tag*
        ///cbwh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInPrepareHeader")]
        public static extern uint waveInPrepareHeader(IntPtr hwi, ref wavehdr_tag pwh, uint cbwh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///phwi: LPHWAVEIN->HWAVEIN*
        ///uDeviceID: UINT->unsigned int
        ///pwfx: LPCWAVEFORMATEX->WAVEFORMATEX*
        ///dwCallback: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwInstance: DWORD_PTR->ULONG_PTR->unsigned int
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInOpen")]
        public static extern uint waveInOpen(ref IntPtr phwi, uint uDeviceID, ref tWAVEFORMATEX pwfx, uint dwCallback, uint dwInstance, uint fdwOpen);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        ///uMsg: UINT->unsigned int
        ///dw1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dw2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInMessage")]
        public static extern uint waveInMessage(IntPtr hwi, uint uMsg, uint dw1, uint dw2);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        ///pmmt: LPMMTIME->mmtime_tag*
        ///cbmmt: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInGetPosition")]
        public static extern uint waveInGetPosition(IntPtr hwi, ref mmtime_tag pmmt, uint cbmmt);


        /// Return Type: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInGetNumDevs")]
        public static extern uint waveInGetNumDevs();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        ///puDeviceID: LPUINT->UINT*
        [DllImport("winmm.dll", EntryPoint = "waveInGetID")]
        public static extern uint waveInGetID(IntPtr hwi, ref uint puDeviceID);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPWSTR->WCHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInGetErrorTextW")]
        public static extern uint waveInGetErrorTextW(uint mmrError, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPSTR->CHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInGetErrorTextA")]
        public static extern uint waveInGetErrorTextA(uint mmrError, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pwic: LPWAVEINCAPSW->tagWAVEINCAPSW*
        ///cbwic: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInGetDevCapsW")]
        public static extern uint waveInGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagWAVEINCAPSW pwic, uint cbwic);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pwic: LPWAVEINCAPSA->tagWAVEINCAPSA*
        ///cbwic: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInGetDevCapsA")]
        public static extern uint waveInGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagWAVEINCAPSA pwic, uint cbwic);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        [DllImport("winmm.dll", EntryPoint = "waveInClose")]
        public static extern uint waveInClose(IntPtr hwi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hwi: HWAVEIN->HWAVEIN__*
        ///pwh: LPWAVEHDR->wavehdr_tag*
        ///cbwh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "waveInAddBuffer")]
        public static extern uint waveInAddBuffer(IntPtr hwi, ref wavehdr_tag pwh, uint cbwh);


        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCWSTR->WCHAR*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitNamedPipeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, uint nTimeOut);


        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCSTR->CHAR*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitNamedPipeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitNamedPipeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpNamedPipeName, uint nTimeOut);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "WaitMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitMessage();


        /// Return Type: DWORD->unsigned int
        ///hHandle: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "WaitForSingleObjectEx")]
        public static extern uint WaitForSingleObjectEx([In] IntPtr hHandle, uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);


        /// Return Type: DWORD->unsigned int
        ///hHandle: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitForSingleObject")]
        public static extern uint WaitForSingleObject([In] IntPtr hHandle, uint dwMilliseconds);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///Flags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "WaitForPrinterChange")]
        public static extern uint WaitForPrinterChange([In] IntPtr hPrinter, uint Flags);


        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///lpHandles: HANDLE*
        ///bWaitAll: BOOL->int
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "WaitForMultipleObjectsEx")]
        public static extern uint WaitForMultipleObjectsEx(uint nCount, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 0)] IntPtr[] lpHandles, [MarshalAs(UnmanagedType.Bool)] bool bWaitAll, uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);


        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///lpHandles: HANDLE*
        ///bWaitAll: BOOL->int
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitForMultipleObjects")]
        public static extern uint WaitForMultipleObjects(uint nCount, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 0)] IntPtr[] lpHandles, [MarshalAs(UnmanagedType.Bool)] bool bWaitAll, uint dwMilliseconds);


        /// Return Type: DWORD->unsigned int
        ///hProcess: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "WaitForInputIdle")]
        public static extern uint WaitForInputIdle([In] IntPtr hProcess, uint dwMilliseconds);


        /// Return Type: BOOL->int
        ///lpDebugEvent: LPDEBUG_EVENT->_DEBUG_EVENT*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WaitForDebugEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitForDebugEvent([In] ref DEBUG_EVENT lpDebugEvent, uint dwMilliseconds);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpEvtMask: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "WaitCommEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitCommEvent([In] IntPtr hFile, ref uint lpEvtMask, IntPtr lpOverlapped);

    }

}
