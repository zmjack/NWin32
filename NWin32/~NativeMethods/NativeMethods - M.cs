using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEW->_NETRESOURCEW*
        ///lpNetConnectInfoStruct: LPNETCONNECTINFOSTRUCT->_NETCONNECTINFOSTRUCT*
        [DllImport("mpr.dll", EntryPoint = "MultinetGetConnectionPerformanceW")]
        public static extern uint MultinetGetConnectionPerformanceW(ref NETRESOURCEW lpNetResource, ref NETCONNECTINFOSTRUCT lpNetConnectInfoStruct);


        /// Return Type: DWORD->unsigned int
        ///lpNetResource: LPNETRESOURCEA->_NETRESOURCEA*
        ///lpNetConnectInfoStruct: LPNETCONNECTINFOSTRUCT->_NETCONNECTINFOSTRUCT*
        [DllImport("mpr.dll", EntryPoint = "MultinetGetConnectionPerformanceA")]
        public static extern uint MultinetGetConnectionPerformanceA(ref NETRESOURCEA lpNetResource, ref NETCONNECTINFOSTRUCT lpNetConnectInfoStruct);


        /// Return Type: int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpMultiByteStr: LPCSTR->CHAR*
        ///cbMultiByte: int
        ///lpWideCharStr: LPWSTR->WCHAR*
        ///cchWideChar: int
        [DllImport("kernel32.dll", EntryPoint = "MultiByteToWideChar")]
        public static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpMultiByteStr, int cbMultiByte, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpWideCharStr, int cchWideChar);


        /// Return Type: int
        ///nNumber: int
        ///nNumerator: int
        ///nDenominator: int
        [DllImport("kernel32.dll", EntryPoint = "MulDiv")]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);


        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///pHandles: HANDLE*
        ///dwMilliseconds: DWORD->unsigned int
        ///dwWakeMask: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjectsEx")]
        public static extern uint MsgWaitForMultipleObjectsEx(uint nCount, ref IntPtr pHandles, uint dwMilliseconds, uint dwWakeMask, uint dwFlags);


        /// Return Type: DWORD->unsigned int
        ///nCount: DWORD->unsigned int
        ///pHandles: HANDLE*
        ///fWaitAll: BOOL->int
        ///dwMilliseconds: DWORD->unsigned int
        ///dwWakeMask: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MsgWaitForMultipleObjects")]
        public static extern uint MsgWaitForMultipleObjects(uint nCount, ref IntPtr pHandles, [MarshalAs(UnmanagedType.Bool)] bool fWaitAll, uint dwMilliseconds, uint dwWakeMask);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///bRepaint: BOOL->int
        [DllImport("user32.dll", EntryPoint = "MoveWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow([In] IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [MarshalAs(UnmanagedType.Bool)] bool bRepaint);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "MoveToEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveToEx([In] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileWithProgressW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileWithProgressW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileWithProgressA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileWithProgressA([In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "MoveFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MoveFileExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, uint dwFlags);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "MoveFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName);


        /// Return Type: void
        ///dwFlags: DWORD->unsigned int
        ///dx: DWORD->unsigned int
        ///dy: DWORD->unsigned int
        ///dwData: DWORD->unsigned int
        ///dwExtraInfo: ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInfo);


        /// Return Type: HMONITOR->HMONITOR__*
        ///hwnd: HWND->HWND__*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MonitorFromWindow")]
        public static extern IntPtr MonitorFromWindow([In] IntPtr hwnd, uint dwFlags);


        /// Return Type: HMONITOR->HMONITOR__*
        ///lprc: LPCRECT->RECT*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MonitorFromRect")]
        public static extern IntPtr MonitorFromRect([In] ref tagRECT lprc, uint dwFlags);


        /// Return Type: HMONITOR->HMONITOR__*
        ///pt: POINT->tagPOINT
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "MonitorFromPoint")]
        public static extern IntPtr MonitorFromPoint(Point pt, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///pmkSrc: LPMONIKER->IMoniker*
        ///pmkDest: LPMONIKER->IMoniker*
        ///ppmkRelPath: LPMONIKER*
        ///dwReserved: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "MonikerRelativePathTo", CallingConvention = CallingConvention.StdCall)]
        public static extern int MonikerRelativePathTo(ref IMoniker pmkSrc, ref IMoniker pmkDest, ref IntPtr ppmkRelPath, [MarshalAs(UnmanagedType.Bool)] bool dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pmkThis: LPMONIKER->IMoniker*
        ///pmkOther: LPMONIKER->IMoniker*
        ///ppmkCommon: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "MonikerCommonPrefixWith", CallingConvention = CallingConvention.StdCall)]
        public static extern int MonikerCommonPrefixWith(ref IMoniker pmkThis, ref IMoniker pmkOther, ref IntPtr ppmkCommon);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpxf: XFORM*
        ///mode: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "ModifyWorldTransform")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ModifyWorldTransform([In] IntPtr hdc, [In] IntPtr lpxf, uint mode);


        /// Return Type: BOOL->int
        ///hMnu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "ModifyMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ModifyMenuW([In] IntPtr hMnu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uIDNewItem, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewItem);


        /// Return Type: BOOL->int
        ///hMnu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        ///uIDNewItem: UINT_PTR->unsigned int
        ///lpNewItem: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "ModifyMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ModifyMenuA([In] IntPtr hMnu, uint uPosition, uint uFlags, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr uIDNewItem, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewItem);


        /// Return Type: LONG->int
        ///hmmio: HMMIO->HMMIO__*
        ///pch: char*
        ///cch: LONG->int
        [DllImport("winmm.dll", EntryPoint = "mmioWrite")]
        public static extern int mmioWrite(IntPtr hmmio, [In] [MarshalAs(UnmanagedType.LPStr)] string pch, int cch);


        /// Return Type: FOURCC->DWORD->unsigned int
        ///sz: LPCWSTR->WCHAR*
        ///uFlags: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioStringToFOURCCW")]
        public static extern uint mmioStringToFOURCCW([In] [MarshalAs(UnmanagedType.LPWStr)] string sz, uint uFlags);


        /// Return Type: FOURCC->DWORD->unsigned int
        ///sz: LPCSTR->CHAR*
        ///uFlags: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioStringToFOURCCA")]
        public static extern uint mmioStringToFOURCCA([In] [MarshalAs(UnmanagedType.LPStr)] string sz, uint uFlags);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///pmmioinfo: LPCMMIOINFO->MMIOINFO*
        ///fuInfo: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioSetInfo")]
        public static extern uint mmioSetInfo(IntPtr hmmio, ref MMIOINFO pmmioinfo, uint fuInfo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///pchBuffer: LPSTR->CHAR*
        ///cchBuffer: LONG->int
        ///fuBuffer: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioSetBuffer")]
        public static extern uint mmioSetBuffer(IntPtr hmmio, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pchBuffer, int cchBuffer, uint fuBuffer);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hmmio: HMMIO->HMMIO__*
        ///uMsg: UINT->unsigned int
        ///lParam1: LPARAM->LONG_PTR->int
        ///lParam2: LPARAM->LONG_PTR->int
        [DllImport("winmm.dll", EntryPoint = "mmioSendMessage")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr mmioSendMessage(IntPtr hmmio, uint uMsg, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam1, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam2);


        /// Return Type: LONG->int
        ///hmmio: HMMIO->HMMIO__*
        ///lOffset: LONG->int
        ///iOrigin: int
        [DllImport("winmm.dll", EntryPoint = "mmioSeek")]
        public static extern int mmioSeek(IntPtr hmmio, int lOffset, int iOrigin);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///pszFileName: LPCWSTR->WCHAR*
        ///pszNewFileName: LPCWSTR->WCHAR*
        ///pmmioinfo: LPCMMIOINFO->MMIOINFO*
        ///fdwRename: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioRenameW")]
        public static extern uint mmioRenameW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszNewFileName, ref MMIOINFO pmmioinfo, uint fdwRename);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///pszFileName: LPCSTR->CHAR*
        ///pszNewFileName: LPCSTR->CHAR*
        ///pmmioinfo: LPCMMIOINFO->MMIOINFO*
        ///fdwRename: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioRenameA")]
        public static extern uint mmioRenameA([In] [MarshalAs(UnmanagedType.LPStr)] string pszFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string pszNewFileName, ref MMIOINFO pmmioinfo, uint fdwRename);


        /// Return Type: LONG->int
        ///hmmio: HMMIO->HMMIO__*
        ///pch: HPSTR->char*
        ///cch: LONG->int
        [DllImport("winmm.dll", EntryPoint = "mmioRead")]
        public static extern int mmioRead(IntPtr hmmio, IntPtr pch, int cch);


        /// Return Type: HMMIO->HMMIO__*
        ///pszFileName: LPWSTR->WCHAR*
        ///pmmioinfo: LPMMIOINFO->_MMIOINFO*
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioOpenW")]
        public static extern IntPtr mmioOpenW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszFileName, ref MMIOINFO pmmioinfo, uint fdwOpen);


        /// Return Type: HMMIO->HMMIO__*
        ///pszFileName: LPSTR->CHAR*
        ///pmmioinfo: LPMMIOINFO->_MMIOINFO*
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioOpenA")]
        public static extern IntPtr mmioOpenA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszFileName, ref MMIOINFO pmmioinfo, uint fdwOpen);


        /// Return Type: LPMMIOPROC->MMIOPROC*
        ///fccIOProc: FOURCC->DWORD->unsigned int
        ///pIOProc: LPMMIOPROC->MMIOPROC*
        ///dwFlags: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioInstallIOProcW")]
        public static extern IntPtr mmioInstallIOProcW(uint fccIOProc, ref MMIOPROC pIOProc, uint dwFlags);


        /// Return Type: LPMMIOPROC->MMIOPROC*
        ///fccIOProc: FOURCC->DWORD->unsigned int
        ///pIOProc: LPMMIOPROC->MMIOPROC*
        ///dwFlags: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioInstallIOProcA")]
        public static extern IntPtr mmioInstallIOProcA(uint fccIOProc, ref MMIOPROC pIOProc, uint dwFlags);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///pmmioinfo: LPMMIOINFO->_MMIOINFO*
        ///fuInfo: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioGetInfo")]
        public static extern uint mmioGetInfo(IntPtr hmmio, ref MMIOINFO pmmioinfo, uint fuInfo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///fuFlush: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioFlush")]
        public static extern uint mmioFlush(IntPtr hmmio, uint fuFlush);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///pmmcki: LPMMCKINFO->_MMCKINFO*
        ///pmmckiParent: MMCKINFO*
        ///fuDescend: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioDescend")]
        public static extern uint mmioDescend(IntPtr hmmio, ref MMCKINFO pmmcki, ref MMCKINFO pmmckiParent, uint fuDescend);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///pmmcki: LPMMCKINFO->_MMCKINFO*
        ///fuCreate: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioCreateChunk")]
        public static extern uint mmioCreateChunk(IntPtr hmmio, ref MMCKINFO pmmcki, uint fuCreate);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///fuClose: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioClose")]
        public static extern uint mmioClose(IntPtr hmmio, uint fuClose);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///pmmcki: LPMMCKINFO->_MMCKINFO*
        ///fuAscend: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioAscend")]
        public static extern uint mmioAscend(IntPtr hmmio, ref MMCKINFO pmmcki, uint fuAscend);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmmio: HMMIO->HMMIO__*
        ///pmmioinfo: LPMMIOINFO->_MMIOINFO*
        ///fuAdvance: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mmioAdvance")]
        public static extern uint mmioAdvance(IntPtr hmmio, ref MMIOINFO pmmioinfo, uint fuAdvance);


        /// Return Type: HRESULT->LONG->int
        ///pbc: IBindCtx*
        ///szDisplayName: LPCWSTR->WCHAR*
        ///pchEaten: ULONG*
        ///ppmk: LPMONIKER*
        [DllImport("urlmon.dll", EntryPoint = "MkParseDisplayNameEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int MkParseDisplayNameEx(ref IBindCtx pbc, [In] [MarshalAs(UnmanagedType.LPWStr)] string szDisplayName, ref uint pchEaten, ref IntPtr ppmk);


        /// Return Type: HRESULT->LONG->int
        ///pbc: LPBC->IBindCtx*
        ///szUserName: LPCOLESTR->OLECHAR*
        ///pchEaten: ULONG*
        ///ppmk: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "MkParseDisplayName", CallingConvention = CallingConvention.StdCall)]
        public static extern int MkParseDisplayName(ref IBindCtx pbc, [In] [MarshalAs(UnmanagedType.LPWStr)] string szUserName, ref uint pchEaten, ref IntPtr ppmk);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///pmxcd: LPMIXERCONTROLDETAILS->tMIXERCONTROLDETAILS*
        ///fdwDetails: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerSetControlDetails")]
        public static extern uint mixerSetControlDetails(IntPtr hmxobj, ref tMIXERCONTROLDETAILS pmxcd, uint fdwDetails);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///phmx: LPHMIXER->HMIXER*
        ///uMxId: UINT->unsigned int
        ///dwCallback: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwInstance: DWORD_PTR->ULONG_PTR->unsigned int
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerOpen")]
        public static extern uint mixerOpen(ref IntPtr phmx, uint uMxId, uint dwCallback, uint dwInstance, uint fdwOpen);


        /// Return Type: DWORD->unsigned int
        ///hmx: HMIXER->HMIXER__*
        ///uMsg: UINT->unsigned int
        ///dwParam1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwParam2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerMessage")]
        public static extern uint mixerMessage(IntPtr hmx, uint uMsg, uint dwParam1, uint dwParam2);


        /// Return Type: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetNumDevs")]
        public static extern uint mixerGetNumDevs();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///pmxl: LPMIXERLINEW->tagMIXERLINEW*
        ///fdwInfo: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetLineInfoW")]
        public static extern uint mixerGetLineInfoW(IntPtr hmxobj, ref tagMIXERLINEW pmxl, uint fdwInfo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///pmxl: LPMIXERLINEA->tagMIXERLINEA*
        ///fdwInfo: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetLineInfoA")]
        public static extern uint mixerGetLineInfoA(IntPtr hmxobj, ref tagMIXERLINEA pmxl, uint fdwInfo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///pmxlc: LPMIXERLINECONTROLSW->tagMIXERLINECONTROLSW*
        ///fdwControls: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetLineControlsW")]
        public static extern uint mixerGetLineControlsW(IntPtr hmxobj, ref tagMIXERLINECONTROLSW pmxlc, uint fdwControls);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///pmxlc: LPMIXERLINECONTROLSA->tagMIXERLINECONTROLSA*
        ///fdwControls: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetLineControlsA")]
        public static extern uint mixerGetLineControlsA(IntPtr hmxobj, ref tagMIXERLINECONTROLSA pmxlc, uint fdwControls);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///puMxId: UINT*
        ///fdwId: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetID")]
        public static extern uint mixerGetID(IntPtr hmxobj, ref uint puMxId, uint fdwId);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uMxId: UINT_PTR->unsigned int
        ///pmxcaps: LPMIXERCAPSW->tagMIXERCAPSW*
        ///cbmxcaps: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetDevCapsW")]
        public static extern uint mixerGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uMxId, ref tagMIXERCAPSW pmxcaps, uint cbmxcaps);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uMxId: UINT_PTR->unsigned int
        ///pmxcaps: LPMIXERCAPSA->tagMIXERCAPSA*
        ///cbmxcaps: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetDevCapsA")]
        public static extern uint mixerGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uMxId, ref tagMIXERCAPSA pmxcaps, uint cbmxcaps);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///pmxcd: LPMIXERCONTROLDETAILS->tMIXERCONTROLDETAILS*
        ///fdwDetails: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetControlDetailsW")]
        public static extern uint mixerGetControlDetailsW(IntPtr hmxobj, ref tMIXERCONTROLDETAILS pmxcd, uint fdwDetails);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmxobj: HMIXEROBJ->HMIXEROBJ__*
        ///pmxcd: LPMIXERCONTROLDETAILS->tMIXERCONTROLDETAILS*
        ///fdwDetails: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mixerGetControlDetailsA")]
        public static extern uint mixerGetControlDetailsA(IntPtr hmxobj, ref tMIXERCONTROLDETAILS pmxcd, uint fdwDetails);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmx: HMIXER->HMIXER__*
        [DllImport("winmm.dll", EntryPoint = "mixerClose")]
        public static extern uint mixerClose(IntPtr hmx);


        /// Return Type: void
        ///param0: void*
        [DllImport("<Unknown>", EntryPoint = "MIDL_user_free", CallingConvention = CallingConvention.StdCall)]
        public static extern void MIDL_user_free(IntPtr param0);


        /// Return Type: void*
        ///param0: size_t->unsigned int
        [DllImport("<Unknown>", EntryPoint = "MIDL_user_allocate", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MIDL_user_allocate([MarshalAs(UnmanagedType.SysUInt)] UIntPtr param0);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hms: HMIDISTRM->HMIDISTRM__*
        [DllImport("winmm.dll", EntryPoint = "midiStreamStop")]
        public static extern uint midiStreamStop(IntPtr hms);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hms: HMIDISTRM->HMIDISTRM__*
        [DllImport("winmm.dll", EntryPoint = "midiStreamRestart")]
        public static extern uint midiStreamRestart(IntPtr hms);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hms: HMIDISTRM->HMIDISTRM__*
        ///lppropdata: LPBYTE->BYTE*
        ///dwProperty: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiStreamProperty")]
        public static extern uint midiStreamProperty(IntPtr hms, ref byte lppropdata, uint dwProperty);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hms: HMIDISTRM->HMIDISTRM__*
        ///lpmmt: LPMMTIME->mmtime_tag*
        ///cbmmt: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiStreamPosition")]
        public static extern uint midiStreamPosition(IntPtr hms, ref mmtime_tag lpmmt, uint cbmmt);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hms: HMIDISTRM->HMIDISTRM__*
        [DllImport("winmm.dll", EntryPoint = "midiStreamPause")]
        public static extern uint midiStreamPause(IntPtr hms);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hms: HMIDISTRM->HMIDISTRM__*
        ///pmh: LPMIDIHDR->midihdr_tag*
        ///cbmh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiStreamOut")]
        public static extern uint midiStreamOut(IntPtr hms, ref midihdr_tag pmh, uint cbmh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///phms: LPHMIDISTRM->HMIDISTRM*
        ///puDeviceID: LPUINT->UINT*
        ///cMidi: DWORD->unsigned int
        ///dwCallback: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwInstance: DWORD_PTR->ULONG_PTR->unsigned int
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiStreamOpen")]
        public static extern uint midiStreamOpen(ref IntPtr phms, ref uint puDeviceID, uint cMidi, uint dwCallback, uint dwInstance, uint fdwOpen);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hms: HMIDISTRM->HMIDISTRM__*
        [DllImport("winmm.dll", EntryPoint = "midiStreamClose")]
        public static extern uint midiStreamClose(IntPtr hms);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///pmh: LPMIDIHDR->midihdr_tag*
        ///cbmh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutUnprepareHeader")]
        public static extern uint midiOutUnprepareHeader(IntPtr hmo, ref midihdr_tag pmh, uint cbmh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///dwMsg: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutShortMsg")]
        public static extern uint midiOutShortMsg(IntPtr hmo, uint dwMsg);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///dwVolume: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutSetVolume")]
        public static extern uint midiOutSetVolume(IntPtr hmo, uint dwVolume);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        [DllImport("winmm.dll", EntryPoint = "midiOutReset")]
        public static extern uint midiOutReset(IntPtr hmo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///pmh: LPMIDIHDR->midihdr_tag*
        ///cbmh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutPrepareHeader")]
        public static extern uint midiOutPrepareHeader(IntPtr hmo, ref midihdr_tag pmh, uint cbmh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///phmo: LPHMIDIOUT->HMIDIOUT*
        ///uDeviceID: UINT->unsigned int
        ///dwCallback: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwInstance: DWORD_PTR->ULONG_PTR->unsigned int
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutOpen")]
        public static extern uint midiOutOpen(ref IntPtr phmo, uint uDeviceID, uint dwCallback, uint dwInstance, uint fdwOpen);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///uMsg: UINT->unsigned int
        ///dw1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dw2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutMessage")]
        public static extern uint midiOutMessage(IntPtr hmo, uint uMsg, uint dw1, uint dw2);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///pmh: LPMIDIHDR->midihdr_tag*
        ///cbmh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutLongMsg")]
        public static extern uint midiOutLongMsg(IntPtr hmo, ref midihdr_tag pmh, uint cbmh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///pdwVolume: LPDWORD->DWORD*
        [DllImport("winmm.dll", EntryPoint = "midiOutGetVolume")]
        public static extern uint midiOutGetVolume(IntPtr hmo, ref uint pdwVolume);


        /// Return Type: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutGetNumDevs")]
        public static extern uint midiOutGetNumDevs();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///puDeviceID: LPUINT->UINT*
        [DllImport("winmm.dll", EntryPoint = "midiOutGetID")]
        public static extern uint midiOutGetID(IntPtr hmo, ref uint puDeviceID);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPWSTR->WCHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutGetErrorTextW")]
        public static extern uint midiOutGetErrorTextW(uint mmrError, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPSTR->CHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutGetErrorTextA")]
        public static extern uint midiOutGetErrorTextA(uint mmrError, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pmoc: LPMIDIOUTCAPSW->tagMIDIOUTCAPSW*
        ///cbmoc: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutGetDevCapsW")]
        public static extern uint midiOutGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagMIDIOUTCAPSW pmoc, uint cbmoc);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pmoc: LPMIDIOUTCAPSA->tagMIDIOUTCAPSA*
        ///cbmoc: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutGetDevCapsA")]
        public static extern uint midiOutGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagMIDIOUTCAPSA pmoc, uint cbmoc);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        [DllImport("winmm.dll", EntryPoint = "midiOutClose")]
        public static extern uint midiOutClose(IntPtr hmo);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///uBank: UINT->unsigned int
        ///pwpa: LPWORD->WORD*
        ///fuCache: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutCachePatches")]
        public static extern uint midiOutCachePatches(IntPtr hmo, uint uBank, ref ushort pwpa, uint fuCache);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///uPatch: UINT->unsigned int
        ///pwkya: LPWORD->WORD*
        ///fuCache: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiOutCacheDrumPatches")]
        public static extern uint midiOutCacheDrumPatches(IntPtr hmo, uint uPatch, ref ushort pwkya, uint fuCache);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        ///pmh: LPMIDIHDR->midihdr_tag*
        ///cbmh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInUnprepareHeader")]
        public static extern uint midiInUnprepareHeader(IntPtr hmi, ref midihdr_tag pmh, uint cbmh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        [DllImport("winmm.dll", EntryPoint = "midiInStop")]
        public static extern uint midiInStop(IntPtr hmi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        [DllImport("winmm.dll", EntryPoint = "midiInStart")]
        public static extern uint midiInStart(IntPtr hmi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        [DllImport("winmm.dll", EntryPoint = "midiInReset")]
        public static extern uint midiInReset(IntPtr hmi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        ///pmh: LPMIDIHDR->midihdr_tag*
        ///cbmh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInPrepareHeader")]
        public static extern uint midiInPrepareHeader(IntPtr hmi, ref midihdr_tag pmh, uint cbmh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///phmi: LPHMIDIIN->HMIDIIN*
        ///uDeviceID: UINT->unsigned int
        ///dwCallback: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwInstance: DWORD_PTR->ULONG_PTR->unsigned int
        ///fdwOpen: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInOpen")]
        public static extern uint midiInOpen(ref IntPtr phmi, uint uDeviceID, uint dwCallback, uint dwInstance, uint fdwOpen);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        ///uMsg: UINT->unsigned int
        ///dw1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dw2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInMessage")]
        public static extern uint midiInMessage(IntPtr hmi, uint uMsg, uint dw1, uint dw2);


        /// Return Type: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInGetNumDevs")]
        public static extern uint midiInGetNumDevs();


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        ///puDeviceID: LPUINT->UINT*
        [DllImport("winmm.dll", EntryPoint = "midiInGetID")]
        public static extern uint midiInGetID(IntPtr hmi, ref uint puDeviceID);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPWSTR->WCHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInGetErrorTextW")]
        public static extern uint midiInGetErrorTextW(uint mmrError, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///mmrError: MMRESULT->UINT->unsigned int
        ///pszText: LPSTR->CHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInGetErrorTextA")]
        public static extern uint midiInGetErrorTextA(uint mmrError, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pmic: LPMIDIINCAPSW->tagMIDIINCAPSW*
        ///cbmic: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInGetDevCapsW")]
        public static extern uint midiInGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagMIDIINCAPSW pmic, uint cbmic);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///uDeviceID: UINT_PTR->unsigned int
        ///pmic: LPMIDIINCAPSA->tagMIDIINCAPSA*
        ///cbmic: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInGetDevCapsA")]
        public static extern uint midiInGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] UIntPtr uDeviceID, ref tagMIDIINCAPSA pmic, uint cbmic);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        [DllImport("winmm.dll", EntryPoint = "midiInClose")]
        public static extern uint midiInClose(IntPtr hmi);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDIIN->HMIDIIN__*
        ///pmh: LPMIDIHDR->midihdr_tag*
        ///cbmh: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "midiInAddBuffer")]
        public static extern uint midiInAddBuffer(IntPtr hmi, ref midihdr_tag pmh, uint cbmh);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDI->HMIDI__*
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///pReserved: LPVOID->void*
        [DllImport("winmm.dll", EntryPoint = "midiDisconnect")]
        public static extern uint midiDisconnect(IntPtr hmi, IntPtr hmo, IntPtr pReserved);


        /// Return Type: MMRESULT->UINT->unsigned int
        ///hmi: HMIDI->HMIDI__*
        ///hmo: HMIDIOUT->HMIDIOUT__*
        ///pReserved: LPVOID->void*
        [DllImport("winmm.dll", EntryPoint = "midiConnect")]
        public static extern uint midiConnect(IntPtr hmi, IntPtr hmo, IntPtr pReserved);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCWSTR->WCHAR*
        ///lpCaption: LPCWSTR->WCHAR*
        ///uType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MessageBoxW")]
        public static extern int MessageBoxW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType);


        /// Return Type: int
        ///lpmbp: MSGBOXPARAMSW*
        [DllImport("user32.dll", EntryPoint = "MessageBoxIndirectW")]
        public static extern int MessageBoxIndirectW([In] ref tagMSGBOXPARAMSW lpmbp);


        /// Return Type: int
        ///lpmbp: MSGBOXPARAMSA*
        [DllImport("user32.dll", EntryPoint = "MessageBoxIndirectA")]
        public static extern int MessageBoxIndirectA([In] ref tagMSGBOXPARAMSA lpmbp);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCWSTR->WCHAR*
        ///lpCaption: LPCWSTR->WCHAR*
        ///uType: UINT->unsigned int
        ///wLanguageId: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "MessageBoxExW")]
        public static extern int MessageBoxExW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCaption, uint uType, ushort wLanguageId);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCSTR->CHAR*
        ///lpCaption: LPCSTR->CHAR*
        ///uType: UINT->unsigned int
        ///wLanguageId: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "MessageBoxExA")]
        public static extern int MessageBoxExA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType, ushort wLanguageId);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpText: LPCSTR->CHAR*
        ///lpCaption: LPCSTR->CHAR*
        ///uType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
        public static extern int MessageBoxA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpText, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCaption, uint uType);


        /// Return Type: BOOL->int
        ///uType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MessageBeep")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(uint uType);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///ptScreen: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "MenuItemFromPoint")]
        public static extern int MenuItemFromPoint([In] IntPtr hWnd, [In] IntPtr hMenu, Point ptScreen);


        /// Return Type: void*
        ///_Dst: void*
        ///_Val: int
        ///_Size: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "memset", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr memset(IntPtr _Dst, int _Val, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: errno_t->int
        ///_Dst: void*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: void*
        ///_MaxCount: rsize_t->size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "memmove_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int memmove_s(IntPtr _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] IntPtr _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: void*
        ///_Dst: void*
        ///_Src: void*
        ///_Size: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "memmove", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr memmove(IntPtr _Dst, [In] IntPtr _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: errno_t->int
        ///_Dst: void*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_Src: void*
        ///_MaxCount: rsize_t->size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "memcpy_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int memcpy_s(IntPtr _Dst, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] IntPtr _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: void*
        ///_Dst: void*
        ///_Src: void*
        ///_Size: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr memcpy(IntPtr _Dst, [In] IntPtr _Src, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: int
        ///_Buf1: void*
        ///_Buf2: void*
        ///_Size: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "memcmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern int memcmp([In] IntPtr _Buf1, [In] IntPtr _Buf2, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: void*
        ///_Buf: void*
        ///_Val: int
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "memchr", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr memchr([In] IntPtr _Buf, int _Val, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: BOOL->int
        ///mciId: MCIDEVICEID->UINT->unsigned int
        ///fpYieldProc: YIELDPROC
        ///dwYieldData: DWORD->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mciSetYieldProc")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool mciSetYieldProc(uint mciId, YIELDPROC fpYieldProc, uint dwYieldData);


        /// Return Type: MCIERROR->DWORD->unsigned int
        ///lpstrCommand: LPCWSTR->WCHAR*
        ///lpstrReturnString: LPWSTR->WCHAR*
        ///uReturnLength: UINT->unsigned int
        ///hwndCallback: HWND->HWND__*
        [DllImport("winmm.dll", EntryPoint = "mciSendStringW")]
        public static extern uint mciSendStringW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpstrCommand, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpstrReturnString, uint uReturnLength, IntPtr hwndCallback);


        /// Return Type: MCIERROR->DWORD->unsigned int
        ///lpstrCommand: LPCSTR->CHAR*
        ///lpstrReturnString: LPSTR->CHAR*
        ///uReturnLength: UINT->unsigned int
        ///hwndCallback: HWND->HWND__*
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
        public static extern uint mciSendStringA([In] [MarshalAs(UnmanagedType.LPStr)] string lpstrCommand, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpstrReturnString, uint uReturnLength, IntPtr hwndCallback);


        /// Return Type: MCIERROR->DWORD->unsigned int
        ///mciId: MCIDEVICEID->UINT->unsigned int
        ///uMsg: UINT->unsigned int
        ///dwParam1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwParam2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mciSendCommandW")]
        public static extern uint mciSendCommandW(uint mciId, uint uMsg, uint dwParam1, uint dwParam2);


        /// Return Type: MCIERROR->DWORD->unsigned int
        ///mciId: MCIDEVICEID->UINT->unsigned int
        ///uMsg: UINT->unsigned int
        ///dwParam1: DWORD_PTR->ULONG_PTR->unsigned int
        ///dwParam2: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mciSendCommandA")]
        public static extern uint mciSendCommandA(uint mciId, uint uMsg, uint dwParam1, uint dwParam2);


        /// Return Type: YIELDPROC
        ///mciId: MCIDEVICEID->UINT->unsigned int
        ///pdwYieldData: LPDWORD->DWORD*
        [DllImport("winmm.dll", EntryPoint = "mciGetYieldProc")]
        public static extern YIELDPROC mciGetYieldProc(uint mciId, ref uint pdwYieldData);


        /// Return Type: BOOL->int
        ///mcierr: MCIERROR->DWORD->unsigned int
        ///pszText: LPWSTR->WCHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mciGetErrorStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool mciGetErrorStringW(uint mcierr, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: BOOL->int
        ///mcierr: MCIERROR->DWORD->unsigned int
        ///pszText: LPSTR->CHAR*
        ///cchText: UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mciGetErrorStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool mciGetErrorStringA(uint mcierr, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszText, uint cchText);


        /// Return Type: MCIDEVICEID->UINT->unsigned int
        ///pszDevice: LPCWSTR->WCHAR*
        [DllImport("winmm.dll", EntryPoint = "mciGetDeviceIDW")]
        public static extern uint mciGetDeviceIDW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszDevice);


        /// Return Type: MCIDEVICEID->UINT->unsigned int
        ///dwElementID: DWORD->unsigned int
        ///lpstrType: LPCWSTR->WCHAR*
        [DllImport("winmm.dll", EntryPoint = "mciGetDeviceIDFromElementIDW")]
        public static extern uint mciGetDeviceIDFromElementIDW(uint dwElementID, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpstrType);


        /// Return Type: MCIDEVICEID->UINT->unsigned int
        ///dwElementID: DWORD->unsigned int
        ///lpstrType: LPCSTR->CHAR*
        [DllImport("winmm.dll", EntryPoint = "mciGetDeviceIDFromElementIDA")]
        public static extern uint mciGetDeviceIDFromElementIDA(uint dwElementID, [In] [MarshalAs(UnmanagedType.LPStr)] string lpstrType);


        /// Return Type: MCIDEVICEID->UINT->unsigned int
        ///pszDevice: LPCSTR->CHAR*
        [DllImport("winmm.dll", EntryPoint = "mciGetDeviceIDA")]
        public static extern uint mciGetDeviceIDA([In] [MarshalAs(UnmanagedType.LPStr)] string pszDevice);


        /// Return Type: HTASK->HTASK__*
        ///mciId: MCIDEVICEID->UINT->unsigned int
        [DllImport("winmm.dll", EntryPoint = "mciGetCreatorTask")]
        public static extern IntPtr mciGetCreatorTask(uint mciId);


        /// Return Type: int
        ///_DstCh: wchar_t*
        ///_SrcCh: char*
        ///_SrcSizeInBytes: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "mbtowc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int mbtowc(IntPtr _DstCh, [In] [MarshalAs(UnmanagedType.LPStr)] string _SrcCh, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SrcSizeInBytes);


        /// Return Type: errno_t->int
        ///_PtNumOfCharConverted: size_t*
        ///_DstBuf: wchar_t*
        ///_SizeInWords: size_t->unsigned int
        ///_SrcBuf: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "mbstowcs_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int mbstowcs_s(IntPtr _PtNumOfCharConverted, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeInWords, [In] [MarshalAs(UnmanagedType.LPStr)] string _SrcBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: size_t->unsigned int
        ///_Dest: wchar_t*
        ///_Source: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("ntdll.dll", EntryPoint = "mbstowcs", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.SysUInt)]
        public static extern uint mbstowcs([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder _Dest, [In] [MarshalAs(UnmanagedType.LPStr)] string _Source, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: int
        ///_Ch: char*
        ///_MaxCount: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "mblen", CallingConvention = CallingConvention.Cdecl)]
        public static extern int mblen([In] [MarshalAs(UnmanagedType.LPStr)] string _Ch, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _MaxCount);


        /// Return Type: BOOL->int
        ///hdcDest: HDC->HDC__*
        ///xDest: int
        ///yDest: int
        ///width: int
        ///height: int
        ///hdcSrc: HDC->HDC__*
        ///xSrc: int
        ///ySrc: int
        ///hbmMask: HBITMAP->HBITMAP__*
        ///xMask: int
        ///yMask: int
        ///rop: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "MaskBlt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MaskBlt([In] IntPtr hdcDest, int xDest, int yDest, int width, int height, [In] IntPtr hdcSrc, int xSrc, int ySrc, [In] IntPtr hbmMask, int xMask, int yMask, uint rop);


        /// Return Type: int
        ///hWndFrom: HWND->HWND__*
        ///hWndTo: HWND->HWND__*
        ///lpPoints: LPPOINT->tagPOINT*
        ///cPoints: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MapWindowPoints")]
        public static extern int MapWindowPoints([In] IntPtr hWndFrom, [In] IntPtr hWndTo, IntPtr lpPoints, uint cPoints);


        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyW")]
        public static extern uint MapVirtualKeyW(uint uCode, uint uMapType);


        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyExW")]
        public static extern uint MapVirtualKeyExW(uint uCode, uint uMapType, [In] IntPtr dwhkl);


        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        ///dwhkl: HKL->HKL__*
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyExA")]
        public static extern uint MapVirtualKeyExA(uint uCode, uint uMapType, [In] IntPtr dwhkl);


        /// Return Type: UINT->unsigned int
        ///uCode: UINT->unsigned int
        ///uMapType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        public static extern uint MapVirtualKeyA(uint uCode, uint uMapType);


        /// Return Type: LPVOID->void*
        ///hFileMappingObject: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwNumberOfBytesToMap: SIZE_T->ULONG_PTR->unsigned int
        ///lpBaseAddress: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "MapViewOfFileEx")]
        public static extern IntPtr MapViewOfFileEx([In] IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap, [In] IntPtr lpBaseAddress);


        /// Return Type: LPVOID->void*
        ///hFileMappingObject: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwFileOffsetHigh: DWORD->unsigned int
        ///dwFileOffsetLow: DWORD->unsigned int
        ///dwNumberOfBytesToMap: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "MapViewOfFile")]
        public static extern IntPtr MapViewOfFile([In] IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap);


        /// Return Type: BOOL->int
        ///VirtualAddresses: PVOID*
        ///NumberOfPages: ULONG_PTR->unsigned int
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "MapUserPhysicalPagesScatter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapUserPhysicalPagesScatter([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 1)] IntPtr[] VirtualAddresses, uint NumberOfPages, [In] IntPtr PageArray);


        /// Return Type: BOOL->int
        ///VirtualAddress: PVOID->void*
        ///NumberOfPages: ULONG_PTR->unsigned int
        ///PageArray: PULONG_PTR->unsigned int*
        [DllImport("kernel32.dll", EntryPoint = "MapUserPhysicalPages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapUserPhysicalPages([In] IntPtr VirtualAddress, uint NumberOfPages, [In] IntPtr PageArray);


        /// Return Type: void
        ///AccessMask: PDWORD->DWORD*
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        [DllImport("advapi32.dll", EntryPoint = "MapGenericMask")]
        public static extern void MapGenericMask(ref uint AccessMask, [In] ref GENERIC_MAPPING GenericMapping);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "MapDialogRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapDialogRect([In] IntPtr hDlg, ref tagRECT lpRect);


        /// Return Type: void*
        ///_Size: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "malloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr malloc([MarshalAs(UnmanagedType.SysUInt)] UIntPtr _Size);


        /// Return Type: BOOL->int
        ///pAbsoluteSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///pSelfRelativeSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///lpdwBufferLength: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "MakeSelfRelativeSD")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MakeSelfRelativeSD([In] IntPtr pAbsoluteSecurityDescriptor, IntPtr pSelfRelativeSecurityDescriptor, ref uint lpdwBufferLength);


        /// Return Type: BOOL->int
        ///pSelfRelativeSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///lpdwBufferSize: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "MakeAbsoluteSD2")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MakeAbsoluteSD2(IntPtr pSelfRelativeSecurityDescriptor, ref uint lpdwBufferSize);


        /// Return Type: BOOL->int
        ///pSelfRelativeSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///pAbsoluteSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///lpdwAbsoluteSecurityDescriptorSize: LPDWORD->DWORD*
        ///pDacl: PACL->ACL*
        ///lpdwDaclSize: LPDWORD->DWORD*
        ///pSacl: PACL->ACL*
        ///lpdwSaclSize: LPDWORD->DWORD*
        ///pOwner: PSID->PVOID->void*
        ///lpdwOwnerSize: LPDWORD->DWORD*
        ///pPrimaryGroup: PSID->PVOID->void*
        ///lpdwPrimaryGroupSize: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "MakeAbsoluteSD")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MakeAbsoluteSD([In] IntPtr pSelfRelativeSecurityDescriptor, IntPtr pAbsoluteSecurityDescriptor, ref uint lpdwAbsoluteSecurityDescriptorSize, IntPtr pDacl, ref uint lpdwDaclSize, IntPtr pSacl, ref uint lpdwSaclSize, IntPtr pOwner, ref uint lpdwOwnerSize, IntPtr pPrimaryGroup, ref uint lpdwPrimaryGroupSize);

    }

}
