namespace NWin32
{
    public partial class NativeConstants
    {

        /// JOY_USEDEADZONE -> 0x00000800l
        public const int JOY_USEDEADZONE = 2048;

        /// JOY_RETURNZ -> 0x00000004l
        public const int JOY_RETURNZ = 4;

        /// JOY_RETURNY -> 0x00000002l
        public const int JOY_RETURNY = 2;

        /// JOY_RETURNX -> 0x00000001l
        public const int JOY_RETURNX = 1;

        /// JOY_RETURNV -> 0x00000020l
        public const int JOY_RETURNV = 32;

        /// JOY_RETURNU -> 0x00000010l
        public const int JOY_RETURNU = 16;

        /// JOY_RETURNRAWDATA -> 0x00000100l
        public const int JOY_RETURNRAWDATA = 256;

        /// JOY_RETURNR -> 0x00000008l
        public const int JOY_RETURNR = 8;

        /// JOY_RETURNPOVCTS -> 0x00000200l
        public const int JOY_RETURNPOVCTS = 512;

        /// JOY_RETURNPOV -> 0x00000040l
        public const int JOY_RETURNPOV = 64;

        /// JOY_RETURNCENTERED -> 0x00000400l
        public const int JOY_RETURNCENTERED = 1024;

        /// JOY_RETURNBUTTONS -> 0x00000080l
        public const int JOY_RETURNBUTTONS = 128;

        /// JOY_RETURNALL -> (JOY_RETURNX | JOY_RETURNY | JOY_RETURNZ |                                  JOY_RETURNR | JOY_RETURNU | JOY_RETURNV |                                  JOY_RETURNPOV | JOY_RETURNBUTTONS)
        public const int JOY_RETURNALL = (NativeConstants.JOY_RETURNX
                    | (NativeConstants.JOY_RETURNY
                    | (NativeConstants.JOY_RETURNZ
                    | (NativeConstants.JOY_RETURNR
                    | (NativeConstants.JOY_RETURNU
                    | (NativeConstants.JOY_RETURNV
                    | (NativeConstants.JOY_RETURNPOV | NativeConstants.JOY_RETURNBUTTONS)))))));

        /// JOY_POVRIGHT -> 9000
        public const int JOY_POVRIGHT = 9000;

        /// JOY_POVLEFT -> 27000
        public const int JOY_POVLEFT = 27000;

        /// JOY_POVFORWARD -> 0
        public const int JOY_POVFORWARD = 0;

        /// JOY_POVBACKWARD -> 18000
        public const int JOY_POVBACKWARD = 18000;

        /// JOY_CAL_READZONLY -> 0x01000000l
        public const int JOY_CAL_READZONLY = 16777216;

        /// JOY_CAL_READYONLY -> 0x00200000l
        public const int JOY_CAL_READYONLY = 2097152;

        /// JOY_CAL_READXYONLY -> 0x00020000l
        public const int JOY_CAL_READXYONLY = 131072;

        /// JOY_CAL_READXONLY -> 0x00100000l
        public const int JOY_CAL_READXONLY = 1048576;

        /// JOY_CAL_READVONLY -> 0x08000000l
        public const int JOY_CAL_READVONLY = 134217728;

        /// JOY_CAL_READUONLY -> 0x04000000l
        public const int JOY_CAL_READUONLY = 67108864;

        /// JOY_CAL_READRONLY -> 0x02000000l
        public const int JOY_CAL_READRONLY = 33554432;

        /// JOY_CAL_READALWAYS -> 0x00010000l
        public const int JOY_CAL_READALWAYS = 65536;

        /// JOY_CAL_READ6 -> 0x00800000l
        public const int JOY_CAL_READ6 = 8388608;

        /// JOY_CAL_READ5 -> 0x00400000l
        public const int JOY_CAL_READ5 = 4194304;

        /// JOY_CAL_READ4 -> 0x00080000l
        public const int JOY_CAL_READ4 = 524288;

        /// JOY_CAL_READ3 -> 0x00040000l
        public const int JOY_CAL_READ3 = 262144;

        /// JOY_BUTTON9 -> 0x00000100l
        public const int JOY_BUTTON9 = 256;

        /// JOY_BUTTON8 -> 0x00000080l
        public const int JOY_BUTTON8 = 128;

        /// JOY_BUTTON7 -> 0x00000040l
        public const int JOY_BUTTON7 = 64;

