using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    public enum @__MIDL___MIDL_itf_objidl_0055_0002
    {

        /// SERVER_LOCALITY_PROCESS_LOCAL -> 0
        SERVER_LOCALITY_PROCESS_LOCAL = 0,

        /// SERVER_LOCALITY_MACHINE_LOCAL -> 1
        SERVER_LOCALITY_MACHINE_LOCAL = 1,

        /// SERVER_LOCALITY_REMOTE -> 2
        SERVER_LOCALITY_REMOTE = 2,
    }

    public enum @__MIDL___MIDL_itf_objidl_0055_0001
    {

        /// COMBND_RPCTIMEOUT -> 0x1
        COMBND_RPCTIMEOUT = 1,

        /// COMBND_SERVER_LOCALITY -> 0x2
        COMBND_SERVER_LOCALITY = 2,
    }

    public enum @__MIDL_IInternetZoneManager_0001
    {

        /// MAX_ZONE_PATH -> 260
        MAX_ZONE_PATH = 260,

        /// MAX_ZONE_DESCRIPTION -> 200
        MAX_ZONE_DESCRIPTION = 200,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct _wireVARIANT
    {

        /// DWORD->unsigned int
        public uint clSize;

        /// DWORD->unsigned int
        public uint rpcReserved;

        /// USHORT->unsigned short
        public ushort vt;

        /// USHORT->unsigned short
        public ushort wReserved1;

        /// USHORT->unsigned short
        public ushort wReserved2;

        /// USHORT->unsigned short
        public ushort wReserved3;

        /// Anonymous_bd348551_10f9_42f6_b86b_1318bd5c6172
        public Anonymous_bd348551_10f9_42f6_b86b_1318bd5c6172 Union1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _wireSAFEARRAY_UNION___MIDL_IOleAutomationTypes_0001
    {

        /// SAFEARR_BSTR->_wireSAFEARR_BSTR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SAFEARR_BSTR BstrStr;

        /// SAFEARR_UNKNOWN->_wireSAFEARR_UNKNOWN
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SAFEARR_UNKNOWN UnknownStr;

        /// SAFEARR_DISPATCH->_wireSAFEARR_DISPATCH
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SAFEARR_DISPATCH DispatchStr;

        /// SAFEARR_VARIANT->_wireSAFEARR_VARIANT
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SAFEARR_VARIANT VariantStr;

        /// SAFEARR_BRECORD->_wireSAFEARR_BRECORD
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SAFEARR_BRECORD RecordStr;

        /// SAFEARR_HAVEIID->_wireSAFEARR_HAVEIID
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public SAFEARR_HAVEIID HaveIidStr;

        /// BYTE_SIZEDARR->_BYTE_SIZEDARR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public BYTE_SIZEDARR ByteStr;

        /// WORD_SIZEDARR->_SHORT_SIZEDARR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public WORD_SIZEDARR WordStr;

        /// DWORD_SIZEDARR->_LONG_SIZEDARR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public DWORD_SIZEDARR LongStr;

        /// HYPER_SIZEDARR->_HYPER_SIZEDARR
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public HYPER_SIZEDARR HyperStr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct _wireSAFEARRAY
    {

        /// USHORT->unsigned short
        public ushort cDims;

        /// USHORT->unsigned short
        public ushort fFeatures;

        /// ULONG->unsigned int
        public uint cbElements;

        /// ULONG->unsigned int
        public uint cLocks;

        /// SAFEARRAYUNION->_wireSAFEARRAY_UNION
        public SAFEARRAYUNION uArrayStructs;

        /// SAFEARRAYBOUND[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagSAFEARRAYBOUND[] rgsabound;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct _wireBRECORD
    {

        /// ULONG->unsigned int
        public uint fFlags;

        /// ULONG->unsigned int
        public uint clSize;

        /// IRecordInfo*
        public IntPtr pRecInfo;

        /// byte*
        public IntPtr pRecord;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _userSTGMEDIUM__STGMEDIUM_UNION___MIDL_IAdviseSink_0003
    {

        /// wireHMETAFILEPICT->userHMETAFILEPICT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hMetaFilePict;

        /// wireHENHMETAFILE->userHENHMETAFILE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hHEnhMetaFile;

        /// GDI_OBJECT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hGdiHandle;

        /// wireHGLOBAL->userHGLOBAL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hGlobal;

        /// LPOLESTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lpszFileName;

        /// BYTE_BLOB*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pstm;

        /// BYTE_BLOB*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pstg;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct _userSTGMEDIUM__STGMEDIUM_UNION
    {

        /// DWORD->unsigned int
        public uint tymed;

        /// _userSTGMEDIUM__STGMEDIUM_UNION___MIDL_IAdviseSink_0003
        public _userSTGMEDIUM__STGMEDIUM_UNION___MIDL_IAdviseSink_0003 Union1;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _userHPALETTE___MIDL_IWinTypes_0008
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// LOGPALETTE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hRemote;

        /// __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long hInproc64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _userHMETAFILE___MIDL_IWinTypes_0004
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// BYTE_BLOB*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hRemote;

        /// __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long hInproc64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _userHMETAFILEPICT___MIDL_IWinTypes_0005
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// remoteMETAFILEPICT*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hRemote;

        /// __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long hInproc64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _userHGLOBAL___MIDL_IWinTypes_0003
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// FLAGGED_BYTE_BLOB*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hRemote;

        /// __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long hInproc64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _userHENHMETAFILE___MIDL_IWinTypes_0006
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// BYTE_BLOB*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hRemote;

        /// __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long hInproc64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _userHBITMAP___MIDL_IWinTypes_0007
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// userBITMAP*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hRemote;

        /// __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long hInproc64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _RemotableHandle___MIDL_IWinTypes_0009
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hRemote;
    }

    /// Return Type: void
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _purecall_handler();

    /// Return Type: int
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int _onexit_t();

    /// Return Type: DWORD->unsigned int
    ///param0: LPOLESTREAM->_OLESTREAM*
    ///param1: void*
    ///param2: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint _OLESTREAMVTBL_Put(ref OLESTREAM param0, IntPtr param1, uint param2);

    /// Return Type: DWORD->unsigned int
    ///param0: LPOLESTREAM->_OLESTREAM*
    ///param1: void*
    ///param2: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint _OLESTREAMVTBL_Get(ref OLESTREAM param0, IntPtr param1, uint param2);

    /// Return Type: void
    ///param0: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _NDR_USER_MARSHAL_INFO_LEVEL1_pfnFree(IntPtr param0);

    /// Return Type: void*
    ///param0: size_t->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr _NDR_USER_MARSHAL_INFO_LEVEL1_pfnAllocate(IntPtr param0);

    /// Return Type: void
    ///param0: _NCB*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _NCB_ncb_post(ref NCB param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct _MIDL_SYNTAX_INFO
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

    /// Return Type: void
    ///param0: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _MIDL_STUB_MESSAGE_pfnFree(IntPtr param0);

    /// Return Type: void*
    ///param0: size_t->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr _MIDL_STUB_MESSAGE_pfnAllocate(IntPtr param0);

    /// Return Type: void
    ///param0: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _MIDL_STUB_DESC_pfnFree(IntPtr param0);

    /// Return Type: void*
    ///param0: size_t->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr _MIDL_STUB_DESC_pfnAllocate(IntPtr param0);

    /// Return Type: void
    ///param0: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void _MALLOC_FREE_STRUCT_pfnFree(IntPtr param0);

    /// Return Type: void*
    ///param0: size_t->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr _MALLOC_FREE_STRUCT_pfnAllocate(IntPtr param0);

    /// Return Type: void
    ///param0: wchar_t*
    ///param1: wchar_t*
    ///param2: wchar_t*
    ///param3: unsigned int
    ///param4: uintptr_t->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _invalid_parameter_handler([In] [MarshalAs(UnmanagedType.LPWStr)] string param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, [In] [MarshalAs(UnmanagedType.LPWStr)] string param2, uint param3, uint param4);

    [StructLayout(LayoutKind.Explicit)]
    public struct _GDI_OBJECT___MIDL_IAdviseSink_0002
    {

        /// wireHBITMAP->userHBITMAP*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hBitmap;

        /// wireHPALETTE->userHPALETTE*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hPalette;

        /// wireHGLOBAL->userHGLOBAL*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hGeneric;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct _GDI_NONREMOTE___MIDL_IWinTypes_0002
    {

        /// int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;

        /// DWORD_BLOB*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr hRemote;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct _CMSG_RECIPIENT_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint dwRecipientChoice;

        /// Anonymous_9ca4478c_b7fb_4748_b3ff_66088946049b
        public Anonymous_9ca4478c_b7fb_4748_b3ff_66088946049b Union1;
    }

}
