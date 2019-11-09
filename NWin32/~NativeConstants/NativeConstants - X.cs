using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// XTYP_XACT_COMPLETE -> (0x0080 | XCLASS_NOTIFICATION  )
        public const int XTYP_XACT_COMPLETE = (128 | NativeConstants.XCLASS_NOTIFICATION);

        /// XTYP_WILDCONNECT -> (0x00E0 | XCLASS_DATA | XTYPF_NOBLOCK)
        public const int XTYP_WILDCONNECT = (224
                    | (NativeConstants.XCLASS_DATA | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_UNREGISTER -> (0x00D0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK)
        public const int XTYP_UNREGISTER = (208
                    | (NativeConstants.XCLASS_NOTIFICATION | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_SHIFT -> 4
        public const int XTYP_SHIFT = 4;

        /// XTYP_REQUEST -> (0x00B0 | XCLASS_DATA          )
        public const int XTYP_REQUEST = (176 | NativeConstants.XCLASS_DATA);

        /// XTYP_REGISTER -> (0x00A0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK)
        public const int XTYP_REGISTER = (160
                    | (NativeConstants.XCLASS_NOTIFICATION | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_POKE -> (0x0090 | XCLASS_FLAGS         )
        public const int XTYP_POKE = (144 | NativeConstants.XCLASS_FLAGS);

        /// XTYP_MONITOR -> (0x00F0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK)
        public const int XTYP_MONITOR = (240
                    | (NativeConstants.XCLASS_NOTIFICATION | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_MASK -> 0x00F0
        public const int XTYP_MASK = 240;

        /// XTYP_EXECUTE -> (0x0050 | XCLASS_FLAGS         )
        public const int XTYP_EXECUTE = (80 | NativeConstants.XCLASS_FLAGS);

        /// XTYP_ERROR -> (0x0000 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK )
        public const int XTYP_ERROR = (0
                    | (NativeConstants.XCLASS_NOTIFICATION | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_DISCONNECT -> (0x00C0 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK)
        public const int XTYP_DISCONNECT = (192
                    | (NativeConstants.XCLASS_NOTIFICATION | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_CONNECT_CONFIRM -> (0x0070 | XCLASS_NOTIFICATION | XTYPF_NOBLOCK)
        public const int XTYP_CONNECT_CONFIRM = (112
                    | (NativeConstants.XCLASS_NOTIFICATION | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_CONNECT -> (0x0060 | XCLASS_BOOL | XTYPF_NOBLOCK)
        public const int XTYP_CONNECT = (96
                    | (NativeConstants.XCLASS_BOOL | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_ADVSTOP -> (0x0040 | XCLASS_NOTIFICATION)
        public const int XTYP_ADVSTOP = (64 | NativeConstants.XCLASS_NOTIFICATION);

        /// XTYP_ADVSTART -> (0x0030 | XCLASS_BOOL          )
        public const int XTYP_ADVSTART = (48 | NativeConstants.XCLASS_BOOL);

        /// XTYP_ADVREQ -> (0x0020 | XCLASS_DATA | XTYPF_NOBLOCK )
        public const int XTYP_ADVREQ = (32
                    | (NativeConstants.XCLASS_DATA | NativeConstants.XTYPF_NOBLOCK));

        /// XTYP_ADVDATA -> (0x0010 | XCLASS_FLAGS         )
        public const int XTYP_ADVDATA = (16 | NativeConstants.XCLASS_FLAGS);

        /// XTYPF_NODATA -> 0x0004
        public const int XTYPF_NODATA = 4;

        /// XTYPF_NOBLOCK -> 0x0002
        public const int XTYPF_NOBLOCK = 2;

        /// XTYPF_ACKREQ -> 0x0008
        public const int XTYPF_ACKREQ = 8;

        /// XST_UNADVSENT -> 12
        public const int XST_UNADVSENT = 12;

        /// XST_UNADVACKRCVD -> 14
        public const int XST_UNADVACKRCVD = 14;

        /// XST_REQSENT -> 5
        public const int XST_REQSENT = 5;

        /// XST_POKESENT -> 7
        public const int XST_POKESENT = 7;

        /// XST_POKEACKRCVD -> 8
        public const int XST_POKEACKRCVD = 8;

        /// XST_NULL -> 0
        public const int XST_NULL = 0;

        /// XST_INIT2 -> 4
        public const int XST_INIT2 = 4;

        /// XST_INIT1 -> 3
        public const int XST_INIT1 = 3;

        /// XST_INCOMPLETE -> 1
        public const int XST_INCOMPLETE = 1;

        /// XST_EXECSENT -> 9
        public const int XST_EXECSENT = 9;

        /// XST_EXECACKRCVD -> 10
        public const int XST_EXECACKRCVD = 10;

        /// XST_DATARCVD -> 6
        public const int XST_DATARCVD = 6;

        /// XST_CONNECTED -> 2
        public const int XST_CONNECTED = 2;

        /// XST_ADVSENT -> 11
        public const int XST_ADVSENT = 11;

        /// XST_ADVDATASENT -> 15
        public const int XST_ADVDATASENT = 15;

        /// XST_ADVDATAACKRCVD -> 16
        public const int XST_ADVDATAACKRCVD = 16;

        /// XST_ADVACKRCVD -> 13
        public const int XST_ADVACKRCVD = 13;

        /// XcvData -> XcvDataW
        /// Error generating expression: Value XcvDataW is not resolved
        public const string XcvData = "XcvDataW";

        /// XCLASS_NOTIFICATION -> 0x8000
        public const int XCLASS_NOTIFICATION = 32768;

        /// XCLASS_MASK -> 0xFC00
        public const int XCLASS_MASK = 64512;

        /// XCLASS_FLAGS -> 0x4000
        public const int XCLASS_FLAGS = 16384;

        /// XCLASS_DATA -> 0x2000
        public const int XCLASS_DATA = 8192;

        /// XCLASS_BOOL -> 0x1000
        public const int XCLASS_BOOL = 4096;

        /// XBUTTON2 -> 0x0002
        public const int XBUTTON2 = 2;

        /// XBUTTON1 -> 0x0001
        public const int XBUTTON1 = 1;

        /// XACT_S_LAST -> 0x0004D010
        public const int XACT_S_LAST = 315408;

        /// XACT_S_FIRST -> 0x0004D000
        public const int XACT_S_FIRST = 315392;

        /// XACT_E_LAST -> 0x8004D029
        public const int XACT_E_LAST = -2147168215;

        /// XACT_E_FIRST -> 0x8004D000
        public const int XACT_E_FIRST = -2147168256;

        /// X509_UNICODE_ANY_STRING -> X509_UNICODE_NAME_VALUE
        public const string X509_UNICODE_ANY_STRING = NativeConstants.X509_UNICODE_NAME_VALUE;

        /// X509_NDR_ENCODING -> 0x00000002
        public const int X509_NDR_ENCODING = 2;

        /// X509_DSS_PUBLICKEY -> X509_MULTI_BYTE_UINT
        public const string X509_DSS_PUBLICKEY = NativeConstants.X509_MULTI_BYTE_UINT;

        /// X509_DH_PUBLICKEY -> X509_MULTI_BYTE_UINT
        public const string X509_DH_PUBLICKEY = NativeConstants.X509_MULTI_BYTE_UINT;

        /// X509_CRL_REASON_CODE -> X509_ENUMERATED
        public const string X509_CRL_REASON_CODE = NativeConstants.X509_ENUMERATED;

        /// X509_ASN_ENCODING -> 0x00000001
        public const int X509_ASN_ENCODING = 1;

        /// X509_ANY_STRING -> X509_NAME_VALUE
        public const string X509_ANY_STRING = NativeConstants.X509_NAME_VALUE;

        /// X3_TMPLT_SIZE_X -> 4
        public const int X3_TMPLT_SIZE_X = 4;

        /// X3_TMPLT_SIGN_VAL_POS_X -> 0
        public const int X3_TMPLT_SIGN_VAL_POS_X = 0;

        /// X3_TMPLT_INST_WORD_X -> 0
        public const int X3_TMPLT_INST_WORD_X = 0;

        /// X3_TMPLT_INST_WORD_POS_X -> 0
        public const int X3_TMPLT_INST_WORD_POS_X = 0;

        /// X3_P_SIZE_X -> 4
        public const int X3_P_SIZE_X = 4;

        /// X3_P_SIGN_VAL_POS_X -> 0
        public const int X3_P_SIGN_VAL_POS_X = 0;

        /// X3_P_INST_WORD_X -> 3
        public const int X3_P_INST_WORD_X = 3;

        /// X3_P_INST_WORD_POS_X -> 0
        public const int X3_P_INST_WORD_POS_X = 0;

        /// X3_OPCODE_SIZE_X -> 4
        public const int X3_OPCODE_SIZE_X = 4;

        /// X3_OPCODE_SIGN_VAL_POS_X -> 0
        public const int X3_OPCODE_SIGN_VAL_POS_X = 0;

        /// X3_OPCODE_INST_WORD_X -> 3
        public const int X3_OPCODE_INST_WORD_X = 3;

        /// X3_OPCODE_INST_WORD_POS_X -> 28
        public const int X3_OPCODE_INST_WORD_POS_X = 28;

        /// X3_I_SIZE_X -> 1
        public const int X3_I_SIZE_X = 1;

        /// X3_I_SIGN_VAL_POS_X -> 59
        public const int X3_I_SIGN_VAL_POS_X = 59;

        /// X3_I_INST_WORD_X -> 3
        public const int X3_I_INST_WORD_X = 3;

        /// X3_I_INST_WORD_POS_X -> 27
        public const int X3_I_INST_WORD_POS_X = 27;

        /// X3_IMM39_2_SIZE_X -> 16
        public const int X3_IMM39_2_SIZE_X = 16;

        /// X3_IMM39_2_SIGN_VAL_POS_X -> 20
        public const int X3_IMM39_2_SIGN_VAL_POS_X = 20;

        /// X3_IMM39_2_INST_WORD_X -> 1
        public const int X3_IMM39_2_INST_WORD_X = 1;

        /// X3_IMM39_2_INST_WORD_POS_X -> 16
        public const int X3_IMM39_2_INST_WORD_POS_X = 16;

        /// X3_IMM39_1_SIZE_X -> 23
        public const int X3_IMM39_1_SIZE_X = 23;

        /// X3_IMM39_1_SIGN_VAL_POS_X -> 36
        public const int X3_IMM39_1_SIGN_VAL_POS_X = 36;

        /// X3_IMM39_1_INST_WORD_X -> 2
        public const int X3_IMM39_1_INST_WORD_X = 2;

        /// X3_IMM39_1_INST_WORD_POS_X -> 0
        public const int X3_IMM39_1_INST_WORD_POS_X = 0;

        /// X3_IMM20_SIZE_X -> 20
        public const int X3_IMM20_SIZE_X = 20;

        /// X3_IMM20_SIGN_VAL_POS_X -> 0
        public const int X3_IMM20_SIGN_VAL_POS_X = 0;

        /// X3_IMM20_INST_WORD_X -> 3
        public const int X3_IMM20_INST_WORD_X = 3;

        /// X3_IMM20_INST_WORD_POS_X -> 4
        public const int X3_IMM20_INST_WORD_POS_X = 4;

        /// X3_EMPTY_SIZE_X -> 2
        public const int X3_EMPTY_SIZE_X = 2;

        /// X3_EMPTY_INST_WORD_X -> 1
        public const int X3_EMPTY_INST_WORD_X = 1;

        /// X3_EMPTY_INST_WORD_POS_X -> 14
        public const int X3_EMPTY_INST_WORD_POS_X = 14;

        /// X3_EMPTY_INST_VAL_POS_X -> 0
        public const int X3_EMPTY_INST_VAL_POS_X = 0;

        /// X3_D_WH_SIZE_X -> 3
        public const int X3_D_WH_SIZE_X = 3;

        /// X3_D_WH_SIGN_VAL_POS_X -> 0
        public const int X3_D_WH_SIGN_VAL_POS_X = 0;

        /// X3_D_WH_INST_WORD_X -> 3
        public const int X3_D_WH_INST_WORD_X = 3;

        /// X3_D_WH_INST_WORD_POS_X -> 24
        public const int X3_D_WH_INST_WORD_POS_X = 24;

        /// X3_BTYPE_QP_SIZE_X -> 9
        public const int X3_BTYPE_QP_SIZE_X = 9;

        /// X3_BTYPE_QP_INST_WORD_X -> 2
        public const int X3_BTYPE_QP_INST_WORD_X = 2;

        /// X3_BTYPE_QP_INST_WORD_POS_X -> 23
        public const int X3_BTYPE_QP_INST_WORD_POS_X = 23;

        /// X3_BTYPE_QP_INST_VAL_POS_X -> 0
        public const int X3_BTYPE_QP_INST_VAL_POS_X = 0;

        /// X509_UNICODE_NAME_VALUE -> ((LPCSTR) 24)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string X509_UNICODE_NAME_VALUE = "((LPCSTR) 24)";

        /// X509_MULTI_BYTE_UINT -> ((LPCSTR) 38)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string X509_MULTI_BYTE_UINT = "((LPCSTR) 38)";

        /// X509_ENUMERATED -> ((LPCSTR) 29)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string X509_ENUMERATED = "((LPCSTR) 29)";

        /// X509_NAME_VALUE -> ((LPCSTR) 6)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string X509_NAME_VALUE = "((LPCSTR) 6)";
    }

}
