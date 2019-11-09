using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: DWORD->unsigned int
    ///keycontext: LPVOID->void*
    ///val_list: PVALCONTEXT->val_context*
    ///num_vals: DWORD->unsigned int
    ///outputbuffer: LPVOID->void*
    ///total_outlen: DWORD*
    ///input_blen: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint QUERYHANDLER(IntPtr keycontext, ref val_context val_list, uint num_vals, IntPtr outputbuffer, ref uint total_outlen, uint input_blen);

    [StructLayout(LayoutKind.Sequential)]
    public struct QUOTA_LIMITS_EX
    {

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint PagedPoolLimit;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint NonPagedPoolLimit;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint MinimumWorkingSetSize;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint MaximumWorkingSetSize;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint PagefileLimit;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER TimeLimit;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint Reserved1;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint Reserved2;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint Reserved3;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint Reserved4;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint Reserved5;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QUOTA_LIMITS
    {

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint PagedPoolLimit;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint NonPagedPoolLimit;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint MinimumWorkingSetSize;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint MaximumWorkingSetSize;

        /// SIZE_T->ULONG_PTR->unsigned int
        public uint PagefileLimit;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER TimeLimit;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QUERY_SERVICE_LOCK_STATUSW
    {

        /// DWORD->unsigned int
        public uint fIsLocked;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpLockOwner;

        /// DWORD->unsigned int
        public uint dwLockDuration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QUERY_SERVICE_LOCK_STATUSA
    {

        /// DWORD->unsigned int
        public uint fIsLocked;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpLockOwner;

        /// DWORD->unsigned int
        public uint dwLockDuration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QUERY_SERVICE_CONFIGW
    {

        /// DWORD->unsigned int
        public uint dwServiceType;

        /// DWORD->unsigned int
        public uint dwStartType;

        /// DWORD->unsigned int
        public uint dwErrorControl;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpBinaryPathName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpLoadOrderGroup;

        /// DWORD->unsigned int
        public uint dwTagId;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDependencies;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpServiceStartName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDisplayName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QUERY_SERVICE_CONFIGA
    {

        /// DWORD->unsigned int
        public uint dwServiceType;

        /// DWORD->unsigned int
        public uint dwStartType;

        /// DWORD->unsigned int
        public uint dwErrorControl;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpBinaryPathName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpLoadOrderGroup;

        /// DWORD->unsigned int
        public uint dwTagId;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDependencies;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpServiceStartName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDisplayName;
    }

    public enum QUERYOPTION
    {

        /// QUERY_EXPIRATION_DATE -> 1
        QUERY_EXPIRATION_DATE = 1,

        /// QUERY_TIME_OF_LAST_CHANGE -> QUERY_EXPIRATION_DATE+1
        QUERY_TIME_OF_LAST_CHANGE = (QUERYOPTION.QUERY_EXPIRATION_DATE + 1),

        /// QUERY_CONTENT_ENCODING -> QUERY_TIME_OF_LAST_CHANGE+1
        QUERY_CONTENT_ENCODING = (QUERYOPTION.QUERY_TIME_OF_LAST_CHANGE + 1),

        /// QUERY_CONTENT_TYPE -> QUERY_CONTENT_ENCODING+1
        QUERY_CONTENT_TYPE = (QUERYOPTION.QUERY_CONTENT_ENCODING + 1),

        /// QUERY_REFRESH -> QUERY_CONTENT_TYPE+1
        QUERY_REFRESH = (QUERYOPTION.QUERY_CONTENT_TYPE + 1),

        /// QUERY_RECOMBINE -> QUERY_REFRESH+1
        QUERY_RECOMBINE = (QUERYOPTION.QUERY_REFRESH + 1),

        /// QUERY_CAN_NAVIGATE -> QUERY_RECOMBINE+1
        QUERY_CAN_NAVIGATE = (QUERYOPTION.QUERY_RECOMBINE + 1),

        /// QUERY_USES_NETWORK -> QUERY_CAN_NAVIGATE+1
        QUERY_USES_NETWORK = (QUERYOPTION.QUERY_CAN_NAVIGATE + 1),

        /// QUERY_IS_CACHED -> QUERY_USES_NETWORK+1
        QUERY_IS_CACHED = (QUERYOPTION.QUERY_USES_NETWORK + 1),

        /// QUERY_IS_INSTALLEDENTRY -> QUERY_IS_CACHED+1
        QUERY_IS_INSTALLEDENTRY = (QUERYOPTION.QUERY_IS_CACHED + 1),

        /// QUERY_IS_CACHED_OR_MAPPED -> QUERY_IS_INSTALLEDENTRY+1
        QUERY_IS_CACHED_OR_MAPPED = (QUERYOPTION.QUERY_IS_INSTALLEDENTRY + 1),

        /// QUERY_USES_CACHE -> QUERY_IS_CACHED_OR_MAPPED+1
        QUERY_USES_CACHE = (QUERYOPTION.QUERY_IS_CACHED_OR_MAPPED + 1),

        /// QUERY_IS_SECURE -> QUERY_USES_CACHE+1
        QUERY_IS_SECURE = (QUERYOPTION.QUERY_USES_CACHE + 1),

        /// QUERY_IS_SAFE -> QUERY_IS_SECURE+1
        QUERY_IS_SAFE = (QUERYOPTION.QUERY_IS_SECURE + 1),
    }

}
