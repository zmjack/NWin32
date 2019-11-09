using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// E_DRAW -> VIEW_E_DRAW
        public const string E_DRAW = NativeConstants.VIEW_E_DRAW;

        /// EXT_DEVICE_CAPS -> 4099
        public const int EXT_DEVICE_CAPS = 4099;

        /// ExtTextOut -> ExtTextOutW
        /// Error generating expression: Value ExtTextOutW is not resolved
        public const string ExtTextOut = "ExtTextOutW";

        /// EXTTEXTOUT -> 512
        public const int EXTTEXTOUT = 512;

        /// ExtractIconEx -> ExtractIconExW
        /// Error generating expression: Value ExtractIconExW is not resolved
        public const string ExtractIconEx = "ExtractIconExW";

        /// ExtractIcon -> ExtractIconW
        /// Error generating expression: Value ExtractIconW is not resolved
        public const string ExtractIcon = "ExtractIconW";

        /// ExtractAssociatedIcon -> ExtractAssociatedIconW
        /// Error generating expression: Value ExtractAssociatedIconW is not resolved
        public const string ExtractAssociatedIcon = "ExtractAssociatedIconW";

        /// EXTERN_C -> extern
        /// Error generating expression: Value extern is not resolved
        public const string EXTERN_C = "extern";

        /// EXTEND_IEPORT -> 2
        public const int EXTEND_IEPORT = 2;

        /// EXPO_OFFLOAD_REG_VALUE -> "ExpoOffload"
        public const string EXPO_OFFLOAD_REG_VALUE = "ExpoOffload";

        /// EXPO_OFFLOAD_FUNC_NAME -> "OffloadModExpo"
        public const string EXPO_OFFLOAD_FUNC_NAME = "OffloadModExpo";

        /// EXPORT_PRIVATE_KEYS -> 0x0004
        public const int EXPORT_PRIVATE_KEYS = 4;

        /// EXPENTRY -> CALLBACK
        public const string EXPENTRY = NativeConstants.CALLBACK;

        /// ExpandEnvironmentStrings -> ExpandEnvironmentStringsW
        /// Error generating expression: Value ExpandEnvironmentStringsW is not resolved
        public const string ExpandEnvironmentStrings = "ExpandEnvironmentStringsW";

        /// EXIT_THREAD_DEBUG_EVENT -> 4
        public const int EXIT_THREAD_DEBUG_EVENT = 4;

        /// EXIT_SUCCESS -> 0
        public const int EXIT_SUCCESS = 0;

        /// EXIT_PROCESS_DEBUG_EVENT -> 5
        public const int EXIT_PROCESS_DEBUG_EVENT = 5;

        /// EXIT_FAILURE -> 1
        public const int EXIT_FAILURE = 1;

        /// EXECUTE_OFFLINE_DIAGS -> 0xD4
        public const int EXECUTE_OFFLINE_DIAGS = 212;

        /// EXCEPTION_WRITE_FAULT -> 1
        public const int EXCEPTION_WRITE_FAULT = 1;

        /// EXCEPTION_STACK_OVERFLOW -> STATUS_STACK_OVERFLOW
        public const string EXCEPTION_STACK_OVERFLOW = NativeConstants.STATUS_STACK_OVERFLOW;

        /// EXCEPTION_SINGLE_STEP -> STATUS_SINGLE_STEP
        public const string EXCEPTION_SINGLE_STEP = NativeConstants.STATUS_SINGLE_STEP;

        /// EXCEPTION_READ_FAULT -> 0
        public const int EXCEPTION_READ_FAULT = 0;

        /// EXCEPTION_PRIV_INSTRUCTION -> STATUS_PRIVILEGED_INSTRUCTION
        public const string EXCEPTION_PRIV_INSTRUCTION = NativeConstants.STATUS_PRIVILEGED_INSTRUCTION;

        /// EXCEPTION_POSSIBLE_DEADLOCK -> STATUS_POSSIBLE_DEADLOCK
        /// Error generating expression: Value STATUS_POSSIBLE_DEADLOCK is not resolved
        public const string EXCEPTION_POSSIBLE_DEADLOCK = "STATUS_POSSIBLE_DEADLOCK";

        /// EXCEPTION_NONCONTINUABLE_EXCEPTION -> STATUS_NONCONTINUABLE_EXCEPTION
        public const string EXCEPTION_NONCONTINUABLE_EXCEPTION = NativeConstants.STATUS_NONCONTINUABLE_EXCEPTION;

        /// EXCEPTION_NONCONTINUABLE -> 0x1
        public const int EXCEPTION_NONCONTINUABLE = 1;

        /// EXCEPTION_MAXIMUM_PARAMETERS -> 15
        public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;

        /// EXCEPTION_IN_PAGE_ERROR -> STATUS_IN_PAGE_ERROR
        public const string EXCEPTION_IN_PAGE_ERROR = NativeConstants.STATUS_IN_PAGE_ERROR;

        /// EXCEPTION_INVALID_HANDLE -> STATUS_INVALID_HANDLE
        public const string EXCEPTION_INVALID_HANDLE = NativeConstants.STATUS_INVALID_HANDLE;

        /// EXCEPTION_INVALID_DISPOSITION -> STATUS_INVALID_DISPOSITION
        public const string EXCEPTION_INVALID_DISPOSITION = NativeConstants.STATUS_INVALID_DISPOSITION;

        /// EXCEPTION_INT_OVERFLOW -> STATUS_INTEGER_OVERFLOW
        public const string EXCEPTION_INT_OVERFLOW = NativeConstants.STATUS_INTEGER_OVERFLOW;

        /// EXCEPTION_INT_DIVIDE_BY_ZERO -> STATUS_INTEGER_DIVIDE_BY_ZERO
        public const string EXCEPTION_INT_DIVIDE_BY_ZERO = NativeConstants.STATUS_INTEGER_DIVIDE_BY_ZERO;

        /// EXCEPTION_ILLEGAL_INSTRUCTION -> STATUS_ILLEGAL_INSTRUCTION
        public const string EXCEPTION_ILLEGAL_INSTRUCTION = NativeConstants.STATUS_ILLEGAL_INSTRUCTION;

        /// EXCEPTION_GUARD_PAGE -> STATUS_GUARD_PAGE_VIOLATION
        public const string EXCEPTION_GUARD_PAGE = NativeConstants.STATUS_GUARD_PAGE_VIOLATION;

        /// EXCEPTION_FLT_UNDERFLOW -> STATUS_FLOAT_UNDERFLOW
        public const string EXCEPTION_FLT_UNDERFLOW = NativeConstants.STATUS_FLOAT_UNDERFLOW;

        /// EXCEPTION_FLT_STACK_CHECK -> STATUS_FLOAT_STACK_CHECK
        public const string EXCEPTION_FLT_STACK_CHECK = NativeConstants.STATUS_FLOAT_STACK_CHECK;

        /// EXCEPTION_FLT_OVERFLOW -> STATUS_FLOAT_OVERFLOW
        public const string EXCEPTION_FLT_OVERFLOW = NativeConstants.STATUS_FLOAT_OVERFLOW;

        /// EXCEPTION_FLT_INVALID_OPERATION -> STATUS_FLOAT_INVALID_OPERATION
        public const string EXCEPTION_FLT_INVALID_OPERATION = NativeConstants.STATUS_FLOAT_INVALID_OPERATION;

        /// EXCEPTION_FLT_INEXACT_RESULT -> STATUS_FLOAT_INEXACT_RESULT
        public const string EXCEPTION_FLT_INEXACT_RESULT = NativeConstants.STATUS_FLOAT_INEXACT_RESULT;

        /// EXCEPTION_FLT_DIVIDE_BY_ZERO -> STATUS_FLOAT_DIVIDE_BY_ZERO
        public const string EXCEPTION_FLT_DIVIDE_BY_ZERO = NativeConstants.STATUS_FLOAT_DIVIDE_BY_ZERO;

        /// EXCEPTION_FLT_DENORMAL_OPERAND -> STATUS_FLOAT_DENORMAL_OPERAND
        public const string EXCEPTION_FLT_DENORMAL_OPERAND = NativeConstants.STATUS_FLOAT_DENORMAL_OPERAND;

        /// EXCEPTION_EXECUTE_HANDLER -> 1
        public const int EXCEPTION_EXECUTE_HANDLER = 1;

        /// EXCEPTION_EXECUTE_FAULT -> 8
        public const int EXCEPTION_EXECUTE_FAULT = 8;

        /// EXCEPTION_DEBUG_EVENT -> 1
        public const int EXCEPTION_DEBUG_EVENT = 1;

        /// EXCEPTION_DATATYPE_MISALIGNMENT -> STATUS_DATATYPE_MISALIGNMENT
        public const string EXCEPTION_DATATYPE_MISALIGNMENT = NativeConstants.STATUS_DATATYPE_MISALIGNMENT;

        /// EXCEPTION_CONTINUE_SEARCH -> 0
        public const int EXCEPTION_CONTINUE_SEARCH = 0;

        /// EXCEPTION_CONTINUE_EXECUTION -> -1
        public const int EXCEPTION_CONTINUE_EXECUTION = -1;

        /// exception_code -> _exception_code
        /// Error generating expression: Value _exception_code is not resolved
        public const string exception_code = "_exception_code";

        /// EXCEPTION_BREAKPOINT -> STATUS_BREAKPOINT
        public const string EXCEPTION_BREAKPOINT = NativeConstants.STATUS_BREAKPOINT;

        /// EXCEPTION_ARRAY_BOUNDS_EXCEEDED -> STATUS_ARRAY_BOUNDS_EXCEEDED
        public const string EXCEPTION_ARRAY_BOUNDS_EXCEEDED = NativeConstants.STATUS_ARRAY_BOUNDS_EXCEEDED;

        /// EXCEPTION_ACCESS_VIOLATION -> STATUS_ACCESS_VIOLATION
        public const string EXCEPTION_ACCESS_VIOLATION = NativeConstants.STATUS_ACCESS_VIOLATION;

        /// EWX_SHUTDOWN -> 0x00000001
        public const int EWX_SHUTDOWN = 1;

        /// EWX_REBOOT -> 0x00000002
        public const int EWX_REBOOT = 2;

        /// EWX_POWEROFF -> 0x00000008
        public const int EWX_POWEROFF = 8;

        /// EWX_LOGOFF -> 0
        public const int EWX_LOGOFF = 0;

        /// EWX_FORCEIFHUNG -> 0x00000010
        public const int EWX_FORCEIFHUNG = 16;

        /// EWX_FORCE -> 0x00000004
        public const int EWX_FORCE = 4;

        /// EV_TXEMPTY -> 0x0004
        public const int EV_TXEMPTY = 4;

        /// EV_RXFLAG -> 0x0002
        public const int EV_RXFLAG = 2;

        /// EV_RXCHAR -> 0x0001
        public const int EV_RXCHAR = 1;

        /// EV_RX80FULL -> 0x0400
        public const int EV_RX80FULL = 1024;

        /// EV_RLSD -> 0x0020
        public const int EV_RLSD = 32;

        /// EV_RING -> 0x0100
        public const int EV_RING = 256;

        /// EV_PERR -> 0x0200
        public const int EV_PERR = 512;

        /// EV_EVENT2 -> 0x1000
        public const int EV_EVENT2 = 4096;

        /// EV_EVENT1 -> 0x0800
        public const int EV_EVENT1 = 2048;

        /// EV_ERR -> 0x0080
        public const int EV_ERR = 128;

        /// EV_DSR -> 0x0010
        public const int EV_DSR = 16;

        /// EV_CTS -> 0x0008
        public const int EV_CTS = 8;

        /// EV_BREAK -> 0x0040
        public const int EV_BREAK = 64;

        /// EVENT_S_LAST -> 0x0004021FL
        public const int EVENT_S_LAST = 262687;

        /// EVENT_S_FIRST -> 0x00040200L
        public const int EVENT_S_FIRST = 262656;

        /// EVENT_SYSTEM_SWITCHSTART -> 0x0014
        public const int EVENT_SYSTEM_SWITCHSTART = 20;

        /// EVENT_SYSTEM_SWITCHEND -> 0x0015
        public const int EVENT_SYSTEM_SWITCHEND = 21;

        /// EVENT_SYSTEM_SOUND -> 0x0001
        public const int EVENT_SYSTEM_SOUND = 1;

        /// EVENT_SYSTEM_SCROLLINGSTART -> 0x0012
        public const int EVENT_SYSTEM_SCROLLINGSTART = 18;

        /// EVENT_SYSTEM_SCROLLINGEND -> 0x0013
        public const int EVENT_SYSTEM_SCROLLINGEND = 19;

        /// EVENT_SYSTEM_MOVESIZESTART -> 0x000A
        public const int EVENT_SYSTEM_MOVESIZESTART = 10;

        /// EVENT_SYSTEM_MOVESIZEEND -> 0x000B
        public const int EVENT_SYSTEM_MOVESIZEEND = 11;

        /// EVENT_SYSTEM_MINIMIZESTART -> 0x0016
        public const int EVENT_SYSTEM_MINIMIZESTART = 22;

        /// EVENT_SYSTEM_MINIMIZEEND -> 0x0017
        public const int EVENT_SYSTEM_MINIMIZEEND = 23;

        /// EVENT_SYSTEM_MENUSTART -> 0x0004
        public const int EVENT_SYSTEM_MENUSTART = 4;

        /// EVENT_SYSTEM_MENUPOPUPSTART -> 0x0006
        public const int EVENT_SYSTEM_MENUPOPUPSTART = 6;

        /// EVENT_SYSTEM_MENUPOPUPEND -> 0x0007
        public const int EVENT_SYSTEM_MENUPOPUPEND = 7;

        /// EVENT_SYSTEM_MENUEND -> 0x0005
        public const int EVENT_SYSTEM_MENUEND = 5;

        /// EVENT_SYSTEM_FOREGROUND -> 0x0003
        public const int EVENT_SYSTEM_FOREGROUND = 3;

        /// EVENT_SYSTEM_DRAGDROPSTART -> 0x000E
        public const int EVENT_SYSTEM_DRAGDROPSTART = 14;

        /// EVENT_SYSTEM_DRAGDROPEND -> 0x000F
        public const int EVENT_SYSTEM_DRAGDROPEND = 15;

        /// EVENT_SYSTEM_DIALOGSTART -> 0x0010
        public const int EVENT_SYSTEM_DIALOGSTART = 16;

        /// EVENT_SYSTEM_DIALOGEND -> 0x0011
        public const int EVENT_SYSTEM_DIALOGEND = 17;

        /// EVENT_SYSTEM_CONTEXTHELPSTART -> 0x000C
        public const int EVENT_SYSTEM_CONTEXTHELPSTART = 12;

        /// EVENT_SYSTEM_CONTEXTHELPEND -> 0x000D
        public const int EVENT_SYSTEM_CONTEXTHELPEND = 13;

        /// EVENT_SYSTEM_CAPTURESTART -> 0x0008
        public const int EVENT_SYSTEM_CAPTURESTART = 8;

        /// EVENT_SYSTEM_CAPTUREEND -> 0x0009
        public const int EVENT_SYSTEM_CAPTUREEND = 9;

        /// EVENT_SYSTEM_ALERT -> 0x0002
        public const int EVENT_SYSTEM_ALERT = 2;

        /// EVENT_OBJECT_VALUECHANGE -> 0x800E
        public const int EVENT_OBJECT_VALUECHANGE = 32782;

        /// EVENT_OBJECT_STATECHANGE -> 0x800A
        public const int EVENT_OBJECT_STATECHANGE = 32778;

        /// EVENT_OBJECT_SHOW -> 0x8002
        public const int EVENT_OBJECT_SHOW = 32770;

        /// EVENT_OBJECT_SELECTIONWITHIN -> 0x8009
        public const int EVENT_OBJECT_SELECTIONWITHIN = 32777;

        /// EVENT_OBJECT_SELECTIONREMOVE -> 0x8008
        public const int EVENT_OBJECT_SELECTIONREMOVE = 32776;

        /// EVENT_OBJECT_SELECTIONADD -> 0x8007
        public const int EVENT_OBJECT_SELECTIONADD = 32775;

        /// EVENT_OBJECT_SELECTION -> 0x8006
        public const int EVENT_OBJECT_SELECTION = 32774;

        /// EVENT_OBJECT_REORDER -> 0x8004
        public const int EVENT_OBJECT_REORDER = 32772;

        /// EVENT_OBJECT_PARENTCHANGE -> 0x800F
        public const int EVENT_OBJECT_PARENTCHANGE = 32783;

        /// EVENT_OBJECT_NAMECHANGE -> 0x800C
        public const int EVENT_OBJECT_NAMECHANGE = 32780;

        /// EVENT_OBJECT_LOCATIONCHANGE -> 0x800B
        public const int EVENT_OBJECT_LOCATIONCHANGE = 32779;

        /// EVENT_OBJECT_HIDE -> 0x8003
        public const int EVENT_OBJECT_HIDE = 32771;

        /// EVENT_OBJECT_HELPCHANGE -> 0x8010
        public const int EVENT_OBJECT_HELPCHANGE = 32784;

        /// EVENT_OBJECT_FOCUS -> 0x8005
        public const int EVENT_OBJECT_FOCUS = 32773;

        /// EVENT_OBJECT_DESTROY -> 0x8001
        public const int EVENT_OBJECT_DESTROY = 32769;

        /// EVENT_OBJECT_DESCRIPTIONCHANGE -> 0x800D
        public const int EVENT_OBJECT_DESCRIPTIONCHANGE = 32781;

        /// EVENT_OBJECT_DEFACTIONCHANGE -> 0x8011
        public const int EVENT_OBJECT_DEFACTIONCHANGE = 32785;

        /// EVENT_OBJECT_CREATE -> 0x8000
        public const int EVENT_OBJECT_CREATE = 32768;

        /// EVENT_OBJECT_ACCELERATORCHANGE -> 0x8012
        public const int EVENT_OBJECT_ACCELERATORCHANGE = 32786;

        /// EVENT_MODIFY_STATE -> 0x0002
        public const int EVENT_MODIFY_STATE = 2;

        /// EVENT_MIN -> 0x00000001
        public const int EVENT_MIN = 1;

        /// EVENT_MAX -> 0x7FFFFFFF
        public const int EVENT_MAX = 2147483647;

        /// EVENT_E_LAST -> 0x8004021FL
        public const int EVENT_E_LAST = -2147220961;

        /// EVENT_E_FIRST -> 0x80040200L
        public const int EVENT_E_FIRST = -2147220992;

        /// EVENT_CONSOLE_UPDATE_SIMPLE -> 0x4003
        public const int EVENT_CONSOLE_UPDATE_SIMPLE = 16387;

        /// EVENT_CONSOLE_UPDATE_SCROLL -> 0x4004
        public const int EVENT_CONSOLE_UPDATE_SCROLL = 16388;

        /// EVENT_CONSOLE_UPDATE_REGION -> 0x4002
        public const int EVENT_CONSOLE_UPDATE_REGION = 16386;

        /// EVENT_CONSOLE_START_APPLICATION -> 0x4006
        public const int EVENT_CONSOLE_START_APPLICATION = 16390;

        /// EVENT_CONSOLE_LAYOUT -> 0x4005
        public const int EVENT_CONSOLE_LAYOUT = 16389;

        /// EVENT_CONSOLE_END_APPLICATION -> 0x4007
        public const int EVENT_CONSOLE_END_APPLICATION = 16391;

        /// EVENT_CONSOLE_CARET -> 0x4001
        public const int EVENT_CONSOLE_CARET = 16385;

        /// EVENT_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)
        public const int EVENT_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE | 3));

        /// EVENTLOG_WARNING_TYPE -> 0x0002
        public const int EVENTLOG_WARNING_TYPE = 2;

        /// EVENTLOG_SUCCESS -> 0x0000
        public const int EVENTLOG_SUCCESS = 0;

        /// EVENTLOG_START_PAIRED_EVENT -> 0x0001
        public const int EVENTLOG_START_PAIRED_EVENT = 1;

        /// EVENTLOG_SEQUENTIAL_READ -> 0x0001
        public const int EVENTLOG_SEQUENTIAL_READ = 1;

        /// EVENTLOG_SEEK_READ -> 0x0002
        public const int EVENTLOG_SEEK_READ = 2;

        /// EVENTLOG_PAIRED_EVENT_INACTIVE -> 0x0010
        public const int EVENTLOG_PAIRED_EVENT_INACTIVE = 16;

        /// EVENTLOG_PAIRED_EVENT_ACTIVE -> 0x0008
        public const int EVENTLOG_PAIRED_EVENT_ACTIVE = 8;

        /// EVENTLOG_INFORMATION_TYPE -> 0x0004
        public const int EVENTLOG_INFORMATION_TYPE = 4;

        /// EVENTLOG_FULL_INFO -> 0
        public const int EVENTLOG_FULL_INFO = 0;

        /// EVENTLOG_FORWARDS_READ -> 0x0004
        public const int EVENTLOG_FORWARDS_READ = 4;

        /// EVENTLOG_ERROR_TYPE -> 0x0001
        public const int EVENTLOG_ERROR_TYPE = 1;

        /// EVENTLOG_END_PAIRED_EVENT -> 0x0002
        public const int EVENTLOG_END_PAIRED_EVENT = 2;

        /// EVENTLOG_END_ALL_PAIRED_EVENTS -> 0x0004
        public const int EVENTLOG_END_ALL_PAIRED_EVENTS = 4;

        /// EVENTLOG_BACKWARDS_READ -> 0x0008
        public const int EVENTLOG_BACKWARDS_READ = 8;

        /// EVENTLOG_AUDIT_SUCCESS -> 0x0008
        public const int EVENTLOG_AUDIT_SUCCESS = 8;

        /// EVENTLOG_AUDIT_FAILURE -> 0x0010
        public const int EVENTLOG_AUDIT_FAILURE = 16;

        /// EVENPARITY -> 2
        public const int EVENPARITY = 2;

        /// ETO_RTLREADING -> 0x0080
        public const int ETO_RTLREADING = 128;

        /// ETO_PDY -> 0x2000
        public const int ETO_PDY = 8192;

        /// ETO_OPAQUE -> 0x0002
        public const int ETO_OPAQUE = 2;

        /// ETO_NUMERICSLOCAL -> 0x0400
        public const int ETO_NUMERICSLOCAL = 1024;

        /// ETO_NUMERICSLATIN -> 0x0800
        public const int ETO_NUMERICSLATIN = 2048;

        /// ETO_IGNORELANGUAGE -> 0x1000
        public const int ETO_IGNORELANGUAGE = 4096;

        /// ETO_GLYPH_INDEX -> 0x0010
        public const int ETO_GLYPH_INDEX = 16;

        /// ETO_CLIPPED -> 0x0004
        public const int ETO_CLIPPED = 4;

        /// ES_WANTRETURN -> 0x1000L
        public const int ES_WANTRETURN = 4096;

        /// ES_UPPERCASE -> 0x0008L
        public const int ES_UPPERCASE = 8;

        /// ES_RIGHT -> 0x0002L
        public const int ES_RIGHT = 2;

        /// ES_READONLY -> 0x0800L
        public const int ES_READONLY = 2048;

        /// ES_PASSWORD -> 0x0020L
        public const int ES_PASSWORD = 32;

        /// ES_OEMCONVERT -> 0x0400L
        public const int ES_OEMCONVERT = 1024;

        /// ES_NUMBER -> 0x2000L
        public const int ES_NUMBER = 8192;

        /// ES_NOHIDESEL -> 0x0100L
        public const int ES_NOHIDESEL = 256;

        /// ES_MULTILINE -> 0x0004L
        public const int ES_MULTILINE = 4;

        /// ES_LOWERCASE -> 0x0010L
        public const int ES_LOWERCASE = 16;

        /// ES_LEFT -> 0x0000L
        public const int ES_LEFT = 0;

        /// ES_CENTER -> 0x0001L
        public const int ES_CENTER = 1;

        /// ES_AUTOVSCROLL -> 0x0040L
        public const int ES_AUTOVSCROLL = 64;

        /// ES_AUTOHSCROLL -> 0x0080L
        public const int ES_AUTOHSCROLL = 128;

        /// ESB_ENABLE_BOTH -> 0x0000
        public const int ESB_ENABLE_BOTH = 0;

        /// ESB_DISABLE_UP -> 0x0001
        public const int ESB_DISABLE_UP = 1;

        /// ESB_DISABLE_RTDN -> ESB_DISABLE_RIGHT
        public const int ESB_DISABLE_RTDN = NativeConstants.ESB_DISABLE_RIGHT;

        /// ESB_DISABLE_RIGHT -> 0x0002
        public const int ESB_DISABLE_RIGHT = 2;

        /// ESB_DISABLE_LTUP -> ESB_DISABLE_LEFT
        public const int ESB_DISABLE_LTUP = NativeConstants.ESB_DISABLE_LEFT;

        /// ESB_DISABLE_LEFT -> 0x0001
        public const int ESB_DISABLE_LEFT = 1;

        /// ESB_DISABLE_DOWN -> 0x0002
        public const int ESB_DISABLE_DOWN = 2;

        /// ESB_DISABLE_BOTH -> 0x0003
        public const int ESB_DISABLE_BOTH = 3;

        /// ERROR_WRONG_TARGET_NAME -> 1396L
        public const int ERROR_WRONG_TARGET_NAME = 1396;

        /// ERROR_WRONG_PASSWORD -> 1323L
        public const int ERROR_WRONG_PASSWORD = 1323;

        /// ERROR_WRONG_EFS -> 6005L
        public const int ERROR_WRONG_EFS = 6005;

        /// ERROR_WRONG_DISK -> 34L
        public const int ERROR_WRONG_DISK = 34;

        /// ERROR_WRITE_PROTECT -> 19L
        public const int ERROR_WRITE_PROTECT = 19;

        /// ERROR_WRITE_FAULT -> 29L
        public const int ERROR_WRITE_FAULT = 29;

        /// ERROR_WORKING_SET_QUOTA -> 1453L
        public const int ERROR_WORKING_SET_QUOTA = 1453;

        /// ERROR_WMI_UNRESOLVED_INSTANCE_REF -> 4205L
        public const int ERROR_WMI_UNRESOLVED_INSTANCE_REF = 4205;

        /// ERROR_WMI_TRY_AGAIN -> 4203L
        public const int ERROR_WMI_TRY_AGAIN = 4203;

        /// ERROR_WMI_SET_FAILURE -> 4214L
        public const int ERROR_WMI_SET_FAILURE = 4214;

        /// ERROR_WMI_SERVER_UNAVAILABLE -> 4208L
        public const int ERROR_WMI_SERVER_UNAVAILABLE = 4208;

        /// ERROR_WMI_READ_ONLY -> 4213L
        public const int ERROR_WMI_READ_ONLY = 4213;

        /// ERROR_WMI_ITEMID_NOT_FOUND -> 4202L
        public const int ERROR_WMI_ITEMID_NOT_FOUND = 4202;

        /// ERROR_WMI_INVALID_REGINFO -> 4211L
        public const int ERROR_WMI_INVALID_REGINFO = 4211;

        /// ERROR_WMI_INVALID_MOF -> 4210L
        public const int ERROR_WMI_INVALID_MOF = 4210;

        /// ERROR_WMI_INSTANCE_NOT_FOUND -> 4201L
        public const int ERROR_WMI_INSTANCE_NOT_FOUND = 4201;

        /// ERROR_WMI_GUID_NOT_FOUND -> 4200L
        public const int ERROR_WMI_GUID_NOT_FOUND = 4200;

        /// ERROR_WMI_GUID_DISCONNECTED -> 4207L
        public const int ERROR_WMI_GUID_DISCONNECTED = 4207;

        /// ERROR_WMI_DP_NOT_FOUND -> 4204L
        public const int ERROR_WMI_DP_NOT_FOUND = 4204;

        /// ERROR_WMI_DP_FAILED -> 4209L
        public const int ERROR_WMI_DP_FAILED = 4209;

        /// ERROR_WMI_ALREADY_ENABLED -> 4206L
        public const int ERROR_WMI_ALREADY_ENABLED = 4206;

        /// ERROR_WMI_ALREADY_DISABLED -> 4212L
        public const int ERROR_WMI_ALREADY_DISABLED = 4212;

        /// ERROR_WINS_INTERNAL -> 4000L
        public const int ERROR_WINS_INTERNAL = 4000;

        /// ERROR_WINDOW_OF_OTHER_THREAD -> 1408L
        public const int ERROR_WINDOW_OF_OTHER_THREAD = 1408;

        /// ERROR_WINDOW_NOT_DIALOG -> 1420L
        public const int ERROR_WINDOW_NOT_DIALOG = 1420;

        /// ERROR_WINDOW_NOT_COMBOBOX -> 1423L
        public const int ERROR_WINDOW_NOT_COMBOBOX = 1423;

        /// ERROR_WAIT_NO_CHILDREN -> 128L
        public const int ERROR_WAIT_NO_CHILDREN = 128;

        /// ERROR_VOLUME_NOT_SUPPORT_EFS -> 6014L
        public const int ERROR_VOLUME_NOT_SUPPORT_EFS = 6014;

        /// ERROR_VOLUME_NOT_SIS_ENABLED -> 4500L
        public const int ERROR_VOLUME_NOT_SIS_ENABLED = 4500;

        /// ERROR_VOLUME_CONTAINS_SYS_FILES -> 4337L
        public const int ERROR_VOLUME_CONTAINS_SYS_FILES = 4337;

        /// ERROR_VDM_DISALLOWED -> 1286L
        public const int ERROR_VDM_DISALLOWED = 1286;

        /// ERROR_VC_DISCONNECTED -> 240L
        public const int ERROR_VC_DISCONNECTED = 240;

        /// ERROR_USER_MAPPED_FILE -> 1224L
        public const int ERROR_USER_MAPPED_FILE = 1224;

        /// ERROR_USER_EXISTS -> 1316L
        public const int ERROR_USER_EXISTS = 1316;

        /// ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED -> 1934L
        public const int ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED = 1934;

        /// ERROR_UNSUPPORTED_TYPE -> 1630L
        public const int ERROR_UNSUPPORTED_TYPE = 1630;

        /// ERROR_UNRECOGNIZED_VOLUME -> 1005L
        public const int ERROR_UNRECOGNIZED_VOLUME = 1005;

        /// ERROR_UNRECOGNIZED_MEDIA -> 1785L
        public const int ERROR_UNRECOGNIZED_MEDIA = 1785;

        /// ERROR_UNKNOWN_REVISION -> 1305L
        public const int ERROR_UNKNOWN_REVISION = 1305;

        /// ERROR_UNKNOWN_PROPERTY -> 1608L
        public const int ERROR_UNKNOWN_PROPERTY = 1608;

        /// ERROR_UNKNOWN_PRODUCT -> 1605L
        public const int ERROR_UNKNOWN_PRODUCT = 1605;

        /// ERROR_UNKNOWN_PRINT_MONITOR -> 3000L
        public const int ERROR_UNKNOWN_PRINT_MONITOR = 3000;

        /// ERROR_UNKNOWN_PRINTPROCESSOR -> 1798L
        public const int ERROR_UNKNOWN_PRINTPROCESSOR = 1798;

        /// ERROR_UNKNOWN_PRINTER_DRIVER -> 1797L
        public const int ERROR_UNKNOWN_PRINTER_DRIVER = 1797;

        /// ERROR_UNKNOWN_PORT -> 1796L
        public const int ERROR_UNKNOWN_PORT = 1796;

        /// ERROR_UNKNOWN_FEATURE -> 1606L
        public const int ERROR_UNKNOWN_FEATURE = 1606;

        /// ERROR_UNKNOWN_COMPONENT -> 1607L
        public const int ERROR_UNKNOWN_COMPONENT = 1607;

        /// ERROR_UNIDENTIFIED_ERROR -> 1287L
        public const int ERROR_UNIDENTIFIED_ERROR = 1287;

        /// ERROR_UNHANDLED_ERROR -> 0xFFFFFFFF
        public const int ERROR_UNHANDLED_ERROR = -1;

        /// ERROR_UNEXP_NET_ERR -> 59L
        public const int ERROR_UNEXP_NET_ERR = 59;

        /// ERROR_UNEXPECTED_OMID -> 4334L
        public const int ERROR_UNEXPECTED_OMID = 4334;

        /// ERROR_UNABLE_TO_UNLOAD_MEDIA -> 1109L
        public const int ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109;

        /// ERROR_UNABLE_TO_REMOVE_REPLACED -> 1175L
        public const int ERROR_UNABLE_TO_REMOVE_REPLACED = 1175;

        /// ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 -> 1177L
        public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177;

        /// ERROR_UNABLE_TO_MOVE_REPLACEMENT -> 1176L
        public const int ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176;

        /// ERROR_UNABLE_TO_LOCK_MEDIA -> 1108L
        public const int ERROR_UNABLE_TO_LOCK_MEDIA = 1108;

        /// ERROR_UNABLE_TO_LOAD_MEDIUM -> 4324L
        public const int ERROR_UNABLE_TO_LOAD_MEDIUM = 4324;

        /// ERROR_UNABLE_TO_INVENTORY_TRANSPORT -> 4327L
        public const int ERROR_UNABLE_TO_INVENTORY_TRANSPORT = 4327;

        /// ERROR_UNABLE_TO_INVENTORY_SLOT -> 4326L
        public const int ERROR_UNABLE_TO_INVENTORY_SLOT = 4326;

        /// ERROR_UNABLE_TO_INVENTORY_DRIVE -> 4325L
        public const int ERROR_UNABLE_TO_INVENTORY_DRIVE = 4325;

        /// ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA -> 4330L
        public const int ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA = 4330;

        /// ERROR_UNABLE_TO_CLEAN -> 4311L
        public const int ERROR_UNABLE_TO_CLEAN = 4311;

        /// ERROR_TRUST_FAILURE -> 1790L
        public const int ERROR_TRUST_FAILURE = 1790;

        /// ERROR_TRUSTED_RELATIONSHIP_FAILURE -> 1789L
        public const int ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789;

        /// ERROR_TRUSTED_DOMAIN_FAILURE -> 1788L
        public const int ERROR_TRUSTED_DOMAIN_FAILURE = 1788;

        /// ERROR_TRAY_MALFUNCTION -> 0x00000010
        public const int ERROR_TRAY_MALFUNCTION = 16;

        /// ERROR_TRANSPORT_FULL -> 4328L
        public const int ERROR_TRANSPORT_FULL = 4328;

        /// ERROR_TRANSFORM_NOT_SUPPORTED -> 2004L
        public const int ERROR_TRANSFORM_NOT_SUPPORTED = 2004;

        /// ERROR_TOO_MANY_TCBS -> 155L
        public const int ERROR_TOO_MANY_TCBS = 155;

        /// ERROR_TOO_MANY_SIDS -> 1389L
        public const int ERROR_TOO_MANY_SIDS = 1389;

        /// ERROR_TOO_MANY_SESS -> 69L
        public const int ERROR_TOO_MANY_SESS = 69;

        /// ERROR_TOO_MANY_SEM_REQUESTS -> 103L
        public const int ERROR_TOO_MANY_SEM_REQUESTS = 103;

        /// ERROR_TOO_MANY_SEMAPHORES -> 100L
        public const int ERROR_TOO_MANY_SEMAPHORES = 100;

        /// ERROR_TOO_MANY_SECRETS -> 1381L
        public const int ERROR_TOO_MANY_SECRETS = 1381;

        /// ERROR_TOO_MANY_POSTS -> 298L
        public const int ERROR_TOO_MANY_POSTS = 298;

        /// ERROR_TOO_MANY_OPEN_FILES -> 4L
        public const int ERROR_TOO_MANY_OPEN_FILES = 4;

        /// ERROR_TOO_MANY_NAMES -> 68L
        public const int ERROR_TOO_MANY_NAMES = 68;

        /// ERROR_TOO_MANY_MUXWAITERS -> 152L
        public const int ERROR_TOO_MANY_MUXWAITERS = 152;

        /// ERROR_TOO_MANY_MODULES -> 214L
        public const int ERROR_TOO_MANY_MODULES = 214;

        /// ERROR_TOO_MANY_LUIDS_REQUESTED -> 1333L
        public const int ERROR_TOO_MANY_LUIDS_REQUESTED = 1333;

        /// ERROR_TOO_MANY_LINKS -> 1142L
        public const int ERROR_TOO_MANY_LINKS = 1142;

        /// ERROR_TOO_MANY_CONTEXT_IDS -> 1384L
        public const int ERROR_TOO_MANY_CONTEXT_IDS = 1384;

        /// ERROR_TOO_MANY_CMDS -> 56L
        public const int ERROR_TOO_MANY_CMDS = 56;

        /// ERROR_TOKEN_ALREADY_IN_USE -> 1375L
        public const int ERROR_TOKEN_ALREADY_IN_USE = 1375;

        /// ERROR_TLW_WITH_WSCHILD -> 1406L
        public const int ERROR_TLW_WITH_WSCHILD = 1406;

        /// ERROR_TIME_SKEW -> 1398L
        public const int ERROR_TIME_SKEW = 1398;

        /// ERROR_TIMEOUT -> 1460L
        public const int ERROR_TIMEOUT = 1460;

        /// ERROR_THREAD_1_INACTIVE -> 210L
        public const int ERROR_THREAD_1_INACTIVE = 210;

        /// ERROR_TAG_NOT_PRESENT -> 2013L
        public const int ERROR_TAG_NOT_PRESENT = 2013;

        /// ERROR_TAG_NOT_FOUND -> 2012L
        public const int ERROR_TAG_NOT_FOUND = 2012;

        /// ERROR_SYSTEM_TRACE -> 150L
        public const int ERROR_SYSTEM_TRACE = 150;

        /// ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED -> 1274L
        public const int ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274;

        /// ERROR_SXS_XML_E_XMLDECLSYNTAX -> 14035L
        public const int ERROR_SXS_XML_E_XMLDECLSYNTAX = 14035;

        /// ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK -> 14050L
        public const int ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK = 14050;

        /// ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE -> 14042L
        public const int ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE = 14042;

        /// ERROR_SXS_XML_E_UNEXPECTED_STANDALONE -> 14071L
        public const int ERROR_SXS_XML_E_UNEXPECTED_STANDALONE = 14071;

        /// ERROR_SXS_XML_E_UNEXPECTEDEOF -> 14058L
        public const int ERROR_SXS_XML_E_UNEXPECTEDEOF = 14058;

        /// ERROR_SXS_XML_E_UNEXPECTEDENDTAG -> 14051L
        public const int ERROR_SXS_XML_E_UNEXPECTEDENDTAG = 14051;

        /// ERROR_SXS_XML_E_UNCLOSEDTAG -> 14052L
        public const int ERROR_SXS_XML_E_UNCLOSEDTAG = 14052;

        /// ERROR_SXS_XML_E_UNCLOSEDSTRING -> 14062L
        public const int ERROR_SXS_XML_E_UNCLOSEDSTRING = 14062;

        /// ERROR_SXS_XML_E_UNCLOSEDSTARTTAG -> 14060L
        public const int ERROR_SXS_XML_E_UNCLOSEDSTARTTAG = 14060;

        /// ERROR_SXS_XML_E_UNCLOSEDENDTAG -> 14061L
        public const int ERROR_SXS_XML_E_UNCLOSEDENDTAG = 14061;

        /// ERROR_SXS_XML_E_UNCLOSEDDECL -> 14064L
        public const int ERROR_SXS_XML_E_UNCLOSEDDECL = 14064;

        /// ERROR_SXS_XML_E_UNCLOSEDCOMMENT -> 14063L
        public const int ERROR_SXS_XML_E_UNCLOSEDCOMMENT = 14063;

        /// ERROR_SXS_XML_E_UNCLOSEDCDATA -> 14065L
        public const int ERROR_SXS_XML_E_UNCLOSEDCDATA = 14065;

        /// ERROR_SXS_XML_E_UNBALANCEDPAREN -> 14040L
        public const int ERROR_SXS_XML_E_UNBALANCEDPAREN = 14040;

        /// ERROR_SXS_XML_E_RESERVEDNAMESPACE -> 14066L
        public const int ERROR_SXS_XML_E_RESERVEDNAMESPACE = 14066;

        /// ERROR_SXS_XML_E_MULTIPLE_COLONS -> 14046L
        public const int ERROR_SXS_XML_E_MULTIPLE_COLONS = 14046;

        /// ERROR_SXS_XML_E_MULTIPLEROOTS -> 14054L
        public const int ERROR_SXS_XML_E_MULTIPLEROOTS = 14054;

        /// ERROR_SXS_XML_E_MISSING_PAREN -> 14044L
        public const int ERROR_SXS_XML_E_MISSING_PAREN = 14044;

        /// ERROR_SXS_XML_E_MISSINGWHITESPACE -> 14037L
        public const int ERROR_SXS_XML_E_MISSINGWHITESPACE = 14037;

        /// ERROR_SXS_XML_E_MISSINGSEMICOLON -> 14039L
        public const int ERROR_SXS_XML_E_MISSINGSEMICOLON = 14039;

        /// ERROR_SXS_XML_E_MISSINGROOT -> 14057L
        public const int ERROR_SXS_XML_E_MISSINGROOT = 14057;

        /// ERROR_SXS_XML_E_MISSINGQUOTE -> 14030L
        public const int ERROR_SXS_XML_E_MISSINGQUOTE = 14030;

        /// ERROR_SXS_XML_E_MISSINGEQUALS -> 14073L
        public const int ERROR_SXS_XML_E_MISSINGEQUALS = 14073;

        /// ERROR_SXS_XML_E_INVALID_VERSION -> 14072L
        public const int ERROR_SXS_XML_E_INVALID_VERSION = 14072;

        /// ERROR_SXS_XML_E_INVALID_UNICODE -> 14049L
        public const int ERROR_SXS_XML_E_INVALID_UNICODE = 14049;

        /// ERROR_SXS_XML_E_INVALID_STANDALONE -> 14070L
        public const int ERROR_SXS_XML_E_INVALID_STANDALONE = 14070;

        /// ERROR_SXS_XML_E_INVALID_HEXIDECIMAL -> 14048L
        public const int ERROR_SXS_XML_E_INVALID_HEXIDECIMAL = 14048;

        /// ERROR_SXS_XML_E_INVALID_DECIMAL -> 14047L
        public const int ERROR_SXS_XML_E_INVALID_DECIMAL = 14047;

        /// ERROR_SXS_XML_E_INVALIDSWITCH -> 14068L
        public const int ERROR_SXS_XML_E_INVALIDSWITCH = 14068;

        /// ERROR_SXS_XML_E_INVALIDENCODING -> 14067L
        public const int ERROR_SXS_XML_E_INVALIDENCODING = 14067;

        /// ERROR_SXS_XML_E_INVALIDATROOTLEVEL -> 14055L
        public const int ERROR_SXS_XML_E_INVALIDATROOTLEVEL = 14055;

        /// ERROR_SXS_XML_E_INTERNALERROR -> 14041L
        public const int ERROR_SXS_XML_E_INTERNALERROR = 14041;

        /// ERROR_SXS_XML_E_INCOMPLETE_ENCODING -> 14043L
        public const int ERROR_SXS_XML_E_INCOMPLETE_ENCODING = 14043;

        /// ERROR_SXS_XML_E_EXPECTINGTAGEND -> 14038L
        public const int ERROR_SXS_XML_E_EXPECTINGTAGEND = 14038;

        /// ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE -> 14045L
        public const int ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE = 14045;

        /// ERROR_SXS_XML_E_DUPLICATEATTRIBUTE -> 14053L
        public const int ERROR_SXS_XML_E_DUPLICATEATTRIBUTE = 14053;

        /// ERROR_SXS_XML_E_COMMENTSYNTAX -> 14031L
        public const int ERROR_SXS_XML_E_COMMENTSYNTAX = 14031;

        /// ERROR_SXS_XML_E_BADXMLDECL -> 14056L
        public const int ERROR_SXS_XML_E_BADXMLDECL = 14056;

        /// ERROR_SXS_XML_E_BADXMLCASE -> 14069L
        public const int ERROR_SXS_XML_E_BADXMLCASE = 14069;

        /// ERROR_SXS_XML_E_BADSTARTNAMECHAR -> 14032L
        public const int ERROR_SXS_XML_E_BADSTARTNAMECHAR = 14032;

        /// ERROR_SXS_XML_E_BADPEREFINSUBSET -> 14059L
        public const int ERROR_SXS_XML_E_BADPEREFINSUBSET = 14059;

        /// ERROR_SXS_XML_E_BADNAMECHAR -> 14033L
        public const int ERROR_SXS_XML_E_BADNAMECHAR = 14033;

        /// ERROR_SXS_XML_E_BADCHARINSTRING -> 14034L
        public const int ERROR_SXS_XML_E_BADCHARINSTRING = 14034;

        /// ERROR_SXS_XML_E_BADCHARDATA -> 14036L
        public const int ERROR_SXS_XML_E_BADCHARDATA = 14036;

        /// ERROR_SXS_WRONG_SECTION_TYPE -> 14009L
        public const int ERROR_SXS_WRONG_SECTION_TYPE = 14009;

        /// ERROR_SXS_VERSION_CONFLICT -> 14008L
        public const int ERROR_SXS_VERSION_CONFLICT = 14008;

        /// ERROR_SXS_UNTRANSLATABLE_HRESULT -> 14077L
        public const int ERROR_SXS_UNTRANSLATABLE_HRESULT = 14077;

        /// ERROR_SXS_UNKNOWN_ENCODING_GROUP -> 14012L
        public const int ERROR_SXS_UNKNOWN_ENCODING_GROUP = 14012;

        /// ERROR_SXS_UNKNOWN_ENCODING -> 14013L
        public const int ERROR_SXS_UNKNOWN_ENCODING = 14013;

        /// ERROR_SXS_THREAD_QUERIES_DISABLED -> 14010L
        public const int ERROR_SXS_THREAD_QUERIES_DISABLED = 14010;

        /// ERROR_SXS_SECTION_NOT_FOUND -> 14000L
        public const int ERROR_SXS_SECTION_NOT_FOUND = 14000;

        /// ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED -> 14015L
        public const int ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14015;

        /// ERROR_SXS_PROTECTION_RECOVERY_FAILED -> 14074L
        public const int ERROR_SXS_PROTECTION_RECOVERY_FAILED = 14074;

        /// ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT -> 14075L
        public const int ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT = 14075;

        /// ERROR_SXS_PROTECTION_CATALOG_NOT_VALID -> 14076L
        public const int ERROR_SXS_PROTECTION_CATALOG_NOT_VALID = 14076;

        /// ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING -> 14078L
        public const int ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING = 14078;

        /// ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET -> 14011L
        public const int ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET = 14011;

        /// ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT -> 14020L
        public const int ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT = 14020;

        /// ERROR_SXS_POLICY_PARSE_ERROR -> 14029L
        public const int ERROR_SXS_POLICY_PARSE_ERROR = 14029;

        /// ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE -> 14079L
        public const int ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE = 14079;

        /// ERROR_SXS_MANIFEST_PARSE_ERROR -> 14005L
        public const int ERROR_SXS_MANIFEST_PARSE_ERROR = 14005;

        /// ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE -> 14018L
        public const int ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE = 14018;

        /// ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE -> 14019L
        public const int ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE = 14019;

        /// ERROR_SXS_MANIFEST_FORMAT_ERROR -> 14004L
        public const int ERROR_SXS_MANIFEST_FORMAT_ERROR = 14004;

        /// ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED -> 14016L
        public const int ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14016;

        /// ERROR_SXS_KEY_NOT_FOUND -> 14007L
        public const int ERROR_SXS_KEY_NOT_FOUND = 14007;

        /// ERROR_SXS_INVALID_XML_NAMESPACE_URI -> 14014L
        public const int ERROR_SXS_INVALID_XML_NAMESPACE_URI = 14014;

        /// ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME -> 14080L
        public const int ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME = 14080;

        /// ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE -> 14017L
        public const int ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE = 14017;

        /// ERROR_SXS_INVALID_ACTCTXDATA_FORMAT -> 14002L
        public const int ERROR_SXS_INVALID_ACTCTXDATA_FORMAT = 14002;

        /// ERROR_SXS_FILE_HASH_MISMATCH -> 14028L
        public const int ERROR_SXS_FILE_HASH_MISMATCH = 14028;

        /// ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME -> 14022L
        public const int ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME = 14022;

        /// ERROR_SXS_DUPLICATE_TLBID -> 14025L
        public const int ERROR_SXS_DUPLICATE_TLBID = 14025;

        /// ERROR_SXS_DUPLICATE_PROGID -> 14026L
        public const int ERROR_SXS_DUPLICATE_PROGID = 14026;

        /// ERROR_SXS_DUPLICATE_IID -> 14024L
        public const int ERROR_SXS_DUPLICATE_IID = 14024;

        /// ERROR_SXS_DUPLICATE_DLL_NAME -> 14021L
        public const int ERROR_SXS_DUPLICATE_DLL_NAME = 14021;

        /// ERROR_SXS_DUPLICATE_CLSID -> 14023L
        public const int ERROR_SXS_DUPLICATE_CLSID = 14023;

        /// ERROR_SXS_DUPLICATE_ASSEMBLY_NAME -> 14027L
        public const int ERROR_SXS_DUPLICATE_ASSEMBLY_NAME = 14027;

        /// ERROR_SXS_CANT_GEN_ACTCTX -> 14001L
        public const int ERROR_SXS_CANT_GEN_ACTCTX = 14001;

        /// ERROR_SXS_ASSEMBLY_NOT_FOUND -> 14003L
        public const int ERROR_SXS_ASSEMBLY_NOT_FOUND = 14003;

        /// ERROR_SXS_ACTIVATION_CONTEXT_DISABLED -> 14006L
        public const int ERROR_SXS_ACTIVATION_CONTEXT_DISABLED = 14006;

        /// ERROR_SWAPERROR -> 999L
        public const int ERROR_SWAPERROR = 999;

        /// ERROR_SUCCESS_RESTART_REQUIRED -> 3011L
        public const int ERROR_SUCCESS_RESTART_REQUIRED = 3011;

        /// ERROR_SUCCESS_REBOOT_REQUIRED -> 3010L
        public const int ERROR_SUCCESS_REBOOT_REQUIRED = 3010;

        /// ERROR_SUCCESS_REBOOT_INITIATED -> 1641L
        public const int ERROR_SUCCESS_REBOOT_INITIATED = 1641;

        /// ERROR_SUCCESS -> 0L
        public const int ERROR_SUCCESS = 0;

        /// ERROR_SUBST_TO_SUBST -> 139L
        public const int ERROR_SUBST_TO_SUBST = 139;

        /// ERROR_SUBST_TO_JOIN -> 141L
        public const int ERROR_SUBST_TO_JOIN = 141;

        /// ERROR_STATIC_INIT -> 4002L
        public const int ERROR_STATIC_INIT = 4002;

        /// ERROR_STACK_OVERFLOW -> 1001L
        public const int ERROR_STACK_OVERFLOW = 1001;

        /// ERROR_STACK_BUFFER_OVERRUN -> 1282L
        public const int ERROR_STACK_BUFFER_OVERRUN = 1282;

        /// ERROR_SPOOL_FILE_NOT_FOUND -> 3002L
        public const int ERROR_SPOOL_FILE_NOT_FOUND = 3002;

        /// ERROR_SPL_NO_STARTDOC -> 3003L
        public const int ERROR_SPL_NO_STARTDOC = 3003;

        /// ERROR_SPL_NO_ADDJOB -> 3004L
        public const int ERROR_SPL_NO_ADDJOB = 3004;

        /// ERROR_SPECIAL_USER -> 1373L
        public const int ERROR_SPECIAL_USER = 1373;

        /// ERROR_SPECIAL_GROUP -> 1372L
        public const int ERROR_SPECIAL_GROUP = 1372;

        /// ERROR_SPECIAL_ACCOUNT -> 1371L
        public const int ERROR_SPECIAL_ACCOUNT = 1371;

        /// ERROR_SOURCE_ELEMENT_EMPTY -> 1160L
        public const int ERROR_SOURCE_ELEMENT_EMPTY = 1160;

        /// ERROR_SOME_NOT_MAPPED -> 1301L
        public const int ERROR_SOME_NOT_MAPPED = 1301;

        /// ERROR_SMARTCARD_SUBSYSTEM_FAILURE -> 1264L
        public const int ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264;

        /// ERROR_SLOT_NOT_PRESENT -> 0x00000004
        public const int ERROR_SLOT_NOT_PRESENT = 4;

        /// ERROR_SINGLE_INSTANCE_APP -> 1152L
        public const int ERROR_SINGLE_INSTANCE_APP = 1152;

        /// ERROR_SIGNAL_REFUSED -> 156L
        public const int ERROR_SIGNAL_REFUSED = 156;

        /// ERROR_SIGNAL_PENDING -> 162L
        public const int ERROR_SIGNAL_PENDING = 162;

        /// ERROR_SHUTDOWN_IN_PROGRESS -> 1115L
        public const int ERROR_SHUTDOWN_IN_PROGRESS = 1115;

        /// ERROR_SHUTDOWN_CLUSTER -> 5008L
        public const int ERROR_SHUTDOWN_CLUSTER = 5008;

        /// ERROR_SHARING_VIOLATION -> 32L
        public const int ERROR_SHARING_VIOLATION = 32;

        /// ERROR_SHARING_PAUSED -> 70L
        public const int ERROR_SHARING_PAUSED = 70;

        /// ERROR_SHARING_BUFFER_EXCEEDED -> 36L
        public const int ERROR_SHARING_BUFFER_EXCEEDED = 36;

        /// ERROR_SHARED_POLICY -> 8218L
        public const int ERROR_SHARED_POLICY = 8218;

        /// ERROR_SEVERITY_WARNING -> 0x80000000
        public const int ERROR_SEVERITY_WARNING = -2147483648;

        /// ERROR_SEVERITY_SUCCESS -> 0x00000000
        public const int ERROR_SEVERITY_SUCCESS = 0;

        /// ERROR_SEVERITY_INFORMATIONAL -> 0x40000000
        public const int ERROR_SEVERITY_INFORMATIONAL = 1073741824;

        /// ERROR_SEVERITY_ERROR -> 0xC0000000
        public const int ERROR_SEVERITY_ERROR = -1073741824;

        /// ERROR_SET_POWER_STATE_VETOED -> 1140L
        public const int ERROR_SET_POWER_STATE_VETOED = 1140;

        /// ERROR_SET_POWER_STATE_FAILED -> 1141L
        public const int ERROR_SET_POWER_STATE_FAILED = 1141;

        /// ERROR_SET_NOT_FOUND -> 1170L
        public const int ERROR_SET_NOT_FOUND = 1170;

        /// ERROR_SETMARK_DETECTED -> 1103L
        public const int ERROR_SETMARK_DETECTED = 1103;

        /// ERROR_SETCOUNT_ON_BAD_LB -> 1433L
        public const int ERROR_SETCOUNT_ON_BAD_LB = 1433;

        /// ERROR_SESSION_CREDENTIAL_CONFLICT -> 1219L
        public const int ERROR_SESSION_CREDENTIAL_CONFLICT = 1219;

        /// ERROR_SERVICE_START_HANG -> 1070L
        public const int ERROR_SERVICE_START_HANG = 1070;

        /// ERROR_SERVICE_SPECIFIC_ERROR -> 1066L
        public const int ERROR_SERVICE_SPECIFIC_ERROR = 1066;

        /// ERROR_SERVICE_REQUEST_TIMEOUT -> 1053L
        public const int ERROR_SERVICE_REQUEST_TIMEOUT = 1053;

        /// ERROR_SERVICE_NO_THREAD -> 1054L
        public const int ERROR_SERVICE_NO_THREAD = 1054;

        /// ERROR_SERVICE_NOT_IN_EXE -> 1083L
        public const int ERROR_SERVICE_NOT_IN_EXE = 1083;

        /// ERROR_SERVICE_NOT_FOUND -> 1243L
        public const int ERROR_SERVICE_NOT_FOUND = 1243;

        /// ERROR_SERVICE_NOT_ACTIVE -> 1062L
        public const int ERROR_SERVICE_NOT_ACTIVE = 1062;

        /// ERROR_SERVICE_NEVER_STARTED -> 1077L
        public const int ERROR_SERVICE_NEVER_STARTED = 1077;

        /// ERROR_SERVICE_MARKED_FOR_DELETE -> 1072L
        public const int ERROR_SERVICE_MARKED_FOR_DELETE = 1072;

        /// ERROR_SERVICE_LOGON_FAILED -> 1069L
        public const int ERROR_SERVICE_LOGON_FAILED = 1069;

        /// ERROR_SERVICE_EXISTS -> 1073L
        public const int ERROR_SERVICE_EXISTS = 1073;

        /// ERROR_SERVICE_DOES_NOT_EXIST -> 1060L
        public const int ERROR_SERVICE_DOES_NOT_EXIST = 1060;

        /// ERROR_SERVICE_DISABLED -> 1058L
        public const int ERROR_SERVICE_DISABLED = 1058;

        /// ERROR_SERVICE_DEPENDENCY_FAIL -> 1068L
        public const int ERROR_SERVICE_DEPENDENCY_FAIL = 1068;

        /// ERROR_SERVICE_DEPENDENCY_DELETED -> 1075L
        public const int ERROR_SERVICE_DEPENDENCY_DELETED = 1075;

        /// ERROR_SERVICE_DATABASE_LOCKED -> 1055L
        public const int ERROR_SERVICE_DATABASE_LOCKED = 1055;

        /// ERROR_SERVICE_CANNOT_ACCEPT_CTRL -> 1061L
        public const int ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061;

        /// ERROR_SERVICE_ALREADY_RUNNING -> 1056L
        public const int ERROR_SERVICE_ALREADY_RUNNING = 1056;

        /// ERROR_SERVER_SHUTDOWN_IN_PROGRESS -> 1255L
        public const int ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255;

        /// ERROR_SERVER_NOT_DISABLED -> 1342L
        public const int ERROR_SERVER_NOT_DISABLED = 1342;

        /// ERROR_SERVER_HAS_OPEN_HANDLES -> 1811L
        public const int ERROR_SERVER_HAS_OPEN_HANDLES = 1811;

        /// ERROR_SERVER_DISABLED -> 1341L
        public const int ERROR_SERVER_DISABLED = 1341;

        /// ERROR_SERIAL_NO_DEVICE -> 1118L
        public const int ERROR_SERIAL_NO_DEVICE = 1118;

        /// ERROR_SEM_USER_LIMIT -> 106L
        public const int ERROR_SEM_USER_LIMIT = 106;

        /// ERROR_SEM_TIMEOUT -> 121L
        public const int ERROR_SEM_TIMEOUT = 121;

        /// ERROR_SEM_OWNER_DIED -> 105L
        public const int ERROR_SEM_OWNER_DIED = 105;

        /// ERROR_SEM_NOT_FOUND -> 187L
        public const int ERROR_SEM_NOT_FOUND = 187;

        /// ERROR_SEM_IS_SET -> 102L
        public const int ERROR_SEM_IS_SET = 102;

        /// ERROR_SEEK_ON_DEVICE -> 132L
        public const int ERROR_SEEK_ON_DEVICE = 132;

        /// ERROR_SEEK -> 25L
        public const int ERROR_SEEK = 25;

        /// ERROR_SECTOR_NOT_FOUND -> 27L
        public const int ERROR_SECTOR_NOT_FOUND = 27;

        /// ERROR_SECRET_TOO_LONG -> 1382L
        public const int ERROR_SECRET_TOO_LONG = 1382;

        /// ERROR_SCREEN_ALREADY_LOCKED -> 1440L
        public const int ERROR_SCREEN_ALREADY_LOCKED = 1440;

        /// ERROR_SCOPE_NOT_FOUND -> 318L
        public const int ERROR_SCOPE_NOT_FOUND = 318;

        /// ERROR_SAM_INIT_FAILURE -> 8541L
        public const int ERROR_SAM_INIT_FAILURE = 8541;

        /// ERROR_SAME_DRIVE -> 143L
        public const int ERROR_SAME_DRIVE = 143;

        /// ERROR_RXACT_INVALID_STATE -> 1369L
        public const int ERROR_RXACT_INVALID_STATE = 1369;

        /// ERROR_RXACT_COMMIT_FAILURE -> 1370L
        public const int ERROR_RXACT_COMMIT_FAILURE = 1370;

        /// ERROR_RPL_NOT_ALLOWED -> 4006L
        public const int ERROR_RPL_NOT_ALLOWED = 4006;

        /// ERROR_RMODE_APP -> 1153L
        public const int ERROR_RMODE_APP = 1153;

        /// ERROR_RING2_STACK_IN_USE -> 207L
        public const int ERROR_RING2_STACK_IN_USE = 207;

        /// ERROR_RING2SEG_MUST_BE_MOVABLE -> 200L
        public const int ERROR_RING2SEG_MUST_BE_MOVABLE = 200;

        /// ERROR_REVISION_MISMATCH -> 1306L
        public const int ERROR_REVISION_MISMATCH = 1306;

        /// ERROR_RETRY -> 1237L
        public const int ERROR_RETRY = 1237;

        /// ERROR_RESOURCE_TYPE_NOT_FOUND -> 1813L
        public const int ERROR_RESOURCE_TYPE_NOT_FOUND = 1813;

        /// ERROR_RESOURCE_PROPERTY_UNCHANGEABLE -> 5089L
        public const int ERROR_RESOURCE_PROPERTY_UNCHANGEABLE = 5089;

        /// ERROR_RESOURCE_PROPERTIES_STORED -> 5024L
        public const int ERROR_RESOURCE_PROPERTIES_STORED = 5024;

        /// ERROR_RESOURCE_ONLINE -> 5019L
        public const int ERROR_RESOURCE_ONLINE = 5019;

        /// ERROR_RESOURCE_NOT_PRESENT -> 4316L
        public const int ERROR_RESOURCE_NOT_PRESENT = 4316;

        /// ERROR_RESOURCE_NOT_ONLINE -> 5004L
        public const int ERROR_RESOURCE_NOT_ONLINE = 5004;

        /// ERROR_RESOURCE_NOT_FOUND -> 5007L
        public const int ERROR_RESOURCE_NOT_FOUND = 5007;

        /// ERROR_RESOURCE_NOT_AVAILABLE -> 5006L
        public const int ERROR_RESOURCE_NOT_AVAILABLE = 5006;

        /// ERROR_RESOURCE_NAME_NOT_FOUND -> 1814L
        public const int ERROR_RESOURCE_NAME_NOT_FOUND = 1814;

        /// ERROR_RESOURCE_LANG_NOT_FOUND -> 1815L
        public const int ERROR_RESOURCE_LANG_NOT_FOUND = 1815;

        /// ERROR_RESOURCE_FAILED -> 5038L
        public const int ERROR_RESOURCE_FAILED = 5038;

        /// ERROR_RESOURCE_DISABLED -> 4309L
        public const int ERROR_RESOURCE_DISABLED = 4309;

        /// ERROR_RESOURCE_DATA_NOT_FOUND -> 1812L
        public const int ERROR_RESOURCE_DATA_NOT_FOUND = 1812;

        /// ERROR_RESMON_ONLINE_FAILED -> 5018L
        public const int ERROR_RESMON_ONLINE_FAILED = 5018;

        /// ERROR_RESMON_INVALID_STATE -> 5084L
        public const int ERROR_RESMON_INVALID_STATE = 5084;

        /// ERROR_RESMON_CREATE_FAILED -> 5017L
        public const int ERROR_RESMON_CREATE_FAILED = 5017;

        /// ERROR_REQ_NOT_ACCEP -> 71L
        public const int ERROR_REQ_NOT_ACCEP = 71;

        /// ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION -> 1459L
        public const int ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459;

        /// ERROR_REQUEST_REFUSED -> 4320L
        public const int ERROR_REQUEST_REFUSED = 4320;

        /// ERROR_REQUEST_ABORTED -> 1235L
        public const int ERROR_REQUEST_ABORTED = 1235;

        /// ERROR_REPARSE_TAG_MISMATCH -> 4394L
        public const int ERROR_REPARSE_TAG_MISMATCH = 4394;

        /// ERROR_REPARSE_TAG_INVALID -> 4393L
        public const int ERROR_REPARSE_TAG_INVALID = 4393;

        /// ERROR_REPARSE_ATTRIBUTE_CONFLICT -> 4391L
        public const int ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391;

        /// ERROR_REM_NOT_LIST -> 51L
        public const int ERROR_REM_NOT_LIST = 51;

        /// ERROR_REMOTE_STORAGE_NOT_ACTIVE -> 4351L
        public const int ERROR_REMOTE_STORAGE_NOT_ACTIVE = 4351;

        /// ERROR_REMOTE_STORAGE_MEDIA_ERROR -> 4352L
        public const int ERROR_REMOTE_STORAGE_MEDIA_ERROR = 4352;

        /// ERROR_REMOTE_SESSION_LIMIT_EXCEEDED -> 1220L
        public const int ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220;

        /// ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED -> 1936L
        public const int ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED = 1936;

        /// ERROR_RELOC_CHAIN_XEEDS_SEGLIM -> 201L
        public const int ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201;

        /// ERROR_REG_NAT_CONSUMPTION -> 1261L
        public const int ERROR_REG_NAT_CONSUMPTION = 1261;

        /// ERROR_REGISTRY_RECOVERED -> 1014L
        public const int ERROR_REGISTRY_RECOVERED = 1014;

        /// ERROR_REGISTRY_IO_FAILED -> 1016L
        public const int ERROR_REGISTRY_IO_FAILED = 1016;

        /// ERROR_REGISTRY_CORRUPT -> 1015L
        public const int ERROR_REGISTRY_CORRUPT = 1015;

        /// ERROR_REDIR_PAUSED -> 72L
        public const int ERROR_REDIR_PAUSED = 72;

        /// ERROR_REDIRECTOR_HAS_OPEN_HANDLES -> 1794L
        public const int ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794;

        /// ERROR_REC_NON_EXISTENT -> 4005L
        public const int ERROR_REC_NON_EXISTENT = 4005;

        /// ERROR_RECOVERY_FAILURE -> 1279L
        public const int ERROR_RECOVERY_FAILURE = 1279;

        /// ERROR_READ_FAULT -> 30L
        public const int ERROR_READ_FAULT = 30;

        /// ERROR_QUORUM_RESOURCE_ONLINE_FAILED -> 5027L
        public const int ERROR_QUORUM_RESOURCE_ONLINE_FAILED = 5027;

        /// ERROR_QUORUM_RESOURCE -> 5020L
        public const int ERROR_QUORUM_RESOURCE = 5020;

        /// ERROR_QUORUM_OWNER_ALIVE -> 5034L
        public const int ERROR_QUORUM_OWNER_ALIVE = 5034;

        /// ERROR_QUORUM_DISK_NOT_FOUND -> 5086L
        public const int ERROR_QUORUM_DISK_NOT_FOUND = 5086;

        /// ERROR_QUORUMLOG_OPEN_FAILED -> 5028L
        public const int ERROR_QUORUMLOG_OPEN_FAILED = 5028;

        /// ERROR_PROTOCOL_UNREACHABLE -> 1233L
        public const int ERROR_PROTOCOL_UNREACHABLE = 1233;

        /// ERROR_PROMOTION_ACTIVE -> 8221L
        public const int ERROR_PROMOTION_ACTIVE = 8221;

        /// ERROR_PROFILE_NOT_FOUND -> 2016L
        public const int ERROR_PROFILE_NOT_FOUND = 2016;

        /// ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE -> 2015L
        public const int ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE = 2015;

        /// ERROR_PRODUCT_VERSION -> 1638L
        public const int ERROR_PRODUCT_VERSION = 1638;

        /// ERROR_PRODUCT_UNINSTALLED -> 1614L
        public const int ERROR_PRODUCT_UNINSTALLED = 1614;

        /// ERROR_PROC_NOT_FOUND -> 127L
        public const int ERROR_PROC_NOT_FOUND = 127;

        /// ERROR_PROCESS_ABORTED -> 1067L
        public const int ERROR_PROCESS_ABORTED = 1067;

        /// ERROR_PRIVILEGE_NOT_HELD -> 1314L
        public const int ERROR_PRIVILEGE_NOT_HELD = 1314;

        /// ERROR_PRIVATE_DIALOG_INDEX -> 1415L
        public const int ERROR_PRIVATE_DIALOG_INDEX = 1415;

        /// ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED -> 3005L
        public const int ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005;

        /// ERROR_PRINT_MONITOR_IN_USE -> 3008L
        public const int ERROR_PRINT_MONITOR_IN_USE = 3008;

        /// ERROR_PRINT_MONITOR_ALREADY_INSTALLED -> 3006L
        public const int ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006;

        /// ERROR_PRINT_CANCELLED -> 63L
        public const int ERROR_PRINT_CANCELLED = 63;

        /// ERROR_PRINTQ_FULL -> 61L
        public const int ERROR_PRINTQ_FULL = 61;

        /// ERROR_PRINTER_NOT_FOUND -> 3012L
        public const int ERROR_PRINTER_NOT_FOUND = 3012;

        /// ERROR_PRINTER_HAS_JOBS_QUEUED -> 3009L
        public const int ERROR_PRINTER_HAS_JOBS_QUEUED = 3009;

        /// ERROR_PRINTER_DRIVER_WARNED -> 3013L
        public const int ERROR_PRINTER_DRIVER_WARNED = 3013;

        /// ERROR_PRINTER_DRIVER_IN_USE -> 3001L
        public const int ERROR_PRINTER_DRIVER_IN_USE = 3001;

        /// ERROR_PRINTER_DRIVER_BLOCKED -> 3014L
        public const int ERROR_PRINTER_DRIVER_BLOCKED = 3014;

        /// ERROR_PRINTER_DRIVER_ALREADY_INSTALLED -> 1795L
        public const int ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795;

        /// ERROR_PRINTER_DELETED -> 1905L
        public const int ERROR_PRINTER_DELETED = 1905;

        /// ERROR_PRINTER_ALREADY_EXISTS -> 1802L
        public const int ERROR_PRINTER_ALREADY_EXISTS = 1802;

        /// ERROR_POTENTIAL_FILE_FOUND -> 1180L
        public const int ERROR_POTENTIAL_FILE_FOUND = 1180;

        /// ERROR_POSSIBLE_DEADLOCK -> 1131L
        public const int ERROR_POSSIBLE_DEADLOCK = 1131;

        /// ERROR_PORT_UNREACHABLE -> 1234L
        public const int ERROR_PORT_UNREACHABLE = 1234;

        /// ERROR_POPUP_ALREADY_ACTIVE -> 1446L
        public const int ERROR_POPUP_ALREADY_ACTIVE = 1446;

        /// ERROR_POLICY_ONLY_IN_DS -> 8220L
        public const int ERROR_POLICY_ONLY_IN_DS = 8220;

        /// ERROR_POLICY_OBJECT_NOT_FOUND -> 8219L
        public const int ERROR_POLICY_OBJECT_NOT_FOUND = 8219;

        /// ERROR_POINT_NOT_FOUND -> 1171L
        public const int ERROR_POINT_NOT_FOUND = 1171;

        /// ERROR_PKINIT_FAILURE -> 1263L
        public const int ERROR_PKINIT_FAILURE = 1263;

        /// ERROR_PIPE_NOT_CONNECTED -> 233L
        public const int ERROR_PIPE_NOT_CONNECTED = 233;

        /// ERROR_PIPE_LISTENING -> 536L
        public const int ERROR_PIPE_LISTENING = 536;

        /// ERROR_PIPE_CONNECTED -> 535L
        public const int ERROR_PIPE_CONNECTED = 535;

        /// ERROR_PIPE_BUSY -> 231L
        public const int ERROR_PIPE_BUSY = 231;

        /// ERROR_PER_USER_TRUST_QUOTA_EXCEEDED -> 1932L
        public const int ERROR_PER_USER_TRUST_QUOTA_EXCEEDED = 1932;

        /// ERROR_PATH_NOT_FOUND -> 3L
        public const int ERROR_PATH_NOT_FOUND = 3;

        /// ERROR_PATH_BUSY -> 148L
        public const int ERROR_PATH_BUSY = 148;

        /// ERROR_PATCH_TARGET_NOT_FOUND -> 1642L
        public const int ERROR_PATCH_TARGET_NOT_FOUND = 1642;

        /// ERROR_PATCH_PACKAGE_UNSUPPORTED -> 1637L
        public const int ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637;

        /// ERROR_PATCH_PACKAGE_REJECTED -> 1643L
        public const int ERROR_PATCH_PACKAGE_REJECTED = 1643;

        /// ERROR_PATCH_PACKAGE_OPEN_FAILED -> 1635L
        public const int ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635;

        /// ERROR_PATCH_PACKAGE_INVALID -> 1636L
        public const int ERROR_PATCH_PACKAGE_INVALID = 1636;

        /// ERROR_PASSWORD_RESTRICTION -> 1325L
        public const int ERROR_PASSWORD_RESTRICTION = 1325;

        /// ERROR_PASSWORD_MUST_CHANGE -> 1907L
        public const int ERROR_PASSWORD_MUST_CHANGE = 1907;

        /// ERROR_PASSWORD_EXPIRED -> 1330L
        public const int ERROR_PASSWORD_EXPIRED = 1330;

        /// ERROR_PARTITION_FAILURE -> 1105L
        public const int ERROR_PARTITION_FAILURE = 1105;

        /// ERROR_PARTIAL_COPY -> 299L
        public const int ERROR_PARTIAL_COPY = 299;

        /// ERROR_PARAMETER_QUOTA_EXCEEDED -> 1283L
        public const int ERROR_PARAMETER_QUOTA_EXCEEDED = 1283;

        /// ERROR_PAGEFILE_QUOTA -> 1454L
        public const int ERROR_PAGEFILE_QUOTA = 1454;

        /// ERROR_PAGED_SYSTEM_RESOURCES -> 1452L
        public const int ERROR_PAGED_SYSTEM_RESOURCES = 1452;

        /// ERROR_OVERRIDE_NOCHANGES -> 1252L
        public const int ERROR_OVERRIDE_NOCHANGES = 1252;

        /// ERROR_OUT_OF_STRUCTURES -> 84L
        public const int ERROR_OUT_OF_STRUCTURES = 84;

        /// ERROR_OUT_OF_PAPER -> 28L
        public const int ERROR_OUT_OF_PAPER = 28;

        /// ERROR_OUTOFMEMORY -> 14L
        public const int ERROR_OUTOFMEMORY = 14;

        /// ERROR_OPLOCK_NOT_GRANTED -> 300L
        public const int ERROR_OPLOCK_NOT_GRANTED = 300;

        /// ERROR_OPERATION_ABORTED -> 995L
        public const int ERROR_OPERATION_ABORTED = 995;

        /// ERROR_OPEN_FILES -> 2401L
        public const int ERROR_OPEN_FILES = 2401;

        /// ERROR_OPEN_FAILED -> 110L
        public const int ERROR_OPEN_FAILED = 110;

        /// ERROR_ONLY_IF_CONNECTED -> 1251L
        public const int ERROR_ONLY_IF_CONNECTED = 1251;

        /// ERROR_OLD_WIN_VERSION -> 1150L
        public const int ERROR_OLD_WIN_VERSION = 1150;

        /// ERROR_OBJECT_NOT_FOUND -> 4312L
        public const int ERROR_OBJECT_NOT_FOUND = 4312;

        /// ERROR_OBJECT_IN_LIST -> 5011L
        public const int ERROR_OBJECT_IN_LIST = 5011;

        /// ERROR_OBJECT_ALREADY_EXISTS -> 5010L
        public const int ERROR_OBJECT_ALREADY_EXISTS = 5010;

        /// ERROR_NULL_LM_PASSWORD -> 1304L
        public const int ERROR_NULL_LM_PASSWORD = 1304;

        /// ERROR_NT_CROSS_ENCRYPTION_REQUIRED -> 1386L
        public const int ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386;

        /// ERROR_NO_WILDCARD_CHARACTERS -> 1417L
        public const int ERROR_NO_WILDCARD_CHARACTERS = 1417;

        /// ERROR_NO_VOLUME_LABEL -> 125L
        public const int ERROR_NO_VOLUME_LABEL = 125;

        /// ERROR_NO_VOLUME_ID -> 1173L
        public const int ERROR_NO_VOLUME_ID = 1173;

        /// ERROR_NO_USER_SESSION_KEY -> 1394L
        public const int ERROR_NO_USER_SESSION_KEY = 1394;

        /// ERROR_NO_USER_KEYS -> 6006L
        public const int ERROR_NO_USER_KEYS = 6006;

        /// ERROR_NO_UNICODE_TRANSLATION -> 1113L
        public const int ERROR_NO_UNICODE_TRANSLATION = 1113;

        /// ERROR_NO_TRUST_SAM_ACCOUNT -> 1787L
        public const int ERROR_NO_TRUST_SAM_ACCOUNT = 1787;

        /// ERROR_NO_TRUST_LSA_SECRET -> 1786L
        public const int ERROR_NO_TRUST_LSA_SECRET = 1786;

        /// ERROR_NO_TRACKING_SERVICE -> 1172L
        public const int ERROR_NO_TRACKING_SERVICE = 1172;

        /// ERROR_NO_TOKEN -> 1008L
        public const int ERROR_NO_TOKEN = 1008;

        /// ERROR_NO_SYSTEM_RESOURCES -> 1450L
        public const int ERROR_NO_SYSTEM_RESOURCES = 1450;

        /// ERROR_NO_SYSTEM_MENU -> 1437L
        public const int ERROR_NO_SYSTEM_MENU = 1437;

        /// ERROR_NO_SUPPORTING_DRIVES -> 4339L
        public const int ERROR_NO_SUPPORTING_DRIVES = 4339;

        /// ERROR_NO_SUCH_USER -> 1317L
        public const int ERROR_NO_SUCH_USER = 1317;

        /// ERROR_NO_SUCH_SITE -> 1249L
        public const int ERROR_NO_SUCH_SITE = 1249;

        /// ERROR_NO_SUCH_PRIVILEGE -> 1313L
        public const int ERROR_NO_SUCH_PRIVILEGE = 1313;

        /// ERROR_NO_SUCH_PACKAGE -> 1364L
        public const int ERROR_NO_SUCH_PACKAGE = 1364;

        /// ERROR_NO_SUCH_MEMBER -> 1387L
        public const int ERROR_NO_SUCH_MEMBER = 1387;

        /// ERROR_NO_SUCH_LOGON_SESSION -> 1312L
        public const int ERROR_NO_SUCH_LOGON_SESSION = 1312;

        /// ERROR_NO_SUCH_GROUP -> 1319L
        public const int ERROR_NO_SUCH_GROUP = 1319;

        /// ERROR_NO_SUCH_DOMAIN -> 1355L
        public const int ERROR_NO_SUCH_DOMAIN = 1355;

        /// ERROR_NO_SUCH_ALIAS -> 1376L
        public const int ERROR_NO_SUCH_ALIAS = 1376;

        /// ERROR_NO_SPOOL_SPACE -> 62L
        public const int ERROR_NO_SPOOL_SPACE = 62;

        /// ERROR_NO_SITENAME -> 1919L
        public const int ERROR_NO_SITENAME = 1919;

        /// ERROR_NO_SIGNAL_SENT -> 205L
        public const int ERROR_NO_SIGNAL_SENT = 205;

        /// ERROR_NO_SHUTDOWN_IN_PROGRESS -> 1116L
        public const int ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116;

        /// ERROR_NO_SECURITY_ON_OBJECT -> 1350L
        public const int ERROR_NO_SECURITY_ON_OBJECT = 1350;

        /// ERROR_NO_SCROLLBARS -> 1447L
        public const int ERROR_NO_SCROLLBARS = 1447;

        /// ERROR_NO_RECOVERY_PROGRAM -> 1082L
        public const int ERROR_NO_RECOVERY_PROGRAM = 1082;

        /// ERROR_NO_RECOVERY_POLICY -> 6003L
        public const int ERROR_NO_RECOVERY_POLICY = 6003;

        /// ERROR_NO_QUOTAS_FOR_ACCOUNT -> 1302L
        public const int ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302;

        /// ERROR_NO_PROMOTION_ACTIVE -> 8222L
        public const int ERROR_NO_PROMOTION_ACTIVE = 8222;

        /// ERROR_NO_PROC_SLOTS -> 89L
        public const int ERROR_NO_PROC_SLOTS = 89;

        /// ERROR_NO_NET_OR_BAD_PATH -> 1203L
        public const int ERROR_NO_NET_OR_BAD_PATH = 1203;

        /// ERROR_NO_NETWORK -> 1222L
        public const int ERROR_NO_NETWORK = 1222;

        /// ERROR_NO_MORE_USER_HANDLES -> 1158L
        public const int ERROR_NO_MORE_USER_HANDLES = 1158;

        /// ERROR_NO_MORE_SEARCH_HANDLES -> 113L
        public const int ERROR_NO_MORE_SEARCH_HANDLES = 113;

        /// ERROR_NO_MORE_ITEMS -> 259L
        public const int ERROR_NO_MORE_ITEMS = 259;

        /// ERROR_NO_MORE_FILES -> 18L
        public const int ERROR_NO_MORE_FILES = 18;

        /// ERROR_NO_MORE_DEVICES -> 1248L
        public const int ERROR_NO_MORE_DEVICES = 1248;

        /// ERROR_NO_MEDIA_IN_DRIVE -> 1112L
        public const int ERROR_NO_MEDIA_IN_DRIVE = 1112;

        /// ERROR_NO_MATCH -> 1169L
        public const int ERROR_NO_MATCH = 1169;

        /// ERROR_NO_LOG_SPACE -> 1019L
        public const int ERROR_NO_LOG_SPACE = 1019;

        /// ERROR_NO_LOGON_SERVERS -> 1311L
        public const int ERROR_NO_LOGON_SERVERS = 1311;

        /// ERROR_NO_INHERITANCE -> 1391L
        public const int ERROR_NO_INHERITANCE = 1391;

        /// ERROR_NO_IMPERSONATION_TOKEN -> 1309L
        public const int ERROR_NO_IMPERSONATION_TOKEN = 1309;

        /// ERROR_NO_EFS -> 6004L
        public const int ERROR_NO_EFS = 6004;

        /// ERROR_NO_DATA_DETECTED -> 1104L
        public const int ERROR_NO_DATA_DETECTED = 1104;

        /// ERROR_NO_DATA -> 232L
        public const int ERROR_NO_DATA = 232;

        /// ERROR_NO_BROWSER_SERVERS_FOUND -> 6118L
        public const int ERROR_NO_BROWSER_SERVERS_FOUND = 6118;

        /// ERROR_NO_ASSOCIATION -> 1155L
        public const int ERROR_NO_ASSOCIATION = 1155;

        /// ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER -> 8584L
        public const int ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER = 8584;

        /// ERROR_NOT_SUPPORTED_ON_SBS -> 1254L
        public const int ERROR_NOT_SUPPORTED_ON_SBS = 1254;

        /// ERROR_NOT_SUPPORTED -> 50L
        public const int ERROR_NOT_SUPPORTED = 50;

        /// ERROR_NOT_SUBSTED -> 137L
        public const int ERROR_NOT_SUBSTED = 137;

        /// ERROR_NOT_SAME_DEVICE -> 17L
        public const int ERROR_NOT_SAME_DEVICE = 17;

        /// ERROR_NOT_SAFEBOOT_SERVICE -> 1084L
        public const int ERROR_NOT_SAFEBOOT_SERVICE = 1084;

        /// ERROR_NOT_REGISTRY_FILE -> 1017L
        public const int ERROR_NOT_REGISTRY_FILE = 1017;

        /// ERROR_NOT_READY -> 21L
        public const int ERROR_NOT_READY = 21;

        /// ERROR_NOT_QUORUM_CLASS -> 5025L
        public const int ERROR_NOT_QUORUM_CLASS = 5025;

        /// ERROR_NOT_QUORUM_CAPABLE -> 5021L
        public const int ERROR_NOT_QUORUM_CAPABLE = 5021;

        /// ERROR_NOT_OWNER -> 288L
        public const int ERROR_NOT_OWNER = 288;

        /// ERROR_NOT_LOGON_PROCESS -> 1362L
        public const int ERROR_NOT_LOGON_PROCESS = 1362;

        /// ERROR_NOT_LOGGED_ON -> 1245L
        public const int ERROR_NOT_LOGGED_ON = 1245;

        /// ERROR_NOT_LOCKED -> 158L
        public const int ERROR_NOT_LOCKED = 158;

        /// ERROR_NOT_JOINED -> 136L
        public const int ERROR_NOT_JOINED = 136;

        /// ERROR_NOT_FOUND -> 1168L
        public const int ERROR_NOT_FOUND = 1168;

        /// ERROR_NOT_EXPORT_FORMAT -> 6008L
        public const int ERROR_NOT_EXPORT_FORMAT = 6008;

        /// ERROR_NOT_ENOUGH_SERVER_MEMORY -> 1130L
        public const int ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130;

        /// ERROR_NOT_ENOUGH_QUOTA -> 1816L
        public const int ERROR_NOT_ENOUGH_QUOTA = 1816;

        /// ERROR_NOT_ENOUGH_MEMORY -> 8L
        public const int ERROR_NOT_ENOUGH_MEMORY = 8;

        /// ERROR_NOT_EMPTY -> 4307L
        public const int ERROR_NOT_EMPTY = 4307;

        /// ERROR_NOT_DOS_DISK -> 26L
        public const int ERROR_NOT_DOS_DISK = 26;

        /// ERROR_NOT_CONTAINER -> 1207L
        public const int ERROR_NOT_CONTAINER = 1207;

        /// ERROR_NOT_CONNECTED -> 2250L
        public const int ERROR_NOT_CONNECTED = 2250;

        /// ERROR_NOT_CHILD_WINDOW -> 1442L
        public const int ERROR_NOT_CHILD_WINDOW = 1442;

        /// ERROR_NOT_A_REPARSE_POINT -> 4390L
        public const int ERROR_NOT_A_REPARSE_POINT = 4390;

        /// ERROR_NOT_AUTHENTICATED -> 1244L
        public const int ERROR_NOT_AUTHENTICATED = 1244;

        /// ERROR_NOT_ALL_ASSIGNED -> 1300L
        public const int ERROR_NOT_ALL_ASSIGNED = 1300;

        /// ERROR_NOTIFY_ENUM_DIR -> 1022L
        public const int ERROR_NOTIFY_ENUM_DIR = 1022;

        /// ERROR_NON_MDICHILD_WINDOW -> 1445L
        public const int ERROR_NON_MDICHILD_WINDOW = 1445;

        /// ERROR_NON_DOMAIN_SID -> 1258L
        public const int ERROR_NON_DOMAIN_SID = 1258;

        /// ERROR_NON_ACCOUNT_SID -> 1257L
        public const int ERROR_NON_ACCOUNT_SID = 1257;

        /// ERROR_NONPAGED_SYSTEM_RESOURCES -> 1451L
        public const int ERROR_NONPAGED_SYSTEM_RESOURCES = 1451;

        /// ERROR_NONE_MAPPED -> 1332L
        public const int ERROR_NONE_MAPPED = 1332;

        /// ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT -> 1808L
        public const int ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808;

        /// ERROR_NOLOGON_SERVER_TRUST_ACCOUNT -> 1809L
        public const int ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809;

        /// ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT -> 1807L
        public const int ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807;

        /// ERROR_NODE_NOT_AVAILABLE -> 5036L
        public const int ERROR_NODE_NOT_AVAILABLE = 5036;

        /// ERROR_NODE_CANT_HOST_RESOURCE -> 5071L
        public const int ERROR_NODE_CANT_HOST_RESOURCE = 5071;

        /// ERROR_NODE_CANNOT_BE_CLUSTERED -> 5898L
        public const int ERROR_NODE_CANNOT_BE_CLUSTERED = 5898;

        /// ERROR_NOACCESS -> 998L
        public const int ERROR_NOACCESS = 998;

        /// ERROR_NET_WRITE_FAULT -> 88L
        public const int ERROR_NET_WRITE_FAULT = 88;

        /// ERROR_NETWORK_UNREACHABLE -> 1231L
        public const int ERROR_NETWORK_UNREACHABLE = 1231;

        /// ERROR_NETWORK_NOT_AVAILABLE -> 5035L
        public const int ERROR_NETWORK_NOT_AVAILABLE = 5035;

        /// ERROR_NETWORK_BUSY -> 54L
        public const int ERROR_NETWORK_BUSY = 54;

        /// ERROR_NETWORK_ACCESS_DENIED -> 65L
        public const int ERROR_NETWORK_ACCESS_DENIED = 65;

        /// ERROR_NETNAME_DELETED -> 64L
        public const int ERROR_NETNAME_DELETED = 64;

        /// ERROR_NETLOGON_NOT_STARTED -> 1792L
        public const int ERROR_NETLOGON_NOT_STARTED = 1792;

        /// ERROR_NESTING_NOT_ALLOWED -> 215L
        public const int ERROR_NESTING_NOT_ALLOWED = 215;

        /// ERROR_NEGATIVE_SEEK -> 131L
        public const int ERROR_NEGATIVE_SEEK = 131;

        /// ERROR_MUTUAL_AUTH_FAILED -> 1397L
        public const int ERROR_MUTUAL_AUTH_FAILED = 1397;

        /// ERROR_MR_MID_NOT_FOUND -> 317L
        public const int ERROR_MR_MID_NOT_FOUND = 317;

        /// ERROR_MORE_WRITES -> 1120L
        public const int ERROR_MORE_WRITES = 1120;

        /// ERROR_MORE_DATA -> 234L
        public const int ERROR_MORE_DATA = 234;

        /// ERROR_MOD_NOT_FOUND -> 126L
        public const int ERROR_MOD_NOT_FOUND = 126;

        /// ERROR_META_EXPANSION_TOO_LONG -> 208L
        public const int ERROR_META_EXPANSION_TOO_LONG = 208;

        /// ERROR_METAFILE_NOT_SUPPORTED -> 2003L
        public const int ERROR_METAFILE_NOT_SUPPORTED = 2003;

        /// ERROR_MESSAGE_SYNC_ONLY -> 1159L
        public const int ERROR_MESSAGE_SYNC_ONLY = 1159;

        /// ERROR_MESSAGE_EXCEEDS_MAX_SIZE -> 4336L
        public const int ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336;

        /// ERROR_MENU_ITEM_NOT_FOUND -> 1456L
        public const int ERROR_MENU_ITEM_NOT_FOUND = 1456;

        /// ERROR_MEMBER_NOT_IN_GROUP -> 1321L
        public const int ERROR_MEMBER_NOT_IN_GROUP = 1321;

        /// ERROR_MEMBER_NOT_IN_ALIAS -> 1377L
        public const int ERROR_MEMBER_NOT_IN_ALIAS = 1377;

        /// ERROR_MEMBER_IN_GROUP -> 1320L
        public const int ERROR_MEMBER_IN_GROUP = 1320;

        /// ERROR_MEMBER_IN_ALIAS -> 1378L
        public const int ERROR_MEMBER_IN_ALIAS = 1378;

        /// ERROR_MEMBERS_PRIMARY_GROUP -> 1374L
        public const int ERROR_MEMBERS_PRIMARY_GROUP = 1374;

        /// ERROR_MEDIUM_NOT_ACCESSIBLE -> 4323L
        public const int ERROR_MEDIUM_NOT_ACCESSIBLE = 4323;

        /// ERROR_MEDIA_UNAVAILABLE -> 4308L
        public const int ERROR_MEDIA_UNAVAILABLE = 4308;

        /// ERROR_MEDIA_OFFLINE -> 4304L
        public const int ERROR_MEDIA_OFFLINE = 4304;

        /// ERROR_MEDIA_NOT_AVAILABLE -> 4318L
        public const int ERROR_MEDIA_NOT_AVAILABLE = 4318;

        /// ERROR_MEDIA_INCOMPATIBLE -> 4315L
        public const int ERROR_MEDIA_INCOMPATIBLE = 4315;

        /// ERROR_MEDIA_CHANGED -> 1110L
        public const int ERROR_MEDIA_CHANGED = 1110;

        /// ERROR_MAX_THRDS_REACHED -> 164L
        public const int ERROR_MAX_THRDS_REACHED = 164;

        /// ERROR_MAPPED_ALIGNMENT -> 1132L
        public const int ERROR_MAPPED_ALIGNMENT = 1132;

        /// ERROR_MAGAZINE_NOT_PRESENT -> 1163L
        public const int ERROR_MAGAZINE_NOT_PRESENT = 1163;

        /// ERROR_MACHINE_LOCKED -> 1271L
        public const int ERROR_MACHINE_LOCKED = 1271;

        /// ERROR_LUIDS_EXHAUSTED -> 1334L
        public const int ERROR_LUIDS_EXHAUSTED = 1334;

        /// ERROR_LOG_FILE_FULL -> 1502L
        public const int ERROR_LOG_FILE_FULL = 1502;

        /// ERROR_LOGON_TYPE_NOT_GRANTED -> 1385L
        public const int ERROR_LOGON_TYPE_NOT_GRANTED = 1385;

        /// ERROR_LOGON_SESSION_EXISTS -> 1363L
        public const int ERROR_LOGON_SESSION_EXISTS = 1363;

        /// ERROR_LOGON_SESSION_COLLISION -> 1366L
        public const int ERROR_LOGON_SESSION_COLLISION = 1366;

        /// ERROR_LOGON_NOT_GRANTED -> 1380L
        public const int ERROR_LOGON_NOT_GRANTED = 1380;

        /// ERROR_LOGON_FAILURE -> 1326L
        public const int ERROR_LOGON_FAILURE = 1326;

        /// ERROR_LOGIN_WKSTA_RESTRICTION -> 1240L
        public const int ERROR_LOGIN_WKSTA_RESTRICTION = 1240;

        /// ERROR_LOGIN_TIME_RESTRICTION -> 1239L
        public const int ERROR_LOGIN_TIME_RESTRICTION = 1239;

        /// ERROR_LOCK_VIOLATION -> 33L
        public const int ERROR_LOCK_VIOLATION = 33;

        /// ERROR_LOCK_FAILED -> 167L
        public const int ERROR_LOCK_FAILED = 167;

        /// ERROR_LOCKED -> 212L
        public const int ERROR_LOCKED = 212;

        /// ERROR_LOCAL_USER_SESSION_KEY -> 1303L
        public const int ERROR_LOCAL_USER_SESSION_KEY = 1303;

        /// ERROR_LM_CROSS_ENCRYPTION_REQUIRED -> 1390L
        public const int ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390;

        /// ERROR_LISTBOX_ID_NOT_FOUND -> 1416L
        public const int ERROR_LISTBOX_ID_NOT_FOUND = 1416;

        /// ERROR_LICENSE_QUOTA_EXCEEDED -> 1395L
        public const int ERROR_LICENSE_QUOTA_EXCEEDED = 1395;

        /// ERROR_LIBRARY_OFFLINE -> 4305L
        public const int ERROR_LIBRARY_OFFLINE = 4305;

        /// ERROR_LIBRARY_FULL -> 4322L
        public const int ERROR_LIBRARY_FULL = 4322;

        /// ERROR_LB_WITHOUT_TABSTOPS -> 1434L
        public const int ERROR_LB_WITHOUT_TABSTOPS = 1434;

        /// ERROR_LAST_ADMIN -> 1322L
        public const int ERROR_LAST_ADMIN = 1322;

        /// ERROR_LABEL_UNREADABLE -> 0x00000001
        public const int ERROR_LABEL_UNREADABLE = 1;

        /// ERROR_LABEL_TOO_LONG -> 154L
        public const int ERROR_LABEL_TOO_LONG = 154;

        /// ERROR_LABEL_QUESTIONABLE -> 0x00000002
        public const int ERROR_LABEL_QUESTIONABLE = 2;

        /// ERROR_KM_DRIVER_BLOCKED -> 1930L
        public const int ERROR_KM_DRIVER_BLOCKED = 1930;

        /// ERROR_KEY_HAS_CHILDREN -> 1020L
        public const int ERROR_KEY_HAS_CHILDREN = 1020;

        /// ERROR_KEY_DELETED -> 1018L
        public const int ERROR_KEY_DELETED = 1018;

        /// ERROR_JOURNAL_NOT_ACTIVE -> 1179L
        public const int ERROR_JOURNAL_NOT_ACTIVE = 1179;

        /// ERROR_JOURNAL_HOOK_SET -> 1430L
        public const int ERROR_JOURNAL_HOOK_SET = 1430;

        /// ERROR_JOURNAL_ENTRY_DELETED -> 1181L
        public const int ERROR_JOURNAL_ENTRY_DELETED = 1181;

        /// ERROR_JOURNAL_DELETE_IN_PROGRESS -> 1178L
        public const int ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178;

        /// ERROR_JOIN_TO_SUBST -> 140L
        public const int ERROR_JOIN_TO_SUBST = 140;

        /// ERROR_JOIN_TO_JOIN -> 138L
        public const int ERROR_JOIN_TO_JOIN = 138;

        /// ERROR_ITERATED_DATA_EXCEEDS_64k -> 194L
        public const int ERROR_ITERATED_DATA_EXCEEDS_64k = 194;

        /// ERROR_IS_SUBST_TARGET -> 149L
        public const int ERROR_IS_SUBST_TARGET = 149;

        /// ERROR_IS_SUBST_PATH -> 146L
        public const int ERROR_IS_SUBST_PATH = 146;

        /// ERROR_IS_SUBSTED -> 135L
        public const int ERROR_IS_SUBSTED = 135;

        /// ERROR_IS_JOIN_TARGET -> 133L
        public const int ERROR_IS_JOIN_TARGET = 133;

        /// ERROR_IS_JOIN_PATH -> 147L
        public const int ERROR_IS_JOIN_PATH = 147;

        /// ERROR_IS_JOINED -> 134L
        public const int ERROR_IS_JOINED = 134;

        /// ERROR_IRQ_BUSY -> 1119L
        public const int ERROR_IRQ_BUSY = 1119;

        /// ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION -> 13020L
        public const int ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION = 13020;

        /// ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND -> 13017L
        public const int ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND = 13017;

        /// ERROR_IPSEC_TUNNEL_FILTER_EXISTS -> 13016L
        public const int ERROR_IPSEC_TUNNEL_FILTER_EXISTS = 13016;

        /// ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION -> 13019L
        public const int ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION = 13019;

        /// ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND -> 13009L
        public const int ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND = 13009;

        /// ERROR_IPSEC_TRANSPORT_FILTER_EXISTS -> 13008L
        public const int ERROR_IPSEC_TRANSPORT_FILTER_EXISTS = 13008;

        /// ERROR_IPSEC_QM_POLICY_PENDING_DELETION -> 13023L
        public const int ERROR_IPSEC_QM_POLICY_PENDING_DELETION = 13023;

        /// ERROR_IPSEC_QM_POLICY_NOT_FOUND -> 13001L
        public const int ERROR_IPSEC_QM_POLICY_NOT_FOUND = 13001;

        /// ERROR_IPSEC_QM_POLICY_IN_USE -> 13002L
        public const int ERROR_IPSEC_QM_POLICY_IN_USE = 13002;

        /// ERROR_IPSEC_QM_POLICY_EXISTS -> 13000L
        public const int ERROR_IPSEC_QM_POLICY_EXISTS = 13000;

        /// ERROR_IPSEC_MM_POLICY_PENDING_DELETION -> 13021L
        public const int ERROR_IPSEC_MM_POLICY_PENDING_DELETION = 13021;

        /// ERROR_IPSEC_MM_POLICY_NOT_FOUND -> 13004L
        public const int ERROR_IPSEC_MM_POLICY_NOT_FOUND = 13004;

        /// ERROR_IPSEC_MM_POLICY_IN_USE -> 13005L
        public const int ERROR_IPSEC_MM_POLICY_IN_USE = 13005;

        /// ERROR_IPSEC_MM_POLICY_EXISTS -> 13003L
        public const int ERROR_IPSEC_MM_POLICY_EXISTS = 13003;

        /// ERROR_IPSEC_MM_FILTER_PENDING_DELETION -> 13018L
        public const int ERROR_IPSEC_MM_FILTER_PENDING_DELETION = 13018;

        /// ERROR_IPSEC_MM_FILTER_NOT_FOUND -> 13007L
        public const int ERROR_IPSEC_MM_FILTER_NOT_FOUND = 13007;

        /// ERROR_IPSEC_MM_FILTER_EXISTS -> 13006L
        public const int ERROR_IPSEC_MM_FILTER_EXISTS = 13006;

        /// ERROR_IPSEC_MM_AUTH_PENDING_DELETION -> 13022L
        public const int ERROR_IPSEC_MM_AUTH_PENDING_DELETION = 13022;

        /// ERROR_IPSEC_MM_AUTH_NOT_FOUND -> 13011L
        public const int ERROR_IPSEC_MM_AUTH_NOT_FOUND = 13011;

        /// ERROR_IPSEC_MM_AUTH_IN_USE -> 13012L
        public const int ERROR_IPSEC_MM_AUTH_IN_USE = 13012;

        /// ERROR_IPSEC_MM_AUTH_EXISTS -> 13010L
        public const int ERROR_IPSEC_MM_AUTH_EXISTS = 13010;

        /// ERROR_IPSEC_IKE_UNSUPPORTED_ID -> 13869L
        public const int ERROR_IPSEC_IKE_UNSUPPORTED_ID = 13869;

        /// ERROR_IPSEC_IKE_UNKNOWN_DOI -> 13862L
        public const int ERROR_IPSEC_IKE_UNKNOWN_DOI = 13862;

        /// ERROR_IPSEC_IKE_TIMED_OUT -> 13805L
        public const int ERROR_IPSEC_IKE_TIMED_OUT = 13805;

        /// ERROR_IPSEC_IKE_SRVQUERYCRED -> 13856L
        public const int ERROR_IPSEC_IKE_SRVQUERYCRED = 13856;

        /// ERROR_IPSEC_IKE_SRVACQFAIL -> 13855L
        public const int ERROR_IPSEC_IKE_SRVACQFAIL = 13855;

        /// ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN -> 13845L
        public const int ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN = 13845;

        /// ERROR_IPSEC_IKE_SECLOADFAIL -> 13852L
        public const int ERROR_IPSEC_IKE_SECLOADFAIL = 13852;

        /// ERROR_IPSEC_IKE_SA_REAPED -> 13808L
        public const int ERROR_IPSEC_IKE_SA_REAPED = 13808;

        /// ERROR_IPSEC_IKE_SA_DELETED -> 13807L
        public const int ERROR_IPSEC_IKE_SA_DELETED = 13807;

        /// ERROR_IPSEC_IKE_RPC_DELETE -> 13877L
        public const int ERROR_IPSEC_IKE_RPC_DELETE = 13877;

        /// ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM -> 13812L
        public const int ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM = 13812;

        /// ERROR_IPSEC_IKE_QUEUE_DROP_MM -> 13811L
        public const int ERROR_IPSEC_IKE_QUEUE_DROP_MM = 13811;

        /// ERROR_IPSEC_IKE_QM_DELAY_DROP -> 13815L
        public const int ERROR_IPSEC_IKE_QM_DELAY_DROP = 13815;

        /// ERROR_IPSEC_IKE_QM_ACQUIRE_DROP -> 13810L
        public const int ERROR_IPSEC_IKE_QM_ACQUIRE_DROP = 13810;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR -> 13842L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR = 13842;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_TRANS -> 13832L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_TRANS = 13832;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_SIG -> 13838L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_SIG = 13838;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_SA -> 13830L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_SA = 13830;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_PROP -> 13831L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_PROP = 13831;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY -> 13840L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY = 13840;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_NONCE -> 13839L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_NONCE = 13839;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_KE -> 13833L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_KE = 13833;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_ID -> 13834L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_ID = 13834;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_HASH -> 13837L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_HASH = 13837;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_DELETE -> 13841L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_DELETE = 13841;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ -> 13836L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ = 13836;

        /// ERROR_IPSEC_IKE_PROCESS_ERR_CERT -> 13835L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR_CERT = 13835;

        /// ERROR_IPSEC_IKE_PROCESS_ERR -> 13829L
        public const int ERROR_IPSEC_IKE_PROCESS_ERR = 13829;

        /// ERROR_IPSEC_IKE_POLICY_MATCH -> 13868L
        public const int ERROR_IPSEC_IKE_POLICY_MATCH = 13868;

        /// ERROR_IPSEC_IKE_POLICY_CHANGE -> 13849L
        public const int ERROR_IPSEC_IKE_POLICY_CHANGE = 13849;

        /// ERROR_IPSEC_IKE_PEER_CRL_FAILED -> 13848L
        public const int ERROR_IPSEC_IKE_PEER_CRL_FAILED = 13848;

        /// ERROR_IPSEC_IKE_OUT_OF_MEMORY -> 13859L
        public const int ERROR_IPSEC_IKE_OUT_OF_MEMORY = 13859;

        /// ERROR_IPSEC_IKE_NO_PUBLIC_KEY -> 13828L
        public const int ERROR_IPSEC_IKE_NO_PUBLIC_KEY = 13828;

        /// ERROR_IPSEC_IKE_NO_PRIVATE_KEY -> 13820L
        public const int ERROR_IPSEC_IKE_NO_PRIVATE_KEY = 13820;

        /// ERROR_IPSEC_IKE_NO_POLICY -> 13825L
        public const int ERROR_IPSEC_IKE_NO_POLICY = 13825;

        /// ERROR_IPSEC_IKE_NO_PEER_CERT -> 13847L
        public const int ERROR_IPSEC_IKE_NO_PEER_CERT = 13847;

        /// ERROR_IPSEC_IKE_NO_MM_POLICY -> 13850L
        public const int ERROR_IPSEC_IKE_NO_MM_POLICY = 13850;

        /// ERROR_IPSEC_IKE_NO_CERT -> 13806L
        public const int ERROR_IPSEC_IKE_NO_CERT = 13806;

        /// ERROR_IPSEC_IKE_NOTCBPRIV -> 13851L
        public const int ERROR_IPSEC_IKE_NOTCBPRIV = 13851;

        /// ERROR_IPSEC_IKE_NEG_STATUS_END -> 13884L
        public const int ERROR_IPSEC_IKE_NEG_STATUS_END = 13884;

        /// ERROR_IPSEC_IKE_NEG_STATUS_BEGIN -> 13800L
        public const int ERROR_IPSEC_IKE_NEG_STATUS_BEGIN = 13800;

        /// ERROR_IPSEC_IKE_NEGOTIATION_PENDING -> 13803L
        public const int ERROR_IPSEC_IKE_NEGOTIATION_PENDING = 13803;

        /// ERROR_IPSEC_IKE_NEGOTIATION_DISABLED -> 13883L
        public const int ERROR_IPSEC_IKE_NEGOTIATION_DISABLED = 13883;

        /// ERROR_IPSEC_IKE_MM_LIMIT -> 13882L
        public const int ERROR_IPSEC_IKE_MM_LIMIT = 13882;

        /// ERROR_IPSEC_IKE_MM_DELAY_DROP -> 13814L
        public const int ERROR_IPSEC_IKE_MM_DELAY_DROP = 13814;

        /// ERROR_IPSEC_IKE_MM_ACQUIRE_DROP -> 13809L
        public const int ERROR_IPSEC_IKE_MM_ACQUIRE_DROP = 13809;

        /// ERROR_IPSEC_IKE_LOAD_SOFT_SA -> 13844L
        public const int ERROR_IPSEC_IKE_LOAD_SOFT_SA = 13844;

        /// ERROR_IPSEC_IKE_LOAD_FAILED -> 13876L
        public const int ERROR_IPSEC_IKE_LOAD_FAILED = 13876;

        /// ERROR_IPSEC_IKE_KERBEROS_ERROR -> 13827L
        public const int ERROR_IPSEC_IKE_KERBEROS_ERROR = 13827;

        /// ERROR_IPSEC_IKE_INVALID_SITUATION -> 13863L
        public const int ERROR_IPSEC_IKE_INVALID_SITUATION = 13863;

        /// ERROR_IPSEC_IKE_INVALID_SIGNATURE -> 13826L
        public const int ERROR_IPSEC_IKE_INVALID_SIGNATURE = 13826;

        /// ERROR_IPSEC_IKE_INVALID_SIG -> 13875L
        public const int ERROR_IPSEC_IKE_INVALID_SIG = 13875;

        /// ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY -> 13879L
        public const int ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY = 13879;

        /// ERROR_IPSEC_IKE_INVALID_POLICY -> 13861L
        public const int ERROR_IPSEC_IKE_INVALID_POLICY = 13861;

        /// ERROR_IPSEC_IKE_INVALID_PAYLOAD -> 13843L
        public const int ERROR_IPSEC_IKE_INVALID_PAYLOAD = 13843;

        /// ERROR_IPSEC_IKE_INVALID_KEY_USAGE -> 13818L
        public const int ERROR_IPSEC_IKE_INVALID_KEY_USAGE = 13818;

        /// ERROR_IPSEC_IKE_INVALID_HEADER -> 13824L
        public const int ERROR_IPSEC_IKE_INVALID_HEADER = 13824;

        /// ERROR_IPSEC_IKE_INVALID_HASH_SIZE -> 13872L
        public const int ERROR_IPSEC_IKE_INVALID_HASH_SIZE = 13872;

        /// ERROR_IPSEC_IKE_INVALID_HASH_ALG -> 13871L
        public const int ERROR_IPSEC_IKE_INVALID_HASH_ALG = 13871;

        /// ERROR_IPSEC_IKE_INVALID_HASH -> 13870L
        public const int ERROR_IPSEC_IKE_INVALID_HASH = 13870;

        /// ERROR_IPSEC_IKE_INVALID_GROUP -> 13865L
        public const int ERROR_IPSEC_IKE_INVALID_GROUP = 13865;

        /// ERROR_IPSEC_IKE_INVALID_FILTER -> 13858L
        public const int ERROR_IPSEC_IKE_INVALID_FILTER = 13858;

        /// ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG -> 13873L
        public const int ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG = 13873;

        /// ERROR_IPSEC_IKE_INVALID_COOKIE -> 13846L
        public const int ERROR_IPSEC_IKE_INVALID_COOKIE = 13846;

        /// ERROR_IPSEC_IKE_INVALID_CERT_TYPE -> 13819L
        public const int ERROR_IPSEC_IKE_INVALID_CERT_TYPE = 13819;

        /// ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN -> 13881L
        public const int ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN = 13881;

        /// ERROR_IPSEC_IKE_INVALID_AUTH_ALG -> 13874L
        public const int ERROR_IPSEC_IKE_INVALID_AUTH_ALG = 13874;

        /// ERROR_IPSEC_IKE_GETSPIFAIL -> 13857L
        public const int ERROR_IPSEC_IKE_GETSPIFAIL = 13857;

        /// ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR -> 13804L
        public const int ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR = 13804;

        /// ERROR_IPSEC_IKE_FAILSSPINIT -> 13853L
        public const int ERROR_IPSEC_IKE_FAILSSPINIT = 13853;

        /// ERROR_IPSEC_IKE_FAILQUERYSSP -> 13854L
        public const int ERROR_IPSEC_IKE_FAILQUERYSSP = 13854;

        /// ERROR_IPSEC_IKE_ERROR -> 13816L
        public const int ERROR_IPSEC_IKE_ERROR = 13816;

        /// ERROR_IPSEC_IKE_ENCRYPT -> 13866L
        public const int ERROR_IPSEC_IKE_ENCRYPT = 13866;

        /// ERROR_IPSEC_IKE_DROP_NO_RESPONSE -> 13813L
        public const int ERROR_IPSEC_IKE_DROP_NO_RESPONSE = 13813;

        /// ERROR_IPSEC_IKE_DH_FAILURE -> 13864L
        public const int ERROR_IPSEC_IKE_DH_FAILURE = 13864;

        /// ERROR_IPSEC_IKE_DH_FAIL -> 13822L
        public const int ERROR_IPSEC_IKE_DH_FAIL = 13822;

        /// ERROR_IPSEC_IKE_DECRYPT -> 13867L
        public const int ERROR_IPSEC_IKE_DECRYPT = 13867;

        /// ERROR_IPSEC_IKE_CRL_FAILED -> 13817L
        public const int ERROR_IPSEC_IKE_CRL_FAILED = 13817;

        /// ERROR_IPSEC_IKE_BENIGN_REINIT -> 13878L
        public const int ERROR_IPSEC_IKE_BENIGN_REINIT = 13878;

        /// ERROR_IPSEC_IKE_AUTH_FAIL -> 13801L
        public const int ERROR_IPSEC_IKE_AUTH_FAIL = 13801;

        /// ERROR_IPSEC_IKE_ATTRIB_FAIL -> 13802L
        public const int ERROR_IPSEC_IKE_ATTRIB_FAIL = 13802;

        /// ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED -> 13860L
        public const int ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED = 13860;

        /// ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND -> 13015L
        public const int ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND = 13015;

        /// ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND -> 13013L
        public const int ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND = 13013;

        /// ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND -> 13014L
        public const int ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND = 13014;

        /// ERROR_IO_PENDING -> 997L
        public const int ERROR_IO_PENDING = 997;

        /// ERROR_IO_INCOMPLETE -> 996L
        public const int ERROR_IO_INCOMPLETE = 996;

        /// ERROR_IO_DEVICE -> 1117L
        public const int ERROR_IO_DEVICE = 1117;

        /// ERROR_IOPL_NOT_ENABLED -> 197L
        public const int ERROR_IOPL_NOT_ENABLED = 197;

        /// ERROR_INVALID_WORKSTATION -> 1329L
        public const int ERROR_INVALID_WORKSTATION = 1329;

        /// ERROR_INVALID_WINDOW_STYLE -> 2002L
        public const int ERROR_INVALID_WINDOW_STYLE = 2002;

        /// ERROR_INVALID_WINDOW_HANDLE -> 1400L
        public const int ERROR_INVALID_WINDOW_HANDLE = 1400;

        /// ERROR_INVALID_VERIFY_SWITCH -> 118L
        public const int ERROR_INVALID_VERIFY_SWITCH = 118;

        /// ERROR_INVALID_USER_BUFFER -> 1784L
        public const int ERROR_INVALID_USER_BUFFER = 1784;

        /// ERROR_INVALID_TRANSFORM -> 2020L
        public const int ERROR_INVALID_TRANSFORM = 2020;

        /// ERROR_INVALID_TIME -> 1901L
        public const int ERROR_INVALID_TIME = 1901;

        /// ERROR_INVALID_THREAD_ID -> 1444L
        public const int ERROR_INVALID_THREAD_ID = 1444;

        /// ERROR_INVALID_TARGET_HANDLE -> 114L
        public const int ERROR_INVALID_TARGET_HANDLE = 114;

        /// ERROR_INVALID_TABLE -> 1628L
        public const int ERROR_INVALID_TABLE = 1628;

        /// ERROR_INVALID_SUB_AUTHORITY -> 1335L
        public const int ERROR_INVALID_SUB_AUTHORITY = 1335;

        /// ERROR_INVALID_STATE -> 5023L
        public const int ERROR_INVALID_STATE = 5023;

        /// ERROR_INVALID_STARTING_CODESEG -> 188L
        public const int ERROR_INVALID_STARTING_CODESEG = 188;

        /// ERROR_INVALID_STACKSEG -> 189L
        public const int ERROR_INVALID_STACKSEG = 189;

        /// ERROR_INVALID_SPI_VALUE -> 1439L
        public const int ERROR_INVALID_SPI_VALUE = 1439;

        /// ERROR_INVALID_SIGNAL_NUMBER -> 209L
        public const int ERROR_INVALID_SIGNAL_NUMBER = 209;

        /// ERROR_INVALID_SID -> 1337L
        public const int ERROR_INVALID_SID = 1337;

        /// ERROR_INVALID_SHOWWIN_COMMAND -> 1449L
        public const int ERROR_INVALID_SHOWWIN_COMMAND = 1449;

        /// ERROR_INVALID_SHARENAME -> 1215L
        public const int ERROR_INVALID_SHARENAME = 1215;

        /// ERROR_INVALID_SERVICE_LOCK -> 1071L
        public const int ERROR_INVALID_SERVICE_LOCK = 1071;

        /// ERROR_INVALID_SERVICE_CONTROL -> 1052L
        public const int ERROR_INVALID_SERVICE_CONTROL = 1052;

        /// ERROR_INVALID_SERVICE_ACCOUNT -> 1057L
        public const int ERROR_INVALID_SERVICE_ACCOUNT = 1057;

        /// ERROR_INVALID_SERVICENAME -> 1213L
        public const int ERROR_INVALID_SERVICENAME = 1213;

        /// ERROR_INVALID_SERVER_STATE -> 1352L
        public const int ERROR_INVALID_SERVER_STATE = 1352;

        /// ERROR_INVALID_SEPARATOR_FILE -> 1799L
        public const int ERROR_INVALID_SEPARATOR_FILE = 1799;

        /// ERROR_INVALID_SEGMENT_NUMBER -> 180L
        public const int ERROR_INVALID_SEGMENT_NUMBER = 180;

        /// ERROR_INVALID_SEGDPL -> 198L
        public const int ERROR_INVALID_SEGDPL = 198;

        /// ERROR_INVALID_SECURITY_DESCR -> 1338L
        public const int ERROR_INVALID_SECURITY_DESCR = 1338;

        /// ERROR_INVALID_SCROLLBAR_RANGE -> 1448L
        public const int ERROR_INVALID_SCROLLBAR_RANGE = 1448;

        /// ERROR_INVALID_REPARSE_DATA -> 4392L
        public const int ERROR_INVALID_REPARSE_DATA = 4392;

        /// ERROR_INVALID_PROFILE -> 2011L
        public const int ERROR_INVALID_PROFILE = 2011;

        /// ERROR_INVALID_PRIORITY -> 1800L
        public const int ERROR_INVALID_PRIORITY = 1800;

        /// ERROR_INVALID_PRINT_MONITOR -> 3007L
        public const int ERROR_INVALID_PRINT_MONITOR = 3007;

        /// ERROR_INVALID_PRINTER_STATE -> 1906L
        public const int ERROR_INVALID_PRINTER_STATE = 1906;

        /// ERROR_INVALID_PRINTER_NAME -> 1801L
        public const int ERROR_INVALID_PRINTER_NAME = 1801;

        /// ERROR_INVALID_PRINTER_COMMAND -> 1803L
        public const int ERROR_INVALID_PRINTER_COMMAND = 1803;

        /// ERROR_INVALID_PRIMARY_GROUP -> 1308L
        public const int ERROR_INVALID_PRIMARY_GROUP = 1308;

        /// ERROR_INVALID_PIXEL_FORMAT -> 2000L
        public const int ERROR_INVALID_PIXEL_FORMAT = 2000;

        /// ERROR_INVALID_PASSWORDNAME -> 1216L
        public const int ERROR_INVALID_PASSWORDNAME = 1216;

        /// ERROR_INVALID_PASSWORD -> 86L
        public const int ERROR_INVALID_PASSWORD = 86;

        /// ERROR_INVALID_PARAMETER -> 87L
        public const int ERROR_INVALID_PARAMETER = 87;

        /// ERROR_INVALID_OWNER -> 1307L
        public const int ERROR_INVALID_OWNER = 1307;

        /// ERROR_INVALID_ORDINAL -> 182L
        public const int ERROR_INVALID_ORDINAL = 182;

        /// ERROR_INVALID_OPLOCK_PROTOCOL -> 301L
        public const int ERROR_INVALID_OPLOCK_PROTOCOL = 301;

        /// ERROR_INVALID_OPERATION_ON_QUORUM -> 5068L
        public const int ERROR_INVALID_OPERATION_ON_QUORUM = 5068;

        /// ERROR_INVALID_OPERATION -> 4317L
        public const int ERROR_INVALID_OPERATION = 4317;

        /// ERROR_INVALID_NETNAME -> 1214L
        public const int ERROR_INVALID_NETNAME = 1214;

        /// ERROR_INVALID_NAME -> 123L
        public const int ERROR_INVALID_NAME = 123;

        /// ERROR_INVALID_MSGBOX_STYLE -> 1438L
        public const int ERROR_INVALID_MSGBOX_STYLE = 1438;

        /// ERROR_INVALID_MONITOR_HANDLE -> 1461L
        public const int ERROR_INVALID_MONITOR_HANDLE = 1461;

        /// ERROR_INVALID_MODULETYPE -> 190L
        public const int ERROR_INVALID_MODULETYPE = 190;

        /// ERROR_INVALID_MINALLOCSIZE -> 195L
        public const int ERROR_INVALID_MINALLOCSIZE = 195;

        /// ERROR_INVALID_MESSAGENAME -> 1217L
        public const int ERROR_INVALID_MESSAGENAME = 1217;

        /// ERROR_INVALID_MESSAGEDEST -> 1218L
        public const int ERROR_INVALID_MESSAGEDEST = 1218;

        /// ERROR_INVALID_MESSAGE -> 1002L
        public const int ERROR_INVALID_MESSAGE = 1002;

        /// ERROR_INVALID_MENU_HANDLE -> 1401L
        public const int ERROR_INVALID_MENU_HANDLE = 1401;

        /// ERROR_INVALID_MEMBER -> 1388L
        public const int ERROR_INVALID_MEMBER = 1388;

        /// ERROR_INVALID_MEDIA_POOL -> 4302L
        public const int ERROR_INVALID_MEDIA_POOL = 4302;

        /// ERROR_INVALID_MEDIA -> 4300L
        public const int ERROR_INVALID_MEDIA = 4300;

        /// ERROR_INVALID_LOGON_TYPE -> 1367L
        public const int ERROR_INVALID_LOGON_TYPE = 1367;

        /// ERROR_INVALID_LOGON_HOURS -> 1328L
        public const int ERROR_INVALID_LOGON_HOURS = 1328;

        /// ERROR_INVALID_LIST_FORMAT -> 153L
        public const int ERROR_INVALID_LIST_FORMAT = 153;

        /// ERROR_INVALID_LIBRARY -> 4301L
        public const int ERROR_INVALID_LIBRARY = 4301;

        /// ERROR_INVALID_LEVEL -> 124L
        public const int ERROR_INVALID_LEVEL = 124;

        /// ERROR_INVALID_LB_MESSAGE -> 1432L
        public const int ERROR_INVALID_LB_MESSAGE = 1432;

        /// ERROR_INVALID_KEYBOARD_HANDLE -> 1457L
        public const int ERROR_INVALID_KEYBOARD_HANDLE = 1457;

        /// ERROR_INVALID_INDEX -> 1413L
        public const int ERROR_INVALID_INDEX = 1413;

        /// ERROR_INVALID_IMPORT_OF_NON_DLL -> 1276L
        public const int ERROR_INVALID_IMPORT_OF_NON_DLL = 1276;

        /// ERROR_INVALID_ID_AUTHORITY -> 1343L
        public const int ERROR_INVALID_ID_AUTHORITY = 1343;

        /// ERROR_INVALID_ICON_HANDLE -> 1414L
        public const int ERROR_INVALID_ICON_HANDLE = 1414;

        /// ERROR_INVALID_HOOK_HANDLE -> 1404L
        public const int ERROR_INVALID_HOOK_HANDLE = 1404;

        /// ERROR_INVALID_HOOK_FILTER -> 1426L
        public const int ERROR_INVALID_HOOK_FILTER = 1426;

        /// ERROR_INVALID_HANDLE_STATE -> 1609L
        public const int ERROR_INVALID_HANDLE_STATE = 1609;

        /// ERROR_INVALID_HANDLE -> 6L
        public const int ERROR_INVALID_HANDLE = 6;

        /// ERROR_INVALID_GW_COMMAND -> 1443L
        public const int ERROR_INVALID_GW_COMMAND = 1443;

        /// ERROR_INVALID_GROUP_ATTRIBUTES -> 1345L
        public const int ERROR_INVALID_GROUP_ATTRIBUTES = 1345;

        /// ERROR_INVALID_GROUPNAME -> 1209L
        public const int ERROR_INVALID_GROUPNAME = 1209;

        /// ERROR_INVALID_FUNCTION -> 1L
        public const int ERROR_INVALID_FUNCTION = 1;

        /// ERROR_INVALID_FORM_SIZE -> 1903L
        public const int ERROR_INVALID_FORM_SIZE = 1903;

        /// ERROR_INVALID_FORM_NAME -> 1902L
        public const int ERROR_INVALID_FORM_NAME = 1902;

        /// ERROR_INVALID_FLAG_NUMBER -> 186L
        public const int ERROR_INVALID_FLAG_NUMBER = 186;

        /// ERROR_INVALID_FLAGS -> 1004L
        public const int ERROR_INVALID_FLAGS = 1004;

        /// ERROR_INVALID_FILTER_PROC -> 1427L
        public const int ERROR_INVALID_FILTER_PROC = 1427;

        /// ERROR_INVALID_FIELD -> 1616L
        public const int ERROR_INVALID_FIELD = 1616;

        /// ERROR_INVALID_EXE_SIGNATURE -> 191L
        public const int ERROR_INVALID_EXE_SIGNATURE = 191;

        /// ERROR_INVALID_EVENT_COUNT -> 151L
        public const int ERROR_INVALID_EVENT_COUNT = 151;

        /// ERROR_INVALID_EVENTNAME -> 1211L
        public const int ERROR_INVALID_EVENTNAME = 1211;

        /// ERROR_INVALID_ENVIRONMENT -> 1805L
        public const int ERROR_INVALID_ENVIRONMENT = 1805;

        /// ERROR_INVALID_EDIT_HEIGHT -> 1424L
        public const int ERROR_INVALID_EDIT_HEIGHT = 1424;

        /// ERROR_INVALID_EA_NAME -> 254L
        public const int ERROR_INVALID_EA_NAME = 254;

        /// ERROR_INVALID_EA_HANDLE -> 278L
        public const int ERROR_INVALID_EA_HANDLE = 278;

        /// ERROR_INVALID_DWP_HANDLE -> 1405L
        public const int ERROR_INVALID_DWP_HANDLE = 1405;

        /// ERROR_INVALID_DRIVE_OBJECT -> 4321L
        public const int ERROR_INVALID_DRIVE_OBJECT = 4321;

        /// ERROR_INVALID_DRIVE -> 15L
        public const int ERROR_INVALID_DRIVE = 15;

        /// ERROR_INVALID_DOMAIN_STATE -> 1353L
        public const int ERROR_INVALID_DOMAIN_STATE = 1353;

        /// ERROR_INVALID_DOMAIN_ROLE -> 1354L
        public const int ERROR_INVALID_DOMAIN_ROLE = 1354;

        /// ERROR_INVALID_DOMAINNAME -> 1212L
        public const int ERROR_INVALID_DOMAINNAME = 1212;

        /// ERROR_INVALID_DLL -> 1154L
        public const int ERROR_INVALID_DLL = 1154;

        /// ERROR_INVALID_DATATYPE -> 1804L
        public const int ERROR_INVALID_DATATYPE = 1804;

        /// ERROR_INVALID_DATA -> 13L
        public const int ERROR_INVALID_DATA = 13;

        /// ERROR_INVALID_CURSOR_HANDLE -> 1402L
        public const int ERROR_INVALID_CURSOR_HANDLE = 1402;

        /// ERROR_INVALID_COMPUTERNAME -> 1210L
        public const int ERROR_INVALID_COMPUTERNAME = 1210;

        /// ERROR_INVALID_COMMAND_LINE -> 1639L
        public const int ERROR_INVALID_COMMAND_LINE = 1639;

        /// ERROR_INVALID_COMBOBOX_MESSAGE -> 1422L
        public const int ERROR_INVALID_COMBOBOX_MESSAGE = 1422;

        /// ERROR_INVALID_COLORSPACE -> 2017L
        public const int ERROR_INVALID_COLORSPACE = 2017;

        /// ERROR_INVALID_COLORINDEX -> 2022L
        public const int ERROR_INVALID_COLORINDEX = 2022;

        /// ERROR_INVALID_CMM -> 2010L
        public const int ERROR_INVALID_CMM = 2010;

        /// ERROR_INVALID_CLEANER -> 4310L
        public const int ERROR_INVALID_CLEANER = 4310;

        /// ERROR_INVALID_CATEGORY -> 117L
        public const int ERROR_INVALID_CATEGORY = 117;

        /// ERROR_INVALID_BLOCK_LENGTH -> 1106L
        public const int ERROR_INVALID_BLOCK_LENGTH = 1106;

        /// ERROR_INVALID_BLOCK -> 9L
        public const int ERROR_INVALID_BLOCK = 9;

        /// ERROR_INVALID_AT_INTERRUPT_TIME -> 104L
        public const int ERROR_INVALID_AT_INTERRUPT_TIME = 104;

        /// ERROR_INVALID_ADDRESS -> 487L
        public const int ERROR_INVALID_ADDRESS = 487;

        /// ERROR_INVALID_ACL -> 1336L
        public const int ERROR_INVALID_ACL = 1336;

        /// ERROR_INVALID_ACCOUNT_NAME -> 1315L
        public const int ERROR_INVALID_ACCOUNT_NAME = 1315;

        /// ERROR_INVALID_ACCESS -> 12L
        public const int ERROR_INVALID_ACCESS = 12;

        /// ERROR_INVALID_ACCEL_HANDLE -> 1403L
        public const int ERROR_INVALID_ACCEL_HANDLE = 1403;

        /// ERROR_INTERNAL_ERROR -> 1359L
        public const int ERROR_INTERNAL_ERROR = 1359;

        /// ERROR_INTERNAL_DB_ERROR -> 1383L
        public const int ERROR_INTERNAL_DB_ERROR = 1383;

        /// ERROR_INTERNAL_DB_CORRUPTION -> 1358L
        public const int ERROR_INTERNAL_DB_CORRUPTION = 1358;

        /// ERROR_INSUFFICIENT_BUFFER -> 122L
        public const int ERROR_INSUFFICIENT_BUFFER = 122;

        /// ERROR_INSTALL_USEREXIT -> 1602L
        public const int ERROR_INSTALL_USEREXIT = 1602;

        /// ERROR_INSTALL_UI_FAILURE -> 1621L
        public const int ERROR_INSTALL_UI_FAILURE = 1621;

        /// ERROR_INSTALL_TRANSFORM_REJECTED -> 1644L
        public const int ERROR_INSTALL_TRANSFORM_REJECTED = 1644;

        /// ERROR_INSTALL_TRANSFORM_FAILURE -> 1624L
        public const int ERROR_INSTALL_TRANSFORM_FAILURE = 1624;

        /// ERROR_INSTALL_TEMP_UNWRITABLE -> 1632L
        public const int ERROR_INSTALL_TEMP_UNWRITABLE = 1632;

        /// ERROR_INSTALL_SUSPEND -> 1604L
        public const int ERROR_INSTALL_SUSPEND = 1604;

        /// ERROR_INSTALL_SOURCE_ABSENT -> 1612L
        public const int ERROR_INSTALL_SOURCE_ABSENT = 1612;

        /// ERROR_INSTALL_SERVICE_FAILURE -> 1601L
        public const int ERROR_INSTALL_SERVICE_FAILURE = 1601;

        /// ERROR_INSTALL_REMOTE_PROHIBITED -> 1645L
        public const int ERROR_INSTALL_REMOTE_PROHIBITED = 1645;

        /// ERROR_INSTALL_REMOTE_DISALLOWED -> 1640L
        public const int ERROR_INSTALL_REMOTE_DISALLOWED = 1640;

        /// ERROR_INSTALL_PLATFORM_UNSUPPORTED -> 1633L
        public const int ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633;

        /// ERROR_INSTALL_PACKAGE_VERSION -> 1613L
        public const int ERROR_INSTALL_PACKAGE_VERSION = 1613;

        /// ERROR_INSTALL_PACKAGE_REJECTED -> 1625L
        public const int ERROR_INSTALL_PACKAGE_REJECTED = 1625;

        /// ERROR_INSTALL_PACKAGE_OPEN_FAILED -> 1619L
        public const int ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619;

        /// ERROR_INSTALL_PACKAGE_INVALID -> 1620L
        public const int ERROR_INSTALL_PACKAGE_INVALID = 1620;

        /// ERROR_INSTALL_NOTUSED -> 1634L
        public const int ERROR_INSTALL_NOTUSED = 1634;

        /// ERROR_INSTALL_LOG_FAILURE -> 1622L
        public const int ERROR_INSTALL_LOG_FAILURE = 1622;

        /// ERROR_INSTALL_LANGUAGE_UNSUPPORTED -> 1623L
        public const int ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623;

        /// ERROR_INSTALL_FAILURE -> 1603L
        public const int ERROR_INSTALL_FAILURE = 1603;

        /// ERROR_INSTALL_ALREADY_RUNNING -> 1618L
        public const int ERROR_INSTALL_ALREADY_RUNNING = 1618;

        /// ERROR_INIT_STATUS_NEEDED -> 0x00000011
        public const int ERROR_INIT_STATUS_NEEDED = 17;

        /// ERROR_INFLOOP_IN_RELOC_CHAIN -> 202L
        public const int ERROR_INFLOOP_IN_RELOC_CHAIN = 202;

        /// ERROR_INDIGENOUS_TYPE -> 4338L
        public const int ERROR_INDIGENOUS_TYPE = 4338;

        /// ERROR_INDEX_ABSENT -> 1611L
        public const int ERROR_INDEX_ABSENT = 1611;

        /// ERROR_INC_BACKUP -> 4003L
        public const int ERROR_INC_BACKUP = 4003;

        /// ERROR_INCORRECT_SIZE -> 1462L
        public const int ERROR_INCORRECT_SIZE = 1462;

        /// ERROR_INCORRECT_ADDRESS -> 1241L
        public const int ERROR_INCORRECT_ADDRESS = 1241;

        /// ERROR_ILL_FORMED_PASSWORD -> 1324L
        public const int ERROR_ILL_FORMED_PASSWORD = 1324;

        /// ERROR_ILLEGAL_ELEMENT_ADDRESS -> 1162L
        public const int ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162;

        /// ERROR_IEPORT_FULL -> 4341L
        public const int ERROR_IEPORT_FULL = 4341;

        /// ERROR_ICM_NOT_ENABLED -> 2018L
        public const int ERROR_ICM_NOT_ENABLED = 2018;

        /// ERROR_HWNDS_HAVE_DIFF_PARENT -> 1441L
        public const int ERROR_HWNDS_HAVE_DIFF_PARENT = 1441;

        /// ERROR_HOTKEY_NOT_REGISTERED -> 1419L
        public const int ERROR_HOTKEY_NOT_REGISTERED = 1419;

        /// ERROR_HOTKEY_ALREADY_REGISTERED -> 1409L
        public const int ERROR_HOTKEY_ALREADY_REGISTERED = 1409;

        /// ERROR_HOST_UNREACHABLE -> 1232L
        public const int ERROR_HOST_UNREACHABLE = 1232;

        /// ERROR_HOST_NODE_NOT_RESOURCE_OWNER -> 5015L
        public const int ERROR_HOST_NODE_NOT_RESOURCE_OWNER = 5015;

        /// ERROR_HOST_NODE_NOT_GROUP_OWNER -> 5016L
        public const int ERROR_HOST_NODE_NOT_GROUP_OWNER = 5016;

        /// ERROR_HOST_NODE_NOT_AVAILABLE -> 5005L
        public const int ERROR_HOST_NODE_NOT_AVAILABLE = 5005;

        /// ERROR_HOST_DOWN -> 1256L
        public const int ERROR_HOST_DOWN = 1256;

        /// ERROR_HOOK_TYPE_NOT_ALLOWED -> 1458L
        public const int ERROR_HOOK_TYPE_NOT_ALLOWED = 1458;

        /// ERROR_HOOK_NOT_INSTALLED -> 1431L
        public const int ERROR_HOOK_NOT_INSTALLED = 1431;

        /// ERROR_HOOK_NEEDS_HMOD -> 1428L
        public const int ERROR_HOOK_NEEDS_HMOD = 1428;

        /// ERROR_HANDLE_EOF -> 38L
        public const int ERROR_HANDLE_EOF = 38;

        /// ERROR_HANDLE_DISK_FULL -> 39L
        public const int ERROR_HANDLE_DISK_FULL = 39;

        /// ERROR_GROUP_NOT_ONLINE -> 5014L
        public const int ERROR_GROUP_NOT_ONLINE = 5014;

        /// ERROR_GROUP_NOT_FOUND -> 5013L
        public const int ERROR_GROUP_NOT_FOUND = 5013;

        /// ERROR_GROUP_NOT_AVAILABLE -> 5012L
        public const int ERROR_GROUP_NOT_AVAILABLE = 5012;

        /// ERROR_GROUP_EXISTS -> 1318L
        public const int ERROR_GROUP_EXISTS = 1318;

        /// ERROR_GRACEFUL_DISCONNECT -> 1226L
        public const int ERROR_GRACEFUL_DISCONNECT = 1226;

        /// ERROR_GLOBAL_ONLY_HOOK -> 1429L
        public const int ERROR_GLOBAL_ONLY_HOOK = 1429;

        /// ERROR_GEN_FAILURE -> 31L
        public const int ERROR_GEN_FAILURE = 31;

        /// ERROR_GENERIC_NOT_MAPPED -> 1360L
        public const int ERROR_GENERIC_NOT_MAPPED = 1360;

        /// ERROR_FUNCTION_NOT_CALLED -> 1626L
        public const int ERROR_FUNCTION_NOT_CALLED = 1626;

        /// ERROR_FUNCTION_FAILED -> 1627L
        public const int ERROR_FUNCTION_FAILED = 1627;

        /// ERROR_FULL_BACKUP -> 4004L
        public const int ERROR_FULL_BACKUP = 4004;

        /// ERROR_FULLSCREEN_MODE -> 1007L
        public const int ERROR_FULLSCREEN_MODE = 1007;

        /// ERROR_FLOPPY_WRONG_CYLINDER -> 1123L
        public const int ERROR_FLOPPY_WRONG_CYLINDER = 1123;

        /// ERROR_FLOPPY_UNKNOWN_ERROR -> 1124L
        public const int ERROR_FLOPPY_UNKNOWN_ERROR = 1124;

        /// ERROR_FLOPPY_ID_MARK_NOT_FOUND -> 1122L
        public const int ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122;

        /// ERROR_FLOPPY_BAD_REGISTERS -> 1125L
        public const int ERROR_FLOPPY_BAD_REGISTERS = 1125;

        /// ERROR_FILE_READ_ONLY -> 6009L
        public const int ERROR_FILE_READ_ONLY = 6009;

        /// ERROR_FILE_OFFLINE -> 4350L
        public const int ERROR_FILE_OFFLINE = 4350;

        /// ERROR_FILE_NOT_FOUND -> 2L
        public const int ERROR_FILE_NOT_FOUND = 2;

        /// ERROR_FILE_NOT_ENCRYPTED -> 6007L
        public const int ERROR_FILE_NOT_ENCRYPTED = 6007;

        /// ERROR_FILE_INVALID -> 1006L
        public const int ERROR_FILE_INVALID = 1006;

        /// ERROR_FILE_EXISTS -> 80L
        public const int ERROR_FILE_EXISTS = 80;

        /// ERROR_FILE_ENCRYPTED -> 6002L
        public const int ERROR_FILE_ENCRYPTED = 6002;

        /// ERROR_FILE_CORRUPT -> 1392L
        public const int ERROR_FILE_CORRUPT = 1392;

        /// ERROR_FILENAME_EXCED_RANGE -> 206L
        public const int ERROR_FILENAME_EXCED_RANGE = 206;

        /// ERROR_FILEMARK_DETECTED -> 1101L
        public const int ERROR_FILEMARK_DETECTED = 1101;

        /// ERROR_FAIL_I24 -> 83L
        public const int ERROR_FAIL_I24 = 83;

        /// ERROR_FAILED_SERVICE_CONTROLLER_CONNECT -> 1063L
        public const int ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063;

        /// ERROR_EXTENDED_ERROR -> 1208L
        public const int ERROR_EXTENDED_ERROR = 1208;

        /// ERROR_EXE_MARKED_INVALID -> 192L
        public const int ERROR_EXE_MARKED_INVALID = 192;

        /// ERROR_EXE_MACHINE_TYPE_MISMATCH -> 216L
        public const int ERROR_EXE_MACHINE_TYPE_MISMATCH = 216;

        /// ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY -> 218L
        public const int ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218;

        /// ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY -> 217L
        public const int ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217;

        /// ERROR_EXCL_SEM_ALREADY_OWNED -> 101L
        public const int ERROR_EXCL_SEM_ALREADY_OWNED = 101;

        /// ERROR_EXCEPTION_IN_SERVICE -> 1064L
        public const int ERROR_EXCEPTION_IN_SERVICE = 1064;

        /// ERROR_EVENTLOG_FILE_CORRUPT -> 1500L
        public const int ERROR_EVENTLOG_FILE_CORRUPT = 1500;

        /// ERROR_EVENTLOG_FILE_CHANGED -> 1503L
        public const int ERROR_EVENTLOG_FILE_CHANGED = 1503;

        /// ERROR_EVENTLOG_CANT_START -> 1501L
        public const int ERROR_EVENTLOG_CANT_START = 1501;

        /// ERROR_EOM_OVERFLOW -> 1129L
        public const int ERROR_EOM_OVERFLOW = 1129;

        /// ERROR_ENVVAR_NOT_FOUND -> 203L
        public const int ERROR_ENVVAR_NOT_FOUND = 203;

        /// ERROR_END_OF_MEDIA -> 1100L
        public const int ERROR_END_OF_MEDIA = 1100;

        /// ERROR_ENCRYPTION_FAILED -> 6000L
        public const int ERROR_ENCRYPTION_FAILED = 6000;

        /// ERROR_EMPTY -> 4306L
        public const int ERROR_EMPTY = 4306;

        /// ERROR_EFS_VERSION_NOT_SUPPORT -> 6016L
        public const int ERROR_EFS_VERSION_NOT_SUPPORT = 6016;

        /// ERROR_EFS_SERVER_NOT_TRUSTED -> 6011L
        public const int ERROR_EFS_SERVER_NOT_TRUSTED = 6011;

        /// ERROR_EFS_DISABLED -> 6015L
        public const int ERROR_EFS_DISABLED = 6015;

        /// ERROR_EFS_ALG_BLOB_TOO_BIG -> 6013L
        public const int ERROR_EFS_ALG_BLOB_TOO_BIG = 6013;

        /// ERROR_EA_TABLE_FULL -> 277L
        public const int ERROR_EA_TABLE_FULL = 277;

        /// ERROR_EA_LIST_INCONSISTENT -> 255L
        public const int ERROR_EA_LIST_INCONSISTENT = 255;

        /// ERROR_EA_FILE_CORRUPT -> 276L
        public const int ERROR_EA_FILE_CORRUPT = 276;

        /// ERROR_EA_ACCESS_DENIED -> 994L
        public const int ERROR_EA_ACCESS_DENIED = 994;

        /// ERROR_EAS_NOT_SUPPORTED -> 282L
        public const int ERROR_EAS_NOT_SUPPORTED = 282;

        /// ERROR_EAS_DIDNT_FIT -> 275L
        public const int ERROR_EAS_DIDNT_FIT = 275;

        /// ERROR_DYNLINK_FROM_INVALID_RING -> 196L
        public const int ERROR_DYNLINK_FROM_INVALID_RING = 196;

        /// ERROR_DUP_NAME -> 52L
        public const int ERROR_DUP_NAME = 52;

        /// ERROR_DUP_DOMAINNAME -> 1221L
        public const int ERROR_DUP_DOMAINNAME = 1221;

        /// ERROR_DUPLICATE_TAG -> 2014L
        public const int ERROR_DUPLICATE_TAG = 2014;

        /// ERROR_DUPLICATE_SERVICE_NAME -> 1078L
        public const int ERROR_DUPLICATE_SERVICE_NAME = 1078;

        /// ERROR_DS_WRONG_OM_OBJ_CLASS -> 8476L
        public const int ERROR_DS_WRONG_OM_OBJ_CLASS = 8476;

        /// ERROR_DS_WRONG_LINKED_ATT_SYNTAX -> 8528L
        public const int ERROR_DS_WRONG_LINKED_ATT_SYNTAX = 8528;

        /// ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL -> 8611L
        public const int ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL = 8611;

        /// ERROR_DS_USER_BUFFER_TO_SMALL -> 8309L
        public const int ERROR_DS_USER_BUFFER_TO_SMALL = 8309;

        /// ERROR_DS_UNWILLING_TO_PERFORM -> 8245L
        public const int ERROR_DS_UNWILLING_TO_PERFORM = 8245;

        /// ERROR_DS_UNKNOWN_OPERATION -> 8365L
        public const int ERROR_DS_UNKNOWN_OPERATION = 8365;

        /// ERROR_DS_UNKNOWN_ERROR -> 8431L
        public const int ERROR_DS_UNKNOWN_ERROR = 8431;

        /// ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER -> 8518L
        public const int ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 8518;

        /// ERROR_DS_UNICODEPWD_NOT_IN_QUOTES -> 8556L
        public const int ERROR_DS_UNICODEPWD_NOT_IN_QUOTES = 8556;

        /// ERROR_DS_UNAVAILABLE_CRIT_EXTENSION -> 8236L
        public const int ERROR_DS_UNAVAILABLE_CRIT_EXTENSION = 8236;

        /// ERROR_DS_UNAVAILABLE -> 8207L
        public const int ERROR_DS_UNAVAILABLE = 8207;

        /// ERROR_DS_UNABLE_TO_SURRENDER_ROLES -> 8435L
        public const int ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435;

        /// ERROR_DS_TREE_DELETE_NOT_FINISHED -> 8397L
        public const int ERROR_DS_TREE_DELETE_NOT_FINISHED = 8397;

        /// ERROR_DS_TIMELIMIT_EXCEEDED -> 8226L
        public const int ERROR_DS_TIMELIMIT_EXCEEDED = 8226;

        /// ERROR_DS_THREAD_LIMIT_EXCEEDED -> 8587L
        public const int ERROR_DS_THREAD_LIMIT_EXCEEDED = 8587;

        /// ERROR_DS_SYNTAX_MISMATCH -> 8384L
        public const int ERROR_DS_SYNTAX_MISMATCH = 8384;

        /// ERROR_DS_SUB_CLS_TEST_FAIL -> 8391L
        public const int ERROR_DS_SUB_CLS_TEST_FAIL = 8391;

        /// ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD -> 8376L
        public const int ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD = 8376;

        /// ERROR_DS_SUBREF_MUST_HAVE_PARENT -> 8356L
        public const int ERROR_DS_SUBREF_MUST_HAVE_PARENT = 8356;

        /// ERROR_DS_STRONG_AUTH_REQUIRED -> 8232L
        public const int ERROR_DS_STRONG_AUTH_REQUIRED = 8232;

        /// ERROR_DS_STRING_SD_CONVERSION_FAILED -> 8522L
        public const int ERROR_DS_STRING_SD_CONVERSION_FAILED = 8522;

        /// ERROR_DS_SRC_SID_EXISTS_IN_FOREST -> 8539L
        public const int ERROR_DS_SRC_SID_EXISTS_IN_FOREST = 8539;

        /// ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER -> 8538L
        public const int ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER = 8538;

        /// ERROR_DS_SRC_NAME_MISMATCH -> 8484L
        public const int ERROR_DS_SRC_NAME_MISMATCH = 8484;

        /// ERROR_DS_SRC_GUID_MISMATCH -> 8488L
        public const int ERROR_DS_SRC_GUID_MISMATCH = 8488;

        /// ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER -> 8559L
        public const int ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER = 8559;

        /// ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH -> 8540L
        public const int ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH = 8540;

        /// ERROR_DS_SRC_AND_DST_NC_IDENTICAL -> 8485L
        public const int ERROR_DS_SRC_AND_DST_NC_IDENTICAL = 8485;

        /// ERROR_DS_SOURCE_DOMAIN_IN_FOREST -> 8534L
        public const int ERROR_DS_SOURCE_DOMAIN_IN_FOREST = 8534;

        /// ERROR_DS_SOURCE_AUDITING_NOT_ENABLED -> 8552L
        public const int ERROR_DS_SOURCE_AUDITING_NOT_ENABLED = 8552;

        /// ERROR_DS_SORT_CONTROL_MISSING -> 8261L
        public const int ERROR_DS_SORT_CONTROL_MISSING = 8261;

        /// ERROR_DS_SIZELIMIT_EXCEEDED -> 8227L
        public const int ERROR_DS_SIZELIMIT_EXCEEDED = 8227;

        /// ERROR_DS_SINGLE_VALUE_CONSTRAINT -> 8321L
        public const int ERROR_DS_SINGLE_VALUE_CONSTRAINT = 8321;

        /// ERROR_DS_SINGLE_USER_MODE_FAILED -> 8590L
        public const int ERROR_DS_SINGLE_USER_MODE_FAILED = 8590;

        /// ERROR_DS_SHUTTING_DOWN -> 8364L
        public const int ERROR_DS_SHUTTING_DOWN = 8364;

        /// ERROR_DS_SERVER_DOWN -> 8250L
        public const int ERROR_DS_SERVER_DOWN = 8250;

        /// ERROR_DS_SENSITIVE_GROUP_VIOLATION -> 8505L
        public const int ERROR_DS_SENSITIVE_GROUP_VIOLATION = 8505;

        /// ERROR_DS_SEMANTIC_ATT_TEST -> 8383L
        public const int ERROR_DS_SEMANTIC_ATT_TEST = 8383;

        /// ERROR_DS_SEC_DESC_TOO_SHORT -> 8353L
        public const int ERROR_DS_SEC_DESC_TOO_SHORT = 8353;

        /// ERROR_DS_SEC_DESC_INVALID -> 8354L
        public const int ERROR_DS_SEC_DESC_INVALID = 8354;

        /// ERROR_DS_SECURITY_ILLEGAL_MODIFY -> 8423L
        public const int ERROR_DS_SECURITY_ILLEGAL_MODIFY = 8423;

        /// ERROR_DS_SECURITY_CHECKING_ERROR -> 8413L
        public const int ERROR_DS_SECURITY_CHECKING_ERROR = 8413;

        /// ERROR_DS_SCHEMA_UPDATE_DISALLOWED -> 8509L
        public const int ERROR_DS_SCHEMA_UPDATE_DISALLOWED = 8509;

        /// ERROR_DS_SCHEMA_NOT_LOADED -> 8414L
        public const int ERROR_DS_SCHEMA_NOT_LOADED = 8414;

        /// ERROR_DS_SCHEMA_ALLOC_FAILED -> 8415L
        public const int ERROR_DS_SCHEMA_ALLOC_FAILED = 8415;

        /// ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD -> 8529L
        public const int ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD = 8529;

        /// ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY -> 8530L
        public const int ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY = 8530;

        /// ERROR_DS_SAM_INIT_FAILURE_CONSOLE -> 8562L
        public const int ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562;

        /// ERROR_DS_SAM_INIT_FAILURE -> 8504L
        public const int ERROR_DS_SAM_INIT_FAILURE = 8504;

        /// ERROR_DS_ROOT_REQUIRES_CLASS_TOP -> 8432L
        public const int ERROR_DS_ROOT_REQUIRES_CLASS_TOP = 8432;

        /// ERROR_DS_ROOT_MUST_BE_NC -> 8301L
        public const int ERROR_DS_ROOT_MUST_BE_NC = 8301;

        /// ERROR_DS_ROOT_CANT_BE_SUBREF -> 8326L
        public const int ERROR_DS_ROOT_CANT_BE_SUBREF = 8326;

        /// ERROR_DS_ROLE_NOT_VERIFIED -> 8610L
        public const int ERROR_DS_ROLE_NOT_VERIFIED = 8610;

        /// ERROR_DS_RIDMGR_INIT_ERROR -> 8211L
        public const int ERROR_DS_RIDMGR_INIT_ERROR = 8211;

        /// ERROR_DS_RESERVED_LINK_ID -> 8576L
        public const int ERROR_DS_RESERVED_LINK_ID = 8576;

        /// ERROR_DS_REPL_LIFETIME_EXCEEDED -> 8614L
        public const int ERROR_DS_REPL_LIFETIME_EXCEEDED = 8614;

        /// ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR -> 8595L
        public const int ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR = 8595;

        /// ERROR_DS_REPLICATOR_ONLY -> 8370L
        public const int ERROR_DS_REPLICATOR_ONLY = 8370;

        /// ERROR_DS_REMOTE_CROSSREF_OP_FAILED -> 8601L
        public const int ERROR_DS_REMOTE_CROSSREF_OP_FAILED = 8601;

        /// ERROR_DS_REFUSING_FSMO_ROLES -> 8433L
        public const int ERROR_DS_REFUSING_FSMO_ROLES = 8433;

        /// ERROR_DS_REFERRAL_LIMIT_EXCEEDED -> 8260L
        public const int ERROR_DS_REFERRAL_LIMIT_EXCEEDED = 8260;

        /// ERROR_DS_REFERRAL -> 8235L
        public const int ERROR_DS_REFERRAL = 8235;

        /// ERROR_DS_RECALCSCHEMA_FAILED -> 8396L
        public const int ERROR_DS_RECALCSCHEMA_FAILED = 8396;

        /// ERROR_DS_RDN_DOESNT_MATCH_SCHEMA -> 8307L
        public const int ERROR_DS_RDN_DOESNT_MATCH_SCHEMA = 8307;

        /// ERROR_DS_RANGE_CONSTRAINT -> 8322L
        public const int ERROR_DS_RANGE_CONSTRAINT = 8322;

        /// ERROR_DS_PROTOCOL_ERROR -> 8225L
        public const int ERROR_DS_PROTOCOL_ERROR = 8225;

        /// ERROR_DS_PDC_OPERATION_IN_PROGRESS -> 8490L
        public const int ERROR_DS_PDC_OPERATION_IN_PROGRESS = 8490;

        /// ERROR_DS_PARENT_IS_AN_ALIAS -> 8330L
        public const int ERROR_DS_PARENT_IS_AN_ALIAS = 8330;

        /// ERROR_DS_PARAM_ERROR -> 8255L
        public const int ERROR_DS_PARAM_ERROR = 8255;

        /// ERROR_DS_OUT_OF_VERSION_STORE -> 8573L
        public const int ERROR_DS_OUT_OF_VERSION_STORE = 8573;

        /// ERROR_DS_OUT_OF_SCOPE -> 8338L
        public const int ERROR_DS_OUT_OF_SCOPE = 8338;

        /// ERROR_DS_OPERATIONS_ERROR -> 8224L
        public const int ERROR_DS_OPERATIONS_ERROR = 8224;

        /// ERROR_DS_OFFSET_RANGE_ERROR -> 8262L
        public const int ERROR_DS_OFFSET_RANGE_ERROR = 8262;

        /// ERROR_DS_OBJ_TOO_LARGE -> 8312L
        public const int ERROR_DS_OBJ_TOO_LARGE = 8312;

        /// ERROR_DS_OBJ_STRING_NAME_EXISTS -> 8305L
        public const int ERROR_DS_OBJ_STRING_NAME_EXISTS = 8305;

        /// ERROR_DS_OBJ_NOT_FOUND -> 8333L
        public const int ERROR_DS_OBJ_NOT_FOUND = 8333;

        /// ERROR_DS_OBJ_GUID_EXISTS -> 8361L
        public const int ERROR_DS_OBJ_GUID_EXISTS = 8361;

        /// ERROR_DS_OBJ_CLASS_VIOLATION -> 8212L
        public const int ERROR_DS_OBJ_CLASS_VIOLATION = 8212;

        /// ERROR_DS_OBJ_CLASS_NOT_SUBCLASS -> 8372L
        public const int ERROR_DS_OBJ_CLASS_NOT_SUBCLASS = 8372;

        /// ERROR_DS_OBJ_CLASS_NOT_DEFINED -> 8371L
        public const int ERROR_DS_OBJ_CLASS_NOT_DEFINED = 8371;

        /// ERROR_DS_OBJECT_RESULTS_TOO_LARGE -> 8248L
        public const int ERROR_DS_OBJECT_RESULTS_TOO_LARGE = 8248;

        /// ERROR_DS_OBJECT_CLASS_REQUIRED -> 8315L
        public const int ERROR_DS_OBJECT_CLASS_REQUIRED = 8315;

        /// ERROR_DS_OBJECT_BEING_REMOVED -> 8339L
        public const int ERROR_DS_OBJECT_BEING_REMOVED = 8339;

        /// ERROR_DS_NTDSCRIPT_SYNTAX_ERROR -> 8591L
        public const int ERROR_DS_NTDSCRIPT_SYNTAX_ERROR = 8591;

        /// ERROR_DS_NTDSCRIPT_PROCESS_ERROR -> 8592L
        public const int ERROR_DS_NTDSCRIPT_PROCESS_ERROR = 8592;

        /// ERROR_DS_NO_TREE_DELETE_ABOVE_NC -> 8501L
        public const int ERROR_DS_NO_TREE_DELETE_ABOVE_NC = 8501;

        /// ERROR_DS_NO_SUCH_OBJECT -> 8240L
        public const int ERROR_DS_NO_SUCH_OBJECT = 8240;

        /// ERROR_DS_NO_RIDS_ALLOCATED -> 8208L
        public const int ERROR_DS_NO_RIDS_ALLOCATED = 8208;

        /// ERROR_DS_NO_RESULTS_RETURNED -> 8257L
        public const int ERROR_DS_NO_RESULTS_RETURNED = 8257;

        /// ERROR_DS_NO_REQUESTED_ATTS_FOUND -> 8308L
        public const int ERROR_DS_NO_REQUESTED_ATTS_FOUND = 8308;

        /// ERROR_DS_NO_REF_DOMAIN -> 8575L
        public const int ERROR_DS_NO_REF_DOMAIN = 8575;

        /// ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA -> 8306L
        public const int ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA = 8306;

        /// ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION -> 8533L
        public const int ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION = 8533;

        /// ERROR_DS_NO_PARENT_OBJECT -> 8329L
        public const int ERROR_DS_NO_PARENT_OBJECT = 8329;

        /// ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC -> 8580L
        public const int ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC = 8580;

        /// ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN -> 8515L
        public const int ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 8515;

        /// ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN -> 8514L
        public const int ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 8514;

        /// ERROR_DS_NO_MSDS_INTID -> 8596L
        public const int ERROR_DS_NO_MSDS_INTID = 8596;

        /// ERROR_DS_NO_MORE_RIDS -> 8209L
        public const int ERROR_DS_NO_MORE_RIDS = 8209;

        /// ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS -> 8549L
        public const int ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 8549;

        /// ERROR_DS_NO_DELETED_NAME -> 8355L
        public const int ERROR_DS_NO_DELETED_NAME = 8355;

        /// ERROR_DS_NO_CROSSREF_FOR_NC -> 8363L
        public const int ERROR_DS_NO_CROSSREF_FOR_NC = 8363;

        /// ERROR_DS_NO_CHECKPOINT_WITH_PDC -> 8551L
        public const int ERROR_DS_NO_CHECKPOINT_WITH_PDC = 8551;

        /// ERROR_DS_NO_CHAINING -> 8327L
        public const int ERROR_DS_NO_CHAINING = 8327;

        /// ERROR_DS_NO_CHAINED_EVAL -> 8328L
        public const int ERROR_DS_NO_CHAINED_EVAL = 8328;

        /// ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN -> 8569L
        public const int ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN = 8569;

        /// ERROR_DS_NO_ATTRIBUTE_OR_VALUE -> 8202L
        public const int ERROR_DS_NO_ATTRIBUTE_OR_VALUE = 8202;

        /// ERROR_DS_NOT_SUPPORTED_SORT_ORDER -> 8570L
        public const int ERROR_DS_NOT_SUPPORTED_SORT_ORDER = 8570;

        /// ERROR_DS_NOT_SUPPORTED -> 8256L
        public const int ERROR_DS_NOT_SUPPORTED = 8256;

        /// ERROR_DS_NOT_ON_BACKLINK -> 8362L
        public const int ERROR_DS_NOT_ON_BACKLINK = 8362;

        /// ERROR_DS_NOT_INSTALLED -> 8200L
        public const int ERROR_DS_NOT_INSTALLED = 8200;

        /// ERROR_DS_NOT_CLOSEST -> 8588L
        public const int ERROR_DS_NOT_CLOSEST = 8588;

        /// ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC -> 8487L
        public const int ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC = 8487;

        /// ERROR_DS_NOT_AN_OBJECT -> 8352L
        public const int ERROR_DS_NOT_AN_OBJECT = 8352;

        /// ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX -> 8377L
        public const int ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX = 8377;

        /// ERROR_DS_NON_BASE_SEARCH -> 8480L
        public const int ERROR_DS_NON_BASE_SEARCH = 8480;

        /// ERROR_DS_NONSAFE_SCHEMA_CHANGE -> 8508L
        public const int ERROR_DS_NONSAFE_SCHEMA_CHANGE = 8508;

        /// ERROR_DS_NONEXISTENT_POSS_SUP -> 8390L
        public const int ERROR_DS_NONEXISTENT_POSS_SUP = 8390;

        /// ERROR_DS_NONEXISTENT_MUST_HAVE -> 8388L
        public const int ERROR_DS_NONEXISTENT_MUST_HAVE = 8388;

        /// ERROR_DS_NONEXISTENT_MAY_HAVE -> 8387L
        public const int ERROR_DS_NONEXISTENT_MAY_HAVE = 8387;

        /// ERROR_DS_NC_STILL_HAS_DSAS -> 8546L
        public const int ERROR_DS_NC_STILL_HAS_DSAS = 8546;

        /// ERROR_DS_NC_MUST_HAVE_NC_PARENT -> 8494L
        public const int ERROR_DS_NC_MUST_HAVE_NC_PARENT = 8494;

        /// ERROR_DS_NCNAME_MUST_BE_NC -> 8357L
        public const int ERROR_DS_NCNAME_MUST_BE_NC = 8357;

        /// ERROR_DS_NCNAME_MISSING_CR_REF -> 8412L
        public const int ERROR_DS_NCNAME_MISSING_CR_REF = 8412;

        /// ERROR_DS_NAMING_VIOLATION -> 8247L
        public const int ERROR_DS_NAMING_VIOLATION = 8247;

        /// ERROR_DS_NAMING_MASTER_GC -> 8523L
        public const int ERROR_DS_NAMING_MASTER_GC = 8523;

        /// ERROR_DS_NAME_VALUE_TOO_LONG -> 8349L
        public const int ERROR_DS_NAME_VALUE_TOO_LONG = 8349;

        /// ERROR_DS_NAME_UNPARSEABLE -> 8350L
        public const int ERROR_DS_NAME_UNPARSEABLE = 8350;

        /// ERROR_DS_NAME_TYPE_UNKNOWN -> 8351L
        public const int ERROR_DS_NAME_TYPE_UNKNOWN = 8351;

        /// ERROR_DS_NAME_TOO_MANY_PARTS -> 8347L
        public const int ERROR_DS_NAME_TOO_MANY_PARTS = 8347;

        /// ERROR_DS_NAME_TOO_LONG -> 8348L
        public const int ERROR_DS_NAME_TOO_LONG = 8348;

        /// ERROR_DS_NAME_REFERENCE_INVALID -> 8373L
        public const int ERROR_DS_NAME_REFERENCE_INVALID = 8373;

        /// ERROR_DS_NAME_NOT_UNIQUE -> 8571L
        public const int ERROR_DS_NAME_NOT_UNIQUE = 8571;

        /// ERROR_DS_NAME_ERROR_TRUST_REFERRAL -> 8583L
        public const int ERROR_DS_NAME_ERROR_TRUST_REFERRAL = 8583;

        /// ERROR_DS_NAME_ERROR_RESOLVING -> 8469L
        public const int ERROR_DS_NAME_ERROR_RESOLVING = 8469;

        /// ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING -> 8474L
        public const int ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 8474;

        /// ERROR_DS_NAME_ERROR_NO_MAPPING -> 8472L
        public const int ERROR_DS_NAME_ERROR_NO_MAPPING = 8472;

        /// ERROR_DS_NAME_ERROR_NOT_UNIQUE -> 8471L
        public const int ERROR_DS_NAME_ERROR_NOT_UNIQUE = 8471;

        /// ERROR_DS_NAME_ERROR_NOT_FOUND -> 8470L
        public const int ERROR_DS_NAME_ERROR_NOT_FOUND = 8470;

        /// ERROR_DS_NAME_ERROR_DOMAIN_ONLY -> 8473L
        public const int ERROR_DS_NAME_ERROR_DOMAIN_ONLY = 8473;

        /// ERROR_DS_MUST_BE_RUN_ON_DST_DC -> 8558L
        public const int ERROR_DS_MUST_BE_RUN_ON_DST_DC = 8558;

        /// ERROR_DS_MODIFYDN_WRONG_GRANDPARENT -> 8582L
        public const int ERROR_DS_MODIFYDN_WRONG_GRANDPARENT = 8582;

        /// ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE -> 8579L
        public const int ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE = 8579;

        /// ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG -> 8581L
        public const int ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG = 8581;

        /// ERROR_DS_MISSING_SUPREF -> 8406L
        public const int ERROR_DS_MISSING_SUPREF = 8406;

        /// ERROR_DS_MISSING_REQUIRED_ATT -> 8316L
        public const int ERROR_DS_MISSING_REQUIRED_ATT = 8316;

        /// ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER -> 8497L
        public const int ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER = 8497;

        /// ERROR_DS_MISSING_FSMO_SETTINGS -> 8434L
        public const int ERROR_DS_MISSING_FSMO_SETTINGS = 8434;

        /// ERROR_DS_MISSING_EXPECTED_ATT -> 8411L
        public const int ERROR_DS_MISSING_EXPECTED_ATT = 8411;

        /// ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY -> 8201L
        public const int ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY = 8201;

        /// ERROR_DS_MAX_OBJ_SIZE_EXCEEDED -> 8304L
        public const int ERROR_DS_MAX_OBJ_SIZE_EXCEEDED = 8304;

        /// ERROR_DS_MASTERDSA_REQUIRED -> 8314L
        public const int ERROR_DS_MASTERDSA_REQUIRED = 8314;

        /// ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED -> 8557L
        public const int ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 8557;

        /// ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 -> 8572L
        public const int ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 = 8572;

        /// ERROR_DS_LOW_DSA_VERSION -> 8568L
        public const int ERROR_DS_LOW_DSA_VERSION = 8568;

        /// ERROR_DS_LOOP_DETECT -> 8246L
        public const int ERROR_DS_LOOP_DETECT = 8246;

        /// ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY -> 8548L
        public const int ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 8548;

        /// ERROR_DS_LOCAL_ERROR -> 8251L
        public const int ERROR_DS_LOCAL_ERROR = 8251;

        /// ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER -> 8520L
        public const int ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 8520;

        /// ERROR_DS_LINK_ID_NOT_AVAILABLE -> 8577L
        public const int ERROR_DS_LINK_ID_NOT_AVAILABLE = 8577;

        /// ERROR_DS_LDAP_SEND_QUEUE_FULL -> 8616L
        public const int ERROR_DS_LDAP_SEND_QUEUE_FULL = 8616;

        /// ERROR_DS_KEY_NOT_UNIQUE -> 8527L
        public const int ERROR_DS_KEY_NOT_UNIQUE = 8527;

        /// ERROR_DS_IS_LEAF -> 8243L
        public const int ERROR_DS_IS_LEAF = 8243;

        /// ERROR_DS_INVALID_SEARCH_FLAG -> 8500L
        public const int ERROR_DS_INVALID_SEARCH_FLAG = 8500;

        /// ERROR_DS_INVALID_SCRIPT -> 8600L
        public const int ERROR_DS_INVALID_SCRIPT = 8600;

        /// ERROR_DS_INVALID_ROLE_OWNER -> 8366L
        public const int ERROR_DS_INVALID_ROLE_OWNER = 8366;

        /// ERROR_DS_INVALID_NAME_FOR_SPN -> 8554L
        public const int ERROR_DS_INVALID_NAME_FOR_SPN = 8554;

        /// ERROR_DS_INVALID_LDAP_DISPLAY_NAME -> 8479L
        public const int ERROR_DS_INVALID_LDAP_DISPLAY_NAME = 8479;

        /// ERROR_DS_INVALID_GROUP_TYPE -> 8513L
        public const int ERROR_DS_INVALID_GROUP_TYPE = 8513;

        /// ERROR_DS_INVALID_DN_SYNTAX -> 8242L
        public const int ERROR_DS_INVALID_DN_SYNTAX = 8242;

        /// ERROR_DS_INVALID_DMD -> 8360L
        public const int ERROR_DS_INVALID_DMD = 8360;

        /// ERROR_DS_INVALID_ATTRIBUTE_SYNTAX -> 8203L
        public const int ERROR_DS_INVALID_ATTRIBUTE_SYNTAX = 8203;

        /// ERROR_DS_INTERNAL_FAILURE -> 8430L
        public const int ERROR_DS_INTERNAL_FAILURE = 8430;

        /// ERROR_DS_INSUFF_ACCESS_RIGHTS -> 8344L
        public const int ERROR_DS_INSUFF_ACCESS_RIGHTS = 8344;

        /// ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT -> 8606L
        public const int ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT = 8606;

        /// ERROR_DS_INSTALL_SCHEMA_MISMATCH -> 8467L
        public const int ERROR_DS_INSTALL_SCHEMA_MISMATCH = 8467;

        /// ERROR_DS_INSTALL_NO_SRC_SCH_VERSION -> 8511L
        public const int ERROR_DS_INSTALL_NO_SRC_SCH_VERSION = 8511;

        /// ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE -> 8512L
        public const int ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE = 8512;

        /// ERROR_DS_INIT_FAILURE_CONSOLE -> 8561L
        public const int ERROR_DS_INIT_FAILURE_CONSOLE = 8561;

        /// ERROR_DS_INIT_FAILURE -> 8532L
        public const int ERROR_DS_INIT_FAILURE = 8532;

        /// ERROR_DS_INCORRECT_ROLE_OWNER -> 8210L
        public const int ERROR_DS_INCORRECT_ROLE_OWNER = 8210;

        /// ERROR_DS_INCOMPATIBLE_VERSION -> 8567L
        public const int ERROR_DS_INCOMPATIBLE_VERSION = 8567;

        /// ERROR_DS_INCOMPATIBLE_CONTROLS_USED -> 8574L
        public const int ERROR_DS_INCOMPATIBLE_CONTROLS_USED = 8574;

        /// ERROR_DS_INAPPROPRIATE_MATCHING -> 8238L
        public const int ERROR_DS_INAPPROPRIATE_MATCHING = 8238;

        /// ERROR_DS_INAPPROPRIATE_AUTH -> 8233L
        public const int ERROR_DS_INAPPROPRIATE_AUTH = 8233;

        /// ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION -> 8492L
        public const int ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION = 8492;

        /// ERROR_DS_ILLEGAL_SUPERIOR -> 8345L
        public const int ERROR_DS_ILLEGAL_SUPERIOR = 8345;

        /// ERROR_DS_ILLEGAL_MOD_OPERATION -> 8311L
        public const int ERROR_DS_ILLEGAL_MOD_OPERATION = 8311;

        /// ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD -> 8507L
        public const int ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD = 8507;

        /// ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED -> 8429L
        public const int ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED = 8429;

        /// ERROR_DS_HAVE_PRIMARY_MEMBERS -> 8521L
        public const int ERROR_DS_HAVE_PRIMARY_MEMBERS = 8521;

        /// ERROR_DS_GROUP_CONVERSION_ERROR -> 8607L
        public const int ERROR_DS_GROUP_CONVERSION_ERROR = 8607;

        /// ERROR_DS_GOVERNSID_MISSING -> 8410L
        public const int ERROR_DS_GOVERNSID_MISSING = 8410;

        /// ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER -> 8517L
        public const int ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 8517;

        /// ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER -> 8516L
        public const int ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 8516;

        /// ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER -> 8519L
        public const int ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 8519;

        /// ERROR_DS_GENERIC_ERROR -> 8341L
        public const int ERROR_DS_GENERIC_ERROR = 8341;

        /// ERROR_DS_GC_REQUIRED -> 8547L
        public const int ERROR_DS_GC_REQUIRED = 8547;

        /// ERROR_DS_GC_NOT_AVAILABLE -> 8217L
        public const int ERROR_DS_GC_NOT_AVAILABLE = 8217;

        /// ERROR_DS_GCVERIFY_ERROR -> 8417L
        public const int ERROR_DS_GCVERIFY_ERROR = 8417;

        /// ERROR_DS_FOREST_VERSION_TOO_LOW -> 8565L
        public const int ERROR_DS_FOREST_VERSION_TOO_LOW = 8565;

        /// ERROR_DS_FOREST_VERSION_TOO_HIGH -> 8563L
        public const int ERROR_DS_FOREST_VERSION_TOO_HIGH = 8563;

        /// ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS -> 8555L
        public const int ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS = 8555;

        /// ERROR_DS_FILTER_UNKNOWN -> 8254L
        public const int ERROR_DS_FILTER_UNKNOWN = 8254;

        /// ERROR_DS_EXISTS_IN_SUB_CLS -> 8394L
        public const int ERROR_DS_EXISTS_IN_SUB_CLS = 8394;

        /// ERROR_DS_EXISTS_IN_RDNATTID -> 8598L
        public const int ERROR_DS_EXISTS_IN_RDNATTID = 8598;

        /// ERROR_DS_EXISTS_IN_POSS_SUP -> 8395L
        public const int ERROR_DS_EXISTS_IN_POSS_SUP = 8395;

        /// ERROR_DS_EXISTS_IN_MUST_HAVE -> 8385L
        public const int ERROR_DS_EXISTS_IN_MUST_HAVE = 8385;

        /// ERROR_DS_EXISTS_IN_MAY_HAVE -> 8386L
        public const int ERROR_DS_EXISTS_IN_MAY_HAVE = 8386;

        /// ERROR_DS_EXISTS_IN_AUX_CLS -> 8393L
        public const int ERROR_DS_EXISTS_IN_AUX_CLS = 8393;

        /// ERROR_DS_EXISTING_AD_CHILD_NC -> 8613L
        public const int ERROR_DS_EXISTING_AD_CHILD_NC = 8613;

        /// ERROR_DS_EPOCH_MISMATCH -> 8483L
        public const int ERROR_DS_EPOCH_MISMATCH = 8483;

        /// ERROR_DS_ENCODING_ERROR -> 8252L
        public const int ERROR_DS_ENCODING_ERROR = 8252;

        /// ERROR_DS_DUP_SCHEMA_ID_GUID -> 8381L
        public const int ERROR_DS_DUP_SCHEMA_ID_GUID = 8381;

        /// ERROR_DS_DUP_RDN -> 8378L
        public const int ERROR_DS_DUP_RDN = 8378;

        /// ERROR_DS_DUP_OID -> 8379L
        public const int ERROR_DS_DUP_OID = 8379;

        /// ERROR_DS_DUP_MSDS_INTID -> 8597L
        public const int ERROR_DS_DUP_MSDS_INTID = 8597;

        /// ERROR_DS_DUP_MAPI_ID -> 8380L
        public const int ERROR_DS_DUP_MAPI_ID = 8380;

        /// ERROR_DS_DUP_LINK_ID -> 8468L
        public const int ERROR_DS_DUP_LINK_ID = 8468;

        /// ERROR_DS_DUP_LDAP_DISPLAY_NAME -> 8382L
        public const int ERROR_DS_DUP_LDAP_DISPLAY_NAME = 8382;

        /// ERROR_DS_DUPLICATE_ID_FOUND -> 8605L
        public const int ERROR_DS_DUPLICATE_ID_FOUND = 8605;

        /// ERROR_DS_DS_REQUIRED -> 8478L
        public const int ERROR_DS_DS_REQUIRED = 8478;

        /// ERROR_DS_DST_NC_MISMATCH -> 8486L
        public const int ERROR_DS_DST_NC_MISMATCH = 8486;

        /// ERROR_DS_DST_DOMAIN_NOT_NATIVE -> 8496L
        public const int ERROR_DS_DST_DOMAIN_NOT_NATIVE = 8496;

        /// ERROR_DS_DSA_MUST_BE_INT_MASTER -> 8342L
        public const int ERROR_DS_DSA_MUST_BE_INT_MASTER = 8342;

        /// ERROR_DS_DRS_EXTENSIONS_CHANGED -> 8594L
        public const int ERROR_DS_DRS_EXTENSIONS_CHANGED = 8594;

        /// ERROR_DS_DRA_SOURCE_REINSTALLED -> 8459L
        public const int ERROR_DS_DRA_SOURCE_REINSTALLED = 8459;

        /// ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA -> 8465L
        public const int ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA = 8465;

        /// ERROR_DS_DRA_SOURCE_DISABLED -> 8456L
        public const int ERROR_DS_DRA_SOURCE_DISABLED = 8456;

        /// ERROR_DS_DRA_SINK_DISABLED -> 8457L
        public const int ERROR_DS_DRA_SINK_DISABLED = 8457;

        /// ERROR_DS_DRA_SHUTDOWN -> 8463L
        public const int ERROR_DS_DRA_SHUTDOWN = 8463;

        /// ERROR_DS_DRA_SCHEMA_MISMATCH -> 8418L
        public const int ERROR_DS_DRA_SCHEMA_MISMATCH = 8418;

        /// ERROR_DS_DRA_SCHEMA_INFO_SHIP -> 8542L
        public const int ERROR_DS_DRA_SCHEMA_INFO_SHIP = 8542;

        /// ERROR_DS_DRA_SCHEMA_CONFLICT -> 8543L
        public const int ERROR_DS_DRA_SCHEMA_CONFLICT = 8543;

        /// ERROR_DS_DRA_RPC_CANCELLED -> 8455L
        public const int ERROR_DS_DRA_RPC_CANCELLED = 8455;

        /// ERROR_DS_DRA_REPL_PENDING -> 8477L
        public const int ERROR_DS_DRA_REPL_PENDING = 8477;

        /// ERROR_DS_DRA_REF_NOT_FOUND -> 8449L
        public const int ERROR_DS_DRA_REF_NOT_FOUND = 8449;

        /// ERROR_DS_DRA_REF_ALREADY_EXISTS -> 8448L
        public const int ERROR_DS_DRA_REF_ALREADY_EXISTS = 8448;

        /// ERROR_DS_DRA_PREEMPTED -> 8461L
        public const int ERROR_DS_DRA_PREEMPTED = 8461;

        /// ERROR_DS_DRA_OUT_SCHEDULE_WINDOW -> 8617L
        public const int ERROR_DS_DRA_OUT_SCHEDULE_WINDOW = 8617;

        /// ERROR_DS_DRA_OUT_OF_MEM -> 8446L
        public const int ERROR_DS_DRA_OUT_OF_MEM = 8446;

        /// ERROR_DS_DRA_OBJ_NC_MISMATCH -> 8545L
        public const int ERROR_DS_DRA_OBJ_NC_MISMATCH = 8545;

        /// ERROR_DS_DRA_OBJ_IS_REP_SOURCE -> 8450L
        public const int ERROR_DS_DRA_OBJ_IS_REP_SOURCE = 8450;

        /// ERROR_DS_DRA_NO_REPLICA -> 8452L
        public const int ERROR_DS_DRA_NO_REPLICA = 8452;

        /// ERROR_DS_DRA_NOT_SUPPORTED -> 8454L
        public const int ERROR_DS_DRA_NOT_SUPPORTED = 8454;

        /// ERROR_DS_DRA_NAME_COLLISION -> 8458L
        public const int ERROR_DS_DRA_NAME_COLLISION = 8458;

        /// ERROR_DS_DRA_MISSING_PARENT -> 8460L
        public const int ERROR_DS_DRA_MISSING_PARENT = 8460;

        /// ERROR_DS_DRA_MAIL_PROBLEM -> 8447L
        public const int ERROR_DS_DRA_MAIL_PROBLEM = 8447;

        /// ERROR_DS_DRA_INVALID_PARAMETER -> 8437L
        public const int ERROR_DS_DRA_INVALID_PARAMETER = 8437;

        /// ERROR_DS_DRA_INTERNAL_ERROR -> 8442L
        public const int ERROR_DS_DRA_INTERNAL_ERROR = 8442;

        /// ERROR_DS_DRA_INCONSISTENT_DIT -> 8443L
        public const int ERROR_DS_DRA_INCONSISTENT_DIT = 8443;

        /// ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET -> 8464L
        public const int ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET = 8464;

        /// ERROR_DS_DRA_GENERIC -> 8436L
        public const int ERROR_DS_DRA_GENERIC = 8436;

        /// ERROR_DS_DRA_EXTN_CONNECTION_FAILED -> 8466L
        public const int ERROR_DS_DRA_EXTN_CONNECTION_FAILED = 8466;

        /// ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT -> 8544L
        public const int ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT = 8544;

        /// ERROR_DS_DRA_DN_EXISTS -> 8441L
        public const int ERROR_DS_DRA_DN_EXISTS = 8441;

        /// ERROR_DS_DRA_DB_ERROR -> 8451L
        public const int ERROR_DS_DRA_DB_ERROR = 8451;

        /// ERROR_DS_DRA_CONNECTION_FAILED -> 8444L
        public const int ERROR_DS_DRA_CONNECTION_FAILED = 8444;

        /// ERROR_DS_DRA_BUSY -> 8438L
        public const int ERROR_DS_DRA_BUSY = 8438;

        /// ERROR_DS_DRA_BAD_NC -> 8440L
        public const int ERROR_DS_DRA_BAD_NC = 8440;

        /// ERROR_DS_DRA_BAD_INSTANCE_TYPE -> 8445L
        public const int ERROR_DS_DRA_BAD_INSTANCE_TYPE = 8445;

        /// ERROR_DS_DRA_BAD_DN -> 8439L
        public const int ERROR_DS_DRA_BAD_DN = 8439;

        /// ERROR_DS_DRA_ACCESS_DENIED -> 8453L
        public const int ERROR_DS_DRA_ACCESS_DENIED = 8453;

        /// ERROR_DS_DRA_ABANDON_SYNC -> 8462L
        public const int ERROR_DS_DRA_ABANDON_SYNC = 8462;

        /// ERROR_DS_DOMAIN_VERSION_TOO_LOW -> 8566L
        public const int ERROR_DS_DOMAIN_VERSION_TOO_LOW = 8566;

        /// ERROR_DS_DOMAIN_VERSION_TOO_HIGH -> 8564L
        public const int ERROR_DS_DOMAIN_VERSION_TOO_HIGH = 8564;

        /// ERROR_DS_DOMAIN_RENAME_IN_PROGRESS -> 8612L
        public const int ERROR_DS_DOMAIN_RENAME_IN_PROGRESS = 8612;

        /// ERROR_DS_DNS_LOOKUP_FAILURE -> 8524L
        public const int ERROR_DS_DNS_LOOKUP_FAILURE = 8524;

        /// ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER -> 8615L
        public const int ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER = 8615;

        /// ERROR_DS_DIFFERENT_REPL_EPOCHS -> 8593L
        public const int ERROR_DS_DIFFERENT_REPL_EPOCHS = 8593;

        /// ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST -> 8535L
        public const int ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST = 8535;

        /// ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED -> 8536L
        public const int ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED = 8536;

        /// ERROR_DS_DECODING_ERROR -> 8253L
        public const int ERROR_DS_DECODING_ERROR = 8253;

        /// ERROR_DS_DATABASE_ERROR -> 8409L
        public const int ERROR_DS_DATABASE_ERROR = 8409;

        /// ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 -> 8586L
        public const int ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 = 8586;

        /// ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE -> 8495L
        public const int ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE = 8495;

        /// ERROR_DS_CROSS_REF_EXISTS -> 8374L
        public const int ERROR_DS_CROSS_REF_EXISTS = 8374;

        /// ERROR_DS_CROSS_REF_BUSY -> 8602L
        public const int ERROR_DS_CROSS_REF_BUSY = 8602;

        /// ERROR_DS_CROSS_NC_DN_RENAME -> 8368L
        public const int ERROR_DS_CROSS_NC_DN_RENAME = 8368;

        /// ERROR_DS_CROSS_DOM_MOVE_ERROR -> 8216L
        public const int ERROR_DS_CROSS_DOM_MOVE_ERROR = 8216;

        /// ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD -> 8491L
        public const int ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD = 8491;

        /// ERROR_DS_COUNTING_AB_INDICES_FAILED -> 8428L
        public const int ERROR_DS_COUNTING_AB_INDICES_FAILED = 8428;

        /// ERROR_DS_COULDNT_UPDATE_SPNS -> 8525L
        public const int ERROR_DS_COULDNT_UPDATE_SPNS = 8525;

        /// ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE -> 8502L
        public const int ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE = 8502;

        /// ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE -> 8503L
        public const int ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE = 8503;

        /// ERROR_DS_COULDNT_CONTACT_FSMO -> 8367L
        public const int ERROR_DS_COULDNT_CONTACT_FSMO = 8367;

        /// ERROR_DS_CONTROL_NOT_FOUND -> 8258L
        public const int ERROR_DS_CONTROL_NOT_FOUND = 8258;

        /// ERROR_DS_CONSTRUCTED_ATT_MOD -> 8475L
        public const int ERROR_DS_CONSTRUCTED_ATT_MOD = 8475;

        /// ERROR_DS_CONSTRAINT_VIOLATION -> 8239L
        public const int ERROR_DS_CONSTRAINT_VIOLATION = 8239;

        /// ERROR_DS_CONFIG_PARAM_MISSING -> 8427L
        public const int ERROR_DS_CONFIG_PARAM_MISSING = 8427;

        /// ERROR_DS_CONFIDENTIALITY_REQUIRED -> 8237L
        public const int ERROR_DS_CONFIDENTIALITY_REQUIRED = 8237;

        /// ERROR_DS_COMPARE_TRUE -> 8230L
        public const int ERROR_DS_COMPARE_TRUE = 8230;

        /// ERROR_DS_COMPARE_FALSE -> 8229L
        public const int ERROR_DS_COMPARE_FALSE = 8229;

        /// ERROR_DS_CODE_INCONSISTENCY -> 8408L
        public const int ERROR_DS_CODE_INCONSISTENCY = 8408;

        /// ERROR_DS_CLIENT_LOOP -> 8259L
        public const int ERROR_DS_CLIENT_LOOP = 8259;

        /// ERROR_DS_CLASS_NOT_DSA -> 8343L
        public const int ERROR_DS_CLASS_NOT_DSA = 8343;

        /// ERROR_DS_CLASS_MUST_BE_CONCRETE -> 8359L
        public const int ERROR_DS_CLASS_MUST_BE_CONCRETE = 8359;

        /// ERROR_DS_CHILDREN_EXIST -> 8332L
        public const int ERROR_DS_CHILDREN_EXIST = 8332;

        /// ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS -> 8493L
        public const int ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS = 8493;

        /// ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ -> 8560L
        public const int ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ = 8560;

        /// ERROR_DS_CANT_START -> 8531L
        public const int ERROR_DS_CANT_START = 8531;

        /// ERROR_DS_CANT_RETRIEVE_SD -> 8526L
        public const int ERROR_DS_CANT_RETRIEVE_SD = 8526;

        /// ERROR_DS_CANT_RETRIEVE_INSTANCE -> 8407L
        public const int ERROR_DS_CANT_RETRIEVE_INSTANCE = 8407;

        /// ERROR_DS_CANT_RETRIEVE_DN -> 8405L
        public const int ERROR_DS_CANT_RETRIEVE_DN = 8405;

        /// ERROR_DS_CANT_RETRIEVE_CHILD -> 8422L
        public const int ERROR_DS_CANT_RETRIEVE_CHILD = 8422;

        /// ERROR_DS_CANT_RETRIEVE_ATTS -> 8481L
        public const int ERROR_DS_CANT_RETRIEVE_ATTS = 8481;

        /// ERROR_DS_CANT_REPLACE_HIDDEN_REC -> 8424L
        public const int ERROR_DS_CANT_REPLACE_HIDDEN_REC = 8424;

        /// ERROR_DS_CANT_REM_MISSING_ATT_VAL -> 8325L
        public const int ERROR_DS_CANT_REM_MISSING_ATT_VAL = 8325;

        /// ERROR_DS_CANT_REM_MISSING_ATT -> 8324L
        public const int ERROR_DS_CANT_REM_MISSING_ATT = 8324;

        /// ERROR_DS_CANT_REMOVE_CLASS_CACHE -> 8404L
        public const int ERROR_DS_CANT_REMOVE_CLASS_CACHE = 8404;

        /// ERROR_DS_CANT_REMOVE_ATT_CACHE -> 8403L
        public const int ERROR_DS_CANT_REMOVE_ATT_CACHE = 8403;

        /// ERROR_DS_CANT_ON_RDN -> 8214L
        public const int ERROR_DS_CANT_ON_RDN = 8214;

        /// ERROR_DS_CANT_ON_NON_LEAF -> 8213L
        public const int ERROR_DS_CANT_ON_NON_LEAF = 8213;

        /// ERROR_DS_CANT_MOVE_RESOURCE_GROUP -> 8499L
        public const int ERROR_DS_CANT_MOVE_RESOURCE_GROUP = 8499;

        /// ERROR_DS_CANT_MOVE_DELETED_OBJECT -> 8489L
        public const int ERROR_DS_CANT_MOVE_DELETED_OBJECT = 8489;

        /// ERROR_DS_CANT_MOVE_APP_QUERY_GROUP -> 8609L
        public const int ERROR_DS_CANT_MOVE_APP_QUERY_GROUP = 8609;

        /// ERROR_DS_CANT_MOVE_APP_BASIC_GROUP -> 8608L
        public const int ERROR_DS_CANT_MOVE_APP_BASIC_GROUP = 8608;

        /// ERROR_DS_CANT_MOVE_ACCOUNT_GROUP -> 8498L
        public const int ERROR_DS_CANT_MOVE_ACCOUNT_GROUP = 8498;

        /// ERROR_DS_CANT_MOD_SYSTEM_ONLY -> 8369L
        public const int ERROR_DS_CANT_MOD_SYSTEM_ONLY = 8369;

        /// ERROR_DS_CANT_MOD_PRIMARYGROUPID -> 8506L
        public const int ERROR_DS_CANT_MOD_PRIMARYGROUPID = 8506;

        /// ERROR_DS_CANT_MOD_OBJ_CLASS -> 8215L
        public const int ERROR_DS_CANT_MOD_OBJ_CLASS = 8215;

        /// ERROR_DS_CANT_MIX_MASTER_AND_REPS -> 8331L
        public const int ERROR_DS_CANT_MIX_MASTER_AND_REPS = 8331;

        /// ERROR_DS_CANT_FIND_NC_IN_CACHE -> 8421L
        public const int ERROR_DS_CANT_FIND_NC_IN_CACHE = 8421;

        /// ERROR_DS_CANT_FIND_EXPECTED_NC -> 8420L
        public const int ERROR_DS_CANT_FIND_EXPECTED_NC = 8420;

        /// ERROR_DS_CANT_FIND_DSA_OBJ -> 8419L
        public const int ERROR_DS_CANT_FIND_DSA_OBJ = 8419;

        /// ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN -> 8537L
        public const int ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN = 8537;

        /// ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF -> 8589L
        public const int ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF = 8589;

        /// ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN -> 8603L
        public const int ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN = 8603;

        /// ERROR_DS_CANT_DEREF_ALIAS -> 8337L
        public const int ERROR_DS_CANT_DEREF_ALIAS = 8337;

        /// ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC -> 8604L
        public const int ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC = 8604;

        /// ERROR_DS_CANT_DEL_MASTER_CROSSREF -> 8375L
        public const int ERROR_DS_CANT_DEL_MASTER_CROSSREF = 8375;

        /// ERROR_DS_CANT_DELETE_DSA_OBJ -> 8340L
        public const int ERROR_DS_CANT_DELETE_DSA_OBJ = 8340;

        /// ERROR_DS_CANT_DELETE -> 8398L
        public const int ERROR_DS_CANT_DELETE = 8398;

        /// ERROR_DS_CANT_CREATE_UNDER_SCHEMA -> 8510L
        public const int ERROR_DS_CANT_CREATE_UNDER_SCHEMA = 8510;

        /// ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC -> 8553L
        public const int ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC = 8553;

        /// ERROR_DS_CANT_CACHE_CLASS -> 8402L
        public const int ERROR_DS_CANT_CACHE_CLASS = 8402;

        /// ERROR_DS_CANT_CACHE_ATT -> 8401L
        public const int ERROR_DS_CANT_CACHE_ATT = 8401;

        /// ERROR_DS_CANT_ADD_TO_GC -> 8550L
        public const int ERROR_DS_CANT_ADD_TO_GC = 8550;

        /// ERROR_DS_CANT_ADD_SYSTEM_ONLY -> 8358L
        public const int ERROR_DS_CANT_ADD_SYSTEM_ONLY = 8358;

        /// ERROR_DS_CANT_ADD_ATT_VALUES -> 8320L
        public const int ERROR_DS_CANT_ADD_ATT_VALUES = 8320;

        /// ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD -> 8585L
        public const int ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD = 8585;

        /// ERROR_DS_BUSY -> 8206L
        public const int ERROR_DS_BUSY = 8206;

        /// ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED -> 8426L
        public const int ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED = 8426;

        /// ERROR_DS_BAD_RDN_ATT_ID_SYNTAX -> 8392L
        public const int ERROR_DS_BAD_RDN_ATT_ID_SYNTAX = 8392;

        /// ERROR_DS_BAD_NAME_SYNTAX -> 8335L
        public const int ERROR_DS_BAD_NAME_SYNTAX = 8335;

        /// ERROR_DS_BAD_INSTANCE_TYPE -> 8313L
        public const int ERROR_DS_BAD_INSTANCE_TYPE = 8313;

        /// ERROR_DS_BAD_HIERARCHY_FILE -> 8425L
        public const int ERROR_DS_BAD_HIERARCHY_FILE = 8425;

        /// ERROR_DS_BAD_ATT_SCHEMA_SYNTAX -> 8400L
        public const int ERROR_DS_BAD_ATT_SCHEMA_SYNTAX = 8400;

        /// ERROR_DS_BACKLINK_WITHOUT_LINK -> 8482L
        public const int ERROR_DS_BACKLINK_WITHOUT_LINK = 8482;

        /// ERROR_DS_AUX_CLS_TEST_FAIL -> 8389L
        public const int ERROR_DS_AUX_CLS_TEST_FAIL = 8389;

        /// ERROR_DS_AUTH_UNKNOWN -> 8234L
        public const int ERROR_DS_AUTH_UNKNOWN = 8234;

        /// ERROR_DS_AUTH_METHOD_NOT_SUPPORTED -> 8231L
        public const int ERROR_DS_AUTH_METHOD_NOT_SUPPORTED = 8231;

        /// ERROR_DS_AUTHORIZATION_FAILED -> 8599L
        public const int ERROR_DS_AUTHORIZATION_FAILED = 8599;

        /// ERROR_DS_ATT_VAL_ALREADY_EXISTS -> 8323L
        public const int ERROR_DS_ATT_VAL_ALREADY_EXISTS = 8323;

        /// ERROR_DS_ATT_SCHEMA_REQ_SYNTAX -> 8416L
        public const int ERROR_DS_ATT_SCHEMA_REQ_SYNTAX = 8416;

        /// ERROR_DS_ATT_SCHEMA_REQ_ID -> 8399L
        public const int ERROR_DS_ATT_SCHEMA_REQ_ID = 8399;

        /// ERROR_DS_ATT_NOT_DEF_IN_SCHEMA -> 8303L
        public const int ERROR_DS_ATT_NOT_DEF_IN_SCHEMA = 8303;

        /// ERROR_DS_ATT_NOT_DEF_FOR_CLASS -> 8317L
        public const int ERROR_DS_ATT_NOT_DEF_FOR_CLASS = 8317;

        /// ERROR_DS_ATT_IS_NOT_ON_OBJ -> 8310L
        public const int ERROR_DS_ATT_IS_NOT_ON_OBJ = 8310;

        /// ERROR_DS_ATT_ALREADY_EXISTS -> 8318L
        public const int ERROR_DS_ATT_ALREADY_EXISTS = 8318;

        /// ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED -> 8204L
        public const int ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED = 8204;

        /// ERROR_DS_ATTRIBUTE_OWNED_BY_SAM -> 8346L
        public const int ERROR_DS_ATTRIBUTE_OWNED_BY_SAM = 8346;

        /// ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS -> 8205L
        public const int ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS = 8205;

        /// ERROR_DS_ALIAS_PROBLEM -> 8241L
        public const int ERROR_DS_ALIAS_PROBLEM = 8241;

        /// ERROR_DS_ALIAS_POINTS_TO_ALIAS -> 8336L
        public const int ERROR_DS_ALIAS_POINTS_TO_ALIAS = 8336;

        /// ERROR_DS_ALIAS_DEREF_PROBLEM -> 8244L
        public const int ERROR_DS_ALIAS_DEREF_PROBLEM = 8244;

        /// ERROR_DS_ALIASED_OBJ_MISSING -> 8334L
        public const int ERROR_DS_ALIASED_OBJ_MISSING = 8334;

        /// ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER -> 8578L
        public const int ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 8578;

        /// ERROR_DS_AFFECTS_MULTIPLE_DSAS -> 8249L
        public const int ERROR_DS_AFFECTS_MULTIPLE_DSAS = 8249;

        /// ERROR_DS_ADMIN_LIMIT_EXCEEDED -> 8228L
        public const int ERROR_DS_ADMIN_LIMIT_EXCEEDED = 8228;

        /// ERROR_DS_ADD_REPLICA_INHIBITED -> 8302L
        public const int ERROR_DS_ADD_REPLICA_INHIBITED = 8302;

        /// ERROR_DRIVE_NOT_INSTALLED -> 0x00000008
        public const int ERROR_DRIVE_NOT_INSTALLED = 8;

        /// ERROR_DRIVE_MEDIA_MISMATCH -> 4303L
        public const int ERROR_DRIVE_MEDIA_MISMATCH = 4303;

        /// ERROR_DRIVE_LOCKED -> 108L
        public const int ERROR_DRIVE_LOCKED = 108;

        /// ERROR_DRIVER_BLOCKED -> 1275L
        public const int ERROR_DRIVER_BLOCKED = 1275;

        /// ERROR_DOWNGRADE_DETECTED -> 1265L
        public const int ERROR_DOWNGRADE_DETECTED = 1265;

        /// ERROR_DOMAIN_TRUST_INCONSISTENT -> 1810L
        public const int ERROR_DOMAIN_TRUST_INCONSISTENT = 1810;

        /// ERROR_DOMAIN_LIMIT_EXCEEDED -> 1357L
        public const int ERROR_DOMAIN_LIMIT_EXCEEDED = 1357;

        /// ERROR_DOMAIN_EXISTS -> 1356L
        public const int ERROR_DOMAIN_EXISTS = 1356;

        /// ERROR_DOMAIN_CONTROLLER_NOT_FOUND -> 1908L
        public const int ERROR_DOMAIN_CONTROLLER_NOT_FOUND = 1908;

        /// ERROR_DOMAIN_CONTROLLER_EXISTS -> 1250L
        public const int ERROR_DOMAIN_CONTROLLER_EXISTS = 1250;

        /// ERROR_DLL_NOT_FOUND -> 1157L
        public const int ERROR_DLL_NOT_FOUND = 1157;

        /// ERROR_DLL_INIT_FAILED -> 1114L
        public const int ERROR_DLL_INIT_FAILED = 1114;

        /// ERROR_DISK_TOO_FRAGMENTED -> 302L
        public const int ERROR_DISK_TOO_FRAGMENTED = 302;

        /// ERROR_DISK_RESET_FAILED -> 1128L
        public const int ERROR_DISK_RESET_FAILED = 1128;

        /// ERROR_DISK_RECALIBRATE_FAILED -> 1126L
        public const int ERROR_DISK_RECALIBRATE_FAILED = 1126;

        /// ERROR_DISK_OPERATION_FAILED -> 1127L
        public const int ERROR_DISK_OPERATION_FAILED = 1127;

        /// ERROR_DISK_FULL -> 112L
        public const int ERROR_DISK_FULL = 112;

        /// ERROR_DISK_CORRUPT -> 1393L
        public const int ERROR_DISK_CORRUPT = 1393;

        /// ERROR_DISK_CHANGE -> 107L
        public const int ERROR_DISK_CHANGE = 107;

        /// ERROR_DISCARDED -> 157L
        public const int ERROR_DISCARDED = 157;

        /// ERROR_DIR_NOT_ROOT -> 144L
        public const int ERROR_DIR_NOT_ROOT = 144;

        /// ERROR_DIR_NOT_EMPTY -> 145L
        public const int ERROR_DIR_NOT_EMPTY = 145;

        /// ERROR_DIR_EFS_DISALLOWED -> 6010L
        public const int ERROR_DIR_EFS_DISALLOWED = 6010;

        /// ERROR_DIRECT_ACCESS_HANDLE -> 130L
        public const int ERROR_DIRECT_ACCESS_HANDLE = 130;

        /// ERROR_DIRECTORY -> 267L
        public const int ERROR_DIRECTORY = 267;

        /// ERROR_DIFFERENT_SERVICE_ACCOUNT -> 1079L
        public const int ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079;

        /// ERROR_DHCP_ADDRESS_CONFLICT -> 4100L
        public const int ERROR_DHCP_ADDRESS_CONFLICT = 4100;

        /// ERROR_DEV_NOT_EXIST -> 55L
        public const int ERROR_DEV_NOT_EXIST = 55;

        /// ERROR_DEVICE_REQUIRES_CLEANING -> 1165L
        public const int ERROR_DEVICE_REQUIRES_CLEANING = 1165;

        /// ERROR_DEVICE_REMOVED -> 1617L
        public const int ERROR_DEVICE_REMOVED = 1617;

        /// ERROR_DEVICE_REINITIALIZATION_NEEDED -> 1164L
        public const int ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164;

        /// ERROR_DEVICE_NOT_PARTITIONED -> 1107L
        public const int ERROR_DEVICE_NOT_PARTITIONED = 1107;

        /// ERROR_DEVICE_NOT_CONNECTED -> 1167L
        public const int ERROR_DEVICE_NOT_CONNECTED = 1167;

        /// ERROR_DEVICE_NOT_AVAILABLE -> 4319L
        public const int ERROR_DEVICE_NOT_AVAILABLE = 4319;

        /// ERROR_DEVICE_IN_USE -> 2404L
        public const int ERROR_DEVICE_IN_USE = 2404;

        /// ERROR_DEVICE_DOOR_OPEN -> 1166L
        public const int ERROR_DEVICE_DOOR_OPEN = 1166;

        /// ERROR_DEVICE_ALREADY_REMEMBERED -> 1202L
        public const int ERROR_DEVICE_ALREADY_REMEMBERED = 1202;

        /// ERROR_DESTROY_OBJECT_OF_OTHER_THREAD -> 1435L
        public const int ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435;

        /// ERROR_DESTINATION_ELEMENT_FULL -> 1161L
        public const int ERROR_DESTINATION_ELEMENT_FULL = 1161;

        /// ERROR_DEPENDENT_SERVICES_RUNNING -> 1051L
        public const int ERROR_DEPENDENT_SERVICES_RUNNING = 1051;

        /// ERROR_DEPENDENT_RESOURCE_EXISTS -> 5001L
        public const int ERROR_DEPENDENT_RESOURCE_EXISTS = 5001;

        /// ERROR_DEPENDENCY_NOT_FOUND -> 5002L
        public const int ERROR_DEPENDENCY_NOT_FOUND = 5002;

        /// ERROR_DEPENDENCY_NOT_ALLOWED -> 5069L
        public const int ERROR_DEPENDENCY_NOT_ALLOWED = 5069;

        /// ERROR_DEPENDENCY_ALREADY_EXISTS -> 5003L
        public const int ERROR_DEPENDENCY_ALREADY_EXISTS = 5003;

        /// ERROR_DELETING_ICM_XFORM -> 2019L
        public const int ERROR_DELETING_ICM_XFORM = 2019;

        /// ERROR_DELETE_PENDING -> 303L
        public const int ERROR_DELETE_PENDING = 303;

        /// ERROR_DELAY_LOAD_FAILED -> 1285L
        public const int ERROR_DELAY_LOAD_FAILED = 1285;

        /// ERROR_DECRYPTION_FAILED -> 6001L
        public const int ERROR_DECRYPTION_FAILED = 6001;

        /// ERROR_DEBUGGER_INACTIVE -> 1284L
        public const int ERROR_DEBUGGER_INACTIVE = 1284;

        /// ERROR_DDE_FAIL -> 1156L
        public const int ERROR_DDE_FAIL = 1156;

        /// ERROR_DC_NOT_FOUND -> 1425L
        public const int ERROR_DC_NOT_FOUND = 1425;

        /// ERROR_DATATYPE_MISMATCH -> 1629L
        public const int ERROR_DATATYPE_MISMATCH = 1629;

        /// ERROR_DATABASE_FULL -> 4314L
        public const int ERROR_DATABASE_FULL = 4314;

        /// ERROR_DATABASE_FAILURE -> 4313L
        public const int ERROR_DATABASE_FAILURE = 4313;

        /// ERROR_DATABASE_DOES_NOT_EXIST -> 1065L
        public const int ERROR_DATABASE_DOES_NOT_EXIST = 1065;

        /// ERROR_DATABASE_BACKUP_CORRUPT -> 5087L
        public const int ERROR_DATABASE_BACKUP_CORRUPT = 5087;

        /// ERROR_CURRENT_DOMAIN_NOT_ALLOWED -> 1399L
        public const int ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399;

        /// ERROR_CURRENT_DIRECTORY -> 16L
        public const int ERROR_CURRENT_DIRECTORY = 16;

        /// ERROR_CTX_WINSTATION_NOT_FOUND -> 7022L
        public const int ERROR_CTX_WINSTATION_NOT_FOUND = 7022;

        /// ERROR_CTX_WINSTATION_NAME_INVALID -> 7001L
        public const int ERROR_CTX_WINSTATION_NAME_INVALID = 7001;

        /// ERROR_CTX_WINSTATION_BUSY -> 7024L
        public const int ERROR_CTX_WINSTATION_BUSY = 7024;

        /// ERROR_CTX_WINSTATION_ALREADY_EXISTS -> 7023L
        public const int ERROR_CTX_WINSTATION_ALREADY_EXISTS = 7023;

        /// ERROR_CTX_WINSTATION_ACCESS_DENIED -> 7045L
        public const int ERROR_CTX_WINSTATION_ACCESS_DENIED = 7045;

        /// ERROR_CTX_WD_NOT_FOUND -> 7004L
        public const int ERROR_CTX_WD_NOT_FOUND = 7004;

        /// ERROR_CTX_TD_ERROR -> 7017L
        public const int ERROR_CTX_TD_ERROR = 7017;

        /// ERROR_CTX_SHADOW_NOT_RUNNING -> 7057L
        public const int ERROR_CTX_SHADOW_NOT_RUNNING = 7057;

        /// ERROR_CTX_SHADOW_INVALID -> 7050L
        public const int ERROR_CTX_SHADOW_INVALID = 7050;

        /// ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE -> 7058L
        public const int ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 7058;

        /// ERROR_CTX_SHADOW_DISABLED -> 7051L
        public const int ERROR_CTX_SHADOW_DISABLED = 7051;

        /// ERROR_CTX_SHADOW_DENIED -> 7044L
        public const int ERROR_CTX_SHADOW_DENIED = 7044;

        /// ERROR_CTX_SERVICE_NAME_COLLISION -> 7006L
        public const int ERROR_CTX_SERVICE_NAME_COLLISION = 7006;

        /// ERROR_CTX_PD_NOT_FOUND -> 7003L
        public const int ERROR_CTX_PD_NOT_FOUND = 7003;

        /// ERROR_CTX_NO_OUTBUF -> 7008L
        public const int ERROR_CTX_NO_OUTBUF = 7008;

        /// ERROR_CTX_NOT_CONSOLE -> 7038L
        public const int ERROR_CTX_NOT_CONSOLE = 7038;

        /// ERROR_CTX_MODEM_RESPONSE_VOICE -> 7016L
        public const int ERROR_CTX_MODEM_RESPONSE_VOICE = 7016;

        /// ERROR_CTX_MODEM_RESPONSE_TIMEOUT -> 7012L
        public const int ERROR_CTX_MODEM_RESPONSE_TIMEOUT = 7012;

        /// ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE -> 7014L
        public const int ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE = 7014;

        /// ERROR_CTX_MODEM_RESPONSE_NO_CARRIER -> 7013L
        public const int ERROR_CTX_MODEM_RESPONSE_NO_CARRIER = 7013;

        /// ERROR_CTX_MODEM_RESPONSE_ERROR -> 7011L
        public const int ERROR_CTX_MODEM_RESPONSE_ERROR = 7011;

        /// ERROR_CTX_MODEM_RESPONSE_BUSY -> 7015L
        public const int ERROR_CTX_MODEM_RESPONSE_BUSY = 7015;

        /// ERROR_CTX_MODEM_INF_NOT_FOUND -> 7009L
        public const int ERROR_CTX_MODEM_INF_NOT_FOUND = 7009;

        /// ERROR_CTX_LOGON_DISABLED -> 7037L
        public const int ERROR_CTX_LOGON_DISABLED = 7037;

        /// ERROR_CTX_LICENSE_NOT_AVAILABLE -> 7054L
        public const int ERROR_CTX_LICENSE_NOT_AVAILABLE = 7054;

        /// ERROR_CTX_LICENSE_EXPIRED -> 7056L
        public const int ERROR_CTX_LICENSE_EXPIRED = 7056;

        /// ERROR_CTX_LICENSE_CLIENT_INVALID -> 7055L
        public const int ERROR_CTX_LICENSE_CLIENT_INVALID = 7055;

        /// ERROR_CTX_INVALID_WD -> 7049L
        public const int ERROR_CTX_INVALID_WD = 7049;

        /// ERROR_CTX_INVALID_PD -> 7002L
        public const int ERROR_CTX_INVALID_PD = 7002;

        /// ERROR_CTX_INVALID_MODEMNAME -> 7010L
        public const int ERROR_CTX_INVALID_MODEMNAME = 7010;

        /// ERROR_CTX_GRAPHICS_INVALID -> 7035L
        public const int ERROR_CTX_GRAPHICS_INVALID = 7035;

        /// ERROR_CTX_CONSOLE_DISCONNECT -> 7041L
        public const int ERROR_CTX_CONSOLE_DISCONNECT = 7041;

        /// ERROR_CTX_CONSOLE_CONNECT -> 7042L
        public const int ERROR_CTX_CONSOLE_CONNECT = 7042;

        /// ERROR_CTX_CLOSE_PENDING -> 7007L
        public const int ERROR_CTX_CLOSE_PENDING = 7007;

        /// ERROR_CTX_CLIENT_QUERY_TIMEOUT -> 7040L
        public const int ERROR_CTX_CLIENT_QUERY_TIMEOUT = 7040;

        /// ERROR_CTX_CLIENT_LICENSE_NOT_SET -> 7053L
        public const int ERROR_CTX_CLIENT_LICENSE_NOT_SET = 7053;

        /// ERROR_CTX_CLIENT_LICENSE_IN_USE -> 7052L
        public const int ERROR_CTX_CLIENT_LICENSE_IN_USE = 7052;

        /// ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY -> 7005L
        public const int ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY = 7005;

        /// ERROR_CTX_BAD_VIDEO_MODE -> 7025L
        public const int ERROR_CTX_BAD_VIDEO_MODE = 7025;

        /// ERROR_CSCSHARE_OFFLINE -> 1262L
        public const int ERROR_CSCSHARE_OFFLINE = 1262;

        /// ERROR_CREATE_FAILED -> 1631L
        public const int ERROR_CREATE_FAILED = 1631;

        /// ERROR_CRC -> 23L
        public const int ERROR_CRC = 23;

        /// ERROR_COUNTER_TIMEOUT -> 1121L
        public const int ERROR_COUNTER_TIMEOUT = 1121;

        /// ERROR_CORE_RESOURCE -> 5026L
        public const int ERROR_CORE_RESOURCE = 5026;

        /// ERROR_CONTROL_ID_NOT_FOUND -> 1421L
        public const int ERROR_CONTROL_ID_NOT_FOUND = 1421;

        /// ERROR_CONTROLLING_IEPORT -> 4329L
        public const int ERROR_CONTROLLING_IEPORT = 4329;

        /// ERROR_CONTINUE -> 1246L
        public const int ERROR_CONTINUE = 1246;

        /// ERROR_CONTEXT_EXPIRED -> 1931L
        public const int ERROR_CONTEXT_EXPIRED = 1931;

        /// ERROR_CONNECTION_UNAVAIL -> 1201L
        public const int ERROR_CONNECTION_UNAVAIL = 1201;

        /// ERROR_CONNECTION_REFUSED -> 1225L
        public const int ERROR_CONNECTION_REFUSED = 1225;

        /// ERROR_CONNECTION_INVALID -> 1229L
        public const int ERROR_CONNECTION_INVALID = 1229;

        /// ERROR_CONNECTION_COUNT_LIMIT -> 1238L
        public const int ERROR_CONNECTION_COUNT_LIMIT = 1238;

        /// ERROR_CONNECTION_ACTIVE -> 1230L
        public const int ERROR_CONNECTION_ACTIVE = 1230;

        /// ERROR_CONNECTION_ABORTED -> 1236L
        public const int ERROR_CONNECTION_ABORTED = 1236;

        /// ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT -> 2109L
        public const int ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109;

        /// ERROR_CONNECTED_OTHER_PASSWORD -> 2108L
        public const int ERROR_CONNECTED_OTHER_PASSWORD = 2108;

        /// ERROR_COMMITMENT_LIMIT -> 1455L
        public const int ERROR_COMMITMENT_LIMIT = 1455;

        /// ERROR_COLORSPACE_MISMATCH -> 2021L
        public const int ERROR_COLORSPACE_MISMATCH = 2021;

        /// ERROR_CLUSTER_WRONG_OS_VERSION -> 5899L
        public const int ERROR_CLUSTER_WRONG_OS_VERSION = 5899;

        /// ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED -> 5077L
        public const int ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED = 5077;

        /// ERROR_CLUSTER_SHUTTING_DOWN -> 5022L
        public const int ERROR_CLUSTER_SHUTTING_DOWN = 5022;

        /// ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED -> 5079L
        public const int ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED = 5079;

        /// ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND -> 5078L
        public const int ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND = 5078;

        /// ERROR_CLUSTER_RESNAME_NOT_FOUND -> 5080L
        public const int ERROR_CLUSTER_RESNAME_NOT_FOUND = 5080;

        /// ERROR_CLUSTER_QUORUMLOG_NOT_FOUND -> 5891L
        public const int ERROR_CLUSTER_QUORUMLOG_NOT_FOUND = 5891;

        /// ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH -> 5895L
        public const int ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH = 5895;

        /// ERROR_CLUSTER_PARAMETER_MISMATCH -> 5897L
        public const int ERROR_CLUSTER_PARAMETER_MISMATCH = 5897;

        /// ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST -> 5082L
        public const int ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST = 5082;

        /// ERROR_CLUSTER_OLD_VERSION -> 5904L
        public const int ERROR_CLUSTER_OLD_VERSION = 5904;

        /// ERROR_CLUSTER_NO_SECURITY_CONTEXT -> 5059L
        public const int ERROR_CLUSTER_NO_SECURITY_CONTEXT = 5059;

        /// ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED -> 5081L
        public const int ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED = 5081;

        /// ERROR_CLUSTER_NODE_UP -> 5056L
        public const int ERROR_CLUSTER_NODE_UP = 5056;

        /// ERROR_CLUSTER_NODE_UNREACHABLE -> 5051L
        public const int ERROR_CLUSTER_NODE_UNREACHABLE = 5051;

        /// ERROR_CLUSTER_NODE_SHUTTING_DOWN -> 5073L
        public const int ERROR_CLUSTER_NODE_SHUTTING_DOWN = 5073;

        /// ERROR_CLUSTER_NODE_PAUSED -> 5070L
        public const int ERROR_CLUSTER_NODE_PAUSED = 5070;

        /// ERROR_CLUSTER_NODE_NOT_READY -> 5072L
        public const int ERROR_CLUSTER_NODE_NOT_READY = 5072;

        /// ERROR_CLUSTER_NODE_NOT_PAUSED -> 5058L
        public const int ERROR_CLUSTER_NODE_NOT_PAUSED = 5058;

        /// ERROR_CLUSTER_NODE_NOT_MEMBER -> 5052L
        public const int ERROR_CLUSTER_NODE_NOT_MEMBER = 5052;

        /// ERROR_CLUSTER_NODE_NOT_FOUND -> 5042L
        public const int ERROR_CLUSTER_NODE_NOT_FOUND = 5042;

        /// ERROR_CLUSTER_NODE_EXISTS -> 5040L
        public const int ERROR_CLUSTER_NODE_EXISTS = 5040;

        /// ERROR_CLUSTER_NODE_DOWN -> 5050L
        public const int ERROR_CLUSTER_NODE_DOWN = 5050;

        /// ERROR_CLUSTER_NODE_ALREADY_UP -> 5061L
        public const int ERROR_CLUSTER_NODE_ALREADY_UP = 5061;

        /// ERROR_CLUSTER_NODE_ALREADY_MEMBER -> 5065L
        public const int ERROR_CLUSTER_NODE_ALREADY_MEMBER = 5065;

        /// ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT -> 5088L
        public const int ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT = 5088;

        /// ERROR_CLUSTER_NODE_ALREADY_DOWN -> 5062L
        public const int ERROR_CLUSTER_NODE_ALREADY_DOWN = 5062;

        /// ERROR_CLUSTER_NETWORK_NOT_INTERNAL -> 5060L
        public const int ERROR_CLUSTER_NETWORK_NOT_INTERNAL = 5060;

        /// ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP -> 5894L
        public const int ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP = 5894;

        /// ERROR_CLUSTER_NETWORK_NOT_FOUND -> 5045L
        public const int ERROR_CLUSTER_NETWORK_NOT_FOUND = 5045;

        /// ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS -> 5067L
        public const int ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS = 5067;

        /// ERROR_CLUSTER_NETWORK_EXISTS -> 5044L
        public const int ERROR_CLUSTER_NETWORK_EXISTS = 5044;

        /// ERROR_CLUSTER_NETWORK_ALREADY_ONLINE -> 5063L
        public const int ERROR_CLUSTER_NETWORK_ALREADY_ONLINE = 5063;

        /// ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE -> 5064L
        public const int ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE = 5064;

        /// ERROR_CLUSTER_NETINTERFACE_NOT_FOUND -> 5047L
        public const int ERROR_CLUSTER_NETINTERFACE_NOT_FOUND = 5047;

        /// ERROR_CLUSTER_NETINTERFACE_EXISTS -> 5046L
        public const int ERROR_CLUSTER_NETINTERFACE_EXISTS = 5046;

        /// ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME -> 5905L
        public const int ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME = 5905;

        /// ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE -> 5890L
        public const int ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE = 5890;

        /// ERROR_CLUSTER_MEMBERSHIP_HALT -> 5892L
        public const int ERROR_CLUSTER_MEMBERSHIP_HALT = 5892;

        /// ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED -> 5076L
        public const int ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED = 5076;

        /// ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND -> 5043L
        public const int ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND = 5043;

        /// ERROR_CLUSTER_LAST_INTERNAL_NETWORK -> 5066L
        public const int ERROR_CLUSTER_LAST_INTERNAL_NETWORK = 5066;

        /// ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS -> 5053L
        public const int ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS = 5053;

        /// ERROR_CLUSTER_JOIN_IN_PROGRESS -> 5041L
        public const int ERROR_CLUSTER_JOIN_IN_PROGRESS = 5041;

        /// ERROR_CLUSTER_JOIN_ABORTED -> 5074L
        public const int ERROR_CLUSTER_JOIN_ABORTED = 5074;

        /// ERROR_CLUSTER_IPADDR_IN_USE -> 5057L
        public const int ERROR_CLUSTER_IPADDR_IN_USE = 5057;

        /// ERROR_CLUSTER_INVALID_REQUEST -> 5048L
        public const int ERROR_CLUSTER_INVALID_REQUEST = 5048;

        /// ERROR_CLUSTER_INVALID_NODE -> 5039L
        public const int ERROR_CLUSTER_INVALID_NODE = 5039;

        /// ERROR_CLUSTER_INVALID_NETWORK_PROVIDER -> 5049L
        public const int ERROR_CLUSTER_INVALID_NETWORK_PROVIDER = 5049;

        /// ERROR_CLUSTER_INVALID_NETWORK -> 5054L
        public const int ERROR_CLUSTER_INVALID_NETWORK = 5054;

        /// ERROR_CLUSTER_INSTANCE_ID_MISMATCH -> 5893L
        public const int ERROR_CLUSTER_INSTANCE_ID_MISMATCH = 5893;

        /// ERROR_CLUSTER_INCOMPATIBLE_VERSIONS -> 5075L
        public const int ERROR_CLUSTER_INCOMPATIBLE_VERSIONS = 5075;

        /// ERROR_CLUSTER_GUM_NOT_LOCKER -> 5085L
        public const int ERROR_CLUSTER_GUM_NOT_LOCKER = 5085;

        /// ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP -> 5896L
        public const int ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP = 5896;

        /// ERROR_CLUSTER_DATABASE_SEQMISMATCH -> 5083L
        public const int ERROR_CLUSTER_DATABASE_SEQMISMATCH = 5083;

        /// ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME -> 5900L
        public const int ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME = 5900;

        /// ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE -> 5030L
        public const int ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE = 5030;

        /// ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE -> 5033L
        public const int ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE = 5033;

        /// ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE -> 5031L
        public const int ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE = 5031;

        /// ERROR_CLUSTERLOG_CORRUPT -> 5029L
        public const int ERROR_CLUSTERLOG_CORRUPT = 5029;

        /// ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND -> 5032L
        public const int ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND = 5032;

        /// ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT -> 5903L
        public const int ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT = 5903;

        /// ERROR_CLUSCFG_ROLLBACK_FAILED -> 5902L
        public const int ERROR_CLUSCFG_ROLLBACK_FAILED = 5902;

        /// ERROR_CLUSCFG_ALREADY_COMMITTED -> 5901L
        public const int ERROR_CLUSCFG_ALREADY_COMMITTED = 5901;

        /// ERROR_CLIPPING_NOT_SUPPORTED -> 2005L
        public const int ERROR_CLIPPING_NOT_SUPPORTED = 2005;

        /// ERROR_CLIPBOARD_NOT_OPEN -> 1418L
        public const int ERROR_CLIPBOARD_NOT_OPEN = 1418;

        /// ERROR_CLEANER_SLOT_SET -> 4331L
        public const int ERROR_CLEANER_SLOT_SET = 4331;

        /// ERROR_CLEANER_SLOT_NOT_SET -> 4332L
        public const int ERROR_CLEANER_SLOT_NOT_SET = 4332;

        /// ERROR_CLEANER_CARTRIDGE_SPENT -> 4333L
        public const int ERROR_CLEANER_CARTRIDGE_SPENT = 4333;

        /// ERROR_CLEANER_CARTRIDGE_INSTALLED -> 4340L
        public const int ERROR_CLEANER_CARTRIDGE_INSTALLED = 4340;

        /// ERROR_CLASS_HAS_WINDOWS -> 1412L
        public const int ERROR_CLASS_HAS_WINDOWS = 1412;

        /// ERROR_CLASS_DOES_NOT_EXIST -> 1411L
        public const int ERROR_CLASS_DOES_NOT_EXIST = 1411;

        /// ERROR_CLASS_ALREADY_EXISTS -> 1410L
        public const int ERROR_CLASS_ALREADY_EXISTS = 1410;

        /// ERROR_CIRCULAR_DEPENDENCY -> 1059L
        public const int ERROR_CIRCULAR_DEPENDENCY = 1059;

        /// ERROR_CHILD_WINDOW_MENU -> 1436L
        public const int ERROR_CHILD_WINDOW_MENU = 1436;

        /// ERROR_CHILD_NOT_COMPLETE -> 129L
        public const int ERROR_CHILD_NOT_COMPLETE = 129;

        /// ERROR_CHILD_MUST_BE_VOLATILE -> 1021L
        public const int ERROR_CHILD_MUST_BE_VOLATILE = 1021;

        /// ERROR_CAN_NOT_DEL_LOCAL_WINS -> 4001L
        public const int ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001;

        /// ERROR_CAN_NOT_COMPLETE -> 1003L
        public const int ERROR_CAN_NOT_COMPLETE = 1003;

        /// ERROR_CANT_RESOLVE_FILENAME -> 1921L
        public const int ERROR_CANT_RESOLVE_FILENAME = 1921;

        /// ERROR_CANT_OPEN_ANONYMOUS -> 1347L
        public const int ERROR_CANT_OPEN_ANONYMOUS = 1347;

        /// ERROR_CANT_EVICT_ACTIVE_NODE -> 5009L
        public const int ERROR_CANT_EVICT_ACTIVE_NODE = 5009;

        /// ERROR_CANT_DISABLE_MANDATORY -> 1310L
        public const int ERROR_CANT_DISABLE_MANDATORY = 1310;

        /// ERROR_CANT_DELETE_LAST_ITEM -> 4335L
        public const int ERROR_CANT_DELETE_LAST_ITEM = 4335;

        /// ERROR_CANT_ACCESS_FILE -> 1920L
        public const int ERROR_CANT_ACCESS_FILE = 1920;

        /// ERROR_CANT_ACCESS_DOMAIN_INFO -> 1351L
        public const int ERROR_CANT_ACCESS_DOMAIN_INFO = 1351;

        /// ERROR_CANTWRITE -> 1013L
        public const int ERROR_CANTWRITE = 1013;

        /// ERROR_CANTREAD -> 1012L
        public const int ERROR_CANTREAD = 1012;

        /// ERROR_CANTOPEN -> 1011L
        public const int ERROR_CANTOPEN = 1011;

        /// ERROR_CANNOT_OPEN_PROFILE -> 1205L
        public const int ERROR_CANNOT_OPEN_PROFILE = 1205;

        /// ERROR_CANNOT_MAKE -> 82L
        public const int ERROR_CANNOT_MAKE = 82;

        /// ERROR_CANNOT_IMPERSONATE -> 1368L
        public const int ERROR_CANNOT_IMPERSONATE = 1368;

        /// ERROR_CANNOT_FIND_WND_CLASS -> 1407L
        public const int ERROR_CANNOT_FIND_WND_CLASS = 1407;

        /// ERROR_CANNOT_DETECT_PROCESS_ABORT -> 1081L
        public const int ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081;

        /// ERROR_CANNOT_DETECT_DRIVER_FAILURE -> 1080L
        public const int ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080;

        /// ERROR_CANNOT_COPY -> 266L
        public const int ERROR_CANNOT_COPY = 266;

        /// ERROR_CANCEL_VIOLATION -> 173L
        public const int ERROR_CANCEL_VIOLATION = 173;

        /// ERROR_CANCELLED -> 1223L
        public const int ERROR_CANCELLED = 1223;

        /// ERROR_CALL_NOT_IMPLEMENTED -> 120L
        public const int ERROR_CALL_NOT_IMPLEMENTED = 120;

        /// ERROR_CALLBACK_SUPPLIED_INVALID_DATA -> 1273L
        public const int ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273;

        /// ERROR_BUS_RESET -> 1111L
        public const int ERROR_BUS_RESET = 1111;

        /// ERROR_BUSY_DRIVE -> 142L
        public const int ERROR_BUSY_DRIVE = 142;

        /// ERROR_BUSY -> 170L
        public const int ERROR_BUSY = 170;

        /// ERROR_BUFFER_OVERFLOW -> 111L
        public const int ERROR_BUFFER_OVERFLOW = 111;

        /// ERROR_BROKEN_PIPE -> 109L
        public const int ERROR_BROKEN_PIPE = 109;

        /// ERROR_BOOT_ALREADY_ACCEPTED -> 1076L
        public const int ERROR_BOOT_ALREADY_ACCEPTED = 1076;

        /// ERROR_BIDI_STATUS_WARNING -> (ERROR_BIDI_ERROR_BASE + 1)
        public const int ERROR_BIDI_STATUS_WARNING = (NativeConstants.ERROR_BIDI_ERROR_BASE + 1);

        /// ERROR_BIDI_STATUS_OK -> 0
        public const int ERROR_BIDI_STATUS_OK = 0;

        /// ERROR_BIDI_SERVER_OFFLINE -> (ERROR_BIDI_ERROR_BASE + 3)
        public const int ERROR_BIDI_SERVER_OFFLINE = (NativeConstants.ERROR_BIDI_ERROR_BASE + 3);

        /// ERROR_BIDI_SCHEMA_READ_ONLY -> (ERROR_BIDI_ERROR_BASE + 2)
        public const int ERROR_BIDI_SCHEMA_READ_ONLY = (NativeConstants.ERROR_BIDI_ERROR_BASE + 2);

        /// ERROR_BIDI_SCHEMA_NOT_SUPPORTED -> (ERROR_BIDI_ERROR_BASE + 5)
        public const int ERROR_BIDI_SCHEMA_NOT_SUPPORTED = (NativeConstants.ERROR_BIDI_ERROR_BASE + 5);

        /// ERROR_BIDI_NOT_SUPPORTED -> ERROR_NOT_SUPPORTED
        public const int ERROR_BIDI_NOT_SUPPORTED = NativeConstants.ERROR_NOT_SUPPORTED;

        /// ERROR_BIDI_ERROR_BASE -> 13000
        public const int ERROR_BIDI_ERROR_BASE = 13000;

        /// ERROR_BIDI_DEVICE_OFFLINE -> (ERROR_BIDI_ERROR_BASE + 4)
        public const int ERROR_BIDI_DEVICE_OFFLINE = (NativeConstants.ERROR_BIDI_ERROR_BASE + 4);

        /// ERROR_BEGINNING_OF_MEDIA -> 1102L
        public const int ERROR_BEGINNING_OF_MEDIA = 1102;

        /// ERROR_BAD_VALIDATION_CLASS -> 1348L
        public const int ERROR_BAD_VALIDATION_CLASS = 1348;

        /// ERROR_BAD_USER_PROFILE -> 1253L
        public const int ERROR_BAD_USER_PROFILE = 1253;

        /// ERROR_BAD_USERNAME -> 2202L
        public const int ERROR_BAD_USERNAME = 2202;

        /// ERROR_BAD_UNIT -> 20L
        public const int ERROR_BAD_UNIT = 20;

        /// ERROR_BAD_TOKEN_TYPE -> 1349L
        public const int ERROR_BAD_TOKEN_TYPE = 1349;

        /// ERROR_BAD_THREADID_ADDR -> 159L
        public const int ERROR_BAD_THREADID_ADDR = 159;

        /// ERROR_BAD_REM_ADAP -> 60L
        public const int ERROR_BAD_REM_ADAP = 60;

        /// ERROR_BAD_RECOVERY_POLICY -> 6012L
        public const int ERROR_BAD_RECOVERY_POLICY = 6012;

        /// ERROR_BAD_QUERY_SYNTAX -> 1615L
        public const int ERROR_BAD_QUERY_SYNTAX = 1615;

        /// ERROR_BAD_PROVIDER -> 1204L
        public const int ERROR_BAD_PROVIDER = 1204;

        /// ERROR_BAD_PROFILE -> 1206L
        public const int ERROR_BAD_PROFILE = 1206;

        /// ERROR_BAD_PIPE -> 230L
        public const int ERROR_BAD_PIPE = 230;

        /// ERROR_BAD_PATHNAME -> 161L
        public const int ERROR_BAD_PATHNAME = 161;

        /// ERROR_BAD_NET_RESP -> 58L
        public const int ERROR_BAD_NET_RESP = 58;

        /// ERROR_BAD_NET_NAME -> 67L
        public const int ERROR_BAD_NET_NAME = 67;

        /// ERROR_BAD_NETPATH -> 53L
        public const int ERROR_BAD_NETPATH = 53;

        /// ERROR_BAD_LOGON_SESSION_STATE -> 1365L
        public const int ERROR_BAD_LOGON_SESSION_STATE = 1365;

        /// ERROR_BAD_LENGTH -> 24L
        public const int ERROR_BAD_LENGTH = 24;

        /// ERROR_BAD_INHERITANCE_ACL -> 1340L
        public const int ERROR_BAD_INHERITANCE_ACL = 1340;

        /// ERROR_BAD_IMPERSONATION_LEVEL -> 1346L
        public const int ERROR_BAD_IMPERSONATION_LEVEL = 1346;

        /// ERROR_BAD_FORMAT -> 11L
        public const int ERROR_BAD_FORMAT = 11;

        /// ERROR_BAD_EXE_FORMAT -> 193L
        public const int ERROR_BAD_EXE_FORMAT = 193;

        /// ERROR_BAD_ENVIRONMENT -> 10L
        public const int ERROR_BAD_ENVIRONMENT = 10;

        /// ERROR_BAD_DRIVER_LEVEL -> 119L
        public const int ERROR_BAD_DRIVER_LEVEL = 119;

        /// ERROR_BAD_DRIVER -> 2001L
        public const int ERROR_BAD_DRIVER = 2001;

        /// ERROR_BAD_DEV_TYPE -> 66L
        public const int ERROR_BAD_DEV_TYPE = 66;

        /// ERROR_BAD_DEVICE -> 1200L
        public const int ERROR_BAD_DEVICE = 1200;

        /// ERROR_BAD_DESCRIPTOR_FORMAT -> 1361L
        public const int ERROR_BAD_DESCRIPTOR_FORMAT = 1361;

        /// ERROR_BAD_CONFIGURATION -> 1610L
        public const int ERROR_BAD_CONFIGURATION = 1610;

        /// ERROR_BAD_COMMAND -> 22L
        public const int ERROR_BAD_COMMAND = 22;

        /// ERROR_BAD_ARGUMENTS -> 160L
        public const int ERROR_BAD_ARGUMENTS = 160;

        /// ERROR_BADKEY -> 1010L
        public const int ERROR_BADKEY = 1010;

        /// ERROR_BADDB -> 1009L
        public const int ERROR_BADDB = 1009;

        /// ERROR_AUTODATASEG_EXCEEDS_64k -> 199L
        public const int ERROR_AUTODATASEG_EXCEEDS_64k = 199;

        /// ERROR_AUTHENTICATION_FIREWALL_FAILED -> 1935L
        public const int ERROR_AUTHENTICATION_FIREWALL_FAILED = 1935;

        /// ERROR_ATOMIC_LOCKS_NOT_SUPPORTED -> 174L
        public const int ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174;

        /// ERROR_ARITHMETIC_OVERFLOW -> 534L
        public const int ERROR_ARITHMETIC_OVERFLOW = 534;

        /// ERROR_ARENA_TRASHED -> 7L
        public const int ERROR_ARENA_TRASHED = 7;

        /// ERROR_APP_WRONG_OS -> 1151L
        public const int ERROR_APP_WRONG_OS = 1151;

        /// ERROR_APPHELP_BLOCK -> 1259L
        public const int ERROR_APPHELP_BLOCK = 1259;

        /// ERROR_ALREADY_WAITING -> 1904L
        public const int ERROR_ALREADY_WAITING = 1904;

        /// ERROR_ALREADY_THREAD -> 1281L
        public const int ERROR_ALREADY_THREAD = 1281;

        /// ERROR_ALREADY_RUNNING_LKG -> 1074L
        public const int ERROR_ALREADY_RUNNING_LKG = 1074;

        /// ERROR_ALREADY_REGISTERED -> 1242L
        public const int ERROR_ALREADY_REGISTERED = 1242;

        /// ERROR_ALREADY_INITIALIZED -> 1247L
        public const int ERROR_ALREADY_INITIALIZED = 1247;

        /// ERROR_ALREADY_FIBER -> 1280L
        public const int ERROR_ALREADY_FIBER = 1280;

        /// ERROR_ALREADY_EXISTS -> 183L
        public const int ERROR_ALREADY_EXISTS = 183;

        /// ERROR_ALREADY_ASSIGNED -> 85L
        public const int ERROR_ALREADY_ASSIGNED = 85;

        /// ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED -> 1933L
        public const int ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED = 1933;

        /// ERROR_ALL_NODES_NOT_AVAILABLE -> 5037L
        public const int ERROR_ALL_NODES_NOT_AVAILABLE = 5037;

        /// ERROR_ALLOTTED_SPACE_EXCEEDED -> 1344L
        public const int ERROR_ALLOTTED_SPACE_EXCEEDED = 1344;

        /// ERROR_ALIAS_EXISTS -> 1379L
        public const int ERROR_ALIAS_EXISTS = 1379;

        /// ERROR_ADDRESS_NOT_ASSOCIATED -> 1228L
        public const int ERROR_ADDRESS_NOT_ASSOCIATED = 1228;

        /// ERROR_ADDRESS_ALREADY_ASSOCIATED -> 1227L
        public const int ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227;

        /// ERROR_ADAP_HDW_ERR -> 57L
        public const int ERROR_ADAP_HDW_ERR = 57;

        /// ERROR_ACTIVE_CONNECTIONS -> 2402L
        public const int ERROR_ACTIVE_CONNECTIONS = 2402;

        /// ERROR_ACTIVATION_COUNT_EXCEEDED -> 7059L
        public const int ERROR_ACTIVATION_COUNT_EXCEEDED = 7059;

        /// ERROR_ACCOUNT_RESTRICTION -> 1327L
        public const int ERROR_ACCOUNT_RESTRICTION = 1327;

        /// ERROR_ACCOUNT_LOCKED_OUT -> 1909L
        public const int ERROR_ACCOUNT_LOCKED_OUT = 1909;

        /// ERROR_ACCOUNT_EXPIRED -> 1793L
        public const int ERROR_ACCOUNT_EXPIRED = 1793;

        /// ERROR_ACCOUNT_DISABLED -> 1331L
        public const int ERROR_ACCOUNT_DISABLED = 1331;

        /// ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER -> 1278L
        public const int ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278;

        /// ERROR_ACCESS_DISABLED_WEBBLADE -> 1277L
        public const int ERROR_ACCESS_DISABLED_WEBBLADE = 1277;

        /// ERROR_ACCESS_DISABLED_BY_POLICY -> 1260L
        public const int ERROR_ACCESS_DISABLED_BY_POLICY = 1260;

        /// ERROR_ACCESS_DENIED -> 5L
        public const int ERROR_ACCESS_DENIED = 5;

        /// ERROR -> 0
        public const int ERROR = 0;

        /// EPT_S_NOT_REGISTERED -> 1753L
        public const int EPT_S_NOT_REGISTERED = 1753;

        /// EPT_S_INVALID_ENTRY -> 1751L
        public const int EPT_S_INVALID_ENTRY = 1751;

        /// EPT_S_CANT_PERFORM_OP -> 1752L
        public const int EPT_S_CANT_PERFORM_OP = 1752;

        /// EPT_S_CANT_CREATE -> 1899L
        public const int EPT_S_CANT_CREATE = 1899;

        /// EPS_SIGNATURE -> 0x46535045
        public const int EPS_SIGNATURE = 1179865157;

        /// EPSPRINTING -> 33
        public const int EPSPRINTING = 33;

        /// EN_VSCROLL -> 0x0602
        public const int EN_VSCROLL = 1538;

        /// EN_UPDATE -> 0x0400
        public const int EN_UPDATE = 1024;

        /// EN_SETFOCUS -> 0x0100
        public const int EN_SETFOCUS = 256;

        /// EN_MAXTEXT -> 0x0501
        public const int EN_MAXTEXT = 1281;

        /// EN_KILLFOCUS -> 0x0200
        public const int EN_KILLFOCUS = 512;

        /// EN_HSCROLL -> 0x0601
        public const int EN_HSCROLL = 1537;

        /// EN_ERRSPACE -> 0x0500
        public const int EN_ERRSPACE = 1280;

        /// EN_CHANGE -> 0x0300
        public const int EN_CHANGE = 768;

        /// EN_ALIGN_RTL_EC -> 0x0701
        public const int EN_ALIGN_RTL_EC = 1793;

        /// EN_ALIGN_LTR_EC -> 0x0700
        public const int EN_ALIGN_LTR_EC = 1792;

        /// ENUM_S_LAST -> 0x000401BFL
        public const int ENUM_S_LAST = 262591;

        /// ENUM_S_FIRST -> 0x000401B0L
        public const int ENUM_S_FIRST = 262576;

        /// ENUM_REGISTRY_SETTINGS -> ((DWORD)-2)
        /// Error generating expression: Value DWORD is not resolved
        public const string ENUM_REGISTRY_SETTINGS = "((DWORD)-2)";

        /// ENUM_E_LAST -> 0x800401BFL
        public const int ENUM_E_LAST = -2147221057;

        /// ENUM_E_FIRST -> 0x800401B0L
        public const int ENUM_E_FIRST = -2147221072;

        /// ENUM_CURRENT_SETTINGS -> ((DWORD)-1)
        /// Error generating expression: Value DWORD is not resolved
        public const string ENUM_CURRENT_SETTINGS = "((DWORD)-1)";

        /// ENUM_ALL_CALENDARS -> 0xffffffff
        public const int ENUM_ALL_CALENDARS = -1;

        /// EnumWindowStations -> EnumWindowStationsW
        /// Error generating expression: Value EnumWindowStationsW is not resolved
        public const string EnumWindowStations = "EnumWindowStationsW";

        /// EnumUILanguages -> EnumUILanguagesW
        /// Error generating expression: Value EnumUILanguagesW is not resolved
        public const string EnumUILanguages = "EnumUILanguagesW";

        /// EnumTimeFormats -> EnumTimeFormatsW
        /// Error generating expression: Value EnumTimeFormatsW is not resolved
        public const string EnumTimeFormats = "EnumTimeFormatsW";

        /// EnumSystemLocales -> EnumSystemLocalesW
        /// Error generating expression: Value EnumSystemLocalesW is not resolved
        public const string EnumSystemLocales = "EnumSystemLocalesW";

        /// EnumSystemLanguageGroups -> EnumSystemLanguageGroupsW
        /// Error generating expression: Value EnumSystemLanguageGroupsW is not resolved
        public const string EnumSystemLanguageGroups = "EnumSystemLanguageGroupsW";

        /// EnumSystemCodePages -> EnumSystemCodePagesW
        /// Error generating expression: Value EnumSystemCodePagesW is not resolved
        public const string EnumSystemCodePages = "EnumSystemCodePagesW";

        /// EnumServicesStatusEx -> EnumServicesStatusExW
        /// Error generating expression: Value EnumServicesStatusExW is not resolved
        public const string EnumServicesStatusEx = "EnumServicesStatusExW";

        /// EnumServicesStatus -> EnumServicesStatusW
        /// Error generating expression: Value EnumServicesStatusW is not resolved
        public const string EnumServicesStatus = "EnumServicesStatusW";

        /// ENUMRESTYPEPROC -> ENUMRESTYPEPROCW
        /// Error generating expression: Value ENUMRESTYPEPROCW is not resolved
        public const string ENUMRESTYPEPROC = "ENUMRESTYPEPROCW";

        /// EnumResourceTypes -> EnumResourceTypesW
        /// Error generating expression: Value EnumResourceTypesW is not resolved
        public const string EnumResourceTypes = "EnumResourceTypesW";

        /// EnumResourceNames -> EnumResourceNamesW
        /// Error generating expression: Value EnumResourceNamesW is not resolved
        public const string EnumResourceNames = "EnumResourceNamesW";

        /// EnumResourceLanguages -> EnumResourceLanguagesW
        /// Error generating expression: Value EnumResourceLanguagesW is not resolved
        public const string EnumResourceLanguages = "EnumResourceLanguagesW";

        /// ENUMRESNAMEPROC -> ENUMRESNAMEPROCW
        /// Error generating expression: Value ENUMRESNAMEPROCW is not resolved
        public const string ENUMRESNAMEPROC = "ENUMRESNAMEPROCW";

        /// ENUMRESLANGPROC -> ENUMRESLANGPROCW
        /// Error generating expression: Value ENUMRESLANGPROCW is not resolved
        public const string ENUMRESLANGPROC = "ENUMRESLANGPROCW";

        /// EnumPropsEx -> EnumPropsExW
        /// Error generating expression: Value EnumPropsExW is not resolved
        public const string EnumPropsEx = "EnumPropsExW";

        /// EnumProps -> EnumPropsW
        /// Error generating expression: Value EnumPropsW is not resolved
        public const string EnumProps = "EnumPropsW";

        /// EnumPrintProcessors -> EnumPrintProcessorsW
        /// Error generating expression: Value EnumPrintProcessorsW is not resolved
        public const string EnumPrintProcessors = "EnumPrintProcessorsW";

        /// EnumPrintProcessorDatatypes -> EnumPrintProcessorDatatypesW
        /// Error generating expression: Value EnumPrintProcessorDatatypesW is not resolved
        public const string EnumPrintProcessorDatatypes = "EnumPrintProcessorDatatypesW";

        /// EnumPrinters -> EnumPrintersW
        /// Error generating expression: Value EnumPrintersW is not resolved
        public const string EnumPrinters = "EnumPrintersW";

        /// EnumPrinterKey -> EnumPrinterKeyW
        /// Error generating expression: Value EnumPrinterKeyW is not resolved
        public const string EnumPrinterKey = "EnumPrinterKeyW";

        /// EnumPrinterDrivers -> EnumPrinterDriversW
        /// Error generating expression: Value EnumPrinterDriversW is not resolved
        public const string EnumPrinterDrivers = "EnumPrinterDriversW";

        /// EnumPrinterDataEx -> EnumPrinterDataExW
        /// Error generating expression: Value EnumPrinterDataExW is not resolved
        public const string EnumPrinterDataEx = "EnumPrinterDataExW";

        /// EnumPrinterData -> EnumPrinterDataW
        /// Error generating expression: Value EnumPrinterDataW is not resolved
        public const string EnumPrinterData = "EnumPrinterDataW";

        /// EnumPorts -> EnumPortsW
        /// Error generating expression: Value EnumPortsW is not resolved
        public const string EnumPorts = "EnumPortsW";

        /// ENUMPAPERMETRICS -> 34
        public const int ENUMPAPERMETRICS = 34;

        /// ENUMPAPERBINS -> 31
        public const int ENUMPAPERBINS = 31;

        /// EnumMonitors -> EnumMonitorsW
        /// Error generating expression: Value EnumMonitorsW is not resolved
        public const string EnumMonitors = "EnumMonitorsW";

        /// EnumLanguageGroupLocales -> EnumLanguageGroupLocalesW
        /// Error generating expression: Value EnumLanguageGroupLocalesW is not resolved
        public const string EnumLanguageGroupLocales = "EnumLanguageGroupLocalesW";

        /// EnumJobs -> EnumJobsW
        /// Error generating expression: Value EnumJobsW is not resolved
        public const string EnumJobs = "EnumJobsW";

        /// EnumICMProfiles -> EnumICMProfilesW
        /// Error generating expression: Value EnumICMProfilesW is not resolved
        public const string EnumICMProfiles = "EnumICMProfilesW";

        /// EnumForms -> EnumFormsW
        /// Error generating expression: Value EnumFormsW is not resolved
        public const string EnumForms = "EnumFormsW";

        /// EnumFonts -> EnumFontsW
        /// Error generating expression: Value EnumFontsW is not resolved
        public const string EnumFonts = "EnumFontsW";

        /// EnumFontFamiliesEx -> EnumFontFamiliesExW
        /// Error generating expression: Value EnumFontFamiliesExW is not resolved
        public const string EnumFontFamiliesEx = "EnumFontFamiliesExW";

        /// EnumFontFamilies -> EnumFontFamiliesW
        /// Error generating expression: Value EnumFontFamiliesW is not resolved
        public const string EnumFontFamilies = "EnumFontFamiliesW";

        /// EnumDisplaySettingsEx -> EnumDisplaySettingsExW
        /// Error generating expression: Value EnumDisplaySettingsExW is not resolved
        public const string EnumDisplaySettingsEx = "EnumDisplaySettingsExW";

        /// EnumDisplaySettings -> EnumDisplaySettingsW
        /// Error generating expression: Value EnumDisplaySettingsW is not resolved
        public const string EnumDisplaySettings = "EnumDisplaySettingsW";

        /// EnumDisplayDevices -> EnumDisplayDevicesW
        /// Error generating expression: Value EnumDisplayDevicesW is not resolved
        public const string EnumDisplayDevices = "EnumDisplayDevicesW";

        /// EnumDesktops -> EnumDesktopsW
        /// Error generating expression: Value EnumDesktopsW is not resolved
        public const string EnumDesktops = "EnumDesktopsW";

        /// EnumDependentServices -> EnumDependentServicesW
        /// Error generating expression: Value EnumDependentServicesW is not resolved
        public const string EnumDependentServices = "EnumDependentServicesW";

        /// EnumDateFormatsEx -> EnumDateFormatsExW
        /// Error generating expression: Value EnumDateFormatsExW is not resolved
        public const string EnumDateFormatsEx = "EnumDateFormatsExW";

        /// EnumDateFormats -> EnumDateFormatsW
        /// Error generating expression: Value EnumDateFormatsW is not resolved
        public const string EnumDateFormats = "EnumDateFormatsW";

        /// EnumCalendarInfoEx -> EnumCalendarInfoExW
        /// Error generating expression: Value EnumCalendarInfoExW is not resolved
        public const string EnumCalendarInfoEx = "EnumCalendarInfoExW";

        /// EnumCalendarInfo -> EnumCalendarInfoW
        /// Error generating expression: Value EnumCalendarInfoW is not resolved
        public const string EnumCalendarInfo = "EnumCalendarInfoW";

        /// ENHMETA_STOCK_OBJECT -> 0x80000000
        public const int ENHMETA_STOCK_OBJECT = -2147483648;

        /// ENHMETA_SIGNATURE -> 0x464D4520
        public const int ENHMETA_SIGNATURE = 1179469088;

        /// ENHANCED_KEY -> 0x0100
        public const int ENHANCED_KEY = 256;

        /// END_PATH -> 4098
        public const int END_PATH = 4098;

        /// EndUpdateResource -> EndUpdateResourceW
        /// Error generating expression: Value EndUpdateResourceW is not resolved
        public const string EndUpdateResource = "EndUpdateResourceW";

        /// ENDSESSION_LOGOFF -> 0x80000000
        public const int ENDSESSION_LOGOFF = -2147483648;

        /// ENDDOC -> 11
        public const int ENDDOC = 11;

        /// ENCRYPTION_FORMAT_DEFAULT -> (0x01)
        public const int ENCRYPTION_FORMAT_DEFAULT = 1;

        /// EncryptFile -> EncryptFileW
        /// Error generating expression: Value EncryptFileW is not resolved
        public const string EncryptFile = "EncryptFileW";

        /// ENCAPSULATED_POSTSCRIPT -> 4116
        public const int ENCAPSULATED_POSTSCRIPT = 4116;

        /// ENABLE_WRAP_AT_EOL_OUTPUT -> 0x0002
        public const int ENABLE_WRAP_AT_EOL_OUTPUT = 2;

        /// ENABLE_WINDOW_INPUT -> 0x0008
        public const int ENABLE_WINDOW_INPUT = 8;

        /// ENABLE_SMART -> 0xD8
        public const int ENABLE_SMART = 216;

        /// ENABLE_PROCESSED_OUTPUT -> 0x0001
        public const int ENABLE_PROCESSED_OUTPUT = 1;

        /// ENABLE_PROCESSED_INPUT -> 0x0001
        public const int ENABLE_PROCESSED_INPUT = 1;

        /// ENABLE_MOUSE_INPUT -> 0x0010
        public const int ENABLE_MOUSE_INPUT = 16;

        /// ENABLE_LINE_INPUT -> 0x0002
        public const int ENABLE_LINE_INPUT = 2;

        /// ENABLE_ECHO_INPUT -> 0x0004
        public const int ENABLE_ECHO_INPUT = 4;

        /// ENABLE_DISABLE_AUTO_OFFLINE -> 0xDB
        public const int ENABLE_DISABLE_AUTO_OFFLINE = 219;

        /// ENABLE_DISABLE_AUTOSAVE -> 0xD2
        public const int ENABLE_DISABLE_AUTOSAVE = 210;

        /// ENABLERELATIVEWIDTHS -> 768
        public const int ENABLERELATIVEWIDTHS = 768;

        /// ENABLEPAIRKERNING -> 769
        public const int ENABLEPAIRKERNING = 769;

        /// ENABLEDUPLEX -> 28
        public const int ENABLEDUPLEX = 28;

        /// EM_UNDO -> 0x00C7
        public const int EM_UNDO = 199;

        /// EM_SETWORDBREAKPROC -> 0x00D0
        public const int EM_SETWORDBREAKPROC = 208;

        /// EM_SETTABSTOPS -> 0x00CB
        public const int EM_SETTABSTOPS = 203;

        /// EM_SETSEL -> 0x00B1
        public const int EM_SETSEL = 177;

        /// EM_SETRECTNP -> 0x00B4
        public const int EM_SETRECTNP = 180;

        /// EM_SETRECT -> 0x00B3
        public const int EM_SETRECT = 179;

        /// EM_SETREADONLY -> 0x00CF
        public const int EM_SETREADONLY = 207;

        /// EM_SETPASSWORDCHAR -> 0x00CC
        public const int EM_SETPASSWORDCHAR = 204;

        /// EM_SETMODIFY -> 0x00B9
        public const int EM_SETMODIFY = 185;

        /// EM_SETMARGINS -> 0x00D3
        public const int EM_SETMARGINS = 211;

        /// EM_SETLIMITTEXT -> EM_LIMITTEXT
        public const int EM_SETLIMITTEXT = NativeConstants.EM_LIMITTEXT;

        /// EM_SETIMESTATUS -> 0x00D8
        public const int EM_SETIMESTATUS = 216;

        /// EM_SETHANDLE -> 0x00BC
        public const int EM_SETHANDLE = 188;

        /// EM_SCROLLCARET -> 0x00B7
        public const int EM_SCROLLCARET = 183;

        /// EM_SCROLL -> 0x00B5
        public const int EM_SCROLL = 181;

        /// EM_REPLACESEL -> 0x00C2
        public const int EM_REPLACESEL = 194;

        /// EM_POSFROMCHAR -> 0x00D6
        public const int EM_POSFROMCHAR = 214;

        /// EM_LINESCROLL -> 0x00B6
        public const int EM_LINESCROLL = 182;

        /// EM_LINELENGTH -> 0x00C1
        public const int EM_LINELENGTH = 193;

        /// EM_LINEINDEX -> 0x00BB
        public const int EM_LINEINDEX = 187;

        /// EM_LINEFROMCHAR -> 0x00C9
        public const int EM_LINEFROMCHAR = 201;

        /// EM_LIMITTEXT -> 0x00C5
        public const int EM_LIMITTEXT = 197;

        /// EM_GETWORDBREAKPROC -> 0x00D1
        public const int EM_GETWORDBREAKPROC = 209;

        /// EM_GETTHUMB -> 0x00BE
        public const int EM_GETTHUMB = 190;

        /// EM_GETSEL -> 0x00B0
        public const int EM_GETSEL = 176;

        /// EM_GETRECT -> 0x00B2
        public const int EM_GETRECT = 178;

        /// EM_GETPASSWORDCHAR -> 0x00D2
        public const int EM_GETPASSWORDCHAR = 210;

        /// EM_GETMODIFY -> 0x00B8
        public const int EM_GETMODIFY = 184;

        /// EM_GETMARGINS -> 0x00D4
        public const int EM_GETMARGINS = 212;

        /// EM_GETLINECOUNT -> 0x00BA
        public const int EM_GETLINECOUNT = 186;

        /// EM_GETLINE -> 0x00C4
        public const int EM_GETLINE = 196;

        /// EM_GETLIMITTEXT -> 0x00D5
        public const int EM_GETLIMITTEXT = 213;

        /// EM_GETIMESTATUS -> 0x00D9
        public const int EM_GETIMESTATUS = 217;

        /// EM_GETHANDLE -> 0x00BD
        public const int EM_GETHANDLE = 189;

        /// EM_GETFIRSTVISIBLELINE -> 0x00CE
        public const int EM_GETFIRSTVISIBLELINE = 206;

        /// EM_FMTLINES -> 0x00C8
        public const int EM_FMTLINES = 200;

        /// EM_EMPTYUNDOBUFFER -> 0x00CD
        public const int EM_EMPTYUNDOBUFFER = 205;

        /// EM_CHARFROMPOS -> 0x00D7
        public const int EM_CHARFROMPOS = 215;

        /// EM_CANUNDO -> 0x00C6
        public const int EM_CANUNDO = 198;

        /// EMSIS_COMPOSITIONSTRING -> 0x0001
        public const int EMSIS_COMPOSITIONSTRING = 1;

        /// EMR_WIDENPATH -> 66
        public const int EMR_WIDENPATH = 66;

        /// EMR_TRANSPARENTBLT -> 116
        public const int EMR_TRANSPARENTBLT = 116;

        /// EMR_STROKEPATH -> 64
        public const int EMR_STROKEPATH = 64;

        /// EMR_STROKEANDFILLPATH -> 63
        public const int EMR_STROKEANDFILLPATH = 63;

        /// EMR_STRETCHDIBITS -> 81
        public const int EMR_STRETCHDIBITS = 81;

        /// EMR_STRETCHBLT -> 77
        public const int EMR_STRETCHBLT = 77;

        /// EMR_SETWORLDTRANSFORM -> 35
        public const int EMR_SETWORLDTRANSFORM = 35;

        /// EMR_SETWINDOWORGEX -> 10
        public const int EMR_SETWINDOWORGEX = 10;

        /// EMR_SETWINDOWEXTEX -> 9
        public const int EMR_SETWINDOWEXTEX = 9;

        /// EMR_SETVIEWPORTORGEX -> 12
        public const int EMR_SETVIEWPORTORGEX = 12;

        /// EMR_SETVIEWPORTEXTEX -> 11
        public const int EMR_SETVIEWPORTEXTEX = 11;

        /// EMR_SETTEXTCOLOR -> 24
        public const int EMR_SETTEXTCOLOR = 24;

        /// EMR_SETTEXTALIGN -> 22
        public const int EMR_SETTEXTALIGN = 22;

        /// EMR_SETSTRETCHBLTMODE -> 21
        public const int EMR_SETSTRETCHBLTMODE = 21;

        /// EMR_SETROP2 -> 20
        public const int EMR_SETROP2 = 20;

        /// EMR_SETPOLYFILLMODE -> 19
        public const int EMR_SETPOLYFILLMODE = 19;

        /// EMR_SETPIXELV -> 15
        public const int EMR_SETPIXELV = 15;

        /// EMR_SETPALETTEENTRIES -> 50
        public const int EMR_SETPALETTEENTRIES = 50;

        /// EMR_SETMITERLIMIT -> 58
        public const int EMR_SETMITERLIMIT = 58;

        /// EMR_SETMETARGN -> 28
        public const int EMR_SETMETARGN = 28;

        /// EMR_SETMAPPERFLAGS -> 16
        public const int EMR_SETMAPPERFLAGS = 16;

        /// EMR_SETMAPMODE -> 17
        public const int EMR_SETMAPMODE = 17;

        /// EMR_SETLAYOUT -> 115
        public const int EMR_SETLAYOUT = 115;

        /// EMR_SETICMPROFILEW -> 113
        public const int EMR_SETICMPROFILEW = 113;

        /// EMR_SETICMPROFILEA -> 112
        public const int EMR_SETICMPROFILEA = 112;

        /// EMR_SETICMMODE -> 98
        public const int EMR_SETICMMODE = 98;

        /// EMR_SETDIBITSTODEVICE -> 80
        public const int EMR_SETDIBITSTODEVICE = 80;

        /// EMR_SETCOLORSPACE -> 100
        public const int EMR_SETCOLORSPACE = 100;

        /// EMR_SETCOLORADJUSTMENT -> 23
        public const int EMR_SETCOLORADJUSTMENT = 23;

        /// EMR_SETBRUSHORGEX -> 13
        public const int EMR_SETBRUSHORGEX = 13;

        /// EMR_SETBKMODE -> 18
        public const int EMR_SETBKMODE = 18;

        /// EMR_SETBKCOLOR -> 25
        public const int EMR_SETBKCOLOR = 25;

        /// EMR_SETARCDIRECTION -> 57
        public const int EMR_SETARCDIRECTION = 57;

        /// EMR_SELECTPALETTE -> 48
        public const int EMR_SELECTPALETTE = 48;

        /// EMR_SELECTOBJECT -> 37
        public const int EMR_SELECTOBJECT = 37;

        /// EMR_SELECTCLIPPATH -> 67
        public const int EMR_SELECTCLIPPATH = 67;

        /// EMR_SCALEWINDOWEXTEX -> 32
        public const int EMR_SCALEWINDOWEXTEX = 32;

        /// EMR_SCALEVIEWPORTEXTEX -> 31
        public const int EMR_SCALEVIEWPORTEXTEX = 31;

        /// EMR_SAVEDC -> 33
        public const int EMR_SAVEDC = 33;

        /// EMR_ROUNDRECT -> 44
        public const int EMR_ROUNDRECT = 44;

        /// EMR_RESTOREDC -> 34
        public const int EMR_RESTOREDC = 34;

        /// EMR_RESIZEPALETTE -> 51
        public const int EMR_RESIZEPALETTE = 51;

        /// EMR_RESERVED_120 -> 120
        public const int EMR_RESERVED_120 = 120;

        /// EMR_RESERVED_119 -> 119
        public const int EMR_RESERVED_119 = 119;

        /// EMR_RESERVED_117 -> 117
        public const int EMR_RESERVED_117 = 117;

        /// EMR_RESERVED_110 -> 110
        public const int EMR_RESERVED_110 = 110;

        /// EMR_RESERVED_109 -> 109
        public const int EMR_RESERVED_109 = 109;

        /// EMR_RESERVED_108 -> 108
        public const int EMR_RESERVED_108 = 108;

        /// EMR_RESERVED_107 -> 107
        public const int EMR_RESERVED_107 = 107;

        /// EMR_RESERVED_106 -> 106
        public const int EMR_RESERVED_106 = 106;

        /// EMR_RESERVED_105 -> 105
        public const int EMR_RESERVED_105 = 105;

        /// EMR_RECTANGLE -> 43
        public const int EMR_RECTANGLE = 43;

        /// EMR_REALIZEPALETTE -> 52
        public const int EMR_REALIZEPALETTE = 52;

        /// EMR_POLYTEXTOUTW -> 97
        public const int EMR_POLYTEXTOUTW = 97;

        /// EMR_POLYTEXTOUTA -> 96
        public const int EMR_POLYTEXTOUTA = 96;

        /// EMR_POLYPOLYLINE16 -> 90
        public const int EMR_POLYPOLYLINE16 = 90;

        /// EMR_POLYPOLYLINE -> 7
        public const int EMR_POLYPOLYLINE = 7;

        /// EMR_POLYPOLYGON16 -> 91
        public const int EMR_POLYPOLYGON16 = 91;

        /// EMR_POLYPOLYGON -> 8
        public const int EMR_POLYPOLYGON = 8;

        /// EMR_POLYLINETO16 -> 89
        public const int EMR_POLYLINETO16 = 89;

        /// EMR_POLYLINETO -> 6
        public const int EMR_POLYLINETO = 6;

        /// EMR_POLYLINE16 -> 87
        public const int EMR_POLYLINE16 = 87;

        /// EMR_POLYLINE -> 4
        public const int EMR_POLYLINE = 4;

        /// EMR_POLYGON16 -> 86
        public const int EMR_POLYGON16 = 86;

        /// EMR_POLYGON -> 3
        public const int EMR_POLYGON = 3;

        /// EMR_POLYDRAW16 -> 92
        public const int EMR_POLYDRAW16 = 92;

        /// EMR_POLYDRAW -> 56
        public const int EMR_POLYDRAW = 56;

        /// EMR_POLYBEZIERTO16 -> 88
        public const int EMR_POLYBEZIERTO16 = 88;

        /// EMR_POLYBEZIERTO -> 5
        public const int EMR_POLYBEZIERTO = 5;

        /// EMR_POLYBEZIER16 -> 85
        public const int EMR_POLYBEZIER16 = 85;

        /// EMR_POLYBEZIER -> 2
        public const int EMR_POLYBEZIER = 2;

        /// EMR_PLGBLT -> 79
        public const int EMR_PLGBLT = 79;

        /// EMR_PIXELFORMAT -> 104
        public const int EMR_PIXELFORMAT = 104;

        /// EMR_PIE -> 47
        public const int EMR_PIE = 47;

        /// EMR_PAINTRGN -> 74
        public const int EMR_PAINTRGN = 74;

        /// EMR_OFFSETCLIPRGN -> 26
        public const int EMR_OFFSETCLIPRGN = 26;

        /// EMR_MOVETOEX -> 27
        public const int EMR_MOVETOEX = 27;

        /// EMR_MODIFYWORLDTRANSFORM -> 36
        public const int EMR_MODIFYWORLDTRANSFORM = 36;

        /// EMR_MIN -> 1
        public const int EMR_MIN = 1;

        /// EMR_MAX -> 122
        public const int EMR_MAX = 122;

        /// EMR_MASKBLT -> 78
        public const int EMR_MASKBLT = 78;

        /// EMR_LINETO -> 54
        public const int EMR_LINETO = 54;

        /// EMR_INVERTRGN -> 73
        public const int EMR_INVERTRGN = 73;

        /// EMR_INTERSECTCLIPRECT -> 30
        public const int EMR_INTERSECTCLIPRECT = 30;

        /// EMR_HEADER -> 1
        public const int EMR_HEADER = 1;

        /// EMR_GRADIENTFILL -> 118
        public const int EMR_GRADIENTFILL = 118;

        /// EMR_GLSRECORD -> 102
        public const int EMR_GLSRECORD = 102;

        /// EMR_GLSBOUNDEDRECORD -> 103
        public const int EMR_GLSBOUNDEDRECORD = 103;

        /// EMR_GDICOMMENT -> 70
        public const int EMR_GDICOMMENT = 70;

        /// EMR_FRAMERGN -> 72
        public const int EMR_FRAMERGN = 72;

        /// EMR_FLATTENPATH -> 65
        public const int EMR_FLATTENPATH = 65;

        /// EMR_FILLRGN -> 71
        public const int EMR_FILLRGN = 71;

        /// EMR_FILLPATH -> 62
        public const int EMR_FILLPATH = 62;

        /// EMR_EXTTEXTOUTW -> 84
        public const int EMR_EXTTEXTOUTW = 84;

        /// EMR_EXTTEXTOUTA -> 83
        public const int EMR_EXTTEXTOUTA = 83;

        /// EMR_EXTSELECTCLIPRGN -> 75
        public const int EMR_EXTSELECTCLIPRGN = 75;

        /// EMR_EXTFLOODFILL -> 53
        public const int EMR_EXTFLOODFILL = 53;

        /// EMR_EXTCREATEPEN -> 95
        public const int EMR_EXTCREATEPEN = 95;

        /// EMR_EXTCREATEFONTINDIRECTW -> 82
        public const int EMR_EXTCREATEFONTINDIRECTW = 82;

        /// EMR_EXCLUDECLIPRECT -> 29
        public const int EMR_EXCLUDECLIPRECT = 29;

        /// EMR_EOF -> 14
        public const int EMR_EOF = 14;

        /// EMR_ENDPATH -> 60
        public const int EMR_ENDPATH = 60;

        /// EMR_ELLIPSE -> 42
        public const int EMR_ELLIPSE = 42;

        /// EMR_DELETEOBJECT -> 40
        public const int EMR_DELETEOBJECT = 40;

        /// EMR_DELETECOLORSPACE -> 101
        public const int EMR_DELETECOLORSPACE = 101;

        /// EMR_CREATEPEN -> 38
        public const int EMR_CREATEPEN = 38;

        /// EMR_CREATEPALETTE -> 49
        public const int EMR_CREATEPALETTE = 49;

        /// EMR_CREATEMONOBRUSH -> 93
        public const int EMR_CREATEMONOBRUSH = 93;

        /// EMR_CREATEDIBPATTERNBRUSHPT -> 94
        public const int EMR_CREATEDIBPATTERNBRUSHPT = 94;

        /// EMR_CREATECOLORSPACEW -> 122
        public const int EMR_CREATECOLORSPACEW = 122;

        /// EMR_CREATECOLORSPACE -> 99
        public const int EMR_CREATECOLORSPACE = 99;

        /// EMR_CREATEBRUSHINDIRECT -> 39
        public const int EMR_CREATEBRUSHINDIRECT = 39;

        /// EMR_COLORMATCHTOTARGETW -> 121
        public const int EMR_COLORMATCHTOTARGETW = 121;

        /// EMR_COLORCORRECTPALETTE -> 111
        public const int EMR_COLORCORRECTPALETTE = 111;

        /// EMR_CLOSEFIGURE -> 61
        public const int EMR_CLOSEFIGURE = 61;

        /// EMR_CHORD -> 46
        public const int EMR_CHORD = 46;

        /// EMR_BITBLT -> 76
        public const int EMR_BITBLT = 76;

        /// EMR_BEGINPATH -> 59
        public const int EMR_BEGINPATH = 59;

        /// EMR_ARCTO -> 55
        public const int EMR_ARCTO = 55;

        /// EMR_ARC -> 45
        public const int EMR_ARC = 45;

        /// EMR_ANGLEARC -> 41
        public const int EMR_ANGLEARC = 41;

        /// EMR_ALPHABLEND -> 114
        public const int EMR_ALPHABLEND = 114;

        /// EMR_ABORTPATH -> 68
        public const int EMR_ABORTPATH = 68;

        /// EMBDHLP_INPROC_SERVER -> 0x0001L
        public const int EMBDHLP_INPROC_SERVER = 1;

        /// EMBDHLP_INPROC_HANDLER -> 0x0000L
        public const int EMBDHLP_INPROC_HANDLER = 0;

        /// EMBDHLP_DELAYCREATE -> 0x00010000L
        public const int EMBDHLP_DELAYCREATE = 65536;

        /// EMBDHLP_CREATENOW -> 0x00000000L
        public const int EMBDHLP_CREATENOW = 0;

        /// EMARCH_ENC_I17_SIGN_VAL_POS_X -> 63
        public const int EMARCH_ENC_I17_SIGN_VAL_POS_X = 63;

        /// EMARCH_ENC_I17_SIGN_SIZE_X -> 1
        public const int EMARCH_ENC_I17_SIGN_SIZE_X = 1;

        /// EMARCH_ENC_I17_SIGN_INST_WORD_X -> 3
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_X = 3;

        /// EMARCH_ENC_I17_SIGN_INST_WORD_POS_X -> 27
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_POS_X = 27;

        /// EMARCH_ENC_I17_IMM9D_VAL_POS_X -> 7
        public const int EMARCH_ENC_I17_IMM9D_VAL_POS_X = 7;

        /// EMARCH_ENC_I17_IMM9D_SIZE_X -> 9
        public const int EMARCH_ENC_I17_IMM9D_SIZE_X = 9;

        /// EMARCH_ENC_I17_IMM9D_INST_WORD_X -> 3
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_X = 3;

        /// EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X -> 18
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X = 18;

        /// EMARCH_ENC_I17_IMM7B_VAL_POS_X -> 0
        public const int EMARCH_ENC_I17_IMM7B_VAL_POS_X = 0;

        /// EMARCH_ENC_I17_IMM7B_SIZE_X -> 7
        public const int EMARCH_ENC_I17_IMM7B_SIZE_X = 7;

        /// EMARCH_ENC_I17_IMM7B_INST_WORD_X -> 3
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_X = 3;

        /// EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X -> 4
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X = 4;

        /// EMARCH_ENC_I17_IMM5C_VAL_POS_X -> 16
        public const int EMARCH_ENC_I17_IMM5C_VAL_POS_X = 16;

        /// EMARCH_ENC_I17_IMM5C_SIZE_X -> 5
        public const int EMARCH_ENC_I17_IMM5C_SIZE_X = 5;

        /// EMARCH_ENC_I17_IMM5C_INST_WORD_X -> 3
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_X = 3;

        /// EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X -> 13
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X = 13;

        /// EMARCH_ENC_I17_IMM41c_VAL_POS_X -> 40
        public const int EMARCH_ENC_I17_IMM41c_VAL_POS_X = 40;

        /// EMARCH_ENC_I17_IMM41c_SIZE_X -> 23
        public const int EMARCH_ENC_I17_IMM41c_SIZE_X = 23;

        /// EMARCH_ENC_I17_IMM41c_INST_WORD_X -> 2
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_X = 2;

        /// EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X -> 0
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X = 0;

        /// EMARCH_ENC_I17_IMM41b_VAL_POS_X -> 32
        public const int EMARCH_ENC_I17_IMM41b_VAL_POS_X = 32;

        /// EMARCH_ENC_I17_IMM41b_SIZE_X -> 8
        public const int EMARCH_ENC_I17_IMM41b_SIZE_X = 8;

        /// EMARCH_ENC_I17_IMM41b_INST_WORD_X -> 1
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_X = 1;

        /// EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X -> 24
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X = 24;

        /// EMARCH_ENC_I17_IMM41a_VAL_POS_X -> 22
        public const int EMARCH_ENC_I17_IMM41a_VAL_POS_X = 22;

        /// EMARCH_ENC_I17_IMM41a_SIZE_X -> 10
        public const int EMARCH_ENC_I17_IMM41a_SIZE_X = 10;

        /// EMARCH_ENC_I17_IMM41a_INST_WORD_X -> 1
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_X = 1;

        /// EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X -> 14
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X = 14;

        /// EMARCH_ENC_I17_IC_VAL_POS_X -> 21
        public const int EMARCH_ENC_I17_IC_VAL_POS_X = 21;

        /// EMARCH_ENC_I17_IC_SIZE_X -> 1
        public const int EMARCH_ENC_I17_IC_SIZE_X = 1;

        /// EMARCH_ENC_I17_IC_INST_WORD_X -> 3
        public const int EMARCH_ENC_I17_IC_INST_WORD_X = 3;

        /// EMARCH_ENC_I17_IC_INST_WORD_POS_X -> 12
        public const int EMARCH_ENC_I17_IC_INST_WORD_POS_X = 12;

        /// ELF_VERSION -> 0
        public const int ELF_VERSION = 0;

        /// ELF_VENDOR_SIZE -> 4
        public const int ELF_VENDOR_SIZE = 4;

        /// ELF_CULTURE_LATIN -> 0
        public const int ELF_CULTURE_LATIN = 0;

        /// ELEMENT_STATUS_SVALID -> 0x00800000
        public const int ELEMENT_STATUS_SVALID = 8388608;

        /// ELEMENT_STATUS_PVOLTAG -> 0x10000000
        public const int ELEMENT_STATUS_PVOLTAG = 268435456;

        /// ELEMENT_STATUS_PRODUCT_DATA -> 0x00000040
        public const int ELEMENT_STATUS_PRODUCT_DATA = 64;

        /// ELEMENT_STATUS_NOT_BUS -> 0x00008000
        public const int ELEMENT_STATUS_NOT_BUS = 32768;

        /// ELEMENT_STATUS_LUN_VALID -> 0x00001000
        public const int ELEMENT_STATUS_LUN_VALID = 4096;

        /// ELEMENT_STATUS_INVERT -> 0x00400000
        public const int ELEMENT_STATUS_INVERT = 4194304;

        /// ELEMENT_STATUS_INENAB -> 0x00000020
        public const int ELEMENT_STATUS_INENAB = 32;

        /// ELEMENT_STATUS_IMPEXP -> 0x00000002
        public const int ELEMENT_STATUS_IMPEXP = 2;

        /// ELEMENT_STATUS_ID_VALID -> 0x00002000
        public const int ELEMENT_STATUS_ID_VALID = 8192;

        /// ELEMENT_STATUS_FULL -> 0x00000001
        public const int ELEMENT_STATUS_FULL = 1;

        /// ELEMENT_STATUS_EXENAB -> 0x00000010
        public const int ELEMENT_STATUS_EXENAB = 16;

        /// ELEMENT_STATUS_EXCEPT -> 0x00000004
        public const int ELEMENT_STATUS_EXCEPT = 4;

        /// ELEMENT_STATUS_AVOLTAG -> 0x20000000
        public const int ELEMENT_STATUS_AVOLTAG = 536870912;

        /// ELEMENT_STATUS_ACCESS -> 0x00000008
        public const int ELEMENT_STATUS_ACCESS = 8;

        /// EIMES_GETCOMPSTRATONCE -> 0x0001
        public const int EIMES_GETCOMPSTRATONCE = 1;

        /// EIMES_COMPLETECOMPSTRKILLFOCUS -> 0x0004
        public const int EIMES_COMPLETECOMPSTRKILLFOCUS = 4;

        /// EIMES_CANCELCOMPSTRINFOCUS -> 0x0002
        public const int EIMES_CANCELCOMPSTRINFOCUS = 2;

        /// EFS_USE_RECOVERY_KEYS -> (0x1)
        public const int EFS_USE_RECOVERY_KEYS = 1;

        /// EEInfoUseFileTime -> 4
        public const int EEInfoUseFileTime = 4;

        /// EEInfoPreviousRecordsMissing -> 1
        public const int EEInfoPreviousRecordsMissing = 1;

        /// EEInfoNextRecordsMissing -> 2
        public const int EEInfoNextRecordsMissing = 2;

        /// EEInfoGCFRS -> 12
        public const int EEInfoGCFRS = 12;

        /// EEInfoGCCOM -> 11
        public const int EEInfoGCCOM = 11;

        /// edt9 -> 0x0488
        public const int edt9 = 1160;

        /// edt8 -> 0x0487
        public const int edt8 = 1159;

        /// edt7 -> 0x0486
        public const int edt7 = 1158;

        /// edt6 -> 0x0485
        public const int edt6 = 1157;

        /// edt5 -> 0x0484
        public const int edt5 = 1156;

        /// edt4 -> 0x0483
        public const int edt4 = 1155;

        /// edt3 -> 0x0482
        public const int edt3 = 1154;

        /// edt2 -> 0x0481
        public const int edt2 = 1153;

        /// edt16 -> 0x048f
        public const int edt16 = 1167;

        /// edt15 -> 0x048e
        public const int edt15 = 1166;

        /// edt14 -> 0x048d
        public const int edt14 = 1165;

        /// edt13 -> 0x048c
        public const int edt13 = 1164;

        /// edt12 -> 0x048b
        public const int edt12 = 1163;

        /// edt11 -> 0x048a
        public const int edt11 = 1162;

        /// edt10 -> 0x0489
        public const int edt10 = 1161;

        /// edt1 -> 0x0480
        public const int edt1 = 1152;

        /// EDS_RAWMODE -> 0x00000002
        public const int EDS_RAWMODE = 2;

        /// EDGE_SUNKEN -> (BDR_SUNKENOUTER | BDR_SUNKENINNER)
        public const int EDGE_SUNKEN = (NativeConstants.BDR_SUNKENOUTER | NativeConstants.BDR_SUNKENINNER);

        /// EDGE_RAISED -> (BDR_RAISEDOUTER | BDR_RAISEDINNER)
        public const int EDGE_RAISED = (NativeConstants.BDR_RAISEDOUTER | NativeConstants.BDR_RAISEDINNER);

        /// EDGE_ETCHED -> (BDR_SUNKENOUTER | BDR_RAISEDINNER)
        public const int EDGE_ETCHED = (NativeConstants.BDR_SUNKENOUTER | NativeConstants.BDR_RAISEDINNER);

        /// EDGE_BUMP -> (BDR_RAISEDOUTER | BDR_SUNKENINNER)
        public const int EDGE_BUMP = (NativeConstants.BDR_RAISEDOUTER | NativeConstants.BDR_SUNKENINNER);

        /// EC_USEFONTINFO -> 0xffff
        public const int EC_USEFONTINFO = 65535;

        /// EC_RIGHTMARGIN -> 0x0002
        public const int EC_RIGHTMARGIN = 2;

        /// EC_QUERYWAITING -> 2
        public const int EC_QUERYWAITING = 2;

        /// EC_LEFTMARGIN -> 0x0001
        public const int EC_LEFTMARGIN = 1;

        /// EC_ENABLEONE -> ST_BLOCKNEXT
        public const int EC_ENABLEONE = NativeConstants.ST_BLOCKNEXT;

        /// EC_ENABLEALL -> 0
        public const int EC_ENABLEALL = 0;

        /// EC_DISABLE -> ST_BLOCKED
        public const int EC_DISABLE = NativeConstants.ST_BLOCKED;

        /// EASTEUROPE_CHARSET -> 238
        public const int EASTEUROPE_CHARSET = 238;
    }

}
