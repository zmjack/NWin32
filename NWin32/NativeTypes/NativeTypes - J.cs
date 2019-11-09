using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct joyinfo_tag
    {

        /// UINT->unsigned int
        public uint wXpos;

        /// UINT->unsigned int
        public uint wYpos;

        /// UINT->unsigned int
        public uint wZpos;

        /// UINT->unsigned int
        public uint wButtons;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct joyinfoex_tag
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwXpos;

        /// DWORD->unsigned int
        public uint dwYpos;

        /// DWORD->unsigned int
        public uint dwZpos;

        /// DWORD->unsigned int
        public uint dwRpos;

        /// DWORD->unsigned int
        public uint dwUpos;

        /// DWORD->unsigned int
        public uint dwVpos;

        /// DWORD->unsigned int
        public uint dwButtons;

        /// DWORD->unsigned int
        public uint dwButtonNumber;

        /// DWORD->unsigned int
        public uint dwPOV;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// DWORD->unsigned int
        public uint dwReserved2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_SET_ARRAY
    {

        /// HANDLE->void*
        public IntPtr JobHandle;

        /// DWORD->unsigned int
        public uint MemberLevel;

        /// DWORD->unsigned int
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_INFO_3
    {

        /// DWORD->unsigned int
        public uint JobId;

        /// DWORD->unsigned int
        public uint NextJobId;

        /// DWORD->unsigned int
        public uint Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_INFO_2W
    {

        /// DWORD->unsigned int
        public uint JobId;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrinterName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pMachineName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pUserName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDocument;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pNotifyName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDatatype;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrintProcessor;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pParameters;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDriverName;

        /// LPDEVMODEW->_devicemodeW*
        public IntPtr pDevMode;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pStatus;

        /// PSECURITY_DESCRIPTOR->PVOID->void*
        public IntPtr pSecurityDescriptor;

        /// DWORD->unsigned int
        public uint Status;

        /// DWORD->unsigned int
        public uint Priority;

        /// DWORD->unsigned int
        public uint Position;

        /// DWORD->unsigned int
        public uint StartTime;

        /// DWORD->unsigned int
        public uint UntilTime;

        /// DWORD->unsigned int
        public uint TotalPages;

        /// DWORD->unsigned int
        public uint Size;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME Submitted;

        /// DWORD->unsigned int
        public uint Time;

        /// DWORD->unsigned int
        public uint PagesPrinted;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_INFO_2A
    {

        /// DWORD->unsigned int
        public uint JobId;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPrinterName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pMachineName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pUserName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocument;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pNotifyName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDatatype;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPrintProcessor;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pParameters;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDriverName;

        /// LPDEVMODEA->_devicemodeA*
        public IntPtr pDevMode;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pStatus;

        /// PSECURITY_DESCRIPTOR->PVOID->void*
        public IntPtr pSecurityDescriptor;

        /// DWORD->unsigned int
        public uint Status;

        /// DWORD->unsigned int
        public uint Priority;

        /// DWORD->unsigned int
        public uint Position;

        /// DWORD->unsigned int
        public uint StartTime;

        /// DWORD->unsigned int
        public uint UntilTime;

        /// DWORD->unsigned int
        public uint TotalPages;

        /// DWORD->unsigned int
        public uint Size;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME Submitted;

        /// DWORD->unsigned int
        public uint Time;

        /// DWORD->unsigned int
        public uint PagesPrinted;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_INFO_1W
    {

        /// DWORD->unsigned int
        public uint JobId;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrinterName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pMachineName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pUserName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDocument;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDatatype;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pStatus;

        /// DWORD->unsigned int
        public uint Status;

        /// DWORD->unsigned int
        public uint Priority;

        /// DWORD->unsigned int
        public uint Position;

        /// DWORD->unsigned int
        public uint TotalPages;

        /// DWORD->unsigned int
        public uint PagesPrinted;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME Submitted;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOB_INFO_1A
    {

        /// DWORD->unsigned int
        public uint JobId;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPrinterName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pMachineName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pUserName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocument;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDatatype;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pStatus;

        /// DWORD->unsigned int
        public uint Status;

        /// DWORD->unsigned int
        public uint Priority;

        /// DWORD->unsigned int
        public uint Position;

        /// DWORD->unsigned int
        public uint TotalPages;

        /// DWORD->unsigned int
        public uint PagesPrinted;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME Submitted;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_SECURITY_LIMIT_INFORMATION
    {

        /// DWORD->unsigned int
        public uint SecurityLimitFlags;

        /// HANDLE->void*
        public IntPtr JobToken;

        /// PTOKEN_GROUPS->_TOKEN_GROUPS*
        public IntPtr SidsToDisable;

        /// PTOKEN_PRIVILEGES->_TOKEN_PRIVILEGES*
        public IntPtr PrivilegesToDelete;

        /// PTOKEN_GROUPS->_TOKEN_GROUPS*
        public IntPtr RestrictedSids;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_JOBSET_INFORMATION
    {

        /// DWORD->unsigned int
        public uint MemberLevel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
    {

        /// JOBOBJECT_BASIC_LIMIT_INFORMATION->_JOBOBJECT_BASIC_LIMIT_INFORMATION
        public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;

        /// IO_COUNTERS->_IO_COUNTERS
        public IO_COUNTERS IoInfo;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint ProcessMemoryLimit;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint JobMemoryLimit;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint PeakProcessMemoryUsed;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint PeakJobMemoryUsed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_END_OF_JOB_TIME_INFORMATION
    {

        /// DWORD->unsigned int
        public uint EndOfJobTimeAction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_UI_RESTRICTIONS
    {

        /// DWORD->unsigned int
        public uint UIRestrictionsClass;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_PROCESS_ID_LIST
    {

        /// DWORD->unsigned int
        public uint NumberOfAssignedProcesses;

        /// DWORD->unsigned int
        public uint NumberOfProcessIdsInList;

        /// ULONG_PTR[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
        public uint[] ProcessIdList;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_LIMIT_INFORMATION
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PerProcessUserTimeLimit;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PerJobUserTimeLimit;

        /// DWORD->unsigned int
        public uint LimitFlags;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint MinimumWorkingSetSize;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint MaximumWorkingSetSize;

        /// DWORD->unsigned int
        public uint ActiveProcessLimit;

        /// ULONG_PTR->unsigned int
        public uint Affinity;

        /// DWORD->unsigned int
        public uint PriorityClass;

        /// DWORD->unsigned int
        public uint SchedulingClass;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_AND_IO_ACCOUNTING_INFORMATION
    {

        /// JOBOBJECT_BASIC_ACCOUNTING_INFORMATION->_JOBOBJECT_BASIC_ACCOUNTING_INFORMATION
        public JOBOBJECT_BASIC_ACCOUNTING_INFORMATION BasicInfo;

        /// IO_COUNTERS->_IO_COUNTERS
        public IO_COUNTERS IoInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_BASIC_ACCOUNTING_INFORMATION
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER TotalUserTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER TotalKernelTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER ThisPeriodTotalUserTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER ThisPeriodTotalKernelTime;

        /// DWORD->unsigned int
        public uint TotalPageFaultCount;

        /// DWORD->unsigned int
        public uint TotalProcesses;

        /// DWORD->unsigned int
        public uint ActiveProcesses;

        /// DWORD->unsigned int
        public uint TotalTerminatedProcesses;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JOBOBJECT_ASSOCIATE_COMPLETION_PORT
    {

        /// PVOID->void*
        public IntPtr CompletionKey;

        /// HANDLE->void*
        public IntPtr CompletionPort;
    }

    public enum JOBOBJECTINFOCLASS
    {

        /// JobObjectBasicAccountingInformation -> 1
        JobObjectBasicAccountingInformation = 1,

        JobObjectBasicLimitInformation,

        JobObjectBasicProcessIdList,

        JobObjectBasicUIRestrictions,

        JobObjectSecurityLimitInformation,

        JobObjectEndOfJobTimeInformation,

        JobObjectAssociateCompletionPortInformation,

        JobObjectBasicAndIoAccountingInformation,

        JobObjectExtendedLimitInformation,

        JobObjectJobSetInformation,

        MaxJobObjectInfoClass,
    }

}
