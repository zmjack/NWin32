using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: u_short->unsigned short
        ///netshort: u_short->unsigned short
        [DllImport("ws2_32.dll", EntryPoint = "ntohs", CallingConvention = CallingConvention.StdCall)]
        public static extern ushort ntohs(ushort netshort);


        /// Return Type: u_long->unsigned int
        ///netlong: u_long->unsigned int
        [DllImport("ws2_32.dll", EntryPoint = "ntohl", CallingConvention = CallingConvention.StdCall)]
        public static extern uint ntohl(uint netlong);


        /// Return Type: void
        ///event: DWORD->unsigned int
        ///hwnd: HWND->HWND__*
        ///idObject: LONG->int
        ///idChild: LONG->int
        [DllImport("user32.dll", EntryPoint = "NotifyWinEvent")]
        public static extern void NotifyWinEvent(uint @event, [In] IntPtr hwnd, int idObject, int idChild);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///hEvent: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "NotifyChangeEventLog")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NotifyChangeEventLog([In] IntPtr hEventLog, [In] IntPtr hEvent);


        /// Return Type: BOOL->int
        ///BootAcceptable: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "NotifyBootConfigStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NotifyBootConfigStatus([MarshalAs(UnmanagedType.Bool)] bool BootAcceptable);


        /// Return Type: UCHAR->unsigned char
        ///pncb: PNCB->_NCB*
        [DllImport("<Unknown>", EntryPoint = "Netbios")]
        public static extern byte Netbios(ref NCB pncb);


        /// Return Type: BOOL->int
        ///ExeName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "NeedCurrentDirectoryForExePathW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePathW([In] [MarshalAs(UnmanagedType.LPWStr)] string ExeName);


        /// Return Type: BOOL->int
        ///ExeName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "NeedCurrentDirectoryForExePathA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool NeedCurrentDirectoryForExePathA([In] [MarshalAs(UnmanagedType.LPStr)] string ExeName);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrXmitOrRepAsUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrXmitOrRepAsUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrXmitOrRepAsMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrXmitOrRepAsMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrXmitOrRepAsMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrXmitOrRepAsMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrXmitOrRepAsFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrXmitOrRepAsFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrXmitOrRepAsBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrXmitOrRepAsBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrVaryingArrayUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrVaryingArrayUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrVaryingArrayMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrVaryingArrayMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrVaryingArrayMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrVaryingArrayMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrVaryingArrayFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrVaryingArrayFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrVaryingArrayBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrVaryingArrayBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrUserMarshalUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrUserMarshalUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned char*
        ///pFlags: unsigned int*
        ///pBuffer: unsigned char*
        ///FormatChar: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrUserMarshalSimpleTypeConvert", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrUserMarshalSimpleTypeConvert(ref uint pFlags, IntPtr pBuffer, byte FormatChar);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrUserMarshalMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrUserMarshalMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrUserMarshalMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrUserMarshalMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrUserMarshalFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrUserMarshalFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrUserMarshalBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrUserMarshalBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: int
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pdwStubPhase: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrStubCall3", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrStubCall3(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref uint pdwStubPhase);


        /// Return Type: int
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pdwStubPhase: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrStubCall2", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrStubCall2(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref uint pdwStubPhase);


        /// Return Type: int
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pdwStubPhase: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrStubCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrStubCall(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref uint pdwStubPhase);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///FormatChar: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSimpleTypeUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrSimpleTypeUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, byte FormatChar);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///FormatChar: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSimpleTypeMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrSimpleTypeMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, byte FormatChar);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSimpleStructUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrSimpleStructUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSimpleStructMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrSimpleStructMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSimpleStructMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrSimpleStructMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSimpleStructFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrSimpleStructFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSimpleStructBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrSimpleStructBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        ///pBuffer: RPC_BUFPTR->unsigned char*
        [DllImport("<Unknown>", EntryPoint = "NdrSH_UPDecision", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrSH_UPDecision(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem, IntPtr pBuffer);


        /// Return Type: int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        [DllImport("<Unknown>", EntryPoint = "NdrSH_TLUPDecisionBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrSH_TLUPDecisionBuffer(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem);


        /// Return Type: int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        [DllImport("<Unknown>", EntryPoint = "NdrSH_TLUPDecision", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrSH_TLUPDecision(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem);


        /// Return Type: RPC_BUFPTR->unsigned char*
        ///pMessage: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char**
        ///Size: int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_StringUnMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrSH_StringUnMarshall(ref MIDL_STUB_MESSAGE pMessage, ref IntPtr pMemory, int Size);


        /// Return Type: RPC_BUFPTR->unsigned char*
        ///pMessage: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///Count: unsigned int
        ///Size: int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_StringMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrSH_StringMarshall(ref MIDL_STUB_MESSAGE pMessage, IntPtr pMemory, uint Count, int Size);


        /// Return Type: void
        ///pMessage: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtr: unsigned char*
        [DllImport("<Unknown>", EntryPoint = "NdrSH_IfFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrSH_IfFree(ref MIDL_STUB_MESSAGE pMessage, IntPtr pPtr);


        /// Return Type: RPC_BUFPTR->unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        ///Count: unsigned int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_IfCopy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrSH_IfCopy(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem, uint Count);


        /// Return Type: int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        ///Count: unsigned int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_IfAllocSet", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrSH_IfAllocSet(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem, uint Count);


        /// Return Type: int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        ///Count: unsigned int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_IfAllocRef", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrSH_IfAllocRef(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem, uint Count);


        /// Return Type: RPC_BUFPTR->unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        ///Count: unsigned int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_IfAllocCopy", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrSH_IfAllocCopy(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem, uint Count);


        /// Return Type: int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pPtrInMem: unsigned char**
        ///Count: unsigned int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_IfAlloc", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrSH_IfAlloc(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pPtrInMem, uint Count);


        /// Return Type: unsigned int
        ///pStubMsg: unsigned char*
        ///pPtrInMem: unsigned char*
        ///Count: unsigned int
        [DllImport("<Unknown>", EntryPoint = "NdrSH_Copy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrSH_Copy(IntPtr pStubMsg, IntPtr pPtrInMem, uint Count);


        /// Return Type: int
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pStubDescriptor: PMIDL_STUB_DESC->MIDL_STUB_DESC*
        ///pFormat: PFORMAT_STRING->char*
        ///pParamList: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrServerUnmarshall(ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref MIDL_STUB_MESSAGE pStubMsg, ref MIDL_STUB_DESC pStubDescriptor, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, IntPtr pParamList);


        /// Return Type: void
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerMarshall(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pStubDescriptor: PMIDL_STUB_DESC->MIDL_STUB_DESC*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerInitializeUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrServerInitializeUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref MIDL_STUB_DESC pStubDescriptor, ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pStubDescriptor: PMIDL_STUB_DESC->MIDL_STUB_DESC*
        ///RequestedBufferSize: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerInitializePartial", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerInitializePartial(ref RPC_MESSAGE pRpcMsg, ref MIDL_STUB_MESSAGE pStubMsg, ref MIDL_STUB_DESC pStubDescriptor, uint RequestedBufferSize);


        /// Return Type: unsigned char*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pStubDescriptor: PMIDL_STUB_DESC->MIDL_STUB_DESC*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerInitializeNew", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrServerInitializeNew(ref RPC_MESSAGE pRpcMsg, ref MIDL_STUB_MESSAGE pStubMsg, ref MIDL_STUB_DESC pStubDescriptor);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerInitializeMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerInitializeMarshall(ref RPC_MESSAGE pRpcMsg, ref MIDL_STUB_MESSAGE pStubMsg);


        /// Return Type: unsigned char*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pStubDescriptor: PMIDL_STUB_DESC->MIDL_STUB_DESC*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrServerInitialize(ref RPC_MESSAGE pRpcMsg, ref MIDL_STUB_MESSAGE pStubMsg, ref MIDL_STUB_DESC pStubDescriptor);


        /// Return Type: RPC_STATUS->int
        ///pInf: RPC_SERVER_INTERFACE*
        ///pCount: unsigned int*
        ///pArr: MIDL_SYNTAX_INFO**
        ///pPreferSyntaxIndex: unsigned int*
        [DllImport("<Unknown>", EntryPoint = "NdrServerGetSupportedSyntaxes", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrServerGetSupportedSyntaxes(ref RPC_SERVER_INTERFACE pInf, ref uint pCount, ref IntPtr pArr, ref uint pPreferSyntaxIndex);


        /// Return Type: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerContextUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrServerContextUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg);


        /// Return Type: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerContextNewUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrServerContextNewUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ContextHandle: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///RundownRoutine: NDR_RUNDOWN
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerContextNewMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerContextNewMarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634 ContextHandle, NDR_RUNDOWN RundownRoutine, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ContextHandle: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///RundownRoutine: NDR_RUNDOWN
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerContextMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerContextMarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634 ContextHandle, NDR_RUNDOWN RundownRoutine);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerCallNdr64", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerCallNdr64(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerCallAll", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerCallAll(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("<Unknown>", EntryPoint = "NdrServerCall3", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerCall3(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerCall2", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerCall2(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrServerCall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrServerCall(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pBufferEnd: unsigned char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrSendReceive", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrSendReceive(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pBufferEnd);


        /// Return Type: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///pBuff: void*
        ///DataRepresentation: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NDRSContextUnmarshallEx", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NDRSContextUnmarshallEx(IntPtr BindingHandle, IntPtr pBuff, uint DataRepresentation);


        /// Return Type: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///pBuff: void*
        ///DataRepresentation: unsigned int
        ///CtxGuard: void*
        ///Flags: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NDRSContextUnmarshall2", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NDRSContextUnmarshall2(IntPtr BindingHandle, IntPtr pBuff, uint DataRepresentation, IntPtr CtxGuard, uint Flags);


        /// Return Type: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///pBuff: void*
        ///DataRepresentation: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NDRSContextUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NDRSContextUnmarshall(IntPtr pBuff, uint DataRepresentation);


        /// Return Type: void
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///CContext: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///pBuff: void*
        ///userRunDownIn: NDR_RUNDOWN
        [DllImport("rpcrt4.dll", EntryPoint = "NDRSContextMarshallEx", CallingConvention = CallingConvention.StdCall)]
        public static extern void NDRSContextMarshallEx(IntPtr BindingHandle, ref Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634 CContext, IntPtr pBuff, NDR_RUNDOWN userRunDownIn);


        /// Return Type: void
        ///BindingHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///CContext: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///pBuff: void*
        ///userRunDownIn: NDR_RUNDOWN
        ///CtxGuard: void*
        ///Flags: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NDRSContextMarshall2", CallingConvention = CallingConvention.StdCall)]
        public static extern void NDRSContextMarshall2(IntPtr BindingHandle, ref Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634 CContext, IntPtr pBuff, NDR_RUNDOWN userRunDownIn, IntPtr CtxGuard, uint Flags);


        /// Return Type: void
        ///CContext: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///pBuff: void*
        ///userRunDownIn: NDR_RUNDOWN
        [DllImport("rpcrt4.dll", EntryPoint = "NDRSContextMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NDRSContextMarshall(ref Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634 CContext, IntPtr pBuff, NDR_RUNDOWN userRunDownIn);


        /// Return Type: void
        ///pMessage: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRpcSsEnableAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrRpcSsEnableAllocate(ref MIDL_STUB_MESSAGE pMessage);


        /// Return Type: void
        ///pMessage: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRpcSsDisableAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrRpcSsDisableAllocate(ref MIDL_STUB_MESSAGE pMessage);


        /// Return Type: void
        ///NodeToFree: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRpcSsDefaultFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrRpcSsDefaultFree(IntPtr NodeToFree);


        /// Return Type: void*
        ///Size: size_t->unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRpcSsDefaultAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrRpcSsDefaultAllocate([MarshalAs(UnmanagedType.SysUInt)] UIntPtr Size);


        /// Return Type: void
        ///pMessage: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRpcSmSetClientToOsf", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrRpcSmSetClientToOsf(ref MIDL_STUB_MESSAGE pMessage);


        /// Return Type: void
        ///NodeToFree: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRpcSmClientFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrRpcSmClientFree(IntPtr NodeToFree);


        /// Return Type: void*
        ///Size: size_t->unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRpcSmClientAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrRpcSmClientAllocate([MarshalAs(UnmanagedType.SysUInt)] UIntPtr Size);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrRangeUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrRangeUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPointerUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrPointerUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPointerMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrPointerMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPointerMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrPointerMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPointerFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrPointerFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPointerBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrPointerBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: void**
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPartialIgnoreServerUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrPartialIgnoreServerUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: void**
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPartialIgnoreServerInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrPartialIgnoreServerInitialize(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPartialIgnoreClientMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrPartialIgnoreClientMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrPartialIgnoreClientBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrPartialIgnoreClientBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory);


        /// Return Type: void
        ///NodeToFree: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrOleFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrOleFree(IntPtr NodeToFree);


        /// Return Type: void*
        ///Size: size_t->unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrOleAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrOleAllocate([MarshalAs(UnmanagedType.SysUInt)] UIntPtr Size);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pBufferEnd: unsigned char*
        ///pAutoHandle: RPC_BINDING_HANDLE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNsSendReceive", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrNsSendReceive(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pBufferEnd, ref IntPtr pAutoHandle);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///BufferLength: unsigned int
        ///Handle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNsGetBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrNsGetBuffer(ref MIDL_STUB_MESSAGE pStubMsg, uint BufferLength, IntPtr Handle);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonEncapsulatedUnionUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrNonEncapsulatedUnionUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonEncapsulatedUnionMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrNonEncapsulatedUnionMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonEncapsulatedUnionMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrNonEncapsulatedUnionMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonEncapsulatedUnionFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrNonEncapsulatedUnionFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonEncapsulatedUnionBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrNonEncapsulatedUnionBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonConformantStringUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrNonConformantStringUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonConformantStringMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrNonConformantStringMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonConformantStringMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrNonConformantStringMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrNonConformantStringBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrNonConformantStringBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: RPC_STATUS->int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pCommStatus: unsigned int*
        ///pFaultStatus: unsigned int*
        ///Status: RPC_STATUS->int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrMapCommAndFaultStatus", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrMapCommAndFaultStatus(ref MIDL_STUB_MESSAGE pStubMsg, ref uint pCommStatus, ref uint pFaultStatus, int Status);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrInterfacePointerUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrInterfacePointerUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrInterfacePointerMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrInterfacePointerMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrInterfacePointerMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrInterfacePointerMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrInterfacePointerFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrInterfacePointerFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrInterfacePointerBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrInterfacePointerBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: RPC_STATUS->int
        ///pFlags: unsigned int*
        ///InformationLevel: unsigned int
        ///pMarshalInfo: NDR_USER_MARSHAL_INFO*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrGetUserMarshalInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrGetUserMarshalInfo(ref uint pFlags, uint InformationLevel, ref NDR_USER_MARSHAL_INFO pMarshalInfo);


        /// Return Type: RPC_STATUS->int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pVersion: RPC_VERSION*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrGetDcomProtocolVersion", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrGetDcomProtocolVersion(ref MIDL_STUB_MESSAGE pStubMsg, ref RPC_VERSION pVersion);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///BufferLength: unsigned int
        ///Handle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrGetBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrGetBuffer(ref MIDL_STUB_MESSAGE pStubMsg, uint BufferLength, IntPtr Handle);


        /// Return Type: PFULL_PTR_XLAT_TABLES->_FULL_PTR_XLAT_TABLES*
        ///NumberOfPointers: unsigned int
        ///XlatSide: XLAT_SIDE->Anonymous_bac968f7_3f83_4950_a616_220cca7c06bf
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFullPointerXlatInit", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrFullPointerXlatInit(uint NumberOfPointers, XLAT_SIDE XlatSide);


        /// Return Type: void
        ///pXlatTables: PFULL_PTR_XLAT_TABLES->_FULL_PTR_XLAT_TABLES*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFullPointerXlatFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrFullPointerXlatFree(ref FULL_PTR_XLAT_TABLES pXlatTables);


        /// Return Type: int
        ///pXlatTables: PFULL_PTR_XLAT_TABLES->_FULL_PTR_XLAT_TABLES*
        ///RefId: unsigned int
        ///QueryType: unsigned char
        ///ppPointer: void**
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFullPointerQueryRefId", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrFullPointerQueryRefId(ref FULL_PTR_XLAT_TABLES pXlatTables, uint RefId, byte QueryType, ref IntPtr ppPointer);


        /// Return Type: int
        ///pXlatTables: PFULL_PTR_XLAT_TABLES->_FULL_PTR_XLAT_TABLES*
        ///pPointer: void*
        ///QueryType: unsigned char
        ///pRefId: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFullPointerQueryPointer", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrFullPointerQueryPointer(ref FULL_PTR_XLAT_TABLES pXlatTables, IntPtr pPointer, byte QueryType, ref uint pRefId);


        /// Return Type: void
        ///pXlatTables: PFULL_PTR_XLAT_TABLES->_FULL_PTR_XLAT_TABLES*
        ///RefId: unsigned int
        ///pPointer: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFullPointerInsertRefId", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrFullPointerInsertRefId(ref FULL_PTR_XLAT_TABLES pXlatTables, uint RefId, IntPtr pPointer);


        /// Return Type: int
        ///pXlatTables: PFULL_PTR_XLAT_TABLES->_FULL_PTR_XLAT_TABLES*
        ///Pointer: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFullPointerFree", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrFullPointerFree(ref FULL_PTR_XLAT_TABLES pXlatTables, IntPtr Pointer);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFreeBuffer", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrFreeBuffer(ref MIDL_STUB_MESSAGE pStubMsg);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFixedArrayUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrFixedArrayUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFixedArrayMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrFixedArrayMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFixedArrayMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrFixedArrayMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFixedArrayFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrFixedArrayFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrFixedArrayBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrFixedArrayBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrEncapsulatedUnionUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrEncapsulatedUnionUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrEncapsulatedUnionMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrEncapsulatedUnionMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrEncapsulatedUnionMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrEncapsulatedUnionMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrEncapsulatedUnionFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrEncapsulatedUnionFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrEncapsulatedUnionBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrEncapsulatedUnionBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: int
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pdwStubPhase: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrDcomAsyncStubCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrDcomAsyncStubCall(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref uint pdwStubPhase);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("<Unknown>", EntryPoint = "NdrCsTagUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrCsTagUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("<Unknown>", EntryPoint = "NdrCsTagMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrCsTagMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("<Unknown>", EntryPoint = "NdrCsTagMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrCsTagMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("<Unknown>", EntryPoint = "NdrCsTagBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrCsTagBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("<Unknown>", EntryPoint = "NdrCsArrayUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrCsArrayUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("<Unknown>", EntryPoint = "NdrCsArrayMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrCsArrayMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("<Unknown>", EntryPoint = "NdrCsArrayMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrCsArrayMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("<Unknown>", EntryPoint = "NdrCsArrayFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrCsArrayFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("<Unknown>", EntryPoint = "NdrCsArrayBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrCsArrayBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: RPC_STATUS->int
        ///pStub: IRpcStubBuffer*
        ///pServerIf: RPC_SERVER_INTERFACE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrCreateServerInterfaceFromStub", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrCreateServerInterfaceFromStub(ref IRpcStubBuffer pStub, ref RPC_SERVER_INTERFACE pServerIf);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrCorrelationPass", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrCorrelationPass(ref MIDL_STUB_MESSAGE pStubMsg);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: void*
        ///CacheSize: unsigned int
        ///flags: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrCorrelationInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrCorrelationInitialize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, uint CacheSize, uint flags);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrCorrelationFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrCorrelationFree(ref MIDL_STUB_MESSAGE pStubMsg);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        ///NumberParams: int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConvert2", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConvert2(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, int NumberParams);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConvert", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConvert(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrContextHandleSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrContextHandleSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: NDR_SCONTEXT->Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrContextHandleInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrContextHandleInitialize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingStructUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantVaryingStructUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingStructMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrConformantVaryingStructMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingStructMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantVaryingStructMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingStructFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantVaryingStructFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingStructBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantVaryingStructBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingArrayUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantVaryingArrayUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingArrayMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrConformantVaryingArrayMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingArrayMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantVaryingArrayMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingArrayFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantVaryingArrayFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantVaryingArrayBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantVaryingArrayBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStructUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantStructUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStructMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrConformantStructMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStructMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantStructMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStructFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantStructFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStructBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantStructBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStringUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantStringUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStringMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrConformantStringMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStringMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantStringMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantStringBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantStringBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantArrayUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantArrayUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantArrayMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrConformantArrayMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantArrayMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrConformantArrayMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantArrayFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantArrayFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrConformantArrayBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrConformantArrayBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexStructUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrComplexStructUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexStructMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrComplexStructMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexStructMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrComplexStructMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexStructFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrComplexStructFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexStructBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrComplexStructBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexArrayUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrComplexArrayUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned int
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexArrayMemorySize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint NdrComplexArrayMemorySize(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexArrayMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrComplexArrayMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexArrayFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrComplexArrayFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrComplexArrayBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrComplexArrayBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pStubDescriptor: PMIDL_STUB_DESC->MIDL_STUB_DESC*
        ///ProcNum: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientInitializeNew", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrClientInitializeNew(ref RPC_MESSAGE pRpcMsg, ref MIDL_STUB_MESSAGE pStubMsg, ref MIDL_STUB_DESC pStubDescriptor, uint ProcNum);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pStubDescriptor: PMIDL_STUB_DESC->MIDL_STUB_DESC*
        ///ProcNum: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrClientInitialize(ref RPC_MESSAGE pRpcMsg, ref MIDL_STUB_MESSAGE pStubMsg, ref MIDL_STUB_DESC pStubDescriptor, uint ProcNum);


        /// Return Type: RPC_STATUS->int
        ///pInf: RPC_CLIENT_INTERFACE*
        ///pCount: unsigned int*
        ///pArr: MIDL_SYNTAX_INFO**
        [DllImport("<Unknown>", EntryPoint = "NdrClientGetSupportedSyntaxes", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrClientGetSupportedSyntaxes(ref RPC_CLIENT_INTERFACE pInf, ref uint pCount, ref IntPtr pArr);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pContextHandle: NDR_CCONTEXT*
        ///BindHandle: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientContextUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrClientContextUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr pContextHandle, IntPtr BindHandle);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ContextHandle: NDR_CCONTEXT->void*
        ///fCheck: int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrClientContextMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrClientContextMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr ContextHandle, int fCheck);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pFormat: PFORMAT_STRING->char*
        ///ArgAddr: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrClearOutParameters", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrClearOutParameters(ref MIDL_STUB_MESSAGE pStubMsg, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, IntPtr ArgAddr);


        /// Return Type: void
        ///pCContext: NDR_CCONTEXT*
        ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///pBuff: void*
        ///DataRepresentation: unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NDRCContextUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NDRCContextUnmarshall(ref IntPtr pCContext, IntPtr hBinding, IntPtr pBuff, uint DataRepresentation);


        /// Return Type: void
        ///CContext: NDR_CCONTEXT->void*
        ///pBuff: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NDRCContextMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NDRCContextMarshall(IntPtr CContext, IntPtr pBuff);


        /// Return Type: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
        ///CContext: NDR_CCONTEXT->void*
        [DllImport("rpcrt4.dll", EntryPoint = "NDRCContextBinding", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NDRCContextBinding(IntPtr CContext);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///ppMemory: unsigned char**
        ///pFormat: PFORMAT_STRING->char*
        ///fMustAlloc: unsigned char
        [DllImport("rpcrt4.dll", EntryPoint = "NdrByteCountPointerUnmarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrByteCountPointerUnmarshall(ref MIDL_STUB_MESSAGE pStubMsg, ref IntPtr ppMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat, byte fMustAlloc);


        /// Return Type: unsigned char*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrByteCountPointerMarshall", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrByteCountPointerMarshall(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrByteCountPointerFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrByteCountPointerFree(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: void
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///pMemory: unsigned char*
        ///pFormat: PFORMAT_STRING->char*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrByteCountPointerBufferSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrByteCountPointerBufferSize(ref MIDL_STUB_MESSAGE pStubMsg, IntPtr pMemory, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormat);


        /// Return Type: int
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pdwStubPhase: unsigned int*
        [DllImport("<Unknown>", EntryPoint = "NdrAsyncStubCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int NdrAsyncStubCall(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref uint pdwStubPhase);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrAsyncServerCall", CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrAsyncServerCall(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void*
        ///pStubMsg: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
        ///Len: size_t->unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrAllocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrAllocate(ref MIDL_STUB_MESSAGE pStubMsg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr Len);


        /// Return Type: int
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pdwStubPhase: unsigned int*
        [DllImport("rpcrt4.dll", EntryPoint = "Ndr64DcomAsyncStubCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int Ndr64DcomAsyncStubCall(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref uint pdwStubPhase);


        /// Return Type: int
        ///pThis: IRpcStubBuffer*
        ///pChannel: IRpcChannelBuffer*
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        ///pdwStubPhase: unsigned int*
        [DllImport("<Unknown>", EntryPoint = "Ndr64AsyncStubCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int Ndr64AsyncStubCall(ref IRpcStubBuffer pThis, ref IRpcChannelBuffer pChannel, ref RPC_MESSAGE pRpcMsg, ref uint pdwStubPhase);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "Ndr64AsyncServerCallAll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Ndr64AsyncServerCallAll(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("rpcrt4.dll", EntryPoint = "Ndr64AsyncServerCall64", CallingConvention = CallingConvention.StdCall)]
        public static extern void Ndr64AsyncServerCall64(ref RPC_MESSAGE pRpcMsg);


        /// Return Type: void
        ///pRpcMsg: PRPC_MESSAGE->_RPC_MESSAGE*
        [DllImport("<Unknown>", EntryPoint = "Ndr64AsyncServerCall", CallingConvention = CallingConvention.StdCall)]
        public static extern void Ndr64AsyncServerCall(ref RPC_MESSAGE pRpcMsg);

    }

}
