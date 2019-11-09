using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// TWOSTOPBITS -> 2
        public const int TWOSTOPBITS = 2;

        /// TURKISH_CHARSET -> 162
        public const int TURKISH_CHARSET = 162;

        /// TT_PRIM_QSPLINE -> 2
        public const int TT_PRIM_QSPLINE = 2;

        /// TT_PRIM_LINE -> 1
        public const int TT_PRIM_LINE = 1;

        /// TT_PRIM_CSPLINE -> 3
        public const int TT_PRIM_CSPLINE = 3;

        /// TT_POLYGON_TYPE -> 24
        public const int TT_POLYGON_TYPE = 24;

        /// TT_ENABLED -> 0x0002
        public const int TT_ENABLED = 2;

        /// TT_AVAILABLE -> 0x0001
        public const int TT_AVAILABLE = 1;

        /// TRY_AGAIN -> WSATRY_AGAIN
        public const int TRY_AGAIN = NativeConstants.WSATRY_AGAIN;

        /// TRUNCATE_EXISTING -> 5
        public const int TRUNCATE_EXISTING = 5;

        /// TRUETYPE_FONTTYPE -> 0x004
        public const int TRUETYPE_FONTTYPE = 4;

        /// TRUE -> 1
        public const int TRUE = 1;

        /// TRANSPORT_TYPE_WMSG -> 0x08
        public const int TRANSPORT_TYPE_WMSG = 8;

        /// TRANSPORT_TYPE_LPC -> 0x04
        public const int TRANSPORT_TYPE_LPC = 4;

        /// TRANSPORT_TYPE_DG -> 0x02
        public const int TRANSPORT_TYPE_DG = 2;

        /// TRANSPORT_TYPE_CN -> 0x01
        public const int TRANSPORT_TYPE_CN = 1;

        /// TRANSPARENT -> 1
        public const int TRANSPARENT = 1;

        /// TranslateAccelerator -> TranslateAcceleratorW
        /// Error generating expression: Value TranslateAcceleratorW is not resolved
        public const string TranslateAccelerator = "TranslateAcceleratorW";

        /// TRANSFORM_CTM -> 4107
        public const int TRANSFORM_CTM = 4107;

        /// TPM_VERTICAL -> 0x0040L
        public const int TPM_VERTICAL = 64;

        /// TPM_VERPOSANIMATION -> 0x1000L
        public const int TPM_VERPOSANIMATION = 4096;

        /// TPM_VERNEGANIMATION -> 0x2000L
        public const int TPM_VERNEGANIMATION = 8192;

        /// TPM_VCENTERALIGN -> 0x0010L
        public const int TPM_VCENTERALIGN = 16;

        /// TPM_TOPALIGN -> 0x0000L
        public const int TPM_TOPALIGN = 0;

        /// TPM_RIGHTBUTTON -> 0x0002L
        public const int TPM_RIGHTBUTTON = 2;

        /// TPM_RIGHTALIGN -> 0x0008L
        public const int TPM_RIGHTALIGN = 8;

        /// TPM_RETURNCMD -> 0x0100L
        public const int TPM_RETURNCMD = 256;

        /// TPM_RECURSE -> 0x0001L
        public const int TPM_RECURSE = 1;

        /// TPM_NONOTIFY -> 0x0080L
        public const int TPM_NONOTIFY = 128;

        /// TPM_NOANIMATION -> 0x4000L
        public const int TPM_NOANIMATION = 16384;

        /// TPM_LEFTBUTTON -> 0x0000L
        public const int TPM_LEFTBUTTON = 0;

        /// TPM_LEFTALIGN -> 0x0000L
        public const int TPM_LEFTALIGN = 0;

        /// TPM_LAYOUTRTL -> 0x8000L
        public const int TPM_LAYOUTRTL = 32768;

        /// TPM_HORPOSANIMATION -> 0x0400L
        public const int TPM_HORPOSANIMATION = 1024;

        /// TPM_HORNEGANIMATION -> 0x0800L
        public const int TPM_HORNEGANIMATION = 2048;

        /// TPM_HORIZONTAL -> 0x0000L
        public const int TPM_HORIZONTAL = 0;

        /// TPM_CENTERALIGN -> 0x0004L
        public const int TPM_CENTERALIGN = 4;

        /// TPM_BOTTOMALIGN -> 0x0020L
        public const int TPM_BOTTOMALIGN = 32;

        /// TOKEN_WRITE -> (STANDARD_RIGHTS_WRITE     |                          TOKEN_ADJUST_PRIVILEGES   |                          TOKEN_ADJUST_GROUPS       |                          TOKEN_ADJUST_DEFAULT)
        public const int TOKEN_WRITE = (NativeConstants.STANDARD_RIGHTS_WRITE
                    | (NativeConstants.TOKEN_ADJUST_PRIVILEGES
                    | (NativeConstants.TOKEN_ADJUST_GROUPS | NativeConstants.TOKEN_ADJUST_DEFAULT)));

        /// TOKEN_SOURCE_LENGTH -> 8
        public const int TOKEN_SOURCE_LENGTH = 8;

        /// TOKEN_READ -> (STANDARD_RIGHTS_READ      |                          TOKEN_QUERY)
        public const int TOKEN_READ = (NativeConstants.STANDARD_RIGHTS_READ | NativeConstants.TOKEN_QUERY);

        /// TOKEN_QUERY_SOURCE -> (0x0010)
        public const int TOKEN_QUERY_SOURCE = 16;

        /// TOKEN_QUERY -> (0x0008)
        public const int TOKEN_QUERY = 8;

        /// TOKEN_IMPERSONATE -> (0x0004)
        public const int TOKEN_IMPERSONATE = 4;

        /// TOKEN_EXECUTE -> (STANDARD_RIGHTS_EXECUTE)
        public const int TOKEN_EXECUTE = NativeConstants.STANDARD_RIGHTS_EXECUTE;

        /// TOKEN_DUPLICATE -> (0x0002)
        public const int TOKEN_DUPLICATE = 2;

        /// TOKEN_AUDIT_SUCCESS_INCLUDE -> 0x1
        public const int TOKEN_AUDIT_SUCCESS_INCLUDE = 1;

        /// TOKEN_AUDIT_SUCCESS_EXCLUDE -> 0x2
        public const int TOKEN_AUDIT_SUCCESS_EXCLUDE = 2;

        /// TOKEN_AUDIT_FAILURE_INCLUDE -> 0x4
        public const int TOKEN_AUDIT_FAILURE_INCLUDE = 4;

        /// TOKEN_AUDIT_FAILURE_EXCLUDE -> 0x8
        public const int TOKEN_AUDIT_FAILURE_EXCLUDE = 8;

        /// TOKEN_ASSIGN_PRIMARY -> (0x0001)
        public const int TOKEN_ASSIGN_PRIMARY = 1;

        /// TOKEN_ALL_ACCESS_P -> (STANDARD_RIGHTS_REQUIRED  |                          TOKEN_ASSIGN_PRIMARY      |                          TOKEN_DUPLICATE           |                          TOKEN_IMPERSONATE         |                          TOKEN_QUERY               |                          TOKEN_QUERY_SOURCE        |                          TOKEN_ADJUST_PRIVILEGES   |                          TOKEN_ADJUST_GROUPS       |                          TOKEN_ADJUST_DEFAULT )
        public const int TOKEN_ALL_ACCESS_P = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.TOKEN_ASSIGN_PRIMARY
                    | (NativeConstants.TOKEN_DUPLICATE
                    | (NativeConstants.TOKEN_IMPERSONATE
                    | (NativeConstants.TOKEN_QUERY
                    | (NativeConstants.TOKEN_QUERY_SOURCE
                    | (NativeConstants.TOKEN_ADJUST_PRIVILEGES
                    | (NativeConstants.TOKEN_ADJUST_GROUPS | NativeConstants.TOKEN_ADJUST_DEFAULT))))))));

        /// TOKEN_ALL_ACCESS -> (TOKEN_ALL_ACCESS_P |                          TOKEN_ADJUST_SESSIONID )
        public const int TOKEN_ALL_ACCESS = (NativeConstants.TOKEN_ALL_ACCESS_P | NativeConstants.TOKEN_ADJUST_SESSIONID);

        /// TOKEN_ADJUST_SESSIONID -> (0x0100)
        public const int TOKEN_ADJUST_SESSIONID = 256;

        /// TOKEN_ADJUST_PRIVILEGES -> (0x0020)
        public const int TOKEN_ADJUST_PRIVILEGES = 32;

        /// TOKEN_ADJUST_GROUPS -> (0x0040)
        public const int TOKEN_ADJUST_GROUPS = 64;

        /// TOKEN_ADJUST_DEFAULT -> (0x0080)
        public const int TOKEN_ADJUST_DEFAULT = 128;

        /// TMPF_VECTOR -> 0x02
        public const int TMPF_VECTOR = 2;

        /// TMPF_TRUETYPE -> 0x04
        public const int TMPF_TRUETYPE = 4;

        /// TMPF_FIXED_PITCH -> 0x01
        public const int TMPF_FIXED_PITCH = 1;

        /// TMPF_DEVICE -> 0x08
        public const int TMPF_DEVICE = 8;

        /// TME_QUERY -> 0x40000000
        public const int TME_QUERY = 1073741824;

        /// TME_NONCLIENT -> 0x00000010
        public const int TME_NONCLIENT = 16;

        /// TME_LEAVE -> 0x00000002
        public const int TME_LEAVE = 2;

        /// TME_HOVER -> 0x00000001
        public const int TME_HOVER = 1;

        /// TME_CANCEL -> 0x80000000
        public const int TME_CANCEL = -2147483648;

        /// TLS_MINIMUM_AVAILABLE -> 64
        public const int TLS_MINIMUM_AVAILABLE = 64;

        /// TKF_TOGGLEKEYSON -> 0x00000001
        public const int TKF_TOGGLEKEYSON = 1;

        /// TKF_INDICATOR -> 0x00000020
        public const int TKF_INDICATOR = 32;

        /// TKF_HOTKEYSOUND -> 0x00000010
        public const int TKF_HOTKEYSOUND = 16;

        /// TKF_HOTKEYACTIVE -> 0x00000004
        public const int TKF_HOTKEYACTIVE = 4;

        /// TKF_CONFIRMHOTKEY -> 0x00000008
        public const int TKF_CONFIRMHOTKEY = 8;

        /// TKF_AVAILABLE -> 0x00000002
        public const int TKF_AVAILABLE = 2;

        /// TIME_ZONE_ID_UNKNOWN -> 0
        public const int TIME_ZONE_ID_UNKNOWN = 0;

        /// TIME_ZONE_ID_STANDARD -> 1
        public const int TIME_ZONE_ID_STANDARD = 1;

        /// TIME_ZONE_ID_DAYLIGHT -> 2
        public const int TIME_ZONE_ID_DAYLIGHT = 2;

        /// TIME_VALID_OID_GET_OBJECT_FUNC -> "TimeValidDllGetObject"
        public const string TIME_VALID_OID_GET_OBJECT_FUNC = "TimeValidDllGetObject";

        /// TIME_VALID_OID_FLUSH_OBJECT_FUNC -> "TimeValidDllFlushObject"
        public const string TIME_VALID_OID_FLUSH_OBJECT_FUNC = "TimeValidDllFlushObject";

        /// TIME_TICKS -> 0x0020
        public const int TIME_TICKS = 32;

        /// TIME_SMPTE -> 0x0008
        public const int TIME_SMPTE = 8;

        /// TIME_SAMPLES -> 0x0002
        public const int TIME_SAMPLES = 2;

        /// TIME_PERIODIC -> 0x0001
        public const int TIME_PERIODIC = 1;

        /// TIME_ONESHOT -> 0x0000
        public const int TIME_ONESHOT = 0;

        /// TIME_NOTIMEMARKER -> 0x00000004
        public const int TIME_NOTIMEMARKER = 4;

        /// TIME_NOSECONDS -> 0x00000002
        public const int TIME_NOSECONDS = 2;

        /// TIME_NOMINUTESORSECONDS -> 0x00000001
        public const int TIME_NOMINUTESORSECONDS = 1;

        /// TIME_MS -> 0x0001
        public const int TIME_MS = 1;

        /// TIME_MIDI -> 0x0010
        public const int TIME_MIDI = 16;

        /// TIME_KILL_SYNCHRONOUS -> 0x0100
        public const int TIME_KILL_SYNCHRONOUS = 256;

        /// TIME_FORCE24HOURFORMAT -> 0x00000008
        public const int TIME_FORCE24HOURFORMAT = 8;

        /// TIME_CALLBACK_FUNCTION -> 0x0000
        public const int TIME_CALLBACK_FUNCTION = 0;

        /// TIME_CALLBACK_EVENT_SET -> 0x0010
        public const int TIME_CALLBACK_EVENT_SET = 16;

        /// TIME_CALLBACK_EVENT_PULSE -> 0x0020
        public const int TIME_CALLBACK_EVENT_PULSE = 32;

        /// TIME_BYTES -> 0x0004
        public const int TIME_BYTES = 4;

        /// TIMER_QUERY_STATE -> 0x0001
        public const int TIMER_QUERY_STATE = 1;

        /// TIMER_MODIFY_STATE -> 0x0002
        public const int TIMER_MODIFY_STATE = 2;

        /// TIMER_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|                          TIMER_QUERY_STATE|TIMER_MODIFY_STATE)
        public const int TIMER_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE
                    | (NativeConstants.TIMER_QUERY_STATE | NativeConstants.TIMER_MODIFY_STATE)));

        /// TIMERR_STRUCT -> (TIMERR_BASE+33)
        public const int TIMERR_STRUCT = (NativeConstants.TIMERR_BASE + 33);

        /// TIMERR_NOERROR -> (0)
        public const int TIMERR_NOERROR = 0;

        /// TIMERR_NOCANDO -> (TIMERR_BASE+1)
        public const int TIMERR_NOCANDO = (NativeConstants.TIMERR_BASE + 1);

        /// TIMERR_BASE -> 96
        public const int TIMERR_BASE = 96;

        /// TIMEOUT_ASYNC -> 0xFFFFFFFF
        public const int TIMEOUT_ASYNC = -1;

        /// TIMEFMT_ENUMPROC -> TIMEFMT_ENUMPROCW
        /// Error generating expression: Value TIMEFMT_ENUMPROCW is not resolved
        public const string TIMEFMT_ENUMPROC = "TIMEFMT_ENUMPROCW";

        /// THREAD_TERMINATE -> (0x0001)
        public const int THREAD_TERMINATE = 1;

        /// THREAD_SUSPEND_RESUME -> (0x0002)
        public const int THREAD_SUSPEND_RESUME = 2;

        /// THREAD_SET_THREAD_TOKEN -> (0x0080)
        public const int THREAD_SET_THREAD_TOKEN = 128;

        /// THREAD_SET_INFORMATION -> (0x0020)
        public const int THREAD_SET_INFORMATION = 32;

        /// THREAD_SET_CONTEXT -> (0x0010)
        public const int THREAD_SET_CONTEXT = 16;

        /// THREAD_QUERY_INFORMATION -> (0x0040)
        public const int THREAD_QUERY_INFORMATION = 64;

        /// THREAD_PRIORITY_TIME_CRITICAL -> THREAD_BASE_PRIORITY_LOWRT
        public const int THREAD_PRIORITY_TIME_CRITICAL = NativeConstants.THREAD_BASE_PRIORITY_LOWRT;

        /// THREAD_PRIORITY_NORMAL -> 0
        public const int THREAD_PRIORITY_NORMAL = 0;

        /// THREAD_PRIORITY_LOWEST -> THREAD_BASE_PRIORITY_MIN
        public const int THREAD_PRIORITY_LOWEST = NativeConstants.THREAD_BASE_PRIORITY_MIN;

        /// THREAD_PRIORITY_IDLE -> THREAD_BASE_PRIORITY_IDLE
        public const int THREAD_PRIORITY_IDLE = NativeConstants.THREAD_BASE_PRIORITY_IDLE;

        /// THREAD_PRIORITY_HIGHEST -> THREAD_BASE_PRIORITY_MAX
        public const int THREAD_PRIORITY_HIGHEST = NativeConstants.THREAD_BASE_PRIORITY_MAX;

        /// THREAD_PRIORITY_ERROR_RETURN -> (MAXLONG)
        public const int THREAD_PRIORITY_ERROR_RETURN = NativeConstants.MAXLONG;

        /// THREAD_PRIORITY_BELOW_NORMAL -> (THREAD_PRIORITY_LOWEST+1)
        public const int THREAD_PRIORITY_BELOW_NORMAL = (NativeConstants.THREAD_PRIORITY_LOWEST + 1);

        /// THREAD_PRIORITY_ABOVE_NORMAL -> (THREAD_PRIORITY_HIGHEST-1)
        public const int THREAD_PRIORITY_ABOVE_NORMAL = (NativeConstants.THREAD_PRIORITY_HIGHEST - 1);

        /// THREAD_IMPERSONATE -> (0x0100)
        public const int THREAD_IMPERSONATE = 256;

        /// THREAD_GET_CONTEXT -> (0x0008)
        public const int THREAD_GET_CONTEXT = 8;

        /// THREAD_DIRECT_IMPERSONATION -> (0x0200)
        public const int THREAD_DIRECT_IMPERSONATION = 512;

        /// THREAD_BASE_PRIORITY_MIN -> (-2)
        public const int THREAD_BASE_PRIORITY_MIN = -2;

        /// THREAD_BASE_PRIORITY_MAX -> 2
        public const int THREAD_BASE_PRIORITY_MAX = 2;

        /// THREAD_BASE_PRIORITY_LOWRT -> 15
        public const int THREAD_BASE_PRIORITY_LOWRT = 15;

        /// THREAD_BASE_PRIORITY_IDLE -> (-15)
        public const int THREAD_BASE_PRIORITY_IDLE = -15;

        /// THREAD_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE |                                    0x3FF)
        public const int THREAD_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE | 1023));

        /// THAI_CHARSET -> 222
        public const int THAI_CHARSET = 222;

        /// TF_WRITE_BEHIND -> 0x04
        public const int TF_WRITE_BEHIND = 4;

        /// TF_REUSE_SOCKET -> 0x02
        public const int TF_REUSE_SOCKET = 2;

        /// TF_DISCONNECT -> 0x01
        public const int TF_DISCONNECT = 1;

        /// TextOut -> TextOutW
        /// Error generating expression: Value TextOutW is not resolved
        public const string TextOut = "TextOutW";

        /// TEXTCAPS -> 34
        public const int TEXTCAPS = 34;

        /// TECHNOLOGY -> 2
        public const int TECHNOLOGY = 2;

        /// TC_VA_ABLE -> 0x00004000
        public const int TC_VA_ABLE = 16384;

        /// TC_UA_ABLE -> 0x00000800
        public const int TC_UA_ABLE = 2048;

        /// TC_SO_ABLE -> 0x00001000
        public const int TC_SO_ABLE = 4096;

        /// TC_SIGNAL -> 3
        public const int TC_SIGNAL = 3;

        /// TC_SF_X_YINDEP -> 0x00000020
        public const int TC_SF_X_YINDEP = 32;

        /// TC_SCROLLBLT -> 0x00010000
        public const int TC_SCROLLBLT = 65536;

        /// TC_SA_INTEGER -> 0x00000080
        public const int TC_SA_INTEGER = 128;

        /// TC_SA_DOUBLE -> 0x00000040
        public const int TC_SA_DOUBLE = 64;

        /// TC_SA_CONTIN -> 0x00000100
        public const int TC_SA_CONTIN = 256;

        /// TC_RESERVED -> 0x00008000
        public const int TC_RESERVED = 32768;

        /// TC_RA_ABLE -> 0x00002000
        public const int TC_RA_ABLE = 8192;

        /// TC_OP_STROKE -> 0x00000002
        public const int TC_OP_STROKE = 2;

        /// TC_OP_CHARACTER -> 0x00000001
        public const int TC_OP_CHARACTER = 1;

        /// TC_NORMAL -> 0
        public const int TC_NORMAL = 0;

        /// TC_IA_ABLE -> 0x00000400
        public const int TC_IA_ABLE = 1024;

        /// TC_HARDERR -> 1
        public const int TC_HARDERR = 1;

        /// TC_GP_TRAP -> 2
        public const int TC_GP_TRAP = 2;

        /// TC_EA_DOUBLE -> 0x00000200
        public const int TC_EA_DOUBLE = 512;

        /// TC_CR_ANY -> 0x00000010
        public const int TC_CR_ANY = 16;

        /// TC_CR_90 -> 0x00000008
        public const int TC_CR_90 = 8;

        /// TC_CP_STROKE -> 0x00000004
        public const int TC_CP_STROKE = 4;

        /// TCP_NODELAY -> 0x0001
        public const int TCP_NODELAY = 1;

        /// TCP_BSDURGENT -> 0x7000
        public const int TCP_BSDURGENT = 28672;

        /// TCI_SRCLOCALE -> 0x1000
        public const int TCI_SRCLOCALE = 4096;

        /// TCI_SRCFONTSIG -> 3
        public const int TCI_SRCFONTSIG = 3;

        /// TCI_SRCCODEPAGE -> 2
        public const int TCI_SRCCODEPAGE = 2;

        /// TCI_SRCCHARSET -> 1
        public const int TCI_SRCCHARSET = 1;

        /// TA_UPDATECP -> 1
        public const int TA_UPDATECP = 1;

        /// TA_TOP -> 0
        public const int TA_TOP = 0;

        /// TA_RTLREADING -> 256
        public const int TA_RTLREADING = 256;

        /// TA_RIGHT -> 2
        public const int TA_RIGHT = 2;

        /// TA_NOUPDATECP -> 0
        public const int TA_NOUPDATECP = 0;

        /// TA_MASK -> (TA_BASELINE+TA_CENTER+TA_UPDATECP+TA_RTLREADING)
        public const int TA_MASK = (NativeConstants.TA_BASELINE
                    + (NativeConstants.TA_CENTER
                    + (NativeConstants.TA_UPDATECP + NativeConstants.TA_RTLREADING)));

        /// TA_LEFT -> 0
        public const int TA_LEFT = 0;

        /// TA_CENTER -> 6
        public const int TA_CENTER = 6;

        /// TA_BOTTOM -> 8
        public const int TA_BOTTOM = 8;

        /// TA_BASELINE -> 24
        public const int TA_BASELINE = 24;

        /// TARGET_IS_NT51_OR_LATER -> 1
        public const int TARGET_IS_NT51_OR_LATER = 1;

        /// TARGET_IS_NT50_OR_LATER -> 1
        public const int TARGET_IS_NT50_OR_LATER = 1;

        /// TARGET_IS_NT40_OR_LATER -> 1
        public const int TARGET_IS_NT40_OR_LATER = 1;

        /// TARGET_IS_NT351_OR_WIN95_OR_LATER -> 1
        public const int TARGET_IS_NT351_OR_WIN95_OR_LATER = 1;

        /// TAPE_UNLOCK -> 4L
        public const int TAPE_UNLOCK = 4;

        /// TAPE_UNLOAD -> 1L
        public const int TAPE_UNLOAD = 1;

        /// TAPE_TENSION -> 2L
        public const int TAPE_TENSION = 2;

        /// TAPE_SPACE_SETMARKS -> 8L
        public const int TAPE_SPACE_SETMARKS = 8;

        /// TAPE_SPACE_SEQUENTIAL_SMKS -> 9L
        public const int TAPE_SPACE_SEQUENTIAL_SMKS = 9;

        /// TAPE_SPACE_SEQUENTIAL_FMKS -> 7L
        public const int TAPE_SPACE_SEQUENTIAL_FMKS = 7;

        /// TAPE_SPACE_RELATIVE_BLOCKS -> 5L
        public const int TAPE_SPACE_RELATIVE_BLOCKS = 5;

        /// TAPE_SPACE_FILEMARKS -> 6L
        public const int TAPE_SPACE_FILEMARKS = 6;

        /// TAPE_SPACE_END_OF_DATA -> 4L
        public const int TAPE_SPACE_END_OF_DATA = 4;

        /// TAPE_SHORT_FILEMARKS -> 2L
        public const int TAPE_SHORT_FILEMARKS = 2;

        /// TAPE_SETMARKS -> 0L
        public const int TAPE_SETMARKS = 0;

        /// TAPE_SELECT_PARTITIONS -> 1L
        public const int TAPE_SELECT_PARTITIONS = 1;

        /// TAPE_REWIND -> 0L
        public const int TAPE_REWIND = 0;

        /// TAPE_RETURN_STATISTICS -> 0L
        public const int TAPE_RETURN_STATISTICS = 0;

        /// TAPE_RETURN_ENV_INFO -> 1L
        public const int TAPE_RETURN_ENV_INFO = 1;

        /// TAPE_RESET_STATISTICS -> 2L
        public const int TAPE_RESET_STATISTICS = 2;

        /// TAPE_QUERY_MEDIA_CAPACITY -> 1L
        public const int TAPE_QUERY_MEDIA_CAPACITY = 1;

        /// TAPE_QUERY_IO_ERROR_DATA -> 3L
        public const int TAPE_QUERY_IO_ERROR_DATA = 3;

        /// TAPE_QUERY_DRIVE_PARAMETERS -> 0L
        public const int TAPE_QUERY_DRIVE_PARAMETERS = 0;

        /// TAPE_QUERY_DEVICE_ERROR_DATA -> 4L
        public const int TAPE_QUERY_DEVICE_ERROR_DATA = 4;

        /// TAPE_PSEUDO_LOGICAL_POSITION -> 2L
        public const int TAPE_PSEUDO_LOGICAL_POSITION = 2;

        /// TAPE_PSEUDO_LOGICAL_BLOCK -> 3L
        public const int TAPE_PSEUDO_LOGICAL_BLOCK = 3;

        /// TAPE_LONG_FILEMARKS -> 3L
        public const int TAPE_LONG_FILEMARKS = 3;

        /// TAPE_LOGICAL_POSITION -> 1L
        public const int TAPE_LOGICAL_POSITION = 1;

        /// TAPE_LOGICAL_BLOCK -> 2L
        public const int TAPE_LOGICAL_BLOCK = 2;

        /// TAPE_LOCK -> 3L
        public const int TAPE_LOCK = 3;

        /// TAPE_LOAD -> 0L
        public const int TAPE_LOAD = 0;

        /// TAPE_INITIATOR_PARTITIONS -> 2L
        public const int TAPE_INITIATOR_PARTITIONS = 2;

        /// TAPE_FORMAT -> 5L
        public const int TAPE_FORMAT = 5;

        /// TAPE_FIXED_PARTITIONS -> 0L
        public const int TAPE_FIXED_PARTITIONS = 0;

        /// TAPE_FILEMARKS -> 1L
        public const int TAPE_FILEMARKS = 1;

        /// TAPE_ERASE_SHORT -> 0L
        public const int TAPE_ERASE_SHORT = 0;

        /// TAPE_ERASE_LONG -> 1L
        public const int TAPE_ERASE_LONG = 1;

        /// TAPE_DRIVE_WRITE_SHORT_FMKS -> 0x84000000
        public const int TAPE_DRIVE_WRITE_SHORT_FMKS = -2080374784;

        /// TAPE_DRIVE_WRITE_SETMARKS -> 0x81000000
        public const int TAPE_DRIVE_WRITE_SETMARKS = -2130706432;

        /// TAPE_DRIVE_WRITE_PROTECT -> 0x00001000
        public const int TAPE_DRIVE_WRITE_PROTECT = 4096;

        /// TAPE_DRIVE_WRITE_MARK_IMMED -> 0x90000000
        public const int TAPE_DRIVE_WRITE_MARK_IMMED = -1879048192;

        /// TAPE_DRIVE_WRITE_LONG_FMKS -> 0x88000000
        public const int TAPE_DRIVE_WRITE_LONG_FMKS = -2013265920;

        /// TAPE_DRIVE_WRITE_FILEMARKS -> 0x82000000
        public const int TAPE_DRIVE_WRITE_FILEMARKS = -2113929216;

        /// TAPE_DRIVE_VARIABLE_BLOCK -> 0x00000800
        public const int TAPE_DRIVE_VARIABLE_BLOCK = 2048;

        /// TAPE_DRIVE_TENSION_IMMED -> 0x80000040
        public const int TAPE_DRIVE_TENSION_IMMED = -2147483584;

        /// TAPE_DRIVE_TENSION -> 0x80000002
        public const int TAPE_DRIVE_TENSION = -2147483646;

        /// TAPE_DRIVE_TAPE_REMAINING -> 0x00000200
        public const int TAPE_DRIVE_TAPE_REMAINING = 512;

        /// TAPE_DRIVE_TAPE_CAPACITY -> 0x00000100
        public const int TAPE_DRIVE_TAPE_CAPACITY = 256;

        /// TAPE_DRIVE_SPACE_IMMEDIATE -> 0x80800000
        public const int TAPE_DRIVE_SPACE_IMMEDIATE = -2139095040;

        /// TAPE_DRIVE_SET_REPORT_SMKS -> 0x80000800
        public const int TAPE_DRIVE_SET_REPORT_SMKS = -2147481600;

        /// TAPE_DRIVE_SET_PADDING -> 0x80000400
        public const int TAPE_DRIVE_SET_PADDING = -2147482624;

        /// TAPE_DRIVE_SET_EOT_WZ_SIZE -> 0x00400000
        public const int TAPE_DRIVE_SET_EOT_WZ_SIZE = 4194304;

        /// TAPE_DRIVE_SET_ECC -> 0x80000100
        public const int TAPE_DRIVE_SET_ECC = -2147483392;

        /// TAPE_DRIVE_SET_COMPRESSION -> 0x80000200
        public const int TAPE_DRIVE_SET_COMPRESSION = -2147483136;

        /// TAPE_DRIVE_SET_CMP_BOP_ONLY -> 0x04000000
        public const int TAPE_DRIVE_SET_CMP_BOP_ONLY = 67108864;

        /// TAPE_DRIVE_SET_BLOCK_SIZE -> 0x80000010
        public const int TAPE_DRIVE_SET_BLOCK_SIZE = -2147483632;

        /// TAPE_DRIVE_SETMARKS -> 0x80100000
        public const int TAPE_DRIVE_SETMARKS = -2146435072;

        /// TAPE_DRIVE_SEQUENTIAL_SMKS -> 0x80200000
        public const int TAPE_DRIVE_SEQUENTIAL_SMKS = -2145386496;

        /// TAPE_DRIVE_SEQUENTIAL_FMKS -> 0x80080000
        public const int TAPE_DRIVE_SEQUENTIAL_FMKS = -2146959360;

        /// TAPE_DRIVE_SELECT -> 0x00000002
        public const int TAPE_DRIVE_SELECT = 2;

        /// TAPE_DRIVE_REWIND_IMMEDIATE -> 0x80000008
        public const int TAPE_DRIVE_REWIND_IMMEDIATE = -2147483640;

        /// TAPE_DRIVE_REVERSE_POSITION -> 0x80400000
        public const int TAPE_DRIVE_REVERSE_POSITION = -2143289344;

        /// TAPE_DRIVE_RESERVED_BIT -> 0x80000000
        public const int TAPE_DRIVE_RESERVED_BIT = -2147483648;

        /// TAPE_DRIVE_REPORT_SMKS -> 0x00080000
        public const int TAPE_DRIVE_REPORT_SMKS = 524288;

        /// TAPE_DRIVE_RELATIVE_BLKS -> 0x80020000
        public const int TAPE_DRIVE_RELATIVE_BLKS = -2147352576;

        /// TAPE_DRIVE_PADDING -> 0x00040000
        public const int TAPE_DRIVE_PADDING = 262144;

        /// TAPE_DRIVE_LOG_BLK_IMMED -> 0x80008000
        public const int TAPE_DRIVE_LOG_BLK_IMMED = -2147450880;

        /// TAPE_DRIVE_LOGICAL_BLK -> 0x80004000
        public const int TAPE_DRIVE_LOGICAL_BLK = -2147467264;

        /// TAPE_DRIVE_LOCK_UNLOCK -> 0x80000004
        public const int TAPE_DRIVE_LOCK_UNLOCK = -2147483644;

        /// TAPE_DRIVE_LOCK_UNLK_IMMED -> 0x80000080
        public const int TAPE_DRIVE_LOCK_UNLK_IMMED = -2147483520;

        /// TAPE_DRIVE_LOAD_UNLOAD -> 0x80000001
        public const int TAPE_DRIVE_LOAD_UNLOAD = -2147483647;

        /// TAPE_DRIVE_LOAD_UNLD_IMMED -> 0x80000020
        public const int TAPE_DRIVE_LOAD_UNLD_IMMED = -2147483616;

        /// TAPE_DRIVE_INITIATOR -> 0x00000004
        public const int TAPE_DRIVE_INITIATOR = 4;

        /// TAPE_DRIVE_HIGH_FEATURES -> 0x80000000
        public const int TAPE_DRIVE_HIGH_FEATURES = -2147483648;

        /// TAPE_DRIVE_GET_LOGICAL_BLK -> 0x00200000
        public const int TAPE_DRIVE_GET_LOGICAL_BLK = 2097152;

        /// TAPE_DRIVE_GET_ABSOLUTE_BLK -> 0x00100000
        public const int TAPE_DRIVE_GET_ABSOLUTE_BLK = 1048576;

        /// TAPE_DRIVE_FORMAT_IMMEDIATE -> 0xC0000000
        public const int TAPE_DRIVE_FORMAT_IMMEDIATE = -1073741824;

        /// TAPE_DRIVE_FORMAT -> 0xA0000000
        public const int TAPE_DRIVE_FORMAT = -1610612736;

        /// TAPE_DRIVE_FIXED_BLOCK -> 0x00000400
        public const int TAPE_DRIVE_FIXED_BLOCK = 1024;

        /// TAPE_DRIVE_FIXED -> 0x00000001
        public const int TAPE_DRIVE_FIXED = 1;

        /// TAPE_DRIVE_FILEMARKS -> 0x80040000
        public const int TAPE_DRIVE_FILEMARKS = -2147221504;

        /// TAPE_DRIVE_ERASE_SHORT -> 0x00000010
        public const int TAPE_DRIVE_ERASE_SHORT = 16;

        /// TAPE_DRIVE_ERASE_LONG -> 0x00000020
        public const int TAPE_DRIVE_ERASE_LONG = 32;

        /// TAPE_DRIVE_ERASE_IMMEDIATE -> 0x00000080
        public const int TAPE_DRIVE_ERASE_IMMEDIATE = 128;

        /// TAPE_DRIVE_ERASE_BOP_ONLY -> 0x00000040
        public const int TAPE_DRIVE_ERASE_BOP_ONLY = 64;

        /// TAPE_DRIVE_EOT_WZ_SIZE -> 0x00002000
        public const int TAPE_DRIVE_EOT_WZ_SIZE = 8192;

        /// TAPE_DRIVE_END_OF_DATA -> 0x80010000
        public const int TAPE_DRIVE_END_OF_DATA = -2147418112;

        /// TAPE_DRIVE_EJECT_MEDIA -> 0x01000000
        public const int TAPE_DRIVE_EJECT_MEDIA = 16777216;

        /// TAPE_DRIVE_ECC -> 0x00010000
        public const int TAPE_DRIVE_ECC = 65536;

        /// TAPE_DRIVE_COMPRESSION -> 0x00020000
        public const int TAPE_DRIVE_COMPRESSION = 131072;

        /// TAPE_DRIVE_CLEAN_REQUESTS -> 0x02000000
        public const int TAPE_DRIVE_CLEAN_REQUESTS = 33554432;

        /// TAPE_DRIVE_ABS_BLK_IMMED -> 0x80002000
        public const int TAPE_DRIVE_ABS_BLK_IMMED = -2147475456;

        /// TAPE_DRIVE_ABSOLUTE_BLK -> 0x80001000
        public const int TAPE_DRIVE_ABSOLUTE_BLK = -2147479552;

        /// TAPE_CHECK_FOR_DRIVE_PROBLEM -> 2L
        public const int TAPE_CHECK_FOR_DRIVE_PROBLEM = 2;

        /// TAPE_ABSOLUTE_POSITION -> 0L
        public const int TAPE_ABSOLUTE_POSITION = 0;

        /// TAPE_ABSOLUTE_BLOCK -> 1L
        public const int TAPE_ABSOLUTE_BLOCK = 1;

        /// TapeClassGuid -> GUID_DEVINTERFACE_TAPE
        /// Error generating expression: Value GUID_DEVINTERFACE_TAPE is not resolved
        public const string TapeClassGuid = "GUID_DEVINTERFACE_TAPE";

        /// TabbedTextOut -> TabbedTextOutW
        /// Error generating expression: Value TabbedTextOutW is not resolved
        public const string TabbedTextOut = "TabbedTextOutW";
    }

}
