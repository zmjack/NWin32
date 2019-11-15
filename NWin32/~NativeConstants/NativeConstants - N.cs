namespace NWin32
{
    public partial class NativeConstants
    {

        /// N_TSHIFT -> 2
        public const int N_TSHIFT = 2;

        /// N_TMASK2 -> 0x00F0
        public const int N_TMASK2 = 240;

        /// N_TMASK1 -> 0x00C0
        public const int N_TMASK1 = 192;

        /// N_TMASK -> 0x0030
        public const int N_TMASK = 48;

        /// N_BTSHFT -> 4
        public const int N_BTSHFT = 4;

        /// N_BTMASK -> 0x000F
        public const int N_BTMASK = 15;

        /// NUM_DISCHARGE_POLICIES -> 4
        public const int NUM_DISCHARGE_POLICIES = 4;

        /// NUMRESERVED -> 106
        public const int NUMRESERVED = 106;

        /// NUMPRS_USE_ALL -> 0x1000
        public const int NUMPRS_USE_ALL = 4096;

        /// NUMPRS_TRAILING_WHITE -> 0x0002
        public const int NUMPRS_TRAILING_WHITE = 2;

        /// NUMPRS_TRAILING_PLUS -> 0x0008
        public const int NUMPRS_TRAILING_PLUS = 8;

        /// NUMPRS_TRAILING_MINUS -> 0x0020
        public const int NUMPRS_TRAILING_MINUS = 32;

        /// NUMPRS_THOUSANDS -> 0x0200
        public const int NUMPRS_THOUSANDS = 512;

        /// NUMPRS_STD -> 0x1FFF
        public const int NUMPRS_STD = 8191;

        /// NUMPRS_PARENS -> 0x0080
        public const int NUMPRS_PARENS = 128;

        /// NUMPRS_NEG -> 0x10000
        public const int NUMPRS_NEG = 65536;

        /// NUMPRS_LEADING_WHITE -> 0x0001
        public const int NUMPRS_LEADING_WHITE = 1;

        /// NUMPRS_LEADING_PLUS -> 0x0004
        public const int NUMPRS_LEADING_PLUS = 4;

        /// NUMPRS_LEADING_MINUS -> 0x0010
        public const int NUMPRS_LEADING_MINUS = 16;

        /// NUMPRS_INEXACT -> 0x20000
        public const int NUMPRS_INEXACT = 131072;

        /// NUMPRS_HEX_OCT -> 0x0040
        public const int NUMPRS_HEX_OCT = 64;

        /// NUMPRS_EXPONENT -> 0x0800
        public const int NUMPRS_EXPONENT = 2048;

        /// NUMPRS_DECIMAL -> 0x0100
        public const int NUMPRS_DECIMAL = 256;

        /// NUMPRS_CURRENCY -> 0x0400
        public const int NUMPRS_CURRENCY = 1024;

        /// NUMPENS -> 18
        public const int NUMPENS = 18;

        /// NUMMARKERS -> 20
        public const int NUMMARKERS = 20;

        /// NUMLOCK_ON -> 0x0020
        public const int NUMLOCK_ON = 32;

        /// NUMFONTS -> 22
        public const int NUMFONTS = 22;

        /// NUMCOLORS -> 24
        public const int NUMCOLORS = 24;

        /// NUMBRUSHES -> 16
        public const int NUMBRUSHES = 16;

        /// NULL_PEN -> 8
        public const int NULL_PEN = 8;

        /// NULL_BRUSH -> 5
        public const int NULL_BRUSH = 5;

        /// NULLREGION -> 1
        public const int NULLREGION = 1;

        /// NTSYSCALLAPI -> DECLSPEC_IMPORT
        public const string NTSYSCALLAPI = NativeConstants.DECLSPEC_IMPORT;

        /// NTSYSAPI -> DECLSPEC_IMPORT
        public const string NTSYSAPI = NativeConstants.DECLSPEC_IMPORT;

        /// NTM_TYPE1 -> 0x00100000
        public const int NTM_TYPE1 = 1048576;

        /// NTM_TT_OPENTYPE -> 0x00040000
        public const int NTM_TT_OPENTYPE = 262144;

        /// NTM_REGULAR -> 0x00000040L
        public const int NTM_REGULAR = 64;

        /// NTM_PS_OPENTYPE -> 0x00020000
        public const int NTM_PS_OPENTYPE = 131072;

        /// NTM_NONNEGATIVE_AC -> 0x00010000
        public const int NTM_NONNEGATIVE_AC = 65536;

        /// NTM_MULTIPLEMASTER -> 0x00080000
        public const int NTM_MULTIPLEMASTER = 524288;

        /// NTM_ITALIC -> 0x00000001L
        public const int NTM_ITALIC = 1;

        /// NTM_DSIG -> 0x00200000
        public const int NTM_DSIG = 2097152;

        /// NTM_BOLD -> 0x00000020L
        public const int NTM_BOLD = 32;

        /// NTE_OP_OK -> 0
        public const int NTE_OP_OK = 0;

        /// NTAPI -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string NTAPI = "__stdcall";

        /// NT351_INTERFACE_SIZE -> 0x40
        public const int NT351_INTERFACE_SIZE = 64;

        /// NRC_TOOMANY -> 0x22
        public const int NRC_TOOMANY = 34;

        /// NRC_SYSTEM -> 0x40
        public const int NRC_SYSTEM = 64;

        /// NRC_SNUMOUT -> 0x08
        public const int NRC_SNUMOUT = 8;

        /// NRC_SCLOSED -> 0x0a
        public const int NRC_SCLOSED = 10;

        /// NRC_SABORT -> 0x18
        public const int NRC_SABORT = 24;

        /// NRC_REMTFUL -> 0x12
        public const int NRC_REMTFUL = 18;

        /// NRC_PENDING -> 0xff
        public const int NRC_PENDING = 255;

        /// NRC_OSRESNOTAV -> 0x35
        public const int NRC_OSRESNOTAV = 53;

        /// NRC_OPENERR -> 0x3f
        public const int NRC_OPENERR = 63;

        /// NRC_NOWILD -> 0x15
        public const int NRC_NOWILD = 21;

        /// NRC_NOSAPS -> 0x37
        public const int NRC_NOSAPS = 55;

        /// NRC_NORESOURCES -> 0x38
        public const int NRC_NORESOURCES = 56;

        /// NRC_NORES -> 0x09
        public const int NRC_NORES = 9;

        /// NRC_NOCALL -> 0x14
        public const int NRC_NOCALL = 20;

        /// NRC_NAMTFUL -> 0x0e
        public const int NRC_NAMTFUL = 14;

        /// NRC_NAMERR -> 0x17
        public const int NRC_NAMERR = 23;

        /// NRC_NAMCONF -> 0x19
        public const int NRC_NAMCONF = 25;

        /// NRC_MAXAPPS -> 0x36
        public const int NRC_MAXAPPS = 54;

        /// NRC_LOCTFUL -> 0x11
        public const int NRC_LOCTFUL = 17;

        /// NRC_LOCKFAIL -> 0x3C
        public const int NRC_LOCKFAIL = 60;

        /// NRC_INVDDID -> 0x3B
        public const int NRC_INVDDID = 59;

        /// NRC_INVADDRESS -> 0x39
        public const int NRC_INVADDRESS = 57;

        /// NRC_INUSE -> 0x16
        public const int NRC_INUSE = 22;

        /// NRC_INCOMP -> 0x06
        public const int NRC_INCOMP = 6;

        /// NRC_ILLNN -> 0x13
        public const int NRC_ILLNN = 19;

        /// NRC_ILLCMD -> 0x03
        public const int NRC_ILLCMD = 3;

        /// NRC_IFBUSY -> 0x21
        public const int NRC_IFBUSY = 33;

        /// NRC_GOODRET -> 0x00
        public const int NRC_GOODRET = 0;

        /// NRC_ENVNOTDEF -> 0x34
        public const int NRC_ENVNOTDEF = 52;

        /// NRC_DUPNAME -> 0x0d
        public const int NRC_DUPNAME = 13;

        /// NRC_DUPENV -> 0x30
        public const int NRC_DUPENV = 48;

        /// NRC_CMDTMO -> 0x05
        public const int NRC_CMDTMO = 5;

        /// NRC_CMDCAN -> 0x0b
        public const int NRC_CMDCAN = 11;

        /// NRC_CANOCCR -> 0x24
        public const int NRC_CANOCCR = 36;

        /// NRC_CANCEL -> 0x26
        public const int NRC_CANCEL = 38;

        /// NRC_BUFLEN -> 0x01
        public const int NRC_BUFLEN = 1;

        /// NRC_BRIDGE -> 0x23
        public const int NRC_BRIDGE = 35;

        /// NRC_BADDR -> 0x07
        public const int NRC_BADDR = 7;

        /// NRC_ACTSES -> 0x0f
        public const int NRC_ACTSES = 15;

        /// NO_RECOVERY -> WSANO_RECOVERY
        public const int NO_RECOVERY = NativeConstants.WSANO_RECOVERY;

        /// NO_PROPAGATE_INHERIT_ACE -> (0x4)
        public const int NO_PROPAGATE_INHERIT_ACE = 4;

        /// NO_PRIORITY -> 0
        public const int NO_PRIORITY = 0;

        /// NO_ERROR -> 0L
        public const int NO_ERROR = 0;

        /// NO_DATA -> WSANO_DATA
        public const int NO_DATA = NativeConstants.WSANO_DATA;

        /// NO_ADDRESS -> WSANO_ADDRESS
        public const int NO_ADDRESS = NativeConstants.WSANO_ADDRESS;

        /// NOTIFYICONDATA_V2_SIZE -> NOTIFYICONDATAW_V2_SIZE
        public const string NOTIFYICONDATA_V2_SIZE = NativeConstants.NOTIFYICONDATAW_V2_SIZE;

        /// NOTIFYICONDATA_V1_SIZE -> NOTIFYICONDATAW_V1_SIZE
        public const string NOTIFYICONDATA_V1_SIZE = NativeConstants.NOTIFYICONDATAW_V1_SIZE;

        /// NORM_IGNOREWIDTH -> 0x00020000
        public const int NORM_IGNOREWIDTH = 131072;

        /// NORM_IGNORESYMBOLS -> 0x00000004
        public const int NORM_IGNORESYMBOLS = 4;

        /// NORM_IGNORENONSPACE -> 0x00000002
        public const int NORM_IGNORENONSPACE = 2;

        /// NORM_IGNOREKANATYPE -> 0x00010000
        public const int NORM_IGNOREKANATYPE = 65536;

        /// NORM_IGNORECASE -> 0x00000001
        public const int NORM_IGNORECASE = 1;

        /// NORMAL_PRIORITY_CLASS -> 0x00000020
        public const int NORMAL_PRIORITY_CLASS = 32;

        /// NORMAL_PRINT -> 0x00000000
        public const int NORMAL_PRINT = 0;

        /// NOP_FUNCTION -> __noop
        /// Error generating expression: Value __noop is not resolved
        public const string NOP_FUNCTION = "__noop";

        /// NOPARITY -> 0
        public const int NOPARITY = 0;

        /// NON_PAGED_DEBUG_SIGNATURE -> 0x494E
        public const int NON_PAGED_DEBUG_SIGNATURE = 18766;

        /// NONZEROLPTR -> (LMEM_FIXED)
        public const int NONZEROLPTR = NativeConstants.LMEM_FIXED;

        /// NONZEROLHND -> (LMEM_MOVEABLE)
        public const int NONZEROLHND = NativeConstants.LMEM_MOVEABLE;

        /// NONANTIALIASED_QUALITY -> 3
        public const int NONANTIALIASED_QUALITY = 3;

        /// NOERROR -> 0
        public const int NOERROR = 0;

        /// NMPWAIT_WAIT_FOREVER -> 0xffffffff
        public const int NMPWAIT_WAIT_FOREVER = -1;

        /// NMPWAIT_USE_DEFAULT_WAIT -> 0x00000000
        public const int NMPWAIT_USE_DEFAULT_WAIT = 0;

        /// NMPWAIT_NOWAIT -> 0x00000001
        public const int NMPWAIT_NOWAIT = 1;

        /// NLS_VALID_LOCALE_MASK -> 0x000fffff
        public const int NLS_VALID_LOCALE_MASK = 1048575;

        /// NLS_ROMAN -> 0x00400000
        public const int NLS_ROMAN = 4194304;

        /// NLS_KATAKANA -> 0x00020000
        public const int NLS_KATAKANA = 131072;

        /// NLS_IME_DISABLE -> 0x20000000
        public const int NLS_IME_DISABLE = 536870912;

        /// NLS_IME_CONVERSION -> 0x00800000
        public const int NLS_IME_CONVERSION = 8388608;

        /// NLS_HIRAGANA -> 0x00040000
        public const int NLS_HIRAGANA = 262144;

        /// NLS_DBCSCHAR -> 0x00010000
        public const int NLS_DBCSCHAR = 65536;

        /// NLS_ALPHANUMERIC -> 0x00000000
        public const int NLS_ALPHANUMERIC = 0;

        /// NI_SETCANDIDATE_PAGESTART -> 0x0016
        public const int NI_SETCANDIDATE_PAGESTART = 22;

        /// NI_SETCANDIDATE_PAGESIZE -> 0x0017
        public const int NI_SETCANDIDATE_PAGESIZE = 23;

        /// NI_SELECTCANDIDATESTR -> 0x0012
        public const int NI_SELECTCANDIDATESTR = 18;

        /// NI_OPENCANDIDATE -> 0x0010
        public const int NI_OPENCANDIDATE = 16;

        /// NI_IMEMENUSELECTED -> 0x0018
        public const int NI_IMEMENUSELECTED = 24;

        /// NI_FINALIZECONVERSIONRESULT -> 0x0014
        public const int NI_FINALIZECONVERSIONRESULT = 20;

        /// NI_COMPOSITIONSTR -> 0x0015
        public const int NI_COMPOSITIONSTR = 21;

        /// NI_CLOSECANDIDATE -> 0x0011
        public const int NI_CLOSECANDIDATE = 17;

        /// NI_CHANGECANDIDATELIST -> 0x0013
        public const int NI_CHANGECANDIDATELIST = 19;

        /// NIM_MODIFY -> 0x00000001
        public const int NIM_MODIFY = 1;

        /// NIM_DELETE -> 0x00000002
        public const int NIM_DELETE = 2;

        /// NIM_ADD -> 0x00000000
        public const int NIM_ADD = 0;

        /// NIF_TIP -> 0x00000004
        public const int NIF_TIP = 4;

        /// NIF_MESSAGE -> 0x00000001
        public const int NIF_MESSAGE = 1;

        /// NIF_ICON -> 0x00000002
        public const int NIF_ICON = 2;

        /// NF_REQUERY -> 4
        public const int NF_REQUERY = 4;

        /// NF_QUERY -> 3
        public const int NF_QUERY = 3;

        /// NFR_UNICODE -> 2
        public const int NFR_UNICODE = 2;

        /// NFR_ANSI -> 1
        public const int NFR_ANSI = 1;

        /// NEXTBAND -> 3
        public const int NEXTBAND = 3;

        /// NEWTRANSPARENT -> 3
        public const int NEWTRANSPARENT = 3;

        /// NEWFRAME -> 1
        public const int NEWFRAME = 1;

        /// NEWFILEOPENV2ORD -> 1552
        public const int NEWFILEOPENV2ORD = 1552;

        /// NEWFILEOPENORD -> 1547
        public const int NEWFILEOPENORD = 1547;

        /// NETSCAPE_SSL_SERVER_AUTH_CERT_TYPE -> 0x40
        public const int NETSCAPE_SSL_SERVER_AUTH_CERT_TYPE = 64;

        /// NETSCAPE_SSL_CLIENT_AUTH_CERT_TYPE -> 0x80
        public const int NETSCAPE_SSL_CLIENT_AUTH_CERT_TYPE = 128;

        /// NETSCAPE_SSL_CA_CERT_TYPE -> 0x04
        public const int NETSCAPE_SSL_CA_CERT_TYPE = 4;

        /// NETSCAPE_SMIME_CERT_TYPE -> 0x20
        public const int NETSCAPE_SMIME_CERT_TYPE = 32;

        /// NETSCAPE_SMIME_CA_CERT_TYPE -> 0x02
        public const int NETSCAPE_SMIME_CA_CERT_TYPE = 2;

        /// NETSCAPE_SIGN_CERT_TYPE -> 0x10
        public const int NETSCAPE_SIGN_CERT_TYPE = 16;

        /// NETSCAPE_SIGN_CA_CERT_TYPE -> 0x01
        public const int NETSCAPE_SIGN_CA_CERT_TYPE = 1;

        /// NETPROPERTY_PERSISTENT -> 1
        public const int NETPROPERTY_PERSISTENT = 1;

        /// NETINFO_PRINTERRED -> 0x00000008
        public const int NETINFO_PRINTERRED = 8;

        /// NETINFO_DLL16 -> 0x00000001
        public const int NETINFO_DLL16 = 1;

        /// NETINFO_DISKRED -> 0x00000004
        public const int NETINFO_DISKRED = 4;

        /// NeedCurrentDirectoryForExePath -> NeedCurrentDirectoryForExePathW
        /// Error generating expression: Value NeedCurrentDirectoryForExePathW is not resolved
        public const string NeedCurrentDirectoryForExePath = "NeedCurrentDirectoryForExePathW";

        /// NEAR -> near
        public const string NEAR = NativeConstants.near;

        /// NDR_SHAREABLE -> __inline
        /// Error generating expression: Value __inline is not resolved
        public const string NDR_SHAREABLE = "__inline";

        /// NDR_LOCAL_ENDIAN -> NDR_LITTLE_ENDIAN
        public const string NDR_LOCAL_ENDIAN = NativeConstants.NDR_LITTLE_ENDIAN;

        /// NCBUNLINK -> 0x70
        public const int NCBUNLINK = 112;

        /// NCBTRACE -> 0x79
        public const int NCBTRACE = 121;

        /// NCBSSTAT -> 0x34
        public const int NCBSSTAT = 52;

        /// NCBSENDNA -> 0x71
        public const int NCBSENDNA = 113;

        /// NCBSEND -> 0x14
        public const int NCBSEND = 20;

        /// NCBRESET -> 0x32
        public const int NCBRESET = 50;

        /// NCBRECVANY -> 0x16
        public const int NCBRECVANY = 22;

        /// NCBRECV -> 0x15
        public const int NCBRECV = 21;

        /// NCBNAMSZ -> 16
        public const int NCBNAMSZ = 16;

        /// NCBLISTEN -> 0x11
        public const int NCBLISTEN = 17;

        /// NCBLANSTALERT -> 0x73
        public const int NCBLANSTALERT = 115;

        /// NCBHANGUP -> 0x12
        public const int NCBHANGUP = 18;

        /// NCBFINDNAME -> 0x78
        public const int NCBFINDNAME = 120;

        /// NCBENUM -> 0x37
        public const int NCBENUM = 55;

        /// NCBDGSENDBC -> 0x22
        public const int NCBDGSENDBC = 34;

        /// NCBDGSEND -> 0x20
        public const int NCBDGSEND = 32;

        /// NCBDGRECVBC -> 0x23
        public const int NCBDGRECVBC = 35;

        /// NCBDGRECV -> 0x21
        public const int NCBDGRECV = 33;

        /// NCBDELNAME -> 0x31
        public const int NCBDELNAME = 49;

        /// NCBCHAINSENDNA -> 0x72
        public const int NCBCHAINSENDNA = 114;

        /// NCBCHAINSEND -> 0x17
        public const int NCBCHAINSEND = 23;

        /// NCBCANCEL -> 0x35
        public const int NCBCANCEL = 53;

        /// NCBCALL -> 0x10
        public const int NCBCALL = 16;

        /// NCBASTAT -> 0x33
        public const int NCBASTAT = 51;

        /// NCBADDNAME -> 0x30
        public const int NCBADDNAME = 48;

        /// NCBADDGRNAME -> 0x36
        public const int NCBADDGRNAME = 54;

        /// NCBACTION -> 0x77
        public const int NCBACTION = 119;

        /// NAME_FLAGS_MASK -> 0x87
        public const int NAME_FLAGS_MASK = 135;

        /// NOTIFYICONDATAW_V2_SIZE -> FIELD_OFFSET(NOTIFYICONDATAW, guidItem)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string NOTIFYICONDATAW_V2_SIZE = "FIELD_OFFSET(NOTIFYICONDATAW, guidItem)";

        /// NOTIFYICONDATAW_V1_SIZE -> FIELD_OFFSET(NOTIFYICONDATAW, szTip[64])
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string NOTIFYICONDATAW_V1_SIZE = "FIELD_OFFSET(NOTIFYICONDATAW, szTip[64])";

        /// near -> 
        /// Error generating expression: 值不能为空。
        ///参数名: node
        public const string near = "";

        /// Warning: Generation of Method Macros is not supported at this time
        /// NDR_LITTLE_ENDIAN -> "() 0X00000010L"
        public const string NDR_LITTLE_ENDIAN = "() 0X00000010L";
    }

}
