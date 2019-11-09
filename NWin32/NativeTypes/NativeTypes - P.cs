using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: LONG->int
    ///ExceptionInfo: _EXCEPTION_POINTERS*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PVECTORED_EXCEPTION_HANDLER(ref EXCEPTION_POINTERS ExceptionInfo);

    [StructLayout(LayoutKind.Sequential)]
    public struct pvalueW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pv_valuename;

        /// int
        public int pv_valuelen;

        /// LPVOID->void*
        public IntPtr pv_value_context;

        /// DWORD->unsigned int
        public uint pv_type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct pvalueA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pv_valuename;

        /// int
        public int pv_valuelen;

        /// LPVOID->void*
        public IntPtr pv_value_context;

        /// DWORD->unsigned int
        public uint pv_type;
    }

    /// Return Type: LONG->int
    ///ExceptionInfo: _EXCEPTION_POINTERS*
    public delegate int PTOP_LEVEL_EXCEPTION_FILTER([In] ref EXCEPTION_POINTERS ExceptionInfo);

    /// Return Type: void
    ///lpArgToCompletionRoutine: LPVOID->void*
    ///dwTimerLowValue: DWORD->unsigned int
    ///dwTimerHighValue: DWORD->unsigned int
    public delegate void PTIMERAPCROUTINE([In] IntPtr lpArgToCompletionRoutine, uint dwTimerLowValue, uint dwTimerHighValue);

    /// Return Type: DWORD->unsigned int
    ///lpThreadParameter: LPVOID->void*
    public delegate uint PTHREAD_START_ROUTINE(IntPtr lpThreadParameter);

    /// Return Type: void
    ///AssociationContext: void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PRPC_RUNDOWN(IntPtr AssociationContext);

    [StructLayout(LayoutKind.Sequential)]
    public struct provider_info
    {

        /// PQUERYHANDLER->QUERYHANDLER*
        public IntPtr pi_R0_1val;

        /// PQUERYHANDLER->QUERYHANDLER*
        public IntPtr pi_R0_allvals;

        /// PQUERYHANDLER->QUERYHANDLER*
        public IntPtr pi_R3_1val;

        /// PQUERYHANDLER->QUERYHANDLER*
        public IntPtr pi_R3_allvals;

        /// DWORD->unsigned int
        public uint pi_flags;

        /// LPVOID->void*
        public IntPtr pi_key_context;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct protoent
    {

        /// char*
        [MarshalAs(UnmanagedType.LPStr)]
        public string p_name;

        /// char**
        public IntPtr p_aliases;

        /// short
        public short p_proto;
    }

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPCWSTR->WCHAR*
    ///param2: HANDLE->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCW(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1, IntPtr param2);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPWSTR->WCHAR*
    ///param2: HANDLE->void*
    ///param3: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCEXW(IntPtr param0, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param1, IntPtr param2, uint param3);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPSTR->CHAR*
    ///param2: HANDLE->void*
    ///param3: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCEXA(IntPtr param0, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param1, IntPtr param2, uint param3);

    /// Return Type: BOOL->int
    ///param0: HWND->HWND__*
    ///param1: LPCSTR->CHAR*
    ///param2: HANDLE->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PROPENUMPROCA(IntPtr param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1, IntPtr param2);

    /// Return Type: int
    public delegate int PROC();

    /// Return Type: BOOLEAN->BYTE->unsigned char
    ///param0: LPCWSTR->WCHAR*
    public delegate byte PREGISTERCLASSNAMEW([In] [MarshalAs(UnmanagedType.LPWStr)] string param0);

    /// Return Type: BOOL->int
    ///dwFlags: DWORD->unsigned int
    ///hActCtx: HANDLE->void*
    ///pvSubInstance: PVOID->void*
    ///ulInfoClass: ULONG->unsigned int
    ///pvBuffer: PVOID->void*
    ///cbBuffer: SIZE_T->ULONG_PTR->unsigned int
    ///pcbWrittenOrRequired: SIZE_T*
    public delegate int PQUERYACTCTXW_FUNC(uint dwFlags, [In] IntPtr hActCtx, [In] IntPtr pvSubInstance, uint ulInfoClass, IntPtr pvBuffer, uint cbBuffer, IntPtr pcbWrittenOrRequired);

    /// Return Type: DWORD->unsigned int
    ///param0: LPDWORD->DWORD*
    ///param1: LPVOID*
    ///param2: LPDWORD->DWORD*
    ///param3: LPDWORD->DWORD*
    public delegate uint PM_QUERY_PROC(ref uint param0, ref IntPtr param1, ref uint param2, ref uint param3);

    /// Return Type: DWORD->unsigned int
    ///param0: LPWSTR->WCHAR*
    public delegate uint PM_OPEN_PROC([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0);

    /// Return Type: DWORD->unsigned int
    ///param0: LPWSTR->WCHAR*
    ///param1: LPVOID*
    ///param2: LPDWORD->DWORD*
    ///param3: LPDWORD->DWORD*
    public delegate uint PM_COLLECT_PROC([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, ref IntPtr param1, ref uint param2, ref uint param3);

    /// Return Type: DWORD->unsigned int
    public delegate uint PM_CLOSE_PROC();

    /// Return Type: void
    ///DllHandle: PVOID->void*
    ///Reason: DWORD->unsigned int
    ///Reserved: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PIMAGE_TLS_CALLBACK(IntPtr DllHandle, uint Reason, IntPtr Reserved);

    public enum PIDMSI_STATUS_VALUE
    {

        /// PIDMSI_STATUS_NORMAL -> 0
        PIDMSI_STATUS_NORMAL = 0,

        /// PIDMSI_STATUS_NEW -> PIDMSI_STATUS_NORMAL+1
        PIDMSI_STATUS_NEW = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_NORMAL + 1),

        /// PIDMSI_STATUS_PRELIM -> PIDMSI_STATUS_NEW+1
        PIDMSI_STATUS_PRELIM = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_NEW + 1),

        /// PIDMSI_STATUS_DRAFT -> PIDMSI_STATUS_PRELIM+1
        PIDMSI_STATUS_DRAFT = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_PRELIM + 1),

        /// PIDMSI_STATUS_INPROGRESS -> PIDMSI_STATUS_DRAFT+1
        PIDMSI_STATUS_INPROGRESS = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_DRAFT + 1),

        /// PIDMSI_STATUS_EDIT -> PIDMSI_STATUS_INPROGRESS+1
        PIDMSI_STATUS_EDIT = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_INPROGRESS + 1),

        /// PIDMSI_STATUS_REVIEW -> PIDMSI_STATUS_EDIT+1
        PIDMSI_STATUS_REVIEW = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_EDIT + 1),

        /// PIDMSI_STATUS_PROOF -> PIDMSI_STATUS_REVIEW+1
        PIDMSI_STATUS_PROOF = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_REVIEW + 1),

        /// PIDMSI_STATUS_FINAL -> PIDMSI_STATUS_PROOF+1
        PIDMSI_STATUS_FINAL = (PIDMSI_STATUS_VALUE.PIDMSI_STATUS_PROOF + 1),

        /// PIDMSI_STATUS_OTHER -> 0x7fff
        PIDMSI_STATUS_OTHER = 32767,
    }

    /// Return Type: BOOL->int
    ///CtrlType: DWORD->unsigned int
    public delegate int PHANDLER_ROUTINE(uint CtrlType);

    /// Return Type: UINT->unsigned int
    ///lpBuffer: LPWSTR->WCHAR*
    ///uSize: UINT->unsigned int
    public delegate uint PGET_SYSTEM_WOW64_DIRECTORY_W([Out] [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpBuffer, uint uSize);

    /// Return Type: UINT->unsigned int
    ///lpBuffer: LPSTR->CHAR*
    ///uSize: UINT->unsigned int
    public delegate uint PGET_SYSTEM_WOW64_DIRECTORY_A([Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpBuffer, uint uSize);

    /// Return Type: BOOL->int
    ///dwFlags: DWORD->unsigned int
    ///lpModuleName: LPCWSTR->WCHAR*
    ///phModule: HMODULE*
    public delegate int PGET_MODULE_HANDLE_EXW(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpModuleName, out IntPtr phModule);

    /// Return Type: BOOL->int
    ///dwFlags: DWORD->unsigned int
    ///lpModuleName: LPCSTR->CHAR*
    ///phModule: HMODULE*
    public delegate int PGET_MODULE_HANDLE_EXA(uint dwFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpModuleName, out IntPtr phModule);

    /// Return Type: BOOL->int
    ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
    ///pPrivateKeyInfo: CRYPT_PRIVATE_KEY_INFO*
    ///dwFlags: DWORD->unsigned int
    ///pvAuxInfo: void*
    public delegate int PFN_IMPORT_PRIV_KEY_FUNC(uint hCryptProv, ref CRYPT_PRIVATE_KEY_INFO pPrivateKeyInfo, uint dwFlags, IntPtr pvAuxInfo);

    /// Return Type: void
    ///pszObjectOid: LPCSTR->CHAR*
    ///pObject: PCRYPT_BLOB_ARRAY->_CRYPT_BLOB_ARRAY*
    ///pvFreeContext: LPVOID->void*
    public delegate void PFN_FREE_ENCODED_OBJECT_FUNC([In] [MarshalAs(UnmanagedType.LPStr)] string pszObjectOid, ref CRYPT_BLOB_ARRAY pObject, IntPtr pvFreeContext);

    /// Return Type: BOOL->int
    ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
    ///dwKeySpec: DWORD->unsigned int
    ///pszPrivateKeyObjId: LPSTR->CHAR*
    ///dwFlags: DWORD->unsigned int
    ///pvAuxInfo: void*
    ///pPrivateKeyInfo: CRYPT_PRIVATE_KEY_INFO*
    ///pcbPrivateKeyBlob: DWORD*
    public delegate int PFN_EXPORT_PRIV_KEY_FUNC(uint hCryptProv, uint dwKeySpec, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszPrivateKeyObjId, uint dwFlags, IntPtr pvAuxInfo, ref CRYPT_PRIVATE_KEY_INFO pPrivateKeyInfo, ref uint pcbPrivateKeyBlob);

    /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
    ///pvGetArg: void*
    ///dwCertEncodingType: DWORD->unsigned int
    ///pSignerId: PCERT_INFO->_CERT_INFO*
    ///hMsgCertStore: HCERTSTORE->void*
    public delegate IntPtr PFN_CRYPT_GET_SIGNER_CERTIFICATE(IntPtr pvGetArg, uint dwCertEncodingType, ref CERT_INFO pSignerId, IntPtr hMsgCertStore);

    /// Return Type: void
    ///pv: LPVOID->void*
    public delegate void PFN_CRYPT_FREE(IntPtr pv);

    /// Return Type: BOOL->int
    ///pInfo: PCCRYPT_OID_INFO->CRYPT_OID_INFO*
    ///pvArg: void*
    public delegate int PFN_CRYPT_ENUM_OID_INFO(ref CRYPT_OID_INFO pInfo, IntPtr pvArg);

    /// Return Type: BOOL->int
    ///dwEncodingType: DWORD->unsigned int
    ///pszFuncName: LPCSTR->CHAR*
    ///pszOID: LPCSTR->CHAR*
    ///cValue: DWORD->unsigned int
    ///rgdwValueType: DWORD*
    ///rgpwszValueName: LPCWSTR*
    ///rgpbValueData: BYTE**
    ///rgcbValueData: DWORD*
    ///pvArg: void*
    public delegate int PFN_CRYPT_ENUM_OID_FUNC(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOID, uint cValue, ref uint rgdwValueType, ref IntPtr rgpwszValueName, ref IntPtr rgpbValueData, ref uint rgcbValueData, IntPtr pvArg);

    /// Return Type: BOOL->int
    ///pKeyIdentifier: CRYPT_HASH_BLOB*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    ///pvArg: void*
    ///cProp: DWORD->unsigned int
    ///rgdwPropId: DWORD*
    ///rgpvData: void**
    ///rgcbData: DWORD*
    public delegate int PFN_CRYPT_ENUM_KEYID_PROP(ref CRYPT_ATTR_BLOB pKeyIdentifier, uint dwFlags, IntPtr pvReserved, IntPtr pvArg, uint cProp, ref uint rgdwPropId, ref IntPtr rgpvData, ref uint rgcbData);

    /// Return Type: BOOL->int
    ///dwFlags: DWORD->unsigned int
    ///pvArg: void*
    public delegate int PFN_CRYPT_CANCEL_RETRIEVAL(uint dwFlags, IntPtr pvArg);

    /// Return Type: void
    ///pvCompletion: LPVOID->void*
    ///dwCompletionCode: DWORD->unsigned int
    ///pszUrl: LPCSTR->CHAR*
    ///pszObjectOid: LPSTR->CHAR*
    ///pvObject: LPVOID->void*
    public delegate void PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC(IntPtr pvCompletion, uint dwCompletionCode, [In] [MarshalAs(UnmanagedType.LPStr)] string pszUrl, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszObjectOid, IntPtr pvObject);

    /// Return Type: void
    ///pszParamOid: LPSTR->CHAR*
    ///pvParam: LPVOID->void*
    public delegate void PFN_CRYPT_ASYNC_PARAM_FREE_FUNC([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszParamOid, IntPtr pvParam);

    /// Return Type: LPVOID->void*
    ///cbSize: size_t->unsigned int
    public delegate IntPtr PFN_CRYPT_ALLOC(IntPtr cbSize);

    /// Return Type: BOOL->int
    ///pvArg: void*
    ///pbData: BYTE*
    ///cbData: DWORD->unsigned int
    ///fFinal: BOOL->int
    public delegate int PFN_CMSG_STREAM_OUTPUT(IntPtr pvArg, ref byte pbData, uint cbData, [MarshalAs(UnmanagedType.Bool)] bool fFinal);

    /// Return Type: BOOL->int
    ///pContentEncryptionAlgorithm: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
    ///pMailListDecryptPara: PCMSG_CTRL_MAIL_LIST_DECRYPT_PARA->_CMSG_CTRL_MAIL_LIST_DECRYPT_PARA*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    ///phContentEncryptKey: HCRYPTKEY*
    public delegate int PFN_CMSG_IMPORT_MAIL_LIST(ref CRYPT_ALGORITHM_IDENTIFIER pContentEncryptionAlgorithm, ref CMSG_CTRL_MAIL_LIST_DECRYPT_PARA pMailListDecryptPara, uint dwFlags, IntPtr pvReserved, ref uint phContentEncryptKey);

    /// Return Type: BOOL->int
    ///pContentEncryptionAlgorithm: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
    ///pKeyTransDecryptPara: PCMSG_CTRL_KEY_TRANS_DECRYPT_PARA->_CMSG_CTRL_KEY_TRANS_DECRYPT_PARA*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    ///phContentEncryptKey: HCRYPTKEY*
    public delegate int PFN_CMSG_IMPORT_KEY_TRANS(ref CRYPT_ALGORITHM_IDENTIFIER pContentEncryptionAlgorithm, ref CMSG_CTRL_KEY_TRANS_DECRYPT_PARA pKeyTransDecryptPara, uint dwFlags, IntPtr pvReserved, ref uint phContentEncryptKey);

    /// Return Type: BOOL->int
    ///pContentEncryptionAlgorithm: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
    ///pKeyAgreeDecryptPara: PCMSG_CTRL_KEY_AGREE_DECRYPT_PARA->_CMSG_CTRL_KEY_AGREE_DECRYPT_PARA*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    ///phContentEncryptKey: HCRYPTKEY*
    public delegate int PFN_CMSG_IMPORT_KEY_AGREE(ref CRYPT_ALGORITHM_IDENTIFIER pContentEncryptionAlgorithm, ref CMSG_CTRL_KEY_AGREE_DECRYPT_PARA pKeyAgreeDecryptPara, uint dwFlags, IntPtr pvReserved, ref uint phContentEncryptKey);

    /// Return Type: BOOL->int
    ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
    ///dwKeySpec: DWORD->unsigned int
    ///paiEncrypt: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
    ///paiPubKey: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
    ///pbEncodedKey: PBYTE->BYTE*
    ///cbEncodedKey: DWORD->unsigned int
    ///phEncryptKey: HCRYPTKEY*
    public delegate int PFN_CMSG_IMPORT_ENCRYPT_KEY(uint hCryptProv, uint dwKeySpec, ref CRYPT_ALGORITHM_IDENTIFIER paiEncrypt, ref CRYPT_ALGORITHM_IDENTIFIER paiPubKey, ref byte pbEncodedKey, uint cbEncodedKey, ref uint phEncryptKey);

    /// Return Type: BOOL->int
    ///phCryptProv: HCRYPTPROV*
    ///paiEncrypt: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
    ///pvEncryptAuxInfo: PVOID->void*
    ///pPublicKeyInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
    ///pfnAlloc: PFN_CMSG_ALLOC
    ///phEncryptKey: HCRYPTKEY*
    ///ppbEncryptParameters: PBYTE*
    ///pcbEncryptParameters: PDWORD->DWORD*
    public delegate int PFN_CMSG_GEN_ENCRYPT_KEY(ref uint phCryptProv, ref CRYPT_ALGORITHM_IDENTIFIER paiEncrypt, IntPtr pvEncryptAuxInfo, ref CERT_PUBLIC_KEY_INFO pPublicKeyInfo, PFN_CMSG_ALLOC pfnAlloc, ref uint phEncryptKey, ref IntPtr ppbEncryptParameters, ref uint pcbEncryptParameters);

    /// Return Type: BOOL->int
    ///pContentEncryptInfo: PCMSG_CONTENT_ENCRYPT_INFO->_CMSG_CONTENT_ENCRYPT_INFO*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    public delegate int PFN_CMSG_GEN_CONTENT_ENCRYPT_KEY(ref CMSG_CONTENT_ENCRYPT_INFO pContentEncryptInfo, uint dwFlags, IntPtr pvReserved);

    /// Return Type: void
    ///pv: void*
    public delegate void PFN_CMSG_FREE(IntPtr pv);

    /// Return Type: BOOL->int
    ///pContentEncryptInfo: PCMSG_CONTENT_ENCRYPT_INFO->_CMSG_CONTENT_ENCRYPT_INFO*
    ///pMailListEncodeInfo: PCMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO->_CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO*
    ///pMailListEncryptInfo: PCMSG_MAIL_LIST_ENCRYPT_INFO->_CMSG_MAIL_LIST_ENCRYPT_INFO*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    public delegate int PFN_CMSG_EXPORT_MAIL_LIST(ref CMSG_CONTENT_ENCRYPT_INFO pContentEncryptInfo, ref CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO pMailListEncodeInfo, ref CMSG_MAIL_LIST_ENCRYPT_INFO pMailListEncryptInfo, uint dwFlags, IntPtr pvReserved);

    /// Return Type: BOOL->int
    ///pContentEncryptInfo: PCMSG_CONTENT_ENCRYPT_INFO->_CMSG_CONTENT_ENCRYPT_INFO*
    ///pKeyTransEncodeInfo: PCMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO->_CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO*
    ///pKeyTransEncryptInfo: PCMSG_KEY_TRANS_ENCRYPT_INFO->_CMSG_KEY_TRANS_ENCRYPT_INFO*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    public delegate int PFN_CMSG_EXPORT_KEY_TRANS(ref CMSG_CONTENT_ENCRYPT_INFO pContentEncryptInfo, ref CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO pKeyTransEncodeInfo, ref CMSG_KEY_TRANS_ENCRYPT_INFO pKeyTransEncryptInfo, uint dwFlags, IntPtr pvReserved);

    /// Return Type: BOOL->int
    ///pContentEncryptInfo: PCMSG_CONTENT_ENCRYPT_INFO->_CMSG_CONTENT_ENCRYPT_INFO*
    ///pKeyAgreeEncodeInfo: PCMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO->_CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO*
    ///pKeyAgreeEncryptInfo: PCMSG_KEY_AGREE_ENCRYPT_INFO->_CMSG_KEY_AGREE_ENCRYPT_INFO*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    public delegate int PFN_CMSG_EXPORT_KEY_AGREE(ref CMSG_CONTENT_ENCRYPT_INFO pContentEncryptInfo, ref CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO pKeyAgreeEncodeInfo, ref CMSG_KEY_AGREE_ENCRYPT_INFO pKeyAgreeEncryptInfo, uint dwFlags, IntPtr pvReserved);

    /// Return Type: BOOL->int
    ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
    ///hEncryptKey: HCRYPTKEY->ULONG_PTR->unsigned int
    ///pPublicKeyInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
    ///pbData: PBYTE->BYTE*
    ///pcbData: PDWORD->DWORD*
    public delegate int PFN_CMSG_EXPORT_ENCRYPT_KEY(uint hCryptProv, uint hEncryptKey, ref CERT_PUBLIC_KEY_INFO pPublicKeyInfo, ref byte pbData, ref uint pcbData);

    /// Return Type: void*
    ///cb: size_t->unsigned int
    public delegate IntPtr PFN_CMSG_ALLOC(IntPtr cb);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_WRITE_CTL(IntPtr hStoreProv, ref CTL_CONTEXT pCtlContext, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_WRITE_CRL(IntPtr hStoreProv, ref CRL_CONTEXT pCrlContext, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_WRITE_CERT(IntPtr hStoreProv, ref CERT_CONTEXT pCertContext, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
    ///dwPropId: DWORD->unsigned int
    ///dwFlags: DWORD->unsigned int
    ///pvData: void*
    public delegate int PFN_CERT_STORE_PROV_SET_CTL_PROPERTY(IntPtr hStoreProv, ref CTL_CONTEXT pCtlContext, uint dwPropId, uint dwFlags, IntPtr pvData);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
    ///dwPropId: DWORD->unsigned int
    ///dwFlags: DWORD->unsigned int
    ///pvData: void*
    public delegate int PFN_CERT_STORE_PROV_SET_CRL_PROPERTY(IntPtr hStoreProv, ref CRL_CONTEXT pCrlContext, uint dwPropId, uint dwFlags, IntPtr pvData);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
    ///dwPropId: DWORD->unsigned int
    ///dwFlags: DWORD->unsigned int
    ///pvData: void*
    public delegate int PFN_CERT_STORE_PROV_SET_CERT_PROPERTY(IntPtr hStoreProv, ref CERT_CONTEXT pCertContext, uint dwPropId, uint dwFlags, IntPtr pvData);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pStoreCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    ///ppProvCtlContext: PCCTL_CONTEXT*
    public delegate int PFN_CERT_STORE_PROV_READ_CTL(IntPtr hStoreProv, ref CTL_CONTEXT pStoreCtlContext, uint dwFlags, ref IntPtr ppProvCtlContext);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pStoreCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    ///ppProvCrlContext: PCCRL_CONTEXT*
    public delegate int PFN_CERT_STORE_PROV_READ_CRL(IntPtr hStoreProv, ref CRL_CONTEXT pStoreCrlContext, uint dwFlags, ref IntPtr ppProvCrlContext);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pStoreCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    ///ppProvCertContext: PCCERT_CONTEXT*
    public delegate int PFN_CERT_STORE_PROV_READ_CERT(IntPtr hStoreProv, ref CERT_CONTEXT pStoreCertContext, uint dwFlags, ref IntPtr ppProvCertContext);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
    ///dwPropId: DWORD->unsigned int
    ///dwFlags: DWORD->unsigned int
    ///pvData: void*
    ///pcbData: DWORD*
    public delegate int PFN_CERT_STORE_PROV_GET_CTL_PROPERTY(IntPtr hStoreProv, ref CTL_CONTEXT pCtlContext, uint dwPropId, uint dwFlags, IntPtr pvData, ref uint pcbData);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
    ///dwPropId: DWORD->unsigned int
    ///dwFlags: DWORD->unsigned int
    ///pvData: void*
    ///pcbData: DWORD*
    public delegate int PFN_CERT_STORE_PROV_GET_CRL_PROPERTY(IntPtr hStoreProv, ref CRL_CONTEXT pCrlContext, uint dwPropId, uint dwFlags, IntPtr pvData, ref uint pcbData);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
    ///dwPropId: DWORD->unsigned int
    ///dwFlags: DWORD->unsigned int
    ///pvData: void*
    ///pcbData: DWORD*
    public delegate int PFN_CERT_STORE_PROV_GET_CERT_PROPERTY(IntPtr hStoreProv, ref CERT_CONTEXT pCertContext, uint dwPropId, uint dwFlags, IntPtr pvData, ref uint pcbData);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
    ///pvStoreProvFindInfo: void*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_FREE_FIND_CTL(IntPtr hStoreProv, ref CTL_CONTEXT pCtlContext, IntPtr pvStoreProvFindInfo, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
    ///pvStoreProvFindInfo: void*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_FREE_FIND_CRL(IntPtr hStoreProv, ref CRL_CONTEXT pCrlContext, IntPtr pvStoreProvFindInfo, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
    ///pvStoreProvFindInfo: void*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_FREE_FIND_CERT(IntPtr hStoreProv, ref CERT_CONTEXT pCertContext, IntPtr pvStoreProvFindInfo, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pFindInfo: PCCERT_STORE_PROV_FIND_INFO->CERT_STORE_PROV_FIND_INFO*
    ///pPrevCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    ///ppvStoreProvFindInfo: void**
    ///ppProvCtlContext: PCCTL_CONTEXT*
    public delegate int PFN_CERT_STORE_PROV_FIND_CTL(IntPtr hStoreProv, ref CERT_STORE_PROV_FIND_INFO pFindInfo, ref CTL_CONTEXT pPrevCtlContext, uint dwFlags, ref IntPtr ppvStoreProvFindInfo, ref IntPtr ppProvCtlContext);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pFindInfo: PCCERT_STORE_PROV_FIND_INFO->CERT_STORE_PROV_FIND_INFO*
    ///pPrevCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    ///ppvStoreProvFindInfo: void**
    ///ppProvCrlContext: PCCRL_CONTEXT*
    public delegate int PFN_CERT_STORE_PROV_FIND_CRL(IntPtr hStoreProv, ref CERT_STORE_PROV_FIND_INFO pFindInfo, ref CRL_CONTEXT pPrevCrlContext, uint dwFlags, ref IntPtr ppvStoreProvFindInfo, ref IntPtr ppProvCrlContext);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pFindInfo: PCCERT_STORE_PROV_FIND_INFO->CERT_STORE_PROV_FIND_INFO*
    ///pPrevCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    ///ppvStoreProvFindInfo: void**
    ///ppProvCertContext: PCCERT_CONTEXT*
    public delegate int PFN_CERT_STORE_PROV_FIND_CERT(IntPtr hStoreProv, ref CERT_STORE_PROV_FIND_INFO pFindInfo, ref CERT_CONTEXT pPrevCertContext, uint dwFlags, ref IntPtr ppvStoreProvFindInfo, ref IntPtr ppProvCertContext);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_DELETE_CTL(IntPtr hStoreProv, ref CTL_CONTEXT pCtlContext, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_DELETE_CRL(IntPtr hStoreProv, ref CRL_CONTEXT pCrlContext, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
    ///dwFlags: DWORD->unsigned int
    public delegate int PFN_CERT_STORE_PROV_DELETE_CERT(IntPtr hStoreProv, ref CERT_CONTEXT pCertContext, uint dwFlags);

    /// Return Type: BOOL->int
    ///hStoreProv: HCERTSTOREPROV->void*
    ///dwFlags: DWORD->unsigned int
    ///dwCtrlType: DWORD->unsigned int
    ///pvCtrlPara: void*
    public delegate int PFN_CERT_STORE_PROV_CONTROL(IntPtr hStoreProv, uint dwFlags, uint dwCtrlType, IntPtr pvCtrlPara);

    /// Return Type: void
    ///hStoreProv: HCERTSTOREPROV->void*
    ///dwFlags: DWORD->unsigned int
    public delegate void PFN_CERT_STORE_PROV_CLOSE(IntPtr hStoreProv, uint dwFlags);

    /// Return Type: BOOL->int
    ///pwszStoreLocation: LPCWSTR->WCHAR*
    ///dwFlags: DWORD->unsigned int
    ///pvReserved: void*
    ///pvArg: void*
    public delegate int PFN_CERT_ENUM_SYSTEM_STORE_LOCATION([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszStoreLocation, uint dwFlags, IntPtr pvReserved, IntPtr pvArg);

    /// Return Type: BOOL->int
    ///pvSystemStore: void*
    ///dwFlags: DWORD->unsigned int
    ///pStoreInfo: PCERT_SYSTEM_STORE_INFO->_CERT_SYSTEM_STORE_INFO*
    ///pvReserved: void*
    ///pvArg: void*
    public delegate int PFN_CERT_ENUM_SYSTEM_STORE(IntPtr pvSystemStore, uint dwFlags, ref CERT_SYSTEM_STORE_INFO pStoreInfo, IntPtr pvReserved, IntPtr pvArg);

    /// Return Type: BOOL->int
    ///pvSystemStore: void*
    ///dwFlags: DWORD->unsigned int
    ///pwszStoreName: LPCWSTR->WCHAR*
    ///pStoreInfo: PCERT_PHYSICAL_STORE_INFO->_CERT_PHYSICAL_STORE_INFO*
    ///pvReserved: void*
    ///pvArg: void*
    public delegate int PFN_CERT_ENUM_PHYSICAL_STORE(IntPtr pvSystemStore, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszStoreName, ref CERT_PHYSICAL_STORE_INFO pStoreInfo, IntPtr pvReserved, IntPtr pvArg);

    /// Return Type: BOOL->int
    ///lpszStoreProvider: LPCSTR->CHAR*
    ///dwEncodingType: DWORD->unsigned int
    ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
    ///dwFlags: DWORD->unsigned int
    ///pvPara: void*
    ///hCertStore: HCERTSTORE->void*
    ///pStoreProvInfo: PCERT_STORE_PROV_INFO->_CERT_STORE_PROV_INFO*
    public delegate int PFN_CERT_DLL_OPEN_STORE_PROV_FUNC([In] [MarshalAs(UnmanagedType.LPStr)] string lpszStoreProvider, uint dwEncodingType, uint hCryptProv, uint dwFlags, IntPtr pvPara, IntPtr hCertStore, ref CERT_STORE_PROV_INFO pStoreProvInfo);

    /// Return Type: BOOL->int
    ///pCert: PCCERT_CONTEXT->CERT_CONTEXT*
    ///pvFindArg: void*
    public delegate int PFN_CERT_CHAIN_FIND_BY_ISSUER_CALLBACK(ref CERT_CONTEXT pCert, IntPtr pvFindArg);

    /// Return Type: BOOL->int
    ///hAsyncRetrieve: HCRYPTASYNC->HANDLE->void*
    public delegate int PFN_CANCEL_ASYNC_RETRIEVAL_FUNC(IntPtr hAsyncRetrieve);

    /// Return Type: UINT->unsigned int
    ///pszCentralFile: LPCWSTR->WCHAR*
    ///pszLocalFile: LPCWSTR->WCHAR*
    ///dwFlags: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint PFNRECONCILEPROFILEW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszCentralFile, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszLocalFile, uint dwFlags);

    /// Return Type: UINT->unsigned int
    ///pszCentralFile: LPCSTR->CHAR*
    ///pszLocalFile: LPCSTR->CHAR*
    ///dwFlags: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint PFNRECONCILEPROFILEA([In] [MarshalAs(UnmanagedType.LPStr)] string pszCentralFile, [In] [MarshalAs(UnmanagedType.LPStr)] string pszLocalFile, uint dwFlags);

    /// Return Type: int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PFNPROPSHEETCALLBACK(IntPtr param0, uint param1, IntPtr param2);

    /// Return Type: BOOL->int
    ///hwnd: HWND->HWND__*
    ///pszPath: LPCWSTR->WCHAR*
    ///pszUsername: LPCWSTR->WCHAR*
    ///pszComputerName: LPCWSTR->WCHAR*
    ///dwFlags: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PFNPROCESSPOLICIESW(IntPtr hwnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPath, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszUsername, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszComputerName, uint dwFlags);

    /// Return Type: BOOL->int
    ///hwnd: HWND->HWND__*
    ///pszPath: LPCSTR->CHAR*
    ///pszUsername: LPCSTR->CHAR*
    ///pszComputerName: LPCSTR->CHAR*
    ///dwFlags: DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PFNPROCESSPOLICIESA(IntPtr hwnd, [In] [MarshalAs(UnmanagedType.LPStr)] string pszPath, [In] [MarshalAs(UnmanagedType.LPStr)] string pszUsername, [In] [MarshalAs(UnmanagedType.LPStr)] string pszComputerName, uint dwFlags);

    /// Return Type: UINT->unsigned int
    ///pszUsername: LPCWSTR->WCHAR*
    ///pszBuffer: LPWSTR->WCHAR*
    ///cbBuffer: UINT->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint PFNGETPROFILEPATHW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszUsername, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszBuffer, uint cbBuffer);

    /// Return Type: UINT->unsigned int
    ///pszUsername: LPCSTR->CHAR*
    ///pszBuffer: LPSTR->CHAR*
    ///cbBuffer: UINT->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint PFNGETPROFILEPATHA([In] [MarshalAs(UnmanagedType.LPStr)] string pszUsername, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszBuffer, uint cbBuffer);

    /// Return Type: HDDEDATA->HDDEDATA__*
    ///wType: UINT->unsigned int
    ///wFmt: UINT->unsigned int
    ///hConv: HCONV->HCONV__*
    ///hsz1: HSZ->HSZ__*
    ///hsz2: HSZ->HSZ__*
    ///hData: HDDEDATA->HDDEDATA__*
    ///dwData1: ULONG_PTR->unsigned int
    ///dwData2: ULONG_PTR->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate IntPtr PFNCALLBACK(uint wType, uint wFmt, IntPtr hConv, IntPtr hsz1, IntPtr hsz2, IntPtr hData, uint dwData1, uint dwData2);

    /// Return Type: void
    ///lpFlsData: PVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void PFLS_CALLBACK_FUNCTION(IntPtr lpFlsData);

    /// Return Type: void
    ///lpFiberParameter: LPVOID->void*
    public delegate void PFIBER_START_ROUTINE(IntPtr lpFiberParameter);

    /// Return Type: DWORD->unsigned int
    ///pbData: PBYTE->BYTE*
    ///pvCallbackContext: PVOID->void*
    ///ulLength: PULONG->ULONG*
    public delegate uint PFE_IMPORT_FUNC(IntPtr pbData, [In] IntPtr pvCallbackContext, ref uint ulLength);

    /// Return Type: DWORD->unsigned int
    ///pbData: PBYTE->BYTE*
    ///pvCallbackContext: PVOID->void*
    ///ulLength: ULONG->unsigned int
    public delegate uint PFE_EXPORT_FUNC([In] IntPtr pbData, [In] IntPtr pvCallbackContext, uint ulLength);

    /// Return Type: BOOL->int
    ///pPrivateKeyInfo: CRYPT_PRIVATE_KEY_INFO*
    ///phCryptProv: HCRYPTPROV*
    ///pVoidResolveFunc: LPVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PCRYPT_RESOLVE_HCRYPTPROV_FUNC(ref CRYPT_PRIVATE_KEY_INFO pPrivateKeyInfo, ref uint phCryptProv, IntPtr pVoidResolveFunc);

    /// Return Type: BOOL->int
    ///pAlgorithm: CRYPT_ALGORITHM_IDENTIFIER*
    ///pClearTextPrivateKey: CRYPT_DATA_BLOB*
    ///pbEncryptedKey: BYTE*
    ///pcbEncryptedKey: DWORD*
    ///pVoidEncryptFunc: LPVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PCRYPT_ENCRYPT_PRIVATE_KEY_FUNC(ref CRYPT_ALGORITHM_IDENTIFIER pAlgorithm, ref CRYPT_ATTR_BLOB pClearTextPrivateKey, ref byte pbEncryptedKey, ref uint pcbEncryptedKey, IntPtr pVoidEncryptFunc);

    /// Return Type: BOOL->int
    ///Algorithm: CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
    ///EncryptedPrivateKey: CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
    ///pbClearTextKey: BYTE*
    ///pcbClearTextKey: DWORD*
    ///pVoidDecryptFunc: LPVOID->void*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int PCRYPT_DECRYPT_PRIVATE_KEY_FUNC(CRYPT_ALGORITHM_IDENTIFIER Algorithm, CRYPT_ATTR_BLOB EncryptedPrivateKey, ref byte pbClearTextKey, ref uint pcbClearTextKey, IntPtr pVoidDecryptFunc);

    [StructLayout(LayoutKind.Sequential)]
    public struct pcmwaveformat_tag
    {

        /// WAVEFORMAT->waveformat_tag
        public waveformat_tag wf;

        /// WORD->unsigned short
        public ushort wBitsPerSample;
    }

    /// Return Type: void
    ///dwParam: ULONG_PTR->unsigned int
    public delegate void PAPCFUNC(uint dwParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct PUBLICKEYSTRUC
    {

        /// BYTE->unsigned char
        public byte bType;

        /// BYTE->unsigned char
        public byte bVersion;

        /// WORD->unsigned short
        public ushort reserved;

        /// ALG_ID->unsigned int
        public uint aiKeyAlg;
    }

    public enum PUAFOUT
    {

        /// PUAFOUT_DEFAULT -> 0
        PUAFOUT_DEFAULT = 0,

        /// PUAFOUT_ISLOCKZONEPOLICY -> 0x1
        PUAFOUT_ISLOCKZONEPOLICY = 1,
    }

    public enum PUAF
    {

        /// PUAF_DEFAULT -> 0
        PUAF_DEFAULT = 0,

        /// PUAF_NOUI -> 0x1
        PUAF_NOUI = 1,

        /// PUAF_ISFILE -> 0x2
        PUAF_ISFILE = 2,

        /// PUAF_WARN_IF_DENIED -> 0x4
        PUAF_WARN_IF_DENIED = 4,

        /// PUAF_FORCEUI_FOREGROUND -> 0x8
        PUAF_FORCEUI_FOREGROUND = 8,

        /// PUAF_CHECK_TIFS -> 0x10
        PUAF_CHECK_TIFS = 16,

        /// PUAF_DONTCHECKBOXINDIALOG -> 0x20
        PUAF_DONTCHECKBOXINDIALOG = 32,

        /// PUAF_TRUSTED -> 0x40
        PUAF_TRUSTED = 64,

        /// PUAF_ACCEPT_WILDCARD_SCHEME -> 0x80
        PUAF_ACCEPT_WILDCARD_SCHEME = 128,

        /// PUAF_ENFORCERESTRICTED -> 0x100
        PUAF_ENFORCERESTRICTED = 256,

        /// PUAF_NOSAVEDFILECHECK -> 0x200
        PUAF_NOSAVEDFILECHECK = 512,

        /// PUAF_REQUIRESAVEDFILECHECK -> 0x400
        PUAF_REQUIRESAVEDFILECHECK = 1024,

        /// PUAF_LMZ_UNLOCKED -> 0x10000
        PUAF_LMZ_UNLOCKED = 65536,

        /// PUAF_LMZ_LOCKED -> 0x20000
        PUAF_LMZ_LOCKED = 131072,

        /// PUAF_DEFAULTZONEPOL -> 0x40000
        PUAF_DEFAULTZONEPOL = 262144,

        /// PUAF_NPL_USE_LOCKED_IF_RESTRICTED -> 0x80000
        PUAF_NPL_USE_LOCKED_IF_RESTRICTED = 524288,

        /// PUAF_NOUIIFLOCKED -> 0x100000
        PUAF_NOUIIFLOCKED = 1048576,

        /// PUAF_DRAGPROTOCOLCHECK -> 0x200000
        PUAF_DRAGPROTOCOLCHECK = 2097152,
    }

    public enum PSUACTION
    {

        /// PSU_DEFAULT -> 1
        PSU_DEFAULT = 1,

        /// PSU_SECURITY_URL_ONLY -> PSU_DEFAULT+1
        PSU_SECURITY_URL_ONLY = (PSUACTION.PSU_DEFAULT + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PSINJECTDATA
    {

        /// DWORD->unsigned int
        public uint DataBytes;

        /// WORD->unsigned short
        public ushort InjectionPoint;

        /// WORD->unsigned short
        public ushort PageNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PSHNOTIFY
    {

        /// NMHDR->tagNMHDR
        public tagNMHDR hdr;

        /// LPARAM->LONG_PTR->int
        public int lParam;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PSFEATURE_OUTPUT
    {

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bPageIndependent;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bSetPageDevice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PSFEATURE_CUSTPAPER
    {

        /// LONG->int
        public int lOrientation;

        /// LONG->int
        public int lWidth;

        /// LONG->int
        public int lHeight;

        /// LONG->int
        public int lWidthOffset;

        /// LONG->int
        public int lHeightOffset;
    }

    public enum PROXY_PHASE
    {

        PROXY_CALCSIZE,

        PROXY_GETBUFFER,

        PROXY_MARSHAL,

        PROXY_SENDRECEIVE,

        PROXY_UNMARSHAL,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROV_ENUMALGS_EX
    {

        /// ALG_ID->unsigned int
        public uint aiAlgid;

        /// DWORD->unsigned int
        public uint dwDefaultLen;

        /// DWORD->unsigned int
        public uint dwMinLen;

        /// DWORD->unsigned int
        public uint dwMaxLen;

        /// DWORD->unsigned int
        public uint dwProtocols;

        /// DWORD->unsigned int
        public uint dwNameLen;

        /// CHAR[20]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string szName;

        /// DWORD->unsigned int
        public uint dwLongNameLen;

        /// CHAR[40]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string szLongName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROV_ENUMALGS
    {

        /// ALG_ID->unsigned int
        public uint aiAlgid;

        /// DWORD->unsigned int
        public uint dwBitLen;

        /// DWORD->unsigned int
        public uint dwNameLen;

        /// CHAR[20]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string szName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROVIDOR_INFO_2W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROVIDOR_INFO_2A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROVIDOR_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pEnvironment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDLLName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROVIDOR_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pEnvironment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDLLName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROTOCOLFILTERDATA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// IInternetProtocolSink*
        public IntPtr pProtocolSink;

        /// IInternetProtocol*
        public IntPtr pProtocol;

        /// IUnknown*
        public IntPtr pUnk;

        /// DWORD->unsigned int
        public uint dwFilterFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROTOCOLDATA
    {

        /// DWORD->unsigned int
        public uint grfFlags;

        /// DWORD->unsigned int
        public uint dwState;

        /// LPVOID->void*
        public IntPtr pData;

        /// ULONG->unsigned int
        public uint cbData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETPAGEW_V3
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_4ab5a4bd_9e2a_4940_b27d_599c914ef6f1
        public Anonymous_4ab5a4bd_9e2a_4940_b27d_599c914ef6f1 Union1;

        /// Anonymous_a7f13da1_dec1_4dac_ae92_16e3d8cba71c
        public Anonymous_a7f13da1_dec1_4dac_ae92_16e3d8cba71c Union2;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszTitle;

        /// DLGPROC
        public DLGPROC pfnDlgProc;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// LPFNPSPCALLBACKW
        public LPFNPSPCALLBACKW pfnCallback;

        /// UINT*
        public IntPtr pcRefParent;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszHeaderTitle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszHeaderSubTitle;

        /// HANDLE->void*
        public IntPtr hActCtx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETPAGEW_V2
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_ec3d2e6d_20ad_46aa_814e_7b1702028889
        public Anonymous_ec3d2e6d_20ad_46aa_814e_7b1702028889 Union1;

        /// Anonymous_19ab1780_6726_4de7_b522_04c6cbe4cee1
        public Anonymous_19ab1780_6726_4de7_b522_04c6cbe4cee1 Union2;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszTitle;

        /// DLGPROC
        public DLGPROC pfnDlgProc;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// LPFNPSPCALLBACKW
        public LPFNPSPCALLBACKW pfnCallback;

        /// UINT*
        public IntPtr pcRefParent;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszHeaderTitle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszHeaderSubTitle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETPAGEW_V1
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_cfe69ad2_5ccf_492c_ada2_b57240733f82
        public Anonymous_cfe69ad2_5ccf_492c_ada2_b57240733f82 Union1;

        /// Anonymous_cb866153_4202_46bb_a783_4f83678ec1a5
        public Anonymous_cb866153_4202_46bb_a783_4f83678ec1a5 Union2;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszTitle;

        /// DLGPROC
        public DLGPROC pfnDlgProc;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// LPFNPSPCALLBACKW
        public LPFNPSPCALLBACKW pfnCallback;

        /// UINT*
        public IntPtr pcRefParent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETPAGEA_V3
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_9637d98a_5c31_4364_8c28_61baf1ae752a
        public Anonymous_9637d98a_5c31_4364_8c28_61baf1ae752a Union1;

        /// Anonymous_0afef47a_7c7b_4367_b4ad_cb85b5f7e05e
        public Anonymous_0afef47a_7c7b_4367_b4ad_cb85b5f7e05e Union2;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszTitle;

        /// DLGPROC
        public DLGPROC pfnDlgProc;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// LPFNPSPCALLBACKA
        public LPFNPSPCALLBACKA pfnCallback;

        /// UINT*
        public IntPtr pcRefParent;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszHeaderTitle;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszHeaderSubTitle;

        /// HANDLE->void*
        public IntPtr hActCtx;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETPAGEA_V2
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_d744c6eb_695a_417f_b8f4_c85f39642ecd
        public Anonymous_d744c6eb_695a_417f_b8f4_c85f39642ecd Union1;

        /// Anonymous_88f3017d_a889_46b6_84da_843bcde8f004
        public Anonymous_88f3017d_a889_46b6_84da_843bcde8f004 Union2;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszTitle;

        /// DLGPROC
        public DLGPROC pfnDlgProc;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// LPFNPSPCALLBACKA
        public LPFNPSPCALLBACKA pfnCallback;

        /// UINT*
        public IntPtr pcRefParent;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszHeaderTitle;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszHeaderSubTitle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETPAGEA_V1
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_838128fc_6fad_48ae_bb9f_1ce1ded37abc
        public Anonymous_838128fc_6fad_48ae_bb9f_1ce1ded37abc Union1;

        /// Anonymous_11ed492b_9ab3_4f10_8119_154d936020f6
        public Anonymous_11ed492b_9ab3_4f10_8119_154d936020f6 Union2;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszTitle;

        /// DLGPROC
        public DLGPROC pfnDlgProc;

        /// LPARAM->LONG_PTR->int
        public int lParam;

        /// LPFNPSPCALLBACKA
        public LPFNPSPCALLBACKA pfnCallback;

        /// UINT*
        public IntPtr pcRefParent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETHEADERW
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HWND->HWND__*
        public IntPtr hwndParent;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_bae06084_c07b_4428_8082_e2b9fbe43125
        public Anonymous_bae06084_c07b_4428_8082_e2b9fbe43125 Union1;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszCaption;

        /// UINT->unsigned int
        public uint nPages;

        /// Anonymous_34cf2035_247b_4d12_a4e4_7a7be8706b8a
        public Anonymous_34cf2035_247b_4d12_a4e4_7a7be8706b8a Union2;

        /// Anonymous_94b32888_87dd_4b6f_a5b7_0e0020f6dc88
        public Anonymous_94b32888_87dd_4b6f_a5b7_0e0020f6dc88 Union3;

        /// PFNPROPSHEETCALLBACK
        public PFNPROPSHEETCALLBACK pfnCallback;

        /// Anonymous_222c9197_a443_449d_8fe0_b6b264448c71
        public Anonymous_222c9197_a443_449d_8fe0_b6b264448c71 Union4;

        /// HPALETTE->HPALETTE__*
        public IntPtr hplWatermark;

        /// Anonymous_452bdd45_7a70_4765_9e3d_53eceb6d0161
        public Anonymous_452bdd45_7a70_4765_9e3d_53eceb6d0161 Union5;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROPSHEETHEADERA
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HWND->HWND__*
        public IntPtr hwndParent;

        /// HINSTANCE->HINSTANCE__*
        public IntPtr hInstance;

        /// Anonymous_6b974a5d_1ff7_4e60_8dc7_d6d0c32293be
        public Anonymous_6b974a5d_1ff7_4e60_8dc7_d6d0c32293be Union1;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszCaption;

        /// UINT->unsigned int
        public uint nPages;

        /// Anonymous_8cb88cea_ec75_4ac4_b7a5_799dc26b6429
        public Anonymous_8cb88cea_ec75_4ac4_b7a5_799dc26b6429 Union2;

        /// Anonymous_f75e3883_ac7c_476e_bd60_3b6d9fe9cacc
        public Anonymous_f75e3883_ac7c_476e_bd60_3b6d9fe9cacc Union3;

        /// PFNPROPSHEETCALLBACK
        public PFNPROPSHEETCALLBACK pfnCallback;

        /// Anonymous_77c631f1_b84e_4548_aa5c_9f59a7947f03
        public Anonymous_77c631f1_b84e_4548_aa5c_9f59a7947f03 Union4;

        /// HPALETTE->HPALETTE__*
        public IntPtr hplWatermark;

        /// Anonymous_5fb4f54e_e61b_4684_b8b7_bfc5d228ac55
        public Anonymous_5fb4f54e_e61b_4684_b8b7_bfc5d228ac55 Union5;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_INFORMATION
    {

        /// HANDLE->void*
        public IntPtr hProcess;

        /// HANDLE->void*
        public IntPtr hThread;

        /// DWORD->unsigned int
        public uint dwProcessId;

        /// DWORD->unsigned int
        public uint dwThreadId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_HEAP_ENTRY
    {

        /// PVOID->void*
        public IntPtr lpData;

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE->unsigned char
        public byte cbOverhead;

        /// BYTE->unsigned char
        public byte iRegionIndex;

        /// WORD->unsigned short
        public ushort wFlags;

        /// Anonymous_53c79322_6506_4260_871f_234e2af0cacb
        public Anonymous_53c79322_6506_4260_871f_234e2af0cacb Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_POWER_POLICY_INFO
    {

        /// DWORD->unsigned int
        public uint TimeCheck;

        /// DWORD->unsigned int
        public uint DemoteLimit;

        /// DWORD->unsigned int
        public uint PromoteLimit;

        /// BYTE->unsigned char
        public byte DemotePercent;

        /// BYTE->unsigned char
        public byte PromotePercent;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] Spare;

        /// AllowDemotion : 1
        ///AllowPromotion : 1
        ///Reserved : 30
        public uint bitvector1;

        public uint AllowDemotion
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint AllowPromotion
        {
            get
            {
                return ((uint)(((this.bitvector1 & 2u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }

        public uint Reserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4294967292u)
                            / 4)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4)
                            | this.bitvector1)));
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSOR_POWER_POLICY
    {

        /// DWORD->unsigned int
        public uint Revision;

        /// BYTE->unsigned char
        public byte DynamicThrottle;

        /// BYTE[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
        public byte[] Spare;

        /// DisableCStates : 1
        ///Reserved : 31
        public uint bitvector1;

        /// DWORD->unsigned int
        public uint PolicyCount;

        /// PROCESSOR_POWER_POLICY_INFO[3]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
        public PROCESSOR_POWER_POLICY_INFO[] Policy;

        public uint DisableCStates
        {
            get
            {
                return ((uint)((this.bitvector1 & 1u)));
            }
            set
            {
                this.bitvector1 = ((uint)((value | this.bitvector1)));
            }
        }

        public uint Reserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4294967294u)
                            / 2)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 2)
                            | this.bitvector1)));
            }
        }
    }

    public enum PROCESSOR_CACHE_TYPE
    {

        CacheUnified,

        CacheInstruction,

        CacheData,

        CacheTrace,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRIVILEGE_SET
    {

        /// DWORD->unsigned int
        public uint PrivilegeCount;

        /// DWORD->unsigned int
        public uint Control;

        /// LUID_AND_ATTRIBUTES[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public LUID_AND_ATTRIBUTES[] Privilege;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTPROCESSOR_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTPROCESSOR_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTPROCESSOR_CAPS_1
    {

        /// DWORD->unsigned int
        public uint dwLevel;

        /// DWORD->unsigned int
        public uint dwNupOptions;

        /// DWORD->unsigned int
        public uint dwPageOrderFlags;

        /// DWORD->unsigned int
        public uint dwNumberOfCopies;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_NOTIFY_OPTIONS_TYPE
    {

        /// WORD->unsigned short
        public ushort Type;

        /// WORD->unsigned short
        public ushort Reserved0;

        /// DWORD->unsigned int
        public uint Reserved1;

        /// DWORD->unsigned int
        public uint Reserved2;

        /// DWORD->unsigned int
        public uint Count;

        /// PWORD->WORD*
        public IntPtr pFields;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_NOTIFY_OPTIONS
    {

        /// DWORD->unsigned int
        public uint Version;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint Count;

        /// PPRINTER_NOTIFY_OPTIONS_TYPE->_PRINTER_NOTIFY_OPTIONS_TYPE*
        public IntPtr pTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_NOTIFY_INFO_DATA
    {

        /// WORD->unsigned short
        public ushort Type;

        /// WORD->unsigned short
        public ushort Field;

        /// DWORD->unsigned int
        public uint Reserved;

        /// DWORD->unsigned int
        public uint Id;

        /// Anonymous_6d643135_3562_4386_a300_df7ee6f42ac2
        public Anonymous_6d643135_3562_4386_a300_df7ee6f42ac2 NotifyData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_NOTIFY_INFO
    {

        /// DWORD->unsigned int
        public uint Version;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint Count;

        /// PRINTER_NOTIFY_INFO_DATA[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public PRINTER_NOTIFY_INFO_DATA[] aData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_9W
    {

        /// LPDEVMODEW->_devicemodeW*
        public IntPtr pDevMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_9A
    {

        /// LPDEVMODEA->_devicemodeA*
        public IntPtr pDevMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_8W
    {

        /// LPDEVMODEW->_devicemodeW*
        public IntPtr pDevMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_8A
    {

        /// LPDEVMODEA->_devicemodeA*
        public IntPtr pDevMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_7W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszObjectGUID;

        /// DWORD->unsigned int
        public uint dwAction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_7A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjectGUID;

        /// DWORD->unsigned int
        public uint dwAction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_6
    {

        /// DWORD->unsigned int
        public uint dwStatus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_5W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrinterName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPortName;

        /// DWORD->unsigned int
        public uint Attributes;

        /// DWORD->unsigned int
        public uint DeviceNotSelectedTimeout;

        /// DWORD->unsigned int
        public uint TransmissionRetryTimeout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_5A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPrinterName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPortName;

        /// DWORD->unsigned int
        public uint Attributes;

        /// DWORD->unsigned int
        public uint DeviceNotSelectedTimeout;

        /// DWORD->unsigned int
        public uint TransmissionRetryTimeout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_4W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrinterName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pServerName;

        /// DWORD->unsigned int
        public uint Attributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_4A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPrinterName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pServerName;

        /// DWORD->unsigned int
        public uint Attributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_3
    {

        /// PSECURITY_DESCRIPTOR->PVOID->void*
        public IntPtr pSecurityDescriptor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_2W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pServerName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrinterName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pShareName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPortName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDriverName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pComment;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pLocation;

        /// LPDEVMODEW->_devicemodeW*
        public IntPtr pDevMode;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pSepFile;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPrintProcessor;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDatatype;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pParameters;

        /// PSECURITY_DESCRIPTOR->PVOID->void*
        public IntPtr pSecurityDescriptor;

        /// DWORD->unsigned int
        public uint Attributes;

        /// DWORD->unsigned int
        public uint Priority;

        /// DWORD->unsigned int
        public uint DefaultPriority;

        /// DWORD->unsigned int
        public uint StartTime;

        /// DWORD->unsigned int
        public uint UntilTime;

        /// DWORD->unsigned int
        public uint Status;

        /// DWORD->unsigned int
        public uint cJobs;

        /// DWORD->unsigned int
        public uint AveragePPM;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_2A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pServerName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPrinterName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pShareName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPortName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDriverName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pComment;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pLocation;

        /// LPDEVMODEA->_devicemodeA*
        public IntPtr pDevMode;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pSepFile;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPrintProcessor;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDatatype;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pParameters;

        /// PSECURITY_DESCRIPTOR->PVOID->void*
        public IntPtr pSecurityDescriptor;

        /// DWORD->unsigned int
        public uint Attributes;

        /// DWORD->unsigned int
        public uint Priority;

        /// DWORD->unsigned int
        public uint DefaultPriority;

        /// DWORD->unsigned int
        public uint StartTime;

        /// DWORD->unsigned int
        public uint UntilTime;

        /// DWORD->unsigned int
        public uint Status;

        /// DWORD->unsigned int
        public uint cJobs;

        /// DWORD->unsigned int
        public uint AveragePPM;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_1W
    {

        /// DWORD->unsigned int
        public uint Flags;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDescription;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pComment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_INFO_1A
    {

        /// DWORD->unsigned int
        public uint Flags;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDescription;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pComment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_ENUM_VALUESW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pValueName;

        /// DWORD->unsigned int
        public uint cbValueName;

        /// DWORD->unsigned int
        public uint dwType;

        /// LPBYTE->BYTE*
        public IntPtr pData;

        /// DWORD->unsigned int
        public uint cbData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_ENUM_VALUESA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pValueName;

        /// DWORD->unsigned int
        public uint cbValueName;

        /// DWORD->unsigned int
        public uint dwType;

        /// LPBYTE->BYTE*
        public IntPtr pData;

        /// DWORD->unsigned int
        public uint cbData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_DEFAULTSW
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDatatype;

        /// LPDEVMODEW->_devicemodeW*
        public IntPtr pDevMode;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint DesiredAccess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PRINTER_DEFAULTSA
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDatatype;

        /// LPDEVMODEA->_devicemodeA*
        public IntPtr pDevMode;

        /// ACCESS_MASK->DWORD->unsigned int
        public uint DesiredAccess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PREVENT_MEDIA_REMOVAL
    {

        /// BOOLEAN->BYTE->unsigned char
        public byte PreventMediaRemoval;
    }

    public enum POWER_INFORMATION_LEVEL
    {

        SystemPowerPolicyAc,

        SystemPowerPolicyDc,

        VerifySystemPolicyAc,

        VerifySystemPolicyDc,

        SystemPowerCapabilities,

        SystemBatteryState,

        SystemPowerStateHandler,

        ProcessorStateHandler,

        SystemPowerPolicyCurrent,

        AdministratorPowerPolicy,

        SystemReserveHiberFile,

        ProcessorInformation,

        SystemPowerInformation,

        ProcessorStateHandler2,

        LastWakeTime,

        LastSleepTime,

        SystemExecutionState,

        SystemPowerStateNotifyHandler,

        ProcessorPowerPolicyAc,

        ProcessorPowerPolicyDc,

        VerifyProcessorPowerPolicyAc,

        VerifyProcessorPowerPolicyDc,

        ProcessorPowerPolicyCurrent,

        SystemPowerStateLogging,

        SystemPowerLoggingEntry,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POWER_ACTION_POLICY
    {

        /// POWER_ACTION->Anonymous_b03c8fc1_898b_4bcb_a220_c32458eefeb4
        public POWER_ACTION Action;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint EventCode;
    }

    public enum POWER_ACTION
    {

        /// PowerActionNone -> 0
        PowerActionNone = 0,

        PowerActionReserved,

        PowerActionSleep,

        PowerActionHibernate,

        PowerActionShutdown,

        PowerActionShutdownReset,

        PowerActionShutdownOff,

        PowerActionWarmEject,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PORT_INFO_3W
    {

        /// DWORD->unsigned int
        public uint dwStatus;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszStatus;

        /// DWORD->unsigned int
        public uint dwSeverity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PORT_INFO_3A
    {

        /// DWORD->unsigned int
        public uint dwStatus;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszStatus;

        /// DWORD->unsigned int
        public uint dwSeverity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PORT_INFO_2W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pPortName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pMonitorName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDescription;

        /// DWORD->unsigned int
        public uint fPortType;

        /// DWORD->unsigned int
        public uint Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PORT_INFO_2A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pPortName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pMonitorName;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDescription;

        /// DWORD->unsigned int
        public uint fPortType;

        /// DWORD->unsigned int
        public uint Reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PORT_INFO_1W
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PORT_INFO_1A
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINTL
    {

        /// LONG->int
        public int x;

        /// LONG->int
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINTFLOAT
    {

        /// FLOAT->float
        public float x;

        /// FLOAT->float
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {

        /// LONG->int
        public int x;

        /// LONG->int
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PLEX_READ_DATA_REQUEST
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER ByteOffset;

        /// DWORD->unsigned int
        public uint ByteLength;

        /// DWORD->unsigned int
        public uint PlexNumber;
    }

    public enum PI_FLAGS
    {

        /// PI_PARSE_URL -> 0x1
        PI_PARSE_URL = 1,

        /// PI_FILTER_MODE -> 0x2
        PI_FILTER_MODE = 2,

        /// PI_FORCE_ASYNC -> 0x4
        PI_FORCE_ASYNC = 4,

        /// PI_USE_WORKERTHREAD -> 0x8
        PI_USE_WORKERTHREAD = 8,

        /// PI_MIMEVERIFICATION -> 0x10
        PI_MIMEVERIFICATION = 16,

        /// PI_CLSIDLOOKUP -> 0x20
        PI_CLSIDLOOKUP = 32,

        /// PI_DATAPROGRESS -> 0x40
        PI_DATAPROGRESS = 64,

        /// PI_SYNCHRONOUS -> 0x80
        PI_SYNCHRONOUS = 128,

        /// PI_APARTMENTTHREADED -> 0x100
        PI_APARTMENTTHREADED = 256,

        /// PI_CLASSINSTALL -> 0x200
        PI_CLASSINSTALL = 512,

        /// PI_PASSONBINDCTX -> 0x2000
        PI_PASSONBINDCTX = 8192,

        /// PI_NOMIMEHANDLER -> 0x8000
        PI_NOMIMEHANDLER = 32768,

        /// PI_LOADAPPDIRECT -> 0x4000
        PI_LOADAPPDIRECT = 16384,

        /// PD_FORCE_SWITCH -> 0x10000
        PD_FORCE_SWITCH = 65536,

        /// PI_PREFERDEFAULTHANDLER -> 0x20000
        PI_PREFERDEFAULTHANDLER = 131072,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PERF_OBJECT_TYPE
    {

        /// DWORD->unsigned int
        public uint TotalByteLength;

        /// DWORD->unsigned int
        public uint DefinitionLength;

        /// DWORD->unsigned int
        public uint HeaderLength;

        /// DWORD->unsigned int
        public uint ObjectNameTitleIndex;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ObjectNameTitle;

        /// DWORD->unsigned int
        public uint ObjectHelpTitleIndex;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string ObjectHelpTitle;

        /// DWORD->unsigned int
        public uint DetailLevel;

        /// DWORD->unsigned int
        public uint NumCounters;

        /// LONG->int
        public int DefaultCounter;

        /// LONG->int
        public int NumInstances;

        /// DWORD->unsigned int
        public uint CodePage;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PerfTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PerfFreq;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PERF_INSTANCE_DEFINITION
    {

        /// DWORD->unsigned int
        public uint ByteLength;

        /// DWORD->unsigned int
        public uint ParentObjectTitleIndex;

        /// DWORD->unsigned int
        public uint ParentObjectInstance;

        /// LONG->int
        public int UniqueID;

        /// DWORD->unsigned int
        public uint NameOffset;

        /// DWORD->unsigned int
        public uint NameLength;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct PERF_DATA_BLOCK
    {

        /// WCHAR[4]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string Signature;

        /// DWORD->unsigned int
        public uint LittleEndian;

        /// DWORD->unsigned int
        public uint Version;

        /// DWORD->unsigned int
        public uint Revision;

        /// DWORD->unsigned int
        public uint TotalByteLength;

        /// DWORD->unsigned int
        public uint HeaderLength;

        /// DWORD->unsigned int
        public uint NumObjectTypes;

        /// LONG->int
        public int DefaultObject;

        /// SYSTEMTIME->_SYSTEMTIME
        public SYSTEMTIME SystemTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PerfTime;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PerfFreq;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PerfTime100nSec;

        /// DWORD->unsigned int
        public uint SystemNameLength;

        /// DWORD->unsigned int
        public uint SystemNameOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PERF_COUNTER_DEFINITION
    {

        /// DWORD->unsigned int
        public uint ByteLength;

        /// DWORD->unsigned int
        public uint CounterNameTitleIndex;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string CounterNameTitle;

        /// DWORD->unsigned int
        public uint CounterHelpTitleIndex;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string CounterHelpTitle;

        /// LONG->int
        public int DefaultScale;

        /// DWORD->unsigned int
        public uint DetailLevel;

        /// DWORD->unsigned int
        public uint CounterType;

        /// DWORD->unsigned int
        public uint CounterSize;

        /// DWORD->unsigned int
        public uint CounterOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PERF_COUNTER_BLOCK
    {

        /// DWORD->unsigned int
        public uint ByteLength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PERF_BIN
    {

        /// DWORD->unsigned int
        public uint NumberOfBins;

        /// DWORD->unsigned int
        public uint TypeOfBin;

        /// BIN_RANGE[1]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public BIN_RANGE[] BinsRanges;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct PATHNAME_BUFFER
    {

        /// DWORD->unsigned int
        public uint PathNameLength;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string Name;
    }

    public enum PARTITION_STYLE
    {

        PARTITION_STYLE_MBR,

        PARTITION_STYLE_GPT,

        PARTITION_STYLE_RAW,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PARTITION_INFORMATION_MBR
    {

        /// BYTE->unsigned char
        public byte PartitionType;

        /// BOOLEAN->BYTE->unsigned char
        public byte BootIndicator;

        /// BOOLEAN->BYTE->unsigned char
        public byte RecognizedPartition;

        /// DWORD->unsigned int
        public uint HiddenSectors;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct PARTITION_INFORMATION_GPT
    {

        /// GUID->_GUID
        public GUID PartitionType;

        /// GUID->_GUID
        public GUID PartitionId;

        /// DWORD64->unsigned __int64
        public ulong Attributes;

        /// WCHAR[36]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Name;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PARTITION_INFORMATION_EX
    {

        /// PARTITION_STYLE->_PARTITION_STYLE
        public PARTITION_STYLE PartitionStyle;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PartitionLength;

        /// DWORD->unsigned int
        public uint PartitionNumber;

        /// BOOLEAN->BYTE->unsigned char
        public byte RewritePartition;

        /// Anonymous_6a8b6acb_03f6_4286_8d2c_69d4d4f7c663
        public Anonymous_6a8b6acb_03f6_4286_8d2c_69d4d4f7c663 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PARTITION_INFORMATION
    {

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER StartingOffset;

        /// LARGE_INTEGER->_LARGE_INTEGER
        public LARGE_INTEGER PartitionLength;

        /// DWORD->unsigned int
        public uint HiddenSectors;

        /// DWORD->unsigned int
        public uint PartitionNumber;

        /// BYTE->unsigned char
        public byte PartitionType;

        /// BOOLEAN->BYTE->unsigned char
        public byte BootIndicator;

        /// BOOLEAN->BYTE->unsigned char
        public byte RecognizedPartition;

        /// BOOLEAN->BYTE->unsigned char
        public byte RewritePartition;
    }

    public enum PARSEACTION
    {

        /// PARSE_CANONICALIZE -> 1
        PARSE_CANONICALIZE = 1,

        /// PARSE_FRIENDLY -> PARSE_CANONICALIZE+1
        PARSE_FRIENDLY = (PARSEACTION.PARSE_CANONICALIZE + 1),

        /// PARSE_SECURITY_URL -> PARSE_FRIENDLY+1
        PARSE_SECURITY_URL = (PARSEACTION.PARSE_FRIENDLY + 1),

        /// PARSE_ROOTDOCUMENT -> PARSE_SECURITY_URL+1
        PARSE_ROOTDOCUMENT = (PARSEACTION.PARSE_SECURITY_URL + 1),

        /// PARSE_DOCUMENT -> PARSE_ROOTDOCUMENT+1
        PARSE_DOCUMENT = (PARSEACTION.PARSE_ROOTDOCUMENT + 1),

        /// PARSE_ANCHOR -> PARSE_DOCUMENT+1
        PARSE_ANCHOR = (PARSEACTION.PARSE_DOCUMENT + 1),

        /// PARSE_ENCODE -> PARSE_ANCHOR+1
        PARSE_ENCODE = (PARSEACTION.PARSE_ANCHOR + 1),

        /// PARSE_DECODE -> PARSE_ENCODE+1
        PARSE_DECODE = (PARSEACTION.PARSE_ENCODE + 1),

        /// PARSE_PATH_FROM_URL -> PARSE_DECODE+1
        PARSE_PATH_FROM_URL = (PARSEACTION.PARSE_DECODE + 1),

        /// PARSE_URL_FROM_PATH -> PARSE_PATH_FROM_URL+1
        PARSE_URL_FROM_PATH = (PARSEACTION.PARSE_PATH_FROM_URL + 1),

        /// PARSE_MIME -> PARSE_URL_FROM_PATH+1
        PARSE_MIME = (PARSEACTION.PARSE_URL_FROM_PATH + 1),

        /// PARSE_SERVER -> PARSE_MIME+1
        PARSE_SERVER = (PARSEACTION.PARSE_MIME + 1),

        /// PARSE_SCHEMA -> PARSE_SERVER+1
        PARSE_SCHEMA = (PARSEACTION.PARSE_SERVER + 1),

        /// PARSE_SITE -> PARSE_SCHEMA+1
        PARSE_SITE = (PARSEACTION.PARSE_SCHEMA + 1),

        /// PARSE_DOMAIN -> PARSE_SITE+1
        PARSE_DOMAIN = (PARSEACTION.PARSE_SITE + 1),

        /// PARSE_LOCATION -> PARSE_DOMAIN+1
        PARSE_LOCATION = (PARSEACTION.PARSE_DOMAIN + 1),

        /// PARSE_SECURITY_DOMAIN -> PARSE_LOCATION+1
        PARSE_SECURITY_DOMAIN = (PARSEACTION.PARSE_LOCATION + 1),

        /// PARSE_ESCAPE -> PARSE_SECURITY_DOMAIN+1
        PARSE_ESCAPE = (PARSEACTION.PARSE_SECURITY_DOMAIN + 1),

        /// PARSE_UNESCAPE -> PARSE_ESCAPE+1
        PARSE_UNESCAPE = (PARSEACTION.PARSE_ESCAPE + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PACKEDEVENTINFO
    {

        /// DWORD->unsigned int
        public uint ulSize;

        /// DWORD->unsigned int
        public uint ulNumEventsForLogFile;

        /// DWORD[]
        public uint[] ulOffsets;
    }

}
