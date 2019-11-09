using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ZONEATTRIBUTES
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;

        /// WCHAR[200]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 200)]
        public string szDescription;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szIconPath;

        /// DWORD->unsigned int
        public uint dwTemplateMinLevel;

        /// DWORD->unsigned int
        public uint dwTemplateRecommended;

        /// DWORD->unsigned int
        public uint dwTemplateCurrentLevel;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    public enum ZAFLAGS
    {

        /// ZAFLAGS_CUSTOM_EDIT -> 0x1
        ZAFLAGS_CUSTOM_EDIT = 1,

        /// ZAFLAGS_ADD_SITES -> 0x2
        ZAFLAGS_ADD_SITES = 2,

        /// ZAFLAGS_REQUIRE_VERIFICATION -> 0x4
        ZAFLAGS_REQUIRE_VERIFICATION = 4,

        /// ZAFLAGS_INCLUDE_PROXY_OVERRIDE -> 0x8
        ZAFLAGS_INCLUDE_PROXY_OVERRIDE = 8,

        /// ZAFLAGS_INCLUDE_INTRANET_SITES -> 0x10
        ZAFLAGS_INCLUDE_INTRANET_SITES = 16,

        /// ZAFLAGS_NO_UI -> 0x20
        ZAFLAGS_NO_UI = 32,

        /// ZAFLAGS_SUPPORTS_VERIFICATION -> 0x40
        ZAFLAGS_SUPPORTS_VERIFICATION = 64,

        /// ZAFLAGS_UNC_AS_INTRANET -> 0x80
        ZAFLAGS_UNC_AS_INTRANET = 128,

        /// ZAFLAGS_USE_LOCKED_ZONES -> 0x10000
        ZAFLAGS_USE_LOCKED_ZONES = 65536,
    }

}
