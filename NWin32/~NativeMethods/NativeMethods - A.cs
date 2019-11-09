using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT->unsigned int
        ///dwVolume: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "auxSetVolume")]
        public static extern uint auxSetVolume(uint uDeviceID, uint dwVolume);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT->unsigned int
        ///uMsg: UINT->unsigned int
        ///dw1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dw2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "auxOutMessage")]
        public static extern uint auxOutMessage(uint uDeviceID, uint uMsg, uint dw1, uint dw2);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT->unsigned int
        ///pdwVolume: LPDWORD->DWORD*
        [DllImport("winmm.dll", EntryPoint = "auxGetVolume")]
        public static extern uint auxGetVolume(uint uDeviceID, ref uint pdwVolume);


        /// Return Type: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "auxGetNumDevs")]
        public static extern uint auxGetNumDevs();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pac: LPAUXCAPSW->tagAUXCAPSW*
        ///cbac: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "auxGetDevCapsW")]
        public static extern uint auxGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagAUXCAPSW pac, uint cbac);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pac: LPAUXCAPSA->tagAUXCAPSA*
        ///cbac: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "auxGetDevCapsA")]
        public static extern uint auxGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagAUXCAPSA pac, uint cbac);


        /// Return Type: BOOL->int
        ///idAttach: DWORD->unsigned int
        ///idAttachTo: DWORD->unsigned int
        ///fAttach: BOOL->int
        [DllImport("user32.dll", EntryPoint = "AttachThreadInput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, [MarshalAs(UnmanagedType.Bool)] bool fAttach);


        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "AttachConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachConsole(uint dwProcessId);


        /// Return Type: int
        ///_Str: char*
        [DllImport("ntdll.dll", EntryPoint = "atol", CallingConvention = CallingConvention.Cdecl)]
        public static extern int atol([In] [MarshalAs(UnmanagedType.LPStr)] string _Str);


        /// Return Type: int
        ///_Str: char*
        [DllImport("ntdll.dll", EntryPoint = "atoi", CallingConvention = CallingConvention.Cdecl)]
        public static extern int atoi([In] [MarshalAs(UnmanagedType.LPStr)] string _Str);


        /// Return Type: double
        ///_String: char*
        [DllImport("msvcr80.dll", EntryPoint = "atof", CallingConvention = CallingConvention.Cdecl)]
        public static extern double atof([In] [MarshalAs(UnmanagedType.LPStr)] string _String);


        /// Return Type: int
        ///param0: Anonymous_a3debd67_ecba_49a0_9c67_1b83f463a375
        [DllImport("msvcr80.dll", EntryPoint = "atexit", CallingConvention = CallingConvention.Cdecl)]
        public static extern int atexit(Anonymous_a3debd67_ecba_49a0_9c67_1b83f463a375 param0);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "ASYNC_STGMEDIUM_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ASYNC_STGMEDIUM_UserUnmarshal(ref uint param0, IntPtr param1, ref tagSTGMEDIUM param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "ASYNC_STGMEDIUM_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint ASYNC_STGMEDIUM_UserSize(ref uint param0, uint param1, ref tagSTGMEDIUM param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "ASYNC_STGMEDIUM_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ASYNC_STGMEDIUM_UserMarshal(ref uint param0, IntPtr param1, ref tagSTGMEDIUM param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "ASYNC_STGMEDIUM_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void ASYNC_STGMEDIUM_UserFree(ref uint param0, ref tagSTGMEDIUM param1);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Finish_Release_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIUnknown_Finish_Release_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: ULONG->unsigned int
        ///This: AsyncIUnknown*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Finish_Release_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint AsyncIUnknown_Finish_Release_Proxy(ref AsyncIUnknown This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Finish_QueryInterface_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIUnknown_Finish_QueryInterface_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIUnknown*
        ///ppvObject: void**
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Finish_QueryInterface_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIUnknown_Finish_QueryInterface_Proxy(ref AsyncIUnknown This, ref IntPtr ppvObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Finish_AddRef_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIUnknown_Finish_AddRef_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: ULONG->unsigned int
        ///This: AsyncIUnknown*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Finish_AddRef_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern uint AsyncIUnknown_Finish_AddRef_Proxy(ref AsyncIUnknown This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Begin_Release_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIUnknown_Begin_Release_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIUnknown*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Begin_Release_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIUnknown_Begin_Release_Proxy(ref AsyncIUnknown This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Begin_QueryInterface_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIUnknown_Begin_QueryInterface_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIUnknown*
        ///riid: IID*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Begin_QueryInterface_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIUnknown_Begin_QueryInterface_Proxy(ref AsyncIUnknown This, ref GUID riid);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Begin_AddRef_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIUnknown_Begin_AddRef_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIUnknown*
        [DllImport("<Unknown>", EntryPoint = "AsyncIUnknown_Begin_AddRef_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIUnknown_Begin_AddRef_Proxy(ref AsyncIUnknown This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Finish_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeLong_Finish_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeLong*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Finish_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeLong_Finish_Push_Proxy(ref AsyncIPipeLong This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Finish_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeLong_Finish_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeLong*
        ///buf: LONG*
        ///pcReturned: ULONG*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Finish_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeLong_Finish_Pull_Proxy(ref AsyncIPipeLong This, ref int buf, ref uint pcReturned);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Begin_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeLong_Begin_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeLong*
        ///buf: LONG*
        ///cSent: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Begin_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeLong_Begin_Push_Proxy(ref AsyncIPipeLong This, ref int buf, uint cSent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Begin_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeLong_Begin_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeLong*
        ///cRequest: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeLong_Begin_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeLong_Begin_Pull_Proxy(ref AsyncIPipeLong This, uint cRequest);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Finish_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeDouble_Finish_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeDouble*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Finish_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeDouble_Finish_Push_Proxy(ref AsyncIPipeDouble This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Finish_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeDouble_Finish_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeDouble*
        ///buf: DOUBLE*
        ///pcReturned: ULONG*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Finish_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeDouble_Finish_Pull_Proxy(ref AsyncIPipeDouble This, ref double buf, ref uint pcReturned);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Begin_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeDouble_Begin_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeDouble*
        ///buf: DOUBLE*
        ///cSent: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Begin_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeDouble_Begin_Push_Proxy(ref AsyncIPipeDouble This, ref double buf, uint cSent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Begin_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeDouble_Begin_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeDouble*
        ///cRequest: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeDouble_Begin_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeDouble_Begin_Pull_Proxy(ref AsyncIPipeDouble This, uint cRequest);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Finish_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeByte_Finish_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeByte*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Finish_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeByte_Finish_Push_Proxy(ref AsyncIPipeByte This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Finish_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeByte_Finish_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeByte*
        ///buf: BYTE*
        ///pcReturned: ULONG*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Finish_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeByte_Finish_Pull_Proxy(ref AsyncIPipeByte This, ref byte buf, ref uint pcReturned);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Begin_Push_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeByte_Begin_Push_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeByte*
        ///buf: BYTE*
        ///cSent: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Begin_Push_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeByte_Begin_Push_Proxy(ref AsyncIPipeByte This, ref byte buf, uint cSent);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Begin_Pull_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIPipeByte_Begin_Pull_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIPipeByte*
        ///cRequest: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AsyncIPipeByte_Begin_Pull_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIPipeByte_Begin_Pull_Proxy(ref AsyncIPipeByte This, uint cRequest);


        /// Return Type: HRESULT->LONG->int
        ///szDistUnit: LPCWSTR->WCHAR*
        ///szTYPE: LPCWSTR->WCHAR*
        ///szExt: LPCWSTR->WCHAR*
        ///dwFileVersionMS: DWORD->unsigned int
        ///dwFileVersionLS: DWORD->unsigned int
        ///szURL: LPCWSTR->WCHAR*
        ///pbc: IBindCtx*
        ///pvReserved: LPVOID->void*
        ///flags: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "AsyncInstallDistributionUnit", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncInstallDistributionUnit([In] [MarshalAs(UnmanagedType.LPWStr)] string szDistUnit, [In] [MarshalAs(UnmanagedType.LPWStr)] string szTYPE, [In] [MarshalAs(UnmanagedType.LPWStr)] string szExt, uint dwFileVersionMS, uint dwFileVersionLS, [In] [MarshalAs(UnmanagedType.LPWStr)] string szURL, ref IBindCtx pbc, IntPtr pvReserved, uint flags);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIMultiQI_Finish_QueryMultipleInterfaces_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIMultiQI_Finish_QueryMultipleInterfaces_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIMultiQI*
        ///pMQIs: MULTI_QI*
        [DllImport("<Unknown>", EntryPoint = "AsyncIMultiQI_Finish_QueryMultipleInterfaces_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIMultiQI_Finish_QueryMultipleInterfaces_Proxy(ref AsyncIMultiQI This, ref tagMULTI_QI pMQIs);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIMultiQI_Begin_QueryMultipleInterfaces_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIMultiQI_Begin_QueryMultipleInterfaces_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIMultiQI*
        ///cMQIs: ULONG->unsigned int
        ///pMQIs: MULTI_QI*
        [DllImport("<Unknown>", EntryPoint = "AsyncIMultiQI_Begin_QueryMultipleInterfaces_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIMultiQI_Begin_QueryMultipleInterfaces_Proxy(ref AsyncIMultiQI This, uint cMQIs, ref tagMULTI_QI pMQIs);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnViewChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_RemoteOnViewChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnViewChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_RemoteOnViewChange_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnSave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_RemoteOnSave_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnSave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_RemoteOnSave_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnRename_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_RemoteOnRename_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnRename_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_RemoteOnRename_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnDataChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_RemoteOnDataChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnDataChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_RemoteOnDataChange_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnClose_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_RemoteOnClose_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_RemoteOnClose_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_RemoteOnClose_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnViewChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_OnViewChange_Stub(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnViewChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_OnViewChange_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnSave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_OnSave_Stub(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnSave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_OnSave_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnRename_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_OnRename_Stub(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnRename_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_OnRename_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnDataChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_OnDataChange_Stub(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnDataChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_OnDataChange_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnClose_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Finish_OnClose_Stub(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Finish_OnClose_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Finish_OnClose_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnViewChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_RemoteOnViewChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        ///dwAspect: DWORD->unsigned int
        ///lindex: LONG->int
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnViewChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_RemoteOnViewChange_Proxy(ref AsyncIAdviseSink This, uint dwAspect, int lindex);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnSave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_RemoteOnSave_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnSave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_RemoteOnSave_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnRename_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_RemoteOnRename_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnRename_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_RemoteOnRename_Proxy(ref AsyncIAdviseSink This, ref IMoniker pmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnDataChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_RemoteOnDataChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        ///pFormatetc: FORMATETC*
        ///pStgmed: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnDataChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_RemoteOnDataChange_Proxy(ref AsyncIAdviseSink This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnClose_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_RemoteOnClose_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_RemoteOnClose_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_RemoteOnClose_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        ///dwAspect: DWORD->unsigned int
        ///lindex: LONG->int
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnViewChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_OnViewChange_Stub(ref AsyncIAdviseSink This, uint dwAspect, int lindex);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        ///dwAspect: DWORD->unsigned int
        ///lindex: LONG->int
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnViewChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_OnViewChange_Proxy(ref AsyncIAdviseSink This, uint dwAspect, int lindex);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnSave_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_OnSave_Stub(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnSave_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_OnSave_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnRename_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_OnRename_Stub(ref AsyncIAdviseSink This, ref IMoniker pmk);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnRename_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_OnRename_Proxy(ref AsyncIAdviseSink This, ref IMoniker pmk);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        ///pFormatetc: FORMATETC*
        ///pStgmed: ASYNC_STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnDataChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_OnDataChange_Stub(ref AsyncIAdviseSink This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        ///pFormatetc: FORMATETC*
        ///pStgmed: STGMEDIUM*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnDataChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_OnDataChange_Proxy(ref AsyncIAdviseSink This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnClose_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink_Begin_OnClose_Stub(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: AsyncIAdviseSink*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink_Begin_OnClose_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink_Begin_OnClose_Proxy(ref AsyncIAdviseSink This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Finish_RemoteOnLinkSrcChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink2_Finish_RemoteOnLinkSrcChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink2*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Finish_RemoteOnLinkSrcChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink2_Finish_RemoteOnLinkSrcChange_Proxy(ref AsyncIAdviseSink2 This);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink2*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Finish_OnLinkSrcChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink2_Finish_OnLinkSrcChange_Stub(ref AsyncIAdviseSink2 This);


        /// Return Type: void
        ///This: AsyncIAdviseSink2*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Finish_OnLinkSrcChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink2_Finish_OnLinkSrcChange_Proxy(ref AsyncIAdviseSink2 This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Begin_RemoteOnLinkSrcChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink2_Begin_RemoteOnLinkSrcChange_Stub(ref IRpcStubBuffer This, ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink2*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Begin_RemoteOnLinkSrcChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink2_Begin_RemoteOnLinkSrcChange_Proxy(ref AsyncIAdviseSink2 This, ref IMoniker pmk);


        /// Return Type: HRESULT->LONG->int
        ///This: AsyncIAdviseSink2*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Begin_OnLinkSrcChange_Stub", CallingConvention = CallingConvention.StdCall)]
        public static extern int AsyncIAdviseSink2_Begin_OnLinkSrcChange_Stub(ref AsyncIAdviseSink2 This, ref IMoniker pmk);


        /// Return Type: void
        ///This: AsyncIAdviseSink2*
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "AsyncIAdviseSink2_Begin_OnLinkSrcChange_Proxy", CallingConvention = CallingConvention.StdCall)]
        public static extern void AsyncIAdviseSink2_Begin_OnLinkSrcChange_Proxy(ref AsyncIAdviseSink2 This, ref IMoniker pmk);


        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///hProcess: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "AssignProcessToJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AssignProcessToJobObject([In] IntPtr hJob, [In] IntPtr hProcess);


        /// Return Type: UINT->unsigned int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ArrangeIconicWindows")]
        public static extern uint ArrangeIconicWindows([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "AreFileApisANSI")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AreFileApisANSI();


        /// Return Type: BOOL->int
        ///GrantedAccess: DWORD->unsigned int
        ///DesiredAccess: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "AreAnyAccessesGranted")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AreAnyAccessesGranted(uint GrantedAccess, uint DesiredAccess);


        /// Return Type: BOOL->int
        ///GrantedAccess: DWORD->unsigned int
        ///DesiredAccess: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "AreAllAccessesGranted")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AreAllAccessesGranted(uint GrantedAccess, uint DesiredAccess);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        ///xr1: int
        ///yr1: int
        ///xr2: int
        ///yr2: int
        [DllImport("gdi32.dll", EntryPoint = "ArcTo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ArcTo([In] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        ///x3: int
        ///y3: int
        ///x4: int
        ///y4: int
        [DllImport("gdi32.dll", EntryPoint = "Arc")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Arc([In] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "AppendMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenuW([In] IntPtr hMenu, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uIDNewItem, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "AppendMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenuA([In] IntPtr hMenu, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uIDNewItem, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "AnyPopup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnyPopup();


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///dwTime: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnimateWindow([In] IntPtr hWnd, uint dwTime, uint dwFlags);


        /// Return Type: BOOL->int
        ///hPal: HPALETTE->HPALETTE__*
        ///iStartIndex: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///ppe: PALETTEENTRY*
        [DllImport("gdi32.dll", EntryPoint = "AnimatePalette")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnimatePalette([In] IntPtr hPal, uint iStartIndex, uint cEntries, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPALETTEENTRY[] ppe);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///r: DWORD->unsigned int
        ///StartAngle: FLOAT->float
        ///SweepAngle: FLOAT->float
        [DllImport("gdi32.dll", EntryPoint = "AngleArc")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AngleArc([In] IntPtr hdc, int x, int y, uint r, float StartAngle, float SweepAngle);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///xoriginDest: int
        ///yoriginDest: int
        ///wDest: int
        ///hDest: int
        ///hdcSrc: HDC->HDC__*
        ///xoriginSrc: int
        ///yoriginSrc: int
        ///wSrc: int
        ///hSrc: int
        ///ftn: BLENDFUNCTION->_BLENDFUNCTION
        [DllImport("msimg32.dll", EntryPoint = "AlphaBlend")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AlphaBlend([In] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [In] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);


        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "AllowSetForegroundWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllowSetForegroundWindow(uint dwProcessId);


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///NumberOfPages: PULONG_PTR->unsigned int*
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "AllocateUserPhysicalPages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocateUserPhysicalPages([In] IntPtr hProcess, ref uint NumberOfPages, IntPtr PageArray);


        /// Return Type: BOOL->int
        ///Luid: PLUID->_LUID*
        [DllImport("advapi32.dll", EntryPoint = "AllocateLocallyUniqueId")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocateLocallyUniqueId([Out] out LUID Luid);


        /// Return Type: BOOL->int
        ///pIdentifierAuthority: PSID_IDENTIFIER_AUTHORITY->_SID_IDENTIFIER_AUTHORITY*
        ///nSubAuthorityCount: BYTE->unsigned char
        ///nSubAuthority0: DWORD->unsigned int
        ///nSubAuthority1: DWORD->unsigned int
        ///nSubAuthority2: DWORD->unsigned int
        ///nSubAuthority3: DWORD->unsigned int
        ///nSubAuthority4: DWORD->unsigned int
        ///nSubAuthority5: DWORD->unsigned int
        ///nSubAuthority6: DWORD->unsigned int
        ///nSubAuthority7: DWORD->unsigned int
        ///pSid: PSID*
        [DllImport("advapi32.dll", EntryPoint = "AllocateAndInitializeSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocateAndInitializeSid([In] ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, byte nSubAuthorityCount, uint nSubAuthority0, uint nSubAuthority1, uint nSubAuthority2, uint nSubAuthority3, uint nSubAuthority4, uint nSubAuthority5, uint nSubAuthority6, uint nSubAuthority7, out IntPtr pSid);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///hPrinter: HANDLE->void*
        ///pDeviceName: LPWSTR->WCHAR*
        ///pDevModeOutput: PDEVMODEW->_devicemodeW*
        ///pDevModeInput: PDEVMODEW->_devicemodeW*
        [DllImport("<Unknown>", EntryPoint = "AdvancedDocumentPropertiesW")]
        public static extern int AdvancedDocumentPropertiesW([In] IntPtr hWnd, [In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pDeviceName, IntPtr pDevModeOutput, [In] IntPtr pDevModeInput);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///hPrinter: HANDLE->void*
        ///pDeviceName: LPSTR->CHAR*
        ///pDevModeOutput: PDEVMODEA->_devicemodeA*
        ///pDevModeInput: PDEVMODEA->_devicemodeA*
        [DllImport("<Unknown>", EntryPoint = "AdvancedDocumentPropertiesA")]
        public static extern int AdvancedDocumentPropertiesA([In] IntPtr hWnd, [In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pDeviceName, IntPtr pDevModeOutput, [In] IntPtr pDevModeInput);


        /// Return Type: BOOL->int
        ///lpRect: LPRECT->tagRECT*
        ///dwStyle: DWORD->unsigned int
        ///bMenu: BOOL->int
        ///dwExStyle: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRectEx(ref tagRECT lpRect, uint dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, uint dwExStyle);


        /// Return Type: BOOL->int
        ///lpRect: LPRECT->tagRECT*
        ///dwStyle: DWORD->unsigned int
        ///bMenu: BOOL->int
        [DllImport("user32.dll", EntryPoint = "AdjustWindowRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRect(ref tagRECT lpRect, uint dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu);


        /// Return Type: BOOL->int
        ///TokenHandle: HANDLE->void*
        ///DisableAllPrivileges: BOOL->int
        ///NewState: PTOKEN_PRIVILEGES->_TOKEN_PRIVILEGES*
        ///BufferLength: DWORD->unsigned int
        ///PreviousState: PTOKEN_PRIVILEGES->_TOKEN_PRIVILEGES*
        ///ReturnLength: PDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "AdjustTokenPrivileges")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustTokenPrivileges([In] IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, [In] IntPtr NewState, uint BufferLength, IntPtr PreviousState, IntPtr ReturnLength);


        /// Return Type: BOOL->int
        ///TokenHandle: HANDLE->void*
        ///ResetToDefault: BOOL->int
        ///NewState: PTOKEN_GROUPS->_TOKEN_GROUPS*
        ///BufferLength: DWORD->unsigned int
        ///PreviousState: PTOKEN_GROUPS->_TOKEN_GROUPS*
        ///ReturnLength: PDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "AdjustTokenGroups")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustTokenGroups([In] IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool ResetToDefault, [In] IntPtr NewState, uint BufferLength, IntPtr PreviousState, IntPtr ReturnLength);


        /// Return Type: PVOID->void*
        ///First: ULONG->unsigned int
        ///Handler: PVECTORED_EXCEPTION_HANDLER
        [DllImport("kernel32.dll", EntryPoint = "AddVectoredExceptionHandler")]
        public static extern IntPtr AddVectoredExceptionHandler(uint First, PVECTORED_EXCEPTION_HANDLER Handler);


        /// Return Type: PVOID->void*
        ///First: ULONG->unsigned int
        ///Handler: PVECTORED_EXCEPTION_HANDLER
        [DllImport("kernel32.dll", EntryPoint = "AddVectoredContinueHandler")]
        public static extern IntPtr AddVectoredContinueHandler(uint First, PVECTORED_EXCEPTION_HANDLER Handler);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///pUsers: PENCRYPTION_CERTIFICATE_LIST->_ENCRYPTION_CERTIFICATE_LIST*
        [DllImport("advapi32.dll", EntryPoint = "AddUsersToEncryptedFile")]
        public static extern uint AddUsersToEncryptedFile([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [In] ref ENCRYPTION_CERTIFICATE_LIST pUsers);


        /// Return Type: void
        ///hActCtx: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "AddRefActCtx")]
        public static extern void AddRefActCtx(IntPtr hActCtx);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///level: DWORD->unsigned int
        ///pProvidorInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddPrintProvidorW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrintProvidorW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, uint level, [In] ref byte pProvidorInfo);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///level: DWORD->unsigned int
        ///pProvidorInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddPrintProvidorA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrintProvidorA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, uint level, [In] ref byte pProvidorInfo);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///pPathName: LPWSTR->WCHAR*
        ///pPrintProcessorName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "AddPrintProcessorW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrintProcessorW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPathName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPrintProcessorName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///pPathName: LPSTR->CHAR*
        ///pPrintProcessorName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "AddPrintProcessorA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrintProcessorA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string pPathName, [In] [MarshalAs(UnmanagedType.LPStr)] string pPrintProcessorName);


        /// Return Type: HANDLE->void*
        ///pName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pPrinter: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddPrinterW")]
        public static extern IntPtr AddPrinterW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, uint Level, [In] ref byte pPrinter);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddPrinterDriverW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrinterDriverW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, uint Level, ref byte pDriverInfo);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        ///dwFileCopyFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AddPrinterDriverExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrinterDriverExW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, uint Level, ref byte pDriverInfo, uint dwFileCopyFlags);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        ///dwFileCopyFlags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "AddPrinterDriverExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrinterDriverExA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, uint Level, ref byte pDriverInfo, uint dwFileCopyFlags);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddPrinterDriverA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrinterDriverA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, uint Level, ref byte pDriverInfo);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "AddPrinterConnectionW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrinterConnectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "AddPrinterConnectionA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPrinterConnectionA([In] [MarshalAs(UnmanagedType.LPStr)] string pName);


        /// Return Type: HANDLE->void*
        ///pName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pPrinter: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddPrinterA")]
        public static extern IntPtr AddPrinterA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, uint Level, [In] ref byte pPrinter);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///hWnd: HWND->HWND__*
        ///pMonitorName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "AddPortW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPortW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string pMonitorName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///hWnd: HWND->HWND__*
        ///pMonitorName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "AddPortA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddPortA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string pMonitorName);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pMonitorInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddMonitorW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddMonitorW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, uint Level, [In] IntPtr pMonitorInfo);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pMonitorInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddMonitorA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddMonitorA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, uint Level, [In] IntPtr pMonitorInfo);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pData: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "AddJobW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddJobW([In] IntPtr hPrinter, uint Level, IntPtr pData, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pData: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "AddJobA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddJobA([In] IntPtr hPrinter, uint Level, IntPtr pData, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddFormW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddFormW([In] IntPtr hPrinter, uint Level, [In] ref byte pForm);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "AddFormA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddFormA([In] IntPtr hPrinter, uint Level, [In] ref byte pForm);


        /// Return Type: int
        ///param0: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW")]
        public static extern int AddFontResourceW([In] [MarshalAs(UnmanagedType.LPWStr)] string param0);


        /// Return Type: int
        ///name: LPCWSTR->WCHAR*
        ///fl: DWORD->unsigned int
        ///res: PVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceExW")]
        public static extern int AddFontResourceExW([In] [MarshalAs(UnmanagedType.LPWStr)] string name, uint fl, IntPtr res);


        /// Return Type: int
        ///name: LPCSTR->CHAR*
        ///fl: DWORD->unsigned int
        ///res: PVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceExA")]
        public static extern int AddFontResourceExA([In] [MarshalAs(UnmanagedType.LPStr)] string name, uint fl, IntPtr res);


        /// Return Type: int
        ///param0: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceA")]
        public static extern int AddFontResourceA([In] [MarshalAs(UnmanagedType.LPStr)] string param0);


        /// Return Type: HANDLE->void*
        ///pFileView: PVOID->void*
        ///cjSize: DWORD->unsigned int
        ///pvResrved: PVOID->void*
        ///pNumFonts: DWORD*
        [DllImport("gdi32.dll", EntryPoint = "AddFontMemResourceEx")]
        public static extern IntPtr AddFontMemResourceEx([In] IntPtr pFileView, uint cjSize, IntPtr pvResrved, [In] ref uint pNumFonts);


        /// Return Type: BOOL->int
        ///Source: LPWSTR->WCHAR*
        ///Target: LPWSTR->WCHAR*
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddConsoleAliasW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddConsoleAliasW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder Source, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder Target, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///Source: LPSTR->CHAR*
        ///Target: LPSTR->CHAR*
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddConsoleAliasA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder Source, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder Target, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AceFlags: DWORD->unsigned int
        ///AccessMask: DWORD->unsigned int
        ///ObjectTypeGuid: GUID*
        ///InheritedObjectTypeGuid: GUID*
        ///pSid: PSID->PVOID->void*
        ///bAuditSuccess: BOOL->int
        ///bAuditFailure: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "AddAuditAccessObjectAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAuditAccessObjectAce(ref ACL pAcl, uint dwAceRevision, uint AceFlags, uint AccessMask, [In] IntPtr ObjectTypeGuid, [In] IntPtr InheritedObjectTypeGuid, [In] IntPtr pSid, [MarshalAs(UnmanagedType.Bool)] bool bAuditSuccess, [MarshalAs(UnmanagedType.Bool)] bool bAuditFailure);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AceFlags: DWORD->unsigned int
        ///dwAccessMask: DWORD->unsigned int
        ///pSid: PSID->PVOID->void*
        ///bAuditSuccess: BOOL->int
        ///bAuditFailure: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "AddAuditAccessAceEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAuditAccessAceEx(ref ACL pAcl, uint dwAceRevision, uint AceFlags, uint dwAccessMask, [In] IntPtr pSid, [MarshalAs(UnmanagedType.Bool)] bool bAuditSuccess, [MarshalAs(UnmanagedType.Bool)] bool bAuditFailure);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///dwAccessMask: DWORD->unsigned int
        ///pSid: PSID->PVOID->void*
        ///bAuditSuccess: BOOL->int
        ///bAuditFailure: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "AddAuditAccessAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAuditAccessAce(ref ACL pAcl, uint dwAceRevision, uint dwAccessMask, [In] IntPtr pSid, [MarshalAs(UnmanagedType.Bool)] bool bAuditSuccess, [MarshalAs(UnmanagedType.Bool)] bool bAuditFailure);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddAtomW")]
        public static extern ushort AddAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddAtomA")]
        public static extern ushort AddAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///dwStartingAceIndex: DWORD->unsigned int
        ///pAceList: LPVOID->void*
        ///nAceListLength: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "AddAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAce(ref ACL pAcl, uint dwAceRevision, uint dwStartingAceIndex, [In] IntPtr pAceList, uint nAceListLength);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AceFlags: DWORD->unsigned int
        ///AccessMask: DWORD->unsigned int
        ///ObjectTypeGuid: GUID*
        ///InheritedObjectTypeGuid: GUID*
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "AddAccessDeniedObjectAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAccessDeniedObjectAce(ref ACL pAcl, uint dwAceRevision, uint AceFlags, uint AccessMask, [In] IntPtr ObjectTypeGuid, [In] IntPtr InheritedObjectTypeGuid, [In] IntPtr pSid);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AceFlags: DWORD->unsigned int
        ///AccessMask: DWORD->unsigned int
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "AddAccessDeniedAceEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAccessDeniedAceEx(ref ACL pAcl, uint dwAceRevision, uint AceFlags, uint AccessMask, [In] IntPtr pSid);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AccessMask: DWORD->unsigned int
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "AddAccessDeniedAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAccessDeniedAce(ref ACL pAcl, uint dwAceRevision, uint AccessMask, [In] IntPtr pSid);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AceFlags: DWORD->unsigned int
        ///AccessMask: DWORD->unsigned int
        ///ObjectTypeGuid: GUID*
        ///InheritedObjectTypeGuid: GUID*
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "AddAccessAllowedObjectAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAccessAllowedObjectAce(ref ACL pAcl, uint dwAceRevision, uint AceFlags, uint AccessMask, [In] IntPtr ObjectTypeGuid, [In] IntPtr InheritedObjectTypeGuid, [In] IntPtr pSid);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AceFlags: DWORD->unsigned int
        ///AccessMask: DWORD->unsigned int
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "AddAccessAllowedAceEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAccessAllowedAceEx(ref ACL pAcl, uint dwAceRevision, uint AceFlags, uint AccessMask, [In] IntPtr pSid);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceRevision: DWORD->unsigned int
        ///AccessMask: DWORD->unsigned int
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "AddAccessAllowedAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddAccessAllowedAce(ref ACL pAcl, uint dwAceRevision, uint AccessMask, [In] IntPtr pSid);


        /// Return Type: HKL->HKL__*
        ///hkl: HKL->HKL__*
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ActivateKeyboardLayout")]
        public static extern IntPtr ActivateKeyboardLayout([In] IntPtr hkl, uint Flags);


        /// Return Type: BOOL->int
        ///hActCtx: HANDLE->void*
        ///lpCookie: ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "ActivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ActivateActCtx(IntPtr hActCtx, [Out] out uint lpCookie);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPCWSTR->WCHAR*
        ///ObjectName: LPCWSTR->WCHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///AuditType: AUDIT_EVENT_TYPE->_AUDIT_EVENT_TYPE
        ///Flags: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatusList: LPDWORD->DWORD*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByTypeResultListAndAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByTypeResultListAndAuditAlarmW(
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName,
                    [In] IntPtr HandleId,
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectTypeName,
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectName,
                    [In] IntPtr SecurityDescriptor,
                    [In] IntPtr PrincipalSelfSid,
                    uint DesiredAccess,
                    AUDIT_EVENT_TYPE AuditType,
                    uint Flags,
                    IntPtr ObjectTypeList,
                    uint ObjectTypeListLength,
                    [In] ref GENERIC_MAPPING GenericMapping,
                    [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation,
                    [Out] out uint GrantedAccess,
                    [Out] out uint AccessStatusList,
                    [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///ClientToken: HANDLE->void*
        ///ObjectTypeName: LPCWSTR->WCHAR*
        ///ObjectName: LPCWSTR->WCHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///AuditType: AUDIT_EVENT_TYPE->_AUDIT_EVENT_TYPE
        ///Flags: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatusList: LPDWORD->DWORD*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByTypeResultListAndAuditAlarmByHandleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByTypeResultListAndAuditAlarmByHandleW(
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName,
                    [In] IntPtr HandleId,
                    [In] IntPtr ClientToken,
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectTypeName,
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectName,
                    [In] IntPtr SecurityDescriptor,
                    [In] IntPtr PrincipalSelfSid,
                    uint DesiredAccess,
                    AUDIT_EVENT_TYPE AuditType,
                    uint Flags,
                    IntPtr ObjectTypeList,
                    uint ObjectTypeListLength,
                    [In] ref GENERIC_MAPPING GenericMapping,
                    [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation,
                    [Out] out uint GrantedAccess,
                    [Out] out uint AccessStatusList,
                    [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///ClientToken: HANDLE->void*
        ///ObjectTypeName: LPCSTR->CHAR*
        ///ObjectName: LPCSTR->CHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///AuditType: AUDIT_EVENT_TYPE->_AUDIT_EVENT_TYPE
        ///Flags: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatusList: LPDWORD->DWORD*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByTypeResultListAndAuditAlarmByHandleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByTypeResultListAndAuditAlarmByHandleA(
                    [In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName,
                    [In] IntPtr HandleId,
                    [In] IntPtr ClientToken,
                    [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectTypeName,
                    [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectName,
                    [In] IntPtr SecurityDescriptor,
                    [In] IntPtr PrincipalSelfSid,
                    uint DesiredAccess,
                    AUDIT_EVENT_TYPE AuditType,
                    uint Flags,
                    IntPtr ObjectTypeList,
                    uint ObjectTypeListLength,
                    [In] ref GENERIC_MAPPING GenericMapping,
                    [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation,
                    [Out] out uint GrantedAccess,
                    [Out] out uint AccessStatusList,
                    [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPCSTR->CHAR*
        ///ObjectName: LPCSTR->CHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///AuditType: AUDIT_EVENT_TYPE->_AUDIT_EVENT_TYPE
        ///Flags: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatusList: LPDWORD->DWORD*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByTypeResultListAndAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByTypeResultListAndAuditAlarmA(
                    [In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName,
                    [In] IntPtr HandleId,
                    [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectTypeName,
                    [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectName,
                    [In] IntPtr SecurityDescriptor,
                    [In] IntPtr PrincipalSelfSid,
                    uint DesiredAccess,
                    AUDIT_EVENT_TYPE AuditType,
                    uint Flags,
                    IntPtr ObjectTypeList,
                    uint ObjectTypeListLength,
                    [In] ref GENERIC_MAPPING GenericMapping,
                    [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation,
                    [Out] out uint GrantedAccess,
                    [Out] out uint AccessStatusList,
                    [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///ClientToken: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///PrivilegeSet: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///PrivilegeSetLength: LPDWORD->DWORD*
        ///GrantedAccessList: LPDWORD->DWORD*
        ///AccessStatusList: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByTypeResultList")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByTypeResultList([In] IntPtr pSecurityDescriptor, [In] IntPtr PrincipalSelfSid, [In] IntPtr ClientToken, uint DesiredAccess, IntPtr ObjectTypeList, uint ObjectTypeListLength, [In] ref GENERIC_MAPPING GenericMapping, IntPtr PrivilegeSet, ref uint PrivilegeSetLength, [Out] out uint GrantedAccessList, [Out] out uint AccessStatusList);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPCWSTR->WCHAR*
        ///ObjectName: LPCWSTR->WCHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///AuditType: AUDIT_EVENT_TYPE->_AUDIT_EVENT_TYPE
        ///Flags: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatus: LPBOOL->BOOL*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByTypeAndAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByTypeAndAuditAlarmW(
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName,
                    [In] IntPtr HandleId,
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectTypeName,
                    [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectName,
                    [In] IntPtr SecurityDescriptor,
                    [In] IntPtr PrincipalSelfSid,
                    uint DesiredAccess,
                    AUDIT_EVENT_TYPE AuditType,
                    uint Flags,
                    IntPtr ObjectTypeList,
                    uint ObjectTypeListLength,
                    [In] ref GENERIC_MAPPING GenericMapping,
                    [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation,
                    [Out] out uint GrantedAccess,
                    [Out] out int AccessStatus,
                    [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPCSTR->CHAR*
        ///ObjectName: LPCSTR->CHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///AuditType: AUDIT_EVENT_TYPE->_AUDIT_EVENT_TYPE
        ///Flags: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatus: LPBOOL->BOOL*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByTypeAndAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByTypeAndAuditAlarmA(
                    [In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName,
                    [In] IntPtr HandleId,
                    [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectTypeName,
                    [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectName,
                    [In] IntPtr SecurityDescriptor,
                    [In] IntPtr PrincipalSelfSid,
                    uint DesiredAccess,
                    AUDIT_EVENT_TYPE AuditType,
                    uint Flags,
                    IntPtr ObjectTypeList,
                    uint ObjectTypeListLength,
                    [In] ref GENERIC_MAPPING GenericMapping,
                    [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation,
                    [Out] out uint GrantedAccess,
                    [Out] out int AccessStatus,
                    [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///PrincipalSelfSid: PSID->PVOID->void*
        ///ClientToken: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///ObjectTypeList: POBJECT_TYPE_LIST->_OBJECT_TYPE_LIST*
        ///ObjectTypeListLength: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///PrivilegeSet: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///PrivilegeSetLength: LPDWORD->DWORD*
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatus: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckByType")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckByType([In] IntPtr pSecurityDescriptor, [In] IntPtr PrincipalSelfSid, [In] IntPtr ClientToken, uint DesiredAccess, IntPtr ObjectTypeList, uint ObjectTypeListLength, [In] ref GENERIC_MAPPING GenericMapping, IntPtr PrivilegeSet, ref uint PrivilegeSetLength, [Out] out uint GrantedAccess, [Out] out int AccessStatus);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPWSTR->WCHAR*
        ///ObjectName: LPWSTR->WCHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatus: LPBOOL->BOOL*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckAndAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckAndAuditAlarmW([In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName, [In] IntPtr HandleId, [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectTypeName, [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectName, [In] IntPtr SecurityDescriptor, uint DesiredAccess, [In] ref GENERIC_MAPPING GenericMapping, [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation, [Out] out uint GrantedAccess, [Out] out int AccessStatus, [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPSTR->CHAR*
        ///ObjectName: LPSTR->CHAR*
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///DesiredAccess: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///ObjectCreation: BOOL->int
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatus: LPBOOL->BOOL*
        ///pfGenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheckAndAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheckAndAuditAlarmA([In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName, [In] IntPtr HandleId, [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectTypeName, [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectName, [In] IntPtr SecurityDescriptor, uint DesiredAccess, [In] ref GENERIC_MAPPING GenericMapping, [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation, [Out] out uint GrantedAccess, [Out] out int AccessStatus, [Out] out int pfGenerateOnClose);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///ClientToken: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///PrivilegeSet: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///PrivilegeSetLength: LPDWORD->DWORD*
        ///GrantedAccess: LPDWORD->DWORD*
        ///AccessStatus: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "AccessCheck")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AccessCheck([In] IntPtr pSecurityDescriptor, [In] IntPtr ClientToken, uint DesiredAccess, [In] ref GENERIC_MAPPING GenericMapping, IntPtr PrivilegeSet, ref uint PrivilegeSetLength, [Out] out uint GrantedAccess, [Out] out int AccessStatus);


        /// Return Type: BOOL->int
        ///sListenSocket: SOCKET->UINT_PTR->unsigned int
        ///sAcceptSocket: SOCKET->UINT_PTR->unsigned int
        ///lpOutputBuffer: PVOID->void*
        ///dwReceiveDataLength: DWORD->unsigned int
        ///dwLocalAddressLength: DWORD->unsigned int
        ///dwRemoteAddressLength: DWORD->unsigned int
        ///lpdwBytesReceived: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("mswsock.dll", EntryPoint = "AcceptEx", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AcceptEx([MarshalAs(UnmanagedType.SysUInt)] UIntPtr sListenSocket, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr sAcceptSocket, IntPtr lpOutputBuffer, uint dwReceiveDataLength, uint dwLocalAddressLength, uint dwRemoteAddressLength, ref uint lpdwBytesReceived, ref OVERLAPPED lpOverlapped);


        /// Return Type: SOCKET->UINT_PTR->unsigned int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///addr: sockaddr*
        ///addrlen: int*
        [DllImport("ws2_32.dll", EntryPoint = "accept", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint accept([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, ref sockaddr addr, ref int addrlen);


        /// Return Type: int
        ///_X: int
        [DllImport("ntdll.dll", EntryPoint = "abs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int abs(int _X);


        /// Return Type: BOOL->int
        ///lpMachineName: LPWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "AbortSystemShutdownW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AbortSystemShutdownW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpMachineName);


        /// Return Type: BOOL->int
        ///lpMachineName: LPSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "AbortSystemShutdownA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AbortSystemShutdownA([In] [MarshalAs(UnmanagedType.LPStr)] string lpMachineName);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "AbortPrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AbortPrinter([In] IntPtr hPrinter);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "AbortPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AbortPath([In] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "AbortDoc")]
        public static extern int AbortDoc([In] IntPtr hdc);


        /// Return Type: void
        [DllImport("msvcr80.dll", EntryPoint = "abort", CallingConvention = CallingConvention.Cdecl)]
        public static extern void abort();

    }

}
