namespace NWin32
{
    public partial class NativeConstants
    {

        /// hyper -> __int64
        /// Error generating expression: Value __int64 is not resolved
        public const string hyper = "__int64";

        /// HW_PROFILE_GUIDLEN -> 39
        public const int HW_PROFILE_GUIDLEN = 39;

        /// HWND_TOPMOST -> ((HWND)-1)
        /// Error generating expression: Value HWND is not resolved
        public const string HWND_TOPMOST = "((HWND)-1)";

        /// HWND_NOTOPMOST -> ((HWND)-2)
        /// Error generating expression: Value HWND is not resolved
        public const string HWND_NOTOPMOST = "((HWND)-2)";

        /// HWND_MESSAGE -> ((HWND)-3)
        /// Error generating expression: Value HWND is not resolved
        public const string HWND_MESSAGE = "((HWND)-3)";

        /// HTZOOM -> HTMAXBUTTON
        public const int HTZOOM = NativeConstants.HTMAXBUTTON;

        /// HTVSCROLL -> 7
        public const int HTVSCROLL = 7;

        /// HTTRANSPARENT -> (-1)
        public const int HTTRANSPARENT = -1;

        /// HTTOPRIGHT -> 14
        public const int HTTOPRIGHT = 14;

        /// HTTOPLEFT -> 13
        public const int HTTOPLEFT = 13;

        /// HTTOP -> 12
        public const int HTTOP = 12;

        /// HTSYSMENU -> 3
        public const int HTSYSMENU = 3;

        /// HTSIZELAST -> HTBOTTOMRIGHT
        public const int HTSIZELAST = NativeConstants.HTBOTTOMRIGHT;

        /// HTSIZEFIRST -> HTLEFT
        public const int HTSIZEFIRST = NativeConstants.HTLEFT;

        /// HTSIZE -> HTGROWBOX
        public const int HTSIZE = NativeConstants.HTGROWBOX;

        /// HTRIGHT -> 11
        public const int HTRIGHT = 11;

        /// HTREDUCE -> HTMINBUTTON
        public const int HTREDUCE = NativeConstants.HTMINBUTTON;

        /// HTOBJECT -> 19
        public const int HTOBJECT = 19;

        /// HTNOWHERE -> 0
        public const int HTNOWHERE = 0;

        /// HTMINBUTTON -> 8
        public const int HTMINBUTTON = 8;

        /// HTMENU -> 5
        public const int HTMENU = 5;

        /// HTMAXBUTTON -> 9
        public const int HTMAXBUTTON = 9;

        /// HTLEFT -> 10
        public const int HTLEFT = 10;

        /// HTHSCROLL -> 6
        public const int HTHSCROLL = 6;

        /// HTHELP -> 21
        public const int HTHELP = 21;

        /// HTGROWBOX -> 4
        public const int HTGROWBOX = 4;

        /// HTERROR -> (-2)
        public const int HTERROR = -2;

        /// HTCLOSE -> 20
        public const int HTCLOSE = 20;

        /// HTCLIENT -> 1
        public const int HTCLIENT = 1;

        /// HTCAPTION -> 2
        public const int HTCAPTION = 2;

        /// HTBOTTOMRIGHT -> 17
        public const int HTBOTTOMRIGHT = 17;

        /// HTBOTTOMLEFT -> 16
        public const int HTBOTTOMLEFT = 16;

        /// HTBOTTOM -> 15
        public const int HTBOTTOM = 15;

        /// HTBORDER -> 18
        public const int HTBORDER = 18;

        /// HS_VERTICAL -> 1
        public const int HS_VERTICAL = 1;

        /// HS_HORIZONTAL -> 0
        public const int HS_HORIZONTAL = 0;

        /// HS_FDIAGONAL -> 2
        public const int HS_FDIAGONAL = 2;

        /// HS_DIAGCROSS -> 5
        public const int HS_DIAGCROSS = 5;

        /// HS_CROSS -> 4
        public const int HS_CROSS = 4;

        /// HS_BDIAGONAL -> 3
        public const int HS_BDIAGONAL = 3;

        /// HSHELL_WINDOWREPLACING -> 14
        public const int HSHELL_WINDOWREPLACING = 14;

        /// HSHELL_WINDOWREPLACED -> 13
        public const int HSHELL_WINDOWREPLACED = 13;

