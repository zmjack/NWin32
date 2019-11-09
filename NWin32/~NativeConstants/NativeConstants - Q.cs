using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// QUOTA_LIMITS_HARDWS_MIN_ENABLE -> 0x00000001
        public const int QUOTA_LIMITS_HARDWS_MIN_ENABLE = 1;

        /// QUOTA_LIMITS_HARDWS_MIN_DISABLE -> 0x00000002
        public const int QUOTA_LIMITS_HARDWS_MIN_DISABLE = 2;

        /// QUOTA_LIMITS_HARDWS_MAX_ENABLE -> 0x00000004
        public const int QUOTA_LIMITS_HARDWS_MAX_ENABLE = 4;

        /// QUOTA_LIMITS_HARDWS_MAX_DISABLE -> 0x00000008
        public const int QUOTA_LIMITS_HARDWS_MAX_DISABLE = 8;

        /// QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX -> (0x00000004)
        public const int QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX = 4;

        /// QUERY_ACTCTX_FLAG_NO_ADDREF -> (0x80000000)
        public const int QUERY_ACTCTX_FLAG_NO_ADDREF = -2147483648;

        /// QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE -> (0x00000008)
        public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE = 8;

        /// QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS -> (0x00000010)
        public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS = 16;

        /// QueryServiceLockStatus -> QueryServiceLockStatusW
        /// Error generating expression: Value QueryServiceLockStatusW is not resolved
        public const string QueryServiceLockStatus = "QueryServiceLockStatusW";

        /// QueryServiceConfig2 -> QueryServiceConfig2W
        /// Error generating expression: Value QueryServiceConfig2W is not resolved
        public const string QueryServiceConfig2 = "QueryServiceConfig2W";

        /// QueryServiceConfig -> QueryServiceConfigW
        /// Error generating expression: Value QueryServiceConfigW is not resolved
        public const string QueryServiceConfig = "QueryServiceConfigW";

        /// QUERYROPSUPPORT -> 40
        public const int QUERYROPSUPPORT = 40;

        /// QUERYESCSUPPORT -> 8
        public const int QUERYESCSUPPORT = 8;

        /// QueryDosDevice -> QueryDosDeviceW
        /// Error generating expression: Value QueryDosDeviceW is not resolved
        public const string QueryDosDevice = "QueryDosDeviceW";

        /// QUERYDIBSUPPORT -> 3073
        public const int QUERYDIBSUPPORT = 3073;

        /// QS_TIMER -> 0x0010
        public const int QS_TIMER = 16;

        /// QS_SENDMESSAGE -> 0x0040
        public const int QS_SENDMESSAGE = 64;

        /// QS_RAWINPUT -> 0x0400
        public const int QS_RAWINPUT = 1024;

        /// QS_POSTMESSAGE -> 0x0008
        public const int QS_POSTMESSAGE = 8;

        /// QS_PAINT -> 0x0020
        public const int QS_PAINT = 32;

        /// QS_MOUSEMOVE -> 0x0002
        public const int QS_MOUSEMOVE = 2;

        /// QS_MOUSEBUTTON -> 0x0004
        public const int QS_MOUSEBUTTON = 4;

        /// QS_MOUSE -> (QS_MOUSEMOVE     |                             QS_MOUSEBUTTON)
        public const int QS_MOUSE = (NativeConstants.QS_MOUSEMOVE | NativeConstants.QS_MOUSEBUTTON);

        /// QS_KEY -> 0x0001
        public const int QS_KEY = 1;

        /// QS_INPUT -> (QS_MOUSE         |                             QS_KEY           |                             QS_RAWINPUT)
        public const int QS_INPUT = (NativeConstants.QS_MOUSE
                    | (NativeConstants.QS_KEY | NativeConstants.QS_RAWINPUT));

        /// QS_HOTKEY -> 0x0080
        public const int QS_HOTKEY = 128;

        /// QS_ALLPOSTMESSAGE -> 0x0100
        public const int QS_ALLPOSTMESSAGE = 256;

        /// QS_ALLINPUT -> (QS_INPUT         |                             QS_POSTMESSAGE   |                             QS_TIMER         |                             QS_PAINT         |                             QS_HOTKEY        |                             QS_SENDMESSAGE)
        public const int QS_ALLINPUT = (NativeConstants.QS_INPUT
                    | (NativeConstants.QS_POSTMESSAGE
                    | (NativeConstants.QS_TIMER
                    | (NativeConstants.QS_PAINT
                    | (NativeConstants.QS_HOTKEY | NativeConstants.QS_SENDMESSAGE)))));

        /// QS_ALLEVENTS -> (QS_INPUT         |                             QS_POSTMESSAGE   |                             QS_TIMER         |                             QS_PAINT         |                             QS_HOTKEY)
        public const int QS_ALLEVENTS = (NativeConstants.QS_INPUT
                    | (NativeConstants.QS_POSTMESSAGE
                    | (NativeConstants.QS_TIMER
                    | (NativeConstants.QS_PAINT | NativeConstants.QS_HOTKEY))));

        /// QID_SYNC -> 0xFFFFFFFF
        public const int QID_SYNC = -1;

        /// QDI_STRETCHDIB -> 8
        public const int QDI_STRETCHDIB = 8;

        /// QDI_SETDIBITS -> 1
        public const int QDI_SETDIBITS = 1;

        /// QDI_GETDIBITS -> 2
        public const int QDI_GETDIBITS = 2;

        /// QDI_DIBTOSCREEN -> 4
        public const int QDI_DIBTOSCREEN = 4;
    }

}