        /// JOY_BUTTON6 -> 0x00000020l
        public const int JOY_BUTTON6 = 32;

        /// JOY_BUTTON5 -> 0x00000010l
        public const int JOY_BUTTON5 = 16;

        /// JOY_BUTTON4CHG -> 0x0800
        public const int JOY_BUTTON4CHG = 2048;

        /// JOY_BUTTON4 -> 0x0008
        public const int JOY_BUTTON4 = 8;

        /// JOY_BUTTON3CHG -> 0x0400
        public const int JOY_BUTTON3CHG = 1024;

        /// JOY_BUTTON32 -> 0x80000000l
        public const int JOY_BUTTON32 = -2147483648;

        /// JOY_BUTTON31 -> 0x40000000l
        public const int JOY_BUTTON31 = 1073741824;

        /// JOY_BUTTON30 -> 0x20000000l
        public const int JOY_BUTTON30 = 536870912;

        /// JOY_BUTTON3 -> 0x0004
        public const int JOY_BUTTON3 = 4;

        /// JOY_BUTTON2CHG -> 0x0200
        public const int JOY_BUTTON2CHG = 512;

        /// JOY_BUTTON29 -> 0x10000000l
        public const int JOY_BUTTON29 = 268435456;

        /// JOY_BUTTON28 -> 0x08000000l
        public const int JOY_BUTTON28 = 134217728;

        /// JOY_BUTTON27 -> 0x04000000l
        public const int JOY_BUTTON27 = 67108864;

        /// JOY_BUTTON26 -> 0x02000000l
        public const int JOY_BUTTON26 = 33554432;

        /// JOY_BUTTON25 -> 0x01000000l
        public const int JOY_BUTTON25 = 16777216;

        /// JOY_BUTTON24 -> 0x00800000l
        public const int JOY_BUTTON24 = 8388608;

        /// JOY_BUTTON23 -> 0x00400000l
        public const int JOY_BUTTON23 = 4194304;

        /// JOY_BUTTON22 -> 0x00200000l
        public const int JOY_BUTTON22 = 2097152;

        /// JOY_BUTTON21 -> 0x00100000l
        public const int JOY_BUTTON21 = 1048576;

        /// JOY_BUTTON20 -> 0x00080000l
        public const int JOY_BUTTON20 = 524288;

        /// JOY_BUTTON2 -> 0x0002
        public const int JOY_BUTTON2 = 2;

        /// JOY_BUTTON1CHG -> 0x0100
        public const int JOY_BUTTON1CHG = 256;

        /// JOY_BUTTON19 -> 0x00040000l
        public const int JOY_BUTTON19 = 262144;

        /// JOY_BUTTON18 -> 0x00020000l
        public const int JOY_BUTTON18 = 131072;

        /// JOY_BUTTON17 -> 0x00010000l
        public const int JOY_BUTTON17 = 65536;

        /// JOY_BUTTON16 -> 0x00008000l
        public const int JOY_BUTTON16 = 32768;

        /// JOY_BUTTON15 -> 0x00004000l
        public const int JOY_BUTTON15 = 16384;

        /// JOY_BUTTON14 -> 0x00002000l
        public const int JOY_BUTTON14 = 8192;

        /// JOY_BUTTON13 -> 0x00001000l
        public const int JOY_BUTTON13 = 4096;

        /// JOY_BUTTON12 -> 0x00000800l
        public const int JOY_BUTTON12 = 2048;

        /// JOY_BUTTON11 -> 0x00000400l
        public const int JOY_BUTTON11 = 1024;

        /// JOY_BUTTON10 -> 0x00000200l
        public const int JOY_BUTTON10 = 512;

        /// JOY_BUTTON1 -> 0x0001
        public const int JOY_BUTTON1 = 1;

        /// JOYSTICKID2 -> 1
        public const int JOYSTICKID2 = 1;

        /// JOYSTICKID1 -> 0
        public const int JOYSTICKID1 = 0;

        /// joyGetDevCaps -> joyGetDevCapsW
        /// Error generating expression: Value joyGetDevCapsW is not resolved
        public const string joyGetDevCaps = "joyGetDevCapsW";

        /// JOYERR_UNPLUGGED -> (JOYERR_BASE+7)
        public const int JOYERR_UNPLUGGED = (NativeConstants.JOYERR_BASE + 7);

        /// JOYERR_PARMS -> (JOYERR_BASE+5)
        public const int JOYERR_PARMS = (NativeConstants.JOYERR_BASE + 5);

