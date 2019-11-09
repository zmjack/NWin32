using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    public enum VARENUM
    {

        /// VT_EMPTY -> 0
        VT_EMPTY = 0,

        /// VT_NULL -> 1
        VT_NULL = 1,

        /// VT_I2 -> 2
        VT_I2 = 2,

        /// VT_I4 -> 3
        VT_I4 = 3,

        /// VT_R4 -> 4
        VT_R4 = 4,

        /// VT_R8 -> 5
        VT_R8 = 5,

        /// VT_CY -> 6
        VT_CY = 6,

        /// VT_DATE -> 7
        VT_DATE = 7,

        /// VT_BSTR -> 8
        VT_BSTR = 8,

        /// VT_DISPATCH -> 9
        VT_DISPATCH = 9,

        /// VT_ERROR -> 10
        VT_ERROR = 10,

        /// VT_BOOL -> 11
        VT_BOOL = 11,

        /// VT_VARIANT -> 12
        VT_VARIANT = 12,

        /// VT_UNKNOWN -> 13
        VT_UNKNOWN = 13,

        /// VT_DECIMAL -> 14
        VT_DECIMAL = 14,

        /// VT_I1 -> 16
        VT_I1 = 16,

        /// VT_UI1 -> 17
        VT_UI1 = 17,

        /// VT_UI2 -> 18
        VT_UI2 = 18,

        /// VT_UI4 -> 19
        VT_UI4 = 19,

        /// VT_I8 -> 20
        VT_I8 = 20,

        /// VT_UI8 -> 21
        VT_UI8 = 21,

        /// VT_INT -> 22
        VT_INT = 22,

        /// VT_UINT -> 23
        VT_UINT = 23,

        /// VT_VOID -> 24
        VT_VOID = 24,

        /// VT_HRESULT -> 25
        VT_HRESULT = 25,

        /// VT_PTR -> 26
        VT_PTR = 26,

        /// VT_SAFEARRAY -> 27
        VT_SAFEARRAY = 27,

        /// VT_CARRAY -> 28
        VT_CARRAY = 28,

        /// VT_USERDEFINED -> 29
        VT_USERDEFINED = 29,

        /// VT_LPSTR -> 30
        VT_LPSTR = 30,

        /// VT_LPWSTR -> 31
        VT_LPWSTR = 31,

        /// VT_RECORD -> 36
        VT_RECORD = 36,

        /// VT_INT_PTR -> 37
        VT_INT_PTR = 37,

        /// VT_UINT_PTR -> 38
        VT_UINT_PTR = 38,

        /// VT_FILETIME -> 64
        VT_FILETIME = 64,

        /// VT_BLOB -> 65
        VT_BLOB = 65,

        /// VT_STREAM -> 66
        VT_STREAM = 66,

        /// VT_STORAGE -> 67
        VT_STORAGE = 67,

        /// VT_STREAMED_OBJECT -> 68
        VT_STREAMED_OBJECT = 68,

        /// VT_STORED_OBJECT -> 69
        VT_STORED_OBJECT = 69,

        /// VT_BLOB_OBJECT -> 70
        VT_BLOB_OBJECT = 70,

        /// VT_CF -> 71
        VT_CF = 71,

        /// VT_CLSID -> 72
        VT_CLSID = 72,

        /// VT_VERSIONED_STREAM -> 73
        VT_VERSIONED_STREAM = 73,

        /// VT_BSTR_BLOB -> 0xfff
        VT_BSTR_BLOB = 4095,

        /// VT_VECTOR -> 0x1000
        VT_VECTOR = 4096,

        /// VT_ARRAY -> 0x2000
        VT_ARRAY = 8192,

        /// VT_BYREF -> 0x4000
        VT_BYREF = 16384,

        /// VT_RESERVED -> 0x8000
        VT_RESERVED = 32768,

        /// VT_ILLEGAL -> 0xffff
        VT_ILLEGAL = 65535,

        /// VT_ILLEGALMASKED -> 0xfff
        VT_ILLEGALMASKED = 4095,

        /// VT_TYPEMASK -> 0xfff
        VT_TYPEMASK = 4095,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct val_context
    {

        /// int
        public int valuelen;

        /// LPVOID->void*
        public IntPtr value_context;

        /// LPVOID->void*
        public IntPtr val_buff_ptr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct value_entW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ve_valuename;

        /// DWORD->unsigned int
        public uint ve_valuelen;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint ve_valueptr;

        /// DWORD->unsigned int
        public uint ve_type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct value_entA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string ve_valuename;

        /// DWORD->unsigned int
        public uint ve_valuelen;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint ve_valueptr;

        /// DWORD->unsigned int
        public uint ve_type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VOLUME_DISK_EXTENTS
    {

        /// DWORD->unsigned int
        public uint NumberOfDiskExtents;

        /// DISK_EXTENT[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public DISK_EXTENT[] Extents;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VOLUME_BITMAP_BUFFER
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingLcn;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER BitmapSize;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Buffer;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct VIDEOPARAMETERS
    {

        /// GUID->_GUID
        public GUID Guid;

        /// ULONG->unsigned int
        public uint dwOffset;

        /// ULONG->unsigned int
        public uint dwCommand;

        /// ULONG->unsigned int
        public uint dwFlags;

        /// ULONG->unsigned int
        public uint dwMode;

        /// ULONG->unsigned int
        public uint dwTVStandard;

        /// ULONG->unsigned int
        public uint dwAvailableModes;

        /// ULONG->unsigned int
        public uint dwAvailableTVStandard;

        /// ULONG->unsigned int
        public uint dwFlickerFilter;

        /// ULONG->unsigned int
        public uint dwOverScanX;

        /// ULONG->unsigned int
        public uint dwOverScanY;

        /// ULONG->unsigned int
        public uint dwMaxUnscaledX;

        /// ULONG->unsigned int
        public uint dwMaxUnscaledY;

        /// ULONG->unsigned int
        public uint dwPositionX;

        /// ULONG->unsigned int
        public uint dwPositionY;

        /// ULONG->unsigned int
        public uint dwBrightness;

        /// ULONG->unsigned int
        public uint dwContrast;

        /// ULONG->unsigned int
        public uint dwCPType;

        /// ULONG->unsigned int
        public uint dwCPCommand;

        /// ULONG->unsigned int
        public uint dwCPStandard;

        /// ULONG->unsigned int
        public uint dwCPKey;

        /// ULONG->unsigned int
        public uint bCP_APSTriggerBits;

        /// UCHAR[256]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string bOEMCopyProtection;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VERIFY_INFORMATION
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingOffset;

        /// DWORD->unsigned int
        public uint Length;
    }

}
