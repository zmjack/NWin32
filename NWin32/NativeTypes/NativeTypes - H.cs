using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HWND__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HWINSTA__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HWINEVENTHOOK__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HWAVE__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HWAVEOUT__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HWAVEIN__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HUMPD__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HTASK__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HSZ__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HSTR__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HRSRC__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HRGN__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HRAWINPUT__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HPEN__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HPALETTE__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct hostent
    {

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string h_name;

        /// char**
        public IntPtr h_aliases;

        /// short
        public short h_addrtype;

        /// short
        public short h_length;

        /// char**
        public IntPtr h_addr_list;
    }

    /// Return Type: LRESULT->LONG_PTR->int
    ///code: int
    ///wParam: WPARAM->UINT_PTR->unsigned int
    ///lParam: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int HOOKPROC(int code, IntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct HMONITOR__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMMIO__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMIXER__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMIXEROBJ__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMIDI__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMIDISTRM__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMIDIOUT__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMIDIIN__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMETAFILE__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMENU__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HKL__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HKEY__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HINSTANCE__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HIMC__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HIMCC__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HICON__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HHOOK__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HGLRC__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HFONT__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HENHMETAFILE__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HDRVR__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HDROP__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HDESK__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HDDEDATA__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HDC__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HCONV__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HCONVLIST__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HCOLORSPACE__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HBRUSH__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HBITMAP__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HACCEL__
    {

        /// int
        public int unused;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HYPER_SIZEDARR
    {

        /// unsigned int
        public uint clSize;

        /// __int64*
        public IntPtr pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HMAC_INFO
    {

        /// ALG_ID->unsigned int
        public uint HashAlgid;

        /// BYTE*
        public IntPtr pbInnerString;

        /// DWORD->unsigned int
        public uint cbInnerString;

        /// BYTE*
        public IntPtr pbOuterString;

        /// DWORD->unsigned int
        public uint cbOuterString;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HIT_LOGGING_INFO
    {

        /// DWORD->unsigned int
        public uint dwStructSize;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszLoggedUrlName;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME StartTime;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME EndTime;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpszExtendedInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HISTOGRAM_BUCKET
    {

        /// DWORD->unsigned int
        public uint Reads;

        /// DWORD->unsigned int
        public uint Writes;
    }

    public enum HEAP_INFORMATION_CLASS
    {

        HeapCompatibilityInformation,
    }

}
