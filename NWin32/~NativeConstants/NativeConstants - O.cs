using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// OWNER_SECURITY_INFORMATION -> (0x00000001L)
        public const int OWNER_SECURITY_INFORMATION = 1;

        /// OVERWRITE_HIDDEN -> (4)
        public const int OVERWRITE_HIDDEN = 4;

        /// OUT_TT_PRECIS -> 4
        public const int OUT_TT_PRECIS = 4;

        /// OUT_TT_ONLY_PRECIS -> 7
        public const int OUT_TT_ONLY_PRECIS = 7;

        /// OUT_STROKE_PRECIS -> 3
        public const int OUT_STROKE_PRECIS = 3;

        /// OUT_STRING_PRECIS -> 1
        public const int OUT_STRING_PRECIS = 1;

        /// OUT_SCREEN_OUTLINE_PRECIS -> 9
        public const int OUT_SCREEN_OUTLINE_PRECIS = 9;

        /// OUT_RASTER_PRECIS -> 6
        public const int OUT_RASTER_PRECIS = 6;

        /// OUT_PS_ONLY_PRECIS -> 10
        public const int OUT_PS_ONLY_PRECIS = 10;

        /// OUT_OUTLINE_PRECIS -> 8
        public const int OUT_OUTLINE_PRECIS = 8;

        /// OUT_DEVICE_PRECIS -> 5
        public const int OUT_DEVICE_PRECIS = 5;

        /// OUT_DEFAULT_PRECIS -> 0
        public const int OUT_DEFAULT_PRECIS = 0;

        /// OUT_CHARACTER_PRECIS -> 2
        public const int OUT_CHARACTER_PRECIS = 2;

        /// OUTPUT_DEBUG_STRING_EVENT -> 8
        public const int OUTPUT_DEBUG_STRING_EVENT = 8;

        /// OutputDebugString -> OutputDebugStringW
        /// Error generating expression: Value OutputDebugStringW is not resolved
        public const string OutputDebugString = "OutputDebugStringW";

        /// OutputDebugStr -> OutputDebugString
        public const string OutputDebugStr = NativeConstants.OutputDebugString;

        /// OR_INVALID_SET -> 1912L
        public const int OR_INVALID_SET = 1912;

        /// OR_INVALID_OXID -> 1910L
        public const int OR_INVALID_OXID = 1910;

        /// OR_INVALID_OID -> 1911L
        public const int OR_INVALID_OID = 1911;

        /// ORD_LANGDRIVER -> 1
        public const int ORD_LANGDRIVER = 1;

        /// OPEN_EXISTING -> 3
        public const int OPEN_EXISTING = 3;

        /// OPEN_ALWAYS -> 4
        public const int OPEN_ALWAYS = 4;

        /// OpenWindowStation -> OpenWindowStationW
        /// Error generating expression: Value OpenWindowStationW is not resolved
        public const string OpenWindowStation = "OpenWindowStationW";

        /// OpenWaitableTimer -> OpenWaitableTimerW
        /// Error generating expression: Value OpenWaitableTimerW is not resolved
        public const string OpenWaitableTimer = "OpenWaitableTimerW";

        /// OpenService -> OpenServiceW
        /// Error generating expression: Value OpenServiceW is not resolved
        public const string OpenService = "OpenServiceW";

        /// OpenSemaphore -> OpenSemaphoreW
        /// Error generating expression: Value OpenSemaphoreW is not resolved
        public const string OpenSemaphore = "OpenSemaphoreW";

        /// OpenSCManager -> OpenSCManagerW
        /// Error generating expression: Value OpenSCManagerW is not resolved
        public const string OpenSCManager = "OpenSCManagerW";

        /// OpenPrinter -> OpenPrinterW
        /// Error generating expression: Value OpenPrinterW is not resolved
        public const string OpenPrinter = "OpenPrinterW";

        /// OpenMutex -> OpenMutexW
        /// Error generating expression: Value OpenMutexW is not resolved
        public const string OpenMutex = "OpenMutexW";

        /// OpenJobObject -> OpenJobObjectW
        /// Error generating expression: Value OpenJobObjectW is not resolved
        public const string OpenJobObject = "OpenJobObjectW";

        /// OPENFILENAME_SIZE_VERSION_400 -> OPENFILENAME_SIZE_VERSION_400W
        public const string OPENFILENAME_SIZE_VERSION_400 = NativeConstants.OPENFILENAME_SIZE_VERSION_400W;

        /// OpenFileMapping -> OpenFileMappingW
        /// Error generating expression: Value OpenFileMappingW is not resolved
        public const string OpenFileMapping = "OpenFileMappingW";

        /// OpenEventLog -> OpenEventLogW
        /// Error generating expression: Value OpenEventLogW is not resolved
        public const string OpenEventLog = "OpenEventLogW";

        /// OpenEvent -> OpenEventW
        /// Error generating expression: Value OpenEventW is not resolved
        public const string OpenEvent = "OpenEventW";

        /// OpenEncryptedFileRaw -> OpenEncryptedFileRawW
        /// Error generating expression: Value OpenEncryptedFileRawW is not resolved
        public const string OpenEncryptedFileRaw = "OpenEncryptedFileRawW";

        /// OpenDesktop -> OpenDesktopW
        /// Error generating expression: Value OpenDesktopW is not resolved
        public const string OpenDesktop = "OpenDesktopW";

        /// OPENCHANNEL -> 4110
        public const int OPENCHANNEL = 4110;

        /// OPENCARDNAME_W -> OPENCARDNAMEW
        /// Error generating expression: Value OPENCARDNAMEW is not resolved
        public const string OPENCARDNAME_W = "OPENCARDNAMEW";

        /// OPENCARDNAME_A -> OPENCARDNAMEA
        /// Error generating expression: Value OPENCARDNAMEA is not resolved
        public const string OPENCARDNAME_A = "OPENCARDNAMEA";

        /// OPENCARDNAMEW_EX -> OPENCARDNAME_EXW
        /// Error generating expression: Value OPENCARDNAME_EXW is not resolved
        public const string OPENCARDNAMEW_EX = "OPENCARDNAME_EXW";

        /// OPENCARDNAMEA_EX -> OPENCARDNAME_EXA
        /// Error generating expression: Value OPENCARDNAME_EXA is not resolved
        public const string OPENCARDNAMEA_EX = "OPENCARDNAME_EXA";

        /// OpenBackupEventLog -> OpenBackupEventLogW
        /// Error generating expression: Value OpenBackupEventLogW is not resolved
        public const string OpenBackupEventLog = "OpenBackupEventLogW";

        /// OPAQUEKEYBLOB -> 0x9
        public const int OPAQUEKEYBLOB = 9;

        /// OPAQUE -> 2
        public const int OPAQUE = 2;

        /// ONESTOPBIT -> 0
        public const int ONESTOPBIT = 0;

        /// ONE5STOPBITS -> 1
        public const int ONE5STOPBITS = 1;

        /// OLEOBJ_S_LAST -> 0x0004018FL
        public const int OLEOBJ_S_LAST = 262543;

        /// OLEOBJ_S_FIRST -> 0x00040180L
        public const int OLEOBJ_S_FIRST = 262528;

        /// OLEOBJ_E_LAST -> 0x8004018FL
        public const int OLEOBJ_E_LAST = -2147221105;

        /// OLEOBJ_E_FIRST -> 0x80040180L
        public const int OLEOBJ_E_FIRST = -2147221120;

        /// OLEIVERB_UIACTIVATE -> (-4L)
        public const int OLEIVERB_UIACTIVATE = -4;

        /// OLEIVERB_SHOW -> (-1L)
        public const int OLEIVERB_SHOW = -1;

        /// OLEIVERB_PRIMARY -> (0L)
        public const int OLEIVERB_PRIMARY = 0;

        /// OLEIVERB_OPEN -> (-2L)
        public const int OLEIVERB_OPEN = -2;

        /// OLEIVERB_INPLACEACTIVATE -> (-5L)
        public const int OLEIVERB_INPLACEACTIVATE = -5;

        /// OLEIVERB_HIDE -> (-3L)
        public const int OLEIVERB_HIDE = -3;

        /// OLEIVERB_DISCARDUNDOSTATE -> (-6L)
        public const int OLEIVERB_DISCARDUNDOSTATE = -6;

        /// OLECREATE_LEAVERUNNING -> 0x00000001
        public const int OLECREATE_LEAVERUNNING = 1;

        /// OLDFONTENUMPROC -> OLDFONTENUMPROCW
        /// Error generating expression: Value OLDFONTENUMPROCW is not resolved
        public const string OLDFONTENUMPROC = "OLDFONTENUMPROCW";

        /// OInetQueryInfo -> CoInternetQueryInfo
        /// Error generating expression: Value CoInternetQueryInfo is not resolved
        public const string OInetQueryInfo = "CoInternetQueryInfo";

        /// OInetParseUrl -> CoInternetParseUrl
        /// Error generating expression: Value CoInternetParseUrl is not resolved
        public const string OInetParseUrl = "CoInternetParseUrl";

        /// OInetGetSession -> CoInternetGetSession
        /// Error generating expression: Value CoInternetGetSession is not resolved
        public const string OInetGetSession = "CoInternetGetSession";

        /// OInetCompareUrl -> CoInternetCompareUrl
        /// Error generating expression: Value CoInternetCompareUrl is not resolved
        public const string OInetCompareUrl = "CoInternetCompareUrl";

        /// OInetCombineUrl -> CoInternetCombineUrl
        /// Error generating expression: Value CoInternetCombineUrl is not resolved
        public const string OInetCombineUrl = "CoInternetCombineUrl";

        /// OF_WRITE -> 0x00000001
        public const int OF_WRITE = 1;

        /// OF_VERIFY -> 0x00000400
        public const int OF_VERIFY = 1024;

        /// OF_SHARE_EXCLUSIVE -> 0x00000010
        public const int OF_SHARE_EXCLUSIVE = 16;

        /// OF_SHARE_DENY_WRITE -> 0x00000020
        public const int OF_SHARE_DENY_WRITE = 32;

        /// OF_SHARE_DENY_READ -> 0x00000030
        public const int OF_SHARE_DENY_READ = 48;

        /// OF_SHARE_DENY_NONE -> 0x00000040
        public const int OF_SHARE_DENY_NONE = 64;

        /// OF_SHARE_COMPAT -> 0x00000000
        public const int OF_SHARE_COMPAT = 0;

        /// OF_REOPEN -> 0x00008000
        public const int OF_REOPEN = 32768;

        /// OF_READWRITE -> 0x00000002
        public const int OF_READWRITE = 2;

        /// OF_READ -> 0x00000000
        public const int OF_READ = 0;

        /// OF_PROMPT -> 0x00002000
        public const int OF_PROMPT = 8192;

        /// OF_PARSE -> 0x00000100
        public const int OF_PARSE = 256;

        /// OF_EXIST -> 0x00004000
        public const int OF_EXIST = 16384;

        /// OF_DELETE -> 0x00000200
        public const int OF_DELETE = 512;

        /// OF_CREATE -> 0x00001000
        public const int OF_CREATE = 4096;

        /// OF_CANCEL -> 0x00000800
        public const int OF_CANCEL = 2048;

        /// OFS_MAXPATHNAME -> 128
        public const int OFS_MAXPATHNAME = 128;

        /// OFN_SHOWHELP -> 0x00000010
        public const int OFN_SHOWHELP = 16;

        /// OFN_SHAREWARN -> 0
        public const int OFN_SHAREWARN = 0;

        /// OFN_SHARENOWARN -> 1
        public const int OFN_SHARENOWARN = 1;

        /// OFN_SHAREFALLTHROUGH -> 2
        public const int OFN_SHAREFALLTHROUGH = 2;

        /// OFN_SHAREAWARE -> 0x00004000
        public const int OFN_SHAREAWARE = 16384;

        /// OFN_READONLY -> 0x00000001
        public const int OFN_READONLY = 1;

        /// OFN_PATHMUSTEXIST -> 0x00000800
        public const int OFN_PATHMUSTEXIST = 2048;

        /// OFN_OVERWRITEPROMPT -> 0x00000002
        public const int OFN_OVERWRITEPROMPT = 2;

        /// OFN_NOVALIDATE -> 0x00000100
        public const int OFN_NOVALIDATE = 256;

        /// OFN_NOTESTFILECREATE -> 0x00010000
        public const int OFN_NOTESTFILECREATE = 65536;

        /// OFN_NOREADONLYRETURN -> 0x00008000
        public const int OFN_NOREADONLYRETURN = 32768;

        /// OFN_NONETWORKBUTTON -> 0x00020000
        public const int OFN_NONETWORKBUTTON = 131072;

        /// OFN_NOLONGNAMES -> 0x00040000
        public const int OFN_NOLONGNAMES = 262144;

        /// OFN_NODEREFERENCELINKS -> 0x00100000
        public const int OFN_NODEREFERENCELINKS = 1048576;

        /// OFN_NOCHANGEDIR -> 0x00000008
        public const int OFN_NOCHANGEDIR = 8;

        /// OFN_LONGNAMES -> 0x00200000
        public const int OFN_LONGNAMES = 2097152;

        /// OFN_HIDEREADONLY -> 0x00000004
        public const int OFN_HIDEREADONLY = 4;

        /// OFN_FORCESHOWHIDDEN -> 0x10000000
        public const int OFN_FORCESHOWHIDDEN = 268435456;

        /// OFN_FILEMUSTEXIST -> 0x00001000
        public const int OFN_FILEMUSTEXIST = 4096;

        /// OFN_EX_NOPLACESBAR -> 0x00000001
        public const int OFN_EX_NOPLACESBAR = 1;

        /// OFN_EXTENSIONDIFFERENT -> 0x00000400
        public const int OFN_EXTENSIONDIFFERENT = 1024;

        /// OFN_EXPLORER -> 0x00080000
        public const int OFN_EXPLORER = 524288;

        /// OFN_ENABLETEMPLATEHANDLE -> 0x00000080
        public const int OFN_ENABLETEMPLATEHANDLE = 128;

        /// OFN_ENABLETEMPLATE -> 0x00000040
        public const int OFN_ENABLETEMPLATE = 64;

        /// OFN_ENABLESIZING -> 0x00800000
        public const int OFN_ENABLESIZING = 8388608;

        /// OFN_ENABLEINCLUDENOTIFY -> 0x00400000
        public const int OFN_ENABLEINCLUDENOTIFY = 4194304;

        /// OFN_ENABLEHOOK -> 0x00000020
        public const int OFN_ENABLEHOOK = 32;

        /// OFN_DONTADDTORECENT -> 0x02000000
        public const int OFN_DONTADDTORECENT = 33554432;

        /// OFN_CREATEPROMPT -> 0x00002000
        public const int OFN_CREATEPROMPT = 8192;

        /// OFN_ALLOWMULTISELECT -> 0x00000200
        public const int OFN_ALLOWMULTISELECT = 512;

        /// OFFLINE_STATUS_REMOTE -> 0x0002
        public const int OFFLINE_STATUS_REMOTE = 2;

        /// OFFLINE_STATUS_LOCAL -> 0x0001
        public const int OFFLINE_STATUS_LOCAL = 1;

        /// OFFLINE_STATUS_INCOMPLETE -> 0x0004
        public const int OFFLINE_STATUS_INCOMPLETE = 4;

        /// OEM_FIXED_FONT -> 10
        public const int OEM_FIXED_FONT = 10;

        /// OEM_CHARSET -> 255
        public const int OEM_CHARSET = 255;

        /// OemToCharBuff -> OemToCharBuffW
        /// Error generating expression: Value OemToCharBuffW is not resolved
        public const string OemToCharBuff = "OemToCharBuffW";

        /// OemToChar -> OemToCharW
        /// Error generating expression: Value OemToCharW is not resolved
        public const string OemToChar = "OemToCharW";

        /// OemToAnsiBuff -> OemToCharBuffA
        /// Error generating expression: Value OemToCharBuffA is not resolved
        public const string OemToAnsiBuff = "OemToCharBuffA";

        /// OemToAnsi -> OemToCharA
        /// Error generating expression: Value OemToCharA is not resolved
        public const string OemToAnsi = "OemToCharA";

        /// ODT_STATIC -> 5
        public const int ODT_STATIC = 5;

        /// ODT_MENU -> 1
        public const int ODT_MENU = 1;

        /// ODT_LISTBOX -> 2
        public const int ODT_LISTBOX = 2;

        /// ODT_COMBOBOX -> 3
        public const int ODT_COMBOBOX = 3;

        /// ODT_BUTTON -> 4
        public const int ODT_BUTTON = 4;

        /// ODS_SELECTED -> 0x0001
        public const int ODS_SELECTED = 1;

        /// ODS_NOFOCUSRECT -> 0x0200
        public const int ODS_NOFOCUSRECT = 512;

        /// ODS_NOACCEL -> 0x0100
        public const int ODS_NOACCEL = 256;

        /// ODS_INACTIVE -> 0x0080
        public const int ODS_INACTIVE = 128;

        /// ODS_HOTLIGHT -> 0x0040
        public const int ODS_HOTLIGHT = 64;

        /// ODS_GRAYED -> 0x0002
        public const int ODS_GRAYED = 2;

        /// ODS_FOCUS -> 0x0010
        public const int ODS_FOCUS = 16;

        /// ODS_DISABLED -> 0x0004
        public const int ODS_DISABLED = 4;

        /// ODS_DEFAULT -> 0x0020
        public const int ODS_DEFAULT = 32;

        /// ODS_COMBOBOXEDIT -> 0x1000
        public const int ODS_COMBOBOXEDIT = 4096;

        /// ODS_CHECKED -> 0x0008
        public const int ODS_CHECKED = 8;

        /// ODDPARITY -> 1
        public const int ODDPARITY = 1;

        /// ODA_SELECT -> 0x0002
        public const int ODA_SELECT = 2;

        /// ODA_FOCUS -> 0x0004
        public const int ODA_FOCUS = 4;

        /// ODA_DRAWENTIRE -> 0x0001
        public const int ODA_DRAWENTIRE = 1;

        /// OBJ_REGION -> 8
        public const int OBJ_REGION = 8;

        /// OBJ_PEN -> 1
        public const int OBJ_PEN = 1;

        /// OBJ_PAL -> 5
        public const int OBJ_PAL = 5;

        /// OBJ_METAFILE -> 9
        public const int OBJ_METAFILE = 9;

        /// OBJ_METADC -> 4
        public const int OBJ_METADC = 4;

        /// OBJ_MEMDC -> 10
        public const int OBJ_MEMDC = 10;

        /// OBJ_FONT -> 6
        public const int OBJ_FONT = 6;

        /// OBJ_EXTPEN -> 11
        public const int OBJ_EXTPEN = 11;

        /// OBJ_ENHMETAFILE -> 13
        public const int OBJ_ENHMETAFILE = 13;

        /// OBJ_ENHMETADC -> 12
        public const int OBJ_ENHMETADC = 12;

        /// OBJ_DC -> 3
        public const int OBJ_DC = 3;

        /// OBJ_COLORSPACE -> 14
        public const int OBJ_COLORSPACE = 14;

        /// OBJ_BRUSH -> 2
        public const int OBJ_BRUSH = 2;

        /// OBJ_BITMAP -> 7
        public const int OBJ_BITMAP = 7;

        /// OBJECT_INHERIT_ACE -> (0x1)
        public const int OBJECT_INHERIT_ACE = 1;

        /// ObjectPrivilegeAuditAlarm -> ObjectPrivilegeAuditAlarmW
        /// Error generating expression: Value ObjectPrivilegeAuditAlarmW is not resolved
        public const string ObjectPrivilegeAuditAlarm = "ObjectPrivilegeAuditAlarmW";

        /// ObjectOpenAuditAlarm -> ObjectOpenAuditAlarmW
        /// Error generating expression: Value ObjectOpenAuditAlarmW is not resolved
        public const string ObjectOpenAuditAlarm = "ObjectOpenAuditAlarmW";

        /// ObjectDeleteAuditAlarm -> ObjectDeleteAuditAlarmW
        /// Error generating expression: Value ObjectDeleteAuditAlarmW is not resolved
        public const string ObjectDeleteAuditAlarm = "ObjectDeleteAuditAlarmW";

        /// ObjectCloseAuditAlarm -> ObjectCloseAuditAlarmW
        /// Error generating expression: Value ObjectCloseAuditAlarmW is not resolved
        public const string ObjectCloseAuditAlarm = "ObjectCloseAuditAlarmW";

        /// OPENFILENAME_SIZE_VERSION_400W -> CDSIZEOF_STRUCT(OPENFILENAMEW,lpTemplateName)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string OPENFILENAME_SIZE_VERSION_400W = "CDSIZEOF_STRUCT(OPENFILENAMEW,lpTemplateName)";
    }

}
