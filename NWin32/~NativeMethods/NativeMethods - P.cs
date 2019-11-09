using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "PulseEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PulseEvent([In] IntPtr hEvent);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImport("gdi32.dll", EntryPoint = "PtVisible")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PtVisible([In] IntPtr hdc, int x, int y);


        /// Return Type: BOOL->int
        ///hrgn: HRGN->HRGN__*
        ///x: int
        ///y: int
        [DllImport("gdi32.dll", EntryPoint = "PtInRegion")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PtInRegion([In] IntPtr hrgn, int x, int y);


        /// Return Type: BOOL->int
        ///lprc: RECT*
        ///pt: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "PtInRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PtInRect([In] ref tagRECT lprc, Point pt);


        /// Return Type: HRESULT->LONG->int
        ///pvarDest: PROPVARIANT*
        ///pvarSrc: PROPVARIANT*
        [DllImport("ole32.dll", EntryPoint = "PropVariantCopy", CallingConvention = CallingConvention.StdCall)]
        public static extern int PropVariantCopy(ref tagPROPVARIANT pvarDest, ref tagPROPVARIANT pvarSrc);


        /// Return Type: HRESULT->LONG->int
        ///pvar: PROPVARIANT*
        [DllImport("ole32.dll", EntryPoint = "PropVariantClear", CallingConvention = CallingConvention.StdCall)]
        public static extern int PropVariantClear(ref tagPROPVARIANT pvar);


        /// Return Type: HRESULT->LONG->int
        ///oszName: LPOLESTR->OLECHAR*
        ///pfmtid: FMTID*
        [DllImport("ole32.dll", EntryPoint = "PropStgNameToFmtId", CallingConvention = CallingConvention.StdCall)]
        public static extern int PropStgNameToFmtId(IntPtr oszName, ref GUID pfmtid);


        /// Return Type: INT_PTR->int
        ///param0: LPCPROPSHEETHEADERW->PROPSHEETHEADERW*
        [DllImport("comctl32.dll", EntryPoint = "PropertySheetW")]
        public static extern int PropertySheetW(ref PROPSHEETHEADERW param0);


        /// Return Type: INT_PTR->int
        ///param0: LPCPROPSHEETHEADERA->PROPSHEETHEADERA*
        [DllImport("comctl32.dll", EntryPoint = "PropertySheetA")]
        public static extern int PropertySheetA(ref PROPSHEETHEADERA param0);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///lplpszProgID: LPOLESTR*
        [DllImport("ole32.dll", EntryPoint = "ProgIDFromCLSID", CallingConvention = CallingConvention.StdCall)]
        public static extern int ProgIDFromCLSID(ref GUID clsid, ref IntPtr lplpszProgID);


        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        ///pSessionId: DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ProcessIdToSessionId")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ProcessIdToSessionId(uint dwProcessId, [Out] out uint pSessionId);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///ServiceName: LPCWSTR->WCHAR*
        ///ClientToken: HANDLE->void*
        ///Privileges: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///AccessGranted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "PrivilegedServiceAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrivilegedServiceAuditAlarmW([In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName, [In] [MarshalAs(UnmanagedType.LPWStr)] string ServiceName, [In] IntPtr ClientToken, [In] ref PRIVILEGE_SET Privileges, [MarshalAs(UnmanagedType.Bool)] bool AccessGranted);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///ServiceName: LPCSTR->CHAR*
        ///ClientToken: HANDLE->void*
        ///Privileges: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///AccessGranted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "PrivilegedServiceAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrivilegedServiceAuditAlarmA([In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName, [In] [MarshalAs(UnmanagedType.LPStr)] string ServiceName, [In] IntPtr ClientToken, [In] ref PRIVILEGE_SET Privileges, [MarshalAs(UnmanagedType.Bool)] bool AccessGranted);


        /// Return Type: BOOL->int
        ///ClientToken: HANDLE->void*
        ///RequiredPrivileges: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///pfResult: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "PrivilegeCheck")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrivilegeCheck([In] IntPtr ClientToken, ref PRIVILEGE_SET RequiredPrivileges, [Out] out int pfResult);


        /// Return Type: UINT->unsigned int
        ///szFileName: LPCWSTR->WCHAR*
        ///nIconIndex: int
        ///cxIcon: int
        ///cyIcon: int
        ///phicon: HICON*
        ///piconid: UINT*
        ///nIcons: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PrivateExtractIconsW")]
        public static extern uint PrivateExtractIconsW([In] [MarshalAs(UnmanagedType.LPWStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, ref IntPtr phicon, IntPtr piconid, uint nIcons, uint flags);


        /// Return Type: UINT->unsigned int
        ///szFileName: LPCSTR->CHAR*
        ///nIconIndex: int
        ///cxIcon: int
        ///cyIcon: int
        ///phicon: HICON*
        ///piconid: UINT*
        ///nIcons: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PrivateExtractIconsA")]
        public static extern uint PrivateExtractIconsA([In] [MarshalAs(UnmanagedType.LPStr)] string szFileName, int nIconIndex, int cxIcon, int cyIcon, ref IntPtr phicon, IntPtr piconid, uint nIcons, uint flags);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///hdcBlt: HDC->HDC__*
        ///nFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PrintWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintWindow([In] IntPtr hwnd, [In] IntPtr hdcBlt, uint nFlags);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hPrinter: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "PrinterProperties")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrinterProperties([In] IntPtr hWnd, [In] IntPtr hPrinter);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///Error: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///pText: LPWSTR->WCHAR*
        ///pCaption: LPWSTR->WCHAR*
        ///dwType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "PrinterMessageBoxW")]
        public static extern uint PrinterMessageBoxW([In] IntPtr hPrinter, uint Error, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string pText, [In] [MarshalAs(UnmanagedType.LPWStr)] string pCaption, uint dwType);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///Error: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///pText: LPSTR->CHAR*
        ///pCaption: LPSTR->CHAR*
        ///dwType: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "PrinterMessageBoxA")]
        public static extern uint PrinterMessageBoxA([In] IntPtr hPrinter, uint Error, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string pText, [In] [MarshalAs(UnmanagedType.LPStr)] string pCaption, uint dwType);


        /// Return Type: BOOL->int
        ///param0: LPPRINTDLGW->tagPDW*
        [DllImport("comdlg32.dll", EntryPoint = "PrintDlgW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintDlgW(ref tagPDW param0);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPPRINTDLGEXW->tagPDEXW*
        [DllImport("comdlg32.dll", EntryPoint = "PrintDlgExW")]
        public static extern int PrintDlgExW(ref tagPDEXW param0);


        /// Return Type: HRESULT->LONG->int
        ///param0: LPPRINTDLGEXA->tagPDEXA*
        [DllImport("comdlg32.dll", EntryPoint = "PrintDlgExA")]
        public static extern int PrintDlgExA(ref tagPDEXA param0);


        /// Return Type: BOOL->int
        ///param0: LPPRINTDLGA->tagPDA*
        [DllImport("comdlg32.dll", EntryPoint = "PrintDlgA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintDlgA(ref tagPDA param0);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwOperation: DWORD->unsigned int
        ///bImmediate: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "PrepareTape")]
        public static extern uint PrepareTape([In] IntPtr hDevice, uint dwOperation, [MarshalAs(UnmanagedType.Bool)] bool bImmediate);


        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostThreadMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostThreadMessageW(uint idThread, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostThreadMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostThreadMessageA(uint idThread, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: void
        ///nExitCode: int
        [DllImport("user32.dll", EntryPoint = "PostQuitMessage")]
        public static extern void PostQuitMessage(int nExitCode);


        /// Return Type: BOOL->int
        ///CompletionPort: HANDLE->void*
        ///dwNumberOfBytesTransferred: DWORD->unsigned int
        ///dwCompletionKey: ULONG_PTR->unsigned int
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "PostQueuedCompletionStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostQueuedCompletionStatus([In] IntPtr CompletionPort, uint dwNumberOfBytesTransferred, uint dwCompletionKey, [In] IntPtr lpOverlapped);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessageW([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "PostMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessageA([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///ppt: POLYTEXTW*
        ///nstrings: int
        [DllImport("gdi32.dll", EntryPoint = "PolyTextOutW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolyTextOutW([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPOLYTEXTW[] ppt, int nstrings);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///ppt: POLYTEXTA*
        ///nstrings: int
        [DllImport("gdi32.dll", EntryPoint = "PolyTextOutA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolyTextOutA([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] tagPOLYTEXTA[] ppt, int nstrings);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///asz: DWORD*
        ///csz: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "PolyPolyline")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolyPolyline([In] IntPtr hdc, [In] ref Point apt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 3)] uint[] asz, uint csz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///asz: INT*
        ///csz: int
        [DllImport("gdi32.dll", EntryPoint = "PolyPolygon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolyPolygon([In] IntPtr hdc, [In] ref Point apt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4, SizeParamIndex = 3)] int[] asz, int csz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "PolylineTo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolylineTo([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: int
        [DllImport("gdi32.dll", EntryPoint = "Polyline")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Polyline([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, int cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: int
        [DllImport("gdi32.dll", EntryPoint = "Polygon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Polygon([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, int cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///aj: BYTE*
        ///cpt: int
        [DllImport("gdi32.dll", EntryPoint = "PolyDraw")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolyDraw([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] Point[] apt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1, SizeParamIndex = 3)] byte[] aj, int cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "PolyBezierTo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolyBezierTo([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///apt: POINT*
        ///cpt: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "PolyBezier")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PolyBezier([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] Point[] apt, uint cpt);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///lpPoint: POINT*
        ///hdcSrc: HDC->HDC__*
        ///xSrc: int
        ///ySrc: int
        ///width: int
        ///height: int
        ///hbmMask: HBITMAP->HBITMAP__*
        ///xMask: int
        ///yMask: int
        [DllImport("gdi32.dll", EntryPoint = "PlgBlt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PlgBlt([In] IntPtr hdcDest, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeConst = 3)] Point[] lpPoint, [In] IntPtr hdcSrc, int xSrc, int ySrc, int width, int height, [In] IntPtr hbmMask, int xMask, int yMask);


        /// Return Type: BOOL->int
        ///pszSound: LPCWSTR->WCHAR*
        ///hmod: HMODULE->HINSTANCE->HINSTANCE__*
        ///fdwSound: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "PlaySoundW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PlaySoundW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszSound, IntPtr hmod, uint fdwSound);


        /// Return Type: BOOL->int
        ///pszSound: LPCSTR->CHAR*
        ///hmod: HMODULE->HINSTANCE->HINSTANCE__*
        ///fdwSound: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "PlaySoundA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PlaySoundA([In] [MarshalAs(UnmanagedType.LPStr)] string pszSound, IntPtr hmod, uint fdwSound);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpHandleTable: LPHANDLETABLE->tagHANDLETABLE*
        ///lpMR: LPMETARECORD->tagMETARECORD*
        ///noObjs: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "PlayMetaFileRecord")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PlayMetaFileRecord([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] tagHANDLETABLE[] lpHandleTable, [In] ref tagMETARECORD lpMR, uint noObjs);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HMETAFILE->HMETAFILE__*
        [DllImport("gdi32.dll", EntryPoint = "PlayMetaFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PlayMetaFile([In] IntPtr hdc, [In] IntPtr hmf);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pht: LPHANDLETABLE->tagHANDLETABLE*
        ///pmr: ENHMETARECORD*
        ///cht: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "PlayEnhMetaFileRecord")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PlayEnhMetaFileRecord([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 3)] tagHANDLETABLE[] pht, [In] ref tagENHMETARECORD pmr, uint cht);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hmf: HENHMETAFILE->HENHMETAFILE__*
        ///lprect: RECT*
        [DllImport("gdi32.dll", EntryPoint = "PlayEnhMetaFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PlayEnhMetaFile([In] IntPtr hdc, [In] IntPtr hmf, [In] ref tagRECT lprect);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///left: int
        ///top: int
        ///right: int
        ///bottom: int
        ///xr1: int
        ///yr1: int
        ///xr2: int
        ///yr2: int
        [DllImport("gdi32.dll", EntryPoint = "Pie")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Pie([In] IntPtr hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);


        /// Return Type: BOOL->int
        ///pPFX: CRYPT_DATA_BLOB*
        ///szPassword: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "PFXVerifyPassword")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PFXVerifyPassword(ref CRYPT_ATTR_BLOB pPFX, [In] [MarshalAs(UnmanagedType.LPWStr)] string szPassword, uint dwFlags);


        /// Return Type: BOOL->int
        ///pPFX: CRYPT_DATA_BLOB*
        [DllImport("crypt32.dll", EntryPoint = "PFXIsPFXBlob")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PFXIsPFXBlob(ref CRYPT_ATTR_BLOB pPFX);


        /// Return Type: HCERTSTORE->void*
        ///pPFX: CRYPT_DATA_BLOB*
        ///szPassword: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "PFXImportCertStore")]
        public static extern IntPtr PFXImportCertStore(ref CRYPT_ATTR_BLOB pPFX, [In] [MarshalAs(UnmanagedType.LPWStr)] string szPassword, uint dwFlags);


        /// Return Type: BOOL->int
        ///hStore: HCERTSTORE->void*
        ///pPFX: CRYPT_DATA_BLOB*
        ///szPassword: LPCWSTR->WCHAR*
        ///pvReserved: void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "PFXExportCertStoreEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PFXExportCertStoreEx(IntPtr hStore, ref CRYPT_ATTR_BLOB pPFX, [In] [MarshalAs(UnmanagedType.LPWStr)] string szPassword, IntPtr pvReserved, uint dwFlags);


        /// Return Type: BOOL->int
        ///hStore: HCERTSTORE->void*
        ///pPFX: CRYPT_DATA_BLOB*
        ///szPassword: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "PFXExportCertStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PFXExportCertStore(IntPtr hStore, ref CRYPT_ATTR_BLOB pPFX, [In] [MarshalAs(UnmanagedType.LPWStr)] string szPassword, uint dwFlags);


        /// Return Type: void
        ///_ErrMsg: char*
        [DllImport("msvcr80.dll", EntryPoint = "perror", CallingConvention = CallingConvention.Cdecl)]
        public static extern void perror([In] [MarshalAs(UnmanagedType.LPStr)] string _ErrMsg);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///lpTotalBytesAvail: LPDWORD->DWORD*
        ///lpBytesLeftThisMessage: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekNamedPipe([In] IntPtr hNamedPipe, IntPtr lpBuffer, uint nBufferSize, IntPtr lpBytesRead, IntPtr lpTotalBytesAvail, IntPtr lpBytesLeftThisMessage);


        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        ///wRemoveMsg: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PeekMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageW([Out] out tagMSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);


        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        ///wRemoveMsg: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "PeekMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageA([Out] out tagMSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: HRGN->HRGN__*
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "PathToRegion")]
        public static extern IntPtr PathToRegion([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///w: int
        ///h: int
        ///rop: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "PatBlt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PatBlt([In] IntPtr hdc, int x, int y, int w, int h, uint rop);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImport("gdi32.dll", EntryPoint = "PaintRgn")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PaintRgn([In] IntPtr hdc, [In] IntPtr hrgn);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("user32.dll", EntryPoint = "PaintDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PaintDesktop([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///param0: LPPAGESETUPDLGW->tagPSDW*
        [DllImport("comdlg32.dll", EntryPoint = "PageSetupDlgW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PageSetupDlgW(ref tagPSDW param0);


        /// Return Type: BOOL->int
        ///param0: LPPAGESETUPDLGA->tagPSDA*
        [DllImport("comdlg32.dll", EntryPoint = "PageSetupDlgA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PageSetupDlgA(ref tagPSDA param0);


        /// Return Type: LPARAM->LONG_PTR->int
        ///msg: UINT->unsigned int
        ///uiLo: UINT_PTR->unsigned int
        ///uiHi: UINT_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "PackDDElParam")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr PackDDElParam(uint msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uiLo, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uiHi);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "PurgeComm")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PurgeComm([In] IntPtr hFile, uint dwFlags);

    }

}
