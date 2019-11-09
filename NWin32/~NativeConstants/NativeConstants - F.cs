using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// FW_ULTRALIGHT -> FW_EXTRALIGHT
        public const int FW_ULTRALIGHT = NativeConstants.FW_EXTRALIGHT;

        /// FW_ULTRABOLD -> FW_EXTRABOLD
        public const int FW_ULTRABOLD = NativeConstants.FW_EXTRABOLD;

        /// FW_THIN -> 100
        public const int FW_THIN = 100;

        /// FW_SEMIBOLD -> 600
        public const int FW_SEMIBOLD = 600;

        /// FW_REGULAR -> FW_NORMAL
        public const int FW_REGULAR = NativeConstants.FW_NORMAL;

        /// FW_NORMAL -> 400
        public const int FW_NORMAL = 400;

        /// FW_MEDIUM -> 500
        public const int FW_MEDIUM = 500;

        /// FW_LIGHT -> 300
        public const int FW_LIGHT = 300;

        /// FW_HEAVY -> 900
        public const int FW_HEAVY = 900;

        /// FW_EXTRALIGHT -> 200
        public const int FW_EXTRALIGHT = 200;

        /// FW_EXTRABOLD -> 800
        public const int FW_EXTRABOLD = 800;

        /// FW_DONTCARE -> 0
        public const int FW_DONTCARE = 0;

        /// FW_DEMIBOLD -> FW_SEMIBOLD
        public const int FW_DEMIBOLD = NativeConstants.FW_SEMIBOLD;

        /// FW_BOLD -> 700
        public const int FW_BOLD = 700;

        /// FW_BLACK -> FW_HEAVY
        public const int FW_BLACK = NativeConstants.FW_HEAVY;

        /// FVIRTKEY -> TRUE
        public const int FVIRTKEY = NativeConstants.TRUE;

        /// FS_WANSUNG -> 0x00080000L
        public const int FS_WANSUNG = 524288;

        /// FS_VOL_IS_COMPRESSED -> FILE_VOLUME_IS_COMPRESSED
        public const int FS_VOL_IS_COMPRESSED = NativeConstants.FILE_VOLUME_IS_COMPRESSED;

        /// FS_VIETNAMESE -> 0x00000100L
        public const int FS_VIETNAMESE = 256;

        /// FS_UNICODE_STORED_ON_DISK -> FILE_UNICODE_ON_DISK
        public const int FS_UNICODE_STORED_ON_DISK = NativeConstants.FILE_UNICODE_ON_DISK;

        /// FS_TURKISH -> 0x00000010L
        public const int FS_TURKISH = 16;

        /// FS_THAI -> 0x00010000L
        public const int FS_THAI = 65536;

        /// FS_SYMBOL -> 0x80000000L
        public const int FS_SYMBOL = -2147483648;

        /// FS_PERSISTENT_ACLS -> FILE_PERSISTENT_ACLS
        public const int FS_PERSISTENT_ACLS = NativeConstants.FILE_PERSISTENT_ACLS;

        /// FS_LATIN2 -> 0x00000002L
        public const int FS_LATIN2 = 2;

        /// FS_LATIN1 -> 0x00000001L
        public const int FS_LATIN1 = 1;

        /// FS_JOHAB -> 0x00200000L
        public const int FS_JOHAB = 2097152;

        /// FS_JISJAPAN -> 0x00020000L
        public const int FS_JISJAPAN = 131072;

        /// FS_HEBREW -> 0x00000020L
        public const int FS_HEBREW = 32;

        /// FS_GREEK -> 0x00000008L
        public const int FS_GREEK = 8;

        /// FS_FILE_ENCRYPTION -> FILE_SUPPORTS_ENCRYPTION
        public const int FS_FILE_ENCRYPTION = NativeConstants.FILE_SUPPORTS_ENCRYPTION;

        /// FS_FILE_COMPRESSION -> FILE_FILE_COMPRESSION
        public const int FS_FILE_COMPRESSION = NativeConstants.FILE_FILE_COMPRESSION;

        /// FS_CYRILLIC -> 0x00000004L
        public const int FS_CYRILLIC = 4;

        /// FS_CHINESETRAD -> 0x00100000L
        public const int FS_CHINESETRAD = 1048576;

        /// FS_CHINESESIMP -> 0x00040000L
        public const int FS_CHINESESIMP = 262144;

        /// FS_CASE_SENSITIVE -> FILE_CASE_SENSITIVE_SEARCH
        public const int FS_CASE_SENSITIVE = NativeConstants.FILE_CASE_SENSITIVE_SEARCH;

        /// FS_CASE_IS_PRESERVED -> FILE_CASE_PRESERVED_NAMES
        public const int FS_CASE_IS_PRESERVED = NativeConstants.FILE_CASE_PRESERVED_NAMES;

        /// FS_BALTIC -> 0x00000080L
        public const int FS_BALTIC = 128;

        /// FS_ARABIC -> 0x00000040L
        public const int FS_ARABIC = 64;

        /// FSHIFT -> 0x04
        public const int FSHIFT = 4;

        /// FR_WHOLEWORD -> 0x00000002
        public const int FR_WHOLEWORD = 2;

        /// FR_SHOWHELP -> 0x00000080
        public const int FR_SHOWHELP = 128;

        /// FR_REPLACEALL -> 0x00000020
        public const int FR_REPLACEALL = 32;

        /// FR_REPLACE -> 0x00000010
        public const int FR_REPLACE = 16;

        /// FR_RAW -> 0x00020000
        public const int FR_RAW = 131072;

        /// FR_PRIVATE -> 0x10
        public const int FR_PRIVATE = 16;

        /// FR_NOWHOLEWORD -> 0x00001000
        public const int FR_NOWHOLEWORD = 4096;

        /// FR_NOUPDOWN -> 0x00000400
        public const int FR_NOUPDOWN = 1024;

        /// FR_NOT_ENUM -> 0x20
        public const int FR_NOT_ENUM = 32;

        /// FR_NOMATCHCASE -> 0x00000800
        public const int FR_NOMATCHCASE = 2048;

        /// FR_MATCHKASHIDA -> 0x40000000
        public const int FR_MATCHKASHIDA = 1073741824;

        /// FR_MATCHDIAC -> 0x20000000
        public const int FR_MATCHDIAC = 536870912;

        /// FR_MATCHCASE -> 0x00000004
        public const int FR_MATCHCASE = 4;

        /// FR_MATCHALEFHAMZA -> 0x80000000
        public const int FR_MATCHALEFHAMZA = -2147483648;

        /// FR_HIDEWHOLEWORD -> 0x00010000
        public const int FR_HIDEWHOLEWORD = 65536;

        /// FR_HIDEUPDOWN -> 0x00004000
        public const int FR_HIDEUPDOWN = 16384;

        /// FR_HIDEMATCHCASE -> 0x00008000
        public const int FR_HIDEMATCHCASE = 32768;

        /// FR_FINDNEXT -> 0x00000008
        public const int FR_FINDNEXT = 8;

        /// FR_ENABLETEMPLATEHANDLE -> 0x00002000
        public const int FR_ENABLETEMPLATEHANDLE = 8192;

        /// FR_ENABLETEMPLATE -> 0x00000200
        public const int FR_ENABLETEMPLATE = 512;

        /// FR_ENABLEHOOK -> 0x00000100
        public const int FR_ENABLEHOOK = 256;

        /// FR_DOWN -> 0x00000001
        public const int FR_DOWN = 1;

        /// FR_DIALOGTERM -> 0x00000040
        public const int FR_DIALOGTERM = 64;

        /// FRS_ERR_SYSVOL_POPULATE_TIMEOUT -> 8014L
        public const int FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014;

        /// FRS_ERR_SYSVOL_POPULATE -> 8013L
        public const int FRS_ERR_SYSVOL_POPULATE = 8013;

        /// FRS_ERR_SYSVOL_IS_BUSY -> 8015L
        public const int FRS_ERR_SYSVOL_IS_BUSY = 8015;

        /// FRS_ERR_SYSVOL_DEMOTE -> 8016L
        public const int FRS_ERR_SYSVOL_DEMOTE = 8016;

        /// FRS_ERR_STOPPING_SERVICE -> 8003L
        public const int FRS_ERR_STOPPING_SERVICE = 8003;

        /// FRS_ERR_STARTING_SERVICE -> 8002L
        public const int FRS_ERR_STARTING_SERVICE = 8002;

        /// FRS_ERR_SERVICE_COMM -> 8006L
        public const int FRS_ERR_SERVICE_COMM = 8006;

        /// FRS_ERR_PARENT_TO_CHILD_COMM -> 8012L
        public const int FRS_ERR_PARENT_TO_CHILD_COMM = 8012;

        /// FRS_ERR_PARENT_INSUFFICIENT_PRIV -> 8009L
        public const int FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009;

        /// FRS_ERR_PARENT_AUTHENTICATION -> 8010L
        public const int FRS_ERR_PARENT_AUTHENTICATION = 8010;

        /// FRS_ERR_INVALID_SERVICE_PARAMETER -> 8017L
        public const int FRS_ERR_INVALID_SERVICE_PARAMETER = 8017;

        /// FRS_ERR_INVALID_API_SEQUENCE -> 8001L
        public const int FRS_ERR_INVALID_API_SEQUENCE = 8001;

        /// FRS_ERR_INTERNAL_API -> 8004L
        public const int FRS_ERR_INTERNAL_API = 8004;

        /// FRS_ERR_INTERNAL -> 8005L
        public const int FRS_ERR_INTERNAL = 8005;

        /// FRS_ERR_INSUFFICIENT_PRIV -> 8007L
        public const int FRS_ERR_INSUFFICIENT_PRIV = 8007;

        /// FRS_ERR_CHILD_TO_PARENT_COMM -> 8011L
        public const int FRS_ERR_CHILD_TO_PARENT_COMM = 8011;

        /// FRS_ERR_AUTHENTICATION -> 8008L
        public const int FRS_ERR_AUTHENTICATION = 8008;

        /// FROM_LEFT_4TH_BUTTON_PRESSED -> 0x0010
        public const int FROM_LEFT_4TH_BUTTON_PRESSED = 16;

        /// FROM_LEFT_3RD_BUTTON_PRESSED -> 0x0008
        public const int FROM_LEFT_3RD_BUTTON_PRESSED = 8;

        /// FROM_LEFT_2ND_BUTTON_PRESSED -> 0x0004
        public const int FROM_LEFT_2ND_BUTTON_PRESSED = 4;

        /// FROM_LEFT_1ST_BUTTON_PRESSED -> 0x0001
        public const int FROM_LEFT_1ST_BUTTON_PRESSED = 1;

        /// frm4 -> 0x0437
        public const int frm4 = 1079;

        /// frm3 -> 0x0436
        public const int frm3 = 1078;

        /// frm2 -> 0x0435
        public const int frm2 = 1077;

        /// frm1 -> 0x0434
        public const int frm1 = 1076;

        /// FRERR_FINDREPLACECODES -> 0x4000
        public const int FRERR_FINDREPLACECODES = 16384;

        /// FRERR_BUFFERLENGTHZERO -> 0x4001
        public const int FRERR_BUFFERLENGTHZERO = 16385;

        /// FreeEnvironmentStrings -> FreeEnvironmentStringsW
        /// Error generating expression: Value FreeEnvironmentStringsW is not resolved
        public const string FreeEnvironmentStrings = "FreeEnvironmentStringsW";

        /// FRAME_TSS -> 2
        public const int FRAME_TSS = 2;

        /// FRAME_TRAP -> 1
        public const int FRAME_TRAP = 1;

        /// FRAME_NONFPO -> 3
        public const int FRAME_NONFPO = 3;

        /// FRAME_FPO -> 0
        public const int FRAME_FPO = 0;

        /// FO_RENAME -> 0x0004
        public const int FO_RENAME = 4;

        /// FO_MOVE -> 0x0001
        public const int FO_MOVE = 1;

        /// FO_DELETE -> 0x0003
        public const int FO_DELETE = 3;

        /// FO_COPY -> 0x0002
        public const int FO_COPY = 2;

        /// FORM_USER -> 0x00000000
        public const int FORM_USER = 0;

        /// FORM_PRINTER -> 0x00000002
        public const int FORM_PRINTER = 2;

        /// FORM_BUILTIN -> 0x00000001
        public const int FORM_BUILTIN = 1;

        /// FORMAT_MESSAGE_MAX_WIDTH_MASK -> 0x000000FF
        public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 255;

        /// FORMAT_MESSAGE_IGNORE_INSERTS -> 0x00000200
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

        /// FORMAT_MESSAGE_FROM_SYSTEM -> 0x00001000
        public const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

        /// FORMAT_MESSAGE_FROM_STRING -> 0x00000400
        public const int FORMAT_MESSAGE_FROM_STRING = 1024;

        /// FORMAT_MESSAGE_FROM_HMODULE -> 0x00000800
        public const int FORMAT_MESSAGE_FROM_HMODULE = 2048;

        /// FORMAT_MESSAGE_ARGUMENT_ARRAY -> 0x00002000
        public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

        /// FORMAT_MESSAGE_ALLOCATE_BUFFER -> 0x00000100
        public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 256;

        /// FormatMessage -> FormatMessageW
        /// Error generating expression: Value FormatMessageW is not resolved
        public const string FormatMessage = "FormatMessageW";

        /// FORMATDLGORD31 -> 1543
        public const int FORMATDLGORD31 = 1543;

        /// FORMATDLGORD30 -> 1544
        public const int FORMATDLGORD30 = 1544;

        /// FOREST_USER_RID_MAX -> (0x000001F3L)
        public const int FOREST_USER_RID_MAX = 499;

        /// FOREGROUND_RED -> 0x0004
        public const int FOREGROUND_RED = 4;

        /// FOREGROUND_INTENSITY -> 0x0008
        public const int FOREGROUND_INTENSITY = 8;

        /// FOREGROUND_GREEN -> 0x0002
        public const int FOREGROUND_GREEN = 2;

        /// FOREGROUND_BLUE -> 0x0001
        public const int FOREGROUND_BLUE = 1;

        /// FORCEINLINE -> __forceinline
        /// Error generating expression: Value __forceinline is not resolved
        public const string FORCEINLINE = "__forceinline";

        /// FONTMAPPER_MAX -> 10
        public const int FONTMAPPER_MAX = 10;

        /// FONTDLGORD -> 1542
        public const int FONTDLGORD = 1542;

        /// FoldString -> FoldStringW
        /// Error generating expression: Value FoldStringW is not resolved
        public const string FoldString = "FoldStringW";

        /// FOF_WANTMAPPINGHANDLE -> 0x0020
        public const int FOF_WANTMAPPINGHANDLE = 32;

        /// FOF_SIMPLEPROGRESS -> 0x0100
        public const int FOF_SIMPLEPROGRESS = 256;

        /// FOF_SILENT -> 0x0004
        public const int FOF_SILENT = 4;

        /// FOF_RENAMEONCOLLISION -> 0x0008
        public const int FOF_RENAMEONCOLLISION = 8;

        /// FOF_NORECURSION -> 0x1000
        public const int FOF_NORECURSION = 4096;

        /// FOF_NORECURSEREPARSE -> 0x8000
        public const int FOF_NORECURSEREPARSE = 32768;

        /// FOF_NOERRORUI -> 0x0400
        public const int FOF_NOERRORUI = 1024;

        /// FOF_NOCOPYSECURITYATTRIBS -> 0x0800
        public const int FOF_NOCOPYSECURITYATTRIBS = 2048;

        /// FOF_NOCONFIRMMKDIR -> 0x0200
        public const int FOF_NOCONFIRMMKDIR = 512;

        /// FOF_NOCONFIRMATION -> 0x0010
        public const int FOF_NOCONFIRMATION = 16;

        /// FOF_MULTIDESTFILES -> 0x0001
        public const int FOF_MULTIDESTFILES = 1;

        /// FOF_FILESONLY -> 0x0080
        public const int FOF_FILESONLY = 128;

        /// FOF_CONFIRMMOUSE -> 0x0002
        public const int FOF_CONFIRMMOUSE = 2;

        /// FOF_ALLOWUNDO -> 0x0040
        public const int FOF_ALLOWUNDO = 64;

        /// FOCUS_EVENT -> 0x0010
        public const int FOCUS_EVENT = 16;

        /// FNOINVERT -> 0x02
        public const int FNOINVERT = 2;

        /// FNERR_SUBCLASSFAILURE -> 0x3001
        public const int FNERR_SUBCLASSFAILURE = 12289;

        /// FNERR_INVALIDFILENAME -> 0x3002
        public const int FNERR_INVALIDFILENAME = 12290;

        /// FNERR_FILENAMECODES -> 0x3000
        public const int FNERR_FILENAMECODES = 12288;

        /// FNERR_BUFFERTOOSMALL -> 0x3003
        public const int FNERR_BUFFERTOOSMALL = 12291;

        /// FMTID_NULL -> GUID_NULL
        /// Error generating expression: Value GUID_NULL is not resolved
        public const string FMTID_NULL = "GUID_NULL";

        /// FMFD_URLASFILENAME -> 0x00000001
        public const int FMFD_URLASFILENAME = 1;

        /// FMFD_IGNOREMIMETEXTPLAIN -> 0x00000004
        public const int FMFD_IGNOREMIMETEXTPLAIN = 4;

        /// FMFD_ENABLEMIMESNIFFING -> 0x00000002
        public const int FMFD_ENABLEMIMESNIFFING = 2;

        /// FMFD_DEFAULT -> 0x00000000
        public const int FMFD_DEFAULT = 0;

        /// FLUSHOUTPUT -> 6
        public const int FLUSHOUTPUT = 6;

        /// FLS_MAXIMUM_AVAILABLE -> 128
        public const int FLS_MAXIMUM_AVAILABLE = 128;

        /// FloppyClassGuid -> GUID_DEVINTERFACE_FLOPPY
        /// Error generating expression: Value GUID_DEVINTERFACE_FLOPPY is not resolved
        public const string FloppyClassGuid = "GUID_DEVINTERFACE_FLOPPY";

        /// FLOODFILLSURFACE -> 1
        public const int FLOODFILLSURFACE = 1;

        /// FLOODFILLBORDER -> 0
        public const int FLOODFILLBORDER = 0;

        /// FLI_MASK -> 0x103B
        public const int FLI_MASK = 4155;

        /// FLI_GLYPHS -> 0x00040000L
        public const int FLI_GLYPHS = 262144;

        /// FLASHW_TRAY -> 0x00000002
        public const int FLASHW_TRAY = 2;

        /// FLASHW_TIMERNOFG -> 0x0000000C
        public const int FLASHW_TIMERNOFG = 12;

        /// FLASHW_TIMER -> 0x00000004
        public const int FLASHW_TIMER = 4;

        /// FLASHW_STOP -> 0
        public const int FLASHW_STOP = 0;

        /// FLASHW_CAPTION -> 0x00000001
        public const int FLASHW_CAPTION = 1;

        /// FLASHW_ALL -> (FLASHW_CAPTION | FLASHW_TRAY)
        public const int FLASHW_ALL = (NativeConstants.FLASHW_CAPTION | NativeConstants.FLASHW_TRAY);

        /// FKF_INDICATOR -> 0x00000020
        public const int FKF_INDICATOR = 32;

        /// FKF_HOTKEYSOUND -> 0x00000010
        public const int FKF_HOTKEYSOUND = 16;

        /// FKF_HOTKEYACTIVE -> 0x00000004
        public const int FKF_HOTKEYACTIVE = 4;

        /// FKF_FILTERKEYSON -> 0x00000001
        public const int FKF_FILTERKEYSON = 1;

        /// FKF_CONFIRMHOTKEY -> 0x00000008
        public const int FKF_CONFIRMHOTKEY = 8;

        /// FKF_CLICKON -> 0x00000040
        public const int FKF_CLICKON = 64;

        /// FKF_AVAILABLE -> 0x00000002
        public const int FKF_AVAILABLE = 2;

        /// FIXED_PITCH -> 1
        public const int FIXED_PITCH = 1;

        /// FIRMWARE_PTR -> POINTER_32
        public const string FIRMWARE_PTR = NativeConstants.POINTER_32;

        /// FIND_FIRST_EX_CASE_SENSITIVE -> 0x00000001
        public const int FIND_FIRST_EX_CASE_SENSITIVE = 1;

        /// FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX -> (0x00000001)
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX = 1;

        /// FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS -> (0x00000002)
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS = 2;

        /// FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA -> (0x00000004)
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA = 4;

        /// FindWindowEx -> FindWindowExW
        /// Error generating expression: Value FindWindowExW is not resolved
        public const string FindWindowEx = "FindWindowExW";

        /// FindWindow -> FindWindowW
        /// Error generating expression: Value FindWindowW is not resolved
        public const string FindWindow = "FindWindowW";

        /// FindText -> FindTextW
        /// Error generating expression: Value FindTextW is not resolved
        public const string FindText = "FindTextW";

        /// FindResourceEx -> FindResourceExW
        /// Error generating expression: Value FindResourceExW is not resolved
        public const string FindResourceEx = "FindResourceExW";

        /// FindResource -> FindResourceW
        /// Error generating expression: Value FindResourceW is not resolved
        public const string FindResource = "FindResourceW";

        /// FindNextVolumeMountPoint -> FindNextVolumeMountPointW
        /// Error generating expression: Value FindNextVolumeMountPointW is not resolved
        public const string FindNextVolumeMountPoint = "FindNextVolumeMountPointW";

        /// FindNextVolume -> FindNextVolumeW
        /// Error generating expression: Value FindNextVolumeW is not resolved
        public const string FindNextVolume = "FindNextVolumeW";

        /// FindNextFile -> FindNextFileW
        /// Error generating expression: Value FindNextFileW is not resolved
        public const string FindNextFile = "FindNextFileW";

        /// FINDMSGSTRINGW -> L"commdlg_FindReplace"
        public const string FINDMSGSTRINGW = "commdlg_FindReplace";

        /// FINDMSGSTRINGA -> "commdlg_FindReplace"
        public const string FINDMSGSTRINGA = "commdlg_FindReplace";

        /// FINDMSGSTRING -> FINDMSGSTRINGW
        public const string FINDMSGSTRING = NativeConstants.FINDMSGSTRINGW;

        /// FindFirstVolumeMountPoint -> FindFirstVolumeMountPointW
        /// Error generating expression: Value FindFirstVolumeMountPointW is not resolved
        public const string FindFirstVolumeMountPoint = "FindFirstVolumeMountPointW";

        /// FindFirstVolume -> FindFirstVolumeW
        /// Error generating expression: Value FindFirstVolumeW is not resolved
        public const string FindFirstVolume = "FindFirstVolumeW";

        /// FindFirstFileEx -> FindFirstFileExW
        /// Error generating expression: Value FindFirstFileExW is not resolved
        public const string FindFirstFileEx = "FindFirstFileExW";

        /// FindFirstFile -> FindFirstFileW
        /// Error generating expression: Value FindFirstFileW is not resolved
        public const string FindFirstFile = "FindFirstFileW";

        /// FindFirstChangeNotification -> FindFirstChangeNotificationW
        /// Error generating expression: Value FindFirstChangeNotificationW is not resolved
        public const string FindFirstChangeNotification = "FindFirstChangeNotificationW";

        /// FindExecutable -> FindExecutableW
        /// Error generating expression: Value FindExecutableW is not resolved
        public const string FindExecutable = "FindExecutableW";

        /// FINDDLGORD -> 1540
        public const int FINDDLGORD = 1540;

        /// FindAtom -> FindAtomW
        /// Error generating expression: Value FindAtomW is not resolved
        public const string FindAtom = "FindAtomW";

        /// FindActCtxSectionString -> FindActCtxSectionStringW
        /// Error generating expression: Value FindActCtxSectionStringW is not resolved
        public const string FindActCtxSectionString = "FindActCtxSectionStringW";

        /// FillMemory -> RtlFillMemory
        public const string FillMemory = NativeConstants.RtlFillMemory;

        /// FillConsoleOutputCharacter -> FillConsoleOutputCharacterW
        /// Error generating expression: Value FillConsoleOutputCharacterW is not resolved
        public const string FillConsoleOutputCharacter = "FillConsoleOutputCharacterW";

        /// FILE_WRITE_EA -> ( 0x0010 )
        public const int FILE_WRITE_EA = 16;

        /// FILE_WRITE_DATA -> ( 0x0002 )
        public const int FILE_WRITE_DATA = 2;

        /// FILE_WRITE_ATTRIBUTES -> ( 0x0100 )
        public const int FILE_WRITE_ATTRIBUTES = 256;

        /// FILE_WRITE_ACCESS -> ( 0x0002 )
        public const int FILE_WRITE_ACCESS = 2;

        /// FILE_VOLUME_QUOTAS -> 0x00000020
        public const int FILE_VOLUME_QUOTAS = 32;

        /// FILE_VOLUME_IS_COMPRESSED -> 0x00008000
        public const int FILE_VOLUME_IS_COMPRESSED = 32768;

        /// FILE_USER_DISALLOWED -> 7
        public const int FILE_USER_DISALLOWED = 7;

        /// FILE_UNKNOWN -> 5
        public const int FILE_UNKNOWN = 5;

        /// FILE_UNICODE_ON_DISK -> 0x00000004
        public const int FILE_UNICODE_ON_DISK = 4;

        /// FILE_TYPE_UNKNOWN -> 0x0000
        public const int FILE_TYPE_UNKNOWN = 0;

        /// FILE_TYPE_REMOTE -> 0x8000
        public const int FILE_TYPE_REMOTE = 32768;

        /// FILE_TYPE_PIPE -> 0x0003
        public const int FILE_TYPE_PIPE = 3;

        /// FILE_TYPE_DISK -> 0x0001
        public const int FILE_TYPE_DISK = 1;

        /// FILE_TYPE_CHAR -> 0x0002
        public const int FILE_TYPE_CHAR = 2;

        /// FILE_TRAVERSE -> ( 0x0020 )
        public const int FILE_TRAVERSE = 32;

        /// FILE_SYSTEM_NOT_SUPPORT -> 6
        public const int FILE_SYSTEM_NOT_SUPPORT = 6;

        /// FILE_SYSTEM_DIR -> 4
        public const int FILE_SYSTEM_DIR = 4;

        /// FILE_SYSTEM_ATTR -> 2
        public const int FILE_SYSTEM_ATTR = 2;

        /// FILE_SUPPORTS_SPARSE_FILES -> 0x00000040
        public const int FILE_SUPPORTS_SPARSE_FILES = 64;

        /// FILE_SUPPORTS_REPARSE_POINTS -> 0x00000080
        public const int FILE_SUPPORTS_REPARSE_POINTS = 128;

        /// FILE_SUPPORTS_REMOTE_STORAGE -> 0x00000100
        public const int FILE_SUPPORTS_REMOTE_STORAGE = 256;

        /// FILE_SUPPORTS_OBJECT_IDS -> 0x00010000
        public const int FILE_SUPPORTS_OBJECT_IDS = 65536;

        /// FILE_SUPPORTS_ENCRYPTION -> 0x00020000
        public const int FILE_SUPPORTS_ENCRYPTION = 131072;

        /// FILE_SPECIAL_ACCESS -> (FILE_ANY_ACCESS)
        public const int FILE_SPECIAL_ACCESS = NativeConstants.FILE_ANY_ACCESS;

        /// FILE_SHARE_WRITE -> 0x00000002
        public const int FILE_SHARE_WRITE = 2;

        /// FILE_SHARE_READ -> 0x00000001
        public const int FILE_SHARE_READ = 1;

        /// FILE_SHARE_DELETE -> 0x00000004
        public const int FILE_SHARE_DELETE = 4;

        /// FILE_SET_ENCRYPTION -> 0x00000001
        public const int FILE_SET_ENCRYPTION = 1;

        /// FILE_ROOT_DIR -> 3
        public const int FILE_ROOT_DIR = 3;

        /// FILE_READ_ONLY_VOLUME -> 0x00080000
        public const int FILE_READ_ONLY_VOLUME = 524288;

        /// FILE_READ_ONLY -> 8
        public const int FILE_READ_ONLY = 8;

        /// FILE_READ_EA -> ( 0x0008 )
        public const int FILE_READ_EA = 8;

        /// FILE_READ_DATA -> ( 0x0001 )
        public const int FILE_READ_DATA = 1;

        /// FILE_READ_ATTRIBUTES -> ( 0x0080 )
        public const int FILE_READ_ATTRIBUTES = 128;

        /// FILE_READ_ACCESS -> ( 0x0001 )
        public const int FILE_READ_ACCESS = 1;

        /// FILE_PREFETCH_TYPE_FOR_CREATE -> 0x1
        public const int FILE_PREFETCH_TYPE_FOR_CREATE = 1;

        /// FILE_PERSISTENT_ACLS -> 0x00000008
        public const int FILE_PERSISTENT_ACLS = 8;

        /// FILE_NOTIFY_CHANGE_SIZE -> 0x00000008
        public const int FILE_NOTIFY_CHANGE_SIZE = 8;

        /// FILE_NOTIFY_CHANGE_SECURITY -> 0x00000100
        public const int FILE_NOTIFY_CHANGE_SECURITY = 256;

        /// FILE_NOTIFY_CHANGE_LAST_WRITE -> 0x00000010
        public const int FILE_NOTIFY_CHANGE_LAST_WRITE = 16;

        /// FILE_NOTIFY_CHANGE_LAST_ACCESS -> 0x00000020
        public const int FILE_NOTIFY_CHANGE_LAST_ACCESS = 32;

        /// FILE_NOTIFY_CHANGE_FILE_NAME -> 0x00000001
        public const int FILE_NOTIFY_CHANGE_FILE_NAME = 1;

        /// FILE_NOTIFY_CHANGE_DIR_NAME -> 0x00000002
        public const int FILE_NOTIFY_CHANGE_DIR_NAME = 2;

        /// FILE_NOTIFY_CHANGE_CREATION -> 0x00000040
        public const int FILE_NOTIFY_CHANGE_CREATION = 64;

        /// FILE_NOTIFY_CHANGE_ATTRIBUTES -> 0x00000004
        public const int FILE_NOTIFY_CHANGE_ATTRIBUTES = 4;

        /// FILE_NAMED_STREAMS -> 0x00040000
        public const int FILE_NAMED_STREAMS = 262144;

        /// FILE_MAP_WRITE -> SECTION_MAP_WRITE
        public const int FILE_MAP_WRITE = NativeConstants.SECTION_MAP_WRITE;

        /// FILE_MAP_READ -> SECTION_MAP_READ
        public const int FILE_MAP_READ = NativeConstants.SECTION_MAP_READ;

        /// FILE_MAP_EXECUTE -> SECTION_MAP_EXECUTE_EXPLICIT
        public const int FILE_MAP_EXECUTE = NativeConstants.SECTION_MAP_EXECUTE_EXPLICIT;

        /// FILE_MAP_COPY -> SECTION_QUERY
        public const int FILE_MAP_COPY = NativeConstants.SECTION_QUERY;

        /// FILE_MAP_ALL_ACCESS -> SECTION_ALL_ACCESS
        public const int FILE_MAP_ALL_ACCESS = NativeConstants.SECTION_ALL_ACCESS;

        /// FILE_LIST_DIRECTORY -> ( 0x0001 )
        public const int FILE_LIST_DIRECTORY = 1;

        /// FILE_IS_ENCRYPTED -> 1
        public const int FILE_IS_ENCRYPTED = 1;

        /// FILE_GENERIC_WRITE -> (STANDARD_RIGHTS_WRITE    |                                   FILE_WRITE_DATA          |                                   FILE_WRITE_ATTRIBUTES    |                                   FILE_WRITE_EA            |                                   FILE_APPEND_DATA         |                                   SYNCHRONIZE)
        public const int FILE_GENERIC_WRITE = (NativeConstants.STANDARD_RIGHTS_WRITE
                    | (NativeConstants.FILE_WRITE_DATA
                    | (NativeConstants.FILE_WRITE_ATTRIBUTES
                    | (NativeConstants.FILE_WRITE_EA
                    | (NativeConstants.FILE_APPEND_DATA | NativeConstants.SYNCHRONIZE)))));

        /// FILE_GENERIC_READ -> (STANDARD_RIGHTS_READ     |                                   FILE_READ_DATA           |                                   FILE_READ_ATTRIBUTES     |                                   FILE_READ_EA             |                                   SYNCHRONIZE)
        public const int FILE_GENERIC_READ = (NativeConstants.STANDARD_RIGHTS_READ
                    | (NativeConstants.FILE_READ_DATA
                    | (NativeConstants.FILE_READ_ATTRIBUTES
                    | (NativeConstants.FILE_READ_EA | NativeConstants.SYNCHRONIZE))));

        /// FILE_GENERIC_EXECUTE -> (STANDARD_RIGHTS_EXECUTE  |                                   FILE_READ_ATTRIBUTES     |                                   FILE_EXECUTE             |                                   SYNCHRONIZE)
        public const int FILE_GENERIC_EXECUTE = (NativeConstants.STANDARD_RIGHTS_EXECUTE
                    | (NativeConstants.FILE_READ_ATTRIBUTES
                    | (NativeConstants.FILE_EXECUTE | NativeConstants.SYNCHRONIZE)));

        /// FILE_FLAG_WRITE_THROUGH -> 0x80000000
        public const int FILE_FLAG_WRITE_THROUGH = -2147483648;

        /// FILE_FLAG_SEQUENTIAL_SCAN -> 0x08000000
        public const int FILE_FLAG_SEQUENTIAL_SCAN = 134217728;

        /// FILE_FLAG_RANDOM_ACCESS -> 0x10000000
        public const int FILE_FLAG_RANDOM_ACCESS = 268435456;

        /// FILE_FLAG_POSIX_SEMANTICS -> 0x01000000
        public const int FILE_FLAG_POSIX_SEMANTICS = 16777216;

        /// FILE_FLAG_OVERLAPPED -> 0x40000000
        public const int FILE_FLAG_OVERLAPPED = 1073741824;

        /// FILE_FLAG_OPEN_REPARSE_POINT -> 0x00200000
        public const int FILE_FLAG_OPEN_REPARSE_POINT = 2097152;

        /// FILE_FLAG_OPEN_NO_RECALL -> 0x00100000
        public const int FILE_FLAG_OPEN_NO_RECALL = 1048576;

        /// FILE_FLAG_NO_BUFFERING -> 0x20000000
        public const int FILE_FLAG_NO_BUFFERING = 536870912;

        /// FILE_FLAG_FIRST_PIPE_INSTANCE -> 0x00080000
        public const int FILE_FLAG_FIRST_PIPE_INSTANCE = 524288;

        /// FILE_FLAG_DELETE_ON_CLOSE -> 0x04000000
        public const int FILE_FLAG_DELETE_ON_CLOSE = 67108864;

        /// FILE_FLAG_BACKUP_SEMANTICS -> 0x02000000
        public const int FILE_FLAG_BACKUP_SEMANTICS = 33554432;

        /// FILE_FILE_COMPRESSION -> 0x00000010
        public const int FILE_FILE_COMPRESSION = 16;

        /// FILE_EXECUTE -> ( 0x0020 )
        public const int FILE_EXECUTE = 32;

        /// FILE_END -> 2
        public const int FILE_END = 2;

        /// FILE_ENCRYPTABLE -> 0
        public const int FILE_ENCRYPTABLE = 0;

        /// FILE_DIR_DISALLOWED -> 9
        public const int FILE_DIR_DISALLOWED = 9;

        /// FILE_DEVICE_WAVE_OUT -> 0x00000026
        public const int FILE_DEVICE_WAVE_OUT = 38;

        /// FILE_DEVICE_WAVE_IN -> 0x00000025
        public const int FILE_DEVICE_WAVE_IN = 37;

        /// FILE_DEVICE_VIRTUAL_DISK -> 0x00000024
        public const int FILE_DEVICE_VIRTUAL_DISK = 36;

        /// FILE_DEVICE_VIDEO -> 0x00000023
        public const int FILE_DEVICE_VIDEO = 35;

        /// FILE_DEVICE_VDM -> 0x0000002c
        public const int FILE_DEVICE_VDM = 44;

        /// FILE_DEVICE_UNKNOWN -> 0x00000022
        public const int FILE_DEVICE_UNKNOWN = 34;

        /// FILE_DEVICE_TRANSPORT -> 0x00000021
        public const int FILE_DEVICE_TRANSPORT = 33;

        /// FILE_DEVICE_TERMSRV -> 0x00000038
        public const int FILE_DEVICE_TERMSRV = 56;

        /// FILE_DEVICE_TAPE_FILE_SYSTEM -> 0x00000020
        public const int FILE_DEVICE_TAPE_FILE_SYSTEM = 32;

        /// FILE_DEVICE_TAPE -> 0x0000001f
        public const int FILE_DEVICE_TAPE = 31;

        /// FILE_DEVICE_STREAMS -> 0x0000001e
        public const int FILE_DEVICE_STREAMS = 30;

        /// FILE_DEVICE_SOUND -> 0x0000001d
        public const int FILE_DEVICE_SOUND = 29;

        /// FILE_DEVICE_SMB -> 0x0000002e
        public const int FILE_DEVICE_SMB = 46;

        /// FILE_DEVICE_SMARTCARD -> 0x00000031
        public const int FILE_DEVICE_SMARTCARD = 49;

        /// FILE_DEVICE_SERIAL_PORT -> 0x0000001b
        public const int FILE_DEVICE_SERIAL_PORT = 27;

        /// FILE_DEVICE_SERIAL_MOUSE_PORT -> 0x0000001a
        public const int FILE_DEVICE_SERIAL_MOUSE_PORT = 26;

        /// FILE_DEVICE_SERENUM -> 0x00000037
        public const int FILE_DEVICE_SERENUM = 55;

        /// FILE_DEVICE_SCREEN -> 0x0000001c
        public const int FILE_DEVICE_SCREEN = 28;

        /// FILE_DEVICE_SCANNER -> 0x00000019
        public const int FILE_DEVICE_SCANNER = 25;

        /// FILE_DEVICE_PRINTER -> 0x00000018
        public const int FILE_DEVICE_PRINTER = 24;

        /// FILE_DEVICE_PHYSICAL_NETCARD -> 0x00000017
        public const int FILE_DEVICE_PHYSICAL_NETCARD = 23;

        /// FILE_DEVICE_PARALLEL_PORT -> 0x00000016
        public const int FILE_DEVICE_PARALLEL_PORT = 22;

        /// FILE_DEVICE_NULL -> 0x00000015
        public const int FILE_DEVICE_NULL = 21;

        /// FILE_DEVICE_NETWORK_REDIRECTOR -> 0x00000028
        public const int FILE_DEVICE_NETWORK_REDIRECTOR = 40;

        /// FILE_DEVICE_NETWORK_FILE_SYSTEM -> 0x00000014
        public const int FILE_DEVICE_NETWORK_FILE_SYSTEM = 20;

        /// FILE_DEVICE_NETWORK_BROWSER -> 0x00000013
        public const int FILE_DEVICE_NETWORK_BROWSER = 19;

        /// FILE_DEVICE_NETWORK -> 0x00000012
        public const int FILE_DEVICE_NETWORK = 18;

        /// FILE_DEVICE_NAMED_PIPE -> 0x00000011
        public const int FILE_DEVICE_NAMED_PIPE = 17;

        /// FILE_DEVICE_MULTI_UNC_PROVIDER -> 0x00000010
        public const int FILE_DEVICE_MULTI_UNC_PROVIDER = 16;

        /// FILE_DEVICE_MOUSE -> 0x0000000f
        public const int FILE_DEVICE_MOUSE = 15;

        /// FILE_DEVICE_MODEM -> 0x0000002b
        public const int FILE_DEVICE_MODEM = 43;

        /// FILE_DEVICE_MIDI_OUT -> 0x0000000e
        public const int FILE_DEVICE_MIDI_OUT = 14;

        /// FILE_DEVICE_MIDI_IN -> 0x0000000d
        public const int FILE_DEVICE_MIDI_IN = 13;

        /// FILE_DEVICE_MASS_STORAGE -> 0x0000002d
        public const int FILE_DEVICE_MASS_STORAGE = 45;

        /// FILE_DEVICE_MAILSLOT -> 0x0000000c
        public const int FILE_DEVICE_MAILSLOT = 12;

        /// FILE_DEVICE_KSEC -> 0x00000039
        public const int FILE_DEVICE_KSEC = 57;

        /// FILE_DEVICE_KS -> 0x0000002f
        public const int FILE_DEVICE_KS = 47;

        /// FILE_DEVICE_KEYBOARD -> 0x0000000b
        public const int FILE_DEVICE_KEYBOARD = 11;

        /// FILE_DEVICE_INPORT_PORT -> 0x0000000a
        public const int FILE_DEVICE_INPORT_PORT = 10;

        /// FILE_DEVICE_INFINIBAND -> 0x0000003B
        public const int FILE_DEVICE_INFINIBAND = 59;

        /// FILE_DEVICE_FULLSCREEN_VIDEO -> 0x00000034
        public const int FILE_DEVICE_FULLSCREEN_VIDEO = 52;

        /// FILE_DEVICE_FIPS -> 0x0000003A
        public const int FILE_DEVICE_FIPS = 58;

        /// FILE_DEVICE_FILE_SYSTEM -> 0x00000009
        public const int FILE_DEVICE_FILE_SYSTEM = 9;

        /// FILE_DEVICE_DVD -> 0x00000033
        public const int FILE_DEVICE_DVD = 51;

        /// FILE_DEVICE_DISK_FILE_SYSTEM -> 0x00000008
        public const int FILE_DEVICE_DISK_FILE_SYSTEM = 8;

        /// FILE_DEVICE_DISK -> 0x00000007
        public const int FILE_DEVICE_DISK = 7;

        /// FILE_DEVICE_DFS_VOLUME -> 0x00000036
        public const int FILE_DEVICE_DFS_VOLUME = 54;

        /// FILE_DEVICE_DFS_FILE_SYSTEM -> 0x00000035
        public const int FILE_DEVICE_DFS_FILE_SYSTEM = 53;

        /// FILE_DEVICE_DFS -> 0x00000006
        public const int FILE_DEVICE_DFS = 6;

        /// FILE_DEVICE_DATALINK -> 0x00000005
        public const int FILE_DEVICE_DATALINK = 5;

        /// FILE_DEVICE_CONTROLLER -> 0x00000004
        public const int FILE_DEVICE_CONTROLLER = 4;

        /// FILE_DEVICE_CHANGER -> 0x00000030
        public const int FILE_DEVICE_CHANGER = 48;

        /// FILE_DEVICE_CD_ROM_FILE_SYSTEM -> 0x00000003
        public const int FILE_DEVICE_CD_ROM_FILE_SYSTEM = 3;

        /// FILE_DEVICE_CD_ROM -> 0x00000002
        public const int FILE_DEVICE_CD_ROM = 2;

        /// FILE_DEVICE_BUS_EXTENDER -> 0x0000002a
        public const int FILE_DEVICE_BUS_EXTENDER = 42;

        /// FILE_DEVICE_BEEP -> 0x00000001
        public const int FILE_DEVICE_BEEP = 1;

        /// FILE_DEVICE_BATTERY -> 0x00000029
        public const int FILE_DEVICE_BATTERY = 41;

        /// FILE_DEVICE_ACPI -> 0x00000032
        public const int FILE_DEVICE_ACPI = 50;

        /// FILE_DEVICE_8042_PORT -> 0x00000027
        public const int FILE_DEVICE_8042_PORT = 39;

        /// FILE_DELETE_CHILD -> ( 0x0040 )
        public const int FILE_DELETE_CHILD = 64;

        /// FILE_CURRENT -> 1
        public const int FILE_CURRENT = 1;

        /// FILE_CREATE_PIPE_INSTANCE -> ( 0x0004 )
        public const int FILE_CREATE_PIPE_INSTANCE = 4;

        /// FILE_CLEAR_ENCRYPTION -> 0x00000002
        public const int FILE_CLEAR_ENCRYPTION = 2;

        /// FILE_CASE_SENSITIVE_SEARCH -> 0x00000001
        public const int FILE_CASE_SENSITIVE_SEARCH = 1;

        /// FILE_CASE_PRESERVED_NAMES -> 0x00000002
        public const int FILE_CASE_PRESERVED_NAMES = 2;

        /// FILE_BEGIN -> 0
        public const int FILE_BEGIN = 0;

        /// FILE_ATTRIBUTE_TEMPORARY -> 0x00000100
        public const int FILE_ATTRIBUTE_TEMPORARY = 256;

        /// FILE_ATTRIBUTE_SYSTEM -> 0x00000004
        public const int FILE_ATTRIBUTE_SYSTEM = 4;

        /// FILE_ATTRIBUTE_SPARSE_FILE -> 0x00000200
        public const int FILE_ATTRIBUTE_SPARSE_FILE = 512;

        /// FILE_ATTRIBUTE_REPARSE_POINT -> 0x00000400
        public const int FILE_ATTRIBUTE_REPARSE_POINT = 1024;

        /// FILE_ATTRIBUTE_READONLY -> 0x00000001
        public const int FILE_ATTRIBUTE_READONLY = 1;

        /// FILE_ATTRIBUTE_OFFLINE -> 0x00001000
        public const int FILE_ATTRIBUTE_OFFLINE = 4096;

        /// FILE_ATTRIBUTE_NOT_CONTENT_INDEXED -> 0x00002000
        public const int FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192;

        /// FILE_ATTRIBUTE_NORMAL -> 0x00000080
        public const int FILE_ATTRIBUTE_NORMAL = 128;

        /// FILE_ATTRIBUTE_HIDDEN -> 0x00000002
        public const int FILE_ATTRIBUTE_HIDDEN = 2;

        /// FILE_ATTRIBUTE_ENCRYPTED -> 0x00004000
        public const int FILE_ATTRIBUTE_ENCRYPTED = 16384;

        /// FILE_ATTRIBUTE_DIRECTORY -> 0x00000010
        public const int FILE_ATTRIBUTE_DIRECTORY = 16;

        /// FILE_ATTRIBUTE_DEVICE -> 0x00000040
        public const int FILE_ATTRIBUTE_DEVICE = 64;

        /// FILE_ATTRIBUTE_COMPRESSED -> 0x00000800
        public const int FILE_ATTRIBUTE_COMPRESSED = 2048;

        /// FILE_ATTRIBUTE_ARCHIVE -> 0x00000020
        public const int FILE_ATTRIBUTE_ARCHIVE = 32;

        /// FILE_APPEND_DATA -> ( 0x0004 )
        public const int FILE_APPEND_DATA = 4;

        /// FILE_ANY_ACCESS -> 0
        public const int FILE_ANY_ACCESS = 0;

        /// FILE_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF)
        public const int FILE_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE | 511));

        /// FILE_ADD_SUBDIRECTORY -> ( 0x0004 )
        public const int FILE_ADD_SUBDIRECTORY = 4;

        /// FILE_ADD_FILE -> ( 0x0002 )
        public const int FILE_ADD_FILE = 2;

        /// FILE_ACTION_RENAMED_OLD_NAME -> 0x00000004
        public const int FILE_ACTION_RENAMED_OLD_NAME = 4;

        /// FILE_ACTION_RENAMED_NEW_NAME -> 0x00000005
        public const int FILE_ACTION_RENAMED_NEW_NAME = 5;

        /// FILE_ACTION_REMOVED -> 0x00000002
        public const int FILE_ACTION_REMOVED = 2;

        /// FILE_ACTION_MODIFIED -> 0x00000003
        public const int FILE_ACTION_MODIFIED = 3;

        /// FILE_ACTION_ADDED -> 0x00000001
        public const int FILE_ACTION_ADDED = 1;

        /// FILESYSTEM_STATISTICS_TYPE_NTFS -> 1
        public const int FILESYSTEM_STATISTICS_TYPE_NTFS = 1;

        /// FILESYSTEM_STATISTICS_TYPE_FAT -> 2
        public const int FILESYSTEM_STATISTICS_TYPE_FAT = 2;

        /// FILEOPENORD -> 1536
        public const int FILEOPENORD = 1536;

        /// FILEOKSTRINGW -> L"commdlg_FileNameOK"
        public const string FILEOKSTRINGW = "commdlg_FileNameOK";

        /// FILEOKSTRINGA -> "commdlg_FileNameOK"
        public const string FILEOKSTRINGA = "commdlg_FileNameOK";

        /// FILEOKSTRING -> FILEOKSTRINGW
        public const string FILEOKSTRING = NativeConstants.FILEOKSTRINGW;

        /// FileEncryptionStatus -> FileEncryptionStatusW
        /// Error generating expression: Value FileEncryptionStatusW is not resolved
        public const string FileEncryptionStatus = "FileEncryptionStatusW";

        /// FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK -> 0x4
        public const int FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK = 4;

        /// FIEF_FLAG_PEEK -> 0x2
        public const int FIEF_FLAG_PEEK = 2;

        /// FIEF_FLAG_FORCE_JITUI -> 0x1
        public const int FIEF_FLAG_FORCE_JITUI = 1;

        /// FIBER_FLAG_FLOAT_SWITCH -> 0x1
        public const int FIBER_FLAG_FLOAT_SWITCH = 1;

        /// FF_SWISS -> (2<<4)
        public const int FF_SWISS = (2) << (4);

        /// FF_SCRIPT -> (4<<4)
        public const int FF_SCRIPT = (4) << (4);

        /// FF_ROMAN -> (1<<4)
        public const int FF_ROMAN = (1) << (4);

        /// FF_MODERN -> (3<<4)
        public const int FF_MODERN = (3) << (4);

        /// FF_DONTCARE -> (0<<4)
        public const int FF_DONTCARE = (0) << (4);

        /// FF_DECORATIVE -> (5<<4)
        public const int FF_DECORATIVE = (5) << (4);

        /// FE_FONTSMOOTHINGSTANDARD -> 0x0001
        public const int FE_FONTSMOOTHINGSTANDARD = 1;

        /// FE_FONTSMOOTHINGORIENTATIONRGB -> 0x0001
        public const int FE_FONTSMOOTHINGORIENTATIONRGB = 1;

        /// FE_FONTSMOOTHINGORIENTATIONBGR -> 0x0000
        public const int FE_FONTSMOOTHINGORIENTATIONBGR = 0;

        /// FE_FONTSMOOTHINGDOCKING -> 0x8000
        public const int FE_FONTSMOOTHINGDOCKING = 32768;

        /// FE_FONTSMOOTHINGCLEARTYPE -> 0x0002
        public const int FE_FONTSMOOTHINGCLEARTYPE = 2;

        /// FEATURESETTING_PSLEVEL -> 2
        public const int FEATURESETTING_PSLEVEL = 2;

        /// FEATURESETTING_PROTOCOL -> 6
        public const int FEATURESETTING_PROTOCOL = 6;

        /// FEATURESETTING_PRIVATE_END -> 0x1FFF
        public const int FEATURESETTING_PRIVATE_END = 8191;

        /// FEATURESETTING_PRIVATE_BEGIN -> 0x1000
        public const int FEATURESETTING_PRIVATE_BEGIN = 4096;

        /// FEATURESETTING_OUTPUT -> 1
        public const int FEATURESETTING_OUTPUT = 1;

        /// FEATURESETTING_NUP -> 0
        public const int FEATURESETTING_NUP = 0;

        /// FEATURESETTING_NEGATIVE -> 5
        public const int FEATURESETTING_NEGATIVE = 5;

        /// FEATURESETTING_MIRROR -> 4
        public const int FEATURESETTING_MIRROR = 4;

        /// FEATURESETTING_CUSTPAPER -> 3
        public const int FEATURESETTING_CUSTPAPER = 3;

        /// FD_WRITE -> 0x02
        public const int FD_WRITE = 2;

        /// FD_SETSIZE -> 64
        public const int FD_SETSIZE = 64;

        /// FD_READ -> 0x01
        public const int FD_READ = 1;

        /// FD_OOB -> 0x04
        public const int FD_OOB = 4;

        /// FD_CONNECT -> 0x10
        public const int FD_CONNECT = 16;

        /// FD_CLOSE -> 0x20
        public const int FD_CLOSE = 32;

        /// FD_ACCEPT -> 0x08
        public const int FD_ACCEPT = 8;

        /// FCONTROL -> 0x08
        public const int FCONTROL = 8;

        /// FatalAppExit -> FatalAppExitW
        /// Error generating expression: Value FatalAppExitW is not resolved
        public const string FatalAppExit = "FatalAppExitW";

        /// FAR -> far
        public const string FAR = NativeConstants.far;

        /// FAPPCOMMAND_OEM -> 0x1000
        public const int FAPPCOMMAND_OEM = 4096;

        /// FAPPCOMMAND_MOUSE -> 0x8000
        public const int FAPPCOMMAND_MOUSE = 32768;

        /// FAPPCOMMAND_MASK -> 0xF000
        public const int FAPPCOMMAND_MASK = 61440;

        /// FAPPCOMMAND_KEY -> 0
        public const int FAPPCOMMAND_KEY = 0;

        /// FALT -> 0x10
        public const int FALT = 16;

        /// FALSE -> 0
        public const int FALSE = 0;

        /// FAILED_ACCESS_ACE_FLAG -> (0x80)
        public const int FAILED_ACCESS_ACE_FLAG = 128;

        /// FADF_VARIANT -> ( 0x800 )
        public const int FADF_VARIANT = 2048;

        /// FADF_UNKNOWN -> ( 0x200 )
        public const int FADF_UNKNOWN = 512;

        /// FADF_STATIC -> ( 0x2 )
        public const int FADF_STATIC = 2;

        /// FADF_RESERVED -> ( 0xf008 )
        public const int FADF_RESERVED = 61448;

        /// FADF_RECORD -> ( 0x20 )
        public const int FADF_RECORD = 32;

        /// FADF_HAVEVARTYPE -> ( 0x80 )
        public const int FADF_HAVEVARTYPE = 128;

        /// FADF_HAVEIID -> ( 0x40 )
        public const int FADF_HAVEIID = 64;

        /// FADF_FIXEDSIZE -> ( 0x10 )
        public const int FADF_FIXEDSIZE = 16;

        /// FADF_EMBEDDED -> ( 0x4 )
        public const int FADF_EMBEDDED = 4;

        /// FADF_DISPATCH -> ( 0x400 )
        public const int FADF_DISPATCH = 1024;

        /// FADF_BSTR -> ( 0x100 )
        public const int FADF_BSTR = 256;

        /// FADF_AUTO -> ( 0x1 )
        public const int FADF_AUTO = 1;

        /// FACILITY_WINDOWS_CE -> 24
        public const int FACILITY_WINDOWS_CE = 24;

        /// FACILITY_WINDOWSUPDATE -> 36
        public const int FACILITY_WINDOWSUPDATE = 36;

        /// FACILITY_WINDOWS -> 8
        public const int FACILITY_WINDOWS = 8;

        /// FACILITY_WIN32 -> 7
        public const int FACILITY_WIN32 = 7;

        /// FACILITY_URT -> 19
        public const int FACILITY_URT = 19;

        /// FACILITY_UMI -> 22
        public const int FACILITY_UMI = 22;

        /// FACILITY_SXS -> 23
        public const int FACILITY_SXS = 23;

        /// FACILITY_STORAGE -> 3
        public const int FACILITY_STORAGE = 3;

        /// FACILITY_STATE_MANAGEMENT -> 34
        public const int FACILITY_STATE_MANAGEMENT = 34;

        /// FACILITY_SSPI -> 9
        public const int FACILITY_SSPI = 9;

        /// FACILITY_SETUPAPI -> 15
        public const int FACILITY_SETUPAPI = 15;

        /// FACILITY_SECURITY -> 9
        public const int FACILITY_SECURITY = 9;

        /// FACILITY_SCARD -> 16
        public const int FACILITY_SCARD = 16;

        /// FACILITY_RPC -> 1
        public const int FACILITY_RPC = 1;

        /// FACILITY_NULL -> 0
        public const int FACILITY_NULL = 0;

        /// FACILITY_NT_BIT -> 0x10000000
        public const int FACILITY_NT_BIT = 268435456;

        /// FACILITY_MSMQ -> 14
        public const int FACILITY_MSMQ = 14;

        /// FACILITY_METADIRECTORY -> 35
        public const int FACILITY_METADIRECTORY = 35;

        /// FACILITY_MEDIASERVER -> 13
        public const int FACILITY_MEDIASERVER = 13;

        /// FACILITY_ITF -> 4
        public const int FACILITY_ITF = 4;

        /// FACILITY_INTERNET -> 12
        public const int FACILITY_INTERNET = 12;

        /// FACILITY_HTTP -> 25
        public const int FACILITY_HTTP = 25;

        /// FACILITY_DPLAY -> 21
        public const int FACILITY_DPLAY = 21;

        /// FACILITY_DISPATCH -> 2
        public const int FACILITY_DISPATCH = 2;

        /// FACILITY_DIRECTORYSERVICE -> 37
        public const int FACILITY_DIRECTORYSERVICE = 37;

        /// FACILITY_CONTROL -> 10
        public const int FACILITY_CONTROL = 10;

        /// FACILITY_CONFIGURATION -> 33
        public const int FACILITY_CONFIGURATION = 33;

        /// FACILITY_COMPLUS -> 17
        public const int FACILITY_COMPLUS = 17;

        /// FACILITY_CERT -> 11
        public const int FACILITY_CERT = 11;

        /// FACILITY_BACKGROUNDCOPY -> 32
        public const int FACILITY_BACKGROUNDCOPY = 32;

        /// FACILITY_ACS -> 20
        public const int FACILITY_ACS = 20;

        /// FACILITY_AAF -> 18
        public const int FACILITY_AAF = 18;
        
        /// far -> 
        /// Error generating expression: 值不能为空。
        ///参数名: node
        public const string far = "";
    }

}