        /// JOYERR_NOERROR -> (0)
        public const int JOYERR_NOERROR = 0;

        /// JOYERR_NOCANDO -> (JOYERR_BASE+6)
        public const int JOYERR_NOCANDO = (NativeConstants.JOYERR_BASE + 6);

        /// JOYERR_BASE -> 160
        public const int JOYERR_BASE = 160;

        /// JOYCAPS_POVCTS -> 0x0040
        public const int JOYCAPS_POVCTS = 64;

        /// JOYCAPS_POV4DIR -> 0x0020
        public const int JOYCAPS_POV4DIR = 32;

        /// JOYCAPS_HASZ -> 0x0001
        public const int JOYCAPS_HASZ = 1;

        /// JOYCAPS_HASV -> 0x0008
        public const int JOYCAPS_HASV = 8;

        /// JOYCAPS_HASU -> 0x0004
        public const int JOYCAPS_HASU = 4;

        /// JOYCAPS_HASR -> 0x0002
        public const int JOYCAPS_HASR = 2;

        /// JOYCAPS_HASPOV -> 0x0010
        public const int JOYCAPS_HASPOV = 16;

        /// JOHAB_CHARSET -> 130
        public const int JOHAB_CHARSET = 130;

        /// JOB_WRITE -> (STANDARD_RIGHTS_WRITE       |                                JOB_ACCESS_ADMINISTER)
        public const int JOB_WRITE = (NativeConstants.STANDARD_RIGHTS_WRITE | NativeConstants.JOB_ACCESS_ADMINISTER);

        /// JOB_STATUS_USER_INTERVENTION -> 0x00000400
        public const int JOB_STATUS_USER_INTERVENTION = 1024;

        /// JOB_STATUS_SPOOLING -> 0x00000008
        public const int JOB_STATUS_SPOOLING = 8;

        /// JOB_STATUS_RESTART -> 0x00000800
        public const int JOB_STATUS_RESTART = 2048;

        /// JOB_STATUS_PRINTING -> 0x00000010
        public const int JOB_STATUS_PRINTING = 16;

        /// JOB_STATUS_PRINTED -> 0x00000080
        public const int JOB_STATUS_PRINTED = 128;

        /// JOB_STATUS_PAUSED -> 0x00000001
        public const int JOB_STATUS_PAUSED = 1;

        /// JOB_STATUS_PAPEROUT -> 0x00000040
        public const int JOB_STATUS_PAPEROUT = 64;

        /// JOB_STATUS_OFFLINE -> 0x00000020
        public const int JOB_STATUS_OFFLINE = 32;

        /// JOB_STATUS_ERROR -> 0x00000002
        public const int JOB_STATUS_ERROR = 2;

        /// JOB_STATUS_DELETING -> 0x00000004
        public const int JOB_STATUS_DELETING = 4;

        /// JOB_STATUS_DELETED -> 0x00000100
        public const int JOB_STATUS_DELETED = 256;

        /// JOB_STATUS_COMPLETE -> 0x00001000
        public const int JOB_STATUS_COMPLETE = 4096;

        /// JOB_STATUS_BLOCKED_DEVQ -> 0x00000200
        public const int JOB_STATUS_BLOCKED_DEVQ = 512;

        /// JOB_READ -> (STANDARD_RIGHTS_READ        |                                JOB_ACCESS_READ)
        public const int JOB_READ = (NativeConstants.STANDARD_RIGHTS_READ | NativeConstants.JOB_ACCESS_READ);

        /// JOB_POSITION_UNSPECIFIED -> 0
        public const int JOB_POSITION_UNSPECIFIED = 0;

        /// JOB_OBJECT_UI_VALID_FLAGS -> 0x000000FF
        public const int JOB_OBJECT_UI_VALID_FLAGS = 255;

        /// JOB_OBJECT_UILIMIT_WRITECLIPBOARD -> 0x00000004
        public const int JOB_OBJECT_UILIMIT_WRITECLIPBOARD = 4;

        /// JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS -> 0x00000008
        public const int JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = 8;

        /// JOB_OBJECT_UILIMIT_READCLIPBOARD -> 0x00000002
        public const int JOB_OBJECT_UILIMIT_READCLIPBOARD = 2;

        /// JOB_OBJECT_UILIMIT_NONE -> 0x00000000
        public const int JOB_OBJECT_UILIMIT_NONE = 0;

