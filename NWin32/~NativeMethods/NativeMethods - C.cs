using NWin32.NativeTypes;
using System;
using System.Runtime.InteropServices;
using FILETIME = NWin32.NativeTypes.FILETIME;
using IServiceProvider = NWin32.NativeTypes.IServiceProvider;

namespace NWin32
{
    public partial class NativeMethods
    {

        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///pbSignature: BYTE*
        ///dwSigLen: DWORD->unsigned int
        ///hPubKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///szDescription: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptVerifySignatureW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifySignatureW(uint hHash, ref byte pbSignature, uint dwSigLen, uint hPubKey, [In] [MarshalAs(UnmanagedType.LPWStr)] string szDescription, uint dwFlags);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///pbSignature: BYTE*
        ///dwSigLen: DWORD->unsigned int
        ///hPubKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///szDescription: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptVerifySignatureA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifySignatureA(uint hHash, ref byte pbSignature, uint dwSigLen, uint hPubKey, [In] [MarshalAs(UnmanagedType.LPStr)] string szDescription, uint dwFlags);


        /// Return Type: BOOL->int
        ///pVerifyPara: PCRYPT_KEY_VERIFY_MESSAGE_PARA->_CRYPT_KEY_VERIFY_MESSAGE_PARA*
        ///pPublicKeyInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        ///pbSignedBlob: BYTE*
        ///cbSignedBlob: DWORD->unsigned int
        ///pbDecoded: BYTE*
        ///pcbDecoded: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptVerifyMessageSignatureWithKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifyMessageSignatureWithKey(ref CRYPT_KEY_VERIFY_MESSAGE_PARA pVerifyPara, ref CERT_PUBLIC_KEY_INFO pPublicKeyInfo, ref byte pbSignedBlob, uint cbSignedBlob, ref byte pbDecoded, ref uint pcbDecoded);


        /// Return Type: BOOL->int
        ///pVerifyPara: PCRYPT_VERIFY_MESSAGE_PARA->_CRYPT_VERIFY_MESSAGE_PARA*
        ///dwSignerIndex: DWORD->unsigned int
        ///pbSignedBlob: BYTE*
        ///cbSignedBlob: DWORD->unsigned int
        ///pbDecoded: BYTE*
        ///pcbDecoded: DWORD*
        ///ppSignerCert: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CryptVerifyMessageSignature")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifyMessageSignature(ref CRYPT_VERIFY_MESSAGE_PARA pVerifyPara, uint dwSignerIndex, ref byte pbSignedBlob, uint cbSignedBlob, ref byte pbDecoded, ref uint pcbDecoded, ref IntPtr ppSignerCert);


        /// Return Type: BOOL->int
        ///pHashPara: PCRYPT_HASH_MESSAGE_PARA->_CRYPT_HASH_MESSAGE_PARA*
        ///pbHashedBlob: BYTE*
        ///cbHashedBlob: DWORD->unsigned int
        ///pbToBeHashed: BYTE*
        ///pcbToBeHashed: DWORD*
        ///pbComputedHash: BYTE*
        ///pcbComputedHash: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptVerifyMessageHash")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifyMessageHash(ref CRYPT_HASH_MESSAGE_PARA pHashPara, ref byte pbHashedBlob, uint cbHashedBlob, ref byte pbToBeHashed, ref uint pcbToBeHashed, ref byte pbComputedHash, ref uint pcbComputedHash);


        /// Return Type: BOOL->int
        ///pVerifyPara: PCRYPT_VERIFY_MESSAGE_PARA->_CRYPT_VERIFY_MESSAGE_PARA*
        ///dwSignerIndex: DWORD->unsigned int
        ///pbDetachedSignBlob: BYTE*
        ///cbDetachedSignBlob: DWORD->unsigned int
        ///cToBeSigned: DWORD->unsigned int
        ///rgpbToBeSigned: BYTE**
        ///rgcbToBeSigned: DWORD*
        ///ppSignerCert: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CryptVerifyDetachedMessageSignature")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifyDetachedMessageSignature(ref CRYPT_VERIFY_MESSAGE_PARA pVerifyPara, uint dwSignerIndex, ref byte pbDetachedSignBlob, uint cbDetachedSignBlob, uint cToBeSigned, ref IntPtr rgpbToBeSigned, ref uint rgcbToBeSigned, ref IntPtr ppSignerCert);


        /// Return Type: BOOL->int
        ///pHashPara: PCRYPT_HASH_MESSAGE_PARA->_CRYPT_HASH_MESSAGE_PARA*
        ///pbDetachedHashBlob: BYTE*
        ///cbDetachedHashBlob: DWORD->unsigned int
        ///cToBeHashed: DWORD->unsigned int
        ///rgpbToBeHashed: BYTE**
        ///rgcbToBeHashed: DWORD*
        ///pbComputedHash: BYTE*
        ///pcbComputedHash: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptVerifyDetachedMessageHash")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifyDetachedMessageHash(ref CRYPT_HASH_MESSAGE_PARA pHashPara, ref byte pbDetachedHashBlob, uint cbDetachedHashBlob, uint cToBeHashed, ref IntPtr rgpbToBeHashed, ref uint rgcbToBeHashed, ref byte pbComputedHash, ref uint pcbComputedHash);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///dwSubjectType: DWORD->unsigned int
        ///pvSubject: void*
        ///dwIssuerType: DWORD->unsigned int
        ///pvIssuer: void*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("crypt32.dll", EntryPoint = "CryptVerifyCertificateSignatureEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifyCertificateSignatureEx(uint hCryptProv, uint dwCertEncodingType, uint dwSubjectType, IntPtr pvSubject, uint dwIssuerType, IntPtr pvIssuer, uint dwFlags, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pbEncoded: BYTE*
        ///cbEncoded: DWORD->unsigned int
        ///pPublicKey: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CryptVerifyCertificateSignature")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptVerifyCertificateSignature(uint hCryptProv, uint dwCertEncodingType, ref byte pbEncoded, uint cbEncoded, ref CERT_PUBLIC_KEY_INFO pPublicKey);


