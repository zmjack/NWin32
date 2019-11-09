using System;
using System.Runtime.InteropServices;

namespace NWin32.NativeTypes
{
    /// Return Type: void
    ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
    ///ulNetworkCodeSet: unsigned int
    ///pLocalData: void*
    ///ulLocalDataLength: unsigned int
    ///pNetworkData: byte*
    ///pulNetworkDataLength: unsigned int*
    ///pStatus: error_status_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void CS_TYPE_TO_NETCS_ROUTINE(IntPtr hBinding, uint ulNetworkCodeSet, IntPtr pLocalData, uint ulLocalDataLength, ref byte pNetworkData, ref uint pulNetworkDataLength, ref uint pStatus);

    /// Return Type: void
    ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
    ///ulNetworkCodeSet: unsigned int
    ///ulLocalBufferSize: unsigned int
    ///conversionType: IDL_CS_CONVERT*
    ///pulNetworkBufferSize: unsigned int*
    ///pStatus: error_status_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void CS_TYPE_NET_SIZE_ROUTINE(IntPtr hBinding, uint ulNetworkCodeSet, uint ulLocalBufferSize, ref IDL_CS_CONVERT conversionType, ref uint pulNetworkBufferSize, ref uint pStatus);

    /// Return Type: void
    ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
    ///ulNetworkCodeSet: unsigned int
    ///ulNetworkBufferSize: unsigned int
    ///conversionType: IDL_CS_CONVERT*
    ///pulLocalBufferSize: unsigned int*
    ///pStatus: error_status_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void CS_TYPE_LOCAL_SIZE_ROUTINE(IntPtr hBinding, uint ulNetworkCodeSet, uint ulNetworkBufferSize, ref IDL_CS_CONVERT conversionType, ref uint pulLocalBufferSize, ref uint pStatus);

    /// Return Type: void
    ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
    ///ulNetworkCodeSet: unsigned int
    ///pNetworkData: byte*
    ///ulNetworkDataLength: unsigned int
    ///ulLocalBufferSize: unsigned int
    ///pLocalData: void*
    ///pulLocalDataLength: unsigned int*
    ///pStatus: error_status_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void CS_TYPE_FROM_NETCS_ROUTINE(IntPtr hBinding, uint ulNetworkCodeSet, ref byte pNetworkData, uint ulNetworkDataLength, uint ulLocalBufferSize, IntPtr pLocalData, ref uint pulLocalDataLength, ref uint pStatus);

    /// Return Type: void
    ///hBinding: RPC_BINDING_HANDLE->I_RPC_HANDLE->void*
    ///fServerSide: int
    ///pulSendingTag: unsigned int*
    ///pulDesiredReceivingTag: unsigned int*
    ///pulReceivingTag: unsigned int*
    ///pStatus: error_status_t*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void CS_TAG_GETTING_ROUTINE(IntPtr hBinding, int fServerSide, ref uint pulSendingTag, ref uint pulDesiredReceivingTag, ref uint pulReceivingTag, ref uint pStatus);

    [StructLayout(LayoutKind.Sequential)]
    public struct CONFIRMSAFETY
    {

        /// CLSID->GUID->_GUID
        public GUID clsid;

        /// IUnknown*
        public IntPtr pUnk;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CODEPAGE_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CODEPAGE_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct CM_Power_Data_s
    {

        /// DWORD->unsigned int
        public uint PD_Size;

        /// DEVICE_POWER_STATE->_DEVICE_POWER_STATE
        public DEVICE_POWER_STATE PD_MostRecentPowerState;

        /// DWORD->unsigned int
        public uint PD_Capabilities;

        /// DWORD->unsigned int
        public uint PD_D1Latency;

        /// DWORD->unsigned int
        public uint PD_D2Latency;

        /// DWORD->unsigned int
        public uint PD_D3Latency;

        /// DEVICE_POWER_STATE[7]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.Struct)]
        public DEVICE_POWER_STATE[] PD_PowerStateMapping;

        /// SYSTEM_POWER_STATE->_SYSTEM_POWER_STATE
        public SYSTEM_POWER_STATE PD_DeepestSystemWake;
    }

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0);

    /// Return Type: BOOL->int
    ///param0: LPWSTR->WCHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCEXW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    ///param1: CALID->DWORD->unsigned int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCEXA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0, uint param1);

