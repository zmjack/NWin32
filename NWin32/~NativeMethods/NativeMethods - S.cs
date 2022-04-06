using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;
using FILETIME = NWin32.NativeTypes.FILETIME;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: INT->int
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        ///pvtime: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "SystemTimeToVariantTime", CallingConvention = CallingConvention.StdCall)]
        public static extern int SystemTimeToVariantTime(ref SYSTEMTIME lpSystemTime, ref double pvtime);


        /// Return Type: BOOL->int
        ///lpTimeZoneInformation: LPTIME_ZONE_INFORMATION->_TIME_ZONE_INFORMATION*
        ///lpUniversalTime: LPSYSTEMTIME->_SYSTEMTIME*
        ///lpLocalTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "SystemTimeToTzSpecificLocalTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemTimeToTzSpecificLocalTime([In] IntPtr lpTimeZoneInformation, [In] ref SYSTEMTIME lpUniversalTime, [Out] out SYSTEMTIME lpLocalTime);


        /// Return Type: BOOL->int
        ///lpSystemTime: SYSTEMTIME*
        ///lpFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "SystemTimeToFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemTimeToFileTime([In] ref SYSTEMTIME lpSystemTime, [Out] out FILETIME lpFileTime);


        /// Return Type: BOOL->int
        ///uiAction: UINT->unsigned int
        ///uiParam: UINT->unsigned int
        ///pvParam: PVOID->void*
        ///fWinIni: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);


        /// Return Type: BOOL->int
        ///uiAction: UINT->unsigned int
        ///uiParam: UINT->unsigned int
        ///pvParam: PVOID->void*
        ///fWinIni: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoA(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);


        /// Return Type: int
        ///_Command: char*
        [DllImport("msvcr80.dll", EntryPoint = "system", CallingConvention = CallingConvention.Cdecl)]
        public static extern int system([In] [MarshalAs(UnmanagedType.LPStr)] string _Command);


        /// Return Type: UINT->unsigned int
        ///param0: BSTR->OLECHAR*
        [DllImport("oleaut32.dll", EntryPoint = "SysStringLen", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SysStringLen([MarshalAs(UnmanagedType.BStr)] string param0);


        /// Return Type: UINT->unsigned int
        ///bstr: BSTR->OLECHAR*
        [DllImport("oleaut32.dll", EntryPoint = "SysStringByteLen", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SysStringByteLen([MarshalAs(UnmanagedType.BStr)] string bstr);


        /// Return Type: INT->int
        ///param0: BSTR*
        ///param1: OLECHAR*
        ///param2: UINT->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "SysReAllocStringLen", CallingConvention = CallingConvention.StdCall)]
        public static extern int SysReAllocStringLen([MarshalAs(UnmanagedType.BStr)] ref string param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, uint param2);


        /// Return Type: INT->int
        ///param0: BSTR*
        ///param1: OLECHAR*
        [DllImport("oleaut32.dll", EntryPoint = "SysReAllocString", CallingConvention = CallingConvention.StdCall)]
        public static extern int SysReAllocString([MarshalAs(UnmanagedType.BStr)] ref string param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1);


        /// Return Type: void
        ///param0: BSTR->OLECHAR*
        [DllImport("oleaut32.dll", EntryPoint = "SysFreeString", CallingConvention = CallingConvention.StdCall)]
        public static extern void SysFreeString([MarshalAs(UnmanagedType.BStr)] string param0);


        /// Return Type: BSTR->OLECHAR*
        ///param0: OLECHAR*
        ///param1: UINT->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "SysAllocStringLen", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string SysAllocStringLen([In] [MarshalAs(UnmanagedType.LPWStr)] string param0, uint param1);


        /// Return Type: BSTR->OLECHAR*
        ///psz: LPCSTR->CHAR*
        ///len: UINT->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "SysAllocStringByteLen", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string SysAllocStringByteLen([In] [MarshalAs(UnmanagedType.LPStr)] string psz, uint len);


        /// Return Type: BSTR->OLECHAR*
        ///param0: OLECHAR*
        [DllImport("oleaut32.dll", EntryPoint = "SysAllocString", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string SysAllocString([In] [MarshalAs(UnmanagedType.LPWStr)] string param0);


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SwitchToThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwitchToThread();


        /// Return Type: void
        ///hwnd: HWND->HWND__*
        ///fUnknown: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SwitchToThisWindow")]
        public static extern void SwitchToThisWindow([In] IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fUnknown);


        /// Return Type: void
        ///lpFiber: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "SwitchToFiber")]
        public static extern void SwitchToFiber([In] IntPtr lpFiber);


        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        [DllImport("user32.dll", EntryPoint = "SwitchDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwitchDesktop([In] IntPtr hDesktop);


        /// Return Type: BOOL->int
        ///fSwap: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SwapMouseButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwapMouseButton([MarshalAs(UnmanagedType.Bool)] bool fSwap);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "SwapBuffers")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwapBuffers(IntPtr param0);


        /// Return Type: DWORD->unsigned int
        ///hThread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SuspendThread")]
        public static extern uint SuspendThread([In] IntPtr hThread);


        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc1: RECT*
        ///lprcSrc2: RECT*
        [DllImport("user32.dll", EntryPoint = "SubtractRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SubtractRect([Out] out tagRECT lprcDst, [In] ref tagRECT lprcSrc1, [In] ref tagRECT lprcSrc2);


        /// Return Type: size_t->unsigned int
        ///_Dst: char*
        ///_Src: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "strxfrm", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint strxfrm([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dst, [In] [MarshalAs(UnmanagedType.LPStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: unsigned int
        ///_Str: char*
        ///_EndPtr: char**
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "strtoul", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint strtoul([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, ref IntPtr _EndPtr, int _Radix);


        /// Return Type: int
        ///_Str: char*
        ///_EndPtr: char**
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "strtol", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strtol([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, ref IntPtr _EndPtr, int _Radix);


        /// Return Type: char*
        ///_Str: char*
        ///_Delim: char*
        ///_Context: char**
        [DllImport("msvcr80.dll", EntryPoint = "strtok_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strtok_s(IntPtr _Str, [In] [MarshalAs(UnmanagedType.LPStr)] string _Delim, ref IntPtr _Context);


        /// Return Type: char*
        ///_Str: char*
        ///_Delim: char*
        [DllImport("msvcr80.dll", EntryPoint = "strtok", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strtok(IntPtr _Str, [In] [MarshalAs(UnmanagedType.LPStr)] string _Delim);


        /// Return Type: double
        ///_Str: char*
        ///_EndPtr: char**
        [DllImport("msvcr80.dll", EntryPoint = "strtod", CallingConvention = CallingConvention.Cdecl)]
        public static extern double strtod([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, ref IntPtr _EndPtr);


        /// Return Type: char*
        ///_Str: char*
        ///_SubStr: char*
        [DllImport("ntdll.dll", EntryPoint = "strstr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strstr([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPStr)] string _SubStr);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        ///_Control: char*
        [DllImport("ntdll.dll", EntryPoint = "strspn", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint strspn([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPStr)] string _Control);


        /// Return Type: char*
        ///_Str: char*
        ///_Ch: int
        [DllImport("ntdll.dll", EntryPoint = "strrchr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strrchr([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, int _Ch);


        /// Return Type: char*
        ///_Str: char*
        ///_Control: char*
        [DllImport("ntdll.dll", EntryPoint = "strpbrk", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strpbrk([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPStr)] string _Control);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "StrokePath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StrokePath([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "StrokeAndFillPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StrokeAndFillPath([In] IntPtr hdc);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "strnlen", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint strnlen([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: errno_t->int
        ///_Dst: char*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: char*
        ///_MaxCount: rsize_t->size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "strncpy_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strncpy_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: char*
        ///_Dest: char*
        ///_Source: char*
        ///_Count: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "strncpy", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strncpy([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dest, [In] [MarshalAs(UnmanagedType.LPStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "strncmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strncmp([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: errno_t->int
        ///_Dst: char*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: char*
        ///_MaxCount: rsize_t->size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "strncat_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strncat_s([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: char*
        ///_Dest: char*
        ///_Source: char*
        ///_Count: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "strncat", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strncat([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dest, [In] [MarshalAs(UnmanagedType.LPStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        [DllImport("ntdll.dll", EntryPoint = "strlen", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint strlen([In] [MarshalAs(UnmanagedType.LPStr)] string _Str);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///lplpsz: LPOLESTR*
        [DllImport("ole32.dll", EntryPoint = "StringFromIID", CallingConvention = CallingConvention.StdCall)]
        public static extern int StringFromIID(ref GUID rclsid, ref IntPtr lplpsz);


        /// Return Type: int
        ///rguid: GUID*
        ///lpsz: LPOLESTR->OLECHAR*
        ///cchMax: int
        [DllImport("ole32.dll", EntryPoint = "StringFromGUID2", CallingConvention = CallingConvention.StdCall)]
        public static extern int StringFromGUID2(ref GUID rguid, IntPtr lpsz, int cchMax);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///lplpsz: LPOLESTR*
        [DllImport("ole32.dll", EntryPoint = "StringFromCLSID", CallingConvention = CallingConvention.StdCall)]
        public static extern int StringFromCLSID(ref GUID rclsid, ref IntPtr lplpsz);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///DestWidth: int
        ///DestHeight: int
        ///xSrc: int
        ///ySrc: int
        ///SrcWidth: int
        ///SrcHeight: int
        ///lpBits: void*
        ///lpbmi: BITMAPINFO*
        ///iUsage: UINT->unsigned int
        ///rop: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "StretchDIBits")]
        public static extern int StretchDIBits([In] IntPtr hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [In] IntPtr lpBits, [In] ref tagBITMAPINFO lpbmi, uint iUsage, uint rop);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///wDest: int
        ///hDest: int
        ///hdcSrc: HDC->HDC__*
        ///xSrc: int
        ///ySrc: int
        ///wSrc: int
        ///hSrc: int
        ///rop: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "StretchBlt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StretchBlt([In] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, [In] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, uint rop);


        /// Return Type: errno_t->int
        ///_Buf: char*
        ///_SizeInBytes: size_t->unsigned int
        ///_ErrNum: int
        [DllImport("msvcr80.dll", EntryPoint = "strerror_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strerror_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Buf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInBytes, int _ErrNum);


        /// Return Type: char*
        ///param0: int
        [DllImport("msvcr80.dll", EntryPoint = "strerror", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strerror(int param0);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        ///_Control: char*
        [DllImport("ntdll.dll", EntryPoint = "strcspn", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint strcspn([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] [MarshalAs(UnmanagedType.LPStr)] string _Control);


        /// Return Type: errno_t->int
        ///_Dst: char*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: char*
        [DllImport("msvcr80.dll", EntryPoint = "strcpy_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strcpy_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPStr)] string _Src);


        /// Return Type: char*
        ///_Dest: char*
        ///_Source: char*
        [DllImport("ntdll.dll", EntryPoint = "strcpy", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strcpy(IntPtr _Dest, [In] [MarshalAs(UnmanagedType.LPStr)] string _Source);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        [DllImport("msvcr80.dll", EntryPoint = "strcoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strcoll([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        [DllImport("ntdll.dll", EntryPoint = "strcmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strcmp([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2);


        /// Return Type: char*
        ///_Str: char*
        ///_Val: int
        [DllImport("ntdll.dll", EntryPoint = "strchr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strchr([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, int _Val);


        /// Return Type: errno_t->int
        ///_Dst: char*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: char*
        [DllImport("msvcr80.dll", EntryPoint = "strcat_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int strcat_s([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPStr)] string _Src);


        /// Return Type: char*
        ///_Dest: char*
        ///_Source: char*
        [DllImport("ntdll.dll", EntryPoint = "strcat", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr strcat(IntPtr _Dest, [In] [MarshalAs(UnmanagedType.LPStr)] string _Source);


        /// Return Type: HRESULT->LONG->int
        ///lpszName: OLECHAR*
        ///pctime: FILETIME*
        ///patime: FILETIME*
        ///pmtime: FILETIME*
        [DllImport("ole32.dll", EntryPoint = "StgSetTimes", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgSetTimes(IntPtr lpszName, ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime);


        /// Return Type: HRESULT->LONG->int
        ///plkbyt: ILockBytes*
        ///pstgPriority: IStorage*
        ///grfMode: DWORD->unsigned int
        ///snbExclude: SNB->OLECHAR**
        ///reserved: DWORD->unsigned int
        ///ppstgOpen: IStorage**
        [DllImport("ole32.dll", EntryPoint = "StgOpenStorageOnILockBytes", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgOpenStorageOnILockBytes(ref ILockBytes plkbyt, ref IStorage pstgPriority, uint grfMode, ref IntPtr snbExclude, uint reserved, ref IntPtr ppstgOpen);


        /// Return Type: HRESULT->LONG->int
        ///pwcsName: WCHAR*
        ///grfMode: DWORD->unsigned int
        ///stgfmt: DWORD->unsigned int
        ///grfAttrs: DWORD->unsigned int
        ///pStgOptions: STGOPTIONS*
        ///reserved: void*
        ///riid: IID*
        ///ppObjectOpen: void**
        [DllImport("ole32.dll", EntryPoint = "StgOpenStorageEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgOpenStorageEx([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref tagSTGOPTIONS pStgOptions, IntPtr reserved, ref GUID riid, ref IntPtr ppObjectOpen);


        /// Return Type: HRESULT->LONG->int
        ///pwcsName: OLECHAR*
        ///pstgPriority: IStorage*
        ///grfMode: DWORD->unsigned int
        ///snbExclude: SNB->OLECHAR**
        ///reserved: DWORD->unsigned int
        ///ppstgOpen: IStorage**
        [DllImport("ole32.dll", EntryPoint = "StgOpenStorage", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgOpenStorage([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, ref IStorage pstgPriority, uint grfMode, ref IntPtr snbExclude, uint reserved, ref IntPtr ppstgOpen);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        ///fmtid: IID*
        ///grfFlags: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        ///ppPropStg: IPropertyStorage**
        [DllImport("ole32.dll", EntryPoint = "StgOpenPropStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgOpenPropStg(ref IUnknown pUnk, ref GUID fmtid, uint grfFlags, uint dwReserved, ref IntPtr ppPropStg);


        /// Return Type: HRESULT->LONG->int
        ///pwcsDfName: OLECHAR*
        ///grfMode: DWORD->unsigned int
        ///reserved: DWORD->unsigned int
        ///ppstgOpen: IStorage**
        [DllImport("<Unknown>", EntryPoint = "StgOpenLayoutDocfile", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgOpenLayoutDocfile(IntPtr pwcsDfName, uint grfMode, uint reserved, ref IntPtr ppstgOpen);


        /// Return Type: HRESULT->LONG->int
        ///pflb: IFillLockBytes*
        ///grfMode: DWORD->unsigned int
        ///asyncFlags: DWORD->unsigned int
        ///ppstgOpen: IStorage**
        [DllImport("ole32.dll", EntryPoint = "StgOpenAsyncDocfileOnIFillLockBytes", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgOpenAsyncDocfileOnIFillLockBytes(ref IFillLockBytes pflb, uint grfMode, uint asyncFlags, ref IntPtr ppstgOpen);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: STGMEDIUM*
        [DllImport("ole32.dll", EntryPoint = "STGMEDIUM_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr STGMEDIUM_UserUnmarshal(ref uint param0, IntPtr param1, ref tagSTGMEDIUM param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: STGMEDIUM*
        [DllImport("ole32.dll", EntryPoint = "STGMEDIUM_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint STGMEDIUM_UserSize(ref uint param0, uint param1, ref tagSTGMEDIUM param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: STGMEDIUM*
        [DllImport("ole32.dll", EntryPoint = "STGMEDIUM_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr STGMEDIUM_UserMarshal(ref uint param0, IntPtr param1, ref tagSTGMEDIUM param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: STGMEDIUM*
        [DllImport("ole32.dll", EntryPoint = "STGMEDIUM_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void STGMEDIUM_UserFree(ref uint param0, ref tagSTGMEDIUM param1);


        /// Return Type: HRESULT->LONG->int
        ///plkbyt: ILockBytes*
        [DllImport("ole32.dll", EntryPoint = "StgIsStorageILockBytes", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgIsStorageILockBytes(ref ILockBytes plkbyt);


        /// Return Type: HRESULT->LONG->int
        ///pwcsName: OLECHAR*
        [DllImport("ole32.dll", EntryPoint = "StgIsStorageFile", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgIsStorageFile([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName);


        /// Return Type: HRESULT->LONG->int
        ///pilb: ILockBytes*
        ///ppflb: IFillLockBytes**
        [DllImport("ole32.dll", EntryPoint = "StgGetIFillLockBytesOnILockBytes", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgGetIFillLockBytesOnILockBytes(ref ILockBytes pilb, ref IntPtr ppflb);


        /// Return Type: HRESULT->LONG->int
        ///pwcsName: OLECHAR*
        ///ppflb: IFillLockBytes**
        [DllImport("ole32.dll", EntryPoint = "StgGetIFillLockBytesOnFile", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgGetIFillLockBytesOnFile(IntPtr pwcsName, ref IntPtr ppflb);


        /// Return Type: HRESULT->LONG->int
        ///pwcsName: WCHAR*
        ///grfMode: DWORD->unsigned int
        ///stgfmt: DWORD->unsigned int
        ///grfAttrs: DWORD->unsigned int
        ///pStgOptions: STGOPTIONS*
        ///reserved: void*
        ///riid: IID*
        ///ppObjectOpen: void**
        [DllImport("ole32.dll", EntryPoint = "StgCreateStorageEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgCreateStorageEx([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint stgfmt, uint grfAttrs, ref tagSTGOPTIONS pStgOptions, IntPtr reserved, ref GUID riid, ref IntPtr ppObjectOpen);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        ///fmtid: IID*
        ///pclsid: CLSID*
        ///grfFlags: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        ///ppPropStg: IPropertyStorage**
        [DllImport("ole32.dll", EntryPoint = "StgCreatePropStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgCreatePropStg(ref IUnknown pUnk, ref GUID fmtid, ref GUID pclsid, uint grfFlags, uint dwReserved, ref IntPtr ppPropStg);


        /// Return Type: HRESULT->LONG->int
        ///pStorage: IStorage*
        ///dwReserved: DWORD->unsigned int
        ///ppPropSetStg: IPropertySetStorage**
        [DllImport("ole32.dll", EntryPoint = "StgCreatePropSetStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgCreatePropSetStg(ref IStorage pStorage, uint dwReserved, ref IntPtr ppPropSetStg);


        /// Return Type: HRESULT->LONG->int
        ///plkbyt: ILockBytes*
        ///grfMode: DWORD->unsigned int
        ///reserved: DWORD->unsigned int
        ///ppstgOpen: IStorage**
        [DllImport("ole32.dll", EntryPoint = "StgCreateDocfileOnILockBytes", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgCreateDocfileOnILockBytes(ref ILockBytes plkbyt, uint grfMode, uint reserved, ref IntPtr ppstgOpen);


        /// Return Type: HRESULT->LONG->int
        ///pwcsName: OLECHAR*
        ///grfMode: DWORD->unsigned int
        ///reserved: DWORD->unsigned int
        ///ppstgOpen: IStorage**
        [DllImport("ole32.dll", EntryPoint = "StgCreateDocfile", CallingConvention = CallingConvention.StdCall)]
        public static extern int StgCreateDocfile([In] [MarshalAs(UnmanagedType.LPWStr)] string pwcsName, uint grfMode, uint reserved, ref IntPtr ppstgOpen);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwNumServiceArgs: DWORD->unsigned int
        ///lpServiceArgVectors: LPCWSTR*
        [DllImport("advapi32.dll", EntryPoint = "StartServiceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StartServiceW([In] ref SC_HANDLE__ hService, uint dwNumServiceArgs, ref IntPtr lpServiceArgVectors);


        /// Return Type: BOOL->int
        ///lpServiceStartTable: SERVICE_TABLE_ENTRYW*
        [DllImport("advapi32.dll", EntryPoint = "StartServiceCtrlDispatcherW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StartServiceCtrlDispatcherW([In] ref SERVICE_TABLE_ENTRYW lpServiceStartTable);


        /// Return Type: BOOL->int
        ///lpServiceStartTable: SERVICE_TABLE_ENTRYA*
        [DllImport("advapi32.dll", EntryPoint = "StartServiceCtrlDispatcherA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StartServiceCtrlDispatcherA([In] ref SERVICE_TABLE_ENTRYA lpServiceStartTable);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwNumServiceArgs: DWORD->unsigned int
        ///lpServiceArgVectors: LPCSTR*
        [DllImport("advapi32.dll", EntryPoint = "StartServiceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StartServiceA([In] ref SC_HANDLE__ hService, uint dwNumServiceArgs, ref IntPtr lpServiceArgVectors);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "StartPagePrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StartPagePrinter([In] IntPtr hPrinter);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "StartPage")]
        public static extern int StartPage([In] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpdi: DOCINFOW*
        [DllImport("gdi32.dll", EntryPoint = "StartDocW")]
        public static extern int StartDocW([In] IntPtr hdc, [In] ref DOCINFOW lpdi);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pDocInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "StartDocPrinterW")]
        public static extern uint StartDocPrinterW([In] IntPtr hPrinter, uint Level, [In] ref byte pDocInfo);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pDocInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "StartDocPrinterA")]
        public static extern uint StartDocPrinterA([In] IntPtr hPrinter, uint Level, [In] ref byte pDocInfo);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpdi: DOCINFOA*
        [DllImport("gdi32.dll", EntryPoint = "StartDocA")]
        public static extern int StartDocA([In] IntPtr hdc, [In] ref DOCINFOA lpdi);


        /// Return Type: void
        ///_Seed: unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "srand", CallingConvention = CallingConvention.Cdecl)]
        public static extern void srand(uint _Seed);


        /// Return Type: SOCKET->UINT_PTR->unsigned int
        ///af: int
        ///type: int
        ///protocol: int
        [DllImport("ws2_32.dll", EntryPoint = "socket", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint socket(int af, int type, int protocol);


        /// Return Type: BOOL->int
        ///pszSound: LPCWSTR->WCHAR*
        ///fuSound: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "sndPlaySoundW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool sndPlaySoundW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszSound, uint fuSound);


        /// Return Type: BOOL->int
        ///pszSound: LPCSTR->CHAR*
        ///fuSound: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "sndPlaySoundA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool sndPlaySoundA([In] [MarshalAs(UnmanagedType.LPStr)] string pszSound, uint fuSound);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: SNB*
        [DllImport("ole32.dll", EntryPoint = "SNB_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SNB_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: SNB*
        [DllImport("ole32.dll", EntryPoint = "SNB_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SNB_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: SNB*
        [DllImport("ole32.dll", EntryPoint = "SNB_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SNB_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: SNB*
        [DllImport("ole32.dll", EntryPoint = "SNB_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void SNB_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: DWORD->unsigned int
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SleepEx")]
        public static extern uint SleepEx(uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);


        /// Return Type: void
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "Sleep")]
        public static extern void Sleep(uint dwMilliseconds);


        /// Return Type: DWORD->unsigned int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///hResInfo: HRSRC->HRSRC__*
        [DllImport("kernel32.dll", EntryPoint = "SizeofResource")]
        public static extern uint SizeofResource([In] IntPtr hModule, [In] IntPtr hResInfo);


        /// Return Type: DWORD->unsigned int
        ///hObjectToSignal: HANDLE->void*
        ///hObjectToWaitOn: HANDLE->void*
        ///dwMilliseconds: DWORD->unsigned int
        ///bAlertable: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SignalObjectAndWait")]
        public static extern uint SignalObjectAndWait([In] IntPtr hObjectToSignal, [In] IntPtr hObjectToWaitOn, uint dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool bAlertable);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///how: int
        [DllImport("ws2_32.dll", EntryPoint = "shutdown", CallingConvention = CallingConvention.StdCall)]
        public static extern int shutdown([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, int how);


        /// Return Type: HRESULT->LONG->int
        ///pszPath: LPWSTR->WCHAR*
        ///pszResModule: LPCWSTR->WCHAR*
        ///idsRes: int
        [DllImport("shell32.dll", EntryPoint = "SHSetLocalizedName", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHSetLocalizedName([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszPath, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszResModule, int idsRes);


        /// Return Type: HRESULT->LONG->int
        ///pszRootPath: LPCWSTR->WCHAR*
        ///pSHQueryRBInfo: LPSHQUERYRBINFO->_SHQUERYRBINFO*
        [DllImport("shell32.dll", EntryPoint = "SHQueryRecycleBinW", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHQueryRecycleBinW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszRootPath, ref SHQUERYRBINFO pSHQueryRBInfo);


        /// Return Type: HRESULT->LONG->int
        ///pszRootPath: LPCSTR->CHAR*
        ///pSHQueryRBInfo: LPSHQUERYRBINFO->_SHQUERYRBINFO*
        [DllImport("shell32.dll", EntryPoint = "SHQueryRecycleBinA", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHQueryRecycleBinA([In] [MarshalAs(UnmanagedType.LPStr)] string pszRootPath, ref SHQUERYRBINFO pSHQueryRBInfo);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nCmdShow: int
        [DllImport("user32.dll", EntryPoint = "ShowWindowAsync")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindowAsync([In] IntPtr hWnd, int nCmdShow);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nCmdShow: int
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow([In] IntPtr hWnd, int nCmdShow);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///wBar: int
        ///bShow: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ShowScrollBar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowScrollBar([In] IntPtr hWnd, int wBar, [MarshalAs(UnmanagedType.Bool)] bool bShow);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///fShow: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ShowOwnedPopups")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowOwnedPopups([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool fShow);


        /// Return Type: int
        ///bShow: BOOL->int
        [DllImport("user32.dll", EntryPoint = "ShowCursor")]
        public static extern int ShowCursor([MarshalAs(UnmanagedType.Bool)] bool bShow);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ShowCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowCaret([In] IntPtr hWnd);


        /// Return Type: HRESULT->LONG->int
        [DllImport("shell32.dll", EntryPoint = "SHLoadNonloadedIconOverlayIdentifiers", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHLoadNonloadedIconOverlayIdentifiers();


        /// Return Type: HRESULT->LONG->int
        ///pwszPath: LPCWSTR->WCHAR*
        ///pdwStatus: LPDWORD->DWORD*
        [DllImport("shell32.dll", EntryPoint = "SHIsFileAvailableOffline", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHIsFileAvailableOffline([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszPath, ref uint pdwStatus);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///uAction: UINT->unsigned int
        ///lpBuf1: LPCWSTR->WCHAR*
        ///lpBuf2: LPCWSTR->WCHAR*
        ///fModal: BOOL->int
        [DllImport("shell32.dll", EntryPoint = "SHInvokePrinterCommandW", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHInvokePrinterCommandW(IntPtr hwnd, uint uAction, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBuf1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBuf2, [MarshalAs(UnmanagedType.Bool)] bool fModal);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///uAction: UINT->unsigned int
        ///lpBuf1: LPCSTR->CHAR*
        ///lpBuf2: LPCSTR->CHAR*
        ///fModal: BOOL->int
        [DllImport("shell32.dll", EntryPoint = "SHInvokePrinterCommandA", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHInvokePrinterCommandA(IntPtr hwnd, uint uAction, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuf1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuf2, [MarshalAs(UnmanagedType.Bool)] bool fModal);


        /// Return Type: BOOL->int
        ///pszLinkTo: LPCWSTR->WCHAR*
        ///pszDir: LPCWSTR->WCHAR*
        ///pszName: LPWSTR->WCHAR*
        ///pfMustCopy: BOOL*
        ///uFlags: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "SHGetNewLinkInfoW", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHGetNewLinkInfoW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszLinkTo, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszDir, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszName, ref int pfMustCopy, uint uFlags);


        /// Return Type: BOOL->int
        ///pszLinkTo: LPCSTR->CHAR*
        ///pszDir: LPCSTR->CHAR*
        ///pszName: LPSTR->CHAR*
        ///pfMustCopy: BOOL*
        ///uFlags: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "SHGetNewLinkInfoA", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHGetNewLinkInfoA([In] [MarshalAs(UnmanagedType.LPStr)] string pszLinkTo, [In] [MarshalAs(UnmanagedType.LPStr)] string pszDir, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszName, ref int pfMustCopy, uint uFlags);


        /// Return Type: DWORD_PTR->ULONG_PTR->unsigned int
        ///pszPath: LPCWSTR->WCHAR*
        ///dwFileAttributes: DWORD->unsigned int
        ///psfi: SHFILEINFOW*
        ///cbFileInfo: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "SHGetFileInfoW", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SHGetFileInfoW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszPath, uint dwFileAttributes, ref SHFILEINFOW psfi, uint cbFileInfo, uint uFlags);


        /// Return Type: DWORD_PTR->ULONG_PTR->unsigned int
        ///pszPath: LPCSTR->CHAR*
        ///dwFileAttributes: DWORD->unsigned int
        ///psfi: SHFILEINFOA*
        ///cbFileInfo: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "SHGetFileInfoA", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SHGetFileInfoA([In] [MarshalAs(UnmanagedType.LPStr)] string pszPath, uint dwFileAttributes, ref SHFILEINFOA psfi, uint cbFileInfo, uint uFlags);


        /// Return Type: BOOL->int
        ///pszDirectoryName: LPCWSTR->WCHAR*
        ///pulFreeBytesAvailableToCaller: ULARGE_INTEGER*
        ///pulTotalNumberOfBytes: ULARGE_INTEGER*
        ///pulTotalNumberOfFreeBytes: ULARGE_INTEGER*
        [DllImport("shell32.dll", EntryPoint = "SHGetDiskFreeSpaceExW", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHGetDiskFreeSpaceExW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszDirectoryName, ref ULARGE_INTEGER pulFreeBytesAvailableToCaller, ref ULARGE_INTEGER pulTotalNumberOfBytes, ref ULARGE_INTEGER pulTotalNumberOfFreeBytes);


        /// Return Type: BOOL->int
        ///pszDirectoryName: LPCSTR->CHAR*
        ///pulFreeBytesAvailableToCaller: ULARGE_INTEGER*
        ///pulTotalNumberOfBytes: ULARGE_INTEGER*
        ///pulTotalNumberOfFreeBytes: ULARGE_INTEGER*
        [DllImport("shell32.dll", EntryPoint = "SHGetDiskFreeSpaceExA", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHGetDiskFreeSpaceExA([In] [MarshalAs(UnmanagedType.LPStr)] string pszDirectoryName, ref ULARGE_INTEGER pulFreeBytesAvailableToCaller, ref ULARGE_INTEGER pulTotalNumberOfBytes, ref ULARGE_INTEGER pulTotalNumberOfFreeBytes);


        /// Return Type: void
        ///hNameMappings: HANDLE->void*
        [DllImport("shell32.dll", EntryPoint = "SHFreeNameMappings", CallingConvention = CallingConvention.StdCall)]
        public static extern void SHFreeNameMappings(IntPtr hNameMappings);


        /// Return Type: int
        ///lpFileOp: LPSHFILEOPSTRUCTW->_SHFILEOPSTRUCTW*
        [DllImport("shell32.dll", EntryPoint = "SHFileOperationW", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHFileOperationW(ref SHFILEOPSTRUCTW lpFileOp);


        /// Return Type: int
        ///lpFileOp: LPSHFILEOPSTRUCTA->_SHFILEOPSTRUCTA*
        [DllImport("shell32.dll", EntryPoint = "SHFileOperationA", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHFileOperationA(ref SHFILEOPSTRUCTA lpFileOp);


        /// Return Type: HRESULT->LONG->int
        ///hwnd: HWND->HWND__*
        ///pszRootPath: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("shell32.dll", EntryPoint = "SHEmptyRecycleBinW", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHEmptyRecycleBinW(IntPtr hwnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszRootPath, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///hwnd: HWND->HWND__*
        ///pszRootPath: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("shell32.dll", EntryPoint = "SHEmptyRecycleBinA", CallingConvention = CallingConvention.StdCall)]
        public static extern int SHEmptyRecycleBinA(IntPtr hwnd, [In] [MarshalAs(UnmanagedType.LPStr)] string pszRootPath, uint dwFlags);


        /// Return Type: BOOL->int
        ///dwMessage: DWORD->unsigned int
        ///lpData: PNOTIFYICONDATAW->_NOTIFYICONDATAW*
        [DllImport("shell32.dll", EntryPoint = "Shell_NotifyIconW", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Shell_NotifyIconW(uint dwMessage, ref NOTIFYICONDATAW lpData);


        /// Return Type: BOOL->int
        ///dwMessage: DWORD->unsigned int
        ///lpData: PNOTIFYICONDATAA->_NOTIFYICONDATAA*
        [DllImport("shell32.dll", EntryPoint = "Shell_NotifyIconA", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Shell_NotifyIconA(uint dwMessage, ref NOTIFYICONDATAA lpData);


        /// Return Type: HINSTANCE->HINSTANCE__*
        ///hwnd: HWND->HWND__*
        ///lpOperation: LPCWSTR->WCHAR*
        ///lpFile: LPCWSTR->WCHAR*
        ///lpParameters: LPCWSTR->WCHAR*
        ///lpDirectory: LPCWSTR->WCHAR*
        ///nShowCmd: INT->int
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteW", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ShellExecuteW(IntPtr hwnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpOperation, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFile, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpParameters, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDirectory, int nShowCmd);


        /// Return Type: BOOL->int
        ///lpExecInfo: LPSHELLEXECUTEINFOW->_SHELLEXECUTEINFOW*
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteExW", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShellExecuteExW(ref SHELLEXECUTEINFOW lpExecInfo);


        /// Return Type: BOOL->int
        ///lpExecInfo: LPSHELLEXECUTEINFOA->_SHELLEXECUTEINFOA*
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteExA", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShellExecuteExA(ref SHELLEXECUTEINFOA lpExecInfo);


        /// Return Type: HINSTANCE->HINSTANCE__*
        ///hwnd: HWND->HWND__*
        ///lpOperation: LPCSTR->CHAR*
        ///lpFile: LPCSTR->CHAR*
        ///lpParameters: LPCSTR->CHAR*
        ///lpDirectory: LPCSTR->CHAR*
        ///nShowCmd: INT->int
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteA", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ShellExecuteA(IntPtr hwnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpOperation, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpParameters, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDirectory, int nShowCmd);


        /// Return Type: INT->int
        ///hWnd: HWND->HWND__*
        ///szApp: LPCWSTR->WCHAR*
        ///szOtherStuff: LPCWSTR->WCHAR*
        ///hIcon: HICON->HICON__*
        [DllImport("shell32.dll", EntryPoint = "ShellAboutW", CallingConvention = CallingConvention.StdCall)]
        public static extern int ShellAboutW(IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string szApp, [In] [MarshalAs(UnmanagedType.LPWStr)] string szOtherStuff, IntPtr hIcon);


        /// Return Type: INT->int
        ///hWnd: HWND->HWND__*
        ///szApp: LPCSTR->CHAR*
        ///szOtherStuff: LPCSTR->CHAR*
        ///hIcon: HICON->HICON__*
        [DllImport("shell32.dll", EntryPoint = "ShellAboutA", CallingConvention = CallingConvention.StdCall)]
        public static extern int ShellAboutA(IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string szApp, [In] [MarshalAs(UnmanagedType.LPStr)] string szOtherStuff, IntPtr hIcon);


        /// Return Type: BOOL->int
        ///pscpi: PSHCREATEPROCESSINFOW->_SHCREATEPROCESSINFOW*
        [DllImport("shell32.dll", EntryPoint = "SHCreateProcessAsUserW", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHCreateProcessAsUserW(ref SHCREATEPROCESSINFOW pscpi);


        /// Return Type: UINT_PTR->unsigned int
        ///dwMessage: DWORD->unsigned int
        ///pData: PAPPBARDATA->_AppBarData*
        [DllImport("shell32.dll", EntryPoint = "SHAppBarMessage", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern uint SHAppBarMessage(uint dwMessage, ref APPBARDATA pData);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpxf: XFORM*
        [DllImport("gdi32.dll", EntryPoint = "SetWorldTransform")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWorldTransform([In] IntPtr hdc, [In] ref tagXFORM lpxf);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///lpMeta16Data: BYTE*
        ///hdcRef: HDC->HDC__*
        ///lpMFP: METAFILEPICT*
        [DllImport("gdi32.dll", EntryPoint = "SetWinMetaFileBits")]
        public static extern IntPtr SetWinMetaFileBits(uint nSize, [In] IntPtr lpMeta16Data, [In] IntPtr hdcRef, [In] IntPtr lpMFP);


        /// Return Type: HWINEVENTHOOK->HWINEVENTHOOK__*
        ///eventMin: DWORD->unsigned int
        ///eventMax: DWORD->unsigned int
        ///hmodWinEventProc: HMODULE->HINSTANCE->HINSTANCE__*
        ///pfnWinEventProc: WINEVENTPROC
        ///idProcess: DWORD->unsigned int
        ///idThread: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWinEventHook")]
        public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, [In] IntPtr hmodWinEventProc, WINEVENTPROC pfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);


        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///wNewWord: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "SetWindowWord")]
        public static extern ushort SetWindowWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "SetWindowTextW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowTextW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "SetWindowTextA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowTextA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: HHOOK->HHOOK__*
        ///nFilterType: int
        ///pfnFilterProc: HOOKPROC
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookW")]
        public static extern IntPtr SetWindowsHookW(int nFilterType, HOOKPROC pfnFilterProc);


        /// Return Type: HHOOK->HHOOK__*
        ///idHook: int
        ///lpfn: HOOKPROC
        ///hmod: HINSTANCE->HINSTANCE__*
        ///dwThreadId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExW")]
        public static extern IntPtr SetWindowsHookExW(int idHook, HOOKPROC lpfn, [In] IntPtr hmod, uint dwThreadId);


        /// Return Type: HHOOK->HHOOK__*
        ///idHook: int
        ///lpfn: HOOKPROC
        ///hmod: HINSTANCE->HINSTANCE__*
        ///dwThreadId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExA")]
        public static extern IntPtr SetWindowsHookExA(int idHook, HOOKPROC lpfn, [In] IntPtr hmod, uint dwThreadId);


        /// Return Type: HHOOK->HHOOK__*
        ///nFilterType: int
        ///pfnFilterProc: HOOKPROC
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookA")]
        public static extern IntPtr SetWindowsHookA(int nFilterType, HOOKPROC pfnFilterProc);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        ///bRedraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
        public static extern int SetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hWndInsertAfter: HWND->HWND__*
        ///X: int
        ///Y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos([In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpwndpl: WINDOWPLACEMENT*
        [DllImport("user32.dll", EntryPoint = "SetWindowPlacement")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPlacement([In] IntPtr hWnd, [In] ref tagWINDOWPLACEMENT lpwndpl);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "SetWindowOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetWindowLongW")]
        public static extern int SetWindowLongW([In] IntPtr hWnd, int nIndex, int dwNewLong);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetWindowLongA")]
        public static extern int SetWindowLongA([In] IntPtr hWnd, int nIndex, int dwNewLong);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "SetWindowExtEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowExtEx([In] IntPtr hdc, int x, int y, IntPtr lpsz);


        /// Return Type: BOOL->int
        ///param0: HWND->HWND__*
        ///param1: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetWindowContextHelpId")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowContextHelpId([In] IntPtr param0, uint param1);


        /// Return Type: BOOL->int
        ///hTimer: HANDLE->void*
        ///lpDueTime: LARGE_INTEGER*
        ///lPeriod: LONG->int
        ///pfnCompletionRoutine: PTIMERAPCROUTINE
        ///lpArgToCompletionRoutine: LPVOID->void*
        ///fResume: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetWaitableTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWaitableTimer([In] IntPtr hTimer, [In] ref LARGE_INTEGER lpDueTime, int lPeriod, PTIMERAPCROUTINE pfnCompletionRoutine, [In] IntPtr lpArgToCompletionRoutine, [MarshalAs(UnmanagedType.Bool)] bool fResume);


        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCWSTR->WCHAR*
        ///lpszVolumeName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeMountPointW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName);


        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCSTR->CHAR*
        ///lpszVolumeName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeMountPointA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName);


        /// Return Type: BOOL->int
        ///lpRootPathName: LPCWSTR->WCHAR*
        ///lpVolumeName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeLabelW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeLabelW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpVolumeName);


        /// Return Type: BOOL->int
        ///lpRootPathName: LPCSTR->CHAR*
        ///lpVolumeName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetVolumeLabelA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetVolumeLabelA([In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpVolumeName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "SetViewportOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetViewportOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "SetViewportExtEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetViewportExtEx([In] IntPtr hdc, int x, int y, IntPtr lpsz);


        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///pSIRequested: PSECURITY_INFORMATION->DWORD*
        ///pSID: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("user32.dll", EntryPoint = "SetUserObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, [In] IntPtr pSID);


        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetUserObjectInformationW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectInformationW([In] IntPtr hObj, int nIndex, [In] IntPtr pvInfo, uint nLength);


        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetUserObjectInformationA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectInformationA([In] IntPtr hObj, int nIndex, [In] IntPtr pvInfo, uint nLength);


        /// Return Type: BOOL->int
        ///GeoId: GEOID->LONG->int
        [DllImport("kernel32.dll", EntryPoint = "SetUserGeoID")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserGeoID(int GeoId);


        /// Return Type: DWORD->unsigned int
        ///pEncryptionCertificate: PENCRYPTION_CERTIFICATE->_ENCRYPTION_CERTIFICATE*
        [DllImport("advapi32.dll", EntryPoint = "SetUserFileEncryptionKey")]
        public static extern uint SetUserFileEncryptionKey([In] IntPtr pEncryptionCertificate);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwInQueue: DWORD->unsigned int
        ///dwOutQueue: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetupComm")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetupComm([In] IntPtr hFile, uint dwInQueue, uint dwOutQueue);


        /// Return Type: LPTOP_LEVEL_EXCEPTION_FILTER->PTOP_LEVEL_EXCEPTION_FILTER
        ///lpTopLevelExceptionFilter: LPTOP_LEVEL_EXCEPTION_FILTER->PTOP_LEVEL_EXCEPTION_FILTER
        [DllImport("kernel32.dll", EntryPoint = "SetUnhandledExceptionFilter")]
        public static extern PTOP_LEVEL_EXCEPTION_FILTER SetUnhandledExceptionFilter(PTOP_LEVEL_EXCEPTION_FILTER lpTopLevelExceptionFilter);


        /// Return Type: BOOL->int
        ///TokenHandle: HANDLE->void*
        ///TokenInformationClass: TOKEN_INFORMATION_CLASS->_TOKEN_INFORMATION_CLASS
        ///TokenInformation: LPVOID->void*
        ///TokenInformationLength: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "SetTokenInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetTokenInformation([In] IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, [In] IntPtr TokenInformation, uint TokenInformationLength);


        /// Return Type: BOOL->int
        ///lpTimeZoneInformation: TIME_ZONE_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "SetTimeZoneInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetTimeZoneInformation([In] ref TIME_ZONE_INFORMATION lpTimeZoneInformation);


        /// Return Type: HANDLE->void*
        ///TimerQueue: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Parameter: PVOID->void*
        ///DueTime: DWORD->unsigned int
        ///Period: DWORD->unsigned int
        ///PreferIo: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetTimerQueueTimer")]
        public static extern IntPtr SetTimerQueueTimer([In] IntPtr TimerQueue, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Parameter, uint DueTime, uint Period, [MarshalAs(UnmanagedType.Bool)] bool PreferIo);


        /// Return Type: UINT_PTR->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIDEvent: UINT_PTR->unsigned int
        ///uElapse: UINT->unsigned int
        ///lpTimerFunc: TIMERPROC
        [DllImport("user32.dll", EntryPoint = "SetTimer")]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint SetTimer([In] IntPtr hWnd, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr nIDEvent, uint uElapse, TIMERPROC lpTimerFunc);


        /// Return Type: BOOL->int
        ///Thread: PHANDLE->HANDLE*
        ///Token: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "SetThreadToken")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadToken(ref IntPtr Thread, [In] IntPtr Token);


        /// Return Type: BOOL->int
        ///StackSizeInBytes: PULONG->ULONG*
        [DllImport("kernel32.dll", EntryPoint = "SetThreadStackGuarantee")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadStackGuarantee(ref uint StackSizeInBytes);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///bDisablePriorityBoost: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadPriorityBoost([In] IntPtr hThread, [MarshalAs(UnmanagedType.Bool)] bool bDisablePriorityBoost);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///nPriority: int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadPriority")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadPriority([In] IntPtr hThread, int nPriority);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadLocale")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadLocale(uint Locale);


        /// Return Type: DWORD->unsigned int
        ///hThread: HANDLE->void*
        ///dwIdealProcessor: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadIdealProcessor")]
        public static extern uint SetThreadIdealProcessor([In] IntPtr hThread, uint dwIdealProcessor);


        /// Return Type: EXECUTION_STATE->DWORD->unsigned int
        ///esFlags: EXECUTION_STATE->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadExecutionState")]
        public static extern uint SetThreadExecutionState(uint esFlags);


        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        [DllImport("user32.dll", EntryPoint = "SetThreadDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadDesktop([In] IntPtr hDesktop);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpContext: CONTEXT*
        [DllImport("kernel32.dll", EntryPoint = "SetThreadContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadContext([In] IntPtr hThread, [In] ref CONTEXT lpContext);


        /// Return Type: DWORD_PTR->ULONG_PTR->unsigned int
        ///hThread: HANDLE->void*
        ///dwThreadAffinityMask: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetThreadAffinityMask")]
        public static extern uint SetThreadAffinityMask([In] IntPtr hThread, uint dwThreadAffinityMask);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///extra: int
        ///count: int
        [DllImport("gdi32.dll", EntryPoint = "SetTextJustification")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetTextJustification([In] IntPtr hdc, int extra, int count);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetTextColor")]
        public static extern uint SetTextColor([In] IntPtr hdc, uint color);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///extra: int
        [DllImport("gdi32.dll", EntryPoint = "SetTextCharacterExtra")]
        public static extern int SetTextCharacterExtra([In] IntPtr hdc, int extra);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///align: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetTextAlign")]
        public static extern uint SetTextAlign([In] IntPtr hdc, uint align);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwPositionMethod: DWORD->unsigned int
        ///dwPartition: DWORD->unsigned int
        ///dwOffsetLow: DWORD->unsigned int
        ///dwOffsetHigh: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetTapePosition")]
        public static extern uint SetTapePosition([In] IntPtr hDevice, uint dwPositionMethod, uint dwPartition, uint dwOffsetLow, uint dwOffsetHigh, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwOperation: DWORD->unsigned int
        ///lpTapeInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "SetTapeParameters")]
        public static extern uint SetTapeParameters([In] IntPtr hDevice, uint dwOperation, [In] IntPtr lpTapeInformation);


        /// Return Type: BOOL->int
        ///dwTimeAdjustment: DWORD->unsigned int
        ///bTimeAdjustmentDisabled: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetSystemTimeAdjustment")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemTimeAdjustment(uint dwTimeAdjustment, [MarshalAs(UnmanagedType.Bool)] bool bTimeAdjustmentDisabled);


        /// Return Type: BOOL->int
        ///lpSystemTime: SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME lpSystemTime);


        /// Return Type: BOOL->int
        ///fSuspend: BOOL->int
        ///fForce: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetSystemPowerState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemPowerState([MarshalAs(UnmanagedType.Bool)] bool fSuspend, [MarshalAs(UnmanagedType.Bool)] bool fForce);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///use: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetSystemPaletteUse")]
        public static extern uint SetSystemPaletteUse([In] IntPtr hdc, uint use);


        /// Return Type: BOOL->int
        ///MinimumFileCacheSize: SIZE_T->ULONG_PTR->unsigned int
        ///MaximumFileCacheSize: SIZE_T->ULONG_PTR->unsigned int
        ///Flags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetSystemFileCacheSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemFileCacheSize(uint MinimumFileCacheSize, uint MaximumFileCacheSize, uint Flags);


        /// Return Type: BOOL->int
        ///hcur: HCURSOR->HICON->HICON__*
        ///id: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetSystemCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemCursor([In] IntPtr hcur, uint id);


        /// Return Type: BOOL->int
        ///cElements: int
        ///lpaElements: INT*
        ///lpaRgbValues: COLORREF*
        [DllImport("user32.dll", EntryPoint = "SetSysColors")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSysColors(int cElements, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 0)] int[] lpaElements, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 0)] uint[] lpaRgbValues);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImport("gdi32.dll", EntryPoint = "SetStretchBltMode")]
        public static extern int SetStretchBltMode([In] IntPtr hdc, int mode);


        /// Return Type: BOOL->int
        ///nStdHandle: DWORD->unsigned int
        ///hHandle: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetStdHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetStdHandle(uint nStdHandle, [In] IntPtr hHandle);


        /// Return Type: HRESULT->LONG->int
        ///szDistUnit: LPCWSTR->WCHAR*
        ///dwAdState: DWORD->unsigned int
        ///dwAdvertisedVersionMS: DWORD->unsigned int
        ///dwAdvertisedVersionLS: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "SetSoftwareUpdateAdvertisementState", CallingConvention = CallingConvention.StdCall)]
        public static extern int SetSoftwareUpdateAdvertisementState([In] [MarshalAs(UnmanagedType.LPWStr)] string szDistUnit, uint dwAdState, uint dwAdvertisedVersionMS, uint dwAdvertisedVersionLS);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///level: int
        ///optname: int
        ///optval: char*
        ///optlen: int
        [DllImport("ws2_32.dll", EntryPoint = "setsockopt", CallingConvention = CallingConvention.StdCall)]
        public static extern int setsockopt([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, int level, int optname, [In] [MarshalAs(UnmanagedType.LPStr)] string optval, int optlen);


        /// Return Type: BOOL->int
        ///hServiceStatus: SERVICE_STATUS_HANDLE->SERVICE_STATUS_HANDLE__*
        ///lpServiceStatus: LPSERVICE_STATUS->_SERVICE_STATUS*
        [DllImport("advapi32.dll", EntryPoint = "SetServiceStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetServiceStatus([In] ref SERVICE_STATUS_HANDLE__ hServiceStatus, [In] ref SERVICE_STATUS lpServiceStatus);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwSecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///lpSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "SetServiceObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetServiceObjectSecurity([In] ref SC_HANDLE__ hService, uint dwSecurityInformation, [In] IntPtr lpSecurityDescriptor);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///bSaclPresent: BOOL->int
        ///pSacl: PACL->ACL*
        ///bSaclDefaulted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "SetSecurityDescriptorSacl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSecurityDescriptorSacl(IntPtr pSecurityDescriptor, [MarshalAs(UnmanagedType.Bool)] bool bSaclPresent, [In] IntPtr pSacl, [MarshalAs(UnmanagedType.Bool)] bool bSaclDefaulted);


        /// Return Type: DWORD->unsigned int
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///RMControl: PUCHAR->UCHAR*
        [DllImport("advapi32.dll", EntryPoint = "SetSecurityDescriptorRMControl")]
        public static extern uint SetSecurityDescriptorRMControl(IntPtr SecurityDescriptor, [In] [MarshalAs(UnmanagedType.LPStr)] string RMControl);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///pOwner: PSID->PVOID->void*
        ///bOwnerDefaulted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "SetSecurityDescriptorOwner")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSecurityDescriptorOwner(IntPtr pSecurityDescriptor, [In] IntPtr pOwner, [MarshalAs(UnmanagedType.Bool)] bool bOwnerDefaulted);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///pGroup: PSID->PVOID->void*
        ///bGroupDefaulted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "SetSecurityDescriptorGroup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSecurityDescriptorGroup(IntPtr pSecurityDescriptor, [In] IntPtr pGroup, [MarshalAs(UnmanagedType.Bool)] bool bGroupDefaulted);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///bDaclPresent: BOOL->int
        ///pDacl: PACL->ACL*
        ///bDaclDefaulted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "SetSecurityDescriptorDacl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSecurityDescriptorDacl(IntPtr pSecurityDescriptor, [MarshalAs(UnmanagedType.Bool)] bool bDaclPresent, [In] IntPtr pDacl, [MarshalAs(UnmanagedType.Bool)] bool bDaclDefaulted);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///ControlBitsOfInterest: SECURITY_DESCRIPTOR_CONTROL->WORD->unsigned short
        ///ControlBitsToSet: SECURITY_DESCRIPTOR_CONTROL->WORD->unsigned short
        [DllImport("advapi32.dll", EntryPoint = "SetSecurityDescriptorControl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSecurityDescriptorControl([In] IntPtr pSecurityDescriptor, ushort ControlBitsOfInterest, ushort ControlBitsToSet);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        ///nMinPos: int
        ///nMaxPos: int
        ///bRedraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetScrollRange")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetScrollRange([In] IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        ///nPos: int
        ///bRedraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetScrollPos")]
        public static extern int SetScrollPos([In] IntPtr hWnd, int nBar, int nPos, [MarshalAs(UnmanagedType.Bool)] bool bRedraw);


        /// Return Type: int
        ///hwnd: HWND->HWND__*
        ///nBar: int
        ///lpsi: LPCSCROLLINFO->SCROLLINFO*
        ///redraw: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetScrollInfo")]
        public static extern int SetScrollInfo([In] IntPtr hwnd, int nBar, [In] ref tagSCROLLINFO lpsi, [MarshalAs(UnmanagedType.Bool)] bool redraw);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///rop2: int
        [DllImport("gdi32.dll", EntryPoint = "SetROP2")]
        public static extern int SetROP2([In] IntPtr hdc, int rop2);


        /// Return Type: BOOL->int
        ///hrgn: HRGN->HRGN__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        [DllImport("gdi32.dll", EntryPoint = "SetRectRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetRectRgn([In] IntPtr hrgn, int left, int top, int right, int bottom);


        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "SetRectEmpty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetRectEmpty([Out] out tagRECT lprc);


        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        ///xLeft: int
        ///yTop: int
        ///xRight: int
        ///yBottom: int
        [DllImport("user32.dll", EntryPoint = "SetRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetRect([Out] out tagRECT lprc, int xLeft, int yTop, int xRight, int yBottom);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        ///hData: HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "SetPropW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPropW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, [In] IntPtr hData);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        ///hData: HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "SetPropA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPropA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, [In] IntPtr hData);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///dwMinimumWorkingSetSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwMaximumWorkingSetSize: SIZE_T->ULONG_PTR->unsigned int
        ///Flags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSizeEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessWorkingSetSizeEx([In] IntPtr hProcess, uint dwMinimumWorkingSetSize, uint dwMaximumWorkingSetSize, uint Flags);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///dwMinimumWorkingSetSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwMaximumWorkingSetSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessWorkingSetSize([In] IntPtr hProcess, uint dwMinimumWorkingSetSize, uint dwMaximumWorkingSetSize);


        /// Return Type: BOOL->int
        ///hWinSta: HWINSTA->HWINSTA__*
        [DllImport("user32.dll", EntryPoint = "SetProcessWindowStation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessWindowStation([In] IntPtr hWinSta);


        /// Return Type: BOOL->int
        ///dwLevel: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessShutdownParameters")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessShutdownParameters(uint dwLevel, uint dwFlags);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///bDisablePriorityBoost: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessPriorityBoost([In] IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] bool bDisablePriorityBoost);


        /// Return Type: BOOL->int
        ///dwDefaultLayout: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetProcessDefaultLayout")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessDefaultLayout(uint dwDefaultLayout);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///dwProcessAffinityMask: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetProcessAffinityMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessAffinityMask([In] IntPtr hProcess, uint dwProcessAffinityMask);


        /// Return Type: BOOL->int
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///ModificationDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///ObjectsSecurityDescriptor: PSECURITY_DESCRIPTOR*
        ///AutoInheritFlags: ULONG->unsigned int
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///Token: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "SetPrivateObjectSecurityEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPrivateObjectSecurityEx(uint SecurityInformation, [In] IntPtr ModificationDescriptor, ref IntPtr ObjectsSecurityDescriptor, uint AutoInheritFlags, [In] ref GENERIC_MAPPING GenericMapping, [In] IntPtr Token);


        /// Return Type: BOOL->int
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///ModificationDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///ObjectsSecurityDescriptor: PSECURITY_DESCRIPTOR*
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        ///Token: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "SetPrivateObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPrivateObjectSecurity(uint SecurityInformation, [In] IntPtr ModificationDescriptor, ref IntPtr ObjectsSecurityDescriptor, [In] ref GENERIC_MAPPING GenericMapping, [In] IntPtr Token);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///dwPriorityClass: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetPriorityClass")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPriorityClass([In] IntPtr hProcess, uint dwPriorityClass);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pPrinter: LPBYTE->BYTE*
        ///Command: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetPrinterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPrinterW([In] IntPtr hPrinter, uint Level, [In] ref byte pPrinter, uint Command);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pValueName: LPWSTR->WCHAR*
        ///Type: DWORD->unsigned int
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetPrinterDataW")]
        public static extern uint SetPrinterDataW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pValueName, uint Type, [In] IntPtr pData, uint cbData);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCWSTR->WCHAR*
        ///pValueName: LPCWSTR->WCHAR*
        ///Type: DWORD->unsigned int
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetPrinterDataExW")]
        public static extern uint SetPrinterDataExW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pKeyName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pValueName, uint Type, [In] IntPtr pData, uint cbData);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCSTR->CHAR*
        ///pValueName: LPCSTR->CHAR*
        ///Type: DWORD->unsigned int
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetPrinterDataExA")]
        public static extern uint SetPrinterDataExA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pKeyName, [In] [MarshalAs(UnmanagedType.LPStr)] string pValueName, uint Type, [In] IntPtr pData, uint cbData);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pValueName: LPSTR->CHAR*
        ///Type: DWORD->unsigned int
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetPrinterDataA")]
        public static extern uint SetPrinterDataA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pValueName, uint Type, [In] IntPtr pData, uint cbData);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pPrinter: LPBYTE->BYTE*
        ///Command: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetPrinterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPrinterA([In] IntPtr hPrinter, uint Level, [In] ref byte pPrinter, uint Command);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pPortName: LPWSTR->WCHAR*
        ///dwLevel: DWORD->unsigned int
        ///pPortInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "SetPortW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPortW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPortName, uint dwLevel, [In] ref byte pPortInfo);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pPortName: LPSTR->CHAR*
        ///dwLevel: DWORD->unsigned int
        ///pPortInfo: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "SetPortA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPortA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pPortName, uint dwLevel, [In] ref byte pPortInfo);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImport("gdi32.dll", EntryPoint = "SetPolyFillMode")]
        public static extern int SetPolyFillMode([In] IntPtr hdc, int mode);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetPixelV")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPixelV([In] IntPtr hdc, int x, int y, uint color);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///format: int
        ///ppfd: PIXELFORMATDESCRIPTOR*
        [DllImport("gdi32.dll", EntryPoint = "SetPixelFormat")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPixelFormat([In] IntPtr hdc, int format, [In] ref tagPIXELFORMATDESCRIPTOR ppfd);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetPixel")]
        public static extern uint SetPixel([In] IntPtr hdc, int x, int y, uint color);


        /// Return Type: HWND->HWND__*
        ///hWndChild: HWND->HWND__*
        ///hWndNewParent: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetParent")]
        public static extern IntPtr SetParent([In] IntPtr hWndChild, [In] IntPtr hWndNewParent);


        /// Return Type: UINT->unsigned int
        ///hpal: HPALETTE->HPALETTE__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///pPalEntries: PALETTEENTRY*
        [DllImport("gdi32.dll", EntryPoint = "SetPaletteEntries")]
        public static extern uint SetPaletteEntries([In] IntPtr hpal, uint iStart, uint cEntries, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPALETTEENTRY[] pPalEntries);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpMode: LPDWORD->DWORD*
        ///lpMaxCollectionCount: LPDWORD->DWORD*
        ///lpCollectDataTimeout: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "SetNamedPipeHandleState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetNamedPipeHandleState([In] IntPtr hNamedPipe, [In] IntPtr lpMode, [In] IntPtr lpMaxCollectionCount, [In] IntPtr lpCollectDataTimeout);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///limit: FLOAT->float
        ///old: PFLOAT->FLOAT*
        [DllImport("gdi32.dll", EntryPoint = "SetMiterLimit")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMiterLimit([In] IntPtr hdc, float limit, IntPtr old);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "SetMetaRgn")]
        public static extern int SetMetaRgn([In] IntPtr hdc);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///cbBuffer: UINT->unsigned int
        ///lpData: BYTE*
        [DllImport("gdi32.dll", EntryPoint = "SetMetaFileBitsEx")]
        public static extern IntPtr SetMetaFileBitsEx(uint cbBuffer, [In] IntPtr lpData);


        /// Return Type: BOOL->int
        ///hMsgIndicator: HANDLE->void*
        ///ulMsgCount: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetMessageWaitingIndicator")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMessageWaitingIndicator([In] IntPtr hMsgIndicator, uint ulMsgCount);


        /// Return Type: BOOL->int
        ///cMessagesMax: int
        [DllImport("user32.dll", EntryPoint = "SetMessageQueue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMessageQueue(int cMessagesMax);


        /// Return Type: LPARAM->LONG_PTR->int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SetMessageExtraInfo")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SetMessageExtraInfo([MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPositon: BOOL->int
        ///lpmii: LPCMENUITEMINFOW->MENUITEMINFOW*
        [DllImport("user32.dll", EntryPoint = "SetMenuItemInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemInfoW([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPositon, [In] ref tagMENUITEMINFOW lpmii);


        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPositon: BOOL->int
        ///lpmii: LPCMENUITEMINFOA->MENUITEMINFOA*
        [DllImport("user32.dll", EntryPoint = "SetMenuItemInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemInfoA([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPositon, [In] ref tagMENUITEMINFOA lpmii);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///hBitmapUnchecked: HBITMAP->HBITMAP__*
        ///hBitmapChecked: HBITMAP->HBITMAP__*
        [DllImport("user32.dll", EntryPoint = "SetMenuItemBitmaps")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemBitmaps([In] IntPtr hMenu, uint uPosition, uint uFlags, [In] IntPtr hBitmapUnchecked, [In] IntPtr hBitmapChecked);


        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: LPCMENUINFO->MENUINFO*
        [DllImport("user32.dll", EntryPoint = "SetMenuInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuInfo([In] IntPtr param0, [In] ref tagMENUINFO param1);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uItem: UINT->unsigned int
        ///fByPos: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetMenuDefaultItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuDefaultItem([In] IntPtr hMenu, uint uItem, uint fByPos);


        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetMenuContextHelpId")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuContextHelpId([In] IntPtr param0, uint param1);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "SetMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenu([In] IntPtr hWnd, [In] IntPtr hMenu);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///flags: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetMapperFlags")]
        public static extern uint SetMapperFlags([In] IntPtr hdc, uint flags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iMode: int
        [DllImport("gdi32.dll", EntryPoint = "SetMapMode")]
        public static extern int SetMapMode([In] IntPtr hdc, int iMode);


        /// Return Type: BOOL->int
        ///hMailslot: HANDLE->void*
        ///lReadTimeout: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetMailslotInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMailslotInfo([In] IntPtr hMailslot, uint lReadTimeout);


        /// Return Type: BOOL->int
        ///lpSystemTime: SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "SetLocalTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocalTime([In] ref SYSTEMTIME lpSystemTime);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetLocaleInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocaleInfoW(uint Locale, uint LCType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpLCData);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetLocaleInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLocaleInfoA(uint Locale, uint LCType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpLCData);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///l: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetLayout")]
        public static extern uint SetLayout([In] IntPtr hdc, uint l);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///crKey: COLORREF->DWORD->unsigned int
        ///bAlpha: BYTE->unsigned char
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes([In] IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);


        /// Return Type: void
        ///dwErrCode: DWORD->unsigned int
        ///dwType: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetLastErrorEx")]
        public static extern void SetLastErrorEx(uint dwErrCode, uint dwType);


        /// Return Type: void
        ///dwErrCode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetLastError")]
        public static extern void SetLastError(uint dwErrCode);


        /// Return Type: BOOL->int
        ///lpKeyState: LPBYTE->BYTE*
        [DllImport("user32.dll", EntryPoint = "SetKeyboardState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetKeyboardState([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeConst = 256)] byte[] lpKeyState);


        /// Return Type: BOOL->int
        ///Handle: HANDLE->void*
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "SetKernelObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetKernelObjectSecurity([In] IntPtr Handle, uint SecurityInformation, [In] IntPtr SecurityDescriptor);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///JobId: DWORD->unsigned int
        ///Level: DWORD->unsigned int
        ///pJob: LPBYTE->BYTE*
        ///Command: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetJobW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetJobW([In] IntPtr hPrinter, uint JobId, uint Level, [In] IntPtr pJob, uint Command);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///JobId: DWORD->unsigned int
        ///Level: DWORD->unsigned int
        ///pJob: LPBYTE->BYTE*
        ///Command: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SetJobA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetJobA([In] IntPtr hPrinter, uint JobId, uint Level, [In] IntPtr pJob, uint Command);


        /// Return Type: BOOL->int
        ///hJob: HANDLE->void*
        ///JobObjectInformationClass: JOBOBJECTINFOCLASS->_JOBOBJECTINFOCLASS
        ///lpJobObjectInformation: LPVOID->void*
        ///cbJobObjectInformationLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetInformationJobObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetInformationJobObject([In] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [In] IntPtr lpJobObjectInformation, uint cbJobObjectInformationLength);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpFileName: LPWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "SetICMProfileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetICMProfileW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpFileName: LPSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "SetICMProfileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetICMProfileA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImport("gdi32.dll", EntryPoint = "SetICMMode")]
        public static extern int SetICMMode([In] IntPtr hdc, int mode);


        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        ///dwMask: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetHandleInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetHandleInformation([In] IntPtr hObject, uint dwMask, uint dwFlags);


        /// Return Type: UINT->unsigned int
        ///uNumber: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetHandleCount")]
        public static extern uint SetHandleCount(uint uNumber);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iMode: int
        [DllImport("gdi32.dll", EntryPoint = "SetGraphicsMode")]
        public static extern int SetGraphicsMode([In] IntPtr hdc, int iMode);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pFormName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "SetFormW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFormW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pFormName, uint Level, [In] ref byte pForm);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pFormName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        [DllImport("<Unknown>", EntryPoint = "SetFormA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFormA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormName, uint Level, [In] ref byte pForm);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow([In] IntPtr hWnd);


        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetFocus")]
        public static extern IntPtr SetFocus([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        ///lpGuid: LPCWSTR->WCHAR*
        ///pValue: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFirmwareEnvironmentVariableW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFirmwareEnvironmentVariableW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, [In] IntPtr pValue, uint nSize);


        /// Return Type: BOOL->int
        ///lpName: LPCSTR->CHAR*
        ///lpGuid: LPCSTR->CHAR*
        ///pValue: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFirmwareEnvironmentVariableA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFirmwareEnvironmentVariableA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpGuid, [In] IntPtr pValue, uint nSize);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///ValidDataLength: LONGLONG->__int64
        [DllImport("kernel32.dll", EntryPoint = "SetFileValidData")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileValidData([In] IntPtr hFile, long ValidDataLength);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCreationTime: FILETIME*
        ///lpLastAccessTime: FILETIME*
        ///lpLastWriteTime: FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "SetFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileTime([In] IntPtr hFile, [In] IntPtr lpCreationTime, [In] IntPtr lpLastAccessTime, [In] IntPtr lpLastWriteTime);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpShortName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetFileShortNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileShortNameW([In] IntPtr hFile, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpShortName);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpShortName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetFileShortNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileShortNameA([In] IntPtr hFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpShortName);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "SetFileSecurityW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileSecurityW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint SecurityInformation, [In] IntPtr pSecurityDescriptor);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "SetFileSecurityA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileSecurityA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint SecurityInformation, [In] IntPtr pSecurityDescriptor);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///liDistanceToMove: LARGE_INTEGER->_LARGE_INTEGER
        ///lpNewFilePointer: PLARGE_INTEGER->LARGE_INTEGER*
        ///dwMoveMethod: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFilePointerEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFilePointerEx([In] IntPtr hFile, LARGE_INTEGER liDistanceToMove, IntPtr lpNewFilePointer, uint dwMoveMethod);


        /// Return Type: DWORD->unsigned int
        ///hFile: HANDLE->void*
        ///lDistanceToMove: LONG->int
        ///lpDistanceToMoveHigh: PLONG->LONG*
        ///dwMoveMethod: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFilePointer")]
        public static extern uint SetFilePointer([In] IntPtr hFile, int lDistanceToMove, [In] IntPtr lpDistanceToMoveHigh, uint dwMoveMethod);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///dwFileAttributes: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFileAttributesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileAttributesW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint dwFileAttributes);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///dwFileAttributes: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetFileAttributesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileAttributesA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint dwFileAttributes);


        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "SetFileApisToOEM")]
        public static extern void SetFileApisToOEM();


        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "SetFileApisToANSI")]
        public static extern void SetFileApisToANSI();


        /// Return Type: BOOL->int
        ///hEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEvent([In] IntPtr hEvent);


        /// Return Type: UINT->unsigned int
        ///uMode: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetErrorMode")]
        public static extern uint SetErrorMode(uint uMode);


        /// Return Type: HRESULT->LONG->int
        ///dwReserved: ULONG->unsigned int
        ///perrinfo: IErrorInfo*
        [DllImport("oleaut32.dll", EntryPoint = "SetErrorInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int SetErrorInfo(uint dwReserved, ref IErrorInfo perrinfo);


        /// Return Type: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        ///lpValue: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetEnvironmentVariableW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValue);


        /// Return Type: BOOL->int
        ///lpName: LPCSTR->CHAR*
        ///lpValue: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetEnvironmentVariableA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentVariableA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValue);


        /// Return Type: BOOL->int
        ///NewEnvironment: LPWCH->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetEnvironmentStringsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentStringsW([In] [MarshalAs(UnmanagedType.LPWStr)] string NewEnvironment);


        /// Return Type: BOOL->int
        ///NewEnvironment: LPCH->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetEnvironmentStringsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEnvironmentStringsA([In] [MarshalAs(UnmanagedType.LPStr)] string NewEnvironment);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///pb: BYTE*
        [DllImport("gdi32.dll", EntryPoint = "SetEnhMetaFileBits")]
        public static extern IntPtr SetEnhMetaFileBits(uint nSize, [In] IntPtr pb);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetEndOfFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetEndOfFile([In] IntPtr hFile);


        /// Return Type: BOOL->int
        ///param0: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetDoubleClickTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDoubleClickTime(uint param0);


        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetDllDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDllDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName);


        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetDllDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDllDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "SetDlgItemTextW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemTextW([In] IntPtr hDlg, int nIDDlgItem, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "SetDlgItemTextA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemTextA([In] IntPtr hDlg, int nIDDlgItem, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///uValue: UINT->unsigned int
        ///bSigned: BOOL->int
        [DllImport("user32.dll", EntryPoint = "SetDlgItemInt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, uint uValue, [MarshalAs(UnmanagedType.Bool)] bool bSigned);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///w: DWORD->unsigned int
        ///h: DWORD->unsigned int
        ///xSrc: int
        ///ySrc: int
        ///StartScan: UINT->unsigned int
        ///cLines: UINT->unsigned int
        ///lpvBits: void*
        ///lpbmi: BITMAPINFO*
        ///ColorUse: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetDIBitsToDevice")]
        public static extern int SetDIBitsToDevice([In] IntPtr hdc, int xDest, int yDest, uint w, uint h, int xSrc, int ySrc, uint StartScan, uint cLines, [In] IntPtr lpvBits, [In] ref tagBITMAPINFO lpbmi, uint ColorUse);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hbm: HBITMAP->HBITMAP__*
        ///start: UINT->unsigned int
        ///cLines: UINT->unsigned int
        ///lpBits: void*
        ///lpbmi: BITMAPINFO*
        ///ColorUse: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetDIBits")]
        public static extern int SetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines, [In] IntPtr lpBits, [In] ref tagBITMAPINFO lpbmi, uint ColorUse);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///prgbq: RGBQUAD*
        [DllImport("gdi32.dll", EntryPoint = "SetDIBColorTable")]
        public static extern uint SetDIBColorTable([In] IntPtr hdc, uint iStart, uint cEntries, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagRGBQUAD[] prgbq);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpRamp: LPVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "SetDeviceGammaRamp")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDeviceGammaRamp([In] IntPtr hdc, [In] IntPtr lpRamp);


        /// Return Type: BOOL->int
        ///pszPrinter: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "SetDefaultPrinterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultPrinterW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszPrinter);


        /// Return Type: BOOL->int
        ///pszPrinter: LPCSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "SetDefaultPrinterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultPrinterA([In] [MarshalAs(UnmanagedType.LPStr)] string pszPrinter);


        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetDefaultCommConfigW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultCommConfigW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszName, [In] IntPtr lpCC, uint dwSize);


        /// Return Type: BOOL->int
        ///lpszName: LPCSTR->CHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetDefaultCommConfigA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDefaultCommConfigA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszName, [In] IntPtr lpCC, uint dwSize);


        /// Return Type: void
        ///dwLevel: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetDebugErrorLevel")]
        public static extern void SetDebugErrorLevel(uint dwLevel);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetDCPenColor")]
        public static extern uint SetDCPenColor([In] IntPtr hdc, uint color);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetDCBrushColor")]
        public static extern uint SetDCBrushColor([In] IntPtr hdc, uint color);


        /// Return Type: BOOL->int
        ///X: int
        ///Y: int
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int X, int Y);


        /// Return Type: HCURSOR->HICON->HICON__*
        ///hCursor: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "SetCursor")]
        public static extern IntPtr SetCursor([In] IntPtr hCursor);


        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCurrentDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName);


        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCurrentDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCurrentDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName);


        /// Return Type: DWORD->unsigned int
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        ///dwSpinCount: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetCriticalSectionSpinCount")]
        public static extern uint SetCriticalSectionSpinCount(ref RTL_CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        ///fConvert: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "SetConvertStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int SetConvertStg(ref IStorage pStg, [MarshalAs(UnmanagedType.Bool)] bool fConvert);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///bAbsolute: BOOL->int
        ///lpConsoleWindow: SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleWindowInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleWindowInfo(IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.Bool)] bool bAbsolute, ref SMALL_RECT lpConsoleWindow);


        /// Return Type: BOOL->int
        ///lpConsoleTitle: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTitleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTitleW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpConsoleTitle);


        /// Return Type: BOOL->int
        ///lpConsoleTitle: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTitleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTitleA([In] [MarshalAs(UnmanagedType.LPStr)] string lpConsoleTitle);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///wAttributes: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTextAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, ushort wAttributes);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///dwSize: COORD->_COORD
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleScreenBufferSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD dwSize);


        /// Return Type: BOOL->int
        ///wCodePageID: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleOutputCP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleOutputCP(uint wCodePageID);


        /// Return Type: BOOL->int
        ///hConsoleHandle: HANDLE->void*
        ///dwMode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///dwCursorPosition: COORD->_COORD
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCursorPosition")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleCursorInfo: CONSOLE_CURSOR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);


        /// Return Type: BOOL->int
        ///HandlerRoutine: PHANDLER_ROUTINE
        ///Add: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCtrlHandler")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCtrlHandler(PHANDLER_ROUTINE HandlerRoutine, [MarshalAs(UnmanagedType.Bool)] bool Add);


        /// Return Type: BOOL->int
        ///wCodePageID: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCP(uint wCodePageID);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleActiveScreenBuffer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);


        /// Return Type: BOOL->int
        ///lpComputerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpComputerName);


        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameExW(COMPUTER_NAME_FORMAT NameType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer);


        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameExA(COMPUTER_NAME_FORMAT NameType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuffer);


        /// Return Type: BOOL->int
        ///lpComputerName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetComputerNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetComputerNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpComputerName);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "SetCommTimeouts")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommTimeouts([In] IntPtr hFile, [In] ref COMMTIMEOUTS lpCommTimeouts);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "SetCommState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommState([In] IntPtr hFile, [In] ref DCB lpDCB);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwEvtMask: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetCommMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommMask([In] IntPtr hFile, uint dwEvtMask);


        /// Return Type: BOOL->int
        ///hCommDev: HANDLE->void*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetCommConfig")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommConfig([In] IntPtr hCommDev, [In] IntPtr lpCC, uint dwSize);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetCommBreak")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCommBreak([In] IntPtr hFile);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///hdc: HDC->HDC__*
        ///hcs: HCOLORSPACE->HCOLORSPACE__*
        [DllImport("gdi32.dll", EntryPoint = "SetColorSpace")]
        public static extern IntPtr SetColorSpace([In] IntPtr hdc, [In] IntPtr hcs);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpca: COLORADJUSTMENT*
        [DllImport("gdi32.dll", EntryPoint = "SetColorAdjustment")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetColorAdjustment([In] IntPtr hdc, [In] ref tagCOLORADJUSTMENT lpca);


        /// Return Type: HWND->HWND__*
        ///hWndNewViewer: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetClipboardViewer")]
        public static extern IntPtr SetClipboardViewer([In] IntPtr hWndNewViewer);


        /// Return Type: HANDLE->void*
        ///uFormat: UINT->unsigned int
        ///hMem: HANDLE->void*
        [DllImport("user32.dll", EntryPoint = "SetClipboardData")]
        public static extern IntPtr SetClipboardData(uint uFormat, [In] IntPtr hMem);


        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///wNewWord: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "SetClassWord")]
        public static extern ushort SetClassWord([In] IntPtr hWnd, int nIndex, ushort wNewWord);


        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetClassLongW")]
        public static extern uint SetClassLongW([In] IntPtr hWnd, int nIndex, int dwNewLong);


        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        ///dwNewLong: LONG->int
        [DllImport("user32.dll", EntryPoint = "SetClassLongA")]
        public static extern uint SetClassLongA([In] IntPtr hWnd, int nIndex, int dwNewLong);


        /// Return Type: BOOL->int
        ///X: int
        ///Y: int
        [DllImport("user32.dll", EntryPoint = "SetCaretPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCaretPos(int X, int Y);


        /// Return Type: BOOL->int
        ///uMSeconds: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "SetCaretBlinkTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCaretBlinkTime(uint uMSeconds);


        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetCapture")]
        public static extern IntPtr SetCapture([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCalendarInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCalendarInfoW(uint Locale, uint Calendar, uint CalType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCalData);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetCalendarInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCalendarInfoA(uint Locale, uint Calendar, uint CalType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCalData);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "SetBrushOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetBrushOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///lprect: RECT*
        ///flags: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetBoundsRect")]
        public static extern uint SetBoundsRect([In] IntPtr hdc, [In] IntPtr lprect, uint flags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImport("gdi32.dll", EntryPoint = "SetBkMode")]
        public static extern int SetBkMode([In] IntPtr hdc, int mode);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "SetBkColor")]
        public static extern uint SetBkColor([In] IntPtr hdc, uint color);


        /// Return Type: BOOL->int
        ///hbm: HBITMAP->HBITMAP__*
        ///w: int
        ///h: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "SetBitmapDimensionEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetBitmapDimensionEx([In] IntPtr hbm, int w, int h, IntPtr lpsz);


        /// Return Type: LONG->int
        ///hbm: HBITMAP->HBITMAP__*
        ///cb: DWORD->unsigned int
        ///pvBits: void*
        [DllImport("gdi32.dll", EntryPoint = "SetBitmapBits")]
        public static extern int SetBitmapBits([In] IntPtr hbm, uint cb, [In] IntPtr pvBits);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///dir: int
        [DllImport("gdi32.dll", EntryPoint = "SetArcDirection")]
        public static extern int SetArcDirection([In] IntPtr hdc, int dir);


        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "SetActiveWindow")]
        public static extern IntPtr SetActiveWindow([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///pAclInformation: LPVOID->void*
        ///nAclInformationLength: DWORD->unsigned int
        ///dwAclInformationClass: ACL_INFORMATION_CLASS->_ACL_INFORMATION_CLASS
        [DllImport("advapi32.dll", EntryPoint = "SetAclInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetAclInformation(ref ACL pAcl, [In] IntPtr pAclInformation, uint nAclInformationLength, ACL_INFORMATION_CLASS dwAclInformationClass);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///proc: ABORTPROC
        [DllImport("gdi32.dll", EntryPoint = "SetAbortProc")]
        public static extern int SetAbortProc([In] IntPtr hdc, ABORTPROC proc);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///buf: char*
        ///len: int
        ///flags: int
        ///to: sockaddr*
        ///tolen: int
        [DllImport("ws2_32.dll", EntryPoint = "sendto", CallingConvention = CallingConvention.StdCall)]
        public static extern int sendto([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, [In] [MarshalAs(UnmanagedType.LPStr)] string buf, int len, int flags, ref sockaddr to, int tolen);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendNotifyMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendNotifyMessageW([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendNotifyMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendNotifyMessageA([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SendMessageW([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///fuFlags: UINT->unsigned int
        ///uTimeout: UINT->unsigned int
        ///lpdwResult: PDWORD_PTR->ULONG_PTR*
        [DllImport("user32.dll", EntryPoint = "SendMessageTimeoutW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SendMessageTimeoutW([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, uint fuFlags, uint uTimeout, IntPtr lpdwResult);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///fuFlags: UINT->unsigned int
        ///uTimeout: UINT->unsigned int
        ///lpdwResult: PDWORD_PTR->ULONG_PTR*
        [DllImport("user32.dll", EntryPoint = "SendMessageTimeoutA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SendMessageTimeoutA([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, uint fuFlags, uint uTimeout, IntPtr lpdwResult);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///lpResultCallBack: SENDASYNCPROC
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "SendMessageCallbackW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendMessageCallbackW([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, SENDASYNCPROC lpResultCallBack, uint dwData);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        ///lpResultCallBack: SENDASYNCPROC
        ///dwData: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "SendMessageCallbackA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendMessageCallbackA([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam, SENDASYNCPROC lpResultCallBack, uint dwData);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SendMessageA([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: UINT->unsigned int
        ///cInputs: UINT->unsigned int
        ///pInputs: LPINPUT->tagINPUT*
        ///cbSize: int
        [DllImport("user32.dll", EntryPoint = "SendInput")]
        public static extern uint SendInput(uint cInputs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0)] tagINPUT[] pInputs, int cbSize);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hDriver: HDRVR->HDRVR__*
        ///message: UINT->unsigned int
        ///lParam1: LPARAM->LONG_PTR->int
        ///lParam2: LPARAM->LONG_PTR->int
        [DllImport("winmm.dll", EntryPoint = "SendDriverMessage")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SendDriverMessage(IntPtr hDriver, uint message, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam1, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam2);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendDlgItemMessageW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SendDlgItemMessageW([In] IntPtr hDlg, int nIDDlgItem, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "SendDlgItemMessageA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr SendDlgItemMessageA([In] IntPtr hDlg, int nIDDlgItem, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///buf: char*
        ///len: int
        ///flags: int
        [DllImport("ws2_32.dll", EntryPoint = "send", CallingConvention = CallingConvention.StdCall)]
        public static extern int send([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, [In] [MarshalAs(UnmanagedType.LPStr)] string buf, int len, int flags);


        /// Return Type: HPALETTE->HPALETTE__*
        ///hdc: HDC->HDC__*
        ///hPal: HPALETTE->HPALETTE__*
        ///bForceBkgd: BOOL->int
        [DllImport("gdi32.dll", EntryPoint = "SelectPalette")]
        public static extern IntPtr SelectPalette([In] IntPtr hdc, [In] IntPtr hPal, [MarshalAs(UnmanagedType.Bool)] bool bForceBkgd);


        /// Return Type: HGDIOBJ->void*
        ///hdc: HDC->HDC__*
        ///h: HGDIOBJ->void*
        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
        public static extern IntPtr SelectObject([In] IntPtr hdc, [In] IntPtr h);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImport("gdi32.dll", EntryPoint = "SelectClipRgn")]
        public static extern int SelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///mode: int
        [DllImport("gdi32.dll", EntryPoint = "SelectClipPath")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SelectClipPath([In] IntPtr hdc, int mode);


        /// Return Type: int
        ///nfds: int
        ///readfds: fd_set*
        ///writefds: fd_set*
        ///exceptfds: fd_set*
        ///timeout: timeval*
        [DllImport("ws2_32.dll", EntryPoint = "select", CallingConvention = CallingConvention.StdCall)]
        public static extern int select(int nfds, ref fd_set readfds, ref fd_set writefds, ref fd_set exceptfds, ref timeval timeout);


        /// Return Type: DWORD->unsigned int
        ///lpPath: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpExtension: LPCWSTR->WCHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///lpFilePart: LPWSTR*
        [DllImport("kernel32.dll", EntryPoint = "SearchPathW")]
        public static extern uint SearchPathW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPath, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExtension, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, ref IntPtr lpFilePart);


        /// Return Type: DWORD->unsigned int
        ///lpPath: LPCSTR->CHAR*
        ///lpFileName: LPCSTR->CHAR*
        ///lpExtension: LPCSTR->CHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///lpFilePart: LPSTR*
        [DllImport("kernel32.dll", EntryPoint = "SearchPathA")]
        public static extern uint SearchPathA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPath, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpExtension, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, ref IntPtr lpFilePart);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///dx: int
        ///dy: int
        ///prcScroll: RECT*
        ///prcClip: RECT*
        ///hrgnUpdate: HRGN->HRGN__*
        ///prcUpdate: LPRECT->tagRECT*
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ScrollWindowEx")]
        public static extern int ScrollWindowEx([In] IntPtr hWnd, int dx, int dy, [In] IntPtr prcScroll, [In] IntPtr prcClip, [In] IntPtr hrgnUpdate, IntPtr prcUpdate, uint flags);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///XAmount: int
        ///YAmount: int
        ///lpRect: RECT*
        ///lpClipRect: RECT*
        [DllImport("user32.dll", EntryPoint = "ScrollWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollWindow([In] IntPtr hWnd, int XAmount, int YAmount, [In] IntPtr lpRect, [In] IntPtr lpClipRect);


        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///dx: int
        ///dy: int
        ///lprcScroll: RECT*
        ///lprcClip: RECT*
        ///hrgnUpdate: HRGN->HRGN__*
        ///lprcUpdate: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "ScrollDC")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollDC([In] IntPtr hDC, int dx, int dy, [In] IntPtr lprcScroll, [In] IntPtr lprcClip, [In] IntPtr hrgnUpdate, IntPtr lprcUpdate);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpScrollRectangle: SMALL_RECT*
        ///lpClipRectangle: SMALL_RECT*
        ///dwDestinationOrigin: COORD->_COORD
        ///lpFill: CHAR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "ScrollConsoleScreenBufferW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollConsoleScreenBufferW(IntPtr hConsoleOutput, ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, ref CHAR_INFO lpFill);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpScrollRectangle: SMALL_RECT*
        ///lpClipRectangle: SMALL_RECT*
        ///dwDestinationOrigin: COORD->_COORD
        ///lpFill: CHAR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "ScrollConsoleScreenBufferA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollConsoleScreenBufferA(IntPtr hConsoleOutput, ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin, ref CHAR_INFO lpFill);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "ScreenToClient")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScreenToClient([In] IntPtr hWnd, ref Point lpPoint);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///JobId: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ScheduleJob")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScheduleJob([In] IntPtr hPrinter, uint JobId);


        /// Return Type: LONG->int
        ///param0: LPOPENCARDNAME_EXW->Anonymous_6c2723be_0edc_4918_9e7d_6b4764899e3e*
        [DllImport("<Unknown>", EntryPoint = "SCardUIDlgSelectCardW")]
        public static extern int SCardUIDlgSelectCardW(ref OPENCARDNAME_EXW param0);


        /// Return Type: LONG->int
        ///param0: LPOPENCARDNAME_EXA->Anonymous_60bbc11a_66f3_4167_86b7_b82b311976b7*
        [DllImport("<Unknown>", EntryPoint = "SCardUIDlgSelectCardA")]
        public static extern int SCardUIDlgSelectCardA(ref OPENCARDNAME_EXA param0);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///pioSendPci: LPCSCARD_IO_REQUEST->SCARD_IO_REQUEST*
        ///pbSendBuffer: LPCBYTE->BYTE*
        ///cbSendLength: DWORD->unsigned int
        ///pioRecvPci: LPSCARD_IO_REQUEST->_SCARD_IO_REQUEST*
        ///pbRecvBuffer: LPBYTE->BYTE*
        ///pcbRecvLength: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardTransmit")]
        public static extern int SCardTransmit(uint hCard, ref SCARD_IO_REQUEST pioSendPci, ref byte pbSendBuffer, uint cbSendLength, ref SCARD_IO_REQUEST pioRecvPci, ref byte pbRecvBuffer, ref uint pcbRecvLength);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///szReaderName: LPWSTR->WCHAR*
        ///pcchReaderLen: LPDWORD->DWORD*
        ///pdwState: LPDWORD->DWORD*
        ///pdwProtocol: LPDWORD->DWORD*
        ///pbAtr: LPBYTE->BYTE*
        ///pcbAtrLen: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardStatusW")]
        public static extern int SCardStatusW(uint hCard, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szReaderName, ref uint pcchReaderLen, ref uint pdwState, ref uint pdwProtocol, ref byte pbAtr, ref uint pcbAtrLen);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///szReaderName: LPSTR->CHAR*
        ///pcchReaderLen: LPDWORD->DWORD*
        ///pdwState: LPDWORD->DWORD*
        ///pdwProtocol: LPDWORD->DWORD*
        ///pbAtr: LPBYTE->BYTE*
        ///pcbAtrLen: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardStatusA")]
        public static extern int SCardStatusA(uint hCard, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szReaderName, ref uint pcchReaderLen, ref uint pdwState, ref uint pdwProtocol, ref byte pbAtr, ref uint pcbAtrLen);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///pdwState: LPDWORD->DWORD*
        ///pdwProtocol: LPDWORD->DWORD*
        ///pbAtr: LPBYTE->BYTE*
        ///pcbAtrLen: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardState")]
        public static extern int SCardState(uint hCard, ref uint pdwState, ref uint pdwProtocol, ref byte pbAtr, ref uint pcbAtrLen);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCWSTR->WCHAR*
        ///dwProviderId: DWORD->unsigned int
        ///szProvider: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardSetCardTypeProviderNameW")]
        public static extern int SCardSetCardTypeProviderNameW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCardName, uint dwProviderId, [In] [MarshalAs(UnmanagedType.LPWStr)] string szProvider);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCSTR->CHAR*
        ///dwProviderId: DWORD->unsigned int
        ///szProvider: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardSetCardTypeProviderNameA")]
        public static extern int SCardSetCardTypeProviderNameA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szCardName, uint dwProviderId, [In] [MarshalAs(UnmanagedType.LPStr)] string szProvider);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///dwAttrId: DWORD->unsigned int
        ///pbAttr: LPCBYTE->BYTE*
        ///cbAttrLen: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardSetAttrib")]
        public static extern int SCardSetAttrib(uint hCard, uint dwAttrId, ref byte pbAttr, uint cbAttrLen);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCWSTR->WCHAR*
        ///szGroupName: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardRemoveReaderFromGroupW")]
        public static extern int SCardRemoveReaderFromGroupW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szReaderName, [In] [MarshalAs(UnmanagedType.LPWStr)] string szGroupName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCSTR->CHAR*
        ///szGroupName: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardRemoveReaderFromGroupA")]
        public static extern int SCardRemoveReaderFromGroupA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szReaderName, [In] [MarshalAs(UnmanagedType.LPStr)] string szGroupName);


        /// Return Type: void
        [DllImport("winscard.dll", EntryPoint = "SCardReleaseStartedEvent")]
        public static extern void SCardReleaseStartedEvent();


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardReleaseContext")]
        public static extern int SCardReleaseContext(uint hContext);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///dwPreferredProtocols: DWORD->unsigned int
        ///dwInitialization: DWORD->unsigned int
        ///pdwActiveProtocol: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardReconnect")]
        public static extern int SCardReconnect(uint hCard, uint dwShareMode, uint dwPreferredProtocols, uint dwInitialization, ref uint pdwActiveProtocol);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///mszCards: LPCWSTR->WCHAR*
        ///rgReaderStates: LPSCARD_READERSTATEW->Anonymous_32a6444e_bb16_41f5_852f_253df321f0d9*
        ///cReaders: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardLocateCardsW")]
        public static extern int SCardLocateCardsW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string mszCards, ref SCARD_READERSTATEW rgReaderStates, uint cReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///rgAtrMasks: LPSCARD_ATRMASK->_SCARD_ATRMASK*
        ///cAtrs: DWORD->unsigned int
        ///rgReaderStates: LPSCARD_READERSTATEW->Anonymous_32a6444e_bb16_41f5_852f_253df321f0d9*
        ///cReaders: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardLocateCardsByATRW")]
        public static extern int SCardLocateCardsByATRW(uint hContext, ref SCARD_ATRMASK rgAtrMasks, uint cAtrs, ref SCARD_READERSTATEW rgReaderStates, uint cReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///rgAtrMasks: LPSCARD_ATRMASK->_SCARD_ATRMASK*
        ///cAtrs: DWORD->unsigned int
        ///rgReaderStates: LPSCARD_READERSTATEA->Anonymous_43358639_5d92_4dde_add7_e5422ca1791e*
        ///cReaders: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardLocateCardsByATRA")]
        public static extern int SCardLocateCardsByATRA(uint hContext, ref SCARD_ATRMASK rgAtrMasks, uint cAtrs, ref SCARD_READERSTATEA rgReaderStates, uint cReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///mszCards: LPCSTR->CHAR*
        ///rgReaderStates: LPSCARD_READERSTATEA->Anonymous_43358639_5d92_4dde_add7_e5422ca1791e*
        ///cReaders: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardLocateCardsA")]
        public static extern int SCardLocateCardsA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string mszCards, ref SCARD_READERSTATEA rgReaderStates, uint cReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///mszGroups: LPCWSTR->WCHAR*
        ///mszReaders: LPWSTR->WCHAR*
        ///pcchReaders: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListReadersW")]
        public static extern int SCardListReadersW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string mszGroups, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder mszReaders, ref uint pcchReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///mszGroups: LPCSTR->CHAR*
        ///mszReaders: LPSTR->CHAR*
        ///pcchReaders: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListReadersA")]
        public static extern int SCardListReadersA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string mszGroups, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder mszReaders, ref uint pcchReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///mszGroups: LPWSTR->WCHAR*
        ///pcchGroups: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListReaderGroupsW")]
        public static extern int SCardListReaderGroupsW(uint hContext, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder mszGroups, ref uint pcchGroups);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///mszGroups: LPSTR->CHAR*
        ///pcchGroups: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListReaderGroupsA")]
        public static extern int SCardListReaderGroupsA(uint hContext, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder mszGroups, ref uint pcchGroups);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCard: LPCWSTR->WCHAR*
        ///pguidInterfaces: LPGUID->GUID*
        ///pcguidInterfaces: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListInterfacesW")]
        public static extern int SCardListInterfacesW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCard, ref GUID pguidInterfaces, ref uint pcguidInterfaces);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCard: LPCSTR->CHAR*
        ///pguidInterfaces: LPGUID->GUID*
        ///pcguidInterfaces: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListInterfacesA")]
        public static extern int SCardListInterfacesA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szCard, ref GUID pguidInterfaces, ref uint pcguidInterfaces);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///pbAtr: LPCBYTE->BYTE*
        ///rgquidInterfaces: LPCGUID->GUID*
        ///cguidInterfaceCount: DWORD->unsigned int
        ///mszCards: LPWSTR->WCHAR*
        ///pcchCards: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListCardsW")]
        public static extern int SCardListCardsW(uint hContext, ref byte pbAtr, ref GUID rgquidInterfaces, uint cguidInterfaceCount, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder mszCards, ref uint pcchCards);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///pbAtr: LPCBYTE->BYTE*
        ///rgquidInterfaces: LPCGUID->GUID*
        ///cguidInterfaceCount: DWORD->unsigned int
        ///mszCards: LPSTR->CHAR*
        ///pcchCards: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardListCardsA")]
        public static extern int SCardListCardsA(uint hContext, ref byte pbAtr, ref GUID rgquidInterfaces, uint cguidInterfaceCount, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder mszCards, ref uint pcchCards);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardIsValidContext")]
        public static extern int SCardIsValidContext(uint hContext);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCWSTR->WCHAR*
        ///szDeviceName: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardIntroduceReaderW")]
        public static extern int SCardIntroduceReaderW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szReaderName, [In] [MarshalAs(UnmanagedType.LPWStr)] string szDeviceName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szGroupName: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardIntroduceReaderGroupW")]
        public static extern int SCardIntroduceReaderGroupW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szGroupName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szGroupName: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardIntroduceReaderGroupA")]
        public static extern int SCardIntroduceReaderGroupA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szGroupName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCSTR->CHAR*
        ///szDeviceName: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardIntroduceReaderA")]
        public static extern int SCardIntroduceReaderA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szReaderName, [In] [MarshalAs(UnmanagedType.LPStr)] string szDeviceName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCWSTR->WCHAR*
        ///pguidPrimaryProvider: LPCGUID->GUID*
        ///rgguidInterfaces: LPCGUID->GUID*
        ///dwInterfaceCount: DWORD->unsigned int
        ///pbAtr: LPCBYTE->BYTE*
        ///pbAtrMask: LPCBYTE->BYTE*
        ///cbAtrLen: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardIntroduceCardTypeW")]
        public static extern int SCardIntroduceCardTypeW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCardName, ref GUID pguidPrimaryProvider, ref GUID rgguidInterfaces, uint dwInterfaceCount, ref byte pbAtr, ref byte pbAtrMask, uint cbAtrLen);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCSTR->CHAR*
        ///pguidPrimaryProvider: LPCGUID->GUID*
        ///rgguidInterfaces: LPCGUID->GUID*
        ///dwInterfaceCount: DWORD->unsigned int
        ///pbAtr: LPCBYTE->BYTE*
        ///pbAtrMask: LPCBYTE->BYTE*
        ///cbAtrLen: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardIntroduceCardTypeA")]
        public static extern int SCardIntroduceCardTypeA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szCardName, ref GUID pguidPrimaryProvider, ref GUID rgguidInterfaces, uint dwInterfaceCount, ref byte pbAtr, ref byte pbAtrMask, uint cbAtrLen);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///rgReaderStates: LPSCARD_READERSTATEW->Anonymous_32a6444e_bb16_41f5_852f_253df321f0d9*
        ///cReaders: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardGetStatusChangeW")]
        public static extern int SCardGetStatusChangeW(uint hContext, uint dwTimeout, ref SCARD_READERSTATEW rgReaderStates, uint cReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///rgReaderStates: LPSCARD_READERSTATEA->Anonymous_43358639_5d92_4dde_add7_e5422ca1791e*
        ///cReaders: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardGetStatusChangeA")]
        public static extern int SCardGetStatusChangeA(uint hContext, uint dwTimeout, ref SCARD_READERSTATEA rgReaderStates, uint cReaders);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCard: LPCWSTR->WCHAR*
        ///pguidProviderId: LPGUID->GUID*
        [DllImport("winscard.dll", EntryPoint = "SCardGetProviderIdW")]
        public static extern int SCardGetProviderIdW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCard, ref GUID pguidProviderId);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCard: LPCSTR->CHAR*
        ///pguidProviderId: LPGUID->GUID*
        [DllImport("winscard.dll", EntryPoint = "SCardGetProviderIdA")]
        public static extern int SCardGetProviderIdA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szCard, ref GUID pguidProviderId);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCWSTR->WCHAR*
        ///dwProviderId: DWORD->unsigned int
        ///szProvider: LPWSTR->WCHAR*
        ///pcchProvider: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardGetCardTypeProviderNameW")]
        public static extern int SCardGetCardTypeProviderNameW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCardName, uint dwProviderId, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szProvider, ref uint pcchProvider);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCSTR->CHAR*
        ///dwProviderId: DWORD->unsigned int
        ///szProvider: LPSTR->CHAR*
        ///pcchProvider: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardGetCardTypeProviderNameA")]
        public static extern int SCardGetCardTypeProviderNameA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szCardName, uint dwProviderId, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szProvider, ref uint pcchProvider);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///dwAttrId: DWORD->unsigned int
        ///pbAttr: LPBYTE->BYTE*
        ///pcbAttrLen: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardGetAttrib")]
        public static extern int SCardGetAttrib(uint hCard, uint dwAttrId, ref byte pbAttr, ref uint pcbAttrLen);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///pvMem: LPCVOID->void*
        [DllImport("winscard.dll", EntryPoint = "SCardFreeMemory")]
        public static extern int SCardFreeMemory(uint hContext, IntPtr pvMem);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardForgetReaderW")]
        public static extern int SCardForgetReaderW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szReaderName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szGroupName: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardForgetReaderGroupW")]
        public static extern int SCardForgetReaderGroupW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szGroupName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szGroupName: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardForgetReaderGroupA")]
        public static extern int SCardForgetReaderGroupA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szGroupName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardForgetReaderA")]
        public static extern int SCardForgetReaderA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szReaderName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardForgetCardTypeW")]
        public static extern int SCardForgetCardTypeW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCardName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szCardName: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardForgetCardTypeA")]
        public static extern int SCardForgetCardTypeA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szCardName);


        /// Return Type: LONG->int
        ///dwScope: DWORD->unsigned int
        ///pvReserved1: LPCVOID->void*
        ///pvReserved2: LPCVOID->void*
        ///phContext: LPSCARDCONTEXT->SCARDCONTEXT*
        [DllImport("winscard.dll", EntryPoint = "SCardEstablishContext")]
        public static extern int SCardEstablishContext(uint dwScope, IntPtr pvReserved1, IntPtr pvReserved2, ref uint phContext);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///dwDisposition: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardEndTransaction")]
        public static extern int SCardEndTransaction(uint hCard, uint dwDisposition);


        /// Return Type: LONG->int
        [DllImport("<Unknown>", EntryPoint = "SCardDlgExtendedError")]
        public static extern int SCardDlgExtendedError();


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///dwDisposition: DWORD->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardDisconnect")]
        public static extern int SCardDisconnect(uint hCard, uint dwDisposition);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        ///dwControlCode: DWORD->unsigned int
        ///lpInBuffer: LPCVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesReturned: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardControl")]
        public static extern int SCardControl(uint hCard, uint dwControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReader: LPCWSTR->WCHAR*
        ///dwShareMode: DWORD->unsigned int
        ///dwPreferredProtocols: DWORD->unsigned int
        ///phCard: LPSCARDHANDLE->SCARDHANDLE*
        ///pdwActiveProtocol: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardConnectW")]
        public static extern int SCardConnectW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szReader, uint dwShareMode, uint dwPreferredProtocols, ref uint phCard, ref uint pdwActiveProtocol);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReader: LPCSTR->CHAR*
        ///dwShareMode: DWORD->unsigned int
        ///dwPreferredProtocols: DWORD->unsigned int
        ///phCard: LPSCARDHANDLE->SCARDHANDLE*
        ///pdwActiveProtocol: LPDWORD->DWORD*
        [DllImport("winscard.dll", EntryPoint = "SCardConnectA")]
        public static extern int SCardConnectA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szReader, uint dwShareMode, uint dwPreferredProtocols, ref uint phCard, ref uint pdwActiveProtocol);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        [DllImport("<Unknown>", EntryPoint = "SCardCancelTransaction")]
        public static extern int SCardCancelTransaction(uint hCard);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardCancel")]
        public static extern int SCardCancel(uint hContext);


        /// Return Type: LONG->int
        ///hCard: SCARDHANDLE->ULONG_PTR->unsigned int
        [DllImport("winscard.dll", EntryPoint = "SCardBeginTransaction")]
        public static extern int SCardBeginTransaction(uint hCard);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCWSTR->WCHAR*
        ///szGroupName: LPCWSTR->WCHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardAddReaderToGroupW")]
        public static extern int SCardAddReaderToGroupW(uint hContext, [In] [MarshalAs(UnmanagedType.LPWStr)] string szReaderName, [In] [MarshalAs(UnmanagedType.LPWStr)] string szGroupName);


        /// Return Type: LONG->int
        ///hContext: SCARDCONTEXT->ULONG_PTR->unsigned int
        ///szReaderName: LPCSTR->CHAR*
        ///szGroupName: LPCSTR->CHAR*
        [DllImport("winscard.dll", EntryPoint = "SCardAddReaderToGroupA")]
        public static extern int SCardAddReaderToGroupA(uint hContext, [In] [MarshalAs(UnmanagedType.LPStr)] string szReaderName, [In] [MarshalAs(UnmanagedType.LPStr)] string szGroupName);


        /// Return Type: HANDLE->void*
        [DllImport("winscard.dll", EntryPoint = "SCardAccessStartedEvent")]
        public static extern IntPtr SCardAccessStartedEvent();


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///xn: int
        ///xd: int
        ///yn: int
        ///yd: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "ScaleWindowExtEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScaleWindowExtEx([In] IntPtr hdc, int xn, int xd, int yn, int yd, IntPtr lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///xn: int
        ///dx: int
        ///yn: int
        ///yd: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "ScaleViewportExtEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScaleViewportExtEx([In] IntPtr hdc, int xn, int dx, int yn, int yd, IntPtr lpsz);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "SaveDC")]
        public static extern int SaveDC([In] IntPtr hdc);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayUnlock", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayUnlock(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayUnaccessData", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayUnaccessData(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///prinfo: IRecordInfo*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArraySetRecordInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArraySetRecordInfo(ref tagSAFEARRAY psa, ref IRecordInfo prinfo);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///guid: GUID*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArraySetIID", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArraySetIID(ref tagSAFEARRAY psa, ref GUID guid);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///psaboundNew: SAFEARRAYBOUND*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayRedim", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayRedim(ref tagSAFEARRAY psa, ref tagSAFEARRAYBOUND psaboundNew);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///rgIndices: LONG*
        ///pv: void*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayPutElement", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayPutElement(ref tagSAFEARRAY psa, ref int rgIndices, IntPtr pv);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///rgIndices: LONG*
        ///ppvData: void**
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayPtrOfIndex", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayPtrOfIndex(ref tagSAFEARRAY psa, ref int rgIndices, ref IntPtr ppvData);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayLock", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayLock(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///pvt: VARTYPE*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetVartype", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayGetVartype(ref tagSAFEARRAY psa, ref ushort pvt);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///nDim: UINT->unsigned int
        ///plUbound: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetUBound", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayGetUBound(ref tagSAFEARRAY psa, uint nDim, ref int plUbound);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///prinfo: IRecordInfo**
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetRecordInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayGetRecordInfo(ref tagSAFEARRAY psa, ref IntPtr prinfo);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///nDim: UINT->unsigned int
        ///plLbound: LONG*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetLBound", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayGetLBound(ref tagSAFEARRAY psa, uint nDim, ref int plLbound);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///pguid: GUID*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetIID", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayGetIID(ref tagSAFEARRAY psa, ref GUID pguid);


        /// Return Type: UINT->unsigned int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetElemsize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SafeArrayGetElemsize(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///rgIndices: LONG*
        ///pv: void*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetElement", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayGetElement(ref tagSAFEARRAY psa, ref int rgIndices, IntPtr pv);


        /// Return Type: UINT->unsigned int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayGetDim", CallingConvention = CallingConvention.StdCall)]
        public static extern uint SafeArrayGetDim(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayDestroyDescriptor", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayDestroyDescriptor(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayDestroyData", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayDestroyData(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayDestroy", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayDestroy(ref tagSAFEARRAY psa);


        /// Return Type: SAFEARRAY*
        ///vt: VARTYPE->unsigned short
        ///lLbound: LONG->int
        ///cElements: ULONG->unsigned int
        ///pvExtra: PVOID->void*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayCreateVectorEx", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SafeArrayCreateVectorEx(ushort vt, int lLbound, uint cElements, IntPtr pvExtra);


        /// Return Type: SAFEARRAY*
        ///vt: VARTYPE->unsigned short
        ///lLbound: LONG->int
        ///cElements: ULONG->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayCreateVector", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SafeArrayCreateVector(ushort vt, int lLbound, uint cElements);


        /// Return Type: SAFEARRAY*
        ///vt: VARTYPE->unsigned short
        ///cDims: UINT->unsigned int
        ///rgsabound: SAFEARRAYBOUND*
        ///pvExtra: PVOID->void*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayCreateEx", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SafeArrayCreateEx(ushort vt, uint cDims, ref tagSAFEARRAYBOUND rgsabound, IntPtr pvExtra);


        /// Return Type: SAFEARRAY*
        ///vt: VARTYPE->unsigned short
        ///cDims: UINT->unsigned int
        ///rgsabound: SAFEARRAYBOUND*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayCreate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SafeArrayCreate(ushort vt, uint cDims, ref tagSAFEARRAYBOUND rgsabound);


        /// Return Type: HRESULT->LONG->int
        ///psaSource: SAFEARRAY*
        ///psaTarget: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayCopyData", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayCopyData(ref tagSAFEARRAY psaSource, ref tagSAFEARRAY psaTarget);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///ppsaOut: SAFEARRAY**
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayCopy", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayCopy(ref tagSAFEARRAY psa, ref IntPtr ppsaOut);


        /// Return Type: HRESULT->LONG->int
        ///vt: VARTYPE->unsigned short
        ///cDims: UINT->unsigned int
        ///ppsaOut: SAFEARRAY**
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayAllocDescriptorEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayAllocDescriptorEx(ushort vt, uint cDims, ref IntPtr ppsaOut);


        /// Return Type: HRESULT->LONG->int
        ///cDims: UINT->unsigned int
        ///ppsaOut: SAFEARRAY**
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayAllocDescriptor", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayAllocDescriptor(uint cDims, ref IntPtr ppsaOut);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayAllocData", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayAllocData(ref tagSAFEARRAY psa);


        /// Return Type: HRESULT->LONG->int
        ///psa: SAFEARRAY*
        ///ppvData: void**
        [DllImport("oleaut32.dll", EntryPoint = "SafeArrayAccessData", CallingConvention = CallingConvention.StdCall)]
        public static extern int SafeArrayAccessData(ref tagSAFEARRAY psa, ref IntPtr ppvData);

    }

}
