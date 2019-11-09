using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// uuid_vector_t -> UUID_VECTOR
        /// Error generating expression: Value UUID_VECTOR is not resolved
        public const string uuid_vector_t = "UUID_VECTOR";

        /// uuid_t -> UUID
        /// Error generating expression: Value UUID is not resolved
        public const string uuid_t = "UUID";

        /// UuidToString -> UuidToStringW
        /// Error generating expression: Value UuidToStringW is not resolved
        public const string UuidToString = "UuidToStringW";

        /// UuidFromString -> UuidFromStringW
        /// Error generating expression: Value UuidFromStringW is not resolved
        public const string UuidFromString = "UuidFromStringW";

        /// USN_SOURCE_REPLICATION_MANAGEMENT -> (0x00000004)
        public const int USN_SOURCE_REPLICATION_MANAGEMENT = 4;

        /// USN_SOURCE_DATA_MANAGEMENT -> (0x00000001)
        public const int USN_SOURCE_DATA_MANAGEMENT = 1;

        /// USN_SOURCE_AUXILIARY_DATA -> (0x00000002)
        public const int USN_SOURCE_AUXILIARY_DATA = 2;

        /// USN_REASON_STREAM_CHANGE -> (0x00200000)
        public const int USN_REASON_STREAM_CHANGE = 2097152;

        /// USN_REASON_SECURITY_CHANGE -> (0x00000800)
        public const int USN_REASON_SECURITY_CHANGE = 2048;

        /// USN_REASON_REPARSE_POINT_CHANGE -> (0x00100000)
        public const int USN_REASON_REPARSE_POINT_CHANGE = 1048576;

        /// USN_REASON_RENAME_OLD_NAME -> (0x00001000)
        public const int USN_REASON_RENAME_OLD_NAME = 4096;

        /// USN_REASON_RENAME_NEW_NAME -> (0x00002000)
        public const int USN_REASON_RENAME_NEW_NAME = 8192;

        /// USN_REASON_OBJECT_ID_CHANGE -> (0x00080000)
        public const int USN_REASON_OBJECT_ID_CHANGE = 524288;

        /// USN_REASON_NAMED_DATA_TRUNCATION -> (0x00000040)
        public const int USN_REASON_NAMED_DATA_TRUNCATION = 64;

        /// USN_REASON_NAMED_DATA_OVERWRITE -> (0x00000010)
        public const int USN_REASON_NAMED_DATA_OVERWRITE = 16;

        /// USN_REASON_NAMED_DATA_EXTEND -> (0x00000020)
        public const int USN_REASON_NAMED_DATA_EXTEND = 32;

        /// USN_REASON_INDEXABLE_CHANGE -> (0x00004000)
        public const int USN_REASON_INDEXABLE_CHANGE = 16384;

        /// USN_REASON_HARD_LINK_CHANGE -> (0x00010000)
        public const int USN_REASON_HARD_LINK_CHANGE = 65536;

        /// USN_REASON_FILE_DELETE -> (0x00000200)
        public const int USN_REASON_FILE_DELETE = 512;

        /// USN_REASON_FILE_CREATE -> (0x00000100)
        public const int USN_REASON_FILE_CREATE = 256;

        /// USN_REASON_ENCRYPTION_CHANGE -> (0x00040000)
        public const int USN_REASON_ENCRYPTION_CHANGE = 262144;

        /// USN_REASON_EA_CHANGE -> (0x00000400)
        public const int USN_REASON_EA_CHANGE = 1024;

        /// USN_REASON_DATA_TRUNCATION -> (0x00000004)
        public const int USN_REASON_DATA_TRUNCATION = 4;

        /// USN_REASON_DATA_OVERWRITE -> (0x00000001)
        public const int USN_REASON_DATA_OVERWRITE = 1;

        /// USN_REASON_DATA_EXTEND -> (0x00000002)
        public const int USN_REASON_DATA_EXTEND = 2;

        /// USN_REASON_COMPRESSION_CHANGE -> (0x00020000)
        public const int USN_REASON_COMPRESSION_CHANGE = 131072;

        /// USN_REASON_CLOSE -> (0x80000000)
        public const int USN_REASON_CLOSE = -2147483648;

        /// USN_REASON_BASIC_INFO_CHANGE -> (0x00008000)
        public const int USN_REASON_BASIC_INFO_CHANGE = 32768;

        /// USN_PAGE_SIZE -> (0x1000)
        public const int USN_PAGE_SIZE = 4096;

        /// USN_DELETE_VALID_FLAGS -> (0x00000003)
        public const int USN_DELETE_VALID_FLAGS = 3;

        /// USN_DELETE_FLAG_NOTIFY -> (0x00000002)
        public const int USN_DELETE_FLAG_NOTIFY = 2;

        /// USN_DELETE_FLAG_DELETE -> (0x00000001)
        public const int USN_DELETE_FLAG_DELETE = 1;

        /// USHRT_MAX -> 0xffff
        public const int USHRT_MAX = 65535;

        /// USER_TIMER_MINIMUM -> 0x0000000A
        public const int USER_TIMER_MINIMUM = 10;

        /// USER_TIMER_MAXIMUM -> 0x7FFFFFFF
        public const int USER_TIMER_MAXIMUM = 2147483647;

        /// USER_MARSHAL_FC_WCHAR -> 5
        public const int USER_MARSHAL_FC_WCHAR = 5;

        /// USER_MARSHAL_FC_USMALL -> 4
        public const int USER_MARSHAL_FC_USMALL = 4;

        /// USER_MARSHAL_FC_USHORT -> 7
        public const int USER_MARSHAL_FC_USHORT = 7;

        /// USER_MARSHAL_FC_ULONG -> 9
        public const int USER_MARSHAL_FC_ULONG = 9;

        /// USER_MARSHAL_FC_SMALL -> 3
        public const int USER_MARSHAL_FC_SMALL = 3;

        /// USER_MARSHAL_FC_SHORT -> 6
        public const int USER_MARSHAL_FC_SHORT = 6;

        /// USER_MARSHAL_FC_LONG -> 8
        public const int USER_MARSHAL_FC_LONG = 8;

        /// USER_MARSHAL_FC_HYPER -> 11
        public const int USER_MARSHAL_FC_HYPER = 11;

        /// USER_MARSHAL_FC_FLOAT -> 10
        public const int USER_MARSHAL_FC_FLOAT = 10;

        /// USER_MARSHAL_FC_DOUBLE -> 12
        public const int USER_MARSHAL_FC_DOUBLE = 12;

        /// USER_MARSHAL_FC_CHAR -> 2
        public const int USER_MARSHAL_FC_CHAR = 2;

        /// USER_MARSHAL_FC_BYTE -> 1
        public const int USER_MARSHAL_FC_BYTE = 1;

        /// USER_CALL_NEW_CORRELATION_DESC -> 0x0200
        public const int USER_CALL_NEW_CORRELATION_DESC = 512;

        /// USER_CALL_IS_ASYNC -> 0x0100
        public const int USER_CALL_IS_ASYNC = 256;

        /// USAGE_MATCH_TYPE_OR -> 0x00000001
        public const int USAGE_MATCH_TYPE_OR = 1;

        /// USAGE_MATCH_TYPE_AND -> 0x00000000
        public const int USAGE_MATCH_TYPE_AND = 0;

        /// URL_OID_GET_OBJECT_URL_FUNC -> "UrlDllGetObjectUrl"
        public const string URL_OID_GET_OBJECT_URL_FUNC = "UrlDllGetObjectUrl";

        /// URL_MK_UNIFORM -> 1
        public const int URL_MK_UNIFORM = 1;

        /// URL_MK_NO_CANONICALIZE -> 2
        public const int URL_MK_NO_CANONICALIZE = 2;

        /// URL_MK_LEGACY -> 0
        public const int URL_MK_LEGACY = 0;

        /// URLZONE_ESC_FLAG -> 0x100
        public const int URLZONE_ESC_FLAG = 256;

        /// URLPOLICY_QUERY -> 0x01
        public const int URLPOLICY_QUERY = 1;

        /// URLPOLICY_NOTIFY_ON_DISALLOW -> 0x20
        public const int URLPOLICY_NOTIFY_ON_DISALLOW = 32;

        /// URLPOLICY_NOTIFY_ON_ALLOW -> 0x10
        public const int URLPOLICY_NOTIFY_ON_ALLOW = 16;

        /// URLPOLICY_MASK_PERMISSIONS -> 0x0f
        public const int URLPOLICY_MASK_PERMISSIONS = 15;

        /// URLPOLICY_LOG_ON_DISALLOW -> 0x80
        public const int URLPOLICY_LOG_ON_DISALLOW = 128;

        /// URLPOLICY_LOG_ON_ALLOW -> 0x40
        public const int URLPOLICY_LOG_ON_ALLOW = 64;

        /// URLPOLICY_JAVA_PROHIBIT -> 0x00000000
        public const int URLPOLICY_JAVA_PROHIBIT = 0;

        /// URLPOLICY_JAVA_MEDIUM -> 0x00020000
        public const int URLPOLICY_JAVA_MEDIUM = 131072;

        /// URLPOLICY_JAVA_LOW -> 0x00030000
        public const int URLPOLICY_JAVA_LOW = 196608;

        /// URLPOLICY_JAVA_HIGH -> 0x00010000
        public const int URLPOLICY_JAVA_HIGH = 65536;

        /// URLPOLICY_JAVA_CUSTOM -> 0x00800000
        public const int URLPOLICY_JAVA_CUSTOM = 8388608;

        /// URLPOLICY_DONTCHECKDLGBOX -> 0x100
        public const int URLPOLICY_DONTCHECKDLGBOX = 256;

        /// URLPOLICY_DISALLOW -> 0x03
        public const int URLPOLICY_DISALLOW = 3;

        /// URLPOLICY_CREDENTIALS_SILENT_LOGON_OK -> 0x00000000
        public const int URLPOLICY_CREDENTIALS_SILENT_LOGON_OK = 0;

        /// URLPOLICY_CREDENTIALS_MUST_PROMPT_USER -> 0x00010000
        public const int URLPOLICY_CREDENTIALS_MUST_PROMPT_USER = 65536;

        /// URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT -> 0x00020000
        public const int URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT = 131072;

        /// URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY -> 0x00030000
        public const int URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY = 196608;

        /// URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT -> 0x00010000
        public const int URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT = 65536;

        /// URLPOLICY_CHANNEL_SOFTDIST_PRECACHE -> 0x00020000
        public const int URLPOLICY_CHANNEL_SOFTDIST_PRECACHE = 131072;

        /// URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL -> 0x00030000
        public const int URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL = 196608;

        /// URLPOLICY_BEHAVIOR_CHECK_LIST -> 0x00010000
        public const int URLPOLICY_BEHAVIOR_CHECK_LIST = 65536;

        /// URLPOLICY_AUTHENTICATE_MUTUAL_ONLY -> 0x00030000
        public const int URLPOLICY_AUTHENTICATE_MUTUAL_ONLY = 196608;

        /// URLPOLICY_AUTHENTICATE_CLEARTEXT_OK -> 0x00000000
        public const int URLPOLICY_AUTHENTICATE_CLEARTEXT_OK = 0;

        /// URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE -> 0x00010000
        public const int URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE = 65536;

        /// URLPOLICY_ALLOW -> 0x00
        public const int URLPOLICY_ALLOW = 0;

        /// URLPOLICY_ACTIVEX_CHECK_LIST -> 0x00010000
        public const int URLPOLICY_ACTIVEX_CHECK_LIST = 65536;

        /// URLOSTRM_USECACHEDCOPY_ONLY -> 0x1
        public const int URLOSTRM_USECACHEDCOPY_ONLY = 1;

        /// URLOSTRM_USECACHEDCOPY -> 0x2
        public const int URLOSTRM_USECACHEDCOPY = 2;

        /// URLOSTRM_GETNEWESTVERSION -> 0x3
        public const int URLOSTRM_GETNEWESTVERSION = 3;

        /// URLOpenStream -> URLOpenStreamW
        /// Error generating expression: Value URLOpenStreamW is not resolved
        public const string URLOpenStream = "URLOpenStreamW";

        /// URLOpenPullStream -> URLOpenPullStreamW
        /// Error generating expression: Value URLOpenPullStreamW is not resolved
        public const string URLOpenPullStream = "URLOpenPullStreamW";

        /// URLOpenBlockingStream -> URLOpenBlockingStreamW
        /// Error generating expression: Value URLOpenBlockingStreamW is not resolved
        public const string URLOpenBlockingStream = "URLOpenBlockingStreamW";

        /// URLMON_OPTION_USE_BINDSTRINGCREDS -> 0x10000008
        public const int URLMON_OPTION_USE_BINDSTRINGCREDS = 268435464;

        /// URLMON_OPTION_USERAGENT_REFRESH -> 0x10000002
        public const int URLMON_OPTION_USERAGENT_REFRESH = 268435458;

        /// URLMON_OPTION_USERAGENT -> 0x10000001
        public const int URLMON_OPTION_USERAGENT = 268435457;

        /// URLMON_OPTION_URL_ENCODING -> 0x10000004
        public const int URLMON_OPTION_URL_ENCODING = 268435460;

        /// URLDownloadToFile -> URLDownloadToFileW
        /// Error generating expression: Value URLDownloadToFileW is not resolved
        public const string URLDownloadToFile = "URLDownloadToFileW";

        /// URLDownloadToCacheFile -> URLDownloadToCacheFileW
        /// Error generating expression: Value URLDownloadToCacheFileW is not resolved
        public const string URLDownloadToCacheFile = "URLDownloadToCacheFileW";

        /// URLACTION_SHELL_WEBVIEW_VERB -> 0x00001805
        public const int URLACTION_SHELL_WEBVIEW_VERB = 6149;

        /// URLACTION_SHELL_VERB -> 0x00001804
        public const int URLACTION_SHELL_VERB = 6148;

        /// URLACTION_SHELL_SHELLEXECUTE -> 0x00001806
        public const int URLACTION_SHELL_SHELLEXECUTE = 6150;

        /// URLACTION_SHELL_RTF_OBJECTS_LOAD -> 0x0000180A
        public const int URLACTION_SHELL_RTF_OBJECTS_LOAD = 6154;

        /// URLACTION_SHELL_POPUPMGR -> 0x00001809
        public const int URLACTION_SHELL_POPUPMGR = 6153;

        /// URLACTION_SHELL_MOVE_OR_COPY -> 0x00001802
        public const int URLACTION_SHELL_MOVE_OR_COPY = 6146;

        /// URLACTION_SHELL_MIN -> 0x00001800
        public const int URLACTION_SHELL_MIN = 6144;

        /// URLACTION_SHELL_MAX -> 0x000019ff
        public const int URLACTION_SHELL_MAX = 6655;

        /// URLACTION_SHELL_INSTALL_DTITEMS -> 0x00001800
        public const int URLACTION_SHELL_INSTALL_DTITEMS = 6144;

        /// URLACTION_SHELL_FILE_DOWNLOAD -> 0x00001803
        public const int URLACTION_SHELL_FILE_DOWNLOAD = 6147;

        /// URLACTION_SHELL_EXECUTE_MODRISK -> 0x00001807
        public const int URLACTION_SHELL_EXECUTE_MODRISK = 6151;

        /// URLACTION_SHELL_EXECUTE_LOWRISK -> 0x00001808
        public const int URLACTION_SHELL_EXECUTE_LOWRISK = 6152;

        /// URLACTION_SHELL_EXECUTE_HIGHRISK -> 0x00001806
        public const int URLACTION_SHELL_EXECUTE_HIGHRISK = 6150;

        /// URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY -> 0x0000180B
        public const int URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY = 6155;

        /// URLACTION_SHELL_CURR_MAX -> 0x0000180B
        public const int URLACTION_SHELL_CURR_MAX = 6155;

        /// URLACTION_SCRIPT_SAFE_ACTIVEX -> 0x00001405
        public const int URLACTION_SCRIPT_SAFE_ACTIVEX = 5125;

        /// URLACTION_SCRIPT_RUN -> 0x00001400
        public const int URLACTION_SCRIPT_RUN = 5120;

        /// URLACTION_SCRIPT_PASTE -> 0x00001407
        public const int URLACTION_SCRIPT_PASTE = 5127;

        /// URLACTION_SCRIPT_OVERRIDE_SAFETY -> 0x00001401
        public const int URLACTION_SCRIPT_OVERRIDE_SAFETY = 5121;

        /// URLACTION_SCRIPT_MIN -> 0x00001400
        public const int URLACTION_SCRIPT_MIN = 5120;

        /// URLACTION_SCRIPT_MAX -> 0x000015ff
        public const int URLACTION_SCRIPT_MAX = 5631;

        /// URLACTION_SCRIPT_JAVA_USE -> 0x00001402
        public const int URLACTION_SCRIPT_JAVA_USE = 5122;

        /// URLACTION_SCRIPT_CURR_MAX -> 0x00001407
        public const int URLACTION_SCRIPT_CURR_MAX = 5127;

        /// URLACTION_NETWORK_MIN -> 0x00001A00
        public const int URLACTION_NETWORK_MIN = 6656;

        /// URLACTION_NETWORK_MAX -> 0x00001Bff
        public const int URLACTION_NETWORK_MAX = 7167;

        /// URLACTION_NETWORK_CURR_MAX -> 0x00001A10
        public const int URLACTION_NETWORK_CURR_MAX = 6672;

        /// URLACTION_MIN -> 0x00001000
        public const int URLACTION_MIN = 4096;

        /// URLACTION_JAVA_PERMISSIONS -> 0x00001C00
        public const int URLACTION_JAVA_PERMISSIONS = 7168;

        /// URLACTION_JAVA_MIN -> 0x00001C00
        public const int URLACTION_JAVA_MIN = 7168;

        /// URLACTION_JAVA_MAX -> 0x00001Cff
        public const int URLACTION_JAVA_MAX = 7423;

        /// URLACTION_JAVA_CURR_MAX -> 0x00001C00
        public const int URLACTION_JAVA_CURR_MAX = 7168;

        /// URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS -> 0x00001D05
        public const int URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS = 7429;

        /// URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS -> 0x00001D02
        public const int URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS = 7426;

        /// URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS -> 0x00001D04
        public const int URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS = 7428;

        /// URLACTION_INFODELIVERY_NO_EDITING_CHANNELS -> 0x00001D01
        public const int URLACTION_INFODELIVERY_NO_EDITING_CHANNELS = 7425;

        /// URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING -> 0x00001D06
        public const int URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING = 7430;

        /// URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS -> 0x00001D03
        public const int URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS = 7427;

        /// URLACTION_INFODELIVERY_NO_ADDING_CHANNELS -> 0x00001D00
        public const int URLACTION_INFODELIVERY_NO_ADDING_CHANNELS = 7424;

        /// URLACTION_INFODELIVERY_MIN -> 0x00001D00
        public const int URLACTION_INFODELIVERY_MIN = 7424;

        /// URLACTION_INFODELIVERY_MAX -> 0x00001Dff
        public const int URLACTION_INFODELIVERY_MAX = 7679;

        /// URLACTION_INFODELIVERY_CURR_MAX -> 0x00001D06
        public const int URLACTION_INFODELIVERY_CURR_MAX = 7430;

        /// URLACTION_HTML_USERDATA_SAVE -> 0x00001606
        public const int URLACTION_HTML_USERDATA_SAVE = 5638;

        /// URLACTION_HTML_SUBMIT_FORMS_TO -> 0x00001603
        public const int URLACTION_HTML_SUBMIT_FORMS_TO = 5635;

        /// URLACTION_HTML_SUBMIT_FORMS_FROM -> 0x00001602
        public const int URLACTION_HTML_SUBMIT_FORMS_FROM = 5634;

        /// URLACTION_HTML_SUBMIT_FORMS -> 0x00001601
        public const int URLACTION_HTML_SUBMIT_FORMS = 5633;

        /// URLACTION_HTML_SUBFRAME_NAVIGATE -> 0x00001607
        public const int URLACTION_HTML_SUBFRAME_NAVIGATE = 5639;

        /// URLACTION_HTML_MIXED_CONTENT -> 0x00001609
        public const int URLACTION_HTML_MIXED_CONTENT = 5641;

        /// URLACTION_HTML_MIN -> 0x00001600
        public const int URLACTION_HTML_MIN = 5632;

        /// URLACTION_HTML_META_REFRESH -> 0x00001608
        public const int URLACTION_HTML_META_REFRESH = 5640;

        /// URLACTION_HTML_MAX -> 0x000017ff
        public const int URLACTION_HTML_MAX = 6143;

        /// URLACTION_HTML_JAVA_RUN -> 0x00001605
        public const int URLACTION_HTML_JAVA_RUN = 5637;

        /// URLACTION_HTML_FONT_DOWNLOAD -> 0x00001604
        public const int URLACTION_HTML_FONT_DOWNLOAD = 5636;

        /// URLACTION_FEATURE_ZONE_ELEVATION -> 0x00002101
        public const int URLACTION_FEATURE_ZONE_ELEVATION = 8449;

        /// URLACTION_FEATURE_WINDOW_RESTRICTIONS -> 0x00002102
        public const int URLACTION_FEATURE_WINDOW_RESTRICTIONS = 8450;

        /// URLACTION_FEATURE_MIN -> 0x00002100
        public const int URLACTION_FEATURE_MIN = 8448;

        /// URLACTION_FEATURE_MIME_SNIFFING -> 0x00002100
        public const int URLACTION_FEATURE_MIME_SNIFFING = 8448;

        /// URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX -> 0x00001004
        public const int URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX = 4100;

        /// URLACTION_DOWNLOAD_SIGNED_ACTIVEX -> 0x00001001
        public const int URLACTION_DOWNLOAD_SIGNED_ACTIVEX = 4097;

        /// URLACTION_DOWNLOAD_MIN -> 0x00001000
        public const int URLACTION_DOWNLOAD_MIN = 4096;

        /// URLACTION_DOWNLOAD_MAX -> 0x000011FF
        public const int URLACTION_DOWNLOAD_MAX = 4607;

        /// URLACTION_DOWNLOAD_CURR_MAX -> 0x00001004
        public const int URLACTION_DOWNLOAD_CURR_MAX = 4100;

        /// URLACTION_CROSS_DOMAIN_DATA -> 0x00001406
        public const int URLACTION_CROSS_DOMAIN_DATA = 5126;

        /// URLACTION_CREDENTIALS_USE -> 0x00001A00
        public const int URLACTION_CREDENTIALS_USE = 6656;

        /// URLACTION_COOKIES_THIRD_PARTY -> 0x00001A05
        public const int URLACTION_COOKIES_THIRD_PARTY = 6661;

        /// URLACTION_COOKIES_SESSION_THIRD_PARTY -> 0x00001A06
        public const int URLACTION_COOKIES_SESSION_THIRD_PARTY = 6662;

        /// URLACTION_COOKIES_SESSION -> 0x00001A03
        public const int URLACTION_COOKIES_SESSION = 6659;

        /// URLACTION_COOKIES_ENABLED -> 0x00001A10
        public const int URLACTION_COOKIES_ENABLED = 6672;

        /// URLACTION_COOKIES -> 0x00001A02
        public const int URLACTION_COOKIES = 6658;

        /// URLACTION_CLIENT_CERT_PROMPT -> 0x00001A04
        public const int URLACTION_CLIENT_CERT_PROMPT = 6660;

        /// URLACTION_CHANNEL_SOFTDIST_PERMISSIONS -> 0x00001E05
        public const int URLACTION_CHANNEL_SOFTDIST_PERMISSIONS = 7685;

        /// URLACTION_CHANNEL_SOFTDIST_MIN -> 0x00001E00
        public const int URLACTION_CHANNEL_SOFTDIST_MIN = 7680;

        /// URLACTION_CHANNEL_SOFTDIST_MAX -> 0x00001Eff
        public const int URLACTION_CHANNEL_SOFTDIST_MAX = 7935;

        /// URLACTION_BEHAVIOR_RUN -> 0x00002000
        public const int URLACTION_BEHAVIOR_RUN = 8192;

        /// URLACTION_BEHAVIOR_MIN -> 0x00002000
        public const int URLACTION_BEHAVIOR_MIN = 8192;

        /// URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN -> 0x00002200
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN = 8704;

        /// URLACTION_AUTOMATIC_DOWNLOAD_UI -> 0x00002200
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI = 8704;

        /// URLACTION_AUTOMATIC_ACTIVEX_UI -> 0x00002201
        public const int URLACTION_AUTOMATIC_ACTIVEX_UI = 8705;

        /// URLACTION_AUTHENTICATE_CLIENT -> 0x00001A01
        public const int URLACTION_AUTHENTICATE_CLIENT = 6657;

        /// URLACTION_ALLOW_RESTRICTEDPROTOCOLS -> 0x00002300
        public const int URLACTION_ALLOW_RESTRICTEDPROTOCOLS = 8960;

        /// URLACTION_ACTIVEX_TREATASUNTRUSTED -> 0x00001205
        public const int URLACTION_ACTIVEX_TREATASUNTRUSTED = 4613;

        /// URLACTION_ACTIVEX_RUN -> 0x00001200
        public const int URLACTION_ACTIVEX_RUN = 4608;

        /// URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY -> 0x00001203
        public const int URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY = 4611;

        /// URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY -> 0x00001201
        public const int URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY = 4609;

        /// URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY -> 0x00001202
        public const int URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY = 4610;

        /// URLACTION_ACTIVEX_NO_WEBOC_SCRIPT -> 0x00001206
        public const int URLACTION_ACTIVEX_NO_WEBOC_SCRIPT = 4614;

        /// URLACTION_ACTIVEX_MIN -> 0x00001200
        public const int URLACTION_ACTIVEX_MIN = 4608;

        /// URLACTION_ACTIVEX_MAX -> 0x000013ff
        public const int URLACTION_ACTIVEX_MAX = 5119;

        /// URLACTION_ACTIVEX_CURR_MAX -> 0x00001206
        public const int URLACTION_ACTIVEX_CURR_MAX = 4614;

        /// URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY -> 0x00001204
        public const int URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY = 4612;

        /// UPDFCACHE_ONSTOPCACHE -> ( 0x4 )
        public const int UPDFCACHE_ONSTOPCACHE = 4;

        /// UPDFCACHE_ONSAVECACHE -> ( 0x2 )
        public const int UPDFCACHE_ONSAVECACHE = 2;

        /// UPDFCACHE_ONLYIFBLANK -> ( 0x80000000 )
        public const int UPDFCACHE_ONLYIFBLANK = -2147483648;

        /// UPDFCACHE_NORMALCACHE -> ( 0x8 )
        public const int UPDFCACHE_NORMALCACHE = 8;

        /// UPDFCACHE_NODATACACHE -> ( 0x1 )
        public const int UPDFCACHE_NODATACACHE = 1;

        /// UPDFCACHE_IFBLANKORONSAVECACHE -> ( UPDFCACHE_IFBLANK | UPDFCACHE_ONSAVECACHE )
        public const int UPDFCACHE_IFBLANKORONSAVECACHE = (NativeConstants.UPDFCACHE_IFBLANK | NativeConstants.UPDFCACHE_ONSAVECACHE);

        /// UPDFCACHE_IFBLANK -> ( 0x10 )
        public const int UPDFCACHE_IFBLANK = 16;

        /// UpdateResource -> UpdateResourceW
        /// Error generating expression: Value UpdateResourceW is not resolved
        public const string UpdateResource = "UpdateResourceW";

        /// UpdateICMRegKey -> UpdateICMRegKeyW
        /// Error generating expression: Value UpdateICMRegKeyW is not resolved
        public const string UpdateICMRegKey = "UpdateICMRegKeyW";

        /// UOI_USER_SID -> 4
        public const int UOI_USER_SID = 4;

        /// UOI_TYPE -> 3
        public const int UOI_TYPE = 3;

        /// UOI_NAME -> 2
        public const int UOI_NAME = 2;

        /// UOI_FLAGS -> 1
        public const int UOI_FLAGS = 1;

        /// UnregisterClass -> UnregisterClassW
        /// Error generating expression: Value UnregisterClassW is not resolved
        public const string UnregisterClass = "UnregisterClassW";

        /// UNRECOVERED_WRITES_VALID -> 0x00000002
        public const int UNRECOVERED_WRITES_VALID = 2;

        /// UNRECOVERED_READS_VALID -> 0x00000008
        public const int UNRECOVERED_READS_VALID = 8;

        /// UNPROTECTED_SACL_SECURITY_INFORMATION -> (0x10000000L)
        public const int UNPROTECTED_SACL_SECURITY_INFORMATION = 268435456;

        /// UNPROTECTED_DACL_SECURITY_INFORMATION -> (0x20000000L)
        public const int UNPROTECTED_DACL_SECURITY_INFORMATION = 536870912;

        /// UNLOCK_ELEMENT -> 1
        public const int UNLOCK_ELEMENT = 1;

        /// UNLOAD_DLL_DEBUG_EVENT -> 7
        public const int UNLOAD_DLL_DEBUG_EVENT = 7;

        /// UNIVERSAL_NAME_INFO_LEVEL -> 0x00000001
        public const int UNIVERSAL_NAME_INFO_LEVEL = 1;

        /// UNIQUE_NAME -> 0x00
        public const int UNIQUE_NAME = 0;

        /// UNICODE_STRING_MAX_CHARS -> (32767)
        public const int UNICODE_STRING_MAX_CHARS = 32767;

        /// UNICODE_NOCHAR -> 0xFFFF
        public const int UNICODE_NOCHAR = 65535;

        /// UNICODE -> 1
        public const int UNICODE = 1;

        /// UNDEFINE_PRIMARY -> 0xC
        public const int UNDEFINE_PRIMARY = 12;

        /// UNDEFINE_ALTERNATE -> 0xD
        public const int UNDEFINE_ALTERNATE = 13;

        /// ULW_OPAQUE -> 0x00000004
        public const int ULW_OPAQUE = 4;

        /// ULW_EX_NORESIZE -> 0x00000008
        public const int ULW_EX_NORESIZE = 8;

        /// ULW_COLORKEY -> 0x00000001
        public const int ULW_COLORKEY = 1;

        /// ULW_ALPHA -> 0x00000002
        public const int ULW_ALPHA = 2;

        /// ULONG_MAX -> 0xffffffffUL
        public const uint ULONG_MAX = 4294967295u;

        /// ULLONG_MAX -> 0xffffffffffffffffui64
        public const ulong ULLONG_MAX = 18446744073709551615ul;

        /// UI_CAP_ROTANY -> 0x00000004
        public const int UI_CAP_ROTANY = 4;

        /// UI_CAP_ROT90 -> 0x00000002
        public const int UI_CAP_ROT90 = 2;

        /// UI_CAP_2700 -> 0x00000001
        public const int UI_CAP_2700 = 1;

        /// UIS_SET -> 1
        public const int UIS_SET = 1;

        /// UIS_INITIALIZE -> 3
        public const int UIS_INITIALIZE = 3;

        /// UIS_CLEAR -> 2
        public const int UIS_CLEAR = 2;

        /// UISF_HIDEFOCUS -> 0x1
        public const int UISF_HIDEFOCUS = 1;

        /// UISF_HIDEACCEL -> 0x2
        public const int UISF_HIDEACCEL = 2;

        /// UISF_ACTIVE -> 0x4
        public const int UISF_ACTIVE = 4;

        /// UINT_MAX -> 0xffffffff
        public const int UINT_MAX = -1;

        /// UILANGUAGE_ENUMPROC -> UILANGUAGE_ENUMPROCW
        /// Error generating expression: Value UILANGUAGE_ENUMPROCW is not resolved
        public const string UILANGUAGE_ENUMPROC = "UILANGUAGE_ENUMPROCW";

        /// UDIRTYUI -> (SHTDN_REASON_FLAG_DIRTY_UI)
        public const int UDIRTYUI = NativeConstants.SHTDN_REASON_FLAG_DIRTY_UI;

        /// UCLEANUI -> (SHTDN_REASON_FLAG_CLEAN_UI)
        public const int UCLEANUI = NativeConstants.SHTDN_REASON_FLAG_CLEAN_UI;

        /// UCHAR_MAX -> 0xff
        public const int UCHAR_MAX = 255;

        /// ua_wcsrchr -> wcsrchr
        /// Error generating expression: Value wcsrchr is not resolved
        public const string ua_wcsrchr = "wcsrchr";

        /// ua_wcslen -> wcslen
        /// Error generating expression: Value wcslen is not resolved
        public const string ua_wcslen = "wcslen";

        /// ua_wcsicmp -> wcsicmp
        /// Error generating expression: Value wcsicmp is not resolved
        public const string ua_wcsicmp = "wcsicmp";

        /// ua_wcschr -> wcschr
        /// Error generating expression: Value wcschr is not resolved
        public const string ua_wcschr = "wcschr";

        /// ua_tcscpy -> ua_wcscpy
        /// Error generating expression: Value ua_wcscpy is not resolved
        public const string ua_tcscpy = "ua_wcscpy";

        /// ua_lstrlenW -> lstrlenW
        /// Error generating expression: Value lstrlenW is not resolved
        public const string ua_lstrlenW = "lstrlenW";

        /// ua_lstrlen -> ua_lstrlenW
        public const string ua_lstrlen = NativeConstants.ua_lstrlenW;

        /// ua_lstrcmpW -> lstrcmpW
        /// Error generating expression: Value lstrcmpW is not resolved
        public const string ua_lstrcmpW = "lstrcmpW";

        /// ua_lstrcmpiW -> lstrcmpiW
        /// Error generating expression: Value lstrcmpiW is not resolved
        public const string ua_lstrcmpiW = "lstrcmpiW";

        /// ua_lstrcmpi -> ua_lstrcmpiW
        public const string ua_lstrcmpi = NativeConstants.ua_lstrcmpiW;

        /// ua_lstrcmp -> ua_lstrcmpW
        public const string ua_lstrcmp = NativeConstants.ua_lstrcmpW;

        /// ua_CharUpperW -> CharUpperW
        /// Error generating expression: Value CharUpperW is not resolved
        public const string ua_CharUpperW = "CharUpperW";

        /// ua_CharUpper -> ua_CharUpperW
        public const string ua_CharUpper = NativeConstants.ua_CharUpperW;
    }

}
