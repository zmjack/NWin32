using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// KP_Y -> 15
        public const int KP_Y = 15;

        /// KP_X -> 14
        public const int KP_X = 14;

        /// KP_VERIFY_PARAMS -> 40
        public const int KP_VERIFY_PARAMS = 40;

        /// KP_SIGNATURE_PIN -> 33
        public const int KP_SIGNATURE_PIN = 33;

        /// KP_SERVER_RANDOM -> 22
        public const int KP_SERVER_RANDOM = 22;

        /// KP_SCHANNEL_ALG -> 20
        public const int KP_SCHANNEL_ALG = 20;

        /// KP_SALT_EX -> 10
        public const int KP_SALT_EX = 10;

        /// KP_SALT -> 2
        public const int KP_SALT = 2;

        /// KP_RP -> 23
        public const int KP_RP = 23;

        /// KP_ROUNDS -> 35
        public const int KP_ROUNDS = 35;

        /// KP_RB -> 17
        public const int KP_RB = 17;

        /// KP_RA -> 16
        public const int KP_RA = 16;

        /// KP_Q -> 13
        public const int KP_Q = 13;

        /// KP_PUB_PARAMS -> 39
        public const int KP_PUB_PARAMS = 39;

        /// KP_PUB_EX_VAL -> 29
        public const int KP_PUB_EX_VAL = 29;

        /// KP_PUB_EX_LEN -> 28
        public const int KP_PUB_EX_LEN = 28;

        /// KP_PREHASH -> 34
        public const int KP_PREHASH = 34;

        /// KP_PRECOMP_SHA -> 25
        public const int KP_PRECOMP_SHA = 25;

        /// KP_PRECOMP_MD5 -> 24
        public const int KP_PRECOMP_MD5 = 24;

        /// KP_PERMISSIONS -> 6
        public const int KP_PERMISSIONS = 6;

        /// KP_PADDING -> 3
        public const int KP_PADDING = 3;

        /// KP_P -> 11
        public const int KP_P = 11;

        /// KP_OAEP_PARAMS -> 36
        public const int KP_OAEP_PARAMS = 36;

        /// KP_MODE_BITS -> 5
        public const int KP_MODE_BITS = 5;

        /// KP_MODE -> 4
        public const int KP_MODE = 4;

        /// KP_KEYVAL -> 30
        public const int KP_KEYVAL = 30;

        /// KP_KEYLEN -> 9
        public const int KP_KEYLEN = 9;

        /// KP_KEYEXCHANGE_PIN -> 32
        public const int KP_KEYEXCHANGE_PIN = 32;

        /// KP_IV -> 1
        public const int KP_IV = 1;

        /// KP_INFO -> 18
        public const int KP_INFO = 18;

        /// KP_HIGHEST_VERSION -> 41
        public const int KP_HIGHEST_VERSION = 41;

        /// KP_GET_USE_COUNT -> 42
        public const int KP_GET_USE_COUNT = 42;

        /// KP_G -> 12
        public const int KP_G = 12;

        /// KP_EFFECTIVE_KEYLEN -> 19
        public const int KP_EFFECTIVE_KEYLEN = 19;

        /// KP_CMS_KEY_INFO -> 37
        public const int KP_CMS_KEY_INFO = 37;

        /// KP_CMS_DH_KEY_INFO -> 38
        public const int KP_CMS_DH_KEY_INFO = 38;

        /// KP_CLIENT_RANDOM -> 21
        public const int KP_CLIENT_RANDOM = 21;

        /// KP_CLEAR_KEY -> 27
        public const int KP_CLEAR_KEY = 27;

        /// KP_CERTIFICATE -> 26
        public const int KP_CERTIFICATE = 26;

        /// KP_BLOCKLEN -> 8
        public const int KP_BLOCKLEN = 8;

        /// KP_ALGID -> 7
        public const int KP_ALGID = 7;

        /// KP_ADMIN_PIN -> 31
        public const int KP_ADMIN_PIN = 31;

        /// KL_NAMELENGTH -> 9
        public const int KL_NAMELENGTH = 9;

        /// KLF_SUBSTITUTE_OK -> 0x00000002
        public const int KLF_SUBSTITUTE_OK = 2;

        /// KLF_SHIFTLOCK -> 0x00010000
        public const int KLF_SHIFTLOCK = 65536;

        /// KLF_SETFORPROCESS -> 0x00000100
        public const int KLF_SETFORPROCESS = 256;

        /// KLF_RESET -> 0x40000000
        public const int KLF_RESET = 1073741824;

        /// KLF_REPLACELANG -> 0x00000010
        public const int KLF_REPLACELANG = 16;

        /// KLF_REORDER -> 0x00000008
        public const int KLF_REORDER = 8;

        /// KLF_NOTELLSHELL -> 0x00000080
        public const int KLF_NOTELLSHELL = 128;

        /// KLF_ACTIVATE -> 0x00000001
        public const int KLF_ACTIVATE = 1;

        /// KF_UP -> 0x8000
        public const int KF_UP = 32768;

        /// KF_REPEAT -> 0x4000
        public const int KF_REPEAT = 16384;

        /// KF_MENUMODE -> 0x1000
        public const int KF_MENUMODE = 4096;

        /// KF_EXTENDED -> 0x0100
        public const int KF_EXTENDED = 256;

        /// KF_DLGMODE -> 0x0800
        public const int KF_DLGMODE = 2048;

        /// KF_ALTDOWN -> 0x2000
        public const int KF_ALTDOWN = 8192;

        /// KEY_WOW64_RES -> (0x0300)
        public const int KEY_WOW64_RES = 768;

        /// KEY_WOW64_64KEY -> (0x0100)
        public const int KEY_WOW64_64KEY = 256;

        /// KEY_WOW64_32KEY -> (0x0200)
        public const int KEY_WOW64_32KEY = 512;

        /// KEY_SET_VALUE -> (0x0002)
        public const int KEY_SET_VALUE = 2;

        /// KEY_QUERY_VALUE -> (0x0001)
        public const int KEY_QUERY_VALUE = 1;

        /// KEY_NOTIFY -> (0x0010)
        public const int KEY_NOTIFY = 16;

        /// KEY_LENGTH_MASK -> 0xFFFF0000
        public const int KEY_LENGTH_MASK = -65536;

        /// KEY_EVENT -> 0x0001
        public const int KEY_EVENT = 1;

        /// KEY_ENUMERATE_SUB_KEYS -> (0x0008)
        public const int KEY_ENUMERATE_SUB_KEYS = 8;

        /// KEY_CREATE_SUB_KEY -> (0x0004)
        public const int KEY_CREATE_SUB_KEY = 4;

        /// KEY_CREATE_LINK -> (0x0020)
        public const int KEY_CREATE_LINK = 32;

        /// KEYSTATEBLOB -> 0xC
        public const int KEYSTATEBLOB = 12;

        /// KEYEVENTF_UNICODE -> 0x0004
        public const int KEYEVENTF_UNICODE = 4;

        /// KEYEVENTF_SCANCODE -> 0x0008
        public const int KEYEVENTF_SCANCODE = 8;

        /// KEYEVENTF_KEYUP -> 0x0002
        public const int KEYEVENTF_KEYUP = 2;

        /// KEYEVENTF_EXTENDEDKEY -> 0x0001
        public const int KEYEVENTF_EXTENDEDKEY = 1;

        /// KEYBOARD_OVERRUN_MAKE_CODE -> 0xFF
        public const int KEYBOARD_OVERRUN_MAKE_CODE = 255;
    }

}
