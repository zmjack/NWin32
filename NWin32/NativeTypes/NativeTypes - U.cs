using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: unsigned char*
    ///param0: unsigned int*
    ///param1: unsigned char*
    ///param2: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr USER_MARSHAL_UNMARSHALLING_ROUTINE(ref uint param0, IntPtr param1, IntPtr param2);

    /// Return Type: unsigned int
    ///param0: unsigned int*
    ///param1: unsigned int
    ///param2: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint USER_MARSHAL_SIZING_ROUTINE(ref uint param0, uint param1, IntPtr param2);

    /// Return Type: unsigned char*
    ///param0: unsigned int*
    ///param1: unsigned char*
    ///param2: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr USER_MARSHAL_MARSHALLING_ROUTINE(ref uint param0, IntPtr param1, IntPtr param2);

    /// Return Type: void
    ///param0: unsigned int*
    ///param1: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void USER_MARSHAL_FREEING_ROUTINE(ref uint param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UILANGUAGE_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int UILANGUAGE_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, IntPtr param1);

    [StructLayout(LayoutKind.Sequential)]
    public struct UUID_VECTOR
    {

        /// unsigned int
        public uint Count;

        /// UUID*[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] Uuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct USN_RECORD
    {

        /// DWORD->unsigned int
        public uint RecordLength;

        /// WORD->unsigned short
        public ushort MajorVersion;

        /// WORD->unsigned short
        public ushort MinorVersion;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong FileReferenceNumber;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ParentFileReferenceNumber;

        /// USN->LONGLONG->__int64
        public long Usn;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER TimeStamp;

        /// DWORD->unsigned int
        public uint Reason;

        /// DWORD->unsigned int
        public uint SourceInfo;

        /// DWORD->unsigned int
        public uint SecurityId;

        /// DWORD->unsigned int
        public uint FileAttributes;

        /// WORD->unsigned short
        public ushort FileNameLength;

        /// WORD->unsigned short
        public ushort FileNameOffset;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string FileName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct USN_JOURNAL_DATA
    {

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong UsnJournalID;

        /// USN->LONGLONG->__int64
        public long FirstUsn;

        /// USN->LONGLONG->__int64
        public long NextUsn;

        /// USN->LONGLONG->__int64
        public long LowestValidUsn;

        /// USN->LONGLONG->__int64
        public long MaxUsn;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong MaximumSize;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong AllocationDelta;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct USER_MARSHAL_ROUTINE_QUADRUPLE
    {

        /// USER_MARSHAL_SIZING_ROUTINE
        public USER_MARSHAL_SIZING_ROUTINE pfnBufferSize;

        /// USER_MARSHAL_MARSHALLING_ROUTINE
        public USER_MARSHAL_MARSHALLING_ROUTINE pfnMarshall;

        /// USER_MARSHAL_UNMARSHALLING_ROUTINE
        public USER_MARSHAL_UNMARSHALLING_ROUTINE pfnUnmarshall;

        /// USER_MARSHAL_FREEING_ROUTINE
        public USER_MARSHAL_FREEING_ROUTINE pfnFree;
    }

    public enum USER_MARSHAL_CB_TYPE
    {

        USER_MARSHAL_CB_BUFFER_SIZE,

        USER_MARSHAL_CB_MARSHALL,

        USER_MARSHAL_CB_UNMARSHALL,

        USER_MARSHAL_CB_FREE,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct USER_MARSHAL_CB
    {

        /// unsigned int
        public uint Flags;

        /// PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        public IntPtr pStubMsg;

        /// PFORMAT_STRING->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pReserve;

        /// unsigned int
        public uint Signature;

        /// USER_MARSHAL_CB_TYPE->_USER_MARSHAL_CB_TYPE
        public USER_MARSHAL_CB_TYPE CBType;

        /// PFORMAT_STRING->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pFormat;

        /// PFORMAT_STRING->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pTypeFormat;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userSTGMEDIUM
    {

        /// _userSTGMEDIUM__STGMEDIUM_UNION
        public _userSTGMEDIUM__STGMEDIUM_UNION Struct1;

        /// IUnknown*
        public IntPtr pUnkForRelease;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userHPALETTE
    {

        /// int
        public int fContext;

        /// _userHPALETTE___MIDL_IWinTypes_0008
        public _userHPALETTE___MIDL_IWinTypes_0008 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userHMETAFILEPICT
    {

        /// int
        public int fContext;

        /// _userHMETAFILEPICT___MIDL_IWinTypes_0005
        public _userHMETAFILEPICT___MIDL_IWinTypes_0005 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userHMETAFILE
    {

        /// int
        public int fContext;

        /// _userHMETAFILE___MIDL_IWinTypes_0004
        public _userHMETAFILE___MIDL_IWinTypes_0004 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userHGLOBAL
    {

        /// int
        public int fContext;

        /// _userHGLOBAL___MIDL_IWinTypes_0003
        public _userHGLOBAL___MIDL_IWinTypes_0003 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userHENHMETAFILE
    {

        /// int
        public int fContext;

        /// _userHENHMETAFILE___MIDL_IWinTypes_0006
        public _userHENHMETAFILE___MIDL_IWinTypes_0006 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userHBITMAP
    {

        /// int
        public int fContext;

        /// _userHBITMAP___MIDL_IWinTypes_0007
        public _userHBITMAP___MIDL_IWinTypes_0007 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userFLAG_STGMEDIUM
    {

        /// int
        public int ContextFlags;

        /// int
        public int fPassOwnership;

        /// userSTGMEDIUM->_userSTGMEDIUM
        public userSTGMEDIUM Stgmed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userCLIPFORMAT
    {

        /// int
        public int fContext;

        /// _userCLIPFORMAT___MIDL_IWinTypes_0001
        public u Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct userBITMAP
    {

        /// LONG->int
        public int bmType;

        /// LONG->int
        public int bmWidth;

        /// LONG->int
        public int bmHeight;

        /// LONG->int
        public int bmWidthBytes;

        /// WORD->unsigned short
        public ushort bmPlanes;

        /// WORD->unsigned short
        public ushort bmBitsPixel;

        /// ULONG->unsigned int
        public uint cbSize;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] pBuffer;
    }

    public enum URL_ENCODING
    {

        /// URL_ENCODING_NONE -> 0
        URL_ENCODING_NONE = 0,

        /// URL_ENCODING_ENABLE_UTF8 -> 0x10000000
        URL_ENCODING_ENABLE_UTF8 = 268435456,

        /// URL_ENCODING_DISABLE_UTF8 -> 0x20000000
        URL_ENCODING_DISABLE_UTF8 = 536870912,
    }

    public enum URLZONEREG
    {

        /// URLZONEREG_DEFAULT -> 0
        URLZONEREG_DEFAULT = 0,

        /// URLZONEREG_HKLM -> URLZONEREG_DEFAULT+1
        URLZONEREG_HKLM = (URLZONEREG.URLZONEREG_DEFAULT + 1),

        /// URLZONEREG_HKCU -> URLZONEREG_HKLM+1
        URLZONEREG_HKCU = (URLZONEREG.URLZONEREG_HKLM + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UNLOAD_DLL_DEBUG_INFO
    {

        /// LPVOID->void*
        public IntPtr lpBaseOfDll;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UNIVERSAL_NAME_INFOW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpUniversalName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UNIVERSAL_NAME_INFOA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpUniversalName;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ULARGE_INTEGER
    {

        /// Anonymous_652f900e_e9d5_4a81_ba95_5c3af2ba5157
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_652f900e_e9d5_4a81_ba95_5c3af2ba5157 Struct1;

        /// Anonymous_da3d5bb2_d7f6_4b49_a86f_df044e26e59a
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_da3d5bb2_d7f6_4b49_a86f_df044e26e59a u;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong QuadPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UDATE
    {

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME st;

        /// USHORT->unsigned short
        public ushort wDayOfYear;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct uCLSSPEC
    {

        /// DWORD->unsigned int
        public uint tyspec;

        /// __MIDL___MIDL_itf_wtypes_0003_0001___MIDL___MIDL_itf_wtypes_0003_0005
        public tagged_union Union1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct u
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwValue;

        /// wchar_t*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pwszName;
    }

}