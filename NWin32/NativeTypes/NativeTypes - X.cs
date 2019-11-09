using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: ULONG->unsigned int
    ///This: XMLDOMDocumentEvents*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint XMLDOMDocumentEventsVtbl_Release(ref XMLDOMDocumentEvents This);

    /// Return Type: HRESULT->LONG->int
    ///This: XMLDOMDocumentEvents*
    ///riid: IID*
    ///ppvObject: void**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int XMLDOMDocumentEventsVtbl_QueryInterface(ref XMLDOMDocumentEvents This, ref GUID riid, ref IntPtr ppvObject);

    /// Return Type: HRESULT->LONG->int
    ///This: XMLDOMDocumentEvents*
    ///dispIdMember: DISPID->LONG->int
    ///riid: IID*
    ///lcid: LCID->DWORD->unsigned int
    ///wFlags: WORD->unsigned short
    ///pDispParams: DISPPARAMS*
    ///pVarResult: VARIANT*
    ///pExcepInfo: EXCEPINFO*
    ///puArgErr: UINT*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int XMLDOMDocumentEventsVtbl_Invoke(ref XMLDOMDocumentEvents This, int dispIdMember, ref GUID riid, uint lcid, ushort wFlags, ref tagDISPPARAMS pDispParams, ref tagVARIANT pVarResult, ref tagEXCEPINFO pExcepInfo, ref uint puArgErr);

    /// Return Type: HRESULT->LONG->int
    ///This: XMLDOMDocumentEvents*
    ///pctinfo: UINT*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int XMLDOMDocumentEventsVtbl_GetTypeInfoCount(ref XMLDOMDocumentEvents This, ref uint pctinfo);

    /// Return Type: HRESULT->LONG->int
    ///This: XMLDOMDocumentEvents*
    ///iTInfo: UINT->unsigned int
    ///lcid: LCID->DWORD->unsigned int
    ///ppTInfo: ITypeInfo**
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int XMLDOMDocumentEventsVtbl_GetTypeInfo(ref XMLDOMDocumentEvents This, uint iTInfo, uint lcid, ref IntPtr ppTInfo);

    /// Return Type: HRESULT->LONG->int
    ///This: XMLDOMDocumentEvents*
    ///riid: IID*
    ///rgszNames: LPOLESTR*
    ///cNames: UINT->unsigned int
    ///lcid: LCID->DWORD->unsigned int
    ///rgDispId: DISPID*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int XMLDOMDocumentEventsVtbl_GetIDsOfNames(ref XMLDOMDocumentEvents This, ref GUID riid, ref IntPtr rgszNames, uint cNames, uint lcid, ref int rgDispId);

    /// Return Type: ULONG->unsigned int
    ///This: XMLDOMDocumentEvents*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint XMLDOMDocumentEventsVtbl_AddRef(ref XMLDOMDocumentEvents This);

    [StructLayout(LayoutKind.Sequential)]
    public struct XMLDOMDocumentEventsVtbl
    {

        /// XMLDOMDocumentEventsVtbl_QueryInterface
        public XMLDOMDocumentEventsVtbl_QueryInterface AnonymousMember1;

        /// XMLDOMDocumentEventsVtbl_AddRef
        public XMLDOMDocumentEventsVtbl_AddRef AnonymousMember2;

        /// XMLDOMDocumentEventsVtbl_Release
        public XMLDOMDocumentEventsVtbl_Release AnonymousMember3;

        /// XMLDOMDocumentEventsVtbl_GetTypeInfoCount
        public XMLDOMDocumentEventsVtbl_GetTypeInfoCount AnonymousMember4;

        /// XMLDOMDocumentEventsVtbl_GetTypeInfo
        public XMLDOMDocumentEventsVtbl_GetTypeInfo AnonymousMember5;

        /// XMLDOMDocumentEventsVtbl_GetIDsOfNames
        public XMLDOMDocumentEventsVtbl_GetIDsOfNames AnonymousMember6;

        /// XMLDOMDocumentEventsVtbl_Invoke
        public XMLDOMDocumentEventsVtbl_Invoke AnonymousMember7;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XMLDOMDocumentEvents
    {

        /// XMLDOMDocumentEventsVtbl*
        public IntPtr lpVtbl;
    }

    /// Return Type: void
    ///param0: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void XMIT_HELPER_ROUTINE(ref MIDL_STUB_MESSAGE param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct XML_ERROR
    {

        /// unsigned int
        public uint _nLine;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string _pchBuf;

        /// unsigned int
        public uint _cchBuf;

        /// unsigned int
        public uint _ich;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string _pszFound;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string _pszExpected;

        /// DWORD->unsigned int
        public uint _reserved1;

        /// DWORD->unsigned int
        public uint _reserved2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XMIT_ROUTINE_QUINTUPLE
    {

        /// XMIT_HELPER_ROUTINE
        public XMIT_HELPER_ROUTINE pfnTranslateToXmit;

        /// XMIT_HELPER_ROUTINE
        public XMIT_HELPER_ROUTINE pfnTranslateFromXmit;

        /// XMIT_HELPER_ROUTINE
        public XMIT_HELPER_ROUTINE pfnFreeXmit;

        /// XMIT_HELPER_ROUTINE
        public XMIT_HELPER_ROUTINE pfnFreeInst;
    }

    public enum XLAT_SIDE
    {

        /// XLAT_SERVER -> 1
        XLAT_SERVER = 1,

        XLAT_CLIENT,
    }

}
