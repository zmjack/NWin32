using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// VT_HARDTYPE -> VT_RESERVED
        public const VARENUM VT_HARDTYPE = VARENUM.VT_RESERVED;

        /// VTDATEGRE_MIN -> -657434
        public const int VTDATEGRE_MIN = -657434;

        /// VTDATEGRE_MAX -> 2958465
        public const int VTDATEGRE_MAX = 2958465;

        /// VTBIT_UI8 -> (1 << VT_UI8)
        public const int VTBIT_UI8 = (1) << (int)(VARENUM.VT_UI8);

        /// VTBIT_UI4 -> (1 << VT_UI4)
        public const int VTBIT_UI4 = (1) << (int)(VARENUM.VT_UI4);

        /// VTBIT_UI2 -> (1 << VT_UI2)
        public const int VTBIT_UI2 = (1) << (int)(VARENUM.VT_UI2);

        /// VTBIT_UI1 -> (1 << VT_UI1)
        public const int VTBIT_UI1 = (1) << (int)(VARENUM.VT_UI1);

        /// VTBIT_R8 -> (1 << VT_R8)
        public const int VTBIT_R8 = (1) << (int)(VARENUM.VT_R8);

        /// VTBIT_R4 -> (1 << VT_R4)
        public const int VTBIT_R4 = (1) << (int)(VARENUM.VT_R4);

        /// VTBIT_I8 -> (1 << VT_I8)
        public const int VTBIT_I8 = (1) << (int)(VARENUM.VT_I8);

        /// VTBIT_I4 -> (1 << VT_I4)
        public const int VTBIT_I4 = (1) << (int)(VARENUM.VT_I4);

        /// VTBIT_I2 -> (1 << VT_I2)
        public const int VTBIT_I2 = (1) << (int)(VARENUM.VT_I2);

        /// VTBIT_I1 -> (1 << VT_I1)
        public const int VTBIT_I1 = (1) << (int)(VARENUM.VT_I1);

        /// VTBIT_DECIMAL -> (1 << VT_DECIMAL)
        public const int VTBIT_DECIMAL = (1) << (int)(VARENUM.VT_DECIMAL);

        /// VTBIT_CY -> (1 << VT_CY)
        public const int VTBIT_CY = (1) << (int)(VARENUM.VT_CY);

        /// VTA_TOP -> TA_LEFT
        public const int VTA_TOP = NativeConstants.TA_LEFT;

        /// VTA_RIGHT -> TA_TOP
        public const int VTA_RIGHT = NativeConstants.TA_TOP;

        /// VTA_LEFT -> TA_BOTTOM
        public const int VTA_LEFT = NativeConstants.TA_BOTTOM;

        /// VTA_CENTER -> TA_CENTER
        public const int VTA_CENTER = NativeConstants.TA_CENTER;

        /// VTA_BOTTOM -> TA_RIGHT
        public const int VTA_BOTTOM = NativeConstants.TA_RIGHT;

        /// VTA_BASELINE -> TA_BASELINE
        public const int VTA_BASELINE = NativeConstants.TA_BASELINE;

        /// VS_VERSION_INFO -> 1
        public const int VS_VERSION_INFO = 1;

        /// VS_USER_DEFINED -> 100
        public const int VS_USER_DEFINED = 100;

        /// VS_FILE_INFO -> RT_VERSION
        public const string VS_FILE_INFO = NativeConstants.RT_VERSION;

        /// VS_FF_SPECIALBUILD -> 0x00000020L
        public const int VS_FF_SPECIALBUILD = 32;

        /// VS_FF_PRIVATEBUILD -> 0x00000008L
        public const int VS_FF_PRIVATEBUILD = 8;

        /// VS_FF_PRERELEASE -> 0x00000002L
        public const int VS_FF_PRERELEASE = 2;

        /// VS_FF_PATCHED -> 0x00000004L
        public const int VS_FF_PATCHED = 4;

        /// VS_FF_INFOINFERRED -> 0x00000010L
        public const int VS_FF_INFOINFERRED = 16;

        /// VS_FF_DEBUG -> 0x00000001L
        public const int VS_FF_DEBUG = 1;

        /// VS_FFI_STRUCVERSION -> 0x00010000L
        public const int VS_FFI_STRUCVERSION = 65536;

        /// VS_FFI_SIGNATURE -> 0xFEEF04BDL
        public const int VS_FFI_SIGNATURE = -17890115;

        /// VS_FFI_FILEFLAGSMASK -> 0x0000003FL
        public const int VS_FFI_FILEFLAGSMASK = 63;

        /// VREFRESH -> 116
        public const int VREFRESH = 116;

        /// VP_TV_STANDARD_WIN_VGA -> 0x8000
        public const int VP_TV_STANDARD_WIN_VGA = 32768;

        /// VP_TV_STANDARD_SECAM_L1 -> 0x00080000
        public const int VP_TV_STANDARD_SECAM_L1 = 524288;

        /// VP_TV_STANDARD_SECAM_L -> 0x4000
        public const int VP_TV_STANDARD_SECAM_L = 16384;

        /// VP_TV_STANDARD_SECAM_K1 -> 0x2000
        public const int VP_TV_STANDARD_SECAM_K1 = 8192;

        /// VP_TV_STANDARD_SECAM_K -> 0x1000
        public const int VP_TV_STANDARD_SECAM_K = 4096;

        /// VP_TV_STANDARD_SECAM_H -> 0x0800
        public const int VP_TV_STANDARD_SECAM_H = 2048;

        /// VP_TV_STANDARD_SECAM_G -> 0x0400
        public const int VP_TV_STANDARD_SECAM_G = 1024;

        /// VP_TV_STANDARD_SECAM_D -> 0x0200
        public const int VP_TV_STANDARD_SECAM_D = 512;

        /// VP_TV_STANDARD_SECAM_B -> 0x0100
        public const int VP_TV_STANDARD_SECAM_B = 256;

        /// VP_TV_STANDARD_PAL_N -> 0x0080
        public const int VP_TV_STANDARD_PAL_N = 128;

        /// VP_TV_STANDARD_PAL_M -> 0x0040
        public const int VP_TV_STANDARD_PAL_M = 64;

        /// VP_TV_STANDARD_PAL_I -> 0x0020
        public const int VP_TV_STANDARD_PAL_I = 32;

        /// VP_TV_STANDARD_PAL_H -> 0x0010
        public const int VP_TV_STANDARD_PAL_H = 16;

        /// VP_TV_STANDARD_PAL_G -> 0x00020000
        public const int VP_TV_STANDARD_PAL_G = 131072;

        /// VP_TV_STANDARD_PAL_D -> 0x0008
        public const int VP_TV_STANDARD_PAL_D = 8;

        /// VP_TV_STANDARD_PAL_B -> 0x0004
        public const int VP_TV_STANDARD_PAL_B = 4;

        /// VP_TV_STANDARD_PAL_60 -> 0x00040000
        public const int VP_TV_STANDARD_PAL_60 = 262144;

        /// VP_TV_STANDARD_NTSC_M_J -> 0x0002
        public const int VP_TV_STANDARD_NTSC_M_J = 2;

        /// VP_TV_STANDARD_NTSC_M -> 0x0001
        public const int VP_TV_STANDARD_NTSC_M = 1;

        /// VP_TV_STANDARD_NTSC_433 -> 0x00010000
        public const int VP_TV_STANDARD_NTSC_433 = 65536;

        /// VP_MODE_WIN_GRAPHICS -> 0x0001
        public const int VP_MODE_WIN_GRAPHICS = 1;

        /// VP_MODE_TV_PLAYBACK -> 0x0002
        public const int VP_MODE_TV_PLAYBACK = 2;

        /// VP_FLAGS_TV_STANDARD -> 0x0002
        public const int VP_FLAGS_TV_STANDARD = 2;

        /// VP_FLAGS_TV_MODE -> 0x0001
        public const int VP_FLAGS_TV_MODE = 1;

        /// VP_FLAGS_POSITION -> 0x0020
        public const int VP_FLAGS_POSITION = 32;

        /// VP_FLAGS_OVERSCAN -> 0x0008
        public const int VP_FLAGS_OVERSCAN = 8;

        /// VP_FLAGS_MAX_UNSCALED -> 0x0010
        public const int VP_FLAGS_MAX_UNSCALED = 16;

        /// VP_FLAGS_FLICKER -> 0x0004
        public const int VP_FLAGS_FLICKER = 4;

        /// VP_FLAGS_COPYPROTECT -> 0x0100
        public const int VP_FLAGS_COPYPROTECT = 256;

        /// VP_FLAGS_CONTRAST -> 0x0080
        public const int VP_FLAGS_CONTRAST = 128;

        /// VP_FLAGS_BRIGHTNESS -> 0x0040
        public const int VP_FLAGS_BRIGHTNESS = 64;

        /// VP_CP_TYPE_MACROVISION -> 0x0002
        public const int VP_CP_TYPE_MACROVISION = 2;

        /// VP_CP_TYPE_APS_TRIGGER -> 0x0001
        public const int VP_CP_TYPE_APS_TRIGGER = 1;

        /// VP_CP_CMD_DEACTIVATE -> 0x0002
        public const int VP_CP_CMD_DEACTIVATE = 2;

        /// VP_CP_CMD_CHANGE -> 0x0004
        public const int VP_CP_CMD_CHANGE = 4;

        /// VP_CP_CMD_ACTIVATE -> 0x0001
        public const int VP_CP_CMD_ACTIVATE = 1;

        /// VP_COMMAND_SET -> 0x0002
        public const int VP_COMMAND_SET = 2;

        /// VP_COMMAND_GET -> 0x0001
        public const int VP_COMMAND_GET = 1;

        /// VOS__WINDOWS32 -> 0x00000004L
        public const int VOS__WINDOWS32 = 4;

        /// VOS__WINDOWS16 -> 0x00000001L
        public const int VOS__WINDOWS16 = 1;

        /// VOS__PM32 -> 0x00000003L
        public const int VOS__PM32 = 3;

        /// VOS__PM16 -> 0x00000002L
        public const int VOS__PM16 = 2;

        /// VOS__BASE -> 0x00000000L
        public const int VOS__BASE = 0;

        /// VOS_WINCE -> 0x00050000L
        public const int VOS_WINCE = 327680;

        /// VOS_UNKNOWN -> 0x00000000L
        public const int VOS_UNKNOWN = 0;

        /// VOS_OS232_PM32 -> 0x00030003L
        public const int VOS_OS232_PM32 = 196611;

        /// VOS_OS232 -> 0x00030000L
        public const int VOS_OS232 = 196608;

        /// VOS_OS216_PM16 -> 0x00020002L
        public const int VOS_OS216_PM16 = 131074;

        /// VOS_OS216 -> 0x00020000L
        public const int VOS_OS216 = 131072;

        /// VOS_NT_WINDOWS32 -> 0x00040004L
        public const int VOS_NT_WINDOWS32 = 262148;

        /// VOS_NT -> 0x00040000L
        public const int VOS_NT = 262144;

        /// VOS_DOS_WINDOWS32 -> 0x00010004L
        public const int VOS_DOS_WINDOWS32 = 65540;

        /// VOS_DOS_WINDOWS16 -> 0x00010001L
        public const int VOS_DOS_WINDOWS16 = 65537;

        /// VOS_DOS -> 0x00010000L
        public const int VOS_DOS = 65536;

        /// VOLUME_UPGRADE_SCHEDULED -> (0x00000002)
        public const int VOLUME_UPGRADE_SCHEDULED = 2;

        /// VOLUME_IS_DIRTY -> (0x00000001)
        public const int VOLUME_IS_DIRTY = 1;

        /// VolumeClassGuid -> GUID_DEVINTERFACE_VOLUME
        /// Error generating expression: Value GUID_DEVINTERFACE_VOLUME is not resolved
        public const string VolumeClassGuid = "GUID_DEVINTERFACE_VOLUME";

        /// VOID -> void
        /// Error generating expression: Value void is not resolved
        public const string VOID = "void";

        /// VK_ZOOM -> 0xFB
        public const int VK_ZOOM = 251;

        /// VK_XBUTTON2 -> 0x06
        public const int VK_XBUTTON2 = 6;

        /// VK_XBUTTON1 -> 0x05
        public const int VK_XBUTTON1 = 5;

        /// VK_VOLUME_UP -> 0xAF
        public const int VK_VOLUME_UP = 175;

        /// VK_VOLUME_MUTE -> 0xAD
        public const int VK_VOLUME_MUTE = 173;

        /// VK_VOLUME_DOWN -> 0xAE
        public const int VK_VOLUME_DOWN = 174;

        /// VK_UP -> 0x26
        public const int VK_UP = 38;

        /// VK_TAB -> 0x09
        public const int VK_TAB = 9;

        /// VK_SUBTRACT -> 0x6D
        public const int VK_SUBTRACT = 109;

        /// VK_SPACE -> 0x20
        public const int VK_SPACE = 32;

        /// VK_SNAPSHOT -> 0x2C
        public const int VK_SNAPSHOT = 44;

        /// VK_SLEEP -> 0x5F
        public const int VK_SLEEP = 95;

        /// VK_SHIFT -> 0x10
        public const int VK_SHIFT = 16;

        /// VK_SEPARATOR -> 0x6C
        public const int VK_SEPARATOR = 108;

        /// VK_SELECT -> 0x29
        public const int VK_SELECT = 41;

        /// VK_SCROLL -> 0x91
        public const int VK_SCROLL = 145;

        /// VK_RWIN -> 0x5C
        public const int VK_RWIN = 92;

        /// VK_RSHIFT -> 0xA1
        public const int VK_RSHIFT = 161;

        /// VK_RMENU -> 0xA5
        public const int VK_RMENU = 165;

        /// VK_RIGHT -> 0x27
        public const int VK_RIGHT = 39;

        /// VK_RETURN -> 0x0D
        public const int VK_RETURN = 13;

        /// VK_RCONTROL -> 0xA3
        public const int VK_RCONTROL = 163;

        /// VK_RBUTTON -> 0x02
        public const int VK_RBUTTON = 2;

        /// VK_PROCESSKEY -> 0xE5
        public const int VK_PROCESSKEY = 229;

        /// VK_PRIOR -> 0x21
        public const int VK_PRIOR = 33;

        /// VK_PRINT -> 0x2A
        public const int VK_PRINT = 42;

        /// VK_PLAY -> 0xFA
        public const int VK_PLAY = 250;

        /// VK_PAUSE -> 0x13
        public const int VK_PAUSE = 19;

        /// VK_PACKET -> 0xE7
        public const int VK_PACKET = 231;

        /// VK_PA1 -> 0xFD
        public const int VK_PA1 = 253;

        /// VK_OEM_WSCTRL -> 0xEE
        public const int VK_OEM_WSCTRL = 238;

        /// VK_OEM_RESET -> 0xE9
        public const int VK_OEM_RESET = 233;

        /// VK_OEM_PLUS -> 0xBB
        public const int VK_OEM_PLUS = 187;

        /// VK_OEM_PERIOD -> 0xBE
        public const int VK_OEM_PERIOD = 190;

        /// VK_OEM_PA3 -> 0xED
        public const int VK_OEM_PA3 = 237;

        /// VK_OEM_PA2 -> 0xEC
        public const int VK_OEM_PA2 = 236;

        /// VK_OEM_PA1 -> 0xEB
        public const int VK_OEM_PA1 = 235;

        /// VK_OEM_NEC_EQUAL -> 0x92
        public const int VK_OEM_NEC_EQUAL = 146;

        /// VK_OEM_MINUS -> 0xBD
        public const int VK_OEM_MINUS = 189;

        /// VK_OEM_JUMP -> 0xEA
        public const int VK_OEM_JUMP = 234;

        /// VK_OEM_FJ_TOUROKU -> 0x94
        public const int VK_OEM_FJ_TOUROKU = 148;

        /// VK_OEM_FJ_ROYA -> 0x96
        public const int VK_OEM_FJ_ROYA = 150;

        /// VK_OEM_FJ_MASSHOU -> 0x93
        public const int VK_OEM_FJ_MASSHOU = 147;

        /// VK_OEM_FJ_LOYA -> 0x95
        public const int VK_OEM_FJ_LOYA = 149;

        /// VK_OEM_FJ_JISHO -> 0x92
        public const int VK_OEM_FJ_JISHO = 146;

        /// VK_OEM_FINISH -> 0xF1
        public const int VK_OEM_FINISH = 241;

        /// VK_OEM_ENLW -> 0xF4
        public const int VK_OEM_ENLW = 244;

        /// VK_OEM_CUSEL -> 0xEF
        public const int VK_OEM_CUSEL = 239;

        /// VK_OEM_COPY -> 0xF2
        public const int VK_OEM_COPY = 242;

        /// VK_OEM_COMMA -> 0xBC
        public const int VK_OEM_COMMA = 188;

        /// VK_OEM_CLEAR -> 0xFE
        public const int VK_OEM_CLEAR = 254;

        /// VK_OEM_BACKTAB -> 0xF5
        public const int VK_OEM_BACKTAB = 245;

        /// VK_OEM_AX -> 0xE1
        public const int VK_OEM_AX = 225;

        /// VK_OEM_AUTO -> 0xF3
        public const int VK_OEM_AUTO = 243;

        /// VK_OEM_ATTN -> 0xF0
        public const int VK_OEM_ATTN = 240;

        /// VK_OEM_8 -> 0xDF
        public const int VK_OEM_8 = 223;

        /// VK_OEM_7 -> 0xDE
        public const int VK_OEM_7 = 222;

        /// VK_OEM_6 -> 0xDD
        public const int VK_OEM_6 = 221;

        /// VK_OEM_5 -> 0xDC
        public const int VK_OEM_5 = 220;

        /// VK_OEM_4 -> 0xDB
        public const int VK_OEM_4 = 219;

        /// VK_OEM_3 -> 0xC0
        public const int VK_OEM_3 = 192;

        /// VK_OEM_2 -> 0xBF
        public const int VK_OEM_2 = 191;

        /// VK_OEM_102 -> 0xE2
        public const int VK_OEM_102 = 226;

        /// VK_OEM_1 -> 0xBA
        public const int VK_OEM_1 = 186;

        /// VK_NUMPAD9 -> 0x69
        public const int VK_NUMPAD9 = 105;

        /// VK_NUMPAD8 -> 0x68
        public const int VK_NUMPAD8 = 104;

        /// VK_NUMPAD7 -> 0x67
        public const int VK_NUMPAD7 = 103;

        /// VK_NUMPAD6 -> 0x66
        public const int VK_NUMPAD6 = 102;

        /// VK_NUMPAD5 -> 0x65
        public const int VK_NUMPAD5 = 101;

        /// VK_NUMPAD4 -> 0x64
        public const int VK_NUMPAD4 = 100;

        /// VK_NUMPAD3 -> 0x63
        public const int VK_NUMPAD3 = 99;

        /// VK_NUMPAD2 -> 0x62
        public const int VK_NUMPAD2 = 98;

        /// VK_NUMPAD1 -> 0x61
        public const int VK_NUMPAD1 = 97;

        /// VK_NUMPAD0 -> 0x60
        public const int VK_NUMPAD0 = 96;

        /// VK_NUMLOCK -> 0x90
        public const int VK_NUMLOCK = 144;

        /// VK_NONCONVERT -> 0x1D
        public const int VK_NONCONVERT = 29;

        /// VK_NONAME -> 0xFC
        public const int VK_NONAME = 252;

        /// VK_NEXT -> 0x22
        public const int VK_NEXT = 34;

        /// VK_MULTIPLY -> 0x6A
        public const int VK_MULTIPLY = 106;

        /// VK_MODECHANGE -> 0x1F
        public const int VK_MODECHANGE = 31;

        /// VK_MENU -> 0x12
        public const int VK_MENU = 18;

        /// VK_MEDIA_STOP -> 0xB2
        public const int VK_MEDIA_STOP = 178;

        /// VK_MEDIA_PREV_TRACK -> 0xB1
        public const int VK_MEDIA_PREV_TRACK = 177;

        /// VK_MEDIA_PLAY_PAUSE -> 0xB3
        public const int VK_MEDIA_PLAY_PAUSE = 179;

        /// VK_MEDIA_NEXT_TRACK -> 0xB0
        public const int VK_MEDIA_NEXT_TRACK = 176;

        /// VK_MBUTTON -> 0x04
        public const int VK_MBUTTON = 4;

        /// VK_LWIN -> 0x5B
        public const int VK_LWIN = 91;

        /// VK_LSHIFT -> 0xA0
        public const int VK_LSHIFT = 160;

        /// VK_LMENU -> 0xA4
        public const int VK_LMENU = 164;

        /// VK_LEFT -> 0x25
        public const int VK_LEFT = 37;

        /// VK_LCONTROL -> 0xA2
        public const int VK_LCONTROL = 162;

        /// VK_LBUTTON -> 0x01
        public const int VK_LBUTTON = 1;

        /// VK_LAUNCH_MEDIA_SELECT -> 0xB5
        public const int VK_LAUNCH_MEDIA_SELECT = 181;

        /// VK_LAUNCH_MAIL -> 0xB4
        public const int VK_LAUNCH_MAIL = 180;

        /// VK_LAUNCH_APP2 -> 0xB7
        public const int VK_LAUNCH_APP2 = 183;

        /// VK_LAUNCH_APP1 -> 0xB6
        public const int VK_LAUNCH_APP1 = 182;

        /// VK_KANJI -> 0x19
        public const int VK_KANJI = 25;

        /// VK_KANA -> 0x15
        public const int VK_KANA = 21;

        /// VK_JUNJA -> 0x17
        public const int VK_JUNJA = 23;

        /// VK_INSERT -> 0x2D
        public const int VK_INSERT = 45;

        /// VK_ICO_HELP -> 0xE3
        public const int VK_ICO_HELP = 227;

        /// VK_ICO_CLEAR -> 0xE6
        public const int VK_ICO_CLEAR = 230;

        /// VK_ICO_00 -> 0xE4
        public const int VK_ICO_00 = 228;

        /// VK_HOME -> 0x24
        public const int VK_HOME = 36;

        /// VK_HELP -> 0x2F
        public const int VK_HELP = 47;

        /// VK_HANJA -> 0x19
        public const int VK_HANJA = 25;

        /// VK_HANGUL -> 0x15
        public const int VK_HANGUL = 21;

        /// VK_HANGEUL -> 0x15
        public const int VK_HANGEUL = 21;

        /// VK_FINAL -> 0x18
        public const int VK_FINAL = 24;

        /// VK_F9 -> 0x78
        public const int VK_F9 = 120;

        /// VK_F8 -> 0x77
        public const int VK_F8 = 119;

        /// VK_F7 -> 0x76
        public const int VK_F7 = 118;

        /// VK_F6 -> 0x75
        public const int VK_F6 = 117;

        /// VK_F5 -> 0x74
        public const int VK_F5 = 116;

        /// VK_F4 -> 0x73
        public const int VK_F4 = 115;

        /// VK_F3 -> 0x72
        public const int VK_F3 = 114;

        /// VK_F24 -> 0x87
        public const int VK_F24 = 135;

        /// VK_F23 -> 0x86
        public const int VK_F23 = 134;

        /// VK_F22 -> 0x85
        public const int VK_F22 = 133;

        /// VK_F21 -> 0x84
        public const int VK_F21 = 132;

        /// VK_F20 -> 0x83
        public const int VK_F20 = 131;

        /// VK_F2 -> 0x71
        public const int VK_F2 = 113;

        /// VK_F19 -> 0x82
        public const int VK_F19 = 130;

        /// VK_F18 -> 0x81
        public const int VK_F18 = 129;

        /// VK_F17 -> 0x80
        public const int VK_F17 = 128;

        /// VK_F16 -> 0x7F
        public const int VK_F16 = 127;

        /// VK_F15 -> 0x7E
        public const int VK_F15 = 126;

        /// VK_F14 -> 0x7D
        public const int VK_F14 = 125;

        /// VK_F13 -> 0x7C
        public const int VK_F13 = 124;

        /// VK_F12 -> 0x7B
        public const int VK_F12 = 123;

        /// VK_F11 -> 0x7A
        public const int VK_F11 = 122;

        /// VK_F10 -> 0x79
        public const int VK_F10 = 121;

        /// VK_F1 -> 0x70
        public const int VK_F1 = 112;

        /// VK_EXSEL -> 0xF8
        public const int VK_EXSEL = 248;

        /// VK_EXECUTE -> 0x2B
        public const int VK_EXECUTE = 43;

        /// VK_ESCAPE -> 0x1B
        public const int VK_ESCAPE = 27;

        /// VK_EREOF -> 0xF9
        public const int VK_EREOF = 249;

        /// VK_END -> 0x23
        public const int VK_END = 35;

        /// VK_DOWN -> 0x28
        public const int VK_DOWN = 40;

        /// VK_DIVIDE -> 0x6F
        public const int VK_DIVIDE = 111;

        /// VK_DELETE -> 0x2E
        public const int VK_DELETE = 46;

        /// VK_DECIMAL -> 0x6E
        public const int VK_DECIMAL = 110;

        /// VK_CRSEL -> 0xF7
        public const int VK_CRSEL = 247;

        /// VK_CONVERT -> 0x1C
        public const int VK_CONVERT = 28;

        /// VK_CONTROL -> 0x11
        public const int VK_CONTROL = 17;

        /// VK_CLEAR -> 0x0C
        public const int VK_CLEAR = 12;

        /// VK_CAPITAL -> 0x14
        public const int VK_CAPITAL = 20;

        /// VK_CANCEL -> 0x03
        public const int VK_CANCEL = 3;

        /// VK_BROWSER_STOP -> 0xA9
        public const int VK_BROWSER_STOP = 169;

        /// VK_BROWSER_SEARCH -> 0xAA
        public const int VK_BROWSER_SEARCH = 170;

        /// VK_BROWSER_REFRESH -> 0xA8
        public const int VK_BROWSER_REFRESH = 168;

        /// VK_BROWSER_HOME -> 0xAC
        public const int VK_BROWSER_HOME = 172;

        /// VK_BROWSER_FORWARD -> 0xA7
        public const int VK_BROWSER_FORWARD = 167;

        /// VK_BROWSER_FAVORITES -> 0xAB
        public const int VK_BROWSER_FAVORITES = 171;

        /// VK_BROWSER_BACK -> 0xA6
        public const int VK_BROWSER_BACK = 166;

        /// VK_BACK -> 0x08
        public const int VK_BACK = 8;

        /// VK_ATTN -> 0xF6
        public const int VK_ATTN = 246;

        /// VK_APPS -> 0x5D
        public const int VK_APPS = 93;

        /// VK_ADD -> 0x6B
        public const int VK_ADD = 107;

        /// VK_ACCEPT -> 0x1E
        public const int VK_ACCEPT = 30;

        /// VkKeyScanEx -> VkKeyScanExW
        /// Error generating expression: Value VkKeyScanExW is not resolved
        public const string VkKeyScanEx = "VkKeyScanExW";

        /// VkKeyScan -> VkKeyScanW
        /// Error generating expression: Value VkKeyScanW is not resolved
        public const string VkKeyScan = "VkKeyScanW";

        /// VIF_WRITEPROT -> 0x00000040L
        public const int VIF_WRITEPROT = 64;

        /// VIF_TEMPFILE -> 0x00000001L
        public const int VIF_TEMPFILE = 1;

        /// VIF_SRCOLD -> 0x00000004L
        public const int VIF_SRCOLD = 4;

        /// VIF_SHARINGVIOLATION -> 0x00000400L
        public const int VIF_SHARINGVIOLATION = 1024;

        /// VIF_OUTOFSPACE -> 0x00000100L
        public const int VIF_OUTOFSPACE = 256;

        /// VIF_OUTOFMEMORY -> 0x00008000L
        public const int VIF_OUTOFMEMORY = 32768;

        /// VIF_MISMATCH -> 0x00000002L
        public const int VIF_MISMATCH = 2;

        /// VIF_FILEINUSE -> 0x00000080L
        public const int VIF_FILEINUSE = 128;

        /// VIF_DIFFTYPE -> 0x00000020L
        public const int VIF_DIFFTYPE = 32;

        /// VIF_DIFFLANG -> 0x00000008L
        public const int VIF_DIFFLANG = 8;

        /// VIF_DIFFCODEPG -> 0x00000010L
        public const int VIF_DIFFCODEPG = 16;

        /// VIF_CANNOTRENAME -> 0x00002000L
        public const int VIF_CANNOTRENAME = 8192;

        /// VIF_CANNOTREADSRC -> 0x00010000L
        public const int VIF_CANNOTREADSRC = 65536;

        /// VIF_CANNOTREADDST -> 0x00020000L
        public const int VIF_CANNOTREADDST = 131072;

        /// VIF_CANNOTLOADLZ32 -> 0x00080000L
        public const int VIF_CANNOTLOADLZ32 = 524288;

        /// VIF_CANNOTLOADCABINET -> 0x00100000L
        public const int VIF_CANNOTLOADCABINET = 1048576;

        /// VIF_CANNOTDELETECUR -> 0x00004000L
        public const int VIF_CANNOTDELETECUR = 16384;

        /// VIF_CANNOTDELETE -> 0x00001000L
        public const int VIF_CANNOTDELETE = 4096;

        /// VIF_CANNOTCREATE -> 0x00000800L
        public const int VIF_CANNOTCREATE = 2048;

        /// VIF_BUFFTOOSMALL -> 0x00040000L
        public const int VIF_BUFFTOOSMALL = 262144;

        /// VIF_ACCESSVIOLATION -> 0x00000200L
        public const int VIF_ACCESSVIOLATION = 512;

        /// VIFF_FORCEINSTALL -> 0x0001
        public const int VIFF_FORCEINSTALL = 1;

        /// VIFF_DONTDELETEOLD -> 0x0002
        public const int VIFF_DONTDELETEOLD = 2;

        /// VIEW_S_LAST -> 0x0004014FL
        public const int VIEW_S_LAST = 262479;

        /// VIEW_S_FIRST -> 0x00040140L
        public const int VIEW_S_FIRST = 262464;

        /// VIEW_E_LAST -> 0x8004014FL
        public const int VIEW_E_LAST = -2147221169;

        /// VIEW_E_FIRST -> 0x80040140L
        public const int VIEW_E_FIRST = -2147221184;

        /// VIETNAMESE_CHARSET -> 163
        public const int VIETNAMESE_CHARSET = 163;

        /// VFT_VXD -> 0x00000005L
        public const int VFT_VXD = 5;

        /// VFT_UNKNOWN -> 0x00000000L
        public const int VFT_UNKNOWN = 0;

        /// VFT_STATIC_LIB -> 0x00000007L
        public const int VFT_STATIC_LIB = 7;

        /// VFT_FONT -> 0x00000004L
        public const int VFT_FONT = 4;

        /// VFT_DRV -> 0x00000003L
        public const int VFT_DRV = 3;

        /// VFT_DLL -> 0x00000002L
        public const int VFT_DLL = 2;

        /// VFT_APP -> 0x00000001L
        public const int VFT_APP = 1;

        /// VFT2_UNKNOWN -> 0x00000000L
        public const int VFT2_UNKNOWN = 0;

        /// VFT2_FONT_VECTOR -> 0x00000002L
        public const int VFT2_FONT_VECTOR = 2;

        /// VFT2_FONT_TRUETYPE -> 0x00000003L
        public const int VFT2_FONT_TRUETYPE = 3;

        /// VFT2_FONT_RASTER -> 0x00000001L
        public const int VFT2_FONT_RASTER = 1;

        /// VFT2_DRV_VERSIONED_PRINTER -> 0x0000000CL
        public const int VFT2_DRV_VERSIONED_PRINTER = 12;

        /// VFT2_DRV_SYSTEM -> 0x00000007L
        public const int VFT2_DRV_SYSTEM = 7;

        /// VFT2_DRV_SOUND -> 0x00000009L
        public const int VFT2_DRV_SOUND = 9;

        /// VFT2_DRV_PRINTER -> 0x00000001L
        public const int VFT2_DRV_PRINTER = 1;

        /// VFT2_DRV_NETWORK -> 0x00000006L
        public const int VFT2_DRV_NETWORK = 6;

        /// VFT2_DRV_MOUSE -> 0x00000005L
        public const int VFT2_DRV_MOUSE = 5;

        /// VFT2_DRV_LANGUAGE -> 0x00000003L
        public const int VFT2_DRV_LANGUAGE = 3;

        /// VFT2_DRV_KEYBOARD -> 0x00000002L
        public const int VFT2_DRV_KEYBOARD = 2;

        /// VFT2_DRV_INSTALLABLE -> 0x00000008L
        public const int VFT2_DRV_INSTALLABLE = 8;

        /// VFT2_DRV_INPUTMETHOD -> 0x0000000BL
        public const int VFT2_DRV_INPUTMETHOD = 11;

        /// VFT2_DRV_DISPLAY -> 0x00000004L
        public const int VFT2_DRV_DISPLAY = 4;

        /// VFT2_DRV_COMM -> 0x0000000AL
        public const int VFT2_DRV_COMM = 10;

        /// VFF_FILEINUSE -> 0x0002
        public const int VFF_FILEINUSE = 2;

        /// VFF_CURNEDEST -> 0x0001
        public const int VFF_CURNEDEST = 1;

        /// VFF_BUFFTOOSMALL -> 0x0004
        public const int VFF_BUFFTOOSMALL = 4;

        /// VFFF_ISSHAREDFILE -> 0x0001
        public const int VFFF_ISSHAREDFILE = 1;

        /// VER_WORKSTATION_NT -> 0x40000000
        public const int VER_WORKSTATION_NT = 1073741824;

        /// VER_SUITE_TERMINAL -> 0x00000010
        public const int VER_SUITE_TERMINAL = 16;

        /// VER_SUITE_STORAGE_SERVER -> 0x00002000
        public const int VER_SUITE_STORAGE_SERVER = 8192;

        /// VER_SUITE_SMALLBUSINESS_RESTRICTED -> 0x00000020
        public const int VER_SUITE_SMALLBUSINESS_RESTRICTED = 32;

        /// VER_SUITE_SMALLBUSINESS -> 0x00000001
        public const int VER_SUITE_SMALLBUSINESS = 1;

        /// VER_SUITE_SINGLEUSERTS -> 0x00000100
        public const int VER_SUITE_SINGLEUSERTS = 256;

        /// VER_SUITE_SECURITY_APPLIANCE -> 0x00001000
        public const int VER_SUITE_SECURITY_APPLIANCE = 4096;

        /// VER_SUITE_PERSONAL -> 0x00000200
        public const int VER_SUITE_PERSONAL = 512;

        /// VER_SUITE_ENTERPRISE -> 0x00000002
        public const int VER_SUITE_ENTERPRISE = 2;

        /// VER_SUITE_EMBEDDED_RESTRICTED -> 0x00000800
        public const int VER_SUITE_EMBEDDED_RESTRICTED = 2048;

        /// VER_SUITE_EMBEDDEDNT -> 0x00000040
        public const int VER_SUITE_EMBEDDEDNT = 64;

        /// VER_SUITE_DATACENTER -> 0x00000080
        public const int VER_SUITE_DATACENTER = 128;

        /// VER_SUITE_COMPUTE_SERVER -> 0x00004000
        public const int VER_SUITE_COMPUTE_SERVER = 16384;

        /// VER_SUITE_COMMUNICATIONS -> 0x00000008
        public const int VER_SUITE_COMMUNICATIONS = 8;

        /// VER_SUITE_BLADE -> 0x00000400
        public const int VER_SUITE_BLADE = 1024;

        /// VER_SUITE_BACKOFFICE -> 0x00000004
        public const int VER_SUITE_BACKOFFICE = 4;

        /// VER_SUITENAME -> 0x0000040
        public const int VER_SUITENAME = 64;

        /// VER_SERVICEPACKMINOR -> 0x0000010
        public const int VER_SERVICEPACKMINOR = 16;

        /// VER_SERVICEPACKMAJOR -> 0x0000020
        public const int VER_SERVICEPACKMAJOR = 32;

        /// VER_SERVER_NT -> 0x80000000
        public const int VER_SERVER_NT = -2147483648;

        /// VER_PRODUCT_TYPE -> 0x0000080
        public const int VER_PRODUCT_TYPE = 128;

        /// VER_PLATFORM_WIN32_WINDOWS -> 1
        public const int VER_PLATFORM_WIN32_WINDOWS = 1;

        /// VER_PLATFORM_WIN32_NT -> 2
        public const int VER_PLATFORM_WIN32_NT = 2;

        /// VER_PLATFORM_WIN32s -> 0
        public const int VER_PLATFORM_WIN32s = 0;

        /// VER_PLATFORMID -> 0x0000008
        public const int VER_PLATFORMID = 8;

        /// VER_OR -> 7
        public const int VER_OR = 7;

        /// VER_NUM_BITS_PER_CONDITION_MASK -> 3
        public const int VER_NUM_BITS_PER_CONDITION_MASK = 3;

        /// VER_NT_WORKSTATION -> 0x0000001
        public const int VER_NT_WORKSTATION = 1;

        /// VER_NT_SERVER -> 0x0000003
        public const int VER_NT_SERVER = 3;

        /// VER_NT_DOMAIN_CONTROLLER -> 0x0000002
        public const int VER_NT_DOMAIN_CONTROLLER = 2;

        /// VER_MINORVERSION -> 0x0000001
        public const int VER_MINORVERSION = 1;

        /// VER_MAJORVERSION -> 0x0000002
        public const int VER_MAJORVERSION = 2;

        /// VER_LESS_EQUAL -> 5
        public const int VER_LESS_EQUAL = 5;

        /// VER_LESS -> 4
        public const int VER_LESS = 4;

        /// VER_GREATER_EQUAL -> 3
        public const int VER_GREATER_EQUAL = 3;

        /// VER_GREATER -> 2
        public const int VER_GREATER = 2;

        /// VER_EQUAL -> 1
        public const int VER_EQUAL = 1;

        /// VER_CONDITION_MASK -> 7
        public const int VER_CONDITION_MASK = 7;

        /// VER_BUILDNUMBER -> 0x0000004
        public const int VER_BUILDNUMBER = 4;

        /// VER_AND -> 6
        public const int VER_AND = 6;

        /// VERTSIZE -> 6
        public const int VERTSIZE = 6;

        /// VERTRES -> 10
        public const int VERTRES = 10;

        /// VerQueryValue -> VerQueryValueW
        /// Error generating expression: Value VerQueryValueW is not resolved
        public const string VerQueryValue = "VerQueryValueW";

        /// VerLanguageName -> VerLanguageNameW
        /// Error generating expression: Value VerLanguageNameW is not resolved
        public const string VerLanguageName = "VerLanguageNameW";

        /// VerInstallFile -> VerInstallFileW
        /// Error generating expression: Value VerInstallFileW is not resolved
        public const string VerInstallFile = "VerInstallFileW";

        /// VerifyVersionInfo -> VerifyVersionInfoW
        /// Error generating expression: Value VerifyVersionInfoW is not resolved
        public const string VerifyVersionInfo = "VerifyVersionInfoW";

        /// VerFindFile -> VerFindFileW
        /// Error generating expression: Value VerFindFileW is not resolved
        public const string VerFindFile = "VerFindFileW";

        /// VENDOR_ID_LENGTH -> 8
        public const int VENDOR_ID_LENGTH = 8;

        /// va_start -> _crt_va_start
        public const string va_start = NativeConstants._crt_va_start;

        /// va_end -> _crt_va_end
        public const string va_end = NativeConstants._crt_va_end;

        /// va_arg -> _crt_va_arg
        public const string va_arg = NativeConstants._crt_va_arg;

        /// VarUintFromUI8 -> VarUI4FromUI8
        /// Error generating expression: Value VarUI4FromUI8 is not resolved
        public const string VarUintFromUI8 = "VarUI4FromUI8";

        /// VarUintFromUI4 -> VarUI4FromUI4
        public const string VarUintFromUI4 = NativeConstants.VarUI4FromUI4;

        /// VarUintFromUI2 -> VarUI4FromUI2
        /// Error generating expression: Value VarUI4FromUI2 is not resolved
        public const string VarUintFromUI2 = "VarUI4FromUI2";

        /// VarUintFromUI1 -> VarUI4FromUI1
        /// Error generating expression: Value VarUI4FromUI1 is not resolved
        public const string VarUintFromUI1 = "VarUI4FromUI1";

        /// VarUintFromStr -> VarUI4FromStr
        /// Error generating expression: Value VarUI4FromStr is not resolved
        public const string VarUintFromStr = "VarUI4FromStr";

        /// VarUintFromR8 -> VarUI4FromR8
        /// Error generating expression: Value VarUI4FromR8 is not resolved
        public const string VarUintFromR8 = "VarUI4FromR8";

        /// VarUintFromR4 -> VarUI4FromR4
        /// Error generating expression: Value VarUI4FromR4 is not resolved
        public const string VarUintFromR4 = "VarUI4FromR4";

        /// VarUintFromInt -> VarUI4FromI4
        /// Error generating expression: Value VarUI4FromI4 is not resolved
        public const string VarUintFromInt = "VarUI4FromI4";

        /// VarUintFromI8 -> VarUI4FromI8
        /// Error generating expression: Value VarUI4FromI8 is not resolved
        public const string VarUintFromI8 = "VarUI4FromI8";

        /// VarUintFromI4 -> VarUI4FromI4
        /// Error generating expression: Value VarUI4FromI4 is not resolved
        public const string VarUintFromI4 = "VarUI4FromI4";

        /// VarUintFromI2 -> VarUI4FromI2
        /// Error generating expression: Value VarUI4FromI2 is not resolved
        public const string VarUintFromI2 = "VarUI4FromI2";

        /// VarUintFromI1 -> VarUI4FromI1
        /// Error generating expression: Value VarUI4FromI1 is not resolved
        public const string VarUintFromI1 = "VarUI4FromI1";

        /// VarUintFromDisp -> VarUI4FromDisp
        /// Error generating expression: Value VarUI4FromDisp is not resolved
        public const string VarUintFromDisp = "VarUI4FromDisp";

        /// VarUintFromDec -> VarUI4FromDec
        /// Error generating expression: Value VarUI4FromDec is not resolved
        public const string VarUintFromDec = "VarUI4FromDec";

        /// VarUintFromDate -> VarUI4FromDate
        /// Error generating expression: Value VarUI4FromDate is not resolved
        public const string VarUintFromDate = "VarUI4FromDate";

        /// VarUintFromCy -> VarUI4FromCy
        /// Error generating expression: Value VarUI4FromCy is not resolved
        public const string VarUintFromCy = "VarUI4FromCy";

        /// VarUintFromBool -> VarUI4FromBool
        /// Error generating expression: Value VarUI4FromBool is not resolved
        public const string VarUintFromBool = "VarUI4FromBool";

        /// VarUI4FromUint -> VarUI4FromUI4
        public const string VarUI4FromUint = NativeConstants.VarUI4FromUI4;

        /// VarUI4FromInt -> VarUI4FromI4
        /// Error generating expression: Value VarUI4FromI4 is not resolved
        public const string VarUI4FromInt = "VarUI4FromI4";

        /// VarUI2FromUint -> VarUI2FromUI4
        /// Error generating expression: Value VarUI2FromUI4 is not resolved
        public const string VarUI2FromUint = "VarUI2FromUI4";

        /// VarUI2FromInt -> VarUI2FromI4
        /// Error generating expression: Value VarUI2FromI4 is not resolved
        public const string VarUI2FromInt = "VarUI2FromI4";

        /// VarUI1FromUint -> VarUI1FromUI4
        /// Error generating expression: Value VarUI1FromUI4 is not resolved
        public const string VarUI1FromUint = "VarUI1FromUI4";

        /// VarUI1FromInt -> VarUI1FromI4
        /// Error generating expression: Value VarUI1FromI4 is not resolved
        public const string VarUI1FromInt = "VarUI1FromI4";

        /// VarR8FromUint -> VarR8FromUI4
        /// Error generating expression: Value VarR8FromUI4 is not resolved
        public const string VarR8FromUint = "VarR8FromUI4";

        /// VarR8FromInt -> VarR8FromI4
        /// Error generating expression: Value VarR8FromI4 is not resolved
        public const string VarR8FromInt = "VarR8FromI4";

        /// VarR4FromUint -> VarR4FromUI4
        /// Error generating expression: Value VarR4FromUI4 is not resolved
        public const string VarR4FromUint = "VarR4FromUI4";

        /// VarR4FromInt -> VarR4FromI4
        /// Error generating expression: Value VarR4FromI4 is not resolved
        public const string VarR4FromInt = "VarR4FromI4";

        /// VarIntFromUint -> VarI4FromUI4
        /// Error generating expression: Value VarI4FromUI4 is not resolved
        public const string VarIntFromUint = "VarI4FromUI4";

        /// VarIntFromUI8 -> VarI4FromUI8
        /// Error generating expression: Value VarI4FromUI8 is not resolved
        public const string VarIntFromUI8 = "VarI4FromUI8";

        /// VarIntFromUI4 -> VarI4FromUI4
        /// Error generating expression: Value VarI4FromUI4 is not resolved
        public const string VarIntFromUI4 = "VarI4FromUI4";

        /// VarIntFromUI2 -> VarI4FromUI2
        /// Error generating expression: Value VarI4FromUI2 is not resolved
        public const string VarIntFromUI2 = "VarI4FromUI2";

        /// VarIntFromUI1 -> VarI4FromUI1
        /// Error generating expression: Value VarI4FromUI1 is not resolved
        public const string VarIntFromUI1 = "VarI4FromUI1";

        /// VarIntFromStr -> VarI4FromStr
        /// Error generating expression: Value VarI4FromStr is not resolved
        public const string VarIntFromStr = "VarI4FromStr";

        /// VarIntFromR8 -> VarI4FromR8
        /// Error generating expression: Value VarI4FromR8 is not resolved
        public const string VarIntFromR8 = "VarI4FromR8";

        /// VarIntFromR4 -> VarI4FromR4
        /// Error generating expression: Value VarI4FromR4 is not resolved
        public const string VarIntFromR4 = "VarI4FromR4";

        /// VarIntFromI8 -> VarI4FromI8
        /// Error generating expression: Value VarI4FromI8 is not resolved
        public const string VarIntFromI8 = "VarI4FromI8";

        /// VarIntFromI4 -> VarI4FromI4
        public const string VarIntFromI4 = NativeConstants.VarI4FromI4;

        /// VarIntFromI2 -> VarI4FromI2
        /// Error generating expression: Value VarI4FromI2 is not resolved
        public const string VarIntFromI2 = "VarI4FromI2";

        /// VarIntFromI1 -> VarI4FromI1
        /// Error generating expression: Value VarI4FromI1 is not resolved
        public const string VarIntFromI1 = "VarI4FromI1";

        /// VarIntFromDisp -> VarI4FromDisp
        /// Error generating expression: Value VarI4FromDisp is not resolved
        public const string VarIntFromDisp = "VarI4FromDisp";

        /// VarIntFromDec -> VarI4FromDec
        /// Error generating expression: Value VarI4FromDec is not resolved
        public const string VarIntFromDec = "VarI4FromDec";

        /// VarIntFromDate -> VarI4FromDate
        /// Error generating expression: Value VarI4FromDate is not resolved
        public const string VarIntFromDate = "VarI4FromDate";

        /// VarIntFromCy -> VarI4FromCy
        /// Error generating expression: Value VarI4FromCy is not resolved
        public const string VarIntFromCy = "VarI4FromCy";

        /// VarIntFromBool -> VarI4FromBool
        /// Error generating expression: Value VarI4FromBool is not resolved
        public const string VarIntFromBool = "VarI4FromBool";

        /// VARIANT_USE_NLS -> 0x80
        public const int VARIANT_USE_NLS = 128;

        /// VARIANT_TRUE -> ((VARIANT_BOOL)-1)
        /// Error generating expression: Value VARIANT_BOOL is not resolved
        public const string VARIANT_TRUE = "((VARIANT_BOOL)-1)";

        /// VARIANT_NOVALUEPROP -> 0x01
        public const int VARIANT_NOVALUEPROP = 1;

        /// VARIANT_NOUSEROVERRIDE -> 0x04
        public const int VARIANT_NOUSEROVERRIDE = 4;

        /// VARIANT_LOCALBOOL -> 0x10
        public const int VARIANT_LOCALBOOL = 16;

        /// VARIANT_CALENDAR_THAI -> 0x20
        public const int VARIANT_CALENDAR_THAI = 32;

        /// VARIANT_CALENDAR_HIJRI -> 0x08
        public const int VARIANT_CALENDAR_HIJRI = 8;

        /// VARIANT_CALENDAR_GREGORIAN -> 0x40
        public const int VARIANT_CALENDAR_GREGORIAN = 64;

        /// VARIANT_ALPHABOOL -> 0x02
        public const int VARIANT_ALPHABOOL = 2;

        /// VARIABLE_PITCH -> 2
        public const int VARIABLE_PITCH = 2;

        /// VarI8FromUint -> VarI8FromUI4
        /// Error generating expression: Value VarI8FromUI4 is not resolved
        public const string VarI8FromUint = "VarI8FromUI4";

        /// VarI8FromInt -> VarI8FromI4
        /// Error generating expression: Value VarI8FromI4 is not resolved
        public const string VarI8FromInt = "VarI8FromI4";

        /// VarI4FromUint -> VarI4FromUI4
        /// Error generating expression: Value VarI4FromUI4 is not resolved
        public const string VarI4FromUint = "VarI4FromUI4";

        /// VarI4FromInt -> VarI4FromI4
        public const string VarI4FromInt = NativeConstants.VarI4FromI4;

        /// VarI2FromUint -> VarI2FromUI4
        /// Error generating expression: Value VarI2FromUI4 is not resolved
        public const string VarI2FromUint = "VarI2FromUI4";

        /// VarI2FromInt -> VarI2FromI4
        /// Error generating expression: Value VarI2FromI4 is not resolved
        public const string VarI2FromInt = "VarI2FromI4";

        /// VarI1FromUint -> VarI1FromUI4
        /// Error generating expression: Value VarI1FromUI4 is not resolved
        public const string VarI1FromUint = "VarI1FromUI4";

        /// VarI1FromInt -> VarI1FromI4
        /// Error generating expression: Value VarI1FromI4 is not resolved
        public const string VarI1FromInt = "VarI1FromI4";

        /// VarDecFromUint -> VarDecFromUI4
        /// Error generating expression: Value VarDecFromUI4 is not resolved
        public const string VarDecFromUint = "VarDecFromUI4";

        /// VarDecFromInt -> VarDecFromI4
        /// Error generating expression: Value VarDecFromI4 is not resolved
        public const string VarDecFromInt = "VarDecFromI4";

        /// VarDateFromUint -> VarDateFromUI4
        /// Error generating expression: Value VarDateFromUI4 is not resolved
        public const string VarDateFromUint = "VarDateFromUI4";

        /// VarDateFromInt -> VarDateFromI4
        /// Error generating expression: Value VarDateFromI4 is not resolved
        public const string VarDateFromInt = "VarDateFromI4";

        /// VarCyFromUint -> VarCyFromUI4
        /// Error generating expression: Value VarCyFromUI4 is not resolved
        public const string VarCyFromUint = "VarCyFromUI4";

        /// VarCyFromInt -> VarCyFromI4
        /// Error generating expression: Value VarCyFromI4 is not resolved
        public const string VarCyFromInt = "VarCyFromI4";

        /// VARCMP_NULL -> 3
        public const int VARCMP_NULL = 3;

        /// VARCMP_LT -> 0
        public const int VARCMP_LT = 0;

        /// VARCMP_GT -> 2
        public const int VARCMP_GT = 2;

        /// VARCMP_EQ -> 1
        public const int VARCMP_EQ = 1;

        /// VarBstrFromUint -> VarBstrFromUI4
        /// Error generating expression: Value VarBstrFromUI4 is not resolved
        public const string VarBstrFromUint = "VarBstrFromUI4";

        /// VarBstrFromInt -> VarBstrFromI4
        /// Error generating expression: Value VarBstrFromI4 is not resolved
        public const string VarBstrFromInt = "VarBstrFromI4";

        /// VarBoolFromUint -> VarBoolFromUI4
        /// Error generating expression: Value VarBoolFromUI4 is not resolved
        public const string VarBoolFromUint = "VarBoolFromUI4";

        /// VarBoolFromInt -> VarBoolFromI4
        /// Error generating expression: Value VarBoolFromI4 is not resolved
        public const string VarBoolFromInt = "VarBoolFromI4";

        /// VALID_NTFT -> 0xC0
        public const int VALID_NTFT = 192;

        /// VALID_INHERIT_FLAGS -> (0x1F)
        public const int VALID_INHERIT_FLAGS = 31;

        /// VALID_AUDIT_POLICY_BITS -> (TOKEN_AUDIT_SUCCESS_INCLUDE |                                  TOKEN_AUDIT_SUCCESS_EXCLUDE |                                  TOKEN_AUDIT_FAILURE_INCLUDE |                                  TOKEN_AUDIT_FAILURE_EXCLUDE)
        public const int VALID_AUDIT_POLICY_BITS = (NativeConstants.TOKEN_AUDIT_SUCCESS_INCLUDE
                    | (NativeConstants.TOKEN_AUDIT_SUCCESS_EXCLUDE
                    | (NativeConstants.TOKEN_AUDIT_FAILURE_INCLUDE | NativeConstants.TOKEN_AUDIT_FAILURE_EXCLUDE)));

        /// Warning: Generation of Method Macros is not supported at this time
        /// VarUI4FromUI4 -> "(in,pOut) (*(pOut) = (in))"
        public const string VarUI4FromUI4 = "(in,pOut) (*(pOut) = (in))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// VarI4FromI4 -> "(in,pOut) (*(pOut) = (in))"
        public const string VarI4FromI4 = "(in,pOut) (*(pOut) = (in))";
    }

}
