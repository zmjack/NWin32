using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: void
        ///lpOutputString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OutputDebugStringW")]
        public static extern void OutputDebugStringW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpOutputString);


        /// Return Type: void
        ///lpOutputString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OutputDebugStringA")]
        public static extern void OutputDebugStringA([In] [MarshalAs(UnmanagedType.LPStr)] string lpOutputString);


        /// Return Type: HWINSTA->HWINSTA__*
        ///lpszWinSta: LPCWSTR->WCHAR*
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenWindowStationW")]
        public static extern IntPtr OpenWindowStationW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszWinSta, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);


        /// Return Type: HWINSTA->HWINSTA__*
        ///lpszWinSta: LPCSTR->CHAR*
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenWindowStationA")]
        public static extern IntPtr OpenWindowStationA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszWinSta, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpTimerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenWaitableTimerW")]
        public static extern IntPtr OpenWaitableTimerW(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpTimerName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenWaitableTimerA")]
        public static extern IntPtr OpenWaitableTimerA(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);


        /// Return Type: BOOL->int
        ///ThreadHandle: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///OpenAsSelf: BOOL->int
        ///TokenHandle: PHANDLE->HANDLE*
        [DllImport("advapi32.dll", EntryPoint = "OpenThreadToken")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenThreadToken([In] IntPtr ThreadHandle, uint DesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool OpenAsSelf, out IntPtr TokenHandle);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwThreadId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenThread")]
        public static extern IntPtr OpenThread(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwThreadId);


        /// Return Type: SC_HANDLE->SC_HANDLE__*
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpServiceName: LPCWSTR->WCHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "OpenServiceW")]
        public static extern IntPtr OpenServiceW([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpServiceName, uint dwDesiredAccess);


        /// Return Type: SC_HANDLE->SC_HANDLE__*
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpServiceName: LPCSTR->CHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "OpenServiceA")]
        public static extern IntPtr OpenServiceA([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPStr)] string lpServiceName, uint dwDesiredAccess);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenSemaphoreW")]
        public static extern IntPtr OpenSemaphoreW(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenSemaphoreA")]
        public static extern IntPtr OpenSemaphoreA(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: SC_HANDLE->SC_HANDLE__*
        ///lpMachineName: LPCWSTR->WCHAR*
        ///lpDatabaseName: LPCWSTR->WCHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "OpenSCManagerW")]
        public static extern IntPtr OpenSCManagerW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpMachineName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDatabaseName, uint dwDesiredAccess);


        /// Return Type: SC_HANDLE->SC_HANDLE__*
        ///lpMachineName: LPCSTR->CHAR*
        ///lpDatabaseName: LPCSTR->CHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "OpenSCManagerA")]
        public static extern IntPtr OpenSCManagerA([In] [MarshalAs(UnmanagedType.LPStr)] string lpMachineName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDatabaseName, uint dwDesiredAccess);


        /// Return Type: BOOL->int
        ///ProcessHandle: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///TokenHandle: PHANDLE->HANDLE*
        [DllImport("advapi32.dll", EntryPoint = "OpenProcessToken")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenProcessToken([In] IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwProcessId);


        /// Return Type: BOOL->int
        ///pPrinterName: LPWSTR->WCHAR*
        ///phPrinter: LPHANDLE->HANDLE*
        ///pDefault: LPPRINTER_DEFAULTSW->_PRINTER_DEFAULTSW*
        [DllImport("<Unknown>", EntryPoint = "OpenPrinterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenPrinterW([In] [MarshalAs(UnmanagedType.LPWStr)] string pPrinterName, ref IntPtr phPrinter, [In] IntPtr pDefault);


        /// Return Type: BOOL->int
        ///pPrinterName: LPSTR->CHAR*
        ///phPrinter: LPHANDLE->HANDLE*
        ///pDefault: LPPRINTER_DEFAULTSA->_PRINTER_DEFAULTSA*
        [DllImport("<Unknown>", EntryPoint = "OpenPrinterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenPrinterA([In] [MarshalAs(UnmanagedType.LPStr)] string pPrinterName, ref IntPtr phPrinter, [In] IntPtr pDefault);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenMutexW")]
        public static extern IntPtr OpenMutexW(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenMutexA")]
        public static extern IntPtr OpenMutexA(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenJobObjectW")]
        public static extern IntPtr OpenJobObjectW(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenJobObjectA")]
        public static extern IntPtr OpenJobObjectA(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: HDESK->HDESK__*
        ///dwFlags: DWORD->unsigned int
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenInputDesktop")]
        public static extern IntPtr OpenInputDesktop(uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "OpenIcon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenIcon([In] IntPtr hWnd);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenFileMappingW")]
        public static extern IntPtr OpenFileMappingW(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenFileMappingA")]
        public static extern IntPtr OpenFileMappingA(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: HFILE->int
        ///lpFileName: LPCSTR->CHAR*
        ///lpReOpenBuff: LPOFSTRUCT->_OFSTRUCT*
        ///uStyle: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "OpenFile")]
        public static extern int OpenFile([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenEventW")]
        public static extern IntPtr OpenEventW(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///lpUNCServerName: LPCWSTR->WCHAR*
        ///lpSourceName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "OpenEventLogW")]
        public static extern IntPtr OpenEventLogW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpUNCServerName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSourceName);


        /// Return Type: HANDLE->void*
        ///lpUNCServerName: LPCSTR->CHAR*
        ///lpSourceName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "OpenEventLogA")]
        public static extern IntPtr OpenEventLogA([In] [MarshalAs(UnmanagedType.LPStr)] string lpUNCServerName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSourceName);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///bInheritHandle: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "OpenEventA")]
        public static extern IntPtr OpenEventA(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///ulFlags: ULONG->unsigned int
        ///pvContext: PVOID*
        [DllImport("advapi32.dll", EntryPoint = "OpenEncryptedFileRawW")]
        public static extern uint OpenEncryptedFileRawW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint ulFlags, out IntPtr pvContext);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        ///ulFlags: ULONG->unsigned int
        ///pvContext: PVOID*
        [DllImport("advapi32.dll", EntryPoint = "OpenEncryptedFileRawA")]
        public static extern uint OpenEncryptedFileRawA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint ulFlags, out IntPtr pvContext);


        /// Return Type: HDRVR->HDRVR__*
        ///szDriverName: LPCWSTR->WCHAR*
        ///szSectionName: LPCWSTR->WCHAR*
        ///lParam2: LPARAM->LONG_PTR->int
        [DllImport("winmm.dll", EntryPoint = "OpenDriver")]
        public static extern IntPtr OpenDriver([In] [MarshalAs(UnmanagedType.LPWStr)] string szDriverName, [In] [MarshalAs(UnmanagedType.LPWStr)] string szSectionName, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam2);


        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenDesktopW")]
        public static extern IntPtr OpenDesktopW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);


        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///fInherit: BOOL->int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OpenDesktopA")]
        public static extern IntPtr OpenDesktopA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fInherit, uint dwDesiredAccess);


        /// Return Type: BOOL->int
        ///hWndNewOwner: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "OpenClipboard")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenClipboard([In] IntPtr hWndNewOwner);


        /// Return Type: HANDLE->void*
        ///lpUNCServerName: LPCWSTR->WCHAR*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "OpenBackupEventLogW")]
        public static extern IntPtr OpenBackupEventLogW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpUNCServerName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: HANDLE->void*
        ///lpUNCServerName: LPCSTR->CHAR*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "OpenBackupEventLogA")]
        public static extern IntPtr OpenBackupEventLogA([In] [MarshalAs(UnmanagedType.LPStr)] string lpUNCServerName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "OleUninitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void OleUninitialize();


        /// Return Type: HRESULT->LONG->int
        ///lpFrame: LPOLEINPLACEFRAME->IOleInPlaceFrame*
        ///lpFrameInfo: LPOLEINPLACEFRAMEINFO->tagOIFI*
        ///lpmsg: LPMSG->tagMSG*
        [DllImport("ole32.dll", EntryPoint = "OleTranslateAccelerator", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleTranslateAccelerator(ref IOleInPlaceFrame lpFrame, ref tagOIFI lpFrameInfo, ref tagMSG lpmsg);


        /// Return Type: HRESULT->LONG->int
        ///holemenu: HOLEMENU->HGLOBAL->HANDLE->void*
        ///hwndFrame: HWND->HWND__*
        ///hwndActiveObject: HWND->HWND__*
        ///lpFrame: LPOLEINPLACEFRAME->IOleInPlaceFrame*
        ///lpActiveObj: LPOLEINPLACEACTIVEOBJECT->IOleInPlaceActiveObject*
        [DllImport("ole32.dll", EntryPoint = "OleSetMenuDescriptor", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetMenuDescriptor(IntPtr holemenu, IntPtr hwndFrame, IntPtr hwndActiveObject, ref IOleInPlaceFrame lpFrame, ref IOleInPlaceActiveObject lpActiveObj);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///fContained: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleSetContainedObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetContainedObject(ref IUnknown pUnknown, [MarshalAs(UnmanagedType.Bool)] bool fContained);


        /// Return Type: HRESULT->LONG->int
        ///pDataObj: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleSetClipboard", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetClipboard(ref IDataObject pDataObj);


        /// Return Type: HRESULT->LONG->int
        ///clsidOld: IID*
        ///clsidNew: IID*
        [DllImport("ole32.dll", EntryPoint = "OleSetAutoConvert", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetAutoConvert(ref GUID clsidOld, ref GUID clsidNew);


        /// Return Type: HRESULT->LONG->int
        ///pPStm: LPPERSISTSTREAM->IPersistStream*
        ///pStm: LPSTREAM->IStream*
        [DllImport("ole32.dll", EntryPoint = "OleSaveToStream", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSaveToStream(ref IPersistStream pPStm, ref IStream pStm);


        /// Return Type: HRESULT->LONG->int
        ///pPS: LPPERSISTSTORAGE->IPersistStorage*
        ///pStg: LPSTORAGE->IStorage*
        ///fSameAsLoad: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleSave", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSave(ref IPersistStorage pPS, ref IStorage pStg, [MarshalAs(UnmanagedType.Bool)] bool fSameAsLoad);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        [DllImport("ole32.dll", EntryPoint = "OleRun", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRun(ref IUnknown pUnknown);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///dwFormOfType: DWORD->unsigned int
        ///pszUserType: LPOLESTR*
        [DllImport("ole32.dll", EntryPoint = "OleRegGetUserType", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegGetUserType(ref GUID clsid, uint dwFormOfType, ref IntPtr pszUserType);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///dwAspect: DWORD->unsigned int
        ///pdwStatus: DWORD*
        [DllImport("ole32.dll", EntryPoint = "OleRegGetMiscStatus", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegGetMiscStatus(ref GUID clsid, uint dwAspect, ref uint pdwStatus);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///ppenum: LPENUMOLEVERB*
        [DllImport("ole32.dll", EntryPoint = "OleRegEnumVerbs", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegEnumVerbs(ref GUID clsid, ref IntPtr ppenum);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///dwDirection: DWORD->unsigned int
        ///ppenum: LPENUMFORMATETC*
        [DllImport("ole32.dll", EntryPoint = "OleRegEnumFormatEtc", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegEnumFormatEtc(ref GUID clsid, uint dwDirection, ref IntPtr ppenum);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObject: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleQueryLinkFromData", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleQueryLinkFromData(ref IDataObject pSrcDataObject);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObject: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleQueryCreateFromData", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleQueryCreateFromData(ref IDataObject pSrcDataObject);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///fVisible: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleNoteObjectVisible", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleNoteObjectVisible(ref IUnknown pUnknown, [MarshalAs(UnmanagedType.Bool)] bool fVisible);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///hIcon: HICON->HICON__*
        ///lpszLabel: LPOLESTR->OLECHAR*
        ///lpszSourceFile: LPOLESTR->OLECHAR*
        ///iIconIndex: UINT->unsigned int
        [DllImport("ole32.dll", EntryPoint = "OleMetafilePictFromIconAndLabel", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleMetafilePictFromIconAndLabel(IntPtr hIcon, IntPtr lpszLabel, IntPtr lpszSourceFile, uint iIconIndex);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///fLock: BOOL->int
        ///fLastUnlockCloses: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleLockRunning", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleLockRunning(ref IUnknown pUnknown, [MarshalAs(UnmanagedType.Bool)] bool fLock, [MarshalAs(UnmanagedType.Bool)] bool fLastUnlockCloses);


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        ///iidInterface: IID*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleLoadFromStream", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleLoadFromStream(ref IStream pStm, ref GUID iidInterface, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        ///riid: IID*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleLoad", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleLoad(ref IStorage pStg, ref GUID riid, ref IOleClientSite pClientSite, ref IntPtr ppvObj);


        /// Return Type: BOOL->int
        ///pObject: LPOLEOBJECT->IOleObject*
        [DllImport("ole32.dll", EntryPoint = "OleIsRunning", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OleIsRunning(ref IOleObject pObject);


        /// Return Type: HRESULT->LONG->int
        ///pDataObj: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleIsCurrentClipboard", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleIsCurrentClipboard(ref IDataObject pDataObj);


        /// Return Type: HRESULT->LONG->int
        ///pvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "OleInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleInitialize(IntPtr pvReserved);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///lpszPath: LPOLESTR->OLECHAR*
        ///fUseFileAsLabel: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleGetIconOfFile", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleGetIconOfFile(IntPtr lpszPath, [MarshalAs(UnmanagedType.Bool)] bool fUseFileAsLabel);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///rclsid: IID*
        ///lpszLabel: LPOLESTR->OLECHAR*
        ///fUseTypeAsLabel: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleGetIconOfClass", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleGetIconOfClass(ref GUID rclsid, IntPtr lpszLabel, [MarshalAs(UnmanagedType.Bool)] bool fUseTypeAsLabel);


        /// Return Type: HRESULT->LONG->int
        ///ppDataObj: LPDATAOBJECT*
        [DllImport("ole32.dll", EntryPoint = "OleGetClipboard", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleGetClipboard(ref IntPtr ppDataObj);


        /// Return Type: HRESULT->LONG->int
        ///clsidOld: IID*
        ///pClsidNew: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "OleGetAutoConvert", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleGetAutoConvert(ref GUID clsidOld, ref GUID pClsidNew);


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "OleFlushClipboard", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleFlushClipboard();


        /// Return Type: HANDLE->void*
        ///hSrc: HANDLE->void*
        ///cfFormat: CLIPFORMAT->WORD->unsigned short
        ///uiFlags: UINT->unsigned int
        [DllImport("ole32.dll", EntryPoint = "OleDuplicateData", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleDuplicateData(IntPtr hSrc, ushort cfFormat, uint uiFlags);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///dwAspect: DWORD->unsigned int
        ///hdcDraw: HDC->HDC__*
        ///lprcBounds: LPCRECT->RECT*
        [DllImport("ole32.dll", EntryPoint = "OleDraw", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleDraw(ref IUnknown pUnknown, uint dwAspect, IntPtr hdcDraw, ref tagRECT lprcBounds);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        ///pClsidNew: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "OleDoAutoConvert", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleDoAutoConvert(ref IStorage pStg, ref GUID pClsidNew);


        /// Return Type: HRESULT->LONG->int
        ///holemenu: HOLEMENU->HGLOBAL->HANDLE->void*
        [DllImport("ole32.dll", EntryPoint = "OleDestroyMenuDescriptor", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleDestroyMenuDescriptor(IntPtr holemenu);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///iid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateStaticFromData", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateStaticFromData(ref IDataObject pSrcDataObj, ref GUID iid, uint renderopt, ref tagFORMATETC pFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HOLEMENU->HGLOBAL->HANDLE->void*
        ///hmenuCombined: HMENU->HMENU__*
        ///lpMenuWidths: LPOLEMENUGROUPWIDTHS->tagOleMenuGroupWidths*
        [DllImport("ole32.dll", EntryPoint = "OleCreateMenuDescriptor", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleCreateMenuDescriptor(IntPtr hmenuCombined, ref tagOleMenuGroupWidths lpMenuWidths);


        /// Return Type: HRESULT->LONG->int
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkToFileEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkToFileEx([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///lpFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkToFile", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkToFile([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, ref GUID riid, uint renderopt, ref tagFORMATETC lpFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkFromDataEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkFromDataEx(ref IDataObject pSrcDataObj, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkFromData", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkFromData(ref IDataObject pSrcDataObj, ref GUID riid, uint renderopt, ref tagFORMATETC pFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pmkLinkSrc: LPMONIKER->IMoniker*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkEx(ref IMoniker pmkLinkSrc, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pmkLinkSrc: LPMONIKER->IMoniker*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///lpFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLink", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLink(ref IMoniker pmkLinkSrc, ref GUID riid, uint renderopt, ref tagFORMATETC lpFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromFileEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromFileEx(ref GUID rclsid, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///lpFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromFile", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromFile(ref GUID rclsid, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, ref GUID riid, uint renderopt, ref tagFORMATETC lpFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromDataEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromDataEx(ref IDataObject pSrcDataObj, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromData", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromData(ref IDataObject pSrcDataObj, ref GUID riid, uint renderopt, ref tagFORMATETC pFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateEx(ref GUID rclsid, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///flags: DWORD->unsigned int
        ///pCF: LPCLASSFACTORY->IClassFactory*
        ///riid: IID*
        ///lplpObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateEmbeddingHelper", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateEmbeddingHelper(ref GUID clsid, ref IUnknown pUnkOuter, uint flags, ref IClassFactory pCF, ref GUID riid, ref IntPtr lplpObj);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///riid: IID*
        ///lplpObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateDefaultHandler", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateDefaultHandler(ref GUID clsid, ref IUnknown pUnkOuter, ref GUID riid, ref IntPtr lplpObj);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreate", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreate(ref GUID rclsid, ref GUID riid, uint renderopt, ref tagFORMATETC pFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///polestm: LPOLESTREAM->_OLESTREAM*
        ///pstg: LPSTORAGE->IStorage*
        ///pcfFormat: CLIPFORMAT*
        ///plwWidth: LONG*
        ///plHeight: LONG*
        ///pdwSize: DWORD*
        ///pmedium: LPSTGMEDIUM->STGMEDIUM*
        [DllImport("ole32.dll", EntryPoint = "OleConvertOLESTREAMToIStorageEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertOLESTREAMToIStorageEx(ref OLESTREAM polestm, ref IStorage pstg, ref ushort pcfFormat, ref int plwWidth, ref int plHeight, ref uint pdwSize, ref tagSTGMEDIUM pmedium);


        /// Return Type: HRESULT->LONG->int
        ///lpolestream: LPOLESTREAM->_OLESTREAM*
        ///pstg: LPSTORAGE->IStorage*
        ///ptd: DVTARGETDEVICE*
        [DllImport("ole32.dll", EntryPoint = "OleConvertOLESTREAMToIStorage", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertOLESTREAMToIStorage(ref OLESTREAM lpolestream, ref IStorage pstg, ref tagDVTARGETDEVICE ptd);


        /// Return Type: HRESULT->LONG->int
        ///pstg: LPSTORAGE->IStorage*
        ///cfFormat: CLIPFORMAT->WORD->unsigned short
        ///lWidth: LONG->int
        ///lHeight: LONG->int
        ///dwSize: DWORD->unsigned int
        ///pmedium: LPSTGMEDIUM->STGMEDIUM*
        ///polestm: LPOLESTREAM->_OLESTREAM*
        [DllImport("ole32.dll", EntryPoint = "OleConvertIStorageToOLESTREAMEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertIStorageToOLESTREAMEx(ref IStorage pstg, ushort cfFormat, int lWidth, int lHeight, uint dwSize, ref tagSTGMEDIUM pmedium, ref OLESTREAM polestm);


        /// Return Type: HRESULT->LONG->int
        ///pstg: LPSTORAGE->IStorage*
        ///lpolestream: LPOLESTREAM->_OLESTREAM*
        [DllImport("ole32.dll", EntryPoint = "OleConvertIStorageToOLESTREAM", CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertIStorageToOLESTREAM(ref IStorage pstg, ref OLESTREAM lpolestream);


        /// Return Type: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "OleBuildVersion", CallingConvention = CallingConvention.StdCall)]
        public static extern uint OleBuildVersion();


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "OffsetWindowOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OffsetWindowOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "OffsetViewportOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OffsetViewportOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);


        /// Return Type: int
        ///hrgn: HRGN->HRGN__*
        ///x: int
        ///y: int
        [DllImport("gdi32.dll", EntryPoint = "OffsetRgn")]
        public static extern int OffsetRgn([In] IntPtr hrgn, int x, int y);


        /// Return Type: BOOL->int
        ///lprc: LPRECT->tagRECT*
        ///dx: int
        ///dy: int
        [DllImport("user32.dll", EntryPoint = "OffsetRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OffsetRect(ref tagRECT lprc, int dx, int dy);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImport("gdi32.dll", EntryPoint = "OffsetClipRgn")]
        public static extern int OffsetClipRgn([In] IntPtr hdc, int x, int y);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "OemToCharW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharW([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszDst);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPWSTR->WCHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OemToCharBuffW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharBuffW([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszDst, uint cchDstLength);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "OemToCharBuffA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharBuffA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszDst, uint cchDstLength);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "OemToCharA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszDst);


        /// Return Type: DWORD->unsigned int
        ///wOemChar: WORD->unsigned short
        [DllImport("user32.dll", EntryPoint = "OemKeyScan")]
        public static extern uint OemKeyScan(ushort wOemChar);


        /// Return Type: HRESULT->LONG->int
        ///dwOption: DWORD->unsigned int
        ///pszUAOut: LPSTR->CHAR*
        ///cbSize: DWORD*
        [DllImport("urlmon.dll", EntryPoint = "ObtainUserAgentString", CallingConvention = CallingConvention.StdCall)]
        public static extern int ObtainUserAgentString(uint dwOption, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszUAOut, ref uint cbSize);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///ClientToken: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///Privileges: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///AccessGranted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "ObjectPrivilegeAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectPrivilegeAuditAlarmW([In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName, [In] IntPtr HandleId, [In] IntPtr ClientToken, uint DesiredAccess, [In] ref PRIVILEGE_SET Privileges, [MarshalAs(UnmanagedType.Bool)] bool AccessGranted);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///ClientToken: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///Privileges: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///AccessGranted: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "ObjectPrivilegeAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectPrivilegeAuditAlarmA([In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName, [In] IntPtr HandleId, [In] IntPtr ClientToken, uint DesiredAccess, [In] ref PRIVILEGE_SET Privileges, [MarshalAs(UnmanagedType.Bool)] bool AccessGranted);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPWSTR->WCHAR*
        ///ObjectName: LPWSTR->WCHAR*
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///ClientToken: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///GrantedAccess: DWORD->unsigned int
        ///Privileges: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///ObjectCreation: BOOL->int
        ///AccessGranted: BOOL->int
        ///GenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "ObjectOpenAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectOpenAuditAlarmW([In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName, [In] IntPtr HandleId, [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectTypeName, [In] [MarshalAs(UnmanagedType.LPWStr)] string ObjectName, [In] IntPtr pSecurityDescriptor, [In] IntPtr ClientToken, uint DesiredAccess, uint GrantedAccess, [In] IntPtr Privileges, [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation, [MarshalAs(UnmanagedType.Bool)] bool AccessGranted, [Out] out int GenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///ObjectTypeName: LPSTR->CHAR*
        ///ObjectName: LPSTR->CHAR*
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///ClientToken: HANDLE->void*
        ///DesiredAccess: DWORD->unsigned int
        ///GrantedAccess: DWORD->unsigned int
        ///Privileges: PPRIVILEGE_SET->_PRIVILEGE_SET*
        ///ObjectCreation: BOOL->int
        ///AccessGranted: BOOL->int
        ///GenerateOnClose: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "ObjectOpenAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectOpenAuditAlarmA([In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName, [In] IntPtr HandleId, [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectTypeName, [In] [MarshalAs(UnmanagedType.LPStr)] string ObjectName, [In] IntPtr pSecurityDescriptor, [In] IntPtr ClientToken, uint DesiredAccess, uint GrantedAccess, [In] IntPtr Privileges, [MarshalAs(UnmanagedType.Bool)] bool ObjectCreation, [MarshalAs(UnmanagedType.Bool)] bool AccessGranted, [Out] out int GenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///GenerateOnClose: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "ObjectDeleteAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectDeleteAuditAlarmW([In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName, [In] IntPtr HandleId, [MarshalAs(UnmanagedType.Bool)] bool GenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///GenerateOnClose: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "ObjectDeleteAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectDeleteAuditAlarmA([In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName, [In] IntPtr HandleId, [MarshalAs(UnmanagedType.Bool)] bool GenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCWSTR->WCHAR*
        ///HandleId: LPVOID->void*
        ///GenerateOnClose: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "ObjectCloseAuditAlarmW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectCloseAuditAlarmW([In] [MarshalAs(UnmanagedType.LPWStr)] string SubsystemName, [In] IntPtr HandleId, [MarshalAs(UnmanagedType.Bool)] bool GenerateOnClose);


        /// Return Type: BOOL->int
        ///SubsystemName: LPCSTR->CHAR*
        ///HandleId: LPVOID->void*
        ///GenerateOnClose: BOOL->int
        [DllImport("advapi32.dll", EntryPoint = "ObjectCloseAuditAlarmA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectCloseAuditAlarmA([In] [MarshalAs(UnmanagedType.LPStr)] string SubsystemName, [In] IntPtr HandleId, [MarshalAs(UnmanagedType.Bool)] bool GenerateOnClose);


        /// Return Type: ULONG->unsigned int
        [DllImport("oleaut32.dll", EntryPoint = "OaBuildVersion", CallingConvention = CallingConvention.StdCall)]
        public static extern uint OaBuildVersion();

    }

}
