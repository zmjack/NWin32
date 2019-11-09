using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: void
    ///lpHelpInfo: LPHELPINFO->tagHELPINFO*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void MSGBOXCALLBACK(ref tagHELPINFO lpHelpInfo);

    /// Return Type: BOOL->int
    ///param0: HMONITOR->HMONITOR__*
    ///param1: HDC->HDC__*
    ///param2: LPRECT->tagRECT*
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MONITORENUMPROC(IntPtr param0, IntPtr param1, ref tagRECT param2, IntPtr param3);

    [StructLayout(LayoutKind.Sequential)]
    public struct mmtime_tag
    {

        /// UINT->unsigned int
        public uint wType;

        /// Anonymous_191604fe_770e_4688_aef5_8c113498eb25
        public Anonymous_191604fe_770e_4688_aef5_8c113498eb25 u;
    }

    /// Return Type: LRESULT->LONG_PTR->int
    ///lpmmioinfo: LPSTR->CHAR*
    ///uMsg: UINT->unsigned int
    ///lParam1: LPARAM->LONG_PTR->int
    ///lParam2: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MMIOPROC([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpmmioinfo, uint uMsg, IntPtr lParam1, IntPtr lParam2);

    [StructLayout(LayoutKind.Sequential)]
    public struct midistrmbuffver_tag
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// DWORD->unsigned int
        public uint dwMid;

        /// DWORD->unsigned int
        public uint dwOEMVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct midiproptimediv_tag
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwTimeDiv;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct midiproptempo_tag
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwTempo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct midihdr_tag
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;

        /// DWORD->unsigned int
        public uint dwBufferLength;

        /// DWORD->unsigned int
        public uint dwBytesRecorded;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwUser;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// midihdr_tag*
        public IntPtr lpNext;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint reserved;

        /// DWORD->unsigned int
        public uint dwOffset;

        /// DWORD_PTR[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct midievent_tag
    {

        /// DWORD->unsigned int
        public uint dwDeltaTime;

        /// DWORD->unsigned int
        public uint dwStreamID;

        /// DWORD->unsigned int
        public uint dwEvent;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] dwParms;
    }

    /// Return Type: int
    ///hdc: HDC->HDC__*
    ///lpht: HANDLETABLE*
    ///lpMR: METARECORD*
    ///nObj: int
    ///param: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int MFENUMPROC([In] IntPtr hdc, [In] IntPtr lpht, [In] ref tagMETARECORD lpMR, int nObj, [In] IntPtr param);

    [StructLayout(LayoutKind.Sequential)]
    public struct MOVE_FILE_DATA
    {

        /// HANDLE->void*
        public IntPtr FileHandle;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingVcn;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingLcn;

        /// DWORD->unsigned int
        public uint ClusterCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSE_EVENT_RECORD
    {

        /// COORD->_COORD
        public COORD dwMousePosition;

        /// DWORD->unsigned int
        public uint dwButtonState;

        /// DWORD->unsigned int
        public uint dwControlKeyState;

        /// DWORD->unsigned int
        public uint dwEventFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MONITOR_INFO_2W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pEnvironment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDLLName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MONITOR_INFO_2A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pEnvironment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDLLName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MONITOR_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MONITOR_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;
    }

    public enum MONIKERPROPERTY
    {

        /// MIMETYPEPROP -> 0
        MIMETYPEPROP = 0,

        /// USE_SRC_URL -> 0x1
        USE_SRC_URL = 1,

        /// CLASSIDPROP -> 0x2
        CLASSIDPROP = 2,

        /// TRUSTEDDOWNLOADPROP -> 0x3
        TRUSTEDDOWNLOADPROP = 3,

        /// POPUPLEVELPROP -> 0x4
        POPUPLEVELPROP = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MODEMSETTINGS
    {

        /// DWORD->unsigned int
        public uint dwActualSize;

        /// DWORD->unsigned int
        public uint dwRequiredSize;

        /// DWORD->unsigned int
        public uint dwDevSpecificOffset;

        /// DWORD->unsigned int
        public uint dwDevSpecificSize;

        /// DWORD->unsigned int
        public uint dwCallSetupFailTimer;

        /// DWORD->unsigned int
        public uint dwInactivityTimeout;

        /// DWORD->unsigned int
        public uint dwSpeakerVolume;

        /// DWORD->unsigned int
        public uint dwSpeakerMode;

        /// DWORD->unsigned int
        public uint dwPreferredModemOptions;

        /// DWORD->unsigned int
        public uint dwNegotiatedModemOptions;

        /// DWORD->unsigned int
        public uint dwNegotiatedDCERate;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] abVariablePortion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MODEMDEVCAPS
    {

        /// DWORD->unsigned int
        public uint dwActualSize;

        /// DWORD->unsigned int
        public uint dwRequiredSize;

        /// DWORD->unsigned int
        public uint dwDevSpecificOffset;

        /// DWORD->unsigned int
        public uint dwDevSpecificSize;

        /// DWORD->unsigned int
        public uint dwModemProviderVersion;

        /// DWORD->unsigned int
        public uint dwModemManufacturerOffset;

        /// DWORD->unsigned int
        public uint dwModemManufacturerSize;

        /// DWORD->unsigned int
        public uint dwModemModelOffset;

        /// DWORD->unsigned int
        public uint dwModemModelSize;

        /// DWORD->unsigned int
        public uint dwModemVersionOffset;

        /// DWORD->unsigned int
        public uint dwModemVersionSize;

        /// DWORD->unsigned int
        public uint dwDialOptions;

        /// DWORD->unsigned int
        public uint dwCallSetupFailTimer;

        /// DWORD->unsigned int
        public uint dwInactivityTimeout;

        /// DWORD->unsigned int
        public uint dwSpeakerVolume;

        /// DWORD->unsigned int
        public uint dwSpeakerMode;

        /// DWORD->unsigned int
        public uint dwModemOptions;

        /// DWORD->unsigned int
        public uint dwMaxDTERate;

        /// DWORD->unsigned int
        public uint dwMaxDCERate;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] abVariablePortion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MMIOINFO
    {

        /// DWORD->unsigned int
        public uint dwFlags;

        /// FOURCC->DWORD->unsigned int
        public uint fccIOProc;

        /// LPMMIOPROC->MMIOPROC*
        public IntPtr pIOProc;

        /// UINT->unsigned int
        public uint wErrorRet;

        /// HTASK->HTASK__*
        public IntPtr htask;

        /// LONG->int
        public int cchBuffer;

        /// HPSTR->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pchBuffer;

        /// HPSTR->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pchNext;

        /// HPSTR->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pchEndRead;

        /// HPSTR->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pchEndWrite;

        /// LONG->int
        public int lBufOffset;

        /// LONG->int
        public int lDiskOffset;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] adwInfo;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// DWORD->unsigned int
        public uint dwReserved2;

        /// HMMIO->HMMIO__*
        public IntPtr hmmio;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MMCKINFO
    {

        /// FOURCC->DWORD->unsigned int
        public uint ckid;

        /// DWORD->unsigned int
        public uint cksize;

        /// FOURCC->DWORD->unsigned int
        public uint fccType;

        /// DWORD->unsigned int
        public uint dwDataOffset;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MIDL_SYNTAX_INFO
    {

        /// RPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER
        public RPC_SYNTAX_IDENTIFIER TransferSyntax;

        /// RPC_DISPATCH_TABLE*
        public IntPtr DispatchTable;

        /// PFORMAT_STRING->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ProcString;

        /// short*
        public IntPtr FmtStringOffset;

        /// PFORMAT_STRING->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string TypeString;

        /// void*
        public IntPtr aUserMarshalQuadruple;

        /// ULONG_PTR->unsigned int
        public uint pReserved1;

        /// ULONG_PTR->unsigned int
        public uint pReserved2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MIDL_STUB_MESSAGE
    {

        /// PRPC_MESSAGE->_RPC_MESSAGE*
        public IntPtr RpcMsg;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string Buffer;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string BufferStart;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string BufferEnd;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string BufferMark;

        /// unsigned int
        public uint BufferLength;

        /// unsigned int
        public uint MemorySize;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string Memory;

        /// unsigned char
        public byte IsClient;

        /// unsigned char
        public byte Pad;

        /// unsigned short
        public ushort uFlags2;

        /// int
        public int ReuseBuffer;

        /// NDR_ALLOC_ALL_NODES_CONTEXT*
        public IntPtr pAllocAllNodesContext;

        /// NDR_POINTER_QUEUE_STATE*
        public IntPtr pPointerQueueState;

        /// int
        public int IgnoreEmbeddedPointers;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string PointerBufferMark;

        /// unsigned char
        public byte fBufferValid;

        /// unsigned char
        public byte uFlags;

        /// unsigned short
        public ushort UniquePtrCount;

        /// ULONG_PTR->unsigned int
        public uint MaxCount;

        /// unsigned int
        public uint Offset;

        /// unsigned int
        public uint ActualCount;

        /// _MIDL_STUB_MESSAGE_pfnAllocate
        public _MIDL_STUB_MESSAGE_pfnAllocate AnonymousMember1;

        /// _MIDL_STUB_MESSAGE_pfnFree
        public _MIDL_STUB_MESSAGE_pfnFree AnonymousMember2;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string StackTop;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPresentedType;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pTransmitType;

        /// handle_t->RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        public IntPtr SavedHandle;

        /// _MIDL_STUB_DESC*
        public IntPtr StubDesc;

        /// _FULL_PTR_XLAT_TABLES*
        public IntPtr FullPtrXlatTables;

        /// unsigned int
        public uint FullPtrRefId;

        /// unsigned int
        public uint PointerLength;

        /// fInDontFree : 1
        ///fDontCallFreeInst : 1
        ///fInOnlyParam : 1
        ///fHasReturn : 1
        ///fHasExtensions : 1
        ///fHasNewCorrDesc : 1
        ///fIsOicfServer : 1
        ///fHasMemoryValidateCallback : 1
        ///fUnused : 8
        ///fUnused2 : 16
        public uint bitvector1;

        /// unsigned int
        public uint dwDestContext;

        /// void*
        public IntPtr pvDestContext;

        /// NDR_SCONTEXT*
        public IntPtr SavedContextHandles;

        /// int
        public int ParamNumber;

        /// IRpcChannelBuffer*
        public IntPtr pRpcChannelBuffer;

        /// PARRAY_INFO->Anonymous_83897020_0166_4476_ad38_ad3dc41cb585*
        public IntPtr pArrayInfo;

        /// unsigned int*
        public IntPtr SizePtrCountArray;

        /// unsigned int*
        public IntPtr SizePtrOffsetArray;

        /// unsigned int*
        public IntPtr SizePtrLengthArray;

        /// void*
        public IntPtr pArgQueue;

        /// unsigned int
        public uint dwStubPhase;

        /// void*
        public IntPtr LowStackMark;

        /// PNDR_ASYNC_MESSAGE->_NDR_ASYNC_MESSAGE*
        public IntPtr pAsyncMsg;

        /// PNDR_CORRELATION_INFO->_NDR_CORRELATION_INFO*
        public IntPtr pCorrInfo;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pCorrMemory;

        /// void*
        public IntPtr pMemoryList;

        /// CS_STUB_INFO*
        public IntPtr pCSInfo;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ConformanceMark;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string VarianceMark;

        /// INT_PTR->int
        public int Unused;

        /// _NDR_PROC_CONTEXT*
        public IntPtr pContext;

        /// void*
        public IntPtr pUserMarshalList;

        /// INT_PTR->int
        public int Reserved51_2;

        /// INT_PTR->int
        public int Reserved51_3;

        /// INT_PTR->int
        public int Reserved51_4;

        /// INT_PTR->int
        public int Reserved51_5;

        public uint fInDontFree
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint fDontCallFreeInst
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }

        public uint fInOnlyParam
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4u)
                            / 4)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4)
                            | this.bitvector1)));
            }
        }

        public uint fHasReturn
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8u)
                            / 8)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8)
                            | this.bitvector1)));
            }
        }

        public uint fHasExtensions
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16u)
                            / 16)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16)
                            | this.bitvector1)));
            }
        }

        public uint fHasNewCorrDesc
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32u)
                            / 32)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32)
                            | this.bitvector1)));
            }
        }

        public uint fIsOicfServer
        {
            get
            {
                return ((uint)(((this.bitvector1 & 64u)
                            / 64)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 64)
                            | this.bitvector1)));
            }
        }

        public uint fHasMemoryValidateCallback
        {
            get
            {
                return ((uint)(((this.bitvector1 & 128u)
                            / 128)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 128)
                            | this.bitvector1)));
            }
        }

        public uint fUnused
        {
            get
            {
                return ((uint)(((this.bitvector1 & 65280u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint fUnused2
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4294901760u)
                            / 65536)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 65536)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MIDL_STUB_DESC
    {

        /// void*
        public IntPtr RpcInterfaceInformation;

        /// _MIDL_STUB_DESC_pfnAllocate
        public _MIDL_STUB_DESC_pfnAllocate AnonymousMember1;

        /// _MIDL_STUB_DESC_pfnFree
        public _MIDL_STUB_DESC_pfnFree AnonymousMember2;

        /// Anonymous_446ffc7f_2d11_49ef_8817_6d4d0b594562
        public Anonymous_446ffc7f_2d11_49ef_8817_6d4d0b594562 IMPLICIT_HANDLE_INFO;

        /// NDR_RUNDOWN*
        public IntPtr apfnNdrRundownRoutines;

        /// GENERIC_BINDING_ROUTINE_PAIR*
        public IntPtr aGenericBindingRoutinePairs;

        /// EXPR_EVAL*
        public IntPtr apfnExprEval;

        /// XMIT_ROUTINE_QUINTUPLE*
        public IntPtr aXmitQuintuple;

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pFormatTypes;

        /// int
        public int fCheckBounds;

        /// unsigned int
        public uint Version;

        /// MALLOC_FREE_STRUCT*
        public IntPtr pMallocFreeStruct;

        /// int
        public int MIDLVersion;

        /// COMM_FAULT_OFFSETS*
        public IntPtr CommFaultOffsets;

        /// USER_MARSHAL_ROUTINE_QUADRUPLE*
        public IntPtr aUserMarshalQuadruple;

        /// NDR_NOTIFY_ROUTINE*
        public IntPtr NotifyRoutineTable;

        /// ULONG_PTR->unsigned int
        public uint mFlags;

        /// NDR_CS_ROUTINES*
        public IntPtr CsRoutineTables;

        /// void*
        public IntPtr Reserved4;

        /// ULONG_PTR->unsigned int
        public uint Reserved5;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MIDL_STUBLESS_PROXY_INFO
    {

        /// PMIDL_STUB_DESC->MIDL_STUB_DESC*
        public IntPtr pStubDesc;

        /// PFORMAT_STRING->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ProcFormatString;

        /// short*
        public IntPtr FormatStringOffset;

        /// PRPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER*
        public IntPtr pTransferSyntax;

        /// ULONG_PTR->unsigned int
        public uint nCount;

        /// PMIDL_SYNTAX_INFO->_MIDL_SYNTAX_INFO*
        public IntPtr pSyntaxInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MIDL_SERVER_INFO
    {

        /// PMIDL_STUB_DESC->MIDL_STUB_DESC*
        public IntPtr pStubDesc;

        /// SERVER_ROUTINE*
        public IntPtr DispatchTable;

        /// PFORMAT_STRING->char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ProcString;

        /// short*
        public IntPtr FmtStringOffset;

        /// STUB_THUNK*
        public IntPtr ThunkTable;

        /// PRPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER*
        public IntPtr pTransferSyntax;

        /// ULONG_PTR->unsigned int
        public uint nCount;

        /// PMIDL_SYNTAX_INFO->_MIDL_SYNTAX_INFO*
        public IntPtr pSyntaxInfo;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MIDL_FORMAT_STRING
    {

        /// short
        public short Pad;

        /// unsigned char[]
        //TODO: [MarshalAs(UnmanagedType.ByValTStr, SizeConst = -1)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string Format;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MFT_ENUM_DATA
    {

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong StartFileReferenceNumber;

        /// USN->LONGLONG->__int64
        public long LowUsn;

        /// USN->LONGLONG->__int64
        public long HighUsn;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MESSAGE_RESOURCE_ENTRY
    {

        /// WORD->unsigned short
        public ushort Length;

        /// WORD->unsigned short
        public ushort Flags;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Text;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MESSAGE_RESOURCE_DATA
    {

        /// DWORD->unsigned int
        public uint NumberOfBlocks;

        /// MESSAGE_RESOURCE_BLOCK[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public MESSAGE_RESOURCE_BLOCK[] Blocks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MESSAGE_RESOURCE_BLOCK
    {

        /// DWORD->unsigned int
        public uint LowId;

        /// DWORD->unsigned int
        public uint HighId;

        /// DWORD->unsigned int
        public uint OffsetToEntries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MENU_EVENT_RECORD
    {

        /// UINT->unsigned int
        public uint dwCommandId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MENUITEMTEMPLATEHEADER
    {

        /// WORD->unsigned short
        public ushort versionNumber;

        /// WORD->unsigned short
        public ushort offset;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MENUITEMTEMPLATE
    {

        /// WORD->unsigned short
        public ushort mtOption;

        /// WORD->unsigned short
        public ushort mtID;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string mtString;
    }

    public enum MEMORY_RESOURCE_NOTIFICATION_TYPE
    {

        LowMemoryResourceNotification,

        HighMemoryResourceNotification,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION64
    {

        /// ULONGLONG->unsigned __int64
        public ulong BaseAddress;

        /// ULONGLONG->unsigned __int64
        public ulong AllocationBase;

        /// DWORD->unsigned int
        public uint AllocationProtect;

        /// DWORD->unsigned int
        public uint @__alignment1;

        /// ULONGLONG->unsigned __int64
        public ulong RegionSize;

        /// DWORD->unsigned int
        public uint State;

        /// DWORD->unsigned int
        public uint Protect;

        /// DWORD->unsigned int
        public uint Type;

        /// DWORD->unsigned int
        public uint @__alignment2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION32
    {

        /// DWORD->unsigned int
        public uint BaseAddress;

        /// DWORD->unsigned int
        public uint AllocationBase;

        /// DWORD->unsigned int
        public uint AllocationProtect;

        /// DWORD->unsigned int
        public uint RegionSize;

        /// DWORD->unsigned int
        public uint State;

        /// DWORD->unsigned int
        public uint Protect;

        /// DWORD->unsigned int
        public uint Type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {

        /// PVOID->void*
        public IntPtr BaseAddress;

        /// PVOID->void*
        public IntPtr AllocationBase;

        /// DWORD->unsigned int
        public uint AllocationProtect;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint RegionSize;

        /// DWORD->unsigned int
        public uint State;

        /// DWORD->unsigned int
        public uint Protect;

        /// DWORD->unsigned int
        public uint Type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORYSTATUSEX
    {

        /// DWORD->unsigned int
        public uint dwLength;

        /// DWORD->unsigned int
        public uint dwMemoryLoad;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullTotalPhys;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailPhys;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullTotalPageFile;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailPageFile;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullTotalVirtual;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailVirtual;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong ullAvailExtendedVirtual;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORYSTATUS
    {

        /// DWORD->unsigned int
        public uint dwLength;

        /// DWORD->unsigned int
        public uint dwMemoryLoad;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwTotalPhys;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwAvailPhys;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwTotalPageFile;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwAvailPageFile;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwTotalVirtual;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint dwAvailVirtual;
    }

    public enum MEDIA_TYPE
    {

        Unknown,

        F5_1Pt2_512,

        F3_1Pt44_512,

        F3_2Pt88_512,

        F3_20Pt8_512,

        F3_720_512,

        F5_360_512,

        F5_320_512,

        F5_320_1024,

        F5_180_512,

        F5_160_512,

        RemovableMedia,

        FixedMedia,

        F3_120M_512,

        F3_640_512,

        F5_640_512,

        F5_720_512,

        F3_1Pt2_512,

        F3_1Pt23_1024,

        F5_1Pt23_1024,

        F3_128Mb_512,

        F3_230Mb_512,

        F8_256_128,

        F3_200Mb_512,

        F3_240M_512,

        F3_32M_512,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAT2
    {

        /// FIXED->_FIXED
        public FIXED eM11;

        /// FIXED->_FIXED
        public FIXED eM12;

        /// FIXED->_FIXED
        public FIXED eM21;

        /// FIXED->_FIXED
        public FIXED eM22;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MARK_HANDLE_INFO
    {

        /// DWORD->unsigned int
        public uint UsnSourceInfo;

        /// HANDLE->void*
        public IntPtr VolumeHandle;

        /// DWORD->unsigned int
        public uint HandleInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MALLOC_FREE_STRUCT
    {

        /// _MALLOC_FREE_STRUCT_pfnAllocate
        public _MALLOC_FREE_STRUCT_pfnAllocate AnonymousMember1;

        /// _MALLOC_FREE_STRUCT_pfnFree
        public _MALLOC_FREE_STRUCT_pfnFree AnonymousMember2;
    }

}
