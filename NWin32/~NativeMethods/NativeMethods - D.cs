using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;
using FILETIME = NWin32.NativeTypes.FILETIME;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hExistingToken: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///lpTokenAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///ImpersonationLevel: SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
        ///TokenType: TOKEN_TYPE->_TOKEN_TYPE
        ///phNewToken: PHANDLE->HANDLE*
        [DllImport("advapi32.dll", EntryPoint = "DuplicateTokenEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DuplicateTokenEx([In] IntPtr hExistingToken, uint dwDesiredAccess, [In] IntPtr lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, out IntPtr phNewToken);


        /// Return Type: BOOL->int
        ///ExistingTokenHandle: HANDLE->void*
        ///ImpersonationLevel: SECURITY_IMPERSONATION_LEVEL->_SECURITY_IMPERSONATION_LEVEL
        ///DuplicateTokenHandle: PHANDLE->HANDLE*
        [DllImport("advapi32.dll", EntryPoint = "DuplicateToken")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DuplicateToken([In] IntPtr ExistingTokenHandle, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, out IntPtr DuplicateTokenHandle);


        /// Return Type: HICON->HICON__*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///hIcon: HICON->HICON__*
        [DllImport("shell32.dll", EntryPoint = "DuplicateIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr DuplicateIcon(IntPtr hInst, IntPtr hIcon);


        /// Return Type: BOOL->int
        ///hSourceProcessHandle: HANDLE->void*
        ///hSourceHandle: HANDLE->void*
        ///hTargetProcessHandle: HANDLE->void*
        ///lpTargetHandle: LPHANDLE->HANDLE*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwOptions: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DuplicateHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DuplicateHandle([In] IntPtr hSourceProcessHandle, [In] IntPtr hSourceHandle, [In] IntPtr hTargetProcessHandle, out IntPtr lpTargetHandle, uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwOptions);


        /// Return Type: DWORD->unsigned int
        ///SrcFileName: LPCWSTR->WCHAR*
        ///DstFileName: LPCWSTR->WCHAR*
        ///dwCreationDistribution: DWORD->unsigned int
        ///dwAttributes: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("advapi32.dll", EntryPoint = "DuplicateEncryptionInfoFile")]
        public static extern uint DuplicateEncryptionInfoFile([In] [MarshalAs(UnmanagedType.LPWStr)] string SrcFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string DstFileName, uint dwCreationDistribution, uint dwAttributes, [In] ref SECURITY_ATTRIBUTES lpSecurityAttributes);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///hDriver: HDRVR->HDRVR__*
        [DllImport("winmm.dll", EntryPoint = "DrvGetModuleHandle")]
        public static extern IntPtr DrvGetModuleHandle(IntPtr hDriver);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPCWSTR->WCHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawTextW")]
        public static extern int DrawTextW([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpchText, int cchText, ref tagRECT lprc, uint format);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPWSTR->WCHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        ///lpdtp: LPDRAWTEXTPARAMS->tagDRAWTEXTPARAMS*
        [DllImport("user32.dll", EntryPoint = "DrawTextExW")]
        public static extern int DrawTextExW([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpchText, int cchText, ref tagRECT lprc, uint format, [In] IntPtr lpdtp);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPSTR->CHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        ///lpdtp: LPDRAWTEXTPARAMS->tagDRAWTEXTPARAMS*
        [DllImport("user32.dll", EntryPoint = "DrawTextExA")]
        public static extern int DrawTextExA([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpchText, int cchText, ref tagRECT lprc, uint format, [In] IntPtr lpdtp);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpchText: LPCSTR->CHAR*
        ///cchText: int
        ///lprc: LPRECT->tagRECT*
        ///format: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawTextA")]
        public static extern int DrawTextA([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpchText, int cchText, ref tagRECT lprc, uint format);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hbrFore: HBRUSH->HBRUSH__*
        ///qfnCallBack: DRAWSTATEPROC
        ///lData: LPARAM->LONG_PTR->int
        ///wData: WPARAM->UINT_PTR->unsigned int
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawStateW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawStateW([In] IntPtr hdc, [In] IntPtr hbrFore, DRAWSTATEPROC qfnCallBack, [MarshalAs(UnmanagedType.SysInt)] IntPtr lData, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wData, int x, int y, int cx, int cy, uint uFlags);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hbrFore: HBRUSH->HBRUSH__*
        ///qfnCallBack: DRAWSTATEPROC
        ///lData: LPARAM->LONG_PTR->int
        ///wData: WPARAM->UINT_PTR->unsigned int
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawStateA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawStateA([In] IntPtr hdc, [In] IntPtr hbrFore, DRAWSTATEPROC qfnCallBack, [MarshalAs(UnmanagedType.SysInt)] IntPtr lData, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wData, int x, int y, int cx, int cy, uint uFlags);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawMenuBar([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///xLeft: int
        ///yTop: int
        ///hIcon: HICON->HICON__*
        ///cxWidth: int
        ///cyWidth: int
        ///istepIfAniCur: UINT->unsigned int
        ///hbrFlickerFreeDraw: HBRUSH->HBRUSH__*
        ///diFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawIconEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawIconEx([In] IntPtr hdc, int xLeft, int yTop, [In] IntPtr hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, [In] IntPtr hbrFlickerFreeDraw, uint diFlags);


        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///X: int
        ///Y: int
        ///hIcon: HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DrawIcon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawIcon([In] IntPtr hDC, int X, int Y, [In] IntPtr hIcon);


        /// Return Type: BOOL->int
        ///param0: HDC->HDC__*
        ///param1: LPRECT->tagRECT*
        ///param2: UINT->unsigned int
        ///param3: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawFrameControl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawFrameControl([In] IntPtr param0, ref tagRECT param1, uint param2, uint param3);


        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///lprc: RECT*
        [DllImport("user32.dll", EntryPoint = "DrawFocusRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawFocusRect([In] IntPtr hDC, [In] ref tagRECT lprc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iEscape: int
        ///cjIn: int
        ///lpIn: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "DrawEscape")]
        public static extern int DrawEscape([In] IntPtr hdc, int iEscape, int cjIn, [In] [MarshalAs(UnmanagedType.LPStr)] string lpIn);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///qrc: LPRECT->tagRECT*
        ///edge: UINT->unsigned int
        ///grfFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawEdge")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawEdge([In] IntPtr hdc, ref tagRECT qrc, uint edge, uint grfFlags);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///hdc: HDC->HDC__*
        ///lprect: RECT*
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DrawCaption")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawCaption([In] IntPtr hwnd, [In] IntPtr hdc, [In] ref tagRECT lprect, uint flags);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///idAni: int
        ///lprcFrom: RECT*
        ///lprcTo: RECT*
        [DllImport("user32.dll", EntryPoint = "DrawAnimatedRects")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawAnimatedRects([In] IntPtr hwnd, int idAni, [In] ref tagRECT lprcFrom, [In] ref tagRECT lprcTo);


        /// Return Type: BOOL->int
        ///param0: HDROP->HDROP__*
        ///param1: LPPOINT->tagPOINT*
        [DllImport("shell32.dll", EntryPoint = "DragQueryPoint", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DragQueryPoint(IntPtr param0, ref Point param1);


        /// Return Type: UINT->unsigned int
        ///param0: HDROP->HDROP__*
        ///param1: UINT->unsigned int
        ///param2: LPWSTR->WCHAR*
        ///param3: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "DragQueryFileW", CallingConvention = CallingConvention.StdCall)]
        public static extern uint DragQueryFileW(IntPtr param0, uint param1, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param2, uint param3);


        /// Return Type: UINT->unsigned int
        ///param0: HDROP->HDROP__*
        ///param1: UINT->unsigned int
        ///param2: LPSTR->CHAR*
        ///param3: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "DragQueryFileA", CallingConvention = CallingConvention.StdCall)]
        public static extern uint DragQueryFileA(IntPtr param0, uint param1, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param2, uint param3);


        /// Return Type: DWORD->unsigned int
        ///hwndParent: HWND->HWND__*
        ///hwndFrom: HWND->HWND__*
        ///fmt: UINT->unsigned int
        ///data: ULONG_PTR->unsigned int
        ///hcur: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DragObject")]
        public static extern uint DragObject([In] IntPtr hwndParent, [In] IntPtr hwndFrom, uint fmt, uint data, [In] IntPtr hcur);


        /// Return Type: void
        ///param0: HDROP->HDROP__*
        [DllImport("shell32.dll", EntryPoint = "DragFinish", CallingConvention = CallingConvention.StdCall)]
        public static extern void DragFinish(IntPtr param0);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pt: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "DragDetect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DragDetect([In] IntPtr hwnd, Point pt);


        /// Return Type: void
        ///param0: HWND->HWND__*
        ///param1: BOOL->int
        [DllImport("shell32.dll", EntryPoint = "DragAcceptFiles", CallingConvention = CallingConvention.StdCall)]
        public static extern void DragAcceptFiles(IntPtr param0, [MarshalAs(UnmanagedType.Bool)] bool param1);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        ///c: int
        [DllImport("gdi32.dll", EntryPoint = "DPtoLP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DPtoLP([In] IntPtr hdc, IntPtr lppt, int c);


        /// Return Type: INT->int
        ///wDosDate: USHORT->unsigned short
        ///wDosTime: USHORT->unsigned short
        ///pvtime: DOUBLE*
        [DllImport("oleaut32.dll", EntryPoint = "DosDateTimeToVariantTime", CallingConvention = CallingConvention.StdCall)]
        public static extern int DosDateTimeToVariantTime(ushort wDosDate, ushort wDosTime, ref double pvtime);


        /// Return Type: BOOL->int
        ///wFatDate: WORD->unsigned short
        ///wFatTime: WORD->unsigned short
        ///lpFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "DosDateTimeToFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DosDateTimeToFileTime(ushort wFatDate, ushort wFatTime, [Out] out FILETIME lpFileTime);


        /// Return Type: DWORD->unsigned int
        ///szString: LPWSTR->WCHAR*
        ///cchString: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "DoEnvironmentSubstW", CallingConvention = CallingConvention.StdCall)]
        public static extern uint DoEnvironmentSubstW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szString, uint cchString);


        /// Return Type: DWORD->unsigned int
        ///szString: LPSTR->CHAR*
        ///cchString: UINT->unsigned int
        [DllImport("shell32.dll", EntryPoint = "DoEnvironmentSubstA", CallingConvention = CallingConvention.StdCall)]
        public static extern uint DoEnvironmentSubstA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szString, uint cchString);


        /// Return Type: HRESULT->LONG->int
        ///pDataObj: LPDATAOBJECT->IDataObject*
        ///pDropSource: LPDROPSOURCE->IDropSource*
        ///dwOKEffects: DWORD->unsigned int
        ///pdwEffect: LPDWORD->DWORD*
        [DllImport("ole32.dll", EntryPoint = "DoDragDrop", CallingConvention = CallingConvention.StdCall)]
        public static extern int DoDragDrop(ref IDataObject pDataObj, ref IDropSource pDropSource, uint dwOKEffects, ref uint pdwEffect);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///hPrinter: HANDLE->void*
        ///pDeviceName: LPWSTR->WCHAR*
        ///pDevModeOutput: PDEVMODEW->_devicemodeW*
        ///pDevModeInput: PDEVMODEW->_devicemodeW*
        ///fMode: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "DocumentPropertiesW")]
        public static extern int DocumentPropertiesW([In] IntPtr hWnd, [In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pDeviceName, IntPtr pDevModeOutput, [In] IntPtr pDevModeInput, uint fMode);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///hPrinter: HANDLE->void*
        ///pDeviceName: LPSTR->CHAR*
        ///pDevModeOutput: PDEVMODEA->_devicemodeA*
        ///pDevModeInput: PDEVMODEA->_devicemodeA*
        ///fMode: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "DocumentPropertiesA")]
        public static extern int DocumentPropertiesA([In] IntPtr hWnd, [In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pDeviceName, IntPtr pDevModeOutput, [In] IntPtr pDevModeInput, uint fMode);


        /// Return Type: BOOL->int
        ///Hostname: LPCWSTR->WCHAR*
        ///ComputerName: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "DnsHostnameToComputerNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DnsHostnameToComputerNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string Hostname, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ComputerName, ref uint nSize);


        /// Return Type: BOOL->int
        ///Hostname: LPCSTR->CHAR*
        ///ComputerName: LPSTR->CHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "DnsHostnameToComputerNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DnsHostnameToComputerNameA([In] [MarshalAs(UnmanagedType.LPStr)] string Hostname, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ComputerName, ref uint nSize);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("shell32.dll", EntryPoint = "DllGetClassObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int DllGetClassObject(ref GUID rclsid, ref GUID riid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        [DllImport("shell32.dll", EntryPoint = "DllCanUnloadNow", CallingConvention = CallingConvention.StdCall)]
        public static extern int DllCanUnloadNow();


        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPWSTR->WCHAR*
        ///chCount: int
        ///idListBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectExW([In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString, int chCount, int idListBox);


        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPSTR->CHAR*
        ///chCount: int
        ///idListBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectExA([In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString, int chCount, int idListBox);


        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPWSTR->WCHAR*
        ///cchOut: int
        ///idComboBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectComboBoxExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectComboBoxExW([In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString, int cchOut, int idComboBox);


        /// Return Type: BOOL->int
        ///hwndDlg: HWND->HWND__*
        ///lpString: LPSTR->CHAR*
        ///cchOut: int
        ///idComboBox: int
        [DllImport("user32.dll", EntryPoint = "DlgDirSelectComboBoxExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectComboBoxExA([In] IntPtr hwndDlg, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString, int cchOut, int idComboBox);


        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPWSTR->WCHAR*
        ///nIDListBox: int
        ///nIDStaticPath: int
        ///uFileType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListW")]
        public static extern int DlgDirListW([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);


        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPWSTR->WCHAR*
        ///nIDComboBox: int
        ///nIDStaticPath: int
        ///uFiletype: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListComboBoxW")]
        public static extern int DlgDirListComboBoxW([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);


        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPSTR->CHAR*
        ///nIDComboBox: int
        ///nIDStaticPath: int
        ///uFiletype: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListComboBoxA")]
        public static extern int DlgDirListComboBoxA([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);


        /// Return Type: int
        ///hDlg: HWND->HWND__*
        ///lpPathSpec: LPSTR->CHAR*
        ///nIDListBox: int
        ///nIDStaticPath: int
        ///uFileType: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DlgDirListA")]
        public static extern int DlgDirListA([In] IntPtr hDlg, IntPtr lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);


        /// Return Type: div_t->_div_t
        ///_Numerator: int
        ///_Denominator: int
        [DllImport("msvcr80.dll", EntryPoint = "div", CallingConvention = CallingConvention.Cdecl)]
        public static extern div_t div(int _Numerator, int _Denominator);


        /// Return Type: HRESULT->LONG->int
        ///_this: void*
        ///ptinfo: ITypeInfo*
        ///dispidMember: DISPID->LONG->int
        ///wFlags: WORD->unsigned short
        ///pparams: DISPPARAMS*
        ///pvarResult: VARIANT*
        ///pexcepinfo: EXCEPINFO*
        ///puArgErr: UINT*
        [DllImport("oleaut32.dll", EntryPoint = "DispInvoke", CallingConvention = CallingConvention.StdCall)]
        public static extern int DispInvoke(IntPtr _this, ref ITypeInfo ptinfo, int dispidMember, ushort wFlags, ref tagDISPPARAMS pparams, ref tagVARIANT pvarResult, ref tagEXCEPINFO pexcepinfo, ref uint puArgErr);


        /// Return Type: HRESULT->LONG->int
        ///pdispparams: DISPPARAMS*
        ///position: UINT->unsigned int
        ///vtTarg: VARTYPE->unsigned short
        ///pvarResult: VARIANT*
        ///puArgErr: UINT*
        [DllImport("oleaut32.dll", EntryPoint = "DispGetParam", CallingConvention = CallingConvention.StdCall)]
        public static extern int DispGetParam(ref tagDISPPARAMS pdispparams, uint position, ushort vtTarg, ref tagVARIANT pvarResult, ref uint puArgErr);


        /// Return Type: HRESULT->LONG->int
        ///ptinfo: ITypeInfo*
        ///rgszNames: OLECHAR**
        ///cNames: UINT->unsigned int
        ///rgdispid: DISPID*
        [DllImport("oleaut32.dll", EntryPoint = "DispGetIDsOfNames", CallingConvention = CallingConvention.StdCall)]
        public static extern int DispGetIDsOfNames(ref ITypeInfo ptinfo, ref IntPtr rgszNames, uint cNames, ref int rgdispid);


        /// Return Type: HRESULT->LONG->int
        ///pvInstance: void*
        ///oVft: ULONG_PTR->unsigned int
        ///cc: CALLCONV->tagCALLCONV
        ///vtReturn: VARTYPE->unsigned short
        ///cActuals: UINT->unsigned int
        ///prgvt: VARTYPE*
        ///prgpvarg: VARIANTARG**
        ///pvargResult: VARIANT*
        [DllImport("oleaut32.dll", EntryPoint = "DispCallFunc", CallingConvention = CallingConvention.StdCall)]
        public static extern int DispCallFunc(IntPtr pvInstance, uint oVft, tagCALLCONV cc, ushort vtReturn, uint cActuals, ref ushort prgvt, ref IntPtr prgpvarg, ref tagVARIANT pvargResult);


        /// Return Type: LRESULT->LONG_PTR->int
        ///lpMsg: MSG*
        [DllImport("user32.dll", EntryPoint = "DispatchMessageW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DispatchMessageW([In] ref tagMSG lpMsg);


        /// Return Type: LRESULT->LONG_PTR->int
        ///lpMsg: MSG*
        [DllImport("user32.dll", EntryPoint = "DispatchMessageA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DispatchMessageA([In] ref tagMSG lpMsg);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DisconnectNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DisconnectNamedPipe([In] IntPtr hNamedPipe);


        /// Return Type: BOOL->int
        ///hLibModule: HMODULE->HINSTANCE->HINSTANCE__*
        [DllImport("kernel32.dll", EntryPoint = "DisableThreadLibraryCalls")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DisableThreadLibraryCalls([In] IntPtr hLibModule);


        /// Return Type: void
        [DllImport("user32.dll", EntryPoint = "DisableProcessWindowsGhosting")]
        public static extern void DisableProcessWindowsGhosting();


        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCWSTR->WCHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxParamW")]
        public static extern int DialogBoxParamW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCSTR->CHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxParamA")]
        public static extern int DialogBoxParamA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///hDialogTemplate: LPCDLGTEMPLATEW->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxIndirectParamW")]
        public static extern int DialogBoxIndirectParamW([In] IntPtr hInstance, [In] ref DLGTEMPLATE hDialogTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: INT_PTR->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///hDialogTemplate: LPCDLGTEMPLATEA->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DialogBoxIndirectParamA")]
        public static extern int DialogBoxIndirectParamA([In] IntPtr hInstance, [In] ref DLGTEMPLATE hDialogTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        ///dwIoControlCode: DWORD->unsigned int
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesReturned: LPDWORD->DWORD*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl([In] IntPtr hDevice, uint dwIoControlCode, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, IntPtr lpBytesReturned, IntPtr lpOverlapped);


        /// Return Type: int
        ///pDevice: LPCWSTR->WCHAR*
        ///pPort: LPCWSTR->WCHAR*
        ///fwCapability: WORD->unsigned short
        ///pOutput: LPWSTR->WCHAR*
        ///pDevMode: DEVMODEW*
        [DllImport("<Unknown>", EntryPoint = "DeviceCapabilitiesW")]
        public static extern int DeviceCapabilitiesW([In] [MarshalAs(UnmanagedType.LPWStr)] string pDevice, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPort, ushort fwCapability, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pOutput, [In] IntPtr pDevMode);


        /// Return Type: int
        ///pDevice: LPCSTR->CHAR*
        ///pPort: LPCSTR->CHAR*
        ///fwCapability: WORD->unsigned short
        ///pOutput: LPSTR->CHAR*
        ///pDevMode: DEVMODEA*
        [DllImport("<Unknown>", EntryPoint = "DeviceCapabilitiesA")]
        public static extern int DeviceCapabilitiesA([In] [MarshalAs(UnmanagedType.LPStr)] string pDevice, [In] [MarshalAs(UnmanagedType.LPStr)] string pPort, ushort fwCapability, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pOutput, [In] IntPtr pDevMode);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "DestroyWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///param0: HPROPSHEETPAGE->_PSP*
        [DllImport("comctl32.dll", EntryPoint = "DestroyPropertySheetPage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyPropertySheetPage(IntPtr param0);


        /// Return Type: BOOL->int
        ///ObjectDescriptor: PSECURITY_DESCRIPTOR*
        [DllImport("advapi32.dll", EntryPoint = "DestroyPrivateObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyPrivateObjectSecurity(ref IntPtr ObjectDescriptor);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "DestroyMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyMenu([In] IntPtr hMenu);


        /// Return Type: BOOL->int
        ///hIcon: HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DestroyIcon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyIcon([In] IntPtr hIcon);


        /// Return Type: BOOL->int
        ///hCursor: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "DestroyCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyCursor([In] IntPtr hCursor);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "DestroyCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyCaret();


        /// Return Type: BOOL->int
        ///hAccel: HACCEL->HACCEL__*
        [DllImport("user32.dll", EntryPoint = "DestroyAcceleratorTable")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyAcceleratorTable([In] IntPtr hAccel);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///iPixelFormat: int
        ///nBytes: UINT->unsigned int
        ///ppfd: LPPIXELFORMATDESCRIPTOR->tagPIXELFORMATDESCRIPTOR*
        [DllImport("gdi32.dll", EntryPoint = "DescribePixelFormat")]
        public static extern int DescribePixelFormat([In] IntPtr hdc, int iPixelFormat, uint nBytes, IntPtr ppfd);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "DeregisterShellHookWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeregisterShellHookWindow([In] IntPtr hwnd);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "DeregisterEventSource")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeregisterEventSource([In] IntPtr hEventLog);


        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteVolumeMountPointW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint);


        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteVolumeMountPointA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint);


        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///Timer: HANDLE->void*
        ///CompletionEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteTimerQueueTimer([In] IntPtr TimerQueue, [In] IntPtr Timer, [In] IntPtr CompletionEvent);


        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///CompletionEvent: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueueEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteTimerQueueEx([In] IntPtr TimerQueue, [In] IntPtr CompletionEvent);


        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteTimerQueue([In] IntPtr TimerQueue);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        [DllImport("advapi32.dll", EntryPoint = "DeleteService")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteService([In] ref SC_HANDLE__ hService);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///pPrintProvidorName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrintProvidorW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrintProvidorW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPrintProvidorName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///pPrintProvidorName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrintProvidorA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrintProvidorA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string pPrintProvidorName);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///pPrintProcessorName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrintProcessorW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrintProcessorW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPrintProcessorName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///pPrintProcessorName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrintProcessorA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrintProcessorA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string pPrintProcessorName);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterKeyW")]
        public static extern uint DeletePrinterKeyW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pKeyName);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterKeyA")]
        public static extern uint DeletePrinterKeyA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pKeyName);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///pDriverName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDriverW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrinterDriverW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string pDriverName);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///pDriverName: LPWSTR->WCHAR*
        ///dwDeleteFlag: DWORD->unsigned int
        ///dwVersionFlag: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDriverExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrinterDriverExW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string pDriverName, uint dwDeleteFlag, uint dwVersionFlag);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///pDriverName: LPSTR->CHAR*
        ///dwDeleteFlag: DWORD->unsigned int
        ///dwVersionFlag: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDriverExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrinterDriverExA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string pDriverName, uint dwDeleteFlag, uint dwVersionFlag);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///pDriverName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDriverA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrinterDriverA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string pDriverName);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pValueName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDataW")]
        public static extern uint DeletePrinterDataW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pValueName);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCWSTR->WCHAR*
        ///pValueName: LPCWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDataExW")]
        public static extern uint DeletePrinterDataExW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pKeyName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pValueName);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCSTR->CHAR*
        ///pValueName: LPCSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDataExA")]
        public static extern uint DeletePrinterDataExA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pKeyName, [In] [MarshalAs(UnmanagedType.LPStr)] string pValueName);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pValueName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterDataA")]
        public static extern uint DeletePrinterDataA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pValueName);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterConnectionW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrinterConnectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinterConnectionA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrinterConnectionA([In] [MarshalAs(UnmanagedType.LPStr)] string pName);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "DeletePrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePrinter([In] IntPtr hPrinter);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///hWnd: HWND->HWND__*
        ///pPortName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePortW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePortW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPortName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///hWnd: HWND->HWND__*
        ///pPortName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeletePortA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeletePortA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string pPortName);


        /// Return Type: BOOL->int
        ///ho: HGDIOBJ->void*
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr ho);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///pMonitorName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeleteMonitorW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteMonitorW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string pMonitorName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///pMonitorName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeleteMonitorA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteMonitorA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string pMonitorName);


        /// Return Type: BOOL->int
        ///hmf: HMETAFILE->HMETAFILE__*
        [DllImport("gdi32.dll", EntryPoint = "DeleteMetaFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteMetaFile([In] IntPtr hmf);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///uPosition: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DeleteMenu")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteMenu([In] IntPtr hMenu, uint uPosition, uint uFlags);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pFormName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "DeleteFormW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFormW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pFormName);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pFormName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "DeleteFormA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFormA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormName);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "DeleteFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: void
        ///lpFiber: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "DeleteFiber")]
        public static extern void DeleteFiber([In] IntPtr lpFiber);


        /// Return Type: BOOL->int
        ///hmf: HENHMETAFILE->HENHMETAFILE__*
        [DllImport("gdi32.dll", EntryPoint = "DeleteEnhMetaFile")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteEnhMetaFile([In] IntPtr hmf);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteDC([In] IntPtr hdc);


        /// Return Type: void
        ///lpCriticalSection: LPCRITICAL_SECTION->PRTL_CRITICAL_SECTION->_RTL_CRITICAL_SECTION*
        [DllImport("kernel32.dll", EntryPoint = "DeleteCriticalSection")]
        public static extern void DeleteCriticalSection(ref RTL_CRITICAL_SECTION lpCriticalSection);


        /// Return Type: BOOL->int
        ///hcs: HCOLORSPACE->HCOLORSPACE__*
        [DllImport("gdi32.dll", EntryPoint = "DeleteColorSpace")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteColorSpace([In] IntPtr hcs);


        /// Return Type: ATOM->WORD->unsigned short
        ///nAtom: ATOM->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "DeleteAtom")]
        public static extern ushort DeleteAtom(ushort nAtom);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceIndex: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "DeleteAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteAce(ref ACL pAcl, uint dwAceIndex);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefWindowProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefWindowProcW([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefWindowProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefWindowProcA([In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///paRawInput: PRAWINPUT*
        ///nInput: INT->int
        ///cbSizeHeader: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DefRawInputProc")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefRawInputProc([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt, SizeParamIndex = 1)] IntPtr[] paRawInput, int nInput, uint cbSizeHeader);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefMDIChildProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefMDIChildProcW([In] IntPtr hWnd, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefMDIChildProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefMDIChildProcA([In] IntPtr hWnd, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpDeviceName: LPCWSTR->WCHAR*
        ///lpTargetPath: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "DefineDosDeviceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DefineDosDeviceW(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDeviceName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTargetPath);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpDeviceName: LPCSTR->CHAR*
        ///lpTargetPath: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "DefineDosDeviceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DefineDosDeviceA(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDeviceName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTargetPath);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///hWndMDIClient: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefFrameProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefFrameProcW([In] IntPtr hWnd, [In] IntPtr hWndMDIClient, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hWnd: HWND->HWND__*
        ///hWndMDIClient: HWND->HWND__*
        ///uMsg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefFrameProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefFrameProcA([In] IntPtr hWnd, [In] IntPtr hWndMDIClient, uint uMsg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: HDWP->HANDLE->void*
        ///hWinPosInfo: HDWP->HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///hWndInsertAfter: HWND->HWND__*
        ///x: int
        ///y: int
        ///cx: int
        ///cy: int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DeferWindowPos")]
        public static extern IntPtr DeferWindowPos([In] IntPtr hWinPosInfo, [In] IntPtr hWnd, [In] IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);


        /// Return Type: LRESULT->LONG_PTR->int
        ///dwDriverIdentifier: DWORD_PTR->ULONG_PTR->unsigned int
        ///hdrvr: HDRVR->HDRVR__*
        ///uMsg: UINT->unsigned int
        ///lParam1: LPARAM->LONG_PTR->int
        ///lParam2: LPARAM->LONG_PTR->int
        [DllImport("winmm.dll", EntryPoint = "DefDriverProc")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefDriverProc(uint dwDriverIdentifier, IntPtr hdrvr, uint uMsg, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam1, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam2);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefDlgProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefDlgProcW([In] IntPtr hDlg, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hDlg: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "DefDlgProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr DefDlgProcA([In] IntPtr hDlg, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "DecryptFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DecryptFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint dwReserved);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///dwReserved: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "DecryptFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DecryptFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint dwReserved);


        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "DecodeSystemPointer")]
        public static extern IntPtr DecodeSystemPointer([In] IntPtr Ptr);


        /// Return Type: PVOID->void*
        ///Ptr: PVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "DecodePointer")]
        public static extern IntPtr DecodePointer([In] IntPtr Ptr);


        /// Return Type: BOOL->int
        ///KillOnExit: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "DebugSetProcessKillOnExit")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugSetProcessKillOnExit([MarshalAs(UnmanagedType.Bool)] bool KillOnExit);


        /// Return Type: BOOL->int
        ///Process: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "DebugBreakProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugBreakProcess([In] IntPtr Process);


        /// Return Type: void
        [DllImport("kernel32.dll", EntryPoint = "DebugBreak")]
        public static extern void DebugBreak();


        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DebugActiveProcessStop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugActiveProcessStop(uint dwProcessId);


        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DebugActiveProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugActiveProcess(uint dwProcessId);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///ulCookie: ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "DeactivateActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeactivateActCtx(uint dwFlags, uint ulCookie);


        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeUninitialize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeUninitialize(uint idInst);


        /// Return Type: BOOL->int
        ///hData: HDDEDATA->HDDEDATA__*
        [DllImport("user32.dll", EntryPoint = "DdeUnaccessData")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeUnaccessData(IntPtr hData);


        /// Return Type: BOOL->int
        ///hConv: HCONV->HCONV__*
        ///id: DWORD->unsigned int
        ///hUser: DWORD_PTR->ULONG_PTR->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeSetUserHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeSetUserHandle(IntPtr hConv, uint id, uint hUser);


        /// Return Type: BOOL->int
        ///hwndClient: HWND->HWND__*
        ///pqosNew: SECURITY_QUALITY_OF_SERVICE*
        ///pqosPrev: PSECURITY_QUALITY_OF_SERVICE->_SECURITY_QUALITY_OF_SERVICE*
        [DllImport("user32.dll", EntryPoint = "DdeSetQualityOfService")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeSetQualityOfService(IntPtr hwndClient, ref SECURITY_QUALITY_OF_SERVICE pqosNew, ref SECURITY_QUALITY_OF_SERVICE pqosPrev);


        /// Return Type: HCONV->HCONV__*
        ///hConv: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeReconnect")]
        public static extern IntPtr DdeReconnect(IntPtr hConv);


        /// Return Type: DWORD->unsigned int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        ///psz: LPWSTR->WCHAR*
        ///cchMax: DWORD->unsigned int
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeQueryStringW")]
        public static extern uint DdeQueryStringW(uint idInst, IntPtr hsz, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder psz, uint cchMax, int iCodePage);


        /// Return Type: DWORD->unsigned int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        ///psz: LPSTR->CHAR*
        ///cchMax: DWORD->unsigned int
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeQueryStringA")]
        public static extern uint DdeQueryStringA(uint idInst, IntPtr hsz, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder psz, uint cchMax, int iCodePage);


        /// Return Type: HCONV->HCONV__*
        ///hConvList: HCONVLIST->HCONVLIST__*
        ///hConvPrev: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeQueryNextServer")]
        public static extern IntPtr DdeQueryNextServer(IntPtr hConvList, IntPtr hConvPrev);


        /// Return Type: UINT->unsigned int
        ///hConv: HCONV->HCONV__*
        ///idTransaction: DWORD->unsigned int
        ///pConvInfo: PCONVINFO->CONVINFO*
        [DllImport("user32.dll", EntryPoint = "DdeQueryConvInfo")]
        public static extern uint DdeQueryConvInfo(IntPtr hConv, uint idTransaction, ref tagCONVINFO pConvInfo);


        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hszTopic: HSZ->HSZ__*
        ///hszItem: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdePostAdvise")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdePostAdvise(uint idInst, IntPtr hszTopic, IntPtr hszItem);


        /// Return Type: HDDEDATA->HDDEDATA__*
        ///idInst: DWORD->unsigned int
        ///hsz1: HSZ->HSZ__*
        ///hsz2: HSZ->HSZ__*
        ///afCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeNameService")]
        public static extern IntPtr DdeNameService(uint idInst, IntPtr hsz1, IntPtr hsz2, uint afCmd);


        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdeKeepStringHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeKeepStringHandle(uint idInst, IntPtr hsz);


        /// Return Type: UINT->unsigned int
        ///pidInst: LPDWORD->DWORD*
        ///pfnCallback: PFNCALLBACK
        ///afCmd: DWORD->unsigned int
        ///ulRes: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeInitializeW")]
        public static extern uint DdeInitializeW(ref uint pidInst, PFNCALLBACK pfnCallback, uint afCmd, uint ulRes);


        /// Return Type: UINT->unsigned int
        ///pidInst: LPDWORD->DWORD*
        ///pfnCallback: PFNCALLBACK
        ///afCmd: DWORD->unsigned int
        ///ulRes: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeInitializeA")]
        public static extern uint DdeInitializeA(ref uint pidInst, PFNCALLBACK pfnCallback, uint afCmd, uint ulRes);


        /// Return Type: BOOL->int
        ///hConv: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeImpersonateClient")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeImpersonateClient(IntPtr hConv);


        /// Return Type: UINT->unsigned int
        ///idInst: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeGetLastError")]
        public static extern uint DdeGetLastError(uint idInst);


        /// Return Type: DWORD->unsigned int
        ///hData: HDDEDATA->HDDEDATA__*
        ///pDst: LPBYTE->BYTE*
        ///cbMax: DWORD->unsigned int
        ///cbOff: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeGetData")]
        public static extern uint DdeGetData(IntPtr hData, ref byte pDst, uint cbMax, uint cbOff);


        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hsz: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdeFreeStringHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeFreeStringHandle(uint idInst, IntPtr hsz);


        /// Return Type: BOOL->int
        ///hData: HDDEDATA->HDDEDATA__*
        [DllImport("user32.dll", EntryPoint = "DdeFreeDataHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeFreeDataHandle(IntPtr hData);


        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hConv: HCONV->HCONV__*
        ///wCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeEnableCallback")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeEnableCallback(uint idInst, IntPtr hConv, uint wCmd);


        /// Return Type: BOOL->int
        ///hConvList: HCONVLIST->HCONVLIST__*
        [DllImport("user32.dll", EntryPoint = "DdeDisconnectList")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeDisconnectList(IntPtr hConvList);


        /// Return Type: BOOL->int
        ///hConv: HCONV->HCONV__*
        [DllImport("user32.dll", EntryPoint = "DdeDisconnect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeDisconnect(IntPtr hConv);


        /// Return Type: HSZ->HSZ__*
        ///idInst: DWORD->unsigned int
        ///psz: LPCWSTR->WCHAR*
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeCreateStringHandleW")]
        public static extern IntPtr DdeCreateStringHandleW(uint idInst, [In] [MarshalAs(UnmanagedType.LPWStr)] string psz, int iCodePage);


        /// Return Type: HSZ->HSZ__*
        ///idInst: DWORD->unsigned int
        ///psz: LPCSTR->CHAR*
        ///iCodePage: int
        [DllImport("user32.dll", EntryPoint = "DdeCreateStringHandleA")]
        public static extern IntPtr DdeCreateStringHandleA(uint idInst, [In] [MarshalAs(UnmanagedType.LPStr)] string psz, int iCodePage);


        /// Return Type: HDDEDATA->HDDEDATA__*
        ///idInst: DWORD->unsigned int
        ///pSrc: LPBYTE->BYTE*
        ///cb: DWORD->unsigned int
        ///cbOff: DWORD->unsigned int
        ///hszItem: HSZ->HSZ__*
        ///wFmt: UINT->unsigned int
        ///afCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeCreateDataHandle")]
        public static extern IntPtr DdeCreateDataHandle(uint idInst, ref byte pSrc, uint cb, uint cbOff, IntPtr hszItem, uint wFmt, uint afCmd);


        /// Return Type: HCONVLIST->HCONVLIST__*
        ///idInst: DWORD->unsigned int
        ///hszService: HSZ->HSZ__*
        ///hszTopic: HSZ->HSZ__*
        ///hConvList: HCONVLIST->HCONVLIST__*
        ///pCC: PCONVCONTEXT->CONVCONTEXT*
        [DllImport("user32.dll", EntryPoint = "DdeConnectList")]
        public static extern IntPtr DdeConnectList(uint idInst, IntPtr hszService, IntPtr hszTopic, IntPtr hConvList, ref tagCONVCONTEXT pCC);


        /// Return Type: HCONV->HCONV__*
        ///idInst: DWORD->unsigned int
        ///hszService: HSZ->HSZ__*
        ///hszTopic: HSZ->HSZ__*
        ///pCC: PCONVCONTEXT->CONVCONTEXT*
        [DllImport("user32.dll", EntryPoint = "DdeConnect")]
        public static extern IntPtr DdeConnect(uint idInst, IntPtr hszService, IntPtr hszTopic, ref tagCONVCONTEXT pCC);


        /// Return Type: int
        ///hsz1: HSZ->HSZ__*
        ///hsz2: HSZ->HSZ__*
        [DllImport("user32.dll", EntryPoint = "DdeCmpStringHandles")]
        public static extern int DdeCmpStringHandles(IntPtr hsz1, IntPtr hsz2);


        /// Return Type: HDDEDATA->HDDEDATA__*
        ///pData: LPBYTE->BYTE*
        ///cbData: DWORD->unsigned int
        ///hConv: HCONV->HCONV__*
        ///hszItem: HSZ->HSZ__*
        ///wFmt: UINT->unsigned int
        ///wType: UINT->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///pdwResult: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "DdeClientTransaction")]
        public static extern IntPtr DdeClientTransaction(ref byte pData, uint cbData, IntPtr hConv, IntPtr hszItem, uint wFmt, uint wType, uint dwTimeout, ref uint pdwResult);


        /// Return Type: HDDEDATA->HDDEDATA__*
        ///hData: HDDEDATA->HDDEDATA__*
        ///pSrc: LPBYTE->BYTE*
        ///cb: DWORD->unsigned int
        ///cbOff: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeAddData")]
        public static extern IntPtr DdeAddData(IntPtr hData, ref byte pSrc, uint cb, uint cbOff);


        /// Return Type: LPBYTE->BYTE*
        ///hData: HDDEDATA->HDDEDATA__*
        ///pcbDataSize: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "DdeAccessData")]
        public static extern IntPtr DdeAccessData(IntPtr hData, ref uint pcbDataSize);


        /// Return Type: BOOL->int
        ///idInst: DWORD->unsigned int
        ///hConv: HCONV->HCONV__*
        ///idTransaction: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "DdeAbandonTransaction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeAbandonTransaction(uint idInst, IntPtr hConv, uint idTransaction);


        /// Return Type: HRESULT->LONG->int
        ///pvReserved: LPVOID->void*
        ///pulReserved: ULONG*
        ///appsHR: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "DcomChannelSetHResult", CallingConvention = CallingConvention.StdCall)]
        public static extern int DcomChannelSetHResult(IntPtr pvReserved, ref uint pulReserved, int appsHR);


        /// Return Type: RPC_STATUS->int
        ///RpcStatus: RPC_STATUS->int
        ///ErrorText: RPC_WSTR->unsigned short*
        [DllImport("rpcrt4.dll", EntryPoint = "DceErrorInqTextW", CallingConvention = CallingConvention.StdCall)]
        public static extern int DceErrorInqTextW(int RpcStatus, IntPtr ErrorText);


        /// Return Type: RPC_STATUS->int
        ///RpcStatus: RPC_STATUS->int
        ///ErrorText: RPC_CSTR->unsigned char*
        [DllImport("rpcrt4.dll", EntryPoint = "DceErrorInqTextA", CallingConvention = CallingConvention.StdCall)]
        public static extern int DceErrorInqTextA(int RpcStatus, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ErrorText);

    }

}