        /// HSHELL_WINDOWDESTROYED -> 2
        public const int HSHELL_WINDOWDESTROYED = 2;

        /// HSHELL_WINDOWCREATED -> 1
        public const int HSHELL_WINDOWCREATED = 1;

        /// HSHELL_WINDOWACTIVATED -> 4
        public const int HSHELL_WINDOWACTIVATED = 4;

        /// HSHELL_TASKMAN -> 7
        public const int HSHELL_TASKMAN = 7;

        /// HSHELL_SYSMENU -> 9
        public const int HSHELL_SYSMENU = 9;

        /// HSHELL_RUDEAPPACTIVATED -> (HSHELL_WINDOWACTIVATED|HSHELL_HIGHBIT)
        public const int HSHELL_RUDEAPPACTIVATED = (NativeConstants.HSHELL_WINDOWACTIVATED | NativeConstants.HSHELL_HIGHBIT);

        /// HSHELL_REDRAW -> 6
        public const int HSHELL_REDRAW = 6;

        /// HSHELL_LANGUAGE -> 8
        public const int HSHELL_LANGUAGE = 8;

        /// HSHELL_HIGHBIT -> 0x8000
        public const int HSHELL_HIGHBIT = 32768;

        /// HSHELL_GETMINRECT -> 5
        public const int HSHELL_GETMINRECT = 5;

        /// HSHELL_FLASH -> (HSHELL_REDRAW|HSHELL_HIGHBIT)
        public const int HSHELL_FLASH = (NativeConstants.HSHELL_REDRAW | NativeConstants.HSHELL_HIGHBIT);

        /// HSHELL_ENDTASK -> 10
        public const int HSHELL_ENDTASK = 10;

        /// HSHELL_APPCOMMAND -> 12
        public const int HSHELL_APPCOMMAND = 12;

        /// HSHELL_ACTIVATESHELLWINDOW -> 3
        public const int HSHELL_ACTIVATESHELLWINDOW = 3;

        /// HSHELL_ACCESSIBILITYSTATE -> 11
        public const int HSHELL_ACCESSIBILITYSTATE = 11;

        /// HP_TLS1PRF_SEED -> 0x0007
        public const int HP_TLS1PRF_SEED = 7;

        /// HP_TLS1PRF_LABEL -> 0x0006
        public const int HP_TLS1PRF_LABEL = 6;

        /// HP_HMAC_INFO -> 0x0005
        public const int HP_HMAC_INFO = 5;

        /// HP_HASHVAL -> 0x0002
        public const int HP_HASHVAL = 2;

        /// HP_HASHSIZE -> 0x0004
        public const int HP_HASHSIZE = 4;

        /// HP_ALGID -> 0x0001
        public const int HP_ALGID = 1;

        /// HOVER_DEFAULT -> 0xFFFFFFFF
        public const int HOVER_DEFAULT = -1;

        /// HOST_NOT_FOUND -> WSAHOST_NOT_FOUND
        public const int HOST_NOT_FOUND = NativeConstants.WSAHOST_NOT_FOUND;

        /// HORZSIZE -> 4
        public const int HORZSIZE = 4;

        /// HORZRES -> 8
        public const int HORZRES = 8;

        /// HOLLOW_BRUSH -> NULL_BRUSH
        public const int HOLLOW_BRUSH = NativeConstants.NULL_BRUSH;

        /// HKL_PREV -> 0
        public const int HKL_PREV = 0;

        /// HKL_NEXT -> 1
        public const int HKL_NEXT = 1;

        /// HIST_NO_OF_BUCKETS -> 24
        public const int HIST_NO_OF_BUCKETS = 24;

        /// HINSTANCE_ERROR -> 32
        public const int HINSTANCE_ERROR = 32;

        /// HIGH_PRIORITY_CLASS -> 0x00000080
        public const int HIGH_PRIORITY_CLASS = 128;

        /// HIDE_WINDOW -> 0
        public const int HIDE_WINDOW = 0;

        /// HFILE_ERROR -> ((HFILE)-1)
        /// Error generating expression: Value HFILE is not resolved
        public const string HFILE_ERROR = "((HFILE)-1)";

        /// HELP_WM_HELP -> 0x000c
        public const int HELP_WM_HELP = 12;

        /// HELP_TCARD_OTHER_CALLER -> 0x0011
        public const int HELP_TCARD_OTHER_CALLER = 17;

