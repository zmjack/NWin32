using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    public enum SYSNLS_FUNCTION
    {

        /// COMPARE_STRING -> 0x0001
        COMPARE_STRING = 1,
    }

    public enum SYSGEOTYPE
    {

        /// GEO_NATION -> 0x0001
        GEO_NATION = 1,

        /// GEO_LATITUDE -> 0x0002
        GEO_LATITUDE = 2,

        /// GEO_LONGITUDE -> 0x0003
        GEO_LONGITUDE = 3,

        /// GEO_ISO2 -> 0x0004
        GEO_ISO2 = 4,

        /// GEO_ISO3 -> 0x0005
        GEO_ISO3 = 5,

        /// GEO_RFC1766 -> 0x0006
        GEO_RFC1766 = 6,

        /// GEO_LCID -> 0x0007
        GEO_LCID = 7,

        /// GEO_FRIENDLYNAME -> 0x0008
        GEO_FRIENDLYNAME = 8,

        /// GEO_OFFICIALNAME -> 0x0009
        GEO_OFFICIALNAME = 9,

        /// GEO_TIMEZONES -> 0x000A
        GEO_TIMEZONES = 10,

        /// GEO_OFFICIALLANGUAGES -> 0x000B
        GEO_OFFICIALLANGUAGES = 11,
    }

    public enum SYSGEOCLASS
    {

        /// GEOCLASS_NATION -> 16
        GEOCLASS_NATION = 16,

        /// GEOCLASS_REGION -> 14
        GEOCLASS_REGION = 14,
    }

    /// Return Type: void
    ///param0: PMIDL_STUB_MESSAGE->_MIDL_STUB_MESSAGE*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void STUB_THUNK(ref MIDL_STUB_MESSAGE param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct STORAGE_BREAK_RESERVATION_REQUEST
    {

        /// DWORD->unsigned int
        public uint Length;

        /// BYTE->unsigned char
        public byte _unused;

        /// BYTE->unsigned char
        public byte PathId;

        /// BYTE->unsigned char
        public byte TargetId;

        /// BYTE->unsigned char
        public byte Lun;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct sockproto
    {

        /// u_short->unsigned short
        public ushort sp_family;

        /// u_short->unsigned short
        public ushort sp_protocol;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct sockaddr_in
    {

        /// short
        public short sin_family;

        /// u_short->unsigned short
        public ushort sin_port;

        /// in_addr
        public in_addr sin_addr;

        /// char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string sin_zero;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct sockaddr
    {

        /// u_short->unsigned short
        public ushort sa_family;

        /// char[14]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string sa_data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_STATUS_HANDLE__
    {

        /// int
        public int unused;
    }

    /// Return Type: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int SERVER_ROUTINE();

    [StructLayout(LayoutKind.Sequential)]
    public struct servent
    {

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string s_name;

        /// char**
        public IntPtr s_aliases;

        /// short
        public short s_port;

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string s_proto;
    }

    /// Return Type: void
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: ULONG_PTR->unsigned int
    ///param3: LRESULT->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void SENDASYNCPROC(IntPtr param0, uint param1, uint param2, IntPtr param3);

    [StructLayout(LayoutKind.Sequential)]
    public struct SC_HANDLE__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SChannelHookCallInfo
    {

        /// IID->GUID->_GUID
        public GUID iid;

        /// DWORD->unsigned int
        public uint cbSize;

        /// GUID->_GUID
        public GUID uCausality;

        /// DWORD->unsigned int
        public uint dwServerPid;

        /// DWORD->unsigned int
        public uint iMethod;

        /// void*
        public IntPtr pObject;
    }

    public enum SZM_FLAGS
    {

        /// SZM_CREATE -> 0
        SZM_CREATE = 0,

        /// SZM_DELETE -> 0x1
        SZM_DELETE = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_STATUS
    {

        /// BYTE->unsigned char
        public byte ACLineStatus;

        /// BYTE->unsigned char
        public byte BatteryFlag;

        /// BYTE->unsigned char
        public byte BatteryLifePercent;

        /// BYTE->unsigned char
        public byte Reserved1;

        /// DWORD->unsigned int
        public uint BatteryLifeTime;

        /// DWORD->unsigned int
        public uint BatteryFullLifeTime;
    }

    public enum SYSTEM_POWER_STATE
    {

        /// PowerSystemUnspecified -> 0
        PowerSystemUnspecified = 0,

        /// PowerSystemWorking -> 1
        PowerSystemWorking = 1,

        /// PowerSystemSleeping1 -> 2
        PowerSystemSleeping1 = 2,

        /// PowerSystemSleeping2 -> 3
        PowerSystemSleeping2 = 3,

        /// PowerSystemSleeping3 -> 4
        PowerSystemSleeping3 = 4,

        /// PowerSystemHibernate -> 5
        PowerSystemHibernate = 5,

        /// PowerSystemShutdown -> 6
        PowerSystemShutdown = 6,

        /// PowerSystemMaximum -> 7
        PowerSystemMaximum = 7,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_POLICY
    {

        /// DWORD->unsigned int
        public uint Revision;

        /// POWER_ACTION_POLICY->Anonymous_1b853e9a_7835_4196_b67f_de92526d47b3
        public POWER_ACTION_POLICY PowerButton;

        /// POWER_ACTION_POLICY->Anonymous_1b853e9a_7835_4196_b67f_de92526d47b3
        public POWER_ACTION_POLICY SleepButton;

        /// POWER_ACTION_POLICY->Anonymous_1b853e9a_7835_4196_b67f_de92526d47b3
        public POWER_ACTION_POLICY LidClose;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE LidOpenWake;

        /// DWORD->unsigned int
        public uint Reserved;

        /// POWER_ACTION_POLICY->Anonymous_1b853e9a_7835_4196_b67f_de92526d47b3
        public POWER_ACTION_POLICY Idle;

        /// DWORD->unsigned int
        public uint IdleTimeout;

        /// BYTE->unsigned char
        public byte IdleSensitivity;

        /// BYTE->unsigned char
        public byte DynamicThrottle;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] Spare2;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE MinSleep;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE MaxSleep;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE ReducedLatencySleep;

        /// DWORD->unsigned int
        public uint WinLogonFlags;

        /// DWORD->unsigned int
        public uint Spare3;

        /// DWORD->unsigned int
        public uint DozeS4Timeout;

        /// DWORD->unsigned int
        public uint BroadcastCapacityResolution;

        /// SYSTEM_POWER_LEVEL[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
        public SYSTEM_POWER_LEVEL[] DischargePolicy;

        /// DWORD->unsigned int
        public uint VideoTimeout;

        /// BOOLEAN->BYTE->unsigned char
        public byte VideoDimDisplay;

        /// DWORD[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
        public uint[] VideoReserved;

        /// DWORD->unsigned int
        public uint SpindownTimeout;

        /// BOOLEAN->BYTE->unsigned char
        public byte OptimizeForPower;

        /// BYTE->unsigned char
        public byte FanThrottleTolerance;

        /// BYTE->unsigned char
        public byte ForcedThrottle;

        /// BYTE->unsigned char
        public byte MinThrottle;

        /// POWER_ACTION_POLICY->Anonymous_1b853e9a_7835_4196_b67f_de92526d47b3
        public POWER_ACTION_POLICY OverThrottled;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_LEVEL
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte Enable;

        /// BYTE[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public byte[] Spare;

        /// DWORD->unsigned int
        public uint BatteryLevel;

        /// POWER_ACTION_POLICY->Anonymous_1b853e9a_7835_4196_b67f_de92526d47b3
        public POWER_ACTION_POLICY PowerPolicy;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE MinSystemState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_CAPABILITIES
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte PowerButtonPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte SleepButtonPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte LidPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte SystemS1;

        /// BOOLEAN->BYTE->unsigned char
        public byte SystemS2;

        /// BOOLEAN->BYTE->unsigned char
        public byte SystemS3;

        /// BOOLEAN->BYTE->unsigned char
        public byte SystemS4;

        /// BOOLEAN->BYTE->unsigned char
        public byte SystemS5;

        /// BOOLEAN->BYTE->unsigned char
        public byte HiberFilePresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte FullWake;

        /// BOOLEAN->BYTE->unsigned char
        public byte VideoDimPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte ApmPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte UpsPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte ThermalControl;

        /// BOOLEAN->BYTE->unsigned char
        public byte ProcessorThrottle;

        /// BYTE->unsigned char
        public byte ProcessorMinThrottle;

        /// BYTE->unsigned char
        public byte ProcessorMaxThrottle;

        /// BYTE[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
        public byte[] spare2;

        /// BOOLEAN->BYTE->unsigned char
        public byte DiskSpinDown;

        /// BYTE[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
        public byte[] spare3;

        /// BOOLEAN->BYTE->unsigned char
        public byte SystemBatteriesPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte BatteriesAreShortTerm;

        /// BATTERY_REPORTING_SCALE[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
        public BATTERY_REPORTING_SCALE[] BatteryScale;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE AcOnLineWake;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE SoftLidWake;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE RtcWake;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE MinDeviceWakeState;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE DefaultLowLatencyWake;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
    {

        /// ULONG_PTR->unsigned int
        public uint ProcessorMask;

        /// LOGICAL_PROCESSOR_RELATIONSHIP->_LOGICAL_PROCESSOR_RELATIONSHIP
        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

        /// Anonymous_cfba373b_d315_405c_b345_eabbe699bc66
        public Anonymous_cfba373b_d315_405c_b345_eabbe699bc66 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {

        /// Anonymous_459bdf75_2992_4fef_9fb5_389952f59d12
        public Anonymous_459bdf75_2992_4fef_9fb5_389952f59d12 Union1;

        /// DWORD->unsigned int
        public uint dwPageSize;

        /// LPVOID->void*
        public IntPtr lpMinimumApplicationAddress;

        /// LPVOID->void*
        public IntPtr lpMaximumApplicationAddress;

        /// DWORD_PTR->ULONG_PTR->unsigned int
        public uint dwActiveProcessorMask;

        /// DWORD->unsigned int
        public uint dwNumberOfProcessors;

        /// DWORD->unsigned int
        public uint dwProcessorType;

        /// DWORD->unsigned int
        public uint dwAllocationGranularity;

        /// WORD->unsigned short
        public ushort wProcessorLevel;

        /// WORD->unsigned short
        public ushort wProcessorRevision;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_BATTERY_STATE
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte AcOnLine;

        /// BOOLEAN->BYTE->unsigned char
        public byte BatteryPresent;

        /// BOOLEAN->BYTE->unsigned char
        public byte Charging;

        /// BOOLEAN->BYTE->unsigned char
        public byte Discharging;

        /// BOOLEAN[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
        public byte[] Spare1;

        /// DWORD->unsigned int
        public uint MaxCapacity;

        /// DWORD->unsigned int
        public uint RemainingCapacity;

        /// DWORD->unsigned int
        public uint Rate;

        /// DWORD->unsigned int
        public uint EstimatedTime;

        /// DWORD->unsigned int
        public uint DefaultAlert1;

        /// DWORD->unsigned int
        public uint DefaultAlert2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_AUDIT_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_AUDIT_CALLBACK_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_AUDIT_CALLBACK_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_AUDIT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_ALARM_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_ALARM_CALLBACK_OBJECT_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint Flags;

        /// GUID->_GUID
        public GUID ObjectType;

        /// GUID->_GUID
        public GUID InheritedObjectType;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_ALARM_CALLBACK_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_ALARM_ACE
    {

        /// ACE_HEADER->_ACE_HEADER
        public ACE_HEADER Header;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint Mask;

        /// DWORD->unsigned int
        public uint SidStart;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {

        /// WORD->unsigned short
        public ushort wYear;

        /// WORD->unsigned short
        public ushort wMonth;

        /// WORD->unsigned short
        public ushort wDayOfWeek;

        /// WORD->unsigned short
        public ushort wDay;

        /// WORD->unsigned short
        public ushort wHour;

        /// WORD->unsigned short
        public ushort wMinute;

        /// WORD->unsigned short
        public ushort wSecond;

        /// WORD->unsigned short
        public ushort wMilliseconds;
    }

    public enum STUB_PHASE
    {

        STUB_UNMARSHAL,

        STUB_CALL_SERVER,

        STUB_MARSHAL,

        STUB_CALL_SERVER_NO_HRESULT,
    }

    public enum STREAM_INFO_LEVELS
    {

        FindStreamInfoStandard,

        FindStreamInfoMaxInfoLevel,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STORAGE_PREDICT_FAILURE
    {

        /// DWORD->unsigned int
        public uint PredictFailure;

        /// BYTE[512]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.I1)]
        public byte[] VendorSpecific;
    }

    public enum STORAGE_MEDIA_TYPE
    {

        /// DDS_4mm -> 0x20
        DDS_4mm = 32,

        MiniQic,

        Travan,

        QIC,

        MP_8mm,

        AME_8mm,

        AIT1_8mm,

        DLT,

        NCTP,

        IBM_3480,

        IBM_3490E,

        IBM_Magstar_3590,

        IBM_Magstar_MP,

        STK_DATA_D3,

        SONY_DTF,

        DV_6mm,

        DMI,

        SONY_D2,

        CLEANER_CARTRIDGE,

        CD_ROM,

        CD_R,

        CD_RW,

        DVD_ROM,

        DVD_R,

        DVD_RW,

        MO_3_RW,

        MO_5_WO,

        MO_5_RW,

        MO_5_LIMDOW,

        PC_5_WO,

        PC_5_RW,

        PD_5_RW,

        ABL_5_WO,

        PINNACLE_APEX_5_RW,

        SONY_12_WO,

        PHILIPS_12_WO,

        HITACHI_12_WO,

        CYGNET_12_WO,

        KODAK_14_WO,

        MO_NFR_525,

        NIKON_12_RW,

        IOMEGA_ZIP,

        IOMEGA_JAZ,

        SYQUEST_EZ135,

        SYQUEST_EZFLYER,

        SYQUEST_SYJET,

        AVATAR_F2,

        MP2_8mm,

        DST_S,

        DST_M,

        DST_L,

        VXATape_1,

        VXATape_2,

        STK_9840,

        LTO_Ultrium,

        LTO_Accelis,

        DVD_RAM,

        AIT_8mm,

        ADR_1,

        ADR_2,

        STK_9940,

        SAIT,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STORAGE_HOTPLUG_INFO
    {

        /// DWORD->unsigned int
        public uint Size;

        /// BOOLEAN->BYTE->unsigned char
        public byte MediaRemovable;

        /// BOOLEAN->BYTE->unsigned char
        public byte MediaHotplug;

        /// BOOLEAN->BYTE->unsigned char
        public byte DeviceHotplug;

        /// BOOLEAN->BYTE->unsigned char
        public byte WriteCacheEnableOverride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STORAGE_DEVICE_NUMBER
    {

        /// DWORD->unsigned int
        public uint DeviceType;

        /// DWORD->unsigned int
        public uint DeviceNumber;

        /// DWORD->unsigned int
        public uint PartitionNumber;
    }

    public enum STORAGE_BUS_TYPE
    {

        /// BusTypeUnknown -> 0x00
        BusTypeUnknown = 0,

        BusTypeScsi,

        BusTypeAtapi,

        BusTypeAta,

        BusType1394,

        BusTypeSsa,

        BusTypeFibre,

        BusTypeUsb,

        BusTypeRAID,

        BusTypeiScsi,

        BusTypeSas,

        BusTypeSata,

        /// BusTypeMaxReserved -> 0x7F
        BusTypeMaxReserved = 127,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STORAGE_BUS_RESET_REQUEST
    {

        /// BYTE->unsigned char
        public byte PathId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STARTUPINFOW
    {

        /// DWORD->unsigned int
        public uint cb;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpReserved;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDesktop;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpTitle;

        /// DWORD->unsigned int
        public uint dwX;

        /// DWORD->unsigned int
        public uint dwY;

        /// DWORD->unsigned int
        public uint dwXSize;

        /// DWORD->unsigned int
        public uint dwYSize;

        /// DWORD->unsigned int
        public uint dwXCountChars;

        /// DWORD->unsigned int
        public uint dwYCountChars;

        /// DWORD->unsigned int
        public uint dwFillAttribute;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// WORD->unsigned short
        public ushort wShowWindow;

        /// WORD->unsigned short
        public ushort cbReserved2;

        /// LPBYTE->BYTE*
        public IntPtr lpReserved2;

        /// HANDLE->void*
        public IntPtr hStdInput;

        /// HANDLE->void*
        public IntPtr hStdOutput;

        /// HANDLE->void*
        public IntPtr hStdError;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STARTUPINFOA
    {

        /// DWORD->unsigned int
        public uint cb;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpReserved;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDesktop;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpTitle;

        /// DWORD->unsigned int
        public uint dwX;

        /// DWORD->unsigned int
        public uint dwY;

        /// DWORD->unsigned int
        public uint dwXSize;

        /// DWORD->unsigned int
        public uint dwYSize;

        /// DWORD->unsigned int
        public uint dwXCountChars;

        /// DWORD->unsigned int
        public uint dwYCountChars;

        /// DWORD->unsigned int
        public uint dwFillAttribute;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// WORD->unsigned short
        public ushort wShowWindow;

        /// WORD->unsigned short
        public ushort cbReserved2;

        /// LPBYTE->BYTE*
        public IntPtr lpReserved2;

        /// HANDLE->void*
        public IntPtr hStdInput;

        /// HANDLE->void*
        public IntPtr hStdOutput;

        /// HANDLE->void*
        public IntPtr hStdError;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct StartParam
    {

        /// IID->GUID->_GUID
        public GUID iid;

        /// IBindCtx*
        public IntPtr pIBindCtx;

        /// IUnknown*
        public IntPtr pItf;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STARTING_VCN_INPUT_BUFFER
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingVcn;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct STARTING_LCN_INPUT_BUFFER
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingLcn;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SSL_EXTRA_CERT_CHAIN_POLICY_PARA
    {

        /// Anonymous_14807298_3e51_42fc_9504_55e7fb0c037f
        public Anonymous_14807298_3e51_42fc_9504_55e7fb0c037f Union1;

        /// DWORD->unsigned int
        public uint dwAuthType;

        /// DWORD->unsigned int
        public uint fdwChecks;

        /// WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszServerName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SOFTDISTINFO
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwAdState;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szTitle;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szAbstract;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szHREF;

        /// DWORD->unsigned int
        public uint dwInstalledVersionMS;

        /// DWORD->unsigned int
        public uint dwInstalledVersionLS;

        /// DWORD->unsigned int
        public uint dwUpdateVersionMS;

        /// DWORD->unsigned int
        public uint dwUpdateVersionLS;

        /// DWORD->unsigned int
        public uint dwAdvertisedVersionMS;

        /// DWORD->unsigned int
        public uint dwAdvertisedVersionLS;

        /// DWORD->unsigned int
        public uint dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SMALL_RECT
    {

        /// SHORT->short
        public short Left;

        /// SHORT->short
        public short Top;

        /// SHORT->short
        public short Right;

        /// SHORT->short
        public short Bottom;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SLIST_HEADER
    {

        /// ULONGLONG->unsigned __int64
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public ulong Alignment;

        /// Anonymous_fd626461_7f3e_49a1_aabe_a2b90f0df936
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public Anonymous_fd626461_7f3e_49a1_aabe_a2b90f0df936 Struct1;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SI_COPYFILE
    {

        /// DWORD->unsigned int
        public uint SourceFileNameLength;

        /// DWORD->unsigned int
        public uint DestinationFileNameLength;

        /// DWORD->unsigned int
        public uint Flags;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string FileNameBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SINGLE_LIST_ENTRY
    {

        /// _SINGLE_LIST_ENTRY*
        public IntPtr Next;
    }

    public enum SID_NAME_USE
    {

        /// SidTypeUser -> 1
        SidTypeUser = 1,

        SidTypeGroup,

        SidTypeDomain,

        SidTypeAlias,

        SidTypeWellKnownGroup,

        SidTypeDeletedAccount,

        SidTypeInvalid,

        SidTypeUnknown,

        SidTypeComputer,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SID_IDENTIFIER_AUTHORITY
    {

        /// BYTE[6]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
        public byte[] Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SID_AND_ATTRIBUTES
    {

        /// PSID->PVOID->void*
        public IntPtr Sid;

        /// DWORD->unsigned int
        public uint Attributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SID
    {

        /// BYTE->unsigned char
        public byte Revision;

        /// BYTE->unsigned char
        public byte SubAuthorityCount;

        /// SID_IDENTIFIER_AUTHORITY->_SID_IDENTIFIER_AUTHORITY
        public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

        /// DWORD[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] SubAuthority;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHQUERYRBINFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// __int64
        public long i64Size;

        /// __int64
        public long i64NumItems;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHNAMEMAPPINGW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszOldPath;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszNewPath;

        /// int
        public int cchOldPath;

        /// int
        public int cchNewPath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHNAMEMAPPINGA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszOldPath;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszNewPath;

        /// int
        public int cchOldPath;

        /// int
        public int cchNewPath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEOPSTRUCTW
    {

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// UINT->unsigned int
        public uint wFunc;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pFrom;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pTo;

        /// FILEOP_FLAGS->WORD->unsigned short
        public ushort fFlags;

        /// BOOL->int
        public int fAnyOperationsAborted;

        /// LPVOID->void*
        public IntPtr hNameMappings;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpszProgressTitle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEOPSTRUCTA
    {

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// UINT->unsigned int
        public uint wFunc;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pFrom;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pTo;

        /// FILEOP_FLAGS->WORD->unsigned short
        public ushort fFlags;

        /// BOOL->int
        public int fAnyOperationsAborted;

        /// LPVOID->void*
        public IntPtr hNameMappings;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszProgressTitle;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHFILEINFOW
    {

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// int
        public int iIcon;

        /// DWORD->unsigned int
        public uint dwAttributes;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;

        /// WCHAR[80]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SHFILEINFOA
    {

        /// HICON->HICON__*
        public IntPtr hIcon;

        /// int
        public int iIcon;

        /// DWORD->unsigned int
        public uint dwAttributes;

        /// CHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;

        /// CHAR[80]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHELLHOOKINFO
    {

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// RECT->tagRECT
        public tagRECT rc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHELLEXECUTEINFOW
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// ULONG->unsigned int
        public uint fMask;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpVerb;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpFile;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpParameters;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDirectory;

        /// int
        public int nShow;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstApp;

        /// LPVOID->void*
        public IntPtr lpIDList;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpClass;

        /// HKEY->HKEY__*
        public IntPtr hkeyClass;

        /// DWORD->unsigned int
        public uint dwHotKey;

        /// Anonymous_98a511c6_8aeb_4e58_afe9_4f14a656c4cc
        public Anonymous_98a511c6_8aeb_4e58_afe9_4f14a656c4cc Union1;

        /// HANDLE->void*
        public IntPtr hProcess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHELLEXECUTEINFOA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// ULONG->unsigned int
        public uint fMask;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpVerb;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpFile;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpParameters;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDirectory;

        /// int
        public int nShow;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstApp;

        /// LPVOID->void*
        public IntPtr lpIDList;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpClass;

        /// HKEY->HKEY__*
        public IntPtr hkeyClass;

        /// DWORD->unsigned int
        public uint dwHotKey;

        /// Anonymous_884f82cb_5522_4cde_9861_2583ea4ab552
        public Anonymous_884f82cb_5522_4cde_9861_2583ea4ab552 Union1;

        /// HANDLE->void*
        public IntPtr hProcess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHCREATEPROCESSINFOW
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// ULONG->unsigned int
        public uint fMask;

        /// HWND->HWND__*
        public IntPtr hwnd;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszFile;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszParameters;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszCurrentDirectory;

        /// HANDLE->void*
        public IntPtr hUserToken;

        /// LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        public IntPtr lpProcessAttributes;

        /// LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        public IntPtr lpThreadAttributes;

        /// BOOL->int
        public int bInheritHandles;

        /// DWORD->unsigned int
        public uint dwCreationFlags;

        /// LPSTARTUPINFOW->_STARTUPINFOW*
        public IntPtr lpStartupInfo;

        /// LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        public IntPtr lpProcessInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SE_IMPERSONATION_STATE
    {

        /// PACCESS_TOKEN->PVOID->void*
        public IntPtr Token;

        /// BOOLEAN->BYTE->unsigned char
        public byte CopyOnOpen;

        /// BOOLEAN->BYTE->unsigned char
        public byte EffectiveOnly;

        /// SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
        public SECURITY_IMPERSONATION_LEVEL Level;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SET_PARTITION_INFORMATION_EX
    {

        /// PARTITION_STYLE->_PARTITION_STYLE
        public PARTITION_STYLE PartitionStyle;

        /// Anonymous_28149612_2d2b_4017_83d6_ea46e595ab25
        public Anonymous_28149612_2d2b_4017_83d6_ea46e595ab25 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SET_PARTITION_INFORMATION
    {

        /// BYTE->unsigned char
        public byte PartitionType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SESSION_HEADER
    {

        /// UCHAR->unsigned char
        public byte sess_name;

        /// UCHAR->unsigned char
        public byte num_sess;

        /// UCHAR->unsigned char
        public byte rcv_dg_outstanding;

        /// UCHAR->unsigned char
        public byte rcv_any_outstanding;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SESSION_BUFFER
    {

        /// UCHAR->unsigned char
        public byte lsn;

        /// UCHAR->unsigned char
        public byte state;

        /// UCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string local_name;

        /// UCHAR[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string remote_name;

        /// UCHAR->unsigned char
        public byte rcvs_outstanding;

        /// UCHAR->unsigned char
        public byte sends_outstanding;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_TABLE_ENTRYW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpServiceName;

        /// LPSERVICE_MAIN_FUNCTIONW
        public LPSERVICE_MAIN_FUNCTIONW lpServiceProc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_TABLE_ENTRYA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpServiceName;

        /// LPSERVICE_MAIN_FUNCTIONA
        public LPSERVICE_MAIN_FUNCTIONA lpServiceProc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_STATUS_PROCESS
    {

        /// DWORD->unsigned int
        public uint dwServiceType;

        /// DWORD->unsigned int
        public uint dwCurrentState;

        /// DWORD->unsigned int
        public uint dwControlsAccepted;

        /// DWORD->unsigned int
        public uint dwWin32ExitCode;

        /// DWORD->unsigned int
        public uint dwServiceSpecificExitCode;

        /// DWORD->unsigned int
        public uint dwCheckPoint;

        /// DWORD->unsigned int
        public uint dwWaitHint;

        /// DWORD->unsigned int
        public uint dwProcessId;

        /// DWORD->unsigned int
        public uint dwServiceFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_STATUS
    {

        /// DWORD->unsigned int
        public uint dwServiceType;

        /// DWORD->unsigned int
        public uint dwCurrentState;

        /// DWORD->unsigned int
        public uint dwControlsAccepted;

        /// DWORD->unsigned int
        public uint dwWin32ExitCode;

        /// DWORD->unsigned int
        public uint dwServiceSpecificExitCode;

        /// DWORD->unsigned int
        public uint dwCheckPoint;

        /// DWORD->unsigned int
        public uint dwWaitHint;
    }

    public enum SERVICE_NODE_TYPE
    {

        /// DriverType -> 0x00000001
        DriverType = 1,

        /// FileSystemType -> 0x00000002
        FileSystemType = 2,

        /// Win32ServiceOwnProcess -> 0x00000010
        Win32ServiceOwnProcess = 16,

        /// Win32ServiceShareProcess -> 0x00000020
        Win32ServiceShareProcess = 32,

        /// AdapterType -> 0x00000004
        AdapterType = 4,

        /// RecognizerType -> 0x00000008
        RecognizerType = 8,
    }

    public enum SERVICE_LOAD_TYPE
    {

        /// BootLoad -> 0x00000000
        BootLoad = 0,

        /// SystemLoad -> 0x00000001
        SystemLoad = 1,

        /// AutoLoad -> 0x00000002
        AutoLoad = 2,

        /// DemandLoad -> 0x00000003
        DemandLoad = 3,

        /// DisableLoad -> 0x00000004
        DisableLoad = 4,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_FAILURE_ACTIONSW
    {

        /// DWORD->unsigned int
        public uint dwResetPeriod;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpRebootMsg;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpCommand;

        /// DWORD->unsigned int
        public uint cActions;

        /// SC_ACTION*
        public IntPtr lpsaActions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_FAILURE_ACTIONSA
    {

        /// DWORD->unsigned int
        public uint dwResetPeriod;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpRebootMsg;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpCommand;

        /// DWORD->unsigned int
        public uint cActions;

        /// SC_ACTION*
        public IntPtr lpsaActions;
    }

    public enum SERVICE_ERROR_TYPE
    {

        /// IgnoreError -> 0x00000000
        IgnoreError = 0,

        /// NormalError -> 0x00000001
        NormalError = 1,

        /// SevereError -> 0x00000002
        SevereError = 2,

        /// CriticalError -> 0x00000003
        CriticalError = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_DESCRIPTIONW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDescription;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SERVICE_DESCRIPTIONA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDescription;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SENDCMDOUTPARAMS
    {

        /// DWORD->unsigned int
        public uint cBufferSize;

        /// DRIVERSTATUS->_DRIVERSTATUS
        public DRIVERSTATUS DriverStatus;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] bBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SENDCMDINPARAMS
    {

        /// DWORD->unsigned int
        public uint cBufferSize;

        /// IDEREGS->_IDEREGS
        public IDEREGS irDriveRegs;

        /// BYTE->unsigned char
        public byte bDriveNumber;

        /// BYTE[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public byte[] bReserved;

        /// DWORD[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved;

        /// BYTE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
        public byte[] bBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SEC_WINNT_AUTH_IDENTITY_W
    {

        /// unsigned short*
        public IntPtr User;

        /// unsigned int
        public uint UserLength;

        /// unsigned short*
        public IntPtr Domain;

        /// unsigned int
        public uint DomainLength;

        /// unsigned short*
        public IntPtr Password;

        /// unsigned int
        public uint PasswordLength;

        /// unsigned int
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SEC_WINNT_AUTH_IDENTITY_A
    {

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string User;

        /// unsigned int
        public uint UserLength;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string Domain;

        /// unsigned int
        public uint DomainLength;

        /// unsigned char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string Password;

        /// unsigned int
        public uint PasswordLength;

        /// unsigned int
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_QUALITY_OF_SERVICE
    {

        /// DWORD->unsigned int
        public uint Length;

        /// SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
        public SECURITY_IMPERSONATION_LEVEL ImpersonationLevel;

        /// SECURITY_CONTEXT_TRACKING_MODE->BOOLEAN->BYTE->unsigned char
        public byte ContextTrackingMode;

        /// BOOLEAN->BYTE->unsigned char
        public byte EffectiveOnly;
    }

    public enum SECURITY_IMPERSONATION_LEVEL
    {

        SecurityAnonymous,

        SecurityIdentification,

        SecurityImpersonation,

        SecurityDelegation,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_DESCRIPTOR_RELATIVE
    {

        /// BYTE->unsigned char
        public byte Revision;

        /// BYTE->unsigned char
        public byte Sbz1;

        /// SECURITY_DESCRIPTOR_CONTROL->WORD->unsigned short
        public ushort Control;

        /// DWORD->unsigned int
        public uint Owner;

        /// DWORD->unsigned int
        public uint Group;

        /// DWORD->unsigned int
        public uint Sacl;

        /// DWORD->unsigned int
        public uint Dacl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_DESCRIPTOR
    {

        /// BYTE->unsigned char
        public byte Revision;

        /// BYTE->unsigned char
        public byte Sbz1;

        /// SECURITY_DESCRIPTOR_CONTROL->WORD->unsigned short
        public ushort Control;

        /// PSID->PVOID->void*
        public IntPtr Owner;

        /// PSID->PVOID->void*
        public IntPtr Group;

        /// PACL->ACL*
        public IntPtr Sacl;

        /// PACL->ACL*
        public IntPtr Dacl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {

        /// DWORD->unsigned int
        public uint nLength;

        /// LPVOID->void*
        public IntPtr lpSecurityDescriptor;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bInheritHandle;
    }

    public enum SC_STATUS_TYPE
    {

        /// SC_STATUS_PROCESS_INFO -> 0
        SC_STATUS_PROCESS_INFO = 0,
    }

    public enum SC_ENUM_TYPE
    {

        /// SC_ENUM_PROCESS_INFO -> 0
        SC_ENUM_PROCESS_INFO = 0,
    }

    public enum SC_ACTION_TYPE
    {

        /// SC_ACTION_NONE -> 0
        SC_ACTION_NONE = 0,

        /// SC_ACTION_RESTART -> 1
        SC_ACTION_RESTART = 1,

        /// SC_ACTION_REBOOT -> 2
        SC_ACTION_REBOOT = 2,

        /// SC_ACTION_RUN_COMMAND -> 3
        SC_ACTION_RUN_COMMAND = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SC_ACTION
    {

        /// SC_ACTION_TYPE->_SC_ACTION_TYPE
        public SC_ACTION_TYPE Type;

        /// DWORD->unsigned int
        public uint Delay;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCONTEXT_QUEUE
    {

        /// unsigned int
        public uint NumberOfObjects;

        /// NDR_SCONTEXT*
        public IntPtr ArrayOfObjects;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCHANNEL_ALG
    {

        /// DWORD->unsigned int
        public uint dwUse;

        /// ALG_ID->unsigned int
        public uint Algid;

        /// DWORD->unsigned int
        public uint cBits;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_T1_REQUEST
    {

        /// SCARD_IO_REQUEST->_SCARD_IO_REQUEST
        public SCARD_IO_REQUEST ioRequest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_T0_REQUEST
    {

        /// SCARD_IO_REQUEST->_SCARD_IO_REQUEST
        public SCARD_IO_REQUEST ioRequest;

        /// BYTE->unsigned char
        public byte bSw1;

        /// BYTE->unsigned char
        public byte bSw2;

        /// Anonymous_32cf6d47_d069_456c_bd13_17fc2e179c43
        public Anonymous_32cf6d47_d069_456c_bd13_17fc2e179c43 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_T0_COMMAND
    {

        /// BYTE->unsigned char
        public byte bCla;

        /// BYTE->unsigned char
        public byte bIns;

        /// BYTE->unsigned char
        public byte bP1;

        /// BYTE->unsigned char
        public byte bP2;

        /// BYTE->unsigned char
        public byte bP3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_READERSTATEW
    {

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szReader;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwCurrentState;

        /// DWORD->unsigned int
        public uint dwEventState;

        /// DWORD->unsigned int
        public uint cbAtr;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbAtr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_READERSTATEA
    {

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string szReader;

        /// LPVOID->void*
        public IntPtr pvUserData;

        /// DWORD->unsigned int
        public uint dwCurrentState;

        /// DWORD->unsigned int
        public uint dwEventState;

        /// DWORD->unsigned int
        public uint cbAtr;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbAtr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_IO_REQUEST
    {

        /// DWORD->unsigned int
        public uint dwProtocol;

        /// DWORD->unsigned int
        public uint cbPciLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SCARD_ATRMASK
    {

        /// DWORD->unsigned int
        public uint cbAtr;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbAtr;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_VARIANT
    {

        /// ULONG->unsigned int
        public uint Size;

        /// wireVARIANT*
        public IntPtr aVariant;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_UNKNOWN
    {

        /// ULONG->unsigned int
        public uint Size;

        /// IUnknown**
        public IntPtr apUnknown;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_HAVEIID
    {

        /// ULONG->unsigned int
        public uint Size;

        /// IUnknown**
        public IntPtr apUnknown;

        /// IID->GUID->_GUID
        public GUID iid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_DISPATCH
    {

        /// ULONG->unsigned int
        public uint Size;

        /// IDispatch**
        public IntPtr apDispatch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_BSTR
    {

        /// ULONG->unsigned int
        public uint Size;

        /// wireBSTR*
        public IntPtr aBstr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARR_BRECORD
    {

        /// ULONG->unsigned int
        public uint Size;

        /// wireBRECORD*
        public IntPtr aRecord;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SAFEARRAYUNION
    {

        /// ULONG->unsigned int
        public uint sfType;

        /// _wireSAFEARRAY_UNION___MIDL_IOleAutomationTypes_0001
        public _wireSAFEARRAY_UNION___MIDL_IOleAutomationTypes_0001 Union1;
    }

}
