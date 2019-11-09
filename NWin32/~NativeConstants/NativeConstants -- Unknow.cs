using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// Warning: Generation of Method Macros is not supported at this time
        /// RtlZeroMemory -> "(Destination,Length) memset((Destination),0,(Length))"
        public const string RtlZeroMemory = "(Destination,Length) memset((Destination),0,(Length))";

        /// DECLSPEC_IMPORT -> 
        /// Error generating expression: 值不能为空。
        ///参数名: node
        public const string DECLSPEC_IMPORT = "";

        /// NULL -> ((void *)0)
        /// Error generating expression: Expression is not parsable.  Treating value as a raw string
        public const string NULL = "((void *)0)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// RtlCopyMemory -> "(Destination,Source,Length) memcpy((Destination),(Source),(Length))"
        public const string RtlCopyMemory = "(Destination,Source,Length) memcpy((Destination),(Source),(Length))";

        /// RT_VERSION -> MAKEINTRESOURCE(16)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string RT_VERSION = "MAKEINTRESOURCE(16)";

        /// MK_S_ASYNCHRONOUS -> _HRESULT_TYPEDEF_(0x000401E8L)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string MK_S_ASYNCHRONOUS = "_HRESULT_TYPEDEF_(0x000401E8L)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _crt_va_start -> "(ap,v) ( ap = (va_list)_ADDRESSOF(v) + _INTSIZEOF(v) )"
        public const string _crt_va_start = "(ap,v) ( ap = (va_list)_ADDRESSOF(v) + _INTSIZEOF(v) )";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _crt_va_end -> "(ap) ( ap = (va_list)0 )"
        public const string _crt_va_end = "(ap) ( ap = (va_list)0 )";

        /// Warning: Generation of Method Macros is not supported at this time
        /// _crt_va_arg -> "(ap,t) ( *(t *)((ap += _INTSIZEOF(t)) - _INTSIZEOF(t)) )"
        public const string _crt_va_arg = "(ap,t) ( *(t *)((ap += _INTSIZEOF(t)) - _INTSIZEOF(t)) )";

        /// VIEW_E_DRAW -> _HRESULT_TYPEDEF_(0x80040140L)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string VIEW_E_DRAW = "_HRESULT_TYPEDEF_(0x80040140L)";
        
        /// STATUS_WAIT_0 -> ((DWORD   )0x00000000L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_WAIT_0 = "((DWORD   )0x00000000L)";

        /// STATUS_USER_APC -> ((DWORD   )0x000000C0L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_USER_APC = "((DWORD   )0x000000C0L)";

        /// STATUS_ABANDONED_WAIT_0 -> ((DWORD   )0x00000080L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_ABANDONED_WAIT_0 = "((DWORD   )0x00000080L)";

        /// STATUS_STACK_OVERFLOW -> ((DWORD   )0xC00000FDL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_STACK_OVERFLOW = "((DWORD   )0xC00000FDL)";

        /// STATUS_SINGLE_STEP -> ((DWORD   )0x80000004L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_SINGLE_STEP = "((DWORD   )0x80000004L)";

        /// STATUS_PRIVILEGED_INSTRUCTION -> ((DWORD   )0xC0000096L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_PRIVILEGED_INSTRUCTION = "((DWORD   )0xC0000096L)";

        /// STATUS_NONCONTINUABLE_EXCEPTION -> ((DWORD   )0xC0000025L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_NONCONTINUABLE_EXCEPTION = "((DWORD   )0xC0000025L)";
        
        /// STATUS_IN_PAGE_ERROR -> ((DWORD   )0xC0000006L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_IN_PAGE_ERROR = "((DWORD   )0xC0000006L)";
        
        /// STATUS_INVALID_HANDLE -> ((DWORD   )0xC0000008L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_INVALID_HANDLE = "((DWORD   )0xC0000008L)";

        /// STATUS_INVALID_DISPOSITION -> ((DWORD   )0xC0000026L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_INVALID_DISPOSITION = "((DWORD   )0xC0000026L)";

        /// STATUS_INTEGER_OVERFLOW -> ((DWORD   )0xC0000095L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_INTEGER_OVERFLOW = "((DWORD   )0xC0000095L)";


        /// STATUS_INTEGER_DIVIDE_BY_ZERO -> ((DWORD   )0xC0000094L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_INTEGER_DIVIDE_BY_ZERO = "((DWORD   )0xC0000094L)";

        /// STATUS_ILLEGAL_INSTRUCTION -> ((DWORD   )0xC000001DL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_ILLEGAL_INSTRUCTION = "((DWORD   )0xC000001DL)";

        /// STATUS_GUARD_PAGE_VIOLATION -> ((DWORD   )0x80000001L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_GUARD_PAGE_VIOLATION = "((DWORD   )0x80000001L)";

        /// STATUS_FLOAT_UNDERFLOW -> ((DWORD   )0xC0000093L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_FLOAT_UNDERFLOW = "((DWORD   )0xC0000093L)";

        /// STATUS_FLOAT_STACK_CHECK -> ((DWORD   )0xC0000092L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_FLOAT_STACK_CHECK = "((DWORD   )0xC0000092L)";

        /// STATUS_FLOAT_OVERFLOW -> ((DWORD   )0xC0000091L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_FLOAT_OVERFLOW = "((DWORD   )0xC0000091L)";

        /// STATUS_FLOAT_INVALID_OPERATION -> ((DWORD   )0xC0000090L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_FLOAT_INVALID_OPERATION = "((DWORD   )0xC0000090L)";

        /// STATUS_FLOAT_INEXACT_RESULT -> ((DWORD   )0xC000008FL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_FLOAT_INEXACT_RESULT = "((DWORD   )0xC000008FL)";

        /// STATUS_FLOAT_DIVIDE_BY_ZERO -> ((DWORD   )0xC000008EL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_FLOAT_DIVIDE_BY_ZERO = "((DWORD   )0xC000008EL)";

        /// STATUS_FLOAT_DENORMAL_OPERAND -> ((DWORD   )0xC000008DL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_FLOAT_DENORMAL_OPERAND = "((DWORD   )0xC000008DL)";

        /// STATUS_DATATYPE_MISALIGNMENT -> ((DWORD   )0x80000002L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_DATATYPE_MISALIGNMENT = "((DWORD   )0x80000002L)";

        /// STATUS_CONTROL_C_EXIT -> ((DWORD   )0xC000013AL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_CONTROL_C_EXIT = "((DWORD   )0xC000013AL)";

        /// STATUS_BREAKPOINT -> ((DWORD   )0x80000003L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_BREAKPOINT = "((DWORD   )0x80000003L)";

        /// STATUS_ARRAY_BOUNDS_EXCEEDED -> ((DWORD   )0xC000008CL)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_ARRAY_BOUNDS_EXCEEDED = "((DWORD   )0xC000008CL)";

        /// STATUS_ACCESS_VIOLATION -> ((DWORD   )0xC0000005L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_ACCESS_VIOLATION = "((DWORD   )0xC0000005L)";

        /// Warning: Generation of Method Macros is not supported at this time
        /// RtlMoveMemory -> "(Destination,Source,Length) memmove((Destination),(Source),(Length))"
        public const string RtlMoveMemory = "(Destination,Source,Length) memmove((Destination),(Source),(Length))";

        /// Warning: Generation of Method Macros is not supported at this time
        /// RtlFillMemory -> "(Destination,Length,Fill) memset((Destination),(Fill),(Length))"
        public const string RtlFillMemory = "(Destination,Length,Fill) memset((Destination),(Fill),(Length))";

        /// POINTER_32 -> 
        /// Error generating expression: 值不能为空。
        ///参数名: node
        public const string POINTER_32 = "";

    }
}
