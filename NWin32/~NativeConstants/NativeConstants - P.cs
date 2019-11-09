using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// PW_CLIENTONLY -> 0x00000001
        public const int PW_CLIENTONLY = 1;

        /// PWR_SUSPENDRESUME -> 2
        public const int PWR_SUSPENDRESUME = 2;

        /// PWR_SUSPENDREQUEST -> 1
        public const int PWR_SUSPENDREQUEST = 1;

        /// PWR_OK -> 1
        public const int PWR_OK = 1;

        /// PWR_FAIL -> (-1)
        public const int PWR_FAIL = -1;

        /// PWR_CRITICALRESUME -> 3
        public const int PWR_CRITICALRESUME = 3;

        /// PURGE_TXCLEAR -> 0x0004
        public const int PURGE_TXCLEAR = 4;

        /// PURGE_TXABORT -> 0x0001
        public const int PURGE_TXABORT = 1;

        /// PURGE_RXCLEAR -> 0x0008
        public const int PURGE_RXCLEAR = 8;

        /// PURGE_RXABORT -> 0x0002
        public const int PURGE_RXABORT = 2;

        /// PUBLICKEYBLOBEX -> 0xA
        public const int PUBLICKEYBLOBEX = 10;

        /// PUBLICKEYBLOB -> 0x6
        public const int PUBLICKEYBLOB = 6;

        /// PT_MOVETO -> 0x06
        public const int PT_MOVETO = 6;

        /// PT_LINETO -> 0x02
        public const int PT_LINETO = 2;

        /// PT_CLOSEFIGURE -> 0x01
        public const int PT_CLOSEFIGURE = 1;

        /// PT_BEZIERTO -> 0x04
        public const int PT_BEZIERTO = 4;

        /// PS_USERSTYLE -> 7
        public const int PS_USERSTYLE = 7;

        /// PS_TYPE_MASK -> 0x000F0000
        public const int PS_TYPE_MASK = 983040;

        /// PS_STYLE_MASK -> 0x0000000F
        public const int PS_STYLE_MASK = 15;

        /// PS_SOLID -> 0
        public const int PS_SOLID = 0;

        /// PS_NULL -> 5
        public const int PS_NULL = 5;

        /// PS_JOIN_ROUND -> 0x00000000
        public const int PS_JOIN_ROUND = 0;

        /// PS_JOIN_MITER -> 0x00002000
        public const int PS_JOIN_MITER = 8192;

        /// PS_JOIN_MASK -> 0x0000F000
        public const int PS_JOIN_MASK = 61440;

        /// PS_JOIN_BEVEL -> 0x00001000
        public const int PS_JOIN_BEVEL = 4096;

        /// PS_INSIDEFRAME -> 6
        public const int PS_INSIDEFRAME = 6;

        /// PS_GEOMETRIC -> 0x00010000
        public const int PS_GEOMETRIC = 65536;

        /// PS_ENDCAP_SQUARE -> 0x00000100
        public const int PS_ENDCAP_SQUARE = 256;

        /// PS_ENDCAP_ROUND -> 0x00000000
        public const int PS_ENDCAP_ROUND = 0;

        /// PS_ENDCAP_MASK -> 0x00000F00
        public const int PS_ENDCAP_MASK = 3840;

        /// PS_ENDCAP_FLAT -> 0x00000200
        public const int PS_ENDCAP_FLAT = 512;

        /// PS_DOT -> 2
        public const int PS_DOT = 2;

        /// PS_DASHDOTDOT -> 4
        public const int PS_DASHDOTDOT = 4;

        /// PS_DASHDOT -> 3
        public const int PS_DASHDOT = 3;

        /// PS_DASH -> 1
        public const int PS_DASH = 1;

        /// PS_COSMETIC -> 0x00000000
        public const int PS_COSMETIC = 0;

        /// PS_ALTERNATE -> 8
        public const int PS_ALTERNATE = 8;

        /// PSWIZB_NEXT -> 0x00000002
        public const int PSWIZB_NEXT = 2;

        /// PSWIZB_FINISH -> 0x00000004
        public const int PSWIZB_FINISH = 4;

        /// PSWIZB_DISABLEDFINISH -> 0x00000008
        public const int PSWIZB_DISABLEDFINISH = 8;

        /// PSWIZB_BACK -> 0x00000001
        public const int PSWIZB_BACK = 1;

        /// PSP_USETITLE -> 0x00000008
        public const int PSP_USETITLE = 8;

        /// PSP_USEREFPARENT -> 0x00000040
        public const int PSP_USEREFPARENT = 64;

        /// PSP_USEICONID -> 0x00000004
        public const int PSP_USEICONID = 4;

        /// PSP_USEHICON -> 0x00000002
        public const int PSP_USEHICON = 2;

        /// PSP_USEHEADERTITLE -> 0x00001000
        public const int PSP_USEHEADERTITLE = 4096;

        /// PSP_USEHEADERSUBTITLE -> 0x00002000
        public const int PSP_USEHEADERSUBTITLE = 8192;

        /// PSP_USEFUSIONCONTEXT -> 0x00004000
        public const int PSP_USEFUSIONCONTEXT = 16384;

        /// PSP_USECALLBACK -> 0x00000080
        public const int PSP_USECALLBACK = 128;

        /// PSP_RTLREADING -> 0x00000010
        public const int PSP_RTLREADING = 16;

        /// PSP_PREMATURE -> 0x00000400
        public const int PSP_PREMATURE = 1024;

        /// PSP_HIDEHEADER -> 0x00000800
        public const int PSP_HIDEHEADER = 2048;

        /// PSP_HASHELP -> 0x00000020
        public const int PSP_HASHELP = 32;

        /// PSP_DLGINDIRECT -> 0x00000001
        public const int PSP_DLGINDIRECT = 1;

        /// PSP_DEFAULT -> 0x00000000
        public const int PSP_DEFAULT = 0;

        /// PSPROTOCOL_TBCP -> 2
        public const int PSPROTOCOL_TBCP = 2;

        /// PSPROTOCOL_BINARY -> 3
        public const int PSPROTOCOL_BINARY = 3;

        /// PSPROTOCOL_BCP -> 1
        public const int PSPROTOCOL_BCP = 1;

        /// PSPROTOCOL_ASCII -> 0
        public const int PSPROTOCOL_ASCII = 0;

        /// PSPCB_RELEASE -> 1
        public const int PSPCB_RELEASE = 1;

        /// PSPCB_CREATE -> 2
        public const int PSPCB_CREATE = 2;

        /// PSPCB_ADDREF -> 0
        public const int PSPCB_ADDREF = 0;

        /// PSN_WIZNEXT -> (PSN_FIRST-7)
        public const uint PSN_WIZNEXT = (NativeConstants.PSN_FIRST - 7);

        /// PSN_WIZFINISH -> (PSN_FIRST-8)
        public const uint PSN_WIZFINISH = (NativeConstants.PSN_FIRST - 8);

        /// PSN_WIZBACK -> (PSN_FIRST-6)
        public const uint PSN_WIZBACK = (NativeConstants.PSN_FIRST - 6);

        /// PSN_TRANSLATEACCELERATOR -> (PSN_FIRST-12)
        public const uint PSN_TRANSLATEACCELERATOR = (NativeConstants.PSN_FIRST - 12);

        /// PSN_SETACTIVE -> (PSN_FIRST-0)
        public const uint PSN_SETACTIVE = (NativeConstants.PSN_FIRST - 0);

        /// PSN_RESET -> (PSN_FIRST-3)
        public const uint PSN_RESET = (NativeConstants.PSN_FIRST - 3);

        /// PSN_QUERYINITIALFOCUS -> (PSN_FIRST-13)
        public const uint PSN_QUERYINITIALFOCUS = (NativeConstants.PSN_FIRST - 13);

        /// PSN_QUERYCANCEL -> (PSN_FIRST-9)
        public const uint PSN_QUERYCANCEL = (NativeConstants.PSN_FIRST - 9);

        /// PSN_LAST -> (0U-299U)
        public const uint PSN_LAST = unchecked(0u - 299u);

        /// PSN_KILLACTIVE -> (PSN_FIRST-1)
        public const uint PSN_KILLACTIVE = (NativeConstants.PSN_FIRST - 1);

        /// PSN_HELP -> (PSN_FIRST-5)
        public const uint PSN_HELP = (NativeConstants.PSN_FIRST - 5);

        /// PSN_GETOBJECT -> (PSN_FIRST-10)
        public const uint PSN_GETOBJECT = (NativeConstants.PSN_FIRST - 10);

        /// PSN_FIRST -> (0U-200U)
        public const uint PSN_FIRST = unchecked(0u - 200u);

        /// PSN_APPLY -> (PSN_FIRST-2)
        public const uint PSN_APPLY = (NativeConstants.PSN_FIRST - 2);

        /// PSNRET_NOERROR -> 0
        public const int PSNRET_NOERROR = 0;

        /// PSNRET_MESSAGEHANDLED -> 3
        public const int PSNRET_MESSAGEHANDLED = 3;

        /// PSNRET_INVALID_NOCHANGEPAGE -> 2
        public const int PSNRET_INVALID_NOCHANGEPAGE = 2;

        /// PSNRET_INVALID -> 1
        public const int PSNRET_INVALID = 1;

        /// PSM_UNCHANGED -> (WM_USER + 109)
        public const int PSM_UNCHANGED = (NativeConstants.WM_USER + 109);

        /// PSM_SETWIZBUTTONS -> (WM_USER + 112)
        public const int PSM_SETWIZBUTTONS = (NativeConstants.WM_USER + 112);

        /// PSM_SETTITLEW -> (WM_USER + 120)
        public const int PSM_SETTITLEW = (NativeConstants.WM_USER + 120);

        /// PSM_SETTITLEA -> (WM_USER + 111)
        public const int PSM_SETTITLEA = (NativeConstants.WM_USER + 111);

        /// PSM_SETTITLE -> PSM_SETTITLEW
        public const int PSM_SETTITLE = NativeConstants.PSM_SETTITLEW;

        /// PSM_SETHEADERTITLEW -> (WM_USER + 126)
        public const int PSM_SETHEADERTITLEW = (NativeConstants.WM_USER + 126);

        /// PSM_SETHEADERTITLEA -> (WM_USER + 125)
        public const int PSM_SETHEADERTITLEA = (NativeConstants.WM_USER + 125);

        /// PSM_SETHEADERTITLE -> PSM_SETHEADERTITLEW
        public const int PSM_SETHEADERTITLE = NativeConstants.PSM_SETHEADERTITLEW;

        /// PSM_SETHEADERSUBTITLEW -> (WM_USER + 128)
        public const int PSM_SETHEADERSUBTITLEW = (NativeConstants.WM_USER + 128);

        /// PSM_SETHEADERSUBTITLEA -> (WM_USER + 127)
        public const int PSM_SETHEADERSUBTITLEA = (NativeConstants.WM_USER + 127);

        /// PSM_SETHEADERSUBTITLE -> PSM_SETHEADERSUBTITLEW
        public const int PSM_SETHEADERSUBTITLE = NativeConstants.PSM_SETHEADERSUBTITLEW;

        /// PSM_SETFINISHTEXTW -> (WM_USER + 121)
        public const int PSM_SETFINISHTEXTW = (NativeConstants.WM_USER + 121);

        /// PSM_SETFINISHTEXTA -> (WM_USER + 115)
        public const int PSM_SETFINISHTEXTA = (NativeConstants.WM_USER + 115);

        /// PSM_SETFINISHTEXT -> PSM_SETFINISHTEXTW
        public const int PSM_SETFINISHTEXT = NativeConstants.PSM_SETFINISHTEXTW;

        /// PSM_SETCURSELID -> (WM_USER + 114)
        public const int PSM_SETCURSELID = (NativeConstants.WM_USER + 114);

        /// PSM_SETCURSEL -> (WM_USER + 101)
        public const int PSM_SETCURSEL = (NativeConstants.WM_USER + 101);

        /// PSM_RESTARTWINDOWS -> (WM_USER + 105)
        public const int PSM_RESTARTWINDOWS = (NativeConstants.WM_USER + 105);

        /// PSM_REMOVEPAGE -> (WM_USER + 102)
        public const int PSM_REMOVEPAGE = (NativeConstants.WM_USER + 102);

        /// PSM_RECALCPAGESIZES -> (WM_USER + 136)
        public const int PSM_RECALCPAGESIZES = (NativeConstants.WM_USER + 136);

        /// PSM_REBOOTSYSTEM -> (WM_USER + 106)
        public const int PSM_REBOOTSYSTEM = (NativeConstants.WM_USER + 106);

        /// PSM_QUERYSIBLINGS -> (WM_USER + 108)
        public const int PSM_QUERYSIBLINGS = (NativeConstants.WM_USER + 108);

        /// PSM_PRESSBUTTON -> (WM_USER + 113)
        public const int PSM_PRESSBUTTON = (NativeConstants.WM_USER + 113);

        /// PSM_PAGETOINDEX -> (WM_USER + 131)
        public const int PSM_PAGETOINDEX = (NativeConstants.WM_USER + 131);

        /// PSM_ISDIALOGMESSAGE -> (WM_USER + 117)
        public const int PSM_ISDIALOGMESSAGE = (NativeConstants.WM_USER + 117);

        /// PSM_INSERTPAGE -> (WM_USER + 119)
        public const int PSM_INSERTPAGE = (NativeConstants.WM_USER + 119);

        /// PSM_INDEXTOPAGE -> (WM_USER + 132)
        public const int PSM_INDEXTOPAGE = (NativeConstants.WM_USER + 132);

        /// PSM_INDEXTOID -> (WM_USER + 134)
        public const int PSM_INDEXTOID = (NativeConstants.WM_USER + 134);

        /// PSM_INDEXTOHWND -> (WM_USER + 130)
        public const int PSM_INDEXTOHWND = (NativeConstants.WM_USER + 130);

        /// PSM_IDTOINDEX -> (WM_USER + 133)
        public const int PSM_IDTOINDEX = (NativeConstants.WM_USER + 133);

        /// PSM_HWNDTOINDEX -> (WM_USER + 129)
        public const int PSM_HWNDTOINDEX = (NativeConstants.WM_USER + 129);

        /// PSM_GETTABCONTROL -> (WM_USER + 116)
        public const int PSM_GETTABCONTROL = (NativeConstants.WM_USER + 116);

        /// PSM_GETRESULT -> (WM_USER + 135)
        public const int PSM_GETRESULT = (NativeConstants.WM_USER + 135);

        /// PSM_GETCURRENTPAGEHWND -> (WM_USER + 118)
        public const int PSM_GETCURRENTPAGEHWND = (NativeConstants.WM_USER + 118);

        /// PSM_CHANGED -> (WM_USER + 104)
        public const int PSM_CHANGED = (NativeConstants.WM_USER + 104);

        /// PSM_CANCELTOCLOSE -> (WM_USER + 107)
        public const int PSM_CANCELTOCLOSE = (NativeConstants.WM_USER + 107);

        /// PSM_APPLY -> (WM_USER + 110)
        public const int PSM_APPLY = (NativeConstants.WM_USER + 110);

        /// PSM_ADDPAGE -> (WM_USER + 103)
        public const int PSM_ADDPAGE = (NativeConstants.WM_USER + 103);

        /// PSLIST_ENTRY -> PSINGLE_LIST_ENTRY
        /// Error generating expression: Value PSINGLE_LIST_ENTRY is not resolved
        public const string PSLIST_ENTRY = "PSINGLE_LIST_ENTRY";

        /// PSINJECT_VMSAVE -> 200
        public const int PSINJECT_VMSAVE = 200;

        /// PSINJECT_VMRESTORE -> 201
        public const int PSINJECT_VMRESTORE = 201;

        /// PSINJECT_TRAILER -> 18
        public const int PSINJECT_TRAILER = 18;

        /// PSINJECT_SHOWPAGE -> 105
        public const int PSINJECT_SHOWPAGE = 105;

        /// PSINJECT_PSADOBE -> 2
        public const int PSINJECT_PSADOBE = 2;

        /// PSINJECT_PLATECOLOR -> 104
        public const int PSINJECT_PLATECOLOR = 104;

        /// PSINJECT_PAGETRAILER -> 103
        public const int PSINJECT_PAGETRAILER = 103;

        /// PSINJECT_PAGESATEND -> 3
        public const int PSINJECT_PAGESATEND = 3;

        /// PSINJECT_PAGES -> 4
        public const int PSINJECT_PAGES = 4;

        /// PSINJECT_PAGEORDER -> 7
        public const int PSINJECT_PAGEORDER = 7;

        /// PSINJECT_PAGENUMBER -> 100
        public const int PSINJECT_PAGENUMBER = 100;

        /// PSINJECT_PAGEBBOX -> 106
        public const int PSINJECT_PAGEBBOX = 106;

        /// PSINJECT_ORIENTATION -> 8
        public const int PSINJECT_ORIENTATION = 8;

        /// PSINJECT_EOF -> 19
        public const int PSINJECT_EOF = 19;

        /// PSINJECT_ENDSTREAM -> 20
        public const int PSINJECT_ENDSTREAM = 20;

        /// PSINJECT_ENDSETUP -> 17
        public const int PSINJECT_ENDSETUP = 17;

        /// PSINJECT_ENDPROLOG -> 15
        public const int PSINJECT_ENDPROLOG = 15;

        /// PSINJECT_ENDPAGESETUP -> 102
        public const int PSINJECT_ENDPAGESETUP = 102;

        /// PSINJECT_ENDPAGECOMMENTS -> 107
        public const int PSINJECT_ENDPAGECOMMENTS = 107;

        /// PSINJECT_ENDDEFAULTS -> 13
        public const int PSINJECT_ENDDEFAULTS = 13;

        /// PSINJECT_DOCUMENTPROCESSCOLORSATEND -> 21
        public const int PSINJECT_DOCUMENTPROCESSCOLORSATEND = 21;

        /// PSINJECT_DOCUMENTPROCESSCOLORS -> 10
        public const int PSINJECT_DOCUMENTPROCESSCOLORS = 10;

        /// PSINJECT_DOCSUPPLIEDRES -> 6
        public const int PSINJECT_DOCSUPPLIEDRES = 6;

        /// PSINJECT_DOCNEEDEDRES -> 5
        public const int PSINJECT_DOCNEEDEDRES = 5;

        /// PSINJECT_COMMENTS -> 11
        public const int PSINJECT_COMMENTS = 11;

        /// PSINJECT_BOUNDINGBOX -> 9
        public const int PSINJECT_BOUNDINGBOX = 9;

        /// PSINJECT_BEGINSTREAM -> 1
        public const int PSINJECT_BEGINSTREAM = 1;

        /// PSINJECT_BEGINSETUP -> 16
        public const int PSINJECT_BEGINSETUP = 16;

        /// PSINJECT_BEGINPROLOG -> 14
        public const int PSINJECT_BEGINPROLOG = 14;

        /// PSINJECT_BEGINPAGESETUP -> 101
        public const int PSINJECT_BEGINPAGESETUP = 101;

        /// PSINJECT_BEGINDEFAULTS -> 12
        public const int PSINJECT_BEGINDEFAULTS = 12;

        /// PSIDENT_PSCENTRIC -> 1
        public const int PSIDENT_PSCENTRIC = 1;

        /// PSIDENT_GDICENTRIC -> 0
        public const int PSIDENT_GDICENTRIC = 0;

        /// PSH_WIZARD_LITE -> 0x00400000
        public const int PSH_WIZARD_LITE = 4194304;

        /// PSH_WIZARDHASFINISH -> 0x00000010
        public const int PSH_WIZARDHASFINISH = 16;

        /// PSH_WIZARDCONTEXTHELP -> 0x00001000
        public const int PSH_WIZARDCONTEXTHELP = 4096;

        /// PSH_WIZARD97 -> 0x01000000
        public const int PSH_WIZARD97 = 16777216;

        /// PSH_WIZARD -> 0x00000020
        public const int PSH_WIZARD = 32;

        /// PSH_WATERMARK -> 0x00008000
        public const int PSH_WATERMARK = 32768;

        /// PSH_USEPSTARTPAGE -> 0x00000040
        public const int PSH_USEPSTARTPAGE = 64;

        /// PSH_USEPAGELANG -> 0x00200000
        public const int PSH_USEPAGELANG = 2097152;

        /// PSH_USEICONID -> 0x00000004
        public const int PSH_USEICONID = 4;

        /// PSH_USEHPLWATERMARK -> 0x00020000
        public const int PSH_USEHPLWATERMARK = 131072;

        /// PSH_USEHICON -> 0x00000002
        public const int PSH_USEHICON = 2;

        /// PSH_USEHBMWATERMARK -> 0x00010000
        public const int PSH_USEHBMWATERMARK = 65536;

        /// PSH_USEHBMHEADER -> 0x00100000
        public const int PSH_USEHBMHEADER = 1048576;

        /// PSH_USECALLBACK -> 0x00000100
        public const int PSH_USECALLBACK = 256;

        /// PSH_STRETCHWATERMARK -> 0x00040000
        public const int PSH_STRETCHWATERMARK = 262144;

        /// PSH_RTLREADING -> 0x00000800
        public const int PSH_RTLREADING = 2048;

        /// PSH_PROPTITLE -> 0x00000001
        public const int PSH_PROPTITLE = 1;

        /// PSH_PROPSHEETPAGE -> 0x00000008
        public const int PSH_PROPSHEETPAGE = 8;

        /// PSH_NOCONTEXTHELP -> 0x02000000
        public const int PSH_NOCONTEXTHELP = 33554432;

        /// PSH_NOAPPLYNOW -> 0x00000080
        public const int PSH_NOAPPLYNOW = 128;

        /// PSH_MODELESS -> 0x00000400
        public const int PSH_MODELESS = 1024;

        /// PSH_HEADER -> 0x00080000
        public const int PSH_HEADER = 524288;

        /// PSH_HASHELP -> 0x00000200
        public const int PSH_HASHELP = 512;

        /// PSH_DEFAULT -> 0x00000000
        public const int PSH_DEFAULT = 0;

        /// pshHelp -> psh15
        public const int pshHelp = NativeConstants.psh15;

        /// psh9 -> 0x0408
        public const int psh9 = 1032;

        /// psh8 -> 0x0407
        public const int psh8 = 1031;

        /// psh7 -> 0x0406
        public const int psh7 = 1030;

        /// psh6 -> 0x0405
        public const int psh6 = 1029;

        /// psh5 -> 0x0404
        public const int psh5 = 1028;

        /// psh4 -> 0x0403
        public const int psh4 = 1027;

        /// psh3 -> 0x0402
        public const int psh3 = 1026;

        /// psh2 -> 0x0401
        public const int psh2 = 1025;

        /// psh16 -> 0x040f
        public const int psh16 = 1039;

        /// psh15 -> 0x040e
        public const int psh15 = 1038;

        /// psh14 -> 0x040d
        public const int psh14 = 1037;

        /// psh13 -> 0x040c
        public const int psh13 = 1036;

        /// psh12 -> 0x040b
        public const int psh12 = 1035;

        /// psh11 -> 0x040a
        public const int psh11 = 1034;

        /// psh10 -> 0x0409
        public const int psh10 = 1033;

        /// psh1 -> 0x0400
        public const int psh1 = 1024;

        /// PSEC_WINNT_AUTH_IDENTITY -> PSEC_WINNT_AUTH_IDENTITY_W
        /// Error generating expression: Value PSEC_WINNT_AUTH_IDENTITY_W is not resolved
        public const string PSEC_WINNT_AUTH_IDENTITY = "PSEC_WINNT_AUTH_IDENTITY_W";

        /// PSD_SHOWHELP -> 0x00000800
        public const int PSD_SHOWHELP = 2048;

        /// PSD_RETURNDEFAULT -> 0x00000400
        public const int PSD_RETURNDEFAULT = 1024;

        /// PSD_NOWARNING -> 0x00000080
        public const int PSD_NOWARNING = 128;

        /// PSD_NONETWORKBUTTON -> 0x00200000
        public const int PSD_NONETWORKBUTTON = 2097152;

        /// PSD_MINMARGINS -> 0x00000001
        public const int PSD_MINMARGINS = 1;

        /// PSD_MARGINS -> 0x00000002
        public const int PSD_MARGINS = 2;

        /// PSD_INWININIINTLMEASURE -> 0x00000000
        public const int PSD_INWININIINTLMEASURE = 0;

        /// PSD_INTHOUSANDTHSOFINCHES -> 0x00000004
        public const int PSD_INTHOUSANDTHSOFINCHES = 4;

        /// PSD_INHUNDREDTHSOFMILLIMETERS -> 0x00000008
        public const int PSD_INHUNDREDTHSOFMILLIMETERS = 8;

        /// PSD_ENABLEPAGESETUPTEMPLATEHANDLE -> 0x00020000
        public const int PSD_ENABLEPAGESETUPTEMPLATEHANDLE = 131072;

        /// PSD_ENABLEPAGESETUPTEMPLATE -> 0x00008000
        public const int PSD_ENABLEPAGESETUPTEMPLATE = 32768;

        /// PSD_ENABLEPAGESETUPHOOK -> 0x00002000
        public const int PSD_ENABLEPAGESETUPHOOK = 8192;

        /// PSD_ENABLEPAGEPAINTHOOK -> 0x00040000
        public const int PSD_ENABLEPAGEPAINTHOOK = 262144;

        /// PSD_DISABLEPRINTER -> 0x00000020
        public const int PSD_DISABLEPRINTER = 32;

        /// PSD_DISABLEPAPER -> 0x00000200
        public const int PSD_DISABLEPAPER = 512;

        /// PSD_DISABLEPAGEPAINTING -> 0x00080000
        public const int PSD_DISABLEPAGEPAINTING = 524288;

        /// PSD_DISABLEORIENTATION -> 0x00000100
        public const int PSD_DISABLEORIENTATION = 256;

        /// PSD_DISABLEMARGINS -> 0x00000010
        public const int PSD_DISABLEMARGINS = 16;

        /// PSD_DEFAULTMINMARGINS -> 0x00000000
        public const int PSD_DEFAULTMINMARGINS = 0;

        /// PSCB_PRECREATE -> 2
        public const int PSCB_PRECREATE = 2;

        /// PSCB_INITIALIZED -> 1
        public const int PSCB_INITIALIZED = 1;

        /// PSCARD_READERSTATE_W -> PSCARD_READERSTATEW
        /// Error generating expression: Value PSCARD_READERSTATEW is not resolved
        public const string PSCARD_READERSTATE_W = "PSCARD_READERSTATEW";

        /// PSCARD_READERSTATE_A -> PSCARD_READERSTATEA
        /// Error generating expression: Value PSCARD_READERSTATEA is not resolved
        public const string PSCARD_READERSTATE_A = "PSCARD_READERSTATEA";

        /// PSBTN_OK -> 3
        public const int PSBTN_OK = 3;

        /// PSBTN_NEXT -> 1
        public const int PSBTN_NEXT = 1;

        /// PSBTN_MAX -> 6
        public const int PSBTN_MAX = 6;

        /// PSBTN_HELP -> 6
        public const int PSBTN_HELP = 6;

        /// PSBTN_FINISH -> 2
        public const int PSBTN_FINISH = 2;

        /// PSBTN_CANCEL -> 5
        public const int PSBTN_CANCEL = 5;

        /// PSBTN_BACK -> 0
        public const int PSBTN_BACK = 0;

        /// PSBTN_APPLYNOW -> 4
        public const int PSBTN_APPLYNOW = 4;

        /// PR_JOBSTATUS -> 0x0000
        public const int PR_JOBSTATUS = 0;

        /// PRSPEC_PROPID -> ( 1 )
        public const int PRSPEC_PROPID = 1;

        /// PRSPEC_LPWSTR -> ( 0 )
        public const int PRSPEC_LPWSTR = 0;

        /// PRSPEC_INVALID -> ( 0xffffffff )
        public const int PRSPEC_INVALID = -1;

        /// PRPC_SECURITY_QOS_V3 -> PRPC_SECURITY_QOS_V3_W
        /// Error generating expression: Value PRPC_SECURITY_QOS_V3_W is not resolved
        public const string PRPC_SECURITY_QOS_V3 = "PRPC_SECURITY_QOS_V3_W";

        /// PRPC_SECURITY_QOS_V2 -> PRPC_SECURITY_QOS_V2_W
        /// Error generating expression: Value PRPC_SECURITY_QOS_V2_W is not resolved
        public const string PRPC_SECURITY_QOS_V2 = "PRPC_SECURITY_QOS_V2_W";

        /// PRPC_HTTP_TRANSPORT_CREDENTIALS -> PRPC_HTTP_TRANSPORT_CREDENTIALS_W
        /// Error generating expression: Value PRPC_HTTP_TRANSPORT_CREDENTIALS_W is not resolved
        public const string PRPC_HTTP_TRANSPORT_CREDENTIALS = "PRPC_HTTP_TRANSPORT_CREDENTIALS_W";

        /// PROV_SSL -> 6
        public const int PROV_SSL = 6;

        /// PROV_SPYRUS_LYNKS -> 20
        public const int PROV_SPYRUS_LYNKS = 20;

        /// PROV_RSA_SIG -> 2
        public const int PROV_RSA_SIG = 2;

        /// PROV_RSA_SCHANNEL -> 12
        public const int PROV_RSA_SCHANNEL = 12;

        /// PROV_RSA_FULL -> 1
        public const int PROV_RSA_FULL = 1;

        /// PROV_RSA_AES -> 24
        public const int PROV_RSA_AES = 24;

        /// PROV_RNG -> 21
        public const int PROV_RNG = 21;

        /// PROV_REPLACE_OWF -> 23
        public const int PROV_REPLACE_OWF = 23;

        /// PROV_MS_EXCHANGE -> 5
        public const int PROV_MS_EXCHANGE = 5;

        /// PROV_INTEL_SEC -> 22
        public const int PROV_INTEL_SEC = 22;

        /// PROV_FORTEZZA -> 4
        public const int PROV_FORTEZZA = 4;

        /// PROV_EC_ECNRA_SIG -> 15
        public const int PROV_EC_ECNRA_SIG = 15;

        /// PROV_EC_ECNRA_FULL -> 17
        public const int PROV_EC_ECNRA_FULL = 17;

        /// PROV_EC_ECDSA_SIG -> 14
        public const int PROV_EC_ECDSA_SIG = 14;

        /// PROV_EC_ECDSA_FULL -> 16
        public const int PROV_EC_ECDSA_FULL = 16;

        /// PROV_DSS_DH -> 13
        public const int PROV_DSS_DH = 13;

        /// PROV_DSS -> 3
        public const int PROV_DSS = 3;

        /// PROV_DH_SCHANNEL -> 18
        public const int PROV_DH_SCHANNEL = 18;

        /// PROVIDER_KEEPS_VALUE_LENGTH -> 0x1
        public const int PROVIDER_KEEPS_VALUE_LENGTH = 1;

        /// PROTOCOLFLAG_NO_PICS_CHECK -> 0x00000001
        public const int PROTOCOLFLAG_NO_PICS_CHECK = 1;

        /// PROTECTED_SACL_SECURITY_INFORMATION -> (0x40000000L)
        public const int PROTECTED_SACL_SECURITY_INFORMATION = 1073741824;

        /// PROTECTED_DACL_SECURITY_INFORMATION -> (0x80000000L)
        public const int PROTECTED_DACL_SECURITY_INFORMATION = -2147483648;

        /// PROP_SM_CYDLG -> 188
        public const int PROP_SM_CYDLG = 188;

        /// PROP_SM_CXDLG -> 212
        public const int PROP_SM_CXDLG = 212;

        /// PROP_MED_CYDLG -> 215
        public const int PROP_MED_CYDLG = 215;

        /// PROP_MED_CXDLG -> 227
        public const int PROP_MED_CXDLG = 227;

        /// PROP_LG_CYDLG -> 218
        public const int PROP_LG_CYDLG = 218;

        /// PROP_LG_CXDLG -> 252
        public const int PROP_LG_CXDLG = 252;

        /// PROPSHEETPAGE_V3 -> PROPSHEETPAGEW_V3
        /// Error generating expression: Value PROPSHEETPAGEW_V3 is not resolved
        public const string PROPSHEETPAGE_V3 = "PROPSHEETPAGEW_V3";

        /// PROPSHEETPAGE_V2_SIZE -> PROPSHEETPAGEW_V2_SIZE
        public const string PROPSHEETPAGE_V2_SIZE = NativeConstants.PROPSHEETPAGEW_V2_SIZE;

        /// PROPSHEETPAGE_V2 -> PROPSHEETPAGEW_V2
        /// Error generating expression: Value PROPSHEETPAGEW_V2 is not resolved
        public const string PROPSHEETPAGE_V2 = "PROPSHEETPAGEW_V2";

        /// PROPSHEETPAGE_V1_SIZE -> PROPSHEETPAGEW_V1_SIZE
        public const string PROPSHEETPAGE_V1_SIZE = NativeConstants.PROPSHEETPAGEW_V1_SIZE;

        /// PROPSHEETPAGE_V1 -> PROPSHEETPAGEW_V1
        /// Error generating expression: Value PROPSHEETPAGEW_V1 is not resolved
        public const string PROPSHEETPAGE_V1 = "PROPSHEETPAGEW_V1";

        /// PROPSHEETPAGE_LATEST -> PROPSHEETPAGEW_LATEST
        /// Error generating expression: Value PROPSHEETPAGEW_LATEST is not resolved
        public const string PROPSHEETPAGE_LATEST = "PROPSHEETPAGEW_LATEST";

        /// PROPSHEETPAGE -> PROPSHEETPAGEW
        /// Error generating expression: Value PROPSHEETPAGEW is not resolved
        public const string PROPSHEETPAGE = "PROPSHEETPAGEW";

        /// PROPSHEETHEADER_V2_SIZE -> PROPSHEETHEADERW_V2_SIZE
        public const string PROPSHEETHEADER_V2_SIZE = NativeConstants.PROPSHEETHEADERW_V2_SIZE;

        /// PROPSHEETHEADER_V1_SIZE -> PROPSHEETHEADERW_V1_SIZE
        public const string PROPSHEETHEADER_V1_SIZE = NativeConstants.PROPSHEETHEADERW_V1_SIZE;

        /// PROPSHEETHEADER -> PROPSHEETHEADERW
        /// Error generating expression: Value PROPSHEETHEADERW is not resolved
        public const string PROPSHEETHEADER = "PROPSHEETHEADERW";

        /// PROPSET_BEHAVIOR_CASE_SENSITIVE -> ( 1 )
        public const int PROPSET_BEHAVIOR_CASE_SENSITIVE = 1;

        /// PROPSETHDR_OSVERSION_UNKNOWN -> 0xFFFFFFFF
        public const int PROPSETHDR_OSVERSION_UNKNOWN = -1;

        /// PROPSETFLAG_UNBUFFERED -> ( 4 )
        public const int PROPSETFLAG_UNBUFFERED = 4;

        /// PROPSETFLAG_NONSIMPLE -> ( 1 )
        public const int PROPSETFLAG_NONSIMPLE = 1;

        /// PROPSETFLAG_DEFAULT -> ( 0 )
        public const int PROPSETFLAG_DEFAULT = 0;

        /// PROPSETFLAG_CASE_SENSITIVE -> ( 8 )
        public const int PROPSETFLAG_CASE_SENSITIVE = 8;

        /// PROPSETFLAG_ANSI -> ( 2 )
        public const int PROPSETFLAG_ANSI = 2;

        /// PropertySheet -> PropertySheetW
        /// Error generating expression: Value PropertySheetW is not resolved
        public const string PropertySheet = "PropertySheetW";

        /// PROOF_QUALITY -> 2
        public const int PROOF_QUALITY = 2;

        /// PROGRESS_STOP -> 2
        public const int PROGRESS_STOP = 2;

        /// PROGRESS_QUIET -> 3
        public const int PROGRESS_QUIET = 3;

        /// PROGRESS_CONTINUE -> 0
        public const int PROGRESS_CONTINUE = 0;

        /// PROGRESS_CANCEL -> 1
        public const int PROGRESS_CANCEL = 1;

        /// PROFILE_USER -> 0x10000000
        public const int PROFILE_USER = 268435456;

        /// PROFILE_SERVER -> 0x40000000
        public const int PROFILE_SERVER = 1073741824;

        /// PROFILE_KERNEL -> 0x20000000
        public const int PROFILE_KERNEL = 536870912;

        /// PRODUCT_ID_LENGTH -> 16
        public const int PRODUCT_ID_LENGTH = 16;

        /// PROCESS_VM_WRITE -> (0x0020)
        public const int PROCESS_VM_WRITE = 32;

        /// PROCESS_VM_READ -> (0x0010)
        public const int PROCESS_VM_READ = 16;

        /// PROCESS_VM_OPERATION -> (0x0008)
        public const int PROCESS_VM_OPERATION = 8;

        /// PROCESS_TERMINATE -> (0x0001)
        public const int PROCESS_TERMINATE = 1;

        /// PROCESS_SUSPEND_RESUME -> (0x0800)
        public const int PROCESS_SUSPEND_RESUME = 2048;

        /// PROCESS_SET_SESSIONID -> (0x0004)
        public const int PROCESS_SET_SESSIONID = 4;

        /// PROCESS_SET_QUOTA -> (0x0100)
        public const int PROCESS_SET_QUOTA = 256;

        /// PROCESS_SET_INFORMATION -> (0x0200)
        public const int PROCESS_SET_INFORMATION = 512;

        /// PROCESS_QUERY_INFORMATION -> (0x0400)
        public const int PROCESS_QUERY_INFORMATION = 1024;

        /// PROCESS_HEAP_UNCOMMITTED_RANGE -> 0x0002
        public const int PROCESS_HEAP_UNCOMMITTED_RANGE = 2;

        /// PROCESS_HEAP_REGION -> 0x0001
        public const int PROCESS_HEAP_REGION = 1;

        /// PROCESS_HEAP_ENTRY_MOVEABLE -> 0x0010
        public const int PROCESS_HEAP_ENTRY_MOVEABLE = 16;

        /// PROCESS_HEAP_ENTRY_DDESHARE -> 0x0020
        public const int PROCESS_HEAP_ENTRY_DDESHARE = 32;

        /// PROCESS_HEAP_ENTRY_BUSY -> 0x0004
        public const int PROCESS_HEAP_ENTRY_BUSY = 4;

        /// PROCESS_DUP_HANDLE -> (0x0040)
        public const int PROCESS_DUP_HANDLE = 64;

        /// PROCESS_CREATE_THREAD -> (0x0002)
        public const int PROCESS_CREATE_THREAD = 2;

        /// PROCESS_CREATE_PROCESS -> (0x0080)
        public const int PROCESS_CREATE_PROCESS = 128;

        /// PROCESS_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE |                                    0xFFF)
        public const int PROCESS_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE | 4095));

        /// PROCESSOR_STRONGARM -> 2577
        public const int PROCESSOR_STRONGARM = 2577;

        /// PROCESSOR_SHx_SH4 -> 104
        public const int PROCESSOR_SHx_SH4 = 104;

        /// PROCESSOR_SHx_SH3 -> 103
        public const int PROCESSOR_SHx_SH3 = 103;

        /// PROCESSOR_PPC_620 -> 620
        public const int PROCESSOR_PPC_620 = 620;

        /// PROCESSOR_PPC_604 -> 604
        public const int PROCESSOR_PPC_604 = 604;

        /// PROCESSOR_PPC_603 -> 603
        public const int PROCESSOR_PPC_603 = 603;

        /// PROCESSOR_PPC_601 -> 601
        public const int PROCESSOR_PPC_601 = 601;

        /// PROCESSOR_OPTIL -> 0x494f
        public const int PROCESSOR_OPTIL = 18767;

        /// PROCESSOR_MOTOROLA_821 -> 821
        public const int PROCESSOR_MOTOROLA_821 = 821;

        /// PROCESSOR_MIPS_R4000 -> 4000
        public const int PROCESSOR_MIPS_R4000 = 4000;

        /// PROCESSOR_INTEL_PENTIUM -> 586
        public const int PROCESSOR_INTEL_PENTIUM = 586;

        /// PROCESSOR_INTEL_IA64 -> 2200
        public const int PROCESSOR_INTEL_IA64 = 2200;

        /// PROCESSOR_INTEL_486 -> 486
        public const int PROCESSOR_INTEL_486 = 486;

        /// PROCESSOR_INTEL_386 -> 386
        public const int PROCESSOR_INTEL_386 = 386;

        /// PROCESSOR_HITACHI_SH4 -> 10005
        public const int PROCESSOR_HITACHI_SH4 = 10005;

        /// PROCESSOR_HITACHI_SH3E -> 10004
        public const int PROCESSOR_HITACHI_SH3E = 10004;

        /// PROCESSOR_HITACHI_SH3 -> 10003
        public const int PROCESSOR_HITACHI_SH3 = 10003;

        /// PROCESSOR_ARM_7TDMI -> 70001
        public const int PROCESSOR_ARM_7TDMI = 70001;

        /// PROCESSOR_ARM920 -> 2336
        public const int PROCESSOR_ARM920 = 2336;

        /// PROCESSOR_ARM820 -> 2080
        public const int PROCESSOR_ARM820 = 2080;

        /// PROCESSOR_ARM720 -> 1824
        public const int PROCESSOR_ARM720 = 1824;

        /// PROCESSOR_ARCHITECTURE_UNKNOWN -> 0xFFFF
        public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 65535;

        /// PROCESSOR_ARCHITECTURE_SHX -> 4
        public const int PROCESSOR_ARCHITECTURE_SHX = 4;

        /// PROCESSOR_ARCHITECTURE_PPC -> 3
        public const int PROCESSOR_ARCHITECTURE_PPC = 3;

        /// PROCESSOR_ARCHITECTURE_MSIL -> 8
        public const int PROCESSOR_ARCHITECTURE_MSIL = 8;

        /// PROCESSOR_ARCHITECTURE_MIPS -> 1
        public const int PROCESSOR_ARCHITECTURE_MIPS = 1;

        /// PROCESSOR_ARCHITECTURE_INTEL -> 0
        public const int PROCESSOR_ARCHITECTURE_INTEL = 0;

        /// PROCESSOR_ARCHITECTURE_IA64 -> 6
        public const int PROCESSOR_ARCHITECTURE_IA64 = 6;

        /// PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 -> 10
        public const int PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 = 10;

        /// PROCESSOR_ARCHITECTURE_ARM -> 5
        public const int PROCESSOR_ARCHITECTURE_ARM = 5;

        /// PROCESSOR_ARCHITECTURE_AMD64 -> 9
        public const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

        /// PROCESSOR_ARCHITECTURE_ALPHA64 -> 7
        public const int PROCESSOR_ARCHITECTURE_ALPHA64 = 7;

        /// PROCESSOR_ARCHITECTURE_ALPHA -> 2
        public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;

        /// PROCESSOR_AMD_X8664 -> 8664
        public const int PROCESSOR_AMD_X8664 = 8664;

        /// PROCESSOR_ALPHA_21064 -> 21064
        public const int PROCESSOR_ALPHA_21064 = 21064;

        /// PRNSETUPDLGORD -> 1539
        public const int PRNSETUPDLGORD = 1539;

        /// PRIVILEGE_SET_ALL_NECESSARY -> (1)
        public const int PRIVILEGE_SET_ALL_NECESSARY = 1;

        /// PrivilegedServiceAuditAlarm -> PrivilegedServiceAuditAlarmW
        /// Error generating expression: Value PrivilegedServiceAuditAlarmW is not resolved
        public const string PrivilegedServiceAuditAlarm = "PrivilegedServiceAuditAlarmW";

        /// PRIVATEKEYBLOB -> 0x7
        public const int PRIVATEKEYBLOB = 7;

        /// PrivateExtractIcons -> PrivateExtractIconsW
        /// Error generating expression: Value PrivateExtractIconsW is not resolved
        public const string PrivateExtractIcons = "PrivateExtractIconsW";

        /// PRINTRATEUNIT_PPM -> 1
        public const int PRINTRATEUNIT_PPM = 1;

        /// PRINTRATEUNIT_LPM -> 3
        public const int PRINTRATEUNIT_LPM = 3;

        /// PRINTRATEUNIT_IPM -> 4
        public const int PRINTRATEUNIT_IPM = 4;

        /// PRINTRATEUNIT_CPS -> 2
        public const int PRINTRATEUNIT_CPS = 2;

        /// PRINTER_WRITE -> (STANDARD_RIGHTS_WRITE        |                               PRINTER_ACCESS_USE)
        public const int PRINTER_WRITE = (NativeConstants.STANDARD_RIGHTS_WRITE | NativeConstants.PRINTER_ACCESS_USE);

        /// PRINTER_STATUS_WARMING_UP -> 0x00010000
        public const int PRINTER_STATUS_WARMING_UP = 65536;

        /// PRINTER_STATUS_WAITING -> 0x00002000
        public const int PRINTER_STATUS_WAITING = 8192;

        /// PRINTER_STATUS_USER_INTERVENTION -> 0x00100000
        public const int PRINTER_STATUS_USER_INTERVENTION = 1048576;

        /// PRINTER_STATUS_TONER_LOW -> 0x00020000
        public const int PRINTER_STATUS_TONER_LOW = 131072;

        /// PRINTER_STATUS_SERVER_UNKNOWN -> 0x00800000
        public const int PRINTER_STATUS_SERVER_UNKNOWN = 8388608;

        /// PRINTER_STATUS_PROCESSING -> 0x00004000
        public const int PRINTER_STATUS_PROCESSING = 16384;

        /// PRINTER_STATUS_PRINTING -> 0x00000400
        public const int PRINTER_STATUS_PRINTING = 1024;

        /// PRINTER_STATUS_POWER_SAVE -> 0x01000000
        public const int PRINTER_STATUS_POWER_SAVE = 16777216;

        /// PRINTER_STATUS_PENDING_DELETION -> 0x00000004
        public const int PRINTER_STATUS_PENDING_DELETION = 4;

        /// PRINTER_STATUS_PAUSED -> 0x00000001
        public const int PRINTER_STATUS_PAUSED = 1;

        /// PRINTER_STATUS_PAPER_PROBLEM -> 0x00000040
        public const int PRINTER_STATUS_PAPER_PROBLEM = 64;

        /// PRINTER_STATUS_PAPER_OUT -> 0x00000010
        public const int PRINTER_STATUS_PAPER_OUT = 16;

        /// PRINTER_STATUS_PAPER_JAM -> 0x00000008
        public const int PRINTER_STATUS_PAPER_JAM = 8;

        /// PRINTER_STATUS_PAGE_PUNT -> 0x00080000
        public const int PRINTER_STATUS_PAGE_PUNT = 524288;

        /// PRINTER_STATUS_OUT_OF_MEMORY -> 0x00200000
        public const int PRINTER_STATUS_OUT_OF_MEMORY = 2097152;

        /// PRINTER_STATUS_OUTPUT_BIN_FULL -> 0x00000800
        public const int PRINTER_STATUS_OUTPUT_BIN_FULL = 2048;

        /// PRINTER_STATUS_OFFLINE -> 0x00000080
        public const int PRINTER_STATUS_OFFLINE = 128;

        /// PRINTER_STATUS_NO_TONER -> 0x00040000
        public const int PRINTER_STATUS_NO_TONER = 262144;

        /// PRINTER_STATUS_NOT_AVAILABLE -> 0x00001000
        public const int PRINTER_STATUS_NOT_AVAILABLE = 4096;

        /// PRINTER_STATUS_MANUAL_FEED -> 0x00000020
        public const int PRINTER_STATUS_MANUAL_FEED = 32;

        /// PRINTER_STATUS_IO_ACTIVE -> 0x00000100
        public const int PRINTER_STATUS_IO_ACTIVE = 256;

        /// PRINTER_STATUS_INITIALIZING -> 0x00008000
        public const int PRINTER_STATUS_INITIALIZING = 32768;

        /// PRINTER_STATUS_ERROR -> 0x00000002
        public const int PRINTER_STATUS_ERROR = 2;

        /// PRINTER_STATUS_DOOR_OPEN -> 0x00400000
        public const int PRINTER_STATUS_DOOR_OPEN = 4194304;

        /// PRINTER_STATUS_BUSY -> 0x00000200
        public const int PRINTER_STATUS_BUSY = 512;

        /// PRINTER_READ -> (STANDARD_RIGHTS_READ         |                               PRINTER_ACCESS_USE)
        public const int PRINTER_READ = (NativeConstants.STANDARD_RIGHTS_READ | NativeConstants.PRINTER_ACCESS_USE);

        /// PRINTER_NOTIFY_TYPE -> 0x00
        public const int PRINTER_NOTIFY_TYPE = 0;

        /// PRINTER_NOTIFY_OPTIONS_REFRESH -> 0x01
        public const int PRINTER_NOTIFY_OPTIONS_REFRESH = 1;

        /// PRINTER_NOTIFY_INFO_DISCARDED -> 0x01
        public const int PRINTER_NOTIFY_INFO_DISCARDED = 1;

        /// PRINTER_NOTIFY_FIELD_UNTIL_TIME -> 0x11
        public const int PRINTER_NOTIFY_FIELD_UNTIL_TIME = 17;

        /// PRINTER_NOTIFY_FIELD_TOTAL_PAGES -> 0x16
        public const int PRINTER_NOTIFY_FIELD_TOTAL_PAGES = 22;

        /// PRINTER_NOTIFY_FIELD_TOTAL_BYTES -> 0x18
        public const int PRINTER_NOTIFY_FIELD_TOTAL_BYTES = 24;

        /// PRINTER_NOTIFY_FIELD_STATUS_STRING -> 0x13
        public const int PRINTER_NOTIFY_FIELD_STATUS_STRING = 19;

        /// PRINTER_NOTIFY_FIELD_STATUS -> 0x12
        public const int PRINTER_NOTIFY_FIELD_STATUS = 18;

        /// PRINTER_NOTIFY_FIELD_START_TIME -> 0x10
        public const int PRINTER_NOTIFY_FIELD_START_TIME = 16;

        /// PRINTER_NOTIFY_FIELD_SHARE_NAME -> 0x02
        public const int PRINTER_NOTIFY_FIELD_SHARE_NAME = 2;

        /// PRINTER_NOTIFY_FIELD_SERVER_NAME -> 0x00
        public const int PRINTER_NOTIFY_FIELD_SERVER_NAME = 0;

        /// PRINTER_NOTIFY_FIELD_SEPFILE -> 0x08
        public const int PRINTER_NOTIFY_FIELD_SEPFILE = 8;

        /// PRINTER_NOTIFY_FIELD_SECURITY_DESCRIPTOR -> 0x0C
        public const int PRINTER_NOTIFY_FIELD_SECURITY_DESCRIPTOR = 12;

        /// PRINTER_NOTIFY_FIELD_PRIORITY -> 0x0E
        public const int PRINTER_NOTIFY_FIELD_PRIORITY = 14;

        /// PRINTER_NOTIFY_FIELD_PRINT_PROCESSOR -> 0x09
        public const int PRINTER_NOTIFY_FIELD_PRINT_PROCESSOR = 9;

        /// PRINTER_NOTIFY_FIELD_PRINTER_NAME -> 0x01
        public const int PRINTER_NOTIFY_FIELD_PRINTER_NAME = 1;

        /// PRINTER_NOTIFY_FIELD_PORT_NAME -> 0x03
        public const int PRINTER_NOTIFY_FIELD_PORT_NAME = 3;

        /// PRINTER_NOTIFY_FIELD_PARAMETERS -> 0x0A
        public const int PRINTER_NOTIFY_FIELD_PARAMETERS = 10;

        /// PRINTER_NOTIFY_FIELD_PAGES_PRINTED -> 0x17
        public const int PRINTER_NOTIFY_FIELD_PAGES_PRINTED = 23;

        /// PRINTER_NOTIFY_FIELD_OBJECT_GUID -> 0x1A
        public const int PRINTER_NOTIFY_FIELD_OBJECT_GUID = 26;

        /// PRINTER_NOTIFY_FIELD_LOCATION -> 0x06
        public const int PRINTER_NOTIFY_FIELD_LOCATION = 6;

        /// PRINTER_NOTIFY_FIELD_DRIVER_NAME -> 0x04
        public const int PRINTER_NOTIFY_FIELD_DRIVER_NAME = 4;

        /// PRINTER_NOTIFY_FIELD_DEVMODE -> 0x07
        public const int PRINTER_NOTIFY_FIELD_DEVMODE = 7;

        /// PRINTER_NOTIFY_FIELD_DEFAULT_PRIORITY -> 0x0F
        public const int PRINTER_NOTIFY_FIELD_DEFAULT_PRIORITY = 15;

        /// PRINTER_NOTIFY_FIELD_DATATYPE -> 0x0B
        public const int PRINTER_NOTIFY_FIELD_DATATYPE = 11;

        /// PRINTER_NOTIFY_FIELD_COMMENT -> 0x05
        public const int PRINTER_NOTIFY_FIELD_COMMENT = 5;

        /// PRINTER_NOTIFY_FIELD_CJOBS -> 0x14
        public const int PRINTER_NOTIFY_FIELD_CJOBS = 20;

        /// PRINTER_NOTIFY_FIELD_BYTES_PRINTED -> 0x19
        public const int PRINTER_NOTIFY_FIELD_BYTES_PRINTED = 25;

        /// PRINTER_NOTIFY_FIELD_AVERAGE_PPM -> 0x15
        public const int PRINTER_NOTIFY_FIELD_AVERAGE_PPM = 21;

        /// PRINTER_NOTIFY_FIELD_ATTRIBUTES -> 0x0D
        public const int PRINTER_NOTIFY_FIELD_ATTRIBUTES = 13;

        /// PRINTER_FONTTYPE -> 0x4000
        public const int PRINTER_FONTTYPE = 16384;

        /// PRINTER_EXECUTE -> (STANDARD_RIGHTS_EXECUTE      |                               PRINTER_ACCESS_USE)
        public const int PRINTER_EXECUTE = (NativeConstants.STANDARD_RIGHTS_EXECUTE | NativeConstants.PRINTER_ACCESS_USE);

        /// PRINTER_ERROR_WARNING -> 0x40000000
        public const int PRINTER_ERROR_WARNING = 1073741824;

        /// PRINTER_ERROR_SEVERE -> 0x20000000
        public const int PRINTER_ERROR_SEVERE = 536870912;

        /// PRINTER_ERROR_OUTOFTONER -> 0x00000004
        public const int PRINTER_ERROR_OUTOFTONER = 4;

        /// PRINTER_ERROR_OUTOFPAPER -> 0x00000001
        public const int PRINTER_ERROR_OUTOFPAPER = 1;

        /// PRINTER_ERROR_JAM -> 0x00000002
        public const int PRINTER_ERROR_JAM = 2;

        /// PRINTER_ERROR_INFORMATION -> 0x80000000
        public const int PRINTER_ERROR_INFORMATION = -2147483648;

        /// PRINTER_ENUM_SHARED -> 0x00000020
        public const int PRINTER_ENUM_SHARED = 32;

        /// PRINTER_ENUM_REMOTE -> 0x00000010
        public const int PRINTER_ENUM_REMOTE = 16;

        /// PRINTER_ENUM_NETWORK -> 0x00000040
        public const int PRINTER_ENUM_NETWORK = 64;

        /// PRINTER_ENUM_NAME -> 0x00000008
        public const int PRINTER_ENUM_NAME = 8;

        /// PRINTER_ENUM_LOCAL -> 0x00000002
        public const int PRINTER_ENUM_LOCAL = 2;

        /// PRINTER_ENUM_ICONMASK -> 0x00ff0000
        public const int PRINTER_ENUM_ICONMASK = 16711680;

        /// PRINTER_ENUM_ICON8 -> 0x00800000
        public const int PRINTER_ENUM_ICON8 = 8388608;

        /// PRINTER_ENUM_ICON7 -> 0x00400000
        public const int PRINTER_ENUM_ICON7 = 4194304;

        /// PRINTER_ENUM_ICON6 -> 0x00200000
        public const int PRINTER_ENUM_ICON6 = 2097152;

        /// PRINTER_ENUM_ICON5 -> 0x00100000
        public const int PRINTER_ENUM_ICON5 = 1048576;

        /// PRINTER_ENUM_ICON4 -> 0x00080000
        public const int PRINTER_ENUM_ICON4 = 524288;

        /// PRINTER_ENUM_ICON3 -> 0x00040000
        public const int PRINTER_ENUM_ICON3 = 262144;

        /// PRINTER_ENUM_ICON2 -> 0x00020000
        public const int PRINTER_ENUM_ICON2 = 131072;

        /// PRINTER_ENUM_ICON1 -> 0x00010000
        public const int PRINTER_ENUM_ICON1 = 65536;

        /// PRINTER_ENUM_HIDE -> 0x01000000
        public const int PRINTER_ENUM_HIDE = 16777216;

        /// PRINTER_ENUM_FAVORITE -> 0x00000004
        public const int PRINTER_ENUM_FAVORITE = 4;

        /// PRINTER_ENUM_EXPAND -> 0x00004000
        public const int PRINTER_ENUM_EXPAND = 16384;

        /// PRINTER_ENUM_DEFAULT -> 0x00000001
        public const int PRINTER_ENUM_DEFAULT = 1;

        /// PRINTER_ENUM_CONTAINER -> 0x00008000
        public const int PRINTER_ENUM_CONTAINER = 32768;

        /// PRINTER_ENUM_CONNECTIONS -> 0x00000004
        public const int PRINTER_ENUM_CONNECTIONS = 4;

        /// PRINTER_CONTROL_SET_STATUS -> 4
        public const int PRINTER_CONTROL_SET_STATUS = 4;

        /// PRINTER_CONTROL_RESUME -> 2
        public const int PRINTER_CONTROL_RESUME = 2;

        /// PRINTER_CONTROL_PURGE -> 3
        public const int PRINTER_CONTROL_PURGE = 3;

        /// PRINTER_CONTROL_PAUSE -> 1
        public const int PRINTER_CONTROL_PAUSE = 1;

        /// PRINTER_CHANGE_WRITE_JOB -> 0x00000800
        public const int PRINTER_CHANGE_WRITE_JOB = 2048;

        /// PRINTER_CHANGE_TIMEOUT -> 0x80000000
        public const int PRINTER_CHANGE_TIMEOUT = -2147483648;

        /// PRINTER_CHANGE_SET_PRINTER_DRIVER -> 0x20000000
        public const int PRINTER_CHANGE_SET_PRINTER_DRIVER = 536870912;

        /// PRINTER_CHANGE_SET_PRINTER -> 0x00000002
        public const int PRINTER_CHANGE_SET_PRINTER = 2;

        /// PRINTER_CHANGE_SET_JOB -> 0x00000200
        public const int PRINTER_CHANGE_SET_JOB = 512;

        /// PRINTER_CHANGE_SET_FORM -> 0x00020000
        public const int PRINTER_CHANGE_SET_FORM = 131072;

        /// PRINTER_CHANGE_PRINT_PROCESSOR -> 0x07000000
        public const int PRINTER_CHANGE_PRINT_PROCESSOR = 117440512;

        /// PRINTER_CHANGE_PRINTER_DRIVER -> 0x70000000
        public const int PRINTER_CHANGE_PRINTER_DRIVER = 1879048192;

        /// PRINTER_CHANGE_PRINTER -> 0x000000FF
        public const int PRINTER_CHANGE_PRINTER = 255;

        /// PRINTER_CHANGE_PORT -> 0x00700000
        public const int PRINTER_CHANGE_PORT = 7340032;

        /// PRINTER_CHANGE_JOB -> 0x0000FF00
        public const int PRINTER_CHANGE_JOB = 65280;

        /// PRINTER_CHANGE_FORM -> 0x00070000
        public const int PRINTER_CHANGE_FORM = 458752;

        /// PRINTER_CHANGE_FAILED_CONNECTION_PRINTER -> 0x00000008
        public const int PRINTER_CHANGE_FAILED_CONNECTION_PRINTER = 8;

        /// PRINTER_CHANGE_DELETE_PRINT_PROCESSOR -> 0x04000000
        public const int PRINTER_CHANGE_DELETE_PRINT_PROCESSOR = 67108864;

        /// PRINTER_CHANGE_DELETE_PRINTER_DRIVER -> 0x40000000
        public const int PRINTER_CHANGE_DELETE_PRINTER_DRIVER = 1073741824;

        /// PRINTER_CHANGE_DELETE_PRINTER -> 0x00000004
        public const int PRINTER_CHANGE_DELETE_PRINTER = 4;

        /// PRINTER_CHANGE_DELETE_PORT -> 0x00400000
        public const int PRINTER_CHANGE_DELETE_PORT = 4194304;

        /// PRINTER_CHANGE_DELETE_JOB -> 0x00000400
        public const int PRINTER_CHANGE_DELETE_JOB = 1024;

        /// PRINTER_CHANGE_DELETE_FORM -> 0x00040000
        public const int PRINTER_CHANGE_DELETE_FORM = 262144;

        /// PRINTER_CHANGE_CONFIGURE_PORT -> 0x00200000
        public const int PRINTER_CHANGE_CONFIGURE_PORT = 2097152;

        /// PRINTER_CHANGE_ALL -> 0x7777FFFF
        public const int PRINTER_CHANGE_ALL = 2004353023;

        /// PRINTER_CHANGE_ADD_PRINT_PROCESSOR -> 0x01000000
        public const int PRINTER_CHANGE_ADD_PRINT_PROCESSOR = 16777216;

        /// PRINTER_CHANGE_ADD_PRINTER_DRIVER -> 0x10000000
        public const int PRINTER_CHANGE_ADD_PRINTER_DRIVER = 268435456;

        /// PRINTER_CHANGE_ADD_PRINTER -> 0x00000001
        public const int PRINTER_CHANGE_ADD_PRINTER = 1;

        /// PRINTER_CHANGE_ADD_PORT -> 0x00100000
        public const int PRINTER_CHANGE_ADD_PORT = 1048576;

        /// PRINTER_CHANGE_ADD_JOB -> 0x00000100
        public const int PRINTER_CHANGE_ADD_JOB = 256;

        /// PRINTER_CHANGE_ADD_FORM -> 0x00010000
        public const int PRINTER_CHANGE_ADD_FORM = 65536;

        /// PRINTER_ATTRIBUTE_WORK_OFFLINE -> 0x00000400
        public const int PRINTER_ATTRIBUTE_WORK_OFFLINE = 1024;

        /// PRINTER_ATTRIBUTE_TS -> 0x00008000
        public const int PRINTER_ATTRIBUTE_TS = 32768;

        /// PRINTER_ATTRIBUTE_SHARED -> 0x00000008
        public const int PRINTER_ATTRIBUTE_SHARED = 8;

        /// PRINTER_ATTRIBUTE_RAW_ONLY -> 0x00001000
        public const int PRINTER_ATTRIBUTE_RAW_ONLY = 4096;

        /// PRINTER_ATTRIBUTE_QUEUED -> 0x00000001
        public const int PRINTER_ATTRIBUTE_QUEUED = 1;

        /// PRINTER_ATTRIBUTE_PUBLISHED -> 0x00002000
        public const int PRINTER_ATTRIBUTE_PUBLISHED = 8192;

        /// PRINTER_ATTRIBUTE_NETWORK -> 0x00000010
        public const int PRINTER_ATTRIBUTE_NETWORK = 16;

        /// PRINTER_ATTRIBUTE_LOCAL -> 0x00000040
        public const int PRINTER_ATTRIBUTE_LOCAL = 64;

        /// PRINTER_ATTRIBUTE_KEEPPRINTEDJOBS -> 0x00000100
        public const int PRINTER_ATTRIBUTE_KEEPPRINTEDJOBS = 256;

        /// PRINTER_ATTRIBUTE_HIDDEN -> 0x00000020
        public const int PRINTER_ATTRIBUTE_HIDDEN = 32;

        /// PRINTER_ATTRIBUTE_FAX -> 0x00004000
        public const int PRINTER_ATTRIBUTE_FAX = 16384;

        /// PRINTER_ATTRIBUTE_ENABLE_DEVQ -> 0x00000080
        public const int PRINTER_ATTRIBUTE_ENABLE_DEVQ = 128;

        /// PRINTER_ATTRIBUTE_ENABLE_BIDI -> 0x00000800
        public const int PRINTER_ATTRIBUTE_ENABLE_BIDI = 2048;

        /// PRINTER_ATTRIBUTE_DO_COMPLETE_FIRST -> 0x00000200
        public const int PRINTER_ATTRIBUTE_DO_COMPLETE_FIRST = 512;

        /// PRINTER_ATTRIBUTE_DIRECT -> 0x00000002
        public const int PRINTER_ATTRIBUTE_DIRECT = 2;

        /// PRINTER_ATTRIBUTE_DEFAULT -> 0x00000004
        public const int PRINTER_ATTRIBUTE_DEFAULT = 4;

        /// PRINTER_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED     |                               PRINTER_ACCESS_ADMINISTER    |                               PRINTER_ACCESS_USE)
        public const int PRINTER_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.PRINTER_ACCESS_ADMINISTER | NativeConstants.PRINTER_ACCESS_USE));

        /// PRINTER_ACCESS_USE -> 0x00000008
        public const int PRINTER_ACCESS_USE = 8;

        /// PRINTER_ACCESS_ADMINISTER -> 0x00000004
        public const int PRINTER_ACCESS_ADMINISTER = 4;

        /// PrinterMessageBox -> PrinterMessageBoxW
        /// Error generating expression: Value PrinterMessageBoxW is not resolved
        public const string PrinterMessageBox = "PrinterMessageBoxW";

        /// PRINTDLGORD -> 1538
        public const int PRINTDLGORD = 1538;

        /// PRINTDLGEXORD -> 1549
        public const int PRINTDLGEXORD = 1549;

        /// PrintDlgEx -> PrintDlgExW
        /// Error generating expression: Value PrintDlgExW is not resolved
        public const string PrintDlgEx = "PrintDlgExW";

        /// PrintDlg -> PrintDlgW
        /// Error generating expression: Value PrintDlgW is not resolved
        public const string PrintDlg = "PrintDlgW";

        /// PRINTACTION_TESTPAGE -> 4
        public const int PRINTACTION_TESTPAGE = 4;

        /// PRINTACTION_PROPERTIES -> 1
        public const int PRINTACTION_PROPERTIES = 1;

        /// PRINTACTION_OPENNETPRN -> 5
        public const int PRINTACTION_OPENNETPRN = 5;

        /// PRINTACTION_OPEN -> 0
        public const int PRINTACTION_OPEN = 0;

        /// PRINTACTION_NETINSTALLLINK -> 3
        public const int PRINTACTION_NETINSTALLLINK = 3;

        /// PRINTACTION_NETINSTALL -> 2
        public const int PRINTACTION_NETINSTALL = 2;

        /// PRF_OWNED -> 0x00000020L
        public const int PRF_OWNED = 32;

        /// PRF_NONCLIENT -> 0x00000002L
        public const int PRF_NONCLIENT = 2;

        /// PRF_ERASEBKGND -> 0x00000008L
        public const int PRF_ERASEBKGND = 8;

        /// PRF_CLIENT -> 0x00000004L
        public const int PRF_CLIENT = 4;

        /// PRF_CHILDREN -> 0x00000010L
        public const int PRF_CHILDREN = 16;

        /// PRF_CHECKVISIBLE -> 0x00000001L
        public const int PRF_CHECKVISIBLE = 1;

        /// PRAGMA_DEPRECATED_DDK -> 0
        public const int PRAGMA_DEPRECATED_DDK = 0;

        /// PP_VERSION -> 5
        public const int PP_VERSION = 5;

        /// PP_USE_HARDWARE_RNG -> 38
        public const int PP_USE_HARDWARE_RNG = 38;

        /// PP_UNIQUE_CONTAINER -> 36
        public const int PP_UNIQUE_CONTAINER = 36;

        /// PP_UI_PROMPT -> 21
        public const int PP_UI_PROMPT = 21;

        /// PP_SYM_KEYSIZE -> 19
        public const int PP_SYM_KEYSIZE = 19;

        /// PP_SIG_KEYSIZE_INC -> 34
        public const int PP_SIG_KEYSIZE_INC = 34;

        /// PP_SIGNATURE_PIN -> 33
        public const int PP_SIGNATURE_PIN = 33;

        /// PP_SIGNATURE_KEYSIZE -> 13
        public const int PP_SIGNATURE_KEYSIZE = 13;

        /// PP_SIGNATURE_ALG -> 15
        public const int PP_SIGNATURE_ALG = 15;

        /// PP_SGC_INFO -> 37
        public const int PP_SGC_INFO = 37;

        /// PP_SESSION_KEYSIZE -> 20
        public const int PP_SESSION_KEYSIZE = 20;

        /// PP_PROVTYPE -> 16
        public const int PP_PROVTYPE = 16;

        /// PP_NAME -> 4
        public const int PP_NAME = 4;

        /// PP_KEY_TYPE_SUBTYPE -> 10
        public const int PP_KEY_TYPE_SUBTYPE = 10;

        /// PP_KEYX_KEYSIZE_INC -> 35
        public const int PP_KEYX_KEYSIZE_INC = 35;

        /// PP_KEYSTORAGE -> 17
        public const int PP_KEYSTORAGE = 17;

        /// PP_KEYSPEC -> 39
        public const int PP_KEYSPEC = 39;

        /// PP_KEYSET_TYPE -> 27
        public const int PP_KEYSET_TYPE = 27;

        /// PP_KEYSET_SEC_DESCR -> 8
        public const int PP_KEYSET_SEC_DESCR = 8;

        /// PP_KEYEXCHANGE_PIN -> 32
        public const int PP_KEYEXCHANGE_PIN = 32;

        /// PP_KEYEXCHANGE_KEYSIZE -> 12
        public const int PP_KEYEXCHANGE_KEYSIZE = 12;

        /// PP_KEYEXCHANGE_ALG -> 14
        public const int PP_KEYEXCHANGE_ALG = 14;

        /// PP_IMPTYPE -> 3
        public const int PP_IMPTYPE = 3;

        /// PP_ENUMMANDROOTS -> 25
        public const int PP_ENUMMANDROOTS = 25;

        /// PP_ENUMEX_SIGNING_PROT -> 40
        public const int PP_ENUMEX_SIGNING_PROT = 40;

        /// PP_ENUMELECTROOTS -> 26
        public const int PP_ENUMELECTROOTS = 26;

        /// PP_ENUMCONTAINERS -> 2
        public const int PP_ENUMCONTAINERS = 2;

        /// PP_ENUMALGS_EX -> 22
        public const int PP_ENUMALGS_EX = 22;

        /// PP_ENUMALGS -> 1
        public const int PP_ENUMALGS = 1;

        /// PP_DISPLAYERRORS -> 0x01
        public const int PP_DISPLAYERRORS = 1;

        /// PP_DELETEKEY -> 24
        public const int PP_DELETEKEY = 24;

        /// PP_CRYPT_COUNT_KEY_USE -> 41
        public const int PP_CRYPT_COUNT_KEY_USE = 41;

        /// PP_CONTEXT_INFO -> 11
        public const int PP_CONTEXT_INFO = 11;

        /// PP_CONTAINER -> 6
        public const int PP_CONTAINER = 6;

        /// PP_CLIENT_HWND -> 1
        public const int PP_CLIENT_HWND = 1;

        /// PP_CHANGE_PASSWORD -> 7
        public const int PP_CHANGE_PASSWORD = 7;

        /// PP_CERTCHAIN -> 9
        public const int PP_CERTCHAIN = 9;

        /// PP_APPLI_CERT -> 18
        public const int PP_APPLI_CERT = 18;

        /// PP_ADMIN_PIN -> 31
        public const int PP_ADMIN_PIN = 31;

        /// PO_THROTTLE_NONE -> 0
        public const int PO_THROTTLE_NONE = 0;

        /// PO_THROTTLE_MAXIMUM -> 4
        public const int PO_THROTTLE_MAXIMUM = 4;

        /// PO_THROTTLE_DEGRADE -> 2
        public const int PO_THROTTLE_DEGRADE = 2;

        /// PO_THROTTLE_CONSTANT -> 1
        public const int PO_THROTTLE_CONSTANT = 1;

        /// PO_THROTTLE_ADAPTIVE -> 3
        public const int PO_THROTTLE_ADAPTIVE = 3;

        /// PO_REN_PORT -> 0x0034
        public const int PO_REN_PORT = 52;

        /// PO_RENAME -> 0x0014
        public const int PO_RENAME = 20;

        /// PO_PORTCHANGE -> 0x0020
        public const int PO_PORTCHANGE = 32;

        /// PO_DELETE -> 0x0013
        public const int PO_DELETE = 19;

        /// POWER_USER_NOTIFY_SHUTDOWN -> 0x00000010
        public const int POWER_USER_NOTIFY_SHUTDOWN = 16;

        /// POWER_USER_NOTIFY_BUTTON -> 0x00000008
        public const int POWER_USER_NOTIFY_BUTTON = 8;

        /// POWER_SYSTEM_MAXIMUM -> 7
        public const int POWER_SYSTEM_MAXIMUM = 7;

        /// POWER_LEVEL_USER_NOTIFY_TEXT -> 0x00000001
        public const int POWER_LEVEL_USER_NOTIFY_TEXT = 1;

        /// POWER_LEVEL_USER_NOTIFY_SOUND -> 0x00000002
        public const int POWER_LEVEL_USER_NOTIFY_SOUND = 2;

        /// POWER_LEVEL_USER_NOTIFY_EXEC -> 0x00000004
        public const int POWER_LEVEL_USER_NOTIFY_EXEC = 4;

        /// POWER_FORCE_TRIGGER_RESET -> 0x80000000
        public const int POWER_FORCE_TRIGGER_RESET = -2147483648;

        /// POWER_ACTION_UI_ALLOWED -> 0x00000002
        public const int POWER_ACTION_UI_ALLOWED = 2;

        /// POWER_ACTION_QUERY_ALLOWED -> 0x00000001
        public const int POWER_ACTION_QUERY_ALLOWED = 1;

        /// POWER_ACTION_OVERRIDE_APPS -> 0x00000004
        public const int POWER_ACTION_OVERRIDE_APPS = 4;

        /// POWER_ACTION_LOCK_CONSOLE -> 0x20000000
        public const int POWER_ACTION_LOCK_CONSOLE = 536870912;

        /// POWER_ACTION_LIGHTEST_FIRST -> 0x10000000
        public const int POWER_ACTION_LIGHTEST_FIRST = 268435456;

        /// POWER_ACTION_DISABLE_WAKES -> 0x40000000
        public const int POWER_ACTION_DISABLE_WAKES = 1073741824;

        /// POWER_ACTION_CRITICAL -> 0x80000000
        public const int POWER_ACTION_CRITICAL = -2147483648;

        /// PostThreadMessage -> PostThreadMessageW
        /// Error generating expression: Value PostThreadMessageW is not resolved
        public const string PostThreadMessage = "PostThreadMessageW";

        /// POSTSCRIPT_PASSTHROUGH -> 4115
        public const int POSTSCRIPT_PASSTHROUGH = 4115;

        /// POSTSCRIPT_INJECTION -> 4118
        public const int POSTSCRIPT_INJECTION = 4118;

        /// POSTSCRIPT_IGNORE -> 38
        public const int POSTSCRIPT_IGNORE = 38;

        /// POSTSCRIPT_IDENTIFY -> 4117
        public const int POSTSCRIPT_IDENTIFY = 4117;

        /// POSTSCRIPT_DATA -> 37
        public const int POSTSCRIPT_DATA = 37;

        /// PostMessage -> PostMessageW
        /// Error generating expression: Value PostMessageW is not resolved
        public const string PostMessage = "PostMessageW";

        /// PostAppMessage -> PostAppMessageW
        public const string PostAppMessage = NativeConstants.PostAppMessageW;

        /// PORT_TYPE_WRITE -> 0x0001
        public const int PORT_TYPE_WRITE = 1;

        /// PORT_TYPE_REDIRECTED -> 0x0004
        public const int PORT_TYPE_REDIRECTED = 4;

        /// PORT_TYPE_READ -> 0x0002
        public const int PORT_TYPE_READ = 2;

        /// PORT_TYPE_NET_ATTACHED -> 0x0008
        public const int PORT_TYPE_NET_ATTACHED = 8;

        /// PORT_STATUS_WARMING_UP -> 11
        public const int PORT_STATUS_WARMING_UP = 11;

        /// PORT_STATUS_USER_INTERVENTION -> 8
        public const int PORT_STATUS_USER_INTERVENTION = 8;

        /// PORT_STATUS_TYPE_WARNING -> 2
        public const int PORT_STATUS_TYPE_WARNING = 2;

        /// PORT_STATUS_TYPE_INFO -> 3
        public const int PORT_STATUS_TYPE_INFO = 3;

        /// PORT_STATUS_TYPE_ERROR -> 1
        public const int PORT_STATUS_TYPE_ERROR = 1;

        /// PORT_STATUS_TONER_LOW -> 10
        public const int PORT_STATUS_TONER_LOW = 10;

        /// PORT_STATUS_POWER_SAVE -> 12
        public const int PORT_STATUS_POWER_SAVE = 12;

        /// PORT_STATUS_PAPER_PROBLEM -> 5
        public const int PORT_STATUS_PAPER_PROBLEM = 5;

        /// PORT_STATUS_PAPER_OUT -> 3
        public const int PORT_STATUS_PAPER_OUT = 3;

        /// PORT_STATUS_PAPER_JAM -> 2
        public const int PORT_STATUS_PAPER_JAM = 2;

        /// PORT_STATUS_OUT_OF_MEMORY -> 9
        public const int PORT_STATUS_OUT_OF_MEMORY = 9;

        /// PORT_STATUS_OUTPUT_BIN_FULL -> 4
        public const int PORT_STATUS_OUTPUT_BIN_FULL = 4;

        /// PORT_STATUS_OFFLINE -> 1
        public const int PORT_STATUS_OFFLINE = 1;

        /// PORT_STATUS_NO_TONER -> 6
        public const int PORT_STATUS_NO_TONER = 6;

        /// PORT_STATUS_DOOR_OPEN -> 7
        public const int PORT_STATUS_DOOR_OPEN = 7;

        /// POPENCARDNAME_W -> POPENCARDNAMEW
        /// Error generating expression: Value POPENCARDNAMEW is not resolved
        public const string POPENCARDNAME_W = "POPENCARDNAMEW";

        /// POPENCARDNAME_A -> POPENCARDNAMEA
        /// Error generating expression: Value POPENCARDNAMEA is not resolved
        public const string POPENCARDNAME_A = "POPENCARDNAMEA";

        /// POPENCARDNAMEW_EX -> POPENCARDNAME_EXW
        /// Error generating expression: Value POPENCARDNAME_EXW is not resolved
        public const string POPENCARDNAMEW_EX = "POPENCARDNAME_EXW";

        /// POPENCARDNAMEA_EX -> POPENCARDNAME_EXA
        /// Error generating expression: Value POPENCARDNAME_EXA is not resolved
        public const string POPENCARDNAMEA_EX = "POPENCARDNAME_EXA";

        /// PolyTextOut -> PolyTextOutW
        /// Error generating expression: Value PolyTextOutW is not resolved
        public const string PolyTextOut = "PolyTextOutW";

        /// POLYGONALCAPS -> 32
        public const int POLYGONALCAPS = 32;

        /// POLYFILL_LAST -> 2
        public const int POLYFILL_LAST = 2;

        /// POLICY_SHOWREASONUI_WORKSTATIONONLY -> 2
        public const int POLICY_SHOWREASONUI_WORKSTATIONONLY = 2;

        /// POLICY_SHOWREASONUI_SERVERONLY -> 3
        public const int POLICY_SHOWREASONUI_SERVERONLY = 3;

        /// POLICY_SHOWREASONUI_NEVER -> 0
        public const int POLICY_SHOWREASONUI_NEVER = 0;

        /// POLICY_SHOWREASONUI_ALWAYS -> 1
        public const int POLICY_SHOWREASONUI_ALWAYS = 1;

        /// POINTER_64 -> __ptr64
        /// Error generating expression: Value __ptr64 is not resolved
        public const string POINTER_64 = "__ptr64";

        /// PM_REMOVE -> 0x0001
        public const int PM_REMOVE = 1;

        /// PM_QS_SENDMESSAGE -> (QS_SENDMESSAGE << 16)
        public const int PM_QS_SENDMESSAGE = (NativeConstants.QS_SENDMESSAGE) << (16);

        /// PM_QS_POSTMESSAGE -> ((QS_POSTMESSAGE | QS_HOTKEY | QS_TIMER) << 16)
        public const int PM_QS_POSTMESSAGE = ((NativeConstants.QS_POSTMESSAGE
                | (NativeConstants.QS_HOTKEY | NativeConstants.QS_TIMER))) << (16);

        /// PM_QS_PAINT -> (QS_PAINT << 16)
        public const int PM_QS_PAINT = (NativeConstants.QS_PAINT) << (16);

        /// PM_QS_INPUT -> (QS_INPUT << 16)
        public const int PM_QS_INPUT = (NativeConstants.QS_INPUT) << (16);

        /// PM_NOYIELD -> 0x0002
        public const int PM_NOYIELD = 2;

        /// PM_NOREMOVE -> 0x0000
        public const int PM_NOREMOVE = 0;

        /// PMB_ACTIVE -> 0x00000001
        public const int PMB_ACTIVE = 1;

        /// PlaySound -> PlaySoundW
        /// Error generating expression: Value PlaySoundW is not resolved
        public const string PlaySound = "PlaySoundW";

        /// PLANES -> 14
        public const int PLANES = 14;

        /// PLAINTEXTKEYBLOB -> 0x8
        public const int PLAINTEXTKEYBLOB = 8;

        /// PKCS_7_NDR_ENCODING -> 0x00020000
        public const int PKCS_7_NDR_ENCODING = 131072;

        /// PKCS_7_ASN_ENCODING -> 0x00010000
        public const int PKCS_7_ASN_ENCODING = 65536;

        /// PKCS5_PADDING -> 1
        public const int PKCS5_PADDING = 1;

        /// PKCS12_IMPORT_RESERVED_MASK -> 0xffff0000
        public const int PKCS12_IMPORT_RESERVED_MASK = -65536;

        /// PKCS12_EXPORT_RESERVED_MASK -> 0xffff0000
        public const int PKCS12_EXPORT_RESERVED_MASK = -65536;

        /// PI_DOCFILECLSIDLOOKUP -> PI_CLSIDLOOKUP
        public const PI_FLAGS PI_DOCFILECLSIDLOOKUP = PI_FLAGS.PI_CLSIDLOOKUP;

        /// PIPE_WAIT -> 0x00000000
        public const int PIPE_WAIT = 0;

        /// PIPE_UNLIMITED_INSTANCES -> 255
        public const int PIPE_UNLIMITED_INSTANCES = 255;

        /// PIPE_TYPE_MESSAGE -> 0x00000004
        public const int PIPE_TYPE_MESSAGE = 4;

        /// PIPE_TYPE_BYTE -> 0x00000000
        public const int PIPE_TYPE_BYTE = 0;

        /// PIPE_SERVER_END -> 0x00000001
        public const int PIPE_SERVER_END = 1;

        /// PIPE_READMODE_MESSAGE -> 0x00000002
        public const int PIPE_READMODE_MESSAGE = 2;

        /// PIPE_READMODE_BYTE -> 0x00000000
        public const int PIPE_READMODE_BYTE = 0;

        /// PIPE_NOWAIT -> 0x00000001
        public const int PIPE_NOWAIT = 1;

        /// PIPE_CLIENT_END -> 0x00000000
        public const int PIPE_CLIENT_END = 0;

        /// PIPE_ACCESS_OUTBOUND -> 0x00000002
        public const int PIPE_ACCESS_OUTBOUND = 2;

        /// PIPE_ACCESS_INBOUND -> 0x00000001
        public const int PIPE_ACCESS_INBOUND = 1;

        /// PIPE_ACCESS_DUPLEX -> 0x00000003
        public const int PIPE_ACCESS_DUPLEX = 3;

        /// PID_SECURITY -> ( 0x80000002 )
        public const int PID_SECURITY = -2147483646;

        /// PID_MODIFY_TIME -> ( 0x80000001 )
        public const int PID_MODIFY_TIME = -2147483647;

        /// PID_MIN_READONLY -> ( 0x80000000 )
        public const int PID_MIN_READONLY = -2147483648;

        /// PID_MAX_READONLY -> ( 0xbfffffff )
        public const int PID_MAX_READONLY = -1073741825;

        /// PID_LOCALE -> ( 0x80000000 )
        public const int PID_LOCALE = -2147483648;

        /// PID_ILLEGAL -> ( 0xffffffff )
        public const int PID_ILLEGAL = -1;

        /// PID_FIRST_USABLE -> ( 0x2 )
        public const int PID_FIRST_USABLE = 2;

        /// PID_FIRST_NAME_DEFAULT -> ( 0xfff )
        public const int PID_FIRST_NAME_DEFAULT = 4095;

        /// PID_DICTIONARY -> ( 0 )
        public const int PID_DICTIONARY = 0;

        /// PID_CODEPAGE -> ( 0x1 )
        public const int PID_CODEPAGE = 1;

        /// PID_BEHAVIOR -> ( 0x80000003 )
        public const int PID_BEHAVIOR = -2147483645;

        /// PIDSI_WORDCOUNT -> 0x0000000fL
        public const int PIDSI_WORDCOUNT = 15;

        /// PIDSI_TITLE -> 0x00000002L
        public const int PIDSI_TITLE = 2;

        /// PIDSI_THUMBNAIL -> 0x00000011L
        public const int PIDSI_THUMBNAIL = 17;

        /// PIDSI_TEMPLATE -> 0x00000007L
        public const int PIDSI_TEMPLATE = 7;

        /// PIDSI_SUBJECT -> 0x00000003L
        public const int PIDSI_SUBJECT = 3;

        /// PIDSI_REVNUMBER -> 0x00000009L
        public const int PIDSI_REVNUMBER = 9;

        /// PIDSI_PAGECOUNT -> 0x0000000eL
        public const int PIDSI_PAGECOUNT = 14;

        /// PIDSI_LASTSAVE_DTM -> 0x0000000dL
        public const int PIDSI_LASTSAVE_DTM = 13;

        /// PIDSI_LASTPRINTED -> 0x0000000bL
        public const int PIDSI_LASTPRINTED = 11;

        /// PIDSI_LASTAUTHOR -> 0x00000008L
        public const int PIDSI_LASTAUTHOR = 8;

        /// PIDSI_KEYWORDS -> 0x00000005L
        public const int PIDSI_KEYWORDS = 5;

        /// PIDSI_EDITTIME -> 0x0000000aL
        public const int PIDSI_EDITTIME = 10;

        /// PIDSI_DOC_SECURITY -> 0x00000013L
        public const int PIDSI_DOC_SECURITY = 19;

        /// PIDSI_CREATE_DTM -> 0x0000000cL
        public const int PIDSI_CREATE_DTM = 12;

        /// PIDSI_COMMENTS -> 0x00000006L
        public const int PIDSI_COMMENTS = 6;

        /// PIDSI_CHARCOUNT -> 0x00000010L
        public const int PIDSI_CHARCOUNT = 16;

        /// PIDSI_AUTHOR -> 0x00000004L
        public const int PIDSI_AUTHOR = 4;

        /// PIDSI_APPNAME -> 0x00000012L
        public const int PIDSI_APPNAME = 18;

        /// PIDMSI_SUPPLIER -> 0x00000003L
        public const int PIDMSI_SUPPLIER = 3;

        /// PIDMSI_STATUS -> 0x00000007L
        public const int PIDMSI_STATUS = 7;

        /// PIDMSI_SOURCE -> 0x00000004L
        public const int PIDMSI_SOURCE = 4;

        /// PIDMSI_SEQUENCE_NO -> 0x00000005L
        public const int PIDMSI_SEQUENCE_NO = 5;

        /// PIDMSI_RATING -> 0x00000009L
        public const int PIDMSI_RATING = 9;

        /// PIDMSI_PROJECT -> 0x00000006L
        public const int PIDMSI_PROJECT = 6;

        /// PIDMSI_PRODUCTION -> 0x0000000AL
        public const int PIDMSI_PRODUCTION = 10;

        /// PIDMSI_OWNER -> 0x00000008L
        public const int PIDMSI_OWNER = 8;

        /// PIDMSI_EDITOR -> 0x00000002L
        public const int PIDMSI_EDITOR = 2;

        /// PIDMSI_COPYRIGHT -> 0x0000000BL
        public const int PIDMSI_COPYRIGHT = 11;

        /// PIDDSI_SLIDECOUNT -> 0x00000007
        public const int PIDDSI_SLIDECOUNT = 7;

        /// PIDDSI_SCALE -> 0x0000000B
        public const int PIDDSI_SCALE = 11;

        /// PIDDSI_PRESFORMAT -> 0x00000003
        public const int PIDDSI_PRESFORMAT = 3;

        /// PIDDSI_PARCOUNT -> 0x00000006
        public const int PIDDSI_PARCOUNT = 6;

        /// PIDDSI_NOTECOUNT -> 0x00000008
        public const int PIDDSI_NOTECOUNT = 8;

        /// PIDDSI_MMCLIPCOUNT -> 0x0000000A
        public const int PIDDSI_MMCLIPCOUNT = 10;

        /// PIDDSI_MANAGER -> 0x0000000E
        public const int PIDDSI_MANAGER = 14;

        /// PIDDSI_LINKSDIRTY -> 0x00000010
        public const int PIDDSI_LINKSDIRTY = 16;

        /// PIDDSI_LINECOUNT -> 0x00000005
        public const int PIDDSI_LINECOUNT = 5;

        /// PIDDSI_HIDDENCOUNT -> 0x00000009
        public const int PIDDSI_HIDDENCOUNT = 9;

        /// PIDDSI_HEADINGPAIR -> 0x0000000C
        public const int PIDDSI_HEADINGPAIR = 12;

        /// PIDDSI_DOCPARTS -> 0x0000000D
        public const int PIDDSI_DOCPARTS = 13;

        /// PIDDSI_COMPANY -> 0x0000000F
        public const int PIDDSI_COMPANY = 15;

        /// PIDDSI_CATEGORY -> 0x00000002
        public const int PIDDSI_CATEGORY = 2;

        /// PIDDSI_BYTECOUNT -> 0x00000004
        public const int PIDDSI_BYTECOUNT = 4;

        /// PIDDI_THUMBNAIL -> 0x00000002L
        public const int PIDDI_THUMBNAIL = 2;

        /// PHYSICALWIDTH -> 110
        public const int PHYSICALWIDTH = 110;

        /// PHYSICALOFFSETY -> 113
        public const int PHYSICALOFFSETY = 113;

        /// PHYSICALOFFSETX -> 112
        public const int PHYSICALOFFSETX = 112;

        /// PHYSICALHEIGHT -> 111
        public const int PHYSICALHEIGHT = 111;

        /// PGET_MODULE_HANDLE_EX -> PGET_MODULE_HANDLE_EXW
        /// Error generating expression: Value PGET_MODULE_HANDLE_EXW is not resolved
        public const string PGET_MODULE_HANDLE_EX = "PGET_MODULE_HANDLE_EXW";

        /// PF_XMMI_INSTRUCTIONS_AVAILABLE -> 6
        public const int PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;

        /// PF_XMMI64_INSTRUCTIONS_AVAILABLE -> 10
        public const int PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;

        /// PF_VOICEVIEW -> AF_VOICEVIEW
        public const int PF_VOICEVIEW = NativeConstants.AF_VOICEVIEW;

        /// PF_UNSPEC -> AF_UNSPEC
        public const int PF_UNSPEC = NativeConstants.AF_UNSPEC;

        /// PF_UNKNOWN1 -> AF_UNKNOWN1
        public const int PF_UNKNOWN1 = NativeConstants.AF_UNKNOWN1;

        /// PF_UNIX -> AF_UNIX
        public const int PF_UNIX = NativeConstants.AF_UNIX;

        /// PF_SSE_DAZ_MODE_AVAILABLE -> 11
        public const int PF_SSE_DAZ_MODE_AVAILABLE = 11;

        /// PF_SNA -> AF_SNA
        public const int PF_SNA = NativeConstants.AF_SNA;

        /// PF_RDTSC_INSTRUCTION_AVAILABLE -> 8
        public const int PF_RDTSC_INSTRUCTION_AVAILABLE = 8;

        /// PF_PUP -> AF_PUP
        public const int PF_PUP = NativeConstants.AF_PUP;

        /// PF_PPC_MOVEMEM_64BIT_OK -> 4
        public const int PF_PPC_MOVEMEM_64BIT_OK = 4;

        /// PF_PAE_ENABLED -> 9
        public const int PF_PAE_ENABLED = 9;

        /// PF_OSI -> AF_OSI
        public const int PF_OSI = NativeConstants.AF_OSI;

        /// PF_NX_ENABLED -> 12
        public const int PF_NX_ENABLED = 12;

        /// PF_NS -> AF_NS
        public const int PF_NS = NativeConstants.AF_NS;

        /// PF_MMX_INSTRUCTIONS_AVAILABLE -> 3
        public const int PF_MMX_INSTRUCTIONS_AVAILABLE = 3;

        /// PF_MAX -> AF_MAX
        public const int PF_MAX = NativeConstants.AF_MAX;

        /// PF_LAT -> AF_LAT
        public const int PF_LAT = NativeConstants.AF_LAT;

        /// PF_ISO -> AF_ISO
        public const int PF_ISO = NativeConstants.AF_ISO;

        /// PF_IPX -> AF_IPX
        public const int PF_IPX = NativeConstants.AF_IPX;

        /// PF_INET -> AF_INET
        public const int PF_INET = NativeConstants.AF_INET;

        /// PF_IMPLINK -> AF_IMPLINK
        public const int PF_IMPLINK = NativeConstants.AF_IMPLINK;

        /// PF_HYLINK -> AF_HYLINK
        public const int PF_HYLINK = NativeConstants.AF_HYLINK;

        /// PF_FLOATING_POINT_PRECISION_ERRATA -> 0
        public const int PF_FLOATING_POINT_PRECISION_ERRATA = 0;

        /// PF_FLOATING_POINT_EMULATED -> 1
        public const int PF_FLOATING_POINT_EMULATED = 1;

        /// PF_FIREFOX -> AF_FIREFOX
        public const int PF_FIREFOX = NativeConstants.AF_FIREFOX;

        /// PF_ECMA -> AF_ECMA
        public const int PF_ECMA = NativeConstants.AF_ECMA;

        /// PF_DLI -> AF_DLI
        public const int PF_DLI = NativeConstants.AF_DLI;

        /// PF_DECnet -> AF_DECnet
        public const int PF_DECnet = NativeConstants.AF_DECnet;

        /// PF_DATAKIT -> AF_DATAKIT
        public const int PF_DATAKIT = NativeConstants.AF_DATAKIT;

        /// PF_COMPARE_EXCHANGE_DOUBLE -> 2
        public const int PF_COMPARE_EXCHANGE_DOUBLE = 2;

        /// PF_CHAOS -> AF_CHAOS
        public const int PF_CHAOS = NativeConstants.AF_CHAOS;

        /// PF_CCITT -> AF_CCITT
        public const int PF_CCITT = NativeConstants.AF_CCITT;

        /// PF_BAN -> AF_BAN
        public const int PF_BAN = NativeConstants.AF_BAN;

        /// PF_APPLETALK -> AF_APPLETALK
        public const int PF_APPLETALK = NativeConstants.AF_APPLETALK;

        /// PF_ALPHA_BYTE_INSTRUCTIONS -> 5
        public const int PF_ALPHA_BYTE_INSTRUCTIONS = 5;

        /// PF_3DNOW_INSTRUCTIONS_AVAILABLE -> 7
        public const int PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7;

        /// PFNRECONCILEPROFILE -> PFNRECONCILEPROFILEW
        /// Error generating expression: Value PFNRECONCILEPROFILEW is not resolved
        public const string PFNRECONCILEPROFILE = "PFNRECONCILEPROFILEW";

        /// PFNPROCESSPOLICIES -> PFNPROCESSPOLICIESW
        /// Error generating expression: Value PFNPROCESSPOLICIESW is not resolved
        public const string PFNPROCESSPOLICIES = "PFNPROCESSPOLICIESW";

        /// PFNGETPROFILEPATH -> PFNGETPROFILEPATHW
        /// Error generating expression: Value PFNGETPROFILEPATHW is not resolved
        public const string PFNGETPROFILEPATH = "PFNGETPROFILEPATHW";

        /// PFD_UNDERLAY_PLANE -> (-1)
        public const int PFD_UNDERLAY_PLANE = -1;

        /// PFD_TYPE_RGBA -> 0
        public const int PFD_TYPE_RGBA = 0;

        /// PFD_TYPE_COLORINDEX -> 1
        public const int PFD_TYPE_COLORINDEX = 1;

        /// PFD_SWAP_LAYER_BUFFERS -> 0x00000800
        public const int PFD_SWAP_LAYER_BUFFERS = 2048;

        /// PFD_SWAP_EXCHANGE -> 0x00000200
        public const int PFD_SWAP_EXCHANGE = 512;

        /// PFD_SWAP_COPY -> 0x00000400
        public const int PFD_SWAP_COPY = 1024;

        /// PFD_SUPPORT_OPENGL -> 0x00000020
        public const int PFD_SUPPORT_OPENGL = 32;

        /// PFD_SUPPORT_GDI -> 0x00000010
        public const int PFD_SUPPORT_GDI = 16;

        /// PFD_SUPPORT_DIRECTDRAW -> 0x00002000
        public const int PFD_SUPPORT_DIRECTDRAW = 8192;

        /// PFD_STEREO_DONTCARE -> 0x80000000
        public const int PFD_STEREO_DONTCARE = -2147483648;

        /// PFD_STEREO -> 0x00000002
        public const int PFD_STEREO = 2;

        /// PFD_OVERLAY_PLANE -> 1
        public const int PFD_OVERLAY_PLANE = 1;

        /// PFD_NEED_SYSTEM_PALETTE -> 0x00000100
        public const int PFD_NEED_SYSTEM_PALETTE = 256;

        /// PFD_NEED_PALETTE -> 0x00000080
        public const int PFD_NEED_PALETTE = 128;

        /// PFD_MAIN_PLANE -> 0
        public const int PFD_MAIN_PLANE = 0;

        /// PFD_GENERIC_FORMAT -> 0x00000040
        public const int PFD_GENERIC_FORMAT = 64;

        /// PFD_GENERIC_ACCELERATED -> 0x00001000
        public const int PFD_GENERIC_ACCELERATED = 4096;

        /// PFD_DRAW_TO_WINDOW -> 0x00000004
        public const int PFD_DRAW_TO_WINDOW = 4;

        /// PFD_DRAW_TO_BITMAP -> 0x00000008
        public const int PFD_DRAW_TO_BITMAP = 8;

        /// PFD_DOUBLEBUFFER_DONTCARE -> 0x40000000
        public const int PFD_DOUBLEBUFFER_DONTCARE = 1073741824;

        /// PFD_DOUBLEBUFFER -> 0x00000001
        public const int PFD_DOUBLEBUFFER = 1;

        /// PFD_DEPTH_DONTCARE -> 0x20000000
        public const int PFD_DEPTH_DONTCARE = 536870912;

        /// PERF_TYPE_ZERO -> 0x00000C00
        public const int PERF_TYPE_ZERO = 3072;

        /// PERF_TYPE_TEXT -> 0x00000800
        public const int PERF_TYPE_TEXT = 2048;

        /// PERF_TYPE_NUMBER -> 0x00000000
        public const int PERF_TYPE_NUMBER = 0;

        /// PERF_TYPE_COUNTER -> 0x00000400
        public const int PERF_TYPE_COUNTER = 1024;

        /// PERF_TIMER_TICK -> 0x00000000
        public const int PERF_TIMER_TICK = 0;

        /// PERF_TIMER_100NS -> 0x00100000
        public const int PERF_TIMER_100NS = 1048576;

        /// PERF_TEXT_UNICODE -> 0x00000000
        public const int PERF_TEXT_UNICODE = 0;

        /// PERF_TEXT_ASCII -> 0x00010000
        public const int PERF_TEXT_ASCII = 65536;

        /// PERF_SIZE_ZERO -> 0x00000200
        public const int PERF_SIZE_ZERO = 512;

        /// PERF_SIZE_VARIABLE_LEN -> 0x00000300
        public const int PERF_SIZE_VARIABLE_LEN = 768;

        /// PERF_SIZE_LARGE -> 0x00000100
        public const int PERF_SIZE_LARGE = 256;

        /// PERF_SIZE_DWORD -> 0x00000000
        public const int PERF_SIZE_DWORD = 0;

        /// PERF_SAMPLE_FRACTION -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION |            PERF_DELTA_COUNTER | PERF_DELTA_BASE | PERF_DISPLAY_PERCENT)
        public const int PERF_SAMPLE_FRACTION = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_FRACTION
                    | (NativeConstants.PERF_DELTA_COUNTER
                    | (NativeConstants.PERF_DELTA_BASE | NativeConstants.PERF_DISPLAY_PERCENT)))));

        /// PERF_SAMPLE_COUNTER -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_TIMER_TICK | PERF_DELTA_COUNTER | PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_SAMPLE_COUNTER = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_NO_SUFFIX)))));

        /// PERF_SAMPLE_BASE -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_BASE |            PERF_DISPLAY_NOSHOW |            0x00000001)
        public const int PERF_SAMPLE_BASE = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_BASE
                    | (NativeConstants.PERF_DISPLAY_NOSHOW | 1))));

        /// PERF_RAW_FRACTION -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION |            PERF_DISPLAY_PERCENT)
        public const int PERF_RAW_FRACTION = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_FRACTION | NativeConstants.PERF_DISPLAY_PERCENT)));

        /// PERF_RAW_BASE -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_BASE |            PERF_DISPLAY_NOSHOW |            0x00000003)
        public const int PERF_RAW_BASE = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_BASE
                    | (NativeConstants.PERF_DISPLAY_NOSHOW | 3))));

        /// PERF_PRECISION_TIMESTAMP -> PERF_LARGE_RAW_BASE
        public const int PERF_PRECISION_TIMESTAMP = NativeConstants.PERF_LARGE_RAW_BASE;

        /// PERF_PRECISION_SYSTEM_TIMER -> (PERF_SIZE_LARGE    | PERF_TYPE_COUNTER     | PERF_COUNTER_PRECISION    |          PERF_TIMER_TICK    | PERF_DELTA_COUNTER    | PERF_DISPLAY_PERCENT   )
        public const int PERF_PRECISION_SYSTEM_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_PRECISION
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))));

        /// PERF_PRECISION_OBJECT_TIMER -> (PERF_SIZE_LARGE    | PERF_TYPE_COUNTER     | PERF_COUNTER_PRECISION    |          PERF_OBJECT_TIMER  | PERF_DELTA_COUNTER    | PERF_DISPLAY_PERCENT   )
        public const int PERF_PRECISION_OBJECT_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_PRECISION
                    | (NativeConstants.PERF_OBJECT_TIMER
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))));

        /// PERF_PRECISION_100NS_TIMER -> (PERF_SIZE_LARGE    | PERF_TYPE_COUNTER     | PERF_COUNTER_PRECISION    |          PERF_TIMER_100NS   | PERF_DELTA_COUNTER    | PERF_DISPLAY_PERCENT   )
        public const int PERF_PRECISION_100NS_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_PRECISION
                    | (NativeConstants.PERF_TIMER_100NS
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))));

        /// PERF_OBJ_TIME_TIMER -> (PERF_SIZE_LARGE   | PERF_TYPE_COUNTER  | PERF_COUNTER_RATE |             PERF_OBJECT_TIMER | PERF_DELTA_COUNTER | PERF_DISPLAY_PERCENT)
        public const int PERF_OBJ_TIME_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_OBJECT_TIMER
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))));

        /// PERF_OBJECT_TIMER -> 0x00200000
        public const int PERF_OBJECT_TIMER = 2097152;

        /// PERF_NUMBER_HEX -> 0x00000000
        public const int PERF_NUMBER_HEX = 0;

        /// PERF_NUMBER_DEC_1000 -> 0x00020000
        public const int PERF_NUMBER_DEC_1000 = 131072;

        /// PERF_NUMBER_DECIMAL -> 0x00010000
        public const int PERF_NUMBER_DECIMAL = 65536;

        /// PERF_NO_UNIQUE_ID -> -1
        public const int PERF_NO_UNIQUE_ID = -1;

        /// PERF_NO_INSTANCES -> -1
        public const int PERF_NO_INSTANCES = -1;

        /// PERF_MULTI_COUNTER -> 0x02000000
        public const int PERF_MULTI_COUNTER = 33554432;

        /// PERF_LARGE_RAW_FRACTION -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION |            PERF_DISPLAY_PERCENT)
        public const int PERF_LARGE_RAW_FRACTION = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_FRACTION | NativeConstants.PERF_DISPLAY_PERCENT)));

        /// PERF_LARGE_RAW_BASE -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_BASE |            PERF_DISPLAY_NOSHOW )
        public const int PERF_LARGE_RAW_BASE = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_BASE | NativeConstants.PERF_DISPLAY_NOSHOW)));

        /// PERF_INVERSE_COUNTER -> 0x01000000
        public const int PERF_INVERSE_COUNTER = 16777216;

        /// PERF_ELAPSED_TIME -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_ELAPSED |            PERF_OBJECT_TIMER | PERF_DISPLAY_SECONDS)
        public const int PERF_ELAPSED_TIME = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_ELAPSED
                    | (NativeConstants.PERF_OBJECT_TIMER | NativeConstants.PERF_DISPLAY_SECONDS))));

        /// PERF_DISPLAY_SECONDS -> 0x30000000
        public const int PERF_DISPLAY_SECONDS = 805306368;

        /// PERF_DISPLAY_PER_SEC -> 0x10000000
        public const int PERF_DISPLAY_PER_SEC = 268435456;

        /// PERF_DISPLAY_PERCENT -> 0x20000000
        public const int PERF_DISPLAY_PERCENT = 536870912;

        /// PERF_DISPLAY_NO_SUFFIX -> 0x00000000
        public const int PERF_DISPLAY_NO_SUFFIX = 0;

        /// PERF_DISPLAY_NOSHOW -> 0x40000000
        public const int PERF_DISPLAY_NOSHOW = 1073741824;

        /// PERF_DETAIL_WIZARD -> 400
        public const int PERF_DETAIL_WIZARD = 400;

        /// PERF_DETAIL_NOVICE -> 100
        public const int PERF_DETAIL_NOVICE = 100;

        /// PERF_DETAIL_EXPERT -> 300
        public const int PERF_DETAIL_EXPERT = 300;

        /// PERF_DETAIL_ADVANCED -> 200
        public const int PERF_DETAIL_ADVANCED = 200;

        /// PERF_DELTA_COUNTER -> 0x00400000
        public const int PERF_DELTA_COUNTER = 4194304;

        /// PERF_DELTA_BASE -> 0x00800000
        public const int PERF_DELTA_BASE = 8388608;

        /// PERF_DATA_VERSION -> 1
        public const int PERF_DATA_VERSION = 1;

        /// PERF_DATA_REVISION -> 1
        public const int PERF_DATA_REVISION = 1;

        /// PERF_COUNTER_VALUE -> 0x00000000
        public const int PERF_COUNTER_VALUE = 0;

        /// PERF_COUNTER_TIMER_INV -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_TIMER_TICK | PERF_DELTA_COUNTER | PERF_INVERSE_COUNTER |             PERF_DISPLAY_PERCENT)
        public const int PERF_COUNTER_TIMER_INV = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER
                    | (NativeConstants.PERF_INVERSE_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT))))));

        /// PERF_COUNTER_TIMER -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_TIMER_TICK | PERF_DELTA_COUNTER | PERF_DISPLAY_PERCENT)
        public const int PERF_COUNTER_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))));

        /// PERF_COUNTER_TEXT -> (PERF_SIZE_VARIABLE_LEN | PERF_TYPE_TEXT | PERF_TEXT_UNICODE |            PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_TEXT = (NativeConstants.PERF_SIZE_VARIABLE_LEN
                    | (NativeConstants.PERF_TYPE_TEXT
                    | (NativeConstants.PERF_TEXT_UNICODE | NativeConstants.PERF_DISPLAY_NO_SUFFIX)));

        /// PERF_COUNTER_RAWCOUNT_HEX -> (PERF_SIZE_DWORD | PERF_TYPE_NUMBER | PERF_NUMBER_HEX |            PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_RAWCOUNT_HEX = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_NUMBER
                    | (NativeConstants.PERF_NUMBER_HEX | NativeConstants.PERF_DISPLAY_NO_SUFFIX)));

        /// PERF_COUNTER_RAWCOUNT -> (PERF_SIZE_DWORD | PERF_TYPE_NUMBER | PERF_NUMBER_DECIMAL |            PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_RAWCOUNT = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_NUMBER
                    | (NativeConstants.PERF_NUMBER_DECIMAL | NativeConstants.PERF_DISPLAY_NO_SUFFIX)));

        /// PERF_COUNTER_RATE -> 0x00010000
        public const int PERF_COUNTER_RATE = 65536;

        /// PERF_COUNTER_QUEUELEN_TYPE -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_QUEUELEN |            PERF_TIMER_TICK | PERF_DELTA_COUNTER | PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_QUEUELEN_TYPE = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_QUEUELEN
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_NO_SUFFIX)))));

        /// PERF_COUNTER_QUEUELEN -> 0x00050000
        public const int PERF_COUNTER_QUEUELEN = 327680;

        /// PERF_COUNTER_PRECISION -> 0x00070000
        public const int PERF_COUNTER_PRECISION = 458752;

        /// PERF_COUNTER_OBJ_TIME_QUEUELEN_TYPE -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_QUEUELEN |            PERF_OBJECT_TIMER | PERF_DELTA_COUNTER | PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_OBJ_TIME_QUEUELEN_TYPE = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_QUEUELEN
                    | (NativeConstants.PERF_OBJECT_TIMER
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_NO_SUFFIX)))));

        /// PERF_COUNTER_NODATA -> (PERF_SIZE_ZERO | PERF_DISPLAY_NOSHOW)
        public const int PERF_COUNTER_NODATA = (NativeConstants.PERF_SIZE_ZERO | NativeConstants.PERF_DISPLAY_NOSHOW);

        /// PERF_COUNTER_MULTI_TIMER_INV -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_DELTA_COUNTER | PERF_MULTI_COUNTER | PERF_TIMER_TICK |            PERF_INVERSE_COUNTER | PERF_DISPLAY_PERCENT)
        public const int PERF_COUNTER_MULTI_TIMER_INV = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_DELTA_COUNTER
                    | (NativeConstants.PERF_MULTI_COUNTER
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_INVERSE_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))))));

        /// PERF_COUNTER_MULTI_TIMER -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_DELTA_COUNTER | PERF_TIMER_TICK | PERF_MULTI_COUNTER |            PERF_DISPLAY_PERCENT)
        public const int PERF_COUNTER_MULTI_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_DELTA_COUNTER
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_MULTI_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT))))));

        /// PERF_COUNTER_MULTI_BASE -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_BASE |            PERF_MULTI_COUNTER | PERF_DISPLAY_NOSHOW)
        public const int PERF_COUNTER_MULTI_BASE = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_BASE
                    | (NativeConstants.PERF_MULTI_COUNTER | NativeConstants.PERF_DISPLAY_NOSHOW))));

        /// PERF_COUNTER_LARGE_RAWCOUNT_HEX -> (PERF_SIZE_LARGE | PERF_TYPE_NUMBER | PERF_NUMBER_HEX |            PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_LARGE_RAWCOUNT_HEX = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_NUMBER
                    | (NativeConstants.PERF_NUMBER_HEX | NativeConstants.PERF_DISPLAY_NO_SUFFIX)));

        /// PERF_COUNTER_LARGE_RAWCOUNT -> (PERF_SIZE_LARGE | PERF_TYPE_NUMBER | PERF_NUMBER_DECIMAL |            PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_LARGE_RAWCOUNT = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_NUMBER
                    | (NativeConstants.PERF_NUMBER_DECIMAL | NativeConstants.PERF_DISPLAY_NO_SUFFIX)));

        /// PERF_COUNTER_LARGE_QUEUELEN_TYPE -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_QUEUELEN |            PERF_TIMER_TICK | PERF_DELTA_COUNTER | PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_LARGE_QUEUELEN_TYPE = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_QUEUELEN
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_NO_SUFFIX)))));

        /// PERF_COUNTER_LARGE_DELTA -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_VALUE |            PERF_DELTA_COUNTER | PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_LARGE_DELTA = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_VALUE
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_NO_SUFFIX))));

        /// PERF_COUNTER_HISTOGRAM_TYPE -> 0x80000000
        public const int PERF_COUNTER_HISTOGRAM_TYPE = -2147483648;

        /// PERF_COUNTER_HISTOGRAM -> 0x00060000
        public const int PERF_COUNTER_HISTOGRAM = 393216;

        /// PERF_COUNTER_FRACTION -> 0x00020000
        public const int PERF_COUNTER_FRACTION = 131072;

        /// PERF_COUNTER_ELAPSED -> 0x00040000
        public const int PERF_COUNTER_ELAPSED = 262144;

        /// PERF_COUNTER_DELTA -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_VALUE |            PERF_DELTA_COUNTER | PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_DELTA = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_VALUE
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_NO_SUFFIX))));

        /// PERF_COUNTER_COUNTER -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_TIMER_TICK | PERF_DELTA_COUNTER | PERF_DISPLAY_PER_SEC)
        public const int PERF_COUNTER_COUNTER = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PER_SEC)))));

        /// PERF_COUNTER_BULK_COUNT -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_TIMER_TICK | PERF_DELTA_COUNTER | PERF_DISPLAY_PER_SEC)
        public const int PERF_COUNTER_BULK_COUNT = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_TICK
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PER_SEC)))));

        /// PERF_COUNTER_BASE -> 0x00030000
        public const int PERF_COUNTER_BASE = 196608;

        /// PERF_COUNTER_100NS_QUEUELEN_TYPE -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_QUEUELEN |            PERF_TIMER_100NS | PERF_DELTA_COUNTER | PERF_DISPLAY_NO_SUFFIX)
        public const int PERF_COUNTER_100NS_QUEUELEN_TYPE = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_QUEUELEN
                    | (NativeConstants.PERF_TIMER_100NS
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_NO_SUFFIX)))));

        /// PERF_AVERAGE_TIMER -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION |            PERF_DISPLAY_SECONDS)
        public const int PERF_AVERAGE_TIMER = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_FRACTION | NativeConstants.PERF_DISPLAY_SECONDS)));

        /// PERF_AVERAGE_BULK -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_FRACTION  |            PERF_DISPLAY_NOSHOW)
        public const int PERF_AVERAGE_BULK = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_FRACTION | NativeConstants.PERF_DISPLAY_NOSHOW)));

        /// PERF_AVERAGE_BASE -> (PERF_SIZE_DWORD | PERF_TYPE_COUNTER | PERF_COUNTER_BASE |            PERF_DISPLAY_NOSHOW |            0x00000002)
        public const int PERF_AVERAGE_BASE = (NativeConstants.PERF_SIZE_DWORD
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_BASE
                    | (NativeConstants.PERF_DISPLAY_NOSHOW | 2))));

        /// PERF_100NSEC_TIMER_INV -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_TIMER_100NS | PERF_DELTA_COUNTER | PERF_INVERSE_COUNTER  |            PERF_DISPLAY_PERCENT)
        public const int PERF_100NSEC_TIMER_INV = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_100NS
                    | (NativeConstants.PERF_DELTA_COUNTER
                    | (NativeConstants.PERF_INVERSE_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT))))));

        /// PERF_100NSEC_TIMER -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_COUNTER_RATE |            PERF_TIMER_100NS | PERF_DELTA_COUNTER | PERF_DISPLAY_PERCENT)
        public const int PERF_100NSEC_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_100NS
                    | (NativeConstants.PERF_DELTA_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))));

        /// PERF_100NSEC_MULTI_TIMER_INV -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_DELTA_COUNTER  |            PERF_COUNTER_RATE | PERF_TIMER_100NS | PERF_MULTI_COUNTER |            PERF_INVERSE_COUNTER | PERF_DISPLAY_PERCENT)
        public const int PERF_100NSEC_MULTI_TIMER_INV = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_DELTA_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_100NS
                    | (NativeConstants.PERF_MULTI_COUNTER
                    | (NativeConstants.PERF_INVERSE_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT)))))));

        /// PERF_100NSEC_MULTI_TIMER -> (PERF_SIZE_LARGE | PERF_TYPE_COUNTER | PERF_DELTA_COUNTER  |            PERF_COUNTER_RATE | PERF_TIMER_100NS | PERF_MULTI_COUNTER |            PERF_DISPLAY_PERCENT)
        public const int PERF_100NSEC_MULTI_TIMER = (NativeConstants.PERF_SIZE_LARGE
                    | (NativeConstants.PERF_TYPE_COUNTER
                    | (NativeConstants.PERF_DELTA_COUNTER
                    | (NativeConstants.PERF_COUNTER_RATE
                    | (NativeConstants.PERF_TIMER_100NS
                    | (NativeConstants.PERF_MULTI_COUNTER | NativeConstants.PERF_DISPLAY_PERCENT))))));

        /// PeekMessage -> PeekMessageW
        /// Error generating expression: Value PeekMessageW is not resolved
        public const string PeekMessage = "PeekMessageW";

        /// PeekConsoleInput -> PeekConsoleInputW
        /// Error generating expression: Value PeekConsoleInputW is not resolved
        public const string PeekConsoleInput = "PeekConsoleInputW";

        /// PD_USELARGETEMPLATE -> 0x10000000
        public const int PD_USELARGETEMPLATE = 268435456;

        /// PD_USEDEVMODECOPIESANDCOLLATE -> 0x00040000
        public const int PD_USEDEVMODECOPIESANDCOLLATE = 262144;

        /// PD_USEDEVMODECOPIES -> 0x00040000
        public const int PD_USEDEVMODECOPIES = 262144;

        /// PD_SHOWHELP -> 0x00000800
        public const int PD_SHOWHELP = 2048;

        /// PD_SELECTION -> 0x00000001
        public const int PD_SELECTION = 1;

        /// PD_RETURNIC -> 0x00000200
        public const int PD_RETURNIC = 512;

        /// PD_RETURNDEFAULT -> 0x00000400
        public const int PD_RETURNDEFAULT = 1024;

        /// PD_RETURNDC -> 0x00000100
        public const int PD_RETURNDC = 256;

        /// PD_RESULT_PRINT -> 1
        public const int PD_RESULT_PRINT = 1;

        /// PD_RESULT_CANCEL -> 0
        public const int PD_RESULT_CANCEL = 0;

        /// PD_RESULT_APPLY -> 2
        public const int PD_RESULT_APPLY = 2;

        /// PD_PRINTTOFILE -> 0x00000020
        public const int PD_PRINTTOFILE = 32;

        /// PD_PRINTSETUP -> 0x00000040
        public const int PD_PRINTSETUP = 64;

        /// PD_PAGENUMS -> 0x00000002
        public const int PD_PAGENUMS = 2;

        /// PD_NOWARNING -> 0x00000080
        public const int PD_NOWARNING = 128;

        /// PD_NOSELECTION -> 0x00000004
        public const int PD_NOSELECTION = 4;

        /// PD_NOPAGENUMS -> 0x00000008
        public const int PD_NOPAGENUMS = 8;

        /// PD_NONETWORKBUTTON -> 0x00200000
        public const int PD_NONETWORKBUTTON = 2097152;

        /// PD_NOCURRENTPAGE -> 0x00800000
        public const int PD_NOCURRENTPAGE = 8388608;

        /// PD_HIDEPRINTTOFILE -> 0x00100000
        public const int PD_HIDEPRINTTOFILE = 1048576;

        /// PD_EXCL_COPIESANDCOLLATE -> (DM_COPIES | DM_COLLATE)
        public const int PD_EXCL_COPIESANDCOLLATE = (NativeConstants.DM_COPIES | NativeConstants.DM_COLLATE);

        /// PD_EXCLUSIONFLAGS -> 0x01000000
        public const int PD_EXCLUSIONFLAGS = 16777216;

        /// PD_ENABLESETUPTEMPLATEHANDLE -> 0x00020000
        public const int PD_ENABLESETUPTEMPLATEHANDLE = 131072;

        /// PD_ENABLESETUPTEMPLATE -> 0x00008000
        public const int PD_ENABLESETUPTEMPLATE = 32768;

        /// PD_ENABLESETUPHOOK -> 0x00002000
        public const int PD_ENABLESETUPHOOK = 8192;

        /// PD_ENABLEPRINTTEMPLATEHANDLE -> 0x00010000
        public const int PD_ENABLEPRINTTEMPLATEHANDLE = 65536;

        /// PD_ENABLEPRINTTEMPLATE -> 0x00004000
        public const int PD_ENABLEPRINTTEMPLATE = 16384;

        /// PD_ENABLEPRINTHOOK -> 0x00001000
        public const int PD_ENABLEPRINTHOOK = 4096;

        /// PD_DISABLEPRINTTOFILE -> 0x00080000
        public const int PD_DISABLEPRINTTOFILE = 524288;

        /// PD_CURRENTPAGE -> 0x00400000
        public const int PD_CURRENTPAGE = 4194304;

        /// PD_COLLATE -> 0x00000010
        public const int PD_COLLATE = 16;

        /// PD_ALLPAGES -> 0x00000000
        public const int PD_ALLPAGES = 0;

        /// PDIRTYUI -> (SHTDN_REASON_FLAG_PLANNED | SHTDN_REASON_FLAG_DIRTY_UI)
        public const int PDIRTYUI = (NativeConstants.SHTDN_REASON_FLAG_PLANNED | NativeConstants.SHTDN_REASON_FLAG_DIRTY_UI);

        /// PDEVICESIZE -> 26
        public const int PDEVICESIZE = 26;

        /// PDERR_SETUPFAILURE -> 0x1001
        public const int PDERR_SETUPFAILURE = 4097;

        /// PDERR_RETDEFFAILURE -> 0x1003
        public const int PDERR_RETDEFFAILURE = 4099;

        /// PDERR_PRINTERNOTFOUND -> 0x100B
        public const int PDERR_PRINTERNOTFOUND = 4107;

        /// PDERR_PRINTERCODES -> 0x1000
        public const int PDERR_PRINTERCODES = 4096;

        /// PDERR_PARSEFAILURE -> 0x1002
        public const int PDERR_PARSEFAILURE = 4098;

        /// PDERR_NODEVICES -> 0x1007
        public const int PDERR_NODEVICES = 4103;

        /// PDERR_NODEFAULTPRN -> 0x1008
        public const int PDERR_NODEFAULTPRN = 4104;

        /// PDERR_LOADDRVFAILURE -> 0x1004
        public const int PDERR_LOADDRVFAILURE = 4100;

        /// PDERR_INITFAILURE -> 0x1006
        public const int PDERR_INITFAILURE = 4102;

        /// PDERR_GETDEVMODEFAIL -> 0x1005
        public const int PDERR_GETDEVMODEFAIL = 4101;

        /// PDERR_DNDMMISMATCH -> 0x1009
        public const int PDERR_DNDMMISMATCH = 4105;

        /// PDERR_DEFAULTDIFFERENT -> 0x100C
        public const int PDERR_DEFAULTDIFFERENT = 4108;

        /// PDERR_CREATEICFAILURE -> 0x100A
        public const int PDERR_CREATEICFAILURE = 4106;

        /// PDCAP_WARM_EJECT_SUPPORTED -> 0x00000100
        public const int PDCAP_WARM_EJECT_SUPPORTED = 256;

        /// PDCAP_WAKE_FROM_D3_SUPPORTED -> 0x00000080
        public const int PDCAP_WAKE_FROM_D3_SUPPORTED = 128;

        /// PDCAP_WAKE_FROM_D2_SUPPORTED -> 0x00000040
        public const int PDCAP_WAKE_FROM_D2_SUPPORTED = 64;

        /// PDCAP_WAKE_FROM_D1_SUPPORTED -> 0x00000020
        public const int PDCAP_WAKE_FROM_D1_SUPPORTED = 32;

        /// PDCAP_WAKE_FROM_D0_SUPPORTED -> 0x00000010
        public const int PDCAP_WAKE_FROM_D0_SUPPORTED = 16;

        /// PDCAP_D3_SUPPORTED -> 0x00000008
        public const int PDCAP_D3_SUPPORTED = 8;

        /// PDCAP_D2_SUPPORTED -> 0x00000004
        public const int PDCAP_D2_SUPPORTED = 4;

        /// PDCAP_D1_SUPPORTED -> 0x00000002
        public const int PDCAP_D1_SUPPORTED = 2;

        /// PDCAP_D0_SUPPORTED -> 0x00000001
        public const int PDCAP_D0_SUPPORTED = 1;

        /// PC_WINDPOLYGON -> 4
        public const int PC_WINDPOLYGON = 4;

        /// PC_WIDESTYLED -> 64
        public const int PC_WIDESTYLED = 64;

        /// PC_WIDE -> 16
        public const int PC_WIDE = 16;

        /// PC_TRAPEZOID -> 4
        public const int PC_TRAPEZOID = 4;

        /// PC_STYLED -> 32
        public const int PC_STYLED = 32;

        /// PC_SCANLINE -> 8
        public const int PC_SCANLINE = 8;

        /// PC_RESERVED -> 0x01
        public const int PC_RESERVED = 1;

        /// PC_RECTANGLE -> 2
        public const int PC_RECTANGLE = 2;

        /// PC_POLYPOLYGON -> 256
        public const int PC_POLYPOLYGON = 256;

        /// PC_POLYGON -> 1
        public const int PC_POLYGON = 1;

        /// PC_PATHS -> 512
        public const int PC_PATHS = 512;

        /// PC_NONE -> 0
        public const int PC_NONE = 0;

        /// PC_NOCOLLAPSE -> 0x04
        public const int PC_NOCOLLAPSE = 4;

        /// PC_INTERIORS -> 128
        public const int PC_INTERIORS = 128;

        /// PC_EXPLICIT -> 0x02
        public const int PC_EXPLICIT = 2;

        /// PCLEANUI -> (SHTDN_REASON_FLAG_PLANNED | SHTDN_REASON_FLAG_CLEAN_UI)
        public const int PCLEANUI = (NativeConstants.SHTDN_REASON_FLAG_PLANNED | NativeConstants.SHTDN_REASON_FLAG_CLEAN_UI);

        /// PCASSEMBLY_DLL_REDIRECTION_DETAILED_INFORMATION -> PCASSEMBLY_FILE_DETAILED_INFORMATION
        /// Error generating expression: Value PCASSEMBLY_FILE_DETAILED_INFORMATION is not resolved
        public const string PCASSEMBLY_DLL_REDIRECTION_DETAILED_INFORMATION = "PCASSEMBLY_FILE_DETAILED_INFORMATION";

        /// PBT_APMSUSPEND -> 0x0004
        public const int PBT_APMSUSPEND = 4;

        /// PBT_APMSTANDBY -> 0x0005
        public const int PBT_APMSTANDBY = 5;

        /// PBT_APMRESUMESUSPEND -> 0x0007
        public const int PBT_APMRESUMESUSPEND = 7;

        /// PBT_APMRESUMESTANDBY -> 0x0008
        public const int PBT_APMRESUMESTANDBY = 8;

        /// PBT_APMRESUMECRITICAL -> 0x0006
        public const int PBT_APMRESUMECRITICAL = 6;

        /// PBT_APMRESUMEAUTOMATIC -> 0x0012
        public const int PBT_APMRESUMEAUTOMATIC = 18;

        /// PBT_APMQUERYSUSPENDFAILED -> 0x0002
        public const int PBT_APMQUERYSUSPENDFAILED = 2;

        /// PBT_APMQUERYSUSPEND -> 0x0000
        public const int PBT_APMQUERYSUSPEND = 0;

        /// PBT_APMQUERYSTANDBYFAILED -> 0x0003
        public const int PBT_APMQUERYSTANDBYFAILED = 3;

        /// PBT_APMQUERYSTANDBY -> 0x0001
        public const int PBT_APMQUERYSTANDBY = 1;

        /// PBT_APMPOWERSTATUSCHANGE -> 0x000A
        public const int PBT_APMPOWERSTATUSCHANGE = 10;

        /// PBT_APMOEMEVENT -> 0x000B
        public const int PBT_APMOEMEVENT = 11;

        /// PBT_APMBATTERYLOW -> 0x0009
        public const int PBT_APMBATTERYLOW = 9;

        /// PBTF_APMRESUMEFROMFAILURE -> 0x00000001
        public const int PBTF_APMRESUMEFROMFAILURE = 1;

        /// PASSTHROUGH -> 19
        public const int PASSTHROUGH = 19;

        /// PASSEMBLY_DLL_REDIRECTION_DETAILED_INFORMATION -> PASSEMBLY_FILE_DETAILED_INFORMATION
        /// Error generating expression: Value PASSEMBLY_FILE_DETAILED_INFORMATION is not resolved
        public const string PASSEMBLY_DLL_REDIRECTION_DETAILED_INFORMATION = "PASSEMBLY_FILE_DETAILED_INFORMATION";

        /// PASCAL -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string PASCAL = "__stdcall";

        /// pascal -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string pascal = "__stdcall";

        /// PARTITION_XINT13_EXTENDED -> 0x0F
        public const int PARTITION_XINT13_EXTENDED = 15;

        /// PARTITION_XINT13 -> 0x0E
        public const int PARTITION_XINT13 = 14;

        /// PARTITION_XENIX_2 -> 0x03
        public const int PARTITION_XENIX_2 = 3;

        /// PARTITION_XENIX_1 -> 0x02
        public const int PARTITION_XENIX_1 = 2;

        /// PARTITION_UNIX -> 0x63
        public const int PARTITION_UNIX = 99;

        /// PARTITION_PREP -> 0x41
        public const int PARTITION_PREP = 65;

        /// PARTITION_OS2BOOTMGR -> 0x0A
        public const int PARTITION_OS2BOOTMGR = 10;

        /// PARTITION_NTFT -> 0x80
        public const int PARTITION_NTFT = 128;

        /// PARTITION_LDM -> 0x42
        public const int PARTITION_LDM = 66;

        /// PARTITION_IFS -> 0x07
        public const int PARTITION_IFS = 7;

        /// PARTITION_HUGE -> 0x06
        public const int PARTITION_HUGE = 6;

        /// PARTITION_FAT_16 -> 0x04
        public const int PARTITION_FAT_16 = 4;

        /// PARTITION_FAT_12 -> 0x01
        public const int PARTITION_FAT_12 = 1;

        /// PARTITION_FAT32_XINT13 -> 0x0C
        public const int PARTITION_FAT32_XINT13 = 12;

        /// PARTITION_FAT32 -> 0x0B
        public const int PARTITION_FAT32 = 11;

        /// PARTITION_EXTENDED -> 0x05
        public const int PARTITION_EXTENDED = 5;

        /// PARTITION_ENTRY_UNUSED -> 0x00
        public const int PARTITION_ENTRY_UNUSED = 0;

        /// PartitionClassGuid -> GUID_DEVINTERFACE_PARTITION
        /// Error generating expression: Value GUID_DEVINTERFACE_PARTITION is not resolved
        public const string PartitionClassGuid = "GUID_DEVINTERFACE_PARTITION";

        /// PARAMFLAG_NONE -> ( 0 )
        public const int PARAMFLAG_NONE = 0;

        /// PARAMFLAG_FRETVAL -> ( 0x8 )
        public const int PARAMFLAG_FRETVAL = 8;

        /// PARAMFLAG_FOUT -> ( 0x2 )
        public const int PARAMFLAG_FOUT = 2;

        /// PARAMFLAG_FOPT -> ( 0x10 )
        public const int PARAMFLAG_FOPT = 16;

        /// PARAMFLAG_FLCID -> ( 0x4 )
        public const int PARAMFLAG_FLCID = 4;

        /// PARAMFLAG_FIN -> ( 0x1 )
        public const int PARAMFLAG_FIN = 1;

        /// PARAMFLAG_FHASDEFAULT -> ( 0x20 )
        public const int PARAMFLAG_FHASDEFAULT = 32;

        /// PARAMFLAG_FHASCUSTDATA -> ( 0x40 )
        public const int PARAMFLAG_FHASCUSTDATA = 64;

        /// PAN_XHEIGHT_INDEX -> 9
        public const int PAN_XHEIGHT_INDEX = 9;

        /// PAN_XHEIGHT_DUCKING_STD -> 6
        public const int PAN_XHEIGHT_DUCKING_STD = 6;

        /// PAN_XHEIGHT_DUCKING_SMALL -> 5
        public const int PAN_XHEIGHT_DUCKING_SMALL = 5;

        /// PAN_XHEIGHT_DUCKING_LARGE -> 7
        public const int PAN_XHEIGHT_DUCKING_LARGE = 7;

        /// PAN_XHEIGHT_CONSTANT_STD -> 3
        public const int PAN_XHEIGHT_CONSTANT_STD = 3;

        /// PAN_XHEIGHT_CONSTANT_SMALL -> 2
        public const int PAN_XHEIGHT_CONSTANT_SMALL = 2;

        /// PAN_XHEIGHT_CONSTANT_LARGE -> 4
        public const int PAN_XHEIGHT_CONSTANT_LARGE = 4;

        /// PAN_WEIGHT_VERY_LIGHT -> 2
        public const int PAN_WEIGHT_VERY_LIGHT = 2;

        /// PAN_WEIGHT_THIN -> 4
        public const int PAN_WEIGHT_THIN = 4;

        /// PAN_WEIGHT_NORD -> 11
        public const int PAN_WEIGHT_NORD = 11;

        /// PAN_WEIGHT_MEDIUM -> 6
        public const int PAN_WEIGHT_MEDIUM = 6;

        /// PAN_WEIGHT_LIGHT -> 3
        public const int PAN_WEIGHT_LIGHT = 3;

        /// PAN_WEIGHT_INDEX -> 2
        public const int PAN_WEIGHT_INDEX = 2;

        /// PAN_WEIGHT_HEAVY -> 9
        public const int PAN_WEIGHT_HEAVY = 9;

        /// PAN_WEIGHT_DEMI -> 7
        public const int PAN_WEIGHT_DEMI = 7;

        /// PAN_WEIGHT_BOOK -> 5
        public const int PAN_WEIGHT_BOOK = 5;

        /// PAN_WEIGHT_BOLD -> 8
        public const int PAN_WEIGHT_BOLD = 8;

        /// PAN_WEIGHT_BLACK -> 10
        public const int PAN_WEIGHT_BLACK = 10;

        /// PAN_STROKE_RAPID_VERT -> 6
        public const int PAN_STROKE_RAPID_VERT = 6;

        /// PAN_STROKE_RAPID_HORZ -> 7
        public const int PAN_STROKE_RAPID_HORZ = 7;

        /// PAN_STROKE_INSTANT_VERT -> 8
        public const int PAN_STROKE_INSTANT_VERT = 8;

        /// PAN_STROKE_GRADUAL_VERT -> 4
        public const int PAN_STROKE_GRADUAL_VERT = 4;

        /// PAN_STROKE_GRADUAL_TRAN -> 3
        public const int PAN_STROKE_GRADUAL_TRAN = 3;

        /// PAN_STROKE_GRADUAL_HORZ -> 5
        public const int PAN_STROKE_GRADUAL_HORZ = 5;

        /// PAN_STROKE_GRADUAL_DIAG -> 2
        public const int PAN_STROKE_GRADUAL_DIAG = 2;

        /// PAN_STROKEVARIATION_INDEX -> 5
        public const int PAN_STROKEVARIATION_INDEX = 5;

        /// PAN_STRAIGHT_ARMS_WEDGE -> 3
        public const int PAN_STRAIGHT_ARMS_WEDGE = 3;

        /// PAN_STRAIGHT_ARMS_VERT -> 4
        public const int PAN_STRAIGHT_ARMS_VERT = 4;

        /// PAN_STRAIGHT_ARMS_SINGLE_SERIF -> 5
        public const int PAN_STRAIGHT_ARMS_SINGLE_SERIF = 5;

        /// PAN_STRAIGHT_ARMS_HORZ -> 2
        public const int PAN_STRAIGHT_ARMS_HORZ = 2;

        /// PAN_STRAIGHT_ARMS_DOUBLE_SERIF -> 6
        public const int PAN_STRAIGHT_ARMS_DOUBLE_SERIF = 6;

        /// PAN_SERIF_TRIANGLE -> 10
        public const int PAN_SERIF_TRIANGLE = 10;

        /// PAN_SERIF_THIN -> 7
        public const int PAN_SERIF_THIN = 7;

        /// PAN_SERIF_SQUARE_COVE -> 4
        public const int PAN_SERIF_SQUARE_COVE = 4;

        /// PAN_SERIF_SQUARE -> 6
        public const int PAN_SERIF_SQUARE = 6;

        /// PAN_SERIF_ROUNDED -> 15
        public const int PAN_SERIF_ROUNDED = 15;

        /// PAN_SERIF_PERP_SANS -> 13
        public const int PAN_SERIF_PERP_SANS = 13;

        /// PAN_SERIF_OBTUSE_SQUARE_COVE -> 5
        public const int PAN_SERIF_OBTUSE_SQUARE_COVE = 5;

        /// PAN_SERIF_OBTUSE_SANS -> 12
        public const int PAN_SERIF_OBTUSE_SANS = 12;

        /// PAN_SERIF_OBTUSE_COVE -> 3
        public const int PAN_SERIF_OBTUSE_COVE = 3;

        /// PAN_SERIF_NORMAL_SANS -> 11
        public const int PAN_SERIF_NORMAL_SANS = 11;

        /// PAN_SERIF_FLARED -> 14
        public const int PAN_SERIF_FLARED = 14;

        /// PAN_SERIF_EXAGGERATED -> 9
        public const int PAN_SERIF_EXAGGERATED = 9;

        /// PAN_SERIF_COVE -> 2
        public const int PAN_SERIF_COVE = 2;

        /// PAN_SERIF_BONE -> 8
        public const int PAN_SERIF_BONE = 8;

        /// PAN_SERIFSTYLE_INDEX -> 1
        public const int PAN_SERIFSTYLE_INDEX = 1;

        /// PAN_PROP_VERY_EXPANDED -> 7
        public const int PAN_PROP_VERY_EXPANDED = 7;

        /// PAN_PROP_VERY_CONDENSED -> 8
        public const int PAN_PROP_VERY_CONDENSED = 8;

        /// PAN_PROP_OLD_STYLE -> 2
        public const int PAN_PROP_OLD_STYLE = 2;

        /// PAN_PROP_MONOSPACED -> 9
        public const int PAN_PROP_MONOSPACED = 9;

        /// PAN_PROP_MODERN -> 3
        public const int PAN_PROP_MODERN = 3;

        /// PAN_PROP_EXPANDED -> 5
        public const int PAN_PROP_EXPANDED = 5;

        /// PAN_PROP_EVEN_WIDTH -> 4
        public const int PAN_PROP_EVEN_WIDTH = 4;

        /// PAN_PROP_CONDENSED -> 6
        public const int PAN_PROP_CONDENSED = 6;

        /// PAN_PROPORTION_INDEX -> 3
        public const int PAN_PROPORTION_INDEX = 3;

        /// PAN_NO_FIT -> 1
        public const int PAN_NO_FIT = 1;

        /// PAN_MIDLINE_STANDARD_TRIMMED -> 2
        public const int PAN_MIDLINE_STANDARD_TRIMMED = 2;

        /// PAN_MIDLINE_STANDARD_SERIFED -> 4
        public const int PAN_MIDLINE_STANDARD_SERIFED = 4;

        /// PAN_MIDLINE_STANDARD_POINTED -> 3
        public const int PAN_MIDLINE_STANDARD_POINTED = 3;

        /// PAN_MIDLINE_LOW_TRIMMED -> 11
        public const int PAN_MIDLINE_LOW_TRIMMED = 11;

        /// PAN_MIDLINE_LOW_SERIFED -> 13
        public const int PAN_MIDLINE_LOW_SERIFED = 13;

        /// PAN_MIDLINE_LOW_POINTED -> 12
        public const int PAN_MIDLINE_LOW_POINTED = 12;

        /// PAN_MIDLINE_INDEX -> 8
        public const int PAN_MIDLINE_INDEX = 8;

        /// PAN_MIDLINE_HIGH_TRIMMED -> 5
        public const int PAN_MIDLINE_HIGH_TRIMMED = 5;

        /// PAN_MIDLINE_HIGH_SERIFED -> 7
        public const int PAN_MIDLINE_HIGH_SERIFED = 7;

        /// PAN_MIDLINE_HIGH_POINTED -> 6
        public const int PAN_MIDLINE_HIGH_POINTED = 6;

        /// PAN_MIDLINE_CONSTANT_TRIMMED -> 8
        public const int PAN_MIDLINE_CONSTANT_TRIMMED = 8;

        /// PAN_MIDLINE_CONSTANT_SERIFED -> 10
        public const int PAN_MIDLINE_CONSTANT_SERIFED = 10;

        /// PAN_MIDLINE_CONSTANT_POINTED -> 9
        public const int PAN_MIDLINE_CONSTANT_POINTED = 9;

        /// PAN_LETT_OBLIQUE_WEIGHTED -> 10
        public const int PAN_LETT_OBLIQUE_WEIGHTED = 10;

        /// PAN_LETT_OBLIQUE_SQUARE -> 15
        public const int PAN_LETT_OBLIQUE_SQUARE = 15;

        /// PAN_LETT_OBLIQUE_ROUNDED -> 13
        public const int PAN_LETT_OBLIQUE_ROUNDED = 13;

        /// PAN_LETT_OBLIQUE_OFF_CENTER -> 14
        public const int PAN_LETT_OBLIQUE_OFF_CENTER = 14;

        /// PAN_LETT_OBLIQUE_FLATTENED -> 12
        public const int PAN_LETT_OBLIQUE_FLATTENED = 12;

        /// PAN_LETT_OBLIQUE_CONTACT -> 9
        public const int PAN_LETT_OBLIQUE_CONTACT = 9;

        /// PAN_LETT_OBLIQUE_BOXED -> 11
        public const int PAN_LETT_OBLIQUE_BOXED = 11;

        /// PAN_LETT_NORMAL_WEIGHTED -> 3
        public const int PAN_LETT_NORMAL_WEIGHTED = 3;

        /// PAN_LETT_NORMAL_SQUARE -> 8
        public const int PAN_LETT_NORMAL_SQUARE = 8;

        /// PAN_LETT_NORMAL_ROUNDED -> 6
        public const int PAN_LETT_NORMAL_ROUNDED = 6;

        /// PAN_LETT_NORMAL_OFF_CENTER -> 7
        public const int PAN_LETT_NORMAL_OFF_CENTER = 7;

        /// PAN_LETT_NORMAL_FLATTENED -> 5
        public const int PAN_LETT_NORMAL_FLATTENED = 5;

        /// PAN_LETT_NORMAL_CONTACT -> 2
        public const int PAN_LETT_NORMAL_CONTACT = 2;

        /// PAN_LETT_NORMAL_BOXED -> 4
        public const int PAN_LETT_NORMAL_BOXED = 4;

        /// PAN_LETTERFORM_INDEX -> 7
        public const int PAN_LETTERFORM_INDEX = 7;

        /// PAN_FAMILY_TEXT_DISPLAY -> 2
        public const int PAN_FAMILY_TEXT_DISPLAY = 2;

        /// PAN_FAMILY_SCRIPT -> 3
        public const int PAN_FAMILY_SCRIPT = 3;

        /// PAN_FAMILY_PICTORIAL -> 5
        public const int PAN_FAMILY_PICTORIAL = 5;

        /// PAN_FAMILY_DECORATIVE -> 4
        public const int PAN_FAMILY_DECORATIVE = 4;

        /// PAN_FAMILYTYPE_INDEX -> 0
        public const int PAN_FAMILYTYPE_INDEX = 0;

        /// PAN_CULTURE_LATIN -> 0
        public const int PAN_CULTURE_LATIN = 0;

        /// PAN_CONTRAST_VERY_LOW -> 3
        public const int PAN_CONTRAST_VERY_LOW = 3;

        /// PAN_CONTRAST_VERY_HIGH -> 9
        public const int PAN_CONTRAST_VERY_HIGH = 9;

        /// PAN_CONTRAST_NONE -> 2
        public const int PAN_CONTRAST_NONE = 2;

        /// PAN_CONTRAST_MEDIUM_LOW -> 5
        public const int PAN_CONTRAST_MEDIUM_LOW = 5;

        /// PAN_CONTRAST_MEDIUM_HIGH -> 7
        public const int PAN_CONTRAST_MEDIUM_HIGH = 7;

        /// PAN_CONTRAST_MEDIUM -> 6
        public const int PAN_CONTRAST_MEDIUM = 6;

        /// PAN_CONTRAST_LOW -> 4
        public const int PAN_CONTRAST_LOW = 4;

        /// PAN_CONTRAST_INDEX -> 4
        public const int PAN_CONTRAST_INDEX = 4;

        /// PAN_CONTRAST_HIGH -> 8
        public const int PAN_CONTRAST_HIGH = 8;

        /// PAN_BENT_ARMS_WEDGE -> 8
        public const int PAN_BENT_ARMS_WEDGE = 8;

        /// PAN_BENT_ARMS_VERT -> 9
        public const int PAN_BENT_ARMS_VERT = 9;

        /// PAN_BENT_ARMS_SINGLE_SERIF -> 10
        public const int PAN_BENT_ARMS_SINGLE_SERIF = 10;

        /// PAN_BENT_ARMS_HORZ -> 7
        public const int PAN_BENT_ARMS_HORZ = 7;

        /// PAN_BENT_ARMS_DOUBLE_SERIF -> 11
        public const int PAN_BENT_ARMS_DOUBLE_SERIF = 11;

        /// PAN_ARMSTYLE_INDEX -> 6
        public const int PAN_ARMSTYLE_INDEX = 6;

        /// PAN_ANY -> 0
        public const int PAN_ANY = 0;

        /// PANOSE_COUNT -> 10
        public const int PANOSE_COUNT = 10;

        /// PAGE_WRITECOPY -> 0x08
        public const int PAGE_WRITECOPY = 8;

        /// PAGE_WRITECOMBINE -> 0x400
        public const int PAGE_WRITECOMBINE = 1024;

        /// PAGE_READWRITE -> 0x04
        public const int PAGE_READWRITE = 4;

        /// PAGE_READONLY -> 0x02
        public const int PAGE_READONLY = 2;

        /// PAGE_NOCACHE -> 0x200
        public const int PAGE_NOCACHE = 512;

        /// PAGE_NOACCESS -> 0x01
        public const int PAGE_NOACCESS = 1;

        /// PAGE_GUARD -> 0x100
        public const int PAGE_GUARD = 256;

        /// PAGE_EXECUTE_WRITECOPY -> 0x80
        public const int PAGE_EXECUTE_WRITECOPY = 128;

        /// PAGE_EXECUTE_READWRITE -> 0x40
        public const int PAGE_EXECUTE_READWRITE = 64;

        /// PAGE_EXECUTE_READ -> 0x20
        public const int PAGE_EXECUTE_READ = 32;

        /// PAGE_EXECUTE -> 0x10
        public const int PAGE_EXECUTE = 16;

        /// PAGESETUPDLGORDMOTIF -> 1550
        public const int PAGESETUPDLGORDMOTIF = 1550;

        /// PAGESETUPDLGORD -> 1546
        public const int PAGESETUPDLGORD = 1546;

        /// PageSetupDlg -> PageSetupDlgW
        /// Error generating expression: Value PageSetupDlgW is not resolved
        public const string PageSetupDlg = "PageSetupDlgW";

        /// PROPSHEETPAGEW_V2_SIZE -> CCSIZEOF_STRUCT(PROPSHEETPAGEW, pszHeaderSubTitle)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PROPSHEETPAGEW_V2_SIZE = "CCSIZEOF_STRUCT(PROPSHEETPAGEW, pszHeaderSubTitle)";

        /// PROPSHEETPAGEW_V1_SIZE -> CCSIZEOF_STRUCT(PROPSHEETPAGEW, pcRefParent)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PROPSHEETPAGEW_V1_SIZE = "CCSIZEOF_STRUCT(PROPSHEETPAGEW, pcRefParent)";

        /// PROPSHEETHEADERW_V2_SIZE -> CCSIZEOF_STRUCT(PROPSHEETHEADERW, DUMMYUNION5_MEMBER(hbmHeader))
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PROPSHEETHEADERW_V2_SIZE = "CCSIZEOF_STRUCT(PROPSHEETHEADERW, DUMMYUNION5_MEMBER(hbmHeader))";

        /// PROPSHEETHEADERW_V1_SIZE -> CCSIZEOF_STRUCT(PROPSHEETHEADERW, pfnCallback)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string PROPSHEETHEADERW_V1_SIZE = "CCSIZEOF_STRUCT(PROPSHEETHEADERW, pfnCallback)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// PostAppMessageW -> "(idThread,wMsg,wParam,lParam) PostThreadMessageW((DWORD)idThread, wMsg, wParam, lParam)"
        public const string PostAppMessageW = "(idThread,wMsg,wParam,lParam) PostThreadMessageW((DWORD)idThread, wMsg, wParam, l" +
            "Param)";
        
    }
    
}
