using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;
using FILETIME = NWin32.NativeTypes.FILETIME;
using IServiceProvider = NWin32.NativeTypes.IServiceProvider;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: RPC_STATUS->int
        ///Uuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "I_UuidCreate", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_UuidCreate(ref GUID Uuid);


        /// Return Type: unsigned int
        ///hWnd: void*
        ///Message: unsigned int
        ///wParam: unsigned int
        ///lParam: unsigned int
        [DllImport("<Unknown>", EntryPoint = "I_RpcWindowProc", CallingConvention = CallingConvention.StdCall)]
        public static extern uint I_RpcWindowProc(IntPtr hWnd, uint Message, uint wParam, uint lParam);


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcTurnOnEEInfoPropagation", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcTurnOnEEInfoPropagation();


        /// Return Type: RPC_STATUS->int
        ///Handle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "I_RpcStopMonitorAssociation", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcStopMonitorAssociation(IntPtr Handle);


        /// Return Type: void
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcSsDontSerializeContext", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcSsDontSerializeContext();


        /// Return Type: RPC_STATUS->int
        ///fClientFree: int
        ///Context: void*
        ///hWndClient: void*
        [DllImport("<Unknown>", EntryPoint = "I_RpcSetThreadParams", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcSetThreadParams(int fClientFree, IntPtr Context, IntPtr hWndClient);


        /// Return Type: void
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerContextList: void*
        [DllImport("<Unknown>", EntryPoint = "I_RpcSetServerContextList", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcSetServerContextList(IntPtr BindingHandle, IntPtr ServerContextList);


        /// Return Type: void
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcSessionStrictContextHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcSessionStrictContextHandle();


        /// Return Type: RPC_STATUS->int
        ///NetworkAddress: RPC_WSTR->unsigned short*
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///Endpoint: RPC_WSTR->unsigned short*
        ///SecurityDescriptor: void*
        ///Policy: void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerUseProtseqEp2W", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerUseProtseqEp2W([In] ref ushort NetworkAddress, [In] ref ushort Protseq, uint MaxCalls, [In] ref ushort Endpoint, [In] IntPtr SecurityDescriptor, [In] IntPtr Policy);


        /// Return Type: RPC_STATUS->int
        ///NetworkAddress: RPC_CSTR->unsigned char*
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///Endpoint: RPC_CSTR->unsigned char*
        ///SecurityDescriptor: void*
        ///Policy: void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerUseProtseqEp2A", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerUseProtseqEp2A([In] [MarshalAs(UnmanagedType.LPStr)] string NetworkAddress, [In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] [MarshalAs(UnmanagedType.LPStr)] string Endpoint, [In] IntPtr SecurityDescriptor, [In] IntPtr Policy);


        /// Return Type: RPC_STATUS->int
        ///NetworkAddress: RPC_WSTR->unsigned short*
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        ///Policy: void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerUseProtseq2W", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerUseProtseq2W([In] ref ushort NetworkAddress, [In] ref ushort Protseq, uint MaxCalls, [In] IntPtr SecurityDescriptor, [In] IntPtr Policy);


        /// Return Type: RPC_STATUS->int
        ///NetworkAddress: RPC_CSTR->unsigned char*
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        ///Policy: void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerUseProtseq2A", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerUseProtseq2A([In] [MarshalAs(UnmanagedType.LPStr)] string NetworkAddress, [In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] IntPtr SecurityDescriptor, [In] IntPtr Policy);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        ///Endpoint: RPC_WSTR->unsigned short*
        [DllImport("<Unknown>", EntryPoint = "I_RpcServerUnregisterEndpointW", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerUnregisterEndpointW([In] ref ushort Protseq, [In] ref ushort Endpoint);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        ///Endpoint: RPC_CSTR->unsigned char*
        [DllImport("<Unknown>", EntryPoint = "I_RpcServerUnregisterEndpointA", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerUnregisterEndpointA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, [In] [MarshalAs(UnmanagedType.LPStr)] string Endpoint);


        /// Return Type: RPC_STATUS->int
        [DllImport("<Unknown>", EntryPoint = "I_RpcServerStopListening", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerStopListening();


        /// Return Type: RPC_STATUS->int
        ///hWnd: void*
        [DllImport("<Unknown>", EntryPoint = "I_RpcServerStartListening", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerStartListening(IntPtr hWnd);


        /// Return Type: RPC_STATUS->int
        ///pAddressChangeFn: RPC_ADDRESS_CHANGE_FN*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerSetAddressChangeFn", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerSetAddressChangeFn(ref RPC_ADDRESS_CHANGE_FN pAddressChangeFn);


        /// Return Type: RPC_STATUS->int
        ///pForwardFunction: RPC_FORWARD_FUNCTION*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerRegisterForwardFunction", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerRegisterForwardFunction(ref RPC_FORWARD_FUNCTION pForwardFunction);


        /// Return Type: RPC_STATUS->int
        ///Type: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerInqTransportType", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerInqTransportType(ref uint Type);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Buffer: void*
        ///BufferSize: unsigned int*
        ///AddressFormat: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerInqLocalConnAddress", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerInqLocalConnAddress(IntPtr Binding, IntPtr Buffer, ref uint BufferSize, ref uint AddressFormat);


        /// Return Type: RPC_ADDRESS_CHANGE_FN*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerInqAddressChangeFn", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr I_RpcServerInqAddressChangeFn();


        /// Return Type: RPC_STATUS->int
        ///Context: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcServerCheckClientRestriction", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcServerCheckClientRestriction(IntPtr Context);


        /// Return Type: RPC_STATUS->int
        ///Message: RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcSendReceive", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcSendReceive(ref RPC_MESSAGE Message);


        /// Return Type: RPC_STATUS->int
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcSend", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcSend(ref RPC_MESSAGE Message);


        /// Return Type: void
        ///Mutex: I_RPC_MUTEX*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcRequestMutex", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcRequestMutex(ref IntPtr Mutex);


        /// Return Type: RPC_STATUS->int
        ///ConnectionParameter: void*
        ///RpcStatus: RPC_STATUS->int
        [DllImport("<Unknown>", EntryPoint = "I_RpcReplyToClientWithStatus", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcReplyToClientWithStatus(IntPtr ConnectionParameter, int RpcStatus);


        /// Return Type: void
        ///RpcStatus: RPC_STATUS->int
        ///CallOutState: RDR_CALLOUT_STATE*
        ///DllName: unsigned short*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcRecordCalloutFailure", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcRecordCalloutFailure(int RpcStatus, ref RDR_CALLOUT_STATE CallOutState, ref ushort DllName);


        /// Return Type: RPC_STATUS->int
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        ///Size: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcReceive", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcReceive(ref RPC_MESSAGE Message, uint Size);


        /// Return Type: RPC_STATUS->int
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcns4.dll", EntryPoint = "I_RpcReBindBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcReBindBuffer(ref RPC_MESSAGE Message);


        /// Return Type: RPC_STATUS->int
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        ///NewSize: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcReallocPipeBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcReallocPipeBuffer(ref RPC_MESSAGE Message, uint NewSize);


        /// Return Type: RPC_STATUS->int
        ///ConnectionType: unsigned int
        ///ServerAddress: unsigned short*
        ///ServerPort: unsigned short*
        ///MinConnTimeout: unsigned short*
        ///ConnectionParameter: void*
        ///CallOutState: RDR_CALLOUT_STATE*
        ///ProxyCallbackInterface: I_RpcProxyCallbackInterface*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcProxyNewConnection", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcProxyNewConnection(uint ConnectionType, ref ushort ServerAddress, ref ushort ServerPort, ref ushort MinConnTimeout, IntPtr ConnectionParameter, ref RDR_CALLOUT_STATE CallOutState, ref tagI_RpcProxyCallbackInterface ProxyCallbackInterface);


        /// Return Type: void
        ///Milliseconds: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcPauseExecution", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcPauseExecution(uint Milliseconds);


        /// Return Type: RPC_STATUS->int
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        ///Handle: RPC_BINDING_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "I_RpcNsSendReceive", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcNsSendReceive(ref RPC_MESSAGE Message, ref IntPtr Handle);


        /// Return Type: void
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        ///Status: RPC_STATUS->int
        [DllImport("rpcns4.dll", EntryPoint = "I_RpcNsRaiseException", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcNsRaiseException(ref RPC_MESSAGE Message, int Status);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: unsigned short*
        ///RpcInterfaceInformation: RPC_SERVER_INTERFACE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcNsInterfaceUnexported", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcNsInterfaceUnexported(uint EntryNameSyntax, ref ushort EntryName, ref RPC_SERVER_INTERFACE RpcInterfaceInformation);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: unsigned short*
        ///RpcInterfaceInformation: RPC_SERVER_INTERFACE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcNsInterfaceExported", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcNsInterfaceExported(uint EntryNameSyntax, ref ushort EntryName, ref RPC_SERVER_INTERFACE RpcInterfaceInformation);


        /// Return Type: RPC_STATUS->int
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcns4.dll", EntryPoint = "I_RpcNsGetBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcNsGetBuffer(ref RPC_MESSAGE Message);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcNsBindingSetEntryNameW", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcNsBindingSetEntryNameW([In] IntPtr Binding, uint EntryNameSyntax, [In] ref ushort EntryName);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcNsBindingSetEntryNameA", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcNsBindingSetEntryNameA([In] IntPtr Binding, uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName);


        /// Return Type: RPC_STATUS->int
        ///Message: RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcNegotiateTransferSyntax", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcNegotiateTransferSyntax(ref RPC_MESSAGE Message);


        /// Return Type: RPC_STATUS->int
        ///Handle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///RundownRoutine: PRPC_RUNDOWN
        ///Context: void*
        [DllImport("<Unknown>", EntryPoint = "I_RpcMonitorAssociation", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcMonitorAssociation(IntPtr Handle, PRPC_RUNDOWN RundownRoutine, IntPtr Context);


        /// Return Type: int
        ///Status: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcMapWin32Status", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcMapWin32Status(int Status);


        /// Return Type: RPC_STATUS->int
        ///pAddress: void*
        [DllImport("<Unknown>", EntryPoint = "I_RpcLaunchDatagramReceiveThread", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcLaunchDatagramReceiveThread(IntPtr pAddress);


        /// Return Type: RPC_STATUS->int
        ///RpcIfHandle: RPC_IF_HANDLE->void*
        ///TransferSyntaxes: RPC_TRANSFER_SYNTAX*
        ///TransferSyntaxSize: unsigned int
        ///TransferSyntaxCount: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcIfInqTransferSyntaxes", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcIfInqTransferSyntaxes(IntPtr RpcIfHandle, ref RPC_TRANSFER_SYNTAX TransferSyntaxes, uint TransferSyntaxSize, ref uint TransferSyntaxCount);


        /// Return Type: void*
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "I_RpcGetServerContextList", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr I_RpcGetServerContextList(IntPtr BindingHandle);


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcGetExtendedError", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcGetExtendedError();


        /// Return Type: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcGetCurrentCallHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr I_RpcGetCurrentCallHandle();


        /// Return Type: RPC_STATUS->int
        ///Message: RPC_MESSAGE*
        ///ObjectUuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcGetBufferWithObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcGetBufferWithObject(ref RPC_MESSAGE Message, ref GUID ObjectUuid);


        /// Return Type: RPC_STATUS->int
        ///Message: RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcGetBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcGetBuffer(ref RPC_MESSAGE Message);


        /// Return Type: RPC_STATUS->int
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///AssociationContext: void**
        [DllImport("<Unknown>", EntryPoint = "I_RpcGetAssociationContext", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcGetAssociationContext(IntPtr BindingHandle, ref IntPtr AssociationContext);


        /// Return Type: RPC_STATUS->int
        ///Message: RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcFreePipeBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcFreePipeBuffer(ref RPC_MESSAGE Message);


        /// Return Type: RPC_STATUS->int
        ///Message: RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcFreeBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcFreeBuffer(ref RPC_MESSAGE Message);


        /// Return Type: void
        ///Object: void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcFree(IntPtr Object);


        /// Return Type: int
        ///ExceptionCode: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcExceptionFilter", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcExceptionFilter(uint ExceptionCode);


        /// Return Type: void
        ///Mutex: I_RPC_MUTEX->void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcDeleteMutex", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcDeleteMutex(IntPtr Mutex);


        /// Return Type: RPC_STATUS->int
        ///RecvBuffSize: unsigned int
        ///SendBuffSize: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcConnectionSetSockBuffSize", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcConnectionSetSockBuffSize(uint RecvBuffSize, uint SendBuffSize);


        /// Return Type: RPC_STATUS->int
        ///RecvBuffSize: unsigned int*
        ///SendBuffSize: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcConnectionInqSockBuffSize", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcConnectionInqSockBuffSize(ref uint RecvBuffSize, ref uint SendBuffSize);


        /// Return Type: void
        ///Mutex: I_RPC_MUTEX->void*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcClearMutex", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_RpcClearMutex(IntPtr Mutex);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///StringBinding: unsigned short**
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingToStaticStringBindingW", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingToStaticStringBindingW(IntPtr Binding, ref IntPtr StringBinding);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///BlockingFn: RPC_BLOCKING_FN
        ///ServerTid: unsigned int
        [DllImport("<Unknown>", EntryPoint = "I_RpcBindingSetAsync", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingSetAsync(IntPtr Binding, RPC_BLOCKING_FN BlockingFn, uint ServerTid);


        /// Return Type: RPC_STATUS->int
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ClientLocalFlag: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingIsClientLocal", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingIsClientLocal(IntPtr BindingHandle, ref uint ClientLocalFlag);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///WireId: RPC_CSTR->unsigned char*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqWireIdForSnego", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqWireIdForSnego([In] IntPtr Binding, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder WireId);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Type: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqTransportType", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqTransportType(IntPtr Binding, ref uint Type);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///SecurityContextHandle: void**
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqSecurityContext", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqSecurityContext(IntPtr Binding, ref IntPtr SecurityContextHandle);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///MarshalledTargetInfoLength: unsigned int*
        ///MarshalledTargetInfo: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqMarshalledTargetInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqMarshalledTargetInfo([In] IntPtr Binding, [Out] out uint MarshalledTargetInfoLength, ref IntPtr MarshalledTargetInfo);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Pid: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqLocalClientPID", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqLocalClientPID(IntPtr Binding, ref uint Pid);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///DynamicEndpoint: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqDynamicEndpointW", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqDynamicEndpointW([In] IntPtr Binding, ref IntPtr DynamicEndpoint);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///DynamicEndpoint: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqDynamicEndpointA", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqDynamicEndpointA([In] IntPtr Binding, ref IntPtr DynamicEndpoint);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ConnId: void**
        ///pfFirstCall: int*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingInqConnId", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingInqConnId(IntPtr Binding, ref IntPtr ConnId, ref int pfFirstCall);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///AsyncHandle: void**
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingHandleToAsyncHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingHandleToAsyncHandle(IntPtr Binding, ref IntPtr AsyncHandle);


        /// Return Type: RPC_STATUS->int
        ///SourceBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///DestinationBinding: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcBindingCopy", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcBindingCopy(IntPtr SourceBinding, ref IntPtr DestinationBinding);


        /// Return Type: RPC_STATUS->int
        ///Message: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcAsyncSetHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcAsyncSetHandle(ref RPC_MESSAGE Message, ref RPC_ASYNC_STATE pAsync);


        /// Return Type: RPC_STATUS->int
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        ///ExceptionCode: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcAsyncAbortCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_RpcAsyncAbortCall(ref RPC_ASYNC_STATE pAsync, uint ExceptionCode);


        /// Return Type: void*
        ///Size: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "I_RpcAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr I_RpcAllocate(uint Size);


        /// Return Type: RPC_STATUS->int
        [DllImport("<Unknown>", EntryPoint = "I_NsServerBindSearch", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_NsServerBindSearch();


        /// Return Type: RPC_STATUS->int
        [DllImport("<Unknown>", EntryPoint = "I_NsClientBindSearch", CallingConvention = CallingConvention.StdCall)]
        public static extern int I_NsClientBindSearch();


        /// Return Type: void
        [DllImport("<Unknown>", EntryPoint = "I_NsClientBindDone", CallingConvention = CallingConvention.StdCall)]
        public static extern void I_NsClientBindDone();


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IZoneIdentifier_SetId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IZoneIdentifier_SetId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IZoneIdentifier*
        ///dwZone: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IZoneIdentifier_SetId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IZoneIdentifier_SetId_Proxy(ref IZoneIdentifier This, uint dwZone);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IZoneIdentifier_Remove_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IZoneIdentifier_Remove_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IZoneIdentifier*
        [DllImport("<Unknown>", EntryPoint = "IZoneIdentifier_Remove_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IZoneIdentifier_Remove_Proxy(ref IZoneIdentifier This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IZoneIdentifier_GetId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IZoneIdentifier_GetId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IZoneIdentifier*
        ///pdwZone: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IZoneIdentifier_GetId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IZoneIdentifier_GetId_Proxy(ref IZoneIdentifier This, ref uint pdwZone);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_uniqueID_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_uniqueID_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///pNode: IXMLDOMNode*
        ///pID: int*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_uniqueID_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_uniqueID_Proxy(ref IXTLRuntime This, ref IXMLDOMNode pNode, ref int pID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatTime_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_formatTime_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///varTime: VARIANT->tagVARIANT
        ///bstrFormat: BSTR->OLECHAR*
        ///varDestLocale: VARIANT->tagVARIANT
        ///pbstrFormattedString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatTime_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_formatTime_Proxy(ref IXTLRuntime This, tagVARIANT varTime, [MarshalAs(UnmanagedType.BStr)] string bstrFormat, tagVARIANT varDestLocale, [MarshalAs(UnmanagedType.BStr)] ref string pbstrFormattedString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatNumber_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_formatNumber_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///dblNumber: double
        ///bstrFormat: BSTR->OLECHAR*
        ///pbstrFormattedString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatNumber_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_formatNumber_Proxy(ref IXTLRuntime This, double dblNumber, [MarshalAs(UnmanagedType.BStr)] string bstrFormat, [MarshalAs(UnmanagedType.BStr)] ref string pbstrFormattedString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatIndex_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_formatIndex_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///lIndex: int
        ///bstrFormat: BSTR->OLECHAR*
        ///pbstrFormattedString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatIndex_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_formatIndex_Proxy(ref IXTLRuntime This, int lIndex, [MarshalAs(UnmanagedType.BStr)] string bstrFormat, [MarshalAs(UnmanagedType.BStr)] ref string pbstrFormattedString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatDate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_formatDate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///varDate: VARIANT->tagVARIANT
        ///bstrFormat: BSTR->OLECHAR*
        ///varDestLocale: VARIANT->tagVARIANT
        ///pbstrFormattedString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_formatDate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_formatDate_Proxy(ref IXTLRuntime This, tagVARIANT varDate, [MarshalAs(UnmanagedType.BStr)] string bstrFormat, tagVARIANT varDestLocale, [MarshalAs(UnmanagedType.BStr)] ref string pbstrFormattedString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_depth_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_depth_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///pNode: IXMLDOMNode*
        ///pDepth: int*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_depth_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_depth_Proxy(ref IXTLRuntime This, ref IXMLDOMNode pNode, ref int pDepth);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_childNumber_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_childNumber_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///pNode: IXMLDOMNode*
        ///pNumber: int*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_childNumber_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_childNumber_Proxy(ref IXTLRuntime This, ref IXMLDOMNode pNode, ref int pNumber);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_ancestorChildNumber_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_ancestorChildNumber_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///bstrNodeName: BSTR->OLECHAR*
        ///pNode: IXMLDOMNode*
        ///pNumber: int*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_ancestorChildNumber_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_ancestorChildNumber_Proxy(ref IXTLRuntime This, [MarshalAs(UnmanagedType.BStr)] string bstrNodeName, ref IXMLDOMNode pNode, ref int pNumber);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_absoluteChildNumber_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXTLRuntime_absoluteChildNumber_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXTLRuntime*
        ///pNode: IXMLDOMNode*
        ///pNumber: int*
        [DllImport("<Unknown>", EntryPoint = "IXTLRuntime_absoluteChildNumber_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXTLRuntime_absoluteChildNumber_Proxy(ref IXTLRuntime This, ref IXMLDOMNode pNode, ref int pNumber);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_setRequestHeader_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_setRequestHeader_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///bstrHeader: BSTR->OLECHAR*
        ///bstrValue: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_setRequestHeader_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_setRequestHeader_Proxy(ref IXMLHttpRequest This, [MarshalAs(UnmanagedType.BStr)] string bstrHeader, [MarshalAs(UnmanagedType.BStr)] string bstrValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_send_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_send_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///varBody: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_send_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_send_Proxy(ref IXMLHttpRequest This, tagVARIANT varBody);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_put_onreadystatechange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_put_onreadystatechange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///pReadyStateSink: IDispatch*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_put_onreadystatechange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_put_onreadystatechange_Proxy(ref IXMLHttpRequest This, ref IDispatch pReadyStateSink);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_open_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_open_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///bstrMethod: BSTR->OLECHAR*
        ///bstrUrl: BSTR->OLECHAR*
        ///varAsync: VARIANT->tagVARIANT
        ///bstrUser: VARIANT->tagVARIANT
        ///bstrPassword: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_open_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_open_Proxy(ref IXMLHttpRequest This, [MarshalAs(UnmanagedType.BStr)] string bstrMethod, [MarshalAs(UnmanagedType.BStr)] string bstrUrl, tagVARIANT varAsync, tagVARIANT bstrUser, tagVARIANT bstrPassword);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_status_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_get_status_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///plStatus: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_status_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_get_status_Proxy(ref IXMLHttpRequest This, ref int plStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_statusText_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_get_statusText_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///pbstrStatus: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_statusText_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_get_statusText_Proxy(ref IXMLHttpRequest This, [MarshalAs(UnmanagedType.BStr)] ref string pbstrStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseXML_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_get_responseXML_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///ppBody: IDispatch**
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseXML_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_get_responseXML_Proxy(ref IXMLHttpRequest This, ref IntPtr ppBody);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseText_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_get_responseText_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///pbstrBody: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseText_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_get_responseText_Proxy(ref IXMLHttpRequest This, [MarshalAs(UnmanagedType.BStr)] ref string pbstrBody);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseStream_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_get_responseStream_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///pvarBody: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseStream_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_get_responseStream_Proxy(ref IXMLHttpRequest This, ref tagVARIANT pvarBody);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseBody_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_get_responseBody_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///pvarBody: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_responseBody_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_get_responseBody_Proxy(ref IXMLHttpRequest This, ref tagVARIANT pvarBody);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_readyState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_get_readyState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///plState: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_get_readyState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_get_readyState_Proxy(ref IXMLHttpRequest This, ref int plState);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_getResponseHeader_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_getResponseHeader_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///bstrHeader: BSTR->OLECHAR*
        ///pbstrValue: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_getResponseHeader_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_getResponseHeader_Proxy(ref IXMLHttpRequest This, [MarshalAs(UnmanagedType.BStr)] string bstrHeader, [MarshalAs(UnmanagedType.BStr)] ref string pbstrValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_getAllResponseHeaders_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_getAllResponseHeaders_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        ///pbstrHeaders: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_getAllResponseHeaders_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_getAllResponseHeaders_Proxy(ref IXMLHttpRequest This, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHeaders);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_abort_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLHttpRequest_abort_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLHttpRequest*
        [DllImport("<Unknown>", EntryPoint = "IXMLHttpRequest_abort_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLHttpRequest_abort_Proxy(ref IXMLHttpRequest This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLError_GetErrorInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLError_GetErrorInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLError*
        ///pErrorReturn: XML_ERROR*
        [DllImport("<Unknown>", EntryPoint = "IXMLError_GetErrorInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLError_GetErrorInfo_Proxy(ref IXMLError This, ref XML_ERROR pErrorReturn);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_setAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_setAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///strPropertyName: BSTR->OLECHAR*
        ///PropertyValue: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_setAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_setAttribute_Proxy(ref IXMLElement This, [MarshalAs(UnmanagedType.BStr)] string strPropertyName, tagVARIANT PropertyValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_removeChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_removeChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///pChildElem: IXMLElement*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_removeChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_removeChild_Proxy(ref IXMLElement This, ref IXMLElement pChildElem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_removeAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_removeAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///strPropertyName: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_removeAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_removeAttribute_Proxy(ref IXMLElement This, [MarshalAs(UnmanagedType.BStr)] string strPropertyName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_put_text_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_put_text_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_put_text_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_put_text_Proxy(ref IXMLElement This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_put_tagName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_put_tagName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_put_tagName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_put_tagName_Proxy(ref IXMLElement This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_type_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_get_type_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///plType: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_type_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_get_type_Proxy(ref IXMLElement This, ref int plType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_text_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_get_text_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_text_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_get_text_Proxy(ref IXMLElement This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_tagName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_get_tagName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_tagName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_get_tagName_Proxy(ref IXMLElement This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_parent_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_get_parent_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///ppParent: IXMLElement**
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_parent_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_get_parent_Proxy(ref IXMLElement This, ref IntPtr ppParent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_children_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_get_children_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///pp: IXMLElementCollection**
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_get_children_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_get_children_Proxy(ref IXMLElement This, ref IntPtr pp);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_getAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_getAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///strPropertyName: BSTR->OLECHAR*
        ///PropertyValue: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_getAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_getAttribute_Proxy(ref IXMLElement This, [MarshalAs(UnmanagedType.BStr)] string strPropertyName, ref tagVARIANT PropertyValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_addChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement_addChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement*
        ///pChildElem: IXMLElement*
        ///lIndex: int
        ///lReserved: int
        [DllImport("<Unknown>", EntryPoint = "IXMLElement_addChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement_addChild_Proxy(ref IXMLElement This, ref IXMLElement pChildElem, int lIndex, int lReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_put_length_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElementCollection_put_length_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElementCollection*
        ///v: int
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_put_length_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElementCollection_put_length_Proxy(ref IXMLElementCollection This, int v);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_item_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElementCollection_item_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElementCollection*
        ///var1: VARIANT->tagVARIANT
        ///var2: VARIANT->tagVARIANT
        ///ppDisp: IDispatch**
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_item_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElementCollection_item_Proxy(ref IXMLElementCollection This, tagVARIANT var1, tagVARIANT var2, ref IntPtr ppDisp);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_get__newEnum_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElementCollection_get__newEnum_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElementCollection*
        ///ppUnk: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_get__newEnum_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElementCollection_get__newEnum_Proxy(ref IXMLElementCollection This, ref IntPtr ppUnk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_get_length_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElementCollection_get_length_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElementCollection*
        ///p: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLElementCollection_get_length_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElementCollection_get_length_Proxy(ref IXMLElementCollection This, ref int p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_setAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_setAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///strPropertyName: BSTR->OLECHAR*
        ///PropertyValue: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_setAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_setAttribute_Proxy(ref IXMLElement2 This, [MarshalAs(UnmanagedType.BStr)] string strPropertyName, tagVARIANT PropertyValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_removeChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_removeChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///pChildElem: IXMLElement2*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_removeChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_removeChild_Proxy(ref IXMLElement2 This, ref IXMLElement2 pChildElem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_removeAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_removeAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///strPropertyName: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_removeAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_removeAttribute_Proxy(ref IXMLElement2 This, [MarshalAs(UnmanagedType.BStr)] string strPropertyName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_put_text_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_put_text_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_put_text_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_put_text_Proxy(ref IXMLElement2 This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_put_tagName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_put_tagName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_put_tagName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_put_tagName_Proxy(ref IXMLElement2 This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_type_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_get_type_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///plType: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_type_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_get_type_Proxy(ref IXMLElement2 This, ref int plType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_text_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_get_text_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_text_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_get_text_Proxy(ref IXMLElement2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_tagName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_get_tagName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_tagName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_get_tagName_Proxy(ref IXMLElement2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_parent_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_get_parent_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///ppParent: IXMLElement2**
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_parent_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_get_parent_Proxy(ref IXMLElement2 This, ref IntPtr ppParent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_children_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_get_children_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///pp: IXMLElementCollection**
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_children_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_get_children_Proxy(ref IXMLElement2 This, ref IntPtr pp);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_attributes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_get_attributes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///pp: IXMLElementCollection**
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_get_attributes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_get_attributes_Proxy(ref IXMLElement2 This, ref IntPtr pp);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_getAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_getAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///strPropertyName: BSTR->OLECHAR*
        ///PropertyValue: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_getAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_getAttribute_Proxy(ref IXMLElement2 This, [MarshalAs(UnmanagedType.BStr)] string strPropertyName, ref tagVARIANT PropertyValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_addChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLElement2_addChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLElement2*
        ///pChildElem: IXMLElement2*
        ///lIndex: int
        ///lReserved: int
        [DllImport("<Unknown>", EntryPoint = "IXMLElement2_addChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLElement2_addChild_Proxy(ref IXMLElement2 This, ref IXMLElement2 pChildElem, int lIndex, int lReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_put_XMLDocument_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDSOControl_put_XMLDocument_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDSOControl*
        ///ppDoc: IXMLDOMDocument*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_put_XMLDocument_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDSOControl_put_XMLDocument_Proxy(ref IXMLDSOControl This, ref IXMLDOMDocument ppDoc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_put_JavaDSOCompatible_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDSOControl_put_JavaDSOCompatible_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDSOControl*
        ///fJavaDSOCompatible: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_put_JavaDSOCompatible_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDSOControl_put_JavaDSOCompatible_Proxy(ref IXMLDSOControl This, [MarshalAs(UnmanagedType.Bool)] bool fJavaDSOCompatible);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_get_XMLDocument_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDSOControl_get_XMLDocument_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDSOControl*
        ///ppDoc: IXMLDOMDocument**
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_get_XMLDocument_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDSOControl_get_XMLDocument_Proxy(ref IXMLDSOControl This, ref IntPtr ppDoc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_get_readyState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDSOControl_get_readyState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDSOControl*
        ///state: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_get_readyState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDSOControl_get_readyState_Proxy(ref IXMLDSOControl This, ref int state);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_get_JavaDSOCompatible_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDSOControl_get_JavaDSOCompatible_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDSOControl*
        ///fJavaDSOCompatible: BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDSOControl_get_JavaDSOCompatible_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDSOControl_get_JavaDSOCompatible_Proxy(ref IXMLDSOControl This, ref int fJavaDSOCompatible);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMText_splitText_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMText_splitText_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMText*
        ///offset: int
        ///rightHandTextNode: IXMLDOMText**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMText_splitText_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMText_splitText_Proxy(ref IXMLDOMText This, int offset, ref IntPtr rightHandTextNode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMProcessingInstruction_put_data_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMProcessingInstruction_put_data_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMProcessingInstruction*
        ///value: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMProcessingInstruction_put_data_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMProcessingInstruction_put_data_Proxy(ref IXMLDOMProcessingInstruction This, [MarshalAs(UnmanagedType.BStr)] string value);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMProcessingInstruction_get_target_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMProcessingInstruction_get_target_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMProcessingInstruction*
        ///name: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMProcessingInstruction_get_target_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMProcessingInstruction_get_target_Proxy(ref IXMLDOMProcessingInstruction This, [MarshalAs(UnmanagedType.BStr)] ref string name);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMProcessingInstruction_get_data_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMProcessingInstruction_get_data_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMProcessingInstruction*
        ///value: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMProcessingInstruction_get_data_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMProcessingInstruction_get_data_Proxy(ref IXMLDOMProcessingInstruction This, [MarshalAs(UnmanagedType.BStr)] ref string value);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_url_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMParseError_get_url_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMParseError*
        ///urlString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_url_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMParseError_get_url_Proxy(ref IXMLDOMParseError This, [MarshalAs(UnmanagedType.BStr)] ref string urlString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_srcText_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMParseError_get_srcText_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMParseError*
        ///sourceString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_srcText_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMParseError_get_srcText_Proxy(ref IXMLDOMParseError This, [MarshalAs(UnmanagedType.BStr)] ref string sourceString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_reason_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMParseError_get_reason_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMParseError*
        ///reasonString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_reason_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMParseError_get_reason_Proxy(ref IXMLDOMParseError This, [MarshalAs(UnmanagedType.BStr)] ref string reasonString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_line_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMParseError_get_line_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMParseError*
        ///lineNumber: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_line_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMParseError_get_line_Proxy(ref IXMLDOMParseError This, ref int lineNumber);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_linepos_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMParseError_get_linepos_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMParseError*
        ///linePosition: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_linepos_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMParseError_get_linepos_Proxy(ref IXMLDOMParseError This, ref int linePosition);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_filepos_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMParseError_get_filepos_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMParseError*
        ///filePosition: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_filepos_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMParseError_get_filepos_Proxy(ref IXMLDOMParseError This, ref int filePosition);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_errorCode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMParseError_get_errorCode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMParseError*
        ///errorCode: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMParseError_get_errorCode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMParseError_get_errorCode_Proxy(ref IXMLDOMParseError This, ref int errorCode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNotation_get_systemId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNotation_get_systemId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNotation*
        ///systemID: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNotation_get_systemId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNotation_get_systemId_Proxy(ref IXMLDOMNotation This, ref tagVARIANT systemID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNotation_get_publicId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNotation_get_publicId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNotation*
        ///publicID: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNotation_get_publicId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNotation_get_publicId_Proxy(ref IXMLDOMNotation This, ref tagVARIANT publicID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_transformNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_transformNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///stylesheet: IXMLDOMNode*
        ///xmlString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_transformNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_transformNode_Proxy(ref IXMLDOMNode This, ref IXMLDOMNode stylesheet, [MarshalAs(UnmanagedType.BStr)] ref string xmlString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_transformNodeToObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_transformNodeToObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///stylesheet: IXMLDOMNode*
        ///outputObject: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_transformNodeToObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_transformNodeToObject_Proxy(ref IXMLDOMNode This, ref IXMLDOMNode stylesheet, tagVARIANT outputObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_selectSingleNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_selectSingleNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///queryString: BSTR->OLECHAR*
        ///resultNode: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_selectSingleNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_selectSingleNode_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] string queryString, ref IntPtr resultNode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_selectNodes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_selectNodes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///queryString: BSTR->OLECHAR*
        ///resultList: IXMLDOMNodeList**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_selectNodes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_selectNodes_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] string queryString, ref IntPtr resultList);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_replaceChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_replaceChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///newChild: IXMLDOMNode*
        ///oldChild: IXMLDOMNode*
        ///outOldChild: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_replaceChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_replaceChild_Proxy(ref IXMLDOMNode This, ref IXMLDOMNode newChild, ref IXMLDOMNode oldChild, ref IntPtr outOldChild);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_removeChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_removeChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///childNode: IXMLDOMNode*
        ///oldChild: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_removeChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_removeChild_Proxy(ref IXMLDOMNode This, ref IXMLDOMNode childNode, ref IntPtr oldChild);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_text_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_put_text_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///text: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_text_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_put_text_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] string text);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_nodeValue_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_put_nodeValue_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///value: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_nodeValue_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_put_nodeValue_Proxy(ref IXMLDOMNode This, tagVARIANT value);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_nodeTypedValue_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_put_nodeTypedValue_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///typedValue: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_nodeTypedValue_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_put_nodeTypedValue_Proxy(ref IXMLDOMNode This, tagVARIANT typedValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_dataType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_put_dataType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///dataTypeName: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_put_dataType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_put_dataType_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] string dataTypeName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_insertBefore_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_insertBefore_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///newChild: IXMLDOMNode*
        ///refChild: VARIANT->tagVARIANT
        ///outNewChild: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_insertBefore_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_insertBefore_Proxy(ref IXMLDOMNode This, ref IXMLDOMNode newChild, tagVARIANT refChild, ref IntPtr outNewChild);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_hasChildNodes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_hasChildNodes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///hasChild: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_hasChildNodes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_hasChildNodes_Proxy(ref IXMLDOMNode This, ref short hasChild);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_xml_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_xml_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///xmlString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_xml_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_xml_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] ref string xmlString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_text_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_text_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///text: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_text_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_text_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] ref string text);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_specified_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_specified_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///isSpecified: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_specified_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_specified_Proxy(ref IXMLDOMNode This, ref short isSpecified);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_previousSibling_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_previousSibling_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///previousSibling: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_previousSibling_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_previousSibling_Proxy(ref IXMLDOMNode This, ref IntPtr previousSibling);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_prefix_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_prefix_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///prefixString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_prefix_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_prefix_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] ref string prefixString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_parsed_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_parsed_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///isParsed: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_parsed_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_parsed_Proxy(ref IXMLDOMNode This, ref short isParsed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_parentNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_parentNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///parent: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_parentNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_parentNode_Proxy(ref IXMLDOMNode This, ref IntPtr parent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_ownerDocument_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_ownerDocument_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///DOMDocument: IXMLDOMDocument**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_ownerDocument_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_ownerDocument_Proxy(ref IXMLDOMNode This, ref IntPtr DOMDocument);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeValue_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_nodeValue_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///value: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeValue_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_nodeValue_Proxy(ref IXMLDOMNode This, ref tagVARIANT value);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_nodeType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///type: DOMNodeType*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_nodeType_Proxy(ref IXMLDOMNode This, ref tagDOMNodeType type);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeTypeString_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_nodeTypeString_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///nodeType: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeTypeString_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_nodeTypeString_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] ref string nodeType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeTypedValue_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_nodeTypedValue_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///typedValue: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeTypedValue_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_nodeTypedValue_Proxy(ref IXMLDOMNode This, ref tagVARIANT typedValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_nodeName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///name: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nodeName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_nodeName_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] ref string name);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nextSibling_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_nextSibling_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///nextSibling: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_nextSibling_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_nextSibling_Proxy(ref IXMLDOMNode This, ref IntPtr nextSibling);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_namespaceURI_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_namespaceURI_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///namespaceURI: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_namespaceURI_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_namespaceURI_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] ref string namespaceURI);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_lastChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_lastChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///lastChild: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_lastChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_lastChild_Proxy(ref IXMLDOMNode This, ref IntPtr lastChild);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_firstChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_firstChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///firstChild: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_firstChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_firstChild_Proxy(ref IXMLDOMNode This, ref IntPtr firstChild);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_definition_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_definition_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///definitionNode: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_definition_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_definition_Proxy(ref IXMLDOMNode This, ref IntPtr definitionNode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_dataType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_dataType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///dataTypeName: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_dataType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_dataType_Proxy(ref IXMLDOMNode This, ref tagVARIANT dataTypeName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_childNodes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_childNodes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///childList: IXMLDOMNodeList**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_childNodes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_childNodes_Proxy(ref IXMLDOMNode This, ref IntPtr childList);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_baseName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_baseName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///nameString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_baseName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_baseName_Proxy(ref IXMLDOMNode This, [MarshalAs(UnmanagedType.BStr)] ref string nameString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_attributes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_get_attributes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///attributeMap: IXMLDOMNamedNodeMap**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_get_attributes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_get_attributes_Proxy(ref IXMLDOMNode This, ref IntPtr attributeMap);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_cloneNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_cloneNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///deep: VARIANT_BOOL->short
        ///cloneRoot: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_cloneNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_cloneNode_Proxy(ref IXMLDOMNode This, short deep, ref IntPtr cloneRoot);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_appendChild_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNode_appendChild_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNode*
        ///newChild: IXMLDOMNode*
        ///outNewChild: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNode_appendChild_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNode_appendChild_Proxy(ref IXMLDOMNode This, ref IXMLDOMNode newChild, ref IntPtr outNewChild);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNodeList_reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNodeList*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNodeList_reset_Proxy(ref IXMLDOMNodeList This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_nextNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNodeList_nextNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNodeList*
        ///nextItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_nextNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNodeList_nextNode_Proxy(ref IXMLDOMNodeList This, ref IntPtr nextItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_get__newEnum_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNodeList_get__newEnum_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNodeList*
        ///ppUnk: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_get__newEnum_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNodeList_get__newEnum_Proxy(ref IXMLDOMNodeList This, ref IntPtr ppUnk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_get_length_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNodeList_get_length_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNodeList*
        ///listLength: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_get_length_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNodeList_get_length_Proxy(ref IXMLDOMNodeList This, ref int listLength);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_get_item_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNodeList_get_item_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNodeList*
        ///index: int
        ///listItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNodeList_get_item_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNodeList_get_item_Proxy(ref IXMLDOMNodeList This, int index, ref IntPtr listItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_setNamedItem_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_setNamedItem_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///newItem: IXMLDOMNode*
        ///nameItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_setNamedItem_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_setNamedItem_Proxy(ref IXMLDOMNamedNodeMap This, ref IXMLDOMNode newItem, ref IntPtr nameItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_reset_Proxy(ref IXMLDOMNamedNodeMap This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_removeQualifiedItem_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_removeQualifiedItem_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///baseName: BSTR->OLECHAR*
        ///namespaceURI: BSTR->OLECHAR*
        ///qualifiedItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_removeQualifiedItem_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_removeQualifiedItem_Proxy(ref IXMLDOMNamedNodeMap This, [MarshalAs(UnmanagedType.BStr)] string baseName, [MarshalAs(UnmanagedType.BStr)] string namespaceURI, ref IntPtr qualifiedItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_removeNamedItem_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_removeNamedItem_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///name: BSTR->OLECHAR*
        ///namedItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_removeNamedItem_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_removeNamedItem_Proxy(ref IXMLDOMNamedNodeMap This, [MarshalAs(UnmanagedType.BStr)] string name, ref IntPtr namedItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_nextNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_nextNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///nextItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_nextNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_nextNode_Proxy(ref IXMLDOMNamedNodeMap This, ref IntPtr nextItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_get__newEnum_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_get__newEnum_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///ppUnk: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_get__newEnum_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_get__newEnum_Proxy(ref IXMLDOMNamedNodeMap This, ref IntPtr ppUnk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_get_length_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_get_length_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///listLength: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_get_length_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_get_length_Proxy(ref IXMLDOMNamedNodeMap This, ref int listLength);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_get_item_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_get_item_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///index: int
        ///listItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_get_item_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_get_item_Proxy(ref IXMLDOMNamedNodeMap This, int index, ref IntPtr listItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_getQualifiedItem_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_getQualifiedItem_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///baseName: BSTR->OLECHAR*
        ///namespaceURI: BSTR->OLECHAR*
        ///qualifiedItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_getQualifiedItem_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_getQualifiedItem_Proxy(ref IXMLDOMNamedNodeMap This, [MarshalAs(UnmanagedType.BStr)] string baseName, [MarshalAs(UnmanagedType.BStr)] string namespaceURI, ref IntPtr qualifiedItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_getNamedItem_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMNamedNodeMap_getNamedItem_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMNamedNodeMap*
        ///name: BSTR->OLECHAR*
        ///namedItem: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMNamedNodeMap_getNamedItem_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMNamedNodeMap_getNamedItem_Proxy(ref IXMLDOMNamedNodeMap This, [MarshalAs(UnmanagedType.BStr)] string name, ref IntPtr namedItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMImplementation_hasFeature_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMImplementation_hasFeature_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMImplementation*
        ///feature: BSTR->OLECHAR*
        ///version: BSTR->OLECHAR*
        ///hasFeature: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMImplementation_hasFeature_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMImplementation_hasFeature_Proxy(ref IXMLDOMImplementation This, [MarshalAs(UnmanagedType.BStr)] string feature, [MarshalAs(UnmanagedType.BStr)] string version, ref short hasFeature);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMEntity_get_systemId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMEntity_get_systemId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMEntity*
        ///systemID: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMEntity_get_systemId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMEntity_get_systemId_Proxy(ref IXMLDOMEntity This, ref tagVARIANT systemID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMEntity_get_publicId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMEntity_get_publicId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMEntity*
        ///publicID: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMEntity_get_publicId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMEntity_get_publicId_Proxy(ref IXMLDOMEntity This, ref tagVARIANT publicID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMEntity_get_notationName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMEntity_get_notationName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMEntity*
        ///name: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMEntity_get_notationName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMEntity_get_notationName_Proxy(ref IXMLDOMEntity This, [MarshalAs(UnmanagedType.BStr)] ref string name);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_setAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_setAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///name: BSTR->OLECHAR*
        ///value: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_setAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_setAttribute_Proxy(ref IXMLDOMElement This, [MarshalAs(UnmanagedType.BStr)] string name, tagVARIANT value);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_setAttributeNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_setAttributeNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///DOMAttribute: IXMLDOMAttribute*
        ///attributeNode: IXMLDOMAttribute**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_setAttributeNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_setAttributeNode_Proxy(ref IXMLDOMElement This, ref IXMLDOMAttribute DOMAttribute, ref IntPtr attributeNode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_removeAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_removeAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///name: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_removeAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_removeAttribute_Proxy(ref IXMLDOMElement This, [MarshalAs(UnmanagedType.BStr)] string name);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_removeAttributeNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_removeAttributeNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///DOMAttribute: IXMLDOMAttribute*
        ///attributeNode: IXMLDOMAttribute**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_removeAttributeNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_removeAttributeNode_Proxy(ref IXMLDOMElement This, ref IXMLDOMAttribute DOMAttribute, ref IntPtr attributeNode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_normalize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_normalize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_normalize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_normalize_Proxy(ref IXMLDOMElement This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_get_tagName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_get_tagName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///tagName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_get_tagName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_get_tagName_Proxy(ref IXMLDOMElement This, [MarshalAs(UnmanagedType.BStr)] ref string tagName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_getElementsByTagName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_getElementsByTagName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///tagName: BSTR->OLECHAR*
        ///resultList: IXMLDOMNodeList**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_getElementsByTagName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_getElementsByTagName_Proxy(ref IXMLDOMElement This, [MarshalAs(UnmanagedType.BStr)] string tagName, ref IntPtr resultList);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_getAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_getAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///name: BSTR->OLECHAR*
        ///value: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_getAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_getAttribute_Proxy(ref IXMLDOMElement This, [MarshalAs(UnmanagedType.BStr)] string name, ref tagVARIANT value);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_getAttributeNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMElement_getAttributeNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMElement*
        ///name: BSTR->OLECHAR*
        ///attributeNode: IXMLDOMAttribute**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMElement_getAttributeNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMElement_getAttributeNode_Proxy(ref IXMLDOMElement This, [MarshalAs(UnmanagedType.BStr)] string name, ref IntPtr attributeNode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_save_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_save_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///destination: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_save_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_save_Proxy(ref IXMLDOMDocument This, tagVARIANT destination);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_validateOnParse_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_put_validateOnParse_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isValidating: VARIANT_BOOL->short
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_validateOnParse_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_put_validateOnParse_Proxy(ref IXMLDOMDocument This, short isValidating);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_resolveExternals_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_put_resolveExternals_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isResolving: VARIANT_BOOL->short
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_resolveExternals_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_put_resolveExternals_Proxy(ref IXMLDOMDocument This, short isResolving);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_preserveWhiteSpace_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_put_preserveWhiteSpace_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isPreserving: VARIANT_BOOL->short
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_preserveWhiteSpace_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_put_preserveWhiteSpace_Proxy(ref IXMLDOMDocument This, short isPreserving);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_ontransformnode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_put_ontransformnode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///ontransformnodeSink: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_ontransformnode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_put_ontransformnode_Proxy(ref IXMLDOMDocument This, tagVARIANT ontransformnodeSink);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_onreadystatechange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_put_onreadystatechange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///readystatechangeSink: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_onreadystatechange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_put_onreadystatechange_Proxy(ref IXMLDOMDocument This, tagVARIANT readystatechangeSink);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_ondataavailable_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_put_ondataavailable_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///ondataavailableSink: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_ondataavailable_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_put_ondataavailable_Proxy(ref IXMLDOMDocument This, tagVARIANT ondataavailableSink);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_async_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_put_async_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isAsync: VARIANT_BOOL->short
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_put_async_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_put_async_Proxy(ref IXMLDOMDocument This, short isAsync);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_putref_documentElement_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_putref_documentElement_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///DOMElement: IXMLDOMElement*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_putref_documentElement_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_putref_documentElement_Proxy(ref IXMLDOMDocument This, ref IXMLDOMElement DOMElement);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_nodeFromID_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_nodeFromID_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///idString: BSTR->OLECHAR*
        ///node: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_nodeFromID_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_nodeFromID_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string idString, ref IntPtr node);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_load_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_load_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///xmlSource: VARIANT->tagVARIANT
        ///isSuccessful: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_load_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_load_Proxy(ref IXMLDOMDocument This, tagVARIANT xmlSource, ref short isSuccessful);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_loadXML_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_loadXML_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///bstrXML: BSTR->OLECHAR*
        ///isSuccessful: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_loadXML_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_loadXML_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string bstrXML, ref short isSuccessful);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_validateOnParse_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_validateOnParse_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isValidating: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_validateOnParse_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_validateOnParse_Proxy(ref IXMLDOMDocument This, ref short isValidating);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_url_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_url_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///urlString: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_url_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_url_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] ref string urlString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_resolveExternals_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_resolveExternals_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isResolving: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_resolveExternals_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_resolveExternals_Proxy(ref IXMLDOMDocument This, ref short isResolving);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_readyState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_readyState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///value: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_readyState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_readyState_Proxy(ref IXMLDOMDocument This, ref int value);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_preserveWhiteSpace_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_preserveWhiteSpace_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isPreserving: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_preserveWhiteSpace_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_preserveWhiteSpace_Proxy(ref IXMLDOMDocument This, ref short isPreserving);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_parseError_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_parseError_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///errorObj: IXMLDOMParseError**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_parseError_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_parseError_Proxy(ref IXMLDOMDocument This, ref IntPtr errorObj);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_implementation_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_implementation_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///impl: IXMLDOMImplementation**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_implementation_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_implementation_Proxy(ref IXMLDOMDocument This, ref IntPtr impl);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_documentElement_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_documentElement_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///DOMElement: IXMLDOMElement**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_documentElement_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_documentElement_Proxy(ref IXMLDOMDocument This, ref IntPtr DOMElement);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_doctype_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_doctype_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///documentType: IXMLDOMDocumentType**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_doctype_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_doctype_Proxy(ref IXMLDOMDocument This, ref IntPtr documentType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_async_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_get_async_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///isAsync: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_get_async_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_get_async_Proxy(ref IXMLDOMDocument This, ref short isAsync);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_getElementsByTagName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_getElementsByTagName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///tagName: BSTR->OLECHAR*
        ///resultList: IXMLDOMNodeList**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_getElementsByTagName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_getElementsByTagName_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string tagName, ref IntPtr resultList);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createTextNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createTextNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///data: BSTR->OLECHAR*
        ///text: IXMLDOMText**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createTextNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createTextNode_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string data, ref IntPtr text);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createProcessingInstruction_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createProcessingInstruction_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///target: BSTR->OLECHAR*
        ///data: BSTR->OLECHAR*
        ///pi: IXMLDOMProcessingInstruction**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createProcessingInstruction_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createProcessingInstruction_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string target, [MarshalAs(UnmanagedType.BStr)] string data, ref IntPtr pi);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createNode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createNode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///Type: VARIANT->tagVARIANT
        ///name: BSTR->OLECHAR*
        ///namespaceURI: BSTR->OLECHAR*
        ///node: IXMLDOMNode**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createNode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createNode_Proxy(ref IXMLDOMDocument This, tagVARIANT Type, [MarshalAs(UnmanagedType.BStr)] string name, [MarshalAs(UnmanagedType.BStr)] string namespaceURI, ref IntPtr node);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createEntityReference_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createEntityReference_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///name: BSTR->OLECHAR*
        ///entityRef: IXMLDOMEntityReference**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createEntityReference_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createEntityReference_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string name, ref IntPtr entityRef);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createElement_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createElement_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///tagName: BSTR->OLECHAR*
        ///element: IXMLDOMElement**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createElement_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createElement_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string tagName, ref IntPtr element);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createDocumentFragment_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createDocumentFragment_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///docFrag: IXMLDOMDocumentFragment**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createDocumentFragment_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createDocumentFragment_Proxy(ref IXMLDOMDocument This, ref IntPtr docFrag);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createComment_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createComment_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///data: BSTR->OLECHAR*
        ///comment: IXMLDOMComment**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createComment_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createComment_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string data, ref IntPtr comment);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createCDATASection_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createCDATASection_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///data: BSTR->OLECHAR*
        ///cdata: IXMLDOMCDATASection**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createCDATASection_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createCDATASection_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string data, ref IntPtr cdata);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createAttribute_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_createAttribute_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        ///name: BSTR->OLECHAR*
        ///attribute: IXMLDOMAttribute**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_createAttribute_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_createAttribute_Proxy(ref IXMLDOMDocument This, [MarshalAs(UnmanagedType.BStr)] string name, ref IntPtr attribute);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_abort_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocument_abort_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocument*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocument_abort_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocument_abort_Proxy(ref IXMLDOMDocument This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocumentType_get_notations_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocumentType_get_notations_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocumentType*
        ///notationMap: IXMLDOMNamedNodeMap**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocumentType_get_notations_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocumentType_get_notations_Proxy(ref IXMLDOMDocumentType This, ref IntPtr notationMap);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocumentType_get_name_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocumentType_get_name_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocumentType*
        ///rootName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocumentType_get_name_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocumentType_get_name_Proxy(ref IXMLDOMDocumentType This, [MarshalAs(UnmanagedType.BStr)] ref string rootName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocumentType_get_entities_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMDocumentType_get_entities_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMDocumentType*
        ///entityMap: IXMLDOMNamedNodeMap**
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMDocumentType_get_entities_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMDocumentType_get_entities_Proxy(ref IXMLDOMDocumentType This, ref IntPtr entityMap);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_substringData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_substringData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///offset: int
        ///count: int
        ///data: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_substringData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_substringData_Proxy(ref IXMLDOMCharacterData This, int offset, int count, [MarshalAs(UnmanagedType.BStr)] ref string data);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_replaceData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_replaceData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///offset: int
        ///count: int
        ///data: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_replaceData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_replaceData_Proxy(ref IXMLDOMCharacterData This, int offset, int count, [MarshalAs(UnmanagedType.BStr)] string data);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_put_data_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_put_data_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///data: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_put_data_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_put_data_Proxy(ref IXMLDOMCharacterData This, [MarshalAs(UnmanagedType.BStr)] string data);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_insertData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_insertData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///offset: int
        ///data: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_insertData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_insertData_Proxy(ref IXMLDOMCharacterData This, int offset, [MarshalAs(UnmanagedType.BStr)] string data);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_get_length_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_get_length_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///dataLength: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_get_length_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_get_length_Proxy(ref IXMLDOMCharacterData This, ref int dataLength);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_get_data_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_get_data_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///data: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_get_data_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_get_data_Proxy(ref IXMLDOMCharacterData This, [MarshalAs(UnmanagedType.BStr)] ref string data);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_deleteData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_deleteData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///offset: int
        ///count: int
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_deleteData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_deleteData_Proxy(ref IXMLDOMCharacterData This, int offset, int count);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_appendData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMCharacterData_appendData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMCharacterData*
        ///data: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMCharacterData_appendData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMCharacterData_appendData_Proxy(ref IXMLDOMCharacterData This, [MarshalAs(UnmanagedType.BStr)] string data);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMAttribute_put_value_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMAttribute_put_value_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMAttribute*
        ///attributeValue: VARIANT->tagVARIANT
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMAttribute_put_value_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMAttribute_put_value_Proxy(ref IXMLDOMAttribute This, tagVARIANT attributeValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMAttribute_get_value_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMAttribute_get_value_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMAttribute*
        ///attributeValue: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMAttribute_get_value_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMAttribute_get_value_Proxy(ref IXMLDOMAttribute This, ref tagVARIANT attributeValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMAttribute_get_name_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDOMAttribute_get_name_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDOMAttribute*
        ///attributeName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDOMAttribute_get_name_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDOMAttribute_get_name_Proxy(ref IXMLDOMAttribute This, [MarshalAs(UnmanagedType.BStr)] ref string attributeName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_put_URL_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_put_URL_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_put_URL_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_put_URL_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_put_charset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_put_charset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_put_charset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_put_charset_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_version_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_version_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_version_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_version_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_URL_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_URL_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_URL_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_URL_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_root_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_root_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: IXMLElement**
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_root_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_root_Proxy(ref IXMLDocument This, ref IntPtr p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_readyState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_readyState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///pl: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_readyState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_readyState_Proxy(ref IXMLDocument This, ref int pl);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_mimeType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_mimeType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_mimeType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_mimeType_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_fileUpdatedDate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_fileUpdatedDate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_fileUpdatedDate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_fileUpdatedDate_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_fileSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_fileSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_fileSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_fileSize_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_fileModifiedDate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_fileModifiedDate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_fileModifiedDate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_fileModifiedDate_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_dtdURL_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_dtdURL_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_dtdURL_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_dtdURL_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_doctype_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_doctype_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_doctype_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_doctype_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_charset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_get_charset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_get_charset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_get_charset_Proxy(ref IXMLDocument This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_createElement_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument_createElement_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument*
        ///vType: VARIANT->tagVARIANT
        ///var1: VARIANT->tagVARIANT
        ///ppElem: IXMLElement**
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument_createElement_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument_createElement_Proxy(ref IXMLDocument This, tagVARIANT vType, tagVARIANT var1, ref IntPtr ppElem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_put_URL_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_put_URL_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_put_URL_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_put_URL_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_put_charset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_put_charset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_put_charset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_put_charset_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_put_async_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_put_async_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///f: VARIANT_BOOL->short
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_put_async_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_put_async_Proxy(ref IXMLDocument2 This, short f);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_version_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_version_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_version_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_version_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_URL_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_URL_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_URL_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_URL_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_root_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_root_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: IXMLElement2**
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_root_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_root_Proxy(ref IXMLDocument2 This, ref IntPtr p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_readyState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_readyState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///pl: int*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_readyState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_readyState_Proxy(ref IXMLDocument2 This, ref int pl);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_mimeType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_mimeType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_mimeType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_mimeType_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_fileUpdatedDate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_fileUpdatedDate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_fileUpdatedDate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_fileUpdatedDate_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_fileSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_fileSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_fileSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_fileSize_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_fileModifiedDate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_fileModifiedDate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_fileModifiedDate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_fileModifiedDate_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_dtdURL_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_dtdURL_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_dtdURL_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_dtdURL_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_doctype_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_doctype_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_doctype_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_doctype_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_charset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_charset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///p: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_charset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_charset_Proxy(ref IXMLDocument2 This, [MarshalAs(UnmanagedType.BStr)] ref string p);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_async_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_get_async_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///pf: VARIANT_BOOL*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_get_async_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_get_async_Proxy(ref IXMLDocument2 This, ref short pf);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_createElement_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLDocument2_createElement_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLDocument2*
        ///vType: VARIANT->tagVARIANT
        ///var1: VARIANT->tagVARIANT
        ///ppElem: IXMLElement2**
        [DllImport("<Unknown>", EntryPoint = "IXMLDocument2_createElement_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLDocument2_createElement_Proxy(ref IXMLDocument2 This, tagVARIANT vType, tagVARIANT var1, ref IntPtr ppElem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLAttribute_get_value_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLAttribute_get_value_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLAttribute*
        ///v: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLAttribute_get_value_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLAttribute_get_value_Proxy(ref IXMLAttribute This, [MarshalAs(UnmanagedType.BStr)] ref string v);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IXMLAttribute_get_name_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IXMLAttribute_get_name_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IXMLAttribute*
        ///n: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IXMLAttribute_get_name_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IXMLAttribute_get_name_Proxy(ref IXMLAttribute This, [MarshalAs(UnmanagedType.BStr)] ref string n);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWrappedProtocol_GetWrapperCode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWrappedProtocol_GetWrapperCode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWrappedProtocol*
        ///pnCode: LONG*
        ///dwReserved: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IWrappedProtocol_GetWrapperCode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWrappedProtocol_GetWrapperCode_Proxy(ref IWrappedProtocol This, ref int pnCode, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetInfo_RemoteQueryOption_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWinInetInfo_RemoteQueryOption_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetInfo*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: BYTE*
        ///pcbBuf: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetInfo_RemoteQueryOption_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetInfo_RemoteQueryOption_Proxy(ref IWinInetInfo This, uint dwOption, ref byte pBuffer, ref uint pcbBuf);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetInfo*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: BYTE*
        ///pcbBuf: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetInfo_QueryOption_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetInfo_QueryOption_Stub(ref IWinInetInfo This, uint dwOption, ref byte pBuffer, ref uint pcbBuf);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetInfo*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: LPVOID->void*
        ///pcbBuf: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetInfo_QueryOption_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetInfo_QueryOption_Proxy(ref IWinInetInfo This, uint dwOption, IntPtr pBuffer, ref uint pcbBuf);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetHttpInfo_RemoteQueryInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWinInetHttpInfo_RemoteQueryInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetHttpInfo*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: BYTE*
        ///pcbBuf: DWORD*
        ///pdwFlags: DWORD*
        ///pdwReserved: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetHttpInfo_RemoteQueryInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetHttpInfo_RemoteQueryInfo_Proxy(ref IWinInetHttpInfo This, uint dwOption, ref byte pBuffer, ref uint pcbBuf, ref uint pdwFlags, ref uint pdwReserved);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetHttpInfo*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: BYTE*
        ///pcbBuf: DWORD*
        ///pdwFlags: DWORD*
        ///pdwReserved: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetHttpInfo_QueryInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetHttpInfo_QueryInfo_Stub(ref IWinInetHttpInfo This, uint dwOption, ref byte pBuffer, ref uint pcbBuf, ref uint pdwFlags, ref uint pdwReserved);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetHttpInfo*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: LPVOID->void*
        ///pcbBuf: DWORD*
        ///pdwFlags: DWORD*
        ///pdwReserved: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetHttpInfo_QueryInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetHttpInfo_QueryInfo_Proxy(ref IWinInetHttpInfo This, uint dwOption, IntPtr pBuffer, ref uint pcbBuf, ref uint pdwFlags, ref uint pdwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetFileStream_SetHandleForUnlock_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWinInetFileStream_SetHandleForUnlock_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetFileStream*
        ///hWinInetLockHandle: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwReserved: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IWinInetFileStream_SetHandleForUnlock_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetFileStream_SetHandleForUnlock_Proxy(ref IWinInetFileStream This, uint hWinInetLockHandle, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetFileStream_SetDeleteFile_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWinInetFileStream_SetDeleteFile_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetFileStream*
        ///dwReserved: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IWinInetFileStream_SetDeleteFile_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetFileStream_SetDeleteFile_Proxy(ref IWinInetFileStream This, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetCacheHints_SetCacheExtension_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWinInetCacheHints_SetCacheExtension_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWinInetCacheHints*
        ///pwzExt: LPCWSTR->WCHAR*
        ///pszCacheFile: LPVOID->void*
        ///pcbCacheFile: DWORD*
        ///pdwWinInetError: DWORD*
        ///pdwReserved: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWinInetCacheHints_SetCacheExtension_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWinInetCacheHints_SetCacheExtension_Proxy(ref IWinInetCacheHints This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzExt, IntPtr pszCacheFile, ref uint pcbCacheFile, ref uint pdwWinInetError, ref uint pdwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWindowForBindingUI_GetWindow_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWindowForBindingUI_GetWindow_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWindowForBindingUI*
        ///rguidReason: GUID*
        ///phwnd: HWND*
        [DllImport("<Unknown>", EntryPoint = "IWindowForBindingUI_GetWindow_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWindowForBindingUI_GetWindow_Proxy(ref IWindowForBindingUI This, ref GUID rguidReason, ref IntPtr phwnd);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWaitMultiple_WaitMultiple_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWaitMultiple_WaitMultiple_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWaitMultiple*
        ///timeout: DWORD->unsigned int
        ///pSync: ISynchronize**
        [DllImport("<Unknown>", EntryPoint = "IWaitMultiple_WaitMultiple_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWaitMultiple_WaitMultiple_Proxy(ref IWaitMultiple This, uint timeout, ref IntPtr pSync);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IWaitMultiple_AddSynchronize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IWaitMultiple_AddSynchronize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IWaitMultiple*
        ///pSync: ISynchronize*
        [DllImport("<Unknown>", EntryPoint = "IWaitMultiple_AddSynchronize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IWaitMultiple_AddSynchronize_Proxy(ref IWaitMultiple This, ref ISynchronize pSync);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_Unfreeze_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IViewObject_Unfreeze_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwFreeze: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IViewObject_Unfreeze_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_Unfreeze_Proxy(ref IViewObject This, uint dwFreeze);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_SetAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IViewObject_SetAdvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///aspects: DWORD->unsigned int
        ///advf: DWORD->unsigned int
        ///pAdvSink: IAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_SetAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_SetAdvise_Proxy(ref IViewObject This, uint aspects, uint advf, ref IAdviseSink pAdvSink);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteGetColorSet_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IViewObject_RemoteGetColorSet_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: ULONG_PTR->unsigned int
        ///ptd: DVTARGETDEVICE*
        ///hicTargetDev: ULONG_PTR->unsigned int
        ///ppColorSet: LOGPALETTE**
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteGetColorSet_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_RemoteGetColorSet_Proxy(ref IViewObject This, uint dwDrawAspect, int lindex, uint pvAspect, ref tagDVTARGETDEVICE ptd, uint hicTargetDev, ref IntPtr ppColorSet);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteGetAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IViewObject_RemoteGetAdvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///pAspects: DWORD*
        ///pAdvf: DWORD*
        ///ppAdvSink: IAdviseSink**
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteGetAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_RemoteGetAdvise_Proxy(ref IViewObject This, ref uint pAspects, ref uint pAdvf, ref IntPtr ppAdvSink);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteFreeze_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IViewObject_RemoteFreeze_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: ULONG_PTR->unsigned int
        ///pdwFreeze: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteFreeze_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_RemoteFreeze_Proxy(ref IViewObject This, uint dwDrawAspect, int lindex, uint pvAspect, ref uint pdwFreeze);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteDraw_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IViewObject_RemoteDraw_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: ULONG_PTR->unsigned int
        ///ptd: DVTARGETDEVICE*
        ///hdcTargetDev: ULONG_PTR->unsigned int
        ///hdcDraw: ULONG_PTR->unsigned int
        ///lprcBounds: LPCRECTL->RECTL*
        ///lprcWBounds: LPCRECTL->RECTL*
        ///pContinue: IContinue*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_RemoteDraw_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_RemoteDraw_Proxy(ref IViewObject This, uint dwDrawAspect, int lindex, uint pvAspect, ref tagDVTARGETDEVICE ptd, uint hdcTargetDev, uint hdcDraw, ref RECTL lprcBounds, ref RECTL lprcWBounds, ref IContinue pContinue);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: ULONG_PTR->unsigned int
        ///ptd: DVTARGETDEVICE*
        ///hicTargetDev: ULONG_PTR->unsigned int
        ///ppColorSet: LOGPALETTE**
        [DllImport("<Unknown>", EntryPoint = "IViewObject_GetColorSet_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_GetColorSet_Stub(ref IViewObject This, uint dwDrawAspect, int lindex, uint pvAspect, ref tagDVTARGETDEVICE ptd, uint hicTargetDev, ref IntPtr ppColorSet);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: void*
        ///ptd: DVTARGETDEVICE*
        ///hicTargetDev: HDC->HDC__*
        ///ppColorSet: LOGPALETTE**
        [DllImport("<Unknown>", EntryPoint = "IViewObject_GetColorSet_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_GetColorSet_Proxy(ref IViewObject This, uint dwDrawAspect, int lindex, IntPtr pvAspect, ref tagDVTARGETDEVICE ptd, IntPtr hicTargetDev, ref IntPtr ppColorSet);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///pAspects: DWORD*
        ///pAdvf: DWORD*
        ///ppAdvSink: IAdviseSink**
        [DllImport("<Unknown>", EntryPoint = "IViewObject_GetAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_GetAdvise_Stub(ref IViewObject This, ref uint pAspects, ref uint pAdvf, ref IntPtr ppAdvSink);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///pAspects: DWORD*
        ///pAdvf: DWORD*
        ///ppAdvSink: IAdviseSink**
        [DllImport("<Unknown>", EntryPoint = "IViewObject_GetAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_GetAdvise_Proxy(ref IViewObject This, ref uint pAspects, ref uint pAdvf, ref IntPtr ppAdvSink);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: ULONG_PTR->unsigned int
        ///pdwFreeze: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_Freeze_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_Freeze_Stub(ref IViewObject This, uint dwDrawAspect, int lindex, uint pvAspect, ref uint pdwFreeze);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: void*
        ///pdwFreeze: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_Freeze_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_Freeze_Proxy(ref IViewObject This, uint dwDrawAspect, int lindex, IntPtr pvAspect, ref uint pdwFreeze);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: ULONG_PTR->unsigned int
        ///ptd: DVTARGETDEVICE*
        ///hdcTargetDev: ULONG_PTR->unsigned int
        ///hdcDraw: ULONG_PTR->unsigned int
        ///lprcBounds: LPCRECTL->RECTL*
        ///lprcWBounds: LPCRECTL->RECTL*
        ///pContinue: IContinue*
        [DllImport("<Unknown>", EntryPoint = "IViewObject_Draw_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_Draw_Stub(ref IViewObject This, uint dwDrawAspect, int lindex, uint pvAspect, ref tagDVTARGETDEVICE ptd, uint hdcTargetDev, uint hdcDraw, ref RECTL lprcBounds, ref RECTL lprcWBounds, ref IContinue pContinue);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///pvAspect: void*
        ///ptd: DVTARGETDEVICE*
        ///hdcTargetDev: HDC->HDC__*
        ///hdcDraw: HDC->HDC__*
        ///lprcBounds: LPCRECTL->RECTL*
        ///lprcWBounds: LPCRECTL->RECTL*
        ///pfnContinue: Anonymous_6870f0ea_5b0f_451e_b508_21951610fb29
        ///dwContinue: ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IViewObject_Draw_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject_Draw_Proxy(ref IViewObject This, uint dwDrawAspect, int lindex, IntPtr pvAspect, ref tagDVTARGETDEVICE ptd, IntPtr hdcTargetDev, IntPtr hdcDraw, ref RECTL lprcBounds, ref RECTL lprcWBounds, Anonymous_6870f0ea_5b0f_451e_b508_21951610fb29 pfnContinue, uint dwContinue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IViewObject2_GetExtent_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IViewObject2_GetExtent_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IViewObject2*
        ///dwDrawAspect: DWORD->unsigned int
        ///lindex: LONG->int
        ///ptd: DVTARGETDEVICE*
        ///lpsizel: LPSIZEL->SIZE*
        [DllImport("<Unknown>", EntryPoint = "IViewObject2_GetExtent_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IViewObject2_GetExtent_Proxy(ref IViewObject2 This, uint dwDrawAspect, int lindex, ref tagDVTARGETDEVICE ptd, ref tagSIZE lpsizel);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IUrlMon_AsyncGetClassBits_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IUrlMon_AsyncGetClassBits_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IUrlMon*
        ///rclsid: IID*
        ///pszTYPE: LPCWSTR->WCHAR*
        ///pszExt: LPCWSTR->WCHAR*
        ///dwFileVersionMS: DWORD->unsigned int
        ///dwFileVersionLS: DWORD->unsigned int
        ///pszCodeBase: LPCWSTR->WCHAR*
        ///pbc: IBindCtx*
        ///dwClassContext: DWORD->unsigned int
        ///riid: IID*
        ///flags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IUrlMon_AsyncGetClassBits_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IUrlMon_AsyncGetClassBits_Proxy(ref IUrlMon This, ref GUID rclsid, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszTYPE, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref GUID riid, uint flags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IUnknown_Release_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IUnknown_Release_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: ULONG->unsigned int
        ///This: IUnknown*
        [DllImport("rpcrt4.dll", EntryPoint = "IUnknown_Release_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IUnknown_Release_Proxy(ref IUnknown This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IUnknown_QueryInterface_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IUnknown_QueryInterface_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IUnknown*
        ///riid: IID*
        ///ppvObject: void**
        [DllImport("rpcrt4.dll", EntryPoint = "IUnknown_QueryInterface_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IUnknown_QueryInterface_Proxy(ref IUnknown This, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IUnknown_AddRef_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IUnknown_AddRef_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: ULONG->unsigned int
        ///This: IUnknown*
        [DllImport("rpcrt4.dll", EntryPoint = "IUnknown_AddRef_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IUnknown_AddRef_Proxy(ref IUnknown This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Unmarshal_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeMarshal_Unmarshal_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeMarshal*
        ///pvType: PVOID->void*
        ///dwFlags: DWORD->unsigned int
        ///cbBufferLength: ULONG->unsigned int
        ///pBuffer: BYTE*
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Unmarshal_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeMarshal_Unmarshal_Proxy(ref ITypeMarshal This, IntPtr pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, ref uint pcbRead);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Size_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeMarshal_Size_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeMarshal*
        ///pvType: PVOID->void*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: PVOID->void*
        ///pSize: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Size_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeMarshal_Size_Proxy(ref ITypeMarshal This, IntPtr pvType, uint dwDestContext, IntPtr pvDestContext, ref uint pSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Marshal_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeMarshal_Marshal_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeMarshal*
        ///pvType: PVOID->void*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: PVOID->void*
        ///cbBufferLength: ULONG->unsigned int
        ///pBuffer: BYTE*
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Marshal_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeMarshal_Marshal_Proxy(ref ITypeMarshal This, IntPtr pvType, uint dwDestContext, IntPtr pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Free_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeMarshal_Free_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeMarshal*
        ///pvType: PVOID->void*
        [DllImport("<Unknown>", EntryPoint = "ITypeMarshal_Free_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeMarshal_Free_Proxy(ref ITypeMarshal This, IntPtr pvType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteIsName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_RemoteIsName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///szNameBuf: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///pfName: BOOL*
        ///pBstrLibName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteIsName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_RemoteIsName_Proxy(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal, ref int pfName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrLibName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteGetTypeInfoCount_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_RemoteGetTypeInfoCount_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///pcTInfo: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteGetTypeInfoCount_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_RemoteGetTypeInfoCount_Proxy(ref ITypeLib This, ref uint pcTInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteGetLibAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_RemoteGetLibAttr_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///ppTLibAttr: LPTLIBATTR*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteGetLibAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_RemoteGetLibAttr_Proxy(ref ITypeLib This, ref IntPtr ppTLibAttr, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteGetDocumentation_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_RemoteGetDocumentation_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///index: INT->int
        ///refPtrFlags: DWORD->unsigned int
        ///pBstrName: BSTR*
        ///pBstrDocString: BSTR*
        ///pdwHelpContext: DWORD*
        ///pBstrHelpFile: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteGetDocumentation_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_RemoteGetDocumentation_Proxy(ref ITypeLib This, int index, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDocString, ref uint pdwHelpContext, [MarshalAs(UnmanagedType.BStr)] ref string pBstrHelpFile);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteFindName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_RemoteFindName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///szNameBuf: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///ppTInfo: ITypeInfo**
        ///rgMemId: MEMBERID*
        ///pcFound: USHORT*
        ///pBstrLibName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_RemoteFindName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_RemoteFindName_Proxy(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal, ref IntPtr ppTInfo, ref int rgMemId, ref ushort pcFound, [MarshalAs(UnmanagedType.BStr)] ref string pBstrLibName);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_ReleaseTLibAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_ReleaseTLibAttr_Stub(ref ITypeLib This);


        /// Return Type: void
        ///This: ITypeLib*
        ///pTLibAttr: TLIBATTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_ReleaseTLibAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_ReleaseTLibAttr_Proxy(ref ITypeLib This, ref tagTLIBATTR pTLibAttr);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_LocalReleaseTLibAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_LocalReleaseTLibAttr_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_LocalReleaseTLibAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_LocalReleaseTLibAttr_Proxy(ref ITypeLib This);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///szNameBuf: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///pfName: BOOL*
        ///pBstrLibName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_IsName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_IsName_Stub(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal, ref int pfName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrLibName);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///szNameBuf: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///pfName: BOOL*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_IsName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_IsName_Proxy(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal, ref int pfName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_GetTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///index: UINT->unsigned int
        ///ppTInfo: ITypeInfo**
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetTypeInfo_Proxy(ref ITypeLib This, uint index, ref IntPtr ppTInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfoType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_GetTypeInfoType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///index: UINT->unsigned int
        ///pTKind: TYPEKIND*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfoType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetTypeInfoType_Proxy(ref ITypeLib This, uint index, ref tagTYPEKIND pTKind);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfoOfGuid_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_GetTypeInfoOfGuid_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///guid: GUID*
        ///ppTinfo: ITypeInfo**
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfoOfGuid_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetTypeInfoOfGuid_Proxy(ref ITypeLib This, ref GUID guid, ref IntPtr ppTinfo);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///pcTInfo: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfoCount_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetTypeInfoCount_Stub(ref ITypeLib This, ref uint pcTInfo);


        /// Return Type: UINT->unsigned int
        ///This: ITypeLib*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeInfoCount_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint ITypeLib_GetTypeInfoCount_Proxy(ref ITypeLib This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeComp_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib_GetTypeComp_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///ppTComp: ITypeComp**
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetTypeComp_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetTypeComp_Proxy(ref ITypeLib This, ref IntPtr ppTComp);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///ppTLibAttr: LPTLIBATTR*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetLibAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetLibAttr_Stub(ref ITypeLib This, ref IntPtr ppTLibAttr, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///ppTLibAttr: TLIBATTR**
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetLibAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetLibAttr_Proxy(ref ITypeLib This, ref IntPtr ppTLibAttr);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///index: INT->int
        ///refPtrFlags: DWORD->unsigned int
        ///pBstrName: BSTR*
        ///pBstrDocString: BSTR*
        ///pdwHelpContext: DWORD*
        ///pBstrHelpFile: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetDocumentation_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetDocumentation_Stub(ref ITypeLib This, int index, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDocString, ref uint pdwHelpContext, [MarshalAs(UnmanagedType.BStr)] ref string pBstrHelpFile);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///index: INT->int
        ///pBstrName: BSTR*
        ///pBstrDocString: BSTR*
        ///pdwHelpContext: DWORD*
        ///pBstrHelpFile: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_GetDocumentation_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_GetDocumentation_Proxy(ref ITypeLib This, int index, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDocString, ref uint pdwHelpContext, [MarshalAs(UnmanagedType.BStr)] ref string pBstrHelpFile);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///szNameBuf: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///ppTInfo: ITypeInfo**
        ///rgMemId: MEMBERID*
        ///pcFound: USHORT*
        ///pBstrLibName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_FindName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_FindName_Stub(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal, ref IntPtr ppTInfo, ref int rgMemId, ref ushort pcFound, [MarshalAs(UnmanagedType.BStr)] ref string pBstrLibName);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib*
        ///szNameBuf: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///ppTInfo: ITypeInfo**
        ///rgMemId: MEMBERID*
        ///pcFound: USHORT*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib_FindName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib_FindName_Proxy(ref ITypeLib This, IntPtr szNameBuf, uint lHashVal, ref IntPtr ppTInfo, ref int rgMemId, ref ushort pcFound);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_RemoteGetLibStatistics_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib2_RemoteGetLibStatistics_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///pcUniqueNames: ULONG*
        ///pcchUniqueNames: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_RemoteGetLibStatistics_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_RemoteGetLibStatistics_Proxy(ref ITypeLib2 This, ref uint pcUniqueNames, ref uint pcchUniqueNames);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_RemoteGetDocumentation2_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib2_RemoteGetDocumentation2_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///index: INT->int
        ///lcid: LCID->DWORD->unsigned int
        ///refPtrFlags: DWORD->unsigned int
        ///pbstrHelpString: BSTR*
        ///pdwHelpStringContext: DWORD*
        ///pbstrHelpStringDll: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_RemoteGetDocumentation2_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_RemoteGetDocumentation2_Proxy(ref ITypeLib2 This, int index, uint lcid, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpString, ref uint pdwHelpStringContext, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpStringDll);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///pcUniqueNames: ULONG*
        ///pcchUniqueNames: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetLibStatistics_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_GetLibStatistics_Stub(ref ITypeLib2 This, ref uint pcUniqueNames, ref uint pcchUniqueNames);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///pcUniqueNames: ULONG*
        ///pcchUniqueNames: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetLibStatistics_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_GetLibStatistics_Proxy(ref ITypeLib2 This, ref uint pcUniqueNames, ref uint pcchUniqueNames);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///index: INT->int
        ///lcid: LCID->DWORD->unsigned int
        ///refPtrFlags: DWORD->unsigned int
        ///pbstrHelpString: BSTR*
        ///pdwHelpStringContext: DWORD*
        ///pbstrHelpStringDll: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetDocumentation2_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_GetDocumentation2_Stub(ref ITypeLib2 This, int index, uint lcid, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpString, ref uint pdwHelpStringContext, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpStringDll);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///index: INT->int
        ///lcid: LCID->DWORD->unsigned int
        ///pbstrHelpString: BSTR*
        ///pdwHelpStringContext: DWORD*
        ///pbstrHelpStringDll: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetDocumentation2_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_GetDocumentation2_Proxy(ref ITypeLib2 This, int index, uint lcid, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpString, ref uint pdwHelpStringContext, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpStringDll);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib2_GetCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_GetCustData_Proxy(ref ITypeLib2 This, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetAllCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeLib2_GetAllCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeLib2*
        ///pCustData: CUSTDATA*
        [DllImport("<Unknown>", EntryPoint = "ITypeLib2_GetAllCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeLib2_GetAllCustData_Proxy(ref ITypeLib2 This, ref tagCUSTDATA pCustData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetVarDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteGetVarDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///ppVarDesc: LPVARDESC*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetVarDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteGetVarDesc_Proxy(ref ITypeInfo This, uint index, ref IntPtr ppVarDesc, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetTypeAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteGetTypeAttr_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///ppTypeAttr: LPTYPEATTR*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetTypeAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteGetTypeAttr_Proxy(ref ITypeInfo This, ref IntPtr ppTypeAttr, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteGetNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///rgBstrNames: BSTR*
        ///cMaxNames: UINT->unsigned int
        ///pcNames: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteGetNames_Proxy(ref ITypeInfo This, int memid, [MarshalAs(UnmanagedType.BStr)] ref string rgBstrNames, uint cMaxNames, ref uint pcNames);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetFuncDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteGetFuncDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///ppFuncDesc: LPFUNCDESC*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetFuncDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteGetFuncDesc_Proxy(ref ITypeInfo This, uint index, ref IntPtr ppFuncDesc, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetDocumentation_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteGetDocumentation_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///refPtrFlags: DWORD->unsigned int
        ///pBstrName: BSTR*
        ///pBstrDocString: BSTR*
        ///pdwHelpContext: DWORD*
        ///pBstrHelpFile: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetDocumentation_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteGetDocumentation_Proxy(ref ITypeInfo This, int memid, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDocString, ref uint pdwHelpContext, [MarshalAs(UnmanagedType.BStr)] ref string pBstrHelpFile);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetDllEntry_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteGetDllEntry_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///invKind: INVOKEKIND->tagINVOKEKIND
        ///refPtrFlags: DWORD->unsigned int
        ///pBstrDllName: BSTR*
        ///pBstrName: BSTR*
        ///pwOrdinal: WORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetDllEntry_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteGetDllEntry_Proxy(ref ITypeInfo This, int memid, tagINVOKEKIND invKind, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDllName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, ref ushort pwOrdinal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetContainingTypeLib_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteGetContainingTypeLib_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///ppTLib: ITypeLib**
        ///pIndex: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteGetContainingTypeLib_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteGetContainingTypeLib_Proxy(ref ITypeInfo This, ref IntPtr ppTLib, ref uint pIndex);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteCreateInstance_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_RemoteCreateInstance_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_RemoteCreateInstance_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_RemoteCreateInstance_Proxy(ref ITypeInfo This, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_ReleaseVarDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_ReleaseVarDesc_Stub(ref ITypeInfo This);


        /// Return Type: void
        ///This: ITypeInfo*
        ///pVarDesc: VARDESC*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_ReleaseVarDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_ReleaseVarDesc_Proxy(ref ITypeInfo This, ref tagVARDESC pVarDesc);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_ReleaseTypeAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_ReleaseTypeAttr_Stub(ref ITypeInfo This);


        /// Return Type: void
        ///This: ITypeInfo*
        ///pTypeAttr: TYPEATTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_ReleaseTypeAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_ReleaseTypeAttr_Proxy(ref ITypeInfo This, ref tagTYPEATTR pTypeAttr);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_ReleaseFuncDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_ReleaseFuncDesc_Stub(ref ITypeInfo This);


        /// Return Type: void
        ///This: ITypeInfo*
        ///pFuncDesc: FUNCDESC*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_ReleaseFuncDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_ReleaseFuncDesc_Proxy(ref ITypeInfo This, ref tagFUNCDESC pFuncDesc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalReleaseVarDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_LocalReleaseVarDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalReleaseVarDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_LocalReleaseVarDesc_Proxy(ref ITypeInfo This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalReleaseTypeAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_LocalReleaseTypeAttr_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalReleaseTypeAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_LocalReleaseTypeAttr_Proxy(ref ITypeInfo This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalReleaseFuncDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_LocalReleaseFuncDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalReleaseFuncDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_LocalReleaseFuncDesc_Proxy(ref ITypeInfo This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalInvoke_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_LocalInvoke_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalInvoke_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_LocalInvoke_Proxy(ref ITypeInfo This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalGetIDsOfNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_LocalGetIDsOfNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalGetIDsOfNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_LocalGetIDsOfNames_Proxy(ref ITypeInfo This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalAddressOfMember_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_LocalAddressOfMember_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_LocalAddressOfMember_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_LocalAddressOfMember_Proxy(ref ITypeInfo This);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_Invoke_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_Invoke_Stub(ref ITypeInfo This);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///pvInstance: PVOID->void*
        ///memid: MEMBERID->DISPID->LONG->int
        ///wFlags: WORD->unsigned short
        ///pDispParams: DISPPARAMS*
        ///pVarResult: VARIANT*
        ///pExcepInfo: EXCEPINFO*
        ///puArgErr: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_Invoke_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_Invoke_Proxy(ref ITypeInfo This, IntPtr pvInstance, int memid, ushort wFlags, ref tagDISPPARAMS pDispParams, ref tagVARIANT pVarResult, ref tagEXCEPINFO pExcepInfo, ref uint puArgErr);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///ppVarDesc: LPVARDESC*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetVarDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetVarDesc_Stub(ref ITypeInfo This, uint index, ref IntPtr ppVarDesc, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///ppVarDesc: VARDESC**
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetVarDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetVarDesc_Proxy(ref ITypeInfo This, uint index, ref IntPtr ppVarDesc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetTypeComp_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_GetTypeComp_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///ppTComp: ITypeComp**
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetTypeComp_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetTypeComp_Proxy(ref ITypeInfo This, ref IntPtr ppTComp);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///ppTypeAttr: LPTYPEATTR*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetTypeAttr_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetTypeAttr_Stub(ref ITypeInfo This, ref IntPtr ppTypeAttr, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///ppTypeAttr: TYPEATTR**
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetTypeAttr_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetTypeAttr_Proxy(ref ITypeInfo This, ref IntPtr ppTypeAttr);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetRefTypeOfImplType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_GetRefTypeOfImplType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///pRefType: HREFTYPE*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetRefTypeOfImplType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetRefTypeOfImplType_Proxy(ref ITypeInfo This, uint index, ref uint pRefType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetRefTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_GetRefTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///hRefType: HREFTYPE->DWORD->unsigned int
        ///ppTInfo: ITypeInfo**
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetRefTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetRefTypeInfo_Proxy(ref ITypeInfo This, uint hRefType, ref IntPtr ppTInfo);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///rgBstrNames: BSTR*
        ///cMaxNames: UINT->unsigned int
        ///pcNames: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetNames_Stub(ref ITypeInfo This, int memid, [MarshalAs(UnmanagedType.BStr)] ref string rgBstrNames, uint cMaxNames, ref uint pcNames);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///rgBstrNames: BSTR*
        ///cMaxNames: UINT->unsigned int
        ///pcNames: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetNames_Proxy(ref ITypeInfo This, int memid, [MarshalAs(UnmanagedType.BStr)] ref string rgBstrNames, uint cMaxNames, ref uint pcNames);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetMops_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_GetMops_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///pBstrMops: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetMops_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetMops_Proxy(ref ITypeInfo This, int memid, [MarshalAs(UnmanagedType.BStr)] ref string pBstrMops);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetImplTypeFlags_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo_GetImplTypeFlags_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///pImplTypeFlags: INT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetImplTypeFlags_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetImplTypeFlags_Proxy(ref ITypeInfo This, uint index, ref int pImplTypeFlags);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetIDsOfNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetIDsOfNames_Stub(ref ITypeInfo This);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///rgszNames: LPOLESTR*
        ///cNames: UINT->unsigned int
        ///pMemId: MEMBERID*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetIDsOfNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetIDsOfNames_Proxy(ref ITypeInfo This, ref IntPtr rgszNames, uint cNames, ref int pMemId);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///ppFuncDesc: LPFUNCDESC*
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetFuncDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetFuncDesc_Stub(ref ITypeInfo This, uint index, ref IntPtr ppFuncDesc, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///index: UINT->unsigned int
        ///ppFuncDesc: FUNCDESC**
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetFuncDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetFuncDesc_Proxy(ref ITypeInfo This, uint index, ref IntPtr ppFuncDesc);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///refPtrFlags: DWORD->unsigned int
        ///pBstrName: BSTR*
        ///pBstrDocString: BSTR*
        ///pdwHelpContext: DWORD*
        ///pBstrHelpFile: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetDocumentation_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetDocumentation_Stub(ref ITypeInfo This, int memid, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDocString, ref uint pdwHelpContext, [MarshalAs(UnmanagedType.BStr)] ref string pBstrHelpFile);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///pBstrName: BSTR*
        ///pBstrDocString: BSTR*
        ///pdwHelpContext: DWORD*
        ///pBstrHelpFile: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetDocumentation_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetDocumentation_Proxy(ref ITypeInfo This, int memid, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDocString, ref uint pdwHelpContext, [MarshalAs(UnmanagedType.BStr)] ref string pBstrHelpFile);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///invKind: INVOKEKIND->tagINVOKEKIND
        ///refPtrFlags: DWORD->unsigned int
        ///pBstrDllName: BSTR*
        ///pBstrName: BSTR*
        ///pwOrdinal: WORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetDllEntry_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetDllEntry_Stub(ref ITypeInfo This, int memid, tagINVOKEKIND invKind, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDllName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, ref ushort pwOrdinal);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///invKind: INVOKEKIND->tagINVOKEKIND
        ///pBstrDllName: BSTR*
        ///pBstrName: BSTR*
        ///pwOrdinal: WORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetDllEntry_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetDllEntry_Proxy(ref ITypeInfo This, int memid, tagINVOKEKIND invKind, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDllName, [MarshalAs(UnmanagedType.BStr)] ref string pBstrName, ref ushort pwOrdinal);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///ppTLib: ITypeLib**
        ///pIndex: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetContainingTypeLib_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetContainingTypeLib_Stub(ref ITypeInfo This, ref IntPtr ppTLib, ref uint pIndex);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///ppTLib: ITypeLib**
        ///pIndex: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_GetContainingTypeLib_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_GetContainingTypeLib_Proxy(ref ITypeInfo This, ref IntPtr ppTLib, ref uint pIndex);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_CreateInstance_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_CreateInstance_Stub(ref ITypeInfo This, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///pUnkOuter: IUnknown*
        ///riid: IID*
        ///ppvObj: PVOID*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_CreateInstance_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_CreateInstance_Proxy(ref ITypeInfo This, ref IUnknown pUnkOuter, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_AddressOfMember_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_AddressOfMember_Stub(ref ITypeInfo This);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo*
        ///memid: MEMBERID->DISPID->LONG->int
        ///invKind: INVOKEKIND->tagINVOKEKIND
        ///ppv: PVOID*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo_AddressOfMember_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo_AddressOfMember_Proxy(ref ITypeInfo This, int memid, tagINVOKEKIND invKind, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_RemoteGetDocumentation2_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_RemoteGetDocumentation2_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///memid: MEMBERID->DISPID->LONG->int
        ///lcid: LCID->DWORD->unsigned int
        ///refPtrFlags: DWORD->unsigned int
        ///pbstrHelpString: BSTR*
        ///pdwHelpStringContext: DWORD*
        ///pbstrHelpStringDll: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_RemoteGetDocumentation2_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_RemoteGetDocumentation2_Proxy(ref ITypeInfo2 This, int memid, uint lcid, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpString, ref uint pdwHelpStringContext, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpStringDll);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetVarIndexOfMemId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetVarIndexOfMemId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///memid: MEMBERID->DISPID->LONG->int
        ///pVarIndex: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetVarIndexOfMemId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetVarIndexOfMemId_Proxy(ref ITypeInfo2 This, int memid, ref uint pVarIndex);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetVarCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetVarCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///index: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetVarCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetVarCustData_Proxy(ref ITypeInfo2 This, uint index, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetTypeKind_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetTypeKind_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///pTypeKind: TYPEKIND*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetTypeKind_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetTypeKind_Proxy(ref ITypeInfo2 This, ref tagTYPEKIND pTypeKind);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetTypeFlags_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetTypeFlags_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///pTypeFlags: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetTypeFlags_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetTypeFlags_Proxy(ref ITypeInfo2 This, ref uint pTypeFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetParamCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetParamCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///indexFunc: UINT->unsigned int
        ///indexParam: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetParamCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetParamCustData_Proxy(ref ITypeInfo2 This, uint indexFunc, uint indexParam, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetImplTypeCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetImplTypeCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///index: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetImplTypeCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetImplTypeCustData_Proxy(ref ITypeInfo2 This, uint index, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetFuncIndexOfMemId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetFuncIndexOfMemId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///memid: MEMBERID->DISPID->LONG->int
        ///invKind: INVOKEKIND->tagINVOKEKIND
        ///pFuncIndex: UINT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetFuncIndexOfMemId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetFuncIndexOfMemId_Proxy(ref ITypeInfo2 This, int memid, tagINVOKEKIND invKind, ref uint pFuncIndex);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetFuncCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetFuncCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///index: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetFuncCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetFuncCustData_Proxy(ref ITypeInfo2 This, uint index, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///memid: MEMBERID->DISPID->LONG->int
        ///lcid: LCID->DWORD->unsigned int
        ///refPtrFlags: DWORD->unsigned int
        ///pbstrHelpString: BSTR*
        ///pdwHelpStringContext: DWORD*
        ///pbstrHelpStringDll: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetDocumentation2_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetDocumentation2_Stub(ref ITypeInfo2 This, int memid, uint lcid, uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpString, ref uint pdwHelpStringContext, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpStringDll);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///memid: MEMBERID->DISPID->LONG->int
        ///lcid: LCID->DWORD->unsigned int
        ///pbstrHelpString: BSTR*
        ///pdwHelpStringContext: DWORD*
        ///pbstrHelpStringDll: BSTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetDocumentation2_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetDocumentation2_Proxy(ref ITypeInfo2 This, int memid, uint lcid, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpString, ref uint pdwHelpStringContext, [MarshalAs(UnmanagedType.BStr)] ref string pbstrHelpStringDll);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetCustData_Proxy(ref ITypeInfo2 This, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllVarCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetAllVarCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///index: UINT->unsigned int
        ///pCustData: CUSTDATA*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllVarCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetAllVarCustData_Proxy(ref ITypeInfo2 This, uint index, ref tagCUSTDATA pCustData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllParamCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetAllParamCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///indexFunc: UINT->unsigned int
        ///indexParam: UINT->unsigned int
        ///pCustData: CUSTDATA*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllParamCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetAllParamCustData_Proxy(ref ITypeInfo2 This, uint indexFunc, uint indexParam, ref tagCUSTDATA pCustData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllImplTypeCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetAllImplTypeCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///index: UINT->unsigned int
        ///pCustData: CUSTDATA*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllImplTypeCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetAllImplTypeCustData_Proxy(ref ITypeInfo2 This, uint index, ref tagCUSTDATA pCustData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllFuncCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetAllFuncCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///index: UINT->unsigned int
        ///pCustData: CUSTDATA*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllFuncCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetAllFuncCustData_Proxy(ref ITypeInfo2 This, uint index, ref tagCUSTDATA pCustData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeInfo2_GetAllCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeInfo2*
        ///pCustData: CUSTDATA*
        [DllImport("<Unknown>", EntryPoint = "ITypeInfo2_GetAllCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeInfo2_GetAllCustData_Proxy(ref ITypeInfo2 This, ref tagCUSTDATA pCustData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeFactory_CreateFromTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeFactory_CreateFromTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeFactory*
        ///pTypeInfo: ITypeInfo*
        ///riid: IID*
        ///ppv: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "ITypeFactory_CreateFromTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeFactory_CreateFromTypeInfo_Proxy(ref ITypeFactory This, ref ITypeInfo pTypeInfo, ref GUID riid, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_RemoteBind_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeComp_RemoteBind_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeComp*
        ///szName: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///wFlags: WORD->unsigned short
        ///ppTInfo: ITypeInfo**
        ///pDescKind: DESCKIND*
        ///ppFuncDesc: LPFUNCDESC*
        ///ppVarDesc: LPVARDESC*
        ///ppTypeComp: ITypeComp**
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_RemoteBind_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeComp_RemoteBind_Proxy(ref ITypeComp This, IntPtr szName, uint lHashVal, ushort wFlags, ref IntPtr ppTInfo, ref tagDESCKIND pDescKind, ref IntPtr ppFuncDesc, ref IntPtr ppVarDesc, ref IntPtr ppTypeComp, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_RemoteBindType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeComp_RemoteBindType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeComp*
        ///szName: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///ppTInfo: ITypeInfo**
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_RemoteBindType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeComp_RemoteBindType_Proxy(ref ITypeComp This, IntPtr szName, uint lHashVal, ref IntPtr ppTInfo);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeComp*
        ///szName: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///wFlags: WORD->unsigned short
        ///ppTInfo: ITypeInfo**
        ///pDescKind: DESCKIND*
        ///ppFuncDesc: LPFUNCDESC*
        ///ppVarDesc: LPVARDESC*
        ///ppTypeComp: ITypeComp**
        ///pDummy: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_Bind_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeComp_Bind_Stub(ref ITypeComp This, IntPtr szName, uint lHashVal, ushort wFlags, ref IntPtr ppTInfo, ref tagDESCKIND pDescKind, ref IntPtr ppFuncDesc, ref IntPtr ppVarDesc, ref IntPtr ppTypeComp, ref tagCLEANLOCALSTORAGE pDummy);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeComp*
        ///szName: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///wFlags: WORD->unsigned short
        ///ppTInfo: ITypeInfo**
        ///pDescKind: DESCKIND*
        ///pBindPtr: BINDPTR*
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_Bind_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeComp_Bind_Proxy(ref ITypeComp This, IntPtr szName, uint lHashVal, ushort wFlags, ref IntPtr ppTInfo, ref tagDESCKIND pDescKind, ref tagBINDPTR pBindPtr);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeComp*
        ///szName: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///ppTInfo: ITypeInfo**
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_BindType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeComp_BindType_Stub(ref ITypeComp This, IntPtr szName, uint lHashVal, ref IntPtr ppTInfo);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeComp*
        ///szName: LPOLESTR->OLECHAR*
        ///lHashVal: ULONG->unsigned int
        ///ppTInfo: ITypeInfo**
        ///ppTComp: ITypeComp**
        [DllImport("<Unknown>", EntryPoint = "ITypeComp_BindType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeComp_BindType_Proxy(ref ITypeComp This, IntPtr szName, uint lHashVal, ref IntPtr ppTInfo, ref IntPtr ppTComp);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeChangeEvents_RequestTypeChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeChangeEvents_RequestTypeChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeChangeEvents*
        ///changeKind: CHANGEKIND->tagCHANGEKIND
        ///pTInfoBefore: ITypeInfo*
        ///pStrName: LPOLESTR->OLECHAR*
        ///pfCancel: INT*
        [DllImport("<Unknown>", EntryPoint = "ITypeChangeEvents_RequestTypeChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeChangeEvents_RequestTypeChange_Proxy(ref ITypeChangeEvents This, tagCHANGEKIND changeKind, ref ITypeInfo pTInfoBefore, IntPtr pStrName, ref int pfCancel);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITypeChangeEvents_AfterTypeChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITypeChangeEvents_AfterTypeChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITypeChangeEvents*
        ///changeKind: CHANGEKIND->tagCHANGEKIND
        ///pTInfoAfter: ITypeInfo*
        ///pStrName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ITypeChangeEvents_AfterTypeChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITypeChangeEvents_AfterTypeChange_Proxy(ref ITypeChangeEvents This, tagCHANGEKIND changeKind, ref ITypeInfo pTInfoAfter, IntPtr pStrName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ITimeAndNoticeControl_SuppressChanges_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ITimeAndNoticeControl_SuppressChanges_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ITimeAndNoticeControl*
        ///res1: DWORD->unsigned int
        ///res2: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ITimeAndNoticeControl_SuppressChanges_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ITimeAndNoticeControl_SuppressChanges_Proxy(ref ITimeAndNoticeControl This, uint res1, uint res2);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IThumbnailExtractor_OnFileUpdated_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IThumbnailExtractor_OnFileUpdated_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IThumbnailExtractor*
        ///pStg: IStorage*
        [DllImport("<Unknown>", EntryPoint = "IThumbnailExtractor_OnFileUpdated_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IThumbnailExtractor_OnFileUpdated_Proxy(ref IThumbnailExtractor This, ref IStorage pStg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IThumbnailExtractor_ExtractThumbnail_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IThumbnailExtractor_ExtractThumbnail_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IThumbnailExtractor*
        ///pStg: IStorage*
        ///ulLength: ULONG->unsigned int
        ///ulHeight: ULONG->unsigned int
        ///pulOutputLength: ULONG*
        ///pulOutputHeight: ULONG*
        ///phOutputBitmap: HBITMAP*
        [DllImport("<Unknown>", EntryPoint = "IThumbnailExtractor_ExtractThumbnail_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IThumbnailExtractor_ExtractThumbnail_Proxy(ref IThumbnailExtractor This, ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, ref IntPtr phOutputBitmap);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Type: wctype_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "is_wctype", CallingConvention = CallingConvention.Cdecl)]
        public static extern int is_wctype(ushort _C, ushort _Type);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsZoomed")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsZoomed([In] IntPtr hWnd);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronize_Wait_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronize_Wait_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronize*
        ///dwFlags: DWORD->unsigned int
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ISynchronize_Wait_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronize_Wait_Proxy(ref ISynchronize This, uint dwFlags, uint dwMilliseconds);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronize_Signal_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronize_Signal_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronize*
        [DllImport("<Unknown>", EntryPoint = "ISynchronize_Signal_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronize_Signal_Proxy(ref ISynchronize This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronize_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronize_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronize*
        [DllImport("<Unknown>", EntryPoint = "ISynchronize_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronize_Reset_Proxy(ref ISynchronize This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeMutex_ReleaseMutex_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronizeMutex_ReleaseMutex_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronizeMutex*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeMutex_ReleaseMutex_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronizeMutex_ReleaseMutex_Proxy(ref ISynchronizeMutex This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeHandle_GetHandle_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronizeHandle_GetHandle_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronizeHandle*
        ///ph: HANDLE*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeHandle_GetHandle_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronizeHandle_GetHandle_Proxy(ref ISynchronizeHandle This, ref IntPtr ph);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeEvent_SetEventHandle_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronizeEvent_SetEventHandle_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronizeEvent*
        ///ph: HANDLE*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeEvent_SetEventHandle_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronizeEvent_SetEventHandle_Proxy(ref ISynchronizeEvent This, ref IntPtr ph);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeContainer_WaitMultiple_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronizeContainer_WaitMultiple_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronizeContainer*
        ///dwFlags: DWORD->unsigned int
        ///dwTimeOut: DWORD->unsigned int
        ///ppSync: ISynchronize**
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeContainer_WaitMultiple_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronizeContainer_WaitMultiple_Proxy(ref ISynchronizeContainer This, uint dwFlags, uint dwTimeOut, ref IntPtr ppSync);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeContainer_AddSynchronize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISynchronizeContainer_AddSynchronize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISynchronizeContainer*
        ///pSync: ISynchronize*
        [DllImport("<Unknown>", EntryPoint = "ISynchronizeContainer_AddSynchronize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISynchronizeContainer_AddSynchronize_Proxy(ref ISynchronizeContainer This, ref ISynchronize pSync);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isxdigit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isxdigit(int _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "iswxdigit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswxdigit(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "iswupper", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswupper(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "iswspace", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswspace(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "iswpunct", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswpunct(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "iswprint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswprint(ushort _C);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///Wow64Process: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "IsWow64Process")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out int Wow64Process);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "IsWow64Message")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Message();


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "iswlower", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswlower(ushort _C);


        /// Return Type: BOOL->int
        ///event: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "IsWinEventHookInstalled")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWinEventHookInstalled(uint @event);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindowUnicode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowUnicode([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindowEnabled")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowEnabled([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow([In] IntPtr hWnd);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "iswgraph", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswgraph(ushort _C);


        /// Return Type: BOOL->int
        ///pSid: PSID->PVOID->void*
        ///WellKnownSidType: WELL_KNOWN_SID_TYPE->Anonymous_2a66b804_5814_4d7a_8190_9d15131e188a
        [DllImport("advapi32.dll", EntryPoint = "IsWellKnownSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWellKnownSid([In] IntPtr pSid, WELL_KNOWN_SID_TYPE WellKnownSidType);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "iswdigit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswdigit(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Type: wctype_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "iswctype", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswctype(ushort _C, ushort _Type);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "iswcntrl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswcntrl(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "iswascii", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswascii(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("ntdll.dll", EntryPoint = "iswalpha", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswalpha(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "iswalnum", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iswalnum(ushort _C);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///szURL: LPCWSTR->WCHAR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "IsValidURL", CallingConvention = CallingConvention.StdCall)]
        public static extern int IsValidURL(ref IBindCtx pBC, [In] [MarshalAs(UnmanagedType.LPWStr)] string szURL, uint dwReserved);


        /// Return Type: BOOL->int
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "IsValidSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidSid([In] IntPtr pSid);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "IsValidSecurityDescriptor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidSecurityDescriptor([In] IntPtr pSecurityDescriptor);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsValidLocale")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidLocale(uint Locale, uint dwFlags);


        /// Return Type: BOOL->int
        ///LanguageGroup: LGRPID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsValidLanguageGroup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidLanguageGroup(uint LanguageGroup, uint dwFlags);


        /// Return Type: BOOL->int
        ///pDevmode: PDEVMODEW->_devicemodeW*
        ///DevmodeSize: size_t->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IsValidDevmodeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidDevmodeW([In] ref DEVMODEW pDevmode, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr DevmodeSize);


        /// Return Type: BOOL->int
        ///pDevmode: PDEVMODEA->_devicemodeA*
        ///DevmodeSize: size_t->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IsValidDevmodeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidDevmodeA([In] ref DEVMODEA pDevmode, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr DevmodeSize);


        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsValidCodePage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidCodePage(uint CodePage);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        [DllImport("advapi32.dll", EntryPoint = "IsValidAcl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsValidAcl([In] ref ACL pAcl);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISurrogate_LoadDllServer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISurrogate_LoadDllServer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISurrogate*
        ///Clsid: IID*
        [DllImport("<Unknown>", EntryPoint = "ISurrogate_LoadDllServer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISurrogate_LoadDllServer_Proxy(ref ISurrogate This, ref GUID Clsid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISurrogate_FreeSurrogate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISurrogate_FreeSurrogate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISurrogate*
        [DllImport("<Unknown>", EntryPoint = "ISurrogate_FreeSurrogate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISurrogate_FreeSurrogate_Proxy(ref ISurrogate This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_ProcessShutdown_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISurrogateService_ProcessShutdown_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISurrogateService*
        ///shutdownType: ShutdownType->tagShutdownType
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_ProcessShutdown_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISurrogateService_ProcessShutdown_Proxy(ref ISurrogateService This, tagShutdownType shutdownType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_Init_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISurrogateService_Init_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISurrogateService*
        ///rguidProcessID: GUID*
        ///pProcessLock: IProcessLock*
        ///pfApplicationAware: BOOL*
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_Init_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISurrogateService_Init_Proxy(ref ISurrogateService This, ref GUID rguidProcessID, ref IProcessLock pProcessLock, ref int pfApplicationAware);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_CatalogRefresh_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISurrogateService_CatalogRefresh_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISurrogateService*
        ///ulReserved: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_CatalogRefresh_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISurrogateService_CatalogRefresh_Proxy(ref ISurrogateService This, uint ulReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_ApplicationLaunch_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISurrogateService_ApplicationLaunch_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISurrogateService*
        ///rguidApplID: GUID*
        ///appType: ApplicationType->tagApplicationType
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_ApplicationLaunch_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISurrogateService_ApplicationLaunch_Proxy(ref ISurrogateService This, ref GUID rguidApplID, tagApplicationType appType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_ApplicationFree_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISurrogateService_ApplicationFree_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISurrogateService*
        ///rguidApplID: GUID*
        [DllImport("<Unknown>", EntryPoint = "ISurrogateService_ApplicationFree_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISurrogateService_ApplicationFree_Proxy(ref ISurrogateService This, ref GUID rguidApplID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISupportErrorInfo_InterfaceSupportsErrorInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISupportErrorInfo_InterfaceSupportsErrorInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISupportErrorInfo*
        ///riid: IID*
        [DllImport("<Unknown>", EntryPoint = "ISupportErrorInfo_InterfaceSupportsErrorInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISupportErrorInfo_InterfaceSupportsErrorInfo_Proxy(ref ISupportErrorInfo This, ref GUID riid);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isupper", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isupper(int _C);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_UnlockRegion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_UnlockRegion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///libOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        ///dwLockType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStream_UnlockRegion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_UnlockRegion_Proxy(ref IStream This, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_Stat_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_Stat_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///pstatstg: STATSTG*
        ///grfStatFlag: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStream_Stat_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_Stat_Proxy(ref IStream This, ref tagSTATSTG pstatstg, uint grfStatFlag);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_SetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_SetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///libNewSize: ULARGE_INTEGER->_ULARGE_INTEGER
        [DllImport("<Unknown>", EntryPoint = "IStream_SetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_SetSize_Proxy(ref IStream This, ULARGE_INTEGER libNewSize);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///dlibMove: LARGE_INTEGER->_LARGE_INTEGER
        ///dwOrigin: DWORD->unsigned int
        ///plibNewPosition: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IStream_Seek_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_Seek_Stub(ref IStream This, LARGE_INTEGER dlibMove, uint dwOrigin, ref ULARGE_INTEGER plibNewPosition);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///dlibMove: LARGE_INTEGER->_LARGE_INTEGER
        ///dwOrigin: DWORD->unsigned int
        ///plibNewPosition: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IStream_Seek_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_Seek_Proxy(ref IStream This, LARGE_INTEGER dlibMove, uint dwOrigin, ref ULARGE_INTEGER plibNewPosition);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_Revert_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_Revert_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        [DllImport("<Unknown>", EntryPoint = "IStream_Revert_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_Revert_Proxy(ref IStream This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_RemoteSeek_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_RemoteSeek_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///dlibMove: LARGE_INTEGER->_LARGE_INTEGER
        ///dwOrigin: DWORD->unsigned int
        ///plibNewPosition: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IStream_RemoteSeek_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_RemoteSeek_Proxy(ref IStream This, LARGE_INTEGER dlibMove, uint dwOrigin, ref ULARGE_INTEGER plibNewPosition);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_RemoteCopyTo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_RemoteCopyTo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///pstm: IStream*
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pcbRead: ULARGE_INTEGER*
        ///pcbWritten: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IStream_RemoteCopyTo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_RemoteCopyTo_Proxy(ref IStream This, ref IStream pstm, ULARGE_INTEGER cb, ref ULARGE_INTEGER pcbRead, ref ULARGE_INTEGER pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_LockRegion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_LockRegion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///libOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        ///dwLockType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStream_LockRegion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_LockRegion_Proxy(ref IStream This, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///pstm: IStream*
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pcbRead: ULARGE_INTEGER*
        ///pcbWritten: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IStream_CopyTo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_CopyTo_Stub(ref IStream This, ref IStream pstm, ULARGE_INTEGER cb, ref ULARGE_INTEGER pcbRead, ref ULARGE_INTEGER pcbWritten);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///pstm: IStream*
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pcbRead: ULARGE_INTEGER*
        ///pcbWritten: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IStream_CopyTo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_CopyTo_Proxy(ref IStream This, ref IStream pstm, ULARGE_INTEGER cb, ref ULARGE_INTEGER pcbRead, ref ULARGE_INTEGER pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_Commit_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_Commit_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///grfCommitFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStream_Commit_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_Commit_Proxy(ref IStream This, uint grfCommitFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStream_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStream_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStream*
        ///ppstm: IStream**
        [DllImport("<Unknown>", EntryPoint = "IStream_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStream_Clone_Proxy(ref IStream This, ref IntPtr ppstm);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_Stat_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_Stat_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pstatstg: STATSTG*
        ///grfStatFlag: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStorage_Stat_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_Stat_Proxy(ref IStorage This, ref tagSTATSTG pstatstg, uint grfStatFlag);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_SetStateBits_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_SetStateBits_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///grfStateBits: DWORD->unsigned int
        ///grfMask: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStorage_SetStateBits_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_SetStateBits_Proxy(ref IStorage This, uint grfStateBits, uint grfMask);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_SetElementTimes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_SetElementTimes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///pctime: FILETIME*
        ///patime: FILETIME*
        ///pmtime: FILETIME*
        [DllImport("<Unknown>", EntryPoint = "IStorage_SetElementTimes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_SetElementTimes_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_SetClass_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_SetClass_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///clsid: IID*
        [DllImport("<Unknown>", EntryPoint = "IStorage_SetClass_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_SetClass_Proxy(ref IStorage This, ref GUID clsid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_Revert_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_Revert_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        [DllImport("<Unknown>", EntryPoint = "IStorage_Revert_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_Revert_Proxy(ref IStorage This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_RenameElement_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_RenameElement_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsOldName: OLECHAR*
        ///pwcsNewName: OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IStorage_RenameElement_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_RenameElement_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsOldName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsNewName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_RemoteOpenStream_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_RemoteOpenStream_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///cbReserved1: unsigned int
        ///reserved1: byte*
        ///grfMode: DWORD->unsigned int
        ///reserved2: DWORD->unsigned int
        ///ppstm: IStream**
        [DllImport("<Unknown>", EntryPoint = "IStorage_RemoteOpenStream_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_RemoteOpenStream_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint cbReserved1, ref byte reserved1, uint grfMode, uint reserved2, ref IntPtr ppstm);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_RemoteEnumElements_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_RemoteEnumElements_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///reserved1: DWORD->unsigned int
        ///cbReserved2: unsigned int
        ///reserved2: byte*
        ///reserved3: DWORD->unsigned int
        ///ppenum: IEnumSTATSTG**
        [DllImport("<Unknown>", EntryPoint = "IStorage_RemoteEnumElements_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_RemoteEnumElements_Proxy(ref IStorage This, uint reserved1, uint cbReserved2, ref byte reserved2, uint reserved3, ref IntPtr ppenum);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///cbReserved1: unsigned int
        ///reserved1: byte*
        ///grfMode: DWORD->unsigned int
        ///reserved2: DWORD->unsigned int
        ///ppstm: IStream**
        [DllImport("<Unknown>", EntryPoint = "IStorage_OpenStream_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_OpenStream_Stub(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint cbReserved1, ref byte reserved1, uint grfMode, uint reserved2, ref IntPtr ppstm);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///reserved1: void*
        ///grfMode: DWORD->unsigned int
        ///reserved2: DWORD->unsigned int
        ///ppstm: IStream**
        [DllImport("<Unknown>", EntryPoint = "IStorage_OpenStream_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_OpenStream_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, IntPtr reserved1, uint grfMode, uint reserved2, ref IntPtr ppstm);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_OpenStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_OpenStorage_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///pstgPriority: IStorage*
        ///grfMode: DWORD->unsigned int
        ///snbExclude: SNB->OLECHAR**
        ///reserved: DWORD->unsigned int
        ///ppstg: IStorage**
        [DllImport("<Unknown>", EntryPoint = "IStorage_OpenStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_OpenStorage_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, ref IStorage pstgPriority, uint grfMode, ref IntPtr snbExclude, uint reserved, ref IntPtr ppstg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_MoveElementTo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_MoveElementTo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///pstgDest: IStorage*
        ///pwcsNewName: OLECHAR*
        ///grfFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStorage_MoveElementTo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_MoveElementTo_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, ref IStorage pstgDest, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsNewName, uint grfFlags);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///reserved1: DWORD->unsigned int
        ///cbReserved2: unsigned int
        ///reserved2: byte*
        ///reserved3: DWORD->unsigned int
        ///ppenum: IEnumSTATSTG**
        [DllImport("<Unknown>", EntryPoint = "IStorage_EnumElements_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_EnumElements_Stub(ref IStorage This, uint reserved1, uint cbReserved2, ref byte reserved2, uint reserved3, ref IntPtr ppenum);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///reserved1: DWORD->unsigned int
        ///reserved2: void*
        ///reserved3: DWORD->unsigned int
        ///ppenum: IEnumSTATSTG**
        [DllImport("<Unknown>", EntryPoint = "IStorage_EnumElements_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_EnumElements_Proxy(ref IStorage This, uint reserved1, IntPtr reserved2, uint reserved3, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_DestroyElement_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_DestroyElement_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IStorage_DestroyElement_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_DestroyElement_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_CreateStream_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_CreateStream_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///grfMode: DWORD->unsigned int
        ///reserved1: DWORD->unsigned int
        ///reserved2: DWORD->unsigned int
        ///ppstm: IStream**
        [DllImport("<Unknown>", EntryPoint = "IStorage_CreateStream_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_CreateStream_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IntPtr ppstm);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_CreateStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_CreateStorage_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///pwcsName: OLECHAR*
        ///grfMode: DWORD->unsigned int
        ///reserved1: DWORD->unsigned int
        ///reserved2: DWORD->unsigned int
        ///ppstg: IStorage**
        [DllImport("<Unknown>", EntryPoint = "IStorage_CreateStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_CreateStorage_Proxy(ref IStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IntPtr ppstg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_CopyTo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_CopyTo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///ciidExclude: DWORD->unsigned int
        ///rgiidExclude: IID*
        ///snbExclude: SNB->OLECHAR**
        ///pstgDest: IStorage*
        [DllImport("<Unknown>", EntryPoint = "IStorage_CopyTo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_CopyTo_Proxy(ref IStorage This, uint ciidExclude, ref GUID rgiidExclude, ref IntPtr snbExclude, ref IStorage pstgDest);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStorage_Commit_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStorage_Commit_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStorage*
        ///grfCommitFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IStorage_Commit_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStorage_Commit_Proxy(ref IStorage This, uint grfCommitFlags);


        /// Return Type: BOOL->int
        ///TokenHandle: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "IsTokenUntrusted")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsTokenUntrusted([In] IntPtr TokenHandle);


        /// Return Type: BOOL->int
        ///TokenHandle: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "IsTokenRestricted")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsTokenRestricted([In] IntPtr TokenHandle);


        /// Return Type: BOOL->int
        ///lpv: void*
        ///iSize: int
        ///lpiResult: LPINT->int*
        [DllImport("advapi32.dll", EntryPoint = "IsTextUnicode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsTextUnicode([In] IntPtr lpv, int iSize, IntPtr lpiResult);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IStdMarshalInfo_GetClassForHandler_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IStdMarshalInfo_GetClassForHandler_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IStdMarshalInfo*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: void*
        ///pClsid: CLSID*
        [DllImport("<Unknown>", EntryPoint = "IStdMarshalInfo_GetClassForHandler_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IStdMarshalInfo_GetClassForHandler_Proxy(ref IStdMarshalInfo This, uint dwDestContext, IntPtr pvDestContext, ref GUID pClsid);


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "IsSystemResumeAutomatic")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsSystemResumeAutomatic();


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isspace", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isspace(int _C);


        /// Return Type: BOOL->int
        ///lprc: RECT*
        [DllImport("user32.dll", EntryPoint = "IsRectEmpty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsRectEmpty([In] ref tagRECT lprc);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "ispunct", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ispunct(int _C);


        /// Return Type: BOOL->int
        ///ProcessorFeature: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsProcessorFeaturePresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsProcessorFeaturePresent(uint ProcessorFeature);


        /// Return Type: BOOL->int
        ///ProcessHandle: HANDLE->void*
        ///JobHandle: HANDLE->void*
        ///Result: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "IsProcessInJob")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsProcessInJob([In] IntPtr ProcessHandle, [In] IntPtr JobHandle, [Out] out int Result);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isprint", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isprint(int _C);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_ProcessSoftDist_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISoftDistExt_ProcessSoftDist_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISoftDistExt*
        ///szCDFURL: LPCWSTR->WCHAR*
        ///pSoftDistElement: IXMLElement*
        ///lpsdi: LPSOFTDISTINFO->_tagSOFTDISTINFO*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_ProcessSoftDist_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISoftDistExt_ProcessSoftDist_Proxy(ref ISoftDistExt This, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCDFURL, ref IXMLElement pSoftDistElement, ref SOFTDISTINFO lpsdi);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_GetNextCodeBase_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISoftDistExt_GetNextCodeBase_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISoftDistExt*
        ///szCodeBase: LPWSTR*
        ///dwMaxSize: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_GetNextCodeBase_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISoftDistExt_GetNextCodeBase_Proxy(ref ISoftDistExt This, ref IntPtr szCodeBase, ref uint dwMaxSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_GetFirstCodeBase_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISoftDistExt_GetFirstCodeBase_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISoftDistExt*
        ///szCodeBase: LPWSTR*
        ///dwMaxSize: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_GetFirstCodeBase_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISoftDistExt_GetFirstCodeBase_Proxy(ref ISoftDistExt This, ref IntPtr szCodeBase, ref uint dwMaxSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_AsyncInstallDistributionUnit_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISoftDistExt_AsyncInstallDistributionUnit_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISoftDistExt*
        ///pbc: IBindCtx*
        ///pvReserved: LPVOID->void*
        ///flags: DWORD->unsigned int
        ///lpcbh: LPCODEBASEHOLD->_tagCODEBASEHOLD*
        [DllImport("<Unknown>", EntryPoint = "ISoftDistExt_AsyncInstallDistributionUnit_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISoftDistExt_AsyncInstallDistributionUnit_Proxy(ref ISoftDistExt This, ref IBindCtx pbc, IntPtr pvReserved, uint flags, ref CODEBASEHOLD lpcbh);


        /// Return Type: BOOL->int
        ///Function: NLS_FUNCTION->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpVersionInformation: LPNLSVERSIONINFO->_nlsversioninfo*
        ///lpString: LPCWSTR->WCHAR*
        ///cchStr: INT->int
        [DllImport("kernel32.dll", EntryPoint = "IsNLSDefinedString")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsNLSDefinedString(uint Function, uint dwFlags, [In] ref NLSVERSIONINFO lpVersionInformation, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int cchStr);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "IsMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsMenu([In] IntPtr hMenu);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "islower", CallingConvention = CallingConvention.Cdecl)]
        public static extern int islower(int _C);


        /// Return Type: BOOL->int
        ///pwszUrl: LPCWSTR->WCHAR*
        [DllImport("urlmon.dll", EntryPoint = "IsLoggingEnabledW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsLoggingEnabledW([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl);


        /// Return Type: BOOL->int
        ///pszUrl: LPCSTR->CHAR*
        [DllImport("urlmon.dll", EntryPoint = "IsLoggingEnabledA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsLoggingEnabledA([In] [MarshalAs(UnmanagedType.LPStr)] string pszUrl);


        /// Return Type: int
        ///_C: int
        [DllImport("msvcr80.dll", EntryPoint = "isleadbyte", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isleadbyte(int _C);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsIconic")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsIconic([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsHungAppWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsHungAppWindow([In] IntPtr hwnd);


        /// Return Type: BOOL->int
        ///bConvert: BOOL->int
        [DllImport("user32.dll", EntryPoint = "IsGUIThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsGUIThread([MarshalAs(UnmanagedType.Bool)] bool bConvert);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isgraph", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isgraph(int _C);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IServiceProvider_RemoteQueryService_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IServiceProvider_RemoteQueryService_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IServiceProvider*
        ///guidService: GUID*
        ///riid: IID*
        ///ppvObject: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IServiceProvider_RemoteQueryService_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IServiceProvider_RemoteQueryService_Proxy(ref IServiceProvider This, ref GUID guidService, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IServiceProvider*
        ///guidService: GUID*
        ///riid: IID*
        ///ppvObject: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IServiceProvider_QueryService_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IServiceProvider_QueryService_Stub(ref IServiceProvider This, ref GUID guidService, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IServiceProvider*
        ///guidService: GUID*
        ///riid: IID*
        ///ppvObject: void**
        [DllImport("<Unknown>", EntryPoint = "IServiceProvider_QueryService_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IServiceProvider_QueryService_Proxy(ref IServiceProvider This, ref GUID guidService, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_RevertToSelf_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IServerSecurity_RevertToSelf_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IServerSecurity*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_RevertToSelf_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IServerSecurity_RevertToSelf_Proxy(ref IServerSecurity This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_QueryBlanket_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IServerSecurity_QueryBlanket_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IServerSecurity*
        ///pAuthnSvc: DWORD*
        ///pAuthzSvc: DWORD*
        ///pServerPrincName: OLECHAR**
        ///pAuthnLevel: DWORD*
        ///pImpLevel: DWORD*
        ///pPrivs: void**
        ///pCapabilities: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_QueryBlanket_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IServerSecurity_QueryBlanket_Proxy(ref IServerSecurity This, ref uint pAuthnSvc, ref uint pAuthzSvc, ref IntPtr pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref IntPtr pPrivs, ref uint pCapabilities);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_IsImpersonating_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IServerSecurity_IsImpersonating_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: BOOL->int
        ///This: IServerSecurity*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_IsImpersonating_Proxy", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IServerSecurity_IsImpersonating_Proxy(ref IServerSecurity This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_ImpersonateClient_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IServerSecurity_ImpersonateClient_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IServerSecurity*
        [DllImport("<Unknown>", EntryPoint = "IServerSecurity_ImpersonateClient_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IServerSecurity_ImpersonateClient_Proxy(ref IServerSecurity This);


        /// Return Type: HRESULT->LONG->int
        ///This: ISequentialStream*
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_Write_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISequentialStream_Write_Stub(ref ISequentialStream This, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: HRESULT->LONG->int
        ///This: ISequentialStream*
        ///pv: void*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_Write_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISequentialStream_Write_Proxy(ref ISequentialStream This, IntPtr pv, uint cb, ref uint pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_RemoteWrite_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISequentialStream_RemoteWrite_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISequentialStream*
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_RemoteWrite_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISequentialStream_RemoteWrite_Proxy(ref ISequentialStream This, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_RemoteRead_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ISequentialStream_RemoteRead_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ISequentialStream*
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_RemoteRead_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISequentialStream_RemoteRead_Proxy(ref ISequentialStream This, ref byte pv, uint cb, ref uint pcbRead);


        /// Return Type: HRESULT->LONG->int
        ///This: ISequentialStream*
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_Read_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISequentialStream_Read_Stub(ref ISequentialStream This, ref byte pv, uint cb, ref uint pcbRead);


        /// Return Type: HRESULT->LONG->int
        ///This: ISequentialStream*
        ///pv: void*
        ///cb: ULONG->unsigned int
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ISequentialStream_Read_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ISequentialStream_Read_Proxy(ref ISequentialStream This, IntPtr pv, uint cb, ref uint pcbRead);


        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        [DllImport("user32.dll", EntryPoint = "IsDlgButtonChecked")]
        public static extern uint IsDlgButtonChecked([In] IntPtr hDlg, int nIDButton);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isdigit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isdigit(int _C);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "IsDialogMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDialogMessageW([In] IntPtr hDlg, [In] ref tagMSG lpMsg);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///lpMsg: LPMSG->tagMSG*
        [DllImport("user32.dll", EntryPoint = "IsDialogMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDialogMessageA([In] IntPtr hDlg, [In] ref tagMSG lpMsg);


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDebuggerPresent();


        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///TestChar: BYTE->unsigned char
        [DllImport("kernel32.dll", EntryPoint = "IsDBCSLeadByteEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDBCSLeadByteEx(uint CodePage, byte TestChar);


        /// Return Type: BOOL->int
        ///TestChar: BYTE->unsigned char
        [DllImport("kernel32.dll", EntryPoint = "IsDBCSLeadByte")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDBCSLeadByte(byte TestChar);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "iscntrl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iscntrl(int _C);


        /// Return Type: BOOL->int
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsClipboardFormatAvailable(uint format);


        /// Return Type: BOOL->int
        ///hWndParent: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "IsChild")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsChild([In] IntPtr hWndParent, [In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharUpperW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharUpperW(char ch);


        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharUpperA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharUpperA(byte ch);


        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharLowerW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharLowerW(char ch);


        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharLowerA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharLowerA(byte ch);


        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaW(char ch);


        /// Return Type: BOOL->int
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaNumericW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaNumericW(char ch);


        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaNumericA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaNumericA(byte ch);


        /// Return Type: BOOL->int
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "IsCharAlphaA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaA(byte ch);


        /// Return Type: BOOL->int
        ///lp: LPVOID->void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadWritePtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadWritePtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr ucb);


        /// Return Type: BOOL->int
        ///lpsz: LPCWSTR->WCHAR*
        ///ucchMax: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadStringPtrW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadStringPtrW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpsz, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr ucchMax);


        /// Return Type: BOOL->int
        ///lpsz: LPCSTR->CHAR*
        ///ucchMax: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadStringPtrA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadStringPtrA([In] [MarshalAs(UnmanagedType.LPStr)] string lpsz, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr ucchMax);


        /// Return Type: BOOL->int
        ///lp: void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadReadPtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadReadPtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr ucb);


        /// Return Type: BOOL->int
        ///lp: LPVOID->void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadHugeWritePtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadHugeWritePtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr ucb);


        /// Return Type: BOOL->int
        ///lp: void*
        ///ucb: UINT_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "IsBadHugeReadPtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadHugeReadPtr([In] IntPtr lp, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr ucb);


        /// Return Type: BOOL->int
        ///lpfn: FARPROC
        [DllImport("kernel32.dll", EntryPoint = "IsBadCodePtr")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsBadCodePtr(FARPROC lpfn);


        /// Return Type: HRESULT->LONG->int
        ///pmk: IMoniker*
        [DllImport("urlmon.dll", EntryPoint = "IsAsyncMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int IsAsyncMoniker(ref IMoniker pmk);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isalpha", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isalpha(int _C);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "isalnum", CallingConvention = CallingConvention.Cdecl)]
        public static extern int isalnum(int _C);


        /// Return Type: BOOL->int
        ///hAccel: HACCEL->HACCEL__*
        ///cAccelEntries: int
        ///lpMsg: LPMSG->tagMSG*
        ///lpwCmd: WORD*
        [DllImport("ole32.dll", EntryPoint = "IsAccelerator", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsAccelerator(IntPtr hAccel, int cAccelEntries, ref tagMSG lpMsg, ref ushort lpwCmd);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_Revoke_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunningObjectTable_Revoke_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunningObjectTable*
        ///dwRegister: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_Revoke_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunningObjectTable_Revoke_Proxy(ref IRunningObjectTable This, uint dwRegister);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_Register_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunningObjectTable_Register_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunningObjectTable*
        ///grfFlags: DWORD->unsigned int
        ///punkObject: IUnknown*
        ///pmkObjectName: IMoniker*
        ///pdwRegister: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_Register_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunningObjectTable_Register_Proxy(ref IRunningObjectTable This, uint grfFlags, ref IUnknown punkObject, ref IMoniker pmkObjectName, ref uint pdwRegister);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_NoteChangeTime_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunningObjectTable_NoteChangeTime_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunningObjectTable*
        ///dwRegister: DWORD->unsigned int
        ///pfiletime: FILETIME*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_NoteChangeTime_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunningObjectTable_NoteChangeTime_Proxy(ref IRunningObjectTable This, uint dwRegister, ref FILETIME pfiletime);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_IsRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunningObjectTable_IsRunning_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunningObjectTable*
        ///pmkObjectName: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_IsRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunningObjectTable_IsRunning_Proxy(ref IRunningObjectTable This, ref IMoniker pmkObjectName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_GetTimeOfLastChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunningObjectTable_GetTimeOfLastChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunningObjectTable*
        ///pmkObjectName: IMoniker*
        ///pfiletime: FILETIME*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_GetTimeOfLastChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunningObjectTable_GetTimeOfLastChange_Proxy(ref IRunningObjectTable This, ref IMoniker pmkObjectName, ref FILETIME pfiletime);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_GetObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunningObjectTable_GetObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunningObjectTable*
        ///pmkObjectName: IMoniker*
        ///ppunkObject: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_GetObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunningObjectTable_GetObject_Proxy(ref IRunningObjectTable This, ref IMoniker pmkObjectName, ref IntPtr ppunkObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_EnumRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunningObjectTable_EnumRunning_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunningObjectTable*
        ///ppenumMoniker: IEnumMoniker**
        [DllImport("<Unknown>", EntryPoint = "IRunningObjectTable_EnumRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunningObjectTable_EnumRunning_Proxy(ref IRunningObjectTable This, ref IntPtr ppenumMoniker);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_SetContainedObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunnableObject_SetContainedObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunnableObject*
        ///fContained: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_SetContainedObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunnableObject_SetContainedObject_Proxy(ref IRunnableObject This, [MarshalAs(UnmanagedType.Bool)] bool fContained);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_Run_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunnableObject_Run_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunnableObject*
        ///pbc: LPBINDCTX->IBindCtx*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_Run_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunnableObject_Run_Proxy(ref IRunnableObject This, ref IBindCtx pbc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_RemoteIsRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunnableObject_RemoteIsRunning_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunnableObject*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_RemoteIsRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunnableObject_RemoteIsRunning_Proxy(ref IRunnableObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_LockRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunnableObject_LockRunning_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunnableObject*
        ///fLock: BOOL->int
        ///fLastUnlockCloses: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_LockRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunnableObject_LockRunning_Proxy(ref IRunnableObject This, [MarshalAs(UnmanagedType.Bool)] bool fLock, [MarshalAs(UnmanagedType.Bool)] bool fLastUnlockCloses);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunnableObject*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_IsRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunnableObject_IsRunning_Stub(ref IRunnableObject This);


        /// Return Type: BOOL->int
        ///This: IRunnableObject*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_IsRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IRunnableObject_IsRunning_Proxy(ref IRunnableObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_GetRunningClass_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRunnableObject_GetRunningClass_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRunnableObject*
        ///lpClsid: LPCLSID->CLSID*
        [DllImport("<Unknown>", EntryPoint = "IRunnableObject_GetRunningClass_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRunnableObject_GetRunningClass_Proxy(ref IRunnableObject This, ref GUID lpClsid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcSyntaxNegotiate_NegotiateSyntax_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcSyntaxNegotiate_NegotiateSyntax_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcSyntaxNegotiate*
        ///pMsg: RPCOLEMESSAGE*
        [DllImport("<Unknown>", EntryPoint = "IRpcSyntaxNegotiate_NegotiateSyntax_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcSyntaxNegotiate_NegotiateSyntax_Proxy(ref IRpcSyntaxNegotiate This, ref tagRPCOLEMESSAGE pMsg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_IsIIDSupported_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_IsIIDSupported_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: IRpcStubBuffer*
        ///This: IRpcStubBuffer*
        ///riid: IID*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_IsIIDSupported_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IRpcStubBuffer_IsIIDSupported_Proxy(ref IRpcStubBuffer This, ref GUID riid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_Invoke_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_Invoke_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcStubBuffer*
        ///_prpcmsg: RPCOLEMESSAGE*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_Invoke_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcStubBuffer_Invoke_Proxy(ref IRpcStubBuffer This, ref tagRPCOLEMESSAGE _prpcmsg, ref IRpcChannelBuffer _pRpcChannelBuffer);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_Disconnect_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_Disconnect_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_Disconnect_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_Disconnect_Proxy(ref IRpcStubBuffer This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_DebugServerRelease_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_DebugServerRelease_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///pv: void*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_DebugServerRelease_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_DebugServerRelease_Proxy(ref IRpcStubBuffer This, IntPtr pv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_DebugServerQueryInterface_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_DebugServerQueryInterface_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcStubBuffer*
        ///ppv: void**
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_DebugServerQueryInterface_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcStubBuffer_DebugServerQueryInterface_Proxy(ref IRpcStubBuffer This, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_CountRefs_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_CountRefs_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: ULONG->unsigned int
        ///This: IRpcStubBuffer*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_CountRefs_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IRpcStubBuffer_CountRefs_Proxy(ref IRpcStubBuffer This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_Connect_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcStubBuffer_Connect_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcStubBuffer*
        ///pUnkServer: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IRpcStubBuffer_Connect_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcStubBuffer_Connect_Proxy(ref IRpcStubBuffer This, ref IUnknown pUnkServer);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcProxyBuffer_Disconnect_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcProxyBuffer_Disconnect_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcProxyBuffer*
        [DllImport("<Unknown>", EntryPoint = "IRpcProxyBuffer_Disconnect_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcProxyBuffer_Disconnect_Proxy(ref IRpcProxyBuffer This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcProxyBuffer_Connect_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcProxyBuffer_Connect_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcProxyBuffer*
        ///pRpcChannelBuffer: IRpcChannelBuffer*
        [DllImport("<Unknown>", EntryPoint = "IRpcProxyBuffer_Connect_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcProxyBuffer_Connect_Proxy(ref IRpcProxyBuffer This, ref IRpcChannelBuffer pRpcChannelBuffer);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcOptions_Set_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcOptions_Set_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcOptions*
        ///pPrx: IUnknown*
        ///dwProperty: DWORD->unsigned int
        ///dwValue: ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IRpcOptions_Set_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcOptions_Set_Proxy(ref IRpcOptions This, ref IUnknown pPrx, uint dwProperty, uint dwValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcOptions_Query_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcOptions_Query_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcOptions*
        ///pPrx: IUnknown*
        ///dwProperty: DWORD->unsigned int
        ///pdwValue: ULONG_PTR*
        [DllImport("<Unknown>", EntryPoint = "IRpcOptions_Query_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcOptions_Query_Proxy(ref IRpcOptions This, ref IUnknown pPrx, uint dwProperty, ref uint pdwValue);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcHelper_GetIIDFromOBJREF_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcHelper_GetIIDFromOBJREF_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcHelper*
        ///pObjRef: void*
        ///piid: IID**
        [DllImport("<Unknown>", EntryPoint = "IRpcHelper_GetIIDFromOBJREF_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcHelper_GetIIDFromOBJREF_Proxy(ref IRpcHelper This, IntPtr pObjRef, ref IntPtr piid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcHelper_GetDCOMProtocolVersion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcHelper_GetDCOMProtocolVersion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcHelper*
        ///pComVersion: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcHelper_GetDCOMProtocolVersion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcHelper_GetDCOMProtocolVersion_Proxy(ref IRpcHelper This, ref uint pComVersion);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_SendReceive_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer_SendReceive_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer*
        ///pMessage: RPCOLEMESSAGE*
        ///pStatus: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_SendReceive_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer_SendReceive_Proxy(ref IRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMessage, ref uint pStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_IsConnected_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer_IsConnected_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_IsConnected_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer_IsConnected_Proxy(ref IRpcChannelBuffer This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_GetDestCtx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer_GetDestCtx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer*
        ///pdwDestContext: DWORD*
        ///ppvDestContext: void**
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_GetDestCtx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer_GetDestCtx_Proxy(ref IRpcChannelBuffer This, ref uint pdwDestContext, ref IntPtr ppvDestContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_GetBuffer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer_GetBuffer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer*
        ///pMessage: RPCOLEMESSAGE*
        ///riid: IID*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_GetBuffer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer_GetBuffer_Proxy(ref IRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMessage, ref GUID riid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_FreeBuffer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer_FreeBuffer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer*
        ///pMessage: RPCOLEMESSAGE*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer_FreeBuffer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer_FreeBuffer_Proxy(ref IRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMessage);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_Send_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer3_Send_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer3*
        ///pMsg: RPCOLEMESSAGE*
        ///pulStatus: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_Send_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer3_Send_Proxy(ref IRpcChannelBuffer3 This, ref tagRPCOLEMESSAGE pMsg, ref uint pulStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_RegisterAsync_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer3_RegisterAsync_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer3*
        ///pMsg: RPCOLEMESSAGE*
        ///pAsyncMgr: IAsyncManager*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_RegisterAsync_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer3_RegisterAsync_Proxy(ref IRpcChannelBuffer3 This, ref tagRPCOLEMESSAGE pMsg, ref IAsyncManager pAsyncMgr);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_Receive_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer3_Receive_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer3*
        ///pMsg: RPCOLEMESSAGE*
        ///ulSize: ULONG->unsigned int
        ///pulStatus: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_Receive_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer3_Receive_Proxy(ref IRpcChannelBuffer3 This, ref tagRPCOLEMESSAGE pMsg, uint ulSize, ref uint pulStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_GetState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer3_GetState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer3*
        ///pMsg: RPCOLEMESSAGE*
        ///pState: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_GetState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer3_GetState_Proxy(ref IRpcChannelBuffer3 This, ref tagRPCOLEMESSAGE pMsg, ref uint pState);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_GetDestCtxEx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer3_GetDestCtxEx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer3*
        ///pMsg: RPCOLEMESSAGE*
        ///pdwDestContext: DWORD*
        ///ppvDestContext: void**
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_GetDestCtxEx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer3_GetDestCtxEx_Proxy(ref IRpcChannelBuffer3 This, ref tagRPCOLEMESSAGE pMsg, ref uint pdwDestContext, ref IntPtr ppvDestContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_GetCallContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer3_GetCallContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer3*
        ///pMsg: RPCOLEMESSAGE*
        ///riid: IID*
        ///pInterface: void**
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_GetCallContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer3_GetCallContext_Proxy(ref IRpcChannelBuffer3 This, ref tagRPCOLEMESSAGE pMsg, ref GUID riid, ref IntPtr pInterface);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_Cancel_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer3_Cancel_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer3*
        ///pMsg: RPCOLEMESSAGE*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer3_Cancel_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer3_Cancel_Proxy(ref IRpcChannelBuffer3 This, ref tagRPCOLEMESSAGE pMsg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer2_GetProtocolVersion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRpcChannelBuffer2_GetProtocolVersion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRpcChannelBuffer2*
        ///pdwVersion: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRpcChannelBuffer2_GetProtocolVersion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRpcChannelBuffer2_GetProtocolVersion_Proxy(ref IRpcChannelBuffer2 This, ref uint pdwVersion);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IROTData_GetComparisonData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IROTData_GetComparisonData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IROTData*
        ///pbData: byte*
        ///cbMax: ULONG->unsigned int
        ///pcbData: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IROTData_GetComparisonData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IROTData_GetComparisonData_Proxy(ref IROTData This, ref byte pbData, uint cbMax, ref uint pcbData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRootStorage_SwitchToFile_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRootStorage_SwitchToFile_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRootStorage*
        ///pszFile: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IRootStorage_SwitchToFile_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRootStorage_SwitchToFile_Proxy(ref IRootStorage This, IntPtr pszFile);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IReleaseMarshalBuffers_ReleaseMarshalBuffer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IReleaseMarshalBuffers_ReleaseMarshalBuffer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IReleaseMarshalBuffers*
        ///pMsg: RPCOLEMESSAGE*
        ///dwFlags: DWORD->unsigned int
        ///pChnl: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IReleaseMarshalBuffers_ReleaseMarshalBuffer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IReleaseMarshalBuffers_ReleaseMarshalBuffer_Proxy(ref IReleaseMarshalBuffers This, ref tagRPCOLEMESSAGE pMsg, uint dwFlags, ref IUnknown pChnl);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordInit_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_RecordInit_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pvNew: PVOID->void*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordInit_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_RecordInit_Proxy(ref IRecordInfo This, IntPtr pvNew);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordDestroy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_RecordDestroy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pvRecord: PVOID->void*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordDestroy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_RecordDestroy_Proxy(ref IRecordInfo This, IntPtr pvRecord);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordCreate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_RecordCreate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: PVOID->void*
        ///This: IRecordInfo*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordCreate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IRecordInfo_RecordCreate_Proxy(ref IRecordInfo This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordCreateCopy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_RecordCreateCopy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pvSource: PVOID->void*
        ///ppvDest: PVOID*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordCreateCopy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_RecordCreateCopy_Proxy(ref IRecordInfo This, IntPtr pvSource, ref IntPtr ppvDest);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordCopy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_RecordCopy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pvExisting: PVOID->void*
        ///pvNew: PVOID->void*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordCopy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_RecordCopy_Proxy(ref IRecordInfo This, IntPtr pvExisting, IntPtr pvNew);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordClear_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_RecordClear_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pvExisting: PVOID->void*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_RecordClear_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_RecordClear_Proxy(ref IRecordInfo This, IntPtr pvExisting);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_PutField_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_PutField_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///wFlags: ULONG->unsigned int
        ///pvData: PVOID->void*
        ///szFieldName: LPCOLESTR->OLECHAR*
        ///pvarField: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_PutField_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_PutField_Proxy(ref IRecordInfo This, uint wFlags, IntPtr pvData, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFieldName, ref tagVARIANT pvarField);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_PutFieldNoCopy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_PutFieldNoCopy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///wFlags: ULONG->unsigned int
        ///pvData: PVOID->void*
        ///szFieldName: LPCOLESTR->OLECHAR*
        ///pvarField: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_PutFieldNoCopy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_PutFieldNoCopy_Proxy(ref IRecordInfo This, uint wFlags, IntPtr pvData, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFieldName, ref tagVARIANT pvarField);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_IsMatchingType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_IsMatchingType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: BOOL->int
        ///This: IRecordInfo*
        ///pRecordInfo: IRecordInfo*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_IsMatchingType_Proxy", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IRecordInfo_IsMatchingType_Proxy(ref IRecordInfo This, ref IRecordInfo pRecordInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_GetTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///ppTypeInfo: ITypeInfo**
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_GetTypeInfo_Proxy(ref IRecordInfo This, ref IntPtr ppTypeInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_GetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pcbSize: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_GetSize_Proxy(ref IRecordInfo This, ref uint pcbSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_GetName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pbstrName: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_GetName_Proxy(ref IRecordInfo This, [MarshalAs(UnmanagedType.BStr)] ref string pbstrName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetGuid_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_GetGuid_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pguid: GUID*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetGuid_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_GetGuid_Proxy(ref IRecordInfo This, ref GUID pguid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetField_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_GetField_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pvData: PVOID->void*
        ///szFieldName: LPCOLESTR->OLECHAR*
        ///pvarField: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetField_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_GetField_Proxy(ref IRecordInfo This, IntPtr pvData, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFieldName, ref tagVARIANT pvarField);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetFieldNoCopy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_GetFieldNoCopy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pvData: PVOID->void*
        ///szFieldName: LPCOLESTR->OLECHAR*
        ///pvarField: VARIANT*
        ///ppvDataCArray: PVOID*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetFieldNoCopy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_GetFieldNoCopy_Proxy(ref IRecordInfo This, IntPtr pvData, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFieldName, ref tagVARIANT pvarField, ref IntPtr ppvDataCArray);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetFieldNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IRecordInfo_GetFieldNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IRecordInfo*
        ///pcNames: ULONG*
        ///rgBstrNames: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IRecordInfo_GetFieldNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IRecordInfo_GetFieldNames_Proxy(ref IRecordInfo This, ref uint pcNames, [MarshalAs(UnmanagedType.BStr)] ref string rgBstrNames);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPSFactoryBuffer_CreateStub_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPSFactoryBuffer_CreateStub_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPSFactoryBuffer*
        ///riid: IID*
        ///pUnkServer: IUnknown*
        ///ppStub: IRpcStubBuffer**
        [DllImport("<Unknown>", EntryPoint = "IPSFactoryBuffer_CreateStub_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPSFactoryBuffer_CreateStub_Proxy(ref IPSFactoryBuffer This, ref GUID riid, ref IUnknown pUnkServer, ref IntPtr ppStub);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPSFactoryBuffer_CreateProxy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPSFactoryBuffer_CreateProxy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPSFactoryBuffer*
        ///pUnkOuter: IUnknown*
        ///riid: IID*
        ///ppProxy: IRpcProxyBuffer**
        ///ppv: void**
        [DllImport("<Unknown>", EntryPoint = "IPSFactoryBuffer_CreateProxy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPSFactoryBuffer_CreateProxy_Proxy(ref IPSFactoryBuffer This, ref IUnknown pUnkOuter, ref GUID riid, ref IntPtr ppProxy, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_WritePropertyNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_WritePropertyNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///cpropid: ULONG->unsigned int
        ///rgpropid: PROPID*
        ///rglpwstrName: LPOLESTR*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_WritePropertyNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_WritePropertyNames_Proxy(ref IPropertyStorage This, uint cpropid, ref uint rgpropid, ref IntPtr rglpwstrName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_WriteMultiple_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_WriteMultiple_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///cpspec: ULONG->unsigned int
        ///rgpspec: PROPSPEC*
        ///rgpropvar: PROPVARIANT*
        ///propidNameFirst: PROPID->ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_WriteMultiple_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_WriteMultiple_Proxy(ref IPropertyStorage This, uint cpspec, ref tagPROPSPEC rgpspec, ref tagPROPVARIANT rgpropvar, uint propidNameFirst);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Stat_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_Stat_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///pstatpsstg: STATPROPSETSTG*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Stat_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_Stat_Proxy(ref IPropertyStorage This, ref tagSTATPROPSETSTG pstatpsstg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_SetTimes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_SetTimes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///pctime: FILETIME*
        ///patime: FILETIME*
        ///pmtime: FILETIME*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_SetTimes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_SetTimes_Proxy(ref IPropertyStorage This, ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_SetClass_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_SetClass_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///clsid: IID*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_SetClass_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_SetClass_Proxy(ref IPropertyStorage This, ref GUID clsid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Revert_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_Revert_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Revert_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_Revert_Proxy(ref IPropertyStorage This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_ReadPropertyNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_ReadPropertyNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///cpropid: ULONG->unsigned int
        ///rgpropid: PROPID*
        ///rglpwstrName: LPOLESTR*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_ReadPropertyNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_ReadPropertyNames_Proxy(ref IPropertyStorage This, uint cpropid, ref uint rgpropid, ref IntPtr rglpwstrName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_ReadMultiple_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_ReadMultiple_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///cpspec: ULONG->unsigned int
        ///rgpspec: PROPSPEC*
        ///rgpropvar: PROPVARIANT*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_ReadMultiple_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_ReadMultiple_Proxy(ref IPropertyStorage This, uint cpspec, ref tagPROPSPEC rgpspec, ref tagPROPVARIANT rgpropvar);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Enum_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_Enum_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///ppenum: IEnumSTATPROPSTG**
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Enum_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_Enum_Proxy(ref IPropertyStorage This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_DeletePropertyNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_DeletePropertyNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///cpropid: ULONG->unsigned int
        ///rgpropid: PROPID*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_DeletePropertyNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_DeletePropertyNames_Proxy(ref IPropertyStorage This, uint cpropid, ref uint rgpropid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_DeleteMultiple_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_DeleteMultiple_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///cpspec: ULONG->unsigned int
        ///rgpspec: PROPSPEC*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_DeleteMultiple_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_DeleteMultiple_Proxy(ref IPropertyStorage This, uint cpspec, ref tagPROPSPEC rgpspec);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Commit_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyStorage_Commit_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyStorage*
        ///grfCommitFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IPropertyStorage_Commit_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyStorage_Commit_Proxy(ref IPropertyStorage This, uint grfCommitFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Open_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertySetStorage_Open_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertySetStorage*
        ///rfmtid: IID*
        ///grfMode: DWORD->unsigned int
        ///ppprstg: IPropertyStorage**
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Open_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertySetStorage_Open_Proxy(ref IPropertySetStorage This, ref GUID rfmtid, uint grfMode, ref IntPtr ppprstg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Enum_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertySetStorage_Enum_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertySetStorage*
        ///ppenum: IEnumSTATPROPSETSTG**
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Enum_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertySetStorage_Enum_Proxy(ref IPropertySetStorage This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Delete_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertySetStorage_Delete_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertySetStorage*
        ///rfmtid: IID*
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Delete_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertySetStorage_Delete_Proxy(ref IPropertySetStorage This, ref GUID rfmtid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Create_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertySetStorage_Create_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertySetStorage*
        ///rfmtid: IID*
        ///pclsid: CLSID*
        ///grfFlags: DWORD->unsigned int
        ///grfMode: DWORD->unsigned int
        ///ppprstg: IPropertyStorage**
        [DllImport("<Unknown>", EntryPoint = "IPropertySetStorage_Create_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertySetStorage_Create_Proxy(ref IPropertySetStorage This, ref GUID rfmtid, ref GUID pclsid, uint grfFlags, uint grfMode, ref IntPtr ppprstg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyBag_Write_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyBag_Write_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyBag*
        ///pszPropName: LPCOLESTR->OLECHAR*
        ///pVar: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "IPropertyBag_Write_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyBag_Write_Proxy(ref IPropertyBag This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPropName, ref tagVARIANT pVar);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPropertyBag_RemoteRead_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPropertyBag_RemoteRead_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyBag*
        ///pszPropName: LPCOLESTR->OLECHAR*
        ///pVar: VARIANT*
        ///pErrorLog: IErrorLog*
        ///varType: DWORD->unsigned int
        ///pUnkObj: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IPropertyBag_RemoteRead_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyBag_RemoteRead_Proxy(ref IPropertyBag This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPropName, ref tagVARIANT pVar, ref IErrorLog pErrorLog, uint varType, ref IUnknown pUnkObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyBag*
        ///pszPropName: LPCOLESTR->OLECHAR*
        ///pVar: VARIANT*
        ///pErrorLog: IErrorLog*
        ///varType: DWORD->unsigned int
        ///pUnkObj: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IPropertyBag_Read_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyBag_Read_Stub(ref IPropertyBag This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPropName, ref tagVARIANT pVar, ref IErrorLog pErrorLog, uint varType, ref IUnknown pUnkObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IPropertyBag*
        ///pszPropName: LPCOLESTR->OLECHAR*
        ///pVar: VARIANT*
        ///pErrorLog: IErrorLog*
        [DllImport("<Unknown>", EntryPoint = "IPropertyBag_Read_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPropertyBag_Read_Proxy(ref IPropertyBag This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPropName, ref tagVARIANT pVar, ref IErrorLog pErrorLog);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IProgressNotify_OnProgress_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IProgressNotify_OnProgress_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IProgressNotify*
        ///dwProgressCurrent: DWORD->unsigned int
        ///dwProgressMaximum: DWORD->unsigned int
        ///fAccurate: BOOL->int
        ///fOwner: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IProgressNotify_OnProgress_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IProgressNotify_OnProgress_Proxy(ref IProgressNotify This, uint dwProgressCurrent, uint dwProgressMaximum, [MarshalAs(UnmanagedType.Bool)] bool fAccurate, [MarshalAs(UnmanagedType.Bool)] bool fOwner);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IProcessLock_ReleaseRefOnProcess_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IProcessLock_ReleaseRefOnProcess_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: ULONG->unsigned int
        ///This: IProcessLock*
        [DllImport("<Unknown>", EntryPoint = "IProcessLock_ReleaseRefOnProcess_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IProcessLock_ReleaseRefOnProcess_Proxy(ref IProcessLock This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IProcessLock_AddRefOnProcess_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IProcessLock_AddRefOnProcess_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: ULONG->unsigned int
        ///This: IProcessLock*
        [DllImport("<Unknown>", EntryPoint = "IProcessLock_AddRefOnProcess_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IProcessLock_AddRefOnProcess_Proxy(ref IProcessLock This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IProcessInitControl_ResetInitializerTimeout_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IProcessInitControl_ResetInitializerTimeout_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IProcessInitControl*
        ///dwSecondsRemaining: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IProcessInitControl_ResetInitializerTimeout_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IProcessInitControl_ResetInitializerTimeout_Proxy(ref IProcessInitControl This, uint dwSecondsRemaining);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPipeLong_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPipeLong_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPipeLong*
        ///buf: LONG*
        ///cSent: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IPipeLong_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPipeLong_Push_Proxy(ref IPipeLong This, ref int buf, uint cSent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPipeLong_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPipeLong_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPipeLong*
        ///buf: LONG*
        ///cRequest: ULONG->unsigned int
        ///pcReturned: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IPipeLong_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPipeLong_Pull_Proxy(ref IPipeLong This, ref int buf, uint cRequest, ref uint pcReturned);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPipeDouble_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPipeDouble_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPipeDouble*
        ///buf: DOUBLE*
        ///cSent: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IPipeDouble_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPipeDouble_Push_Proxy(ref IPipeDouble This, ref double buf, uint cSent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPipeDouble_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPipeDouble_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPipeDouble*
        ///buf: DOUBLE*
        ///cRequest: ULONG->unsigned int
        ///pcReturned: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IPipeDouble_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPipeDouble_Pull_Proxy(ref IPipeDouble This, ref double buf, uint cRequest, ref uint pcReturned);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPipeByte_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPipeByte_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPipeByte*
        ///buf: BYTE*
        ///cSent: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IPipeByte_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPipeByte_Push_Proxy(ref IPipeByte This, ref byte buf, uint cSent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPipeByte_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPipeByte_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPipeByte*
        ///buf: BYTE*
        ///cRequest: ULONG->unsigned int
        ///pcReturned: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IPipeByte_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPipeByte_Pull_Proxy(ref IPipeByte This, ref byte buf, uint cRequest, ref uint pcReturned);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersist_GetClassID_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersist_GetClassID_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersist*
        ///pClassID: CLSID*
        [DllImport("<Unknown>", EntryPoint = "IPersist_GetClassID_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersist_GetClassID_Proxy(ref IPersist This, ref GUID pClassID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_Save_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStream_Save_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStream*
        ///pStm: IStream*
        ///fClearDirty: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_Save_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStream_Save_Proxy(ref IPersistStream This, ref IStream pStm, [MarshalAs(UnmanagedType.Bool)] bool fClearDirty);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_Load_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStream_Load_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStream*
        ///pStm: IStream*
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_Load_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStream_Load_Proxy(ref IPersistStream This, ref IStream pStm);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_IsDirty_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStream_IsDirty_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStream*
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_IsDirty_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStream_IsDirty_Proxy(ref IPersistStream This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_GetSizeMax_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStream_GetSizeMax_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStream*
        ///pcbSize: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IPersistStream_GetSizeMax_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStream_GetSizeMax_Proxy(ref IPersistStream This, ref ULARGE_INTEGER pcbSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_Save_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStorage_Save_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStorage*
        ///pStgSave: IStorage*
        ///fSameAsLoad: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_Save_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStorage_Save_Proxy(ref IPersistStorage This, ref IStorage pStgSave, [MarshalAs(UnmanagedType.Bool)] bool fSameAsLoad);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_SaveCompleted_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStorage_SaveCompleted_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStorage*
        ///pStgNew: IStorage*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_SaveCompleted_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStorage_SaveCompleted_Proxy(ref IPersistStorage This, ref IStorage pStgNew);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_Load_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStorage_Load_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStorage*
        ///pStg: IStorage*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_Load_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStorage_Load_Proxy(ref IPersistStorage This, ref IStorage pStg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_IsDirty_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStorage_IsDirty_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStorage*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_IsDirty_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStorage_IsDirty_Proxy(ref IPersistStorage This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_InitNew_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStorage_InitNew_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStorage*
        ///pStg: IStorage*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_InitNew_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStorage_InitNew_Proxy(ref IPersistStorage This, ref IStorage pStg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_HandsOffStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistStorage_HandsOffStorage_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistStorage*
        [DllImport("<Unknown>", EntryPoint = "IPersistStorage_HandsOffStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistStorage_HandsOffStorage_Proxy(ref IPersistStorage This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_Save_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistMoniker_Save_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistMoniker*
        ///pimkName: IMoniker*
        ///pbc: LPBC->IBindCtx*
        ///fRemember: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_Save_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistMoniker_Save_Proxy(ref IPersistMoniker This, ref IMoniker pimkName, ref IBindCtx pbc, [MarshalAs(UnmanagedType.Bool)] bool fRemember);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_SaveCompleted_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistMoniker_SaveCompleted_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistMoniker*
        ///pimkName: IMoniker*
        ///pibc: LPBC->IBindCtx*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_SaveCompleted_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistMoniker_SaveCompleted_Proxy(ref IPersistMoniker This, ref IMoniker pimkName, ref IBindCtx pibc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_Load_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistMoniker_Load_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistMoniker*
        ///fFullyAvailable: BOOL->int
        ///pimkName: IMoniker*
        ///pibc: LPBC->IBindCtx*
        ///grfMode: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_Load_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistMoniker_Load_Proxy(ref IPersistMoniker This, [MarshalAs(UnmanagedType.Bool)] bool fFullyAvailable, ref IMoniker pimkName, ref IBindCtx pibc, uint grfMode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_IsDirty_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistMoniker_IsDirty_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistMoniker*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_IsDirty_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistMoniker_IsDirty_Proxy(ref IPersistMoniker This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_GetCurMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistMoniker_GetCurMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistMoniker*
        ///ppimkName: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_GetCurMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistMoniker_GetCurMoniker_Proxy(ref IPersistMoniker This, ref IntPtr ppimkName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_GetClassID_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistMoniker_GetClassID_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistMoniker*
        ///pClassID: CLSID*
        [DllImport("<Unknown>", EntryPoint = "IPersistMoniker_GetClassID_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistMoniker_GetClassID_Proxy(ref IPersistMoniker This, ref GUID pClassID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_Save_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistFile_Save_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistFile*
        ///pszFileName: LPCOLESTR->OLECHAR*
        ///fRemember: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_Save_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistFile_Save_Proxy(ref IPersistFile This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.Bool)] bool fRemember);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_SaveCompleted_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistFile_SaveCompleted_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistFile*
        ///pszFileName: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_SaveCompleted_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistFile_SaveCompleted_Proxy(ref IPersistFile This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszFileName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_Load_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistFile_Load_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistFile*
        ///pszFileName: LPCOLESTR->OLECHAR*
        ///dwMode: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_Load_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistFile_Load_Proxy(ref IPersistFile This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, uint dwMode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_IsDirty_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistFile_IsDirty_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistFile*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_IsDirty_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistFile_IsDirty_Proxy(ref IPersistFile This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_GetCurFile_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IPersistFile_GetCurFile_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IPersistFile*
        ///ppszFileName: LPOLESTR*
        [DllImport("<Unknown>", EntryPoint = "IPersistFile_GetCurFile_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IPersistFile_GetCurFile_Proxy(ref IPersistFile This, ref IntPtr ppszFileName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IParseDisplayName_ParseDisplayName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IParseDisplayName_ParseDisplayName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IParseDisplayName*
        ///pbc: IBindCtx*
        ///pszDisplayName: LPOLESTR->OLECHAR*
        ///pchEaten: ULONG*
        ///ppmkOut: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IParseDisplayName_ParseDisplayName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IParseDisplayName_ParseDisplayName_Proxy(ref IParseDisplayName This, ref IBindCtx pbc, IntPtr pszDisplayName, ref uint pchEaten, ref IntPtr ppmkOut);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOplockStorage_OpenStorageEx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOplockStorage_OpenStorageEx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOplockStorage*
        ///pwcsName: LPCWSTR->WCHAR*
        ///grfMode: DWORD->unsigned int
        ///stgfmt: DWORD->unsigned int
        ///grfAttrs: DWORD->unsigned int
        ///riid: IID*
        ///ppstgOpen: void**
        [DllImport("<Unknown>", EntryPoint = "IOplockStorage_OpenStorageEx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOplockStorage_OpenStorageEx_Proxy(ref IOplockStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref GUID riid, ref IntPtr ppstgOpen);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOplockStorage_CreateStorageEx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOplockStorage_CreateStorageEx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOplockStorage*
        ///pwcsName: LPCWSTR->WCHAR*
        ///grfMode: DWORD->unsigned int
        ///stgfmt: DWORD->unsigned int
        ///grfAttrs: DWORD->unsigned int
        ///riid: IID*
        ///ppstgOpen: void**
        [DllImport("<Unknown>", EntryPoint = "IOplockStorage_CreateStorageEx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOplockStorage_CreateStorageEx_Proxy(ref IOplockStorage This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref GUID riid, ref IntPtr ppstgOpen);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleWindow_GetWindow_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleWindow_GetWindow_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleWindow*
        ///phwnd: HWND*
        [DllImport("<Unknown>", EntryPoint = "IOleWindow_GetWindow_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleWindow_GetWindow_Proxy(ref IOleWindow This, ref IntPtr phwnd);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleWindow_ContextSensitiveHelp_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleWindow_ContextSensitiveHelp_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleWindow*
        ///fEnterMode: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleWindow_ContextSensitiveHelp_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleWindow_ContextSensitiveHelp_Proxy(ref IOleWindow This, [MarshalAs(UnmanagedType.Bool)] bool fEnterMode);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Update_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Update_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Update_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Update_Proxy(ref IOleObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Unadvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Unadvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Unadvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Unadvise_Proxy(ref IOleObject This, uint dwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwWhichMoniker: DWORD->unsigned int
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetMoniker_Proxy(ref IOleObject This, uint dwWhichMoniker, ref IMoniker pmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetHostNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetHostNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///szContainerApp: LPCOLESTR->OLECHAR*
        ///szContainerObj: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetHostNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetHostNames_Proxy(ref IOleObject This, [In] [MarshalAs(UnmanagedType.LPWStr)] string szContainerApp, [In] [MarshalAs(UnmanagedType.LPWStr)] string szContainerObj);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetExtent_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetExtent_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///psizel: SIZEL*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetExtent_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetExtent_Proxy(ref IOleObject This, uint dwDrawAspect, ref tagSIZE psizel);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetColorScheme_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetColorScheme_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pLogpal: LOGPALETTE*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetColorScheme_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetColorScheme_Proxy(ref IOleObject This, ref tagLOGPALETTE pLogpal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetClientSite_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetClientSite_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pClientSite: IOleClientSite*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetClientSite_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetClientSite_Proxy(ref IOleObject This, ref IOleClientSite pClientSite);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_IsUpToDate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_IsUpToDate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_IsUpToDate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_IsUpToDate_Proxy(ref IOleObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_InitFromData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_InitFromData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pDataObject: IDataObject*
        ///fCreation: BOOL->int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleObject_InitFromData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_InitFromData_Proxy(ref IOleObject This, ref IDataObject pDataObject, [MarshalAs(UnmanagedType.Bool)] bool fCreation, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetUserType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwFormOfType: DWORD->unsigned int
        ///pszUserType: LPOLESTR*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetUserType_Proxy(ref IOleObject This, uint dwFormOfType, ref IntPtr pszUserType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserClassID_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetUserClassID_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pClsid: CLSID*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserClassID_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetUserClassID_Proxy(ref IOleObject This, ref GUID pClsid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwAssign: DWORD->unsigned int
        ///dwWhichMoniker: DWORD->unsigned int
        ///ppmk: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetMoniker_Proxy(ref IOleObject This, uint dwAssign, uint dwWhichMoniker, ref IntPtr ppmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMiscStatus_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetMiscStatus_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwAspect: DWORD->unsigned int
        ///pdwStatus: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMiscStatus_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetMiscStatus_Proxy(ref IOleObject This, uint dwAspect, ref uint pdwStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetExtent_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetExtent_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///psizel: SIZEL*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetExtent_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetExtent_Proxy(ref IOleObject This, uint dwDrawAspect, ref tagSIZE psizel);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetClipboardData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetClipboardData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwReserved: DWORD->unsigned int
        ///ppDataObject: IDataObject**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetClipboardData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetClipboardData_Proxy(ref IOleObject This, uint dwReserved, ref IntPtr ppDataObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetClientSite_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetClientSite_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///ppClientSite: IOleClientSite**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetClientSite_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetClientSite_Proxy(ref IOleObject This, ref IntPtr ppClientSite);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumVerbs_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_EnumVerbs_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///ppEnumOleVerb: IEnumOLEVERB**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumVerbs_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_EnumVerbs_Proxy(ref IOleObject This, ref IntPtr ppEnumOleVerb);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_EnumAdvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///ppenumAdvise: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_EnumAdvise_Proxy(ref IOleObject This, ref IntPtr ppenumAdvise);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_DoVerb_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_DoVerb_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///iVerb: LONG->int
        ///lpmsg: LPMSG->tagMSG*
        ///pActiveSite: IOleClientSite*
        ///lindex: LONG->int
        ///hwndParent: HWND->HWND__*
        ///lprcPosRect: LPCRECT->RECT*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_DoVerb_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_DoVerb_Proxy(ref IOleObject This, int iVerb, ref tagMSG lpmsg, ref IOleClientSite pActiveSite, int lindex, IntPtr hwndParent, ref tagRECT lprcPosRect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Close_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Close_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwSaveOption: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Close_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Close_Proxy(ref IOleObject This, uint dwSaveOption);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Advise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Advise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pAdvSink: IAdviseSink*
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Advise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Advise_Proxy(ref IOleObject This, ref IAdviseSink pAdvSink, ref uint pdwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_Update_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_Update_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pbc: IBindCtx*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_Update_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_Update_Proxy(ref IOleLink This, ref IBindCtx pbc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_UnbindSource_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_UnbindSource_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_UnbindSource_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_UnbindSource_Proxy(ref IOleLink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetUpdateOptions_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_SetUpdateOptions_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///dwUpdateOpt: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetUpdateOptions_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_SetUpdateOptions_Proxy(ref IOleLink This, uint dwUpdateOpt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetSourceMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_SetSourceMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pmk: IMoniker*
        ///rclsid: IID*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetSourceMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_SetSourceMoniker_Proxy(ref IOleLink This, ref IMoniker pmk, ref GUID rclsid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetSourceDisplayName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_SetSourceDisplayName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pszStatusText: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetSourceDisplayName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_SetSourceDisplayName_Proxy(ref IOleLink This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszStatusText);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetUpdateOptions_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetUpdateOptions_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pdwUpdateOpt: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetUpdateOptions_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetUpdateOptions_Proxy(ref IOleLink This, ref uint pdwUpdateOpt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetSourceMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetSourceMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///ppmk: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetSourceMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetSourceMoniker_Proxy(ref IOleLink This, ref IntPtr ppmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetSourceDisplayName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetSourceDisplayName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///ppszDisplayName: LPOLESTR*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetSourceDisplayName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetSourceDisplayName_Proxy(ref IOleLink This, ref IntPtr ppszDisplayName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetBoundSource_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetBoundSource_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///ppunk: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetBoundSource_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetBoundSource_Proxy(ref IOleLink This, ref IntPtr ppunk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindToSource_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_BindToSource_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///bindflags: DWORD->unsigned int
        ///pbc: IBindCtx*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindToSource_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_BindToSource_Proxy(ref IOleLink This, uint bindflags, ref IBindCtx pbc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindIfRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_BindIfRunning_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindIfRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_BindIfRunning_Proxy(ref IOleLink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_IsRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleItemContainer_IsRunning_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleItemContainer*
        ///pszItem: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_IsRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleItemContainer_IsRunning_Proxy(ref IOleItemContainer This, IntPtr pszItem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_GetObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleItemContainer_GetObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleItemContainer*
        ///pszItem: LPOLESTR->OLECHAR*
        ///dwSpeedNeeded: DWORD->unsigned int
        ///pbc: IBindCtx*
        ///riid: IID*
        ///ppvObject: void**
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_GetObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleItemContainer_GetObject_Proxy(ref IOleItemContainer This, IntPtr pszItem, uint dwSpeedNeeded, ref IBindCtx pbc, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_GetObjectStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleItemContainer_GetObjectStorage_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleItemContainer*
        ///pszItem: LPOLESTR->OLECHAR*
        ///pbc: IBindCtx*
        ///riid: IID*
        ///ppvStorage: void**
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_GetObjectStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleItemContainer_GetObjectStorage_Proxy(ref IOleItemContainer This, IntPtr pszItem, ref IBindCtx pbc, ref GUID riid, ref IntPtr ppvStorage);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_SetBorderSpace_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_SetBorderSpace_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///pborderwidths: LPCBORDERWIDTHS->LPCRECT->RECT*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_SetBorderSpace_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_SetBorderSpace_Proxy(ref IOleInPlaceUIWindow This, ref tagRECT pborderwidths);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_SetActiveObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_SetActiveObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///pActiveObject: IOleInPlaceActiveObject*
        ///pszObjName: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_SetActiveObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_SetActiveObject_Proxy(ref IOleInPlaceUIWindow This, ref IOleInPlaceActiveObject pActiveObject, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszObjName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_RequestBorderSpace_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_RequestBorderSpace_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///pborderwidths: LPCBORDERWIDTHS->LPCRECT->RECT*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_RequestBorderSpace_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_RequestBorderSpace_Proxy(ref IOleInPlaceUIWindow This, ref tagRECT pborderwidths);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_GetBorder_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_GetBorder_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///lprectBorder: LPRECT->tagRECT*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceUIWindow_GetBorder_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_GetBorder_Proxy(ref IOleInPlaceUIWindow This, ref tagRECT lprectBorder);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_Scroll_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_Scroll_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///scrollExtant: SIZE->tagSIZE
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_Scroll_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_Scroll_Proxy(ref IOleInPlaceSite This, tagSIZE scrollExtant);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnUIDeactivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnUIDeactivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///fUndoable: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnUIDeactivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnUIDeactivate_Proxy(ref IOleInPlaceSite This, [MarshalAs(UnmanagedType.Bool)] bool fUndoable);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnUIActivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnUIActivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnUIActivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnUIActivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnPosRectChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnPosRectChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///lprcPosRect: LPCRECT->RECT*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnPosRectChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnPosRectChange_Proxy(ref IOleInPlaceSite This, ref tagRECT lprcPosRect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnInPlaceDeactivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnInPlaceDeactivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnInPlaceDeactivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnInPlaceDeactivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnInPlaceActivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnInPlaceActivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_OnInPlaceActivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnInPlaceActivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_GetWindowContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_GetWindowContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///ppFrame: IOleInPlaceFrame**
        ///ppDoc: IOleInPlaceUIWindow**
        ///lprcPosRect: LPRECT->tagRECT*
        ///lprcClipRect: LPRECT->tagRECT*
        ///lpFrameInfo: LPOLEINPLACEFRAMEINFO->tagOIFI*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_GetWindowContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_GetWindowContext_Proxy(ref IOleInPlaceSite This, ref IntPtr ppFrame, ref IntPtr ppDoc, ref tagRECT lprcPosRect, ref tagRECT lprcClipRect, ref tagOIFI lpFrameInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_DiscardUndoState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_DiscardUndoState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_DiscardUndoState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_DiscardUndoState_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_DeactivateAndUndo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_DeactivateAndUndo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_DeactivateAndUndo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_DeactivateAndUndo_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_CanInPlaceActivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_CanInPlaceActivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_CanInPlaceActivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_CanInPlaceActivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_UIDeactivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_UIDeactivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_UIDeactivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_UIDeactivate_Proxy(ref IOleInPlaceObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_SetObjectRects_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_SetObjectRects_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        ///lprcPosRect: LPCRECT->RECT*
        ///lprcClipRect: LPCRECT->RECT*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_SetObjectRects_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_SetObjectRects_Proxy(ref IOleInPlaceObject This, ref tagRECT lprcPosRect, ref tagRECT lprcClipRect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_ReactivateAndUndo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_ReactivateAndUndo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_ReactivateAndUndo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_ReactivateAndUndo_Proxy(ref IOleInPlaceObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_InPlaceDeactivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_InPlaceDeactivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceObject_InPlaceDeactivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_InPlaceDeactivate_Proxy(ref IOleInPlaceObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_TranslateAccelerator_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_TranslateAccelerator_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///lpmsg: LPMSG->tagMSG*
        ///wID: WORD->unsigned short
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_TranslateAccelerator_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_TranslateAccelerator_Proxy(ref IOleInPlaceFrame This, ref tagMSG lpmsg, ushort wID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_SetStatusText_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_SetStatusText_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///pszStatusText: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_SetStatusText_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_SetStatusText_Proxy(ref IOleInPlaceFrame This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszStatusText);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_SetMenu_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_SetMenu_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///hmenuShared: HMENU->HMENU__*
        ///holemenu: HOLEMENU->HGLOBAL->HANDLE->void*
        ///hwndActiveObject: HWND->HWND__*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_SetMenu_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_SetMenu_Proxy(ref IOleInPlaceFrame This, IntPtr hmenuShared, IntPtr holemenu, IntPtr hwndActiveObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_RemoveMenus_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_RemoveMenus_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///hmenuShared: HMENU->HMENU__*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_RemoveMenus_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_RemoveMenus_Proxy(ref IOleInPlaceFrame This, IntPtr hmenuShared);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_InsertMenus_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_InsertMenus_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///hmenuShared: HMENU->HMENU__*
        ///lpMenuWidths: LPOLEMENUGROUPWIDTHS->tagOleMenuGroupWidths*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_InsertMenus_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_InsertMenus_Proxy(ref IOleInPlaceFrame This, IntPtr hmenuShared, ref tagOleMenuGroupWidths lpMenuWidths);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_EnableModeless_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_EnableModeless_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///fEnable: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_EnableModeless_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_EnableModeless_Proxy(ref IOleInPlaceFrame This, [MarshalAs(UnmanagedType.Bool)] bool fEnable);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_TranslateAccelerator_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_TranslateAccelerator_Stub(ref IOleInPlaceActiveObject This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///lpmsg: LPMSG->tagMSG*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_TranslateAccelerator_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_TranslateAccelerator_Proxy(ref IOleInPlaceActiveObject This, ref tagMSG lpmsg);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///prcBorder: LPCRECT->RECT*
        ///riid: IID*
        ///pUIWindow: IOleInPlaceUIWindow*
        ///fFrameWindow: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_ResizeBorder_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_ResizeBorder_Stub(ref IOleInPlaceActiveObject This, ref tagRECT prcBorder, ref GUID riid, ref IOleInPlaceUIWindow pUIWindow, [MarshalAs(UnmanagedType.Bool)] bool fFrameWindow);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///prcBorder: LPCRECT->RECT*
        ///pUIWindow: IOleInPlaceUIWindow*
        ///fFrameWindow: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_ResizeBorder_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_ResizeBorder_Proxy(ref IOleInPlaceActiveObject This, ref tagRECT prcBorder, ref IOleInPlaceUIWindow pUIWindow, [MarshalAs(UnmanagedType.Bool)] bool fFrameWindow);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_RemoteTranslateAccelerator_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_RemoteTranslateAccelerator_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_RemoteTranslateAccelerator_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_RemoteTranslateAccelerator_Proxy(ref IOleInPlaceActiveObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_RemoteResizeBorder_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_RemoteResizeBorder_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///prcBorder: LPCRECT->RECT*
        ///riid: IID*
        ///pUIWindow: IOleInPlaceUIWindow*
        ///fFrameWindow: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_RemoteResizeBorder_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_RemoteResizeBorder_Proxy(ref IOleInPlaceActiveObject This, ref tagRECT prcBorder, ref GUID riid, ref IOleInPlaceUIWindow pUIWindow, [MarshalAs(UnmanagedType.Bool)] bool fFrameWindow);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_OnFrameWindowActivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_OnFrameWindowActivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///fActivate: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_OnFrameWindowActivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_OnFrameWindowActivate_Proxy(ref IOleInPlaceActiveObject This, [MarshalAs(UnmanagedType.Bool)] bool fActivate);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_OnDocWindowActivate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_OnDocWindowActivate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///fActivate: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_OnDocWindowActivate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_OnDocWindowActivate_Proxy(ref IOleInPlaceActiveObject This, [MarshalAs(UnmanagedType.Bool)] bool fActivate);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_EnableModeless_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_EnableModeless_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///fEnable: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceActiveObject_EnableModeless_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_EnableModeless_Proxy(ref IOleInPlaceActiveObject This, [MarshalAs(UnmanagedType.Bool)] bool fEnable);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleContainer_LockContainer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleContainer_LockContainer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleContainer*
        ///fLock: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleContainer_LockContainer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleContainer_LockContainer_Proxy(ref IOleContainer This, [MarshalAs(UnmanagedType.Bool)] bool fLock);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleContainer_EnumObjects_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleContainer_EnumObjects_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleContainer*
        ///grfFlags: DWORD->unsigned int
        ///ppenum: IEnumUnknown**
        [DllImport("<Unknown>", EntryPoint = "IOleContainer_EnumObjects_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleContainer_EnumObjects_Proxy(ref IOleContainer This, uint grfFlags, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_ShowObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_ShowObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_ShowObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_ShowObject_Proxy(ref IOleClientSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_SaveObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_SaveObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_SaveObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_SaveObject_Proxy(ref IOleClientSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_RequestNewObjectLayout_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_RequestNewObjectLayout_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_RequestNewObjectLayout_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_RequestNewObjectLayout_Proxy(ref IOleClientSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_OnShowWindow_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_OnShowWindow_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        ///fShow: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_OnShowWindow_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_OnShowWindow_Proxy(ref IOleClientSite This, [MarshalAs(UnmanagedType.Bool)] bool fShow);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_GetMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_GetMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        ///dwAssign: DWORD->unsigned int
        ///dwWhichMoniker: DWORD->unsigned int
        ///ppmk: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_GetMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_GetMoniker_Proxy(ref IOleClientSite This, uint dwAssign, uint dwWhichMoniker, ref IntPtr ppmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_GetContainer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_GetContainer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        ///ppContainer: IOleContainer**
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_GetContainer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_GetContainer_Proxy(ref IOleClientSite This, ref IntPtr ppContainer);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Uncache_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_Uncache_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Uncache_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_Uncache_Proxy(ref IOleCache This, uint dwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_SetData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_SetData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///pformatetc: FORMATETC*
        ///pmedium: STGMEDIUM*
        ///fRelease: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleCache_SetData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_SetData_Proxy(ref IOleCache This, ref tagFORMATETC pformatetc, ref tagSTGMEDIUM pmedium, [MarshalAs(UnmanagedType.Bool)] bool fRelease);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_InitCache_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_InitCache_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///pDataObject: IDataObject*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_InitCache_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_InitCache_Proxy(ref IOleCache This, ref IDataObject pDataObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_EnumCache_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_EnumCache_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///ppenumSTATDATA: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IOleCache_EnumCache_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_EnumCache_Proxy(ref IOleCache This, ref IntPtr ppenumSTATDATA);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Cache_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_Cache_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///pformatetc: FORMATETC*
        ///advf: DWORD->unsigned int
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Cache_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_Cache_Proxy(ref IOleCache This, ref tagFORMATETC pformatetc, uint advf, ref uint pdwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnStop_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCacheControl_OnStop_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCacheControl*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnStop_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCacheControl_OnStop_Proxy(ref IOleCacheControl This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnRun_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCacheControl_OnRun_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCacheControl*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnRun_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCacheControl_OnRun_Proxy(ref IOleCacheControl This, ref IDataObject pDataObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        ///grfUpdf: DWORD->unsigned int
        ///pReserved: LONG_PTR->int
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_UpdateCache_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_UpdateCache_Stub(ref IOleCache2 This, ref IDataObject pDataObject, uint grfUpdf, [MarshalAs(UnmanagedType.SysInt)] IntPtr pReserved);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        ///grfUpdf: DWORD->unsigned int
        ///pReserved: LPVOID->void*
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_UpdateCache_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_UpdateCache_Proxy(ref IOleCache2 This, ref IDataObject pDataObject, uint grfUpdf, IntPtr pReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_RemoteUpdateCache_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache2_RemoteUpdateCache_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        ///grfUpdf: DWORD->unsigned int
        ///pReserved: LONG_PTR->int
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_RemoteUpdateCache_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_RemoteUpdateCache_Proxy(ref IOleCache2 This, ref IDataObject pDataObject, uint grfUpdf, [MarshalAs(UnmanagedType.SysInt)] IntPtr pReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_DiscardCache_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache2_DiscardCache_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///dwDiscardOptions: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_DiscardCache_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_DiscardCache_Proxy(ref IOleCache2 This, uint dwDiscardOptions);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Unadvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_Unadvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Unadvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_Unadvise_Proxy(ref IOleAdviseHolder This, uint dwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_SendOnSave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_SendOnSave_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_SendOnSave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_SendOnSave_Proxy(ref IOleAdviseHolder This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_SendOnRename_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_SendOnRename_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_SendOnRename_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_SendOnRename_Proxy(ref IOleAdviseHolder This, ref IMoniker pmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_SendOnClose_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_SendOnClose_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_SendOnClose_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_SendOnClose_Proxy(ref IOleAdviseHolder This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_EnumAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_EnumAdvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///ppenumAdvise: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_EnumAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_EnumAdvise_Proxy(ref IOleAdviseHolder This, ref IntPtr ppenumAdvise);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Advise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_Advise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///pAdvise: IAdviseSink*
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Advise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_Advise_Proxy(ref IOleAdviseHolder This, ref IAdviseSink pAdvise, ref uint pdwConnection);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///cmd: int
        ///argp: u_long*
        [DllImport("ws2_32.dll", EntryPoint = "ioctlsocket", CallingConvention = CallingConvention.StdCall)]
        public static extern int ioctlsocket([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, int cmd, ref uint argp);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImport("gdi32.dll", EntryPoint = "InvertRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvertRgn([In] IntPtr hdc, [In] IntPtr hrgn);


        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        [DllImport("user32.dll", EntryPoint = "InvertRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvertRect([In] IntPtr hDC, [In] ref tagRECT lprc);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "InvalidateRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: RECT*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "InvalidateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRect([In] IntPtr hWnd, [In] IntPtr lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);


        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc1: RECT*
        ///lprcSrc2: RECT*
        [DllImport("user32.dll", EntryPoint = "IntersectRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IntersectRect([Out] out tagRECT lprcDst, [In] ref tagRECT lprcSrc1, [In] ref tagRECT lprcSrc2);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImport("gdi32.dll", EntryPoint = "IntersectClipRect")]
        public static extern int IntersectClipRect([In] IntPtr hdc, int left, int top, int right, int bottom);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///pString: LPWSTR->WCHAR*
        ///cchMaxCount: int
        [DllImport("user32.dll", EntryPoint = "InternalGetWindowText")]
        public static extern int InternalGetWindowText([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pString, int cchMaxCount);


        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        ///ListEntry: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedPushEntrySList")]
        public static extern IntPtr InterlockedPushEntrySList(ref SLIST_HEADER ListHead, ref SINGLE_LIST_ENTRY ListEntry);


        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedPopEntrySList")]
        public static extern IntPtr InterlockedPopEntrySList(ref SLIST_HEADER ListHead);


        /// Return Type: LONG->int
        ///lpAddend: LONG*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedIncrement")]
        public static extern int InterlockedIncrement(ref int lpAddend);


        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedFlushSList")]
        public static extern IntPtr InterlockedFlushSList(ref SLIST_HEADER ListHead);


        /// Return Type: LONG->int
        ///Addend: LONG*
        ///Value: LONG->int
        [DllImport("kernel32.dll", EntryPoint = "InterlockedExchangeAdd")]
        public static extern int InterlockedExchangeAdd(ref int Addend, int Value);


        /// Return Type: LONG->int
        ///Target: LONG*
        ///Value: LONG->int
        [DllImport("kernel32.dll", EntryPoint = "InterlockedExchange")]
        public static extern int InterlockedExchange(ref int Target, int Value);


        /// Return Type: LONG->int
        ///lpAddend: LONG*
        [DllImport("kernel32.dll", EntryPoint = "InterlockedDecrement")]
        public static extern int InterlockedDecrement(ref int lpAddend);


        /// Return Type: LONGLONG->__int64
        ///Destination: LONGLONG*
        ///Exchange: LONGLONG->__int64
        ///Comperand: LONGLONG->__int64
        [DllImport("<Unknown>", EntryPoint = "InterlockedCompareExchange64")]
        public static extern long InterlockedCompareExchange64(ref long Destination, long Exchange, long Comperand);


        /// Return Type: LONG->int
        ///Destination: LONG*
        ///Exchange: LONG->int
        ///Comperand: LONG->int
        [DllImport("kernel32.dll", EntryPoint = "InterlockedCompareExchange")]
        public static extern int InterlockedCompareExchange(ref int Destination, int Exchange, int Comperand);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "InsertMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuW([In] IntPtr hMenu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uIDNewItem, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);


        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmi: LPCMENUITEMINFOW->MENUITEMINFOW*
        [DllImport("user32.dll", EntryPoint = "InsertMenuItemW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuItemW([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, [In] ref tagMENUITEMINFOW lpmi);


        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmi: LPCMENUITEMINFOA->MENUITEMINFOA*
        [DllImport("user32.dll", EntryPoint = "InsertMenuItemA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuItemA([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, [In] ref tagMENUITEMINFOA lpmi);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "InsertMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuA([In] IntPtr hMenu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uIDNewItem, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);


        /// Return Type: DWORD->unsigned int
        ///lpReserved: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "InSendMessageEx")]
        public static extern uint InSendMessageEx(IntPtr lpReserved);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "InSendMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InSendMessage();


        /// Return Type: BOOL->int
        ///lpMachineName: LPWSTR->WCHAR*
        ///lpMessage: LPWSTR->WCHAR*
        ///dwTimeout: DWORD->unsigned int
        ///bForceAppsClosed: BOOL->int
        ///bRebootAfterShutdown: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "InitiateSystemShutdownW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitiateSystemShutdownW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpMachineName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpMessage, uint dwTimeout, [MarshalAs(UnmanagedType.Bool)] bool bForceAppsClosed, [MarshalAs(UnmanagedType.Bool)] bool bRebootAfterShutdown);


        /// Return Type: BOOL->int
        ///lpMachineName: LPWSTR->WCHAR*
        ///lpMessage: LPWSTR->WCHAR*
        ///dwTimeout: DWORD->unsigned int
        ///bForceAppsClosed: BOOL->int
        ///bRebootAfterShutdown: BOOL->int
        ///dwReason: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "InitiateSystemShutdownExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitiateSystemShutdownExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpMachineName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpMessage, uint dwTimeout, [MarshalAs(UnmanagedType.Bool)] bool bForceAppsClosed, [MarshalAs(UnmanagedType.Bool)] bool bRebootAfterShutdown, uint dwReason);


        /// Return Type: BOOL->int
        ///lpMachineName: LPSTR->CHAR*
        ///lpMessage: LPSTR->CHAR*
        ///dwTimeout: DWORD->unsigned int
        ///bForceAppsClosed: BOOL->int
        ///bRebootAfterShutdown: BOOL->int
        ///dwReason: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "InitiateSystemShutdownExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitiateSystemShutdownExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpMachineName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMessage, uint dwTimeout, [MarshalAs(UnmanagedType.Bool)] bool bForceAppsClosed, [MarshalAs(UnmanagedType.Bool)] bool bRebootAfterShutdown, uint dwReason);


        /// Return Type: BOOL->int
        ///lpMachineName: LPSTR->CHAR*
        ///lpMessage: LPSTR->CHAR*
        ///dwTimeout: DWORD->unsigned int
        ///bForceAppsClosed: BOOL->int
        ///bRebootAfterShutdown: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "InitiateSystemShutdownA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitiateSystemShutdownA([In] [MarshalAs(UnmanagedType.LPStr)] string lpMachineName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMessage, uint dwTimeout, [MarshalAs(UnmanagedType.Bool)] bool bForceAppsClosed, [MarshalAs(UnmanagedType.Bool)] bool bRebootAfterShutdown);


        /// Return Type: void
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "InitializeSListHead")]
        public static extern void InitializeSListHead(ref SLIST_HEADER ListHead);


        /// Return Type: BOOL->int
        ///Sid: PSID->PVOID->void*
        ///pIdentifierAuthority: PSID_IDENTIFIER_AUTHORITY->_SID_IDENTIFIER_AUTHORITY*
        ///nSubAuthorityCount: BYTE->unsigned char
        [DllImport("advapi32.dll", EntryPoint = "InitializeSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitializeSid(IntPtr Sid, [In] ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, byte nSubAuthorityCount);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///dwRevision: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "InitializeSecurityDescriptor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitializeSecurityDescriptor(IntPtr pSecurityDescriptor, uint dwRevision);


        /// Return Type: BOOL->int
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        ///dwSpinCount: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "InitializeCriticalSectionAndSpinCount")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitializeCriticalSectionAndSpinCount([Out] out RTL_CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);


        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "InitializeCriticalSection")]
        public static extern void InitializeCriticalSection([Out] out RTL_CRITICAL_SECTION lpCriticalSection);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///nAclLength: DWORD->unsigned int
        ///dwAclRevision: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "InitializeAcl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitializeAcl(IntPtr pAcl, uint nAclLength, uint dwAclRevision);


        /// Return Type: BOOL->int
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "InitAtomTable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InitAtomTable(uint nSize);


        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        ///dx: int
        ///dy: int
        [DllImport("user32.dll", EntryPoint = "InflateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InflateRect(ref tagRECT lprc, int dx, int dy);


        /// Return Type: char*
        ///in: in_addr
        [DllImport("ws2_32.dll", EntryPoint = "inet_ntoa", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr inet_ntoa(in_addr @in);


        /// Return Type: unsigned int
        ///cp: char*
        [DllImport("ws2_32.dll", EntryPoint = "inet_addr", CallingConvention = CallingConvention.StdCall)]
        public static extern uint inet_addr([In] [MarshalAs(UnmanagedType.LPStr)] string cp);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMultiQI_QueryMultipleInterfaces_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMultiQI_QueryMultipleInterfaces_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMultiQI*
        ///cMQIs: ULONG->unsigned int
        ///pMQIs: MULTI_QI*
        [DllImport("<Unknown>", EntryPoint = "IMultiQI_QueryMultipleInterfaces_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMultiQI_QueryMultipleInterfaces_Proxy(ref IMultiQI This, uint cMQIs, ref tagMULTI_QI pMQIs);


        /// Return Type: BOOL->int
        ///ImpersonationLevel: SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
        [DllImport("advapi32.dll", EntryPoint = "ImpersonateSelf")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImpersonateSelf(SECURITY_IMPERSONATION_LEVEL ImpersonationLevel);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "ImpersonateNamedPipeClient")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImpersonateNamedPipeClient([In] IntPtr hNamedPipe);


        /// Return Type: BOOL->int
        ///hToken: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "ImpersonateLoggedOnUser")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImpersonateLoggedOnUser([In] IntPtr hToken);


        /// Return Type: BOOL->int
        ///hWndClient: HWND->HWND__*
        ///hWndServer: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ImpersonateDdeClientWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImpersonateDdeClientWindow(IntPtr hWndClient, IntPtr hWndServer);


        /// Return Type: BOOL->int
        ///ThreadHandle: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "ImpersonateAnonymousToken")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImpersonateAnonymousToken([In] IntPtr ThreadHandle);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_RemoteBindToStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_RemoteBindToStorage_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_RemoteBindToStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_RemoteBindToStorage_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_RemoteBindToObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_RemoteBindToObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///riidResult: IID*
        ///ppvResult: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_RemoteBindToObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_RemoteBindToObject_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref GUID riidResult, ref IntPtr ppvResult);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_RelativePathTo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_RelativePathTo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pmkOther: IMoniker*
        ///ppmkRelPath: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_RelativePathTo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_RelativePathTo_Proxy(ref IMoniker This, ref IMoniker pmkOther, ref IntPtr ppmkRelPath);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Reduce_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_Reduce_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///dwReduceHowFar: DWORD->unsigned int
        ///ppmkToLeft: IMoniker**
        ///ppmkReduced: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Reduce_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_Reduce_Proxy(ref IMoniker This, ref IBindCtx pbc, uint dwReduceHowFar, ref IntPtr ppmkToLeft, ref IntPtr ppmkReduced);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_ParseDisplayName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_ParseDisplayName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///pszDisplayName: LPOLESTR->OLECHAR*
        ///pchEaten: ULONG*
        ///ppmkOut: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_ParseDisplayName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_ParseDisplayName_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, IntPtr pszDisplayName, ref uint pchEaten, ref IntPtr ppmkOut);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_IsSystemMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_IsSystemMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pdwMksys: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_IsSystemMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_IsSystemMoniker_Proxy(ref IMoniker This, ref uint pdwMksys);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_IsRunning_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_IsRunning_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///pmkNewlyRunning: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_IsRunning_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_IsRunning_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref IMoniker pmkNewlyRunning);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_IsEqual_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_IsEqual_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pmkOtherMoniker: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_IsEqual_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_IsEqual_Proxy(ref IMoniker This, ref IMoniker pmkOtherMoniker);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Inverse_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_Inverse_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///ppmk: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Inverse_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_Inverse_Proxy(ref IMoniker This, ref IntPtr ppmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Hash_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_Hash_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pdwHash: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Hash_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_Hash_Proxy(ref IMoniker This, ref uint pdwHash);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_GetTimeOfLastChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_GetTimeOfLastChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///pFileTime: FILETIME*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_GetTimeOfLastChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_GetTimeOfLastChange_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref FILETIME pFileTime);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_GetDisplayName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_GetDisplayName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///ppszDisplayName: LPOLESTR*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_GetDisplayName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_GetDisplayName_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref IntPtr ppszDisplayName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Enum_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_Enum_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///fForward: BOOL->int
        ///ppenumMoniker: IEnumMoniker**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_Enum_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_Enum_Proxy(ref IMoniker This, [MarshalAs(UnmanagedType.Bool)] bool fForward, ref IntPtr ppenumMoniker);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_ComposeWith_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_ComposeWith_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pmkRight: IMoniker*
        ///fOnlyIfNotGeneric: BOOL->int
        ///ppmkComposite: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_ComposeWith_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_ComposeWith_Proxy(ref IMoniker This, ref IMoniker pmkRight, [MarshalAs(UnmanagedType.Bool)] bool fOnlyIfNotGeneric, ref IntPtr ppmkComposite);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMoniker_CommonPrefixWith_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMoniker_CommonPrefixWith_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pmkOther: IMoniker*
        ///ppmkPrefix: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_CommonPrefixWith_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_CommonPrefixWith_Proxy(ref IMoniker This, ref IMoniker pmkOther, ref IntPtr ppmkPrefix);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_BindToStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_BindToStorage_Stub(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///riid: IID*
        ///ppvObj: void**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_BindToStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_BindToStorage_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///riidResult: IID*
        ///ppvResult: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_BindToObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_BindToObject_Stub(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref GUID riidResult, ref IntPtr ppvResult);


        /// Return Type: HRESULT->LONG->int
        ///This: IMoniker*
        ///pbc: IBindCtx*
        ///pmkToLeft: IMoniker*
        ///riidResult: IID*
        ///ppvResult: void**
        [DllImport("<Unknown>", EntryPoint = "IMoniker_BindToObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMoniker_BindToObject_Proxy(ref IMoniker This, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref GUID riidResult, ref IntPtr ppvResult);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMonikerProp_PutProperty_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMonikerProp_PutProperty_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMonikerProp*
        ///mkp: MONIKERPROPERTY->__MIDL_IMonikerProp_0001
        ///val: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IMonikerProp_PutProperty_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMonikerProp_PutProperty_Proxy(ref IMonikerProp This, MONIKERPROPERTY mkp, [In] [MarshalAs(UnmanagedType.LPWStr)] string val);


        /// Return Type: BOOL->int
        ///param0: HKL->HKL__*
        ///lpszReading: LPCWSTR->WCHAR*
        ///param2: DWORD->unsigned int
        ///lpszUnregister: LPCWSTR->WCHAR*
        [DllImport("imm32.dll", EntryPoint = "ImmUnregisterWordW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmUnregisterWordW(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszReading, uint param2, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszUnregister);


        /// Return Type: BOOL->int
        ///param0: HKL->HKL__*
        ///lpszReading: LPCSTR->CHAR*
        ///param2: DWORD->unsigned int
        ///lpszUnregister: LPCSTR->CHAR*
        [DllImport("imm32.dll", EntryPoint = "ImmUnregisterWordA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmUnregisterWordA(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszReading, uint param2, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszUnregister);


        /// Return Type: BOOL->int
        ///param0: HWND->HWND__*
        ///param1: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmSimulateHotKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSimulateHotKey(IntPtr param0, uint param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPPOINT->tagPOINT*
        [DllImport("imm32.dll", EntryPoint = "ImmSetStatusWindowPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetStatusWindowPos(IntPtr param0, ref Point param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: BOOL->int
        [DllImport("imm32.dll", EntryPoint = "ImmSetOpenStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetOpenStatus(IntPtr param0, [MarshalAs(UnmanagedType.Bool)] bool param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: DWORD->unsigned int
        ///param2: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmSetConversionStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetConversionStatus(IntPtr param0, uint param1, uint param2);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPCOMPOSITIONFORM->tagCOMPOSITIONFORM*
        [DllImport("imm32.dll", EntryPoint = "ImmSetCompositionWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetCompositionWindow(IntPtr param0, ref tagCOMPOSITIONFORM param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///dwIndex: DWORD->unsigned int
        ///lpComp: LPVOID->void*
        ///param3: DWORD->unsigned int
        ///lpRead: LPVOID->void*
        ///param5: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmSetCompositionStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetCompositionStringW(IntPtr param0, uint dwIndex, IntPtr lpComp, uint param3, IntPtr lpRead, uint param5);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///dwIndex: DWORD->unsigned int
        ///lpComp: LPVOID->void*
        ///param3: DWORD->unsigned int
        ///lpRead: LPVOID->void*
        ///param5: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmSetCompositionStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetCompositionStringA(IntPtr param0, uint dwIndex, IntPtr lpComp, uint param3, IntPtr lpRead, uint param5);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPLOGFONTW->tagLOGFONTW*
        [DllImport("imm32.dll", EntryPoint = "ImmSetCompositionFontW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetCompositionFontW(IntPtr param0, ref tagLOGFONTW param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPLOGFONTA->tagLOGFONTA*
        [DllImport("imm32.dll", EntryPoint = "ImmSetCompositionFontA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetCompositionFontA(IntPtr param0, ref tagLOGFONTA param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPCANDIDATEFORM->tagCANDIDATEFORM*
        [DllImport("imm32.dll", EntryPoint = "ImmSetCandidateWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmSetCandidateWindow(IntPtr param0, ref tagCANDIDATEFORM param1);


        /// Return Type: BOOL->int
        ///param0: HWND->HWND__*
        ///param1: HIMC->HIMC__*
        [DllImport("imm32.dll", EntryPoint = "ImmReleaseContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmReleaseContext(IntPtr param0, IntPtr param1);


        /// Return Type: BOOL->int
        ///param0: HKL->HKL__*
        ///lpszReading: LPCWSTR->WCHAR*
        ///param2: DWORD->unsigned int
        ///lpszRegister: LPCWSTR->WCHAR*
        [DllImport("imm32.dll", EntryPoint = "ImmRegisterWordW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmRegisterWordW(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszReading, uint param2, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszRegister);


        /// Return Type: BOOL->int
        ///param0: HKL->HKL__*
        ///lpszReading: LPCSTR->CHAR*
        ///param2: DWORD->unsigned int
        ///lpszRegister: LPCSTR->CHAR*
        [DllImport("imm32.dll", EntryPoint = "ImmRegisterWordA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmRegisterWordA(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszReading, uint param2, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszRegister);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///dwAction: DWORD->unsigned int
        ///dwIndex: DWORD->unsigned int
        ///dwValue: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmNotifyIME")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmNotifyIME(IntPtr param0, uint dwAction, uint dwIndex, uint dwValue);


        /// Return Type: BOOL->int
        ///param0: HWND->HWND__*
        ///param1: UINT->unsigned int
        ///param2: WPARAM->UINT_PTR->unsigned int
        ///param3: LPARAM->LONG_PTR->int
        [DllImport("imm32.dll", EntryPoint = "ImmIsUIMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmIsUIMessageW(IntPtr param0, uint param1, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr param2, [MarshalAs(UnmanagedType.SysInt)] IntPtr param3);


        /// Return Type: BOOL->int
        ///param0: HWND->HWND__*
        ///param1: UINT->unsigned int
        ///param2: WPARAM->UINT_PTR->unsigned int
        ///param3: LPARAM->LONG_PTR->int
        [DllImport("imm32.dll", EntryPoint = "ImmIsUIMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmIsUIMessageA(IntPtr param0, uint param1, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr param2, [MarshalAs(UnmanagedType.SysInt)] IntPtr param3);


        /// Return Type: BOOL->int
        ///param0: HKL->HKL__*
        [DllImport("imm32.dll", EntryPoint = "ImmIsIME")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmIsIME(IntPtr param0);


        /// Return Type: HKL->HKL__*
        ///lpszIMEFileName: LPCWSTR->WCHAR*
        ///lpszLayoutText: LPCWSTR->WCHAR*
        [DllImport("imm32.dll", EntryPoint = "ImmInstallIMEW")]
        public static extern IntPtr ImmInstallIMEW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszIMEFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszLayoutText);


        /// Return Type: HKL->HKL__*
        ///lpszIMEFileName: LPCSTR->CHAR*
        ///lpszLayoutText: LPCSTR->CHAR*
        [DllImport("imm32.dll", EntryPoint = "ImmInstallIMEA")]
        public static extern IntPtr ImmInstallIMEA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszIMEFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszLayoutText);


        /// Return Type: UINT->unsigned int
        ///param0: HWND->HWND__*
        [DllImport("imm32.dll", EntryPoint = "ImmGetVirtualKey")]
        public static extern uint ImmGetVirtualKey(IntPtr param0);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPPOINT->tagPOINT*
        [DllImport("imm32.dll", EntryPoint = "ImmGetStatusWindowPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmGetStatusWindowPos(IntPtr param0, ref Point param1);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///nItem: UINT->unsigned int
        ///param2: LPSTYLEBUFW->tagSTYLEBUFW*
        [DllImport("imm32.dll", EntryPoint = "ImmGetRegisterWordStyleW")]
        public static extern uint ImmGetRegisterWordStyleW(IntPtr param0, uint nItem, ref tagSTYLEBUFW param2);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///nItem: UINT->unsigned int
        ///param2: LPSTYLEBUFA->tagSTYLEBUFA*
        [DllImport("imm32.dll", EntryPoint = "ImmGetRegisterWordStyleA")]
        public static extern uint ImmGetRegisterWordStyleA(IntPtr param0, uint nItem, ref tagSTYLEBUFA param2);


        /// Return Type: DWORD->unsigned int
        ///param0: HKL->HKL__*
        ///param1: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetProperty")]
        public static extern uint ImmGetProperty(IntPtr param0, uint param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        [DllImport("imm32.dll", EntryPoint = "ImmGetOpenStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmGetOpenStatus(IntPtr param0);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///param1: DWORD->unsigned int
        ///param2: DWORD->unsigned int
        ///param3: LPIMEMENUITEMINFOW->tagIMEMENUITEMINFOW*
        ///param4: LPIMEMENUITEMINFOW->tagIMEMENUITEMINFOW*
        ///param5: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetImeMenuItemsW")]
        public static extern uint ImmGetImeMenuItemsW(IntPtr param0, uint param1, uint param2, ref tagIMEMENUITEMINFOW param3, ref tagIMEMENUITEMINFOW param4, uint param5);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///param1: DWORD->unsigned int
        ///param2: DWORD->unsigned int
        ///param3: LPIMEMENUITEMINFOA->tagIMEMENUITEMINFOA*
        ///param4: LPIMEMENUITEMINFOA->tagIMEMENUITEMINFOA*
        ///param5: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetImeMenuItemsA")]
        public static extern uint ImmGetImeMenuItemsA(IntPtr param0, uint param1, uint param2, ref tagIMEMENUITEMINFOA param3, ref tagIMEMENUITEMINFOA param4, uint param5);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///param1: LPWSTR->WCHAR*
        ///uBufLen: UINT->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetIMEFileNameW")]
        public static extern uint ImmGetIMEFileNameW(IntPtr param0, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param1, uint uBufLen);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///param1: LPSTR->CHAR*
        ///uBufLen: UINT->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetIMEFileNameA")]
        public static extern uint ImmGetIMEFileNameA(IntPtr param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, uint uBufLen);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///dwIndex: DWORD->unsigned int
        ///param2: LPWSTR->WCHAR*
        ///dwBufLen: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetGuideLineW")]
        public static extern uint ImmGetGuideLineW(IntPtr param0, uint dwIndex, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param2, uint dwBufLen);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///dwIndex: DWORD->unsigned int
        ///param2: LPSTR->CHAR*
        ///dwBufLen: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetGuideLineA")]
        public static extern uint ImmGetGuideLineA(IntPtr param0, uint dwIndex, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param2, uint dwBufLen);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///param1: LPWSTR->WCHAR*
        ///uBufLen: UINT->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetDescriptionW")]
        public static extern uint ImmGetDescriptionW(IntPtr param0, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param1, uint uBufLen);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///param1: LPSTR->CHAR*
        ///uBufLen: UINT->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetDescriptionA")]
        public static extern uint ImmGetDescriptionA(IntPtr param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, uint uBufLen);


        /// Return Type: HWND->HWND__*
        ///param0: HWND->HWND__*
        [DllImport("imm32.dll", EntryPoint = "ImmGetDefaultIMEWnd")]
        public static extern IntPtr ImmGetDefaultIMEWnd(IntPtr param0);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPDWORD->DWORD*
        ///param2: LPDWORD->DWORD*
        [DllImport("imm32.dll", EntryPoint = "ImmGetConversionStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmGetConversionStatus(IntPtr param0, ref uint param1, ref uint param2);


        /// Return Type: DWORD->unsigned int
        ///param0: HKL->HKL__*
        ///param1: HIMC->HIMC__*
        ///param2: LPCWSTR->WCHAR*
        ///param3: LPCANDIDATELIST->tagCANDIDATELIST*
        ///dwBufLen: DWORD->unsigned int
        ///uFlag: UINT->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetConversionListW")]
        public static extern uint ImmGetConversionListW(IntPtr param0, IntPtr param1, [In] [MarshalAs(UnmanagedType.LPWStr)] string param2, ref tagCANDIDATELIST param3, uint dwBufLen, uint uFlag);


        /// Return Type: DWORD->unsigned int
        ///param0: HKL->HKL__*
        ///param1: HIMC->HIMC__*
        ///param2: LPCSTR->CHAR*
        ///param3: LPCANDIDATELIST->tagCANDIDATELIST*
        ///dwBufLen: DWORD->unsigned int
        ///uFlag: UINT->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetConversionListA")]
        public static extern uint ImmGetConversionListA(IntPtr param0, IntPtr param1, [In] [MarshalAs(UnmanagedType.LPStr)] string param2, ref tagCANDIDATELIST param3, uint dwBufLen, uint uFlag);


        /// Return Type: HIMC->HIMC__*
        ///param0: HWND->HWND__*
        [DllImport("imm32.dll", EntryPoint = "ImmGetContext")]
        public static extern IntPtr ImmGetContext(IntPtr param0);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPCOMPOSITIONFORM->tagCOMPOSITIONFORM*
        [DllImport("imm32.dll", EntryPoint = "ImmGetCompositionWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmGetCompositionWindow(IntPtr param0, ref tagCOMPOSITIONFORM param1);


        /// Return Type: LONG->int
        ///param0: HIMC->HIMC__*
        ///param1: DWORD->unsigned int
        ///param2: LPVOID->void*
        ///param3: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetCompositionStringW")]
        public static extern int ImmGetCompositionStringW(IntPtr param0, uint param1, IntPtr param2, uint param3);


        /// Return Type: LONG->int
        ///param0: HIMC->HIMC__*
        ///param1: DWORD->unsigned int
        ///param2: LPVOID->void*
        ///param3: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetCompositionStringA")]
        public static extern int ImmGetCompositionStringA(IntPtr param0, uint param1, IntPtr param2, uint param3);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPLOGFONTW->tagLOGFONTW*
        [DllImport("imm32.dll", EntryPoint = "ImmGetCompositionFontW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmGetCompositionFontW(IntPtr param0, ref tagLOGFONTW param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: LPLOGFONTA->tagLOGFONTA*
        [DllImport("imm32.dll", EntryPoint = "ImmGetCompositionFontA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmGetCompositionFontA(IntPtr param0, ref tagLOGFONTA param1);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        ///param1: DWORD->unsigned int
        ///param2: LPCANDIDATEFORM->tagCANDIDATEFORM*
        [DllImport("imm32.dll", EntryPoint = "ImmGetCandidateWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmGetCandidateWindow(IntPtr param0, uint param1, ref tagCANDIDATEFORM param2);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///deIndex: DWORD->unsigned int
        ///param2: LPCANDIDATELIST->tagCANDIDATELIST*
        ///dwBufLen: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetCandidateListW")]
        public static extern uint ImmGetCandidateListW(IntPtr param0, uint deIndex, ref tagCANDIDATELIST param2, uint dwBufLen);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///lpdwListCount: LPDWORD->DWORD*
        [DllImport("imm32.dll", EntryPoint = "ImmGetCandidateListCountW")]
        public static extern uint ImmGetCandidateListCountW(IntPtr param0, ref uint lpdwListCount);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///lpdwListCount: LPDWORD->DWORD*
        [DllImport("imm32.dll", EntryPoint = "ImmGetCandidateListCountA")]
        public static extern uint ImmGetCandidateListCountA(IntPtr param0, ref uint lpdwListCount);


        /// Return Type: DWORD->unsigned int
        ///param0: HIMC->HIMC__*
        ///deIndex: DWORD->unsigned int
        ///param2: LPCANDIDATELIST->tagCANDIDATELIST*
        ///dwBufLen: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmGetCandidateListA")]
        public static extern uint ImmGetCandidateListA(IntPtr param0, uint deIndex, ref tagCANDIDATELIST param2, uint dwBufLen);


        /// Return Type: LRESULT->LONG_PTR->int
        ///param0: HKL->HKL__*
        ///param1: HIMC->HIMC__*
        ///param2: UINT->unsigned int
        ///param3: LPVOID->void*
        [DllImport("imm32.dll", EntryPoint = "ImmEscapeW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr ImmEscapeW(IntPtr param0, IntPtr param1, uint param2, IntPtr param3);


        /// Return Type: LRESULT->LONG_PTR->int
        ///param0: HKL->HKL__*
        ///param1: HIMC->HIMC__*
        ///param2: UINT->unsigned int
        ///param3: LPVOID->void*
        [DllImport("imm32.dll", EntryPoint = "ImmEscapeA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr ImmEscapeA(IntPtr param0, IntPtr param1, uint param2, IntPtr param3);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///param1: REGISTERWORDENUMPROCW
        ///lpszReading: LPCWSTR->WCHAR*
        ///param3: DWORD->unsigned int
        ///lpszRegister: LPCWSTR->WCHAR*
        ///param5: LPVOID->void*
        [DllImport("imm32.dll", EntryPoint = "ImmEnumRegisterWordW")]
        public static extern uint ImmEnumRegisterWordW(IntPtr param0, REGISTERWORDENUMPROCW param1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszReading, uint param3, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszRegister, IntPtr param5);


        /// Return Type: UINT->unsigned int
        ///param0: HKL->HKL__*
        ///param1: REGISTERWORDENUMPROCA
        ///lpszReading: LPCSTR->CHAR*
        ///param3: DWORD->unsigned int
        ///lpszRegister: LPCSTR->CHAR*
        ///param5: LPVOID->void*
        [DllImport("imm32.dll", EntryPoint = "ImmEnumRegisterWordA")]
        public static extern uint ImmEnumRegisterWordA(IntPtr param0, REGISTERWORDENUMPROCA param1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszReading, uint param3, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszRegister, IntPtr param5);


        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        ///lpfn: IMCENUMPROC
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("imm32.dll", EntryPoint = "ImmEnumInputContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmEnumInputContext(uint idThread, IMCENUMPROC lpfn, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmDisableTextFrameService")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmDisableTextFrameService(uint idThread);


        /// Return Type: BOOL->int
        ///param0: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmDisableIME")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmDisableIME(uint param0);


        /// Return Type: BOOL->int
        ///param0: HIMC->HIMC__*
        [DllImport("imm32.dll", EntryPoint = "ImmDestroyContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmDestroyContext(IntPtr param0);


        /// Return Type: HIMC->HIMC__*
        [DllImport("imm32.dll", EntryPoint = "ImmCreateContext")]
        public static extern IntPtr ImmCreateContext();


        /// Return Type: BOOL->int
        ///param0: HKL->HKL__*
        ///param1: HWND->HWND__*
        ///param2: DWORD->unsigned int
        ///param3: LPVOID->void*
        [DllImport("imm32.dll", EntryPoint = "ImmConfigureIMEW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmConfigureIMEW(IntPtr param0, IntPtr param1, uint param2, IntPtr param3);


        /// Return Type: BOOL->int
        ///param0: HKL->HKL__*
        ///param1: HWND->HWND__*
        ///param2: DWORD->unsigned int
        ///param3: LPVOID->void*
        [DllImport("imm32.dll", EntryPoint = "ImmConfigureIMEA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmConfigureIMEA(IntPtr param0, IntPtr param1, uint param2, IntPtr param3);


        /// Return Type: BOOL->int
        ///param0: HWND->HWND__*
        ///param1: HIMC->HIMC__*
        ///param2: DWORD->unsigned int
        [DllImport("imm32.dll", EntryPoint = "ImmAssociateContextEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImmAssociateContextEx(IntPtr param0, IntPtr param1, uint param2);


        /// Return Type: HIMC->HIMC__*
        ///param0: HWND->HWND__*
        ///param1: HIMC->HIMC__*
        [DllImport("imm32.dll", EntryPoint = "ImmAssociateContext")]
        public static extern IntPtr ImmAssociateContext(IntPtr param0, IntPtr param1);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMessageFilter_RetryRejectedCall_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMessageFilter_RetryRejectedCall_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: DWORD->unsigned int
        ///This: IMessageFilter*
        ///htaskCallee: HTASK->HTASK__*
        ///dwTickCount: DWORD->unsigned int
        ///dwRejectType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IMessageFilter_RetryRejectedCall_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IMessageFilter_RetryRejectedCall_Proxy(ref IMessageFilter This, IntPtr htaskCallee, uint dwTickCount, uint dwRejectType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMessageFilter_MessagePending_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMessageFilter_MessagePending_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: DWORD->unsigned int
        ///This: IMessageFilter*
        ///htaskCallee: HTASK->HTASK__*
        ///dwTickCount: DWORD->unsigned int
        ///dwPendingType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IMessageFilter_MessagePending_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IMessageFilter_MessagePending_Proxy(ref IMessageFilter This, IntPtr htaskCallee, uint dwTickCount, uint dwPendingType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMessageFilter_HandleInComingCall_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMessageFilter_HandleInComingCall_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: DWORD->unsigned int
        ///This: IMessageFilter*
        ///dwCallType: DWORD->unsigned int
        ///htaskCaller: HTASK->HTASK__*
        ///dwTickCount: DWORD->unsigned int
        ///lpInterfaceInfo: LPINTERFACEINFO->tagINTERFACEINFO*
        [DllImport("<Unknown>", EntryPoint = "IMessageFilter_HandleInComingCall_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IMessageFilter_HandleInComingCall_Proxy(ref IMessageFilter This, uint dwCallType, IntPtr htaskCaller, uint dwTickCount, ref tagINTERFACEINFO lpInterfaceInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_UnmarshalInterface_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMarshal_UnmarshalInterface_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMarshal*
        ///pStm: IStream*
        ///riid: IID*
        ///ppv: void**
        [DllImport("<Unknown>", EntryPoint = "IMarshal_UnmarshalInterface_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMarshal_UnmarshalInterface_Proxy(ref IMarshal This, ref IStream pStm, ref GUID riid, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_ReleaseMarshalData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMarshal_ReleaseMarshalData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMarshal*
        ///pStm: IStream*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_ReleaseMarshalData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMarshal_ReleaseMarshalData_Proxy(ref IMarshal This, ref IStream pStm);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_MarshalInterface_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMarshal_MarshalInterface_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMarshal*
        ///pStm: IStream*
        ///riid: IID*
        ///pv: void*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: void*
        ///mshlflags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IMarshal_MarshalInterface_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMarshal_MarshalInterface_Proxy(ref IMarshal This, ref IStream pStm, ref GUID riid, IntPtr pv, uint dwDestContext, IntPtr pvDestContext, uint mshlflags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_GetUnmarshalClass_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMarshal_GetUnmarshalClass_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMarshal*
        ///riid: IID*
        ///pv: void*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: void*
        ///mshlflags: DWORD->unsigned int
        ///pCid: CLSID*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_GetUnmarshalClass_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMarshal_GetUnmarshalClass_Proxy(ref IMarshal This, ref GUID riid, IntPtr pv, uint dwDestContext, IntPtr pvDestContext, uint mshlflags, ref GUID pCid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_GetMarshalSizeMax_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMarshal_GetMarshalSizeMax_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMarshal*
        ///riid: IID*
        ///pv: void*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: void*
        ///mshlflags: DWORD->unsigned int
        ///pSize: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_GetMarshalSizeMax_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMarshal_GetMarshalSizeMax_Proxy(ref IMarshal This, ref GUID riid, IntPtr pv, uint dwDestContext, IntPtr pvDestContext, uint mshlflags, ref uint pSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMarshal_DisconnectObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMarshal_DisconnectObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IMarshal*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IMarshal_DisconnectObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMarshal_DisconnectObject_Proxy(ref IMarshal This, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_Realloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_Realloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void*
        ///This: IMalloc*
        ///pv: void*
        ///cb: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IMalloc_Realloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IMalloc_Realloc_Proxy(ref IMalloc This, IntPtr pv, uint cb);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_HeapMinimize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_HeapMinimize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IMalloc*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_HeapMinimize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_HeapMinimize_Proxy(ref IMalloc This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_GetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_GetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///This: IMalloc*
        ///pv: void*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_GetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IMalloc_GetSize_Proxy(ref IMalloc This, IntPtr pv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_Free_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_Free_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IMalloc*
        ///pv: void*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_Free_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_Free_Proxy(ref IMalloc This, IntPtr pv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_DidAlloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_DidAlloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: int
        ///This: IMalloc*
        ///pv: void*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_DidAlloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMalloc_DidAlloc_Proxy(ref IMalloc This, IntPtr pv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMalloc_Alloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMalloc_Alloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void*
        ///This: IMalloc*
        ///cb: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IMalloc_Alloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IMalloc_Alloc_Proxy(ref IMalloc This, uint cb);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreRealloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PreRealloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///This: IMallocSpy*
        ///pRequest: void*
        ///cbRequest: SIZE_T->ULONG_PTR->unsigned int
        ///ppNewRequest: void**
        ///fSpyed: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreRealloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IMallocSpy_PreRealloc_Proxy(ref IMallocSpy This, IntPtr pRequest, uint cbRequest, ref IntPtr ppNewRequest, [MarshalAs(UnmanagedType.Bool)] bool fSpyed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreHeapMinimize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PreHeapMinimize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IMallocSpy*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreHeapMinimize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PreHeapMinimize_Proxy(ref IMallocSpy This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreGetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PreGetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void*
        ///This: IMallocSpy*
        ///pRequest: void*
        ///fSpyed: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreGetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IMallocSpy_PreGetSize_Proxy(ref IMallocSpy This, IntPtr pRequest, [MarshalAs(UnmanagedType.Bool)] bool fSpyed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreFree_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PreFree_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void*
        ///This: IMallocSpy*
        ///pRequest: void*
        ///fSpyed: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreFree_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IMallocSpy_PreFree_Proxy(ref IMallocSpy This, IntPtr pRequest, [MarshalAs(UnmanagedType.Bool)] bool fSpyed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreDidAlloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PreDidAlloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void*
        ///This: IMallocSpy*
        ///pRequest: void*
        ///fSpyed: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreDidAlloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IMallocSpy_PreDidAlloc_Proxy(ref IMallocSpy This, IntPtr pRequest, [MarshalAs(UnmanagedType.Bool)] bool fSpyed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreAlloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PreAlloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///This: IMallocSpy*
        ///cbRequest: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PreAlloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IMallocSpy_PreAlloc_Proxy(ref IMallocSpy This, uint cbRequest);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostRealloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostRealloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void*
        ///This: IMallocSpy*
        ///pActual: void*
        ///fSpyed: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostRealloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IMallocSpy_PostRealloc_Proxy(ref IMallocSpy This, IntPtr pActual, [MarshalAs(UnmanagedType.Bool)] bool fSpyed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostHeapMinimize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostHeapMinimize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IMallocSpy*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostHeapMinimize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostHeapMinimize_Proxy(ref IMallocSpy This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostGetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostGetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///This: IMallocSpy*
        ///cbActual: SIZE_T->ULONG_PTR->unsigned int
        ///fSpyed: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostGetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IMallocSpy_PostGetSize_Proxy(ref IMallocSpy This, uint cbActual, [MarshalAs(UnmanagedType.Bool)] bool fSpyed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostFree_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostFree_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IMallocSpy*
        ///fSpyed: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostFree_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostFree_Proxy(ref IMallocSpy This, [MarshalAs(UnmanagedType.Bool)] bool fSpyed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostDidAlloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostDidAlloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: int
        ///This: IMallocSpy*
        ///pRequest: void*
        ///fSpyed: BOOL->int
        ///fActual: int
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostDidAlloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMallocSpy_PostDidAlloc_Proxy(ref IMallocSpy This, IntPtr pRequest, [MarshalAs(UnmanagedType.Bool)] bool fSpyed, int fActual);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostAlloc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IMallocSpy_PostAlloc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void*
        ///This: IMallocSpy*
        ///pActual: void*
        [DllImport("<Unknown>", EntryPoint = "IMallocSpy_PostAlloc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IMallocSpy_PostAlloc_Proxy(ref IMallocSpy This, IntPtr pActual);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_WriteAt_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_WriteAt_Stub(ref ILockBytes This, ULARGE_INTEGER ulOffset, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: void*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_WriteAt_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_WriteAt_Proxy(ref ILockBytes This, ULARGE_INTEGER ulOffset, IntPtr pv, uint cb, ref uint pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_UnlockRegion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILockBytes_UnlockRegion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///libOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        ///dwLockType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_UnlockRegion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_UnlockRegion_Proxy(ref ILockBytes This, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_Stat_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILockBytes_Stat_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///pstatstg: STATSTG*
        ///grfStatFlag: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_Stat_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_Stat_Proxy(ref ILockBytes This, ref tagSTATSTG pstatstg, uint grfStatFlag);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_SetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILockBytes_SetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_SetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_SetSize_Proxy(ref ILockBytes This, ULARGE_INTEGER cb);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_RemoteWriteAt_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILockBytes_RemoteWriteAt_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_RemoteWriteAt_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_RemoteWriteAt_Proxy(ref ILockBytes This, ULARGE_INTEGER ulOffset, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_RemoteReadAt_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILockBytes_RemoteReadAt_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_RemoteReadAt_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_RemoteReadAt_Proxy(ref ILockBytes This, ULARGE_INTEGER ulOffset, ref byte pv, uint cb, ref uint pcbRead);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_ReadAt_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_ReadAt_Stub(ref ILockBytes This, ULARGE_INTEGER ulOffset, ref byte pv, uint cb, ref uint pcbRead);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: void*
        ///cb: ULONG->unsigned int
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_ReadAt_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_ReadAt_Proxy(ref ILockBytes This, ULARGE_INTEGER ulOffset, IntPtr pv, uint cb, ref uint pcbRead);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_LockRegion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILockBytes_LockRegion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        ///libOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///cb: ULARGE_INTEGER->_ULARGE_INTEGER
        ///dwLockType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_LockRegion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_LockRegion_Proxy(ref ILockBytes This, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_Flush_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILockBytes_Flush_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILockBytes*
        [DllImport("<Unknown>", EntryPoint = "ILockBytes_Flush_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILockBytes_Flush_Proxy(ref ILockBytes This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_ReLayoutDocfile_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILayoutStorage_ReLayoutDocfile_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILayoutStorage*
        ///pwcsNewDfName: OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_ReLayoutDocfile_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILayoutStorage_ReLayoutDocfile_Proxy(ref ILayoutStorage This, IntPtr pwcsNewDfName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_ReLayoutDocfileOnILockBytes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILayoutStorage_ReLayoutDocfileOnILockBytes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILayoutStorage*
        ///pILockBytes: ILockBytes*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_ReLayoutDocfileOnILockBytes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILayoutStorage_ReLayoutDocfileOnILockBytes_Proxy(ref ILayoutStorage This, ref ILockBytes pILockBytes);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_LayoutScript_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILayoutStorage_LayoutScript_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILayoutStorage*
        ///pStorageLayout: StorageLayout*
        ///nEntries: DWORD->unsigned int
        ///glfInterleavedFlag: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_LayoutScript_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILayoutStorage_LayoutScript_Proxy(ref ILayoutStorage This, ref tagStorageLayout pStorageLayout, uint nEntries, uint glfInterleavedFlag);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_EndMonitor_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILayoutStorage_EndMonitor_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILayoutStorage*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_EndMonitor_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILayoutStorage_EndMonitor_Proxy(ref ILayoutStorage This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_BeginMonitor_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ILayoutStorage_BeginMonitor_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ILayoutStorage*
        [DllImport("<Unknown>", EntryPoint = "ILayoutStorage_BeginMonitor_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ILayoutStorage_BeginMonitor_Proxy(ref ILayoutStorage This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_SetZoneCustomPolicy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_SetZoneCustomPolicy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwZone: DWORD->unsigned int
        ///guidKey: GUID*
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///urlZoneReg: URLZONEREG->_URLZONEREG
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_SetZoneCustomPolicy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_SetZoneCustomPolicy_Proxy(ref IInternetZoneManager This, uint dwZone, ref GUID guidKey, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_SetZoneAttributes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_SetZoneAttributes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwZone: DWORD->unsigned int
        ///pZoneAttributes: ZONEATTRIBUTES*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_SetZoneAttributes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_SetZoneAttributes_Proxy(ref IInternetZoneManager This, uint dwZone, ref ZONEATTRIBUTES pZoneAttributes);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_SetZoneActionPolicy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_SetZoneActionPolicy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwZone: DWORD->unsigned int
        ///dwAction: DWORD->unsigned int
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///urlZoneReg: URLZONEREG->_URLZONEREG
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_SetZoneActionPolicy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_SetZoneActionPolicy_Proxy(ref IInternetZoneManager This, uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_PromptAction_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_PromptAction_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwAction: DWORD->unsigned int
        ///hwndParent: HWND->HWND__*
        ///pwszUrl: LPCWSTR->WCHAR*
        ///pwszText: LPCWSTR->WCHAR*
        ///dwPromptFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_PromptAction_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_PromptAction_Proxy(ref IInternetZoneManager This, uint dwAction, IntPtr hwndParent, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszText, uint dwPromptFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_LogAction_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_LogAction_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwAction: DWORD->unsigned int
        ///pwszUrl: LPCWSTR->WCHAR*
        ///pwszText: LPCWSTR->WCHAR*
        ///dwLogFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_LogAction_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_LogAction_Proxy(ref IInternetZoneManager This, uint dwAction, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszText, uint dwLogFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneCustomPolicy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_GetZoneCustomPolicy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwZone: DWORD->unsigned int
        ///guidKey: GUID*
        ///ppPolicy: BYTE**
        ///pcbPolicy: DWORD*
        ///urlZoneReg: URLZONEREG->_URLZONEREG
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneCustomPolicy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_GetZoneCustomPolicy_Proxy(ref IInternetZoneManager This, uint dwZone, ref GUID guidKey, ref IntPtr ppPolicy, ref uint pcbPolicy, URLZONEREG urlZoneReg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneAt_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_GetZoneAt_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwEnum: DWORD->unsigned int
        ///dwIndex: DWORD->unsigned int
        ///pdwZone: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneAt_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_GetZoneAt_Proxy(ref IInternetZoneManager This, uint dwEnum, uint dwIndex, ref uint pdwZone);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneAttributes_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_GetZoneAttributes_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwZone: DWORD->unsigned int
        ///pZoneAttributes: ZONEATTRIBUTES*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneAttributes_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_GetZoneAttributes_Proxy(ref IInternetZoneManager This, uint dwZone, ref ZONEATTRIBUTES pZoneAttributes);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneActionPolicy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_GetZoneActionPolicy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwZone: DWORD->unsigned int
        ///dwAction: DWORD->unsigned int
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///urlZoneReg: URLZONEREG->_URLZONEREG
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_GetZoneActionPolicy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_GetZoneActionPolicy_Proxy(ref IInternetZoneManager This, uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_DestroyZoneEnumerator_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_DestroyZoneEnumerator_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwEnum: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_DestroyZoneEnumerator_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_DestroyZoneEnumerator_Proxy(ref IInternetZoneManager This, uint dwEnum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_CreateZoneEnumerator_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_CreateZoneEnumerator_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///pdwEnum: DWORD*
        ///pdwCount: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_CreateZoneEnumerator_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_CreateZoneEnumerator_Proxy(ref IInternetZoneManager This, ref uint pdwEnum, ref uint pdwCount, uint dwFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_CopyTemplatePoliciesToZone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManager_CopyTemplatePoliciesToZone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManager*
        ///dwTemplate: DWORD->unsigned int
        ///dwZone: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManager_CopyTemplatePoliciesToZone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManager_CopyTemplatePoliciesToZone_Proxy(ref IInternetZoneManager This, uint dwTemplate, uint dwZone, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManagerEx_SetZoneActionPolicyEx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManagerEx_SetZoneActionPolicyEx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManagerEx*
        ///dwZone: DWORD->unsigned int
        ///dwAction: DWORD->unsigned int
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///urlZoneReg: URLZONEREG->_URLZONEREG
        ///dwFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManagerEx_SetZoneActionPolicyEx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManagerEx_SetZoneActionPolicyEx_Proxy(ref IInternetZoneManagerEx This, uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg, uint dwFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManagerEx_GetZoneActionPolicyEx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetZoneManagerEx_GetZoneActionPolicyEx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetZoneManagerEx*
        ///dwZone: DWORD->unsigned int
        ///dwAction: DWORD->unsigned int
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///urlZoneReg: URLZONEREG->_URLZONEREG
        ///dwFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetZoneManagerEx_GetZoneActionPolicyEx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetZoneManagerEx_GetZoneActionPolicyEx_Proxy(ref IInternetZoneManagerEx This, uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg, uint dwFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetThreadSwitch_Prepare_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetThreadSwitch_Prepare_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetThreadSwitch*
        [DllImport("<Unknown>", EntryPoint = "IInternetThreadSwitch_Prepare_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetThreadSwitch_Prepare_Proxy(ref IInternetThreadSwitch This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetThreadSwitch_Continue_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetThreadSwitch_Continue_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetThreadSwitch*
        [DllImport("<Unknown>", EntryPoint = "IInternetThreadSwitch_Continue_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetThreadSwitch_Continue_Proxy(ref IInternetThreadSwitch This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_UnregisterNameSpace_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSession_UnregisterNameSpace_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSession*
        ///pCF: IClassFactory*
        ///pszProtocol: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_UnregisterNameSpace_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSession_UnregisterNameSpace_Proxy(ref IInternetSession This, ref IClassFactory pCF, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszProtocol);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_UnregisterMimeFilter_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSession_UnregisterMimeFilter_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSession*
        ///pCF: IClassFactory*
        ///pwzType: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_UnregisterMimeFilter_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSession_UnregisterMimeFilter_Proxy(ref IInternetSession This, ref IClassFactory pCF, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_SetSessionOption_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSession_SetSessionOption_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSession*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: LPVOID->void*
        ///dwBufferLength: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_SetSessionOption_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSession_SetSessionOption_Proxy(ref IInternetSession This, uint dwOption, IntPtr pBuffer, uint dwBufferLength, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_RegisterNameSpace_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSession_RegisterNameSpace_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSession*
        ///pCF: IClassFactory*
        ///rclsid: IID*
        ///pwzProtocol: LPCWSTR->WCHAR*
        ///cPatterns: ULONG->unsigned int
        ///ppwzPatterns: LPCWSTR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_RegisterNameSpace_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSession_RegisterNameSpace_Proxy(ref IInternetSession This, ref IClassFactory pCF, ref GUID rclsid, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzProtocol, uint cPatterns, ref IntPtr ppwzPatterns, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_RegisterMimeFilter_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSession_RegisterMimeFilter_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSession*
        ///pCF: IClassFactory*
        ///rclsid: IID*
        ///pwzType: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_RegisterMimeFilter_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSession_RegisterMimeFilter_Proxy(ref IInternetSession This, ref IClassFactory pCF, ref GUID rclsid, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_GetSessionOption_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSession_GetSessionOption_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSession*
        ///dwOption: DWORD->unsigned int
        ///pBuffer: LPVOID->void*
        ///pdwBufferLength: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_GetSessionOption_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSession_GetSessionOption_Proxy(ref IInternetSession This, uint dwOption, IntPtr pBuffer, ref uint pdwBufferLength, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_CreateBinding_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSession_CreateBinding_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSession*
        ///pBC: LPBC->IBindCtx*
        ///szUrl: LPCWSTR->WCHAR*
        ///pUnkOuter: IUnknown*
        ///ppUnk: IUnknown**
        ///ppOInetProt: IInternetProtocol**
        ///dwOption: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSession_CreateBinding_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSession_CreateBinding_Proxy(ref IInternetSession This, ref IBindCtx pBC, [In] [MarshalAs(UnmanagedType.LPWStr)] string szUrl, ref IUnknown pUnkOuter, ref IntPtr ppUnk, ref IntPtr ppOInetProt, uint dwOption);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityMgrSite_GetWindow_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityMgrSite_GetWindow_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityMgrSite*
        ///phwnd: HWND*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityMgrSite_GetWindow_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityMgrSite_GetWindow_Proxy(ref IInternetSecurityMgrSite This, ref IntPtr phwnd);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityMgrSite_EnableModeless_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityMgrSite_EnableModeless_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityMgrSite*
        ///fEnable: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityMgrSite_EnableModeless_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityMgrSite_EnableModeless_Proxy(ref IInternetSecurityMgrSite This, [MarshalAs(UnmanagedType.Bool)] bool fEnable);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_SetZoneMapping_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_SetZoneMapping_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///dwZone: DWORD->unsigned int
        ///lpszPattern: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_SetZoneMapping_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_SetZoneMapping_Proxy(ref IInternetSecurityManager This, uint dwZone, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszPattern, uint dwFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_SetSecuritySite_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_SetSecuritySite_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///pSite: IInternetSecurityMgrSite*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_SetSecuritySite_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_SetSecuritySite_Proxy(ref IInternetSecurityManager This, ref IInternetSecurityMgrSite pSite);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_QueryCustomPolicy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_QueryCustomPolicy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///pwszUrl: LPCWSTR->WCHAR*
        ///guidKey: GUID*
        ///ppPolicy: BYTE**
        ///pcbPolicy: DWORD*
        ///pContext: BYTE*
        ///cbContext: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_QueryCustomPolicy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_QueryCustomPolicy_Proxy(ref IInternetSecurityManager This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, ref GUID guidKey, ref IntPtr ppPolicy, ref uint pcbPolicy, ref byte pContext, uint cbContext, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_ProcessUrlAction_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_ProcessUrlAction_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///pwszUrl: LPCWSTR->WCHAR*
        ///dwAction: DWORD->unsigned int
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///pContext: BYTE*
        ///cbContext: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_ProcessUrlAction_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_ProcessUrlAction_Proxy(ref IInternetSecurityManager This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, uint dwAction, ref byte pPolicy, uint cbPolicy, ref byte pContext, uint cbContext, uint dwFlags, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_MapUrlToZone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_MapUrlToZone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///pwszUrl: LPCWSTR->WCHAR*
        ///pdwZone: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_MapUrlToZone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_MapUrlToZone_Proxy(ref IInternetSecurityManager This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, ref uint pdwZone, uint dwFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_GetZoneMappings_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_GetZoneMappings_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///dwZone: DWORD->unsigned int
        ///ppenumString: IEnumString**
        ///dwFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_GetZoneMappings_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_GetZoneMappings_Proxy(ref IInternetSecurityManager This, uint dwZone, ref IntPtr ppenumString, uint dwFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_GetSecuritySite_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_GetSecuritySite_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///ppSite: IInternetSecurityMgrSite**
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_GetSecuritySite_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_GetSecuritySite_Proxy(ref IInternetSecurityManager This, ref IntPtr ppSite);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_GetSecurityId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManager_GetSecurityId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManager*
        ///pwszUrl: LPCWSTR->WCHAR*
        ///pbSecurityId: BYTE*
        ///pcbSecurityId: DWORD*
        ///dwReserved: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManager_GetSecurityId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManager_GetSecurityId_Proxy(ref IInternetSecurityManager This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, ref byte pbSecurityId, ref uint pcbSecurityId, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManagerEx_ProcessUrlActionEx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetSecurityManagerEx_ProcessUrlActionEx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetSecurityManagerEx*
        ///pwszUrl: LPCWSTR->WCHAR*
        ///dwAction: DWORD->unsigned int
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///pContext: BYTE*
        ///cbContext: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        ///pdwOutFlags: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetSecurityManagerEx_ProcessUrlActionEx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetSecurityManagerEx_ProcessUrlActionEx_Proxy(ref IInternetSecurityManagerEx This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, uint dwAction, ref byte pPolicy, uint cbPolicy, ref byte pContext, uint cbContext, uint dwFlags, uint dwReserved, ref uint pdwOutFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_UnlockRequest_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocol_UnlockRequest_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocol*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_UnlockRequest_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocol_UnlockRequest_Proxy(ref IInternetProtocol This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_Seek_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocol_Seek_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocol*
        ///dlibMove: LARGE_INTEGER->_LARGE_INTEGER
        ///dwOrigin: DWORD->unsigned int
        ///plibNewPosition: ULARGE_INTEGER*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_Seek_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocol_Seek_Proxy(ref IInternetProtocol This, LARGE_INTEGER dlibMove, uint dwOrigin, ref ULARGE_INTEGER plibNewPosition);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_Read_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocol_Read_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocol*
        ///pv: void*
        ///cb: ULONG->unsigned int
        ///pcbRead: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_Read_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocol_Read_Proxy(ref IInternetProtocol This, IntPtr pv, uint cb, ref uint pcbRead);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_LockRequest_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocol_LockRequest_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocol*
        ///dwOptions: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocol_LockRequest_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocol_LockRequest_Proxy(ref IInternetProtocol This, uint dwOptions);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_Switch_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolSink_Switch_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolSink*
        ///pProtocolData: PROTOCOLDATA*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_Switch_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolSink_Switch_Proxy(ref IInternetProtocolSink This, ref PROTOCOLDATA pProtocolData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_ReportResult_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolSink_ReportResult_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolSink*
        ///hrResult: HRESULT->LONG->int
        ///dwError: DWORD->unsigned int
        ///szResult: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_ReportResult_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolSink_ReportResult_Proxy(ref IInternetProtocolSink This, int hrResult, uint dwError, [In] [MarshalAs(UnmanagedType.LPWStr)] string szResult);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_ReportProgress_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolSink_ReportProgress_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolSink*
        ///ulStatusCode: ULONG->unsigned int
        ///szStatusText: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_ReportProgress_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolSink_ReportProgress_Proxy(ref IInternetProtocolSink This, uint ulStatusCode, [In] [MarshalAs(UnmanagedType.LPWStr)] string szStatusText);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_ReportData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolSink_ReportData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolSink*
        ///grfBSCF: DWORD->unsigned int
        ///ulProgress: ULONG->unsigned int
        ///ulProgressMax: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSink_ReportData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolSink_ReportData_Proxy(ref IInternetProtocolSink This, uint grfBSCF, uint ulProgress, uint ulProgressMax);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSinkStackable_SwitchSink_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolSinkStackable_SwitchSink_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolSinkStackable*
        ///pOIProtSink: IInternetProtocolSink*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSinkStackable_SwitchSink_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolSinkStackable_SwitchSink_Proxy(ref IInternetProtocolSinkStackable This, ref IInternetProtocolSink pOIProtSink);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSinkStackable_RollbackSwitch_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolSinkStackable_RollbackSwitch_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolSinkStackable*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSinkStackable_RollbackSwitch_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolSinkStackable_RollbackSwitch_Proxy(ref IInternetProtocolSinkStackable This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSinkStackable_CommitSwitch_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolSinkStackable_CommitSwitch_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolSinkStackable*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolSinkStackable_CommitSwitch_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolSinkStackable_CommitSwitch_Proxy(ref IInternetProtocolSinkStackable This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Terminate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolRoot_Terminate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolRoot*
        ///dwOptions: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Terminate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolRoot_Terminate_Proxy(ref IInternetProtocolRoot This, uint dwOptions);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Suspend_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolRoot_Suspend_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolRoot*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Suspend_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolRoot_Suspend_Proxy(ref IInternetProtocolRoot This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Start_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolRoot_Start_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolRoot*
        ///szUrl: LPCWSTR->WCHAR*
        ///pOIProtSink: IInternetProtocolSink*
        ///pOIBindInfo: IInternetBindInfo*
        ///grfPI: DWORD->unsigned int
        ///dwReserved: HANDLE_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Start_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolRoot_Start_Proxy(ref IInternetProtocolRoot This, [In] [MarshalAs(UnmanagedType.LPWStr)] string szUrl, ref IInternetProtocolSink pOIProtSink, ref IInternetBindInfo pOIBindInfo, uint grfPI, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Resume_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolRoot_Resume_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolRoot*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Resume_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolRoot_Resume_Proxy(ref IInternetProtocolRoot This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Continue_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolRoot_Continue_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolRoot*
        ///pProtocolData: PROTOCOLDATA*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Continue_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolRoot_Continue_Proxy(ref IInternetProtocolRoot This, ref PROTOCOLDATA pProtocolData);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Abort_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolRoot_Abort_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolRoot*
        ///hrReason: HRESULT->LONG->int
        ///dwOptions: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolRoot_Abort_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolRoot_Abort_Proxy(ref IInternetProtocolRoot This, int hrReason, uint dwOptions);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_QueryInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolInfo_QueryInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolInfo*
        ///pwzUrl: LPCWSTR->WCHAR*
        ///OueryOption: QUERYOPTION->_tagQUERYOPTION
        ///dwQueryFlags: DWORD->unsigned int
        ///pBuffer: LPVOID->void*
        ///cbBuffer: DWORD->unsigned int
        ///pcbBuf: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_QueryInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolInfo_QueryInfo_Proxy(ref IInternetProtocolInfo This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, QUERYOPTION OueryOption, uint dwQueryFlags, IntPtr pBuffer, uint cbBuffer, ref uint pcbBuf, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_ParseUrl_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolInfo_ParseUrl_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolInfo*
        ///pwzUrl: LPCWSTR->WCHAR*
        ///ParseAction: PARSEACTION->_tagPARSEACTION
        ///dwParseFlags: DWORD->unsigned int
        ///pwzResult: LPWSTR->WCHAR*
        ///cchResult: DWORD->unsigned int
        ///pcchResult: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_ParseUrl_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolInfo_ParseUrl_Proxy(ref IInternetProtocolInfo This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, PARSEACTION ParseAction, uint dwParseFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pwzResult, uint cchResult, ref uint pcchResult, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_CompareUrl_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolInfo_CompareUrl_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolInfo*
        ///pwzUrl1: LPCWSTR->WCHAR*
        ///pwzUrl2: LPCWSTR->WCHAR*
        ///dwCompareFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_CompareUrl_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolInfo_CompareUrl_Proxy(ref IInternetProtocolInfo This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl1, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl2, uint dwCompareFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_CombineUrl_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetProtocolInfo_CombineUrl_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetProtocolInfo*
        ///pwzBaseUrl: LPCWSTR->WCHAR*
        ///pwzRelativeUrl: LPCWSTR->WCHAR*
        ///dwCombineFlags: DWORD->unsigned int
        ///pwzResult: LPWSTR->WCHAR*
        ///cchResult: DWORD->unsigned int
        ///pcchResult: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetProtocolInfo_CombineUrl_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetProtocolInfo_CombineUrl_Proxy(ref IInternetProtocolInfo This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzBaseUrl, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzRelativeUrl, uint dwCombineFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pwzResult, uint cchResult, ref uint pcchResult, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetPriority_SetPriority_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetPriority_SetPriority_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetPriority*
        ///nPriority: LONG->int
        [DllImport("<Unknown>", EntryPoint = "IInternetPriority_SetPriority_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetPriority_SetPriority_Proxy(ref IInternetPriority This, int nPriority);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetPriority_GetPriority_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetPriority_GetPriority_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetPriority*
        ///pnPriority: LONG*
        [DllImport("<Unknown>", EntryPoint = "IInternetPriority_GetPriority_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetPriority_GetPriority_Proxy(ref IInternetPriority This, ref int pnPriority);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetHostSecurityManager_QueryCustomPolicy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetHostSecurityManager_QueryCustomPolicy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetHostSecurityManager*
        ///guidKey: GUID*
        ///ppPolicy: BYTE**
        ///pcbPolicy: DWORD*
        ///pContext: BYTE*
        ///cbContext: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetHostSecurityManager_QueryCustomPolicy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetHostSecurityManager_QueryCustomPolicy_Proxy(ref IInternetHostSecurityManager This, ref GUID guidKey, ref IntPtr ppPolicy, ref uint pcbPolicy, ref byte pContext, uint cbContext, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetHostSecurityManager_ProcessUrlAction_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetHostSecurityManager_ProcessUrlAction_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetHostSecurityManager*
        ///dwAction: DWORD->unsigned int
        ///pPolicy: BYTE*
        ///cbPolicy: DWORD->unsigned int
        ///pContext: BYTE*
        ///cbContext: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetHostSecurityManager_ProcessUrlAction_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetHostSecurityManager_ProcessUrlAction_Proxy(ref IInternetHostSecurityManager This, uint dwAction, ref byte pPolicy, uint cbPolicy, ref byte pContext, uint cbContext, uint dwFlags, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetHostSecurityManager_GetSecurityId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetHostSecurityManager_GetSecurityId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetHostSecurityManager*
        ///pbSecurityId: BYTE*
        ///pcbSecurityId: DWORD*
        ///dwReserved: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInternetHostSecurityManager_GetSecurityId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetHostSecurityManager_GetSecurityId_Proxy(ref IInternetHostSecurityManager This, ref byte pbSecurityId, ref uint pcbSecurityId, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetBindInfo_GetBindString_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetBindInfo_GetBindString_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetBindInfo*
        ///ulStringType: ULONG->unsigned int
        ///ppwzStr: LPOLESTR*
        ///cEl: ULONG->unsigned int
        ///pcElFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IInternetBindInfo_GetBindString_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetBindInfo_GetBindString_Proxy(ref IInternetBindInfo This, uint ulStringType, ref IntPtr ppwzStr, uint cEl, ref uint pcElFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternetBindInfo_GetBindInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternetBindInfo_GetBindInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternetBindInfo*
        ///grfBINDF: DWORD*
        ///pbindinfo: BINDINFO*
        [DllImport("<Unknown>", EntryPoint = "IInternetBindInfo_GetBindInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternetBindInfo_GetBindInfo_Proxy(ref IInternetBindInfo This, ref uint grfBINDF, ref BINDINFO pbindinfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInternalUnknown_QueryInternalInterface_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInternalUnknown_QueryInternalInterface_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInternalUnknown*
        ///riid: IID*
        ///ppv: void**
        [DllImport("<Unknown>", EntryPoint = "IInternalUnknown_QueryInternalInterface_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInternalUnknown_QueryInternalInterface_Proxy(ref IInternalUnknown This, ref GUID riid, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PreUninitialize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInitializeSpy_PreUninitialize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInitializeSpy*
        ///dwCurThreadAptRefs: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PreUninitialize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInitializeSpy_PreUninitialize_Proxy(ref IInitializeSpy This, uint dwCurThreadAptRefs);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PreInitialize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInitializeSpy_PreInitialize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInitializeSpy*
        ///dwCoInit: DWORD->unsigned int
        ///dwCurThreadAptRefs: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PreInitialize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInitializeSpy_PreInitialize_Proxy(ref IInitializeSpy This, uint dwCoInit, uint dwCurThreadAptRefs);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PostUninitialize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInitializeSpy_PostUninitialize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInitializeSpy*
        ///dwNewThreadAptRefs: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PostUninitialize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInitializeSpy_PostUninitialize_Proxy(ref IInitializeSpy This, uint dwNewThreadAptRefs);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PostInitialize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IInitializeSpy_PostInitialize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IInitializeSpy*
        ///hrCoInit: HRESULT->LONG->int
        ///dwCoInit: DWORD->unsigned int
        ///dwNewThreadAptRefs: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IInitializeSpy_PostInitialize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IInitializeSpy_PostInitialize_Proxy(ref IInitializeSpy This, int hrCoInit, uint dwCoInit, uint dwNewThreadAptRefs);


        /// Return Type: HRESULT->LONG->int
        ///lpsz: LPOLESTR->OLECHAR*
        ///lpiid: LPIID->IID*
        [DllImport("ole32.dll", EntryPoint = "IIDFromString", CallingConvention = CallingConvention.StdCall)]
        public static extern int IIDFromString(IntPtr lpsz, ref GUID lpiid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IHttpSecurity_OnSecurityProblem_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IHttpSecurity_OnSecurityProblem_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IHttpSecurity*
        ///dwProblem: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IHttpSecurity_OnSecurityProblem_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IHttpSecurity_OnSecurityProblem_Proxy(ref IHttpSecurity This, uint dwProblem);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IHttpNegotiate_OnResponse_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IHttpNegotiate_OnResponse_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IHttpNegotiate*
        ///dwResponseCode: DWORD->unsigned int
        ///szResponseHeaders: LPCWSTR->WCHAR*
        ///szRequestHeaders: LPCWSTR->WCHAR*
        ///pszAdditionalRequestHeaders: LPWSTR*
        [DllImport("<Unknown>", EntryPoint = "IHttpNegotiate_OnResponse_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IHttpNegotiate_OnResponse_Proxy(ref IHttpNegotiate This, uint dwResponseCode, [In] [MarshalAs(UnmanagedType.LPWStr)] string szResponseHeaders, [In] [MarshalAs(UnmanagedType.LPWStr)] string szRequestHeaders, ref IntPtr pszAdditionalRequestHeaders);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IHttpNegotiate_BeginningTransaction_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IHttpNegotiate_BeginningTransaction_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IHttpNegotiate*
        ///szURL: LPCWSTR->WCHAR*
        ///szHeaders: LPCWSTR->WCHAR*
        ///dwReserved: DWORD->unsigned int
        ///pszAdditionalHeaders: LPWSTR*
        [DllImport("<Unknown>", EntryPoint = "IHttpNegotiate_BeginningTransaction_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IHttpNegotiate_BeginningTransaction_Proxy(ref IHttpNegotiate This, [In] [MarshalAs(UnmanagedType.LPWStr)] string szURL, [In] [MarshalAs(UnmanagedType.LPWStr)] string szHeaders, uint dwReserved, ref IntPtr pszAdditionalHeaders);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IHttpNegotiate2_GetRootSecurityId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IHttpNegotiate2_GetRootSecurityId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IHttpNegotiate2*
        ///pbSecurityId: BYTE*
        ///pcbSecurityId: DWORD*
        ///dwReserved: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IHttpNegotiate2_GetRootSecurityId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IHttpNegotiate2_GetRootSecurityId_Proxy(ref IHttpNegotiate2 This, ref byte pbSecurityId, ref uint pcbSecurityId, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IGlobalInterfaceTable_RevokeInterfaceFromGlobal_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IGlobalInterfaceTable_RevokeInterfaceFromGlobal_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IGlobalInterfaceTable*
        ///dwCookie: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IGlobalInterfaceTable_RevokeInterfaceFromGlobal_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IGlobalInterfaceTable_RevokeInterfaceFromGlobal_Proxy(ref IGlobalInterfaceTable This, uint dwCookie);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IGlobalInterfaceTable_RegisterInterfaceInGlobal_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IGlobalInterfaceTable_RegisterInterfaceInGlobal_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IGlobalInterfaceTable*
        ///pUnk: IUnknown*
        ///riid: IID*
        ///pdwCookie: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IGlobalInterfaceTable_RegisterInterfaceInGlobal_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IGlobalInterfaceTable_RegisterInterfaceInGlobal_Proxy(ref IGlobalInterfaceTable This, ref IUnknown pUnk, ref GUID riid, ref uint pdwCookie);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IGlobalInterfaceTable_GetInterfaceFromGlobal_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IGlobalInterfaceTable_GetInterfaceFromGlobal_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IGlobalInterfaceTable*
        ///dwCookie: DWORD->unsigned int
        ///riid: IID*
        ///ppv: void**
        [DllImport("<Unknown>", EntryPoint = "IGlobalInterfaceTable_GetInterfaceFromGlobal_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IGlobalInterfaceTable_GetInterfaceFromGlobal_Proxy(ref IGlobalInterfaceTable This, uint dwCookie, ref GUID riid, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IForegroundTransfer_AllowForegroundTransfer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IForegroundTransfer_AllowForegroundTransfer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IForegroundTransfer*
        ///lpvReserved: void*
        [DllImport("<Unknown>", EntryPoint = "IForegroundTransfer_AllowForegroundTransfer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IForegroundTransfer_AllowForegroundTransfer_Proxy(ref IForegroundTransfer This, IntPtr lpvReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_Terminate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IFillLockBytes_Terminate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///bCanceled: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_Terminate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_Terminate_Proxy(ref IFillLockBytes This, [MarshalAs(UnmanagedType.Bool)] bool bCanceled);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_SetFillSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IFillLockBytes_SetFillSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///ulSize: ULARGE_INTEGER->_ULARGE_INTEGER
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_SetFillSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_SetFillSize_Proxy(ref IFillLockBytes This, ULARGE_INTEGER ulSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_RemoteFillAt_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IFillLockBytes_RemoteFillAt_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_RemoteFillAt_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_RemoteFillAt_Proxy(ref IFillLockBytes This, ULARGE_INTEGER ulOffset, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_RemoteFillAppend_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IFillLockBytes_RemoteFillAppend_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_RemoteFillAppend_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_RemoteFillAppend_Proxy(ref IFillLockBytes This, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_FillAt_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_FillAt_Stub(ref IFillLockBytes This, ULARGE_INTEGER ulOffset, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///ulOffset: ULARGE_INTEGER->_ULARGE_INTEGER
        ///pv: void*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_FillAt_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_FillAt_Proxy(ref IFillLockBytes This, ULARGE_INTEGER ulOffset, IntPtr pv, uint cb, ref uint pcbWritten);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///pv: byte*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_FillAppend_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_FillAppend_Stub(ref IFillLockBytes This, ref byte pv, uint cb, ref uint pcbWritten);


        /// Return Type: HRESULT->LONG->int
        ///This: IFillLockBytes*
        ///pv: void*
        ///cb: ULONG->unsigned int
        ///pcbWritten: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IFillLockBytes_FillAppend_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IFillLockBytes_FillAppend_Proxy(ref IFillLockBytes This, IntPtr pv, uint cb, ref uint pcbWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IExternalConnection_ReleaseConnection_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IExternalConnection_ReleaseConnection_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: DWORD->unsigned int
        ///This: IExternalConnection*
        ///extconn: DWORD->unsigned int
        ///reserved: DWORD->unsigned int
        ///fLastReleaseCloses: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IExternalConnection_ReleaseConnection_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IExternalConnection_ReleaseConnection_Proxy(ref IExternalConnection This, uint extconn, uint reserved, [MarshalAs(UnmanagedType.Bool)] bool fLastReleaseCloses);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IExternalConnection_AddConnection_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IExternalConnection_AddConnection_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: DWORD->unsigned int
        ///This: IExternalConnection*
        ///extconn: DWORD->unsigned int
        ///reserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IExternalConnection_AddConnection_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint IExternalConnection_AddConnection_Proxy(ref IExternalConnection This, uint extconn, uint reserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IErrorLog_AddError_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IErrorLog_AddError_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IErrorLog*
        ///pszPropName: LPCOLESTR->OLECHAR*
        ///pExcepInfo: EXCEPINFO*
        [DllImport("<Unknown>", EntryPoint = "IErrorLog_AddError_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IErrorLog_AddError_Proxy(ref IErrorLog This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPropName, ref tagEXCEPINFO pExcepInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetSource_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IErrorInfo_GetSource_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IErrorInfo*
        ///pBstrSource: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetSource_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IErrorInfo_GetSource_Proxy(ref IErrorInfo This, [MarshalAs(UnmanagedType.BStr)] ref string pBstrSource);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetHelpFile_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IErrorInfo_GetHelpFile_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IErrorInfo*
        ///pBstrHelpFile: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetHelpFile_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IErrorInfo_GetHelpFile_Proxy(ref IErrorInfo This, [MarshalAs(UnmanagedType.BStr)] ref string pBstrHelpFile);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetHelpContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IErrorInfo_GetHelpContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IErrorInfo*
        ///pdwHelpContext: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetHelpContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IErrorInfo_GetHelpContext_Proxy(ref IErrorInfo This, ref uint pdwHelpContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetGUID_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IErrorInfo_GetGUID_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IErrorInfo*
        ///pGUID: GUID*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetGUID_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IErrorInfo_GetGUID_Proxy(ref IErrorInfo This, ref GUID pGUID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetDescription_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IErrorInfo_GetDescription_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IErrorInfo*
        ///pBstrDescription: BSTR*
        [DllImport("<Unknown>", EntryPoint = "IErrorInfo_GetDescription_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IErrorInfo_GetDescription_Proxy(ref IErrorInfo This, [MarshalAs(UnmanagedType.BStr)] ref string pBstrDescription);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumVARIANT_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumVARIANT*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumVARIANT_Skip_Proxy(ref IEnumVARIANT This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumVARIANT_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumVARIANT*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumVARIANT_Reset_Proxy(ref IEnumVARIANT This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumVARIANT_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumVARIANT*
        ///celt: ULONG->unsigned int
        ///rgVar: VARIANT*
        ///pCeltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumVARIANT_RemoteNext_Proxy(ref IEnumVARIANT This, uint celt, ref tagVARIANT rgVar, ref uint pCeltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumVARIANT*
        ///celt: ULONG->unsigned int
        ///rgVar: VARIANT*
        ///pCeltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumVARIANT_Next_Stub(ref IEnumVARIANT This, uint celt, ref tagVARIANT rgVar, ref uint pCeltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumVARIANT*
        ///celt: ULONG->unsigned int
        ///rgVar: VARIANT*
        ///pCeltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumVARIANT_Next_Proxy(ref IEnumVARIANT This, uint celt, ref tagVARIANT rgVar, ref uint pCeltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumVARIANT_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumVARIANT*
        ///ppEnum: IEnumVARIANT**
        [DllImport("<Unknown>", EntryPoint = "IEnumVARIANT_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumVARIANT_Clone_Proxy(ref IEnumVARIANT This, ref IntPtr ppEnum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumUnknown_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumUnknown*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumUnknown_Skip_Proxy(ref IEnumUnknown This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumUnknown_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumUnknown*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumUnknown_Reset_Proxy(ref IEnumUnknown This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumUnknown_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumUnknown*
        ///celt: ULONG->unsigned int
        ///rgelt: IUnknown**
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumUnknown_RemoteNext_Proxy(ref IEnumUnknown This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumUnknown*
        ///celt: ULONG->unsigned int
        ///rgelt: IUnknown**
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumUnknown_Next_Stub(ref IEnumUnknown This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumUnknown*
        ///celt: ULONG->unsigned int
        ///rgelt: IUnknown**
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumUnknown_Next_Proxy(ref IEnumUnknown This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumUnknown_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumUnknown*
        ///ppenum: IEnumUnknown**
        [DllImport("<Unknown>", EntryPoint = "IEnumUnknown_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumUnknown_Clone_Proxy(ref IEnumUnknown This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumString_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumString*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumString_Skip_Proxy(ref IEnumString This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumString_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumString*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumString_Reset_Proxy(ref IEnumString This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumString_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumString*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLESTR*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumString_RemoteNext_Proxy(ref IEnumString This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumString*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLESTR*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumString_Next_Stub(ref IEnumString This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumString*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLESTR*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumString_Next_Proxy(ref IEnumString This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumString_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumString*
        ///ppenum: IEnumString**
        [DllImport("<Unknown>", EntryPoint = "IEnumString_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumString_Clone_Proxy(ref IEnumString This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATSTG_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATSTG*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATSTG_Skip_Proxy(ref IEnumSTATSTG This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATSTG_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATSTG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATSTG_Reset_Proxy(ref IEnumSTATSTG This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATSTG_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATSTG_RemoteNext_Proxy(ref IEnumSTATSTG This, uint celt, ref tagSTATSTG rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATSTG_Next_Stub(ref IEnumSTATSTG This, uint celt, ref tagSTATSTG rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATSTG_Next_Proxy(ref IEnumSTATSTG This, uint celt, ref tagSTATSTG rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATSTG_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATSTG*
        ///ppenum: IEnumSTATSTG**
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATSTG_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATSTG_Clone_Proxy(ref IEnumSTATSTG This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSTG_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSTG*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSTG_Skip_Proxy(ref IEnumSTATPROPSTG This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSTG_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSTG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSTG_Reset_Proxy(ref IEnumSTATPROPSTG This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSTG_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATPROPSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSTG_RemoteNext_Proxy(ref IEnumSTATPROPSTG This, uint celt, ref tagSTATPROPSTG rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATPROPSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSTG_Next_Stub(ref IEnumSTATPROPSTG This, uint celt, ref tagSTATPROPSTG rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATPROPSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSTG_Next_Proxy(ref IEnumSTATPROPSTG This, uint celt, ref tagSTATPROPSTG rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSTG_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSTG*
        ///ppenum: IEnumSTATPROPSTG**
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSTG_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSTG_Clone_Proxy(ref IEnumSTATPROPSTG This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSETSTG_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSETSTG*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSETSTG_Skip_Proxy(ref IEnumSTATPROPSETSTG This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSETSTG_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSETSTG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSETSTG_Reset_Proxy(ref IEnumSTATPROPSETSTG This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSETSTG_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSETSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATPROPSETSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSETSTG_RemoteNext_Proxy(ref IEnumSTATPROPSETSTG This, uint celt, ref tagSTATPROPSETSTG rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSETSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATPROPSETSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSETSTG_Next_Stub(ref IEnumSTATPROPSETSTG This, uint celt, ref tagSTATPROPSETSTG rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSETSTG*
        ///celt: ULONG->unsigned int
        ///rgelt: STATPROPSETSTG*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSETSTG_Next_Proxy(ref IEnumSTATPROPSETSTG This, uint celt, ref tagSTATPROPSETSTG rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATPROPSETSTG_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATPROPSETSTG*
        ///ppenum: IEnumSTATPROPSETSTG**
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATPROPSETSTG_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATPROPSETSTG_Clone_Proxy(ref IEnumSTATPROPSETSTG This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATDATA_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATDATA*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATDATA_Skip_Proxy(ref IEnumSTATDATA This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATDATA_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATDATA*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATDATA_Reset_Proxy(ref IEnumSTATDATA This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATDATA_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATDATA*
        ///celt: ULONG->unsigned int
        ///rgelt: STATDATA*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATDATA_RemoteNext_Proxy(ref IEnumSTATDATA This, uint celt, ref tagSTATDATA rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATDATA*
        ///celt: ULONG->unsigned int
        ///rgelt: STATDATA*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATDATA_Next_Stub(ref IEnumSTATDATA This, uint celt, ref tagSTATDATA rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATDATA*
        ///celt: ULONG->unsigned int
        ///rgelt: STATDATA*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATDATA_Next_Proxy(ref IEnumSTATDATA This, uint celt, ref tagSTATDATA rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumSTATDATA_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumSTATDATA*
        ///ppenum: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IEnumSTATDATA_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumSTATDATA_Clone_Proxy(ref IEnumSTATDATA This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Skip_Proxy(ref IEnumOLEVERB This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Reset_Proxy(ref IEnumOLEVERB This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLEVERB->tagOLEVERB*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_RemoteNext_Proxy(ref IEnumOLEVERB This, uint celt, ref tagOLEVERB rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLEVERB->tagOLEVERB*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Next_Stub(ref IEnumOLEVERB This, uint celt, ref tagOLEVERB rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLEVERB->tagOLEVERB*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Next_Proxy(ref IEnumOLEVERB This, uint celt, ref tagOLEVERB rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///ppenum: IEnumOLEVERB**
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Clone_Proxy(ref IEnumOLEVERB This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumMoniker_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumMoniker*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumMoniker_Skip_Proxy(ref IEnumMoniker This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumMoniker_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumMoniker*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumMoniker_Reset_Proxy(ref IEnumMoniker This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumMoniker_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumMoniker*
        ///celt: ULONG->unsigned int
        ///rgelt: IMoniker**
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumMoniker_RemoteNext_Proxy(ref IEnumMoniker This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumMoniker*
        ///celt: ULONG->unsigned int
        ///rgelt: IMoniker**
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumMoniker_Next_Stub(ref IEnumMoniker This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumMoniker*
        ///celt: ULONG->unsigned int
        ///rgelt: IMoniker**
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumMoniker_Next_Proxy(ref IEnumMoniker This, uint celt, ref IntPtr rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumMoniker_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumMoniker*
        ///ppenum: IEnumMoniker**
        [DllImport("<Unknown>", EntryPoint = "IEnumMoniker_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumMoniker_Clone_Proxy(ref IEnumMoniker This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Skip_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumFORMATETC_Skip_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumFORMATETC*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Skip_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumFORMATETC_Skip_Proxy(ref IEnumFORMATETC This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Reset_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumFORMATETC_Reset_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumFORMATETC*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Reset_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumFORMATETC_Reset_Proxy(ref IEnumFORMATETC This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_RemoteNext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumFORMATETC_RemoteNext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumFORMATETC*
        ///celt: ULONG->unsigned int
        ///rgelt: FORMATETC*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_RemoteNext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumFORMATETC_RemoteNext_Proxy(ref IEnumFORMATETC This, uint celt, ref tagFORMATETC rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumFORMATETC*
        ///celt: ULONG->unsigned int
        ///rgelt: FORMATETC*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Next_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumFORMATETC_Next_Stub(ref IEnumFORMATETC This, uint celt, ref tagFORMATETC rgelt, ref uint pceltFetched);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumFORMATETC*
        ///celt: ULONG->unsigned int
        ///rgelt: FORMATETC*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Next_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumFORMATETC_Next_Proxy(ref IEnumFORMATETC This, uint celt, ref tagFORMATETC rgelt, ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Clone_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumFORMATETC_Clone_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumFORMATETC*
        ///ppenum: IEnumFORMATETC**
        [DllImport("<Unknown>", EntryPoint = "IEnumFORMATETC_Clone_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumFORMATETC_Clone_Proxy(ref IEnumFORMATETC This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEncodingFilterFactory_GetDefaultFilter_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEncodingFilterFactory_GetDefaultFilter_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEncodingFilterFactory*
        ///pwzCodeIn: LPCWSTR->WCHAR*
        ///pwzCodeOut: LPCWSTR->WCHAR*
        ///ppDF: IDataFilter**
        [DllImport("<Unknown>", EntryPoint = "IEncodingFilterFactory_GetDefaultFilter_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEncodingFilterFactory_GetDefaultFilter_Proxy(ref IEncodingFilterFactory This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzCodeIn, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzCodeOut, ref IntPtr ppDF);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEncodingFilterFactory_FindBestFilter_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IEncodingFilterFactory_FindBestFilter_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEncodingFilterFactory*
        ///pwzCodeIn: LPCWSTR->WCHAR*
        ///pwzCodeOut: LPCWSTR->WCHAR*
        ///info: DATAINFO->_tagDATAINFO
        ///ppDF: IDataFilter**
        [DllImport("<Unknown>", EntryPoint = "IEncodingFilterFactory_FindBestFilter_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IEncodingFilterFactory_FindBestFilter_Proxy(ref IEncodingFilterFactory This, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzCodeIn, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzCodeOut, DATAINFO info, ref IntPtr ppDF);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDummyHICONIncluder_Dummy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDummyHICONIncluder_Dummy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDummyHICONIncluder*
        ///h1: HICON->HICON__*
        ///h2: HDC->HDC__*
        [DllImport("<Unknown>", EntryPoint = "IDummyHICONIncluder_Dummy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDummyHICONIncluder_Dummy_Proxy(ref IDummyHICONIncluder This, IntPtr h1, IntPtr h2);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_Drop_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDropTarget_Drop_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDropTarget*
        ///pDataObj: IDataObject*
        ///grfKeyState: DWORD->unsigned int
        ///pt: POINTL->_POINTL
        ///pdwEffect: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_Drop_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDropTarget_Drop_Proxy(ref IDropTarget This, ref IDataObject pDataObj, uint grfKeyState, POINTL pt, ref uint pdwEffect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_DragOver_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDropTarget_DragOver_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDropTarget*
        ///grfKeyState: DWORD->unsigned int
        ///pt: POINTL->_POINTL
        ///pdwEffect: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_DragOver_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDropTarget_DragOver_Proxy(ref IDropTarget This, uint grfKeyState, POINTL pt, ref uint pdwEffect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_DragLeave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDropTarget_DragLeave_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDropTarget*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_DragLeave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDropTarget_DragLeave_Proxy(ref IDropTarget This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_DragEnter_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDropTarget_DragEnter_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDropTarget*
        ///pDataObj: IDataObject*
        ///grfKeyState: DWORD->unsigned int
        ///pt: POINTL->_POINTL
        ///pdwEffect: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropTarget_DragEnter_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDropTarget_DragEnter_Proxy(ref IDropTarget This, ref IDataObject pDataObj, uint grfKeyState, POINTL pt, ref uint pdwEffect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropSource_QueryContinueDrag_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDropSource_QueryContinueDrag_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDropSource*
        ///fEscapePressed: BOOL->int
        ///grfKeyState: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDropSource_QueryContinueDrag_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDropSource_QueryContinueDrag_Proxy(ref IDropSource This, [MarshalAs(UnmanagedType.Bool)] bool fEscapePressed, uint grfKeyState);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDropSource_GiveFeedback_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDropSource_GiveFeedback_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDropSource*
        ///dwEffect: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDropSource_GiveFeedback_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDropSource_GiveFeedback_Proxy(ref IDropSource This, uint dwEffect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_RemoteInvoke_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDispatch_RemoteInvoke_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDispatch*
        ///dispIdMember: DISPID->LONG->int
        ///riid: IID*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pDispParams: DISPPARAMS*
        ///pVarResult: VARIANT*
        ///pExcepInfo: EXCEPINFO*
        ///pArgErr: UINT*
        ///cVarRef: UINT->unsigned int
        ///rgVarRefIdx: UINT*
        ///rgVarRef: VARIANTARG*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_RemoteInvoke_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDispatch_RemoteInvoke_Proxy(ref IDispatch This, int dispIdMember, ref GUID riid, uint lcid, uint dwFlags, ref tagDISPPARAMS pDispParams, ref tagVARIANT pVarResult, ref tagEXCEPINFO pExcepInfo, ref uint pArgErr, uint cVarRef, ref uint rgVarRefIdx, ref tagVARIANT rgVarRef);


        /// Return Type: HRESULT->LONG->int
        ///This: IDispatch*
        ///dispIdMember: DISPID->LONG->int
        ///riid: IID*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pDispParams: DISPPARAMS*
        ///pVarResult: VARIANT*
        ///pExcepInfo: EXCEPINFO*
        ///pArgErr: UINT*
        ///cVarRef: UINT->unsigned int
        ///rgVarRefIdx: UINT*
        ///rgVarRef: VARIANTARG*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_Invoke_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDispatch_Invoke_Stub(ref IDispatch This, int dispIdMember, ref GUID riid, uint lcid, uint dwFlags, ref tagDISPPARAMS pDispParams, ref tagVARIANT pVarResult, ref tagEXCEPINFO pExcepInfo, ref uint pArgErr, uint cVarRef, ref uint rgVarRefIdx, ref tagVARIANT rgVarRef);


        /// Return Type: HRESULT->LONG->int
        ///This: IDispatch*
        ///dispIdMember: DISPID->LONG->int
        ///riid: IID*
        ///lcid: LCID->DWORD->unsigned int
        ///wFlags: WORD->unsigned short
        ///pDispParams: DISPPARAMS*
        ///pVarResult: VARIANT*
        ///pExcepInfo: EXCEPINFO*
        ///puArgErr: UINT*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_Invoke_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDispatch_Invoke_Proxy(ref IDispatch This, int dispIdMember, ref GUID riid, uint lcid, ushort wFlags, ref tagDISPPARAMS pDispParams, ref tagVARIANT pVarResult, ref tagEXCEPINFO pExcepInfo, ref uint puArgErr);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_GetTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDispatch_GetTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDispatch*
        ///iTInfo: UINT->unsigned int
        ///lcid: LCID->DWORD->unsigned int
        ///ppTInfo: ITypeInfo**
        [DllImport("<Unknown>", EntryPoint = "IDispatch_GetTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDispatch_GetTypeInfo_Proxy(ref IDispatch This, uint iTInfo, uint lcid, ref IntPtr ppTInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_GetTypeInfoCount_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDispatch_GetTypeInfoCount_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDispatch*
        ///pctinfo: UINT*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_GetTypeInfoCount_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDispatch_GetTypeInfoCount_Proxy(ref IDispatch This, ref uint pctinfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_GetIDsOfNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDispatch_GetIDsOfNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDispatch*
        ///riid: IID*
        ///rgszNames: LPOLESTR*
        ///cNames: UINT->unsigned int
        ///lcid: LCID->DWORD->unsigned int
        ///rgDispId: DISPID*
        [DllImport("<Unknown>", EntryPoint = "IDispatch_GetIDsOfNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDispatch_GetIDsOfNames_Proxy(ref IDispatch This, ref GUID riid, ref IntPtr rgszNames, uint cNames, uint lcid, ref int rgDispId);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDirectWriterLock_WaitForWriteAccess_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDirectWriterLock_WaitForWriteAccess_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDirectWriterLock*
        ///dwTimeout: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDirectWriterLock_WaitForWriteAccess_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDirectWriterLock_WaitForWriteAccess_Proxy(ref IDirectWriterLock This, uint dwTimeout);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDirectWriterLock_ReleaseWriteAccess_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDirectWriterLock_ReleaseWriteAccess_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDirectWriterLock*
        [DllImport("<Unknown>", EntryPoint = "IDirectWriterLock_ReleaseWriteAccess_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDirectWriterLock_ReleaseWriteAccess_Proxy(ref IDirectWriterLock This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDirectWriterLock_HaveWriteAccess_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDirectWriterLock_HaveWriteAccess_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDirectWriterLock*
        [DllImport("<Unknown>", EntryPoint = "IDirectWriterLock_HaveWriteAccess_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDirectWriterLock_HaveWriteAccess_Proxy(ref IDirectWriterLock This);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        ///pmedium: FLAG_STGMEDIUM*
        ///fRelease: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IDataObject_SetData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_SetData_Stub(ref IDataObject This, ref tagFORMATETC pformatetc, ref FLAG_STGMEDIUM pmedium, [MarshalAs(UnmanagedType.Bool)] bool fRelease);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        ///pmedium: STGMEDIUM*
        ///fRelease: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IDataObject_SetData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_SetData_Proxy(ref IDataObject This, ref tagFORMATETC pformatetc, ref tagSTGMEDIUM pmedium, [MarshalAs(UnmanagedType.Bool)] bool fRelease);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_RemoteSetData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_RemoteSetData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        ///pmedium: FLAG_STGMEDIUM*
        ///fRelease: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IDataObject_RemoteSetData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_RemoteSetData_Proxy(ref IDataObject This, ref tagFORMATETC pformatetc, ref FLAG_STGMEDIUM pmedium, [MarshalAs(UnmanagedType.Bool)] bool fRelease);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_RemoteGetData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_RemoteGetData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetcIn: FORMATETC*
        ///pRemoteMedium: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_RemoteGetData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_RemoteGetData_Proxy(ref IDataObject This, ref tagFORMATETC pformatetcIn, ref tagSTGMEDIUM pRemoteMedium);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_RemoteGetDataHere_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_RemoteGetDataHere_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        ///pRemoteMedium: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_RemoteGetDataHere_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_RemoteGetDataHere_Proxy(ref IDataObject This, ref tagFORMATETC pformatetc, ref tagSTGMEDIUM pRemoteMedium);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_QueryGetData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_QueryGetData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_QueryGetData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_QueryGetData_Proxy(ref IDataObject This, ref tagFORMATETC pformatetc);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetcIn: FORMATETC*
        ///pRemoteMedium: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_GetData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_GetData_Stub(ref IDataObject This, ref tagFORMATETC pformatetcIn, ref tagSTGMEDIUM pRemoteMedium);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetcIn: FORMATETC*
        ///pmedium: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_GetData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_GetData_Proxy(ref IDataObject This, ref tagFORMATETC pformatetcIn, ref tagSTGMEDIUM pmedium);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        ///pRemoteMedium: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_GetDataHere_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_GetDataHere_Stub(ref IDataObject This, ref tagFORMATETC pformatetc, ref tagSTGMEDIUM pRemoteMedium);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        ///pmedium: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_GetDataHere_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_GetDataHere_Proxy(ref IDataObject This, ref tagFORMATETC pformatetc, ref tagSTGMEDIUM pmedium);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_GetCanonicalFormatEtc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_GetCanonicalFormatEtc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatectIn: FORMATETC*
        ///pformatetcOut: FORMATETC*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_GetCanonicalFormatEtc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_GetCanonicalFormatEtc_Proxy(ref IDataObject This, ref tagFORMATETC pformatectIn, ref tagFORMATETC pformatetcOut);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_EnumFormatEtc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_EnumFormatEtc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///dwDirection: DWORD->unsigned int
        ///ppenumFormatEtc: IEnumFORMATETC**
        [DllImport("<Unknown>", EntryPoint = "IDataObject_EnumFormatEtc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_EnumFormatEtc_Proxy(ref IDataObject This, uint dwDirection, ref IntPtr ppenumFormatEtc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_EnumDAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_EnumDAdvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///ppenumAdvise: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IDataObject_EnumDAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_EnumDAdvise_Proxy(ref IDataObject This, ref IntPtr ppenumAdvise);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_DUnadvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_DUnadvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDataObject_DUnadvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_DUnadvise_Proxy(ref IDataObject This, uint dwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_DAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataObject_DAdvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataObject*
        ///pformatetc: FORMATETC*
        ///advf: DWORD->unsigned int
        ///pAdvSink: IAdviseSink*
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataObject_DAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataObject_DAdvise_Proxy(ref IDataObject This, ref tagFORMATETC pformatetc, uint advf, ref IAdviseSink pAdvSink, ref uint pdwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataFilter_SetEncodingLevel_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataFilter_SetEncodingLevel_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataFilter*
        ///dwEncLevel: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDataFilter_SetEncodingLevel_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataFilter_SetEncodingLevel_Proxy(ref IDataFilter This, uint dwEncLevel);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataFilter_DoEncode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataFilter_DoEncode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataFilter*
        ///dwFlags: DWORD->unsigned int
        ///lInBufferSize: LONG->int
        ///pbInBuffer: BYTE*
        ///lOutBufferSize: LONG->int
        ///pbOutBuffer: BYTE*
        ///lInBytesAvailable: LONG->int
        ///plInBytesRead: LONG*
        ///plOutBytesWritten: LONG*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDataFilter_DoEncode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataFilter_DoEncode_Proxy(ref IDataFilter This, uint dwFlags, int lInBufferSize, ref byte pbInBuffer, int lOutBufferSize, ref byte pbOutBuffer, int lInBytesAvailable, ref int plInBytesRead, ref int plOutBytesWritten, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataFilter_DoDecode_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataFilter_DoDecode_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataFilter*
        ///dwFlags: DWORD->unsigned int
        ///lInBufferSize: LONG->int
        ///pbInBuffer: BYTE*
        ///lOutBufferSize: LONG->int
        ///pbOutBuffer: BYTE*
        ///lInBytesAvailable: LONG->int
        ///plInBytesRead: LONG*
        ///plOutBytesWritten: LONG*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDataFilter_DoDecode_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataFilter_DoDecode_Proxy(ref IDataFilter This, uint dwFlags, int lInBufferSize, ref byte pbInBuffer, int lOutBufferSize, ref byte pbOutBuffer, int lInBytesAvailable, ref int plInBytesRead, ref int plOutBytesWritten, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_Unadvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataAdviseHolder_Unadvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataAdviseHolder*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_Unadvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataAdviseHolder_Unadvise_Proxy(ref IDataAdviseHolder This, uint dwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_SendOnDataChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataAdviseHolder_SendOnDataChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataAdviseHolder*
        ///pDataObject: IDataObject*
        ///dwReserved: DWORD->unsigned int
        ///advf: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_SendOnDataChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataAdviseHolder_SendOnDataChange_Proxy(ref IDataAdviseHolder This, ref IDataObject pDataObject, uint dwReserved, uint advf);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_EnumAdvise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataAdviseHolder_EnumAdvise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataAdviseHolder*
        ///ppenumAdvise: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_EnumAdvise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataAdviseHolder_EnumAdvise_Proxy(ref IDataAdviseHolder This, ref IntPtr ppenumAdvise);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_Advise_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IDataAdviseHolder_Advise_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IDataAdviseHolder*
        ///pDataObject: IDataObject*
        ///pFetc: FORMATETC*
        ///advf: DWORD->unsigned int
        ///pAdvise: IAdviseSink*
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IDataAdviseHolder_Advise_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IDataAdviseHolder_Advise_Proxy(ref IDataAdviseHolder This, ref IDataObject pDataObject, ref tagFORMATETC pFetc, uint advf, ref IAdviseSink pAdvise, ref uint pdwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetVersion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetVersion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///wMajorVerNum: WORD->unsigned short
        ///wMinorVerNum: WORD->unsigned short
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetVersion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetVersion_Proxy(ref ICreateTypeLib This, ushort wMajorVerNum, ushort wMinorVerNum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///szName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetName_Proxy(ref ICreateTypeLib This, IntPtr szName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetLibFlags_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetLibFlags_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///uLibFlags: UINT->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetLibFlags_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetLibFlags_Proxy(ref ICreateTypeLib This, uint uLibFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetLcid_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetLcid_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///lcid: LCID->DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetLcid_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetLcid_Proxy(ref ICreateTypeLib This, uint lcid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetHelpFileName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetHelpFileName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///szHelpFileName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetHelpFileName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetHelpFileName_Proxy(ref ICreateTypeLib This, IntPtr szHelpFileName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetHelpContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetHelpContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///dwHelpContext: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetHelpContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetHelpContext_Proxy(ref ICreateTypeLib This, uint dwHelpContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetGuid_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetGuid_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///guid: GUID*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetGuid_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetGuid_Proxy(ref ICreateTypeLib This, ref GUID guid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetDocString_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SetDocString_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///szDoc: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SetDocString_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SetDocString_Proxy(ref ICreateTypeLib This, IntPtr szDoc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SaveAllChanges_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_SaveAllChanges_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_SaveAllChanges_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_SaveAllChanges_Proxy(ref ICreateTypeLib This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_CreateTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib_CreateTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib*
        ///szName: LPOLESTR->OLECHAR*
        ///tkind: TYPEKIND->tagTYPEKIND
        ///ppCTInfo: ICreateTypeInfo**
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib_CreateTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib_CreateTypeInfo_Proxy(ref ICreateTypeLib This, IntPtr szName, tagTYPEKIND tkind, ref IntPtr ppCTInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_SetHelpStringDll_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib2_SetHelpStringDll_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib2*
        ///szFileName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_SetHelpStringDll_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib2_SetHelpStringDll_Proxy(ref ICreateTypeLib2 This, IntPtr szFileName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_SetHelpStringContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib2_SetHelpStringContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib2*
        ///dwHelpStringContext: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_SetHelpStringContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib2_SetHelpStringContext_Proxy(ref ICreateTypeLib2 This, uint dwHelpStringContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_SetCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib2_SetCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib2*
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_SetCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib2_SetCustData_Proxy(ref ICreateTypeLib2 This, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_DeleteTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeLib2_DeleteTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeLib2*
        ///szName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeLib2_DeleteTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeLib2_DeleteTypeInfo_Proxy(ref ICreateTypeLib2 This, IntPtr szName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVersion_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetVersion_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///wMajorVerNum: WORD->unsigned short
        ///wMinorVerNum: WORD->unsigned short
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVersion_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetVersion_Proxy(ref ICreateTypeInfo This, ushort wMajorVerNum, ushort wMinorVerNum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVarName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetVarName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///szName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVarName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetVarName_Proxy(ref ICreateTypeInfo This, uint index, IntPtr szName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVarHelpContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetVarHelpContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///dwHelpContext: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVarHelpContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetVarHelpContext_Proxy(ref ICreateTypeInfo This, uint index, uint dwHelpContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVarDocString_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetVarDocString_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///szDocString: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetVarDocString_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetVarDocString_Proxy(ref ICreateTypeInfo This, uint index, IntPtr szDocString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetTypeIdldesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetTypeIdldesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///pIdlDesc: IDLDESC*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetTypeIdldesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetTypeIdldesc_Proxy(ref ICreateTypeInfo This, ref tagIDLDESC pIdlDesc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetTypeFlags_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetTypeFlags_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///uTypeFlags: UINT->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetTypeFlags_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetTypeFlags_Proxy(ref ICreateTypeInfo This, uint uTypeFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetTypeDescAlias_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetTypeDescAlias_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///pTDescAlias: TYPEDESC*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetTypeDescAlias_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetTypeDescAlias_Proxy(ref ICreateTypeInfo This, ref tagTYPEDESC pTDescAlias);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetSchema_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetSchema_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///pStrSchema: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetSchema_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetSchema_Proxy(ref ICreateTypeInfo This, IntPtr pStrSchema);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetMops_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetMops_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///bstrMops: BSTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetMops_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetMops_Proxy(ref ICreateTypeInfo This, uint index, [MarshalAs(UnmanagedType.BStr)] string bstrMops);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetImplTypeFlags_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetImplTypeFlags_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///implTypeFlags: INT->int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetImplTypeFlags_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetImplTypeFlags_Proxy(ref ICreateTypeInfo This, uint index, int implTypeFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetHelpContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetHelpContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///dwHelpContext: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetHelpContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetHelpContext_Proxy(ref ICreateTypeInfo This, uint dwHelpContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetGuid_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetGuid_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///guid: GUID*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetGuid_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetGuid_Proxy(ref ICreateTypeInfo This, ref GUID guid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetFuncHelpContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetFuncHelpContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///dwHelpContext: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetFuncHelpContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetFuncHelpContext_Proxy(ref ICreateTypeInfo This, uint index, uint dwHelpContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetFuncDocString_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetFuncDocString_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///szDocString: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetFuncDocString_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetFuncDocString_Proxy(ref ICreateTypeInfo This, uint index, IntPtr szDocString);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetFuncAndParamNames_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetFuncAndParamNames_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///rgszNames: LPOLESTR*
        ///cNames: UINT->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetFuncAndParamNames_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetFuncAndParamNames_Proxy(ref ICreateTypeInfo This, uint index, ref IntPtr rgszNames, uint cNames);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetDocString_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetDocString_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///pStrDoc: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetDocString_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetDocString_Proxy(ref ICreateTypeInfo This, IntPtr pStrDoc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetAlignment_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_SetAlignment_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///cbAlignment: WORD->unsigned short
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_SetAlignment_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_SetAlignment_Proxy(ref ICreateTypeInfo This, ushort cbAlignment);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_LayOut_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_LayOut_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_LayOut_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_LayOut_Proxy(ref ICreateTypeInfo This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_DefineFuncAsDllEntry_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_DefineFuncAsDllEntry_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///szDllName: LPOLESTR->OLECHAR*
        ///szProcName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_DefineFuncAsDllEntry_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_DefineFuncAsDllEntry_Proxy(ref ICreateTypeInfo This, uint index, IntPtr szDllName, IntPtr szProcName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddVarDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_AddVarDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///pVarDesc: VARDESC*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddVarDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_AddVarDesc_Proxy(ref ICreateTypeInfo This, uint index, ref tagVARDESC pVarDesc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddRefTypeInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_AddRefTypeInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///pTInfo: ITypeInfo*
        ///phRefType: HREFTYPE*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddRefTypeInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_AddRefTypeInfo_Proxy(ref ICreateTypeInfo This, ref ITypeInfo pTInfo, ref uint phRefType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddImplType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_AddImplType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///hRefType: HREFTYPE->DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddImplType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_AddImplType_Proxy(ref ICreateTypeInfo This, uint index, uint hRefType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddFuncDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo_AddFuncDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo*
        ///index: UINT->unsigned int
        ///pFuncDesc: FUNCDESC*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo_AddFuncDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo_AddFuncDesc_Proxy(ref ICreateTypeInfo This, uint index, ref tagFUNCDESC pFuncDesc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetVarHelpStringContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetVarHelpStringContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        ///dwHelpStringContext: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetVarHelpStringContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetVarHelpStringContext_Proxy(ref ICreateTypeInfo2 This, uint index, uint dwHelpStringContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetVarCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetVarCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetVarCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetVarCustData_Proxy(ref ICreateTypeInfo2 This, uint index, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetParamCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetParamCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///indexFunc: UINT->unsigned int
        ///indexParam: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetParamCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetParamCustData_Proxy(ref ICreateTypeInfo2 This, uint indexFunc, uint indexParam, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetName_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetName_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///szName: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetName_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetName_Proxy(ref ICreateTypeInfo2 This, IntPtr szName);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetImplTypeCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetImplTypeCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetImplTypeCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetImplTypeCustData_Proxy(ref ICreateTypeInfo2 This, uint index, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetHelpStringContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetHelpStringContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///dwHelpStringContext: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetHelpStringContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetHelpStringContext_Proxy(ref ICreateTypeInfo2 This, uint dwHelpStringContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetFuncHelpStringContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetFuncHelpStringContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        ///dwHelpStringContext: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetFuncHelpStringContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetFuncHelpStringContext_Proxy(ref ICreateTypeInfo2 This, uint index, uint dwHelpStringContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetFuncCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetFuncCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetFuncCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetFuncCustData_Proxy(ref ICreateTypeInfo2 This, uint index, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetCustData_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_SetCustData_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///guid: GUID*
        ///pVarVal: VARIANT*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_SetCustData_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_SetCustData_Proxy(ref ICreateTypeInfo2 This, ref GUID guid, ref tagVARIANT pVarVal);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_Invalidate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_Invalidate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_Invalidate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_Invalidate_Proxy(ref ICreateTypeInfo2 This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteVarDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_DeleteVarDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteVarDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_DeleteVarDesc_Proxy(ref ICreateTypeInfo2 This, uint index);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteVarDescByMemId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_DeleteVarDescByMemId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///memid: MEMBERID->DISPID->LONG->int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteVarDescByMemId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_DeleteVarDescByMemId_Proxy(ref ICreateTypeInfo2 This, int memid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteImplType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_DeleteImplType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteImplType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_DeleteImplType_Proxy(ref ICreateTypeInfo2 This, uint index);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteFuncDesc_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_DeleteFuncDesc_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///index: UINT->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteFuncDesc_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_DeleteFuncDesc_Proxy(ref ICreateTypeInfo2 This, uint index);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteFuncDescByMemId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateTypeInfo2_DeleteFuncDescByMemId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateTypeInfo2*
        ///memid: MEMBERID->DISPID->LONG->int
        ///invKind: INVOKEKIND->tagINVOKEKIND
        [DllImport("<Unknown>", EntryPoint = "ICreateTypeInfo2_DeleteFuncDescByMemId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateTypeInfo2_DeleteFuncDescByMemId_Proxy(ref ICreateTypeInfo2 This, int memid, tagINVOKEKIND invKind);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetSource_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateErrorInfo_SetSource_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateErrorInfo*
        ///szSource: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetSource_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateErrorInfo_SetSource_Proxy(ref ICreateErrorInfo This, IntPtr szSource);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetHelpFile_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateErrorInfo_SetHelpFile_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateErrorInfo*
        ///szHelpFile: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetHelpFile_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateErrorInfo_SetHelpFile_Proxy(ref ICreateErrorInfo This, IntPtr szHelpFile);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetHelpContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateErrorInfo_SetHelpContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateErrorInfo*
        ///dwHelpContext: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetHelpContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateErrorInfo_SetHelpContext_Proxy(ref ICreateErrorInfo This, uint dwHelpContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetGUID_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateErrorInfo_SetGUID_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateErrorInfo*
        ///rguid: GUID*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetGUID_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateErrorInfo_SetGUID_Proxy(ref ICreateErrorInfo This, ref GUID rguid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetDescription_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICreateErrorInfo_SetDescription_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICreateErrorInfo*
        ///szDescription: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "ICreateErrorInfo_SetDescription_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICreateErrorInfo_SetDescription_Proxy(ref ICreateErrorInfo This, IntPtr szDescription);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IContinue_FContinue_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IContinue_FContinue_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IContinue*
        [DllImport("<Unknown>", EntryPoint = "IContinue_FContinue_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IContinue_FContinue_Proxy(ref IContinue This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_SetCurrentLogicalThreadId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IComThreadingInfo_SetCurrentLogicalThreadId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IComThreadingInfo*
        ///rguid: GUID*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_SetCurrentLogicalThreadId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IComThreadingInfo_SetCurrentLogicalThreadId_Proxy(ref IComThreadingInfo This, ref GUID rguid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_GetCurrentThreadType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IComThreadingInfo_GetCurrentThreadType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IComThreadingInfo*
        ///pThreadType: THDTYPE*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_GetCurrentThreadType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IComThreadingInfo_GetCurrentThreadType_Proxy(ref IComThreadingInfo This, ref THDTYPE pThreadType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_GetCurrentLogicalThreadId_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IComThreadingInfo_GetCurrentLogicalThreadId_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IComThreadingInfo*
        ///pguidLogicalThreadId: GUID*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_GetCurrentLogicalThreadId_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IComThreadingInfo_GetCurrentLogicalThreadId_Proxy(ref IComThreadingInfo This, ref GUID pguidLogicalThreadId);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_GetCurrentApartmentType_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IComThreadingInfo_GetCurrentApartmentType_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IComThreadingInfo*
        ///pAptType: APTTYPE*
        [DllImport("<Unknown>", EntryPoint = "IComThreadingInfo_GetCurrentApartmentType_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IComThreadingInfo_GetCurrentApartmentType_Proxy(ref IComThreadingInfo This, ref APTTYPE pAptType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICodeInstall_OnCodeInstallProblem_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICodeInstall_OnCodeInstallProblem_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICodeInstall*
        ///ulStatusCode: ULONG->unsigned int
        ///szDestination: LPCWSTR->WCHAR*
        ///szSource: LPCWSTR->WCHAR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICodeInstall_OnCodeInstallProblem_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICodeInstall_OnCodeInstallProblem_Proxy(ref ICodeInstall This, uint ulStatusCode, [In] [MarshalAs(UnmanagedType.LPWStr)] string szDestination, [In] [MarshalAs(UnmanagedType.LPWStr)] string szSource, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IClientSecurity_SetBlanket_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IClientSecurity_SetBlanket_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IClientSecurity*
        ///pProxy: IUnknown*
        ///dwAuthnSvc: DWORD->unsigned int
        ///dwAuthzSvc: DWORD->unsigned int
        ///pServerPrincName: OLECHAR*
        ///dwAuthnLevel: DWORD->unsigned int
        ///dwImpLevel: DWORD->unsigned int
        ///pAuthInfo: void*
        ///dwCapabilities: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IClientSecurity_SetBlanket_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClientSecurity_SetBlanket_Proxy(ref IClientSecurity This, ref IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, IntPtr pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, IntPtr pAuthInfo, uint dwCapabilities);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IClientSecurity_QueryBlanket_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IClientSecurity_QueryBlanket_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IClientSecurity*
        ///pProxy: IUnknown*
        ///pAuthnSvc: DWORD*
        ///pAuthzSvc: DWORD*
        ///pServerPrincName: OLECHAR**
        ///pAuthnLevel: DWORD*
        ///pImpLevel: DWORD*
        ///pAuthInfo: void**
        ///pCapabilites: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IClientSecurity_QueryBlanket_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClientSecurity_QueryBlanket_Proxy(ref IClientSecurity This, ref IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref IntPtr pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref IntPtr pAuthInfo, ref uint pCapabilites);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IClientSecurity_CopyProxy_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IClientSecurity_CopyProxy_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IClientSecurity*
        ///pProxy: IUnknown*
        ///ppCopy: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IClientSecurity_CopyProxy_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClientSecurity_CopyProxy_Proxy(ref IClientSecurity This, ref IUnknown pProxy, ref IntPtr ppCopy);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_RemoteLockServer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IClassFactory_RemoteLockServer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IClassFactory*
        ///fLock: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_RemoteLockServer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClassFactory_RemoteLockServer_Proxy(ref IClassFactory This, [MarshalAs(UnmanagedType.Bool)] bool fLock);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_RemoteCreateInstance_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IClassFactory_RemoteCreateInstance_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IClassFactory*
        ///riid: IID*
        ///ppvObject: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_RemoteCreateInstance_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClassFactory_RemoteCreateInstance_Proxy(ref IClassFactory This, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IClassFactory*
        ///fLock: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_LockServer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClassFactory_LockServer_Stub(ref IClassFactory This, [MarshalAs(UnmanagedType.Bool)] bool fLock);


        /// Return Type: HRESULT->LONG->int
        ///This: IClassFactory*
        ///fLock: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_LockServer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClassFactory_LockServer_Proxy(ref IClassFactory This, [MarshalAs(UnmanagedType.Bool)] bool fLock);


        /// Return Type: HRESULT->LONG->int
        ///This: IClassFactory*
        ///riid: IID*
        ///ppvObject: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_CreateInstance_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClassFactory_CreateInstance_Stub(ref IClassFactory This, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IClassFactory*
        ///pUnkOuter: IUnknown*
        ///riid: IID*
        ///ppvObject: void**
        [DllImport("<Unknown>", EntryPoint = "IClassFactory_CreateInstance_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClassFactory_CreateInstance_Proxy(ref IClassFactory This, ref IUnknown pUnkOuter, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IClassActivator_GetClassObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IClassActivator_GetClassObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IClassActivator*
        ///rclsid: IID*
        ///dwClassContext: DWORD->unsigned int
        ///locale: LCID->DWORD->unsigned int
        ///riid: IID*
        ///ppv: void**
        [DllImport("<Unknown>", EntryPoint = "IClassActivator_GetClassObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IClassActivator_GetClassObject_Proxy(ref IClassActivator This, ref GUID rclsid, uint dwClassContext, uint locale, ref GUID riid, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ServerNotify_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ServerNotify_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IChannelHook*
        ///uExtent: GUID*
        ///riid: IID*
        ///cbDataSize: ULONG->unsigned int
        ///pDataBuffer: void*
        ///lDataRep: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ServerNotify_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ServerNotify_Proxy(ref IChannelHook This, ref GUID uExtent, ref GUID riid, uint cbDataSize, IntPtr pDataBuffer, uint lDataRep);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ServerGetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ServerGetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IChannelHook*
        ///uExtent: GUID*
        ///riid: IID*
        ///hrFault: HRESULT->LONG->int
        ///pDataSize: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ServerGetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ServerGetSize_Proxy(ref IChannelHook This, ref GUID uExtent, ref GUID riid, int hrFault, ref uint pDataSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ServerFillBuffer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ServerFillBuffer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IChannelHook*
        ///uExtent: GUID*
        ///riid: IID*
        ///pDataSize: ULONG*
        ///pDataBuffer: void*
        ///hrFault: HRESULT->LONG->int
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ServerFillBuffer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ServerFillBuffer_Proxy(ref IChannelHook This, ref GUID uExtent, ref GUID riid, ref uint pDataSize, IntPtr pDataBuffer, int hrFault);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ClientNotify_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ClientNotify_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IChannelHook*
        ///uExtent: GUID*
        ///riid: IID*
        ///cbDataSize: ULONG->unsigned int
        ///pDataBuffer: void*
        ///lDataRep: DWORD->unsigned int
        ///hrFault: HRESULT->LONG->int
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ClientNotify_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ClientNotify_Proxy(ref IChannelHook This, ref GUID uExtent, ref GUID riid, uint cbDataSize, IntPtr pDataBuffer, uint lDataRep, int hrFault);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ClientGetSize_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ClientGetSize_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IChannelHook*
        ///uExtent: GUID*
        ///riid: IID*
        ///pDataSize: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ClientGetSize_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ClientGetSize_Proxy(ref IChannelHook This, ref GUID uExtent, ref GUID riid, ref uint pDataSize);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ClientFillBuffer_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ClientFillBuffer_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IChannelHook*
        ///uExtent: GUID*
        ///riid: IID*
        ///pDataSize: ULONG*
        ///pDataBuffer: void*
        [DllImport("<Unknown>", EntryPoint = "IChannelHook_ClientFillBuffer_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IChannelHook_ClientFillBuffer_Proxy(ref IChannelHook This, ref GUID uExtent, ref GUID riid, ref uint pDataSize, IntPtr pDataBuffer);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICatalogFileInfo_GetJavaTrust_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICatalogFileInfo_GetJavaTrust_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICatalogFileInfo*
        ///ppJavaTrust: void**
        [DllImport("<Unknown>", EntryPoint = "ICatalogFileInfo_GetJavaTrust_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICatalogFileInfo_GetJavaTrust_Proxy(ref ICatalogFileInfo This, ref IntPtr ppJavaTrust);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICatalogFileInfo_GetCatalogFile_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICatalogFileInfo_GetCatalogFile_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICatalogFileInfo*
        ///ppszCatalogFile: LPSTR*
        [DllImport("<Unknown>", EntryPoint = "ICatalogFileInfo_GetCatalogFile_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICatalogFileInfo_GetCatalogFile_Proxy(ref ICatalogFileInfo This, ref IntPtr ppszCatalogFile);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICancelMethodCalls_TestCancel_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICancelMethodCalls_TestCancel_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICancelMethodCalls*
        [DllImport("<Unknown>", EntryPoint = "ICancelMethodCalls_TestCancel_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICancelMethodCalls_TestCancel_Proxy(ref ICancelMethodCalls This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICancelMethodCalls_Cancel_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICancelMethodCalls_Cancel_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICancelMethodCalls*
        ///ulSeconds: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ICancelMethodCalls_Cancel_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICancelMethodCalls_Cancel_Proxy(ref ICancelMethodCalls This, uint ulSeconds);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "ICallFactory_CreateCall_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void ICallFactory_CreateCall_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: ICallFactory*
        ///riid: IID*
        ///pCtrlUnk: IUnknown*
        ///riid2: IID*
        ///ppv: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "ICallFactory_CreateCall_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int ICallFactory_CreateCall_Proxy(ref ICallFactory This, ref GUID riid, ref IUnknown pCtrlUnk, ref GUID riid2, ref IntPtr ppv);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBlockingLock_Unlock_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBlockingLock_Unlock_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBlockingLock*
        [DllImport("<Unknown>", EntryPoint = "IBlockingLock_Unlock_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBlockingLock_Unlock_Proxy(ref IBlockingLock This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBlockingLock_Lock_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBlockingLock_Lock_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBlockingLock*
        ///dwTimeout: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IBlockingLock_Lock_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBlockingLock_Lock_Proxy(ref IBlockingLock This, uint dwTimeout);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_RemoteOnDataAvailable_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_RemoteOnDataAvailable_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///grfBSCF: DWORD->unsigned int
        ///dwSize: DWORD->unsigned int
        ///pformatetc: RemFORMATETC*
        ///pstgmed: RemSTGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_RemoteOnDataAvailable_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_RemoteOnDataAvailable_Proxy(ref IBindStatusCallback This, uint grfBSCF, uint dwSize, ref tagRemFORMATETC pformatetc, ref tagRemSTGMEDIUM pstgmed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_RemoteGetBindInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_RemoteGetBindInfo_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///grfBINDF: DWORD*
        ///pbindinfo: RemBINDINFO*
        ///pstgmed: RemSTGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_RemoteGetBindInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_RemoteGetBindInfo_Proxy(ref IBindStatusCallback This, ref uint grfBINDF, ref RemBINDINFO pbindinfo, ref tagRemSTGMEDIUM pstgmed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnStopBinding_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_OnStopBinding_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///hresult: HRESULT->LONG->int
        ///szError: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnStopBinding_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_OnStopBinding_Proxy(ref IBindStatusCallback This, int hresult, [In] [MarshalAs(UnmanagedType.LPWStr)] string szError);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnStartBinding_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_OnStartBinding_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///dwReserved: DWORD->unsigned int
        ///pib: IBinding*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnStartBinding_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_OnStartBinding_Proxy(ref IBindStatusCallback This, uint dwReserved, ref IBinding pib);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnProgress_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_OnProgress_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///ulProgress: ULONG->unsigned int
        ///ulProgressMax: ULONG->unsigned int
        ///ulStatusCode: ULONG->unsigned int
        ///szStatusText: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnProgress_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_OnProgress_Proxy(ref IBindStatusCallback This, uint ulProgress, uint ulProgressMax, uint ulStatusCode, [In] [MarshalAs(UnmanagedType.LPWStr)] string szStatusText);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnObjectAvailable_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_OnObjectAvailable_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///riid: IID*
        ///punk: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnObjectAvailable_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_OnObjectAvailable_Proxy(ref IBindStatusCallback This, ref GUID riid, ref IUnknown punk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnLowResource_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_OnLowResource_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///reserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnLowResource_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_OnLowResource_Proxy(ref IBindStatusCallback This, uint reserved);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///grfBSCF: DWORD->unsigned int
        ///dwSize: DWORD->unsigned int
        ///pformatetc: RemFORMATETC*
        ///pstgmed: RemSTGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnDataAvailable_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_OnDataAvailable_Stub(ref IBindStatusCallback This, uint grfBSCF, uint dwSize, ref tagRemFORMATETC pformatetc, ref tagRemSTGMEDIUM pstgmed);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///grfBSCF: DWORD->unsigned int
        ///dwSize: DWORD->unsigned int
        ///pformatetc: FORMATETC*
        ///pstgmed: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_OnDataAvailable_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_OnDataAvailable_Proxy(ref IBindStatusCallback This, uint grfBSCF, uint dwSize, ref tagFORMATETC pformatetc, ref tagSTGMEDIUM pstgmed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_GetPriority_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindStatusCallback_GetPriority_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///pnPriority: LONG*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_GetPriority_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_GetPriority_Proxy(ref IBindStatusCallback This, ref int pnPriority);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///grfBINDF: DWORD*
        ///pbindinfo: RemBINDINFO*
        ///pstgmed: RemSTGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_GetBindInfo_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_GetBindInfo_Stub(ref IBindStatusCallback This, ref uint grfBINDF, ref RemBINDINFO pbindinfo, ref tagRemSTGMEDIUM pstgmed);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindStatusCallback*
        ///grfBINDF: DWORD*
        ///pbindinfo: BINDINFO*
        [DllImport("<Unknown>", EntryPoint = "IBindStatusCallback_GetBindInfo_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindStatusCallback_GetBindInfo_Proxy(ref IBindStatusCallback This, ref uint grfBINDF, ref BINDINFO pbindinfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindProtocol_CreateBinding_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindProtocol_CreateBinding_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindProtocol*
        ///szUrl: LPCWSTR->WCHAR*
        ///pbc: IBindCtx*
        ///ppb: IBinding**
        [DllImport("<Unknown>", EntryPoint = "IBindProtocol_CreateBinding_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindProtocol_CreateBinding_Proxy(ref IBindProtocol This, [In] [MarshalAs(UnmanagedType.LPWStr)] string szUrl, ref IBindCtx pbc, ref IntPtr ppb);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBinding_Suspend_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBinding_Suspend_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        [DllImport("<Unknown>", EntryPoint = "IBinding_Suspend_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_Suspend_Proxy(ref IBinding This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBinding_SetPriority_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBinding_SetPriority_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        ///nPriority: LONG->int
        [DllImport("<Unknown>", EntryPoint = "IBinding_SetPriority_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_SetPriority_Proxy(ref IBinding This, int nPriority);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBinding_Resume_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBinding_Resume_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        [DllImport("<Unknown>", EntryPoint = "IBinding_Resume_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_Resume_Proxy(ref IBinding This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBinding_RemoteGetBindResult_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBinding_RemoteGetBindResult_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        ///pclsidProtocol: CLSID*
        ///pdwResult: DWORD*
        ///pszResult: LPOLESTR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IBinding_RemoteGetBindResult_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_RemoteGetBindResult_Proxy(ref IBinding This, ref GUID pclsidProtocol, ref uint pdwResult, ref IntPtr pszResult, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBinding_GetPriority_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBinding_GetPriority_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        ///pnPriority: LONG*
        [DllImport("<Unknown>", EntryPoint = "IBinding_GetPriority_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_GetPriority_Proxy(ref IBinding This, ref int pnPriority);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        ///pclsidProtocol: CLSID*
        ///pdwResult: DWORD*
        ///pszResult: LPOLESTR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IBinding_GetBindResult_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_GetBindResult_Stub(ref IBinding This, ref GUID pclsidProtocol, ref uint pdwResult, ref IntPtr pszResult, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        ///pclsidProtocol: CLSID*
        ///pdwResult: DWORD*
        ///pszResult: LPOLESTR*
        ///pdwReserved: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBinding_GetBindResult_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_GetBindResult_Proxy(ref IBinding This, ref GUID pclsidProtocol, ref uint pdwResult, ref IntPtr pszResult, ref uint pdwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBinding_Abort_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBinding_Abort_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBinding*
        [DllImport("<Unknown>", EntryPoint = "IBinding_Abort_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBinding_Abort_Proxy(ref IBinding This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindHost_RemoteMonikerBindToStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindHost_RemoteMonikerBindToStorage_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindHost*
        ///pMk: IMoniker*
        ///pBC: IBindCtx*
        ///pBSC: IBindStatusCallback*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IBindHost_RemoteMonikerBindToStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindHost_RemoteMonikerBindToStorage_Proxy(ref IBindHost This, ref IMoniker pMk, ref IBindCtx pBC, ref IBindStatusCallback pBSC, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindHost_RemoteMonikerBindToObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindHost_RemoteMonikerBindToObject_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindHost*
        ///pMk: IMoniker*
        ///pBC: IBindCtx*
        ///pBSC: IBindStatusCallback*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IBindHost_RemoteMonikerBindToObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindHost_RemoteMonikerBindToObject_Proxy(ref IBindHost This, ref IMoniker pMk, ref IBindCtx pBC, ref IBindStatusCallback pBSC, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindHost*
        ///pMk: IMoniker*
        ///pBC: IBindCtx*
        ///pBSC: IBindStatusCallback*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IBindHost_MonikerBindToStorage_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindHost_MonikerBindToStorage_Stub(ref IBindHost This, ref IMoniker pMk, ref IBindCtx pBC, ref IBindStatusCallback pBSC, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindHost*
        ///pMk: IMoniker*
        ///pBC: IBindCtx*
        ///pBSC: IBindStatusCallback*
        ///riid: IID*
        ///ppvObj: void**
        [DllImport("<Unknown>", EntryPoint = "IBindHost_MonikerBindToStorage_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindHost_MonikerBindToStorage_Proxy(ref IBindHost This, ref IMoniker pMk, ref IBindCtx pBC, ref IBindStatusCallback pBSC, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindHost*
        ///pMk: IMoniker*
        ///pBC: IBindCtx*
        ///pBSC: IBindStatusCallback*
        ///riid: IID*
        ///ppvObj: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IBindHost_MonikerBindToObject_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindHost_MonikerBindToObject_Stub(ref IBindHost This, ref IMoniker pMk, ref IBindCtx pBC, ref IBindStatusCallback pBSC, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindHost*
        ///pMk: IMoniker*
        ///pBC: IBindCtx*
        ///pBSC: IBindStatusCallback*
        ///riid: IID*
        ///ppvObj: void**
        [DllImport("<Unknown>", EntryPoint = "IBindHost_MonikerBindToObject_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindHost_MonikerBindToObject_Proxy(ref IBindHost This, ref IMoniker pMk, ref IBindCtx pBC, ref IBindStatusCallback pBSC, ref GUID riid, ref IntPtr ppvObj);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindHost_CreateMoniker_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindHost_CreateMoniker_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindHost*
        ///szName: LPOLESTR->OLECHAR*
        ///pBC: IBindCtx*
        ///ppmk: IMoniker**
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IBindHost_CreateMoniker_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindHost_CreateMoniker_Proxy(ref IBindHost This, IntPtr szName, ref IBindCtx pBC, ref IntPtr ppmk, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pbindopts: BIND_OPTS2*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_SetBindOptions_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_SetBindOptions_Stub(ref IBindCtx This, ref tagBIND_OPTS2 pbindopts);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pbindopts: BIND_OPTS*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_SetBindOptions_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_SetBindOptions_Proxy(ref IBindCtx This, ref tagBIND_OPTS pbindopts);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RevokeObjectParam_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_RevokeObjectParam_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pszKey: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RevokeObjectParam_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_RevokeObjectParam_Proxy(ref IBindCtx This, IntPtr pszKey);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RevokeObjectBound_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_RevokeObjectBound_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///punk: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RevokeObjectBound_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_RevokeObjectBound_Proxy(ref IBindCtx This, ref IUnknown punk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RemoteSetBindOptions_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_RemoteSetBindOptions_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pbindopts: BIND_OPTS2*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RemoteSetBindOptions_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_RemoteSetBindOptions_Proxy(ref IBindCtx This, ref tagBIND_OPTS2 pbindopts);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RemoteGetBindOptions_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_RemoteGetBindOptions_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pbindopts: BIND_OPTS2*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RemoteGetBindOptions_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_RemoteGetBindOptions_Proxy(ref IBindCtx This, ref tagBIND_OPTS2 pbindopts);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_ReleaseBoundObjects_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_ReleaseBoundObjects_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_ReleaseBoundObjects_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_ReleaseBoundObjects_Proxy(ref IBindCtx This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RegisterObjectParam_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_RegisterObjectParam_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pszKey: LPOLESTR->OLECHAR*
        ///punk: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RegisterObjectParam_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_RegisterObjectParam_Proxy(ref IBindCtx This, IntPtr pszKey, ref IUnknown punk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RegisterObjectBound_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_RegisterObjectBound_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///punk: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_RegisterObjectBound_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_RegisterObjectBound_Proxy(ref IBindCtx This, ref IUnknown punk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_GetRunningObjectTable_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_GetRunningObjectTable_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pprot: IRunningObjectTable**
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_GetRunningObjectTable_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_GetRunningObjectTable_Proxy(ref IBindCtx This, ref IntPtr pprot);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_GetObjectParam_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_GetObjectParam_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pszKey: LPOLESTR->OLECHAR*
        ///ppunk: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_GetObjectParam_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_GetObjectParam_Proxy(ref IBindCtx This, IntPtr pszKey, ref IntPtr ppunk);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pbindopts: BIND_OPTS2*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_GetBindOptions_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_GetBindOptions_Stub(ref IBindCtx This, ref tagBIND_OPTS2 pbindopts);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///pbindopts: BIND_OPTS*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_GetBindOptions_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_GetBindOptions_Proxy(ref IBindCtx This, ref tagBIND_OPTS pbindopts);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_EnumObjectParam_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IBindCtx_EnumObjectParam_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IBindCtx*
        ///ppenum: IEnumString**
        [DllImport("<Unknown>", EntryPoint = "IBindCtx_EnumObjectParam_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IBindCtx_EnumObjectParam_Proxy(ref IBindCtx This, ref IntPtr ppenum);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAuthenticate_Authenticate_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAuthenticate_Authenticate_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAuthenticate*
        ///phwnd: HWND*
        ///pszUsername: LPWSTR*
        ///pszPassword: LPWSTR*
        [DllImport("<Unknown>", EntryPoint = "IAuthenticate_Authenticate_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAuthenticate_Authenticate_Proxy(ref IAuthenticate This, ref IntPtr phwnd, ref IntPtr pszUsername, ref IntPtr pszPassword);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAsyncRpcChannelBuffer_Send_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAsyncRpcChannelBuffer_Send_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAsyncRpcChannelBuffer*
        ///pMsg: RPCOLEMESSAGE*
        ///pSync: ISynchronize*
        ///pulStatus: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IAsyncRpcChannelBuffer_Send_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAsyncRpcChannelBuffer_Send_Proxy(ref IAsyncRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMsg, ref ISynchronize pSync, ref uint pulStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAsyncRpcChannelBuffer_Receive_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAsyncRpcChannelBuffer_Receive_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAsyncRpcChannelBuffer*
        ///pMsg: RPCOLEMESSAGE*
        ///pulStatus: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IAsyncRpcChannelBuffer_Receive_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAsyncRpcChannelBuffer_Receive_Proxy(ref IAsyncRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMsg, ref uint pulStatus);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAsyncRpcChannelBuffer_GetDestCtxEx_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAsyncRpcChannelBuffer_GetDestCtxEx_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAsyncRpcChannelBuffer*
        ///pMsg: RPCOLEMESSAGE*
        ///pdwDestContext: DWORD*
        ///ppvDestContext: void**
        [DllImport("<Unknown>", EntryPoint = "IAsyncRpcChannelBuffer_GetDestCtxEx_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAsyncRpcChannelBuffer_GetDestCtxEx_Proxy(ref IAsyncRpcChannelBuffer This, ref tagRPCOLEMESSAGE pMsg, ref uint pdwDestContext, ref IntPtr ppvDestContext);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAsyncManager_GetState_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAsyncManager_GetState_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAsyncManager*
        ///pulStateFlags: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IAsyncManager_GetState_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAsyncManager_GetState_Proxy(ref IAsyncManager This, ref uint pulStateFlags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAsyncManager_GetCallContext_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAsyncManager_GetCallContext_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAsyncManager*
        ///riid: IID*
        ///pInterface: void**
        [DllImport("<Unknown>", EntryPoint = "IAsyncManager_GetCallContext_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAsyncManager_GetCallContext_Proxy(ref IAsyncManager This, ref GUID riid, ref IntPtr pInterface);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAsyncManager_CompleteCall_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAsyncManager_CompleteCall_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAsyncManager*
        ///Result: HRESULT->LONG->int
        [DllImport("<Unknown>", EntryPoint = "IAsyncManager_CompleteCall_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAsyncManager_CompleteCall_Proxy(ref IAsyncManager This, int Result);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnViewChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_RemoteOnViewChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        ///dwAspect: DWORD->unsigned int
        ///lindex: LONG->int
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnViewChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_RemoteOnViewChange_Proxy(ref IAdviseSink This, uint dwAspect, int lindex);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnSave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_RemoteOnSave_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnSave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_RemoteOnSave_Proxy(ref IAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnRename_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_RemoteOnRename_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnRename_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_RemoteOnRename_Proxy(ref IAdviseSink This, ref IMoniker pmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnDataChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_RemoteOnDataChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        ///pFormatetc: FORMATETC*
        ///pStgmed: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnDataChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_RemoteOnDataChange_Proxy(ref IAdviseSink This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnClose_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_RemoteOnClose_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_RemoteOnClose_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_RemoteOnClose_Proxy(ref IAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        ///dwAspect: DWORD->unsigned int
        ///lindex: LONG->int
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnViewChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_OnViewChange_Stub(ref IAdviseSink This, uint dwAspect, int lindex);


        /// Return Type: void
        ///This: IAdviseSink*
        ///dwAspect: DWORD->unsigned int
        ///lindex: LONG->int
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnViewChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_OnViewChange_Proxy(ref IAdviseSink This, uint dwAspect, int lindex);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnSave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_OnSave_Stub(ref IAdviseSink This);


        /// Return Type: void
        ///This: IAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnSave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_OnSave_Proxy(ref IAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnRename_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_OnRename_Stub(ref IAdviseSink This, ref IMoniker pmk);


        /// Return Type: void
        ///This: IAdviseSink*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnRename_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_OnRename_Proxy(ref IAdviseSink This, ref IMoniker pmk);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        ///pFormatetc: FORMATETC*
        ///pStgmed: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnDataChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_OnDataChange_Stub(ref IAdviseSink This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);


        /// Return Type: void
        ///This: IAdviseSink*
        ///pFormatetc: FORMATETC*
        ///pStgmed: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnDataChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_OnDataChange_Proxy(ref IAdviseSink This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnClose_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink_OnClose_Stub(ref IAdviseSink This);


        /// Return Type: void
        ///This: IAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink_OnClose_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink_OnClose_Proxy(ref IAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink2_RemoteOnLinkSrcChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink2_RemoteOnLinkSrcChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink2*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink2_RemoteOnLinkSrcChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink2_RemoteOnLinkSrcChange_Proxy(ref IAdviseSink2 This, ref IMoniker pmk);


        /// Return Type: HRESULT->LONG->int
        ///This: IAdviseSink2*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink2_OnLinkSrcChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAdviseSink2_OnLinkSrcChange_Stub(ref IAdviseSink2 This, ref IMoniker pmk);


        /// Return Type: void
        ///This: IAdviseSink2*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IAdviseSink2_OnLinkSrcChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAdviseSink2_OnLinkSrcChange_Proxy(ref IAdviseSink2 This, ref IMoniker pmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAddrTrackingControl_EnableCOMDynamicAddrTracking_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAddrTrackingControl_EnableCOMDynamicAddrTracking_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAddrTrackingControl*
        [DllImport("<Unknown>", EntryPoint = "IAddrTrackingControl_EnableCOMDynamicAddrTracking_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAddrTrackingControl_EnableCOMDynamicAddrTracking_Proxy(ref IAddrTrackingControl This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAddrTrackingControl_DisableCOMDynamicAddrTracking_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAddrTrackingControl_DisableCOMDynamicAddrTracking_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAddrTrackingControl*
        [DllImport("<Unknown>", EntryPoint = "IAddrTrackingControl_DisableCOMDynamicAddrTracking_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAddrTrackingControl_DisableCOMDynamicAddrTracking_Proxy(ref IAddrTrackingControl This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAddrExclusionControl_UpdateAddrExclusionList_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAddrExclusionControl_UpdateAddrExclusionList_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAddrExclusionControl*
        ///pEnumerator: IUnknown*
        [DllImport("<Unknown>", EntryPoint = "IAddrExclusionControl_UpdateAddrExclusionList_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAddrExclusionControl_UpdateAddrExclusionList_Proxy(ref IAddrExclusionControl This, ref IUnknown pEnumerator);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IAddrExclusionControl_GetCurrentAddrExclusionList_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void IAddrExclusionControl_GetCurrentAddrExclusionList_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IAddrExclusionControl*
        ///riid: IID*
        ///ppEnumerator: void**
        [DllImport("<Unknown>", EntryPoint = "IAddrExclusionControl_GetCurrentAddrExclusionList_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int IAddrExclusionControl_GetCurrentAddrExclusionList_Proxy(ref IAddrExclusionControl This, ref GUID riid, ref IntPtr ppEnumerator);

    }

}
