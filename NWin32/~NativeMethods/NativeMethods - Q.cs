using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///Function: LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        ///Context: PVOID->void*
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueueUserWorkItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueueUserWorkItem(PTHREAD_START_ROUTINE Function, [In] IntPtr Context, uint Flags);


        /// Return Type: DWORD->unsigned int
        ///pfnAPC: PAPCFUNC
        ///hThread: HANDLE->void*
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueueUserAPC")]
        public static extern uint QueueUserAPC(PAPCFUNC pfnAPC, [In] IntPtr hThread, uint dwData);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///pUsers: PENCRYPTION_CERTIFICATE_HASH_LIST*
        [DllImport("advapi32.dll", EntryPoint = "QueryUsersOnEncryptedFile")]
        public static extern uint QueryUsersOnEncryptedFile([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, ref IntPtr pUsers);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///InfoLevel: SC_STATUS_TYPE->_SC_STATUS_TYPE
        ///lpBuffer: LPBYTE->BYTE*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceStatusEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceStatusEx([In] ref SC_HANDLE__ hService, SC_STATUS_TYPE InfoLevel, IntPtr lpBuffer, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///lpServiceStatus: LPSERVICE_STATUS->_SERVICE_STATUS*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceStatus([In] ref SC_HANDLE__ hService, [Out] out SERVICE_STATUS lpServiceStatus);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwSecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///lpSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceObjectSecurity([In] ref SC_HANDLE__ hService, uint dwSecurityInformation, IntPtr lpSecurityDescriptor, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpLockStatus: LPQUERY_SERVICE_LOCK_STATUSW->_QUERY_SERVICE_LOCK_STATUSW*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceLockStatusW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceLockStatusW([In] ref SC_HANDLE__ hSCManager, IntPtr lpLockStatus, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpLockStatus: LPQUERY_SERVICE_LOCK_STATUSA->_QUERY_SERVICE_LOCK_STATUSA*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceLockStatusA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceLockStatusA([In] ref SC_HANDLE__ hSCManager, IntPtr lpLockStatus, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///lpServiceConfig: LPQUERY_SERVICE_CONFIGW->_QUERY_SERVICE_CONFIGW*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceConfigW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceConfigW([In] ref SC_HANDLE__ hService, IntPtr lpServiceConfig, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///lpServiceConfig: LPQUERY_SERVICE_CONFIGA->_QUERY_SERVICE_CONFIGA*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceConfigA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceConfigA([In] ref SC_HANDLE__ hService, IntPtr lpServiceConfig, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwInfoLevel: DWORD->unsigned int
        ///lpBuffer: LPBYTE->BYTE*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceConfig2W")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceConfig2W([In] ref SC_HANDLE__ hService, uint dwInfoLevel, IntPtr lpBuffer, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwInfoLevel: DWORD->unsigned int
        ///lpBuffer: LPBYTE->BYTE*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "QueryServiceConfig2A")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryServiceConfig2A([In] ref SC_HANDLE__ hService, uint dwInfoLevel, IntPtr lpBuffer, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///pRecoveryAgents: PENCRYPTION_CERTIFICATE_HASH_LIST*
        [DllImport("advapi32.dll", EntryPoint = "QueryRecoveryAgentsOnEncryptedFile")]
        public static extern uint QueryRecoveryAgentsOnEncryptedFile([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, ref IntPtr pRecoveryAgents);


        /// Return Type: BOOL->int
        ///lpFrequency: LARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "QueryPerformanceFrequency")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceFrequency([Out] out LARGE_INTEGER lpFrequency);


        /// Return Type: BOOL->int
        ///lpPerformanceCount: LARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "QueryPerformanceCounter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceCounter([Out] out LARGE_INTEGER lpPerformanceCount);


        /// Return Type: HRESULT->LONG->int
        ///guid: GUID*
        ///wMaj: USHORT->unsigned short
        ///wMin: USHORT->unsigned short
        ///lcid: LCID->DWORD->unsigned int
        ///lpbstrPathName: LPBSTR->BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "QueryPathOfRegTypeLib", CallingConvention = CallingConvention.StdCall)]
        public static extern int QueryPathOfRegTypeLib(ref GUID guid, ushort wMaj, ushort wMin, uint lcid, [MarshalAs(UnmanagedType.BStr)] ref string lpbstrPathName);


        /// Return Type: BOOL->int
        ///ResourceNotificationHandle: HANDLE->void*
        ///ResourceState: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "QueryMemoryResourceNotification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryMemoryResourceNotification([In] IntPtr ResourceNotificationHandle, [Out] out int ResourceState);


        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///JobObjectInformationClass: JOBOBJECTINFOCLASS->_JOBOBJECTINFOCLASS
        ///lpJobObjectInformation: LPVOID->void*
        ///cbJobObjectInformationLength: DWORD->unsigned int
        ///lpReturnLength: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "QueryInformationJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryInformationJobObject([In] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, IntPtr lpJobObjectInformation, uint cbJobObjectInformationLength, IntPtr lpReturnLength);


        /// Return Type: DWORD->unsigned int
        ///lpDeviceName: LPCWSTR->WCHAR*
        ///lpTargetPath: LPWSTR->WCHAR*
        ///ucchMax: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueryDosDeviceW")]
        public static extern uint QueryDosDeviceW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpTargetPath, uint ucchMax);


        /// Return Type: DWORD->unsigned int
        ///lpDeviceName: LPCSTR->CHAR*
        ///lpTargetPath: LPSTR->CHAR*
        ///ucchMax: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "QueryDosDeviceA")]
        public static extern uint QueryDosDeviceA([In] [MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpTargetPath, uint ucchMax);


        /// Return Type: USHORT->unsigned short
        ///ListHead: PSLIST_HEADER->_SLIST_HEADER*
        [DllImport("kernel32.dll", EntryPoint = "QueryDepthSList")]
        public static extern ushort QueryDepthSList([In] ref SLIST_HEADER ListHead);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///hActCtx: HANDLE->void*
        ///pvSubInstance: PVOID->void*
        ///ulInfoClass: ULONG->unsigned int
        ///pvBuffer: PVOID->void*
        ///cbBuffer: SIZE_T->ULONG_PTR->unsigned int
        ///pcbWrittenOrRequired: SIZE_T*
        [DllImport("kernel32.dll", EntryPoint = "QueryActCtxW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryActCtxW(uint dwFlags, [In] IntPtr hActCtx, [In] IntPtr pvSubInstance, uint ulInfoClass, IntPtr pvBuffer, uint cbBuffer, IntPtr pcbWrittenOrRequired);


        /// Return Type: void
        ///_Base: void*
        ///_NumOfElements: rsize_t->size_t->unsigned int
        ///_SizeOfElements: rsize_t->size_t->unsigned int
        ///_PtFuncCompare: Anonymous_20ceb12c_2155_4424_b974_1f19ad09b67c
        ///_Context: void*
        [DllImport("msvcr80.dll", EntryPoint = "qsort_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern void qsort_s(IntPtr _Base, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _NumOfElements, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeOfElements, Anonymous_20ceb12c_2155_4424_b974_1f19ad09b67c _PtFuncCompare, IntPtr _Context);


        /// Return Type: void
        ///_Base: void*
        ///_NumOfElements: size_t->unsigned int
        ///_SizeOfElements: size_t->unsigned int
        ///_PtFuncCompare: Anonymous_0e3bac4b_012a_4c06_9ff5_73383859a489
        [DllImport("ntdll.dll", EntryPoint = "qsort", CallingConvention = CallingConvention.Cdecl)]
        public static extern void qsort(IntPtr _Base, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _NumOfElements, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeOfElements, Anonymous_0e3bac4b_012a_4c06_9ff5_73383859a489 _PtFuncCompare);

    }

}
