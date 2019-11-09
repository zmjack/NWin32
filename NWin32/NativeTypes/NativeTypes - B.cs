using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BY_HANDLE_FILE_INFORMATION
    {

        /// DWORD->unsigned int
        public uint dwFileAttributes;

        /// FILETIME->_FILETIME
        public FILETIME ftCreationTime;

        /// FILETIME->_FILETIME
        public FILETIME ftLastAccessTime;

        /// FILETIME->_FILETIME
        public FILETIME ftLastWriteTime;

        /// DWORD->unsigned int
        public uint dwVolumeSerialNumber;

        /// DWORD->unsigned int
        public uint nFileSizeHigh;

        /// DWORD->unsigned int
        public uint nFileSizeLow;

        /// DWORD->unsigned int
        public uint nNumberOfLinks;

        /// DWORD->unsigned int
        public uint nFileIndexHigh;

        /// DWORD->unsigned int
        public uint nFileIndexLow;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BYTE_SIZEDARR
    {

        /// unsigned int
        public uint clSize;

        /// byte*
        public IntPtr pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BYTE_BLOB
    {

        /// unsigned int
        public uint clSize;

        /// byte[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] abData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BULK_SECURITY_TEST_DATA
    {

        /// ACCESS_MASK->DWORD->unsigned int
        public uint DesiredAccess;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] SecurityIds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BSMINFO
    {

        /// UINT->unsigned int
        public uint cbSize;

        /// HDESK->HDESK__*
        public IntPtr hdesk;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// LUID->_LUID
        public LUID luid;
    }

    public enum BSCF
    {

        /// BSCF_FIRSTDATANOTIFICATION -> 0x1
        BSCF_FIRSTDATANOTIFICATION = 1,

        /// BSCF_INTERMEDIATEDATANOTIFICATION -> 0x2
        BSCF_INTERMEDIATEDATANOTIFICATION = 2,

        /// BSCF_LASTDATANOTIFICATION -> 0x4
        BSCF_LASTDATANOTIFICATION = 4,

        /// BSCF_DATAFULLYAVAILABLE -> 0x8
        BSCF_DATAFULLYAVAILABLE = 8,

        /// BSCF_AVAILABLEDATASIZEUNKNOWN -> 0x10
        BSCF_AVAILABLEDATASIZEUNKNOWN = 16,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct brecVal
    {

        /// PVOID->void*
        public IntPtr pvRecord;

        /// IRecordInfo*
        public IntPtr pRecInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BLENDFUNCTION
    {

        /// BYTE->unsigned char
        public byte BlendOp;

        /// BYTE->unsigned char
        public byte BlendFlags;

        /// BYTE->unsigned char
        public byte SourceConstantAlpha;

        /// BYTE->unsigned char
        public byte AlphaFormat;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPV5HEADER
    {

        /// DWORD->unsigned int
        public uint bV5Size;

        /// LONG->int
        public int bV5Width;

        /// LONG->int
        public int bV5Height;

        /// WORD->unsigned short
        public ushort bV5Planes;

        /// WORD->unsigned short
        public ushort bV5BitCount;

        /// DWORD->unsigned int
        public uint bV5Compression;

        /// DWORD->unsigned int
        public uint bV5SizeImage;

        /// LONG->int
        public int bV5XPelsPerMeter;

        /// LONG->int
        public int bV5YPelsPerMeter;

        /// DWORD->unsigned int
        public uint bV5ClrUsed;

        /// DWORD->unsigned int
        public uint bV5ClrImportant;

        /// DWORD->unsigned int
        public uint bV5RedMask;

        /// DWORD->unsigned int
        public uint bV5GreenMask;

        /// DWORD->unsigned int
        public uint bV5BlueMask;

        /// DWORD->unsigned int
        public uint bV5AlphaMask;

        /// DWORD->unsigned int
        public uint bV5CSType;

        /// CIEXYZTRIPLE->tagICEXYZTRIPLE
        public tagICEXYZTRIPLE bV5Endpoints;

        /// DWORD->unsigned int
        public uint bV5GammaRed;

        /// DWORD->unsigned int
        public uint bV5GammaGreen;

        /// DWORD->unsigned int
        public uint bV5GammaBlue;

        /// DWORD->unsigned int
        public uint bV5Intent;

        /// DWORD->unsigned int
        public uint bV5ProfileData;

        /// DWORD->unsigned int
        public uint bV5ProfileSize;

        /// DWORD->unsigned int
        public uint bV5Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPV4HEADER
    {

        /// DWORD->unsigned int
        public uint bV4Size;

        /// LONG->int
        public int bV4Width;

        /// LONG->int
        public int bV4Height;

        /// WORD->unsigned short
        public ushort bV4Planes;

        /// WORD->unsigned short
        public ushort bV4BitCount;

        /// DWORD->unsigned int
        public uint bV4V4Compression;

        /// DWORD->unsigned int
        public uint bV4SizeImage;

        /// LONG->int
        public int bV4XPelsPerMeter;

        /// LONG->int
        public int bV4YPelsPerMeter;

        /// DWORD->unsigned int
        public uint bV4ClrUsed;

        /// DWORD->unsigned int
        public uint bV4ClrImportant;

        /// DWORD->unsigned int
        public uint bV4RedMask;

        /// DWORD->unsigned int
        public uint bV4GreenMask;

        /// DWORD->unsigned int
        public uint bV4BlueMask;

        /// DWORD->unsigned int
        public uint bV4AlphaMask;

        /// DWORD->unsigned int
        public uint bV4CSType;

        /// CIEXYZTRIPLE->tagICEXYZTRIPLE
        public tagICEXYZTRIPLE bV4Endpoints;

        /// DWORD->unsigned int
        public uint bV4GammaRed;

        /// DWORD->unsigned int
        public uint bV4GammaGreen;

        /// DWORD->unsigned int
        public uint bV4GammaBlue;
    }

    public enum BIN_TYPES
    {

        RequestSize,

        RequestLocation,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIN_RESULTS
    {

        /// DWORD->unsigned int
        public uint NumberOfBins;

        /// BIN_COUNT[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public BIN_COUNT[] BinCounts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIN_RANGE
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartValue;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIN_COUNT
    {

        /// BIN_RANGE->_BIN_RANGE
        public BIN_RANGE BinRange;

        /// DWORD->unsigned int
        public uint BinCount;
    }

    public enum BINDVERB
    {

        /// BINDVERB_GET -> 0
        BINDVERB_GET = 0,

        /// BINDVERB_POST -> 0x1
        BINDVERB_POST = 1,

        /// BINDVERB_PUT -> 0x2
        BINDVERB_PUT = 2,

        /// BINDVERB_CUSTOM -> 0x3
        BINDVERB_CUSTOM = 3,
    }

    public enum BINDINFO_OPTIONS
    {

        /// BINDINFO_OPTIONS_WININETFLAG -> 0x10000
        BINDINFO_OPTIONS_WININETFLAG = 65536,

        /// BINDINFO_OPTIONS_ENABLE_UTF8 -> 0x20000
        BINDINFO_OPTIONS_ENABLE_UTF8 = 131072,

        /// BINDINFO_OPTIONS_DISABLE_UTF8 -> 0x40000
        BINDINFO_OPTIONS_DISABLE_UTF8 = 262144,

        /// BINDINFO_OPTIONS_USE_IE_ENCODING -> 0x80000
        BINDINFO_OPTIONS_USE_IE_ENCODING = 524288,

        /// BINDINFO_OPTIONS_BINDTOOBJECT -> 0x100000
        BINDINFO_OPTIONS_BINDTOOBJECT = 1048576,

        /// BINDINFO_OPTIONS_SECURITYOPTOUT -> 0x200000
        BINDINFO_OPTIONS_SECURITYOPTOUT = 2097152,

        /// BINDINFO_OPTIONS_IGNOREMIMETEXTPLAIN -> 0x400000
        BINDINFO_OPTIONS_IGNOREMIMETEXTPLAIN = 4194304,

        /// BINDINFO_OPTIONS_USEBINDSTRINGCREDS -> 0x800000
        BINDINFO_OPTIONS_USEBINDSTRINGCREDS = 8388608,

        /// BINDINFO_OPTIONS_IGNOREHTTPHTTPSREDIRECTS -> 0x1000000
        BINDINFO_OPTIONS_IGNOREHTTPHTTPSREDIRECTS = 16777216,

        /// BINDINFO_OPTIONS_SHDOCVW_NAVIGATE -> 0x80000000
        BINDINFO_OPTIONS_SHDOCVW_NAVIGATE = -2147483648,
    }

    public enum BINDINFOF
    {

        /// BINDINFOF_URLENCODESTGMEDDATA -> 0x1
        BINDINFOF_URLENCODESTGMEDDATA = 1,

        /// BINDINFOF_URLENCODEDEXTRAINFO -> 0x2
        BINDINFOF_URLENCODEDEXTRAINFO = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BINDINFO
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szExtraInfo;

        /// STGMEDIUM->uSTGMEDIUM->tagSTGMEDIUM
        public tagSTGMEDIUM stgmedData;

        /// DWORD->unsigned int
        public uint grfBindInfoF;

        /// DWORD->unsigned int
        public uint dwBindVerb;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szCustomVerb;

        /// DWORD->unsigned int
        public uint cbstgmedData;

        /// DWORD->unsigned int
        public uint dwOptions;

        /// DWORD->unsigned int
        public uint dwOptionsFlags;

        /// DWORD->unsigned int
        public uint dwCodePage;

        /// SECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES
        public SECURITY_ATTRIBUTES securityAttributes;

        /// IID->GUID->_GUID
        public GUID iid;

        /// IUnknown*
        public IntPtr pUnk;

        /// DWORD->unsigned int
        public uint dwReserved;
    }

    public enum BINDF
    {

        /// BINDF_ASYNCHRONOUS -> 0x1
        BINDF_ASYNCHRONOUS = 1,

        /// BINDF_ASYNCSTORAGE -> 0x2
        BINDF_ASYNCSTORAGE = 2,

        /// BINDF_NOPROGRESSIVERENDERING -> 0x4
        BINDF_NOPROGRESSIVERENDERING = 4,

        /// BINDF_OFFLINEOPERATION -> 0x8
        BINDF_OFFLINEOPERATION = 8,

        /// BINDF_GETNEWESTVERSION -> 0x10
        BINDF_GETNEWESTVERSION = 16,

        /// BINDF_NOWRITECACHE -> 0x20
        BINDF_NOWRITECACHE = 32,

        /// BINDF_NEEDFILE -> 0x40
        BINDF_NEEDFILE = 64,

        /// BINDF_PULLDATA -> 0x80
        BINDF_PULLDATA = 128,

        /// BINDF_IGNORESECURITYPROBLEM -> 0x100
        BINDF_IGNORESECURITYPROBLEM = 256,

        /// BINDF_RESYNCHRONIZE -> 0x200
        BINDF_RESYNCHRONIZE = 512,

        /// BINDF_HYPERLINK -> 0x400
        BINDF_HYPERLINK = 1024,

        /// BINDF_NO_UI -> 0x800
        BINDF_NO_UI = 2048,

        /// BINDF_SILENTOPERATION -> 0x1000
        BINDF_SILENTOPERATION = 4096,

        /// BINDF_PRAGMA_NO_CACHE -> 0x2000
        BINDF_PRAGMA_NO_CACHE = 8192,

        /// BINDF_GETCLASSOBJECT -> 0x4000
        BINDF_GETCLASSOBJECT = 16384,

        /// BINDF_RESERVED_1 -> 0x8000
        BINDF_RESERVED_1 = 32768,

        /// BINDF_FREE_THREADED -> 0x10000
        BINDF_FREE_THREADED = 65536,

        /// BINDF_DIRECT_READ -> 0x20000
        BINDF_DIRECT_READ = 131072,

        /// BINDF_FORMS_SUBMIT -> 0x40000
        BINDF_FORMS_SUBMIT = 262144,

        /// BINDF_GETFROMCACHE_IF_NET_FAIL -> 0x80000
        BINDF_GETFROMCACHE_IF_NET_FAIL = 524288,

        /// BINDF_FROMURLMON -> 0x100000
        BINDF_FROMURLMON = 1048576,

        /// BINDF_FWD_BACK -> 0x200000
        BINDF_FWD_BACK = 2097152,

        /// BINDF_PREFERDEFAULTHANDLER -> 0x400000
        BINDF_PREFERDEFAULTHANDLER = 4194304,

        /// BINDF_ENFORCERESTRICTED -> 0x800000
        BINDF_ENFORCERESTRICTED = 8388608,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BINARY_CONTAINER
    {

        /// DWORD->unsigned int
        public uint cbBuf;

        /// LPBYTE->BYTE*
        public IntPtr pData;
    }

    public enum BIDI_TYPE
    {

        /// BIDI_NULL -> 0
        BIDI_NULL = 0,

        /// BIDI_INT -> 1
        BIDI_INT = 1,

        /// BIDI_FLOAT -> 2
        BIDI_FLOAT = 2,

        /// BIDI_BOOL -> 3
        BIDI_BOOL = 3,

        /// BIDI_STRING -> 4
        BIDI_STRING = 4,

        /// BIDI_TEXT -> 5
        BIDI_TEXT = 5,

        /// BIDI_ENUM -> 6
        BIDI_ENUM = 6,

        /// BIDI_BLOB -> 7
        BIDI_BLOB = 7,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIDI_RESPONSE_DATA
    {

        /// DWORD->unsigned int
        public uint dwResult;

        /// DWORD->unsigned int
        public uint dwReqNumber;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pSchema;

        /// BIDI_DATA->_BIDI_DATA
        public BIDI_DATA data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIDI_RESPONSE_CONTAINER
    {

        /// DWORD->unsigned int
        public uint Version;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint Count;

        /// BIDI_RESPONSE_DATA[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public BIDI_RESPONSE_DATA[] aData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIDI_REQUEST_DATA
    {

        /// DWORD->unsigned int
        public uint dwReqNumber;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pSchema;

        /// BIDI_DATA->_BIDI_DATA
        public BIDI_DATA data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIDI_REQUEST_CONTAINER
    {

        /// DWORD->unsigned int
        public uint Version;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint Count;

        /// BIDI_REQUEST_DATA[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public BIDI_REQUEST_DATA[] aData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BIDI_DATA
    {

        /// DWORD->unsigned int
        public uint dwBidiType;

        /// Anonymous_352ff64d_9a41_492e_a113_1156c54b2291
        public Anonymous_352ff64d_9a41_492e_a113_1156c54b2291 u;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BATTERY_REPORTING_SCALE
    {

        /// DWORD->unsigned int
        public uint Granularity;

        /// DWORD->unsigned int
        public uint Capacity;
    }

}
