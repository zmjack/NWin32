using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: int
    ///param0: LOGFONTW*
    ///param1: TEXTMETRICW*
    ///param2: DWORD->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int OLDFONTENUMPROCW(ref tagLOGFONTW param0, ref tagTEXTMETRICW param1, uint param2, IntPtr param3);

    /// Return Type: int
    ///param0: LOGFONTA*
    ///param1: TEXTMETRICA*
    ///param2: DWORD->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int OLDFONTENUMPROCA(ref tagLOGFONTA param0, ref tagTEXTMETRICA param1, uint param2, IntPtr param3);

    [StructLayout(LayoutKind.Sequential)]
    public struct OVERLAPPED
    {

        /// ULONG_PTR->unsigned int
        public uint Internal;

        /// ULONG_PTR->unsigned int
        public uint InternalHigh;

        /// Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196
        public Anonymous_7416d31a_1ce9_4e50_b1e1_0f2ad25c0196 Union1;

        /// HANDLE->void*
        public IntPtr hEvent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDebugStringData;

        /// WORD->unsigned short
        public ushort fUnicode;

        /// WORD->unsigned short
        public ushort nDebugStringLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OUTLINETEXTMETRICW
    {

        /// UINT->unsigned int
        public uint otmSize;

        /// TEXTMETRICW->tagTEXTMETRICW
        public tagTEXTMETRICW otmTextMetrics;

        /// BYTE->unsigned char
        public byte otmFiller;

        /// PANOSE->tagPANOSE
        public tagPANOSE otmPanoseNumber;

        /// UINT->unsigned int
        public uint otmfsSelection;

        /// UINT->unsigned int
        public uint otmfsType;

        /// int
        public int otmsCharSlopeRise;

        /// int
        public int otmsCharSlopeRun;

        /// int
        public int otmItalicAngle;

        /// UINT->unsigned int
        public uint otmEMSquare;

        /// int
        public int otmAscent;

        /// int
        public int otmDescent;

        /// UINT->unsigned int
        public uint otmLineGap;

        /// UINT->unsigned int
        public uint otmsCapEmHeight;

        /// UINT->unsigned int
        public uint otmsXHeight;

        /// RECT->tagRECT
        public tagRECT otmrcFontBox;

        /// int
        public int otmMacAscent;

        /// int
        public int otmMacDescent;

        /// UINT->unsigned int
        public uint otmMacLineGap;

        /// UINT->unsigned int
        public uint otmusMinimumPPEM;

        /// POINT->tagPOINT
        public Point otmptSubscriptSize;

        /// POINT->tagPOINT
        public Point otmptSubscriptOffset;

        /// POINT->tagPOINT
        public Point otmptSuperscriptSize;

        /// POINT->tagPOINT
        public Point otmptSuperscriptOffset;

        /// UINT->unsigned int
        public uint otmsStrikeoutSize;

        /// int
        public int otmsStrikeoutPosition;

        /// int
        public int otmsUnderscoreSize;

        /// int
        public int otmsUnderscorePosition;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFamilyName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFaceName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpStyleName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFullName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OUTLINETEXTMETRICA
    {

        /// UINT->unsigned int
        public uint otmSize;

        /// TEXTMETRICA->tagTEXTMETRICA
        public tagTEXTMETRICA otmTextMetrics;

        /// BYTE->unsigned char
        public byte otmFiller;

        /// PANOSE->tagPANOSE
        public tagPANOSE otmPanoseNumber;

        /// UINT->unsigned int
        public uint otmfsSelection;

        /// UINT->unsigned int
        public uint otmfsType;

        /// int
        public int otmsCharSlopeRise;

        /// int
        public int otmsCharSlopeRun;

        /// int
        public int otmItalicAngle;

        /// UINT->unsigned int
        public uint otmEMSquare;

        /// int
        public int otmAscent;

        /// int
        public int otmDescent;

        /// UINT->unsigned int
        public uint otmLineGap;

        /// UINT->unsigned int
        public uint otmsCapEmHeight;

        /// UINT->unsigned int
        public uint otmsXHeight;

        /// RECT->tagRECT
        public tagRECT otmrcFontBox;

        /// int
        public int otmMacAscent;

        /// int
        public int otmMacDescent;

        /// UINT->unsigned int
        public uint otmMacLineGap;

        /// UINT->unsigned int
        public uint otmusMinimumPPEM;

        /// POINT->tagPOINT
        public Point otmptSubscriptSize;

        /// POINT->tagPOINT
        public Point otmptSubscriptOffset;

        /// POINT->tagPOINT
        public Point otmptSuperscriptSize;

        /// POINT->tagPOINT
        public Point otmptSuperscriptOffset;

        /// UINT->unsigned int
        public uint otmsStrikeoutSize;

        /// int
        public int otmsStrikeoutPosition;

        /// int
        public int otmsUnderscoreSize;

        /// int
        public int otmsUnderscorePosition;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFamilyName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFaceName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpStyleName;

        /// PSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string otmpFullName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OSVERSIONINFOEXA
    {

        /// DWORD->unsigned int
        public uint dwOSVersionInfoSize;

        /// DWORD->unsigned int
        public uint dwMajorVersion;

        /// DWORD->unsigned int
        public uint dwMinorVersion;

        /// DWORD->unsigned int
        public uint dwBuildNumber;

        /// DWORD->unsigned int
        public uint dwPlatformId;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;

        /// WORD->unsigned short
        public ushort wServicePackMajor;

        /// WORD->unsigned short
        public ushort wServicePackMinor;

        /// WORD->unsigned short
        public ushort wSuiteMask;

        /// BYTE->unsigned char
        public byte wProductType;

        /// BYTE->unsigned char
        public byte wReserved;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OSVERSIONINFOA
    {

        /// DWORD->unsigned int
        public uint dwOSVersionInfoSize;

        /// DWORD->unsigned int
        public uint dwMajorVersion;

        /// DWORD->unsigned int
        public uint dwMinorVersion;

        /// DWORD->unsigned int
        public uint dwBuildNumber;

        /// DWORD->unsigned int
        public uint dwPlatformId;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OPENCARD_SEARCH_CRITERIAW
    {

        /// DWORD->unsigned int
        public uint dwStructSize;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrGroupNames;

        /// DWORD->unsigned int
        public uint nMaxGroupNames;

        /// LPCGUID->GUID*
        public IntPtr rgguidInterfaces;

        /// DWORD->unsigned int
        public uint cguidInterfaces;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrCardNames;

        /// DWORD->unsigned int
        public uint nMaxCardNames;

        /// LPOCNCHKPROC
        public LPOCNCHKPROC lpfnCheck;

        /// LPOCNCONNPROCW
        public LPOCNCONNPROCW lpfnConnect;

        /// LPOCNDSCPROC
        public LPOCNDSCPROC lpfnDisconnect;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwShareMode;

        /// DWORD->unsigned int
        public uint dwPreferredProtocols;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OPENCARD_SEARCH_CRITERIAA
    {

        /// DWORD->unsigned int
        public uint dwStructSize;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrGroupNames;

        /// DWORD->unsigned int
        public uint nMaxGroupNames;

        /// LPCGUID->GUID*
        public IntPtr rgguidInterfaces;

        /// DWORD->unsigned int
        public uint cguidInterfaces;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrCardNames;

        /// DWORD->unsigned int
        public uint nMaxCardNames;

        /// LPOCNCHKPROC
        public LPOCNCHKPROC lpfnCheck;

        /// LPOCNCONNPROCA
        public LPOCNCONNPROCA lpfnConnect;

        /// LPOCNDSCPROC
        public LPOCNDSCPROC lpfnDisconnect;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwShareMode;

        /// DWORD->unsigned int
        public uint dwPreferredProtocols;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OPENCARDNAME_EXW
    {

        /// DWORD->unsigned int
        public uint dwStructSize;

        /// SCARDCONTEXT->ULONG_PTR->unsigned int
        public uint hSCardContext;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrTitle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrSearchDesc;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// POPENCARD_SEARCH_CRITERIAW->Anonymous_c3c6c150_61e6_4cf2_b10c_cb5e26026131*
        public IntPtr pOpenCardSearchCriteria;

        /// LPOCNCONNPROCW
        public LPOCNCONNPROCW lpfnConnect;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwShareMode;

        /// DWORD->unsigned int
        public uint dwPreferredProtocols;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrRdr;

        /// DWORD->unsigned int
        public uint nMaxRdr;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrCard;

        /// DWORD->unsigned int
        public uint nMaxCard;

        /// DWORD->unsigned int
        public uint dwActiveProtocol;

        /// SCARDHANDLE->ULONG_PTR->unsigned int
        public uint hCardHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OPENCARDNAME_EXA
    {

        /// DWORD->unsigned int
        public uint dwStructSize;

        /// SCARDCONTEXT->ULONG_PTR->unsigned int
        public uint hSCardContext;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrTitle;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrSearchDesc;

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// POPENCARD_SEARCH_CRITERIAA->Anonymous_632d20f4_e40f_4e8f_8ec4_508231b6d045*
        public IntPtr pOpenCardSearchCriteria;

        /// LPOCNCONNPROCA
        public LPOCNCONNPROCA lpfnConnect;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwShareMode;

        /// DWORD->unsigned int
        public uint dwPreferredProtocols;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrRdr;

        /// DWORD->unsigned int
        public uint nMaxRdr;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrCard;

        /// DWORD->unsigned int
        public uint nMaxCard;

        /// DWORD->unsigned int
        public uint dwActiveProtocol;

        /// SCARDHANDLE->ULONG_PTR->unsigned int
        public uint hCardHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OPENCARDNAMEW
    {

        /// DWORD->unsigned int
        public uint dwStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// SCARDCONTEXT->ULONG_PTR->unsigned int
        public uint hSCardContext;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrGroupNames;

        /// DWORD->unsigned int
        public uint nMaxGroupNames;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrCardNames;

        /// DWORD->unsigned int
        public uint nMaxCardNames;

        /// LPCGUID->GUID*
        public IntPtr rgguidInterfaces;

        /// DWORD->unsigned int
        public uint cguidInterfaces;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrRdr;

        /// DWORD->unsigned int
        public uint nMaxRdr;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrCard;

        /// DWORD->unsigned int
        public uint nMaxCard;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrTitle;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwShareMode;

        /// DWORD->unsigned int
        public uint dwPreferredProtocols;

        /// DWORD->unsigned int
        public uint dwActiveProtocol;

        /// LPOCNCONNPROCW
        public LPOCNCONNPROCW lpfnConnect;

        /// LPOCNCHKPROC
        public LPOCNCHKPROC lpfnCheck;

        /// LPOCNDSCPROC
        public LPOCNDSCPROC lpfnDisconnect;

        /// SCARDHANDLE->ULONG_PTR->unsigned int
        public uint hCardHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OPENCARDNAMEA
    {

        /// DWORD->unsigned int
        public uint dwStructSize;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// SCARDCONTEXT->ULONG_PTR->unsigned int
        public uint hSCardContext;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrGroupNames;

        /// DWORD->unsigned int
        public uint nMaxGroupNames;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrCardNames;

        /// DWORD->unsigned int
        public uint nMaxCardNames;

        /// LPCGUID->GUID*
        public IntPtr rgguidInterfaces;

        /// DWORD->unsigned int
        public uint cguidInterfaces;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrRdr;

        /// DWORD->unsigned int
        public uint nMaxRdr;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrCard;

        /// DWORD->unsigned int
        public uint nMaxCard;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpstrTitle;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwShareMode;

        /// DWORD->unsigned int
        public uint dwPreferredProtocols;

        /// DWORD->unsigned int
        public uint dwActiveProtocol;

        /// LPOCNCONNPROCA
        public LPOCNCONNPROCA lpfnConnect;

        /// LPOCNCHKPROC
        public LPOCNCHKPROC lpfnCheck;

        /// LPOCNDSCPROC
        public LPOCNDSCPROC lpfnDisconnect;

        /// SCARDHANDLE->ULONG_PTR->unsigned int
        public uint hCardHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OLESTREAMVTBL
    {

        /// _OLESTREAMVTBL_Get
        public _OLESTREAMVTBL_Get AnonymousMember1;

        /// _OLESTREAMVTBL_Put
        public _OLESTREAMVTBL_Put AnonymousMember2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OLESTREAM
    {

        /// LPOLESTREAMVTBL->OLESTREAMVTBL*
        public IntPtr lpstbl;
    }

    public enum OIBDG_FLAGS
    {

        /// OIBDG_APARTMENTTHREADED -> 0x100
        OIBDG_APARTMENTTHREADED = 256,

        /// OIBDG_DATAONLY -> 0x1000
        OIBDG_DATAONLY = 4096,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OFSTRUCT
    {

        /// BYTE->unsigned char
        public byte cBytes;

        /// BYTE->unsigned char
        public byte fFixedDisk;

        /// WORD->unsigned short
        public ushort nErrCode;

        /// WORD->unsigned short
        public ushort Reserved1;

        /// WORD->unsigned short
        public ushort Reserved2;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szPathName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OFNOTIFYW
    {

        /// NMHDR->tagNMHDR
        public tagNMHDR hdr;

        /// LPOPENFILENAMEW->tagOFNW*
        public IntPtr lpOFN;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszFile;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OFNOTIFYEXW
    {

        /// NMHDR->tagNMHDR
        public tagNMHDR hdr;

        /// LPOPENFILENAMEW->tagOFNW*
        public IntPtr lpOFN;

        /// LPVOID->void*
        public IntPtr psf;

        /// LPVOID->void*
        public IntPtr pidl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OFNOTIFYEXA
    {

        /// NMHDR->tagNMHDR
        public tagNMHDR hdr;

        /// LPOPENFILENAMEA->tagOFNA*
        public IntPtr lpOFN;

        /// LPVOID->void*
        public IntPtr psf;

        /// LPVOID->void*
        public IntPtr pidl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OFNOTIFYA
    {

        /// NMHDR->tagNMHDR
        public tagNMHDR hdr;

        /// LPOPENFILENAMEA->tagOFNA*
        public IntPtr lpOFN;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszFile;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OBJECT_TYPE_LIST
    {

        /// WORD->unsigned short
        public ushort Level;

        /// WORD->unsigned short
        public ushort Sbz;

        /// GUID*
        public IntPtr ObjectType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OBJECTID
    {

        /// GUID->_GUID
        public GUID Lineage;

        /// DWORD->unsigned int
        public uint Uniquifier;
    }

}
