using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct netent
    {

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string n_name;

        /// char**
        public IntPtr n_aliases;

        /// short
        public short n_addrtype;

        /// u_long->unsigned int
        public uint n_net;
    }

    /// Return Type: int
    public delegate int NEARPROC();

    /// Return Type: void
    ///context: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void NDR_RUNDOWN(IntPtr context);

    /// Return Type: void
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void NDR_NOTIFY_ROUTINE();

    /// Return Type: void
    ///flag: boolean
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void NDR_NOTIFY2_ROUTINE([MarshalAs(UnmanagedType.I1)] bool flag);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int NAMEENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int NAMEENUMPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, IntPtr param1);

    [StructLayout(LayoutKind.Sequential)]
    public struct NUMPARSE
    {

        /// INT->int
        public int cDig;

        /// ULONG->unsigned int
        public uint dwInFlags;

        /// ULONG->unsigned int
        public uint dwOutFlags;

        /// INT->int
        public int cchUsed;

        /// INT->int
        public int nBaseShift;

        /// INT->int
        public int nPwr10;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NUMBERFMTW
    {

        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDecimalSep;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NUMBERFMTA
    {

        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDecimalSep;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NT_TIB64
    {

        /// DWORD64->unsigned __int64
        public ulong ExceptionList;

        /// DWORD64->unsigned __int64
        public ulong StackBase;

        /// DWORD64->unsigned __int64
        public ulong StackLimit;

        /// DWORD64->unsigned __int64
        public ulong SubSystemTib;

        /// Anonymous_bc7a5469_dda9_4254_b3d4_4de48f191a21
        public Anonymous_bc7a5469_dda9_4254_b3d4_4de48f191a21 Union1;

        /// DWORD64->unsigned __int64
        public ulong ArbitraryUserPointer;

        /// DWORD64->unsigned __int64
        public ulong Self;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NT_TIB32
    {

        /// DWORD->unsigned int
        public uint ExceptionList;

        /// DWORD->unsigned int
        public uint StackBase;

        /// DWORD->unsigned int
        public uint StackLimit;

        /// DWORD->unsigned int
        public uint SubSystemTib;

        /// Anonymous_bc80462d_922e_4a8f_b11f_481f73e89f73
        public Anonymous_bc80462d_922e_4a8f_b11f_481f73e89f73 Union1;

        /// DWORD->unsigned int
        public uint ArbitraryUserPointer;

        /// DWORD->unsigned int
        public uint Self;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NT_TIB
    {

        /// _EXCEPTION_REGISTRATION_RECORD*
        public IntPtr ExceptionList;

        /// PVOID->void*
        public IntPtr StackBase;

        /// PVOID->void*
        public IntPtr StackLimit;

        /// PVOID->void*
        public IntPtr SubSystemTib;

        /// Anonymous_bfc03952_c8c9_43d0_8f63_699e2421631e
        public Anonymous_bfc03952_c8c9_43d0_8f63_699e2421631e Union1;

        /// PVOID->void*
        public IntPtr ArbitraryUserPointer;

        /// _NT_TIB*
        public IntPtr Self;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NTFS_VOLUME_DATA_BUFFER
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER VolumeSerialNumber;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER NumberSectors;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER TotalClusters;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER FreeClusters;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER TotalReserved;

        /// DWORD->unsigned int
        public uint BytesPerSector;

        /// DWORD->unsigned int
        public uint BytesPerCluster;

        /// DWORD->unsigned int
        public uint BytesPerFileRecordSegment;

        /// DWORD->unsigned int
        public uint ClustersPerFileRecordSegment;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER MftValidDataLength;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER MftStartLcn;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Mft2StartLcn;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER MftZoneStart;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER MftZoneEnd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NTFS_STATISTICS
    {

        /// DWORD->unsigned int
        public uint LogFileFullExceptions;

        /// DWORD->unsigned int
        public uint OtherExceptions;

        /// DWORD->unsigned int
        public uint MftReads;

        /// DWORD->unsigned int
        public uint MftReadBytes;

        /// DWORD->unsigned int
        public uint MftWrites;

        /// DWORD->unsigned int
        public uint MftWriteBytes;

        /// Anonymous_eb9433b6_e978_4698_8a32_b407acdfde12
        public Anonymous_eb9433b6_e978_4698_8a32_b407acdfde12 MftWritesUserLevel;

        /// WORD->unsigned short
        public ushort MftWritesFlushForLogFileFull;

        /// WORD->unsigned short
        public ushort MftWritesLazyWriter;

        /// WORD->unsigned short
        public ushort MftWritesUserRequest;

        /// DWORD->unsigned int
        public uint Mft2Writes;

        /// DWORD->unsigned int
        public uint Mft2WriteBytes;

        /// Anonymous_2d16cbec_6a75_4063_8a95_597207c39783
        public Anonymous_2d16cbec_6a75_4063_8a95_597207c39783 Mft2WritesUserLevel;

        /// WORD->unsigned short
        public ushort Mft2WritesFlushForLogFileFull;

        /// WORD->unsigned short
        public ushort Mft2WritesLazyWriter;

        /// WORD->unsigned short
        public ushort Mft2WritesUserRequest;

        /// DWORD->unsigned int
        public uint RootIndexReads;

        /// DWORD->unsigned int
        public uint RootIndexReadBytes;

        /// DWORD->unsigned int
        public uint RootIndexWrites;

        /// DWORD->unsigned int
        public uint RootIndexWriteBytes;

        /// DWORD->unsigned int
        public uint BitmapReads;

        /// DWORD->unsigned int
        public uint BitmapReadBytes;

        /// DWORD->unsigned int
        public uint BitmapWrites;

        /// DWORD->unsigned int
        public uint BitmapWriteBytes;

        /// WORD->unsigned short
        public ushort BitmapWritesFlushForLogFileFull;

        /// WORD->unsigned short
        public ushort BitmapWritesLazyWriter;

        /// WORD->unsigned short
        public ushort BitmapWritesUserRequest;

        /// Anonymous_f88a58b9_6d70_43e3_959d_660704d31585
        public Anonymous_f88a58b9_6d70_43e3_959d_660704d31585 BitmapWritesUserLevel;

        /// DWORD->unsigned int
        public uint MftBitmapReads;

        /// DWORD->unsigned int
        public uint MftBitmapReadBytes;

        /// DWORD->unsigned int
        public uint MftBitmapWrites;

        /// DWORD->unsigned int
        public uint MftBitmapWriteBytes;

        /// WORD->unsigned short
        public ushort MftBitmapWritesFlushForLogFileFull;

        /// WORD->unsigned short
        public ushort MftBitmapWritesLazyWriter;

        /// WORD->unsigned short
        public ushort MftBitmapWritesUserRequest;

        /// Anonymous_05fd816a_fd3c_44de_9f0d_62b1893f6632
        public Anonymous_05fd816a_fd3c_44de_9f0d_62b1893f6632 MftBitmapWritesUserLevel;

        /// DWORD->unsigned int
        public uint UserIndexReads;

        /// DWORD->unsigned int
        public uint UserIndexReadBytes;

        /// DWORD->unsigned int
        public uint UserIndexWrites;

        /// DWORD->unsigned int
        public uint UserIndexWriteBytes;

        /// DWORD->unsigned int
        public uint LogFileReads;

        /// DWORD->unsigned int
        public uint LogFileReadBytes;

        /// DWORD->unsigned int
        public uint LogFileWrites;

        /// DWORD->unsigned int
        public uint LogFileWriteBytes;

        /// Anonymous_6d57931d_760c_4b56_8749_64bd6367fd2f
        public Anonymous_6d57931d_760c_4b56_8749_64bd6367fd2f Allocate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NTFS_FILE_RECORD_OUTPUT_BUFFER
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER FileReferenceNumber;

        /// DWORD->unsigned int
        public uint FileRecordLength;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] FileRecordBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NTFS_FILE_RECORD_INPUT_BUFFER
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER FileReferenceNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NTFS_EXTENDED_VOLUME_DATA
    {

        /// DWORD->unsigned int
        public uint ByteCount;

        /// WORD->unsigned short
        public ushort MajorVersion;

        /// WORD->unsigned short
        public ushort MinorVersion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct NOTIFYICONDATAW
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint uID;

        /// UINT->unsigned int
        public uint uFlags;

        /// UINT->unsigned int
        public uint uCallbackMessage;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szTip;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NOTIFYICONDATAA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint uID;

        /// UINT->unsigned int
        public uint uFlags;

        /// UINT->unsigned int
        public uint uCallbackMessage;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// CHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szTip;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NON_PAGED_DEBUG_INFO
    {

        /// WORD->unsigned short
        public ushort Signature;

        /// WORD->unsigned short
        public ushort Flags;

        /// DWORD->unsigned int
        public uint Size;

        /// WORD->unsigned short
        public ushort Machine;

        /// WORD->unsigned short
        public ushort Characteristics;

        /// DWORD->unsigned int
        public uint TimeDateStamp;

        /// DWORD->unsigned int
        public uint CheckSum;

        /// DWORD->unsigned int
        public uint SizeOfImage;

        /// ULONGLONG->unsigned __int64
        public ulong ImageBase;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NLSVERSIONINFO
    {

        /// DWORD->unsigned int
        public uint dwNLSVersionInfoSize;

        /// DWORD->unsigned int
        public uint dwNLSVersion;

        /// DWORD->unsigned int
        public uint dwDefinedVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETRESOURCEW
    {

        /// DWORD->unsigned int
        public uint dwScope;

        /// DWORD->unsigned int
        public uint dwType;

        /// DWORD->unsigned int
        public uint dwDisplayType;

        /// DWORD->unsigned int
        public uint dwUsage;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpLocalName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpRemoteName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpComment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpProvider;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETRESOURCEA
    {

        /// DWORD->unsigned int
        public uint dwScope;

        /// DWORD->unsigned int
        public uint dwType;

        /// DWORD->unsigned int
        public uint dwDisplayType;

        /// DWORD->unsigned int
        public uint dwUsage;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpLocalName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpRemoteName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpComment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpProvider;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETINFOSTRUCT
    {

        /// DWORD->unsigned int
        public uint cbStructure;

        /// DWORD->unsigned int
        public uint dwProviderVersion;

        /// DWORD->unsigned int
        public uint dwStatus;

        /// DWORD->unsigned int
        public uint dwCharacteristics;

        /// ULONG_PTR->unsigned int
        public uint dwHandle;

        /// WORD->unsigned short
        public ushort wNetType;

        /// DWORD->unsigned int
        public uint dwPrinters;

        /// DWORD->unsigned int
        public uint dwDrives;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETCONNECTINFOSTRUCT
    {

        /// DWORD->unsigned int
        public uint cbStructure;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwSpeed;

        /// DWORD->unsigned int
        public uint dwDelay;

        /// DWORD->unsigned int
        public uint dwOptDataSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NDR_USER_MARSHAL_INFO_LEVEL1
    {

        /// void*
        public IntPtr Buffer;

        /// unsigned int
        public uint BufferSize;

        /// _NDR_USER_MARSHAL_INFO_LEVEL1_pfnAllocate
        public _NDR_USER_MARSHAL_INFO_LEVEL1_pfnAllocate AnonymousMember1;

        /// _NDR_USER_MARSHAL_INFO_LEVEL1_pfnFree
        public _NDR_USER_MARSHAL_INFO_LEVEL1_pfnFree AnonymousMember2;

        /// IRpcChannelBuffer*
        public IntPtr pRpcChannelBuffer;

        /// ULONG_PTR[5]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.U4)]
        public uint[] Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NDR_USER_MARSHAL_INFO
    {

        /// unsigned int
        public uint InformationLevel;

        /// Anonymous_166634b0_1a53_4bd3_a2ea_6cf895ccf002
        public Anonymous_166634b0_1a53_4bd3_a2ea_6cf895ccf002 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NDR_CS_SIZE_CONVERT_ROUTINES
    {

        /// CS_TYPE_NET_SIZE_ROUTINE
        public CS_TYPE_NET_SIZE_ROUTINE pfnNetSize;

        /// CS_TYPE_TO_NETCS_ROUTINE
        public CS_TYPE_TO_NETCS_ROUTINE pfnToNetCs;

        /// CS_TYPE_LOCAL_SIZE_ROUTINE
        public CS_TYPE_LOCAL_SIZE_ROUTINE pfnLocalSize;

        /// CS_TYPE_FROM_NETCS_ROUTINE
        public CS_TYPE_FROM_NETCS_ROUTINE pfnFromNetCs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NDR_CS_ROUTINES
    {

        /// NDR_CS_SIZE_CONVERT_ROUTINES*
        public IntPtr pSizeConvertRoutines;

        /// CS_TAG_GETTING_ROUTINE*
        public IntPtr pTagGettingRoutines;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NCB
    {

        /// UCHAR->unsigned char
        public byte ncb_command;

        /// UCHAR->unsigned char
        public byte ncb_retcode;

        /// UCHAR->unsigned char
        public byte ncb_lsn;

        /// UCHAR->unsigned char
        public byte ncb_num;

        /// PUCHAR->UCHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ncb_buffer;

        /// WORD->unsigned short
        public ushort ncb_length;

        /// UCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ncb_callname;

        /// UCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ncb_name;

        /// UCHAR->unsigned char
        public byte ncb_rto;

        /// UCHAR->unsigned char
        public byte ncb_sto;

        /// _NCB_ncb_post
        public _NCB_ncb_post AnonymousMember1;

        /// UCHAR->unsigned char
        public byte ncb_lana_num;

        /// UCHAR->unsigned char
        public byte ncb_cmd_cplt;

        /// UCHAR[10]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string ncb_reserve;

        /// HANDLE->void*
        public IntPtr ncb_event;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NAME_BUFFER
    {

        /// UCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string name;

        /// UCHAR->unsigned char
        public byte name_num;

        /// UCHAR->unsigned char
        public byte name_flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct n2
    {

        /// VARTYPE->unsigned short
        public ushort vt;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// WORD->unsigned short
        public ushort wReserved2;

        /// WORD->unsigned short
        public ushort wReserved3;

        /// Anonymous_8aa3785c_22bd_4ac9_90f4_6ed601ba4a84
        public Anonymous_8aa3785c_22bd_4ac9_90f4_6ed601ba4a84 n3;
    }

}