    /// Return Type: BOOL->int
    ///param0: LPSTR->CHAR*
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate int CALINFO_ENUMPROCA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct CURRENCYFMTW
    {

        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDecimalSep;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;

        /// UINT->unsigned int
        public uint PositiveOrder;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpCurrencySymbol;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CURRENCYFMTA
    {

        /// UINT->unsigned int
        public uint NumDigits;

        /// UINT->unsigned int
        public uint LeadingZero;

        /// UINT->unsigned int
        public uint Grouping;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDecimalSep;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpThousandSep;

        /// UINT->unsigned int
        public uint NegativeOrder;

        /// UINT->unsigned int
        public uint PositiveOrder;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpCurrencySymbol;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_VERIFY_USAGE_STATUS
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwError;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// PCCTL_CONTEXT*
        public IntPtr ppCtl;

        /// DWORD->unsigned int
        public uint dwCtlEntryIndex;

        /// PCCERT_CONTEXT*
        public IntPtr ppSigner;

        /// DWORD->unsigned int
        public uint dwSignerIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_VERIFY_USAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB ListIdentifier;

        /// DWORD->unsigned int
        public uint cCtlStore;

        /// HCERTSTORE*
        public IntPtr rghCtlStore;

        /// DWORD->unsigned int
        public uint cSignerStore;

        /// HCERTSTORE*
        public IntPtr rghSignerStore;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_USAGE_MATCH
    {

        /// DWORD->unsigned int
        public uint dwType;

        /// CTL_USAGE->_CTL_USAGE
        public CERT_ENHKEY_USAGE Usage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_ENHKEY_USAGE
    {

        /// DWORD->unsigned int
        public uint cUsageIdentifier;

        /// LPSTR*
        public IntPtr rgpszUsageIdentifier;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CTL_USAGE->_CTL_USAGE
        public CERT_ENHKEY_USAGE SubjectUsage;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB ListIdentifier;

        /// CRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SequenceNumber;

        /// FILETIME->_FILETIME
        public FILETIME ThisUpdate;

        /// FILETIME->_FILETIME
        public FILETIME NextUpdate;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER SubjectAlgorithm;

        /// DWORD->unsigned int
        public uint cCTLEntry;

        /// PCTL_ENTRY->_CTL_ENTRY*
        public IntPtr rgCTLEntry;

        /// DWORD->unsigned int
        public uint cExtension;

        /// PCERT_EXTENSION->_CERT_EXTENSION*
        public IntPtr rgExtension;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_FIND_USAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CTL_USAGE->_CTL_USAGE
        public CERT_ENHKEY_USAGE SubjectUsage;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB ListIdentifier;

        /// PCERT_INFO->_CERT_INFO*
        public IntPtr pSigner;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_FIND_SUBJECT_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PCTL_FIND_USAGE_PARA->_CTL_FIND_USAGE_PARA*
        public IntPtr pUsagePara;

        /// DWORD->unsigned int
        public uint dwSubjectType;

        /// void*
        public IntPtr pvSubject;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_ENTRY
    {

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SubjectIdentifier;

        /// DWORD->unsigned int
        public uint cAttribute;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgAttribute;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_CONTEXT
    {

        /// DWORD->unsigned int
        public uint dwMsgAndCertEncodingType;

        /// BYTE*
        public IntPtr pbCtlEncoded;

        /// DWORD->unsigned int
        public uint cbCtlEncoded;

        /// PCTL_INFO->_CTL_INFO*
        public IntPtr pCtlInfo;

        /// HCERTSTORE->void*
        public IntPtr hCertStore;

        /// HCRYPTMSG->void*
        public IntPtr hCryptMsg;

        /// BYTE*
        public IntPtr pbCtlContent;

        /// DWORD->unsigned int
        public uint cbCtlContent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CTL_ANY_SUBJECT_INFO
    {

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER SubjectAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SubjectIdentifier;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CS_STUB_INFO
    {

        /// unsigned int
        public uint WireCodeset;

        /// unsigned int
        public uint DesiredReceivingCodeset;

        /// void*
        public IntPtr CSArrayInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_X942_OTHER_INFO
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszContentEncryptionObjId;

        /// BYTE[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbCounter;

        /// BYTE[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbKeyLength;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB PubInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_VERIFY_MESSAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgAndCertEncodingType;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// PFN_CRYPT_GET_SIGNER_CERTIFICATE
        public PFN_CRYPT_GET_SIGNER_CERTIFICATE pfnGetSignerCertificate;

        /// void*
        public IntPtr pvGetArg;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_URL_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwSyncDeltaTime;

        /// DWORD->unsigned int
        public uint cGroup;

        /// DWORD*
        public IntPtr rgcGroupEntry;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_URL_ARRAY
    {

        /// DWORD->unsigned int
        public uint cUrl;

        /// LPWSTR*
        public IntPtr rgwszUrl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ATTR_BLOB
    {

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE*
        public IntPtr pbData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_TIME_STAMP_REQUEST_INFO
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszTimeStampAlgorithm;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszContentType;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Content;

        /// DWORD->unsigned int
        public uint cAttribute;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgAttribute;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_SMIME_CAPABILITY
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Parameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_SMIME_CAPABILITIES
    {

        /// DWORD->unsigned int
        public uint cCapability;

        /// PCRYPT_SMIME_CAPABILITY->_CRYPT_SMIME_CAPABILITY*
        public IntPtr rgCapability;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_SIGN_MESSAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgEncodingType;

        /// PCCERT_CONTEXT->CERT_CONTEXT*
        public IntPtr pSigningCert;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// void*
        public IntPtr pvHashAuxInfo;

        /// DWORD->unsigned int
        public uint cMsgCert;

        /// PCCERT_CONTEXT*
        public IntPtr rgpMsgCert;

        /// DWORD->unsigned int
        public uint cMsgCrl;

        /// PCCRL_CONTEXT*
        public IntPtr rgpMsgCrl;

        /// DWORD->unsigned int
        public uint cAuthAttr;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgAuthAttr;

        /// DWORD->unsigned int
        public uint cUnauthAttr;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgUnauthAttr;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwInnerContentType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_SEQUENCE_OF_ANY
    {

        /// DWORD->unsigned int
        public uint cValue;

        /// PCRYPT_DER_BLOB->_CRYPTOAPI_BLOB*
        public IntPtr rgValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_RETRIEVE_AUX_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// FILETIME*
        public IntPtr pLastSyncTime;

        /// DWORD->unsigned int
        public uint dwMaxUrlRetrievalByteCount;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CRYPT_RC4_KEY_STATE
    {

        /// unsigned char[16]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string Key;

        /// unsigned char[256]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string SBox;

        /// unsigned char
        public byte i;

        /// unsigned char
        public byte j;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_RC2_CBC_PARAMETERS
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fIV;

        /// BYTE[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbIV;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_PRIVATE_KEY_INFO
    {

        /// DWORD->unsigned int
        public uint Version;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER Algorithm;

        /// CRYPT_DER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB PrivateKey;

        /// PCRYPT_ATTRIBUTES->_CRYPT_ATTRIBUTES*
        public IntPtr pAttributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_PRIVATE_KEY_BLOB_AND_PARAMS
    {

        /// CRYPT_DIGEST_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB PrivateKey;

        /// PCRYPT_RESOLVE_HCRYPTPROV_FUNC
        public PCRYPT_RESOLVE_HCRYPTPROV_FUNC pResolvehCryptProvFunc;

        /// LPVOID->void*
        public IntPtr pVoidResolveFunc;

        /// PCRYPT_DECRYPT_PRIVATE_KEY_FUNC
        public PCRYPT_DECRYPT_PRIVATE_KEY_FUNC pDecryptPrivateKeyFunc;

        /// LPVOID->void*
        public IntPtr pVoidDecryptFunc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_PKCS8_EXPORT_PARAMS
    {

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszPrivateKeyObjId;

        /// PCRYPT_ENCRYPT_PRIVATE_KEY_FUNC
        public PCRYPT_ENCRYPT_PRIVATE_KEY_FUNC pEncryptPrivateKeyFunc;

        /// LPVOID->void*
        public IntPtr pVoidEncryptFunc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_PASSWORD_CREDENTIALSW
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszUsername;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszPassword;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_PASSWORD_CREDENTIALSA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszUsername;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszPassword;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_OID_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszOID;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszName;

        /// DWORD->unsigned int
        public uint dwGroupId;

        /// Anonymous_a3ae7823_8a1d_432c_bc07_a72b6fc6c7d8
        public Anonymous_a3ae7823_8a1d_432c_bc07_a72b6fc6c7d8 Union1;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB ExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_OID_FUNC_ENTRY
    {

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszOID;

        /// void*
        public IntPtr pvFuncAddr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_OBJID_TABLE
    {

        /// DWORD->unsigned int
        public uint dwAlgId;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_KEY_VERIFY_MESSAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgEncodingType;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_KEY_SIGN_MESSAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgAndCertEncodingType;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// void*
        public IntPtr pvHashAuxInfo;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER PubKeyAlgorithm;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_KEY_PROV_PARAM
    {

        /// DWORD->unsigned int
        public uint dwParam;

        /// BYTE*
        public IntPtr pbData;

        /// DWORD->unsigned int
        public uint cbData;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_KEY_PROV_INFO
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszContainerName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszProvName;

        /// DWORD->unsigned int
        public uint dwProvType;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint cProvParam;

        /// PCRYPT_KEY_PROV_PARAM->_CRYPT_KEY_PROV_PARAM*
        public IntPtr rgProvParam;

        /// DWORD->unsigned int
        public uint dwKeySpec;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_HASH_MESSAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgEncodingType;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// void*
        public IntPtr pvHashAuxInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_HASH_INFO
    {

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// CRYPT_HASH_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Hash;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ENROLLMENT_NAME_VALUE_PAIR
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszName;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ENCRYPT_MESSAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgEncodingType;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

        /// void*
        public IntPtr pvEncryptionAuxInfo;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwInnerContentType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ENCRYPTED_PRIVATE_KEY_INFO
    {

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER EncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedPrivateKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ENCODE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PFN_CRYPT_ALLOC
        public PFN_CRYPT_ALLOC pfnAlloc;

        /// PFN_CRYPT_FREE
        public PFN_CRYPT_FREE pfnFree;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CRYPT_DES_KEY_STATE
    {

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string Key;

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string IV;

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string Feedback;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_DEFAULT_CONTEXT_MULTI_OID_PARA
    {

        /// DWORD->unsigned int
        public uint cOID;

        /// LPSTR*
        public IntPtr rgpszOID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_DECRYPT_MESSAGE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgAndCertEncodingType;

        /// DWORD->unsigned int
        public uint cCertStore;

        /// HCERTSTORE*
        public IntPtr rghCertStore;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_DECODE_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PFN_CRYPT_ALLOC
        public PFN_CRYPT_ALLOC pfnAlloc;

        /// PFN_CRYPT_FREE
        public PFN_CRYPT_FREE pfnFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_CSP_PROVIDER
    {

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszProviderName;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB Signature;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_CREDENTIALS
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszCredentialsOid;

        /// LPVOID->void*
        public IntPtr pvCredentials;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_CONTENT_INFO_SEQUENCE_OF_ANY
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// DWORD->unsigned int
        public uint cValue;

        /// PCRYPT_DER_BLOB->_CRYPTOAPI_BLOB*
        public IntPtr rgValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_CONTENT_INFO
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// CRYPT_DER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Content;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_BLOB_ARRAY
    {

        /// DWORD->unsigned int
        public uint cBlob;

        /// PCRYPT_DATA_BLOB->_CRYPTOAPI_BLOB*
        public IntPtr rgBlob;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_BIT_BLOB
    {

        /// DWORD->unsigned int
        public uint cbData;

        /// BYTE*
        public IntPtr pbData;

        /// DWORD->unsigned int
        public uint cUnusedBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ATTRIBUTE_TYPE_VALUE
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ATTRIBUTES
    {

        /// DWORD->unsigned int
        public uint cAttr;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgAttr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ATTRIBUTE
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// DWORD->unsigned int
        public uint cValue;

        /// PCRYPT_ATTR_BLOB->_CRYPTOAPI_BLOB*
        public IntPtr rgValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ASYNC_RETRIEVAL_COMPLETION
    {

        /// PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC
        public PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC pfnCompletion;

        /// LPVOID->void*
        public IntPtr pvCompletion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPT_ALGORITHM_IDENTIFIER
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Parameters;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CRYPT_3DES_KEY_STATE
    {

        /// unsigned char[24]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 24)]
        public string Key;

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string IV;

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string Feedback;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRYPTPROTECT_PROMPTSTRUCT
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwPromptFlags;

        /// HWND->HWND__*
        public IntPtr hwndApp;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szPrompt;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CROSS_CERT_DIST_POINTS_INFO
    {

        /// DWORD->unsigned int
        public uint dwSyncDeltaTime;

        /// DWORD->unsigned int
        public uint cDistPoint;

        /// PCERT_ALT_NAME_INFO->_CERT_ALT_NAME_INFO*
        public IntPtr rgDistPoint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_REVOCATION_INFO
    {

        /// PCRL_ENTRY->_CRL_ENTRY*
        public IntPtr pCrlEntry;

        /// PCCRL_CONTEXT->CRL_CONTEXT*
        public IntPtr pCrlContext;

        /// PCCERT_CHAIN_CONTEXT->CERT_CHAIN_CONTEXT*
        public IntPtr pCrlIssuerChain;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_ISSUING_DIST_POINT
    {

        /// CRL_DIST_POINT_NAME->_CRL_DIST_POINT_NAME
        public CRL_DIST_POINT_NAME DistPointName;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fOnlyContainsUserCerts;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fOnlyContainsCACerts;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB OnlySomeReasonFlags;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fIndirectCRL;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Issuer;

        /// FILETIME->_FILETIME
        public FILETIME ThisUpdate;

        /// FILETIME->_FILETIME
        public FILETIME NextUpdate;

        /// DWORD->unsigned int
        public uint cCRLEntry;

        /// PCRL_ENTRY->_CRL_ENTRY*
        public IntPtr rgCRLEntry;

        /// DWORD->unsigned int
        public uint cExtension;

        /// PCERT_EXTENSION->_CERT_EXTENSION*
        public IntPtr rgExtension;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_FIND_ISSUED_FOR_PARA
    {

        /// PCCERT_CONTEXT->CERT_CONTEXT*
        public IntPtr pSubjectCert;

        /// PCCERT_CONTEXT->CERT_CONTEXT*
        public IntPtr pIssuerCert;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_ENTRY
    {

        /// CRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SerialNumber;

        /// FILETIME->_FILETIME
        public FILETIME RevocationDate;

        /// DWORD->unsigned int
        public uint cExtension;

        /// PCERT_EXTENSION->_CERT_EXTENSION*
        public IntPtr rgExtension;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_DIST_POINT_NAME
    {

        /// DWORD->unsigned int
        public uint dwDistPointNameChoice;

        /// Anonymous_1601fc15_53ff_4fde_8559_0bc744288a1c
        public Anonymous_1601fc15_53ff_4fde_8559_0bc744288a1c Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_DIST_POINTS_INFO
    {

        /// DWORD->unsigned int
        public uint cDistPoint;

        /// PCRL_DIST_POINT->_CRL_DIST_POINT*
        public IntPtr rgDistPoint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_DIST_POINT
    {

        /// CRL_DIST_POINT_NAME->_CRL_DIST_POINT_NAME
        public CRL_DIST_POINT_NAME DistPointName;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB ReasonFlags;

        /// CERT_ALT_NAME_INFO->_CERT_ALT_NAME_INFO
        public CERT_ALT_NAME_INFO CRLIssuer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CRL_CONTEXT
    {

        /// DWORD->unsigned int
        public uint dwCertEncodingType;

        /// BYTE*
        public IntPtr pbCrlEncoded;

        /// DWORD->unsigned int
        public uint cbCrlEncoded;

        /// PCRL_INFO->_CRL_INFO*
        public IntPtr pCrlInfo;

        /// HCERTSTORE->void*
        public IntPtr hCertStore;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_USN_JOURNAL_DATA
    {

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong MaximumSize;

        /// DWORDLONG->ULONGLONG->unsigned __int64
        public ulong AllocationDelta;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_THREAD_DEBUG_INFO
    {

        /// HANDLE->void*
        public IntPtr hThread;

        /// LPVOID->void*
        public IntPtr lpThreadLocalBase;

        /// LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        public PTHREAD_START_ROUTINE lpStartAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_PROCESS_DEBUG_INFO
    {

        /// HANDLE->void*
        public IntPtr hFile;

        /// HANDLE->void*
        public IntPtr hProcess;

        /// HANDLE->void*
        public IntPtr hThread;

        /// LPVOID->void*
        public IntPtr lpBaseOfImage;

        /// DWORD->unsigned int
        public uint dwDebugInfoFileOffset;

        /// DWORD->unsigned int
        public uint nDebugInfoSize;

        /// LPVOID->void*
        public IntPtr lpThreadLocalBase;

        /// LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        public PTHREAD_START_ROUTINE lpStartAddress;

        /// LPVOID->void*
        public IntPtr lpImageName;

        /// WORD->unsigned short
        public ushort fUnicode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_DISK_MBR
    {

        /// DWORD->unsigned int
        public uint Signature;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_DISK_GPT
    {

        /// GUID->_GUID
        public GUID DiskId;

        /// DWORD->unsigned int
        public uint MaxPartitionCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_DISK
    {

        /// PARTITION_STYLE->_PARTITION_STYLE
        public PARTITION_STYLE PartitionStyle;

        /// Anonymous_985b65de_68af_45f8_afd4_03cbaac03ace
        public Anonymous_985b65de_68af_45f8_afd4_03cbaac03ace Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CPS_URLS
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszURL;

        /// CRYPT_ALGORITHM_IDENTIFIER*
        public IntPtr pAlgorithm;

        /// CRYPT_DATA_BLOB*
        public IntPtr pDigest;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CPINFOEXW
    {

        /// UINT->unsigned int
        public uint MaxCharSize;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] DefaultChar;

        /// BYTE[12]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
        public byte[] LeadByte;

        /// WCHAR->wchar_t->unsigned short
        public ushort UnicodeDefaultChar;

        /// UINT->unsigned int
        public uint CodePage;

        /// WCHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string CodePageName;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CPINFOEXA
    {

        /// UINT->unsigned int
        public uint MaxCharSize;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] DefaultChar;

        /// BYTE[12]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
        public byte[] LeadByte;

        /// WCHAR->wchar_t->unsigned short
        public ushort UnicodeDefaultChar;

        /// UINT->unsigned int
        public uint CodePage;

        /// CHAR[260]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string CodePageName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CPINFO
    {

        /// UINT->unsigned int
        public uint MaxCharSize;

        /// BYTE[2]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] DefaultChar;

        /// BYTE[12]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
        public byte[] LeadByte;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COSERVERINFO
    {

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszName;

        /// COAUTHINFO*
        public IntPtr pAuthInfo;

        /// DWORD->unsigned int
        public uint dwReserved2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {

        /// SHORT->short
        public short X;

        /// SHORT->short
        public short Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONTEXT
    {

        /// DWORD->unsigned int
        public uint ContextFlags;

        /// DWORD->unsigned int
        public uint Dr0;

        /// DWORD->unsigned int
        public uint Dr1;

        /// DWORD->unsigned int
        public uint Dr2;

        /// DWORD->unsigned int
        public uint Dr3;

        /// DWORD->unsigned int
        public uint Dr6;

        /// DWORD->unsigned int
        public uint Dr7;

        /// FLOATING_SAVE_AREA->_FLOATING_SAVE_AREA
        public FLOATING_SAVE_AREA FloatSave;

        /// DWORD->unsigned int
        public uint SegGs;

        /// DWORD->unsigned int
        public uint SegFs;

        /// DWORD->unsigned int
        public uint SegEs;

        /// DWORD->unsigned int
        public uint SegDs;

        /// DWORD->unsigned int
        public uint Edi;

        /// DWORD->unsigned int
        public uint Esi;

        /// DWORD->unsigned int
        public uint Ebx;

        /// DWORD->unsigned int
        public uint Edx;

        /// DWORD->unsigned int
        public uint Ecx;

        /// DWORD->unsigned int
        public uint Eax;

        /// DWORD->unsigned int
        public uint Ebp;

        /// DWORD->unsigned int
        public uint Eip;

        /// DWORD->unsigned int
        public uint SegCs;

        /// DWORD->unsigned int
        public uint EFlags;

        /// DWORD->unsigned int
        public uint Esp;

        /// DWORD->unsigned int
        public uint SegSs;

        /// BYTE[512]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.I1)]
        public byte[] ExtendedRegisters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SELECTION_INFO
    {

        /// DWORD->unsigned int
        public uint dwFlags;

        /// COORD->_COORD
        public COORD dwSelectionAnchor;

        /// SMALL_RECT->_SMALL_RECT
        public SMALL_RECT srSelection;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SCREEN_BUFFER_INFO
    {

        /// COORD->_COORD
        public COORD dwSize;

        /// COORD->_COORD
        public COORD dwCursorPosition;

        /// WORD->unsigned short
        public ushort wAttributes;

        /// SMALL_RECT->_SMALL_RECT
        public SMALL_RECT srWindow;

        /// COORD->_COORD
        public COORD dwMaximumWindowSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFO
    {

        /// DWORD->unsigned int
        public uint nFont;

        /// COORD->_COORD
        public COORD dwFontSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_CURSOR_INFO
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool bVisible;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONNECTDLGSTRUCTW
    {

        /// DWORD->unsigned int
        public uint cbStructure;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// LPNETRESOURCEW->_NETRESOURCEW*
        public IntPtr lpConnRes;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwDevNum;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CONNECTDLGSTRUCTA
    {

        /// DWORD->unsigned int
        public uint cbStructure;

        /// HWND->HWND__*
        public IntPtr hwndOwner;

        /// LPNETRESOURCEA->_NETRESOURCEA*
        public IntPtr lpConnRes;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwDevNum;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COMSTAT
    {

        /// fCtsHold : 1
        ///fDsrHold : 1
        ///fRlsdHold : 1
        ///fXoffHold : 1
        ///fXoffSent : 1
        ///fEof : 1
        ///fTxim : 1
        ///fReserved : 25
        public uint bitvector1;

        /// DWORD->unsigned int
        public uint cbInQue;

        /// DWORD->unsigned int
        public uint cbOutQue;

        public uint fCtsHold
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

        public uint fDsrHold
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

        public uint fRlsdHold
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4u)
                            / 4)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 4)
                            | this.bitvector1)));
            }
        }

        public uint fXoffHold
        {
            get
            {
                return ((uint)(((this.bitvector1 & 8u)
                            / 8)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 8)
                            | this.bitvector1)));
            }
        }

        public uint fXoffSent
        {
            get
            {
                return ((uint)(((this.bitvector1 & 16u)
                            / 16)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 16)
                            | this.bitvector1)));
            }
        }

        public uint fEof
        {
            get
            {
                return ((uint)(((this.bitvector1 & 32u)
                            / 32)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 32)
                            | this.bitvector1)));
            }
        }

        public uint fTxim
        {
            get
            {
                return ((uint)(((this.bitvector1 & 64u)
                            / 64)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 64)
                            | this.bitvector1)));
            }
        }

        public uint fReserved
        {
            get
            {
                return ((uint)(((this.bitvector1 & 4294967168u)
                            / 128)));
            }
            set
            {
                this.bitvector1 = ((uint)(((value * 128)
                            | this.bitvector1)));
            }
        }
    }

    public enum COMPUTER_NAME_FORMAT
    {

        ComputerNameNetBIOS,

        ComputerNameDnsHostname,

        ComputerNameDnsDomain,

        ComputerNameDnsFullyQualified,

        ComputerNamePhysicalNetBIOS,

        ComputerNamePhysicalDnsHostname,

        ComputerNamePhysicalDnsDomain,

        ComputerNamePhysicalDnsFullyQualified,

        ComputerNameMax,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COMM_FAULT_OFFSETS
    {

        /// short
        public short CommOffset;

        /// short
        public short FaultOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COMMTIMEOUTS
    {

        /// DWORD->unsigned int
        public uint ReadIntervalTimeout;

        /// DWORD->unsigned int
        public uint ReadTotalTimeoutMultiplier;

        /// DWORD->unsigned int
        public uint ReadTotalTimeoutConstant;

        /// DWORD->unsigned int
        public uint WriteTotalTimeoutMultiplier;

        /// DWORD->unsigned int
        public uint WriteTotalTimeoutConstant;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct COMMPROP
    {

        /// WORD->unsigned short
        public ushort wPacketLength;

        /// WORD->unsigned short
        public ushort wPacketVersion;

        /// DWORD->unsigned int
        public uint dwServiceMask;

        /// DWORD->unsigned int
        public uint dwReserved1;

        /// DWORD->unsigned int
        public uint dwMaxTxQueue;

        /// DWORD->unsigned int
        public uint dwMaxRxQueue;

        /// DWORD->unsigned int
        public uint dwMaxBaud;

        /// DWORD->unsigned int
        public uint dwProvSubType;

        /// DWORD->unsigned int
        public uint dwProvCapabilities;

        /// DWORD->unsigned int
        public uint dwSettableParams;

        /// DWORD->unsigned int
        public uint dwSettableBaud;

        /// WORD->unsigned short
        public ushort wSettableData;

        /// WORD->unsigned short
        public ushort wSettableStopParity;

        /// DWORD->unsigned int
        public uint dwCurrentTxQueue;

        /// DWORD->unsigned int
        public uint dwCurrentRxQueue;

        /// DWORD->unsigned int
        public uint dwProvSpec1;

        /// DWORD->unsigned int
        public uint dwProvSpec2;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string wcProvChar;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct COMMCONFIG
    {

        /// DWORD->unsigned int
        public uint dwSize;

        /// WORD->unsigned short
        public ushort wVersion;

        /// WORD->unsigned short
        public ushort wReserved;

        /// DCB->_DCB
        public DCB dcb;

        /// DWORD->unsigned int
        public uint dwProviderSubType;

        /// DWORD->unsigned int
        public uint dwProviderOffset;

        /// DWORD->unsigned int
        public uint dwProviderSize;

        /// WCHAR[1]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string wcProviderData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CODEBASEHOLD
    {

        /// ULONG->unsigned int
        public uint cbSize;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szDistUnit;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string szCodeBase;

        /// DWORD->unsigned int
        public uint dwVersionMS;

        /// DWORD->unsigned int
        public uint dwVersionLS;

        /// DWORD->unsigned int
        public uint dwStyle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COAUTHINFO
    {

        /// DWORD->unsigned int
        public uint dwAuthnSvc;

        /// DWORD->unsigned int
        public uint dwAuthzSvc;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszServerPrincName;

        /// DWORD->unsigned int
        public uint dwAuthnLevel;

        /// DWORD->unsigned int
        public uint dwImpersonationLevel;

        /// COAUTHIDENTITY*
        public IntPtr pAuthIdentityData;

        /// DWORD->unsigned int
        public uint dwCapabilities;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COAUTHIDENTITY
    {

        /// USHORT*
        public IntPtr User;

        /// ULONG->unsigned int
        public uint UserLength;

        /// USHORT*
        public IntPtr Domain;

        /// ULONG->unsigned int
        public uint DomainLength;

        /// USHORT*
        public IntPtr Password;

        /// ULONG->unsigned int
        public uint PasswordLength;

        /// ULONG->unsigned int
        public uint Flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMS_KEY_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// ALG_ID->unsigned int
        public uint Algid;

        /// BYTE*
        public IntPtr pbOID;

        /// DWORD->unsigned int
        public uint cbOID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMS_DH_KEY_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// ALG_ID->unsigned int
        public uint Algid;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszContentEncObjId;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB PubInfo;

        /// void*
        public IntPtr pReserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_STREAM_INFO
    {

        /// DWORD->unsigned int
        public uint cbContent;

        /// PFN_CMSG_STREAM_OUTPUT
        public PFN_CMSG_STREAM_OUTPUT pfnStreamOutput;

        /// void*
        public IntPtr pvArg;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_SP3_COMPATIBLE_AUX_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_SIGNER_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Issuer;

        /// CRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SerialNumber;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedHash;

        /// CRYPT_ATTRIBUTES->_CRYPT_ATTRIBUTES
        public CRYPT_ATTRIBUTES AuthAttrs;

        /// CRYPT_ATTRIBUTES->_CRYPT_ATTRIBUTES
        public CRYPT_ATTRIBUTES UnauthAttrs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_SIGNER_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PCERT_INFO->_CERT_INFO*
        public IntPtr pCertInfo;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// void*
        public IntPtr pvHashAuxInfo;

        /// DWORD->unsigned int
        public uint cAuthAttr;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgAuthAttr;

        /// DWORD->unsigned int
        public uint cUnauthAttr;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgUnauthAttr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_SIGNED_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint cSigners;

        /// PCMSG_SIGNER_ENCODE_INFO->_CMSG_SIGNER_ENCODE_INFO*
        public IntPtr rgSigners;

        /// DWORD->unsigned int
        public uint cCertEncoded;

        /// PCERT_BLOB->_CRYPTOAPI_BLOB*
        public IntPtr rgCertEncoded;

        /// DWORD->unsigned int
        public uint cCrlEncoded;

        /// PCRL_BLOB->_CRYPTOAPI_BLOB*
        public IntPtr rgCrlEncoded;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_SIGNED_AND_ENVELOPED_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CMSG_SIGNED_ENCODE_INFO->_CMSG_SIGNED_ENCODE_INFO
        public CMSG_SIGNED_ENCODE_INFO SignedInfo;

        /// CMSG_ENVELOPED_ENCODE_INFO->_CMSG_ENVELOPED_ENCODE_INFO
        public CMSG_ENVELOPED_ENCODE_INFO EnvelopedInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_RECIPIENT_ENCRYPTED_KEY_INFO
    {

        /// CERT_ID->_CERT_ID
        public CERT_ID RecipientId;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedKey;

        /// FILETIME->_FILETIME
        public FILETIME Date;

        /// PCRYPT_ATTRIBUTE_TYPE_VALUE->_CRYPT_ATTRIBUTE_TYPE_VALUE*
        public IntPtr pOtherAttr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB RecipientPublicKey;

        /// CERT_ID->_CERT_ID
        public CERT_ID RecipientId;

        /// FILETIME->_FILETIME
        public FILETIME Date;

        /// PCRYPT_ATTRIBUTE_TYPE_VALUE->_CRYPT_ATTRIBUTE_TYPE_VALUE*
        public IntPtr pOtherAttr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_RECIPIENT_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint dwRecipientChoice;

        /// Anonymous_9ca4478c_b7fb_4748_b3ff_66088946049b
        public Anonymous_9ca4478c_b7fb_4748_b3ff_66088946049b Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_RC4_AUX_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwBitLen;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_RC2_AUX_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwBitLen;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_MAIL_LIST_RECIPIENT_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB KeyId;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedKey;

        /// FILETIME->_FILETIME
        public FILETIME Date;

        /// PCRYPT_ATTRIBUTE_TYPE_VALUE->_CRYPT_ATTRIBUTE_TYPE_VALUE*
        public IntPtr pOtherAttr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_MAIL_LIST_RECIPIENT_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// void*
        public IntPtr pvKeyEncryptionAuxInfo;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeyChoice;

        /// Anonymous_2842b733_4922_41bc_a227_1c9bafdb7271
        public Anonymous_2842b733_4922_41bc_a227_1c9bafdb7271 Union1;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB KeyId;

        /// FILETIME->_FILETIME
        public FILETIME Date;

        /// PCRYPT_ATTRIBUTE_TYPE_VALUE->_CRYPT_ATTRIBUTE_TYPE_VALUE*
        public IntPtr pOtherAttr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_MAIL_LIST_ENCRYPT_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwRecipientIndex;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedKey;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_KEY_TRANS_RECIPIENT_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CERT_ID->_CERT_ID
        public CERT_ID RecipientId;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_KEY_TRANS_RECIPIENT_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// void*
        public IntPtr pvKeyEncryptionAuxInfo;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB RecipientPublicKey;

        /// CERT_ID->_CERT_ID
        public CERT_ID RecipientId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_KEY_TRANS_ENCRYPT_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwRecipientIndex;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedKey;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_KEY_AGREE_RECIPIENT_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// DWORD->unsigned int
        public uint dwOriginatorChoice;

        /// Anonymous_2a1aa424_7c4b_4b99_a886_35278aac8963
        public Anonymous_2a1aa424_7c4b_4b99_a886_35278aac8963 Union1;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB UserKeyingMaterial;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// DWORD->unsigned int
        public uint cRecipientEncryptedKeys;

        /// PCMSG_RECIPIENT_ENCRYPTED_KEY_INFO*
        public IntPtr rgpRecipientEncryptedKeys;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_KEY_AGREE_RECIPIENT_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// void*
        public IntPtr pvKeyEncryptionAuxInfo;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyWrapAlgorithm;

        /// void*
        public IntPtr pvKeyWrapAuxInfo;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// DWORD->unsigned int
        public uint dwKeyChoice;

        /// Anonymous_57577a68_32f1_4b39_9314_4bacfa47bb2b
        public Anonymous_57577a68_32f1_4b39_9314_4bacfa47bb2b Union1;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB UserKeyingMaterial;

        /// DWORD->unsigned int
        public uint cRecipientEncryptedKeys;

        /// PCMSG_RECIPIENT_ENCRYPTED_KEY_ENCODE_INFO*
        public IntPtr rgpRecipientEncryptedKeys;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_KEY_AGREE_KEY_ENCRYPT_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_KEY_AGREE_ENCRYPT_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwRecipientIndex;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB UserKeyingMaterial;

        /// DWORD->unsigned int
        public uint dwOriginatorChoice;

        /// Anonymous_f34bda71_2d59_45fc_a121_bbed90a7be1e
        public Anonymous_f34bda71_2d59_45fc_a121_bbed90a7be1e Union1;

        /// DWORD->unsigned int
        public uint cKeyAgreeKeyEncryptInfo;

        /// PCMSG_KEY_AGREE_KEY_ENCRYPT_INFO*
        public IntPtr rgpKeyAgreeKeyEncryptInfo;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_HASHED_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// void*
        public IntPtr pvHashAuxInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_ENVELOPED_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

        /// void*
        public IntPtr pvEncryptionAuxInfo;

        /// DWORD->unsigned int
        public uint cRecipients;

        /// PCERT_INFO*
        public IntPtr rgpRecipients;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_ENCRYPTED_ENCODE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

        /// void*
        public IntPtr pvEncryptionAuxInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwSignerIndex;

        /// DWORD->unsigned int
        public uint dwSignerType;

        /// void*
        public IntPtr pvSigner;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CTRL_MAIL_LIST_DECRYPT_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// PCMSG_MAIL_LIST_RECIPIENT_INFO->_CMSG_MAIL_LIST_RECIPIENT_INFO*
        public IntPtr pMailList;

        /// DWORD->unsigned int
        public uint dwRecipientIndex;

        /// DWORD->unsigned int
        public uint dwKeyChoice;

        /// Anonymous_af7ff830_64ee_4e0f_a1bd_adae73ad26ee
        public Anonymous_af7ff830_64ee_4e0f_a1bd_adae73ad26ee Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CTRL_KEY_TRANS_DECRYPT_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// PCMSG_KEY_TRANS_RECIPIENT_INFO->_CMSG_KEY_TRANS_RECIPIENT_INFO*
        public IntPtr pKeyTrans;

        /// DWORD->unsigned int
        public uint dwRecipientIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CTRL_KEY_AGREE_DECRYPT_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// PCMSG_KEY_AGREE_RECIPIENT_INFO->_CMSG_KEY_AGREE_RECIPIENT_INFO*
        public IntPtr pKeyAgree;

        /// DWORD->unsigned int
        public uint dwRecipientIndex;

        /// DWORD->unsigned int
        public uint dwRecipientEncryptedKeyIndex;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB OriginatorPublicKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwSignerIndex;

        /// DWORD->unsigned int
        public uint dwUnauthAttrIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CTRL_DECRYPT_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// DWORD->unsigned int
        public uint dwRecipientIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwSignerIndex;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB blob;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CONTENT_ENCRYPT_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

        /// void*
        public IntPtr pvEncryptionAuxInfo;

        /// DWORD->unsigned int
        public uint cRecipients;

        /// PCMSG_RECIPIENT_ENCODE_INFO->_CMSG_RECIPIENT_ENCODE_INFO*
        public IntPtr rgCmsRecipients;

        /// PFN_CMSG_ALLOC
        public PFN_CMSG_ALLOC pfnAlloc;

        /// PFN_CMSG_FREE
        public PFN_CMSG_FREE pfnFree;

        /// DWORD->unsigned int
        public uint dwEncryptFlags;

        /// HCRYPTKEY->ULONG_PTR->unsigned int
        public uint hContentEncryptKey;

        /// DWORD->unsigned int
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CMS_SIGNER_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CERT_ID->_CERT_ID
        public CERT_ID SignerId;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncryptedHash;

        /// CRYPT_ATTRIBUTES->_CRYPT_ATTRIBUTES
        public CRYPT_ATTRIBUTES AuthAttrs;

        /// CRYPT_ATTRIBUTES->_CRYPT_ATTRIBUTES
        public CRYPT_ATTRIBUTES UnauthAttrs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMSG_CMS_RECIPIENT_INFO
    {

        /// DWORD->unsigned int
        public uint dwRecipientChoice;

        /// Anonymous_d1088fd3_1611_4816_8fb1_97de0a4a366d
        public Anonymous_d1088fd3_1611_4816_8fb1_97de0a4a366d Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_TAGGED_REQUEST
    {

        /// DWORD->unsigned int
        public uint dwTaggedRequestChoice;

        /// Anonymous_ff24905c_f69f_47bb_bc6c_cb0737f3e649
        public Anonymous_ff24905c_f69f_47bb_bc6c_cb0737f3e649 Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_TAGGED_OTHER_MSG
    {

        /// DWORD->unsigned int
        public uint dwBodyPartID;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_TAGGED_CONTENT_INFO
    {

        /// DWORD->unsigned int
        public uint dwBodyPartID;

        /// CRYPT_DER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB EncodedContentInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_TAGGED_CERT_REQUEST
    {

        /// DWORD->unsigned int
        public uint dwBodyPartID;

        /// CRYPT_DER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SignedCertRequest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_TAGGED_ATTRIBUTE
    {

        /// DWORD->unsigned int
        public uint dwBodyPartID;

        /// CRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE
        public CRYPT_ATTRIBUTE Attribute;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_STATUS_INFO
    {

        /// DWORD->unsigned int
        public uint dwStatus;

        /// DWORD->unsigned int
        public uint cBodyList;

        /// DWORD*
        public IntPtr rgdwBodyList;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszStatusString;

        /// DWORD->unsigned int
        public uint dwOtherInfoChoice;

        /// Anonymous_ddcff603_a053_488b_b924_0d3c694e001a
        public Anonymous_ddcff603_a053_488b_b924_0d3c694e001a Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_RESPONSE_INFO
    {

        /// DWORD->unsigned int
        public uint cTaggedAttribute;

        /// PCMC_TAGGED_ATTRIBUTE->_CMC_TAGGED_ATTRIBUTE*
        public IntPtr rgTaggedAttribute;

        /// DWORD->unsigned int
        public uint cTaggedContentInfo;

        /// PCMC_TAGGED_CONTENT_INFO->_CMC_TAGGED_CONTENT_INFO*
        public IntPtr rgTaggedContentInfo;

        /// DWORD->unsigned int
        public uint cTaggedOtherMsg;

        /// PCMC_TAGGED_OTHER_MSG->_CMC_TAGGED_OTHER_MSG*
        public IntPtr rgTaggedOtherMsg;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_PEND_INFO
    {

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB PendToken;

        /// FILETIME->_FILETIME
        public FILETIME PendTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_DATA_INFO
    {

        /// DWORD->unsigned int
        public uint cTaggedAttribute;

        /// PCMC_TAGGED_ATTRIBUTE->_CMC_TAGGED_ATTRIBUTE*
        public IntPtr rgTaggedAttribute;

        /// DWORD->unsigned int
        public uint cTaggedRequest;

        /// PCMC_TAGGED_REQUEST->_CMC_TAGGED_REQUEST*
        public IntPtr rgTaggedRequest;

        /// DWORD->unsigned int
        public uint cTaggedContentInfo;

        /// PCMC_TAGGED_CONTENT_INFO->_CMC_TAGGED_CONTENT_INFO*
        public IntPtr rgTaggedContentInfo;

        /// DWORD->unsigned int
        public uint cTaggedOtherMsg;

        /// PCMC_TAGGED_OTHER_MSG->_CMC_TAGGED_OTHER_MSG*
        public IntPtr rgTaggedOtherMsg;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_ADD_EXTENSIONS_INFO
    {

        /// DWORD->unsigned int
        public uint dwCmcDataReference;

        /// DWORD->unsigned int
        public uint cCertReference;

        /// DWORD*
        public IntPtr rgdwCertReference;

        /// DWORD->unsigned int
        public uint cExtension;

        /// PCERT_EXTENSION->_CERT_EXTENSION*
        public IntPtr rgExtension;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CMC_ADD_ATTRIBUTES_INFO
    {

        /// DWORD->unsigned int
        public uint dwCmcDataReference;

        /// DWORD->unsigned int
        public uint cCertReference;

        /// DWORD*
        public IntPtr rgdwCertReference;

        /// DWORD->unsigned int
        public uint cAttribute;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgAttribute;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CLIENT_CALL_RETURN
    {

        /// void*
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public IntPtr Pointer;

        /// LONG_PTR->int
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int Simple;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CLASS_MEDIA_CHANGE_CONTEXT
    {

        /// DWORD->unsigned int
        public uint MediaChangeCount;

        /// DWORD->unsigned int
        public uint NewState;
    }

    public enum CIP_STATUS
    {

        /// CIP_DISK_FULL -> 0
        CIP_DISK_FULL = 0,

        /// CIP_ACCESS_DENIED -> CIP_DISK_FULL+1
        CIP_ACCESS_DENIED = (CIP_STATUS.CIP_DISK_FULL + 1),

        /// CIP_NEWER_VERSION_EXISTS -> CIP_ACCESS_DENIED+1
        CIP_NEWER_VERSION_EXISTS = (CIP_STATUS.CIP_ACCESS_DENIED + 1),

        /// CIP_OLDER_VERSION_EXISTS -> CIP_NEWER_VERSION_EXISTS+1
        CIP_OLDER_VERSION_EXISTS = (CIP_STATUS.CIP_NEWER_VERSION_EXISTS + 1),

        /// CIP_NAME_CONFLICT -> CIP_OLDER_VERSION_EXISTS+1
        CIP_NAME_CONFLICT = (CIP_STATUS.CIP_OLDER_VERSION_EXISTS + 1),

        /// CIP_TRUST_VERIFICATION_COMPONENT_MISSING -> CIP_NAME_CONFLICT+1
        CIP_TRUST_VERIFICATION_COMPONENT_MISSING = (CIP_STATUS.CIP_NAME_CONFLICT + 1),

        /// CIP_EXE_SELF_REGISTERATION_TIMEOUT -> CIP_TRUST_VERIFICATION_COMPONENT_MISSING+1
        CIP_EXE_SELF_REGISTERATION_TIMEOUT = (CIP_STATUS.CIP_TRUST_VERIFICATION_COMPONENT_MISSING + 1),

        /// CIP_UNSAFE_TO_ABORT -> CIP_EXE_SELF_REGISTERATION_TIMEOUT+1
        CIP_UNSAFE_TO_ABORT = (CIP_STATUS.CIP_EXE_SELF_REGISTERATION_TIMEOUT + 1),

        /// CIP_NEED_REBOOT -> CIP_UNSAFE_TO_ABORT+1
        CIP_NEED_REBOOT = (CIP_STATUS.CIP_UNSAFE_TO_ABORT + 1),

        /// CIP_NEED_REBOOT_UI_PERMISSION -> CIP_NEED_REBOOT+1
        CIP_NEED_REBOOT_UI_PERMISSION = (CIP_STATUS.CIP_NEED_REBOOT + 1),
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHAR_INFO
    {

        /// Anonymous_f3630dcb_df39_4f30_a593_48e610e9363d
        public Anonymous_f3630dcb_df39_4f30_a593_48e610e9363d Char;

        /// WORD->unsigned short
        public ushort Attributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_SET_POSITION
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Transport;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Destination;

        /// BOOLEAN->BYTE->unsigned char
        public byte Flip;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_SET_ACCESS
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Element;

        /// DWORD->unsigned int
        public uint Control;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_SEND_VOLUME_TAG_INFORMATION
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT StartingElement;

        /// DWORD->unsigned int
        public uint ActionCode;

        /// BYTE[40]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
        public byte[] VolumeIDTemplate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_READ_ELEMENT_STATUS
    {

        /// CHANGER_ELEMENT_LIST->_CHANGER_ELEMENT_LIST
        public CHANGER_ELEMENT_LIST ElementList;

        /// BOOLEAN->BYTE->unsigned char
        public byte VolumeTagInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_PRODUCT_DATA
    {

        /// BYTE[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
        public byte[] VendorId;

        /// BYTE[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] ProductId;

        /// BYTE[4]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
        public byte[] Revision;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] SerialNumber;

        /// BYTE->unsigned char
        public byte DeviceType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_MOVE_MEDIUM
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Transport;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Source;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Destination;

        /// BOOLEAN->BYTE->unsigned char
        public byte Flip;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_INITIALIZE_ELEMENT_STATUS
    {

        /// CHANGER_ELEMENT_LIST->_CHANGER_ELEMENT_LIST
        public CHANGER_ELEMENT_LIST ElementList;

        /// BOOLEAN->BYTE->unsigned char
        public byte BarCodeScan;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_EXCHANGE_MEDIUM
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Transport;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Source;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Destination1;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Destination2;

        /// BOOLEAN->BYTE->unsigned char
        public byte Flip1;

        /// BOOLEAN->BYTE->unsigned char
        public byte Flip2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_ELEMENT_STATUS_EX
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Element;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT SrcElementAddress;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint ExceptionCode;

        /// BYTE->unsigned char
        public byte TargetId;

        /// BYTE->unsigned char
        public byte Lun;

        /// WORD->unsigned short
        public ushort Reserved;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] PrimaryVolumeID;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] AlternateVolumeID;

        /// BYTE[8]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
        public byte[] VendorIdentification;

        /// BYTE[16]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
        public byte[] ProductIdentification;

        /// BYTE[32]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] SerialNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_ELEMENT_STATUS
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Element;

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT SrcElementAddress;

        /// DWORD->unsigned int
        public uint Flags;

        /// DWORD->unsigned int
        public uint ExceptionCode;

        /// BYTE->unsigned char
        public byte TargetId;

        /// BYTE->unsigned char
        public byte Lun;

        /// WORD->unsigned short
        public ushort Reserved;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] PrimaryVolumeID;

        /// BYTE[36]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
        public byte[] AlternateVolumeID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_ELEMENT_LIST
    {

        /// CHANGER_ELEMENT->_CHANGER_ELEMENT
        public CHANGER_ELEMENT Element;

        /// DWORD->unsigned int
        public uint NumberOfElements;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHANGER_ELEMENT
    {

        /// ELEMENT_TYPE->_ELEMENT_TYPE
        public ELEMENT_TYPE ElementType;

        /// DWORD->unsigned int
        public uint ElementAddress;
    }

    public enum CHANGER_DEVICE_PROBLEM_TYPE
    {

        DeviceProblemNone,

        DeviceProblemHardware,

        DeviceProblemCHMError,

        DeviceProblemDoorOpen,

        DeviceProblemCalibrationError,

        DeviceProblemTargetFailure,

        DeviceProblemCHMMoveError,

        DeviceProblemCHMZeroError,

        DeviceProblemCartridgeInsertError,

        DeviceProblemPositionError,

        DeviceProblemSensorError,

        DeviceProblemCartridgeEjectError,

        DeviceProblemGripperError,

        DeviceProblemDriveError,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_X942_DH_VALIDATION_PARAMS
    {

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB seed;

        /// DWORD->unsigned int
        public uint pgenCounter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_X942_DH_PARAMETERS
    {

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB p;

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB g;

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB q;

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB j;

        /// PCERT_X942_DH_VALIDATION_PARAMS->_CERT_X942_DH_VALIDATION_PARAMS*
        public IntPtr pValidationParams;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_USAGE_MATCH
    {

        /// DWORD->unsigned int
        public uint dwType;

        /// CERT_ENHKEY_USAGE->_CTL_USAGE
        public CERT_ENHKEY_USAGE Usage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_TRUST_STATUS
    {

        /// DWORD->unsigned int
        public uint dwErrorStatus;

        /// DWORD->unsigned int
        public uint dwInfoStatus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_TRUST_LIST_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PCTL_ENTRY->_CTL_ENTRY*
        public IntPtr pCtlEntry;

        /// PCCTL_CONTEXT->CTL_CONTEXT*
        public IntPtr pCtlContext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_TEMPLATE_EXT
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// DWORD->unsigned int
        public uint dwMajorVersion;

        /// BOOL->int
        public int fMinorVersion;

        /// DWORD->unsigned int
        public uint dwMinorVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_SYSTEM_STORE_RELOCATE_PARA
    {

        /// Anonymous_440c4700_1348_4323_b8bb_ed586c28a10a
        public Anonymous_440c4700_1348_4323_b8bb_ed586c28a10a Union1;

        /// Anonymous_bee1bc17_403f_41d8_bac9_fbc35d2b706c
        public Anonymous_bee1bc17_403f_41d8_bac9_fbc35d2b706c Union2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_SYSTEM_STORE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_STORE_PROV_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint cStoreProvFunc;

        /// void**
        public IntPtr rgpvStoreProvFunc;

        /// HCERTSTOREPROV->void*
        public IntPtr hStoreProv;

        /// DWORD->unsigned int
        public uint dwStoreProvFlags;

        /// HCRYPTOIDFUNCADDR->void*
        public IntPtr hStoreProvFuncAddr2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_STORE_PROV_FIND_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwMsgAndCertEncodingType;

        /// DWORD->unsigned int
        public uint dwFindFlags;

        /// DWORD->unsigned int
        public uint dwFindType;

        /// void*
        public IntPtr pvFindPara;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_SIMPLE_CHAIN
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CERT_TRUST_STATUS->_CERT_TRUST_STATUS
        public CERT_TRUST_STATUS TrustStatus;

        /// DWORD->unsigned int
        public uint cElement;

        /// PCERT_CHAIN_ELEMENT*
        public IntPtr rgpElement;

        /// PCERT_TRUST_LIST_INFO->_CERT_TRUST_LIST_INFO*
        public IntPtr pTrustListInfo;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fHasRevocationFreshnessTime;

        /// DWORD->unsigned int
        public uint dwRevocationFreshnessTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_SIGNED_CONTENT_INFO
    {

        /// CRYPT_DER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB ToBeSigned;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB Signature;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_REVOCATION_STATUS
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwIndex;

        /// DWORD->unsigned int
        public uint dwError;

        /// DWORD->unsigned int
        public uint dwReason;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fHasFreshnessTime;

        /// DWORD->unsigned int
        public uint dwFreshnessTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_REVOCATION_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PCCERT_CONTEXT->CERT_CONTEXT*
        public IntPtr pIssuerCert;

        /// DWORD->unsigned int
        public uint cCertStore;

        /// HCERTSTORE*
        public IntPtr rgCertStore;

        /// HCERTSTORE->void*
        public IntPtr hCrlStore;

        /// LPFILETIME->_FILETIME*
        public IntPtr pftTimeToUse;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_REVOCATION_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwRevocationResult;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszRevocationOid;

        /// LPVOID->void*
        public IntPtr pvOidSpecificInfo;

        /// BOOL->int
        public int fHasFreshnessTime;

        /// DWORD->unsigned int
        public uint dwFreshnessTime;

        /// PCERT_REVOCATION_CRL_INFO->_CERT_REVOCATION_CRL_INFO*
        public IntPtr pCrlInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_REVOCATION_CRL_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PCCRL_CONTEXT->CRL_CONTEXT*
        public IntPtr pBaseCrlContext;

        /// PCCRL_CONTEXT->CRL_CONTEXT*
        public IntPtr pDeltaCrlContext;

        /// PCRL_ENTRY->_CRL_ENTRY*
        public IntPtr pCrlEntry;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fDeltaCrlEntry;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_REQUEST_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Subject;

        /// CERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO
        public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

        /// DWORD->unsigned int
        public uint cAttribute;

        /// PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        public IntPtr rgAttribute;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_REGISTRY_STORE_ROAMING_PARA
    {

        /// HKEY->HKEY__*
        public IntPtr hKey;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszStoreDirectory;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_REGISTRY_STORE_CLIENT_GPT_PARA
    {

        /// HKEY->HKEY__*
        public IntPtr hKeyBase;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszRegPath;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_RDN_ATTR
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// DWORD->unsigned int
        public uint dwValueType;

        /// CERT_RDN_VALUE_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_RDN
    {

        /// DWORD->unsigned int
        public uint cRDNAttr;

        /// PCERT_RDN_ATTR->_CERT_RDN_ATTR*
        public IntPtr rgRDNAttr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_PUBLIC_KEY_INFO
    {

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER Algorithm;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB PublicKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_PRIVATE_KEY_VALIDITY
    {

        /// FILETIME->_FILETIME
        public FILETIME NotBefore;

        /// FILETIME->_FILETIME
        public FILETIME NotAfter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_QUALIFIER_USER_NOTICE
    {

        /// CERT_POLICY_QUALIFIER_NOTICE_REFERENCE*
        public IntPtr pNoticeReference;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszDisplayText;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_QUALIFIER_NOTICE_REFERENCE
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszOrganization;

        /// DWORD->unsigned int
        public uint cNoticeNumbers;

        /// int*
        public IntPtr rgNoticeNumbers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_QUALIFIER_INFO
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszPolicyQualifierId;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Qualifier;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_MAPPINGS_INFO
    {

        /// DWORD->unsigned int
        public uint cPolicyMapping;

        /// PCERT_POLICY_MAPPING->_CERT_POLICY_MAPPING*
        public IntPtr rgPolicyMapping;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_MAPPING
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszIssuerDomainPolicy;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszSubjectDomainPolicy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_INFO
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszPolicyIdentifier;

        /// DWORD->unsigned int
        public uint cPolicyQualifier;

        /// CERT_POLICY_QUALIFIER_INFO*
        public IntPtr rgPolicyQualifier;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_ID
    {

        /// DWORD->unsigned int
        public uint cCertPolicyElementId;

        /// LPSTR*
        public IntPtr rgpszCertPolicyElementId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY_CONSTRAINTS_INFO
    {

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fRequireExplicitPolicy;

        /// DWORD->unsigned int
        public uint dwRequireExplicitPolicySkipCerts;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fInhibitPolicyMapping;

        /// DWORD->unsigned int
        public uint dwInhibitPolicyMappingSkipCerts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICY95_QUALIFIER1
    {

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszPracticesReference;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszNoticeIdentifier;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszNSINoticeIdentifier;

        /// DWORD->unsigned int
        public uint cCPSURLs;

        /// CPS_URLS*
        public IntPtr rgCPSURLs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_POLICIES_INFO
    {

        /// DWORD->unsigned int
        public uint cPolicyInfo;

        /// CERT_POLICY_INFO*
        public IntPtr rgPolicyInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_PHYSICAL_STORE_INFO
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszOpenStoreProvider;

        /// DWORD->unsigned int
        public uint dwOpenEncodingType;

        /// DWORD->unsigned int
        public uint dwOpenFlags;

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB OpenParameters;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwPriority;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_PAIR
    {

        /// CERT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Forward;

        /// CERT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Reverse;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_OTHER_NAME
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_NAME_VALUE
    {

        /// DWORD->unsigned int
        public uint dwValueType;

        /// CERT_RDN_VALUE_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_NAME_INFO
    {

        /// DWORD->unsigned int
        public uint cRDN;

        /// PCERT_RDN->_CERT_RDN*
        public IntPtr rgRDN;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_NAME_CONSTRAINTS_INFO
    {

        /// DWORD->unsigned int
        public uint cPermittedSubtree;

        /// PCERT_GENERAL_SUBTREE->_CERT_GENERAL_SUBTREE*
        public IntPtr rgPermittedSubtree;

        /// DWORD->unsigned int
        public uint cExcludedSubtree;

        /// PCERT_GENERAL_SUBTREE->_CERT_GENERAL_SUBTREE*
        public IntPtr rgExcludedSubtree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_LDAP_STORE_OPENED_PARA
    {

        /// void*
        public IntPtr pvLdapSessionHandle;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszLdapUrl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_KEY_USAGE_RESTRICTION_INFO
    {

        /// DWORD->unsigned int
        public uint cCertPolicyId;

        /// PCERT_POLICY_ID->_CERT_POLICY_ID*
        public IntPtr rgCertPolicyId;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB RestrictedKeyUsage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_KEY_CONTEXT
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCRYPTPROV->ULONG_PTR->unsigned int
        public uint hCryptProv;

        /// DWORD->unsigned int
        public uint dwKeySpec;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_KEY_ATTRIBUTES_INFO
    {

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB KeyId;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB IntendedKeyUsage;

        /// PCERT_PRIVATE_KEY_VALIDITY->_CERT_PRIVATE_KEY_VALIDITY*
        public IntPtr pPrivateKeyUsagePeriod;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_KEYGEN_REQUEST_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO
        public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

        /// LPWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszChallengeString;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_ISSUER_SERIAL_NUMBER
    {

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Issuer;

        /// CRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SerialNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_INFO
    {

        /// DWORD->unsigned int
        public uint dwVersion;

        /// CRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB SerialNumber;

        /// CRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER
        public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Issuer;

        /// FILETIME->_FILETIME
        public FILETIME NotBefore;

        /// FILETIME->_FILETIME
        public FILETIME NotAfter;

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Subject;

        /// CERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO
        public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB IssuerUniqueId;

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB SubjectUniqueId;

        /// DWORD->unsigned int
        public uint cExtension;

        /// PCERT_EXTENSION->_CERT_EXTENSION*
        public IntPtr rgExtension;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_ID
    {

        /// DWORD->unsigned int
        public uint dwIdChoice;

        /// Anonymous_b895d924_0737_4d5c_bff8_4b994f32d0af
        public Anonymous_b895d924_0737_4d5c_bff8_4b994f32d0af Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_GENERAL_SUBTREE
    {

        /// CERT_ALT_NAME_ENTRY->_CERT_ALT_NAME_ENTRY
        public CERT_ALT_NAME_ENTRY Base;

        /// DWORD->unsigned int
        public uint dwMinimum;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fMaximum;

        /// DWORD->unsigned int
        public uint dwMaximum;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CERT_FORTEZZA_DATA_PROP
    {

        /// unsigned char[8]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string SerialNumber;

        /// int
        public int CertIndex;

        /// unsigned char[36]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string CertLabel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_EXTENSIONS
    {

        /// DWORD->unsigned int
        public uint cExtension;

        /// PCERT_EXTENSION->_CERT_EXTENSION*
        public IntPtr rgExtension;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_EXTENSION
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszObjId;

        /// BOOL->int
        public int fCritical;

        /// CRYPT_OBJID_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_DSS_PARAMETERS
    {

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB p;

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB q;

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB g;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_DH_PARAMETERS
    {

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB p;

        /// CRYPT_UINT_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB g;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CRL_CONTEXT_PAIR
    {

        /// PCCERT_CONTEXT->CERT_CONTEXT*
        public IntPtr pCertContext;

        /// PCCRL_CONTEXT->CRL_CONTEXT*
        public IntPtr pCrlContext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CREATE_CONTEXT_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PFN_CRYPT_FREE
        public PFN_CRYPT_FREE pfnFree;

        /// void*
        public IntPtr pvFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CONTEXT
    {

        /// DWORD->unsigned int
        public uint dwCertEncodingType;

        /// BYTE*
        public IntPtr pbCertEncoded;

        /// DWORD->unsigned int
        public uint cbCertEncoded;

        /// PCERT_INFO->_CERT_INFO*
        public IntPtr pCertInfo;

        /// HCERTSTORE->void*
        public IntPtr hCertStore;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN_POLICY_STATUS
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwError;

        /// LONG->int
        public int lChainIndex;

        /// LONG->int
        public int lElementIndex;

        /// void*
        public IntPtr pvExtraPolicyStatus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN_POLICY_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// void*
        public IntPtr pvExtraPolicyPara;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CERT_USAGE_MATCH->_CERT_USAGE_MATCH
        public CERT_USAGE_MATCH RequestedUsage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN_FIND_BY_ISSUER_PARA
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// LPCSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszUsageIdentifier;

        /// DWORD->unsigned int
        public uint dwKeySpec;

        /// DWORD->unsigned int
        public uint dwAcquirePrivateKeyFlags;

        /// DWORD->unsigned int
        public uint cIssuer;

        /// CERT_NAME_BLOB*
        public IntPtr rgIssuer;

        /// PFN_CERT_CHAIN_FIND_BY_ISSUER_CALLBACK
        public PFN_CERT_CHAIN_FIND_BY_ISSUER_CALLBACK pfnFindCallback;

        /// void*
        public IntPtr pvFindArg;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN_ENGINE_CONFIG
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// HCERTSTORE->void*
        public IntPtr hRestrictedRoot;

        /// HCERTSTORE->void*
        public IntPtr hRestrictedTrust;

        /// HCERTSTORE->void*
        public IntPtr hRestrictedOther;

        /// DWORD->unsigned int
        public uint cAdditionalStore;

        /// HCERTSTORE*
        public IntPtr rghAdditionalStore;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// DWORD->unsigned int
        public uint dwUrlRetrievalTimeout;

        /// DWORD->unsigned int
        public uint MaximumCachedCertificates;

        /// DWORD->unsigned int
        public uint CycleDetectionModulus;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN_ELEMENT
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// PCCERT_CONTEXT->CERT_CONTEXT*
        public IntPtr pCertContext;

        /// CERT_TRUST_STATUS->_CERT_TRUST_STATUS
        public CERT_TRUST_STATUS TrustStatus;

        /// PCERT_REVOCATION_INFO->_CERT_REVOCATION_INFO*
        public IntPtr pRevocationInfo;

        /// PCERT_ENHKEY_USAGE->_CTL_USAGE*
        public IntPtr pIssuanceUsage;

        /// PCERT_ENHKEY_USAGE->_CTL_USAGE*
        public IntPtr pApplicationUsage;

        /// LPCWSTR->WCHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszExtendedErrorInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN_CONTEXT
    {

        /// DWORD->unsigned int
        public uint cbSize;

        /// CERT_TRUST_STATUS->_CERT_TRUST_STATUS
        public CERT_TRUST_STATUS TrustStatus;

        /// DWORD->unsigned int
        public uint cChain;

        /// PCERT_SIMPLE_CHAIN*
        public IntPtr rgpChain;

        /// DWORD->unsigned int
        public uint cLowerQualityChainContext;

        /// PCCERT_CHAIN_CONTEXT*
        public IntPtr rgpLowerQualityChainContext;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fHasRevocationFreshnessTime;

        /// DWORD->unsigned int
        public uint dwRevocationFreshnessTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_CHAIN
    {

        /// DWORD->unsigned int
        public uint cCerts;

        /// PCERT_BLOB->_CRYPTOAPI_BLOB*
        public IntPtr certs;

        /// CRYPT_KEY_PROV_INFO->_CRYPT_KEY_PROV_INFO
        public CRYPT_KEY_PROV_INFO keyLocatorInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_BASIC_CONSTRAINTS_INFO
    {

        /// CRYPT_BIT_BLOB->_CRYPT_BIT_BLOB
        public CRYPT_BIT_BLOB SubjectType;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fPathLenConstraint;

        /// DWORD->unsigned int
        public uint dwPathLenConstraint;

        /// DWORD->unsigned int
        public uint cSubtreesConstraint;

        /// CERT_NAME_BLOB*
        public IntPtr rgSubtreesConstraint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_BASIC_CONSTRAINTS2_INFO
    {

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fCA;

        /// BOOL->int
        [MarshalAs(UnmanagedType.Bool)]
        public bool fPathLenConstraint;

        /// DWORD->unsigned int
        public uint dwPathLenConstraint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_AUTHORITY_KEY_ID_INFO
    {

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB KeyId;

        /// CERT_NAME_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB CertIssuer;

        /// CRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB CertSerialNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_AUTHORITY_KEY_ID2_INFO
    {

        /// CRYPT_DATA_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB KeyId;

        /// CERT_ALT_NAME_INFO->_CERT_ALT_NAME_INFO
        public CERT_ALT_NAME_INFO AuthorityCertIssuer;

        /// CRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB
        public CRYPT_ATTR_BLOB AuthorityCertSerialNumber;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_AUTHORITY_INFO_ACCESS
    {

        /// DWORD->unsigned int
        public uint cAccDescr;

        /// PCERT_ACCESS_DESCRIPTION->_CERT_ACCESS_DESCRIPTION*
        public IntPtr rgAccDescr;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_ALT_NAME_INFO
    {

        /// DWORD->unsigned int
        public uint cAltEntry;

        /// PCERT_ALT_NAME_ENTRY->_CERT_ALT_NAME_ENTRY*
        public IntPtr rgAltEntry;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_ALT_NAME_ENTRY
    {

        /// DWORD->unsigned int
        public uint dwAltNameChoice;

        /// Anonymous_f7b746fc_d446_406f_831b_3beba7513ffc
        public Anonymous_f7b746fc_d446_406f_831b_3beba7513ffc Union1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CERT_ACCESS_DESCRIPTION
    {

        /// LPSTR->CHAR*
        [MarshalAs(UnmanagedType.LPStr)]
        public string pszAccessMethod;

        /// CERT_ALT_NAME_ENTRY->_CERT_ALT_NAME_ENTRY
        public CERT_ALT_NAME_ENTRY AccessLocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CACHE_DESCRIPTOR
    {

        /// BYTE->unsigned char
        public byte Level;

        /// BYTE->unsigned char
        public byte Associativity;

        /// WORD->unsigned short
        public ushort LineSize;

        /// DWORD->unsigned int
        public uint Size;

        /// PROCESSOR_CACHE_TYPE->_PROCESSOR_CACHE_TYPE
        public PROCESSOR_CACHE_TYPE Type;
    }

}
