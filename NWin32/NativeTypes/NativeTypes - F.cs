using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: HDDEDATA->HDDEDATA__*
    ///wType: UINT->unsigned int
    ///wFmt: UINT->unsigned int
    ///hConv: HCONV->HCONV__*
    ///hsz1: HSZ->HSZ__*
    ///hsz2: HSZ->HSZ__*
    ///hData: HDDEDATA->HDDEDATA__*
    ///dwData1: ULONG_PTR->unsigned int
    ///dwData2: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr FNCALLBACK(uint wType, uint wFmt, IntPtr hConv, IntPtr hsz1, IntPtr hsz2, IntPtr hData, uint dwData1, uint dwData2);

    [StructLayout(LayoutKind.Sequential)]
    public struct fd_set
    {

        /// u_int->unsigned int
        public uint fd_count;

        /// SOCKET[64]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U4)]
        public uint[] fd_array;
    }

    /// Return Type: int
    public delegate int FARPROC();

    [StructLayout(LayoutKind.Sequential)]
    public struct FULL_PTR_XLAT_TABLES
    {

        /// Anonymous_be99ba83_4d1f_4757_92c0_097e5f917528
        public Anonymous_be99ba83_4d1f_4757_92c0_097e5f917528 RefIdToPointer;

        /// Anonymous_f30d8ff9_a58f_4580_b612_d3665f894fed
        public Anonymous_f30d8ff9_a58f_4580_b612_d3665f894fed PointerToRefId;

        /// unsigned int
        public uint NextRefId;

        /// XLAT_SIDE->Anonymous_bac968f7_3f83_4950_a616_220cca7c06bf
        public XLAT_SIDE XlatSide;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FULL_PTR_TO_REFID_ELEMENT
    {

        /// _FULL_PTR_TO_REFID_ELEMENT*
        public IntPtr Next;

        /// void*
        public IntPtr Pointer;

        /// unsigned int
        public uint RefId;

        /// unsigned char
        public byte State;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FSCTL_QUERY_FAT_BPB_BUFFER
    {

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] First0x24BytesOfBootSector;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FPO_DATA
    {

        /// DWORD->unsigned int
        public uint ulOffStart;

        /// DWORD->unsigned int
        public uint cbProcSize;

        /// DWORD->unsigned int
        public uint cdwLocals;

        /// WORD->unsigned short
        public ushort cdwParams;

        /// cbProlog : 8
        ///cbRegs : 3
        ///fHasSEH : 1
        ///fUseBP : 1
        ///reserved : 1
        ///cbFrame : 2
        public uint bitvector1;

        public uint cbProlog
        {
            get
            {
                return ((uint)((this.bitvector1 & 255u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint cbRegs
        {
            get
            {
                return ((uint)(((this.bitvector1 & 1792u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint fHasSEH
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2048u)
                            / 2048)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2048)
                            | this.bitvector1)));
            }
        }

        public uint fUseBP
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4096u)
                            / 4096)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4096)
                            | this.bitvector1)));
            }
        }

        public uint reserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8192u)
                            / 8192)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8192)
                            | this.bitvector1)));
            }
        }

        public uint cbFrame
        {
            get
            {
                return ((uint)(((this.bitvector1 & 49152u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FORM_INFO_1W
    {

        /// DWORD->unsigned int
        public uint Flags;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE Size;

        /// RECTL->_RECTL
        public RECTL ImageableArea;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FORM_INFO_1A
    {

        /// DWORD->unsigned int
        public uint Flags;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE Size;

        /// RECTL->_RECTL
        public RECTL ImageableArea;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FORMAT_PARAMETERS
    {

        /// MEDIA_TYPE->_MEDIA_TYPE
        public MEDIA_TYPE MediaType;

        /// DWORD->unsigned int
        public uint StartCylinderNumber;

        /// DWORD->unsigned int
        public uint EndCylinderNumber;

        /// DWORD->unsigned int
        public uint StartHeadNumber;

        /// DWORD->unsigned int
        public uint EndHeadNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FORMAT_EX_PARAMETERS
    {

        /// MEDIA_TYPE->_MEDIA_TYPE
        public MEDIA_TYPE MediaType;

        /// DWORD->unsigned int
        public uint StartCylinderNumber;

        /// DWORD->unsigned int
        public uint EndCylinderNumber;

        /// DWORD->unsigned int
        public uint StartHeadNumber;

        /// DWORD->unsigned int
        public uint EndHeadNumber;

        /// WORD->unsigned short
        public ushort FormatGapLength;

        /// WORD->unsigned short
        public ushort SectorsPerTrack;

        /// WORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U2)]
        public ushort[] SectorNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FOCUS_EVENT_RECORD
    {

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bSetFocus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLOATING_SAVE_AREA
    {

        /// DWORD->unsigned int
        public uint ControlWord;

        /// DWORD->unsigned int
        public uint StatusWord;

        /// DWORD->unsigned int
        public uint TagWord;

        /// DWORD->unsigned int
        public uint ErrorOffset;

        /// DWORD->unsigned int
        public uint ErrorSelector;

        /// DWORD->unsigned int
        public uint DataOffset;

        /// DWORD->unsigned int
        public uint DataSelector;

        /// BYTE[80]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
        public byte[] RegisterArea;

        /// DWORD->unsigned int
        public uint Cr0NpxState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLOAT128
    {

        /// __int64
        public long LowPart;

        /// __int64
        public long HighPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLASHWINFO
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// UINT->unsigned int
        public uint uCount;

        /// DWORD->unsigned int
        public uint dwTimeout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLAG_STGMEDIUM
    {

        /// int
        public int ContextFlags;

        /// int
        public int fPassOwnership;

        /// STGMEDIUM->uSTGMEDIUM->tagSTGMEDIUM
        public tagSTGMEDIUM Stgmed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLAGGED_WORD_BLOB
    {

        /// unsigned int
        public uint fFlags;

        /// unsigned int
        public uint clSize;

        /// unsigned short[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U2)]
        public ushort[] asData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FLAGGED_BYTE_BLOB
    {

        /// unsigned int
        public uint fFlags;

        /// unsigned int
        public uint clSize;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] abData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FIXED
    {

        /// WORD->unsigned short
        public ushort fract;

        /// short
        public short value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FIND_NAME_HEADER
    {

        /// WORD->unsigned short
        public ushort node_count;

        /// UCHAR->unsigned char
        public byte reserved;

        /// UCHAR->unsigned char
        public byte unique_group;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FIND_NAME_BUFFER
    {

        /// UCHAR->unsigned char
        public byte length;

        /// UCHAR->unsigned char
        public byte access_control;

        /// UCHAR->unsigned char
        public byte frame_control;

        /// UCHAR[6]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string destination_addr;

        /// UCHAR[6]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string source_addr;

        /// UCHAR[18]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18)]
        public string routing_info;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct FIND_BY_SID_OUTPUT
    {

        /// DWORD->unsigned int
        public uint NextEntryOffset;

        /// DWORD->unsigned int
        public uint FileIndex;

        /// DWORD->unsigned int
        public uint FileNameLength;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string FileName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FIND_BY_SID_DATA
    {

        /// DWORD->unsigned int
        public uint Restart;

        /// SID->_SID
        public SID Sid;
    }

    public enum FINDEX_SEARCH_OPS
    {

        FindExSearchNameMatch,

        FindExSearchLimitToDirectories,

        FindExSearchLimitToDevices,

        FindExSearchMaxSearchOp,
    }

    public enum FINDEX_INFO_LEVELS
    {

        FindExInfoStandard,

        FindExInfoMaxInfoLevel,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILE_ZERO_DATA_INFORMATION
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER FileOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER BeyondFinalZero;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILE_SET_SPARSE_BUFFER
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte SetSparse;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FILE_SEGMENT_ELEMENT
    {

        /// PVOID64->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr Buffer;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong Alignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILE_PREFETCH
    {

        /// DWORD->unsigned int
        public uint Type;

        /// DWORD->unsigned int
        public uint Count;

        /// DWORDLONG[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U8)]
        public ulong[] Prefetch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILE_OBJECTID_BUFFER
    {

        /// BYTE[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] ObjectId;

        /// Anonymous_845d88d8_08bf_4524_8a38_0222d8c5bd4c
        public Anonymous_845d88d8_08bf_4524_8a38_0222d8c5bd4c Union1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct FILE_NOTIFY_INFORMATION
    {

        /// DWORD->unsigned int
        public uint NextEntryOffset;

        /// DWORD->unsigned int
        public uint Action;

        /// DWORD->unsigned int
        public uint FileNameLength;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string FileName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILE_ALLOCATED_RANGE_BUFFER
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER FileOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME
    {

        /// DWORD->unsigned int
        public uint dwLowDateTime;

        /// DWORD->unsigned int
        public uint dwHighDateTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILESYSTEM_STATISTICS
    {

        /// WORD->unsigned short
        public ushort FileSystemType;

        /// WORD->unsigned short
        public ushort Version;

        /// DWORD->unsigned int
        public uint SizeOfCompleteStructure;

        /// DWORD->unsigned int
        public uint UserFileReads;

        /// DWORD->unsigned int
        public uint UserFileReadBytes;

        /// DWORD->unsigned int
        public uint UserDiskReads;

        /// DWORD->unsigned int
        public uint UserFileWrites;

        /// DWORD->unsigned int
        public uint UserFileWriteBytes;

        /// DWORD->unsigned int
        public uint UserDiskWrites;

        /// DWORD->unsigned int
        public uint MetaDataReads;

        /// DWORD->unsigned int
        public uint MetaDataReadBytes;

        /// DWORD->unsigned int
        public uint MetaDataDiskReads;

        /// DWORD->unsigned int
        public uint MetaDataWrites;

        /// DWORD->unsigned int
        public uint MetaDataWriteBytes;

        /// DWORD->unsigned int
        public uint MetaDataDiskWrites;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FAT_STATISTICS
    {

        /// DWORD->unsigned int
        public uint CreateHits;

        /// DWORD->unsigned int
        public uint SuccessfulCreates;

        /// DWORD->unsigned int
        public uint FailedCreates;

        /// DWORD->unsigned int
        public uint NonCachedReads;

        /// DWORD->unsigned int
        public uint NonCachedReadBytes;

        /// DWORD->unsigned int
        public uint NonCachedWrites;

        /// DWORD->unsigned int
        public uint NonCachedWriteBytes;

        /// DWORD->unsigned int
        public uint NonCachedDiskReads;

        /// DWORD->unsigned int
        public uint NonCachedDiskWrites;
    }

}
