using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// AW_VER_POSITIVE -> 0x00000004
        public const int AW_VER_POSITIVE = 4;

        /// AW_VER_NEGATIVE -> 0x00000008
        public const int AW_VER_NEGATIVE = 8;

        /// AW_SLIDE -> 0x00040000
        public const int AW_SLIDE = 262144;

        /// AW_HOR_POSITIVE -> 0x00000001
        public const int AW_HOR_POSITIVE = 1;

        /// AW_HOR_NEGATIVE -> 0x00000002
        public const int AW_HOR_NEGATIVE = 2;

        /// AW_HIDE -> 0x00010000
        public const int AW_HIDE = 65536;

        /// AW_CENTER -> 0x00000010
        public const int AW_CENTER = 16;

        /// AW_BLEND -> 0x00080000
        public const int AW_BLEND = 524288;

        /// AW_ACTIVATE -> 0x00020000
        public const int AW_ACTIVATE = 131072;

        /// AUX_MAPPER -> ((UINT)-1)
        /// Error generating expression: Value UINT is not resolved
        public const string AUX_MAPPER = "((UINT)-1)";

        /// auxGetDevCaps -> auxGetDevCapsW
        /// Error generating expression: Value auxGetDevCapsW is not resolved
        public const string auxGetDevCaps = "auxGetDevCapsW";

        /// AUXCAPS_VOLUME -> 0x0001
        public const int AUXCAPS_VOLUME = 1;

        /// AUXCAPS_LRVOLUME -> 0x0002
        public const int AUXCAPS_LRVOLUME = 2;

        /// AUXCAPS_CDAUDIO -> 1
        public const int AUXCAPS_CDAUDIO = 1;

        /// AUXCAPS_AUXIN -> 2
        public const int AUXCAPS_AUXIN = 2;

        /// AUTHTYPE_SERVER -> 2
        public const int AUTHTYPE_SERVER = 2;

        /// AUTHTYPE_CLIENT -> 1
        public const int AUTHTYPE_CLIENT = 1;

        /// AUDIT_ALLOW_NO_PRIVILEGE -> 0x1
        public const int AUDIT_ALLOW_NO_PRIVILEGE = 1;

        /// AT_SIGNATURE -> 2
        public const int AT_SIGNATURE = 2;

        /// AT_KEYEXCHANGE -> 1
        public const int AT_KEYEXCHANGE = 1;

        /// ATTR_TARGET_NOTCONVERTED -> 0x03
        public const int ATTR_TARGET_NOTCONVERTED = 3;

        /// ATTR_TARGET_CONVERTED -> 0x01
        public const int ATTR_TARGET_CONVERTED = 1;

        /// ATTR_INPUT_ERROR -> 0x04
        public const int ATTR_INPUT_ERROR = 4;

        /// ATTR_INPUT -> 0x00
        public const int ATTR_INPUT = 0;

        /// ATTR_FIXEDCONVERTED -> 0x05
        public const int ATTR_FIXEDCONVERTED = 5;

        /// ATTR_CONVERTED -> 0x02
        public const int ATTR_CONVERTED = 2;

        /// ATTACH_PARENT_PROCESS -> ((DWORD)-1)
        /// Error generating expression: Value DWORD is not resolved
        public const string ATTACH_PARENT_PROCESS = "((DWORD)-1)";

        /// ATF_TIMEOUTON -> 0x00000001
        public const int ATF_TIMEOUTON = 1;

        /// ATF_ONOFFFEEDBACK -> 0x00000002
        public const int ATF_ONOFFFEEDBACK = 2;

        /// ATAPI_ID_CMD -> 0xA1
        public const int ATAPI_ID_CMD = 161;

        /// ASYNC_MODE_DEFAULT -> 0x00000000L
        public const int ASYNC_MODE_DEFAULT = 0;

        /// ASYNC_MODE_COMPATIBILITY -> 0x00000001L
        public const int ASYNC_MODE_COMPATIBILITY = 1;

        /// ASYNCH -> 0x80
        public const int ASYNCH = 128;

        /// ASSERT_PRIMARY -> 0x8
        public const int ASSERT_PRIMARY = 8;

        /// ASSERT_ALTERNATE -> 0x9
        public const int ASSERT_ALTERNATE = 9;

        /// ASSEMBLY_DLL_REDIRECTION_DETAILED_INFORMATION -> ASSEMBLY_FILE_DETAILED_INFORMATION
        /// Error generating expression: Value ASSEMBLY_FILE_DETAILED_INFORMATION is not resolved
        public const string ASSEMBLY_DLL_REDIRECTION_DETAILED_INFORMATION = "ASSEMBLY_FILE_DETAILED_INFORMATION";

        /// ASPECT_FILTERING -> 0x0001
        public const int ASPECT_FILTERING = 1;

        /// ASPECTY -> 42
        public const int ASPECTY = 42;

        /// ASPECTXY -> 44
        public const int ASPECTXY = 44;

        /// ASPECTX -> 40
        public const int ASPECTX = 40;

        /// ASFW_ANY -> ((DWORD)-1)
        /// Error generating expression: Value DWORD is not resolved
        public const string ASFW_ANY = "((DWORD)-1)";

        /// ARW_UP -> 0x0004L
        public const int ARW_UP = 4;

        /// ARW_TOPRIGHT -> 0x0003L
        public const int ARW_TOPRIGHT = 3;

        /// ARW_TOPLEFT -> 0x0002L
        public const int ARW_TOPLEFT = 2;

        /// ARW_STARTTOP -> 0x0002L
        public const int ARW_STARTTOP = 2;

        /// ARW_STARTRIGHT -> 0x0001L
        public const int ARW_STARTRIGHT = 1;

        /// ARW_STARTMASK -> 0x0003L
        public const int ARW_STARTMASK = 3;

        /// ARW_RIGHT -> 0x0000L
        public const int ARW_RIGHT = 0;

        /// ARW_LEFT -> 0x0000L
        public const int ARW_LEFT = 0;

        /// ARW_HIDE -> 0x0008L
        public const int ARW_HIDE = 8;

        /// ARW_DOWN -> 0x0004L
        public const int ARW_DOWN = 4;

        /// ARW_BOTTOMRIGHT -> 0x0001L
        public const int ARW_BOTTOMRIGHT = 1;

        /// ARW_BOTTOMLEFT -> 0x0000L
        public const int ARW_BOTTOMLEFT = 0;

        /// ARABIC_CHARSET -> 178
        public const int ARABIC_CHARSET = 178;

        /// APPLICATION_VERIFIER_WAIT_IN_DLLMAIN -> 0x0304
        public const int APPLICATION_VERIFIER_WAIT_IN_DLLMAIN = 772;

        /// APPLICATION_VERIFIER_UNSYNCHRONIZED_ACCESS -> 0x0003
        public const int APPLICATION_VERIFIER_UNSYNCHRONIZED_ACCESS = 3;

        /// APPLICATION_VERIFIER_UNKNOWN_ERROR -> 0x0001
        public const int APPLICATION_VERIFIER_UNKNOWN_ERROR = 1;

        /// APPLICATION_VERIFIER_UNEXPECTED_EXCEPTION -> 0x000A
        public const int APPLICATION_VERIFIER_UNEXPECTED_EXCEPTION = 10;

        /// APPLICATION_VERIFIER_THREAD_NOT_LOCK_OWNER -> 0x0214
        public const int APPLICATION_VERIFIER_THREAD_NOT_LOCK_OWNER = 532;

        /// APPLICATION_VERIFIER_TERMINATE_THREAD_CALL -> 0x0100
        public const int APPLICATION_VERIFIER_TERMINATE_THREAD_CALL = 256;

        /// APPLICATION_VERIFIER_SWITCHED_HEAP_HANDLE -> 0x0006
        public const int APPLICATION_VERIFIER_SWITCHED_HEAP_HANDLE = 6;

        /// APPLICATION_VERIFIER_STACK_OVERFLOW -> 0x0101
        public const int APPLICATION_VERIFIER_STACK_OVERFLOW = 257;

        /// APPLICATION_VERIFIER_SIZE_HEAP_UNEXPECTED_EXCEPTION -> 0x0618
        public const int APPLICATION_VERIFIER_SIZE_HEAP_UNEXPECTED_EXCEPTION = 1560;

        /// APPLICATION_VERIFIER_RPC_ERROR -> 0x0500
        public const int APPLICATION_VERIFIER_RPC_ERROR = 1280;

        /// APPLICATION_VERIFIER_PROBE_NULL -> 0x0606
        public const int APPLICATION_VERIFIER_PROBE_NULL = 1542;

        /// APPLICATION_VERIFIER_PROBE_INVALID_START_OR_SIZE -> 0x0607
        public const int APPLICATION_VERIFIER_PROBE_INVALID_START_OR_SIZE = 1543;

        /// APPLICATION_VERIFIER_PROBE_INVALID_ADDRESS -> 0x0603
        public const int APPLICATION_VERIFIER_PROBE_INVALID_ADDRESS = 1539;

        /// APPLICATION_VERIFIER_PROBE_GUARD_PAGE -> 0x0605
        public const int APPLICATION_VERIFIER_PROBE_GUARD_PAGE = 1541;

        /// APPLICATION_VERIFIER_PROBE_FREE_MEM -> 0x0604
        public const int APPLICATION_VERIFIER_PROBE_FREE_MEM = 1540;

        /// APPLICATION_VERIFIER_NULL_HANDLE -> 0x0303
        public const int APPLICATION_VERIFIER_NULL_HANDLE = 771;

        /// APPLICATION_VERIFIER_NO_BREAK -> 0x20000000
        public const int APPLICATION_VERIFIER_NO_BREAK = 536870912;

        /// APPLICATION_VERIFIER_LOCK_OVER_RELEASED -> 0x0209
        public const int APPLICATION_VERIFIER_LOCK_OVER_RELEASED = 521;

        /// APPLICATION_VERIFIER_LOCK_NOT_INITIALIZED -> 0x0210
        public const int APPLICATION_VERIFIER_LOCK_NOT_INITIALIZED = 528;

        /// APPLICATION_VERIFIER_LOCK_IN_UNMAPPED_MEM -> 0x0213
        public const int APPLICATION_VERIFIER_LOCK_IN_UNMAPPED_MEM = 531;

        /// APPLICATION_VERIFIER_LOCK_IN_UNLOADED_DLL -> 0x0201
        public const int APPLICATION_VERIFIER_LOCK_IN_UNLOADED_DLL = 513;

        /// APPLICATION_VERIFIER_LOCK_IN_FREED_VMEM -> 0x0212
        public const int APPLICATION_VERIFIER_LOCK_IN_FREED_VMEM = 530;

        /// APPLICATION_VERIFIER_LOCK_IN_FREED_MEMORY -> 0x0204
        public const int APPLICATION_VERIFIER_LOCK_IN_FREED_MEMORY = 516;

        /// APPLICATION_VERIFIER_LOCK_IN_FREED_HEAP -> 0x0202
        public const int APPLICATION_VERIFIER_LOCK_IN_FREED_HEAP = 514;

        /// APPLICATION_VERIFIER_LOCK_INVALID_RECURSION_COUNT -> 0x0207
        public const int APPLICATION_VERIFIER_LOCK_INVALID_RECURSION_COUNT = 519;

        /// APPLICATION_VERIFIER_LOCK_INVALID_OWNER -> 0x0206
        public const int APPLICATION_VERIFIER_LOCK_INVALID_OWNER = 518;

        /// APPLICATION_VERIFIER_LOCK_INVALID_LOCK_COUNT -> 0x0208
        public const int APPLICATION_VERIFIER_LOCK_INVALID_LOCK_COUNT = 520;

        /// APPLICATION_VERIFIER_LOCK_DOUBLE_INITIALIZE -> 0x0203
        public const int APPLICATION_VERIFIER_LOCK_DOUBLE_INITIALIZE = 515;

        /// APPLICATION_VERIFIER_LOCK_CORRUPTED -> 0x0205
        public const int APPLICATION_VERIFIER_LOCK_CORRUPTED = 517;

        /// APPLICATION_VERIFIER_LOCK_ALREADY_INITIALIZED -> 0x0211
        public const int APPLICATION_VERIFIER_LOCK_ALREADY_INITIALIZED = 529;

        /// APPLICATION_VERIFIER_INVALID_TLS_VALUE -> 0x0301
        public const int APPLICATION_VERIFIER_INVALID_TLS_VALUE = 769;

        /// APPLICATION_VERIFIER_INVALID_MAPVIEW -> 0x0602
        public const int APPLICATION_VERIFIER_INVALID_MAPVIEW = 1538;

        /// APPLICATION_VERIFIER_INVALID_HANDLE -> 0x0300
        public const int APPLICATION_VERIFIER_INVALID_HANDLE = 768;

        /// APPLICATION_VERIFIER_INVALID_FREEMEM -> 0x0600
        public const int APPLICATION_VERIFIER_INVALID_FREEMEM = 1536;

        /// APPLICATION_VERIFIER_INVALID_EXIT_PROCESS_CALL -> 0x0102
        public const int APPLICATION_VERIFIER_INVALID_EXIT_PROCESS_CALL = 258;

        /// APPLICATION_VERIFIER_INVALID_ALLOCMEM -> 0x0601
        public const int APPLICATION_VERIFIER_INVALID_ALLOCMEM = 1537;

        /// APPLICATION_VERIFIER_INTERNAL_WARNING -> 0x40000000
        public const int APPLICATION_VERIFIER_INTERNAL_WARNING = 1073741824;

        /// APPLICATION_VERIFIER_INTERNAL_ERROR -> 0x80000000
        public const int APPLICATION_VERIFIER_INTERNAL_ERROR = -2147483648;

        /// APPLICATION_VERIFIER_INCORRECT_WAIT_CALL -> 0x0302
        public const int APPLICATION_VERIFIER_INCORRECT_WAIT_CALL = 770;

        /// APPLICATION_VERIFIER_FIRST_CHANCE_ACCESS_VIOLATION -> 0x0013
        public const int APPLICATION_VERIFIER_FIRST_CHANCE_ACCESS_VIOLATION = 19;

        /// APPLICATION_VERIFIER_EXTREME_SIZE_REQUEST -> 0x0004
        public const int APPLICATION_VERIFIER_EXTREME_SIZE_REQUEST = 4;

        /// APPLICATION_VERIFIER_EXIT_THREAD_OWNS_LOCK -> 0x0200
        public const int APPLICATION_VERIFIER_EXIT_THREAD_OWNS_LOCK = 512;

        /// APPLICATION_VERIFIER_DOUBLE_FREE -> 0x0007
        public const int APPLICATION_VERIFIER_DOUBLE_FREE = 7;

        /// APPLICATION_VERIFIER_DESTROY_PROCESS_HEAP -> 0x0009
        public const int APPLICATION_VERIFIER_DESTROY_PROCESS_HEAP = 9;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_LIST -> 0x0014
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_LIST = 20;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_SUFFIX -> 0x000F
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_SUFFIX = 15;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_START_STAMP -> 0x0010
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_START_STAMP = 16;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_PREFIX -> 0x0012
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_PREFIX = 18;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_HEADER -> 0x000D
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_HEADER = 13;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_EXCEPTION_RAISED_FOR_PROBING -> 0x000C
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_EXCEPTION_RAISED_FOR_PROBING = 12;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_EXCEPTION_RAISED_FOR_HEADER -> 0x000B
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_EXCEPTION_RAISED_FOR_HEADER = 11;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_END_STAMP -> 0x0011
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK_END_STAMP = 17;

        /// APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK -> 0x0008
        public const int APPLICATION_VERIFIER_CORRUPTED_HEAP_BLOCK = 8;

        /// APPLICATION_VERIFIER_CORRUPTED_FREED_HEAP_BLOCK -> 0x000E
        public const int APPLICATION_VERIFIER_CORRUPTED_FREED_HEAP_BLOCK = 14;

        /// APPLICATION_VERIFIER_CONTINUABLE_BREAK -> 0x10000000
        public const int APPLICATION_VERIFIER_CONTINUABLE_BREAK = 268435456;

        /// APPLICATION_VERIFIER_COM_VTBL_IN_UNLOADED_DLL -> 0x040F
        public const int APPLICATION_VERIFIER_COM_VTBL_IN_UNLOADED_DLL = 1039;

        /// APPLICATION_VERIFIER_COM_VTBL_IN_FREED_MEMORY -> 0x040E
        public const int APPLICATION_VERIFIER_COM_VTBL_IN_FREED_MEMORY = 1038;

        /// APPLICATION_VERIFIER_COM_UNSAFE_IMPERSONATION -> 0x0407
        public const int APPLICATION_VERIFIER_COM_UNSAFE_IMPERSONATION = 1031;

        /// APPLICATION_VERIFIER_COM_UNHANDLED_EXCEPTION -> 0x0402
        public const int APPLICATION_VERIFIER_COM_UNHANDLED_EXCEPTION = 1026;

        /// APPLICATION_VERIFIER_COM_UNBALANCED_SWC -> 0x0405
        public const int APPLICATION_VERIFIER_COM_UNBALANCED_SWC = 1029;

        /// APPLICATION_VERIFIER_COM_UNBALANCED_OLEINIT -> 0x0404
        public const int APPLICATION_VERIFIER_COM_UNBALANCED_OLEINIT = 1028;

        /// APPLICATION_VERIFIER_COM_UNBALANCED_COINIT -> 0x0403
        public const int APPLICATION_VERIFIER_COM_UNBALANCED_COINIT = 1027;

        /// APPLICATION_VERIFIER_COM_SMUGGLED_WRAPPER -> 0x0408
        public const int APPLICATION_VERIFIER_COM_SMUGGLED_WRAPPER = 1032;

        /// APPLICATION_VERIFIER_COM_SMUGGLED_PROXY -> 0x0409
        public const int APPLICATION_VERIFIER_COM_SMUGGLED_PROXY = 1033;

        /// APPLICATION_VERIFIER_COM_OBJECT_IN_UNLOADED_DLL -> 0x040D
        public const int APPLICATION_VERIFIER_COM_OBJECT_IN_UNLOADED_DLL = 1037;

        /// APPLICATION_VERIFIER_COM_OBJECT_IN_FREED_MEMORY -> 0x040C
        public const int APPLICATION_VERIFIER_COM_OBJECT_IN_FREED_MEMORY = 1036;

        /// APPLICATION_VERIFIER_COM_NULL_DACL -> 0x0406
        public const int APPLICATION_VERIFIER_COM_NULL_DACL = 1030;

        /// APPLICATION_VERIFIER_COM_HOLDING_LOCKS_ON_CALL -> 0x0410
        public const int APPLICATION_VERIFIER_COM_HOLDING_LOCKS_ON_CALL = 1040;

        /// APPLICATION_VERIFIER_COM_GCO_SUCCESS_WITH_NULL -> 0x040B
        public const int APPLICATION_VERIFIER_COM_GCO_SUCCESS_WITH_NULL = 1035;

        /// APPLICATION_VERIFIER_COM_ERROR -> 0x0400
        public const int APPLICATION_VERIFIER_COM_ERROR = 1024;

        /// APPLICATION_VERIFIER_COM_CF_SUCCESS_WITH_NULL -> 0x040A
        public const int APPLICATION_VERIFIER_COM_CF_SUCCESS_WITH_NULL = 1034;

        /// APPLICATION_VERIFIER_COM_API_IN_DLLMAIN -> 0x0401
        public const int APPLICATION_VERIFIER_COM_API_IN_DLLMAIN = 1025;

        /// APPLICATION_VERIFIER_BAD_HEAP_HANDLE -> 0x0005
        public const int APPLICATION_VERIFIER_BAD_HEAP_HANDLE = 5;

        /// APPLICATION_VERIFIER_ACCESS_VIOLATION -> 0x0002
        public const int APPLICATION_VERIFIER_ACCESS_VIOLATION = 2;

        /// APPLICATION_ERROR_MASK -> 0x20000000
        public const int APPLICATION_ERROR_MASK = 536870912;

        /// AppendMenu -> AppendMenuW
        /// Error generating expression: Value AppendMenuW is not resolved
        public const string AppendMenu = "AppendMenuW";

        /// APPCOMMAND_VOLUME_UP -> 10
        public const int APPCOMMAND_VOLUME_UP = 10;

        /// APPCOMMAND_VOLUME_MUTE -> 8
        public const int APPCOMMAND_VOLUME_MUTE = 8;

        /// APPCOMMAND_VOLUME_DOWN -> 9
        public const int APPCOMMAND_VOLUME_DOWN = 9;

        /// APPCOMMAND_UNDO -> 34
        public const int APPCOMMAND_UNDO = 34;

        /// APPCOMMAND_TREBLE_UP -> 23
        public const int APPCOMMAND_TREBLE_UP = 23;

        /// APPCOMMAND_TREBLE_DOWN -> 22
        public const int APPCOMMAND_TREBLE_DOWN = 22;

        /// APPCOMMAND_SPELL_CHECK -> 42
        public const int APPCOMMAND_SPELL_CHECK = 42;

        /// APPCOMMAND_SEND_MAIL -> 41
        public const int APPCOMMAND_SEND_MAIL = 41;

        /// APPCOMMAND_SAVE -> 32
        public const int APPCOMMAND_SAVE = 32;

        /// APPCOMMAND_REPLY_TO_MAIL -> 39
        public const int APPCOMMAND_REPLY_TO_MAIL = 39;

        /// APPCOMMAND_REDO -> 35
        public const int APPCOMMAND_REDO = 35;

        /// APPCOMMAND_PRINT -> 33
        public const int APPCOMMAND_PRINT = 33;

        /// APPCOMMAND_PASTE -> 38
        public const int APPCOMMAND_PASTE = 38;

        /// APPCOMMAND_OPEN -> 30
        public const int APPCOMMAND_OPEN = 30;

        /// APPCOMMAND_NEW -> 29
        public const int APPCOMMAND_NEW = 29;

        /// APPCOMMAND_MIC_ON_OFF_TOGGLE -> 44
        public const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 44;

        /// APPCOMMAND_MICROPHONE_VOLUME_UP -> 26
        public const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26;

        /// APPCOMMAND_MICROPHONE_VOLUME_MUTE -> 24
        public const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 24;

        /// APPCOMMAND_MICROPHONE_VOLUME_DOWN -> 25
        public const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25;

        /// APPCOMMAND_MEDIA_STOP -> 13
        public const int APPCOMMAND_MEDIA_STOP = 13;

        /// APPCOMMAND_MEDIA_REWIND -> 50
        public const int APPCOMMAND_MEDIA_REWIND = 50;

        /// APPCOMMAND_MEDIA_RECORD -> 48
        public const int APPCOMMAND_MEDIA_RECORD = 48;

        /// APPCOMMAND_MEDIA_PREVIOUSTRACK -> 12
        public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 12;

        /// APPCOMMAND_MEDIA_PLAY_PAUSE -> 14
        public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14;

        /// APPCOMMAND_MEDIA_PLAY -> 46
        public const int APPCOMMAND_MEDIA_PLAY = 46;

        /// APPCOMMAND_MEDIA_PAUSE -> 47
        public const int APPCOMMAND_MEDIA_PAUSE = 47;

        /// APPCOMMAND_MEDIA_NEXTTRACK -> 11
        public const int APPCOMMAND_MEDIA_NEXTTRACK = 11;

        /// APPCOMMAND_MEDIA_FAST_FORWARD -> 49
        public const int APPCOMMAND_MEDIA_FAST_FORWARD = 49;

        /// APPCOMMAND_MEDIA_CHANNEL_UP -> 51
        public const int APPCOMMAND_MEDIA_CHANNEL_UP = 51;

        /// APPCOMMAND_MEDIA_CHANNEL_DOWN -> 52
        public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 52;

        /// APPCOMMAND_LAUNCH_MEDIA_SELECT -> 16
        public const int APPCOMMAND_LAUNCH_MEDIA_SELECT = 16;

        /// APPCOMMAND_LAUNCH_MAIL -> 15
        public const int APPCOMMAND_LAUNCH_MAIL = 15;

        /// APPCOMMAND_LAUNCH_APP2 -> 18
        public const int APPCOMMAND_LAUNCH_APP2 = 18;

        /// APPCOMMAND_LAUNCH_APP1 -> 17
        public const int APPCOMMAND_LAUNCH_APP1 = 17;

        /// APPCOMMAND_HELP -> 27
        public const int APPCOMMAND_HELP = 27;

        /// APPCOMMAND_FORWARD_MAIL -> 40
        public const int APPCOMMAND_FORWARD_MAIL = 40;

        /// APPCOMMAND_FIND -> 28
        public const int APPCOMMAND_FIND = 28;

        /// APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE -> 43
        public const int APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE = 43;

        /// APPCOMMAND_CUT -> 37
        public const int APPCOMMAND_CUT = 37;

        /// APPCOMMAND_CORRECTION_LIST -> 45
        public const int APPCOMMAND_CORRECTION_LIST = 45;

        /// APPCOMMAND_COPY -> 36
        public const int APPCOMMAND_COPY = 36;

        /// APPCOMMAND_CLOSE -> 31
        public const int APPCOMMAND_CLOSE = 31;

        /// APPCOMMAND_BROWSER_STOP -> 4
        public const int APPCOMMAND_BROWSER_STOP = 4;

        /// APPCOMMAND_BROWSER_SEARCH -> 5
        public const int APPCOMMAND_BROWSER_SEARCH = 5;

        /// APPCOMMAND_BROWSER_REFRESH -> 3
        public const int APPCOMMAND_BROWSER_REFRESH = 3;

        /// APPCOMMAND_BROWSER_HOME -> 7
        public const int APPCOMMAND_BROWSER_HOME = 7;

        /// APPCOMMAND_BROWSER_FORWARD -> 2
        public const int APPCOMMAND_BROWSER_FORWARD = 2;

        /// APPCOMMAND_BROWSER_FAVORITES -> 6
        public const int APPCOMMAND_BROWSER_FAVORITES = 6;

        /// APPCOMMAND_BROWSER_BACKWARD -> 1
        public const int APPCOMMAND_BROWSER_BACKWARD = 1;

        /// APPCOMMAND_BASS_UP -> 21
        public const int APPCOMMAND_BASS_UP = 21;

        /// APPCOMMAND_BASS_DOWN -> 19
        public const int APPCOMMAND_BASS_DOWN = 19;

        /// APPCOMMAND_BASS_BOOST -> 20
        public const int APPCOMMAND_BASS_BOOST = 20;

        /// APPCMD_MASK -> 0x00000FF0L
        public const int APPCMD_MASK = 4080;

        /// APPCMD_FILTERINITS -> 0x00000020L
        public const int APPCMD_FILTERINITS = 32;

        /// APPCMD_CLIENTONLY -> 0x00000010L
        public const int APPCMD_CLIENTONLY = 16;

        /// APPCLASS_STANDARD -> 0x00000000L
        public const int APPCLASS_STANDARD = 0;

        /// APPCLASS_MONITOR -> 0x00000001L
        public const int APPCLASS_MONITOR = 1;

        /// APPCLASS_MASK -> 0x0000000FL
        public const int APPCLASS_MASK = 15;

        /// APIPRIVATE -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string APIPRIVATE = "__stdcall";

        /// APIENTRY -> WINAPI
        public const string APIENTRY = NativeConstants.WINAPI;

        /// APD_STRICT_UPGRADE -> 0x00000001
        public const int APD_STRICT_UPGRADE = 1;

        /// APD_STRICT_DOWNGRADE -> 0x00000002
        public const int APD_STRICT_DOWNGRADE = 2;

        /// APD_COPY_NEW_FILES -> 0x00000008
        public const int APD_COPY_NEW_FILES = 8;

        /// APD_COPY_FROM_DIRECTORY -> 0x00000010
        public const int APD_COPY_FROM_DIRECTORY = 16;

        /// APD_COPY_ALL_FILES -> 0x00000004
        public const int APD_COPY_ALL_FILES = 4;

        /// ANYSIZE_ARRAY -> 1
        public const int ANYSIZE_ARRAY = 1;

        /// ANTIALIASED_QUALITY -> 4
        public const int ANTIALIASED_QUALITY = 4;

        /// ANSI_VAR_FONT -> 12
        public const int ANSI_VAR_FONT = 12;

        /// ANSI_FIXED_FONT -> 11
        public const int ANSI_FIXED_FONT = 11;

        /// ANSI_CHARSET -> 0
        public const int ANSI_CHARSET = 0;

        /// AnsiUpperBuff -> CharUpperBuffA
        /// Error generating expression: Value CharUpperBuffA is not resolved
        public const string AnsiUpperBuff = "CharUpperBuffA";

        /// AnsiUpper -> CharUpperA
        /// Error generating expression: Value CharUpperA is not resolved
        public const string AnsiUpper = "CharUpperA";

        /// AnsiToOemBuff -> CharToOemBuffA
        /// Error generating expression: Value CharToOemBuffA is not resolved
        public const string AnsiToOemBuff = "CharToOemBuffA";

        /// AnsiToOem -> CharToOemA
        /// Error generating expression: Value CharToOemA is not resolved
        public const string AnsiToOem = "CharToOemA";

        /// AnsiPrev -> CharPrevA
        /// Error generating expression: Value CharPrevA is not resolved
        public const string AnsiPrev = "CharPrevA";

        /// AnsiNext -> CharNextA
        /// Error generating expression: Value CharNextA is not resolved
        public const string AnsiNext = "CharNextA";

        /// AnsiLowerBuff -> CharLowerBuffA
        /// Error generating expression: Value CharLowerBuffA is not resolved
        public const string AnsiLowerBuff = "CharLowerBuffA";

        /// AnsiLower -> CharLowerA
        /// Error generating expression: Value CharLowerA is not resolved
        public const string AnsiLower = "CharLowerA";

        /// ALTERNATE -> 1
        public const int ALTERNATE = 1;

        /// ALL_TRANSPORTS -> "M\0\0\0"
        public const string ALL_TRANSPORTS = "M\\0\\0\\0";

        /// ALG_TYPE_STREAM -> (4 << 9)
        public const int ALG_TYPE_STREAM = (4) << (9);

        /// ALG_TYPE_SECURECHANNEL -> (6 << 9)
        public const int ALG_TYPE_SECURECHANNEL = (6) << (9);

        /// ALG_TYPE_RSA -> (2 << 9)
        public const int ALG_TYPE_RSA = (2) << (9);

        /// ALG_TYPE_DSS -> (1 << 9)
        public const int ALG_TYPE_DSS = (1) << (9);

        /// ALG_TYPE_DH -> (5 << 9)
        public const int ALG_TYPE_DH = (5) << (9);

        /// ALG_TYPE_BLOCK -> (3 << 9)
        public const int ALG_TYPE_BLOCK = (3) << (9);

        /// ALG_TYPE_ANY -> (0)
        public const int ALG_TYPE_ANY = 0;

        /// ALG_SID_TLS1_MASTER -> 6
        public const int ALG_SID_TLS1_MASTER = 6;

        /// ALG_SID_TLS1PRF -> 10
        public const int ALG_SID_TLS1PRF = 10;

        /// ALG_SID_TEK -> 11
        public const int ALG_SID_TEK = 11;

        /// ALG_SID_SSL3_MASTER -> 1
        public const int ALG_SID_SSL3_MASTER = 1;

        /// ALG_SID_SSL3SHAMD5 -> 8
        public const int ALG_SID_SSL3SHAMD5 = 8;

        /// ALG_SID_SSL2_MASTER -> 5
        public const int ALG_SID_SSL2_MASTER = 5;

        /// ALG_SID_SKIPJACK -> 10
        public const int ALG_SID_SKIPJACK = 10;

        /// ALG_SID_SHA_512 -> 14
        public const int ALG_SID_SHA_512 = 14;

        /// ALG_SID_SHA_384 -> 13
        public const int ALG_SID_SHA_384 = 13;

        /// ALG_SID_SHA_256 -> 12
        public const int ALG_SID_SHA_256 = 12;

        /// ALG_SID_SHA1 -> 4
        public const int ALG_SID_SHA1 = 4;

        /// ALG_SID_SHA -> 4
        public const int ALG_SID_SHA = 4;

        /// ALG_SID_SEAL -> 2
        public const int ALG_SID_SEAL = 2;

        /// ALG_SID_SCHANNEL_MASTER_HASH -> 2
        public const int ALG_SID_SCHANNEL_MASTER_HASH = 2;

        /// ALG_SID_SCHANNEL_MAC_KEY -> 3
        public const int ALG_SID_SCHANNEL_MAC_KEY = 3;

        /// ALG_SID_SCHANNEL_ENC_KEY -> 7
        public const int ALG_SID_SCHANNEL_ENC_KEY = 7;

        /// ALG_SID_SAFERSK64 -> 7
        public const int ALG_SID_SAFERSK64 = 7;

        /// ALG_SID_SAFERSK128 -> 8
        public const int ALG_SID_SAFERSK128 = 8;

        /// ALG_SID_RSA_PKCS -> 1
        public const int ALG_SID_RSA_PKCS = 1;

        /// ALG_SID_RSA_PGP -> 4
        public const int ALG_SID_RSA_PGP = 4;

        /// ALG_SID_RSA_MSATWORK -> 2
        public const int ALG_SID_RSA_MSATWORK = 2;

        /// ALG_SID_RSA_ENTRUST -> 3
        public const int ALG_SID_RSA_ENTRUST = 3;

        /// ALG_SID_RSA_ANY -> 0
        public const int ALG_SID_RSA_ANY = 0;

        /// ALG_SID_RIPEMD160 -> 7
        public const int ALG_SID_RIPEMD160 = 7;

        /// ALG_SID_RIPEMD -> 6
        public const int ALG_SID_RIPEMD = 6;

        /// ALG_SID_RC5 -> 13
        public const int ALG_SID_RC5 = 13;

        /// ALG_SID_RC4 -> 1
        public const int ALG_SID_RC4 = 1;

        /// ALG_SID_RC2 -> 2
        public const int ALG_SID_RC2 = 2;

        /// ALG_SID_PCT1_MASTER -> 4
        public const int ALG_SID_PCT1_MASTER = 4;

        /// ALG_SID_MD5 -> 3
        public const int ALG_SID_MD5 = 3;

        /// ALG_SID_MD4 -> 2
        public const int ALG_SID_MD4 = 2;

        /// ALG_SID_MD2 -> 1
        public const int ALG_SID_MD2 = 1;

        /// ALG_SID_MAC -> 5
        public const int ALG_SID_MAC = 5;

        /// ALG_SID_KEA -> 4
        public const int ALG_SID_KEA = 4;

        /// ALG_SID_IDEA -> 5
        public const int ALG_SID_IDEA = 5;

        /// ALG_SID_HMAC -> 9
        public const int ALG_SID_HMAC = 9;

        /// ALG_SID_HASH_REPLACE_OWF -> 11
        public const int ALG_SID_HASH_REPLACE_OWF = 11;

        /// ALG_SID_EXAMPLE -> 80
        public const int ALG_SID_EXAMPLE = 80;

        /// ALG_SID_DSS_PKCS -> 1
        public const int ALG_SID_DSS_PKCS = 1;

        /// ALG_SID_DSS_DMS -> 2
        public const int ALG_SID_DSS_DMS = 2;

        /// ALG_SID_DSS_ANY -> 0
        public const int ALG_SID_DSS_ANY = 0;

        /// ALG_SID_DH_SANDF -> 1
        public const int ALG_SID_DH_SANDF = 1;

        /// ALG_SID_DH_EPHEM -> 2
        public const int ALG_SID_DH_EPHEM = 2;

        /// ALG_SID_DESX -> 4
        public const int ALG_SID_DESX = 4;

        /// ALG_SID_DES -> 1
        public const int ALG_SID_DES = 1;

        /// ALG_SID_CYLINK_MEK -> 12
        public const int ALG_SID_CYLINK_MEK = 12;

        /// ALG_SID_CAST -> 6
        public const int ALG_SID_CAST = 6;

        /// ALG_SID_ANY -> (0)
        public const int ALG_SID_ANY = 0;

        /// ALG_SID_AGREED_KEY_ANY -> 3
        public const int ALG_SID_AGREED_KEY_ANY = 3;

        /// ALG_SID_AES_256 -> 16
        public const int ALG_SID_AES_256 = 16;

        /// ALG_SID_AES_192 -> 15
        public const int ALG_SID_AES_192 = 15;

        /// ALG_SID_AES_128 -> 14
        public const int ALG_SID_AES_128 = 14;

        /// ALG_SID_AES -> 17
        public const int ALG_SID_AES = 17;

        /// ALG_SID_3DES_112 -> 9
        public const int ALG_SID_3DES_112 = 9;

        /// ALG_SID_3DES -> 3
        public const int ALG_SID_3DES = 3;

        /// ALG_CLASS_SIGNATURE -> (1 << 13)
        public const int ALG_CLASS_SIGNATURE = (1) << (13);

        /// ALG_CLASS_MSG_ENCRYPT -> (2 << 13)
        public const int ALG_CLASS_MSG_ENCRYPT = (2) << (13);

        /// ALG_CLASS_KEY_EXCHANGE -> (5 << 13)
        public const int ALG_CLASS_KEY_EXCHANGE = (5) << (13);

        /// ALG_CLASS_HASH -> (4 << 13)
        public const int ALG_CLASS_HASH = (4) << (13);

        /// ALG_CLASS_DATA_ENCRYPT -> (3 << 13)
        public const int ALG_CLASS_DATA_ENCRYPT = (3) << (13);

        /// ALG_CLASS_ANY -> (0)
        public const int ALG_CLASS_ANY = 0;

        /// ALG_CLASS_ALL -> (7 << 13)
        public const int ALG_CLASS_ALL = (7) << (13);

        /// ALERT_SYSTEM_WARNING -> 2
        public const int ALERT_SYSTEM_WARNING = 2;

        /// ALERT_SYSTEM_QUERY -> 4
        public const int ALERT_SYSTEM_QUERY = 4;

        /// ALERT_SYSTEM_INFORMATIONAL -> 1
        public const int ALERT_SYSTEM_INFORMATIONAL = 1;

        /// ALERT_SYSTEM_ERROR -> 3
        public const int ALERT_SYSTEM_ERROR = 3;

        /// ALERT_SYSTEM_CRITICAL -> 5
        public const int ALERT_SYSTEM_CRITICAL = 5;

        /// AF_VOICEVIEW -> 18
        public const int AF_VOICEVIEW = 18;

        /// AF_UNSPEC -> 0
        public const int AF_UNSPEC = 0;

        /// AF_UNKNOWN1 -> 20
        public const int AF_UNKNOWN1 = 20;

        /// AF_UNIX -> 1
        public const int AF_UNIX = 1;

        /// AF_SNA -> 11
        public const int AF_SNA = 11;

        /// AF_PUP -> 4
        public const int AF_PUP = 4;

        /// AF_OSI -> AF_ISO
        public const int AF_OSI = NativeConstants.AF_ISO;

        /// AF_NS -> 6
        public const int AF_NS = 6;

        /// AF_NETBIOS -> 17
        public const int AF_NETBIOS = 17;

        /// AF_MAX -> 22
        public const int AF_MAX = 22;

        /// AF_LAT -> 14
        public const int AF_LAT = 14;

        /// AF_ISO -> 7
        public const int AF_ISO = 7;

        /// AF_IPX -> 6
        public const int AF_IPX = 6;

        /// AF_INET -> 2
        public const int AF_INET = 2;

        /// AF_IMPLINK -> 3
        public const int AF_IMPLINK = 3;

        /// AF_HYLINK -> 15
        public const int AF_HYLINK = 15;

        /// AF_FIREFOX -> 19
        public const int AF_FIREFOX = 19;

        /// AF_ECMA -> 8
        public const int AF_ECMA = 8;

        /// AF_DLI -> 13
        public const int AF_DLI = 13;

        /// AF_DECnet -> 12
        public const int AF_DECnet = 12;

        /// AF_DATAKIT -> 9
        public const int AF_DATAKIT = 9;

        /// AF_CHAOS -> 5
        public const int AF_CHAOS = 5;

        /// AF_CCITT -> 10
        public const int AF_CCITT = 10;

        /// AF_BAN -> 21
        public const int AF_BAN = 21;

        /// AF_APPLETALK -> 16
        public const int AF_APPLETALK = 16;

        /// AD_COUNTERCLOCKWISE -> 1
        public const int AD_COUNTERCLOCKWISE = 1;

        /// AD_CLOCKWISE -> 2
        public const int AD_CLOCKWISE = 2;

        /// AdvancedDocumentProperties -> AdvancedDocumentPropertiesW
        /// Error generating expression: Value AdvancedDocumentPropertiesW is not resolved
        public const string AdvancedDocumentProperties = "AdvancedDocumentPropertiesW";

        /// ADDRESS_TAG_BIT -> 0x80000000UL
        public const uint ADDRESS_TAG_BIT = 2147483648u;

        /// AddPrintProvidor -> AddPrintProvidorW
        /// Error generating expression: Value AddPrintProvidorW is not resolved
        public const string AddPrintProvidor = "AddPrintProvidorW";

        /// AddPrintProcessor -> AddPrintProcessorW
        /// Error generating expression: Value AddPrintProcessorW is not resolved
        public const string AddPrintProcessor = "AddPrintProcessorW";

        /// AddPrinterDriverEx -> AddPrinterDriverExW
        /// Error generating expression: Value AddPrinterDriverExW is not resolved
        public const string AddPrinterDriverEx = "AddPrinterDriverExW";

        /// AddPrinterDriver -> AddPrinterDriverW
        /// Error generating expression: Value AddPrinterDriverW is not resolved
        public const string AddPrinterDriver = "AddPrinterDriverW";

        /// AddPrinterConnection -> AddPrinterConnectionW
        /// Error generating expression: Value AddPrinterConnectionW is not resolved
        public const string AddPrinterConnection = "AddPrinterConnectionW";

        /// AddPrinter -> AddPrinterW
        /// Error generating expression: Value AddPrinterW is not resolved
        public const string AddPrinter = "AddPrinterW";

        /// AddPort -> AddPortW
        /// Error generating expression: Value AddPortW is not resolved
        public const string AddPort = "AddPortW";

        /// AddMonitor -> AddMonitorW
        /// Error generating expression: Value AddMonitorW is not resolved
        public const string AddMonitor = "AddMonitorW";

        /// AddJob -> AddJobW
        /// Error generating expression: Value AddJobW is not resolved
        public const string AddJob = "AddJobW";

        /// AddForm -> AddFormW
        /// Error generating expression: Value AddFormW is not resolved
        public const string AddForm = "AddFormW";

        /// AddFontResourceEx -> AddFontResourceExW
        /// Error generating expression: Value AddFontResourceExW is not resolved
        public const string AddFontResourceEx = "AddFontResourceExW";

        /// AddFontResource -> AddFontResourceW
        /// Error generating expression: Value AddFontResourceW is not resolved
        public const string AddFontResource = "AddFontResourceW";

        /// AddConsoleAlias -> AddConsoleAliasW
        /// Error generating expression: Value AddConsoleAliasW is not resolved
        public const string AddConsoleAlias = "AddConsoleAliasW";

        /// AddAtom -> AddAtomW
        /// Error generating expression: Value AddAtomW is not resolved
        public const string AddAtom = "AddAtomW";

        /// AC_SRC_OVER -> 0x00
        public const int AC_SRC_OVER = 0;

        /// AC_SRC_ALPHA -> 0x01
        public const int AC_SRC_ALPHA = 1;

        /// AC_LINE_UNKNOWN -> 0xFF
        public const int AC_LINE_UNKNOWN = 255;

        /// AC_LINE_ONLINE -> 0x01
        public const int AC_LINE_ONLINE = 1;

        /// AC_LINE_OFFLINE -> 0x00
        public const int AC_LINE_OFFLINE = 0;

        /// AC_LINE_BACKUP_POWER -> 0x02
        public const int AC_LINE_BACKUP_POWER = 2;

        /// ACTIVEOBJECT_WEAK -> 0x1
        public const int ACTIVEOBJECT_WEAK = 1;

        /// ACTIVEOBJECT_STRONG -> 0x0
        public const int ACTIVEOBJECT_STRONG = 0;

        /// ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION -> (3)
        public const int ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION = 3;

        /// ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE -> (8)
        public const int ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE = 8;

        /// ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION -> (2)
        public const int ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION = 2;

        /// ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION -> (6)
        public const int ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION = 6;

        /// ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION -> (4)
        public const int ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION = 4;

        /// ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION -> (7)
        public const int ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION = 7;

        /// ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION -> (5)
        public const int ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION = 5;

        /// ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES -> (9)
        public const int ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES = 9;

        /// ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION -> (1)
        public const int ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION = 1;

        /// ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE -> (2)
        public const int ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE = 2;

        /// ACTIVATION_CONTEXT_PATH_TYPE_URL -> (3)
        public const int ACTIVATION_CONTEXT_PATH_TYPE_URL = 3;

        /// ACTIVATION_CONTEXT_PATH_TYPE_NONE -> (1)
        public const int ACTIVATION_CONTEXT_PATH_TYPE_NONE = 1;

        /// ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF -> (4)
        public const int ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF = 4;

        /// ACTIVATION_CONTEXT_BASIC_INFORMATION_DEFINED -> 1
        public const int ACTIVATION_CONTEXT_BASIC_INFORMATION_DEFINED = 1;

        /// ACTIVATIONCONTEXTINFOCLASS -> ACTIVATION_CONTEXT_INFO_CLASS
        /// Error generating expression: Value ACTIVATION_CONTEXT_INFO_CLASS is not resolved
        public const string ACTIVATIONCONTEXTINFOCLASS = "ACTIVATION_CONTEXT_INFO_CLASS";

        /// ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF -> (0x00000040)
        public const int ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF = 64;

        /// ACTCTX_FLAG_SET_PROCESS_DEFAULT -> (0x00000010)
        public const int ACTCTX_FLAG_SET_PROCESS_DEFAULT = 16;

        /// ACTCTX_FLAG_RESOURCE_NAME_VALID -> (0x00000008)
        public const int ACTCTX_FLAG_RESOURCE_NAME_VALID = 8;

        /// ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID -> (0x00000001)
        public const int ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID = 1;

        /// ACTCTX_FLAG_LANGID_VALID -> (0x00000002)
        public const int ACTCTX_FLAG_LANGID_VALID = 2;

        /// ACTCTX_FLAG_HMODULE_VALID -> (0x00000080)
        public const int ACTCTX_FLAG_HMODULE_VALID = 128;

        /// ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID -> (0x00000004)
        public const int ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = 4;

        /// ACTCTX_FLAG_APPLICATION_NAME_VALID -> (0x00000020)
        public const int ACTCTX_FLAG_APPLICATION_NAME_VALID = 32;

        /// ACL_REVISION_DS -> (4)
        public const int ACL_REVISION_DS = 4;

        /// ACL_REVISION4 -> (4)
        public const int ACL_REVISION4 = 4;

        /// ACL_REVISION3 -> (3)
        public const int ACL_REVISION3 = 3;

        /// ACL_REVISION2 -> (2)
        public const int ACL_REVISION2 = 2;

        /// ACL_REVISION1 -> (1)
        public const int ACL_REVISION1 = 1;

        /// ACL_REVISION -> (2)
        public const int ACL_REVISION = 2;

        /// ACE_OBJECT_TYPE_PRESENT -> 0x1
        public const int ACE_OBJECT_TYPE_PRESENT = 1;

        /// ACE_INHERITED_OBJECT_TYPE_PRESENT -> 0x2
        public const int ACE_INHERITED_OBJECT_TYPE_PRESENT = 2;

        /// ACCESS_SYSTEM_SECURITY -> (0x01000000L)
        public const int ACCESS_SYSTEM_SECURITY = 16777216;

        /// ACCESS_STICKYKEYS -> 0x0001
        public const int ACCESS_STICKYKEYS = 1;

        /// ACCESS_PROPERTY_SET_GUID -> 1
        public const int ACCESS_PROPERTY_SET_GUID = 1;

        /// ACCESS_PROPERTY_GUID -> 2
        public const int ACCESS_PROPERTY_GUID = 2;

        /// ACCESS_OBJECT_GUID -> 0
        public const int ACCESS_OBJECT_GUID = 0;

        /// ACCESS_MOUSEKEYS -> 0x0003
        public const int ACCESS_MOUSEKEYS = 3;

        /// ACCESS_MIN_MS_OBJECT_ACE_TYPE -> (0x5)
        public const int ACCESS_MIN_MS_OBJECT_ACE_TYPE = 5;

        /// ACCESS_MIN_MS_ACE_TYPE -> (0x0)
        public const int ACCESS_MIN_MS_ACE_TYPE = 0;

        /// ACCESS_MAX_MS_V5_ACE_TYPE -> (0x10)
        public const int ACCESS_MAX_MS_V5_ACE_TYPE = 16;

        /// ACCESS_MAX_MS_V4_ACE_TYPE -> (0x8)
        public const int ACCESS_MAX_MS_V4_ACE_TYPE = 8;

        /// ACCESS_MAX_MS_V3_ACE_TYPE -> (0x4)
        public const int ACCESS_MAX_MS_V3_ACE_TYPE = 4;

        /// ACCESS_MAX_MS_V2_ACE_TYPE -> (0x3)
        public const int ACCESS_MAX_MS_V2_ACE_TYPE = 3;

        /// ACCESS_MAX_MS_OBJECT_ACE_TYPE -> (0x8)
        public const int ACCESS_MAX_MS_OBJECT_ACE_TYPE = 8;

        /// ACCESS_MAX_MS_ACE_TYPE -> (0x8)
        public const int ACCESS_MAX_MS_ACE_TYPE = 8;

        /// ACCESS_MAX_LEVEL -> 4
        public const int ACCESS_MAX_LEVEL = 4;

        /// ACCESS_FILTERKEYS -> 0x0002
        public const int ACCESS_FILTERKEYS = 2;

        /// ACCESS_DS_SOURCE_W -> L"DS"
        public const string ACCESS_DS_SOURCE_W = "DS";

        /// ACCESS_DS_SOURCE_A -> "DS"
        public const string ACCESS_DS_SOURCE_A = "DS";

        /// ACCESS_DS_OBJECT_TYPE_NAME_W -> L"Directory Service Object"
        public const string ACCESS_DS_OBJECT_TYPE_NAME_W = "Directory Service Object";

        /// ACCESS_DS_OBJECT_TYPE_NAME_A -> "Directory Service Object"
        public const string ACCESS_DS_OBJECT_TYPE_NAME_A = "Directory Service Object";

        /// ACCESS_DENIED_OBJECT_ACE_TYPE -> (0x6)
        public const int ACCESS_DENIED_OBJECT_ACE_TYPE = 6;

        /// ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE -> (0xC)
        public const int ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE = 12;

        /// ACCESS_DENIED_CALLBACK_ACE_TYPE -> (0xA)
        public const int ACCESS_DENIED_CALLBACK_ACE_TYPE = 10;

        /// ACCESS_DENIED_ACE_TYPE -> (0x1)
        public const int ACCESS_DENIED_ACE_TYPE = 1;

        /// ACCESS_ALLOWED_OBJECT_ACE_TYPE -> (0x5)
        public const int ACCESS_ALLOWED_OBJECT_ACE_TYPE = 5;

        /// ACCESS_ALLOWED_COMPOUND_ACE_TYPE -> (0x4)
        public const int ACCESS_ALLOWED_COMPOUND_ACE_TYPE = 4;

        /// ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE -> (0xB)
        public const int ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE = 11;

        /// ACCESS_ALLOWED_CALLBACK_ACE_TYPE -> (0x9)
        public const int ACCESS_ALLOWED_CALLBACK_ACE_TYPE = 9;

        /// ACCESS_ALLOWED_ACE_TYPE -> (0x0)
        public const int ACCESS_ALLOWED_ACE_TYPE = 0;

        /// AccessCheckByTypeResultListAndAuditAlarmByHandle -> AccessCheckByTypeResultListAndAuditAlarmByHandleW
        /// Error generating expression: Value AccessCheckByTypeResultListAndAuditAlarmByHandleW is not resolved
        public const string AccessCheckByTypeResultListAndAuditAlarmByHandle = "AccessCheckByTypeResultListAndAuditAlarmByHandleW";

        /// AccessCheckByTypeResultListAndAuditAlarm -> AccessCheckByTypeResultListAndAuditAlarmW
        /// Error generating expression: Value AccessCheckByTypeResultListAndAuditAlarmW is not resolved
        public const string AccessCheckByTypeResultListAndAuditAlarm = "AccessCheckByTypeResultListAndAuditAlarmW";

        /// AccessCheckByTypeAndAuditAlarm -> AccessCheckByTypeAndAuditAlarmW
        /// Error generating expression: Value AccessCheckByTypeAndAuditAlarmW is not resolved
        public const string AccessCheckByTypeAndAuditAlarm = "AccessCheckByTypeAndAuditAlarmW";

        /// AccessCheckAndAuditAlarm -> AccessCheckAndAuditAlarmW
        /// Error generating expression: Value AccessCheckAndAuditAlarmW is not resolved
        public const string AccessCheckAndAuditAlarm = "AccessCheckAndAuditAlarmW";

        /// ABS_AUTOHIDE -> 0x0000001
        public const int ABS_AUTOHIDE = 1;

        /// ABS_ALWAYSONTOP -> 0x0000002
        public const int ABS_ALWAYSONTOP = 2;

        /// ABSOLUTE -> 1
        public const int ABSOLUTE = 1;

        /// ABOVE_NORMAL_PRIORITY_CLASS -> 0x00008000
        public const int ABOVE_NORMAL_PRIORITY_CLASS = 32768;

        /// AbortSystemShutdown -> AbortSystemShutdownW
        /// Error generating expression: Value AbortSystemShutdownW is not resolved
        public const string AbortSystemShutdown = "AbortSystemShutdownW";

        /// ABORTDOC -> 2
        public const int ABORTDOC = 2;

        /// ABN_WINDOWARRANGE -> 0x0000003
        public const int ABN_WINDOWARRANGE = 3;

        /// ABN_STATECHANGE -> 0x0000000
        public const int ABN_STATECHANGE = 0;

        /// ABN_POSCHANGED -> 0x0000001
        public const int ABN_POSCHANGED = 1;

        /// ABN_FULLSCREENAPP -> 0x0000002
        public const int ABN_FULLSCREENAPP = 2;

        /// abnormal_termination -> _abnormal_termination
        /// Error generating expression: Value _abnormal_termination is not resolved
        public const string abnormal_termination = "_abnormal_termination";

        /// AbnormalTermination -> _abnormal_termination
        /// Error generating expression: Value _abnormal_termination is not resolved
        public const string AbnormalTermination = "_abnormal_termination";

        /// ABM_WINDOWPOSCHANGED -> 0x0000009
        public const int ABM_WINDOWPOSCHANGED = 9;

        /// ABM_SETSTATE -> 0x0000000a
        public const int ABM_SETSTATE = 10;

        /// ABM_SETPOS -> 0x00000003
        public const int ABM_SETPOS = 3;

        /// ABM_SETAUTOHIDEBAR -> 0x00000008
        public const int ABM_SETAUTOHIDEBAR = 8;

        /// ABM_REMOVE -> 0x00000001
        public const int ABM_REMOVE = 1;

        /// ABM_QUERYPOS -> 0x00000002
        public const int ABM_QUERYPOS = 2;

        /// ABM_NEW -> 0x00000000
        public const int ABM_NEW = 0;

        /// ABM_GETTASKBARPOS -> 0x00000005
        public const int ABM_GETTASKBARPOS = 5;

        /// ABM_GETSTATE -> 0x00000004
        public const int ABM_GETSTATE = 4;

        /// ABM_GETAUTOHIDEBAR -> 0x00000007
        public const int ABM_GETAUTOHIDEBAR = 7;

        /// ABM_ACTIVATE -> 0x00000006
        public const int ABM_ACTIVATE = 6;

        /// ABE_TOP -> 1
        public const int ABE_TOP = 1;

        /// ABE_RIGHT -> 2
        public const int ABE_RIGHT = 2;

        /// ABE_LEFT -> 0
        public const int ABE_LEFT = 0;

        /// ABE_BOTTOM -> 3
        public const int ABE_BOTTOM = 3;
    }

}