        /// HELP_TCARD_DATA -> 0x0010
        public const int HELP_TCARD_DATA = 16;

        /// HELP_TCARD -> 0x8000
        public const int HELP_TCARD = 32768;

        /// HELP_SETWINPOS -> 0x0203L
        public const int HELP_SETWINPOS = 515;

        /// HELP_SETPOPUP_POS -> 0x000d
        public const int HELP_SETPOPUP_POS = 13;

        /// HELP_SETINDEX -> 0x0005L
        public const int HELP_SETINDEX = 5;

        /// HELP_SETCONTENTS -> 0x0005L
        public const int HELP_SETCONTENTS = 5;

        /// HELP_QUIT -> 0x0002L
        public const int HELP_QUIT = 2;

        /// HELP_PARTIALKEY -> 0x0105L
        public const int HELP_PARTIALKEY = 261;

        /// HELP_MULTIKEY -> 0x0201L
        public const int HELP_MULTIKEY = 513;

        /// HELP_KEY -> 0x0101L
        public const int HELP_KEY = 257;

        /// HELP_INDEX -> 0x0003L
        public const int HELP_INDEX = 3;

        /// HELP_HELPONHELP -> 0x0004L
        public const int HELP_HELPONHELP = 4;

        /// HELP_FORCEFILE -> 0x0009L
        public const int HELP_FORCEFILE = 9;

        /// HELP_FINDER -> 0x000b
        public const int HELP_FINDER = 11;

        /// HELP_CONTEXTPOPUP -> 0x0008L
        public const int HELP_CONTEXTPOPUP = 8;

        /// HELP_CONTEXTMENU -> 0x000a
        public const int HELP_CONTEXTMENU = 10;

        /// HELP_CONTEXT -> 0x0001L
        public const int HELP_CONTEXT = 1;

        /// HELP_CONTENTS -> 0x0003L
        public const int HELP_CONTENTS = 3;

        /// HELP_COMMAND -> 0x0102L
        public const int HELP_COMMAND = 258;

        /// HELPMSGSTRINGW -> L"commdlg_help"
        public const string HELPMSGSTRINGW = "commdlg_help";

        /// HELPMSGSTRINGA -> "commdlg_help"
        public const string HELPMSGSTRINGA = "commdlg_help";

        /// HELPMSGSTRING -> HELPMSGSTRINGW
        public const string HELPMSGSTRING = NativeConstants.HELPMSGSTRINGW;

        /// HELPINFO_WINDOW -> 0x0001
        public const int HELPINFO_WINDOW = 1;

        /// HELPINFO_MENUITEM -> 0x0002
        public const int HELPINFO_MENUITEM = 2;

        /// HEBREW_CHARSET -> 177
        public const int HEBREW_CHARSET = 177;

        /// HEAP_ZERO_MEMORY -> 0x00000008
        public const int HEAP_ZERO_MEMORY = 8;

        /// HEAP_TAIL_CHECKING_ENABLED -> 0x00000020
        public const int HEAP_TAIL_CHECKING_ENABLED = 32;

        /// HEAP_TAG_SHIFT -> 18
        public const int HEAP_TAG_SHIFT = 18;

        /// HEAP_REALLOC_IN_PLACE_ONLY -> 0x00000010
        public const int HEAP_REALLOC_IN_PLACE_ONLY = 16;

        /// HEAP_PSEUDO_TAG_FLAG -> 0x8000
        public const int HEAP_PSEUDO_TAG_FLAG = 32768;

        /// HEAP_NO_SERIALIZE -> 0x00000001
        public const int HEAP_NO_SERIALIZE = 1;

        /// HEAP_MAXIMUM_TAG -> 0x0FFF
        public const int HEAP_MAXIMUM_TAG = 4095;

        /// HEAP_GROWABLE -> 0x00000002
        public const int HEAP_GROWABLE = 2;

        /// HEAP_GENERATE_EXCEPTIONS -> 0x00000004
        public const int HEAP_GENERATE_EXCEPTIONS = 4;

        /// HEAP_FREE_CHECKING_ENABLED -> 0x00000040
        public const int HEAP_FREE_CHECKING_ENABLED = 64;

        /// HEAP_DISABLE_COALESCE_ON_FREE -> 0x00000080
        public const int HEAP_DISABLE_COALESCE_ON_FREE = 128;