        /// JOB_OBJECT_UILIMIT_HANDLES -> 0x00000001
        public const int JOB_OBJECT_UILIMIT_HANDLES = 1;

        /// JOB_OBJECT_UILIMIT_GLOBALATOMS -> 0x00000020
        public const int JOB_OBJECT_UILIMIT_GLOBALATOMS = 32;

        /// JOB_OBJECT_UILIMIT_EXITWINDOWS -> 0x00000080
        public const int JOB_OBJECT_UILIMIT_EXITWINDOWS = 128;

        /// JOB_OBJECT_UILIMIT_DISPLAYSETTINGS -> 0x00000010
        public const int JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = 16;

        /// JOB_OBJECT_UILIMIT_DESKTOP -> 0x00000040
        public const int JOB_OBJECT_UILIMIT_DESKTOP = 64;

        /// JOB_OBJECT_UILIMIT_ALL -> 0x000000FF
        public const int JOB_OBJECT_UILIMIT_ALL = 255;

        /// JOB_OBJECT_TERMINATE_AT_END_OF_JOB -> 0
        public const int JOB_OBJECT_TERMINATE_AT_END_OF_JOB = 0;

        /// JOB_OBJECT_TERMINATE -> (0x0008)
        public const int JOB_OBJECT_TERMINATE = 8;

        /// JOB_OBJECT_SET_SECURITY_ATTRIBUTES -> (0x0010)
        public const int JOB_OBJECT_SET_SECURITY_ATTRIBUTES = 16;

        /// JOB_OBJECT_SET_ATTRIBUTES -> (0x0002)
        public const int JOB_OBJECT_SET_ATTRIBUTES = 2;

        /// JOB_OBJECT_SECURITY_VALID_FLAGS -> 0x0000000f
        public const int JOB_OBJECT_SECURITY_VALID_FLAGS = 15;

        /// JOB_OBJECT_SECURITY_RESTRICTED_TOKEN -> 0x00000002
        public const int JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = 2;

        /// JOB_OBJECT_SECURITY_ONLY_TOKEN -> 0x00000004
        public const int JOB_OBJECT_SECURITY_ONLY_TOKEN = 4;

        /// JOB_OBJECT_SECURITY_NO_ADMIN -> 0x00000001
        public const int JOB_OBJECT_SECURITY_NO_ADMIN = 1;

        /// JOB_OBJECT_SECURITY_FILTER_TOKENS -> 0x00000008
        public const int JOB_OBJECT_SECURITY_FILTER_TOKENS = 8;

        /// JOB_OBJECT_RESERVED_LIMIT_VALID_FLAGS -> 0x0007ffff
        public const int JOB_OBJECT_RESERVED_LIMIT_VALID_FLAGS = 524287;

        /// JOB_OBJECT_QUERY -> (0x0004)
        public const int JOB_OBJECT_QUERY = 4;

        /// JOB_OBJECT_POST_AT_END_OF_JOB -> 1
        public const int JOB_OBJECT_POST_AT_END_OF_JOB = 1;

        /// JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT -> 9
        public const int JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT = 9;

        /// JOB_OBJECT_MSG_NEW_PROCESS -> 6
        public const int JOB_OBJECT_MSG_NEW_PROCESS = 6;

        /// JOB_OBJECT_MSG_JOB_MEMORY_LIMIT -> 10
        public const int JOB_OBJECT_MSG_JOB_MEMORY_LIMIT = 10;

        /// JOB_OBJECT_MSG_EXIT_PROCESS -> 7
        public const int JOB_OBJECT_MSG_EXIT_PROCESS = 7;

        /// JOB_OBJECT_MSG_END_OF_PROCESS_TIME -> 2
        public const int JOB_OBJECT_MSG_END_OF_PROCESS_TIME = 2;

        /// JOB_OBJECT_MSG_END_OF_JOB_TIME -> 1
        public const int JOB_OBJECT_MSG_END_OF_JOB_TIME = 1;

        /// JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO -> 4
        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO = 4;

        /// JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT -> 3
        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT = 3;

        /// JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS -> 8
        public const int JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS = 8;

        /// JOB_OBJECT_LIMIT_WORKINGSET -> 0x00000001
        public const int JOB_OBJECT_LIMIT_WORKINGSET = 1;

        /// JOB_OBJECT_LIMIT_VALID_FLAGS -> 0x0007ffff
        public const int JOB_OBJECT_LIMIT_VALID_FLAGS = 524287;

        /// JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK -> 0x00001000
        public const int JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 4096;

