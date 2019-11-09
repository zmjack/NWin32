using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// GW_OWNER -> 4
        public const int GW_OWNER = 4;

        /// GW_MAX -> 6
        public const int GW_MAX = 6;

        /// GW_HWNDPREV -> 3
        public const int GW_HWNDPREV = 3;

        /// GW_HWNDNEXT -> 2
        public const int GW_HWNDNEXT = 2;

        /// GW_HWNDLAST -> 1
        public const int GW_HWNDLAST = 1;

        /// GW_HWNDFIRST -> 0
        public const int GW_HWNDFIRST = 0;

        /// GW_ENABLEDPOPUP -> 6
        public const int GW_ENABLEDPOPUP = 6;

        /// GW_CHILD -> 5
        public const int GW_CHILD = 5;

        /// GWL_WNDPROC -> (-4)
        public const int GWL_WNDPROC = -4;

        /// GWL_USERDATA -> (-21)
        public const int GWL_USERDATA = -21;

        /// GWL_STYLE -> (-16)
        public const int GWL_STYLE = -16;

        /// GWL_ID -> (-12)
        public const int GWL_ID = -12;

        /// GWL_HWNDPARENT -> (-8)
        public const int GWL_HWNDPARENT = -8;

        /// GWL_HINSTANCE -> (-6)
        public const int GWL_HINSTANCE = -6;

        /// GWL_EXSTYLE -> (-20)
        public const int GWL_EXSTYLE = -20;

        /// GWLP_WNDPROC -> (-4)
        public const int GWLP_WNDPROC = -4;

        /// GWLP_USERDATA -> (-21)
        public const int GWLP_USERDATA = -21;

        /// GWLP_ID -> (-12)
        public const int GWLP_ID = -12;

        /// GWLP_HWNDPARENT -> (-8)
        public const int GWLP_HWNDPARENT = -8;

        /// GWLP_HINSTANCE -> (-6)
        public const int GWLP_HINSTANCE = -6;

        /// GUI_SYSTEMMENUMODE -> 0x00000008
        public const int GUI_SYSTEMMENUMODE = 8;

        /// GUI_POPUPMENUMODE -> 0x00000010
        public const int GUI_POPUPMENUMODE = 16;

        /// GUI_INMOVESIZE -> 0x00000002
        public const int GUI_INMOVESIZE = 2;

        /// GUI_INMENUMODE -> 0x00000004
        public const int GUI_INMENUMODE = 4;

        /// GUI_CARETBLINKING -> 0x00000001
        public const int GUI_CARETBLINKING = 1;

        /// GUI_16BITTASK -> 0x00000020
        public const int GUI_16BITTASK = 32;

        /// GUID_SERENUM_BUS_ENUMERATOR -> GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR
        /// Error generating expression: Value GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR is not resolved
        public const string GUID_SERENUM_BUS_ENUMERATOR = "GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR";

        /// GUID_CLASS_COMPORT -> GUID_DEVINTERFACE_COMPORT
        /// Error generating expression: Value GUID_DEVINTERFACE_COMPORT is not resolved
        public const string GUID_CLASS_COMPORT = "GUID_DEVINTERFACE_COMPORT";

        /// GS_8BIT_INDICES -> 0x00000001
        public const int GS_8BIT_INDICES = 1;

        /// GR_USEROBJECTS -> 1
        public const int GR_USEROBJECTS = 1;

        /// GR_GDIOBJECTS -> 0
        public const int GR_GDIOBJECTS = 0;

        /// grp4 -> 0x0433
        public const int grp4 = 1075;

        /// grp3 -> 0x0432
        public const int grp3 = 1074;

        /// grp2 -> 0x0431
        public const int grp2 = 1073;

        /// grp1 -> 0x0430
        public const int grp1 = 1072;

        /// GROUP_SECURITY_INFORMATION -> (0x00000002L)
        public const int GROUP_SECURITY_INFORMATION = 2;

        /// GROUP_NAME -> 0x80
        public const int GROUP_NAME = 128;

        /// GREEK_CHARSET -> 161
        public const int GREEK_CHARSET = 161;

        /// GRAY_BRUSH -> 2
        public const int GRAY_BRUSH = 2;

        /// GrayString -> GrayStringW
        /// Error generating expression: Value GrayStringW is not resolved
        public const string GrayString = "GrayStringW";

        /// GRADIENT_FILL_TRIANGLE -> 0x00000002
        public const int GRADIENT_FILL_TRIANGLE = 2;

        /// GRADIENT_FILL_RECT_V -> 0x00000001
        public const int GRADIENT_FILL_RECT_V = 1;

        /// GRADIENT_FILL_RECT_H -> 0x00000000
        public const int GRADIENT_FILL_RECT_H = 0;

        /// GRADIENT_FILL_OP_FLAG -> 0x000000ff
        public const int GRADIENT_FILL_OP_FLAG = 255;

        /// GPT_BASIC_DATA_ATTRIBUTE_SHADOW_COPY -> (0x2000000000000000)
        public const long GPT_BASIC_DATA_ATTRIBUTE_SHADOW_COPY = 2305843009213693952;

        /// GPT_BASIC_DATA_ATTRIBUTE_READ_ONLY -> (0x1000000000000000)
        public const long GPT_BASIC_DATA_ATTRIBUTE_READ_ONLY = 1152921504606846976;

        /// GPT_BASIC_DATA_ATTRIBUTE_NO_DRIVE_LETTER -> (0x8000000000000000)
        public const long GPT_BASIC_DATA_ATTRIBUTE_NO_DRIVE_LETTER = -9223372036854775808;

        /// GPT_BASIC_DATA_ATTRIBUTE_HIDDEN -> (0x4000000000000000)
        public const long GPT_BASIC_DATA_ATTRIBUTE_HIDDEN = 4611686018427387904;

        /// GPT_ATTRIBUTE_PLATFORM_REQUIRED -> (0x0000000000000001)
        public const int GPT_ATTRIBUTE_PLATFORM_REQUIRED = 1;

        /// GPTR -> (GMEM_FIXED | GMEM_ZEROINIT)
        public const int GPTR = (NativeConstants.GMEM_FIXED | NativeConstants.GMEM_ZEROINIT);

        /// GM_LAST -> 2
        public const int GM_LAST = 2;

        /// GM_COMPATIBLE -> 1
        public const int GM_COMPATIBLE = 1;

        /// GM_ADVANCED -> 2
        public const int GM_ADVANCED = 2;

        /// GMMP_USE_HIGH_RESOLUTION_POINTS -> 2
        public const int GMMP_USE_HIGH_RESOLUTION_POINTS = 2;

        /// GMMP_USE_DISPLAY_POINTS -> 1
        public const int GMMP_USE_DISPLAY_POINTS = 1;

        /// GMEM_ZEROINIT -> 0x0040
        public const int GMEM_ZEROINIT = 64;

        /// GMEM_VALID_FLAGS -> 0x7F72
        public const int GMEM_VALID_FLAGS = 32626;

        /// GMEM_SHARE -> 0x2000
        public const int GMEM_SHARE = 8192;

        /// GMEM_NOT_BANKED -> 0x1000
        public const int GMEM_NOT_BANKED = 4096;

        /// GMEM_NOTIFY -> 0x4000
        public const int GMEM_NOTIFY = 16384;

        /// GMEM_NODISCARD -> 0x0020
        public const int GMEM_NODISCARD = 32;

        /// GMEM_NOCOMPACT -> 0x0010
        public const int GMEM_NOCOMPACT = 16;

        /// GMEM_MOVEABLE -> 0x0002
        public const int GMEM_MOVEABLE = 2;

        /// GMEM_MODIFY -> 0x0080
        public const int GMEM_MODIFY = 128;

        /// GMEM_LOWER -> GMEM_NOT_BANKED
        public const int GMEM_LOWER = NativeConstants.GMEM_NOT_BANKED;

        /// GMEM_LOCKCOUNT -> 0x00FF
        public const int GMEM_LOCKCOUNT = 255;

        /// GMEM_INVALID_HANDLE -> 0x8000
        public const int GMEM_INVALID_HANDLE = 32768;

        /// GMEM_FIXED -> 0x0000
        public const int GMEM_FIXED = 0;

        /// GMEM_DISCARDED -> 0x4000
        public const int GMEM_DISCARDED = 16384;

        /// GMEM_DISCARDABLE -> 0x0100
        public const int GMEM_DISCARDABLE = 256;

        /// GMEM_DDESHARE -> 0x2000
        public const int GMEM_DDESHARE = 8192;

        /// GMDI_USEDISABLED -> 0x0001L
        public const int GMDI_USEDISABLED = 1;

        /// GMDI_GOINTOPOPUPS -> 0x0002L
        public const int GMDI_GOINTOPOPUPS = 2;

        /// GL_LEVEL_WARNING -> 0x00000003
        public const int GL_LEVEL_WARNING = 3;

        /// GL_LEVEL_NOGUIDELINE -> 0x00000000
        public const int GL_LEVEL_NOGUIDELINE = 0;

        /// GL_LEVEL_INFORMATION -> 0x00000004
        public const int GL_LEVEL_INFORMATION = 4;

        /// GL_LEVEL_FATAL -> 0x00000001
        public const int GL_LEVEL_FATAL = 1;

        /// GL_LEVEL_ERROR -> 0x00000002
        public const int GL_LEVEL_ERROR = 2;

        /// GL_ID_UNKNOWN -> 0x00000000
        public const int GL_ID_UNKNOWN = 0;

        /// GL_ID_TYPINGERROR -> 0x00000021
        public const int GL_ID_TYPINGERROR = 33;

        /// GL_ID_TOOMANYSTROKE -> 0x00000022
        public const int GL_ID_TOOMANYSTROKE = 34;

        /// GL_ID_REVERSECONVERSION -> 0x00000029
        public const int GL_ID_REVERSECONVERSION = 41;

        /// GL_ID_READINGCONFLICT -> 0x00000023
        public const int GL_ID_READINGCONFLICT = 35;

        /// GL_ID_PRIVATE_LAST -> 0x0000FFFF
        public const int GL_ID_PRIVATE_LAST = 65535;

        /// GL_ID_PRIVATE_FIRST -> 0x00008000
        public const int GL_ID_PRIVATE_FIRST = 32768;

        /// GL_ID_NOMODULE -> 0x00000001
        public const int GL_ID_NOMODULE = 1;

        /// GL_ID_NODICTIONARY -> 0x00000010
        public const int GL_ID_NODICTIONARY = 16;

        /// GL_ID_NOCONVERT -> 0x00000020
        public const int GL_ID_NOCONVERT = 32;

        /// GL_ID_INPUTSYMBOL -> 0x00000027
        public const int GL_ID_INPUTSYMBOL = 39;

        /// GL_ID_INPUTREADING -> 0x00000024
        public const int GL_ID_INPUTREADING = 36;

        /// GL_ID_INPUTRADICAL -> 0x00000025
        public const int GL_ID_INPUTRADICAL = 37;

        /// GL_ID_INPUTCODE -> 0x00000026
        public const int GL_ID_INPUTCODE = 38;

        /// GL_ID_CHOOSECANDIDATE -> 0x00000028
        public const int GL_ID_CHOOSECANDIDATE = 40;

        /// GL_ID_CANNOTSAVE -> 0x00000011
        public const int GL_ID_CANNOTSAVE = 17;

        /// GlobalGetAtomName -> GlobalGetAtomNameW
        /// Error generating expression: Value GlobalGetAtomNameW is not resolved
        public const string GlobalGetAtomName = "GlobalGetAtomNameW";

        /// GlobalFindAtom -> GlobalFindAtomW
        /// Error generating expression: Value GlobalFindAtomW is not resolved
        public const string GlobalFindAtom = "GlobalFindAtomW";

        /// GlobalAddAtom -> GlobalAddAtomW
        /// Error generating expression: Value GlobalAddAtomW is not resolved
        public const string GlobalAddAtom = "GlobalAddAtomW";

        /// GHND -> (GMEM_MOVEABLE | GMEM_ZEROINIT)
        public const int GHND = (NativeConstants.GMEM_MOVEABLE | NativeConstants.GMEM_ZEROINIT);

        /// GGO_UNHINTED -> 0x0100
        public const int GGO_UNHINTED = 256;

        /// GGO_NATIVE -> 2
        public const int GGO_NATIVE = 2;

        /// GGO_METRICS -> 0
        public const int GGO_METRICS = 0;

        /// GGO_GRAY8_BITMAP -> 6
        public const int GGO_GRAY8_BITMAP = 6;

        /// GGO_GRAY4_BITMAP -> 5
        public const int GGO_GRAY4_BITMAP = 5;

        /// GGO_GRAY2_BITMAP -> 4
        public const int GGO_GRAY2_BITMAP = 4;

        /// GGO_GLYPH_INDEX -> 0x0080
        public const int GGO_GLYPH_INDEX = 128;

        /// GGO_BITMAP -> 1
        public const int GGO_BITMAP = 1;

        /// GGO_BEZIER -> 3
        public const int GGO_BEZIER = 3;

        /// GGL_STRING -> 0x00000003
        public const int GGL_STRING = 3;

        /// GGL_PRIVATE -> 0x00000004
        public const int GGL_PRIVATE = 4;

        /// GGL_LEVEL -> 0x00000001
        public const int GGL_LEVEL = 1;

        /// GGL_INDEX -> 0x00000002
        public const int GGL_INDEX = 2;

        /// GGI_MARK_NONEXISTING_GLYPHS -> 0X0001
        public const int GGI_MARK_NONEXISTING_GLYPHS = 1;

        /// GET_TAPE_MEDIA_INFORMATION -> 0
        public const int GET_TAPE_MEDIA_INFORMATION = 0;

        /// GET_TAPE_DRIVE_INFORMATION -> 1
        public const int GET_TAPE_DRIVE_INFORMATION = 1;

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W -> L"GetSystemWow64DirectoryW"
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W = "GetSystemWow64DirectoryW";

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A -> "GetSystemWow64DirectoryW"
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A = "GetSystemWow64DirectoryW";

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W -> GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W = NativeConstants.GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W;

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T -> GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T = NativeConstants.GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T;

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A -> GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A = NativeConstants.GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A;

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W -> L"GetSystemWow64DirectoryA"
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W = "GetSystemWow64DirectoryA";

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A -> "GetSystemWow64DirectoryA"
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A = "GetSystemWow64DirectoryA";

        /// GET_PS_FEATURESETTING -> 4121
        public const int GET_PS_FEATURESETTING = 4121;

        /// GET_MOUSEORKEY_LPARAM -> GET_DEVICE_LPARAM
        public const string GET_MOUSEORKEY_LPARAM = NativeConstants.GET_DEVICE_LPARAM;

        /// GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT -> (0x00000002)
        public const int GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT = 2;

        /// GET_MODULE_HANDLE_EX_FLAG_PIN -> (0x00000001)
        public const int GET_MODULE_HANDLE_EX_FLAG_PIN = 1;

        /// GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS -> (0x00000004)
        public const int GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = 4;

        /// GET_FEATURE_FROM_THREAD_TRUSTED -> 0x00000020
        public const int GET_FEATURE_FROM_THREAD_TRUSTED = 32;

        /// GET_FEATURE_FROM_THREAD_RESTRICTED -> 0x00000080
        public const int GET_FEATURE_FROM_THREAD_RESTRICTED = 128;

        /// GET_FEATURE_FROM_THREAD_LOCALMACHINE -> 0x00000008
        public const int GET_FEATURE_FROM_THREAD_LOCALMACHINE = 8;

        /// GET_FEATURE_FROM_THREAD_INTRANET -> 0x00000010
        public const int GET_FEATURE_FROM_THREAD_INTRANET = 16;

        /// GET_FEATURE_FROM_THREAD_INTERNET -> 0x00000040
        public const int GET_FEATURE_FROM_THREAD_INTERNET = 64;

        /// GET_FEATURE_FROM_THREAD -> 0x00000001
        public const int GET_FEATURE_FROM_THREAD = 1;

        /// GET_FEATURE_FROM_REGISTRY -> 0x00000004
        public const int GET_FEATURE_FROM_REGISTRY = 4;

        /// GET_FEATURE_FROM_PROCESS -> 0x00000002
        public const int GET_FEATURE_FROM_PROCESS = 2;

        /// GetWindowTextLength -> GetWindowTextLengthW
        /// Error generating expression: Value GetWindowTextLengthW is not resolved
        public const string GetWindowTextLength = "GetWindowTextLengthW";

        /// GetWindowText -> GetWindowTextW
        /// Error generating expression: Value GetWindowTextW is not resolved
        public const string GetWindowText = "GetWindowTextW";

        /// GetWindowsDirectory -> GetWindowsDirectoryW
        /// Error generating expression: Value GetWindowsDirectoryW is not resolved
        public const string GetWindowsDirectory = "GetWindowsDirectoryW";

        /// GetWindowModuleFileName -> GetWindowModuleFileNameW
        /// Error generating expression: Value GetWindowModuleFileNameW is not resolved
        public const string GetWindowModuleFileName = "GetWindowModuleFileNameW";

        /// GetWindowLongPtrW -> GetWindowLongW
        /// Error generating expression: Value GetWindowLongW is not resolved
        public const string GetWindowLongPtrW = "GetWindowLongW";

        /// GetWindowLongPtrA -> GetWindowLongA
        /// Error generating expression: Value GetWindowLongA is not resolved
        public const string GetWindowLongPtrA = "GetWindowLongA";

        /// GetWindowLongPtr -> GetWindowLongPtrW
        public const string GetWindowLongPtr = NativeConstants.GetWindowLongPtrW;

        /// GetWindowLong -> GetWindowLongW
        /// Error generating expression: Value GetWindowLongW is not resolved
        public const string GetWindowLong = "GetWindowLongW";

        /// GetVolumePathNamesForVolumeName -> GetVolumePathNamesForVolumeNameW
        /// Error generating expression: Value GetVolumePathNamesForVolumeNameW is not resolved
        public const string GetVolumePathNamesForVolumeName = "GetVolumePathNamesForVolumeNameW";

        /// GetVolumePathName -> GetVolumePathNameW
        /// Error generating expression: Value GetVolumePathNameW is not resolved
        public const string GetVolumePathName = "GetVolumePathNameW";

        /// GetVolumeNameForVolumeMountPoint -> GetVolumeNameForVolumeMountPointW
        /// Error generating expression: Value GetVolumeNameForVolumeMountPointW is not resolved
        public const string GetVolumeNameForVolumeMountPoint = "GetVolumeNameForVolumeMountPointW";

        /// GetVolumeInformation -> GetVolumeInformationW
        /// Error generating expression: Value GetVolumeInformationW is not resolved
        public const string GetVolumeInformation = "GetVolumeInformationW";

        /// GetVersionEx -> GetVersionExW
        /// Error generating expression: Value GetVersionExW is not resolved
        public const string GetVersionEx = "GetVersionExW";

        /// GETVECTORPENSIZE -> 26
        public const int GETVECTORPENSIZE = 26;

        /// GETVECTORBRUSHSIZE -> 27
        public const int GETVECTORBRUSHSIZE = 27;

        /// GetUserObjectInformation -> GetUserObjectInformationW
        /// Error generating expression: Value GetUserObjectInformationW is not resolved
        public const string GetUserObjectInformation = "GetUserObjectInformationW";

        /// GetUserName -> GetUserNameW
        /// Error generating expression: Value GetUserNameW is not resolved
        public const string GetUserName = "GetUserNameW";

        /// GETTRACKKERNTABLE -> 259
        public const int GETTRACKKERNTABLE = 259;

        /// GetTimeFormat -> GetTimeFormatW
        /// Error generating expression: Value GetTimeFormatW is not resolved
        public const string GetTimeFormat = "GetTimeFormatW";

        /// GetTextMetrics -> GetTextMetricsW
        /// Error generating expression: Value GetTextMetricsW is not resolved
        public const string GetTextMetrics = "GetTextMetricsW";

        /// GetTextFace -> GetTextFaceW
        /// Error generating expression: Value GetTextFaceW is not resolved
        public const string GetTextFace = "GetTextFaceW";

        /// GetTextExtentPoint32 -> GetTextExtentPoint32W
        /// Error generating expression: Value GetTextExtentPoint32W is not resolved
        public const string GetTextExtentPoint32 = "GetTextExtentPoint32W";

        /// GetTextExtentPoint -> GetTextExtentPointW
        /// Error generating expression: Value GetTextExtentPointW is not resolved
        public const string GetTextExtentPoint = "GetTextExtentPointW";

        /// GetTextExtentExPoint -> GetTextExtentExPointW
        /// Error generating expression: Value GetTextExtentExPointW is not resolved
        public const string GetTextExtentExPoint = "GetTextExtentExPointW";

        /// GetTempPath -> GetTempPathW
        /// Error generating expression: Value GetTempPathW is not resolved
        public const string GetTempPath = "GetTempPathW";

        /// GetTempFileName -> GetTempFileNameW
        /// Error generating expression: Value GetTempFileNameW is not resolved
        public const string GetTempFileName = "GetTempFileNameW";

        /// GETTECHNOLOGY -> 20
        public const int GETTECHNOLOGY = 20;

        /// GETTECHNOLGY -> 20
        public const int GETTECHNOLGY = 20;

        /// GetTabbedTextExtent -> GetTabbedTextExtentW
        /// Error generating expression: Value GetTabbedTextExtentW is not resolved
        public const string GetTabbedTextExtent = "GetTabbedTextExtentW";

        /// GetSystemWow64Directory -> GetSystemWow64DirectoryW
        /// Error generating expression: Value GetSystemWow64DirectoryW is not resolved
        public const string GetSystemWow64Directory = "GetSystemWow64DirectoryW";

        /// GetSystemWindowsDirectory -> GetSystemWindowsDirectoryW
        /// Error generating expression: Value GetSystemWindowsDirectoryW is not resolved
        public const string GetSystemWindowsDirectory = "GetSystemWindowsDirectoryW";

        /// GetSystemDirectory -> GetSystemDirectoryW
        /// Error generating expression: Value GetSystemDirectoryW is not resolved
        public const string GetSystemDirectory = "GetSystemDirectoryW";

        /// GetStringTypeEx -> GetStringTypeExW
        /// Error generating expression: Value GetStringTypeExW is not resolved
        public const string GetStringTypeEx = "GetStringTypeExW";

        /// GetStartupInfo -> GetStartupInfoW
        /// Error generating expression: Value GetStartupInfoW is not resolved
        public const string GetStartupInfo = "GetStartupInfoW";

        /// GetShortPathName -> GetShortPathNameW
        /// Error generating expression: Value GetShortPathNameW is not resolved
        public const string GetShortPathName = "GetShortPathNameW";

        /// GETSETSCREENPARAMS -> 3072
        public const int GETSETSCREENPARAMS = 3072;

        /// GETSETPRINTORIENT -> 30
        public const int GETSETPRINTORIENT = 30;

        /// GETSETPAPERMETRICS -> 35
        public const int GETSETPAPERMETRICS = 35;

        /// GETSETPAPERBINS -> 29
        public const int GETSETPAPERBINS = 29;

        /// GetServiceKeyName -> GetServiceKeyNameW
        /// Error generating expression: Value GetServiceKeyNameW is not resolved
        public const string GetServiceKeyName = "GetServiceKeyNameW";

        /// GetServiceDisplayName -> GetServiceDisplayNameW
        /// Error generating expression: Value GetServiceDisplayNameW is not resolved
        public const string GetServiceDisplayName = "GetServiceDisplayNameW";

        /// GETSCALINGFACTOR -> 14
        public const int GETSCALINGFACTOR = 14;

        /// GetSaveFileName -> GetSaveFileNameW
        /// Error generating expression: Value GetSaveFileNameW is not resolved
        public const string GetSaveFileName = "GetSaveFileNameW";

        /// GetRawInputDeviceInfo -> GetRawInputDeviceInfoW
        /// Error generating expression: Value GetRawInputDeviceInfoW is not resolved
        public const string GetRawInputDeviceInfo = "GetRawInputDeviceInfoW";

        /// GetProp -> GetPropW
        /// Error generating expression: Value GetPropW is not resolved
        public const string GetProp = "GetPropW";

        /// GetProfileString -> GetProfileStringW
        /// Error generating expression: Value GetProfileStringW is not resolved
        public const string GetProfileString = "GetProfileStringW";

        /// GetProfileSection -> GetProfileSectionW
        /// Error generating expression: Value GetProfileSectionW is not resolved
        public const string GetProfileSection = "GetProfileSectionW";

        /// GetProfileInt -> GetProfileIntW
        /// Error generating expression: Value GetProfileIntW is not resolved
        public const string GetProfileInt = "GetProfileIntW";

        /// GetPrivateProfileStruct -> GetPrivateProfileStructW
        /// Error generating expression: Value GetPrivateProfileStructW is not resolved
        public const string GetPrivateProfileStruct = "GetPrivateProfileStructW";

        /// GetPrivateProfileString -> GetPrivateProfileStringW
        /// Error generating expression: Value GetPrivateProfileStringW is not resolved
        public const string GetPrivateProfileString = "GetPrivateProfileStringW";

        /// GetPrivateProfileSectionNames -> GetPrivateProfileSectionNamesW
        /// Error generating expression: Value GetPrivateProfileSectionNamesW is not resolved
        public const string GetPrivateProfileSectionNames = "GetPrivateProfileSectionNamesW";

        /// GetPrivateProfileSection -> GetPrivateProfileSectionW
        /// Error generating expression: Value GetPrivateProfileSectionW is not resolved
        public const string GetPrivateProfileSection = "GetPrivateProfileSectionW";

        /// GetPrivateProfileInt -> GetPrivateProfileIntW
        /// Error generating expression: Value GetPrivateProfileIntW is not resolved
        public const string GetPrivateProfileInt = "GetPrivateProfileIntW";

        /// GetPrintProcessorDirectory -> GetPrintProcessorDirectoryW
        /// Error generating expression: Value GetPrintProcessorDirectoryW is not resolved
        public const string GetPrintProcessorDirectory = "GetPrintProcessorDirectoryW";

        /// GETPRINTINGOFFSET -> 13
        public const int GETPRINTINGOFFSET = 13;

        /// GetPrinterDriverDirectory -> GetPrinterDriverDirectoryW
        /// Error generating expression: Value GetPrinterDriverDirectoryW is not resolved
        public const string GetPrinterDriverDirectory = "GetPrinterDriverDirectoryW";

        /// GetPrinterDriver -> GetPrinterDriverW
        /// Error generating expression: Value GetPrinterDriverW is not resolved
        public const string GetPrinterDriver = "GetPrinterDriverW";

        /// GetPrinterDataEx -> GetPrinterDataExW
        /// Error generating expression: Value GetPrinterDataExW is not resolved
        public const string GetPrinterDataEx = "GetPrinterDataExW";

        /// GetPrinterData -> GetPrinterDataW
        /// Error generating expression: Value GetPrinterDataW is not resolved
        public const string GetPrinterData = "GetPrinterDataW";

        /// GetPrinter -> GetPrinterW
        /// Error generating expression: Value GetPrinterW is not resolved
        public const string GetPrinter = "GetPrinterW";

        /// GETPHYSPAGESIZE -> 12
        public const int GETPHYSPAGESIZE = 12;

        /// GETPENWIDTH -> 16
        public const int GETPENWIDTH = 16;

        /// GETPAIRKERNTABLE -> 258
        public const int GETPAIRKERNTABLE = 258;

        /// GetOutlineTextMetrics -> GetOutlineTextMetricsW
        /// Error generating expression: Value GetOutlineTextMetricsW is not resolved
        public const string GetOutlineTextMetrics = "GetOutlineTextMetricsW";

        /// GetOpenFileName -> GetOpenFileNameW
        /// Error generating expression: Value GetOpenFileNameW is not resolved
        public const string GetOpenFileName = "GetOpenFileNameW";

        /// GetOpenCardName -> GetOpenCardNameW
        /// Error generating expression: Value GetOpenCardNameW is not resolved
        public const string GetOpenCardName = "GetOpenCardNameW";

        /// GetObject -> GetObjectW
        /// Error generating expression: Value GetObjectW is not resolved
        public const string GetObject = "GetObjectW";

        /// GetNumberFormat -> GetNumberFormatW
        /// Error generating expression: Value GetNumberFormatW is not resolved
        public const string GetNumberFormat = "GetNumberFormatW";

        /// GetNamedPipeHandleState -> GetNamedPipeHandleStateW
        /// Error generating expression: Value GetNamedPipeHandleStateW is not resolved
        public const string GetNamedPipeHandleState = "GetNamedPipeHandleStateW";

        /// GetMonitorInfo -> GetMonitorInfoW
        /// Error generating expression: Value GetMonitorInfoW is not resolved
        public const string GetMonitorInfo = "GetMonitorInfoW";

        /// GetModuleHandleEx -> GetModuleHandleExW
        /// Error generating expression: Value GetModuleHandleExW is not resolved
        public const string GetModuleHandleEx = "GetModuleHandleExW";

        /// GetModuleHandle -> GetModuleHandleW
        /// Error generating expression: Value GetModuleHandleW is not resolved
        public const string GetModuleHandle = "GetModuleHandleW";

        /// GetModuleFileName -> GetModuleFileNameW
        /// Error generating expression: Value GetModuleFileNameW is not resolved
        public const string GetModuleFileName = "GetModuleFileNameW";

        /// GetMetaFile -> GetMetaFileW
        /// Error generating expression: Value GetMetaFileW is not resolved
        public const string GetMetaFile = "GetMetaFileW";

        /// GetMessage -> GetMessageW
        /// Error generating expression: Value GetMessageW is not resolved
        public const string GetMessage = "GetMessageW";

        /// GetMenuString -> GetMenuStringW
        /// Error generating expression: Value GetMenuStringW is not resolved
        public const string GetMenuString = "GetMenuStringW";

        /// GetMenuItemInfo -> GetMenuItemInfoW
        /// Error generating expression: Value GetMenuItemInfoW is not resolved
        public const string GetMenuItemInfo = "GetMenuItemInfoW";

        /// GetLongPathName -> GetLongPathNameW
        /// Error generating expression: Value GetLongPathNameW is not resolved
        public const string GetLongPathName = "GetLongPathNameW";

        /// GetLogicalDriveStrings -> GetLogicalDriveStringsW
        /// Error generating expression: Value GetLogicalDriveStringsW is not resolved
        public const string GetLogicalDriveStrings = "GetLogicalDriveStringsW";

        /// GetLogColorSpace -> GetLogColorSpaceW
        /// Error generating expression: Value GetLogColorSpaceW is not resolved
        public const string GetLogColorSpace = "GetLogColorSpaceW";

        /// GetLocaleInfo -> GetLocaleInfoW
        /// Error generating expression: Value GetLocaleInfoW is not resolved
        public const string GetLocaleInfo = "GetLocaleInfoW";

        /// GetKeyNameText -> GetKeyNameTextW
        /// Error generating expression: Value GetKeyNameTextW is not resolved
        public const string GetKeyNameText = "GetKeyNameTextW";

        /// GetKeyboardLayoutName -> GetKeyboardLayoutNameW
        /// Error generating expression: Value GetKeyboardLayoutNameW is not resolved
        public const string GetKeyboardLayoutName = "GetKeyboardLayoutNameW";

        /// GetKerningPairs -> GetKerningPairsW
        /// Error generating expression: Value GetKerningPairsW is not resolved
        public const string GetKerningPairs = "GetKerningPairsW";

        /// GetJob -> GetJobW
        /// Error generating expression: Value GetJobW is not resolved
        public const string GetJob = "GetJobW";

        /// GetICMProfile -> GetICMProfileW
        /// Error generating expression: Value GetICMProfileW is not resolved
        public const string GetICMProfile = "GetICMProfileW";

        /// GetGlyphOutline -> GetGlyphOutlineW
        /// Error generating expression: Value GetGlyphOutlineW is not resolved
        public const string GetGlyphOutline = "GetGlyphOutlineW";

        /// GetGlyphIndices -> GetGlyphIndicesW
        /// Error generating expression: Value GetGlyphIndicesW is not resolved
        public const string GetGlyphIndices = "GetGlyphIndicesW";

        /// GetGeoInfo -> GetGeoInfoW
        /// Error generating expression: Value GetGeoInfoW is not resolved
        public const string GetGeoInfo = "GetGeoInfoW";

        /// GetFullPathName -> GetFullPathNameW
        /// Error generating expression: Value GetFullPathNameW is not resolved
        public const string GetFullPathName = "GetFullPathNameW";

        /// GetForm -> GetFormW
        /// Error generating expression: Value GetFormW is not resolved
        public const string GetForm = "GetFormW";

        /// GetFirmwareEnvironmentVariable -> GetFirmwareEnvironmentVariableW
        /// Error generating expression: Value GetFirmwareEnvironmentVariableW is not resolved
        public const string GetFirmwareEnvironmentVariable = "GetFirmwareEnvironmentVariableW";

        /// GetFileVersionInfoSize -> GetFileVersionInfoSizeW
        /// Error generating expression: Value GetFileVersionInfoSizeW is not resolved
        public const string GetFileVersionInfoSize = "GetFileVersionInfoSizeW";

        /// GetFileVersionInfo -> GetFileVersionInfoW
        /// Error generating expression: Value GetFileVersionInfoW is not resolved
        public const string GetFileVersionInfo = "GetFileVersionInfoW";

        /// GetFileTitle -> GetFileTitleW
        /// Error generating expression: Value GetFileTitleW is not resolved
        public const string GetFileTitle = "GetFileTitleW";

        /// GetFileSecurity -> GetFileSecurityW
        /// Error generating expression: Value GetFileSecurityW is not resolved
        public const string GetFileSecurity = "GetFileSecurityW";

        /// GetFileAttributesEx -> GetFileAttributesExW
        /// Error generating expression: Value GetFileAttributesExW is not resolved
        public const string GetFileAttributesEx = "GetFileAttributesExW";

        /// GetFileAttributes -> GetFileAttributesW
        /// Error generating expression: Value GetFileAttributesW is not resolved
        public const string GetFileAttributes = "GetFileAttributesW";

        /// GETFACENAME -> 513
        public const int GETFACENAME = 513;

        /// GETEXTENTTABLE -> 257
        public const int GETEXTENTTABLE = 257;

        /// GETEXTENDEDTEXTMETRICS -> 256
        public const int GETEXTENDEDTEXTMETRICS = 256;

        /// GetExpandedName -> GetExpandedNameW
        /// Error generating expression: Value GetExpandedNameW is not resolved
        public const string GetExpandedName = "GetExpandedNameW";

        /// GetExceptionCode -> _exception_code
        /// Error generating expression: Value _exception_code is not resolved
        public const string GetExceptionCode = "_exception_code";

        /// GetEnvironmentVariable -> GetEnvironmentVariableW
        /// Error generating expression: Value GetEnvironmentVariableW is not resolved
        public const string GetEnvironmentVariable = "GetEnvironmentVariableW";

        /// GetEnvironmentStrings -> GetEnvironmentStringsW
        /// Error generating expression: Value GetEnvironmentStringsW is not resolved
        public const string GetEnvironmentStrings = "GetEnvironmentStringsW";

        /// GetEnhMetaFileDescription -> GetEnhMetaFileDescriptionW
        /// Error generating expression: Value GetEnhMetaFileDescriptionW is not resolved
        public const string GetEnhMetaFileDescription = "GetEnhMetaFileDescriptionW";

        /// GetEnhMetaFile -> GetEnhMetaFileW
        /// Error generating expression: Value GetEnhMetaFileW is not resolved
        public const string GetEnhMetaFile = "GetEnhMetaFileW";

        /// GetDriveType -> GetDriveTypeW
        /// Error generating expression: Value GetDriveTypeW is not resolved
        public const string GetDriveType = "GetDriveTypeW";

        /// GetDllDirectory -> GetDllDirectoryW
        /// Error generating expression: Value GetDllDirectoryW is not resolved
        public const string GetDllDirectory = "GetDllDirectoryW";

        /// GetDlgItemText -> GetDlgItemTextW
        /// Error generating expression: Value GetDlgItemTextW is not resolved
        public const string GetDlgItemText = "GetDlgItemTextW";

        /// GetDiskFreeSpaceEx -> GetDiskFreeSpaceExW
        /// Error generating expression: Value GetDiskFreeSpaceExW is not resolved
        public const string GetDiskFreeSpaceEx = "GetDiskFreeSpaceExW";

        /// GetDiskFreeSpace -> GetDiskFreeSpaceW
        /// Error generating expression: Value GetDiskFreeSpaceW is not resolved
        public const string GetDiskFreeSpace = "GetDiskFreeSpaceW";

        /// GETDEVICEUNITS -> 42
        public const int GETDEVICEUNITS = 42;

        /// GetDefaultPrinter -> GetDefaultPrinterW
        /// Error generating expression: Value GetDefaultPrinterW is not resolved
        public const string GetDefaultPrinter = "GetDefaultPrinterW";

        /// GetDefaultCommConfig -> GetDefaultCommConfigW
        /// Error generating expression: Value GetDefaultCommConfigW is not resolved
        public const string GetDefaultCommConfig = "GetDefaultCommConfigW";

        /// GetDateFormat -> GetDateFormatW
        /// Error generating expression: Value GetDateFormatW is not resolved
        public const string GetDateFormat = "GetDateFormatW";

        /// GetCurrentHwProfile -> GetCurrentHwProfileW
        /// Error generating expression: Value GetCurrentHwProfileW is not resolved
        public const string GetCurrentHwProfile = "GetCurrentHwProfileW";

        /// GetCurrentDirectory -> GetCurrentDirectoryW
        /// Error generating expression: Value GetCurrentDirectoryW is not resolved
        public const string GetCurrentDirectory = "GetCurrentDirectoryW";

        /// GetCurrencyFormat -> GetCurrencyFormatW
        /// Error generating expression: Value GetCurrencyFormatW is not resolved
        public const string GetCurrencyFormat = "GetCurrencyFormatW";

        /// GetCPInfoEx -> GetCPInfoExW
        /// Error generating expression: Value GetCPInfoExW is not resolved
        public const string GetCPInfoEx = "GetCPInfoExW";

        /// GetConsoleTitle -> GetConsoleTitleW
        /// Error generating expression: Value GetConsoleTitleW is not resolved
        public const string GetConsoleTitle = "GetConsoleTitleW";

        /// GetConsoleAliasExesLength -> GetConsoleAliasExesLengthW
        /// Error generating expression: Value GetConsoleAliasExesLengthW is not resolved
        public const string GetConsoleAliasExesLength = "GetConsoleAliasExesLengthW";

        /// GetConsoleAliasExes -> GetConsoleAliasExesW
        /// Error generating expression: Value GetConsoleAliasExesW is not resolved
        public const string GetConsoleAliasExes = "GetConsoleAliasExesW";

        /// GetConsoleAliasesLength -> GetConsoleAliasesLengthW
        /// Error generating expression: Value GetConsoleAliasesLengthW is not resolved
        public const string GetConsoleAliasesLength = "GetConsoleAliasesLengthW";

        /// GetConsoleAliases -> GetConsoleAliasesW
        /// Error generating expression: Value GetConsoleAliasesW is not resolved
        public const string GetConsoleAliases = "GetConsoleAliasesW";

        /// GetConsoleAlias -> GetConsoleAliasW
        /// Error generating expression: Value GetConsoleAliasW is not resolved
        public const string GetConsoleAlias = "GetConsoleAliasW";

        /// GetComputerNameEx -> GetComputerNameExW
        /// Error generating expression: Value GetComputerNameExW is not resolved
        public const string GetComputerNameEx = "GetComputerNameExW";

        /// GetComputerName -> GetComputerNameW
        /// Error generating expression: Value GetComputerNameW is not resolved
        public const string GetComputerName = "GetComputerNameW";

        /// GetCompressedFileSize -> GetCompressedFileSizeW
        /// Error generating expression: Value GetCompressedFileSizeW is not resolved
        public const string GetCompressedFileSize = "GetCompressedFileSizeW";

        /// GetCommandLine -> GetCommandLineW
        /// Error generating expression: Value GetCommandLineW is not resolved
        public const string GetCommandLine = "GetCommandLineW";

        /// GETCOLORTABLE -> 5
        public const int GETCOLORTABLE = 5;

        /// GetClipboardFormatName -> GetClipboardFormatNameW
        /// Error generating expression: Value GetClipboardFormatNameW is not resolved
        public const string GetClipboardFormatName = "GetClipboardFormatNameW";

        /// GetClassName -> GetClassNameW
        /// Error generating expression: Value GetClassNameW is not resolved
        public const string GetClassName = "GetClassNameW";

        /// GetClassLongPtrW -> GetClassLongW
        /// Error generating expression: Value GetClassLongW is not resolved
        public const string GetClassLongPtrW = "GetClassLongW";

        /// GetClassLongPtrA -> GetClassLongA
        /// Error generating expression: Value GetClassLongA is not resolved
        public const string GetClassLongPtrA = "GetClassLongA";

        /// GetClassLongPtr -> GetClassLongPtrW
        public const string GetClassLongPtr = NativeConstants.GetClassLongPtrW;

        /// GetClassLong -> GetClassLongW
        /// Error generating expression: Value GetClassLongW is not resolved
        public const string GetClassLong = "GetClassLongW";

        /// GetClassInfoEx -> GetClassInfoExW
        /// Error generating expression: Value GetClassInfoExW is not resolved
        public const string GetClassInfoEx = "GetClassInfoExW";

        /// GetClassInfo -> GetClassInfoW
        /// Error generating expression: Value GetClassInfoW is not resolved
        public const string GetClassInfo = "GetClassInfoW";

        /// GetCharWidthFloat -> GetCharWidthFloatW
        /// Error generating expression: Value GetCharWidthFloatW is not resolved
        public const string GetCharWidthFloat = "GetCharWidthFloatW";

        /// GetCharWidth32 -> GetCharWidth32W
        /// Error generating expression: Value GetCharWidth32W is not resolved
        public const string GetCharWidth32 = "GetCharWidth32W";

        /// GetCharWidth -> GetCharWidthW
        /// Error generating expression: Value GetCharWidthW is not resolved
        public const string GetCharWidth = "GetCharWidthW";

        /// GetCharacterPlacement -> GetCharacterPlacementW
        /// Error generating expression: Value GetCharacterPlacementW is not resolved
        public const string GetCharacterPlacement = "GetCharacterPlacementW";

        /// GetCharABCWidthsFloat -> GetCharABCWidthsFloatW
        /// Error generating expression: Value GetCharABCWidthsFloatW is not resolved
        public const string GetCharABCWidthsFloat = "GetCharABCWidthsFloatW";

        /// GetCharABCWidths -> GetCharABCWidthsW
        /// Error generating expression: Value GetCharABCWidthsW is not resolved
        public const string GetCharABCWidths = "GetCharABCWidthsW";

        /// GetCalendarInfo -> GetCalendarInfoW
        /// Error generating expression: Value GetCalendarInfoW is not resolved
        public const string GetCalendarInfo = "GetCalendarInfoW";

        /// GetBinaryType -> GetBinaryTypeW
        /// Error generating expression: Value GetBinaryTypeW is not resolved
        public const string GetBinaryType = "GetBinaryTypeW";

        /// GetAtomName -> GetAtomNameW
        /// Error generating expression: Value GetAtomNameW is not resolved
        public const string GetAtomName = "GetAtomNameW";

        /// GetAltTabInfo -> GetAltTabInfoW
        /// Error generating expression: Value GetAltTabInfoW is not resolved
        public const string GetAltTabInfo = "GetAltTabInfoW";

        /// GEOID_NOT_AVAILABLE -> -1
        public const int GEOID_NOT_AVAILABLE = -1;

        /// GENERIC_WRITE -> (0x40000000L)
        public const int GENERIC_WRITE = 1073741824;

        /// GENERIC_READ -> (0x80000000L)
        public const int GENERIC_READ = -2147483648;

        /// GENERIC_EXECUTE -> (0x20000000L)
        public const int GENERIC_EXECUTE = 536870912;

        /// GENERIC_ALL -> (0x10000000L)
        public const int GENERIC_ALL = 268435456;

        /// GDI_ERROR -> (0xFFFFFFFFL)
        public const int GDI_ERROR = -1;

        /// GDICOMMENT_WINDOWS_METAFILE -> 0x80000001
        public const int GDICOMMENT_WINDOWS_METAFILE = -2147483647;

        /// GDICOMMENT_UNICODE_STRING -> 0x00000040
        public const int GDICOMMENT_UNICODE_STRING = 64;

        /// GDICOMMENT_UNICODE_END -> 0x00000080
        public const int GDICOMMENT_UNICODE_END = 128;

        /// GDICOMMENT_MULTIFORMATS -> 0x40000004
        public const int GDICOMMENT_MULTIFORMATS = 1073741828;

        /// GDICOMMENT_IDENTIFIER -> 0x43494447
        public const int GDICOMMENT_IDENTIFIER = 1128875079;

        /// GDICOMMENT_ENDGROUP -> 0x00000003
        public const int GDICOMMENT_ENDGROUP = 3;

        /// GDICOMMENT_BEGINGROUP -> 0x00000002
        public const int GDICOMMENT_BEGINGROUP = 2;

        /// GCW_ATOM -> (-32)
        public const int GCW_ATOM = -32;

        /// GCS_RESULTSTR -> 0x0800
        public const int GCS_RESULTSTR = 2048;

        /// GCS_RESULTREADSTR -> 0x0200
        public const int GCS_RESULTREADSTR = 512;

        /// GCS_RESULTREADCLAUSE -> 0x0400
        public const int GCS_RESULTREADCLAUSE = 1024;

        /// GCS_RESULTCLAUSE -> 0x1000
        public const int GCS_RESULTCLAUSE = 4096;

        /// GCS_DELTASTART -> 0x0100
        public const int GCS_DELTASTART = 256;

        /// GCS_CURSORPOS -> 0x0080
        public const int GCS_CURSORPOS = 128;

        /// GCS_COMPSTR -> 0x0008
        public const int GCS_COMPSTR = 8;

        /// GCS_COMPREADSTR -> 0x0001
        public const int GCS_COMPREADSTR = 1;

        /// GCS_COMPREADCLAUSE -> 0x0004
        public const int GCS_COMPREADCLAUSE = 4;

        /// GCS_COMPREADATTR -> 0x0002
        public const int GCS_COMPREADATTR = 2;

        /// GCS_COMPCLAUSE -> 0x0020
        public const int GCS_COMPCLAUSE = 32;

        /// GCS_COMPATTR -> 0x0010
        public const int GCS_COMPATTR = 16;

        /// GCP_USEKERNING -> 0x0008
        public const int GCP_USEKERNING = 8;

        /// GCP_SYMSWAPOFF -> 0x00800000L
        public const int GCP_SYMSWAPOFF = 8388608;

        /// GCP_REORDER -> 0x0002
        public const int GCP_REORDER = 2;

        /// GCP_NUMERICSLOCAL -> 0x08000000L
        public const int GCP_NUMERICSLOCAL = 134217728;

        /// GCP_NUMERICSLATIN -> 0x04000000L
        public const int GCP_NUMERICSLATIN = 67108864;

        /// GCP_NUMERICOVERRIDE -> 0x01000000L
        public const int GCP_NUMERICOVERRIDE = 16777216;

        /// GCP_NEUTRALOVERRIDE -> 0x02000000L
        public const int GCP_NEUTRALOVERRIDE = 33554432;

        /// GCP_MAXEXTENT -> 0x00100000L
        public const int GCP_MAXEXTENT = 1048576;

        /// GCP_LIGATE -> 0x0020
        public const int GCP_LIGATE = 32;

        /// GCP_KASHIDA -> 0x0400
        public const int GCP_KASHIDA = 1024;

        /// GCP_JUSTIFYIN -> 0x00200000L
        public const int GCP_JUSTIFYIN = 2097152;

        /// GCP_JUSTIFY -> 0x00010000L
        public const int GCP_JUSTIFY = 65536;

        /// GCP_GLYPHSHAPE -> 0x0010
        public const int GCP_GLYPHSHAPE = 16;

        /// GCP_ERROR -> 0x8000
        public const int GCP_ERROR = 32768;

        /// GCP_DISPLAYZWG -> 0x00400000L
        public const int GCP_DISPLAYZWG = 4194304;

        /// GCP_DIACRITIC -> 0x0100
        public const int GCP_DIACRITIC = 256;

        /// GCP_DBCS -> 0x0001
        public const int GCP_DBCS = 1;

        /// GCP_CLASSIN -> 0x00080000L
        public const int GCP_CLASSIN = 524288;

        /// GCPGLYPH_LINKBEFORE -> 0x8000
        public const int GCPGLYPH_LINKBEFORE = 32768;

        /// GCPGLYPH_LINKAFTER -> 0x4000
        public const int GCPGLYPH_LINKAFTER = 16384;

        /// GCPCLASS_PREBOUNDRTL -> 0x40
        public const int GCPCLASS_PREBOUNDRTL = 64;

        /// GCPCLASS_PREBOUNDLTR -> 0x80
        public const int GCPCLASS_PREBOUNDLTR = 128;

        /// GCPCLASS_POSTBOUNDRTL -> 0x10
        public const int GCPCLASS_POSTBOUNDRTL = 16;

        /// GCPCLASS_POSTBOUNDLTR -> 0x20
        public const int GCPCLASS_POSTBOUNDLTR = 32;

        /// GCPCLASS_NUMERICSEPARATOR -> 8
        public const int GCPCLASS_NUMERICSEPARATOR = 8;

        /// GCPCLASS_NEUTRAL -> 3
        public const int GCPCLASS_NEUTRAL = 3;

        /// GCPCLASS_LOCALNUMBER -> 4
        public const int GCPCLASS_LOCALNUMBER = 4;

        /// GCPCLASS_LATINNUMERICTERMINATOR -> 6
        public const int GCPCLASS_LATINNUMERICTERMINATOR = 6;

        /// GCPCLASS_LATINNUMERICSEPARATOR -> 7
        public const int GCPCLASS_LATINNUMERICSEPARATOR = 7;

        /// GCPCLASS_LATINNUMBER -> 5
        public const int GCPCLASS_LATINNUMBER = 5;

        /// GCPCLASS_LATIN -> 1
        public const int GCPCLASS_LATIN = 1;

        /// GCPCLASS_HEBREW -> 2
        public const int GCPCLASS_HEBREW = 2;

        /// GCPCLASS_ARABIC -> 2
        public const int GCPCLASS_ARABIC = 2;

        /// GCL_WNDPROC -> (-24)
        public const int GCL_WNDPROC = -24;

        /// GCL_STYLE -> (-26)
        public const int GCL_STYLE = -26;

        /// GCL_REVERSE_LENGTH -> 0x0003
        public const int GCL_REVERSE_LENGTH = 3;

        /// GCL_REVERSECONVERSION -> 0x0002
        public const int GCL_REVERSECONVERSION = 2;

        /// GCL_MENUNAME -> (-8)
        public const int GCL_MENUNAME = -8;

        /// GCL_HMODULE -> (-16)
        public const int GCL_HMODULE = -16;

        /// GCL_HICONSM -> (-34)
        public const int GCL_HICONSM = -34;

        /// GCL_HICON -> (-14)
        public const int GCL_HICON = -14;

        /// GCL_HCURSOR -> (-12)
        public const int GCL_HCURSOR = -12;

        /// GCL_HBRBACKGROUND -> (-10)
        public const int GCL_HBRBACKGROUND = -10;

        /// GCL_CONVERSION -> 0x0001
        public const int GCL_CONVERSION = 1;

        /// GCL_CBWNDEXTRA -> (-18)
        public const int GCL_CBWNDEXTRA = -18;

        /// GCL_CBCLSEXTRA -> (-20)
        public const int GCL_CBCLSEXTRA = -20;

        /// GCLP_WNDPROC -> (-24)
        public const int GCLP_WNDPROC = -24;

        /// GCLP_MENUNAME -> (-8)
        public const int GCLP_MENUNAME = -8;

        /// GCLP_HMODULE -> (-16)
        public const int GCLP_HMODULE = -16;

        /// GCLP_HICONSM -> (-34)
        public const int GCLP_HICONSM = -34;

        /// GCLP_HICON -> (-14)
        public const int GCLP_HICON = -14;

        /// GCLP_HCURSOR -> (-12)
        public const int GCLP_HCURSOR = -12;

        /// GCLP_HBRBACKGROUND -> (-10)
        public const int GCLP_HBRBACKGROUND = -10;

        /// GB2312_CHARSET -> 134
        public const int GB2312_CHARSET = 134;

        /// GA_ROOTOWNER -> 3
        public const int GA_ROOTOWNER = 3;

        /// GA_ROOT -> 2
        public const int GA_ROOT = 2;

        /// GA_PARENT -> 1
        public const int GA_PARENT = 1;

        /// GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T -> TEXT("GetSystemWow64DirectoryW")
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T = "TEXT(\"GetSystemWow64DirectoryW\")";

        /// Warning: Generation of Method Macros is not supported at this time
        /// GET_DEVICE_LPARAM -> "(lParam) ((WORD)(HIWORD(lParam) & FAPPCOMMAND_MASK))"
        public const string GET_DEVICE_LPARAM = "(lParam) ((WORD)(HIWORD(lParam) & FAPPCOMMAND_MASK))";
    }

}
