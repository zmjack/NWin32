using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSAData
    {

        /// WORD->unsigned short
        public ushort wVersion;

        /// WORD->unsigned short
        public ushort wHighVersion;

        /// char[257]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string szDescription;

        /// char[129]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string szSystemStatus;

        /// unsigned short
        public ushort iMaxSockets;

        /// unsigned short
        public ushort iMaxUdpDg;

        /// char*
        public IntPtr lpVendorInfo;
    }

    /// Return Type: void
    ///param0: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void WORKERCALLBACKFUNC(IntPtr param0);

    /// Return Type: LRESULT->LONG_PTR->int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int WNDPROC(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int WNDENUMPROC(IntPtr param0, IntPtr param1);

    /// Return Type: void
    ///hWinEventHook: HWINEVENTHOOK->HWINEVENTHOOK__*
    ///event: DWORD->unsigned int
    ///hwnd: HWND->HWND__*
    ///idObject: LONG->int
    ///idChild: LONG->int
    ///idEventThread: DWORD->unsigned int
    ///dwmsEventTime: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void WINEVENTPROC(IntPtr hWinEventHook, uint @event, IntPtr hwnd, int idObject, int idChild, uint idEventThread, uint dwmsEventTime);

    [StructLayout(LayoutKind.Sequential)]
    public struct wavehdr_tag
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;

        /// DWORD->unsigned int
        public uint dwBufferLength;

        /// DWORD->unsigned int
        public uint dwBytesRecorded;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwUser;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwLoops;

        /// wavehdr_tag*
        public IntPtr lpNext;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct waveformat_tag
    {

        /// WORD->unsigned short
        public ushort wFormatTag;

        /// WORD->unsigned short
        public ushort nChannels;

        /// DWORD->unsigned int
        public uint nSamplesPerSec;

        /// DWORD->unsigned int
        public uint nAvgBytesPerSec;

        /// WORD->unsigned short
        public ushort nBlockAlign;
    }

    /// Return Type: void
    ///param0: PVOID->void*
    ///param1: BOOLEAN->BYTE->unsigned char
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void WAITORTIMERCALLBACKFUNC(IntPtr param0, byte param1);

    [StructLayout(LayoutKind.Sequential)]
    public struct WORD_SIZEDARR
    {

        /// unsigned int
        public uint clSize;

        /// unsigned short*
        public IntPtr pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WORD_BLOB
    {

        /// unsigned int
        public uint clSize;

        /// unsigned short[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U2)]
        public ushort[] asData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOW_BUFFER_SIZE_RECORD
    {

        /// COORD->_COORD
        public COORD dwSize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WIN32_STREAM_ID
    {

        /// DWORD->unsigned int
        public uint dwStreamId;

        /// DWORD->unsigned int
        public uint dwStreamAttributes;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Size;

        /// DWORD->unsigned int
        public uint dwStreamNameSize;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string cStreamName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WIN32_FIND_STREAM_DATA
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StreamSize;

        /// WCHAR[296]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 296)]
        public string cStreamName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WIN32_FIND_DATAW
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
        public uint nFileSizeHigh;

        /// DWORD->unsigned int
        public uint nFileSizeLow;

        /// DWORD->unsigned int
        public uint dwReserved0;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string cFileName;

        /// WCHAR[14]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternateFileName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WIN32_FIND_DATAA
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
        public uint nFileSizeHigh;

        /// DWORD->unsigned int
        public uint nFileSizeLow;

        /// DWORD->unsigned int
        public uint dwReserved0;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// CHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string cFileName;

        /// CHAR[14]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternateFileName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WIN32_FILE_ATTRIBUTE_DATA
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
        public uint nFileSizeHigh;

        /// DWORD->unsigned int
        public uint nFileSizeLow;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WGLSWAP
    {

        /// HDC->HDC__*
        public IntPtr hdc;

        /// UINT->unsigned int
        public uint uiFlags;
    }

    public enum WELL_KNOWN_SID_TYPE
    {

        /// WinNullSid -> 0
        WinNullSid = 0,

        /// WinWorldSid -> 1
        WinWorldSid = 1,

        /// WinLocalSid -> 2
        WinLocalSid = 2,

        /// WinCreatorOwnerSid -> 3
        WinCreatorOwnerSid = 3,

        /// WinCreatorGroupSid -> 4
        WinCreatorGroupSid = 4,

        /// WinCreatorOwnerServerSid -> 5
        WinCreatorOwnerServerSid = 5,

        /// WinCreatorGroupServerSid -> 6
        WinCreatorGroupServerSid = 6,

        /// WinNtAuthoritySid -> 7
        WinNtAuthoritySid = 7,

        /// WinDialupSid -> 8
        WinDialupSid = 8,

        /// WinNetworkSid -> 9
        WinNetworkSid = 9,

        /// WinBatchSid -> 10
        WinBatchSid = 10,

        /// WinInteractiveSid -> 11
        WinInteractiveSid = 11,

        /// WinServiceSid -> 12
        WinServiceSid = 12,

        /// WinAnonymousSid -> 13
        WinAnonymousSid = 13,

        /// WinProxySid -> 14
        WinProxySid = 14,

        /// WinEnterpriseControllersSid -> 15
        WinEnterpriseControllersSid = 15,

        /// WinSelfSid -> 16
        WinSelfSid = 16,

        /// WinAuthenticatedUserSid -> 17
        WinAuthenticatedUserSid = 17,

        /// WinRestrictedCodeSid -> 18
        WinRestrictedCodeSid = 18,

        /// WinTerminalServerSid -> 19
        WinTerminalServerSid = 19,

        /// WinRemoteLogonIdSid -> 20
        WinRemoteLogonIdSid = 20,

        /// WinLogonIdsSid -> 21
        WinLogonIdsSid = 21,

        /// WinLocalSystemSid -> 22
        WinLocalSystemSid = 22,

        /// WinLocalServiceSid -> 23
        WinLocalServiceSid = 23,

        /// WinNetworkServiceSid -> 24
        WinNetworkServiceSid = 24,

        /// WinBuiltinDomainSid -> 25
        WinBuiltinDomainSid = 25,

        /// WinBuiltinAdministratorsSid -> 26
        WinBuiltinAdministratorsSid = 26,

        /// WinBuiltinUsersSid -> 27
        WinBuiltinUsersSid = 27,

        /// WinBuiltinGuestsSid -> 28
        WinBuiltinGuestsSid = 28,

        /// WinBuiltinPowerUsersSid -> 29
        WinBuiltinPowerUsersSid = 29,

        /// WinBuiltinAccountOperatorsSid -> 30
        WinBuiltinAccountOperatorsSid = 30,

        /// WinBuiltinSystemOperatorsSid -> 31
        WinBuiltinSystemOperatorsSid = 31,

        /// WinBuiltinPrintOperatorsSid -> 32
        WinBuiltinPrintOperatorsSid = 32,

        /// WinBuiltinBackupOperatorsSid -> 33
        WinBuiltinBackupOperatorsSid = 33,

        /// WinBuiltinReplicatorSid -> 34
        WinBuiltinReplicatorSid = 34,

        /// WinBuiltinPreWindows2000CompatibleAccessSid -> 35
        WinBuiltinPreWindows2000CompatibleAccessSid = 35,

        /// WinBuiltinRemoteDesktopUsersSid -> 36
        WinBuiltinRemoteDesktopUsersSid = 36,

        /// WinBuiltinNetworkConfigurationOperatorsSid -> 37
        WinBuiltinNetworkConfigurationOperatorsSid = 37,

        /// WinAccountAdministratorSid -> 38
        WinAccountAdministratorSid = 38,

        /// WinAccountGuestSid -> 39
        WinAccountGuestSid = 39,

        /// WinAccountKrbtgtSid -> 40
        WinAccountKrbtgtSid = 40,

        /// WinAccountDomainAdminsSid -> 41
        WinAccountDomainAdminsSid = 41,

        /// WinAccountDomainUsersSid -> 42
        WinAccountDomainUsersSid = 42,

        /// WinAccountDomainGuestsSid -> 43
        WinAccountDomainGuestsSid = 43,

        /// WinAccountComputersSid -> 44
        WinAccountComputersSid = 44,

        /// WinAccountControllersSid -> 45
        WinAccountControllersSid = 45,

        /// WinAccountCertAdminsSid -> 46
        WinAccountCertAdminsSid = 46,

        /// WinAccountSchemaAdminsSid -> 47
        WinAccountSchemaAdminsSid = 47,

        /// WinAccountEnterpriseAdminsSid -> 48
        WinAccountEnterpriseAdminsSid = 48,

        /// WinAccountPolicyAdminsSid -> 49
        WinAccountPolicyAdminsSid = 49,

        /// WinAccountRasAndIasServersSid -> 50
        WinAccountRasAndIasServersSid = 50,

        /// WinNTLMAuthenticationSid -> 51
        WinNTLMAuthenticationSid = 51,

        /// WinDigestAuthenticationSid -> 52
        WinDigestAuthenticationSid = 52,

        /// WinSChannelAuthenticationSid -> 53
        WinSChannelAuthenticationSid = 53,

        /// WinThisOrganizationSid -> 54
        WinThisOrganizationSid = 54,

        /// WinOtherOrganizationSid -> 55
        WinOtherOrganizationSid = 55,

        /// WinBuiltinIncomingForestTrustBuildersSid -> 56
        WinBuiltinIncomingForestTrustBuildersSid = 56,

        /// WinBuiltinPerfMonitoringUsersSid -> 57
        WinBuiltinPerfMonitoringUsersSid = 57,

        /// WinBuiltinPerfLoggingUsersSid -> 58
        WinBuiltinPerfLoggingUsersSid = 58,

        /// WinBuiltinAuthorizationAccessSid -> 59
        WinBuiltinAuthorizationAccessSid = 59,

        /// WinBuiltinTerminalServerLicenseServersSid -> 60
        WinBuiltinTerminalServerLicenseServersSid = 60,

        /// WinBuiltinDCOMUsersSid -> 61
        WinBuiltinDCOMUsersSid = 61,
    }

}