        /// JOB_OBJECT_LIMIT_SCHEDULING_CLASS -> 0x00000080
        public const int JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 128;

        /// JOB_OBJECT_LIMIT_RESERVED6 -> 0x00040000
        public const int JOB_OBJECT_LIMIT_RESERVED6 = 262144;

        /// JOB_OBJECT_LIMIT_RESERVED5 -> 0x00020000
        public const int JOB_OBJECT_LIMIT_RESERVED5 = 131072;

        /// JOB_OBJECT_LIMIT_RESERVED4 -> 0x00010000
        public const int JOB_OBJECT_LIMIT_RESERVED4 = 65536;

        /// JOB_OBJECT_LIMIT_RESERVED3 -> 0x00008000
        public const int JOB_OBJECT_LIMIT_RESERVED3 = 32768;

        /// JOB_OBJECT_LIMIT_RESERVED2 -> 0x00004000
        public const int JOB_OBJECT_LIMIT_RESERVED2 = 16384;

        /// JOB_OBJECT_LIMIT_PROCESS_TIME -> 0x00000002
        public const int JOB_OBJECT_LIMIT_PROCESS_TIME = 2;

        /// JOB_OBJECT_LIMIT_PROCESS_MEMORY -> 0x00000100
        public const int JOB_OBJECT_LIMIT_PROCESS_MEMORY = 256;

        /// JOB_OBJECT_LIMIT_PRIORITY_CLASS -> 0x00000020
        public const int JOB_OBJECT_LIMIT_PRIORITY_CLASS = 32;

        /// JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME -> 0x00000040
        public const int JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 64;

        /// JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE -> 0x00002000
        public const int JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 8192;

        /// JOB_OBJECT_LIMIT_JOB_TIME -> 0x00000004
        public const int JOB_OBJECT_LIMIT_JOB_TIME = 4;

        /// JOB_OBJECT_LIMIT_JOB_MEMORY -> 0x00000200
        public const int JOB_OBJECT_LIMIT_JOB_MEMORY = 512;

        /// JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION -> 0x00000400
        public const int JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 1024;

        /// JOB_OBJECT_LIMIT_BREAKAWAY_OK -> 0x00000800
        public const int JOB_OBJECT_LIMIT_BREAKAWAY_OK = 2048;

        /// JOB_OBJECT_LIMIT_AFFINITY -> 0x00000010
        public const int JOB_OBJECT_LIMIT_AFFINITY = 16;

        /// JOB_OBJECT_LIMIT_ACTIVE_PROCESS -> 0x00000008
        public const int JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 8;

        /// JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS -> 0x00003fff
        public const int JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = 16383;

        /// JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS -> 0x000000ff
        public const int JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = 255;

        /// JOB_OBJECT_ASSIGN_PROCESS -> (0x0001)
        public const int JOB_OBJECT_ASSIGN_PROCESS = 1;

