using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: ULONG->unsigned int
    ///This: AsyncIUnknown*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIUnknownVtbl_Release(ref AsyncIUnknown This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIUnknown*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIUnknownVtbl_QueryInterface(ref AsyncIUnknown This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIUnknown*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIUnknownVtbl_Finish_Release(ref AsyncIUnknown This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIUnknown*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIUnknownVtbl_Finish_QueryInterface(ref AsyncIUnknown This, ref IntPtr ppvObject);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIUnknown*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIUnknownVtbl_Finish_AddRef(ref AsyncIUnknown This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIUnknown*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIUnknownVtbl_Begin_Release(ref AsyncIUnknown This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIUnknown*
    ///riid: IID*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIUnknownVtbl_Begin_QueryInterface(ref AsyncIUnknown This, ref GUID riid);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIUnknown*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIUnknownVtbl_Begin_AddRef(ref AsyncIUnknown This);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIUnknown*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIUnknownVtbl_AddRef(ref AsyncIUnknown This);

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIUnknownVtbl
    {

        /// AsyncIUnknownVtbl_QueryInterface
        public AsyncIUnknownVtbl_QueryInterface AnonymousMember1;

        /// AsyncIUnknownVtbl_AddRef
        public AsyncIUnknownVtbl_AddRef AnonymousMember2;

        /// AsyncIUnknownVtbl_Release
        public AsyncIUnknownVtbl_Release AnonymousMember3;

        /// AsyncIUnknownVtbl_Begin_QueryInterface
        public AsyncIUnknownVtbl_Begin_QueryInterface AnonymousMember4;

        /// AsyncIUnknownVtbl_Finish_QueryInterface
        public AsyncIUnknownVtbl_Finish_QueryInterface AnonymousMember5;

        /// AsyncIUnknownVtbl_Begin_AddRef
        public AsyncIUnknownVtbl_Begin_AddRef AnonymousMember6;

        /// AsyncIUnknownVtbl_Finish_AddRef
        public AsyncIUnknownVtbl_Finish_AddRef AnonymousMember7;

        /// AsyncIUnknownVtbl_Begin_Release
        public AsyncIUnknownVtbl_Begin_Release AnonymousMember8;

        /// AsyncIUnknownVtbl_Finish_Release
        public AsyncIUnknownVtbl_Finish_Release AnonymousMember9;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIUnknown
    {

        /// AsyncIUnknownVtbl*
        public IntPtr lpVtbl;
    }

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIPipeLong*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIPipeLongVtbl_Release(ref AsyncIPipeLong This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeLong*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeLongVtbl_QueryInterface(ref AsyncIPipeLong This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeLong*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeLongVtbl_Finish_Push(ref AsyncIPipeLong This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeLong*
    ///buf: LONG*
    ///pcReturned: ULONG*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeLongVtbl_Finish_Pull(ref AsyncIPipeLong This, ref int buf, ref uint pcReturned);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeLong*
    ///buf: LONG*
    ///cSent: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeLongVtbl_Begin_Push(ref AsyncIPipeLong This, ref int buf, uint cSent);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeLong*
    ///cRequest: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeLongVtbl_Begin_Pull(ref AsyncIPipeLong This, uint cRequest);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIPipeLong*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIPipeLongVtbl_AddRef(ref AsyncIPipeLong This);

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIPipeLongVtbl
    {

        /// AsyncIPipeLongVtbl_QueryInterface
        public AsyncIPipeLongVtbl_QueryInterface AnonymousMember1;

        /// AsyncIPipeLongVtbl_AddRef
        public AsyncIPipeLongVtbl_AddRef AnonymousMember2;

        /// AsyncIPipeLongVtbl_Release
        public AsyncIPipeLongVtbl_Release AnonymousMember3;

        /// AsyncIPipeLongVtbl_Begin_Pull
        public AsyncIPipeLongVtbl_Begin_Pull AnonymousMember4;

        /// AsyncIPipeLongVtbl_Finish_Pull
        public AsyncIPipeLongVtbl_Finish_Pull AnonymousMember5;

        /// AsyncIPipeLongVtbl_Begin_Push
        public AsyncIPipeLongVtbl_Begin_Push AnonymousMember6;

        /// AsyncIPipeLongVtbl_Finish_Push
        public AsyncIPipeLongVtbl_Finish_Push AnonymousMember7;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIPipeLong
    {

        /// AsyncIPipeLongVtbl*
        public IntPtr lpVtbl;
    }

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIPipeDouble*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIPipeDoubleVtbl_Release(ref AsyncIPipeDouble This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeDouble*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeDoubleVtbl_QueryInterface(ref AsyncIPipeDouble This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeDouble*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeDoubleVtbl_Finish_Push(ref AsyncIPipeDouble This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeDouble*
    ///buf: DOUBLE*
    ///pcReturned: ULONG*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeDoubleVtbl_Finish_Pull(ref AsyncIPipeDouble This, ref double buf, ref uint pcReturned);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeDouble*
    ///buf: DOUBLE*
    ///cSent: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeDoubleVtbl_Begin_Push(ref AsyncIPipeDouble This, ref double buf, uint cSent);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeDouble*
    ///cRequest: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeDoubleVtbl_Begin_Pull(ref AsyncIPipeDouble This, uint cRequest);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIPipeDouble*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIPipeDoubleVtbl_AddRef(ref AsyncIPipeDouble This);

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIPipeDoubleVtbl
    {

        /// AsyncIPipeDoubleVtbl_QueryInterface
        public AsyncIPipeDoubleVtbl_QueryInterface AnonymousMember1;

        /// AsyncIPipeDoubleVtbl_AddRef
        public AsyncIPipeDoubleVtbl_AddRef AnonymousMember2;

        /// AsyncIPipeDoubleVtbl_Release
        public AsyncIPipeDoubleVtbl_Release AnonymousMember3;

        /// AsyncIPipeDoubleVtbl_Begin_Pull
        public AsyncIPipeDoubleVtbl_Begin_Pull AnonymousMember4;

        /// AsyncIPipeDoubleVtbl_Finish_Pull
        public AsyncIPipeDoubleVtbl_Finish_Pull AnonymousMember5;

        /// AsyncIPipeDoubleVtbl_Begin_Push
        public AsyncIPipeDoubleVtbl_Begin_Push AnonymousMember6;

        /// AsyncIPipeDoubleVtbl_Finish_Push
        public AsyncIPipeDoubleVtbl_Finish_Push AnonymousMember7;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIPipeDouble
    {

        /// AsyncIPipeDoubleVtbl*
        public IntPtr lpVtbl;
    }

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIPipeByte*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIPipeByteVtbl_Release(ref AsyncIPipeByte This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeByte*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeByteVtbl_QueryInterface(ref AsyncIPipeByte This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeByte*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeByteVtbl_Finish_Push(ref AsyncIPipeByte This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeByte*
    ///buf: BYTE*
    ///pcReturned: ULONG*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeByteVtbl_Finish_Pull(ref AsyncIPipeByte This, ref byte buf, ref uint pcReturned);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeByte*
    ///buf: BYTE*
    ///cSent: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeByteVtbl_Begin_Push(ref AsyncIPipeByte This, ref byte buf, uint cSent);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIPipeByte*
    ///cRequest: ULONG->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIPipeByteVtbl_Begin_Pull(ref AsyncIPipeByte This, uint cRequest);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIPipeByte*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIPipeByteVtbl_AddRef(ref AsyncIPipeByte This);

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIPipeByteVtbl
    {

        /// AsyncIPipeByteVtbl_QueryInterface
        public AsyncIPipeByteVtbl_QueryInterface AnonymousMember1;

        /// AsyncIPipeByteVtbl_AddRef
        public AsyncIPipeByteVtbl_AddRef AnonymousMember2;

        /// AsyncIPipeByteVtbl_Release
        public AsyncIPipeByteVtbl_Release AnonymousMember3;

        /// AsyncIPipeByteVtbl_Begin_Pull
        public AsyncIPipeByteVtbl_Begin_Pull AnonymousMember4;

        /// AsyncIPipeByteVtbl_Finish_Pull
        public AsyncIPipeByteVtbl_Finish_Pull AnonymousMember5;

        /// AsyncIPipeByteVtbl_Begin_Push
        public AsyncIPipeByteVtbl_Begin_Push AnonymousMember6;

        /// AsyncIPipeByteVtbl_Finish_Push
        public AsyncIPipeByteVtbl_Finish_Push AnonymousMember7;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIPipeByte
    {

        /// AsyncIPipeByteVtbl*
        public IntPtr lpVtbl;
    }

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIMultiQI*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIMultiQIVtbl_Release(ref AsyncIMultiQI This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIMultiQI*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIMultiQIVtbl_QueryInterface(ref AsyncIMultiQI This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIMultiQI*
    ///pMQIs: MULTI_QI*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIMultiQIVtbl_Finish_QueryMultipleInterfaces(ref AsyncIMultiQI This, ref tagMULTI_QI pMQIs);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIMultiQI*
    ///cMQIs: ULONG->unsigned int
    ///pMQIs: MULTI_QI*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIMultiQIVtbl_Begin_QueryMultipleInterfaces(ref AsyncIMultiQI This, uint cMQIs, ref tagMULTI_QI pMQIs);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIMultiQI*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIMultiQIVtbl_AddRef(ref AsyncIMultiQI This);

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIMultiQIVtbl
    {

        /// AsyncIMultiQIVtbl_QueryInterface
        public AsyncIMultiQIVtbl_QueryInterface AnonymousMember1;

        /// AsyncIMultiQIVtbl_AddRef
        public AsyncIMultiQIVtbl_AddRef AnonymousMember2;

        /// AsyncIMultiQIVtbl_Release
        public AsyncIMultiQIVtbl_Release AnonymousMember3;

        /// AsyncIMultiQIVtbl_Begin_QueryMultipleInterfaces
        public AsyncIMultiQIVtbl_Begin_QueryMultipleInterfaces AnonymousMember4;

        /// AsyncIMultiQIVtbl_Finish_QueryMultipleInterfaces
        public AsyncIMultiQIVtbl_Finish_QueryMultipleInterfaces AnonymousMember5;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIMultiQI
    {

        /// AsyncIMultiQIVtbl*
        public IntPtr lpVtbl;
    }

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIAdviseSinkVtbl_Release(ref AsyncIAdviseSink This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIAdviseSink*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIAdviseSinkVtbl_QueryInterface(ref AsyncIAdviseSink This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Finish_OnViewChange(ref AsyncIAdviseSink This);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Finish_OnSave(ref AsyncIAdviseSink This);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Finish_OnRename(ref AsyncIAdviseSink This);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Finish_OnDataChange(ref AsyncIAdviseSink This);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Finish_OnClose(ref AsyncIAdviseSink This);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    ///dwAspect: DWORD->unsigned int
    ///lindex: LONG->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Begin_OnViewChange(ref AsyncIAdviseSink This, uint dwAspect, int lindex);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Begin_OnSave(ref AsyncIAdviseSink This);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    ///pmk: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Begin_OnRename(ref AsyncIAdviseSink This, ref IMoniker pmk);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    ///pFormatetc: FORMATETC*
    ///pStgmed: STGMEDIUM*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Begin_OnDataChange(ref AsyncIAdviseSink This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);

    /// Return Type: void
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSinkVtbl_Begin_OnClose(ref AsyncIAdviseSink This);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIAdviseSink*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIAdviseSinkVtbl_AddRef(ref AsyncIAdviseSink This);

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIAdviseSinkVtbl
    {

        /// AsyncIAdviseSinkVtbl_QueryInterface
        public AsyncIAdviseSinkVtbl_QueryInterface AnonymousMember1;

        /// AsyncIAdviseSinkVtbl_AddRef
        public AsyncIAdviseSinkVtbl_AddRef AnonymousMember2;

        /// AsyncIAdviseSinkVtbl_Release
        public AsyncIAdviseSinkVtbl_Release AnonymousMember3;

        /// AsyncIAdviseSinkVtbl_Begin_OnDataChange
        public AsyncIAdviseSinkVtbl_Begin_OnDataChange AnonymousMember4;

        /// AsyncIAdviseSinkVtbl_Finish_OnDataChange
        public AsyncIAdviseSinkVtbl_Finish_OnDataChange AnonymousMember5;

        /// AsyncIAdviseSinkVtbl_Begin_OnViewChange
        public AsyncIAdviseSinkVtbl_Begin_OnViewChange AnonymousMember6;

        /// AsyncIAdviseSinkVtbl_Finish_OnViewChange
        public AsyncIAdviseSinkVtbl_Finish_OnViewChange AnonymousMember7;

        /// AsyncIAdviseSinkVtbl_Begin_OnRename
        public AsyncIAdviseSinkVtbl_Begin_OnRename AnonymousMember8;

        /// AsyncIAdviseSinkVtbl_Finish_OnRename
        public AsyncIAdviseSinkVtbl_Finish_OnRename AnonymousMember9;

        /// AsyncIAdviseSinkVtbl_Begin_OnSave
        public AsyncIAdviseSinkVtbl_Begin_OnSave AnonymousMember10;

        /// AsyncIAdviseSinkVtbl_Finish_OnSave
        public AsyncIAdviseSinkVtbl_Finish_OnSave AnonymousMember11;

        /// AsyncIAdviseSinkVtbl_Begin_OnClose
        public AsyncIAdviseSinkVtbl_Begin_OnClose AnonymousMember12;

        /// AsyncIAdviseSinkVtbl_Finish_OnClose
        public AsyncIAdviseSinkVtbl_Finish_OnClose AnonymousMember13;
    }

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIAdviseSink2Vtbl_Release(ref AsyncIAdviseSink2 This);

    /// Return Type: HRESULT->LONG->int
    ///This: AsyncIAdviseSink2*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int AsyncIAdviseSink2Vtbl_QueryInterface(ref AsyncIAdviseSink2 This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Finish_OnViewChange(ref AsyncIAdviseSink2 This);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Finish_OnSave(ref AsyncIAdviseSink2 This);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Finish_OnRename(ref AsyncIAdviseSink2 This);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Finish_OnLinkSrcChange(ref AsyncIAdviseSink2 This);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Finish_OnDataChange(ref AsyncIAdviseSink2 This);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Finish_OnClose(ref AsyncIAdviseSink2 This);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    ///dwAspect: DWORD->unsigned int
    ///lindex: LONG->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Begin_OnViewChange(ref AsyncIAdviseSink2 This, uint dwAspect, int lindex);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Begin_OnSave(ref AsyncIAdviseSink2 This);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    ///pmk: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Begin_OnRename(ref AsyncIAdviseSink2 This, ref IMoniker pmk);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    ///pmk: IMoniker*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Begin_OnLinkSrcChange(ref AsyncIAdviseSink2 This, ref IMoniker pmk);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    ///pFormatetc: FORMATETC*
    ///pStgmed: STGMEDIUM*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Begin_OnDataChange(ref AsyncIAdviseSink2 This, ref tagFORMATETC pFormatetc, ref tagSTGMEDIUM pStgmed);

    /// Return Type: void
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void AsyncIAdviseSink2Vtbl_Begin_OnClose(ref AsyncIAdviseSink2 This);

    /// Return Type: ULONG->unsigned int
    ///This: AsyncIAdviseSink2*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AsyncIAdviseSink2Vtbl_AddRef(ref AsyncIAdviseSink2 This);

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIAdviseSink2Vtbl
    {

        /// AsyncIAdviseSink2Vtbl_QueryInterface
        public AsyncIAdviseSink2Vtbl_QueryInterface AnonymousMember1;

        /// AsyncIAdviseSink2Vtbl_AddRef
        public AsyncIAdviseSink2Vtbl_AddRef AnonymousMember2;

        /// AsyncIAdviseSink2Vtbl_Release
        public AsyncIAdviseSink2Vtbl_Release AnonymousMember3;

        /// AsyncIAdviseSink2Vtbl_Begin_OnDataChange
        public AsyncIAdviseSink2Vtbl_Begin_OnDataChange AnonymousMember4;

        /// AsyncIAdviseSink2Vtbl_Finish_OnDataChange
        public AsyncIAdviseSink2Vtbl_Finish_OnDataChange AnonymousMember5;

        /// AsyncIAdviseSink2Vtbl_Begin_OnViewChange
        public AsyncIAdviseSink2Vtbl_Begin_OnViewChange AnonymousMember6;

        /// AsyncIAdviseSink2Vtbl_Finish_OnViewChange
        public AsyncIAdviseSink2Vtbl_Finish_OnViewChange AnonymousMember7;

        /// AsyncIAdviseSink2Vtbl_Begin_OnRename
        public AsyncIAdviseSink2Vtbl_Begin_OnRename AnonymousMember8;

        /// AsyncIAdviseSink2Vtbl_Finish_OnRename
        public AsyncIAdviseSink2Vtbl_Finish_OnRename AnonymousMember9;

        /// AsyncIAdviseSink2Vtbl_Begin_OnSave
        public AsyncIAdviseSink2Vtbl_Begin_OnSave AnonymousMember10;

        /// AsyncIAdviseSink2Vtbl_Finish_OnSave
        public AsyncIAdviseSink2Vtbl_Finish_OnSave AnonymousMember11;

        /// AsyncIAdviseSink2Vtbl_Begin_OnClose
        public AsyncIAdviseSink2Vtbl_Begin_OnClose AnonymousMember12;

        /// AsyncIAdviseSink2Vtbl_Finish_OnClose
        public AsyncIAdviseSink2Vtbl_Finish_OnClose AnonymousMember13;

        /// AsyncIAdviseSink2Vtbl_Begin_OnLinkSrcChange
        public AsyncIAdviseSink2Vtbl_Begin_OnLinkSrcChange AnonymousMember14;

        /// AsyncIAdviseSink2Vtbl_Finish_OnLinkSrcChange
        public AsyncIAdviseSink2Vtbl_Finish_OnLinkSrcChange AnonymousMember15;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIAdviseSink2
    {

        /// AsyncIAdviseSink2Vtbl*
        public IntPtr lpVtbl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AsyncIAdviseSink
    {

        /// AsyncIAdviseSinkVtbl*
        public IntPtr lpVtbl;
    }

    /// Return Type: void
    ///param0: DWORD->unsigned int
    ///param1: PVOID->void*
    ///param2: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void APC_CALLBACK_FUNCTION(uint param0, IntPtr param1, IntPtr param2);

    [StructLayout(LayoutKind.Sequential)]
    public struct ANON_OBJECT_HEADER
    {

        /// WORD->unsigned short
        public ushort Sig1;

        /// WORD->unsigned short
        public ushort Sig2;

        /// WORD->unsigned short
        public ushort Version;

        /// WORD->unsigned short
        public ushort Machine;

        /// DWORD->unsigned int
        public uint TimeDateStamp;

        /// CLSID->GUID->_GUID
        public GUID ClassID;

        /// DWORD->unsigned int
        public uint SizeOfData;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_ff24905c_f69f_47bb_bc6c_cb0737f3e649
    {

        /// PCMC_TAGGED_CERT_REQUEST->_CMC_TAGGED_CERT_REQUEST*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pTaggedCertRequest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_fdc84893_b5c2_45fb_b4d7_6a0c9adf3df9
    {

        /// DISK_INT13_INFO->_DISK_INT13_INFO
        public DISK_INT13_INFO Int13;

        /// DISK_EX_INT13_INFO->_DISK_EX_INT13_INFO
        public DISK_EX_INT13_INFO ExInt13;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_fd626461_7f3e_49a1_aabe_a2b90f0df936
    {

        /// SINGLE_LIST_ENTRY->_SINGLE_LIST_ENTRY
        public SINGLE_LIST_ENTRY Next;

        /// WORD->unsigned short
        public ushort Depth;

        /// WORD->unsigned short
        public ushort Sequence;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_f9ea10e8_4357_4c9c_9653_6d8541173cb4
    {

        /// Anonymous_e70ed9cb_9613_4f25_9014_3ef6593c4a40
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_e70ed9cb_9613_4f25_9014_3ef6593c4a40 ScsiInformation;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Anonymous_f9dda5b1_c4ff_4afd_8bff_3d1faaaf5d0c
    {

        /// unsigned char[10]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string ld;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_f95820c2_86d5_4678_8973_0d686c1da512
    {

        /// Anonymous_630b6059_fc11_4fc5_8e79_12b6819f7f2b
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_630b6059_fc11_4fc5_8e79_12b6819f7f2b Struct1;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong Lo64;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_f9090501_6b7a_42cd_8375_395510c223f6
    {

        /// LONG->int
        public int lMinimum;

        /// LONG->int
        public int lMaximum;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_f88a58b9_6d70_43e3_959d_660704d31585
    {

        /// WORD->unsigned short
        public ushort Write;

        /// WORD->unsigned short
        public ushort Create;

        /// WORD->unsigned short
        public ushort SetInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_f7b746fc_d446_406f_831b_3beba7513ffc
    {

        /// PCERT_OTHER_NAME->_CERT_OTHER_NAME*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pOtherName;

        /// LPWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pwszRfc822Name;

        /// LPWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pwszDNSName;

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CRYPT_ATTR_BLOB DirectoryName;

        /// LPWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pwszURL;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CRYPT_ATTR_BLOB IPAddress;

        /// LPSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszRegisteredID;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_f75e3883_ac7c_476e_bd60_3b6d9fe9cacc
    {

        /// LPCPROPSHEETPAGEA->LPCPROPSHEETPAGEA_V3->PROPSHEETPAGEA_V3*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppsp;

        /// HPROPSHEETPAGE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr phpage;
    }

    /// Return Type: BOOL->int
    ///dwContinue: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int Anonymous_f477e6ae_c179_4fc8_95bf_fe29db28a8f2(uint dwContinue);

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_f3630dcb_df39_4f30_a593_48e610e9363d
    {

        /// WCHAR->wchar_t->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort UnicodeChar;

        /// CHAR->char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte AsciiChar;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_f34bda71_2d59_45fc_a121_bbed90a7be1e
    {

        /// CERT_ID->_CERT_ID
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CERT_ID OriginatorCertId;

        /// CERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_f30d8ff9_a58f_4580_b612_d3665f894fed
    {

        /// PFULL_PTR_TO_REFID_ELEMENT*
        public IntPtr XlatTable;

        /// unsigned int
        public uint NumberOfBuckets;

        /// unsigned int
        public uint HashMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_f07de348_4b52_4b8c_b360_6bb20b8e44e5
    {

        /// BYTE[18]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
        public byte[] Name;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_ee4ad878_dde2_4d9b_b7de_b1588db350c7
    {

        /// WCHAR->wchar_t->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort UnicodeChar;

        /// CHAR->char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte AsciiChar;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_ec3d2e6d_20ad_46aa_814e_7b1702028889
    {

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszTemplate;

        /// PROPSHEETPAGE_RESOURCE->LPCDLGTEMPLATE->LPCDLGTEMPLATEW->DLGTEMPLATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pResource;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_eb9433b6_e978_4698_8a32_b407acdfde12
    {

        /// WORD->unsigned short
        public ushort Write;

        /// WORD->unsigned short
        public ushort Create;

        /// WORD->unsigned short
        public ushort SetInfo;

        /// WORD->unsigned short
        public ushort Flush;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_e8fd624a_62ed_4ea9_b136_c21a4d47e44b
    {

        /// DWORD->unsigned int
        public uint cbBuf;

        /// LPVOID->void*
        public IntPtr pBuf;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_e70ed9cb_9613_4f25_9014_3ef6593c4a40
    {

        /// BYTE->unsigned char
        public byte MediumType;

        /// BYTE->unsigned char
        public byte DensityCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_e469aa29_5a46_4c74_b009_60adb4b669c8
    {

        /// DWORD->unsigned int
        public uint dwCommittedSize;

        /// DWORD->unsigned int
        public uint dwUnCommittedSize;

        /// LPVOID->void*
        public IntPtr lpFirstBlock;

        /// LPVOID->void*
        public IntPtr lpLastBlock;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_e172b3d1_df10_4959_b941_c01d77f42733
    {

        /// OffsetToDirectory : 31
        ///DataIsDirectory : 1
        public uint bitvector1;

        public uint OffsetToDirectory
        {
            get
            {
                return ((uint)((this.bitvector1 & 2147483647u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint DataIsDirectory
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2147483648u)
                            / 2147483648)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2147483648)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_de8bc636_9617_4311_97bc_1b3c77b1408f
    {

        /// Anonymous_fdc84893_b5c2_45fb_b4d7_6a0c9adf3df9
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_fdc84893_b5c2_45fb_b4d7_6a0c9adf3df9 Struct1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_ddcff603_a053_488b_b924_0d3c694e001a
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwFailInfo;

        /// PCMC_PEND_INFO->_CMC_PEND_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pPendInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_dccf47da_5155_438b_92bc_41adbefe840c
    {

        /// MOUSEINPUT->tagMOUSEINPUT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagMOUSEINPUT mi;

        /// KEYBDINPUT->tagKEYBDINPUT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagKEYBDINPUT ki;

        /// HARDWAREINPUT->tagHARDWAREINPUT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagHARDWAREINPUT hi;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_da3d5bb2_d7f6_4b49_a86f_df044e26e59a
    {

        /// DWORD->unsigned int
        public uint LowPart;

        /// DWORD->unsigned int
        public uint HighPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_d973d7e7_ad4c_4155_86fe_6d2b51ab5f04
    {

        /// POINTL->_POINTL
        public POINTL dmPosition;

        /// DWORD->unsigned int
        public uint dmDisplayOrientation;

        /// DWORD->unsigned int
        public uint dmDisplayFixedOutput;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_d744c6eb_695a_417f_b8f4_c85f39642ecd
    {

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszTemplate;

        /// PROPSHEETPAGE_RESOURCE->LPCDLGTEMPLATE->LPCDLGTEMPLATEW->DLGTEMPLATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pResource;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_d6929560_b153_442e_89bc_7373a0f636e0
    {

        /// Anonymous_8d75b279_16e0_4e65_b352_f627487a260f
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8d75b279_16e0_4e65_b352_f627487a260f Function;

        /// Anonymous_88ea22a4_7f27_4000_9e6a_caeb8d94a2fd
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_88ea22a4_7f27_4000_9e6a_caeb8d94a2fd Array;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_d4be8f65_6573_460f_bb31_85a2454b800d
    {

        /// RID_DEVICE_INFO_MOUSE->tagRID_DEVICE_INFO_MOUSE
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagRID_DEVICE_INFO_MOUSE mouse;

        /// RID_DEVICE_INFO_KEYBOARD->tagRID_DEVICE_INFO_KEYBOARD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagRID_DEVICE_INFO_KEYBOARD keyboard;

        /// RID_DEVICE_INFO_HID->tagRID_DEVICE_INFO_HID
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagRID_DEVICE_INFO_HID hid;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_d34c77ee_53b2_47a5_a97c_d5c2b29c8ee3
    {

        /// RAWMOUSE->tagRAWMOUSE
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagRAWMOUSE mouse;

        /// RAWKEYBOARD->tagRAWKEYBOARD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagRAWKEYBOARD keyboard;

        /// RAWHID->tagRAWHID
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagRAWHID hid;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_d1088fd3_1611_4816_8fb1_97de0a4a366d
    {

        /// PCMSG_KEY_TRANS_RECIPIENT_INFO->_CMSG_KEY_TRANS_RECIPIENT_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pKeyTrans;

        /// PCMSG_KEY_AGREE_RECIPIENT_INFO->_CMSG_KEY_AGREE_RECIPIENT_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pKeyAgree;

        /// PCMSG_MAIL_LIST_RECIPIENT_INFO->_CMSG_MAIL_LIST_RECIPIENT_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pMailList;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cfe69ad2_5ccf_492c_ada2_b57240733f82
    {

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszTemplate;

        /// PROPSHEETPAGE_RESOURCE->LPCDLGTEMPLATE->LPCDLGTEMPLATEW->DLGTEMPLATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pResource;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cfd23939_9500_4160_98e5_2192e35f1c84
    {

        /// Anonymous_9745490c_3375_4320_bd20_bf98795b0e50
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_9745490c_3375_4320_bd20_bf98795b0e50 Struct1;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Name;

        /// WORD->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort Id;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cfba373b_d315_405c_b345_eabbe699bc66
    {

        /// Anonymous_ccf454b1_fcd7_4ef6_bdd3_a1452ec5448e
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_ccf454b1_fcd7_4ef6_bdd3_a1452ec5448e ProcessorCore;

        /// Anonymous_6bf0fd06_e931_4db4_bf97_e2e2b7af523b
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_6bf0fd06_e931_4db4_bf97_e2e2b7af523b NumaNode;

        /// CACHE_DESCRIPTOR->_CACHE_DESCRIPTOR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CACHE_DESCRIPTOR Cache;

        /// ULONGLONG[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U8)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong[] Reserved;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cfb60db2_96f4_4519_9332_49eedd92748c
    {

        /// DRIVE_LAYOUT_INFORMATION_MBR->_DRIVE_LAYOUT_INFORMATION_MBR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public DRIVE_LAYOUT_INFORMATION_MBR Mbr;

        /// DRIVE_LAYOUT_INFORMATION_GPT->_DRIVE_LAYOUT_INFORMATION_GPT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public DRIVE_LAYOUT_INFORMATION_GPT Gpt;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cf7219a7_561f_4650_8ae4_fbd5695fe221
    {

        /// Anonymous_8ee52dbc_a992_4853_a328_103fc9181176
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8ee52dbc_a992_4853_a328_103fc9181176 S_un_b;

        /// Anonymous_63fe3feb_0017_41da_8c7f_24da3f99f4a8
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_63fe3feb_0017_41da_8c7f_24da3f99f4a8 S_un_w;

        /// u_long->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint S_addr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_ccf454b1_fcd7_4ef6_bdd3_a1452ec5448e
    {

        /// BYTE->unsigned char
        public byte Flags;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cb8be365_afe0_4064_8361_371c31b61c7a
    {

        /// HBITMAP->HBITMAP__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hBitmap;

        /// HMETAFILEPICT->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hMetaFilePict;

        /// HENHMETAFILE->HENHMETAFILE__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hEnhMetaFile;

        /// HGLOBAL->HANDLE->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hGlobal;

        /// LPOLESTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lpszFileName;

        /// IStream*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pstm;

        /// IStorage*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pstg;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_cb866153_4202_46bb_a783_4f83678ec1a5
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_cb1eb549_6c81_48bd_b5bf_228b52412176
    {

        /// DWORD->unsigned int
        public uint songptrpos;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_c9386319_923c_4f10_ad71_12ce6f4c7b4e
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint PhysicalAddress;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint VirtualSize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_c8743c50_a79a_47b5_a663_6d16f2240a64
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint OffsetToData;

        /// Anonymous_e172b3d1_df10_4959_b941_c01d77f42733
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_e172b3d1_df10_4959_b941_c01d77f42733 Struct1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_c6363f3e_2cdc_4c92_81ea_a84a1d4b42a3
    {

        /// BYTE[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte[] ShortName;

        /// Anonymous_907e307b_e326_41de_bac3_596645332f66
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_907e307b_e326_41de_bac3_596645332f66 Name;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint[] LongName;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_c0f5f2ce_b74f_423c_81ee_f2fb7ef45eb7
    {

        /// EXCEPTION_DEBUG_INFO->_EXCEPTION_DEBUG_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public EXCEPTION_DEBUG_INFO Exception;

        /// CREATE_THREAD_DEBUG_INFO->_CREATE_THREAD_DEBUG_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CREATE_THREAD_DEBUG_INFO CreateThread;

        /// CREATE_PROCESS_DEBUG_INFO->_CREATE_PROCESS_DEBUG_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo;

        /// EXIT_THREAD_DEBUG_INFO->_EXIT_THREAD_DEBUG_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public EXIT_THREAD_DEBUG_INFO ExitThread;

        /// EXIT_PROCESS_DEBUG_INFO->_EXIT_PROCESS_DEBUG_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public EXIT_PROCESS_DEBUG_INFO ExitProcess;

        /// LOAD_DLL_DEBUG_INFO->_LOAD_DLL_DEBUG_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public LOAD_DLL_DEBUG_INFO LoadDll;

        /// UNLOAD_DLL_DEBUG_INFO->_UNLOAD_DLL_DEBUG_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public UNLOAD_DLL_DEBUG_INFO UnloadDll;

        /// OUTPUT_DEBUG_STRING_INFO->_OUTPUT_DEBUG_STRING_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public OUTPUT_DEBUG_STRING_INFO DebugString;

        /// RIP_INFO->_RIP_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public RIP_INFO RipInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bfc03952_c8c9_43d0_8f63_699e2421631e
    {

        /// PVOID->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr FiberData;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Version;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bee1bc17_403f_41d8_bac9_fbc35d2b706c
    {

        /// void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pvSystemStore;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszSystemStore;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pwszSystemStore;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_be99ba83_4d1f_4757_92c0_097e5f917528
    {

        /// void**
        public IntPtr XlatTable;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string StateTable;

        /// unsigned int
        public uint NumberOfEntries;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_be850055_9068_46f5_b1b6_55478ba127c0
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwControlID;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwControlType;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bd348551_10f9_42f6_b86b_1318bd5c6172
    {

        /// LONGLONG->__int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long llVal;

        /// LONG->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int lVal;

        /// BYTE->unsigned char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte bVal;

        /// SHORT->short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public short iVal;

        /// FLOAT->float
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public float fltVal;

        /// DOUBLE->double
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public double dblVal;

        /// VARIANT_BOOL->short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public short boolVal;

        /// SCODE->LONG->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int scode;

        /// CY->tagCY
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCY cyVal;

        /// DATE->double
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public double date;

        /// wireBSTR->FLAGGED_WORD_BLOB*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr bstrVal;

        /// IUnknown*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr punkVal;

        /// IDispatch*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdispVal;

        /// wirePSAFEARRAY->wireSAFEARRAY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr parray;

        /// wireBRECORD->_wireBRECORD*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr brecVal;

        /// BYTE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pbVal;

        /// SHORT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr piVal;

        /// LONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr plVal;

        /// LONGLONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pllVal;

        /// FLOAT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pfltVal;

        /// DOUBLE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdblVal;

        /// VARIANT_BOOL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pboolVal;

        /// SCODE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pscode;

        /// CY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pcyVal;

        /// DATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdate;

        /// wireBSTR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pbstrVal;

        /// IUnknown**
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppunkVal;

        /// IDispatch**
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppdispVal;

        /// wirePSAFEARRAY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pparray;

        /// wireVARIANT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pvarVal;

        /// CHAR->char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte cVal;

        /// USHORT->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort uiVal;

        /// ULONG->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint ulVal;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong ullVal;

        /// INT->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int intVal;

        /// UINT->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint uintVal;

        /// DECIMAL->tagDEC
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagDEC decVal;

        /// DECIMAL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdecVal;

        /// CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pcVal;

        /// USHORT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr puiVal;

        /// ULONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pulVal;

        /// ULONGLONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pullVal;

        /// INT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pintVal;

        /// UINT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr puintVal;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bc80462d_922e_4a8f_b11f_481f73e89f73
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint FiberData;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Version;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bc7a5469_dda9_4254_b3d4_4de48f191a21
    {

        /// DWORD64->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong FiberData;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Version;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bb8fbc03_3a8e_4664_a752_b7a8041c4097
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cSteps;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cbCustomData;

        /// DWORD[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bb885a23_f7c8_4f21_b191_d872acbe3100
    {

        /// RPC_HTTP_TRANSPORT_CREDENTIALS_W*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr HttpCredentials;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bae06084_c07b_4428_8082_e2b9fbe43125
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_b895d924_0737_4d5c_bff8_4b994f32d0af
    {

        /// CERT_ISSUER_SERIAL_NUMBER->_CERT_ISSUER_SERIAL_NUMBER
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber;

        /// CRYPT_HASH_BLOB->_CRYPTOAPI_BLOB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CRYPT_ATTR_BLOB KeyId;

        /// CRYPT_HASH_BLOB->_CRYPTOAPI_BLOB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CRYPT_ATTR_BLOB HashId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_b53f0817_0352_415a_9818_e30c336c1e5d
    {

        /// DWORD->unsigned int
        public uint dwMinimum;

        /// DWORD->unsigned int
        public uint dwMaximum;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_af7ff830_64ee_4e0f_a1bd_adae73ad26ee
    {

        /// HCRYPTKEY->ULONG_PTR->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint hKeyEncryptionKey;

        /// void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pvKeyEncryptionKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6
    {

        /// DWORD->unsigned int
        public uint Offset;

        /// DWORD->unsigned int
        public uint OffsetHigh;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_a7f13da1_dec1_4dac_ae92_16e3d8cba71c
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_a67d541d_da92_408e_8852_89977e56cead
    {

        /// short
        public short dmOrientation;

        /// short
        public short dmPaperSize;

        /// short
        public short dmPaperLength;

        /// short
        public short dmPaperWidth;

        /// short
        public short dmScale;

        /// short
        public short dmCopies;

        /// short
        public short dmDefaultSource;

        /// short
        public short dmPrintQuality;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_a6322a0a_897e_4c05_9984_d5cc72d24537
    {

        /// DWORD->unsigned int
        public uint Signature;

        /// DWORD->unsigned int
        public uint CheckSum;
    }

    /// Return Type: void
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Anonymous_a3debd67_ecba_49a0_9c67_1b83f463a375();

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_a3ae7823_8a1d_432c_bc07_a72b6fc6c7d8
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwValue;

        /// ALG_ID->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Algid;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_a30d5f78_3b46_471a_9d25_915a0fe3987d
    {

        /// WORD->unsigned short
        public ushort wProcessorArchitecture;

        /// WORD->unsigned short
        public ushort wReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_9e5ba8f4_6347_4f61_912e_6d0d46462b33
    {

        /// DWORD->unsigned int
        public uint dwMinimum;

        /// DWORD->unsigned int
        public uint dwMaximum;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_9ce4e4c3_5306_4984_8df6_e500c95e0232
    {

        /// GUID->_GUID
        public GUID ObjectId;

        /// GUID->_GUID
        public GUID PolicyId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_9cd09bf7_d4f4_42f0_9f48_4c04295a4c4f
    {

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] DataBuffer;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_9ca4478c_b7fb_4748_b3ff_66088946049b
    {

        /// PCMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO->_CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pKeyTrans;

        /// PCMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO->_CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pKeyAgree;

        /// PCMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO->_CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pMailList;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_9bd9399e_c332_40ac_ad3c_8155b5ea7388
    {

        /// BYTE->unsigned char
        public byte hour;

        /// BYTE->unsigned char
        public byte AnonymousMember1;

        /// BYTE->unsigned char
        public byte sec;

        /// BYTE->unsigned char
        public byte frame;

        /// BYTE->unsigned char
        public byte fps;

        /// BYTE->unsigned char
        public byte dummy;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] pad;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_9ae169eb_8d9d_4c08_91c7_4838cb279a69
    {

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong ForwarderString;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong Function;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong Ordinal;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong AddressOfData;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_999607ba_8a31_4480_af49_8774cb4f5bd6
    {

        /// tagTYPEDESC*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lptdesc;

        /// tagARRAYDESC*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lpadesc;

        /// HREFTYPE->DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint hreftype;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_996376cd_198e_4f94_b294_6f092ed08535
    {

        /// Anonymous_6cd904db_e392_48a8_8a97_d1256010f471
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_6cd904db_e392_48a8_8a97_d1256010f471 LnSz;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint TotalSize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_98a511c6_8aeb_4e58_afe9_4f14a656c4cc
    {

        /// HANDLE->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// HANDLE->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hMonitor;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_985b65de_68af_45f8_afd4_03cbaac03ace
    {

        /// CREATE_DISK_MBR->_CREATE_DISK_MBR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CREATE_DISK_MBR Mbr;

        /// CREATE_DISK_GPT->_CREATE_DISK_GPT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CREATE_DISK_GPT Gpt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_9745490c_3375_4320_bd20_bf98795b0e50
    {

        /// NameOffset : 31
        ///NameIsString : 1
        public uint bitvector1;

        public uint NameOffset
        {
            get
            {
                return ((uint)((this.bitvector1 & 2147483647u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint NameIsString
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2147483648u)
                            / 2147483648)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2147483648)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_9637d98a_5c31_4364_8c28_61baf1ae752a
    {

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszTemplate;

        /// PROPSHEETPAGE_RESOURCE->LPCDLGTEMPLATE->LPCDLGTEMPLATEW->DLGTEMPLATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pResource;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_95951078_628c_4f84_b45e_48d4878fe825
    {

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPackageName;

        /// GUID->_GUID
        public GUID PolicyId;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_94b32888_87dd_4b6f_a5b7_0e0020f6dc88
    {

        /// LPCPROPSHEETPAGEW->LPCPROPSHEETPAGEW_V3->PROPSHEETPAGEW_V3*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppsp;

        /// HPROPSHEETPAGE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr phpage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9
    {

        /// DWORD->unsigned int
        public uint LowPart;

        /// LONG->int
        public int HighPart;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_9458c9ac_2eca_481f_8912_f5ffcf5913b6
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint SymbolTableIndex;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint VirtualAddress;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_93d0990e_9eb8_4bd9_a142_a1aae677f217
    {

        /// RPC_HTTP_TRANSPORT_CREDENTIALS_A*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr HttpCredentials;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_9320654f_2227_43bf_a385_74cc8c562686
    {

        /// DWORD->unsigned int
        public uint LowPart;

        /// LONG->int
        public int HighPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_918724a9_5b23_43e1_8037_08cb0f9cd63e
    {

        /// double
        public double x;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_907e307b_e326_41de_bac3_596645332f66
    {

        /// DWORD->unsigned int
        public uint Short;

        /// DWORD->unsigned int
        public uint Long;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_8fed292e_f8eb_47d1_9d92_4d13c62e2af6
    {

        /// HWND->HWND__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hwndOwner;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cMultipleItems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8fdd9a27_0167_4a68_9d58_0eb653f5b1e6
    {

        /// HANDLE->void*
        public IntPtr hMem;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8f4ef992_3a82_4e46_a5c0_bb11d9e824e2
    {

        /// GUID->_GUID
        public GUID DiskId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8ee52dbc_a992_4853_a328_103fc9181176
    {

        /// u_char->unsigned char
        public byte s_b1;

        /// u_char->unsigned char
        public byte s_b2;

        /// u_char->unsigned char
        public byte s_b3;

        /// u_char->unsigned char
        public byte s_b4;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    ///param2: void*
    public delegate int Anonymous_8ede96d0_92f4_4ad3_bf41_9c8449c4c5c4(IntPtr param0, IntPtr param1, IntPtr param2);

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8e5719f6_11cc_4723_b5ac_c7fe200f6634
    {

        /// void*[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] pad;

        /// void*
        public IntPtr userContext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8d75b279_16e0_4e65_b352_f627487a260f
    {

        /// DWORD->unsigned int
        public uint PointerToLinenumber;

        /// DWORD->unsigned int
        public uint PointerToNextFunction;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_8cf464b6_e59d_4bc1_bc7d_fde4719bfe18
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint VirtualAddress;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint RelocCount;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_8cb88cea_ec75_4ac4_b7a5_799dc26b6429
    {

        /// UINT->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint nStartPage;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pStartPage;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_8c69c7dc_c604_4e3c_8092_884f53e8eb23
    {

        /// WORD->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort Ordinal;

        /// WORD->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort Hint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8bcaf072_e89e_46be_b5ce_4cb09f1d0bbf
    {

        /// WORD->unsigned short
        public ushort Minimum;

        /// WORD->unsigned short
        public ushort Maximum;

        /// WORD->unsigned short
        public ushort MaximumBlocks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8b81cf89_2c9a_493b_82d5_728c36c45e86
    {

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint Msg;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_8b3e61b3_bca7_4933_9aac_1d4748de2126
    {

        /// PFN_RPCNOTIFICATION_ROUTINE->RPCNOTIFICATION_ROUTINE*
        public IntPtr NotificationRoutine;

        /// HANDLE->void*
        public IntPtr hThread;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_8abb5787_2644_417f_a055_f230370c6002
    {

        /// Anonymous_1ebdd9bb_93d1_48f0_9961_02f98fbaaf97
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_1ebdd9bb_93d1_48f0_9961_02f98fbaaf97 Struct1;

        /// USHORT->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort signscale;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_8aa3785c_22bd_4ac9_90f4_6ed601ba4a84
    {

        /// LONGLONG->__int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long llVal;

        /// LONG->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int lVal;

        /// BYTE->unsigned char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte bVal;

        /// SHORT->short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public short iVal;

        /// FLOAT->float
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public float fltVal;

        /// DOUBLE->double
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public double dblVal;

        /// VARIANT_BOOL->short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public short boolVal;

        /// SCODE->LONG->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int scode;

        /// CY->tagCY
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCY cyVal;

        /// DATE->double
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public double date;

        /// BSTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr bstrVal;

        /// IUnknown*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr punkVal;

        /// IDispatch*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdispVal;

        /// SAFEARRAY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr parray;

        /// BYTE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pbVal;

        /// SHORT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr piVal;

        /// LONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr plVal;

        /// LONGLONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pllVal;

        /// FLOAT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pfltVal;

        /// DOUBLE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdblVal;

        /// VARIANT_BOOL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pboolVal;

        /// SCODE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pscode;

        /// CY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pcyVal;

        /// DATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdate;

        /// BSTR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pbstrVal;

        /// IUnknown**
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppunkVal;

        /// IDispatch**
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppdispVal;

        /// SAFEARRAY**
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pparray;

        /// VARIANT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pvarVal;

        /// PVOID->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr byref;

        /// CHAR->char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte cVal;

        /// USHORT->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort uiVal;

        /// ULONG->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint ulVal;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong ullVal;

        /// INT->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int intVal;

        /// UINT->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint uintVal;

        /// DECIMAL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdecVal;

        /// CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pcVal;

        /// USHORT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr puiVal;

        /// ULONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pulVal;

        /// ULONGLONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pullVal;

        /// INT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pintVal;

        /// UINT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr puintVal;

        /// ___tagBRECORD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public brecVal Struct1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Anonymous_8a75d5d0_84ce_4789_a5bb_dd44f5216f27
    {

        /// DWORD->unsigned int
        public uint dwType;

        /// DWORD->unsigned int
        public uint dwDeviceID;

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Anonymous_89cfe1e1_00b8_469c_88c3_21e3caf5899b(IntPtr param0, IntPtr param1);

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_88f3017d_a889_46b6_84da_843bcde8f004
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_88ea22a4_7f27_4000_9e6a_caeb8d94a2fd
    {

        /// WORD[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U2)]
        public ushort[] Dimension;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_88e17f4a_56bc_4ac7_a088_8ac013993c30
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint ForwarderString;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Function;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Ordinal;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint AddressOfData;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_884f82cb_5522_4cde_9861_2583ea4ab552
    {

        /// HANDLE->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// HANDLE->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hMonitor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_865d3c92_fe8c_4ee6_9601_a9eb2536957e
    {

        /// short
        public short dmOrientation;

        /// short
        public short dmPaperSize;

        /// short
        public short dmPaperLength;

        /// short
        public short dmPaperWidth;

        /// short
        public short dmScale;

        /// short
        public short dmCopies;

        /// short
        public short dmDefaultSource;

        /// short
        public short dmPrintQuality;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_845d88d8_08bf_4524_8a38_0222d8c5bd4c
    {

        /// Anonymous_42078ff8_1315_4556_9a2e_948c21558de8
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_42078ff8_1315_4556_9a2e_948c21558de8 Struct1;

        /// BYTE[48]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte[] ExtendedInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_83b19898_3ab8_4cb1_a6de_d8f699e1dc4b
    {

        /// HANDLE->void*
        public IntPtr hIOPort;

        /// DWORD->unsigned int
        public uint dwNumberOfBytesTransferred;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCompletionKey;

        /// LPOVERLAPPED->_OVERLAPPED*
        public IntPtr lpOverlapped;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ARRAY_INFO
    {

        /// int
        public int Dimension;

        /// unsigned int*
        public IntPtr BufferConformanceMark;

        /// unsigned int*
        public IntPtr BufferVarianceMark;

        /// unsigned int*
        public IntPtr MaxCountArray;

        /// unsigned int*
        public IntPtr OffsetArray;

        /// unsigned int*
        public IntPtr ActualCountArray;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_838128fc_6fad_48ae_bb9f_1ce1ded37abc
    {

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszTemplate;

        /// PROPSHEETPAGE_RESOURCE->LPCDLGTEMPLATE->LPCDLGTEMPLATEW->DLGTEMPLATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pResource;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    ///param2: void*
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Anonymous_82879911_f429_4373_bb0c_5e75913076ff(IntPtr param0, IntPtr param1, IntPtr param2);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct Anonymous_7f7374db_bded_4271_9e48_f4aee28762e0
    {

        /// DWORD->unsigned int
        public uint dwType;

        /// DWORD->unsigned int
        public uint dwDeviceID;

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_7dadb22a_8bbe_4747_9d2a_2d35c978fd6b
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint Characteristics;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint OriginalFirstThunk;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_7a7460d9_d99f_4e9a_9ebb_cdd10c08463d
    {

        /// Anonymous_865d3c92_fe8c_4ee6_9601_a9eb2536957e
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_865d3c92_fe8c_4ee6_9601_a9eb2536957e Struct1;

        /// Anonymous_1b5f787e_41ca_472c_8595_3484490ffe0c
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_1b5f787e_41ca_472c_8595_3484490ffe0c Struct2;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_79fe9041_6876_475e_b93a_ffb0d7822836
    {

        /// KEY_EVENT_RECORD->_KEY_EVENT_RECORD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public KEY_EVENT_RECORD KeyEvent;

        /// MOUSE_EVENT_RECORD->_MOUSE_EVENT_RECORD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public MOUSE_EVENT_RECORD MouseEvent;

        /// WINDOW_BUFFER_SIZE_RECORD->_WINDOW_BUFFER_SIZE_RECORD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        /// MENU_EVENT_RECORD->_MENU_EVENT_RECORD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public MENU_EVENT_RECORD MenuEvent;

        /// FOCUS_EVENT_RECORD->_FOCUS_EVENT_RECORD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public FOCUS_EVENT_RECORD FocusEvent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_789d578d_d7a5_48ff_8fd4_02e9d00e01f2
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER NextVcn;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Lcn;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_77c631f1_b84e_4548_aa5c_9f59a7947f03
    {

        /// HBITMAP->HBITMAP__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hbmWatermark;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszbmWatermark;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_75f63f95_3c9e_4dd3_9ea4_4111163afbd5
    {

        /// BaseMid : 8
        ///Type : 5
        ///Dpl : 2
        ///Pres : 1
        ///LimitHi : 4
        ///Sys : 1
        ///Reserved_0 : 1
        ///Default_Big : 1
        ///Granularity : 1
        ///BaseHi : 8
        public uint bitvector1;

        public uint BaseMid
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

        public uint Type
        {
            get
            {
                return ((uint)(((this.bitvector1 & 7936u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint Dpl
        {
            get
            {
                return ((uint)(((this.bitvector1 & 24576u)
                            / 8192)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8192)
                            | this.bitvector1)));
            }
        }

        public uint Pres
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32768u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }

        public uint LimitHi
        {
            get
            {
                return ((uint)(((this.bitvector1 & 983040u)
                            / 65536)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 65536)
                            | this.bitvector1)));
            }
        }

        public uint Sys
        {
            get
            {
                return ((uint)(((this.bitvector1 & 1048576u)
                            / 1048576)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 1048576)
                            | this.bitvector1)));
            }
        }

        public uint Reserved_0
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2097152u)
                            / 2097152)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2097152)
                            | this.bitvector1)));
            }
        }

        public uint Default_Big
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4194304u)
                            / 4194304)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4194304)
                            | this.bitvector1)));
            }
        }

        public uint Granularity
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8388608u)
                            / 8388608)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8388608)
                            | this.bitvector1)));
            }
        }

        public uint BaseHi
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4278190080u)
                            / 16777216)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16777216)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_7557e508_845c_4777_b9f2_a1496c1c7b21
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dmDisplayFlags;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dmNup;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196
    {

        /// Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_ac6e4301_4438_458f_96dd_e86faeeca2a6 Struct1;

        /// PVOID->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr Pointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_715d4807_68f7_43b3_b3b6_d2fd0500eaa4
    {

        /// BYTE->unsigned char
        public byte BaseMid;

        /// BYTE->unsigned char
        public byte Flags1;

        /// BYTE->unsigned char
        public byte Flags2;

        /// BYTE->unsigned char
        public byte BaseHi;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    ///param2: void*
    public delegate int Anonymous_712f731c_8898_4095_bb36_d1b2b0fe0b83(IntPtr param0, IntPtr param1, IntPtr param2);

    /// Return Type: void
    public delegate void Anonymous_7014e5a0_06d0_47bd_9292_4908f9ff022f();

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_6ec22b34_e8ab_46f2_a900_b8a44fc9e55d
    {

        /// Anonymous_715d4807_68f7_43b3_b3b6_d2fd0500eaa4
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_715d4807_68f7_43b3_b3b6_d2fd0500eaa4 Bytes;

        /// Anonymous_75f63f95_3c9e_4dd3_9ea4_4111163afbd5
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_75f63f95_3c9e_4dd3_9ea4_4111163afbd5 Bits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_6e0f8c69_24ae_43c4_ac6c_3e9d8eaffb13
    {

        /// VARTYPE->unsigned short
        public ushort vt;

        /// PROPVAR_PAD1->WORD->unsigned short
        public ushort wReserved1;

        /// PROPVAR_PAD2->WORD->unsigned short
        public ushort wReserved2;

        /// PROPVAR_PAD3->WORD->unsigned short
        public ushort wReserved3;

        /// Anonymous_0ed939e3_7b16_4dcc_ab75_9ab92cfdc558
        public Anonymous_0ed939e3_7b16_4dcc_ab75_9ab92cfdc558 Union1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_6d643135_3562_4386_a300_df7ee6f42ac2
    {

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint[] adwData;

        /// Anonymous_e8fd624a_62ed_4ea9_b136_c21a4d47e44b
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_e8fd624a_62ed_4ea9_b136_c21a4d47e44b Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_6d57931d_760c_4b56_8749_64bd6367fd2f
    {

        /// DWORD->unsigned int
        public uint Calls;

        /// DWORD->unsigned int
        public uint Clusters;

        /// DWORD->unsigned int
        public uint Hints;

        /// DWORD->unsigned int
        public uint RunsReturned;

        /// DWORD->unsigned int
        public uint HintsHonored;

        /// DWORD->unsigned int
        public uint HintsClusters;

        /// DWORD->unsigned int
        public uint Cache;

        /// DWORD->unsigned int
        public uint CacheClusters;

        /// DWORD->unsigned int
        public uint CacheMiss;

        /// DWORD->unsigned int
        public uint CacheMissClusters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_6cd904db_e392_48a8_8a97_d1256010f471
    {

        /// WORD->unsigned short
        public ushort Linenumber;

        /// WORD->unsigned short
        public ushort Size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_6bf0fd06_e931_4db4_bf97_e2e2b7af523b
    {

        /// DWORD->unsigned int
        public uint NodeNumber;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_6b974a5d_1ff7_4e60_8dc7_d6d0c32293be
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_6a8b6acb_03f6_4286_8d2c_69d4d4f7c663
    {

        /// PARTITION_INFORMATION_MBR->_PARTITION_INFORMATION_MBR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public PARTITION_INFORMATION_MBR Mbr;

        /// PARTITION_INFORMATION_GPT->_PARTITION_INFORMATION_GPT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public PARTITION_INFORMATION_GPT Gpt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_697c29df_00ad_48da_88b3_fa9cfa1f6467
    {

        /// DWORD->unsigned int
        public uint Length;

        /// WORD->unsigned short
        public ushort NumberOfRelocations;

        /// WORD->unsigned short
        public ushort NumberOfLinenumbers;

        /// DWORD->unsigned int
        public uint CheckSum;

        /// SHORT->short
        public short Number;

        /// BYTE->unsigned char
        public byte Selection;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Anonymous_68bd195f_ce6e_4d89_96fd_17837a3303be
    {

        /// unsigned char[12]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string ld12;
    }

    /// Return Type: BOOL->int
    ///dwContinue: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int Anonymous_6870f0ea_5b0f_451e_b508_21951610fb29(uint dwContinue);

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_66fbe071_3167_4320_82ad_d492d987c873
    {

        /// WORD->unsigned short
        public ushort Minimum;

        /// WORD->unsigned short
        public ushort Maximum;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_652f900e_e9d5_4a81_ba95_5c3af2ba5157
    {

        /// DWORD->unsigned int
        public uint LowPart;

        /// DWORD->unsigned int
        public uint HighPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_63fe3feb_0017_41da_8c7f_24da3f99f4a8
    {

        /// u_short->unsigned short
        public ushort s_w1;

        /// u_short->unsigned short
        public ushort s_w2;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_63310a95_9b9e_4688_be91_41d3e7b47594
    {

        /// Anonymous_a6322a0a_897e_4c05_9984_d5cc72d24537
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_a6322a0a_897e_4c05_9984_d5cc72d24537 Mbr;

        /// Anonymous_8f4ef992_3a82_4e46_a5c0_bb11d9e824e2
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8f4ef992_3a82_4e46_a5c0_bb11d9e824e2 Gpt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_630b6059_fc11_4fc5_8e79_12b6819f7f2b
    {

        /// ULONG->unsigned int
        public uint Lo32;

        /// ULONG->unsigned int
        public uint Mid32;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_62e38fe9_336a_4989_8fc3_091f25ee1b7d
    {

        /// ULONG->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint oInst;

        /// VARIANT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lpvarValue;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_5fb4f54e_e61b_4684_b8b7_bfc5d228ac55
    {

        /// HBITMAP->HBITMAP__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hbmHeader;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszbmHeader;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_5db048c7_4515_47f5_a6fa_ac03121be649
    {

        /// STORAGE_MEDIA_TYPE->_STORAGE_MEDIA_TYPE
        public STORAGE_MEDIA_TYPE MediaType;

        /// DWORD->unsigned int
        public uint MediaCharacteristics;

        /// DWORD->unsigned int
        public uint CurrentBlockSize;

        /// STORAGE_BUS_TYPE->_STORAGE_BUS_TYPE
        public STORAGE_BUS_TYPE BusType;

        /// Anonymous_f9ea10e8_4357_4c9c_9653_6d8541173cb4
        public Anonymous_f9ea10e8_4357_4c9c_9653_6d8541173cb4 BusSpecificData;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_57577a68_32f1_4b39_9314_4bacfa47bb2b
    {

        /// PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pEphemeralAlgorithm;

        /// PCERT_ID->_CERT_ID*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pSenderId;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_53c79322_6506_4260_871f_234e2af0cacb
    {

        /// Anonymous_8fdd9a27_0167_4a68_9d58_0eb653f5b1e6
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8fdd9a27_0167_4a68_9d58_0eb653f5b1e6 Block;

        /// Anonymous_e469aa29_5a46_4c74_b009_60adb4b669c8
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_e469aa29_5a46_4c74_b009_60adb4b669c8 Region;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_525db7aa_e002_4f41_a515_7d138d82263e
    {

        /// ___tagVARIANT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public n2 Struct1;

        /// DECIMAL->tagDEC
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagDEC decVal;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_500af501_b9b4_43cc_ad24_07d5d9d24897
    {

        /// USHORT->unsigned short
        public ushort usButtonFlags;

        /// USHORT->unsigned short
        public ushort usButtonData;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_4e912b36_f5ab_4eb4_804f_6587b7a78602
    {

        /// ULONG->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint ulButtons;

        /// Anonymous_500af501_b9b4_43cc_ad24_07d5d9d24897
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_500af501_b9b4_43cc_ad24_07d5d9d24897 Struct1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_4ab5a4bd_9e2a_4940_b27d_599c914ef6f1
    {

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszTemplate;

        /// PROPSHEETPAGE_RESOURCE->LPCDLGTEMPLATE->LPCDLGTEMPLATEW->DLGTEMPLATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pResource;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_459bdf75_2992_4fef_9fb5_389952f59d12
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwOemId;

        /// Anonymous_a30d5f78_3b46_471a_9d25_915a0fe3987d
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_a30d5f78_3b46_471a_9d25_915a0fe3987d Struct1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_452bdd45_7a70_4765_9e3d_53eceb6d0161
    {

        /// HBITMAP->HBITMAP__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hbmHeader;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszbmHeader;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_446ffc7f_2d11_49ef_8817_6d4d0b594562
    {

        /// handle_t*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pAutoHandle;

        /// handle_t*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pPrimitiveHandle;

        /// PGENERIC_BINDING_INFO->__GENERIC_BINDING_INFO*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pGenericBindingInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_440c4700_1348_4323_b8bb_ed586c28a10a
    {

        /// HKEY->HKEY__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hKeyBase;

        /// void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pvBase;
    }

    /// Return Type: BOOL->int
    ///dwContinue: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int Anonymous_42eb69bb_a3bf_486c_b3eb_748b6625c8bb(uint dwContinue);

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_42078ff8_1315_4556_9a2e_948c21558de8
    {

        /// BYTE[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] BirthVolumeId;

        /// BYTE[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] BirthObjectId;

        /// BYTE[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] DomainId;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_40d14048_0ade_44b7_81ed_baa885f6fcb2
    {

        /// IDLDESC->tagIDLDESC
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagIDLDESC idldesc;

        /// PARAMDESC->tagPARAMDESC
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagPARAMDESC paramdesc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_3cdcd72e_692f_4916_8874_aac0ab7bab52
    {

        /// DWORD->unsigned int
        public uint TagIndex;

        /// Anonymous_996376cd_198e_4f94_b294_6f092ed08535
        public Anonymous_996376cd_198e_4f94_b294_6f092ed08535 Misc;

        /// Anonymous_d6929560_b153_442e_89bc_7373a0f636e0
        public Anonymous_d6929560_b153_442e_89bc_7373a0f636e0 FcnAry;

        /// WORD->unsigned short
        public ushort TvIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_3a310f0b_0a67_46e7_8794_44e92ad7cf48
    {

        /// double
        public double x;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_3a267c73_6f53_4684_8e08_c837426a0e56
    {

        /// unsigned int
        public uint Lo;

        /// int
        public int Hi;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_38397079_17e2_45c2_94c5_3c954e09268b
    {

        /// RPC_HTTP_TRANSPORT_CREDENTIALS_A*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr HttpCredentials;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_37959f42_bffb_4b55_963f_66ec2f0aca1a
    {

        /// Anonymous_2f494fb7_b3b2_4110_a56f_cf33f0d0b2f2
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_2f494fb7_b3b2_4110_a56f_cf33f0d0b2f2 DiskInfo;

        /// Anonymous_14edf120_c05e_42ee_bd56_a581efe69561
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_14edf120_c05e_42ee_bd56_a581efe69561 RemovableDiskInfo;

        /// Anonymous_5db048c7_4515_47f5_a6fa_ac03121be649
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_5db048c7_4515_47f5_a6fa_ac03121be649 TapeInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_352ff64d_9a41_492e_a113_1156c54b2291
    {

        /// BOOL->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        [MarshalAs(UnmanagedType.I1)]
        public bool bData;

        /// LONG->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int iData;

        /// LPWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr sData;

        /// FLOAT->float
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public float fData;

        /// BINARY_CONTAINER->_BINARY_CONTAINER
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public BINARY_CONTAINER biData;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_34cf2035_247b_4d12_a4e4_7a7be8706b8a
    {

        /// UINT->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint nStartPage;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pStartPage;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_32d07395_111c_4bbf_950d_b622ca74a868
    {

        /// Anonymous_f9090501_6b7a_42cd_8375_395510c223f6
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_f9090501_6b7a_42cd_8375_395510c223f6 Struct1;

        /// Anonymous_9e5ba8f4_6347_4f61_912e_6d0d46462b33
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_9e5ba8f4_6347_4f61_912e_6d0d46462b33 Struct2;

        /// DWORD[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_32cf6d47_d069_456c_bd13_17fc2e179c43
    {

        /// SCARD_T0_COMMAND->Anonymous_a726b547_cacc_4421_9c8c_789e32c0b4a3
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SCARD_T0_COMMAND CmdBytes;

        /// BYTE[5]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte[] rgbHeader;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_30c38121_85ac_43e6_9dce_8c8aabb85854
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cSteps;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cbCustomData;

        /// DWORD[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_2f494fb7_b3b2_4110_a56f_cf33f0d0b2f2
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Cylinders;

        /// STORAGE_MEDIA_TYPE->_STORAGE_MEDIA_TYPE
        public STORAGE_MEDIA_TYPE MediaType;

        /// DWORD->unsigned int
        public uint TracksPerCylinder;

        /// DWORD->unsigned int
        public uint SectorsPerTrack;

        /// DWORD->unsigned int
        public uint BytesPerSector;

        /// DWORD->unsigned int
        public uint NumberMediaSides;

        /// DWORD->unsigned int
        public uint MediaCharacteristics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_2d16cbec_6a75_4063_8a95_597207c39783
    {

        /// WORD->unsigned short
        public ushort Write;

        /// WORD->unsigned short
        public ushort Create;

        /// WORD->unsigned short
        public ushort SetInfo;

        /// WORD->unsigned short
        public ushort Flush;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_2a548e1e_0ffc_4341_926b_8beddd8eca29
    {

        /// float
        public float f;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_2a1aa424_7c4b_4b99_a886_35278aac8963
    {

        /// CERT_ID->_CERT_ID
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CERT_ID OriginatorCertId;

        /// CERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CERT_PUBLIC_KEY_INFO OriginatorPublicKeyInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_2a02bd72_5e93_4bfa_a921_8105eb25ec72
    {

        /// LONG->int
        public int lMinimum;

        /// LONG->int
        public int lMaximum;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_29f7e609_4e9c_4993_9ec9_18c8c124fbcf
    {

        /// Anonymous_2a02bd72_5e93_4bfa_a921_8105eb25ec72
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_2a02bd72_5e93_4bfa_a921_8105eb25ec72 Struct1;

        /// Anonymous_b53f0817_0352_415a_9818_e30c336c1e5d
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_b53f0817_0352_415a_9818_e30c336c1e5d Struct2;

        /// DWORD[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_2842b733_4922_41bc_a227_1c9bafdb7271
    {

        /// HCRYPTKEY->ULONG_PTR->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint hKeyEncryptionKey;

        /// void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pvKeyEncryptionKey;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_28149612_2d2b_4017_83d6_ea46e595ab25
    {

        /// SET_PARTITION_INFORMATION_MBR->SET_PARTITION_INFORMATION->_SET_PARTITION_INFORMATION
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SET_PARTITION_INFORMATION Mbr;

        /// SET_PARTITION_INFORMATION_GPT->PARTITION_INFORMATION_GPT->_PARTITION_INFORMATION_GPT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public PARTITION_INFORMATION_GPT Gpt;
    }

    /// Return Type: void
    public delegate void Anonymous_238be435_467a_48ad_a30b_1282af22b1d7();

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_2338c0fc_03a3_4514_b536_fb9bb5df14c5
    {

        /// Anonymous_a67d541d_da92_408e_8852_89977e56cead
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_a67d541d_da92_408e_8852_89977e56cead Struct1;

        /// Anonymous_d973d7e7_ad4c_4155_86fe_6d2b51ab5f04
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_d973d7e7_ad4c_4155_86fe_6d2b51ab5f04 Struct2;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_222c9197_a443_449d_8fe0_b6b264448c71
    {

        /// HBITMAP->HBITMAP__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hbmWatermark;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszbmWatermark;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    ///param2: void*
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Anonymous_20ceb12c_2155_4424_b974_1f19ad09b67c(IntPtr param0, IntPtr param1, IntPtr param2);

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_2065bd0b_b2af_4631_9cf9_a0bd7667dad0
    {

        /// PROPID->ULONG->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint propid;

        /// LPOLESTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lpwstr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_1ebdd9bb_93d1_48f0_9961_02f98fbaaf97
    {

        /// BYTE->unsigned char
        public byte scale;

        /// BYTE->unsigned char
        public byte sign;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_1d792489_fdc0_40ba_bfc7_71924b76616a
    {

        /// Anonymous_8b3e61b3_bca7_4933_9aac_1d4748de2126
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8b3e61b3_bca7_4933_9aac_1d4748de2126 APC;

        /// Anonymous_83b19898_3ab8_4cb1_a6de_d8f699e1dc4b
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_83b19898_3ab8_4cb1_a6de_d8f699e1dc4b IOC;

        /// Anonymous_8b81cf89_2c9a_493b_82d5_728c36c45e86
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8b81cf89_2c9a_493b_82d5_728c36c45e86 HWND;

        /// HANDLE->void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hEvent;

        /// PFN_RPCNOTIFICATION_ROUTINE->RPCNOTIFICATION_ROUTINE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr NotificationRoutine;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_1d5bfd98_6f98_4ee1_862c_03b73f120f91
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwControlID;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dwControlType;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_1cd4c797_e9ca_4fb1_b8de_64995b16a502
    {

        /// Anonymous_6e0f8c69_24ae_43c4_ac6c_3e9d8eaffb13
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_6e0f8c69_24ae_43c4_ac6c_3e9d8eaffb13 Struct1;

        /// DECIMAL->tagDEC
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagDEC decVal;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    public delegate int Anonymous_1be4f191_dc1f_48e3_98db_681dadcc9987(IntPtr param0, IntPtr param1);

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_1b5f787e_41ca_472c_8595_3484490ffe0c
    {

        /// POINTL->_POINTL
        public POINTL dmPosition;

        /// DWORD->unsigned int
        public uint dmDisplayOrientation;

        /// DWORD->unsigned int
        public uint dmDisplayFixedOutput;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    public delegate int Anonymous_19f4a427_fefd_4c19_8be1_32ce0323fef3(IntPtr param0, IntPtr param1);

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_19ab1780_6726_4de7_b522_04c6cbe4cee1
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_191604fe_770e_4688_aef5_8c113498eb25
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint ms;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint sample;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cb;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint ticks;

        /// Anonymous_9bd9399e_c332_40ac_ad3c_8155b5ea7388
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_9bd9399e_c332_40ac_ad3c_8155b5ea7388 smpte;

        /// Anonymous_cb1eb549_6c81_48bd_b5bf_228b52412176
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_cb1eb549_6c81_48bd_b5bf_228b52412176 midi;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_17a38332_c2b3_4631_bf14_5a1ac15957d8
    {

        /// RPC_HTTP_TRANSPORT_CREDENTIALS_W*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr HttpCredentials;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_166634b0_1a53_4bd3_a2ea_6cf895ccf002
    {

        /// NDR_USER_MARSHAL_INFO_LEVEL1->_NDR_USER_MARSHAL_INFO_LEVEL1
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public NDR_USER_MARSHAL_INFO_LEVEL1 Level1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_1601fc15_53ff_4fde_8559_0bc744288a1c
    {

        /// CERT_ALT_NAME_INFO->_CERT_ALT_NAME_INFO
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public CERT_ALT_NAME_INFO FullName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_14edf120_c05e_42ee_bd56_a581efe69561
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Cylinders;

        /// STORAGE_MEDIA_TYPE->_STORAGE_MEDIA_TYPE
        public STORAGE_MEDIA_TYPE MediaType;

        /// DWORD->unsigned int
        public uint TracksPerCylinder;

        /// DWORD->unsigned int
        public uint SectorsPerTrack;

        /// DWORD->unsigned int
        public uint BytesPerSector;

        /// DWORD->unsigned int
        public uint NumberMediaSides;

        /// DWORD->unsigned int
        public uint MediaCharacteristics;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_14807298_3e51_42fc_9504_55e7fb0c037f
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cbStruct;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint cbSize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_11ed492b_9ab3_4f10_8119_154d936020f6
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_103794fb_1804_41f9_9e19_be8a73f304d1
    {

        /// LPSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr AnsiString;

        /// LPWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr UnicodeString;

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int LVal;

        /// short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public short SVal;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong PVal;

        /// BinaryParam->tagBinaryParam
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagBinaryParam BVal;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_0ed939e3_7b16_4dcc_ab75_9ab92cfdc558
    {

        /// CHAR->char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte cVal;

        /// UCHAR->unsigned char
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public byte bVal;

        /// SHORT->short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public short iVal;

        /// USHORT->unsigned short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ushort uiVal;

        /// LONG->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int lVal;

        /// ULONG->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint ulVal;

        /// INT->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int intVal;

        /// UINT->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint uintVal;

        /// LARGE_INTEGER->_LARGE_INTEGER
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public LARGE_INTEGER hVal;

        /// ULARGE_INTEGER->_ULARGE_INTEGER
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ULARGE_INTEGER uhVal;

        /// FLOAT->float
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public float fltVal;

        /// DOUBLE->double
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public double dblVal;

        /// VARIANT_BOOL->short
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public short boolVal;

        /// SCODE->LONG->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int scode;

        /// CY->tagCY
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCY cyVal;

        /// DATE->double
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public double date;

        /// FILETIME->_FILETIME
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public FILETIME filetime;

        /// CLSID*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr puuid;

        /// CLIPDATA*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pclipdata;

        /// BSTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr bstrVal;

        /// BSTRBLOB->tagBSTRBLOB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagBSTRBLOB bstrblobVal;

        /// BLOB->tagBLOB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagBLOB blob;

        /// LPSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszVal;

        /// LPWSTR->WCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pwszVal;

        /// IUnknown*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr punkVal;

        /// IDispatch*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdispVal;

        /// IStream*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pStream;

        /// IStorage*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pStorage;

        /// LPVERSIONEDSTREAM->tagVersionedStream*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pVersionedStream;

        /// LPSAFEARRAY->SAFEARRAY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr parray;

        /// CAC->tagCAC
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAC cac;

        /// CAUB->tagCAUB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAUB caub;

        /// CAI->tagCAI
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAI cai;

        /// CAUI->tagCAUI
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAUI caui;

        /// CAL->tagCAL
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAL cal;

        /// CAUL->tagCAUL
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAUL caul;

        /// CAH->tagCAH
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAH cah;

        /// CAUH->tagCAUH
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAUH cauh;

        /// CAFLT->tagCAFLT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAFLT caflt;

        /// CADBL->tagCADBL
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCADBL cadbl;

        /// CABOOL->tagCABOOL
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCABOOL cabool;

        /// CASCODE->tagCASCODE
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCASCODE cascode;

        /// CACY->tagCACY
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCACY cacy;

        /// CADATE->tagCADATE
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCADATE cadate;

        /// CAFILETIME->tagCAFILETIME
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAFILETIME cafiletime;

        /// CACLSID->tagCACLSID
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCACLSID cauuid;

        /// CACLIPDATA->tagCACLIPDATA
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCACLIPDATA caclipdata;

        /// CABSTR->tagCABSTR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCABSTR cabstr;

        /// CABSTRBLOB->tagCABSTRBLOB
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCABSTRBLOB cabstrblob;

        /// CALPSTR->tagCALPSTR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCALPSTR calpstr;

        /// CALPWSTR->tagCALPWSTR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCALPWSTR calpwstr;

        /// CAPROPVARIANT->tagCAPROPVARIANT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public tagCAPROPVARIANT capropvar;

        /// CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pcVal;

        /// UCHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pbVal;

        /// SHORT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr piVal;

        /// USHORT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr puiVal;

        /// LONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr plVal;

        /// ULONG*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pulVal;

        /// INT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pintVal;

        /// UINT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr puintVal;

        /// FLOAT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pfltVal;

        /// DOUBLE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdblVal;

        /// VARIANT_BOOL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pboolVal;

        /// DECIMAL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdecVal;

        /// SCODE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pscode;

        /// CY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pcyVal;

        /// DATE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pdate;

        /// BSTR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pbstrVal;

        /// IUnknown**
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppunkVal;

        /// IDispatch**
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr ppdispVal;

        /// LPSAFEARRAY*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pparray;

        /// PROPVARIANT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pvarVal;
    }

    /// Return Type: int
    ///param0: void*
    ///param1: void*
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Anonymous_0e3bac4b_012a_4c06_9ff5_73383859a489(IntPtr param0, IntPtr param1);

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_0afef47a_7c7b_4367_b4ad_cb85b5f7e05e
    {

        /// HICON->HICON__*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hIcon;

        /// LPCSTR->CHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pszIcon;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_09d5703c_909d_49c4_b6db_fb280d26bdf1
    {

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string locale;

        /// wchar_t*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string wlocale;

        /// int*
        public IntPtr refcount;

        /// int*
        public IntPtr wrefcount;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_084dbe97_5806_4c28_a299_ed6037f61d90
    {

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dmDisplayFlags;

        /// DWORD->unsigned int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public uint dmNup;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_07cb9bb0_963c_4d78_8963_ec574f75d3fc
    {

        /// SYSTEMTIME->_SYSTEMTIME
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SYSTEMTIME SystemTime;

        /// FILETIME->_FILETIME
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public FILETIME FileTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Anonymous_05fd816a_fd3c_44de_9f0d_62b1893f6632
    {

        /// WORD->unsigned short
        public ushort Write;

        /// WORD->unsigned short
        public ushort Create;

        /// WORD->unsigned short
        public ushort SetInfo;

        /// WORD->unsigned short
        public ushort Flush;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_034857e8_2cb2_40e6_8427_2aed5a66c84e
    {

        /// Anonymous_8bcaf072_e89e_46be_b5ce_4cb09f1d0bbf
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_8bcaf072_e89e_46be_b5ce_4cb09f1d0bbf ScalarPrefetch;

        /// Anonymous_66fbe071_3167_4320_82ad_d492d987c873
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_66fbe071_3167_4320_82ad_d492d987c873 BlockPrefetch;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_02cf5c90_12c2_42ca_832a_8cd3aa7fc46f
    {

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong EndOfPrologue;

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong UnwindInfoAddress;
    }

    /// Return Type: BOOL->int
    ///param0: HDC->HDC__*
    ///param1: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int ABORTPROC([In] IntPtr param0, int param1);

    [StructLayout(LayoutKind.Sequential)]
    public struct AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwRegPolicySettings;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fCommercial;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fCommercial;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwRegPolicySettings;

        /// PCMSG_SIGNER_INFO->_CMSG_SIGNER_INFO*
        public IntPtr pSignerInfo;
    }

    public enum AUDIT_EVENT_TYPE
    {

        AuditEventObjectAccess,

        AuditEventDirectoryServiceAccess,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASSEMBLY_FILE_DETAILED_INFORMATION
    {

        /// DWORD->unsigned int
        public uint ulFlags;

        /// DWORD->unsigned int
        public uint ulFilenameLength;

        /// DWORD->unsigned int
        public uint ulPathLength;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpFileName;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpFilePath;
    }

    public enum APTTYPE
    {

        /// APTTYPE_CURRENT -> -1
        APTTYPE_CURRENT = -1,

        /// APTTYPE_STA -> 0
        APTTYPE_STA = 0,

        /// APTTYPE_MTA -> 1
        APTTYPE_MTA = 1,

        /// APTTYPE_NA -> 2
        APTTYPE_NA = 2,

        /// APTTYPE_MAINSTA -> 3
        APTTYPE_MAINSTA = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct APPBARDATA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint uCallbackMessage;

        /// UINT->unsigned int
        public uint uEdge;

        /// RECT->tagRECT
        public tagRECT rc;

        /// LPARAM->LONG_PTR->int
        public int lParam;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ADMINISTRATOR_POWER_POLICY
    {

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE MinSleep;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE MaxSleep;

        /// DWORD->unsigned int
        public uint MinVideoTimeout;

        /// DWORD->unsigned int
        public uint MaxVideoTimeout;

        /// DWORD->unsigned int
        public uint MinSpindownTimeout;

        /// DWORD->unsigned int
        public uint MaxSpindownTimeout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ADDJOB_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string Path;

        /// DWORD->unsigned int
        public uint JobId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ADDJOB_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string Path;

        /// DWORD->unsigned int
        public uint JobId;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ADAPTER_STATUS
    {

        /// UCHAR[6]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string adapter_address;

        /// UCHAR->unsigned char
        public byte rev_major;

        /// UCHAR->unsigned char
        public byte reserved0;

        /// UCHAR->unsigned char
        public byte adapter_type;

        /// UCHAR->unsigned char
        public byte rev_minor;

        /// WORD->unsigned short
        public ushort duration;

        /// WORD->unsigned short
        public ushort frmr_recv;

        /// WORD->unsigned short
        public ushort frmr_xmit;

        /// WORD->unsigned short
        public ushort iframe_recv_err;

        /// WORD->unsigned short
        public ushort xmit_aborts;

        /// DWORD->unsigned int
        public uint xmit_success;

        /// DWORD->unsigned int
        public uint recv_success;

        /// WORD->unsigned short
        public ushort iframe_xmit_err;

        /// WORD->unsigned short
        public ushort recv_buff_unavail;

        /// WORD->unsigned short
        public ushort t1_timeouts;

        /// WORD->unsigned short
        public ushort ti_timeouts;

        /// DWORD->unsigned int
        public uint reserved1;

        /// WORD->unsigned short
        public ushort free_ncbs;

        /// WORD->unsigned short
        public ushort max_cfg_ncbs;

        /// WORD->unsigned short
        public ushort max_ncbs;

        /// WORD->unsigned short
        public ushort xmit_buf_unavail;

        /// WORD->unsigned short
        public ushort max_dgram_size;

        /// WORD->unsigned short
        public ushort pending_sess;

        /// WORD->unsigned short
        public ushort max_cfg_sess;

        /// WORD->unsigned short
        public ushort max_sess;

        /// WORD->unsigned short
        public ushort max_sess_pkt_size;

        /// WORD->unsigned short
        public ushort name_count;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTIVATION_CONTEXT_QUERY_INDEX
    {

        /// DWORD->unsigned int
        public uint ulAssemblyIndex;

        /// DWORD->unsigned int
        public uint ulFileIndexInAssembly;
    }

    public enum ACTIVATION_CONTEXT_INFO_CLASS
    {

        /// ActivationContextBasicInformation -> 1
        ActivationContextBasicInformation = 1,

        /// ActivationContextDetailedInformation -> 2
        ActivationContextDetailedInformation = 2,

        /// AssemblyDetailedInformationInActivationContext -> 3
        AssemblyDetailedInformationInActivationContext = 3,

        /// FileInformationInAssemblyOfAssemblyInActivationContext -> 4
        FileInformationInAssemblyOfAssemblyInActivationContext = 4,

        MaxActivationContextInfoClass,

        /// AssemblyDetailedInformationInActivationContxt -> 3
        AssemblyDetailedInformationInActivationContxt = 3,

        /// FileInformationInAssemblyOfAssemblyInActivationContxt -> 4
        FileInformationInAssemblyOfAssemblyInActivationContxt = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTIVATION_CONTEXT_DETAILED_INFORMATION
    {

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint ulFormatVersion;

        /// DWORD->unsigned int
        public uint ulAssemblyCount;

        /// DWORD->unsigned int
        public uint ulRootManifestPathType;

        /// DWORD->unsigned int
        public uint ulRootManifestPathChars;

        /// DWORD->unsigned int
        public uint ulRootConfigurationPathType;

        /// DWORD->unsigned int
        public uint ulRootConfigurationPathChars;

        /// DWORD->unsigned int
        public uint ulAppDirPathType;

        /// DWORD->unsigned int
        public uint ulAppDirPathChars;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpRootManifestPath;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpRootConfigurationPath;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpAppDirPath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTIVATION_CONTEXT_BASIC_INFORMATION
    {

        /// HANDLE->void*
        public IntPtr hActCtx;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION
    {

        /// DWORD->unsigned int
        public uint ulFlags;

        /// DWORD->unsigned int
        public uint ulEncodedAssemblyIdentityLength;

        /// DWORD->unsigned int
        public uint ulManifestPathType;

        /// DWORD->unsigned int
        public uint ulManifestPathLength;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER liManifestLastWriteTime;

        /// DWORD->unsigned int
        public uint ulPolicyPathType;

        /// DWORD->unsigned int
        public uint ulPolicyPathLength;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER liPolicyLastWriteTime;

        /// DWORD->unsigned int
        public uint ulMetadataSatelliteRosterIndex;

        /// DWORD->unsigned int
        public uint ulManifestVersionMajor;

        /// DWORD->unsigned int
        public uint ulManifestVersionMinor;

        /// DWORD->unsigned int
        public uint ulPolicyVersionMajor;

        /// DWORD->unsigned int
        public uint ulPolicyVersionMinor;

        /// DWORD->unsigned int
        public uint ulAssemblyDirectoryNameLength;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpAssemblyEncodedAssemblyIdentity;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpAssemblyManifestPath;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpAssemblyPolicyPath;

        /// PCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpAssemblyDirectoryName;

        /// DWORD->unsigned int
        public uint ulFileCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACTION_HEADER
    {

        /// ULONG->unsigned int
        public uint transport_id;

        /// USHORT->unsigned short
        public ushort action_code;

        /// USHORT->unsigned short
        public ushort reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACL_SIZE_INFORMATION
    {

        /// DWORD->unsigned int
        public uint AceCount;

        /// DWORD->unsigned int
        public uint AclBytesInUse;

        /// DWORD->unsigned int
        public uint AclBytesFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACL_REVISION_INFORMATION
    {

        /// DWORD->unsigned int
        public uint AclRevision;
    }

    public enum ACL_INFORMATION_CLASS
    {

        /// AclRevisionInformation -> 1
        AclRevisionInformation = 1,

        AclSizeInformation,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACL
    {

        /// BYTE->unsigned char
        public byte AclRevision;

        /// BYTE->unsigned char
        public byte Sbz1;

        /// WORD->unsigned short
        public ushort AclSize;

        /// WORD->unsigned short
        public ushort AceCount;

        /// WORD->unsigned short
        public ushort Sbz2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACE_HEADER
    {

        /// BYTE->unsigned char
        public byte AceType;

        /// BYTE->unsigned char
        public byte AceFlags;

        /// WORD->unsigned short
        public ushort AceSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_DENIED_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_DENIED_CALLBACK_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_DENIED_CALLBACK_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_DENIED_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_ALLOWED_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_ALLOWED_CALLBACK_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_ALLOWED_CALLBACK_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ACCESS_ALLOWED_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ABCFLOAT
    {

        /// FLOAT->float
        public float abcfA;

        /// FLOAT->float
        public float abcfB;

        /// FLOAT->float
        public float abcfC;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ABC
    {

        /// int
        public int abcA;

        /// UINT->unsigned int
        public uint abcB;

        /// int
        public int abcC;
    }

}
