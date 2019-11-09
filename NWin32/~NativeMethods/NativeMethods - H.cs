using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HWND*
        [DllImport("ole32.dll", EntryPoint = "HWND_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HWND_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: HWND*
        [DllImport("ole32.dll", EntryPoint = "HWND_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint HWND_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HWND*
        [DllImport("ole32.dll", EntryPoint = "HWND_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HWND_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: HWND*
        [DllImport("ole32.dll", EntryPoint = "HWND_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void HWND_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: u_short->unsigned short
        ///hostshort: u_short->unsigned short
        [DllImport("ws2_32.dll", EntryPoint = "htons", CallingConvention = CallingConvention.StdCall)]
        public static extern ushort htons(ushort hostshort);


        /// Return Type: u_long->unsigned int
        ///hostlong: u_long->unsigned int
        [DllImport("ws2_32.dll", EntryPoint = "htonl", CallingConvention = CallingConvention.StdCall)]
        public static extern uint htonl(uint hostlong);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HMENU*
        [DllImport("ole32.dll", EntryPoint = "HMENU_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HMENU_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: HMENU*
        [DllImport("ole32.dll", EntryPoint = "HMENU_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint HMENU_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HMENU*
        [DllImport("ole32.dll", EntryPoint = "HMENU_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HMENU_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: HMENU*
        [DllImport("ole32.dll", EntryPoint = "HMENU_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void HMENU_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: HRESULT->LONG->int
        ///szTarget: LPCWSTR->WCHAR*
        ///szLocation: LPCWSTR->WCHAR*
        ///szTargetFrameName: LPCWSTR->WCHAR*
        ///pUnk: IUnknown*
        ///pbc: IBindCtx*
        ///param5: IBindStatusCallback*
        ///grfHLNF: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "HlinkSimpleNavigateToString", CallingConvention = CallingConvention.StdCall)]
        public static extern int HlinkSimpleNavigateToString([In] [MarshalAs(UnmanagedType.LPWStr)] string szTarget, [In] [MarshalAs(UnmanagedType.LPWStr)] string szLocation, [In] [MarshalAs(UnmanagedType.LPWStr)] string szTargetFrameName, ref IUnknown pUnk, ref IBindCtx pbc, ref IBindStatusCallback param5, uint grfHLNF, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pmkTarget: IMoniker*
        ///szLocation: LPCWSTR->WCHAR*
        ///szTargetFrameName: LPCWSTR->WCHAR*
        ///pUnk: IUnknown*
        ///pbc: IBindCtx*
        ///param5: IBindStatusCallback*
        ///grfHLNF: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "HlinkSimpleNavigateToMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int HlinkSimpleNavigateToMoniker(ref IMoniker pmkTarget, [In] [MarshalAs(UnmanagedType.LPWStr)] string szLocation, [In] [MarshalAs(UnmanagedType.LPWStr)] string szTargetFrameName, ref IUnknown pUnk, ref IBindCtx pbc, ref IBindStatusCallback param5, uint grfHLNF, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        ///szTarget: LPCWSTR->WCHAR*
        [DllImport("urlmon.dll", EntryPoint = "HlinkNavigateString", CallingConvention = CallingConvention.StdCall)]
        public static extern int HlinkNavigateString(ref IUnknown pUnk, [In] [MarshalAs(UnmanagedType.LPWStr)] string szTarget);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        ///pmkTarget: IMoniker*
        [DllImport("urlmon.dll", EntryPoint = "HlinkNavigateMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int HlinkNavigateMoniker(ref IUnknown pUnk, ref IMoniker pmkTarget);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        [DllImport("urlmon.dll", EntryPoint = "HlinkGoForward", CallingConvention = CallingConvention.StdCall)]
        public static extern int HlinkGoForward(ref IUnknown pUnk);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        [DllImport("urlmon.dll", EntryPoint = "HlinkGoBack", CallingConvention = CallingConvention.StdCall)]
        public static extern int HlinkGoBack(ref IUnknown pUnk);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///uIDHiliteItem: UINT->unsigned int
        ///uHilite: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "HiliteMenuItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HiliteMenuItem([In] IntPtr hWnd, [In] IntPtr hMenu, uint uIDHiliteItem, uint uHilite);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HideCaret([In] IntPtr hWnd);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HICON*
        [DllImport("ole32.dll", EntryPoint = "HICON_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HICON_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: HICON*
        [DllImport("ole32.dll", EntryPoint = "HICON_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint HICON_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HICON*
        [DllImport("ole32.dll", EntryPoint = "HICON_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HICON_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: HICON*
        [DllImport("ole32.dll", EntryPoint = "HICON_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void HICON_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HGLOBAL*
        [DllImport("ole32.dll", EntryPoint = "HGLOBAL_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HGLOBAL_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: HGLOBAL*
        [DllImport("ole32.dll", EntryPoint = "HGLOBAL_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint HGLOBAL_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HGLOBAL*
        [DllImport("ole32.dll", EntryPoint = "HGLOBAL_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HGLOBAL_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: HGLOBAL*
        [DllImport("ole32.dll", EntryPoint = "HGLOBAL_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void HGLOBAL_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        ///lpEntry: LPPROCESS_HEAP_ENTRY->_PROCESS_HEAP_ENTRY*
        [DllImport("kernel32.dll", EntryPoint = "HeapWalk")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapWalk([In] IntPtr hHeap, ref PROCESS_HEAP_ENTRY lpEntry);


        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapValidate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapValidate([In] IntPtr hHeap, uint dwFlags, [In] IntPtr lpMem);


        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapUnlock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapUnlock([In] IntPtr hHeap);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPCVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapSize")]
        public static extern uint HeapSize([In] IntPtr hHeap, uint dwFlags, [In] IntPtr lpMem);


        /// Return Type: BOOL->int
        ///HeapHandle: HANDLE->void*
        ///HeapInformationClass: HEAP_INFORMATION_CLASS->_HEAP_INFORMATION_CLASS
        ///HeapInformation: PVOID->void*
        ///HeapInformationLength: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapSetInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapSetInformation([In] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [In] IntPtr HeapInformation, uint HeapInformationLength);


        /// Return Type: LPVOID->void*
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPVOID->void*
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapReAlloc")]
        public static extern IntPtr HeapReAlloc(IntPtr hHeap, uint dwFlags, IntPtr lpMem, uint dwBytes);


        /// Return Type: BOOL->int
        ///HeapHandle: HANDLE->void*
        ///HeapInformationClass: HEAP_INFORMATION_CLASS->_HEAP_INFORMATION_CLASS
        ///HeapInformation: PVOID->void*
        ///HeapInformationLength: SIZE_T->ULONG_PTR->unsigned int
        ///ReturnLength: PSIZE_T->ULONG_PTR*
        [DllImport("kernel32.dll", EntryPoint = "HeapQueryInformation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapQueryInformation([In] IntPtr HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, IntPtr HeapInformation, uint HeapInformationLength, IntPtr ReturnLength);


        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapLock")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapLock([In] IntPtr hHeap);


        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///lpMem: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapFree")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);


        /// Return Type: BOOL->int
        ///hHeap: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "HeapDestroy")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HeapDestroy([In] IntPtr hHeap);


        /// Return Type: HANDLE->void*
        ///flOptions: DWORD->unsigned int
        ///dwInitialSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwMaximumSize: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapCreate")]
        public static extern IntPtr HeapCreate(uint flOptions, uint dwInitialSize, uint dwMaximumSize);


        /// Return Type: SIZE_T->ULONG_PTR->unsigned int
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapCompact")]
        public static extern uint HeapCompact([In] IntPtr hHeap, uint dwFlags);


        /// Return Type: LPVOID->void*
        ///hHeap: HANDLE->void*
        ///dwFlags: DWORD->unsigned int
        ///dwBytes: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "HeapAlloc")]
        public static extern IntPtr HeapAlloc([In] IntPtr hHeap, uint dwFlags, uint dwBytes);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HDC*
        [DllImport("ole32.dll", EntryPoint = "HDC_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HDC_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: HDC*
        [DllImport("ole32.dll", EntryPoint = "HDC_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint HDC_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HDC*
        [DllImport("ole32.dll", EntryPoint = "HDC_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HDC_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: HDC*
        [DllImport("ole32.dll", EntryPoint = "HDC_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void HDC_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HBITMAP*
        [DllImport("ole32.dll", EntryPoint = "HBITMAP_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HBITMAP_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: HBITMAP*
        [DllImport("ole32.dll", EntryPoint = "HBITMAP_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint HBITMAP_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HBITMAP*
        [DllImport("ole32.dll", EntryPoint = "HBITMAP_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HBITMAP_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: HBITMAP*
        [DllImport("ole32.dll", EntryPoint = "HBITMAP_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void HBITMAP_UserFree(ref uint param0, ref IntPtr param1);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HACCEL*
        [DllImport("ole32.dll", EntryPoint = "HACCEL_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HACCEL_UserUnmarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: HACCEL*
        [DllImport("ole32.dll", EntryPoint = "HACCEL_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint HACCEL_UserSize(ref uint param0, uint param1, ref IntPtr param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: HACCEL*
        [DllImport("ole32.dll", EntryPoint = "HACCEL_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HACCEL_UserMarshal(ref uint param0, IntPtr param1, ref IntPtr param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: HACCEL*
        [DllImport("ole32.dll", EntryPoint = "HACCEL_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void HACCEL_UserFree(ref uint param0, ref IntPtr param1);

    }

}
