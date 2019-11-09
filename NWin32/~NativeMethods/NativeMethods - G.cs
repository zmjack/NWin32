using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;
using FILETIME = NWin32.NativeTypes.FILETIME;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///hBrush: HBRUSH->HBRUSH__*
        ///lpOutputFunc: GRAYSTRINGPROC
        ///lpData: LPARAM->LONG_PTR->int
        ///nCount: int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        [DllImport("user32.dll", EntryPoint = "GrayStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GrayStringW([In] IntPtr hDC, [In] IntPtr hBrush, GRAYSTRINGPROC lpOutputFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lpData, int nCount, int X, int Y, int nWidth, int nHeight);


        /// Return Type: BOOL->int
        ///hDC: HDC->HDC__*
        ///hBrush: HBRUSH->HBRUSH__*
        ///lpOutputFunc: GRAYSTRINGPROC
        ///lpData: LPARAM->LONG_PTR->int
        ///nCount: int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        [DllImport("user32.dll", EntryPoint = "GrayStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GrayStringA([In] IntPtr hDC, [In] IntPtr hBrush, GRAYSTRINGPROC lpOutputFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr lpData, int nCount, int X, int Y, int nWidth, int nHeight);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pVertex: PTRIVERTEX->_TRIVERTEX*
        ///nVertex: ULONG->unsigned int
        ///pMesh: PVOID->void*
        ///nMesh: ULONG->unsigned int
        ///ulMode: ULONG->unsigned int
        [DllImport("msimg32.dll", EntryPoint = "GradientFill")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GradientFill([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] TRIVERTEX[] pVertex, uint nVertex, [In] IntPtr pMesh, uint nMesh, uint ulMode);


        /// Return Type: LPVOID->void*
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalWire")]
        public static extern IntPtr GlobalWire([In] IntPtr hMem);


        /// Return Type: BOOL->int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalUnWire")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnWire([In] IntPtr hMem);


        /// Return Type: BOOL->int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalUnlock([In] IntPtr hMem);


        /// Return Type: void
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalUnfix")]
        public static extern void GlobalUnfix([In] IntPtr hMem);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalSize")]
        public static extern uint GlobalSize([In] IntPtr hMem);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///hMem: HGLOBAL->HANDLE->void*
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GlobalReAlloc")]
        public static extern IntPtr GlobalReAlloc([In] IntPtr hMem, uint dwBytes, uint uFlags);


        /// Return Type: BOOL->int
        ///lpBuffer: LPMEMORYSTATUSEX->_MEMORYSTATUSEX*
        [DllImport("kernel32.dll", EntryPoint = "GlobalMemoryStatusEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx([Out] out MEMORYSTATUSEX lpBuffer);


        /// Return Type: void
        ///lpBuffer: LPMEMORYSTATUS->_MEMORYSTATUS*
        [DllImport("kernel32.dll", EntryPoint = "GlobalMemoryStatus")]
        public static extern void GlobalMemoryStatus([Out] out MEMORYSTATUS lpBuffer);


        /// Return Type: LPVOID->void*
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalLock")]
        public static extern IntPtr GlobalLock([In] IntPtr hMem);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///pMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalHandle")]
        public static extern IntPtr GlobalHandle([In] IntPtr pMem);


        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GlobalGetAtomNameW")]
        public static extern uint GlobalGetAtomNameW(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, int nSize);


        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GlobalGetAtomNameA")]
        public static extern uint GlobalGetAtomNameA(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, int nSize);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFree")]
        public static extern IntPtr GlobalFree(IntPtr hMem);


        /// Return Type: UINT->unsigned int
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFlags")]
        public static extern uint GlobalFlags([In] IntPtr hMem);


        /// Return Type: void
        ///hMem: HGLOBAL->HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFix")]
        public static extern void GlobalFix([In] IntPtr hMem);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFindAtomW")]
        public static extern ushort GlobalFindAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalFindAtomA")]
        public static extern ushort GlobalFindAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: ATOM->WORD->unsigned short
        ///nAtom: ATOM->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GlobalDeleteAtom")]
        public static extern ushort GlobalDeleteAtom(ushort nAtom);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///dwMinFree: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GlobalCompact")]
        public static extern uint GlobalCompact(uint dwMinFree);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///uFlags: UINT->unsigned int
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GlobalAlloc")]
        public static extern IntPtr GlobalAlloc(uint uFlags, uint dwBytes);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalAddAtomW")]
        public static extern ushort GlobalAddAtomW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: ATOM->WORD->unsigned short
        ///lpString: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GlobalAddAtomA")]
        public static extern ushort GlobalAddAtomA([In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpBaseAddress: PVOID->void*
        ///dwRegionSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpAddresses: PVOID*
        ///lpdwCount: ULONG_PTR*
        ///lpdwGranularity: PULONG->ULONG*
        [DllImport("kernel32.dll", EntryPoint = "GetWriteWatch")]
        public static extern uint GetWriteWatch(uint dwFlags, [In] IntPtr lpBaseAddress, uint dwRegionSize, ref IntPtr lpAddresses, ref uint lpdwCount, [Out] out uint lpdwGranularity);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpxf: LPXFORM->tagXFORM*
        [DllImport("gdi32.dll", EntryPoint = "GetWorldTransform")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWorldTransform([In] IntPtr hdc, [Out] out tagXFORM lpxf);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cbData16: UINT->unsigned int
        ///pData16: LPBYTE->BYTE*
        ///iMapMode: INT->int
        ///hdcRef: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetWinMetaFileBits")]
        public static extern uint GetWinMetaFileBits([In] IntPtr hemf, uint cbData16, IntPtr pData16, int iMapMode, [In] IntPtr hdcRef);


        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetWindowWord")]
        public static extern ushort GetWindowWord([In] IntPtr hWnd, int nIndex);


        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///lpdwProcessId: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
        public static extern uint GetWindowThreadProcessId([In] IntPtr hWnd, IntPtr lpdwProcessId);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpString: LPWSTR->WCHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetWindowTextW")]
        public static extern int GetWindowTextW([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString, int nMaxCount);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthW")]
        public static extern int GetWindowTextLengthW([In] IntPtr hWnd);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthA")]
        public static extern int GetWindowTextLengthA([In] IntPtr hWnd);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpString: LPSTR->CHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetWindowTextA")]
        public static extern int GetWindowTextA([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString, int nMaxCount);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetWindowsDirectoryW")]
        public static extern uint GetWindowsDirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetWindowsDirectoryA")]
        public static extern uint GetWindowsDirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: BOOL->int
        ///pSid: PSID->PVOID->void*
        ///pDomainSid: PSID->PVOID->void*
        ///cbDomainSid: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetWindowsAccountDomainSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowsAccountDomainSid([In] IntPtr pSid, IntPtr pDomainSid, ref uint cbDomainSid);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lprc: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetWindowRgnBox")]
        public static extern int GetWindowRgnBox([In] IntPtr hWnd, [Out] out tagRECT lprc);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        [DllImport("user32.dll", EntryPoint = "GetWindowRgn")]
        public static extern int GetWindowRgn([In] IntPtr hWnd, [In] IntPtr hRgn);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetWindowRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect([In] IntPtr hWnd, [Out] out tagRECT lpRect);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpwndpl: WINDOWPLACEMENT*
        [DllImport("user32.dll", EntryPoint = "GetWindowPlacement")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowPlacement([In] IntPtr hWnd, ref tagWINDOWPLACEMENT lpwndpl);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppoint: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "GetWindowOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowOrgEx([In] IntPtr hdc, [Out] out Point lppoint);


        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///pszFileName: LPWSTR->WCHAR*
        ///cchFileNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetWindowModuleFileNameW")]
        public static extern uint GetWindowModuleFileNameW([In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszFileName, uint cchFileNameMax);


        /// Return Type: UINT->unsigned int
        ///hwnd: HWND->HWND__*
        ///pszFileName: LPSTR->CHAR*
        ///cchFileNameMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetWindowModuleFileNameA")]
        public static extern uint GetWindowModuleFileNameA([In] IntPtr hwnd, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszFileName, uint cchFileNameMax);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetWindowLongW")]
        public static extern int GetWindowLongW([In] IntPtr hWnd, int nIndex);


        /// Return Type: LONG->int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetWindowLongA")]
        public static extern int GetWindowLongA([In] IntPtr hWnd, int nIndex);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pwi: PWINDOWINFO->tagWINDOWINFO*
        [DllImport("user32.dll", EntryPoint = "GetWindowInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowInfo([In] IntPtr hwnd, ref tagWINDOWINFO pwi);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetWindowExtEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowExtEx([In] IntPtr hdc, [Out] out tagSIZE lpsize);


        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
        public static extern IntPtr GetWindowDC([In] IntPtr hWnd);


        /// Return Type: DWORD->unsigned int
        ///param0: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetWindowContextHelpId")]
        public static extern uint GetWindowContextHelpId([In] IntPtr param0);


        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        ///uCmd: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetWindow")]
        public static extern IntPtr GetWindow([In] IntPtr hWnd, uint uCmd);


        /// Return Type: BOOL->int
        ///lpszFileName: LPCWSTR->WCHAR*
        ///lpszVolumePathName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszVolumePathName, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///lpszVolumeName: LPCWSTR->WCHAR*
        ///lpszVolumePathNames: LPWCH->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        ///lpcchReturnLength: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNamesForVolumeNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNamesForVolumeNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszVolumePathNames, uint cchBufferLength, [Out] out uint lpcchReturnLength);


        /// Return Type: BOOL->int
        ///lpszVolumeName: LPCSTR->CHAR*
        ///lpszVolumePathNames: LPCH->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        ///lpcchReturnLength: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNamesForVolumeNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNamesForVolumeNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszVolumePathNames, uint cchBufferLength, [Out] out uint lpcchReturnLength);


        /// Return Type: BOOL->int
        ///lpszFileName: LPCSTR->CHAR*
        ///lpszVolumePathName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumePathNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumePathNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszFileName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszVolumePathName, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCWSTR->WCHAR*
        ///lpszVolumeName: LPWSTR->WCHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeNameForVolumeMountPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeNameForVolumeMountPointW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszVolumeName, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///lpszVolumeMountPoint: LPCSTR->CHAR*
        ///lpszVolumeName: LPSTR->CHAR*
        ///cchBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeNameForVolumeMountPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeNameForVolumeMountPointA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszVolumeMountPoint, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszVolumeName, uint cchBufferLength);


        /// Return Type: BOOL->int
        ///lpRootPathName: LPCWSTR->WCHAR*
        ///lpVolumeNameBuffer: LPWSTR->WCHAR*
        ///nVolumeNameSize: DWORD->unsigned int
        ///lpVolumeSerialNumber: LPDWORD->DWORD*
        ///lpMaximumComponentLength: LPDWORD->DWORD*
        ///lpFileSystemFlags: LPDWORD->DWORD*
        ///lpFileSystemNameBuffer: LPWSTR->WCHAR*
        ///nFileSystemNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeInformationW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeInformationW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpVolumeNameBuffer, uint nVolumeNameSize, IntPtr lpVolumeSerialNumber, IntPtr lpMaximumComponentLength, IntPtr lpFileSystemFlags, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpFileSystemNameBuffer, uint nFileSystemNameSize);


        /// Return Type: BOOL->int
        ///lpRootPathName: LPCSTR->CHAR*
        ///lpVolumeNameBuffer: LPSTR->CHAR*
        ///nVolumeNameSize: DWORD->unsigned int
        ///lpVolumeSerialNumber: LPDWORD->DWORD*
        ///lpMaximumComponentLength: LPDWORD->DWORD*
        ///lpFileSystemFlags: LPDWORD->DWORD*
        ///lpFileSystemNameBuffer: LPSTR->CHAR*
        ///nFileSystemNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeInformationA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVolumeInformationA([In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpVolumeNameBuffer, uint nVolumeNameSize, IntPtr lpVolumeSerialNumber, IntPtr lpMaximumComponentLength, IntPtr lpFileSystemFlags, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpFileSystemNameBuffer, uint nFileSystemNameSize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppoint: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "GetViewportOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetViewportOrgEx([In] IntPtr hdc, [Out] out Point lppoint);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetViewportExtEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetViewportExtEx([In] IntPtr hdc, [Out] out tagSIZE lpsize);


        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOW->_OSVERSIONINFOW*
        [DllImport("kernel32.dll", EntryPoint = "GetVersionExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExW(ref RTL_OSVERSIONINFOW lpVersionInformation);


        /// Return Type: BOOL->int
        ///lpVersionInformation: LPOSVERSIONINFOA->_OSVERSIONINFOA*
        [DllImport("kernel32.dll", EntryPoint = "GetVersionExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetVersionExA(ref OSVERSIONINFOA lpVersionInformation);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetVersion")]
        public static extern uint GetVersion();


        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///pSIRequested: PSECURITY_INFORMATION->DWORD*
        ///pSID: PSECURITY_DESCRIPTOR->PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetUserObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectSecurity([In] IntPtr hObj, [In] ref uint pSIRequested, IntPtr pSID, uint nLength, [Out] out uint lpnLengthNeeded);


        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetUserObjectInformationW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectInformationW([In] IntPtr hObj, int nIndex, IntPtr pvInfo, uint nLength, IntPtr lpnLengthNeeded);


        /// Return Type: BOOL->int
        ///hObj: HANDLE->void*
        ///nIndex: int
        ///pvInfo: PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("user32.dll", EntryPoint = "GetUserObjectInformationA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectInformationA([In] IntPtr hObj, int nIndex, IntPtr pvInfo, uint nLength, IntPtr lpnLengthNeeded);


        /// Return Type: BOOL->int
        ///lpBuffer: LPWSTR->WCHAR*
        ///pcbBuffer: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetUserNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserNameW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, ref uint pcbBuffer);


        /// Return Type: BOOL->int
        ///lpBuffer: LPSTR->CHAR*
        ///pcbBuffer: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetUserNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserNameA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, ref uint pcbBuffer);


        /// Return Type: GEOID->LONG->int
        ///GeoClass: GEOCLASS->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetUserGeoID")]
        public static extern int GetUserGeoID(uint GeoClass);


        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetUserDefaultUILanguage")]
        public static extern ushort GetUserDefaultUILanguage();


        /// Return Type: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetUserDefaultLCID")]
        public static extern uint GetUserDefaultLCID();


        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetUserDefaultLangID")]
        public static extern ushort GetUserDefaultLangID();


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///hRgn: HRGN->HRGN__*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetUpdateRgn")]
        public static extern int GetUpdateRgn([In] IntPtr hWnd, [In] IntPtr hRgn, [MarshalAs(UnmanagedType.Bool)] bool bErase);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        ///bErase: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetUpdateRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUpdateRect([In] IntPtr hWnd, IntPtr lpRect, [MarshalAs(UnmanagedType.Bool)] bool bErase);


        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetTopWindow")]
        public static extern IntPtr GetTopWindow([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///TokenHandle: HANDLE->void*
        ///TokenInformationClass: TOKEN_INFORMATION_CLASS->_TOKEN_INFORMATION_CLASS
        ///TokenInformation: LPVOID->void*
        ///TokenInformationLength: DWORD->unsigned int
        ///ReturnLength: PDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetTokenInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTokenInformation([In] IntPtr TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, IntPtr TokenInformation, uint TokenInformationLength, IntPtr ReturnLength);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pti: PTITLEBARINFO->tagTITLEBARINFO*
        [DllImport("user32.dll", EntryPoint = "GetTitleBarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTitleBarInfo([In] IntPtr hwnd, ref tagTITLEBARINFO pti);


        /// Return Type: DWORD->unsigned int
        ///lpTimeZoneInformation: LPTIME_ZONE_INFORMATION->_TIME_ZONE_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "GetTimeZoneInformation")]
        public static extern uint GetTimeZoneInformation([Out] out TIME_ZONE_INFORMATION lpTimeZoneInformation);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpTime: SYSTEMTIME*
        ///lpFormat: LPCWSTR->WCHAR*
        ///lpTimeStr: LPWSTR->WCHAR*
        ///cchTime: int
        [DllImport("kernel32.dll", EntryPoint = "GetTimeFormatW")]
        public static extern int GetTimeFormatW(uint Locale, uint dwFlags, [In] IntPtr lpTime, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpTimeStr, int cchTime);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpTime: SYSTEMTIME*
        ///lpFormat: LPCSTR->CHAR*
        ///lpTimeStr: LPSTR->CHAR*
        ///cchTime: int
        [DllImport("kernel32.dll", EntryPoint = "GetTimeFormatA")]
        public static extern int GetTimeFormatA(uint Locale, uint dwFlags, [In] IntPtr lpTime, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFormat, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpTimeStr, int cchTime);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetTickCount")]
        public static extern uint GetTickCount();


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpCreationTime: LPFILETIME->_FILETIME*
        ///lpExitTime: LPFILETIME->_FILETIME*
        ///lpKernelTime: LPFILETIME->_FILETIME*
        ///lpUserTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadTimes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadTimes([In] IntPtr hThread, [Out] out FILETIME lpCreationTime, [Out] out FILETIME lpExitTime, [Out] out FILETIME lpKernelTime, [Out] out FILETIME lpUserTime);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///dwSelector: DWORD->unsigned int
        ///lpSelectorEntry: LPLDT_ENTRY->PLDT_ENTRY->_LDT_ENTRY*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadSelectorEntry")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadSelectorEntry([In] IntPtr hThread, uint dwSelector, [Out] out LDT_ENTRY lpSelectorEntry);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///pDisablePriorityBoost: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadPriorityBoost([In] IntPtr hThread, [Out] out int pDisablePriorityBoost);


        /// Return Type: int
        ///hThread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadPriority")]
        public static extern int GetThreadPriority([In] IntPtr hThread);


        /// Return Type: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetThreadLocale")]
        public static extern uint GetThreadLocale();


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpIOIsPending: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadIOPendingFlag")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadIOPendingFlag([In] IntPtr hThread, [Out] out int lpIOIsPending);


        /// Return Type: DWORD->unsigned int
        ///Thread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadId")]
        public static extern uint GetThreadId([In] IntPtr Thread);


        /// Return Type: HDESK->HDESK__*
        ///dwThreadId: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
        public static extern IntPtr GetThreadDesktop(uint dwThreadId);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpContext: LPCONTEXT->PCONTEXT->CONTEXT*
        [DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadContext([In] IntPtr hThread, ref CONTEXT lpContext);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lptm: LPTEXTMETRICW->tagTEXTMETRICW*
        [DllImport("gdi32.dll", EntryPoint = "GetTextMetricsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextMetricsW([In] IntPtr hdc, [Out] out tagTEXTMETRICW lptm);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lptm: LPTEXTMETRICA->tagTEXTMETRICA*
        [DllImport("gdi32.dll", EntryPoint = "GetTextMetricsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextMetricsA([In] IntPtr hdc, [Out] out tagTEXTMETRICA lptm);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///c: int
        ///lpName: LPWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetTextFaceW")]
        public static extern int GetTextFaceW([In] IntPtr hdc, int c, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpName);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///c: int
        ///lpName: LPSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetTextFaceA")]
        public static extern int GetTextFaceA([In] IntPtr hdc, int c, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpName);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///c: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPointW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int c, [Out] out tagSIZE lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pgiIn: LPWORD->WORD*
        ///cgi: int
        ///psize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentPointI")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPointI([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] pgiIn, int cgi, [Out] out tagSIZE psize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///c: int
        ///lpsz: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPointA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int c, [Out] out tagSIZE lpsz);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///c: int
        ///psizl: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentPoint32W")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPoint32W([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int c, [Out] out tagSIZE psizl);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///c: int
        ///psizl: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentPoint32A")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentPoint32A([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int c, [Out] out tagSIZE psizl);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpszString: LPCWSTR->WCHAR*
        ///cchString: int
        ///nMaxExtent: int
        ///lpnFit: LPINT->int*
        ///lpnDx: LPINT->int*
        ///lpSize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentExPointW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentExPointW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszString, int cchString, int nMaxExtent, IntPtr lpnFit, IntPtr lpnDx, [Out] out tagSIZE lpSize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpwszString: LPWORD->WORD*
        ///cwchString: int
        ///nMaxExtent: int
        ///lpnFit: LPINT->int*
        ///lpnDx: LPINT->int*
        ///lpSize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentExPointI")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentExPointI([In] IntPtr hdc, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] ushort[] lpwszString, int cwchString, int nMaxExtent, IntPtr lpnFit, IntPtr lpnDx, [Out] out tagSIZE lpSize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpszString: LPCSTR->CHAR*
        ///cchString: int
        ///nMaxExtent: int
        ///lpnFit: LPINT->int*
        ///lpnDx: LPINT->int*
        ///lpSize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetTextExtentExPointA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTextExtentExPointA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszString, int cchString, int nMaxExtent, IntPtr lpnFit, IntPtr lpnDx, [Out] out tagSIZE lpSize);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetTextColor")]
        public static extern uint GetTextColor([In] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lpSig: LPFONTSIGNATURE->tagFONTSIGNATURE*
        ///dwFlags: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetTextCharsetInfo")]
        public static extern int GetTextCharsetInfo([In] IntPtr hdc, IntPtr lpSig, uint dwFlags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetTextCharset")]
        public static extern int GetTextCharset([In] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetTextCharacterExtra")]
        public static extern int GetTextCharacterExtra([In] IntPtr hdc);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetTextAlign")]
        public static extern uint GetTextAlign([In] IntPtr hdc);


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempPathW")]
        public static extern uint GetTempPathW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempPathA")]
        public static extern uint GetTempPathA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: UINT->unsigned int
        ///lpPathName: LPCWSTR->WCHAR*
        ///lpPrefixString: LPCWSTR->WCHAR*
        ///uUnique: UINT->unsigned int
        ///lpTempFileName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempFileNameW")]
        public static extern uint GetTempFileNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpTempFileName);


        /// Return Type: UINT->unsigned int
        ///lpPathName: LPCSTR->CHAR*
        ///lpPrefixString: LPCSTR->CHAR*
        ///uUnique: UINT->unsigned int
        ///lpTempFileName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetTempFileNameA")]
        public static extern uint GetTempFileNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpTempFileName);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetTapeStatus")]
        public static extern uint GetTapeStatus([In] IntPtr hDevice);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwPositionType: DWORD->unsigned int
        ///lpdwPartition: LPDWORD->DWORD*
        ///lpdwOffsetLow: LPDWORD->DWORD*
        ///lpdwOffsetHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetTapePosition")]
        public static extern uint GetTapePosition([In] IntPtr hDevice, uint dwPositionType, [Out] out uint lpdwPartition, [Out] out uint lpdwOffsetLow, [Out] out uint lpdwOffsetHigh);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwOperation: DWORD->unsigned int
        ///lpdwSize: LPDWORD->DWORD*
        ///lpTapeInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GetTapeParameters")]
        public static extern uint GetTapeParameters([In] IntPtr hDevice, uint dwOperation, ref uint lpdwSize, IntPtr lpTapeInformation);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        [DllImport("user32.dll", EntryPoint = "GetTabbedTextExtentW")]
        public static extern uint GetTabbedTextExtentW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///chCount: int
        ///nTabPositions: int
        ///lpnTabStopPositions: INT*
        [DllImport("user32.dll", EntryPoint = "GetTabbedTextExtentA")]
        public static extern uint GetTabbedTextExtentA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int chCount, int nTabPositions, [In] IntPtr lpnTabStopPositions);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWow64DirectoryW")]
        public static extern uint GetSystemWow64DirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWow64DirectoryA")]
        public static extern uint GetSystemWow64DirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWindowsDirectoryW")]
        public static extern uint GetSystemWindowsDirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemWindowsDirectoryA")]
        public static extern uint GetSystemWindowsDirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: BOOL->int
        ///lpIdleTime: LPFILETIME->_FILETIME*
        ///lpKernelTime: LPFILETIME->_FILETIME*
        ///lpUserTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTimes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemTimes(IntPtr lpIdleTime, IntPtr lpKernelTime, IntPtr lpUserTime);


        /// Return Type: void
        ///lpSystemTimeAsFileTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTimeAsFileTime")]
        public static extern void GetSystemTimeAsFileTime([Out] out FILETIME lpSystemTimeAsFileTime);


        /// Return Type: BOOL->int
        ///lpTimeAdjustment: PDWORD->DWORD*
        ///lpTimeIncrement: PDWORD->DWORD*
        ///lpTimeAdjustmentDisabled: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTimeAdjustment")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemTimeAdjustment([Out] out uint lpTimeAdjustment, [Out] out uint lpTimeIncrement, [Out] out int lpTimeAdjustmentDisabled);


        /// Return Type: void
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime")]
        public static extern void GetSystemTime([Out] out SYSTEMTIME lpSystemTime);


        /// Return Type: BOOL->int
        ///pdwQuotaAllowed: PDWORD->DWORD*
        ///pdwQuotaUsed: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemRegistryQuota")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemRegistryQuota(IntPtr pdwQuotaAllowed, IntPtr pdwQuotaUsed);


        /// Return Type: BOOL->int
        ///lpSystemPowerStatus: LPSYSTEM_POWER_STATUS->_SYSTEM_POWER_STATUS*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemPowerStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemPowerStatus([Out] out SYSTEM_POWER_STATUS lpSystemPowerStatus);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetSystemPaletteUse")]
        public static extern uint GetSystemPaletteUse([In] IntPtr hdc);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///pPalEntries: LPPALETTEENTRY->tagPALETTEENTRY*
        [DllImport("gdi32.dll", EntryPoint = "GetSystemPaletteEntries")]
        public static extern uint GetSystemPaletteEntries([In] IntPtr hdc, uint iStart, uint cEntries, IntPtr pPalEntries);


        /// Return Type: int
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int nIndex);


        /// Return Type: HMENU->HMENU__*
        ///hWnd: HWND->HWND__*
        ///bRevert: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
        public static extern IntPtr GetSystemMenu([In] IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool bRevert);


        /// Return Type: void
        ///lpSystemInfo: LPSYSTEM_INFO->_SYSTEM_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemInfo")]
        public static extern void GetSystemInfo([Out] out SYSTEM_INFO lpSystemInfo);


        /// Return Type: UINT->unsigned int
        ///FirmwareTableProviderSignature: DWORD->unsigned int
        ///FirmwareTableID: DWORD->unsigned int
        ///pFirmwareTableBuffer: PVOID->void*
        ///BufferSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemFirmwareTable")]
        public static extern uint GetSystemFirmwareTable(uint FirmwareTableProviderSignature, uint FirmwareTableID, IntPtr pFirmwareTableBuffer, uint BufferSize);


        /// Return Type: BOOL->int
        ///lpMinimumFileCacheSize: PSIZE_T->ULONG_PTR*
        ///lpMaximumFileCacheSize: PSIZE_T->ULONG_PTR*
        ///lpFlags: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetSystemFileCacheSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSystemFileCacheSize([Out] out uint lpMinimumFileCacheSize, [Out] out uint lpMaximumFileCacheSize, [Out] out uint lpFlags);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDirectoryW")]
        public static extern uint GetSystemDirectoryW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: UINT->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///uSize: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDirectoryA")]
        public static extern uint GetSystemDirectoryA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, uint uSize);


        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultUILanguage")]
        public static extern ushort GetSystemDefaultUILanguage();


        /// Return Type: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultLCID")]
        public static extern uint GetSystemDefaultLCID();


        /// Return Type: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetSystemDefaultLangID")]
        public static extern ushort GetSystemDefaultLangID();


        /// Return Type: HBRUSH->HBRUSH__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetSysColorBrush")]
        public static extern IntPtr GetSysColorBrush(int nIndex);


        /// Return Type: DWORD->unsigned int
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetSysColor")]
        public static extern uint GetSysColor(int nIndex);


        /// Return Type: HMENU->HMENU__*
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint = "GetSubMenu")]
        public static extern IntPtr GetSubMenu([In] IntPtr hMenu, int nPos);


        /// Return Type: BOOL->int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeW(uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCWSTR->WCHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeExW(uint Locale, uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeExA(uint Locale, uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);


        /// Return Type: BOOL->int
        ///Locale: LCID->DWORD->unsigned int
        ///dwInfoType: DWORD->unsigned int
        ///lpSrcStr: LPCSTR->CHAR*
        ///cchSrc: int
        ///lpCharType: LPWORD->WORD*
        [DllImport("kernel32.dll", EntryPoint = "GetStringTypeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetStringTypeA(uint Locale, uint dwInfoType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpSrcStr, int cchSrc, [Out] out ushort lpCharType);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetStretchBltMode")]
        public static extern int GetStretchBltMode([In] IntPtr hdc);


        /// Return Type: HGDIOBJ->void*
        ///i: int
        [DllImport("gdi32.dll", EntryPoint = "GetStockObject")]
        public static extern IntPtr GetStockObject(int i);


        /// Return Type: HANDLE->void*
        ///nStdHandle: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle")]
        public static extern IntPtr GetStdHandle(uint nStdHandle);


        /// Return Type: void
        ///lpStartupInfo: LPSTARTUPINFOW->_STARTUPINFOW*
        [DllImport("kernel32.dll", EntryPoint = "GetStartupInfoW")]
        public static extern void GetStartupInfoW([Out] out STARTUPINFOW lpStartupInfo);


        /// Return Type: void
        ///lpStartupInfo: LPSTARTUPINFOA->_STARTUPINFOA*
        [DllImport("kernel32.dll", EntryPoint = "GetStartupInfoA")]
        public static extern void GetStartupInfoA([Out] out STARTUPINFOA lpStartupInfo);


        /// Return Type: HRESULT->LONG->int
        ///szDistUnit: LPCWSTR->WCHAR*
        ///psdi: LPSOFTDISTINFO->_tagSOFTDISTINFO*
        [DllImport("urlmon.dll", EntryPoint = "GetSoftwareUpdateInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSoftwareUpdateInfo([In] [MarshalAs(UnmanagedType.LPWStr)] string szDistUnit, ref SOFTDISTINFO psdi);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///level: int
        ///optname: int
        ///optval: char*
        ///optlen: int*
        [DllImport("ws2_32.dll", EntryPoint = "getsockopt", CallingConvention = CallingConvention.StdCall)]
        public static extern int getsockopt([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, int level, int optname, IntPtr optval, ref int optlen);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///name: sockaddr*
        ///namelen: int*
        [DllImport("ws2_32.dll", EntryPoint = "getsockname", CallingConvention = CallingConvention.StdCall)]
        public static extern int getsockname([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, ref sockaddr name, ref int namelen);


        /// Return Type: PUCHAR->UCHAR*
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "GetSidSubAuthorityCount")]
        public static extern IntPtr GetSidSubAuthorityCount([In] IntPtr pSid);


        /// Return Type: PDWORD->DWORD*
        ///pSid: PSID->PVOID->void*
        ///nSubAuthority: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "GetSidSubAuthority")]
        public static extern IntPtr GetSidSubAuthority([In] IntPtr pSid, uint nSubAuthority);


        /// Return Type: DWORD->unsigned int
        ///nSubAuthorityCount: UCHAR->unsigned char
        [DllImport("advapi32.dll", EntryPoint = "GetSidLengthRequired")]
        public static extern uint GetSidLengthRequired(byte nSubAuthorityCount);


        /// Return Type: PSID_IDENTIFIER_AUTHORITY->_SID_IDENTIFIER_AUTHORITY*
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "GetSidIdentifierAuthority")]
        public static extern IntPtr GetSidIdentifierAuthority([In] IntPtr pSid);


        /// Return Type: DWORD->unsigned int
        ///lpszLongPath: LPCWSTR->WCHAR*
        ///lpszShortPath: LPWSTR->WCHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetShortPathNameW")]
        public static extern uint GetShortPathNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszLongPath, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszShortPath, uint cchBuffer);


        /// Return Type: DWORD->unsigned int
        ///lpszLongPath: LPCSTR->CHAR*
        ///lpszShortPath: LPSTR->CHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetShortPathNameA")]
        public static extern uint GetShortPathNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszLongPath, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszShortPath, uint cchBuffer);


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetShellWindow")]
        public static extern IntPtr GetShellWindow();


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpDisplayName: LPCWSTR->WCHAR*
        ///lpServiceName: LPWSTR->WCHAR*
        ///lpcchBuffer: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetServiceKeyNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetServiceKeyNameW([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDisplayName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpServiceName, ref uint lpcchBuffer);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpDisplayName: LPCSTR->CHAR*
        ///lpServiceName: LPSTR->CHAR*
        ///lpcchBuffer: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetServiceKeyNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetServiceKeyNameA([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDisplayName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpServiceName, ref uint lpcchBuffer);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpServiceName: LPCWSTR->WCHAR*
        ///lpDisplayName: LPWSTR->WCHAR*
        ///lpcchBuffer: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetServiceDisplayNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetServiceDisplayNameW([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpServiceName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpDisplayName, ref uint lpcchBuffer);


        /// Return Type: BOOL->int
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpServiceName: LPCSTR->CHAR*
        ///lpDisplayName: LPSTR->CHAR*
        ///lpcchBuffer: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetServiceDisplayNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetServiceDisplayNameA([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPStr)] string lpServiceName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpDisplayName, ref uint lpcchBuffer);


        /// Return Type: servent*
        ///port: int
        ///proto: char*
        [DllImport("ws2_32.dll", EntryPoint = "getservbyport", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr getservbyport(int port, [In] [MarshalAs(UnmanagedType.LPStr)] string proto);


        /// Return Type: servent*
        ///name: char*
        ///proto: char*
        [DllImport("ws2_32.dll", EntryPoint = "getservbyname", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr getservbyname([In] [MarshalAs(UnmanagedType.LPStr)] string name, [In] [MarshalAs(UnmanagedType.LPStr)] string proto);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///lpbSaclPresent: LPBOOL->BOOL*
        ///pSacl: PACL*
        ///lpbSaclDefaulted: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "GetSecurityDescriptorSacl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSecurityDescriptorSacl([In] IntPtr pSecurityDescriptor, [Out] out int lpbSaclPresent, out IntPtr pSacl, [Out] out int lpbSaclDefaulted);


        /// Return Type: DWORD->unsigned int
        ///SecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///RMControl: PUCHAR->UCHAR*
        [DllImport("advapi32.dll", EntryPoint = "GetSecurityDescriptorRMControl")]
        public static extern uint GetSecurityDescriptorRMControl([In] IntPtr SecurityDescriptor, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder RMControl);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///pOwner: PSID*
        ///lpbOwnerDefaulted: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "GetSecurityDescriptorOwner")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSecurityDescriptorOwner([In] IntPtr pSecurityDescriptor, out IntPtr pOwner, [Out] out int lpbOwnerDefaulted);


        /// Return Type: DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "GetSecurityDescriptorLength")]
        public static extern uint GetSecurityDescriptorLength([In] IntPtr pSecurityDescriptor);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///pGroup: PSID*
        ///lpbGroupDefaulted: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "GetSecurityDescriptorGroup")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSecurityDescriptorGroup([In] IntPtr pSecurityDescriptor, out IntPtr pGroup, [Out] out int lpbGroupDefaulted);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///lpbDaclPresent: LPBOOL->BOOL*
        ///pDacl: PACL*
        ///lpbDaclDefaulted: LPBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "GetSecurityDescriptorDacl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSecurityDescriptorDacl([In] IntPtr pSecurityDescriptor, [Out] out int lpbDaclPresent, out IntPtr pDacl, [Out] out int lpbDaclDefaulted);


        /// Return Type: BOOL->int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///pControl: PSECURITY_DESCRIPTOR_CONTROL->WORD*
        ///lpdwRevision: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetSecurityDescriptorControl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSecurityDescriptorControl([In] IntPtr pSecurityDescriptor, [Out] out ushort pControl, [Out] out uint lpdwRevision);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        ///lpMinPos: LPINT->int*
        ///lpMaxPos: LPINT->int*
        [DllImport("user32.dll", EntryPoint = "GetScrollRange")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollRange([In] IntPtr hWnd, int nBar, [Out] out int lpMinPos, [Out] out int lpMaxPos);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///nBar: int
        [DllImport("user32.dll", EntryPoint = "GetScrollPos")]
        public static extern int GetScrollPos([In] IntPtr hWnd, int nBar);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///nBar: int
        ///lpsi: LPSCROLLINFO->tagSCROLLINFO*
        [DllImport("user32.dll", EntryPoint = "GetScrollInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollInfo([In] IntPtr hwnd, int nBar, ref tagSCROLLINFO lpsi);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///idObject: LONG->int
        ///psbi: PSCROLLBARINFO->tagSCROLLBARINFO*
        [DllImport("user32.dll", EntryPoint = "GetScrollBarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollBarInfo([In] IntPtr hwnd, int idObject, ref tagSCROLLBARINFO psbi);


        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport("comdlg32.dll", EntryPoint = "GetSaveFileNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSaveFileNameW(ref tagOFNW param0);


        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEA->tagOFNA*
        [DllImport("comdlg32.dll", EntryPoint = "GetSaveFileNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetSaveFileNameA(ref tagOFNA param0);


        /// Return Type: HRESULT->LONG->int
        ///reserved: DWORD->unsigned int
        ///pprot: LPRUNNINGOBJECTTABLE*
        [DllImport("ole32.dll", EntryPoint = "GetRunningObjectTable", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRunningObjectTable(uint reserved, ref IntPtr pprot);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetROP2")]
        public static extern int GetROP2([In] IntPtr hdc);


        /// Return Type: int
        ///hrgn: HRGN->HRGN__*
        ///lprc: LPRECT->tagRECT*
        [DllImport("gdi32.dll", EntryPoint = "GetRgnBox")]
        public static extern int GetRgnBox([In] IntPtr hrgn, [Out] out tagRECT lprc);


        /// Return Type: UINT->unsigned int
        ///pRawInputDevices: PRAWINPUTDEVICE->tagRAWINPUTDEVICE*
        ///puiNumDevices: PUINT->unsigned int*
        ///cbSize: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRegisteredRawInputDevices")]
        public static extern uint GetRegisteredRawInputDevices(IntPtr pRawInputDevices, ref uint puiNumDevices, uint cbSize);


        /// Return Type: DWORD->unsigned int
        ///hrgn: HRGN->HRGN__*
        ///nCount: DWORD->unsigned int
        ///lpRgnData: LPRGNDATA->_RGNDATA*
        [DllImport("gdi32.dll", EntryPoint = "GetRegionData")]
        public static extern uint GetRegionData([In] IntPtr hrgn, uint nCount, IntPtr lpRgnData);


        /// Return Type: HRESULT->LONG->int
        ///pTypeInfo: ITypeInfo*
        ///ppRecInfo: IRecordInfo**
        [DllImport("oleaut32.dll", EntryPoint = "GetRecordInfoFromTypeInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRecordInfoFromTypeInfo(ref ITypeInfo pTypeInfo, ref IntPtr ppRecInfo);


        /// Return Type: HRESULT->LONG->int
        ///rGuidTypeLib: GUID*
        ///uVerMajor: ULONG->unsigned int
        ///uVerMinor: ULONG->unsigned int
        ///lcid: LCID->DWORD->unsigned int
        ///rGuidTypeInfo: GUID*
        ///ppRecInfo: IRecordInfo**
        [DllImport("oleaut32.dll", EntryPoint = "GetRecordInfoFromGuids", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRecordInfoFromGuids(ref GUID rGuidTypeLib, uint uVerMajor, uint uVerMinor, uint lcid, ref GUID rGuidTypeInfo, ref IntPtr ppRecInfo);


        /// Return Type: UINT->unsigned int
        ///pRawInputDeviceList: PRAWINPUTDEVICELIST->tagRAWINPUTDEVICELIST*
        ///puiNumDevices: PUINT->unsigned int*
        ///cbSize: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceList")]
        public static extern uint GetRawInputDeviceList(IntPtr pRawInputDeviceList, ref uint puiNumDevices, uint cbSize);


        /// Return Type: UINT->unsigned int
        ///hDevice: HANDLE->void*
        ///uiCommand: UINT->unsigned int
        ///pData: LPVOID->void*
        ///pcbSize: PUINT->unsigned int*
        [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceInfoW")]
        public static extern uint GetRawInputDeviceInfoW([In] IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);


        /// Return Type: UINT->unsigned int
        ///hDevice: HANDLE->void*
        ///uiCommand: UINT->unsigned int
        ///pData: LPVOID->void*
        ///pcbSize: PUINT->unsigned int*
        [DllImport("user32.dll", EntryPoint = "GetRawInputDeviceInfoA")]
        public static extern uint GetRawInputDeviceInfoA([In] IntPtr hDevice, uint uiCommand, IntPtr pData, ref uint pcbSize);


        /// Return Type: UINT->unsigned int
        ///hRawInput: HRAWINPUT->HRAWINPUT__*
        ///uiCommand: UINT->unsigned int
        ///pData: LPVOID->void*
        ///pcbSize: PUINT->unsigned int*
        ///cbSizeHeader: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRawInputData")]
        public static extern uint GetRawInputData([In] IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);


        /// Return Type: UINT->unsigned int
        ///pData: PRAWINPUT->tagRAWINPUT*
        ///pcbSize: PUINT->unsigned int*
        ///cbSizeHeader: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetRawInputBuffer")]
        public static extern uint GetRawInputBuffer(IntPtr pData, ref uint pcbSize, uint cbSizeHeader);


        /// Return Type: BOOL->int
        ///lpraststat: LPRASTERIZER_STATUS->_RASTERIZER_STATUS*
        ///cjBytes: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetRasterizerCaps")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetRasterizerCaps(IntPtr lpraststat, uint cjBytes);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        ///i: INT->int
        [DllImport("gdi32.dll", EntryPoint = "GetRandomRgn")]
        public static extern int GetRandomRgn([In] IntPtr hdc, [In] IntPtr hrgn, int i);


        /// Return Type: DWORD->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetQueueStatus")]
        public static extern uint GetQueueStatus(uint flags);


        /// Return Type: BOOL->int
        ///CompletionPort: HANDLE->void*
        ///lpNumberOfBytesTransferred: LPDWORD->DWORD*
        ///lpCompletionKey: PULONG_PTR->unsigned int*
        ///lpOverlapped: LPOVERLAPPED*
        ///dwMilliseconds: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetQueuedCompletionStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetQueuedCompletionStatus([In] IntPtr CompletionPort, [Out] out uint lpNumberOfBytesTransferred, [Out] out uint lpCompletionKey, ref IntPtr lpOverlapped, uint dwMilliseconds);


        /// Return Type: protoent*
        ///proto: int
        [DllImport("ws2_32.dll", EntryPoint = "getprotobynumber", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr getprotobynumber(int proto);


        /// Return Type: protoent*
        ///name: char*
        [DllImport("ws2_32.dll", EntryPoint = "getprotobyname", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr getprotobyname([In] [MarshalAs(UnmanagedType.LPStr)] string name);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "GetPropW")]
        public static extern IntPtr GetPropW([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString);


        /// Return Type: HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///lpString: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "GetPropA")]
        public static extern IntPtr GetPropA([In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpDefault: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileStringW")]
        public static extern uint GetProfileStringW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpReturnedString, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpDefault: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileStringA")]
        public static extern uint GetProfileStringA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpReturnedString, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileSectionW")]
        public static extern uint GetProfileSectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpReturnedString, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileSectionA")]
        public static extern uint GetProfileSectionA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpReturnedString, uint nSize);


        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///nDefault: INT->int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileIntW")]
        public static extern uint GetProfileIntW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault);


        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///nDefault: INT->int
        [DllImport("kernel32.dll", EntryPoint = "GetProfileIntA")]
        public static extern uint GetProfileIntA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpMinimumWorkingSetSize: PSIZE_T->ULONG_PTR*
        ///lpMaximumWorkingSetSize: PSIZE_T->ULONG_PTR*
        ///Flags: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessWorkingSetSizeEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessWorkingSetSizeEx([In] IntPtr hProcess, [Out] out uint lpMinimumWorkingSetSize, [Out] out uint lpMaximumWorkingSetSize, [Out] out uint Flags);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpMinimumWorkingSetSize: PSIZE_T->ULONG_PTR*
        ///lpMaximumWorkingSetSize: PSIZE_T->ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessWorkingSetSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessWorkingSetSize([In] IntPtr hProcess, [Out] out uint lpMinimumWorkingSetSize, [Out] out uint lpMaximumWorkingSetSize);


        /// Return Type: HWINSTA->HWINSTA__*
        [DllImport("user32.dll", EntryPoint = "GetProcessWindowStation")]
        public static extern IntPtr GetProcessWindowStation();


        /// Return Type: DWORD->unsigned int
        ///ProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetProcessVersion")]
        public static extern uint GetProcessVersion(uint ProcessId);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpCreationTime: LPFILETIME->_FILETIME*
        ///lpExitTime: LPFILETIME->_FILETIME*
        ///lpKernelTime: LPFILETIME->_FILETIME*
        ///lpUserTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessTimes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessTimes([In] IntPtr hProcess, [Out] out FILETIME lpCreationTime, [Out] out FILETIME lpExitTime, [Out] out FILETIME lpKernelTime, [Out] out FILETIME lpUserTime);


        /// Return Type: BOOL->int
        ///lpdwLevel: LPDWORD->DWORD*
        ///lpdwFlags: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessShutdownParameters")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessShutdownParameters([Out] out uint lpdwLevel, [Out] out uint lpdwFlags);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///pDisablePriorityBoost: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessPriorityBoost")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessPriorityBoost([In] IntPtr hProcess, [Out] out int pDisablePriorityBoost);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpIoCounters: PIO_COUNTERS->IO_COUNTERS*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessIoCounters")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessIoCounters([In] IntPtr hProcess, [Out] out IO_COUNTERS lpIoCounters);


        /// Return Type: DWORD->unsigned int
        ///Thread: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessIdOfThread")]
        public static extern uint GetProcessIdOfThread([In] IntPtr Thread);


        /// Return Type: DWORD->unsigned int
        ///Process: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessId")]
        public static extern uint GetProcessId([In] IntPtr Process);


        /// Return Type: DWORD->unsigned int
        ///NumberOfHeaps: DWORD->unsigned int
        ///ProcessHeaps: PHANDLE->HANDLE*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessHeaps")]
        public static extern uint GetProcessHeaps(uint NumberOfHeaps, ref IntPtr ProcessHeaps);


        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessHeap")]
        public static extern IntPtr GetProcessHeap();


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///pdwHandleCount: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessHandleCount")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessHandleCount([In] IntPtr hProcess, [Out] out uint pdwHandleCount);


        /// Return Type: BOOL->int
        ///pdwDefaultLayout: DWORD*
        [DllImport("user32.dll", EntryPoint = "GetProcessDefaultLayout")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessDefaultLayout([Out] out uint pdwDefaultLayout);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpProcessAffinityMask: PDWORD_PTR->ULONG_PTR*
        ///lpSystemAffinityMask: PDWORD_PTR->ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "GetProcessAffinityMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessAffinityMask([In] IntPtr hProcess, [Out] out uint lpProcessAffinityMask, [Out] out uint lpSystemAffinityMask);


        /// Return Type: FARPROC
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpProcName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        public static extern FARPROC GetProcAddress([In] IntPtr hModule, [In] [MarshalAs(UnmanagedType.LPStr)] string lpProcName);


        /// Return Type: BOOL->int
        ///lpszSection: LPCWSTR->WCHAR*
        ///lpszKey: LPCWSTR->WCHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStructW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrivateProfileStructW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszKey, IntPtr lpStruct, uint uSizeStruct, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFile);


        /// Return Type: BOOL->int
        ///lpszSection: LPCSTR->CHAR*
        ///lpszKey: LPCSTR->CHAR*
        ///lpStruct: LPVOID->void*
        ///uSizeStruct: UINT->unsigned int
        ///szFile: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStructA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrivateProfileStructA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSection, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszKey, IntPtr lpStruct, uint uSizeStruct, [In] [MarshalAs(UnmanagedType.LPStr)] string szFile);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///lpDefault: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringW")]
        public static extern uint GetPrivateProfileStringW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpReturnedString, uint nSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///lpDefault: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA")]
        public static extern uint GetPrivateProfileStringA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDefault, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpReturnedString, uint nSize, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpReturnedString: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionW")]
        public static extern uint GetPrivateProfileSectionW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpReturnedString, uint nSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: DWORD->unsigned int
        ///lpszReturnBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionNamesW")]
        public static extern uint GetPrivateProfileSectionNamesW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszReturnBuffer, uint nSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: DWORD->unsigned int
        ///lpszReturnBuffer: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionNamesA")]
        public static extern uint GetPrivateProfileSectionNamesA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszReturnBuffer, uint nSize, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: DWORD->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpReturnedString: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileSectionA")]
        public static extern uint GetPrivateProfileSectionA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpReturnedString, uint nSize, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCWSTR->WCHAR*
        ///lpKeyName: LPCWSTR->WCHAR*
        ///nDefault: INT->int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileIntW")]
        public static extern uint GetPrivateProfileIntW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpKeyName, int nDefault, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: UINT->unsigned int
        ///lpAppName: LPCSTR->CHAR*
        ///lpKeyName: LPCSTR->CHAR*
        ///nDefault: INT->int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileIntA")]
        public static extern uint GetPrivateProfileIntA([In] [MarshalAs(UnmanagedType.LPStr)] string lpAppName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpKeyName, int nDefault, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///ObjectDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///SecurityInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///ResultantDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///DescriptorLength: DWORD->unsigned int
        ///ReturnLength: PDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetPrivateObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrivateObjectSecurity([In] IntPtr ObjectDescriptor, uint SecurityInformation, IntPtr ResultantDescriptor, uint DescriptorLength, [Out] out uint ReturnLength);


        /// Return Type: int
        ///paFormatPriorityList: UINT*
        ///cFormats: int
        [DllImport("user32.dll", EntryPoint = "GetPriorityClipboardFormat")]
        public static extern int GetPriorityClipboardFormat([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 1)] uint[] paFormatPriorityList, int cFormats);


        /// Return Type: DWORD->unsigned int
        ///hProcess: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetPriorityClass")]
        public static extern uint GetPriorityClass([In] IntPtr hProcess);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pPrintProcessorInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrintProcessorDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrintProcessorDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, uint Level, IntPtr pPrintProcessorInfo, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pPrintProcessorInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrintProcessorDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrintProcessorDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, uint Level, IntPtr pPrintProcessorInfo, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pPrinter: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrinterW([In] IntPtr hPrinter, uint Level, IntPtr pPrinter, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pEnvironment: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDriverW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrinterDriverW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, uint Level, IntPtr pDriverInfo, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///pEnvironment: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pDriverDirectory: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDriverDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrinterDriverDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pEnvironment, uint Level, IntPtr pDriverDirectory, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///pEnvironment: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pDriverDirectory: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDriverDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrinterDriverDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, uint Level, IntPtr pDriverDirectory, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pEnvironment: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pDriverInfo: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDriverA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrinterDriverA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pEnvironment, uint Level, IntPtr pDriverInfo, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pValueName: LPWSTR->WCHAR*
        ///pType: LPDWORD->DWORD*
        ///pData: LPBYTE->BYTE*
        ///nSize: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDataW")]
        public static extern uint GetPrinterDataW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pValueName, IntPtr pType, IntPtr pData, uint nSize, [Out] out uint pcbNeeded);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCWSTR->WCHAR*
        ///pValueName: LPCWSTR->WCHAR*
        ///pType: LPDWORD->DWORD*
        ///pData: LPBYTE->BYTE*
        ///nSize: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDataExW")]
        public static extern uint GetPrinterDataExW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pKeyName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pValueName, IntPtr pType, IntPtr pData, uint nSize, [Out] out uint pcbNeeded);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pKeyName: LPCSTR->CHAR*
        ///pValueName: LPCSTR->CHAR*
        ///pType: LPDWORD->DWORD*
        ///pData: LPBYTE->BYTE*
        ///nSize: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDataExA")]
        public static extern uint GetPrinterDataExA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pKeyName, [In] [MarshalAs(UnmanagedType.LPStr)] string pValueName, IntPtr pType, IntPtr pData, uint nSize, [Out] out uint pcbNeeded);


        /// Return Type: DWORD->unsigned int
        ///hPrinter: HANDLE->void*
        ///pValueName: LPSTR->CHAR*
        ///pType: LPDWORD->DWORD*
        ///pData: LPBYTE->BYTE*
        ///nSize: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterDataA")]
        public static extern uint GetPrinterDataA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pValueName, IntPtr pType, IntPtr pData, uint nSize, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///Level: DWORD->unsigned int
        ///pPrinter: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetPrinterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPrinterA([In] IntPtr hPrinter, uint Level, IntPtr pPrinter, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetPolyFillMode")]
        public static extern int GetPolyFillMode([In] IntPtr hdc);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetPixelFormat")]
        public static extern int GetPixelFormat([In] IntPtr hdc);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///x: int
        ///y: int
        [DllImport("gdi32.dll", EntryPoint = "GetPixel")]
        public static extern uint GetPixel([In] IntPtr hdc, int x, int y);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///name: sockaddr*
        ///namelen: int*
        [DllImport("ws2_32.dll", EntryPoint = "getpeername", CallingConvention = CallingConvention.StdCall)]
        public static extern int getpeername([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, ref sockaddr name, ref int namelen);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///apt: LPPOINT->tagPOINT*
        ///aj: LPBYTE->BYTE*
        ///cpt: int
        [DllImport("gdi32.dll", EntryPoint = "GetPath")]
        public static extern int GetPath([In] IntPtr hdc, IntPtr apt, IntPtr aj, int cpt);


        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetParent")]
        public static extern IntPtr GetParent([In] IntPtr hWnd);


        /// Return Type: UINT->unsigned int
        ///hpal: HPALETTE->HPALETTE__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///pPalEntries: LPPALETTEENTRY->tagPALETTEENTRY*
        [DllImport("gdi32.dll", EntryPoint = "GetPaletteEntries")]
        public static extern uint GetPaletteEntries([In] IntPtr hpal, uint iStart, uint cEntries, IntPtr pPalEntries);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        ///lpNumberOfBytesTransferred: LPDWORD->DWORD*
        ///bWait: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "GetOverlappedResult")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOverlappedResult([In] IntPtr hFile, [In] ref OVERLAPPED lpOverlapped, [Out] out uint lpNumberOfBytesTransferred, [MarshalAs(UnmanagedType.Bool)] bool bWait);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///cjCopy: UINT->unsigned int
        ///potm: LPOUTLINETEXTMETRICW->_OUTLINETEXTMETRICW*
        [DllImport("gdi32.dll", EntryPoint = "GetOutlineTextMetricsW")]
        public static extern uint GetOutlineTextMetricsW([In] IntPtr hdc, uint cjCopy, IntPtr potm);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///cjCopy: UINT->unsigned int
        ///potm: LPOUTLINETEXTMETRICA->_OUTLINETEXTMETRICA*
        [DllImport("gdi32.dll", EntryPoint = "GetOutlineTextMetricsA")]
        public static extern uint GetOutlineTextMetricsA([In] IntPtr hdc, uint cjCopy, IntPtr potm);


        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEW->tagOFNW*
        [DllImport("comdlg32.dll", EntryPoint = "GetOpenFileNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOpenFileNameW(ref tagOFNW param0);


        /// Return Type: BOOL->int
        ///param0: LPOPENFILENAMEA->tagOFNA*
        [DllImport("comdlg32.dll", EntryPoint = "GetOpenFileNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOpenFileNameA(ref tagOFNA param0);


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetOpenClipboardWindow")]
        public static extern IntPtr GetOpenClipboardWindow();


        /// Return Type: LONG->int
        ///param0: LPOPENCARDNAMEW->Anonymous_ae8db201_c019_44f0_b6e8_4befd9a65b9c*
        [DllImport("<Unknown>", EntryPoint = "GetOpenCardNameW")]
        public static extern int GetOpenCardNameW(ref OPENCARDNAMEW param0);


        /// Return Type: LONG->int
        ///param0: LPOPENCARDNAMEA->Anonymous_0dd98b8d_9e4f_45eb_b952_469fcbe4f696*
        [DllImport("<Unknown>", EntryPoint = "GetOpenCardNameA")]
        public static extern int GetOpenCardNameA(ref OPENCARDNAMEA param0);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///OldestRecord: PDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetOldestEventLogRecord")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetOldestEventLogRecord([In] IntPtr hEventLog, [Out] out uint OldestRecord);


        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetOEMCP")]
        public static extern uint GetOEMCP();


        /// Return Type: int
        ///h: HANDLE->void*
        ///c: int
        ///pv: LPVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "GetObjectW")]
        public static extern int GetObjectW([In] IntPtr h, int c, IntPtr pv);


        /// Return Type: DWORD->unsigned int
        ///h: HGDIOBJ->void*
        [DllImport("gdi32.dll", EntryPoint = "GetObjectType")]
        public static extern uint GetObjectType([In] IntPtr h);


        /// Return Type: int
        ///h: HANDLE->void*
        ///c: int
        ///pv: LPVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "GetObjectA")]
        public static extern int GetObjectA([In] IntPtr h, int c, IntPtr pv);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///NumberOfRecords: PDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetNumberOfEventLogRecords")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfEventLogRecords([In] IntPtr hEventLog, [Out] out uint NumberOfRecords);


        /// Return Type: BOOL->int
        ///lpNumberOfMouseButtons: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetNumberOfConsoleMouseButtons")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfConsoleMouseButtons(ref uint lpNumberOfMouseButtons);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpNumberOfEvents: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetNumberOfConsoleInputEvents")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, ref uint lpNumberOfEvents);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCWSTR->WCHAR*
        ///lpFormat: NUMBERFMTW*
        ///lpNumberStr: LPWSTR->WCHAR*
        ///cchNumber: int
        [DllImport("kernel32.dll", EntryPoint = "GetNumberFormatW")]
        public static extern int GetNumberFormatW(uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValue, [In] IntPtr lpFormat, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpNumberStr, int cchNumber);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCSTR->CHAR*
        ///lpFormat: NUMBERFMTA*
        ///lpNumberStr: LPSTR->CHAR*
        ///cchNumber: int
        [DllImport("kernel32.dll", EntryPoint = "GetNumberFormatA")]
        public static extern int GetNumberFormatA(uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValue, [In] IntPtr lpFormat, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpNumberStr, int cchNumber);


        /// Return Type: BOOL->int
        ///Processor: UCHAR->unsigned char
        ///NodeNumber: PUCHAR->UCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaProcessorNode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaProcessorNode(byte Processor, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder NodeNumber);


        /// Return Type: BOOL->int
        ///Node: UCHAR->unsigned char
        ///ProcessorMask: PULONGLONG->ULONGLONG*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaNodeProcessorMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaNodeProcessorMask(byte Node, [Out] out ulong ProcessorMask);


        /// Return Type: BOOL->int
        ///HighestNodeNumber: PULONG->ULONG*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaHighestNodeNumber")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaHighestNodeNumber([Out] out uint HighestNodeNumber);


        /// Return Type: BOOL->int
        ///Node: UCHAR->unsigned char
        ///AvailableBytes: PULONGLONG->ULONGLONG*
        [DllImport("kernel32.dll", EntryPoint = "GetNumaAvailableMemoryNode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumaAvailableMemoryNode(byte Node, [Out] out ulong AvailableBytes);


        /// Return Type: BOOL->int
        ///Function: NLS_FUNCTION->DWORD->unsigned int
        ///Locale: LCID->DWORD->unsigned int
        ///lpVersionInformation: LPNLSVERSIONINFO->_nlsversioninfo*
        [DllImport("kernel32.dll", EntryPoint = "GetNLSVersion")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNLSVersion(uint Function, uint Locale, ref NLSVERSIONINFO lpVersionInformation);


        /// Return Type: HWND->HWND__*
        ///hDlg: HWND->HWND__*
        ///hCtl: HWND->HWND__*
        ///bPrevious: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetNextDlgTabItem")]
        public static extern IntPtr GetNextDlgTabItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);


        /// Return Type: HWND->HWND__*
        ///hDlg: HWND->HWND__*
        ///hCtl: HWND->HWND__*
        ///bPrevious: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetNextDlgGroupItem")]
        public static extern IntPtr GetNextDlgGroupItem([In] IntPtr hDlg, [In] IntPtr hCtl, [MarshalAs(UnmanagedType.Bool)] bool bPrevious);


        /// Return Type: UINT->unsigned int
        ///h: HPALETTE->HPALETTE__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetNearestPaletteIndex")]
        public static extern uint GetNearestPaletteIndex([In] IntPtr h, uint color);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetNearestColor")]
        public static extern uint GetNearestColor([In] IntPtr hdc, uint color);


        /// Return Type: void
        ///lpSystemInfo: LPSYSTEM_INFO->_SYSTEM_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetNativeSystemInfo")]
        public static extern void GetNativeSystemInfo([Out] out SYSTEM_INFO lpSystemInfo);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpFlags: LPDWORD->DWORD*
        ///lpOutBufferSize: LPDWORD->DWORD*
        ///lpInBufferSize: LPDWORD->DWORD*
        ///lpMaxInstances: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeInfo([In] IntPtr hNamedPipe, IntPtr lpFlags, IntPtr lpOutBufferSize, IntPtr lpInBufferSize, IntPtr lpMaxInstances);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpState: LPDWORD->DWORD*
        ///lpCurInstances: LPDWORD->DWORD*
        ///lpMaxCollectionCount: LPDWORD->DWORD*
        ///lpCollectDataTimeout: LPDWORD->DWORD*
        ///lpUserName: LPWSTR->WCHAR*
        ///nMaxUserNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeHandleStateW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeHandleStateW([In] IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpUserName, uint nMaxUserNameSize);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpState: LPDWORD->DWORD*
        ///lpCurInstances: LPDWORD->DWORD*
        ///lpMaxCollectionCount: LPDWORD->DWORD*
        ///lpCollectDataTimeout: LPDWORD->DWORD*
        ///lpUserName: LPSTR->CHAR*
        ///nMaxUserNameSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetNamedPipeHandleStateA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNamedPipeHandleStateA([In] IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpUserName, uint nMaxUserNameSize);


        /// Return Type: int
        ///cbSize: UINT->unsigned int
        ///lppt: LPMOUSEMOVEPOINT->tagMOUSEMOVEPOINT*
        ///lpptBuf: LPMOUSEMOVEPOINT->tagMOUSEMOVEPOINT*
        ///nBufPoints: int
        ///resolution: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMouseMovePointsEx")]
        public static extern int GetMouseMovePointsEx(uint cbSize, [In] ref tagMOUSEMOVEPOINT lppt, IntPtr lpptBuf, int nBufPoints, uint resolution);


        /// Return Type: BOOL->int
        ///hMonitor: HMONITOR->HMONITOR__*
        ///lpmi: LPMONITORINFO->tagMONITORINFO*
        [DllImport("user32.dll", EntryPoint = "GetMonitorInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfoW([In] IntPtr hMonitor, ref tagMONITORINFO lpmi);


        /// Return Type: BOOL->int
        ///hMonitor: HMONITOR->HMONITOR__*
        ///lpmi: LPMONITORINFO->tagMONITORINFO*
        [DllImport("user32.dll", EntryPoint = "GetMonitorInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfoA([In] IntPtr hMonitor, ref tagMONITORINFO lpmi);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpModuleName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleW")]
        public static extern IntPtr GetModuleHandleW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpModuleName: LPCWSTR->WCHAR*
        ///phModule: HMODULE*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetModuleHandleExW(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, ref IntPtr phModule);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///lpModuleName: LPCSTR->CHAR*
        ///phModule: HMODULE*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetModuleHandleExA(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpModuleName, ref IntPtr phModule);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpModuleName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetModuleHandleA")]
        public static extern IntPtr GetModuleHandleA([In] [MarshalAs(UnmanagedType.LPStr)] string lpModuleName);


        /// Return Type: DWORD->unsigned int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpFilename: LPWCH->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetModuleFileNameW")]
        public static extern uint GetModuleFileNameW([In] IntPtr hModule, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpFilename, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///lpFilename: LPCH->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetModuleFileNameA")]
        public static extern uint GetModuleFileNameA([In] IntPtr hModule, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpFilename, uint nSize);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///plimit: PFLOAT->FLOAT*
        [DllImport("gdi32.dll", EntryPoint = "GetMiterLimit")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMiterLimit([In] IntPtr hdc, [Out] out float plimit);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImport("gdi32.dll", EntryPoint = "GetMetaRgn")]
        public static extern int GetMetaRgn([In] IntPtr hdc, [In] IntPtr hrgn);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetMetaFileW")]
        public static extern IntPtr GetMetaFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: UINT->unsigned int
        ///hMF: HMETAFILE->HMETAFILE__*
        ///cbBuffer: UINT->unsigned int
        ///lpData: LPVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "GetMetaFileBitsEx")]
        public static extern uint GetMetaFileBitsEx([In] IntPtr hMF, uint cbBuffer, IntPtr lpData);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///lpName: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetMetaFileA")]
        public static extern IntPtr GetMetaFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessageW([Out] out tagMSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);


        /// Return Type: LONG->int
        [DllImport("user32.dll", EntryPoint = "GetMessageTime")]
        public static extern int GetMessageTime();


        /// Return Type: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMessagePos")]
        public static extern uint GetMessagePos();


        /// Return Type: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr GetMessageExtraInfo();


        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMessageA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessageA([Out] out tagMSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);


        /// Return Type: int
        ///hMenu: HMENU->HMENU__*
        ///uIDItem: UINT->unsigned int
        ///lpString: LPWSTR->WCHAR*
        ///cchMax: int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuStringW")]
        public static extern int GetMenuStringW([In] IntPtr hMenu, uint uIDItem, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString, int cchMax, uint flags);


        /// Return Type: int
        ///hMenu: HMENU->HMENU__*
        ///uIDItem: UINT->unsigned int
        ///lpString: LPSTR->CHAR*
        ///cchMax: int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuStringA")]
        public static extern int GetMenuStringA([In] IntPtr hMenu, uint uIDItem, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString, int cchMax, uint flags);


        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///uId: UINT->unsigned int
        ///uFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuState")]
        public static extern uint GetMenuState([In] IntPtr hMenu, uint uId, uint uFlags);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///uItem: UINT->unsigned int
        ///lprcItem: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemRect([In] IntPtr hWnd, [In] IntPtr hMenu, uint uItem, [Out] out tagRECT lprcItem);


        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmii: LPMENUITEMINFOW->tagMENUITEMINFOW*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemInfoW([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref tagMENUITEMINFOW lpmii);


        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///item: UINT->unsigned int
        ///fByPosition: BOOL->int
        ///lpmii: LPMENUITEMINFOA->tagMENUITEMINFOA*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemInfoA([In] IntPtr hmenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref tagMENUITEMINFOA lpmii);


        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///nPos: int
        [DllImport("user32.dll", EntryPoint = "GetMenuItemID")]
        public static extern uint GetMenuItemID([In] IntPtr hMenu, int nPos);


        /// Return Type: int
        ///hMenu: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
        public static extern int GetMenuItemCount([In] IntPtr hMenu);


        /// Return Type: BOOL->int
        ///param0: HMENU->HMENU__*
        ///param1: LPMENUINFO->tagMENUINFO*
        [DllImport("user32.dll", EntryPoint = "GetMenuInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuInfo([In] IntPtr param0, ref tagMENUINFO param1);


        /// Return Type: UINT->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///fByPos: UINT->unsigned int
        ///gmdiFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetMenuDefaultItem")]
        public static extern uint GetMenuDefaultItem([In] IntPtr hMenu, uint fByPos, uint gmdiFlags);


        /// Return Type: DWORD->unsigned int
        ///param0: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "GetMenuContextHelpId")]
        public static extern uint GetMenuContextHelpId([In] IntPtr param0);


        /// Return Type: LONG->int
        [DllImport("user32.dll", EntryPoint = "GetMenuCheckMarkDimensions")]
        public static extern int GetMenuCheckMarkDimensions();


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///idObject: LONG->int
        ///idItem: LONG->int
        ///pmbi: PMENUBARINFO->tagMENUBARINFO*
        [DllImport("user32.dll", EntryPoint = "GetMenuBarInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuBarInfo([In] IntPtr hwnd, int idObject, int idItem, ref tagMENUBARINFO pmbi);


        /// Return Type: HMENU->HMENU__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetMenu")]
        public static extern IntPtr GetMenu([In] IntPtr hWnd);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetMapMode")]
        public static extern int GetMapMode([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hMailslot: HANDLE->void*
        ///lpMaxMessageSize: LPDWORD->DWORD*
        ///lpNextSize: LPDWORD->DWORD*
        ///lpMessageCount: LPDWORD->DWORD*
        ///lpReadTimeout: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetMailslotInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMailslotInfo([In] IntPtr hMailslot, IntPtr lpMaxMessageSize, IntPtr lpNextSize, IntPtr lpMessageCount, IntPtr lpReadTimeout);


        /// Return Type: DWORD->unsigned int
        ///lpszShortPath: LPCWSTR->WCHAR*
        ///lpszLongPath: LPWSTR->WCHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLongPathNameW")]
        public static extern uint GetLongPathNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszShortPath, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszLongPath, uint cchBuffer);


        /// Return Type: DWORD->unsigned int
        ///lpszShortPath: LPCSTR->CHAR*
        ///lpszLongPath: LPSTR->CHAR*
        ///cchBuffer: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLongPathNameA")]
        public static extern uint GetLongPathNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszShortPath, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszLongPath, uint cchBuffer);


        /// Return Type: BOOL->int
        ///Buffer: PSYSTEM_LOGICAL_PROCESSOR_INFORMATION->_SYSTEM_LOGICAL_PROCESSOR_INFORMATION*
        ///ReturnedLength: PDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalProcessorInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLogicalProcessorInformation(IntPtr Buffer, ref uint ReturnedLength);


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDriveStringsW")]
        public static extern uint GetLogicalDriveStringsW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDriveStringsA")]
        public static extern uint GetLogicalDriveStringsA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLogicalDrives")]
        public static extern uint GetLogicalDrives();


        /// Return Type: BOOL->int
        ///hColorSpace: HCOLORSPACE->HCOLORSPACE__*
        ///lpBuffer: LPLOGCOLORSPACEW->tagLOGCOLORSPACEW*
        ///nSize: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetLogColorSpaceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLogColorSpaceW([In] IntPtr hColorSpace, IntPtr lpBuffer, uint nSize);


        /// Return Type: BOOL->int
        ///hColorSpace: HCOLORSPACE->HCOLORSPACE__*
        ///lpBuffer: LPLOGCOLORSPACEA->tagLOGCOLORSPACEA*
        ///nSize: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetLogColorSpaceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLogColorSpaceA([In] IntPtr hColorSpace, IntPtr lpBuffer, uint nSize);


        /// Return Type: void
        ///lpSystemTime: LPSYSTEMTIME->_SYSTEMTIME*
        [DllImport("kernel32.dll", EntryPoint = "GetLocalTime")]
        public static extern void GetLocalTime([Out] out SYSTEMTIME lpSystemTime);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPWSTR->WCHAR*
        ///cchData: int
        [DllImport("kernel32.dll", EntryPoint = "GetLocaleInfoW")]
        public static extern int GetLocaleInfoW(uint Locale, uint LCType, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpLCData, int cchData);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///LCType: LCTYPE->DWORD->unsigned int
        ///lpLCData: LPSTR->CHAR*
        ///cchData: int
        [DllImport("kernel32.dll", EntryPoint = "GetLocaleInfoA")]
        public static extern int GetLocaleInfoA(uint Locale, uint LCType, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpLCData, int cchData);


        /// Return Type: DWORD->unsigned int
        ///hwnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetListBoxInfo")]
        public static extern uint GetListBoxInfo([In] IntPtr hwnd);


        /// Return Type: DWORD->unsigned int
        ///pSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "GetLengthSid")]
        public static extern uint GetLengthSid([In] IntPtr pSid);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetLayout")]
        public static extern uint GetLayout([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///pcrKey: COLORREF*
        ///pbAlpha: BYTE*
        ///pdwFlags: DWORD*
        [DllImport("user32.dll", EntryPoint = "GetLayeredWindowAttributes")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLayeredWindowAttributes([In] IntPtr hwnd, IntPtr pcrKey, IntPtr pbAlpha, IntPtr pdwFlags);


        /// Return Type: BOOL->int
        ///plii: PLASTINPUTINFO->tagLASTINPUTINFO*
        [DllImport("user32.dll", EntryPoint = "GetLastInputInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLastInputInfo([Out] out tagLASTINPUTINFO plii);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLastError")]
        public static extern uint GetLastError();


        /// Return Type: HWND->HWND__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetLastActivePopup")]
        public static extern IntPtr GetLastActivePopup([In] IntPtr hWnd);


        /// Return Type: COORD->_COORD
        ///hConsoleOutput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetLargestConsoleWindowSize")]
        public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetLargePageMinimum")]
        public static extern uint GetLargePageMinimum();


        /// Return Type: SHORT->short
        ///nVirtKey: int
        [DllImport("user32.dll", EntryPoint = "GetKeyState")]
        public static extern short GetKeyState(int nVirtKey);


        /// Return Type: int
        ///lParam: LONG->int
        ///lpString: LPWSTR->WCHAR*
        ///cchSize: int
        [DllImport("user32.dll", EntryPoint = "GetKeyNameTextW")]
        public static extern int GetKeyNameTextW(int lParam, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString, int cchSize);


        /// Return Type: int
        ///lParam: LONG->int
        ///lpString: LPSTR->CHAR*
        ///cchSize: int
        [DllImport("user32.dll", EntryPoint = "GetKeyNameTextA")]
        public static extern int GetKeyNameTextA(int lParam, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString, int cchSize);


        /// Return Type: int
        ///nTypeFlag: int
        [DllImport("user32.dll", EntryPoint = "GetKeyboardType")]
        public static extern int GetKeyboardType(int nTypeFlag);


        /// Return Type: BOOL->int
        ///lpKeyState: PBYTE->BYTE*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardState(IntPtr lpKeyState);


        /// Return Type: BOOL->int
        ///pwszKLID: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardLayoutNameW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pwszKLID);


        /// Return Type: BOOL->int
        ///pwszKLID: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardLayoutNameA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pwszKLID);


        /// Return Type: int
        ///nBuff: int
        ///lpList: HKL*
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayoutList")]
        public static extern int GetKeyboardLayoutList(int nBuff, ref IntPtr lpList);


        /// Return Type: HKL->HKL__*
        ///idThread: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetKeyboardLayout")]
        public static extern IntPtr GetKeyboardLayout(uint idThread);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///nPairs: DWORD->unsigned int
        ///lpKernPair: LPKERNINGPAIR->tagKERNINGPAIR*
        [DllImport("gdi32.dll", EntryPoint = "GetKerningPairsW")]
        public static extern uint GetKerningPairsW([In] IntPtr hdc, uint nPairs, IntPtr lpKernPair);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///nPairs: DWORD->unsigned int
        ///lpKernPair: LPKERNINGPAIR->tagKERNINGPAIR*
        [DllImport("gdi32.dll", EntryPoint = "GetKerningPairsA")]
        public static extern uint GetKerningPairsA([In] IntPtr hdc, uint nPairs, IntPtr lpKernPair);


        /// Return Type: BOOL->int
        ///Handle: HANDLE->void*
        ///RequestedInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetKernelObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKernelObjectSecurity([In] IntPtr Handle, uint RequestedInformation, IntPtr pSecurityDescriptor, uint nLength, [Out] out uint lpnLengthNeeded);


        /// Return Type: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetKBCodePage")]
        public static extern uint GetKBCodePage();


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///JobId: DWORD->unsigned int
        ///Level: DWORD->unsigned int
        ///pJob: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetJobW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetJobW([In] IntPtr hPrinter, uint JobId, uint Level, IntPtr pJob, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///JobId: DWORD->unsigned int
        ///Level: DWORD->unsigned int
        ///pJob: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetJobA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetJobA([In] IntPtr hPrinter, uint JobId, uint Level, IntPtr pJob, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetInputState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetInputState();


        /// Return Type: BOOL->int
        ///hIcon: HICON->HICON__*
        ///piconinfo: PICONINFO->ICONINFO*
        [DllImport("user32.dll", EntryPoint = "GetIconInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo([In] IntPtr hIcon, [Out] out ICONINFO piconinfo);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pBufSize: LPDWORD->DWORD*
        ///pszFilename: LPWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetICMProfileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetICMProfileW([In] IntPtr hdc, ref uint pBufSize, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszFilename);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///pBufSize: LPDWORD->DWORD*
        ///pszFilename: LPSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetICMProfileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetICMProfileA([In] IntPtr hdc, ref uint pBufSize, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszFilename);


        /// Return Type: int
        ///name: char*
        ///namelen: int
        [DllImport("ws2_32.dll", EntryPoint = "gethostname", CallingConvention = CallingConvention.StdCall)]
        public static extern int gethostname(IntPtr name, int namelen);


        /// Return Type: hostent*
        ///name: char*
        [DllImport("ws2_32.dll", EntryPoint = "gethostbyname", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr gethostbyname([In] [MarshalAs(UnmanagedType.LPStr)] string name);


        /// Return Type: hostent*
        ///addr: char*
        ///len: int
        ///type: int
        [DllImport("ws2_32.dll", EntryPoint = "gethostbyaddr", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr gethostbyaddr([In] [MarshalAs(UnmanagedType.LPStr)] string addr, int len, int type);


        /// Return Type: HRESULT->LONG->int
        ///pstm: LPSTREAM->IStream*
        ///phglobal: HGLOBAL*
        [DllImport("ole32.dll", EntryPoint = "GetHGlobalFromStream", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetHGlobalFromStream(ref IStream pstm, ref IntPtr phglobal);


        /// Return Type: HRESULT->LONG->int
        ///plkbyt: LPLOCKBYTES->ILockBytes*
        ///phglobal: HGLOBAL*
        [DllImport("ole32.dll", EntryPoint = "GetHGlobalFromILockBytes", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetHGlobalFromILockBytes(ref ILockBytes plkbyt, ref IntPtr phglobal);


        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        ///lpdwFlags: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetHandleInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetHandleInformation([In] IntPtr hObject, [Out] out uint lpdwFlags);


        /// Return Type: BOOL->int
        ///idThread: DWORD->unsigned int
        ///pgui: PGUITHREADINFO->tagGUITHREADINFO*
        [DllImport("user32.dll", EntryPoint = "GetGUIThreadInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetGUIThreadInfo(uint idThread, ref tagGUITHREADINFO pgui);


        /// Return Type: DWORD->unsigned int
        ///hProcess: HANDLE->void*
        ///uiFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetGuiResources")]
        public static extern uint GetGuiResources([In] IntPtr hProcess, uint uiFlags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetGraphicsMode")]
        public static extern int GetGraphicsMode([In] IntPtr hdc);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///uChar: UINT->unsigned int
        ///fuFormat: UINT->unsigned int
        ///lpgm: LPGLYPHMETRICS->_GLYPHMETRICS*
        ///cjBuffer: DWORD->unsigned int
        ///pvBuffer: LPVOID->void*
        ///lpmat2: MAT2*
        [DllImport("gdi32.dll", EntryPoint = "GetGlyphOutlineW")]
        public static extern uint GetGlyphOutlineW([In] IntPtr hdc, uint uChar, uint fuFormat, [Out] out GLYPHMETRICS lpgm, uint cjBuffer, IntPtr pvBuffer, [In] ref MAT2 lpmat2);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///uChar: UINT->unsigned int
        ///fuFormat: UINT->unsigned int
        ///lpgm: LPGLYPHMETRICS->_GLYPHMETRICS*
        ///cjBuffer: DWORD->unsigned int
        ///pvBuffer: LPVOID->void*
        ///lpmat2: MAT2*
        [DllImport("gdi32.dll", EntryPoint = "GetGlyphOutlineA")]
        public static extern uint GetGlyphOutlineA([In] IntPtr hdc, uint uChar, uint fuFormat, [Out] out GLYPHMETRICS lpgm, uint cjBuffer, IntPtr pvBuffer, [In] ref MAT2 lpmat2);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpstr: LPCWSTR->WCHAR*
        ///c: int
        ///pgi: LPWORD->WORD*
        ///fl: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetGlyphIndicesW")]
        public static extern uint GetGlyphIndicesW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpstr, int c, IntPtr pgi, uint fl);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpstr: LPCSTR->CHAR*
        ///c: int
        ///pgi: LPWORD->WORD*
        ///fl: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetGlyphIndicesA")]
        public static extern uint GetGlyphIndicesA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpstr, int c, IntPtr pgi, uint fl);


        /// Return Type: int
        ///Location: GEOID->LONG->int
        ///GeoType: GEOTYPE->DWORD->unsigned int
        ///lpGeoData: LPWSTR->WCHAR*
        ///cchData: int
        ///LangId: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetGeoInfoW")]
        public static extern int GetGeoInfoW(int Location, uint GeoType, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpGeoData, int cchData, ushort LangId);


        /// Return Type: int
        ///Location: GEOID->LONG->int
        ///GeoType: GEOTYPE->DWORD->unsigned int
        ///lpGeoData: LPSTR->CHAR*
        ///cchData: int
        ///LangId: LANGID->WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "GetGeoInfoA")]
        public static extern int GetGeoInfoA(int Location, uint GeoType, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpGeoData, int cchData, ushort LangId);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        ///lpFilePart: LPWSTR*
        [DllImport("kernel32.dll", EntryPoint = "GetFullPathNameW")]
        public static extern uint GetFullPathNameW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, ref IntPtr lpFilePart);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        ///lpFilePart: LPSTR*
        [DllImport("kernel32.dll", EntryPoint = "GetFullPathNameA")]
        public static extern uint GetFullPathNameA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, ref IntPtr lpFilePart);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pFormName: LPWSTR->WCHAR*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetFormW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFormW([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPWStr)] string pFormName, uint Level, IntPtr pForm, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        ///pFormName: LPSTR->CHAR*
        ///Level: DWORD->unsigned int
        ///pForm: LPBYTE->BYTE*
        ///cbBuf: DWORD->unsigned int
        ///pcbNeeded: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetFormA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFormA([In] IntPtr hPrinter, [In] [MarshalAs(UnmanagedType.LPStr)] string pFormName, uint Level, IntPtr pForm, uint cbBuf, [Out] out uint pcbNeeded);


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
        public static extern IntPtr GetForegroundWindow();


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpgs: LPGLYPHSET->tagGLYPHSET*
        [DllImport("gdi32.dll", EntryPoint = "GetFontUnicodeRanges")]
        public static extern uint GetFontUnicodeRanges([In] IntPtr hdc, IntPtr lpgs);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetFontLanguageInfo")]
        public static extern uint GetFontLanguageInfo([In] IntPtr hdc);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///dwTable: DWORD->unsigned int
        ///dwOffset: DWORD->unsigned int
        ///pvBuffer: PVOID->void*
        ///cjBuffer: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetFontData")]
        public static extern uint GetFontData([In] IntPtr hdc, uint dwTable, uint dwOffset, IntPtr pvBuffer, uint cjBuffer);


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetFocus")]
        public static extern IntPtr GetFocus();


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///lpGuid: LPCWSTR->WCHAR*
        ///pBuffer: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetFirmwareEnvironmentVariableW")]
        public static extern uint GetFirmwareEnvironmentVariableW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpGuid, IntPtr pBuffer, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        ///lpGuid: LPCSTR->CHAR*
        ///pBuffer: PVOID->void*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetFirmwareEnvironmentVariableA")]
        public static extern uint GetFirmwareEnvironmentVariableA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpGuid, IntPtr pBuffer, uint nSize);


        /// Return Type: BOOL->int
        ///lptstrFilename: LPCWSTR->WCHAR*
        ///dwHandle: DWORD->unsigned int
        ///dwLen: DWORD->unsigned int
        ///lpData: LPVOID->void*
        [DllImport("<Unknown>", EntryPoint = "GetFileVersionInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileVersionInfoW([In] [MarshalAs(UnmanagedType.LPWStr)] string lptstrFilename, uint dwHandle, uint dwLen, IntPtr lpData);


        /// Return Type: DWORD->unsigned int
        ///lptstrFilename: LPCWSTR->WCHAR*
        ///lpdwHandle: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetFileVersionInfoSizeW")]
        public static extern uint GetFileVersionInfoSizeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lptstrFilename, IntPtr lpdwHandle);


        /// Return Type: DWORD->unsigned int
        ///lptstrFilename: LPCSTR->CHAR*
        ///lpdwHandle: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetFileVersionInfoSizeA")]
        public static extern uint GetFileVersionInfoSizeA([In] [MarshalAs(UnmanagedType.LPStr)] string lptstrFilename, IntPtr lpdwHandle);


        /// Return Type: BOOL->int
        ///lptstrFilename: LPCSTR->CHAR*
        ///dwHandle: DWORD->unsigned int
        ///dwLen: DWORD->unsigned int
        ///lpData: LPVOID->void*
        [DllImport("<Unknown>", EntryPoint = "GetFileVersionInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileVersionInfoA([In] [MarshalAs(UnmanagedType.LPStr)] string lptstrFilename, uint dwHandle, uint dwLen, IntPtr lpData);


        /// Return Type: DWORD->unsigned int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetFileType")]
        public static extern uint GetFileType([In] IntPtr hFile);


        /// Return Type: short
        ///param0: LPCWSTR->WCHAR*
        ///param1: LPWSTR->WCHAR*
        ///param2: WORD->unsigned short
        [DllImport("comdlg32.dll", EntryPoint = "GetFileTitleW")]
        public static extern short GetFileTitleW([In] [MarshalAs(UnmanagedType.LPWStr)] string param0, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param1, ushort param2);


        /// Return Type: short
        ///param0: LPCSTR->CHAR*
        ///param1: LPSTR->CHAR*
        ///param2: WORD->unsigned short
        [DllImport("comdlg32.dll", EntryPoint = "GetFileTitleA")]
        public static extern short GetFileTitleA([In] [MarshalAs(UnmanagedType.LPStr)] string param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, ushort param2);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCreationTime: LPFILETIME->_FILETIME*
        ///lpLastAccessTime: LPFILETIME->_FILETIME*
        ///lpLastWriteTime: LPFILETIME->_FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "GetFileTime")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileTime([In] IntPtr hFile, IntPtr lpCreationTime, IntPtr lpLastAccessTime, IntPtr lpLastWriteTime);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpFileSize: PLARGE_INTEGER->LARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "GetFileSizeEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileSizeEx([In] IntPtr hFile, [Out] out LARGE_INTEGER lpFileSize);


        /// Return Type: DWORD->unsigned int
        ///hFile: HANDLE->void*
        ///lpFileSizeHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetFileSize")]
        public static extern uint GetFileSize([In] IntPtr hFile, IntPtr lpFileSizeHigh);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///RequestedInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetFileSecurityW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileSecurityW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint RequestedInformation, IntPtr pSecurityDescriptor, uint nLength, [Out] out uint lpnLengthNeeded);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///RequestedInformation: SECURITY_INFORMATION->DWORD->unsigned int
        ///pSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///nLength: DWORD->unsigned int
        ///lpnLengthNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetFileSecurityA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileSecurityA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint RequestedInformation, IntPtr pSecurityDescriptor, uint nLength, [Out] out uint lpnLengthNeeded);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpFileInformation: LPBY_HANDLE_FILE_INFORMATION->_BY_HANDLE_FILE_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "GetFileInformationByHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileInformationByHandle([In] IntPtr hFile, [Out] out BY_HANDLE_FILE_INFORMATION lpFileInformation);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesW")]
        public static extern uint GetFileAttributesW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///fInfoLevelId: GET_FILEEX_INFO_LEVELS->_GET_FILEEX_INFO_LEVELS
        ///lpFileInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileAttributesExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///fInfoLevelId: GET_FILEEX_INFO_LEVELS->_GET_FILEEX_INFO_LEVELS
        ///lpFileInformation: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetFileAttributesExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetFileAttributesA")]
        public static extern uint GetFileAttributesA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: INT->int
        ///param0: LPWSTR->WCHAR*
        ///param1: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetExpandedNameW")]
        public static extern int GetExpandedNameW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param1);


        /// Return Type: INT->int
        ///param0: LPSTR->CHAR*
        ///param1: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetExpandedNameA")]
        public static extern int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1);


        /// Return Type: BOOL->int
        ///hThread: HANDLE->void*
        ///lpExitCode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetExitCodeThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetExitCodeThread([In] IntPtr hThread, [Out] out uint lpExitCode);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///lpExitCode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetExitCodeProcess")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetExitCodeProcess([In] IntPtr hProcess, [Out] out uint lpExitCode);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///dwInfoLevel: DWORD->unsigned int
        ///lpBuffer: LPVOID->void*
        ///cbBufSize: DWORD->unsigned int
        ///pcbBytesNeeded: LPDWORD->DWORD*
        [DllImport("advapi32.dll", EntryPoint = "GetEventLogInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetEventLogInformation([In] IntPtr hEventLog, uint dwInfoLevel, IntPtr lpBuffer, uint cbBufSize, [Out] out uint pcbBytesNeeded);


        /// Return Type: HRESULT->LONG->int
        ///dwReserved: ULONG->unsigned int
        ///pperrinfo: IErrorInfo**
        [DllImport("oleaut32.dll", EntryPoint = "GetErrorInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetErrorInfo(uint dwReserved, ref IntPtr pperrinfo);


        /// Return Type: errno_t->int
        ///_ReturnSize: size_t*
        ///_DstBuf: char*
        ///_DstSize: rsize_t->size_t->unsigned int
        ///_VarName: char*
        [DllImport("msvcr80.dll", EntryPoint = "getenv_s", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getenv_s([Out] out uint _ReturnSize, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder _DstBuf, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _DstSize, [In] [MarshalAs(UnmanagedType.LPStr)] string _VarName);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentVariableW")]
        public static extern uint GetEnvironmentVariableW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentVariableA")]
        public static extern uint GetEnvironmentVariableA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, uint nSize);


        /// Return Type: LPWCH->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentStringsW")]
        public static extern IntPtr GetEnvironmentStringsW();


        /// Return Type: LPCH->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetEnvironmentStrings")]
        public static extern IntPtr GetEnvironmentStrings();


        /// Return Type: char*
        ///_VarName: char*
        [DllImport("msvcr80.dll", EntryPoint = "getenv", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr getenv([In] [MarshalAs(UnmanagedType.LPStr)] string _VarName);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileW")]
        public static extern IntPtr GetEnhMetaFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cbBuffer: UINT->unsigned int
        ///ppfd: PIXELFORMATDESCRIPTOR*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFilePixelFormat")]
        public static extern uint GetEnhMetaFilePixelFormat([In] IntPtr hemf, uint cbBuffer, IntPtr ppfd);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///nNumEntries: UINT->unsigned int
        ///lpPaletteEntries: LPPALETTEENTRY->tagPALETTEENTRY*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFilePaletteEntries")]
        public static extern uint GetEnhMetaFilePaletteEntries([In] IntPtr hemf, uint nNumEntries, IntPtr lpPaletteEntries);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///lpEnhMetaHeader: LPENHMETAHEADER->tagENHMETAHEADER*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileHeader")]
        public static extern uint GetEnhMetaFileHeader([In] IntPtr hemf, uint nSize, IntPtr lpEnhMetaHeader);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cchBuffer: UINT->unsigned int
        ///lpDescription: LPWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileDescriptionW")]
        public static extern uint GetEnhMetaFileDescriptionW([In] IntPtr hemf, uint cchBuffer, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpDescription);


        /// Return Type: UINT->unsigned int
        ///hemf: HENHMETAFILE->HENHMETAFILE__*
        ///cchBuffer: UINT->unsigned int
        ///lpDescription: LPSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileDescriptionA")]
        public static extern uint GetEnhMetaFileDescriptionA([In] IntPtr hemf, uint cchBuffer, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpDescription);


        /// Return Type: UINT->unsigned int
        ///hEMF: HENHMETAFILE->HENHMETAFILE__*
        ///nSize: UINT->unsigned int
        ///lpData: LPBYTE->BYTE*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileBits")]
        public static extern uint GetEnhMetaFileBits([In] IntPtr hEMF, uint nSize, IntPtr lpData);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///lpName: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "GetEnhMetaFileA")]
        public static extern IntPtr GetEnhMetaFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: BOOL->int
        ///pData: BYTE**
        ///dwDecSize: DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetEncSChannel", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetEncSChannel(ref IntPtr pData, ref uint dwDecSize);


        /// Return Type: UINT->unsigned int
        ///lpRootPathName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDriveTypeW")]
        public static extern uint GetDriveTypeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName);


        /// Return Type: UINT->unsigned int
        ///lpRootPathName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDriveTypeA")]
        public static extern uint GetDriveTypeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName);


        /// Return Type: HMODULE->HINSTANCE->HINSTANCE__*
        ///hDriver: HDRVR->HDRVR__*
        [DllImport("winmm.dll", EntryPoint = "GetDriverModuleHandle")]
        public static extern IntPtr GetDriverModuleHandle(IntPtr hDriver);


        /// Return Type: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetDoubleClickTime")]
        public static extern uint GetDoubleClickTime();


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDllDirectoryW")]
        public static extern uint GetDllDirectoryW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetDllDirectoryA")]
        public static extern uint GetDllDirectoryA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPWSTR->WCHAR*
        ///cchMax: int
        [DllImport("user32.dll", EntryPoint = "GetDlgItemTextW")]
        public static extern uint GetDlgItemTextW([In] IntPtr hDlg, int nIDDlgItem, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpString, int cchMax);


        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpString: LPSTR->CHAR*
        ///cchMax: int
        [DllImport("user32.dll", EntryPoint = "GetDlgItemTextA")]
        public static extern uint GetDlgItemTextA([In] IntPtr hDlg, int nIDDlgItem, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpString, int cchMax);


        /// Return Type: UINT->unsigned int
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        ///lpTranslated: BOOL*
        ///bSigned: BOOL->int
        [DllImport("user32.dll", EntryPoint = "GetDlgItemInt")]
        public static extern uint GetDlgItemInt([In] IntPtr hDlg, int nIDDlgItem, IntPtr lpTranslated, [MarshalAs(UnmanagedType.Bool)] bool bSigned);


        /// Return Type: HWND->HWND__*
        ///hDlg: HWND->HWND__*
        ///nIDDlgItem: int
        [DllImport("user32.dll", EntryPoint = "GetDlgItem")]
        public static extern IntPtr GetDlgItem([In] IntPtr hDlg, int nIDDlgItem);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetDlgCtrlID")]
        public static extern int GetDlgCtrlID([In] IntPtr hWnd);


        /// Return Type: BOOL->int
        ///lpRootPathName: LPCWSTR->WCHAR*
        ///lpSectorsPerCluster: LPDWORD->DWORD*
        ///lpBytesPerSector: LPDWORD->DWORD*
        ///lpNumberOfFreeClusters: LPDWORD->DWORD*
        ///lpTotalNumberOfClusters: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, IntPtr lpSectorsPerCluster, IntPtr lpBytesPerSector, IntPtr lpNumberOfFreeClusters, IntPtr lpTotalNumberOfClusters);


        /// Return Type: BOOL->int
        ///lpDirectoryName: LPCWSTR->WCHAR*
        ///lpFreeBytesAvailableToCaller: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfFreeBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpDirectoryName, IntPtr lpFreeBytesAvailableToCaller, IntPtr lpTotalNumberOfBytes, IntPtr lpTotalNumberOfFreeBytes);


        /// Return Type: BOOL->int
        ///lpDirectoryName: LPCSTR->CHAR*
        ///lpFreeBytesAvailableToCaller: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        ///lpTotalNumberOfFreeBytes: PULARGE_INTEGER->ULARGE_INTEGER*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpDirectoryName, IntPtr lpFreeBytesAvailableToCaller, IntPtr lpTotalNumberOfBytes, IntPtr lpTotalNumberOfFreeBytes);


        /// Return Type: BOOL->int
        ///lpRootPathName: LPCSTR->CHAR*
        ///lpSectorsPerCluster: LPDWORD->DWORD*
        ///lpBytesPerSector: LPDWORD->DWORD*
        ///lpNumberOfFreeClusters: LPDWORD->DWORD*
        ///lpTotalNumberOfClusters: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDiskFreeSpaceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceA([In] [MarshalAs(UnmanagedType.LPStr)] string lpRootPathName, IntPtr lpSectorsPerCluster, IntPtr lpBytesPerSector, IntPtr lpNumberOfFreeClusters, IntPtr lpTotalNumberOfClusters);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hbm: HBITMAP->HBITMAP__*
        ///start: UINT->unsigned int
        ///cLines: UINT->unsigned int
        ///lpvBits: LPVOID->void*
        ///lpbmi: LPBITMAPINFO->tagBITMAPINFO*
        ///usage: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetDIBits")]
        public static extern int GetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines, IntPtr lpvBits, ref tagBITMAPINFO lpbmi, uint usage);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///iStart: UINT->unsigned int
        ///cEntries: UINT->unsigned int
        ///prgbq: RGBQUAD*
        [DllImport("gdi32.dll", EntryPoint = "GetDIBColorTable")]
        public static extern uint GetDIBColorTable([In] IntPtr hdc, uint iStart, uint cEntries, IntPtr prgbq);


        /// Return Type: int
        [DllImport("user32.dll", EntryPoint = "GetDialogBaseUnits")]
        public static extern int GetDialogBaseUnits();


        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        ///pfOn: BOOL*
        [DllImport("kernel32.dll", EntryPoint = "GetDevicePowerState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDevicePowerState([In] IntPtr hDevice, [Out] out int pfOn);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpRamp: LPVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "GetDeviceGammaRamp")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDeviceGammaRamp([In] IntPtr hdc, IntPtr lpRamp);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///index: int
        [DllImport("gdi32.dll", EntryPoint = "GetDeviceCaps")]
        public static extern int GetDeviceCaps([In] IntPtr hdc, int index);


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        public static extern IntPtr GetDesktopWindow();


        /// Return Type: BOOL->int
        ///pszBuffer: LPWSTR->WCHAR*
        ///pcchBuffer: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetDefaultPrinterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDefaultPrinterW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszBuffer, ref uint pcchBuffer);


        /// Return Type: BOOL->int
        ///pszBuffer: LPSTR->CHAR*
        ///pcchBuffer: LPDWORD->DWORD*
        [DllImport("<Unknown>", EntryPoint = "GetDefaultPrinterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDefaultPrinterA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszBuffer, ref uint pcchBuffer);


        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///lpdwSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDefaultCommConfigW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDefaultCommConfigW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszName, IntPtr lpCC, ref uint lpdwSize);


        /// Return Type: BOOL->int
        ///lpszName: LPCSTR->CHAR*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///lpdwSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetDefaultCommConfigA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDefaultCommConfigA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszName, IntPtr lpCC, ref uint lpdwSize);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetDCPenColor")]
        public static extern uint GetDCPenColor([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "GetDCOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDCOrgEx([In] IntPtr hdc, [Out] out Point lppt);


        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        ///hrgnClip: HRGN->HRGN__*
        ///flags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetDCEx")]
        public static extern IntPtr GetDCEx([In] IntPtr hWnd, [In] IntPtr hrgnClip, uint flags);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetDCBrushColor")]
        public static extern uint GetDCBrushColor([In] IntPtr hdc);


        /// Return Type: HDC->HDC__*
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC([In] IntPtr hWnd);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpDate: SYSTEMTIME*
        ///lpFormat: LPCWSTR->WCHAR*
        ///lpDateStr: LPWSTR->WCHAR*
        ///cchDate: int
        [DllImport("kernel32.dll", EntryPoint = "GetDateFormatW")]
        public static extern int GetDateFormatW(uint Locale, uint dwFlags, [In] IntPtr lpDate, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFormat, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpDateStr, int cchDate);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpDate: SYSTEMTIME*
        ///lpFormat: LPCSTR->CHAR*
        ///lpDateStr: LPSTR->CHAR*
        ///cchDate: int
        [DllImport("kernel32.dll", EntryPoint = "GetDateFormatA")]
        public static extern int GetDateFormatA(uint Locale, uint dwFlags, [In] IntPtr lpDate, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFormat, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpDateStr, int cchDate);


        /// Return Type: BOOL->int
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos([Out] out Point lpPoint);


        /// Return Type: BOOL->int
        ///pci: PCURSORINFO->tagCURSORINFO*
        [DllImport("user32.dll", EntryPoint = "GetCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorInfo(ref tagCURSORINFO pci);


        /// Return Type: HCURSOR->HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "GetCursor")]
        public static extern IntPtr GetCursor();


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentThreadId")]
        public static extern uint GetCurrentThreadId();


        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentThread")]
        public static extern IntPtr GetCurrentThread();


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessorNumber")]
        public static extern uint GetCurrentProcessorNumber();


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId")]
        public static extern uint GetCurrentProcessId();


        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
        public static extern IntPtr GetCurrentProcess();


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "GetCurrentPositionEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentPositionEx([In] IntPtr hdc, [Out] out Point lppt);


        /// Return Type: HGDIOBJ->void*
        ///hdc: HDC->HDC__*
        ///type: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetCurrentObject")]
        public static extern IntPtr GetCurrentObject([In] IntPtr hdc, uint type);


        /// Return Type: BOOL->int
        ///lpHwProfileInfo: LPHW_PROFILE_INFOW->tagHW_PROFILE_INFOW*
        [DllImport("advapi32.dll", EntryPoint = "GetCurrentHwProfileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentHwProfileW([Out] out tagHW_PROFILE_INFOW lpHwProfileInfo);


        /// Return Type: BOOL->int
        ///lpHwProfileInfo: LPHW_PROFILE_INFOA->tagHW_PROFILE_INFOA*
        [DllImport("advapi32.dll", EntryPoint = "GetCurrentHwProfileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentHwProfileA([Out] out tagHW_PROFILE_INFOA lpHwProfileInfo);


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentDirectoryW")]
        public static extern uint GetCurrentDirectoryW(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: DWORD->unsigned int
        ///nBufferLength: DWORD->unsigned int
        ///lpBuffer: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentDirectoryA")]
        public static extern uint GetCurrentDirectoryA(uint nBufferLength, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///bMaximumWindow: BOOL->int
        ///lpConsoleCurrentFont: PCONSOLE_FONT_INFO->_CONSOLE_FONT_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentConsoleFont")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentConsoleFont(IntPtr hConsoleOutput, [MarshalAs(UnmanagedType.Bool)] bool bMaximumWindow, ref CONSOLE_FONT_INFO lpConsoleCurrentFont);


        /// Return Type: BOOL->int
        ///lphActCtx: HANDLE*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentActCtx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentActCtx(out IntPtr lphActCtx);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCWSTR->WCHAR*
        ///lpFormat: CURRENCYFMTW*
        ///lpCurrencyStr: LPWSTR->WCHAR*
        ///cchCurrency: int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrencyFormatW")]
        public static extern int GetCurrencyFormatW(uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpValue, [In] IntPtr lpFormat, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpCurrencyStr, int cchCurrency);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpValue: LPCSTR->CHAR*
        ///lpFormat: CURRENCYFMTA*
        ///lpCurrencyStr: LPSTR->CHAR*
        ///cchCurrency: int
        [DllImport("kernel32.dll", EntryPoint = "GetCurrencyFormatA")]
        public static extern int GetCurrencyFormatA(uint Locale, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpValue, [In] IntPtr lpFormat, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpCurrencyStr, int cchCurrency);


        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpCPInfoEx: LPCPINFOEXW->_cpinfoexW*
        [DllImport("kernel32.dll", EntryPoint = "GetCPInfoExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoExW(uint CodePage, uint dwFlags, [Out] out CPINFOEXW lpCPInfoEx);


        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpCPInfoEx: LPCPINFOEXA->_cpinfoexA*
        [DllImport("kernel32.dll", EntryPoint = "GetCPInfoExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfoExA(uint CodePage, uint dwFlags, [Out] out CPINFOEXA lpCPInfoEx);


        /// Return Type: BOOL->int
        ///CodePage: UINT->unsigned int
        ///lpCPInfo: LPCPINFO->_cpinfo*
        [DllImport("kernel32.dll", EntryPoint = "GetCPInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCPInfo(uint CodePage, [Out] out CPINFO lpCPInfo);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        [DllImport("ole32.dll", EntryPoint = "GetConvertStg", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetConvertStg(ref IStorage pStg);


        /// Return Type: HWND->HWND__*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow")]
        public static extern IntPtr GetConsoleWindow();


        /// Return Type: DWORD->unsigned int
        ///lpConsoleTitle: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleTitleW")]
        public static extern uint GetConsoleTitleW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpConsoleTitle, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpConsoleTitle: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleTitleA")]
        public static extern uint GetConsoleTitleA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpConsoleTitle, uint nSize);


        /// Return Type: BOOL->int
        ///lpConsoleSelectionInfo: PCONSOLE_SELECTION_INFO->_CONSOLE_SELECTION_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleSelectionInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleSelectionInfo(ref CONSOLE_SELECTION_INFO lpConsoleSelectionInfo);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleScreenBufferInfo: PCONSOLE_SCREEN_BUFFER_INFO->_CONSOLE_SCREEN_BUFFER_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleScreenBufferInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, ref CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);


        /// Return Type: DWORD->unsigned int
        ///lpdwProcessList: LPDWORD->DWORD*
        ///dwProcessCount: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleProcessList")]
        public static extern uint GetConsoleProcessList(ref uint lpdwProcessList, uint dwProcessCount);


        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleOutputCP")]
        public static extern uint GetConsoleOutputCP();


        /// Return Type: BOOL->int
        ///hConsoleHandle: HANDLE->void*
        ///lpMode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleMode(IntPtr hConsoleHandle, ref uint lpMode);


        /// Return Type: COORD->_COORD
        ///hConsoleOutput: HANDLE->void*
        ///nFont: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleFontSize")]
        public static extern COORD GetConsoleFontSize(IntPtr hConsoleOutput, uint nFont);


        /// Return Type: BOOL->int
        ///lpModeFlags: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleDisplayMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleDisplayMode(ref uint lpModeFlags);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleCursorInfo: PCONSOLE_CURSOR_INFO->_CONSOLE_CURSOR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleCursorInfo(IntPtr hConsoleOutput, ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);


        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleCP")]
        public static extern uint GetConsoleCP();


        /// Return Type: DWORD->unsigned int
        ///Source: LPWSTR->WCHAR*
        ///TargetBuffer: LPWSTR->WCHAR*
        ///TargetBufferLength: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasW")]
        public static extern uint GetConsoleAliasW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder Source, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder TargetBuffer, uint TargetBufferLength, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///ExeNameBuffer: LPWSTR->WCHAR*
        ///ExeNameBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesW")]
        public static extern uint GetConsoleAliasExesW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ExeNameBuffer, uint ExeNameBufferLength);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesLengthW")]
        public static extern uint GetConsoleAliasExesLengthW();


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesLengthA")]
        public static extern uint GetConsoleAliasExesLengthA();


        /// Return Type: DWORD->unsigned int
        ///ExeNameBuffer: LPSTR->CHAR*
        ///ExeNameBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesA")]
        public static extern uint GetConsoleAliasExesA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ExeNameBuffer, uint ExeNameBufferLength);


        /// Return Type: DWORD->unsigned int
        ///AliasBuffer: LPWSTR->WCHAR*
        ///AliasBufferLength: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesW")]
        public static extern uint GetConsoleAliasesW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder AliasBuffer, uint AliasBufferLength, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesLengthW")]
        public static extern uint GetConsoleAliasesLengthW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesLengthA")]
        public static extern uint GetConsoleAliasesLengthA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///AliasBuffer: LPSTR->CHAR*
        ///AliasBufferLength: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesA")]
        public static extern uint GetConsoleAliasesA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder AliasBuffer, uint AliasBufferLength, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///Source: LPSTR->CHAR*
        ///TargetBuffer: LPSTR->CHAR*
        ///TargetBufferLength: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasA")]
        public static extern uint GetConsoleAliasA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder Source, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder TargetBuffer, uint TargetBufferLength, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameW([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, ref uint nSize);


        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameExW(COMPUTER_NAME_FORMAT NameType, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, ref uint nSize);


        /// Return Type: BOOL->int
        ///NameType: COMPUTER_NAME_FORMAT->_COMPUTER_NAME_FORMAT
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameExA(COMPUTER_NAME_FORMAT NameType, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, ref uint nSize);


        /// Return Type: BOOL->int
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetComputerNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComputerNameA([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, ref uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpFileSizeHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCompressedFileSizeW")]
        public static extern uint GetCompressedFileSizeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [Out] out uint lpFileSizeHigh);


        /// Return Type: DWORD->unsigned int
        ///lpFileName: LPCSTR->CHAR*
        ///lpFileSizeHigh: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCompressedFileSizeA")]
        public static extern uint GetCompressedFileSizeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [Out] out uint lpFileSizeHigh);


        /// Return Type: HRESULT->LONG->int
        ///pClassspec: uCLSSPEC*
        ///ppszComponentID: LPSTR*
        [DllImport("urlmon.dll", EntryPoint = "GetComponentIDFromCLSSPEC", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetComponentIDFromCLSSPEC(ref uCLSSPEC pClassspec, ref IntPtr ppszComponentID);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCommTimeouts: LPCOMMTIMEOUTS->_COMMTIMEOUTS*
        [DllImport("kernel32.dll", EntryPoint = "GetCommTimeouts")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommTimeouts([In] IntPtr hFile, [Out] out COMMTIMEOUTS lpCommTimeouts);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpDCB: LPDCB->_DCB*
        [DllImport("kernel32.dll", EntryPoint = "GetCommState")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommState([In] IntPtr hFile, [Out] out DCB lpDCB);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpCommProp: LPCOMMPROP->_COMMPROP*
        [DllImport("kernel32.dll", EntryPoint = "GetCommProperties")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommProperties([In] IntPtr hFile, [Out] out COMMPROP lpCommProp);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpModemStat: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCommModemStatus")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommModemStatus([In] IntPtr hFile, [Out] out uint lpModemStat);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpEvtMask: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCommMask")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommMask([In] IntPtr hFile, [Out] out uint lpEvtMask);


        /// Return Type: BOOL->int
        ///hCommDev: HANDLE->void*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        ///lpdwSize: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCommConfig")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCommConfig([In] IntPtr hCommDev, IntPtr lpCC, ref uint lpdwSize);


        /// Return Type: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCommandLineW")]
        public static extern IntPtr GetCommandLineW();


        /// Return Type: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetCommandLineA")]
        public static extern IntPtr GetCommandLineA();


        /// Return Type: BOOL->int
        ///hwndCombo: HWND->HWND__*
        ///pcbi: PCOMBOBOXINFO->tagCOMBOBOXINFO*
        [DllImport("user32.dll", EntryPoint = "GetComboBoxInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComboBoxInfo([In] IntPtr hwndCombo, ref tagCOMBOBOXINFO pcbi);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetColorSpace")]
        public static extern IntPtr GetColorSpace([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpca: LPCOLORADJUSTMENT->tagCOLORADJUSTMENT*
        [DllImport("gdi32.dll", EntryPoint = "GetColorAdjustment")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetColorAdjustment([In] IntPtr hdc, [Out] out tagCOLORADJUSTMENT lpca);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///hrgn: HRGN->HRGN__*
        [DllImport("gdi32.dll", EntryPoint = "GetClipRgn")]
        public static extern int GetClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);


        /// Return Type: BOOL->int
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetClipCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClipCursor([Out] out tagRECT lpRect);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///lprect: LPRECT->tagRECT*
        [DllImport("gdi32.dll", EntryPoint = "GetClipBox")]
        public static extern int GetClipBox([In] IntPtr hdc, [Out] out tagRECT lprect);


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetClipboardViewer")]
        public static extern IntPtr GetClipboardViewer();


        /// Return Type: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetClipboardSequenceNumber")]
        public static extern uint GetClipboardSequenceNumber();


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetClipboardOwner")]
        public static extern IntPtr GetClipboardOwner();


        /// Return Type: int
        ///format: UINT->unsigned int
        ///lpszFormatName: LPWSTR->WCHAR*
        ///cchMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClipboardFormatNameW")]
        public static extern int GetClipboardFormatNameW(uint format, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpszFormatName, int cchMaxCount);


        /// Return Type: int
        ///format: UINT->unsigned int
        ///lpszFormatName: LPSTR->CHAR*
        ///cchMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClipboardFormatNameA")]
        public static extern int GetClipboardFormatNameA(uint format, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszFormatName, int cchMaxCount);


        /// Return Type: HANDLE->void*
        ///uFormat: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetClipboardData")]
        public static extern IntPtr GetClipboardData(uint uFormat);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpRect: LPRECT->tagRECT*
        [DllImport("user32.dll", EntryPoint = "GetClientRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect([In] IntPtr hWnd, [Out] out tagRECT lpRect);


        /// Return Type: WORD->unsigned short
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetClassWord")]
        public static extern ushort GetClassWord([In] IntPtr hWnd, int nIndex);


        /// Return Type: HRESULT->LONG->int
        ///szURL: LPCWSTR->WCHAR*
        ///pClsID: CLSID*
        [DllImport("urlmon.dll", EntryPoint = "GetClassURL", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetClassURL([In] [MarshalAs(UnmanagedType.LPWStr)] string szURL, ref GUID pClsID);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpClassName: LPWSTR->WCHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClassNameW")]
        public static extern int GetClassNameW([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpClassName, int nMaxCount);


        /// Return Type: int
        ///hWnd: HWND->HWND__*
        ///lpClassName: LPSTR->CHAR*
        ///nMaxCount: int
        [DllImport("user32.dll", EntryPoint = "GetClassNameA")]
        public static extern int GetClassNameA([In] IntPtr hWnd, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpClassName, int nMaxCount);


        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetClassLongW")]
        public static extern uint GetClassLongW([In] IntPtr hWnd, int nIndex);


        /// Return Type: DWORD->unsigned int
        ///hWnd: HWND->HWND__*
        ///nIndex: int
        [DllImport("user32.dll", EntryPoint = "GetClassLongA")]
        public static extern uint GetClassLongA([In] IntPtr hWnd, int nIndex);


        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWndClass: LPWNDCLASSW->tagWNDCLASSW*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [Out] out tagWNDCLASSW lpWndClass);


        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpszClass: LPCWSTR->WCHAR*
        ///lpwcx: LPWNDCLASSEXW->tagWNDCLASSEXW*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoExW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszClass, [Out] out tagWNDCLASSEXW lpwcx);


        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpszClass: LPCSTR->CHAR*
        ///lpwcx: LPWNDCLASSEXA->tagWNDCLASSEXA*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoExA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszClass, [Out] out tagWNDCLASSEXA lpwcx);


        /// Return Type: BOOL->int
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpClassName: LPCSTR->CHAR*
        ///lpWndClass: LPWNDCLASSA->tagWNDCLASSA*
        [DllImport("user32.dll", EntryPoint = "GetClassInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [Out] out tagWNDCLASSA lpWndClass);


        /// Return Type: HRESULT->LONG->int
        ///pBC: LPBC->IBindCtx*
        ///szFilename: LPCWSTR->WCHAR*
        ///pBuffer: LPVOID->void*
        ///cbSize: DWORD->unsigned int
        ///szMime: LPCWSTR->WCHAR*
        ///dwReserved: DWORD->unsigned int
        ///pclsid: CLSID*
        [DllImport("urlmon.dll", EntryPoint = "GetClassFileOrMime", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetClassFileOrMime(ref IBindCtx pBC, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFilename, IntPtr pBuffer, uint cbSize, [In] [MarshalAs(UnmanagedType.LPWStr)] string szMime, uint dwReserved, ref GUID pclsid);


        /// Return Type: HRESULT->LONG->int
        ///szFilename: LPCOLESTR->OLECHAR*
        ///pclsid: CLSID*
        [DllImport("ole32.dll", EntryPoint = "GetClassFile", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetClassFile([In] [MarshalAs(UnmanagedType.LPWStr)] string szFilename, ref GUID pclsid);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImport("gdi32.dll", EntryPoint = "GetCharWidthW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharWidthW([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///giFirst: UINT->unsigned int
        ///cgi: UINT->unsigned int
        ///pgi: LPWORD->WORD*
        ///piWidths: LPINT->int*
        [DllImport("gdi32.dll", EntryPoint = "GetCharWidthI")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharWidthI([In] IntPtr hdc, uint giFirst, uint cgi, [In] IntPtr pgi, IntPtr piWidths);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: PFLOAT->FLOAT*
        [DllImport("gdi32.dll", EntryPoint = "GetCharWidthFloatW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharWidthFloatW([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: PFLOAT->FLOAT*
        [DllImport("gdi32.dll", EntryPoint = "GetCharWidthFloatA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharWidthFloatA([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImport("gdi32.dll", EntryPoint = "GetCharWidthA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharWidthA([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImport("gdi32.dll", EntryPoint = "GetCharWidth32W")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharWidth32W([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpBuffer: LPINT->int*
        [DllImport("gdi32.dll", EntryPoint = "GetCharWidth32A")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharWidth32A([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpBuffer);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCWSTR->WCHAR*
        ///nCount: int
        ///nMexExtent: int
        ///lpResults: LPGCP_RESULTSW->tagGCP_RESULTSW*
        ///dwFlags: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetCharacterPlacementW")]
        public static extern uint GetCharacterPlacementW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString, int nCount, int nMexExtent, ref tagGCP_RESULTSW lpResults, uint dwFlags);


        /// Return Type: DWORD->unsigned int
        ///hdc: HDC->HDC__*
        ///lpString: LPCSTR->CHAR*
        ///nCount: int
        ///nMexExtent: int
        ///lpResults: LPGCP_RESULTSA->tagGCP_RESULTSA*
        ///dwFlags: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetCharacterPlacementA")]
        public static extern uint GetCharacterPlacementA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString, int nCount, int nMexExtent, ref tagGCP_RESULTSA lpResults, uint dwFlags);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///wFirst: UINT->unsigned int
        ///wLast: UINT->unsigned int
        ///lpABC: LPABC->_ABC*
        [DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsW([In] IntPtr hdc, uint wFirst, uint wLast, IntPtr lpABC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///giFirst: UINT->unsigned int
        ///cgi: UINT->unsigned int
        ///pgi: LPWORD->WORD*
        ///pabc: LPABC->_ABC*
        [DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsI")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsI([In] IntPtr hdc, uint giFirst, uint cgi, [In] IntPtr pgi, IntPtr pabc);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpABC: LPABCFLOAT->_ABCFLOAT*
        [DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsFloatW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsFloatW([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpABC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///iFirst: UINT->unsigned int
        ///iLast: UINT->unsigned int
        ///lpABC: LPABCFLOAT->_ABCFLOAT*
        [DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsFloatA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsFloatA([In] IntPtr hdc, uint iFirst, uint iLast, IntPtr lpABC);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///wFirst: UINT->unsigned int
        ///wLast: UINT->unsigned int
        ///lpABC: LPABC->_ABC*
        [DllImport("gdi32.dll", EntryPoint = "GetCharABCWidthsA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCharABCWidthsA([In] IntPtr hdc, uint wFirst, uint wLast, IntPtr lpABC);


        /// Return Type: BOOL->int
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "GetCaretPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCaretPos([Out] out Point lpPoint);


        /// Return Type: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetCaretBlinkTime")]
        public static extern uint GetCaretBlinkTime();


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetCapture")]
        public static extern IntPtr GetCapture();


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPWSTR->WCHAR*
        ///cchData: int
        ///lpValue: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCalendarInfoW")]
        public static extern int GetCalendarInfoW(uint Locale, uint Calendar, uint CalType, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpCalData, int cchData, [In] IntPtr lpValue);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///Calendar: CALID->DWORD->unsigned int
        ///CalType: CALTYPE->DWORD->unsigned int
        ///lpCalData: LPSTR->CHAR*
        ///cchData: int
        ///lpValue: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetCalendarInfoA")]
        public static extern int GetCalendarInfoA(uint Locale, uint Calendar, uint CalType, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpCalData, int cchData, [In] IntPtr lpValue);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lppt: LPPOINT->tagPOINT*
        [DllImport("gdi32.dll", EntryPoint = "GetBrushOrgEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetBrushOrgEx([In] IntPtr hdc, [Out] out Point lppt);


        /// Return Type: UINT->unsigned int
        ///hdc: HDC->HDC__*
        ///lprect: LPRECT->tagRECT*
        ///flags: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GetBoundsRect")]
        public static extern uint GetBoundsRect([In] IntPtr hdc, [Out] out tagRECT lprect, uint flags);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetBkMode")]
        public static extern int GetBkMode([In] IntPtr hdc);


        /// Return Type: COLORREF->DWORD->unsigned int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetBkColor")]
        public static extern uint GetBkColor([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hbit: HBITMAP->HBITMAP__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetBitmapDimensionEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetBitmapDimensionEx([In] IntPtr hbit, [Out] out tagSIZE lpsize);


        /// Return Type: LONG->int
        ///hbit: HBITMAP->HBITMAP__*
        ///cb: LONG->int
        ///lpvBits: LPVOID->void*
        [DllImport("gdi32.dll", EntryPoint = "GetBitmapBits")]
        public static extern int GetBitmapBits([In] IntPtr hbit, int cb, IntPtr lpvBits);


        /// Return Type: BOOL->int
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpBinaryType: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetBinaryTypeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetBinaryTypeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, [Out] out uint lpBinaryType);


        /// Return Type: BOOL->int
        ///lpApplicationName: LPCSTR->CHAR*
        ///lpBinaryType: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetBinaryTypeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetBinaryTypeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, [Out] out uint lpBinaryType);


        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPWSTR->WCHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GetAtomNameW")]
        public static extern uint GetAtomNameW(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, int nSize);


        /// Return Type: UINT->unsigned int
        ///nAtom: ATOM->WORD->unsigned short
        ///lpBuffer: LPSTR->CHAR*
        ///nSize: int
        [DllImport("kernel32.dll", EntryPoint = "GetAtomNameA")]
        public static extern uint GetAtomNameA(ushort nAtom, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, int nSize);


        /// Return Type: SHORT->short
        ///vKey: int
        [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
        public static extern short GetAsyncKeyState(int vKey);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpsize: LPSIZE->tagSIZE*
        [DllImport("gdi32.dll", EntryPoint = "GetAspectRatioFilterEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAspectRatioFilterEx([In] IntPtr hdc, [Out] out tagSIZE lpsize);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "GetArcDirection")]
        public static extern int GetArcDirection([In] IntPtr hdc);


        /// Return Type: HWND->HWND__*
        ///hwnd: HWND->HWND__*
        ///gaFlags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetAncestor")]
        public static extern IntPtr GetAncestor([In] IntPtr hwnd, uint gaFlags);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///iItem: int
        ///pati: PALTTABINFO->tagALTTABINFO*
        ///pszItemText: LPWSTR->WCHAR*
        ///cchItemText: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetAltTabInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAltTabInfoW([In] IntPtr hwnd, int iItem, ref tagALTTABINFO pati, [Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszItemText, uint cchItemText);


        /// Return Type: BOOL->int
        ///hwnd: HWND->HWND__*
        ///iItem: int
        ///pati: PALTTABINFO->tagALTTABINFO*
        ///pszItemText: LPSTR->CHAR*
        ///cchItemText: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "GetAltTabInfoA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAltTabInfoA([In] IntPtr hwnd, int iItem, ref tagALTTABINFO pati, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszItemText, uint cchItemText);


        /// Return Type: HRESULT->LONG->int
        ///lcid: LCID->DWORD->unsigned int
        ///prgp: LPOLESTR**
        [DllImport("oleaut32.dll", EntryPoint = "GetAltMonthNames", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetAltMonthNames(uint lcid, ref IntPtr prgp);


        /// Return Type: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "GetActiveWindow")]
        public static extern IntPtr GetActiveWindow();


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///pvReserved: void*
        ///ppunk: IUnknown**
        [DllImport("oleaut32.dll", EntryPoint = "GetActiveObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetActiveObject(ref GUID rclsid, IntPtr pvReserved, ref IntPtr ppunk);


        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetACP")]
        public static extern uint GetACP();


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///pAclInformation: LPVOID->void*
        ///nAclInformationLength: DWORD->unsigned int
        ///dwAclInformationClass: ACL_INFORMATION_CLASS->_ACL_INFORMATION_CLASS
        [DllImport("advapi32.dll", EntryPoint = "GetAclInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAclInformation([In] ref ACL pAcl, IntPtr pAclInformation, uint nAclInformationLength, ACL_INFORMATION_CLASS dwAclInformationClass);


        /// Return Type: BOOL->int
        ///pAcl: PACL->ACL*
        ///dwAceIndex: DWORD->unsigned int
        ///pAce: LPVOID*
        [DllImport("advapi32.dll", EntryPoint = "GetAce")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAce([In] ref ACL pAcl, uint dwAceIndex, out IntPtr pAce);


        /// Return Type: void
        ///lpOutputBuffer: PVOID->void*
        ///dwReceiveDataLength: DWORD->unsigned int
        ///dwLocalAddressLength: DWORD->unsigned int
        ///dwRemoteAddressLength: DWORD->unsigned int
        ///LocalSockaddr: sockaddr**
        ///LocalSockaddrLength: LPINT->int*
        ///RemoteSockaddr: sockaddr**
        ///RemoteSockaddrLength: LPINT->int*
        [DllImport("mswsock.dll", EntryPoint = "GetAcceptExSockaddrs", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetAcceptExSockaddrs(IntPtr lpOutputBuffer, uint dwReceiveDataLength, uint dwLocalAddressLength, uint dwRemoteAddressLength, ref IntPtr LocalSockaddr, ref int LocalSockaddrLength, ref IntPtr RemoteSockaddr, ref int RemoteSockaddrLength);


        /// Return Type: BOOL->int
        ///dwCtrlEvent: DWORD->unsigned int
        ///dwProcessGroupId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GenerateConsoleCtrlEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);


        /// Return Type: DWORD->unsigned int
        ///dw: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GdiSetBatchLimit")]
        public static extern uint GdiSetBatchLimit(uint dw);


        /// Return Type: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "GdiGetBatchLimit")]
        public static extern uint GdiGetBatchLimit();


        /// Return Type: BOOL->int
        [DllImport("gdi32.dll", EntryPoint = "GdiFlush")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GdiFlush();


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///nSize: UINT->unsigned int
        ///lpData: BYTE*
        [DllImport("gdi32.dll", EntryPoint = "GdiComment")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GdiComment([In] IntPtr hdc, uint nSize, [In] IntPtr lpData);

    }

}