        /// HEAP_CREATE_ENABLE_TRACING -> 0x00020000
        public const int HEAP_CREATE_ENABLE_TRACING = 131072;

        /// HEAP_CREATE_ENABLE_EXECUTE -> 0x00040000
        public const int HEAP_CREATE_ENABLE_EXECUTE = 262144;

        /// HEAP_CREATE_ALIGN_16 -> 0x00010000
        public const int HEAP_CREATE_ALIGN_16 = 65536;

        /// HDATA_APPOWNED -> 0x0001
        public const int HDATA_APPOWNED = 1;

        /// HC_SYSMODALON -> 4
        public const int HC_SYSMODALON = 4;

        /// HC_SYSMODALOFF -> 5
        public const int HC_SYSMODALOFF = 5;

        /// HC_SKIP -> 2
        public const int HC_SKIP = 2;

        /// HC_NOREMOVE -> 3
        public const int HC_NOREMOVE = 3;

        /// HC_NOREM -> HC_NOREMOVE
        public const int HC_NOREM = NativeConstants.HC_NOREMOVE;

        /// HC_GETNEXT -> 1
        public const int HC_GETNEXT = 1;

        /// HC_ACTION -> 0
        public const int HC_ACTION = 0;

        /// HCF_LOGONDESKTOP -> 0x00000100
        public const int HCF_LOGONDESKTOP = 256;

        /// HCF_INDICATOR -> 0x00000020
        public const int HCF_INDICATOR = 32;

        /// HCF_HOTKEYSOUND -> 0x00000010
        public const int HCF_HOTKEYSOUND = 16;

        /// HCF_HOTKEYAVAILABLE -> 0x00000040
        public const int HCF_HOTKEYAVAILABLE = 64;

        /// HCF_HOTKEYACTIVE -> 0x00000004
        public const int HCF_HOTKEYACTIVE = 4;

        /// HCF_HIGHCONTRASTON -> 0x00000001
        public const int HCF_HIGHCONTRASTON = 1;

        /// HCF_DEFAULTDESKTOP -> 0x00000200
        public const int HCF_DEFAULTDESKTOP = 512;

        /// HCF_CONFIRMHOTKEY -> 0x00000008
        public const int HCF_CONFIRMHOTKEY = 8;

        /// HCF_AVAILABLE -> 0x00000002
        public const int HCF_AVAILABLE = 2;

        /// HCBT_SYSCOMMAND -> 8
        public const int HCBT_SYSCOMMAND = 8;

        /// HCBT_SETFOCUS -> 9
        public const int HCBT_SETFOCUS = 9;

        /// HCBT_QS -> 2
        public const int HCBT_QS = 2;

        /// HCBT_MOVESIZE -> 0
        public const int HCBT_MOVESIZE = 0;

        /// HCBT_MINMAX -> 1
        public const int HCBT_MINMAX = 1;

        /// HCBT_KEYSKIPPED -> 7
        public const int HCBT_KEYSKIPPED = 7;

        /// HCBT_DESTROYWND -> 4
        public const int HCBT_DESTROYWND = 4;

        /// HCBT_CREATEWND -> 3
        public const int HCBT_CREATEWND = 3;

        /// HCBT_CLICKSKIPPED -> 6
        public const int HCBT_CLICKSKIPPED = 6;

        /// HCBT_ACTIVATE -> 5
        public const int HCBT_ACTIVATE = 5;

        /// HBMMENU_CALLBACK -> ((HBITMAP) -1)
        /// Error generating expression: Value HBITMAP is not resolved
        public const string HBMMENU_CALLBACK = "((HBITMAP) -1)";

        /// HANGUP_PENDING -> 0x04
        public const int HANGUP_PENDING = 4;

        /// HANGUP_COMPLETE -> 0x05
        public const int HANGUP_COMPLETE = 5;

        /// HANGUL_CHARSET -> 129
        public const int HANGUL_CHARSET = 129;

        /// HANGEUL_CHARSET -> 129
        public const int HANGEUL_CHARSET = 129;

        /// HANDLE_FLAG_PROTECT_FROM_CLOSE -> 0x00000002
        public const int HANDLE_FLAG_PROTECT_FROM_CLOSE = 2;

        /// HANDLE_FLAG_INHERIT -> 0x00000001
        public const int HANDLE_FLAG_INHERIT = 1;

        /// HALFTONE -> 4
        public const int HALFTONE = 4;
    }

}
