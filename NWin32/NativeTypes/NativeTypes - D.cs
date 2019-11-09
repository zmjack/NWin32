using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DRVCONFIGINFOEX
    {

        /// DWORD->unsigned int
        public uint dwDCISize;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszDCISectionName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszDCIAliasName;

        /// DWORD->unsigned int
        public uint dnDevNode;
    }

    /// Return Type: void
    ///hdrvr: HDRVR->HDRVR__*
    ///uMsg: UINT->unsigned int
    ///dwUser: DWORD_PTR->ULONG_PTR->unsigned int
    ///dw1: DWORD_PTR->ULONG_PTR->unsigned int
    ///dw2: DWORD_PTR->ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void DRVCALLBACK(IntPtr hdrvr, uint uMsg, uint dwUser, uint dw1, uint dw2);

    /// Return Type: LRESULT->LONG_PTR->int
    ///param0: DWORD_PTR->ULONG_PTR->unsigned int
    ///param1: HDRVR->HDRVR__*
    ///param2: UINT->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    ///param4: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DRIVERPROC(uint param0, IntPtr param1, uint param2, IntPtr param3, IntPtr param4);

    /// Return Type: BOOL->int
    ///hdc: HDC->HDC__*
    ///lData: LPARAM->LONG_PTR->int
    ///wData: WPARAM->UINT_PTR->unsigned int
    ///cx: int
    ///cy: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DRAWSTATEPROC(IntPtr hdc, IntPtr lData, IntPtr wData, int cx, int cy);

    /// Return Type: INT_PTR->int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DLGPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCEXW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCEXA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int DATEFMT_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct DWORD_SIZEDARR
    {

        /// unsigned int
        public uint clSize;

        /// unsigned int*
        public IntPtr pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DWORD_BLOB
    {

        /// unsigned int
        public uint clSize;

        /// unsigned int[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] alData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DSSSEED
    {

        /// DWORD->unsigned int
        public uint counter;

        /// BYTE[20]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
        public byte[] seed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DSSPUBKEY_VER3
    {

        /// DWORD->unsigned int
        public uint magic;

        /// DWORD->unsigned int
        public uint bitlenP;

        /// DWORD->unsigned int
        public uint bitlenQ;

        /// DWORD->unsigned int
        public uint bitlenJ;

        /// DSSSEED->_DSSSEED
        public DSSSEED DSSSeed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DSSPRIVKEY_VER3
    {

        /// DWORD->unsigned int
        public uint magic;

        /// DWORD->unsigned int
        public uint bitlenP;

        /// DWORD->unsigned int
        public uint bitlenQ;

        /// DWORD->unsigned int
        public uint bitlenJ;

        /// DWORD->unsigned int
        public uint bitlenX;

        /// DSSSEED->_DSSSEED
        public DSSSEED DSSSeed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVE_LAYOUT_INFORMATION_MBR
    {

        /// DWORD->unsigned int
        public uint Signature;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVE_LAYOUT_INFORMATION_GPT
    {

        /// GUID->_GUID
        public GUID DiskId;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingUsableOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER UsableLength;

        /// DWORD->unsigned int
        public uint MaxPartitionCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVE_LAYOUT_INFORMATION_EX
    {

        /// DWORD->unsigned int
        public uint PartitionStyle;

        /// DWORD->unsigned int
        public uint PartitionCount;

        /// Anonymous_cfb60db2_96f4_4519_9332_49eedd92748c
        public Anonymous_cfb60db2_96f4_4519_9332_49eedd92748c Union1;

        /// PARTITION_INFORMATION_EX[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public PARTITION_INFORMATION_EX[] PartitionEntry;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVE_LAYOUT_INFORMATION
    {

        /// DWORD->unsigned int
        public uint PartitionCount;

        /// DWORD->unsigned int
        public uint Signature;

        /// PARTITION_INFORMATION[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public PARTITION_INFORMATION[] PartitionEntry;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_6W
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pEnvironment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDriverPath;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDataFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pConfigFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pHelpFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDependentFiles;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pMonitorName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDefaultDataType;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszzPreviousNames;

        /// FILETIME->_FILETIME
        public FILETIME ftDriverDate;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong dwlDriverVersion;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszMfgName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszOEMUrl;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszHardwareID;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszProvider;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_6A
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pEnvironment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDriverPath;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pConfigFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pHelpFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDependentFiles;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pMonitorName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDefaultDataType;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszzPreviousNames;

        /// FILETIME->_FILETIME
        public FILETIME ftDriverDate;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong dwlDriverVersion;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszMfgName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszOEMUrl;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszHardwareID;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszProvider;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_5W
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pEnvironment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDriverPath;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDataFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pConfigFile;

        /// DWORD->unsigned int
        public uint dwDriverAttributes;

        /// DWORD->unsigned int
        public uint dwConfigVersion;

        /// DWORD->unsigned int
        public uint dwDriverVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_5A
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pEnvironment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDriverPath;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pConfigFile;

        /// DWORD->unsigned int
        public uint dwDriverAttributes;

        /// DWORD->unsigned int
        public uint dwConfigVersion;

        /// DWORD->unsigned int
        public uint dwDriverVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_4W
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pEnvironment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDriverPath;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDataFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pConfigFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pHelpFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDependentFiles;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pMonitorName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDefaultDataType;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszzPreviousNames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_4A
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pEnvironment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDriverPath;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pConfigFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pHelpFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDependentFiles;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pMonitorName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDefaultDataType;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszzPreviousNames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_3W
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pEnvironment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDriverPath;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDataFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pConfigFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pHelpFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDependentFiles;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pMonitorName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDefaultDataType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_3A
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pEnvironment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDriverPath;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pConfigFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pHelpFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDependentFiles;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pMonitorName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDefaultDataType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_2W
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pEnvironment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDriverPath;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDataFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pConfigFile;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_2A
    {

        /// DWORD->unsigned int
        public uint cVersion;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pEnvironment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDriverPath;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pConfigFile;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVER_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRIVERSTATUS
    {

        /// BYTE->unsigned char
        public byte bDriverError;

        /// BYTE->unsigned char
        public byte bIDEError;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] bReserved;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRAWPATRECT
    {

        /// POINT->tagPOINT
        public Point ptPosition;

        /// POINT->tagPOINT
        public Point ptSize;

        /// WORD->unsigned short
        public ushort wStyle;

        /// WORD->unsigned short
        public ushort wPattern;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRAGINFOW
    {

        /// UINT->unsigned int
        public uint uSize;

        /// POINT->tagPOINT
        public Point pt;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fNC;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpFileList;

        /// DWORD->unsigned int
        public uint grfKeyState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DRAGINFOA
    {

        /// UINT->unsigned int
        public uint uSize;

        /// POINT->tagPOINT
        public Point pt;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fNC;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpFileList;

        /// DWORD->unsigned int
        public uint grfKeyState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOC_INFO_3W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDocName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pOutputFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDatatype;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOC_INFO_3A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDatatype;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOC_INFO_2W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDocName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pOutputFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDatatype;

        /// DWORD->unsigned int
        public uint dwMode;

        /// DWORD->unsigned int
        public uint JobId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOC_INFO_2A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDatatype;

        /// DWORD->unsigned int
        public uint dwMode;

        /// DWORD->unsigned int
        public uint JobId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOC_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDocName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pOutputFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDatatype;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOC_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDatatype;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOCINFOW
    {

        /// int
        public int cbSize;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszDocName;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszOutput;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszDatatype;

        /// DWORD->unsigned int
        public uint fwType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DOCINFOA
    {

        /// int
        public int cbSize;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszDocName;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszOutput;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszDatatype;

        /// DWORD->unsigned int
        public uint fwType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DLGTEMPLATE
    {

        /// DWORD->unsigned int
        public uint style;

        /// DWORD->unsigned int
        public uint dwExtendedStyle;

        /// WORD->unsigned short
        public ushort cdit;

        /// short
        public short x;

        /// short
        public short y;

        /// short
        public short cx;

        /// short
        public short cy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DLGITEMTEMPLATE
    {

        /// DWORD->unsigned int
        public uint style;

        /// DWORD->unsigned int
        public uint dwExtendedStyle;

        /// short
        public short x;

        /// short
        public short y;

        /// short
        public short cx;

        /// short
        public short cy;

        /// WORD->unsigned short
        public ushort id;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct div_t
    {

        /// int
        public int quot;

        /// int
        public int rem;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DISPLAY_DEVICEW
    {

        /// DWORD->unsigned int
        public uint cb;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        /// WCHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;

        /// DWORD->unsigned int
        public uint StateFlags;

        /// WCHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;

        /// WCHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DISPLAY_DEVICEA
    {

        /// DWORD->unsigned int
        public uint cb;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;

        /// DWORD->unsigned int
        public uint StateFlags;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_RECORD
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER ByteOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER EndTime;

        /// PVOID->void*
        public IntPtr VirtualAddress;

        /// DWORD->unsigned int
        public uint NumberOfBytes;

        /// BYTE->unsigned char
        public byte DeviceNumber;

        /// BOOLEAN->BYTE->unsigned char
        public byte ReadRequest;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DISK_PERFORMANCE
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER BytesRead;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER BytesWritten;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER ReadTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER WriteTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER IdleTime;

        /// DWORD->unsigned int
        public uint ReadCount;

        /// DWORD->unsigned int
        public uint WriteCount;

        /// DWORD->unsigned int
        public uint QueueDepth;

        /// DWORD->unsigned int
        public uint SplitCount;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER QueryTime;

        /// DWORD->unsigned int
        public uint StorageDeviceNumber;

        /// WCHAR[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string StorageManagerName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_PARTITION_INFO
    {

        /// DWORD->unsigned int
        public uint SizeOfPartitionInfo;

        /// PARTITION_STYLE->_PARTITION_STYLE
        public PARTITION_STYLE PartitionStyle;

        /// Anonymous_63310a95_9b9e_4688_be91_41d3e7b47594
        public Anonymous_63310a95_9b9e_4688_be91_41d3e7b47594 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_LOGGING
    {

        /// BYTE->unsigned char
        public byte Function;

        /// PVOID->void*
        public IntPtr BufferAddress;

        /// DWORD->unsigned int
        public uint BufferSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_INT13_INFO
    {

        /// WORD->unsigned short
        public ushort DriveSelect;

        /// DWORD->unsigned int
        public uint MaxCylinders;

        /// WORD->unsigned short
        public ushort SectorsPerTrack;

        /// WORD->unsigned short
        public ushort MaxHeads;

        /// WORD->unsigned short
        public ushort NumberDrives;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_HISTOGRAM
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER DiskSize;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Start;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER End;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Average;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER AverageRead;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER AverageWrite;

        /// DWORD->unsigned int
        public uint Granularity;

        /// DWORD->unsigned int
        public uint Size;

        /// DWORD->unsigned int
        public uint ReadCount;

        /// DWORD->unsigned int
        public uint WriteCount;

        /// PHISTOGRAM_BUCKET->_HISTOGRAM_BUCKET*
        public IntPtr Histogram;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_GROW_PARTITION
    {

        /// DWORD->unsigned int
        public uint PartitionNumber;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER BytesToGrow;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_GEOMETRY_EX
    {

        /// DISK_GEOMETRY->_DISK_GEOMETRY
        public DISK_GEOMETRY Geometry;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER DiskSize;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_GEOMETRY
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Cylinders;

        /// MEDIA_TYPE->_MEDIA_TYPE
        public MEDIA_TYPE MediaType;

        /// DWORD->unsigned int
        public uint TracksPerCylinder;

        /// DWORD->unsigned int
        public uint SectorsPerTrack;

        /// DWORD->unsigned int
        public uint BytesPerSector;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_EX_INT13_INFO
    {

        /// WORD->unsigned short
        public ushort ExBufferSize;

        /// WORD->unsigned short
        public ushort ExFlags;

        /// DWORD->unsigned int
        public uint ExCylinders;

        /// DWORD->unsigned int
        public uint ExHeads;

        /// DWORD->unsigned int
        public uint ExSectorsPerTrack;

        /// DWORD64->unsigned __int64
        public ulong ExSectorsPerDrive;

        /// WORD->unsigned short
        public ushort ExSectorSize;

        /// WORD->unsigned short
        public ushort ExReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_EXTENT
    {

        /// DWORD->unsigned int
        public uint DiskNumber;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER ExtentLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_DETECTION_INFO
    {

        /// DWORD->unsigned int
        public uint SizeOfDetectInfo;

        /// DETECTION_TYPE->_DETECTION_TYPE
        public DETECTION_TYPE DetectionType;

        /// Anonymous_de8bc636_9617_4311_97bc_1b3c77b1408f
        public Anonymous_de8bc636_9617_4311_97bc_1b3c77b1408f Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_CONTROLLER_NUMBER
    {

        /// DWORD->unsigned int
        public uint ControllerNumber;

        /// DWORD->unsigned int
        public uint DiskNumber;
    }

    public enum DISK_CACHE_RETENTION_PRIORITY
    {

        EqualPriority,

        KeepPrefetchedData,

        KeepReadData,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_CACHE_INFORMATION
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte ParametersSavable;

        /// BOOLEAN->BYTE->unsigned char
        public byte ReadCacheEnabled;

        /// BOOLEAN->BYTE->unsigned char
        public byte WriteCacheEnabled;

        /// DISK_CACHE_RETENTION_PRIORITY->Anonymous_dccd88a3_310b_4bd8_96bf_84946a879680
        public DISK_CACHE_RETENTION_PRIORITY ReadRetentionPriority;

        /// DISK_CACHE_RETENTION_PRIORITY->Anonymous_dccd88a3_310b_4bd8_96bf_84946a879680
        public DISK_CACHE_RETENTION_PRIORITY WriteRetentionPriority;

        /// WORD->unsigned short
        public ushort DisablePrefetchTransferLength;

        /// BOOLEAN->BYTE->unsigned char
        public byte PrefetchScalar;

        /// Anonymous_034857e8_2cb2_40e6_8427_2aed5a66c84e
        public Anonymous_034857e8_2cb2_40e6_8427_2aed5a66c84e Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISCDLGSTRUCTW
    {

        /// DWORD->unsigned int
        public uint cbStructure;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpLocalName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpRemoteName;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DISCDLGSTRUCTA
    {

        /// DWORD->unsigned int
        public uint cbStructure;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpLocalName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpRemoteName;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DEVMODEW
    {

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        /// WORD->unsigned short
        public ushort dmSpecVersion;

        /// WORD->unsigned short
        public ushort dmDriverVersion;

        /// WORD->unsigned short
        public ushort dmSize;

        /// WORD->unsigned short
        public ushort dmDriverExtra;

        /// DWORD->unsigned int
        public uint dmFields;

        /// Anonymous_7a7460d9_d99f_4e9a_9ebb_cdd10c08463d
        public Anonymous_7a7460d9_d99f_4e9a_9ebb_cdd10c08463d Union1;

        /// short
        public short dmColor;

        /// short
        public short dmDuplex;

        /// short
        public short dmYResolution;

        /// short
        public short dmTTOption;

        /// short
        public short dmCollate;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;

        /// WORD->unsigned short
        public ushort dmLogPixels;

        /// DWORD->unsigned int
        public uint dmBitsPerPel;

        /// DWORD->unsigned int
        public uint dmPelsWidth;

        /// DWORD->unsigned int
        public uint dmPelsHeight;

        /// Anonymous_084dbe97_5806_4c28_a299_ed6037f61d90
        public Anonymous_084dbe97_5806_4c28_a299_ed6037f61d90 Union2;

        /// DWORD->unsigned int
        public uint dmDisplayFrequency;

        /// DWORD->unsigned int
        public uint dmICMMethod;

        /// DWORD->unsigned int
        public uint dmICMIntent;

        /// DWORD->unsigned int
        public uint dmMediaType;

        /// DWORD->unsigned int
        public uint dmDitherType;

        /// DWORD->unsigned int
        public uint dmReserved1;

        /// DWORD->unsigned int
        public uint dmReserved2;

        /// DWORD->unsigned int
        public uint dmPanningWidth;

        /// DWORD->unsigned int
        public uint dmPanningHeight;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEVMODEA
    {

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] dmDeviceName;

        /// WORD->unsigned short
        public ushort dmSpecVersion;

        /// WORD->unsigned short
        public ushort dmDriverVersion;

        /// WORD->unsigned short
        public ushort dmSize;

        /// WORD->unsigned short
        public ushort dmDriverExtra;

        /// DWORD->unsigned int
        public uint dmFields;

        /// Anonymous_2338c0fc_03a3_4514_b536_fb9bb5df14c5
        public Anonymous_2338c0fc_03a3_4514_b536_fb9bb5df14c5 Union1;

        /// short
        public short dmColor;

        /// short
        public short dmDuplex;

        /// short
        public short dmYResolution;

        /// short
        public short dmTTOption;

        /// short
        public short dmCollate;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] dmFormName;

        /// WORD->unsigned short
        public ushort dmLogPixels;

        /// DWORD->unsigned int
        public uint dmBitsPerPel;

        /// DWORD->unsigned int
        public uint dmPelsWidth;

        /// DWORD->unsigned int
        public uint dmPelsHeight;

        /// Anonymous_7557e508_845c_4777_b9f2_a1496c1c7b21
        public Anonymous_7557e508_845c_4777_b9f2_a1496c1c7b21 Union2;

        /// DWORD->unsigned int
        public uint dmDisplayFrequency;

        /// DWORD->unsigned int
        public uint dmICMMethod;

        /// DWORD->unsigned int
        public uint dmICMIntent;

        /// DWORD->unsigned int
        public uint dmMediaType;

        /// DWORD->unsigned int
        public uint dmDitherType;

        /// DWORD->unsigned int
        public uint dmReserved1;

        /// DWORD->unsigned int
        public uint dmReserved2;

        /// DWORD->unsigned int
        public uint dmPanningWidth;

        /// DWORD->unsigned int
        public uint dmPanningHeight;
    }

    public enum DEVICE_POWER_STATE
    {

        /// PowerDeviceUnspecified -> 0
        PowerDeviceUnspecified = 0,

        PowerDeviceD0,

        PowerDeviceD1,

        PowerDeviceD2,

        PowerDeviceD3,

        PowerDeviceMaximum,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEVICE_MEDIA_INFO
    {

        /// Anonymous_37959f42_bffb_4b55_963f_66ec2f0aca1a
        public Anonymous_37959f42_bffb_4b55_963f_66ec2f0aca1a DeviceSpecific;
    }

    public enum DETECTION_TYPE
    {

        DetectNone,

        DetectInt13,

        DetectExInt13,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DELETE_USN_JOURNAL_DATA
    {

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong UsnJournalID;

        /// DWORD->unsigned int
        public uint DeleteFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DECRYPTION_STATUS_BUFFER
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte NoEncryptedStreams;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEBUG_EVENT
    {

        /// DWORD->unsigned int
        public uint dwDebugEventCode;

        /// DWORD->unsigned int
        public uint dwProcessId;

        /// DWORD->unsigned int
        public uint dwThreadId;

        /// Anonymous_c0f5f2ce_b74f_423c_81ee_f2fb7ef45eb7
        public Anonymous_c0f5f2ce_b74f_423c_81ee_f2fb7ef45eb7 u;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDEUP
    {

        /// unused : 12
        ///fAck : 1
        ///fRelease : 1
        ///fReserved : 1
        ///fAckReq : 1
        public uint bitvector1;

        /// short
        public short cfFormat;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] rgb;

        public uint unused
        {
            get
            {
                return ((uint)((this.bitvector1 & 4095u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint fAck
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4096u)
                            / 4096)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4096)
                            | this.bitvector1)));
            }
        }

        public uint fRelease
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8192u)
                            / 8192)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8192)
                            | this.bitvector1)));
            }
        }

        public uint fReserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16384u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }

        public uint fAckReq
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32768u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDEPOKE
    {

        /// unused : 13
        ///fRelease : 1
        ///fReserved : 2
        public uint bitvector1;

        /// short
        public short cfFormat;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Value;

        public uint unused
        {
            get
            {
                return ((uint)((this.bitvector1 & 8191u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint fRelease
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8192u)
                            / 8192)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8192)
                            | this.bitvector1)));
            }
        }

        public uint fReserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 49152u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDELN
    {

        /// unused : 13
        ///fRelease : 1
        ///fDeferUpd : 1
        ///fAckReq : 1
        public uint bitvector1;

        /// short
        public short cfFormat;

        public uint unused
        {
            get
            {
                return ((uint)((this.bitvector1 & 8191u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint fRelease
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8192u)
                            / 8192)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8192)
                            | this.bitvector1)));
            }
        }

        public uint fDeferUpd
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16384u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }

        public uint fAckReq
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32768u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDEDATA
    {

        /// unused : 12
        ///fResponse : 1
        ///fRelease : 1
        ///reserved : 1
        ///fAckReq : 1
        public uint bitvector1;

        /// short
        public short cfFormat;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] Value;

        public uint unused
        {
            get
            {
                return ((uint)((this.bitvector1 & 4095u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint fResponse
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4096u)
                            / 4096)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4096)
                            | this.bitvector1)));
            }
        }

        public uint fRelease
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8192u)
                            / 8192)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8192)
                            | this.bitvector1)));
            }
        }

        public uint reserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16384u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }

        public uint fAckReq
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32768u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDEADVISE
    {

        /// reserved : 14
        ///fDeferUpd : 1
        ///fAckReq : 1
        public uint bitvector1;

        /// short
        public short cfFormat;

        public uint reserved
        {
            get
            {
                return ((uint)((this.bitvector1 & 16383u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint fDeferUpd
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16384u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }

        public uint fAckReq
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32768u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDEACK
    {

        /// bAppReturnCode : 8
        ///reserved : 6
        ///fBusy : 1
        ///fAck : 1
        public uint bitvector1;

        public uint bAppReturnCode
        {
            get
            {
                return ((uint)((this.bitvector1 & 255u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint reserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16128u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint fBusy
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16384u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }

        public uint fAck
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32768u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DCB
    {

        /// DWORD->unsigned int
        public uint DCBlength;

        /// DWORD->unsigned int
        public uint BaudRate;

        /// fBinary : 1
        ///fParity : 1
        ///fOutxCtsFlow : 1
        ///fOutxDsrFlow : 1
        ///fDtrControl : 2
        ///fDsrSensitivity : 1
        ///fTXContinueOnXoff : 1
        ///fOutX : 1
        ///fInX : 1
        ///fErrorChar : 1
        ///fNull : 1
        ///fRtsControl : 2
        ///fAbortOnError : 1
        ///fDummy2 : 17
        public uint bitvector1;

        /// WORD->unsigned short
        public ushort wReserved;

        /// WORD->unsigned short
        public ushort XonLim;

        /// WORD->unsigned short
        public ushort XoffLim;

        /// BYTE->unsigned char
        public byte ByteSize;

        /// BYTE->unsigned char
        public byte Parity;

        /// BYTE->unsigned char
        public byte StopBits;

        /// char
        public byte XonChar;

        /// char
        public byte XoffChar;

        /// char
        public byte ErrorChar;

        /// char
        public byte EofChar;

        /// char
        public byte EvtChar;

        /// WORD->unsigned short
        public ushort wReserved1;

        public uint fBinary
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint fParity
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }

        public uint fOutxCtsFlow
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4u)
                            / 4)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4)
                            | this.bitvector1)));
            }
        }

        public uint fOutxDsrFlow
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8u)
                            / 8)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8)
                            | this.bitvector1)));
            }
        }

        public uint fDtrControl
        {
            get
            {
                return ((uint)(((this.bitvector1 & 48u)
                            / 16)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16)
                            | this.bitvector1)));
            }
        }

        public uint fDsrSensitivity
        {
            get
            {
                return ((uint)(((this.bitvector1 & 64u)
                            / 64)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 64)
                            | this.bitvector1)));
            }
        }

        public uint fTXContinueOnXoff
        {
            get
            {
                return ((uint)(((this.bitvector1 & 128u)
                            / 128)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 128)
                            | this.bitvector1)));
            }
        }

        public uint fOutX
        {
            get
            {
                return ((uint)(((this.bitvector1 & 256u)
                            / 256)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 256)
                            | this.bitvector1)));
            }
        }

        public uint fInX
        {
            get
            {
                return ((uint)(((this.bitvector1 & 512u)
                            / 512)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 512)
                            | this.bitvector1)));
            }
        }

        public uint fErrorChar
        {
            get
            {
                return ((uint)(((this.bitvector1 & 1024u)
                            / 1024)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 1024)
                            | this.bitvector1)));
            }
        }

        public uint fNull
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2048u)
                            / 2048)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2048)
                            | this.bitvector1)));
            }
        }

        public uint fRtsControl
        {
            get
            {
                return ((uint)(((this.bitvector1 & 12288u)
                            / 4096)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4096)
                            | this.bitvector1)));
            }
        }

        public uint fAbortOnError
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16384u)
                            / 16384)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16384)
                            | this.bitvector1)));
            }
        }

        public uint fDummy2
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4294934528u)
                            / 32768)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32768)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DATATYPES_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DATATYPES_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DATAINFO
    {

        /// ULONG->unsigned int
        public uint ulTotalSize;

        /// ULONG->unsigned int
        public uint ulavrPacketSize;

        /// ULONG->unsigned int
        public uint ulConnectSpeed;

        /// ULONG->unsigned int
        public uint ulProcessorSpeed;
    }

}