        /// Return Type: BOOL->int
        ///pInfo: PCCRYPT_OID_INFO->CRYPT_OID_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CryptUnregisterOIDInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptUnregisterOIDInfo(ref CRYPT_OID_INFO pInfo);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///pszOID: LPCSTR->CHAR*
        [DllImport("crypt32.dll", EntryPoint = "CryptUnregisterOIDFunction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptUnregisterOIDFunction(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOID);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///pwszDll: LPCWSTR->WCHAR*
        [DllImport("crypt32.dll", EntryPoint = "CryptUnregisterDefaultOIDFunction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptUnregisterDefaultOIDFunction(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszDll);


        /// Return Type: BOOL->int
        ///pDataIn: LPVOID->void*
        ///cbDataIn: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptUnprotectMemory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptUnprotectMemory(IntPtr pDataIn, uint cbDataIn, uint dwFlags);


        /// Return Type: BOOL->int
        ///pDataIn: DATA_BLOB*
        ///ppszDataDescr: LPWSTR*
        ///pOptionalEntropy: DATA_BLOB*
        ///pvReserved: PVOID->void*
        ///pPromptStruct: CRYPTPROTECT_PROMPTSTRUCT*
        ///dwFlags: DWORD->unsigned int
        ///pDataOut: DATA_BLOB*
        [DllImport("crypt32.dll", EntryPoint = "CryptUnprotectData")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptUnprotectData(ref CRYPT_ATTR_BLOB pDataIn, ref IntPtr ppszDataDescr, ref CRYPT_ATTR_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, uint dwFlags, ref CRYPT_ATTR_BLOB pDataOut);


        /// Return Type: BOOL->int
        ///hDefaultContext: HCRYPTDEFAULTCONTEXT->void*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("crypt32.dll", EntryPoint = "CryptUninstallDefaultContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptUninstallDefaultContext(IntPtr hDefaultContext, uint dwFlags, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("cryptnet.dll", EntryPoint = "CryptUninstallCancelRetrieval")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptUninstallCancelRetrieval(uint dwFlags, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///pszString: LPCWSTR->WCHAR*
        ///cchString: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pbBinary: BYTE*
        ///pcbBinary: DWORD*
        ///pdwSkip: DWORD*
        ///pdwFlags: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptStringToBinaryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptStringToBinaryW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszString, uint cchString, uint dwFlags, ref byte pbBinary, ref uint pcbBinary, ref uint pdwSkip, ref uint pdwFlags);


        /// Return Type: BOOL->int
        ///pszString: LPCSTR->CHAR*
        ///cchString: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pbBinary: BYTE*
        ///pcbBinary: DWORD*
        ///pdwSkip: DWORD*
        ///pdwFlags: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptStringToBinaryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptStringToBinaryA([In] [MarshalAs(UnmanagedType.LPStr)] string pszString, uint cchString, uint dwFlags, ref byte pbBinary, ref uint pcbBinary, ref uint pdwSkip, ref uint pdwFlags);


        /// Return Type: BOOL->int
        ///pSignPara: PCRYPT_KEY_SIGN_MESSAGE_PARA->_CRYPT_KEY_SIGN_MESSAGE_PARA*
        ///pbToBeSigned: BYTE*
        ///cbToBeSigned: DWORD->unsigned int
        ///pbSignedBlob: BYTE*
        ///pcbSignedBlob: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptSignMessageWithKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSignMessageWithKey(ref CRYPT_KEY_SIGN_MESSAGE_PARA pSignPara, ref byte pbToBeSigned, uint cbToBeSigned, ref byte pbSignedBlob, ref uint pcbSignedBlob);


        /// Return Type: BOOL->int
        ///pSignPara: PCRYPT_SIGN_MESSAGE_PARA->_CRYPT_SIGN_MESSAGE_PARA*
        ///fDetachedSignature: BOOL->int
        ///cToBeSigned: DWORD->unsigned int
        ///rgpbToBeSigned: BYTE**
        ///rgcbToBeSigned: DWORD*
        ///pbSignedBlob: BYTE*
        ///pcbSignedBlob: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptSignMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSignMessage(ref CRYPT_SIGN_MESSAGE_PARA pSignPara, [MarshalAs(UnmanagedType.Bool)] bool fDetachedSignature, uint cToBeSigned, ref IntPtr rgpbToBeSigned, ref uint rgcbToBeSigned, ref byte pbSignedBlob, ref uint pcbSignedBlob);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///szDescription: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///pbSignature: BYTE*
        ///pdwSigLen: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptSignHashW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSignHashW(uint hHash, uint dwKeySpec, [In] [MarshalAs(UnmanagedType.LPWStr)] string szDescription, uint dwFlags, ref byte pbSignature, ref uint pdwSigLen);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///szDescription: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///pbSignature: BYTE*
        ///pdwSigLen: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptSignHashA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSignHashA(uint hHash, uint dwKeySpec, [In] [MarshalAs(UnmanagedType.LPStr)] string szDescription, uint dwFlags, ref byte pbSignature, ref uint pdwSigLen);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pbEncodedToBeSigned: BYTE*
        ///cbEncodedToBeSigned: DWORD->unsigned int
        ///pSignatureAlgorithm: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
        ///pvHashAuxInfo: void*
        ///pbSignature: BYTE*
        ///pcbSignature: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptSignCertificate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSignCertificate(uint hCryptProv, uint dwKeySpec, uint dwCertEncodingType, ref byte pbEncodedToBeSigned, uint cbEncodedToBeSigned, ref CRYPT_ALGORITHM_IDENTIFIER pSignatureAlgorithm, IntPtr pvHashAuxInfo, ref byte pbSignature, ref uint pcbSignature);


        /// Return Type: BOOL->int
        ///pSignPara: PCRYPT_SIGN_MESSAGE_PARA->_CRYPT_SIGN_MESSAGE_PARA*
        ///pEncryptPara: PCRYPT_ENCRYPT_MESSAGE_PARA->_CRYPT_ENCRYPT_MESSAGE_PARA*
        ///cRecipientCert: DWORD->unsigned int
        ///rgpRecipientCert: PCCERT_CONTEXT*
        ///pbToBeSignedAndEncrypted: BYTE*
        ///cbToBeSignedAndEncrypted: DWORD->unsigned int
        ///pbSignedAndEncryptedBlob: BYTE*
        ///pcbSignedAndEncryptedBlob: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptSignAndEncryptMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSignAndEncryptMessage(ref CRYPT_SIGN_MESSAGE_PARA pSignPara, ref CRYPT_ENCRYPT_MESSAGE_PARA pEncryptPara, uint cRecipientCert, ref IntPtr rgpRecipientCert, ref byte pbToBeSignedAndEncrypted, uint cbToBeSignedAndEncrypted, ref byte pbSignedAndEncryptedBlob, ref uint pcbSignedAndEncryptedBlob);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///lpszStructType: LPCSTR->CHAR*
        ///pvStructInfo: void*
        ///pSignatureAlgorithm: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
        ///pvHashAuxInfo: void*
        ///pbEncoded: PBYTE->BYTE*
        ///pcbEncoded: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptSignAndEncodeCertificate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSignAndEncodeCertificate(uint hCryptProv, uint dwKeySpec, uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszStructType, IntPtr pvStructInfo, ref CRYPT_ALGORITHM_IDENTIFIER pSignatureAlgorithm, IntPtr pvHashAuxInfo, ref byte pbEncoded, ref uint pcbEncoded);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwParam: DWORD->unsigned int
        ///pbData: BYTE*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptSetProvParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetProvParam(uint hProv, uint dwParam, ref byte pbData, uint dwFlags);


        /// Return Type: BOOL->int
        ///pszProvName: LPCWSTR->WCHAR*
        ///dwProvType: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptSetProviderW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetProviderW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszProvName, uint dwProvType);


        /// Return Type: BOOL->int
        ///pszProvName: LPCWSTR->WCHAR*
        ///dwProvType: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptSetProviderExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetProviderExW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszProvName, uint dwProvType, ref uint pdwReserved, uint dwFlags);


        /// Return Type: BOOL->int
        ///pszProvName: LPCSTR->CHAR*
        ///dwProvType: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptSetProviderExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetProviderExA([In] [MarshalAs(UnmanagedType.LPStr)] string pszProvName, uint dwProvType, ref uint pdwReserved, uint dwFlags);


        /// Return Type: BOOL->int
        ///pszProvName: LPCSTR->CHAR*
        ///dwProvType: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptSetProviderA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetProviderA([In] [MarshalAs(UnmanagedType.LPStr)] string pszProvName, uint dwProvType);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///pszOID: LPCSTR->CHAR*
        ///pwszValueName: LPCWSTR->WCHAR*
        ///dwValueType: DWORD->unsigned int
        ///pbValueData: BYTE*
        ///cbValueData: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptSetOIDFunctionValue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetOIDFunctionValue(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOID, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszValueName, uint dwValueType, ref byte pbValueData, uint cbValueData);


        /// Return Type: BOOL->int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///dwParam: DWORD->unsigned int
        ///pbData: BYTE*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptSetKeyParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetKeyParam(uint hKey, uint dwParam, ref byte pbData, uint dwFlags);


        /// Return Type: BOOL->int
        ///pKeyIdentifier: CRYPT_HASH_BLOB*
        ///dwPropId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pwszComputerName: LPCWSTR->WCHAR*
        ///pvReserved: void*
        ///pvData: void*
        [DllImport("crypt32.dll", EntryPoint = "CryptSetKeyIdentifierProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetKeyIdentifierProperty(ref CRYPT_ATTR_BLOB pKeyIdentifier, uint dwPropId, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszComputerName, IntPtr pvReserved, IntPtr pvData);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///dwParam: DWORD->unsigned int
        ///pbData: BYTE*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptSetHashParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetHashParam(uint hHash, uint dwParam, ref byte pbData, uint dwFlags);


        /// Return Type: BOOL->int
        ///hAsync: HCRYPTASYNC->HANDLE->void*
        ///pszParamOid: LPSTR->CHAR*
        ///pvParam: LPVOID->void*
        ///pfnFree: PFN_CRYPT_ASYNC_PARAM_FREE_FUNC
        [DllImport("crypt32.dll", EntryPoint = "CryptSetAsyncParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptSetAsyncParam(IntPtr hAsync, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszParamOid, IntPtr pvParam, PFN_CRYPT_ASYNC_PARAM_FREE_FUNC pfnFree);


        /// Return Type: BOOL->int
        ///pszUrl: LPCWSTR->WCHAR*
        ///pszObjectOid: LPCSTR->CHAR*
        ///dwRetrievalFlags: DWORD->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///ppvObject: LPVOID*
        ///hAsyncRetrieve: HCRYPTASYNC->HANDLE->void*
        ///pCredentials: PCRYPT_CREDENTIALS->_CRYPT_CREDENTIALS*
        ///pvVerify: LPVOID->void*
        ///pAuxInfo: PCRYPT_RETRIEVE_AUX_INFO->_CRYPT_RETRIEVE_AUX_INFO*
        [DllImport("cryptnet.dll", EntryPoint = "CryptRetrieveObjectByUrlW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptRetrieveObjectByUrlW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszUrl, [In] [MarshalAs(UnmanagedType.LPStr)] string pszObjectOid, uint dwRetrievalFlags, uint dwTimeout, ref IntPtr ppvObject, IntPtr hAsyncRetrieve, ref CRYPT_CREDENTIALS pCredentials, IntPtr pvVerify, ref CRYPT_RETRIEVE_AUX_INFO pAuxInfo);


        /// Return Type: BOOL->int
        ///pszUrl: LPCSTR->CHAR*
        ///pszObjectOid: LPCSTR->CHAR*
        ///dwRetrievalFlags: DWORD->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///ppvObject: LPVOID*
        ///hAsyncRetrieve: HCRYPTASYNC->HANDLE->void*
        ///pCredentials: PCRYPT_CREDENTIALS->_CRYPT_CREDENTIALS*
        ///pvVerify: LPVOID->void*
        ///pAuxInfo: PCRYPT_RETRIEVE_AUX_INFO->_CRYPT_RETRIEVE_AUX_INFO*
        [DllImport("cryptnet.dll", EntryPoint = "CryptRetrieveObjectByUrlA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptRetrieveObjectByUrlA([In] [MarshalAs(UnmanagedType.LPStr)] string pszUrl, [In] [MarshalAs(UnmanagedType.LPStr)] string pszObjectOid, uint dwRetrievalFlags, uint dwTimeout, ref IntPtr ppvObject, IntPtr hAsyncRetrieve, ref CRYPT_CREDENTIALS pCredentials, IntPtr pvVerify, ref CRYPT_RETRIEVE_AUX_INFO pAuxInfo);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptReleaseContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptReleaseContext(uint hProv, uint dwFlags);


        /// Return Type: BOOL->int
        ///pInfo: PCCRYPT_OID_INFO->CRYPT_OID_INFO*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptRegisterOIDInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptRegisterOIDInfo(ref CRYPT_OID_INFO pInfo, uint dwFlags);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///pszOID: LPCSTR->CHAR*
        ///pwszDll: LPCWSTR->WCHAR*
        ///pszOverrideFuncName: LPCSTR->CHAR*
        [DllImport("crypt32.dll", EntryPoint = "CryptRegisterOIDFunction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptRegisterOIDFunction(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOID, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszDll, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOverrideFuncName);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///dwIndex: DWORD->unsigned int
        ///pwszDll: LPCWSTR->WCHAR*
        [DllImport("crypt32.dll", EntryPoint = "CryptRegisterDefaultOIDFunction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptRegisterDefaultOIDFunction(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, uint dwIndex, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszDll);


        /// Return Type: BOOL->int
        ///dwObjectType: DWORD->unsigned int
        ///pvObject: void*
        ///dwExpectedContentTypeFlags: DWORD->unsigned int
        ///dwExpectedFormatTypeFlags: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pdwMsgAndCertEncodingType: DWORD*
        ///pdwContentType: DWORD*
        ///pdwFormatType: DWORD*
        ///phCertStore: HCERTSTORE*
        ///phMsg: HCRYPTMSG*
        ///ppvContext: void**
        [DllImport("crypt32.dll", EntryPoint = "CryptQueryObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptQueryObject(uint dwObjectType, IntPtr pvObject, uint dwExpectedContentTypeFlags, uint dwExpectedFormatTypeFlags, uint dwFlags, ref uint pdwMsgAndCertEncodingType, ref uint pdwContentType, ref uint pdwFormatType, ref IntPtr phCertStore, ref IntPtr phMsg, ref IntPtr ppvContext);


        /// Return Type: BOOL->int
        ///pDataIn: LPVOID->void*
        ///cbDataIn: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptProtectMemory")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptProtectMemory(IntPtr pDataIn, uint cbDataIn, uint dwFlags);


        /// Return Type: BOOL->int
        ///pDataIn: DATA_BLOB*
        ///szDataDescr: LPCWSTR->WCHAR*
        ///pOptionalEntropy: DATA_BLOB*
        ///pvReserved: PVOID->void*
        ///pPromptStruct: CRYPTPROTECT_PROMPTSTRUCT*
        ///dwFlags: DWORD->unsigned int
        ///pDataOut: DATA_BLOB*
        [DllImport("crypt32.dll", EntryPoint = "CryptProtectData")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptProtectData(ref CRYPT_ATTR_BLOB pDataIn, [In] [MarshalAs(UnmanagedType.LPWStr)] string szDataDescr, ref CRYPT_ATTR_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, uint dwFlags, ref CRYPT_ATTR_BLOB pDataOut);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwEncodingType: DWORD->unsigned int
        ///pbSignerInfo: PBYTE->BYTE*
        ///cbSignerInfo: DWORD->unsigned int
        ///pbSignerInfoCountersignature: PBYTE->BYTE*
        ///cbSignerInfoCountersignature: DWORD->unsigned int
        ///dwSignerType: DWORD->unsigned int
        ///pvSigner: void*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgVerifyCountersignatureEncodedEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgVerifyCountersignatureEncodedEx(uint hCryptProv, uint dwEncodingType, ref byte pbSignerInfo, uint cbSignerInfo, ref byte pbSignerInfoCountersignature, uint cbSignerInfoCountersignature, uint dwSignerType, IntPtr pvSigner, uint dwFlags, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwEncodingType: DWORD->unsigned int
        ///pbSignerInfo: PBYTE->BYTE*
        ///cbSignerInfo: DWORD->unsigned int
        ///pbSignerInfoCountersignature: PBYTE->BYTE*
        ///cbSignerInfoCountersignature: DWORD->unsigned int
        ///pciCountersigner: PCERT_INFO->_CERT_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgVerifyCountersignatureEncoded")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgVerifyCountersignatureEncoded(uint hCryptProv, uint dwEncodingType, ref byte pbSignerInfo, uint cbSignerInfo, ref byte pbSignerInfoCountersignature, uint cbSignerInfoCountersignature, ref CERT_INFO pciCountersigner);


        /// Return Type: BOOL->int
        ///hCryptMsg: HCRYPTMSG->void*
        ///pbData: BYTE*
        ///cbData: DWORD->unsigned int
        ///fFinal: BOOL->int
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgUpdate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgUpdate(IntPtr hCryptMsg, ref byte pbData, uint cbData, [MarshalAs(UnmanagedType.Bool)] bool fFinal);


        /// Return Type: BOOL->int
        ///dwMsgEncodingType: DWORD->unsigned int
        ///pbCtlContent: BYTE*
        ///cbCtlContent: DWORD->unsigned int
        ///pSignInfo: PCMSG_SIGNED_ENCODE_INFO->_CMSG_SIGNED_ENCODE_INFO*
        ///dwFlags: DWORD->unsigned int
        ///pbEncoded: BYTE*
        ///pcbEncoded: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgSignCTL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgSignCTL(uint dwMsgEncodingType, ref byte pbCtlContent, uint cbCtlContent, ref CMSG_SIGNED_ENCODE_INFO pSignInfo, uint dwFlags, ref byte pbEncoded, ref uint pcbEncoded);


        /// Return Type: HCRYPTMSG->void*
        ///dwMsgEncodingType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwMsgType: DWORD->unsigned int
        ///pvMsgEncodeInfo: void*
        ///pszInnerContentObjID: LPSTR->CHAR*
        ///pStreamInfo: PCMSG_STREAM_INFO->_CMSG_STREAM_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgOpenToEncode")]
        public static extern IntPtr CryptMsgOpenToEncode(uint dwMsgEncodingType, uint dwFlags, uint dwMsgType, IntPtr pvMsgEncodeInfo, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszInnerContentObjID, ref CMSG_STREAM_INFO pStreamInfo);


        /// Return Type: HCRYPTMSG->void*
        ///dwMsgEncodingType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwMsgType: DWORD->unsigned int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///pRecipientInfo: PCERT_INFO->_CERT_INFO*
        ///pStreamInfo: PCMSG_STREAM_INFO->_CMSG_STREAM_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgOpenToDecode")]
        public static extern IntPtr CryptMsgOpenToDecode(uint dwMsgEncodingType, uint dwFlags, uint dwMsgType, uint hCryptProv, ref CERT_INFO pRecipientInfo, ref CMSG_STREAM_INFO pStreamInfo);


        /// Return Type: BOOL->int
        ///hCryptMsg: HCRYPTMSG->void*
        ///dwParamType: DWORD->unsigned int
        ///dwIndex: DWORD->unsigned int
        ///pvData: void*
        ///pcbData: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgGetParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgGetParam(IntPtr hCryptMsg, uint dwParamType, uint dwIndex, IntPtr pvData, ref uint pcbData);


        /// Return Type: BOOL->int
        ///hCryptMsg: HCRYPTMSG->void*
        ///cSignerStore: DWORD->unsigned int
        ///rghSignerStore: HCERTSTORE*
        ///dwFlags: DWORD->unsigned int
        ///ppSigner: PCCERT_CONTEXT*
        ///pdwSignerIndex: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgGetAndVerifySigner")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgGetAndVerifySigner(IntPtr hCryptMsg, uint cSignerStore, ref IntPtr rghSignerStore, uint dwFlags, ref IntPtr ppSigner, ref uint pdwSignerIndex);


        /// Return Type: BOOL->int
        ///dwMsgEncodingType: DWORD->unsigned int
        ///pCtlInfo: PCTL_INFO->_CTL_INFO*
        ///pSignInfo: PCMSG_SIGNED_ENCODE_INFO->_CMSG_SIGNED_ENCODE_INFO*
        ///dwFlags: DWORD->unsigned int
        ///pbEncoded: BYTE*
        ///pcbEncoded: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgEncodeAndSignCTL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgEncodeAndSignCTL(uint dwMsgEncodingType, ref CTL_INFO pCtlInfo, ref CMSG_SIGNED_ENCODE_INFO pSignInfo, uint dwFlags, ref byte pbEncoded, ref uint pcbEncoded);


        /// Return Type: HCRYPTMSG->void*
        ///hCryptMsg: HCRYPTMSG->void*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgDuplicate")]
        public static extern IntPtr CryptMsgDuplicate(IntPtr hCryptMsg);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pbSignerInfo: PBYTE->BYTE*
        ///cbSignerInfo: DWORD->unsigned int
        ///cCountersigners: DWORD->unsigned int
        ///rgCountersigners: PCMSG_SIGNER_ENCODE_INFO->_CMSG_SIGNER_ENCODE_INFO*
        ///pbCountersignature: PBYTE->BYTE*
        ///pcbCountersignature: PDWORD->DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgCountersignEncoded")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgCountersignEncoded(uint dwEncodingType, ref byte pbSignerInfo, uint cbSignerInfo, uint cCountersigners, ref CMSG_SIGNER_ENCODE_INFO rgCountersigners, ref byte pbCountersignature, ref uint pcbCountersignature);


        /// Return Type: BOOL->int
        ///hCryptMsg: HCRYPTMSG->void*
        ///dwIndex: DWORD->unsigned int
        ///cCountersigners: DWORD->unsigned int
        ///rgCountersigners: PCMSG_SIGNER_ENCODE_INFO->_CMSG_SIGNER_ENCODE_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgCountersign")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgCountersign(IntPtr hCryptMsg, uint dwIndex, uint cCountersigners, ref CMSG_SIGNER_ENCODE_INFO rgCountersigners);


        /// Return Type: BOOL->int
        ///hCryptMsg: HCRYPTMSG->void*
        ///dwFlags: DWORD->unsigned int
        ///dwCtrlType: DWORD->unsigned int
        ///pvCtrlPara: void*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgControl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgControl(IntPtr hCryptMsg, uint dwFlags, uint dwCtrlType, IntPtr pvCtrlPara);


        /// Return Type: BOOL->int
        ///hCryptMsg: HCRYPTMSG->void*
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgClose")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptMsgClose(IntPtr hCryptMsg);


        /// Return Type: DWORD->unsigned int
        ///dwMsgEncodingType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwMsgType: DWORD->unsigned int
        ///pvMsgEncodeInfo: void*
        ///pszInnerContentObjID: LPSTR->CHAR*
        ///cbData: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptMsgCalculateEncodedLength")]
        public static extern uint CryptMsgCalculateEncodedLength(uint dwMsgEncodingType, uint dwFlags, uint dwMsgType, IntPtr pvMsgEncodeInfo, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszInnerContentObjID, uint cbData);


        /// Return Type: LPVOID->void*
        ///pv: LPVOID->void*
        ///cbSize: ULONG->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptMemRealloc")]
        public static extern IntPtr CryptMemRealloc(IntPtr pv, uint cbSize);


        /// Return Type: void
        ///pv: LPVOID->void*
        [DllImport("crypt32.dll", EntryPoint = "CryptMemFree")]
        public static extern void CryptMemFree(IntPtr pv);


        /// Return Type: LPVOID->void*
        ///cbSize: ULONG->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptMemAlloc")]
        public static extern IntPtr CryptMemAlloc(uint cbSize);


        /// Return Type: BOOL->int
        ///hModule: HMODULE->HINSTANCE->HINSTANCE__*
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///cFuncEntry: DWORD->unsigned int
        ///rgFuncEntry: CRYPT_OID_FUNC_ENTRY*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptInstallOIDFunctionAddress")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptInstallOIDFunctionAddress(IntPtr hModule, uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, uint cFuncEntry, ref CRYPT_OID_FUNC_ENTRY rgFuncEntry, uint dwFlags);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwDefaultType: DWORD->unsigned int
        ///pvDefaultPara: void*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        ///phDefaultContext: HCRYPTDEFAULTCONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CryptInstallDefaultContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptInstallDefaultContext(uint hCryptProv, uint dwDefaultType, IntPtr pvDefaultPara, uint dwFlags, IntPtr pvReserved, ref IntPtr phDefaultContext);


        /// Return Type: BOOL->int
        ///pfnCancel: PFN_CRYPT_CANCEL_RETRIEVAL
        ///pvArg: void*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("cryptnet.dll", EntryPoint = "CryptInstallCancelRetrieval")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptInstallCancelRetrieval(PFN_CRYPT_CANCEL_RETRIEVAL pfnCancel, IntPtr pvArg, uint dwFlags, IntPtr pvReserved);


        /// Return Type: HCRYPTOIDFUNCSET->void*
        ///pszFuncName: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptInitOIDFunctionSet")]
        public static extern IntPtr CryptInitOIDFunctionSet([In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, uint dwFlags);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        ///aiKeyAlg: ALG_ID->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvAuxInfo: void*
        ///phKey: HCRYPTKEY*
        [DllImport("crypt32.dll", EntryPoint = "CryptImportPublicKeyInfoEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptImportPublicKeyInfoEx(uint hCryptProv, uint dwCertEncodingType, ref CERT_PUBLIC_KEY_INFO pInfo, uint aiKeyAlg, uint dwFlags, IntPtr pvAuxInfo, ref uint phKey);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        ///phKey: HCRYPTKEY*
        [DllImport("crypt32.dll", EntryPoint = "CryptImportPublicKeyInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptImportPublicKeyInfo(uint hCryptProv, uint dwCertEncodingType, ref CERT_PUBLIC_KEY_INFO pInfo, ref uint phKey);


        /// Return Type: BOOL->int
        ///sImportParams: CRYPT_PKCS8_IMPORT_PARAMS->_CRYPT_PKCS8_IMPORT_PARAMS
        ///dwFlags: DWORD->unsigned int
        ///phCryptProv: HCRYPTPROV*
        ///pvAuxInfo: void*
        [DllImport("crypt32.dll", EntryPoint = "CryptImportPKCS8")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptImportPKCS8(CRYPT_PRIVATE_KEY_BLOB_AND_PARAMS sImportParams, uint dwFlags, ref uint phCryptProv, IntPtr pvAuxInfo);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///pbData: BYTE*
        ///dwDataLen: DWORD->unsigned int
        ///hPubKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///phKey: HCRYPTKEY*
        [DllImport("advapi32.dll", EntryPoint = "CryptImportKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptImportKey(uint hProv, ref byte pbData, uint dwDataLen, uint hPubKey, uint dwFlags, ref uint phKey);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pbEncoded: BYTE*
        ///cbEncoded: DWORD->unsigned int
        ///pbComputedHash: BYTE*
        ///pcbComputedHash: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptHashToBeSigned")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptHashToBeSigned(uint hCryptProv, uint dwCertEncodingType, ref byte pbEncoded, uint cbEncoded, ref byte pbComputedHash, ref uint pcbComputedHash);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptHashSessionKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptHashSessionKey(uint hHash, uint hKey, uint dwFlags);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///Algid: ALG_ID->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        ///pbComputedHash: BYTE*
        ///pcbComputedHash: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptHashPublicKeyInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptHashPublicKeyInfo(uint hCryptProv, uint Algid, uint dwFlags, uint dwCertEncodingType, ref CERT_PUBLIC_KEY_INFO pInfo, ref byte pbComputedHash, ref uint pcbComputedHash);


        /// Return Type: BOOL->int
        ///pHashPara: PCRYPT_HASH_MESSAGE_PARA->_CRYPT_HASH_MESSAGE_PARA*
        ///fDetachedHash: BOOL->int
        ///cToBeHashed: DWORD->unsigned int
        ///rgpbToBeHashed: BYTE**
        ///rgcbToBeHashed: DWORD*
        ///pbHashedBlob: BYTE*
        ///pcbHashedBlob: DWORD*
        ///pbComputedHash: BYTE*
        ///pcbComputedHash: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptHashMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptHashMessage(ref CRYPT_HASH_MESSAGE_PARA pHashPara, [MarshalAs(UnmanagedType.Bool)] bool fDetachedHash, uint cToBeHashed, ref IntPtr rgpbToBeHashed, ref uint rgcbToBeHashed, ref byte pbHashedBlob, ref uint pcbHashedBlob, ref byte pbComputedHash, ref uint pcbComputedHash);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///pbData: BYTE*
        ///dwDataLen: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptHashData")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptHashData(uint hHash, ref byte pbData, uint dwDataLen, uint dwFlags);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///Algid: ALG_ID->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pbEncoded: BYTE*
        ///cbEncoded: DWORD->unsigned int
        ///pbComputedHash: BYTE*
        ///pcbComputedHash: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptHashCertificate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptHashCertificate(uint hCryptProv, uint Algid, uint dwFlags, ref byte pbEncoded, uint cbEncoded, ref byte pbComputedHash, ref uint pcbComputedHash);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///phUserKey: HCRYPTKEY*
        [DllImport("advapi32.dll", EntryPoint = "CryptGetUserKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetUserKey(uint hProv, uint dwKeySpec, ref uint phUserKey);


        /// Return Type: BOOL->int
        ///pszTimeValidOid: LPCSTR->CHAR*
        ///pvPara: LPVOID->void*
        ///pIssuer: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pftValidFor: LPFILETIME->_FILETIME*
        ///dwFlags: DWORD->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///ppvObject: LPVOID*
        ///pCredentials: PCRYPT_CREDENTIALS->_CRYPT_CREDENTIALS*
        ///pvReserved: LPVOID->void*
        [DllImport("cryptnet.dll", EntryPoint = "CryptGetTimeValidObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetTimeValidObject([In] [MarshalAs(UnmanagedType.LPStr)] string pszTimeValidOid, IntPtr pvPara, ref CERT_CONTEXT pIssuer, ref FILETIME pftValidFor, uint dwFlags, uint dwTimeout, ref IntPtr ppvObject, ref CRYPT_CREDENTIALS pCredentials, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwParam: DWORD->unsigned int
        ///pbData: BYTE*
        ///pdwDataLen: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptGetProvParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetProvParam(uint hProv, uint dwParam, ref byte pbData, ref uint pdwDataLen, uint dwFlags);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///pszOID: LPCSTR->CHAR*
        ///pwszValueName: LPCWSTR->WCHAR*
        ///pdwValueType: DWORD*
        ///pbValueData: BYTE*
        ///pcbValueData: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptGetOIDFunctionValue")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetOIDFunctionValue(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOID, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszValueName, ref uint pdwValueType, ref byte pbValueData, ref uint pcbValueData);


        /// Return Type: BOOL->int
        ///hFuncSet: HCRYPTOIDFUNCSET->void*
        ///dwEncodingType: DWORD->unsigned int
        ///pszOID: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///ppvFuncAddr: void**
        ///phFuncAddr: HCRYPTOIDFUNCADDR*
        [DllImport("crypt32.dll", EntryPoint = "CryptGetOIDFunctionAddress")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetOIDFunctionAddress(IntPtr hFuncSet, uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOID, uint dwFlags, ref IntPtr ppvFuncAddr, ref IntPtr phFuncAddr);


        /// Return Type: BOOL->int
        ///pszUrlOid: LPCSTR->CHAR*
        ///pvPara: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        ///pUrlArray: PCRYPT_URL_ARRAY->_CRYPT_URL_ARRAY*
        ///pcbUrlArray: DWORD*
        ///pUrlInfo: PCRYPT_URL_INFO->_CRYPT_URL_INFO*
        ///pcbUrlInfo: DWORD*
        ///pvReserved: LPVOID->void*
        [DllImport("cryptnet.dll", EntryPoint = "CryptGetObjectUrl")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetObjectUrl([In] [MarshalAs(UnmanagedType.LPStr)] string pszUrlOid, IntPtr pvPara, uint dwFlags, ref CRYPT_URL_ARRAY pUrlArray, ref uint pcbUrlArray, ref CRYPT_URL_INFO pUrlInfo, ref uint pcbUrlInfo, IntPtr pvReserved);


        /// Return Type: LONG->int
        ///dwMsgEncodingType: DWORD->unsigned int
        ///pbSignedBlob: BYTE*
        ///cbSignedBlob: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptGetMessageSignerCount")]
        public static extern int CryptGetMessageSignerCount(uint dwMsgEncodingType, ref byte pbSignedBlob, uint cbSignedBlob);


        /// Return Type: HCERTSTORE->void*
        ///dwMsgAndCertEncodingType: DWORD->unsigned int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pbSignedBlob: BYTE*
        ///cbSignedBlob: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptGetMessageCertificates")]
        public static extern IntPtr CryptGetMessageCertificates(uint dwMsgAndCertEncodingType, uint hCryptProv, uint dwFlags, ref byte pbSignedBlob, uint cbSignedBlob);


        /// Return Type: BOOL->int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///dwParam: DWORD->unsigned int
        ///pbData: BYTE*
        ///pdwDataLen: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptGetKeyParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetKeyParam(uint hKey, uint dwParam, ref byte pbData, ref uint pdwDataLen, uint dwFlags);


        /// Return Type: BOOL->int
        ///pKeyIdentifier: CRYPT_HASH_BLOB*
        ///dwPropId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pwszComputerName: LPCWSTR->WCHAR*
        ///pvReserved: void*
        ///pvData: void*
        ///pcbData: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptGetKeyIdentifierProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetKeyIdentifierProperty(ref CRYPT_ATTR_BLOB pKeyIdentifier, uint dwPropId, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszComputerName, IntPtr pvReserved, IntPtr pvData, ref uint pcbData);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///dwParam: DWORD->unsigned int
        ///pbData: BYTE*
        ///pdwDataLen: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptGetHashParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetHashParam(uint hHash, uint dwParam, ref byte pbData, ref uint pdwDataLen, uint dwFlags);


        /// Return Type: BOOL->int
        ///dwProvType: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///pszProvName: LPWSTR->WCHAR*
        ///pcbProvName: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptGetDefaultProviderW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetDefaultProviderW(uint dwProvType, ref uint pdwReserved, uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszProvName, ref uint pcbProvName);


        /// Return Type: BOOL->int
        ///dwProvType: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///pszProvName: LPSTR->CHAR*
        ///pcbProvName: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptGetDefaultProviderA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetDefaultProviderA(uint dwProvType, ref uint pdwReserved, uint dwFlags, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszProvName, ref uint pcbProvName);


        /// Return Type: BOOL->int
        ///hFuncSet: HCRYPTOIDFUNCSET->void*
        ///dwEncodingType: DWORD->unsigned int
        ///pwszDll: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///ppvFuncAddr: void**
        ///phFuncAddr: HCRYPTOIDFUNCADDR*
        [DllImport("crypt32.dll", EntryPoint = "CryptGetDefaultOIDFunctionAddress")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetDefaultOIDFunctionAddress(IntPtr hFuncSet, uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszDll, uint dwFlags, ref IntPtr ppvFuncAddr, ref IntPtr phFuncAddr);


        /// Return Type: BOOL->int
        ///hFuncSet: HCRYPTOIDFUNCSET->void*
        ///dwEncodingType: DWORD->unsigned int
        ///pwszDllList: LPWSTR->WCHAR*
        ///pcchDllList: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptGetDefaultOIDDllList")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetDefaultOIDDllList(IntPtr hFuncSet, uint dwEncodingType, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pwszDllList, ref uint pcchDllList);


        /// Return Type: BOOL->int
        ///hAsync: HCRYPTASYNC->HANDLE->void*
        ///pszParamOid: LPSTR->CHAR*
        ///ppvParam: LPVOID*
        ///ppfnFree: PFN_CRYPT_ASYNC_PARAM_FREE_FUNC*
        [DllImport("crypt32.dll", EntryPoint = "CryptGetAsyncParam")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGetAsyncParam(IntPtr hAsync, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszParamOid, ref IntPtr ppvParam, ref PFN_CRYPT_ASYNC_PARAM_FREE_FUNC ppfnFree);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwLen: DWORD->unsigned int
        ///pbBuffer: BYTE*
        [DllImport("advapi32.dll", EntryPoint = "CryptGenRandom")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGenRandom(uint hProv, uint dwLen, ref byte pbBuffer);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///Algid: ALG_ID->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///phKey: HCRYPTKEY*
        [DllImport("advapi32.dll", EntryPoint = "CryptGenKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptGenKey(uint hProv, uint Algid, uint dwFlags, ref uint phKey);


        /// Return Type: BOOL->int
        ///hFuncAddr: HCRYPTOIDFUNCADDR->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptFreeOIDFunctionAddress")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptFreeOIDFunctionAddress(IntPtr hFuncAddr, uint dwFlags);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///dwFormatType: DWORD->unsigned int
        ///dwFormatStrType: DWORD->unsigned int
        ///pFormatStruct: void*
        ///lpszStructType: LPCSTR->CHAR*
        ///pbEncoded: BYTE*
        ///cbEncoded: DWORD->unsigned int
        ///pbFormat: void*
        ///pcbFormat: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptFormatObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptFormatObject(uint dwCertEncodingType, uint dwFormatType, uint dwFormatStrType, IntPtr pFormatStruct, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszStructType, ref byte pbEncoded, uint cbEncoded, IntPtr pbFormat, ref uint pcbFormat);


        /// Return Type: BOOL->int
        ///pszFlushTimeValidOid: LPCSTR->CHAR*
        ///pvPara: LPVOID->void*
        ///pIssuer: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: LPVOID->void*
        [DllImport("cryptnet.dll", EntryPoint = "CryptFlushTimeValidObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptFlushTimeValidObject([In] [MarshalAs(UnmanagedType.LPStr)] string pszFlushTimeValidOid, IntPtr pvPara, ref CERT_CONTEXT pIssuer, uint dwFlags, IntPtr pvReserved);


        /// Return Type: PCCRYPT_OID_INFO->CRYPT_OID_INFO*
        ///dwKeyType: DWORD->unsigned int
        ///pvKey: void*
        ///dwGroupId: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CryptFindOIDInfo")]
        public static extern IntPtr CryptFindOIDInfo(uint dwKeyType, IntPtr pvKey, uint dwGroupId);


        /// Return Type: LPCWSTR->WCHAR*
        ///pwszCryptName: LPCWSTR->WCHAR*
        [DllImport("crypt32.dll", EntryPoint = "CryptFindLocalizedName")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CryptFindLocalizedName([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszCryptName);


        /// Return Type: BOOL->int
        ///pCert: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("crypt32.dll", EntryPoint = "CryptFindCertificateKeyProvInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptFindCertificateKeyProvInfo(ref CERT_CONTEXT pCert, uint dwFlags, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pszPublicKeyObjId: LPSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///pvAuxInfo: void*
        ///pInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        ///pcbInfo: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptExportPublicKeyInfoEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptExportPublicKeyInfoEx(uint hCryptProv, uint dwKeySpec, uint dwCertEncodingType, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszPublicKeyObjId, uint dwFlags, IntPtr pvAuxInfo, ref CERT_PUBLIC_KEY_INFO pInfo, ref uint pcbInfo);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pInfo: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        ///pcbInfo: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptExportPublicKeyInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptExportPublicKeyInfo(uint hCryptProv, uint dwKeySpec, uint dwCertEncodingType, ref CERT_PUBLIC_KEY_INFO pInfo, ref uint pcbInfo);


        /// Return Type: BOOL->int
        ///psExportParams: CRYPT_PKCS8_EXPORT_PARAMS*
        ///dwFlags: DWORD->unsigned int
        ///pvAuxInfo: void*
        ///pbPrivateKeyBlob: BYTE*
        ///pcbPrivateKeyBlob: DWORD*
        [DllImport("<Unknown>", EntryPoint = "CryptExportPKCS8Ex")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptExportPKCS8Ex(ref CRYPT_PKCS8_EXPORT_PARAMS psExportParams, uint dwFlags, IntPtr pvAuxInfo, ref byte pbPrivateKeyBlob, ref uint pcbPrivateKeyBlob);


        /// Return Type: BOOL->int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwKeySpec: DWORD->unsigned int
        ///pszPrivateKeyObjId: LPSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///pvAuxInfo: void*
        ///pbPrivateKeyBlob: BYTE*
        ///pcbPrivateKeyBlob: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptExportPKCS8")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptExportPKCS8(uint hCryptProv, uint dwKeySpec, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszPrivateKeyObjId, uint dwFlags, IntPtr pvAuxInfo, ref byte pbPrivateKeyBlob, ref uint pcbPrivateKeyBlob);


        /// Return Type: BOOL->int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///hExpKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///dwBlobType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pbData: BYTE*
        ///pdwDataLen: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptExportKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptExportKey(uint hKey, uint hExpKey, uint dwBlobType, uint dwFlags, ref byte pbData, ref uint pdwDataLen);


        /// Return Type: BOOL->int
        ///dwIndex: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///pdwProvType: DWORD*
        ///szTypeName: LPWSTR->WCHAR*
        ///pcbTypeName: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptEnumProviderTypesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEnumProviderTypesW(uint dwIndex, ref uint pdwReserved, uint dwFlags, ref uint pdwProvType, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szTypeName, ref uint pcbTypeName);


        /// Return Type: BOOL->int
        ///dwIndex: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///pdwProvType: DWORD*
        ///szTypeName: LPSTR->CHAR*
        ///pcbTypeName: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptEnumProviderTypesA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEnumProviderTypesA(uint dwIndex, ref uint pdwReserved, uint dwFlags, ref uint pdwProvType, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szTypeName, ref uint pcbTypeName);


        /// Return Type: BOOL->int
        ///dwIndex: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///pdwProvType: DWORD*
        ///szProvName: LPWSTR->WCHAR*
        ///pcbProvName: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptEnumProvidersW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEnumProvidersW(uint dwIndex, ref uint pdwReserved, uint dwFlags, ref uint pdwProvType, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder szProvName, ref uint pcbProvName);


        /// Return Type: BOOL->int
        ///dwIndex: DWORD->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///pdwProvType: DWORD*
        ///szProvName: LPSTR->CHAR*
        ///pcbProvName: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptEnumProvidersA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEnumProvidersA(uint dwIndex, ref uint pdwReserved, uint dwFlags, ref uint pdwProvType, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder szProvName, ref uint pcbProvName);


        /// Return Type: BOOL->int
        ///dwGroupId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvArg: void*
        ///pfnEnumOIDInfo: PFN_CRYPT_ENUM_OID_INFO
        [DllImport("crypt32.dll", EntryPoint = "CryptEnumOIDInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEnumOIDInfo(uint dwGroupId, uint dwFlags, IntPtr pvArg, PFN_CRYPT_ENUM_OID_INFO pfnEnumOIDInfo);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///pszFuncName: LPCSTR->CHAR*
        ///pszOID: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///pvArg: void*
        ///pfnEnumOIDFunc: PFN_CRYPT_ENUM_OID_FUNC
        [DllImport("crypt32.dll", EntryPoint = "CryptEnumOIDFunction")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEnumOIDFunction(uint dwEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFuncName, [In] [MarshalAs(UnmanagedType.LPStr)] string pszOID, uint dwFlags, IntPtr pvArg, PFN_CRYPT_ENUM_OID_FUNC pfnEnumOIDFunc);


        /// Return Type: BOOL->int
        ///pKeyIdentifier: CRYPT_HASH_BLOB*
        ///dwPropId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pwszComputerName: LPCWSTR->WCHAR*
        ///pvReserved: void*
        ///pvArg: void*
        ///pfnEnum: PFN_CRYPT_ENUM_KEYID_PROP
        [DllImport("crypt32.dll", EntryPoint = "CryptEnumKeyIdentifierProperties")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEnumKeyIdentifierProperties(ref CRYPT_ATTR_BLOB pKeyIdentifier, uint dwPropId, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszComputerName, IntPtr pvReserved, IntPtr pvArg, PFN_CRYPT_ENUM_KEYID_PROP pfnEnum);


        /// Return Type: BOOL->int
        ///pEncryptPara: PCRYPT_ENCRYPT_MESSAGE_PARA->_CRYPT_ENCRYPT_MESSAGE_PARA*
        ///cRecipientCert: DWORD->unsigned int
        ///rgpRecipientCert: PCCERT_CONTEXT*
        ///pbToBeEncrypted: BYTE*
        ///cbToBeEncrypted: DWORD->unsigned int
        ///pbEncryptedBlob: BYTE*
        ///pcbEncryptedBlob: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptEncryptMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEncryptMessage(ref CRYPT_ENCRYPT_MESSAGE_PARA pEncryptPara, uint cRecipientCert, ref IntPtr rgpRecipientCert, ref byte pbToBeEncrypted, uint cbToBeEncrypted, ref byte pbEncryptedBlob, ref uint pcbEncryptedBlob);


        /// Return Type: BOOL->int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///Final: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///pbData: BYTE*
        ///pdwDataLen: DWORD*
        ///dwBufLen: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptEncrypt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEncrypt(uint hKey, uint hHash, [MarshalAs(UnmanagedType.Bool)] bool Final, uint dwFlags, ref byte pbData, ref uint pdwDataLen, uint dwBufLen);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///lpszStructType: LPCSTR->CHAR*
        ///pvStructInfo: void*
        ///dwFlags: DWORD->unsigned int
        ///pEncodePara: PCRYPT_ENCODE_PARA->_CRYPT_ENCODE_PARA*
        ///pvEncoded: void*
        ///pcbEncoded: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptEncodeObjectEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEncodeObjectEx(uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszStructType, IntPtr pvStructInfo, uint dwFlags, ref CRYPT_ENCODE_PARA pEncodePara, IntPtr pvEncoded, ref uint pcbEncoded);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///lpszStructType: LPCSTR->CHAR*
        ///pvStructInfo: void*
        ///pbEncoded: BYTE*
        ///pcbEncoded: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptEncodeObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptEncodeObject(uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszStructType, IntPtr pvStructInfo, ref byte pbEncoded, ref uint pcbEncoded);


        /// Return Type: BOOL->int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///phKey: HCRYPTKEY*
        [DllImport("advapi32.dll", EntryPoint = "CryptDuplicateKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDuplicateKey(uint hKey, ref uint pdwReserved, uint dwFlags, ref uint phKey);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        ///phHash: HCRYPTHASH*
        [DllImport("advapi32.dll", EntryPoint = "CryptDuplicateHash")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDuplicateHash(uint hHash, ref uint pdwReserved, uint dwFlags, ref uint phHash);


        /// Return Type: BOOL->int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptDestroyKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDestroyKey(uint hKey);


        /// Return Type: BOOL->int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptDestroyHash")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDestroyHash(uint hHash);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///Algid: ALG_ID->unsigned int
        ///hBaseData: HCRYPTHASH->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///phKey: HCRYPTKEY*
        [DllImport("advapi32.dll", EntryPoint = "CryptDeriveKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDeriveKey(uint hProv, uint Algid, uint hBaseData, uint dwFlags, ref uint phKey);


        /// Return Type: BOOL->int
        ///pDecryptPara: PCRYPT_DECRYPT_MESSAGE_PARA->_CRYPT_DECRYPT_MESSAGE_PARA*
        ///pbEncryptedBlob: BYTE*
        ///cbEncryptedBlob: DWORD->unsigned int
        ///pbDecrypted: BYTE*
        ///pcbDecrypted: DWORD*
        ///ppXchgCert: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CryptDecryptMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecryptMessage(ref CRYPT_DECRYPT_MESSAGE_PARA pDecryptPara, ref byte pbEncryptedBlob, uint cbEncryptedBlob, ref byte pbDecrypted, ref uint pcbDecrypted, ref IntPtr ppXchgCert);


        /// Return Type: BOOL->int
        ///pDecryptPara: PCRYPT_DECRYPT_MESSAGE_PARA->_CRYPT_DECRYPT_MESSAGE_PARA*
        ///pVerifyPara: PCRYPT_VERIFY_MESSAGE_PARA->_CRYPT_VERIFY_MESSAGE_PARA*
        ///dwSignerIndex: DWORD->unsigned int
        ///pbEncryptedBlob: BYTE*
        ///cbEncryptedBlob: DWORD->unsigned int
        ///pbDecrypted: BYTE*
        ///pcbDecrypted: DWORD*
        ///ppXchgCert: PCCERT_CONTEXT*
        ///ppSignerCert: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CryptDecryptAndVerifyMessageSignature")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecryptAndVerifyMessageSignature(ref CRYPT_DECRYPT_MESSAGE_PARA pDecryptPara, ref CRYPT_VERIFY_MESSAGE_PARA pVerifyPara, uint dwSignerIndex, ref byte pbEncryptedBlob, uint cbEncryptedBlob, ref byte pbDecrypted, ref uint pcbDecrypted, ref IntPtr ppXchgCert, ref IntPtr ppSignerCert);


        /// Return Type: BOOL->int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///hHash: HCRYPTHASH->ULONG_PTR->unsigned int
        ///Final: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///pbData: BYTE*
        ///pdwDataLen: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CryptDecrypt")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecrypt(uint hKey, uint hHash, [MarshalAs(UnmanagedType.Bool)] bool Final, uint dwFlags, ref byte pbData, ref uint pdwDataLen);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///lpszStructType: LPCSTR->CHAR*
        ///pbEncoded: BYTE*
        ///cbEncoded: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pDecodePara: PCRYPT_DECODE_PARA->_CRYPT_DECODE_PARA*
        ///pvStructInfo: void*
        ///pcbStructInfo: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptDecodeObjectEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecodeObjectEx(uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszStructType, ref byte pbEncoded, uint cbEncoded, uint dwFlags, ref CRYPT_DECODE_PARA pDecodePara, IntPtr pvStructInfo, ref uint pcbStructInfo);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///lpszStructType: LPCSTR->CHAR*
        ///pbEncoded: BYTE*
        ///cbEncoded: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvStructInfo: void*
        ///pcbStructInfo: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptDecodeObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecodeObject(uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszStructType, ref byte pbEncoded, uint cbEncoded, uint dwFlags, IntPtr pvStructInfo, ref uint pcbStructInfo);


        /// Return Type: BOOL->int
        ///dwMsgTypeFlags: DWORD->unsigned int
        ///pDecryptPara: PCRYPT_DECRYPT_MESSAGE_PARA->_CRYPT_DECRYPT_MESSAGE_PARA*
        ///pVerifyPara: PCRYPT_VERIFY_MESSAGE_PARA->_CRYPT_VERIFY_MESSAGE_PARA*
        ///dwSignerIndex: DWORD->unsigned int
        ///pbEncodedBlob: BYTE*
        ///cbEncodedBlob: DWORD->unsigned int
        ///dwPrevInnerContentType: DWORD->unsigned int
        ///pdwMsgType: DWORD*
        ///pdwInnerContentType: DWORD*
        ///pbDecoded: BYTE*
        ///pcbDecoded: DWORD*
        ///ppXchgCert: PCCERT_CONTEXT*
        ///ppSignerCert: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CryptDecodeMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecodeMessage(uint dwMsgTypeFlags, ref CRYPT_DECRYPT_MESSAGE_PARA pDecryptPara, ref CRYPT_VERIFY_MESSAGE_PARA pVerifyPara, uint dwSignerIndex, ref byte pbEncodedBlob, uint cbEncodedBlob, uint dwPrevInnerContentType, ref uint pdwMsgType, ref uint pdwInnerContentType, ref byte pbDecoded, ref uint pcbDecoded, ref IntPtr ppXchgCert, ref IntPtr ppSignerCert);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pszPubKeyOID: LPCSTR->CHAR*
        ///pPubKeyStruc: PUBLICKEYSTRUC*
        ///cbPubKeyStruc: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        ///pbHash: BYTE*
        ///pcbHash: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptCreateKeyIdentifierFromCSP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptCreateKeyIdentifierFromCSP(uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszPubKeyOID, ref PUBLICKEYSTRUC pPubKeyStruc, uint cbPubKeyStruc, uint dwFlags, IntPtr pvReserved, ref byte pbHash, ref uint pcbHash);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///Algid: ALG_ID->unsigned int
        ///hKey: HCRYPTKEY->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///phHash: HCRYPTHASH*
        [DllImport("advapi32.dll", EntryPoint = "CryptCreateHash")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptCreateHash(uint hProv, uint Algid, uint hKey, uint dwFlags, ref uint phHash);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///phAsync: PHCRYPTASYNC->HANDLE*
        [DllImport("crypt32.dll", EntryPoint = "CryptCreateAsyncHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptCreateAsyncHandle(uint dwFlags, ref IntPtr phAsync);


        /// Return Type: BOOL->int
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///pdwReserved: DWORD*
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptContextAddRef")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptContextAddRef(uint hProv, ref uint pdwReserved, uint dwFlags);


        /// Return Type: BOOL->int
        ///hAsync: HCRYPTASYNC->HANDLE->void*
        [DllImport("crypt32.dll", EntryPoint = "CryptCloseAsyncHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptCloseAsyncHandle(IntPtr hAsync);


        /// Return Type: BOOL->int
        ///hAsyncRetrieval: HCRYPTASYNC->HANDLE->void*
        [DllImport("cryptnet.dll", EntryPoint = "CryptCancelAsyncRetrieval")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptCancelAsyncRetrieval(IntPtr hAsyncRetrieval);


        /// Return Type: BOOL->int
        ///pbBinary: BYTE*
        ///cbBinary: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pszString: LPWSTR->WCHAR*
        ///pcchString: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptBinaryToStringW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptBinaryToStringW(ref byte pbBinary, uint cbBinary, uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszString, ref uint pcchString);


        /// Return Type: BOOL->int
        ///pbBinary: BYTE*
        ///cbBinary: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pszString: LPSTR->CHAR*
        ///pcchString: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CryptBinaryToStringA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptBinaryToStringA(ref byte pbBinary, uint cbBinary, uint dwFlags, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszString, ref uint pcchString);


        /// Return Type: BOOL->int
        ///phProv: HCRYPTPROV*
        ///szContainer: LPCWSTR->WCHAR*
        ///szProvider: LPCWSTR->WCHAR*
        ///dwProvType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptAcquireContextW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptAcquireContextW(ref uint phProv, [In] [MarshalAs(UnmanagedType.LPWStr)] string szContainer, [In] [MarshalAs(UnmanagedType.LPWStr)] string szProvider, uint dwProvType, uint dwFlags);


        /// Return Type: BOOL->int
        ///phProv: HCRYPTPROV*
        ///szContainer: LPCSTR->CHAR*
        ///szProvider: LPCSTR->CHAR*
        ///dwProvType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        [DllImport("advapi32.dll", EntryPoint = "CryptAcquireContextA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptAcquireContextA(ref uint phProv, [In] [MarshalAs(UnmanagedType.LPStr)] string szContainer, [In] [MarshalAs(UnmanagedType.LPStr)] string szProvider, uint dwProvType, uint dwFlags);


        /// Return Type: BOOL->int
        ///pCert: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        ///phCryptProv: HCRYPTPROV*
        ///pdwKeySpec: DWORD*
        ///pfCallerFreeProv: BOOL*
        [DllImport("crypt32.dll", EntryPoint = "CryptAcquireCertificatePrivateKey")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptAcquireCertificatePrivateKey(ref CERT_CONTEXT pCert, uint dwFlags, IntPtr pvReserved, ref uint phCryptProv, ref uint pdwKeySpec, ref int pfCallerFreeProv);


        /// Return Type: HWINSTA->HWINSTA__*
        ///lpwinsta: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateWindowStationW")]
        public static extern IntPtr CreateWindowStationW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpwinsta, uint dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);


        /// Return Type: HWINSTA->HWINSTA__*
        ///lpwinsta: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateWindowStationA")]
        public static extern IntPtr CreateWindowStationA([In] [MarshalAs(UnmanagedType.LPStr)] string lpwinsta, uint dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);


        /// Return Type: HWND->HWND__*
        ///dwExStyle: DWORD->unsigned int
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "CreateWindowExW")]
        public static extern IntPtr CreateWindowExW(uint dwExStyle, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);


        /// Return Type: HWND->HWND__*
        ///dwExStyle: DWORD->unsigned int
        ///lpClassName: LPCSTR->CHAR*
        ///lpWindowName: LPCSTR->CHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hMenu: HMENU->HMENU__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "CreateWindowExA")]
        public static extern IntPtr CreateWindowExA(uint dwExStyle, [In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hMenu, [In] IntPtr hInstance, [In] IntPtr lpParam);


        /// Return Type: BOOL->int
        ///WellKnownSidType: WELL_KNOWN_SID_TYPE->Anonymous_2a66b804_5814_4d7a_8190_9d15131e188a
        ///DomainSid: PSID->PVOID->void*
        ///pSid: PSID->PVOID->void*
        ///cbSid: DWORD*
        [DllImport("advapi32.dll", EntryPoint = "CreateWellKnownSid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateWellKnownSid(WELL_KNOWN_SID_TYPE WellKnownSidType, [In] IntPtr DomainSid, IntPtr pSid, ref uint cbSid);


        /// Return Type: HANDLE->void*
        ///lpTimerAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///lpTimerName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateWaitableTimerW")]
        public static extern IntPtr CreateWaitableTimerW([In] IntPtr lpTimerAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTimerName);


        /// Return Type: HANDLE->void*
        ///lpTimerAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///lpTimerName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateWaitableTimerA")]
        public static extern IntPtr CreateWaitableTimerA([In] IntPtr lpTimerAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTimerName);


        /// Return Type: HRESULT->LONG->int
        ///pMkCtx: LPMONIKER->IMoniker*
        ///szURL: LPCWSTR->WCHAR*
        ///ppmk: LPMONIKER*
        ///dwFlags: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CreateURLMonikerEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateURLMonikerEx(ref IMoniker pMkCtx, [In] [MarshalAs(UnmanagedType.LPWStr)] string szURL, ref IntPtr ppmk, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///pMkCtx: LPMONIKER->IMoniker*
        ///szURL: LPCWSTR->WCHAR*
        ///ppmk: LPMONIKER*
        [DllImport("urlmon.dll", EntryPoint = "CreateURLMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateURLMoniker(ref IMoniker pMkCtx, [In] [MarshalAs(UnmanagedType.LPWStr)] string szURL, ref IntPtr ppmk);


        /// Return Type: HRESULT->LONG->int
        ///lpszUrl: LPCWSTR->WCHAR*
        ///pbc: IBindCtx*
        ///ppBdg: IBinding**
        [DllImport("<Unknown>", EntryPoint = "CreateURLBinding", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateURLBinding([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszUrl, ref IBindCtx pbc, ref IntPtr ppBdg);


        /// Return Type: HRESULT->LONG->int
        ///syskind: SYSKIND->tagSYSKIND
        ///szFile: LPCOLESTR->OLECHAR*
        ///ppctlib: ICreateTypeLib2**
        [DllImport("oleaut32.dll", EntryPoint = "CreateTypeLib2", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateTypeLib2(tagSYSKIND syskind, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFile, ref IntPtr ppctlib);


        /// Return Type: HRESULT->LONG->int
        ///syskind: SYSKIND->tagSYSKIND
        ///szFile: OLECHAR*
        ///ppctlib: ICreateTypeLib**
        [DllImport("oleaut32.dll", EntryPoint = "CreateTypeLib", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateTypeLib(tagSYSKIND syskind, [In] [MarshalAs(UnmanagedType.LPWStr)] string szFile, ref IntPtr ppctlib);


        /// Return Type: BOOL->int
        ///phNewTimer: PHANDLE->HANDLE*
        ///TimerQueue: HANDLE->void*
        ///Callback: WAITORTIMERCALLBACK->WAITORTIMERCALLBACKFUNC
        ///Parameter: PVOID->void*
        ///DueTime: DWORD->unsigned int
        ///Period: DWORD->unsigned int
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateTimerQueueTimer(out IntPtr phNewTimer, [In] IntPtr TimerQueue, WAITORTIMERCALLBACKFUNC Callback, [In] IntPtr Parameter, uint DueTime, uint Period, uint Flags);


        /// Return Type: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateTimerQueue")]
        public static extern IntPtr CreateTimerQueue();


        /// Return Type: HANDLE->void*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwStackSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpStartAddress: LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        ///lpParameter: LPVOID->void*
        ///dwCreationFlags: DWORD->unsigned int
        ///lpThreadId: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "CreateThread")]
        public static extern IntPtr CreateThread([In] IntPtr lpThreadAttributes, uint dwStackSize, PTHREAD_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);


        /// Return Type: DWORD->unsigned int
        ///hDevice: HANDLE->void*
        ///dwPartitionMethod: DWORD->unsigned int
        ///dwCount: DWORD->unsigned int
        ///dwSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateTapePartition")]
        public static extern uint CreateTapePartition([In] IntPtr hDevice, uint dwPartitionMethod, uint dwCount, uint dwSize);


        /// Return Type: HRESULT->LONG->int
        ///hGlobal: HGLOBAL->HANDLE->void*
        ///fDeleteOnRelease: BOOL->int
        ///ppstm: LPSTREAM*
        [DllImport("ole32.dll", EntryPoint = "CreateStreamOnHGlobal", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateStreamOnHGlobal(IntPtr hGlobal, [MarshalAs(UnmanagedType.Bool)] bool fDeleteOnRelease, ref IntPtr ppstm);


        /// Return Type: HRESULT->LONG->int
        ///hwndParent: HWND->HWND__*
        ///pszTitle: LPCOLESTR->OLECHAR*
        ///pIbscCaller: IBindStatusCallback*
        ///ppIbsc: IBindStatusCallback**
        [DllImport("ole32.dll", EntryPoint = "CreateStdProgressIndicator", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateStdProgressIndicator(IntPtr hwndParent, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszTitle, ref IBindStatusCallback pIbscCaller, ref IntPtr ppIbsc);


        /// Return Type: HRESULT->LONG->int
        ///punkOuter: IUnknown*
        ///pvThis: void*
        ///ptinfo: ITypeInfo*
        ///ppunkStdDisp: IUnknown**
        [DllImport("oleaut32.dll", EntryPoint = "CreateStdDispatch", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateStdDispatch(ref IUnknown punkOuter, IntPtr pvThis, ref ITypeInfo ptinfo, ref IntPtr ppunkStdDisp);


        /// Return Type: HBRUSH->HBRUSH__*
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush")]
        public static extern IntPtr CreateSolidBrush(uint color);


        /// Return Type: SC_HANDLE->SC_HANDLE__*
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpServiceName: LPCWSTR->WCHAR*
        ///lpDisplayName: LPCWSTR->WCHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwServiceType: DWORD->unsigned int
        ///dwStartType: DWORD->unsigned int
        ///dwErrorControl: DWORD->unsigned int
        ///lpBinaryPathName: LPCWSTR->WCHAR*
        ///lpLoadOrderGroup: LPCWSTR->WCHAR*
        ///lpdwTagId: LPDWORD->DWORD*
        ///lpDependencies: LPCWSTR->WCHAR*
        ///lpServiceStartName: LPCWSTR->WCHAR*
        ///lpPassword: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "CreateServiceW")]
        public static extern IntPtr CreateServiceW([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpServiceName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDisplayName, uint dwDesiredAccess, uint dwServiceType, uint dwStartType, uint dwErrorControl, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBinaryPathName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpLoadOrderGroup, IntPtr lpdwTagId, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDependencies, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpServiceStartName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPassword);


        /// Return Type: SC_HANDLE->SC_HANDLE__*
        ///hSCManager: SC_HANDLE->SC_HANDLE__*
        ///lpServiceName: LPCSTR->CHAR*
        ///lpDisplayName: LPCSTR->CHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwServiceType: DWORD->unsigned int
        ///dwStartType: DWORD->unsigned int
        ///dwErrorControl: DWORD->unsigned int
        ///lpBinaryPathName: LPCSTR->CHAR*
        ///lpLoadOrderGroup: LPCSTR->CHAR*
        ///lpdwTagId: LPDWORD->DWORD*
        ///lpDependencies: LPCSTR->CHAR*
        ///lpServiceStartName: LPCSTR->CHAR*
        ///lpPassword: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "CreateServiceA")]
        public static extern IntPtr CreateServiceA([In] ref SC_HANDLE__ hSCManager, [In] [MarshalAs(UnmanagedType.LPStr)] string lpServiceName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDisplayName, uint dwDesiredAccess, uint dwServiceType, uint dwStartType, uint dwErrorControl, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBinaryPathName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpLoadOrderGroup, IntPtr lpdwTagId, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDependencies, [In] [MarshalAs(UnmanagedType.LPStr)] string lpServiceStartName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPassword);


        /// Return Type: HANDLE->void*
        ///lpSemaphoreAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lInitialCount: LONG->int
        ///lMaximumCount: LONG->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateSemaphoreW")]
        public static extern IntPtr CreateSemaphoreW([In] IntPtr lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///lpSemaphoreAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lInitialCount: LONG->int
        ///lMaximumCount: LONG->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateSemaphoreA")]
        public static extern IntPtr CreateSemaphoreA([In] IntPtr lpSemaphoreAttributes, int lInitialCount, int lMaximumCount, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: BOOL->int
        ///fdwHidden: DWORD->unsigned int
        ///lpszFont: LPCWSTR->WCHAR*
        ///lpszFile: LPCWSTR->WCHAR*
        ///lpszPath: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateScalableFontResourceW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateScalableFontResourceW(uint fdwHidden, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFont, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFile, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszPath);


        /// Return Type: BOOL->int
        ///fdwHidden: DWORD->unsigned int
        ///lpszFont: LPCSTR->CHAR*
        ///lpszFile: LPCSTR->CHAR*
        ///lpszPath: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateScalableFontResourceA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateScalableFontResourceA(uint fdwHidden, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszFont, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszFile, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszPath);


        /// Return Type: HRGN->HRGN__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        ///w: int
        ///h: int
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);


        /// Return Type: BOOL->int
        ///ExistingTokenHandle: HANDLE->void*
        ///Flags: DWORD->unsigned int
        ///DisableSidCount: DWORD->unsigned int
        ///SidsToDisable: PSID_AND_ATTRIBUTES->_SID_AND_ATTRIBUTES*
        ///DeletePrivilegeCount: DWORD->unsigned int
        ///PrivilegesToDelete: PLUID_AND_ATTRIBUTES->_LUID_AND_ATTRIBUTES*
        ///RestrictedSidCount: DWORD->unsigned int
        ///SidsToRestrict: PSID_AND_ATTRIBUTES->_SID_AND_ATTRIBUTES*
        ///NewTokenHandle: PHANDLE->HANDLE*
        [DllImport("advapi32.dll", EntryPoint = "CreateRestrictedToken")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateRestrictedToken([In] IntPtr ExistingTokenHandle, uint Flags, uint DisableSidCount, [In] IntPtr SidsToDisable, uint DeletePrivilegeCount, [In] IntPtr PrivilegesToDelete, uint RestrictedSidCount, [In] IntPtr SidsToRestrict, out IntPtr NewTokenHandle);


        /// Return Type: HANDLE->void*
        ///hProcess: HANDLE->void*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwStackSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpStartAddress: LPTHREAD_START_ROUTINE->PTHREAD_START_ROUTINE
        ///lpParameter: LPVOID->void*
        ///dwCreationFlags: DWORD->unsigned int
        ///lpThreadId: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "CreateRemoteThread")]
        public static extern IntPtr CreateRemoteThread([In] IntPtr hProcess, [In] IntPtr lpThreadAttributes, uint dwStackSize, PTHREAD_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);


        /// Return Type: HRGN->HRGN__*
        ///lprect: RECT*
        [DllImport("gdi32.dll", EntryPoint = "CreateRectRgnIndirect")]
        public static extern IntPtr CreateRectRgnIndirect([In] ref tagRECT lprect);


        /// Return Type: HRGN->HRGN__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        [DllImport("gdi32.dll", EntryPoint = "CreateRectRgn")]
        public static extern IntPtr CreateRectRgn(int x1, int y1, int x2, int y2);


        /// Return Type: HPROPSHEETPAGE->_PSP*
        ///constPropSheetPagePointer: LPCPROPSHEETPAGEW->LPCPROPSHEETPAGEW_V3->PROPSHEETPAGEW_V3*
        [DllImport("comctl32.dll", EntryPoint = "CreatePropertySheetPageW")]
        public static extern IntPtr CreatePropertySheetPageW(ref PROPSHEETPAGEW_V3 constPropSheetPagePointer);


        /// Return Type: HPROPSHEETPAGE->_PSP*
        ///constPropSheetPagePointer: LPCPROPSHEETPAGEA->LPCPROPSHEETPAGEA_V3->PROPSHEETPAGEA_V3*
        [DllImport("comctl32.dll", EntryPoint = "CreatePropertySheetPageA")]
        public static extern IntPtr CreatePropertySheetPageA(ref PROPSHEETPAGEA_V3 constPropSheetPagePointer);


        /// Return Type: BOOL->int
        ///hToken: HANDLE->void*
        ///dwLogonFlags: DWORD->unsigned int
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpCommandLine: LPWSTR->WCHAR*
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCWSTR->WCHAR*
        ///lpStartupInfo: LPSTARTUPINFOW->_STARTUPINFOW*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("advapi32.dll", EntryPoint = "CreateProcessWithTokenW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessWithTokenW([In] IntPtr hToken, uint dwLogonFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, IntPtr lpCommandLine, uint dwCreationFlags, [In] IntPtr lpEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, [In] ref STARTUPINFOW lpStartupInfo, [Out] out PROCESS_INFORMATION lpProcessInformation);


        /// Return Type: BOOL->int
        ///lpUsername: LPCWSTR->WCHAR*
        ///lpDomain: LPCWSTR->WCHAR*
        ///lpPassword: LPCWSTR->WCHAR*
        ///dwLogonFlags: DWORD->unsigned int
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpCommandLine: LPWSTR->WCHAR*
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCWSTR->WCHAR*
        ///lpStartupInfo: LPSTARTUPINFOW->_STARTUPINFOW*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("advapi32.dll", EntryPoint = "CreateProcessWithLogonW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessWithLogonW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpUsername, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDomain, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPassword, uint dwLogonFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, IntPtr lpCommandLine, uint dwCreationFlags, [In] IntPtr lpEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, [In] ref STARTUPINFOW lpStartupInfo, [Out] out PROCESS_INFORMATION lpProcessInformation);


        /// Return Type: BOOL->int
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpCommandLine: LPWSTR->WCHAR*
        ///lpProcessAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInheritHandles: BOOL->int
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCWSTR->WCHAR*
        ///lpStartupInfo: LPSTARTUPINFOW->_STARTUPINFOW*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "CreateProcessW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, IntPtr lpCommandLine, [In] IntPtr lpProcessAttributes, [In] IntPtr lpThreadAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles, uint dwCreationFlags, [In] IntPtr lpEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, [In] ref STARTUPINFOW lpStartupInfo, [Out] out PROCESS_INFORMATION lpProcessInformation);


        /// Return Type: BOOL->int
        ///hToken: HANDLE->void*
        ///lpApplicationName: LPCWSTR->WCHAR*
        ///lpCommandLine: LPWSTR->WCHAR*
        ///lpProcessAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInheritHandles: BOOL->int
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCWSTR->WCHAR*
        ///lpStartupInfo: LPSTARTUPINFOW->_STARTUPINFOW*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("advapi32.dll", EntryPoint = "CreateProcessAsUserW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessAsUserW([In] IntPtr hToken, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName, IntPtr lpCommandLine, [In] IntPtr lpProcessAttributes, [In] IntPtr lpThreadAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles, uint dwCreationFlags, [In] IntPtr lpEnvironment, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory, [In] ref STARTUPINFOW lpStartupInfo, [Out] out PROCESS_INFORMATION lpProcessInformation);


        /// Return Type: BOOL->int
        ///hToken: HANDLE->void*
        ///lpApplicationName: LPCSTR->CHAR*
        ///lpCommandLine: LPSTR->CHAR*
        ///lpProcessAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInheritHandles: BOOL->int
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCSTR->CHAR*
        ///lpStartupInfo: LPSTARTUPINFOA->_STARTUPINFOA*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("advapi32.dll", EntryPoint = "CreateProcessAsUserA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessAsUserA([In] IntPtr hToken, [In] [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, IntPtr lpCommandLine, [In] IntPtr lpProcessAttributes, [In] IntPtr lpThreadAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles, uint dwCreationFlags, [In] IntPtr lpEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, [In] ref STARTUPINFOA lpStartupInfo, [Out] out PROCESS_INFORMATION lpProcessInformation);


        /// Return Type: BOOL->int
        ///lpApplicationName: LPCSTR->CHAR*
        ///lpCommandLine: LPSTR->CHAR*
        ///lpProcessAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpThreadAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInheritHandles: BOOL->int
        ///dwCreationFlags: DWORD->unsigned int
        ///lpEnvironment: LPVOID->void*
        ///lpCurrentDirectory: LPCSTR->CHAR*
        ///lpStartupInfo: LPSTARTUPINFOA->_STARTUPINFOA*
        ///lpProcessInformation: LPPROCESS_INFORMATION->_PROCESS_INFORMATION*
        [DllImport("kernel32.dll", EntryPoint = "CreateProcessA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcessA([In] [MarshalAs(UnmanagedType.LPStr)] string lpApplicationName, IntPtr lpCommandLine, [In] IntPtr lpProcessAttributes, [In] IntPtr lpThreadAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandles, uint dwCreationFlags, [In] IntPtr lpEnvironment, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentDirectory, [In] ref STARTUPINFOA lpStartupInfo, [Out] out PROCESS_INFORMATION lpProcessInformation);


        /// Return Type: BOOL->int
        ///ParentDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///CreatorDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///NewDescriptor: PSECURITY_DESCRIPTOR*
        ///ObjectTypes: GUID**
        ///GuidCount: ULONG->unsigned int
        ///IsContainerObject: BOOL->int
        ///AutoInheritFlags: ULONG->unsigned int
        ///Token: HANDLE->void*
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        [DllImport("advapi32.dll", EntryPoint = "CreatePrivateObjectSecurityWithMultipleInheritance")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreatePrivateObjectSecurityWithMultipleInheritance([In] IntPtr ParentDescriptor, [In] IntPtr CreatorDescriptor, out IntPtr NewDescriptor, ref IntPtr ObjectTypes, uint GuidCount, [MarshalAs(UnmanagedType.Bool)] bool IsContainerObject, uint AutoInheritFlags, [In] IntPtr Token, [In] ref GENERIC_MAPPING GenericMapping);


        /// Return Type: BOOL->int
        ///ParentDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///CreatorDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///NewDescriptor: PSECURITY_DESCRIPTOR*
        ///ObjectType: GUID*
        ///IsContainerObject: BOOL->int
        ///AutoInheritFlags: ULONG->unsigned int
        ///Token: HANDLE->void*
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        [DllImport("advapi32.dll", EntryPoint = "CreatePrivateObjectSecurityEx")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreatePrivateObjectSecurityEx([In] IntPtr ParentDescriptor, [In] IntPtr CreatorDescriptor, out IntPtr NewDescriptor, [In] IntPtr ObjectType, [MarshalAs(UnmanagedType.Bool)] bool IsContainerObject, uint AutoInheritFlags, [In] IntPtr Token, [In] ref GENERIC_MAPPING GenericMapping);


        /// Return Type: BOOL->int
        ///ParentDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///CreatorDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///NewDescriptor: PSECURITY_DESCRIPTOR*
        ///IsDirectoryObject: BOOL->int
        ///Token: HANDLE->void*
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        [DllImport("advapi32.dll", EntryPoint = "CreatePrivateObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreatePrivateObjectSecurity([In] IntPtr ParentDescriptor, [In] IntPtr CreatorDescriptor, out IntPtr NewDescriptor, [MarshalAs(UnmanagedType.Bool)] bool IsDirectoryObject, [In] IntPtr Token, [In] ref GENERIC_MAPPING GenericMapping);


        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "CreatePopupMenu")]
        public static extern IntPtr CreatePopupMenu();


        /// Return Type: HRGN->HRGN__*
        ///pptl: POINT*
        ///pc: INT*
        ///cPoly: int
        ///iMode: int
        [DllImport("gdi32.dll", EntryPoint = "CreatePolyPolygonRgn")]
        public static extern IntPtr CreatePolyPolygonRgn([In] ref Point pptl, [In] ref int pc, int cPoly, int iMode);


        /// Return Type: HRGN->HRGN__*
        ///pptl: POINT*
        ///cPoint: int
        ///iMode: int
        [DllImport("gdi32.dll", EntryPoint = "CreatePolygonRgn")]
        public static extern IntPtr CreatePolygonRgn([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] Point[] pptl, int cPoint, int iMode);


        /// Return Type: HRESULT->LONG->int
        ///punk: LPUNKNOWN->IUnknown*
        ///ppmk: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "CreatePointerMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreatePointerMoniker(ref IUnknown punk, ref IntPtr ppmk);


        /// Return Type: BOOL->int
        ///hReadPipe: PHANDLE->HANDLE*
        ///hWritePipe: PHANDLE->HANDLE*
        ///lpPipeAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreatePipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreatePipe(ref IntPtr hReadPipe, ref IntPtr hWritePipe, [In] IntPtr lpPipeAttributes, uint nSize);


        /// Return Type: HPEN->HPEN__*
        ///plpen: LOGPEN*
        [DllImport("gdi32.dll", EntryPoint = "CreatePenIndirect")]
        public static extern IntPtr CreatePenIndirect([In] ref tagLOGPEN plpen);


        /// Return Type: HPEN->HPEN__*
        ///iStyle: int
        ///cWidth: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CreatePen")]
        public static extern IntPtr CreatePen(int iStyle, int cWidth, uint color);


        /// Return Type: HBRUSH->HBRUSH__*
        ///hbm: HBITMAP->HBITMAP__*
        [DllImport("gdi32.dll", EntryPoint = "CreatePatternBrush")]
        public static extern IntPtr CreatePatternBrush([In] IntPtr hbm);


        /// Return Type: HPALETTE->HPALETTE__*
        ///plpal: LOGPALETTE*
        [DllImport("gdi32.dll", EntryPoint = "CreatePalette")]
        public static extern IntPtr CreatePalette([In] ref tagLOGPALETTE plpal);


        /// Return Type: HRESULT->LONG->int
        ///ppOAHolder: LPOLEADVISEHOLDER*
        [DllImport("ole32.dll", EntryPoint = "CreateOleAdviseHolder", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateOleAdviseHolder(ref IntPtr ppOAHolder);


        /// Return Type: HRESULT->LONG->int
        ///punk: LPUNKNOWN->IUnknown*
        ///ppmk: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "CreateObjrefMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateObjrefMoniker(ref IUnknown punk, ref IntPtr ppmk);


        /// Return Type: HANDLE->void*
        ///lpName: LPCWSTR->WCHAR*
        ///dwOpenMode: DWORD->unsigned int
        ///dwPipeMode: DWORD->unsigned int
        ///nMaxInstances: DWORD->unsigned int
        ///nOutBufferSize: DWORD->unsigned int
        ///nInBufferSize: DWORD->unsigned int
        ///nDefaultTimeOut: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateNamedPipeW")]
        public static extern IntPtr CreateNamedPipeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, [In] IntPtr lpSecurityAttributes);


        /// Return Type: HANDLE->void*
        ///lpName: LPCSTR->CHAR*
        ///dwOpenMode: DWORD->unsigned int
        ///dwPipeMode: DWORD->unsigned int
        ///nMaxInstances: DWORD->unsigned int
        ///nOutBufferSize: DWORD->unsigned int
        ///nInBufferSize: DWORD->unsigned int
        ///nDefaultTimeOut: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateNamedPipeA")]
        public static extern IntPtr CreateNamedPipeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, [In] IntPtr lpSecurityAttributes);


        /// Return Type: HANDLE->void*
        ///lpMutexAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInitialOwner: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateMutexW")]
        public static extern IntPtr CreateMutexW([In] IntPtr lpMutexAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///lpMutexAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bInitialOwner: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateMutexA")]
        public static extern IntPtr CreateMutexA([In] IntPtr lpMutexAttributes, [MarshalAs(UnmanagedType.Bool)] bool bInitialOwner, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: HDC->HDC__*
        ///pszFile: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateMetaFileW")]
        public static extern IntPtr CreateMetaFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszFile);


        /// Return Type: HDC->HDC__*
        ///pszFile: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateMetaFileA")]
        public static extern IntPtr CreateMetaFileA([In] [MarshalAs(UnmanagedType.LPStr)] string pszFile);


        /// Return Type: HMENU->HMENU__*
        [DllImport("user32.dll", EntryPoint = "CreateMenu")]
        public static extern IntPtr CreateMenu();


        /// Return Type: HANDLE->void*
        ///NotificationType: MEMORY_RESOURCE_NOTIFICATION_TYPE->_MEMORY_RESOURCE_NOTIFICATION_TYPE
        [DllImport("kernel32.dll", EntryPoint = "CreateMemoryResourceNotification")]
        public static extern IntPtr CreateMemoryResourceNotification(MEMORY_RESOURCE_NOTIFICATION_TYPE NotificationType);


        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCWSTR->WCHAR*
        ///lpWindowName: LPCWSTR->WCHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateMDIWindowW")]
        public static extern IntPtr CreateMDIWindowW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hInstance, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: HWND->HWND__*
        ///lpClassName: LPCSTR->CHAR*
        ///lpWindowName: LPCSTR->CHAR*
        ///dwStyle: DWORD->unsigned int
        ///X: int
        ///Y: int
        ///nWidth: int
        ///nHeight: int
        ///hWndParent: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateMDIWindowA")]
        public static extern IntPtr CreateMDIWindowA([In] [MarshalAs(UnmanagedType.LPStr)] string lpClassName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpWindowName, uint dwStyle, int X, int Y, int nWidth, int nHeight, [In] IntPtr hWndParent, [In] IntPtr hInstance, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: HANDLE->void*
        ///lpName: LPCWSTR->WCHAR*
        ///nMaxMessageSize: DWORD->unsigned int
        ///lReadTimeout: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateMailslotW")]
        public static extern IntPtr CreateMailslotW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, uint nMaxMessageSize, uint lReadTimeout, [In] IntPtr lpSecurityAttributes);


        /// Return Type: HANDLE->void*
        ///lpName: LPCSTR->CHAR*
        ///nMaxMessageSize: DWORD->unsigned int
        ///lReadTimeout: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateMailslotA")]
        public static extern IntPtr CreateMailslotA([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, uint nMaxMessageSize, uint lReadTimeout, [In] IntPtr lpSecurityAttributes);


        /// Return Type: BOOL->int
        ///NumJob: ULONG->unsigned int
        ///UserJobSet: PJOB_SET_ARRAY->_JOB_SET_ARRAY*
        ///Flags: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateJobSet")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateJobSet(uint NumJob, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0)] JOB_SET_ARRAY[] UserJobSet, uint Flags);


        /// Return Type: HANDLE->void*
        ///lpJobAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateJobObjectW")]
        public static extern IntPtr CreateJobObjectW([In] IntPtr lpJobAttributes, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///lpJobAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateJobObjectA")]
        public static extern IntPtr CreateJobObjectA([In] IntPtr lpJobAttributes, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: HRESULT->LONG->int
        ///lpszDelim: LPCOLESTR->OLECHAR*
        ///lpszItem: LPCOLESTR->OLECHAR*
        ///ppmk: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "CreateItemMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateItemMoniker([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDelim, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszItem, ref IntPtr ppmk);


        /// Return Type: HANDLE->void*
        ///FileHandle: HANDLE->void*
        ///ExistingCompletionPort: HANDLE->void*
        ///CompletionKey: ULONG_PTR->unsigned int
        ///NumberOfConcurrentThreads: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CreateIoCompletionPort")]
        public static extern IntPtr CreateIoCompletionPort([In] IntPtr FileHandle, [In] IntPtr ExistingCompletionPort, uint CompletionKey, uint NumberOfConcurrentThreads);


        /// Return Type: HRESULT->LONG->int
        ///hGlobal: HGLOBAL->HANDLE->void*
        ///fDeleteOnRelease: BOOL->int
        ///pplkbyt: LPLOCKBYTES*
        [DllImport("ole32.dll", EntryPoint = "CreateILockBytesOnHGlobal", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateILockBytesOnHGlobal(IntPtr hGlobal, [MarshalAs(UnmanagedType.Bool)] bool fDeleteOnRelease, ref IntPtr pplkbyt);


        /// Return Type: HDC->HDC__*
        ///pszDriver: LPCWSTR->WCHAR*
        ///pszDevice: LPCWSTR->WCHAR*
        ///pszPort: LPCWSTR->WCHAR*
        ///pdm: DEVMODEW*
        [DllImport("gdi32.dll", EntryPoint = "CreateICW")]
        public static extern IntPtr CreateICW([In] [MarshalAs(UnmanagedType.LPWStr)] string pszDriver, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszDevice, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPort, [In] IntPtr pdm);


        /// Return Type: HICON->HICON__*
        ///piconinfo: PICONINFO->ICONINFO*
        [DllImport("user32.dll", EntryPoint = "CreateIconIndirect")]
        public static extern IntPtr CreateIconIndirect([In] ref ICONINFO piconinfo);


        /// Return Type: HICON->HICON__*
        ///presbits: PBYTE->BYTE*
        ///dwResSize: DWORD->unsigned int
        ///fIcon: BOOL->int
        ///dwVer: DWORD->unsigned int
        ///cxDesired: int
        ///cyDesired: int
        ///Flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CreateIconFromResourceEx")]
        public static extern IntPtr CreateIconFromResourceEx([In] ref byte presbits, uint dwResSize, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVer, int cxDesired, int cyDesired, uint Flags);


        /// Return Type: HICON->HICON__*
        ///presbits: PBYTE->BYTE*
        ///dwResSize: DWORD->unsigned int
        ///fIcon: BOOL->int
        ///dwVer: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CreateIconFromResource")]
        public static extern IntPtr CreateIconFromResource([In] ref byte presbits, uint dwResSize, [MarshalAs(UnmanagedType.Bool)] bool fIcon, uint dwVer);


        /// Return Type: HICON->HICON__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///nWidth: int
        ///nHeight: int
        ///cPlanes: BYTE->unsigned char
        ///cBitsPixel: BYTE->unsigned char
        ///lpbANDbits: BYTE*
        ///lpbXORbits: BYTE*
        [DllImport("user32.dll", EntryPoint = "CreateIcon")]
        public static extern IntPtr CreateIcon([In] IntPtr hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, [In] ref byte lpbANDbits, [In] ref byte lpbXORbits);


        /// Return Type: HDC->HDC__*
        ///pszDriver: LPCSTR->CHAR*
        ///pszDevice: LPCSTR->CHAR*
        ///pszPort: LPCSTR->CHAR*
        ///pdm: DEVMODEA*
        [DllImport("gdi32.dll", EntryPoint = "CreateICA")]
        public static extern IntPtr CreateICA([In] [MarshalAs(UnmanagedType.LPStr)] string pszDriver, [In] [MarshalAs(UnmanagedType.LPStr)] string pszDevice, [In] [MarshalAs(UnmanagedType.LPStr)] string pszPort, [In] IntPtr pdm);


        /// Return Type: HBRUSH->HBRUSH__*
        ///iHatch: int
        ///color: COLORREF->DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CreateHatchBrush")]
        public static extern IntPtr CreateHatchBrush(int iHatch, uint color);


        /// Return Type: BOOL->int
        ///lpFileName: LPCWSTR->WCHAR*
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateHardLinkW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateHardLinkW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, IntPtr lpSecurityAttributes);


        /// Return Type: BOOL->int
        ///lpFileName: LPCSTR->CHAR*
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateHardLinkA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateHardLinkA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, IntPtr lpSecurityAttributes);


        /// Return Type: HPALETTE->HPALETTE__*
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "CreateHalftonePalette")]
        public static extern IntPtr CreateHalftonePalette([In] IntPtr hdc);


        /// Return Type: HRESULT->LONG->int
        ///pmkFirst: LPMONIKER->IMoniker*
        ///pmkRest: LPMONIKER->IMoniker*
        ///ppmkComposite: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "CreateGenericComposite", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateGenericComposite(ref IMoniker pmkFirst, ref IMoniker pmkRest, ref IntPtr ppmkComposite);


        /// Return Type: HRESULT->LONG->int
        ///cfmtetc: UINT->unsigned int
        ///rgfmtetc: FORMATETC*
        ///ppenumfmtetc: IEnumFORMATETC**
        [DllImport("urlmon.dll", EntryPoint = "CreateFormatEnumerator", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateFormatEnumerator(uint cfmtetc, ref tagFORMATETC rgfmtetc, ref IntPtr ppenumfmtetc);


        /// Return Type: HFONT->HFONT__*
        ///cHeight: int
        ///cWidth: int
        ///cEscapement: int
        ///cOrientation: int
        ///cWeight: int
        ///bItalic: DWORD->unsigned int
        ///bUnderline: DWORD->unsigned int
        ///bStrikeOut: DWORD->unsigned int
        ///iCharSet: DWORD->unsigned int
        ///iOutPrecision: DWORD->unsigned int
        ///iClipPrecision: DWORD->unsigned int
        ///iQuality: DWORD->unsigned int
        ///iPitchAndFamily: DWORD->unsigned int
        ///pszFaceName: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontW")]
        public static extern IntPtr CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, uint bItalic, uint bUnderline, uint bStrikeOut, uint iCharSet, uint iOutPrecision, uint iClipPrecision, uint iQuality, uint iPitchAndFamily, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszFaceName);


        /// Return Type: HFONT->HFONT__*
        ///lplf: LOGFONTW*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectW")]
        public static extern IntPtr CreateFontIndirectW([In] ref tagLOGFONTW lplf);


        /// Return Type: HFONT->HFONT__*
        ///param0: ENUMLOGFONTEXDVW*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectExW")]
        public static extern IntPtr CreateFontIndirectExW([In] ref tagENUMLOGFONTEXDVW param0);


        /// Return Type: HFONT->HFONT__*
        ///param0: ENUMLOGFONTEXDVA*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectExA")]
        public static extern IntPtr CreateFontIndirectExA([In] ref tagENUMLOGFONTEXDVA param0);


        /// Return Type: HFONT->HFONT__*
        ///lplf: LOGFONTA*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontIndirectA")]
        public static extern IntPtr CreateFontIndirectA([In] ref tagLOGFONTA lplf);


        /// Return Type: HFONT->HFONT__*
        ///cHeight: int
        ///cWidth: int
        ///cEscapement: int
        ///cOrientation: int
        ///cWeight: int
        ///bItalic: DWORD->unsigned int
        ///bUnderline: DWORD->unsigned int
        ///bStrikeOut: DWORD->unsigned int
        ///iCharSet: DWORD->unsigned int
        ///iOutPrecision: DWORD->unsigned int
        ///iClipPrecision: DWORD->unsigned int
        ///iQuality: DWORD->unsigned int
        ///iPitchAndFamily: DWORD->unsigned int
        ///pszFaceName: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateFontA")]
        public static extern IntPtr CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, uint bItalic, uint bUnderline, uint bStrikeOut, uint iCharSet, uint iOutPrecision, uint iClipPrecision, uint iQuality, uint iPitchAndFamily, [In] [MarshalAs(UnmanagedType.LPStr)] string pszFaceName);


        /// Return Type: HANDLE->void*
        ///lpFileName: LPCWSTR->WCHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwCreationDisposition: DWORD->unsigned int
        ///dwFlagsAndAttributes: DWORD->unsigned int
        ///hTemplateFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileW")]
        public static extern IntPtr CreateFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, [In] IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, [In] IntPtr hTemplateFile);


        /// Return Type: HRESULT->LONG->int
        ///lpszPathName: LPCOLESTR->OLECHAR*
        ///ppmk: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "CreateFileMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateFileMoniker([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszPathName, ref IntPtr ppmk);


        /// Return Type: HANDLE->void*
        ///hFile: HANDLE->void*
        ///lpFileMappingAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///flProtect: DWORD->unsigned int
        ///dwMaximumSizeHigh: DWORD->unsigned int
        ///dwMaximumSizeLow: DWORD->unsigned int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileMappingW")]
        public static extern IntPtr CreateFileMappingW([In] IntPtr hFile, [In] IntPtr lpFileMappingAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///hFile: HANDLE->void*
        ///lpFileMappingAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///flProtect: DWORD->unsigned int
        ///dwMaximumSizeHigh: DWORD->unsigned int
        ///dwMaximumSizeLow: DWORD->unsigned int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileMappingA")]
        public static extern IntPtr CreateFileMappingA([In] IntPtr hFile, [In] IntPtr lpFileMappingAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///lpFileName: LPCSTR->CHAR*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///dwCreationDisposition: DWORD->unsigned int
        ///dwFlagsAndAttributes: DWORD->unsigned int
        ///hTemplateFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFileA")]
        public static extern IntPtr CreateFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, [In] IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, [In] IntPtr hTemplateFile);


        /// Return Type: LPVOID->void*
        ///dwStackCommitSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwStackReserveSize: SIZE_T->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///lpStartAddress: LPFIBER_START_ROUTINE->PFIBER_START_ROUTINE
        ///lpParameter: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFiberEx")]
        public static extern IntPtr CreateFiberEx(uint dwStackCommitSize, uint dwStackReserveSize, uint dwFlags, PFIBER_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter);


        /// Return Type: LPVOID->void*
        ///dwStackSize: SIZE_T->ULONG_PTR->unsigned int
        ///lpStartAddress: LPFIBER_START_ROUTINE->PFIBER_START_ROUTINE
        ///lpParameter: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateFiber")]
        public static extern IntPtr CreateFiber(uint dwStackSize, PFIBER_START_ROUTINE lpStartAddress, [In] IntPtr lpParameter);


        /// Return Type: HANDLE->void*
        ///lpEventAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///bInitialState: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateEventW")]
        public static extern IntPtr CreateEventW([In] IntPtr lpEventAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [MarshalAs(UnmanagedType.Bool)] bool bInitialState, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpName);


        /// Return Type: HANDLE->void*
        ///lpEventAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        ///bManualReset: BOOL->int
        ///bInitialState: BOOL->int
        ///lpName: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "CreateEventA")]
        public static extern IntPtr CreateEventA([In] IntPtr lpEventAttributes, [MarshalAs(UnmanagedType.Bool)] bool bManualReset, [MarshalAs(UnmanagedType.Bool)] bool bInitialState, [In] [MarshalAs(UnmanagedType.LPStr)] string lpName);


        /// Return Type: HRESULT->LONG->int
        ///pperrinfo: ICreateErrorInfo**
        [DllImport("oleaut32.dll", EntryPoint = "CreateErrorInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateErrorInfo(ref IntPtr pperrinfo);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpFilename: LPCWSTR->WCHAR*
        ///lprc: RECT*
        ///lpDesc: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateEnhMetaFileW")]
        public static extern IntPtr CreateEnhMetaFileW([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFilename, [In] IntPtr lprc, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDesc);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        ///lpFilename: LPCSTR->CHAR*
        ///lprc: RECT*
        ///lpDesc: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "CreateEnhMetaFileA")]
        public static extern IntPtr CreateEnhMetaFileA([In] IntPtr hdc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFilename, [In] IntPtr lprc, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDesc);


        /// Return Type: HRGN->HRGN__*
        ///lprect: RECT*
        [DllImport("gdi32.dll", EntryPoint = "CreateEllipticRgnIndirect")]
        public static extern IntPtr CreateEllipticRgnIndirect([In] ref tagRECT lprect);


        /// Return Type: HRGN->HRGN__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        [DllImport("gdi32.dll", EntryPoint = "CreateEllipticRgn")]
        public static extern IntPtr CreateEllipticRgn(int x1, int y1, int x2, int y2);


        /// Return Type: HRESULT->LONG->int
        ///pidata: INTERFACEDATA*
        ///lcid: LCID->DWORD->unsigned int
        ///pptinfo: ITypeInfo**
        [DllImport("oleaut32.dll", EntryPoint = "CreateDispTypeInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateDispTypeInfo(ref tagINTERFACEDATA pidata, uint lcid, ref IntPtr pptinfo);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///cx: int
        ///cy: int
        [DllImport("gdi32.dll", EntryPoint = "CreateDiscardableBitmap")]
        public static extern IntPtr CreateDiscardableBitmap([In] IntPtr hdc, int cx, int cy);


        /// Return Type: BOOL->int
        ///lpPathName: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName, [In] IntPtr lpSecurityAttributes);


        /// Return Type: BOOL->int
        ///lpTemplateDirectory: LPCWSTR->WCHAR*
        ///lpNewDirectory: LPCWSTR->WCHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateDirectory, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewDirectory, [In] IntPtr lpSecurityAttributes);


        /// Return Type: BOOL->int
        ///lpTemplateDirectory: LPCSTR->CHAR*
        ///lpNewDirectory: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpTemplateDirectory, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewDirectory, [In] IntPtr lpSecurityAttributes);


        /// Return Type: BOOL->int
        ///lpPathName: LPCSTR->CHAR*
        ///lpSecurityAttributes: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("kernel32.dll", EntryPoint = "CreateDirectoryA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateDirectoryA([In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName, [In] IntPtr lpSecurityAttributes);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///lpbmi: BITMAPINFO*
        ///usage: UINT->unsigned int
        ///ppvBits: void**
        ///hSection: HANDLE->void*
        ///offset: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CreateDIBSection")]
        public static extern IntPtr CreateDIBSection([In] IntPtr hdc, [In] ref tagBITMAPINFO lpbmi, uint usage, ref IntPtr ppvBits, [In] IntPtr hSection, uint offset);


        /// Return Type: HBRUSH->HBRUSH__*
        ///lpPackedDIB: void*
        ///iUsage: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CreateDIBPatternBrushPt")]
        public static extern IntPtr CreateDIBPatternBrushPt([In] IntPtr lpPackedDIB, uint iUsage);


        /// Return Type: HBRUSH->HBRUSH__*
        ///h: HGLOBAL->HANDLE->void*
        ///iUsage: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CreateDIBPatternBrush")]
        public static extern IntPtr CreateDIBPatternBrush([In] IntPtr h, uint iUsage);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///pbmih: BITMAPINFOHEADER*
        ///flInit: DWORD->unsigned int
        ///pjBits: void*
        ///pbmi: BITMAPINFO*
        ///iUsage: UINT->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CreateDIBitmap")]
        public static extern IntPtr CreateDIBitmap([In] IntPtr hdc, [In] IntPtr pbmih, uint flInit, [In] IntPtr pjBits, [In] IntPtr pbmi, uint iUsage);


        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCWSTR->WCHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogParamW")]
        public static extern IntPtr CreateDialogParamW([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplateName: LPCSTR->CHAR*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogParamA")]
        public static extern IntPtr CreateDialogParamA([In] IntPtr hInstance, [In] [MarshalAs(UnmanagedType.LPStr)] string lpTemplateName, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplate: LPCDLGTEMPLATEW->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogIndirectParamW")]
        public static extern IntPtr CreateDialogIndirectParamW([In] IntPtr hInstance, [In] ref DLGTEMPLATE lpTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: HWND->HWND__*
        ///hInstance: HINSTANCE->HINSTANCE__*
        ///lpTemplate: LPCDLGTEMPLATEA->DLGTEMPLATE*
        ///hWndParent: HWND->HWND__*
        ///lpDialogFunc: DLGPROC
        ///dwInitParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CreateDialogIndirectParamA")]
        public static extern IntPtr CreateDialogIndirectParamA([In] IntPtr hInstance, [In] ref DLGTEMPLATE lpTemplate, [In] IntPtr hWndParent, DLGPROC lpDialogFunc, [MarshalAs(UnmanagedType.SysInt)] IntPtr dwInitParam);


        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCWSTR->WCHAR*
        ///lpszDevice: LPCWSTR->WCHAR*
        ///pDevmode: LPDEVMODEW->_devicemodeW*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateDesktopW")]
        public static extern IntPtr CreateDesktopW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDesktop, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDevice, IntPtr pDevmode, uint dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);


        /// Return Type: HDESK->HDESK__*
        ///lpszDesktop: LPCSTR->CHAR*
        ///lpszDevice: LPCSTR->CHAR*
        ///pDevmode: LPDEVMODEA->_devicemodeA*
        ///dwFlags: DWORD->unsigned int
        ///dwDesiredAccess: ACCESS_MASK->DWORD->unsigned int
        ///lpsa: LPSECURITY_ATTRIBUTES->_SECURITY_ATTRIBUTES*
        [DllImport("user32.dll", EntryPoint = "CreateDesktopA")]
        public static extern IntPtr CreateDesktopA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszDesktop, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszDevice, IntPtr pDevmode, uint dwFlags, uint dwDesiredAccess, [In] IntPtr lpsa);


        /// Return Type: HDC->HDC__*
        ///pwszDriver: LPCWSTR->WCHAR*
        ///pwszDevice: LPCWSTR->WCHAR*
        ///pszPort: LPCWSTR->WCHAR*
        ///pdm: DEVMODEW*
        [DllImport("gdi32.dll", EntryPoint = "CreateDCW")]
        public static extern IntPtr CreateDCW([In] [MarshalAs(UnmanagedType.LPWStr)] string pwszDriver, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszDevice, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszPort, [In] IntPtr pdm);


        /// Return Type: HDC->HDC__*
        ///pwszDriver: LPCSTR->CHAR*
        ///pwszDevice: LPCSTR->CHAR*
        ///pszPort: LPCSTR->CHAR*
        ///pdm: DEVMODEA*
        [DllImport("gdi32.dll", EntryPoint = "CreateDCA")]
        public static extern IntPtr CreateDCA([In] [MarshalAs(UnmanagedType.LPStr)] string pwszDriver, [In] [MarshalAs(UnmanagedType.LPStr)] string pwszDevice, [In] [MarshalAs(UnmanagedType.LPStr)] string pszPort, [In] IntPtr pdm);


        /// Return Type: HRESULT->LONG->int
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///rclsid: IID*
        ///iid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "CreateDataCache", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateDataCache(ref IUnknown pUnkOuter, ref GUID rclsid, ref GUID iid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///ppDAHolder: LPDATAADVISEHOLDER*
        [DllImport("ole32.dll", EntryPoint = "CreateDataAdviseHolder", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateDataAdviseHolder(ref IntPtr ppDAHolder);


        /// Return Type: HCURSOR->HICON->HICON__*
        ///hInst: HINSTANCE->HINSTANCE__*
        ///xHotSpot: int
        ///yHotSpot: int
        ///nWidth: int
        ///nHeight: int
        ///pvANDPlane: void*
        ///pvXORPlane: void*
        [DllImport("user32.dll", EntryPoint = "CreateCursor")]
        public static extern IntPtr CreateCursor([In] IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [In] IntPtr pvANDPlane, [In] IntPtr pvXORPlane);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: SECURITY_ATTRIBUTES*
        ///dwFlags: DWORD->unsigned int
        ///lpScreenBufferData: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateConsoleScreenBuffer")]
        public static extern IntPtr CreateConsoleScreenBuffer(uint dwDesiredAccess, uint dwShareMode, ref SECURITY_ATTRIBUTES lpSecurityAttributes, uint dwFlags, IntPtr lpScreenBufferData);


        /// Return Type: HDC->HDC__*
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
        public static extern IntPtr CreateCompatibleDC([In] IntPtr hdc);


        /// Return Type: HBITMAP->HBITMAP__*
        ///hdc: HDC->HDC__*
        ///cx: int
        ///cy: int
        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
        public static extern IntPtr CreateCompatibleBitmap([In] IntPtr hdc, int cx, int cy);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///lplcs: LPLOGCOLORSPACEW->tagLOGCOLORSPACEW*
        [DllImport("gdi32.dll", EntryPoint = "CreateColorSpaceW")]
        public static extern IntPtr CreateColorSpaceW([In] ref tagLOGCOLORSPACEW lplcs);


        /// Return Type: HCOLORSPACE->HCOLORSPACE__*
        ///lplcs: LPLOGCOLORSPACEA->tagLOGCOLORSPACEA*
        [DllImport("gdi32.dll", EntryPoint = "CreateColorSpaceA")]
        public static extern IntPtr CreateColorSpaceA([In] ref tagLOGCOLORSPACEA lplcs);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///ppmk: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "CreateClassMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateClassMoniker(ref GUID rclsid, ref IntPtr ppmk);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///hBitmap: HBITMAP->HBITMAP__*
        ///nWidth: int
        ///nHeight: int
        [DllImport("user32.dll", EntryPoint = "CreateCaret")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateCaret([In] IntPtr hWnd, [In] IntPtr hBitmap, int nWidth, int nHeight);


        /// Return Type: HBRUSH->HBRUSH__*
        ///plbrush: LOGBRUSH*
        [DllImport("gdi32.dll", EntryPoint = "CreateBrushIndirect")]
        public static extern IntPtr CreateBrushIndirect([In] ref tagLOGBRUSH plbrush);


        /// Return Type: HBITMAP->HBITMAP__*
        ///pbm: BITMAP*
        [DllImport("gdi32.dll", EntryPoint = "CreateBitmapIndirect")]
        public static extern IntPtr CreateBitmapIndirect([In] ref tagBITMAP pbm);


        /// Return Type: HBITMAP->HBITMAP__*
        ///nWidth: int
        ///nHeight: int
        ///nPlanes: UINT->unsigned int
        ///nBitCount: UINT->unsigned int
        ///lpBits: void*
        [DllImport("gdi32.dll", EntryPoint = "CreateBitmap")]
        public static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, [In] IntPtr lpBits);


        /// Return Type: HRESULT->LONG->int
        ///reserved: DWORD->unsigned int
        ///ppbc: LPBC*
        [DllImport("ole32.dll", EntryPoint = "CreateBindCtx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateBindCtx(uint reserved, ref IntPtr ppbc);


        /// Return Type: HRESULT->LONG->int
        ///pbc: IBindCtx*
        ///dwOptions: DWORD->unsigned int
        ///pBSCb: IBindStatusCallback*
        ///pEnum: IEnumFORMATETC*
        ///ppBC: IBindCtx**
        ///reserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CreateAsyncBindCtxEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateAsyncBindCtxEx(ref IBindCtx pbc, uint dwOptions, ref IBindStatusCallback pBSCb, ref IEnumFORMATETC pEnum, ref IntPtr ppBC, uint reserved);


        /// Return Type: HRESULT->LONG->int
        ///reserved: DWORD->unsigned int
        ///pBSCb: IBindStatusCallback*
        ///pEFetc: IEnumFORMATETC*
        ///ppBC: IBindCtx**
        [DllImport("urlmon.dll", EntryPoint = "CreateAsyncBindCtx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateAsyncBindCtx(uint reserved, ref IBindStatusCallback pBSCb, ref IEnumFORMATETC pEFetc, ref IntPtr ppBC);


        /// Return Type: HRESULT->LONG->int
        ///ppmk: LPMONIKER*
        [DllImport("ole32.dll", EntryPoint = "CreateAntiMoniker", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateAntiMoniker(ref IntPtr ppmk);


        /// Return Type: HANDLE->void*
        ///pActCtx: PCACTCTXW->ACTCTXW*
        [DllImport("kernel32.dll", EntryPoint = "CreateActCtxW")]
        public static extern IntPtr CreateActCtxW([In] ref tagACTCTXW pActCtx);


        /// Return Type: HANDLE->void*
        ///pActCtx: PCACTCTXA->ACTCTXA*
        [DllImport("kernel32.dll", EntryPoint = "CreateActCtxA")]
        public static extern IntPtr CreateActCtxA([In] ref tagACTCTXA pActCtx);


        /// Return Type: HACCEL->HACCEL__*
        ///paccel: LPACCEL->tagACCEL*
        ///cAccel: int
        [DllImport("user32.dll", EntryPoint = "CreateAcceleratorTableW")]
        public static extern IntPtr CreateAcceleratorTableW([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] tagACCEL[] paccel, int cAccel);


        /// Return Type: HACCEL->HACCEL__*
        ///paccel: LPACCEL->tagACCEL*
        ///cAccel: int
        [DllImport("user32.dll", EntryPoint = "CreateAcceleratorTableA")]
        public static extern IntPtr CreateAcceleratorTableA([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1)] tagACCEL[] paccel, int cAccel);


        /// Return Type: HRESULT->LONG->int
        ///dwFlags: DWORD->unsigned int
        ///dwTimeout: DWORD->unsigned int
        ///cHandles: ULONG->unsigned int
        ///pHandles: LPHANDLE->HANDLE*
        ///lpdwindex: LPDWORD->DWORD*
        [DllImport("ole32.dll", EntryPoint = "CoWaitForMultipleHandles", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoWaitForMultipleHandles(uint dwFlags, uint dwTimeout, uint cHandles, ref IntPtr pHandles, ref uint lpdwindex);


        /// Return Type: int
        [DllImport("user32.dll", EntryPoint = "CountClipboardFormats")]
        public static extern int CountClipboardFormats();


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "CoUnmarshalInterface", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoUnmarshalInterface(ref IStream pStm, ref GUID riid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///pstm: LPSTREAM->IStream*
        ///phresult: HRESULT*
        [DllImport("ole32.dll", EntryPoint = "CoUnmarshalHresult", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoUnmarshalHresult(ref IStream pstm, ref int phresult);


        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "CoUninitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern void CoUninitialize();


        /// Return Type: HRESULT->LONG->int
        ///clsidOld: IID*
        ///clsidNew: IID*
        [DllImport("ole32.dll", EntryPoint = "CoTreatAsClass", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoTreatAsClass(ref GUID clsidOld, ref GUID clsidNew);


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "CoTestCancel", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoTestCancel();


        /// Return Type: LPVOID->void*
        ///pv: LPVOID->void*
        ///cb: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoTaskMemRealloc", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CoTaskMemRealloc(IntPtr pv, uint cb);


        /// Return Type: void
        ///pv: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "CoTaskMemFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void CoTaskMemFree(IntPtr pv);


        /// Return Type: LPVOID->void*
        ///cb: SIZE_T->ULONG_PTR->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoTaskMemAlloc", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CoTaskMemAlloc(uint cb);


        /// Return Type: HRESULT->LONG->int
        ///pNewObject: IUnknown*
        ///ppOldObject: IUnknown**
        [DllImport("ole32.dll", EntryPoint = "CoSwitchCallContext", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoSwitchCallContext(ref IUnknown pNewObject, ref IntPtr ppOldObject);


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "CoSuspendClassObjects", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoSuspendClassObjects();


        /// Return Type: HRESULT->LONG->int
        ///pProxy: IUnknown*
        ///dwAuthnSvc: DWORD->unsigned int
        ///dwAuthzSvc: DWORD->unsigned int
        ///pServerPrincName: OLECHAR*
        ///dwAuthnLevel: DWORD->unsigned int
        ///dwImpLevel: DWORD->unsigned int
        ///pAuthInfo: RPC_AUTH_IDENTITY_HANDLE->void*
        ///dwCapabilities: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoSetProxyBlanket", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoSetProxyBlanket(ref IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, IntPtr pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, IntPtr pAuthInfo, uint dwCapabilities);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        [DllImport("ole32.dll", EntryPoint = "CoSetCancelObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoSetCancelObject(ref IUnknown pUnk);


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "CoRevokeMallocSpy", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRevokeMallocSpy();


        /// Return Type: HRESULT->LONG->int
        ///uliCookie: ULARGE_INTEGER->_ULARGE_INTEGER
        [DllImport("ole32.dll", EntryPoint = "CoRevokeInitializeSpy", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRevokeInitializeSpy(ULARGE_INTEGER uliCookie);


        /// Return Type: HRESULT->LONG->int
        ///dwRegister: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoRevokeClassObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRevokeClassObject(uint dwRegister);


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "CoRevertToSelf", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRevertToSelf();


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "CoResumeClassObjects", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoResumeClassObjects();


        /// Return Type: ULONG->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoReleaseServerProcess", CallingConvention = CallingConvention.StdCall)]
        public static extern uint CoReleaseServerProcess();


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        [DllImport("ole32.dll", EntryPoint = "CoReleaseMarshalData", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoReleaseMarshalData(ref IStream pStm);


        /// Return Type: HRESULT->LONG->int
        ///pSurrogate: LPSURROGATE->ISurrogate*
        [DllImport("ole32.dll", EntryPoint = "CoRegisterSurrogate", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRegisterSurrogate(ref ISurrogate pSurrogate);


        /// Return Type: HRESULT->LONG->int
        ///riid: IID*
        ///rclsid: IID*
        [DllImport("ole32.dll", EntryPoint = "CoRegisterPSClsid", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRegisterPSClsid(ref GUID riid, ref GUID rclsid);


        /// Return Type: HRESULT->LONG->int
        ///lpMessageFilter: LPMESSAGEFILTER->IMessageFilter*
        ///lplpMessageFilter: LPMESSAGEFILTER*
        [DllImport("ole32.dll", EntryPoint = "CoRegisterMessageFilter", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRegisterMessageFilter(ref IMessageFilter lpMessageFilter, ref IntPtr lplpMessageFilter);


        /// Return Type: HRESULT->LONG->int
        ///pMallocSpy: LPMALLOCSPY->IMallocSpy*
        [DllImport("ole32.dll", EntryPoint = "CoRegisterMallocSpy", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRegisterMallocSpy(ref IMallocSpy pMallocSpy);


        /// Return Type: HRESULT->LONG->int
        ///pSpy: LPINITIALIZESPY->IInitializeSpy*
        ///puliCookie: ULARGE_INTEGER*
        [DllImport("ole32.dll", EntryPoint = "CoRegisterInitializeSpy", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRegisterInitializeSpy(ref IInitializeSpy pSpy, ref ULARGE_INTEGER puliCookie);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///pUnk: LPUNKNOWN->IUnknown*
        ///dwClsContext: DWORD->unsigned int
        ///flags: DWORD->unsigned int
        ///lpdwRegister: LPDWORD->DWORD*
        [DllImport("ole32.dll", EntryPoint = "CoRegisterClassObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRegisterClassObject(ref GUID rclsid, ref IUnknown pUnk, uint dwClsContext, uint flags, ref uint lpdwRegister);


        /// Return Type: HRESULT->LONG->int
        ///ExtensionUuid: GUID*
        ///pChannelHook: IChannelHook*
        [DllImport("ole32.dll", EntryPoint = "CoRegisterChannelHook", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoRegisterChannelHook(ref GUID ExtensionUuid, ref IChannelHook pChannelHook);


        /// Return Type: HRESULT->LONG->int
        ///pProxy: IUnknown*
        ///pwAuthnSvc: DWORD*
        ///pAuthzSvc: DWORD*
        ///pServerPrincName: OLECHAR**
        ///pAuthnLevel: DWORD*
        ///pImpLevel: DWORD*
        ///pAuthInfo: RPC_AUTH_IDENTITY_HANDLE*
        ///pCapabilites: DWORD*
        [DllImport("ole32.dll", EntryPoint = "CoQueryProxyBlanket", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoQueryProxyBlanket(ref IUnknown pProxy, ref uint pwAuthnSvc, ref uint pAuthzSvc, ref IntPtr pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref IntPtr pAuthInfo, ref uint pCapabilites);


        /// Return Type: HRESULT->LONG->int
        ///pAuthnSvc: DWORD*
        ///pAuthzSvc: DWORD*
        ///pServerPrincName: OLECHAR**
        ///pAuthnLevel: DWORD*
        ///pImpLevel: DWORD*
        ///pPrivs: RPC_AUTHZ_HANDLE*
        ///pCapabilities: DWORD*
        [DllImport("ole32.dll", EntryPoint = "CoQueryClientBlanket", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoQueryClientBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref IntPtr pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref IntPtr pPrivs, ref uint pCapabilities);


        /// Return Type: HRESULT->LONG->int
        ///pcAuthSvc: DWORD*
        ///asAuthSvc: SOLE_AUTHENTICATION_SERVICE**
        [DllImport("ole32.dll", EntryPoint = "CoQueryAuthenticationServices", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoQueryAuthenticationServices(ref uint pcAuthSvc, ref IntPtr asAuthSvc);


        /// Return Type: HRESULT->LONG->int
        ///pcstgmedSrc: STGMEDIUM*
        ///pstgmedDest: STGMEDIUM*
        [DllImport("urlmon.dll", EntryPoint = "CopyStgMedium", CallingConvention = CallingConvention.StdCall)]
        public static extern int CopyStgMedium(ref tagSTGMEDIUM pcstgmedSrc, ref tagSTGMEDIUM pstgmedDest);


        /// Return Type: BOOL->int
        ///nDestinationSidLength: DWORD->unsigned int
        ///pDestinationSid: PSID->PVOID->void*
        ///pSourceSid: PSID->PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "CopySid")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopySid(uint nDestinationSidLength, IntPtr pDestinationSid, [In] IntPtr pSourceSid);


        /// Return Type: BOOL->int
        ///lprcDst: LPRECT->tagRECT*
        ///lprcSrc: RECT*
        [DllImport("user32.dll", EntryPoint = "CopyRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyRect([Out] out tagRECT lprcDst, [In] ref tagRECT lprcSrc);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///param0: HMETAFILE->HMETAFILE__*
        ///param1: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "CopyMetaFileW")]
        public static extern IntPtr CopyMetaFileW([In] IntPtr param0, [In] [MarshalAs(UnmanagedType.LPWStr)] string param1);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///param0: HMETAFILE->HMETAFILE__*
        ///param1: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "CopyMetaFileA")]
        public static extern IntPtr CopyMetaFileA([In] IntPtr param0, [In] [MarshalAs(UnmanagedType.LPStr)] string param1);


        /// Return Type: LONG->int
        ///param0: INT->int
        ///param1: INT->int
        [DllImport("kernel32.dll", EntryPoint = "CopyLZFile")]
        public static extern int CopyLZFile(int param0, int param1);


        /// Return Type: HANDLE->void*
        ///h: HANDLE->void*
        ///type: UINT->unsigned int
        ///cx: int
        ///cy: int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CopyImage")]
        public static extern IntPtr CopyImage([In] IntPtr h, uint type, int cx, int cy, uint flags);


        /// Return Type: HICON->HICON__*
        ///hIcon: HICON->HICON__*
        [DllImport("user32.dll", EntryPoint = "CopyIcon")]
        public static extern IntPtr CopyIcon([In] IntPtr hIcon);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///bFailIfExists: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "CopyFileW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, [MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCWSTR->WCHAR*
        ///lpNewFileName: LPCWSTR->WCHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///pbCancel: LPBOOL->BOOL*
        ///dwCopyFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CopyFileExW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName, LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, [In] IntPtr pbCancel, uint dwCopyFlags);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///lpProgressRoutine: LPPROGRESS_ROUTINE
        ///lpData: LPVOID->void*
        ///pbCancel: LPBOOL->BOOL*
        ///dwCopyFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CopyFileExA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, LPPROGRESS_ROUTINE lpProgressRoutine, [In] IntPtr lpData, [In] IntPtr pbCancel, uint dwCopyFlags);


        /// Return Type: BOOL->int
        ///lpExistingFileName: LPCSTR->CHAR*
        ///lpNewFileName: LPCSTR->CHAR*
        ///bFailIfExists: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "CopyFileA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileA([In] [MarshalAs(UnmanagedType.LPStr)] string lpExistingFileName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpNewFileName, [MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///hEnh: HENHMETAFILE->HENHMETAFILE__*
        ///lpFileName: LPCWSTR->WCHAR*
        [DllImport("gdi32.dll", EntryPoint = "CopyEnhMetaFileW")]
        public static extern IntPtr CopyEnhMetaFileW([In] IntPtr hEnh, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpFileName);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///hEnh: HENHMETAFILE->HENHMETAFILE__*
        ///lpFileName: LPCSTR->CHAR*
        [DllImport("gdi32.dll", EntryPoint = "CopyEnhMetaFileA")]
        public static extern IntPtr CopyEnhMetaFileA([In] IntPtr hEnh, [In] [MarshalAs(UnmanagedType.LPStr)] string lpFileName);


        /// Return Type: HRESULT->LONG->int
        ///pcbiSrc: BINDINFO*
        ///pbiDest: BINDINFO*
        [DllImport("urlmon.dll", EntryPoint = "CopyBindInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int CopyBindInfo(ref BINDINFO pcbiSrc, ref BINDINFO pbiDest);


        /// Return Type: int
        ///hAccelSrc: HACCEL->HACCEL__*
        ///lpAccelDst: LPACCEL->tagACCEL*
        ///cAccelEntries: int
        [DllImport("user32.dll", EntryPoint = "CopyAcceleratorTableW")]
        public static extern int CopyAcceleratorTableW([In] IntPtr hAccelSrc, IntPtr lpAccelDst, int cAccelEntries);


        /// Return Type: int
        ///hAccelSrc: HACCEL->HACCEL__*
        ///lpAccelDst: LPACCEL->tagACCEL*
        ///cAccelEntries: int
        [DllImport("user32.dll", EntryPoint = "CopyAcceleratorTableA")]
        public static extern int CopyAcceleratorTableA([In] IntPtr hAccelSrc, IntPtr lpAccelDst, int cAccelEntries);


        /// Return Type: BOOL->int
        ///ParentDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///CurrentSecurityDescriptor: PSECURITY_DESCRIPTOR->PVOID->void*
        ///NewSecurityDescriptor: PSECURITY_DESCRIPTOR*
        ///ObjectType: GUID*
        ///IsDirectoryObject: BOOLEAN->BYTE->unsigned char
        ///GenericMapping: PGENERIC_MAPPING->GENERIC_MAPPING*
        [DllImport("advapi32.dll", EntryPoint = "ConvertToAutoInheritPrivateObjectSecurity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ConvertToAutoInheritPrivateObjectSecurity([In] IntPtr ParentDescriptor, [In] IntPtr CurrentSecurityDescriptor, out IntPtr NewSecurityDescriptor, [In] IntPtr ObjectType, byte IsDirectoryObject, [In] ref GENERIC_MAPPING GenericMapping);


        /// Return Type: LPVOID->void*
        ///lpParameter: LPVOID->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ConvertThreadToFiberEx")]
        public static extern IntPtr ConvertThreadToFiberEx([In] IntPtr lpParameter, uint dwFlags);


        /// Return Type: LPVOID->void*
        ///lpParameter: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ConvertThreadToFiber")]
        public static extern IntPtr ConvertThreadToFiber([In] IntPtr lpParameter);


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "ConvertFiberToThread")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ConvertFiberToThread();


        /// Return Type: LCID->DWORD->unsigned int
        ///Locale: LCID->DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ConvertDefaultLocale")]
        public static extern uint ConvertDefaultLocale(uint Locale);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwControl: DWORD->unsigned int
        ///lpServiceStatus: LPSERVICE_STATUS->_SERVICE_STATUS*
        [DllImport("advapi32.dll", EntryPoint = "ControlService")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ControlService([In] ref SC_HANDLE__ hService, uint dwControl, [Out] out SERVICE_STATUS lpServiceStatus);


        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        ///dwThreadId: DWORD->unsigned int
        ///dwContinueStatus: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ContinueDebugEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ContinueDebugEvent(uint dwProcessId, uint dwThreadId, uint dwContinueStatus);


        /// Return Type: HANDLE->void*
        ///hwnd: HWND->HWND__*
        ///Flags: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "ConnectToPrinterDlg")]
        public static extern IntPtr ConnectToPrinterDlg([In] IntPtr hwnd, uint Flags);


        /// Return Type: BOOL->int
        ///hNamedPipe: HANDLE->void*
        ///lpOverlapped: LPOVERLAPPED->_OVERLAPPED*
        [DllImport("kernel32.dll", EntryPoint = "ConnectNamedPipe")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ConnectNamedPipe([In] IntPtr hNamedPipe, IntPtr lpOverlapped);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        ///name: sockaddr*
        ///namelen: int
        [DllImport("ws2_32.dll", EntryPoint = "connect", CallingConvention = CallingConvention.StdCall)]
        public static extern int connect([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s, ref sockaddr name, int namelen);


        /// Return Type: BOOL->int
        ///pName: LPWSTR->WCHAR*
        ///hWnd: HWND->HWND__*
        ///pPortName: LPWSTR->WCHAR*
        [DllImport("<Unknown>", EntryPoint = "ConfigurePortW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ConfigurePortW([In] [MarshalAs(UnmanagedType.LPWStr)] string pName, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string pPortName);


        /// Return Type: BOOL->int
        ///pName: LPSTR->CHAR*
        ///hWnd: HWND->HWND__*
        ///pPortName: LPSTR->CHAR*
        [DllImport("<Unknown>", EntryPoint = "ConfigurePortA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ConfigurePortA([In] [MarshalAs(UnmanagedType.LPStr)] string pName, [In] IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string pPortName);


        /// Return Type: HRESULT->LONG->int
        ///pclsid: CLSID*
        ///pdwCompatFlags: LPDWORD->DWORD*
        ///pdwMiscStatusFlags: LPDWORD->DWORD*
        [DllImport("urlmon.dll", EntryPoint = "CompatFlagsFromClsid", CallingConvention = CallingConvention.StdCall)]
        public static extern int CompatFlagsFromClsid(ref GUID pclsid, ref uint pdwCompatFlags, ref uint pdwMiscStatusFlags);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwCmpFlags: DWORD->unsigned int
        ///lpString1: LPCWSTR->WCHAR*
        ///cchCount1: int
        ///lpString2: LPCWSTR->WCHAR*
        ///cchCount2: int
        [DllImport("kernel32.dll", EntryPoint = "CompareStringW")]
        public static extern int CompareStringW(uint Locale, uint dwCmpFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString1, int cchCount1, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpString2, int cchCount2);


        /// Return Type: int
        ///Locale: LCID->DWORD->unsigned int
        ///dwCmpFlags: DWORD->unsigned int
        ///lpString1: LPCSTR->CHAR*
        ///cchCount1: int
        ///lpString2: LPCSTR->CHAR*
        ///cchCount2: int
        [DllImport("kernel32.dll", EntryPoint = "CompareStringA")]
        public static extern int CompareStringA(uint Locale, uint dwCmpFlags, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString1, int cchCount1, [In] [MarshalAs(UnmanagedType.LPStr)] string lpString2, int cchCount2);


        /// Return Type: HRESULT->LONG->int
        ///pbSecurityId1: BYTE*
        ///dwLen1: DWORD->unsigned int
        ///pbSecurityId2: BYTE*
        ///dwLen2: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CompareSecurityIds", CallingConvention = CallingConvention.StdCall)]
        public static extern int CompareSecurityIds(ref byte pbSecurityId1, uint dwLen1, ref byte pbSecurityId2, uint dwLen2, uint dwReserved);


        /// Return Type: LONG->int
        ///lpFileTime1: FILETIME*
        ///lpFileTime2: FILETIME*
        [DllImport("kernel32.dll", EntryPoint = "CompareFileTime")]
        public static extern int CompareFileTime([In] ref FILETIME lpFileTime1, [In] ref FILETIME lpFileTime2);


        /// Return Type: DWORD->unsigned int
        [DllImport("comdlg32.dll", EntryPoint = "CommDlgExtendedError")]
        public static extern uint CommDlgExtendedError();


        /// Return Type: BOOL->int
        ///lpszName: LPCWSTR->WCHAR*
        ///hWnd: HWND->HWND__*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        [DllImport("kernel32.dll", EntryPoint = "CommConfigDialogW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CommConfigDialogW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszName, [In] IntPtr hWnd, ref COMMCONFIG lpCC);


        /// Return Type: BOOL->int
        ///lpszName: LPCSTR->CHAR*
        ///hWnd: HWND->HWND__*
        ///lpCC: LPCOMMCONFIG->_COMMCONFIG*
        [DllImport("kernel32.dll", EntryPoint = "CommConfigDialogA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CommConfigDialogA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszName, [In] IntPtr hWnd, ref COMMCONFIG lpCC);


        /// Return Type: LPWSTR*
        ///lpCmdLine: LPCWSTR->WCHAR*
        ///pNumArgs: int*
        [DllImport("shell32.dll", EntryPoint = "CommandLineToArgvW", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CommandLineToArgvW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpCmdLine, ref int pNumArgs);


        /// Return Type: BOOL->int
        ///lpxfOut: LPXFORM->tagXFORM*
        ///lpxf1: XFORM*
        ///lpxf2: XFORM*
        [DllImport("gdi32.dll", EntryPoint = "CombineTransform")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CombineTransform([Out] out tagXFORM lpxfOut, [In] ref tagXFORM lpxf1, [In] ref tagXFORM lpxf2);


        /// Return Type: int
        ///hrgnDst: HRGN->HRGN__*
        ///hrgnSrc1: HRGN->HRGN__*
        ///hrgnSrc2: HRGN->HRGN__*
        ///iMode: int
        [DllImport("gdi32.dll", EntryPoint = "CombineRgn")]
        public static extern int CombineRgn([In] IntPtr hrgnDst, [In] IntPtr hrgnSrc1, [In] IntPtr hrgnSrc2, int iMode);


        /// Return Type: HRESULT->LONG->int
        ///riid: IID*
        ///pUnk: LPUNKNOWN->IUnknown*
        ///ppStm: LPSTREAM*
        [DllImport("ole32.dll", EntryPoint = "CoMarshalInterThreadInterfaceInStream", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoMarshalInterThreadInterfaceInStream(ref GUID riid, ref IUnknown pUnk, ref IntPtr ppStm);


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        ///riid: IID*
        ///pUnk: LPUNKNOWN->IUnknown*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: LPVOID->void*
        ///mshlflags: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoMarshalInterface", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoMarshalInterface(ref IStream pStm, ref GUID riid, ref IUnknown pUnk, uint dwDestContext, IntPtr pvDestContext, uint mshlflags);


        /// Return Type: HRESULT->LONG->int
        ///pstm: LPSTREAM->IStream*
        ///hresult: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "CoMarshalHresult", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoMarshalHresult(ref IStream pstm, int hresult);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hdcTarget: HDC->HDC__*
        ///action: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "ColorMatchToTarget")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ColorMatchToTarget([In] IntPtr hdc, [In] IntPtr hdcTarget, uint action);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///hPal: HPALETTE->HPALETTE__*
        ///deFirst: DWORD->unsigned int
        ///num: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "ColorCorrectPalette")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ColorCorrectPalette([In] IntPtr hdc, [In] IntPtr hPal, uint deFirst, uint num);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: LPUNKNOWN->IUnknown*
        ///fLock: BOOL->int
        ///fLastUnlockReleases: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "CoLockObjectExternal", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoLockObjectExternal(ref IUnknown pUnk, [MarshalAs(UnmanagedType.Bool)] bool fLock, [MarshalAs(UnmanagedType.Bool)] bool fLastUnlockReleases);


        /// Return Type: HINSTANCE->HINSTANCE__*
        ///lpszLibName: LPOLESTR->OLECHAR*
        ///bAutoFree: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "CoLoadLibrary", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CoLoadLibrary(IntPtr lpszLibName, [MarshalAs(UnmanagedType.Bool)] bool bAutoFree);


        /// Return Type: BOOL->int
        ///rclsid: IID*
        [DllImport("ole32.dll", EntryPoint = "CoIsOle1Class", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CoIsOle1Class(ref GUID rclsid);


        /// Return Type: BOOL->int
        ///pUnk: LPUNKNOWN->IUnknown*
        [DllImport("ole32.dll", EntryPoint = "CoIsHandlerConnected", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CoIsHandlerConnected(ref IUnknown pUnk);


        /// Return Type: HRESULT->LONG->int
        ///pszMachineName: LPOLESTR->OLECHAR*
        [DllImport("ole32.dll", EntryPoint = "CoInvalidateRemoteMachineBindings", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInvalidateRemoteMachineBindings(IntPtr pszMachineName);


        /// Return Type: HRESULT->LONG->int
        ///FeatureEntry: INTERNETFEATURELIST->_tagINTERNETFEATURELIST
        ///dwFlags: DWORD->unsigned int
        ///fEnable: BOOL->int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetSetFeatureEnabled", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetSetFeatureEnabled(INTERNETFEATURELIST FeatureEntry, uint dwFlags, [MarshalAs(UnmanagedType.Bool)] bool fEnable);


        /// Return Type: HRESULT->LONG->int
        ///pwzUrl: LPCWSTR->WCHAR*
        ///QueryOptions: QUERYOPTION->_tagQUERYOPTION
        ///dwQueryFlags: DWORD->unsigned int
        ///pvBuffer: LPVOID->void*
        ///cbBuffer: DWORD->unsigned int
        ///pcbBuffer: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetQueryInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetQueryInfo([In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, QUERYOPTION QueryOptions, uint dwQueryFlags, IntPtr pvBuffer, uint cbBuffer, ref uint pcbBuffer, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pwzUrl: LPCWSTR->WCHAR*
        ///ParseAction: PARSEACTION->_tagPARSEACTION
        ///dwFlags: DWORD->unsigned int
        ///pszResult: LPWSTR->WCHAR*
        ///cchResult: DWORD->unsigned int
        ///pcchResult: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetParseUrl", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetParseUrl([In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, PARSEACTION ParseAction, uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszResult, uint cchResult, ref uint pcchResult, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///szFromURL: LPCWSTR->WCHAR*
        ///szToURL: LPCWSTR->WCHAR*
        ///pSecMgr: IInternetSecurityManager*
        ///dwFlags: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetIsFeatureZoneElevationEnabled", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetIsFeatureZoneElevationEnabled([In] [MarshalAs(UnmanagedType.LPWStr)] string szFromURL, [In] [MarshalAs(UnmanagedType.LPWStr)] string szToURL, ref IInternetSecurityManager pSecMgr, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///FeatureEntry: INTERNETFEATURELIST->_tagINTERNETFEATURELIST
        ///dwFlags: DWORD->unsigned int
        ///szURL: LPCWSTR->WCHAR*
        ///pSecMgr: IInternetSecurityManager*
        [DllImport("urlmon.dll", EntryPoint = "CoInternetIsFeatureEnabledForUrl", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetIsFeatureEnabledForUrl(INTERNETFEATURELIST FeatureEntry, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string szURL, ref IInternetSecurityManager pSecMgr);


        /// Return Type: HRESULT->LONG->int
        ///FeatureEntry: INTERNETFEATURELIST->_tagINTERNETFEATURELIST
        ///dwFlags: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetIsFeatureEnabled", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetIsFeatureEnabled(INTERNETFEATURELIST FeatureEntry, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///dwSessionMode: DWORD->unsigned int
        ///ppIInternetSession: IInternetSession**
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetGetSession", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetGetSession(uint dwSessionMode, ref IntPtr ppIInternetSession, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pwzUrl: LPCWSTR->WCHAR*
        ///ppwzSecUrl: LPWSTR*
        ///psuAction: PSUACTION->_tagPSUACTION
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetGetSecurityUrl", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetGetSecurityUrl([In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, ref IntPtr ppwzSecUrl, PSUACTION psuAction, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pwzUrl: LPCWSTR->WCHAR*
        ///pdwFlags: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetGetProtocolFlags", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetGetProtocolFlags([In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl, ref uint pdwFlags, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pSP: IServiceProvider*
        ///ppZM: IInternetZoneManager**
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetCreateZoneManager", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetCreateZoneManager(ref IServiceProvider pSP, ref IntPtr ppZM, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pSP: IServiceProvider*
        ///ppSM: IInternetSecurityManager**
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetCreateSecurityManager", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetCreateSecurityManager(ref IServiceProvider pSP, ref IntPtr ppSM, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pwzUrl1: LPCWSTR->WCHAR*
        ///pwzUrl2: LPCWSTR->WCHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetCompareUrl", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetCompareUrl([In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl1, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl2, uint dwFlags);


        /// Return Type: HRESULT->LONG->int
        ///pwzBaseUrl: LPCWSTR->WCHAR*
        ///pwzRelativeUrl: LPCWSTR->WCHAR*
        ///dwCombineFlags: DWORD->unsigned int
        ///pszResult: LPWSTR->WCHAR*
        ///cchResult: DWORD->unsigned int
        ///pcchResult: DWORD*
        ///dwReserved: DWORD->unsigned int
        [DllImport("urlmon.dll", EntryPoint = "CoInternetCombineUrl", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInternetCombineUrl([In] [MarshalAs(UnmanagedType.LPWStr)] string pwzBaseUrl, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwzRelativeUrl, uint dwCombineFlags, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszResult, uint cchResult, ref uint pcchResult, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pbc: IBindCtx*
        ///dwFlags: DWORD->unsigned int
        ///pClassSpec: uCLSSPEC*
        ///pQuery: QUERYCONTEXT*
        ///pszCodeBase: LPWSTR->WCHAR*
        [DllImport("urlmon.dll", EntryPoint = "CoInstall", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInstall(ref IBindCtx pbc, uint dwFlags, ref uCLSSPEC pClassSpec, ref tagQUERYCONTEXT pQuery, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszCodeBase);


        /// Return Type: HRESULT->LONG->int
        ///pSecDesc: PSECURITY_DESCRIPTOR->PVOID->void*
        ///cAuthSvc: LONG->int
        ///asAuthSvc: SOLE_AUTHENTICATION_SERVICE*
        ///pReserved1: void*
        ///dwAuthnLevel: DWORD->unsigned int
        ///dwImpLevel: DWORD->unsigned int
        ///pAuthList: void*
        ///dwCapabilities: DWORD->unsigned int
        ///pReserved3: void*
        [DllImport("ole32.dll", EntryPoint = "CoInitializeSecurity", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInitializeSecurity(IntPtr pSecDesc, int cAuthSvc, ref tagSOLE_AUTHENTICATION_SERVICE asAuthSvc, IntPtr pReserved1, uint dwAuthnLevel, uint dwImpLevel, IntPtr pAuthList, uint dwCapabilities, IntPtr pReserved3);


        /// Return Type: HRESULT->LONG->int
        ///pvReserved: LPVOID->void*
        ///dwCoInit: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoInitializeEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInitializeEx(IntPtr pvReserved, uint dwCoInit);


        /// Return Type: HRESULT->LONG->int
        ///pvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "CoInitialize", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoInitialize(IntPtr pvReserved);


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "CoImpersonateClient", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoImpersonateClient();


        /// Return Type: HRESULT->LONG->int
        ///clsidOld: IID*
        ///pClsidNew: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "CoGetTreatAsClass", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetTreatAsClass(ref GUID clsidOld, ref GUID pClsidNew);


        /// Return Type: HRESULT->LONG->int
        ///comSDType: COMSD->tagCOMSD
        ///ppSD: PSECURITY_DESCRIPTOR*
        [DllImport("ole32.dll", EntryPoint = "CoGetSystemSecurityPermissions", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetSystemSecurityPermissions(tagCOMSD comSDType, ref IntPtr ppSD);


        /// Return Type: HRESULT->LONG->int
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///smexflags: DWORD->unsigned int
        ///ppUnkInner: LPUNKNOWN*
        [DllImport("ole32.dll", EntryPoint = "CoGetStdMarshalEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetStdMarshalEx(ref IUnknown pUnkOuter, uint smexflags, ref IntPtr ppUnkInner);


        /// Return Type: HRESULT->LONG->int
        ///riid: IID*
        ///pUnk: LPUNKNOWN->IUnknown*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: LPVOID->void*
        ///mshlflags: DWORD->unsigned int
        ///ppMarshal: LPMARSHAL*
        [DllImport("ole32.dll", EntryPoint = "CoGetStandardMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetStandardMarshal(ref GUID riid, ref IUnknown pUnk, uint dwDestContext, IntPtr pvDestContext, uint mshlflags, ref IntPtr ppMarshal);


        /// Return Type: HRESULT->LONG->int
        ///riid: IID*
        ///pClsid: CLSID*
        [DllImport("ole32.dll", EntryPoint = "CoGetPSClsid", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetPSClsid(ref GUID riid, ref GUID pClsid);


        /// Return Type: HRESULT->LONG->int
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "CoGetObjectContext", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetObjectContext(ref GUID riid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///pszName: LPCWSTR->WCHAR*
        ///pBindOptions: BIND_OPTS*
        ///riid: IID*
        ///ppv: void**
        [DllImport("ole32.dll", EntryPoint = "CoGetObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetObject([In] [MarshalAs(UnmanagedType.LPWStr)] string pszName, ref tagBIND_OPTS pBindOptions, ref GUID riid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///pulSize: ULONG*
        ///riid: IID*
        ///pUnk: LPUNKNOWN->IUnknown*
        ///dwDestContext: DWORD->unsigned int
        ///pvDestContext: LPVOID->void*
        ///mshlflags: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoGetMarshalSizeMax", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetMarshalSizeMax(ref uint pulSize, ref GUID riid, ref IUnknown pUnk, uint dwDestContext, IntPtr pvDestContext, uint mshlflags);


        /// Return Type: HRESULT->LONG->int
        ///dwMemContext: DWORD->unsigned int
        ///ppMalloc: LPMALLOC*
        [DllImport("ole32.dll", EntryPoint = "CoGetMalloc", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetMalloc(uint dwMemContext, ref IntPtr ppMalloc);


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        ///iid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "CoGetInterfaceAndReleaseStream", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetInterfaceAndReleaseStream(ref IStream pStm, ref GUID iid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///pServerInfo: COSERVERINFO*
        ///pClsid: CLSID*
        ///punkOuter: IUnknown*
        ///dwClsCtx: DWORD->unsigned int
        ///pstg: IStorage*
        ///dwCount: DWORD->unsigned int
        ///pResults: MULTI_QI*
        [DllImport("ole32.dll", EntryPoint = "CoGetInstanceFromIStorage", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetInstanceFromIStorage(ref COSERVERINFO pServerInfo, ref GUID pClsid, ref IUnknown punkOuter, uint dwClsCtx, ref IStorage pstg, uint dwCount, ref tagMULTI_QI pResults);


        /// Return Type: HRESULT->LONG->int
        ///pServerInfo: COSERVERINFO*
        ///pClsid: CLSID*
        ///punkOuter: IUnknown*
        ///dwClsCtx: DWORD->unsigned int
        ///grfMode: DWORD->unsigned int
        ///pwszName: OLECHAR*
        ///dwCount: DWORD->unsigned int
        ///pResults: MULTI_QI*
        [DllImport("ole32.dll", EntryPoint = "CoGetInstanceFromFile", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetInstanceFromFile(ref COSERVERINFO pServerInfo, ref GUID pClsid, ref IUnknown punkOuter, uint dwClsCtx, uint grfMode, IntPtr pwszName, uint dwCount, ref tagMULTI_QI pResults);


        /// Return Type: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoGetCurrentProcess", CallingConvention = CallingConvention.StdCall)]
        public static extern uint CoGetCurrentProcess();


        /// Return Type: HRESULT->LONG->int
        ///pToken: ULONG_PTR*
        [DllImport("ole32.dll", EntryPoint = "CoGetContextToken", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetContextToken(ref uint pToken);


        /// Return Type: HRESULT->LONG->int
        ///rCLASSID: IID*
        ///szCODE: LPCWSTR->WCHAR*
        ///dwFileVersionMS: DWORD->unsigned int
        ///dwFileVersionLS: DWORD->unsigned int
        ///szTYPE: LPCWSTR->WCHAR*
        ///pBindCtx: LPBINDCTX->IBindCtx*
        ///dwClsContext: DWORD->unsigned int
        ///pvReserved: LPVOID->void*
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("urlmon.dll", EntryPoint = "CoGetClassObjectFromURL", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetClassObjectFromURL(ref GUID rCLASSID, [In] [MarshalAs(UnmanagedType.LPWStr)] string szCODE, uint dwFileVersionMS, uint dwFileVersionLS, [In] [MarshalAs(UnmanagedType.LPWStr)] string szTYPE, ref IBindCtx pBindCtx, uint dwClsContext, IntPtr pvReserved, ref GUID riid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///dwClsContext: DWORD->unsigned int
        ///pvReserved: LPVOID->void*
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "CoGetClassObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetClassObject(ref GUID rclsid, uint dwClsContext, IntPtr pvReserved, ref GUID riid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///dwThreadId: DWORD->unsigned int
        ///iid: IID*
        ///ppUnk: void**
        [DllImport("ole32.dll", EntryPoint = "CoGetCancelObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetCancelObject(uint dwThreadId, ref GUID iid, ref IntPtr ppUnk);


        /// Return Type: HRESULT->LONG->int
        ///lpdwTID: LPDWORD->DWORD*
        [DllImport("ole32.dll", EntryPoint = "CoGetCallerTID", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetCallerTID(ref uint lpdwTID);


        /// Return Type: HRESULT->LONG->int
        ///riid: IID*
        ///ppInterface: void**
        [DllImport("ole32.dll", EntryPoint = "CoGetCallContext", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoGetCallContext(ref GUID riid, ref IntPtr ppInterface);


        /// Return Type: void
        ///dwUnloadDelay: DWORD->unsigned int
        ///dwReserved: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoFreeUnusedLibrariesEx", CallingConvention = CallingConvention.StdCall)]
        public static extern void CoFreeUnusedLibrariesEx(uint dwUnloadDelay, uint dwReserved);


        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "CoFreeUnusedLibraries", CallingConvention = CallingConvention.StdCall)]
        public static extern void CoFreeUnusedLibraries();


        /// Return Type: void
        ///hInst: HINSTANCE->HINSTANCE__*
        [DllImport("ole32.dll", EntryPoint = "CoFreeLibrary", CallingConvention = CallingConvention.StdCall)]
        public static extern void CoFreeLibrary(IntPtr hInst);


        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "CoFreeAllLibraries", CallingConvention = CallingConvention.StdCall)]
        public static extern void CoFreeAllLibraries();


        /// Return Type: BOOL->int
        ///lpFileTime: FILETIME*
        ///lpDosDate: LPWORD->WORD*
        ///lpDosTime: LPWORD->WORD*
        [DllImport("ole32.dll", EntryPoint = "CoFileTimeToDosDateTime", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CoFileTimeToDosDateTime(ref FILETIME lpFileTime, ref ushort lpDosDate, ref ushort lpDosTime);


        /// Return Type: HRESULT->LONG->int
        ///lpFileTime: FILETIME*
        [DllImport("ole32.dll", EntryPoint = "CoFileTimeNow", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoFileTimeNow(ref FILETIME lpFileTime);


        /// Return Type: HRESULT->LONG->int
        ///pReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "CoEnableCallCancellation", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoEnableCallCancellation(IntPtr pReserved);


        /// Return Type: BOOL->int
        ///nDosDate: WORD->unsigned short
        ///nDosTime: WORD->unsigned short
        ///lpFileTime: FILETIME*
        [DllImport("ole32.dll", EntryPoint = "CoDosDateTimeToFileTime", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CoDosDateTimeToFileTime(ushort nDosDate, ushort nDosTime, ref FILETIME lpFileTime);


        /// Return Type: HRESULT->LONG->int
        ///pUnk: LPUNKNOWN->IUnknown*
        ///dwReserved: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoDisconnectObject", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoDisconnectObject(ref IUnknown pUnk, uint dwReserved);


        /// Return Type: HRESULT->LONG->int
        ///pReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "CoDisableCallCancellation", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoDisableCallCancellation(IntPtr pReserved);


        /// Return Type: HRESULT->LONG->int
        ///memctx: DWORD->unsigned int
        ///ppMalloc: IMalloc**
        [DllImport("<Unknown>", EntryPoint = "CoCreateStandardMalloc", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoCreateStandardMalloc(uint memctx, ref IntPtr ppMalloc);


        /// Return Type: HRESULT->LONG->int
        ///Clsid: IID*
        ///punkOuter: IUnknown*
        ///dwClsCtx: DWORD->unsigned int
        ///pServerInfo: COSERVERINFO*
        ///dwCount: DWORD->unsigned int
        ///pResults: MULTI_QI*
        [DllImport("ole32.dll", EntryPoint = "CoCreateInstanceEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoCreateInstanceEx(ref GUID Clsid, ref IUnknown punkOuter, uint dwClsCtx, ref COSERVERINFO pServerInfo, uint dwCount, ref tagMULTI_QI pResults);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///dwClsContext: DWORD->unsigned int
        ///riid: IID*
        ///ppv: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "CoCreateInstance", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoCreateInstance(ref GUID rclsid, ref IUnknown pUnkOuter, uint dwClsContext, ref GUID riid, ref IntPtr ppv);


        /// Return Type: HRESULT->LONG->int
        ///pguid: GUID*
        [DllImport("ole32.dll", EntryPoint = "CoCreateGuid", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoCreateGuid(ref GUID pguid);


        /// Return Type: HRESULT->LONG->int
        ///punkOuter: LPUNKNOWN->IUnknown*
        ///ppunkMarshal: LPUNKNOWN*
        [DllImport("ole32.dll", EntryPoint = "CoCreateFreeThreadedMarshaler", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoCreateFreeThreadedMarshaler(ref IUnknown punkOuter, ref IntPtr ppunkMarshal);


        /// Return Type: HRESULT->LONG->int
        ///pProxy: IUnknown*
        ///ppCopy: IUnknown**
        [DllImport("ole32.dll", EntryPoint = "CoCopyProxy", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoCopyProxy(ref IUnknown pProxy, ref IntPtr ppCopy);


        /// Return Type: HRESULT->LONG->int
        ///dwThreadId: DWORD->unsigned int
        ///ulTimeout: ULONG->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoCancelCall", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoCancelCall(uint dwThreadId, uint ulTimeout);


        /// Return Type: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoBuildVersion", CallingConvention = CallingConvention.StdCall)]
        public static extern uint CoBuildVersion();


        /// Return Type: HRESULT->LONG->int
        ///pUnk: IUnknown*
        ///lpvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "CoAllowSetForegroundWindow", CallingConvention = CallingConvention.StdCall)]
        public static extern int CoAllowSetForegroundWindow(ref IUnknown pUnk, IntPtr lpvReserved);


        /// Return Type: ULONG->unsigned int
        [DllImport("ole32.dll", EntryPoint = "CoAddRefServerProcess", CallingConvention = CallingConvention.StdCall)]
        public static extern uint CoAddRefServerProcess();


        /// Return Type: HRESULT->LONG->int
        ///lpsz: LPOLESTR->OLECHAR*
        ///pclsid: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "CLSIDFromString", CallingConvention = CallingConvention.StdCall)]
        public static extern int CLSIDFromString(IntPtr lpsz, ref GUID pclsid);


        /// Return Type: HRESULT->LONG->int
        ///lpszProgID: LPCOLESTR->OLECHAR*
        ///lpclsid: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "CLSIDFromProgIDEx", CallingConvention = CallingConvention.StdCall)]
        public static extern int CLSIDFromProgIDEx([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszProgID, ref GUID lpclsid);


        /// Return Type: HRESULT->LONG->int
        ///lpszProgID: LPCOLESTR->OLECHAR*
        ///lpclsid: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "CLSIDFromProgID", CallingConvention = CallingConvention.StdCall)]
        public static extern int CLSIDFromProgID([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszProgID, ref GUID lpclsid);


        /// Return Type: BOOL->int
        ///hWinSta: HWINSTA->HWINSTA__*
        [DllImport("user32.dll", EntryPoint = "CloseWindowStation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseWindowStation([In] IntPtr hWinSta);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "CloseWindow")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseWindow([In] IntPtr hWnd);


        /// Return Type: int
        ///s: SOCKET->UINT_PTR->unsigned int
        [DllImport("ws2_32.dll", EntryPoint = "closesocket", CallingConvention = CallingConvention.StdCall)]
        public static extern int closesocket([MarshalAs(UnmanagedType.SysUInt)] UIntPtr s);


        /// Return Type: BOOL->int
        ///hSCObject: SC_HANDLE->SC_HANDLE__*
        [DllImport("advapi32.dll", EntryPoint = "CloseServiceHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseServiceHandle([In] ref SC_HANDLE__ hSCObject);


        /// Return Type: BOOL->int
        ///hPrinter: HANDLE->void*
        [DllImport("<Unknown>", EntryPoint = "ClosePrinter")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClosePrinter([In] IntPtr hPrinter);


        /// Return Type: HMETAFILE->HMETAFILE__*
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "CloseMetaFile")]
        public static extern IntPtr CloseMetaFile([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hObject: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle([In] IntPtr hObject);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "CloseFigure")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseFigure([In] IntPtr hdc);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        [DllImport("advapi32.dll", EntryPoint = "CloseEventLog")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseEventLog([In] IntPtr hEventLog);


        /// Return Type: HENHMETAFILE->HENHMETAFILE__*
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "CloseEnhMetaFile")]
        public static extern IntPtr CloseEnhMetaFile([In] IntPtr hdc);


        /// Return Type: void
        ///pvContext: PVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "CloseEncryptedFileRaw")]
        public static extern void CloseEncryptedFileRaw([In] IntPtr pvContext);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hDriver: HDRVR->HDRVR__*
        ///lParam1: LPARAM->LONG_PTR->int
        ///lParam2: LPARAM->LONG_PTR->int
        [DllImport("winmm.dll", EntryPoint = "CloseDriver")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr CloseDriver(IntPtr hDriver, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam1, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam2);


        /// Return Type: BOOL->int
        ///hDesktop: HDESK->HDESK__*
        [DllImport("user32.dll", EntryPoint = "CloseDesktop")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseDesktop([In] IntPtr hDesktop);


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint = "CloseClipboard")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseClipboard();


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: CLIPFORMAT*
        [DllImport("ole32.dll", EntryPoint = "CLIPFORMAT_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CLIPFORMAT_UserUnmarshal(ref uint param0, IntPtr param1, ref ushort param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: CLIPFORMAT*
        [DllImport("ole32.dll", EntryPoint = "CLIPFORMAT_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint CLIPFORMAT_UserSize(ref uint param0, uint param1, ref ushort param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: CLIPFORMAT*
        [DllImport("ole32.dll", EntryPoint = "CLIPFORMAT_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CLIPFORMAT_UserMarshal(ref uint param0, IntPtr param1, ref ushort param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: CLIPFORMAT*
        [DllImport("ole32.dll", EntryPoint = "CLIPFORMAT_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void CLIPFORMAT_UserFree(ref uint param0, ref ushort param1);


        /// Return Type: BOOL->int
        ///lpRect: RECT*
        [DllImport("user32.dll", EntryPoint = "ClipCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClipCursor([In] IntPtr lpRect);


        /// Return Type: BOOL->int
        ///hWnd: HWND->HWND__*
        ///lpPoint: LPPOINT->tagPOINT*
        [DllImport("user32.dll", EntryPoint = "ClientToScreen")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClientToScreen([In] IntPtr hWnd, ref Point lpPoint);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///lpBackupFileName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "ClearEventLogW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClearEventLogW([In] IntPtr hEventLog, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBackupFileName);


        /// Return Type: BOOL->int
        ///hEventLog: HANDLE->void*
        ///lpBackupFileName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "ClearEventLogA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClearEventLogA([In] IntPtr hEventLog, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBackupFileName);


        /// Return Type: void
        ///pCustData: LPCUSTDATA->tagCUSTDATA*
        [DllImport("oleaut32.dll", EntryPoint = "ClearCustData", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearCustData(ref tagCUSTDATA pCustData);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        ///lpErrors: LPDWORD->DWORD*
        ///lpStat: LPCOMSTAT->_COMSTAT*
        [DllImport("kernel32.dll", EntryPoint = "ClearCommError")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClearCommError([In] IntPtr hFile, IntPtr lpErrors, IntPtr lpStat);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "ClearCommBreak")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClearCommBreak([In] IntPtr hFile);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "CLEANLOCALSTORAGE_UserUnmarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CLEANLOCALSTORAGE_UserUnmarshal(ref uint param0, IntPtr param1, ref tagCLEANLOCALSTORAGE param2);


        /// Return Type: unsigned int
        ///param0: unsigned int*
        ///param1: unsigned int
        ///param2: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "CLEANLOCALSTORAGE_UserSize", CallingConvention = CallingConvention.StdCall)]
        public static extern uint CLEANLOCALSTORAGE_UserSize(ref uint param0, uint param1, ref tagCLEANLOCALSTORAGE param2);


        /// Return Type: unsigned char*
        ///param0: unsigned int*
        ///param1: unsigned char*
        ///param2: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "CLEANLOCALSTORAGE_UserMarshal", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CLEANLOCALSTORAGE_UserMarshal(ref uint param0, IntPtr param1, ref tagCLEANLOCALSTORAGE param2);


        /// Return Type: void
        ///param0: unsigned int*
        ///param1: CLEANLOCALSTORAGE*
        [DllImport("<Unknown>", EntryPoint = "CLEANLOCALSTORAGE_UserFree", CallingConvention = CallingConvention.StdCall)]
        public static extern void CLEANLOCALSTORAGE_UserFree(ref uint param0, ref tagCLEANLOCALSTORAGE param1);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///x1: int
        ///y1: int
        ///x2: int
        ///y2: int
        ///x3: int
        ///y3: int
        ///x4: int
        ///y4: int
        [DllImport("gdi32.dll", EntryPoint = "Chord")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Chord([In] IntPtr hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);


        /// Return Type: int
        ///hdc: HDC->HDC__*
        ///ppfd: PIXELFORMATDESCRIPTOR*
        [DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat")]
        public static extern int ChoosePixelFormat([In] IntPtr hdc, [In] ref tagPIXELFORMATDESCRIPTOR ppfd);


        /// Return Type: BOOL->int
        ///param0: LPCHOOSEFONTW->tagCHOOSEFONTW*
        [DllImport("comdlg32.dll", EntryPoint = "ChooseFontW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChooseFontW(ref tagCHOOSEFONTW param0);


        /// Return Type: BOOL->int
        ///param0: LPCHOOSEFONTA->tagCHOOSEFONTA*
        [DllImport("comdlg32.dll", EntryPoint = "ChooseFontA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChooseFontA(ref tagCHOOSEFONTA param0);


        /// Return Type: BOOL->int
        ///param0: LPCHOOSECOLORW->tagCHOOSECOLORW*
        [DllImport("comdlg32.dll", EntryPoint = "ChooseColorW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChooseColorW(ref tagCHOOSECOLORW param0);


        /// Return Type: BOOL->int
        ///param0: LPCHOOSECOLORA->tagCHOOSECOLORA*
        [DllImport("comdlg32.dll", EntryPoint = "ChooseColorA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChooseColorA(ref tagCHOOSECOLORA param0);


        /// Return Type: HWND->HWND__*
        ///hwnd: HWND->HWND__*
        ///pt: POINT->tagPOINT
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChildWindowFromPointEx")]
        public static extern IntPtr ChildWindowFromPointEx([In] IntPtr hwnd, Point pt, uint flags);


        /// Return Type: HWND->HWND__*
        ///hWndParent: HWND->HWND__*
        ///Point: POINT->tagPOINT
        [DllImport("user32.dll", EntryPoint = "ChildWindowFromPoint")]
        public static extern IntPtr ChildWindowFromPoint([In] IntPtr hWndParent, Point Point);


        /// Return Type: BOOL->int
        ///TokenHandle: HANDLE->void*
        ///SidToCheck: PSID->PVOID->void*
        ///IsMember: PBOOL->BOOL*
        [DllImport("advapi32.dll", EntryPoint = "CheckTokenMembership")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckTokenMembership([In] IntPtr TokenHandle, [In] IntPtr SidToCheck, [Out] out int IsMember);


        /// Return Type: BOOL->int
        ///hProcess: HANDLE->void*
        ///pbDebuggerPresent: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckRemoteDebuggerPresent([In] IntPtr hProcess, [Out] out int pbDebuggerPresent);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDFirstButton: int
        ///nIDLastButton: int
        ///nIDCheckButton: int
        [DllImport("user32.dll", EntryPoint = "CheckRadioButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckRadioButton([In] IntPtr hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);


        /// Return Type: BOOL->int
        ///lpName: LPCWSTR->WCHAR*
        ///lpOemName: LPSTR->CHAR*
        ///OemNameSize: DWORD->unsigned int
        ///pbNameContainsSpaces: PBOOL->BOOL*
        ///pbNameLegal: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "CheckNameLegalDOS8Dot3W")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckNameLegalDOS8Dot3W([In] [MarshalAs(UnmanagedType.LPWStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpOemName, uint OemNameSize, IntPtr pbNameContainsSpaces, [Out] out int pbNameLegal);


        /// Return Type: BOOL->int
        ///lpName: LPCSTR->CHAR*
        ///lpOemName: LPSTR->CHAR*
        ///OemNameSize: DWORD->unsigned int
        ///pbNameContainsSpaces: PBOOL->BOOL*
        ///pbNameLegal: PBOOL->BOOL*
        [DllImport("kernel32.dll", EntryPoint = "CheckNameLegalDOS8Dot3A")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckNameLegalDOS8Dot3A([In] [MarshalAs(UnmanagedType.LPStr)] string lpName, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpOemName, uint OemNameSize, IntPtr pbNameContainsSpaces, [Out] out int pbNameLegal);


        /// Return Type: BOOL->int
        ///hmenu: HMENU->HMENU__*
        ///first: UINT->unsigned int
        ///last: UINT->unsigned int
        ///check: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckMenuRadioItem")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckMenuRadioItem([In] IntPtr hmenu, uint first, uint last, uint check, uint flags);


        /// Return Type: DWORD->unsigned int
        ///hMenu: HMENU->HMENU__*
        ///uIDCheckItem: UINT->unsigned int
        ///uCheck: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckMenuItem")]
        public static extern uint CheckMenuItem([In] IntPtr hMenu, uint uIDCheckItem, uint uCheck);


        /// Return Type: BOOL->int
        ///hDlg: HWND->HWND__*
        ///nIDButton: int
        ///uCheck: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "CheckDlgButton")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckDlgButton([In] IntPtr hDlg, int nIDButton, uint uCheck);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        ///lpRGBTriple: LPVOID->void*
        ///dlpBuffer: LPVOID->void*
        ///nCount: DWORD->unsigned int
        [DllImport("gdi32.dll", EntryPoint = "CheckColorsInGamut")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckColorsInGamut([In] IntPtr hdc, [In] IntPtr lpRGBTriple, IntPtr dlpBuffer, uint nCount);


        /// Return Type: LPWSTR->WCHAR*
        ///lpsz: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharUpperW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharUpperW(IntPtr lpsz);


        /// Return Type: DWORD->unsigned int
        ///lpsz: LPWSTR->WCHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharUpperBuffW")]
        public static extern uint CharUpperBuffW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpsz, uint cchLength);


        /// Return Type: DWORD->unsigned int
        ///lpsz: LPSTR->CHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharUpperBuffA")]
        public static extern uint CharUpperBuffA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpsz, uint cchLength);


        /// Return Type: LPSTR->CHAR*
        ///lpsz: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharUpperA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharUpperA(IntPtr lpsz);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCWSTR->WCHAR*
        ///lpszDst: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharToOemW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszDst);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCWSTR->WCHAR*
        ///lpszDst: LPSTR->CHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharToOemBuffW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemBuffW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszDst, uint cchDstLength);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        ///cchDstLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharToOemBuffA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemBuffA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszDst, uint cchDstLength);


        /// Return Type: BOOL->int
        ///lpszSrc: LPCSTR->CHAR*
        ///lpszDst: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharToOemA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszSrc, [Out] [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpszDst);


        /// Return Type: LPWSTR->WCHAR*
        ///lpszStart: LPCWSTR->WCHAR*
        ///lpszCurrent: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharPrevW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharPrevW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszStart, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszCurrent);


        /// Return Type: LPSTR->CHAR*
        ///CodePage: WORD->unsigned short
        ///lpStart: LPCSTR->CHAR*
        ///lpCurrentChar: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharPrevExA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharPrevExA(ushort CodePage, [In] [MarshalAs(UnmanagedType.LPStr)] string lpStart, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);


        /// Return Type: LPSTR->CHAR*
        ///lpszStart: LPCSTR->CHAR*
        ///lpszCurrent: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharPrevA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharPrevA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszStart, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszCurrent);


        /// Return Type: LPWSTR->WCHAR*
        ///lpsz: LPCWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharNextW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharNextW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpsz);


        /// Return Type: LPSTR->CHAR*
        ///CodePage: WORD->unsigned short
        ///lpCurrentChar: LPCSTR->CHAR*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharNextExA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharNextExA(ushort CodePage, [In] [MarshalAs(UnmanagedType.LPStr)] string lpCurrentChar, uint dwFlags);


        /// Return Type: LPSTR->CHAR*
        ///lpsz: LPCSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharNextA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharNextA([In] [MarshalAs(UnmanagedType.LPStr)] string lpsz);


        /// Return Type: LPWSTR->WCHAR*
        ///lpsz: LPWSTR->WCHAR*
        [DllImport("user32.dll", EntryPoint = "CharLowerW")]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string CharLowerW(IntPtr lpsz);


        /// Return Type: DWORD->unsigned int
        ///lpsz: LPWSTR->WCHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharLowerBuffW")]
        public static extern uint CharLowerBuffW([MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder lpsz, uint cchLength);


        /// Return Type: DWORD->unsigned int
        ///lpsz: LPSTR->CHAR*
        ///cchLength: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "CharLowerBuffA")]
        public static extern uint CharLowerBuffA([MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder lpsz, uint cchLength);


        /// Return Type: LPSTR->CHAR*
        ///lpsz: LPSTR->CHAR*
        [DllImport("user32.dll", EntryPoint = "CharLowerA")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CharLowerA(IntPtr lpsz);


        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///Timer: HANDLE->void*
        ///DueTime: ULONG->unsigned int
        ///Period: ULONG->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "ChangeTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeTimerQueueTimer([In] IntPtr TimerQueue, IntPtr Timer, uint DueTime, uint Period);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwServiceType: DWORD->unsigned int
        ///dwStartType: DWORD->unsigned int
        ///dwErrorControl: DWORD->unsigned int
        ///lpBinaryPathName: LPCWSTR->WCHAR*
        ///lpLoadOrderGroup: LPCWSTR->WCHAR*
        ///lpdwTagId: LPDWORD->DWORD*
        ///lpDependencies: LPCWSTR->WCHAR*
        ///lpServiceStartName: LPCWSTR->WCHAR*
        ///lpPassword: LPCWSTR->WCHAR*
        ///lpDisplayName: LPCWSTR->WCHAR*
        [DllImport("advapi32.dll", EntryPoint = "ChangeServiceConfigW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeServiceConfigW([In] ref SC_HANDLE__ hService, uint dwServiceType, uint dwStartType, uint dwErrorControl, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBinaryPathName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpLoadOrderGroup, IntPtr lpdwTagId, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDependencies, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpServiceStartName, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpDisplayName);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwServiceType: DWORD->unsigned int
        ///dwStartType: DWORD->unsigned int
        ///dwErrorControl: DWORD->unsigned int
        ///lpBinaryPathName: LPCSTR->CHAR*
        ///lpLoadOrderGroup: LPCSTR->CHAR*
        ///lpdwTagId: LPDWORD->DWORD*
        ///lpDependencies: LPCSTR->CHAR*
        ///lpServiceStartName: LPCSTR->CHAR*
        ///lpPassword: LPCSTR->CHAR*
        ///lpDisplayName: LPCSTR->CHAR*
        [DllImport("advapi32.dll", EntryPoint = "ChangeServiceConfigA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeServiceConfigA([In] ref SC_HANDLE__ hService, uint dwServiceType, uint dwStartType, uint dwErrorControl, [In] [MarshalAs(UnmanagedType.LPStr)] string lpBinaryPathName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpLoadOrderGroup, IntPtr lpdwTagId, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDependencies, [In] [MarshalAs(UnmanagedType.LPStr)] string lpServiceStartName, [In] [MarshalAs(UnmanagedType.LPStr)] string lpPassword, [In] [MarshalAs(UnmanagedType.LPStr)] string lpDisplayName);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwInfoLevel: DWORD->unsigned int
        ///lpInfo: LPVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "ChangeServiceConfig2W")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeServiceConfig2W([In] ref SC_HANDLE__ hService, uint dwInfoLevel, [In] IntPtr lpInfo);


        /// Return Type: BOOL->int
        ///hService: SC_HANDLE->SC_HANDLE__*
        ///dwInfoLevel: DWORD->unsigned int
        ///lpInfo: LPVOID->void*
        [DllImport("advapi32.dll", EntryPoint = "ChangeServiceConfig2A")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeServiceConfig2A([In] ref SC_HANDLE__ hService, uint dwInfoLevel, [In] IntPtr lpInfo);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///cmd: UINT->unsigned int
        ///lpszNewItem: LPCWSTR->WCHAR*
        ///cmdInsert: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeMenuW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeMenuW([In] IntPtr hMenu, uint cmd, [In] [MarshalAs(UnmanagedType.LPWStr)] string lpszNewItem, uint cmdInsert, uint flags);


        /// Return Type: BOOL->int
        ///hMenu: HMENU->HMENU__*
        ///cmd: UINT->unsigned int
        ///lpszNewItem: LPCSTR->CHAR*
        ///cmdInsert: UINT->unsigned int
        ///flags: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeMenuA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeMenuA([In] IntPtr hMenu, uint cmd, [In] [MarshalAs(UnmanagedType.LPStr)] string lpszNewItem, uint cmdInsert, uint flags);


        /// Return Type: LONG->int
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsW")]
        public static extern int ChangeDisplaySettingsW([In] IntPtr lpDevMode, uint dwFlags);


        /// Return Type: LONG->int
        ///lpszDeviceName: LPCWSTR->WCHAR*
        ///lpDevMode: LPDEVMODEW->_devicemodeW*
        ///hwnd: HWND->HWND__*
        ///dwflags: DWORD->unsigned int
        ///lParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsExW")]
        public static extern int ChangeDisplaySettingsExW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszDeviceName, [In] IntPtr lpDevMode, IntPtr hwnd, uint dwflags, [In] IntPtr lParam);


        /// Return Type: LONG->int
        ///lpszDeviceName: LPCSTR->CHAR*
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        ///hwnd: HWND->HWND__*
        ///dwflags: DWORD->unsigned int
        ///lParam: LPVOID->void*
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsExA")]
        public static extern int ChangeDisplaySettingsExA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszDeviceName, [In] IntPtr lpDevMode, IntPtr hwnd, uint dwflags, [In] IntPtr lParam);


        /// Return Type: LONG->int
        ///lpDevMode: LPDEVMODEA->_devicemodeA*
        ///dwFlags: DWORD->unsigned int
        [DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsA")]
        public static extern int ChangeDisplaySettingsA([In] IntPtr lpDevMode, uint dwFlags);


        /// Return Type: BOOL->int
        ///hWndRemove: HWND->HWND__*
        ///hWndNewNext: HWND->HWND__*
        [DllImport("user32.dll", EntryPoint = "ChangeClipboardChain")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeClipboardChain([In] IntPtr hWndRemove, [In] IntPtr hWndNewNext);


        /// Return Type: BOOL->int
        ///pSubjectInfo: PCERT_INFO->_CERT_INFO*
        ///pIssuerInfo: PCERT_INFO->_CERT_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifyValidityNesting")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertVerifyValidityNesting(ref CERT_INFO pSubjectInfo, ref CERT_INFO pIssuerInfo);


        /// Return Type: LONG->int
        ///pTimeToVerify: LPFILETIME->_FILETIME*
        ///pCertInfo: PCERT_INFO->_CERT_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifyTimeValidity")]
        public static extern int CertVerifyTimeValidity(ref FILETIME pTimeToVerify, ref CERT_INFO pCertInfo);


        /// Return Type: BOOL->int
        ///pSubject: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pIssuer: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pdwFlags: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifySubjectCertificateContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertVerifySubjectCertificateContext(ref CERT_CONTEXT pSubject, ref CERT_CONTEXT pIssuer, ref uint pdwFlags);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///dwRevType: DWORD->unsigned int
        ///cContext: DWORD->unsigned int
        ///rgpvContext: PVOID*
        ///dwFlags: DWORD->unsigned int
        ///pRevPara: PCERT_REVOCATION_PARA->_CERT_REVOCATION_PARA*
        ///pRevStatus: PCERT_REVOCATION_STATUS->_CERT_REVOCATION_STATUS*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifyRevocation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertVerifyRevocation(uint dwEncodingType, uint dwRevType, uint cContext, ref IntPtr rgpvContext, uint dwFlags, ref CERT_REVOCATION_PARA pRevPara, ref CERT_REVOCATION_STATUS pRevStatus);


        /// Return Type: BOOL->int
        ///dwEncodingType: DWORD->unsigned int
        ///dwSubjectType: DWORD->unsigned int
        ///pvSubject: void*
        ///pSubjectUsage: PCTL_USAGE->_CTL_USAGE*
        ///dwFlags: DWORD->unsigned int
        ///pVerifyUsagePara: PCTL_VERIFY_USAGE_PARA->_CTL_VERIFY_USAGE_PARA*
        ///pVerifyUsageStatus: PCTL_VERIFY_USAGE_STATUS->_CTL_VERIFY_USAGE_STATUS*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifyCTLUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertVerifyCTLUsage(uint dwEncodingType, uint dwSubjectType, IntPtr pvSubject, ref CERT_ENHKEY_USAGE pSubjectUsage, uint dwFlags, ref CTL_VERIFY_USAGE_PARA pVerifyUsagePara, ref CTL_VERIFY_USAGE_STATUS pVerifyUsageStatus);


        /// Return Type: LONG->int
        ///pTimeToVerify: LPFILETIME->_FILETIME*
        ///pCrlInfo: PCRL_INFO->_CRL_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifyCRLTimeValidity")]
        public static extern int CertVerifyCRLTimeValidity(ref FILETIME pTimeToVerify, ref CRL_INFO pCrlInfo);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pCertId: PCERT_INFO->_CERT_INFO*
        ///cCrlInfo: DWORD->unsigned int
        ///rgpCrlInfo: PCRL_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifyCRLRevocation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertVerifyCRLRevocation(uint dwCertEncodingType, ref CERT_INFO pCertId, uint cCrlInfo, ref IntPtr rgpCrlInfo);


        /// Return Type: BOOL->int
        ///pszPolicyOID: LPCSTR->CHAR*
        ///pChainContext: PCCERT_CHAIN_CONTEXT->CERT_CHAIN_CONTEXT*
        ///pPolicyPara: PCERT_CHAIN_POLICY_PARA->_CERT_CHAIN_POLICY_PARA*
        ///pPolicyStatus: PCERT_CHAIN_POLICY_STATUS->_CERT_CHAIN_POLICY_STATUS*
        [DllImport("crypt32.dll", EntryPoint = "CertVerifyCertificateChainPolicy")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertVerifyCertificateChainPolicy([In] [MarshalAs(UnmanagedType.LPStr)] string pszPolicyOID, ref CERT_CHAIN_CONTEXT pChainContext, ref CERT_CHAIN_POLICY_PARA pPolicyPara, ref CERT_CHAIN_POLICY_STATUS pPolicyStatus);


        /// Return Type: BOOL->int
        ///pvSystemStore: void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertUnregisterSystemStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertUnregisterSystemStore(IntPtr pvSystemStore, uint dwFlags);


        /// Return Type: BOOL->int
        ///pvSystemStore: void*
        ///dwFlags: DWORD->unsigned int
        ///pwszStoreName: LPCWSTR->WCHAR*
        [DllImport("crypt32.dll", EntryPoint = "CertUnregisterPhysicalStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertUnregisterPhysicalStore(IntPtr pvSystemStore, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszStoreName);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pszX500: LPCWSTR->WCHAR*
        ///dwStrType: DWORD->unsigned int
        ///pvReserved: void*
        ///pbEncoded: BYTE*
        ///pcbEncoded: DWORD*
        ///ppszError: LPCWSTR*
        [DllImport("crypt32.dll", EntryPoint = "CertStrToNameW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertStrToNameW(uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPWStr)] string pszX500, uint dwStrType, IntPtr pvReserved, ref byte pbEncoded, ref uint pcbEncoded, ref IntPtr ppszError);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pszX500: LPCSTR->CHAR*
        ///dwStrType: DWORD->unsigned int
        ///pvReserved: void*
        ///pbEncoded: BYTE*
        ///pcbEncoded: DWORD*
        ///ppszError: LPCSTR*
        [DllImport("crypt32.dll", EntryPoint = "CertStrToNameA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertStrToNameA(uint dwCertEncodingType, [In] [MarshalAs(UnmanagedType.LPStr)] string pszX500, uint dwStrType, IntPtr pvReserved, ref byte pbEncoded, ref uint pcbEncoded, ref IntPtr ppszError);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwPropId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvData: void*
        [DllImport("crypt32.dll", EntryPoint = "CertSetStoreProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSetStoreProperty(IntPtr hCertStore, uint dwPropId, uint dwFlags, IntPtr pvData);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pUsage: PCERT_ENHKEY_USAGE->_CTL_USAGE*
        [DllImport("crypt32.dll", EntryPoint = "CertSetEnhancedKeyUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSetEnhancedKeyUsage(ref CERT_CONTEXT pCertContext, ref CERT_ENHKEY_USAGE pUsage);


        /// Return Type: BOOL->int
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvData: void*
        [DllImport("crypt32.dll", EntryPoint = "CertSetCTLContextProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSetCTLContextProperty(ref CTL_CONTEXT pCtlContext, uint dwPropId, uint dwFlags, IntPtr pvData);


        /// Return Type: BOOL->int
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvData: void*
        [DllImport("crypt32.dll", EntryPoint = "CertSetCRLContextProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSetCRLContextProperty(ref CRL_CONTEXT pCrlContext, uint dwPropId, uint dwFlags, IntPtr pvData);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvData: void*
        [DllImport("crypt32.dll", EntryPoint = "CertSetCertificateContextProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSetCertificateContextProperty(ref CERT_CONTEXT pCertContext, uint dwPropId, uint dwFlags, IntPtr pvData);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pCtlEntry: PCTL_ENTRY->_CTL_ENTRY*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertSetCertificateContextPropertiesFromCTLEntry")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSetCertificateContextPropertiesFromCTLEntry(ref CERT_CONTEXT pCertContext, ref CTL_ENTRY pCtlEntry, uint dwFlags);


        /// Return Type: BOOL->int
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pbElement: BYTE*
        ///pcbElement: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertSerializeCTLStoreElement")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSerializeCTLStoreElement(ref CTL_CONTEXT pCtlContext, uint dwFlags, ref byte pbElement, ref uint pcbElement);


        /// Return Type: BOOL->int
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pbElement: BYTE*
        ///pcbElement: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertSerializeCRLStoreElement")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSerializeCRLStoreElement(ref CRL_CONTEXT pCrlContext, uint dwFlags, ref byte pbElement, ref uint pcbElement);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pbElement: BYTE*
        ///pcbElement: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertSerializeCertificateStoreElement")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSerializeCertificateStoreElement(ref CERT_CONTEXT pCertContext, uint dwFlags, ref byte pbElement, ref uint pcbElement);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwEncodingType: DWORD->unsigned int
        ///dwSaveAs: DWORD->unsigned int
        ///dwSaveTo: DWORD->unsigned int
        ///pvSaveToPara: void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertSaveStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertSaveStore(IntPtr hCertStore, uint dwEncodingType, uint dwSaveAs, uint dwSaveTo, IntPtr pvSaveToPara, uint dwFlags);


        /// Return Type: BOOL->int
        ///hChainEngine: HCERTCHAINENGINE->HANDLE->void*
        [DllImport("crypt32.dll", EntryPoint = "CertResyncCertificateChainEngine")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertResyncCertificateChainEngine(IntPtr hChainEngine);


        /// Return Type: void
        ///hCollectionStore: HCERTSTORE->void*
        ///hSiblingStore: HCERTSTORE->void*
        [DllImport("crypt32.dll", EntryPoint = "CertRemoveStoreFromCollection")]
        public static extern void CertRemoveStoreFromCollection(IntPtr hCollectionStore, IntPtr hSiblingStore);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pszUsageIdentifier: LPCSTR->CHAR*
        [DllImport("crypt32.dll", EntryPoint = "CertRemoveEnhancedKeyUsageIdentifier")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertRemoveEnhancedKeyUsageIdentifier(ref CERT_CONTEXT pCertContext, [In] [MarshalAs(UnmanagedType.LPStr)] string pszUsageIdentifier);


        /// Return Type: BOOL->int
        ///pvSystemStore: void*
        ///dwFlags: DWORD->unsigned int
        ///pStoreInfo: PCERT_SYSTEM_STORE_INFO->_CERT_SYSTEM_STORE_INFO*
        ///pvReserved: void*
        [DllImport("crypt32.dll", EntryPoint = "CertRegisterSystemStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertRegisterSystemStore(IntPtr pvSystemStore, uint dwFlags, ref CERT_SYSTEM_STORE_INFO pStoreInfo, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///pvSystemStore: void*
        ///dwFlags: DWORD->unsigned int
        ///pwszStoreName: LPCWSTR->WCHAR*
        ///pStoreInfo: PCERT_PHYSICAL_STORE_INFO->_CERT_PHYSICAL_STORE_INFO*
        ///pvReserved: void*
        [DllImport("crypt32.dll", EntryPoint = "CertRegisterPhysicalStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertRegisterPhysicalStore(IntPtr pvSystemStore, uint dwFlags, [In] [MarshalAs(UnmanagedType.LPWStr)] string pwszStoreName, ref CERT_PHYSICAL_STORE_INFO pStoreInfo, IntPtr pvReserved);


        /// Return Type: DWORD->unsigned int
        ///dwValueType: DWORD->unsigned int
        ///pValue: PCERT_RDN_VALUE_BLOB->_CRYPTOAPI_BLOB*
        ///psz: LPWSTR->WCHAR*
        ///csz: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertRDNValueToStrW")]
        public static extern uint CertRDNValueToStrW(uint dwValueType, ref CRYPT_ATTR_BLOB pValue, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder psz, uint csz);


        /// Return Type: DWORD->unsigned int
        ///dwValueType: DWORD->unsigned int
        ///pValue: PCERT_RDN_VALUE_BLOB->_CRYPTOAPI_BLOB*
        ///psz: LPSTR->CHAR*
        ///csz: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertRDNValueToStrA")]
        public static extern uint CertRDNValueToStrA(uint dwValueType, ref CRYPT_ATTR_BLOB pValue, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder psz, uint csz);


        /// Return Type: HCERTSTORE->void*
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///szSubsystemProtocol: LPCWSTR->WCHAR*
        [DllImport("crypt32.dll", EntryPoint = "CertOpenSystemStoreW")]
        public static extern IntPtr CertOpenSystemStoreW(uint hProv, [In] [MarshalAs(UnmanagedType.LPWStr)] string szSubsystemProtocol);


        /// Return Type: HCERTSTORE->void*
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///szSubsystemProtocol: LPCSTR->CHAR*
        [DllImport("crypt32.dll", EntryPoint = "CertOpenSystemStoreA")]
        public static extern IntPtr CertOpenSystemStoreA(uint hProv, [In] [MarshalAs(UnmanagedType.LPStr)] string szSubsystemProtocol);


        /// Return Type: HCERTSTORE->void*
        ///lpszStoreProvider: LPCSTR->CHAR*
        ///dwEncodingType: DWORD->unsigned int
        ///hCryptProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvPara: void*
        [DllImport("crypt32.dll", EntryPoint = "CertOpenStore")]
        public static extern IntPtr CertOpenStore([In] [MarshalAs(UnmanagedType.LPStr)] string lpszStoreProvider, uint dwEncodingType, uint hCryptProv, uint dwFlags, IntPtr pvPara);


        /// Return Type: DWORD->unsigned int
        ///pszObjId: LPCSTR->CHAR*
        [DllImport("crypt32.dll", EntryPoint = "CertOIDToAlgId")]
        public static extern uint CertOIDToAlgId([In] [MarshalAs(UnmanagedType.LPStr)] string pszObjId);


        /// Return Type: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pName: PCERT_NAME_BLOB->_CRYPTOAPI_BLOB*
        ///dwStrType: DWORD->unsigned int
        ///psz: LPWSTR->WCHAR*
        ///csz: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertNameToStrW")]
        public static extern uint CertNameToStrW(uint dwCertEncodingType, ref CRYPT_ATTR_BLOB pName, uint dwStrType, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder psz, uint csz);


        /// Return Type: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pName: PCERT_NAME_BLOB->_CRYPTOAPI_BLOB*
        ///dwStrType: DWORD->unsigned int
        ///psz: LPSTR->CHAR*
        ///csz: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertNameToStrA")]
        public static extern uint CertNameToStrA(uint dwCertEncodingType, ref CRYPT_ATTR_BLOB pName, uint dwStrType, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder psz, uint csz);


        /// Return Type: BOOL->int
        ///pCert: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pCrl: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        [DllImport("crypt32.dll", EntryPoint = "CertIsValidCRLForCertificate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertIsValidCRLForCertificate(ref CERT_CONTEXT pCert, ref CRL_CONTEXT pCrl, uint dwFlags, IntPtr pvReserved);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pCertName: PCERT_NAME_BLOB->_CRYPTOAPI_BLOB*
        ///pRDN: PCERT_RDN->_CERT_RDN*
        [DllImport("crypt32.dll", EntryPoint = "CertIsRDNAttrsInCertificateName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertIsRDNAttrsInCertificateName(uint dwCertEncodingType, uint dwFlags, ref CRYPT_ATTR_BLOB pCertName, ref CERT_RDN pRDN);


        /// Return Type: BOOL->int
        ///cCerts: DWORD->unsigned int
        ///rghCerts: PCCERT_CONTEXT*
        ///cNumOIDs: int*
        ///rghOIDs: LPSTR*
        ///pcbOIDs: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetValidUsages")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetValidUsages(uint cCerts, ref IntPtr rghCerts, ref int cNumOIDs, ref IntPtr rghOIDs, ref uint pcbOIDs);


        /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///dwCertEncodingType: DWORD->unsigned int
        ///pCertId: PCERT_INFO->_CERT_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertGetSubjectCertificateFromStore")]
        public static extern IntPtr CertGetSubjectCertificateFromStore(IntPtr hCertStore, uint dwCertEncodingType, ref CERT_INFO pCertId);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwPropId: DWORD->unsigned int
        ///pvData: void*
        ///pcbData: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetStoreProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetStoreProperty(IntPtr hCertStore, uint dwPropId, IntPtr pvData, ref uint pcbData);


        /// Return Type: DWORD->unsigned int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pPublicKey: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertGetPublicKeyLength")]
        public static extern uint CertGetPublicKeyLength(uint dwCertEncodingType, ref CERT_PUBLIC_KEY_INFO pPublicKey);


        /// Return Type: DWORD->unsigned int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvTypePara: void*
        ///pszNameString: LPWSTR->WCHAR*
        ///cchNameString: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertGetNameStringW")]
        public static extern uint CertGetNameStringW(ref CERT_CONTEXT pCertContext, uint dwType, uint dwFlags, IntPtr pvTypePara, [MarshalAs(UnmanagedType.LPWStr)] System.Text.StringBuilder pszNameString, uint cchNameString);


        /// Return Type: DWORD->unsigned int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwType: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pvTypePara: void*
        ///pszNameString: LPSTR->CHAR*
        ///cchNameString: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertGetNameStringA")]
        public static extern uint CertGetNameStringA(ref CERT_CONTEXT pCertContext, uint dwType, uint dwFlags, IntPtr pvTypePara, [MarshalAs(UnmanagedType.LPStr)] System.Text.StringBuilder pszNameString, uint cchNameString);


        /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///pSubjectContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pPrevIssuerContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pdwFlags: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetIssuerCertificateFromStore")]
        public static extern IntPtr CertGetIssuerCertificateFromStore(IntPtr hCertStore, ref CERT_CONTEXT pSubjectContext, ref CERT_CONTEXT pPrevIssuerContext, ref uint pdwFlags);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pCertInfo: PCERT_INFO->_CERT_INFO*
        ///pbKeyUsage: BYTE*
        ///cbKeyUsage: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertGetIntendedKeyUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetIntendedKeyUsage(uint dwCertEncodingType, ref CERT_INFO pCertInfo, ref byte pbKeyUsage, uint cbKeyUsage);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pUsage: PCERT_ENHKEY_USAGE->_CTL_USAGE*
        ///pcbUsage: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetEnhancedKeyUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetEnhancedKeyUsage(ref CERT_CONTEXT pCertContext, uint dwFlags, ref CERT_ENHKEY_USAGE pUsage, ref uint pcbUsage);


        /// Return Type: BOOL->int
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        ///pvData: void*
        ///pcbData: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetCTLContextProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetCTLContextProperty(ref CTL_CONTEXT pCtlContext, uint dwPropId, IntPtr pvData, ref uint pcbData);


        /// Return Type: PCCRL_CONTEXT->CRL_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///pIssuerContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pPrevCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///pdwFlags: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetCRLFromStore")]
        public static extern IntPtr CertGetCRLFromStore(IntPtr hCertStore, ref CERT_CONTEXT pIssuerContext, ref CRL_CONTEXT pPrevCrlContext, ref uint pdwFlags);


        /// Return Type: BOOL->int
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        ///pvData: void*
        ///pcbData: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetCRLContextProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetCRLContextProperty(ref CRL_CONTEXT pCrlContext, uint dwPropId, IntPtr pvData, ref uint pcbData);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        ///pvData: void*
        ///pcbData: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertGetCertificateContextProperty")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetCertificateContextProperty(ref CERT_CONTEXT pCertContext, uint dwPropId, IntPtr pvData, ref uint pcbData);


        /// Return Type: BOOL->int
        ///hChainEngine: HCERTCHAINENGINE->HANDLE->void*
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pTime: LPFILETIME->_FILETIME*
        ///hAdditionalStore: HCERTSTORE->void*
        ///pChainPara: PCERT_CHAIN_PARA->_CERT_CHAIN_PARA*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: LPVOID->void*
        ///ppChainContext: PCCERT_CHAIN_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertGetCertificateChain")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertGetCertificateChain(IntPtr hChainEngine, ref CERT_CONTEXT pCertContext, ref FILETIME pTime, IntPtr hAdditionalStore, ref CERT_CHAIN_PARA pChainPara, uint dwFlags, IntPtr pvReserved, ref IntPtr ppChainContext);


        /// Return Type: BOOL->int
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFreeCTLContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertFreeCTLContext(ref CTL_CONTEXT pCtlContext);


        /// Return Type: BOOL->int
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFreeCRLContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertFreeCRLContext(ref CRL_CONTEXT pCrlContext);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFreeCertificateContext")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertFreeCertificateContext(ref CERT_CONTEXT pCertContext);


        /// Return Type: void
        ///hChainEngine: HCERTCHAINENGINE->HANDLE->void*
        [DllImport("crypt32.dll", EntryPoint = "CertFreeCertificateChainEngine")]
        public static extern void CertFreeCertificateChainEngine(IntPtr hChainEngine);


        /// Return Type: void
        ///pChainContext: PCCERT_CHAIN_CONTEXT->CERT_CHAIN_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFreeCertificateChain")]
        public static extern void CertFreeCertificateChain(ref CERT_CHAIN_CONTEXT pChainContext);


        /// Return Type: BOOL->int
        ///pSubjectIdentifier: PCRYPT_DATA_BLOB->_CRYPTOAPI_BLOB*
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        ///pEncodedAttributes: PCRYPT_DER_BLOB->_CRYPTOAPI_BLOB*
        [DllImport("crypt32.dll", EntryPoint = "CertFindSubjectInSortedCTL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertFindSubjectInSortedCTL(ref CRYPT_ATTR_BLOB pSubjectIdentifier, ref CTL_CONTEXT pCtlContext, uint dwFlags, IntPtr pvReserved, ref CRYPT_ATTR_BLOB pEncodedAttributes);


        /// Return Type: PCTL_ENTRY->_CTL_ENTRY*
        ///dwEncodingType: DWORD->unsigned int
        ///dwSubjectType: DWORD->unsigned int
        ///pvSubject: void*
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertFindSubjectInCTL")]
        public static extern IntPtr CertFindSubjectInCTL(uint dwEncodingType, uint dwSubjectType, IntPtr pvSubject, ref CTL_CONTEXT pCtlContext, uint dwFlags);


        /// Return Type: PCERT_RDN_ATTR->_CERT_RDN_ATTR*
        ///pszObjId: LPCSTR->CHAR*
        ///pName: PCERT_NAME_INFO->_CERT_NAME_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertFindRDNAttr")]
        public static extern IntPtr CertFindRDNAttr([In] [MarshalAs(UnmanagedType.LPStr)] string pszObjId, ref CERT_NAME_INFO pName);


        /// Return Type: PCERT_EXTENSION->_CERT_EXTENSION*
        ///pszObjId: LPCSTR->CHAR*
        ///cExtensions: DWORD->unsigned int
        ///rgExtensions: CERT_EXTENSION*
        [DllImport("crypt32.dll", EntryPoint = "CertFindExtension")]
        public static extern IntPtr CertFindExtension([In] [MarshalAs(UnmanagedType.LPStr)] string pszObjId, uint cExtensions, ref CERT_EXTENSION rgExtensions);


        /// Return Type: PCCTL_CONTEXT->CTL_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///dwMsgAndCertEncodingType: DWORD->unsigned int
        ///dwFindFlags: DWORD->unsigned int
        ///dwFindType: DWORD->unsigned int
        ///pvFindPara: void*
        ///pPrevCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFindCTLInStore")]
        public static extern IntPtr CertFindCTLInStore(IntPtr hCertStore, uint dwMsgAndCertEncodingType, uint dwFindFlags, uint dwFindType, IntPtr pvFindPara, ref CTL_CONTEXT pPrevCtlContext);


        /// Return Type: PCCRL_CONTEXT->CRL_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///dwCertEncodingType: DWORD->unsigned int
        ///dwFindFlags: DWORD->unsigned int
        ///dwFindType: DWORD->unsigned int
        ///pvFindPara: void*
        ///pPrevCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFindCRLInStore")]
        public static extern IntPtr CertFindCRLInStore(IntPtr hCertStore, uint dwCertEncodingType, uint dwFindFlags, uint dwFindType, IntPtr pvFindPara, ref CRL_CONTEXT pPrevCrlContext);


        /// Return Type: PCCERT_CHAIN_CONTEXT->CERT_CHAIN_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///dwCertEncodingType: DWORD->unsigned int
        ///dwFindFlags: DWORD->unsigned int
        ///dwFindType: DWORD->unsigned int
        ///pvFindPara: void*
        ///pPrevChainContext: PCCERT_CHAIN_CONTEXT->CERT_CHAIN_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFindChainInStore")]
        public static extern IntPtr CertFindChainInStore(IntPtr hCertStore, uint dwCertEncodingType, uint dwFindFlags, uint dwFindType, IntPtr pvFindPara, ref CERT_CHAIN_CONTEXT pPrevChainContext);


        /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///dwCertEncodingType: DWORD->unsigned int
        ///dwFindFlags: DWORD->unsigned int
        ///dwFindType: DWORD->unsigned int
        ///pvFindPara: void*
        ///pPrevCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertFindCertificateInStore")]
        public static extern IntPtr CertFindCertificateInStore(IntPtr hCertStore, uint dwCertEncodingType, uint dwFindFlags, uint dwFindType, IntPtr pvFindPara, ref CERT_CONTEXT pPrevCertContext);


        /// Return Type: BOOL->int
        ///pCert: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        ///ppCrlEntry: PCRL_ENTRY*
        [DllImport("crypt32.dll", EntryPoint = "CertFindCertificateInCRL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertFindCertificateInCRL(ref CERT_CONTEXT pCert, ref CRL_CONTEXT pCrlContext, uint dwFlags, IntPtr pvReserved, ref IntPtr ppCrlEntry);


        /// Return Type: PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        ///pszObjId: LPCSTR->CHAR*
        ///cAttr: DWORD->unsigned int
        ///rgAttr: CRYPT_ATTRIBUTE*
        [DllImport("crypt32.dll", EntryPoint = "CertFindAttribute")]
        public static extern IntPtr CertFindAttribute([In] [MarshalAs(UnmanagedType.LPStr)] string pszObjId, uint cAttr, ref CRYPT_ATTRIBUTE rgAttr);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///pvArg: void*
        ///pfnEnum: PFN_CERT_ENUM_SYSTEM_STORE_LOCATION
        [DllImport("crypt32.dll", EntryPoint = "CertEnumSystemStoreLocation")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertEnumSystemStoreLocation(uint dwFlags, IntPtr pvArg, PFN_CERT_ENUM_SYSTEM_STORE_LOCATION pfnEnum);


        /// Return Type: BOOL->int
        ///dwFlags: DWORD->unsigned int
        ///pvSystemStoreLocationPara: void*
        ///pvArg: void*
        ///pfnEnum: PFN_CERT_ENUM_SYSTEM_STORE
        [DllImport("crypt32.dll", EntryPoint = "CertEnumSystemStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertEnumSystemStore(uint dwFlags, IntPtr pvSystemStoreLocationPara, IntPtr pvArg, PFN_CERT_ENUM_SYSTEM_STORE pfnEnum);


        /// Return Type: BOOL->int
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///ppvNextSubject: void**
        ///pSubjectIdentifier: PCRYPT_DER_BLOB->_CRYPTOAPI_BLOB*
        ///pEncodedAttributes: PCRYPT_DER_BLOB->_CRYPTOAPI_BLOB*
        [DllImport("crypt32.dll", EntryPoint = "CertEnumSubjectInSortedCTL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertEnumSubjectInSortedCTL(ref CTL_CONTEXT pCtlContext, ref IntPtr ppvNextSubject, ref CRYPT_ATTR_BLOB pSubjectIdentifier, ref CRYPT_ATTR_BLOB pEncodedAttributes);


        /// Return Type: BOOL->int
        ///pvSystemStore: void*
        ///dwFlags: DWORD->unsigned int
        ///pvArg: void*
        ///pfnEnum: PFN_CERT_ENUM_PHYSICAL_STORE
        [DllImport("crypt32.dll", EntryPoint = "CertEnumPhysicalStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertEnumPhysicalStore(IntPtr pvSystemStore, uint dwFlags, IntPtr pvArg, PFN_CERT_ENUM_PHYSICAL_STORE pfnEnum);


        /// Return Type: PCCTL_CONTEXT->CTL_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///pPrevCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertEnumCTLsInStore")]
        public static extern IntPtr CertEnumCTLsInStore(IntPtr hCertStore, ref CTL_CONTEXT pPrevCtlContext);


        /// Return Type: DWORD->unsigned int
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertEnumCTLContextProperties")]
        public static extern uint CertEnumCTLContextProperties(ref CTL_CONTEXT pCtlContext, uint dwPropId);


        /// Return Type: PCCRL_CONTEXT->CRL_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///pPrevCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertEnumCRLsInStore")]
        public static extern IntPtr CertEnumCRLsInStore(IntPtr hCertStore, ref CRL_CONTEXT pPrevCrlContext);


        /// Return Type: DWORD->unsigned int
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertEnumCRLContextProperties")]
        public static extern uint CertEnumCRLContextProperties(ref CRL_CONTEXT pCrlContext, uint dwPropId);


        /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
        ///hCertStore: HCERTSTORE->void*
        ///pPrevCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertEnumCertificatesInStore")]
        public static extern IntPtr CertEnumCertificatesInStore(IntPtr hCertStore, ref CERT_CONTEXT pPrevCertContext);


        /// Return Type: DWORD->unsigned int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwPropId: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertEnumCertificateContextProperties")]
        public static extern uint CertEnumCertificateContextProperties(ref CERT_CONTEXT pCertContext, uint dwPropId);


        /// Return Type: HCERTSTORE->void*
        ///hCertStore: HCERTSTORE->void*
        [DllImport("crypt32.dll", EntryPoint = "CertDuplicateStore")]
        public static extern IntPtr CertDuplicateStore(IntPtr hCertStore);


        /// Return Type: PCCTL_CONTEXT->CTL_CONTEXT*
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertDuplicateCTLContext")]
        public static extern IntPtr CertDuplicateCTLContext(ref CTL_CONTEXT pCtlContext);


        /// Return Type: PCCRL_CONTEXT->CRL_CONTEXT*
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertDuplicateCRLContext")]
        public static extern IntPtr CertDuplicateCRLContext(ref CRL_CONTEXT pCrlContext);


        /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertDuplicateCertificateContext")]
        public static extern IntPtr CertDuplicateCertificateContext(ref CERT_CONTEXT pCertContext);


        /// Return Type: PCCERT_CHAIN_CONTEXT->CERT_CHAIN_CONTEXT*
        ///pChainContext: PCCERT_CHAIN_CONTEXT->CERT_CHAIN_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertDuplicateCertificateChain")]
        public static extern IntPtr CertDuplicateCertificateChain(ref CERT_CHAIN_CONTEXT pChainContext);


        /// Return Type: BOOL->int
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertDeleteCTLFromStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertDeleteCTLFromStore(ref CTL_CONTEXT pCtlContext);


        /// Return Type: BOOL->int
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertDeleteCRLFromStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertDeleteCRLFromStore(ref CRL_CONTEXT pCrlContext);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertDeleteCertificateFromStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertDeleteCertificateFromStore(ref CERT_CONTEXT pCertContext);


        /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
        ///hProv: HCRYPTPROV->ULONG_PTR->unsigned int
        ///pSubjectIssuerBlob: PCERT_NAME_BLOB->_CRYPTOAPI_BLOB*
        ///dwFlags: DWORD->unsigned int
        ///pKeyProvInfo: PCRYPT_KEY_PROV_INFO->_CRYPT_KEY_PROV_INFO*
        ///pSignatureAlgorithm: PCRYPT_ALGORITHM_IDENTIFIER->_CRYPT_ALGORITHM_IDENTIFIER*
        ///pStartTime: PSYSTEMTIME->_SYSTEMTIME*
        ///pEndTime: PSYSTEMTIME->_SYSTEMTIME*
        ///pExtensions: PCERT_EXTENSIONS->_CERT_EXTENSIONS*
        [DllImport("crypt32.dll", EntryPoint = "CertCreateSelfSignCertificate")]
        public static extern IntPtr CertCreateSelfSignCertificate(uint hProv, ref CRYPT_ATTR_BLOB pSubjectIssuerBlob, uint dwFlags, ref CRYPT_KEY_PROV_INFO pKeyProvInfo, ref CRYPT_ALGORITHM_IDENTIFIER pSignatureAlgorithm, ref SYSTEMTIME pStartTime, ref SYSTEMTIME pEndTime, ref CERT_EXTENSIONS pExtensions);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///cOptAttr: DWORD->unsigned int
        ///rgOptAttr: PCRYPT_ATTRIBUTE->_CRYPT_ATTRIBUTE*
        ///dwFlags: DWORD->unsigned int
        ///pvReserved: void*
        ///pCtlEntry: PCTL_ENTRY->_CTL_ENTRY*
        ///pcbCtlEntry: DWORD*
        [DllImport("crypt32.dll", EntryPoint = "CertCreateCTLEntryFromCertificateContextProperties")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertCreateCTLEntryFromCertificateContextProperties(ref CERT_CONTEXT pCertContext, uint cOptAttr, ref CRYPT_ATTRIBUTE rgOptAttr, uint dwFlags, IntPtr pvReserved, ref CTL_ENTRY pCtlEntry, ref uint pcbCtlEntry);


        /// Return Type: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwMsgAndCertEncodingType: DWORD->unsigned int
        ///pbCtlEncoded: BYTE*
        ///cbCtlEncoded: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertCreateCTLContext")]
        public static extern IntPtr CertCreateCTLContext(uint dwMsgAndCertEncodingType, ref byte pbCtlEncoded, uint cbCtlEncoded);


        /// Return Type: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwCertEncodingType: DWORD->unsigned int
        ///pbCrlEncoded: BYTE*
        ///cbCrlEncoded: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertCreateCRLContext")]
        public static extern IntPtr CertCreateCRLContext(uint dwCertEncodingType, ref byte pbCrlEncoded, uint cbCrlEncoded);


        /// Return Type: void*
        ///dwContextType: DWORD->unsigned int
        ///dwEncodingType: DWORD->unsigned int
        ///pbEncoded: BYTE*
        ///cbEncoded: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///pCreatePara: PCERT_CREATE_CONTEXT_PARA->_CERT_CREATE_CONTEXT_PARA*
        [DllImport("crypt32.dll", EntryPoint = "CertCreateContext")]
        public static extern IntPtr CertCreateContext(uint dwContextType, uint dwEncodingType, ref byte pbEncoded, uint cbEncoded, uint dwFlags, ref CERT_CREATE_CONTEXT_PARA pCreatePara);


        /// Return Type: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwCertEncodingType: DWORD->unsigned int
        ///pbCertEncoded: BYTE*
        ///cbCertEncoded: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertCreateCertificateContext")]
        public static extern IntPtr CertCreateCertificateContext(uint dwCertEncodingType, ref byte pbCertEncoded, uint cbCertEncoded);


        /// Return Type: BOOL->int
        ///pConfig: PCERT_CHAIN_ENGINE_CONFIG->_CERT_CHAIN_ENGINE_CONFIG*
        ///phChainEngine: HCERTCHAINENGINE*
        [DllImport("crypt32.dll", EntryPoint = "CertCreateCertificateChainEngine")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertCreateCertificateChainEngine(ref CERT_CHAIN_ENGINE_CONFIG pConfig, ref IntPtr phChainEngine);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwFlags: DWORD->unsigned int
        ///dwCtrlType: DWORD->unsigned int
        ///pvCtrlPara: void*
        [DllImport("crypt32.dll", EntryPoint = "CertControlStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertControlStore(IntPtr hCertStore, uint dwFlags, uint dwCtrlType, IntPtr pvCtrlPara);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pPublicKey1: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        ///pPublicKey2: PCERT_PUBLIC_KEY_INFO->_CERT_PUBLIC_KEY_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertComparePublicKeyInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertComparePublicKeyInfo(uint dwCertEncodingType, ref CERT_PUBLIC_KEY_INFO pPublicKey1, ref CERT_PUBLIC_KEY_INFO pPublicKey2);


        /// Return Type: BOOL->int
        ///pInt1: PCRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB*
        ///pInt2: PCRYPT_INTEGER_BLOB->_CRYPTOAPI_BLOB*
        [DllImport("crypt32.dll", EntryPoint = "CertCompareIntegerBlob")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertCompareIntegerBlob(ref CRYPT_ATTR_BLOB pInt1, ref CRYPT_ATTR_BLOB pInt2);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pCertName1: PCERT_NAME_BLOB->_CRYPTOAPI_BLOB*
        ///pCertName2: PCERT_NAME_BLOB->_CRYPTOAPI_BLOB*
        [DllImport("crypt32.dll", EntryPoint = "CertCompareCertificateName")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertCompareCertificateName(uint dwCertEncodingType, ref CRYPT_ATTR_BLOB pCertName1, ref CRYPT_ATTR_BLOB pCertName2);


        /// Return Type: BOOL->int
        ///dwCertEncodingType: DWORD->unsigned int
        ///pCertId1: PCERT_INFO->_CERT_INFO*
        ///pCertId2: PCERT_INFO->_CERT_INFO*
        [DllImport("crypt32.dll", EntryPoint = "CertCompareCertificate")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertCompareCertificate(uint dwCertEncodingType, ref CERT_INFO pCertId1, ref CERT_INFO pCertId2);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwFlags: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertCloseStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertCloseStore(IntPtr hCertStore, uint dwFlags);


        /// Return Type: LPCSTR->CHAR*
        ///dwAlgId: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertAlgIdToOID")]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern string CertAlgIdToOID(uint dwAlgId);


        /// Return Type: BOOL->int
        ///hCollectionStore: HCERTSTORE->void*
        ///hSiblingStore: HCERTSTORE->void*
        ///dwUpdateFlags: DWORD->unsigned int
        ///dwPriority: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertAddStoreToCollection")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddStoreToCollection(IntPtr hCollectionStore, IntPtr hSiblingStore, uint dwUpdateFlags, uint dwPriority);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///pbElement: BYTE*
        ///cbElement: DWORD->unsigned int
        ///dwAddDisposition: DWORD->unsigned int
        ///dwFlags: DWORD->unsigned int
        ///dwContextTypeFlags: DWORD->unsigned int
        ///pdwContextType: DWORD*
        ///ppvContext: void**
        [DllImport("crypt32.dll", EntryPoint = "CertAddSerializedElementToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddSerializedElementToStore(IntPtr hCertStore, ref byte pbElement, uint cbElement, uint dwAddDisposition, uint dwFlags, uint dwContextTypeFlags, ref uint pdwContextType, ref IntPtr ppvContext);


        /// Return Type: BOOL->int
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///pszUsageIdentifier: LPCSTR->CHAR*
        [DllImport("crypt32.dll", EntryPoint = "CertAddEnhancedKeyUsageIdentifier")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddEnhancedKeyUsageIdentifier(ref CERT_CONTEXT pCertContext, [In] [MarshalAs(UnmanagedType.LPStr)] string pszUsageIdentifier);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwMsgAndCertEncodingType: DWORD->unsigned int
        ///pbCtlEncoded: BYTE*
        ///cbCtlEncoded: DWORD->unsigned int
        ///dwAddDisposition: DWORD->unsigned int
        ///ppCtlContext: PCCTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddEncodedCTLToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddEncodedCTLToStore(IntPtr hCertStore, uint dwMsgAndCertEncodingType, ref byte pbCtlEncoded, uint cbCtlEncoded, uint dwAddDisposition, ref IntPtr ppCtlContext);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwCertEncodingType: DWORD->unsigned int
        ///pbCrlEncoded: BYTE*
        ///cbCrlEncoded: DWORD->unsigned int
        ///dwAddDisposition: DWORD->unsigned int
        ///ppCrlContext: PCCRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddEncodedCRLToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddEncodedCRLToStore(IntPtr hCertStore, uint dwCertEncodingType, ref byte pbCrlEncoded, uint cbCrlEncoded, uint dwAddDisposition, ref IntPtr ppCrlContext);


        /// Return Type: BOOL->int
        ///szCertStoreName: LPCWSTR->WCHAR*
        ///pbCertEncoded: BYTE*
        ///cbCertEncoded: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertAddEncodedCertificateToSystemStoreW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddEncodedCertificateToSystemStoreW([In] [MarshalAs(UnmanagedType.LPWStr)] string szCertStoreName, ref byte pbCertEncoded, uint cbCertEncoded);


        /// Return Type: BOOL->int
        ///szCertStoreName: LPCSTR->CHAR*
        ///pbCertEncoded: BYTE*
        ///cbCertEncoded: DWORD->unsigned int
        [DllImport("crypt32.dll", EntryPoint = "CertAddEncodedCertificateToSystemStoreA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddEncodedCertificateToSystemStoreA([In] [MarshalAs(UnmanagedType.LPStr)] string szCertStoreName, ref byte pbCertEncoded, uint cbCertEncoded);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///dwCertEncodingType: DWORD->unsigned int
        ///pbCertEncoded: BYTE*
        ///cbCertEncoded: DWORD->unsigned int
        ///dwAddDisposition: DWORD->unsigned int
        ///ppCertContext: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddEncodedCertificateToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddEncodedCertificateToStore(IntPtr hCertStore, uint dwCertEncodingType, ref byte pbCertEncoded, uint cbCertEncoded, uint dwAddDisposition, ref IntPtr ppCertContext);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwAddDisposition: DWORD->unsigned int
        ///ppStoreContext: PCCTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddCTLLinkToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddCTLLinkToStore(IntPtr hCertStore, ref CTL_CONTEXT pCtlContext, uint dwAddDisposition, ref IntPtr ppStoreContext);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///pCtlContext: PCCTL_CONTEXT->CTL_CONTEXT*
        ///dwAddDisposition: DWORD->unsigned int
        ///ppStoreContext: PCCTL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddCTLContextToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddCTLContextToStore(IntPtr hCertStore, ref CTL_CONTEXT pCtlContext, uint dwAddDisposition, ref IntPtr ppStoreContext);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwAddDisposition: DWORD->unsigned int
        ///ppStoreContext: PCCRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddCRLLinkToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddCRLLinkToStore(IntPtr hCertStore, ref CRL_CONTEXT pCrlContext, uint dwAddDisposition, ref IntPtr ppStoreContext);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///pCrlContext: PCCRL_CONTEXT->CRL_CONTEXT*
        ///dwAddDisposition: DWORD->unsigned int
        ///ppStoreContext: PCCRL_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddCRLContextToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddCRLContextToStore(IntPtr hCertStore, ref CRL_CONTEXT pCrlContext, uint dwAddDisposition, ref IntPtr ppStoreContext);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwAddDisposition: DWORD->unsigned int
        ///ppStoreContext: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddCertificateLinkToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddCertificateLinkToStore(IntPtr hCertStore, ref CERT_CONTEXT pCertContext, uint dwAddDisposition, ref IntPtr ppStoreContext);


        /// Return Type: BOOL->int
        ///hCertStore: HCERTSTORE->void*
        ///pCertContext: PCCERT_CONTEXT->CERT_CONTEXT*
        ///dwAddDisposition: DWORD->unsigned int
        ///ppStoreContext: PCCERT_CONTEXT*
        [DllImport("crypt32.dll", EntryPoint = "CertAddCertificateContextToStore")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CertAddCertificateContextToStore(IntPtr hCertStore, ref CERT_CONTEXT pCertContext, uint dwAddDisposition, ref IntPtr ppStoreContext);


        /// Return Type: WORD->unsigned short
        ///hwndParent: HWND->HWND__*
        ///wHow: UINT->unsigned int
        ///lpRect: RECT*
        ///cKids: UINT->unsigned int
        ///lpKids: HWND*
        [DllImport("user32.dll", EntryPoint = "CascadeWindows")]
        public static extern ushort CascadeWindows([In] IntPtr hwndParent, uint wHow, [In] IntPtr lpRect, uint cKids, ref IntPtr lpKids);


        /// Return Type: BOOL->int
        ///hTimer: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelWaitableTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelWaitableTimer([In] IntPtr hTimer);


        /// Return Type: BOOL->int
        ///TimerQueue: HANDLE->void*
        ///Timer: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelTimerQueueTimer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelTimerQueueTimer([In] IntPtr TimerQueue, [In] IntPtr Timer);


        /// Return Type: BOOL->int
        ///hFile: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelIo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelIo([In] IntPtr hFile);


        /// Return Type: BOOL->int
        ///hDevice: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "CancelDeviceWakeupRequest")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelDeviceWakeupRequest([In] IntPtr hDevice);


        /// Return Type: BOOL->int
        ///hdc: HDC->HDC__*
        [DllImport("gdi32.dll", EntryPoint = "CancelDC")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelDC([In] IntPtr hdc);


        /// Return Type: LRESULT->LONG_PTR->int
        ///lpPrevWndFunc: WNDPROC
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CallWindowProcW")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr CallWindowProcW(WNDPROC lpPrevWndFunc, [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: LRESULT->LONG_PTR->int
        ///lpPrevWndFunc: WNDPROC
        ///hWnd: HWND->HWND__*
        ///Msg: UINT->unsigned int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CallWindowProcA")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr CallWindowProcA(WNDPROC lpPrevWndFunc, [In] IntPtr hWnd, uint Msg, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: void*
        ///_NumOfElements: size_t->unsigned int
        ///_SizeOfElements: size_t->unsigned int
        [DllImport("msvcr80.dll", EntryPoint = "calloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr calloc([MarshalAs(UnmanagedType.SysUInt)] UIntPtr _NumOfElements, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr _SizeOfElements);


        /// Return Type: LRESULT->LONG_PTR->int
        ///hhk: HHOOK->HHOOK__*
        ///nCode: int
        ///wParam: WPARAM->UINT_PTR->unsigned int
        ///lParam: LPARAM->LONG_PTR->int
        [DllImport("user32.dll", EntryPoint = "CallNextHookEx")]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr CallNextHookEx([In] IntPtr hhk, int nCode, [MarshalAs(UnmanagedType.SysUInt)] UIntPtr wParam, [MarshalAs(UnmanagedType.SysInt)] IntPtr lParam);


        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCWSTR->WCHAR*
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CallNamedPipeW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallNamedPipeW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpNamedPipeName, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, [Out] out uint lpBytesRead, uint nTimeOut);


        /// Return Type: BOOL->int
        ///lpNamedPipeName: LPCSTR->CHAR*
        ///lpInBuffer: LPVOID->void*
        ///nInBufferSize: DWORD->unsigned int
        ///lpOutBuffer: LPVOID->void*
        ///nOutBufferSize: DWORD->unsigned int
        ///lpBytesRead: LPDWORD->DWORD*
        ///nTimeOut: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "CallNamedPipeA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallNamedPipeA([In] [MarshalAs(UnmanagedType.LPStr)] string lpNamedPipeName, [In] IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, [Out] out uint lpBytesRead, uint nTimeOut);


        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///nCode: int
        [DllImport("user32.dll", EntryPoint = "CallMsgFilterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallMsgFilterW([In] ref tagMSG lpMsg, int nCode);


        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///nCode: int
        [DllImport("user32.dll", EntryPoint = "CallMsgFilterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallMsgFilterA([In] ref tagMSG lpMsg, int nCode);

    }

}
