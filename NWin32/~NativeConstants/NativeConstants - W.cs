namespace NWin32
{
    public partial class NativeConstants
    {

        /// wvsprintf -> wvsprintfW
        /// Error generating expression: Value wvsprintfW is not resolved
        public const string wvsprintf = "wvsprintfW";

        /// WVR_VREDRAW -> 0x0200
        public const int WVR_VREDRAW = 512;

        /// WVR_VALIDRECTS -> 0x0400
        public const int WVR_VALIDRECTS = 1024;

        /// WVR_REDRAW -> (WVR_HREDRAW |                             WVR_VREDRAW)
        public const int WVR_REDRAW = (NativeConstants.WVR_HREDRAW | NativeConstants.WVR_VREDRAW);

        /// WVR_HREDRAW -> 0x0100
        public const int WVR_HREDRAW = 256;

        /// WVR_ALIGNTOP -> 0x0010
        public const int WVR_ALIGNTOP = 16;

        /// WVR_ALIGNRIGHT -> 0x0080
        public const int WVR_ALIGNRIGHT = 128;

        /// WVR_ALIGNLEFT -> 0x0020
        public const int WVR_ALIGNLEFT = 32;

        /// WVR_ALIGNBOTTOM -> 0x0040
        public const int WVR_ALIGNBOTTOM = 64;

        /// WT_TRANSFER_IMPERSONATION -> 0x00000100
        public const int WT_TRANSFER_IMPERSONATION = 256;

        /// WT_EXECUTEONLYONCE -> 0x00000008
        public const int WT_EXECUTEONLYONCE = 8;

        /// WT_EXECUTELONGFUNCTION -> 0x00000010
        public const int WT_EXECUTELONGFUNCTION = 16;

        /// WT_EXECUTEINWAITTHREAD -> 0x00000004
        public const int WT_EXECUTEINWAITTHREAD = 4;

        /// WT_EXECUTEINUITHREAD -> 0x00000002
        public const int WT_EXECUTEINUITHREAD = 2;

        /// WT_EXECUTEINTIMERTHREAD -> 0x00000020
        public const int WT_EXECUTEINTIMERTHREAD = 32;

        /// WT_EXECUTEINPERSISTENTTHREAD -> 0x00000080
        public const int WT_EXECUTEINPERSISTENTTHREAD = 128;

        /// WT_EXECUTEINPERSISTENTIOTHREAD -> 0x00000040
        public const int WT_EXECUTEINPERSISTENTIOTHREAD = 64;

        /// WT_EXECUTEINLONGTHREAD -> 0x00000010
        public const int WT_EXECUTEINLONGTHREAD = 16;

        /// WT_EXECUTEINIOTHREAD -> 0x00000001
        public const int WT_EXECUTEINIOTHREAD = 1;

        /// WT_EXECUTEDELETEWAIT -> 0x00000008
        public const int WT_EXECUTEDELETEWAIT = 8;

        /// WT_EXECUTEDEFAULT -> 0x00000000
        public const int WT_EXECUTEDEFAULT = 0;

        /// WTS_SESSION_UNLOCK -> 0x8
        public const int WTS_SESSION_UNLOCK = 8;

        /// WTS_SESSION_REMOTE_CONTROL -> 0x9
        public const int WTS_SESSION_REMOTE_CONTROL = 9;

        /// WTS_SESSION_LOGON -> 0x5
        public const int WTS_SESSION_LOGON = 5;

        /// WTS_SESSION_LOGOFF -> 0x6
        public const int WTS_SESSION_LOGOFF = 6;

        /// WTS_SESSION_LOCK -> 0x7
        public const int WTS_SESSION_LOCK = 7;

        /// WTS_REMOTE_DISCONNECT -> 0x4
        public const int WTS_REMOTE_DISCONNECT = 4;

        /// WTS_REMOTE_CONNECT -> 0x3
        public const int WTS_REMOTE_CONNECT = 3;

        /// WTS_CONSOLE_DISCONNECT -> 0x2
        public const int WTS_CONSOLE_DISCONNECT = 2;

        /// WTS_CONSOLE_CONNECT -> 0x1
        public const int WTS_CONSOLE_CONNECT = 1;

        /// WS_VSCROLL -> 0x00200000L
        public const int WS_VSCROLL = 2097152;

        /// WS_VISIBLE -> 0x10000000L
        public const int WS_VISIBLE = 268435456;

        /// WS_TILEDWINDOW -> WS_OVERLAPPEDWINDOW
        public const int WS_TILEDWINDOW = NativeConstants.WS_OVERLAPPEDWINDOW;

        /// WS_TILED -> WS_OVERLAPPED
        public const int WS_TILED = NativeConstants.WS_OVERLAPPED;

        /// WS_THICKFRAME -> 0x00040000L
        public const int WS_THICKFRAME = 262144;

        /// WS_TABSTOP -> 0x00010000L
        public const int WS_TABSTOP = 65536;

        /// WS_SYSMENU -> 0x00080000L
        public const int WS_SYSMENU = 524288;

        /// WS_SIZEBOX -> WS_THICKFRAME
        public const int WS_SIZEBOX = NativeConstants.WS_THICKFRAME;

        /// WS_POPUPWINDOW -> (WS_POPUP          |                              WS_BORDER         |                              WS_SYSMENU)
        public const int WS_POPUPWINDOW = (NativeConstants.WS_POPUP
                    | (NativeConstants.WS_BORDER | NativeConstants.WS_SYSMENU));

        /// WS_POPUP -> 0x80000000L
        public const int WS_POPUP = -2147483648;

        /// WS_OVERLAPPEDWINDOW -> (WS_OVERLAPPED     |                              WS_CAPTION        |                              WS_SYSMENU        |                              WS_THICKFRAME     |                              WS_MINIMIZEBOX    |                              WS_MAXIMIZEBOX)
        public const int WS_OVERLAPPEDWINDOW = (NativeConstants.WS_OVERLAPPED
                    | (NativeConstants.WS_CAPTION
                    | (NativeConstants.WS_SYSMENU
                    | (NativeConstants.WS_THICKFRAME
                    | (NativeConstants.WS_MINIMIZEBOX | NativeConstants.WS_MAXIMIZEBOX)))));

        /// WS_OVERLAPPED -> 0x00000000L
        public const int WS_OVERLAPPED = 0;

        /// WS_MINIMIZEBOX -> 0x00020000L
        public const int WS_MINIMIZEBOX = 131072;

        /// WS_MINIMIZE -> 0x20000000L
        public const int WS_MINIMIZE = 536870912;

        /// WS_MAXIMIZEBOX -> 0x00010000L
        public const int WS_MAXIMIZEBOX = 65536;

        /// WS_MAXIMIZE -> 0x01000000L
        public const int WS_MAXIMIZE = 16777216;

        /// WS_ICONIC -> WS_MINIMIZE
        public const int WS_ICONIC = NativeConstants.WS_MINIMIZE;

        /// WS_HSCROLL -> 0x00100000L
        public const int WS_HSCROLL = 1048576;

        /// WS_GROUP -> 0x00020000L
        public const int WS_GROUP = 131072;

        /// WS_EX_WINDOWEDGE -> 0x00000100L
        public const int WS_EX_WINDOWEDGE = 256;

        /// WS_EX_TRANSPARENT -> 0x00000020L
        public const int WS_EX_TRANSPARENT = 32;

        /// WS_EX_TOPMOST -> 0x00000008L
        public const int WS_EX_TOPMOST = 8;

        /// WS_EX_TOOLWINDOW -> 0x00000080L
        public const int WS_EX_TOOLWINDOW = 128;

        /// WS_EX_STATICEDGE -> 0x00020000L
        public const int WS_EX_STATICEDGE = 131072;

        /// WS_EX_RTLREADING -> 0x00002000L
        public const int WS_EX_RTLREADING = 8192;

        /// WS_EX_RIGHTSCROLLBAR -> 0x00000000L
        public const int WS_EX_RIGHTSCROLLBAR = 0;

        /// WS_EX_RIGHT -> 0x00001000L
        public const int WS_EX_RIGHT = 4096;

        /// WS_EX_PALETTEWINDOW -> (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST)
        public const int WS_EX_PALETTEWINDOW = (NativeConstants.WS_EX_WINDOWEDGE
                    | (NativeConstants.WS_EX_TOOLWINDOW | NativeConstants.WS_EX_TOPMOST));

        /// WS_EX_OVERLAPPEDWINDOW -> (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE)
        public const int WS_EX_OVERLAPPEDWINDOW = (NativeConstants.WS_EX_WINDOWEDGE | NativeConstants.WS_EX_CLIENTEDGE);

        /// WS_EX_NOPARENTNOTIFY -> 0x00000004L
        public const int WS_EX_NOPARENTNOTIFY = 4;

        /// WS_EX_NOINHERITLAYOUT -> 0x00100000L
        public const int WS_EX_NOINHERITLAYOUT = 1048576;

        /// WS_EX_NOACTIVATE -> 0x08000000L
        public const int WS_EX_NOACTIVATE = 134217728;

        /// WS_EX_MDICHILD -> 0x00000040L
        public const int WS_EX_MDICHILD = 64;

        /// WS_EX_LTRREADING -> 0x00000000L
        public const int WS_EX_LTRREADING = 0;

        /// WS_EX_LEFTSCROLLBAR -> 0x00004000L
        public const int WS_EX_LEFTSCROLLBAR = 16384;

        /// WS_EX_LEFT -> 0x00000000L
        public const int WS_EX_LEFT = 0;

        /// WS_EX_LAYOUTRTL -> 0x00400000L
        public const int WS_EX_LAYOUTRTL = 4194304;

        /// WS_EX_LAYERED -> 0x00080000
        public const int WS_EX_LAYERED = 524288;

        /// WS_EX_DLGMODALFRAME -> 0x00000001L
        public const int WS_EX_DLGMODALFRAME = 1;

        /// WS_EX_CONTROLPARENT -> 0x00010000L
        public const int WS_EX_CONTROLPARENT = 65536;

        /// WS_EX_CONTEXTHELP -> 0x00000400L
        public const int WS_EX_CONTEXTHELP = 1024;

        /// WS_EX_COMPOSITED -> 0x02000000L
        public const int WS_EX_COMPOSITED = 33554432;

        /// WS_EX_CLIENTEDGE -> 0x00000200L
        public const int WS_EX_CLIENTEDGE = 512;

        /// WS_EX_APPWINDOW -> 0x00040000L
        public const int WS_EX_APPWINDOW = 262144;

        /// WS_EX_ACCEPTFILES -> 0x00000010L
        public const int WS_EX_ACCEPTFILES = 16;

        /// WS_DLGFRAME -> 0x00400000L
        public const int WS_DLGFRAME = 4194304;

        /// WS_DISABLED -> 0x08000000L
        public const int WS_DISABLED = 134217728;

        /// WS_CLIPSIBLINGS -> 0x04000000L
        public const int WS_CLIPSIBLINGS = 67108864;

        /// WS_CLIPCHILDREN -> 0x02000000L
        public const int WS_CLIPCHILDREN = 33554432;

        /// WS_CHILDWINDOW -> (WS_CHILD)
        public const int WS_CHILDWINDOW = NativeConstants.WS_CHILD;

        /// WS_CHILD -> 0x40000000L
        public const int WS_CHILD = 1073741824;

        /// WS_CAPTION -> 0x00C00000L
        public const int WS_CAPTION = 12582912;

        /// WS_BORDER -> 0x00800000L
        public const int WS_BORDER = 8388608;

        /// WS_ACTIVECAPTION -> 0x0001
        public const int WS_ACTIVECAPTION = 1;

        /// wsprintf -> wsprintfW
        /// Error generating expression: Value wsprintfW is not resolved
        public const string wsprintf = "wsprintfW";

        /// WSF_VISIBLE -> 0x0001L
        public const int WSF_VISIBLE = 1;

        /// WSA_QOS_TRAFFIC_CTRL_ERROR -> 11014L
        public const int WSA_QOS_TRAFFIC_CTRL_ERROR = 11014;

        /// WSA_QOS_SENDERS -> 11006L
        public const int WSA_QOS_SENDERS = 11006;

        /// WSA_QOS_RESERVED_PETYPE -> 11031L
        public const int WSA_QOS_RESERVED_PETYPE = 11031;

        /// WSA_QOS_REQUEST_CONFIRMED -> 11009L
        public const int WSA_QOS_REQUEST_CONFIRMED = 11009;

        /// WSA_QOS_RECEIVERS -> 11005L
        public const int WSA_QOS_RECEIVERS = 11005;

        /// WSA_QOS_POLICY_FAILURE -> 11011L
        public const int WSA_QOS_POLICY_FAILURE = 11011;

        /// WSA_QOS_NO_SENDERS -> 11007L
        public const int WSA_QOS_NO_SENDERS = 11007;

        /// WSA_QOS_NO_RECEIVERS -> 11008L
        public const int WSA_QOS_NO_RECEIVERS = 11008;

        /// WSA_QOS_GENERIC_ERROR -> 11015L
        public const int WSA_QOS_GENERIC_ERROR = 11015;

        /// WSA_QOS_EUNKOWNPSOBJ -> 11024L
        public const int WSA_QOS_EUNKOWNPSOBJ = 11024;

        /// WSA_QOS_ESHAPERATEOBJ -> 11030L
        public const int WSA_QOS_ESHAPERATEOBJ = 11030;

        /// WSA_QOS_ESERVICETYPE -> 11016L
        public const int WSA_QOS_ESERVICETYPE = 11016;

        /// WSA_QOS_ESDMODEOBJ -> 11029L
        public const int WSA_QOS_ESDMODEOBJ = 11029;

        /// WSA_QOS_EPSFLOWSPEC -> 11027L
        public const int WSA_QOS_EPSFLOWSPEC = 11027;

        /// WSA_QOS_EPSFILTERSPEC -> 11028L
        public const int WSA_QOS_EPSFILTERSPEC = 11028;

        /// WSA_QOS_EPROVSPECBUF -> 11018L
        public const int WSA_QOS_EPROVSPECBUF = 11018;

        /// WSA_QOS_EPOLICYOBJ -> 11025L
        public const int WSA_QOS_EPOLICYOBJ = 11025;

        /// WSA_QOS_EOBJLENGTH -> 11022L
        public const int WSA_QOS_EOBJLENGTH = 11022;

        /// WSA_QOS_EFLOWSPEC -> 11017L
        public const int WSA_QOS_EFLOWSPEC = 11017;

        /// WSA_QOS_EFLOWDESC -> 11026L
        public const int WSA_QOS_EFLOWDESC = 11026;

        /// WSA_QOS_EFLOWCOUNT -> 11023L
        public const int WSA_QOS_EFLOWCOUNT = 11023;

        /// WSA_QOS_EFILTERTYPE -> 11020L
        public const int WSA_QOS_EFILTERTYPE = 11020;

        /// WSA_QOS_EFILTERSTYLE -> 11019L
        public const int WSA_QOS_EFILTERSTYLE = 11019;

        /// WSA_QOS_EFILTERCOUNT -> 11021L
        public const int WSA_QOS_EFILTERCOUNT = 11021;

        /// WSA_QOS_BAD_STYLE -> 11012L
        public const int WSA_QOS_BAD_STYLE = 11012;

        /// WSA_QOS_BAD_OBJECT -> 11013L
        public const int WSA_QOS_BAD_OBJECT = 11013;

        /// WSA_QOS_ADMISSION_FAILURE -> 11010L
        public const int WSA_QOS_ADMISSION_FAILURE = 11010;

        /// WSA_E_NO_MORE -> 10110L
        public const int WSA_E_NO_MORE = 10110;

        /// WSA_E_CANCELLED -> 10111L
        public const int WSA_E_CANCELLED = 10111;

        /// WSAVERNOTSUPPORTED -> 10092L
        public const int WSAVERNOTSUPPORTED = 10092;

        /// WSATYPE_NOT_FOUND -> 10109L
        public const int WSATYPE_NOT_FOUND = 10109;

        /// WSATRY_AGAIN -> 11002L
        public const int WSATRY_AGAIN = 11002;

        /// WSASYS_STATUS_LEN -> 128
        public const int WSASYS_STATUS_LEN = 128;

        /// WSASYSNOTREADY -> 10091L
        public const int WSASYSNOTREADY = 10091;

        /// WSASYSCALLFAILURE -> 10107L
        public const int WSASYSCALLFAILURE = 10107;

        /// WSASERVICE_NOT_FOUND -> 10108L
        public const int WSASERVICE_NOT_FOUND = 10108;

        /// WSANO_RECOVERY -> 11003L
        public const int WSANO_RECOVERY = 11003;

        /// WSANO_DATA -> 11004L
        public const int WSANO_DATA = 11004;

        /// WSANO_ADDRESS -> WSANO_DATA
        public const int WSANO_ADDRESS = NativeConstants.WSANO_DATA;

        /// WSANOTINITIALISED -> 10093L
        public const int WSANOTINITIALISED = 10093;

        /// WSAHOST_NOT_FOUND -> 11001L
        public const int WSAHOST_NOT_FOUND = 11001;

        /// WSAEWOULDBLOCK -> 10035L
        public const int WSAEWOULDBLOCK = 10035;

        /// WSAEUSERS -> 10068L
        public const int WSAEUSERS = 10068;

        /// WSAETOOMANYREFS -> 10059L
        public const int WSAETOOMANYREFS = 10059;

        /// WSAETIMEDOUT -> 10060L
        public const int WSAETIMEDOUT = 10060;

        /// WSAESTALE -> 10070L
        public const int WSAESTALE = 10070;

        /// WSAESOCKTNOSUPPORT -> 10044L
        public const int WSAESOCKTNOSUPPORT = 10044;

        /// WSAESHUTDOWN -> 10058L
        public const int WSAESHUTDOWN = 10058;

        /// WSAEREMOTE -> 10071L
        public const int WSAEREMOTE = 10071;

        /// WSAEREFUSED -> 10112L
        public const int WSAEREFUSED = 10112;

        /// WSAEPROVIDERFAILEDINIT -> 10106L
        public const int WSAEPROVIDERFAILEDINIT = 10106;

        /// WSAEPROTOTYPE -> 10041L
        public const int WSAEPROTOTYPE = 10041;

        /// WSAEPROTONOSUPPORT -> 10043L
        public const int WSAEPROTONOSUPPORT = 10043;

        /// WSAEPROCLIM -> 10067L
        public const int WSAEPROCLIM = 10067;

        /// WSAEPFNOSUPPORT -> 10046L
        public const int WSAEPFNOSUPPORT = 10046;

        /// WSAEOPNOTSUPP -> 10045L
        public const int WSAEOPNOTSUPP = 10045;

        /// WSAENOTSOCK -> 10038L
        public const int WSAENOTSOCK = 10038;

        /// WSAENOTEMPTY -> 10066L
        public const int WSAENOTEMPTY = 10066;

        /// WSAENOTCONN -> 10057L
        public const int WSAENOTCONN = 10057;

        /// WSAENOPROTOOPT -> 10042L
        public const int WSAENOPROTOOPT = 10042;

        /// WSAENOMORE -> 10102L
        public const int WSAENOMORE = 10102;

        /// WSAENOBUFS -> 10055L
        public const int WSAENOBUFS = 10055;

        /// WSAENETUNREACH -> 10051L
        public const int WSAENETUNREACH = 10051;

        /// WSAENETRESET -> 10052L
        public const int WSAENETRESET = 10052;

        /// WSAENETDOWN -> 10050L
        public const int WSAENETDOWN = 10050;

        /// WSAENAMETOOLONG -> 10063L
        public const int WSAENAMETOOLONG = 10063;

        /// WSAEMSGSIZE -> 10040L
        public const int WSAEMSGSIZE = 10040;

        /// WSAEMFILE -> 10024L
        public const int WSAEMFILE = 10024;

        /// WSAELOOP -> 10062L
        public const int WSAELOOP = 10062;

        /// WSAEISCONN -> 10056L
        public const int WSAEISCONN = 10056;

        /// WSAEINVALIDPROVIDER -> 10105L
        public const int WSAEINVALIDPROVIDER = 10105;

        /// WSAEINVALIDPROCTABLE -> 10104L
        public const int WSAEINVALIDPROCTABLE = 10104;

        /// WSAEINVAL -> 10022L
        public const int WSAEINVAL = 10022;

        /// WSAEINTR -> 10004L
        public const int WSAEINTR = 10004;

        /// WSAEINPROGRESS -> 10036L
        public const int WSAEINPROGRESS = 10036;

        /// WSAEHOSTUNREACH -> 10065L
        public const int WSAEHOSTUNREACH = 10065;

        /// WSAEHOSTDOWN -> 10064L
        public const int WSAEHOSTDOWN = 10064;

        /// WSAEFAULT -> 10014L
        public const int WSAEFAULT = 10014;

        /// WSAEDQUOT -> 10069L
        public const int WSAEDQUOT = 10069;

        /// WSAEDISCON -> 10101L
        public const int WSAEDISCON = 10101;

        /// WSAEDESTADDRREQ -> 10039L
        public const int WSAEDESTADDRREQ = 10039;

        /// WSAECONNRESET -> 10054L
        public const int WSAECONNRESET = 10054;

        /// WSAECONNREFUSED -> 10061L
        public const int WSAECONNREFUSED = 10061;

        /// WSAECONNABORTED -> 10053L
        public const int WSAECONNABORTED = 10053;

        /// WSAECANCELLED -> 10103L
        public const int WSAECANCELLED = 10103;

        /// WSAEBADF -> 10009L
        public const int WSAEBADF = 10009;

        /// WSAEALREADY -> 10037L
        public const int WSAEALREADY = 10037;

        /// WSAEAFNOSUPPORT -> 10047L
        public const int WSAEAFNOSUPPORT = 10047;

        /// WSAEADDRNOTAVAIL -> 10049L
        public const int WSAEADDRNOTAVAIL = 10049;

        /// WSAEADDRINUSE -> 10048L
        public const int WSAEADDRINUSE = 10048;

        /// WSAEACCES -> 10013L
        public const int WSAEACCES = 10013;

        /// WSADESCRIPTION_LEN -> 256
        public const int WSADESCRIPTION_LEN = 256;

        /// WSABASEERR -> 10000
        public const int WSABASEERR = 10000;

        /// WRITE_WATCH_FLAG_RESET -> 0x01
        public const int WRITE_WATCH_FLAG_RESET = 1;

        /// WRITE_OWNER -> (0x00080000L)
        public const int WRITE_OWNER = 524288;

        /// WRITE_DAC -> (0x00040000L)
        public const int WRITE_DAC = 262144;

        /// WRITE_COMPRESSION_INFO_VALID -> 0x00000010
        public const int WRITE_COMPRESSION_INFO_VALID = 16;

        /// WriteProfileString -> WriteProfileStringW
        /// Error generating expression: Value WriteProfileStringW is not resolved
        public const string WriteProfileString = "WriteProfileStringW";

        /// WriteProfileSection -> WriteProfileSectionW
        /// Error generating expression: Value WriteProfileSectionW is not resolved
        public const string WriteProfileSection = "WriteProfileSectionW";

        /// WritePrivateProfileStruct -> WritePrivateProfileStructW
        /// Error generating expression: Value WritePrivateProfileStructW is not resolved
        public const string WritePrivateProfileStruct = "WritePrivateProfileStructW";

        /// WritePrivateProfileString -> WritePrivateProfileStringW
        /// Error generating expression: Value WritePrivateProfileStringW is not resolved
        public const string WritePrivateProfileString = "WritePrivateProfileStringW";

        /// WritePrivateProfileSection -> WritePrivateProfileSectionW
        /// Error generating expression: Value WritePrivateProfileSectionW is not resolved
        public const string WritePrivateProfileSection = "WritePrivateProfileSectionW";

        /// WriteOnceDiskClassGuid -> GUID_DEVINTERFACE_WRITEONCEDISK
        /// Error generating expression: Value GUID_DEVINTERFACE_WRITEONCEDISK is not resolved
        public const string WriteOnceDiskClassGuid = "GUID_DEVINTERFACE_WRITEONCEDISK";

        /// WriteConsoleOutputCharacter -> WriteConsoleOutputCharacterW
        /// Error generating expression: Value WriteConsoleOutputCharacterW is not resolved
        public const string WriteConsoleOutputCharacter = "WriteConsoleOutputCharacterW";

        /// WriteConsoleOutput -> WriteConsoleOutputW
        /// Error generating expression: Value WriteConsoleOutputW is not resolved
        public const string WriteConsoleOutput = "WriteConsoleOutputW";

        /// WriteConsoleInput -> WriteConsoleInputW
        /// Error generating expression: Value WriteConsoleInputW is not resolved
        public const string WriteConsoleInput = "WriteConsoleInputW";

        /// WriteConsole -> WriteConsoleW
        /// Error generating expression: Value WriteConsoleW is not resolved
        public const string WriteConsole = "WriteConsoleW";

        /// WPF_SETMINPOSITION -> 0x0001
        public const int WPF_SETMINPOSITION = 1;

        /// WPF_RESTORETOMAXIMIZED -> 0x0002
        public const int WPF_RESTORETOMAXIMIZED = 2;

        /// WPF_ASYNCWINDOWPLACEMENT -> 0x0004
        public const int WPF_ASYNCWINDOWPLACEMENT = 4;

        /// WOM_OPEN -> MM_WOM_OPEN
        public const int WOM_OPEN = NativeConstants.MM_WOM_OPEN;

        /// WOM_DONE -> MM_WOM_DONE
        public const int WOM_DONE = NativeConstants.MM_WOM_DONE;

        /// WOM_CLOSE -> MM_WOM_CLOSE
        public const int WOM_CLOSE = NativeConstants.MM_WOM_CLOSE;

        /// WN_WINDOWS_ERROR -> ERROR_UNEXP_NET_ERR
        public const int WN_WINDOWS_ERROR = NativeConstants.ERROR_UNEXP_NET_ERR;

        /// WN_SUCCESS -> NO_ERROR
        public const int WN_SUCCESS = NativeConstants.NO_ERROR;

        /// WN_RETRY -> ERROR_RETRY
        public const int WN_RETRY = NativeConstants.ERROR_RETRY;

        /// WN_OUT_OF_MEMORY -> ERROR_NOT_ENOUGH_MEMORY
        public const int WN_OUT_OF_MEMORY = NativeConstants.ERROR_NOT_ENOUGH_MEMORY;

        /// WN_OPEN_FILES -> ERROR_OPEN_FILES
        public const int WN_OPEN_FILES = NativeConstants.ERROR_OPEN_FILES;

        /// WN_NO_NET_OR_BAD_PATH -> ERROR_NO_NET_OR_BAD_PATH
        public const int WN_NO_NET_OR_BAD_PATH = NativeConstants.ERROR_NO_NET_OR_BAD_PATH;

        /// WN_NO_NETWORK -> ERROR_NO_NETWORK
        public const int WN_NO_NETWORK = NativeConstants.ERROR_NO_NETWORK;

        /// WN_NO_MORE_ENTRIES -> ERROR_NO_MORE_ITEMS
        public const int WN_NO_MORE_ENTRIES = NativeConstants.ERROR_NO_MORE_ITEMS;

        /// WN_NO_MORE_DEVICES -> ERROR_NO_MORE_DEVICES
        public const int WN_NO_MORE_DEVICES = NativeConstants.ERROR_NO_MORE_DEVICES;

        /// WN_NO_ERROR -> NO_ERROR
        public const int WN_NO_ERROR = NativeConstants.NO_ERROR;

        /// WN_NOT_VALIDATED -> ERROR_NO_LOGON_SERVERS
        public const int WN_NOT_VALIDATED = NativeConstants.ERROR_NO_LOGON_SERVERS;

        /// WN_NOT_SUPPORTED -> ERROR_NOT_SUPPORTED
        public const int WN_NOT_SUPPORTED = NativeConstants.ERROR_NOT_SUPPORTED;

        /// WN_NOT_LOGGED_ON -> ERROR_NOT_LOGGED_ON
        public const int WN_NOT_LOGGED_ON = NativeConstants.ERROR_NOT_LOGGED_ON;

        /// WN_NOT_INITIALIZING -> ERROR_ALREADY_INITIALIZED
        public const int WN_NOT_INITIALIZING = NativeConstants.ERROR_ALREADY_INITIALIZED;

        /// WN_NOT_CONTAINER -> ERROR_NOT_CONTAINER
        public const int WN_NOT_CONTAINER = NativeConstants.ERROR_NOT_CONTAINER;

        /// WN_NOT_CONNECTED -> ERROR_NOT_CONNECTED
        public const int WN_NOT_CONNECTED = NativeConstants.ERROR_NOT_CONNECTED;

        /// WN_NOT_AUTHENTICATED -> ERROR_NOT_AUTHENTICATED
        public const int WN_NOT_AUTHENTICATED = NativeConstants.ERROR_NOT_AUTHENTICATED;

        /// WN_NET_ERROR -> ERROR_UNEXP_NET_ERR
        public const int WN_NET_ERROR = NativeConstants.ERROR_UNEXP_NET_ERR;

        /// WN_MORE_DATA -> ERROR_MORE_DATA
        public const int WN_MORE_DATA = NativeConstants.ERROR_MORE_DATA;

        /// WN_FUNCTION_BUSY -> ERROR_BUSY
        public const int WN_FUNCTION_BUSY = NativeConstants.ERROR_BUSY;

        /// WN_EXTENDED_ERROR -> ERROR_EXTENDED_ERROR
        public const int WN_EXTENDED_ERROR = NativeConstants.ERROR_EXTENDED_ERROR;

        /// WN_DEVICE_IN_USE -> ERROR_DEVICE_IN_USE
        public const int WN_DEVICE_IN_USE = NativeConstants.ERROR_DEVICE_IN_USE;

        /// WN_DEVICE_ERROR -> ERROR_GEN_FAILURE
        public const int WN_DEVICE_ERROR = NativeConstants.ERROR_GEN_FAILURE;

        /// WN_DEVICE_ALREADY_REMEMBERED -> ERROR_DEVICE_ALREADY_REMEMBERED
        public const int WN_DEVICE_ALREADY_REMEMBERED = NativeConstants.ERROR_DEVICE_ALREADY_REMEMBERED;

        /// WN_CONNECTION_CLOSED -> ERROR_CONNECTION_UNAVAIL
        public const int WN_CONNECTION_CLOSED = NativeConstants.ERROR_CONNECTION_UNAVAIL;

        /// WN_CONNECTED_OTHER_PASSWORD_DEFAULT -> ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT
        public const int WN_CONNECTED_OTHER_PASSWORD_DEFAULT = NativeConstants.ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT;

        /// WN_CONNECTED_OTHER_PASSWORD -> ERROR_CONNECTED_OTHER_PASSWORD
        public const int WN_CONNECTED_OTHER_PASSWORD = NativeConstants.ERROR_CONNECTED_OTHER_PASSWORD;

        /// WN_CANNOT_OPEN_PROFILE -> ERROR_CANNOT_OPEN_PROFILE
        public const int WN_CANNOT_OPEN_PROFILE = NativeConstants.ERROR_CANNOT_OPEN_PROFILE;

        /// WN_CANCEL -> ERROR_CANCELLED
        public const int WN_CANCEL = NativeConstants.ERROR_CANCELLED;

        /// WN_BAD_VALUE -> ERROR_INVALID_PARAMETER
        public const int WN_BAD_VALUE = NativeConstants.ERROR_INVALID_PARAMETER;

        /// WN_BAD_USER -> ERROR_BAD_USERNAME
        public const int WN_BAD_USER = NativeConstants.ERROR_BAD_USERNAME;

        /// WN_BAD_PROVIDER -> ERROR_BAD_PROVIDER
        public const int WN_BAD_PROVIDER = NativeConstants.ERROR_BAD_PROVIDER;

        /// WN_BAD_PROFILE -> ERROR_BAD_PROFILE
        public const int WN_BAD_PROFILE = NativeConstants.ERROR_BAD_PROFILE;

        /// WN_BAD_POINTER -> ERROR_INVALID_ADDRESS
        public const int WN_BAD_POINTER = NativeConstants.ERROR_INVALID_ADDRESS;

        /// WN_BAD_PASSWORD -> ERROR_INVALID_PASSWORD
        public const int WN_BAD_PASSWORD = NativeConstants.ERROR_INVALID_PASSWORD;

        /// WN_BAD_NETNAME -> ERROR_BAD_NET_NAME
        public const int WN_BAD_NETNAME = NativeConstants.ERROR_BAD_NET_NAME;

        /// WN_BAD_LOCALNAME -> ERROR_BAD_DEVICE
        public const int WN_BAD_LOCALNAME = NativeConstants.ERROR_BAD_DEVICE;

        /// WN_BAD_LEVEL -> ERROR_INVALID_LEVEL
        public const int WN_BAD_LEVEL = NativeConstants.ERROR_INVALID_LEVEL;

        /// WN_BAD_HANDLE -> ERROR_INVALID_HANDLE
        public const int WN_BAD_HANDLE = NativeConstants.ERROR_INVALID_HANDLE;

        /// WN_BAD_DEV_TYPE -> ERROR_BAD_DEV_TYPE
        public const int WN_BAD_DEV_TYPE = NativeConstants.ERROR_BAD_DEV_TYPE;

        /// WN_ALREADY_CONNECTED -> ERROR_ALREADY_ASSIGNED
        public const int WN_ALREADY_CONNECTED = NativeConstants.ERROR_ALREADY_ASSIGNED;

        /// WN_ACCESS_DENIED -> ERROR_ACCESS_DENIED
        public const int WN_ACCESS_DENIED = NativeConstants.ERROR_ACCESS_DENIED;

        /// WNNC_NET_YAHOO -> 0x002C0000
        public const int WNNC_NET_YAHOO = 2883584;

        /// WNNC_NET_VINES -> 0x00040000
        public const int WNNC_NET_VINES = 262144;

        /// WNNC_NET_TWINS -> 0x00240000
        public const int WNNC_NET_TWINS = 2359296;

        /// WNNC_NET_TERMSRV -> 0x00360000
        public const int WNNC_NET_TERMSRV = 3538944;

        /// WNNC_NET_SYMFONET -> 0x00150000
        public const int WNNC_NET_SYMFONET = 1376256;

        /// WNNC_NET_SUN_PC_NFS -> 0x00070000
        public const int WNNC_NET_SUN_PC_NFS = 458752;

        /// WNNC_NET_STAC -> 0x002A0000
        public const int WNNC_NET_STAC = 2752512;

        /// WNNC_NET_SRT -> 0x00370000
        public const int WNNC_NET_SRT = 3604480;

        /// WNNC_NET_SHIVA -> 0x00330000
        public const int WNNC_NET_SHIVA = 3342336;

        /// WNNC_NET_SERNET -> 0x001D0000
        public const int WNNC_NET_SERNET = 1900544;

        /// WNNC_NET_RIVERFRONT2 -> 0x001F0000
        public const int WNNC_NET_RIVERFRONT2 = 2031616;

        /// WNNC_NET_RIVERFRONT1 -> 0X001E0000
        public const int WNNC_NET_RIVERFRONT1 = 1966080;

        /// WNNC_NET_RDR2SAMPLE -> 0x00250000
        public const int WNNC_NET_RDR2SAMPLE = 2424832;

        /// WNNC_NET_QUINCY -> 0x00380000
        public const int WNNC_NET_QUINCY = 3670016;

        /// WNNC_NET_PROTSTOR -> 0x00210000
        public const int WNNC_NET_PROTSTOR = 2162688;

        /// WNNC_NET_POWERLAN -> 0x000F0000
        public const int WNNC_NET_POWERLAN = 983040;

        /// WNNC_NET_PATHWORKS -> 0x000D0000
        public const int WNNC_NET_PATHWORKS = 851968;

        /// WNNC_NET_OBJECT_DIRE -> 0x00300000
        public const int WNNC_NET_OBJECT_DIRE = 3145728;

        /// WNNC_NET_NETWARE -> 0x00030000
        public const int WNNC_NET_NETWARE = 196608;

        /// WNNC_NET_MSNET -> 0x00010000
        public const int WNNC_NET_MSNET = 65536;

        /// WNNC_NET_MASFAX -> 0x00310000
        public const int WNNC_NET_MASFAX = 3211264;

        /// WNNC_NET_MANGOSOFT -> 0x001C0000
        public const int WNNC_NET_MANGOSOFT = 1835008;

        /// WNNC_NET_LOCUS -> 0x00060000
        public const int WNNC_NET_LOCUS = 393216;

        /// WNNC_NET_LOCK -> 0x00350000
        public const int WNNC_NET_LOCK = 3473408;

        /// WNNC_NET_LIFENET -> 0x000E0000
        public const int WNNC_NET_LIFENET = 917504;

        /// WNNC_NET_LANTASTIC -> 0x000A0000
        public const int WNNC_NET_LANTASTIC = 655360;

        /// WNNC_NET_LANSTEP -> 0x00080000
        public const int WNNC_NET_LANSTEP = 524288;

        /// WNNC_NET_LANMAN -> 0x00020000
        public const int WNNC_NET_LANMAN = 131072;

        /// WNNC_NET_KNOWARE -> 0x002F0000
        public const int WNNC_NET_KNOWARE = 3080192;

        /// WNNC_NET_INTERGRAPH -> 0x00140000
        public const int WNNC_NET_INTERGRAPH = 1310720;

        /// WNNC_NET_IBMAL -> 0x00340000
        public const int WNNC_NET_IBMAL = 3407872;

        /// WNNC_NET_HOB_NFS -> 0x00320000
        public const int WNNC_NET_HOB_NFS = 3276800;

        /// WNNC_NET_FTP_NFS -> 0x000C0000
        public const int WNNC_NET_FTP_NFS = 786432;

        /// WNNC_NET_FRONTIER -> 0x00170000
        public const int WNNC_NET_FRONTIER = 1507328;

        /// WNNC_NET_FOXBAT -> 0x002B0000
        public const int WNNC_NET_FOXBAT = 2818048;

        /// WNNC_NET_FJ_REDIR -> 0x00220000
        public const int WNNC_NET_FJ_REDIR = 2228224;

        /// WNNC_NET_FARALLON -> 0x00120000
        public const int WNNC_NET_FARALLON = 1179648;

        /// WNNC_NET_EXTENDNET -> 0x00290000
        public const int WNNC_NET_EXTENDNET = 2686976;

        /// WNNC_NET_EXIFS -> 0x002D0000
        public const int WNNC_NET_EXIFS = 2949120;

        /// WNNC_NET_DOCUSPACE -> 0x001B0000
        public const int WNNC_NET_DOCUSPACE = 1769472;

        /// WNNC_NET_DISTINCT -> 0x00230000
        public const int WNNC_NET_DISTINCT = 2293760;

        /// WNNC_NET_DECORB -> 0x00200000
        public const int WNNC_NET_DECORB = 2097152;

        /// WNNC_NET_DCE -> 0x00190000
        public const int WNNC_NET_DCE = 1638400;

        /// WNNC_NET_DAV -> 0x002E0000
        public const int WNNC_NET_DAV = 3014656;

        /// WNNC_NET_CSC -> 0x00260000
        public const int WNNC_NET_CSC = 2490368;

        /// WNNC_NET_COGENT -> 0x00110000
        public const int WNNC_NET_COGENT = 1114112;

        /// WNNC_NET_CLEARCASE -> 0x00160000
        public const int WNNC_NET_CLEARCASE = 1441792;

        /// WNNC_NET_BWNFS -> 0x00100000
        public const int WNNC_NET_BWNFS = 1048576;

        /// WNNC_NET_BMC -> 0x00180000
        public const int WNNC_NET_BMC = 1572864;

        /// WNNC_NET_AVID -> 0x001A0000
        public const int WNNC_NET_AVID = 1703936;

        /// WNNC_NET_AS400 -> 0x000B0000
        public const int WNNC_NET_AS400 = 720896;

        /// WNNC_NET_APPLETALK -> 0x00130000
        public const int WNNC_NET_APPLETALK = 1245184;

        /// WNNC_NET_9TILES -> 0x00090000
        public const int WNNC_NET_9TILES = 589824;

        /// WNNC_NET_3IN1 -> 0x00270000
        public const int WNNC_NET_3IN1 = 2555904;

        /// WNNC_NET_10NET -> 0x00050000
        public const int WNNC_NET_10NET = 327680;

        /// WNNC_CRED_MANAGER -> 0xFFFF0000
        public const int WNNC_CRED_MANAGER = -65536;

        /// WNFMT_MULTILINE -> 0x01
        public const int WNFMT_MULTILINE = 1;

        /// WNFMT_INENUM -> 0x10
        public const int WNFMT_INENUM = 16;

        /// WNFMT_CONNECTION -> 0x20
        public const int WNFMT_CONNECTION = 32;

        /// WNFMT_ABBREVIATED -> 0x02
        public const int WNFMT_ABBREVIATED = 2;

        /// WNetUseConnection -> WNetUseConnectionW
        /// Error generating expression: Value WNetUseConnectionW is not resolved
        public const string WNetUseConnection = "WNetUseConnectionW";

        /// WNetRestoreConnection -> WNetRestoreConnectionW
        /// Error generating expression: Value WNetRestoreConnectionW is not resolved
        public const string WNetRestoreConnection = "WNetRestoreConnectionW";

        /// WNetOpenEnum -> WNetOpenEnumW
        /// Error generating expression: Value WNetOpenEnumW is not resolved
        public const string WNetOpenEnum = "WNetOpenEnumW";

        /// WNetGetUser -> WNetGetUserW
        /// Error generating expression: Value WNetGetUserW is not resolved
        public const string WNetGetUser = "WNetGetUserW";

        /// WNetGetUniversalName -> WNetGetUniversalNameW
        /// Error generating expression: Value WNetGetUniversalNameW is not resolved
        public const string WNetGetUniversalName = "WNetGetUniversalNameW";

        /// WNetGetResourceParent -> WNetGetResourceParentW
        /// Error generating expression: Value WNetGetResourceParentW is not resolved
        public const string WNetGetResourceParent = "WNetGetResourceParentW";

        /// WNetGetResourceInformation -> WNetGetResourceInformationW
        /// Error generating expression: Value WNetGetResourceInformationW is not resolved
        public const string WNetGetResourceInformation = "WNetGetResourceInformationW";

        /// WNetGetProviderName -> WNetGetProviderNameW
        /// Error generating expression: Value WNetGetProviderNameW is not resolved
        public const string WNetGetProviderName = "WNetGetProviderNameW";

        /// WNetGetNetworkInformation -> WNetGetNetworkInformationW
        /// Error generating expression: Value WNetGetNetworkInformationW is not resolved
        public const string WNetGetNetworkInformation = "WNetGetNetworkInformationW";

        /// WNetGetLastError -> WNetGetLastErrorW
        /// Error generating expression: Value WNetGetLastErrorW is not resolved
        public const string WNetGetLastError = "WNetGetLastErrorW";

        /// WNetGetConnection -> WNetGetConnectionW
        /// Error generating expression: Value WNetGetConnectionW is not resolved
        public const string WNetGetConnection = "WNetGetConnectionW";

        /// WNetEnumResource -> WNetEnumResourceW
        /// Error generating expression: Value WNetEnumResourceW is not resolved
        public const string WNetEnumResource = "WNetEnumResourceW";

        /// WNetDisconnectDialog1 -> WNetDisconnectDialog1W
        /// Error generating expression: Value WNetDisconnectDialog1W is not resolved
        public const string WNetDisconnectDialog1 = "WNetDisconnectDialog1W";

        /// WNetConnectionDialog1 -> WNetConnectionDialog1W
        /// Error generating expression: Value WNetConnectionDialog1W is not resolved
        public const string WNetConnectionDialog1 = "WNetConnectionDialog1W";

        /// WNetCancelConnection2 -> WNetCancelConnection2W
        /// Error generating expression: Value WNetCancelConnection2W is not resolved
        public const string WNetCancelConnection2 = "WNetCancelConnection2W";

        /// WNetCancelConnection -> WNetCancelConnectionW
        /// Error generating expression: Value WNetCancelConnectionW is not resolved
        public const string WNetCancelConnection = "WNetCancelConnectionW";

        /// WNetAddConnection3 -> WNetAddConnection3W
        /// Error generating expression: Value WNetAddConnection3W is not resolved
        public const string WNetAddConnection3 = "WNetAddConnection3W";

        /// WNetAddConnection2 -> WNetAddConnection2W
        /// Error generating expression: Value WNetAddConnection2W is not resolved
        public const string WNetAddConnection2 = "WNetAddConnection2W";

        /// WNetAddConnection -> WNetAddConnectionW
        /// Error generating expression: Value WNetAddConnectionW is not resolved
        public const string WNetAddConnection = "WNetAddConnectionW";

        /// WNCON_SLOWLINK -> 0x00000004
        public const int WNCON_SLOWLINK = 4;

        /// WNCON_NOTROUTED -> 0x00000002
        public const int WNCON_NOTROUTED = 2;

        /// WNCON_FORNETCARD -> 0x00000001
        public const int WNCON_FORNETCARD = 1;

        /// WNCON_DYNAMIC -> 0x00000008
        public const int WNCON_DYNAMIC = 8;

        /// WM_XBUTTONUP -> 0x020C
        public const int WM_XBUTTONUP = 524;

        /// WM_XBUTTONDOWN -> 0x020B
        public const int WM_XBUTTONDOWN = 523;

        /// WM_XBUTTONDBLCLK -> 0x020D
        public const int WM_XBUTTONDBLCLK = 525;

        /// WM_WTSSESSION_CHANGE -> 0x02B1
        public const int WM_WTSSESSION_CHANGE = 689;

        /// WM_WININICHANGE -> 0x001A
        public const int WM_WININICHANGE = 26;

        /// WM_WINDOWPOSCHANGING -> 0x0046
        public const int WM_WINDOWPOSCHANGING = 70;

        /// WM_WINDOWPOSCHANGED -> 0x0047
        public const int WM_WINDOWPOSCHANGED = 71;

        /// WM_VSCROLLCLIPBOARD -> 0x030A
        public const int WM_VSCROLLCLIPBOARD = 778;

        /// WM_VSCROLL -> 0x0115
        public const int WM_VSCROLL = 277;

        /// WM_VKEYTOITEM -> 0x002E
        public const int WM_VKEYTOITEM = 46;

        /// WM_USERCHANGED -> 0x0054
        public const int WM_USERCHANGED = 84;

        /// WM_USER -> 0x0400
        public const int WM_USER = 1024;

        /// WM_UPDATEUISTATE -> 0x0128
        public const int WM_UPDATEUISTATE = 296;

        /// WM_UNINITMENUPOPUP -> 0x0125
        public const int WM_UNINITMENUPOPUP = 293;

        /// WM_UNICHAR -> 0x0109
        public const int WM_UNICHAR = 265;

        /// WM_UNDO -> 0x0304
        public const int WM_UNDO = 772;

        /// WM_TIMER -> 0x0113
        public const int WM_TIMER = 275;

        /// WM_TIMECHANGE -> 0x001E
        public const int WM_TIMECHANGE = 30;

        /// WM_THEMECHANGED -> 0x031A
        public const int WM_THEMECHANGED = 794;

        /// WM_TCARD -> 0x0052
        public const int WM_TCARD = 82;

        /// WM_TABLET_LAST -> 0x02df
        public const int WM_TABLET_LAST = 735;

        /// WM_TABLET_FIRST -> 0x02c0
        public const int WM_TABLET_FIRST = 704;

        /// WM_SYSKEYUP -> 0x0105
        public const int WM_SYSKEYUP = 261;

        /// WM_SYSKEYDOWN -> 0x0104
        public const int WM_SYSKEYDOWN = 260;

        /// WM_SYSDEADCHAR -> 0x0107
        public const int WM_SYSDEADCHAR = 263;

        /// WM_SYSCOMMAND -> 0x0112
        public const int WM_SYSCOMMAND = 274;

        /// WM_SYSCOLORCHANGE -> 0x0015
        public const int WM_SYSCOLORCHANGE = 21;

        /// WM_SYSCHAR -> 0x0106
        public const int WM_SYSCHAR = 262;

        /// WM_SYNCPAINT -> 0x0088
        public const int WM_SYNCPAINT = 136;

        /// WM_STYLECHANGING -> 0x007C
        public const int WM_STYLECHANGING = 124;

        /// WM_STYLECHANGED -> 0x007D
        public const int WM_STYLECHANGED = 125;

        /// WM_SPOOLERSTATUS -> 0x002A
        public const int WM_SPOOLERSTATUS = 42;

        /// WM_SIZING -> 0x0214
        public const int WM_SIZING = 532;

        /// WM_SIZECLIPBOARD -> 0x030B
        public const int WM_SIZECLIPBOARD = 779;

        /// WM_SIZE -> 0x0005
        public const int WM_SIZE = 5;

        /// WM_SHOWWINDOW -> 0x0018
        public const int WM_SHOWWINDOW = 24;

        /// WM_SETTINGCHANGE -> WM_WININICHANGE
        public const int WM_SETTINGCHANGE = NativeConstants.WM_WININICHANGE;

        /// WM_SETTEXT -> 0x000C
        public const int WM_SETTEXT = 12;

        /// WM_SETREDRAW -> 0x000B
        public const int WM_SETREDRAW = 11;

        /// WM_SETICON -> 0x0080
        public const int WM_SETICON = 128;

        /// WM_SETHOTKEY -> 0x0032
        public const int WM_SETHOTKEY = 50;

        /// WM_SETFONT -> 0x0030
        public const int WM_SETFONT = 48;

        /// WM_SETFOCUS -> 0x0007
        public const int WM_SETFOCUS = 7;

        /// WM_SETCURSOR -> 0x0020
        public const int WM_SETCURSOR = 32;

        /// WM_RENDERFORMAT -> 0x0305
        public const int WM_RENDERFORMAT = 773;

        /// WM_RENDERALLFORMATS -> 0x0306
        public const int WM_RENDERALLFORMATS = 774;

        /// WM_RBUTTONUP -> 0x0205
        public const int WM_RBUTTONUP = 517;

        /// WM_RBUTTONDOWN -> 0x0204
        public const int WM_RBUTTONDOWN = 516;

        /// WM_RBUTTONDBLCLK -> 0x0206
        public const int WM_RBUTTONDBLCLK = 518;

        /// WM_QUIT -> 0x0012
        public const int WM_QUIT = 18;

        /// WM_QUEUESYNC -> 0x0023
        public const int WM_QUEUESYNC = 35;

        /// WM_QUERYUISTATE -> 0x0129
        public const int WM_QUERYUISTATE = 297;

        /// WM_QUERYOPEN -> 0x0013
        public const int WM_QUERYOPEN = 19;

        /// WM_QUERYNEWPALETTE -> 0x030F
        public const int WM_QUERYNEWPALETTE = 783;

        /// WM_QUERYENDSESSION -> 0x0011
        public const int WM_QUERYENDSESSION = 17;

        /// WM_QUERYDRAGICON -> 0x0037
        public const int WM_QUERYDRAGICON = 55;

        /// WM_PSD_YAFULLPAGERECT -> (WM_USER+6)
        public const int WM_PSD_YAFULLPAGERECT = (NativeConstants.WM_USER + 6);

        /// WM_PSD_PAGESETUPDLG -> (WM_USER  )
        public const int WM_PSD_PAGESETUPDLG = NativeConstants.WM_USER;

        /// WM_PSD_MINMARGINRECT -> (WM_USER+2)
        public const int WM_PSD_MINMARGINRECT = (NativeConstants.WM_USER + 2);

        /// WM_PSD_MARGINRECT -> (WM_USER+3)
        public const int WM_PSD_MARGINRECT = (NativeConstants.WM_USER + 3);

        /// WM_PSD_GREEKTEXTRECT -> (WM_USER+4)
        public const int WM_PSD_GREEKTEXTRECT = (NativeConstants.WM_USER + 4);

        /// WM_PSD_FULLPAGERECT -> (WM_USER+1)
        public const int WM_PSD_FULLPAGERECT = (NativeConstants.WM_USER + 1);

        /// WM_PSD_ENVSTAMPRECT -> (WM_USER+5)
        public const int WM_PSD_ENVSTAMPRECT = (NativeConstants.WM_USER + 5);

        /// WM_PRINTCLIENT -> 0x0318
        public const int WM_PRINTCLIENT = 792;

        /// WM_PRINT -> 0x0317
        public const int WM_PRINT = 791;

        /// WM_POWERBROADCAST -> 0x0218
        public const int WM_POWERBROADCAST = 536;

        /// WM_POWER -> 0x0048
        public const int WM_POWER = 72;

        /// WM_PENWINLAST -> 0x038F
        public const int WM_PENWINLAST = 911;

        /// WM_PENWINFIRST -> 0x0380
        public const int WM_PENWINFIRST = 896;

        /// WM_PASTE -> 0x0302
        public const int WM_PASTE = 770;

        /// WM_PARENTNOTIFY -> 0x0210
        public const int WM_PARENTNOTIFY = 528;

        /// WM_PALETTEISCHANGING -> 0x0310
        public const int WM_PALETTEISCHANGING = 784;

        /// WM_PALETTECHANGED -> 0x0311
        public const int WM_PALETTECHANGED = 785;

        /// WM_PAINTICON -> 0x0026
        public const int WM_PAINTICON = 38;

        /// WM_PAINTCLIPBOARD -> 0x0309
        public const int WM_PAINTCLIPBOARD = 777;

        /// WM_PAINT -> 0x000F
        public const int WM_PAINT = 15;

        /// WM_NULL -> 0x0000
        public const int WM_NULL = 0;

        /// WM_NOTIFYFORMAT -> 0x0055
        public const int WM_NOTIFYFORMAT = 85;

        /// WM_NOTIFY -> 0x004E
        public const int WM_NOTIFY = 78;

        /// WM_NEXTMENU -> 0x0213
        public const int WM_NEXTMENU = 531;

        /// WM_NEXTDLGCTL -> 0x0028
        public const int WM_NEXTDLGCTL = 40;

        /// WM_NCXBUTTONUP -> 0x00AC
        public const int WM_NCXBUTTONUP = 172;

        /// WM_NCXBUTTONDOWN -> 0x00AB
        public const int WM_NCXBUTTONDOWN = 171;

        /// WM_NCXBUTTONDBLCLK -> 0x00AD
        public const int WM_NCXBUTTONDBLCLK = 173;

        /// WM_NCRBUTTONUP -> 0x00A5
        public const int WM_NCRBUTTONUP = 165;

        /// WM_NCRBUTTONDOWN -> 0x00A4
        public const int WM_NCRBUTTONDOWN = 164;

        /// WM_NCRBUTTONDBLCLK -> 0x00A6
        public const int WM_NCRBUTTONDBLCLK = 166;

        /// WM_NCPAINT -> 0x0085
        public const int WM_NCPAINT = 133;

        /// WM_NCMOUSEMOVE -> 0x00A0
        public const int WM_NCMOUSEMOVE = 160;

        /// WM_NCMOUSELEAVE -> 0x02A2
        public const int WM_NCMOUSELEAVE = 674;

        /// WM_NCMOUSEHOVER -> 0x02A0
        public const int WM_NCMOUSEHOVER = 672;

        /// WM_NCMBUTTONUP -> 0x00A8
        public const int WM_NCMBUTTONUP = 168;

        /// WM_NCMBUTTONDOWN -> 0x00A7
        public const int WM_NCMBUTTONDOWN = 167;

        /// WM_NCMBUTTONDBLCLK -> 0x00A9
        public const int WM_NCMBUTTONDBLCLK = 169;

        /// WM_NCLBUTTONUP -> 0x00A2
        public const int WM_NCLBUTTONUP = 162;

        /// WM_NCLBUTTONDOWN -> 0x00A1
        public const int WM_NCLBUTTONDOWN = 161;

        /// WM_NCLBUTTONDBLCLK -> 0x00A3
        public const int WM_NCLBUTTONDBLCLK = 163;

        /// WM_NCHITTEST -> 0x0084
        public const int WM_NCHITTEST = 132;

        /// WM_NCDESTROY -> 0x0082
        public const int WM_NCDESTROY = 130;

        /// WM_NCCREATE -> 0x0081
        public const int WM_NCCREATE = 129;

        /// WM_NCCALCSIZE -> 0x0083
        public const int WM_NCCALCSIZE = 131;

        /// WM_NCACTIVATE -> 0x0086
        public const int WM_NCACTIVATE = 134;

        /// WM_MOVING -> 0x0216
        public const int WM_MOVING = 534;

        /// WM_MOVE -> 0x0003
        public const int WM_MOVE = 3;

        /// WM_MOUSEWHEEL -> 0x020A
        public const int WM_MOUSEWHEEL = 522;

        /// WM_MOUSEMOVE -> 0x0200
        public const int WM_MOUSEMOVE = 512;

        /// WM_MOUSELEAVE -> 0x02A3
        public const int WM_MOUSELEAVE = 675;

        /// WM_MOUSELAST -> 0x020D
        public const int WM_MOUSELAST = 525;

        /// WM_MOUSEHOVER -> 0x02A1
        public const int WM_MOUSEHOVER = 673;

        /// WM_MOUSEFIRST -> 0x0200
        public const int WM_MOUSEFIRST = 512;

        /// WM_MOUSEACTIVATE -> 0x0021
        public const int WM_MOUSEACTIVATE = 33;

        /// WM_MENUSELECT -> 0x011F
        public const int WM_MENUSELECT = 287;

        /// WM_MENURBUTTONUP -> 0x0122
        public const int WM_MENURBUTTONUP = 290;

        /// WM_MENUGETOBJECT -> 0x0124
        public const int WM_MENUGETOBJECT = 292;

        /// WM_MENUDRAG -> 0x0123
        public const int WM_MENUDRAG = 291;

        /// WM_MENUCOMMAND -> 0x0126
        public const int WM_MENUCOMMAND = 294;

        /// WM_MENUCHAR -> 0x0120
        public const int WM_MENUCHAR = 288;

        /// WM_MEASUREITEM -> 0x002C
        public const int WM_MEASUREITEM = 44;

        /// WM_MDITILE -> 0x0226
        public const int WM_MDITILE = 550;

        /// WM_MDISETMENU -> 0x0230
        public const int WM_MDISETMENU = 560;

        /// WM_MDIRESTORE -> 0x0223
        public const int WM_MDIRESTORE = 547;

        /// WM_MDIREFRESHMENU -> 0x0234
        public const int WM_MDIREFRESHMENU = 564;

        /// WM_MDINEXT -> 0x0224
        public const int WM_MDINEXT = 548;

        /// WM_MDIMAXIMIZE -> 0x0225
        public const int WM_MDIMAXIMIZE = 549;

        /// WM_MDIICONARRANGE -> 0x0228
        public const int WM_MDIICONARRANGE = 552;

        /// WM_MDIGETACTIVE -> 0x0229
        public const int WM_MDIGETACTIVE = 553;

        /// WM_MDIDESTROY -> 0x0221
        public const int WM_MDIDESTROY = 545;

        /// WM_MDICREATE -> 0x0220
        public const int WM_MDICREATE = 544;

        /// WM_MDICASCADE -> 0x0227
        public const int WM_MDICASCADE = 551;

        /// WM_MDIACTIVATE -> 0x0222
        public const int WM_MDIACTIVATE = 546;

        /// WM_MBUTTONUP -> 0x0208
        public const int WM_MBUTTONUP = 520;

        /// WM_MBUTTONDOWN -> 0x0207
        public const int WM_MBUTTONDOWN = 519;

        /// WM_MBUTTONDBLCLK -> 0x0209
        public const int WM_MBUTTONDBLCLK = 521;

        /// WM_LBUTTONUP -> 0x0202
        public const int WM_LBUTTONUP = 514;

        /// WM_LBUTTONDOWN -> 0x0201
        public const int WM_LBUTTONDOWN = 513;

        /// WM_LBUTTONDBLCLK -> 0x0203
        public const int WM_LBUTTONDBLCLK = 515;

        /// WM_KILLFOCUS -> 0x0008
        public const int WM_KILLFOCUS = 8;

        /// WM_KEYUP -> 0x0101
        public const int WM_KEYUP = 257;

        /// WM_KEYLAST -> 0x0109
        public const int WM_KEYLAST = 265;

        /// WM_KEYFIRST -> 0x0100
        public const int WM_KEYFIRST = 256;

        /// WM_KEYDOWN -> 0x0100
        public const int WM_KEYDOWN = 256;

        /// WM_INPUTLANGCHANGEREQUEST -> 0x0050
        public const int WM_INPUTLANGCHANGEREQUEST = 80;

        /// WM_INPUTLANGCHANGE -> 0x0051
        public const int WM_INPUTLANGCHANGE = 81;

        /// WM_INPUT -> 0x00FF
        public const int WM_INPUT = 255;

        /// WM_INITMENUPOPUP -> 0x0117
        public const int WM_INITMENUPOPUP = 279;

        /// WM_INITMENU -> 0x0116
        public const int WM_INITMENU = 278;

        /// WM_INITDIALOG -> 0x0110
        public const int WM_INITDIALOG = 272;

        /// WM_IME_STARTCOMPOSITION -> 0x010D
        public const int WM_IME_STARTCOMPOSITION = 269;

        /// WM_IME_SETCONTEXT -> 0x0281
        public const int WM_IME_SETCONTEXT = 641;

        /// WM_IME_SELECT -> 0x0285
        public const int WM_IME_SELECT = 645;

        /// WM_IME_REQUEST -> 0x0288
        public const int WM_IME_REQUEST = 648;

        /// WM_IME_NOTIFY -> 0x0282
        public const int WM_IME_NOTIFY = 642;

        /// WM_IME_KEYUP -> 0x0291
        public const int WM_IME_KEYUP = 657;

        /// WM_IME_KEYLAST -> 0x010F
        public const int WM_IME_KEYLAST = 271;

        /// WM_IME_KEYDOWN -> 0x0290
        public const int WM_IME_KEYDOWN = 656;

        /// WM_IME_ENDCOMPOSITION -> 0x010E
        public const int WM_IME_ENDCOMPOSITION = 270;

        /// WM_IME_CONTROL -> 0x0283
        public const int WM_IME_CONTROL = 643;

        /// WM_IME_COMPOSITIONFULL -> 0x0284
        public const int WM_IME_COMPOSITIONFULL = 644;

        /// WM_IME_COMPOSITION -> 0x010F
        public const int WM_IME_COMPOSITION = 271;

        /// WM_IME_CHAR -> 0x0286
        public const int WM_IME_CHAR = 646;

        /// WM_ICONERASEBKGND -> 0x0027
        public const int WM_ICONERASEBKGND = 39;

        /// WM_HSCROLLCLIPBOARD -> 0x030E
        public const int WM_HSCROLLCLIPBOARD = 782;

        /// WM_HSCROLL -> 0x0114
        public const int WM_HSCROLL = 276;

        /// WM_HOTKEY -> 0x0312
        public const int WM_HOTKEY = 786;

        /// WM_HELP -> 0x0053
        public const int WM_HELP = 83;

        /// WM_HANDHELDLAST -> 0x035F
        public const int WM_HANDHELDLAST = 863;

        /// WM_HANDHELDFIRST -> 0x0358
        public const int WM_HANDHELDFIRST = 856;

        /// WM_GETTEXTLENGTH -> 0x000E
        public const int WM_GETTEXTLENGTH = 14;

        /// WM_GETTEXT -> 0x000D
        public const int WM_GETTEXT = 13;

        /// WM_GETOBJECT -> 0x003D
        public const int WM_GETOBJECT = 61;

        /// WM_GETMINMAXINFO -> 0x0024
        public const int WM_GETMINMAXINFO = 36;

        /// WM_GETICON -> 0x007F
        public const int WM_GETICON = 127;

        /// WM_GETHOTKEY -> 0x0033
        public const int WM_GETHOTKEY = 51;

        /// WM_GETFONT -> 0x0031
        public const int WM_GETFONT = 49;

        /// WM_GETDLGCODE -> 0x0087
        public const int WM_GETDLGCODE = 135;

        /// WM_FONTCHANGE -> 0x001D
        public const int WM_FONTCHANGE = 29;

        /// WM_EXITSIZEMOVE -> 0x0232
        public const int WM_EXITSIZEMOVE = 562;

        /// WM_EXITMENULOOP -> 0x0212
        public const int WM_EXITMENULOOP = 530;

        /// WM_ERASEBKGND -> 0x0014
        public const int WM_ERASEBKGND = 20;

        /// WM_ENTERSIZEMOVE -> 0x0231
        public const int WM_ENTERSIZEMOVE = 561;

        /// WM_ENTERMENULOOP -> 0x0211
        public const int WM_ENTERMENULOOP = 529;

        /// WM_ENTERIDLE -> 0x0121
        public const int WM_ENTERIDLE = 289;

        /// WM_ENDSESSION -> 0x0016
        public const int WM_ENDSESSION = 22;

        /// WM_ENABLE -> 0x000A
        public const int WM_ENABLE = 10;

        /// WM_DROPFILES -> 0x0233
        public const int WM_DROPFILES = 563;

        /// WM_DRAWITEM -> 0x002B
        public const int WM_DRAWITEM = 43;

        /// WM_DRAWCLIPBOARD -> 0x0308
        public const int WM_DRAWCLIPBOARD = 776;

        /// WM_DISPLAYCHANGE -> 0x007E
        public const int WM_DISPLAYCHANGE = 126;

        /// WM_DEVMODECHANGE -> 0x001B
        public const int WM_DEVMODECHANGE = 27;

        /// WM_DEVICECHANGE -> 0x0219
        public const int WM_DEVICECHANGE = 537;

        /// WM_DESTROYCLIPBOARD -> 0x0307
        public const int WM_DESTROYCLIPBOARD = 775;

        /// WM_DESTROY -> 0x0002
        public const int WM_DESTROY = 2;

        /// WM_DELETEITEM -> 0x002D
        public const int WM_DELETEITEM = 45;

        /// WM_DEADCHAR -> 0x0103
        public const int WM_DEADCHAR = 259;

        /// WM_DDE_UNADVISE -> (WM_DDE_FIRST+3)
        public const int WM_DDE_UNADVISE = (NativeConstants.WM_DDE_FIRST + 3);

        /// WM_DDE_TERMINATE -> (WM_DDE_FIRST+1)
        public const int WM_DDE_TERMINATE = (NativeConstants.WM_DDE_FIRST + 1);

        /// WM_DDE_REQUEST -> (WM_DDE_FIRST+6)
        public const int WM_DDE_REQUEST = (NativeConstants.WM_DDE_FIRST + 6);

        /// WM_DDE_POKE -> (WM_DDE_FIRST+7)
        public const int WM_DDE_POKE = (NativeConstants.WM_DDE_FIRST + 7);

        /// WM_DDE_LAST -> (WM_DDE_FIRST+8)
        public const int WM_DDE_LAST = (NativeConstants.WM_DDE_FIRST + 8);

        /// WM_DDE_INITIATE -> (WM_DDE_FIRST)
        public const int WM_DDE_INITIATE = NativeConstants.WM_DDE_FIRST;

        /// WM_DDE_FIRST -> 0x03E0
        public const int WM_DDE_FIRST = 992;

        /// WM_DDE_EXECUTE -> (WM_DDE_FIRST+8)
        public const int WM_DDE_EXECUTE = (NativeConstants.WM_DDE_FIRST + 8);

        /// WM_DDE_DATA -> (WM_DDE_FIRST+5)
        public const int WM_DDE_DATA = (NativeConstants.WM_DDE_FIRST + 5);

        /// WM_DDE_ADVISE -> (WM_DDE_FIRST+2)
        public const int WM_DDE_ADVISE = (NativeConstants.WM_DDE_FIRST + 2);

        /// WM_DDE_ACK -> (WM_DDE_FIRST+4)
        public const int WM_DDE_ACK = (NativeConstants.WM_DDE_FIRST + 4);

        /// WM_CUT -> 0x0300
        public const int WM_CUT = 768;

        /// WM_CTLCOLORSTATIC -> 0x0138
        public const int WM_CTLCOLORSTATIC = 312;

        /// WM_CTLCOLORSCROLLBAR -> 0x0137
        public const int WM_CTLCOLORSCROLLBAR = 311;

        /// WM_CTLCOLORMSGBOX -> 0x0132
        public const int WM_CTLCOLORMSGBOX = 306;

        /// WM_CTLCOLORLISTBOX -> 0x0134
        public const int WM_CTLCOLORLISTBOX = 308;

        /// WM_CTLCOLOREDIT -> 0x0133
        public const int WM_CTLCOLOREDIT = 307;

        /// WM_CTLCOLORDLG -> 0x0136
        public const int WM_CTLCOLORDLG = 310;

        /// WM_CTLCOLORBTN -> 0x0135
        public const int WM_CTLCOLORBTN = 309;

        /// WM_CREATE -> 0x0001
        public const int WM_CREATE = 1;

        /// WM_COPYDATA -> 0x004A
        public const int WM_COPYDATA = 74;

        /// WM_COPY -> 0x0301
        public const int WM_COPY = 769;

        /// WM_CONTEXTMENU -> 0x007B
        public const int WM_CONTEXTMENU = 123;

        /// WM_COMPAREITEM -> 0x0039
        public const int WM_COMPAREITEM = 57;

        /// WM_COMPACTING -> 0x0041
        public const int WM_COMPACTING = 65;

        /// WM_COMMNOTIFY -> 0x0044
        public const int WM_COMMNOTIFY = 68;

        /// WM_COMMAND -> 0x0111
        public const int WM_COMMAND = 273;

        /// WM_CLOSE -> 0x0010
        public const int WM_CLOSE = 16;

        /// WM_CLEAR -> 0x0303
        public const int WM_CLEAR = 771;

        /// WM_CHOOSEFONT_SETLOGFONT -> (WM_USER + 101)
        public const int WM_CHOOSEFONT_SETLOGFONT = (NativeConstants.WM_USER + 101);

        /// WM_CHOOSEFONT_SETFLAGS -> (WM_USER + 102)
        public const int WM_CHOOSEFONT_SETFLAGS = (NativeConstants.WM_USER + 102);

        /// WM_CHOOSEFONT_GETLOGFONT -> (WM_USER + 1)
        public const int WM_CHOOSEFONT_GETLOGFONT = (NativeConstants.WM_USER + 1);

        /// WM_CHILDACTIVATE -> 0x0022
        public const int WM_CHILDACTIVATE = 34;

        /// WM_CHARTOITEM -> 0x002F
        public const int WM_CHARTOITEM = 47;

        /// WM_CHAR -> 0x0102
        public const int WM_CHAR = 258;

        /// WM_CHANGEUISTATE -> 0x0127
        public const int WM_CHANGEUISTATE = 295;

        /// WM_CHANGECBCHAIN -> 0x030D
        public const int WM_CHANGECBCHAIN = 781;

        /// WM_CAPTURECHANGED -> 0x0215
        public const int WM_CAPTURECHANGED = 533;

        /// WM_CANCELMODE -> 0x001F
        public const int WM_CANCELMODE = 31;

        /// WM_CANCELJOURNAL -> 0x004B
        public const int WM_CANCELJOURNAL = 75;

        /// WM_ASKCBFORMATNAME -> 0x030C
        public const int WM_ASKCBFORMATNAME = 780;

        /// WM_APPCOMMAND -> 0x0319
        public const int WM_APPCOMMAND = 793;

        /// WM_APP -> 0x8000
        public const int WM_APP = 32768;

        /// WM_AFXLAST -> 0x037F
        public const int WM_AFXLAST = 895;

        /// WM_AFXFIRST -> 0x0360
        public const int WM_AFXFIRST = 864;

        /// WM_ACTIVATEAPP -> 0x001C
        public const int WM_ACTIVATEAPP = 28;

        /// WM_ACTIVATE -> 0x0006
        public const int WM_ACTIVATE = 6;

        /// WMSZ_TOPRIGHT -> 5
        public const int WMSZ_TOPRIGHT = 5;

        /// WMSZ_TOPLEFT -> 4
        public const int WMSZ_TOPLEFT = 4;

        /// WMSZ_TOP -> 3
        public const int WMSZ_TOP = 3;

        /// WMSZ_RIGHT -> 2
        public const int WMSZ_RIGHT = 2;

        /// WMSZ_LEFT -> 1
        public const int WMSZ_LEFT = 1;

        /// WMSZ_BOTTOMRIGHT -> 8
        public const int WMSZ_BOTTOMRIGHT = 8;

        /// WMSZ_BOTTOMLEFT -> 7
        public const int WMSZ_BOTTOMLEFT = 7;

        /// WMSZ_BOTTOM -> 6
        public const int WMSZ_BOTTOM = 6;

        /// WIZ_CYDLG -> 140
        public const int WIZ_CYDLG = 140;

        /// WIZ_CXDLG -> 276
        public const int WIZ_CXDLG = 276;

        /// WIZ_CXBMP -> 80
        public const int WIZ_CXBMP = 80;

        /// WIZ_BODYX -> 92
        public const int WIZ_BODYX = 92;

        /// WIZ_BODYCX -> 184
        public const int WIZ_BODYCX = 184;

        /// WINVER -> 0x0600
        public const int WINVER = 1536;

        /// WINUSERAPI -> DECLSPEC_IMPORT
        public const string WINUSERAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WINSTA_WRITEATTRIBUTES -> 0x0010L
        public const int WINSTA_WRITEATTRIBUTES = 16;

        /// WINSTA_READSCREEN -> 0x0200L
        public const int WINSTA_READSCREEN = 512;

        /// WINSTA_READATTRIBUTES -> 0x0002L
        public const int WINSTA_READATTRIBUTES = 2;

        /// WINSTA_EXITWINDOWS -> 0x0040L
        public const int WINSTA_EXITWINDOWS = 64;

        /// WINSTA_ENUMERATE -> 0x0100L
        public const int WINSTA_ENUMERATE = 256;

        /// WINSTA_ENUMDESKTOPS -> 0x0001L
        public const int WINSTA_ENUMDESKTOPS = 1;

        /// WINSTA_CREATEDESKTOP -> 0x0008L
        public const int WINSTA_CREATEDESKTOP = 8;

        /// WINSTA_ALL_ACCESS -> (WINSTA_ENUMDESKTOPS  | WINSTA_READATTRIBUTES  | WINSTA_ACCESSCLIPBOARD |                                      WINSTA_CREATEDESKTOP | WINSTA_WRITEATTRIBUTES | WINSTA_ACCESSGLOBALATOMS |                                      WINSTA_EXITWINDOWS   | WINSTA_ENUMERATE       | WINSTA_READSCREEN)
        public const int WINSTA_ALL_ACCESS = (NativeConstants.WINSTA_ENUMDESKTOPS
                    | (NativeConstants.WINSTA_READATTRIBUTES
                    | (NativeConstants.WINSTA_ACCESSCLIPBOARD
                    | (NativeConstants.WINSTA_CREATEDESKTOP
                    | (NativeConstants.WINSTA_WRITEATTRIBUTES
                    | (NativeConstants.WINSTA_ACCESSGLOBALATOMS
                    | (NativeConstants.WINSTA_EXITWINDOWS
                    | (NativeConstants.WINSTA_ENUMERATE | NativeConstants.WINSTA_READSCREEN))))))));

        /// WINSTA_ACCESSGLOBALATOMS -> 0x0020L
        public const int WINSTA_ACCESSGLOBALATOMS = 32;

        /// WINSTA_ACCESSCLIPBOARD -> 0x0004L
        public const int WINSTA_ACCESSCLIPBOARD = 4;

        /// WINSPOOLAPI -> DECLSPEC_IMPORT
        public const string WINSPOOLAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WINSHELLAPI -> DECLSPEC_IMPORT
        public const string WINSHELLAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WINPERF_LOG_VERBOSE -> 3
        public const int WINPERF_LOG_VERBOSE = 3;

        /// WINPERF_LOG_USER -> 1
        public const int WINPERF_LOG_USER = 1;

        /// WINPERF_LOG_NONE -> 0
        public const int WINPERF_LOG_NONE = 0;

        /// WINPERF_LOG_DEBUG -> 2
        public const int WINPERF_LOG_DEBUG = 2;

        /// WINMMAPI -> DECLSPEC_IMPORT
        public const string WINMMAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WININETINFO_OPTION_LOCK_HANDLE -> 65534
        public const int WININETINFO_OPTION_LOCK_HANDLE = 65534;

        /// WinHelp -> WinHelpW
        /// Error generating expression: Value WinHelpW is not resolved
        public const string WinHelp = "WinHelpW";

        /// WINGDIAPI -> DECLSPEC_IMPORT
        public const string WINGDIAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WinExecError -> WinExecErrorW
        /// Error generating expression: Value WinExecErrorW is not resolved
        public const string WinExecError = "WinExecErrorW";

        /// WINEVENT_SKIPOWNTHREAD -> 0x0001
        public const int WINEVENT_SKIPOWNTHREAD = 1;

        /// WINEVENT_SKIPOWNPROCESS -> 0x0002
        public const int WINEVENT_SKIPOWNPROCESS = 2;

        /// WINEVENT_OUTOFCONTEXT -> 0x0000
        public const int WINEVENT_OUTOFCONTEXT = 0;

        /// WINEVENT_INCONTEXT -> 0x0004
        public const int WINEVENT_INCONTEXT = 4;

        /// WINDOW_BUFFER_SIZE_EVENT -> 0x0004
        public const int WINDOW_BUFFER_SIZE_EVENT = 4;

        /// WINDING -> 2
        public const int WINDING = 2;

        /// WINCRYPT32STRINGAPI -> WINCRYPT32API
        public const string WINCRYPT32STRINGAPI = NativeConstants.WINCRYPT32API;

        /// WINCRYPT32API -> DECLSPEC_IMPORT
        public const string WINCRYPT32API = NativeConstants.DECLSPEC_IMPORT;

        /// WINCOMMDLGAPI -> DECLSPEC_IMPORT
        public const string WINCOMMDLGAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WINCOMMCTRLAPI -> DECLSPEC_IMPORT
        public const string WINCOMMCTRLAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WINBASEAPI -> DECLSPEC_IMPORT
        public const string WINBASEAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WINAPI_INLINE -> WINAPI
        public const string WINAPI_INLINE = NativeConstants.WINAPI;

        /// WINAPIV -> __cdecl
        /// Error generating expression: Value __cdecl is not resolved
        public const string WINAPIV = "__cdecl";

        /// WINAPI -> __winapi
        /// Error generating expression: Value __winapi is not resolved
        public const string WINAPI = "__winapi";

        /// WINADVAPI -> DECLSPEC_IMPORT
        public const string WINADVAPI = NativeConstants.DECLSPEC_IMPORT;

        /// WIN31_CLASS -> NULL
        public const string WIN31_CLASS = NativeConstants.NULL;

        /// WIM_OPEN -> MM_WIM_OPEN
        public const int WIM_OPEN = NativeConstants.MM_WIM_OPEN;

        /// WIM_DATA -> MM_WIM_DATA
        public const int WIM_DATA = NativeConstants.MM_WIM_DATA;

        /// WIM_CLOSE -> MM_WIM_CLOSE
        public const int WIM_CLOSE = NativeConstants.MM_WIM_CLOSE;

        /// WH_SYSMSGFILTER -> 6
        public const int WH_SYSMSGFILTER = 6;

        /// WH_SHELL -> 10
        public const int WH_SHELL = 10;

        /// WH_MSGFILTER -> (-1)
        public const int WH_MSGFILTER = -1;

        /// WH_MOUSE_LL -> 14
        public const int WH_MOUSE_LL = 14;

        /// WH_MOUSE -> 7
        public const int WH_MOUSE = 7;

        /// WH_MINHOOK -> WH_MIN
        public const int WH_MINHOOK = NativeConstants.WH_MIN;

        /// WH_MIN -> (-1)
        public const int WH_MIN = -1;

        /// WH_MAXHOOK -> WH_MAX
        public const int WH_MAXHOOK = NativeConstants.WH_MAX;

        /// WH_MAX -> 14
        public const int WH_MAX = 14;

        /// WH_KEYBOARD_LL -> 13
        public const int WH_KEYBOARD_LL = 13;

        /// WH_KEYBOARD -> 2
        public const int WH_KEYBOARD = 2;

        /// WH_JOURNALRECORD -> 0
        public const int WH_JOURNALRECORD = 0;

        /// WH_JOURNALPLAYBACK -> 1
        public const int WH_JOURNALPLAYBACK = 1;

        /// WH_GETMESSAGE -> 3
        public const int WH_GETMESSAGE = 3;

        /// WH_FOREGROUNDIDLE -> 11
        public const int WH_FOREGROUNDIDLE = 11;

        /// WH_DEBUG -> 9
        public const int WH_DEBUG = 9;

        /// WH_CBT -> 5
        public const int WH_CBT = 5;

        /// WH_CALLWNDPROCRET -> 12
        public const int WH_CALLWNDPROCRET = 12;

        /// WH_CALLWNDPROC -> 4
        public const int WH_CALLWNDPROC = 4;

        /// WHITE_PEN -> 6
        public const int WHITE_PEN = 6;

        /// WHITE_BRUSH -> 0
        public const int WHITE_BRUSH = 0;

        /// WHITEONBLACK -> 2
        public const int WHITEONBLACK = 2;

        /// WHEEL_PAGESCROLL -> (UINT_MAX)
        public const int WHEEL_PAGESCROLL = NativeConstants.UINT_MAX;

        /// WHEEL_DELTA -> 120
        public const int WHEEL_DELTA = 120;

        /// WHDR_PREPARED -> 0x00000002
        public const int WHDR_PREPARED = 2;

        /// WHDR_INQUEUE -> 0x00000010
        public const int WHDR_INQUEUE = 16;

        /// WHDR_ENDLOOP -> 0x00000008
        public const int WHDR_ENDLOOP = 8;

        /// WHDR_DONE -> 0x00000001
        public const int WHDR_DONE = 1;

        /// WHDR_BEGINLOOP -> 0x00000004
        public const int WHDR_BEGINLOOP = 4;

        /// WGL_SWAP_UNDERLAY9 -> 0x01000000
        public const int WGL_SWAP_UNDERLAY9 = 16777216;

        /// WGL_SWAP_UNDERLAY8 -> 0x00800000
        public const int WGL_SWAP_UNDERLAY8 = 8388608;

        /// WGL_SWAP_UNDERLAY7 -> 0x00400000
        public const int WGL_SWAP_UNDERLAY7 = 4194304;

        /// WGL_SWAP_UNDERLAY6 -> 0x00200000
        public const int WGL_SWAP_UNDERLAY6 = 2097152;

        /// WGL_SWAP_UNDERLAY5 -> 0x00100000
        public const int WGL_SWAP_UNDERLAY5 = 1048576;

        /// WGL_SWAP_UNDERLAY4 -> 0x00080000
        public const int WGL_SWAP_UNDERLAY4 = 524288;

        /// WGL_SWAP_UNDERLAY3 -> 0x00040000
        public const int WGL_SWAP_UNDERLAY3 = 262144;

        /// WGL_SWAP_UNDERLAY2 -> 0x00020000
        public const int WGL_SWAP_UNDERLAY2 = 131072;

        /// WGL_SWAP_UNDERLAY15 -> 0x40000000
        public const int WGL_SWAP_UNDERLAY15 = 1073741824;

        /// WGL_SWAP_UNDERLAY14 -> 0x20000000
        public const int WGL_SWAP_UNDERLAY14 = 536870912;

        /// WGL_SWAP_UNDERLAY13 -> 0x10000000
        public const int WGL_SWAP_UNDERLAY13 = 268435456;

        /// WGL_SWAP_UNDERLAY12 -> 0x08000000
        public const int WGL_SWAP_UNDERLAY12 = 134217728;

        /// WGL_SWAP_UNDERLAY11 -> 0x04000000
        public const int WGL_SWAP_UNDERLAY11 = 67108864;

        /// WGL_SWAP_UNDERLAY10 -> 0x02000000
        public const int WGL_SWAP_UNDERLAY10 = 33554432;

        /// WGL_SWAP_UNDERLAY1 -> 0x00010000
        public const int WGL_SWAP_UNDERLAY1 = 65536;

        /// WGL_SWAP_OVERLAY9 -> 0x00000200
        public const int WGL_SWAP_OVERLAY9 = 512;

        /// WGL_SWAP_OVERLAY8 -> 0x00000100
        public const int WGL_SWAP_OVERLAY8 = 256;

        /// WGL_SWAP_OVERLAY7 -> 0x00000080
        public const int WGL_SWAP_OVERLAY7 = 128;

        /// WGL_SWAP_OVERLAY6 -> 0x00000040
        public const int WGL_SWAP_OVERLAY6 = 64;

        /// WGL_SWAP_OVERLAY5 -> 0x00000020
        public const int WGL_SWAP_OVERLAY5 = 32;

        /// WGL_SWAP_OVERLAY4 -> 0x00000010
        public const int WGL_SWAP_OVERLAY4 = 16;

        /// WGL_SWAP_OVERLAY3 -> 0x00000008
        public const int WGL_SWAP_OVERLAY3 = 8;

        /// WGL_SWAP_OVERLAY2 -> 0x00000004
        public const int WGL_SWAP_OVERLAY2 = 4;

        /// WGL_SWAP_OVERLAY15 -> 0x00008000
        public const int WGL_SWAP_OVERLAY15 = 32768;

        /// WGL_SWAP_OVERLAY14 -> 0x00004000
        public const int WGL_SWAP_OVERLAY14 = 16384;

        /// WGL_SWAP_OVERLAY13 -> 0x00002000
        public const int WGL_SWAP_OVERLAY13 = 8192;

        /// WGL_SWAP_OVERLAY12 -> 0x00001000
        public const int WGL_SWAP_OVERLAY12 = 4096;

        /// WGL_SWAP_OVERLAY11 -> 0x00000800
        public const int WGL_SWAP_OVERLAY11 = 2048;

        /// WGL_SWAP_OVERLAY10 -> 0x00000400
        public const int WGL_SWAP_OVERLAY10 = 1024;

        /// WGL_SWAP_OVERLAY1 -> 0x00000002
        public const int WGL_SWAP_OVERLAY1 = 2;

        /// WGL_SWAP_MAIN_PLANE -> 0x00000001
        public const int WGL_SWAP_MAIN_PLANE = 1;

        /// WGL_SWAPMULTIPLE_MAX -> 16
        public const int WGL_SWAPMULTIPLE_MAX = 16;

        /// WGL_FONT_POLYGONS -> 1
        public const int WGL_FONT_POLYGONS = 1;

        /// WGL_FONT_LINES -> 0
        public const int WGL_FONT_LINES = 0;

        /// wglUseFontOutlines -> wglUseFontOutlinesW
        /// Error generating expression: Value wglUseFontOutlinesW is not resolved
        public const string wglUseFontOutlines = "wglUseFontOutlinesW";

        /// wglUseFontBitmaps -> wglUseFontBitmapsW
        /// Error generating expression: Value wglUseFontBitmapsW is not resolved
        public const string wglUseFontBitmaps = "wglUseFontBitmapsW";

        /// WDT_REMOTE_CALL -> ( 0x52746457 )
        public const int WDT_REMOTE_CALL = 1383359575;

        /// WDT_INPROC_CALL -> ( 0x48746457 )
        public const int WDT_INPROC_CALL = 1215587415;

        /// WDT_INPROC64_CALL -> ( 0x50746457 )
        public const int WDT_INPROC64_CALL = 1349805143;

        /// WC_SEPCHARS -> 0x00000020
        public const int WC_SEPCHARS = 32;

        /// WC_NO_BEST_FIT_CHARS -> 0x00000400
        public const int WC_NO_BEST_FIT_CHARS = 1024;

        /// WC_DISCARDNS -> 0x00000010
        public const int WC_DISCARDNS = 16;

        /// WC_DEFAULTCHAR -> 0x00000040
        public const int WC_DEFAULTCHAR = 64;

        /// WC_COMPOSITECHECK -> 0x00000200
        public const int WC_COMPOSITECHECK = 512;

        /// WB_RIGHT -> 1
        public const int WB_RIGHT = 1;

        /// WB_LEFT -> 0
        public const int WB_LEFT = 0;

        /// WB_ISDELIMITER -> 2
        public const int WB_ISDELIMITER = 2;

        /// WA_INACTIVE -> 0
        public const int WA_INACTIVE = 0;

        /// WA_CLICKACTIVE -> 2
        public const int WA_CLICKACTIVE = 2;

        /// WA_ACTIVE -> 1
        public const int WA_ACTIVE = 1;

        /// WAVE_MAPPER -> ((UINT)-1)
        /// Error generating expression: Value UINT is not resolved
        public const string WAVE_MAPPER = "((UINT)-1)";

        /// WAVE_MAPPED -> 0x0004
        public const int WAVE_MAPPED = 4;

        /// WAVE_INVALIDFORMAT -> 0x00000000
        public const int WAVE_INVALIDFORMAT = 0;

        /// WAVE_FORMAT_QUERY -> 0x0001
        public const int WAVE_FORMAT_QUERY = 1;

        /// WAVE_FORMAT_PCM -> 1
        public const int WAVE_FORMAT_PCM = 1;

        /// WAVE_FORMAT_DIRECT_QUERY -> (WAVE_FORMAT_QUERY | WAVE_FORMAT_DIRECT)
        public const int WAVE_FORMAT_DIRECT_QUERY = (NativeConstants.WAVE_FORMAT_QUERY | NativeConstants.WAVE_FORMAT_DIRECT);

        /// WAVE_FORMAT_DIRECT -> 0x0008
        public const int WAVE_FORMAT_DIRECT = 8;

        /// WAVE_FORMAT_96S16 -> 0x00080000
        public const int WAVE_FORMAT_96S16 = 524288;

        /// WAVE_FORMAT_96S08 -> 0x00020000
        public const int WAVE_FORMAT_96S08 = 131072;

        /// WAVE_FORMAT_96M16 -> 0x00040000
        public const int WAVE_FORMAT_96M16 = 262144;

        /// WAVE_FORMAT_96M08 -> 0x00010000
        public const int WAVE_FORMAT_96M08 = 65536;

        /// WAVE_FORMAT_4S16 -> 0x00000800
        public const int WAVE_FORMAT_4S16 = 2048;

        /// WAVE_FORMAT_4S08 -> 0x00000200
        public const int WAVE_FORMAT_4S08 = 512;

        /// WAVE_FORMAT_4M16 -> 0x00000400
        public const int WAVE_FORMAT_4M16 = 1024;

        /// WAVE_FORMAT_4M08 -> 0x00000100
        public const int WAVE_FORMAT_4M08 = 256;

        /// WAVE_FORMAT_48S16 -> 0x00008000
        public const int WAVE_FORMAT_48S16 = 32768;

        /// WAVE_FORMAT_48S08 -> 0x00002000
        public const int WAVE_FORMAT_48S08 = 8192;

        /// WAVE_FORMAT_48M16 -> 0x00004000
        public const int WAVE_FORMAT_48M16 = 16384;

        /// WAVE_FORMAT_48M08 -> 0x00001000
        public const int WAVE_FORMAT_48M08 = 4096;

        /// WAVE_FORMAT_44S16 -> 0x00000800
        public const int WAVE_FORMAT_44S16 = 2048;

        /// WAVE_FORMAT_44S08 -> 0x00000200
        public const int WAVE_FORMAT_44S08 = 512;

        /// WAVE_FORMAT_44M16 -> 0x00000400
        public const int WAVE_FORMAT_44M16 = 1024;

        /// WAVE_FORMAT_44M08 -> 0x00000100
        public const int WAVE_FORMAT_44M08 = 256;

        /// WAVE_FORMAT_2S16 -> 0x00000080
        public const int WAVE_FORMAT_2S16 = 128;

        /// WAVE_FORMAT_2S08 -> 0x00000020
        public const int WAVE_FORMAT_2S08 = 32;

        /// WAVE_FORMAT_2M16 -> 0x00000040
        public const int WAVE_FORMAT_2M16 = 64;

        /// WAVE_FORMAT_2M08 -> 0x00000010
        public const int WAVE_FORMAT_2M08 = 16;

        /// WAVE_FORMAT_1S16 -> 0x00000008
        public const int WAVE_FORMAT_1S16 = 8;

        /// WAVE_FORMAT_1S08 -> 0x00000002
        public const int WAVE_FORMAT_1S08 = 2;

        /// WAVE_FORMAT_1M16 -> 0x00000004
        public const int WAVE_FORMAT_1M16 = 4;

        /// WAVE_FORMAT_1M08 -> 0x00000001
        public const int WAVE_FORMAT_1M08 = 1;

        /// WAVE_ALLOWSYNC -> 0x0002
        public const int WAVE_ALLOWSYNC = 2;

        /// WAVERR_UNPREPARED -> (WAVERR_BASE + 2)
        public const int WAVERR_UNPREPARED = (NativeConstants.WAVERR_BASE + 2);

        /// WAVERR_SYNC -> (WAVERR_BASE + 3)
        public const int WAVERR_SYNC = (NativeConstants.WAVERR_BASE + 3);

        /// WAVERR_STILLPLAYING -> (WAVERR_BASE + 1)
        public const int WAVERR_STILLPLAYING = (NativeConstants.WAVERR_BASE + 1);

        /// WAVERR_LASTERROR -> (WAVERR_BASE + 3)
        public const int WAVERR_LASTERROR = (NativeConstants.WAVERR_BASE + 3);

        /// WAVERR_BASE -> 32
        public const int WAVERR_BASE = 32;

        /// WAVERR_BADFORMAT -> (WAVERR_BASE + 0)
        public const int WAVERR_BADFORMAT = (NativeConstants.WAVERR_BASE + 0);

        /// waveOutGetErrorText -> waveOutGetErrorTextW
        /// Error generating expression: Value waveOutGetErrorTextW is not resolved
        public const string waveOutGetErrorText = "waveOutGetErrorTextW";

        /// waveOutGetDevCaps -> waveOutGetDevCapsW
        /// Error generating expression: Value waveOutGetDevCapsW is not resolved
        public const string waveOutGetDevCaps = "waveOutGetDevCapsW";

        /// waveInGetErrorText -> waveInGetErrorTextW
        /// Error generating expression: Value waveInGetErrorTextW is not resolved
        public const string waveInGetErrorText = "waveInGetErrorTextW";

        /// waveInGetDevCaps -> waveInGetDevCapsW
        /// Error generating expression: Value waveInGetDevCapsW is not resolved
        public const string waveInGetDevCaps = "waveInGetDevCapsW";

        /// WAVECAPS_VOLUME -> 0x0004
        public const int WAVECAPS_VOLUME = 4;

        /// WAVECAPS_SYNC -> 0x0010
        public const int WAVECAPS_SYNC = 16;

        /// WAVECAPS_SAMPLEACCURATE -> 0x0020
        public const int WAVECAPS_SAMPLEACCURATE = 32;

        /// WAVECAPS_PLAYBACKRATE -> 0x0002
        public const int WAVECAPS_PLAYBACKRATE = 2;

        /// WAVECAPS_PITCH -> 0x0001
        public const int WAVECAPS_PITCH = 1;

        /// WAVECAPS_LRVOLUME -> 0x0008
        public const int WAVECAPS_LRVOLUME = 8;

        /// WARNING_IPSEC_QM_POLICY_PRUNED -> 13025L
        public const int WARNING_IPSEC_QM_POLICY_PRUNED = 13025;

        /// WARNING_IPSEC_MM_POLICY_PRUNED -> 13024L
        public const int WARNING_IPSEC_MM_POLICY_PRUNED = 13024;

        /// WAIT_TIMEOUT -> 258L
        public const int WAIT_TIMEOUT = 258;

        /// WAIT_OBJECT_0 -> ((STATUS_WAIT_0 ) + 0 )
        public const string WAIT_OBJECT_0 = NativeConstants.STATUS_WAIT_0;

        /// WAIT_IO_COMPLETION -> STATUS_USER_APC
        public const string WAIT_IO_COMPLETION = NativeConstants.STATUS_USER_APC;

        /// WAIT_ABANDONED_0 -> ((STATUS_ABANDONED_WAIT_0 ) + 0 )
        public const string WAIT_ABANDONED_0 = NativeConstants.STATUS_ABANDONED_WAIT_0;

        /// WAIT_ABANDONED -> ((STATUS_ABANDONED_WAIT_0 ) + 0 )
        public const string WAIT_ABANDONED = NativeConstants.STATUS_ABANDONED_WAIT_0;

        /// WaitNamedPipe -> WaitNamedPipeW
        /// Error generating expression: Value WaitNamedPipeW is not resolved
        public const string WaitNamedPipe = "WaitNamedPipeW";
    }

}