        /// JOB_OBJECT_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE |                                         0x1F )
        public const int JOB_OBJECT_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE | 31));

        /// JOB_NOTIFY_TYPE -> 0x01
        public const int JOB_NOTIFY_TYPE = 1;

        /// JOB_NOTIFY_FIELD_USER_NAME -> 0x03
        public const int JOB_NOTIFY_FIELD_USER_NAME = 3;

        /// JOB_NOTIFY_FIELD_UNTIL_TIME -> 0x12
        public const int JOB_NOTIFY_FIELD_UNTIL_TIME = 18;

        /// JOB_NOTIFY_FIELD_TOTAL_PAGES -> 0x14
        public const int JOB_NOTIFY_FIELD_TOTAL_PAGES = 20;

        /// JOB_NOTIFY_FIELD_TOTAL_BYTES -> 0x16
        public const int JOB_NOTIFY_FIELD_TOTAL_BYTES = 22;

        /// JOB_NOTIFY_FIELD_TIME -> 0x13
        public const int JOB_NOTIFY_FIELD_TIME = 19;

        /// JOB_NOTIFY_FIELD_SUBMITTED -> 0x10
        public const int JOB_NOTIFY_FIELD_SUBMITTED = 16;

        /// JOB_NOTIFY_FIELD_STATUS_STRING -> 0x0B
        public const int JOB_NOTIFY_FIELD_STATUS_STRING = 11;

        /// JOB_NOTIFY_FIELD_STATUS -> 0x0A
        public const int JOB_NOTIFY_FIELD_STATUS = 10;

        /// JOB_NOTIFY_FIELD_START_TIME -> 0x11
        public const int JOB_NOTIFY_FIELD_START_TIME = 17;

        /// JOB_NOTIFY_FIELD_SECURITY_DESCRIPTOR -> 0x0C
        public const int JOB_NOTIFY_FIELD_SECURITY_DESCRIPTOR = 12;

        /// JOB_NOTIFY_FIELD_PRIORITY -> 0x0E
        public const int JOB_NOTIFY_FIELD_PRIORITY = 14;

        /// JOB_NOTIFY_FIELD_PRINT_PROCESSOR -> 0x06
        public const int JOB_NOTIFY_FIELD_PRINT_PROCESSOR = 6;

        /// JOB_NOTIFY_FIELD_PRINTER_NAME -> 0x00
        public const int JOB_NOTIFY_FIELD_PRINTER_NAME = 0;

        /// JOB_NOTIFY_FIELD_POSITION -> 0x0F
        public const int JOB_NOTIFY_FIELD_POSITION = 15;

        /// JOB_NOTIFY_FIELD_PORT_NAME -> 0x02
        public const int JOB_NOTIFY_FIELD_PORT_NAME = 2;

        /// JOB_NOTIFY_FIELD_PARAMETERS -> 0x07
        public const int JOB_NOTIFY_FIELD_PARAMETERS = 7;

        /// JOB_NOTIFY_FIELD_PAGES_PRINTED -> 0x15
        public const int JOB_NOTIFY_FIELD_PAGES_PRINTED = 21;

        /// JOB_NOTIFY_FIELD_NOTIFY_NAME -> 0x04
        public const int JOB_NOTIFY_FIELD_NOTIFY_NAME = 4;

        /// JOB_NOTIFY_FIELD_MACHINE_NAME -> 0x01
        public const int JOB_NOTIFY_FIELD_MACHINE_NAME = 1;

        /// JOB_NOTIFY_FIELD_DRIVER_NAME -> 0x08
        public const int JOB_NOTIFY_FIELD_DRIVER_NAME = 8;

        /// JOB_NOTIFY_FIELD_DOCUMENT -> 0x0D
        public const int JOB_NOTIFY_FIELD_DOCUMENT = 13;

        /// JOB_NOTIFY_FIELD_DEVMODE -> 0x09
        public const int JOB_NOTIFY_FIELD_DEVMODE = 9;

        /// JOB_NOTIFY_FIELD_DATATYPE -> 0x05
        public const int JOB_NOTIFY_FIELD_DATATYPE = 5;

        /// JOB_NOTIFY_FIELD_BYTES_PRINTED -> 0x17
        public const int JOB_NOTIFY_FIELD_BYTES_PRINTED = 23;

        /// JOB_EXECUTE -> (STANDARD_RIGHTS_EXECUTE     |                                JOB_ACCESS_ADMINISTER)
        public const int JOB_EXECUTE = (NativeConstants.STANDARD_RIGHTS_EXECUTE | NativeConstants.JOB_ACCESS_ADMINISTER);

        /// JOB_CONTROL_SENT_TO_PRINTER -> 6
        public const int JOB_CONTROL_SENT_TO_PRINTER = 6;

        /// JOB_CONTROL_RESUME -> 2
        public const int JOB_CONTROL_RESUME = 2;

        /// JOB_CONTROL_RESTART -> 4
        public const int JOB_CONTROL_RESTART = 4;

        /// JOB_CONTROL_PAUSE -> 1
        public const int JOB_CONTROL_PAUSE = 1;

        /// JOB_CONTROL_LAST_PAGE_EJECTED -> 7
        public const int JOB_CONTROL_LAST_PAGE_EJECTED = 7;

        /// JOB_CONTROL_DELETE -> 5
        public const int JOB_CONTROL_DELETE = 5;

        /// JOB_CONTROL_CANCEL -> 3
        public const int JOB_CONTROL_CANCEL = 3;

        /// JOB_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED    |                                JOB_ACCESS_ADMINISTER       |                                JOB_ACCESS_READ)
        public const int JOB_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.JOB_ACCESS_ADMINISTER | NativeConstants.JOB_ACCESS_READ));

        /// JOB_ACCESS_READ -> 0x00000020
        public const int JOB_ACCESS_READ = 32;

        /// JOB_ACCESS_ADMINISTER -> 0x00000010
        public const int JOB_ACCESS_ADMINISTER = 16;
    }

}
