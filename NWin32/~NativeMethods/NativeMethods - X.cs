using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hXcv: HANDLE->void*
        ///pszDataName: PCWSTR->WCHAR*
        ///pInputData: PBYTE->BYTE*
        ///cbInputData: DWORD->unsigned int
        ///pOutputData: PBYTE->BYTE*
        ///cbOutputData: DWORD->unsigned int
        ///pcbOutputNeeded: PDWORD->DWORD*
        ///pdwStatus: PDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "XcvDataW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool XcvDataW([In] IntPtr hXcv, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszDataName, [In] IntPtr pInputData, uint cbInputData, IntPtr pOutputData, uint cbOutputData, [Out] out uint pcbOutputNeeded, [Out] out uint pdwStatus);

    }

}
