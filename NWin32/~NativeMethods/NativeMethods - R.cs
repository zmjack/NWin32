using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: DWORD->unsigned int
        ///HeapHandle: PVOID->void*
        ///HeapInformationClass: HEAP_INFORMATION_CLASS->_HEAP_INFORMATION_CLASS
        ///HeapInformation: PVOID->void*
        ///HeapInformationLength: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "RtlSetHeapInformation", CallingConvention = CallingConvention.StdCall)]
        public static extern uint RtlSetHeapInformation(IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, IntPtr HeapInformation, uint HeapInformationLength);


        /// Return Type: DWORD->unsigned int
        ///HeapHandle: PVOID->void*
        ///HeapInformationClass: HEAP_INFORMATION_CLASS->_HEAP_INFORMATION_CLASS
        ///HeapInformation: PVOID->void*
        ///HeapInformationLength: SIZE_T->ULONG_PTR->unsigned int
        ///ReturnLength: PSIZE_T->ULONG_PTR*
        [DllImport("ntdll.dll", EntryPoint = "RtlQueryHeapInformation", CallingConvention = CallingConvention.StdCall)]
        public static extern uint RtlQueryHeapInformation(IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, IntPtr HeapInformation, uint HeapInformationLength, ref uint ReturnLength);


        /// Return Type: WORD->unsigned short
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("ntdll.dll", EntryPoint = "RtlQueryDepthSList", CallingConvention = CallingConvention.StdCall)]
        public static extern ushort RtlQueryDepthSList(ref SLIST_HEADER ListHead);


        /// Return Type: DWORD->unsigned int
        ///HeapHandle: PVOID->void*
        ///Flags: DWORD->unsigned int
        ///Count: DWORD->unsigned int
        ///Array: PVOID*
        [DllImport("ntdll.dll", EntryPoint = "RtlMultipleFreeHeap", CallingConvention = CallingConvention.StdCall)]
        public static extern uint RtlMultipleFreeHeap(IntPtr HeapHandle, uint Flags, uint Count, ref IntPtr Array);


        /// Return Type: DWORD->unsigned int
        ///HeapHandle: PVOID->void*
        ///Flags: DWORD->unsigned int
        ///Size: SIZE_T->ULONG_PTR->unsigned int
        ///Count: DWORD->unsigned int
        ///Array: PVOID*
        [DllImport("ntdll.dll", EntryPoint = "RtlMultipleAllocateHeap", CallingConvention = CallingConvention.StdCall)]
        public static extern uint RtlMultipleAllocateHeap(IntPtr HeapHandle, uint Flags, uint Size, uint Count, ref IntPtr Array);


        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        ///ListEntry: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        [DllImport("ntdll.dll", EntryPoint = "RtlInterlockedPushEntrySList", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RtlInterlockedPushEntrySList(ref SLIST_HEADER ListHead, ref SINGLE_LIST_ENTRY ListEntry);


        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("ntdll.dll", EntryPoint = "RtlInterlockedPopEntrySList", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RtlInterlockedPopEntrySList(ref SLIST_HEADER ListHead);


        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("ntdll.dll", EntryPoint = "RtlInterlockedFlushSList", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RtlInterlockedFlushSList(ref SLIST_HEADER ListHead);


        /// Return Type: void
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("ntdll.dll", EntryPoint = "RtlInitializeSListHead", CallingConvention = CallingConvention.StdCall)]
        public static extern void RtlInitializeSListHead(ref SLIST_HEADER ListHead);


        /// Return Type: PSINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY*
        ///ListHead: SLIST_HEADER*
        [DllImport("ntdll.dll", EntryPoint = "RtlFirstEntrySList", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RtlFirstEntrySList(ref SLIST_HEADER ListHead);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///Source1: void*
        ///Source2: void*
        ///Length: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "RtlCompareMemory", CallingConvention = CallingConvention.StdCall)]
        public static extern uint RtlCompareMemory(IntPtr Source1, IntPtr Source2, uint Length);


        /// Return Type: void
        ///ContextRecord: PCONTEXT->CONTEXT*
        [DllImport("kernel32.dll", EntryPoint = "RtlCaptureContext", CallingConvention = CallingConvention.StdCall)]
        public static extern void RtlCaptureContext(ref CONTEXT ContextRecord);


        /// Return Type: void
        ///Code: ULONG_PTR->unsigned int
        ///Message: PSTR->CHAR*
        ///Param1: ULONG_PTR->unsigned int
        ///Description1: PSTR->CHAR*
        ///Param2: ULONG_PTR->unsigned int
        ///Description2: PSTR->CHAR*
        ///Param3: ULONG_PTR->unsigned int
        ///Description3: PSTR->CHAR*
        ///Param4: ULONG_PTR->unsigned int
        ///Description4: PSTR->CHAR*
        [DllImport("ntdll.dll", EntryPoint = "RtlApplicationVerifierStop", CallingConvention = CallingConvention.StdCall)]
        public static extern void RtlApplicationVerifierStop(uint Code, [In] [MarshalAs(UnmanagedType.LPStr)] string Message, uint Param1, [In] [MarshalAs(UnmanagedType.LPStr)] string Description1, uint Param2, [In] [MarshalAs(UnmanagedType.LPStr)] string Description2, uint Param3, [In] [MarshalAs(UnmanagedType.LPStr)] string Description3, uint Param4, [In] [MarshalAs(UnmanagedType.LPStr)] string Description4);


        /// Return Type: void
        ///AsyncHandle: handle_t->RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///pBuffer: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcUserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcUserFree(IntPtr AsyncHandle, IntPtr pBuffer);


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcTestCancel", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcTestCancel();


        /// Return Type: RPC_STATUS->int
        ///String: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcStringFreeW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcStringFreeW(ref IntPtr String);


        /// Return Type: RPC_STATUS->int
        ///String: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcStringFreeA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcStringFreeA(ref IntPtr String);


        /// Return Type: RPC_STATUS->int
        ///StringBinding: RPC_WSTR->unsigned short*
        ///ObjUuid: RPC_WSTR*
        ///Protseq: RPC_WSTR*
        ///NetworkAddr: RPC_WSTR*
        ///Endpoint: RPC_WSTR*
        ///NetworkOptions: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcStringBindingParseW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcStringBindingParseW([In] ref ushort StringBinding, ref IntPtr ObjUuid, ref IntPtr Protseq, ref IntPtr NetworkAddr, ref IntPtr Endpoint, ref IntPtr NetworkOptions);


        /// Return Type: RPC_STATUS->int
        ///StringBinding: RPC_CSTR->unsigned char*
        ///ObjUuid: RPC_CSTR*
        ///Protseq: RPC_CSTR*
        ///NetworkAddr: RPC_CSTR*
        ///Endpoint: RPC_CSTR*
        ///NetworkOptions: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcStringBindingParseA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcStringBindingParseA([In] [MarshalAs(UnmanagedType.LPStr)] string StringBinding, ref IntPtr ObjUuid, ref IntPtr Protseq, ref IntPtr NetworkAddr, ref IntPtr Endpoint, ref IntPtr NetworkOptions);


        /// Return Type: RPC_STATUS->int
        ///ObjUuid: RPC_WSTR->unsigned short*
        ///Protseq: RPC_WSTR->unsigned short*
        ///NetworkAddr: RPC_WSTR->unsigned short*
        ///Endpoint: RPC_WSTR->unsigned short*
        ///Options: RPC_WSTR->unsigned short*
        ///StringBinding: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcStringBindingComposeW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcStringBindingComposeW([In] IntPtr ObjUuid, [In] IntPtr Protseq, [In] IntPtr NetworkAddr, [In] IntPtr Endpoint, [In] IntPtr Options, ref IntPtr StringBinding);


        /// Return Type: RPC_STATUS->int
        ///ObjUuid: RPC_CSTR->unsigned char*
        ///Protseq: RPC_CSTR->unsigned char*
        ///NetworkAddr: RPC_CSTR->unsigned char*
        ///Endpoint: RPC_CSTR->unsigned char*
        ///Options: RPC_CSTR->unsigned char*
        ///StringBinding: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcStringBindingComposeA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcStringBindingComposeA([In] [MarshalAs(UnmanagedType.LPStr)] string ObjUuid, [In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, [In] [MarshalAs(UnmanagedType.LPStr)] string NetworkAddr, [In] [MarshalAs(UnmanagedType.LPStr)] string Endpoint, [In] [MarshalAs(UnmanagedType.LPStr)] string Options, ref IntPtr StringBinding);


        /// Return Type: void
        ///ClientAlloc: RPC_CLIENT_ALLOC*
        ///ClientFree: RPC_CLIENT_FREE*
        ///OldClientAlloc: RPC_CLIENT_ALLOC**
        ///OldClientFree: RPC_CLIENT_FREE**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsSwapClientAllocFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsSwapClientAllocFree(ref RPC_CLIENT_ALLOC ClientAlloc, ref RPC_CLIENT_FREE ClientFree, ref IntPtr OldClientAlloc, ref IntPtr OldClientFree);


        /// Return Type: void
        ///Id: RPC_SS_THREAD_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsSetThreadHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsSetThreadHandle(IntPtr Id);


        /// Return Type: void
        ///ClientAlloc: RPC_CLIENT_ALLOC*
        ///ClientFree: RPC_CLIENT_FREE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsSetClientAllocFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsSetClientAllocFree(ref RPC_CLIENT_ALLOC ClientAlloc, ref RPC_CLIENT_FREE ClientFree);


        /// Return Type: RPC_SS_THREAD_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsGetThreadHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RpcSsGetThreadHandle();


        /// Return Type: RPC_STATUS->int
        ///ContextHandle: void*
        ///Binding: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsGetContextBinding", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSsGetContextBinding(IntPtr ContextHandle, ref IntPtr Binding);


        /// Return Type: void
        ///NodeToFree: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsFree(IntPtr NodeToFree);


        /// Return Type: void
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsEnableAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsEnableAllocate();


        /// Return Type: void
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsDontSerializeContext", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsDontSerializeContext();


        /// Return Type: void
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsDisableAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsDisableAllocate();


        /// Return Type: void
        ///ContextHandle: void**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsDestroyClientContext", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcSsDestroyClientContext(ref IntPtr ContextHandle);


        /// Return Type: RPC_STATUS->int
        ///ServerBindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///UserContext: PVOID->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsContextLockShared", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSsContextLockShared(IntPtr ServerBindingHandle, IntPtr UserContext);


        /// Return Type: RPC_STATUS->int
        ///ServerBindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///UserContext: PVOID->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsContextLockExclusive", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSsContextLockExclusive(IntPtr ServerBindingHandle, IntPtr UserContext);


        /// Return Type: void*
        ///Size: size_t->unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSsAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RpcSsAllocate([MarshalAs(UnmanagedType.SysUInt)] UIntPtr Size);


        /// Return Type: RPC_STATUS->int
        ///ClientAlloc: RPC_CLIENT_ALLOC*
        ///ClientFree: RPC_CLIENT_FREE*
        ///OldClientAlloc: RPC_CLIENT_ALLOC**
        ///OldClientFree: RPC_CLIENT_FREE**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmSwapClientAllocFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmSwapClientAllocFree(ref RPC_CLIENT_ALLOC ClientAlloc, ref RPC_CLIENT_FREE ClientFree, ref IntPtr OldClientAlloc, ref IntPtr OldClientFree);


        /// Return Type: RPC_STATUS->int
        ///Id: RPC_SS_THREAD_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmSetThreadHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmSetThreadHandle(IntPtr Id);


        /// Return Type: RPC_STATUS->int
        ///ClientAlloc: RPC_CLIENT_ALLOC*
        ///ClientFree: RPC_CLIENT_FREE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmSetClientAllocFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmSetClientAllocFree(ref RPC_CLIENT_ALLOC ClientAlloc, ref RPC_CLIENT_FREE ClientFree);


        /// Return Type: RPC_SS_THREAD_HANDLE->void*
        ///pStatus: RPC_STATUS*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmGetThreadHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RpcSmGetThreadHandle(ref int pStatus);


        /// Return Type: RPC_STATUS->int
        ///NodeToFree: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmFree(IntPtr NodeToFree);


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmEnableAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmEnableAllocate();


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmDisableAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmDisableAllocate();


        /// Return Type: RPC_STATUS->int
        ///ContextHandle: void**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmDestroyClientContext", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmDestroyClientContext(ref IntPtr ContextHandle);


        /// Return Type: RPC_STATUS->int
        ///pNodeToFree: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmClientFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcSmClientFree(IntPtr pNodeToFree);


        /// Return Type: void*
        ///Size: size_t->unsigned int
        ///pStatus: RPC_STATUS*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcSmAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr RpcSmAllocate([MarshalAs(UnmanagedType.SysUInt)] UIntPtr Size, ref int pStatus);


        /// Return Type: void
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerYield", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcServerYield();


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqW([In] ref ushort Protseq, uint MaxCalls, [In] IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqIfW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqIfW([In] ref ushort Protseq, uint MaxCalls, [In] IntPtr IfSpec, [In] IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqIfExW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqIfExW([In] ref ushort Protseq, uint MaxCalls, [In] IntPtr IfSpec, [In] IntPtr SecurityDescriptor, [In] ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqIfExA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqIfExA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] IntPtr IfSpec, [In] IntPtr SecurityDescriptor, [In] ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqIfA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqIfA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] IntPtr IfSpec, [In] IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqExW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqExW([In] ref ushort Protseq, uint MaxCalls, [In] IntPtr SecurityDescriptor, [In] ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqExA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqExA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] IntPtr SecurityDescriptor, [In] ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///Endpoint: RPC_WSTR->unsigned short*
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqEpW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqEpW([In] ref ushort Protseq, uint MaxCalls, [In] ref ushort Endpoint, [In] IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        ///MaxCalls: unsigned int
        ///Endpoint: RPC_WSTR->unsigned short*
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqEpExW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqEpExW([In] ref ushort Protseq, uint MaxCalls, [In] ref ushort Endpoint, [In] IntPtr SecurityDescriptor, [In] ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///Endpoint: RPC_CSTR->unsigned char*
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqEpExA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqEpExA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] [MarshalAs(UnmanagedType.LPStr)] string Endpoint, [In] IntPtr SecurityDescriptor, [In] ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///Endpoint: RPC_CSTR->unsigned char*
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqEpA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqEpA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] [MarshalAs(UnmanagedType.LPStr)] string Endpoint, [In] IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseProtseqA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseProtseqA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq, uint MaxCalls, [In] IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///MaxCalls: unsigned int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseAllProtseqsIfEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseAllProtseqsIfEx(uint MaxCalls, IntPtr IfSpec, IntPtr SecurityDescriptor, ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///MaxCalls: unsigned int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseAllProtseqsIf", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseAllProtseqsIf(uint MaxCalls, IntPtr IfSpec, IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        ///Policy: PRPC_POLICY->_RPC_POLICY*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseAllProtseqsEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseAllProtseqsEx(uint MaxCalls, IntPtr SecurityDescriptor, ref RPC_POLICY Policy);


        /// Return Type: RPC_STATUS->int
        ///MaxCalls: unsigned int
        ///SecurityDescriptor: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUseAllProtseqs", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUseAllProtseqs(uint MaxCalls, IntPtr SecurityDescriptor);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///MgrTypeUuid: UUID*
        ///RundownContextHandles: int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUnregisterIfEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUnregisterIfEx(IntPtr IfSpec, ref GUID MgrTypeUuid, int RundownContextHandles);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///MgrTypeUuid: UUID*
        ///WaitForCallsToComplete: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerUnregisterIf", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerUnregisterIf(IntPtr IfSpec, ref GUID MgrTypeUuid, uint WaitForCallsToComplete);


        /// Return Type: RPC_STATUS->int
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerTestCancel", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerTestCancel(IntPtr BindingHandle);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///MgrTypeUuid: UUID*
        ///MgrEpv: void*
        ///Flags: unsigned int
        ///MaxCalls: unsigned int
        ///IfCallback: RPC_IF_CALLBACK_FN*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerRegisterIfEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerRegisterIfEx(IntPtr IfSpec, ref GUID MgrTypeUuid, IntPtr MgrEpv, uint Flags, uint MaxCalls, ref RPC_IF_CALLBACK_FN IfCallback);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///MgrTypeUuid: UUID*
        ///MgrEpv: void*
        ///Flags: unsigned int
        ///MaxCalls: unsigned int
        ///MaxRpcSize: unsigned int
        ///IfCallbackFn: RPC_IF_CALLBACK_FN*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerRegisterIf2", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerRegisterIf2(IntPtr IfSpec, ref GUID MgrTypeUuid, IntPtr MgrEpv, uint Flags, uint MaxCalls, uint MaxRpcSize, ref RPC_IF_CALLBACK_FN IfCallbackFn);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///MgrTypeUuid: UUID*
        ///MgrEpv: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerRegisterIf", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerRegisterIf(IntPtr IfSpec, ref GUID MgrTypeUuid, IntPtr MgrEpv);


        /// Return Type: RPC_STATUS->int
        ///ServerPrincName: RPC_WSTR->unsigned short*
        ///AuthnSvc: unsigned int
        ///GetKeyFn: RPC_AUTH_KEY_RETRIEVAL_FN
        ///Arg: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerRegisterAuthInfoW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerRegisterAuthInfoW([In] ref ushort ServerPrincName, uint AuthnSvc, RPC_AUTH_KEY_RETRIEVAL_FN GetKeyFn, [In] IntPtr Arg);


        /// Return Type: RPC_STATUS->int
        ///ServerPrincName: RPC_CSTR->unsigned char*
        ///AuthnSvc: unsigned int
        ///GetKeyFn: RPC_AUTH_KEY_RETRIEVAL_FN
        ///Arg: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerRegisterAuthInfoA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerRegisterAuthInfoA([In] [MarshalAs(UnmanagedType.LPStr)] string ServerPrincName, uint AuthnSvc, RPC_AUTH_KEY_RETRIEVAL_FN GetKeyFn, [In] IntPtr Arg);


        /// Return Type: RPC_STATUS->int
        ///MinimumCallThreads: unsigned int
        ///MaxCalls: unsigned int
        ///DontWait: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerListen", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerListen(uint MinimumCallThreads, uint MaxCalls, uint DontWait);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///MgrTypeUuid: UUID*
        ///MgrEpv: void**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerInqIf", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerInqIf(IntPtr IfSpec, ref GUID MgrTypeUuid, ref IntPtr MgrEpv);


        /// Return Type: RPC_STATUS->int
        ///AuthnSvc: unsigned int
        ///PrincName: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerInqDefaultPrincNameW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerInqDefaultPrincNameW(uint AuthnSvc, out IntPtr PrincName);


        /// Return Type: RPC_STATUS->int
        ///AuthnSvc: unsigned int
        ///PrincName: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerInqDefaultPrincNameA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerInqDefaultPrincNameA(uint AuthnSvc, out IntPtr PrincName);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///RpcCallAttributes: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerInqCallAttributesW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerInqCallAttributesW(IntPtr ClientBinding, IntPtr RpcCallAttributes);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///RpcCallAttributes: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerInqCallAttributesA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerInqCallAttributesA(IntPtr ClientBinding, IntPtr RpcCallAttributes);


        /// Return Type: RPC_STATUS->int
        ///BindingVector: RPC_BINDING_VECTOR**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcServerInqBindings", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcServerInqBindings(ref IntPtr BindingVector);


        /// Return Type: RPC_STATUS->int
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcRevertToSelfEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcRevertToSelfEx(IntPtr BindingHandle);


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcRevertToSelf", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcRevertToSelf();


        /// Return Type: void
        ///exception: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcRaiseException", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcRaiseException(int exception);


        /// Return Type: RPC_STATUS->int
        ///ProtseqVector: RPC_PROTSEQ_VECTORW**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcProtseqVectorFreeW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcProtseqVectorFreeW(ref IntPtr ProtseqVector);


        /// Return Type: RPC_STATUS->int
        ///ProtseqVector: RPC_PROTSEQ_VECTORA**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcProtseqVectorFreeA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcProtseqVectorFreeA(ref IntPtr ProtseqVector);


        /// Return Type: RPC_STATUS->int
        ///ObjUuid: UUID*
        ///TypeUuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcObjectSetType", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcObjectSetType(ref GUID ObjUuid, ref GUID TypeUuid);


        /// Return Type: RPC_STATUS->int
        ///InquiryFn: RPC_OBJECT_INQ_FN*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcObjectSetInqFn", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcObjectSetInqFn(ref RPC_OBJECT_INQ_FN InquiryFn);


        /// Return Type: RPC_STATUS->int
        ///ObjUuid: UUID*
        ///TypeUuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcObjectInqType", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcObjectInqType(ref GUID ObjUuid, ref GUID TypeUuid);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_WSTR->unsigned short*
        ///IfId: RPC_IF_ID*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltRemoveW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltRemoveW(uint ProfileNameSyntax, [In] ref ushort ProfileName, [In] IntPtr IfId, uint MemberNameSyntax, [In] ref ushort MemberName);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_CSTR->unsigned char*
        ///IfId: RPC_IF_ID*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltRemoveA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltRemoveA(uint ProfileNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string ProfileName, [In] IntPtr IfId, uint MemberNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string MemberName);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE->void*
        ///IfId: RPC_IF_ID*
        ///MemberName: RPC_WSTR*
        ///Priority: unsigned int*
        ///Annotation: RPC_WSTR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltInqNextW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltInqNextW([In] IntPtr InquiryContext, IntPtr IfId, ref IntPtr MemberName, [Out] out uint Priority, ref IntPtr Annotation);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE->void*
        ///IfId: RPC_IF_ID*
        ///MemberName: RPC_CSTR*
        ///Priority: unsigned int*
        ///Annotation: RPC_CSTR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltInqNextA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltInqNextA([In] IntPtr InquiryContext, IntPtr IfId, ref IntPtr MemberName, [Out] out uint Priority, ref IntPtr Annotation);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltInqDone", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltInqDone(ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_WSTR->unsigned short*
        ///InquiryType: unsigned int
        ///IfId: RPC_IF_ID*
        ///VersOption: unsigned int
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_WSTR->unsigned short*
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltInqBeginW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltInqBeginW(uint ProfileNameSyntax, [In] ref ushort ProfileName, uint InquiryType, [In] IntPtr IfId, uint VersOption, uint MemberNameSyntax, [In] IntPtr MemberName, ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_CSTR->unsigned char*
        ///InquiryType: unsigned int
        ///IfId: RPC_IF_ID*
        ///VersOption: unsigned int
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_CSTR->unsigned char*
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltInqBeginA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltInqBeginA(uint ProfileNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string ProfileName, uint InquiryType, [In] IntPtr IfId, uint VersOption, uint MemberNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string MemberName, ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_WSTR->unsigned short*
        ///IfId: RPC_IF_ID*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_WSTR->unsigned short*
        ///Priority: unsigned int
        ///Annotation: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltAddW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltAddW(uint ProfileNameSyntax, [In] ref ushort ProfileName, [In] IntPtr IfId, uint MemberNameSyntax, [In] ref ushort MemberName, uint Priority, [In] IntPtr Annotation);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_CSTR->unsigned char*
        ///IfId: RPC_IF_ID*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_CSTR->unsigned char*
        ///Priority: unsigned int
        ///Annotation: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileEltAddA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileEltAddA(uint ProfileNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string ProfileName, [In] IntPtr IfId, uint MemberNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string MemberName, uint Priority, [In] [MarshalAs(UnmanagedType.LPStr)] string Annotation);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileDeleteW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileDeleteW(uint ProfileNameSyntax, [In] ref ushort ProfileName);


        /// Return Type: RPC_STATUS->int
        ///ProfileNameSyntax: unsigned int
        ///ProfileName: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsProfileDeleteA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsProfileDeleteA(uint ProfileNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string ProfileName);


        /// Return Type: RPC_STATUS->int
        ///ExpirationAge: unsigned int
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtSetExpAge", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtSetExpAge(uint ExpirationAge);


        /// Return Type: RPC_STATUS->int
        ///ExpirationAge: unsigned int*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtInqExpAge", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtInqExpAge(ref uint ExpirationAge);


        /// Return Type: RPC_STATUS->int
        ///NsHandle: RPC_NS_HANDLE->void*
        ///ExpirationAge: unsigned int
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtHandleSetExpAge", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtHandleSetExpAge(IntPtr NsHandle, uint ExpirationAge);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfIdVec: RPC_IF_ID_VECTOR**
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtEntryInqIfIdsW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtEntryInqIfIdsW(uint EntryNameSyntax, [In] ref ushort EntryName, ref IntPtr IfIdVec);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfIdVec: RPC_IF_ID_VECTOR**
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtEntryInqIfIdsA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtEntryInqIfIdsA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, ref IntPtr IfIdVec);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtEntryDeleteW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtEntryDeleteW(uint EntryNameSyntax, [In] ref ushort EntryName);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtEntryDeleteA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtEntryDeleteA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtEntryCreateW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtEntryCreateW(uint EntryNameSyntax, [In] ref ushort EntryName);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtEntryCreateA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtEntryCreateA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfId: RPC_IF_ID*
        ///VersOption: unsigned int
        ///ObjectUuidVec: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtBindingUnexportW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtBindingUnexportW(uint EntryNameSyntax, [In] ref ushort EntryName, [In] IntPtr IfId, uint VersOption, [In] IntPtr ObjectUuidVec);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfId: RPC_IF_ID*
        ///VersOption: unsigned int
        ///ObjectUuidVec: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsMgmtBindingUnexportA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsMgmtBindingUnexportA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, [In] IntPtr IfId, uint VersOption, [In] IntPtr ObjectUuidVec);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_WSTR->unsigned short*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrRemoveW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrRemoveW(uint GroupNameSyntax, [In] ref ushort GroupName, uint MemberNameSyntax, [In] ref ushort MemberName);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_CSTR->unsigned char*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrRemoveA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrRemoveA(uint GroupNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string GroupName, uint MemberNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string MemberName);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE->void*
        ///MemberName: RPC_WSTR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrInqNextW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrInqNextW(IntPtr InquiryContext, out IntPtr MemberName);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE->void*
        ///MemberName: RPC_CSTR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrInqNextA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrInqNextA(IntPtr InquiryContext, out IntPtr MemberName);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrInqDone", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrInqDone(ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_WSTR->unsigned short*
        ///MemberNameSyntax: unsigned int
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrInqBeginW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrInqBeginW(uint GroupNameSyntax, [In] ref ushort GroupName, uint MemberNameSyntax, ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_CSTR->unsigned char*
        ///MemberNameSyntax: unsigned int
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrInqBeginA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrInqBeginA(uint GroupNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string GroupName, uint MemberNameSyntax, ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_WSTR->unsigned short*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrAddW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrAddW(uint GroupNameSyntax, [In] ref ushort GroupName, uint MemberNameSyntax, [In] ref ushort MemberName);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_CSTR->unsigned char*
        ///MemberNameSyntax: unsigned int
        ///MemberName: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupMbrAddA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupMbrAddA(uint GroupNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string GroupName, uint MemberNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string MemberName);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_WSTR->unsigned short*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupDeleteW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupDeleteW(uint GroupNameSyntax, [In] IntPtr GroupName);


        /// Return Type: RPC_STATUS->int
        ///GroupNameSyntax: unsigned int
        ///GroupName: RPC_CSTR->unsigned char*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsGroupDeleteA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsGroupDeleteA(uint GroupNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string GroupName);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE->void*
        ///ObjUuid: UUID*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsEntryObjectInqNext", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsEntryObjectInqNext(IntPtr InquiryContext, ref GUID ObjUuid);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsEntryObjectInqDone", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsEntryObjectInqDone(ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsEntryObjectInqBeginW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsEntryObjectInqBeginW(uint EntryNameSyntax, [In] ref ushort EntryName, ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///InquiryContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsEntryObjectInqBeginA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsEntryObjectInqBeginA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///ExpandedName: RPC_WSTR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsEntryExpandNameW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsEntryExpandNameW(uint EntryNameSyntax, [In] ref ushort EntryName, ref IntPtr ExpandedName);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///ExpandedName: RPC_CSTR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsEntryExpandNameA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsEntryExpandNameA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, ref IntPtr ExpandedName);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjectUuidVec: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingUnexportW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingUnexportW(uint EntryNameSyntax, [In] IntPtr EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjectUuidVec);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjectVector: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingUnexportPnPW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingUnexportPnPW(uint EntryNameSyntax, [In] IntPtr EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjectVector);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjectVector: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingUnexportPnPA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingUnexportPnPA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjectVector);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjectUuidVec: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingUnexportA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingUnexportA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjectUuidVec);


        /// Return Type: RPC_STATUS->int
        ///BindingVec: RPC_BINDING_VECTOR*
        ///Binding: RPC_BINDING_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingSelect", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingSelect(ref RPC_BINDING_VECTOR BindingVec, ref IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///LookupContext: RPC_NS_HANDLE->void*
        ///BindingVec: RPC_BINDING_VECTOR**
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingLookupNext", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingLookupNext(IntPtr LookupContext, ref IntPtr BindingVec);


        /// Return Type: RPC_STATUS->int
        ///LookupContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingLookupDone", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingLookupDone(ref IntPtr LookupContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjUuid: UUID*
        ///BindingMaxCount: unsigned int
        ///LookupContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingLookupBeginW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingLookupBeginW(uint EntryNameSyntax, [In] IntPtr EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjUuid, uint BindingMaxCount, ref IntPtr LookupContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjUuid: UUID*
        ///BindingMaxCount: unsigned int
        ///LookupContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingLookupBeginA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingLookupBeginA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjUuid, uint BindingMaxCount, ref IntPtr LookupContext);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcNsBindingInqEntryNameW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingInqEntryNameW([In] IntPtr Binding, uint EntryNameSyntax, out IntPtr EntryName);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcNsBindingInqEntryNameA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingInqEntryNameA([In] IntPtr Binding, uint EntryNameSyntax, out IntPtr EntryName);


        /// Return Type: RPC_STATUS->int
        ///ImportContext: RPC_NS_HANDLE->void*
        ///Binding: RPC_BINDING_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingImportNext", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingImportNext(IntPtr ImportContext, ref IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///ImportContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingImportDone", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingImportDone(ref IntPtr ImportContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjUuid: UUID*
        ///ImportContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingImportBeginW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingImportBeginW(uint EntryNameSyntax, [In] IntPtr EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjUuid, ref IntPtr ImportContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjUuid: UUID*
        ///ImportContext: RPC_NS_HANDLE*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingImportBeginA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingImportBeginA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjUuid, ref IntPtr ImportContext);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///BindingVec: RPC_BINDING_VECTOR*
        ///ObjectUuidVec: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingExportW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingExportW(uint EntryNameSyntax, [In] IntPtr EntryName, [In] IntPtr IfSpec, [In] IntPtr BindingVec, [In] IntPtr ObjectUuidVec);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_WSTR->unsigned short*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjectVector: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingExportPnPW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingExportPnPW(uint EntryNameSyntax, [In] IntPtr EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjectVector);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///ObjectVector: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingExportPnPA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingExportPnPA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, [In] IntPtr IfSpec, [In] IntPtr ObjectVector);


        /// Return Type: RPC_STATUS->int
        ///EntryNameSyntax: unsigned int
        ///EntryName: RPC_CSTR->unsigned char*
        ///IfSpec: RPC_IF_HANDLE->void*
        ///BindingVec: RPC_BINDING_VECTOR*
        ///ObjectUuidVec: UUID_VECTOR*
        [DllImport("rpcns4.dll", EntryPoint = "RpcNsBindingExportA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNsBindingExportA(uint EntryNameSyntax, [In] [MarshalAs(UnmanagedType.LPStr)] string EntryName, [In] IntPtr IfSpec, [In] IntPtr BindingVec, [In] IntPtr ObjectUuidVec);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_WSTR->unsigned short*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcNetworkIsProtseqValidW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNetworkIsProtseqValidW([In] ref ushort Protseq);


        /// Return Type: RPC_STATUS->int
        ///Protseq: RPC_CSTR->unsigned char*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcNetworkIsProtseqValidA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNetworkIsProtseqValidA([In] [MarshalAs(UnmanagedType.LPStr)] string Protseq);


        /// Return Type: RPC_STATUS->int
        ///ProtseqVector: RPC_PROTSEQ_VECTORW**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcNetworkInqProtseqsW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNetworkInqProtseqsW(ref IntPtr ProtseqVector);


        /// Return Type: RPC_STATUS->int
        ///ProtseqVector: RPC_PROTSEQ_VECTORA**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcNetworkInqProtseqsA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcNetworkInqProtseqsA(ref IntPtr ProtseqVector);


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtWaitServerListen", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtWaitServerListen();


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtStopServerListening", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtStopServerListening(IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///StatsVector: RPC_STATS_VECTOR**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtStatsVectorFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtStatsVectorFree(ref IntPtr StatsVector);


        /// Return Type: RPC_STATUS->int
        ///ThreadStackSize: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtSetServerStackSize", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtSetServerStackSize(uint ThreadStackSize);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Timeout: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtSetComTimeout", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtSetComTimeout(IntPtr Binding, uint Timeout);


        /// Return Type: RPC_STATUS->int
        ///Timeout: int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtSetCancelTimeout", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtSetCancelTimeout(int Timeout);


        /// Return Type: RPC_STATUS->int
        ///AuthorizationFn: RPC_MGMT_AUTHORIZATION_FN
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtSetAuthorizationFn", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtSetAuthorizationFn(RPC_MGMT_AUTHORIZATION_FN AuthorizationFn);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtIsServerListening", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtIsServerListening(IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Statistics: RPC_STATS_VECTOR**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtInqStats", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtInqStats(IntPtr Binding, ref IntPtr Statistics);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///AuthnSvc: unsigned int
        ///ServerPrincName: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtInqServerPrincNameW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtInqServerPrincNameW([In] IntPtr Binding, uint AuthnSvc, out IntPtr ServerPrincName);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///AuthnSvc: unsigned int
        ///ServerPrincName: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtInqServerPrincNameA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtInqServerPrincNameA([In] IntPtr Binding, uint AuthnSvc, out IntPtr ServerPrincName);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///IfIdVector: RPC_IF_ID_VECTOR**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtInqIfIds", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtInqIfIds(IntPtr Binding, ref IntPtr IfIdVector);


        /// Return Type: RPC_STATUS->int
        ///AuthnSvc: unsigned int
        ///AuthnLevel: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtInqDefaultProtectLevel", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtInqDefaultProtectLevel(uint AuthnSvc, ref uint AuthnLevel);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Timeout: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtInqComTimeout", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtInqComTimeout(IntPtr Binding, ref uint Timeout);


        /// Return Type: RPC_STATUS->int
        ///EpBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///IfId: RPC_IF_ID*
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ObjectUuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtEpUnregister", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtEpUnregister(IntPtr EpBinding, ref RPC_IF_ID IfId, IntPtr Binding, ref GUID ObjectUuid);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_EP_INQ_HANDLE->I_RPC_HANDLE*
        ///IfId: RPC_IF_ID*
        ///Binding: RPC_BINDING_HANDLE*
        ///ObjectUuid: UUID*
        ///Annotation: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtEpEltInqNextW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtEpEltInqNextW([In] IntPtr InquiryContext, [Out] out RPC_IF_ID IfId, ref IntPtr Binding, IntPtr ObjectUuid, ref IntPtr Annotation);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_EP_INQ_HANDLE->I_RPC_HANDLE*
        ///IfId: RPC_IF_ID*
        ///Binding: RPC_BINDING_HANDLE*
        ///ObjectUuid: UUID*
        ///Annotation: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtEpEltInqNextA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtEpEltInqNextA([In] IntPtr InquiryContext, [Out] out RPC_IF_ID IfId, ref IntPtr Binding, IntPtr ObjectUuid, ref IntPtr Annotation);


        /// Return Type: RPC_STATUS->int
        ///InquiryContext: RPC_EP_INQ_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtEpEltInqDone", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtEpEltInqDone(ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        ///EpBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///InquiryType: unsigned int
        ///IfId: RPC_IF_ID*
        ///VersOption: unsigned int
        ///ObjectUuid: UUID*
        ///InquiryContext: RPC_EP_INQ_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtEpEltInqBegin", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtEpEltInqBegin(IntPtr EpBinding, uint InquiryType, ref RPC_IF_ID IfId, uint VersOption, ref GUID ObjectUuid, ref IntPtr InquiryContext);


        /// Return Type: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcMgmtEnableIdleCleanup", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcMgmtEnableIdleCleanup();


        /// Return Type: RPC_STATUS->int
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcImpersonateClient", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcImpersonateClient(IntPtr BindingHandle);


        /// Return Type: RPC_STATUS->int
        ///RpcIfHandle: RPC_IF_HANDLE->void*
        ///RpcIfId: RPC_IF_ID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcIfInqId", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcIfInqId(IntPtr RpcIfHandle, ref RPC_IF_ID RpcIfId);


        /// Return Type: RPC_STATUS->int
        ///IfIdVector: RPC_IF_ID_VECTOR**
        [DllImport("rpcns4.dll", EntryPoint = "RpcIfIdVectorFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcIfIdVectorFree(ref IntPtr IfIdVector);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ImpersonateOnReturn: BOOL->int
        ///Reserved1: PVOID->void*
        ///pExpirationTime: PLARGE_INTEGER->LARGE_INTEGER*
        ///Reserved2: LUID->_LUID
        ///Reserved3: DWORD->unsigned int
        ///Reserved4: PVOID->void*
        ///pAuthzClientContext: PVOID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcGetAuthorizationContextForClient", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcGetAuthorizationContextForClient(IntPtr ClientBinding, [MarshalAs(UnmanagedType.Bool)] bool ImpersonateOnReturn, IntPtr Reserved1, ref LARGE_INTEGER pExpirationTime, LUID Reserved2, uint Reserved3, IntPtr Reserved4, ref IntPtr pAuthzClientContext);


        /// Return Type: RPC_STATUS->int
        ///pAuthzClientContext: PVOID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcFreeAuthorizationContext", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcFreeAuthorizationContext(ref IntPtr pAuthzClientContext);


        /// Return Type: RPC_STATUS->int
        ///EnumHandle: RPC_ERROR_ENUM_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorStartEnumeration", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorStartEnumeration(ref tagRPC_ERROR_ENUM_HANDLE EnumHandle);


        /// Return Type: RPC_STATUS->int
        ///EnumHandle: RPC_ERROR_ENUM_HANDLE*
        ///ErrorBlob: PVOID*
        ///BlobSize: size_t*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorSaveErrorInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorSaveErrorInfo(ref tagRPC_ERROR_ENUM_HANDLE EnumHandle, ref IntPtr ErrorBlob, ref uint BlobSize);


        /// Return Type: RPC_STATUS->int
        ///EnumHandle: RPC_ERROR_ENUM_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorResetEnumeration", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorResetEnumeration(ref tagRPC_ERROR_ENUM_HANDLE EnumHandle);


        /// Return Type: RPC_STATUS->int
        ///ErrorBlob: PVOID->void*
        ///BlobSize: size_t->unsigned int
        ///EnumHandle: RPC_ERROR_ENUM_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorLoadErrorInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorLoadErrorInfo(IntPtr ErrorBlob, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr BlobSize, ref tagRPC_ERROR_ENUM_HANDLE EnumHandle);


        /// Return Type: RPC_STATUS->int
        ///EnumHandle: RPC_ERROR_ENUM_HANDLE*
        ///Records: int*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorGetNumberOfRecords", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorGetNumberOfRecords(ref tagRPC_ERROR_ENUM_HANDLE EnumHandle, ref int Records);


        /// Return Type: RPC_STATUS->int
        ///EnumHandle: RPC_ERROR_ENUM_HANDLE*
        ///CopyStrings: BOOL->int
        ///ErrorInfo: RPC_EXTENDED_ERROR_INFO*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorGetNextRecord", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorGetNextRecord(ref tagRPC_ERROR_ENUM_HANDLE EnumHandle, [MarshalAs(UnmanagedType.Bool)] bool CopyStrings, ref tagRPC_EXTENDED_ERROR_INFO ErrorInfo);


        /// Return Type: RPC_STATUS->int
        ///EnumHandle: RPC_ERROR_ENUM_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorEndEnumeration", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorEndEnumeration(ref tagRPC_ERROR_ENUM_HANDLE EnumHandle);


        /// Return Type: void
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorClearInformation", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcErrorClearInformation();


        /// Return Type: RPC_STATUS->int
        ///ErrorInfo: RPC_EXTENDED_ERROR_INFO*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcErrorAddRecord", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcErrorAddRecord(ref tagRPC_EXTENDED_ERROR_INFO ErrorInfo);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///BindingVector: RPC_BINDING_VECTOR*
        ///UuidVector: UUID_VECTOR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcEpUnregister", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcEpUnregister(IntPtr IfSpec, ref RPC_BINDING_VECTOR BindingVector, ref UUID_VECTOR UuidVector);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///IfSpec: RPC_IF_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcEpResolveBinding", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcEpResolveBinding(IntPtr Binding, IntPtr IfSpec);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///BindingVector: RPC_BINDING_VECTOR*
        ///UuidVector: UUID_VECTOR*
        ///Annotation: RPC_WSTR->unsigned short*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcEpRegisterW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcEpRegisterW([In] IntPtr IfSpec, [In] ref RPC_BINDING_VECTOR BindingVector, [In] IntPtr UuidVector, [In] IntPtr Annotation);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///BindingVector: RPC_BINDING_VECTOR*
        ///UuidVector: UUID_VECTOR*
        ///Annotation: RPC_WSTR->unsigned short*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcEpRegisterNoReplaceW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcEpRegisterNoReplaceW([In] IntPtr IfSpec, [In] ref RPC_BINDING_VECTOR BindingVector, [In] IntPtr UuidVector, [In] IntPtr Annotation);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///BindingVector: RPC_BINDING_VECTOR*
        ///UuidVector: UUID_VECTOR*
        ///Annotation: RPC_CSTR->unsigned char*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcEpRegisterNoReplaceA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcEpRegisterNoReplaceA([In] IntPtr IfSpec, [In] ref RPC_BINDING_VECTOR BindingVector, [In] IntPtr UuidVector, [In] [MarshalAs(UnmanagedType.LPStr)] string Annotation);


        /// Return Type: RPC_STATUS->int
        ///IfSpec: RPC_IF_HANDLE->void*
        ///BindingVector: RPC_BINDING_VECTOR*
        ///UuidVector: UUID_VECTOR*
        ///Annotation: RPC_CSTR->unsigned char*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcEpRegisterA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcEpRegisterA([In] IntPtr IfSpec, [In] ref RPC_BINDING_VECTOR BindingVector, [In] IntPtr UuidVector, [In] [MarshalAs(UnmanagedType.LPStr)] string Annotation);


        /// Return Type: void
        ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///fServerSide: int
        ///pulSendingTag: unsigned int*
        ///pulDesiredReceivingTag: unsigned int*
        ///pulReceivingTag: unsigned int*
        ///pStatus: error_status_t*
        [DllImport("<Unknown>", EntryPoint = "RpcCsGetTags", CallingConvention = CallingConvention.StdCall)]
        public static extern void RpcCsGetTags(IntPtr hBinding, int fServerSide, ref uint pulSendingTag, ref uint pulDesiredReceivingTag, ref uint pulReceivingTag, ref uint pStatus);


        /// Return Type: RPC_STATUS->int
        ///Thread: void*
        ///Timeout: int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcCancelThreadEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcCancelThreadEx(IntPtr Thread, int Timeout);


        /// Return Type: RPC_STATUS->int
        ///Thread: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcCancelThread", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcCancelThread(IntPtr Thread);


        /// Return Type: RPC_STATUS->int
        ///BindingVector: RPC_BINDING_VECTOR**
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingVectorFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingVectorFree(ref IntPtr BindingVector);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///StringBinding: RPC_WSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingToStringBindingW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingToStringBindingW([In] IntPtr Binding, out IntPtr StringBinding);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///StringBinding: RPC_CSTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingToStringBindingA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingToStringBindingA([In] IntPtr Binding, out IntPtr StringBinding);


        /// Return Type: RPC_STATUS->int
        ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///option: unsigned int
        ///optionValue: ULONG_PTR->unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingSetOption", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingSetOption(IntPtr hBinding, uint option, uint optionValue);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ObjectUuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingSetObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingSetObject(IntPtr Binding, ref GUID ObjectUuid);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_WSTR->unsigned short*
        ///AuthnLevel: unsigned int
        ///AuthnSvc: unsigned int
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE->void*
        ///AuthzSvc: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingSetAuthInfoW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingSetAuthInfoW([In] IntPtr Binding, [In] ref ushort ServerPrincName, uint AuthnLevel, uint AuthnSvc, [In] IntPtr AuthIdentity, uint AuthzSvc);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_WSTR->unsigned short*
        ///AuthnLevel: unsigned int
        ///AuthnSvc: unsigned int
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE->void*
        ///AuthzSvc: unsigned int
        ///SecurityQOS: RPC_SECURITY_QOS*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingSetAuthInfoExW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingSetAuthInfoExW([In] IntPtr Binding, [In] ref ushort ServerPrincName, uint AuthnLevel, uint AuthnSvc, [In] IntPtr AuthIdentity, uint AuthzSvc, [In] IntPtr SecurityQOS);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_CSTR->unsigned char*
        ///AuthnLevel: unsigned int
        ///AuthnSvc: unsigned int
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE->void*
        ///AuthzSvc: unsigned int
        ///SecurityQos: RPC_SECURITY_QOS*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingSetAuthInfoExA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingSetAuthInfoExA([In] IntPtr Binding, [In] [MarshalAs(UnmanagedType.LPStr)] string ServerPrincName, uint AuthnLevel, uint AuthnSvc, [In] IntPtr AuthIdentity, uint AuthzSvc, [In] IntPtr SecurityQos);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_CSTR->unsigned char*
        ///AuthnLevel: unsigned int
        ///AuthnSvc: unsigned int
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE->void*
        ///AuthzSvc: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingSetAuthInfoA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingSetAuthInfoA([In] IntPtr Binding, [In] [MarshalAs(UnmanagedType.LPStr)] string ServerPrincName, uint AuthnLevel, uint AuthnSvc, [In] IntPtr AuthIdentity, uint AuthzSvc);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerBinding: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingServerFromClient", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingServerFromClient(IntPtr ClientBinding, ref IntPtr ServerBinding);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingReset", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingReset(IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///option: unsigned int
        ///pOptionValue: ULONG_PTR*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqOption", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqOption(IntPtr hBinding, uint option, ref uint pOptionValue);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ObjectUuid: UUID*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqObject(IntPtr Binding, ref GUID ObjectUuid);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_WSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE*
        ///AuthzSvc: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthInfoW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthInfoW([In] IntPtr Binding, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, ref IntPtr AuthIdentity, IntPtr AuthzSvc);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_WSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE*
        ///AuthzSvc: unsigned int*
        ///RpcQosVersion: unsigned int
        ///SecurityQOS: RPC_SECURITY_QOS*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthInfoExW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthInfoExW([In] IntPtr Binding, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, ref IntPtr AuthIdentity, IntPtr AuthzSvc, uint RpcQosVersion, IntPtr SecurityQOS);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_CSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE*
        ///AuthzSvc: unsigned int*
        ///RpcQosVersion: unsigned int
        ///SecurityQOS: RPC_SECURITY_QOS*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthInfoExA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthInfoExA([In] IntPtr Binding, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, ref IntPtr AuthIdentity, IntPtr AuthzSvc, uint RpcQosVersion, IntPtr SecurityQOS);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///ServerPrincName: RPC_CSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthIdentity: RPC_AUTH_IDENTITY_HANDLE*
        ///AuthzSvc: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthInfoA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthInfoA([In] IntPtr Binding, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, ref IntPtr AuthIdentity, IntPtr AuthzSvc);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Privs: RPC_AUTHZ_HANDLE*
        ///ServerPrincName: RPC_WSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthzSvc: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthClientW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthClientW([In] IntPtr ClientBinding, ref IntPtr Privs, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, IntPtr AuthzSvc);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Privs: RPC_AUTHZ_HANDLE*
        ///ServerPrincName: RPC_WSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthzSvc: unsigned int*
        ///Flags: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthClientExW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthClientExW([In] IntPtr ClientBinding, ref IntPtr Privs, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, IntPtr AuthzSvc, uint Flags);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Privs: RPC_AUTHZ_HANDLE*
        ///ServerPrincName: RPC_CSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthzSvc: unsigned int*
        ///Flags: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthClientExA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthClientExA([In] IntPtr ClientBinding, ref IntPtr Privs, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, IntPtr AuthzSvc, uint Flags);


        /// Return Type: RPC_STATUS->int
        ///ClientBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///Privs: RPC_AUTHZ_HANDLE*
        ///ServerPrincName: RPC_CSTR*
        ///AuthnLevel: unsigned int*
        ///AuthnSvc: unsigned int*
        ///AuthzSvc: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingInqAuthClientA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingInqAuthClientA([In] IntPtr ClientBinding, ref IntPtr Privs, ref IntPtr ServerPrincName, IntPtr AuthnLevel, IntPtr AuthnSvc, IntPtr AuthzSvc);


        /// Return Type: RPC_STATUS->int
        ///StringBinding: RPC_WSTR->unsigned short*
        ///Binding: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingFromStringBindingW", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingFromStringBindingW([In] ref ushort StringBinding, ref IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///StringBinding: RPC_CSTR->unsigned char*
        ///Binding: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingFromStringBindingA", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingFromStringBindingA([In] [MarshalAs(UnmanagedType.LPStr)] string StringBinding, ref IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///Binding: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingFree(ref IntPtr Binding);


        /// Return Type: RPC_STATUS->int
        ///SourceBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///DestinationBinding: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcBindingCopy", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcBindingCopy(IntPtr SourceBinding, ref IntPtr DestinationBinding);


        /// Return Type: RPC_STATUS->int
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcAsyncRegisterInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcAsyncRegisterInfo(ref RPC_ASYNC_STATE pAsync);


        /// Return Type: RPC_STATUS->int
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        ///Size: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcAsyncInitializeHandle", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcAsyncInitializeHandle(ref RPC_ASYNC_STATE pAsync, uint Size);


        /// Return Type: RPC_STATUS->int
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcAsyncGetCallStatus", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcAsyncGetCallStatus(ref RPC_ASYNC_STATE pAsync);


        /// Return Type: RPC_STATUS->int
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        ///Reply: void*
        [DllImport("rpcrt4.dll", EntryPoint = "RpcAsyncCompleteCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcAsyncCompleteCall(ref RPC_ASYNC_STATE pAsync, IntPtr Reply);


        /// Return Type: RPC_STATUS->int
        ///dwTimeout: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "RpcAsyncCleanupThread", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcAsyncCleanupThread(uint dwTimeout);


        /// Return Type: RPC_STATUS->int
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        ///fAbort: BOOL->int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcAsyncCancelCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcAsyncCancelCall(ref RPC_ASYNC_STATE pAsync, [MarshalAs(UnmanagedType.Bool)] bool fAbort);


        /// Return Type: RPC_STATUS->int
        ///pAsync: PRPC_ASYNC_STATE->_RPC_ASYNC_STATE*
        ///ExceptionCode: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "RpcAsyncAbortCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int RpcAsyncAbortCall(ref RPC_ASYNC_STATE pAsync, uint ExceptionCode);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        ///width: int
        ///height: int
        [DllImport("gdi32.dll", EntryPoint = "RoundRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RoundRect([In] IntPtr hdc, int left, int top, int right, int bottom, int width, int height);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///pEFetc: IEnumFORMATETC*
        [DllImport("urlmon.dll", EntryPoint = "RevokeFormatEnumerator", CallingConvention = CallingConvention.StdCall)]
        public static extern int RevokeFormatEnumerator(ref IBindCtx pBC, ref IEnumFORMATETC pEFetc);


        /// Return Type: HRESULT->LONG->int
        ///hwnd: HWND->HWND__*
        [DllImport("ole32.dll", EntryPoint = "RevokeDragDrop", CallingConvention = CallingConvention.StdCall)]
        public static extern int RevokeDragDrop(IntPtr hwnd);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///pBSCb: IBindStatusCallback*
        [DllImport("urlmon.dll", EntryPoint = "RevokeBindStatusCallback", CallingConvention = CallingConvention.StdCall)]
        public static extern int RevokeBindStatusCallback(ref IBindCtx pBC, ref IBindStatusCallback pBSCb);


        /// Return Type: HRESULT->LONG->int
        ///dwRegister: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("oleaut32.dll", EntryPoint = "RevokeActiveObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int RevokeActiveObject(uint dwRegister, IntPtr pvReserved);


        /// Return Type: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "RevertToSelf")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RevertToSelf();


        /// Return Type: LPARAM->LONG_PTR->int
        ///lParam: LPARAM->LONG_PTR->int
        ///msgIn: UINT->unsigned int
        ///msgOut: UINT->unsigned int
        ///uiLo: UINT_PTR->unsigned int
        ///uiHi: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "ReuseDDElParam")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr ReuseDDElParam([MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, uint msgIn, uint msgOut, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uiLo, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uiHi);


        /// Return Type: DWORD->unsigned int
        ///hThread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ResumeThread")]
        public static extern uint ResumeThread([In] IntPtr hThread);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///nSavedDC: int
        [DllImport("gdi32.dll", EntryPoint = "RestoreDC")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RestoreDC([In] IntPtr hdc, int nSavedDC);


        /// Return Type: BOOL->int
        ///hpal: HPALETTE->HPALETTE__*
        ///n: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "ResizePalette")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ResizePalette([In] IntPtr hpal, uint n);


        /// Return Type: UINT->unsigned int
        ///lpBaseAddress: LPVOID->void*
        ///dwRegionSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ResetWriteWatch")]
        public static extern uint ResetWriteWatch([In] IntPtr lpBaseAddress, uint dwRegionSize);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pDefault: LPPRINTER_DEFAULTSW->_PRINTER_DEFAULTSW*
        [DllImport("<Unknown>", EntryPoint = "ResetPrinterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ResetPrinterW([In] IntPtr hPrinter, [In] IntPtr pDefault);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pDefault: LPPRINTER_DEFAULTSA->_PRINTER_DEFAULTSA*
        [DllImport("<Unknown>", EntryPoint = "ResetPrinterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ResetPrinterA([In] IntPtr hPrinter, [In] IntPtr pDefault);


        /// Return Type: BOOL->int
        ///hEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ResetEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ResetEvent([In] IntPtr hEvent);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpdm: DEVMODEW*
        [DllImport("gdi32.dll", EntryPoint = "ResetDCW")]
        public static extern IntPtr ResetDCW([In] IntPtr hdc, [In] ref DEVMODEW lpdm);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpdm: DEVMODEA*
        [DllImport("gdi32.dll", EntryPoint = "ResetDCA")]
        public static extern IntPtr ResetDCA([In] IntPtr hdc, [In] ref DEVMODEA lpdm);


        /// Return Type: BOOL->int
        ///latency: LATENCY_TIME->Anonymous_faa2d20b_f3c7_40e5_b631_f121698025b2
        [DllImport("kernel32.dll", EntryPoint = "RequestWakeupLatency")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RequestWakeupLatency(LATENCY_TIME latency);


        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "RequestDeviceWakeup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RequestDeviceWakeup([In] IntPtr hDevice);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///wType: WORD->unsigned short
        ///wCategory: WORD->unsigned short
        ///dwEventID: DWORD->unsigned int
        ///lpUserSid: PSID->PVOID->void*
        ///wNumStrings: WORD->unsigned short
        ///dwDataSize: DWORD->unsigned int
        ///lpStrings: LPCWSTR*
        ///lpRawData: LPVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "ReportEventW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReportEventW([In] IntPtr hEventLog, ushort wType, ushort wCategory, uint dwEventID, [In] IntPtr lpUserSid, ushort wNumStrings, uint dwDataSize, ref IntPtr lpStrings, [In] IntPtr lpRawData);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///wType: WORD->unsigned short
        ///wCategory: WORD->unsigned short
        ///dwEventID: DWORD->unsigned int
        ///lpUserSid: PSID->PVOID->void*
        ///wNumStrings: WORD->unsigned short
        ///dwDataSize: DWORD->unsigned int
        ///lpStrings: LPCSTR*
        ///lpRawData: LPVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "ReportEventA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReportEventA([In] IntPtr hEventLog, ushort wType, ushort wCategory, uint dwEventID, [In] IntPtr lpUserSid, ushort wNumStrings, uint dwDataSize, ref IntPtr lpStrings, [In] IntPtr lpRawData);


        /// Return Type: BOOL->int
        ///lResult: LRESULT->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "ReplyMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplyMessage([MarshalAs(UnmanagedType.SysInt)] IntPtr lResult);


        /// Return Type: HWND->HWND__*
        ///param0: LPFINDREPLACEW->tagFINDREPLACEW*
        [DllImport("comdlg32.dll", EntryPoint = "ReplaceTextW")]
        public static extern IntPtr ReplaceTextW(ref tagFINDREPLACEW param0);


        /// Return Type: HWND->HWND__*
        ///param0: LPFINDREPLACEA->tagFINDREPLACEA*
        [DllImport("comdlg32.dll", EntryPoint = "ReplaceTextA")]
        public static extern IntPtr ReplaceTextA(ref tagFINDREPLACEA param0);


        /// Return Type: BOOL->int
        ///lpReplacedFileName: LPCWSTR->WCHAR*
        ///lpReplacementFileName: LPCWSTR->WCHAR*
        ///lpBackupFileName: LPCWSTR->WCHAR*
        ///dwReplaceFlags: DWORD->unsigned int
        ///lpExclude: LPVOID->void*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReplaceFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplaceFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpReplacedFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpReplacementFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);


        /// Return Type: BOOL->int
        ///lpReplacedFileName: LPCSTR->CHAR*
        ///lpReplacementFileName: LPCSTR->CHAR*
        ///lpBackupFileName: LPCSTR->CHAR*
        ///dwReplaceFlags: DWORD->unsigned int
        ///lpExclude: LPVOID->void*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReplaceFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplaceFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpReplacedFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpReplacementFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName, uint dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved);


        /// Return Type: HANDLE->void*
        ///hOriginalFile: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///dwFlagsAndAttributes: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ReOpenFile")]
        public static extern IntPtr ReOpenFile([In] IntPtr hOriginalFile, uint dwDesiredAccess, uint dwShareMode, uint dwFlagsAndAttributes);


        /// Return Type: ULONG->unsigned int
        ///Handle: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "RemoveVectoredExceptionHandler")]
        public static extern uint RemoveVectoredExceptionHandler([In] IntPtr Handle);


        /// Return Type: ULONG->unsigned int
        ///Handle: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "RemoveVectoredContinueHandler")]
        public static extern uint RemoveVectoredContinueHandler([In] IntPtr Handle);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///pHashes: PENCRYPTION_CERTIFICATE_HASH_LIST->_ENCRYPTION_CERTIFICATE_HASH_LIST*
        [DllImport("advapi32.dll", EntryPoint = "RemoveUsersFromEncryptedFile")]
        public static extern uint RemoveUsersFromEncryptedFile([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [In] ref ENCRYPTION_CERTIFICATE_HASH_LIST pHashes);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "RemovePropW")]
        public static extern IntPtr RemovePropW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "RemovePropA")]
        public static extern IntPtr RemovePropA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveMenu([In] IntPtr hMenu, uint uPosition, uint uFlags);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///name: LPCWSTR->WCHAR*
        ///fl: DWORD->unsigned int
        ///pdv: PVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceExW([In] [MarshalAs(UnmanagedType.LPWStr)] string name, uint fl, IntPtr pdv);


        /// Return Type: BOOL->int
        ///name: LPCSTR->CHAR*
        ///fl: DWORD->unsigned int
        ///pdv: PVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceExA([In] [MarshalAs(UnmanagedType.LPStr)] string name, uint fl, IntPtr pdv);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveFontResourceA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///h: HANDLE->void*
        [DllImport("gdi32.dll", EntryPoint = "RemoveFontMemResourceEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveFontMemResourceEx([In] IntPtr h);


        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "RemoveDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName);


        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "RemoveDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName);


        /// Return Type: void
        ///param0: LPSTGMEDIUM->STGMEDIUM*
        [DllImport("ole32.dll", EntryPoint = "ReleaseStgMedium", CallingConvention = CallingConvention.StdCall)]
        public static extern void ReleaseStgMedium(ref tagSTGMEDIUM param0);


        /// Return Type: BOOL->int
        ///hSemaphore: HANDLE->void*
        ///lReleaseCount: LONG->int
        ///lpPreviousCount: LPLONG->int*
        [DllImport("kernel32.dll", EntryPoint = "ReleaseSemaphore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseSemaphore([In] IntPtr hSemaphore, int lReleaseCount, IntPtr lpPreviousCount);


        /// Return Type: BOOL->int
        ///hMutex: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ReleaseMutex")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseMutex([In] IntPtr hMutex);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hDC: HDC->HDC__*
        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern int ReleaseDC([In] IntPtr hWnd, [In] IntPtr hDC);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseCapture();


        /// Return Type: void
        ///pbindinfo: BINDINFO*
        [DllImport("urlmon.dll", EntryPoint = "ReleaseBindInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern void ReleaseBindInfo(ref BINDINFO pbindinfo);


        /// Return Type: void
        ///hActCtx: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ReleaseActCtx")]
        public static extern void ReleaseActCtx(IntPtr hActCtx);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegUnLoadKeyW")]
        public static extern int RegUnLoadKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegUnLoadKeyA")]
        public static extern int RegUnLoadKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///dwType: DWORD->unsigned int
        ///lpData: LPCWSTR->WCHAR*
        ///cbData: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegSetValueW")]
        public static extern int RegSetValueW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, uint dwType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpData, uint cbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpValueName: LPCWSTR->WCHAR*
        ///Reserved: DWORD->unsigned int
        ///dwType: DWORD->unsigned int
        ///lpData: BYTE*
        ///cbData: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegSetValueExW")]
        public static extern int RegSetValueExW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, uint Reserved, uint dwType, [In] IntPtr lpData, uint cbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpValueName: LPCSTR->CHAR*
        ///Reserved: DWORD->unsigned int
        ///dwType: DWORD->unsigned int
        ///lpData: BYTE*
        ///cbData: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegSetValueExA")]
        public static extern int RegSetValueExA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValueName, uint Reserved, uint dwType, [In] IntPtr lpData, uint cbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///dwType: DWORD->unsigned int
        ///lpData: LPCSTR->CHAR*
        ///cbData: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegSetValueA")]
        public static extern int RegSetValueA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, uint dwType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpData, uint cbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "RegSetKeySecurity")]
        public static extern int RegSetKeySecurity([In] IntPtr hKey, uint SecurityInformation, [In] IntPtr pSecurityDescriptor);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpFile: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("advapi32.dll", EntryPoint = "RegSaveKeyW")]
        public static extern int RegSaveKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFile, [In] IntPtr lpSecurityAttributes);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpFile: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///Flags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegSaveKeyExW")]
        public static extern int RegSaveKeyExW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFile, [In] IntPtr lpSecurityAttributes, uint Flags);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpFile: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///Flags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegSaveKeyExA")]
        public static extern int RegSaveKeyExA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFile, [In] IntPtr lpSecurityAttributes, uint Flags);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpFile: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("advapi32.dll", EntryPoint = "RegSaveKeyA")]
        public static extern int RegSaveKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFile, [In] IntPtr lpSecurityAttributes);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpFile: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegRestoreKeyW")]
        public static extern int RegRestoreKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFile, uint dwFlags);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpFile: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegRestoreKeyA")]
        public static extern int RegRestoreKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFile, uint dwFlags);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///lpNewFile: LPCWSTR->WCHAR*
        ///lpOldFile: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegReplaceKeyW")]
        public static extern int RegReplaceKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFile, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpOldFile);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///lpNewFile: LPCSTR->CHAR*
        ///lpOldFile: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegReplaceKeyA")]
        public static extern int RegReplaceKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpOldFile);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///lpData: LPWSTR->WCHAR*
        ///lpcbData: PLONG->LONG*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryValueW")]
        public static extern int RegQueryValueW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, IntPtr lpData, IntPtr lpcbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpValueName: LPCWSTR->WCHAR*
        ///lpReserved: LPDWORD->DWORD*
        ///lpType: LPDWORD->DWORD*
        ///lpData: LPBYTE->BYTE*
        ///lpcbData: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryValueExW")]
        public static extern int RegQueryValueExW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValueName, IntPtr lpReserved, IntPtr lpType, IntPtr lpData, IntPtr lpcbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpValueName: LPCSTR->CHAR*
        ///lpReserved: LPDWORD->DWORD*
        ///lpType: LPDWORD->DWORD*
        ///lpData: LPBYTE->BYTE*
        ///lpcbData: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryValueExA")]
        public static extern int RegQueryValueExA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValueName, IntPtr lpReserved, IntPtr lpType, IntPtr lpData, IntPtr lpcbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///lpData: LPSTR->CHAR*
        ///lpcbData: PLONG->LONG*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryValueA")]
        public static extern int RegQueryValueA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, IntPtr lpData, IntPtr lpcbData);


        /// Return Type: LONG->int
        ///hBase: HKEY->HKEY__*
        ///bIsReflectionDisabled: BOOL*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryReflectionKey")]
        public static extern int RegQueryReflectionKey([In] IntPtr hBase, [Out] out int bIsReflectionDisabled);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///val_list: PVALENTW->value_entW*
        ///num_vals: DWORD->unsigned int
        ///lpValueBuf: LPWSTR->WCHAR*
        ///ldwTotsize: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryMultipleValuesW")]
        public static extern int RegQueryMultipleValuesW([In] IntPtr hKey, IntPtr val_list, uint num_vals, IntPtr lpValueBuf, IntPtr ldwTotsize);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///val_list: PVALENTA->value_entA*
        ///num_vals: DWORD->unsigned int
        ///lpValueBuf: LPSTR->CHAR*
        ///ldwTotsize: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryMultipleValuesA")]
        public static extern int RegQueryMultipleValuesA([In] IntPtr hKey, IntPtr val_list, uint num_vals, IntPtr lpValueBuf, IntPtr ldwTotsize);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpClass: LPWSTR->WCHAR*
        ///lpcchClass: LPDWORD->DWORD*
        ///lpReserved: LPDWORD->DWORD*
        ///lpcSubKeys: LPDWORD->DWORD*
        ///lpcbMaxSubKeyLen: LPDWORD->DWORD*
        ///lpcbMaxClassLen: LPDWORD->DWORD*
        ///lpcValues: LPDWORD->DWORD*
        ///lpcbMaxValueNameLen: LPDWORD->DWORD*
        ///lpcbMaxValueLen: LPDWORD->DWORD*
        ///lpcbSecurityDescriptor: LPDWORD->DWORD*
        ///lpftLastWriteTime: PFILETIME->_FILETIME*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryInfoKeyW")]
        public static extern int RegQueryInfoKeyW([In] IntPtr hKey, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpClass, IntPtr lpcchClass, IntPtr lpReserved, IntPtr lpcSubKeys, IntPtr lpcbMaxSubKeyLen, IntPtr lpcbMaxClassLen, IntPtr lpcValues, IntPtr lpcbMaxValueNameLen, IntPtr lpcbMaxValueLen, IntPtr lpcbSecurityDescriptor, IntPtr lpftLastWriteTime);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpClass: LPSTR->CHAR*
        ///lpcchClass: LPDWORD->DWORD*
        ///lpReserved: LPDWORD->DWORD*
        ///lpcSubKeys: LPDWORD->DWORD*
        ///lpcbMaxSubKeyLen: LPDWORD->DWORD*
        ///lpcbMaxClassLen: LPDWORD->DWORD*
        ///lpcValues: LPDWORD->DWORD*
        ///lpcbMaxValueNameLen: LPDWORD->DWORD*
        ///lpcbMaxValueLen: LPDWORD->DWORD*
        ///lpcbSecurityDescriptor: LPDWORD->DWORD*
        ///lpftLastWriteTime: PFILETIME->_FILETIME*
        [DllImport("advapi32.dll", EntryPoint = "RegQueryInfoKeyA")]
        public static extern int RegQueryInfoKeyA([In] IntPtr hKey, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpClass, IntPtr lpcchClass, IntPtr lpReserved, IntPtr lpcSubKeys, IntPtr lpcbMaxSubKeyLen, IntPtr lpcbMaxClassLen, IntPtr lpcValues, IntPtr lpcbMaxValueNameLen, IntPtr lpcbMaxValueLen, IntPtr lpcbSecurityDescriptor, IntPtr lpftLastWriteTime);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///hNewHKey: HKEY->HKEY__*
        [DllImport("advapi32.dll", EntryPoint = "RegOverridePredefKey")]
        public static extern int RegOverridePredefKey([In] IntPtr hKey, [In] IntPtr hNewHKey);


        /// Return Type: LONG->int
        ///hToken: HANDLE->void*
        ///dwOptions: DWORD->unsigned int
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegOpenUserClassesRoot")]
        public static extern int RegOpenUserClassesRoot([In] IntPtr hToken, uint dwOptions, uint samDesired, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegOpenKeyW")]
        public static extern int RegOpenKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///ulOptions: DWORD->unsigned int
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegOpenKeyExW")]
        public static extern int RegOpenKeyExW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, uint ulOptions, uint samDesired, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///ulOptions: DWORD->unsigned int
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegOpenKeyExA")]
        public static extern int RegOpenKeyExA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, uint ulOptions, uint samDesired, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegOpenKeyA")]
        public static extern int RegOpenKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegOpenCurrentUser")]
        public static extern int RegOpenCurrentUser(uint samDesired, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        ///hEvent: HANDLE->void*
        ///fAsynchronous: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "RegNotifyChangeKeyValue")]
        public static extern int RegNotifyChangeKeyValue([In] IntPtr hKey, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter, [In] IntPtr hEvent, [MarshalAs(UnmanagedType.Bool)] bool fAsynchronous);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///lpFile: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegLoadKeyW")]
        public static extern int RegLoadKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFile);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///lpFile: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegLoadKeyA")]
        public static extern int RegLoadKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFile);


        /// Return Type: UINT->unsigned int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessageW")]
        public static extern uint RegisterWindowMessageW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: UINT->unsigned int
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessageA")]
        public static extern uint RegisterWindowMessageA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: HANDLE->void*
        ///hObject: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Context: PVOID->void*
        ///dwMilliseconds: ULONG->unsigned int
        ///dwFlags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "RegisterWaitForSingleObjectEx")]
        public static extern IntPtr RegisterWaitForSingleObjectEx([In] IntPtr hObject, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Context, uint dwMilliseconds, uint dwFlags);


        /// Return Type: BOOL->int
        ///phNewWaitObject: PHANDLE->HANDLE*
        ///hObject: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Context: PVOID->void*
        ///dwMilliseconds: ULONG->unsigned int
        ///dwFlags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "RegisterWaitForSingleObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterWaitForSingleObject(out IntPtr phNewWaitObject, [In] IntPtr hObject, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Context, uint dwMilliseconds, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///ptlib: ITypeLib*
        ///szFullPath: OLECHAR*
        ///szHelpDir: OLECHAR*
        [DllImport("oleaut32.dll", EntryPoint = "RegisterTypeLib", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterTypeLib(ref ITypeLib ptlib, IntPtr szFullPath, IntPtr szHelpDir);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "RegisterShellHookWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterShellHookWindow([In] IntPtr hwnd);


        /// Return Type: SERVICE_STATUS_HANDLE->SERVICE_STATUS_HANDLE__*
        ///lpServiceName: LPCWSTR->WCHAR*
        ///lpHandlerProc: LPHANDLER_FUNCTION
        [DllImport("advapi32.dll", EntryPoint = "RegisterServiceCtrlHandlerW")]
        public static extern IntPtr RegisterServiceCtrlHandlerW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpServiceName, LPHANDLER_FUNCTION lpHandlerProc);


        /// Return Type: SERVICE_STATUS_HANDLE->SERVICE_STATUS_HANDLE__*
        ///lpServiceName: LPCWSTR->WCHAR*
        ///lpHandlerProc: LPHANDLER_FUNCTION_EX
        ///lpContext: LPVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "RegisterServiceCtrlHandlerExW")]
        public static extern IntPtr RegisterServiceCtrlHandlerExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpServiceName, LPHANDLER_FUNCTION_EX lpHandlerProc, [In] IntPtr lpContext);


        /// Return Type: SERVICE_STATUS_HANDLE->SERVICE_STATUS_HANDLE__*
        ///lpServiceName: LPCSTR->CHAR*
        ///lpHandlerProc: LPHANDLER_FUNCTION_EX
        ///lpContext: LPVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "RegisterServiceCtrlHandlerExA")]
        public static extern IntPtr RegisterServiceCtrlHandlerExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpServiceName, LPHANDLER_FUNCTION_EX lpHandlerProc, [In] IntPtr lpContext);


        /// Return Type: SERVICE_STATUS_HANDLE->SERVICE_STATUS_HANDLE__*
        ///lpServiceName: LPCSTR->CHAR*
        ///lpHandlerProc: LPHANDLER_FUNCTION
        [DllImport("advapi32.dll", EntryPoint = "RegisterServiceCtrlHandlerA")]
        public static extern IntPtr RegisterServiceCtrlHandlerA([In] [MarshalAs(UnmanagedType.LPStr)] string lpServiceName, LPHANDLER_FUNCTION lpHandlerProc);


        /// Return Type: BOOL->int
        ///pRawInputDevices: PCRAWINPUTDEVICE->RAWINPUTDEVICE*
        ///uiNumDevices: UINT->unsigned int
        ///cbSize: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterRawInputDevices")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterRawInputDevices([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] tagRAWINPUTDEVICE[] pRawInputDevices, uint uiNumDevices, uint cbSize);


        /// Return Type: HRESULT->LONG->int
        ///ctypes: UINT->unsigned int
        ///rgszTypes: LPCSTR*
        ///rgcfTypes: CLIPFORMAT*
        [DllImport("urlmon.dll", EntryPoint = "RegisterMediaTypes", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterMediaTypes(uint ctypes, ref IntPtr rgszTypes, ref ushort rgcfTypes);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///ctypes: UINT->unsigned int
        ///rgszTypes: LPCSTR*
        ///rgclsID: CLSID*
        ///reserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "RegisterMediaTypeClass", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterMediaTypeClass(ref IBindCtx pBC, uint ctypes, ref IntPtr rgszTypes, ref GUID rgclsID, uint reserved);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///id: int
        ///fsModifiers: UINT->unsigned int
        ///vk: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterHotKey([In] IntPtr hWnd, int id, uint fsModifiers, uint vk);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///pEFetc: IEnumFORMATETC*
        ///reserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "RegisterFormatEnumerator", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterFormatEnumerator(ref IBindCtx pBC, ref IEnumFORMATETC pEFetc, uint reserved);


        /// Return Type: HANDLE->void*
        ///lpUNCServerName: LPCWSTR->WCHAR*
        ///lpSourceName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegisterEventSourceW")]
        public static extern IntPtr RegisterEventSourceW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpUNCServerName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSourceName);


        /// Return Type: HANDLE->void*
        ///lpUNCServerName: LPCSTR->CHAR*
        ///lpSourceName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegisterEventSourceA")]
        public static extern IntPtr RegisterEventSourceA([In] [MarshalAs(UnmanagedType.LPStr)] string lpUNCServerName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSourceName);


        /// Return Type: HRESULT->LONG->int
        ///hwnd: HWND->HWND__*
        ///pDropTarget: LPDROPTARGET->IDropTarget*
        [DllImport("ole32.dll", EntryPoint = "RegisterDragDrop", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterDragDrop(IntPtr hwnd, ref IDropTarget pDropTarget);


        /// Return Type: HDEVNOTIFY->PVOID->void*
        ///hRecipient: HANDLE->void*
        ///NotificationFilter: LPVOID->void*
        ///Flags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterDeviceNotificationW")]
        public static extern IntPtr RegisterDeviceNotificationW([In] IntPtr hRecipient, [In] IntPtr NotificationFilter, uint Flags);


        /// Return Type: HDEVNOTIFY->PVOID->void*
        ///hRecipient: HANDLE->void*
        ///NotificationFilter: LPVOID->void*
        ///Flags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "RegisterDeviceNotificationA")]
        public static extern IntPtr RegisterDeviceNotificationA([In] IntPtr hRecipient, [In] IntPtr NotificationFilter, uint Flags);


        /// Return Type: UINT->unsigned int
        ///lpszFormat: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterClipboardFormatW")]
        public static extern uint RegisterClipboardFormatW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);


        /// Return Type: UINT->unsigned int
        ///lpszFormat: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "RegisterClipboardFormatA")]
        public static extern uint RegisterClipboardFormatA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszFormat);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpWndClass: WNDCLASSW*
        [DllImport("user32.dll", EntryPoint = "RegisterClassW")]
        public static extern ushort RegisterClassW([In] ref tagWNDCLASSW lpWndClass);


        /// Return Type: ATOM->WORD->unsigned short
        ///param0: WNDCLASSEXW*
        [DllImport("user32.dll", EntryPoint = "RegisterClassExW")]
        public static extern ushort RegisterClassExW([In] ref tagWNDCLASSEXW param0);


        /// Return Type: ATOM->WORD->unsigned short
        ///param0: WNDCLASSEXA*
        [DllImport("user32.dll", EntryPoint = "RegisterClassExA")]
        public static extern ushort RegisterClassExA([In] ref tagWNDCLASSEXA param0);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpWndClass: WNDCLASSA*
        [DllImport("user32.dll", EntryPoint = "RegisterClassA")]
        public static extern ushort RegisterClassA([In] ref tagWNDCLASSA lpWndClass);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///pBSCb: IBindStatusCallback*
        ///ppBSCBPrev: IBindStatusCallback**
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "RegisterBindStatusCallback", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterBindStatusCallback(ref IBindCtx pBC, ref IBindStatusCallback pBSCb, ref IntPtr ppBSCBPrev, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///punk: IUnknown*
        ///rclsid: IID*
        ///dwFlags: DWORD->unsigned int
        ///pdwRegister: DWORD*
        [DllImport("oleaut32.dll", EntryPoint = "RegisterActiveObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterActiveObject(ref IUnknown punk, ref GUID rclsid, uint dwFlags, ref uint pdwRegister);


        /// Return Type: LONG->int
        ///hkey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///lpValue: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///pdwType: LPDWORD->DWORD*
        ///pvData: PVOID->void*
        ///pcbData: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "RegGetValueW")]
        public static extern int RegGetValueW([In] IntPtr hkey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValue, uint dwFlags, IntPtr pdwType, IntPtr pvData, IntPtr pcbData);


        /// Return Type: LONG->int
        ///hkey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///lpValue: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///pdwType: LPDWORD->DWORD*
        ///pvData: PVOID->void*
        ///pcbData: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "RegGetValueA")]
        public static extern int RegGetValueA([In] IntPtr hkey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValue, uint dwFlags, IntPtr pdwType, IntPtr pvData, IntPtr pcbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///lpcbSecurityDescriptor: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegGetKeySecurity")]
        public static extern int RegGetKeySecurity([In] IntPtr hKey, uint SecurityInformation, IntPtr pSecurityDescriptor, ref uint lpcbSecurityDescriptor);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        [DllImport("advapi32.dll", EntryPoint = "RegFlushKey")]
        public static extern int RegFlushKey([In] IntPtr hKey);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///dwIndex: DWORD->unsigned int
        ///lpValueName: LPWSTR->WCHAR*
        ///lpcchValueName: LPDWORD->DWORD*
        ///lpReserved: LPDWORD->DWORD*
        ///lpType: LPDWORD->DWORD*
        ///lpData: LPBYTE->BYTE*
        ///lpcbData: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegEnumValueW")]
        public static extern int RegEnumValueW([In] IntPtr hKey, uint dwIndex, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpValueName, ref uint lpcchValueName, IntPtr lpReserved, IntPtr lpType, IntPtr lpData, IntPtr lpcbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///dwIndex: DWORD->unsigned int
        ///lpValueName: LPSTR->CHAR*
        ///lpcchValueName: LPDWORD->DWORD*
        ///lpReserved: LPDWORD->DWORD*
        ///lpType: LPDWORD->DWORD*
        ///lpData: LPBYTE->BYTE*
        ///lpcbData: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegEnumValueA")]
        public static extern int RegEnumValueA([In] IntPtr hKey, uint dwIndex, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpValueName, ref uint lpcchValueName, IntPtr lpReserved, IntPtr lpType, IntPtr lpData, IntPtr lpcbData);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///dwIndex: DWORD->unsigned int
        ///lpName: LPWSTR->WCHAR*
        ///cchName: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegEnumKeyW")]
        public static extern int RegEnumKeyW([In] IntPtr hKey, uint dwIndex, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpName, uint cchName);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///dwIndex: DWORD->unsigned int
        ///lpName: LPWSTR->WCHAR*
        ///lpcchName: LPDWORD->DWORD*
        ///lpReserved: LPDWORD->DWORD*
        ///lpClass: LPWSTR->WCHAR*
        ///lpcchClass: LPDWORD->DWORD*
        ///lpftLastWriteTime: PFILETIME->_FILETIME*
        [DllImport("advapi32.dll", EntryPoint = "RegEnumKeyExW")]
        public static extern int RegEnumKeyExW([In] IntPtr hKey, uint dwIndex, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpName, ref uint lpcchName, IntPtr lpReserved, IntPtr lpClass, IntPtr lpcchClass, IntPtr lpftLastWriteTime);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///dwIndex: DWORD->unsigned int
        ///lpName: LPSTR->CHAR*
        ///lpcchName: LPDWORD->DWORD*
        ///lpReserved: LPDWORD->DWORD*
        ///lpClass: LPSTR->CHAR*
        ///lpcchClass: LPDWORD->DWORD*
        ///lpftLastWriteTime: PFILETIME->_FILETIME*
        [DllImport("advapi32.dll", EntryPoint = "RegEnumKeyExA")]
        public static extern int RegEnumKeyExA([In] IntPtr hKey, uint dwIndex, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpName, ref uint lpcchName, IntPtr lpReserved, IntPtr lpClass, IntPtr lpcchClass, IntPtr lpftLastWriteTime);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///dwIndex: DWORD->unsigned int
        ///lpName: LPSTR->CHAR*
        ///cchName: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "RegEnumKeyA")]
        public static extern int RegEnumKeyA([In] IntPtr hKey, uint dwIndex, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpName, uint cchName);


        /// Return Type: LONG->int
        ///hBase: HKEY->HKEY__*
        [DllImport("advapi32.dll", EntryPoint = "RegEnableReflectionKey")]
        public static extern int RegEnableReflectionKey([In] IntPtr hBase);


        /// Return Type: LONG->int
        ///hBase: HKEY->HKEY__*
        [DllImport("advapi32.dll", EntryPoint = "RegDisableReflectionKey")]
        public static extern int RegDisableReflectionKey([In] IntPtr hBase);


        /// Return Type: LONG->int
        [DllImport("advapi32.dll", EntryPoint = "RegDisablePredefinedCache")]
        public static extern int RegDisablePredefinedCache();


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpValueName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegDeleteValueW")]
        public static extern int RegDeleteValueW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValueName);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpValueName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegDeleteValueA")]
        public static extern int RegDeleteValueA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValueName);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegDeleteKeyW")]
        public static extern int RegDeleteKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///Reserved: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "RegDeleteKeyExW")]
        public static extern int RegDeleteKeyExW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, uint samDesired, uint Reserved);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///Reserved: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "RegDeleteKeyExA")]
        public static extern int RegDeleteKeyExA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, uint samDesired, uint Reserved);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "RegDeleteKeyA")]
        public static extern int RegDeleteKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegCreateKeyW")]
        public static extern int RegCreateKeyW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCWSTR->WCHAR*
        ///Reserved: DWORD->unsigned int
        ///lpClass: LPWSTR->WCHAR*
        ///dwOptions: DWORD->unsigned int
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///phkResult: PHKEY->HKEY*
        ///lpdwDisposition: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegCreateKeyExW")]
        public static extern int RegCreateKeyExW([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey, uint Reserved, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClass, uint dwOptions, uint samDesired, [In] IntPtr lpSecurityAttributes, ref IntPtr phkResult, IntPtr lpdwDisposition);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///Reserved: DWORD->unsigned int
        ///lpClass: LPSTR->CHAR*
        ///dwOptions: DWORD->unsigned int
        ///samDesired: REGSAM->ACCESS_MASK->DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///phkResult: PHKEY->HKEY*
        ///lpdwDisposition: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "RegCreateKeyExA")]
        public static extern int RegCreateKeyExA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, uint Reserved, [In] [MarshalAs(UnmanagedType.LPStr)] string lpClass, uint dwOptions, uint samDesired, [In] IntPtr lpSecurityAttributes, ref IntPtr phkResult, IntPtr lpdwDisposition);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        ///lpSubKey: LPCSTR->CHAR*
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegCreateKeyA")]
        public static extern int RegCreateKeyA([In] IntPtr hKey, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSubKey, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///lpMachineName: LPCWSTR->WCHAR*
        ///hKey: HKEY->HKEY__*
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegConnectRegistryW")]
        public static extern int RegConnectRegistryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpMachineName, [In] IntPtr hKey, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///lpMachineName: LPCWSTR->WCHAR*
        ///hKey: HKEY->HKEY__*
        ///Flags: ULONG->unsigned int
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegConnectRegistryExW")]
        public static extern int RegConnectRegistryExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpMachineName, [In] IntPtr hKey, uint Flags, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///lpMachineName: LPCSTR->CHAR*
        ///hKey: HKEY->HKEY__*
        ///Flags: ULONG->unsigned int
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegConnectRegistryExA")]
        public static extern int RegConnectRegistryExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpMachineName, [In] IntPtr hKey, uint Flags, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///lpMachineName: LPCSTR->CHAR*
        ///hKey: HKEY->HKEY__*
        ///phkResult: PHKEY->HKEY*
        [DllImport("advapi32.dll", EntryPoint = "RegConnectRegistryA")]
        public static extern int RegConnectRegistryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpMachineName, [In] IntPtr hKey, ref IntPtr phkResult);


        /// Return Type: LONG->int
        ///hKey: HKEY->HKEY__*
        [DllImport("advapi32.dll", EntryPoint = "RegCloseKey")]
        public static extern int RegCloseKey([In] IntPtr hKey);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lprcUpdate: RECT*
        ///hrgnUpdate: HRGN->HRGN__*
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RedrawWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RedrawWindow([In] IntPtr hWnd, [In] IntPtr lprcUpdate, [In] IntPtr hrgnUpdate, uint flags);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///buf: char*
        ///len: int
        ///flags: int
        ///from: sockaddr*
        ///fromlen: int*
        [DllImport("ws2_32.dll", EntryPoint = "recvfrom", CallingConvention = CallingConvention.StdCall)]
        public static extern int recvfrom([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, IntPtr buf, int len, int flags, ref sockaddr from, ref int fromlen);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///buf: char*
        ///len: int
        ///flags: int
        [DllImport("ws2_32.dll", EntryPoint = "recv", CallingConvention = CallingConvention.StdCall)]
        public static extern int recv([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, IntPtr buf, int len, int flags);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lprect: RECT*
        [DllImport("gdi32.dll", EntryPoint = "RectVisible")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RectVisible([In] IntPtr hdc, [In] ref tagRECT lprect);


        /// Return Type: BOOL->int
        ///hrgn: HRGN->HRGN__*
        ///lprect: RECT*
        [DllImport("gdi32.dll", EntryPoint = "RectInRegion")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RectInRegion([In] IntPtr hrgn, [In] ref tagRECT lprect);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImport("gdi32.dll", EntryPoint = "Rectangle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Rectangle([In] IntPtr hdc, int left, int top, int right, int bottom);


        /// Return Type: void*
        ///_Memory: void*
        ///_NewSize: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "realloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr realloc([In] IntPtr _Memory, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _NewSize);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "RealizePalette")]
        public static extern uint RealizePalette([In] IntPtr hdc);


        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///ptszClassName: LPWSTR->WCHAR*
        ///cchClassNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RealGetWindowClassW")]
        public static extern uint RealGetWindowClassW([In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ptszClassName, uint cchClassNameMax);


        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///ptszClassName: LPSTR->CHAR*
        ///cchClassNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "RealGetWindowClassA")]
        public static extern uint RealGetWindowClassA([In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ptszClassName, uint cchClassNameMax);


        /// Return Type: HWND->HWND__*
        ///hwndParent: HWND->HWND__*
        ///ptParentClientCoords: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "RealChildWindowFromPoint")]
        public static extern IntPtr RealChildWindowFromPoint([In] IntPtr hwndParent, Point ptParentClientCoords);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpBaseAddress: LPCVOID->void*
        ///lpBuffer: LPVOID->void*
        ///nSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpNumberOfBytesRead: SIZE_T*
        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadProcessMemory([In] IntPtr hProcess, [In] IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, IntPtr lpNumberOfBytesRead);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pBuf: LPVOID->void*
        ///cbBuf: DWORD->unsigned int
        ///pNoBytesRead: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "ReadPrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadPrinter([In] IntPtr hPrinter, IntPtr pBuf, uint cbBuf, [Out] out uint pNoBytesRead);


        /// Return Type: HRESULT->LONG->int
        ///pstg: LPSTORAGE->IStorage*
        ///pcf: CLIPFORMAT*
        ///lplpszUserType: LPOLESTR*
        [DllImport("ole32.dll", EntryPoint = "ReadFmtUserTypeStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadFmtUserTypeStg(ref IStorage pstg, ref ushort pcf, ref IntPtr lplpszUserType);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///aSegmentArray: FILE_SEGMENT_ELEMENT*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpReserved: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "ReadFileScatter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadFileScatter([In] IntPtr hFile, [In] ref FILE_SEGMENT_ELEMENT aSegmentArray, uint nNumberOfBytesToRead, IntPtr lpReserved, ref OVERLAPPED lpOverlapped);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpCompletionRoutine: LPOVERLAPPED_COMPLETION_ROUTINE
        [DllImport("kernel32.dll", EntryPoint = "ReadFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadFileEx([In] IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, ref OVERLAPPED lpOverlapped, LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///lpNumberOfBytesRead: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "ReadFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadFile([In] IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, IntPtr lpNumberOfBytesRead, IntPtr lpOverlapped);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///dwReadFlags: DWORD->unsigned int
        ///dwRecordOffset: DWORD->unsigned int
        ///lpBuffer: LPVOID->void*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///pnBytesRead: DWORD*
        ///pnMinNumberOfBytesNeeded: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "ReadEventLogW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadEventLogW([In] IntPtr hEventLog, uint dwReadFlags, uint dwRecordOffset, IntPtr lpBuffer, uint nNumberOfBytesToRead, [Out] out uint pnBytesRead, [Out] out uint pnMinNumberOfBytesNeeded);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///dwReadFlags: DWORD->unsigned int
        ///dwRecordOffset: DWORD->unsigned int
        ///lpBuffer: LPVOID->void*
        ///nNumberOfBytesToRead: DWORD->unsigned int
        ///pnBytesRead: DWORD*
        ///pnMinNumberOfBytesNeeded: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "ReadEventLogA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadEventLogA([In] IntPtr hEventLog, uint dwReadFlags, uint dwRecordOffset, IntPtr lpBuffer, uint nNumberOfBytesToRead, [Out] out uint pnBytesRead, [Out] out uint pnMinNumberOfBytesNeeded);


        /// Return Type: DWORD->unsigned int
        ///pfExportCallback: PFE_EXPORT_FUNC
        ///pvCallbackContext: PVOID->void*
        ///pvContext: PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "ReadEncryptedFileRaw")]
        public static extern uint ReadEncryptedFileRaw(PFE_EXPORT_FUNC pfExportCallback, [In] IntPtr pvCallbackContext, [In] IntPtr pvContext);


        /// Return Type: BOOL->int
        ///hDirectory: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nBufferLength: DWORD->unsigned int
        ///bWatchSubtree: BOOL->int
        ///dwNotifyFilter: DWORD->unsigned int
        ///lpBytesReturned: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpCompletionRoutine: LPOVERLAPPED_COMPLETION_ROUTINE
        [DllImport("kernel32.dll", EntryPoint = "ReadDirectoryChangesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadDirectoryChangesW([In] IntPtr hDirectory, IntPtr lpBuffer, uint nBufferLength, [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, uint dwNotifyFilter, [Out] out uint lpBytesReturned, ref OVERLAPPED lpOverlapped, LPOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfCharsToRead: DWORD->unsigned int
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleW(IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: PCHAR_INFO->_CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpReadRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputW(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPWSTR->WCHAR*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputCharacterW(IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPSTR->CHAR*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputCharacterA(IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpAttribute: LPWORD->WORD*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfAttrsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputAttribute(IntPtr hConsoleOutput, ref ushort lpAttribute, uint nLength, COORD dwReadCoord, ref uint lpNumberOfAttrsRead);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: PCHAR_INFO->_CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpReadRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputA(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfCharsToRead: DWORD->unsigned int
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleA(IntPtr hConsoleInput, IntPtr lpBuffer, uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        ///pclsid: CLSID*
        [DllImport("ole32.dll", EntryPoint = "ReadClassStm", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadClassStm(ref IStream pStm, ref GUID pclsid);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        ///pclsid: CLSID*
        [DllImport("ole32.dll", EntryPoint = "ReadClassStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadClassStg(ref IStorage pStg, ref GUID pclsid);


        /// Return Type: int
        [DllImport("msvcr80.dll", EntryPoint = "rand", CallingConvention = CallingConvention.Cdecl)]
        public static extern int rand();


        /// Return Type: void
        ///dwExceptionCode: DWORD->unsigned int
        ///dwExceptionFlags: DWORD->unsigned int
        ///nNumberOfArguments: DWORD->unsigned int
        ///lpArguments: ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "RaiseException")]
        public static extern void RaiseException(uint dwExceptionCode, uint dwExceptionFlags, uint nNumberOfArguments, [In] IntPtr lpArguments);

    }

}
