using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// DWL_USER -> 8
        public const int DWL_USER = 8;

        /// DWL_MSGRESULT -> 0
        public const int DWL_MSGRESULT = 0;

        /// DWL_DLGPROC -> 4
        public const int DWL_DLGPROC = 4;

        /// DWLP_MSGRESULT -> 0
        public const int DWLP_MSGRESULT = 0;

        /// dwFORCE_KEY_PROTECTION_USER_SELECT -> 0x1
        public const int dwFORCE_KEY_PROTECTION_USER_SELECT = 1;

        /// dwFORCE_KEY_PROTECTION_HIGH -> 0x2
        public const int dwFORCE_KEY_PROTECTION_HIGH = 2;

        /// dwFORCE_KEY_PROTECTION_DISABLED -> 0x0
        public const int dwFORCE_KEY_PROTECTION_DISABLED = 0;

        /// DUPLICATE_SAME_ACCESS -> 0x00000002
        public const int DUPLICATE_SAME_ACCESS = 2;

        /// DUPLICATE_DEREG -> 0x07
        public const int DUPLICATE_DEREG = 7;

        /// DUPLICATE_CLOSE_SOURCE -> 0x00000001
        public const int DUPLICATE_CLOSE_SOURCE = 1;

        /// DUPLICATE -> 0x06
        public const int DUPLICATE = 6;

        /// DT_WORD_ELLIPSIS -> 0x00040000
        public const int DT_WORD_ELLIPSIS = 262144;

        /// DT_WORDBREAK -> 0x00000010
        public const int DT_WORDBREAK = 16;

        /// DT_VCENTER -> 0x00000004
        public const int DT_VCENTER = 4;

        /// DT_TOP -> 0x00000000
        public const int DT_TOP = 0;

        /// DT_TABSTOP -> 0x00000080
        public const int DT_TABSTOP = 128;

        /// DT_SINGLELINE -> 0x00000020
        public const int DT_SINGLELINE = 32;

        /// DT_RTLREADING -> 0x00020000
        public const int DT_RTLREADING = 131072;

        /// DT_RIGHT -> 0x00000002
        public const int DT_RIGHT = 2;

        /// DT_RASPRINTER -> 2
        public const int DT_RASPRINTER = 2;

        /// DT_RASDISPLAY -> 1
        public const int DT_RASDISPLAY = 1;

        /// DT_RASCAMERA -> 3
        public const int DT_RASCAMERA = 3;

        /// DT_PREFIXONLY -> 0x00200000
        public const int DT_PREFIXONLY = 2097152;

        /// DT_PLOTTER -> 0
        public const int DT_PLOTTER = 0;

        /// DT_PATH_ELLIPSIS -> 0x00004000
        public const int DT_PATH_ELLIPSIS = 16384;

        /// DT_NOPREFIX -> 0x00000800
        public const int DT_NOPREFIX = 2048;

        /// DT_NOFULLWIDTHCHARBREAK -> 0x00080000
        public const int DT_NOFULLWIDTHCHARBREAK = 524288;

        /// DT_NOCLIP -> 0x00000100
        public const int DT_NOCLIP = 256;

        /// DT_MODIFYSTRING -> 0x00010000
        public const int DT_MODIFYSTRING = 65536;

        /// DT_METAFILE -> 5
        public const int DT_METAFILE = 5;

        /// DT_LEFT -> 0x00000000
        public const int DT_LEFT = 0;

        /// DT_INTERNAL -> 0x00001000
        public const int DT_INTERNAL = 4096;

        /// DT_HIDEPREFIX -> 0x00100000
        public const int DT_HIDEPREFIX = 1048576;

        /// DT_EXTERNALLEADING -> 0x00000200
        public const int DT_EXTERNALLEADING = 512;

        /// DT_EXPANDTABS -> 0x00000040
        public const int DT_EXPANDTABS = 64;

        /// DT_END_ELLIPSIS -> 0x00008000
        public const int DT_END_ELLIPSIS = 32768;

        /// DT_EDITCONTROL -> 0x00002000
        public const int DT_EDITCONTROL = 8192;

        /// DT_DISPFILE -> 6
        public const int DT_DISPFILE = 6;

        /// DT_CHARSTREAM -> 4
        public const int DT_CHARSTREAM = 4;

        /// DT_CENTER -> 0x00000001
        public const int DT_CENTER = 1;

        /// DT_CALCRECT -> 0x00000400
        public const int DT_CALCRECT = 1024;

        /// DT_BOTTOM -> 0x00000008
        public const int DT_BOTTOM = 8;

        /// DTR_CONTROL_HANDSHAKE -> 0x02
        public const int DTR_CONTROL_HANDSHAKE = 2;

        /// DTR_CONTROL_ENABLE -> 0x01
        public const int DTR_CONTROL_ENABLE = 1;

        /// DTR_CONTROL_DISABLE -> 0x00
        public const int DTR_CONTROL_DISABLE = 0;

        /// DS_S_SUCCESS -> NO_ERROR
        public const int DS_S_SUCCESS = NativeConstants.NO_ERROR;

        /// DS_SYSMODAL -> 0x02L
        public const int DS_SYSMODAL = 2;

        /// DS_SHELLFONT -> (DS_SETFONT | DS_FIXEDSYS)
        public const int DS_SHELLFONT = (NativeConstants.DS_SETFONT | NativeConstants.DS_FIXEDSYS);

        /// DS_SETFOREGROUND -> 0x200L
        public const int DS_SETFOREGROUND = 512;

        /// DS_SETFONT -> 0x40L
        public const int DS_SETFONT = 64;

        /// DS_NOIDLEMSG -> 0x100L
        public const int DS_NOIDLEMSG = 256;

        /// DS_NOFAILCREATE -> 0x0010L
        public const int DS_NOFAILCREATE = 16;

        /// DS_MODALFRAME -> 0x80L
        public const int DS_MODALFRAME = 128;

        /// DS_LOCALEDIT -> 0x20L
        public const int DS_LOCALEDIT = 32;

        /// DS_FIXEDSYS -> 0x0008L
        public const int DS_FIXEDSYS = 8;

        /// DS_CONTROL -> 0x0400L
        public const int DS_CONTROL = 1024;

        /// DS_CONTEXTHELP -> 0x2000L
        public const int DS_CONTEXTHELP = 8192;

        /// DS_CENTERMOUSE -> 0x1000L
        public const int DS_CENTERMOUSE = 4096;

        /// DS_CENTER -> 0x0800L
        public const int DS_CENTER = 2048;

        /// DS_ABSALIGN -> 0x01L
        public const int DS_ABSALIGN = 1;

        /// DS_3DLOOK -> 0x0004L
        public const int DS_3DLOOK = 4;

        /// DST_TEXT -> 0x0001
        public const int DST_TEXT = 1;

        /// DST_PREFIXTEXT -> 0x0002
        public const int DST_PREFIXTEXT = 2;

        /// DST_ICON -> 0x0003
        public const int DST_ICON = 3;

        /// DST_COMPLEX -> 0x0000
        public const int DST_COMPLEX = 0;

        /// DST_BITMAP -> 0x0004
        public const int DST_BITMAP = 4;

        /// DSS_UNION -> 0x0010
        public const int DSS_UNION = 16;

        /// DSS_RIGHT -> 0x8000
        public const int DSS_RIGHT = 32768;

        /// DSS_PREFIXONLY -> 0x0400
        public const int DSS_PREFIXONLY = 1024;

        /// DSS_NORMAL -> 0x0000
        public const int DSS_NORMAL = 0;

        /// DSS_MONO -> 0x0080
        public const int DSS_MONO = 128;

        /// DSS_HIDEPREFIX -> 0x0200
        public const int DSS_HIDEPREFIX = 512;

        /// DSS_DISABLED -> 0x0020
        public const int DSS_DISABLED = 32;

        /// DSPRINT_UPDATE -> 0x00000002
        public const int DSPRINT_UPDATE = 2;

        /// DSPRINT_UNPUBLISH -> 0x00000004
        public const int DSPRINT_UNPUBLISH = 4;

        /// DSPRINT_REPUBLISH -> 0x00000008
        public const int DSPRINT_REPUBLISH = 8;

        /// DSPRINT_PUBLISH -> 0x00000001
        public const int DSPRINT_PUBLISH = 1;

        /// DSPRINT_PENDING -> 0x80000000
        public const int DSPRINT_PENDING = -2147483648;

        /// DRV_USER -> 0x4000
        public const int DRV_USER = 16384;

        /// DRV_RESTART -> DRVCNF_RESTART
        public const int DRV_RESTART = NativeConstants.DRVCNF_RESTART;

        /// DRV_RESERVED -> 0x0800
        public const int DRV_RESERVED = 2048;

        /// DRV_REMOVE -> 0x000A
        public const int DRV_REMOVE = 10;

        /// DRV_QUERYCONFIGURE -> 0x0008
        public const int DRV_QUERYCONFIGURE = 8;

        /// DRV_POWER -> 0x000F
        public const int DRV_POWER = 15;

        /// DRV_OPEN -> 0x0003
        public const int DRV_OPEN = 3;

        /// DRV_OK -> DRVCNF_OK
        public const int DRV_OK = NativeConstants.DRVCNF_OK;

        /// DRV_MCI_LAST -> (DRV_RESERVED + 0xFFF)
        public const int DRV_MCI_LAST = (NativeConstants.DRV_RESERVED + 4095);

        /// DRV_MCI_FIRST -> DRV_RESERVED
        public const int DRV_MCI_FIRST = NativeConstants.DRV_RESERVED;

        /// DRV_LOAD -> 0x0001
        public const int DRV_LOAD = 1;

        /// DRV_INSTALL -> 0x0009
        public const int DRV_INSTALL = 9;

        /// DRV_FREE -> 0x0006
        public const int DRV_FREE = 6;

        /// DRV_EXITSESSION -> 0x000B
        public const int DRV_EXITSESSION = 11;

        /// DRV_ENABLE -> 0x0002
        public const int DRV_ENABLE = 2;

        /// DRV_DISABLE -> 0x0005
        public const int DRV_DISABLE = 5;

        /// DRV_CONFIGURE -> 0x0007
        public const int DRV_CONFIGURE = 7;

        /// DRV_CLOSE -> 0x0004
        public const int DRV_CLOSE = 4;

        /// DRV_CANCEL -> DRVCNF_CANCEL
        public const int DRV_CANCEL = NativeConstants.DRVCNF_CANCEL;

        /// DRVCNF_RESTART -> 0x0002
        public const int DRVCNF_RESTART = 2;

        /// DRVCNF_OK -> 0x0001
        public const int DRVCNF_OK = 1;

        /// DRVCNF_CANCEL -> 0x0000
        public const int DRVCNF_CANCEL = 0;

        /// DROPEFFECT_SCROLL -> ( 0x80000000 )
        public const int DROPEFFECT_SCROLL = -2147483648;

        /// DROPEFFECT_NONE -> ( 0 )
        public const int DROPEFFECT_NONE = 0;

        /// DROPEFFECT_MOVE -> ( 2 )
        public const int DROPEFFECT_MOVE = 2;

        /// DROPEFFECT_LINK -> ( 4 )
        public const int DROPEFFECT_LINK = 4;

        /// DROPEFFECT_COPY -> ( 1 )
        public const int DROPEFFECT_COPY = 1;

        /// DRIVE_UNKNOWN -> 0
        public const int DRIVE_UNKNOWN = 0;

        /// DRIVE_REMOVABLE -> 2
        public const int DRIVE_REMOVABLE = 2;

        /// DRIVE_REMOTE -> 4
        public const int DRIVE_REMOTE = 4;

        /// DRIVE_RAMDISK -> 6
        public const int DRIVE_RAMDISK = 6;

        /// DRIVE_NO_ROOT_DIR -> 1
        public const int DRIVE_NO_ROOT_DIR = 1;

        /// DRIVE_FIXED -> 3
        public const int DRIVE_FIXED = 3;

        /// DRIVE_CDROM -> 5
        public const int DRIVE_CDROM = 5;

        /// DRIVER_USERMODE -> 0x00000002
        public const int DRIVER_USERMODE = 2;

        /// DRIVER_KERNELMODE -> 0x00000001
        public const int DRIVER_KERNELMODE = 1;

        /// DRIVERVERSION -> 0
        public const int DRIVERVERSION = 0;

        /// DrawTextEx -> DrawTextExW
        /// Error generating expression: Value DrawTextExW is not resolved
        public const string DrawTextEx = "DrawTextExW";

        /// DrawText -> DrawTextW
        /// Error generating expression: Value DrawTextW is not resolved
        public const string DrawText = "DrawTextW";

        /// DrawState -> DrawStateW
        /// Error generating expression: Value DrawStateW is not resolved
        public const string DrawState = "DrawStateW";

        /// DRAWPATTERNRECT -> 25
        public const int DRAWPATTERNRECT = 25;

        /// DragQueryFile -> DragQueryFileW
        /// Error generating expression: Value DragQueryFileW is not resolved
        public const string DragQueryFile = "DragQueryFileW";

        /// DRAGDROP_S_LAST -> 0x0004010FL
        public const int DRAGDROP_S_LAST = 262415;

        /// DRAGDROP_S_FIRST -> 0x00040100L
        public const int DRAGDROP_S_FIRST = 262400;

        /// DRAGDROP_E_LAST -> 0x8004010FL
        public const int DRAGDROP_E_LAST = -2147221233;

        /// DRAGDROP_E_FIRST -> 0x80040100L
        public const int DRAGDROP_E_FIRST = -2147221248;

        /// DRAFT_QUALITY -> 1
        public const int DRAFT_QUALITY = 1;

        /// DRAFTMODE -> 7
        public const int DRAFTMODE = 7;

        /// DPD_DELETE_UNUSED_FILES -> 0x00000001
        public const int DPD_DELETE_UNUSED_FILES = 1;

        /// DPD_DELETE_SPECIFIC_VERSION -> 0x00000002
        public const int DPD_DELETE_SPECIFIC_VERSION = 2;

        /// DPD_DELETE_ALL_FILES -> 0x00000004
        public const int DPD_DELETE_ALL_FILES = 4;

        /// DO_PRINTFILE -> 0x544E5250L
        public const int DO_PRINTFILE = 1414419024;

        /// DO_DROPFILE -> 0x454C4946L
        public const int DO_DROPFILE = 1162627398;

        /// DOWNLOADHEADER -> 4111
        public const int DOWNLOADHEADER = 4111;

        /// DOWNLOADFACE -> 514
        public const int DOWNLOADFACE = 514;

        /// DOUBLE_CLICK -> 0x0002
        public const int DOUBLE_CLICK = 2;

        /// DONT_RESOLVE_DLL_REFERENCES -> 0x00000001
        public const int DONT_RESOLVE_DLL_REFERENCES = 1;

        /// DOMAIN_USER_RID_MAX -> (0x000003E7L)
        public const int DOMAIN_USER_RID_MAX = 999;

        /// DOMAIN_USER_RID_KRBTGT -> (0x000001F6L)
        public const int DOMAIN_USER_RID_KRBTGT = 502;

        /// DOMAIN_USER_RID_GUEST -> (0x000001F5L)
        public const int DOMAIN_USER_RID_GUEST = 501;

        /// DOMAIN_USER_RID_ADMIN -> (0x000001F4L)
        public const int DOMAIN_USER_RID_ADMIN = 500;

        /// DOMAIN_GROUP_RID_USERS -> (0x00000201L)
        public const int DOMAIN_GROUP_RID_USERS = 513;

        /// DOMAIN_GROUP_RID_SCHEMA_ADMINS -> (0x00000206L)
        public const int DOMAIN_GROUP_RID_SCHEMA_ADMINS = 518;

        /// DOMAIN_GROUP_RID_POLICY_ADMINS -> (0x00000208L)
        public const int DOMAIN_GROUP_RID_POLICY_ADMINS = 520;

        /// DOMAIN_GROUP_RID_GUESTS -> (0x00000202L)
        public const int DOMAIN_GROUP_RID_GUESTS = 514;

        /// DOMAIN_GROUP_RID_ENTERPRISE_ADMINS -> (0x00000207L)
        public const int DOMAIN_GROUP_RID_ENTERPRISE_ADMINS = 519;

        /// DOMAIN_GROUP_RID_CONTROLLERS -> (0x00000204L)
        public const int DOMAIN_GROUP_RID_CONTROLLERS = 516;

        /// DOMAIN_GROUP_RID_COMPUTERS -> (0x00000203L)
        public const int DOMAIN_GROUP_RID_COMPUTERS = 515;

        /// DOMAIN_GROUP_RID_CERT_ADMINS -> (0x00000205L)
        public const int DOMAIN_GROUP_RID_CERT_ADMINS = 517;

        /// DOMAIN_GROUP_RID_ADMINS -> (0x00000200L)
        public const int DOMAIN_GROUP_RID_ADMINS = 512;

        /// DOMAIN_ALIAS_RID_USERS -> (0x00000221L)
        public const int DOMAIN_ALIAS_RID_USERS = 545;

        /// DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS -> (0x00000231L)
        public const int DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS = 561;

        /// DOMAIN_ALIAS_RID_SYSTEM_OPS -> (0x00000225L)
        public const int DOMAIN_ALIAS_RID_SYSTEM_OPS = 549;

        /// DOMAIN_ALIAS_RID_REPLICATOR -> (0x00000228L)
        public const int DOMAIN_ALIAS_RID_REPLICATOR = 552;

        /// DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS -> (0x0000022BL)
        public const int DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS = 555;

        /// DOMAIN_ALIAS_RID_RAS_SERVERS -> (0x00000229L)
        public const int DOMAIN_ALIAS_RID_RAS_SERVERS = 553;

        /// DOMAIN_ALIAS_RID_PRINT_OPS -> (0x00000226L)
        public const int DOMAIN_ALIAS_RID_PRINT_OPS = 550;

        /// DOMAIN_ALIAS_RID_PREW2KCOMPACCESS -> (0x0000022AL)
        public const int DOMAIN_ALIAS_RID_PREW2KCOMPACCESS = 554;

        /// DOMAIN_ALIAS_RID_POWER_USERS -> (0x00000223L)
        public const int DOMAIN_ALIAS_RID_POWER_USERS = 547;

        /// DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS -> (0x0000022CL)
        public const int DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS = 556;

        /// DOMAIN_ALIAS_RID_MONITORING_USERS -> (0x0000022EL)
        public const int DOMAIN_ALIAS_RID_MONITORING_USERS = 558;

        /// DOMAIN_ALIAS_RID_LOGGING_USERS -> (0x0000022FL)
        public const int DOMAIN_ALIAS_RID_LOGGING_USERS = 559;

        /// DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS -> (0x0000022DL)
        public const int DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS = 557;

        /// DOMAIN_ALIAS_RID_GUESTS -> (0x00000222L)
        public const int DOMAIN_ALIAS_RID_GUESTS = 546;

        /// DOMAIN_ALIAS_RID_DCOM_USERS -> (0x00000232L)
        public const int DOMAIN_ALIAS_RID_DCOM_USERS = 562;

        /// DOMAIN_ALIAS_RID_BACKUP_OPS -> (0x00000227L)
        public const int DOMAIN_ALIAS_RID_BACKUP_OPS = 551;

        /// DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS -> (0x00000230L)
        public const int DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS = 560;

        /// DOMAIN_ALIAS_RID_ADMINS -> (0x00000220L)
        public const int DOMAIN_ALIAS_RID_ADMINS = 544;

        /// DOMAIN_ALIAS_RID_ACCOUNT_OPS -> (0x00000224L)
        public const int DOMAIN_ALIAS_RID_ACCOUNT_OPS = 548;

        /// DOF_SHELLDATA -> 0x0002
        public const int DOF_SHELLDATA = 2;

        /// DOF_PROGMAN -> 0x0001
        public const int DOF_PROGMAN = 1;

        /// DOF_MULTIPLE -> 0x8004
        public const int DOF_MULTIPLE = 32772;

        /// DOF_EXECUTABLE -> 0x8001
        public const int DOF_EXECUTABLE = 32769;

        /// DOF_DOCUMENT -> 0x8002
        public const int DOF_DOCUMENT = 32770;

        /// DOF_DIRECTORY -> 0x8003
        public const int DOF_DIRECTORY = 32771;

        /// DoEnvironmentSubst -> DoEnvironmentSubstW
        /// Error generating expression: Value DoEnvironmentSubstW is not resolved
        public const string DoEnvironmentSubst = "DoEnvironmentSubstW";

        /// DocumentProperties -> DocumentPropertiesW
        /// Error generating expression: Value DocumentPropertiesW is not resolved
        public const string DocumentProperties = "DocumentPropertiesW";

        /// DOCKINFO_USER_UNDOCKED -> (DOCKINFO_USER_SUPPLIED | DOCKINFO_UNDOCKED)
        public const int DOCKINFO_USER_UNDOCKED = (NativeConstants.DOCKINFO_USER_SUPPLIED | NativeConstants.DOCKINFO_UNDOCKED);

        /// DOCKINFO_USER_SUPPLIED -> (0x4)
        public const int DOCKINFO_USER_SUPPLIED = 4;

        /// DOCKINFO_USER_DOCKED -> (DOCKINFO_USER_SUPPLIED | DOCKINFO_DOCKED)
        public const int DOCKINFO_USER_DOCKED = (NativeConstants.DOCKINFO_USER_SUPPLIED | NativeConstants.DOCKINFO_DOCKED);

        /// DOCKINFO_UNDOCKED -> (0x1)
        public const int DOCKINFO_UNDOCKED = 1;

        /// DOCKINFO_DOCKED -> (0x2)
        public const int DOCKINFO_DOCKED = 2;

        /// DN_DEFAULTPRN -> 0x0001
        public const int DN_DEFAULTPRN = 1;

        /// DNS_WARNING_PTR_CREATE_FAILED -> 9715L
        public const int DNS_WARNING_PTR_CREATE_FAILED = 9715;

        /// DNS_WARNING_DOMAIN_UNDELETED -> 9716L
        public const int DNS_WARNING_DOMAIN_UNDELETED = 9716;

        /// DNS_UNREGISTER -> 0x0002
        public const int DNS_UNREGISTER = 2;

        /// DNS_STATUS_SINGLE_PART_NAME -> 9559L
        public const int DNS_STATUS_SINGLE_PART_NAME = 9559;

        /// DNS_STATUS_PACKET_UNSECURE -> DNS_ERROR_UNSECURE_PACKET
        public const int DNS_STATUS_PACKET_UNSECURE = NativeConstants.DNS_ERROR_UNSECURE_PACKET;

        /// DNS_STATUS_FQDN -> 9557L
        public const int DNS_STATUS_FQDN = 9557;

        /// DNS_STATUS_DOTTED_NAME -> 9558L
        public const int DNS_STATUS_DOTTED_NAME = 9558;

        /// DNS_STATUS_CONTINUE_NEEDED -> 9801L
        public const int DNS_STATUS_CONTINUE_NEEDED = 9801;

        /// DNS_REGISTER -> 0x0001
        public const int DNS_REGISTER = 1;

        /// DNS_INFO_NO_RECORDS -> 9501L
        public const int DNS_INFO_NO_RECORDS = 9501;

        /// DNS_INFO_AXFR_COMPLETE -> 9751L
        public const int DNS_INFO_AXFR_COMPLETE = 9751;

        /// DNS_INFO_ADDED_LOCAL_WINS -> 9753L
        public const int DNS_INFO_ADDED_LOCAL_WINS = 9753;

        /// DNS_FILTERON -> 0x0004
        public const int DNS_FILTERON = 4;

        /// DNS_FILTEROFF -> 0x0008
        public const int DNS_FILTEROFF = 8;

        /// DNS_ERROR_ZONE_REQUIRES_MASTER_IP -> 9620L
        public const int DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620;

        /// DNS_ERROR_ZONE_NOT_SECONDARY -> 9613L
        public const int DNS_ERROR_ZONE_NOT_SECONDARY = 9613;

        /// DNS_ERROR_ZONE_LOCKED -> 9607L
        public const int DNS_ERROR_ZONE_LOCKED = 9607;

        /// DNS_ERROR_ZONE_IS_SHUTDOWN -> 9621L
        public const int DNS_ERROR_ZONE_IS_SHUTDOWN = 9621;

        /// DNS_ERROR_ZONE_HAS_NO_SOA_RECORD -> 9605L
        public const int DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605;

        /// DNS_ERROR_ZONE_HAS_NO_NS_RECORDS -> 9606L
        public const int DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606;

        /// DNS_ERROR_ZONE_DOES_NOT_EXIST -> 9601L
        public const int DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601;

        /// DNS_ERROR_ZONE_CREATION_FAILED -> 9608L
        public const int DNS_ERROR_ZONE_CREATION_FAILED = 9608;

        /// DNS_ERROR_ZONE_CONFIGURATION_ERROR -> 9604L
        public const int DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604;

        /// DNS_ERROR_ZONE_BASE -> 9600
        public const int DNS_ERROR_ZONE_BASE = 9600;

        /// DNS_ERROR_ZONE_ALREADY_EXISTS -> 9609L
        public const int DNS_ERROR_ZONE_ALREADY_EXISTS = 9609;

        /// DNS_ERROR_WINS_INIT_FAILED -> 9615L
        public const int DNS_ERROR_WINS_INIT_FAILED = 9615;

        /// DNS_ERROR_UNSECURE_PACKET -> 9505L
        public const int DNS_ERROR_UNSECURE_PACKET = 9505;

        /// DNS_ERROR_UNKNOWN_RECORD_TYPE -> 9704L
        public const int DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704;

        /// DNS_ERROR_TRY_AGAIN_LATER -> 9554L
        public const int DNS_ERROR_TRY_AGAIN_LATER = 9554;

        /// DNS_ERROR_SOA_DELETE_INVALID -> 9618L
        public const int DNS_ERROR_SOA_DELETE_INVALID = 9618;

        /// DNS_ERROR_SETUP_BASE -> 9850
        public const int DNS_ERROR_SETUP_BASE = 9850;

        /// DNS_ERROR_SECURE_BASE -> 9800
        public const int DNS_ERROR_SECURE_BASE = 9800;

        /// DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP -> 9612L
        public const int DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612;

        /// DNS_ERROR_SECONDARY_DATA -> 9712L
        public const int DNS_ERROR_SECONDARY_DATA = 9712;

        /// DNS_ERROR_RESPONSE_CODES_BASE -> 9000
        public const int DNS_ERROR_RESPONSE_CODES_BASE = 9000;

        /// DNS_ERROR_RECORD_TIMED_OUT -> 9705L
        public const int DNS_ERROR_RECORD_TIMED_OUT = 9705;

        /// DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT -> 9710L
        public const int DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710;

        /// DNS_ERROR_RECORD_FORMAT -> 9702L
        public const int DNS_ERROR_RECORD_FORMAT = 9702;

        /// DNS_ERROR_RECORD_DOES_NOT_EXIST -> 9701L
        public const int DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701;

        /// DNS_ERROR_RECORD_ALREADY_EXISTS -> 9711L
        public const int DNS_ERROR_RECORD_ALREADY_EXISTS = 9711;

        /// DNS_ERROR_RCODE_YXRRSET -> 9007L
        public const int DNS_ERROR_RCODE_YXRRSET = 9007;

        /// DNS_ERROR_RCODE_YXDOMAIN -> 9006L
        public const int DNS_ERROR_RCODE_YXDOMAIN = 9006;

        /// DNS_ERROR_RCODE_SERVER_FAILURE -> 9002L
        public const int DNS_ERROR_RCODE_SERVER_FAILURE = 9002;

        /// DNS_ERROR_RCODE_REFUSED -> 9005L
        public const int DNS_ERROR_RCODE_REFUSED = 9005;

        /// DNS_ERROR_RCODE_NXRRSET -> 9008L
        public const int DNS_ERROR_RCODE_NXRRSET = 9008;

        /// DNS_ERROR_RCODE_NO_ERROR -> NO_ERROR
        public const int DNS_ERROR_RCODE_NO_ERROR = NativeConstants.NO_ERROR;

        /// DNS_ERROR_RCODE_NOT_IMPLEMENTED -> 9004L
        public const int DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004;

        /// DNS_ERROR_RCODE_NOTZONE -> 9010L
        public const int DNS_ERROR_RCODE_NOTZONE = 9010;

        /// DNS_ERROR_RCODE_NOTAUTH -> 9009L
        public const int DNS_ERROR_RCODE_NOTAUTH = 9009;

        /// DNS_ERROR_RCODE_NAME_ERROR -> 9003L
        public const int DNS_ERROR_RCODE_NAME_ERROR = 9003;

        /// DNS_ERROR_RCODE_LAST -> DNS_ERROR_RCODE_BADTIME
        public const int DNS_ERROR_RCODE_LAST = NativeConstants.DNS_ERROR_RCODE_BADTIME;

        /// DNS_ERROR_RCODE_FORMAT_ERROR -> 9001L
        public const int DNS_ERROR_RCODE_FORMAT_ERROR = 9001;

        /// DNS_ERROR_RCODE_BADTIME -> 9018L
        public const int DNS_ERROR_RCODE_BADTIME = 9018;

        /// DNS_ERROR_RCODE_BADSIG -> 9016L
        public const int DNS_ERROR_RCODE_BADSIG = 9016;

        /// DNS_ERROR_RCODE_BADKEY -> 9017L
        public const int DNS_ERROR_RCODE_BADKEY = 9017;

        /// DNS_ERROR_RCODE -> 9504L
        public const int DNS_ERROR_RCODE = 9504;

        /// DNS_ERROR_PRIMARY_REQUIRES_DATAFILE -> 9651L
        public const int DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651;

        /// DNS_ERROR_PACKET_FMT_BASE -> 9500
        public const int DNS_ERROR_PACKET_FMT_BASE = 9500;

        /// DNS_ERROR_OPERATION_BASE -> 9750
        public const int DNS_ERROR_OPERATION_BASE = 9750;

        /// DNS_ERROR_NUMERIC_NAME -> 9561L
        public const int DNS_ERROR_NUMERIC_NAME = 9561;

        /// DNS_ERROR_NO_ZONE_INFO -> 9602L
        public const int DNS_ERROR_NO_ZONE_INFO = 9602;

        /// DNS_ERROR_NO_TCPIP -> 9851L
        public const int DNS_ERROR_NO_TCPIP = 9851;

        /// DNS_ERROR_NO_PACKET -> 9503L
        public const int DNS_ERROR_NO_PACKET = 9503;

        /// DNS_ERROR_NO_MEMORY -> ERROR_OUTOFMEMORY
        public const int DNS_ERROR_NO_MEMORY = NativeConstants.ERROR_OUTOFMEMORY;

        /// DNS_ERROR_NO_DNS_SERVERS -> 9852L
        public const int DNS_ERROR_NO_DNS_SERVERS = 9852;

        /// DNS_ERROR_NO_CREATE_CACHE_DATA -> 9713L
        public const int DNS_ERROR_NO_CREATE_CACHE_DATA = 9713;

        /// DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE -> 9719L
        public const int DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719;

        /// DNS_ERROR_NOT_UNIQUE -> 9555L
        public const int DNS_ERROR_NOT_UNIQUE = 9555;

        /// DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION -> 9563L
        public const int DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563;

        /// DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER -> 9562L
        public const int DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562;

        /// DNS_ERROR_NON_RFC_NAME -> 9556L
        public const int DNS_ERROR_NON_RFC_NAME = 9556;

        /// DNS_ERROR_NODE_IS_CNAME -> 9708L
        public const int DNS_ERROR_NODE_IS_CNAME = 9708;

        /// DNS_ERROR_NODE_CREATION_FAILED -> 9703L
        public const int DNS_ERROR_NODE_CREATION_FAILED = 9703;

        /// DNS_ERROR_NEED_WINS_SERVERS -> 9616L
        public const int DNS_ERROR_NEED_WINS_SERVERS = 9616;

        /// DNS_ERROR_NEED_SECONDARY_ADDRESSES -> 9614L
        public const int DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614;

        /// DNS_ERROR_NBSTAT_INIT_FAILED -> 9617L
        public const int DNS_ERROR_NBSTAT_INIT_FAILED = 9617;

        /// DNS_ERROR_NAME_NOT_IN_ZONE -> 9706L
        public const int DNS_ERROR_NAME_NOT_IN_ZONE = 9706;

        /// DNS_ERROR_NAME_DOES_NOT_EXIST -> 9714L
        public const int DNS_ERROR_NAME_DOES_NOT_EXIST = 9714;

        /// DNS_ERROR_MASK -> 0x00002328
        public const int DNS_ERROR_MASK = 9000;

        /// DNS_ERROR_INVALID_ZONE_TYPE -> 9611L
        public const int DNS_ERROR_INVALID_ZONE_TYPE = 9611;

        /// DNS_ERROR_INVALID_ZONE_OPERATION -> 9603L
        public const int DNS_ERROR_INVALID_ZONE_OPERATION = 9603;

        /// DNS_ERROR_INVALID_TYPE -> 9551L
        public const int DNS_ERROR_INVALID_TYPE = 9551;

        /// DNS_ERROR_INVALID_PROPERTY -> 9553L
        public const int DNS_ERROR_INVALID_PROPERTY = 9553;

        /// DNS_ERROR_INVALID_NAME_CHAR -> 9560L
        public const int DNS_ERROR_INVALID_NAME_CHAR = 9560;

        /// DNS_ERROR_INVALID_NAME -> ERROR_INVALID_NAME
        public const int DNS_ERROR_INVALID_NAME = NativeConstants.ERROR_INVALID_NAME;

        /// DNS_ERROR_INVALID_IP_ADDRESS -> 9552L
        public const int DNS_ERROR_INVALID_IP_ADDRESS = 9552;

        /// DNS_ERROR_INVALID_DATAFILE_NAME -> 9652L
        public const int DNS_ERROR_INVALID_DATAFILE_NAME = 9652;

        /// DNS_ERROR_INVALID_DATA -> ERROR_INVALID_DATA
        public const int DNS_ERROR_INVALID_DATA = NativeConstants.ERROR_INVALID_DATA;

        /// DNS_ERROR_INCONSISTENT_ROOT_HINTS -> 9565L
        public const int DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565;

        /// DNS_ERROR_GENERAL_API_BASE -> 9550
        public const int DNS_ERROR_GENERAL_API_BASE = 9550;

        /// DNS_ERROR_FORWARDER_ALREADY_EXISTS -> 9619L
        public const int DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619;

        /// DNS_ERROR_FILE_WRITEBACK_FAILED -> 9654L
        public const int DNS_ERROR_FILE_WRITEBACK_FAILED = 9654;

        /// DNS_ERROR_DS_ZONE_ALREADY_EXISTS -> 9718L
        public const int DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718;

        /// DNS_ERROR_DS_UNAVAILABLE -> 9717L
        public const int DNS_ERROR_DS_UNAVAILABLE = 9717;

        /// DNS_ERROR_DP_NOT_ENLISTED -> 9903L
        public const int DNS_ERROR_DP_NOT_ENLISTED = 9903;

        /// DNS_ERROR_DP_NOT_AVAILABLE -> 9905L
        public const int DNS_ERROR_DP_NOT_AVAILABLE = 9905;

        /// DNS_ERROR_DP_FSMO_ERROR -> 9906L
        public const int DNS_ERROR_DP_FSMO_ERROR = 9906;

        /// DNS_ERROR_DP_DOES_NOT_EXIST -> 9901L
        public const int DNS_ERROR_DP_DOES_NOT_EXIST = 9901;

        /// DNS_ERROR_DP_BASE -> 9900
        public const int DNS_ERROR_DP_BASE = 9900;

        /// DNS_ERROR_DP_ALREADY_EXISTS -> 9902L
        public const int DNS_ERROR_DP_ALREADY_EXISTS = 9902;

        /// DNS_ERROR_DP_ALREADY_ENLISTED -> 9904L
        public const int DNS_ERROR_DP_ALREADY_ENLISTED = 9904;

        /// DNS_ERROR_DATAFILE_PARSING -> 9655L
        public const int DNS_ERROR_DATAFILE_PARSING = 9655;

        /// DNS_ERROR_DATAFILE_OPEN_FAILURE -> 9653L
        public const int DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653;

        /// DNS_ERROR_DATAFILE_BASE -> 9650
        public const int DNS_ERROR_DATAFILE_BASE = 9650;

        /// DNS_ERROR_DATABASE_BASE -> 9700
        public const int DNS_ERROR_DATABASE_BASE = 9700;

        /// DNS_ERROR_CNAME_LOOP -> 9707L
        public const int DNS_ERROR_CNAME_LOOP = 9707;

        /// DNS_ERROR_CNAME_COLLISION -> 9709L
        public const int DNS_ERROR_CNAME_COLLISION = 9709;

        /// DNS_ERROR_CANNOT_FIND_ROOT_HINTS -> 9564L
        public const int DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564;

        /// DNS_ERROR_BAD_PACKET -> 9502L
        public const int DNS_ERROR_BAD_PACKET = 9502;

        /// DNS_ERROR_AXFR -> 9752L
        public const int DNS_ERROR_AXFR = 9752;

        /// DNS_ERROR_AUTOZONE_ALREADY_EXISTS -> 9610L
        public const int DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610;

        /// DnsHostnameToComputerName -> DnsHostnameToComputerNameW
        /// Error generating expression: Value DnsHostnameToComputerNameW is not resolved
        public const string DnsHostnameToComputerName = "DnsHostnameToComputerNameW";

        /// DM_YRESOLUTION -> 0x00002000L
        public const int DM_YRESOLUTION = 8192;

        /// DM_UPDATE -> 1
        public const int DM_UPDATE = 1;

        /// DM_TTOPTION -> 0x00004000L
        public const int DM_TTOPTION = 16384;

        /// DM_SPECVERSION -> 0x0401
        public const int DM_SPECVERSION = 1025;

        /// DM_SETDEFID -> (WM_USER+1)
        public const int DM_SETDEFID = (NativeConstants.WM_USER + 1);

        /// DM_SCALE -> 0x00000010L
        public const int DM_SCALE = 16;

        /// DM_REPOSITION -> (WM_USER+2)
        public const int DM_REPOSITION = (NativeConstants.WM_USER + 2);

        /// DM_PROMPT -> 4
        public const int DM_PROMPT = 4;

        /// DM_PRINTQUALITY -> 0x00000400L
        public const int DM_PRINTQUALITY = 1024;

        /// DM_POSITION -> 0x00000020L
        public const int DM_POSITION = 32;

        /// DM_PELSWIDTH -> 0x00080000L
        public const int DM_PELSWIDTH = 524288;

        /// DM_PELSHEIGHT -> 0x00100000L
        public const int DM_PELSHEIGHT = 1048576;

        /// DM_PAPERWIDTH -> 0x00000008L
        public const int DM_PAPERWIDTH = 8;

        /// DM_PAPERSIZE -> 0x00000002L
        public const int DM_PAPERSIZE = 2;

        /// DM_PAPERLENGTH -> 0x00000004L
        public const int DM_PAPERLENGTH = 4;

        /// DM_PANNINGWIDTH -> 0x08000000L
        public const int DM_PANNINGWIDTH = 134217728;

        /// DM_PANNINGHEIGHT -> 0x10000000L
        public const int DM_PANNINGHEIGHT = 268435456;

        /// DM_OUT_DEFAULT -> DM_UPDATE
        public const int DM_OUT_DEFAULT = NativeConstants.DM_UPDATE;

        /// DM_OUT_BUFFER -> DM_COPY
        public const int DM_OUT_BUFFER = NativeConstants.DM_COPY;

        /// DM_ORIENTATION -> 0x00000001L
        public const int DM_ORIENTATION = 1;

        /// DM_NUP -> 0x00000040L
        public const int DM_NUP = 64;

        /// DM_MODIFY -> 8
        public const int DM_MODIFY = 8;

        /// DM_MEDIATYPE -> 0x02000000L
        public const int DM_MEDIATYPE = 33554432;

        /// DM_LOGPIXELS -> 0x00020000L
        public const int DM_LOGPIXELS = 131072;

        /// DM_IN_PROMPT -> DM_PROMPT
        public const int DM_IN_PROMPT = NativeConstants.DM_PROMPT;

        /// DM_IN_BUFFER -> DM_MODIFY
        public const int DM_IN_BUFFER = NativeConstants.DM_MODIFY;

        /// DM_ICMMETHOD -> 0x00800000L
        public const int DM_ICMMETHOD = 8388608;

        /// DM_ICMINTENT -> 0x01000000L
        public const int DM_ICMINTENT = 16777216;

        /// DM_GETDEFID -> (WM_USER+0)
        public const int DM_GETDEFID = (NativeConstants.WM_USER + 0);

        /// DM_FORMNAME -> 0x00010000L
        public const int DM_FORMNAME = 65536;

        /// DM_DUPLEX -> 0x00001000L
        public const int DM_DUPLEX = 4096;

        /// DM_DITHERTYPE -> 0x04000000L
        public const int DM_DITHERTYPE = 67108864;

        /// DM_DISPLAYORIENTATION -> 0x00000080L
        public const int DM_DISPLAYORIENTATION = 128;

        /// DM_DISPLAYFREQUENCY -> 0x00400000L
        public const int DM_DISPLAYFREQUENCY = 4194304;

        /// DM_DISPLAYFLAGS -> 0x00200000L
        public const int DM_DISPLAYFLAGS = 2097152;

        /// DM_DISPLAYFIXEDOUTPUT -> 0x20000000L
        public const int DM_DISPLAYFIXEDOUTPUT = 536870912;

        /// DM_DEFAULTSOURCE -> 0x00000200L
        public const int DM_DEFAULTSOURCE = 512;

        /// DM_COPY -> 2
        public const int DM_COPY = 2;

        /// DM_COPIES -> 0x00000100L
        public const int DM_COPIES = 256;

        /// DM_COLOR -> 0x00000800L
        public const int DM_COLOR = 2048;

        /// DM_COLLATE -> 0x00008000L
        public const int DM_COLLATE = 32768;

        /// DM_BITSPERPEL -> 0x00040000L
        public const int DM_BITSPERPEL = 262144;

        /// DMTT_SUBDEV -> 3
        public const int DMTT_SUBDEV = 3;

        /// DMTT_DOWNLOAD_OUTLINE -> 4
        public const int DMTT_DOWNLOAD_OUTLINE = 4;

        /// DMTT_DOWNLOAD -> 2
        public const int DMTT_DOWNLOAD = 2;

        /// DMTT_BITMAP -> 1
        public const int DMTT_BITMAP = 1;

        /// DMRES_MEDIUM -> (-3)
        public const int DMRES_MEDIUM = -3;

        /// DMRES_LOW -> (-2)
        public const int DMRES_LOW = -2;

        /// DMRES_HIGH -> (-4)
        public const int DMRES_HIGH = -4;

        /// DMRES_DRAFT -> (-1)
        public const int DMRES_DRAFT = -1;

        /// DMPAPER_USER -> 256
        public const int DMPAPER_USER = 256;

        /// DMPAPER_TABLOID_EXTRA -> 52
        public const int DMPAPER_TABLOID_EXTRA = 52;

        /// DMPAPER_TABLOID -> 3
        public const int DMPAPER_TABLOID = 3;

        /// DMPAPER_STATEMENT -> 6
        public const int DMPAPER_STATEMENT = 6;

        /// DMPAPER_RESERVED_49 -> 49
        public const int DMPAPER_RESERVED_49 = 49;

        /// DMPAPER_RESERVED_48 -> 48
        public const int DMPAPER_RESERVED_48 = 48;

        /// DMPAPER_QUARTO -> 15
        public const int DMPAPER_QUARTO = 15;

        /// DMPAPER_PENV_9_ROTATED -> 117
        public const int DMPAPER_PENV_9_ROTATED = 117;

        /// DMPAPER_PENV_9 -> 104
        public const int DMPAPER_PENV_9 = 104;

        /// DMPAPER_PENV_8_ROTATED -> 116
        public const int DMPAPER_PENV_8_ROTATED = 116;

        /// DMPAPER_PENV_8 -> 103
        public const int DMPAPER_PENV_8 = 103;

        /// DMPAPER_PENV_7_ROTATED -> 115
        public const int DMPAPER_PENV_7_ROTATED = 115;

        /// DMPAPER_PENV_7 -> 102
        public const int DMPAPER_PENV_7 = 102;

        /// DMPAPER_PENV_6_ROTATED -> 114
        public const int DMPAPER_PENV_6_ROTATED = 114;

        /// DMPAPER_PENV_6 -> 101
        public const int DMPAPER_PENV_6 = 101;

        /// DMPAPER_PENV_5_ROTATED -> 113
        public const int DMPAPER_PENV_5_ROTATED = 113;

        /// DMPAPER_PENV_5 -> 100
        public const int DMPAPER_PENV_5 = 100;

        /// DMPAPER_PENV_4_ROTATED -> 112
        public const int DMPAPER_PENV_4_ROTATED = 112;

        /// DMPAPER_PENV_4 -> 99
        public const int DMPAPER_PENV_4 = 99;

        /// DMPAPER_PENV_3_ROTATED -> 111
        public const int DMPAPER_PENV_3_ROTATED = 111;

        /// DMPAPER_PENV_3 -> 98
        public const int DMPAPER_PENV_3 = 98;

        /// DMPAPER_PENV_2_ROTATED -> 110
        public const int DMPAPER_PENV_2_ROTATED = 110;

        /// DMPAPER_PENV_2 -> 97
        public const int DMPAPER_PENV_2 = 97;

        /// DMPAPER_PENV_1_ROTATED -> 109
        public const int DMPAPER_PENV_1_ROTATED = 109;

        /// DMPAPER_PENV_10_ROTATED -> 118
        public const int DMPAPER_PENV_10_ROTATED = 118;

        /// DMPAPER_PENV_10 -> 105
        public const int DMPAPER_PENV_10 = 105;

        /// DMPAPER_PENV_1 -> 96
        public const int DMPAPER_PENV_1 = 96;

        /// DMPAPER_P32K_ROTATED -> 107
        public const int DMPAPER_P32K_ROTATED = 107;

        /// DMPAPER_P32KBIG_ROTATED -> 108
        public const int DMPAPER_P32KBIG_ROTATED = 108;

        /// DMPAPER_P32KBIG -> 95
        public const int DMPAPER_P32KBIG = 95;

        /// DMPAPER_P32K -> 94
        public const int DMPAPER_P32K = 94;

        /// DMPAPER_P16K_ROTATED -> 106
        public const int DMPAPER_P16K_ROTATED = 106;

        /// DMPAPER_P16K -> 93
        public const int DMPAPER_P16K = 93;

        /// DMPAPER_NOTE -> 18
        public const int DMPAPER_NOTE = 18;

        /// DMPAPER_LETTER_TRANSVERSE -> 54
        public const int DMPAPER_LETTER_TRANSVERSE = 54;

        /// DMPAPER_LETTER_ROTATED -> 75
        public const int DMPAPER_LETTER_ROTATED = 75;

        /// DMPAPER_LETTER_PLUS -> 59
        public const int DMPAPER_LETTER_PLUS = 59;

        /// DMPAPER_LETTER_EXTRA_TRANSVERSE -> 56
        public const int DMPAPER_LETTER_EXTRA_TRANSVERSE = 56;

        /// DMPAPER_LETTER_EXTRA -> 50
        public const int DMPAPER_LETTER_EXTRA = 50;

        /// DMPAPER_LETTERSMALL -> 2
        public const int DMPAPER_LETTERSMALL = 2;

        /// DMPAPER_LETTER -> 1
        public const int DMPAPER_LETTER = 1;

        /// DMPAPER_LEGAL_EXTRA -> 51
        public const int DMPAPER_LEGAL_EXTRA = 51;

        /// DMPAPER_LEGAL -> 5
        public const int DMPAPER_LEGAL = 5;

        /// DMPAPER_LEDGER -> 4
        public const int DMPAPER_LEDGER = 4;

        /// DMPAPER_LAST -> DMPAPER_PENV_10_ROTATED
        public const int DMPAPER_LAST = NativeConstants.DMPAPER_PENV_10_ROTATED;

        /// DMPAPER_JENV_YOU4_ROTATED -> 92
        public const int DMPAPER_JENV_YOU4_ROTATED = 92;

        /// DMPAPER_JENV_YOU4 -> 91
        public const int DMPAPER_JENV_YOU4 = 91;

        /// DMPAPER_JENV_KAKU3_ROTATED -> 85
        public const int DMPAPER_JENV_KAKU3_ROTATED = 85;

        /// DMPAPER_JENV_KAKU3 -> 72
        public const int DMPAPER_JENV_KAKU3 = 72;

        /// DMPAPER_JENV_KAKU2_ROTATED -> 84
        public const int DMPAPER_JENV_KAKU2_ROTATED = 84;

        /// DMPAPER_JENV_KAKU2 -> 71
        public const int DMPAPER_JENV_KAKU2 = 71;

        /// DMPAPER_JENV_CHOU4_ROTATED -> 87
        public const int DMPAPER_JENV_CHOU4_ROTATED = 87;

        /// DMPAPER_JENV_CHOU4 -> 74
        public const int DMPAPER_JENV_CHOU4 = 74;

        /// DMPAPER_JENV_CHOU3_ROTATED -> 86
        public const int DMPAPER_JENV_CHOU3_ROTATED = 86;

        /// DMPAPER_JENV_CHOU3 -> 73
        public const int DMPAPER_JENV_CHOU3 = 73;

        /// DMPAPER_JAPANESE_POSTCARD_ROTATED -> 81
        public const int DMPAPER_JAPANESE_POSTCARD_ROTATED = 81;

        /// DMPAPER_JAPANESE_POSTCARD -> 43
        public const int DMPAPER_JAPANESE_POSTCARD = 43;

        /// DMPAPER_ISO_B4 -> 42
        public const int DMPAPER_ISO_B4 = 42;

        /// DMPAPER_FOLIO -> 14
        public const int DMPAPER_FOLIO = 14;

        /// DMPAPER_FIRST -> DMPAPER_LETTER
        public const int DMPAPER_FIRST = NativeConstants.DMPAPER_LETTER;

        /// DMPAPER_FANFOLD_US -> 39
        public const int DMPAPER_FANFOLD_US = 39;

        /// DMPAPER_FANFOLD_STD_GERMAN -> 40
        public const int DMPAPER_FANFOLD_STD_GERMAN = 40;

        /// DMPAPER_FANFOLD_LGL_GERMAN -> 41
        public const int DMPAPER_FANFOLD_LGL_GERMAN = 41;

        /// DMPAPER_EXECUTIVE -> 7
        public const int DMPAPER_EXECUTIVE = 7;

        /// DMPAPER_ESHEET -> 26
        public const int DMPAPER_ESHEET = 26;

        /// DMPAPER_ENV_PERSONAL -> 38
        public const int DMPAPER_ENV_PERSONAL = 38;

        /// DMPAPER_ENV_MONARCH -> 37
        public const int DMPAPER_ENV_MONARCH = 37;

        /// DMPAPER_ENV_ITALY -> 36
        public const int DMPAPER_ENV_ITALY = 36;

        /// DMPAPER_ENV_INVITE -> 47
        public const int DMPAPER_ENV_INVITE = 47;

        /// DMPAPER_ENV_DL -> 27
        public const int DMPAPER_ENV_DL = 27;

        /// DMPAPER_ENV_C65 -> 32
        public const int DMPAPER_ENV_C65 = 32;

        /// DMPAPER_ENV_C6 -> 31
        public const int DMPAPER_ENV_C6 = 31;

        /// DMPAPER_ENV_C5 -> 28
        public const int DMPAPER_ENV_C5 = 28;

        /// DMPAPER_ENV_C4 -> 30
        public const int DMPAPER_ENV_C4 = 30;

        /// DMPAPER_ENV_C3 -> 29
        public const int DMPAPER_ENV_C3 = 29;

        /// DMPAPER_ENV_B6 -> 35
        public const int DMPAPER_ENV_B6 = 35;

        /// DMPAPER_ENV_B5 -> 34
        public const int DMPAPER_ENV_B5 = 34;

        /// DMPAPER_ENV_B4 -> 33
        public const int DMPAPER_ENV_B4 = 33;

        /// DMPAPER_ENV_9 -> 19
        public const int DMPAPER_ENV_9 = 19;

        /// DMPAPER_ENV_14 -> 23
        public const int DMPAPER_ENV_14 = 23;

        /// DMPAPER_ENV_12 -> 22
        public const int DMPAPER_ENV_12 = 22;

        /// DMPAPER_ENV_11 -> 21
        public const int DMPAPER_ENV_11 = 21;

        /// DMPAPER_ENV_10 -> 20
        public const int DMPAPER_ENV_10 = 20;

        /// DMPAPER_DSHEET -> 25
        public const int DMPAPER_DSHEET = 25;

        /// DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED -> 82
        public const int DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED = 82;

        /// DMPAPER_DBL_JAPANESE_POSTCARD -> 69
        public const int DMPAPER_DBL_JAPANESE_POSTCARD = 69;

        /// DMPAPER_CSHEET -> 24
        public const int DMPAPER_CSHEET = 24;

        /// DMPAPER_B_PLUS -> 58
        public const int DMPAPER_B_PLUS = 58;

        /// DMPAPER_B6_JIS_ROTATED -> 89
        public const int DMPAPER_B6_JIS_ROTATED = 89;

        /// DMPAPER_B6_JIS -> 88
        public const int DMPAPER_B6_JIS = 88;

        /// DMPAPER_B5_TRANSVERSE -> 62
        public const int DMPAPER_B5_TRANSVERSE = 62;

        /// DMPAPER_B5_JIS_ROTATED -> 80
        public const int DMPAPER_B5_JIS_ROTATED = 80;

        /// DMPAPER_B5_EXTRA -> 65
        public const int DMPAPER_B5_EXTRA = 65;

        /// DMPAPER_B5 -> 13
        public const int DMPAPER_B5 = 13;

        /// DMPAPER_B4_JIS_ROTATED -> 79
        public const int DMPAPER_B4_JIS_ROTATED = 79;

        /// DMPAPER_B4 -> 12
        public const int DMPAPER_B4 = 12;

        /// DMPAPER_A_PLUS -> 57
        public const int DMPAPER_A_PLUS = 57;

        /// DMPAPER_A6_ROTATED -> 83
        public const int DMPAPER_A6_ROTATED = 83;

        /// DMPAPER_A6 -> 70
        public const int DMPAPER_A6 = 70;

        /// DMPAPER_A5_TRANSVERSE -> 61
        public const int DMPAPER_A5_TRANSVERSE = 61;

        /// DMPAPER_A5_ROTATED -> 78
        public const int DMPAPER_A5_ROTATED = 78;

        /// DMPAPER_A5_EXTRA -> 64
        public const int DMPAPER_A5_EXTRA = 64;

        /// DMPAPER_A5 -> 11
        public const int DMPAPER_A5 = 11;

        /// DMPAPER_A4_TRANSVERSE -> 55
        public const int DMPAPER_A4_TRANSVERSE = 55;

        /// DMPAPER_A4_ROTATED -> 77
        public const int DMPAPER_A4_ROTATED = 77;

        /// DMPAPER_A4_PLUS -> 60
        public const int DMPAPER_A4_PLUS = 60;

        /// DMPAPER_A4_EXTRA -> 53
        public const int DMPAPER_A4_EXTRA = 53;

        /// DMPAPER_A4SMALL -> 10
        public const int DMPAPER_A4SMALL = 10;

        /// DMPAPER_A4 -> 9
        public const int DMPAPER_A4 = 9;

        /// DMPAPER_A3_TRANSVERSE -> 67
        public const int DMPAPER_A3_TRANSVERSE = 67;

        /// DMPAPER_A3_ROTATED -> 76
        public const int DMPAPER_A3_ROTATED = 76;

        /// DMPAPER_A3_EXTRA_TRANSVERSE -> 68
        public const int DMPAPER_A3_EXTRA_TRANSVERSE = 68;

        /// DMPAPER_A3_EXTRA -> 63
        public const int DMPAPER_A3_EXTRA = 63;

        /// DMPAPER_A3 -> 8
        public const int DMPAPER_A3 = 8;

        /// DMPAPER_A2 -> 66
        public const int DMPAPER_A2 = 66;

        /// DMPAPER_9X11 -> 44
        public const int DMPAPER_9X11 = 44;

        /// DMPAPER_15X11 -> 46
        public const int DMPAPER_15X11 = 46;

        /// DMPAPER_12X11 -> 90
        public const int DMPAPER_12X11 = 90;

        /// DMPAPER_11X17 -> 17
        public const int DMPAPER_11X17 = 17;

        /// DMPAPER_10X14 -> 16
        public const int DMPAPER_10X14 = 16;

        /// DMPAPER_10X11 -> 45
        public const int DMPAPER_10X11 = 45;

        /// DMORIENT_PORTRAIT -> 1
        public const int DMORIENT_PORTRAIT = 1;

        /// DMORIENT_LANDSCAPE -> 2
        public const int DMORIENT_LANDSCAPE = 2;

        /// DMNUP_SYSTEM -> 1
        public const int DMNUP_SYSTEM = 1;

        /// DMNUP_ONEUP -> 2
        public const int DMNUP_ONEUP = 2;

        /// DMMEDIA_USER -> 256
        public const int DMMEDIA_USER = 256;

        /// DMMEDIA_TRANSPARENCY -> 2
        public const int DMMEDIA_TRANSPARENCY = 2;

        /// DMMEDIA_STANDARD -> 1
        public const int DMMEDIA_STANDARD = 1;

        /// DMMEDIA_GLOSSY -> 3
        public const int DMMEDIA_GLOSSY = 3;

        /// DMLERR_UNFOUND_QUEUE_ID -> 0x4011
        public const int DMLERR_UNFOUND_QUEUE_ID = 16401;

        /// DMLERR_UNADVACKTIMEOUT -> 0x4010
        public const int DMLERR_UNADVACKTIMEOUT = 16400;

        /// DMLERR_SYS_ERROR -> 0x400f
        public const int DMLERR_SYS_ERROR = 16399;

        /// DMLERR_SERVER_DIED -> 0x400e
        public const int DMLERR_SERVER_DIED = 16398;

        /// DMLERR_REENTRANCY -> 0x400d
        public const int DMLERR_REENTRANCY = 16397;

        /// DMLERR_POSTMSG_FAILED -> 0x400c
        public const int DMLERR_POSTMSG_FAILED = 16396;

        /// DMLERR_POKEACKTIMEOUT -> 0x400b
        public const int DMLERR_POKEACKTIMEOUT = 16395;

        /// DMLERR_NO_ERROR -> 0
        public const int DMLERR_NO_ERROR = 0;

        /// DMLERR_NO_CONV_ESTABLISHED -> 0x400a
        public const int DMLERR_NO_CONV_ESTABLISHED = 16394;

        /// DMLERR_NOTPROCESSED -> 0x4009
        public const int DMLERR_NOTPROCESSED = 16393;

        /// DMLERR_MEMORY_ERROR -> 0x4008
        public const int DMLERR_MEMORY_ERROR = 16392;

        /// DMLERR_LOW_MEMORY -> 0x4007
        public const int DMLERR_LOW_MEMORY = 16391;

        /// DMLERR_LAST -> 0x4011
        public const int DMLERR_LAST = 16401;

        /// DMLERR_INVALIDPARAMETER -> 0x4006
        public const int DMLERR_INVALIDPARAMETER = 16390;

        /// DMLERR_FIRST -> 0x4000
        public const int DMLERR_FIRST = 16384;

        /// DMLERR_EXECACKTIMEOUT -> 0x4005
        public const int DMLERR_EXECACKTIMEOUT = 16389;

        /// DMLERR_DLL_USAGE -> 0x4004
        public const int DMLERR_DLL_USAGE = 16388;

        /// DMLERR_DLL_NOT_INITIALIZED -> 0x4003
        public const int DMLERR_DLL_NOT_INITIALIZED = 16387;

        /// DMLERR_DATAACKTIMEOUT -> 0x4002
        public const int DMLERR_DATAACKTIMEOUT = 16386;

        /// DMLERR_BUSY -> 0x4001
        public const int DMLERR_BUSY = 16385;

        /// DMLERR_ADVACKTIMEOUT -> 0x4000
        public const int DMLERR_ADVACKTIMEOUT = 16384;

        /// DMICM_USER -> 256
        public const int DMICM_USER = 256;

        /// DMICM_SATURATE -> 1
        public const int DMICM_SATURATE = 1;

        /// DMICM_CONTRAST -> 2
        public const int DMICM_CONTRAST = 2;

        /// DMICM_COLORIMETRIC -> 3
        public const int DMICM_COLORIMETRIC = 3;

        /// DMICM_ABS_COLORIMETRIC -> 4
        public const int DMICM_ABS_COLORIMETRIC = 4;

        /// DMICMMETHOD_USER -> 256
        public const int DMICMMETHOD_USER = 256;

        /// DMICMMETHOD_SYSTEM -> 2
        public const int DMICMMETHOD_SYSTEM = 2;

        /// DMICMMETHOD_NONE -> 1
        public const int DMICMMETHOD_NONE = 1;

        /// DMICMMETHOD_DRIVER -> 3
        public const int DMICMMETHOD_DRIVER = 3;

        /// DMICMMETHOD_DEVICE -> 4
        public const int DMICMMETHOD_DEVICE = 4;

        /// DMDUP_VERTICAL -> 2
        public const int DMDUP_VERTICAL = 2;

        /// DMDUP_SIMPLEX -> 1
        public const int DMDUP_SIMPLEX = 1;

        /// DMDUP_HORIZONTAL -> 3
        public const int DMDUP_HORIZONTAL = 3;

        /// DMDO_DEFAULT -> 0
        public const int DMDO_DEFAULT = 0;

        /// DMDO_90 -> 1
        public const int DMDO_90 = 1;

        /// DMDO_270 -> 3
        public const int DMDO_270 = 3;

        /// DMDO_180 -> 2
        public const int DMDO_180 = 2;

        /// DMDITHER_USER -> 256
        public const int DMDITHER_USER = 256;

        /// DMDITHER_RESERVED9 -> 9
        public const int DMDITHER_RESERVED9 = 9;

        /// DMDITHER_RESERVED8 -> 8
        public const int DMDITHER_RESERVED8 = 8;

        /// DMDITHER_RESERVED7 -> 7
        public const int DMDITHER_RESERVED7 = 7;

        /// DMDITHER_RESERVED6 -> 6
        public const int DMDITHER_RESERVED6 = 6;

        /// DMDITHER_NONE -> 1
        public const int DMDITHER_NONE = 1;

        /// DMDITHER_LINEART -> 4
        public const int DMDITHER_LINEART = 4;

        /// DMDITHER_GRAYSCALE -> 10
        public const int DMDITHER_GRAYSCALE = 10;

        /// DMDITHER_FINE -> 3
        public const int DMDITHER_FINE = 3;

        /// DMDITHER_ERRORDIFFUSION -> 5
        public const int DMDITHER_ERRORDIFFUSION = 5;

        /// DMDITHER_COARSE -> 2
        public const int DMDITHER_COARSE = 2;

        /// DMDISPLAYFLAGS_TEXTMODE -> 0x00000004
        public const int DMDISPLAYFLAGS_TEXTMODE = 4;

        /// DMDFO_STRETCH -> 1
        public const int DMDFO_STRETCH = 1;

        /// DMDFO_DEFAULT -> 0
        public const int DMDFO_DEFAULT = 0;

        /// DMDFO_CENTER -> 2
        public const int DMDFO_CENTER = 2;

        /// DMCOLOR_MONOCHROME -> 1
        public const int DMCOLOR_MONOCHROME = 1;

        /// DMCOLOR_COLOR -> 2
        public const int DMCOLOR_COLOR = 2;

        /// DMCOLLATE_TRUE -> 1
        public const int DMCOLLATE_TRUE = 1;

        /// DMCOLLATE_FALSE -> 0
        public const int DMCOLLATE_FALSE = 0;

        /// DMBIN_USER -> 256
        public const int DMBIN_USER = 256;

        /// DMBIN_UPPER -> 1
        public const int DMBIN_UPPER = 1;

        /// DMBIN_TRACTOR -> 8
        public const int DMBIN_TRACTOR = 8;

        /// DMBIN_SMALLFMT -> 9
        public const int DMBIN_SMALLFMT = 9;

        /// DMBIN_ONLYONE -> 1
        public const int DMBIN_ONLYONE = 1;

        /// DMBIN_MIDDLE -> 3
        public const int DMBIN_MIDDLE = 3;

        /// DMBIN_MANUAL -> 4
        public const int DMBIN_MANUAL = 4;

        /// DMBIN_LOWER -> 2
        public const int DMBIN_LOWER = 2;

        /// DMBIN_LAST -> DMBIN_FORMSOURCE
        public const int DMBIN_LAST = NativeConstants.DMBIN_FORMSOURCE;

        /// DMBIN_LARGEFMT -> 10
        public const int DMBIN_LARGEFMT = 10;

        /// DMBIN_LARGECAPACITY -> 11
        public const int DMBIN_LARGECAPACITY = 11;

        /// DMBIN_FORMSOURCE -> 15
        public const int DMBIN_FORMSOURCE = 15;

        /// DMBIN_FIRST -> DMBIN_UPPER
        public const int DMBIN_FIRST = NativeConstants.DMBIN_UPPER;

        /// DMBIN_ENVMANUAL -> 6
        public const int DMBIN_ENVMANUAL = 6;

        /// DMBIN_ENVELOPE -> 5
        public const int DMBIN_ENVELOPE = 5;

        /// DMBIN_CASSETTE -> 14
        public const int DMBIN_CASSETTE = 14;

        /// DMBIN_AUTO -> 7
        public const int DMBIN_AUTO = 7;

        /// DLL_THREAD_DETACH -> 3
        public const int DLL_THREAD_DETACH = 3;

        /// DLL_THREAD_ATTACH -> 2
        public const int DLL_THREAD_ATTACH = 2;

        /// DLL_PROCESS_VERIFIER -> 4
        public const int DLL_PROCESS_VERIFIER = 4;

        /// DLL_PROCESS_DETACH -> 0
        public const int DLL_PROCESS_DETACH = 0;

        /// DLL_PROCESS_ATTACH -> 1
        public const int DLL_PROCESS_ATTACH = 1;

        /// DLGWINDOWEXTRA -> 30
        public const int DLGWINDOWEXTRA = 30;

        /// DlgDirSelectEx -> DlgDirSelectExW
        /// Error generating expression: Value DlgDirSelectExW is not resolved
        public const string DlgDirSelectEx = "DlgDirSelectExW";

        /// DlgDirSelectComboBoxEx -> DlgDirSelectComboBoxExW
        /// Error generating expression: Value DlgDirSelectComboBoxExW is not resolved
        public const string DlgDirSelectComboBoxEx = "DlgDirSelectComboBoxExW";

        /// DlgDirListComboBox -> DlgDirListComboBoxW
        /// Error generating expression: Value DlgDirListComboBoxW is not resolved
        public const string DlgDirListComboBox = "DlgDirListComboBoxW";

        /// DlgDirList -> DlgDirListW
        /// Error generating expression: Value DlgDirListW is not resolved
        public const string DlgDirList = "DlgDirListW";

        /// DLGC_WANTTAB -> 0x0002
        public const int DLGC_WANTTAB = 2;

        /// DLGC_WANTMESSAGE -> 0x0004
        public const int DLGC_WANTMESSAGE = 4;

        /// DLGC_WANTCHARS -> 0x0080
        public const int DLGC_WANTCHARS = 128;

        /// DLGC_WANTARROWS -> 0x0001
        public const int DLGC_WANTARROWS = 1;

        /// DLGC_WANTALLKEYS -> 0x0004
        public const int DLGC_WANTALLKEYS = 4;

        /// DLGC_UNDEFPUSHBUTTON -> 0x0020
        public const int DLGC_UNDEFPUSHBUTTON = 32;

        /// DLGC_STATIC -> 0x0100
        public const int DLGC_STATIC = 256;

        /// DLGC_RADIOBUTTON -> 0x0040
        public const int DLGC_RADIOBUTTON = 64;

        /// DLGC_HASSETSEL -> 0x0008
        public const int DLGC_HASSETSEL = 8;

        /// DLGC_DEFPUSHBUTTON -> 0x0010
        public const int DLGC_DEFPUSHBUTTON = 16;

        /// DLGC_BUTTON -> 0x2000
        public const int DLGC_BUTTON = 8192;

        /// DKGRAY_BRUSH -> 3
        public const int DKGRAY_BRUSH = 3;

        /// DI_ROPS_READ_DESTINATION -> 0x00000002
        public const int DI_ROPS_READ_DESTINATION = 2;

        /// DI_READ_SPOOL_JOB -> 3
        public const int DI_READ_SPOOL_JOB = 3;

        /// DI_NORMAL -> 0x0003
        public const int DI_NORMAL = 3;

        /// DI_NOMIRROR -> 0x0010
        public const int DI_NOMIRROR = 16;

        /// DI_MEMORYMAP_WRITE -> 0x00000001
        public const int DI_MEMORYMAP_WRITE = 1;

        /// DI_MASK -> 0x0001
        public const int DI_MASK = 1;

        /// DI_IMAGE -> 0x0002
        public const int DI_IMAGE = 2;

        /// DI_DEFAULTSIZE -> 0x0008
        public const int DI_DEFAULTSIZE = 8;

        /// DI_COMPAT -> 0x0004
        public const int DI_COMPAT = 4;

        /// DI_CHANNEL -> 1
        public const int DI_CHANNEL = 1;

        /// DI_APPBANDING -> 0x00000001
        public const int DI_APPBANDING = 1;

        /// DISP_CHANGE_SUCCESSFUL -> 0
        public const int DISP_CHANGE_SUCCESSFUL = 0;

        /// DISP_CHANGE_RESTART -> 1
        public const int DISP_CHANGE_RESTART = 1;

        /// DISP_CHANGE_NOTUPDATED -> -3
        public const int DISP_CHANGE_NOTUPDATED = -3;

        /// DISP_CHANGE_FAILED -> -1
        public const int DISP_CHANGE_FAILED = -1;

        /// DISP_CHANGE_BADPARAM -> -5
        public const int DISP_CHANGE_BADPARAM = -5;

        /// DISP_CHANGE_BADMODE -> -2
        public const int DISP_CHANGE_BADMODE = -2;

        /// DISP_CHANGE_BADFLAGS -> -4
        public const int DISP_CHANGE_BADFLAGS = -4;

        /// DISP_CHANGE_BADDUALVIEW -> -6
        public const int DISP_CHANGE_BADDUALVIEW = -6;

        /// DISPLAY_DEVICE_VGA_COMPATIBLE -> 0x00000010
        public const int DISPLAY_DEVICE_VGA_COMPATIBLE = 16;

        /// DISPLAY_DEVICE_REMOVABLE -> 0x00000020
        public const int DISPLAY_DEVICE_REMOVABLE = 32;

        /// DISPLAY_DEVICE_REMOTE -> 0x04000000
        public const int DISPLAY_DEVICE_REMOTE = 67108864;

        /// DISPLAY_DEVICE_PRIMARY_DEVICE -> 0x00000004
        public const int DISPLAY_DEVICE_PRIMARY_DEVICE = 4;

        /// DISPLAY_DEVICE_MULTI_DRIVER -> 0x00000002
        public const int DISPLAY_DEVICE_MULTI_DRIVER = 2;

        /// DISPLAY_DEVICE_MODESPRUNED -> 0x08000000
        public const int DISPLAY_DEVICE_MODESPRUNED = 134217728;

        /// DISPLAY_DEVICE_MIRRORING_DRIVER -> 0x00000008
        public const int DISPLAY_DEVICE_MIRRORING_DRIVER = 8;

        /// DISPLAY_DEVICE_DISCONNECT -> 0x02000000
        public const int DISPLAY_DEVICE_DISCONNECT = 33554432;

        /// DISPLAY_DEVICE_ATTACHED_TO_DESKTOP -> 0x00000001
        public const int DISPLAY_DEVICE_ATTACHED_TO_DESKTOP = 1;

        /// DISPLAY_DEVICE_ATTACHED -> 0x00000002
        public const int DISPLAY_DEVICE_ATTACHED = 2;

        /// DISPLAY_DEVICE_ACTIVE -> 0x00000001
        public const int DISPLAY_DEVICE_ACTIVE = 1;

        /// DISPID_VALUE -> ( 0 )
        public const int DISPID_VALUE = 0;

        /// DISPID_UNKNOWN -> ( -1 )
        public const int DISPID_UNKNOWN = -1;

        /// DISPID_PROPERTYPUT -> ( -3 )
        public const int DISPID_PROPERTYPUT = -3;

        /// DISPID_NEWENUM -> ( -4 )
        public const int DISPID_NEWENUM = -4;

        /// DISPID_EVALUATE -> ( -5 )
        public const int DISPID_EVALUATE = -5;

        /// DISPID_DESTRUCTOR -> ( -7 )
        public const int DISPID_DESTRUCTOR = -7;

        /// DISPID_CONSTRUCTOR -> ( -6 )
        public const int DISPID_CONSTRUCTOR = -6;

        /// DISPID_COLLECT -> ( -8 )
        public const int DISPID_COLLECT = -8;

        /// DISPATCH_PROPERTYPUTREF -> 0x8
        public const int DISPATCH_PROPERTYPUTREF = 8;

        /// DISPATCH_PROPERTYPUT -> 0x4
        public const int DISPATCH_PROPERTYPUT = 4;

        /// DISPATCH_PROPERTYGET -> 0x2
        public const int DISPATCH_PROPERTYGET = 2;

        /// DISPATCH_METHOD -> 0x1
        public const int DISPATCH_METHOD = 1;

        /// DispatchMessage -> DispatchMessageW
        /// Error generating expression: Value DispatchMessageW is not resolved
        public const string DispatchMessage = "DispatchMessageW";

        /// DISK_LOGGING_STOP -> 1
        public const int DISK_LOGGING_STOP = 1;

        /// DISK_LOGGING_START -> 0
        public const int DISK_LOGGING_START = 0;

        /// DISK_LOGGING_DUMP -> 2
        public const int DISK_LOGGING_DUMP = 2;

        /// DISK_BINNING -> 3
        public const int DISK_BINNING = 3;

        /// DiskClassGuid -> GUID_DEVINTERFACE_DISK
        /// Error generating expression: Value GUID_DEVINTERFACE_DISK is not resolved
        public const string DiskClassGuid = "GUID_DEVINTERFACE_DISK";

        /// DISC_UPDATE_PROFILE -> 0x00000001
        public const int DISC_UPDATE_PROFILE = 1;

        /// DISC_NO_FORCE -> 0x00000040
        public const int DISC_NO_FORCE = 64;

        /// DISCHARGE_POLICY_LOW -> 1
        public const int DISCHARGE_POLICY_LOW = 1;

        /// DISCHARGE_POLICY_CRITICAL -> 0
        public const int DISCHARGE_POLICY_CRITICAL = 0;

        /// DISABLE_SMART -> 0xD9
        public const int DISABLE_SMART = 217;

        /// DISABLE_MAX_PRIVILEGE -> 0x1
        public const int DISABLE_MAX_PRIVILEGE = 1;

        /// DIFFERENCE -> 11
        public const int DIFFERENCE = 11;

        /// DIB_RGB_COLORS -> 0
        public const int DIB_RGB_COLORS = 0;

        /// DIB_PAL_COLORS -> 1
        public const int DIB_PAL_COLORS = 1;

        /// DIALOPTION_QUIET -> 0x00000080
        public const int DIALOPTION_QUIET = 128;

        /// DIALOPTION_DIALTONE -> 0x00000100
        public const int DIALOPTION_DIALTONE = 256;

        /// DIALOPTION_BILLING -> 0x00000040
        public const int DIALOPTION_BILLING = 64;

        /// DialogBoxParam -> DialogBoxParamW
        /// Error generating expression: Value DialogBoxParamW is not resolved
        public const string DialogBoxParam = "DialogBoxParamW";

        /// DialogBoxIndirectParam -> DialogBoxIndirectParamW
        /// Error generating expression: Value DialogBoxIndirectParamW is not resolved
        public const string DialogBoxIndirectParam = "DialogBoxIndirectParamW";

        /// DialogBoxIndirect -> DialogBoxIndirectW
        public const string DialogBoxIndirect = NativeConstants.DialogBoxIndirectW;

        /// DialogBox -> DialogBoxW
        public const string DialogBox = NativeConstants.DialogBoxW;

        /// DF_ALLOWOTHERACCOUNTHOOK -> 0x0001L
        public const int DF_ALLOWOTHERACCOUNTHOOK = 1;

        /// DFC_SCROLL -> 3
        public const int DFC_SCROLL = 3;

        /// DFC_POPUPMENU -> 5
        public const int DFC_POPUPMENU = 5;

        /// DFC_MENU -> 2
        public const int DFC_MENU = 2;

        /// DFC_CAPTION -> 1
        public const int DFC_CAPTION = 1;

        /// DFC_BUTTON -> 4
        public const int DFC_BUTTON = 4;

        /// DFCS_TRANSPARENT -> 0x0800
        public const int DFCS_TRANSPARENT = 2048;

        /// DFCS_SCROLLUP -> 0x0000
        public const int DFCS_SCROLLUP = 0;

        /// DFCS_SCROLLSIZEGRIPRIGHT -> 0x0010
        public const int DFCS_SCROLLSIZEGRIPRIGHT = 16;

        /// DFCS_SCROLLSIZEGRIP -> 0x0008
        public const int DFCS_SCROLLSIZEGRIP = 8;

        /// DFCS_SCROLLRIGHT -> 0x0003
        public const int DFCS_SCROLLRIGHT = 3;

        /// DFCS_SCROLLLEFT -> 0x0002
        public const int DFCS_SCROLLLEFT = 2;

        /// DFCS_SCROLLDOWN -> 0x0001
        public const int DFCS_SCROLLDOWN = 1;

        /// DFCS_SCROLLCOMBOBOX -> 0x0005
        public const int DFCS_SCROLLCOMBOBOX = 5;

        /// DFCS_PUSHED -> 0x0200
        public const int DFCS_PUSHED = 512;

        /// DFCS_MONO -> 0x8000
        public const int DFCS_MONO = 32768;

        /// DFCS_MENUCHECK -> 0x0001
        public const int DFCS_MENUCHECK = 1;

        /// DFCS_MENUBULLET -> 0x0002
        public const int DFCS_MENUBULLET = 2;

        /// DFCS_MENUARROWRIGHT -> 0x0004
        public const int DFCS_MENUARROWRIGHT = 4;

        /// DFCS_MENUARROW -> 0x0000
        public const int DFCS_MENUARROW = 0;

        /// DFCS_INACTIVE -> 0x0100
        public const int DFCS_INACTIVE = 256;

        /// DFCS_HOT -> 0x1000
        public const int DFCS_HOT = 4096;

        /// DFCS_FLAT -> 0x4000
        public const int DFCS_FLAT = 16384;

        /// DFCS_CHECKED -> 0x0400
        public const int DFCS_CHECKED = 1024;

        /// DFCS_CAPTIONRESTORE -> 0x0003
        public const int DFCS_CAPTIONRESTORE = 3;

        /// DFCS_CAPTIONMIN -> 0x0001
        public const int DFCS_CAPTIONMIN = 1;

        /// DFCS_CAPTIONMAX -> 0x0002
        public const int DFCS_CAPTIONMAX = 2;

        /// DFCS_CAPTIONHELP -> 0x0004
        public const int DFCS_CAPTIONHELP = 4;

        /// DFCS_CAPTIONCLOSE -> 0x0000
        public const int DFCS_CAPTIONCLOSE = 0;

        /// DFCS_BUTTONRADIOMASK -> 0x0002
        public const int DFCS_BUTTONRADIOMASK = 2;

        /// DFCS_BUTTONRADIOIMAGE -> 0x0001
        public const int DFCS_BUTTONRADIOIMAGE = 1;

        /// DFCS_BUTTONRADIO -> 0x0004
        public const int DFCS_BUTTONRADIO = 4;

        /// DFCS_BUTTONPUSH -> 0x0010
        public const int DFCS_BUTTONPUSH = 16;

        /// DFCS_BUTTONCHECK -> 0x0000
        public const int DFCS_BUTTONCHECK = 0;

        /// DFCS_BUTTON3STATE -> 0x0008
        public const int DFCS_BUTTON3STATE = 8;

        /// DFCS_ADJUSTRECT -> 0x2000
        public const int DFCS_ADJUSTRECT = 8192;

        /// DEVICE_TYPE -> DWORD
        /// Error generating expression: Value DWORD is not resolved
        public const string DEVICE_TYPE = "DWORD";

        /// DEVICE_NOTIFY_WINDOW_HANDLE -> 0x00000000
        public const int DEVICE_NOTIFY_WINDOW_HANDLE = 0;

        /// DEVICE_NOTIFY_SERVICE_HANDLE -> 0x00000001
        public const int DEVICE_NOTIFY_SERVICE_HANDLE = 1;

        /// DEVICE_NOTIFY_ALL_INTERFACE_CLASSES -> 0x00000004
        public const int DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 4;

        /// DEVICE_FONTTYPE -> 0x002
        public const int DEVICE_FONTTYPE = 2;

        /// DEVICE_DEFAULT_FONT -> 14
        public const int DEVICE_DEFAULT_FONT = 14;

        /// DEVICEDATA -> 19
        public const int DEVICEDATA = 19;

        /// DeviceCapabilities -> DeviceCapabilitiesW
        /// Error generating expression: Value DeviceCapabilitiesW is not resolved
        public const string DeviceCapabilities = "DeviceCapabilitiesW";

        /// DETACHED_PROCESS -> 0x00000008
        public const int DETACHED_PROCESS = 8;

        /// DESKTOP_WRITEOBJECTS -> 0x0080L
        public const int DESKTOP_WRITEOBJECTS = 128;

        /// DESKTOP_SWITCHDESKTOP -> 0x0100L
        public const int DESKTOP_SWITCHDESKTOP = 256;

        /// DESKTOP_READOBJECTS -> 0x0001L
        public const int DESKTOP_READOBJECTS = 1;

        /// DESKTOP_JOURNALRECORD -> 0x0010L
        public const int DESKTOP_JOURNALRECORD = 16;

        /// DESKTOP_JOURNALPLAYBACK -> 0x0020L
        public const int DESKTOP_JOURNALPLAYBACK = 32;

        /// DESKTOP_HOOKCONTROL -> 0x0008L
        public const int DESKTOP_HOOKCONTROL = 8;

        /// DESKTOP_ENUMERATE -> 0x0040L
        public const int DESKTOP_ENUMERATE = 64;

        /// DESKTOP_CREATEWINDOW -> 0x0002L
        public const int DESKTOP_CREATEWINDOW = 2;

        /// DESKTOP_CREATEMENU -> 0x0004L
        public const int DESKTOP_CREATEMENU = 4;

        /// DESKTOPVERTRES -> 117
        public const int DESKTOPVERTRES = 117;

        /// DESKTOPHORZRES -> 118
        public const int DESKTOPHORZRES = 118;

        /// DEREGISTERED -> 0x05
        public const int DEREGISTERED = 5;

        /// DeleteVolumeMountPoint -> DeleteVolumeMountPointW
        /// Error generating expression: Value DeleteVolumeMountPointW is not resolved
        public const string DeleteVolumeMountPoint = "DeleteVolumeMountPointW";

        /// DeletePrintProvidor -> DeletePrintProvidorW
        /// Error generating expression: Value DeletePrintProvidorW is not resolved
        public const string DeletePrintProvidor = "DeletePrintProvidorW";

        /// DeletePrintProcessor -> DeletePrintProcessorW
        /// Error generating expression: Value DeletePrintProcessorW is not resolved
        public const string DeletePrintProcessor = "DeletePrintProcessorW";

        /// DeletePrinterKey -> DeletePrinterKeyW
        /// Error generating expression: Value DeletePrinterKeyW is not resolved
        public const string DeletePrinterKey = "DeletePrinterKeyW";

        /// DeletePrinterDriverEx -> DeletePrinterDriverExW
        /// Error generating expression: Value DeletePrinterDriverExW is not resolved
        public const string DeletePrinterDriverEx = "DeletePrinterDriverExW";

        /// DeletePrinterDriver -> DeletePrinterDriverW
        /// Error generating expression: Value DeletePrinterDriverW is not resolved
        public const string DeletePrinterDriver = "DeletePrinterDriverW";

        /// DeletePrinterDataEx -> DeletePrinterDataExW
        /// Error generating expression: Value DeletePrinterDataExW is not resolved
        public const string DeletePrinterDataEx = "DeletePrinterDataExW";

        /// DeletePrinterData -> DeletePrinterDataW
        /// Error generating expression: Value DeletePrinterDataW is not resolved
        public const string DeletePrinterData = "DeletePrinterDataW";

        /// DeletePrinterConnection -> DeletePrinterConnectionW
        /// Error generating expression: Value DeletePrinterConnectionW is not resolved
        public const string DeletePrinterConnection = "DeletePrinterConnectionW";

        /// DeletePort -> DeletePortW
        /// Error generating expression: Value DeletePortW is not resolved
        public const string DeletePort = "DeletePortW";

        /// DeleteMonitor -> DeleteMonitorW
        /// Error generating expression: Value DeleteMonitorW is not resolved
        public const string DeleteMonitor = "DeleteMonitorW";

        /// DeleteForm -> DeleteFormW
        /// Error generating expression: Value DeleteFormW is not resolved
        public const string DeleteForm = "DeleteFormW";

        /// DeleteFile -> DeleteFileW
        /// Error generating expression: Value DeleteFileW is not resolved
        public const string DeleteFile = "DeleteFileW";

        /// DELETE -> (0x00010000L)
        public const int DELETE = 65536;

        /// DEF_PRIORITY -> 1
        public const int DEF_PRIORITY = 1;

        /// DefWindowProc -> DefWindowProcW
        /// Error generating expression: Value DefWindowProcW is not resolved
        public const string DefWindowProc = "DefWindowProcW";

        /// DefMDIChildProc -> DefMDIChildProcW
        /// Error generating expression: Value DefMDIChildProcW is not resolved
        public const string DefMDIChildProc = "DefMDIChildProcW";

        /// DefineDosDevice -> DefineDosDeviceW
        /// Error generating expression: Value DefineDosDeviceW is not resolved
        public const string DefineDosDevice = "DefineDosDeviceW";

        /// DefFrameProc -> DefFrameProcW
        /// Error generating expression: Value DefFrameProcW is not resolved
        public const string DefFrameProc = "DefFrameProcW";

        /// DefDlgProc -> DefDlgProcW
        /// Error generating expression: Value DefDlgProcW is not resolved
        public const string DefDlgProc = "DefDlgProcW";

        /// DEFAULT_QUALITY -> 0
        public const int DEFAULT_QUALITY = 0;

        /// DEFAULT_PITCH -> 0
        public const int DEFAULT_PITCH = 0;

        /// DEFAULT_PALETTE -> 15
        public const int DEFAULT_PALETTE = 15;

        /// DEFAULT_IMPERSONATION_LEVEL -> SecurityImpersonation
        public const SECURITY_IMPERSONATION_LEVEL DEFAULT_IMPERSONATION_LEVEL = SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation;

        /// DEFAULT_GUI_FONT -> 17
        public const int DEFAULT_GUI_FONT = 17;

        /// DEFAULT_CHARSET -> 1
        public const int DEFAULT_CHARSET = 1;

        /// DecryptFile -> DecryptFileW
        /// Error generating expression: Value DecryptFileW is not resolved
        public const string DecryptFile = "DecryptFileW";

        /// DECLSPEC_UUID -> (x)
        /// Error generating expression: Value x is not resolved
        public const string DECLSPEC_UUID = "(x)";

        /// DEBUG_PROCESS -> 0x00000001
        public const int DEBUG_PROCESS = 1;

        /// DEBUG_ONLY_THIS_PROCESS -> 0x00000002
        public const int DEBUG_ONLY_THIS_PROCESS = 2;

        /// DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION -> (0x00000001)
        public const int DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION = 1;

        /// DD_DEFSCROLLINTERVAL -> ( 50 )
        public const int DD_DEFSCROLLINTERVAL = 50;

        /// DD_DEFSCROLLINSET -> ( 11 )
        public const int DD_DEFSCROLLINSET = 11;

        /// DD_DEFSCROLLDELAY -> ( 50 )
        public const int DD_DEFSCROLLDELAY = 50;

        /// DD_DEFDRAGMINDIST -> ( 2 )
        public const int DD_DEFDRAGMINDIST = 2;

        /// DD_DEFDRAGDELAY -> ( 200 )
        public const int DD_DEFDRAGDELAY = 200;

        /// DDL_SYSTEM -> 0x0004
        public const int DDL_SYSTEM = 4;

        /// DDL_READWRITE -> 0x0000
        public const int DDL_READWRITE = 0;

        /// DDL_READONLY -> 0x0001
        public const int DDL_READONLY = 1;

        /// DDL_POSTMSGS -> 0x2000
        public const int DDL_POSTMSGS = 8192;

        /// DDL_HIDDEN -> 0x0002
        public const int DDL_HIDDEN = 2;

        /// DDL_EXCLUSIVE -> 0x8000
        public const int DDL_EXCLUSIVE = 32768;

        /// DDL_DRIVES -> 0x4000
        public const int DDL_DRIVES = 16384;

        /// DDL_DIRECTORY -> 0x0010
        public const int DDL_DIRECTORY = 16;

        /// DDL_ARCHIVE -> 0x0020
        public const int DDL_ARCHIVE = 32;

        /// DDE_FREQUESTED -> 0x1000
        public const int DDE_FREQUESTED = 4096;

        /// DDE_FRELEASE -> 0x2000
        public const int DDE_FRELEASE = 8192;

        /// DDE_FNOTPROCESSED -> 0x0000
        public const int DDE_FNOTPROCESSED = 0;

        /// DDE_FDEFERUPD -> 0x4000
        public const int DDE_FDEFERUPD = 16384;

        /// DDE_FBUSY -> 0x4000
        public const int DDE_FBUSY = 16384;

        /// DDE_FAPPSTATUS -> 0x00ff
        public const int DDE_FAPPSTATUS = 255;

        /// DDE_FACKREQ -> 0x8000
        public const int DDE_FACKREQ = 32768;

        /// DDE_FACK -> 0x8000
        public const int DDE_FACK = 32768;

        /// DdeQueryString -> DdeQueryStringW
        /// Error generating expression: Value DdeQueryStringW is not resolved
        public const string DdeQueryString = "DdeQueryStringW";

        /// DdeInitialize -> DdeInitializeW
        /// Error generating expression: Value DdeInitializeW is not resolved
        public const string DdeInitialize = "DdeInitializeW";

        /// DdeCreateStringHandle -> DdeCreateStringHandleW
        /// Error generating expression: Value DdeCreateStringHandleW is not resolved
        public const string DdeCreateStringHandle = "DdeCreateStringHandleW";

        /// DDD_REMOVE_DEFINITION -> 0x00000002
        public const int DDD_REMOVE_DEFINITION = 2;

        /// DDD_RAW_TARGET_PATH -> 0x00000001
        public const int DDD_RAW_TARGET_PATH = 1;

        /// DDD_NO_BROADCAST_SYSTEM -> 0x00000008
        public const int DDD_NO_BROADCAST_SYSTEM = 8;

        /// DDD_LUID_BROADCAST_DRIVE -> 0x00000010
        public const int DDD_LUID_BROADCAST_DRIVE = 16;

        /// DDD_EXACT_MATCH_ON_REMOVE -> 0x00000004
        public const int DDD_EXACT_MATCH_ON_REMOVE = 4;

        /// DC_VERSION -> 10
        public const int DC_VERSION = 10;

        /// DC_TRUETYPE -> 15
        public const int DC_TRUETYPE = 15;

        /// DC_TEXT -> 0x0008
        public const int DC_TEXT = 8;

        /// DC_STAPLE -> 30
        public const int DC_STAPLE = 30;

        /// DC_SMALLCAP -> 0x0002
        public const int DC_SMALLCAP = 2;

        /// DC_SIZE -> 8
        public const int DC_SIZE = 8;

        /// DC_PRINTRATEUNIT -> 27
        public const int DC_PRINTRATEUNIT = 27;

        /// DC_PRINTRATEPPM -> 31
        public const int DC_PRINTRATEPPM = 31;

        /// DC_PRINTRATE -> 26
        public const int DC_PRINTRATE = 26;

        /// DC_PRINTERMEM -> 28
        public const int DC_PRINTERMEM = 28;

        /// DC_PERSONALITY -> 25
        public const int DC_PERSONALITY = 25;

        /// DC_PEN -> 19
        public const int DC_PEN = 19;

        /// DC_PAPERSIZE -> 3
        public const int DC_PAPERSIZE = 3;

        /// DC_PAPERS -> 2
        public const int DC_PAPERS = 2;

        /// DC_PAPERNAMES -> 16
        public const int DC_PAPERNAMES = 16;

        /// DC_ORIENTATION -> 17
        public const int DC_ORIENTATION = 17;

        /// DC_NUP -> 33
        public const int DC_NUP = 33;

        /// DC_MODEL -> 24
        public const int DC_MODEL = 24;

        /// DC_MINEXTENT -> 4
        public const int DC_MINEXTENT = 4;

        /// DC_MEDIATYPES -> 35
        public const int DC_MEDIATYPES = 35;

        /// DC_MEDIATYPENAMES -> 34
        public const int DC_MEDIATYPENAMES = 34;

        /// DC_MEDIAREADY -> 29
        public const int DC_MEDIAREADY = 29;

        /// DC_MAXEXTENT -> 5
        public const int DC_MAXEXTENT = 5;

        /// DC_MANUFACTURER -> 23
        public const int DC_MANUFACTURER = 23;

        /// DC_INBUTTON -> 0x0010
        public const int DC_INBUTTON = 16;

        /// DC_ICON -> 0x0004
        public const int DC_ICON = 4;

        /// DC_HASDEFID -> 0x534B
        public const int DC_HASDEFID = 21323;

        /// DC_GRADIENT -> 0x0020
        public const int DC_GRADIENT = 32;

        /// DC_FILEDEPENDENCIES -> 14
        public const int DC_FILEDEPENDENCIES = 14;

        /// DC_FIELDS -> 1
        public const int DC_FIELDS = 1;

        /// DC_EXTRA -> 9
        public const int DC_EXTRA = 9;

        /// DC_ENUMRESOLUTIONS -> 13
        public const int DC_ENUMRESOLUTIONS = 13;

        /// DC_EMF_COMPLIANT -> 20
        public const int DC_EMF_COMPLIANT = 20;

        /// DC_DUPLEX -> 7
        public const int DC_DUPLEX = 7;

        /// DC_DRIVER -> 11
        public const int DC_DRIVER = 11;

        /// DC_DATATYPE_PRODUCED -> 21
        public const int DC_DATATYPE_PRODUCED = 21;

        /// DC_COPIES -> 18
        public const int DC_COPIES = 18;

        /// DC_COLORDEVICE -> 32
        public const int DC_COLORDEVICE = 32;

        /// DC_COLLATE -> 22
        public const int DC_COLLATE = 22;

        /// DC_BUTTONS -> 0x1000
        public const int DC_BUTTONS = 4096;

        /// DC_BRUSH -> 18
        public const int DC_BRUSH = 18;

        /// DC_BINS -> 6
        public const int DC_BINS = 6;

        /// DC_BINNAMES -> 12
        public const int DC_BINNAMES = 12;

        /// DC_BINADJUST -> 19
        public const int DC_BINADJUST = 19;

        /// DC_ACTIVE -> 0x0001
        public const int DC_ACTIVE = 1;

        /// DCX_WINDOW -> 0x00000001L
        public const int DCX_WINDOW = 1;

        /// DCX_VALIDATE -> 0x00200000L
        public const int DCX_VALIDATE = 2097152;

        /// DCX_PARENTCLIP -> 0x00000020L
        public const int DCX_PARENTCLIP = 32;

        /// DCX_NORESETATTRS -> 0x00000004L
        public const int DCX_NORESETATTRS = 4;

        /// DCX_LOCKWINDOWUPDATE -> 0x00000400L
        public const int DCX_LOCKWINDOWUPDATE = 1024;

        /// DCX_INTERSECTUPDATE -> 0x00000200L
        public const int DCX_INTERSECTUPDATE = 512;

        /// DCX_INTERSECTRGN -> 0x00000080L
        public const int DCX_INTERSECTRGN = 128;

        /// DCX_EXCLUDEUPDATE -> 0x00000100L
        public const int DCX_EXCLUDEUPDATE = 256;

        /// DCX_EXCLUDERGN -> 0x00000040L
        public const int DCX_EXCLUDERGN = 64;

        /// DCX_CLIPSIBLINGS -> 0x00000010L
        public const int DCX_CLIPSIBLINGS = 16;

        /// DCX_CLIPCHILDREN -> 0x00000008L
        public const int DCX_CLIPCHILDREN = 8;

        /// DCX_CACHE -> 0x00000002L
        public const int DCX_CACHE = 2;

        /// DCTT_SUBDEV -> 0x0000004L
        public const int DCTT_SUBDEV = 4;

        /// DCTT_DOWNLOAD_OUTLINE -> 0x0000008L
        public const int DCTT_DOWNLOAD_OUTLINE = 8;

        /// DCTT_DOWNLOAD -> 0x0000002L
        public const int DCTT_DOWNLOAD = 2;

        /// DCTT_BITMAP -> 0x0000001L
        public const int DCTT_BITMAP = 1;

        /// DCE_C_ERROR_STRING_LEN -> 256
        public const int DCE_C_ERROR_STRING_LEN = 256;

        /// DceErrorInqText -> DceErrorInqTextW
        /// Error generating expression: Value DceErrorInqTextW is not resolved
        public const string DceErrorInqText = "DceErrorInqTextW";

        /// DCB_SET -> (DCB_RESET | DCB_ACCUMULATE)
        public const int DCB_SET = (NativeConstants.DCB_RESET | NativeConstants.DCB_ACCUMULATE);

        /// DCB_RESET -> 0x0001
        public const int DCB_RESET = 1;

        /// DCB_ENABLE -> 0x0004
        public const int DCB_ENABLE = 4;

        /// DCB_DISABLE -> 0x0008
        public const int DCB_DISABLE = 8;

        /// DCB_DIRTY -> DCB_ACCUMULATE
        public const int DCB_DIRTY = NativeConstants.DCB_ACCUMULATE;

        /// DCB_ACCUMULATE -> 0x0002
        public const int DCB_ACCUMULATE = 2;

        /// DCBA_FACEUPRIGHT -> 0x0003
        public const int DCBA_FACEUPRIGHT = 3;

        /// DCBA_FACEUPNONE -> 0x0000
        public const int DCBA_FACEUPNONE = 0;

        /// DCBA_FACEUPLEFT -> 0x0002
        public const int DCBA_FACEUPLEFT = 2;

        /// DCBA_FACEUPCENTER -> 0x0001
        public const int DCBA_FACEUPCENTER = 1;

        /// DCBA_FACEDOWNRIGHT -> 0x0103
        public const int DCBA_FACEDOWNRIGHT = 259;

        /// DCBA_FACEDOWNNONE -> 0x0100
        public const int DCBA_FACEDOWNNONE = 256;

        /// DCBA_FACEDOWNLEFT -> 0x0102
        public const int DCBA_FACEDOWNLEFT = 258;

        /// DCBA_FACEDOWNCENTER -> 0x0101
        public const int DCBA_FACEDOWNCENTER = 257;

        /// DATE_YEARMONTH -> 0x00000008
        public const int DATE_YEARMONTH = 8;

        /// DATE_USE_ALT_CALENDAR -> 0x00000004
        public const int DATE_USE_ALT_CALENDAR = 4;

        /// DATE_SHORTDATE -> 0x00000001
        public const int DATE_SHORTDATE = 1;

        /// DATE_RTLREADING -> 0x00000020
        public const int DATE_RTLREADING = 32;

        /// DATE_LTRREADING -> 0x00000010
        public const int DATE_LTRREADING = 16;

        /// DATE_LONGDATE -> 0x00000002
        public const int DATE_LONGDATE = 2;

        /// DATEFMT_ENUMPROCEX -> DATEFMT_ENUMPROCEXW
        /// Error generating expression: Value DATEFMT_ENUMPROCEXW is not resolved
        public const string DATEFMT_ENUMPROCEX = "DATEFMT_ENUMPROCEXW";

        /// DATEFMT_ENUMPROC -> DATEFMT_ENUMPROCW
        /// Error generating expression: Value DATEFMT_ENUMPROCW is not resolved
        public const string DATEFMT_ENUMPROC = "DATEFMT_ENUMPROCW";

        /// DATA_S_LAST -> 0x0004013FL
        public const int DATA_S_LAST = 262463;

        /// DATA_S_FIRST -> 0x00040130L
        public const int DATA_S_FIRST = 262448;

        /// DATA_E_LAST -> 0x8004013FL
        public const int DATA_E_LAST = -2147221185;

        /// DATA_E_FORMATETC -> DV_E_FORMATETC
        public const string DATA_E_FORMATETC = NativeConstants.DV_E_FORMATETC;

        /// DATA_E_FIRST -> 0x80040130L
        public const int DATA_E_FIRST = -2147221200;

        /// DACL_SECURITY_INFORMATION -> (0x00000004L)
        public const int DACL_SECURITY_INFORMATION = 4;

        /// Warning: Generation of Method Macros is not supported at this time
        /// DialogBoxIndirectW -> "(hInstance,lpTemplate,hWndParent,lpDialogFunc) DialogBoxIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)"
        public const string DialogBoxIndirectW = "(hInstance,lpTemplate,hWndParent,lpDialogFunc) DialogBoxIndirectParamW(hInstance," +
            " lpTemplate, hWndParent, lpDialogFunc, 0L)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// DialogBoxW -> "(hInstance,lpTemplate,hWndParent,lpDialogFunc) DialogBoxParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, 0L)"
        public const string DialogBoxW = "(hInstance,lpTemplate,hWndParent,lpDialogFunc) DialogBoxParamW(hInstance, lpTempl" +
            "ate, hWndParent, lpDialogFunc, 0L)";

        /// DV_E_FORMATETC -> _HRESULT_TYPEDEF_(0x80040064L)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string DV_E_FORMATETC = "_HRESULT_TYPEDEF_(0x80040064L)";
    }

}
