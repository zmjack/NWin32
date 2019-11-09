using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: int
        ///param0: _locale_t->localeinfo_struct*
        [DllImport("<Unknown>", EntryPoint = "___mb_cur_max_l_func", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ___mb_cur_max_l_func(ref localeinfo_struct param0);


        /// Return Type: int
        [DllImport("msvcr80.dll", EntryPoint = "___mb_cur_max_func", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ___mb_cur_max_func();


        /// Return Type: int
        ///param0: SOCKET->UINT_PTR->unsigned int
        ///param1: fd_set*
        [DllImport("ws2_32.dll", EntryPoint = "__WSAFDIsSet", CallingConvention = CallingConvention.StdCall)]
        public static extern int @__WSAFDIsSet([MarshalAs(UnmanagedType.SysUInt)] UIntPtr param0, ref fd_set param1);


        /// Return Type: errno_t->int
        ///_Buffer: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_ErrMsg: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "__wcserror_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int @__wcserror_s([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Buffer, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, [In] [MarshalAs(UnmanagedType.LPWStr)] string _ErrMsg);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "__wcserror", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr @__wcserror([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "__toascii", CallingConvention = CallingConvention.Cdecl)]
        public static extern int @__toascii(int _C);


        /// Return Type: int*
        [DllImport("msvcr80.dll", EntryPoint = "__sys_nerr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr @__sys_nerr();


        /// Return Type: char**
        [DllImport("msvcr80.dll", EntryPoint = "__sys_errlist", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr @__sys_errlist();


        /// Return Type: wctype_t*
        [DllImport("msvcr80.dll", EntryPoint = "__pwctype_func", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr @__pwctype_func();


        /// Return Type: short*
        [DllImport("msvcr80.dll", EntryPoint = "__pctype_func", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr @__pctype_func();


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "__iswcsymf", CallingConvention = CallingConvention.Cdecl)]
        public static extern int @__iswcsymf(ushort _C);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "__iswcsym", CallingConvention = CallingConvention.Cdecl)]
        public static extern int @__iswcsym(ushort _C);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "__iscsymf", CallingConvention = CallingConvention.Cdecl)]
        public static extern int @__iscsymf(int _C);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "__iscsym", CallingConvention = CallingConvention.Cdecl)]
        public static extern int @__iscsym(int _C);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "__isascii", CallingConvention = CallingConvention.Cdecl)]
        public static extern int @__isascii(int _C);


        /// Return Type: unsigned int*
        [DllImport("msvcr80.dll", EntryPoint = "__doserrno", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr @__doserrno();


        /// Return Type: int
        ///_Str: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wtol_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wtol_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "_wtol", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wtol([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str);


        /// Return Type: int
        ///_Str: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wtoi_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wtoi_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "_wtoi", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wtoi([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str);


        /// Return Type: double
        ///_Str: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wtof_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern double _wtof_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: double
        ///_Str: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wtof", CallingConvention = CallingConvention.Cdecl)]
        public static extern double _wtof([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str);


        /// Return Type: int
        ///_Command: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wsystem", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wsystem([In] [MarshalAs(UnmanagedType.LPWStr)] string _Command);


        /// Return Type: errno_t->int
        ///_FullPath: wchar_t*
        ///_Drive: wchar_t*
        ///_DriveSizeInWords: size_t->unsigned int
        ///_Dir: wchar_t*
        ///_DirSizeInWords: size_t->unsigned int
        ///_Filename: wchar_t*
        ///_FilenameSizeInWords: size_t->unsigned int
        ///_Ext: wchar_t*
        ///_ExtSizeInWords: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wsplitpath_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wsplitpath_s([In] [MarshalAs(UnmanagedType.LPWStr)] string _FullPath, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Drive, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DriveSizeInWords, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dir, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DirSizeInWords, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Filename, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _FilenameSizeInWords, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Ext, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _ExtSizeInWords);


        /// Return Type: void
        ///_FullPath: wchar_t*
        ///_Drive: wchar_t*
        ///_Dir: wchar_t*
        ///_Filename: wchar_t*
        ///_Ext: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wsplitpath", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _wsplitpath([In] [MarshalAs(UnmanagedType.LPWStr)] string _FullPath, IntPtr _Drive, IntPtr _Dir, IntPtr _Filename, IntPtr _Ext);


        /// Return Type: errno_t->int
        ///_Filename: wchar_t*
        ///_EnvVar: wchar_t*
        ///_ResultPath: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wsearchenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wsearchenv_s([In] [MarshalAs(UnmanagedType.LPWStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPWStr)] string _EnvVar, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _ResultPath, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords);


        /// Return Type: void
        ///_Filename: wchar_t*
        ///_EnvVar: wchar_t*
        ///_ResultPath: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wsearchenv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _wsearchenv([In] [MarshalAs(UnmanagedType.LPWStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPWStr)] string _EnvVar, IntPtr _ResultPath);


        /// Return Type: errno_t->int
        ///_Name: wchar_t*
        ///_Value: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wputenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wputenv_s([In] [MarshalAs(UnmanagedType.LPWStr)] string _Name, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Value);


        /// Return Type: int
        ///_EnvString: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wputenv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wputenv([In] [MarshalAs(UnmanagedType.LPWStr)] string _EnvString);


        /// Return Type: void
        ///_ErrMsg: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wperror", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _wperror([In] [MarshalAs(UnmanagedType.LPWStr)] string _ErrMsg);


        /// Return Type: errno_t->int
        ///_PathResult: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_Drive: wchar_t*
        ///_Dir: wchar_t*
        ///_Filename: wchar_t*
        ///_Ext: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wmakepath_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wmakepath_s([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _PathResult, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Drive, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Dir, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Ext);


        /// Return Type: void
        ///_ResultPath: wchar_t*
        ///_Drive: wchar_t*
        ///_Dir: wchar_t*
        ///_Filename: wchar_t*
        ///_Ext: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wmakepath", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _wmakepath(IntPtr _ResultPath, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Drive, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Dir, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Ext);


        /// Return Type: errno_t->int
        ///_ReturnSize: size_t*
        ///_DstBuf: wchar_t*
        ///_DstSizeInWords: size_t->unsigned int
        ///_VarName: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wgetenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wgetenv_s([Out] out uint _ReturnSize, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSizeInWords, [In] [MarshalAs(UnmanagedType.LPWStr)] string _VarName);


        /// Return Type: wchar_t*
        ///_VarName: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wgetenv", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wgetenv([In] [MarshalAs(UnmanagedType.LPWStr)] string _VarName);


        /// Return Type: wchar_t*
        ///_FullPath: wchar_t*
        ///_Path: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wfullpath", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wfullpath([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _FullPath, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Path, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords);


        /// Return Type: errno_t->int
        ///_Buffer: wchar_t**
        ///_BufferSizeInWords: size_t*
        ///_VarName: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wdupenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wdupenv_s(ref IntPtr _Buffer, IntPtr _BufferSizeInWords, [In] [MarshalAs(UnmanagedType.LPWStr)] string _VarName);


        /// Return Type: errno_t->int
        ///_SizeConverted: int*
        ///_MbCh: char*
        ///_SizeInBytes: size_t->unsigned int
        ///_WCh: wchar_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wctomb_s_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wctomb_s_l(IntPtr _SizeConverted, IntPtr _MbCh, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInBytes, char _WCh, [In] IntPtr _Locale);


        /// Return Type: int
        ///_MbCh: char*
        ///_WCh: wchar_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wctomb_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wctomb_l(IntPtr _MbCh, char _WCh, [In] IntPtr _Locale);


        /// Return Type: size_t->unsigned int
        ///_Dst: wchar_t*
        ///_Src: wchar_t*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsxfrm_l", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _wcsxfrm_l([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dst, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Str: wchar_t*
        ///_Size: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsupr_s_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsupr_s_l([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Str: wchar_t*
        ///_Size: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wcsupr_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsupr_s([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: wchar_t*
        ///_String: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsupr_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcsupr_l(IntPtr _String, [In] IntPtr _Locale);


        /// Return Type: wchar_t*
        ///_String: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "_wcsupr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcsupr(IntPtr _String);


        /// Return Type: unsigned int
        ///_Str: wchar_t*
        ///_EndPtr: wchar_t**
        ///_Radix: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcstoul_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _wcstoul_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, ref IntPtr _EndPtr, int _Radix, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_PtNumOfCharConverted: size_t*
        ///_Dst: char*
        ///_DstSizeInBytes: size_t->unsigned int
        ///_Src: wchar_t*
        ///_MaxCountInBytes: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcstombs_s_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcstombs_s_l(IntPtr _PtNumOfCharConverted, IntPtr _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSizeInBytes, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCountInBytes, [In] IntPtr _Locale);


        /// Return Type: size_t->unsigned int
        ///_Dest: char*
        ///_Source: wchar_t*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcstombs_l", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _wcstombs_l([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dest, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str: wchar_t*
        ///_EndPtr: wchar_t**
        ///_Radix: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcstol_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcstol_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, ref IntPtr _EndPtr, int _Radix, [In] IntPtr _Locale);


        /// Return Type: double
        ///_Str: wchar_t*
        ///_EndPtr: wchar_t**
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcstod_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern double _wcstod_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str, ref IntPtr _EndPtr, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Str: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_Val: wchar_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "_wcsset_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsset_s([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, char _Val);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_Val: wchar_t->unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "_wcsset", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcsset(IntPtr _Str, char _Val);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsrev", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcsrev(IntPtr _Str);


        /// Return Type: errno_t->int
        ///_Dst: wchar_t*
        ///_DstSizeInWords: size_t->unsigned int
        ///_Val: wchar_t->unsigned short
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wcsnset_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsnset_s([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSizeInWords, char _Val, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        ///_Val: wchar_t->unsigned short
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wcsnset", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcsnset([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Str, char _Val, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsnicoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsnicoll_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wcsnicoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsnicoll([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsnicmp_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsnicmp_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "_wcsnicmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsnicmp([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsncoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsncoll_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wcsncoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsncoll([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: errno_t->int
        ///_Str: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcslwr_s_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcslwr_s_l([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Str: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_wcslwr_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcslwr_s([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords);


        /// Return Type: wchar_t*
        ///_String: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcslwr_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcslwr_l(IntPtr _String, [In] IntPtr _Locale);


        /// Return Type: wchar_t*
        ///_String: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "_wcslwr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcslwr(IntPtr _String);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsicoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsicoll_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsicoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsicoll([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsicmp_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsicmp_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        [DllImport("ntdll.dll", EntryPoint = "_wcsicmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcsicmp([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2);


        /// Return Type: errno_t->int
        ///_Buf: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_ErrNum: int
        [DllImport("msvcr80.dll", EntryPoint = "_wcserror_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcserror_s([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Buf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, int _ErrNum);


        /// Return Type: wchar_t*
        ///_ErrNum: int
        [DllImport("msvcr80.dll", EntryPoint = "_wcserror", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcserror(int _ErrNum);


        /// Return Type: wchar_t*
        ///_Str: wchar_t*
        [DllImport("msvcr80.dll", EntryPoint = "_wcsdup", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _wcsdup([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str);


        /// Return Type: int
        ///_Str1: wchar_t*
        ///_Str2: wchar_t*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_wcscoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _wcscoll_l([In] [MarshalAs(UnmanagedType.LPWStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPWStr)] string _Str2, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Val: unsigned int
        ///_DstBuf: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_Radix: int
        [DllImport("msvcr80.dll", EntryPoint = "_ultow_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _ultow_s(uint _Val, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, int _Radix);


        /// Return Type: wchar_t*
        ///_Value: unsigned int
        ///_Dest: wchar_t*
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "_ultow", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _ultow(uint _Value, IntPtr _Dest, int _Radix);


        /// Return Type: errno_t->int
        ///_Val: unsigned int
        ///_DstBuf: char*
        ///_Size: size_t->unsigned int
        ///_Radix: int
        [DllImport("msvcr80.dll", EntryPoint = "_ultoa_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _ultoa_s(uint _Val, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, int _Radix);


        /// Return Type: char*
        ///_Value: unsigned int
        ///_Dest: char*
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "_ultoa", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _ultoa(uint _Value, IntPtr _Dest, int _Radix);


        /// Return Type: wint_t->unsigned short
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_towupper_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort _towupper_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: wint_t->unsigned short
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_towlower_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort _towlower_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_toupper_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _toupper_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "_toupper", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _toupper(int _C);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_tolower_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _tolower_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        [DllImport("ntdll.dll", EntryPoint = "_tolower", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _tolower(int _C);


        /// Return Type: void
        ///_Buf1: char*
        ///_Buf2: char*
        ///_SizeInBytes: int
        [DllImport("msvcr80.dll", EntryPoint = "_swab", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _swab(IntPtr _Buf1, IntPtr _Buf2, int _SizeInBytes);


        /// Return Type: size_t->unsigned int
        ///_Dst: char*
        ///_Src: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strxfrm_l", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _strxfrm_l([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dst, [In] [MarshalAs(UnmanagedType.LPStr)] string _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Str: char*
        ///_Size: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strupr_s_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strupr_s_l([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, ref localeinfo_struct _Locale);


        /// Return Type: errno_t->int
        ///_Str: char*
        ///_Size: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_strupr_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strupr_s([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: char*
        ///_String: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strupr_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strupr_l(IntPtr _String, [In] IntPtr _Locale);


        /// Return Type: char*
        ///_String: char*
        [DllImport("ntdll.dll", EntryPoint = "_strupr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strupr(IntPtr _String);


        /// Return Type: unsigned int
        ///_Str: char*
        ///_EndPtr: char**
        ///_Radix: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strtoul_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _strtoul_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, ref IntPtr _EndPtr, int _Radix, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str: char*
        ///_EndPtr: char**
        ///_Radix: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strtol_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strtol_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, ref IntPtr _EndPtr, int _Radix, [In] IntPtr _Locale);


        /// Return Type: double
        ///_Str: char*
        ///_EndPtr: char**
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strtod_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern double _strtod_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, ref IntPtr _EndPtr, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Dst: char*
        ///_DstSize: size_t->unsigned int
        ///_Value: int
        [DllImport("msvcr80.dll", EntryPoint = "_strset_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strset_s([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, int _Value);


        /// Return Type: char*
        ///_Dest: char*
        ///_Value: int
        [DllImport("msvcr80.dll", EntryPoint = "_strset", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strset(IntPtr _Dest, int _Value);


        /// Return Type: char*
        ///_Str: char*
        [DllImport("msvcr80.dll", EntryPoint = "_strrev", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strrev(IntPtr _Str);


        /// Return Type: errno_t->int
        ///_Str: char*
        ///_Size: size_t->unsigned int
        ///_Val: int
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_strnset_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strnset_s([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, int _Val, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: char*
        ///_Dest: char*
        ///_Val: int
        ///_Count: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_strnset", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strnset([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dest, int _Val, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strnicoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strnicoll_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_strnicoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strnicoll([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strnicmp_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strnicmp_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "_strnicmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strnicmp([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strncoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strncoll_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_strncoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strncoll([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: errno_t->int
        ///_Str: char*
        ///_Size: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strlwr_s_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strlwr_s_l([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_Str: char*
        ///_Size: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_strlwr_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strlwr_s([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: char*
        ///_String: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strlwr_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strlwr_l(IntPtr _String, [In] IntPtr _Locale);


        /// Return Type: char*
        ///_String: char*
        [DllImport("ntdll.dll", EntryPoint = "_strlwr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strlwr(IntPtr _String);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_stricoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _stricoll_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        [DllImport("msvcr80.dll", EntryPoint = "_stricoll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _stricoll([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_stricmp_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _stricmp_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        [DllImport("ntdll.dll", EntryPoint = "_stricmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _stricmp([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2);


        /// Return Type: errno_t->int
        ///_Buf: char*
        ///_SizeInBytes: size_t->unsigned int
        ///_ErrMsg: char*
        [DllImport("msvcr80.dll", EntryPoint = "_strerror_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strerror_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Buf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInBytes, [In] [MarshalAs(UnmanagedType.LPStr)] string _ErrMsg);


        /// Return Type: char*
        ///_ErrMsg: char*
        [DllImport("msvcr80.dll", EntryPoint = "_strerror", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strerror([In] [MarshalAs(UnmanagedType.LPStr)] string _ErrMsg);


        /// Return Type: char*
        ///_Src: char*
        [DllImport("msvcr80.dll", EntryPoint = "_strdup", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _strdup([In] [MarshalAs(UnmanagedType.LPStr)] string _Src);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_strcoll_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strcoll_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Str1: char*
        ///_Str2: char*
        [DllImport("ntdll.dll", EntryPoint = "_strcmpi", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _strcmpi([In] [MarshalAs(UnmanagedType.LPStr)] string _Str1, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str2);


        /// Return Type: errno_t->int
        ///_FullPath: char*
        ///_Drive: char*
        ///_DriveSize: size_t->unsigned int
        ///_Dir: char*
        ///_DirSize: size_t->unsigned int
        ///_Filename: char*
        ///_FilenameSize: size_t->unsigned int
        ///_Ext: char*
        ///_ExtSize: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_splitpath_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _splitpath_s([In] [MarshalAs(UnmanagedType.LPStr)] string _FullPath, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Drive, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DriveSize, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Dir, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DirSize, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Filename, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _FilenameSize, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _Ext, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _ExtSize);


        /// Return Type: void
        ///_FullPath: char*
        ///_Drive: char*
        ///_Dir: char*
        ///_Filename: char*
        ///_Ext: char*
        [DllImport("ntdll.dll", EntryPoint = "_splitpath", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _splitpath([In] [MarshalAs(UnmanagedType.LPStr)] string _FullPath, IntPtr _Drive, IntPtr _Dir, IntPtr _Filename, IntPtr _Ext);


        /// Return Type: void
        ///_Duration: unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_sleep", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _sleep(uint _Duration);


        /// Return Type: _purecall_handler
        ///_Handler: _purecall_handler
        [DllImport("msvcr80.dll", EntryPoint = "_set_purecall_handler", CallingConvention = CallingConvention.Cdecl)]
        public static extern _purecall_handler _set_purecall_handler(_purecall_handler _Handler);


        /// Return Type: _invalid_parameter_handler
        ///_Handler: _invalid_parameter_handler
        [DllImport("msvcr80.dll", EntryPoint = "_set_invalid_parameter_handler", CallingConvention = CallingConvention.Cdecl)]
        public static extern _invalid_parameter_handler _set_invalid_parameter_handler(_invalid_parameter_handler _Handler);


        /// Return Type: errno_t->int
        ///_Mode: int
        [DllImport("msvcr80.dll", EntryPoint = "_set_fmode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _set_fmode(int _Mode);


        /// Return Type: int
        ///_Mode: int
        [DllImport("msvcr80.dll", EntryPoint = "_set_error_mode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _set_error_mode(int _Mode);


        /// Return Type: errno_t->int
        ///_Value: int
        [DllImport("msvcr80.dll", EntryPoint = "_set_errno", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _set_errno(int _Value);


        /// Return Type: errno_t->int
        ///_Value: unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_set_doserrno", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _set_doserrno(uint _Value);


        /// Return Type: unsigned int
        ///_Flags: unsigned int
        ///_Mask: unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_set_abort_behavior", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _set_abort_behavior(uint _Flags, uint _Mask);


        /// Return Type: void
        ///_Mode: int
        [DllImport("msvcr80.dll", EntryPoint = "_seterrormode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _seterrormode(int _Mode);


        /// Return Type: errno_t->int
        ///_Filename: char*
        ///_EnvVar: char*
        ///_ResultPath: char*
        ///_SizeInBytes: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_searchenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _searchenv_s([In] [MarshalAs(UnmanagedType.LPStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPStr)] string _EnvVar, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _ResultPath, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInBytes);


        /// Return Type: void
        ///_Filename: char*
        ///_EnvVar: char*
        ///_ResultPath: char*
        [DllImport("msvcr80.dll", EntryPoint = "_searchenv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _searchenv([In] [MarshalAs(UnmanagedType.LPStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPStr)] string _EnvVar, IntPtr _ResultPath);


        /// Return Type: unsigned __int64
        ///Value: unsigned __int64
        ///Shift: int
        [DllImport("msvcr80.dll", EntryPoint = "_rotr64", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong _rotr64(ulong Value, int Shift);


        /// Return Type: unsigned int
        ///Value: unsigned int
        ///Shift: int
        [DllImport("msvcr80.dll", EntryPoint = "_rotr", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _rotr(uint Value, int Shift);


        /// Return Type: unsigned __int64
        ///Value: unsigned __int64
        ///Shift: int
        [DllImport("msvcr80.dll", EntryPoint = "_rotl64", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong _rotl64(ulong Value, int Shift);


        /// Return Type: unsigned int
        ///Value: unsigned int
        ///Shift: int
        [DllImport("msvcr80.dll", EntryPoint = "_rotl", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _rotl(uint Value, int Shift);


        /// Return Type: void*
        ///_Memory: void*
        ///_Count: size_t->unsigned int
        ///_Size: size_t->unsigned int
        [DllImport("<Unknown>", EntryPoint = "_recalloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _recalloc([In] IntPtr _Memory, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: errno_t->int
        ///_Name: char*
        ///_Value: char*
        [DllImport("msvcr80.dll", EntryPoint = "_putenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _putenv_s([In] [MarshalAs(UnmanagedType.LPStr)] string _Name, [In] [MarshalAs(UnmanagedType.LPStr)] string _Value);


        /// Return Type: int
        ///_EnvString: char*
        [DllImport("msvcr80.dll", EntryPoint = "_putenv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _putenv([In] [MarshalAs(UnmanagedType.LPStr)] string _EnvString);


        /// Return Type: _onexit_t
        ///_Func: _onexit_t
        [DllImport("msvcr80.dll", EntryPoint = "_onexit", CallingConvention = CallingConvention.Cdecl)]
        public static extern _onexit_t _onexit(_onexit_t _Func);


        /// Return Type: int
        ///_Buf1: void*
        ///_Buf2: void*
        ///_Size: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_memicmp_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _memicmp_l([In] IntPtr _Buf1, [In] IntPtr _Buf2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Buf1: void*
        ///_Buf2: void*
        ///_Size: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "_memicmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _memicmp([In] IntPtr _Buf1, [In] IntPtr _Buf2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: void*
        ///_Dst: void*
        ///_Src: void*
        ///_Val: int
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "_memccpy", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _memccpy(IntPtr _Dst, [In] IntPtr _Src, int _Val, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_DstCh: wchar_t*
        ///_SrcCh: char*
        ///_SrcSizeInBytes: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_mbtowc_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _mbtowc_l(IntPtr _DstCh, [In] [MarshalAs(UnmanagedType.LPStr)] string _SrcCh, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SrcSizeInBytes, [In] IntPtr _Locale);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_mbstrnlen_l", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _mbstrnlen_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_mbstrnlen", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _mbstrnlen([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_mbstrlen_l", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _mbstrlen_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: size_t->unsigned int
        ///_Str: char*
        [DllImport("msvcr80.dll", EntryPoint = "_mbstrlen", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _mbstrlen([In] [MarshalAs(UnmanagedType.LPStr)] string _Str);


        /// Return Type: errno_t->int
        ///_PtNumOfCharConverted: size_t*
        ///_DstBuf: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_SrcBuf: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_mbstowcs_s_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _mbstowcs_s_l(IntPtr _PtNumOfCharConverted, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, [In] [MarshalAs(UnmanagedType.LPStr)] string _SrcBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: size_t->unsigned int
        ///_Dest: wchar_t*
        ///_Source: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_mbstowcs_l", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _mbstowcs_l([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dest, [In] [MarshalAs(UnmanagedType.LPStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Ch: char*
        ///_MaxCount: size_t->unsigned int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_mblen_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _mblen_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Ch, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount, [In] IntPtr _Locale);


        /// Return Type: errno_t->int
        ///_PathResult: char*
        ///_Size: size_t->unsigned int
        ///_Drive: char*
        ///_Dir: char*
        ///_Filename: char*
        ///_Ext: char*
        [DllImport("msvcr80.dll", EntryPoint = "_makepath_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _makepath_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _PathResult, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [In] [MarshalAs(UnmanagedType.LPStr)] string _Drive, [In] [MarshalAs(UnmanagedType.LPStr)] string _Dir, [In] [MarshalAs(UnmanagedType.LPStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPStr)] string _Ext);


        /// Return Type: void
        ///_Path: char*
        ///_Drive: char*
        ///_Dir: char*
        ///_Filename: char*
        ///_Ext: char*
        [DllImport("msvcr80.dll", EntryPoint = "_makepath", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _makepath(IntPtr _Path, [In] [MarshalAs(UnmanagedType.LPStr)] string _Drive, [In] [MarshalAs(UnmanagedType.LPStr)] string _Dir, [In] [MarshalAs(UnmanagedType.LPStr)] string _Filename, [In] [MarshalAs(UnmanagedType.LPStr)] string _Ext);


        /// Return Type: UINT->unsigned int
        ///hFile: HFILE->int
        ///lpBuffer: LPCCH->CHAR*
        ///uBytes: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "_lwrite")]
        public static extern uint _lwrite(int hFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, uint uBytes);


        /// Return Type: errno_t->int
        ///_Val: int
        ///_DstBuf: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_Radix: int
        [DllImport("msvcr80.dll", EntryPoint = "_ltow_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _ltow_s(int _Val, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, int _Radix);


        /// Return Type: wchar_t*
        ///_Value: int
        ///_Dest: wchar_t*
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "_ltow", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _ltow(int _Value, IntPtr _Dest, int _Radix);


        /// Return Type: errno_t->int
        ///_Val: int
        ///_DstBuf: char*
        ///_Size: size_t->unsigned int
        ///_Radix: int
        [DllImport("msvcr80.dll", EntryPoint = "_ltoa_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _ltoa_s(int _Val, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, int _Radix);


        /// Return Type: char*
        ///_Value: int
        ///_Dest: char*
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "_ltoa", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _ltoa(int _Value, IntPtr _Dest, int _Radix);


        /// Return Type: unsigned int
        ///_Val: unsigned int
        ///_Shift: int
        [DllImport("msvcr80.dll", EntryPoint = "_lrotr", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _lrotr(uint _Val, int _Shift);


        /// Return Type: unsigned int
        ///_Val: unsigned int
        ///_Shift: int
        [DllImport("msvcr80.dll", EntryPoint = "_lrotl", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _lrotl(uint _Val, int _Shift);


        /// Return Type: UINT->unsigned int
        ///hFile: HFILE->int
        ///lpBuffer: LPVOID->void*
        ///uBytes: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "_lread")]
        public static extern uint _lread(int hFile, IntPtr lpBuffer, uint uBytes);


        /// Return Type: HFILE->int
        ///lpPathName: LPCSTR->CHAR*
        ///iReadWrite: int
        [DllImport("kernel32.dll", EntryPoint = "_lopen")]
        public static extern int _lopen([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, int iReadWrite);


        /// Return Type: LONG->int
        ///hFile: HFILE->int
        ///lOffset: LONG->int
        ///iOrigin: int
        [DllImport("kernel32.dll", EntryPoint = "_llseek")]
        public static extern int _llseek(int hFile, int lOffset, int iOrigin);


        /// Return Type: HFILE->int
        ///lpPathName: LPCSTR->CHAR*
        ///iAttribute: int
        [DllImport("kernel32.dll", EntryPoint = "_lcreat")]
        public static extern int _lcreat([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, int iAttribute);


        /// Return Type: HFILE->int
        ///hFile: HFILE->int
        [DllImport("kernel32.dll", EntryPoint = "_lclose")]
        public static extern int _lclose(int hFile);


        /// Return Type: errno_t->int
        ///_Val: int
        ///_DstBuf: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_Radix: int
        [DllImport("msvcr80.dll", EntryPoint = "_itow_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _itow_s(int _Val, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, int _Radix);


        /// Return Type: wchar_t*
        ///_Value: int
        ///_Dest: wchar_t*
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "_itow", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _itow(int _Value, IntPtr _Dest, int _Radix);


        /// Return Type: errno_t->int
        ///_Value: int
        ///_DstBuf: char*
        ///_Size: size_t->unsigned int
        ///_Radix: int
        [DllImport("msvcr80.dll", EntryPoint = "_itoa_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _itoa_s(int _Value, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, int _Radix);


        /// Return Type: char*
        ///_Value: int
        ///_Dest: char*
        ///_Radix: int
        [DllImport("ntdll.dll", EntryPoint = "_itoa", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _itoa(int _Value, IntPtr _Dest, int _Radix);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isxdigit_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isxdigit_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswxdigit_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswxdigit_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswupper_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswupper_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswspace_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswspace_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswpunct_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswpunct_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswprint_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswprint_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswlower_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswlower_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswgraph_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswgraph_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswdigit_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswdigit_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Type: wctype_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswctype_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswctype_l(ushort _C, ushort _Type, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswcsym_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswcsym_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswcsymf_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswcsymf_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswcntrl_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswcntrl_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswalpha_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswalpha_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: wint_t->unsigned short
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iswalnum_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iswalnum_l(ushort _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isupper_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isupper_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isspace_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isspace_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("<Unknown>", EntryPoint = "_ispunct_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _ispunct_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isprint_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isprint_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_islower_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _islower_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isleadbyte_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isleadbyte_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isgraph_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isgraph_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isdigit_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isdigit_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Type: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isctype_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isctype_l(int _C, int _Type, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Type: int
        [DllImport("msvcr80.dll", EntryPoint = "_isctype", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isctype(int _C, int _Type);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_iscntrl_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _iscntrl_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isalpha_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isalpha_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///_C: int
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_isalnum_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _isalnum_l(int _C, [In] IntPtr _Locale);


        /// Return Type: int
        ///hFile: HFILE->int
        ///lpBuffer: LPCCH->CHAR*
        ///lBytes: int
        [DllImport("kernel32.dll", EntryPoint = "_hwrite")]
        public static extern int _hwrite(int hFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBuffer, int lBytes);


        /// Return Type: int
        ///hFile: HFILE->int
        ///lpBuffer: LPVOID->void*
        ///lBytes: int
        [DllImport("kernel32.dll", EntryPoint = "_hread")]
        public static extern int _hread(int hFile, IntPtr lpBuffer, int lBytes);


        /// Return Type: errno_t->int
        ///_Value: wchar_t**
        [DllImport("msvcr80.dll", EntryPoint = "_get_wpgmptr", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_wpgmptr(ref IntPtr _Value);


        /// Return Type: errno_t->int
        ///_Value: unsigned int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_winver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_winver([Out] out uint _Value);


        /// Return Type: errno_t->int
        ///_Value: unsigned int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_winminor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_winminor([Out] out uint _Value);


        /// Return Type: errno_t->int
        ///_Value: unsigned int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_winmajor", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_winmajor([Out] out uint _Value);


        /// Return Type: _purecall_handler
        [DllImport("msvcr80.dll", EntryPoint = "_get_purecall_handler", CallingConvention = CallingConvention.Cdecl)]
        public static extern _purecall_handler _get_purecall_handler();


        /// Return Type: errno_t->int
        ///_Value: char**
        [DllImport("msvcr80.dll", EntryPoint = "_get_pgmptr", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_pgmptr(ref IntPtr _Value);


        /// Return Type: errno_t->int
        ///_Value: unsigned int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_osver", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_osver([Out] out uint _Value);


        /// Return Type: errno_t->int
        ///_Value: unsigned int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_osplatform", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_osplatform([Out] out uint _Value);


        /// Return Type: _invalid_parameter_handler
        [DllImport("msvcr80.dll", EntryPoint = "_get_invalid_parameter_handler", CallingConvention = CallingConvention.Cdecl)]
        public static extern _invalid_parameter_handler _get_invalid_parameter_handler();


        /// Return Type: errno_t->int
        ///_PMode: int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_fmode", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_fmode([Out] out int _PMode);


        /// Return Type: errno_t->int
        ///_Value: int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_errno", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_errno([Out] out int _Value);


        /// Return Type: errno_t->int
        ///_Value: unsigned int*
        [DllImport("msvcr80.dll", EntryPoint = "_get_doserrno", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _get_doserrno([Out] out uint _Value);


        /// Return Type: errno_t->int
        ///_DstBuf: char*
        ///_Size: size_t->unsigned int
        ///_Val: double
        ///_NumOfDigits: int
        [DllImport("msvcr80.dll", EntryPoint = "_gcvt_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _gcvt_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, double _Val, int _NumOfDigits);


        /// Return Type: char*
        ///_Val: double
        ///_NumOfDigits: int
        ///_DstBuf: char*
        [DllImport("msvcr80.dll", EntryPoint = "_gcvt", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _gcvt(double _Val, int _NumOfDigits, IntPtr _DstBuf);


        /// Return Type: char*
        ///_FullPath: char*
        ///_Path: char*
        ///_SizeInBytes: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_fullpath", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _fullpath([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _FullPath, [In] [MarshalAs(UnmanagedType.LPStr)] string _Path, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInBytes);


        /// Return Type: errno_t->int
        ///_DstBuf: char*
        ///_Size: size_t->unsigned int
        ///_Val: double
        ///_NumOfDec: int
        ///_PtDec: int*
        ///_PtSign: int*
        [DllImport("msvcr80.dll", EntryPoint = "_fcvt_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _fcvt_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, double _Val, int _NumOfDec, [Out] out int _PtDec, [Out] out int _PtSign);


        /// Return Type: char*
        ///_Val: double
        ///_NumOfDec: int
        ///_PtDec: int*
        ///_PtSign: int*
        [DllImport("msvcr80.dll", EntryPoint = "_fcvt", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _fcvt(double _Val, int _NumOfDec, [Out] out int _PtDec, [Out] out int _PtSign);


        /// Return Type: void
        ///_Code: int
        [DllImport("msvcr80.dll", EntryPoint = "_exit", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _exit(int _Code);


        /// Return Type: void*
        [DllImport("<Unknown>", EntryPoint = "_exception_info", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _exception_info();


        /// Return Type: unsigned int
        [DllImport("<Unknown>", EntryPoint = "_exception_code", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _exception_code();


        /// Return Type: int*
        [DllImport("msvcr80.dll", EntryPoint = "_errno", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _errno();


        /// Return Type: errno_t->int
        ///_DstBuf: char*
        ///_Size: size_t->unsigned int
        ///_Val: double
        ///_NumOfDights: int
        ///_PtDec: int*
        ///_PtSign: int*
        [DllImport("msvcr80.dll", EntryPoint = "_ecvt_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _ecvt_s([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, double _Val, int _NumOfDights, [Out] out int _PtDec, [Out] out int _PtSign);


        /// Return Type: char*
        ///_Val: double
        ///_NumOfDigits: int
        ///_PtDec: int*
        ///_PtSign: int*
        [DllImport("msvcr80.dll", EntryPoint = "_ecvt", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _ecvt(double _Val, int _NumOfDigits, [Out] out int _PtDec, [Out] out int _PtSign);


        /// Return Type: errno_t->int
        ///_PBuffer: char**
        ///_PBufferSizeInBytes: size_t*
        ///_VarName: char*
        [DllImport("msvcr80.dll", EntryPoint = "_dupenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _dupenv_s(ref IntPtr _PBuffer, IntPtr _PBufferSizeInBytes, [In] [MarshalAs(UnmanagedType.LPStr)] string _VarName);


        /// Return Type: unsigned short
        ///_Short: unsigned short
        [DllImport("msvcr80.dll", EntryPoint = "_byteswap_ushort", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort _byteswap_ushort(ushort _Short);


        /// Return Type: unsigned int
        ///_Long: unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_byteswap_ulong", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint _byteswap_ulong(uint _Long);


        /// Return Type: void
        ///_Frequency: unsigned int
        ///_Duration: unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_beep", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _beep(uint _Frequency, uint _Duration);


        /// Return Type: int
        ///_Str: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_atol_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atol_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Result: _LDOUBLE*
        ///_Str: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_atoldbl_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atoldbl_l([Out] out Anonymous_f9dda5b1_c4ff_4afd_8bff_3d1faaaf5d0c _Result, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Result: _LDOUBLE*
        ///_Str: char*
        [DllImport("msvcr80.dll", EntryPoint = "_atoldbl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atoldbl([Out] out Anonymous_f9dda5b1_c4ff_4afd_8bff_3d1faaaf5d0c _Result, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str);


        /// Return Type: int
        ///_Str: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_atoi_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atoi_l([In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: double
        ///_String: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_atof_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern double _atof_l([In] [MarshalAs(UnmanagedType.LPStr)] string _String, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Result: _CRT_FLOAT*
        ///_Str: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_atoflt_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atoflt_l([Out] out Anonymous_2a548e1e_0ffc_4341_926b_8beddd8eca29 _Result, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Result: _CRT_FLOAT*
        ///_Str: char*
        [DllImport("msvcr80.dll", EntryPoint = "_atoflt", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atoflt([Out] out Anonymous_2a548e1e_0ffc_4341_926b_8beddd8eca29 _Result, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str);


        /// Return Type: int
        ///_Result: _CRT_DOUBLE*
        ///_Str: char*
        ///_Locale: _locale_t->localeinfo_struct*
        [DllImport("msvcr80.dll", EntryPoint = "_atodbl_l", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atodbl_l([Out] out Anonymous_3a310f0b_0a67_46e7_8794_44e92ad7cf48 _Result, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str, [In] IntPtr _Locale);


        /// Return Type: int
        ///_Result: _CRT_DOUBLE*
        ///_Str: char*
        [DllImport("msvcr80.dll", EntryPoint = "_atodbl", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _atodbl([Out] out Anonymous_3a310f0b_0a67_46e7_8794_44e92ad7cf48 _Result, [In] [MarshalAs(UnmanagedType.LPStr)] string _Str);


        /// Return Type: int
        ///_Func: Anonymous_238be435_467a_48ad_a30b_1282af22b1d7
        [DllImport("<Unknown>", EntryPoint = "_atexit_m_appdomain")]
        public static extern int _atexit_m_appdomain(Anonymous_238be435_467a_48ad_a30b_1282af22b1d7 _Func);


        /// Return Type: void*
        ///_Memory: void*
        ///_Count: size_t->unsigned int
        ///_Size: size_t->unsigned int
        ///_Alignment: size_t->unsigned int
        [DllImport("<Unknown>", EntryPoint = "_aligned_recalloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _aligned_recalloc([In] IntPtr _Memory, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Alignment);


        /// Return Type: void*
        ///_Memory: void*
        ///_Size: size_t->unsigned int
        ///_Alignment: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_aligned_realloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _aligned_realloc([In] IntPtr _Memory, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Alignment);


        /// Return Type: void*
        ///_Memory: void*
        ///_Count: size_t->unsigned int
        ///_Size: size_t->unsigned int
        ///_Alignment: size_t->unsigned int
        ///_Offset: size_t->unsigned int
        [DllImport("<Unknown>", EntryPoint = "_aligned_offset_recalloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _aligned_offset_recalloc([In] IntPtr _Memory, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Count, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Alignment, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Offset);


        /// Return Type: void*
        ///_Memory: void*
        ///_Size: size_t->unsigned int
        ///_Alignment: size_t->unsigned int
        ///_Offset: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_aligned_offset_realloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _aligned_offset_realloc([In] IntPtr _Memory, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Alignment, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Offset);


        /// Return Type: void*
        ///_Size: size_t->unsigned int
        ///_Alignment: size_t->unsigned int
        ///_Offset: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_aligned_offset_malloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _aligned_offset_malloc([MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Alignment, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Offset);


        /// Return Type: size_t->unsigned int
        ///_Memory: void*
        ///_Alignment: size_t->unsigned int
        ///_Offset: size_t->unsigned int
        [DllImport("<Unknown>", EntryPoint = "_aligned_msize", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint _aligned_msize([In] IntPtr _Memory, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Alignment, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Offset);


        /// Return Type: void*
        ///_Size: size_t->unsigned int
        ///_Alignment: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "_aligned_malloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr _aligned_malloc([MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Alignment);


        /// Return Type: void
        ///_Memory: void*
        [DllImport("msvcr80.dll", EntryPoint = "_aligned_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void _aligned_free(IntPtr _Memory);


        /// Return Type: int
        [DllImport("msvcr80.dll", EntryPoint = "_abnormal_termination", CallingConvention = CallingConvention.Cdecl)]
        public static extern int _abnormal_termination();

    }

}
