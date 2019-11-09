using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: void
    ///AllocationBase: PVOID->void*
    ///AllocationSize: SIZE_T->ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RTL_VERIFIER_NTDLLHEAPFREE_CALLBACK(IntPtr AllocationBase, uint AllocationSize);

    /// Return Type: void
    ///DllName: PWSTR->WCHAR*
    ///DllBase: PVOID->void*
    ///DllSize: SIZE_T->ULONG_PTR->unsigned int
    ///Reserved: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RTL_VERIFIER_DLL_UNLOAD_CALLBACK(IntPtr DllName, IntPtr DllBase, uint DllSize, IntPtr Reserved);

    /// Return Type: void
    ///DllName: PWSTR->WCHAR*
    ///DllBase: PVOID->void*
    ///DllSize: SIZE_T->ULONG_PTR->unsigned int
    ///Reserved: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RTL_VERIFIER_DLL_LOAD_CALLBACK(IntPtr DllName, IntPtr DllBase, uint DllSize, IntPtr Reserved);

    /// Return Type: void
    ///pfnFilter: RPCLT_PDU_FILTER_FUNC
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void RPC_SETFILTER_FUNC(RPCLT_PDU_FILTER_FUNC pfnFilter);

    /// Return Type: void
    ///Context: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPC_SECURITY_CALLBACK_FN(IntPtr Context);

    /// Return Type: void
    ///ObjectUuid: UUID*
    ///TypeUuid: UUID*
    ///Status: RPC_STATUS*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPC_OBJECT_INQ_FN(ref GUID ObjectUuid, ref GUID TypeUuid, ref int Status);

    /// Return Type: RPC_STATUS->int
    ///RedirectorStage: RPC_HTTP_REDIRECTOR_STAGE->_RPC_HTTP_REDIRECTOR_STAGE
    ///ServerName: unsigned short*
    ///ServerPort: unsigned short*
    ///RemoteUser: unsigned short*
    ///AuthType: unsigned short*
    ///ResourceUuid: void*
    ///Metadata: void*
    ///SessionId: void*
    ///Interface: void*
    ///Reserved: void*
    ///Flags: unsigned int
    ///NewServerName: unsigned short**
    ///NewServerPort: unsigned short**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int RPC_NEW_HTTP_PROXY_CHANNEL(RPC_HTTP_REDIRECTOR_STAGE RedirectorStage, ref ushort ServerName, ref ushort ServerPort, ref ushort RemoteUser, ref ushort AuthType, IntPtr ResourceUuid, IntPtr Metadata, IntPtr SessionId, IntPtr Interface, IntPtr Reserved, uint Flags, ref IntPtr NewServerName, ref IntPtr NewServerPort);

    /// Return Type: int
    ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
    ///RequestedMgmtOperation: unsigned int
    ///Status: RPC_STATUS*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int RPC_MGMT_AUTHORIZATION_FN(IntPtr ClientBinding, uint RequestedMgmtOperation, ref int Status);

    /// Return Type: RPC_STATUS->int
    ///InterfaceUuid: RPC_IF_HANDLE->void*
    ///Context: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int RPC_IF_CALLBACK_FN(IntPtr InterfaceUuid, IntPtr Context);

    /// Return Type: void
    ///String: unsigned short*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPC_HTTP_PROXY_FREE_STRING(ref ushort String);

    /// Return Type: RPC_STATUS->int
    ///InterfaceId: UUID*
    ///InterfaceVersion: RPC_VERSION*
    ///ObjectId: UUID*
    ///Rpcpro: unsigned char*
    ///ppDestEndpoint: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int RPC_FORWARD_FUNCTION(ref GUID InterfaceId, ref RPC_VERSION InterfaceVersion, ref GUID ObjectId, IntPtr Rpcpro, ref IntPtr ppDestEndpoint);

    /// Return Type: void
    ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPC_DISPATCH_FUNCTION(ref RPC_MESSAGE Message);

    /// Return Type: void
    ///Ptr: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPC_CLIENT_FREE(IntPtr Ptr);

    /// Return Type: void*
    ///Size: size_t->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr RPC_CLIENT_ALLOC(IntPtr Size);

    /// Return Type: RPC_STATUS->int
    ///hWnd: void*
    ///Context: void*
    ///hSyncEvent: void*
    public delegate int RPC_BLOCKING_FN(IntPtr hWnd, IntPtr Context, IntPtr hSyncEvent);

    /// Return Type: void
    ///Arg: void*
    ///ServerPrincName: unsigned short*
    ///KeyVer: unsigned int
    ///Key: void**
    ///Status: RPC_STATUS*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPC_AUTH_KEY_RETRIEVAL_FN(IntPtr Arg, ref ushort ServerPrincName, uint KeyVer, ref IntPtr Key, ref int Status);

    public enum RPC_ADDRESS_CHANGE_TYPE
    {

        /// PROTOCOL_NOT_LOADED -> 1
        PROTOCOL_NOT_LOADED = 1,

        PROTOCOL_LOADED,

        PROTOCOL_ADDRESS_CHANGE,
    }

    /// Return Type: void
    ///arg: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPC_ADDRESS_CHANGE_FN(IntPtr arg);

    /// Return Type: void
    ///pAsync: _RPC_ASYNC_STATE*
    ///Context: void*
    ///Event: RPC_ASYNC_EVENT->_RPC_ASYNC_EVENT
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void RPCNOTIFICATION_ROUTINE(ref RPC_ASYNC_STATE pAsync, IntPtr Context, RPC_ASYNC_EVENT Event);

    /// Return Type: void
    ///Buffer: void*
    ///BufferLength: unsigned int
    ///fDatagram: int
    public delegate void RPCLT_PDU_FILTER_FUNC(IntPtr Buffer, uint BufferLength, int fDatagram);

    [StructLayout(LayoutKind.Sequential)]
    public struct RETRIEVAL_POINTERS_BUFFER
    {

        /// DWORD->unsigned int
        public uint ExtentCount;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingVcn;

        /// Anonymous_789d578d_d7a5_48ff_8fd4_02e9d00e01f2[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public Anonymous_789d578d_d7a5_48ff_8fd4_02e9d00e01f2[] Extents;
    }

    public enum ReplacesCorHdrNumericDefines
    {

        /// COMIMAGE_FLAGS_ILONLY -> 0x00000001
        COMIMAGE_FLAGS_ILONLY = 1,

        /// COMIMAGE_FLAGS_32BITREQUIRED -> 0x00000002
        COMIMAGE_FLAGS_32BITREQUIRED = 2,

        /// COMIMAGE_FLAGS_IL_LIBRARY -> 0x00000004
        COMIMAGE_FLAGS_IL_LIBRARY = 4,

        /// COMIMAGE_FLAGS_STRONGNAMESIGNED -> 0x00000008
        COMIMAGE_FLAGS_STRONGNAMESIGNED = 8,

        /// COMIMAGE_FLAGS_TRACKDEBUGDATA -> 0x00010000
        COMIMAGE_FLAGS_TRACKDEBUGDATA = 65536,

        /// COR_VERSION_MAJOR_V2 -> 2
        COR_VERSION_MAJOR_V2 = 2,

        /// COR_VERSION_MAJOR -> COR_VERSION_MAJOR_V2
        COR_VERSION_MAJOR = ReplacesCorHdrNumericDefines.COR_VERSION_MAJOR_V2,

        /// COR_VERSION_MINOR -> 0
        COR_VERSION_MINOR = 0,

        /// COR_DELETED_NAME_LENGTH -> 8
        COR_DELETED_NAME_LENGTH = 8,

        /// COR_VTABLEGAP_NAME_LENGTH -> 8
        COR_VTABLEGAP_NAME_LENGTH = 8,

        /// NATIVE_TYPE_MAX_CB -> 1
        NATIVE_TYPE_MAX_CB = 1,

        /// COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE -> 0xFF
        COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE = 255,

        /// IMAGE_COR_MIH_METHODRVA -> 0x01
        IMAGE_COR_MIH_METHODRVA = 1,

        /// IMAGE_COR_MIH_EHRVA -> 0x02
        IMAGE_COR_MIH_EHRVA = 2,

        /// IMAGE_COR_MIH_BASICBLOCK -> 0x08
        IMAGE_COR_MIH_BASICBLOCK = 8,

        /// COR_VTABLE_32BIT -> 0x01
        COR_VTABLE_32BIT = 1,

        /// COR_VTABLE_64BIT -> 0x02
        COR_VTABLE_64BIT = 2,

        /// COR_VTABLE_FROM_UNMANAGED -> 0x04
        COR_VTABLE_FROM_UNMANAGED = 4,

        /// COR_VTABLE_CALL_MOST_DERIVED -> 0x10
        COR_VTABLE_CALL_MOST_DERIVED = 16,

        /// IMAGE_COR_EATJ_THUNK_SIZE -> 32
        IMAGE_COR_EATJ_THUNK_SIZE = 32,

        /// MAX_CLASS_NAME -> 1024
        MAX_CLASS_NAME = 1024,

        /// MAX_PACKAGE_NAME -> 1024
        MAX_PACKAGE_NAME = 1024,
    }

    /// Return Type: int
    ///param0: LPCWSTR->WCHAR*
    ///param1: DWORD->unsigned int
    ///param2: LPCWSTR->WCHAR*
    ///param3: LPVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int REGISTERWORDENUMPROCW([In] [MarshalAs(UnmanagedType.LPWStr)] string param0, uint param1, [In] [MarshalAs(UnmanagedType.LPWStr)] string param2, IntPtr param3);

    /// Return Type: int
    ///param0: LPCSTR->CHAR*
    ///param1: DWORD->unsigned int
    ///param2: LPCSTR->CHAR*
    ///param3: LPVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int REGISTERWORDENUMPROCA([In] [MarshalAs(UnmanagedType.LPStr)] string param0, uint param1, [In] [MarshalAs(UnmanagedType.LPStr)] string param2, IntPtr param3);

    [StructLayout(LayoutKind.Sequential)]
    public struct RTL_VERIFIER_THUNK_DESCRIPTOR
    {

        /// PCHAR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ThunkName;

        /// PVOID->void*
        public IntPtr ThunkOldAddress;

        /// PVOID->void*
        public IntPtr ThunkNewAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RTL_VERIFIER_PROVIDER_DESCRIPTOR
    {

        /// DWORD->unsigned int
        public uint Length;

        /// PRTL_VERIFIER_DLL_DESCRIPTOR->_RTL_VERIFIER_DLL_DESCRIPTOR*
        public IntPtr ProviderDlls;

        /// RTL_VERIFIER_DLL_LOAD_CALLBACK
        public RTL_VERIFIER_DLL_LOAD_CALLBACK ProviderDllLoadCallback;

        /// RTL_VERIFIER_DLL_UNLOAD_CALLBACK
        public RTL_VERIFIER_DLL_UNLOAD_CALLBACK ProviderDllUnloadCallback;

        /// PWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string VerifierImage;

        /// DWORD->unsigned int
        public uint VerifierFlags;

        /// DWORD->unsigned int
        public uint VerifierDebug;

        /// PVOID->void*
        public IntPtr RtlpGetStackTraceAddress;

        /// PVOID->void*
        public IntPtr RtlpDebugPageHeapCreate;

        /// PVOID->void*
        public IntPtr RtlpDebugPageHeapDestroy;

        /// RTL_VERIFIER_NTDLLHEAPFREE_CALLBACK
        public RTL_VERIFIER_NTDLLHEAPFREE_CALLBACK ProviderNtdllHeapFreeCallback;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RTL_VERIFIER_DLL_DESCRIPTOR
    {

        /// PWCHAR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string DllName;

        /// DWORD->unsigned int
        public uint DllFlags;

        /// PVOID->void*
        public IntPtr DllAddress;

        /// PRTL_VERIFIER_THUNK_DESCRIPTOR->_RTL_VERIFIER_THUNK_DESCRIPTOR*
        public IntPtr DllThunks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RTL_RESOURCE_DEBUG
    {

        /// WORD->unsigned short
        public ushort Type;

        /// WORD->unsigned short
        public ushort CreatorBackTraceIndex;

        /// _RTL_CRITICAL_SECTION*
        public IntPtr CriticalSection;

        /// LIST_ENTRY->_LIST_ENTRY
        public LIST_ENTRY ProcessLocksList;

        /// DWORD->unsigned int
        public uint EntryCount;

        /// DWORD->unsigned int
        public uint ContentionCount;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] Spare;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct RTL_OSVERSIONINFOW
    {

        /// DWORD->unsigned int
        public uint dwOSVersionInfoSize;

        /// DWORD->unsigned int
        public uint dwMajorVersion;

        /// DWORD->unsigned int
        public uint dwMinorVersion;

        /// DWORD->unsigned int
        public uint dwBuildNumber;

        /// DWORD->unsigned int
        public uint dwPlatformId;

        /// WCHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct RTL_OSVERSIONINFOEXW
    {

        /// DWORD->unsigned int
        public uint dwOSVersionInfoSize;

        /// DWORD->unsigned int
        public uint dwMajorVersion;

        /// DWORD->unsigned int
        public uint dwMinorVersion;

        /// DWORD->unsigned int
        public uint dwBuildNumber;

        /// DWORD->unsigned int
        public uint dwPlatformId;

        /// WCHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;

        /// WORD->unsigned short
        public ushort wServicePackMajor;

        /// WORD->unsigned short
        public ushort wServicePackMinor;

        /// WORD->unsigned short
        public ushort wSuiteMask;

        /// BYTE->unsigned char
        public byte wProductType;

        /// BYTE->unsigned char
        public byte wReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RTL_CRITICAL_SECTION
    {

        /// PRTL_CRITICAL_SECTION_DEBUG->_RTL_CRITICAL_SECTION_DEBUG*
        public IntPtr DebugInfo;

        /// LONG->int
        public int LockCount;

        /// LONG->int
        public int RecursionCount;

        /// HANDLE->void*
        public IntPtr OwningThread;

        /// HANDLE->void*
        public IntPtr LockSemaphore;

        /// ULONG_PTR->unsigned int
        public uint SpinCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RSAPUBKEY
    {

        /// DWORD->unsigned int
        public uint magic;

        /// DWORD->unsigned int
        public uint bitlen;

        /// DWORD->unsigned int
        public uint pubexp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_VERSION
    {

        /// unsigned short
        public ushort MajorVersion;

        /// unsigned short
        public ushort MinorVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_TRANSFER_SYNTAX
    {

        /// UUID->GUID->_GUID
        public GUID Uuid;

        /// unsigned short
        public ushort VersMajor;

        /// unsigned short
        public ushort VersMinor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SYNTAX_IDENTIFIER
    {

        /// GUID->_GUID
        public GUID SyntaxGUID;

        /// RPC_VERSION->_RPC_VERSION
        public RPC_VERSION SyntaxVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_STATS_VECTOR
    {

        /// unsigned int
        public uint Count;

        /// unsigned int[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] Stats;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SERVER_INTERFACE
    {

        /// unsigned int
        public uint Length;

        /// RPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER
        public RPC_SYNTAX_IDENTIFIER InterfaceId;

        /// RPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER
        public RPC_SYNTAX_IDENTIFIER TransferSyntax;

        /// PRPC_DISPATCH_TABLE->Anonymous_85928cb1_3c2f_4778_a67e_bb37e326ae96*
        public IntPtr DispatchTable;

        /// unsigned int
        public uint RpcProtseqEndpointCount;

        /// PRPC_PROTSEQ_ENDPOINT->_RPC_PROTSEQ_ENDPOINT*
        public IntPtr RpcProtseqEndpoint;

        /// void*
        public IntPtr DefaultManagerEpv;

        /// void*
        public IntPtr InterpreterInfo;

        /// unsigned int
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SECURITY_QOS_V3_W
    {

        /// unsigned int
        public uint Version;

        /// unsigned int
        public uint Capabilities;

        /// unsigned int
        public uint IdentityTracking;

        /// unsigned int
        public uint ImpersonationType;

        /// unsigned int
        public uint AdditionalSecurityInfoType;

        /// Anonymous_17a38332_c2b3_4631_bf14_5a1ac15957d8
        public Anonymous_17a38332_c2b3_4631_bf14_5a1ac15957d8 u;

        /// void*
        public IntPtr Sid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SECURITY_QOS_V3_A
    {

        /// unsigned int
        public uint Version;

        /// unsigned int
        public uint Capabilities;

        /// unsigned int
        public uint IdentityTracking;

        /// unsigned int
        public uint ImpersonationType;

        /// unsigned int
        public uint AdditionalSecurityInfoType;

        /// Anonymous_38397079_17e2_45c2_94c5_3c954e09268b
        public Anonymous_38397079_17e2_45c2_94c5_3c954e09268b u;

        /// void*
        public IntPtr Sid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SECURITY_QOS_V2_W
    {

        /// unsigned int
        public uint Version;

        /// unsigned int
        public uint Capabilities;

        /// unsigned int
        public uint IdentityTracking;

        /// unsigned int
        public uint ImpersonationType;

        /// unsigned int
        public uint AdditionalSecurityInfoType;

        /// Anonymous_bb885a23_f7c8_4f21_b191_d872acbe3100
        public Anonymous_bb885a23_f7c8_4f21_b191_d872acbe3100 u;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SECURITY_QOS_V2_A
    {

        /// unsigned int
        public uint Version;

        /// unsigned int
        public uint Capabilities;

        /// unsigned int
        public uint IdentityTracking;

        /// unsigned int
        public uint ImpersonationType;

        /// unsigned int
        public uint AdditionalSecurityInfoType;

        /// Anonymous_93d0990e_9eb8_4bd9_a142_a1aae677f217
        public Anonymous_93d0990e_9eb8_4bd9_a142_a1aae677f217 u;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_SECURITY_QOS
    {

        /// unsigned int
        public uint Version;

        /// unsigned int
        public uint Capabilities;

        /// unsigned int
        public uint IdentityTracking;

        /// unsigned int
        public uint ImpersonationType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_PROTSEQ_VECTORW
    {

        /// unsigned int
        public uint Count;

        /// unsigned short*[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] Protseq;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_PROTSEQ_VECTORA
    {

        /// unsigned int
        public uint Count;

        /// unsigned char*[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] Protseq;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_PROTSEQ_ENDPOINT
    {

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string RpcProtocolSequence;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string Endpoint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_POLICY
    {

        /// unsigned int
        public uint Length;

        /// unsigned int
        public uint EndpointFlags;

        /// unsigned int
        public uint NICFlags;
    }

    public enum RPC_NOTIFICATION_TYPES
    {

        RpcNotificationTypeNone,

        RpcNotificationTypeEvent,

        RpcNotificationTypeApc,

        RpcNotificationTypeIoc,

        RpcNotificationTypeHwnd,

        RpcNotificationTypeCallback,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_MESSAGE
    {

        /// RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        public IntPtr Handle;

        /// unsigned int
        public uint DataRepresentation;

        /// void*
        public IntPtr Buffer;

        /// unsigned int
        public uint BufferLength;

        /// unsigned int
        public uint ProcNum;

        /// PRPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER*
        public IntPtr TransferSyntax;

        /// void*
        public IntPtr RpcInterfaceInformation;

        /// void*
        public IntPtr ReservedForRuntime;

        /// void*
        public IntPtr ManagerEpv;

        /// void*
        public IntPtr ImportContext;

        /// unsigned int
        public uint RpcFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_IMPORT_CONTEXT_P
    {

        /// RPC_NS_HANDLE->void*
        public IntPtr LookupContext;

        /// RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        public IntPtr ProposedHandle;

        /// RPC_BINDING_VECTOR*
        public IntPtr Bindings;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_IF_ID_VECTOR
    {

        /// unsigned int
        public uint Count;

        /// RPC_IF_ID*[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] IfId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_IF_ID
    {

        /// UUID->GUID->_GUID
        public GUID Uuid;

        /// unsigned short
        public ushort VersMajor;

        /// unsigned short
        public ushort VersMinor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_HTTP_TRANSPORT_CREDENTIALS_W
    {

        /// SEC_WINNT_AUTH_IDENTITY_W*
        public IntPtr TransportCredentials;

        /// unsigned int
        public uint Flags;

        /// unsigned int
        public uint AuthenticationTarget;

        /// unsigned int
        public uint NumberOfAuthnSchemes;

        /// unsigned int*
        public IntPtr AuthnSchemes;

        /// unsigned short*
        public IntPtr ServerCertificateSubject;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_HTTP_TRANSPORT_CREDENTIALS_A
    {

        /// SEC_WINNT_AUTH_IDENTITY_A*
        public IntPtr TransportCredentials;

        /// unsigned int
        public uint Flags;

        /// unsigned int
        public uint AuthenticationTarget;

        /// unsigned int
        public uint NumberOfAuthnSchemes;

        /// unsigned int*
        public IntPtr AuthnSchemes;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ServerCertificateSubject;
    }

    public enum RPC_HTTP_REDIRECTOR_STAGE
    {

        /// RPCHTTP_RS_REDIRECT -> 1
        RPCHTTP_RS_REDIRECT = 1,

        RPCHTTP_RS_ACCESS_1,

        RPCHTTP_RS_SESSION,

        RPCHTTP_RS_ACCESS_2,

        RPCHTTP_RS_INTERFACE,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_DISPATCH_TABLE
    {

        /// unsigned int
        public uint DispatchTableCount;

        /// RPC_DISPATCH_FUNCTION*
        public IntPtr DispatchTable;

        /// LONG_PTR->int
        public int Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_C_OPT_METADATA_DESCRIPTOR
    {

        /// unsigned int
        public uint BufferSize;

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string Buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_CLIENT_INTERFACE
    {

        /// unsigned int
        public uint Length;

        /// RPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER
        public RPC_SYNTAX_IDENTIFIER InterfaceId;

        /// RPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER
        public RPC_SYNTAX_IDENTIFIER TransferSyntax;

        /// PRPC_DISPATCH_TABLE->Anonymous_85928cb1_3c2f_4778_a67e_bb37e326ae96*
        public IntPtr DispatchTable;

        /// unsigned int
        public uint RpcProtseqEndpointCount;

        /// PRPC_PROTSEQ_ENDPOINT->_RPC_PROTSEQ_ENDPOINT*
        public IntPtr RpcProtseqEndpoint;

        /// ULONG_PTR->unsigned int
        public uint Reserved;

        /// void*
        public IntPtr InterpreterInfo;

        /// unsigned int
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_CLIENT_INFORMATION1
    {

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string UserName;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ComputerName;

        /// unsigned short
        public ushort Privilege;

        /// unsigned int
        public uint AuthFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_BINDING_VECTOR
    {

        /// unsigned int
        public uint Count;

        /// RPC_BINDING_HANDLE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] BindingH;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RPC_ASYNC_STATE
    {

        /// unsigned int
        public uint Size;

        /// unsigned int
        public uint Signature;

        /// int
        public int Lock;

        /// unsigned int
        public uint Flags;

        /// void*
        public IntPtr StubInfo;

        /// void*
        public IntPtr UserInfo;

        /// void*
        public IntPtr RuntimeInfo;

        /// RPC_ASYNC_EVENT->_RPC_ASYNC_EVENT
        public RPC_ASYNC_EVENT Event;

        /// RPC_NOTIFICATION_TYPES->_RPC_NOTIFICATION_TYPES
        public RPC_NOTIFICATION_TYPES NotificationType;

        /// Anonymous_1d792489_fdc0_40ba_bfc7_71924b76616a
        public Anonymous_1d792489_fdc0_40ba_bfc7_71924b76616a u;

        /// LONG_PTR[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
        public int[] Reserved;
    }

    public enum RPC_ASYNC_EVENT
    {

        RpcCallComplete,

        RpcSendComplete,

        RpcReceiveComplete,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RIP_INFO
    {

        /// DWORD->unsigned int
        public uint dwError;

        /// DWORD->unsigned int
        public uint dwType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RGNDATAHEADER
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint iType;

        /// DWORD->unsigned int
        public uint nCount;

        /// DWORD->unsigned int
        public uint nRgnSize;

        /// RECT->tagRECT
        public tagRECT rcBound;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RGNDATA
    {

        /// RGNDATAHEADER->_RGNDATAHEADER
        public RGNDATAHEADER rdh;

        /// char[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string Buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REQUEST_RAW_ENCRYPTED_DATA
    {

        /// LONGLONG->__int64
        public long FileOffset;

        /// DWORD->unsigned int
        public uint Length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REPARSE_GUID_DATA_BUFFER
    {

        /// DWORD->unsigned int
        public uint ReparseTag;

        /// WORD->unsigned short
        public ushort ReparseDataLength;

        /// WORD->unsigned short
        public ushort Reserved;

        /// GUID->_GUID
        public GUID ReparseGuid;

        /// Anonymous_9cd09bf7_d4f4_42f0_9f48_4c04295a4c4f
        public Anonymous_9cd09bf7_d4f4_42f0_9f48_4c04295a4c4f GenericReparseBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REMSECURITY_ATTRIBUTES
    {

        /// DWORD->unsigned int
        public uint nLength;

        /// DWORD->unsigned int
        public uint lpSecurityDescriptor;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bInheritHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REMOTE_NAME_INFOW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpUniversalName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpConnectionName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpRemainingPath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REMOTE_NAME_INFOA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpUniversalName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpConnectionName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpRemainingPath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct remoteMETAFILEPICT
    {

        /// int
        public int mm;

        /// int
        public int xExt;

        /// int
        public int yExt;

        /// userHMETAFILE*
        public IntPtr hMF;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RemotableHandle
    {

        /// int
        public int fContext;

        /// _RemotableHandle___MIDL_IWinTypes_0009
        public _RemotableHandle___MIDL_IWinTypes_0009 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RemBINDINFO
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szExtraInfo;

        /// DWORD->unsigned int
        public uint grfBindInfoF;

        /// DWORD->unsigned int
        public uint dwBindVerb;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szCustomVerb;

        /// DWORD->unsigned int
        public uint cbstgmedData;

        /// DWORD->unsigned int
        public uint dwOptions;

        /// DWORD->unsigned int
        public uint dwOptionsFlags;

        /// DWORD->unsigned int
        public uint dwCodePage;

        /// REMSECURITY_ATTRIBUTES->_REMSECURITY_ATTRIBUTES
        public REMSECURITY_ATTRIBUTES securityAttributes;

        /// IID->GUID->_GUID
        public GUID iid;

        /// IUnknown*
        public IntPtr pUnk;

        /// DWORD->unsigned int
        public uint dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECTL
    {

        /// LONG->int
        public int left;

        /// LONG->int
        public int top;

        /// LONG->int
        public int right;

        /// LONG->int
        public int bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REASSIGN_BLOCKS_EX
    {

        /// WORD->unsigned short
        public ushort Reserved;

        /// WORD->unsigned short
        public ushort Count;

        /// LARGE_INTEGER[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public LARGE_INTEGER[] BlockNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct REASSIGN_BLOCKS
    {

        /// WORD->unsigned short
        public ushort Reserved;

        /// WORD->unsigned short
        public ushort Count;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] BlockNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct READ_USN_JOURNAL_DATA
    {

        /// USN->LONGLONG->__int64
        public long StartUsn;

        /// DWORD->unsigned int
        public uint ReasonMask;

        /// DWORD->unsigned int
        public uint ReturnOnlyOnClose;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong Timeout;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong BytesToWaitFor;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong UsnJournalID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct READ_ELEMENT_ADDRESS_INFO
    {

        /// DWORD->unsigned int
        public uint NumberOfElements;

        /// CHANGER_ELEMENT_STATUS[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public CHANGER_ELEMENT_STATUS[] ElementStatus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RDR_CALLOUT_STATE
    {

        /// RPC_STATUS->int
        public int LastError;

        /// void*
        public IntPtr LastEEInfo;

        /// RPC_HTTP_REDIRECTOR_STAGE->_RPC_HTTP_REDIRECTOR_STAGE
        public RPC_HTTP_REDIRECTOR_STAGE LastCalledStage;

        /// unsigned short*
        public IntPtr ServerName;

        /// unsigned short*
        public IntPtr ServerPort;

        /// unsigned short*
        public IntPtr RemoteUser;

        /// unsigned short*
        public IntPtr AuthType;

        /// unsigned char
        public byte ResourceTypePresent;

        /// unsigned char
        public byte MetadataPresent;

        /// unsigned char
        public byte SessionIdPresent;

        /// unsigned char
        public byte InterfacePresent;

        /// UUID->GUID->_GUID
        public GUID ResourceType;

        /// RPC_C_OPT_METADATA_DESCRIPTOR->_RPC_C_OPT_METADATA_DESCRIPTOR
        public RPC_C_OPT_METADATA_DESCRIPTOR Metadata;

        /// UUID->GUID->_GUID
        public GUID SessionId;

        /// RPC_SYNTAX_IDENTIFIER->_RPC_SYNTAX_IDENTIFIER
        public RPC_SYNTAX_IDENTIFIER Interface;

        /// void*
        public IntPtr CertContext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RASTERIZER_STATUS
    {

        /// short
        public short nSize;

        /// short
        public short wFlags;

        /// short
        public short nLanguageID;
    }

}
