using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: BOOL->int
    ///param0: HDC->HDC__*
    ///param1: LPARAM->LONG_PTR->int
    ///param2: int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GRAYSTRINGPROC(IntPtr param0, IntPtr param1, int param2);

    /// Return Type: int
    ///param0: LPVOID->void*
    ///param1: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GOBJENUMPROC(IntPtr param0, IntPtr param1);

    /// Return Type: BOOL->int
    ///param0: GEOID->LONG->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int GEO_ENUMPROC(int param0);

    /// Return Type: void
    ///param0: void*
    ///param1: unsigned char*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GENERIC_UNBIND_ROUTINE(IntPtr param0, IntPtr param1);

    /// Return Type: void*
    ///param0: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr GENERIC_BINDING_ROUTINE(IntPtr param0);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GUID
    {

        /// unsigned int
        public uint Data1;

        /// unsigned short
        public ushort Data2;

        /// unsigned short
        public ushort Data3;

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string Data4;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GRADIENT_TRIANGLE
    {

        /// ULONG->unsigned int
        public uint Vertex1;

        /// ULONG->unsigned int
        public uint Vertex2;

        /// ULONG->unsigned int
        public uint Vertex3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GRADIENT_RECT
    {

        /// ULONG->unsigned int
        public uint UpperLeft;

        /// ULONG->unsigned int
        public uint LowerRight;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLYPHMETRICSFLOAT
    {

        /// FLOAT->float
        public float gmfBlackBoxX;

        /// FLOAT->float
        public float gmfBlackBoxY;

        /// POINTFLOAT->_POINTFLOAT
        public POINTFLOAT gmfptGlyphOrigin;

        /// FLOAT->float
        public float gmfCellIncX;

        /// FLOAT->float
        public float gmfCellIncY;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLYPHMETRICS
    {

        /// UINT->unsigned int
        public uint gmBlackBoxX;

        /// UINT->unsigned int
        public uint gmBlackBoxY;

        /// POINT->tagPOINT
        public Point gmptGlyphOrigin;

        /// short
        public short gmCellIncX;

        /// short
        public short gmCellIncY;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GET_MEDIA_TYPES
    {

        /// DWORD->unsigned int
        public uint DeviceType;

        /// DWORD->unsigned int
        public uint MediaInfoCount;

        /// DEVICE_MEDIA_INFO[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public DEVICE_MEDIA_INFO[] MediaInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GET_LENGTH_INFORMATION
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER Length;
    }

    public enum GET_FILEEX_INFO_LEVELS
    {

        GetFileExInfoStandard,

        GetFileExMaxInfoLevel,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GET_CHANGER_PARAMETERS
    {

        /// DWORD->unsigned int
        public uint Size;

        /// WORD->unsigned short
        public ushort NumberTransportElements;

        /// WORD->unsigned short
        public ushort NumberStorageElements;

        /// WORD->unsigned short
        public ushort NumberCleanerSlots;

        /// WORD->unsigned short
        public ushort NumberIEElements;

        /// WORD->unsigned short
        public ushort NumberDataTransferElements;

        /// WORD->unsigned short
        public ushort NumberOfDoors;

        /// WORD->unsigned short
        public ushort FirstSlotNumber;

        /// WORD->unsigned short
        public ushort FirstDriveNumber;

        /// WORD->unsigned short
        public ushort FirstTransportNumber;

        /// WORD->unsigned short
        public ushort FirstIEPortNumber;

        /// WORD->unsigned short
        public ushort FirstCleanerSlotAddress;

        /// WORD->unsigned short
        public ushort MagazineSize;

        /// DWORD->unsigned int
        public uint DriveCleanTimeout;

        /// DWORD->unsigned int
        public uint Features0;

        /// DWORD->unsigned int
        public uint Features1;

        /// BYTE->unsigned char
        public byte MoveFromTransport;

        /// BYTE->unsigned char
        public byte MoveFromSlot;

        /// BYTE->unsigned char
        public byte MoveFromIePort;

        /// BYTE->unsigned char
        public byte MoveFromDrive;

        /// BYTE->unsigned char
        public byte ExchangeFromTransport;

        /// BYTE->unsigned char
        public byte ExchangeFromSlot;

        /// BYTE->unsigned char
        public byte ExchangeFromIePort;

        /// BYTE->unsigned char
        public byte ExchangeFromDrive;

        /// BYTE->unsigned char
        public byte LockUnlockCapabilities;

        /// BYTE->unsigned char
        public byte PositionCapabilities;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] Reserved1;

        /// DWORD[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
        public uint[] Reserved2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GETVERSIONINPARAMS
    {

        /// BYTE->unsigned char
        public byte bVersion;

        /// BYTE->unsigned char
        public byte bRevision;

        /// BYTE->unsigned char
        public byte bReserved;

        /// BYTE->unsigned char
        public byte bIDEDeviceMap;

        /// DWORD->unsigned int
        public uint fCapabilities;

        /// DWORD[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
        public uint[] dwReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GENERIC_MAPPING
    {

        /// ACCESS_MASK->DWORD->unsigned int
        public uint GenericRead;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint GenericWrite;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint GenericExecute;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint GenericAll;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GENERIC_BINDING_ROUTINE_PAIR
    {

        /// GENERIC_BINDING_ROUTINE
        public GENERIC_BINDING_ROUTINE pfnBind;

        /// GENERIC_UNBIND_ROUTINE
        public GENERIC_UNBIND_ROUTINE pfnUnbind;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GENERIC_BINDING_INFO
    {

        /// void*
        public IntPtr pObj;

        /// unsigned int
        public uint Size;

        /// GENERIC_BINDING_ROUTINE
        public GENERIC_BINDING_ROUTINE pfnBind;

        /// GENERIC_UNBIND_ROUTINE
        public GENERIC_UNBIND_ROUTINE pfnUnbind;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GDI_OBJECT
    {

        /// DWORD->unsigned int
        public uint ObjectType;

        /// _GDI_OBJECT___MIDL_IAdviseSink_0002
        public _GDI_OBJECT___MIDL_IAdviseSink_0002 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GDI_NONREMOTE
    {

        /// int
        public int fContext;

        /// _GDI_NONREMOTE___MIDL_IWinTypes_0002
        public _GDI_NONREMOTE___MIDL_IWinTypes_0002 Union1;
    }

}
