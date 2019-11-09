using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// BuildCommDCBAndTimeouts -> BuildCommDCBAndTimeoutsW
        /// Error generating expression: Value BuildCommDCBAndTimeoutsW is not resolved
        public const string BuildCommDCBAndTimeouts = "BuildCommDCBAndTimeoutsW";

        /// BuildCommDCB -> BuildCommDCBW
        /// Error generating expression: Value BuildCommDCBW is not resolved
        public const string BuildCommDCB = "BuildCommDCBW";

        /// BS_VCENTER -> 0x00000C00L
        public const int BS_VCENTER = 3072;

        /// BS_USERBUTTON -> 0x00000008L
        public const int BS_USERBUTTON = 8;

        /// BS_TYPEMASK -> 0x0000000FL
        public const int BS_TYPEMASK = 15;

        /// BS_TOP -> 0x00000400L
        public const int BS_TOP = 1024;

        /// BS_TEXT -> 0x00000000L
        public const int BS_TEXT = 0;

        /// BS_SOLID -> 0
        public const int BS_SOLID = 0;

        /// BS_RIGHTBUTTON -> BS_LEFTTEXT
        public const int BS_RIGHTBUTTON = NativeConstants.BS_LEFTTEXT;

        /// BS_RIGHT -> 0x00000200L
        public const int BS_RIGHT = 512;

        /// BS_RADIOBUTTON -> 0x00000004L
        public const int BS_RADIOBUTTON = 4;

        /// BS_PUSHLIKE -> 0x00001000L
        public const int BS_PUSHLIKE = 4096;

        /// BS_PUSHBUTTON -> 0x00000000L
        public const int BS_PUSHBUTTON = 0;

        /// BS_PUSHBOX -> 0x0000000AL
        public const int BS_PUSHBOX = 10;

        /// BS_PATTERN8X8 -> 7
        public const int BS_PATTERN8X8 = 7;

        /// BS_PATTERN -> 3
        public const int BS_PATTERN = 3;

        /// BS_OWNERDRAW -> 0x0000000BL
        public const int BS_OWNERDRAW = 11;

        /// BS_NULL -> 1
        public const int BS_NULL = 1;

        /// BS_NOTIFY -> 0x00004000L
        public const int BS_NOTIFY = 16384;

        /// BS_MULTILINE -> 0x00002000L
        public const int BS_MULTILINE = 8192;

        /// BS_MONOPATTERN -> 9
        public const int BS_MONOPATTERN = 9;

        /// BS_LEFTTEXT -> 0x00000020L
        public const int BS_LEFTTEXT = 32;

        /// BS_LEFT -> 0x00000100L
        public const int BS_LEFT = 256;

        /// BS_INDEXED -> 4
        public const int BS_INDEXED = 4;

        /// BS_ICON -> 0x00000040L
        public const int BS_ICON = 64;

        /// BS_HOLLOW -> BS_NULL
        public const int BS_HOLLOW = NativeConstants.BS_NULL;

        /// BS_HATCHED -> 2
        public const int BS_HATCHED = 2;

        /// BS_GROUPBOX -> 0x00000007L
        public const int BS_GROUPBOX = 7;

        /// BS_FLAT -> 0x00008000L
        public const int BS_FLAT = 32768;

        /// BS_DIBPATTERNPT -> 6
        public const int BS_DIBPATTERNPT = 6;

        /// BS_DIBPATTERN8X8 -> 8
        public const int BS_DIBPATTERN8X8 = 8;

        /// BS_DIBPATTERN -> 5
        public const int BS_DIBPATTERN = 5;

        /// BS_DEFPUSHBUTTON -> 0x00000001L
        public const int BS_DEFPUSHBUTTON = 1;

        /// BS_CHECKBOX -> 0x00000002L
        public const int BS_CHECKBOX = 2;

        /// BS_CENTER -> 0x00000300L
        public const int BS_CENTER = 768;

        /// BS_BOTTOM -> 0x00000800L
        public const int BS_BOTTOM = 2048;

        /// BS_BITMAP -> 0x00000080L
        public const int BS_BITMAP = 128;

        /// BS_AUTORADIOBUTTON -> 0x00000009L
        public const int BS_AUTORADIOBUTTON = 9;

        /// BS_AUTOCHECKBOX -> 0x00000003L
        public const int BS_AUTOCHECKBOX = 3;

        /// BS_AUTO3STATE -> 0x00000006L
        public const int BS_AUTO3STATE = 6;

        /// BS_3STATE -> 0x00000005L
        public const int BS_3STATE = 5;

        /// BST_UNCHECKED -> 0x0000
        public const int BST_UNCHECKED = 0;

        /// BST_PUSHED -> 0x0004
        public const int BST_PUSHED = 4;

        /// BST_INDETERMINATE -> 0x0002
        public const int BST_INDETERMINATE = 2;

        /// BST_FOCUS -> 0x0008
        public const int BST_FOCUS = 8;

        /// BST_CHECKED -> 0x0001
        public const int BST_CHECKED = 1;

        /// BSM_VXDS -> 0x00000001
        public const int BSM_VXDS = 1;

        /// BSM_NETDRIVER -> 0x00000002
        public const int BSM_NETDRIVER = 2;

        /// BSM_INSTALLABLEDRIVERS -> 0x00000004
        public const int BSM_INSTALLABLEDRIVERS = 4;

        /// BSM_APPLICATIONS -> 0x00000008
        public const int BSM_APPLICATIONS = 8;

        /// BSM_ALLDESKTOPS -> 0x00000010
        public const int BSM_ALLDESKTOPS = 16;

        /// BSM_ALLCOMPONENTS -> 0x00000000
        public const int BSM_ALLCOMPONENTS = 0;

        /// BSF_SENDNOTIFYMESSAGE -> 0x00000100
        public const int BSF_SENDNOTIFYMESSAGE = 256;

        /// BSF_RETURNHDESK -> 0x00000200
        public const int BSF_RETURNHDESK = 512;

        /// BSF_QUERY -> 0x00000001
        public const int BSF_QUERY = 1;

        /// BSF_POSTMESSAGE -> 0x00000010
        public const int BSF_POSTMESSAGE = 16;

        /// BSF_NOTIMEOUTIFNOTHUNG -> 0x00000040
        public const int BSF_NOTIMEOUTIFNOTHUNG = 64;

        /// BSF_NOHANG -> 0x00000008
        public const int BSF_NOHANG = 8;

        /// BSF_LUID -> 0x00000400
        public const int BSF_LUID = 1024;

        /// BSF_IGNORECURRENTTASK -> 0x00000002
        public const int BSF_IGNORECURRENTTASK = 2;

        /// BSF_FORCEIFHUNG -> 0x00000020
        public const int BSF_FORCEIFHUNG = 32;

        /// BSF_FLUSHDISK -> 0x00000004
        public const int BSF_FLUSHDISK = 4;

        /// BSF_ALLOWSFW -> 0x00000080
        public const int BSF_ALLOWSFW = 128;

        /// BROADCAST_QUERY_DENY -> 0x424D5144
        public const int BROADCAST_QUERY_DENY = 1112363332;

        /// BroadcastSystemMessageEx -> BroadcastSystemMessageExW
        /// Error generating expression: Value BroadcastSystemMessageExW is not resolved
        public const string BroadcastSystemMessageEx = "BroadcastSystemMessageExW";

        /// BroadcastSystemMessage -> BroadcastSystemMessageW
        /// Error generating expression: Value BroadcastSystemMessageW is not resolved
        public const string BroadcastSystemMessage = "BroadcastSystemMessageW";

        /// BOLD_FONTTYPE -> 0x0100
        public const int BOLD_FONTTYPE = 256;

        /// BN_UNPUSHED -> BN_UNHILITE
        public const int BN_UNPUSHED = NativeConstants.BN_UNHILITE;

        /// BN_UNHILITE -> 3
        public const int BN_UNHILITE = 3;

        /// BN_SETFOCUS -> 6
        public const int BN_SETFOCUS = 6;

        /// BN_PUSHED -> BN_HILITE
        public const int BN_PUSHED = NativeConstants.BN_HILITE;

        /// BN_PAINT -> 1
        public const int BN_PAINT = 1;

        /// BN_KILLFOCUS -> 7
        public const int BN_KILLFOCUS = 7;

        /// BN_HILITE -> 2
        public const int BN_HILITE = 2;

        /// BN_DOUBLECLICKED -> 5
        public const int BN_DOUBLECLICKED = 5;

        /// BN_DISABLE -> 4
        public const int BN_DISABLE = 4;

        /// BN_DBLCLK -> BN_DOUBLECLICKED
        public const int BN_DBLCLK = NativeConstants.BN_DOUBLECLICKED;

        /// BN_CLICKED -> 0
        public const int BN_CLICKED = 0;

        /// BM_SETSTYLE -> 0x00F4
        public const int BM_SETSTYLE = 244;

        /// BM_SETSTATE -> 0x00F3
        public const int BM_SETSTATE = 243;

        /// BM_SETIMAGE -> 0x00F7
        public const int BM_SETIMAGE = 247;

        /// BM_SETCHECK -> 0x00F1
        public const int BM_SETCHECK = 241;

        /// BM_GETSTATE -> 0x00F2
        public const int BM_GETSTATE = 242;

        /// BM_GETIMAGE -> 0x00F6
        public const int BM_GETIMAGE = 246;

        /// BM_GETCHECK -> 0x00F0
        public const int BM_GETCHECK = 240;

        /// BM_CLICK -> 0x00F5
        public const int BM_CLICK = 245;

        /// BLTALIGNMENT -> 119
        public const int BLTALIGNMENT = 119;

        /// BLACK_PEN -> 7
        public const int BLACK_PEN = 7;

        /// BLACK_BRUSH -> 4
        public const int BLACK_BRUSH = 4;

        /// BLACKONWHITE -> 1
        public const int BLACKONWHITE = 1;

        /// BKMODE_LAST -> 2
        public const int BKMODE_LAST = 2;

        /// BI_RLE8 -> 1L
        public const int BI_RLE8 = 1;

        /// BI_RLE4 -> 2L
        public const int BI_RLE4 = 2;

        /// BI_RGB -> 0L
        public const int BI_RGB = 0;

        /// BI_PNG -> 5L
        public const int BI_PNG = 5;

        /// BI_JPEG -> 4L
        public const int BI_JPEG = 4;

        /// BI_BITFIELDS -> 3L
        public const int BI_BITFIELDS = 3;

        /// BITSPIXEL -> 12
        public const int BITSPIXEL = 12;

        /// BINDF_NOCOPYDATA -> BINDF_PULLDATA
        public const BINDF BINDF_NOCOPYDATA = BINDF.BINDF_PULLDATA;

        /// BINDF_DONTUSECACHE -> BINDF_GETNEWESTVERSION
        public const BINDF BINDF_DONTUSECACHE = BINDF.BINDF_GETNEWESTVERSION;

        /// BINDF_DONTPUTINCACHE -> BINDF_NOWRITECACHE
        public const BINDF BINDF_DONTPUTINCACHE = BINDF.BINDF_NOWRITECACHE;

        /// BIDI_ACTION_SET -> L"Set"
        public const string BIDI_ACTION_SET = "Set";

        /// BIDI_ACTION_GET_ALL -> L"GetAll"
        public const string BIDI_ACTION_GET_ALL = "GetAll";

        /// BIDI_ACTION_GET -> L"Get"
        public const string BIDI_ACTION_GET = "Get";

        /// BIDI_ACTION_ENUM_SCHEMA -> L"EnumSchema"
        public const string BIDI_ACTION_ENUM_SCHEMA = "EnumSchema";

        /// BIDI_ACCESS_USER -> 0x2
        public const int BIDI_ACCESS_USER = 2;

        /// BIDI_ACCESS_ADMINISTRATOR -> 0x1
        public const int BIDI_ACCESS_ADMINISTRATOR = 1;

        /// BF_TOPRIGHT -> (BF_TOP | BF_RIGHT)
        public const int BF_TOPRIGHT = (NativeConstants.BF_TOP | NativeConstants.BF_RIGHT);

        /// BF_TOPLEFT -> (BF_TOP | BF_LEFT)
        public const int BF_TOPLEFT = (NativeConstants.BF_TOP | NativeConstants.BF_LEFT);

        /// BF_TOP -> 0x0002
        public const int BF_TOP = 2;

        /// BF_SOFT -> 0x1000
        public const int BF_SOFT = 4096;

        /// BF_RIGHT -> 0x0004
        public const int BF_RIGHT = 4;

        /// BF_RECT -> (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM)
        public const int BF_RECT = (NativeConstants.BF_LEFT
                    | (NativeConstants.BF_TOP
                    | (NativeConstants.BF_RIGHT | NativeConstants.BF_BOTTOM)));

        /// BF_MONO -> 0x8000
        public const int BF_MONO = 32768;

        /// BF_MIDDLE -> 0x0800
        public const int BF_MIDDLE = 2048;

        /// BF_LEFT -> 0x0001
        public const int BF_LEFT = 1;

        /// BF_FLAT -> 0x4000
        public const int BF_FLAT = 16384;

        /// BF_DIAGONAL_ENDTOPRIGHT -> (BF_DIAGONAL | BF_TOP | BF_RIGHT)
        public const int BF_DIAGONAL_ENDTOPRIGHT = (NativeConstants.BF_DIAGONAL
                    | (NativeConstants.BF_TOP | NativeConstants.BF_RIGHT));

        /// BF_DIAGONAL_ENDTOPLEFT -> (BF_DIAGONAL | BF_TOP | BF_LEFT)
        public const int BF_DIAGONAL_ENDTOPLEFT = (NativeConstants.BF_DIAGONAL
                    | (NativeConstants.BF_TOP | NativeConstants.BF_LEFT));

        /// BF_DIAGONAL_ENDBOTTOMRIGHT -> (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT)
        public const int BF_DIAGONAL_ENDBOTTOMRIGHT = (NativeConstants.BF_DIAGONAL
                    | (NativeConstants.BF_BOTTOM | NativeConstants.BF_RIGHT));

        /// BF_DIAGONAL_ENDBOTTOMLEFT -> (BF_DIAGONAL | BF_BOTTOM | BF_LEFT)
        public const int BF_DIAGONAL_ENDBOTTOMLEFT = (NativeConstants.BF_DIAGONAL
                    | (NativeConstants.BF_BOTTOM | NativeConstants.BF_LEFT));

        /// BF_DIAGONAL -> 0x0010
        public const int BF_DIAGONAL = 16;

        /// BF_BOTTOMRIGHT -> (BF_BOTTOM | BF_RIGHT)
        public const int BF_BOTTOMRIGHT = (NativeConstants.BF_BOTTOM | NativeConstants.BF_RIGHT);

        /// BF_BOTTOMLEFT -> (BF_BOTTOM | BF_LEFT)
        public const int BF_BOTTOMLEFT = (NativeConstants.BF_BOTTOM | NativeConstants.BF_LEFT);

        /// BF_BOTTOM -> 0x0008
        public const int BF_BOTTOM = 8;

        /// BF_ADJUST -> 0x2000
        public const int BF_ADJUST = 8192;

        /// BELOW_NORMAL_PRIORITY_CLASS -> 0x00004000
        public const int BELOW_NORMAL_PRIORITY_CLASS = 16384;

        /// BEGIN_PATH -> 4096
        public const int BEGIN_PATH = 4096;

        /// BeginUpdateResource -> BeginUpdateResourceW
        /// Error generating expression: Value BeginUpdateResourceW is not resolved
        public const string BeginUpdateResource = "BeginUpdateResourceW";

        /// BDR_SUNKENOUTER -> 0x0002
        public const int BDR_SUNKENOUTER = 2;

        /// BDR_SUNKENINNER -> 0x0008
        public const int BDR_SUNKENINNER = 8;

        /// BDR_SUNKEN -> (BDR_SUNKENOUTER | BDR_SUNKENINNER)
        public const int BDR_SUNKEN = (NativeConstants.BDR_SUNKENOUTER | NativeConstants.BDR_SUNKENINNER);

        /// BDR_RAISEDOUTER -> 0x0001
        public const int BDR_RAISEDOUTER = 1;

        /// BDR_RAISEDINNER -> 0x0004
        public const int BDR_RAISEDINNER = 4;

        /// BDR_RAISED -> (BDR_RAISEDOUTER | BDR_RAISEDINNER)
        public const int BDR_RAISED = (NativeConstants.BDR_RAISEDOUTER | NativeConstants.BDR_RAISEDINNER);

        /// BDR_OUTER -> (BDR_RAISEDOUTER | BDR_SUNKENOUTER)
        public const int BDR_OUTER = (NativeConstants.BDR_RAISEDOUTER | NativeConstants.BDR_SUNKENOUTER);

        /// BDR_INNER -> (BDR_RAISEDINNER | BDR_SUNKENINNER)
        public const int BDR_INNER = (NativeConstants.BDR_RAISEDINNER | NativeConstants.BDR_SUNKENINNER);

        /// BATTERY_PERCENTAGE_UNKNOWN -> 0xFF
        public const int BATTERY_PERCENTAGE_UNKNOWN = 255;

        /// BATTERY_LIFE_UNKNOWN -> 0xFFFFFFFF
        public const int BATTERY_LIFE_UNKNOWN = -1;

        /// BATTERY_FLAG_UNKNOWN -> 0xFF
        public const int BATTERY_FLAG_UNKNOWN = 255;

        /// BATTERY_FLAG_NO_BATTERY -> 0x80
        public const int BATTERY_FLAG_NO_BATTERY = 128;

        /// BATTERY_FLAG_LOW -> 0x02
        public const int BATTERY_FLAG_LOW = 2;

        /// BATTERY_FLAG_HIGH -> 0x01
        public const int BATTERY_FLAG_HIGH = 1;

        /// BATTERY_FLAG_CRITICAL -> 0x04
        public const int BATTERY_FLAG_CRITICAL = 4;

        /// BATTERY_FLAG_CHARGING -> 0x08
        public const int BATTERY_FLAG_CHARGING = 8;

        /// BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_END_ENTITY_FLAG -> 0x40000000
        public const int BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_END_ENTITY_FLAG = 1073741824;

        /// BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_CA_FLAG -> 0x80000000
        public const int BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_CA_FLAG = -2147483648;

        /// BANDINFO -> 24
        public const int BANDINFO = 24;

        /// BALTIC_CHARSET -> 186
        public const int BALTIC_CHARSET = 186;

        /// BACKUP_SPARSE_BLOCK -> 0x00000009
        public const int BACKUP_SPARSE_BLOCK = 9;

        /// BACKUP_SECURITY_DATA -> 0x00000003
        public const int BACKUP_SECURITY_DATA = 3;

        /// BACKUP_REPARSE_DATA -> 0x00000008
        public const int BACKUP_REPARSE_DATA = 8;

        /// BACKUP_PROPERTY_DATA -> 0x00000006
        public const int BACKUP_PROPERTY_DATA = 6;

        /// BACKUP_OBJECT_ID -> 0x00000007
        public const int BACKUP_OBJECT_ID = 7;

        /// BACKUP_LINK -> 0x00000005
        public const int BACKUP_LINK = 5;

        /// BACKUP_INVALID -> 0x00000000
        public const int BACKUP_INVALID = 0;

        /// BACKUP_EA_DATA -> 0x00000002
        public const int BACKUP_EA_DATA = 2;

        /// BACKUP_DATA -> 0x00000001
        public const int BACKUP_DATA = 1;

        /// BACKUP_ALTERNATE_DATA -> 0x00000004
        public const int BACKUP_ALTERNATE_DATA = 4;

        /// BackupEventLog -> BackupEventLogW
        /// Error generating expression: Value BackupEventLogW is not resolved
        public const string BackupEventLog = "BackupEventLogW";

        /// BACKGROUND_RED -> 0x0040
        public const int BACKGROUND_RED = 64;

        /// BACKGROUND_INTENSITY -> 0x0080
        public const int BACKGROUND_INTENSITY = 128;

        /// BACKGROUND_GREEN -> 0x0020
        public const int BACKGROUND_GREEN = 32;

        /// BACKGROUND_BLUE -> 0x0010
        public const int BACKGROUND_BLUE = 16;
    }
    
}
