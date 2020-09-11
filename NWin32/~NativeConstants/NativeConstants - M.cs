namespace NWin32
{
    public partial class NativeConstants
    {

        /// MWT_RIGHTMULTIPLY -> 3
        public const int MWT_RIGHTMULTIPLY = 3;

        /// MWT_MIN -> MWT_IDENTITY
        public const int MWT_MIN = NativeConstants.MWT_IDENTITY;

        /// MWT_MAX -> MWT_RIGHTMULTIPLY
        public const int MWT_MAX = NativeConstants.MWT_RIGHTMULTIPLY;

        /// MWT_LEFTMULTIPLY -> 2
        public const int MWT_LEFTMULTIPLY = 2;

        /// MWT_IDENTITY -> 1
        public const int MWT_IDENTITY = 1;

        /// MWMO_WAITALL -> 0x0001
        public const int MWMO_WAITALL = 1;

        /// MWMO_INPUTAVAILABLE -> 0x0004
        public const int MWMO_INPUTAVAILABLE = 4;

        /// MWMO_ALERTABLE -> 0x0002
        public const int MWMO_ALERTABLE = 2;

        /// MUTZ_REQUIRESAVEDFILECHECK -> 0x00000400
        public const int MUTZ_REQUIRESAVEDFILECHECK = 1024;

        /// MUTZ_NOSAVEDFILECHECK -> 0x00000001
        public const int MUTZ_NOSAVEDFILECHECK = 1;

        /// MUTZ_ISFILE -> 0x00000002
        public const int MUTZ_ISFILE = 2;

        /// MUTZ_ENFORCERESTRICTED -> 0x00000100
        public const int MUTZ_ENFORCERESTRICTED = 256;

        /// MUTZ_DONT_UNESCAPE -> 0x00000800
        public const int MUTZ_DONT_UNESCAPE = 2048;

        /// MUTZ_ACCEPT_WILDCARD_SCHEME -> 0x00000080
        public const int MUTZ_ACCEPT_WILDCARD_SCHEME = 128;

        /// MUTEX_MODIFY_STATE -> MUTANT_QUERY_STATE
        public const int MUTEX_MODIFY_STATE = NativeConstants.MUTANT_QUERY_STATE;

        /// MUTEX_ALL_ACCESS -> MUTANT_ALL_ACCESS
        public const int MUTEX_ALL_ACCESS = NativeConstants.MUTANT_ALL_ACCESS;

        /// MUTANT_QUERY_STATE -> 0x0001
        public const int MUTANT_QUERY_STATE = 1;

        /// MUTANT_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|                          MUTANT_QUERY_STATE)
        public const int MUTANT_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE | NativeConstants.MUTANT_QUERY_STATE));

        /// MultinetGetConnectionPerformance -> MultinetGetConnectionPerformanceW
        /// Error generating expression: Value MultinetGetConnectionPerformanceW is not resolved
        public const string MultinetGetConnectionPerformance = "MultinetGetConnectionPerformanceW";

        /// MULTIFILEOPENORD -> 1537
        public const int MULTIFILEOPENORD = 1537;

        /// MS_STRONG_PROV_W -> L"Microsoft Strong Cryptographic Provider"
        public const string MS_STRONG_PROV_W = "Microsoft Strong Cryptographic Provider";

        /// MS_STRONG_PROV_A -> "Microsoft Strong Cryptographic Provider"
        public const string MS_STRONG_PROV_A = "Microsoft Strong Cryptographic Provider";

        /// MS_STRONG_PROV -> MS_STRONG_PROV_W
        public const string MS_STRONG_PROV = NativeConstants.MS_STRONG_PROV_W;

        /// MS_SCARD_PROV_W -> L"Microsoft Base Smart Card Crypto Provider"
        public const string MS_SCARD_PROV_W = "Microsoft Base Smart Card Crypto Provider";

        /// MS_SCARD_PROV_A -> "Microsoft Base Smart Card Crypto Provider"
        public const string MS_SCARD_PROV_A = "Microsoft Base Smart Card Crypto Provider";

        /// MS_SCARD_PROV -> MS_SCARD_PROV_W
        public const string MS_SCARD_PROV = NativeConstants.MS_SCARD_PROV_W;

        /// MS_NBF -> "MNBF"
        public const string MS_NBF = "MNBF";

        /// MS_ENH_RSA_AES_PROV_W -> L"Microsoft Enhanced RSA and AES Cryptographic Provider"
        public const string MS_ENH_RSA_AES_PROV_W = "Microsoft Enhanced RSA and AES Cryptographic Provider";

        /// MS_ENH_RSA_AES_PROV_A -> "Microsoft Enhanced RSA and AES Cryptographic Provider"
        public const string MS_ENH_RSA_AES_PROV_A = "Microsoft Enhanced RSA and AES Cryptographic Provider";

        /// MS_ENH_RSA_AES_PROV -> MS_ENH_RSA_AES_PROV_W
        public const string MS_ENH_RSA_AES_PROV = NativeConstants.MS_ENH_RSA_AES_PROV_W;

        /// MS_ENH_DSS_DH_PROV_W -> L"Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider"
        public const string MS_ENH_DSS_DH_PROV_W = "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

        /// MS_ENH_DSS_DH_PROV_A -> "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider"
        public const string MS_ENH_DSS_DH_PROV_A = "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

        /// MS_ENH_DSS_DH_PROV -> MS_ENH_DSS_DH_PROV_W
        public const string MS_ENH_DSS_DH_PROV = NativeConstants.MS_ENH_DSS_DH_PROV_W;

        /// MS_ENHANCED_PROV_W -> L"Microsoft Enhanced Cryptographic Provider v1.0"
        public const string MS_ENHANCED_PROV_W = "Microsoft Enhanced Cryptographic Provider v1.0";

        /// MS_ENHANCED_PROV_A -> "Microsoft Enhanced Cryptographic Provider v1.0"
        public const string MS_ENHANCED_PROV_A = "Microsoft Enhanced Cryptographic Provider v1.0";

        /// MS_ENHANCED_PROV -> MS_ENHANCED_PROV_W
        public const string MS_ENHANCED_PROV = NativeConstants.MS_ENHANCED_PROV_W;

        /// MS_DEF_RSA_SIG_PROV_W -> L"Microsoft RSA Signature Cryptographic Provider"
        public const string MS_DEF_RSA_SIG_PROV_W = "Microsoft RSA Signature Cryptographic Provider";

        /// MS_DEF_RSA_SIG_PROV_A -> "Microsoft RSA Signature Cryptographic Provider"
        public const string MS_DEF_RSA_SIG_PROV_A = "Microsoft RSA Signature Cryptographic Provider";

        /// MS_DEF_RSA_SIG_PROV -> MS_DEF_RSA_SIG_PROV_W
        public const string MS_DEF_RSA_SIG_PROV = NativeConstants.MS_DEF_RSA_SIG_PROV_W;

        /// MS_DEF_RSA_SCHANNEL_PROV_W -> L"Microsoft RSA SChannel Cryptographic Provider"
        public const string MS_DEF_RSA_SCHANNEL_PROV_W = "Microsoft RSA SChannel Cryptographic Provider";

        /// MS_DEF_RSA_SCHANNEL_PROV_A -> "Microsoft RSA SChannel Cryptographic Provider"
        public const string MS_DEF_RSA_SCHANNEL_PROV_A = "Microsoft RSA SChannel Cryptographic Provider";

        /// MS_DEF_RSA_SCHANNEL_PROV -> MS_DEF_RSA_SCHANNEL_PROV_W
        public const string MS_DEF_RSA_SCHANNEL_PROV = NativeConstants.MS_DEF_RSA_SCHANNEL_PROV_W;

        /// MS_DEF_PROV_W -> L"Microsoft Base Cryptographic Provider v1.0"
        public const string MS_DEF_PROV_W = "Microsoft Base Cryptographic Provider v1.0";

        /// MS_DEF_PROV_A -> "Microsoft Base Cryptographic Provider v1.0"
        public const string MS_DEF_PROV_A = "Microsoft Base Cryptographic Provider v1.0";

        /// MS_DEF_PROV -> MS_DEF_PROV_W
        public const string MS_DEF_PROV = NativeConstants.MS_DEF_PROV_W;

        /// MS_DEF_DSS_PROV_W -> L"Microsoft Base DSS Cryptographic Provider"
        public const string MS_DEF_DSS_PROV_W = "Microsoft Base DSS Cryptographic Provider";

        /// MS_DEF_DSS_PROV_A -> "Microsoft Base DSS Cryptographic Provider"
        public const string MS_DEF_DSS_PROV_A = "Microsoft Base DSS Cryptographic Provider";

        /// MS_DEF_DSS_PROV -> MS_DEF_DSS_PROV_W
        public const string MS_DEF_DSS_PROV = NativeConstants.MS_DEF_DSS_PROV_W;

        /// MS_DEF_DSS_DH_PROV_W -> L"Microsoft Base DSS and Diffie-Hellman Cryptographic Provider"
        public const string MS_DEF_DSS_DH_PROV_W = "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

        /// MS_DEF_DSS_DH_PROV_A -> "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider"
        public const string MS_DEF_DSS_DH_PROV_A = "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

        /// MS_DEF_DSS_DH_PROV -> MS_DEF_DSS_DH_PROV_W
        public const string MS_DEF_DSS_DH_PROV = NativeConstants.MS_DEF_DSS_DH_PROV_W;

        /// MS_DEF_DH_SCHANNEL_PROV_W -> L"Microsoft DH SChannel Cryptographic Provider"
        public const string MS_DEF_DH_SCHANNEL_PROV_W = "Microsoft DH SChannel Cryptographic Provider";

        /// MS_DEF_DH_SCHANNEL_PROV_A -> "Microsoft DH SChannel Cryptographic Provider"
        public const string MS_DEF_DH_SCHANNEL_PROV_A = "Microsoft DH SChannel Cryptographic Provider";

        /// MS_DEF_DH_SCHANNEL_PROV -> MS_DEF_DH_SCHANNEL_PROV_W
        public const string MS_DEF_DH_SCHANNEL_PROV = NativeConstants.MS_DEF_DH_SCHANNEL_PROV_W;

        /// MSG_PEEK -> 0x2
        public const int MSG_PEEK = 2;

        /// MSG_PARTIAL -> 0x8000
        public const int MSG_PARTIAL = 32768;

        /// MSG_OOB -> 0x1
        public const int MSG_OOB = 1;

        /// MSG_MAXIOVLEN -> 16
        public const int MSG_MAXIOVLEN = 16;

        /// MSG_DONTROUTE -> 0x4
        public const int MSG_DONTROUTE = 4;

        /// MSGF_USER -> 4096
        public const int MSGF_USER = 4096;

        /// MSGF_SCROLLBAR -> 5
        public const int MSGF_SCROLLBAR = 5;

        /// MSGF_NEXTWINDOW -> 6
        public const int MSGF_NEXTWINDOW = 6;

        /// MSGF_MESSAGEBOX -> 1
        public const int MSGF_MESSAGEBOX = 1;

        /// MSGF_MENU -> 2
        public const int MSGF_MENU = 2;

        /// MSGF_MAX -> 8
        public const int MSGF_MAX = 8;

        /// MSGF_DIALOGBOX -> 0
        public const int MSGF_DIALOGBOX = 0;

        /// MSGF_DDEMGR -> 0x8001
        public const int MSGF_DDEMGR = 32769;

        /// MoveMemory -> RtlMoveMemory
        public const string MoveMemory = NativeConstants.RtlMoveMemory;

        /// MOVEFILE_WRITE_THROUGH -> 0x00000008
        public const int MOVEFILE_WRITE_THROUGH = 8;

        /// MOVEFILE_REPLACE_EXISTING -> 0x00000001
        public const int MOVEFILE_REPLACE_EXISTING = 1;

        /// MOVEFILE_FAIL_IF_NOT_TRACKABLE -> 0x00000020
        public const int MOVEFILE_FAIL_IF_NOT_TRACKABLE = 32;

        /// MOVEFILE_DELAY_UNTIL_REBOOT -> 0x00000004
        public const int MOVEFILE_DELAY_UNTIL_REBOOT = 4;

        /// MOVEFILE_CREATE_HARDLINK -> 0x00000010
        public const int MOVEFILE_CREATE_HARDLINK = 16;

        /// MOVEFILE_COPY_ALLOWED -> 0x00000002
        public const int MOVEFILE_COPY_ALLOWED = 2;

        /// MoveFileWithProgress -> MoveFileWithProgressW
        /// Error generating expression: Value MoveFileWithProgressW is not resolved
        public const string MoveFileWithProgress = "MoveFileWithProgressW";

        /// MoveFileEx -> MoveFileExW
        /// Error generating expression: Value MoveFileExW is not resolved
        public const string MoveFileEx = "MoveFileExW";

        /// MoveFile -> MoveFileW
        /// Error generating expression: Value MoveFileW is not resolved
        public const string MoveFile = "MoveFileW";

        /// MOUSE_WHEELED -> 0x0004
        public const int MOUSE_WHEELED = 4;

        /// MOUSE_VIRTUAL_DESKTOP -> 0x02
        public const int MOUSE_VIRTUAL_DESKTOP = 2;

        /// MOUSE_MOVE_RELATIVE -> 0
        public const int MOUSE_MOVE_RELATIVE = 0;

        /// MOUSE_MOVE_ABSOLUTE -> 1
        public const int MOUSE_MOVE_ABSOLUTE = 1;

        /// MOUSE_MOVED -> 0x0001
        public const int MOUSE_MOVED = 1;

        /// MOUSE_EVENT -> 0x0002
        public const int MOUSE_EVENT = 2;

        /// MOUSE_ATTRIBUTES_CHANGED -> 0x04
        public const int MOUSE_ATTRIBUTES_CHANGED = 4;

        /// MOUSETRAILS -> 39
        public const int MOUSETRAILS = 39;

        /// MOUSEEVENTF_XUP -> 0x0100
        public const int MOUSEEVENTF_XUP = 256;

        /// MOUSEEVENTF_XDOWN -> 0x0080
        public const int MOUSEEVENTF_XDOWN = 128;

        /// MOUSEEVENTF_WHEEL -> 0x0800
        public const int MOUSEEVENTF_WHEEL = 2048;

        /// MOUSEEVENTF_VIRTUALDESK -> 0x4000
        public const int MOUSEEVENTF_VIRTUALDESK = 16384;

        /// MOUSEEVENTF_RIGHTUP -> 0x0010
        public const int MOUSEEVENTF_RIGHTUP = 16;

        /// MOUSEEVENTF_RIGHTDOWN -> 0x0008
        public const int MOUSEEVENTF_RIGHTDOWN = 8;

        /// MOUSEEVENTF_MOVE -> 0x0001
        public const int MOUSEEVENTF_MOVE = 1;

        /// MOUSEEVENTF_MIDDLEUP -> 0x0040
        public const int MOUSEEVENTF_MIDDLEUP = 64;

        /// MOUSEEVENTF_MIDDLEDOWN -> 0x0020
        public const int MOUSEEVENTF_MIDDLEDOWN = 32;

        /// MOUSEEVENTF_LEFTUP -> 0x0004
        public const int MOUSEEVENTF_LEFTUP = 4;

        /// MOUSEEVENTF_LEFTDOWN -> 0x0002
        public const int MOUSEEVENTF_LEFTDOWN = 2;

        /// MOUSEEVENTF_ABSOLUTE -> 0x8000
        public const int MOUSEEVENTF_ABSOLUTE = 32768;

        /// MONO_FONT -> 8
        public const int MONO_FONT = 8;

        /// MONITOR_DEFAULTTOPRIMARY -> 0x00000001
        public const int MONITOR_DEFAULTTOPRIMARY = 1;

        /// MONITOR_DEFAULTTONULL -> 0x00000000
        public const int MONITOR_DEFAULTTONULL = 0;

        /// MONITOR_DEFAULTTONEAREST -> 0x00000002
        public const int MONITOR_DEFAULTTONEAREST = 2;

        /// MONITORINFOF_PRIMARY -> 0x00000001
        public const int MONITORINFOF_PRIMARY = 1;

        /// MOM_POSITIONCB -> MM_MOM_POSITIONCB
        public const int MOM_POSITIONCB = NativeConstants.MM_MOM_POSITIONCB;

        /// MOM_OPEN -> MM_MOM_OPEN
        public const int MOM_OPEN = NativeConstants.MM_MOM_OPEN;

        /// MOM_DONE -> MM_MOM_DONE
        public const int MOM_DONE = NativeConstants.MM_MOM_DONE;

        /// MOM_CLOSE -> MM_MOM_CLOSE
        public const int MOM_CLOSE = NativeConstants.MM_MOM_CLOSE;

        /// MOD_WIN -> 0x0008
        public const int MOD_WIN = 8;

        /// MOD_WAVETABLE -> 6
        public const int MOD_WAVETABLE = 6;

        /// MOD_SYNTH -> 2
        public const int MOD_SYNTH = 2;

        /// MOD_SWSYNTH -> 7
        public const int MOD_SWSYNTH = 7;

        /// MOD_SQSYNTH -> 3
        public const int MOD_SQSYNTH = 3;

        /// MOD_SHIFT -> 0x0004
        public const int MOD_SHIFT = 4;

        /// MOD_RIGHT -> 0x4000
        public const int MOD_RIGHT = 16384;

        /// MOD_ON_KEYUP -> 0x0800
        public const int MOD_ON_KEYUP = 2048;

        /// MOD_MIDIPORT -> 1
        public const int MOD_MIDIPORT = 1;

        /// MOD_MAPPER -> 5
        public const int MOD_MAPPER = 5;

        /// MOD_LEFT -> 0x8000
        public const int MOD_LEFT = 32768;

        /// MOD_IGNORE_ALL_MODIFIER -> 0x0400
        public const int MOD_IGNORE_ALL_MODIFIER = 1024;

        /// MOD_FMSYNTH -> 4
        public const int MOD_FMSYNTH = 4;

        /// MOD_CONTROL -> 0x0002
        public const int MOD_CONTROL = 2;

        /// MOD_ALT -> 0x0001
        public const int MOD_ALT = 1;

        /// ModifyMenu -> ModifyMenuW
        /// Error generating expression: Value ModifyMenuW is not resolved
        public const string ModifyMenu = "ModifyMenuW";

        /// MN_GETHMENU -> 0x01E1
        public const int MN_GETHMENU = 481;

        /// MNS_NOTIFYBYPOS -> 0x08000000
        public const int MNS_NOTIFYBYPOS = 134217728;

        /// MNS_NOCHECK -> 0x80000000
        public const int MNS_NOCHECK = -2147483648;

        /// MNS_MODELESS -> 0x40000000
        public const int MNS_MODELESS = 1073741824;

        /// MNS_DRAGDROP -> 0x20000000
        public const int MNS_DRAGDROP = 536870912;

        /// MNS_CHECKORBMP -> 0x04000000
        public const int MNS_CHECKORBMP = 67108864;

        /// MNS_AUTODISMISS -> 0x10000000
        public const int MNS_AUTODISMISS = 268435456;

        /// MNGO_NOINTERFACE -> 0x00000000
        public const int MNGO_NOINTERFACE = 0;

        /// MNGO_NOERROR -> 0x00000001
        public const int MNGO_NOERROR = 1;

        /// MNGOF_TOPGAP -> 0x00000001
        public const int MNGOF_TOPGAP = 1;

        /// MNGOF_BOTTOMGAP -> 0x00000002
        public const int MNGOF_BOTTOMGAP = 2;

        /// MND_ENDMENU -> 1
        public const int MND_ENDMENU = 1;

        /// MND_CONTINUE -> 0
        public const int MND_CONTINUE = 0;

        /// MNC_SELECT -> 3
        public const int MNC_SELECT = 3;

        /// MNC_IGNORE -> 0
        public const int MNC_IGNORE = 0;

        /// MNC_EXECUTE -> 2
        public const int MNC_EXECUTE = 2;

        /// MNC_CLOSE -> 1
        public const int MNC_CLOSE = 1;

        /// MM_WOM_OPEN -> 0x3BB
        public const int MM_WOM_OPEN = 955;

        /// MM_WOM_DONE -> 0x3BD
        public const int MM_WOM_DONE = 957;

        /// MM_WOM_CLOSE -> 0x3BC
        public const int MM_WOM_CLOSE = 956;

        /// MM_WIM_OPEN -> 0x3BE
        public const int MM_WIM_OPEN = 958;

        /// MM_WIM_DATA -> 0x3C0
        public const int MM_WIM_DATA = 960;

        /// MM_WIM_CLOSE -> 0x3BF
        public const int MM_WIM_CLOSE = 959;

        /// MM_TWIPS -> 6
        public const int MM_TWIPS = 6;

        /// MM_TEXT -> 1
        public const int MM_TEXT = 1;

        /// MM_STREAM_OPEN -> 0x3D4
        public const int MM_STREAM_OPEN = 980;

        /// MM_STREAM_ERROR -> 0x3D7
        public const int MM_STREAM_ERROR = 983;

        /// MM_STREAM_DONE -> 0x3D6
        public const int MM_STREAM_DONE = 982;

        /// MM_STREAM_CLOSE -> 0x3D5
        public const int MM_STREAM_CLOSE = 981;

        /// MM_MOM_POSITIONCB -> 0x3CA
        public const int MM_MOM_POSITIONCB = 970;

        /// MM_MOM_OPEN -> 0x3C7
        public const int MM_MOM_OPEN = 967;

        /// MM_MOM_DONE -> 0x3C9
        public const int MM_MOM_DONE = 969;

        /// MM_MOM_CLOSE -> 0x3C8
        public const int MM_MOM_CLOSE = 968;

        /// MM_MIXM_LINE_CHANGE -> 0x3D0
        public const int MM_MIXM_LINE_CHANGE = 976;

        /// MM_MIXM_CONTROL_CHANGE -> 0x3D1
        public const int MM_MIXM_CONTROL_CHANGE = 977;

        /// MM_MIN -> MM_TEXT
        public const int MM_MIN = NativeConstants.MM_TEXT;

        /// MM_MIM_OPEN -> 0x3C1
        public const int MM_MIM_OPEN = 961;

        /// MM_MIM_MOREDATA -> 0x3CC
        public const int MM_MIM_MOREDATA = 972;

        /// MM_MIM_LONGERROR -> 0x3C6
        public const int MM_MIM_LONGERROR = 966;

        /// MM_MIM_LONGDATA -> 0x3C4
        public const int MM_MIM_LONGDATA = 964;

        /// MM_MIM_ERROR -> 0x3C5
        public const int MM_MIM_ERROR = 965;

        /// MM_MIM_DATA -> 0x3C3
        public const int MM_MIM_DATA = 963;

        /// MM_MIM_CLOSE -> 0x3C2
        public const int MM_MIM_CLOSE = 962;

        /// MM_MCISIGNAL -> 0x3CB
        public const int MM_MCISIGNAL = 971;

        /// MM_MCINOTIFY -> 0x3B9
        public const int MM_MCINOTIFY = 953;

        /// MM_MAX_NUMAXES -> 16
        public const int MM_MAX_NUMAXES = 16;

        /// MM_MAX_FIXEDSCALE -> MM_TWIPS
        public const int MM_MAX_FIXEDSCALE = NativeConstants.MM_TWIPS;

        /// MM_MAX_AXES_NAMELEN -> 16
        public const int MM_MAX_AXES_NAMELEN = 16;

        /// MM_MAX -> MM_ANISOTROPIC
        public const int MM_MAX = NativeConstants.MM_ANISOTROPIC;

        /// MM_LOMETRIC -> 2
        public const int MM_LOMETRIC = 2;

        /// MM_LOENGLISH -> 4
        public const int MM_LOENGLISH = 4;

        /// MM_JOY2ZMOVE -> 0x3A3
        public const int MM_JOY2ZMOVE = 931;

        /// MM_JOY2MOVE -> 0x3A1
        public const int MM_JOY2MOVE = 929;

        /// MM_JOY2BUTTONUP -> 0x3B8
        public const int MM_JOY2BUTTONUP = 952;

        /// MM_JOY2BUTTONDOWN -> 0x3B6
        public const int MM_JOY2BUTTONDOWN = 950;

        /// MM_JOY1ZMOVE -> 0x3A2
        public const int MM_JOY1ZMOVE = 930;

        /// MM_JOY1MOVE -> 0x3A0
        public const int MM_JOY1MOVE = 928;

        /// MM_JOY1BUTTONUP -> 0x3B7
        public const int MM_JOY1BUTTONUP = 951;

        /// MM_JOY1BUTTONDOWN -> 0x3B5
        public const int MM_JOY1BUTTONDOWN = 949;

        /// MM_ISOTROPIC -> 7
        public const int MM_ISOTROPIC = 7;

        /// MM_HIMETRIC -> 3
        public const int MM_HIMETRIC = 3;

        /// MM_HIENGLISH -> 5
        public const int MM_HIENGLISH = 5;

        /// MM_DRVM_OPEN -> 0x3D0
        public const int MM_DRVM_OPEN = 976;

        /// MM_DRVM_ERROR -> 0x3D3
        public const int MM_DRVM_ERROR = 979;

        /// MM_DRVM_DATA -> 0x3D2
        public const int MM_DRVM_DATA = 978;

        /// MM_DRVM_CLOSE -> 0x3D1
        public const int MM_DRVM_CLOSE = 977;

        /// MM_ANISOTROPIC -> 8
        public const int MM_ANISOTROPIC = 8;

        /// MMSYSERR_WRITEERROR -> (MMSYSERR_BASE + 17)
        public const int MMSYSERR_WRITEERROR = (NativeConstants.MMSYSERR_BASE + 17);

        /// MMSYSERR_VALNOTFOUND -> (MMSYSERR_BASE + 19)
        public const int MMSYSERR_VALNOTFOUND = (NativeConstants.MMSYSERR_BASE + 19);

        /// MMSYSERR_READERROR -> (MMSYSERR_BASE + 16)
        public const int MMSYSERR_READERROR = (NativeConstants.MMSYSERR_BASE + 16);

        /// MMSYSERR_NOTSUPPORTED -> (MMSYSERR_BASE + 8)
        public const int MMSYSERR_NOTSUPPORTED = (NativeConstants.MMSYSERR_BASE + 8);

        /// MMSYSERR_NOTENABLED -> (MMSYSERR_BASE + 3)
        public const int MMSYSERR_NOTENABLED = (NativeConstants.MMSYSERR_BASE + 3);

        /// MMSYSERR_NOMEM -> (MMSYSERR_BASE + 7)
        public const int MMSYSERR_NOMEM = (NativeConstants.MMSYSERR_BASE + 7);

        /// MMSYSERR_NOERROR -> 0
        public const int MMSYSERR_NOERROR = 0;

        /// MMSYSERR_NODRIVERCB -> (MMSYSERR_BASE + 20)
        public const int MMSYSERR_NODRIVERCB = (NativeConstants.MMSYSERR_BASE + 20);

        /// MMSYSERR_NODRIVER -> (MMSYSERR_BASE + 6)
        public const int MMSYSERR_NODRIVER = (NativeConstants.MMSYSERR_BASE + 6);

        /// MMSYSERR_MOREDATA -> (MMSYSERR_BASE + 21)
        public const int MMSYSERR_MOREDATA = (NativeConstants.MMSYSERR_BASE + 21);

        /// MMSYSERR_LASTERROR -> (MMSYSERR_BASE + 21)
        public const int MMSYSERR_LASTERROR = (NativeConstants.MMSYSERR_BASE + 21);

        /// MMSYSERR_KEYNOTFOUND -> (MMSYSERR_BASE + 15)
        public const int MMSYSERR_KEYNOTFOUND = (NativeConstants.MMSYSERR_BASE + 15);

        /// MMSYSERR_INVALPARAM -> (MMSYSERR_BASE + 11)
        public const int MMSYSERR_INVALPARAM = (NativeConstants.MMSYSERR_BASE + 11);

        /// MMSYSERR_INVALIDALIAS -> (MMSYSERR_BASE + 13)
        public const int MMSYSERR_INVALIDALIAS = (NativeConstants.MMSYSERR_BASE + 13);

        /// MMSYSERR_INVALHANDLE -> (MMSYSERR_BASE + 5)
        public const int MMSYSERR_INVALHANDLE = (NativeConstants.MMSYSERR_BASE + 5);

        /// MMSYSERR_INVALFLAG -> (MMSYSERR_BASE + 10)
        public const int MMSYSERR_INVALFLAG = (NativeConstants.MMSYSERR_BASE + 10);

        /// MMSYSERR_HANDLEBUSY -> (MMSYSERR_BASE + 12)
        public const int MMSYSERR_HANDLEBUSY = (NativeConstants.MMSYSERR_BASE + 12);

        /// MMSYSERR_ERROR -> (MMSYSERR_BASE + 1)
        public const int MMSYSERR_ERROR = (NativeConstants.MMSYSERR_BASE + 1);

        /// MMSYSERR_DELETEERROR -> (MMSYSERR_BASE + 18)
        public const int MMSYSERR_DELETEERROR = (NativeConstants.MMSYSERR_BASE + 18);

        /// MMSYSERR_BASE -> 0
        public const int MMSYSERR_BASE = 0;

        /// MMSYSERR_BADERRNUM -> (MMSYSERR_BASE + 9)
        public const int MMSYSERR_BADERRNUM = (NativeConstants.MMSYSERR_BASE + 9);

        /// MMSYSERR_BADDEVICEID -> (MMSYSERR_BASE + 2)
        public const int MMSYSERR_BADDEVICEID = (NativeConstants.MMSYSERR_BASE + 2);

        /// MMSYSERR_BADDB -> (MMSYSERR_BASE + 14)
        public const int MMSYSERR_BADDB = (NativeConstants.MMSYSERR_BASE + 14);

        /// MMSYSERR_ALLOCATED -> (MMSYSERR_BASE + 4)
        public const int MMSYSERR_ALLOCATED = (NativeConstants.MMSYSERR_BASE + 4);

        /// MMIO_WRITE -> 0x00000001
        public const int MMIO_WRITE = 1;

        /// MMIO_UNICODEPROC -> 0x01000000
        public const int MMIO_UNICODEPROC = 16777216;

        /// MMIO_TOUPPER -> 0x0010
        public const int MMIO_TOUPPER = 16;

        /// MMIO_SHAREMODE -> 0x00000070
        public const int MMIO_SHAREMODE = 112;

        /// MMIO_RWMODE -> 0x00000003
        public const int MMIO_RWMODE = 3;

        /// MMIO_REMOVEPROC -> 0x00020000
        public const int MMIO_REMOVEPROC = 131072;

        /// MMIO_READWRITE -> 0x00000002
        public const int MMIO_READWRITE = 2;

        /// MMIO_READ -> 0x00000000
        public const int MMIO_READ = 0;

        /// MMIO_PARSE -> 0x00000100
        public const int MMIO_PARSE = 256;

        /// MMIO_INSTALLPROC -> 0x00010000
        public const int MMIO_INSTALLPROC = 65536;

        /// MMIO_GLOBALPROC -> 0x10000000
        public const int MMIO_GLOBALPROC = 268435456;

        /// MMIO_GETTEMP -> 0x00020000
        public const int MMIO_GETTEMP = 131072;

        /// MMIO_FINDRIFF -> 0x0020
        public const int MMIO_FINDRIFF = 32;

        /// MMIO_FINDPROC -> 0x00040000
        public const int MMIO_FINDPROC = 262144;

        /// MMIO_FINDLIST -> 0x0040
        public const int MMIO_FINDLIST = 64;

        /// MMIO_FINDCHUNK -> 0x0010
        public const int MMIO_FINDCHUNK = 16;

        /// MMIO_FHOPEN -> 0x0010
        public const int MMIO_FHOPEN = 16;

        /// MMIO_EXIST -> 0x00004000
        public const int MMIO_EXIST = 16384;

        /// MMIO_EXCLUSIVE -> 0x00000010
        public const int MMIO_EXCLUSIVE = 16;

        /// MMIO_EMPTYBUF -> 0x0010
        public const int MMIO_EMPTYBUF = 16;

        /// MMIO_DIRTY -> 0x10000000
        public const int MMIO_DIRTY = 268435456;

        /// MMIO_DENYWRITE -> 0x00000020
        public const int MMIO_DENYWRITE = 32;

        /// MMIO_DENYREAD -> 0x00000030
        public const int MMIO_DENYREAD = 48;

        /// MMIO_DENYNONE -> 0x00000040
        public const int MMIO_DENYNONE = 64;

        /// MMIO_DELETE -> 0x00000200
        public const int MMIO_DELETE = 512;

        /// MMIO_DEFAULTBUFFER -> 8192
        public const int MMIO_DEFAULTBUFFER = 8192;

        /// MMIO_CREATERIFF -> 0x0020
        public const int MMIO_CREATERIFF = 32;

        /// MMIO_CREATELIST -> 0x0040
        public const int MMIO_CREATELIST = 64;

        /// MMIO_CREATE -> 0x00001000
        public const int MMIO_CREATE = 4096;

        /// MMIO_COMPAT -> 0x00000000
        public const int MMIO_COMPAT = 0;

        /// MMIO_ALLOCBUF -> 0x00010000
        public const int MMIO_ALLOCBUF = 65536;

        /// mmioStringToFOURCC -> mmioStringToFOURCCW
        /// Error generating expression: Value mmioStringToFOURCCW is not resolved
        public const string mmioStringToFOURCC = "mmioStringToFOURCCW";

        /// mmioRename -> mmioRenameW
        /// Error generating expression: Value mmioRenameW is not resolved
        public const string mmioRename = "mmioRenameW";

        /// mmioOpen -> mmioOpenW
        /// Error generating expression: Value mmioOpenW is not resolved
        public const string mmioOpen = "mmioOpenW";

        /// MMIOM_WRITEFLUSH -> 5
        public const int MMIOM_WRITEFLUSH = 5;

        /// MMIOM_WRITE -> MMIO_WRITE
        public const int MMIOM_WRITE = NativeConstants.MMIO_WRITE;

        /// MMIOM_USER -> 0x8000
        public const int MMIOM_USER = 32768;

        /// MMIOM_SEEK -> 2
        public const int MMIOM_SEEK = 2;

        /// MMIOM_RENAME -> 6
        public const int MMIOM_RENAME = 6;

        /// MMIOM_READ -> MMIO_READ
        public const int MMIOM_READ = NativeConstants.MMIO_READ;

        /// MMIOM_OPEN -> 3
        public const int MMIOM_OPEN = 3;

        /// MMIOM_CLOSE -> 4
        public const int MMIOM_CLOSE = 4;

        /// mmioInstallIOProc -> mmioInstallIOProcW
        /// Error generating expression: Value mmioInstallIOProcW is not resolved
        public const string mmioInstallIOProc = "mmioInstallIOProcW";

        /// MMIOERR_UNBUFFERED -> (MMIOERR_BASE + 10)
        public const int MMIOERR_UNBUFFERED = (NativeConstants.MMIOERR_BASE + 10);

        /// MMIOERR_TOOMANYOPENFILES -> (MMIOERR_BASE + 15)
        public const int MMIOERR_TOOMANYOPENFILES = (NativeConstants.MMIOERR_BASE + 15);

        /// MMIOERR_SHARINGVIOLATION -> (MMIOERR_BASE + 13)
        public const int MMIOERR_SHARINGVIOLATION = (NativeConstants.MMIOERR_BASE + 13);

        /// MMIOERR_PATHNOTFOUND -> (MMIOERR_BASE + 11)
        public const int MMIOERR_PATHNOTFOUND = (NativeConstants.MMIOERR_BASE + 11);

        /// MMIOERR_OUTOFMEMORY -> (MMIOERR_BASE + 2)
        public const int MMIOERR_OUTOFMEMORY = (NativeConstants.MMIOERR_BASE + 2);

        /// MMIOERR_NETWORKERROR -> (MMIOERR_BASE + 14)
        public const int MMIOERR_NETWORKERROR = (NativeConstants.MMIOERR_BASE + 14);

        /// MMIOERR_INVALIDFILE -> (MMIOERR_BASE + 16)
        public const int MMIOERR_INVALIDFILE = (NativeConstants.MMIOERR_BASE + 16);

        /// MMIOERR_FILENOTFOUND -> (MMIOERR_BASE + 1)
        public const int MMIOERR_FILENOTFOUND = (NativeConstants.MMIOERR_BASE + 1);

        /// MMIOERR_CHUNKNOTFOUND -> (MMIOERR_BASE + 9)
        public const int MMIOERR_CHUNKNOTFOUND = (NativeConstants.MMIOERR_BASE + 9);

        /// MMIOERR_CANNOTWRITE -> (MMIOERR_BASE + 6)
        public const int MMIOERR_CANNOTWRITE = (NativeConstants.MMIOERR_BASE + 6);

        /// MMIOERR_CANNOTSEEK -> (MMIOERR_BASE + 7)
        public const int MMIOERR_CANNOTSEEK = (NativeConstants.MMIOERR_BASE + 7);

        /// MMIOERR_CANNOTREAD -> (MMIOERR_BASE + 5)
        public const int MMIOERR_CANNOTREAD = (NativeConstants.MMIOERR_BASE + 5);

        /// MMIOERR_CANNOTOPEN -> (MMIOERR_BASE + 3)
        public const int MMIOERR_CANNOTOPEN = (NativeConstants.MMIOERR_BASE + 3);

        /// MMIOERR_CANNOTEXPAND -> (MMIOERR_BASE + 8)
        public const int MMIOERR_CANNOTEXPAND = (NativeConstants.MMIOERR_BASE + 8);

        /// MMIOERR_CANNOTCLOSE -> (MMIOERR_BASE + 4)
        public const int MMIOERR_CANNOTCLOSE = (NativeConstants.MMIOERR_BASE + 4);

        /// MMIOERR_BASE -> 256
        public const int MMIOERR_BASE = 256;

        /// MMIOERR_ACCESSDENIED -> (MMIOERR_BASE + 12)
        public const int MMIOERR_ACCESSDENIED = (NativeConstants.MMIOERR_BASE + 12);

        /// MK_XBUTTON2 -> 0x0040
        public const int MK_XBUTTON2 = 64;

        /// MK_XBUTTON1 -> 0x0020
        public const int MK_XBUTTON1 = 32;

        /// MK_S_LAST -> 0x000401EFL
        public const int MK_S_LAST = 262639;

        /// MK_S_FIRST -> 0x000401E0L
        public const int MK_S_FIRST = 262624;

        /// MK_SHIFT -> 0x0004
        public const int MK_SHIFT = 4;

        /// MK_RBUTTON -> 0x0002
        public const int MK_RBUTTON = 2;

        /// MK_MBUTTON -> 0x0010
        public const int MK_MBUTTON = 16;

        /// MK_LBUTTON -> 0x0001
        public const int MK_LBUTTON = 1;

        /// MK_E_LAST -> 0x800401EFL
        public const int MK_E_LAST = -2147221009;

        /// MK_E_FIRST -> 0x800401E0L
        public const int MK_E_FIRST = -2147221024;

        /// MK_CONTROL -> 0x0008
        public const int MK_CONTROL = 8;

        /// MK_ALT -> ( 0x20 )
        public const int MK_ALT = 32;

        /// MKSYS_URLMONIKER -> 6
        public const int MKSYS_URLMONIKER = 6;

        /// MKF_RIGHTBUTTONSEL -> 0x20000000
        public const int MKF_RIGHTBUTTONSEL = 536870912;

        /// MKF_RIGHTBUTTONDOWN -> 0x02000000
        public const int MKF_RIGHTBUTTONDOWN = 33554432;

        /// MKF_REPLACENUMBERS -> 0x00000080
        public const int MKF_REPLACENUMBERS = 128;

        /// MKF_MOUSEMODE -> 0x80000000
        public const int MKF_MOUSEMODE = -2147483648;

        /// MKF_MOUSEKEYSON -> 0x00000001
        public const int MKF_MOUSEKEYSON = 1;

        /// MKF_MODIFIERS -> 0x00000040
        public const int MKF_MODIFIERS = 64;

        /// MKF_LEFTBUTTONSEL -> 0x10000000
        public const int MKF_LEFTBUTTONSEL = 268435456;

        /// MKF_LEFTBUTTONDOWN -> 0x01000000
        public const int MKF_LEFTBUTTONDOWN = 16777216;

        /// MKF_INDICATOR -> 0x00000020
        public const int MKF_INDICATOR = 32;

        /// MKF_HOTKEYSOUND -> 0x00000010
        public const int MKF_HOTKEYSOUND = 16;

        /// MKF_HOTKEYACTIVE -> 0x00000004
        public const int MKF_HOTKEYACTIVE = 4;

        /// MKF_CONFIRMHOTKEY -> 0x00000008
        public const int MKF_CONFIRMHOTKEY = 8;

        /// MKF_AVAILABLE -> 0x00000002
        public const int MKF_AVAILABLE = 2;

        /// MIXER_SHORT_NAME_CHARS -> 16
        public const int MIXER_SHORT_NAME_CHARS = 16;

        /// MIXER_SETCONTROLDETAILSF_VALUE -> 0x00000000L
        public const int MIXER_SETCONTROLDETAILSF_VALUE = 0;

        /// MIXER_SETCONTROLDETAILSF_QUERYMASK -> 0x0000000FL
        public const int MIXER_SETCONTROLDETAILSF_QUERYMASK = 15;

        /// MIXER_SETCONTROLDETAILSF_CUSTOM -> 0x00000001L
        public const int MIXER_SETCONTROLDETAILSF_CUSTOM = 1;

        /// MIXER_OBJECTF_WAVEOUT -> 0x10000000L
        public const int MIXER_OBJECTF_WAVEOUT = 268435456;

        /// MIXER_OBJECTF_WAVEIN -> 0x20000000L
        public const int MIXER_OBJECTF_WAVEIN = 536870912;

        /// MIXER_OBJECTF_MIXER -> 0x00000000L
        public const int MIXER_OBJECTF_MIXER = 0;

        /// MIXER_OBJECTF_MIDIOUT -> 0x30000000L
        public const int MIXER_OBJECTF_MIDIOUT = 805306368;

        /// MIXER_OBJECTF_MIDIIN -> 0x40000000L
        public const int MIXER_OBJECTF_MIDIIN = 1073741824;

        /// MIXER_OBJECTF_HWAVEOUT -> (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEOUT)
        public const int MIXER_OBJECTF_HWAVEOUT = (NativeConstants.MIXER_OBJECTF_HANDLE | NativeConstants.MIXER_OBJECTF_WAVEOUT);

        /// MIXER_OBJECTF_HWAVEIN -> (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEIN)
        public const int MIXER_OBJECTF_HWAVEIN = (NativeConstants.MIXER_OBJECTF_HANDLE | NativeConstants.MIXER_OBJECTF_WAVEIN);

        /// MIXER_OBJECTF_HMIXER -> (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIXER)
        public const int MIXER_OBJECTF_HMIXER = (NativeConstants.MIXER_OBJECTF_HANDLE | NativeConstants.MIXER_OBJECTF_MIXER);

        /// MIXER_OBJECTF_HMIDIOUT -> (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIOUT)
        public const int MIXER_OBJECTF_HMIDIOUT = (NativeConstants.MIXER_OBJECTF_HANDLE | NativeConstants.MIXER_OBJECTF_MIDIOUT);

        /// MIXER_OBJECTF_HMIDIIN -> (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIIN)
        public const int MIXER_OBJECTF_HMIDIIN = (NativeConstants.MIXER_OBJECTF_HANDLE | NativeConstants.MIXER_OBJECTF_MIDIIN);

        /// MIXER_OBJECTF_HANDLE -> 0x80000000L
        public const int MIXER_OBJECTF_HANDLE = -2147483648;

        /// MIXER_OBJECTF_AUX -> 0x50000000L
        public const int MIXER_OBJECTF_AUX = 1342177280;

        /// MIXER_LONG_NAME_CHARS -> 64
        public const int MIXER_LONG_NAME_CHARS = 64;

        /// MIXER_GETLINEINFOF_TARGETTYPE -> 0x00000004L
        public const int MIXER_GETLINEINFOF_TARGETTYPE = 4;

        /// MIXER_GETLINEINFOF_SOURCE -> 0x00000001L
        public const int MIXER_GETLINEINFOF_SOURCE = 1;

        /// MIXER_GETLINEINFOF_QUERYMASK -> 0x0000000FL
        public const int MIXER_GETLINEINFOF_QUERYMASK = 15;

        /// MIXER_GETLINEINFOF_LINEID -> 0x00000002L
        public const int MIXER_GETLINEINFOF_LINEID = 2;

        /// MIXER_GETLINEINFOF_DESTINATION -> 0x00000000L
        public const int MIXER_GETLINEINFOF_DESTINATION = 0;

        /// MIXER_GETLINEINFOF_COMPONENTTYPE -> 0x00000003L
        public const int MIXER_GETLINEINFOF_COMPONENTTYPE = 3;

        /// MIXER_GETLINECONTROLSF_QUERYMASK -> 0x0000000FL
        public const int MIXER_GETLINECONTROLSF_QUERYMASK = 15;

        /// MIXER_GETLINECONTROLSF_ONEBYTYPE -> 0x00000002L
        public const int MIXER_GETLINECONTROLSF_ONEBYTYPE = 2;

        /// MIXER_GETLINECONTROLSF_ONEBYID -> 0x00000001L
        public const int MIXER_GETLINECONTROLSF_ONEBYID = 1;

        /// MIXER_GETLINECONTROLSF_ALL -> 0x00000000L
        public const int MIXER_GETLINECONTROLSF_ALL = 0;

        /// MIXER_GETCONTROLDETAILSF_VALUE -> 0x00000000L
        public const int MIXER_GETCONTROLDETAILSF_VALUE = 0;

        /// MIXER_GETCONTROLDETAILSF_QUERYMASK -> 0x0000000FL
        public const int MIXER_GETCONTROLDETAILSF_QUERYMASK = 15;

        /// MIXER_GETCONTROLDETAILSF_LISTTEXT -> 0x00000001L
        public const int MIXER_GETCONTROLDETAILSF_LISTTEXT = 1;

        /// MIXERR_LASTERROR -> (MIXERR_BASE + 2)
        public const int MIXERR_LASTERROR = (NativeConstants.MIXERR_BASE + 2);

        /// MIXERR_INVALVALUE -> (MIXERR_BASE + 2)
        public const int MIXERR_INVALVALUE = (NativeConstants.MIXERR_BASE + 2);

        /// MIXERR_INVALLINE -> (MIXERR_BASE + 0)
        public const int MIXERR_INVALLINE = (NativeConstants.MIXERR_BASE + 0);

        /// MIXERR_INVALCONTROL -> (MIXERR_BASE + 1)
        public const int MIXERR_INVALCONTROL = (NativeConstants.MIXERR_BASE + 1);

        /// MIXERR_BASE -> 1024
        public const int MIXERR_BASE = 1024;

        /// MIXERLINE_TARGETTYPE_WAVEOUT -> 1
        public const int MIXERLINE_TARGETTYPE_WAVEOUT = 1;

        /// MIXERLINE_TARGETTYPE_WAVEIN -> 2
        public const int MIXERLINE_TARGETTYPE_WAVEIN = 2;

        /// MIXERLINE_TARGETTYPE_UNDEFINED -> 0
        public const int MIXERLINE_TARGETTYPE_UNDEFINED = 0;

        /// MIXERLINE_TARGETTYPE_MIDIOUT -> 3
        public const int MIXERLINE_TARGETTYPE_MIDIOUT = 3;

        /// MIXERLINE_TARGETTYPE_MIDIIN -> 4
        public const int MIXERLINE_TARGETTYPE_MIDIIN = 4;

        /// MIXERLINE_TARGETTYPE_AUX -> 5
        public const int MIXERLINE_TARGETTYPE_AUX = 5;

        /// MIXERLINE_LINEF_SOURCE -> 0x80000000L
        public const int MIXERLINE_LINEF_SOURCE = -2147483648;

        /// MIXERLINE_LINEF_DISCONNECTED -> 0x00008000L
        public const int MIXERLINE_LINEF_DISCONNECTED = 32768;

        /// MIXERLINE_LINEF_ACTIVE -> 0x00000001L
        public const int MIXERLINE_LINEF_ACTIVE = 1;

        /// MIXERLINE_COMPONENTTYPE_SRC_WAVEOUT -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 8)
        public const int MIXERLINE_COMPONENTTYPE_SRC_WAVEOUT = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 8);

        /// MIXERLINE_COMPONENTTYPE_SRC_UNDEFINED -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 0)
        public const int MIXERLINE_COMPONENTTYPE_SRC_UNDEFINED = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 0);

        /// MIXERLINE_COMPONENTTYPE_SRC_TELEPHONE -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 6)
        public const int MIXERLINE_COMPONENTTYPE_SRC_TELEPHONE = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 6);

        /// MIXERLINE_COMPONENTTYPE_SRC_SYNTHESIZER -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 4)
        public const int MIXERLINE_COMPONENTTYPE_SRC_SYNTHESIZER = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 4);

        /// MIXERLINE_COMPONENTTYPE_SRC_PCSPEAKER -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 7)
        public const int MIXERLINE_COMPONENTTYPE_SRC_PCSPEAKER = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 7);

        /// MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 3)
        public const int MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 3);

        /// MIXERLINE_COMPONENTTYPE_SRC_LINE -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 2)
        public const int MIXERLINE_COMPONENTTYPE_SRC_LINE = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 2);

        /// MIXERLINE_COMPONENTTYPE_SRC_LAST -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10)
        public const int MIXERLINE_COMPONENTTYPE_SRC_LAST = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10);

        /// MIXERLINE_COMPONENTTYPE_SRC_FIRST -> 0x00001000L
        public const int MIXERLINE_COMPONENTTYPE_SRC_FIRST = 4096;

        /// MIXERLINE_COMPONENTTYPE_SRC_DIGITAL -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 1)
        public const int MIXERLINE_COMPONENTTYPE_SRC_DIGITAL = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 1);

        /// MIXERLINE_COMPONENTTYPE_SRC_COMPACTDISC -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 5)
        public const int MIXERLINE_COMPONENTTYPE_SRC_COMPACTDISC = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 5);

        /// MIXERLINE_COMPONENTTYPE_SRC_AUXILIARY -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 9)
        public const int MIXERLINE_COMPONENTTYPE_SRC_AUXILIARY = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 9);

        /// MIXERLINE_COMPONENTTYPE_SRC_ANALOG -> (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10)
        public const int MIXERLINE_COMPONENTTYPE_SRC_ANALOG = (NativeConstants.MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10);

        /// MIXERLINE_COMPONENTTYPE_DST_WAVEIN -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 7)
        public const int MIXERLINE_COMPONENTTYPE_DST_WAVEIN = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 7);

        /// MIXERLINE_COMPONENTTYPE_DST_VOICEIN -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8)
        public const int MIXERLINE_COMPONENTTYPE_DST_VOICEIN = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 8);

        /// MIXERLINE_COMPONENTTYPE_DST_UNDEFINED -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 0)
        public const int MIXERLINE_COMPONENTTYPE_DST_UNDEFINED = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 0);

        /// MIXERLINE_COMPONENTTYPE_DST_TELEPHONE -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 6)
        public const int MIXERLINE_COMPONENTTYPE_DST_TELEPHONE = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 6);

        /// MIXERLINE_COMPONENTTYPE_DST_SPEAKERS -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 4)
        public const int MIXERLINE_COMPONENTTYPE_DST_SPEAKERS = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 4);

        /// MIXERLINE_COMPONENTTYPE_DST_MONITOR -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 3)
        public const int MIXERLINE_COMPONENTTYPE_DST_MONITOR = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 3);

        /// MIXERLINE_COMPONENTTYPE_DST_LINE -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 2)
        public const int MIXERLINE_COMPONENTTYPE_DST_LINE = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 2);

        /// MIXERLINE_COMPONENTTYPE_DST_LAST -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8)
        public const int MIXERLINE_COMPONENTTYPE_DST_LAST = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 8);

        /// MIXERLINE_COMPONENTTYPE_DST_HEADPHONES -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 5)
        public const int MIXERLINE_COMPONENTTYPE_DST_HEADPHONES = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 5);

        /// MIXERLINE_COMPONENTTYPE_DST_FIRST -> 0x00000000L
        public const int MIXERLINE_COMPONENTTYPE_DST_FIRST = 0;

        /// MIXERLINE_COMPONENTTYPE_DST_DIGITAL -> (MIXERLINE_COMPONENTTYPE_DST_FIRST + 1)
        public const int MIXERLINE_COMPONENTTYPE_DST_DIGITAL = (NativeConstants.MIXERLINE_COMPONENTTYPE_DST_FIRST + 1);

        /// mixerGetLineInfo -> mixerGetLineInfoW
        /// Error generating expression: Value mixerGetLineInfoW is not resolved
        public const string mixerGetLineInfo = "mixerGetLineInfoW";

        /// mixerGetLineControls -> mixerGetLineControlsW
        /// Error generating expression: Value mixerGetLineControlsW is not resolved
        public const string mixerGetLineControls = "mixerGetLineControlsW";

        /// mixerGetDevCaps -> mixerGetDevCapsW
        /// Error generating expression: Value mixerGetDevCapsW is not resolved
        public const string mixerGetDevCaps = "mixerGetDevCapsW";

        /// mixerGetControlDetails -> mixerGetControlDetailsW
        /// Error generating expression: Value mixerGetControlDetailsW is not resolved
        public const string mixerGetControlDetails = "mixerGetControlDetailsW";

        /// MIXERCONTROL_CT_UNITS_UNSIGNED -> 0x00030000L
        public const int MIXERCONTROL_CT_UNITS_UNSIGNED = 196608;

        /// MIXERCONTROL_CT_UNITS_SIGNED -> 0x00020000L
        public const int MIXERCONTROL_CT_UNITS_SIGNED = 131072;

        /// MIXERCONTROL_CT_UNITS_PERCENT -> 0x00050000L
        public const int MIXERCONTROL_CT_UNITS_PERCENT = 327680;

        /// MIXERCONTROL_CT_UNITS_MASK -> 0x00FF0000L
        public const int MIXERCONTROL_CT_UNITS_MASK = 16711680;

        /// MIXERCONTROL_CT_UNITS_DECIBELS -> 0x00040000L
        public const int MIXERCONTROL_CT_UNITS_DECIBELS = 262144;

        /// MIXERCONTROL_CT_UNITS_CUSTOM -> 0x00000000L
        public const int MIXERCONTROL_CT_UNITS_CUSTOM = 0;

        /// MIXERCONTROL_CT_UNITS_BOOLEAN -> 0x00010000L
        public const int MIXERCONTROL_CT_UNITS_BOOLEAN = 65536;

        /// MIXERCONTROL_CT_SUBCLASS_MASK -> 0x0F000000L
        public const int MIXERCONTROL_CT_SUBCLASS_MASK = 251658240;

        /// MIXERCONTROL_CT_SC_TIME_MILLISECS -> 0x01000000L
        public const int MIXERCONTROL_CT_SC_TIME_MILLISECS = 16777216;

        /// MIXERCONTROL_CT_SC_TIME_MICROSECS -> 0x00000000L
        public const int MIXERCONTROL_CT_SC_TIME_MICROSECS = 0;

        /// MIXERCONTROL_CT_SC_SWITCH_BUTTON -> 0x01000000L
        public const int MIXERCONTROL_CT_SC_SWITCH_BUTTON = 16777216;

        /// MIXERCONTROL_CT_SC_SWITCH_BOOLEAN -> 0x00000000L
        public const int MIXERCONTROL_CT_SC_SWITCH_BOOLEAN = 0;

        /// MIXERCONTROL_CT_SC_METER_POLLED -> 0x00000000L
        public const int MIXERCONTROL_CT_SC_METER_POLLED = 0;

        /// MIXERCONTROL_CT_SC_LIST_SINGLE -> 0x00000000L
        public const int MIXERCONTROL_CT_SC_LIST_SINGLE = 0;

        /// MIXERCONTROL_CT_SC_LIST_MULTIPLE -> 0x01000000L
        public const int MIXERCONTROL_CT_SC_LIST_MULTIPLE = 16777216;

        /// MIXERCONTROL_CT_CLASS_TIME -> 0x60000000L
        public const int MIXERCONTROL_CT_CLASS_TIME = 1610612736;

        /// MIXERCONTROL_CT_CLASS_SWITCH -> 0x20000000L
        public const int MIXERCONTROL_CT_CLASS_SWITCH = 536870912;

        /// MIXERCONTROL_CT_CLASS_SLIDER -> 0x40000000L
        public const int MIXERCONTROL_CT_CLASS_SLIDER = 1073741824;

        /// MIXERCONTROL_CT_CLASS_NUMBER -> 0x30000000L
        public const int MIXERCONTROL_CT_CLASS_NUMBER = 805306368;

        /// MIXERCONTROL_CT_CLASS_METER -> 0x10000000L
        public const int MIXERCONTROL_CT_CLASS_METER = 268435456;

        /// MIXERCONTROL_CT_CLASS_MASK -> 0xF0000000L
        public const int MIXERCONTROL_CT_CLASS_MASK = -268435456;

        /// MIXERCONTROL_CT_CLASS_LIST -> 0x70000000L
        public const int MIXERCONTROL_CT_CLASS_LIST = 1879048192;

        /// MIXERCONTROL_CT_CLASS_FADER -> 0x50000000L
        public const int MIXERCONTROL_CT_CLASS_FADER = 1342177280;

        /// MIXERCONTROL_CT_CLASS_CUSTOM -> 0x00000000L
        public const int MIXERCONTROL_CT_CLASS_CUSTOM = 0;

        /// MIXERCONTROL_CONTROLTYPE_VOLUME -> (MIXERCONTROL_CONTROLTYPE_FADER + 1)
        public const int MIXERCONTROL_CONTROLTYPE_VOLUME = (NativeConstants.MIXERCONTROL_CONTROLTYPE_FADER + 1);

        /// MIXERCONTROL_CONTROLTYPE_UNSIGNEDMETER -> (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_UNSIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_UNSIGNEDMETER = (NativeConstants.MIXERCONTROL_CT_CLASS_METER
                    | (NativeConstants.MIXERCONTROL_CT_SC_METER_POLLED | NativeConstants.MIXERCONTROL_CT_UNITS_UNSIGNED));

        /// MIXERCONTROL_CONTROLTYPE_UNSIGNED -> (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_UNSIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_UNSIGNED = (NativeConstants.MIXERCONTROL_CT_CLASS_NUMBER | NativeConstants.MIXERCONTROL_CT_UNITS_UNSIGNED);

        /// MIXERCONTROL_CONTROLTYPE_TREBLE -> (MIXERCONTROL_CONTROLTYPE_FADER + 3)
        public const int MIXERCONTROL_CONTROLTYPE_TREBLE = (NativeConstants.MIXERCONTROL_CONTROLTYPE_FADER + 3);

        /// MIXERCONTROL_CONTROLTYPE_STEREOENH -> (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 5)
        public const int MIXERCONTROL_CONTROLTYPE_STEREOENH = (NativeConstants.MIXERCONTROL_CONTROLTYPE_BOOLEAN + 5);

        /// MIXERCONTROL_CONTROLTYPE_SLIDER -> (MIXERCONTROL_CT_CLASS_SLIDER | MIXERCONTROL_CT_UNITS_SIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_SLIDER = (NativeConstants.MIXERCONTROL_CT_CLASS_SLIDER | NativeConstants.MIXERCONTROL_CT_UNITS_SIGNED);

        /// MIXERCONTROL_CONTROLTYPE_SINGLESELECT -> (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_SINGLE | MIXERCONTROL_CT_UNITS_BOOLEAN)
        public const int MIXERCONTROL_CONTROLTYPE_SINGLESELECT = (NativeConstants.MIXERCONTROL_CT_CLASS_LIST
                    | (NativeConstants.MIXERCONTROL_CT_SC_LIST_SINGLE | NativeConstants.MIXERCONTROL_CT_UNITS_BOOLEAN));

        /// MIXERCONTROL_CONTROLTYPE_SIGNEDMETER -> (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_SIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_SIGNEDMETER = (NativeConstants.MIXERCONTROL_CT_CLASS_METER
                    | (NativeConstants.MIXERCONTROL_CT_SC_METER_POLLED | NativeConstants.MIXERCONTROL_CT_UNITS_SIGNED));

        /// MIXERCONTROL_CONTROLTYPE_SIGNED -> (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_SIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_SIGNED = (NativeConstants.MIXERCONTROL_CT_CLASS_NUMBER | NativeConstants.MIXERCONTROL_CT_UNITS_SIGNED);

        /// MIXERCONTROL_CONTROLTYPE_QSOUNDPAN -> (MIXERCONTROL_CONTROLTYPE_SLIDER + 2)
        public const int MIXERCONTROL_CONTROLTYPE_QSOUNDPAN = (NativeConstants.MIXERCONTROL_CONTROLTYPE_SLIDER + 2);

        /// MIXERCONTROL_CONTROLTYPE_PERCENT -> (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_PERCENT)
        public const int MIXERCONTROL_CONTROLTYPE_PERCENT = (NativeConstants.MIXERCONTROL_CT_CLASS_NUMBER | NativeConstants.MIXERCONTROL_CT_UNITS_PERCENT);

        /// MIXERCONTROL_CONTROLTYPE_PEAKMETER -> (MIXERCONTROL_CONTROLTYPE_SIGNEDMETER + 1)
        public const int MIXERCONTROL_CONTROLTYPE_PEAKMETER = (NativeConstants.MIXERCONTROL_CONTROLTYPE_SIGNEDMETER + 1);

        /// MIXERCONTROL_CONTROLTYPE_PAN -> (MIXERCONTROL_CONTROLTYPE_SLIDER + 1)
        public const int MIXERCONTROL_CONTROLTYPE_PAN = (NativeConstants.MIXERCONTROL_CONTROLTYPE_SLIDER + 1);

        /// MIXERCONTROL_CONTROLTYPE_ONOFF -> (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 1)
        public const int MIXERCONTROL_CONTROLTYPE_ONOFF = (NativeConstants.MIXERCONTROL_CONTROLTYPE_BOOLEAN + 1);

        /// MIXERCONTROL_CONTROLTYPE_MUX -> (MIXERCONTROL_CONTROLTYPE_SINGLESELECT + 1)
        public const int MIXERCONTROL_CONTROLTYPE_MUX = (NativeConstants.MIXERCONTROL_CONTROLTYPE_SINGLESELECT + 1);

        /// MIXERCONTROL_CONTROLTYPE_MUTE -> (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 2)
        public const int MIXERCONTROL_CONTROLTYPE_MUTE = (NativeConstants.MIXERCONTROL_CONTROLTYPE_BOOLEAN + 2);

        /// MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT -> (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_MULTIPLE | MIXERCONTROL_CT_UNITS_BOOLEAN)
        public const int MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT = (NativeConstants.MIXERCONTROL_CT_CLASS_LIST
                    | (NativeConstants.MIXERCONTROL_CT_SC_LIST_MULTIPLE | NativeConstants.MIXERCONTROL_CT_UNITS_BOOLEAN));

        /// MIXERCONTROL_CONTROLTYPE_MONO -> (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 3)
        public const int MIXERCONTROL_CONTROLTYPE_MONO = (NativeConstants.MIXERCONTROL_CONTROLTYPE_BOOLEAN + 3);

        /// MIXERCONTROL_CONTROLTYPE_MIXER -> (MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT + 1)
        public const int MIXERCONTROL_CONTROLTYPE_MIXER = (NativeConstants.MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT + 1);

        /// MIXERCONTROL_CONTROLTYPE_MILLITIME -> (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MILLISECS | MIXERCONTROL_CT_UNITS_UNSIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_MILLITIME = (NativeConstants.MIXERCONTROL_CT_CLASS_TIME
                    | (NativeConstants.MIXERCONTROL_CT_SC_TIME_MILLISECS | NativeConstants.MIXERCONTROL_CT_UNITS_UNSIGNED));

        /// MIXERCONTROL_CONTROLTYPE_MICROTIME -> (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MICROSECS | MIXERCONTROL_CT_UNITS_UNSIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_MICROTIME = (NativeConstants.MIXERCONTROL_CT_CLASS_TIME
                    | (NativeConstants.MIXERCONTROL_CT_SC_TIME_MICROSECS | NativeConstants.MIXERCONTROL_CT_UNITS_UNSIGNED));

        /// MIXERCONTROL_CONTROLTYPE_LOUDNESS -> (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 4)
        public const int MIXERCONTROL_CONTROLTYPE_LOUDNESS = (NativeConstants.MIXERCONTROL_CONTROLTYPE_BOOLEAN + 4);

        /// MIXERCONTROL_CONTROLTYPE_FADER -> (MIXERCONTROL_CT_CLASS_FADER | MIXERCONTROL_CT_UNITS_UNSIGNED)
        public const int MIXERCONTROL_CONTROLTYPE_FADER = (NativeConstants.MIXERCONTROL_CT_CLASS_FADER | NativeConstants.MIXERCONTROL_CT_UNITS_UNSIGNED);

        /// MIXERCONTROL_CONTROLTYPE_EQUALIZER -> (MIXERCONTROL_CONTROLTYPE_FADER + 4)
        public const int MIXERCONTROL_CONTROLTYPE_EQUALIZER = (NativeConstants.MIXERCONTROL_CONTROLTYPE_FADER + 4);

        /// MIXERCONTROL_CONTROLTYPE_DECIBELS -> (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_DECIBELS)
        public const int MIXERCONTROL_CONTROLTYPE_DECIBELS = (NativeConstants.MIXERCONTROL_CT_CLASS_NUMBER | NativeConstants.MIXERCONTROL_CT_UNITS_DECIBELS);

        /// MIXERCONTROL_CONTROLTYPE_CUSTOM -> (MIXERCONTROL_CT_CLASS_CUSTOM | MIXERCONTROL_CT_UNITS_CUSTOM)
        public const int MIXERCONTROL_CONTROLTYPE_CUSTOM = (NativeConstants.MIXERCONTROL_CT_CLASS_CUSTOM | NativeConstants.MIXERCONTROL_CT_UNITS_CUSTOM);

        /// MIXERCONTROL_CONTROLTYPE_BUTTON -> (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BUTTON | MIXERCONTROL_CT_UNITS_BOOLEAN)
        public const int MIXERCONTROL_CONTROLTYPE_BUTTON = (NativeConstants.MIXERCONTROL_CT_CLASS_SWITCH
                    | (NativeConstants.MIXERCONTROL_CT_SC_SWITCH_BUTTON | NativeConstants.MIXERCONTROL_CT_UNITS_BOOLEAN));

        /// MIXERCONTROL_CONTROLTYPE_BOOLEANMETER -> (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_BOOLEAN)
        public const int MIXERCONTROL_CONTROLTYPE_BOOLEANMETER = (NativeConstants.MIXERCONTROL_CT_CLASS_METER
                    | (NativeConstants.MIXERCONTROL_CT_SC_METER_POLLED | NativeConstants.MIXERCONTROL_CT_UNITS_BOOLEAN));

        /// MIXERCONTROL_CONTROLTYPE_BOOLEAN -> (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BOOLEAN | MIXERCONTROL_CT_UNITS_BOOLEAN)
        public const int MIXERCONTROL_CONTROLTYPE_BOOLEAN = (NativeConstants.MIXERCONTROL_CT_CLASS_SWITCH
                    | (NativeConstants.MIXERCONTROL_CT_SC_SWITCH_BOOLEAN | NativeConstants.MIXERCONTROL_CT_UNITS_BOOLEAN));

        /// MIXERCONTROL_CONTROLTYPE_BASS_BOOST -> (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 0x00002277)
        public const int MIXERCONTROL_CONTROLTYPE_BASS_BOOST = (NativeConstants.MIXERCONTROL_CONTROLTYPE_BOOLEAN + 8823);

        /// MIXERCONTROL_CONTROLTYPE_BASS -> (MIXERCONTROL_CONTROLTYPE_FADER + 2)
        public const int MIXERCONTROL_CONTROLTYPE_BASS = (NativeConstants.MIXERCONTROL_CONTROLTYPE_FADER + 2);

        /// MIXERCONTROL_CONTROLF_UNIFORM -> 0x00000001L
        public const int MIXERCONTROL_CONTROLF_UNIFORM = 1;

        /// MIXERCONTROL_CONTROLF_MULTIPLE -> 0x00000002L
        public const int MIXERCONTROL_CONTROLF_MULTIPLE = 2;

        /// MIXERCONTROL_CONTROLF_DISABLED -> 0x80000000L
        public const int MIXERCONTROL_CONTROLF_DISABLED = -2147483648;

        /// MIN_PRIORITY -> 1
        public const int MIN_PRIORITY = 1;

        /// MIN_ACL_REVISION -> ACL_REVISION2
        public const int MIN_ACL_REVISION = NativeConstants.ACL_REVISION2;

        /// MINSHORT -> 0x8000
        public const int MINSHORT = 32768;

        /// MINLONG -> 0x80000000
        public const int MINLONG = -2147483648;

        /// MINCHAR -> 0x80
        public const int MINCHAR = 128;

        /// MIM_STYLE -> 0x00000010
        public const int MIM_STYLE = 16;

        /// MIM_OPEN -> MM_MIM_OPEN
        public const int MIM_OPEN = NativeConstants.MM_MIM_OPEN;

        /// MIM_MOREDATA -> MM_MIM_MOREDATA
        public const int MIM_MOREDATA = NativeConstants.MM_MIM_MOREDATA;

        /// MIM_MENUDATA -> 0x00000008
        public const int MIM_MENUDATA = 8;

        /// MIM_MAXHEIGHT -> 0x00000001
        public const int MIM_MAXHEIGHT = 1;

        /// MIM_LONGERROR -> MM_MIM_LONGERROR
        public const int MIM_LONGERROR = NativeConstants.MM_MIM_LONGERROR;

        /// MIM_LONGDATA -> MM_MIM_LONGDATA
        public const int MIM_LONGDATA = NativeConstants.MM_MIM_LONGDATA;

        /// MIM_HELPID -> 0x00000004
        public const int MIM_HELPID = 4;

        /// MIM_ERROR -> MM_MIM_ERROR
        public const int MIM_ERROR = NativeConstants.MM_MIM_ERROR;

        /// MIM_DATA -> MM_MIM_DATA
        public const int MIM_DATA = NativeConstants.MM_MIM_DATA;

        /// MIM_CLOSE -> MM_MIM_CLOSE
        public const int MIM_CLOSE = NativeConstants.MM_MIM_CLOSE;

        /// MIM_BACKGROUND -> 0x00000002
        public const int MIM_BACKGROUND = 2;

        /// MIM_APPLYTOSUBMENUS -> 0x80000000
        public const int MIM_APPLYTOSUBMENUS = -2147483648;

        /// MIIM_TYPE -> 0x00000010
        public const int MIIM_TYPE = 16;

        /// MIIM_SUBMENU -> 0x00000004
        public const int MIIM_SUBMENU = 4;

        /// MIIM_STRING -> 0x00000040
        public const int MIIM_STRING = 64;

        /// MIIM_STATE -> 0x00000001
        public const int MIIM_STATE = 1;

        /// MIIM_ID -> 0x00000002
        public const int MIIM_ID = 2;

        /// MIIM_FTYPE -> 0x00000100
        public const int MIIM_FTYPE = 256;

        /// MIIM_DATA -> 0x00000020
        public const int MIIM_DATA = 32;

        /// MIIM_CHECKMARKS -> 0x00000008
        public const int MIIM_CHECKMARKS = 8;

        /// MIIM_BITMAP -> 0x00000080
        public const int MIIM_BITMAP = 128;

        /// midl_user_free -> MIDL_user_free
        /// Error generating expression: Value MIDL_user_free is not resolved
        public const string midl_user_free = "MIDL_user_free";

        /// midl_user_allocate -> MIDL_user_allocate
        /// Error generating expression: Value MIDL_user_allocate is not resolved
        public const string midl_user_allocate = "MIDL_user_allocate";

        /// MIDI_UNCACHE -> 4
        public const int MIDI_UNCACHE = 4;

        /// MIDI_MAPPER -> ((UINT)-1)
        /// Error generating expression: Value UINT is not resolved
        public const string MIDI_MAPPER = "((UINT)-1)";

        /// MIDI_IO_STATUS -> 0x00000020L
        public const int MIDI_IO_STATUS = 32;

        /// MIDI_CACHE_QUERY -> 3
        public const int MIDI_CACHE_QUERY = 3;

        /// MIDI_CACHE_BESTFIT -> 2
        public const int MIDI_CACHE_BESTFIT = 2;

        /// MIDI_CACHE_ALL -> 1
        public const int MIDI_CACHE_ALL = 1;

        /// MIDISTRM_ERROR -> (-2)
        public const int MIDISTRM_ERROR = -2;

        /// MIDIPROP_TIMEDIV -> 0x00000001L
        public const int MIDIPROP_TIMEDIV = 1;

        /// MIDIPROP_TEMPO -> 0x00000002L
        public const int MIDIPROP_TEMPO = 2;

        /// MIDIPROP_SET -> 0x80000000L
        public const int MIDIPROP_SET = -2147483648;

        /// MIDIPROP_GET -> 0x40000000L
        public const int MIDIPROP_GET = 1073741824;

        /// MIDIPATCHSIZE -> 128
        public const int MIDIPATCHSIZE = 128;

        /// midiOutGetErrorText -> midiOutGetErrorTextW
        /// Error generating expression: Value midiOutGetErrorTextW is not resolved
        public const string midiOutGetErrorText = "midiOutGetErrorTextW";

        /// midiOutGetDevCaps -> midiOutGetDevCapsW
        /// Error generating expression: Value midiOutGetDevCapsW is not resolved
        public const string midiOutGetDevCaps = "midiOutGetDevCapsW";

        /// MIDIMAPPER -> ((UINT)-1)
        /// Error generating expression: Value UINT is not resolved
        public const string MIDIMAPPER = "((UINT)-1)";

        /// midiInGetErrorText -> midiInGetErrorTextW
        /// Error generating expression: Value midiInGetErrorTextW is not resolved
        public const string midiInGetErrorText = "midiInGetErrorTextW";

        /// midiInGetDevCaps -> midiInGetDevCapsW
        /// Error generating expression: Value midiInGetDevCapsW is not resolved
        public const string midiInGetDevCaps = "midiInGetDevCapsW";

        /// MIDIERR_UNPREPARED -> (MIDIERR_BASE + 0)
        public const int MIDIERR_UNPREPARED = (NativeConstants.MIDIERR_BASE + 0);

        /// MIDIERR_STILLPLAYING -> (MIDIERR_BASE + 1)
        public const int MIDIERR_STILLPLAYING = (NativeConstants.MIDIERR_BASE + 1);

        /// MIDIERR_NOTREADY -> (MIDIERR_BASE + 3)
        public const int MIDIERR_NOTREADY = (NativeConstants.MIDIERR_BASE + 3);

        /// MIDIERR_NOMAP -> (MIDIERR_BASE + 2)
        public const int MIDIERR_NOMAP = (NativeConstants.MIDIERR_BASE + 2);

        /// MIDIERR_NODEVICE -> (MIDIERR_BASE + 4)
        public const int MIDIERR_NODEVICE = (NativeConstants.MIDIERR_BASE + 4);

        /// MIDIERR_LASTERROR -> (MIDIERR_BASE + 7)
        public const int MIDIERR_LASTERROR = (NativeConstants.MIDIERR_BASE + 7);

        /// MIDIERR_INVALIDSETUP -> (MIDIERR_BASE + 5)
        public const int MIDIERR_INVALIDSETUP = (NativeConstants.MIDIERR_BASE + 5);

        /// MIDIERR_DONT_CONTINUE -> (MIDIERR_BASE + 7)
        public const int MIDIERR_DONT_CONTINUE = (NativeConstants.MIDIERR_BASE + 7);

        /// MIDIERR_BASE -> 64
        public const int MIDIERR_BASE = 64;

        /// MIDIERR_BADOPENMODE -> (MIDIERR_BASE + 6)
        public const int MIDIERR_BADOPENMODE = (NativeConstants.MIDIERR_BASE + 6);

        /// MIDICAPS_VOLUME -> 0x0001
        public const int MIDICAPS_VOLUME = 1;

        /// MIDICAPS_STREAM -> 0x0008
        public const int MIDICAPS_STREAM = 8;

        /// MIDICAPS_LRVOLUME -> 0x0002
        public const int MIDICAPS_LRVOLUME = 2;

        /// MIDICAPS_CACHE -> 0x0004
        public const int MIDICAPS_CACHE = 4;

        /// MICROSOFT_ROOT_CERT_CHAIN_POLICY_ENABLE_TEST_ROOT_FLAG -> 0x00010000
        public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_ENABLE_TEST_ROOT_FLAG = 65536;

        /// MH_KEEP -> 2
        public const int MH_KEEP = 2;

        /// MH_DELETE -> 3
        public const int MH_DELETE = 3;

        /// MH_CREATE -> 1
        public const int MH_CREATE = 1;

        /// MH_CLEANUP -> 4
        public const int MH_CLEANUP = 4;

        /// MHDR_PREPARED -> 0x00000002
        public const int MHDR_PREPARED = 2;

        /// MHDR_ISSTRM -> 0x00000008
        public const int MHDR_ISSTRM = 8;

        /// MHDR_INQUEUE -> 0x00000004
        public const int MHDR_INQUEUE = 4;

        /// MHDR_DONE -> 0x00000001
        public const int MHDR_DONE = 1;

        /// MF_USECHECKBITMAPS -> 0x00000200L
        public const int MF_USECHECKBITMAPS = 512;

        /// MF_UNHILITE -> 0x00000000L
        public const int MF_UNHILITE = 0;

        /// MF_UNCHECKED -> 0x00000000L
        public const int MF_UNCHECKED = 0;

        /// MF_SYSMENU -> 0x00002000L
        public const int MF_SYSMENU = 8192;

        /// MF_STRING -> 0x00000000L
        public const int MF_STRING = 0;

        /// MF_SEPARATOR -> 0x00000800L
        public const int MF_SEPARATOR = 2048;

        /// MF_SENDMSGS -> 0x02000000
        public const int MF_SENDMSGS = 33554432;

        /// MF_RIGHTJUSTIFY -> 0x00004000L
        public const int MF_RIGHTJUSTIFY = 16384;

        /// MF_REMOVE -> 0x00001000L
        public const int MF_REMOVE = 4096;

        /// MF_POSTMSGS -> 0x04000000
        public const int MF_POSTMSGS = 67108864;

        /// MF_POPUP -> 0x00000010L
        public const int MF_POPUP = 16;

        /// MF_OWNERDRAW -> 0x00000100L
        public const int MF_OWNERDRAW = 256;

        /// MF_MOUSESELECT -> 0x00008000L
        public const int MF_MOUSESELECT = 32768;

        /// MF_MENUBREAK -> 0x00000040L
        public const int MF_MENUBREAK = 64;

        /// MF_MENUBARBREAK -> 0x00000020L
        public const int MF_MENUBARBREAK = 32;

        /// MF_MASK -> 0xFF000000
        public const int MF_MASK = -16777216;

        /// MF_LINKS -> 0x20000000
        public const int MF_LINKS = 536870912;

        /// MF_INSERT -> 0x00000000L
        public const int MF_INSERT = 0;

        /// MF_HSZ_INFO -> 0x01000000
        public const int MF_HSZ_INFO = 16777216;

        /// MF_HILITE -> 0x00000080L
        public const int MF_HILITE = 128;

        /// MF_HELP -> 0x00004000L
        public const int MF_HELP = 16384;

        /// MF_GRAYED -> 0x00000001L
        public const int MF_GRAYED = 1;

        /// MF_ERRORS -> 0x10000000
        public const int MF_ERRORS = 268435456;

        /// MF_END -> 0x00000080L
        public const int MF_END = 128;

        /// MF_ENABLED -> 0x00000000L
        public const int MF_ENABLED = 0;

        /// MF_DISABLED -> 0x00000002L
        public const int MF_DISABLED = 2;

        /// MF_DELETE -> 0x00000200L
        public const int MF_DELETE = 512;

        /// MF_DEFAULT -> 0x00001000L
        public const int MF_DEFAULT = 4096;

        /// MF_CONV -> 0x40000000
        public const int MF_CONV = 1073741824;

        /// MF_CHECKED -> 0x00000008L
        public const int MF_CHECKED = 8;

        /// MF_CHANGE -> 0x00000080L
        public const int MF_CHANGE = 128;

        /// MF_CALLBACKS -> 0x08000000
        public const int MF_CALLBACKS = 134217728;

        /// MF_BYPOSITION -> 0x00000400L
        public const int MF_BYPOSITION = 1024;

        /// MF_BYCOMMAND -> 0x00000000L
        public const int MF_BYCOMMAND = 0;

        /// MF_BITMAP -> 0x00000004L
        public const int MF_BITMAP = 4;

        /// MF_APPEND -> 0x00000100L
        public const int MF_APPEND = 256;

        /// MFT_STRING -> MF_STRING
        public const int MFT_STRING = NativeConstants.MF_STRING;

        /// MFT_SEPARATOR -> MF_SEPARATOR
        public const int MFT_SEPARATOR = NativeConstants.MF_SEPARATOR;

        /// MFT_RIGHTORDER -> 0x00002000L
        public const int MFT_RIGHTORDER = 8192;

        /// MFT_RIGHTJUSTIFY -> MF_RIGHTJUSTIFY
        public const int MFT_RIGHTJUSTIFY = NativeConstants.MF_RIGHTJUSTIFY;

        /// MFT_RADIOCHECK -> 0x00000200L
        public const int MFT_RADIOCHECK = 512;

        /// MFT_OWNERDRAW -> MF_OWNERDRAW
        public const int MFT_OWNERDRAW = NativeConstants.MF_OWNERDRAW;

        /// MFT_MENUBREAK -> MF_MENUBREAK
        public const int MFT_MENUBREAK = NativeConstants.MF_MENUBREAK;

        /// MFT_MENUBARBREAK -> MF_MENUBARBREAK
        public const int MFT_MENUBARBREAK = NativeConstants.MF_MENUBARBREAK;

        /// MFT_BITMAP -> MF_BITMAP
        public const int MFT_BITMAP = NativeConstants.MF_BITMAP;

        /// MFS_UNHILITE -> MF_UNHILITE
        public const int MFS_UNHILITE = NativeConstants.MF_UNHILITE;

        /// MFS_UNCHECKED -> MF_UNCHECKED
        public const int MFS_UNCHECKED = NativeConstants.MF_UNCHECKED;

        /// MFS_HILITE -> MF_HILITE
        public const int MFS_HILITE = NativeConstants.MF_HILITE;

        /// MFS_GRAYED -> 0x00000003L
        public const int MFS_GRAYED = 3;

        /// MFS_ENABLED -> MF_ENABLED
        public const int MFS_ENABLED = NativeConstants.MF_ENABLED;

        /// MFS_DISABLED -> MFS_GRAYED
        public const int MFS_DISABLED = NativeConstants.MFS_GRAYED;

        /// MFS_DEFAULT -> MF_DEFAULT
        public const int MFS_DEFAULT = NativeConstants.MF_DEFAULT;

        /// MFS_CHECKED -> MF_CHECKED
        public const int MFS_CHECKED = NativeConstants.MF_CHECKED;

        /// MFCOMMENT -> 15
        public const int MFCOMMENT = 15;

        /// MEVT_F_SHORT -> 0x00000000L
        public const int MEVT_F_SHORT = 0;

        /// MEVT_F_LONG -> 0x80000000L
        public const int MEVT_F_LONG = -2147483648;

        /// MEVT_F_CALLBACK -> 0x40000000L
        public const int MEVT_F_CALLBACK = 1073741824;

        /// METRICS_USEDEFAULT -> -1
        public const int METRICS_USEDEFAULT = -1;

        /// METHOD_OUT_DIRECT -> 2
        public const int METHOD_OUT_DIRECT = 2;

        /// METHOD_NEITHER -> 3
        public const int METHOD_NEITHER = 3;

        /// METHOD_IN_DIRECT -> 1
        public const int METHOD_IN_DIRECT = 1;

        /// METHOD_DIRECT_TO_HARDWARE -> METHOD_IN_DIRECT
        public const int METHOD_DIRECT_TO_HARDWARE = NativeConstants.METHOD_IN_DIRECT;

        /// METHOD_DIRECT_FROM_HARDWARE -> METHOD_OUT_DIRECT
        public const int METHOD_DIRECT_FROM_HARDWARE = NativeConstants.METHOD_OUT_DIRECT;

        /// METHOD_BUFFERED -> 0
        public const int METHOD_BUFFERED = 0;

        /// META_TEXTOUT -> 0x0521
        public const int META_TEXTOUT = 1313;

        /// META_STRETCHDIB -> 0x0f43
        public const int META_STRETCHDIB = 3907;

        /// META_STRETCHBLT -> 0x0B23
        public const int META_STRETCHBLT = 2851;

        /// META_SETWINDOWORG -> 0x020B
        public const int META_SETWINDOWORG = 523;

        /// META_SETWINDOWEXT -> 0x020C
        public const int META_SETWINDOWEXT = 524;

        /// META_SETVIEWPORTORG -> 0x020D
        public const int META_SETVIEWPORTORG = 525;

        /// META_SETVIEWPORTEXT -> 0x020E
        public const int META_SETVIEWPORTEXT = 526;

        /// META_SETTEXTJUSTIFICATION -> 0x020A
        public const int META_SETTEXTJUSTIFICATION = 522;

        /// META_SETTEXTCOLOR -> 0x0209
        public const int META_SETTEXTCOLOR = 521;

        /// META_SETTEXTCHAREXTRA -> 0x0108
        public const int META_SETTEXTCHAREXTRA = 264;

        /// META_SETTEXTALIGN -> 0x012E
        public const int META_SETTEXTALIGN = 302;

        /// META_SETSTRETCHBLTMODE -> 0x0107
        public const int META_SETSTRETCHBLTMODE = 263;

        /// META_SETROP2 -> 0x0104
        public const int META_SETROP2 = 260;

        /// META_SETRELABS -> 0x0105
        public const int META_SETRELABS = 261;

        /// META_SETPOLYFILLMODE -> 0x0106
        public const int META_SETPOLYFILLMODE = 262;

        /// META_SETPIXEL -> 0x041F
        public const int META_SETPIXEL = 1055;

        /// META_SETPALENTRIES -> 0x0037
        public const int META_SETPALENTRIES = 55;

        /// META_SETMAPPERFLAGS -> 0x0231
        public const int META_SETMAPPERFLAGS = 561;

        /// META_SETMAPMODE -> 0x0103
        public const int META_SETMAPMODE = 259;

        /// META_SETLAYOUT -> 0x0149
        public const int META_SETLAYOUT = 329;

        /// META_SETDIBTODEV -> 0x0d33
        public const int META_SETDIBTODEV = 3379;

        /// META_SETBKMODE -> 0x0102
        public const int META_SETBKMODE = 258;

        /// META_SETBKCOLOR -> 0x0201
        public const int META_SETBKCOLOR = 513;

        /// META_SELECTPALETTE -> 0x0234
        public const int META_SELECTPALETTE = 564;

        /// META_SELECTOBJECT -> 0x012D
        public const int META_SELECTOBJECT = 301;

        /// META_SELECTCLIPREGION -> 0x012C
        public const int META_SELECTCLIPREGION = 300;

        /// META_SCALEWINDOWEXT -> 0x0410
        public const int META_SCALEWINDOWEXT = 1040;

        /// META_SCALEVIEWPORTEXT -> 0x0412
        public const int META_SCALEVIEWPORTEXT = 1042;

        /// META_SAVEDC -> 0x001E
        public const int META_SAVEDC = 30;

        /// META_ROUNDRECT -> 0x061C
        public const int META_ROUNDRECT = 1564;

        /// META_RESTOREDC -> 0x0127
        public const int META_RESTOREDC = 295;

        /// META_RESIZEPALETTE -> 0x0139
        public const int META_RESIZEPALETTE = 313;

        /// META_RECTANGLE -> 0x041B
        public const int META_RECTANGLE = 1051;

        /// META_REALIZEPALETTE -> 0x0035
        public const int META_REALIZEPALETTE = 53;

        /// META_POLYPOLYGON -> 0x0538
        public const int META_POLYPOLYGON = 1336;

        /// META_POLYLINE -> 0x0325
        public const int META_POLYLINE = 805;

        /// META_POLYGON -> 0x0324
        public const int META_POLYGON = 804;

        /// META_PIE -> 0x081A
        public const int META_PIE = 2074;

        /// META_PATBLT -> 0x061D
        public const int META_PATBLT = 1565;

        /// META_PAINTREGION -> 0x012B
        public const int META_PAINTREGION = 299;

        /// META_OFFSETWINDOWORG -> 0x020F
        public const int META_OFFSETWINDOWORG = 527;

        /// META_OFFSETVIEWPORTORG -> 0x0211
        public const int META_OFFSETVIEWPORTORG = 529;

        /// META_OFFSETCLIPRGN -> 0x0220
        public const int META_OFFSETCLIPRGN = 544;

        /// META_MOVETO -> 0x0214
        public const int META_MOVETO = 532;

        /// META_LINETO -> 0x0213
        public const int META_LINETO = 531;

        /// META_INVERTREGION -> 0x012A
        public const int META_INVERTREGION = 298;

        /// META_INTERSECTCLIPRECT -> 0x0416
        public const int META_INTERSECTCLIPRECT = 1046;

        /// META_FRAMEREGION -> 0x0429
        public const int META_FRAMEREGION = 1065;

        /// META_FLOODFILL -> 0x0419
        public const int META_FLOODFILL = 1049;

        /// META_FILLREGION -> 0x0228
        public const int META_FILLREGION = 552;

        /// META_EXTTEXTOUT -> 0x0a32
        public const int META_EXTTEXTOUT = 2610;

        /// META_EXTFLOODFILL -> 0x0548
        public const int META_EXTFLOODFILL = 1352;

        /// META_EXCLUDECLIPRECT -> 0x0415
        public const int META_EXCLUDECLIPRECT = 1045;

        /// META_ESCAPE -> 0x0626
        public const int META_ESCAPE = 1574;

        /// META_ELLIPSE -> 0x0418
        public const int META_ELLIPSE = 1048;

        /// META_DIBSTRETCHBLT -> 0x0b41
        public const int META_DIBSTRETCHBLT = 2881;

        /// META_DIBCREATEPATTERNBRUSH -> 0x0142
        public const int META_DIBCREATEPATTERNBRUSH = 322;

        /// META_DIBBITBLT -> 0x0940
        public const int META_DIBBITBLT = 2368;

        /// META_DELETEOBJECT -> 0x01f0
        public const int META_DELETEOBJECT = 496;

        /// META_CREATEREGION -> 0x06FF
        public const int META_CREATEREGION = 1791;

        /// META_CREATEPENINDIRECT -> 0x02FA
        public const int META_CREATEPENINDIRECT = 762;

        /// META_CREATEPATTERNBRUSH -> 0x01F9
        public const int META_CREATEPATTERNBRUSH = 505;

        /// META_CREATEPALETTE -> 0x00f7
        public const int META_CREATEPALETTE = 247;

        /// META_CREATEFONTINDIRECT -> 0x02FB
        public const int META_CREATEFONTINDIRECT = 763;

        /// META_CREATEBRUSHINDIRECT -> 0x02FC
        public const int META_CREATEBRUSHINDIRECT = 764;

        /// META_CHORD -> 0x0830
        public const int META_CHORD = 2096;

        /// META_BITBLT -> 0x0922
        public const int META_BITBLT = 2338;

        /// META_ARC -> 0x0817
        public const int META_ARC = 2071;

        /// META_ANIMATEPALETTE -> 0x0436
        public const int META_ANIMATEPALETTE = 1078;

        /// METAFILE_DRIVER -> 2049
        public const int METAFILE_DRIVER = 2049;

        /// MESSAGE_RESOURCE_UNICODE -> 0x0001
        public const int MESSAGE_RESOURCE_UNICODE = 1;

        /// MessageBoxIndirect -> MessageBoxIndirectW
        /// Error generating expression: Value MessageBoxIndirectW is not resolved
        public const string MessageBoxIndirect = "MessageBoxIndirectW";

        /// MessageBoxEx -> MessageBoxExW
        /// Error generating expression: Value MessageBoxExW is not resolved
        public const string MessageBoxEx = "MessageBoxExW";

        /// MessageBox -> MessageBoxW
        /// Error generating expression: Value MessageBoxW is not resolved
        public const string MessageBox = "MessageBoxW";

        /// MENU_EVENT -> 0x0008
        public const int MENU_EVENT = 8;

        /// MEM_WRITE_WATCH -> 0x200000
        public const int MEM_WRITE_WATCH = 2097152;

        /// MEM_TOP_DOWN -> 0x100000
        public const int MEM_TOP_DOWN = 1048576;

        /// MEM_RESET -> 0x80000
        public const int MEM_RESET = 524288;

        /// MEM_RESERVE -> 0x2000
        public const int MEM_RESERVE = 8192;

        /// MEM_RELEASE -> 0x8000
        public const int MEM_RELEASE = 32768;

        /// MEM_PRIVATE -> 0x20000
        public const int MEM_PRIVATE = 131072;

        /// MEM_PHYSICAL -> 0x400000
        public const int MEM_PHYSICAL = 4194304;

        /// MEM_MAPPED -> 0x40000
        public const int MEM_MAPPED = 262144;

        /// MEM_LARGE_PAGES -> 0x20000000
        public const int MEM_LARGE_PAGES = 536870912;

        /// MEM_IMAGE -> SEC_IMAGE
        public const int MEM_IMAGE = NativeConstants.SEC_IMAGE;

        /// MEM_FREE -> 0x10000
        public const int MEM_FREE = 65536;

        /// MEM_DECOMMIT -> 0x4000
        public const int MEM_DECOMMIT = 16384;

        /// MEM_COMMIT -> 0x1000
        public const int MEM_COMMIT = 4096;

        /// MEM_4MB_PAGES -> 0x80000000
        public const int MEM_4MB_PAGES = -2147483648;

        /// MEMORY_ALLOCATION_ALIGNMENT -> 8
        public const int MEMORY_ALLOCATION_ALIGNMENT = 8;

        /// MEMBERID_NIL -> DISPID_UNKNOWN
        public const int MEMBERID_NIL = NativeConstants.DISPID_UNKNOWN;

        /// MediumChangerClassGuid -> GUID_DEVINTERFACE_MEDIUMCHANGER
        /// Error generating expression: Value GUID_DEVINTERFACE_MEDIUMCHANGER is not resolved
        public const string MediumChangerClassGuid = "GUID_DEVINTERFACE_MEDIUMCHANGER";

        /// MEDIA_WRITE_PROTECTED -> 0x00000100
        public const int MEDIA_WRITE_PROTECTED = 256;

        /// MEDIA_WRITE_ONCE -> 0x00000002
        public const int MEDIA_WRITE_ONCE = 2;

        /// MEDIA_READ_WRITE -> 0x00000008
        public const int MEDIA_READ_WRITE = 8;

        /// MEDIA_READ_ONLY -> 0x00000004
        public const int MEDIA_READ_ONLY = 4;

        /// MEDIA_ERASEABLE -> 0x00000001
        public const int MEDIA_ERASEABLE = 1;

        /// MEDIA_CURRENTLY_MOUNTED -> 0x80000000
        public const int MEDIA_CURRENTLY_MOUNTED = -2147483648;

        /// MDM_X75_DATA_T_70 -> 0x3
        public const int MDM_X75_DATA_T_70 = 3;

        /// MDM_X75_DATA_DEFAULT -> 0x0
        public const int MDM_X75_DATA_DEFAULT = 0;

        /// MDM_X75_DATA_BTX -> 0x4
        public const int MDM_X75_DATA_BTX = 4;

        /// MDM_X75_DATA_64K -> 0x1
        public const int MDM_X75_DATA_64K = 1;

        /// MDM_X75_DATA_128K -> 0x2
        public const int MDM_X75_DATA_128K = 2;

        /// MDM_V23_OVERRIDE -> 0x00000400
        public const int MDM_V23_OVERRIDE = 1024;

        /// MDM_V120_SPEED_DEFAULT -> 0x0
        public const int MDM_V120_SPEED_DEFAULT = 0;

        /// MDM_V120_SPEED_64K -> 0x1
        public const int MDM_V120_SPEED_64K = 1;

        /// MDM_V120_SPEED_56K -> 0x2
        public const int MDM_V120_SPEED_56K = 2;

        /// MDM_V120_ML_NONE -> 0x1
        public const int MDM_V120_ML_NONE = 1;

        /// MDM_V120_ML_DEFAULT -> 0x0
        public const int MDM_V120_ML_DEFAULT = 0;

        /// MDM_V120_ML_2 -> 0x2
        public const int MDM_V120_ML_2 = 2;

        /// MDM_V110_SPEED_DEFAULT -> 0x0
        public const int MDM_V110_SPEED_DEFAULT = 0;

        /// MDM_V110_SPEED_9DOT6K -> 0x4
        public const int MDM_V110_SPEED_9DOT6K = 4;

        /// MDM_V110_SPEED_57DOT6K -> 0xA
        public const int MDM_V110_SPEED_57DOT6K = 10;

        /// MDM_V110_SPEED_4DOT8K -> 0x3
        public const int MDM_V110_SPEED_4DOT8K = 3;

        /// MDM_V110_SPEED_38DOT4K -> 0x9
        public const int MDM_V110_SPEED_38DOT4K = 9;

        /// MDM_V110_SPEED_2DOT4K -> 0x2
        public const int MDM_V110_SPEED_2DOT4K = 2;

        /// MDM_V110_SPEED_28DOT8K -> 0x8
        public const int MDM_V110_SPEED_28DOT8K = 8;

        /// MDM_V110_SPEED_1DOT2K -> 0x1
        public const int MDM_V110_SPEED_1DOT2K = 1;

        /// MDM_V110_SPEED_19DOT2K -> 0x7
        public const int MDM_V110_SPEED_19DOT2K = 7;

        /// MDM_V110_SPEED_14DOT4K -> 0x6
        public const int MDM_V110_SPEED_14DOT4K = 6;

        /// MDM_V110_SPEED_12DOT0K -> 0x5
        public const int MDM_V110_SPEED_12DOT0K = 5;

        /// MDM_TONE_DIAL -> 0x00000100
        public const int MDM_TONE_DIAL = 256;

        /// MDM_SPEED_ADJUST -> 0x00000080
        public const int MDM_SPEED_ADJUST = 128;

        /// MDM_SHIFT_X75_DATA -> 0x0
        public const int MDM_SHIFT_X75_DATA = 0;

        /// MDM_SHIFT_V120_SPEED -> 0x0
        public const int MDM_SHIFT_V120_SPEED = 0;

        /// MDM_SHIFT_V120_ML -> 0x6
        public const int MDM_SHIFT_V120_ML = 6;

        /// MDM_SHIFT_V110_SPEED -> 0x0
        public const int MDM_SHIFT_V110_SPEED = 0;

        /// MDM_SHIFT_PROTOCOLINFO -> MDM_SHIFT_PROTOCOLID
        public const int MDM_SHIFT_PROTOCOLINFO = NativeConstants.MDM_SHIFT_PROTOCOLID;

        /// MDM_SHIFT_PROTOCOLID -> 16
        public const int MDM_SHIFT_PROTOCOLID = 16;

        /// MDM_SHIFT_PROTOCOLDATA -> 20
        public const int MDM_SHIFT_PROTOCOLDATA = 20;

        /// MDM_SHIFT_HDLCPPP_SPEED -> 0x0
        public const int MDM_SHIFT_HDLCPPP_SPEED = 0;

        /// MDM_SHIFT_HDLCPPP_ML -> 0x6
        public const int MDM_SHIFT_HDLCPPP_ML = 6;

        /// MDM_SHIFT_HDLCPPP_AUTH -> 0x3
        public const int MDM_SHIFT_HDLCPPP_AUTH = 3;

        /// MDM_SHIFT_EXTENDEDINFO -> MDM_SHIFT_BEARERMODE
        public const int MDM_SHIFT_EXTENDEDINFO = NativeConstants.MDM_SHIFT_BEARERMODE;

        /// MDM_SHIFT_BEARERMODE -> 12
        public const int MDM_SHIFT_BEARERMODE = 12;

        /// MDM_SHIFT_AUTO_SPEED -> 0x0
        public const int MDM_SHIFT_AUTO_SPEED = 0;

        /// MDM_SHIFT_AUTO_ML -> 0x6
        public const int MDM_SHIFT_AUTO_ML = 6;

        /// MDM_PROTOCOLID_X75 -> 0x3
        public const int MDM_PROTOCOLID_X75 = 3;

        /// MDM_PROTOCOLID_V128 -> 0x2
        public const int MDM_PROTOCOLID_V128 = 2;

        /// MDM_PROTOCOLID_V120 -> 0x5
        public const int MDM_PROTOCOLID_V120 = 5;

        /// MDM_PROTOCOLID_V110 -> 0x4
        public const int MDM_PROTOCOLID_V110 = 4;

        /// MDM_PROTOCOLID_PIAFS -> 0x9
        public const int MDM_PROTOCOLID_PIAFS = 9;

        /// MDM_PROTOCOLID_HDLCPPP -> 0x1
        public const int MDM_PROTOCOLID_HDLCPPP = 1;

        /// MDM_PROTOCOLID_GPRS -> 0x8
        public const int MDM_PROTOCOLID_GPRS = 8;

        /// MDM_PROTOCOLID_DEFAULT -> 0x0
        public const int MDM_PROTOCOLID_DEFAULT = 0;

        /// MDM_PROTOCOLID_AUTO -> 0x6
        public const int MDM_PROTOCOLID_AUTO = 6;

        /// MDM_PROTOCOLID_ANALOG -> 0x7
        public const int MDM_PROTOCOLID_ANALOG = 7;

        /// MDM_PIAFS_OUTGOING -> 1
        public const int MDM_PIAFS_OUTGOING = 1;

        /// MDM_PIAFS_INCOMING -> 0
        public const int MDM_PIAFS_INCOMING = 0;

        /// MDM_MASK_X75_DATA -> 0x7
        public const int MDM_MASK_X75_DATA = 7;

        /// MDM_MASK_V120_SPEED -> 0x7
        public const int MDM_MASK_V120_SPEED = 7;

        /// MDM_MASK_V120_ML -> (0x3<<6)
        public const int MDM_MASK_V120_ML = (3) << (6);

        /// MDM_MASK_V110_SPEED -> 0xf
        public const int MDM_MASK_V110_SPEED = 15;

        /// MDM_MASK_PROTOCOLINFO -> (MDM_MASK_PROTOCOLID|MDM_MASK_PROTOCOLDATA)
        public const int MDM_MASK_PROTOCOLINFO = (NativeConstants.MDM_MASK_PROTOCOLID | NativeConstants.MDM_MASK_PROTOCOLDATA);

        /// MDM_MASK_PROTOCOLID -> 0x000f0000
        public const int MDM_MASK_PROTOCOLID = 983040;

        /// MDM_MASK_PROTOCOLDATA -> 0x0ff00000
        public const int MDM_MASK_PROTOCOLDATA = 267386880;

        /// MDM_MASK_HDLCPPP_SPEED -> 0x7
        public const int MDM_MASK_HDLCPPP_SPEED = 7;

        /// MDM_MASK_HDLCPPP_ML -> (0x3<<6)
        public const int MDM_MASK_HDLCPPP_ML = (3) << (6);

        /// MDM_MASK_HDLCPPP_AUTH -> (0x7<<3)
        public const int MDM_MASK_HDLCPPP_AUTH = (7) << (3);

        /// MDM_MASK_EXTENDEDINFO -> (MDM_MASK_BEARERMODE|MDM_MASK_PROTOCOLINFO)
        public const int MDM_MASK_EXTENDEDINFO = (NativeConstants.MDM_MASK_BEARERMODE | NativeConstants.MDM_MASK_PROTOCOLINFO);

        /// MDM_MASK_BEARERMODE -> 0x0000f000
        public const int MDM_MASK_BEARERMODE = 61440;

        /// MDM_MASK_AUTO_SPEED -> 0x7
        public const int MDM_MASK_AUTO_SPEED = 7;

        /// MDM_MASK_AUTO_ML -> (0x3<<6)
        public const int MDM_MASK_AUTO_ML = (3) << (6);

        /// MDM_HDLCPPP_SPEED_DEFAULT -> 0x0
        public const int MDM_HDLCPPP_SPEED_DEFAULT = 0;

        /// MDM_HDLCPPP_SPEED_64K -> 0x1
        public const int MDM_HDLCPPP_SPEED_64K = 1;

        /// MDM_HDLCPPP_SPEED_56K -> 0x2
        public const int MDM_HDLCPPP_SPEED_56K = 2;

        /// MDM_HDLCPPP_ML_NONE -> 0x1
        public const int MDM_HDLCPPP_ML_NONE = 1;

        /// MDM_HDLCPPP_ML_DEFAULT -> 0x0
        public const int MDM_HDLCPPP_ML_DEFAULT = 0;

        /// MDM_HDLCPPP_ML_2 -> 0x2
        public const int MDM_HDLCPPP_ML_2 = 2;

        /// MDM_HDLCPPP_AUTH_PAP -> 0x2
        public const int MDM_HDLCPPP_AUTH_PAP = 2;

        /// MDM_HDLCPPP_AUTH_NONE -> 0x1
        public const int MDM_HDLCPPP_AUTH_NONE = 1;

        /// MDM_HDLCPPP_AUTH_MSCHAP -> 0x4
        public const int MDM_HDLCPPP_AUTH_MSCHAP = 4;

        /// MDM_HDLCPPP_AUTH_DEFAULT -> 0x0
        public const int MDM_HDLCPPP_AUTH_DEFAULT = 0;

        /// MDM_HDLCPPP_AUTH_CHAP -> 0x3
        public const int MDM_HDLCPPP_AUTH_CHAP = 3;

        /// MDM_FORCED_EC -> 0x00000004
        public const int MDM_FORCED_EC = 4;

        /// MDM_FLOWCONTROL_SOFT -> 0x00000020
        public const int MDM_FLOWCONTROL_SOFT = 32;

        /// MDM_FLOWCONTROL_HARD -> 0x00000010
        public const int MDM_FLOWCONTROL_HARD = 16;

        /// MDM_ERROR_CONTROL -> 0x00000002
        public const int MDM_ERROR_CONTROL = 2;

        /// MDM_DIAGNOSTICS -> 0x00000800
        public const int MDM_DIAGNOSTICS = 2048;

        /// MDM_COMPRESSION -> 0x00000001
        public const int MDM_COMPRESSION = 1;

        /// MDM_CELLULAR -> 0x00000008
        public const int MDM_CELLULAR = 8;

        /// MDM_CCITT_OVERRIDE -> 0x00000040
        public const int MDM_CCITT_OVERRIDE = 64;

        /// MDM_BLIND_DIAL -> 0x00000200
        public const int MDM_BLIND_DIAL = 512;

        /// MDM_BEARERMODE_ISDN -> 0x1
        public const int MDM_BEARERMODE_ISDN = 1;

        /// MDM_BEARERMODE_GSM -> 0x2
        public const int MDM_BEARERMODE_GSM = 2;

        /// MDM_BEARERMODE_ANALOG -> 0x0
        public const int MDM_BEARERMODE_ANALOG = 0;

        /// MDM_AUTO_SPEED_DEFAULT -> 0x0
        public const int MDM_AUTO_SPEED_DEFAULT = 0;

        /// MDM_AUTO_ML_NONE -> 0x1
        public const int MDM_AUTO_ML_NONE = 1;

        /// MDM_AUTO_ML_DEFAULT -> 0x0
        public const int MDM_AUTO_ML_DEFAULT = 0;

        /// MDM_AUTO_ML_2 -> 0x2
        public const int MDM_AUTO_ML_2 = 2;

        /// MDM_ANALOG_V34 -> 0x2
        public const int MDM_ANALOG_V34 = 2;

        /// MDM_ANALOG_RLP_ON -> 0x0
        public const int MDM_ANALOG_RLP_ON = 0;

        /// MDM_ANALOG_RLP_OFF -> 0x1
        public const int MDM_ANALOG_RLP_OFF = 1;

        /// MDMVOL_MEDIUM -> 0x00000001
        public const int MDMVOL_MEDIUM = 1;

        /// MDMVOL_LOW -> 0x00000000
        public const int MDMVOL_LOW = 0;

        /// MDMVOL_HIGH -> 0x00000002
        public const int MDMVOL_HIGH = 2;

        /// MDMVOLFLAG_MEDIUM -> 0x00000002
        public const int MDMVOLFLAG_MEDIUM = 2;

        /// MDMVOLFLAG_LOW -> 0x00000001
        public const int MDMVOLFLAG_LOW = 1;

        /// MDMVOLFLAG_HIGH -> 0x00000004
        public const int MDMVOLFLAG_HIGH = 4;

        /// MDMSPKR_ON -> 0x00000002
        public const int MDMSPKR_ON = 2;

        /// MDMSPKR_OFF -> 0x00000000
        public const int MDMSPKR_OFF = 0;

        /// MDMSPKR_DIAL -> 0x00000001
        public const int MDMSPKR_DIAL = 1;

        /// MDMSPKR_CALLSETUP -> 0x00000003
        public const int MDMSPKR_CALLSETUP = 3;

        /// MDMSPKRFLAG_ON -> 0x00000004
        public const int MDMSPKRFLAG_ON = 4;

        /// MDMSPKRFLAG_OFF -> 0x00000001
        public const int MDMSPKRFLAG_OFF = 1;

        /// MDMSPKRFLAG_DIAL -> 0x00000002
        public const int MDMSPKRFLAG_DIAL = 2;

        /// MDMSPKRFLAG_CALLSETUP -> 0x00000008
        public const int MDMSPKRFLAG_CALLSETUP = 8;

        /// MDITILE_ZORDER -> 0x0004
        public const int MDITILE_ZORDER = 4;

        /// MDITILE_VERTICAL -> 0x0000
        public const int MDITILE_VERTICAL = 0;

        /// MDITILE_SKIPDISABLED -> 0x0002
        public const int MDITILE_SKIPDISABLED = 2;

        /// MDITILE_HORIZONTAL -> 0x0001
        public const int MDITILE_HORIZONTAL = 1;

        /// MDIS_ALLCHILDSTYLES -> 0x0001
        public const int MDIS_ALLCHILDSTYLES = 1;

        /// MCI_WINDOW -> 0x0841
        public const int MCI_WINDOW = 2113;

        /// MCI_WHERE -> 0x0843
        public const int MCI_WHERE = 2115;

        /// MCI_WAVE_STATUS_SAMPLESPERSEC -> 0x00004003L
        public const int MCI_WAVE_STATUS_SAMPLESPERSEC = 16387;

        /// MCI_WAVE_STATUS_LEVEL -> 0x00004007L
        public const int MCI_WAVE_STATUS_LEVEL = 16391;

        /// MCI_WAVE_STATUS_FORMATTAG -> 0x00004001L
        public const int MCI_WAVE_STATUS_FORMATTAG = 16385;

        /// MCI_WAVE_STATUS_CHANNELS -> 0x00004002L
        public const int MCI_WAVE_STATUS_CHANNELS = 16386;

        /// MCI_WAVE_STATUS_BLOCKALIGN -> 0x00004005L
        public const int MCI_WAVE_STATUS_BLOCKALIGN = 16389;

        /// MCI_WAVE_STATUS_BITSPERSAMPLE -> 0x00004006L
        public const int MCI_WAVE_STATUS_BITSPERSAMPLE = 16390;

        /// MCI_WAVE_STATUS_AVGBYTESPERSEC -> 0x00004004L
        public const int MCI_WAVE_STATUS_AVGBYTESPERSEC = 16388;

        /// MCI_WAVE_SET_SAMPLESPERSEC -> 0x00040000L
        public const int MCI_WAVE_SET_SAMPLESPERSEC = 262144;

        /// MCI_WAVE_SET_FORMATTAG -> 0x00010000L
        public const int MCI_WAVE_SET_FORMATTAG = 65536;

        /// MCI_WAVE_SET_CHANNELS -> 0x00020000L
        public const int MCI_WAVE_SET_CHANNELS = 131072;

        /// MCI_WAVE_SET_BLOCKALIGN -> 0x00100000L
        public const int MCI_WAVE_SET_BLOCKALIGN = 1048576;

        /// MCI_WAVE_SET_BITSPERSAMPLE -> 0x00200000L
        public const int MCI_WAVE_SET_BITSPERSAMPLE = 2097152;

        /// MCI_WAVE_SET_AVGBYTESPERSEC -> 0x00080000L
        public const int MCI_WAVE_SET_AVGBYTESPERSEC = 524288;

        /// MCI_WAVE_SET_ANYOUTPUT -> 0x08000000L
        public const int MCI_WAVE_SET_ANYOUTPUT = 134217728;

        /// MCI_WAVE_SET_ANYINPUT -> 0x04000000L
        public const int MCI_WAVE_SET_ANYINPUT = 67108864;

        /// MCI_WAVE_PCM -> (MCI_WAVE_OFFSET + 0)
        public const int MCI_WAVE_PCM = (NativeConstants.MCI_WAVE_OFFSET + 0);

        /// MCI_WAVE_OUTPUT -> 0x00800000L
        public const int MCI_WAVE_OUTPUT = 8388608;

        /// MCI_WAVE_OPEN_BUFFER -> 0x00010000L
        public const int MCI_WAVE_OPEN_BUFFER = 65536;

        /// MCI_WAVE_OFFSET -> 1152
        public const int MCI_WAVE_OFFSET = 1152;

        /// MCI_WAVE_MAPPER -> (MCI_WAVE_OFFSET + 1)
        public const int MCI_WAVE_MAPPER = (NativeConstants.MCI_WAVE_OFFSET + 1);

        /// MCI_WAVE_INPUT -> 0x00400000L
        public const int MCI_WAVE_INPUT = 4194304;

        /// MCI_WAVE_GETDEVCAPS_OUTPUTS -> 0x00004002L
        public const int MCI_WAVE_GETDEVCAPS_OUTPUTS = 16386;

        /// MCI_WAVE_GETDEVCAPS_INPUTS -> 0x00004001L
        public const int MCI_WAVE_GETDEVCAPS_INPUTS = 16385;

        /// MCI_WAIT -> 0x00000002L
        public const int MCI_WAIT = 2;

        /// MCI_VD_STEP_REVERSE -> 0x00020000L
        public const int MCI_VD_STEP_REVERSE = 131072;

        /// MCI_VD_STEP_FRAMES -> 0x00010000L
        public const int MCI_VD_STEP_FRAMES = 65536;

        /// MCI_VD_STATUS_SPEED -> 0x00004002L
        public const int MCI_VD_STATUS_SPEED = 16386;

        /// MCI_VD_STATUS_SIDE -> 0x00004005L
        public const int MCI_VD_STATUS_SIDE = 16389;

        /// MCI_VD_STATUS_MEDIA_TYPE -> 0x00004004L
        public const int MCI_VD_STATUS_MEDIA_TYPE = 16388;

        /// MCI_VD_STATUS_FORWARD -> 0x00004003L
        public const int MCI_VD_STATUS_FORWARD = 16387;

        /// MCI_VD_STATUS_DISC_SIZE -> 0x00004006L
        public const int MCI_VD_STATUS_DISC_SIZE = 16390;

        /// MCI_VD_SPIN_UP -> 0x00010000L
        public const int MCI_VD_SPIN_UP = 65536;

        /// MCI_VD_SPIN_DOWN -> 0x00020000L
        public const int MCI_VD_SPIN_DOWN = 131072;

        /// MCI_VD_SEEK_REVERSE -> 0x00010000L
        public const int MCI_VD_SEEK_REVERSE = 65536;

        /// MCI_VD_PLAY_SPEED -> 0x00040000L
        public const int MCI_VD_PLAY_SPEED = 262144;

        /// MCI_VD_PLAY_SLOW -> 0x00100000L
        public const int MCI_VD_PLAY_SLOW = 1048576;

        /// MCI_VD_PLAY_SCAN -> 0x00080000L
        public const int MCI_VD_PLAY_SCAN = 524288;

        /// MCI_VD_PLAY_REVERSE -> 0x00010000L
        public const int MCI_VD_PLAY_REVERSE = 65536;

        /// MCI_VD_PLAY_FAST -> 0x00020000L
        public const int MCI_VD_PLAY_FAST = 131072;

        /// MCI_VD_OFFSET -> 1024
        public const int MCI_VD_OFFSET = 1024;

        /// MCI_VD_MODE_PARK -> (MCI_VD_OFFSET + 1)
        public const int MCI_VD_MODE_PARK = (NativeConstants.MCI_VD_OFFSET + 1);

        /// MCI_VD_MEDIA_OTHER -> (MCI_VD_OFFSET + 4)
        public const int MCI_VD_MEDIA_OTHER = (NativeConstants.MCI_VD_OFFSET + 4);

        /// MCI_VD_MEDIA_CLV -> (MCI_VD_OFFSET + 2)
        public const int MCI_VD_MEDIA_CLV = (NativeConstants.MCI_VD_OFFSET + 2);

        /// MCI_VD_MEDIA_CAV -> (MCI_VD_OFFSET + 3)
        public const int MCI_VD_MEDIA_CAV = (NativeConstants.MCI_VD_OFFSET + 3);

        /// MCI_VD_GETDEVCAPS_SLOW_RATE -> 0x00004004L
        public const int MCI_VD_GETDEVCAPS_SLOW_RATE = 16388;

        /// MCI_VD_GETDEVCAPS_NORMAL_RATE -> 0x00004005L
        public const int MCI_VD_GETDEVCAPS_NORMAL_RATE = 16389;

        /// MCI_VD_GETDEVCAPS_FAST_RATE -> 0x00004003L
        public const int MCI_VD_GETDEVCAPS_FAST_RATE = 16387;

        /// MCI_VD_GETDEVCAPS_CLV -> 0x00010000L
        public const int MCI_VD_GETDEVCAPS_CLV = 65536;

        /// MCI_VD_GETDEVCAPS_CAV -> 0x00020000L
        public const int MCI_VD_GETDEVCAPS_CAV = 131072;

        /// MCI_VD_GETDEVCAPS_CAN_REVERSE -> 0x00004002L
        public const int MCI_VD_GETDEVCAPS_CAN_REVERSE = 16386;

        /// MCI_VD_FORMAT_TRACK -> 0x4001
        public const int MCI_VD_FORMAT_TRACK = 16385;

        /// MCI_VD_ESCAPE_STRING -> 0x00000100L
        public const int MCI_VD_ESCAPE_STRING = 256;

        /// MCI_USER_MESSAGES -> (DRV_MCI_FIRST + 0x400)
        public const int MCI_USER_MESSAGES = (NativeConstants.DRV_MCI_FIRST + 1024);

        /// MCI_UPDATE -> 0x0854
        public const int MCI_UPDATE = 2132;

        /// MCI_UNFREEZE -> 0x0845
        public const int MCI_UNFREEZE = 2117;

        /// MCI_TRACK -> 0x00000010L
        public const int MCI_TRACK = 16;

        /// MCI_TO -> 0x00000008L
        public const int MCI_TO = 8;

        /// MCI_SYSINFO_QUANTITY -> 0x00000100L
        public const int MCI_SYSINFO_QUANTITY = 256;

        /// MCI_SYSINFO_OPEN -> 0x00000200L
        public const int MCI_SYSINFO_OPEN = 512;

        /// MCI_SYSINFO_NAME -> 0x00000400L
        public const int MCI_SYSINFO_NAME = 1024;

        /// MCI_SYSINFO_INSTALLNAME -> 0x00000800L
        public const int MCI_SYSINFO_INSTALLNAME = 2048;

        /// MCI_SYSINFO -> 0x0810
        public const int MCI_SYSINFO = 2064;

        /// MCI_STRING_OFFSET -> 512
        public const int MCI_STRING_OFFSET = 512;

        /// MCI_STOP -> 0x0808
        public const int MCI_STOP = 2056;

        /// MCI_STEP -> 0x080E
        public const int MCI_STEP = 2062;

        /// MCI_STATUS_TIME_FORMAT -> 0x00000006L
        public const int MCI_STATUS_TIME_FORMAT = 6;

        /// MCI_STATUS_START -> 0x00000200L
        public const int MCI_STATUS_START = 512;

        /// MCI_STATUS_READY -> 0x00000007L
        public const int MCI_STATUS_READY = 7;

        /// MCI_STATUS_POSITION -> 0x00000002L
        public const int MCI_STATUS_POSITION = 2;

        /// MCI_STATUS_NUMBER_OF_TRACKS -> 0x00000003L
        public const int MCI_STATUS_NUMBER_OF_TRACKS = 3;

        /// MCI_STATUS_MODE -> 0x00000004L
        public const int MCI_STATUS_MODE = 4;

        /// MCI_STATUS_MEDIA_PRESENT -> 0x00000005L
        public const int MCI_STATUS_MEDIA_PRESENT = 5;

        /// MCI_STATUS_LENGTH -> 0x00000001L
        public const int MCI_STATUS_LENGTH = 1;

        /// MCI_STATUS_ITEM -> 0x00000100L
        public const int MCI_STATUS_ITEM = 256;

        /// MCI_STATUS_CURRENT_TRACK -> 0x00000008L
        public const int MCI_STATUS_CURRENT_TRACK = 8;

        /// MCI_STATUS -> 0x0814
        public const int MCI_STATUS = 2068;

        /// MCI_SPIN -> 0x080C
        public const int MCI_SPIN = 2060;

        /// MCI_SET_VIDEO -> 0x00001000L
        public const int MCI_SET_VIDEO = 4096;

        /// MCI_SET_TIME_FORMAT -> 0x00000400L
        public const int MCI_SET_TIME_FORMAT = 1024;

        /// MCI_SET_ON -> 0x00002000L
        public const int MCI_SET_ON = 8192;

        /// MCI_SET_OFF -> 0x00004000L
        public const int MCI_SET_OFF = 16384;

        /// MCI_SET_DOOR_OPEN -> 0x00000100L
        public const int MCI_SET_DOOR_OPEN = 256;

        /// MCI_SET_DOOR_CLOSED -> 0x00000200L
        public const int MCI_SET_DOOR_CLOSED = 512;

        /// MCI_SET_AUDIO_RIGHT -> 0x00000002L
        public const int MCI_SET_AUDIO_RIGHT = 2;

        /// MCI_SET_AUDIO_LEFT -> 0x00000001L
        public const int MCI_SET_AUDIO_LEFT = 1;

        /// MCI_SET_AUDIO_ALL -> 0x00000000L
        public const int MCI_SET_AUDIO_ALL = 0;

        /// MCI_SET_AUDIO -> 0x00000800L
        public const int MCI_SET_AUDIO = 2048;

        /// MCI_SET -> 0x080D
        public const int MCI_SET = 2061;

        /// MCI_SEQ_STATUS_TEMPO -> 0x00004002L
        public const int MCI_SEQ_STATUS_TEMPO = 16386;

        /// MCI_SEQ_STATUS_SLAVE -> 0x00004007L
        public const int MCI_SEQ_STATUS_SLAVE = 16391;

        /// MCI_SEQ_STATUS_PORT -> 0x00004003L
        public const int MCI_SEQ_STATUS_PORT = 16387;

        /// MCI_SEQ_STATUS_OFFSET -> 0x00004009L
        public const int MCI_SEQ_STATUS_OFFSET = 16393;

        /// MCI_SEQ_STATUS_NAME -> 0x0000400BL
        public const int MCI_SEQ_STATUS_NAME = 16395;

        /// MCI_SEQ_STATUS_MASTER -> 0x00004008L
        public const int MCI_SEQ_STATUS_MASTER = 16392;

        /// MCI_SEQ_STATUS_DIVTYPE -> 0x0000400AL
        public const int MCI_SEQ_STATUS_DIVTYPE = 16394;

        /// MCI_SEQ_STATUS_COPYRIGHT -> 0x0000400CL
        public const int MCI_SEQ_STATUS_COPYRIGHT = 16396;

        /// MCI_SEQ_SMPTE -> 0x4004
        public const int MCI_SEQ_SMPTE = 16388;

        /// MCI_SEQ_SET_TEMPO -> 0x00010000L
        public const int MCI_SEQ_SET_TEMPO = 65536;

        /// MCI_SEQ_SET_SLAVE -> 0x00040000L
        public const int MCI_SEQ_SET_SLAVE = 262144;

        /// MCI_SEQ_SET_PORT -> 0x00020000L
        public const int MCI_SEQ_SET_PORT = 131072;

        /// MCI_SEQ_SET_OFFSET -> 0x01000000L
        public const int MCI_SEQ_SET_OFFSET = 16777216;

        /// MCI_SEQ_SET_MASTER -> 0x00080000L
        public const int MCI_SEQ_SET_MASTER = 524288;

        /// MCI_SEQ_OFFSET -> 1216
        public const int MCI_SEQ_OFFSET = 1216;

        /// MCI_SEQ_NONE -> 65533
        public const int MCI_SEQ_NONE = 65533;

        /// MCI_SEQ_MIDI -> 0x4003
        public const int MCI_SEQ_MIDI = 16387;

        /// MCI_SEQ_MAPPER -> 65535
        public const int MCI_SEQ_MAPPER = 65535;

        /// MCI_SEQ_FORMAT_SONGPTR -> 0x4001
        public const int MCI_SEQ_FORMAT_SONGPTR = 16385;

        /// MCI_SEQ_FILE -> 0x4002
        public const int MCI_SEQ_FILE = 16386;

        /// MCI_SEQ_DIV_SMPTE_30DROP -> (3 + MCI_SEQ_OFFSET)
        public const int MCI_SEQ_DIV_SMPTE_30DROP = (3 + NativeConstants.MCI_SEQ_OFFSET);

        /// MCI_SEQ_DIV_SMPTE_30 -> (4 + MCI_SEQ_OFFSET)
        public const int MCI_SEQ_DIV_SMPTE_30 = (4 + NativeConstants.MCI_SEQ_OFFSET);

        /// MCI_SEQ_DIV_SMPTE_25 -> (2 + MCI_SEQ_OFFSET)
        public const int MCI_SEQ_DIV_SMPTE_25 = (2 + NativeConstants.MCI_SEQ_OFFSET);

        /// MCI_SEQ_DIV_SMPTE_24 -> (1 + MCI_SEQ_OFFSET)
        public const int MCI_SEQ_DIV_SMPTE_24 = (1 + NativeConstants.MCI_SEQ_OFFSET);

        /// MCI_SEQ_DIV_PPQN -> (0 + MCI_SEQ_OFFSET)
        public const int MCI_SEQ_DIV_PPQN = (0 + NativeConstants.MCI_SEQ_OFFSET);

        /// MCI_SEEK_TO_START -> 0x00000100L
        public const int MCI_SEEK_TO_START = 256;

        /// MCI_SEEK_TO_END -> 0x00000200L
        public const int MCI_SEEK_TO_END = 512;

        /// MCI_SEEK -> 0x0807
        public const int MCI_SEEK = 2055;

        /// MCI_SAVE_FILE -> 0x00000100L
        public const int MCI_SAVE_FILE = 256;

        /// MCI_SAVE -> 0x0813
        public const int MCI_SAVE = 2067;

        /// MCI_RESUME -> 0x0855
        public const int MCI_RESUME = 2133;

        /// MCI_RECORD_OVERWRITE -> 0x00000200L
        public const int MCI_RECORD_OVERWRITE = 512;

        /// MCI_RECORD_INSERT -> 0x00000100L
        public const int MCI_RECORD_INSERT = 256;

        /// MCI_RECORD -> 0x080F
        public const int MCI_RECORD = 2063;

        /// MCI_REALIZE -> 0x0840
        public const int MCI_REALIZE = 2112;

        /// MCI_PUT -> 0x0842
        public const int MCI_PUT = 2114;

        /// MCI_PLAY -> 0x0806
        public const int MCI_PLAY = 2054;

        /// MCI_PAUSE -> 0x0809
        public const int MCI_PAUSE = 2057;

        /// MCI_PASTE -> 0x0853
        public const int MCI_PASTE = 2131;

        /// MCI_OVLY_WINDOW_TEXT -> 0x00080000L
        public const int MCI_OVLY_WINDOW_TEXT = 524288;

        /// MCI_OVLY_WINDOW_STATE -> 0x00040000L
        public const int MCI_OVLY_WINDOW_STATE = 262144;

        /// MCI_OVLY_WINDOW_HWND -> 0x00010000L
        public const int MCI_OVLY_WINDOW_HWND = 65536;

        /// MCI_OVLY_WINDOW_ENABLE_STRETCH -> 0x00100000L
        public const int MCI_OVLY_WINDOW_ENABLE_STRETCH = 1048576;

        /// MCI_OVLY_WINDOW_DISABLE_STRETCH -> 0x00200000L
        public const int MCI_OVLY_WINDOW_DISABLE_STRETCH = 2097152;

        /// MCI_OVLY_WINDOW_DEFAULT -> 0x00000000L
        public const int MCI_OVLY_WINDOW_DEFAULT = 0;

        /// MCI_OVLY_WHERE_VIDEO -> 0x00100000L
        public const int MCI_OVLY_WHERE_VIDEO = 1048576;

        /// MCI_OVLY_WHERE_SOURCE -> 0x00020000L
        public const int MCI_OVLY_WHERE_SOURCE = 131072;

        /// MCI_OVLY_WHERE_FRAME -> 0x00080000L
        public const int MCI_OVLY_WHERE_FRAME = 524288;

        /// MCI_OVLY_WHERE_DESTINATION -> 0x00040000L
        public const int MCI_OVLY_WHERE_DESTINATION = 262144;

        /// MCI_OVLY_STATUS_STRETCH -> 0x00004002L
        public const int MCI_OVLY_STATUS_STRETCH = 16386;

        /// MCI_OVLY_STATUS_HWND -> 0x00004001L
        public const int MCI_OVLY_STATUS_HWND = 16385;

        /// MCI_OVLY_RECT -> 0x00010000L
        public const int MCI_OVLY_RECT = 65536;

        /// MCI_OVLY_PUT_VIDEO -> 0x00100000L
        public const int MCI_OVLY_PUT_VIDEO = 1048576;

        /// MCI_OVLY_PUT_SOURCE -> 0x00020000L
        public const int MCI_OVLY_PUT_SOURCE = 131072;

        /// MCI_OVLY_PUT_FRAME -> 0x00080000L
        public const int MCI_OVLY_PUT_FRAME = 524288;

        /// MCI_OVLY_PUT_DESTINATION -> 0x00040000L
        public const int MCI_OVLY_PUT_DESTINATION = 262144;

        /// MCI_OVLY_OPEN_WS -> 0x00010000L
        public const int MCI_OVLY_OPEN_WS = 65536;

        /// MCI_OVLY_OPEN_PARENT -> 0x00020000L
        public const int MCI_OVLY_OPEN_PARENT = 131072;

        /// MCI_OVLY_INFO_TEXT -> 0x00010000L
        public const int MCI_OVLY_INFO_TEXT = 65536;

        /// MCI_OVLY_GETDEVCAPS_MAX_WINDOWS -> 0x00004003L
        public const int MCI_OVLY_GETDEVCAPS_MAX_WINDOWS = 16387;

        /// MCI_OVLY_GETDEVCAPS_CAN_STRETCH -> 0x00004001L
        public const int MCI_OVLY_GETDEVCAPS_CAN_STRETCH = 16385;

        /// MCI_OVLY_GETDEVCAPS_CAN_FREEZE -> 0x00004002L
        public const int MCI_OVLY_GETDEVCAPS_CAN_FREEZE = 16386;

        /// MCI_OPEN_TYPE_ID -> 0x00001000L
        public const int MCI_OPEN_TYPE_ID = 4096;

        /// MCI_OPEN_TYPE -> 0x00002000L
        public const int MCI_OPEN_TYPE = 8192;

        /// MCI_OPEN_SHAREABLE -> 0x00000100L
        public const int MCI_OPEN_SHAREABLE = 256;

        /// MCI_OPEN_ELEMENT_ID -> 0x00000800L
        public const int MCI_OPEN_ELEMENT_ID = 2048;

        /// MCI_OPEN_ELEMENT -> 0x00000200L
        public const int MCI_OPEN_ELEMENT = 512;

        /// MCI_OPEN_ALIAS -> 0x00000400L
        public const int MCI_OPEN_ALIAS = 1024;

        /// MCI_OPEN -> 0x0803
        public const int MCI_OPEN = 2051;

        /// MCI_NOTIFY_SUPERSEDED -> 0x0002
        public const int MCI_NOTIFY_SUPERSEDED = 2;

        /// MCI_NOTIFY_SUCCESSFUL -> 0x0001
        public const int MCI_NOTIFY_SUCCESSFUL = 1;

        /// MCI_NOTIFY_FAILURE -> 0x0008
        public const int MCI_NOTIFY_FAILURE = 8;

        /// MCI_NOTIFY_ABORTED -> 0x0004
        public const int MCI_NOTIFY_ABORTED = 4;

        /// MCI_NOTIFY -> 0x00000001L
        public const int MCI_NOTIFY = 1;

        /// MCI_MODE_STOP -> (MCI_STRING_OFFSET + 13)
        public const int MCI_MODE_STOP = (NativeConstants.MCI_STRING_OFFSET + 13);

        /// MCI_MODE_SEEK -> (MCI_STRING_OFFSET + 16)
        public const int MCI_MODE_SEEK = (NativeConstants.MCI_STRING_OFFSET + 16);

        /// MCI_MODE_RECORD -> (MCI_STRING_OFFSET + 15)
        public const int MCI_MODE_RECORD = (NativeConstants.MCI_STRING_OFFSET + 15);

        /// MCI_MODE_PLAY -> (MCI_STRING_OFFSET + 14)
        public const int MCI_MODE_PLAY = (NativeConstants.MCI_STRING_OFFSET + 14);

        /// MCI_MODE_PAUSE -> (MCI_STRING_OFFSET + 17)
        public const int MCI_MODE_PAUSE = (NativeConstants.MCI_STRING_OFFSET + 17);

        /// MCI_MODE_OPEN -> (MCI_STRING_OFFSET + 18)
        public const int MCI_MODE_OPEN = (NativeConstants.MCI_STRING_OFFSET + 18);

        /// MCI_MODE_NOT_READY -> (MCI_STRING_OFFSET + 12)
        public const int MCI_MODE_NOT_READY = (NativeConstants.MCI_STRING_OFFSET + 12);

        /// MCI_LOAD_FILE -> 0x00000100L
        public const int MCI_LOAD_FILE = 256;

        /// MCI_LOAD -> 0x0850
        public const int MCI_LOAD = 2128;

        /// MCI_LAST -> 0x0FFF
        public const int MCI_LAST = 4095;

        /// MCI_INFO_PRODUCT -> 0x00000100L
        public const int MCI_INFO_PRODUCT = 256;

        /// MCI_INFO_NAME -> 0x00001000L
        public const int MCI_INFO_NAME = 4096;

        /// MCI_INFO_MEDIA_UPC -> 0x00000400L
        public const int MCI_INFO_MEDIA_UPC = 1024;

        /// MCI_INFO_MEDIA_IDENTITY -> 0x00000800L
        public const int MCI_INFO_MEDIA_IDENTITY = 2048;

        /// MCI_INFO_FILE -> 0x00000200L
        public const int MCI_INFO_FILE = 512;

        /// MCI_INFO_COPYRIGHT -> 0x00002000L
        public const int MCI_INFO_COPYRIGHT = 8192;

        /// MCI_INFO -> 0x080A
        public const int MCI_INFO = 2058;

        /// MCI_GETDEVCAPS_USES_FILES -> 0x00000005L
        public const int MCI_GETDEVCAPS_USES_FILES = 5;

        /// MCI_GETDEVCAPS_ITEM -> 0x00000100L
        public const int MCI_GETDEVCAPS_ITEM = 256;

        /// MCI_GETDEVCAPS_HAS_VIDEO -> 0x00000003L
        public const int MCI_GETDEVCAPS_HAS_VIDEO = 3;

        /// MCI_GETDEVCAPS_HAS_AUDIO -> 0x00000002L
        public const int MCI_GETDEVCAPS_HAS_AUDIO = 2;

        /// MCI_GETDEVCAPS_DEVICE_TYPE -> 0x00000004L
        public const int MCI_GETDEVCAPS_DEVICE_TYPE = 4;

        /// MCI_GETDEVCAPS_COMPOUND_DEVICE -> 0x00000006L
        public const int MCI_GETDEVCAPS_COMPOUND_DEVICE = 6;

        /// MCI_GETDEVCAPS_CAN_SAVE -> 0x00000009L
        public const int MCI_GETDEVCAPS_CAN_SAVE = 9;

        /// MCI_GETDEVCAPS_CAN_RECORD -> 0x00000001L
        public const int MCI_GETDEVCAPS_CAN_RECORD = 1;

        /// MCI_GETDEVCAPS_CAN_PLAY -> 0x00000008L
        public const int MCI_GETDEVCAPS_CAN_PLAY = 8;

        /// MCI_GETDEVCAPS_CAN_EJECT -> 0x00000007L
        public const int MCI_GETDEVCAPS_CAN_EJECT = 7;

        /// MCI_GETDEVCAPS -> 0x080B
        public const int MCI_GETDEVCAPS = 2059;

        /// MCI_FROM -> 0x00000004L
        public const int MCI_FROM = 4;

        /// MCI_FREEZE -> 0x0844
        public const int MCI_FREEZE = 2116;

        /// MCI_FORMAT_TMSF -> 10
        public const int MCI_FORMAT_TMSF = 10;

        /// MCI_FORMAT_SMPTE_30DROP -> 7
        public const int MCI_FORMAT_SMPTE_30DROP = 7;

        /// MCI_FORMAT_SMPTE_30 -> 6
        public const int MCI_FORMAT_SMPTE_30 = 6;

        /// MCI_FORMAT_SMPTE_25 -> 5
        public const int MCI_FORMAT_SMPTE_25 = 5;

        /// MCI_FORMAT_SMPTE_24 -> 4
        public const int MCI_FORMAT_SMPTE_24 = 4;

        /// MCI_FORMAT_SAMPLES -> 9
        public const int MCI_FORMAT_SAMPLES = 9;

        /// MCI_FORMAT_MSF -> 2
        public const int MCI_FORMAT_MSF = 2;

        /// MCI_FORMAT_MILLISECONDS -> 0
        public const int MCI_FORMAT_MILLISECONDS = 0;

        /// MCI_FORMAT_HMS -> 1
        public const int MCI_FORMAT_HMS = 1;

        /// MCI_FORMAT_FRAMES -> 3
        public const int MCI_FORMAT_FRAMES = 3;

        /// MCI_FORMAT_BYTES -> 8
        public const int MCI_FORMAT_BYTES = 8;

        /// MCI_FIRST -> DRV_MCI_FIRST
        public const int MCI_FIRST = NativeConstants.DRV_MCI_FIRST;

        /// MCI_ESCAPE -> 0x0805
        public const int MCI_ESCAPE = 2053;

        /// MCI_DEVTYPE_WAVEFORM_AUDIO -> 522
        public const int MCI_DEVTYPE_WAVEFORM_AUDIO = 522;

        /// MCI_DEVTYPE_VIDEODISC -> 514
        public const int MCI_DEVTYPE_VIDEODISC = 514;

        /// MCI_DEVTYPE_VCR -> 513
        public const int MCI_DEVTYPE_VCR = 513;

        /// MCI_DEVTYPE_SEQUENCER -> 523
        public const int MCI_DEVTYPE_SEQUENCER = 523;

        /// MCI_DEVTYPE_SCANNER -> 518
        public const int MCI_DEVTYPE_SCANNER = 518;

        /// MCI_DEVTYPE_OVERLAY -> 515
        public const int MCI_DEVTYPE_OVERLAY = 515;

        /// MCI_DEVTYPE_OTHER -> 521
        public const int MCI_DEVTYPE_OTHER = 521;

        /// MCI_DEVTYPE_LAST -> MCI_DEVTYPE_SEQUENCER
        public const int MCI_DEVTYPE_LAST = NativeConstants.MCI_DEVTYPE_SEQUENCER;

        /// MCI_DEVTYPE_FIRST_USER -> 0x1000
        public const int MCI_DEVTYPE_FIRST_USER = 4096;

        /// MCI_DEVTYPE_FIRST -> MCI_DEVTYPE_VCR
        public const int MCI_DEVTYPE_FIRST = NativeConstants.MCI_DEVTYPE_VCR;

        /// MCI_DEVTYPE_DIGITAL_VIDEO -> 520
        public const int MCI_DEVTYPE_DIGITAL_VIDEO = 520;

        /// MCI_DEVTYPE_DAT -> 517
        public const int MCI_DEVTYPE_DAT = 517;

        /// MCI_DEVTYPE_CD_AUDIO -> 516
        public const int MCI_DEVTYPE_CD_AUDIO = 516;

        /// MCI_DEVTYPE_ANIMATION -> 519
        public const int MCI_DEVTYPE_ANIMATION = 519;

        /// MCI_DELETE -> 0x0856
        public const int MCI_DELETE = 2134;

        /// MCI_CUT -> 0x0851
        public const int MCI_CUT = 2129;

        /// MCI_CUE -> 0x0830
        public const int MCI_CUE = 2096;

        /// MCI_COPY -> 0x0852
        public const int MCI_COPY = 2130;

        /// MCI_CLOSE -> 0x0804
        public const int MCI_CLOSE = 2052;

        /// MCI_CD_OFFSET -> 1088
        public const int MCI_CD_OFFSET = 1088;

        /// MCI_CDA_TRACK_OTHER -> (MCI_CD_OFFSET + 1)
        public const int MCI_CDA_TRACK_OTHER = (NativeConstants.MCI_CD_OFFSET + 1);

        /// MCI_CDA_TRACK_AUDIO -> (MCI_CD_OFFSET + 0)
        public const int MCI_CDA_TRACK_AUDIO = (NativeConstants.MCI_CD_OFFSET + 0);

        /// MCI_CDA_STATUS_TYPE_TRACK -> 0x00004001L
        public const int MCI_CDA_STATUS_TYPE_TRACK = 16385;

        /// MCI_BREAK_OFF -> 0x00000400L
        public const int MCI_BREAK_OFF = 1024;

        /// MCI_BREAK_KEY -> 0x00000100L
        public const int MCI_BREAK_KEY = 256;

        /// MCI_BREAK_HWND -> 0x00000200L
        public const int MCI_BREAK_HWND = 512;

        /// MCI_BREAK -> 0x0811
        public const int MCI_BREAK = 2065;

        /// MCI_ANIM_WINDOW_TEXT -> 0x00080000L
        public const int MCI_ANIM_WINDOW_TEXT = 524288;

        /// MCI_ANIM_WINDOW_STATE -> 0x00040000L
        public const int MCI_ANIM_WINDOW_STATE = 262144;

        /// MCI_ANIM_WINDOW_HWND -> 0x00010000L
        public const int MCI_ANIM_WINDOW_HWND = 65536;

        /// MCI_ANIM_WINDOW_ENABLE_STRETCH -> 0x00100000L
        public const int MCI_ANIM_WINDOW_ENABLE_STRETCH = 1048576;

        /// MCI_ANIM_WINDOW_DISABLE_STRETCH -> 0x00200000L
        public const int MCI_ANIM_WINDOW_DISABLE_STRETCH = 2097152;

        /// MCI_ANIM_WINDOW_DEFAULT -> 0x00000000L
        public const int MCI_ANIM_WINDOW_DEFAULT = 0;

        /// MCI_ANIM_WHERE_SOURCE -> 0x00020000L
        public const int MCI_ANIM_WHERE_SOURCE = 131072;

        /// MCI_ANIM_WHERE_DESTINATION -> 0x00040000L
        public const int MCI_ANIM_WHERE_DESTINATION = 262144;

        /// MCI_ANIM_UPDATE_HDC -> 0x00020000L
        public const int MCI_ANIM_UPDATE_HDC = 131072;

        /// MCI_ANIM_STEP_REVERSE -> 0x00010000L
        public const int MCI_ANIM_STEP_REVERSE = 65536;

        /// MCI_ANIM_STEP_FRAMES -> 0x00020000L
        public const int MCI_ANIM_STEP_FRAMES = 131072;

        /// MCI_ANIM_STATUS_STRETCH -> 0x00004005L
        public const int MCI_ANIM_STATUS_STRETCH = 16389;

        /// MCI_ANIM_STATUS_SPEED -> 0x00004001L
        public const int MCI_ANIM_STATUS_SPEED = 16385;

        /// MCI_ANIM_STATUS_HWND -> 0x00004003L
        public const int MCI_ANIM_STATUS_HWND = 16387;

        /// MCI_ANIM_STATUS_HPAL -> 0x00004004L
        public const int MCI_ANIM_STATUS_HPAL = 16388;

        /// MCI_ANIM_STATUS_FORWARD -> 0x00004002L
        public const int MCI_ANIM_STATUS_FORWARD = 16386;

        /// MCI_ANIM_RECT -> 0x00010000L
        public const int MCI_ANIM_RECT = 65536;

        /// MCI_ANIM_REALIZE_NORM -> 0x00010000L
        public const int MCI_ANIM_REALIZE_NORM = 65536;

        /// MCI_ANIM_REALIZE_BKGD -> 0x00020000L
        public const int MCI_ANIM_REALIZE_BKGD = 131072;

        /// MCI_ANIM_PUT_SOURCE -> 0x00020000L
        public const int MCI_ANIM_PUT_SOURCE = 131072;

        /// MCI_ANIM_PUT_DESTINATION -> 0x00040000L
        public const int MCI_ANIM_PUT_DESTINATION = 262144;

        /// MCI_ANIM_PLAY_SPEED -> 0x00010000L
        public const int MCI_ANIM_PLAY_SPEED = 65536;

        /// MCI_ANIM_PLAY_SLOW -> 0x00080000L
        public const int MCI_ANIM_PLAY_SLOW = 524288;

        /// MCI_ANIM_PLAY_SCAN -> 0x00100000L
        public const int MCI_ANIM_PLAY_SCAN = 1048576;

        /// MCI_ANIM_PLAY_REVERSE -> 0x00020000L
        public const int MCI_ANIM_PLAY_REVERSE = 131072;

        /// MCI_ANIM_PLAY_FAST -> 0x00040000L
        public const int MCI_ANIM_PLAY_FAST = 262144;

        /// MCI_ANIM_OPEN_WS -> 0x00010000L
        public const int MCI_ANIM_OPEN_WS = 65536;

        /// MCI_ANIM_OPEN_PARENT -> 0x00020000L
        public const int MCI_ANIM_OPEN_PARENT = 131072;

        /// MCI_ANIM_OPEN_NOSTATIC -> 0x00040000L
        public const int MCI_ANIM_OPEN_NOSTATIC = 262144;

        /// MCI_ANIM_INFO_TEXT -> 0x00010000L
        public const int MCI_ANIM_INFO_TEXT = 65536;

        /// MCI_ANIM_GETDEVCAPS_SLOW_RATE -> 0x00004003L
        public const int MCI_ANIM_GETDEVCAPS_SLOW_RATE = 16387;

        /// MCI_ANIM_GETDEVCAPS_PALETTES -> 0x00004006L
        public const int MCI_ANIM_GETDEVCAPS_PALETTES = 16390;

        /// MCI_ANIM_GETDEVCAPS_NORMAL_RATE -> 0x00004004L
        public const int MCI_ANIM_GETDEVCAPS_NORMAL_RATE = 16388;

        /// MCI_ANIM_GETDEVCAPS_MAX_WINDOWS -> 0x00004008L
        public const int MCI_ANIM_GETDEVCAPS_MAX_WINDOWS = 16392;

        /// MCI_ANIM_GETDEVCAPS_FAST_RATE -> 0x00004002L
        public const int MCI_ANIM_GETDEVCAPS_FAST_RATE = 16386;

        /// MCI_ANIM_GETDEVCAPS_CAN_STRETCH -> 0x00004007L
        public const int MCI_ANIM_GETDEVCAPS_CAN_STRETCH = 16391;

        /// MCI_ANIM_GETDEVCAPS_CAN_REVERSE -> 0x00004001L
        public const int MCI_ANIM_GETDEVCAPS_CAN_REVERSE = 16385;

        /// MCI_ALL_DEVICE_ID -> ((MCIDEVICEID)-1)
        /// Error generating expression: Value MCIDEVICEID is not resolved
        public const string MCI_ALL_DEVICE_ID = "((MCIDEVICEID)-1)";

        /// mciSendString -> mciSendStringW
        /// Error generating expression: Value mciSendStringW is not resolved
        public const string mciSendString = "mciSendStringW";

        /// mciSendCommand -> mciSendCommandW
        /// Error generating expression: Value mciSendCommandW is not resolved
        public const string mciSendCommand = "mciSendCommandW";

        /// mciGetErrorString -> mciGetErrorStringW
        /// Error generating expression: Value mciGetErrorStringW is not resolved
        public const string mciGetErrorString = "mciGetErrorStringW";

        /// mciGetDeviceIDFromElementID -> mciGetDeviceIDFromElementIDW
        /// Error generating expression: Value mciGetDeviceIDFromElementIDW is not resolved
        public const string mciGetDeviceIDFromElementID = "mciGetDeviceIDFromElementIDW";

        /// mciGetDeviceID -> mciGetDeviceIDW
        /// Error generating expression: Value mciGetDeviceIDW is not resolved
        public const string mciGetDeviceID = "mciGetDeviceIDW";

        /// MCIERR_WAVE_SETOUTPUTUNSUITABLE -> (MCIERR_BASE + 71)
        public const int MCIERR_WAVE_SETOUTPUTUNSUITABLE = (NativeConstants.MCIERR_BASE + 71);

        /// MCIERR_WAVE_SETOUTPUTINUSE -> (MCIERR_BASE + 65)
        public const int MCIERR_WAVE_SETOUTPUTINUSE = (NativeConstants.MCIERR_BASE + 65);

        /// MCIERR_WAVE_SETINPUTUNSUITABLE -> (MCIERR_BASE + 73)
        public const int MCIERR_WAVE_SETINPUTUNSUITABLE = (NativeConstants.MCIERR_BASE + 73);

        /// MCIERR_WAVE_SETINPUTINUSE -> (MCIERR_BASE + 67)
        public const int MCIERR_WAVE_SETINPUTINUSE = (NativeConstants.MCIERR_BASE + 67);

        /// MCIERR_WAVE_OUTPUTUNSPECIFIED -> (MCIERR_BASE + 68)
        public const int MCIERR_WAVE_OUTPUTUNSPECIFIED = (NativeConstants.MCIERR_BASE + 68);

        /// MCIERR_WAVE_OUTPUTSUNSUITABLE -> (MCIERR_BASE + 70)
        public const int MCIERR_WAVE_OUTPUTSUNSUITABLE = (NativeConstants.MCIERR_BASE + 70);

        /// MCIERR_WAVE_OUTPUTSINUSE -> (MCIERR_BASE + 64)
        public const int MCIERR_WAVE_OUTPUTSINUSE = (NativeConstants.MCIERR_BASE + 64);

        /// MCIERR_WAVE_INPUTUNSPECIFIED -> (MCIERR_BASE + 69)
        public const int MCIERR_WAVE_INPUTUNSPECIFIED = (NativeConstants.MCIERR_BASE + 69);

        /// MCIERR_WAVE_INPUTSUNSUITABLE -> (MCIERR_BASE + 72)
        public const int MCIERR_WAVE_INPUTSUNSUITABLE = (NativeConstants.MCIERR_BASE + 72);

        /// MCIERR_WAVE_INPUTSINUSE -> (MCIERR_BASE + 66)
        public const int MCIERR_WAVE_INPUTSINUSE = (NativeConstants.MCIERR_BASE + 66);

        /// MCIERR_UNSUPPORTED_FUNCTION -> (MCIERR_BASE + 18)
        public const int MCIERR_UNSUPPORTED_FUNCTION = (NativeConstants.MCIERR_BASE + 18);

        /// MCIERR_UNRECOGNIZED_KEYWORD -> (MCIERR_BASE + 3)
        public const int MCIERR_UNRECOGNIZED_KEYWORD = (NativeConstants.MCIERR_BASE + 3);

        /// MCIERR_UNRECOGNIZED_COMMAND -> (MCIERR_BASE + 5)
        public const int MCIERR_UNRECOGNIZED_COMMAND = (NativeConstants.MCIERR_BASE + 5);

        /// MCIERR_UNNAMED_RESOURCE -> (MCIERR_BASE + 42)
        public const int MCIERR_UNNAMED_RESOURCE = (NativeConstants.MCIERR_BASE + 42);

        /// MCIERR_SET_DRIVE -> (MCIERR_BASE + 53)
        public const int MCIERR_SET_DRIVE = (NativeConstants.MCIERR_BASE + 53);

        /// MCIERR_SET_CD -> (MCIERR_BASE + 52)
        public const int MCIERR_SET_CD = (NativeConstants.MCIERR_BASE + 52);

        /// MCIERR_SEQ_TIMER -> (MCIERR_BASE + 85)
        public const int MCIERR_SEQ_TIMER = (NativeConstants.MCIERR_BASE + 85);

        /// MCIERR_SEQ_PORT_NONEXISTENT -> (MCIERR_BASE + 82)
        public const int MCIERR_SEQ_PORT_NONEXISTENT = (NativeConstants.MCIERR_BASE + 82);

        /// MCIERR_SEQ_PORT_MISCERROR -> (MCIERR_BASE + 84)
        public const int MCIERR_SEQ_PORT_MISCERROR = (NativeConstants.MCIERR_BASE + 84);

        /// MCIERR_SEQ_PORT_MAPNODEVICE -> (MCIERR_BASE + 83)
        public const int MCIERR_SEQ_PORT_MAPNODEVICE = (NativeConstants.MCIERR_BASE + 83);

        /// MCIERR_SEQ_PORT_INUSE -> (MCIERR_BASE + 81)
        public const int MCIERR_SEQ_PORT_INUSE = (NativeConstants.MCIERR_BASE + 81);

        /// MCIERR_SEQ_PORTUNSPECIFIED -> (MCIERR_BASE + 86)
        public const int MCIERR_SEQ_PORTUNSPECIFIED = (NativeConstants.MCIERR_BASE + 86);

        /// MCIERR_SEQ_NOMIDIPRESENT -> (MCIERR_BASE + 87)
        public const int MCIERR_SEQ_NOMIDIPRESENT = (NativeConstants.MCIERR_BASE + 87);

        /// MCIERR_SEQ_DIV_INCOMPATIBLE -> (MCIERR_BASE + 80)
        public const int MCIERR_SEQ_DIV_INCOMPATIBLE = (NativeConstants.MCIERR_BASE + 80);

        /// MCIERR_PARSER_INTERNAL -> (MCIERR_BASE + 15)
        public const int MCIERR_PARSER_INTERNAL = (NativeConstants.MCIERR_BASE + 15);

        /// MCIERR_PARAM_OVERFLOW -> (MCIERR_BASE + 12)
        public const int MCIERR_PARAM_OVERFLOW = (NativeConstants.MCIERR_BASE + 12);

        /// MCIERR_OUT_OF_MEMORY -> (MCIERR_BASE + 8)
        public const int MCIERR_OUT_OF_MEMORY = (NativeConstants.MCIERR_BASE + 8);

        /// MCIERR_OUTOFRANGE -> (MCIERR_BASE + 26)
        public const int MCIERR_OUTOFRANGE = (NativeConstants.MCIERR_BASE + 26);

        /// MCIERR_NULL_PARAMETER_BLOCK -> (MCIERR_BASE + 41)
        public const int MCIERR_NULL_PARAMETER_BLOCK = (NativeConstants.MCIERR_BASE + 41);

        /// MCIERR_NO_WINDOW -> (MCIERR_BASE + 90)
        public const int MCIERR_NO_WINDOW = (NativeConstants.MCIERR_BASE + 90);

        /// MCIERR_NO_INTEGER -> (MCIERR_BASE + 56)
        public const int MCIERR_NO_INTEGER = (NativeConstants.MCIERR_BASE + 56);

        /// MCIERR_NO_IDENTITY -> (MCIERR_BASE + 94)
        public const int MCIERR_NO_IDENTITY = (NativeConstants.MCIERR_BASE + 94);

        /// MCIERR_NO_ELEMENT_ALLOWED -> (MCIERR_BASE + 45)
        public const int MCIERR_NO_ELEMENT_ALLOWED = (NativeConstants.MCIERR_BASE + 45);

        /// MCIERR_NO_CLOSING_QUOTE -> (MCIERR_BASE + 38)
        public const int MCIERR_NO_CLOSING_QUOTE = (NativeConstants.MCIERR_BASE + 38);

        /// MCIERR_NOTIFY_ON_AUTO_OPEN -> (MCIERR_BASE + 44)
        public const int MCIERR_NOTIFY_ON_AUTO_OPEN = (NativeConstants.MCIERR_BASE + 44);

        /// MCIERR_NONAPPLICABLE_FUNCTION -> (MCIERR_BASE + 46)
        public const int MCIERR_NONAPPLICABLE_FUNCTION = (NativeConstants.MCIERR_BASE + 46);

        /// MCIERR_NEW_REQUIRES_ALIAS -> (MCIERR_BASE + 43)
        public const int MCIERR_NEW_REQUIRES_ALIAS = (NativeConstants.MCIERR_BASE + 43);

        /// MCIERR_MUST_USE_SHAREABLE -> (MCIERR_BASE + 35)
        public const int MCIERR_MUST_USE_SHAREABLE = (NativeConstants.MCIERR_BASE + 35);

        /// MCIERR_MULTIPLE -> (MCIERR_BASE + 24)
        public const int MCIERR_MULTIPLE = (NativeConstants.MCIERR_BASE + 24);

        /// MCIERR_MISSING_STRING_ARGUMENT -> (MCIERR_BASE + 13)
        public const int MCIERR_MISSING_STRING_ARGUMENT = (NativeConstants.MCIERR_BASE + 13);

        /// MCIERR_MISSING_PARAMETER -> (MCIERR_BASE + 17)
        public const int MCIERR_MISSING_PARAMETER = (NativeConstants.MCIERR_BASE + 17);

        /// MCIERR_MISSING_DEVICE_NAME -> (MCIERR_BASE + 36)
        public const int MCIERR_MISSING_DEVICE_NAME = (NativeConstants.MCIERR_BASE + 36);

        /// MCIERR_MISSING_COMMAND_STRING -> (MCIERR_BASE + 11)
        public const int MCIERR_MISSING_COMMAND_STRING = (NativeConstants.MCIERR_BASE + 11);

        /// MCIERR_INVALID_FILE -> (MCIERR_BASE + 40)
        public const int MCIERR_INVALID_FILE = (NativeConstants.MCIERR_BASE + 40);

        /// MCIERR_INVALID_DEVICE_NAME -> (MCIERR_BASE + 7)
        public const int MCIERR_INVALID_DEVICE_NAME = (NativeConstants.MCIERR_BASE + 7);

        /// MCIERR_INVALID_DEVICE_ID -> (MCIERR_BASE + 1)
        public const int MCIERR_INVALID_DEVICE_ID = (NativeConstants.MCIERR_BASE + 1);

        /// MCIERR_INTERNAL -> (MCIERR_BASE + 21)
        public const int MCIERR_INTERNAL = (NativeConstants.MCIERR_BASE + 21);

        /// MCIERR_ILLEGAL_FOR_AUTO_OPEN -> (MCIERR_BASE + 47)
        public const int MCIERR_ILLEGAL_FOR_AUTO_OPEN = (NativeConstants.MCIERR_BASE + 47);

        /// MCIERR_HARDWARE -> (MCIERR_BASE + 6)
        public const int MCIERR_HARDWARE = (NativeConstants.MCIERR_BASE + 6);

        /// MCIERR_GET_CD -> (MCIERR_BASE + 51)
        public const int MCIERR_GET_CD = (NativeConstants.MCIERR_BASE + 51);

        /// MCIERR_FLAGS_NOT_COMPATIBLE -> (MCIERR_BASE + 28)
        public const int MCIERR_FLAGS_NOT_COMPATIBLE = (NativeConstants.MCIERR_BASE + 28);

        /// MCIERR_FILE_WRITE -> (MCIERR_BASE + 93)
        public const int MCIERR_FILE_WRITE = (NativeConstants.MCIERR_BASE + 93);

        /// MCIERR_FILE_READ -> (MCIERR_BASE + 92)
        public const int MCIERR_FILE_READ = (NativeConstants.MCIERR_BASE + 92);

        /// MCIERR_FILE_NOT_SAVED -> (MCIERR_BASE + 30)
        public const int MCIERR_FILE_NOT_SAVED = (NativeConstants.MCIERR_BASE + 30);

        /// MCIERR_FILE_NOT_FOUND -> (MCIERR_BASE + 19)
        public const int MCIERR_FILE_NOT_FOUND = (NativeConstants.MCIERR_BASE + 19);

        /// MCIERR_FILENAME_REQUIRED -> (MCIERR_BASE + 48)
        public const int MCIERR_FILENAME_REQUIRED = (NativeConstants.MCIERR_BASE + 48);

        /// MCIERR_EXTRA_CHARACTERS -> (MCIERR_BASE + 49)
        public const int MCIERR_EXTRA_CHARACTERS = (NativeConstants.MCIERR_BASE + 49);

        /// MCIERR_EXTENSION_NOT_FOUND -> (MCIERR_BASE + 25)
        public const int MCIERR_EXTENSION_NOT_FOUND = (NativeConstants.MCIERR_BASE + 25);

        /// MCIERR_DUPLICATE_FLAGS -> (MCIERR_BASE + 39)
        public const int MCIERR_DUPLICATE_FLAGS = (NativeConstants.MCIERR_BASE + 39);

        /// MCIERR_DUPLICATE_ALIAS -> (MCIERR_BASE + 33)
        public const int MCIERR_DUPLICATE_ALIAS = (NativeConstants.MCIERR_BASE + 33);

        /// MCIERR_DRIVER_INTERNAL -> (MCIERR_BASE + 16)
        public const int MCIERR_DRIVER_INTERNAL = (NativeConstants.MCIERR_BASE + 16);

        /// MCIERR_DRIVER -> (MCIERR_BASE + 22)
        public const int MCIERR_DRIVER = (NativeConstants.MCIERR_BASE + 22);

        /// MCIERR_DEVICE_TYPE_REQUIRED -> (MCIERR_BASE + 31)
        public const int MCIERR_DEVICE_TYPE_REQUIRED = (NativeConstants.MCIERR_BASE + 31);

        /// MCIERR_DEVICE_ORD_LENGTH -> (MCIERR_BASE + 55)
        public const int MCIERR_DEVICE_ORD_LENGTH = (NativeConstants.MCIERR_BASE + 55);

        /// MCIERR_DEVICE_OPEN -> (MCIERR_BASE + 9)
        public const int MCIERR_DEVICE_OPEN = (NativeConstants.MCIERR_BASE + 9);

        /// MCIERR_DEVICE_NOT_READY -> (MCIERR_BASE + 20)
        public const int MCIERR_DEVICE_NOT_READY = (NativeConstants.MCIERR_BASE + 20);

        /// MCIERR_DEVICE_NOT_INSTALLED -> (MCIERR_BASE + 50)
        public const int MCIERR_DEVICE_NOT_INSTALLED = (NativeConstants.MCIERR_BASE + 50);

        /// MCIERR_DEVICE_LOCKED -> (MCIERR_BASE + 32)
        public const int MCIERR_DEVICE_LOCKED = (NativeConstants.MCIERR_BASE + 32);

        /// MCIERR_DEVICE_LENGTH -> (MCIERR_BASE + 54)
        public const int MCIERR_DEVICE_LENGTH = (NativeConstants.MCIERR_BASE + 54);

        /// MCIERR_CUSTOM_DRIVER_BASE -> (MCIERR_BASE + 256)
        public const int MCIERR_CUSTOM_DRIVER_BASE = (NativeConstants.MCIERR_BASE + 256);

        /// MCIERR_CREATEWINDOW -> (MCIERR_BASE + 91)
        public const int MCIERR_CREATEWINDOW = (NativeConstants.MCIERR_BASE + 91);

        /// MCIERR_CANNOT_USE_ALL -> (MCIERR_BASE + 23)
        public const int MCIERR_CANNOT_USE_ALL = (NativeConstants.MCIERR_BASE + 23);

        /// MCIERR_CANNOT_LOAD_DRIVER -> (MCIERR_BASE + 10)
        public const int MCIERR_CANNOT_LOAD_DRIVER = (NativeConstants.MCIERR_BASE + 10);

        /// MCIERR_BASE -> 256
        public const int MCIERR_BASE = 256;

        /// MCIERR_BAD_TIME_FORMAT -> (MCIERR_BASE + 37)
        public const int MCIERR_BAD_TIME_FORMAT = (NativeConstants.MCIERR_BASE + 37);

        /// MCIERR_BAD_INTEGER -> (MCIERR_BASE + 14)
        public const int MCIERR_BAD_INTEGER = (NativeConstants.MCIERR_BASE + 14);

        /// MCIERR_BAD_CONSTANT -> (MCIERR_BASE + 34)
        public const int MCIERR_BAD_CONSTANT = (NativeConstants.MCIERR_BASE + 34);

        /// MB_YESNOCANCEL -> 0x00000003L
        public const int MB_YESNOCANCEL = 3;

        /// MB_YESNO -> 0x00000004L
        public const int MB_YESNO = 4;

        /// MB_USERICON -> 0x00000080L
        public const int MB_USERICON = 128;

        /// MB_USEGLYPHCHARS -> 0x00000004
        public const int MB_USEGLYPHCHARS = 4;

        /// MB_TYPEMASK -> 0x0000000FL
        public const int MB_TYPEMASK = 15;

        /// MB_TOPMOST -> 0x00040000L
        public const int MB_TOPMOST = 262144;

        /// MB_TASKMODAL -> 0x00002000L
        public const int MB_TASKMODAL = 8192;

        /// MB_SYSTEMMODAL -> 0x00001000L
        public const int MB_SYSTEMMODAL = 4096;

        /// MB_SETFOREGROUND -> 0x00010000L
        public const int MB_SETFOREGROUND = 65536;

        /// MB_SERVICE_NOTIFICATION_NT3X -> 0x00040000L
        public const int MB_SERVICE_NOTIFICATION_NT3X = 262144;

        /// MB_SERVICE_NOTIFICATION -> 0x00200000L
        public const int MB_SERVICE_NOTIFICATION = 2097152;

        /// MB_RTLREADING -> 0x00100000L
        public const int MB_RTLREADING = 1048576;

        /// MB_RIGHT -> 0x00080000L
        public const int MB_RIGHT = 524288;

        /// MB_RETRYCANCEL -> 0x00000005L
        public const int MB_RETRYCANCEL = 5;

        /// MB_PRECOMPOSED -> 0x00000001
        public const int MB_PRECOMPOSED = 1;

        /// MB_OKCANCEL -> 0x00000001L
        public const int MB_OKCANCEL = 1;

        /// MB_OK -> 0x00000000L
        public const int MB_OK = 0;

        /// MB_NOFOCUS -> 0x00008000L
        public const int MB_NOFOCUS = 32768;

        /// MB_MODEMASK -> 0x00003000L
        public const int MB_MODEMASK = 12288;

        /// MB_MISCMASK -> 0x0000C000L
        public const int MB_MISCMASK = 49152;

        /// MB_LEN_MAX -> 5
        public const int MB_LEN_MAX = 5;

        /// MB_ICONWARNING -> MB_ICONEXCLAMATION
        public const int MB_ICONWARNING = NativeConstants.MB_ICONEXCLAMATION;

        /// MB_ICONSTOP -> MB_ICONHAND
        public const int MB_ICONSTOP = NativeConstants.MB_ICONHAND;

        /// MB_ICONQUESTION -> 0x00000020L
        public const int MB_ICONQUESTION = 32;

        /// MB_ICONMASK -> 0x000000F0L
        public const int MB_ICONMASK = 240;

        /// MB_ICONINFORMATION -> MB_ICONASTERISK
        public const int MB_ICONINFORMATION = NativeConstants.MB_ICONASTERISK;

        /// MB_ICONHAND -> 0x00000010L
        public const int MB_ICONHAND = 16;

        /// MB_ICONEXCLAMATION -> 0x00000030L
        public const int MB_ICONEXCLAMATION = 48;

        /// MB_ICONERROR -> MB_ICONHAND
        public const int MB_ICONERROR = NativeConstants.MB_ICONHAND;

        /// MB_ICONASTERISK -> 0x00000040L
        public const int MB_ICONASTERISK = 64;

        /// MB_HELP -> 0x00004000L
        public const int MB_HELP = 16384;

        /// MB_ERR_INVALID_CHARS -> 0x00000008
        public const int MB_ERR_INVALID_CHARS = 8;

        /// MB_DEFMASK -> 0x00000F00L
        public const int MB_DEFMASK = 3840;

        /// MB_DEFBUTTON4 -> 0x00000300L
        public const int MB_DEFBUTTON4 = 768;

        /// MB_DEFBUTTON3 -> 0x00000200L
        public const int MB_DEFBUTTON3 = 512;

        /// MB_DEFBUTTON2 -> 0x00000100L
        public const int MB_DEFBUTTON2 = 256;

        /// MB_DEFBUTTON1 -> 0x00000000L
        public const int MB_DEFBUTTON1 = 0;

        /// MB_DEFAULT_DESKTOP_ONLY -> 0x00020000L
        public const int MB_DEFAULT_DESKTOP_ONLY = 131072;

        /// MB_COMPOSITE -> 0x00000002
        public const int MB_COMPOSITE = 2;

        /// MB_CANCELTRYCONTINUE -> 0x00000006L
        public const int MB_CANCELTRYCONTINUE = 6;

        /// MB_APPLMODAL -> 0x00000000L
        public const int MB_APPLMODAL = 0;

        /// MB_ABORTRETRYIGNORE -> 0x00000002L
        public const int MB_ABORTRETRYIGNORE = 2;

        /// MA_NOACTIVATEANDEAT -> 4
        public const int MA_NOACTIVATEANDEAT = 4;

        /// MA_NOACTIVATE -> 3
        public const int MA_NOACTIVATE = 3;

        /// MA_ACTIVATEANDEAT -> 2
        public const int MA_ACTIVATEANDEAT = 2;

        /// MA_ACTIVATE -> 1
        public const int MA_ACTIVATE = 1;

        /// MAX_VOLUME_TEMPLATE_SIZE -> 40
        public const int MAX_VOLUME_TEMPLATE_SIZE = 40;

        /// MAX_VOLUME_ID_SIZE -> 36
        public const int MAX_VOLUME_ID_SIZE = 36;

        /// MAX_SIZE_SECURITY_ID -> 512
        public const int MAX_SIZE_SECURITY_ID = 512;

        /// MAX_SID_SIZE -> 256
        public const int MAX_SID_SIZE = 256;

        /// MAX_SHUTDOWN_TIMEOUT -> (10*365*24*60*60)
        public const int MAX_SHUTDOWN_TIMEOUT = (10
                    * (365
                    * (24
                    * (60 * 60))));

        /// MAX_REASON_NAME_LEN -> 64
        public const int MAX_REASON_NAME_LEN = 64;

        /// MAX_REASON_DESC_LEN -> 256
        public const int MAX_REASON_DESC_LEN = 256;

        /// MAX_REASON_COMMENT_LEN -> 512
        public const int MAX_REASON_COMMENT_LEN = 512;

        /// MAX_REASON_BUGID_LEN -> 32
        public const int MAX_REASON_BUGID_LEN = 32;

        /// MAX_PROFILE_LEN -> 80
        public const int MAX_PROFILE_LEN = 80;

        /// MAX_PRIORITY -> 99
        public const int MAX_PRIORITY = 99;

        /// MAX_PERF_OBJECTS_IN_QUERY_FUNCTION -> (64L)
        public const int MAX_PERF_OBJECTS_IN_QUERY_FUNCTION = 64;

        /// MAX_PATH -> 260
        public const int MAX_PATH = 260;

        /// MAX_NUM_REASONS -> 256
        public const int MAX_NUM_REASONS = 256;

        /// MAX_MONITORS -> 4
        public const int MAX_MONITORS = 4;

        /// MAX_LEADBYTES -> 12
        public const int MAX_LEADBYTES = 12;

        /// MAX_LANA -> 254
        public const int MAX_LANA = 254;

        /// MAX_JOYSTICKOEMVXDNAME -> 260
        public const int MAX_JOYSTICKOEMVXDNAME = 260;

        /// MAX_DEFAULTCHAR -> 2
        public const int MAX_DEFAULTCHAR = 2;

        /// MAX_COMPUTERNAME_LENGTH -> 15
        public const int MAX_COMPUTERNAME_LENGTH = 15;

        /// MAX_ACL_REVISION -> ACL_REVISION4
        public const int MAX_ACL_REVISION = NativeConstants.ACL_REVISION4;

        /// MAXWORD -> 0xffff
        public const int MAXWORD = 65535;

        /// MAXUIDLEN -> 64
        public const int MAXUIDLEN = 64;

        /// MAXSTRETCHBLTMODE -> 4
        public const int MAXSTRETCHBLTMODE = 4;

        /// MAXSHORT -> 0x7fff
        public const int MAXSHORT = 32767;

        /// MAXPROPPAGES -> 100
        public const int MAXPROPPAGES = 100;

        /// MAXPNAMELEN -> 32
        public const int MAXPNAMELEN = 32;

        /// MaxNumberOfEEInfoParams -> 4
        public const int MaxNumberOfEEInfoParams = 4;

        /// MAXLONGLONG -> (0x7fffffffffffffff)
        public const long MAXLONGLONG = 9223372036854775807;

        /// MAXLONG -> 0x7fffffff
        public const int MAXLONG = 2147483647;

        /// MAXLOGICALLOGNAMESIZE -> 256
        public const int MAXLOGICALLOGNAMESIZE = 256;

        /// MAXINTATOM -> 0xC000
        public const int MAXINTATOM = 49152;

        /// MAXIMUM_WAIT_OBJECTS -> 64
        public const int MAXIMUM_WAIT_OBJECTS = 64;

        /// MAXIMUM_SUSPEND_COUNT -> MAXCHAR
        public const int MAXIMUM_SUSPEND_COUNT = NativeConstants.MAXCHAR;

        /// MAXIMUM_SUPPORTED_EXTENSION -> 512
        public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

        /// MAXIMUM_SMARTCARD_READERS -> 10
        public const int MAXIMUM_SMARTCARD_READERS = 10;

        /// MAXIMUM_REPARSE_DATA_BUFFER_SIZE -> ( 16 * 1024 )
        public const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = (16 * 1024);

        /// MAXIMUM_PROCESSORS -> 32
        public const int MAXIMUM_PROCESSORS = 32;

        /// MAXIMUM_ENCRYPTION_VALUE -> 0x00000004
        public const int MAXIMUM_ENCRYPTION_VALUE = 4;

        /// MAXIMUM_ATTR_STRING_LENGTH -> 32
        public const int MAXIMUM_ATTR_STRING_LENGTH = 32;

        /// MAXIMUM_ALLOWED -> (0x02000000L)
        public const int MAXIMUM_ALLOWED = 33554432;

        /// MAXGETHOSTSTRUCT -> 1024
        public const int MAXGETHOSTSTRUCT = 1024;

        /// MAXERRORLENGTH -> 256
        public const int MAXERRORLENGTH = 256;

        /// MAXDWORD -> 0xffffffff
        public const int MAXDWORD = -1;

        /// MAXCHAR -> 0x7f
        public const int MAXCHAR = 127;

        /// MAXBYTE -> 0xff
        public const int MAXBYTE = 255;

        /// MARSHAL_S_LAST -> 0x0004012FL
        public const int MARSHAL_S_LAST = 262447;

        /// MARSHAL_S_FIRST -> 0x00040120L
        public const int MARSHAL_S_FIRST = 262432;

        /// MARSHAL_E_LAST -> 0x8004012FL
        public const int MARSHAL_E_LAST = -2147221201;

        /// MARSHAL_E_FIRST -> 0x80040120L
        public const int MARSHAL_E_FIRST = -2147221216;

        /// MARSHALINTERFACE_MIN -> 500
        public const int MARSHALINTERFACE_MIN = 500;

        /// MARK_HANDLE_TXF_SYSTEM_LOG -> (0x00000004)
        public const int MARK_HANDLE_TXF_SYSTEM_LOG = 4;

        /// MARK_HANDLE_PROTECT_CLUSTERS -> (0x00000001)
        public const int MARK_HANDLE_PROTECT_CLUSTERS = 1;

        /// MARK_HANDLE_NOT_TXF_SYSTEM_LOG -> (0x00000008)
        public const int MARK_HANDLE_NOT_TXF_SYSTEM_LOG = 8;

        /// MARKPARITY -> 3
        public const int MARKPARITY = 3;

        /// MAP_PRECOMPOSED -> 0x00000020
        public const int MAP_PRECOMPOSED = 32;

        /// MAP_FOLDDIGITS -> 0x00000080
        public const int MAP_FOLDDIGITS = 128;

        /// MAP_FOLDCZONE -> 0x00000010
        public const int MAP_FOLDCZONE = 16;

        /// MAP_EXPAND_LIGATURES -> 0x00002000
        public const int MAP_EXPAND_LIGATURES = 8192;

        /// MAP_COMPOSITE -> 0x00000040
        public const int MAP_COMPOSITE = 64;

        /// MapVirtualKeyEx -> MapVirtualKeyExW
        /// Error generating expression: Value MapVirtualKeyExW is not resolved
        public const string MapVirtualKeyEx = "MapVirtualKeyExW";

        /// MapVirtualKey -> MapVirtualKeyW
        /// Error generating expression: Value MapVirtualKeyW is not resolved
        public const string MapVirtualKey = "MapVirtualKeyW";

        /// MAKEINTRESOURCE -> MAKEINTRESOURCEW
        public const string MAKEINTRESOURCE = NativeConstants.MAKEINTRESOURCEW;

        /// MAILSLOT_WAIT_FOREVER -> ((DWORD)-1)
        public const int MAILSLOT_WAIT_FOREVER = -1;

        /// MAILSLOT_NO_MESSAGE -> ((DWORD)-1)
        public const int MAILSLOT_NO_MESSAGE = -1;

        /// MAC_CHARSET -> 77
        public const int MAC_CHARSET = 77;

        /// Warning: Generation of Method Macros is not supported at this time
        /// MAKEINTRESOURCEW -> "(i) ((LPWSTR)((ULONG_PTR)((WORD)(i))))"
        public const string MAKEINTRESOURCEW = "(i) ((LPWSTR)((ULONG_PTR)((WORD)(i))))";
    }

}
