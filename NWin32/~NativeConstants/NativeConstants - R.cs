using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// RUSSIAN_CHARSET -> 204
        public const int RUSSIAN_CHARSET = 204;

        /// RUNDLGORD -> 1545
        public const int RUNDLGORD = 1545;

        /// RTS_CONTROL_TOGGLE -> 0x03
        public const int RTS_CONTROL_TOGGLE = 3;

        /// RTS_CONTROL_HANDSHAKE -> 0x02
        public const int RTS_CONTROL_HANDSHAKE = 2;

        /// RTS_CONTROL_ENABLE -> 0x01
        public const int RTS_CONTROL_ENABLE = 1;

        /// RTS_CONTROL_DISABLE -> 0x00
        public const int RTS_CONTROL_DISABLE = 0;

        /// RTL_VRF_FLG_VIRTUAL_SPACE_TRACKING -> 0x00010000
        public const int RTL_VRF_FLG_VIRTUAL_SPACE_TRACKING = 65536;

        /// RTL_VRF_FLG_VIRTUAL_MEM_CHECKS -> 0x00002000
        public const int RTL_VRF_FLG_VIRTUAL_MEM_CHECKS = 8192;

        /// RTL_VRF_FLG_TLS_CHECKS -> 0x00000020
        public const int RTL_VRF_FLG_TLS_CHECKS = 32;

        /// RTL_VRF_FLG_STACK_CHECKS -> 0x00000008
        public const int RTL_VRF_FLG_STACK_CHECKS = 8;

        /// RTL_VRF_FLG_RPC_CHECKS -> 0x00000080
        public const int RTL_VRF_FLG_RPC_CHECKS = 128;

        /// RTL_VRF_FLG_RESERVED_DONOTUSE -> 0x00000002
        public const int RTL_VRF_FLG_RESERVED_DONOTUSE = 2;

        /// RTL_VRF_FLG_RACE_CHECKS -> 0x00000400
        public const int RTL_VRF_FLG_RACE_CHECKS = 1024;

        /// RTL_VRF_FLG_MISCELLANEOUS_CHECKS -> 0x00020000
        public const int RTL_VRF_FLG_MISCELLANEOUS_CHECKS = 131072;

        /// RTL_VRF_FLG_LOCK_CHECKS -> 0x00040000
        public const int RTL_VRF_FLG_LOCK_CHECKS = 262144;

        /// RTL_VRF_FLG_HANDLE_CHECKS -> 0x00000004
        public const int RTL_VRF_FLG_HANDLE_CHECKS = 4;

        /// RTL_VRF_FLG_FULL_PAGE_HEAP -> 0x00000001
        public const int RTL_VRF_FLG_FULL_PAGE_HEAP = 1;

        /// RTL_VRF_FLG_FIRST_CHANCE_EXCEPTION_CHECKS -> 0x00001000
        public const int RTL_VRF_FLG_FIRST_CHANCE_EXCEPTION_CHECKS = 4096;

        /// RTL_VRF_FLG_FAST_FILL_HEAP -> 0x00008000
        public const int RTL_VRF_FLG_FAST_FILL_HEAP = 32768;

        /// RTL_VRF_FLG_ENABLE_LOGGING -> 0x00004000
        public const int RTL_VRF_FLG_ENABLE_LOGGING = 16384;

        /// RTL_VRF_FLG_ENABLED_SYSTEM_WIDE -> 0x00020000
        public const int RTL_VRF_FLG_ENABLED_SYSTEM_WIDE = 131072;

        /// RTL_VRF_FLG_DIRTY_STACKS -> 0x00000040
        public const int RTL_VRF_FLG_DIRTY_STACKS = 64;

        /// RTL_VRF_FLG_DEADLOCK_CHECKS -> 0x00000800
        public const int RTL_VRF_FLG_DEADLOCK_CHECKS = 2048;

        /// RTL_VRF_FLG_DANGEROUS_APIS -> 0x00000200
        public const int RTL_VRF_FLG_DANGEROUS_APIS = 512;

        /// RTL_VRF_FLG_COM_CHECKS -> 0x00000100
        public const int RTL_VRF_FLG_COM_CHECKS = 256;

        /// RTL_VRF_FLG_APPCOMPAT_CHECKS -> 0x00000010
        public const int RTL_VRF_FLG_APPCOMPAT_CHECKS = 16;

        /// RTL_RESOURCE_TYPE -> 1
        public const int RTL_RESOURCE_TYPE = 1;

        /// RTL_CRITSECT_TYPE -> 0
        public const int RTL_CRITSECT_TYPE = 0;

        /// RSIZE_MAX -> SIZE_MAX
        public const int RSIZE_MAX = NativeConstants.SIZE_MAX;

        /// RSA1024BIT_KEY -> 0x04000000
        public const int RSA1024BIT_KEY = 67108864;

        /// RRF_ZEROONFAILURE -> 0x20000000
        public const int RRF_ZEROONFAILURE = 536870912;

        /// RRF_RT_REG_SZ -> 0x00000002
        public const int RRF_RT_REG_SZ = 2;

        /// RRF_RT_REG_QWORD -> 0x00000040
        public const int RRF_RT_REG_QWORD = 64;

        /// RRF_RT_REG_NONE -> 0x00000001
        public const int RRF_RT_REG_NONE = 1;

        /// RRF_RT_REG_MULTI_SZ -> 0x00000020
        public const int RRF_RT_REG_MULTI_SZ = 32;

        /// RRF_RT_REG_EXPAND_SZ -> 0x00000004
        public const int RRF_RT_REG_EXPAND_SZ = 4;

        /// RRF_RT_REG_DWORD -> 0x00000010
        public const int RRF_RT_REG_DWORD = 16;

        /// RRF_RT_REG_BINARY -> 0x00000008
        public const int RRF_RT_REG_BINARY = 8;

        /// RRF_RT_QWORD -> (RRF_RT_REG_BINARY | RRF_RT_REG_QWORD)
        public const int RRF_RT_QWORD = (NativeConstants.RRF_RT_REG_BINARY | NativeConstants.RRF_RT_REG_QWORD);

        /// RRF_RT_DWORD -> (RRF_RT_REG_BINARY | RRF_RT_REG_DWORD)
        public const int RRF_RT_DWORD = (NativeConstants.RRF_RT_REG_BINARY | NativeConstants.RRF_RT_REG_DWORD);

        /// RRF_RT_ANY -> 0x0000ffff
        public const int RRF_RT_ANY = 65535;

        /// RRF_NOEXPAND -> 0x10000000
        public const int RRF_NOEXPAND = 268435456;

        /// RP_LOGON -> 0x01
        public const int RP_LOGON = 1;

        /// RP_INIFILE -> 0x02
        public const int RP_INIFILE = 2;

        /// RPC_X_WRONG_STUB_VERSION -> 1829L
        public const int RPC_X_WRONG_STUB_VERSION = 1829;

        /// RPC_X_WRONG_PIPE_VERSION -> 1832L
        public const int RPC_X_WRONG_PIPE_VERSION = 1832;

        /// RPC_X_WRONG_PIPE_ORDER -> 1831L
        public const int RPC_X_WRONG_PIPE_ORDER = 1831;

        /// RPC_X_WRONG_ES_VERSION -> 1828L
        public const int RPC_X_WRONG_ES_VERSION = 1828;

        /// RPC_X_SS_IN_NULL_CONTEXT -> 1775L
        public const int RPC_X_SS_IN_NULL_CONTEXT = 1775;

        /// RPC_X_SS_HANDLES_MISMATCH -> 1778L
        public const int RPC_X_SS_HANDLES_MISMATCH = 1778;

        /// RPC_X_SS_CONTEXT_MISMATCH -> ERROR_INVALID_HANDLE
        public const int RPC_X_SS_CONTEXT_MISMATCH = NativeConstants.ERROR_INVALID_HANDLE;

        /// RPC_X_SS_CONTEXT_DAMAGED -> 1777L
        public const int RPC_X_SS_CONTEXT_DAMAGED = 1777;

        /// RPC_X_SS_CHAR_TRANS_SHORT_FILE -> 1774L
        public const int RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774;

        /// RPC_X_SS_CHAR_TRANS_OPEN_FAIL -> 1773L
        public const int RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773;

        /// RPC_X_SS_CANNOT_GET_CALL_HANDLE -> 1779L
        public const int RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779;

        /// RPC_X_PIPE_EMPTY -> 1918L
        public const int RPC_X_PIPE_EMPTY = 1918;

        /// RPC_X_PIPE_DISCIPLINE_ERROR -> 1917L
        public const int RPC_X_PIPE_DISCIPLINE_ERROR = 1917;

        /// RPC_X_PIPE_CLOSED -> 1916L
        public const int RPC_X_PIPE_CLOSED = 1916;

        /// RPC_X_PIPE_APP_MEMORY -> ERROR_OUTOFMEMORY
        public const int RPC_X_PIPE_APP_MEMORY = NativeConstants.ERROR_OUTOFMEMORY;

        /// RPC_X_NULL_REF_POINTER -> 1780L
        public const int RPC_X_NULL_REF_POINTER = 1780;

        /// RPC_X_NO_MORE_ENTRIES -> 1772L
        public const int RPC_X_NO_MORE_ENTRIES = 1772;

        /// RPC_X_NO_MEMORY -> RPC_S_OUT_OF_MEMORY
        public const int RPC_X_NO_MEMORY = NativeConstants.RPC_S_OUT_OF_MEMORY;

        /// RPC_X_INVALID_TAG -> RPC_S_INVALID_TAG
        public const int RPC_X_INVALID_TAG = NativeConstants.RPC_S_INVALID_TAG;

        /// RPC_X_INVALID_PIPE_OPERATION -> RPC_X_WRONG_PIPE_ORDER
        public const int RPC_X_INVALID_PIPE_OPERATION = NativeConstants.RPC_X_WRONG_PIPE_ORDER;

        /// RPC_X_INVALID_PIPE_OBJECT -> 1830L
        public const int RPC_X_INVALID_PIPE_OBJECT = 1830;

        /// RPC_X_INVALID_ES_ACTION -> 1827L
        public const int RPC_X_INVALID_ES_ACTION = 1827;

        /// RPC_X_INVALID_BUFFER -> ERROR_INVALID_USER_BUFFER
        public const int RPC_X_INVALID_BUFFER = NativeConstants.ERROR_INVALID_USER_BUFFER;

        /// RPC_X_INVALID_BOUND -> RPC_S_INVALID_BOUND
        public const int RPC_X_INVALID_BOUND = NativeConstants.RPC_S_INVALID_BOUND;

        /// RPC_X_ENUM_VALUE_TOO_LARGE -> RPC_X_ENUM_VALUE_OUT_OF_RANGE
        public const int RPC_X_ENUM_VALUE_TOO_LARGE = NativeConstants.RPC_X_ENUM_VALUE_OUT_OF_RANGE;

        /// RPC_X_ENUM_VALUE_OUT_OF_RANGE -> 1781L
        public const int RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781;

        /// RPC_X_BYTE_COUNT_TOO_SMALL -> 1782L
        public const int RPC_X_BYTE_COUNT_TOO_SMALL = 1782;

        /// RPC_X_BAD_STUB_DATA -> 1783L
        public const int RPC_X_BAD_STUB_DATA = 1783;

        /// RPC_VAR_ENTRY -> __cdecl
        /// Error generating expression: Value __cdecl is not resolved
        public const string RPC_VAR_ENTRY = "__cdecl";

        /// RPC_S_ZERO_DIVIDE -> 1767L
        public const int RPC_S_ZERO_DIVIDE = 1767;

        /// RPC_S_WRONG_KIND_OF_BINDING -> 1701L
        public const int RPC_S_WRONG_KIND_OF_BINDING = 1701;

        /// RPC_S_UUID_NO_ADDRESS -> 1739L
        public const int RPC_S_UUID_NO_ADDRESS = 1739;

        /// RPC_S_UUID_LOCAL_ONLY -> 1824L
        public const int RPC_S_UUID_LOCAL_ONLY = 1824;

        /// RPC_S_UNSUPPORTED_TYPE -> 1732L
        public const int RPC_S_UNSUPPORTED_TYPE = 1732;

        /// RPC_S_UNSUPPORTED_TRANS_SYN -> 1730L
        public const int RPC_S_UNSUPPORTED_TRANS_SYN = 1730;

        /// RPC_S_UNSUPPORTED_NAME_SYNTAX -> 1737L
        public const int RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737;

        /// RPC_S_UNSUPPORTED_AUTHN_LEVEL -> 1821L
        public const int RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821;

        /// RPC_S_UNKNOWN_PRINCIPAL -> ERROR_NONE_MAPPED
        public const int RPC_S_UNKNOWN_PRINCIPAL = NativeConstants.ERROR_NONE_MAPPED;

        /// RPC_S_UNKNOWN_MGR_TYPE -> 1716L
        public const int RPC_S_UNKNOWN_MGR_TYPE = 1716;

        /// RPC_S_UNKNOWN_IF -> 1717L
        public const int RPC_S_UNKNOWN_IF = 1717;

        /// RPC_S_UNKNOWN_AUTHZ_SERVICE -> 1750L
        public const int RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750;

        /// RPC_S_UNKNOWN_AUTHN_TYPE -> 1741L
        public const int RPC_S_UNKNOWN_AUTHN_TYPE = 1741;

        /// RPC_S_UNKNOWN_AUTHN_SERVICE -> 1747L
        public const int RPC_S_UNKNOWN_AUTHN_SERVICE = 1747;

        /// RPC_S_UNKNOWN_AUTHN_LEVEL -> 1748L
        public const int RPC_S_UNKNOWN_AUTHN_LEVEL = 1748;

        /// RPC_S_TYPE_ALREADY_REGISTERED -> 1712L
        public const int RPC_S_TYPE_ALREADY_REGISTERED = 1712;

        /// RPC_S_TIMEOUT -> ERROR_TIMEOUT
        public const int RPC_S_TIMEOUT = NativeConstants.ERROR_TIMEOUT;

        /// RPC_S_STRING_TOO_LONG -> 1743L
        public const int RPC_S_STRING_TOO_LONG = 1743;

        /// RPC_S_SERVER_UNAVAILABLE -> 1722L
        public const int RPC_S_SERVER_UNAVAILABLE = 1722;

        /// RPC_S_SERVER_TOO_BUSY -> 1723L
        public const int RPC_S_SERVER_TOO_BUSY = 1723;

        /// RPC_S_SERVER_OUT_OF_MEMORY -> ERROR_NOT_ENOUGH_SERVER_MEMORY
        public const int RPC_S_SERVER_OUT_OF_MEMORY = NativeConstants.ERROR_NOT_ENOUGH_SERVER_MEMORY;

        /// RPC_S_SEND_INCOMPLETE -> 1913L
        public const int RPC_S_SEND_INCOMPLETE = 1913;

        /// RPC_S_SEC_PKG_ERROR -> 1825L
        public const int RPC_S_SEC_PKG_ERROR = 1825;

        /// RPC_S_PROTSEQ_NOT_SUPPORTED -> 1703L
        public const int RPC_S_PROTSEQ_NOT_SUPPORTED = 1703;

        /// RPC_S_PROTSEQ_NOT_FOUND -> 1744L
        public const int RPC_S_PROTSEQ_NOT_FOUND = 1744;

        /// RPC_S_PROTOCOL_ERROR -> 1728L
        public const int RPC_S_PROTOCOL_ERROR = 1728;

        /// RPC_S_PROFILE_NOT_ADDED -> 1925L
        public const int RPC_S_PROFILE_NOT_ADDED = 1925;

        /// RPC_S_PROCNUM_OUT_OF_RANGE -> 1745L
        public const int RPC_S_PROCNUM_OUT_OF_RANGE = 1745;

        /// RPC_S_PRF_ELT_NOT_REMOVED -> 1927L
        public const int RPC_S_PRF_ELT_NOT_REMOVED = 1927;

        /// RPC_S_PRF_ELT_NOT_ADDED -> 1926L
        public const int RPC_S_PRF_ELT_NOT_ADDED = 1926;

        /// RPC_S_OUT_OF_THREADS -> ERROR_MAX_THRDS_REACHED
        public const int RPC_S_OUT_OF_THREADS = NativeConstants.ERROR_MAX_THRDS_REACHED;

        /// RPC_S_OUT_OF_RESOURCES -> 1721L
        public const int RPC_S_OUT_OF_RESOURCES = 1721;

        /// RPC_S_OUT_OF_MEMORY -> ERROR_OUTOFMEMORY
        public const int RPC_S_OUT_OF_MEMORY = NativeConstants.ERROR_OUTOFMEMORY;

        /// RPC_S_OK -> ERROR_SUCCESS
        public const int RPC_S_OK = NativeConstants.ERROR_SUCCESS;

        /// RPC_S_OBJECT_NOT_FOUND -> 1710L
        public const int RPC_S_OBJECT_NOT_FOUND = 1710;

        /// RPC_S_NO_PROTSEQS_REGISTERED -> 1714L
        public const int RPC_S_NO_PROTSEQS_REGISTERED = 1714;

        /// RPC_S_NO_PROTSEQS -> 1719L
        public const int RPC_S_NO_PROTSEQS = 1719;

        /// RPC_S_NO_PRINC_NAME -> 1822L
        public const int RPC_S_NO_PRINC_NAME = 1822;

        /// RPC_S_NO_MORE_MEMBERS -> 1757L
        public const int RPC_S_NO_MORE_MEMBERS = 1757;

        /// RPC_S_NO_MORE_BINDINGS -> 1806L
        public const int RPC_S_NO_MORE_BINDINGS = 1806;

        /// RPC_S_NO_INTERFACES -> 1817L
        public const int RPC_S_NO_INTERFACES = 1817;

        /// RPC_S_NO_ENTRY_NAME -> 1735L
        public const int RPC_S_NO_ENTRY_NAME = 1735;

        /// RPC_S_NO_ENDPOINT_FOUND -> 1708L
        public const int RPC_S_NO_ENDPOINT_FOUND = 1708;

        /// RPC_S_NO_CONTEXT_AVAILABLE -> 1765L
        public const int RPC_S_NO_CONTEXT_AVAILABLE = 1765;

        /// RPC_S_NO_CALL_ACTIVE -> 1725L
        public const int RPC_S_NO_CALL_ACTIVE = 1725;

        /// RPC_S_NO_BINDINGS -> 1718L
        public const int RPC_S_NO_BINDINGS = 1718;

        /// RPC_S_NOT_RPC_ERROR -> 1823L
        public const int RPC_S_NOT_RPC_ERROR = 1823;

        /// RPC_S_NOT_LISTENING -> 1715L
        public const int RPC_S_NOT_LISTENING = 1715;

        /// RPC_S_NOT_CANCELLED -> 1826L
        public const int RPC_S_NOT_CANCELLED = 1826;

        /// RPC_S_NOT_ALL_OBJS_UNEXPORTED -> 1758L
        public const int RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758;

        /// RPC_S_NOT_ALL_OBJS_EXPORTED -> 1923L
        public const int RPC_S_NOT_ALL_OBJS_EXPORTED = 1923;

        /// RPC_S_NOTHING_TO_EXPORT -> 1754L
        public const int RPC_S_NOTHING_TO_EXPORT = 1754;

        /// RPC_S_NAME_SERVICE_UNAVAILABLE -> 1762L
        public const int RPC_S_NAME_SERVICE_UNAVAILABLE = 1762;

        /// RPC_S_MAX_CALLS_TOO_SMALL -> 1742L
        public const int RPC_S_MAX_CALLS_TOO_SMALL = 1742;

        /// RPC_S_INVALID_VERS_OPTION -> 1756L
        public const int RPC_S_INVALID_VERS_OPTION = 1756;

        /// RPC_S_INVALID_TIMEOUT -> 1709L
        public const int RPC_S_INVALID_TIMEOUT = 1709;

        /// RPC_S_INVALID_TAG -> 1733L
        public const int RPC_S_INVALID_TAG = 1733;

        /// RPC_S_INVALID_STRING_UUID -> 1705L
        public const int RPC_S_INVALID_STRING_UUID = 1705;

        /// RPC_S_INVALID_STRING_BINDING -> 1700L
        public const int RPC_S_INVALID_STRING_BINDING = 1700;

        /// RPC_S_INVALID_SECURITY_DESC -> ERROR_INVALID_SECURITY_DESCR
        public const int RPC_S_INVALID_SECURITY_DESC = NativeConstants.ERROR_INVALID_SECURITY_DESCR;

        /// RPC_S_INVALID_RPC_PROTSEQ -> 1704L
        public const int RPC_S_INVALID_RPC_PROTSEQ = 1704;

        /// RPC_S_INVALID_OBJECT -> 1900L
        public const int RPC_S_INVALID_OBJECT = 1900;

        /// RPC_S_INVALID_NET_ADDR -> 1707L
        public const int RPC_S_INVALID_NET_ADDR = 1707;

        /// RPC_S_INVALID_NETWORK_OPTIONS -> 1724L
        public const int RPC_S_INVALID_NETWORK_OPTIONS = 1724;

        /// RPC_S_INVALID_NAME_SYNTAX -> 1736L
        public const int RPC_S_INVALID_NAME_SYNTAX = 1736;

        /// RPC_S_INVALID_NAF_ID -> 1763L
        public const int RPC_S_INVALID_NAF_ID = 1763;

        /// RPC_S_INVALID_LEVEL -> ERROR_INVALID_PARAMETER
        public const int RPC_S_INVALID_LEVEL = NativeConstants.ERROR_INVALID_PARAMETER;

        /// RPC_S_INVALID_ENDPOINT_FORMAT -> 1706L
        public const int RPC_S_INVALID_ENDPOINT_FORMAT = 1706;

        /// RPC_S_INVALID_BOUND -> 1734L
        public const int RPC_S_INVALID_BOUND = 1734;

        /// RPC_S_INVALID_BINDING -> 1702L
        public const int RPC_S_INVALID_BINDING = 1702;

        /// RPC_S_INVALID_AUTH_IDENTITY -> 1749L
        public const int RPC_S_INVALID_AUTH_IDENTITY = 1749;

        /// RPC_S_INVALID_ASYNC_HANDLE -> 1914L
        public const int RPC_S_INVALID_ASYNC_HANDLE = 1914;

        /// RPC_S_INVALID_ASYNC_CALL -> 1915L
        public const int RPC_S_INVALID_ASYNC_CALL = 1915;

        /// RPC_S_INVALID_ARG -> ERROR_INVALID_PARAMETER
        public const int RPC_S_INVALID_ARG = NativeConstants.ERROR_INVALID_PARAMETER;

        /// RPC_S_INTERNAL_ERROR -> 1766L
        public const int RPC_S_INTERNAL_ERROR = 1766;

        /// RPC_S_INTERFACE_NOT_FOUND -> 1759L
        public const int RPC_S_INTERFACE_NOT_FOUND = 1759;

        /// RPC_S_INTERFACE_NOT_EXPORTED -> 1924L
        public const int RPC_S_INTERFACE_NOT_EXPORTED = 1924;

        /// RPC_S_INCOMPLETE_NAME -> 1755L
        public const int RPC_S_INCOMPLETE_NAME = 1755;

        /// RPC_S_GRP_ELT_NOT_REMOVED -> 1929L
        public const int RPC_S_GRP_ELT_NOT_REMOVED = 1929;

        /// RPC_S_GRP_ELT_NOT_ADDED -> 1928L
        public const int RPC_S_GRP_ELT_NOT_ADDED = 1928;

        /// RPC_S_GROUP_MEMBER_NOT_FOUND -> 1898L
        public const int RPC_S_GROUP_MEMBER_NOT_FOUND = 1898;

        /// RPC_S_FP_UNDERFLOW -> 1770L
        public const int RPC_S_FP_UNDERFLOW = 1770;

        /// RPC_S_FP_OVERFLOW -> 1771L
        public const int RPC_S_FP_OVERFLOW = 1771;

        /// RPC_S_FP_DIV_ZERO -> 1769L
        public const int RPC_S_FP_DIV_ZERO = 1769;

        /// RPC_S_ENTRY_TYPE_MISMATCH -> 1922L
        public const int RPC_S_ENTRY_TYPE_MISMATCH = 1922;

        /// RPC_S_ENTRY_NOT_FOUND -> 1761L
        public const int RPC_S_ENTRY_NOT_FOUND = 1761;

        /// RPC_S_ENTRY_ALREADY_EXISTS -> 1760L
        public const int RPC_S_ENTRY_ALREADY_EXISTS = 1760;

        /// RPC_S_DUPLICATE_ENDPOINT -> 1740L
        public const int RPC_S_DUPLICATE_ENDPOINT = 1740;

        /// RPC_S_COMM_FAILURE -> 1820L
        public const int RPC_S_COMM_FAILURE = 1820;

        /// RPC_S_CANT_CREATE_ENDPOINT -> 1720L
        public const int RPC_S_CANT_CREATE_ENDPOINT = 1720;

        /// RPC_S_CANNOT_SUPPORT -> 1764L
        public const int RPC_S_CANNOT_SUPPORT = 1764;

        /// RPC_S_CALL_IN_PROGRESS -> 1791L
        public const int RPC_S_CALL_IN_PROGRESS = 1791;

        /// RPC_S_CALL_FAILED_DNE -> 1727L
        public const int RPC_S_CALL_FAILED_DNE = 1727;

        /// RPC_S_CALL_FAILED -> 1726L
        public const int RPC_S_CALL_FAILED = 1726;

        /// RPC_S_CALL_CANCELLED -> 1818L
        public const int RPC_S_CALL_CANCELLED = 1818;

        /// RPC_S_BUFFER_TOO_SMALL -> ERROR_INSUFFICIENT_BUFFER
        public const int RPC_S_BUFFER_TOO_SMALL = NativeConstants.ERROR_INSUFFICIENT_BUFFER;

        /// RPC_S_BINDING_INCOMPLETE -> 1819L
        public const int RPC_S_BINDING_INCOMPLETE = 1819;

        /// RPC_S_BINDING_HAS_NO_AUTH -> 1746L
        public const int RPC_S_BINDING_HAS_NO_AUTH = 1746;

        /// RPC_S_ASYNC_CALL_PENDING -> ERROR_IO_PENDING
        public const int RPC_S_ASYNC_CALL_PENDING = NativeConstants.ERROR_IO_PENDING;

        /// RPC_S_ALREADY_REGISTERED -> 1711L
        public const int RPC_S_ALREADY_REGISTERED = 1711;

        /// RPC_S_ALREADY_LISTENING -> 1713L
        public const int RPC_S_ALREADY_LISTENING = 1713;

        /// RPC_S_ADDRESS_ERROR -> 1768L
        public const int RPC_S_ADDRESS_ERROR = 1768;

        /// RPC_S_ACCESS_DENIED -> ERROR_ACCESS_DENIED
        public const int RPC_S_ACCESS_DENIED = NativeConstants.ERROR_ACCESS_DENIED;

        /// RPC_SECURITY_QOS_V3 -> RPC_SECURITY_QOS_V3_W
        /// Error generating expression: Value RPC_SECURITY_QOS_V3_W is not resolved
        public const string RPC_SECURITY_QOS_V3 = "RPC_SECURITY_QOS_V3_W";

        /// RPC_SECURITY_QOS_V2 -> RPC_SECURITY_QOS_V2_W
        /// Error generating expression: Value RPC_SECURITY_QOS_V2_W is not resolved
        public const string RPC_SECURITY_QOS_V2 = "RPC_SECURITY_QOS_V2_W";

        /// RPC_QUERY_SERVER_PRINCIPAL_NAME -> (2)
        public const int RPC_QUERY_SERVER_PRINCIPAL_NAME = 2;

        /// RPC_QUERY_CLIENT_PRINCIPAL_NAME -> (4)
        public const int RPC_QUERY_CLIENT_PRINCIPAL_NAME = 4;

        /// RPC_P_ADDR_FORMAT_TCP_IPV6 -> 2
        public const int RPC_P_ADDR_FORMAT_TCP_IPV6 = 2;

        /// RPC_P_ADDR_FORMAT_TCP_IPV4 -> 1
        public const int RPC_P_ADDR_FORMAT_TCP_IPV4 = 1;

        /// RPC_PROXY_CONNECTION_TYPE_OUT_PROXY -> 1
        public const int RPC_PROXY_CONNECTION_TYPE_OUT_PROXY = 1;

        /// RPC_PROXY_CONNECTION_TYPE_IN_PROXY -> 0
        public const int RPC_PROXY_CONNECTION_TYPE_IN_PROXY = 0;

        /// RPC_PROTSEQ_VECTOR -> RPC_PROTSEQ_VECTORW
        /// Error generating expression: Value RPC_PROTSEQ_VECTORW is not resolved
        public const string RPC_PROTSEQ_VECTOR = "RPC_PROTSEQ_VECTORW";

        /// RPC_NCA_FLAGS_MAYBE -> 0x00000004
        public const int RPC_NCA_FLAGS_MAYBE = 4;

        /// RPC_NCA_FLAGS_IDEMPOTENT -> 0x00000001
        public const int RPC_NCA_FLAGS_IDEMPOTENT = 1;

        /// RPC_NCA_FLAGS_DEFAULT -> 0x00000000
        public const int RPC_NCA_FLAGS_DEFAULT = 0;

        /// RPC_NCA_FLAGS_BROADCAST -> 0x00000002
        public const int RPC_NCA_FLAGS_BROADCAST = 2;

        /// RPC_MGR_EPV -> void
        /// Error generating expression: Value void is not resolved
        public const string RPC_MGR_EPV = "void";

        /// RPC_INTERFACE_HAS_PIPES -> 0x0001
        public const int RPC_INTERFACE_HAS_PIPES = 1;

        /// RPC_IF_SEC_NO_CACHE -> 0x0040
        public const int RPC_IF_SEC_NO_CACHE = 64;

        /// RPC_IF_OLE -> 0x0002
        public const int RPC_IF_OLE = 2;

        /// RPC_IF_AUTOLISTEN -> 0x0001
        public const int RPC_IF_AUTOLISTEN = 1;

        /// RPC_IF_ALLOW_UNKNOWN_AUTHORITY -> 0x0004
        public const int RPC_IF_ALLOW_UNKNOWN_AUTHORITY = 4;

        /// RPC_IF_ALLOW_SECURE_ONLY -> 0x0008
        public const int RPC_IF_ALLOW_SECURE_ONLY = 8;

        /// RPC_IF_ALLOW_LOCAL_ONLY -> 0x0020
        public const int RPC_IF_ALLOW_LOCAL_ONLY = 32;

        /// RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH -> 0x0010
        public const int RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH = 16;

        /// RPC_HTTP_TRANSPORT_CREDENTIALS -> RPC_HTTP_TRANSPORT_CREDENTIALS_W
        /// Error generating expression: Value RPC_HTTP_TRANSPORT_CREDENTIALS_W is not resolved
        public const string RPC_HTTP_TRANSPORT_CREDENTIALS = "RPC_HTTP_TRANSPORT_CREDENTIALS_W";

        /// RPC_FLAGS_VALID_BIT -> 0x00008000
        public const int RPC_FLAGS_VALID_BIT = 32768;

        /// RPC_ENTRY -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string RPC_ENTRY = "__stdcall";

        /// RPC_EEINFO_VERSION -> 1
        public const int RPC_EEINFO_VERSION = 1;

        /// RPC_C_VERS_UPTO -> 5
        public const int RPC_C_VERS_UPTO = 5;

        /// RPC_C_VERS_MAJOR_ONLY -> 4
        public const int RPC_C_VERS_MAJOR_ONLY = 4;

        /// RPC_C_VERS_EXACT -> 3
        public const int RPC_C_VERS_EXACT = 3;

        /// RPC_C_VERS_COMPATIBLE -> 2
        public const int RPC_C_VERS_COMPATIBLE = 2;

        /// RPC_C_VERS_ALL -> 1
        public const int RPC_C_VERS_ALL = 1;

        /// RPC_C_USE_INTRANET_PORT -> 0x2
        public const int RPC_C_USE_INTRANET_PORT = 2;

        /// RPC_C_USE_INTERNET_PORT -> 0x1
        public const int RPC_C_USE_INTERNET_PORT = 1;

        /// RPC_C_STATS_PKTS_OUT -> 3
        public const int RPC_C_STATS_PKTS_OUT = 3;

        /// RPC_C_STATS_PKTS_IN -> 2
        public const int RPC_C_STATS_PKTS_IN = 2;

        /// RPC_C_STATS_CALLS_OUT -> 1
        public const int RPC_C_STATS_CALLS_OUT = 1;

        /// RPC_C_STATS_CALLS_IN -> 0
        public const int RPC_C_STATS_CALLS_IN = 0;

        /// RPC_C_SECURITY_QOS_VERSION_3 -> 3L
        public const int RPC_C_SECURITY_QOS_VERSION_3 = 3;

        /// RPC_C_SECURITY_QOS_VERSION_2 -> 2L
        public const int RPC_C_SECURITY_QOS_VERSION_2 = 2;

        /// RPC_C_SECURITY_QOS_VERSION_1 -> 1L
        public const int RPC_C_SECURITY_QOS_VERSION_1 = 1;

        /// RPC_C_SECURITY_QOS_VERSION -> 1L
        public const int RPC_C_SECURITY_QOS_VERSION = 1;

        /// RPC_C_QOS_IDENTITY_STATIC -> 0
        public const int RPC_C_QOS_IDENTITY_STATIC = 0;

        /// RPC_C_QOS_IDENTITY_DYNAMIC -> 1
        public const int RPC_C_QOS_IDENTITY_DYNAMIC = 1;

        /// RPC_C_QOS_CAPABILITIES_MUTUAL_AUTH -> 0x1
        public const int RPC_C_QOS_CAPABILITIES_MUTUAL_AUTH = 1;

        /// RPC_C_QOS_CAPABILITIES_MAKE_FULLSIC -> 0x2
        public const int RPC_C_QOS_CAPABILITIES_MAKE_FULLSIC = 2;

        /// RPC_C_QOS_CAPABILITIES_LOCAL_MA_HINT -> 0x10
        public const int RPC_C_QOS_CAPABILITIES_LOCAL_MA_HINT = 16;

        /// RPC_C_QOS_CAPABILITIES_IGNORE_DELEGATE_FAILURE -> 0x8
        public const int RPC_C_QOS_CAPABILITIES_IGNORE_DELEGATE_FAILURE = 8;

        /// RPC_C_QOS_CAPABILITIES_DEFAULT -> 0x0
        public const int RPC_C_QOS_CAPABILITIES_DEFAULT = 0;

        /// RPC_C_QOS_CAPABILITIES_ANY_AUTHORITY -> 0x4
        public const int RPC_C_QOS_CAPABILITIES_ANY_AUTHORITY = 4;

        /// RPC_C_PROTSEQ_MAX_REQS_DEFAULT -> 10
        public const int RPC_C_PROTSEQ_MAX_REQS_DEFAULT = 10;

        /// RPC_C_PROTECT_LEVEL_PKT_PRIVACY -> (RPC_C_AUTHN_LEVEL_PKT_PRIVACY)
        public const int RPC_C_PROTECT_LEVEL_PKT_PRIVACY = NativeConstants.RPC_C_AUTHN_LEVEL_PKT_PRIVACY;

        /// RPC_C_PROTECT_LEVEL_PKT_INTEGRITY -> (RPC_C_AUTHN_LEVEL_PKT_INTEGRITY)
        public const int RPC_C_PROTECT_LEVEL_PKT_INTEGRITY = NativeConstants.RPC_C_AUTHN_LEVEL_PKT_INTEGRITY;

        /// RPC_C_PROTECT_LEVEL_PKT -> (RPC_C_AUTHN_LEVEL_PKT)
        public const int RPC_C_PROTECT_LEVEL_PKT = NativeConstants.RPC_C_AUTHN_LEVEL_PKT;

        /// RPC_C_PROTECT_LEVEL_NONE -> (RPC_C_AUTHN_LEVEL_NONE)
        public const int RPC_C_PROTECT_LEVEL_NONE = NativeConstants.RPC_C_AUTHN_LEVEL_NONE;

        /// RPC_C_PROTECT_LEVEL_DEFAULT -> (RPC_C_AUTHN_LEVEL_DEFAULT)
        public const int RPC_C_PROTECT_LEVEL_DEFAULT = NativeConstants.RPC_C_AUTHN_LEVEL_DEFAULT;

        /// RPC_C_PROTECT_LEVEL_CONNECT -> (RPC_C_AUTHN_LEVEL_CONNECT)
        public const int RPC_C_PROTECT_LEVEL_CONNECT = NativeConstants.RPC_C_AUTHN_LEVEL_CONNECT;

        /// RPC_C_PROTECT_LEVEL_CALL -> (RPC_C_AUTHN_LEVEL_CALL)
        public const int RPC_C_PROTECT_LEVEL_CALL = NativeConstants.RPC_C_AUTHN_LEVEL_CALL;

        /// RPC_C_PROFILE_MATCH_BY_MBR -> 3
        public const int RPC_C_PROFILE_MATCH_BY_MBR = 3;

        /// RPC_C_PROFILE_MATCH_BY_IF -> 2
        public const int RPC_C_PROFILE_MATCH_BY_IF = 2;

        /// RPC_C_PROFILE_MATCH_BY_BOTH -> 4
        public const int RPC_C_PROFILE_MATCH_BY_BOTH = 4;

        /// RPC_C_PROFILE_DEFAULT_ELT -> 0
        public const int RPC_C_PROFILE_DEFAULT_ELT = 0;

        /// RPC_C_PROFILE_ALL_ELTS -> RPC_C_PROFILE_ALL_ELT
        public const int RPC_C_PROFILE_ALL_ELTS = NativeConstants.RPC_C_PROFILE_ALL_ELT;

        /// RPC_C_PROFILE_ALL_ELT -> 1
        public const int RPC_C_PROFILE_ALL_ELT = 1;

        /// RPC_C_PARM_MAX_PACKET_LENGTH -> 1
        public const int RPC_C_PARM_MAX_PACKET_LENGTH = 1;

        /// RPC_C_PARM_BUFFER_LENGTH -> 2
        public const int RPC_C_PARM_BUFFER_LENGTH = 2;

        /// RPC_C_OPT_UNIQUE_BINDING -> 11
        public const int RPC_C_OPT_UNIQUE_BINDING = 11;

        /// RPC_C_OPT_SECURITY_CALLBACK -> 10
        public const int RPC_C_OPT_SECURITY_CALLBACK = 10;

        /// RPC_C_OPT_MQ_TIME_TO_REACH_QUEUE -> 7
        public const int RPC_C_OPT_MQ_TIME_TO_REACH_QUEUE = 7;

        /// RPC_C_OPT_MQ_TIME_TO_BE_RECEIVED -> 8
        public const int RPC_C_OPT_MQ_TIME_TO_BE_RECEIVED = 8;

        /// RPC_C_OPT_MQ_PRIORITY -> 2
        public const int RPC_C_OPT_MQ_PRIORITY = 2;

        /// RPC_C_OPT_MQ_JOURNAL -> 3
        public const int RPC_C_OPT_MQ_JOURNAL = 3;

        /// RPC_C_OPT_MQ_DELIVERY -> 1
        public const int RPC_C_OPT_MQ_DELIVERY = 1;

        /// RPC_C_OPT_MQ_AUTHN_SERVICE -> 5
        public const int RPC_C_OPT_MQ_AUTHN_SERVICE = 5;

        /// RPC_C_OPT_MQ_AUTHN_LEVEL -> 6
        public const int RPC_C_OPT_MQ_AUTHN_LEVEL = 6;

        /// RPC_C_OPT_MQ_ACKNOWLEDGE -> 4
        public const int RPC_C_OPT_MQ_ACKNOWLEDGE = 4;

        /// RPC_C_OPT_MAX_OPTIONS -> 14
        public const int RPC_C_OPT_MAX_OPTIONS = 14;

        /// RPC_C_OPT_DONT_LINGER -> 13
        public const int RPC_C_OPT_DONT_LINGER = 13;

        /// RPC_C_OPT_CALL_TIMEOUT -> 12
        public const int RPC_C_OPT_CALL_TIMEOUT = 12;

        /// RPC_C_OPT_BINDING_NONCAUSAL -> 9
        public const int RPC_C_OPT_BINDING_NONCAUSAL = 9;

        /// RPC_C_NS_SYNTAX_DEFAULT -> 0
        public const int RPC_C_NS_SYNTAX_DEFAULT = 0;

        /// RPC_C_NS_SYNTAX_DCE -> 3
        public const int RPC_C_NS_SYNTAX_DCE = 3;

        /// RPC_C_NS_DEFAULT_EXP_AGE -> -1
        public const int RPC_C_NS_DEFAULT_EXP_AGE = -1;

        /// RPC_C_NOTIFY_ON_SEND_COMPLETE -> 0x1
        public const int RPC_C_NOTIFY_ON_SEND_COMPLETE = 1;

        /// RPC_C_MQ_USE_EXISTING_SECURITY -> 0x0004
        public const int RPC_C_MQ_USE_EXISTING_SECURITY = 4;

        /// RPC_C_MQ_TEMPORARY -> 0x0000
        public const int RPC_C_MQ_TEMPORARY = 0;

        /// RPC_C_MQ_RECOVERABLE -> 1
        public const int RPC_C_MQ_RECOVERABLE = 1;

        /// RPC_C_MQ_PERMANENT -> 0x0001
        public const int RPC_C_MQ_PERMANENT = 1;

        /// RPC_C_MQ_JOURNAL_NONE -> 0
        public const int RPC_C_MQ_JOURNAL_NONE = 0;

        /// RPC_C_MQ_JOURNAL_DEADLETTER -> 1
        public const int RPC_C_MQ_JOURNAL_DEADLETTER = 1;

        /// RPC_C_MQ_JOURNAL_ALWAYS -> 2
        public const int RPC_C_MQ_JOURNAL_ALWAYS = 2;

        /// RPC_C_MQ_EXPRESS -> 0
        public const int RPC_C_MQ_EXPRESS = 0;

        /// RPC_C_MQ_CLEAR_ON_OPEN -> 0x0002
        public const int RPC_C_MQ_CLEAR_ON_OPEN = 2;

        /// RPC_C_MQ_AUTHN_LEVEL_PKT_PRIVACY -> 0x0010
        public const int RPC_C_MQ_AUTHN_LEVEL_PKT_PRIVACY = 16;

        /// RPC_C_MQ_AUTHN_LEVEL_PKT_INTEGRITY -> 0x0008
        public const int RPC_C_MQ_AUTHN_LEVEL_PKT_INTEGRITY = 8;

        /// RPC_C_MQ_AUTHN_LEVEL_NONE -> 0x0000
        public const int RPC_C_MQ_AUTHN_LEVEL_NONE = 0;

        /// RPC_C_MGMT_STOP_SERVER_LISTEN -> 4
        public const int RPC_C_MGMT_STOP_SERVER_LISTEN = 4;

        /// RPC_C_MGMT_IS_SERVER_LISTEN -> 3
        public const int RPC_C_MGMT_IS_SERVER_LISTEN = 3;

        /// RPC_C_MGMT_INQ_STATS -> 2
        public const int RPC_C_MGMT_INQ_STATS = 2;

        /// RPC_C_MGMT_INQ_PRINC_NAME -> 1
        public const int RPC_C_MGMT_INQ_PRINC_NAME = 1;

        /// RPC_C_MGMT_INQ_IF_IDS -> 0
        public const int RPC_C_MGMT_INQ_IF_IDS = 0;

        /// RPC_C_LISTEN_MAX_CALLS_DEFAULT -> 1234
        public const int RPC_C_LISTEN_MAX_CALLS_DEFAULT = 1234;

        /// RPC_C_INFINITE_TIMEOUT -> INFINITE
        public const int RPC_C_INFINITE_TIMEOUT = NativeConstants.INFINITE;

        /// RPC_C_IMP_LEVEL_IMPERSONATE -> 3
        public const int RPC_C_IMP_LEVEL_IMPERSONATE = 3;

        /// RPC_C_IMP_LEVEL_IDENTIFY -> 2
        public const int RPC_C_IMP_LEVEL_IDENTIFY = 2;

        /// RPC_C_IMP_LEVEL_DELEGATE -> 4
        public const int RPC_C_IMP_LEVEL_DELEGATE = 4;

        /// RPC_C_IMP_LEVEL_DEFAULT -> 0
        public const int RPC_C_IMP_LEVEL_DEFAULT = 0;

        /// RPC_C_IMP_LEVEL_ANONYMOUS -> 1
        public const int RPC_C_IMP_LEVEL_ANONYMOUS = 1;

        /// RPC_C_HTTP_FLAG_USE_SSL -> 1
        public const int RPC_C_HTTP_FLAG_USE_SSL = 1;

        /// RPC_C_HTTP_FLAG_USE_FIRST_AUTH_SCHEME -> 2
        public const int RPC_C_HTTP_FLAG_USE_FIRST_AUTH_SCHEME = 2;

        /// RPC_C_HTTP_FLAG_IGNORE_CERT_CN_INVALID -> 8
        public const int RPC_C_HTTP_FLAG_IGNORE_CERT_CN_INVALID = 8;

        /// RPC_C_HTTP_AUTHN_TARGET_SERVER -> 1
        public const int RPC_C_HTTP_AUTHN_TARGET_SERVER = 1;

        /// RPC_C_HTTP_AUTHN_TARGET_PROXY -> 2
        public const int RPC_C_HTTP_AUTHN_TARGET_PROXY = 2;

        /// RPC_C_HTTP_AUTHN_SCHEME_PASSPORT -> 0x00000004
        public const int RPC_C_HTTP_AUTHN_SCHEME_PASSPORT = 4;

        /// RPC_C_HTTP_AUTHN_SCHEME_NTLM -> 0x00000002
        public const int RPC_C_HTTP_AUTHN_SCHEME_NTLM = 2;

        /// RPC_C_HTTP_AUTHN_SCHEME_NEGOTIATE -> 0x00000010
        public const int RPC_C_HTTP_AUTHN_SCHEME_NEGOTIATE = 16;

        /// RPC_C_HTTP_AUTHN_SCHEME_DIGEST -> 0x00000008
        public const int RPC_C_HTTP_AUTHN_SCHEME_DIGEST = 8;

        /// RPC_C_HTTP_AUTHN_SCHEME_CERT -> 0x00010000
        public const int RPC_C_HTTP_AUTHN_SCHEME_CERT = 65536;

        /// RPC_C_HTTP_AUTHN_SCHEME_BASIC -> 0x00000001
        public const int RPC_C_HTTP_AUTHN_SCHEME_BASIC = 1;

        /// RPC_C_FULL_CERT_CHAIN -> 0x0001
        public const int RPC_C_FULL_CERT_CHAIN = 1;

        /// RPC_C_EP_MATCH_BY_OBJ -> 2
        public const int RPC_C_EP_MATCH_BY_OBJ = 2;

        /// RPC_C_EP_MATCH_BY_IF -> 1
        public const int RPC_C_EP_MATCH_BY_IF = 1;

        /// RPC_C_EP_MATCH_BY_BOTH -> 3
        public const int RPC_C_EP_MATCH_BY_BOTH = 3;

        /// RPC_C_EP_ALL_ELTS -> 0
        public const int RPC_C_EP_ALL_ELTS = 0;

        /// RPC_C_DONT_FAIL -> 0x4
        public const int RPC_C_DONT_FAIL = 4;

        /// RPC_C_CANCEL_INFINITE_TIMEOUT -> -1
        public const int RPC_C_CANCEL_INFINITE_TIMEOUT = -1;

        /// RPC_C_BIND_TO_ALL_NICS -> 1
        public const int RPC_C_BIND_TO_ALL_NICS = 1;

        /// RPC_C_BINDING_MIN_TIMEOUT -> 0
        public const int RPC_C_BINDING_MIN_TIMEOUT = 0;

        /// RPC_C_BINDING_MAX_TIMEOUT -> 9
        public const int RPC_C_BINDING_MAX_TIMEOUT = 9;

        /// RPC_C_BINDING_INFINITE_TIMEOUT -> 10
        public const int RPC_C_BINDING_INFINITE_TIMEOUT = 10;

        /// RPC_C_BINDING_DEFAULT_TIMEOUT -> 5
        public const int RPC_C_BINDING_DEFAULT_TIMEOUT = 5;

        /// RPC_C_AUTHZ_NONE -> 0
        public const int RPC_C_AUTHZ_NONE = 0;

        /// RPC_C_AUTHZ_NAME -> 1
        public const int RPC_C_AUTHZ_NAME = 1;

        /// RPC_C_AUTHZ_DEFAULT -> 0xffffffff
        public const int RPC_C_AUTHZ_DEFAULT = -1;

        /// RPC_C_AUTHZ_DCE -> 2
        public const int RPC_C_AUTHZ_DCE = 2;

        /// RPC_C_AUTHN_WINNT -> 10
        public const int RPC_C_AUTHN_WINNT = 10;

        /// RPC_C_AUTHN_NONE -> 0
        public const int RPC_C_AUTHN_NONE = 0;

        /// RPC_C_AUTHN_MSN -> 18
        public const int RPC_C_AUTHN_MSN = 18;

        /// RPC_C_AUTHN_MQ -> 100
        public const int RPC_C_AUTHN_MQ = 100;

        /// RPC_C_AUTHN_LEVEL_PKT_PRIVACY -> 6
        public const int RPC_C_AUTHN_LEVEL_PKT_PRIVACY = 6;

        /// RPC_C_AUTHN_LEVEL_PKT_INTEGRITY -> 5
        public const int RPC_C_AUTHN_LEVEL_PKT_INTEGRITY = 5;

        /// RPC_C_AUTHN_LEVEL_PKT -> 4
        public const int RPC_C_AUTHN_LEVEL_PKT = 4;

        /// RPC_C_AUTHN_LEVEL_NONE -> 1
        public const int RPC_C_AUTHN_LEVEL_NONE = 1;

        /// RPC_C_AUTHN_LEVEL_DEFAULT -> 0
        public const int RPC_C_AUTHN_LEVEL_DEFAULT = 0;

        /// RPC_C_AUTHN_LEVEL_CONNECT -> 2
        public const int RPC_C_AUTHN_LEVEL_CONNECT = 2;

        /// RPC_C_AUTHN_LEVEL_CALL -> 3
        public const int RPC_C_AUTHN_LEVEL_CALL = 3;

        /// RPC_C_AUTHN_INFO_TYPE_HTTP -> 1
        public const int RPC_C_AUTHN_INFO_TYPE_HTTP = 1;

        /// RPC_C_AUTHN_GSS_SCHANNEL -> 14
        public const int RPC_C_AUTHN_GSS_SCHANNEL = 14;

        /// RPC_C_AUTHN_GSS_NEGOTIATE -> 9
        public const int RPC_C_AUTHN_GSS_NEGOTIATE = 9;

        /// RPC_C_AUTHN_GSS_KERBEROS -> 16
        public const int RPC_C_AUTHN_GSS_KERBEROS = 16;

        /// RPC_C_AUTHN_DPA -> 17
        public const int RPC_C_AUTHN_DPA = 17;

        /// RPC_C_AUTHN_DIGEST -> 21
        public const int RPC_C_AUTHN_DIGEST = 21;

        /// RPC_C_AUTHN_DEFAULT -> 0xFFFFFFFFL
        public const int RPC_C_AUTHN_DEFAULT = -1;

        /// RPC_C_AUTHN_DEC_PUBLIC -> 4
        public const int RPC_C_AUTHN_DEC_PUBLIC = 4;

        /// RPC_C_AUTHN_DCE_PUBLIC -> 2
        public const int RPC_C_AUTHN_DCE_PUBLIC = 2;

        /// RPC_C_AUTHN_DCE_PRIVATE -> 1
        public const int RPC_C_AUTHN_DCE_PRIVATE = 1;

        /// RPC_CONTEXT_HANDLE_SERIALIZE -> 0x10000000UL
        public const uint RPC_CONTEXT_HANDLE_SERIALIZE = 268435456u;

        /// RPC_CONTEXT_HANDLE_FLAGS -> 0x30000000UL
        public const uint RPC_CONTEXT_HANDLE_FLAGS = 805306368u;

        /// RPC_CONTEXT_HANDLE_DONT_SERIALIZE -> 0x20000000UL
        public const uint RPC_CONTEXT_HANDLE_DONT_SERIALIZE = 536870912u;

        /// RPC_CONTEXT_HANDLE_DEFAULT_FLAGS -> 0x00000000UL
        public const uint RPC_CONTEXT_HANDLE_DEFAULT_FLAGS = 0u;

        /// RPC_CALL_ATTRIBUTES_VERSION -> (1)
        public const int RPC_CALL_ATTRIBUTES_VERSION = 1;

        /// RPC_CALL_ATTRIBUTES_V1 -> RPC_CALL_ATTRIBUTES_V1_W
        /// Error generating expression: Value RPC_CALL_ATTRIBUTES_V1_W is not resolved
        public const string RPC_CALL_ATTRIBUTES_V1 = "RPC_CALL_ATTRIBUTES_V1_W";

        /// RPC_BUFFER_PARTIAL -> 0x00002000
        public const int RPC_BUFFER_PARTIAL = 8192;

        /// RPC_BUFFER_NONOTIFY -> 0x00010000
        public const int RPC_BUFFER_NONOTIFY = 65536;

        /// RPC_BUFFER_EXTRA -> 0x00004000
        public const int RPC_BUFFER_EXTRA = 16384;

        /// RPC_BUFFER_COMPLETE -> 0x00001000
        public const int RPC_BUFFER_COMPLETE = 4096;

        /// RPC_BUFFER_ASYNC -> 0x00008000
        public const int RPC_BUFFER_ASYNC = 32768;

        /// rpc_binding_vector_t -> RPC_BINDING_VECTOR
        /// Error generating expression: Value RPC_BINDING_VECTOR is not resolved
        public const string rpc_binding_vector_t = "RPC_BINDING_VECTOR";

        /// rpc_binding_handle_t -> RPC_BINDING_HANDLE
        /// Error generating expression: Value RPC_BINDING_HANDLE is not resolved
        public const string rpc_binding_handle_t = "RPC_BINDING_HANDLE";

        /// RpcStringFree -> RpcStringFreeW
        /// Error generating expression: Value RpcStringFreeW is not resolved
        public const string RpcStringFree = "RpcStringFreeW";

        /// RpcStringBindingParse -> RpcStringBindingParseW
        /// Error generating expression: Value RpcStringBindingParseW is not resolved
        public const string RpcStringBindingParse = "RpcStringBindingParseW";

        /// RpcStringBindingCompose -> RpcStringBindingComposeW
        /// Error generating expression: Value RpcStringBindingComposeW is not resolved
        public const string RpcStringBindingCompose = "RpcStringBindingComposeW";

        /// RpcServerUseProtseqIfEx -> RpcServerUseProtseqIfExW
        /// Error generating expression: Value RpcServerUseProtseqIfExW is not resolved
        public const string RpcServerUseProtseqIfEx = "RpcServerUseProtseqIfExW";

        /// RpcServerUseProtseqIf -> RpcServerUseProtseqIfW
        /// Error generating expression: Value RpcServerUseProtseqIfW is not resolved
        public const string RpcServerUseProtseqIf = "RpcServerUseProtseqIfW";

        /// RpcServerUseProtseqEx -> RpcServerUseProtseqExW
        /// Error generating expression: Value RpcServerUseProtseqExW is not resolved
        public const string RpcServerUseProtseqEx = "RpcServerUseProtseqExW";

        /// RpcServerUseProtseqEpEx -> RpcServerUseProtseqEpExW
        /// Error generating expression: Value RpcServerUseProtseqEpExW is not resolved
        public const string RpcServerUseProtseqEpEx = "RpcServerUseProtseqEpExW";

        /// RpcServerUseProtseqEp -> RpcServerUseProtseqEpW
        /// Error generating expression: Value RpcServerUseProtseqEpW is not resolved
        public const string RpcServerUseProtseqEp = "RpcServerUseProtseqEpW";

        /// RpcServerUseProtseq -> RpcServerUseProtseqW
        /// Error generating expression: Value RpcServerUseProtseqW is not resolved
        public const string RpcServerUseProtseq = "RpcServerUseProtseqW";

        /// RpcServerRegisterAuthInfo -> RpcServerRegisterAuthInfoW
        /// Error generating expression: Value RpcServerRegisterAuthInfoW is not resolved
        public const string RpcServerRegisterAuthInfo = "RpcServerRegisterAuthInfoW";

        /// RpcServerInqDefaultPrincName -> RpcServerInqDefaultPrincNameW
        /// Error generating expression: Value RpcServerInqDefaultPrincNameW is not resolved
        public const string RpcServerInqDefaultPrincName = "RpcServerInqDefaultPrincNameW";

        /// RpcServerInqCallAttributes -> RpcServerInqCallAttributesW
        /// Error generating expression: Value RpcServerInqCallAttributesW is not resolved
        public const string RpcServerInqCallAttributes = "RpcServerInqCallAttributesW";

        /// RPCRTAPI -> DECLSPEC_IMPORT
        public const string RPCRTAPI = NativeConstants.DECLSPEC_IMPORT;

        /// RpcProtseqVectorFree -> RpcProtseqVectorFreeW
        /// Error generating expression: Value RpcProtseqVectorFreeW is not resolved
        public const string RpcProtseqVectorFree = "RpcProtseqVectorFreeW";

        /// RpcNsProfileEltRemove -> RpcNsProfileEltRemoveW
        /// Error generating expression: Value RpcNsProfileEltRemoveW is not resolved
        public const string RpcNsProfileEltRemove = "RpcNsProfileEltRemoveW";

        /// RpcNsProfileEltInqNext -> RpcNsProfileEltInqNextW
        /// Error generating expression: Value RpcNsProfileEltInqNextW is not resolved
        public const string RpcNsProfileEltInqNext = "RpcNsProfileEltInqNextW";

        /// RpcNsProfileEltInqBegin -> RpcNsProfileEltInqBeginW
        /// Error generating expression: Value RpcNsProfileEltInqBeginW is not resolved
        public const string RpcNsProfileEltInqBegin = "RpcNsProfileEltInqBeginW";

        /// RpcNsProfileEltAdd -> RpcNsProfileEltAddW
        /// Error generating expression: Value RpcNsProfileEltAddW is not resolved
        public const string RpcNsProfileEltAdd = "RpcNsProfileEltAddW";

        /// RpcNsProfileDelete -> RpcNsProfileDeleteW
        /// Error generating expression: Value RpcNsProfileDeleteW is not resolved
        public const string RpcNsProfileDelete = "RpcNsProfileDeleteW";

        /// RpcNsMgmtEntryInqIfIds -> RpcNsMgmtEntryInqIfIdsW
        /// Error generating expression: Value RpcNsMgmtEntryInqIfIdsW is not resolved
        public const string RpcNsMgmtEntryInqIfIds = "RpcNsMgmtEntryInqIfIdsW";

        /// RpcNsMgmtEntryDelete -> RpcNsMgmtEntryDeleteW
        /// Error generating expression: Value RpcNsMgmtEntryDeleteW is not resolved
        public const string RpcNsMgmtEntryDelete = "RpcNsMgmtEntryDeleteW";

        /// RpcNsMgmtEntryCreate -> RpcNsMgmtEntryCreateW
        /// Error generating expression: Value RpcNsMgmtEntryCreateW is not resolved
        public const string RpcNsMgmtEntryCreate = "RpcNsMgmtEntryCreateW";

        /// RpcNsMgmtBindingUnexport -> RpcNsMgmtBindingUnexportW
        /// Error generating expression: Value RpcNsMgmtBindingUnexportW is not resolved
        public const string RpcNsMgmtBindingUnexport = "RpcNsMgmtBindingUnexportW";

        /// RpcNsGroupMbrRemove -> RpcNsGroupMbrRemoveW
        /// Error generating expression: Value RpcNsGroupMbrRemoveW is not resolved
        public const string RpcNsGroupMbrRemove = "RpcNsGroupMbrRemoveW";

        /// RpcNsGroupMbrInqNext -> RpcNsGroupMbrInqNextW
        /// Error generating expression: Value RpcNsGroupMbrInqNextW is not resolved
        public const string RpcNsGroupMbrInqNext = "RpcNsGroupMbrInqNextW";

        /// RpcNsGroupMbrInqBegin -> RpcNsGroupMbrInqBeginW
        /// Error generating expression: Value RpcNsGroupMbrInqBeginW is not resolved
        public const string RpcNsGroupMbrInqBegin = "RpcNsGroupMbrInqBeginW";

        /// RpcNsGroupMbrAdd -> RpcNsGroupMbrAddW
        /// Error generating expression: Value RpcNsGroupMbrAddW is not resolved
        public const string RpcNsGroupMbrAdd = "RpcNsGroupMbrAddW";

        /// RpcNsGroupDelete -> RpcNsGroupDeleteW
        /// Error generating expression: Value RpcNsGroupDeleteW is not resolved
        public const string RpcNsGroupDelete = "RpcNsGroupDeleteW";

        /// RpcNsEntryObjectInqBegin -> RpcNsEntryObjectInqBeginW
        /// Error generating expression: Value RpcNsEntryObjectInqBeginW is not resolved
        public const string RpcNsEntryObjectInqBegin = "RpcNsEntryObjectInqBeginW";

        /// RpcNsEntryExpandName -> RpcNsEntryExpandNameW
        /// Error generating expression: Value RpcNsEntryExpandNameW is not resolved
        public const string RpcNsEntryExpandName = "RpcNsEntryExpandNameW";

        /// RpcNsBindingUnexportPnP -> RpcNsBindingUnexportPnPW
        /// Error generating expression: Value RpcNsBindingUnexportPnPW is not resolved
        public const string RpcNsBindingUnexportPnP = "RpcNsBindingUnexportPnPW";

        /// RpcNsBindingUnexport -> RpcNsBindingUnexportW
        /// Error generating expression: Value RpcNsBindingUnexportW is not resolved
        public const string RpcNsBindingUnexport = "RpcNsBindingUnexportW";

        /// RpcNsBindingLookupBegin -> RpcNsBindingLookupBeginW
        /// Error generating expression: Value RpcNsBindingLookupBeginW is not resolved
        public const string RpcNsBindingLookupBegin = "RpcNsBindingLookupBeginW";

        /// RpcNsBindingInqEntryName -> RpcNsBindingInqEntryNameW
        /// Error generating expression: Value RpcNsBindingInqEntryNameW is not resolved
        public const string RpcNsBindingInqEntryName = "RpcNsBindingInqEntryNameW";

        /// RpcNsBindingImportBegin -> RpcNsBindingImportBeginW
        /// Error generating expression: Value RpcNsBindingImportBeginW is not resolved
        public const string RpcNsBindingImportBegin = "RpcNsBindingImportBeginW";

        /// RpcNsBindingExportPnP -> RpcNsBindingExportPnPW
        /// Error generating expression: Value RpcNsBindingExportPnPW is not resolved
        public const string RpcNsBindingExportPnP = "RpcNsBindingExportPnPW";

        /// RpcNsBindingExport -> RpcNsBindingExportW
        /// Error generating expression: Value RpcNsBindingExportW is not resolved
        public const string RpcNsBindingExport = "RpcNsBindingExportW";

        /// RPCNSAPI -> DECLSPEC_IMPORT
        public const string RPCNSAPI = NativeConstants.DECLSPEC_IMPORT;

        /// RpcNetworkIsProtseqValid -> RpcNetworkIsProtseqValidW
        /// Error generating expression: Value RpcNetworkIsProtseqValidW is not resolved
        public const string RpcNetworkIsProtseqValid = "RpcNetworkIsProtseqValidW";

        /// RpcNetworkInqProtseqs -> RpcNetworkInqProtseqsW
        /// Error generating expression: Value RpcNetworkInqProtseqsW is not resolved
        public const string RpcNetworkInqProtseqs = "RpcNetworkInqProtseqsW";

        /// RpcMgmtInqServerPrincName -> RpcMgmtInqServerPrincNameW
        /// Error generating expression: Value RpcMgmtInqServerPrincNameW is not resolved
        public const string RpcMgmtInqServerPrincName = "RpcMgmtInqServerPrincNameW";

        /// RpcMgmtEpEltInqNext -> RpcMgmtEpEltInqNextW
        /// Error generating expression: Value RpcMgmtEpEltInqNextW is not resolved
        public const string RpcMgmtEpEltInqNext = "RpcMgmtEpEltInqNextW";

        /// RPCFLG_NON_NDR -> 0x80000000UL
        public const uint RPCFLG_NON_NDR = 2147483648u;

        /// RPCFLG_MESSAGE -> 0x01000000UL
        public const uint RPCFLG_MESSAGE = 16777216u;

        /// RPCFLG_LOCAL_CALL -> 0x10000000UL
        public const uint RPCFLG_LOCAL_CALL = 268435456u;

        /// RPCFLG_INPUT_SYNCHRONOUS -> 0x20000000UL
        public const uint RPCFLG_INPUT_SYNCHRONOUS = 536870912u;

        /// RPCFLG_HAS_MULTI_SYNTAXES -> 0x02000000UL
        public const uint RPCFLG_HAS_MULTI_SYNTAXES = 33554432u;

        /// RPCFLG_HAS_CALLBACK -> 0x04000000UL
        public const uint RPCFLG_HAS_CALLBACK = 67108864u;

        /// RPCFLG_AUTO_COMPLETE -> 0x08000000UL
        public const uint RPCFLG_AUTO_COMPLETE = 134217728u;

        /// RPCFLG_ASYNCHRONOUS -> 0x40000000UL
        public const uint RPCFLG_ASYNCHRONOUS = 1073741824u;

        /// RpcEpRegisterNoReplace -> RpcEpRegisterNoReplaceW
        /// Error generating expression: Value RpcEpRegisterNoReplaceW is not resolved
        public const string RpcEpRegisterNoReplace = "RpcEpRegisterNoReplaceW";

        /// RpcEpRegister -> RpcEpRegisterW
        /// Error generating expression: Value RpcEpRegisterW is not resolved
        public const string RpcEpRegister = "RpcEpRegisterW";

        /// RpcBindingToStringBinding -> RpcBindingToStringBindingW
        /// Error generating expression: Value RpcBindingToStringBindingW is not resolved
        public const string RpcBindingToStringBinding = "RpcBindingToStringBindingW";

        /// RpcBindingSetAuthInfoEx -> RpcBindingSetAuthInfoExW
        /// Error generating expression: Value RpcBindingSetAuthInfoExW is not resolved
        public const string RpcBindingSetAuthInfoEx = "RpcBindingSetAuthInfoExW";

        /// RpcBindingSetAuthInfo -> RpcBindingSetAuthInfoW
        /// Error generating expression: Value RpcBindingSetAuthInfoW is not resolved
        public const string RpcBindingSetAuthInfo = "RpcBindingSetAuthInfoW";

        /// RpcBindingInqAuthInfoEx -> RpcBindingInqAuthInfoExW
        /// Error generating expression: Value RpcBindingInqAuthInfoExW is not resolved
        public const string RpcBindingInqAuthInfoEx = "RpcBindingInqAuthInfoExW";

        /// RpcBindingInqAuthInfo -> RpcBindingInqAuthInfoW
        /// Error generating expression: Value RpcBindingInqAuthInfoW is not resolved
        public const string RpcBindingInqAuthInfo = "RpcBindingInqAuthInfoW";

        /// RpcBindingInqAuthClientEx -> RpcBindingInqAuthClientExW
        /// Error generating expression: Value RpcBindingInqAuthClientExW is not resolved
        public const string RpcBindingInqAuthClientEx = "RpcBindingInqAuthClientExW";

        /// RpcBindingInqAuthClient -> RpcBindingInqAuthClientW
        /// Error generating expression: Value RpcBindingInqAuthClientW is not resolved
        public const string RpcBindingInqAuthClient = "RpcBindingInqAuthClientW";

        /// RpcBindingFromStringBinding -> RpcBindingFromStringBindingW
        /// Error generating expression: Value RpcBindingFromStringBindingW is not resolved
        public const string RpcBindingFromStringBinding = "RpcBindingFromStringBindingW";

        /// ROT_COMPARE_MAX -> 2048
        public const int ROT_COMPARE_MAX = 2048;

        /// ROTFLAGS_REGISTRATIONKEEPSALIVE -> 0x1
        public const int ROTFLAGS_REGISTRATIONKEEPSALIVE = 1;

        /// ROTFLAGS_ALLOWANYCLIENT -> 0x2
        public const int ROTFLAGS_ALLOWANYCLIENT = 2;

        /// RotateRight64 -> _rotr64
        /// Error generating expression: Value _rotr64 is not resolved
        public const string RotateRight64 = "_rotr64";

        /// RotateRight32 -> _rotr
        /// Error generating expression: Value _rotr is not resolved
        public const string RotateRight32 = "_rotr";

        /// RotateLeft64 -> _rotl64
        /// Error generating expression: Value _rotl64 is not resolved
        public const string RotateLeft64 = "_rotl64";

        /// RotateLeft32 -> _rotl
        /// Error generating expression: Value _rotl is not resolved
        public const string RotateLeft32 = "_rotl";

        /// RI_MOUSE_WHEEL -> 0x0400
        public const int RI_MOUSE_WHEEL = 1024;

        /// RI_MOUSE_RIGHT_BUTTON_UP -> 0x0008
        public const int RI_MOUSE_RIGHT_BUTTON_UP = 8;

        /// RI_MOUSE_RIGHT_BUTTON_DOWN -> 0x0004
        public const int RI_MOUSE_RIGHT_BUTTON_DOWN = 4;

        /// RI_MOUSE_MIDDLE_BUTTON_UP -> 0x0020
        public const int RI_MOUSE_MIDDLE_BUTTON_UP = 32;

        /// RI_MOUSE_MIDDLE_BUTTON_DOWN -> 0x0010
        public const int RI_MOUSE_MIDDLE_BUTTON_DOWN = 16;

        /// RI_MOUSE_LEFT_BUTTON_UP -> 0x0002
        public const int RI_MOUSE_LEFT_BUTTON_UP = 2;

        /// RI_MOUSE_LEFT_BUTTON_DOWN -> 0x0001
        public const int RI_MOUSE_LEFT_BUTTON_DOWN = 1;

        /// RI_MOUSE_BUTTON_5_UP -> 0x0200
        public const int RI_MOUSE_BUTTON_5_UP = 512;

        /// RI_MOUSE_BUTTON_5_DOWN -> 0x0100
        public const int RI_MOUSE_BUTTON_5_DOWN = 256;

        /// RI_MOUSE_BUTTON_4_UP -> 0x0080
        public const int RI_MOUSE_BUTTON_4_UP = 128;

        /// RI_MOUSE_BUTTON_4_DOWN -> 0x0040
        public const int RI_MOUSE_BUTTON_4_DOWN = 64;

        /// RI_MOUSE_BUTTON_3_UP -> RI_MOUSE_MIDDLE_BUTTON_UP
        public const int RI_MOUSE_BUTTON_3_UP = NativeConstants.RI_MOUSE_MIDDLE_BUTTON_UP;

        /// RI_MOUSE_BUTTON_3_DOWN -> RI_MOUSE_MIDDLE_BUTTON_DOWN
        public const int RI_MOUSE_BUTTON_3_DOWN = NativeConstants.RI_MOUSE_MIDDLE_BUTTON_DOWN;

        /// RI_MOUSE_BUTTON_2_UP -> RI_MOUSE_RIGHT_BUTTON_UP
        public const int RI_MOUSE_BUTTON_2_UP = NativeConstants.RI_MOUSE_RIGHT_BUTTON_UP;

        /// RI_MOUSE_BUTTON_2_DOWN -> RI_MOUSE_RIGHT_BUTTON_DOWN
        public const int RI_MOUSE_BUTTON_2_DOWN = NativeConstants.RI_MOUSE_RIGHT_BUTTON_DOWN;

        /// RI_MOUSE_BUTTON_1_UP -> RI_MOUSE_LEFT_BUTTON_UP
        public const int RI_MOUSE_BUTTON_1_UP = NativeConstants.RI_MOUSE_LEFT_BUTTON_UP;

        /// RI_MOUSE_BUTTON_1_DOWN -> RI_MOUSE_LEFT_BUTTON_DOWN
        public const int RI_MOUSE_BUTTON_1_DOWN = NativeConstants.RI_MOUSE_LEFT_BUTTON_DOWN;

        /// RI_KEY_TERMSRV_SHADOW -> 0x10
        public const int RI_KEY_TERMSRV_SHADOW = 16;

        /// RI_KEY_TERMSRV_SET_LED -> 8
        public const int RI_KEY_TERMSRV_SET_LED = 8;

        /// RI_KEY_MAKE -> 0
        public const int RI_KEY_MAKE = 0;

        /// RI_KEY_E1 -> 4
        public const int RI_KEY_E1 = 4;

        /// RI_KEY_E0 -> 2
        public const int RI_KEY_E0 = 2;

        /// RI_KEY_BREAK -> 1
        public const int RI_KEY_BREAK = 1;

        /// RIP_EVENT -> 9
        public const int RIP_EVENT = 9;

        /// RIM_TYPEMOUSE -> 0
        public const int RIM_TYPEMOUSE = 0;

        /// RIM_TYPEKEYBOARD -> 1
        public const int RIM_TYPEKEYBOARD = 1;

        /// RIM_TYPEHID -> 2
        public const int RIM_TYPEHID = 2;

        /// RIM_INPUTSINK -> 1
        public const int RIM_INPUTSINK = 1;

        /// RIM_INPUT -> 0
        public const int RIM_INPUT = 0;

        /// RIGHT_CTRL_PRESSED -> 0x0004
        public const int RIGHT_CTRL_PRESSED = 4;

        /// RIGHT_ALT_PRESSED -> 0x0001
        public const int RIGHT_ALT_PRESSED = 1;

        /// RIGHTMOST_BUTTON_PRESSED -> 0x0002
        public const int RIGHTMOST_BUTTON_PRESSED = 2;

        /// RID_INPUT -> 0x10000003
        public const int RID_INPUT = 268435459;

        /// RID_HEADER -> 0x10000005
        public const int RID_HEADER = 268435461;

        /// RIDI_PREPARSEDDATA -> 0x20000005
        public const int RIDI_PREPARSEDDATA = 536870917;

        /// RIDI_DEVICENAME -> 0x20000007
        public const int RIDI_DEVICENAME = 536870919;

        /// RIDI_DEVICEINFO -> 0x2000000b
        public const int RIDI_DEVICEINFO = 536870923;

        /// RIDEV_REMOVE -> 0x00000001
        public const int RIDEV_REMOVE = 1;

        /// RIDEV_PAGEONLY -> 0x00000020
        public const int RIDEV_PAGEONLY = 32;

        /// RIDEV_NOLEGACY -> 0x00000030
        public const int RIDEV_NOLEGACY = 48;

        /// RIDEV_NOHOTKEYS -> 0x00000200
        public const int RIDEV_NOHOTKEYS = 512;

        /// RIDEV_INPUTSINK -> 0x00000100
        public const int RIDEV_INPUTSINK = 256;

        /// RIDEV_EXMODEMASK -> 0x000000F0
        public const int RIDEV_EXMODEMASK = 240;

        /// RIDEV_EXCLUDE -> 0x00000010
        public const int RIDEV_EXCLUDE = 16;

        /// RIDEV_CAPTUREMOUSE -> 0x00000200
        public const int RIDEV_CAPTUREMOUSE = 512;

        /// RIDEV_APPKEYS -> 0x00000400
        public const int RIDEV_APPKEYS = 1024;

        /// RGN_XOR -> 3
        public const int RGN_XOR = 3;

        /// RGN_OR -> 2
        public const int RGN_OR = 2;

        /// RGN_MIN -> RGN_AND
        public const int RGN_MIN = NativeConstants.RGN_AND;

        /// RGN_MAX -> RGN_COPY
        public const int RGN_MAX = NativeConstants.RGN_COPY;

        /// RGN_ERROR -> ERROR
        public const int RGN_ERROR = NativeConstants.ERROR;

        /// RGN_DIFF -> 4
        public const int RGN_DIFF = 4;

        /// RGN_COPY -> 5
        public const int RGN_COPY = 5;

        /// RGN_AND -> 1
        public const int RGN_AND = 1;

        /// REVISION_LENGTH -> 4
        public const int REVISION_LENGTH = 4;

        /// REVERSE_PRINT -> 0x00000001
        public const int REVERSE_PRINT = 1;

        /// RETURN_SMART_STATUS -> 0xDA
        public const int RETURN_SMART_STATUS = 218;

        /// RETRACT_IEPORT -> 3
        public const int RETRACT_IEPORT = 3;

        /// RES_ICON -> 1
        public const int RES_ICON = 1;

        /// RES_CURSOR -> 2
        public const int RES_CURSOR = 2;

        /// RESTORE_CTM -> 4100
        public const int RESTORE_CTM = 4100;

        /// RESOURCE_REMEMBERED -> 0x00000003
        public const int RESOURCE_REMEMBERED = 3;

        /// RESOURCE_RECENT -> 0x00000004
        public const int RESOURCE_RECENT = 4;

        /// RESOURCE_GLOBALNET -> 0x00000002
        public const int RESOURCE_GLOBALNET = 2;

        /// RESOURCE_CONTEXT -> 0x00000005
        public const int RESOURCE_CONTEXT = 5;

        /// RESOURCE_CONNECTED -> 0x00000001
        public const int RESOURCE_CONNECTED = 1;

        /// RESOURCEUSAGE_SIBLING -> 0x00000008
        public const int RESOURCEUSAGE_SIBLING = 8;

        /// RESOURCEUSAGE_RESERVED -> 0x80000000
        public const int RESOURCEUSAGE_RESERVED = -2147483648;

        /// RESOURCEUSAGE_NOLOCALDEVICE -> 0x00000004
        public const int RESOURCEUSAGE_NOLOCALDEVICE = 4;

        /// RESOURCEUSAGE_CONTAINER -> 0x00000002
        public const int RESOURCEUSAGE_CONTAINER = 2;

        /// RESOURCEUSAGE_CONNECTABLE -> 0x00000001
        public const int RESOURCEUSAGE_CONNECTABLE = 1;

        /// RESOURCEUSAGE_ATTACHED -> 0x00000010
        public const int RESOURCEUSAGE_ATTACHED = 16;

        /// RESOURCEUSAGE_ALL -> (RESOURCEUSAGE_CONNECTABLE | RESOURCEUSAGE_CONTAINER | RESOURCEUSAGE_ATTACHED)
        public const int RESOURCEUSAGE_ALL = (NativeConstants.RESOURCEUSAGE_CONNECTABLE
                    | (NativeConstants.RESOURCEUSAGE_CONTAINER | NativeConstants.RESOURCEUSAGE_ATTACHED));

        /// RESOURCETYPE_UNKNOWN -> 0xFFFFFFFF
        public const int RESOURCETYPE_UNKNOWN = -1;

        /// RESOURCETYPE_RESERVED -> 0x00000008
        public const int RESOURCETYPE_RESERVED = 8;

        /// RESOURCETYPE_PRINT -> 0x00000002
        public const int RESOURCETYPE_PRINT = 2;

        /// RESOURCETYPE_DISK -> 0x00000001
        public const int RESOURCETYPE_DISK = 1;

        /// RESOURCETYPE_ANY -> 0x00000000
        public const int RESOURCETYPE_ANY = 0;

        /// RESOURCEDISPLAYTYPE_TREE -> 0x0000000A
        public const int RESOURCEDISPLAYTYPE_TREE = 10;

        /// RESOURCEDISPLAYTYPE_SHAREADMIN -> 0x00000008
        public const int RESOURCEDISPLAYTYPE_SHAREADMIN = 8;

        /// RESOURCEDISPLAYTYPE_SHARE -> 0x00000003
        public const int RESOURCEDISPLAYTYPE_SHARE = 3;

        /// RESOURCEDISPLAYTYPE_SERVER -> 0x00000002
        public const int RESOURCEDISPLAYTYPE_SERVER = 2;

        /// RESOURCEDISPLAYTYPE_ROOT -> 0x00000007
        public const int RESOURCEDISPLAYTYPE_ROOT = 7;

        /// RESOURCEDISPLAYTYPE_NETWORK -> 0x00000006
        public const int RESOURCEDISPLAYTYPE_NETWORK = 6;

        /// RESOURCEDISPLAYTYPE_NDSCONTAINER -> 0x0000000B
        public const int RESOURCEDISPLAYTYPE_NDSCONTAINER = 11;

        /// RESOURCEDISPLAYTYPE_GROUP -> 0x00000005
        public const int RESOURCEDISPLAYTYPE_GROUP = 5;

        /// RESOURCEDISPLAYTYPE_GENERIC -> 0x00000000
        public const int RESOURCEDISPLAYTYPE_GENERIC = 0;

        /// RESOURCEDISPLAYTYPE_FILE -> 0x00000004
        public const int RESOURCEDISPLAYTYPE_FILE = 4;

        /// RESOURCEDISPLAYTYPE_DOMAIN -> 0x00000001
        public const int RESOURCEDISPLAYTYPE_DOMAIN = 1;

        /// RESOURCEDISPLAYTYPE_DIRECTORY -> 0x00000009
        public const int RESOURCEDISPLAYTYPE_DIRECTORY = 9;

        /// ResetPrinter -> ResetPrinterW
        /// Error generating expression: Value ResetPrinterW is not resolved
        public const string ResetPrinter = "ResetPrinterW";

        /// RESETDEV -> 7
        public const int RESETDEV = 7;

        /// ResetDC -> ResetDCW
        /// Error generating expression: Value ResetDCW is not resolved
        public const string ResetDC = "ResetDCW";

        /// REPORT_NO_PRIVATE_KEY -> 0x0001
        public const int REPORT_NO_PRIVATE_KEY = 1;

        /// REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY -> 0x0002
        public const int REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY = 2;

        /// ReportEvent -> ReportEventW
        /// Error generating expression: Value ReportEventW is not resolved
        public const string ReportEvent = "ReportEventW";

        /// REPLACE_PRIMARY -> 0xA
        public const int REPLACE_PRIMARY = 10;

        /// REPLACE_ALTERNATE -> 0xB
        public const int REPLACE_ALTERNATE = 11;

        /// ReplaceText -> ReplaceTextW
        /// Error generating expression: Value ReplaceTextW is not resolved
        public const string ReplaceText = "ReplaceTextW";

        /// REPLACEFILE_WRITE_THROUGH -> 0x00000001
        public const int REPLACEFILE_WRITE_THROUGH = 1;

        /// REPLACEFILE_IGNORE_MERGE_ERRORS -> 0x00000002
        public const int REPLACEFILE_IGNORE_MERGE_ERRORS = 2;

        /// ReplaceFile -> ReplaceFileW
        /// Error generating expression: Value ReplaceFileW is not resolved
        public const string ReplaceFile = "ReplaceFileW";

        /// REPLACEDLGORD -> 1541
        public const int REPLACEDLGORD = 1541;

        /// RemoveProp -> RemovePropW
        /// Error generating expression: Value RemovePropW is not resolved
        public const string RemoveProp = "RemovePropW";

        /// RemoveFontResourceEx -> RemoveFontResourceExW
        /// Error generating expression: Value RemoveFontResourceExW is not resolved
        public const string RemoveFontResourceEx = "RemoveFontResourceExW";

        /// RemoveFontResource -> RemoveFontResourceW
        /// Error generating expression: Value RemoveFontResourceW is not resolved
        public const string RemoveFontResource = "RemoveFontResourceW";

        /// RemoveDirectory -> RemoveDirectoryW
        /// Error generating expression: Value RemoveDirectoryW is not resolved
        public const string RemoveDirectory = "RemoveDirectoryW";

        /// REMOTE_NAME_INFO_LEVEL -> 0x00000002
        public const int REMOTE_NAME_INFO_LEVEL = 2;

        /// RELATIVE -> 2
        public const int RELATIVE = 2;

        /// REG_WHOLE_HIVE_VOLATILE -> (0x00000001L)
        public const int REG_WHOLE_HIVE_VOLATILE = 1;

        /// REG_SZ -> ( 1 )
        public const int REG_SZ = 1;

        /// REG_STANDARD_FORMAT -> 1
        public const int REG_STANDARD_FORMAT = 1;

        /// REG_SECURE_CONNECTION -> 1
        public const int REG_SECURE_CONNECTION = 1;

        /// REG_RESOURCE_REQUIREMENTS_LIST -> ( 10 )
        public const int REG_RESOURCE_REQUIREMENTS_LIST = 10;

        /// REG_RESOURCE_LIST -> ( 8 )
        public const int REG_RESOURCE_LIST = 8;

        /// REG_REFRESH_HIVE -> (0x00000002L)
        public const int REG_REFRESH_HIVE = 2;

        /// REG_QWORD_LITTLE_ENDIAN -> ( 11 )
        public const int REG_QWORD_LITTLE_ENDIAN = 11;

        /// REG_QWORD -> ( 11 )
        public const int REG_QWORD = 11;

        /// REG_OPTION_VOLATILE -> (0x00000001L)
        public const int REG_OPTION_VOLATILE = 1;

        /// REG_OPTION_RESERVED -> (0x00000000L)
        public const int REG_OPTION_RESERVED = 0;

        /// REG_OPTION_OPEN_LINK -> (0x00000008L)
        public const int REG_OPTION_OPEN_LINK = 8;

        /// REG_OPTION_NON_VOLATILE -> (0x00000000L)
        public const int REG_OPTION_NON_VOLATILE = 0;

        /// REG_OPTION_CREATE_LINK -> (0x00000002L)
        public const int REG_OPTION_CREATE_LINK = 2;

        /// REG_OPTION_BACKUP_RESTORE -> (0x00000004L)
        public const int REG_OPTION_BACKUP_RESTORE = 4;

        /// REG_OPENED_EXISTING_KEY -> (0x00000002L)
        public const int REG_OPENED_EXISTING_KEY = 2;

        /// REG_NO_LAZY_FLUSH -> (0x00000004L)
        public const int REG_NO_LAZY_FLUSH = 4;

        /// REG_NO_COMPRESSION -> 4
        public const int REG_NO_COMPRESSION = 4;

        /// REG_NOTIFY_CHANGE_SECURITY -> (0x00000008L)
        public const int REG_NOTIFY_CHANGE_SECURITY = 8;

        /// REG_NOTIFY_CHANGE_NAME -> (0x00000001L)
        public const int REG_NOTIFY_CHANGE_NAME = 1;

        /// REG_NOTIFY_CHANGE_LAST_SET -> (0x00000004L)
        public const int REG_NOTIFY_CHANGE_LAST_SET = 4;

        /// REG_NOTIFY_CHANGE_ATTRIBUTES -> (0x00000002L)
        public const int REG_NOTIFY_CHANGE_ATTRIBUTES = 2;

        /// REG_NONE -> ( 0 )
        public const int REG_NONE = 0;

        /// REG_MULTI_SZ -> ( 7 )
        public const int REG_MULTI_SZ = 7;

        /// REG_LINK -> ( 6 )
        public const int REG_LINK = 6;

        /// REG_LEGAL_OPTION -> (REG_OPTION_RESERVED            |                 REG_OPTION_NON_VOLATILE        |                 REG_OPTION_VOLATILE            |                 REG_OPTION_CREATE_LINK         |                 REG_OPTION_BACKUP_RESTORE      |                 REG_OPTION_OPEN_LINK)
        public const int REG_LEGAL_OPTION = (NativeConstants.REG_OPTION_RESERVED
                    | (NativeConstants.REG_OPTION_NON_VOLATILE
                    | (NativeConstants.REG_OPTION_VOLATILE
                    | (NativeConstants.REG_OPTION_CREATE_LINK
                    | (NativeConstants.REG_OPTION_BACKUP_RESTORE | NativeConstants.REG_OPTION_OPEN_LINK)))));

        /// REG_LEGAL_CHANGE_FILTER -> (REG_NOTIFY_CHANGE_NAME          |                 REG_NOTIFY_CHANGE_ATTRIBUTES    |                 REG_NOTIFY_CHANGE_LAST_SET      |                 REG_NOTIFY_CHANGE_SECURITY)
        public const int REG_LEGAL_CHANGE_FILTER = (NativeConstants.REG_NOTIFY_CHANGE_NAME
                    | (NativeConstants.REG_NOTIFY_CHANGE_ATTRIBUTES
                    | (NativeConstants.REG_NOTIFY_CHANGE_LAST_SET | NativeConstants.REG_NOTIFY_CHANGE_SECURITY)));

        /// REG_LATEST_FORMAT -> 2
        public const int REG_LATEST_FORMAT = 2;

        /// REG_FULL_RESOURCE_DESCRIPTOR -> ( 9 )
        public const int REG_FULL_RESOURCE_DESCRIPTOR = 9;

        /// REG_FORCE_UNLOAD -> 1
        public const int REG_FORCE_UNLOAD = 1;

        /// REG_FORCE_RESTORE -> (0x00000008L)
        public const int REG_FORCE_RESTORE = 8;

        /// REG_EXPAND_SZ -> ( 2 )
        public const int REG_EXPAND_SZ = 2;

        /// REG_DWORD_LITTLE_ENDIAN -> ( 4 )
        public const int REG_DWORD_LITTLE_ENDIAN = 4;

        /// REG_DWORD_BIG_ENDIAN -> ( 5 )
        public const int REG_DWORD_BIG_ENDIAN = 5;

        /// REG_DWORD -> ( 4 )
        public const int REG_DWORD = 4;

        /// REG_CREATED_NEW_KEY -> (0x00000001L)
        public const int REG_CREATED_NEW_KEY = 1;

        /// REG_BINARY -> ( 3 )
        public const int REG_BINARY = 3;

        /// RegUnLoadKey -> RegUnLoadKeyW
        /// Error generating expression: Value RegUnLoadKeyW is not resolved
        public const string RegUnLoadKey = "RegUnLoadKeyW";

        /// REGULAR_FONTTYPE -> 0x0400
        public const int REGULAR_FONTTYPE = 1024;

        /// RegSetValueEx -> RegSetValueExW
        /// Error generating expression: Value RegSetValueExW is not resolved
        public const string RegSetValueEx = "RegSetValueExW";

        /// RegSetValue -> RegSetValueW
        /// Error generating expression: Value RegSetValueW is not resolved
        public const string RegSetValue = "RegSetValueW";

        /// RegSaveKeyEx -> RegSaveKeyExW
        /// Error generating expression: Value RegSaveKeyExW is not resolved
        public const string RegSaveKeyEx = "RegSaveKeyExW";

        /// RegSaveKey -> RegSaveKeyW
        /// Error generating expression: Value RegSaveKeyW is not resolved
        public const string RegSaveKey = "RegSaveKeyW";

        /// RegRestoreKey -> RegRestoreKeyW
        /// Error generating expression: Value RegRestoreKeyW is not resolved
        public const string RegRestoreKey = "RegRestoreKeyW";

        /// RegReplaceKey -> RegReplaceKeyW
        /// Error generating expression: Value RegReplaceKeyW is not resolved
        public const string RegReplaceKey = "RegReplaceKeyW";

        /// RegQueryValueEx -> RegQueryValueExW
        /// Error generating expression: Value RegQueryValueExW is not resolved
        public const string RegQueryValueEx = "RegQueryValueExW";

        /// RegQueryValue -> RegQueryValueW
        /// Error generating expression: Value RegQueryValueW is not resolved
        public const string RegQueryValue = "RegQueryValueW";

        /// RegQueryMultipleValues -> RegQueryMultipleValuesW
        /// Error generating expression: Value RegQueryMultipleValuesW is not resolved
        public const string RegQueryMultipleValues = "RegQueryMultipleValuesW";

        /// RegQueryInfoKey -> RegQueryInfoKeyW
        /// Error generating expression: Value RegQueryInfoKeyW is not resolved
        public const string RegQueryInfoKey = "RegQueryInfoKeyW";

        /// RegOpenKeyEx -> RegOpenKeyExW
        /// Error generating expression: Value RegOpenKeyExW is not resolved
        public const string RegOpenKeyEx = "RegOpenKeyExW";

        /// RegOpenKey -> RegOpenKeyW
        /// Error generating expression: Value RegOpenKeyW is not resolved
        public const string RegOpenKey = "RegOpenKeyW";

        /// RegLoadKey -> RegLoadKeyW
        /// Error generating expression: Value RegLoadKeyW is not resolved
        public const string RegLoadKey = "RegLoadKeyW";

        /// REGISTERWORDENUMPROC -> REGISTERWORDENUMPROCW
        /// Error generating expression: Value REGISTERWORDENUMPROCW is not resolved
        public const string REGISTERWORDENUMPROC = "REGISTERWORDENUMPROCW";

        /// RegisterWindowMessage -> RegisterWindowMessageW
        /// Error generating expression: Value RegisterWindowMessageW is not resolved
        public const string RegisterWindowMessage = "RegisterWindowMessageW";

        /// RegisterServiceCtrlHandlerEx -> RegisterServiceCtrlHandlerExW
        /// Error generating expression: Value RegisterServiceCtrlHandlerExW is not resolved
        public const string RegisterServiceCtrlHandlerEx = "RegisterServiceCtrlHandlerExW";

        /// RegisterServiceCtrlHandler -> RegisterServiceCtrlHandlerW
        /// Error generating expression: Value RegisterServiceCtrlHandlerW is not resolved
        public const string RegisterServiceCtrlHandler = "RegisterServiceCtrlHandlerW";

        /// REGISTERING -> 0x00
        public const int REGISTERING = 0;

        /// RegisterEventSource -> RegisterEventSourceW
        /// Error generating expression: Value RegisterEventSourceW is not resolved
        public const string RegisterEventSource = "RegisterEventSourceW";

        /// REGISTERED -> 0x04
        public const int REGISTERED = 4;

        /// RegisterDeviceNotification -> RegisterDeviceNotificationW
        /// Error generating expression: Value RegisterDeviceNotificationW is not resolved
        public const string RegisterDeviceNotification = "RegisterDeviceNotificationW";

        /// RegisterClipboardFormat -> RegisterClipboardFormatW
        /// Error generating expression: Value RegisterClipboardFormatW is not resolved
        public const string RegisterClipboardFormat = "RegisterClipboardFormatW";

        /// RegisterClassEx -> RegisterClassExW
        /// Error generating expression: Value RegisterClassExW is not resolved
        public const string RegisterClassEx = "RegisterClassExW";

        /// RegisterClass -> RegisterClassW
        /// Error generating expression: Value RegisterClassW is not resolved
        public const string RegisterClass = "RegisterClassW";

        /// RegGetValue -> RegGetValueW
        /// Error generating expression: Value RegGetValueW is not resolved
        public const string RegGetValue = "RegGetValueW";

        /// RegEnumValue -> RegEnumValueW
        /// Error generating expression: Value RegEnumValueW is not resolved
        public const string RegEnumValue = "RegEnumValueW";

        /// RegEnumKeyEx -> RegEnumKeyExW
        /// Error generating expression: Value RegEnumKeyExW is not resolved
        public const string RegEnumKeyEx = "RegEnumKeyExW";

        /// RegEnumKey -> RegEnumKeyW
        /// Error generating expression: Value RegEnumKeyW is not resolved
        public const string RegEnumKey = "RegEnumKeyW";

        /// RegDeleteValue -> RegDeleteValueW
        /// Error generating expression: Value RegDeleteValueW is not resolved
        public const string RegDeleteValue = "RegDeleteValueW";

        /// RegDeleteKeyEx -> RegDeleteKeyExW
        /// Error generating expression: Value RegDeleteKeyExW is not resolved
        public const string RegDeleteKeyEx = "RegDeleteKeyExW";

        /// RegDeleteKey -> RegDeleteKeyW
        /// Error generating expression: Value RegDeleteKeyW is not resolved
        public const string RegDeleteKey = "RegDeleteKeyW";

        /// REGDB_S_LAST -> 0x0004015FL
        public const int REGDB_S_LAST = 262495;

        /// REGDB_S_FIRST -> 0x00040150L
        public const int REGDB_S_FIRST = 262480;

        /// REGDB_E_LAST -> 0x8004015FL
        public const int REGDB_E_LAST = -2147221153;

        /// REGDB_E_FIRST -> 0x80040150L
        public const int REGDB_E_FIRST = -2147221168;

        /// RegCreateKeyEx -> RegCreateKeyExW
        /// Error generating expression: Value RegCreateKeyExW is not resolved
        public const string RegCreateKeyEx = "RegCreateKeyExW";

        /// RegCreateKey -> RegCreateKeyW
        /// Error generating expression: Value RegCreateKeyW is not resolved
        public const string RegCreateKey = "RegCreateKeyW";

        /// RegConnectRegistryEx -> RegConnectRegistryExW
        /// Error generating expression: Value RegConnectRegistryExW is not resolved
        public const string RegConnectRegistryEx = "RegConnectRegistryExW";

        /// RegConnectRegistry -> RegConnectRegistryW
        /// Error generating expression: Value RegConnectRegistryW is not resolved
        public const string RegConnectRegistry = "RegConnectRegistryW";

        /// RECOVERED_WRITES_VALID -> 0x00000001
        public const int RECOVERED_WRITES_VALID = 1;

        /// RECOVERED_READS_VALID -> 0x00000004
        public const int RECOVERED_READS_VALID = 4;

        /// REASON_UNSTABLE -> SHTDN_REASON_MAJOR_SYSTEM|SHTDN_REASON_MINOR_UNSTABLE
        public const int REASON_UNSTABLE = (NativeConstants.SHTDN_REASON_MAJOR_SYSTEM | NativeConstants.SHTDN_REASON_MINOR_UNSTABLE);

        /// REASON_UNKNOWN -> SHTDN_REASON_UNKNOWN
        public const int REASON_UNKNOWN = NativeConstants.SHTDN_REASON_UNKNOWN;

        /// REASON_SWINSTALL -> SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_INSTALLATION
        public const int REASON_SWINSTALL = (NativeConstants.SHTDN_REASON_MAJOR_SOFTWARE | NativeConstants.SHTDN_REASON_MINOR_INSTALLATION);

        /// REASON_SWHWRECONF -> SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_RECONFIG
        public const int REASON_SWHWRECONF = (NativeConstants.SHTDN_REASON_MAJOR_SOFTWARE | NativeConstants.SHTDN_REASON_MINOR_RECONFIG);

        /// REASON_SERVICEHANG -> SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_HUNG
        public const int REASON_SERVICEHANG = (NativeConstants.SHTDN_REASON_MAJOR_SOFTWARE | NativeConstants.SHTDN_REASON_MINOR_HUNG);

        /// REASON_PLANNED_FLAG -> SHTDN_REASON_FLAG_PLANNED
        public const int REASON_PLANNED_FLAG = NativeConstants.SHTDN_REASON_FLAG_PLANNED;

        /// REASON_OTHER -> SHTDN_REASON_MAJOR_OTHER|SHTDN_REASON_MINOR_OTHER
        public const int REASON_OTHER = (NativeConstants.SHTDN_REASON_MAJOR_OTHER | NativeConstants.SHTDN_REASON_MINOR_OTHER);

        /// REASON_LEGACY_API -> SHTDN_REASON_LEGACY_API
        public const int REASON_LEGACY_API = NativeConstants.SHTDN_REASON_LEGACY_API;

        /// REASON_HWINSTALL -> SHTDN_REASON_MAJOR_HARDWARE|SHTDN_REASON_MINOR_INSTALLATION
        public const int REASON_HWINSTALL = (NativeConstants.SHTDN_REASON_MAJOR_HARDWARE | NativeConstants.SHTDN_REASON_MINOR_INSTALLATION);

        /// REALTIME_PRIORITY_CLASS -> 0x00000100
        public const int REALTIME_PRIORITY_CLASS = 256;

        /// RealGetWindowClass -> RealGetWindowClassW
        /// Error generating expression: Value RealGetWindowClassW is not resolved
        public const string RealGetWindowClass = "RealGetWindowClassW";

        /// READ_THRESHOLD_BUFFER_SIZE -> 512
        public const int READ_THRESHOLD_BUFFER_SIZE = 512;

        /// READ_THRESHOLDS -> 0xD1
        public const int READ_THRESHOLDS = 209;

        /// READ_CONTROL -> (0x00020000L)
        public const int READ_CONTROL = 131072;

        /// READ_COMPRESSION_INFO_VALID -> 0x00000020
        public const int READ_COMPRESSION_INFO_VALID = 32;

        /// READ_ATTRIBUTE_BUFFER_SIZE -> 512
        public const int READ_ATTRIBUTE_BUFFER_SIZE = 512;

        /// READ_ATTRIBUTES -> 0xD0
        public const int READ_ATTRIBUTES = 208;

        /// ReadEventLog -> ReadEventLogW
        /// Error generating expression: Value ReadEventLogW is not resolved
        public const string ReadEventLog = "ReadEventLogW";

        /// ReadConsoleOutputCharacter -> ReadConsoleOutputCharacterW
        /// Error generating expression: Value ReadConsoleOutputCharacterW is not resolved
        public const string ReadConsoleOutputCharacter = "ReadConsoleOutputCharacterW";

        /// ReadConsoleOutput -> ReadConsoleOutputW
        /// Error generating expression: Value ReadConsoleOutputW is not resolved
        public const string ReadConsoleOutput = "ReadConsoleOutputW";

        /// ReadConsoleInput -> ReadConsoleInputW
        /// Error generating expression: Value ReadConsoleInputW is not resolved
        public const string ReadConsoleInput = "ReadConsoleInputW";

        /// ReadConsole -> ReadConsoleW
        /// Error generating expression: Value ReadConsoleW is not resolved
        public const string ReadConsole = "ReadConsoleW";

        /// RDW_VALIDATE -> 0x0008
        public const int RDW_VALIDATE = 8;

        /// RDW_UPDATENOW -> 0x0100
        public const int RDW_UPDATENOW = 256;

        /// RDW_NOINTERNALPAINT -> 0x0010
        public const int RDW_NOINTERNALPAINT = 16;

        /// RDW_NOFRAME -> 0x0800
        public const int RDW_NOFRAME = 2048;

        /// RDW_NOERASE -> 0x0020
        public const int RDW_NOERASE = 32;

        /// RDW_NOCHILDREN -> 0x0040
        public const int RDW_NOCHILDREN = 64;

        /// RDW_INVALIDATE -> 0x0001
        public const int RDW_INVALIDATE = 1;

        /// RDW_INTERNALPAINT -> 0x0002
        public const int RDW_INTERNALPAINT = 2;

        /// RDW_FRAME -> 0x0400
        public const int RDW_FRAME = 1024;

        /// RDW_ERASENOW -> 0x0200
        public const int RDW_ERASENOW = 512;

        /// RDW_ERASE -> 0x0004
        public const int RDW_ERASE = 4;

        /// RDW_ALLCHILDREN -> 0x0080
        public const int RDW_ALLCHILDREN = 128;

        /// RDH_RECTANGLES -> 1
        public const int RDH_RECTANGLES = 1;

        /// RC_STRETCHDIB -> 0x2000
        public const int RC_STRETCHDIB = 8192;

        /// RC_STRETCHBLT -> 0x0800
        public const int RC_STRETCHBLT = 2048;

        /// RC_SCALING -> 4
        public const int RC_SCALING = 4;

        /// RC_SAVEBITMAP -> 0x0040
        public const int RC_SAVEBITMAP = 64;

        /// RC_PALETTE -> 0x0100
        public const int RC_PALETTE = 256;

        /// RC_OP_DX_OUTPUT -> 0x4000
        public const int RC_OP_DX_OUTPUT = 16384;

        /// RC_GDI20_STATE -> 0x0020
        public const int RC_GDI20_STATE = 32;

        /// RC_GDI20_OUTPUT -> 0x0010
        public const int RC_GDI20_OUTPUT = 16;

        /// RC_FLOODFILL -> 0x1000
        public const int RC_FLOODFILL = 4096;

        /// RC_DI_BITMAP -> 0x0080
        public const int RC_DI_BITMAP = 128;

        /// RC_DIBTODEV -> 0x0200
        public const int RC_DIBTODEV = 512;

        /// RC_DEVBITS -> 0x8000
        public const int RC_DEVBITS = 32768;

        /// RC_BITMAP64 -> 8
        public const int RC_BITMAP64 = 8;

        /// RC_BITBLT -> 1
        public const int RC_BITBLT = 1;

        /// RC_BIGFONT -> 0x0400
        public const int RC_BIGFONT = 1024;

        /// RC_BANDING -> 2
        public const int RC_BANDING = 2;

        /// rct4 -> 0x043b
        public const int rct4 = 1083;

        /// rct3 -> 0x043a
        public const int rct3 = 1082;

        /// rct2 -> 0x0439
        public const int rct2 = 1081;

        /// rct1 -> 0x0438
        public const int rct1 = 1080;

        /// RASTER_FONTTYPE -> 0x0001
        public const int RASTER_FONTTYPE = 1;

        /// RASTERCAPS -> 38
        public const int RASTERCAPS = 38;

        /// RAND_MAX -> 0x7fff
        public const int RAND_MAX = 32767;

        /// RANDOM_PADDING -> 2
        public const int RANDOM_PADDING = 2;

        /// rad9 -> 0x0428
        public const int rad9 = 1064;

        /// rad8 -> 0x0427
        public const int rad8 = 1063;

        /// rad7 -> 0x0426
        public const int rad7 = 1062;

        /// rad6 -> 0x0425
        public const int rad6 = 1061;

        /// rad5 -> 0x0424
        public const int rad5 = 1060;

        /// rad4 -> 0x0423
        public const int rad4 = 1059;

        /// rad3 -> 0x0422
        public const int rad3 = 1058;

        /// rad2 -> 0x0421
        public const int rad2 = 1057;

        /// rad16 -> 0x042f
        public const int rad16 = 1071;

        /// rad15 -> 0x042e
        public const int rad15 = 1070;

        /// rad14 -> 0x042d
        public const int rad14 = 1069;

        /// rad13 -> 0x042c
        public const int rad13 = 1068;

        /// rad12 -> 0x042b
        public const int rad12 = 1067;

        /// rad11 -> 0x042a
        public const int rad11 = 1066;

        /// rad10 -> 0x0429
        public const int rad10 = 1065;

        /// rad1 -> 0x0420
        public const int rad1 = 1056;

        /// R2_XORPEN -> 7
        public const int R2_XORPEN = 7;

        /// R2_WHITE -> 16
        public const int R2_WHITE = 16;

        /// R2_NOTXORPEN -> 10
        public const int R2_NOTXORPEN = 10;

        /// R2_NOTMERGEPEN -> 2
        public const int R2_NOTMERGEPEN = 2;

        /// R2_NOTMASKPEN -> 8
        public const int R2_NOTMASKPEN = 8;

        /// R2_NOTCOPYPEN -> 4
        public const int R2_NOTCOPYPEN = 4;

        /// R2_NOT -> 6
        public const int R2_NOT = 6;

        /// R2_NOP -> 11
        public const int R2_NOP = 11;

        /// R2_MERGEPENNOT -> 14
        public const int R2_MERGEPENNOT = 14;

        /// R2_MERGEPEN -> 15
        public const int R2_MERGEPEN = 15;

        /// R2_MERGENOTPEN -> 12
        public const int R2_MERGENOTPEN = 12;

        /// R2_MASKPENNOT -> 5
        public const int R2_MASKPENNOT = 5;

        /// R2_MASKPEN -> 9
        public const int R2_MASKPEN = 9;

        /// R2_MASKNOTPEN -> 3
        public const int R2_MASKNOTPEN = 3;

        /// R2_LAST -> 16
        public const int R2_LAST = 16;

        /// R2_COPYPEN -> 13
        public const int R2_COPYPEN = 13;

        /// R2_BLACK -> 1
        public const int R2_BLACK = 1;
    }

}
