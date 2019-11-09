using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: SHORT->short
        ///ch: WCHAR->wchar_t->unsigned short
        [DllImport("user32.dll", EntryPoint = "VkKeyScanW")]
        public static extern short VkKeyScanW(char ch);


        /// Return Type: SHORT->short
        ///ch: WCHAR->wchar_t->unsigned short
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "VkKeyScanExW")]
        public static extern short VkKeyScanExW(char ch, [In] IntPtr dwhkl);


        /// Return Type: SHORT->short
        ///ch: CHAR->char
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "VkKeyScanExA")]
        public static extern short VkKeyScanExA(byte ch, [In] IntPtr dwhkl);


        /// Return Type: SHORT->short
        ///ch: CHAR->char
        [DllImport("user32.dll", EntryPoint = "VkKeyScanA")]
        public static extern short VkKeyScanA(byte ch);


        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualUnlock([In] IntPtr lpAddress, uint dwSize);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hProcess: HANDLE->void*
        ///lpAddress: LPCVOID->void*
        ///lpBuffer: PMEMORY_BASIC_INFORMATION->_MEMORY_BASIC_INFORMATION*
        ///dwLength: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx")]
        public static extern uint VirtualQueryEx([In] IntPtr hProcess, [In] IntPtr lpAddress, IntPtr lpBuffer, uint dwLength);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///lpAddress: LPCVOID->void*
        ///lpBuffer: PMEMORY_BASIC_INFORMATION->_MEMORY_BASIC_INFORMATION*
        ///dwLength: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualQuery")]
        public static extern uint VirtualQuery([In] IntPtr lpAddress, IntPtr lpBuffer, uint dwLength);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flNewProtect: DWORD->unsigned int
        ///lpflOldProtect: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "VirtualProtectEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualProtectEx([In] IntPtr hProcess, [In] IntPtr lpAddress, uint dwSize, uint flNewProtect, [Out] out uint lpflOldProtect);


        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flNewProtect: DWORD->unsigned int
        ///lpflOldProtect: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualProtect([In] IntPtr lpAddress, uint dwSize, uint flNewProtect, [Out] out uint lpflOldProtect);


        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualLock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualLock([In] IntPtr lpAddress, uint dwSize);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwFreeType: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualFreeEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualFreeEx([In] IntPtr hProcess, [In] IntPtr lpAddress, uint dwSize, uint dwFreeType);


        /// Return Type: BOOL->int
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwFreeType: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualFree")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualFree([In] IntPtr lpAddress, uint dwSize, uint dwFreeType);


        /// Return Type: LPVOID->void*
        ///hProcess: HANDLE->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flAllocationType: DWORD->unsigned int
        ///flProtect: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx")]
        public static extern IntPtr VirtualAllocEx([In] IntPtr hProcess, [In] IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);


        /// Return Type: LPVOID->void*
        ///lpAddress: LPVOID->void*
        ///dwSize: SIZE_T->ULONG_PTR->unsigned int
        ///flAllocationType: DWORD->unsigned int
        ///flProtect: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VirtualAlloc")]
        public static extern IntPtr VirtualAlloc([In] IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);


        /// Return Type: ULONGLONG->unsigned __int64
        ///ConditionMask: ULONGLONG->unsigned __int64
        ///TypeMask: DWORD->unsigned int
        ///Condition: BYTE->unsigned char
        [DllImport("kernel32.dll", EntryPoint = "VerSetConditionMask", CallingConvention = CallingConvention.StdCall)]
        public static extern ulong VerSetConditionMask(ulong ConditionMask, uint TypeMask, byte Condition);


        /// Return Type: BOOL->int
        ///pBlock: LPVOID->void*
        ///lpSubBlock: LPWSTR->WCHAR*
        ///lplpBuffer: LPVOID*
        ///puLen: PUINT->unsigned int*
        [DllImport("<Unknown>", EntryPoint = "VerQueryValueW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerQueryValueW(IntPtr pBlock, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpSubBlock, ref IntPtr lplpBuffer, ref uint puLen);


        /// Return Type: BOOL->int
        ///pBlock: LPVOID->void*
        ///lpSubBlock: LPSTR->CHAR*
        ///lplpBuffer: LPVOID*
        ///puLen: PUINT->unsigned int*
        [DllImport("<Unknown>", EntryPoint = "VerQueryValueA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerQueryValueA(IntPtr pBlock, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpSubBlock, ref IntPtr lplpBuffer, ref uint puLen);


        /// Return Type: DWORD->unsigned int
        ///wLang: DWORD->unsigned int
        ///szLang: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VerLanguageNameW")]
        public static extern uint VerLanguageNameW(uint wLang, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szLang, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///wLang: DWORD->unsigned int
        ///szLang: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "VerLanguageNameA")]
        public static extern uint VerLanguageNameA(uint wLang, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szLang, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///uFlags: DWORD->unsigned int
        ///szSrcFileName: LPWSTR->WCHAR*
        ///szDestFileName: LPWSTR->WCHAR*
        ///szSrcDir: LPWSTR->WCHAR*
        ///szDestDir: LPWSTR->WCHAR*
        ///szCurDir: LPWSTR->WCHAR*
        ///szTmpFile: LPWSTR->WCHAR*
        ///lpuTmpFileLen: PUINT->unsigned int*
        [DllImport("<Unknown>", EntryPoint = "VerInstallFileW")]
        public static extern uint VerInstallFileW(uint uFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szSrcFileName, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szDestFileName, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szSrcDir, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szDestDir, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szCurDir, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szTmpFile, ref uint lpuTmpFileLen);


        /// Return Type: DWORD->unsigned int
        ///uFlags: DWORD->unsigned int
        ///szSrcFileName: LPSTR->CHAR*
        ///szDestFileName: LPSTR->CHAR*
        ///szSrcDir: LPSTR->CHAR*
        ///szDestDir: LPSTR->CHAR*
        ///szCurDir: LPSTR->CHAR*
        ///szTmpFile: LPSTR->CHAR*
        ///lpuTmpFileLen: PUINT->unsigned int*
        [DllImport("<Unknown>", EntryPoint = "VerInstallFileA")]
        public static extern uint VerInstallFileA(uint uFlags, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szSrcFileName, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szDestFileName, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szSrcDir, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szDestDir, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szCurDir, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szTmpFile, ref uint lpuTmpFileLen);


        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOEXW->_OSVERSIONINFOEXW*
        ///dwTypeMask: DWORD->unsigned int
        ///dwlConditionMask: DWORDLONG->ULONGLONG->unsigned __int64
        [DllImport("kernel32.dll", EntryPoint = "VerifyVersionInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerifyVersionInfoW(ref RTL_OSVERSIONINFOEXW lpVersionInformation, uint dwTypeMask, ulong dwlConditionMask);


        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOEXA->_OSVERSIONINFOEXA*
        ///dwTypeMask: DWORD->unsigned int
        ///dwlConditionMask: DWORDLONG->ULONGLONG->unsigned __int64
        [DllImport("kernel32.dll", EntryPoint = "VerifyVersionInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VerifyVersionInfoA(ref OSVERSIONINFOEXA lpVersionInformation, uint dwTypeMask, ulong dwlConditionMask);


        /// Return Type: DWORD->unsigned int
        ///uFlags: DWORD->unsigned int
        ///szFileName: LPWSTR->WCHAR*
        ///szWinDir: LPWSTR->WCHAR*
        ///szAppDir: LPWSTR->WCHAR*
        ///szCurDir: LPWSTR->WCHAR*
        ///lpuCurDirLen: PUINT->unsigned int*
        ///szDestDir: LPWSTR->WCHAR*
        ///lpuDestDirLen: PUINT->unsigned int*
        [DllImport("<Unknown>", EntryPoint = "VerFindFileW")]
        public static extern uint VerFindFileW(uint uFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szFileName, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szWinDir, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szAppDir, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szCurDir, ref uint lpuCurDirLen, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szDestDir, ref uint lpuDestDirLen);


        /// Return Type: DWORD->unsigned int
        ///uFlags: DWORD->unsigned int
        ///szFileName: LPSTR->CHAR*
        ///szWinDir: LPSTR->CHAR*
        ///szAppDir: LPSTR->CHAR*
        ///szCurDir: LPSTR->CHAR*
        ///lpuCurDirLen: PUINT->unsigned int*
        ///szDestDir: LPSTR->CHAR*
        ///lpuDestDirLen: PUINT->unsigned int*
        [DllImport("<Unknown>", EntryPoint = "VerFindFileA")]
        public static extern uint VerFindFileA(uint uFlags, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szFileName, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szWinDir, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szAppDir, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szCurDir, ref uint lpuCurDirLen, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szDestDir, ref uint lpuDestDirLen);


        /// Return Type: HRESULT->LONG->int
        ///bstr: BSTR->OLECHAR*
        ///ppsa: SAFEARRAY**
        [DllImport("oleaut32.dll", EntryPoint = "VectorFromBstr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VectorFromBstr([MarshalAs(UnmanagedType.BStr)] string bstr, ref IntPtr ppsa);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarXor", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarXor(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///iWeekday: int
        ///fAbbrev: int
        ///iFirstDay: int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarWeekdayName", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarWeekdayName(int iWeekday, int fAbbrev, int iFirstDay, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromUI4(uint ulIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromUI2(ushort uiIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromUI1(byte bIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: unsigned int
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromR8(double dblIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromR4(float fltIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///intIn: INT->int
        ///pi64Out: ULONG64*
        [DllImport("<Unknown>", EntryPoint = "VarUI8FromInt", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromInt(int intIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: LONG64->__int64
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromI8(long ui64In, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pi64Out: ULONG64*
        [DllImport("<Unknown>", EntryPoint = "VarUI8FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromI4(int lIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromI2(short sIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromI1(byte cIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromDisp(ref IDispatch pdispIn, uint lcid, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromDec(ref decimal pdecIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromDate(double dateIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pi64Out: ULONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI8FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI8FromBool(short boolIn, ref ulong pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///plOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromUI8(ulong ui64In, ref uint plOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromUI2(ushort uiIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromUI1(byte bIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromR8(double dblIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromR4(float fltIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///plOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromI8(long i64In, ref uint plOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromI4(int lIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: SHORT->short
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromI2(short uiIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromI1(byte cIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromDisp(ref IDispatch pdispIn, uint lcid, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromDec(ref decimal pdecIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromDate(double dateIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pulOut: ULONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI4FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI4FromBool(short boolIn, ref uint pulOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: ULONG64->unsigned __int64
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromUI8(ulong i64In, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromUI4(uint ulIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromUI1(byte bIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromR8(double dblIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromR4(float fltIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromI8(long i64In, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromI4(int lIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: SHORT->short
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromI2(short uiIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromI1(byte cIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromDisp(ref IDispatch pdispIn, uint lcid, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromDec(ref decimal pdecIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromDate(double dateIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///puiOut: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI2FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI2FromBool(short boolIn, ref ushort puiOut);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromUI8(ulong ui64In, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromUI4(uint ulIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromUI2(ushort uiIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromR8(double dblIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromR4(float fltIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromI8(long i64In, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromI4(int lIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromI2(short sIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromI1(byte cIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromDisp(ref IDispatch pdispIn, uint lcid, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromDec(ref decimal pdecIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromDate(double dateIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pbOut: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUI1FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUI1FromBool(short boolIn, ref byte pbOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///dwFlags: ULONG->unsigned int
        ///pudateOut: UDATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarUdateFromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarUdateFromDate(double dateIn, uint dwFlags, ref UDATE pudateOut);


        /// Return Type: HRESULT->LONG->int
        ///pstrFormat: LPOLESTR->OLECHAR*
        ///rgbTok: LPBYTE->BYTE*
        ///cbTok: int
        ///iFirstDay: int
        ///iFirstWeek: int
        ///lcid: LCID->DWORD->unsigned int
        ///pcbActual: int*
        [DllImport("oleaut32.dll", EntryPoint = "VarTokenizeFormatString", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarTokenizeFormatString(IntPtr pstrFormat, ref byte rgbTok, int cbTok, int iFirstDay, int iFirstWeek, uint lcid, ref int pcbActual);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarSub", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarSub(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///cDecimals: int
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarRound", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarRound(ref tagVARIANT pvarIn, int cDecimals, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: double
        ///cDecimals: int
        ///pdblResult: double*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8Round", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8Round(double dblIn, int cDecimals, ref double pdblResult);


        /// Return Type: HRESULT->LONG->int
        ///dblLeft: double
        ///dblRight: double
        ///pdblResult: double*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8Pow", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8Pow(double dblLeft, double dblRight, ref double pdblResult);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromUI8(ulong ui64In, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromUI4(uint ulIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromUI2(ushort uiIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromUI1(byte bIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromR4(float fltIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromI8(long i64In, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromI4(int lIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromI2(short sIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromI1(byte cIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromDisp(ref IDispatch pdispIn, uint lcid, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromDec(ref decimal pdecIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromDate(double dateIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pdblOut: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "VarR8FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR8FromBool(short boolIn, ref double pdblOut);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromUI8(ulong ui64In, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromUI4(uint ulIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromUI2(ushort uiIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromUI1(byte bIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromR8(double dblIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromI8(long i64In, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromI4(int lIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromI2(short sIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromI1(byte cIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromDisp(ref IDispatch pdispIn, uint lcid, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromDec(ref decimal pdecIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromDate(double dateIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pfltOut: FLOAT*
        [DllImport("oleaut32.dll", EntryPoint = "VarR4FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4FromBool(short boolIn, ref float pfltOut);


        /// Return Type: HRESULT->LONG->int
        ///fltLeft: float
        ///dblRight: double
        [DllImport("oleaut32.dll", EntryPoint = "VarR4CmpR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarR4CmpR8(float fltLeft, double dblRight);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarPow", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarPow(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pnumprs: NUMPARSE*
        ///rgbDig: BYTE*
        [DllImport("oleaut32.dll", EntryPoint = "VarParseNumFromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarParseNumFromStr(IntPtr strIn, uint lcid, uint dwFlags, ref NUMPARSE pnumprs, ref byte rgbDig);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarOr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarOr(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pnumprs: NUMPARSE*
        ///rgbDig: BYTE*
        ///dwVtBits: ULONG->unsigned int
        ///pvar: VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarNumFromParseNum", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarNumFromParseNum(ref NUMPARSE pnumprs, ref byte rgbDig, uint dwVtBits, ref tagVARIANT pvar);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarNot", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarNot(ref tagVARIANT pvarIn, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarNeg", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarNeg(ref tagVARIANT pvarIn, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarMul", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarMul(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///iMonth: int
        ///fAbbrev: int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarMonthName", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarMonthName(int iMonth, int fAbbrev, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarMod", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarMod(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarInt", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarInt(ref tagVARIANT pvarIn, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarImp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarImp(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarIdiv", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarIdiv(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VARIANT_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr VARIANT_UserUnmarshal(ref uint param0, IntPtr param1, ref tagVARIANT param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VARIANT_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint VARIANT_UserSize(ref uint param0, uint param1, ref tagVARIANT param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VARIANT_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr VARIANT_UserMarshal(ref uint param0, IntPtr param1, ref tagVARIANT param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VARIANT_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void VARIANT_UserFree(ref uint param0, ref tagVARIANT param1);


        /// Return Type: INT->int
        ///vtime: DOUBLE->double
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("oleaut32.dll", EntryPoint = "VariantTimeToSystemTime", CallingConvention = CallingConvention.StdCall)]
        public static extern int VariantTimeToSystemTime(double vtime, ref SYSTEMTIME lpSystemTime);


        /// Return Type: INT->int
        ///vtime: DOUBLE->double
        ///pwDosDate: USHORT*
        ///pwDosTime: USHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VariantTimeToDosDateTime", CallingConvention = CallingConvention.StdCall)]
        public static extern int VariantTimeToDosDateTime(double vtime, ref ushort pwDosDate, ref ushort pwDosTime);


        /// Return Type: void
        ///pvarg: VARIANTARG*
        [DllImport("oleaut32.dll", EntryPoint = "VariantInit", CallingConvention = CallingConvention.StdCall)]
        public static extern void VariantInit(ref tagVARIANT pvarg);


        /// Return Type: HRESULT->LONG->int
        ///pvarDest: VARIANT*
        ///pvargSrc: VARIANTARG*
        [DllImport("oleaut32.dll", EntryPoint = "VariantCopyInd", CallingConvention = CallingConvention.StdCall)]
        public static extern int VariantCopyInd(ref tagVARIANT pvarDest, ref tagVARIANT pvargSrc);


        /// Return Type: HRESULT->LONG->int
        ///pvargDest: VARIANTARG*
        ///pvargSrc: VARIANTARG*
        [DllImport("oleaut32.dll", EntryPoint = "VariantCopy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VariantCopy(ref tagVARIANT pvargDest, ref tagVARIANT pvargSrc);


        /// Return Type: HRESULT->LONG->int
        ///pvarg: VARIANTARG*
        [DllImport("oleaut32.dll", EntryPoint = "VariantClear", CallingConvention = CallingConvention.StdCall)]
        public static extern int VariantClear(ref tagVARIANT pvarg);


        /// Return Type: HRESULT->LONG->int
        ///pvargDest: VARIANTARG*
        ///pvarSrc: VARIANTARG*
        ///lcid: LCID->DWORD->unsigned int
        ///wFlags: USHORT->unsigned short
        ///vt: VARTYPE->unsigned short
        [DllImport("oleaut32.dll", EntryPoint = "VariantChangeTypeEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int VariantChangeTypeEx(ref tagVARIANT pvargDest, ref tagVARIANT pvarSrc, uint lcid, ushort wFlags, ushort vt);


        /// Return Type: HRESULT->LONG->int
        ///pvargDest: VARIANTARG*
        ///pvarSrc: VARIANTARG*
        ///wFlags: USHORT->unsigned short
        ///vt: VARTYPE->unsigned short
        [DllImport("oleaut32.dll", EntryPoint = "VariantChangeType", CallingConvention = CallingConvention.StdCall)]
        public static extern int VariantChangeType(ref tagVARIANT pvargDest, ref tagVARIANT pvarSrc, ushort wFlags, ushort vt);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromUI8(ulong ui64In, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromUI4(uint ulIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromUI2(ushort uiIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromUI1(byte bIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: unsigned int
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromR8(double dblIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromR4(float fltIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///intIn: INT->int
        ///pi64Out: LONG64*
        [DllImport("<Unknown>", EntryPoint = "VarI8FromInt", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromInt(int intIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pi64Out: LONG64*
        [DllImport("<Unknown>", EntryPoint = "VarI8FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromI4(int lIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromI2(short sIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromI1(byte cIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromDisp(ref IDispatch pdispIn, uint lcid, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromDec(ref decimal pdecIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromDate(double dateIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pi64Out: LONG64*
        [DllImport("oleaut32.dll", EntryPoint = "VarI8FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI8FromBool(short boolIn, ref long pi64Out);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromUI8(ulong ui64In, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromUI4(uint ulIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromUI2(ushort uiIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromUI1(byte bIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromR8(double dblIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromR4(float fltIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///intIn: INT->int
        ///plOut: LONG*
        [DllImport("<Unknown>", EntryPoint = "VarI4FromInt", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromInt(int intIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromI8(long i64In, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromI2(short sIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromI1(byte cIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromDisp(ref IDispatch pdispIn, uint lcid, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromDec(ref decimal pdecIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromDate(double dateIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///plOut: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "VarI4FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI4FromBool(short boolIn, ref int plOut);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromUI8(ulong ui64In, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromUI4(uint ulIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromUI2(ushort uiIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromUI1(byte bIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromStr(IntPtr strIn, uint lcid, uint dwFlags, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromR8(double dblIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromR4(float fltIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromI8(long i64In, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromI4(int lIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromI1(byte cIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromDisp(ref IDispatch pdispIn, uint lcid, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromDec(ref decimal pdecIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromDate(double dateIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///psOut: SHORT*
        [DllImport("oleaut32.dll", EntryPoint = "VarI2FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI2FromBool(short boolIn, ref short psOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: ULONG64->unsigned __int64
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromUI8(ulong i64In, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromUI4(uint ulIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromUI2(ushort uiIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromUI1(byte bIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromStr([In] [MarshalAs(UnmanagedType.LPWStr)] string strIn, uint lcid, uint dwFlags, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromR8(double dblIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromR4(float fltIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromI8(long i64In, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromI4(int lIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: SHORT->short
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromI2(short uiIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromDisp([In] ref IDispatch pdispIn, uint lcid, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromDec([In] ref decimal pdecIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromDate(double dateIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pcOut: CHAR*
        [DllImport("oleaut32.dll", EntryPoint = "VarI1FromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarI1FromBool(short boolIn, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pcOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///iNumDig: int
        ///iIncLead: int
        ///iUseParens: int
        ///iGroup: int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarFormatPercent", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarFormatPercent(ref tagVARIANT pvarIn, int iNumDig, int iIncLead, int iUseParens, int iGroup, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///iNumDig: int
        ///iIncLead: int
        ///iUseParens: int
        ///iGroup: int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarFormatNumber", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarFormatNumber(ref tagVARIANT pvarIn, int iNumDig, int iIncLead, int iUseParens, int iGroup, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///pstrFormat: LPOLESTR->OLECHAR*
        ///pbTokCur: LPBYTE->BYTE*
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        ///lcid: LCID->DWORD->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "VarFormatFromTokens", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarFormatFromTokens(ref tagVARIANT pvarIn, IntPtr pstrFormat, ref byte pbTokCur, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut, uint lcid);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///iNamedFormat: int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarFormatDateTime", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarFormatDateTime(ref tagVARIANT pvarIn, int iNamedFormat, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///iNumDig: int
        ///iIncLead: int
        ///iUseParens: int
        ///iGroup: int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarFormatCurrency", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarFormatCurrency(ref tagVARIANT pvarIn, int iNumDig, int iIncLead, int iUseParens, int iGroup, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///pstrFormat: LPOLESTR->OLECHAR*
        ///iFirstDay: int
        ///iFirstWeek: int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarFormat", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarFormat(ref tagVARIANT pvarIn, IntPtr pstrFormat, int iFirstDay, int iFirstWeek, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarFix", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarFix(ref tagVARIANT pvarIn, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarEqv", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarEqv(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarDiv", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDiv(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecLeft: LPDECIMAL->DECIMAL*
        ///pdecRight: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecSub", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecSub(ref decimal pdecLeft, ref decimal pdecRight, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: LPDECIMAL->DECIMAL*
        ///cDecimals: int
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecRound", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecRound(ref decimal pdecIn, int cDecimals, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecNeg", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecNeg(ref decimal pdecIn, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecLeft: LPDECIMAL->DECIMAL*
        ///pdecRight: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecMul", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecMul(ref decimal pdecLeft, ref decimal pdecRight, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecInt", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecInt(ref decimal pdecIn, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromUI8(ulong ui64In, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromUI4(uint ulIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromUI2(ushort uiIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromUI1(byte bIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromStr(IntPtr strIn, uint lcid, uint dwFlags, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromR8(double dblIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromR4(float fltIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromI8(long i64In, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromI4(int lIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: SHORT->short
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromI2(short uiIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromI1(byte cIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromDisp(ref IDispatch pdispIn, uint lcid, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromDate(double dateIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pdecOut: DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFromBool(short boolIn, ref decimal pdecOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecFix", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecFix(ref decimal pdecIn, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecLeft: LPDECIMAL->DECIMAL*
        ///pdecRight: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecDiv", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecDiv(ref decimal pdecLeft, ref decimal pdecRight, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecLeft: LPDECIMAL->DECIMAL*
        ///dblRight: double
        [DllImport("oleaut32.dll", EntryPoint = "VarDecCmpR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecCmpR8(ref decimal pdecLeft, double dblRight);


        /// Return Type: HRESULT->LONG->int
        ///pdecLeft: LPDECIMAL->DECIMAL*
        ///pdecRight: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecCmp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecCmp(ref decimal pdecLeft, ref decimal pdecRight);


        /// Return Type: HRESULT->LONG->int
        ///pdecLeft: LPDECIMAL->DECIMAL*
        ///pdecRight: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecAdd", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecAdd(ref decimal pdecLeft, ref decimal pdecRight, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: LPDECIMAL->DECIMAL*
        ///pdecResult: LPDECIMAL->DECIMAL*
        [DllImport("oleaut32.dll", EntryPoint = "VarDecAbs", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDecAbs(ref decimal pdecIn, ref decimal pdecResult);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromUI8(ulong ui64In, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromUI4(uint ulIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromUI2(ushort uiIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromUI1(byte bIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///pudateIn: UDATE*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromUdateEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromUdateEx(ref UDATE pudateIn, uint lcid, uint dwFlags, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///pudateIn: UDATE*
        ///dwFlags: ULONG->unsigned int
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromUdate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromUdate(ref UDATE pudateIn, uint dwFlags, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromStr(IntPtr strIn, uint lcid, uint dwFlags, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromR8(double dblIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromR4(float fltIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromI8(long i64In, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromI4(int lIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromI2(short sIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromI1(byte cIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromDisp(ref IDispatch pdispIn, uint lcid, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromDec(ref decimal pdecIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pdateOut: DATE*
        [DllImport("oleaut32.dll", EntryPoint = "VarDateFromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarDateFromBool(short boolIn, ref double pdateOut);


        /// Return Type: HRESULT->LONG->int
        ///cyLeft: CY->tagCY
        ///cyRight: CY->tagCY
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCySub", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCySub([MarshalAs(UnmanagedType.Currency)] decimal cyLeft, [MarshalAs(UnmanagedType.Currency)] decimal cyRight, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///cDecimals: int
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyRound", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyRound([MarshalAs(UnmanagedType.Currency)] decimal cyIn, int cDecimals, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyNeg", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyNeg([MarshalAs(UnmanagedType.Currency)] decimal cyIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyLeft: CY->tagCY
        ///lRight: LONG64->__int64
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyMulI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyMulI8([MarshalAs(UnmanagedType.Currency)] decimal cyLeft, long lRight, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyLeft: CY->tagCY
        ///lRight: int
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyMulI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyMulI4([MarshalAs(UnmanagedType.Currency)] decimal cyLeft, int lRight, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyLeft: CY->tagCY
        ///cyRight: CY->tagCY
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyMul", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyMul([MarshalAs(UnmanagedType.Currency)] decimal cyLeft, [MarshalAs(UnmanagedType.Currency)] decimal cyRight, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyInt", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyInt([MarshalAs(UnmanagedType.Currency)] decimal cyIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromUI8(ulong ui64In, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromUI4(uint ulIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromUI2(ushort uiIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromUI1(byte bIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromStr(IntPtr strIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromR8(double dblIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromR4(float fltIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromI8(long i64In, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromI4(int lIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromI2(short sIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromI1(byte cIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromDisp(ref IDispatch pdispIn, uint lcid, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromDec(ref decimal pdecIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromDate(double dateIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///pcyOut: CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFromBool(short boolIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyFix", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyFix([MarshalAs(UnmanagedType.Currency)] decimal cyIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyLeft: CY->tagCY
        ///dblRight: double
        [DllImport("oleaut32.dll", EntryPoint = "VarCyCmpR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyCmpR8([MarshalAs(UnmanagedType.Currency)] decimal cyLeft, double dblRight);


        /// Return Type: HRESULT->LONG->int
        ///cyLeft: CY->tagCY
        ///cyRight: CY->tagCY
        [DllImport("oleaut32.dll", EntryPoint = "VarCyCmp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyCmp([MarshalAs(UnmanagedType.Currency)] decimal cyLeft, [MarshalAs(UnmanagedType.Currency)] decimal cyRight);


        /// Return Type: HRESULT->LONG->int
        ///cyLeft: CY->tagCY
        ///cyRight: CY->tagCY
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyAdd", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyAdd([MarshalAs(UnmanagedType.Currency)] decimal cyLeft, [MarshalAs(UnmanagedType.Currency)] decimal cyRight, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pcyResult: LPCY->CY*
        [DllImport("oleaut32.dll", EntryPoint = "VarCyAbs", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCyAbs([MarshalAs(UnmanagedType.Currency)] decimal cyIn, [MarshalAs(UnmanagedType.Currency)] ref decimal pcyResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "VarCmp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCmp(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, uint lcid, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarCat", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarCat(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///ui64In: ULONG64->unsigned __int64
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromUI8(ulong ui64In, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromUI4(uint ulIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromUI2(ushort uiIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///bVal: BYTE->unsigned char
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromUI1(byte bVal, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromR8(double dblIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromR4(float fltIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromI8(long i64In, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromI4(int lIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///iVal: SHORT->short
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromI2(short iVal, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromI1(byte cIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromDisp(ref IDispatch pdispIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromDec(ref decimal pdecIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromDate(double dateIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///boolIn: VARIANT_BOOL->short
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pbstrOut: BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrFromBool", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrFromBool(short boolIn, uint lcid, uint dwFlags, [MarshalAs(UnmanagedType.BStr)] ref string pbstrOut);


        /// Return Type: HRESULT->LONG->int
        ///bstrLeft: BSTR->OLECHAR*
        ///bstrRight: BSTR->OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrCmp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrCmp([MarshalAs(UnmanagedType.BStr)] string bstrLeft, [MarshalAs(UnmanagedType.BStr)] string bstrRight, uint lcid, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///bstrLeft: BSTR->OLECHAR*
        ///bstrRight: BSTR->OLECHAR*
        ///pbstrResult: LPBSTR->BSTR*
        [DllImport("oleaut32.dll", EntryPoint = "VarBstrCat", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBstrCat([MarshalAs(UnmanagedType.BStr)] string bstrLeft, [MarshalAs(UnmanagedType.BStr)] string bstrRight, [MarshalAs(UnmanagedType.BStr)] ref string pbstrResult);


        /// Return Type: HRESULT->LONG->int
        ///i64In: ULONG64->unsigned __int64
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromUI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromUI8(ulong i64In, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///ulIn: ULONG->unsigned int
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromUI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromUI4(uint ulIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///uiIn: USHORT->unsigned short
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromUI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromUI2(ushort uiIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///bIn: BYTE->unsigned char
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromUI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromUI1(byte bIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///strIn: OLECHAR*
        ///lcid: LCID->DWORD->unsigned int
        ///dwFlags: ULONG->unsigned int
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromStr", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromStr(IntPtr strIn, uint lcid, uint dwFlags, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///dblIn: DOUBLE->double
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromR8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromR8(double dblIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///fltIn: FLOAT->float
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromR4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromR4(float fltIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///i64In: LONG64->__int64
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromI8", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromI8(long i64In, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///lIn: LONG->int
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromI4", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromI4(int lIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///sIn: SHORT->short
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromI2", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromI2(short sIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///cIn: CHAR->char
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromI1", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromI1(byte cIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///pdispIn: IDispatch*
        ///lcid: LCID->DWORD->unsigned int
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromDisp", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromDisp(ref IDispatch pdispIn, uint lcid, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///pdecIn: DECIMAL*
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromDec", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromDec(ref decimal pdecIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///dateIn: DATE->double
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromDate", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromDate(double dateIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///cyIn: CY->tagCY
        ///pboolOut: VARIANT_BOOL*
        [DllImport("oleaut32.dll", EntryPoint = "VarBoolFromCy", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarBoolFromCy([MarshalAs(UnmanagedType.Currency)] decimal cyIn, ref short pboolOut);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarAnd", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarAnd(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarLeft: LPVARIANT->VARIANT*
        ///pvarRight: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarAdd", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarAdd(ref tagVARIANT pvarLeft, ref tagVARIANT pvarRight, ref tagVARIANT pvarResult);


        /// Return Type: HRESULT->LONG->int
        ///pvarIn: LPVARIANT->VARIANT*
        ///pvarResult: LPVARIANT->VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "VarAbs", CallingConvention = CallingConvention.StdCall)]
        public static extern int VarAbs(ref tagVARIANT pvarIn, ref tagVARIANT pvarResult);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        [DllImport("user32.dll", EntryPoint = "ValidateRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRgn([In] IntPtr hWnd, [In] IntPtr hRgn);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: RECT*
        [DllImport("user32.dll", EntryPoint = "ValidateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRect([In] IntPtr hWnd, [In] IntPtr lpRect);

    }

}
