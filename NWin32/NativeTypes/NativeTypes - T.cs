using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tWAVEFORMATEX
    {

        /// WORD->unsigned short
        public ushort wFormatTag;

        /// WORD->unsigned short
        public ushort nChannels;

        /// DWORD->unsigned int
        public uint nSamplesPerSec;

        /// DWORD->unsigned int
        public uint nAvgBytesPerSec;

        /// WORD->unsigned short
        public ushort nBlockAlign;

        /// WORD->unsigned short
        public ushort wBitsPerSample;

        /// WORD->unsigned short
        public ushort cbSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tMIXERCONTROLDETAILS_UNSIGNED
    {

        /// DWORD->unsigned int
        public uint dwValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tMIXERCONTROLDETAILS_SIGNED
    {

        /// LONG->int
        public int lValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tMIXERCONTROLDETAILS_BOOLEAN
    {

        /// LONG->int
        public int fValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tMIXERCONTROLDETAILS
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwControlID;

        /// DWORD->unsigned int
        public uint cChannels;

        /// Anonymous_8fed292e_f8eb_47d1_9d92_4d13c62e2af6
        public Anonymous_8fed292e_f8eb_47d1_9d92_4d13c62e2af6 Union1;

        /// DWORD->unsigned int
        public uint cbDetails;

        /// LPVOID->void*
        public IntPtr paDetails;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct timeval
    {

        /// int
        public int tv_sec;

        /// int
        public int tv_usec;
    }

    /// Return Type: void
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: UINT_PTR->unsigned int
    ///param3: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void TIMERPROC(IntPtr param0, uint param1, IntPtr param2, uint param3);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int TIMEFMT_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int TIMEFMT_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct timecaps_tag
    {

        /// UINT->unsigned int
        public uint wPeriodMin;

        /// UINT->unsigned int
        public uint wPeriodMax;
    }

    /// Return Type: void
    ///uTimerID: UINT->unsigned int
    ///uMsg: UINT->unsigned int
    ///dwUser: DWORD_PTR->ULONG_PTR->unsigned int
    ///dw1: DWORD_PTR->ULONG_PTR->unsigned int
    ///dw2: DWORD_PTR->ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void TIMECALLBACK(uint uTimerID, uint uMsg, uint dwUser, uint dw1, uint dw2);

    [StructLayout(LayoutKind.Sequential)]
    public struct threadlocaleinfostruct
    {

        /// int
        public int refcount;

        /// unsigned int
        public uint lc_codepage;

        /// unsigned int
        public uint lc_collate_cp;

        /// unsigned int[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
        public uint[] lc_handle;

        /// LC_ID[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
        public tagLC_ID[] lc_id;

        /// Anonymous_09d5703c_909d_49c4_b6db_fb280d26bdf1[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
        public Anonymous_09d5703c_909d_49c4_b6db_fb280d26bdf1[] lc_category;

        /// int
        public int lc_clike;

        /// int
        public int mb_cur_max;

        /// int*
        public IntPtr lconv_intl_refcount;

        /// int*
        public IntPtr lconv_num_refcount;

        /// int*
        public IntPtr lconv_mon_refcount;

        /// lconv*
        public IntPtr lconv;

        /// int*
        public IntPtr ctype1_refcount;

        /// unsigned short*
        public IntPtr ctype1;

        /// short*
        public IntPtr pctype;

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pclmap;

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pcumap;

        /// __lc_time_data*
        public IntPtr lc_time_curr;
    }

    public enum tagXMLEMEM_TYPE
    {

        /// XMLELEMTYPE_ELEMENT -> 0
        XMLELEMTYPE_ELEMENT = 0,

        /// XMLELEMTYPE_TEXT -> XMLELEMTYPE_ELEMENT+1
        XMLELEMTYPE_TEXT = (tagXMLEMEM_TYPE.XMLELEMTYPE_ELEMENT + 1),

        /// XMLELEMTYPE_COMMENT -> XMLELEMTYPE_TEXT+1
        XMLELEMTYPE_COMMENT = (tagXMLEMEM_TYPE.XMLELEMTYPE_TEXT + 1),

        /// XMLELEMTYPE_DOCUMENT -> XMLELEMTYPE_COMMENT+1
        XMLELEMTYPE_DOCUMENT = (tagXMLEMEM_TYPE.XMLELEMTYPE_COMMENT + 1),

        /// XMLELEMTYPE_DTD -> XMLELEMTYPE_DOCUMENT+1
        XMLELEMTYPE_DTD = (tagXMLEMEM_TYPE.XMLELEMTYPE_DOCUMENT + 1),

        /// XMLELEMTYPE_PI -> XMLELEMTYPE_DTD+1
        XMLELEMTYPE_PI = (tagXMLEMEM_TYPE.XMLELEMTYPE_DTD + 1),

        /// XMLELEMTYPE_OTHER -> XMLELEMTYPE_PI+1
        XMLELEMTYPE_OTHER = (tagXMLEMEM_TYPE.XMLELEMTYPE_PI + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagXFORM
    {

        /// FLOAT->float
        public float eM11;

        /// FLOAT->float
        public float eM12;

        /// FLOAT->float
        public float eM21;

        /// FLOAT->float
        public float eM22;

        /// FLOAT->float
        public float eDx;

        /// FLOAT->float
        public float eDy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWTSSESSION_NOTIFICATION
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwSessionId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWNDCLASSW
    {

        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

        /// int
        public int cbClsExtra;

        /// int
        public int cbWndExtra;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// HCURSOR->HICON->HICON__*
        public IntPtr hCursor;

        /// HBRUSH->HBRUSH__*
        public IntPtr hbrBackground;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszMenuName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszClassName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWNDCLASSEXW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

        /// int
        public int cbClsExtra;

        /// int
        public int cbWndExtra;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// HCURSOR->HICON->HICON__*
        public IntPtr hCursor;

        /// HBRUSH->HBRUSH__*
        public IntPtr hbrBackground;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszMenuName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszClassName;

        /// HICON->HICON__*
        public IntPtr hIconSm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWNDCLASSEXA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

        /// int
        public int cbClsExtra;

        /// int
        public int cbWndExtra;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// HCURSOR->HICON->HICON__*
        public IntPtr hCursor;

        /// HBRUSH->HBRUSH__*
        public IntPtr hbrBackground;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszMenuName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszClassName;

        /// HICON->HICON__*
        public IntPtr hIconSm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWNDCLASSA
    {

        /// UINT->unsigned int
        public uint style;

        /// WNDPROC
        public WNDPROC lpfnWndProc;

        /// int
        public int cbClsExtra;

        /// int
        public int cbWndExtra;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// HCURSOR->HICON->HICON__*
        public IntPtr hCursor;

        /// HBRUSH->HBRUSH__*
        public IntPtr hbrBackground;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszMenuName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszClassName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWINDOWPOS
    {

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// HWND->HWND__*
        public IntPtr hwndInsertAfter;

        /// int
        public int x;

        /// int
        public int y;

        /// int
        public int cx;

        /// int
        public int cy;

        /// UINT->unsigned int
        public uint flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWINDOWPLACEMENT
    {

        /// UINT->unsigned int
        public uint length;

        /// UINT->unsigned int
        public uint flags;

        /// UINT->unsigned int
        public uint showCmd;

        /// POINT->tagPOINT
        public Point ptMinPosition;

        /// POINT->tagPOINT
        public Point ptMaxPosition;

        /// RECT->tagRECT
        public tagRECT rcNormalPosition;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWINDOWINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// RECT->tagRECT
        public tagRECT rcWindow;

        /// RECT->tagRECT
        public tagRECT rcClient;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// DWORD->unsigned int
        public uint dwExStyle;

        /// DWORD->unsigned int
        public uint dwWindowStatus;

        /// UINT->unsigned int
        public uint cxWindowBorders;

        /// UINT->unsigned int
        public uint cyWindowBorders;

        /// ATOM->WORD->unsigned short
        public ushort atomWindowType;

        /// WORD->unsigned short
        public ushort wCreatorVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagWCRANGE
    {

        /// WCHAR->wchar_t->unsigned short
        public ushort wcLow;

        /// USHORT->unsigned short
        public ushort cGlyphs;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagWAVEOUTCAPSW
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagWAVEOUTCAPSA
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagWAVEOUTCAPS2W
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagWAVEOUTCAPS2A
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagWAVEINCAPSW
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagWAVEINCAPSA
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagWAVEINCAPS2W
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagWAVEINCAPS2A
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwFormats;

        /// WORD->unsigned short
        public ushort wChannels;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagVS_FIXEDFILEINFO
    {

        /// DWORD->unsigned int
        public uint dwSignature;

        /// DWORD->unsigned int
        public uint dwStrucVersion;

        /// DWORD->unsigned int
        public uint dwFileVersionMS;

        /// DWORD->unsigned int
        public uint dwFileVersionLS;

        /// DWORD->unsigned int
        public uint dwProductVersionMS;

        /// DWORD->unsigned int
        public uint dwProductVersionLS;

        /// DWORD->unsigned int
        public uint dwFileFlagsMask;

        /// DWORD->unsigned int
        public uint dwFileFlags;

        /// DWORD->unsigned int
        public uint dwFileOS;

        /// DWORD->unsigned int
        public uint dwFileType;

        /// DWORD->unsigned int
        public uint dwFileSubtype;

        /// DWORD->unsigned int
        public uint dwFileDateMS;

        /// DWORD->unsigned int
        public uint dwFileDateLS;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagVersionedStream
    {

        /// GUID->_GUID
        public GUID guidVersion;

        /// IStream*
        public IntPtr pStream;
    }

    public enum tagVARKIND
    {

        /// VAR_PERINSTANCE -> 0
        VAR_PERINSTANCE = 0,

        /// VAR_STATIC -> VAR_PERINSTANCE+1
        VAR_STATIC = (tagVARKIND.VAR_PERINSTANCE + 1),

        /// VAR_CONST -> VAR_STATIC+1
        VAR_CONST = (tagVARKIND.VAR_STATIC + 1),

        /// VAR_DISPATCH -> VAR_CONST+1
        VAR_DISPATCH = (tagVARKIND.VAR_CONST + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagVARIANT
    {

        /// Anonymous_525db7aa_e002_4f41_a515_7d138d82263e
        public Anonymous_525db7aa_e002_4f41_a515_7d138d82263e n1;
    }

    public enum tagVARFLAGS
    {

        /// VARFLAG_FREADONLY -> 0x1
        VARFLAG_FREADONLY = 1,

        /// VARFLAG_FSOURCE -> 0x2
        VARFLAG_FSOURCE = 2,

        /// VARFLAG_FBINDABLE -> 0x4
        VARFLAG_FBINDABLE = 4,

        /// VARFLAG_FREQUESTEDIT -> 0x8
        VARFLAG_FREQUESTEDIT = 8,

        /// VARFLAG_FDISPLAYBIND -> 0x10
        VARFLAG_FDISPLAYBIND = 16,

        /// VARFLAG_FDEFAULTBIND -> 0x20
        VARFLAG_FDEFAULTBIND = 32,

        /// VARFLAG_FHIDDEN -> 0x40
        VARFLAG_FHIDDEN = 64,

        /// VARFLAG_FRESTRICTED -> 0x80
        VARFLAG_FRESTRICTED = 128,

        /// VARFLAG_FDEFAULTCOLLELEM -> 0x100
        VARFLAG_FDEFAULTCOLLELEM = 256,

        /// VARFLAG_FUIDEFAULT -> 0x200
        VARFLAG_FUIDEFAULT = 512,

        /// VARFLAG_FNONBROWSABLE -> 0x400
        VARFLAG_FNONBROWSABLE = 1024,

        /// VARFLAG_FREPLACEABLE -> 0x800
        VARFLAG_FREPLACEABLE = 2048,

        /// VARFLAG_FIMMEDIATEBIND -> 0x1000
        VARFLAG_FIMMEDIATEBIND = 4096,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagVARDESC
    {

        /// MEMBERID->DISPID->LONG->int
        public int memid;

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrSchema;

        /// Anonymous_62e38fe9_336a_4989_8fc3_091f25ee1b7d
        public Anonymous_62e38fe9_336a_4989_8fc3_091f25ee1b7d Union1;

        /// ELEMDESC->tagELEMDESC
        public tagELEMDESC elemdescVar;

        /// WORD->unsigned short
        public ushort wVarFlags;

        /// VARKIND->tagVARKIND
        public tagVARKIND varkind;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagUSEROBJECTFLAGS
    {

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fInherit;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fReserved;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    public enum tagUSERCLASSTYPE
    {

        /// USERCLASSTYPE_FULL -> 1
        USERCLASSTYPE_FULL = 1,

        /// USERCLASSTYPE_SHORT -> 2
        USERCLASSTYPE_SHORT = 2,

        /// USERCLASSTYPE_APPNAME -> 3
        USERCLASSTYPE_APPNAME = 3,
    }

    public enum tagURLZONE
    {

        /// URLZONE_PREDEFINED_MIN -> 0
        URLZONE_PREDEFINED_MIN = 0,

        /// URLZONE_LOCAL_MACHINE -> 0
        URLZONE_LOCAL_MACHINE = 0,

        /// URLZONE_INTRANET -> URLZONE_LOCAL_MACHINE+1
        URLZONE_INTRANET = (tagURLZONE.URLZONE_LOCAL_MACHINE + 1),

        /// URLZONE_TRUSTED -> URLZONE_INTRANET+1
        URLZONE_TRUSTED = (tagURLZONE.URLZONE_INTRANET + 1),

        /// URLZONE_INTERNET -> URLZONE_TRUSTED+1
        URLZONE_INTERNET = (tagURLZONE.URLZONE_TRUSTED + 1),

        /// URLZONE_UNTRUSTED -> URLZONE_INTERNET+1
        URLZONE_UNTRUSTED = (tagURLZONE.URLZONE_INTERNET + 1),

        /// URLZONE_PREDEFINED_MAX -> 999
        URLZONE_PREDEFINED_MAX = 999,

        /// URLZONE_USER_MIN -> 1000
        URLZONE_USER_MIN = 1000,

        /// URLZONE_USER_MAX -> 10000
        URLZONE_USER_MAX = 10000,
    }

    public enum tagURLTEMPLATE
    {

        /// URLTEMPLATE_CUSTOM -> 0
        URLTEMPLATE_CUSTOM = 0,

        /// URLTEMPLATE_PREDEFINED_MIN -> 0x10000
        URLTEMPLATE_PREDEFINED_MIN = 65536,

        /// URLTEMPLATE_LOW -> 0x10000
        URLTEMPLATE_LOW = 65536,

        /// URLTEMPLATE_MEDLOW -> 0x10500
        URLTEMPLATE_MEDLOW = 66816,

        /// URLTEMPLATE_MEDIUM -> 0x11000
        URLTEMPLATE_MEDIUM = 69632,

        /// URLTEMPLATE_HIGH -> 0x12000
        URLTEMPLATE_HIGH = 73728,

        /// URLTEMPLATE_PREDEFINED_MAX -> 0x20000
        URLTEMPLATE_PREDEFINED_MAX = 131072,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagUPDATELAYEREDWINDOWINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HDC->HDC__*
        public IntPtr hdcDst;

        /// POINT*
        public IntPtr pptDst;

        /// SIZE*
        public IntPtr psize;

        /// HDC->HDC__*
        public IntPtr hdcSrc;

        /// POINT*
        public IntPtr pptSrc;

        /// COLORREF->DWORD->unsigned int
        public uint crKey;

        /// BLENDFUNCTION*
        public IntPtr pblend;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// RECT*
        public IntPtr prcDirty;
    }

    public enum tagTYSPEC
    {

        /// TYSPEC_CLSID -> 0
        TYSPEC_CLSID = 0,

        /// TYSPEC_FILEEXT -> TYSPEC_CLSID+1
        TYSPEC_FILEEXT = (tagTYSPEC.TYSPEC_CLSID + 1),

        /// TYSPEC_MIMETYPE -> TYSPEC_FILEEXT+1
        TYSPEC_MIMETYPE = (tagTYSPEC.TYSPEC_FILEEXT + 1),

        /// TYSPEC_FILENAME -> TYSPEC_MIMETYPE+1
        TYSPEC_FILENAME = (tagTYSPEC.TYSPEC_MIMETYPE + 1),

        /// TYSPEC_PROGID -> TYSPEC_FILENAME+1
        TYSPEC_PROGID = (tagTYSPEC.TYSPEC_FILENAME + 1),

        /// TYSPEC_PACKAGENAME -> TYSPEC_PROGID+1
        TYSPEC_PACKAGENAME = (tagTYSPEC.TYSPEC_PROGID + 1),

        /// TYSPEC_OBJECTID -> TYSPEC_PACKAGENAME+1
        TYSPEC_OBJECTID = (tagTYSPEC.TYSPEC_PACKAGENAME + 1),
    }

    public enum tagTYPEKIND
    {

        /// TKIND_ENUM -> 0
        TKIND_ENUM = 0,

        /// TKIND_RECORD -> TKIND_ENUM+1
        TKIND_RECORD = (tagTYPEKIND.TKIND_ENUM + 1),

        /// TKIND_MODULE -> TKIND_RECORD+1
        TKIND_MODULE = (tagTYPEKIND.TKIND_RECORD + 1),

        /// TKIND_INTERFACE -> TKIND_MODULE+1
        TKIND_INTERFACE = (tagTYPEKIND.TKIND_MODULE + 1),

        /// TKIND_DISPATCH -> TKIND_INTERFACE+1
        TKIND_DISPATCH = (tagTYPEKIND.TKIND_INTERFACE + 1),

        /// TKIND_COCLASS -> TKIND_DISPATCH+1
        TKIND_COCLASS = (tagTYPEKIND.TKIND_DISPATCH + 1),

        /// TKIND_ALIAS -> TKIND_COCLASS+1
        TKIND_ALIAS = (tagTYPEKIND.TKIND_COCLASS + 1),

        /// TKIND_UNION -> TKIND_ALIAS+1
        TKIND_UNION = (tagTYPEKIND.TKIND_ALIAS + 1),

        /// TKIND_MAX -> TKIND_UNION+1
        TKIND_MAX = (tagTYPEKIND.TKIND_UNION + 1),
    }

    public enum tagTYPEFLAGS
    {

        /// TYPEFLAG_FAPPOBJECT -> 0x1
        TYPEFLAG_FAPPOBJECT = 1,

        /// TYPEFLAG_FCANCREATE -> 0x2
        TYPEFLAG_FCANCREATE = 2,

        /// TYPEFLAG_FLICENSED -> 0x4
        TYPEFLAG_FLICENSED = 4,

        /// TYPEFLAG_FPREDECLID -> 0x8
        TYPEFLAG_FPREDECLID = 8,

        /// TYPEFLAG_FHIDDEN -> 0x10
        TYPEFLAG_FHIDDEN = 16,

        /// TYPEFLAG_FCONTROL -> 0x20
        TYPEFLAG_FCONTROL = 32,

        /// TYPEFLAG_FDUAL -> 0x40
        TYPEFLAG_FDUAL = 64,

        /// TYPEFLAG_FNONEXTENSIBLE -> 0x80
        TYPEFLAG_FNONEXTENSIBLE = 128,

        /// TYPEFLAG_FOLEAUTOMATION -> 0x100
        TYPEFLAG_FOLEAUTOMATION = 256,

        /// TYPEFLAG_FRESTRICTED -> 0x200
        TYPEFLAG_FRESTRICTED = 512,

        /// TYPEFLAG_FAGGREGATABLE -> 0x400
        TYPEFLAG_FAGGREGATABLE = 1024,

        /// TYPEFLAG_FREPLACEABLE -> 0x800
        TYPEFLAG_FREPLACEABLE = 2048,

        /// TYPEFLAG_FDISPATCHABLE -> 0x1000
        TYPEFLAG_FDISPATCHABLE = 4096,

        /// TYPEFLAG_FREVERSEBIND -> 0x2000
        TYPEFLAG_FREVERSEBIND = 8192,

        /// TYPEFLAG_FPROXY -> 0x4000
        TYPEFLAG_FPROXY = 16384,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTYPEDESC
    {

        /// Anonymous_999607ba_8a31_4480_af49_8774cb4f5bd6
        public Anonymous_999607ba_8a31_4480_af49_8774cb4f5bd6 Union1;

        /// VARTYPE->unsigned short
        public ushort vt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTYPEATTR
    {

        /// GUID->_GUID
        public GUID guid;

        /// LCID->DWORD->unsigned int
        public uint lcid;

        /// DWORD->unsigned int
        public uint dwReserved;

        /// MEMBERID->DISPID->LONG->int
        public int memidConstructor;

        /// MEMBERID->DISPID->LONG->int
        public int memidDestructor;

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrSchema;

        /// ULONG->unsigned int
        public uint cbSizeInstance;

        /// TYPEKIND->tagTYPEKIND
        public tagTYPEKIND typekind;

        /// WORD->unsigned short
        public ushort cFuncs;

        /// WORD->unsigned short
        public ushort cVars;

        /// WORD->unsigned short
        public ushort cImplTypes;

        /// WORD->unsigned short
        public ushort cbSizeVft;

        /// WORD->unsigned short
        public ushort cbAlignment;

        /// WORD->unsigned short
        public ushort wTypeFlags;

        /// WORD->unsigned short
        public ushort wMajorVerNum;

        /// WORD->unsigned short
        public ushort wMinorVerNum;

        /// TYPEDESC->tagTYPEDESC
        public tagTYPEDESC tdescAlias;

        /// IDLDESC->tagIDLDESC
        public tagIDLDESC idldescType;
    }

    public enum tagTYMED
    {

        /// TYMED_HGLOBAL -> 1
        TYMED_HGLOBAL = 1,

        /// TYMED_FILE -> 2
        TYMED_FILE = 2,

        /// TYMED_ISTREAM -> 4
        TYMED_ISTREAM = 4,

        /// TYMED_ISTORAGE -> 8
        TYMED_ISTORAGE = 8,

        /// TYMED_GDI -> 16
        TYMED_GDI = 16,

        /// TYMED_MFPICT -> 32
        TYMED_MFPICT = 32,

        /// TYMED_ENHMF -> 64
        TYMED_ENHMF = 64,

        /// TYMED_NULL -> 0
        TYMED_NULL = 0,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTTPOLYGONHEADER
    {

        /// DWORD->unsigned int
        public uint cb;

        /// DWORD->unsigned int
        public uint dwType;

        /// POINTFX->tagPOINTFX
        public tagPOINTFX pfxStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTTPOLYCURVE
    {

        /// WORD->unsigned short
        public ushort wType;

        /// WORD->unsigned short
        public ushort cpfx;

        /// POINTFX[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagPOINTFX[] apfx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTRACKMOUSEEVENT
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HWND->HWND__*
        public IntPtr hwndTrack;

        /// DWORD->unsigned int
        public uint dwHoverTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTPMPARAMS
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// RECT->tagRECT
        public tagRECT rcExclude;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTOGGLEKEYS
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTLIBATTR
    {

        /// GUID->_GUID
        public GUID guid;

        /// LCID->DWORD->unsigned int
        public uint lcid;

        /// SYSKIND->tagSYSKIND
        public tagSYSKIND syskind;

        /// WORD->unsigned short
        public ushort wMajorVerNum;

        /// WORD->unsigned short
        public ushort wMinorVerNum;

        /// WORD->unsigned short
        public ushort wLibFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTITLEBARINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// RECT->tagRECT
        public tagRECT rcTitleBar;

        /// DWORD[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
        public uint[] rgstate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTEXTMETRICW
    {

        /// LONG->int
        public int tmHeight;

        /// LONG->int
        public int tmAscent;

        /// LONG->int
        public int tmDescent;

        /// LONG->int
        public int tmInternalLeading;

        /// LONG->int
        public int tmExternalLeading;

        /// LONG->int
        public int tmAveCharWidth;

        /// LONG->int
        public int tmMaxCharWidth;

        /// LONG->int
        public int tmWeight;

        /// LONG->int
        public int tmOverhang;

        /// LONG->int
        public int tmDigitizedAspectX;

        /// LONG->int
        public int tmDigitizedAspectY;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmFirstChar;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmLastChar;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmDefaultChar;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmBreakChar;

        /// BYTE->unsigned char
        public byte tmItalic;

        /// BYTE->unsigned char
        public byte tmUnderlined;

        /// BYTE->unsigned char
        public byte tmStruckOut;

        /// BYTE->unsigned char
        public byte tmPitchAndFamily;

        /// BYTE->unsigned char
        public byte tmCharSet;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagTEXTMETRICA
    {

        /// LONG->int
        public int tmHeight;

        /// LONG->int
        public int tmAscent;

        /// LONG->int
        public int tmDescent;

        /// LONG->int
        public int tmInternalLeading;

        /// LONG->int
        public int tmExternalLeading;

        /// LONG->int
        public int tmAveCharWidth;

        /// LONG->int
        public int tmMaxCharWidth;

        /// LONG->int
        public int tmWeight;

        /// LONG->int
        public int tmOverhang;

        /// LONG->int
        public int tmDigitizedAspectX;

        /// LONG->int
        public int tmDigitizedAspectY;

        /// BYTE->unsigned char
        public byte tmFirstChar;

        /// BYTE->unsigned char
        public byte tmLastChar;

        /// BYTE->unsigned char
        public byte tmDefaultChar;

        /// BYTE->unsigned char
        public byte tmBreakChar;

        /// BYTE->unsigned char
        public byte tmItalic;

        /// BYTE->unsigned char
        public byte tmUnderlined;

        /// BYTE->unsigned char
        public byte tmStruckOut;

        /// BYTE->unsigned char
        public byte tmPitchAndFamily;

        /// BYTE->unsigned char
        public byte tmCharSet;
    }

    public enum tagSYSKIND
    {

        /// SYS_WIN16 -> 0
        SYS_WIN16 = 0,

        /// SYS_WIN32 -> SYS_WIN16+1
        SYS_WIN32 = (tagSYSKIND.SYS_WIN16 + 1),

        /// SYS_MAC -> SYS_WIN32+1
        SYS_MAC = (tagSYSKIND.SYS_WIN32 + 1),

        /// SYS_WIN64 -> SYS_MAC+1
        SYS_WIN64 = (tagSYSKIND.SYS_MAC + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTYLESTRUCT
    {

        /// DWORD->unsigned int
        public uint styleOld;

        /// DWORD->unsigned int
        public uint styleNew;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagSTYLEBUFW
    {

        /// DWORD->unsigned int
        public uint dwStyle;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDescription;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagSTYLEBUFA
    {

        /// DWORD->unsigned int
        public uint dwStyle;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDescription;
    }

    public enum tagSTREAM_SEEK
    {

        /// STREAM_SEEK_SET -> 0
        STREAM_SEEK_SET = 0,

        /// STREAM_SEEK_CUR -> 1
        STREAM_SEEK_CUR = 1,

        /// STREAM_SEEK_END -> 2
        STREAM_SEEK_END = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagStorageLayout
    {

        /// DWORD->unsigned int
        public uint LayoutType;

        /// OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsElementName;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER cOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER cBytes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTICKYKEYS
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    public enum tagSTGTY
    {

        /// STGTY_STORAGE -> 1
        STGTY_STORAGE = 1,

        /// STGTY_STREAM -> 2
        STGTY_STREAM = 2,

        /// STGTY_LOCKBYTES -> 3
        STGTY_LOCKBYTES = 3,

        /// STGTY_PROPERTY -> 4
        STGTY_PROPERTY = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTGOPTIONS
    {

        /// USHORT->unsigned short
        public ushort usVersion;

        /// USHORT->unsigned short
        public ushort reserved;

        /// ULONG->unsigned int
        public uint ulSectorSize;

        /// WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsTemplateFile;
    }

    public enum tagSTGMOVE
    {

        /// STGMOVE_MOVE -> 0
        STGMOVE_MOVE = 0,

        /// STGMOVE_COPY -> 1
        STGMOVE_COPY = 1,

        /// STGMOVE_SHALLOWCOPY -> 2
        STGMOVE_SHALLOWCOPY = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTGMEDIUM
    {

        /// DWORD->unsigned int
        public uint tymed;

        /// Anonymous_cb8be365_afe0_4064_8361_371c31b61c7a
        public Anonymous_cb8be365_afe0_4064_8361_371c31b61c7a Union1;

        /// IUnknown*
        public IntPtr pUnkForRelease;
    }

    public enum tagSTGC
    {

        /// STGC_DEFAULT -> 0
        STGC_DEFAULT = 0,

        /// STGC_OVERWRITE -> 1
        STGC_OVERWRITE = 1,

        /// STGC_ONLYIFCURRENT -> 2
        STGC_ONLYIFCURRENT = 2,

        /// STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE -> 4
        STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,

        /// STGC_CONSOLIDATE -> 8
        STGC_CONSOLIDATE = 8,
    }

    public enum tagSTDMSHLFLAGS
    {

        /// SMEXF_SERVER -> 0x01
        SMEXF_SERVER = 1,

        /// SMEXF_HANDLER -> 0x02
        SMEXF_HANDLER = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTATSTG
    {

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwcsName;

        /// DWORD->unsigned int
        public uint type;

        /// ULARGE_INTEGER->_ULARGE_INTEGER
        public ULARGE_INTEGER cbSize;

        /// FILETIME->_FILETIME
        public FILETIME mtime;

        /// FILETIME->_FILETIME
        public FILETIME ctime;

        /// FILETIME->_FILETIME
        public FILETIME atime;

        /// DWORD->unsigned int
        public uint grfMode;

        /// DWORD->unsigned int
        public uint grfLocksSupported;

        /// CLSID->GUID->_GUID
        public GUID clsid;

        /// DWORD->unsigned int
        public uint grfStateBits;

        /// DWORD->unsigned int
        public uint reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTATPROPSTG
    {

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpwstrName;

        /// PROPID->ULONG->unsigned int
        public uint propid;

        /// VARTYPE->unsigned short
        public ushort vt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTATPROPSETSTG
    {

        /// FMTID->GUID->_GUID
        public GUID fmtid;

        /// CLSID->GUID->_GUID
        public GUID clsid;

        /// DWORD->unsigned int
        public uint grfFlags;

        /// FILETIME->_FILETIME
        public FILETIME mtime;

        /// FILETIME->_FILETIME
        public FILETIME ctime;

        /// FILETIME->_FILETIME
        public FILETIME atime;

        /// DWORD->unsigned int
        public uint dwOSVersion;
    }

    public enum tagSTATFLAG
    {

        /// STATFLAG_DEFAULT -> 0
        STATFLAG_DEFAULT = 0,

        /// STATFLAG_NONAME -> 1
        STATFLAG_NONAME = 1,

        /// STATFLAG_NOOPEN -> 2
        STATFLAG_NOOPEN = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSTATDATA
    {

        /// FORMATETC->tagFORMATETC
        public tagFORMATETC formatetc;

        /// DWORD->unsigned int
        public uint advf;

        /// IAdviseSink*
        public IntPtr pAdvSink;

        /// DWORD->unsigned int
        public uint dwConnection;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOUNDSENTRYW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint iFSTextEffect;

        /// DWORD->unsigned int
        public uint iFSTextEffectMSec;

        /// DWORD->unsigned int
        public uint iFSTextEffectColorBits;

        /// DWORD->unsigned int
        public uint iFSGrafEffect;

        /// DWORD->unsigned int
        public uint iFSGrafEffectMSec;

        /// DWORD->unsigned int
        public uint iFSGrafEffectColor;

        /// DWORD->unsigned int
        public uint iWindowsEffect;

        /// DWORD->unsigned int
        public uint iWindowsEffectMSec;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszWindowsEffectDLL;

        /// DWORD->unsigned int
        public uint iWindowsEffectOrdinal;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOUNDSENTRYA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint iFSTextEffect;

        /// DWORD->unsigned int
        public uint iFSTextEffectMSec;

        /// DWORD->unsigned int
        public uint iFSTextEffectColorBits;

        /// DWORD->unsigned int
        public uint iFSGrafEffect;

        /// DWORD->unsigned int
        public uint iFSGrafEffectMSec;

        /// DWORD->unsigned int
        public uint iFSGrafEffectColor;

        /// DWORD->unsigned int
        public uint iWindowsEffect;

        /// DWORD->unsigned int
        public uint iWindowsEffectMSec;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszWindowsEffectDLL;

        /// DWORD->unsigned int
        public uint iWindowsEffectOrdinal;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOLE_AUTHENTICATION_SERVICE
    {

        /// DWORD->unsigned int
        public uint dwAuthnSvc;

        /// DWORD->unsigned int
        public uint dwAuthzSvc;

        /// OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrincipalName;

        /// HRESULT->LONG->int
        public int hr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOLE_AUTHENTICATION_LIST
    {

        /// DWORD->unsigned int
        public uint cAuthInfo;

        /// SOLE_AUTHENTICATION_INFO*
        public IntPtr aAuthInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOLE_AUTHENTICATION_INFO
    {

        /// DWORD->unsigned int
        public uint dwAuthnSvc;

        /// DWORD->unsigned int
        public uint dwAuthzSvc;

        /// void*
        public IntPtr pAuthInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSOleTlsDataPublic
    {

        /// void*[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] pvReserved0;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved0;

        /// void*[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] pvReserved1;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved1;

        /// void*[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] pvReserved2;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved2;

        /// void*
        public IntPtr pCurrentCtx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSIZE
    {

        /// LONG->int
        public int cx;

        /// LONG->int
        public int cy;
    }

    public enum tagShutdownType
    {

        /// IdleShutdown -> 0
        IdleShutdown = 0,

        /// ForcedShutdown -> IdleShutdown+1
        ForcedShutdown = (tagShutdownType.IdleShutdown + 1),
    }

    public enum tagSF_TYPE
    {

        /// SF_ERROR -> VT_ERROR
        SF_ERROR = VARENUM.VT_ERROR,

        /// SF_I1 -> VT_I1
        SF_I1 = VARENUM.VT_I1,

        /// SF_I2 -> VT_I2
        SF_I2 = VARENUM.VT_I2,

        /// SF_I4 -> VT_I4
        SF_I4 = VARENUM.VT_I4,

        /// SF_I8 -> VT_I8
        SF_I8 = VARENUM.VT_I8,

        /// SF_BSTR -> VT_BSTR
        SF_BSTR = VARENUM.VT_BSTR,

        /// SF_UNKNOWN -> VT_UNKNOWN
        SF_UNKNOWN = VARENUM.VT_UNKNOWN,

        /// SF_DISPATCH -> VT_DISPATCH
        SF_DISPATCH = VARENUM.VT_DISPATCH,

        /// SF_VARIANT -> VT_VARIANT
        SF_VARIANT = VARENUM.VT_VARIANT,

        /// SF_RECORD -> VT_RECORD
        SF_RECORD = VARENUM.VT_RECORD,

        /// SF_HAVEIID -> VT_UNKNOWN|VT_RESERVED
        SF_HAVEIID = (VARENUM.VT_UNKNOWN | VARENUM.VT_RESERVED),
    }

    public enum tagSERVERCALL
    {

        /// SERVERCALL_ISHANDLED -> 0
        SERVERCALL_ISHANDLED = 0,

        /// SERVERCALL_REJECTED -> 1
        SERVERCALL_REJECTED = 1,

        /// SERVERCALL_RETRYLATER -> 2
        SERVERCALL_RETRYLATER = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSERIALKEYSW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszActivePort;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszPort;

        /// UINT->unsigned int
        public uint iBaudRate;

        /// UINT->unsigned int
        public uint iPortState;

        /// UINT->unsigned int
        public uint iActive;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSERIALKEYSA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszActivePort;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszPort;

        /// UINT->unsigned int
        public uint iBaudRate;

        /// UINT->unsigned int
        public uint iPortState;

        /// UINT->unsigned int
        public uint iActive;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSCROLLINFO
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint fMask;

        /// int
        public int nMin;

        /// int
        public int nMax;

        /// UINT->unsigned int
        public uint nPage;

        /// int
        public int nPos;

        /// int
        public int nTrackPos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSCROLLBARINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// RECT->tagRECT
        public tagRECT rcScrollBar;

        /// int
        public int dxyLineButton;

        /// int
        public int xyThumbTop;

        /// int
        public int xyThumbBottom;

        /// int
        public int reserved;

        /// DWORD[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
        public uint[] rgstate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSAFEARRAYBOUND
    {

        /// ULONG->unsigned int
        public uint cElements;

        /// LONG->int
        public int lLbound;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagSAFEARRAY
    {

        /// USHORT->unsigned short
        public ushort cDims;

        /// USHORT->unsigned short
        public ushort fFeatures;

        /// ULONG->unsigned int
        public uint cbElements;

        /// ULONG->unsigned int
        public uint cLocks;

        /// PVOID->void*
        public IntPtr pvData;

        /// SAFEARRAYBOUND[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagSAFEARRAYBOUND[] rgsabound;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPC_EXTENDED_ERROR_INFO
    {

        /// ULONG->unsigned int
        public uint Version;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ComputerName;

        /// ULONG->unsigned int
        public uint ProcessID;

        /// Anonymous_07cb9bb0_963c_4d78_8963_ec574f75d3fc
        public Anonymous_07cb9bb0_963c_4d78_8963_ec574f75d3fc u;

        /// ULONG->unsigned int
        public uint GeneratingComponent;

        /// ULONG->unsigned int
        public uint Status;

        /// USHORT->unsigned short
        public ushort DetectionLocation;

        /// USHORT->unsigned short
        public ushort Flags;

        /// int
        public int NumberOfParameters;

        /// RPC_EE_INFO_PARAM[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
        public tagRPC_EE_INFO_PARAM[] Parameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPC_ERROR_ENUM_HANDLE
    {

        /// ULONG->unsigned int
        public uint Signature;

        /// void*
        public IntPtr CurrentPos;

        /// void*
        public IntPtr Head;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPC_EE_INFO_PARAM
    {

        /// ExtendedErrorParamTypes->tagExtendedErrorParamTypes
        public tagExtendedErrorParamTypes ParameterType;

        /// Anonymous_103794fb_1804_41f9_9e19_be8a73f304d1
        public Anonymous_103794fb_1804_41f9_9e19_be8a73f304d1 u;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPC_CALL_ATTRIBUTES_V1_W
    {

        /// unsigned int
        public uint Version;

        /// unsigned int
        public uint Flags;

        /// unsigned int
        public uint ServerPrincipalNameBufferLength;

        /// unsigned short*
        public IntPtr ServerPrincipalName;

        /// unsigned int
        public uint ClientPrincipalNameBufferLength;

        /// unsigned short*
        public IntPtr ClientPrincipalName;

        /// unsigned int
        public uint AuthenticationLevel;

        /// unsigned int
        public uint AuthenticationService;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool NullSession;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPC_CALL_ATTRIBUTES_V1_A
    {

        /// unsigned int
        public uint Version;

        /// unsigned int
        public uint Flags;

        /// unsigned int
        public uint ServerPrincipalNameBufferLength;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ServerPrincipalName;

        /// unsigned int
        public uint ClientPrincipalNameBufferLength;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ClientPrincipalName;

        /// unsigned int
        public uint AuthenticationLevel;

        /// unsigned int
        public uint AuthenticationService;

        /// BOOL->int
        public int NullSession;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRPCOLEMESSAGE
    {

        /// void*
        public IntPtr reserved1;

        /// RPCOLEDATAREP->unsigned int
        public uint dataRepresentation;

        /// void*
        public IntPtr Buffer;

        /// ULONG->unsigned int
        public uint cbBuffer;

        /// ULONG->unsigned int
        public uint iMethod;

        /// void*[5]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] reserved2;

        /// ULONG->unsigned int
        public uint rpcFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRID_DEVICE_INFO_MOUSE
    {

        /// DWORD->unsigned int
        public uint dwId;

        /// DWORD->unsigned int
        public uint dwNumberOfButtons;

        /// DWORD->unsigned int
        public uint dwSampleRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRID_DEVICE_INFO_KEYBOARD
    {

        /// DWORD->unsigned int
        public uint dwType;

        /// DWORD->unsigned int
        public uint dwSubType;

        /// DWORD->unsigned int
        public uint dwKeyboardMode;

        /// DWORD->unsigned int
        public uint dwNumberOfFunctionKeys;

        /// DWORD->unsigned int
        public uint dwNumberOfIndicators;

        /// DWORD->unsigned int
        public uint dwNumberOfKeysTotal;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRID_DEVICE_INFO_HID
    {

        /// DWORD->unsigned int
        public uint dwVendorId;

        /// DWORD->unsigned int
        public uint dwProductId;

        /// DWORD->unsigned int
        public uint dwVersionNumber;

        /// USHORT->unsigned short
        public ushort usUsagePage;

        /// USHORT->unsigned short
        public ushort usUsage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRID_DEVICE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwType;

        /// Anonymous_d4be8f65_6573_460f_bb31_85a2454b800d
        public Anonymous_d4be8f65_6573_460f_bb31_85a2454b800d Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRGBTRIPLE
    {

        /// BYTE->unsigned char
        public byte rgbtBlue;

        /// BYTE->unsigned char
        public byte rgbtGreen;

        /// BYTE->unsigned char
        public byte rgbtRed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRGBQUAD
    {

        /// BYTE->unsigned char
        public byte rgbBlue;

        /// BYTE->unsigned char
        public byte rgbGreen;

        /// BYTE->unsigned char
        public byte rgbRed;

        /// BYTE->unsigned char
        public byte rgbReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemSTGMEDIUM
    {

        /// DWORD->unsigned int
        public uint tymed;

        /// DWORD->unsigned int
        public uint dwHandleType;

        /// unsigned int
        public uint pData;

        /// unsigned int
        public uint pUnkForRelease;

        /// unsigned int
        public uint cbData;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] data;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagRemSNB
    {

        /// unsigned int
        public uint ulCntStr;

        /// unsigned int
        public uint ulCntChar;

        /// OLECHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string rgString;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemHPALETTE
    {

        /// unsigned int
        public uint cbData;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemHMETAFILEPICT
    {

        /// int
        public int mm;

        /// int
        public int xExt;

        /// int
        public int yExt;

        /// unsigned int
        public uint cbData;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemHGLOBAL
    {

        /// int
        public int fNullHGlobal;

        /// unsigned int
        public uint cbData;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemHENHMETAFILE
    {

        /// unsigned int
        public uint cbData;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemHBITMAP
    {

        /// unsigned int
        public uint cbData;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemFORMATETC
    {

        /// DWORD->unsigned int
        public uint cfFormat;

        /// DWORD->unsigned int
        public uint ptd;

        /// DWORD->unsigned int
        public uint dwAspect;

        /// LONG->int
        public int lindex;

        /// DWORD->unsigned int
        public uint tymed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRemBRUSH
    {

        /// unsigned int
        public uint cbData;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] data;
    }

    public enum tagREGKIND
    {

        REGKIND_DEFAULT,

        REGKIND_REGISTER,

        REGKIND_NONE,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagREGISTERWORDW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpReading;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpWord;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagREGISTERWORDA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpReading;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpWord;
    }

    public enum tagREGCLS
    {

        /// REGCLS_SINGLEUSE -> 0
        REGCLS_SINGLEUSE = 0,

        /// REGCLS_MULTIPLEUSE -> 1
        REGCLS_MULTIPLEUSE = 1,

        /// REGCLS_MULTI_SEPARATE -> 2
        REGCLS_MULTI_SEPARATE = 2,

        /// REGCLS_SUSPENDED -> 4
        REGCLS_SUSPENDED = 4,

        /// REGCLS_SURROGATE -> 8
        REGCLS_SURROGATE = 8,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRECT
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
    public struct tagRECONVERTSTRING
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwVersion;

        /// DWORD->unsigned int
        public uint dwStrLen;

        /// DWORD->unsigned int
        public uint dwStrOffset;

        /// DWORD->unsigned int
        public uint dwCompStrLen;

        /// DWORD->unsigned int
        public uint dwCompStrOffset;

        /// DWORD->unsigned int
        public uint dwTargetStrLen;

        /// DWORD->unsigned int
        public uint dwTargetStrOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRAWMOUSE
    {

        /// USHORT->unsigned short
        public ushort usFlags;

        /// Anonymous_4e912b36_f5ab_4eb4_804f_6587b7a78602
        public Anonymous_4e912b36_f5ab_4eb4_804f_6587b7a78602 Union1;

        /// ULONG->unsigned int
        public uint ulRawButtons;

        /// LONG->int
        public int lLastX;

        /// LONG->int
        public int lLastY;

        /// ULONG->unsigned int
        public uint ulExtraInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRAWKEYBOARD
    {

        /// USHORT->unsigned short
        public ushort MakeCode;

        /// USHORT->unsigned short
        public ushort Flags;

        /// USHORT->unsigned short
        public ushort Reserved;

        /// USHORT->unsigned short
        public ushort VKey;

        /// UINT->unsigned int
        public uint Message;

        /// ULONG->unsigned int
        public uint ExtraInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRAWINPUTHEADER
    {

        /// DWORD->unsigned int
        public uint dwType;

        /// DWORD->unsigned int
        public uint dwSize;

        /// HANDLE->void*
        public IntPtr hDevice;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRAWINPUTDEVICELIST
    {

        /// HANDLE->void*
        public IntPtr hDevice;

        /// DWORD->unsigned int
        public uint dwType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRAWINPUTDEVICE
    {

        /// USHORT->unsigned short
        public ushort usUsagePage;

        /// USHORT->unsigned short
        public ushort usUsage;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HWND->HWND__*
        public IntPtr hwndTarget;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRAWINPUT
    {

        /// RAWINPUTHEADER->tagRAWINPUTHEADER
        public tagRAWINPUTHEADER header;

        /// Anonymous_d34c77ee_53b2_47a5_a97c_d5c2b29c8ee3
        public Anonymous_d34c77ee_53b2_47a5_a97c_d5c2b29c8ee3 data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagRAWHID
    {

        /// DWORD->unsigned int
        public uint dwSizeHid;

        /// DWORD->unsigned int
        public uint dwCount;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] bRawData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagQUERYCONTEXT
    {

        /// DWORD->unsigned int
        public uint dwContext;

        /// CSPLATFORM->tagCSPLATFORM
        public tagCSPLATFORM Platform;

        /// LCID->DWORD->unsigned int
        public uint Locale;

        /// DWORD->unsigned int
        public uint dwVersionHi;

        /// DWORD->unsigned int
        public uint dwVersionLo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPSDW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevMode;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevNames;

        /// DWORD->unsigned int
        public uint Flags;

        /// POINT->tagPOINT
        public Point ptPaperSize;

        /// RECT->tagRECT
        public tagRECT rtMinMargin;

        /// RECT->tagRECT
        public tagRECT rtMargin;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPPAGESETUPHOOK
        public LPPAGESETUPHOOK lpfnPageSetupHook;

        /// LPPAGEPAINTHOOK
        public LPPAGEPAINTHOOK lpfnPagePaintHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpPageSetupTemplateName;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hPageSetupTemplate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPSDA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevMode;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevNames;

        /// DWORD->unsigned int
        public uint Flags;

        /// POINT->tagPOINT
        public Point ptPaperSize;

        /// RECT->tagRECT
        public tagRECT rtMinMargin;

        /// RECT->tagRECT
        public tagRECT rtMargin;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPPAGESETUPHOOK
        public LPPAGESETUPHOOK lpfnPageSetupHook;

        /// LPPAGEPAINTHOOK
        public LPPAGEPAINTHOOK lpfnPagePaintHook;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpPageSetupTemplateName;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hPageSetupTemplate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPROPVARIANT
    {

        /// Anonymous_1cd4c797_e9ca_4fb1_b8de_64995b16a502
        public Anonymous_1cd4c797_e9ca_4fb1_b8de_64995b16a502 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPROPSPEC
    {

        /// ULONG->unsigned int
        public uint ulKind;

        /// Anonymous_2065bd0b_b2af_4631_9cf9_a0bd7667dad0
        public Anonymous_2065bd0b_b2af_4631_9cf9_a0bd7667dad0 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPRINTPAGERANGE
    {

        /// DWORD->unsigned int
        public uint nFromPage;

        /// DWORD->unsigned int
        public uint nToPage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPOLYTEXTW
    {

        /// int
        public int x;

        /// int
        public int y;

        /// UINT->unsigned int
        public uint n;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstr;

        /// UINT->unsigned int
        public uint uiFlags;

        /// RECT->tagRECT
        public tagRECT rcl;

        /// int*
        public IntPtr pdx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPOLYTEXTA
    {

        /// int
        public int x;

        /// int
        public int y;

        /// UINT->unsigned int
        public uint n;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstr;

        /// UINT->unsigned int
        public uint uiFlags;

        /// RECT->tagRECT
        public tagRECT rcl;

        /// int*
        public IntPtr pdx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPOINTS
    {

        /// SHORT->short
        public short x;

        /// SHORT->short
        public short y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPOINTFX
    {

        /// FIXED->_FIXED
        public FIXED x;

        /// FIXED->_FIXED
        public FIXED y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPIXELFORMATDESCRIPTOR
    {

        /// WORD->unsigned short
        public ushort nSize;

        /// WORD->unsigned short
        public ushort nVersion;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// BYTE->unsigned char
        public byte iPixelType;

        /// BYTE->unsigned char
        public byte cColorBits;

        /// BYTE->unsigned char
        public byte cRedBits;

        /// BYTE->unsigned char
        public byte cRedShift;

        /// BYTE->unsigned char
        public byte cGreenBits;

        /// BYTE->unsigned char
        public byte cGreenShift;

        /// BYTE->unsigned char
        public byte cBlueBits;

        /// BYTE->unsigned char
        public byte cBlueShift;

        /// BYTE->unsigned char
        public byte cAlphaBits;

        /// BYTE->unsigned char
        public byte cAlphaShift;

        /// BYTE->unsigned char
        public byte cAccumBits;

        /// BYTE->unsigned char
        public byte cAccumRedBits;

        /// BYTE->unsigned char
        public byte cAccumGreenBits;

        /// BYTE->unsigned char
        public byte cAccumBlueBits;

        /// BYTE->unsigned char
        public byte cAccumAlphaBits;

        /// BYTE->unsigned char
        public byte cDepthBits;

        /// BYTE->unsigned char
        public byte cStencilBits;

        /// BYTE->unsigned char
        public byte cAuxBuffers;

        /// BYTE->unsigned char
        public byte iLayerType;

        /// BYTE->unsigned char
        public byte bReserved;

        /// DWORD->unsigned int
        public uint dwLayerMask;

        /// DWORD->unsigned int
        public uint dwVisibleMask;

        /// DWORD->unsigned int
        public uint dwDamageMask;
    }

    public enum tagPENDINGTYPE
    {

        /// PENDINGTYPE_TOPLEVEL -> 1
        PENDINGTYPE_TOPLEVEL = 1,

        /// PENDINGTYPE_NESTED -> 2
        PENDINGTYPE_NESTED = 2,
    }

    public enum tagPENDINGMSG
    {

        /// PENDINGMSG_CANCELCALL -> 0
        PENDINGMSG_CANCELCALL = 0,

        /// PENDINGMSG_WAITNOPROCESS -> 1
        PENDINGMSG_WAITNOPROCESS = 1,

        /// PENDINGMSG_WAITDEFPROCESS -> 2
        PENDINGMSG_WAITDEFPROCESS = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPELARRAY
    {

        /// LONG->int
        public int paXCount;

        /// LONG->int
        public int paYCount;

        /// LONG->int
        public int paXExt;

        /// LONG->int
        public int paYExt;

        /// BYTE->unsigned char
        public byte paRGBs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPDW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevMode;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevNames;

        /// HDC->HDC__*
        public IntPtr hDC;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFromPage;

        /// WORD->unsigned short
        public ushort nToPage;

        /// WORD->unsigned short
        public ushort nMinPage;

        /// WORD->unsigned short
        public ushort nMaxPage;

        /// WORD->unsigned short
        public ushort nCopies;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPPRINTHOOKPROC
        public LPPRINTHOOKPROC lpfnPrintHook;

        /// LPSETUPHOOKPROC
        public LPSETUPHOOKPROC lpfnSetupHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpPrintTemplateName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpSetupTemplateName;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hPrintTemplate;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hSetupTemplate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPDEXW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevMode;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevNames;

        /// HDC->HDC__*
        public IntPtr hDC;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint Flags2;

        /// DWORD->unsigned int
        public uint ExclusionFlags;

        /// DWORD->unsigned int
        public uint nPageRanges;

        /// DWORD->unsigned int
        public uint nMaxPageRanges;

        /// LPPRINTPAGERANGE->tagPRINTPAGERANGE*
        public IntPtr lpPageRanges;

        /// DWORD->unsigned int
        public uint nMinPage;

        /// DWORD->unsigned int
        public uint nMaxPage;

        /// DWORD->unsigned int
        public uint nCopies;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpPrintTemplateName;

        /// LPUNKNOWN->IUnknown*
        public IntPtr lpCallback;

        /// DWORD->unsigned int
        public uint nPropertyPages;

        /// HPROPSHEETPAGE*
        public IntPtr lphPropertyPages;

        /// DWORD->unsigned int
        public uint nStartPage;

        /// DWORD->unsigned int
        public uint dwResultAction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPDEXA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevMode;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevNames;

        /// HDC->HDC__*
        public IntPtr hDC;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint Flags2;

        /// DWORD->unsigned int
        public uint ExclusionFlags;

        /// DWORD->unsigned int
        public uint nPageRanges;

        /// DWORD->unsigned int
        public uint nMaxPageRanges;

        /// LPPRINTPAGERANGE->tagPRINTPAGERANGE*
        public IntPtr lpPageRanges;

        /// DWORD->unsigned int
        public uint nMinPage;

        /// DWORD->unsigned int
        public uint nMaxPage;

        /// DWORD->unsigned int
        public uint nCopies;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpPrintTemplateName;

        /// LPUNKNOWN->IUnknown*
        public IntPtr lpCallback;

        /// DWORD->unsigned int
        public uint nPropertyPages;

        /// HPROPSHEETPAGE*
        public IntPtr lphPropertyPages;

        /// DWORD->unsigned int
        public uint nStartPage;

        /// DWORD->unsigned int
        public uint dwResultAction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPDA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevMode;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hDevNames;

        /// HDC->HDC__*
        public IntPtr hDC;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFromPage;

        /// WORD->unsigned short
        public ushort nToPage;

        /// WORD->unsigned short
        public ushort nMinPage;

        /// WORD->unsigned short
        public ushort nMaxPage;

        /// WORD->unsigned short
        public ushort nCopies;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPPRINTHOOKPROC
        public LPPRINTHOOKPROC lpfnPrintHook;

        /// LPSETUPHOOKPROC
        public LPSETUPHOOKPROC lpfnSetupHook;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpPrintTemplateName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpSetupTemplateName;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hPrintTemplate;

        /// HGLOBAL->HANDLE->void*
        public IntPtr hSetupTemplate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPARAMDESCEX
    {

        /// ULONG->unsigned int
        public uint cBytes;

        /// VARIANTARG->VARIANT->tagVARIANT
        public tagVARIANT varDefaultValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPARAMDESC
    {

        /// LPPARAMDESCEX->tagPARAMDESCEX*
        public IntPtr pparamdescex;

        /// USHORT->unsigned short
        public ushort wParamFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPARAMDATA
    {

        /// OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szName;

        /// VARTYPE->unsigned short
        public ushort vt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPANOSE
    {

        /// BYTE->unsigned char
        public byte bFamilyType;

        /// BYTE->unsigned char
        public byte bSerifStyle;

        /// BYTE->unsigned char
        public byte bWeight;

        /// BYTE->unsigned char
        public byte bProportion;

        /// BYTE->unsigned char
        public byte bContrast;

        /// BYTE->unsigned char
        public byte bStrokeVariation;

        /// BYTE->unsigned char
        public byte bArmStyle;

        /// BYTE->unsigned char
        public byte bLetterform;

        /// BYTE->unsigned char
        public byte bMidline;

        /// BYTE->unsigned char
        public byte bXHeight;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPALETTEENTRY
    {

        /// BYTE->unsigned char
        public byte peRed;

        /// BYTE->unsigned char
        public byte peGreen;

        /// BYTE->unsigned char
        public byte peBlue;

        /// BYTE->unsigned char
        public byte peFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagPAINTSTRUCT
    {

        /// HDC->HDC__*
        public IntPtr hdc;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fErase;

        /// RECT->tagRECT
        public tagRECT rcPaint;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fRestore;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fIncUpdate;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbReserved;
    }

    public enum tagOLEWHICHMK
    {

        /// OLEWHICHMK_CONTAINER -> 1
        OLEWHICHMK_CONTAINER = 1,

        /// OLEWHICHMK_OBJREL -> 2
        OLEWHICHMK_OBJREL = 2,

        /// OLEWHICHMK_OBJFULL -> 3
        OLEWHICHMK_OBJFULL = 3,
    }

    public enum tagOLEVERBATTRIB
    {

        /// OLEVERBATTRIB_NEVERDIRTIES -> 1
        OLEVERBATTRIB_NEVERDIRTIES = 1,

        /// OLEVERBATTRIB_ONCONTAINERMENU -> 2
        OLEVERBATTRIB_ONCONTAINERMENU = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOLEVERB
    {

        /// LONG->int
        public int lVerb;

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszVerbName;

        /// DWORD->unsigned int
        public uint fuFlags;

        /// DWORD->unsigned int
        public uint grfAttribs;
    }

    public enum tagOLEUPDATE
    {

        /// OLEUPDATE_ALWAYS -> 1
        OLEUPDATE_ALWAYS = 1,

        /// OLEUPDATE_ONCALL -> 3
        OLEUPDATE_ONCALL = 3,
    }

    public enum tagOLERENDER
    {

        /// OLERENDER_NONE -> 0
        OLERENDER_NONE = 0,

        /// OLERENDER_DRAW -> 1
        OLERENDER_DRAW = 1,

        /// OLERENDER_FORMAT -> 2
        OLERENDER_FORMAT = 2,

        /// OLERENDER_ASIS -> 3
        OLERENDER_ASIS = 3,
    }

    public enum tagOLEMISC
    {

        /// OLEMISC_RECOMPOSEONRESIZE -> 0x1
        OLEMISC_RECOMPOSEONRESIZE = 1,

        /// OLEMISC_ONLYICONIC -> 0x2
        OLEMISC_ONLYICONIC = 2,

        /// OLEMISC_INSERTNOTREPLACE -> 0x4
        OLEMISC_INSERTNOTREPLACE = 4,

        /// OLEMISC_STATIC -> 0x8
        OLEMISC_STATIC = 8,

        /// OLEMISC_CANTLINKINSIDE -> 0x10
        OLEMISC_CANTLINKINSIDE = 16,

        /// OLEMISC_CANLINKBYOLE1 -> 0x20
        OLEMISC_CANLINKBYOLE1 = 32,

        /// OLEMISC_ISLINKOBJECT -> 0x40
        OLEMISC_ISLINKOBJECT = 64,

        /// OLEMISC_INSIDEOUT -> 0x80
        OLEMISC_INSIDEOUT = 128,

        /// OLEMISC_ACTIVATEWHENVISIBLE -> 0x100
        OLEMISC_ACTIVATEWHENVISIBLE = 256,

        /// OLEMISC_RENDERINGISDEVICEINDEPENDENT -> 0x200
        OLEMISC_RENDERINGISDEVICEINDEPENDENT = 512,

        /// OLEMISC_INVISIBLEATRUNTIME -> 0x400
        OLEMISC_INVISIBLEATRUNTIME = 1024,

        /// OLEMISC_ALWAYSRUN -> 0x800
        OLEMISC_ALWAYSRUN = 2048,

        /// OLEMISC_ACTSLIKEBUTTON -> 0x1000
        OLEMISC_ACTSLIKEBUTTON = 4096,

        /// OLEMISC_ACTSLIKELABEL -> 0x2000
        OLEMISC_ACTSLIKELABEL = 8192,

        /// OLEMISC_NOUIACTIVATE -> 0x4000
        OLEMISC_NOUIACTIVATE = 16384,

        /// OLEMISC_ALIGNABLE -> 0x8000
        OLEMISC_ALIGNABLE = 32768,

        /// OLEMISC_SIMPLEFRAME -> 0x10000
        OLEMISC_SIMPLEFRAME = 65536,

        /// OLEMISC_SETCLIENTSITEFIRST -> 0x20000
        OLEMISC_SETCLIENTSITEFIRST = 131072,

        /// OLEMISC_IMEMODE -> 0x40000
        OLEMISC_IMEMODE = 262144,

        /// OLEMISC_IGNOREACTIVATEWHENVISIBLE -> 0x80000
        OLEMISC_IGNOREACTIVATEWHENVISIBLE = 524288,

        /// OLEMISC_WANTSTOMENUMERGE -> 0x100000
        OLEMISC_WANTSTOMENUMERGE = 1048576,

        /// OLEMISC_SUPPORTSMULTILEVELUNDO -> 0x200000
        OLEMISC_SUPPORTSMULTILEVELUNDO = 2097152,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOleMenuGroupWidths
    {

        /// LONG[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I4)]
        public int[] width;
    }

    public enum tagOLELINKBIND
    {

        /// OLELINKBIND_EVENIFCLASSDIFF -> 1
        OLELINKBIND_EVENIFCLASSDIFF = 1,
    }

    public enum tagOLEGETMONIKER
    {

        /// OLEGETMONIKER_ONLYIFTHERE -> 1
        OLEGETMONIKER_ONLYIFTHERE = 1,

        /// OLEGETMONIKER_FORCEASSIGN -> 2
        OLEGETMONIKER_FORCEASSIGN = 2,

        /// OLEGETMONIKER_UNASSIGN -> 3
        OLEGETMONIKER_UNASSIGN = 3,

        /// OLEGETMONIKER_TEMPFORUSER -> 4
        OLEGETMONIKER_TEMPFORUSER = 4,
    }

    public enum tagOLECONTF
    {

        /// OLECONTF_EMBEDDINGS -> 1
        OLECONTF_EMBEDDINGS = 1,

        /// OLECONTF_LINKS -> 2
        OLECONTF_LINKS = 2,

        /// OLECONTF_OTHERS -> 4
        OLECONTF_OTHERS = 4,

        /// OLECONTF_ONLYUSER -> 8
        OLECONTF_ONLYUSER = 8,

        /// OLECONTF_ONLYIFRUNNING -> 16
        OLECONTF_ONLYIFRUNNING = 16,
    }

    public enum tagOLECLOSE
    {

        /// OLECLOSE_SAVEIFDIRTY -> 0
        OLECLOSE_SAVEIFDIRTY = 0,

        /// OLECLOSE_NOSAVE -> 1
        OLECLOSE_NOSAVE = 1,

        /// OLECLOSE_PROMPTSAVE -> 2
        OLECLOSE_PROMPTSAVE = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOIFI
    {

        /// UINT->unsigned int
        public uint cb;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fMDIApp;

        /// HWND->HWND__*
        public IntPtr hwndFrame;

        /// HACCEL->HACCEL__*
        public IntPtr haccel;

        /// UINT->unsigned int
        public uint cAccelEntries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOFN_NT4W
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrFilter;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrCustomFilter;

        /// DWORD->unsigned int
        public uint nMaxCustFilter;

        /// DWORD->unsigned int
        public uint nFilterIndex;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrFile;

        /// DWORD->unsigned int
        public uint nMaxFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrFileTitle;

        /// DWORD->unsigned int
        public uint nMaxFileTitle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrInitialDir;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrTitle;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFileOffset;

        /// WORD->unsigned short
        public ushort nFileExtension;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrDefExt;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPOFNHOOKPROC
        public LPOFNHOOKPROC lpfnHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpTemplateName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOFN_NT4A
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrFilter;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrCustomFilter;

        /// DWORD->unsigned int
        public uint nMaxCustFilter;

        /// DWORD->unsigned int
        public uint nFilterIndex;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrFile;

        /// DWORD->unsigned int
        public uint nMaxFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrFileTitle;

        /// DWORD->unsigned int
        public uint nMaxFileTitle;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrInitialDir;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrTitle;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFileOffset;

        /// WORD->unsigned short
        public ushort nFileExtension;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrDefExt;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPOFNHOOKPROC
        public LPOFNHOOKPROC lpfnHook;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpTemplateName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOFNW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrFilter;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrCustomFilter;

        /// DWORD->unsigned int
        public uint nMaxCustFilter;

        /// DWORD->unsigned int
        public uint nFilterIndex;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrFile;

        /// DWORD->unsigned int
        public uint nMaxFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrFileTitle;

        /// DWORD->unsigned int
        public uint nMaxFileTitle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrInitialDir;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrTitle;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFileOffset;

        /// WORD->unsigned short
        public ushort nFileExtension;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrDefExt;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPOFNHOOKPROC
        public LPOFNHOOKPROC lpfnHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpTemplateName;

        /// void*
        public IntPtr pvReserved;

        /// DWORD->unsigned int
        public uint dwReserved;

        /// DWORD->unsigned int
        public uint FlagsEx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOFNA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrFilter;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrCustomFilter;

        /// DWORD->unsigned int
        public uint nMaxCustFilter;

        /// DWORD->unsigned int
        public uint nFilterIndex;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrFile;

        /// DWORD->unsigned int
        public uint nMaxFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrFileTitle;

        /// DWORD->unsigned int
        public uint nMaxFileTitle;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrInitialDir;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrTitle;

        /// DWORD->unsigned int
        public uint Flags;

        /// WORD->unsigned short
        public ushort nFileOffset;

        /// WORD->unsigned short
        public ushort nFileExtension;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrDefExt;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPOFNHOOKPROC
        public LPOFNHOOKPROC lpfnHook;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpTemplateName;

        /// void*
        public IntPtr pvReserved;

        /// DWORD->unsigned int
        public uint dwReserved;

        /// DWORD->unsigned int
        public uint FlagsEx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagOBJECTDESCRIPTOR
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// CLSID->GUID->_GUID
        public GUID clsid;

        /// DWORD->unsigned int
        public uint dwDrawAspect;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE sizel;

        /// POINTL->_POINTL
        public POINTL pointl;

        /// DWORD->unsigned int
        public uint dwStatus;

        /// DWORD->unsigned int
        public uint dwFullUserTypeName;

        /// DWORD->unsigned int
        public uint dwSrcOfCopy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNONCLIENTMETRICSW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iBorderWidth;

        /// int
        public int iScrollWidth;

        /// int
        public int iScrollHeight;

        /// int
        public int iCaptionWidth;

        /// int
        public int iCaptionHeight;

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW lfCaptionFont;

        /// int
        public int iSmCaptionWidth;

        /// int
        public int iSmCaptionHeight;

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW lfSmCaptionFont;

        /// int
        public int iMenuWidth;

        /// int
        public int iMenuHeight;

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW lfMenuFont;

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW lfStatusFont;

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW lfMessageFont;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNONCLIENTMETRICSA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iBorderWidth;

        /// int
        public int iScrollWidth;

        /// int
        public int iScrollHeight;

        /// int
        public int iCaptionWidth;

        /// int
        public int iCaptionHeight;

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA lfCaptionFont;

        /// int
        public int iSmCaptionWidth;

        /// int
        public int iSmCaptionHeight;

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA lfSmCaptionFont;

        /// int
        public int iMenuWidth;

        /// int
        public int iMenuHeight;

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA lfMenuFont;

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA lfStatusFont;

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA lfMessageFont;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNMHDR
    {

        /// HWND->HWND__*
        public IntPtr hwndFrom;

        /// UINT_PTR->unsigned int
        public uint idFrom;

        /// UINT->unsigned int
        public uint code;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNEWTEXTMETRICW
    {

        /// LONG->int
        public int tmHeight;

        /// LONG->int
        public int tmAscent;

        /// LONG->int
        public int tmDescent;

        /// LONG->int
        public int tmInternalLeading;

        /// LONG->int
        public int tmExternalLeading;

        /// LONG->int
        public int tmAveCharWidth;

        /// LONG->int
        public int tmMaxCharWidth;

        /// LONG->int
        public int tmWeight;

        /// LONG->int
        public int tmOverhang;

        /// LONG->int
        public int tmDigitizedAspectX;

        /// LONG->int
        public int tmDigitizedAspectY;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmFirstChar;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmLastChar;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmDefaultChar;

        /// WCHAR->wchar_t->unsigned short
        public ushort tmBreakChar;

        /// BYTE->unsigned char
        public byte tmItalic;

        /// BYTE->unsigned char
        public byte tmUnderlined;

        /// BYTE->unsigned char
        public byte tmStruckOut;

        /// BYTE->unsigned char
        public byte tmPitchAndFamily;

        /// BYTE->unsigned char
        public byte tmCharSet;

        /// DWORD->unsigned int
        public uint ntmFlags;

        /// UINT->unsigned int
        public uint ntmSizeEM;

        /// UINT->unsigned int
        public uint ntmCellHeight;

        /// UINT->unsigned int
        public uint ntmAvgWidth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNEWTEXTMETRICEXW
    {

        /// NEWTEXTMETRICW->tagNEWTEXTMETRICW
        public tagNEWTEXTMETRICW ntmTm;

        /// FONTSIGNATURE->tagFONTSIGNATURE
        public tagFONTSIGNATURE ntmFontSig;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNEWTEXTMETRICEXA
    {

        /// NEWTEXTMETRICA->tagNEWTEXTMETRICA
        public tagNEWTEXTMETRICA ntmTm;

        /// FONTSIGNATURE->tagFONTSIGNATURE
        public tagFONTSIGNATURE ntmFontSig;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNEWTEXTMETRICA
    {

        /// LONG->int
        public int tmHeight;

        /// LONG->int
        public int tmAscent;

        /// LONG->int
        public int tmDescent;

        /// LONG->int
        public int tmInternalLeading;

        /// LONG->int
        public int tmExternalLeading;

        /// LONG->int
        public int tmAveCharWidth;

        /// LONG->int
        public int tmMaxCharWidth;

        /// LONG->int
        public int tmWeight;

        /// LONG->int
        public int tmOverhang;

        /// LONG->int
        public int tmDigitizedAspectX;

        /// LONG->int
        public int tmDigitizedAspectY;

        /// BYTE->unsigned char
        public byte tmFirstChar;

        /// BYTE->unsigned char
        public byte tmLastChar;

        /// BYTE->unsigned char
        public byte tmDefaultChar;

        /// BYTE->unsigned char
        public byte tmBreakChar;

        /// BYTE->unsigned char
        public byte tmItalic;

        /// BYTE->unsigned char
        public byte tmUnderlined;

        /// BYTE->unsigned char
        public byte tmStruckOut;

        /// BYTE->unsigned char
        public byte tmPitchAndFamily;

        /// BYTE->unsigned char
        public byte tmCharSet;

        /// DWORD->unsigned int
        public uint ntmFlags;

        /// UINT->unsigned int
        public uint ntmSizeEM;

        /// UINT->unsigned int
        public uint ntmCellHeight;

        /// UINT->unsigned int
        public uint ntmAvgWidth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagNCCALCSIZE_PARAMS
    {

        /// RECT[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
        public tagRECT[] rgrc;

        /// PWINDOWPOS->tagWINDOWPOS*
        public IntPtr lppos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMULTI_QI
    {

        /// IID*
        public IntPtr pIID;

        /// IUnknown*
        public IntPtr pItf;

        /// HRESULT->LONG->int
        public int hr;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMULTIKEYHELPW
    {

        /// DWORD->unsigned int
        public uint mkSize;

        /// WCHAR->wchar_t->unsigned short
        public ushort mkKeylist;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string szKeyphrase;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMULTIKEYHELPA
    {

        /// DWORD->unsigned int
        public uint mkSize;

        /// CHAR->char
        public byte mkKeylist;

        /// CHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string szKeyphrase;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMSLLHOOKSTRUCT
    {

        /// POINT->tagPOINT
        public Point pt;

        /// DWORD->unsigned int
        public uint mouseData;

        /// DWORD->unsigned int
        public uint flags;

        /// DWORD->unsigned int
        public uint time;

        /// ULONG_PTR->unsigned int
        public uint dwExtraInfo;
    }

    public enum tagMSHLFLAGS
    {

        /// MSHLFLAGS_NORMAL -> 0
        MSHLFLAGS_NORMAL = 0,

        /// MSHLFLAGS_TABLESTRONG -> 1
        MSHLFLAGS_TABLESTRONG = 1,

        /// MSHLFLAGS_TABLEWEAK -> 2
        MSHLFLAGS_TABLEWEAK = 2,

        /// MSHLFLAGS_NOPING -> 4
        MSHLFLAGS_NOPING = 4,

        /// MSHLFLAGS_RESERVED1 -> 8
        MSHLFLAGS_RESERVED1 = 8,

        /// MSHLFLAGS_RESERVED2 -> 16
        MSHLFLAGS_RESERVED2 = 16,

        /// MSHLFLAGS_RESERVED3 -> 32
        MSHLFLAGS_RESERVED3 = 32,

        /// MSHLFLAGS_RESERVED4 -> 64
        MSHLFLAGS_RESERVED4 = 64,
    }

    public enum tagMSHCTX
    {

        /// MSHCTX_LOCAL -> 0
        MSHCTX_LOCAL = 0,

        /// MSHCTX_NOSHAREDMEM -> 1
        MSHCTX_NOSHAREDMEM = 1,

        /// MSHCTX_DIFFERENTMACHINE -> 2
        MSHCTX_DIFFERENTMACHINE = 2,

        /// MSHCTX_INPROC -> 3
        MSHCTX_INPROC = 3,

        /// MSHCTX_CROSSCTX -> 4
        MSHCTX_CROSSCTX = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMSGBOXPARAMSW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszText;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszCaption;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszIcon;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwContextHelpId;

        /// MSGBOXCALLBACK
        public MSGBOXCALLBACK lpfnMsgBoxCallback;

        /// DWORD->unsigned int
        public uint dwLanguageId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMSGBOXPARAMSA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszText;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszCaption;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszIcon;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwContextHelpId;

        /// MSGBOXCALLBACK
        public MSGBOXCALLBACK lpfnMsgBoxCallback;

        /// DWORD->unsigned int
        public uint dwLanguageId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMSG
    {

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// UINT->unsigned int
        public uint message;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// DWORD->unsigned int
        public uint time;

        /// POINT->tagPOINT
        public Point pt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMOUSEMOVEPOINT
    {

        /// int
        public int x;

        /// int
        public int y;

        /// DWORD->unsigned int
        public uint time;

        /// ULONG_PTR->unsigned int
        public uint dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMOUSEKEYS
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint iMaxSpeed;

        /// DWORD->unsigned int
        public uint iTimeToMaxSpeed;

        /// DWORD->unsigned int
        public uint iCtrlSpeed;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// DWORD->unsigned int
        public uint dwReserved2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMOUSEINPUT
    {

        /// LONG->int
        public int dx;

        /// LONG->int
        public int dy;

        /// DWORD->unsigned int
        public uint mouseData;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint time;

        /// ULONG_PTR->unsigned int
        public uint dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMOUSEHOOKSTRUCTEX
    {

        /// MOUSEHOOKSTRUCT->tagMOUSEHOOKSTRUCT
        public tagMOUSEHOOKSTRUCT AnonymousMember1;

        /// DWORD->unsigned int
        public uint mouseData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMOUSEHOOKSTRUCT
    {

        /// POINT->tagPOINT
        public Point pt;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// UINT->unsigned int
        public uint wHitTestCode;

        /// ULONG_PTR->unsigned int
        public uint dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMONMSGSTRUCT
    {

        /// UINT->unsigned int
        public uint cb;

        /// HWND->HWND__*
        public IntPtr hwndTo;

        /// DWORD->unsigned int
        public uint dwTime;

        /// HANDLE->void*
        public IntPtr hTask;

        /// UINT->unsigned int
        public uint wMsg;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// DDEML_MSG_HOOK_DATA->tagDDEML_MSG_HOOK_DATA
        public tagDDEML_MSG_HOOK_DATA dmhd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMONLINKSTRUCT
    {

        /// UINT->unsigned int
        public uint cb;

        /// DWORD->unsigned int
        public uint dwTime;

        /// HANDLE->void*
        public IntPtr hTask;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fEstablished;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fNoData;

        /// HSZ->HSZ__*
        public IntPtr hszSvc;

        /// HSZ->HSZ__*
        public IntPtr hszTopic;

        /// HSZ->HSZ__*
        public IntPtr hszItem;

        /// UINT->unsigned int
        public uint wFmt;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fServer;

        /// HCONV->HCONV__*
        public IntPtr hConvServer;

        /// HCONV->HCONV__*
        public IntPtr hConvClient;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMONITORINFOEXW
    {

        /// MONITORINFO->tagMONITORINFO
        public tagMONITORINFO AnonymousMember1;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDevice;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMONITORINFOEXA
    {

        /// MONITORINFO->tagMONITORINFO
        public tagMONITORINFO AnonymousMember1;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDevice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMONITORINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// RECT->tagRECT
        public tagRECT rcMonitor;

        /// RECT->tagRECT
        public tagRECT rcWork;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMONHSZSTRUCTW
    {

        /// UINT->unsigned int
        public uint cb;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fsAction;

        /// DWORD->unsigned int
        public uint dwTime;

        /// HSZ->HSZ__*
        public IntPtr hsz;

        /// HANDLE->void*
        public IntPtr hTask;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string str;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMONHSZSTRUCTA
    {

        /// UINT->unsigned int
        public uint cb;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fsAction;

        /// DWORD->unsigned int
        public uint dwTime;

        /// HSZ->HSZ__*
        public IntPtr hsz;

        /// HANDLE->void*
        public IntPtr hTask;

        /// CHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string str;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMONERRSTRUCT
    {

        /// UINT->unsigned int
        public uint cb;

        /// UINT->unsigned int
        public uint wLastError;

        /// DWORD->unsigned int
        public uint dwTime;

        /// HANDLE->void*
        public IntPtr hTask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMONCONVSTRUCT
    {

        /// UINT->unsigned int
        public uint cb;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fConnect;

        /// DWORD->unsigned int
        public uint dwTime;

        /// HANDLE->void*
        public IntPtr hTask;

        /// HSZ->HSZ__*
        public IntPtr hszSvc;

        /// HSZ->HSZ__*
        public IntPtr hszTopic;

        /// HCONV->HCONV__*
        public IntPtr hConvClient;

        /// HCONV->HCONV__*
        public IntPtr hConvServer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMONCBSTRUCT
    {

        /// UINT->unsigned int
        public uint cb;

        /// DWORD->unsigned int
        public uint dwTime;

        /// HANDLE->void*
        public IntPtr hTask;

        /// DWORD->unsigned int
        public uint dwRet;

        /// UINT->unsigned int
        public uint wType;

        /// UINT->unsigned int
        public uint wFmt;

        /// HCONV->HCONV__*
        public IntPtr hConv;

        /// HSZ->HSZ__*
        public IntPtr hsz1;

        /// HSZ->HSZ__*
        public IntPtr hsz2;

        /// HDDEDATA->HDDEDATA__*
        public IntPtr hData;

        /// ULONG_PTR->unsigned int
        public uint dwData1;

        /// ULONG_PTR->unsigned int
        public uint dwData2;

        /// CONVCONTEXT->tagCONVCONTEXT
        public tagCONVCONTEXT cc;

        /// DWORD->unsigned int
        public uint cbData;

        /// DWORD[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.U4)]
        public uint[] Data;
    }

    public enum tagMKSYS
    {

        /// MKSYS_NONE -> 0
        MKSYS_NONE = 0,

        /// MKSYS_GENERICCOMPOSITE -> 1
        MKSYS_GENERICCOMPOSITE = 1,

        /// MKSYS_FILEMONIKER -> 2
        MKSYS_FILEMONIKER = 2,

        /// MKSYS_ANTIMONIKER -> 3
        MKSYS_ANTIMONIKER = 3,

        /// MKSYS_ITEMMONIKER -> 4
        MKSYS_ITEMMONIKER = 4,

        /// MKSYS_POINTERMONIKER -> 5
        MKSYS_POINTERMONIKER = 5,

        /// MKSYS_CLASSMONIKER -> 7
        MKSYS_CLASSMONIKER = 7,

        /// MKSYS_OBJREFMONIKER -> 8
        MKSYS_OBJREFMONIKER = 8,

        /// MKSYS_SESSIONMONIKER -> 9
        MKSYS_SESSIONMONIKER = 9,
    }

    public enum tagMKREDUCE
    {

        /// MKRREDUCE_ONE -> 3<<16
        MKRREDUCE_ONE = (3) << (16),

        /// MKRREDUCE_TOUSER -> 2<<16
        MKRREDUCE_TOUSER = (2) << (16),

        /// MKRREDUCE_THROUGHUSER -> 1<<16
        MKRREDUCE_THROUGHUSER = (1) << (16),

        /// MKRREDUCE_ALL -> 0
        MKRREDUCE_ALL = 0,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIXERLINEW
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwDestination;

        /// DWORD->unsigned int
        public uint dwSource;

        /// DWORD->unsigned int
        public uint dwLineID;

        /// DWORD->unsigned int
        public uint fdwLine;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwUser;

        /// DWORD->unsigned int
        public uint dwComponentType;

        /// DWORD->unsigned int
        public uint cChannels;

        /// DWORD->unsigned int
        public uint cConnections;

        /// DWORD->unsigned int
        public uint cControls;

        /// WCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string szShortName;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;

        /// Anonymous_7f7374db_bded_4271_9e48_f4aee28762e0
        public Anonymous_7f7374db_bded_4271_9e48_f4aee28762e0 Target;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMIXERLINECONTROLSW
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwLineID;

        /// Anonymous_be850055_9068_46f5_b1b6_55478ba127c0
        public Anonymous_be850055_9068_46f5_b1b6_55478ba127c0 Union1;

        /// DWORD->unsigned int
        public uint cControls;

        /// DWORD->unsigned int
        public uint cbmxctrl;

        /// LPMIXERCONTROLW->tagMIXERCONTROLW*
        public IntPtr pamxctrl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMIXERLINECONTROLSA
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwLineID;

        /// Anonymous_1d5bfd98_6f98_4ee1_862c_03b73f120f91
        public Anonymous_1d5bfd98_6f98_4ee1_862c_03b73f120f91 Union1;

        /// DWORD->unsigned int
        public uint cControls;

        /// DWORD->unsigned int
        public uint cbmxctrl;

        /// LPMIXERCONTROLA->tagMIXERCONTROLA*
        public IntPtr pamxctrl;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIXERLINEA
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwDestination;

        /// DWORD->unsigned int
        public uint dwSource;

        /// DWORD->unsigned int
        public uint dwLineID;

        /// DWORD->unsigned int
        public uint fdwLine;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwUser;

        /// DWORD->unsigned int
        public uint dwComponentType;

        /// DWORD->unsigned int
        public uint cChannels;

        /// DWORD->unsigned int
        public uint cConnections;

        /// DWORD->unsigned int
        public uint cControls;

        /// CHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string szShortName;

        /// CHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;

        /// Anonymous_8a75d5d0_84ce_4789_a5bb_dd44f5216f27
        public Anonymous_8a75d5d0_84ce_4789_a5bb_dd44f5216f27 Target;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIXERCONTROLW
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwControlID;

        /// DWORD->unsigned int
        public uint dwControlType;

        /// DWORD->unsigned int
        public uint fdwControl;

        /// DWORD->unsigned int
        public uint cMultipleItems;

        /// WCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string szShortName;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;

        /// Anonymous_32d07395_111c_4bbf_950d_b622ca74a868
        public Anonymous_32d07395_111c_4bbf_950d_b622ca74a868 Bounds;

        /// Anonymous_bb8fbc03_3a8e_4664_a752_b7a8041c4097
        public Anonymous_bb8fbc03_3a8e_4664_a752_b7a8041c4097 Metrics;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIXERCONTROLDETAILS_LISTTEXTW
    {

        /// DWORD->unsigned int
        public uint dwParam1;

        /// DWORD->unsigned int
        public uint dwParam2;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIXERCONTROLDETAILS_LISTTEXTA
    {

        /// DWORD->unsigned int
        public uint dwParam1;

        /// DWORD->unsigned int
        public uint dwParam2;

        /// CHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIXERCONTROLA
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint dwControlID;

        /// DWORD->unsigned int
        public uint dwControlType;

        /// DWORD->unsigned int
        public uint fdwControl;

        /// DWORD->unsigned int
        public uint cMultipleItems;

        /// CHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string szShortName;

        /// CHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;

        /// Anonymous_29f7e609_4e9c_4993_9ec9_18c8c124fbcf
        public Anonymous_29f7e609_4e9c_4993_9ec9_18c8c124fbcf Bounds;

        /// Anonymous_30c38121_85ac_43e6_9dce_8c8aabb85854
        public Anonymous_30c38121_85ac_43e6_9dce_8c8aabb85854 Metrics;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIXERCAPSW
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint fdwSupport;

        /// DWORD->unsigned int
        public uint cDestinations;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIXERCAPSA
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint fdwSupport;

        /// DWORD->unsigned int
        public uint cDestinations;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIXERCAPS2W
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint fdwSupport;

        /// DWORD->unsigned int
        public uint cDestinations;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIXERCAPS2A
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint fdwSupport;

        /// DWORD->unsigned int
        public uint cDestinations;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMINMAXINFO
    {

        /// POINT->tagPOINT
        public Point ptReserved;

        /// POINT->tagPOINT
        public Point ptMaxSize;

        /// POINT->tagPOINT
        public Point ptMaxPosition;

        /// POINT->tagPOINT
        public Point ptMinTrackSize;

        /// POINT->tagPOINT
        public Point ptMaxTrackSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMINIMIZEDMETRICS
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iWidth;

        /// int
        public int iHorzGap;

        /// int
        public int iVertGap;

        /// int
        public int iArrange;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIDIOUTCAPSW
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wVoices;

        /// WORD->unsigned short
        public ushort wNotes;

        /// WORD->unsigned short
        public ushort wChannelMask;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIDIOUTCAPSA
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wVoices;

        /// WORD->unsigned short
        public ushort wNotes;

        /// WORD->unsigned short
        public ushort wChannelMask;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIDIOUTCAPS2W
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wVoices;

        /// WORD->unsigned short
        public ushort wNotes;

        /// WORD->unsigned short
        public ushort wChannelMask;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIDIOUTCAPS2A
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wVoices;

        /// WORD->unsigned short
        public ushort wNotes;

        /// WORD->unsigned short
        public ushort wChannelMask;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIDIINCAPSW
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIDIINCAPSA
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagMIDIINCAPS2W
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagMIDIINCAPS2A
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMETHODDATA
    {

        /// OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szName;

        /// PARAMDATA*
        public IntPtr ppdata;

        /// DISPID->LONG->int
        public int dispid;

        /// UINT->unsigned int
        public uint iMeth;

        /// CALLCONV->tagCALLCONV
        public tagCALLCONV cc;

        /// UINT->unsigned int
        public uint cArgs;

        /// WORD->unsigned short
        public ushort wFlags;

        /// VARTYPE->unsigned short
        public ushort vtReturn;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMETARECORD
    {

        /// DWORD->unsigned int
        public uint rdSize;

        /// WORD->unsigned short
        public ushort rdFunction;

        /// WORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U2)]
        public ushort[] rdParm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMETAHEADER
    {

        /// WORD->unsigned short
        public ushort mtType;

        /// WORD->unsigned short
        public ushort mtHeaderSize;

        /// WORD->unsigned short
        public ushort mtVersion;

        /// DWORD->unsigned int
        public uint mtSize;

        /// WORD->unsigned short
        public ushort mtNoObjects;

        /// DWORD->unsigned int
        public uint mtMaxRecord;

        /// WORD->unsigned short
        public ushort mtNoParameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMETAFILEPICT
    {

        /// LONG->int
        public int mm;

        /// LONG->int
        public int xExt;

        /// LONG->int
        public int yExt;

        /// HMETAFILE->HMETAFILE__*
        public IntPtr hMF;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMENUITEMINFOW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint fMask;

        /// UINT->unsigned int
        public uint fType;

        /// UINT->unsigned int
        public uint fState;

        /// UINT->unsigned int
        public uint wID;

        /// HMENU->HMENU__*
        public IntPtr hSubMenu;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpChecked;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpUnchecked;

        /// ULONG_PTR->unsigned int
        public uint dwItemData;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string dwTypeData;

        /// UINT->unsigned int
        public uint cch;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpItem;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMENUITEMINFOA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint fMask;

        /// UINT->unsigned int
        public uint fType;

        /// UINT->unsigned int
        public uint fState;

        /// UINT->unsigned int
        public uint wID;

        /// HMENU->HMENU__*
        public IntPtr hSubMenu;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpChecked;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpUnchecked;

        /// ULONG_PTR->unsigned int
        public uint dwItemData;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string dwTypeData;

        /// UINT->unsigned int
        public uint cch;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpItem;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMENUINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint fMask;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// UINT->unsigned int
        public uint cyMax;

        /// HBRUSH->HBRUSH__*
        public IntPtr hbrBack;

        /// DWORD->unsigned int
        public uint dwContextHelpID;

        /// ULONG_PTR->unsigned int
        public uint dwMenuData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMENUGETOBJECTINFO
    {

        /// DWORD->unsigned int
        public uint dwFlags;

        /// UINT->unsigned int
        public uint uPos;

        /// HMENU->HMENU__*
        public IntPtr hmenu;

        /// PVOID->void*
        public IntPtr riid;

        /// PVOID->void*
        public IntPtr pvObj;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMENUBARINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// RECT->tagRECT
        public tagRECT rcBar;

        /// HMENU->HMENU__*
        public IntPtr hMenu;

        /// HWND->HWND__*
        public IntPtr hwndMenu;

        /// fBarFocused : 1
        ///fFocused : 1
        public uint bitvector1;

        public uint fBarFocused
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

        public uint fFocused
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
    }

    public enum tagMEMCTX
    {

        /// MEMCTX_TASK -> 1
        MEMCTX_TASK = 1,

        /// MEMCTX_SHARED -> 2
        MEMCTX_SHARED = 2,

        /// MEMCTX_MACSYSTEM -> 3
        MEMCTX_MACSYSTEM = 3,

        /// MEMCTX_UNKNOWN -> -1
        MEMCTX_UNKNOWN = -1,

        /// MEMCTX_SAME -> -2
        MEMCTX_SAME = -2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMEASUREITEMSTRUCT
    {

        /// UINT->unsigned int
        public uint CtlType;

        /// UINT->unsigned int
        public uint CtlID;

        /// UINT->unsigned int
        public uint itemID;

        /// UINT->unsigned int
        public uint itemWidth;

        /// UINT->unsigned int
        public uint itemHeight;

        /// ULONG_PTR->unsigned int
        public uint itemData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMDINEXTMENU
    {

        /// HMENU->HMENU__*
        public IntPtr hmenuIn;

        /// HMENU->HMENU__*
        public IntPtr hmenuNext;

        /// HWND->HWND__*
        public IntPtr hwndNext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMDICREATESTRUCTW
    {

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szClass;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szTitle;

        /// HANDLE->void*
        public IntPtr hOwner;

        /// int
        public int x;

        /// int
        public int y;

        /// int
        public int cx;

        /// int
        public int cy;

        /// DWORD->unsigned int
        public uint style;

        /// LPARAM->LONG_PTR->int
        public int lParam;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMDICREATESTRUCTA
    {

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string szClass;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string szTitle;

        /// HANDLE->void*
        public IntPtr hOwner;

        /// int
        public int x;

        /// int
        public int y;

        /// int
        public int cx;

        /// int
        public int cy;

        /// DWORD->unsigned int
        public uint style;

        /// LPARAM->LONG_PTR->int
        public int lParam;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_WAVE_SET_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwTimeFormat;

        /// DWORD->unsigned int
        public uint dwAudio;

        /// UINT->unsigned int
        public uint wInput;

        /// UINT->unsigned int
        public uint wOutput;

        /// WORD->unsigned short
        public ushort wFormatTag;

        /// WORD->unsigned short
        public ushort wReserved2;

        /// WORD->unsigned short
        public ushort nChannels;

        /// WORD->unsigned short
        public ushort wReserved3;

        /// DWORD->unsigned int
        public uint nSamplesPerSec;

        /// DWORD->unsigned int
        public uint nAvgBytesPerSec;

        /// WORD->unsigned short
        public ushort nBlockAlign;

        /// WORD->unsigned short
        public ushort wReserved4;

        /// WORD->unsigned short
        public ushort wBitsPerSample;

        /// WORD->unsigned short
        public ushort wReserved5;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_WAVE_OPEN_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrDeviceType;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrElementName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrAlias;

        /// DWORD->unsigned int
        public uint dwBufferSeconds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_WAVE_OPEN_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrDeviceType;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrElementName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrAlias;

        /// DWORD->unsigned int
        public uint dwBufferSeconds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_WAVE_DELETE_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwFrom;

        /// DWORD->unsigned int
        public uint dwTo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_VD_STEP_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwFrames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_VD_PLAY_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwFrom;

        /// DWORD->unsigned int
        public uint dwTo;

        /// DWORD->unsigned int
        public uint dwSpeed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_VD_ESCAPE_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrCommand;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_VD_ESCAPE_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrCommand;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_SYSINFO_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrReturn;

        /// DWORD->unsigned int
        public uint dwRetSize;

        /// DWORD->unsigned int
        public uint dwNumber;

        /// UINT->unsigned int
        public uint wDeviceType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_SYSINFO_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrReturn;

        /// DWORD->unsigned int
        public uint dwRetSize;

        /// DWORD->unsigned int
        public uint dwNumber;

        /// UINT->unsigned int
        public uint wDeviceType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_STATUS_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwReturn;

        /// DWORD->unsigned int
        public uint dwItem;

        /// DWORD->unsigned int
        public uint dwTrack;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_SET_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwTimeFormat;

        /// DWORD->unsigned int
        public uint dwAudio;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_SEQ_SET_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwTimeFormat;

        /// DWORD->unsigned int
        public uint dwAudio;

        /// DWORD->unsigned int
        public uint dwTempo;

        /// DWORD->unsigned int
        public uint dwPort;

        /// DWORD->unsigned int
        public uint dwSlave;

        /// DWORD->unsigned int
        public uint dwMaster;

        /// DWORD->unsigned int
        public uint dwOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_SEEK_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwTo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_SAVE_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpfilename;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_SAVE_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpfilename;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_RECORD_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwFrom;

        /// DWORD->unsigned int
        public uint dwTo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_PLAY_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwFrom;

        /// DWORD->unsigned int
        public uint dwTo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_WINDOW_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint nCmdShow;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrText;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_WINDOW_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint nCmdShow;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrText;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_SAVE_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpfilename;

        /// RECT->tagRECT
        public tagRECT rc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_SAVE_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpfilename;

        /// RECT->tagRECT
        public tagRECT rc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_RECT_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// RECT->tagRECT
        public tagRECT rc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_OPEN_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrDeviceType;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrElementName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrAlias;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// HWND->HWND__*
        public IntPtr hWndParent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_OPEN_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrDeviceType;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrElementName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrAlias;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// HWND->HWND__*
        public IntPtr hWndParent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_LOAD_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpfilename;

        /// RECT->tagRECT
        public tagRECT rc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OVLY_LOAD_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpfilename;

        /// RECT->tagRECT
        public tagRECT rc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OPEN_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrDeviceType;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrElementName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrAlias;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_OPEN_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrDeviceType;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrElementName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrAlias;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_LOAD_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpfilename;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_LOAD_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpfilename;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_INFO_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrReturn;

        /// DWORD->unsigned int
        public uint dwRetSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_INFO_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrReturn;

        /// DWORD->unsigned int
        public uint dwRetSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_GETDEVCAPS_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwReturn;

        /// DWORD->unsigned int
        public uint dwItem;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_GENERIC_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_BREAK_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// int
        public int nVirtKey;

        /// HWND->HWND__*
        public IntPtr hwndBreak;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_WINDOW_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint nCmdShow;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrText;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_WINDOW_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// HWND->HWND__*
        public IntPtr hWnd;

        /// UINT->unsigned int
        public uint nCmdShow;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrText;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_UPDATE_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// RECT->tagRECT
        public tagRECT rc;

        /// HDC->HDC__*
        public IntPtr hDC;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_STEP_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwFrames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_RECT_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// RECT->tagRECT
        public tagRECT rc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_PLAY_PARMS
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// DWORD->unsigned int
        public uint dwFrom;

        /// DWORD->unsigned int
        public uint dwTo;

        /// DWORD->unsigned int
        public uint dwSpeed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_OPEN_PARMSW
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrDeviceType;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrElementName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrAlias;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// HWND->HWND__*
        public IntPtr hWndParent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMCI_ANIM_OPEN_PARMSA
    {

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwCallback;

        /// MCIDEVICEID->UINT->unsigned int
        public uint wDeviceID;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrDeviceType;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrElementName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrAlias;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// HWND->HWND__*
        public IntPtr hWndParent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOGPEN
    {

        /// UINT->unsigned int
        public uint lopnStyle;

        /// POINT->tagPOINT
        public Point lopnWidth;

        /// COLORREF->DWORD->unsigned int
        public uint lopnColor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOGPALETTE
    {

        /// WORD->unsigned short
        public ushort palVersion;

        /// WORD->unsigned short
        public ushort palNumEntries;

        /// PALETTEENTRY[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagPALETTEENTRY[] palPalEntry;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagLOGFONTW
    {

        /// LONG->int
        public int lfHeight;

        /// LONG->int
        public int lfWidth;

        /// LONG->int
        public int lfEscapement;

        /// LONG->int
        public int lfOrientation;

        /// LONG->int
        public int lfWeight;

        /// BYTE->unsigned char
        public byte lfItalic;

        /// BYTE->unsigned char
        public byte lfUnderline;

        /// BYTE->unsigned char
        public byte lfStrikeOut;

        /// BYTE->unsigned char
        public byte lfCharSet;

        /// BYTE->unsigned char
        public byte lfOutPrecision;

        /// BYTE->unsigned char
        public byte lfClipPrecision;

        /// BYTE->unsigned char
        public byte lfQuality;

        /// BYTE->unsigned char
        public byte lfPitchAndFamily;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string lfFaceName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagLOGFONTA
    {

        /// LONG->int
        public int lfHeight;

        /// LONG->int
        public int lfWidth;

        /// LONG->int
        public int lfEscapement;

        /// LONG->int
        public int lfOrientation;

        /// LONG->int
        public int lfWeight;

        /// BYTE->unsigned char
        public byte lfItalic;

        /// BYTE->unsigned char
        public byte lfUnderline;

        /// BYTE->unsigned char
        public byte lfStrikeOut;

        /// BYTE->unsigned char
        public byte lfCharSet;

        /// BYTE->unsigned char
        public byte lfOutPrecision;

        /// BYTE->unsigned char
        public byte lfClipPrecision;

        /// BYTE->unsigned char
        public byte lfQuality;

        /// BYTE->unsigned char
        public byte lfPitchAndFamily;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string lfFaceName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagLOGCOLORSPACEW
    {

        /// DWORD->unsigned int
        public uint lcsSignature;

        /// DWORD->unsigned int
        public uint lcsVersion;

        /// DWORD->unsigned int
        public uint lcsSize;

        /// LCSCSTYPE->LONG->int
        public int lcsCSType;

        /// LCSGAMUTMATCH->LONG->int
        public int lcsIntent;

        /// CIEXYZTRIPLE->tagICEXYZTRIPLE
        public tagICEXYZTRIPLE lcsEndpoints;

        /// DWORD->unsigned int
        public uint lcsGammaRed;

        /// DWORD->unsigned int
        public uint lcsGammaGreen;

        /// DWORD->unsigned int
        public uint lcsGammaBlue;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string lcsFilename;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagLOGCOLORSPACEA
    {

        /// DWORD->unsigned int
        public uint lcsSignature;

        /// DWORD->unsigned int
        public uint lcsVersion;

        /// DWORD->unsigned int
        public uint lcsSize;

        /// LCSCSTYPE->LONG->int
        public int lcsCSType;

        /// LCSGAMUTMATCH->LONG->int
        public int lcsIntent;

        /// CIEXYZTRIPLE->tagICEXYZTRIPLE
        public tagICEXYZTRIPLE lcsEndpoints;

        /// DWORD->unsigned int
        public uint lcsGammaRed;

        /// DWORD->unsigned int
        public uint lcsGammaGreen;

        /// DWORD->unsigned int
        public uint lcsGammaBlue;

        /// CHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string lcsFilename;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOGBRUSH32
    {

        /// UINT->unsigned int
        public uint lbStyle;

        /// COLORREF->DWORD->unsigned int
        public uint lbColor;

        /// ULONG->unsigned int
        public uint lbHatch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOGBRUSH
    {

        /// UINT->unsigned int
        public uint lbStyle;

        /// COLORREF->DWORD->unsigned int
        public uint lbColor;

        /// ULONG_PTR->unsigned int
        public uint lbHatch;
    }

    public enum tagLOCKTYPE
    {

        /// LOCK_WRITE -> 1
        LOCK_WRITE = 1,

        /// LOCK_EXCLUSIVE -> 2
        LOCK_EXCLUSIVE = 2,

        /// LOCK_ONLYONCE -> 4
        LOCK_ONLYONCE = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLOCALESIGNATURE
    {

        /// DWORD[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
        public uint[] lsUsb;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] lsCsbDefault;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] lsCsbSupported;
    }

    public enum tagLIBFLAGS
    {

        /// LIBFLAG_FRESTRICTED -> 0x1
        LIBFLAG_FRESTRICTED = 1,

        /// LIBFLAG_FCONTROL -> 0x2
        LIBFLAG_FCONTROL = 2,

        /// LIBFLAG_FHIDDEN -> 0x4
        LIBFLAG_FHIDDEN = 4,

        /// LIBFLAG_FHASDISKIMAGE -> 0x8
        LIBFLAG_FHASDISKIMAGE = 8,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLC_ID
    {

        /// unsigned short
        public ushort wLanguage;

        /// unsigned short
        public ushort wCountry;

        /// unsigned short
        public ushort wCodePage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLAYERPLANEDESCRIPTOR
    {

        /// WORD->unsigned short
        public ushort nSize;

        /// WORD->unsigned short
        public ushort nVersion;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// BYTE->unsigned char
        public byte iPixelType;

        /// BYTE->unsigned char
        public byte cColorBits;

        /// BYTE->unsigned char
        public byte cRedBits;

        /// BYTE->unsigned char
        public byte cRedShift;

        /// BYTE->unsigned char
        public byte cGreenBits;

        /// BYTE->unsigned char
        public byte cGreenShift;

        /// BYTE->unsigned char
        public byte cBlueBits;

        /// BYTE->unsigned char
        public byte cBlueShift;

        /// BYTE->unsigned char
        public byte cAlphaBits;

        /// BYTE->unsigned char
        public byte cAlphaShift;

        /// BYTE->unsigned char
        public byte cAccumBits;

        /// BYTE->unsigned char
        public byte cAccumRedBits;

        /// BYTE->unsigned char
        public byte cAccumGreenBits;

        /// BYTE->unsigned char
        public byte cAccumBlueBits;

        /// BYTE->unsigned char
        public byte cAccumAlphaBits;

        /// BYTE->unsigned char
        public byte cDepthBits;

        /// BYTE->unsigned char
        public byte cStencilBits;

        /// BYTE->unsigned char
        public byte cAuxBuffers;

        /// BYTE->unsigned char
        public byte iLayerPlane;

        /// BYTE->unsigned char
        public byte bReserved;

        /// COLORREF->DWORD->unsigned int
        public uint crTransparent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagLASTINPUTINFO
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagKEYBDINPUT
    {

        /// WORD->unsigned short
        public ushort wVk;

        /// WORD->unsigned short
        public ushort wScan;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint time;

        /// ULONG_PTR->unsigned int
        public uint dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagKERNINGPAIR
    {

        /// WORD->unsigned short
        public ushort wFirst;

        /// WORD->unsigned short
        public ushort wSecond;

        /// int
        public int iKernAmount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagKBDLLHOOKSTRUCT
    {

        /// DWORD->unsigned int
        public uint vkCode;

        /// DWORD->unsigned int
        public uint scanCode;

        /// DWORD->unsigned int
        public uint flags;

        /// DWORD->unsigned int
        public uint time;

        /// ULONG_PTR->unsigned int
        public uint dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagJOYCAPSW
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// UINT->unsigned int
        public uint wXmin;

        /// UINT->unsigned int
        public uint wXmax;

        /// UINT->unsigned int
        public uint wYmin;

        /// UINT->unsigned int
        public uint wYmax;

        /// UINT->unsigned int
        public uint wZmin;

        /// UINT->unsigned int
        public uint wZmax;

        /// UINT->unsigned int
        public uint wNumButtons;

        /// UINT->unsigned int
        public uint wPeriodMin;

        /// UINT->unsigned int
        public uint wPeriodMax;

        /// UINT->unsigned int
        public uint wRmin;

        /// UINT->unsigned int
        public uint wRmax;

        /// UINT->unsigned int
        public uint wUmin;

        /// UINT->unsigned int
        public uint wUmax;

        /// UINT->unsigned int
        public uint wVmin;

        /// UINT->unsigned int
        public uint wVmax;

        /// UINT->unsigned int
        public uint wCaps;

        /// UINT->unsigned int
        public uint wMaxAxes;

        /// UINT->unsigned int
        public uint wNumAxes;

        /// UINT->unsigned int
        public uint wMaxButtons;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szRegKey;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szOEMVxD;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagJOYCAPSA
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// UINT->unsigned int
        public uint wXmin;

        /// UINT->unsigned int
        public uint wXmax;

        /// UINT->unsigned int
        public uint wYmin;

        /// UINT->unsigned int
        public uint wYmax;

        /// UINT->unsigned int
        public uint wZmin;

        /// UINT->unsigned int
        public uint wZmax;

        /// UINT->unsigned int
        public uint wNumButtons;

        /// UINT->unsigned int
        public uint wPeriodMin;

        /// UINT->unsigned int
        public uint wPeriodMax;

        /// UINT->unsigned int
        public uint wRmin;

        /// UINT->unsigned int
        public uint wRmax;

        /// UINT->unsigned int
        public uint wUmin;

        /// UINT->unsigned int
        public uint wUmax;

        /// UINT->unsigned int
        public uint wVmin;

        /// UINT->unsigned int
        public uint wVmax;

        /// UINT->unsigned int
        public uint wCaps;

        /// UINT->unsigned int
        public uint wMaxAxes;

        /// UINT->unsigned int
        public uint wNumAxes;

        /// UINT->unsigned int
        public uint wMaxButtons;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szRegKey;

        /// CHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szOEMVxD;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagJOYCAPS2W
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// UINT->unsigned int
        public uint wXmin;

        /// UINT->unsigned int
        public uint wXmax;

        /// UINT->unsigned int
        public uint wYmin;

        /// UINT->unsigned int
        public uint wYmax;

        /// UINT->unsigned int
        public uint wZmin;

        /// UINT->unsigned int
        public uint wZmax;

        /// UINT->unsigned int
        public uint wNumButtons;

        /// UINT->unsigned int
        public uint wPeriodMin;

        /// UINT->unsigned int
        public uint wPeriodMax;

        /// UINT->unsigned int
        public uint wRmin;

        /// UINT->unsigned int
        public uint wRmax;

        /// UINT->unsigned int
        public uint wUmin;

        /// UINT->unsigned int
        public uint wUmax;

        /// UINT->unsigned int
        public uint wVmin;

        /// UINT->unsigned int
        public uint wVmax;

        /// UINT->unsigned int
        public uint wCaps;

        /// UINT->unsigned int
        public uint wMaxAxes;

        /// UINT->unsigned int
        public uint wNumAxes;

        /// UINT->unsigned int
        public uint wMaxButtons;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szRegKey;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szOEMVxD;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagJOYCAPS2A
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// UINT->unsigned int
        public uint wXmin;

        /// UINT->unsigned int
        public uint wXmax;

        /// UINT->unsigned int
        public uint wYmin;

        /// UINT->unsigned int
        public uint wYmax;

        /// UINT->unsigned int
        public uint wZmin;

        /// UINT->unsigned int
        public uint wZmax;

        /// UINT->unsigned int
        public uint wNumButtons;

        /// UINT->unsigned int
        public uint wPeriodMin;

        /// UINT->unsigned int
        public uint wPeriodMax;

        /// UINT->unsigned int
        public uint wRmin;

        /// UINT->unsigned int
        public uint wRmax;

        /// UINT->unsigned int
        public uint wUmin;

        /// UINT->unsigned int
        public uint wUmax;

        /// UINT->unsigned int
        public uint wVmin;

        /// UINT->unsigned int
        public uint wVmax;

        /// UINT->unsigned int
        public uint wCaps;

        /// UINT->unsigned int
        public uint wMaxAxes;

        /// UINT->unsigned int
        public uint wNumAxes;

        /// UINT->unsigned int
        public uint wMaxButtons;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szRegKey;

        /// CHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szOEMVxD;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagI_RpcProxyCallbackInterface
    {

        /// I_RpcProxyIsValidMachineFn
        public I_RpcProxyIsValidMachineFn IsValidMachineFn;

        /// I_RpcProxyGetClientAddressFn
        public I_RpcProxyGetClientAddressFn GetClientAddressFn;

        /// I_RpcProxyGetConnectionTimeoutFn
        public I_RpcProxyGetConnectionTimeoutFn GetConnectionTimeoutFn;

        /// I_RpcPerformCalloutFn
        public I_RpcPerformCalloutFn PerformCalloutFn;

        /// I_RpcFreeCalloutStateFn
        public I_RpcFreeCalloutStateFn FreeCalloutStateFn;
    }

    public enum tagINVOKEKIND
    {

        /// INVOKE_FUNC -> 1
        INVOKE_FUNC = 1,

        /// INVOKE_PROPERTYGET -> 2
        INVOKE_PROPERTYGET = 2,

        /// INVOKE_PROPERTYPUT -> 4
        INVOKE_PROPERTYPUT = 4,

        /// INVOKE_PROPERTYPUTREF -> 8
        INVOKE_PROPERTYPUTREF = 8,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagINTERFACEINFO
    {

        /// IUnknown*
        public IntPtr pUnk;

        /// IID->GUID->_GUID
        public GUID iid;

        /// WORD->unsigned short
        public ushort wMethod;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagINTERFACEDATA
    {

        /// METHODDATA*
        public IntPtr pmethdata;

        /// UINT->unsigned int
        public uint cMembers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagINPUT
    {

        /// DWORD->unsigned int
        public uint type;

        /// Anonymous_dccf47da_5155_438b_92bc_41adbefe840c
        public Anonymous_dccf47da_5155_438b_92bc_41adbefe840c Union1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagIMEMENUITEMINFOW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint fType;

        /// UINT->unsigned int
        public uint fState;

        /// UINT->unsigned int
        public uint wID;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpChecked;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpUnchecked;

        /// DWORD->unsigned int
        public uint dwItemData;

        /// WCHAR[80]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szString;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpItem;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagIMEMENUITEMINFOA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// UINT->unsigned int
        public uint fType;

        /// UINT->unsigned int
        public uint fState;

        /// UINT->unsigned int
        public uint wID;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpChecked;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpUnchecked;

        /// DWORD->unsigned int
        public uint dwItemData;

        /// CHAR[80]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szString;

        /// HBITMAP->HBITMAP__*
        public IntPtr hbmpItem;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagIMECHARPOSITION
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwCharPos;

        /// POINT->tagPOINT
        public Point pt;

        /// UINT->unsigned int
        public uint cLineHeight;

        /// RECT->tagRECT
        public tagRECT rcDocument;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagIDLDESC
    {

        /// ULONG_PTR->unsigned int
        public uint dwReserved;

        /// USHORT->unsigned short
        public ushort wIDLFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagICONMETRICSW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iHorzSpacing;

        /// int
        public int iVertSpacing;

        /// int
        public int iTitleWrap;

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW lfFont;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagICONMETRICSA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iHorzSpacing;

        /// int
        public int iVertSpacing;

        /// int
        public int iTitleWrap;

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA lfFont;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagICEXYZTRIPLE
    {

        /// CIEXYZ->tagCIEXYZ
        public tagCIEXYZ ciexyzRed;

        /// CIEXYZ->tagCIEXYZ
        public tagCIEXYZ ciexyzGreen;

        /// CIEXYZ->tagCIEXYZ
        public tagCIEXYZ ciexyzBlue;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagHW_PROFILE_INFOW
    {

        /// DWORD->unsigned int
        public uint dwDockInfo;

        /// WCHAR[39]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 39)]
        public string szHwProfileGuid;

        /// WCHAR[80]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szHwProfileName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagHW_PROFILE_INFOA
    {

        /// DWORD->unsigned int
        public uint dwDockInfo;

        /// CHAR[39]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 39)]
        public string szHwProfileGuid;

        /// CHAR[80]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szHwProfileName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagHSZPAIR
    {

        /// HSZ->HSZ__*
        public IntPtr hszSvc;

        /// HSZ->HSZ__*
        public IntPtr hszTopic;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagHIGHCONTRASTW
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszDefaultScheme;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagHIGHCONTRASTA
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszDefaultScheme;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagHELPWININFOW
    {

        /// int
        public int wStructSize;

        /// int
        public int x;

        /// int
        public int y;

        /// int
        public int dx;

        /// int
        public int dy;

        /// int
        public int wMax;

        /// WCHAR[2]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string rgchMember;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagHELPWININFOA
    {

        /// int
        public int wStructSize;

        /// int
        public int x;

        /// int
        public int y;

        /// int
        public int dx;

        /// int
        public int dy;

        /// int
        public int wMax;

        /// CHAR[2]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string rgchMember;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagHELPINFO
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iContextType;

        /// int
        public int iCtrlId;

        /// HANDLE->void*
        public IntPtr hItemHandle;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwContextId;

        /// POINT->tagPOINT
        public Point MousePos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagHARDWAREINPUT
    {

        /// DWORD->unsigned int
        public uint uMsg;

        /// WORD->unsigned short
        public ushort wParamL;

        /// WORD->unsigned short
        public ushort wParamH;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagHARDWAREHOOKSTRUCT
    {

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// UINT->unsigned int
        public uint message;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;

        /// LPARAM->LONG_PTR->int
        public int lParam;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagHANDLETABLE
    {

        /// HGDIOBJ[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.SysUInt)]
        public IntPtr[] objectHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagGUITHREADINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint flags;

        /// HWND->HWND__*
        public IntPtr hwndActive;

        /// HWND->HWND__*
        public IntPtr hwndFocus;

        /// HWND->HWND__*
        public IntPtr hwndCapture;

        /// HWND->HWND__*
        public IntPtr hwndMenuOwner;

        /// HWND->HWND__*
        public IntPtr hwndMoveSize;

        /// HWND->HWND__*
        public IntPtr hwndCaret;

        /// RECT->tagRECT
        public tagRECT rcCaret;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagGLYPHSET
    {

        /// DWORD->unsigned int
        public uint cbThis;

        /// DWORD->unsigned int
        public uint flAccel;

        /// DWORD->unsigned int
        public uint cGlyphsSupported;

        /// DWORD->unsigned int
        public uint cRanges;

        /// WCRANGE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagWCRANGE[] ranges;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagGCP_RESULTSW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpOutString;

        /// UINT*
        public IntPtr lpOrder;

        /// int*
        public IntPtr lpDx;

        /// int*
        public IntPtr lpCaretPos;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpClass;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpGlyphs;

        /// UINT->unsigned int
        public uint nGlyphs;

        /// int
        public int nMaxFit;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagGCP_RESULTSA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpOutString;

        /// UINT*
        public IntPtr lpOrder;

        /// int*
        public IntPtr lpDx;

        /// int*
        public IntPtr lpCaretPos;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpClass;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpGlyphs;

        /// UINT->unsigned int
        public uint nGlyphs;

        /// int
        public int nMaxFit;
    }

    public enum tagFUNCKIND
    {

        /// FUNC_VIRTUAL -> 0
        FUNC_VIRTUAL = 0,

        /// FUNC_PUREVIRTUAL -> FUNC_VIRTUAL+1
        FUNC_PUREVIRTUAL = (tagFUNCKIND.FUNC_VIRTUAL + 1),

        /// FUNC_NONVIRTUAL -> FUNC_PUREVIRTUAL+1
        FUNC_NONVIRTUAL = (tagFUNCKIND.FUNC_PUREVIRTUAL + 1),

        /// FUNC_STATIC -> FUNC_NONVIRTUAL+1
        FUNC_STATIC = (tagFUNCKIND.FUNC_NONVIRTUAL + 1),

        /// FUNC_DISPATCH -> FUNC_STATIC+1
        FUNC_DISPATCH = (tagFUNCKIND.FUNC_STATIC + 1),
    }

    public enum tagFUNCFLAGS
    {

        /// FUNCFLAG_FRESTRICTED -> 0x1
        FUNCFLAG_FRESTRICTED = 1,

        /// FUNCFLAG_FSOURCE -> 0x2
        FUNCFLAG_FSOURCE = 2,

        /// FUNCFLAG_FBINDABLE -> 0x4
        FUNCFLAG_FBINDABLE = 4,

        /// FUNCFLAG_FREQUESTEDIT -> 0x8
        FUNCFLAG_FREQUESTEDIT = 8,

        /// FUNCFLAG_FDISPLAYBIND -> 0x10
        FUNCFLAG_FDISPLAYBIND = 16,

        /// FUNCFLAG_FDEFAULTBIND -> 0x20
        FUNCFLAG_FDEFAULTBIND = 32,

        /// FUNCFLAG_FHIDDEN -> 0x40
        FUNCFLAG_FHIDDEN = 64,

        /// FUNCFLAG_FUSESGETLASTERROR -> 0x80
        FUNCFLAG_FUSESGETLASTERROR = 128,

        /// FUNCFLAG_FDEFAULTCOLLELEM -> 0x100
        FUNCFLAG_FDEFAULTCOLLELEM = 256,

        /// FUNCFLAG_FUIDEFAULT -> 0x200
        FUNCFLAG_FUIDEFAULT = 512,

        /// FUNCFLAG_FNONBROWSABLE -> 0x400
        FUNCFLAG_FNONBROWSABLE = 1024,

        /// FUNCFLAG_FREPLACEABLE -> 0x800
        FUNCFLAG_FREPLACEABLE = 2048,

        /// FUNCFLAG_FIMMEDIATEBIND -> 0x1000
        FUNCFLAG_FIMMEDIATEBIND = 4096,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagFUNCDESC
    {

        /// MEMBERID->DISPID->LONG->int
        public int memid;

        /// SCODE*
        public IntPtr lprgscode;

        /// ELEMDESC*
        public IntPtr lprgelemdescParam;

        /// FUNCKIND->tagFUNCKIND
        public tagFUNCKIND funckind;

        /// INVOKEKIND->tagINVOKEKIND
        public tagINVOKEKIND invkind;

        /// CALLCONV->tagCALLCONV
        public tagCALLCONV callconv;

        /// SHORT->short
        public short cParams;

        /// SHORT->short
        public short cParamsOpt;

        /// SHORT->short
        public short oVft;

        /// SHORT->short
        public short cScodes;

        /// ELEMDESC->tagELEMDESC
        public tagELEMDESC elemdescFunc;

        /// WORD->unsigned short
        public ushort wFuncFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagFORMATETC
    {

        /// CLIPFORMAT->WORD->unsigned short
        public ushort cfFormat;

        /// DVTARGETDEVICE*
        public IntPtr ptd;

        /// DWORD->unsigned int
        public uint dwAspect;

        /// LONG->int
        public int lindex;

        /// DWORD->unsigned int
        public uint tymed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagFONTSIGNATURE
    {

        /// DWORD[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
        public uint[] fsUsb;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] fsCsb;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagFINDREPLACEW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// DWORD->unsigned int
        public uint Flags;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrFindWhat;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrReplaceWith;

        /// WORD->unsigned short
        public ushort wFindWhatLen;

        /// WORD->unsigned short
        public ushort wReplaceWithLen;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPFRHOOKPROC
        public LPFRHOOKPROC lpfnHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpTemplateName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagFINDREPLACEA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// DWORD->unsigned int
        public uint Flags;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrFindWhat;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrReplaceWith;

        /// WORD->unsigned short
        public ushort wFindWhatLen;

        /// WORD->unsigned short
        public ushort wReplaceWithLen;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPFRHOOKPROC
        public LPFRHOOKPROC lpfnHook;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpTemplateName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagFILTERKEYS
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint iWaitMSec;

        /// DWORD->unsigned int
        public uint iDelayMSec;

        /// DWORD->unsigned int
        public uint iRepeatMSec;

        /// DWORD->unsigned int
        public uint iBounceMSec;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEXTLOGPEN
    {

        /// DWORD->unsigned int
        public uint elpPenStyle;

        /// DWORD->unsigned int
        public uint elpWidth;

        /// UINT->unsigned int
        public uint elpBrushStyle;

        /// COLORREF->DWORD->unsigned int
        public uint elpColor;

        /// ULONG_PTR->unsigned int
        public uint elpHatch;

        /// DWORD->unsigned int
        public uint elpNumEntries;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] elpStyleEntry;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagEXTLOGFONTW
    {

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW elfLogFont;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string elfFullName;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfStyle;

        /// DWORD->unsigned int
        public uint elfVersion;

        /// DWORD->unsigned int
        public uint elfStyleSize;

        /// DWORD->unsigned int
        public uint elfMatch;

        /// DWORD->unsigned int
        public uint elfReserved;

        /// BYTE[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
        public byte[] elfVendorId;

        /// DWORD->unsigned int
        public uint elfCulture;

        /// PANOSE->tagPANOSE
        public tagPANOSE elfPanose;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEXTLOGFONTA
    {

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA elfLogFont;

        /// BYTE[64]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
        public byte[] elfFullName;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] elfStyle;

        /// DWORD->unsigned int
        public uint elfVersion;

        /// DWORD->unsigned int
        public uint elfStyleSize;

        /// DWORD->unsigned int
        public uint elfMatch;

        /// DWORD->unsigned int
        public uint elfReserved;

        /// BYTE[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
        public byte[] elfVendorId;

        /// DWORD->unsigned int
        public uint elfCulture;

        /// PANOSE->tagPANOSE
        public tagPANOSE elfPanose;
    }

    public enum tagExtendedErrorParamTypes
    {

        /// eeptAnsiString -> 1
        eeptAnsiString = 1,

        eeptUnicodeString,

        eeptLongVal,

        eeptShortVal,

        eeptPointerVal,

        eeptNone,

        eeptBinary,
    }

    public enum tagEXTCONN
    {

        /// EXTCONN_STRONG -> 0x1
        EXTCONN_STRONG = 1,

        /// EXTCONN_WEAK -> 0x2
        EXTCONN_WEAK = 2,

        /// EXTCONN_CALLABLE -> 0x4
        EXTCONN_CALLABLE = 4,
    }

    /// Return Type: HRESULT->LONG->int
    ///param0: tagEXCEPINFO*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int tagEXCEPINFO_pfnDeferredFillIn(ref tagEXCEPINFO param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEXCEPINFO
    {

        /// WORD->unsigned short
        public ushort wCode;

        /// WORD->unsigned short
        public ushort wReserved;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string bstrSource;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string bstrDescription;

        /// BSTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string bstrHelpFile;

        /// DWORD->unsigned int
        public uint dwHelpContext;

        /// PVOID->void*
        public IntPtr pvReserved;

        /// tagEXCEPINFO_pfnDeferredFillIn
        public tagEXCEPINFO_pfnDeferredFillIn AnonymousMember1;

        /// SCODE->LONG->int
        public int scode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEVENTMSG
    {

        /// UINT->unsigned int
        public uint message;

        /// UINT->unsigned int
        public uint paramL;

        /// UINT->unsigned int
        public uint paramH;

        /// DWORD->unsigned int
        public uint time;

        /// HWND->HWND__*
        public IntPtr hwnd;
    }

    public enum tagEOLE_AUTHENTICATION_CAPABILITIES
    {

        /// EOAC_NONE -> 0
        EOAC_NONE = 0,

        /// EOAC_MUTUAL_AUTH -> 0x1
        EOAC_MUTUAL_AUTH = 1,

        /// EOAC_STATIC_CLOAKING -> 0x20
        EOAC_STATIC_CLOAKING = 32,

        /// EOAC_DYNAMIC_CLOAKING -> 0x40
        EOAC_DYNAMIC_CLOAKING = 64,

        /// EOAC_ANY_AUTHORITY -> 0x80
        EOAC_ANY_AUTHORITY = 128,

        /// EOAC_MAKE_FULLSIC -> 0x100
        EOAC_MAKE_FULLSIC = 256,

        /// EOAC_DEFAULT -> 0x800
        EOAC_DEFAULT = 2048,

        /// EOAC_SECURE_REFS -> 0x2
        EOAC_SECURE_REFS = 2,

        /// EOAC_ACCESS_CONTROL -> 0x4
        EOAC_ACCESS_CONTROL = 4,

        /// EOAC_APPID -> 0x8
        EOAC_APPID = 8,

        /// EOAC_DYNAMIC -> 0x10
        EOAC_DYNAMIC = 16,

        /// EOAC_REQUIRE_FULLSIC -> 0x200
        EOAC_REQUIRE_FULLSIC = 512,

        /// EOAC_AUTO_IMPERSONATE -> 0x400
        EOAC_AUTO_IMPERSONATE = 1024,

        /// EOAC_NO_CUSTOM_MARSHAL -> 0x2000
        EOAC_NO_CUSTOM_MARSHAL = 8192,

        /// EOAC_DISABLE_AAA -> 0x1000
        EOAC_DISABLE_AAA = 4096,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENUMTEXTMETRICW
    {

        /// NEWTEXTMETRICEXW->tagNEWTEXTMETRICEXW
        public tagNEWTEXTMETRICEXW etmNewTextMetricEx;

        /// AXESLISTW->tagAXESLISTW
        public tagAXESLISTW etmAxesList;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENUMTEXTMETRICA
    {

        /// NEWTEXTMETRICEXA->tagNEWTEXTMETRICEXA
        public tagNEWTEXTMETRICEXA etmNewTextMetricEx;

        /// AXESLISTA->tagAXESLISTA
        public tagAXESLISTA etmAxesList;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagENUMLOGFONTW
    {

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW elfLogFont;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string elfFullName;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfStyle;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagENUMLOGFONTEXW
    {

        /// LOGFONTW->tagLOGFONTW
        public tagLOGFONTW elfLogFont;

        /// WCHAR[64]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string elfFullName;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfStyle;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfScript;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENUMLOGFONTEXDVW
    {

        /// ENUMLOGFONTEXW->tagENUMLOGFONTEXW
        public tagENUMLOGFONTEXW elfEnumLogfontEx;

        /// DESIGNVECTOR->tagDESIGNVECTOR
        public tagDESIGNVECTOR elfDesignVector;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENUMLOGFONTEXDVA
    {

        /// ENUMLOGFONTEXA->tagENUMLOGFONTEXA
        public tagENUMLOGFONTEXA elfEnumLogfontEx;

        /// DESIGNVECTOR->tagDESIGNVECTOR
        public tagDESIGNVECTOR elfDesignVector;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENUMLOGFONTEXA
    {

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA elfLogFont;

        /// BYTE[64]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
        public byte[] elfFullName;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] elfStyle;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] elfScript;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENUMLOGFONTA
    {

        /// LOGFONTA->tagLOGFONTA
        public tagLOGFONTA elfLogFont;

        /// BYTE[64]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
        public byte[] elfFullName;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] elfStyle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENHMETARECORD
    {

        /// DWORD->unsigned int
        public uint iType;

        /// DWORD->unsigned int
        public uint nSize;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] dParm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagENHMETAHEADER
    {

        /// DWORD->unsigned int
        public uint iType;

        /// DWORD->unsigned int
        public uint nSize;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// RECTL->_RECTL
        public RECTL rclFrame;

        /// DWORD->unsigned int
        public uint dSignature;

        /// DWORD->unsigned int
        public uint nVersion;

        /// DWORD->unsigned int
        public uint nBytes;

        /// DWORD->unsigned int
        public uint nRecords;

        /// WORD->unsigned short
        public ushort nHandles;

        /// WORD->unsigned short
        public ushort sReserved;

        /// DWORD->unsigned int
        public uint nDescription;

        /// DWORD->unsigned int
        public uint offDescription;

        /// DWORD->unsigned int
        public uint nPalEntries;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE szlDevice;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE szlMillimeters;

        /// DWORD->unsigned int
        public uint cbPixelFormat;

        /// DWORD->unsigned int
        public uint offPixelFormat;

        /// DWORD->unsigned int
        public uint bOpenGL;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE szlMicrometers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRTRANSPARENTBLT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// LONG->int
        public int xDest;

        /// LONG->int
        public int yDest;

        /// LONG->int
        public int cxDest;

        /// LONG->int
        public int cyDest;

        /// DWORD->unsigned int
        public uint dwRop;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// XFORM->tagXFORM
        public tagXFORM xformSrc;

        /// COLORREF->DWORD->unsigned int
        public uint crBkColorSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;

        /// LONG->int
        public int cxSrc;

        /// LONG->int
        public int cySrc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRTEXT
    {

        /// POINTL->_POINTL
        public POINTL ptlReference;

        /// DWORD->unsigned int
        public uint nChars;

        /// DWORD->unsigned int
        public uint offString;

        /// DWORD->unsigned int
        public uint fOptions;

        /// RECTL->_RECTL
        public RECTL rcl;

        /// DWORD->unsigned int
        public uint offDx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSTRETCHDIBITS
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// LONG->int
        public int xDest;

        /// LONG->int
        public int yDest;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// LONG->int
        public int cxSrc;

        /// LONG->int
        public int cySrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint dwRop;

        /// LONG->int
        public int cxDest;

        /// LONG->int
        public int cyDest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSTRETCHBLT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// LONG->int
        public int xDest;

        /// LONG->int
        public int yDest;

        /// LONG->int
        public int cxDest;

        /// LONG->int
        public int cyDest;

        /// DWORD->unsigned int
        public uint dwRop;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// XFORM->tagXFORM
        public tagXFORM xformSrc;

        /// COLORREF->DWORD->unsigned int
        public uint crBkColorSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;

        /// LONG->int
        public int cxSrc;

        /// LONG->int
        public int cySrc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETWORLDTRANSFORM
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// XFORM->tagXFORM
        public tagXFORM xform;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETVIEWPORTORGEX
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// POINTL->_POINTL
        public POINTL ptlOrigin;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETVIEWPORTEXTEX
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE szlExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETTEXTCOLOR
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// COLORREF->DWORD->unsigned int
        public uint crColor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETPIXELV
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// POINTL->_POINTL
        public POINTL ptlPixel;

        /// COLORREF->DWORD->unsigned int
        public uint crColor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETPALETTEENTRIES
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihPal;

        /// DWORD->unsigned int
        public uint iStart;

        /// DWORD->unsigned int
        public uint cEntries;

        /// PALETTEENTRY[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagPALETTEENTRY[] aPalEntries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETMITERLIMIT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// FLOAT->float
        public float eMiterLimit;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETMAPPERFLAGS
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETICMPROFILE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint cbName;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETDIBITSTODEVICE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// LONG->int
        public int xDest;

        /// LONG->int
        public int yDest;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// LONG->int
        public int cxSrc;

        /// LONG->int
        public int cySrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint iStartScan;

        /// DWORD->unsigned int
        public uint cScans;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETCOLORSPACE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihCS;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETCOLORADJUSTMENT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// COLORADJUSTMENT->tagCOLORADJUSTMENT
        public tagCOLORADJUSTMENT ColorAdjustment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSETARCDIRECTION
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint iArcDirection;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSELECTPALETTE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihPal;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSELECTOBJECT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihObject;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSELECTCLIPPATH
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint iMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRSCALEVIEWPORTEXTEX
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// LONG->int
        public int xNum;

        /// LONG->int
        public int xDenom;

        /// LONG->int
        public int yNum;

        /// LONG->int
        public int yDenom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRROUNDRECT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBox;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE szlCorner;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRRESTOREDC
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// LONG->int
        public int iRelative;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRRESIZEPALETTE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihPal;

        /// DWORD->unsigned int
        public uint cEntries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPOLYTEXTOUTA
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint iGraphicsMode;

        /// FLOAT->float
        public float exScale;

        /// FLOAT->float
        public float eyScale;

        /// LONG->int
        public int cStrings;

        /// EMRTEXT[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagEMRTEXT[] aemrtext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPOLYPOLYLINE16
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint nPolys;

        /// DWORD->unsigned int
        public uint cpts;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] aPolyCounts;

        /// POINTS[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagPOINTS[] apts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPOLYPOLYLINE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint nPolys;

        /// DWORD->unsigned int
        public uint cptl;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] aPolyCounts;

        /// POINTL[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public POINTL[] aptl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPOLYLINE16
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cpts;

        /// POINTS[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagPOINTS[] apts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPOLYLINE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cptl;

        /// POINTL[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public POINTL[] aptl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPOLYDRAW16
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cpts;

        /// POINTS[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagPOINTS[] apts;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] abTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPOLYDRAW
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cptl;

        /// POINTL[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public POINTL[] aptl;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] abTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPLGBLT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// POINTL[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
        public POINTL[] aptlDest;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// LONG->int
        public int cxSrc;

        /// LONG->int
        public int cySrc;

        /// XFORM->tagXFORM
        public tagXFORM xformSrc;

        /// COLORREF->DWORD->unsigned int
        public uint crBkColorSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;

        /// LONG->int
        public int xMask;

        /// LONG->int
        public int yMask;

        /// DWORD->unsigned int
        public uint iUsageMask;

        /// DWORD->unsigned int
        public uint offBmiMask;

        /// DWORD->unsigned int
        public uint cbBmiMask;

        /// DWORD->unsigned int
        public uint offBitsMask;

        /// DWORD->unsigned int
        public uint cbBitsMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRPIXELFORMAT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// PIXELFORMATDESCRIPTOR->tagPIXELFORMATDESCRIPTOR
        public tagPIXELFORMATDESCRIPTOR pfd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMROFFSETCLIPRGN
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// POINTL->_POINTL
        public POINTL ptlOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRNAMEDESCAPE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// INT->int
        public int iEscape;

        /// INT->int
        public int cbDriver;

        /// INT->int
        public int cbEscData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] EscData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRMODIFYWORLDTRANSFORM
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// XFORM->tagXFORM
        public tagXFORM xform;

        /// DWORD->unsigned int
        public uint iMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRMASKBLT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// LONG->int
        public int xDest;

        /// LONG->int
        public int yDest;

        /// LONG->int
        public int cxDest;

        /// LONG->int
        public int cyDest;

        /// DWORD->unsigned int
        public uint dwRop;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// XFORM->tagXFORM
        public tagXFORM xformSrc;

        /// COLORREF->DWORD->unsigned int
        public uint crBkColorSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;

        /// LONG->int
        public int xMask;

        /// LONG->int
        public int yMask;

        /// DWORD->unsigned int
        public uint iUsageMask;

        /// DWORD->unsigned int
        public uint offBmiMask;

        /// DWORD->unsigned int
        public uint cbBmiMask;

        /// DWORD->unsigned int
        public uint offBitsMask;

        /// DWORD->unsigned int
        public uint cbBitsMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRLINETO
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// POINTL->_POINTL
        public POINTL ptl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRINVERTRGN
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cbRgnData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] RgnData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRGRADIENTFILL
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint nVer;

        /// DWORD->unsigned int
        public uint nTri;

        /// ULONG->unsigned int
        public uint ulMode;

        /// TRIVERTEX[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public TRIVERTEX[] Ver;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRGLSRECORD
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRGLSBOUNDEDRECORD
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRGDICOMMENT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRFRAMERGN
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cbRgnData;

        /// DWORD->unsigned int
        public uint ihBrush;

        /// SIZEL->SIZE->tagSIZE
        public tagSIZE szlStroke;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] RgnData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRFORMAT
    {

        /// DWORD->unsigned int
        public uint dSignature;

        /// DWORD->unsigned int
        public uint nVersion;

        /// DWORD->unsigned int
        public uint cbData;

        /// DWORD->unsigned int
        public uint offData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRFILLRGN
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint cbRgnData;

        /// DWORD->unsigned int
        public uint ihBrush;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] RgnData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRFILLPATH
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREXTTEXTOUTA
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// DWORD->unsigned int
        public uint iGraphicsMode;

        /// FLOAT->float
        public float exScale;

        /// FLOAT->float
        public float eyScale;

        /// EMRTEXT->tagEMRTEXT
        public tagEMRTEXT emrtext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREXTSELECTCLIPRGN
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint cbRgnData;

        /// DWORD->unsigned int
        public uint iMode;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] RgnData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREXTFLOODFILL
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// POINTL->_POINTL
        public POINTL ptlStart;

        /// COLORREF->DWORD->unsigned int
        public uint crColor;

        /// DWORD->unsigned int
        public uint iMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREXTESCAPE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// INT->int
        public int iEscape;

        /// INT->int
        public int cbEscData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] EscData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREXTCREATEPEN
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihPen;

        /// DWORD->unsigned int
        public uint offBmi;

        /// DWORD->unsigned int
        public uint cbBmi;

        /// DWORD->unsigned int
        public uint offBits;

        /// DWORD->unsigned int
        public uint cbBits;

        /// EXTLOGPEN->tagEXTLOGPEN
        public tagEXTLOGPEN elp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREXTCREATEFONTINDIRECTW
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihFont;

        /// EXTLOGFONTW->tagEXTLOGFONTW
        public tagEXTLOGFONTW elfw;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREXCLUDECLIPRECT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclClip;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMREOF
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint nPalEntries;

        /// DWORD->unsigned int
        public uint offPalEntries;

        /// DWORD->unsigned int
        public uint nSizeLast;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRELLIPSE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBox;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRCREATEPEN
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihPen;

        /// LOGPEN->tagLOGPEN
        public tagLOGPEN lopn;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRCREATEPALETTE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihPal;

        /// LOGPALETTE->tagLOGPALETTE
        public tagLOGPALETTE lgpl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRCREATEMONOBRUSH
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihBrush;

        /// DWORD->unsigned int
        public uint iUsage;

        /// DWORD->unsigned int
        public uint offBmi;

        /// DWORD->unsigned int
        public uint cbBmi;

        /// DWORD->unsigned int
        public uint offBits;

        /// DWORD->unsigned int
        public uint cbBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRCREATEDIBPATTERNBRUSHPT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihBrush;

        /// DWORD->unsigned int
        public uint iUsage;

        /// DWORD->unsigned int
        public uint offBmi;

        /// DWORD->unsigned int
        public uint cbBmi;

        /// DWORD->unsigned int
        public uint offBits;

        /// DWORD->unsigned int
        public uint cbBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRCREATECOLORSPACEW
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihCS;

        /// LOGCOLORSPACEW->tagLOGCOLORSPACEW
        public tagLOGCOLORSPACEW lcs;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRCREATECOLORSPACE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihCS;

        /// LOGCOLORSPACEA->tagLOGCOLORSPACEA
        public tagLOGCOLORSPACEA lcs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRCREATEBRUSHINDIRECT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihBrush;

        /// LOGBRUSH32->tagLOGBRUSH32
        public tagLOGBRUSH32 lb;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRBITBLT
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// LONG->int
        public int xDest;

        /// LONG->int
        public int yDest;

        /// LONG->int
        public int cxDest;

        /// LONG->int
        public int cyDest;

        /// DWORD->unsigned int
        public uint dwRop;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// XFORM->tagXFORM
        public tagXFORM xformSrc;

        /// COLORREF->DWORD->unsigned int
        public uint crBkColorSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRARC
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBox;

        /// POINTL->_POINTL
        public POINTL ptlStart;

        /// POINTL->_POINTL
        public POINTL ptlEnd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRANGLEARC
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// POINTL->_POINTL
        public POINTL ptlCenter;

        /// DWORD->unsigned int
        public uint nRadius;

        /// FLOAT->float
        public float eStartAngle;

        /// FLOAT->float
        public float eSweepAngle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMRALPHABLEND
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// RECTL->_RECTL
        public RECTL rclBounds;

        /// LONG->int
        public int xDest;

        /// LONG->int
        public int yDest;

        /// LONG->int
        public int cxDest;

        /// LONG->int
        public int cyDest;

        /// DWORD->unsigned int
        public uint dwRop;

        /// LONG->int
        public int xSrc;

        /// LONG->int
        public int ySrc;

        /// XFORM->tagXFORM
        public tagXFORM xformSrc;

        /// COLORREF->DWORD->unsigned int
        public uint crBkColorSrc;

        /// DWORD->unsigned int
        public uint iUsageSrc;

        /// DWORD->unsigned int
        public uint offBmiSrc;

        /// DWORD->unsigned int
        public uint cbBmiSrc;

        /// DWORD->unsigned int
        public uint offBitsSrc;

        /// DWORD->unsigned int
        public uint cbBitsSrc;

        /// LONG->int
        public int cxSrc;

        /// LONG->int
        public int cySrc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagEMR
    {

        /// DWORD->unsigned int
        public uint iType;

        /// DWORD->unsigned int
        public uint nSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagELEMDESC
    {

        /// TYPEDESC->tagTYPEDESC
        public tagTYPEDESC tdesc;

        /// Anonymous_40d14048_0ade_44b7_81ed_baa885f6fcb2
        public Anonymous_40d14048_0ade_44b7_81ed_baa885f6fcb2 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDVTARGETDEVICE
    {

        /// DWORD->unsigned int
        public uint tdSize;

        /// WORD->unsigned short
        public ushort tdDriverNameOffset;

        /// WORD->unsigned short
        public ushort tdDeviceNameOffset;

        /// WORD->unsigned short
        public ushort tdPortNameOffset;

        /// WORD->unsigned short
        public ushort tdExtDevmodeOffset;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] tdData;
    }

    public enum tagDVASPECT
    {

        /// DVASPECT_CONTENT -> 1
        DVASPECT_CONTENT = 1,

        /// DVASPECT_THUMBNAIL -> 2
        DVASPECT_THUMBNAIL = 2,

        /// DVASPECT_ICON -> 4
        DVASPECT_ICON = 4,

        /// DVASPECT_DOCPRINT -> 8
        DVASPECT_DOCPRINT = 8,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDRVCONFIGINFO
    {

        /// DWORD->unsigned int
        public uint dwDCISize;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszDCISectionName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszDCIAliasName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDROPSTRUCT
    {

        /// HWND->HWND__*
        public IntPtr hwndSource;

        /// HWND->HWND__*
        public IntPtr hwndSink;

        /// DWORD->unsigned int
        public uint wFmt;

        /// ULONG_PTR->unsigned int
        public uint dwData;

        /// POINT->tagPOINT
        public Point ptDrop;

        /// DWORD->unsigned int
        public uint dwControlData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDRAWTEXTPARAMS
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iTabLength;

        /// int
        public int iLeftMargin;

        /// int
        public int iRightMargin;

        /// UINT->unsigned int
        public uint uiLengthDrawn;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDRAWITEMSTRUCT
    {

        /// UINT->unsigned int
        public uint CtlType;

        /// UINT->unsigned int
        public uint CtlID;

        /// UINT->unsigned int
        public uint itemID;

        /// UINT->unsigned int
        public uint itemAction;

        /// UINT->unsigned int
        public uint itemState;

        /// HWND->HWND__*
        public IntPtr hwndItem;

        /// HDC->HDC__*
        public IntPtr hDC;

        /// RECT->tagRECT
        public tagRECT rcItem;

        /// ULONG_PTR->unsigned int
        public uint itemData;
    }

    public enum tagDOMNodeType
    {

        /// NODE_INVALID -> 0
        NODE_INVALID = 0,

        /// NODE_ELEMENT -> NODE_INVALID+1
        NODE_ELEMENT = (tagDOMNodeType.NODE_INVALID + 1),

        /// NODE_ATTRIBUTE -> NODE_ELEMENT+1
        NODE_ATTRIBUTE = (tagDOMNodeType.NODE_ELEMENT + 1),

        /// NODE_TEXT -> NODE_ATTRIBUTE+1
        NODE_TEXT = (tagDOMNodeType.NODE_ATTRIBUTE + 1),

        /// NODE_CDATA_SECTION -> NODE_TEXT+1
        NODE_CDATA_SECTION = (tagDOMNodeType.NODE_TEXT + 1),

        /// NODE_ENTITY_REFERENCE -> NODE_CDATA_SECTION+1
        NODE_ENTITY_REFERENCE = (tagDOMNodeType.NODE_CDATA_SECTION + 1),

        /// NODE_ENTITY -> NODE_ENTITY_REFERENCE+1
        NODE_ENTITY = (tagDOMNodeType.NODE_ENTITY_REFERENCE + 1),

        /// NODE_PROCESSING_INSTRUCTION -> NODE_ENTITY+1
        NODE_PROCESSING_INSTRUCTION = (tagDOMNodeType.NODE_ENTITY + 1),

        /// NODE_COMMENT -> NODE_PROCESSING_INSTRUCTION+1
        NODE_COMMENT = (tagDOMNodeType.NODE_PROCESSING_INSTRUCTION + 1),

        /// NODE_DOCUMENT -> NODE_COMMENT+1
        NODE_DOCUMENT = (tagDOMNodeType.NODE_COMMENT + 1),

        /// NODE_DOCUMENT_TYPE -> NODE_DOCUMENT+1
        NODE_DOCUMENT_TYPE = (tagDOMNodeType.NODE_DOCUMENT + 1),

        /// NODE_DOCUMENT_FRAGMENT -> NODE_DOCUMENT_TYPE+1
        NODE_DOCUMENT_FRAGMENT = (tagDOMNodeType.NODE_DOCUMENT_TYPE + 1),

        /// NODE_NOTATION -> NODE_DOCUMENT_FRAGMENT+1
        NODE_NOTATION = (tagDOMNodeType.NODE_DOCUMENT_FRAGMENT + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDISPPARAMS
    {

        /// VARIANTARG*
        public IntPtr rgvarg;

        /// DISPID*
        public IntPtr rgdispidNamedArgs;

        /// UINT->unsigned int
        public uint cArgs;

        /// UINT->unsigned int
        public uint cNamedArgs;
    }

    public enum tagDISCARDCACHE
    {

        /// DISCARDCACHE_SAVEIFDIRTY -> 0
        DISCARDCACHE_SAVEIFDIRTY = 0,

        /// DISCARDCACHE_NOSAVE -> 1
        DISCARDCACHE_NOSAVE = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDIBSECTION
    {

        /// BITMAP->tagBITMAP
        public tagBITMAP dsBm;

        /// BITMAPINFOHEADER->tagBITMAPINFOHEADER
        public tagBITMAPINFOHEADER dsBmih;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] dsBitfields;

        /// HANDLE->void*
        public IntPtr dshSection;

        /// DWORD->unsigned int
        public uint dsOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDEVNAMES
    {

        /// WORD->unsigned short
        public ushort wDriverOffset;

        /// WORD->unsigned short
        public ushort wDeviceOffset;

        /// WORD->unsigned short
        public ushort wOutputOffset;

        /// WORD->unsigned short
        public ushort wDefault;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDESIGNVECTOR
    {

        /// DWORD->unsigned int
        public uint dvReserved;

        /// DWORD->unsigned int
        public uint dvNumAxes;

        /// LONG[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I4)]
        public int[] dvValues;
    }

    public enum tagDESCKIND
    {

        /// DESCKIND_NONE -> 0
        DESCKIND_NONE = 0,

        /// DESCKIND_FUNCDESC -> DESCKIND_NONE+1
        DESCKIND_FUNCDESC = (tagDESCKIND.DESCKIND_NONE + 1),

        /// DESCKIND_VARDESC -> DESCKIND_FUNCDESC+1
        DESCKIND_VARDESC = (tagDESCKIND.DESCKIND_FUNCDESC + 1),

        /// DESCKIND_TYPECOMP -> DESCKIND_VARDESC+1
        DESCKIND_TYPECOMP = (tagDESCKIND.DESCKIND_VARDESC + 1),

        /// DESCKIND_IMPLICITAPPOBJ -> DESCKIND_TYPECOMP+1
        DESCKIND_IMPLICITAPPOBJ = (tagDESCKIND.DESCKIND_TYPECOMP + 1),

        /// DESCKIND_MAX -> DESCKIND_IMPLICITAPPOBJ+1
        DESCKIND_MAX = (tagDESCKIND.DESCKIND_IMPLICITAPPOBJ + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDELETEITEMSTRUCT
    {

        /// UINT->unsigned int
        public uint CtlType;

        /// UINT->unsigned int
        public uint CtlID;

        /// UINT->unsigned int
        public uint itemID;

        /// HWND->HWND__*
        public IntPtr hwndItem;

        /// ULONG_PTR->unsigned int
        public uint itemData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDEC
    {

        /// USHORT->unsigned short
        public ushort wReserved;

        /// Anonymous_8abb5787_2644_417f_a055_f230370c6002
        public Anonymous_8abb5787_2644_417f_a055_f230370c6002 Union1;

        /// ULONG->unsigned int
        public uint Hi32;

        /// Anonymous_f95820c2_86d5_4678_8973_0d686c1da512
        public Anonymous_f95820c2_86d5_4678_8973_0d686c1da512 Union2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDEBUGHOOKINFO
    {

        /// DWORD->unsigned int
        public uint idThread;

        /// DWORD->unsigned int
        public uint idThreadInstaller;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;

        /// int
        public int code;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagDDEML_MSG_HOOK_DATA
    {

        /// UINT_PTR->unsigned int
        public uint uiLo;

        /// UINT_PTR->unsigned int
        public uint uiHi;

        /// DWORD->unsigned int
        public uint cbData;

        /// DWORD[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.U4)]
        public uint[] Data;
    }

    public enum tagDCOM_CALL_STATE
    {

        /// DCOM_NONE -> 0
        DCOM_NONE = 0,

        /// DCOM_CALL_COMPLETE -> 0x1
        DCOM_CALL_COMPLETE = 1,

        /// DCOM_CALL_CANCELED -> 0x2
        DCOM_CALL_CANCELED = 2,
    }

    public enum tagDATADIR
    {

        /// DATADIR_GET -> 1
        DATADIR_GET = 1,

        /// DATADIR_SET -> 2
        DATADIR_SET = 2,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct tagCY
    {

        /// Anonymous_3a267c73_6f53_4684_8e08_c837426a0e56
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_3a267c73_6f53_4684_8e08_c837426a0e56 Struct1;

        /// LONGLONG->__int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public long int64;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCWPSTRUCT
    {

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;

        /// UINT->unsigned int
        public uint message;

        /// HWND->HWND__*
        public IntPtr hwnd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCWPRETSTRUCT
    {

        /// LRESULT->LONG_PTR->int
        public int lResult;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// WPARAM->UINT_PTR->unsigned int
        public uint wParam;

        /// UINT->unsigned int
        public uint message;

        /// HWND->HWND__*
        public IntPtr hwnd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCUSTDATAITEM
    {

        /// GUID->_GUID
        public GUID guid;

        /// VARIANTARG->VARIANT->tagVARIANT
        public tagVARIANT varValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCUSTDATA
    {

        /// DWORD->unsigned int
        public uint cCustData;

        /// LPCUSTDATAITEM->tagCUSTDATAITEM*
        public IntPtr prgCustData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCURSORSHAPE
    {

        /// int
        public int xHotSpot;

        /// int
        public int yHotSpot;

        /// int
        public int cx;

        /// int
        public int cy;

        /// int
        public int cbWidth;

        /// BYTE->unsigned char
        public byte Planes;

        /// BYTE->unsigned char
        public byte BitsPixel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCURSORINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint flags;

        /// HCURSOR->HICON->HICON__*
        public IntPtr hCursor;

        /// POINT->tagPOINT
        public Point ptScreenPos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCSPLATFORM
    {

        /// DWORD->unsigned int
        public uint dwPlatformId;

        /// DWORD->unsigned int
        public uint dwVersionHi;

        /// DWORD->unsigned int
        public uint dwVersionLo;

        /// DWORD->unsigned int
        public uint dwProcessorArch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCRGB
    {

        /// BYTE->unsigned char
        public byte bRed;

        /// BYTE->unsigned char
        public byte bGreen;

        /// BYTE->unsigned char
        public byte bBlue;

        /// BYTE->unsigned char
        public byte bExtra;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCREATESTRUCTW
    {

        /// LPVOID->void*
        public IntPtr lpCreateParams;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// HMENU->HMENU__*
        public IntPtr hMenu;

        /// HWND->HWND__*
        public IntPtr hwndParent;

        /// int
        public int cy;

        /// int
        public int cx;

        /// int
        public int y;

        /// int
        public int x;

        /// LONG->int
        public int style;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszClass;

        /// DWORD->unsigned int
        public uint dwExStyle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCREATESTRUCTA
    {

        /// LPVOID->void*
        public IntPtr lpCreateParams;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// HMENU->HMENU__*
        public IntPtr hMenu;

        /// HWND->HWND__*
        public IntPtr hwndParent;

        /// int
        public int cy;

        /// int
        public int cx;

        /// int
        public int y;

        /// int
        public int x;

        /// LONG->int
        public int style;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszClass;

        /// DWORD->unsigned int
        public uint dwExStyle;
    }

    public enum tagCOWAIT_FLAGS
    {

        /// COWAIT_WAITALL -> 1
        COWAIT_WAITALL = 1,

        /// COWAIT_ALERTABLE -> 2
        COWAIT_ALERTABLE = 2,

        /// COWAIT_INPUTAVAILABLE -> 4
        COWAIT_INPUTAVAILABLE = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCOPYDATASTRUCT
    {

        /// ULONG_PTR->unsigned int
        public uint dwData;

        /// DWORD->unsigned int
        public uint cbData;

        /// PVOID->void*
        public IntPtr lpData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCONVINFO
    {

        /// DWORD->unsigned int
        public uint cb;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint hUser;

        /// HCONV->HCONV__*
        public IntPtr hConvPartner;

        /// HSZ->HSZ__*
        public IntPtr hszSvcPartner;

        /// HSZ->HSZ__*
        public IntPtr hszServiceReq;

        /// HSZ->HSZ__*
        public IntPtr hszTopic;

        /// HSZ->HSZ__*
        public IntPtr hszItem;

        /// UINT->unsigned int
        public uint wFmt;

        /// UINT->unsigned int
        public uint wType;

        /// UINT->unsigned int
        public uint wStatus;

        /// UINT->unsigned int
        public uint wConvst;

        /// UINT->unsigned int
        public uint wLastError;

        /// HCONVLIST->HCONVLIST__*
        public IntPtr hConvList;

        /// CONVCONTEXT->tagCONVCONTEXT
        public tagCONVCONTEXT ConvCtxt;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// HWND->HWND__*
        public IntPtr hwndPartner;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCONVCONTEXT
    {

        /// UINT->unsigned int
        public uint cb;

        /// UINT->unsigned int
        public uint wFlags;

        /// UINT->unsigned int
        public uint wCountryID;

        /// int
        public int iCodePage;

        /// DWORD->unsigned int
        public uint dwLangID;

        /// DWORD->unsigned int
        public uint dwSecurity;

        /// SECURITY_QUALITY_OF_SERVICE->_SECURITY_QUALITY_OF_SERVICE
        public SECURITY_QUALITY_OF_SERVICE qos;
    }

    public enum tagCOMSD
    {

        /// SD_LAUNCHPERMISSIONS -> 0
        SD_LAUNCHPERMISSIONS = 0,

        /// SD_ACCESSPERMISSIONS -> 1
        SD_ACCESSPERMISSIONS = 1,

        /// SD_LAUNCHRESTRICTIONS -> 2
        SD_LAUNCHRESTRICTIONS = 2,

        /// SD_ACCESSRESTRICTIONS -> 3
        SD_ACCESSRESTRICTIONS = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCOMPOSITIONFORM
    {

        /// DWORD->unsigned int
        public uint dwStyle;

        /// POINT->tagPOINT
        public Point ptCurrentPos;

        /// RECT->tagRECT
        public tagRECT rcArea;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCOMPAREITEMSTRUCT
    {

        /// UINT->unsigned int
        public uint CtlType;

        /// UINT->unsigned int
        public uint CtlID;

        /// HWND->HWND__*
        public IntPtr hwndItem;

        /// UINT->unsigned int
        public uint itemID1;

        /// ULONG_PTR->unsigned int
        public uint itemData1;

        /// UINT->unsigned int
        public uint itemID2;

        /// ULONG_PTR->unsigned int
        public uint itemData2;

        /// DWORD->unsigned int
        public uint dwLocaleId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCOMBOBOXINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// RECT->tagRECT
        public tagRECT rcItem;

        /// RECT->tagRECT
        public tagRECT rcButton;

        /// DWORD->unsigned int
        public uint stateButton;

        /// HWND->HWND__*
        public IntPtr hwndCombo;

        /// HWND->HWND__*
        public IntPtr hwndItem;

        /// HWND->HWND__*
        public IntPtr hwndList;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCOLORMATCHTOTARGET
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint dwAction;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint cbName;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCOLORCORRECTPALETTE
    {

        /// EMR->tagEMR
        public tagEMR emr;

        /// DWORD->unsigned int
        public uint ihPalette;

        /// DWORD->unsigned int
        public uint nFirstEntry;

        /// DWORD->unsigned int
        public uint nPalEntries;

        /// DWORD->unsigned int
        public uint nReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCOLORADJUSTMENT
    {

        /// WORD->unsigned short
        public ushort caSize;

        /// WORD->unsigned short
        public ushort caFlags;

        /// WORD->unsigned short
        public ushort caIlluminantIndex;

        /// WORD->unsigned short
        public ushort caRedGamma;

        /// WORD->unsigned short
        public ushort caGreenGamma;

        /// WORD->unsigned short
        public ushort caBlueGamma;

        /// WORD->unsigned short
        public ushort caReferenceBlack;

        /// WORD->unsigned short
        public ushort caReferenceWhite;

        /// SHORT->short
        public short caContrast;

        /// SHORT->short
        public short caBrightness;

        /// SHORT->short
        public short caColorfulness;

        /// SHORT->short
        public short caRedGreenTint;
    }

    public enum tagCOINIT
    {

        /// COINIT_APARTMENTTHREADED -> 0x2
        COINIT_APARTMENTTHREADED = 2,

        /// COINIT_MULTITHREADED -> 0x0
        COINIT_MULTITHREADED = 0,

        /// COINIT_DISABLE_OLE1DDE -> 0x4
        COINIT_DISABLE_OLE1DDE = 4,

        /// COINIT_SPEED_OVER_MEMORY -> 0x8
        COINIT_SPEED_OVER_MEMORY = 8,
    }

    public enum tagCLSCTX
    {

        /// CLSCTX_INPROC_SERVER -> 0x1
        CLSCTX_INPROC_SERVER = 1,

        /// CLSCTX_INPROC_HANDLER -> 0x2
        CLSCTX_INPROC_HANDLER = 2,

        /// CLSCTX_LOCAL_SERVER -> 0x4
        CLSCTX_LOCAL_SERVER = 4,

        /// CLSCTX_INPROC_SERVER16 -> 0x8
        CLSCTX_INPROC_SERVER16 = 8,

        /// CLSCTX_REMOTE_SERVER -> 0x10
        CLSCTX_REMOTE_SERVER = 16,

        /// CLSCTX_INPROC_HANDLER16 -> 0x20
        CLSCTX_INPROC_HANDLER16 = 32,

        /// CLSCTX_RESERVED1 -> 0x40
        CLSCTX_RESERVED1 = 64,

        /// CLSCTX_RESERVED2 -> 0x80
        CLSCTX_RESERVED2 = 128,

        /// CLSCTX_RESERVED3 -> 0x100
        CLSCTX_RESERVED3 = 256,

        /// CLSCTX_RESERVED4 -> 0x200
        CLSCTX_RESERVED4 = 512,

        /// CLSCTX_NO_CODE_DOWNLOAD -> 0x400
        CLSCTX_NO_CODE_DOWNLOAD = 1024,

        /// CLSCTX_RESERVED5 -> 0x800
        CLSCTX_RESERVED5 = 2048,

        /// CLSCTX_NO_CUSTOM_MARSHAL -> 0x1000
        CLSCTX_NO_CUSTOM_MARSHAL = 4096,

        /// CLSCTX_ENABLE_CODE_DOWNLOAD -> 0x2000
        CLSCTX_ENABLE_CODE_DOWNLOAD = 8192,

        /// CLSCTX_NO_FAILURE_LOG -> 0x4000
        CLSCTX_NO_FAILURE_LOG = 16384,

        /// CLSCTX_DISABLE_AAA -> 0x8000
        CLSCTX_DISABLE_AAA = 32768,

        /// CLSCTX_ENABLE_AAA -> 0x10000
        CLSCTX_ENABLE_AAA = 65536,

        /// CLSCTX_FROM_DEFAULT_CONTEXT -> 0x20000
        CLSCTX_FROM_DEFAULT_CONTEXT = 131072,

        /// CLSCTX_ACTIVATE_32_BIT_SERVER -> 0x40000
        CLSCTX_ACTIVATE_32_BIT_SERVER = 262144,

        /// CLSCTX_ACTIVATE_64_BIT_SERVER -> 0x80000
        CLSCTX_ACTIVATE_64_BIT_SERVER = 524288,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCLIPDATA
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// int
        public int ulClipFmt;

        /// BYTE*
        public IntPtr pClipData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCLIENTCREATESTRUCT
    {

        /// HANDLE->void*
        public IntPtr hWindowMenu;

        /// UINT->unsigned int
        public uint idFirstChild;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCLEANLOCALSTORAGE
    {

        /// IUnknown*
        public IntPtr pInterface;

        /// PVOID->void*
        public IntPtr pStorage;

        /// DWORD->unsigned int
        public uint flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCIEXYZ
    {

        /// FXPT2DOT30->int
        public int ciexyzX;

        /// FXPT2DOT30->int
        public int ciexyzY;

        /// FXPT2DOT30->int
        public int ciexyzZ;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCHOOSEFONTW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HDC->HDC__*
        public IntPtr hDC;

        /// LPLOGFONTW->tagLOGFONTW*
        public IntPtr lpLogFont;

        /// INT->int
        public int iPointSize;

        /// DWORD->unsigned int
        public uint Flags;

        /// COLORREF->DWORD->unsigned int
        public uint rgbColors;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPCFHOOKPROC
        public LPCFHOOKPROC lpfnHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpTemplateName;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszStyle;

        /// WORD->unsigned short
        public ushort nFontType;

        /// WORD->unsigned short
        public ushort ___MISSING_ALIGNMENT__;

        /// INT->int
        public int nSizeMin;

        /// INT->int
        public int nSizeMax;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCHOOSEFONTA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HDC->HDC__*
        public IntPtr hDC;

        /// LPLOGFONTA->tagLOGFONTA*
        public IntPtr lpLogFont;

        /// INT->int
        public int iPointSize;

        /// DWORD->unsigned int
        public uint Flags;

        /// COLORREF->DWORD->unsigned int
        public uint rgbColors;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPCFHOOKPROC
        public LPCFHOOKPROC lpfnHook;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpTemplateName;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszStyle;

        /// WORD->unsigned short
        public ushort nFontType;

        /// WORD->unsigned short
        public ushort ___MISSING_ALIGNMENT__;

        /// INT->int
        public int nSizeMin;

        /// INT->int
        public int nSizeMax;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCHOOSECOLORW
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HWND->HWND__*
        public IntPtr hInstance;

        /// COLORREF->DWORD->unsigned int
        public uint rgbResult;

        /// COLORREF*
        public IntPtr lpCustColors;

        /// DWORD->unsigned int
        public uint Flags;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPCCHOOKPROC
        public LPCCHOOKPROC lpfnHook;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpTemplateName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCHOOSECOLORA
    {

        /// DWORD->unsigned int
        public uint lStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// HWND->HWND__*
        public IntPtr hInstance;

        /// COLORREF->DWORD->unsigned int
        public uint rgbResult;

        /// COLORREF*
        public IntPtr lpCustColors;

        /// DWORD->unsigned int
        public uint Flags;

        /// LPARAM->LONG_PTR->int
        public int lCustData;

        /// LPCCHOOKPROC
        public LPCCHOOKPROC lpfnHook;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpTemplateName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCHARSETINFO
    {

        /// UINT->unsigned int
        public uint ciCharset;

        /// UINT->unsigned int
        public uint ciACP;

        /// FONTSIGNATURE->tagFONTSIGNATURE
        public tagFONTSIGNATURE fs;
    }

    public enum tagCHANGEKIND
    {

        /// CHANGEKIND_ADDMEMBER -> 0
        CHANGEKIND_ADDMEMBER = 0,

        /// CHANGEKIND_DELETEMEMBER -> CHANGEKIND_ADDMEMBER+1
        CHANGEKIND_DELETEMEMBER = (tagCHANGEKIND.CHANGEKIND_ADDMEMBER + 1),

        /// CHANGEKIND_SETNAMES -> CHANGEKIND_DELETEMEMBER+1
        CHANGEKIND_SETNAMES = (tagCHANGEKIND.CHANGEKIND_DELETEMEMBER + 1),

        /// CHANGEKIND_SETDOCUMENTATION -> CHANGEKIND_SETNAMES+1
        CHANGEKIND_SETDOCUMENTATION = (tagCHANGEKIND.CHANGEKIND_SETNAMES + 1),

        /// CHANGEKIND_GENERAL -> CHANGEKIND_SETDOCUMENTATION+1
        CHANGEKIND_GENERAL = (tagCHANGEKIND.CHANGEKIND_SETDOCUMENTATION + 1),

        /// CHANGEKIND_INVALIDATE -> CHANGEKIND_GENERAL+1
        CHANGEKIND_INVALIDATE = (tagCHANGEKIND.CHANGEKIND_GENERAL + 1),

        /// CHANGEKIND_CHANGEFAILED -> CHANGEKIND_INVALIDATE+1
        CHANGEKIND_CHANGEFAILED = (tagCHANGEKIND.CHANGEKIND_INVALIDATE + 1),

        /// CHANGEKIND_MAX -> CHANGEKIND_CHANGEFAILED+1
        CHANGEKIND_MAX = (tagCHANGEKIND.CHANGEKIND_CHANGEFAILED + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCBT_CREATEWNDW
    {

        /// tagCREATESTRUCTW*
        public IntPtr lpcs;

        /// HWND->HWND__*
        public IntPtr hwndInsertAfter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCBT_CREATEWNDA
    {

        /// tagCREATESTRUCTA*
        public IntPtr lpcs;

        /// HWND->HWND__*
        public IntPtr hwndInsertAfter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCBTACTIVATESTRUCT
    {

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fMouse;

        /// HWND->HWND__*
        public IntPtr hWndActive;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUL
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// ULONG*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUI
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// USHORT*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUH
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// ULARGE_INTEGER*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAUB
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// UCHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCASCODE
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// SCODE*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAPROPVARIANT
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// PROPVARIANT*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCANDIDATELIST
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// DWORD->unsigned int
        public uint dwCount;

        /// DWORD->unsigned int
        public uint dwSelection;

        /// DWORD->unsigned int
        public uint dwPageStart;

        /// DWORD->unsigned int
        public uint dwPageSize;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] dwOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCANDIDATEFORM
    {

        /// DWORD->unsigned int
        public uint dwIndex;

        /// DWORD->unsigned int
        public uint dwStyle;

        /// POINT->tagPOINT
        public Point ptCurrentPos;

        /// RECT->tagRECT
        public tagRECT rcArea;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCALPWSTR
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// LPWSTR*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCALPSTR
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// LPSTR*
        public IntPtr pElems;
    }

    public enum tagCALLTYPE
    {

        /// CALLTYPE_TOPLEVEL -> 1
        CALLTYPE_TOPLEVEL = 1,

        /// CALLTYPE_NESTED -> 2
        CALLTYPE_NESTED = 2,

        /// CALLTYPE_ASYNC -> 3
        CALLTYPE_ASYNC = 3,

        /// CALLTYPE_TOPLEVEL_CALLPENDING -> 4
        CALLTYPE_TOPLEVEL_CALLPENDING = 4,

        /// CALLTYPE_ASYNC_CALLPENDING -> 5
        CALLTYPE_ASYNC_CALLPENDING = 5,
    }

    public enum tagCALLCONV
    {

        /// CC_FASTCALL -> 0
        CC_FASTCALL = 0,

        /// CC_CDECL -> 1
        CC_CDECL = 1,

        /// CC_MSCPASCAL -> CC_CDECL+1
        CC_MSCPASCAL = (tagCALLCONV.CC_CDECL + 1),

        /// CC_PASCAL -> CC_MSCPASCAL
        CC_PASCAL = tagCALLCONV.CC_MSCPASCAL,

        /// CC_MACPASCAL -> CC_PASCAL+1
        CC_MACPASCAL = (tagCALLCONV.CC_PASCAL + 1),

        /// CC_STDCALL -> CC_MACPASCAL+1
        CC_STDCALL = (tagCALLCONV.CC_MACPASCAL + 1),

        /// CC_FPFASTCALL -> CC_STDCALL+1
        CC_FPFASTCALL = (tagCALLCONV.CC_STDCALL + 1),

        /// CC_SYSCALL -> CC_FPFASTCALL+1
        CC_SYSCALL = (tagCALLCONV.CC_FPFASTCALL + 1),

        /// CC_MPWCDECL -> CC_SYSCALL+1
        CC_MPWCDECL = (tagCALLCONV.CC_SYSCALL + 1),

        /// CC_MPWPASCAL -> CC_MPWCDECL+1
        CC_MPWPASCAL = (tagCALLCONV.CC_MPWCDECL + 1),

        /// CC_MAX -> CC_MPWPASCAL+1
        CC_MAX = (tagCALLCONV.CC_MPWPASCAL + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAL
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// LONG*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAI
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// SHORT*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAH
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// LARGE_INTEGER*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAFLT
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// FLOAT*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAFILETIME
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// FILETIME*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCADBL
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// DOUBLE*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCADATE
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// DATE*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCACY
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// CY*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCACLSID
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// CLSID*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCACLIPDATA
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// CLIPDATA*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCAC
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCABSTRBLOB
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// BSTRBLOB*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCABSTR
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// BSTR*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagCABOOL
    {

        /// ULONG->unsigned int
        public uint cElems;

        /// VARIANT_BOOL*
        public IntPtr pElems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBSTRBLOB
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// BYTE*
        public IntPtr pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBLOB
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// BYTE*
        public IntPtr pBlobData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBITMAPINFOHEADER
    {

        /// DWORD->unsigned int
        public uint biSize;

        /// LONG->int
        public int biWidth;

        /// LONG->int
        public int biHeight;

        /// WORD->unsigned short
        public ushort biPlanes;

        /// WORD->unsigned short
        public ushort biBitCount;

        /// DWORD->unsigned int
        public uint biCompression;

        /// DWORD->unsigned int
        public uint biSizeImage;

        /// LONG->int
        public int biXPelsPerMeter;

        /// LONG->int
        public int biYPelsPerMeter;

        /// DWORD->unsigned int
        public uint biClrUsed;

        /// DWORD->unsigned int
        public uint biClrImportant;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBITMAPINFO
    {

        /// BITMAPINFOHEADER->tagBITMAPINFOHEADER
        public tagBITMAPINFOHEADER bmiHeader;

        /// RGBQUAD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagRGBQUAD[] bmiColors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBITMAPFILEHEADER
    {

        /// WORD->unsigned short
        public ushort bfType;

        /// DWORD->unsigned int
        public uint bfSize;

        /// WORD->unsigned short
        public ushort bfReserved1;

        /// WORD->unsigned short
        public ushort bfReserved2;

        /// DWORD->unsigned int
        public uint bfOffBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBITMAPCOREINFO
    {

        /// BITMAPCOREHEADER->tagBITMAPCOREHEADER
        public tagBITMAPCOREHEADER bmciHeader;

        /// RGBTRIPLE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagRGBTRIPLE[] bmciColors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBITMAPCOREHEADER
    {

        /// DWORD->unsigned int
        public uint bcSize;

        /// WORD->unsigned short
        public ushort bcWidth;

        /// WORD->unsigned short
        public ushort bcHeight;

        /// WORD->unsigned short
        public ushort bcPlanes;

        /// WORD->unsigned short
        public ushort bcBitCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBITMAP
    {

        /// LONG->int
        public int bmType;

        /// LONG->int
        public int bmWidth;

        /// LONG->int
        public int bmHeight;

        /// LONG->int
        public int bmWidthBytes;

        /// WORD->unsigned short
        public ushort bmPlanes;

        /// WORD->unsigned short
        public ushort bmBitsPixel;

        /// LPVOID->void*
        public IntPtr bmBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBIND_OPTS2
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint grfFlags;

        /// DWORD->unsigned int
        public uint grfMode;

        /// DWORD->unsigned int
        public uint dwTickCountDeadline;

        /// DWORD->unsigned int
        public uint dwTrackFlags;

        /// DWORD->unsigned int
        public uint dwClassContext;

        /// LCID->DWORD->unsigned int
        public uint locale;

        /// COSERVERINFO*
        public IntPtr pServerInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBIND_OPTS
    {

        /// DWORD->unsigned int
        public uint cbStruct;

        /// DWORD->unsigned int
        public uint grfFlags;

        /// DWORD->unsigned int
        public uint grfMode;

        /// DWORD->unsigned int
        public uint dwTickCountDeadline;
    }

    public enum tagBIND_FLAGS
    {

        /// BIND_MAYBOTHERUSER -> 1
        BIND_MAYBOTHERUSER = 1,

        /// BIND_JUSTTESTEXISTENCE -> 2
        BIND_JUSTTESTEXISTENCE = 2,
    }

    public enum tagBINDSTRING
    {

        /// BINDSTRING_HEADERS -> 1
        BINDSTRING_HEADERS = 1,

        /// BINDSTRING_ACCEPT_MIMES -> BINDSTRING_HEADERS+1
        BINDSTRING_ACCEPT_MIMES = (tagBINDSTRING.BINDSTRING_HEADERS + 1),

        /// BINDSTRING_EXTRA_URL -> BINDSTRING_ACCEPT_MIMES+1
        BINDSTRING_EXTRA_URL = (tagBINDSTRING.BINDSTRING_ACCEPT_MIMES + 1),

        /// BINDSTRING_LANGUAGE -> BINDSTRING_EXTRA_URL+1
        BINDSTRING_LANGUAGE = (tagBINDSTRING.BINDSTRING_EXTRA_URL + 1),

        /// BINDSTRING_USERNAME -> BINDSTRING_LANGUAGE+1
        BINDSTRING_USERNAME = (tagBINDSTRING.BINDSTRING_LANGUAGE + 1),

        /// BINDSTRING_PASSWORD -> BINDSTRING_USERNAME+1
        BINDSTRING_PASSWORD = (tagBINDSTRING.BINDSTRING_USERNAME + 1),

        /// BINDSTRING_UA_PIXELS -> BINDSTRING_PASSWORD+1
        BINDSTRING_UA_PIXELS = (tagBINDSTRING.BINDSTRING_PASSWORD + 1),

        /// BINDSTRING_UA_COLOR -> BINDSTRING_UA_PIXELS+1
        BINDSTRING_UA_COLOR = (tagBINDSTRING.BINDSTRING_UA_PIXELS + 1),

        /// BINDSTRING_OS -> BINDSTRING_UA_COLOR+1
        BINDSTRING_OS = (tagBINDSTRING.BINDSTRING_UA_COLOR + 1),

        /// BINDSTRING_USER_AGENT -> BINDSTRING_OS+1
        BINDSTRING_USER_AGENT = (tagBINDSTRING.BINDSTRING_OS + 1),

        /// BINDSTRING_ACCEPT_ENCODINGS -> BINDSTRING_USER_AGENT+1
        BINDSTRING_ACCEPT_ENCODINGS = (tagBINDSTRING.BINDSTRING_USER_AGENT + 1),

        /// BINDSTRING_POST_COOKIE -> BINDSTRING_ACCEPT_ENCODINGS+1
        BINDSTRING_POST_COOKIE = (tagBINDSTRING.BINDSTRING_ACCEPT_ENCODINGS + 1),

        /// BINDSTRING_POST_DATA_MIME -> BINDSTRING_POST_COOKIE+1
        BINDSTRING_POST_DATA_MIME = (tagBINDSTRING.BINDSTRING_POST_COOKIE + 1),

        /// BINDSTRING_URL -> BINDSTRING_POST_DATA_MIME+1
        BINDSTRING_URL = (tagBINDSTRING.BINDSTRING_POST_DATA_MIME + 1),

        /// BINDSTRING_IID -> BINDSTRING_URL+1
        BINDSTRING_IID = (tagBINDSTRING.BINDSTRING_URL + 1),

        /// BINDSTRING_FLAG_BIND_TO_OBJECT -> BINDSTRING_IID+1
        BINDSTRING_FLAG_BIND_TO_OBJECT = (tagBINDSTRING.BINDSTRING_IID + 1),

        /// BINDSTRING_PTR_BIND_CONTEXT -> BINDSTRING_FLAG_BIND_TO_OBJECT+1
        BINDSTRING_PTR_BIND_CONTEXT = (tagBINDSTRING.BINDSTRING_FLAG_BIND_TO_OBJECT + 1),
    }

    public enum tagBINDSTATUS
    {

        /// BINDSTATUS_FINDINGRESOURCE -> 1
        BINDSTATUS_FINDINGRESOURCE = 1,

        /// BINDSTATUS_CONNECTING -> BINDSTATUS_FINDINGRESOURCE+1
        BINDSTATUS_CONNECTING = (tagBINDSTATUS.BINDSTATUS_FINDINGRESOURCE + 1),

        /// BINDSTATUS_REDIRECTING -> BINDSTATUS_CONNECTING+1
        BINDSTATUS_REDIRECTING = (tagBINDSTATUS.BINDSTATUS_CONNECTING + 1),

        /// BINDSTATUS_BEGINDOWNLOADDATA -> BINDSTATUS_REDIRECTING+1
        BINDSTATUS_BEGINDOWNLOADDATA = (tagBINDSTATUS.BINDSTATUS_REDIRECTING + 1),

        /// BINDSTATUS_DOWNLOADINGDATA -> BINDSTATUS_BEGINDOWNLOADDATA+1
        BINDSTATUS_DOWNLOADINGDATA = (tagBINDSTATUS.BINDSTATUS_BEGINDOWNLOADDATA + 1),

        /// BINDSTATUS_ENDDOWNLOADDATA -> BINDSTATUS_DOWNLOADINGDATA+1
        BINDSTATUS_ENDDOWNLOADDATA = (tagBINDSTATUS.BINDSTATUS_DOWNLOADINGDATA + 1),

        /// BINDSTATUS_BEGINDOWNLOADCOMPONENTS -> BINDSTATUS_ENDDOWNLOADDATA+1
        BINDSTATUS_BEGINDOWNLOADCOMPONENTS = (tagBINDSTATUS.BINDSTATUS_ENDDOWNLOADDATA + 1),

        /// BINDSTATUS_INSTALLINGCOMPONENTS -> BINDSTATUS_BEGINDOWNLOADCOMPONENTS+1
        BINDSTATUS_INSTALLINGCOMPONENTS = (tagBINDSTATUS.BINDSTATUS_BEGINDOWNLOADCOMPONENTS + 1),

        /// BINDSTATUS_ENDDOWNLOADCOMPONENTS -> BINDSTATUS_INSTALLINGCOMPONENTS+1
        BINDSTATUS_ENDDOWNLOADCOMPONENTS = (tagBINDSTATUS.BINDSTATUS_INSTALLINGCOMPONENTS + 1),

        /// BINDSTATUS_USINGCACHEDCOPY -> BINDSTATUS_ENDDOWNLOADCOMPONENTS+1
        BINDSTATUS_USINGCACHEDCOPY = (tagBINDSTATUS.BINDSTATUS_ENDDOWNLOADCOMPONENTS + 1),

        /// BINDSTATUS_SENDINGREQUEST -> BINDSTATUS_USINGCACHEDCOPY+1
        BINDSTATUS_SENDINGREQUEST = (tagBINDSTATUS.BINDSTATUS_USINGCACHEDCOPY + 1),

        /// BINDSTATUS_CLASSIDAVAILABLE -> BINDSTATUS_SENDINGREQUEST+1
        BINDSTATUS_CLASSIDAVAILABLE = (tagBINDSTATUS.BINDSTATUS_SENDINGREQUEST + 1),

        /// BINDSTATUS_MIMETYPEAVAILABLE -> BINDSTATUS_CLASSIDAVAILABLE+1
        BINDSTATUS_MIMETYPEAVAILABLE = (tagBINDSTATUS.BINDSTATUS_CLASSIDAVAILABLE + 1),

        /// BINDSTATUS_CACHEFILENAMEAVAILABLE -> BINDSTATUS_MIMETYPEAVAILABLE+1
        BINDSTATUS_CACHEFILENAMEAVAILABLE = (tagBINDSTATUS.BINDSTATUS_MIMETYPEAVAILABLE + 1),

        /// BINDSTATUS_BEGINSYNCOPERATION -> BINDSTATUS_CACHEFILENAMEAVAILABLE+1
        BINDSTATUS_BEGINSYNCOPERATION = (tagBINDSTATUS.BINDSTATUS_CACHEFILENAMEAVAILABLE + 1),

        /// BINDSTATUS_ENDSYNCOPERATION -> BINDSTATUS_BEGINSYNCOPERATION+1
        BINDSTATUS_ENDSYNCOPERATION = (tagBINDSTATUS.BINDSTATUS_BEGINSYNCOPERATION + 1),

        /// BINDSTATUS_BEGINUPLOADDATA -> BINDSTATUS_ENDSYNCOPERATION+1
        BINDSTATUS_BEGINUPLOADDATA = (tagBINDSTATUS.BINDSTATUS_ENDSYNCOPERATION + 1),

        /// BINDSTATUS_UPLOADINGDATA -> BINDSTATUS_BEGINUPLOADDATA+1
        BINDSTATUS_UPLOADINGDATA = (tagBINDSTATUS.BINDSTATUS_BEGINUPLOADDATA + 1),

        /// BINDSTATUS_ENDUPLOADDATA -> BINDSTATUS_UPLOADINGDATA+1
        BINDSTATUS_ENDUPLOADDATA = (tagBINDSTATUS.BINDSTATUS_UPLOADINGDATA + 1),

        /// BINDSTATUS_PROTOCOLCLASSID -> BINDSTATUS_ENDUPLOADDATA+1
        BINDSTATUS_PROTOCOLCLASSID = (tagBINDSTATUS.BINDSTATUS_ENDUPLOADDATA + 1),

        /// BINDSTATUS_ENCODING -> BINDSTATUS_PROTOCOLCLASSID+1
        BINDSTATUS_ENCODING = (tagBINDSTATUS.BINDSTATUS_PROTOCOLCLASSID + 1),

        /// BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE -> BINDSTATUS_ENCODING+1
        BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE = (tagBINDSTATUS.BINDSTATUS_ENCODING + 1),

        /// BINDSTATUS_CLASSINSTALLLOCATION -> BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE+1
        BINDSTATUS_CLASSINSTALLLOCATION = (tagBINDSTATUS.BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE + 1),

        /// BINDSTATUS_DECODING -> BINDSTATUS_CLASSINSTALLLOCATION+1
        BINDSTATUS_DECODING = (tagBINDSTATUS.BINDSTATUS_CLASSINSTALLLOCATION + 1),

        /// BINDSTATUS_LOADINGMIMEHANDLER -> BINDSTATUS_DECODING+1
        BINDSTATUS_LOADINGMIMEHANDLER = (tagBINDSTATUS.BINDSTATUS_DECODING + 1),

        /// BINDSTATUS_CONTENTDISPOSITIONATTACH -> BINDSTATUS_LOADINGMIMEHANDLER+1
        BINDSTATUS_CONTENTDISPOSITIONATTACH = (tagBINDSTATUS.BINDSTATUS_LOADINGMIMEHANDLER + 1),

        /// BINDSTATUS_FILTERREPORTMIMETYPE -> BINDSTATUS_CONTENTDISPOSITIONATTACH+1
        BINDSTATUS_FILTERREPORTMIMETYPE = (tagBINDSTATUS.BINDSTATUS_CONTENTDISPOSITIONATTACH + 1),

        /// BINDSTATUS_CLSIDCANINSTANTIATE -> BINDSTATUS_FILTERREPORTMIMETYPE+1
        BINDSTATUS_CLSIDCANINSTANTIATE = (tagBINDSTATUS.BINDSTATUS_FILTERREPORTMIMETYPE + 1),

        /// BINDSTATUS_IUNKNOWNAVAILABLE -> BINDSTATUS_CLSIDCANINSTANTIATE+1
        BINDSTATUS_IUNKNOWNAVAILABLE = (tagBINDSTATUS.BINDSTATUS_CLSIDCANINSTANTIATE + 1),

        /// BINDSTATUS_DIRECTBIND -> BINDSTATUS_IUNKNOWNAVAILABLE+1
        BINDSTATUS_DIRECTBIND = (tagBINDSTATUS.BINDSTATUS_IUNKNOWNAVAILABLE + 1),

        /// BINDSTATUS_RAWMIMETYPE -> BINDSTATUS_DIRECTBIND+1
        BINDSTATUS_RAWMIMETYPE = (tagBINDSTATUS.BINDSTATUS_DIRECTBIND + 1),

        /// BINDSTATUS_PROXYDETECTING -> BINDSTATUS_RAWMIMETYPE+1
        BINDSTATUS_PROXYDETECTING = (tagBINDSTATUS.BINDSTATUS_RAWMIMETYPE + 1),

        /// BINDSTATUS_ACCEPTRANGES -> BINDSTATUS_PROXYDETECTING+1
        BINDSTATUS_ACCEPTRANGES = (tagBINDSTATUS.BINDSTATUS_PROXYDETECTING + 1),

        /// BINDSTATUS_COOKIE_SENT -> BINDSTATUS_ACCEPTRANGES+1
        BINDSTATUS_COOKIE_SENT = (tagBINDSTATUS.BINDSTATUS_ACCEPTRANGES + 1),

        /// BINDSTATUS_COMPACT_POLICY_RECEIVED -> BINDSTATUS_COOKIE_SENT+1
        BINDSTATUS_COMPACT_POLICY_RECEIVED = (tagBINDSTATUS.BINDSTATUS_COOKIE_SENT + 1),

        /// BINDSTATUS_COOKIE_SUPPRESSED -> BINDSTATUS_COMPACT_POLICY_RECEIVED+1
        BINDSTATUS_COOKIE_SUPPRESSED = (tagBINDSTATUS.BINDSTATUS_COMPACT_POLICY_RECEIVED + 1),

        /// BINDSTATUS_COOKIE_STATE_UNKNOWN -> BINDSTATUS_COOKIE_SUPPRESSED+1
        BINDSTATUS_COOKIE_STATE_UNKNOWN = (tagBINDSTATUS.BINDSTATUS_COOKIE_SUPPRESSED + 1),

        /// BINDSTATUS_COOKIE_STATE_ACCEPT -> BINDSTATUS_COOKIE_STATE_UNKNOWN+1
        BINDSTATUS_COOKIE_STATE_ACCEPT = (tagBINDSTATUS.BINDSTATUS_COOKIE_STATE_UNKNOWN + 1),

        /// BINDSTATUS_COOKIE_STATE_REJECT -> BINDSTATUS_COOKIE_STATE_ACCEPT+1
        BINDSTATUS_COOKIE_STATE_REJECT = (tagBINDSTATUS.BINDSTATUS_COOKIE_STATE_ACCEPT + 1),

        /// BINDSTATUS_COOKIE_STATE_PROMPT -> BINDSTATUS_COOKIE_STATE_REJECT+1
        BINDSTATUS_COOKIE_STATE_PROMPT = (tagBINDSTATUS.BINDSTATUS_COOKIE_STATE_REJECT + 1),

        /// BINDSTATUS_COOKIE_STATE_LEASH -> BINDSTATUS_COOKIE_STATE_PROMPT+1
        BINDSTATUS_COOKIE_STATE_LEASH = (tagBINDSTATUS.BINDSTATUS_COOKIE_STATE_PROMPT + 1),

        /// BINDSTATUS_COOKIE_STATE_DOWNGRADE -> BINDSTATUS_COOKIE_STATE_LEASH+1
        BINDSTATUS_COOKIE_STATE_DOWNGRADE = (tagBINDSTATUS.BINDSTATUS_COOKIE_STATE_LEASH + 1),

        /// BINDSTATUS_POLICY_HREF -> BINDSTATUS_COOKIE_STATE_DOWNGRADE+1
        BINDSTATUS_POLICY_HREF = (tagBINDSTATUS.BINDSTATUS_COOKIE_STATE_DOWNGRADE + 1),

        /// BINDSTATUS_P3P_HEADER -> BINDSTATUS_POLICY_HREF+1
        BINDSTATUS_P3P_HEADER = (tagBINDSTATUS.BINDSTATUS_POLICY_HREF + 1),

        /// BINDSTATUS_SESSION_COOKIE_RECEIVED -> BINDSTATUS_P3P_HEADER+1
        BINDSTATUS_SESSION_COOKIE_RECEIVED = (tagBINDSTATUS.BINDSTATUS_P3P_HEADER + 1),

        /// BINDSTATUS_PERSISTENT_COOKIE_RECEIVED -> BINDSTATUS_SESSION_COOKIE_RECEIVED+1
        BINDSTATUS_PERSISTENT_COOKIE_RECEIVED = (tagBINDSTATUS.BINDSTATUS_SESSION_COOKIE_RECEIVED + 1),

        /// BINDSTATUS_SESSION_COOKIES_ALLOWED -> BINDSTATUS_PERSISTENT_COOKIE_RECEIVED+1
        BINDSTATUS_SESSION_COOKIES_ALLOWED = (tagBINDSTATUS.BINDSTATUS_PERSISTENT_COOKIE_RECEIVED + 1),

        /// BINDSTATUS_CACHECONTROL -> BINDSTATUS_SESSION_COOKIES_ALLOWED+1
        BINDSTATUS_CACHECONTROL = (tagBINDSTATUS.BINDSTATUS_SESSION_COOKIES_ALLOWED + 1),

        /// BINDSTATUS_CONTENTDISPOSITIONFILENAME -> BINDSTATUS_CACHECONTROL+1
        BINDSTATUS_CONTENTDISPOSITIONFILENAME = (tagBINDSTATUS.BINDSTATUS_CACHECONTROL + 1),

        /// BINDSTATUS_MIMETEXTPLAINMISMATCH -> BINDSTATUS_CONTENTDISPOSITIONFILENAME+1
        BINDSTATUS_MIMETEXTPLAINMISMATCH = (tagBINDSTATUS.BINDSTATUS_CONTENTDISPOSITIONFILENAME + 1),

        /// BINDSTATUS_PUBLISHERAVAILABLE -> BINDSTATUS_MIMETEXTPLAINMISMATCH+1
        BINDSTATUS_PUBLISHERAVAILABLE = (tagBINDSTATUS.BINDSTATUS_MIMETEXTPLAINMISMATCH + 1),

        /// BINDSTATUS_DISPLAYNAMEAVAILABLE -> BINDSTATUS_PUBLISHERAVAILABLE+1
        BINDSTATUS_DISPLAYNAMEAVAILABLE = (tagBINDSTATUS.BINDSTATUS_PUBLISHERAVAILABLE + 1),
    }

    public enum tagBINDSPEED
    {

        /// BINDSPEED_INDEFINITE -> 1
        BINDSPEED_INDEFINITE = 1,

        /// BINDSPEED_MODERATE -> 2
        BINDSPEED_MODERATE = 2,

        /// BINDSPEED_IMMEDIATE -> 3
        BINDSPEED_IMMEDIATE = 3,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct tagBINDPTR
    {

        /// FUNCDESC*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lpfuncdesc;

        /// VARDESC*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lpvardesc;

        /// ITypeComp*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr lptcomp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagBinaryParam
    {

        /// void*
        public IntPtr Buffer;

        /// short
        public short Size;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagAXISINFOW
    {

        /// LONG->int
        public int axMinValue;

        /// LONG->int
        public int axMaxValue;

        /// WCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string axAxisName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagAXISINFOA
    {

        /// LONG->int
        public int axMinValue;

        /// LONG->int
        public int axMaxValue;

        /// BYTE[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] axAxisName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagAXESLISTW
    {

        /// DWORD->unsigned int
        public uint axlReserved;

        /// DWORD->unsigned int
        public uint axlNumAxes;

        /// AXISINFOW[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
        public tagAXISINFOW[] axlAxisInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagAXESLISTA
    {

        /// DWORD->unsigned int
        public uint axlReserved;

        /// DWORD->unsigned int
        public uint axlNumAxes;

        /// AXISINFOA[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
        public tagAXISINFOA[] axlAxisInfo;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagAUXCAPSW
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagAUXCAPSA
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagAUXCAPS2W
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct tagAUXCAPS2A
    {

        /// WORD->unsigned short
        public ushort wMid;

        /// WORD->unsigned short
        public ushort wPid;

        /// MMVERSION->UINT->unsigned int
        public uint vDriverVersion;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// WORD->unsigned short
        public ushort wTechnology;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// DWORD->unsigned int
        public uint dwSupport;

        /// GUID->_GUID
        public GUID ManufacturerGuid;

        /// GUID->_GUID
        public GUID ProductGuid;

        /// GUID->_GUID
        public GUID NameGuid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagARRAYDESC
    {

        /// TYPEDESC->tagTYPEDESC
        public tagTYPEDESC tdescElem;

        /// USHORT->unsigned short
        public ushort cDims;

        /// SAFEARRAYBOUND[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagSAFEARRAYBOUND[] rgbounds;
    }

    public enum tagApplicationType
    {

        /// ServerApplication -> 0
        ServerApplication = 0,

        /// LibraryApplication -> ServerApplication+1
        LibraryApplication = (tagApplicationType.ServerApplication + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagANIMATIONINFO
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// int
        public int iMinAnimate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagALTTABINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// int
        public int cItems;

        /// int
        public int cColumns;

        /// int
        public int cRows;

        /// int
        public int iColFocus;

        /// int
        public int iRowFocus;

        /// int
        public int cxItem;

        /// int
        public int cyItem;

        /// POINT->tagPOINT
        public Point ptStart;
    }

    public enum tagADVF
    {

        /// ADVF_NODATA -> 1
        ADVF_NODATA = 1,

        /// ADVF_PRIMEFIRST -> 2
        ADVF_PRIMEFIRST = 2,

        /// ADVF_ONLYONCE -> 4
        ADVF_ONLYONCE = 4,

        /// ADVF_DATAONSTOP -> 64
        ADVF_DATAONSTOP = 64,

        /// ADVFCACHE_NOHANDLER -> 8
        ADVFCACHE_NOHANDLER = 8,

        /// ADVFCACHE_FORCEBUILTIN -> 16
        ADVFCACHE_FORCEBUILTIN = 16,

        /// ADVFCACHE_ONSAVE -> 32
        ADVFCACHE_ONSAVE = 32,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA
    {

        /// PVOID->void*
        public IntPtr lpInformation;

        /// PVOID->void*
        public IntPtr lpSectionBase;

        /// ULONG->unsigned int
        public uint ulSectionLength;

        /// PVOID->void*
        public IntPtr lpSectionGlobalDataBase;

        /// ULONG->unsigned int
        public uint ulSectionGlobalDataLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagACTCTX_SECTION_KEYED_DATA_2600
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// ULONG->unsigned int
        public uint ulDataFormatVersion;

        /// PVOID->void*
        public IntPtr lpData;

        /// ULONG->unsigned int
        public uint ulLength;

        /// PVOID->void*
        public IntPtr lpSectionGlobalData;

        /// ULONG->unsigned int
        public uint ulSectionGlobalDataLength;

        /// PVOID->void*
        public IntPtr lpSectionBase;

        /// ULONG->unsigned int
        public uint ulSectionTotalLength;

        /// HANDLE->void*
        public IntPtr hActCtx;

        /// ULONG->unsigned int
        public uint ulAssemblyRosterIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagACTCTX_SECTION_KEYED_DATA
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// ULONG->unsigned int
        public uint ulDataFormatVersion;

        /// PVOID->void*
        public IntPtr lpData;

        /// ULONG->unsigned int
        public uint ulLength;

        /// PVOID->void*
        public IntPtr lpSectionGlobalData;

        /// ULONG->unsigned int
        public uint ulSectionGlobalDataLength;

        /// PVOID->void*
        public IntPtr lpSectionBase;

        /// ULONG->unsigned int
        public uint ulSectionTotalLength;

        /// HANDLE->void*
        public IntPtr hActCtx;

        /// ULONG->unsigned int
        public uint ulAssemblyRosterIndex;

        /// ULONG->unsigned int
        public uint ulFlags;

        /// ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA->tagACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA
        public tagACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA AssemblyMetadata;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagACTCTXW
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpSource;

        /// USHORT->unsigned short
        public ushort wProcessorArchitecture;

        /// LANGID->WORD->unsigned short
        public ushort wLangId;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpAssemblyDirectory;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpResourceName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpApplicationName;

        /// HMODULE->HINSTANCE->HINSTANCE__*
        public IntPtr hModule;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagACTCTXA
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpSource;

        /// USHORT->unsigned short
        public ushort wProcessorArchitecture;

        /// LANGID->WORD->unsigned short
        public ushort wLangId;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpAssemblyDirectory;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpResourceName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpApplicationName;

        /// HMODULE->HINSTANCE->HINSTANCE__*
        public IntPtr hModule;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagACCESSTIMEOUT
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint iTimeOutMSec;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagACCEL
    {

        /// BYTE->unsigned char
        public byte fVirt;

        /// WORD->unsigned short
        public ushort key;

        /// WORD->unsigned short
        public ushort cmd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagABORTPATH
    {

        /// EMR->tagEMR
        public tagEMR emr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TRIVERTEX
    {

        /// LONG->int
        public int x;

        /// LONG->int
        public int y;

        /// COLOR16->USHORT->unsigned short
        public ushort Red;

        /// COLOR16->USHORT->unsigned short
        public ushort Green;

        /// COLOR16->USHORT->unsigned short
        public ushort Blue;

        /// COLOR16->USHORT->unsigned short
        public ushort Alpha;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TRANSMIT_FILE_BUFFERS
    {

        /// PVOID->void*
        public IntPtr Head;

        /// DWORD->unsigned int
        public uint HeadLength;

        /// PVOID->void*
        public IntPtr Tail;

        /// DWORD->unsigned int
        public uint TailLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_USER
    {

        /// SID_AND_ATTRIBUTES->_SID_AND_ATTRIBUTES
        public SID_AND_ATTRIBUTES User;
    }

    public enum TOKEN_TYPE
    {

        /// TokenPrimary -> 1
        TokenPrimary = 1,

        TokenImpersonation,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_STATISTICS
    {

        /// LUID->_LUID
        public LUID TokenId;

        /// LUID->_LUID
        public LUID AuthenticationId;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER ExpirationTime;

        /// TOKEN_TYPE->_TOKEN_TYPE
        public TOKEN_TYPE TokenType;

        /// SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
        public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

        /// DWORD->unsigned int
        public uint DynamicCharged;

        /// DWORD->unsigned int
        public uint DynamicAvailable;

        /// DWORD->unsigned int
        public uint GroupCount;

        /// DWORD->unsigned int
        public uint PrivilegeCount;

        /// LUID->_LUID
        public LUID ModifiedId;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_SOURCE
    {

        /// CHAR[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string SourceName;

        /// LUID->_LUID
        public LUID SourceIdentifier;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_PRIVILEGES
    {

        /// DWORD->unsigned int
        public uint PrivilegeCount;

        /// LUID_AND_ATTRIBUTES[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public LUID_AND_ATTRIBUTES[] Privileges;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_PRIMARY_GROUP
    {

        /// PSID->PVOID->void*
        public IntPtr PrimaryGroup;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_OWNER
    {

        /// PSID->PVOID->void*
        public IntPtr Owner;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_ORIGIN
    {

        /// LUID->_LUID
        public LUID OriginatingLogonSession;
    }

    public enum TOKEN_INFORMATION_CLASS
    {

        /// TokenUser -> 1
        TokenUser = 1,

        TokenGroups,

        TokenPrivileges,

        TokenOwner,

        TokenPrimaryGroup,

        TokenDefaultDacl,

        TokenSource,

        TokenType,

        TokenImpersonationLevel,

        TokenStatistics,

        TokenRestrictedSids,

        TokenSessionId,

        TokenGroupsAndPrivileges,

        TokenSessionReference,

        TokenSandBoxInert,

        TokenAuditPolicy,

        TokenOrigin,

        MaxTokenInfoClass,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_GROUPS_AND_PRIVILEGES
    {

        /// DWORD->unsigned int
        public uint SidCount;

        /// DWORD->unsigned int
        public uint SidLength;

        /// PSID_AND_ATTRIBUTES->_SID_AND_ATTRIBUTES*
        public IntPtr Sids;

        /// DWORD->unsigned int
        public uint RestrictedSidCount;

        /// DWORD->unsigned int
        public uint RestrictedSidLength;

        /// PSID_AND_ATTRIBUTES->_SID_AND_ATTRIBUTES*
        public IntPtr RestrictedSids;

        /// DWORD->unsigned int
        public uint PrivilegeCount;

        /// DWORD->unsigned int
        public uint PrivilegeLength;

        /// PLUID_AND_ATTRIBUTES->_LUID_AND_ATTRIBUTES*
        public IntPtr Privileges;

        /// LUID->_LUID
        public LUID AuthenticationId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_GROUPS
    {

        /// DWORD->unsigned int
        public uint GroupCount;

        /// SID_AND_ATTRIBUTES[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public SID_AND_ATTRIBUTES[] Groups;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_DEFAULT_DACL
    {

        /// PACL->ACL*
        public IntPtr DefaultDacl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_CONTROL
    {

        /// LUID->_LUID
        public LUID TokenId;

        /// LUID->_LUID
        public LUID AuthenticationId;

        /// LUID->_LUID
        public LUID ModifiedId;

        /// TOKEN_SOURCE->_TOKEN_SOURCE
        public TOKEN_SOURCE TokenSource;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_AUDIT_POLICY_ELEMENT
    {

        /// DWORD->unsigned int
        public uint Category;

        /// DWORD->unsigned int
        public uint PolicyMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TOKEN_AUDIT_POLICY
    {

        /// DWORD->unsigned int
        public uint PolicyCount;

        /// TOKEN_AUDIT_POLICY_ELEMENT[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public TOKEN_AUDIT_POLICY_ELEMENT[] Policy;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct TIME_ZONE_INFORMATION
    {

        /// LONG->int
        public int Bias;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string StandardName;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME StandardDate;

        /// LONG->int
        public int StandardBias;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DaylightName;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME DaylightDate;

        /// LONG->int
        public int DaylightBias;
    }

    public enum THDTYPE
    {

        /// THDTYPE_BLOCKMESSAGES -> 0
        THDTYPE_BLOCKMESSAGES = 0,

        /// THDTYPE_PROCESSMESSAGES -> 1
        THDTYPE_PROCESSMESSAGES = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TEKPUBKEY
    {

        /// DWORD->unsigned int
        public uint magic;

        /// DWORD->unsigned int
        public uint bitlen;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_WRITE_MARKS
    {

        /// DWORD->unsigned int
        public uint Type;

        /// DWORD->unsigned int
        public uint Count;

        /// BOOLEAN->BYTE->unsigned char
        public byte Immediate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_WMI_OPERATIONS
    {

        /// DWORD->unsigned int
        public uint Method;

        /// DWORD->unsigned int
        public uint DataBufferSize;

        /// PVOID->void*
        public IntPtr DataBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_STATISTICS
    {

        /// DWORD->unsigned int
        public uint Version;

        /// DWORD->unsigned int
        public uint Flags;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER RecoveredWrites;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER UnrecoveredWrites;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER RecoveredReads;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER UnrecoveredReads;

        /// BYTE->unsigned char
        public byte CompressionRatioReads;

        /// BYTE->unsigned char
        public byte CompressionRatioWrites;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_SET_POSITION
    {

        /// DWORD->unsigned int
        public uint Method;

        /// DWORD->unsigned int
        public uint Partition;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Offset;

        /// BOOLEAN->BYTE->unsigned char
        public byte Immediate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_SET_MEDIA_PARAMETERS
    {

        /// DWORD->unsigned int
        public uint BlockSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_SET_DRIVE_PARAMETERS
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte ECC;

        /// BOOLEAN->BYTE->unsigned char
        public byte Compression;

        /// BOOLEAN->BYTE->unsigned char
        public byte DataPadding;

        /// BOOLEAN->BYTE->unsigned char
        public byte ReportSetmarks;

        /// DWORD->unsigned int
        public uint EOTWarningZoneSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_PREPARE
    {

        /// DWORD->unsigned int
        public uint Operation;

        /// BOOLEAN->BYTE->unsigned char
        public byte Immediate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_GET_STATISTICS
    {

        /// DWORD->unsigned int
        public uint Operation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_GET_POSITION
    {

        /// DWORD->unsigned int
        public uint Type;

        /// DWORD->unsigned int
        public uint Partition;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_GET_MEDIA_PARAMETERS
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Capacity;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Remaining;

        /// DWORD->unsigned int
        public uint BlockSize;

        /// DWORD->unsigned int
        public uint PartitionCount;

        /// BOOLEAN->BYTE->unsigned char
        public byte WriteProtected;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_GET_DRIVE_PARAMETERS
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte ECC;

        /// BOOLEAN->BYTE->unsigned char
        public byte Compression;

        /// BOOLEAN->BYTE->unsigned char
        public byte DataPadding;

        /// BOOLEAN->BYTE->unsigned char
        public byte ReportSetmarks;

        /// DWORD->unsigned int
        public uint DefaultBlockSize;

        /// DWORD->unsigned int
        public uint MaximumBlockSize;

        /// DWORD->unsigned int
        public uint MinimumBlockSize;

        /// DWORD->unsigned int
        public uint MaximumPartitionCount;

        /// DWORD->unsigned int
        public uint FeaturesLow;

        /// DWORD->unsigned int
        public uint FeaturesHigh;

        /// DWORD->unsigned int
        public uint EOTWarningZoneSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_ERASE
    {

        /// DWORD->unsigned int
        public uint Type;

        /// BOOLEAN->BYTE->unsigned char
        public byte Immediate;
    }

    public enum TAPE_DRIVE_PROBLEM_TYPE
    {

        TapeDriveProblemNone,

        TapeDriveReadWriteWarning,

        TapeDriveReadWriteError,

        TapeDriveReadWarning,

        TapeDriveWriteWarning,

        TapeDriveReadError,

        TapeDriveWriteError,

        TapeDriveHardwareError,

        TapeDriveUnsupportedMedia,

        TapeDriveScsiConnectionError,

        TapeDriveTimetoClean,

        TapeDriveCleanDriveNow,

        TapeDriveMediaLifeExpired,

        TapeDriveSnappedTape,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TAPE_CREATE_PARTITION
    {

        /// DWORD->unsigned int
        public uint Method;

        /// DWORD->unsigned int
        public uint Count;

        /// DWORD->unsigned int
        public uint Size;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct tagged_union
    {

        /// CLSID->GUID->_GUID
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public GUID clsid;

        /// LPOLESTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pFileExt;

        /// LPOLESTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pMimeType;

        /// LPOLESTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pProgId;

        /// LPOLESTR->OLECHAR*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr pFileName;

        /// Anonymous_95951078_628c_4f84_b45e_48d4878fe825
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_95951078_628c_4f84_b45e_48d4878fe825 ByName;

        /// Anonymous_9ce4e4c3_5306_4984_8df6_e500c95e0232
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_9ce4e4c3_5306_4984_8df6_e500c95e0232 ByObjectId;
    }

}
