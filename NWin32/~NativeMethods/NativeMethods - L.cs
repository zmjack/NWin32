using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;
using FILETIME = NWin32.NativeTypes.FILETIME;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZStart")]
        public static extern int LZStart();


        /// Return Type: LONG->int
        ///param0: INT->int
        ///param1: LONG->int
        ///param2: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZSeek")]
        public static extern int LZSeek(int param0, int param1, int param2);


        /// Return Type: INT->int
        ///param0: INT->int
        ///param1: LPSTR->CHAR*
        ///param2: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZRead")]
        public static extern int LZRead(int param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, int param2);


        /// Return Type: INT->int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPOFSTRUCT->_OFSTRUCT*
        ///param2: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "LZOpenFileW")]
        public static extern int LZOpenFileW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, ref OFSTRUCT param1, ushort param2);


        /// Return Type: INT->int
        ///param0: LPSTR->CHAR*
        ///param1: LPOFSTRUCT->_OFSTRUCT*
        ///param2: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "LZOpenFileA")]
        public static extern int LZOpenFileA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, ref OFSTRUCT param1, ushort param2);


        /// Return Type: INT->int
        ///param0: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZInit")]
        public static extern int LZInit(int param0);


        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "LZDone")]
        public static extern void LZDone();


        /// Return Type: LONG->int
        ///param0: INT->int
        ///param1: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZCopy")]
        public static extern int LZCopy(int param0, int param1);


        /// Return Type: void
        ///param0: INT->int
        [DllImport("kernel32.dll", EntryPoint = "LZClose")]
        public static extern void LZClose(int param0);


        /// Return Type: int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrlenW")]
        public static extern int lstrlenW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: int
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrlenA")]
        public static extern int lstrlenA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcpyW")]
        public static extern IntPtr lstrcpyW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);


        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        ///iMaxLength: int
        [DllImport("kernel32.dll", EntryPoint = "lstrcpynW")]
        public static extern IntPtr lstrcpynW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int iMaxLength);


        /// Return Type: LPSTR->CHAR*
        ///lpString1: LPSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        ///iMaxLength: int
        [DllImport("kernel32.dll", EntryPoint = "lstrcpynA")]
        public static extern IntPtr lstrcpynA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2, int iMaxLength);


        /// Return Type: LPSTR->CHAR*
        ///lpString1: LPSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcpyA")]
        public static extern IntPtr lstrcpyA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);


        /// Return Type: int
        ///lpString1: LPCWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpW")]
        public static extern int lstrcmpW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);


        /// Return Type: int
        ///lpString1: LPCWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpiW")]
        public static extern int lstrcmpiW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);


        /// Return Type: int
        ///lpString1: LPCSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpiA")]
        public static extern int lstrcmpiA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);


        /// Return Type: int
        ///lpString1: LPCSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcmpA")]
        public static extern int lstrcmpA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);


        /// Return Type: LPWSTR->WCHAR*
        ///lpString1: LPWSTR->WCHAR*
        ///lpString2: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcatW")]
        public static extern IntPtr lstrcatW(IntPtr lpString1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2);


        /// Return Type: LPSTR->CHAR*
        ///lpString1: LPSTR->CHAR*
        ///lpString2: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "lstrcatA")]
        public static extern IntPtr lstrcatA(IntPtr lpString1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        ///c: int
        [DllImport("gdi32.dll", EntryPoint = "LPtoDP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LPtoDP([In] IntPtr hdc, IntPtr lppt, int c);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: LPSAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "LPSAFEARRAY_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LPSAFEARRAY_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: LPSAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "LPSAFEARRAY_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint LPSAFEARRAY_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: LPSAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "LPSAFEARRAY_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LPSAFEARRAY_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: LPSAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "LPSAFEARRAY_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void LPSAFEARRAY_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///lpLuid: PLUID->_LUID*
        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeValueW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeValueW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpSystemName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [Out] out LUID lpLuid);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///lpLuid: PLUID->_LUID*
        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeValueA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeValueA([In] [MarshalAs(UnmanagedType.LPStr)] string lpSystemName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [Out] out LUID lpLuid);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCWSTR->WCHAR*
        ///lpLuid: PLUID->_LUID*
        ///lpName: LPWSTR->WCHAR*
        ///cchName: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpSystemName, [In] ref LUID lpLuid, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpName, ref uint cchName);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCSTR->CHAR*
        ///lpLuid: PLUID->_LUID*
        ///lpName: LPSTR->CHAR*
        ///cchName: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpSystemName, [In] ref LUID lpLuid, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpName, ref uint cchName);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCWSTR->WCHAR*
        ///lpName: LPCWSTR->WCHAR*
        ///lpDisplayName: LPWSTR->WCHAR*
        ///cchDisplayName: LPDWORD->DWORD*
        ///lpLanguageId: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeDisplayNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeDisplayNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpSystemName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpDisplayName, ref uint cchDisplayName, [Out] out uint lpLanguageId);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCSTR->CHAR*
        ///lpName: LPCSTR->CHAR*
        ///lpDisplayName: LPSTR->CHAR*
        ///cchDisplayName: LPDWORD->DWORD*
        ///lpLanguageId: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeDisplayNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeDisplayNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpSystemName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpDisplayName, ref uint cchDisplayName, [Out] out uint lpLanguageId);


        /// Return Type: int
        ///presbits: PBYTE->BYTE*
        ///fIcon: BOOL->int
        ///cxDesired: int
        ///cyDesired: int
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectoryEx")]
        public static extern int LookupIconIdFromDirectoryEx([In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon, int cxDesired, int cyDesired, uint Flags);


        /// Return Type: int
        ///presbits: PBYTE->BYTE*
        ///fIcon: BOOL->int
        [DllImport("user32.dll", EntryPoint = "LookupIconIdFromDirectory")]
        public static extern int LookupIconIdFromDirectory([In] ref byte presbits, [MarshalAs(UnmanagedType.Bool)] bool fIcon);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCWSTR->WCHAR*
        ///Sid: PSID->PVOID->void*
        ///Name: LPWSTR->WCHAR*
        ///cchName: LPDWORD->DWORD*
        ///ReferencedDomainName: LPWSTR->WCHAR*
        ///cchReferencedDomainName: LPDWORD->DWORD*
        ///peUse: PSID_NAME_USE->_SID_NAME_USE*
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountSidW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupAccountSidW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpSystemName, [In] IntPtr Sid, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder Name, ref uint cchName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ReferencedDomainName, ref uint cchReferencedDomainName, [Out] out SID_NAME_USE peUse);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCSTR->CHAR*
        ///Sid: PSID->PVOID->void*
        ///Name: LPSTR->CHAR*
        ///cchName: LPDWORD->DWORD*
        ///ReferencedDomainName: LPSTR->CHAR*
        ///cchReferencedDomainName: LPDWORD->DWORD*
        ///peUse: PSID_NAME_USE->_SID_NAME_USE*
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountSidA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupAccountSidA([In] [MarshalAs(UnmanagedType.LPStr)] string lpSystemName, [In] IntPtr Sid, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder Name, ref uint cchName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ReferencedDomainName, ref uint cchReferencedDomainName, [Out] out SID_NAME_USE peUse);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCWSTR->WCHAR*
        ///lpAccountName: LPCWSTR->WCHAR*
        ///Sid: PSID->PVOID->void*
        ///cbSid: LPDWORD->DWORD*
        ///ReferencedDomainName: LPWSTR->WCHAR*
        ///cchReferencedDomainName: LPDWORD->DWORD*
        ///peUse: PSID_NAME_USE->_SID_NAME_USE*
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupAccountNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpSystemName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpAccountName, IntPtr Sid, ref uint cbSid, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ReferencedDomainName, ref uint cchReferencedDomainName, [Out] out SID_NAME_USE peUse);


        /// Return Type: BOOL->int
        ///lpSystemName: LPCSTR->CHAR*
        ///lpAccountName: LPCSTR->CHAR*
        ///Sid: PSID->PVOID->void*
        ///cbSid: LPDWORD->DWORD*
        ///ReferencedDomainName: LPSTR->CHAR*
        ///cchReferencedDomainName: LPDWORD->DWORD*
        ///peUse: PSID_NAME_USE->_SID_NAME_USE*
        [DllImport("advapi32.dll", EntryPoint = "LookupAccountNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupAccountNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpSystemName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpAccountName, IntPtr Sid, ref uint cbSid, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ReferencedDomainName, ref uint cchReferencedDomainName, [Out] out SID_NAME_USE peUse);


        /// Return Type: BOOL->int
        ///lpszUsername: LPCWSTR->WCHAR*
        ///lpszDomain: LPCWSTR->WCHAR*
        ///lpszPassword: LPCWSTR->WCHAR*
        ///dwLogonType: DWORD->unsigned int
        ///dwLogonProvider: DWORD->unsigned int
        ///phToken: PHANDLE->HANDLE*
        [DllImport("advapi32.dll", EntryPoint = "LogonUserW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LogonUserW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszUsername, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDomain, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszPassword, uint dwLogonType, uint dwLogonProvider, out IntPtr phToken);


        /// Return Type: BOOL->int
        ///lpszUsername: LPCWSTR->WCHAR*
        ///lpszDomain: LPCWSTR->WCHAR*
        ///lpszPassword: LPCWSTR->WCHAR*
        ///dwLogonType: DWORD->unsigned int
        ///dwLogonProvider: DWORD->unsigned int
        ///phToken: PHANDLE->HANDLE*
        ///ppLogonSid: PSID*
        ///ppProfileBuffer: PVOID*
        ///pdwProfileLength: LPDWORD->DWORD*
        ///pQuotaLimits: PQUOTA_LIMITS->_QUOTA_LIMITS*
        [DllImport("advapi32.dll", EntryPoint = "LogonUserExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LogonUserExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszUsername, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDomain, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszPassword, uint dwLogonType, uint dwLogonProvider, ref IntPtr phToken, ref IntPtr ppLogonSid, ref IntPtr ppProfileBuffer, IntPtr pdwProfileLength, IntPtr pQuotaLimits);


        /// Return Type: BOOL->int
        ///lpszUsername: LPCSTR->CHAR*
        ///lpszDomain: LPCSTR->CHAR*
        ///lpszPassword: LPCSTR->CHAR*
        ///dwLogonType: DWORD->unsigned int
        ///dwLogonProvider: DWORD->unsigned int
        ///phToken: PHANDLE->HANDLE*
        ///ppLogonSid: PSID*
        ///ppProfileBuffer: PVOID*
        ///pdwProfileLength: LPDWORD->DWORD*
        ///pQuotaLimits: PQUOTA_LIMITS->_QUOTA_LIMITS*
        [DllImport("advapi32.dll", EntryPoint = "LogonUserExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LogonUserExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszUsername, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDomain, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszPassword, uint dwLogonType, uint dwLogonProvider, ref IntPtr phToken, ref IntPtr ppLogonSid, ref IntPtr ppProfileBuffer, IntPtr pdwProfileLength, IntPtr pQuotaLimits);


        /// Return Type: BOOL->int
        ///lpszUsername: LPCSTR->CHAR*
        ///lpszDomain: LPCSTR->CHAR*
        ///lpszPassword: LPCSTR->CHAR*
        ///dwLogonType: DWORD->unsigned int
        ///dwLogonProvider: DWORD->unsigned int
        ///phToken: PHANDLE->HANDLE*
        [DllImport("advapi32.dll", EntryPoint = "LogonUserA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LogonUserA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszUsername, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDomain, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszPassword, uint dwLogonType, uint dwLogonProvider, out IntPtr phToken);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "LockWorkStation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockWorkStation();


        /// Return Type: BOOL->int
        ///hWndLock: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "LockWindowUpdate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockWindowUpdate([In] IntPtr hWndLock);


        /// Return Type: BOOL->int
        ///uLockCode: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LockSetForegroundWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockSetForegroundWindow(uint uLockCode);


        /// Return Type: SC_LOCK->LPVOID->void*
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        [DllImport("advapi32.dll", EntryPoint = "LockServiceDatabase")]
        public static extern IntPtr LockServiceDatabase([In] ref SC_HANDLE__ hSCManager);


        /// Return Type: LPVOID->void*
        ///hResData: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LockResource")]
        public static extern IntPtr LockResource([In] IntPtr hResData);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        ///nNumberOfBytesToLockLow: DWORD->unsigned int
        ///nNumberOfBytesToLockHigh: DWORD->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "LockFileEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockFileEx([In] IntPtr hFile, uint dwFlags, uint dwReserved, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh, ref OVERLAPPED lpOverlapped);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///nNumberOfBytesToLockLow: DWORD->unsigned int
        ///nNumberOfBytesToLockHigh: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LockFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockFile([In] IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh);


        /// Return Type: BOOL->int
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LocalUnlock([In] IntPtr hMem);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalSize")]
        public static extern uint LocalSize([In] IntPtr hMem);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hMem: HLOCAL->HANDLE->void*
        ///cbNewSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalShrink")]
        public static extern uint LocalShrink([In] IntPtr hMem, uint cbNewSize);


        /// Return Type: HLOCAL->HANDLE->void*
        ///hMem: HLOCAL->HANDLE->void*
        ///uBytes: SIZE_T->ULONG_PTR->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalReAlloc")]
        public static extern IntPtr LocalReAlloc([In] IntPtr hMem, uint uBytes, uint uFlags);


        /// Return Type: LPVOID->void*
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalLock")]
        public static extern IntPtr LocalLock([In] IntPtr hMem);


        /// Return Type: HLOCAL->HANDLE->void*
        ///pMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalHandle")]
        public static extern IntPtr LocalHandle([In] IntPtr pMem);


        /// Return Type: HLOCAL->HANDLE->void*
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalFree")]
        public static extern IntPtr LocalFree(IntPtr hMem);


        /// Return Type: UINT->unsigned int
        ///hMem: HLOCAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "LocalFlags")]
        public static extern uint LocalFlags([In] IntPtr hMem);


        /// Return Type: BOOL->int
        ///lpLocalFileTime: FILETIME*
        ///lpFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "LocalFileTimeToFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LocalFileTimeToFileTime([In] ref FILETIME lpLocalFileTime, [Out] out FILETIME lpFileTime);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///uMinFree: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalCompact")]
        public static extern uint LocalCompact(uint uMinFree);


        /// Return Type: HLOCAL->HANDLE->void*
        ///uFlags: UINT->unsigned int
        ///uBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LocalAlloc")]
        public static extern IntPtr LocalAlloc(uint uFlags, uint uBytes);


        /// Return Type: HRESULT->LONG->int
        ///szFile: LPCOLESTR->OLECHAR*
        ///regkind: REGKIND->tagREGKIND
        ///pptlib: ITypeLib**
        [DllImport("oleaut32.dll", EntryPoint = "LoadTypeLibEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int LoadTypeLibEx([In] [MarshalAs(UnmanagedType.LPWStr)] string szFile, tagREGKIND regkind, ref IntPtr pptlib);


        /// Return Type: HRESULT->LONG->int
        ///szFile: OLECHAR*
        ///pptlib: ITypeLib**
        [DllImport("oleaut32.dll", EntryPoint = "LoadTypeLib", CallingConvention = CallingConvention.StdCall)]
        public static extern int LoadTypeLib([In] [MarshalAs(UnmanagedType.LPWStr)] string szFile, ref IntPtr pptlib);


        /// Return Type: int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///uID: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///cchBufferMax: int
        [DllImport("user32.dll", EntryPoint = "LoadStringW")]
        public static extern int LoadStringW([In] IntPtr hInstance, uint uID, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, int cchBufferMax);


        /// Return Type: int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///uID: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///cchBufferMax: int
        [DllImport("user32.dll", EntryPoint = "LoadStringA")]
        public static extern int LoadStringA([In] IntPtr hInstance, uint uID, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, int cchBufferMax);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///hResInfo: HRSRC->HRSRC__*
        [DllImport("kernel32.dll", EntryPoint = "LoadResource")]
        public static extern IntPtr LoadResource([In] IntPtr hModule, [In] IntPtr hResInfo);


        /// Return Type: HRESULT->LONG->int
        ///rguid: GUID*
        ///wVerMajor: WORD->unsigned short
        ///wVerMinor: WORD->unsigned short
        ///lcid: LCID->DWORD->unsigned int
        ///pptlib: ITypeLib**
        [DllImport("oleaut32.dll", EntryPoint = "LoadRegTypeLib", CallingConvention = CallingConvention.StdCall)]
        public static extern int LoadRegTypeLib(ref GUID rguid, ushort wVerMajor, ushort wVerMinor, uint lcid, ref IntPtr pptlib);


        /// Return Type: DWORD->unsigned int
        ///lpModuleName: LPCSTR->CHAR*
        ///lpParameterBlock: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "LoadModule")]
        public static extern uint LoadModule([In] [MarshalAs(UnmanagedType.LPStr)] string lpModuleName, [In] IntPtr lpParameterBlock);


        /// Return Type: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpMenuName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadMenuW")]
        public static extern IntPtr LoadMenuW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpMenuName);


        /// Return Type: HMENU->HMENU__*
        ///lpMenuTemplate: MENUTEMPLATEW*
        [DllImport("user32.dll", EntryPoint = "LoadMenuIndirectW")]
        public static extern IntPtr LoadMenuIndirectW([In] IntPtr lpMenuTemplate);


        /// Return Type: HMENU->HMENU__*
        ///lpMenuTemplate: MENUTEMPLATEA*
        [DllImport("user32.dll", EntryPoint = "LoadMenuIndirectA")]
        public static extern IntPtr LoadMenuIndirectA([In] IntPtr lpMenuTemplate);


        /// Return Type: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpMenuName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadMenuA")]
        public static extern IntPtr LoadMenuA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMenuName);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryW")]
        public static extern IntPtr LoadLibraryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCWSTR->WCHAR*
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExW")]
        public static extern IntPtr LoadLibraryExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpLibFileName, IntPtr hFile, uint dwFlags);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCSTR->CHAR*
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExA")]
        public static extern IntPtr LoadLibraryExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpLibFileName, IntPtr hFile, uint dwFlags);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpLibFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryA")]
        public static extern IntPtr LoadLibraryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);


        /// Return Type: HKL->HKL__*
        ///pwszKLID: LPCWSTR->WCHAR*
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadKeyboardLayoutW")]
        public static extern IntPtr LoadKeyboardLayoutW([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszKLID, uint Flags);


        /// Return Type: HKL->HKL__*
        ///pwszKLID: LPCSTR->CHAR*
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadKeyboardLayoutA")]
        public static extern IntPtr LoadKeyboardLayoutA([In] [MarshalAs(UnmanagedType.LPStr)] string pwszKLID, uint Flags);


        /// Return Type: HANDLE->void*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///name: LPCWSTR->WCHAR*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///fuLoad: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadImageW")]
        public static extern IntPtr LoadImageW([In] IntPtr hInst, [In] [MarshalAs(UnmanagedType.LPWStr)] string name, uint type, int cx, int cy, uint fuLoad);


        /// Return Type: HANDLE->void*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///name: LPCSTR->CHAR*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///fuLoad: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "LoadImageA")]
        public static extern IntPtr LoadImageA([In] IntPtr hInst, [In] [MarshalAs(UnmanagedType.LPStr)] string name, uint type, int cx, int cy, uint fuLoad);


        /// Return Type: HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpIconName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadIconW")]
        public static extern IntPtr LoadIconW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpIconName);


        /// Return Type: HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpIconName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadIconA")]
        public static extern IntPtr LoadIconA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpIconName);


        /// Return Type: HCURSOR->HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpCursorName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorW")]
        public static extern IntPtr LoadCursorW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCursorName);


        /// Return Type: HCURSOR->HICON->HICON__*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorFromFileW")]
        public static extern IntPtr LoadCursorFromFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: HCURSOR->HICON->HICON__*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorFromFileA")]
        public static extern IntPtr LoadCursorFromFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: HCURSOR->HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpCursorName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadCursorA")]
        public static extern IntPtr LoadCursorA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCursorName);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpBitmapName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadBitmapW")]
        public static extern IntPtr LoadBitmapW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpBitmapName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadBitmapA")]
        public static extern IntPtr LoadBitmapA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBitmapName);


        /// Return Type: HACCEL->HACCEL__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTableName: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "LoadAcceleratorsW")]
        public static extern IntPtr LoadAcceleratorsW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTableName);


        /// Return Type: HACCEL->HACCEL__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTableName: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "LoadAcceleratorsA")]
        public static extern IntPtr LoadAcceleratorsA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTableName);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///backlog: int
        [DllImport("ws2_32.dll", EntryPoint = "listen", CallingConvention = CallingConvention.StdCall)]
        public static extern int listen([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, int backlog);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImport("gdi32.dll", EntryPoint = "LineTo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LineTo([In] IntPtr hdc, int x, int y);


        /// Return Type: BOOL->int
        ///xStart: int
        ///yStart: int
        ///xEnd: int
        ///yEnd: int
        ///lpProc: LINEDDAPROC
        ///data: LPARAM->LONG_PTR->int
        [DllImport("gdi32.dll", EntryPoint = "LineDDA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LineDDA(int xStart, int yStart, int xEnd, int yEnd, LINEDDAPROC lpProc, [MarshalAs(UnmanagedType.SysInt)] IntPtr data);


        /// Return Type: ULONG->unsigned int
        ///syskind: SYSKIND->tagSYSKIND
        ///lcid: LCID->DWORD->unsigned int
        ///szName: LPCSTR->CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "LHashValOfNameSysA", CallingConvention = CallingConvention.StdCall)]
        public static extern uint LHashValOfNameSysA(tagSYSKIND syskind, uint lcid, [In] [MarshalAs(UnmanagedType.LPStr)] string szName);


        /// Return Type: ULONG->unsigned int
        ///syskind: SYSKIND->tagSYSKIND
        ///lcid: LCID->DWORD->unsigned int
        ///szName: OLECHAR*
        [DllImport("oleaut32.dll", EntryPoint = "LHashValOfNameSys", CallingConvention = CallingConvention.StdCall)]
        public static extern uint LHashValOfNameSys(tagSYSKIND syskind, uint lcid, [In] [MarshalAs(UnmanagedType.LPWStr)] string szName);


        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "LeaveCriticalSection")]
        public static extern void LeaveCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);


        /// Return Type: ldiv_t->_ldiv_t
        ///_Numerator: int
        ///_Denominator: int
        [DllImport("msvcr80.dll", EntryPoint = "ldiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern ldiv_t ldiv(int _Numerator, int _Denominator);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpDestStr: LPWSTR->WCHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "LCMapStringW")]
        public static extern int LCMapStringW(uint Locale, uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpDestStr, int cchDest);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwMapFlags: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpDestStr: LPSTR->CHAR*
        ///cchDest: int
        [DllImport("kernel32.dll", EntryPoint = "LCMapStringA")]
        public static extern int LCMapStringA(uint Locale, uint dwMapFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpDestStr, int cchDest);


        /// Return Type: int
        ///_X: int
        [DllImport("ntdll.dll", EntryPoint = "labs", CallingConvention = CallingConvention.Cdecl)]
        public static extern int labs(int _X);

    }

}
