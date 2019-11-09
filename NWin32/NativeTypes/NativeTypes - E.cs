using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: void
    ///param0: _MIDL_STUB_MESSAGE*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void EXPR_EVAL(ref MIDL_STUB_MESSAGE param0);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPWSTR->WCHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESTYPEPROCW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPSTR->CHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESTYPEPROCA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCWSTR->WCHAR*
    ///lpName: LPWSTR->WCHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESNAMEPROCW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCSTR->CHAR*
    ///lpName: LPSTR->CHAR*
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESNAMEPROCA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCWSTR->WCHAR*
    ///lpName: LPCWSTR->WCHAR*
    ///wLanguage: WORD->unsigned short
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESLANGPROCW([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, ushort wLanguage, [In] IntPtr lParam);

    /// Return Type: BOOL->int
    ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
    ///lpType: LPCSTR->CHAR*
    ///lpName: LPCSTR->CHAR*
    ///wLanguage: WORD->unsigned short
    ///lParam: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENUMRESLANGPROCA([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, ushort wLanguage, [In] IntPtr lParam);

    /// Return Type: int
    ///hdc: HDC->HDC__*
    ///lpht: HANDLETABLE*
    ///lpmr: ENHMETARECORD*
    ///hHandles: int
    ///data: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ENHMFENUMPROC([In] IntPtr hdc, [In] IntPtr lpht, [In] ref tagENHMETARECORD lpmr, int hHandles, [In] IntPtr data);

    /// Return Type: int
    ///lpch: LPWSTR->WCHAR*
    ///ichCurrent: int
    ///cch: int
    ///code: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int EDITWORDBREAKPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpch, int ichCurrent, int cch, int code);

    /// Return Type: int
    ///lpch: LPSTR->CHAR*
    ///ichCurrent: int
    ///cch: int
    ///code: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int EDITWORDBREAKPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpch, int ichCurrent, int cch, int code);

    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_THREAD_DEBUG_INFO
    {

        /// DWORD->unsigned int
        public uint dwExitCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_PROCESS_DEBUG_INFO
    {

        /// DWORD->unsigned int
        public uint dwExitCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_RECORD64
    {

        /// DWORD->unsigned int
        public uint ExceptionCode;

        /// DWORD->unsigned int
        public uint ExceptionFlags;

        /// DWORD64->unsigned __int64
        public ulong ExceptionRecord;

        /// DWORD64->unsigned __int64
        public ulong ExceptionAddress;

        /// DWORD->unsigned int
        public uint NumberParameters;

        /// DWORD->unsigned int
        public uint @__unusedAlignment;

        /// DWORD64[15]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U8)]
        public ulong[] ExceptionInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_RECORD32
    {

        /// DWORD->unsigned int
        public uint ExceptionCode;

        /// DWORD->unsigned int
        public uint ExceptionFlags;

        /// DWORD->unsigned int
        public uint ExceptionRecord;

        /// DWORD->unsigned int
        public uint ExceptionAddress;

        /// DWORD->unsigned int
        public uint NumberParameters;

        /// DWORD[15]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U4)]
        public uint[] ExceptionInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_RECORD
    {

        /// DWORD->unsigned int
        public uint ExceptionCode;

        /// DWORD->unsigned int
        public uint ExceptionFlags;

        /// _EXCEPTION_RECORD*
        public IntPtr ExceptionRecord;

        /// PVOID->void*
        public IntPtr ExceptionAddress;

        /// DWORD->unsigned int
        public uint NumberParameters;

        /// ULONG_PTR[15]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U4)]
        public uint[] ExceptionInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_POINTERS
    {

        /// PEXCEPTION_RECORD->EXCEPTION_RECORD*
        public IntPtr ExceptionRecord;

        /// PCONTEXT->CONTEXT*
        public IntPtr ContextRecord;
    }

    public enum EXCEPTION_DISPOSITION
    {

        ExceptionContinueExecution,

        ExceptionContinueSearch,

        ExceptionNestedException,

        ExceptionCollidedUnwind,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_DEBUG_INFO
    {

        /// EXCEPTION_RECORD->_EXCEPTION_RECORD
        public EXCEPTION_RECORD ExceptionRecord;

        /// DWORD->unsigned int
        public uint dwFirstChance;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct EVENTSFORLOGFILE
    {

        /// DWORD->unsigned int
        public uint ulSize;

        /// WCHAR[256]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string szLogicalLogFile;

        /// DWORD->unsigned int
        public uint ulNumRecords;

        /// EVENTLOGRECORD[]
        public EVENTLOGRECORD[] pEventLogRecords;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EVENTLOG_FULL_INFORMATION
    {

        /// DWORD->unsigned int
        public uint dwFull;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EVENTLOGRECORD
    {

        /// DWORD->unsigned int
        public uint Length;

        /// DWORD->unsigned int
        public uint Reserved;

        /// DWORD->unsigned int
        public uint RecordNumber;

        /// DWORD->unsigned int
        public uint TimeGenerated;

        /// DWORD->unsigned int
        public uint TimeWritten;

        /// DWORD->unsigned int
        public uint EventID;

        /// WORD->unsigned short
        public ushort EventType;

        /// WORD->unsigned short
        public ushort NumStrings;

        /// WORD->unsigned short
        public ushort EventCategory;

        /// WORD->unsigned short
        public ushort ReservedFlags;

        /// DWORD->unsigned int
        public uint ClosingRecordNumber;

        /// DWORD->unsigned int
        public uint StringOffset;

        /// DWORD->unsigned int
        public uint UserSidLength;

        /// DWORD->unsigned int
        public uint UserSidOffset;

        /// DWORD->unsigned int
        public uint DataLength;

        /// DWORD->unsigned int
        public uint DataOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENUM_SERVICE_STATUS_PROCESSW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpServiceName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDisplayName;

        /// SERVICE_STATUS_PROCESS->_SERVICE_STATUS_PROCESS
        public SERVICE_STATUS_PROCESS ServiceStatusProcess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENUM_SERVICE_STATUS_PROCESSA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpServiceName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDisplayName;

        /// SERVICE_STATUS_PROCESS->_SERVICE_STATUS_PROCESS
        public SERVICE_STATUS_PROCESS ServiceStatusProcess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENUM_SERVICE_STATUSW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpServiceName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDisplayName;

        /// SERVICE_STATUS->_SERVICE_STATUS
        public SERVICE_STATUS ServiceStatus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENUM_SERVICE_STATUSA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpServiceName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDisplayName;

        /// SERVICE_STATUS->_SERVICE_STATUS
        public SERVICE_STATUS ServiceStatus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENCRYPTION_CERTIFICATE_LIST
    {

        /// DWORD->unsigned int
        public uint nUsers;

        /// PENCRYPTION_CERTIFICATE*
        public IntPtr pUsers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENCRYPTION_CERTIFICATE_HASH_LIST
    {

        /// DWORD->unsigned int
        public uint nCert_Hash;

        /// PENCRYPTION_CERTIFICATE_HASH*
        public IntPtr pUsers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENCRYPTION_CERTIFICATE_HASH
    {

        /// DWORD->unsigned int
        public uint cbTotalLength;

        /// SID*
        public IntPtr pUserSid;

        /// PEFS_HASH_BLOB->_EFS_HASH_BLOB*
        public IntPtr pHash;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDisplayInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENCRYPTION_CERTIFICATE
    {

        /// DWORD->unsigned int
        public uint cbTotalLength;

        /// SID*
        public IntPtr pUserSid;

        /// PEFS_CERTIFICATE_BLOB->_CERTIFICATE_BLOB*
        public IntPtr pCertBlob;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENCRYPTION_BUFFER
    {

        /// DWORD->unsigned int
        public uint EncryptionOperation;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Private;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ENCRYPTED_DATA_INFO
    {

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong StartingFileOffset;

        /// DWORD->unsigned int
        public uint OutputBufferOffset;

        /// DWORD->unsigned int
        public uint BytesWithinFileSize;

        /// DWORD->unsigned int
        public uint BytesWithinValidDataLength;

        /// WORD->unsigned short
        public ushort CompressionFormat;

        /// BYTE->unsigned char
        public byte DataUnitShift;

        /// BYTE->unsigned char
        public byte ChunkShift;

        /// BYTE->unsigned char
        public byte ClusterShift;

        /// BYTE->unsigned char
        public byte EncryptionFormat;

        /// WORD->unsigned short
        public ushort NumberOfDataBlocks;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] DataBlockSize;
    }

    public enum ELEMENT_TYPE
    {

        AllElements,

        ChangerTransport,

        ChangerSlot,

        ChangerIEPort,

        ChangerDrive,

        ChangerDoor,

        ChangerKeypad,

        ChangerMaxElement,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EFS_RPC_BLOB
    {

        /// DWORD->unsigned int
        public uint cbData;

        /// PBYTE->BYTE*
        public IntPtr pbData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EFS_KEY_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// ULONG->unsigned int
        public uint Entropy;

        /// ALG_ID->unsigned int
        public uint Algorithm;

        /// ULONG->unsigned int
        public uint KeyLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EFS_HASH_BLOB
    {

        /// DWORD->unsigned int
        public uint cbData;

        /// PBYTE->BYTE*
        public IntPtr pbData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EFS_CERTIFICATE_BLOB
    {

        /// DWORD->unsigned int
        public uint dwCertEncodingType;

        /// DWORD->unsigned int
        public uint cbData;

        /// PBYTE->BYTE*
        public IntPtr pbData;
    }

}
