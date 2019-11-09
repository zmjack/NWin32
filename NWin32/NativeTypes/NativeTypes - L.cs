using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPSETUPHOOKPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: void
    ///dwNumServicesArgs: DWORD->unsigned int
    ///lpServiceArgVectors: LPWSTR*
    public delegate void LPSERVICE_MAIN_FUNCTIONW(uint dwNumServicesArgs, ref IntPtr lpServiceArgVectors);

    /// Return Type: void
    ///dwNumServicesArgs: DWORD->unsigned int
    ///lpServiceArgVectors: LPSTR*
    public delegate void LPSERVICE_MAIN_FUNCTIONA(uint dwNumServicesArgs, ref IntPtr lpServiceArgVectors);

    /// Return Type: DWORD->unsigned int
    ///TotalFileSize: LARGE_INTEGER->_LARGE_INTEGER
    ///TotalBytesTransferred: LARGE_INTEGER->_LARGE_INTEGER
    ///StreamSize: LARGE_INTEGER->_LARGE_INTEGER
    ///StreamBytesTransferred: LARGE_INTEGER->_LARGE_INTEGER
    ///dwStreamNumber: DWORD->unsigned int
    ///dwCallbackReason: DWORD->unsigned int
    ///hSourceFile: HANDLE->void*
    ///hDestinationFile: HANDLE->void*
    ///lpData: LPVOID->void*
    public delegate uint LPPROGRESS_ROUTINE(LARGE_INTEGER TotalFileSize, LARGE_INTEGER TotalBytesTransferred, LARGE_INTEGER StreamSize, LARGE_INTEGER StreamBytesTransferred, uint dwStreamNumber, uint dwCallbackReason, [In] IntPtr hSourceFile, [In] IntPtr hDestinationFile, [In] IntPtr lpData);

    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPPRINTHOOKPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPPAGESETUPHOOK(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPPAGEPAINTHOOK(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: void
    ///dwErrorCode: DWORD->unsigned int
    ///dwNumberOfBytesTransfered: DWORD->unsigned int
    ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
    public delegate void LPOVERLAPPED_COMPLETION_ROUTINE(uint dwErrorCode, uint dwNumberOfBytesTransfered, ref OVERLAPPED lpOverlapped);

    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPOFNHOOKPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: void
    ///param0: SCARDCONTEXT->ULONG_PTR->unsigned int
    ///param1: SCARDHANDLE->ULONG_PTR->unsigned int
    ///param2: PVOID->void*
    public delegate void LPOCNDSCPROC(uint param0, uint param1, IntPtr param2);

    /// Return Type: SCARDHANDLE->ULONG_PTR->unsigned int
    ///param0: SCARDCONTEXT->ULONG_PTR->unsigned int
    ///param1: LPWSTR->WCHAR*
    ///param2: LPWSTR->WCHAR*
    ///param3: PVOID->void*
    public delegate uint LPOCNCONNPROCW(uint param0, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param1, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param2, IntPtr param3);

    /// Return Type: SCARDHANDLE->ULONG_PTR->unsigned int
    ///param0: SCARDCONTEXT->ULONG_PTR->unsigned int
    ///param1: LPSTR->CHAR*
    ///param2: LPSTR->CHAR*
    ///param3: PVOID->void*
    public delegate uint LPOCNCONNPROCA(uint param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: SCARDCONTEXT->ULONG_PTR->unsigned int
    ///param1: SCARDHANDLE->ULONG_PTR->unsigned int
    ///param2: PVOID->void*
    public delegate int LPOCNCHKPROC(uint param0, uint param1, IntPtr param2);

    /// Return Type: DWORD->unsigned int
    ///dwControl: DWORD->unsigned int
    ///dwEventType: DWORD->unsigned int
    ///lpEventData: LPVOID->void*
    ///lpContext: LPVOID->void*
    public delegate uint LPHANDLER_FUNCTION_EX(uint dwControl, uint dwEventType, IntPtr lpEventData, IntPtr lpContext);

    /// Return Type: void
    ///dwControl: DWORD->unsigned int
    public delegate void LPHANDLER_FUNCTION(uint dwControl);

    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPFRHOOKPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: UINT->unsigned int
    ///hwnd: HWND->HWND__*
    ///uMsg: UINT->unsigned int
    ///ppsp: _PROPSHEETPAGEW*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPFNPSPCALLBACKW(IntPtr hwnd, uint uMsg, ref PROPSHEETPAGEW_V3 ppsp);

    /// Return Type: UINT->unsigned int
    ///hwnd: HWND->HWND__*
    ///uMsg: UINT->unsigned int
    ///ppsp: _PROPSHEETPAGEA*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPFNPSPCALLBACKA(IntPtr hwnd, uint uMsg, ref PROPSHEETPAGEA_V3 ppsp);

    /// Return Type: HRESULT->LONG->int
    ///param0: IID*
    ///param1: IID*
    ///param2: LPVOID*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LPFNGETCLASSOBJECT(ref GUID param0, ref GUID param1, ref IntPtr param2);

    /// Return Type: UINT->unsigned int
    ///param0: HWND->HWND__*
    ///param1: HMODULE->HINSTANCE->HINSTANCE__*
    ///param2: LPDEVMODE->LPDEVMODEW->_devicemodeW*
    ///param3: LPSTR->CHAR*
    ///param4: LPSTR->CHAR*
    ///param5: LPDEVMODE->LPDEVMODEW->_devicemodeW*
    ///param6: LPSTR->CHAR*
    ///param7: UINT->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPFNDEVMODE(IntPtr param0, IntPtr param1, ref DEVMODEW param2, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param3, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param4, ref DEVMODEW param5, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param6, uint param7);

    /// Return Type: DWORD->unsigned int
    ///param0: LPSTR->CHAR*
    ///param1: LPSTR->CHAR*
    ///param2: UINT->unsigned int
    ///param3: LPSTR->CHAR*
    ///param4: LPDEVMODE->LPDEVMODEW->_devicemodeW*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPFNDEVCAPS([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, uint param2, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param3, ref DEVMODEW param4);

    /// Return Type: HRESULT->LONG->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LPFNCANUNLOADNOW();

    /// Return Type: BOOL->int
    ///param0: LPVOID->void*
    ///param1: LPFNADDPROPSHEETPAGE
    ///param2: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LPFNADDPROPSHEETPAGES(IntPtr param0, LPFNADDPROPSHEETPAGE param1, IntPtr param2);

    /// Return Type: BOOL->int
    ///param0: HPROPSHEETPAGE->_PSP*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LPFNADDPROPSHEETPAGE(IntPtr param0, IntPtr param1);

    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPCFHOOKPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LPCCHOOKPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LOCALE_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LOCALE_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct localeinfo_struct
    {

        /// pthreadlocinfo->threadlocaleinfostruct*
        public IntPtr locinfo;

        /// pthreadmbcinfo->threadmbcinfostruct*
        public IntPtr mbcinfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LIST_ENTRY64
    {

        /// ULONGLONG->unsigned __int64
        public ulong Flink;

        /// ULONGLONG->unsigned __int64
        public ulong Blink;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LIST_ENTRY32
    {

        /// DWORD->unsigned int
        public uint Flink;

        /// DWORD->unsigned int
        public uint Blink;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct linger
    {

        /// u_short->unsigned short
        public ushort l_onoff;

        /// u_short->unsigned short
        public ushort l_linger;
    }

    /// Return Type: void
    ///param0: int
    ///param1: int
    ///param2: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void LINEDDAPROC(int param0, int param1, IntPtr param2);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LPWSTR->WCHAR*
    ///param2: LPWSTR->WCHAR*
    ///param3: DWORD->unsigned int
    ///param4: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGUAGEGROUP_ENUMPROCW(uint param0, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param1, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param2, uint param3, IntPtr param4);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LPSTR->CHAR*
    ///param2: LPSTR->CHAR*
    ///param3: DWORD->unsigned int
    ///param4: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGUAGEGROUP_ENUMPROCA(uint param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param2, uint param3, IntPtr param4);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LCID->DWORD->unsigned int
    ///param2: LPWSTR->WCHAR*
    ///param3: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGGROUPLOCALE_ENUMPROCW(uint param0, uint param1, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: LGRPID->DWORD->unsigned int
    ///param1: LCID->DWORD->unsigned int
    ///param2: LPSTR->CHAR*
    ///param3: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int LANGGROUPLOCALE_ENUMPROCA(uint param0, uint param1, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param2, IntPtr param3);

    [StructLayout(LayoutKind.Sequential)]
    public struct LUID_AND_ATTRIBUTES
    {

        /// LUID->_LUID
        public LUID Luid;

        /// DWORD->unsigned int
        public uint Attributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LUID
    {

        /// DWORD->unsigned int
        public uint LowPart;

        /// LONG->int
        public int HighPart;
    }

    public enum LOGICAL_PROCESSOR_RELATIONSHIP
    {

        RelationProcessorCore,

        RelationNumaNode,

        RelationCache,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LOAD_DLL_DEBUG_INFO
    {

        /// HANDLE->void*
        public IntPtr hFile;

        /// LPVOID->void*
        public IntPtr lpBaseOfDll;

        /// DWORD->unsigned int
        public uint dwDebugInfoFileOffset;

        /// DWORD->unsigned int
        public uint nDebugInfoSize;

        /// LPVOID->void*
        public IntPtr lpImageName;

        /// WORD->unsigned short
        public ushort fUnicode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LIST_ENTRY
    {

        /// _LIST_ENTRY*
        public IntPtr Flink;

        /// _LIST_ENTRY*
        public IntPtr Blink;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LDT_ENTRY
    {

        /// WORD->unsigned short
        public ushort LimitLow;

        /// WORD->unsigned short
        public ushort BaseLow;

        /// Anonymous_6ec22b34_e8ab_46f2_a900_b8a44fc9e55d
        public Anonymous_6ec22b34_e8ab_46f2_a900_b8a44fc9e55d HighWord;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ldiv_t
    {

        /// int
        public int quot;

        /// int
        public int rem;
    }

    public enum LATENCY_TIME
    {

        LT_DONT_CARE,

        LT_LOWEST_LATENCY,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LARGE_INTEGER
    {

        /// Anonymous_9320654f_2227_43bf_a385_74cc8c562686
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_9320654f_2227_43bf_a385_74cc8c562686 Struct1;

        /// Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9 u;

        /// LONGLONG->__int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long QuadPart;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LANA_ENUM
    {

        /// UCHAR->unsigned char
        public byte length;

        /// UCHAR[255]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
        public string lana;
    }

}
