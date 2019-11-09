using NWin32.NativeTypes;

namespace NWin32
{
    public partial class NativeConstants
    {

        /// S_WHITEVOICE -> 7
        public const int S_WHITEVOICE = 7;

        /// S_WHITE512 -> 4
        public const int S_WHITE512 = 4;

        /// S_WHITE2048 -> 6
        public const int S_WHITE2048 = 6;

        /// S_WHITE1024 -> 5
        public const int S_WHITE1024 = 5;

        /// S_THRESHOLD -> 1
        public const int S_THRESHOLD = 1;

        /// S_STACCATO -> 2
        public const int S_STACCATO = 2;

        /// S_SERQFUL -> (-4)
        public const int S_SERQFUL = -4;

        /// S_SEROFM -> (-2)
        public const int S_SEROFM = -2;

        /// S_SERMACT -> (-3)
        public const int S_SERMACT = -3;

        /// S_SERDVNA -> (-1)
        public const int S_SERDVNA = -1;

        /// S_SERDVL -> (-9)
        public const int S_SERDVL = -9;

        /// S_SERDTP -> (-8)
        public const int S_SERDTP = -8;

        /// S_SERDST -> (-16)
        public const int S_SERDST = -16;

        /// S_SERDSR -> (-15)
        public const int S_SERDSR = -15;

        /// S_SERDSH -> (-11)
        public const int S_SERDSH = -11;

        /// S_SERDPT -> (-12)
        public const int S_SERDPT = -12;

        /// S_SERDMD -> (-10)
        public const int S_SERDMD = -10;

        /// S_SERDLN -> (-6)
        public const int S_SERDLN = -6;

        /// S_SERDFQ -> (-13)
        public const int S_SERDFQ = -13;

        /// S_SERDDR -> (-14)
        public const int S_SERDDR = -14;

        /// S_SERDCC -> (-7)
        public const int S_SERDCC = -7;

        /// S_SERBDNT -> (-5)
        public const int S_SERBDNT = -5;

        /// S_QUEUEEMPTY -> 0
        public const int S_QUEUEEMPTY = 0;

        /// S_PERIODVOICE -> 3
        public const int S_PERIODVOICE = 3;

        /// S_PERIOD512 -> 0
        public const int S_PERIOD512 = 0;

        /// S_PERIOD2048 -> 2
        public const int S_PERIOD2048 = 2;

        /// S_PERIOD1024 -> 1
        public const int S_PERIOD1024 = 1;

        /// S_NORMAL -> 0
        public const int S_NORMAL = 0;

        /// S_LEGATO -> 1
        public const int S_LEGATO = 1;

        /// S_ASYNCHRONOUS -> MK_S_ASYNCHRONOUS
        public const string S_ASYNCHRONOUS = NativeConstants.MK_S_ASYNCHRONOUS;

        /// S_ALLTHRESHOLD -> 2
        public const int S_ALLTHRESHOLD = 2;

        /// sz_CERT_STORE_PROV_SYSTEM_W -> "System"
        public const string sz_CERT_STORE_PROV_SYSTEM_W = "System";

        /// sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W -> "SystemRegistry"
        public const string sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W = "SystemRegistry";

        /// sz_CERT_STORE_PROV_SYSTEM_REGISTRY -> sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W
        public const string sz_CERT_STORE_PROV_SYSTEM_REGISTRY = NativeConstants.sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W;

        /// sz_CERT_STORE_PROV_SYSTEM -> sz_CERT_STORE_PROV_SYSTEM_W
        public const string sz_CERT_STORE_PROV_SYSTEM = NativeConstants.sz_CERT_STORE_PROV_SYSTEM_W;

        /// sz_CERT_STORE_PROV_SMART_CARD_W -> "SmartCard"
        public const string sz_CERT_STORE_PROV_SMART_CARD_W = "SmartCard";

        /// sz_CERT_STORE_PROV_SMART_CARD -> sz_CERT_STORE_PROV_SMART_CARD_W
        public const string sz_CERT_STORE_PROV_SMART_CARD = NativeConstants.sz_CERT_STORE_PROV_SMART_CARD_W;

        /// sz_CERT_STORE_PROV_SERIALIZED -> "Serialized"
        public const string sz_CERT_STORE_PROV_SERIALIZED = "Serialized";

        /// sz_CERT_STORE_PROV_PKCS7 -> "PKCS7"
        public const string sz_CERT_STORE_PROV_PKCS7 = "PKCS7";

        /// sz_CERT_STORE_PROV_PHYSICAL_W -> "Physical"
        public const string sz_CERT_STORE_PROV_PHYSICAL_W = "Physical";

        /// sz_CERT_STORE_PROV_PHYSICAL -> sz_CERT_STORE_PROV_PHYSICAL_W
        public const string sz_CERT_STORE_PROV_PHYSICAL = NativeConstants.sz_CERT_STORE_PROV_PHYSICAL_W;

        /// sz_CERT_STORE_PROV_MEMORY -> "Memory"
        public const string sz_CERT_STORE_PROV_MEMORY = "Memory";

        /// sz_CERT_STORE_PROV_LDAP_W -> "Ldap"
        public const string sz_CERT_STORE_PROV_LDAP_W = "Ldap";

        /// sz_CERT_STORE_PROV_LDAP -> sz_CERT_STORE_PROV_LDAP_W
        public const string sz_CERT_STORE_PROV_LDAP = NativeConstants.sz_CERT_STORE_PROV_LDAP_W;

        /// sz_CERT_STORE_PROV_FILENAME_W -> "File"
        public const string sz_CERT_STORE_PROV_FILENAME_W = "File";

        /// sz_CERT_STORE_PROV_FILENAME -> sz_CERT_STORE_PROV_FILENAME_W
        public const string sz_CERT_STORE_PROV_FILENAME = NativeConstants.sz_CERT_STORE_PROV_FILENAME_W;

        /// sz_CERT_STORE_PROV_COLLECTION -> "Collection"
        public const string sz_CERT_STORE_PROV_COLLECTION = "Collection";

        /// szPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS -> "PrivKeyCachePurgeIntervalSeconds"
        public const string szPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS = "PrivKeyCachePurgeIntervalSeconds";

        /// szPRIV_KEY_CACHE_MAX_ITEMS -> "PrivKeyCacheMaxItems"
        public const string szPRIV_KEY_CACHE_MAX_ITEMS = "PrivKeyCacheMaxItems";

        /// szOID_YESNO_TRUST_ATTR -> "1.3.6.1.4.1.311.10.4.1"
        public const string szOID_YESNO_TRUST_ATTR = "1.3.6.1.4.1.311.10.4.1";

        /// szOID_X957_SHA1DSA -> "1.2.840.10040.4.3"
        public const string szOID_X957_SHA1DSA = "1.2.840.10040.4.3";

        /// szOID_X957_DSA -> "1.2.840.10040.4.1"
        public const string szOID_X957_DSA = "1.2.840.10040.4.1";

        /// szOID_X957 -> "1.2.840.10040"
        public const string szOID_X957 = "1.2.840.10040";

        /// szOID_X21_ADDRESS -> "2.5.4.24"
        public const string szOID_X21_ADDRESS = "2.5.4.24";

        /// szOID_WHQL_CRYPTO -> "1.3.6.1.4.1.311.10.3.5"
        public const string szOID_WHQL_CRYPTO = "1.3.6.1.4.1.311.10.3.5";

        /// szOID_VERISIGN_PRIVATE_6_9 -> "2.16.840.1.113733.1.6.9"
        public const string szOID_VERISIGN_PRIVATE_6_9 = "2.16.840.1.113733.1.6.9";

        /// szOID_VERISIGN_ONSITE_JURISDICTION_HASH -> "2.16.840.1.113733.1.6.11"
        public const string szOID_VERISIGN_ONSITE_JURISDICTION_HASH = "2.16.840.1.113733.1.6.11";

        /// szOID_VERISIGN_ISS_STRONG_CRYPTO -> "2.16.840.1.113733.1.8.1"
        public const string szOID_VERISIGN_ISS_STRONG_CRYPTO = "2.16.840.1.113733.1.8.1";

        /// szOID_VERISIGN_BITSTRING_6_13 -> "2.16.840.1.113733.1.6.13"
        public const string szOID_VERISIGN_BITSTRING_6_13 = "2.16.840.1.113733.1.6.13";

        /// szOID_USER_PASSWORD -> "2.5.4.35"
        public const string szOID_USER_PASSWORD = "2.5.4.35";

        /// szOID_USER_CERTIFICATE -> "2.5.4.36"
        public const string szOID_USER_CERTIFICATE = "2.5.4.36";

        /// szOID_TITLE -> "2.5.4.12"
        public const string szOID_TITLE = "2.5.4.12";

        /// szOID_TELEX_NUMBER -> "2.5.4.21"
        public const string szOID_TELEX_NUMBER = "2.5.4.21";

        /// szOID_TELETEXT_TERMINAL_IDENTIFIER -> "2.5.4.22"
        public const string szOID_TELETEXT_TERMINAL_IDENTIFIER = "2.5.4.22";

        /// szOID_TELEPHONE_NUMBER -> "2.5.4.20"
        public const string szOID_TELEPHONE_NUMBER = "2.5.4.20";

        /// szOID_SUR_NAME -> "2.5.4.4"
        public const string szOID_SUR_NAME = "2.5.4.4";

        /// szOID_SUPPORTED_APPLICATION_CONTEXT -> "2.5.4.30"
        public const string szOID_SUPPORTED_APPLICATION_CONTEXT = "2.5.4.30";

        /// szOID_SUBJECT_KEY_IDENTIFIER -> "2.5.29.14"
        public const string szOID_SUBJECT_KEY_IDENTIFIER = "2.5.29.14";

        /// szOID_SUBJECT_DIR_ATTRS -> "2.5.29.9"
        public const string szOID_SUBJECT_DIR_ATTRS = "2.5.29.9";

        /// szOID_SUBJECT_ALT_NAME2 -> "2.5.29.17"
        public const string szOID_SUBJECT_ALT_NAME2 = "2.5.29.17";

        /// szOID_SUBJECT_ALT_NAME -> "2.5.29.7"
        public const string szOID_SUBJECT_ALT_NAME = "2.5.29.7";

        /// szOID_STREET_ADDRESS -> "2.5.4.9"
        public const string szOID_STREET_ADDRESS = "2.5.4.9";

        /// szOID_STATE_OR_PROVINCE_NAME -> "2.5.4.8"
        public const string szOID_STATE_OR_PROVINCE_NAME = "2.5.4.8";

        /// szOID_SORTED_CTL -> "1.3.6.1.4.1.311.10.1.1"
        public const string szOID_SORTED_CTL = "1.3.6.1.4.1.311.10.1.1";

        /// szOID_SGC_NETSCAPE -> "2.16.840.1.113730.4.1"
        public const string szOID_SGC_NETSCAPE = "2.16.840.1.113730.4.1";

        /// szOID_SERVER_GATED_CRYPTO -> "1.3.6.1.4.1.311.10.3.3"
        public const string szOID_SERVER_GATED_CRYPTO = "1.3.6.1.4.1.311.10.3.3";

        /// szOID_SERIALIZED -> "1.3.6.1.4.1.311.10.3.3.1"
        public const string szOID_SERIALIZED = "1.3.6.1.4.1.311.10.3.3.1";

        /// szOID_SEE_ALSO -> "2.5.4.34"
        public const string szOID_SEE_ALSO = "2.5.4.34";

        /// szOID_SEARCH_GUIDE -> "2.5.4.14"
        public const string szOID_SEARCH_GUIDE = "2.5.4.14";

        /// szOID_RSA_unstructName -> "1.2.840.113549.1.9.2"
        public const string szOID_RSA_unstructName = "1.2.840.113549.1.9.2";

        /// szOID_RSA_unstructAddr -> "1.2.840.113549.1.9.8"
        public const string szOID_RSA_unstructAddr = "1.2.840.113549.1.9.8";

        /// szOID_RSA_SMIMECapabilities -> "1.2.840.113549.1.9.15"
        public const string szOID_RSA_SMIMECapabilities = "1.2.840.113549.1.9.15";

        /// szOID_RSA_SMIMEalgESDH -> "1.2.840.113549.1.9.16.3.5"
        public const string szOID_RSA_SMIMEalgESDH = "1.2.840.113549.1.9.16.3.5";

        /// szOID_RSA_SMIMEalgCMSRC2wrap -> "1.2.840.113549.1.9.16.3.7"
        public const string szOID_RSA_SMIMEalgCMSRC2wrap = "1.2.840.113549.1.9.16.3.7";

        /// szOID_RSA_SMIMEalgCMS3DESwrap -> "1.2.840.113549.1.9.16.3.6"
        public const string szOID_RSA_SMIMEalgCMS3DESwrap = "1.2.840.113549.1.9.16.3.6";

        /// szOID_RSA_SMIMEalg -> "1.2.840.113549.1.9.16.3"
        public const string szOID_RSA_SMIMEalg = "1.2.840.113549.1.9.16.3";

        /// szOID_RSA_signingTime -> "1.2.840.113549.1.9.5"
        public const string szOID_RSA_signingTime = "1.2.840.113549.1.9.5";

        /// szOID_RSA_signEnvData -> "1.2.840.113549.1.7.4"
        public const string szOID_RSA_signEnvData = "1.2.840.113549.1.7.4";

        /// szOID_RSA_signedData -> "1.2.840.113549.1.7.2"
        public const string szOID_RSA_signedData = "1.2.840.113549.1.7.2";

        /// szOID_RSA_SHA1RSA -> "1.2.840.113549.1.1.5"
        public const string szOID_RSA_SHA1RSA = "1.2.840.113549.1.1.5";

        /// szOID_RSA_SETOAEP_RSA -> "1.2.840.113549.1.1.6"
        public const string szOID_RSA_SETOAEP_RSA = "1.2.840.113549.1.1.6";

        /// szOID_RSA_RSA -> "1.2.840.113549.1.1.1"
        public const string szOID_RSA_RSA = "1.2.840.113549.1.1.1";

        /// szOID_RSA_RC5_CBCPad -> "1.2.840.113549.3.9"
        public const string szOID_RSA_RC5_CBCPad = "1.2.840.113549.3.9";

        /// szOID_RSA_RC4 -> "1.2.840.113549.3.4"
        public const string szOID_RSA_RC4 = "1.2.840.113549.3.4";

        /// szOID_RSA_RC2CBC -> "1.2.840.113549.3.2"
        public const string szOID_RSA_RC2CBC = "1.2.840.113549.3.2";

        /// szOID_RSA_preferSignedData -> "1.2.840.113549.1.9.15.1"
        public const string szOID_RSA_preferSignedData = "1.2.840.113549.1.9.15.1";

        /// szOID_RSA_messageDigest -> "1.2.840.113549.1.9.4"
        public const string szOID_RSA_messageDigest = "1.2.840.113549.1.9.4";

        /// szOID_RSA_MD5RSA -> "1.2.840.113549.1.1.4"
        public const string szOID_RSA_MD5RSA = "1.2.840.113549.1.1.4";

        /// szOID_RSA_MD5 -> "1.2.840.113549.2.5"
        public const string szOID_RSA_MD5 = "1.2.840.113549.2.5";

        /// szOID_RSA_MD4RSA -> "1.2.840.113549.1.1.3"
        public const string szOID_RSA_MD4RSA = "1.2.840.113549.1.1.3";

        /// szOID_RSA_MD4 -> "1.2.840.113549.2.4"
        public const string szOID_RSA_MD4 = "1.2.840.113549.2.4";

        /// szOID_RSA_MD2RSA -> "1.2.840.113549.1.1.2"
        public const string szOID_RSA_MD2RSA = "1.2.840.113549.1.1.2";

        /// szOID_RSA_MD2 -> "1.2.840.113549.2.2"
        public const string szOID_RSA_MD2 = "1.2.840.113549.2.2";

        /// szOID_RSA_hashedData -> "1.2.840.113549.1.7.5"
        public const string szOID_RSA_hashedData = "1.2.840.113549.1.7.5";

        /// szOID_RSA_HASH -> "1.2.840.113549.2"
        public const string szOID_RSA_HASH = "1.2.840.113549.2";

        /// szOID_RSA_extCertAttrs -> "1.2.840.113549.1.9.9"
        public const string szOID_RSA_extCertAttrs = "1.2.840.113549.1.9.9";

        /// szOID_RSA_envelopedData -> "1.2.840.113549.1.7.3"
        public const string szOID_RSA_envelopedData = "1.2.840.113549.1.7.3";

        /// szOID_RSA_encryptedData -> "1.2.840.113549.1.7.6"
        public const string szOID_RSA_encryptedData = "1.2.840.113549.1.7.6";

        /// szOID_RSA_ENCRYPT -> "1.2.840.113549.3"
        public const string szOID_RSA_ENCRYPT = "1.2.840.113549.3";

        /// szOID_RSA_emailAddr -> "1.2.840.113549.1.9.1"
        public const string szOID_RSA_emailAddr = "1.2.840.113549.1.9.1";

        /// szOID_RSA_digestedData -> "1.2.840.113549.1.7.5"
        public const string szOID_RSA_digestedData = "1.2.840.113549.1.7.5";

        /// szOID_RSA_DH -> "1.2.840.113549.1.3.1"
        public const string szOID_RSA_DH = "1.2.840.113549.1.3.1";

        /// szOID_RSA_DES_EDE3_CBC -> "1.2.840.113549.3.7"
        public const string szOID_RSA_DES_EDE3_CBC = "1.2.840.113549.3.7";

        /// szOID_RSA_data -> "1.2.840.113549.1.7.1"
        public const string szOID_RSA_data = "1.2.840.113549.1.7.1";

        /// szOID_RSA_counterSign -> "1.2.840.113549.1.9.6"
        public const string szOID_RSA_counterSign = "1.2.840.113549.1.9.6";

        /// szOID_RSA_contentType -> "1.2.840.113549.1.9.3"
        public const string szOID_RSA_contentType = "1.2.840.113549.1.9.3";

        /// szOID_RSA_challengePwd -> "1.2.840.113549.1.9.7"
        public const string szOID_RSA_challengePwd = "1.2.840.113549.1.9.7";

        /// szOID_RSA_certExtensions -> "1.2.840.113549.1.9.14"
        public const string szOID_RSA_certExtensions = "1.2.840.113549.1.9.14";

        /// szOID_RSA -> "1.2.840.113549"
        public const string szOID_RSA = "1.2.840.113549";

        /// szOID_ROOT_LIST_SIGNER -> "1.3.6.1.4.1.311.10.3.9"
        public const string szOID_ROOT_LIST_SIGNER = "1.3.6.1.4.1.311.10.3.9";

        /// szOID_ROLE_OCCUPANT -> "2.5.4.33"
        public const string szOID_ROLE_OCCUPANT = "2.5.4.33";

        /// szOID_REQUIRE_CERT_CHAIN_POLICY -> "1.3.6.1.4.1.311.21.15"
        public const string szOID_REQUIRE_CERT_CHAIN_POLICY = "1.3.6.1.4.1.311.21.15";

        /// szOID_REQUEST_CLIENT_INFO -> "1.3.6.1.4.1.311.21.20"
        public const string szOID_REQUEST_CLIENT_INFO = "1.3.6.1.4.1.311.21.20";

        /// szOID_RENEWAL_CERTIFICATE -> "1.3.6.1.4.1.311.13.1"
        public const string szOID_RENEWAL_CERTIFICATE = "1.3.6.1.4.1.311.13.1";

        /// szOID_REMOVE_CERTIFICATE -> "1.3.6.1.4.1.311.10.8.1"
        public const string szOID_REMOVE_CERTIFICATE = "1.3.6.1.4.1.311.10.8.1";

        /// szOID_REGISTERED_ADDRESS -> "2.5.4.26"
        public const string szOID_REGISTERED_ADDRESS = "2.5.4.26";

        /// szOID_REASON_CODE_HOLD -> "2.5.29.23"
        public const string szOID_REASON_CODE_HOLD = "2.5.29.23";

        /// szOID_RDN_DUMMY_SIGNER -> "1.3.6.1.4.1.311.21.9"
        public const string szOID_RDN_DUMMY_SIGNER = "1.3.6.1.4.1.311.21.9";

        /// szOID_PRODUCT_UPDATE -> "1.3.6.1.4.1.311.31.1"
        public const string szOID_PRODUCT_UPDATE = "1.3.6.1.4.1.311.31.1";

        /// szOID_PRIVATEKEY_USAGE_PERIOD -> "2.5.29.16"
        public const string szOID_PRIVATEKEY_USAGE_PERIOD = "2.5.29.16";

        /// szOID_PRESENTATION_ADDRESS -> "2.5.4.29"
        public const string szOID_PRESENTATION_ADDRESS = "2.5.4.29";

        /// szOID_PREFERRED_DELIVERY_METHOD -> "2.5.4.28"
        public const string szOID_PREFERRED_DELIVERY_METHOD = "2.5.4.28";

        /// szOID_POST_OFFICE_BOX -> "2.5.4.18"
        public const string szOID_POST_OFFICE_BOX = "2.5.4.18";

        /// szOID_POSTAL_CODE -> "2.5.4.17"
        public const string szOID_POSTAL_CODE = "2.5.4.17";

        /// szOID_POSTAL_ADDRESS -> "2.5.4.16"
        public const string szOID_POSTAL_ADDRESS = "2.5.4.16";

        /// szOID_POLICY_MAPPINGS -> "2.5.29.33"
        public const string szOID_POLICY_MAPPINGS = "2.5.29.33";

        /// szOID_POLICY_CONSTRAINTS -> "2.5.29.36"
        public const string szOID_POLICY_CONSTRAINTS = "2.5.29.36";

        /// szOID_PKIX_POLICY_QUALIFIER_USERNOTICE -> "1.3.6.1.5.5.7.2.2"
        public const string szOID_PKIX_POLICY_QUALIFIER_USERNOTICE = "1.3.6.1.5.5.7.2.2";

        /// szOID_PKIX_POLICY_QUALIFIER_CPS -> "1.3.6.1.5.5.7.2.1"
        public const string szOID_PKIX_POLICY_QUALIFIER_CPS = "1.3.6.1.5.5.7.2.1";

        /// szOID_PKIX_PE -> "1.3.6.1.5.5.7.1"
        public const string szOID_PKIX_PE = "1.3.6.1.5.5.7.1";

        /// szOID_PKIX_OCSP -> "1.3.6.1.5.5.7.48.1"
        public const string szOID_PKIX_OCSP = "1.3.6.1.5.5.7.48.1";

        /// szOID_PKIX_NO_SIGNATURE -> "1.3.6.1.5.5.7.6.2"
        public const string szOID_PKIX_NO_SIGNATURE = "1.3.6.1.5.5.7.6.2";

        /// szOID_PKIX_KP_TIMESTAMP_SIGNING -> "1.3.6.1.5.5.7.3.8"
        public const string szOID_PKIX_KP_TIMESTAMP_SIGNING = "1.3.6.1.5.5.7.3.8";

        /// szOID_PKIX_KP_SERVER_AUTH -> "1.3.6.1.5.5.7.3.1"
        public const string szOID_PKIX_KP_SERVER_AUTH = "1.3.6.1.5.5.7.3.1";

        /// szOID_PKIX_KP_IPSEC_USER -> "1.3.6.1.5.5.7.3.7"
        public const string szOID_PKIX_KP_IPSEC_USER = "1.3.6.1.5.5.7.3.7";

        /// szOID_PKIX_KP_IPSEC_TUNNEL -> "1.3.6.1.5.5.7.3.6"
        public const string szOID_PKIX_KP_IPSEC_TUNNEL = "1.3.6.1.5.5.7.3.6";

        /// szOID_PKIX_KP_IPSEC_END_SYSTEM -> "1.3.6.1.5.5.7.3.5"
        public const string szOID_PKIX_KP_IPSEC_END_SYSTEM = "1.3.6.1.5.5.7.3.5";

        /// szOID_PKIX_KP_EMAIL_PROTECTION -> "1.3.6.1.5.5.7.3.4"
        public const string szOID_PKIX_KP_EMAIL_PROTECTION = "1.3.6.1.5.5.7.3.4";

        /// szOID_PKIX_KP_CODE_SIGNING -> "1.3.6.1.5.5.7.3.3"
        public const string szOID_PKIX_KP_CODE_SIGNING = "1.3.6.1.5.5.7.3.3";

        /// szOID_PKIX_KP_CLIENT_AUTH -> "1.3.6.1.5.5.7.3.2"
        public const string szOID_PKIX_KP_CLIENT_AUTH = "1.3.6.1.5.5.7.3.2";

        /// szOID_PKIX_KP -> "1.3.6.1.5.5.7.3"
        public const string szOID_PKIX_KP = "1.3.6.1.5.5.7.3";

        /// szOID_PKIX_CA_ISSUERS -> "1.3.6.1.5.5.7.48.2"
        public const string szOID_PKIX_CA_ISSUERS = "1.3.6.1.5.5.7.48.2";

        /// szOID_PKIX_ACC_DESCR -> "1.3.6.1.5.5.7.48"
        public const string szOID_PKIX_ACC_DESCR = "1.3.6.1.5.5.7.48";

        /// szOID_PKIX -> "1.3.6.1.5.5.7"
        public const string szOID_PKIX = "1.3.6.1.5.5.7";

        /// szOID_PKCS_9_MESSAGE_DIGEST -> "1.2.840.113549.1.9.4"
        public const string szOID_PKCS_9_MESSAGE_DIGEST = "1.2.840.113549.1.9.4";

        /// szOID_PKCS_9_CONTENT_TYPE -> "1.2.840.113549.1.9.3"
        public const string szOID_PKCS_9_CONTENT_TYPE = "1.2.840.113549.1.9.3";

        /// szOID_PKCS_9 -> "1.2.840.113549.1.9"
        public const string szOID_PKCS_9 = "1.2.840.113549.1.9";

        /// szOID_PKCS_8 -> "1.2.840.113549.1.8"
        public const string szOID_PKCS_8 = "1.2.840.113549.1.8";

        /// szOID_PKCS_7_SIGNEDANDENVELOPED -> "1.2.840.113549.1.7.4"
        public const string szOID_PKCS_7_SIGNEDANDENVELOPED = "1.2.840.113549.1.7.4";

        /// szOID_PKCS_7_SIGNED -> "1.2.840.113549.1.7.2"
        public const string szOID_PKCS_7_SIGNED = "1.2.840.113549.1.7.2";

        /// szOID_PKCS_7_ENVELOPED -> "1.2.840.113549.1.7.3"
        public const string szOID_PKCS_7_ENVELOPED = "1.2.840.113549.1.7.3";

        /// szOID_PKCS_7_ENCRYPTED -> "1.2.840.113549.1.7.6"
        public const string szOID_PKCS_7_ENCRYPTED = "1.2.840.113549.1.7.6";

        /// szOID_PKCS_7_DIGESTED -> "1.2.840.113549.1.7.5"
        public const string szOID_PKCS_7_DIGESTED = "1.2.840.113549.1.7.5";

        /// szOID_PKCS_7_DATA -> "1.2.840.113549.1.7.1"
        public const string szOID_PKCS_7_DATA = "1.2.840.113549.1.7.1";

        /// szOID_PKCS_7 -> "1.2.840.113549.1.7"
        public const string szOID_PKCS_7 = "1.2.840.113549.1.7";

        /// szOID_PKCS_6 -> "1.2.840.113549.1.6"
        public const string szOID_PKCS_6 = "1.2.840.113549.1.6";

        /// szOID_PKCS_5 -> "1.2.840.113549.1.5"
        public const string szOID_PKCS_5 = "1.2.840.113549.1.5";

        /// szOID_PKCS_4 -> "1.2.840.113549.1.4"
        public const string szOID_PKCS_4 = "1.2.840.113549.1.4";

        /// szOID_PKCS_3 -> "1.2.840.113549.1.3"
        public const string szOID_PKCS_3 = "1.2.840.113549.1.3";

        /// szOID_PKCS_2 -> "1.2.840.113549.1.2"
        public const string szOID_PKCS_2 = "1.2.840.113549.1.2";

        /// szOID_PKCS_12_LOCAL_KEY_ID -> "1.2.840.113549.1.9.21"
        public const string szOID_PKCS_12_LOCAL_KEY_ID = "1.2.840.113549.1.9.21";

        /// szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR -> "1.3.6.1.4.1.311.17.1"
        public const string szOID_PKCS_12_KEY_PROVIDER_NAME_ATTR = "1.3.6.1.4.1.311.17.1";

        /// szOID_PKCS_12_FRIENDLY_NAME_ATTR -> "1.2.840.113549.1.9.20"
        public const string szOID_PKCS_12_FRIENDLY_NAME_ATTR = "1.2.840.113549.1.9.20";

        /// szOID_PKCS_12 -> "1.2.840.113549.1.12"
        public const string szOID_PKCS_12 = "1.2.840.113549.1.12";

        /// szOID_PKCS_10 -> "1.2.840.113549.1.10"
        public const string szOID_PKCS_10 = "1.2.840.113549.1.10";

        /// szOID_PKCS_1 -> "1.2.840.113549.1.1"
        public const string szOID_PKCS_1 = "1.2.840.113549.1.1";

        /// szOID_PKCS -> "1.2.840.113549.1"
        public const string szOID_PKCS = "1.2.840.113549.1";

        /// szOID_PHYSICAL_DELIVERY_OFFICE_NAME -> "2.5.4.19"
        public const string szOID_PHYSICAL_DELIVERY_OFFICE_NAME = "2.5.4.19";

        /// szOID_OWNER -> "2.5.4.32"
        public const string szOID_OWNER = "2.5.4.32";

        /// szOID_OS_VERSION -> "1.3.6.1.4.1.311.13.2.3"
        public const string szOID_OS_VERSION = "1.3.6.1.4.1.311.13.2.3";

        /// szOID_ORGANIZATION_NAME -> "2.5.4.10"
        public const string szOID_ORGANIZATION_NAME = "2.5.4.10";

        /// szOID_ORGANIZATIONAL_UNIT_NAME -> "2.5.4.11"
        public const string szOID_ORGANIZATIONAL_UNIT_NAME = "2.5.4.11";

        /// szOID_OIWSEC_shaRSA -> "1.3.14.3.2.15"
        public const string szOID_OIWSEC_shaRSA = "1.3.14.3.2.15";

        /// szOID_OIWSEC_shaDSA -> "1.3.14.3.2.13"
        public const string szOID_OIWSEC_shaDSA = "1.3.14.3.2.13";

        /// szOID_OIWSEC_sha1RSASign -> "1.3.14.3.2.29"
        public const string szOID_OIWSEC_sha1RSASign = "1.3.14.3.2.29";

        /// szOID_OIWSEC_sha1 -> "1.3.14.3.2.26"
        public const string szOID_OIWSEC_sha1 = "1.3.14.3.2.26";

        /// szOID_OIWSEC_sha -> "1.3.14.3.2.18"
        public const string szOID_OIWSEC_sha = "1.3.14.3.2.18";

        /// szOID_OIWSEC_rsaXchg -> "1.3.14.3.2.22"
        public const string szOID_OIWSEC_rsaXchg = "1.3.14.3.2.22";

        /// szOID_OIWSEC_rsaSign -> "1.3.14.3.2.11"
        public const string szOID_OIWSEC_rsaSign = "1.3.14.3.2.11";

        /// szOID_OIWSEC_mdc2RSA -> "1.3.14.3.2.14"
        public const string szOID_OIWSEC_mdc2RSA = "1.3.14.3.2.14";

        /// szOID_OIWSEC_mdc2 -> "1.3.14.3.2.19"
        public const string szOID_OIWSEC_mdc2 = "1.3.14.3.2.19";

        /// szOID_OIWSEC_md5RSASign -> "1.3.14.3.2.25"
        public const string szOID_OIWSEC_md5RSASign = "1.3.14.3.2.25";

        /// szOID_OIWSEC_md5RSA -> "1.3.14.3.2.3"
        public const string szOID_OIWSEC_md5RSA = "1.3.14.3.2.3";

        /// szOID_OIWSEC_md4RSA2 -> "1.3.14.3.2.4"
        public const string szOID_OIWSEC_md4RSA2 = "1.3.14.3.2.4";

        /// szOID_OIWSEC_md4RSA -> "1.3.14.3.2.2"
        public const string szOID_OIWSEC_md4RSA = "1.3.14.3.2.2";

        /// szOID_OIWSEC_md2RSASign -> "1.3.14.3.2.24"
        public const string szOID_OIWSEC_md2RSASign = "1.3.14.3.2.24";

        /// szOID_OIWSEC_keyHashSeal -> "1.3.14.3.2.23"
        public const string szOID_OIWSEC_keyHashSeal = "1.3.14.3.2.23";

        /// szOID_OIWSEC_dsaSHA1 -> "1.3.14.3.2.27"
        public const string szOID_OIWSEC_dsaSHA1 = "1.3.14.3.2.27";

        /// szOID_OIWSEC_dsaCommSHA1 -> "1.3.14.3.2.28"
        public const string szOID_OIWSEC_dsaCommSHA1 = "1.3.14.3.2.28";

        /// szOID_OIWSEC_dsaCommSHA -> "1.3.14.3.2.21"
        public const string szOID_OIWSEC_dsaCommSHA = "1.3.14.3.2.21";

        /// szOID_OIWSEC_dsaComm -> "1.3.14.3.2.20"
        public const string szOID_OIWSEC_dsaComm = "1.3.14.3.2.20";

        /// szOID_OIWSEC_dsa -> "1.3.14.3.2.12"
        public const string szOID_OIWSEC_dsa = "1.3.14.3.2.12";

        /// szOID_OIWSEC_dhCommMod -> "1.3.14.3.2.16"
        public const string szOID_OIWSEC_dhCommMod = "1.3.14.3.2.16";

        /// szOID_OIWSEC_desOFB -> "1.3.14.3.2.8"
        public const string szOID_OIWSEC_desOFB = "1.3.14.3.2.8";

        /// szOID_OIWSEC_desMAC -> "1.3.14.3.2.10"
        public const string szOID_OIWSEC_desMAC = "1.3.14.3.2.10";

        /// szOID_OIWSEC_desEDE -> "1.3.14.3.2.17"
        public const string szOID_OIWSEC_desEDE = "1.3.14.3.2.17";

        /// szOID_OIWSEC_desECB -> "1.3.14.3.2.6"
        public const string szOID_OIWSEC_desECB = "1.3.14.3.2.6";

        /// szOID_OIWSEC_desCFB -> "1.3.14.3.2.9"
        public const string szOID_OIWSEC_desCFB = "1.3.14.3.2.9";

        /// szOID_OIWSEC_desCBC -> "1.3.14.3.2.7"
        public const string szOID_OIWSEC_desCBC = "1.3.14.3.2.7";

        /// szOID_OIWSEC -> "1.3.14.3.2"
        public const string szOID_OIWSEC = "1.3.14.3.2";

        /// szOID_OIWDIR_SIGN -> "1.3.14.7.2.3"
        public const string szOID_OIWDIR_SIGN = "1.3.14.7.2.3";

        /// szOID_OIWDIR_md2RSA -> "1.3.14.7.2.3.1"
        public const string szOID_OIWDIR_md2RSA = "1.3.14.7.2.3.1";

        /// szOID_OIWDIR_md2 -> "1.3.14.7.2.2.1"
        public const string szOID_OIWDIR_md2 = "1.3.14.7.2.2.1";

        /// szOID_OIWDIR_HASH -> "1.3.14.7.2.2"
        public const string szOID_OIWDIR_HASH = "1.3.14.7.2.2";

        /// szOID_OIWDIR_CRPT -> "1.3.14.7.2.1"
        public const string szOID_OIWDIR_CRPT = "1.3.14.7.2.1";

        /// szOID_OIWDIR -> "1.3.14.7.2"
        public const string szOID_OIWDIR = "1.3.14.7.2";

        /// szOID_OIW -> "1.3.14"
        public const string szOID_OIW = "1.3.14";

        /// szOID_OEM_WHQL_CRYPTO -> "1.3.6.1.4.1.311.10.3.7"
        public const string szOID_OEM_WHQL_CRYPTO = "1.3.6.1.4.1.311.10.3.7";

        /// szOID_NT_PRINCIPAL_NAME -> "1.3.6.1.4.1.311.20.2.3"
        public const string szOID_NT_PRINCIPAL_NAME = "1.3.6.1.4.1.311.20.2.3";

        /// szOID_NTDS_REPLICATION -> "1.3.6.1.4.1.311.25.1"
        public const string szOID_NTDS_REPLICATION = "1.3.6.1.4.1.311.25.1";

        /// szOID_NT5_CRYPTO -> "1.3.6.1.4.1.311.10.3.6"
        public const string szOID_NT5_CRYPTO = "1.3.6.1.4.1.311.10.3.6";

        /// szOID_NEXT_UPDATE_LOCATION -> "1.3.6.1.4.1.311.10.2"
        public const string szOID_NEXT_UPDATE_LOCATION = "1.3.6.1.4.1.311.10.2";

        /// szOID_NETSCAPE_SSL_SERVER_NAME -> "2.16.840.1.113730.1.12"
        public const string szOID_NETSCAPE_SSL_SERVER_NAME = "2.16.840.1.113730.1.12";

        /// szOID_NETSCAPE_REVOCATION_URL -> "2.16.840.1.113730.1.3"
        public const string szOID_NETSCAPE_REVOCATION_URL = "2.16.840.1.113730.1.3";

        /// szOID_NETSCAPE_DATA_TYPE -> "2.16.840.1.113730.2"
        public const string szOID_NETSCAPE_DATA_TYPE = "2.16.840.1.113730.2";

        /// szOID_NETSCAPE_COMMENT -> "2.16.840.1.113730.1.13"
        public const string szOID_NETSCAPE_COMMENT = "2.16.840.1.113730.1.13";

        /// szOID_NETSCAPE_CERT_TYPE -> "2.16.840.1.113730.1.1"
        public const string szOID_NETSCAPE_CERT_TYPE = "2.16.840.1.113730.1.1";

        /// szOID_NETSCAPE_CERT_SEQUENCE -> "2.16.840.1.113730.2.5"
        public const string szOID_NETSCAPE_CERT_SEQUENCE = "2.16.840.1.113730.2.5";

        /// szOID_NETSCAPE_CERT_RENEWAL_URL -> "2.16.840.1.113730.1.7"
        public const string szOID_NETSCAPE_CERT_RENEWAL_URL = "2.16.840.1.113730.1.7";

        /// szOID_NETSCAPE_CERT_EXTENSION -> "2.16.840.1.113730.1"
        public const string szOID_NETSCAPE_CERT_EXTENSION = "2.16.840.1.113730.1";

        /// szOID_NETSCAPE_CA_REVOCATION_URL -> "2.16.840.1.113730.1.4"
        public const string szOID_NETSCAPE_CA_REVOCATION_URL = "2.16.840.1.113730.1.4";

        /// szOID_NETSCAPE_CA_POLICY_URL -> "2.16.840.1.113730.1.8"
        public const string szOID_NETSCAPE_CA_POLICY_URL = "2.16.840.1.113730.1.8";

        /// szOID_NETSCAPE_BASE_URL -> "2.16.840.1.113730.1.2"
        public const string szOID_NETSCAPE_BASE_URL = "2.16.840.1.113730.1.2";

        /// szOID_NETSCAPE -> "2.16.840.1.113730"
        public const string szOID_NETSCAPE = "2.16.840.1.113730";

        /// szOID_NAME_CONSTRAINTS -> "2.5.29.30"
        public const string szOID_NAME_CONSTRAINTS = "2.5.29.30";

        /// szOID_MEMBER -> "2.5.4.31"
        public const string szOID_MEMBER = "2.5.4.31";

        /// szOID_LOCAL_MACHINE_KEYSET -> "1.3.6.1.4.1.311.17.2"
        public const string szOID_LOCAL_MACHINE_KEYSET = "1.3.6.1.4.1.311.17.2";

        /// szOID_LOCALITY_NAME -> "2.5.4.7"
        public const string szOID_LOCALITY_NAME = "2.5.4.7";

        /// szOID_LICENSE_SERVER -> "1.3.6.1.4.1.311.10.6.2"
        public const string szOID_LICENSE_SERVER = "1.3.6.1.4.1.311.10.6.2";

        /// szOID_LICENSES -> "1.3.6.1.4.1.311.10.6.1"
        public const string szOID_LICENSES = "1.3.6.1.4.1.311.10.6.1";

        /// szOID_LEGACY_POLICY_MAPPINGS -> "2.5.29.5"
        public const string szOID_LEGACY_POLICY_MAPPINGS = "2.5.29.5";

        /// szOID_KP_TIME_STAMP_SIGNING -> "1.3.6.1.4.1.311.10.3.2"
        public const string szOID_KP_TIME_STAMP_SIGNING = "1.3.6.1.4.1.311.10.3.2";

        /// szOID_KP_SMARTCARD_LOGON -> "1.3.6.1.4.1.311.20.2.2"
        public const string szOID_KP_SMARTCARD_LOGON = "1.3.6.1.4.1.311.20.2.2";

        /// szOID_KP_QUALIFIED_SUBORDINATION -> "1.3.6.1.4.1.311.10.3.10"
        public const string szOID_KP_QUALIFIED_SUBORDINATION = "1.3.6.1.4.1.311.10.3.10";

        /// szOID_KP_MOBILE_DEVICE_SOFTWARE -> "1.3.6.1.4.1.311.10.3.14"
        public const string szOID_KP_MOBILE_DEVICE_SOFTWARE = "1.3.6.1.4.1.311.10.3.14";

        /// szOID_KP_LIFETIME_SIGNING -> "1.3.6.1.4.1.311.10.3.13"
        public const string szOID_KP_LIFETIME_SIGNING = "1.3.6.1.4.1.311.10.3.13";

        /// szOID_KP_KEY_RECOVERY_AGENT -> "1.3.6.1.4.1.311.21.6"
        public const string szOID_KP_KEY_RECOVERY_AGENT = "1.3.6.1.4.1.311.21.6";

        /// szOID_KP_KEY_RECOVERY -> "1.3.6.1.4.1.311.10.3.11"
        public const string szOID_KP_KEY_RECOVERY = "1.3.6.1.4.1.311.10.3.11";

        /// szOID_KP_EFS -> "1.3.6.1.4.1.311.10.3.4"
        public const string szOID_KP_EFS = "1.3.6.1.4.1.311.10.3.4";

        /// szOID_KP_DOCUMENT_SIGNING -> "1.3.6.1.4.1.311.10.3.12"
        public const string szOID_KP_DOCUMENT_SIGNING = "1.3.6.1.4.1.311.10.3.12";

        /// szOID_KP_CTL_USAGE_SIGNING -> "1.3.6.1.4.1.311.10.3.1"
        public const string szOID_KP_CTL_USAGE_SIGNING = "1.3.6.1.4.1.311.10.3.1";

        /// szOID_KP_CA_EXCHANGE -> "1.3.6.1.4.1.311.21.5"
        public const string szOID_KP_CA_EXCHANGE = "1.3.6.1.4.1.311.21.5";

        /// szOID_KEY_USAGE_RESTRICTION -> "2.5.29.4"
        public const string szOID_KEY_USAGE_RESTRICTION = "2.5.29.4";

        /// szOID_KEY_USAGE -> "2.5.29.15"
        public const string szOID_KEY_USAGE = "2.5.29.15";

        /// szOID_KEY_ATTRIBUTES -> "2.5.29.2"
        public const string szOID_KEY_ATTRIBUTES = "2.5.29.2";

        /// szOID_KEYID_RDN -> "1.3.6.1.4.1.311.10.7.1"
        public const string szOID_KEYID_RDN = "1.3.6.1.4.1.311.10.7.1";

        /// szOID_ISSUING_DIST_POINT -> "2.5.29.28"
        public const string szOID_ISSUING_DIST_POINT = "2.5.29.28";

        /// szOID_ISSUER_ALT_NAME2 -> "2.5.29.18"
        public const string szOID_ISSUER_ALT_NAME2 = "2.5.29.18";

        /// szOID_ISSUER_ALT_NAME -> "2.5.29.8"
        public const string szOID_ISSUER_ALT_NAME = "2.5.29.8";

        /// szOID_ISSUED_CERT_HASH -> "1.3.6.1.4.1.311.21.17"
        public const string szOID_ISSUED_CERT_HASH = "1.3.6.1.4.1.311.21.17";

        /// szOID_IPSEC_KP_IKE_INTERMEDIATE -> "1.3.6.1.5.5.8.2.2"
        public const string szOID_IPSEC_KP_IKE_INTERMEDIATE = "1.3.6.1.5.5.8.2.2";

        /// szOID_INTERNATIONAL_ISDN_NUMBER -> "2.5.4.25"
        public const string szOID_INTERNATIONAL_ISDN_NUMBER = "2.5.4.25";

        /// szOID_INITIALS -> "2.5.4.43"
        public const string szOID_INITIALS = "2.5.4.43";

        /// szOID_INFOSEC_SuiteATokenProtection -> "2.16.840.1.101.2.1.1.16"
        public const string szOID_INFOSEC_SuiteATokenProtection = "2.16.840.1.101.2.1.1.16";

        /// szOID_INFOSEC_SuiteASignature -> "2.16.840.1.101.2.1.1.13"
        public const string szOID_INFOSEC_SuiteASignature = "2.16.840.1.101.2.1.1.13";

        /// szOID_INFOSEC_SuiteAKMandSig -> "2.16.840.1.101.2.1.1.18"
        public const string szOID_INFOSEC_SuiteAKMandSig = "2.16.840.1.101.2.1.1.18";

        /// szOID_INFOSEC_SuiteAKeyManagement -> "2.16.840.1.101.2.1.1.17"
        public const string szOID_INFOSEC_SuiteAKeyManagement = "2.16.840.1.101.2.1.1.17";

        /// szOID_INFOSEC_SuiteAIntegrity -> "2.16.840.1.101.2.1.1.15"
        public const string szOID_INFOSEC_SuiteAIntegrity = "2.16.840.1.101.2.1.1.15";

        /// szOID_INFOSEC_SuiteAConfidentiality -> "2.16.840.1.101.2.1.1.14"
        public const string szOID_INFOSEC_SuiteAConfidentiality = "2.16.840.1.101.2.1.1.14";

        /// szOID_INFOSEC_sdnsTokenProtection -> "2.16.840.1.101.2.1.1.7"
        public const string szOID_INFOSEC_sdnsTokenProtection = "2.16.840.1.101.2.1.1.7";

        /// szOID_INFOSEC_sdnsSignature -> "2.16.840.1.101.2.1.1.1"
        public const string szOID_INFOSEC_sdnsSignature = "2.16.840.1.101.2.1.1.1";

        /// szOID_INFOSEC_sdnsKMandSig -> "2.16.840.1.101.2.1.1.11"
        public const string szOID_INFOSEC_sdnsKMandSig = "2.16.840.1.101.2.1.1.11";

        /// szOID_INFOSEC_sdnsKeyManagement -> "2.16.840.1.101.2.1.1.9"
        public const string szOID_INFOSEC_sdnsKeyManagement = "2.16.840.1.101.2.1.1.9";

        /// szOID_INFOSEC_sdnsIntegrity -> "2.16.840.1.101.2.1.1.5"
        public const string szOID_INFOSEC_sdnsIntegrity = "2.16.840.1.101.2.1.1.5";

        /// szOID_INFOSEC_sdnsConfidentiality -> "2.16.840.1.101.2.1.1.3"
        public const string szOID_INFOSEC_sdnsConfidentiality = "2.16.840.1.101.2.1.1.3";

        /// szOID_INFOSEC_mosaicUpdatedSig -> "2.16.840.1.101.2.1.1.19"
        public const string szOID_INFOSEC_mosaicUpdatedSig = "2.16.840.1.101.2.1.1.19";

        /// szOID_INFOSEC_mosaicUpdatedInteg -> "2.16.840.1.101.2.1.1.21"
        public const string szOID_INFOSEC_mosaicUpdatedInteg = "2.16.840.1.101.2.1.1.21";

        /// szOID_INFOSEC_mosaicTokenProtection -> "2.16.840.1.101.2.1.1.8"
        public const string szOID_INFOSEC_mosaicTokenProtection = "2.16.840.1.101.2.1.1.8";

        /// szOID_INFOSEC_mosaicSignature -> "2.16.840.1.101.2.1.1.2"
        public const string szOID_INFOSEC_mosaicSignature = "2.16.840.1.101.2.1.1.2";

        /// szOID_INFOSEC_mosaicKMandUpdSig -> "2.16.840.1.101.2.1.1.20"
        public const string szOID_INFOSEC_mosaicKMandUpdSig = "2.16.840.1.101.2.1.1.20";

        /// szOID_INFOSEC_mosaicKMandSig -> "2.16.840.1.101.2.1.1.12"
        public const string szOID_INFOSEC_mosaicKMandSig = "2.16.840.1.101.2.1.1.12";

        /// szOID_INFOSEC_mosaicKeyManagement -> "2.16.840.1.101.2.1.1.10"
        public const string szOID_INFOSEC_mosaicKeyManagement = "2.16.840.1.101.2.1.1.10";

        /// szOID_INFOSEC_mosaicIntegrity -> "2.16.840.1.101.2.1.1.6"
        public const string szOID_INFOSEC_mosaicIntegrity = "2.16.840.1.101.2.1.1.6";

        /// szOID_INFOSEC_mosaicConfidentiality -> "2.16.840.1.101.2.1.1.4"
        public const string szOID_INFOSEC_mosaicConfidentiality = "2.16.840.1.101.2.1.1.4";

        /// szOID_INFOSEC -> "2.16.840.1.101.2.1"
        public const string szOID_INFOSEC = "2.16.840.1.101.2.1";

        /// szOID_GIVEN_NAME -> "2.5.4.42"
        public const string szOID_GIVEN_NAME = "2.5.4.42";

        /// szOID_FRESHEST_CRL -> "2.5.29.46"
        public const string szOID_FRESHEST_CRL = "2.5.29.46";

        /// szOID_FACSIMILE_TELEPHONE_NUMBER -> "2.5.4.23"
        public const string szOID_FACSIMILE_TELEPHONE_NUMBER = "2.5.4.23";

        /// szOID_ENTERPRISE_OID_ROOT -> "1.3.6.1.4.1.311.21.8"
        public const string szOID_ENTERPRISE_OID_ROOT = "1.3.6.1.4.1.311.21.8";

        /// szOID_ENROLL_CERTTYPE_EXTENSION -> "1.3.6.1.4.1.311.20.2"
        public const string szOID_ENROLL_CERTTYPE_EXTENSION = "1.3.6.1.4.1.311.20.2";

        /// szOID_ENROLLMENT_NAME_VALUE_PAIR -> "1.3.6.1.4.1.311.13.2.1"
        public const string szOID_ENROLLMENT_NAME_VALUE_PAIR = "1.3.6.1.4.1.311.13.2.1";

        /// szOID_ENROLLMENT_CSP_PROVIDER -> "1.3.6.1.4.1.311.13.2.2"
        public const string szOID_ENROLLMENT_CSP_PROVIDER = "1.3.6.1.4.1.311.13.2.2";

        /// szOID_ENROLLMENT_AGENT -> "1.3.6.1.4.1.311.20.2.1"
        public const string szOID_ENROLLMENT_AGENT = "1.3.6.1.4.1.311.20.2.1";

        /// szOID_ENHANCED_KEY_USAGE -> "2.5.29.37"
        public const string szOID_ENHANCED_KEY_USAGE = "2.5.29.37";

        /// szOID_ENCRYPTED_KEY_HASH -> "1.3.6.1.4.1.311.21.21"
        public const string szOID_ENCRYPTED_KEY_HASH = "1.3.6.1.4.1.311.21.21";

        /// szOID_EMBEDDED_NT_CRYPTO -> "1.3.6.1.4.1.311.10.3.8"
        public const string szOID_EMBEDDED_NT_CRYPTO = "1.3.6.1.4.1.311.10.3.8";

        /// szOID_EFS_RECOVERY -> "1.3.6.1.4.1.311.10.3.4.1"
        public const string szOID_EFS_RECOVERY = "1.3.6.1.4.1.311.10.3.4.1";

        /// szOID_DS_EMAIL_REPLICATION -> "1.3.6.1.4.1.311.21.19"
        public const string szOID_DS_EMAIL_REPLICATION = "1.3.6.1.4.1.311.21.19";

        /// szOID_DSALG_SIGN -> "2.5.8.3"
        public const string szOID_DSALG_SIGN = "2.5.8.3";

        /// szOID_DSALG_RSA -> "2.5.8.1.1"
        public const string szOID_DSALG_RSA = "2.5.8.1.1";

        /// szOID_DSALG_HASH -> "2.5.8.2"
        public const string szOID_DSALG_HASH = "2.5.8.2";

        /// szOID_DSALG_CRPT -> "2.5.8.1"
        public const string szOID_DSALG_CRPT = "2.5.8.1";

        /// szOID_DSALG -> "2.5.8"
        public const string szOID_DSALG = "2.5.8";

        /// szOID_DS -> "2.5"
        public const string szOID_DS = "2.5";

        /// szOID_DRM_INDIVIDUALIZATION -> "1.3.6.1.4.1.311.10.5.2"
        public const string szOID_DRM_INDIVIDUALIZATION = "1.3.6.1.4.1.311.10.5.2";

        /// szOID_DRM -> "1.3.6.1.4.1.311.10.5.1"
        public const string szOID_DRM = "1.3.6.1.4.1.311.10.5.1";

        /// szOID_DOMAIN_COMPONENT -> "0.9.2342.19200300.100.1.25"
        public const string szOID_DOMAIN_COMPONENT = "0.9.2342.19200300.100.1.25";

        /// szOID_DN_QUALIFIER -> "2.5.4.46"
        public const string szOID_DN_QUALIFIER = "2.5.4.46";

        /// szOID_DEVICE_SERIAL_NUMBER -> "2.5.4.5"
        public const string szOID_DEVICE_SERIAL_NUMBER = "2.5.4.5";

        /// szOID_DESTINATION_INDICATOR -> "2.5.4.27"
        public const string szOID_DESTINATION_INDICATOR = "2.5.4.27";

        /// szOID_DESCRIPTION -> "2.5.4.13"
        public const string szOID_DESCRIPTION = "2.5.4.13";

        /// szOID_DELTA_CRL_INDICATOR -> "2.5.29.27"
        public const string szOID_DELTA_CRL_INDICATOR = "2.5.29.27";

        /// szOID_CT_PKI_RESPONSE -> "1.3.6.1.5.5.7.12.3"
        public const string szOID_CT_PKI_RESPONSE = "1.3.6.1.5.5.7.12.3";

        /// szOID_CT_PKI_DATA -> "1.3.6.1.5.5.7.12.2"
        public const string szOID_CT_PKI_DATA = "1.3.6.1.5.5.7.12.2";

        /// szOID_CTL -> "1.3.6.1.4.1.311.10.1"
        public const string szOID_CTL = "1.3.6.1.4.1.311.10.1";

        /// szOID_CROSS_CERT_DIST_POINTS -> "1.3.6.1.4.1.311.10.9.1"
        public const string szOID_CROSS_CERT_DIST_POINTS = "1.3.6.1.4.1.311.10.9.1";

        /// szOID_CROSS_CERTIFICATE_PAIR -> "2.5.4.40"
        public const string szOID_CROSS_CERTIFICATE_PAIR = "2.5.4.40";

        /// szOID_CRL_VIRTUAL_BASE -> "1.3.6.1.4.1.311.21.3"
        public const string szOID_CRL_VIRTUAL_BASE = "1.3.6.1.4.1.311.21.3";

        /// szOID_CRL_SELF_CDP -> "1.3.6.1.4.1.311.21.14"
        public const string szOID_CRL_SELF_CDP = "1.3.6.1.4.1.311.21.14";

        /// szOID_CRL_REASON_CODE -> "2.5.29.21"
        public const string szOID_CRL_REASON_CODE = "2.5.29.21";

        /// szOID_CRL_NUMBER -> "2.5.29.20"
        public const string szOID_CRL_NUMBER = "2.5.29.20";

        /// szOID_CRL_NEXT_PUBLISH -> "1.3.6.1.4.1.311.21.4"
        public const string szOID_CRL_NEXT_PUBLISH = "1.3.6.1.4.1.311.21.4";

        /// szOID_CRL_DIST_POINTS -> "2.5.29.31"
        public const string szOID_CRL_DIST_POINTS = "2.5.29.31";

        /// szOID_COUNTRY_NAME -> "2.5.4.6"
        public const string szOID_COUNTRY_NAME = "2.5.4.6";

        /// szOID_COMMON_NAME -> "2.5.4.3"
        public const string szOID_COMMON_NAME = "2.5.4.3";

        /// szOID_CMC_TRANSACTION_ID -> "1.3.6.1.5.5.7.7.5"
        public const string szOID_CMC_TRANSACTION_ID = "1.3.6.1.5.5.7.7.5";

        /// szOID_CMC_STATUS_INFO -> "1.3.6.1.5.5.7.7.1"
        public const string szOID_CMC_STATUS_INFO = "1.3.6.1.5.5.7.7.1";

        /// szOID_CMC_SENDER_NONCE -> "1.3.6.1.5.5.7.7.6"
        public const string szOID_CMC_SENDER_NONCE = "1.3.6.1.5.5.7.7.6";

        /// szOID_CMC_REVOKE_REQUEST -> "1.3.6.1.5.5.7.7.17"
        public const string szOID_CMC_REVOKE_REQUEST = "1.3.6.1.5.5.7.7.17";

        /// szOID_CMC_RESPONSE_INFO -> "1.3.6.1.5.5.7.7.19"
        public const string szOID_CMC_RESPONSE_INFO = "1.3.6.1.5.5.7.7.19";

        /// szOID_CMC_REG_INFO -> "1.3.6.1.5.5.7.7.18"
        public const string szOID_CMC_REG_INFO = "1.3.6.1.5.5.7.7.18";

        /// szOID_CMC_RECIPIENT_NONCE -> "1.3.6.1.5.5.7.7.7"
        public const string szOID_CMC_RECIPIENT_NONCE = "1.3.6.1.5.5.7.7.7";

        /// szOID_CMC_QUERY_PENDING -> "1.3.6.1.5.5.7.7.21"
        public const string szOID_CMC_QUERY_PENDING = "1.3.6.1.5.5.7.7.21";

        /// szOID_CMC_LRA_POP_WITNESS -> "1.3.6.1.5.5.7.7.11"
        public const string szOID_CMC_LRA_POP_WITNESS = "1.3.6.1.5.5.7.7.11";

        /// szOID_CMC_ID_POP_LINK_WITNESS -> "1.3.6.1.5.5.7.7.23"
        public const string szOID_CMC_ID_POP_LINK_WITNESS = "1.3.6.1.5.5.7.7.23";

        /// szOID_CMC_ID_POP_LINK_RANDOM -> "1.3.6.1.5.5.7.7.22"
        public const string szOID_CMC_ID_POP_LINK_RANDOM = "1.3.6.1.5.5.7.7.22";

        /// szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE -> "1.3.6.1.5.5.7.7.24"
        public const string szOID_CMC_ID_CONFIRM_CERT_ACCEPTANCE = "1.3.6.1.5.5.7.7.24";

        /// szOID_CMC_IDENTITY_PROOF -> "1.3.6.1.5.5.7.7.3"
        public const string szOID_CMC_IDENTITY_PROOF = "1.3.6.1.5.5.7.7.3";

        /// szOID_CMC_IDENTIFICATION -> "1.3.6.1.5.5.7.7.2"
        public const string szOID_CMC_IDENTIFICATION = "1.3.6.1.5.5.7.7.2";

        /// szOID_CMC_GET_CRL -> "1.3.6.1.5.5.7.7.16"
        public const string szOID_CMC_GET_CRL = "1.3.6.1.5.5.7.7.16";

        /// szOID_CMC_GET_CERT -> "1.3.6.1.5.5.7.7.15"
        public const string szOID_CMC_GET_CERT = "1.3.6.1.5.5.7.7.15";

        /// szOID_CMC_ENCRYPTED_POP -> "1.3.6.1.5.5.7.7.9"
        public const string szOID_CMC_ENCRYPTED_POP = "1.3.6.1.5.5.7.7.9";

        /// szOID_CMC_DECRYPTED_POP -> "1.3.6.1.5.5.7.7.10"
        public const string szOID_CMC_DECRYPTED_POP = "1.3.6.1.5.5.7.7.10";

        /// szOID_CMC_DATA_RETURN -> "1.3.6.1.5.5.7.7.4"
        public const string szOID_CMC_DATA_RETURN = "1.3.6.1.5.5.7.7.4";

        /// szOID_CMC_ADD_EXTENSIONS -> "1.3.6.1.5.5.7.7.8"
        public const string szOID_CMC_ADD_EXTENSIONS = "1.3.6.1.5.5.7.7.8";

        /// szOID_CMC_ADD_ATTRIBUTES -> "1.3.6.1.4.1.311.10.10.1"
        public const string szOID_CMC_ADD_ATTRIBUTES = "1.3.6.1.4.1.311.10.10.1";

        /// szOID_CMC -> "1.3.6.1.5.5.7.7"
        public const string szOID_CMC = "1.3.6.1.5.5.7.7";

        /// szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID -> "1.3.6.1.4.1.311.10.11.29"
        public const string szOID_CERT_SUBJECT_NAME_MD5_HASH_PROP_ID = "1.3.6.1.4.1.311.10.11.29";

        /// szOID_CERT_PROP_ID_PREFIX -> "1.3.6.1.4.1.311.10.11."
        public const string szOID_CERT_PROP_ID_PREFIX = "1.3.6.1.4.1.311.10.11.";

        /// szOID_CERT_POLICIES_95_QUALIFIER1 -> "2.16.840.1.113733.1.7.1.1"
        public const string szOID_CERT_POLICIES_95_QUALIFIER1 = "2.16.840.1.113733.1.7.1.1";

        /// szOID_CERT_POLICIES_95 -> "2.5.29.3"
        public const string szOID_CERT_POLICIES_95 = "2.5.29.3";

        /// szOID_CERT_POLICIES -> "2.5.29.32"
        public const string szOID_CERT_POLICIES = "2.5.29.32";

        /// szOID_CERT_MANIFOLD -> "1.3.6.1.4.1.311.20.3"
        public const string szOID_CERT_MANIFOLD = "1.3.6.1.4.1.311.20.3";

        /// szOID_CERT_KEY_IDENTIFIER_PROP_ID -> "1.3.6.1.4.1.311.10.11.20"
        public const string szOID_CERT_KEY_IDENTIFIER_PROP_ID = "1.3.6.1.4.1.311.10.11.20";

        /// szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID -> "1.3.6.1.4.1.311.10.11.28"
        public const string szOID_CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID = "1.3.6.1.4.1.311.10.11.28";

        /// szOID_CERT_EXTENSIONS -> "1.3.6.1.4.1.311.2.1.14"
        public const string szOID_CERT_EXTENSIONS = "1.3.6.1.4.1.311.2.1.14";

        /// szOID_CERTSRV_PREVIOUS_CERT_HASH -> "1.3.6.1.4.1.311.21.2"
        public const string szOID_CERTSRV_PREVIOUS_CERT_HASH = "1.3.6.1.4.1.311.21.2";

        /// szOID_CERTSRV_CROSSCA_VERSION -> "1.3.6.1.4.1.311.21.22"
        public const string szOID_CERTSRV_CROSSCA_VERSION = "1.3.6.1.4.1.311.21.22";

        /// szOID_CERTSRV_CA_VERSION -> "1.3.6.1.4.1.311.21.1"
        public const string szOID_CERTSRV_CA_VERSION = "1.3.6.1.4.1.311.21.1";

        /// szOID_CERTIFICATE_TEMPLATE -> "1.3.6.1.4.1.311.21.7"
        public const string szOID_CERTIFICATE_TEMPLATE = "1.3.6.1.4.1.311.21.7";

        /// szOID_CERTIFICATE_REVOCATION_LIST -> "2.5.4.39"
        public const string szOID_CERTIFICATE_REVOCATION_LIST = "2.5.4.39";

        /// szOID_CA_CERTIFICATE -> "2.5.4.37"
        public const string szOID_CA_CERTIFICATE = "2.5.4.37";

        /// szOID_BUSINESS_CATEGORY -> "2.5.4.15"
        public const string szOID_BUSINESS_CATEGORY = "2.5.4.15";

        /// szOID_BASIC_CONSTRAINTS2 -> "2.5.29.19"
        public const string szOID_BASIC_CONSTRAINTS2 = "2.5.29.19";

        /// szOID_BASIC_CONSTRAINTS -> "2.5.29.10"
        public const string szOID_BASIC_CONSTRAINTS = "2.5.29.10";

        /// szOID_AUTO_ENROLL_CTL_USAGE -> "1.3.6.1.4.1.311.20.1"
        public const string szOID_AUTO_ENROLL_CTL_USAGE = "1.3.6.1.4.1.311.20.1";

        /// szOID_AUTHORITY_REVOCATION_LIST -> "2.5.4.38"
        public const string szOID_AUTHORITY_REVOCATION_LIST = "2.5.4.38";

        /// szOID_AUTHORITY_KEY_IDENTIFIER2 -> "2.5.29.35"
        public const string szOID_AUTHORITY_KEY_IDENTIFIER2 = "2.5.29.35";

        /// szOID_AUTHORITY_KEY_IDENTIFIER -> "2.5.29.1"
        public const string szOID_AUTHORITY_KEY_IDENTIFIER = "2.5.29.1";

        /// szOID_AUTHORITY_INFO_ACCESS -> "1.3.6.1.5.5.7.1.1"
        public const string szOID_AUTHORITY_INFO_ACCESS = "1.3.6.1.5.5.7.1.1";

        /// szOID_ARCHIVED_KEY_CERT_HASH -> "1.3.6.1.4.1.311.21.16"
        public const string szOID_ARCHIVED_KEY_CERT_HASH = "1.3.6.1.4.1.311.21.16";

        /// szOID_ARCHIVED_KEY_ATTR -> "1.3.6.1.4.1.311.21.13"
        public const string szOID_ARCHIVED_KEY_ATTR = "1.3.6.1.4.1.311.21.13";

        /// szOID_APPLICATION_POLICY_MAPPINGS -> "1.3.6.1.4.1.311.21.11"
        public const string szOID_APPLICATION_POLICY_MAPPINGS = "1.3.6.1.4.1.311.21.11";

        /// szOID_APPLICATION_POLICY_CONSTRAINTS -> "1.3.6.1.4.1.311.21.12"
        public const string szOID_APPLICATION_POLICY_CONSTRAINTS = "1.3.6.1.4.1.311.21.12";

        /// szOID_APPLICATION_CERT_POLICIES -> "1.3.6.1.4.1.311.21.10"
        public const string szOID_APPLICATION_CERT_POLICIES = "1.3.6.1.4.1.311.21.10";

        /// szOID_ANY_CERT_POLICY -> "2.5.29.32.0"
        public const string szOID_ANY_CERT_POLICY = "2.5.29.32.0";

        /// szOID_ANY_APPLICATION_POLICY -> "1.3.6.1.4.1.311.10.12.1"
        public const string szOID_ANY_APPLICATION_POLICY = "1.3.6.1.4.1.311.10.12.1";

        /// szOID_ANSI_X942_DH -> "1.2.840.10046.2.1"
        public const string szOID_ANSI_X942_DH = "1.2.840.10046.2.1";

        /// szOID_ANSI_X942 -> "1.2.840.10046"
        public const string szOID_ANSI_X942 = "1.2.840.10046";

        /// szKEY_CRYPTOAPI_PRIVATE_KEY_OPTIONS -> "Software\\Policies\\Microsoft\\Cryptography"
        public const string szKEY_CRYPTOAPI_PRIVATE_KEY_OPTIONS = "Software\\\\Policies\\\\Microsoft\\\\Cryptography";

        /// szKEY_CACHE_SECONDS -> "PrivateKeyLifetimeSeconds"
        public const string szKEY_CACHE_SECONDS = "PrivateKeyLifetimeSeconds";

        /// szKEY_CACHE_ENABLED -> "CachePrivateKeys"
        public const string szKEY_CACHE_ENABLED = "CachePrivateKeys";

        /// szFORCE_KEY_PROTECTION -> "ForceKeyProtection"
        public const string szFORCE_KEY_PROTECTION = "ForceKeyProtection";

        /// SZDDE_ITEM_ITEMLIST -> L"TopicItemList"
        public const string SZDDE_ITEM_ITEMLIST = "TopicItemList";

        /// SZDDESYS_TOPIC -> L"System"
        public const string SZDDESYS_TOPIC = "System";

        /// SZDDESYS_ITEM_TOPICS -> L"Topics"
        public const string SZDDESYS_ITEM_TOPICS = "Topics";

        /// SZDDESYS_ITEM_SYSITEMS -> L"SysItems"
        public const string SZDDESYS_ITEM_SYSITEMS = "SysItems";

        /// SZDDESYS_ITEM_STATUS -> L"Status"
        public const string SZDDESYS_ITEM_STATUS = "Status";

        /// SZDDESYS_ITEM_RTNMSG -> L"ReturnMessage"
        public const string SZDDESYS_ITEM_RTNMSG = "ReturnMessage";

        /// SZDDESYS_ITEM_HELP -> L"Help"
        public const string SZDDESYS_ITEM_HELP = "Help";

        /// SZDDESYS_ITEM_FORMATS -> L"Formats"
        public const string SZDDESYS_ITEM_FORMATS = "Formats";

        /// SYSTEM_FONT -> 13
        public const int SYSTEM_FONT = 13;

        /// SYSTEM_FIXED_FONT -> 16
        public const int SYSTEM_FIXED_FONT = 16;

        /// SYSTEM_CACHE_ALIGNMENT_SIZE -> 64
        public const int SYSTEM_CACHE_ALIGNMENT_SIZE = 64;

        /// SYSTEM_AUDIT_OBJECT_ACE_TYPE -> (0x7)
        public const int SYSTEM_AUDIT_OBJECT_ACE_TYPE = 7;

        /// SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE -> (0xF)
        public const int SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE = 15;

        /// SYSTEM_AUDIT_CALLBACK_ACE_TYPE -> (0xD)
        public const int SYSTEM_AUDIT_CALLBACK_ACE_TYPE = 13;

        /// SYSTEM_AUDIT_ACE_TYPE -> (0x2)
        public const int SYSTEM_AUDIT_ACE_TYPE = 2;

        /// SYSTEM_ALARM_OBJECT_ACE_TYPE -> (0x8)
        public const int SYSTEM_ALARM_OBJECT_ACE_TYPE = 8;

        /// SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE -> (0x10)
        public const int SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE = 16;

        /// SYSTEM_ALARM_CALLBACK_ACE_TYPE -> (0xE)
        public const int SYSTEM_ALARM_CALLBACK_ACE_TYPE = 14;

        /// SYSTEM_ALARM_ACE_TYPE -> (0x3)
        public const int SYSTEM_ALARM_ACE_TYPE = 3;

        /// SystemParametersInfo -> SystemParametersInfoW
        /// Error generating expression: Value SystemParametersInfoW is not resolved
        public const string SystemParametersInfo = "SystemParametersInfoW";

        /// SYSRGN -> 4
        public const int SYSRGN = 4;

        /// SYSPAL_STATIC -> 1
        public const int SYSPAL_STATIC = 1;

        /// SYSPAL_NOSTATIC256 -> 3
        public const int SYSPAL_NOSTATIC256 = 3;

        /// SYSPAL_NOSTATIC -> 2
        public const int SYSPAL_NOSTATIC = 2;

        /// SYSPAL_ERROR -> 0
        public const int SYSPAL_ERROR = 0;

        /// SYNCHRONIZE -> (0x00100000L)
        public const int SYNCHRONIZE = 1048576;

        /// SYMMETRICWRAPKEYBLOB -> 0xB
        public const int SYMMETRICWRAPKEYBLOB = 11;

        /// SYMBOL_CHARSET -> 2
        public const int SYMBOL_CHARSET = 2;

        /// SW_SMOOTHSCROLL -> 0x0010
        public const int SW_SMOOTHSCROLL = 16;

        /// SW_SHOWNORMAL -> 1
        public const int SW_SHOWNORMAL = 1;

        /// SW_SHOWNOACTIVATE -> 4
        public const int SW_SHOWNOACTIVATE = 4;

        /// SW_SHOWNA -> 8
        public const int SW_SHOWNA = 8;

        /// SW_SHOWMINNOACTIVE -> 7
        public const int SW_SHOWMINNOACTIVE = 7;

        /// SW_SHOWMINIMIZED -> 2
        public const int SW_SHOWMINIMIZED = 2;

        /// SW_SHOWMAXIMIZED -> 3
        public const int SW_SHOWMAXIMIZED = 3;

        /// SW_SHOWDEFAULT -> 10
        public const int SW_SHOWDEFAULT = 10;

        /// SW_SHOW -> 5
        public const int SW_SHOW = 5;

        /// SW_SCROLLCHILDREN -> 0x0001
        public const int SW_SCROLLCHILDREN = 1;

        /// SW_RESTORE -> 9
        public const int SW_RESTORE = 9;

        /// SW_PARENTOPENING -> 3
        public const int SW_PARENTOPENING = 3;

        /// SW_PARENTCLOSING -> 1
        public const int SW_PARENTCLOSING = 1;

        /// SW_OTHERZOOM -> 2
        public const int SW_OTHERZOOM = 2;

        /// SW_OTHERUNZOOM -> 4
        public const int SW_OTHERUNZOOM = 4;

        /// SW_NORMAL -> 1
        public const int SW_NORMAL = 1;

        /// SW_MINIMIZE -> 6
        public const int SW_MINIMIZE = 6;

        /// SW_MAXIMIZE -> 3
        public const int SW_MAXIMIZE = 3;

        /// SW_MAX -> 11
        public const int SW_MAX = 11;

        /// SW_INVALIDATE -> 0x0002
        public const int SW_INVALIDATE = 2;

        /// SW_HIDE -> 0
        public const int SW_HIDE = 0;

        /// SW_FORCEMINIMIZE -> 11
        public const int SW_FORCEMINIMIZE = 11;

        /// SW_ERASE -> 0x0004
        public const int SW_ERASE = 4;

        /// SWP_SHOWWINDOW -> 0x0040
        public const int SWP_SHOWWINDOW = 64;

        /// SWP_NOZORDER -> 0x0004
        public const int SWP_NOZORDER = 4;

        /// SWP_NOSIZE -> 0x0001
        public const int SWP_NOSIZE = 1;

        /// SWP_NOSENDCHANGING -> 0x0400
        public const int SWP_NOSENDCHANGING = 1024;

        /// SWP_NOREPOSITION -> SWP_NOOWNERZORDER
        public const int SWP_NOREPOSITION = NativeConstants.SWP_NOOWNERZORDER;

        /// SWP_NOREDRAW -> 0x0008
        public const int SWP_NOREDRAW = 8;

        /// SWP_NOOWNERZORDER -> 0x0200
        public const int SWP_NOOWNERZORDER = 512;

        /// SWP_NOMOVE -> 0x0002
        public const int SWP_NOMOVE = 2;

        /// SWP_NOCOPYBITS -> 0x0100
        public const int SWP_NOCOPYBITS = 256;

        /// SWP_NOACTIVATE -> 0x0010
        public const int SWP_NOACTIVATE = 16;

        /// SWP_HIDEWINDOW -> 0x0080
        public const int SWP_HIDEWINDOW = 128;

        /// SWP_FRAMECHANGED -> 0x0020
        public const int SWP_FRAMECHANGED = 32;

        /// SWP_DRAWFRAME -> SWP_FRAMECHANGED
        public const int SWP_DRAWFRAME = NativeConstants.SWP_FRAMECHANGED;

        /// SWP_DEFERERASE -> 0x2000
        public const int SWP_DEFERERASE = 8192;

        /// SWP_ASYNCWINDOWPOS -> 0x4000
        public const int SWP_ASYNCWINDOWPOS = 16384;

        /// SUCCESSFUL_ACCESS_ACE_FLAG -> (0x40)
        public const int SUCCESSFUL_ACCESS_ACE_FLAG = 64;

        /// SUBLANG_UZBEK_LATIN -> 0x01
        public const int SUBLANG_UZBEK_LATIN = 1;

        /// SUBLANG_UZBEK_CYRILLIC -> 0x02
        public const int SUBLANG_UZBEK_CYRILLIC = 2;

        /// SUBLANG_URDU_PAKISTAN -> 0x01
        public const int SUBLANG_URDU_PAKISTAN = 1;

        /// SUBLANG_URDU_INDIA -> 0x02
        public const int SUBLANG_URDU_INDIA = 2;

        /// SUBLANG_SYS_DEFAULT -> 0x02
        public const int SUBLANG_SYS_DEFAULT = 2;

        /// SUBLANG_SWEDISH_FINLAND -> 0x02
        public const int SUBLANG_SWEDISH_FINLAND = 2;

        /// SUBLANG_SWEDISH -> 0x01
        public const int SUBLANG_SWEDISH = 1;

        /// SUBLANG_SPANISH_VENEZUELA -> 0x08
        public const int SUBLANG_SPANISH_VENEZUELA = 8;

        /// SUBLANG_SPANISH_URUGUAY -> 0x0e
        public const int SUBLANG_SPANISH_URUGUAY = 14;

        /// SUBLANG_SPANISH_PUERTO_RICO -> 0x14
        public const int SUBLANG_SPANISH_PUERTO_RICO = 20;

        /// SUBLANG_SPANISH_PERU -> 0x0a
        public const int SUBLANG_SPANISH_PERU = 10;

        /// SUBLANG_SPANISH_PARAGUAY -> 0x0f
        public const int SUBLANG_SPANISH_PARAGUAY = 15;

        /// SUBLANG_SPANISH_PANAMA -> 0x06
        public const int SUBLANG_SPANISH_PANAMA = 6;

        /// SUBLANG_SPANISH_NICARAGUA -> 0x13
        public const int SUBLANG_SPANISH_NICARAGUA = 19;

        /// SUBLANG_SPANISH_MODERN -> 0x03
        public const int SUBLANG_SPANISH_MODERN = 3;

        /// SUBLANG_SPANISH_MEXICAN -> 0x02
        public const int SUBLANG_SPANISH_MEXICAN = 2;

        /// SUBLANG_SPANISH_HONDURAS -> 0x12
        public const int SUBLANG_SPANISH_HONDURAS = 18;

        /// SUBLANG_SPANISH_GUATEMALA -> 0x04
        public const int SUBLANG_SPANISH_GUATEMALA = 4;

        /// SUBLANG_SPANISH_EL_SALVADOR -> 0x11
        public const int SUBLANG_SPANISH_EL_SALVADOR = 17;

        /// SUBLANG_SPANISH_ECUADOR -> 0x0c
        public const int SUBLANG_SPANISH_ECUADOR = 12;

        /// SUBLANG_SPANISH_DOMINICAN_REPUBLIC -> 0x07
        public const int SUBLANG_SPANISH_DOMINICAN_REPUBLIC = 7;

        /// SUBLANG_SPANISH_COSTA_RICA -> 0x05
        public const int SUBLANG_SPANISH_COSTA_RICA = 5;

        /// SUBLANG_SPANISH_COLOMBIA -> 0x09
        public const int SUBLANG_SPANISH_COLOMBIA = 9;

        /// SUBLANG_SPANISH_CHILE -> 0x0d
        public const int SUBLANG_SPANISH_CHILE = 13;

        /// SUBLANG_SPANISH_BOLIVIA -> 0x10
        public const int SUBLANG_SPANISH_BOLIVIA = 16;

        /// SUBLANG_SPANISH_ARGENTINA -> 0x0b
        public const int SUBLANG_SPANISH_ARGENTINA = 11;

        /// SUBLANG_SPANISH -> 0x01
        public const int SUBLANG_SPANISH = 1;

        /// SUBLANG_SERBIAN_LATIN -> 0x02
        public const int SUBLANG_SERBIAN_LATIN = 2;

        /// SUBLANG_SERBIAN_CYRILLIC -> 0x03
        public const int SUBLANG_SERBIAN_CYRILLIC = 3;

        /// SUBLANG_PORTUGUESE_BRAZILIAN -> 0x01
        public const int SUBLANG_PORTUGUESE_BRAZILIAN = 1;

        /// SUBLANG_PORTUGUESE -> 0x02
        public const int SUBLANG_PORTUGUESE = 2;

        /// SUBLANG_NORWEGIAN_NYNORSK -> 0x02
        public const int SUBLANG_NORWEGIAN_NYNORSK = 2;

        /// SUBLANG_NORWEGIAN_BOKMAL -> 0x01
        public const int SUBLANG_NORWEGIAN_BOKMAL = 1;

        /// SUBLANG_NEUTRAL -> 0x00
        public const int SUBLANG_NEUTRAL = 0;

        /// SUBLANG_NEPALI_INDIA -> 0x02
        public const int SUBLANG_NEPALI_INDIA = 2;

        /// SUBLANG_MALAY_MALAYSIA -> 0x01
        public const int SUBLANG_MALAY_MALAYSIA = 1;

        /// SUBLANG_MALAY_BRUNEI_DARUSSALAM -> 0x02
        public const int SUBLANG_MALAY_BRUNEI_DARUSSALAM = 2;

        /// SUBLANG_LITHUANIAN -> 0x01
        public const int SUBLANG_LITHUANIAN = 1;

        /// SUBLANG_KOREAN -> 0x01
        public const int SUBLANG_KOREAN = 1;

        /// SUBLANG_KASHMIRI_SASIA -> 0x02
        public const int SUBLANG_KASHMIRI_SASIA = 2;

        /// SUBLANG_KASHMIRI_INDIA -> 0x02
        public const int SUBLANG_KASHMIRI_INDIA = 2;

        /// SUBLANG_ITALIAN_SWISS -> 0x02
        public const int SUBLANG_ITALIAN_SWISS = 2;

        /// SUBLANG_ITALIAN -> 0x01
        public const int SUBLANG_ITALIAN = 1;

        /// SUBLANG_GERMAN_SWISS -> 0x02
        public const int SUBLANG_GERMAN_SWISS = 2;

        /// SUBLANG_GERMAN_LUXEMBOURG -> 0x04
        public const int SUBLANG_GERMAN_LUXEMBOURG = 4;

        /// SUBLANG_GERMAN_LIECHTENSTEIN -> 0x05
        public const int SUBLANG_GERMAN_LIECHTENSTEIN = 5;

        /// SUBLANG_GERMAN_AUSTRIAN -> 0x03
        public const int SUBLANG_GERMAN_AUSTRIAN = 3;

        /// SUBLANG_GERMAN -> 0x01
        public const int SUBLANG_GERMAN = 1;

        /// SUBLANG_FRENCH_SWISS -> 0x04
        public const int SUBLANG_FRENCH_SWISS = 4;

        /// SUBLANG_FRENCH_MONACO -> 0x06
        public const int SUBLANG_FRENCH_MONACO = 6;

        /// SUBLANG_FRENCH_LUXEMBOURG -> 0x05
        public const int SUBLANG_FRENCH_LUXEMBOURG = 5;

        /// SUBLANG_FRENCH_CANADIAN -> 0x03
        public const int SUBLANG_FRENCH_CANADIAN = 3;

        /// SUBLANG_FRENCH_BELGIAN -> 0x02
        public const int SUBLANG_FRENCH_BELGIAN = 2;

        /// SUBLANG_FRENCH -> 0x01
        public const int SUBLANG_FRENCH = 1;

        /// SUBLANG_ENGLISH_ZIMBABWE -> 0x0c
        public const int SUBLANG_ENGLISH_ZIMBABWE = 12;

        /// SUBLANG_ENGLISH_US -> 0x01
        public const int SUBLANG_ENGLISH_US = 1;

        /// SUBLANG_ENGLISH_UK -> 0x02
        public const int SUBLANG_ENGLISH_UK = 2;

        /// SUBLANG_ENGLISH_TRINIDAD -> 0x0b
        public const int SUBLANG_ENGLISH_TRINIDAD = 11;

        /// SUBLANG_ENGLISH_SOUTH_AFRICA -> 0x07
        public const int SUBLANG_ENGLISH_SOUTH_AFRICA = 7;

        /// SUBLANG_ENGLISH_PHILIPPINES -> 0x0d
        public const int SUBLANG_ENGLISH_PHILIPPINES = 13;

        /// SUBLANG_ENGLISH_NZ -> 0x05
        public const int SUBLANG_ENGLISH_NZ = 5;

        /// SUBLANG_ENGLISH_JAMAICA -> 0x08
        public const int SUBLANG_ENGLISH_JAMAICA = 8;

        /// SUBLANG_ENGLISH_EIRE -> 0x06
        public const int SUBLANG_ENGLISH_EIRE = 6;

        /// SUBLANG_ENGLISH_CARIBBEAN -> 0x09
        public const int SUBLANG_ENGLISH_CARIBBEAN = 9;

        /// SUBLANG_ENGLISH_CAN -> 0x04
        public const int SUBLANG_ENGLISH_CAN = 4;

        /// SUBLANG_ENGLISH_BELIZE -> 0x0a
        public const int SUBLANG_ENGLISH_BELIZE = 10;

        /// SUBLANG_ENGLISH_AUS -> 0x03
        public const int SUBLANG_ENGLISH_AUS = 3;

        /// SUBLANG_DUTCH_BELGIAN -> 0x02
        public const int SUBLANG_DUTCH_BELGIAN = 2;

        /// SUBLANG_DUTCH -> 0x01
        public const int SUBLANG_DUTCH = 1;

        /// SUBLANG_DEFAULT -> 0x01
        public const int SUBLANG_DEFAULT = 1;

        /// SUBLANG_CHINESE_TRADITIONAL -> 0x01
        public const int SUBLANG_CHINESE_TRADITIONAL = 1;

        /// SUBLANG_CHINESE_SINGAPORE -> 0x04
        public const int SUBLANG_CHINESE_SINGAPORE = 4;

        /// SUBLANG_CHINESE_SIMPLIFIED -> 0x02
        public const int SUBLANG_CHINESE_SIMPLIFIED = 2;

        /// SUBLANG_CHINESE_MACAU -> 0x05
        public const int SUBLANG_CHINESE_MACAU = 5;

        /// SUBLANG_CHINESE_HONGKONG -> 0x03
        public const int SUBLANG_CHINESE_HONGKONG = 3;

        /// SUBLANG_AZERI_LATIN -> 0x01
        public const int SUBLANG_AZERI_LATIN = 1;

        /// SUBLANG_AZERI_CYRILLIC -> 0x02
        public const int SUBLANG_AZERI_CYRILLIC = 2;

        /// SUBLANG_ARABIC_YEMEN -> 0x09
        public const int SUBLANG_ARABIC_YEMEN = 9;

        /// SUBLANG_ARABIC_UAE -> 0x0e
        public const int SUBLANG_ARABIC_UAE = 14;

        /// SUBLANG_ARABIC_TUNISIA -> 0x07
        public const int SUBLANG_ARABIC_TUNISIA = 7;

        /// SUBLANG_ARABIC_SYRIA -> 0x0a
        public const int SUBLANG_ARABIC_SYRIA = 10;

        /// SUBLANG_ARABIC_SAUDI_ARABIA -> 0x01
        public const int SUBLANG_ARABIC_SAUDI_ARABIA = 1;

        /// SUBLANG_ARABIC_QATAR -> 0x10
        public const int SUBLANG_ARABIC_QATAR = 16;

        /// SUBLANG_ARABIC_OMAN -> 0x08
        public const int SUBLANG_ARABIC_OMAN = 8;

        /// SUBLANG_ARABIC_MOROCCO -> 0x06
        public const int SUBLANG_ARABIC_MOROCCO = 6;

        /// SUBLANG_ARABIC_LIBYA -> 0x04
        public const int SUBLANG_ARABIC_LIBYA = 4;

        /// SUBLANG_ARABIC_LEBANON -> 0x0c
        public const int SUBLANG_ARABIC_LEBANON = 12;

        /// SUBLANG_ARABIC_KUWAIT -> 0x0d
        public const int SUBLANG_ARABIC_KUWAIT = 13;

        /// SUBLANG_ARABIC_JORDAN -> 0x0b
        public const int SUBLANG_ARABIC_JORDAN = 11;

        /// SUBLANG_ARABIC_IRAQ -> 0x02
        public const int SUBLANG_ARABIC_IRAQ = 2;

        /// SUBLANG_ARABIC_EGYPT -> 0x03
        public const int SUBLANG_ARABIC_EGYPT = 3;

        /// SUBLANG_ARABIC_BAHRAIN -> 0x0f
        public const int SUBLANG_ARABIC_BAHRAIN = 15;

        /// SUBLANG_ARABIC_ALGERIA -> 0x05
        public const int SUBLANG_ARABIC_ALGERIA = 5;

        /// ST_TERMINATED -> 0x0020
        public const int ST_TERMINATED = 32;

        /// ST_ISSELF -> 0x0100
        public const int ST_ISSELF = 256;

        /// ST_ISLOCAL -> 0x0004
        public const int ST_ISLOCAL = 4;

        /// ST_INLIST -> 0x0040
        public const int ST_INLIST = 64;

        /// ST_CONNECTED -> 0x0001
        public const int ST_CONNECTED = 1;

        /// ST_CLIENT -> 0x0010
        public const int ST_CLIENT = 16;

        /// ST_BLOCKNEXT -> 0x0080
        public const int ST_BLOCKNEXT = 128;

        /// ST_BLOCKED -> 0x0008
        public const int ST_BLOCKED = 8;

        /// ST_ADVISE -> 0x0002
        public const int ST_ADVISE = 2;

        /// STYLE_DESCRIPTION_SIZE -> 32
        public const int STYLE_DESCRIPTION_SIZE = 32;

        /// STRICT -> 1
        public const int STRICT = 1;

        /// STRETCH_ORSCANS -> WHITEONBLACK
        public const int STRETCH_ORSCANS = NativeConstants.WHITEONBLACK;

        /// STRETCH_HALFTONE -> HALFTONE
        public const int STRETCH_HALFTONE = NativeConstants.HALFTONE;

        /// STRETCH_DELETESCANS -> COLORONCOLOR
        public const int STRETCH_DELETESCANS = NativeConstants.COLORONCOLOR;

        /// STRETCH_ANDSCANS -> BLACKONWHITE
        public const int STRETCH_ANDSCANS = NativeConstants.BLACKONWHITE;

        /// STRETCHBLT -> 2048
        public const int STRETCHBLT = 2048;

        /// STREAM_SPARSE_ATTRIBUTE -> 0x00000008
        public const int STREAM_SPARSE_ATTRIBUTE = 8;

        /// STREAM_SET_ENCRYPTION -> 0x00000003
        public const int STREAM_SET_ENCRYPTION = 3;

        /// STREAM_NORMAL_ATTRIBUTE -> 0x00000000
        public const int STREAM_NORMAL_ATTRIBUTE = 0;

        /// STREAM_MODIFIED_WHEN_READ -> 0x00000001
        public const int STREAM_MODIFIED_WHEN_READ = 1;

        /// STREAM_CONTAINS_SECURITY -> 0x00000002
        public const int STREAM_CONTAINS_SECURITY = 2;

        /// STREAM_CONTAINS_PROPERTIES -> 0x00000004
        public const int STREAM_CONTAINS_PROPERTIES = 4;

        /// STREAM_CLEAR_ENCRYPTION -> 0x00000004
        public const int STREAM_CLEAR_ENCRYPTION = 4;

        /// StoragePortClassGuid -> GUID_DEVINTERFACE_STORAGEPORT
        /// Error generating expression: Value GUID_DEVINTERFACE_STORAGEPORT is not resolved
        public const string StoragePortClassGuid = "GUID_DEVINTERFACE_STORAGEPORT";

        /// STOCK_LAST -> 19
        public const int STOCK_LAST = 19;

        /// STN_ENABLE -> 2
        public const int STN_ENABLE = 2;

        /// STN_DISABLE -> 3
        public const int STN_DISABLE = 3;

        /// STN_DBLCLK -> 1
        public const int STN_DBLCLK = 1;

        /// STN_CLICKED -> 0
        public const int STN_CLICKED = 0;

        /// STM_SETIMAGE -> 0x0172
        public const int STM_SETIMAGE = 370;

        /// STM_SETICON -> 0x0170
        public const int STM_SETICON = 368;

        /// STM_MSGMAX -> 0x0174
        public const int STM_MSGMAX = 372;

        /// STM_GETIMAGE -> 0x0173
        public const int STM_GETIMAGE = 371;

        /// STM_GETICON -> 0x0171
        public const int STM_GETICON = 369;

        /// STILL_ACTIVE -> STATUS_PENDING
        public const string STILL_ACTIVE = NativeConstants.STATUS_PENDING;

        /// STG_TOEND -> 0xFFFFFFFFL
        public const int STG_TOEND = -1;

        /// STG_LAYOUT_SEQUENTIAL -> 0x00000000L
        public const int STG_LAYOUT_SEQUENTIAL = 0;

        /// STG_LAYOUT_INTERLEAVED -> 0x00000001L
        public const int STG_LAYOUT_INTERLEAVED = 1;

        /// STGTY_REPEAT -> 0x00000100L
        public const int STGTY_REPEAT = 256;

        /// STGOPTIONS_VERSION -> 2
        public const int STGOPTIONS_VERSION = 2;

        /// STGM_WRITE -> 0x00000001L
        public const int STGM_WRITE = 1;

        /// STGM_TRANSACTED -> 0x00010000L
        public const int STGM_TRANSACTED = 65536;

        /// STGM_SIMPLE -> 0x08000000L
        public const int STGM_SIMPLE = 134217728;

        /// STGM_SHARE_EXCLUSIVE -> 0x00000010L
        public const int STGM_SHARE_EXCLUSIVE = 16;

        /// STGM_SHARE_DENY_WRITE -> 0x00000020L
        public const int STGM_SHARE_DENY_WRITE = 32;

        /// STGM_SHARE_DENY_READ -> 0x00000030L
        public const int STGM_SHARE_DENY_READ = 48;

        /// STGM_SHARE_DENY_NONE -> 0x00000040L
        public const int STGM_SHARE_DENY_NONE = 64;

        /// STGM_READWRITE -> 0x00000002L
        public const int STGM_READWRITE = 2;

        /// STGM_READ -> 0x00000000L
        public const int STGM_READ = 0;

        /// STGM_PRIORITY -> 0x00040000L
        public const int STGM_PRIORITY = 262144;

        /// STGM_NOSNAPSHOT -> 0x00200000L
        public const int STGM_NOSNAPSHOT = 2097152;

        /// STGM_NOSCRATCH -> 0x00100000L
        public const int STGM_NOSCRATCH = 1048576;

        /// STGM_FAILIFTHERE -> 0x00000000L
        public const int STGM_FAILIFTHERE = 0;

        /// STGM_DIRECT_SWMR -> 0x00400000L
        public const int STGM_DIRECT_SWMR = 4194304;

        /// STGM_DIRECT -> 0x00000000L
        public const int STGM_DIRECT = 0;

        /// STGM_DELETEONRELEASE -> 0x04000000L
        public const int STGM_DELETEONRELEASE = 67108864;

        /// STGM_CREATE -> 0x00001000L
        public const int STGM_CREATE = 4096;

        /// STGM_CONVERT -> 0x00020000L
        public const int STGM_CONVERT = 131072;

        /// STGFMT_STORAGE -> 0
        public const int STGFMT_STORAGE = 0;

        /// STGFMT_NATIVE -> 1
        public const int STGFMT_NATIVE = 1;

        /// STGFMT_FILE -> 3
        public const int STGFMT_FILE = 3;

        /// STGFMT_DOCUMENT -> 0
        public const int STGFMT_DOCUMENT = 0;

        /// STGFMT_DOCFILE -> 5
        public const int STGFMT_DOCFILE = 5;

        /// STGFMT_ANY -> 4
        public const int STGFMT_ANY = 4;

        /// STD_OUTPUT_HANDLE -> ((DWORD)-11)
        /// Error generating expression: Value DWORD is not resolved
        public const string STD_OUTPUT_HANDLE = "((DWORD)-11)";

        /// STD_INPUT_HANDLE -> ((DWORD)-10)
        /// Error generating expression: Value DWORD is not resolved
        public const string STD_INPUT_HANDLE = "((DWORD)-10)";

        /// STD_ERROR_HANDLE -> ((DWORD)-12)
        /// Error generating expression: Value DWORD is not resolved
        public const string STD_ERROR_HANDLE = "((DWORD)-12)";

        /// STDOLE_MINORVERNUM -> 0x0
        public const int STDOLE_MINORVERNUM = 0;

        /// STDOLE_MAJORVERNUM -> 0x1
        public const int STDOLE_MAJORVERNUM = 1;

        /// STDOLE_LCID -> 0x0000
        public const int STDOLE_LCID = 0;

        /// STDOLE2_MINORVERNUM -> 0x0
        public const int STDOLE2_MINORVERNUM = 0;

        /// STDOLE2_MAJORVERNUM -> 0x2
        public const int STDOLE2_MAJORVERNUM = 2;

        /// STDOLE2_LCID -> 0x0000
        public const int STDOLE2_LCID = 0;

        /// STDMETHODVCALLTYPE -> __cdecl
        /// Error generating expression: Value __cdecl is not resolved
        public const string STDMETHODVCALLTYPE = "__cdecl";

        /// STDMETHODCALLTYPE -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string STDMETHODCALLTYPE = "__stdcall";

        /// STDAPIVCALLTYPE -> __cdecl
        /// Error generating expression: Value __cdecl is not resolved
        public const string STDAPIVCALLTYPE = "__cdecl";

        /// STDAPICALLTYPE -> __stdcall
        /// Error generating expression: Value __stdcall is not resolved
        public const string STDAPICALLTYPE = "__stdcall";

        /// stc9 -> 0x0448
        public const int stc9 = 1096;

        /// stc8 -> 0x0447
        public const int stc8 = 1095;

        /// stc7 -> 0x0446
        public const int stc7 = 1094;

        /// stc6 -> 0x0445
        public const int stc6 = 1093;

        /// stc5 -> 0x0444
        public const int stc5 = 1092;

        /// stc4 -> 0x0443
        public const int stc4 = 1091;

        /// stc32 -> 0x045f
        public const int stc32 = 1119;

        /// stc31 -> 0x045e
        public const int stc31 = 1118;

        /// stc30 -> 0x045d
        public const int stc30 = 1117;

        /// stc3 -> 0x0442
        public const int stc3 = 1090;

        /// stc29 -> 0x045c
        public const int stc29 = 1116;

        /// stc28 -> 0x045b
        public const int stc28 = 1115;

        /// stc27 -> 0x045a
        public const int stc27 = 1114;

        /// stc26 -> 0x0459
        public const int stc26 = 1113;

        /// stc25 -> 0x0458
        public const int stc25 = 1112;

        /// stc24 -> 0x0457
        public const int stc24 = 1111;

        /// stc23 -> 0x0456
        public const int stc23 = 1110;

        /// stc22 -> 0x0455
        public const int stc22 = 1109;

        /// stc21 -> 0x0454
        public const int stc21 = 1108;

        /// stc20 -> 0x0453
        public const int stc20 = 1107;

        /// stc2 -> 0x0441
        public const int stc2 = 1089;

        /// stc19 -> 0x0452
        public const int stc19 = 1106;

        /// stc18 -> 0x0451
        public const int stc18 = 1105;

        /// stc17 -> 0x0450
        public const int stc17 = 1104;

        /// stc16 -> 0x044f
        public const int stc16 = 1103;

        /// stc15 -> 0x044e
        public const int stc15 = 1102;

        /// stc14 -> 0x044d
        public const int stc14 = 1101;

        /// stc13 -> 0x044c
        public const int stc13 = 1100;

        /// stc12 -> 0x044b
        public const int stc12 = 1099;

        /// stc11 -> 0x044a
        public const int stc11 = 1098;

        /// stc10 -> 0x0449
        public const int stc10 = 1097;

        /// stc1 -> 0x0440
        public const int stc1 = 1088;

        /// STATE_SYSTEM_VALID -> 0x3FFFFFFF
        public const int STATE_SYSTEM_VALID = 1073741823;

        /// STATE_SYSTEM_UNAVAILABLE -> 0x00000001
        public const int STATE_SYSTEM_UNAVAILABLE = 1;

        /// STATE_SYSTEM_TRAVERSED -> 0x00800000
        public const int STATE_SYSTEM_TRAVERSED = 8388608;

        /// STATE_SYSTEM_SIZEABLE -> 0x00020000
        public const int STATE_SYSTEM_SIZEABLE = 131072;

        /// STATE_SYSTEM_SELFVOICING -> 0x00080000
        public const int STATE_SYSTEM_SELFVOICING = 524288;

        /// STATE_SYSTEM_SELECTED -> 0x00000002
        public const int STATE_SYSTEM_SELECTED = 2;

        /// STATE_SYSTEM_SELECTABLE -> 0x00200000
        public const int STATE_SYSTEM_SELECTABLE = 2097152;

        /// STATE_SYSTEM_READONLY -> 0x00000040
        public const int STATE_SYSTEM_READONLY = 64;

        /// STATE_SYSTEM_PROTECTED -> 0x20000000
        public const int STATE_SYSTEM_PROTECTED = 536870912;

        /// STATE_SYSTEM_PRESSED -> 0x00000008
        public const int STATE_SYSTEM_PRESSED = 8;

        /// STATE_SYSTEM_OFFSCREEN -> 0x00010000
        public const int STATE_SYSTEM_OFFSCREEN = 65536;

        /// STATE_SYSTEM_MULTISELECTABLE -> 0x01000000
        public const int STATE_SYSTEM_MULTISELECTABLE = 16777216;

        /// STATE_SYSTEM_MOVEABLE -> 0x00040000
        public const int STATE_SYSTEM_MOVEABLE = 262144;

        /// STATE_SYSTEM_MIXED -> 0x00000020
        public const int STATE_SYSTEM_MIXED = 32;

        /// STATE_SYSTEM_MARQUEED -> 0x00002000
        public const int STATE_SYSTEM_MARQUEED = 8192;

        /// STATE_SYSTEM_LINKED -> 0x00400000
        public const int STATE_SYSTEM_LINKED = 4194304;

        /// STATE_SYSTEM_INVISIBLE -> 0x00008000
        public const int STATE_SYSTEM_INVISIBLE = 32768;

        /// STATE_SYSTEM_INDETERMINATE -> STATE_SYSTEM_MIXED
        public const int STATE_SYSTEM_INDETERMINATE = NativeConstants.STATE_SYSTEM_MIXED;

        /// STATE_SYSTEM_HOTTRACKED -> 0x00000080
        public const int STATE_SYSTEM_HOTTRACKED = 128;

        /// STATE_SYSTEM_FOCUSED -> 0x00000004
        public const int STATE_SYSTEM_FOCUSED = 4;

        /// STATE_SYSTEM_FOCUSABLE -> 0x00100000
        public const int STATE_SYSTEM_FOCUSABLE = 1048576;

        /// STATE_SYSTEM_FLOATING -> 0x00001000
        public const int STATE_SYSTEM_FLOATING = 4096;

        /// STATE_SYSTEM_EXTSELECTABLE -> 0x02000000
        public const int STATE_SYSTEM_EXTSELECTABLE = 33554432;

        /// STATE_SYSTEM_EXPANDED -> 0x00000200
        public const int STATE_SYSTEM_EXPANDED = 512;

        /// STATE_SYSTEM_DEFAULT -> 0x00000100
        public const int STATE_SYSTEM_DEFAULT = 256;

        /// STATE_SYSTEM_COLLAPSED -> 0x00000400
        public const int STATE_SYSTEM_COLLAPSED = 1024;

        /// STATE_SYSTEM_CHECKED -> 0x00000010
        public const int STATE_SYSTEM_CHECKED = 16;

        /// STATE_SYSTEM_BUSY -> 0x00000800
        public const int STATE_SYSTEM_BUSY = 2048;

        /// STATE_SYSTEM_ANIMATED -> 0x00004000
        public const int STATE_SYSTEM_ANIMATED = 16384;

        /// STATE_SYSTEM_ALERT_MEDIUM -> 0x08000000
        public const int STATE_SYSTEM_ALERT_MEDIUM = 134217728;

        /// STATE_SYSTEM_ALERT_LOW -> 0x04000000
        public const int STATE_SYSTEM_ALERT_LOW = 67108864;

        /// STATE_SYSTEM_ALERT_HIGH -> 0x10000000
        public const int STATE_SYSTEM_ALERT_HIGH = 268435456;

        /// START_PAGE_GENERAL -> 0xffffffff
        public const int START_PAGE_GENERAL = -1;

        /// StartServiceCtrlDispatcher -> StartServiceCtrlDispatcherW
        /// Error generating expression: Value StartServiceCtrlDispatcherW is not resolved
        public const string StartServiceCtrlDispatcher = "StartServiceCtrlDispatcherW";

        /// StartService -> StartServiceW
        /// Error generating expression: Value StartServiceW is not resolved
        public const string StartService = "StartServiceW";

        /// STARTF_USESTDHANDLES -> 0x00000100
        public const int STARTF_USESTDHANDLES = 256;

        /// STARTF_USESIZE -> 0x00000002
        public const int STARTF_USESIZE = 2;

        /// STARTF_USESHOWWINDOW -> 0x00000001
        public const int STARTF_USESHOWWINDOW = 1;

        /// STARTF_USEPOSITION -> 0x00000004
        public const int STARTF_USEPOSITION = 4;

        /// STARTF_USEHOTKEY -> 0x00000200
        public const int STARTF_USEHOTKEY = 512;

        /// STARTF_USEFILLATTRIBUTE -> 0x00000010
        public const int STARTF_USEFILLATTRIBUTE = 16;

        /// STARTF_USECOUNTCHARS -> 0x00000008
        public const int STARTF_USECOUNTCHARS = 8;

        /// STARTF_RUNFULLSCREEN -> 0x00000020
        public const int STARTF_RUNFULLSCREEN = 32;

        /// STARTF_FORCEONFEEDBACK -> 0x00000040
        public const int STARTF_FORCEONFEEDBACK = 64;

        /// STARTF_FORCEOFFFEEDBACK -> 0x00000080
        public const int STARTF_FORCEOFFFEEDBACK = 128;

        /// StartDocPrinter -> StartDocPrinterW
        /// Error generating expression: Value StartDocPrinterW is not resolved
        public const string StartDocPrinter = "StartDocPrinterW";

        /// StartDoc -> StartDocW
        /// Error generating expression: Value StartDocW is not resolved
        public const string StartDoc = "StartDocW";

        /// STARTDOC -> 10
        public const int STARTDOC = 10;

        /// STANDARD_RIGHTS_WRITE -> (READ_CONTROL)
        public const int STANDARD_RIGHTS_WRITE = NativeConstants.READ_CONTROL;

        /// STANDARD_RIGHTS_REQUIRED -> (0x000F0000L)
        public const int STANDARD_RIGHTS_REQUIRED = 983040;

        /// STANDARD_RIGHTS_READ -> (READ_CONTROL)
        public const int STANDARD_RIGHTS_READ = NativeConstants.READ_CONTROL;

        /// STANDARD_RIGHTS_EXECUTE -> (READ_CONTROL)
        public const int STANDARD_RIGHTS_EXECUTE = NativeConstants.READ_CONTROL;

        /// STANDARD_RIGHTS_ALL -> (0x001F0000L)
        public const int STANDARD_RIGHTS_ALL = 2031616;

        /// STAMP_DESIGNVECTOR -> (0x8000000 + 'd' + ('v' << 8))
        public const int STAMP_DESIGNVECTOR = (134217728
                    + ('d' + ('v') << (8)));

        /// STAMP_AXESLIST -> (0x8000000 + 'a' + ('l' << 8))
        public const int STAMP_AXESLIST = (134217728
                    + ('a' + ('l') << (8)));

        /// STACK_SIZE_PARAM_IS_A_RESERVATION -> 0x00010000
        public const int STACK_SIZE_PARAM_IS_A_RESERVATION = 65536;

        /// SS_WORDELLIPSIS -> 0x0000C000L
        public const int SS_WORDELLIPSIS = 49152;

        /// SS_WHITERECT -> 0x00000006L
        public const int SS_WHITERECT = 6;

        /// SS_WHITEFRAME -> 0x00000009L
        public const int SS_WHITEFRAME = 9;

        /// SS_USERITEM -> 0x0000000AL
        public const int SS_USERITEM = 10;

        /// SS_TYPEMASK -> 0x0000001FL
        public const int SS_TYPEMASK = 31;

        /// SS_SUNKEN -> 0x00001000L
        public const int SS_SUNKEN = 4096;

        /// SS_SIMPLE -> 0x0000000BL
        public const int SS_SIMPLE = 11;

        /// SS_RIGHTJUST -> 0x00000400L
        public const int SS_RIGHTJUST = 1024;

        /// SS_RIGHT -> 0x00000002L
        public const int SS_RIGHT = 2;

        /// SS_REALSIZEIMAGE -> 0x00000800L
        public const int SS_REALSIZEIMAGE = 2048;

        /// SS_REALSIZECONTROL -> 0x00000040L
        public const int SS_REALSIZECONTROL = 64;

        /// SS_PATHELLIPSIS -> 0x00008000L
        public const int SS_PATHELLIPSIS = 32768;

        /// SS_OWNERDRAW -> 0x0000000DL
        public const int SS_OWNERDRAW = 13;

        /// SS_NOTIFY -> 0x00000100L
        public const int SS_NOTIFY = 256;

        /// SS_NOPREFIX -> 0x00000080L
        public const int SS_NOPREFIX = 128;

        /// SS_LEFTNOWORDWRAP -> 0x0000000CL
        public const int SS_LEFTNOWORDWRAP = 12;

        /// SS_LEFT -> 0x00000000L
        public const int SS_LEFT = 0;

        /// SS_ICON -> 0x00000003L
        public const int SS_ICON = 3;

        /// SS_GRAYRECT -> 0x00000005L
        public const int SS_GRAYRECT = 5;

        /// SS_GRAYFRAME -> 0x00000008L
        public const int SS_GRAYFRAME = 8;

        /// SS_ETCHEDVERT -> 0x00000011L
        public const int SS_ETCHEDVERT = 17;

        /// SS_ETCHEDHORZ -> 0x00000010L
        public const int SS_ETCHEDHORZ = 16;

        /// SS_ETCHEDFRAME -> 0x00000012L
        public const int SS_ETCHEDFRAME = 18;

        /// SS_ENHMETAFILE -> 0x0000000FL
        public const int SS_ENHMETAFILE = 15;

        /// SS_ENDELLIPSIS -> 0x00004000L
        public const int SS_ENDELLIPSIS = 16384;

        /// SS_ELLIPSISMASK -> 0x0000C000L
        public const int SS_ELLIPSISMASK = 49152;

        /// SS_EDITCONTROL -> 0x00002000L
        public const int SS_EDITCONTROL = 8192;

        /// SS_CENTERIMAGE -> 0x00000200L
        public const int SS_CENTERIMAGE = 512;

        /// SS_CENTER -> 0x00000001L
        public const int SS_CENTER = 1;

        /// SS_BLACKRECT -> 0x00000004L
        public const int SS_BLACKRECT = 4;

        /// SS_BLACKFRAME -> 0x00000007L
        public const int SS_BLACKFRAME = 7;

        /// SS_BITMAP -> 0x0000000EL
        public const int SS_BITMAP = 14;

        /// SSWF_WINDOW -> 2
        public const int SSWF_WINDOW = 2;

        /// SSWF_TITLE -> 1
        public const int SSWF_TITLE = 1;

        /// SSWF_NONE -> 0
        public const int SSWF_NONE = 0;

        /// SSWF_DISPLAY -> 3
        public const int SSWF_DISPLAY = 3;

        /// SSWF_CUSTOM -> 4
        public const int SSWF_CUSTOM = 4;

        /// SSTF_NONE -> 0
        public const int SSTF_NONE = 0;

        /// SSTF_DISPLAY -> 3
        public const int SSTF_DISPLAY = 3;

        /// SSTF_CHARS -> 1
        public const int SSTF_CHARS = 1;

        /// SSTF_BORDER -> 2
        public const int SSTF_BORDER = 2;

        /// SSGF_NONE -> 0
        public const int SSGF_NONE = 0;

        /// SSGF_DISPLAY -> 3
        public const int SSGF_DISPLAY = 3;

        /// SSF_SOUNDSENTRYON -> 0x00000001
        public const int SSF_SOUNDSENTRYON = 1;

        /// SSF_INDICATOR -> 0x00000004
        public const int SSF_INDICATOR = 4;

        /// SSF_AVAILABLE -> 0x00000002
        public const int SSF_AVAILABLE = 2;

        /// SP_USERABORT -> (-3)
        public const int SP_USERABORT = -3;

        /// SP_OUTOFMEMORY -> (-5)
        public const int SP_OUTOFMEMORY = -5;

        /// SP_OUTOFDISK -> (-4)
        public const int SP_OUTOFDISK = -4;

        /// SP_NOTREPORTED -> 0x4000
        public const int SP_NOTREPORTED = 16384;

        /// SP_ERROR -> (-1)
        public const int SP_ERROR = -1;

        /// SP_APPABORT -> (-2)
        public const int SP_APPABORT = -2;

        /// SPOOL_FILE_TEMPORARY -> 0x00000002
        public const int SPOOL_FILE_TEMPORARY = 2;

        /// SPOOL_FILE_PERSISTENT -> 0x00000001
        public const int SPOOL_FILE_PERSISTENT = 1;

        /// SPI_SETWORKAREA -> 0x002F
        public const int SPI_SETWORKAREA = 47;

        /// SPI_SETWHEELSCROLLLINES -> 0x0069
        public const int SPI_SETWHEELSCROLLLINES = 105;

        /// SPI_SETUIEFFECTS -> 0x103F
        public const int SPI_SETUIEFFECTS = 4159;

        /// SPI_SETTOOLTIPFADE -> 0x1019
        public const int SPI_SETTOOLTIPFADE = 4121;

        /// SPI_SETTOOLTIPANIMATION -> 0x1017
        public const int SPI_SETTOOLTIPANIMATION = 4119;

        /// SPI_SETTOGGLEKEYS -> 0x0035
        public const int SPI_SETTOGGLEKEYS = 53;

        /// SPI_SETSTICKYKEYS -> 0x003B
        public const int SPI_SETSTICKYKEYS = 59;

        /// SPI_SETSOUNDSENTRY -> 0x0041
        public const int SPI_SETSOUNDSENTRY = 65;

        /// SPI_SETSNAPTODEFBUTTON -> 0x0060
        public const int SPI_SETSNAPTODEFBUTTON = 96;

        /// SPI_SETSHOWSOUNDS -> 0x0039
        public const int SPI_SETSHOWSOUNDS = 57;

        /// SPI_SETSHOWIMEUI -> 0x006F
        public const int SPI_SETSHOWIMEUI = 111;

        /// SPI_SETSERIALKEYS -> 0x003F
        public const int SPI_SETSERIALKEYS = 63;

        /// SPI_SETSELECTIONFADE -> 0x1015
        public const int SPI_SETSELECTIONFADE = 4117;

        /// SPI_SETSCREENSAVETIMEOUT -> 0x000F
        public const int SPI_SETSCREENSAVETIMEOUT = 15;

        /// SPI_SETSCREENSAVERRUNNING -> 0x0061
        public const int SPI_SETSCREENSAVERRUNNING = 97;

        /// SPI_SETSCREENSAVEACTIVE -> 0x0011
        public const int SPI_SETSCREENSAVEACTIVE = 17;

        /// SPI_SETSCREENREADER -> 0x0047
        public const int SPI_SETSCREENREADER = 71;

        /// SPI_SETPOWEROFFTIMEOUT -> 0x0052
        public const int SPI_SETPOWEROFFTIMEOUT = 82;

        /// SPI_SETPOWEROFFACTIVE -> 0x0056
        public const int SPI_SETPOWEROFFACTIVE = 86;

        /// SPI_SETPENWINDOWS -> 0x0031
        public const int SPI_SETPENWINDOWS = 49;

        /// SPI_SETNONCLIENTMETRICS -> 0x002A
        public const int SPI_SETNONCLIENTMETRICS = 42;

        /// SPI_SETMOUSEVANISH -> 0x1021
        public const int SPI_SETMOUSEVANISH = 4129;

        /// SPI_SETMOUSETRAILS -> 0x005D
        public const int SPI_SETMOUSETRAILS = 93;

        /// SPI_SETMOUSESPEED -> 0x0071
        public const int SPI_SETMOUSESPEED = 113;

        /// SPI_SETMOUSESONAR -> 0x101D
        public const int SPI_SETMOUSESONAR = 4125;

        /// SPI_SETMOUSEKEYS -> 0x0037
        public const int SPI_SETMOUSEKEYS = 55;

        /// SPI_SETMOUSEHOVERWIDTH -> 0x0063
        public const int SPI_SETMOUSEHOVERWIDTH = 99;

        /// SPI_SETMOUSEHOVERTIME -> 0x0067
        public const int SPI_SETMOUSEHOVERTIME = 103;

        /// SPI_SETMOUSEHOVERHEIGHT -> 0x0065
        public const int SPI_SETMOUSEHOVERHEIGHT = 101;

        /// SPI_SETMOUSECLICKLOCKTIME -> 0x2009
        public const int SPI_SETMOUSECLICKLOCKTIME = 8201;

        /// SPI_SETMOUSECLICKLOCK -> 0x101F
        public const int SPI_SETMOUSECLICKLOCK = 4127;

        /// SPI_SETMOUSEBUTTONSWAP -> 0x0021
        public const int SPI_SETMOUSEBUTTONSWAP = 33;

        /// SPI_SETMOUSE -> 0x0004
        public const int SPI_SETMOUSE = 4;

        /// SPI_SETMINIMIZEDMETRICS -> 0x002C
        public const int SPI_SETMINIMIZEDMETRICS = 44;

        /// SPI_SETMENUUNDERLINES -> SPI_SETKEYBOARDCUES
        public const int SPI_SETMENUUNDERLINES = NativeConstants.SPI_SETKEYBOARDCUES;

        /// SPI_SETMENUSHOWDELAY -> 0x006B
        public const int SPI_SETMENUSHOWDELAY = 107;

        /// SPI_SETMENUFADE -> 0x1013
        public const int SPI_SETMENUFADE = 4115;

        /// SPI_SETMENUDROPALIGNMENT -> 0x001C
        public const int SPI_SETMENUDROPALIGNMENT = 28;

        /// SPI_SETMENUANIMATION -> 0x1003
        public const int SPI_SETMENUANIMATION = 4099;

        /// SPI_SETLOWPOWERTIMEOUT -> 0x0051
        public const int SPI_SETLOWPOWERTIMEOUT = 81;

        /// SPI_SETLOWPOWERACTIVE -> 0x0055
        public const int SPI_SETLOWPOWERACTIVE = 85;

        /// SPI_SETLISTBOXSMOOTHSCROLLING -> 0x1007
        public const int SPI_SETLISTBOXSMOOTHSCROLLING = 4103;

        /// SPI_SETLANGTOGGLE -> 0x005B
        public const int SPI_SETLANGTOGGLE = 91;

        /// SPI_SETKEYBOARDSPEED -> 0x000B
        public const int SPI_SETKEYBOARDSPEED = 11;

        /// SPI_SETKEYBOARDPREF -> 0x0045
        public const int SPI_SETKEYBOARDPREF = 69;

        /// SPI_SETKEYBOARDDELAY -> 0x0017
        public const int SPI_SETKEYBOARDDELAY = 23;

        /// SPI_SETKEYBOARDCUES -> 0x100B
        public const int SPI_SETKEYBOARDCUES = 4107;

        /// SPI_SETICONTITLEWRAP -> 0x001A
        public const int SPI_SETICONTITLEWRAP = 26;

        /// SPI_SETICONTITLELOGFONT -> 0x0022
        public const int SPI_SETICONTITLELOGFONT = 34;

        /// SPI_SETICONS -> 0x0058
        public const int SPI_SETICONS = 88;

        /// SPI_SETICONMETRICS -> 0x002E
        public const int SPI_SETICONMETRICS = 46;

        /// SPI_SETHOTTRACKING -> 0x100F
        public const int SPI_SETHOTTRACKING = 4111;

        /// SPI_SETHIGHCONTRAST -> 0x0043
        public const int SPI_SETHIGHCONTRAST = 67;

        /// SPI_SETHANDHELD -> 0x004E
        public const int SPI_SETHANDHELD = 78;

        /// SPI_SETGRIDGRANULARITY -> 0x0013
        public const int SPI_SETGRIDGRANULARITY = 19;

        /// SPI_SETGRADIENTCAPTIONS -> 0x1009
        public const int SPI_SETGRADIENTCAPTIONS = 4105;

        /// SPI_SETFOREGROUNDLOCKTIMEOUT -> 0x2001
        public const int SPI_SETFOREGROUNDLOCKTIMEOUT = 8193;

        /// SPI_SETFOREGROUNDFLASHCOUNT -> 0x2005
        public const int SPI_SETFOREGROUNDFLASHCOUNT = 8197;

        /// SPI_SETFONTSMOOTHINGTYPE -> 0x200B
        public const int SPI_SETFONTSMOOTHINGTYPE = 8203;

        /// SPI_SETFONTSMOOTHINGORIENTATION -> 0x2013
        public const int SPI_SETFONTSMOOTHINGORIENTATION = 8211;

        /// SPI_SETFONTSMOOTHINGCONTRAST -> 0x200D
        public const int SPI_SETFONTSMOOTHINGCONTRAST = 8205;

        /// SPI_SETFONTSMOOTHING -> 0x004B
        public const int SPI_SETFONTSMOOTHING = 75;

        /// SPI_SETFOCUSBORDERWIDTH -> 0x200F
        public const int SPI_SETFOCUSBORDERWIDTH = 8207;

        /// SPI_SETFOCUSBORDERHEIGHT -> 0x2011
        public const int SPI_SETFOCUSBORDERHEIGHT = 8209;

        /// SPI_SETFLATMENU -> 0x1023
        public const int SPI_SETFLATMENU = 4131;

        /// SPI_SETFILTERKEYS -> 0x0033
        public const int SPI_SETFILTERKEYS = 51;

        /// SPI_SETFASTTASKSWITCH -> 0x0024
        public const int SPI_SETFASTTASKSWITCH = 36;

        /// SPI_SETDROPSHADOW -> 0x1025
        public const int SPI_SETDROPSHADOW = 4133;

        /// SPI_SETDRAGWIDTH -> 0x004C
        public const int SPI_SETDRAGWIDTH = 76;

        /// SPI_SETDRAGHEIGHT -> 0x004D
        public const int SPI_SETDRAGHEIGHT = 77;

        /// SPI_SETDRAGFULLWINDOWS -> 0x0025
        public const int SPI_SETDRAGFULLWINDOWS = 37;

        /// SPI_SETDOUBLECLKWIDTH -> 0x001D
        public const int SPI_SETDOUBLECLKWIDTH = 29;

        /// SPI_SETDOUBLECLKHEIGHT -> 0x001E
        public const int SPI_SETDOUBLECLKHEIGHT = 30;

        /// SPI_SETDOUBLECLICKTIME -> 0x0020
        public const int SPI_SETDOUBLECLICKTIME = 32;

        /// SPI_SETDESKWALLPAPER -> 0x0014
        public const int SPI_SETDESKWALLPAPER = 20;

        /// SPI_SETDESKPATTERN -> 0x0015
        public const int SPI_SETDESKPATTERN = 21;

        /// SPI_SETDEFAULTINPUTLANG -> 0x005A
        public const int SPI_SETDEFAULTINPUTLANG = 90;

        /// SPI_SETCURSORSHADOW -> 0x101B
        public const int SPI_SETCURSORSHADOW = 4123;

        /// SPI_SETCURSORS -> 0x0057
        public const int SPI_SETCURSORS = 87;

        /// SPI_SETCOMBOBOXANIMATION -> 0x1005
        public const int SPI_SETCOMBOBOXANIMATION = 4101;

        /// SPI_SETCARETWIDTH -> 0x2007
        public const int SPI_SETCARETWIDTH = 8199;

        /// SPI_SETBORDER -> 0x0006
        public const int SPI_SETBORDER = 6;

        /// SPI_SETBLOCKSENDINPUTRESETS -> 0x1027
        public const int SPI_SETBLOCKSENDINPUTRESETS = 4135;

        /// SPI_SETBEEP -> 0x0002
        public const int SPI_SETBEEP = 2;

        /// SPI_SETANIMATION -> 0x0049
        public const int SPI_SETANIMATION = 73;

        /// SPI_SETACTIVEWNDTRKZORDER -> 0x100D
        public const int SPI_SETACTIVEWNDTRKZORDER = 4109;

        /// SPI_SETACTIVEWNDTRKTIMEOUT -> 0x2003
        public const int SPI_SETACTIVEWNDTRKTIMEOUT = 8195;

        /// SPI_SETACTIVEWINDOWTRACKING -> 0x1001
        public const int SPI_SETACTIVEWINDOWTRACKING = 4097;

        /// SPI_SETACCESSTIMEOUT -> 0x003D
        public const int SPI_SETACCESSTIMEOUT = 61;

        /// SPI_SCREENSAVERRUNNING -> SPI_SETSCREENSAVERRUNNING
        public const int SPI_SCREENSAVERRUNNING = NativeConstants.SPI_SETSCREENSAVERRUNNING;

        /// SPI_LANGDRIVER -> 0x000C
        public const int SPI_LANGDRIVER = 12;

        /// SPI_ICONVERTICALSPACING -> 0x0018
        public const int SPI_ICONVERTICALSPACING = 24;

        /// SPI_ICONHORIZONTALSPACING -> 0x000D
        public const int SPI_ICONHORIZONTALSPACING = 13;

        /// SPI_GETWORKAREA -> 0x0030
        public const int SPI_GETWORKAREA = 48;

        /// SPI_GETWINDOWSEXTENSION -> 0x005C
        public const int SPI_GETWINDOWSEXTENSION = 92;

        /// SPI_GETWHEELSCROLLLINES -> 0x0068
        public const int SPI_GETWHEELSCROLLLINES = 104;

        /// SPI_GETUIEFFECTS -> 0x103E
        public const int SPI_GETUIEFFECTS = 4158;

        /// SPI_GETTOOLTIPFADE -> 0x1018
        public const int SPI_GETTOOLTIPFADE = 4120;

        /// SPI_GETTOOLTIPANIMATION -> 0x1016
        public const int SPI_GETTOOLTIPANIMATION = 4118;

        /// SPI_GETTOGGLEKEYS -> 0x0034
        public const int SPI_GETTOGGLEKEYS = 52;

        /// SPI_GETSTICKYKEYS -> 0x003A
        public const int SPI_GETSTICKYKEYS = 58;

        /// SPI_GETSOUNDSENTRY -> 0x0040
        public const int SPI_GETSOUNDSENTRY = 64;

        /// SPI_GETSNAPTODEFBUTTON -> 0x005F
        public const int SPI_GETSNAPTODEFBUTTON = 95;

        /// SPI_GETSHOWSOUNDS -> 0x0038
        public const int SPI_GETSHOWSOUNDS = 56;

        /// SPI_GETSHOWIMEUI -> 0x006E
        public const int SPI_GETSHOWIMEUI = 110;

        /// SPI_GETSERIALKEYS -> 0x003E
        public const int SPI_GETSERIALKEYS = 62;

        /// SPI_GETSELECTIONFADE -> 0x1014
        public const int SPI_GETSELECTIONFADE = 4116;

        /// SPI_GETSCREENSAVETIMEOUT -> 0x000E
        public const int SPI_GETSCREENSAVETIMEOUT = 14;

        /// SPI_GETSCREENSAVERRUNNING -> 0x0072
        public const int SPI_GETSCREENSAVERRUNNING = 114;

        /// SPI_GETSCREENSAVEACTIVE -> 0x0010
        public const int SPI_GETSCREENSAVEACTIVE = 16;

        /// SPI_GETSCREENREADER -> 0x0046
        public const int SPI_GETSCREENREADER = 70;

        /// SPI_GETPOWEROFFTIMEOUT -> 0x0050
        public const int SPI_GETPOWEROFFTIMEOUT = 80;

        /// SPI_GETPOWEROFFACTIVE -> 0x0054
        public const int SPI_GETPOWEROFFACTIVE = 84;

        /// SPI_GETNONCLIENTMETRICS -> 0x0029
        public const int SPI_GETNONCLIENTMETRICS = 41;

        /// SPI_GETMOUSEVANISH -> 0x1020
        public const int SPI_GETMOUSEVANISH = 4128;

        /// SPI_GETMOUSETRAILS -> 0x005E
        public const int SPI_GETMOUSETRAILS = 94;

        /// SPI_GETMOUSESPEED -> 0x0070
        public const int SPI_GETMOUSESPEED = 112;

        /// SPI_GETMOUSESONAR -> 0x101C
        public const int SPI_GETMOUSESONAR = 4124;

        /// SPI_GETMOUSEKEYS -> 0x0036
        public const int SPI_GETMOUSEKEYS = 54;

        /// SPI_GETMOUSEHOVERWIDTH -> 0x0062
        public const int SPI_GETMOUSEHOVERWIDTH = 98;

        /// SPI_GETMOUSEHOVERTIME -> 0x0066
        public const int SPI_GETMOUSEHOVERTIME = 102;

        /// SPI_GETMOUSEHOVERHEIGHT -> 0x0064
        public const int SPI_GETMOUSEHOVERHEIGHT = 100;

        /// SPI_GETMOUSECLICKLOCKTIME -> 0x2008
        public const int SPI_GETMOUSECLICKLOCKTIME = 8200;

        /// SPI_GETMOUSECLICKLOCK -> 0x101E
        public const int SPI_GETMOUSECLICKLOCK = 4126;

        /// SPI_GETMOUSE -> 0x0003
        public const int SPI_GETMOUSE = 3;

        /// SPI_GETMINIMIZEDMETRICS -> 0x002B
        public const int SPI_GETMINIMIZEDMETRICS = 43;

        /// SPI_GETMENUUNDERLINES -> SPI_GETKEYBOARDCUES
        public const int SPI_GETMENUUNDERLINES = NativeConstants.SPI_GETKEYBOARDCUES;

        /// SPI_GETMENUSHOWDELAY -> 0x006A
        public const int SPI_GETMENUSHOWDELAY = 106;

        /// SPI_GETMENUFADE -> 0x1012
        public const int SPI_GETMENUFADE = 4114;

        /// SPI_GETMENUDROPALIGNMENT -> 0x001B
        public const int SPI_GETMENUDROPALIGNMENT = 27;

        /// SPI_GETMENUANIMATION -> 0x1002
        public const int SPI_GETMENUANIMATION = 4098;

        /// SPI_GETLOWPOWERTIMEOUT -> 0x004F
        public const int SPI_GETLOWPOWERTIMEOUT = 79;

        /// SPI_GETLOWPOWERACTIVE -> 0x0053
        public const int SPI_GETLOWPOWERACTIVE = 83;

        /// SPI_GETLISTBOXSMOOTHSCROLLING -> 0x1006
        public const int SPI_GETLISTBOXSMOOTHSCROLLING = 4102;

        /// SPI_GETKEYBOARDSPEED -> 0x000A
        public const int SPI_GETKEYBOARDSPEED = 10;

        /// SPI_GETKEYBOARDPREF -> 0x0044
        public const int SPI_GETKEYBOARDPREF = 68;

        /// SPI_GETKEYBOARDDELAY -> 0x0016
        public const int SPI_GETKEYBOARDDELAY = 22;

        /// SPI_GETKEYBOARDCUES -> 0x100A
        public const int SPI_GETKEYBOARDCUES = 4106;

        /// SPI_GETICONTITLEWRAP -> 0x0019
        public const int SPI_GETICONTITLEWRAP = 25;

        /// SPI_GETICONTITLELOGFONT -> 0x001F
        public const int SPI_GETICONTITLELOGFONT = 31;

        /// SPI_GETICONMETRICS -> 0x002D
        public const int SPI_GETICONMETRICS = 45;

        /// SPI_GETHOTTRACKING -> 0x100E
        public const int SPI_GETHOTTRACKING = 4110;

        /// SPI_GETHIGHCONTRAST -> 0x0042
        public const int SPI_GETHIGHCONTRAST = 66;

        /// SPI_GETGRIDGRANULARITY -> 0x0012
        public const int SPI_GETGRIDGRANULARITY = 18;

        /// SPI_GETGRADIENTCAPTIONS -> 0x1008
        public const int SPI_GETGRADIENTCAPTIONS = 4104;

        /// SPI_GETFOREGROUNDLOCKTIMEOUT -> 0x2000
        public const int SPI_GETFOREGROUNDLOCKTIMEOUT = 8192;

        /// SPI_GETFOREGROUNDFLASHCOUNT -> 0x2004
        public const int SPI_GETFOREGROUNDFLASHCOUNT = 8196;

        /// SPI_GETFONTSMOOTHINGTYPE -> 0x200A
        public const int SPI_GETFONTSMOOTHINGTYPE = 8202;

        /// SPI_GETFONTSMOOTHINGORIENTATION -> 0x2012
        public const int SPI_GETFONTSMOOTHINGORIENTATION = 8210;

        /// SPI_GETFONTSMOOTHINGCONTRAST -> 0x200C
        public const int SPI_GETFONTSMOOTHINGCONTRAST = 8204;

        /// SPI_GETFONTSMOOTHING -> 0x004A
        public const int SPI_GETFONTSMOOTHING = 74;

        /// SPI_GETFOCUSBORDERWIDTH -> 0x200E
        public const int SPI_GETFOCUSBORDERWIDTH = 8206;

        /// SPI_GETFOCUSBORDERHEIGHT -> 0x2010
        public const int SPI_GETFOCUSBORDERHEIGHT = 8208;

        /// SPI_GETFLATMENU -> 0x1022
        public const int SPI_GETFLATMENU = 4130;

        /// SPI_GETFILTERKEYS -> 0x0032
        public const int SPI_GETFILTERKEYS = 50;

        /// SPI_GETFASTTASKSWITCH -> 0x0023
        public const int SPI_GETFASTTASKSWITCH = 35;

        /// SPI_GETDROPSHADOW -> 0x1024
        public const int SPI_GETDROPSHADOW = 4132;

        /// SPI_GETDRAGFULLWINDOWS -> 0x0026
        public const int SPI_GETDRAGFULLWINDOWS = 38;

        /// SPI_GETDESKWALLPAPER -> 0x0073
        public const int SPI_GETDESKWALLPAPER = 115;

        /// SPI_GETDEFAULTINPUTLANG -> 0x0059
        public const int SPI_GETDEFAULTINPUTLANG = 89;

        /// SPI_GETCURSORSHADOW -> 0x101A
        public const int SPI_GETCURSORSHADOW = 4122;

        /// SPI_GETCOMBOBOXANIMATION -> 0x1004
        public const int SPI_GETCOMBOBOXANIMATION = 4100;

        /// SPI_GETCARETWIDTH -> 0x2006
        public const int SPI_GETCARETWIDTH = 8198;

        /// SPI_GETBORDER -> 0x0005
        public const int SPI_GETBORDER = 5;

        /// SPI_GETBLOCKSENDINPUTRESETS -> 0x1026
        public const int SPI_GETBLOCKSENDINPUTRESETS = 4134;

        /// SPI_GETBEEP -> 0x0001
        public const int SPI_GETBEEP = 1;

        /// SPI_GETANIMATION -> 0x0048
        public const int SPI_GETANIMATION = 72;

        /// SPI_GETACTIVEWNDTRKZORDER -> 0x100C
        public const int SPI_GETACTIVEWNDTRKZORDER = 4108;

        /// SPI_GETACTIVEWNDTRKTIMEOUT -> 0x2002
        public const int SPI_GETACTIVEWNDTRKTIMEOUT = 8194;

        /// SPI_GETACTIVEWINDOWTRACKING -> 0x1000
        public const int SPI_GETACTIVEWINDOWTRACKING = 4096;

        /// SPI_GETACCESSTIMEOUT -> 0x003C
        public const int SPI_GETACCESSTIMEOUT = 60;

        /// SPIF_UPDATEINIFILE -> 0x0001
        public const int SPIF_UPDATEINIFILE = 1;

        /// SPIF_SENDWININICHANGE -> 0x0002
        public const int SPIF_SENDWININICHANGE = 2;

        /// SPIF_SENDCHANGE -> SPIF_SENDWININICHANGE
        public const int SPIF_SENDCHANGE = NativeConstants.SPIF_SENDWININICHANGE;

        /// SPECIFIC_RIGHTS_ALL -> (0x0000FFFFL)
        public const int SPECIFIC_RIGHTS_ALL = 65535;

        /// SPCLPASSTHROUGH2 -> 4568
        public const int SPCLPASSTHROUGH2 = 4568;

        /// SPACEPARITY -> 4
        public const int SPACEPARITY = 4;

        /// SO_USELOOPBACK -> 0x0040
        public const int SO_USELOOPBACK = 64;

        /// SO_UPDATE_ACCEPT_CONTEXT -> 0x700B
        public const int SO_UPDATE_ACCEPT_CONTEXT = 28683;

        /// SO_TYPE -> 0x1008
        public const int SO_TYPE = 4104;

        /// SO_SYNCHRONOUS_NONALERT -> 0x20
        public const int SO_SYNCHRONOUS_NONALERT = 32;

        /// SO_SYNCHRONOUS_ALERT -> 0x10
        public const int SO_SYNCHRONOUS_ALERT = 16;

        /// SO_SNDTIMEO -> 0x1005
        public const int SO_SNDTIMEO = 4101;

        /// SO_SNDLOWAT -> 0x1003
        public const int SO_SNDLOWAT = 4099;

        /// SO_SNDBUF -> 0x1001
        public const int SO_SNDBUF = 4097;

        /// SO_REUSEADDR -> 0x0004
        public const int SO_REUSEADDR = 4;

        /// SO_RCVTIMEO -> 0x1006
        public const int SO_RCVTIMEO = 4102;

        /// SO_RCVLOWAT -> 0x1004
        public const int SO_RCVLOWAT = 4100;

        /// SO_RCVBUF -> 0x1002
        public const int SO_RCVBUF = 4098;

        /// SO_OPENTYPE -> 0x7008
        public const int SO_OPENTYPE = 28680;

        /// SO_OOBINLINE -> 0x0100
        public const int SO_OOBINLINE = 256;

        /// SO_MAXPATHDG -> 0x700A
        public const int SO_MAXPATHDG = 28682;

        /// SO_MAXDG -> 0x7009
        public const int SO_MAXDG = 28681;

        /// SO_LINGER -> 0x0080
        public const int SO_LINGER = 128;

        /// SO_KEEPALIVE -> 0x0008
        public const int SO_KEEPALIVE = 8;

        /// SO_ERROR -> 0x1007
        public const int SO_ERROR = 4103;

        /// SO_DONTROUTE -> 0x0010
        public const int SO_DONTROUTE = 16;

        /// SO_DISCOPTLEN -> 0x7007
        public const int SO_DISCOPTLEN = 28679;

        /// SO_DISCOPT -> 0x7003
        public const int SO_DISCOPT = 28675;

        /// SO_DISCDATALEN -> 0x7006
        public const int SO_DISCDATALEN = 28678;

        /// SO_DISCDATA -> 0x7002
        public const int SO_DISCDATA = 28674;

        /// SO_DEBUG -> 0x0001
        public const int SO_DEBUG = 1;

        /// SO_CONNOPTLEN -> 0x7005
        public const int SO_CONNOPTLEN = 28677;

        /// SO_CONNOPT -> 0x7001
        public const int SO_CONNOPT = 28673;

        /// SO_CONNECT_TIME -> 0x700C
        public const int SO_CONNECT_TIME = 28684;

        /// SO_CONNDATALEN -> 0x7004
        public const int SO_CONNDATALEN = 28676;

        /// SO_CONNDATA -> 0x7000
        public const int SO_CONNDATA = 28672;

        /// SO_BROADCAST -> 0x0020
        public const int SO_BROADCAST = 32;

        /// SO_ACCEPTCONN -> 0x0002
        public const int SO_ACCEPTCONN = 2;

        /// SOUND_SYSTEM_WARNING -> 6
        public const int SOUND_SYSTEM_WARNING = 6;

        /// SOUND_SYSTEM_STARTUP -> 1
        public const int SOUND_SYSTEM_STARTUP = 1;

        /// SOUND_SYSTEM_SHUTDOWN -> 2
        public const int SOUND_SYSTEM_SHUTDOWN = 2;

        /// SOUND_SYSTEM_RESTOREUP -> 10
        public const int SOUND_SYSTEM_RESTOREUP = 10;

        /// SOUND_SYSTEM_RESTOREDOWN -> 11
        public const int SOUND_SYSTEM_RESTOREDOWN = 11;

        /// SOUND_SYSTEM_QUESTION -> 5
        public const int SOUND_SYSTEM_QUESTION = 5;

        /// SOUND_SYSTEM_MINIMIZE -> 9
        public const int SOUND_SYSTEM_MINIMIZE = 9;

        /// SOUND_SYSTEM_MENUPOPUP -> 16
        public const int SOUND_SYSTEM_MENUPOPUP = 16;

        /// SOUND_SYSTEM_MENUCOMMAND -> 15
        public const int SOUND_SYSTEM_MENUCOMMAND = 15;

        /// SOUND_SYSTEM_MAXIMIZE -> 8
        public const int SOUND_SYSTEM_MAXIMIZE = 8;

        /// SOUND_SYSTEM_INFORMATION -> 7
        public const int SOUND_SYSTEM_INFORMATION = 7;

        /// SOUND_SYSTEM_FAULT -> 13
        public const int SOUND_SYSTEM_FAULT = 13;

        /// SOUND_SYSTEM_ERROR -> 4
        public const int SOUND_SYSTEM_ERROR = 4;

        /// SOUND_SYSTEM_BEEP -> 3
        public const int SOUND_SYSTEM_BEEP = 3;

        /// SOUND_SYSTEM_APPSTART -> 12
        public const int SOUND_SYSTEM_APPSTART = 12;

        /// SOUND_SYSTEM_APPEND -> 14
        public const int SOUND_SYSTEM_APPEND = 14;

        /// SORT_STRINGSORT -> 0x00001000
        public const int SORT_STRINGSORT = 4096;

        /// SORT_KOREAN_UNICODE -> 0x1
        public const int SORT_KOREAN_UNICODE = 1;

        /// SORT_KOREAN_KSC -> 0x0
        public const int SORT_KOREAN_KSC = 0;

        /// SORT_JAPANESE_XJIS -> 0x0
        public const int SORT_JAPANESE_XJIS = 0;

        /// SORT_JAPANESE_UNICODE -> 0x1
        public const int SORT_JAPANESE_UNICODE = 1;

        /// SORT_HUNGARIAN_TECHNICAL -> 0x1
        public const int SORT_HUNGARIAN_TECHNICAL = 1;

        /// SORT_HUNGARIAN_DEFAULT -> 0x0
        public const int SORT_HUNGARIAN_DEFAULT = 0;

        /// SORT_GERMAN_PHONE_BOOK -> 0x1
        public const int SORT_GERMAN_PHONE_BOOK = 1;

        /// SORT_GEORGIAN_TRADITIONAL -> 0x0
        public const int SORT_GEORGIAN_TRADITIONAL = 0;

        /// SORT_GEORGIAN_MODERN -> 0x1
        public const int SORT_GEORGIAN_MODERN = 1;

        /// SORT_DEFAULT -> 0x0
        public const int SORT_DEFAULT = 0;

        /// SORT_CHINESE_UNICODE -> 0x1
        public const int SORT_CHINESE_UNICODE = 1;

        /// SORT_CHINESE_PRCP -> 0x0
        public const int SORT_CHINESE_PRCP = 0;

        /// SORT_CHINESE_PRC -> 0x2
        public const int SORT_CHINESE_PRC = 2;

        /// SORT_CHINESE_BOPOMOFO -> 0x3
        public const int SORT_CHINESE_BOPOMOFO = 3;

        /// SORT_CHINESE_BIG5 -> 0x0
        public const int SORT_CHINESE_BIG5 = 0;

        /// SORTED_CTL_EXT_MAX_COLLISION_OFFSET -> (2*4)
        public const int SORTED_CTL_EXT_MAX_COLLISION_OFFSET = (2 * 4);

        /// SORTED_CTL_EXT_HASH_BUCKET_OFFSET -> (3*4)
        public const int SORTED_CTL_EXT_HASH_BUCKET_OFFSET = (3 * 4);

        /// SORTED_CTL_EXT_HASHED_SUBJECT_IDENTIFIER_FLAG -> 0x1
        public const int SORTED_CTL_EXT_HASHED_SUBJECT_IDENTIFIER_FLAG = 1;

        /// SORTED_CTL_EXT_FLAGS_OFFSET -> (0*4)
        public const int SORTED_CTL_EXT_FLAGS_OFFSET = (0 * 4);

        /// SORTED_CTL_EXT_COUNT_OFFSET -> (1*4)
        public const int SORTED_CTL_EXT_COUNT_OFFSET = (1 * 4);

        /// SOMAXCONN -> 5
        public const int SOMAXCONN = 5;

        /// SOL_SOCKET -> 0xffff
        public const int SOL_SOCKET = 65535;

        /// SOFTKEYBOARD_TYPE_T1 -> 0x0001
        public const int SOFTKEYBOARD_TYPE_T1 = 1;

        /// SOFTKEYBOARD_TYPE_C1 -> 0x0002
        public const int SOFTKEYBOARD_TYPE_C1 = 2;

        /// SOFTDIST_FLAG_USAGE_PRECACHE -> 0x00000002
        public const int SOFTDIST_FLAG_USAGE_PRECACHE = 2;

        /// SOFTDIST_FLAG_USAGE_EMAIL -> 0x00000001
        public const int SOFTDIST_FLAG_USAGE_EMAIL = 1;

        /// SOFTDIST_FLAG_USAGE_AUTOINSTALL -> 0x00000004
        public const int SOFTDIST_FLAG_USAGE_AUTOINSTALL = 4;

        /// SOFTDIST_FLAG_DELETE_SUBSCRIPTION -> 0x00000008
        public const int SOFTDIST_FLAG_DELETE_SUBSCRIPTION = 8;

        /// SOFTDIST_ADSTATE_NONE -> 0x00000000
        public const int SOFTDIST_ADSTATE_NONE = 0;

        /// SOFTDIST_ADSTATE_INSTALLED -> 0x00000003
        public const int SOFTDIST_ADSTATE_INSTALLED = 3;

        /// SOFTDIST_ADSTATE_DOWNLOADED -> 0x00000002
        public const int SOFTDIST_ADSTATE_DOWNLOADED = 2;

        /// SOFTDIST_ADSTATE_AVAILABLE -> 0x00000001
        public const int SOFTDIST_ADSTATE_AVAILABLE = 1;

        /// SOCK_STREAM -> 1
        public const int SOCK_STREAM = 1;

        /// SOCK_SEQPACKET -> 5
        public const int SOCK_SEQPACKET = 5;

        /// SOCK_RDM -> 4
        public const int SOCK_RDM = 4;

        /// SOCK_RAW -> 3
        public const int SOCK_RAW = 3;

        /// SOCK_DGRAM -> 2
        public const int SOCK_DGRAM = 2;

        /// SOCKET_ERROR -> (-1)
        public const int SOCKET_ERROR = -1;

        /// SND_SYNC -> 0x0000
        public const int SND_SYNC = 0;

        /// SND_RESOURCE -> 0x00040004L
        public const int SND_RESOURCE = 262148;

        /// SND_PURGE -> 0x0040
        public const int SND_PURGE = 64;

        /// SND_NOWAIT -> 0x00002000L
        public const int SND_NOWAIT = 8192;

        /// SND_NOSTOP -> 0x0010
        public const int SND_NOSTOP = 16;

        /// SND_NODEFAULT -> 0x0002
        public const int SND_NODEFAULT = 2;

        /// SND_MEMORY -> 0x0004
        public const int SND_MEMORY = 4;

        /// SND_LOOP -> 0x0008
        public const int SND_LOOP = 8;

        /// SND_FILENAME -> 0x00020000L
        public const int SND_FILENAME = 131072;

        /// SND_ASYNC -> 0x0001
        public const int SND_ASYNC = 1;

        /// SND_APPLICATION -> 0x0080
        public const int SND_APPLICATION = 128;

        /// SND_ALIAS_START -> 0
        public const int SND_ALIAS_START = 0;

        /// SND_ALIAS_ID -> 0x00110000L
        public const int SND_ALIAS_ID = 1114112;

        /// SND_ALIAS -> 0x00010000L
        public const int SND_ALIAS = 65536;

        /// sndPlaySound -> sndPlaySoundW
        /// Error generating expression: Value sndPlaySoundW is not resolved
        public const string sndPlaySound = "sndPlaySoundW";

        /// SNDMSG -> SendMessage
        public const string SNDMSG = NativeConstants.SendMessage;

        /// SNAPSHOT_POLICY_UNPLANNED -> 2
        public const int SNAPSHOT_POLICY_UNPLANNED = 2;

        /// SNAPSHOT_POLICY_NEVER -> 0
        public const int SNAPSHOT_POLICY_NEVER = 0;

        /// SNAPSHOT_POLICY_ALWAYS -> 1
        public const int SNAPSHOT_POLICY_ALWAYS = 1;

        /// SM_YVIRTUALSCREEN -> 77
        public const int SM_YVIRTUALSCREEN = 77;

        /// SM_XVIRTUALSCREEN -> 76
        public const int SM_XVIRTUALSCREEN = 76;

        /// SM_TABLETPC -> 86
        public const int SM_TABLETPC = 86;

        /// SM_SWAPBUTTON -> 23
        public const int SM_SWAPBUTTON = 23;

        /// SM_STARTER -> 88
        public const int SM_STARTER = 88;

        /// SM_SLOWMACHINE -> 73
        public const int SM_SLOWMACHINE = 73;

        /// SM_SHUTTINGDOWN -> 0x2000
        public const int SM_SHUTTINGDOWN = 8192;

        /// SM_SHOWSOUNDS -> 70
        public const int SM_SHOWSOUNDS = 70;

        /// SM_SERVERR2 -> 89
        public const int SM_SERVERR2 = 89;

        /// SM_SECURE -> 44
        public const int SM_SECURE = 44;

        /// SM_SAMEDISPLAYFORMAT -> 81
        public const int SM_SAMEDISPLAYFORMAT = 81;

        /// SM_RESERVED4 -> 27
        public const int SM_RESERVED4 = 27;

        /// SM_RESERVED3 -> 26
        public const int SM_RESERVED3 = 26;

        /// SM_RESERVED2 -> 25
        public const int SM_RESERVED2 = 25;

        /// SM_RESERVED1 -> 24
        public const int SM_RESERVED1 = 24;

        /// SM_REMOTESESSION -> 0x1000
        public const int SM_REMOTESESSION = 4096;

        /// SM_REMOTECONTROL -> 0x2001
        public const int SM_REMOTECONTROL = 8193;

        /// SM_PENWINDOWS -> 41
        public const int SM_PENWINDOWS = 41;

        /// SM_NETWORK -> 63
        public const int SM_NETWORK = 63;

        /// SM_MOUSEWHEELPRESENT -> 75
        public const int SM_MOUSEWHEELPRESENT = 75;

        /// SM_MOUSEPRESENT -> 19
        public const int SM_MOUSEPRESENT = 19;

        /// SM_MIDEASTENABLED -> 74
        public const int SM_MIDEASTENABLED = 74;

        /// SM_MENUDROPALIGNMENT -> 40
        public const int SM_MENUDROPALIGNMENT = 40;

        /// SM_MEDIACENTER -> 87
        public const int SM_MEDIACENTER = 87;

        /// SM_IMMENABLED -> 82
        public const int SM_IMMENABLED = 82;

        /// SM_DEBUG -> 22
        public const int SM_DEBUG = 22;

        /// SM_DBCSENABLED -> 42
        public const int SM_DBCSENABLED = 42;

        /// SM_CYVTHUMB -> 9
        public const int SM_CYVTHUMB = 9;

        /// SM_CYVSCROLL -> 20
        public const int SM_CYVSCROLL = 20;

        /// SM_CYVIRTUALSCREEN -> 79
        public const int SM_CYVIRTUALSCREEN = 79;

        /// SM_CYSMSIZE -> 53
        public const int SM_CYSMSIZE = 53;

        /// SM_CYSMICON -> 50
        public const int SM_CYSMICON = 50;

        /// SM_CYSMCAPTION -> 51
        public const int SM_CYSMCAPTION = 51;

        /// SM_CYSIZEFRAME -> SM_CYFRAME
        public const int SM_CYSIZEFRAME = NativeConstants.SM_CYFRAME;

        /// SM_CYSIZE -> 31
        public const int SM_CYSIZE = 31;

        /// SM_CYSCREEN -> 1
        public const int SM_CYSCREEN = 1;

        /// SM_CYMINTRACK -> 35
        public const int SM_CYMINTRACK = 35;

        /// SM_CYMINSPACING -> 48
        public const int SM_CYMINSPACING = 48;

        /// SM_CYMINIMIZED -> 58
        public const int SM_CYMINIMIZED = 58;

        /// SM_CYMIN -> 29
        public const int SM_CYMIN = 29;

        /// SM_CYMENUSIZE -> 55
        public const int SM_CYMENUSIZE = 55;

        /// SM_CYMENUCHECK -> 72
        public const int SM_CYMENUCHECK = 72;

        /// SM_CYMENU -> 15
        public const int SM_CYMENU = 15;

        /// SM_CYMAXTRACK -> 60
        public const int SM_CYMAXTRACK = 60;

        /// SM_CYMAXIMIZED -> 62
        public const int SM_CYMAXIMIZED = 62;

        /// SM_CYKANJIWINDOW -> 18
        public const int SM_CYKANJIWINDOW = 18;

        /// SM_CYICONSPACING -> 39
        public const int SM_CYICONSPACING = 39;

        /// SM_CYICON -> 12
        public const int SM_CYICON = 12;

        /// SM_CYHSCROLL -> 3
        public const int SM_CYHSCROLL = 3;

        /// SM_CYFULLSCREEN -> 17
        public const int SM_CYFULLSCREEN = 17;

        /// SM_CYFRAME -> 33
        public const int SM_CYFRAME = 33;

        /// SM_CYFOCUSBORDER -> 84
        public const int SM_CYFOCUSBORDER = 84;

        /// SM_CYFIXEDFRAME -> SM_CYDLGFRAME
        public const int SM_CYFIXEDFRAME = NativeConstants.SM_CYDLGFRAME;

        /// SM_CYEDGE -> 46
        public const int SM_CYEDGE = 46;

        /// SM_CYDRAG -> 69
        public const int SM_CYDRAG = 69;

        /// SM_CYDOUBLECLK -> 37
        public const int SM_CYDOUBLECLK = 37;

        /// SM_CYDLGFRAME -> 8
        public const int SM_CYDLGFRAME = 8;

        /// SM_CYCURSOR -> 14
        public const int SM_CYCURSOR = 14;

        /// SM_CYCAPTION -> 4
        public const int SM_CYCAPTION = 4;

        /// SM_CYBORDER -> 6
        public const int SM_CYBORDER = 6;

        /// SM_CXVSCROLL -> 2
        public const int SM_CXVSCROLL = 2;

        /// SM_CXVIRTUALSCREEN -> 78
        public const int SM_CXVIRTUALSCREEN = 78;

        /// SM_CXSMSIZE -> 52
        public const int SM_CXSMSIZE = 52;

        /// SM_CXSMICON -> 49
        public const int SM_CXSMICON = 49;

        /// SM_CXSIZEFRAME -> SM_CXFRAME
        public const int SM_CXSIZEFRAME = NativeConstants.SM_CXFRAME;

        /// SM_CXSIZE -> 30
        public const int SM_CXSIZE = 30;

        /// SM_CXSCREEN -> 0
        public const int SM_CXSCREEN = 0;

        /// SM_CXMINTRACK -> 34
        public const int SM_CXMINTRACK = 34;

        /// SM_CXMINSPACING -> 47
        public const int SM_CXMINSPACING = 47;

        /// SM_CXMINIMIZED -> 57
        public const int SM_CXMINIMIZED = 57;

        /// SM_CXMIN -> 28
        public const int SM_CXMIN = 28;

        /// SM_CXMENUSIZE -> 54
        public const int SM_CXMENUSIZE = 54;

        /// SM_CXMENUCHECK -> 71
        public const int SM_CXMENUCHECK = 71;

        /// SM_CXMAXTRACK -> 59
        public const int SM_CXMAXTRACK = 59;

        /// SM_CXMAXIMIZED -> 61
        public const int SM_CXMAXIMIZED = 61;

        /// SM_CXICONSPACING -> 38
        public const int SM_CXICONSPACING = 38;

        /// SM_CXICON -> 11
        public const int SM_CXICON = 11;

        /// SM_CXHTHUMB -> 10
        public const int SM_CXHTHUMB = 10;

        /// SM_CXHSCROLL -> 21
        public const int SM_CXHSCROLL = 21;

        /// SM_CXFULLSCREEN -> 16
        public const int SM_CXFULLSCREEN = 16;

        /// SM_CXFRAME -> 32
        public const int SM_CXFRAME = 32;

        /// SM_CXFOCUSBORDER -> 83
        public const int SM_CXFOCUSBORDER = 83;

        /// SM_CXFIXEDFRAME -> SM_CXDLGFRAME
        public const int SM_CXFIXEDFRAME = NativeConstants.SM_CXDLGFRAME;

        /// SM_CXEDGE -> 45
        public const int SM_CXEDGE = 45;

        /// SM_CXDRAG -> 68
        public const int SM_CXDRAG = 68;

        /// SM_CXDOUBLECLK -> 36
        public const int SM_CXDOUBLECLK = 36;

        /// SM_CXDLGFRAME -> 7
        public const int SM_CXDLGFRAME = 7;

        /// SM_CXCURSOR -> 13
        public const int SM_CXCURSOR = 13;

        /// SM_CXBORDER -> 5
        public const int SM_CXBORDER = 5;

        /// SM_CMOUSEBUTTONS -> 43
        public const int SM_CMOUSEBUTTONS = 43;

        /// SM_CMONITORS -> 80
        public const int SM_CMONITORS = 80;

        /// SM_CMETRICS -> 90
        public const int SM_CMETRICS = 90;

        /// SM_CLEANBOOT -> 67
        public const int SM_CLEANBOOT = 67;

        /// SM_CARETBLINKINGENABLED -> 0x2002
        public const int SM_CARETBLINKINGENABLED = 8194;

        /// SM_ARRANGE -> 56
        public const int SM_ARRANGE = 56;

        /// SMTO_NOTIMEOUTIFNOTHUNG -> 0x0008
        public const int SMTO_NOTIMEOUTIFNOTHUNG = 8;

        /// SMTO_NORMAL -> 0x0000
        public const int SMTO_NORMAL = 0;

        /// SMTO_BLOCK -> 0x0001
        public const int SMTO_BLOCK = 1;

        /// SMTO_ABORTIFHUNG -> 0x0002
        public const int SMTO_ABORTIFHUNG = 2;

        /// SMART_WRITE_LOG -> 0xd6
        public const int SMART_WRITE_LOG = 214;

        /// SMART_SHORT_SELFTEST_OFFLINE -> 1
        public const int SMART_SHORT_SELFTEST_OFFLINE = 1;

        /// SMART_SHORT_SELFTEST_CAPTIVE -> 129
        public const int SMART_SHORT_SELFTEST_CAPTIVE = 129;

        /// SMART_READ_LOG -> 0xD5
        public const int SMART_READ_LOG = 213;

        /// SMART_OFFLINE_ROUTINE_OFFLINE -> 0
        public const int SMART_OFFLINE_ROUTINE_OFFLINE = 0;

        /// SMART_NO_IDE_DEVICE -> 10
        public const int SMART_NO_IDE_DEVICE = 10;

        /// SMART_NO_ERROR -> 0
        public const int SMART_NO_ERROR = 0;

        /// SMART_NOT_SUPPORTED -> 9
        public const int SMART_NOT_SUPPORTED = 9;

        /// SMART_LOG_SECTOR_SIZE -> 512
        public const int SMART_LOG_SECTOR_SIZE = 512;

        /// SMART_INVALID_REGISTER -> 8
        public const int SMART_INVALID_REGISTER = 8;

        /// SMART_INVALID_IOCTL -> 6
        public const int SMART_INVALID_IOCTL = 6;

        /// SMART_INVALID_FLAG -> 2
        public const int SMART_INVALID_FLAG = 2;

        /// SMART_INVALID_DRIVE -> 5
        public const int SMART_INVALID_DRIVE = 5;

        /// SMART_INVALID_COMMAND -> 3
        public const int SMART_INVALID_COMMAND = 3;

        /// SMART_INVALID_BUFFER -> 4
        public const int SMART_INVALID_BUFFER = 4;

        /// SMART_IDE_ERROR -> 1
        public const int SMART_IDE_ERROR = 1;

        /// SMART_EXTENDED_SELFTEST_OFFLINE -> 2
        public const int SMART_EXTENDED_SELFTEST_OFFLINE = 2;

        /// SMART_EXTENDED_SELFTEST_CAPTIVE -> 130
        public const int SMART_EXTENDED_SELFTEST_CAPTIVE = 130;

        /// SMART_ERROR_NO_MEM -> 7
        public const int SMART_ERROR_NO_MEM = 7;

        /// SMART_CYL_LOW -> 0x4F
        public const int SMART_CYL_LOW = 79;

        /// SMART_CYL_HI -> 0xC2
        public const int SMART_CYL_HI = 194;

        /// SMART_CMD -> 0xB0
        public const int SMART_CMD = 176;

        /// SMART_ABORT_OFFLINE_SELFTEST -> 127
        public const int SMART_ABORT_OFFLINE_SELFTEST = 127;

        /// small -> char
        /// Error generating expression: Value char is not resolved
        public const string small = "char";

        /// SLIST_ENTRY -> SINGLE_LIST_ENTRY
        /// Error generating expression: Value SINGLE_LIST_ENTRY is not resolved
        public const string SLIST_ENTRY = "SINGLE_LIST_ENTRY";

        /// SLE_WARNING -> 0x00000003
        public const int SLE_WARNING = 3;

        /// SLE_MINORERROR -> 0x00000002
        public const int SLE_MINORERROR = 2;

        /// SLE_ERROR -> 0x00000001
        public const int SLE_ERROR = 1;

        /// SKF_TWOKEYSOFF -> 0x00000100
        public const int SKF_TWOKEYSOFF = 256;

        /// SKF_TRISTATE -> 0x00000080
        public const int SKF_TRISTATE = 128;

        /// SKF_STICKYKEYSON -> 0x00000001
        public const int SKF_STICKYKEYSON = 1;

        /// SKF_RWINLOCKED -> 0x00800000
        public const int SKF_RWINLOCKED = 8388608;

        /// SKF_RWINLATCHED -> 0x80000000
        public const int SKF_RWINLATCHED = -2147483648;

        /// SKF_RSHIFTLOCKED -> 0x00020000
        public const int SKF_RSHIFTLOCKED = 131072;

        /// SKF_RSHIFTLATCHED -> 0x02000000
        public const int SKF_RSHIFTLATCHED = 33554432;

        /// SKF_RCTLLOCKED -> 0x00080000
        public const int SKF_RCTLLOCKED = 524288;

        /// SKF_RCTLLATCHED -> 0x08000000
        public const int SKF_RCTLLATCHED = 134217728;

        /// SKF_RALTLOCKED -> 0x00200000
        public const int SKF_RALTLOCKED = 2097152;

        /// SKF_RALTLATCHED -> 0x20000000
        public const int SKF_RALTLATCHED = 536870912;

        /// SKF_LWINLOCKED -> 0x00400000
        public const int SKF_LWINLOCKED = 4194304;

        /// SKF_LWINLATCHED -> 0x40000000
        public const int SKF_LWINLATCHED = 1073741824;

        /// SKF_LSHIFTLOCKED -> 0x00010000
        public const int SKF_LSHIFTLOCKED = 65536;

        /// SKF_LSHIFTLATCHED -> 0x01000000
        public const int SKF_LSHIFTLATCHED = 16777216;

        /// SKF_LCTLLOCKED -> 0x00040000
        public const int SKF_LCTLLOCKED = 262144;

        /// SKF_LCTLLATCHED -> 0x04000000
        public const int SKF_LCTLLATCHED = 67108864;

        /// SKF_LALTLOCKED -> 0x00100000
        public const int SKF_LALTLOCKED = 1048576;

        /// SKF_LALTLATCHED -> 0x10000000
        public const int SKF_LALTLATCHED = 268435456;

        /// SKF_INDICATOR -> 0x00000020
        public const int SKF_INDICATOR = 32;

        /// SKF_HOTKEYSOUND -> 0x00000010
        public const int SKF_HOTKEYSOUND = 16;

        /// SKF_HOTKEYACTIVE -> 0x00000004
        public const int SKF_HOTKEYACTIVE = 4;

        /// SKF_CONFIRMHOTKEY -> 0x00000008
        public const int SKF_CONFIRMHOTKEY = 8;

        /// SKF_AVAILABLE -> 0x00000002
        public const int SKF_AVAILABLE = 2;

        /// SKF_AUDIBLEFEEDBACK -> 0x00000040
        public const int SKF_AUDIBLEFEEDBACK = 64;

        /// SIZE_RESTORED -> 0
        public const int SIZE_RESTORED = 0;

        /// SIZE_OF_80387_REGISTERS -> 80
        public const int SIZE_OF_80387_REGISTERS = 80;

        /// SIZE_MINIMIZED -> 1
        public const int SIZE_MINIMIZED = 1;

        /// SIZE_MAXSHOW -> 3
        public const int SIZE_MAXSHOW = 3;

        /// SIZE_MAXIMIZED -> 2
        public const int SIZE_MAXIMIZED = 2;

        /// SIZE_MAXHIDE -> 4
        public const int SIZE_MAXHIDE = 4;

        /// SIZE_MAX -> UINT_MAX
        public const int SIZE_MAX = NativeConstants.UINT_MAX;

        /// SIZEZOOMSHOW -> SIZE_MAXSHOW
        public const int SIZEZOOMSHOW = NativeConstants.SIZE_MAXSHOW;

        /// SIZEZOOMHIDE -> SIZE_MAXHIDE
        public const int SIZEZOOMHIDE = NativeConstants.SIZE_MAXHIDE;

        /// SIZEPALETTE -> 104
        public const int SIZEPALETTE = 104;

        /// SIZEOF_RFPO_DATA -> 16
        public const int SIZEOF_RFPO_DATA = 16;

        /// SIZENORMAL -> SIZE_RESTORED
        public const int SIZENORMAL = NativeConstants.SIZE_RESTORED;

        /// SIZEICONIC -> SIZE_MINIMIZED
        public const int SIZEICONIC = NativeConstants.SIZE_MINIMIZED;

        /// SIZEFULLSCREEN -> SIZE_MAXIMIZED
        public const int SIZEFULLSCREEN = NativeConstants.SIZE_MAXIMIZED;

        /// SIMULATED_FONTTYPE -> 0x8000
        public const int SIMULATED_FONTTYPE = 32768;

        /// SIMPLEREGION -> 2
        public const int SIMPLEREGION = 2;

        /// SIMPLEBLOB -> 0x1
        public const int SIMPLEBLOB = 1;

        /// SIF_TRACKPOS -> 0x0010
        public const int SIF_TRACKPOS = 16;

        /// SIF_RANGE -> 0x0001
        public const int SIF_RANGE = 1;

        /// SIF_POS -> 0x0004
        public const int SIF_POS = 4;

        /// SIF_PAGE -> 0x0002
        public const int SIF_PAGE = 2;

        /// SIF_DISABLENOSCROLL -> 0x0008
        public const int SIF_DISABLENOSCROLL = 8;

        /// SIF_ALL -> (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS)
        public const int SIF_ALL = (NativeConstants.SIF_RANGE
                    | (NativeConstants.SIF_PAGE
                    | (NativeConstants.SIF_POS | NativeConstants.SIF_TRACKPOS)));

        /// SID_SInternetSecurityManagerEx -> IID_IInternetSecurityManagerEx
        /// Error generating expression: Value IID_IInternetSecurityManagerEx is not resolved
        public const string SID_SInternetSecurityManagerEx = "IID_IInternetSecurityManagerEx";

        /// SID_SInternetSecurityManager -> IID_IInternetSecurityManager
        /// Error generating expression: Value IID_IInternetSecurityManager is not resolved
        public const string SID_SInternetSecurityManager = "IID_IInternetSecurityManager";

        /// SID_SInternetHostSecurityManager -> IID_IInternetHostSecurityManager
        /// Error generating expression: Value IID_IInternetHostSecurityManager is not resolved
        public const string SID_SInternetHostSecurityManager = "IID_IInternetHostSecurityManager";

        /// SID_SBindHost -> IID_IBindHost
        /// Error generating expression: Value IID_IBindHost is not resolved
        public const string SID_SBindHost = "IID_IBindHost";

        /// SID_REVISION -> (1)
        public const int SID_REVISION = 1;

        /// SID_RECOMMENDED_SUB_AUTHORITIES -> (1)
        public const int SID_RECOMMENDED_SUB_AUTHORITIES = 1;

        /// SID_MAX_SUB_AUTHORITIES -> (15)
        public const int SID_MAX_SUB_AUTHORITIES = 15;

        /// SID_IBindHost -> IID_IBindHost
        /// Error generating expression: Value IID_IBindHost is not resolved
        public const string SID_IBindHost = "IID_IBindHost";

        /// SHUTDOWN_TYPE_LEN -> 32
        public const int SHUTDOWN_TYPE_LEN = 32;

        /// SHUTDOWN_NORETRY -> 0x00000001
        public const int SHUTDOWN_NORETRY = 1;

        /// SHTDN_REASON_VALID_BIT_MASK -> 0xc0ffffff
        public const int SHTDN_REASON_VALID_BIT_MASK = -1056964609;

        /// SHTDN_REASON_UNKNOWN -> SHTDN_REASON_MINOR_NONE
        public const int SHTDN_REASON_UNKNOWN = NativeConstants.SHTDN_REASON_MINOR_NONE;

        /// SHTDN_REASON_MINOR_WMI -> 0x00000015
        public const int SHTDN_REASON_MINOR_WMI = 21;

        /// SHTDN_REASON_MINOR_UPGRADE -> 0x00000003
        public const int SHTDN_REASON_MINOR_UPGRADE = 3;

        /// SHTDN_REASON_MINOR_UNSTABLE -> 0x00000006
        public const int SHTDN_REASON_MINOR_UNSTABLE = 6;

        /// SHTDN_REASON_MINOR_TERMSRV -> 0x00000020
        public const int SHTDN_REASON_MINOR_TERMSRV = 32;

        /// SHTDN_REASON_MINOR_SYSTEMRESTORE -> 0x0000001a
        public const int SHTDN_REASON_MINOR_SYSTEMRESTORE = 26;

        /// SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL -> 0x00000016
        public const int SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL = 22;

        /// SHTDN_REASON_MINOR_SERVICEPACK -> 0x00000010
        public const int SHTDN_REASON_MINOR_SERVICEPACK = 16;

        /// SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL -> 0x00000018
        public const int SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 24;

        /// SHTDN_REASON_MINOR_SECURITYFIX -> 0x00000012
        public const int SHTDN_REASON_MINOR_SECURITYFIX = 18;

        /// SHTDN_REASON_MINOR_SECURITY -> 0x00000013
        public const int SHTDN_REASON_MINOR_SECURITY = 19;

        /// SHTDN_REASON_MINOR_RECONFIG -> 0x00000004
        public const int SHTDN_REASON_MINOR_RECONFIG = 4;

        /// SHTDN_REASON_MINOR_PROCESSOR -> 0x00000008
        public const int SHTDN_REASON_MINOR_PROCESSOR = 8;

        /// SHTDN_REASON_MINOR_POWER_SUPPLY -> 0x0000000a
        public const int SHTDN_REASON_MINOR_POWER_SUPPLY = 10;

        /// SHTDN_REASON_MINOR_OTHERDRIVER -> 0x0000000e
        public const int SHTDN_REASON_MINOR_OTHERDRIVER = 14;

        /// SHTDN_REASON_MINOR_OTHER -> 0x00000000
        public const int SHTDN_REASON_MINOR_OTHER = 0;

        /// SHTDN_REASON_MINOR_NONE -> 0x000000ff
        public const int SHTDN_REASON_MINOR_NONE = 255;

        /// SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY -> 0x00000014
        public const int SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY = 20;

        /// SHTDN_REASON_MINOR_NETWORKCARD -> 0x00000009
        public const int SHTDN_REASON_MINOR_NETWORKCARD = 9;

        /// SHTDN_REASON_MINOR_MMC -> 0x00000019
        public const int SHTDN_REASON_MINOR_MMC = 25;

        /// SHTDN_REASON_MINOR_MAINTENANCE -> 0x00000001
        public const int SHTDN_REASON_MINOR_MAINTENANCE = 1;

        /// SHTDN_REASON_MINOR_INSTALLATION -> 0x00000002
        public const int SHTDN_REASON_MINOR_INSTALLATION = 2;

        /// SHTDN_REASON_MINOR_HUNG -> 0x00000005
        public const int SHTDN_REASON_MINOR_HUNG = 5;

        /// SHTDN_REASON_MINOR_HOTFIX_UNINSTALL -> 0x00000017
        public const int SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 23;

        /// SHTDN_REASON_MINOR_HOTFIX -> 0x00000011
        public const int SHTDN_REASON_MINOR_HOTFIX = 17;

        /// SHTDN_REASON_MINOR_HARDWARE_DRIVER -> 0x0000000d
        public const int SHTDN_REASON_MINOR_HARDWARE_DRIVER = 13;

        /// SHTDN_REASON_MINOR_ENVIRONMENT -> 0x0000000c
        public const int SHTDN_REASON_MINOR_ENVIRONMENT = 12;

        /// SHTDN_REASON_MINOR_DISK -> 0x00000007
        public const int SHTDN_REASON_MINOR_DISK = 7;

        /// SHTDN_REASON_MINOR_DC_PROMOTION -> 0x00000021
        public const int SHTDN_REASON_MINOR_DC_PROMOTION = 33;

        /// SHTDN_REASON_MINOR_DC_DEMOTION -> 0x00000022
        public const int SHTDN_REASON_MINOR_DC_DEMOTION = 34;

        /// SHTDN_REASON_MINOR_CORDUNPLUGGED -> 0x0000000b
        public const int SHTDN_REASON_MINOR_CORDUNPLUGGED = 11;

        /// SHTDN_REASON_MINOR_BLUESCREEN -> 0x0000000F
        public const int SHTDN_REASON_MINOR_BLUESCREEN = 15;

        /// SHTDN_REASON_MAJOR_SYSTEM -> 0x00050000
        public const int SHTDN_REASON_MAJOR_SYSTEM = 327680;

        /// SHTDN_REASON_MAJOR_SOFTWARE -> 0x00030000
        public const int SHTDN_REASON_MAJOR_SOFTWARE = 196608;

        /// SHTDN_REASON_MAJOR_POWER -> 0x00060000
        public const int SHTDN_REASON_MAJOR_POWER = 393216;

        /// SHTDN_REASON_MAJOR_OTHER -> 0x00000000
        public const int SHTDN_REASON_MAJOR_OTHER = 0;

        /// SHTDN_REASON_MAJOR_OPERATINGSYSTEM -> 0x00020000
        public const int SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 131072;

        /// SHTDN_REASON_MAJOR_NONE -> 0x00000000
        public const int SHTDN_REASON_MAJOR_NONE = 0;

        /// SHTDN_REASON_MAJOR_LEGACY_API -> 0x00070000
        public const int SHTDN_REASON_MAJOR_LEGACY_API = 458752;

        /// SHTDN_REASON_MAJOR_HARDWARE -> 0x00010000
        public const int SHTDN_REASON_MAJOR_HARDWARE = 65536;

        /// SHTDN_REASON_MAJOR_APPLICATION -> 0x00040000
        public const int SHTDN_REASON_MAJOR_APPLICATION = 262144;

        /// SHTDN_REASON_LEGACY_API -> (SHTDN_REASON_MAJOR_LEGACY_API | SHTDN_REASON_FLAG_PLANNED)
        public const int SHTDN_REASON_LEGACY_API = (NativeConstants.SHTDN_REASON_MAJOR_LEGACY_API | NativeConstants.SHTDN_REASON_FLAG_PLANNED);

        /// SHTDN_REASON_FLAG_USER_DEFINED -> 0x40000000
        public const int SHTDN_REASON_FLAG_USER_DEFINED = 1073741824;

        /// SHTDN_REASON_FLAG_PLANNED -> 0x80000000
        public const int SHTDN_REASON_FLAG_PLANNED = -2147483648;

        /// SHTDN_REASON_FLAG_DIRTY_UI -> 0x08000000
        public const int SHTDN_REASON_FLAG_DIRTY_UI = 134217728;

        /// SHTDN_REASON_FLAG_DIRTY_PROBLEM_ID_REQUIRED -> 0x02000000
        public const int SHTDN_REASON_FLAG_DIRTY_PROBLEM_ID_REQUIRED = 33554432;

        /// SHTDN_REASON_FLAG_COMMENT_REQUIRED -> 0x01000000
        public const int SHTDN_REASON_FLAG_COMMENT_REQUIRED = 16777216;

        /// SHTDN_REASON_FLAG_CLEAN_UI -> 0x04000000
        public const int SHTDN_REASON_FLAG_CLEAN_UI = 67108864;

        /// SHRT_MIN -> (-32768)
        public const int SHRT_MIN = -32768;

        /// SHRT_MAX -> 32767
        public const int SHRT_MAX = 32767;

        /// SHQueryRecycleBin -> SHQueryRecycleBinW
        /// Error generating expression: Value SHQueryRecycleBinW is not resolved
        public const string SHQueryRecycleBin = "SHQueryRecycleBinW";

        /// SHOW_OPENWINDOW -> 1
        public const int SHOW_OPENWINDOW = 1;

        /// SHOW_OPENNOACTIVATE -> 4
        public const int SHOW_OPENNOACTIVATE = 4;

        /// SHOW_ICONWINDOW -> 2
        public const int SHOW_ICONWINDOW = 2;

        /// SHOW_FULLSCREEN -> 3
        public const int SHOW_FULLSCREEN = 3;

        /// SHInvokePrinterCommand -> SHInvokePrinterCommandW
        /// Error generating expression: Value SHInvokePrinterCommandW is not resolved
        public const string SHInvokePrinterCommand = "SHInvokePrinterCommandW";

        /// SHIFT_PRESSED -> 0x0010
        public const int SHIFT_PRESSED = 16;

        /// SHIFTJIS_CHARSET -> 128
        public const int SHIFTJIS_CHARSET = 128;

        /// SHGNLI_PREFIXNAME -> 0x000000002
        public const int SHGNLI_PREFIXNAME = 2;

        /// SHGNLI_PIDL -> 0x000000001
        public const int SHGNLI_PIDL = 1;

        /// SHGNLI_NOUNIQUE -> 0x000000004
        public const int SHGNLI_NOUNIQUE = 4;

        /// SHGFI_USEFILEATTRIBUTES -> 0x000000010
        public const int SHGFI_USEFILEATTRIBUTES = 16;

        /// SHGFI_TYPENAME -> 0x000000400
        public const int SHGFI_TYPENAME = 1024;

        /// SHGFI_SYSICONINDEX -> 0x000004000
        public const int SHGFI_SYSICONINDEX = 16384;

        /// SHGFI_SMALLICON -> 0x000000001
        public const int SHGFI_SMALLICON = 1;

        /// SHGFI_SHELLICONSIZE -> 0x000000004
        public const int SHGFI_SHELLICONSIZE = 4;

        /// SHGFI_SELECTED -> 0x000010000
        public const int SHGFI_SELECTED = 65536;

        /// SHGFI_PIDL -> 0x000000008
        public const int SHGFI_PIDL = 8;

        /// SHGFI_OPENICON -> 0x000000002
        public const int SHGFI_OPENICON = 2;

        /// SHGFI_LINKOVERLAY -> 0x000008000
        public const int SHGFI_LINKOVERLAY = 32768;

        /// SHGFI_LARGEICON -> 0x000000000
        public const int SHGFI_LARGEICON = 0;

        /// SHGFI_ICONLOCATION -> 0x000001000
        public const int SHGFI_ICONLOCATION = 4096;

        /// SHGFI_ICON -> 0x000000100
        public const int SHGFI_ICON = 256;

        /// SHGFI_EXETYPE -> 0x000002000
        public const int SHGFI_EXETYPE = 8192;

        /// SHGFI_DISPLAYNAME -> 0x000000200
        public const int SHGFI_DISPLAYNAME = 512;

        /// SHGFI_ATTR_SPECIFIED -> 0x000020000
        public const int SHGFI_ATTR_SPECIFIED = 131072;

        /// SHGFI_ATTRIBUTES -> 0x000000800
        public const int SHGFI_ATTRIBUTES = 2048;

        /// SHGetNewLinkInfo -> SHGetNewLinkInfoW
        /// Error generating expression: Value SHGetNewLinkInfoW is not resolved
        public const string SHGetNewLinkInfo = "SHGetNewLinkInfoW";

        /// SHGetFileInfo -> SHGetFileInfoW
        /// Error generating expression: Value SHGetFileInfoW is not resolved
        public const string SHGetFileInfo = "SHGetFileInfoW";

        /// SHGetDiskFreeSpaceEx -> SHGetDiskFreeSpaceExW
        /// Error generating expression: Value SHGetDiskFreeSpaceExW is not resolved
        public const string SHGetDiskFreeSpaceEx = "SHGetDiskFreeSpaceExW";

        /// SHGetDiskFreeSpace -> SHGetDiskFreeSpaceEx
        public const string SHGetDiskFreeSpace = NativeConstants.SHGetDiskFreeSpaceEx;

        /// SHFileOperation -> SHFileOperationW
        /// Error generating expression: Value SHFileOperationW is not resolved
        public const string SHFileOperation = "SHFileOperationW";

        /// SHERB_NOSOUND -> 0x00000004
        public const int SHERB_NOSOUND = 4;

        /// SHERB_NOPROGRESSUI -> 0x00000002
        public const int SHERB_NOPROGRESSUI = 2;

        /// SHERB_NOCONFIRMATION -> 0x00000001
        public const int SHERB_NOCONFIRMATION = 1;

        /// SHEmptyRecycleBin -> SHEmptyRecycleBinW
        /// Error generating expression: Value SHEmptyRecycleBinW is not resolved
        public const string SHEmptyRecycleBin = "SHEmptyRecycleBinW";

        /// Shell_NotifyIcon -> Shell_NotifyIconW
        /// Error generating expression: Value Shell_NotifyIconW is not resolved
        public const string Shell_NotifyIcon = "Shell_NotifyIconW";

        /// ShellExecuteEx -> ShellExecuteExW
        /// Error generating expression: Value ShellExecuteExW is not resolved
        public const string ShellExecuteEx = "ShellExecuteExW";

        /// ShellExecute -> ShellExecuteW
        /// Error generating expression: Value ShellExecuteW is not resolved
        public const string ShellExecute = "ShellExecuteW";

        /// ShellAbout -> ShellAboutW
        /// Error generating expression: Value ShellAboutW is not resolved
        public const string ShellAbout = "ShellAboutW";

        /// SHAREVISTRINGW -> L"commdlg_ShareViolation"
        public const string SHAREVISTRINGW = "commdlg_ShareViolation";

        /// SHAREVISTRINGA -> "commdlg_ShareViolation"
        public const string SHAREVISTRINGA = "commdlg_ShareViolation";

        /// SHAREVISTRING -> SHAREVISTRINGW
        public const string SHAREVISTRING = NativeConstants.SHAREVISTRINGW;

        /// SHADEBLENDCAPS -> 120
        public const int SHADEBLENDCAPS = 120;

        /// SE_SELF_RELATIVE -> (0x8000)
        public const int SE_SELF_RELATIVE = 32768;

        /// SE_SACL_PROTECTED -> (0x2000)
        public const int SE_SACL_PROTECTED = 8192;

        /// SE_SACL_PRESENT -> (0x0010)
        public const int SE_SACL_PRESENT = 16;

        /// SE_SACL_DEFAULTED -> (0x0020)
        public const int SE_SACL_DEFAULTED = 32;

        /// SE_SACL_AUTO_INHERIT_REQ -> (0x0200)
        public const int SE_SACL_AUTO_INHERIT_REQ = 512;

        /// SE_SACL_AUTO_INHERITED -> (0x0800)
        public const int SE_SACL_AUTO_INHERITED = 2048;

        /// SE_RM_CONTROL_VALID -> (0x4000)
        public const int SE_RM_CONTROL_VALID = 16384;

        /// SE_PRIVILEGE_USED_FOR_ACCESS -> (0x80000000L)
        public const int SE_PRIVILEGE_USED_FOR_ACCESS = -2147483648;

        /// SE_PRIVILEGE_REMOVED -> (0X00000004L)
        public const int SE_PRIVILEGE_REMOVED = 4;

        /// SE_PRIVILEGE_ENABLED_BY_DEFAULT -> (0x00000001L)
        public const int SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1;

        /// SE_PRIVILEGE_ENABLED -> (0x00000002L)
        public const int SE_PRIVILEGE_ENABLED = 2;

        /// SE_OWNER_DEFAULTED -> (0x0001)
        public const int SE_OWNER_DEFAULTED = 1;

        /// SE_GROUP_USE_FOR_DENY_ONLY -> (0x00000010L)
        public const int SE_GROUP_USE_FOR_DENY_ONLY = 16;

        /// SE_GROUP_RESOURCE -> (0x20000000L)
        public const int SE_GROUP_RESOURCE = 536870912;

        /// SE_GROUP_OWNER -> (0x00000008L)
        public const int SE_GROUP_OWNER = 8;

        /// SE_GROUP_MANDATORY -> (0x00000001L)
        public const int SE_GROUP_MANDATORY = 1;

        /// SE_GROUP_LOGON_ID -> (0xC0000000L)
        public const int SE_GROUP_LOGON_ID = -1073741824;

        /// SE_GROUP_ENABLED_BY_DEFAULT -> (0x00000002L)
        public const int SE_GROUP_ENABLED_BY_DEFAULT = 2;

        /// SE_GROUP_ENABLED -> (0x00000004L)
        public const int SE_GROUP_ENABLED = 4;

        /// SE_GROUP_DEFAULTED -> (0x0002)
        public const int SE_GROUP_DEFAULTED = 2;

        /// SE_ERR_SHARE -> 26
        public const int SE_ERR_SHARE = 26;

        /// SE_ERR_PNF -> 3
        public const int SE_ERR_PNF = 3;

        /// SE_ERR_OOM -> 8
        public const int SE_ERR_OOM = 8;

        /// SE_ERR_NOASSOC -> 31
        public const int SE_ERR_NOASSOC = 31;

        /// SE_ERR_FNF -> 2
        public const int SE_ERR_FNF = 2;

        /// SE_ERR_DLLNOTFOUND -> 32
        public const int SE_ERR_DLLNOTFOUND = 32;

        /// SE_ERR_DDETIMEOUT -> 28
        public const int SE_ERR_DDETIMEOUT = 28;

        /// SE_ERR_DDEFAIL -> 29
        public const int SE_ERR_DDEFAIL = 29;

        /// SE_ERR_DDEBUSY -> 30
        public const int SE_ERR_DDEBUSY = 30;

        /// SE_ERR_ASSOCINCOMPLETE -> 27
        public const int SE_ERR_ASSOCINCOMPLETE = 27;

        /// SE_ERR_ACCESSDENIED -> 5
        public const int SE_ERR_ACCESSDENIED = 5;

        /// SE_DACL_PROTECTED -> (0x1000)
        public const int SE_DACL_PROTECTED = 4096;

        /// SE_DACL_PRESENT -> (0x0004)
        public const int SE_DACL_PRESENT = 4;

        /// SE_DACL_DEFAULTED -> (0x0008)
        public const int SE_DACL_DEFAULTED = 8;

        /// SE_DACL_AUTO_INHERIT_REQ -> (0x0100)
        public const int SE_DACL_AUTO_INHERIT_REQ = 256;

        /// SE_DACL_AUTO_INHERITED -> (0x0400)
        public const int SE_DACL_AUTO_INHERITED = 1024;

        /// SEVERITY_SUCCESS -> 0
        public const int SEVERITY_SUCCESS = 0;

        /// SEVERITY_ERROR -> 1
        public const int SEVERITY_ERROR = 1;

        /// SET_TAPE_MEDIA_INFORMATION -> 0
        public const int SET_TAPE_MEDIA_INFORMATION = 0;

        /// SET_TAPE_DRIVE_INFORMATION -> 1
        public const int SET_TAPE_DRIVE_INFORMATION = 1;

        /// SET_SPREAD -> 4106
        public const int SET_SPREAD = 4106;

        /// SET_SCREEN_ANGLE -> 4105
        public const int SET_SCREEN_ANGLE = 4105;

        /// SET_POLY_MODE -> 4104
        public const int SET_POLY_MODE = 4104;

        /// SET_MIRROR_MODE -> 4110
        public const int SET_MIRROR_MODE = 4110;

        /// SET_FEATURE_ON_THREAD_TRUSTED -> 0x00000020
        public const int SET_FEATURE_ON_THREAD_TRUSTED = 32;

        /// SET_FEATURE_ON_THREAD_RESTRICTED -> 0x00000080
        public const int SET_FEATURE_ON_THREAD_RESTRICTED = 128;

        /// SET_FEATURE_ON_THREAD_LOCALMACHINE -> 0x00000008
        public const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 8;

        /// SET_FEATURE_ON_THREAD_INTRANET -> 0x00000010
        public const int SET_FEATURE_ON_THREAD_INTRANET = 16;

        /// SET_FEATURE_ON_THREAD_INTERNET -> 0x00000040
        public const int SET_FEATURE_ON_THREAD_INTERNET = 64;

        /// SET_FEATURE_ON_THREAD -> 0x00000001
        public const int SET_FEATURE_ON_THREAD = 1;

        /// SET_FEATURE_ON_PROCESS -> 0x00000002
        public const int SET_FEATURE_ON_PROCESS = 2;

        /// SET_FEATURE_IN_REGISTRY -> 0x00000004
        public const int SET_FEATURE_IN_REGISTRY = 4;

        /// SET_CLIP_BOX -> 4108
        public const int SET_CLIP_BOX = 4108;

        /// SET_BOUNDS -> 4109
        public const int SET_BOUNDS = 4109;

        /// SET_BACKGROUND_COLOR -> 4103
        public const int SET_BACKGROUND_COLOR = 4103;

        /// SET_ARC_DIRECTION -> 4102
        public const int SET_ARC_DIRECTION = 4102;

        /// SETXON -> 2
        public const int SETXON = 2;

        /// SETXOFF -> 1
        public const int SETXOFF = 1;

        /// SetWindowText -> SetWindowTextW
        /// Error generating expression: Value SetWindowTextW is not resolved
        public const string SetWindowText = "SetWindowTextW";

        /// SetWindowsHookEx -> SetWindowsHookExW
        /// Error generating expression: Value SetWindowsHookExW is not resolved
        public const string SetWindowsHookEx = "SetWindowsHookExW";

        /// SetWindowsHook -> SetWindowsHookW
        /// Error generating expression: Value SetWindowsHookW is not resolved
        public const string SetWindowsHook = "SetWindowsHookW";

        /// SetWindowLongPtrW -> SetWindowLongW
        /// Error generating expression: Value SetWindowLongW is not resolved
        public const string SetWindowLongPtrW = "SetWindowLongW";

        /// SetWindowLongPtrA -> SetWindowLongA
        /// Error generating expression: Value SetWindowLongA is not resolved
        public const string SetWindowLongPtrA = "SetWindowLongA";

        /// SetWindowLongPtr -> SetWindowLongPtrW
        public const string SetWindowLongPtr = NativeConstants.SetWindowLongPtrW;

        /// SetWindowLong -> SetWindowLongW
        /// Error generating expression: Value SetWindowLongW is not resolved
        public const string SetWindowLong = "SetWindowLongW";

        /// SETWALLPAPER_DEFAULT -> ((LPWSTR)-1)
        /// Error generating expression: Value LPWSTR is not resolved
        public const string SETWALLPAPER_DEFAULT = "((LPWSTR)-1)";

        /// SetVolumeMountPoint -> SetVolumeMountPointW
        /// Error generating expression: Value SetVolumeMountPointW is not resolved
        public const string SetVolumeMountPoint = "SetVolumeMountPointW";

        /// SetVolumeLabel -> SetVolumeLabelW
        /// Error generating expression: Value SetVolumeLabelW is not resolved
        public const string SetVolumeLabel = "SetVolumeLabelW";

        /// SetUserObjectInformation -> SetUserObjectInformationW
        /// Error generating expression: Value SetUserObjectInformationW is not resolved
        public const string SetUserObjectInformation = "SetUserObjectInformationW";

        /// SETRTS -> 3
        public const int SETRTS = 3;

        /// SETRGBSTRINGW -> L"commdlg_SetRGBColor"
        public const string SETRGBSTRINGW = "commdlg_SetRGBColor";

        /// SETRGBSTRINGA -> "commdlg_SetRGBColor"
        public const string SETRGBSTRINGA = "commdlg_SetRGBColor";

        /// SETRGBSTRING -> SETRGBSTRINGW
        public const string SETRGBSTRING = NativeConstants.SETRGBSTRINGW;

        /// SetProp -> SetPropW
        /// Error generating expression: Value SetPropW is not resolved
        public const string SetProp = "SetPropW";

        /// SetPrinterDataEx -> SetPrinterDataExW
        /// Error generating expression: Value SetPrinterDataExW is not resolved
        public const string SetPrinterDataEx = "SetPrinterDataExW";

        /// SetPrinterData -> SetPrinterDataW
        /// Error generating expression: Value SetPrinterDataW is not resolved
        public const string SetPrinterData = "SetPrinterDataW";

        /// SetPrinter -> SetPrinterW
        /// Error generating expression: Value SetPrinterW is not resolved
        public const string SetPrinter = "SetPrinterW";

        /// SetPort -> SetPortW
        /// Error generating expression: Value SetPortW is not resolved
        public const string SetPort = "SetPortW";

        /// SETMITERLIMIT -> 23
        public const int SETMITERLIMIT = 23;

        /// SetMenuItemInfo -> SetMenuItemInfoW
        /// Error generating expression: Value SetMenuItemInfoW is not resolved
        public const string SetMenuItemInfo = "SetMenuItemInfoW";

        /// SetLocaleInfo -> SetLocaleInfoW
        /// Error generating expression: Value SetLocaleInfoW is not resolved
        public const string SetLocaleInfo = "SetLocaleInfoW";

        /// SETLINEJOIN -> 22
        public const int SETLINEJOIN = 22;

        /// SETLINECAP -> 21
        public const int SETLINECAP = 21;

        /// SETKERNTRACK -> 770
        public const int SETKERNTRACK = 770;

        /// SetJob -> SetJobW
        /// Error generating expression: Value SetJobW is not resolved
        public const string SetJob = "SetJobW";

        /// SETICMPROFILE_EMBEDED -> 0x00000001
        public const int SETICMPROFILE_EMBEDED = 1;

        /// SetICMProfile -> SetICMProfileW
        /// Error generating expression: Value SetICMProfileW is not resolved
        public const string SetICMProfile = "SetICMProfileW";

        /// SetForm -> SetFormW
        /// Error generating expression: Value SetFormW is not resolved
        public const string SetForm = "SetFormW";

        /// SetFirmwareEnvironmentVariable -> SetFirmwareEnvironmentVariableW
        /// Error generating expression: Value SetFirmwareEnvironmentVariableW is not resolved
        public const string SetFirmwareEnvironmentVariable = "SetFirmwareEnvironmentVariableW";

        /// SetFileShortName -> SetFileShortNameW
        /// Error generating expression: Value SetFileShortNameW is not resolved
        public const string SetFileShortName = "SetFileShortNameW";

        /// SetFileSecurity -> SetFileSecurityW
        /// Error generating expression: Value SetFileSecurityW is not resolved
        public const string SetFileSecurity = "SetFileSecurityW";

        /// SetFileAttributes -> SetFileAttributesW
        /// Error generating expression: Value SetFileAttributesW is not resolved
        public const string SetFileAttributes = "SetFileAttributesW";

        /// SetEnvironmentVariable -> SetEnvironmentVariableW
        /// Error generating expression: Value SetEnvironmentVariableW is not resolved
        public const string SetEnvironmentVariable = "SetEnvironmentVariableW";

        /// SetEnvironmentStrings -> SetEnvironmentStringsW
        /// Error generating expression: Value SetEnvironmentStringsW is not resolved
        public const string SetEnvironmentStrings = "SetEnvironmentStringsW";

        /// SETDTR -> 5
        public const int SETDTR = 5;

        /// SetDllDirectory -> SetDllDirectoryW
        /// Error generating expression: Value SetDllDirectoryW is not resolved
        public const string SetDllDirectory = "SetDllDirectoryW";

        /// SetDlgItemText -> SetDlgItemTextW
        /// Error generating expression: Value SetDlgItemTextW is not resolved
        public const string SetDlgItemText = "SetDlgItemTextW";

        /// SETDIBSCALING -> 32
        public const int SETDIBSCALING = 32;

        /// SetDefaultPrinter -> SetDefaultPrinterW
        /// Error generating expression: Value SetDefaultPrinterW is not resolved
        public const string SetDefaultPrinter = "SetDefaultPrinterW";

        /// SetDefaultCommConfig -> SetDefaultCommConfigW
        /// Error generating expression: Value SetDefaultCommConfigW is not resolved
        public const string SetDefaultCommConfig = "SetDefaultCommConfigW";

        /// SetCurrentDirectory -> SetCurrentDirectoryW
        /// Error generating expression: Value SetCurrentDirectoryW is not resolved
        public const string SetCurrentDirectory = "SetCurrentDirectoryW";

        /// SETCOPYCOUNT -> 17
        public const int SETCOPYCOUNT = 17;

        /// SetConsoleTitle -> SetConsoleTitleW
        /// Error generating expression: Value SetConsoleTitleW is not resolved
        public const string SetConsoleTitle = "SetConsoleTitleW";

        /// SetComputerNameEx -> SetComputerNameExW
        /// Error generating expression: Value SetComputerNameExW is not resolved
        public const string SetComputerNameEx = "SetComputerNameExW";

        /// SetComputerName -> SetComputerNameW
        /// Error generating expression: Value SetComputerNameW is not resolved
        public const string SetComputerName = "SetComputerNameW";

        /// SETCOLORTABLE -> 4
        public const int SETCOLORTABLE = 4;

        /// SetClassLongPtrW -> SetClassLongW
        /// Error generating expression: Value SetClassLongW is not resolved
        public const string SetClassLongPtrW = "SetClassLongW";

        /// SetClassLongPtrA -> SetClassLongA
        /// Error generating expression: Value SetClassLongA is not resolved
        public const string SetClassLongPtrA = "SetClassLongA";

        /// SetClassLongPtr -> SetClassLongPtrW
        public const string SetClassLongPtr = NativeConstants.SetClassLongPtrW;

        /// SetClassLong -> SetClassLongW
        /// Error generating expression: Value SetClassLongW is not resolved
        public const string SetClassLong = "SetClassLongW";

        /// SETCHARSET -> 772
        public const int SETCHARSET = 772;

        /// SetCalendarInfo -> SetCalendarInfoW
        /// Error generating expression: Value SetCalendarInfoW is not resolved
        public const string SetCalendarInfo = "SetCalendarInfoW";

        /// SETBREAK -> 8
        public const int SETBREAK = 8;

        /// SETALLJUSTVALUES -> 771
        public const int SETALLJUSTVALUES = 771;

        /// SETABORTPROC -> 9
        public const int SETABORTPROC = 9;

        /// SESSION_ESTABLISHED -> 0x03
        public const int SESSION_ESTABLISHED = 3;

        /// SESSION_ABORTED -> 0x06
        public const int SESSION_ABORTED = 6;

        /// SERVICE_WIN32_SHARE_PROCESS -> 0x00000020
        public const int SERVICE_WIN32_SHARE_PROCESS = 32;

        /// SERVICE_WIN32_OWN_PROCESS -> 0x00000010
        public const int SERVICE_WIN32_OWN_PROCESS = 16;

        /// SERVICE_WIN32 -> (SERVICE_WIN32_OWN_PROCESS |                                         SERVICE_WIN32_SHARE_PROCESS)
        public const int SERVICE_WIN32 = (NativeConstants.SERVICE_WIN32_OWN_PROCESS | NativeConstants.SERVICE_WIN32_SHARE_PROCESS);

        /// SERVICE_USER_DEFINED_CONTROL -> 0x0100
        public const int SERVICE_USER_DEFINED_CONTROL = 256;

        /// SERVICE_TYPE_ALL -> (SERVICE_WIN32  |                                         SERVICE_ADAPTER |                                         SERVICE_DRIVER  |                                         SERVICE_INTERACTIVE_PROCESS)
        public const int SERVICE_TYPE_ALL = (NativeConstants.SERVICE_WIN32
                    | (NativeConstants.SERVICE_ADAPTER
                    | (NativeConstants.SERVICE_DRIVER | NativeConstants.SERVICE_INTERACTIVE_PROCESS)));

        /// SERVICE_SYSTEM_START -> 0x00000001
        public const int SERVICE_SYSTEM_START = 1;

        /// SERVICE_STOP_PENDING -> 0x00000003
        public const int SERVICE_STOP_PENDING = 3;

        /// SERVICE_STOPPED -> 0x00000001
        public const int SERVICE_STOPPED = 1;

        /// SERVICE_STOP -> 0x0020
        public const int SERVICE_STOP = 32;

        /// SERVICE_STATE_ALL -> (SERVICE_ACTIVE   |                                         SERVICE_INACTIVE)
        public const int SERVICE_STATE_ALL = (NativeConstants.SERVICE_ACTIVE | NativeConstants.SERVICE_INACTIVE);

        /// SERVICE_START_PENDING -> 0x00000002
        public const int SERVICE_START_PENDING = 2;

        /// SERVICE_START -> 0x0010
        public const int SERVICE_START = 16;

        /// SERVICE_RUNS_IN_SYSTEM_PROCESS -> 0x00000001
        public const int SERVICE_RUNS_IN_SYSTEM_PROCESS = 1;

        /// SERVICE_RUNNING -> 0x00000004
        public const int SERVICE_RUNNING = 4;

        /// SERVICE_RECOGNIZER_DRIVER -> 0x00000008
        public const int SERVICE_RECOGNIZER_DRIVER = 8;

        /// SERVICE_QUERY_STATUS -> 0x0004
        public const int SERVICE_QUERY_STATUS = 4;

        /// SERVICE_QUERY_CONFIG -> 0x0001
        public const int SERVICE_QUERY_CONFIG = 1;

        /// SERVICE_PAUSE_PENDING -> 0x00000006
        public const int SERVICE_PAUSE_PENDING = 6;

        /// SERVICE_PAUSE_CONTINUE -> 0x0040
        public const int SERVICE_PAUSE_CONTINUE = 64;

        /// SERVICE_PAUSED -> 0x00000007
        public const int SERVICE_PAUSED = 7;

        /// SERVICE_NO_CHANGE -> 0xffffffff
        public const int SERVICE_NO_CHANGE = -1;

        /// SERVICE_KERNEL_DRIVER -> 0x00000001
        public const int SERVICE_KERNEL_DRIVER = 1;

        /// SERVICE_INTERROGATE -> 0x0080
        public const int SERVICE_INTERROGATE = 128;

        /// SERVICE_INTERACTIVE_PROCESS -> 0x00000100
        public const int SERVICE_INTERACTIVE_PROCESS = 256;

        /// SERVICE_INACTIVE -> 0x00000002
        public const int SERVICE_INACTIVE = 2;

        /// SERVICE_FILE_SYSTEM_DRIVER -> 0x00000002
        public const int SERVICE_FILE_SYSTEM_DRIVER = 2;

        /// SERVICE_ERROR_SEVERE -> 0x00000002
        public const int SERVICE_ERROR_SEVERE = 2;

        /// SERVICE_ERROR_NORMAL -> 0x00000001
        public const int SERVICE_ERROR_NORMAL = 1;

        /// SERVICE_ERROR_IGNORE -> 0x00000000
        public const int SERVICE_ERROR_IGNORE = 0;

        /// SERVICE_ERROR_CRITICAL -> 0x00000003
        public const int SERVICE_ERROR_CRITICAL = 3;

        /// SERVICE_ENUMERATE_DEPENDENTS -> 0x0008
        public const int SERVICE_ENUMERATE_DEPENDENTS = 8;

        /// SERVICE_DRIVER -> (SERVICE_KERNEL_DRIVER |                                         SERVICE_FILE_SYSTEM_DRIVER |                                         SERVICE_RECOGNIZER_DRIVER)
        public const int SERVICE_DRIVER = (NativeConstants.SERVICE_KERNEL_DRIVER
                    | (NativeConstants.SERVICE_FILE_SYSTEM_DRIVER | NativeConstants.SERVICE_RECOGNIZER_DRIVER));

        /// SERVICE_DISABLED -> 0x00000004
        public const int SERVICE_DISABLED = 4;

        /// SERVICE_DEMAND_START -> 0x00000003
        public const int SERVICE_DEMAND_START = 3;

        /// SERVICE_CONTROL_STOP -> 0x00000001
        public const int SERVICE_CONTROL_STOP = 1;

        /// SERVICE_CONTROL_SHUTDOWN -> 0x00000005
        public const int SERVICE_CONTROL_SHUTDOWN = 5;

        /// SERVICE_CONTROL_SESSIONCHANGE -> 0x0000000E
        public const int SERVICE_CONTROL_SESSIONCHANGE = 14;

        /// SERVICE_CONTROL_POWEREVENT -> 0x0000000D
        public const int SERVICE_CONTROL_POWEREVENT = 13;

        /// SERVICE_CONTROL_PAUSE -> 0x00000002
        public const int SERVICE_CONTROL_PAUSE = 2;

        /// SERVICE_CONTROL_PARAMCHANGE -> 0x00000006
        public const int SERVICE_CONTROL_PARAMCHANGE = 6;

        /// SERVICE_CONTROL_NETBINDREMOVE -> 0x00000008
        public const int SERVICE_CONTROL_NETBINDREMOVE = 8;

        /// SERVICE_CONTROL_NETBINDENABLE -> 0x00000009
        public const int SERVICE_CONTROL_NETBINDENABLE = 9;

        /// SERVICE_CONTROL_NETBINDDISABLE -> 0x0000000A
        public const int SERVICE_CONTROL_NETBINDDISABLE = 10;

        /// SERVICE_CONTROL_NETBINDADD -> 0x00000007
        public const int SERVICE_CONTROL_NETBINDADD = 7;

        /// SERVICE_CONTROL_INTERROGATE -> 0x00000004
        public const int SERVICE_CONTROL_INTERROGATE = 4;

        /// SERVICE_CONTROL_HARDWAREPROFILECHANGE -> 0x0000000C
        public const int SERVICE_CONTROL_HARDWAREPROFILECHANGE = 12;

        /// SERVICE_CONTROL_DEVICEEVENT -> 0x0000000B
        public const int SERVICE_CONTROL_DEVICEEVENT = 11;

        /// SERVICE_CONTROL_CONTINUE -> 0x00000003
        public const int SERVICE_CONTROL_CONTINUE = 3;

        /// SERVICE_CONTINUE_PENDING -> 0x00000005
        public const int SERVICE_CONTINUE_PENDING = 5;

        /// SERVICE_CONFIG_FAILURE_ACTIONS -> 2
        public const int SERVICE_CONFIG_FAILURE_ACTIONS = 2;

        /// SERVICE_CONFIG_DESCRIPTION -> 1
        public const int SERVICE_CONFIG_DESCRIPTION = 1;

        /// SERVICE_CHANGE_CONFIG -> 0x0002
        public const int SERVICE_CHANGE_CONFIG = 2;

        /// SERVICE_BOOT_START -> 0x00000000
        public const int SERVICE_BOOT_START = 0;

        /// SERVICE_AUTO_START -> 0x00000002
        public const int SERVICE_AUTO_START = 2;

        /// SERVICE_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED     |                                         SERVICE_QUERY_CONFIG         |                                         SERVICE_CHANGE_CONFIG        |                                         SERVICE_QUERY_STATUS         |                                         SERVICE_ENUMERATE_DEPENDENTS |                                         SERVICE_START                |                                         SERVICE_STOP                 |                                         SERVICE_PAUSE_CONTINUE       |                                         SERVICE_INTERROGATE          |                                         SERVICE_USER_DEFINED_CONTROL)
        public const int SERVICE_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SERVICE_QUERY_CONFIG
                    | (NativeConstants.SERVICE_CHANGE_CONFIG
                    | (NativeConstants.SERVICE_QUERY_STATUS
                    | (NativeConstants.SERVICE_ENUMERATE_DEPENDENTS
                    | (NativeConstants.SERVICE_START
                    | (NativeConstants.SERVICE_STOP
                    | (NativeConstants.SERVICE_PAUSE_CONTINUE
                    | (NativeConstants.SERVICE_INTERROGATE | NativeConstants.SERVICE_USER_DEFINED_CONTROL)))))))));

        /// SERVICE_ADAPTER -> 0x00000004
        public const int SERVICE_ADAPTER = 4;

        /// SERVICE_ACTIVE -> 0x00000001
        public const int SERVICE_ACTIVE = 1;

        /// SERVICE_ACCEPT_STOP -> 0x00000001
        public const int SERVICE_ACCEPT_STOP = 1;

        /// SERVICE_ACCEPT_SHUTDOWN -> 0x00000004
        public const int SERVICE_ACCEPT_SHUTDOWN = 4;

        /// SERVICE_ACCEPT_SESSIONCHANGE -> 0x00000080
        public const int SERVICE_ACCEPT_SESSIONCHANGE = 128;

        /// SERVICE_ACCEPT_POWEREVENT -> 0x00000040
        public const int SERVICE_ACCEPT_POWEREVENT = 64;

        /// SERVICE_ACCEPT_PAUSE_CONTINUE -> 0x00000002
        public const int SERVICE_ACCEPT_PAUSE_CONTINUE = 2;

        /// SERVICE_ACCEPT_PARAMCHANGE -> 0x00000008
        public const int SERVICE_ACCEPT_PARAMCHANGE = 8;

        /// SERVICE_ACCEPT_NETBINDCHANGE -> 0x00000010
        public const int SERVICE_ACCEPT_NETBINDCHANGE = 16;

        /// SERVICE_ACCEPT_HARDWAREPROFILECHANGE -> 0x00000020
        public const int SERVICE_ACCEPT_HARDWAREPROFILECHANGE = 32;

        /// SERVICES_FAILED_DATABASEW -> L"ServicesFailed"
        public const string SERVICES_FAILED_DATABASEW = "ServicesFailed";

        /// SERVICES_FAILED_DATABASEA -> "ServicesFailed"
        public const string SERVICES_FAILED_DATABASEA = "ServicesFailed";

        /// SERVICES_FAILED_DATABASE -> SERVICES_FAILED_DATABASEW
        public const string SERVICES_FAILED_DATABASE = NativeConstants.SERVICES_FAILED_DATABASEW;

        /// SERVICES_ACTIVE_DATABASEW -> L"ServicesActive"
        public const string SERVICES_ACTIVE_DATABASEW = "ServicesActive";

        /// SERVICES_ACTIVE_DATABASEA -> "ServicesActive"
        public const string SERVICES_ACTIVE_DATABASEA = "ServicesActive";

        /// SERVICES_ACTIVE_DATABASE -> SERVICES_ACTIVE_DATABASEW
        public const string SERVICES_ACTIVE_DATABASE = NativeConstants.SERVICES_ACTIVE_DATABASEW;

        /// SERVER_WRITE -> (STANDARD_RIGHTS_WRITE         |                              SERVER_ACCESS_ADMINISTER      |                              SERVER_ACCESS_ENUMERATE)
        public const int SERVER_WRITE = (NativeConstants.STANDARD_RIGHTS_WRITE
                    | (NativeConstants.SERVER_ACCESS_ADMINISTER | NativeConstants.SERVER_ACCESS_ENUMERATE));

        /// SERVER_READ -> (STANDARD_RIGHTS_READ          |                              SERVER_ACCESS_ENUMERATE)
        public const int SERVER_READ = (NativeConstants.STANDARD_RIGHTS_READ | NativeConstants.SERVER_ACCESS_ENUMERATE);

        /// SERVER_EXECUTE -> (STANDARD_RIGHTS_EXECUTE       |                              SERVER_ACCESS_ENUMERATE)
        public const int SERVER_EXECUTE = (NativeConstants.STANDARD_RIGHTS_EXECUTE | NativeConstants.SERVER_ACCESS_ENUMERATE);

        /// SERVER_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED      |                              SERVER_ACCESS_ADMINISTER      |                              SERVER_ACCESS_ENUMERATE)
        public const int SERVER_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SERVER_ACCESS_ADMINISTER | NativeConstants.SERVER_ACCESS_ENUMERATE));

        /// SERVER_ACCESS_ENUMERATE -> 0x00000002
        public const int SERVER_ACCESS_ENUMERATE = 2;

        /// SERVER_ACCESS_ADMINISTER -> 0x00000001
        public const int SERVER_ACCESS_ADMINISTER = 1;

        /// SERKF_SERIALKEYSON -> 0x00000001
        public const int SERKF_SERIALKEYSON = 1;

        /// SERKF_INDICATOR -> 0x00000004
        public const int SERKF_INDICATOR = 4;

        /// SERKF_AVAILABLE -> 0x00000002
        public const int SERKF_AVAILABLE = 2;

        /// SERIAL_NUMBER_LENGTH -> 32
        public const int SERIAL_NUMBER_LENGTH = 32;

        /// SendNotifyMessage -> SendNotifyMessageW
        /// Error generating expression: Value SendNotifyMessageW is not resolved
        public const string SendNotifyMessage = "SendNotifyMessageW";

        /// SendMessageTimeout -> SendMessageTimeoutW
        /// Error generating expression: Value SendMessageTimeoutW is not resolved
        public const string SendMessageTimeout = "SendMessageTimeoutW";

        /// SendMessageCallback -> SendMessageCallbackW
        /// Error generating expression: Value SendMessageCallbackW is not resolved
        public const string SendMessageCallback = "SendMessageCallbackW";

        /// SendMessage -> SendMessageW
        /// Error generating expression: Value SendMessageW is not resolved
        public const string SendMessage = "SendMessageW";

        /// SendDlgItemMessage -> SendDlgItemMessageW
        /// Error generating expression: Value SendDlgItemMessageW is not resolved
        public const string SendDlgItemMessage = "SendDlgItemMessageW";

        /// SEM_NOOPENFILEERRORBOX -> 0x8000
        public const int SEM_NOOPENFILEERRORBOX = 32768;

        /// SEM_NOGPFAULTERRORBOX -> 0x0002
        public const int SEM_NOGPFAULTERRORBOX = 2;

        /// SEM_NOALIGNMENTFAULTEXCEPT -> 0x0004
        public const int SEM_NOALIGNMENTFAULTEXCEPT = 4;

        /// SEM_FAILCRITICALERRORS -> 0x0001
        public const int SEM_FAILCRITICALERRORS = 1;

        /// SEMAPHORE_MODIFY_STATE -> 0x0002
        public const int SEMAPHORE_MODIFY_STATE = 2;

        /// SEMAPHORE_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)
        public const int SEMAPHORE_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SYNCHRONIZE | 3));

        /// SELECT_CAP_SENTENCE -> 0x00000002
        public const int SELECT_CAP_SENTENCE = 2;

        /// SELECT_CAP_CONVERSION -> 0x00000001
        public const int SELECT_CAP_CONVERSION = 1;

        /// SELECTPAPERSOURCE -> 18
        public const int SELECTPAPERSOURCE = 18;

        /// SELECTDIB -> 41
        public const int SELECTDIB = 41;

        /// SEF_SACL_AUTO_INHERIT -> 0x02
        public const int SEF_SACL_AUTO_INHERIT = 2;

        /// SEF_DEFAULT_OWNER_FROM_PARENT -> 0x20
        public const int SEF_DEFAULT_OWNER_FROM_PARENT = 32;

        /// SEF_DEFAULT_GROUP_FROM_PARENT -> 0x40
        public const int SEF_DEFAULT_GROUP_FROM_PARENT = 64;

        /// SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT -> 0x04
        public const int SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT = 4;

        /// SEF_DACL_AUTO_INHERIT -> 0x01
        public const int SEF_DACL_AUTO_INHERIT = 1;

        /// SEF_AVOID_PRIVILEGE_CHECK -> 0x08
        public const int SEF_AVOID_PRIVILEGE_CHECK = 8;

        /// SEF_AVOID_OWNER_CHECK -> 0x10
        public const int SEF_AVOID_OWNER_CHECK = 16;

        /// SEE_MASK_UNICODE -> 0x00004000
        public const int SEE_MASK_UNICODE = 16384;

        /// SEE_MASK_NO_CONSOLE -> 0x00008000
        public const int SEE_MASK_NO_CONSOLE = 32768;

        /// SEE_MASK_NOCLOSEPROCESS -> 0x00000040
        public const int SEE_MASK_NOCLOSEPROCESS = 64;

        /// SEE_MASK_INVOKEIDLIST -> 0x0000000c
        public const int SEE_MASK_INVOKEIDLIST = 12;

        /// SEE_MASK_IDLIST -> 0x00000004
        public const int SEE_MASK_IDLIST = 4;

        /// SEE_MASK_ICON -> 0x00000010
        public const int SEE_MASK_ICON = 16;

        /// SEE_MASK_HOTKEY -> 0x00000020
        public const int SEE_MASK_HOTKEY = 32;

        /// SEE_MASK_HMONITOR -> 0x00200000
        public const int SEE_MASK_HMONITOR = 2097152;

        /// SEE_MASK_FLAG_NO_UI -> 0x00000400
        public const int SEE_MASK_FLAG_NO_UI = 1024;

        /// SEE_MASK_FLAG_DDEWAIT -> 0x00000100
        public const int SEE_MASK_FLAG_DDEWAIT = 256;

        /// SEE_MASK_DOENVSUBST -> 0x00000200
        public const int SEE_MASK_DOENVSUBST = 512;

        /// SEE_MASK_CONNECTNETDRV -> 0x00000080
        public const int SEE_MASK_CONNECTNETDRV = 128;

        /// SEE_MASK_CLASSNAME -> 0x00000001
        public const int SEE_MASK_CLASSNAME = 1;

        /// SEE_MASK_CLASSKEY -> 0x00000003
        public const int SEE_MASK_CLASSKEY = 3;

        /// SEE_MASK_ASYNCOK -> 0x00100000
        public const int SEE_MASK_ASYNCOK = 1048576;

        /// SEEK_SET -> 0
        public const int SEEK_SET = 0;

        /// SEEK_END -> 2
        public const int SEEK_END = 2;

        /// SEEK_CUR -> 1
        public const int SEEK_CUR = 1;

        /// SEC_WINNT_AUTH_IDENTITY_UNICODE -> 0x2
        public const int SEC_WINNT_AUTH_IDENTITY_UNICODE = 2;

        /// SEC_WINNT_AUTH_IDENTITY_ANSI -> 0x1
        public const int SEC_WINNT_AUTH_IDENTITY_ANSI = 1;

        /// SEC_WINNT_AUTH_IDENTITY -> SEC_WINNT_AUTH_IDENTITY_W
        /// Error generating expression: Value SEC_WINNT_AUTH_IDENTITY_W is not resolved
        public const string SEC_WINNT_AUTH_IDENTITY = "SEC_WINNT_AUTH_IDENTITY_W";

        /// SEC_RESERVE -> 0x4000000
        public const int SEC_RESERVE = 67108864;

        /// SEC_NOCACHE -> 0x10000000
        public const int SEC_NOCACHE = 268435456;

        /// SEC_LARGE_PAGES -> 0x80000000
        public const int SEC_LARGE_PAGES = -2147483648;

        /// SEC_IMAGE -> 0x1000000
        public const int SEC_IMAGE = 16777216;

        /// SEC_FILE -> 0x800000
        public const int SEC_FILE = 8388608;

        /// SEC_E_NO_SPM -> SEC_E_INTERNAL_ERROR
        public const string SEC_E_NO_SPM = NativeConstants.SEC_E_INTERNAL_ERROR;

        /// SEC_E_NOT_SUPPORTED -> SEC_E_UNSUPPORTED_FUNCTION
        public const string SEC_E_NOT_SUPPORTED = NativeConstants.SEC_E_UNSUPPORTED_FUNCTION;

        /// SEC_COMMIT -> 0x8000000
        public const int SEC_COMMIT = 134217728;

        /// SECURITY_WORLD_RID -> (0x00000000L)
        public const int SECURITY_WORLD_RID = 0;

        /// SECURITY_VALID_SQOS_FLAGS -> 0x001F0000
        public const int SECURITY_VALID_SQOS_FLAGS = 2031616;

        /// SECURITY_THIS_ORGANIZATION_RID -> (0x0000000FL)
        public const int SECURITY_THIS_ORGANIZATION_RID = 15;

        /// SECURITY_TERMINAL_SERVER_RID -> (0x0000000DL)
        public const int SECURITY_TERMINAL_SERVER_RID = 13;

        /// SECURITY_STATIC_TRACKING -> (FALSE)
        public const int SECURITY_STATIC_TRACKING = NativeConstants.FALSE;

        /// SECURITY_SQOS_PRESENT -> 0x00100000
        public const int SECURITY_SQOS_PRESENT = 1048576;

        /// SECURITY_SERVICE_RID -> (0x00000006L)
        public const int SECURITY_SERVICE_RID = 6;

        /// SECURITY_SERVER_LOGON_RID -> SECURITY_ENTERPRISE_CONTROLLERS_RID
        public const int SECURITY_SERVER_LOGON_RID = NativeConstants.SECURITY_ENTERPRISE_CONTROLLERS_RID;

        /// SECURITY_RESTRICTED_CODE_RID -> (0x0000000CL)
        public const int SECURITY_RESTRICTED_CODE_RID = 12;

        /// SECURITY_REMOTE_LOGON_RID -> (0x0000000EL)
        public const int SECURITY_REMOTE_LOGON_RID = 14;

        /// SECURITY_PROXY_RID -> (0x00000008L)
        public const int SECURITY_PROXY_RID = 8;

        /// SECURITY_PRINCIPAL_SELF_RID -> (0x0000000AL)
        public const int SECURITY_PRINCIPAL_SELF_RID = 10;

        /// SECURITY_PACKAGE_SCHANNEL_RID -> (0x0000000EL)
        public const int SECURITY_PACKAGE_SCHANNEL_RID = 14;

        /// SECURITY_PACKAGE_RID_COUNT -> (2L)
        public const int SECURITY_PACKAGE_RID_COUNT = 2;

        /// SECURITY_PACKAGE_NTLM_RID -> (0x0000000AL)
        public const int SECURITY_PACKAGE_NTLM_RID = 10;

        /// SECURITY_PACKAGE_DIGEST_RID -> (0x00000015L)
        public const int SECURITY_PACKAGE_DIGEST_RID = 21;

        /// SECURITY_PACKAGE_BASE_RID -> (0x00000040L)
        public const int SECURITY_PACKAGE_BASE_RID = 64;

        /// SECURITY_OTHER_ORGANIZATION_RID -> (0x000003E8L)
        public const int SECURITY_OTHER_ORGANIZATION_RID = 1000;

        /// SECURITY_NULL_RID -> (0x00000000L)
        public const int SECURITY_NULL_RID = 0;

        /// SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT -> (3L)
        public const int SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT = 3;

        /// SECURITY_NT_NON_UNIQUE -> (0x00000015L)
        public const int SECURITY_NT_NON_UNIQUE = 21;

        /// SECURITY_NETWORK_SERVICE_RID -> (0x00000014L)
        public const int SECURITY_NETWORK_SERVICE_RID = 20;

        /// SECURITY_NETWORK_RID -> (0x00000002L)
        public const int SECURITY_NETWORK_RID = 2;

        /// SECURITY_MIN_NEVER_FILTERED -> (0x000003E8L)
        public const int SECURITY_MIN_NEVER_FILTERED = 1000;

        /// SECURITY_MIN_IMPERSONATION_LEVEL -> SecurityAnonymous
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_MIN_IMPERSONATION_LEVEL = SECURITY_IMPERSONATION_LEVEL.SecurityAnonymous;

        /// SECURITY_MAX_IMPERSONATION_LEVEL -> SecurityDelegation
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_MAX_IMPERSONATION_LEVEL = SECURITY_IMPERSONATION_LEVEL.SecurityDelegation;

        /// SECURITY_MAX_ALWAYS_FILTERED -> (0x000003E7L)
        public const int SECURITY_MAX_ALWAYS_FILTERED = 999;

        /// SECURITY_LOGON_IDS_RID_COUNT -> (3L)
        public const int SECURITY_LOGON_IDS_RID_COUNT = 3;

        /// SECURITY_LOGON_IDS_RID -> (0x00000005L)
        public const int SECURITY_LOGON_IDS_RID = 5;

        /// SECURITY_LOCAL_SYSTEM_RID -> (0x00000012L)
        public const int SECURITY_LOCAL_SYSTEM_RID = 18;

        /// SECURITY_LOCAL_SERVICE_RID -> (0x00000013L)
        public const int SECURITY_LOCAL_SERVICE_RID = 19;

        /// SECURITY_LOCAL_RID -> (0x00000000L)
        public const int SECURITY_LOCAL_RID = 0;

        /// SECURITY_INTERACTIVE_RID -> (0x00000004L)
        public const int SECURITY_INTERACTIVE_RID = 4;

        /// SECURITY_IMPERSONATION -> ( SecurityImpersonation  << 16 )
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_IMPERSONATION = SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation;

        /// SECURITY_IDENTIFICATION -> ( SecurityIdentification << 16 )
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_IDENTIFICATION = SECURITY_IMPERSONATION_LEVEL.SecurityIdentification;

        /// SECURITY_ENTERPRISE_CONTROLLERS_RID -> (0x00000009L)
        public const int SECURITY_ENTERPRISE_CONTROLLERS_RID = 9;

        /// SECURITY_EFFECTIVE_ONLY -> 0x00080000
        public const int SECURITY_EFFECTIVE_ONLY = 524288;

        /// SECURITY_DYNAMIC_TRACKING -> (TRUE)
        public const int SECURITY_DYNAMIC_TRACKING = NativeConstants.TRUE;

        /// SECURITY_DIALUP_RID -> (0x00000001L)
        public const int SECURITY_DIALUP_RID = 1;

        /// SECURITY_DESCRIPTOR_REVISION1 -> (1)
        public const int SECURITY_DESCRIPTOR_REVISION1 = 1;

        /// SECURITY_DESCRIPTOR_REVISION -> (1)
        public const int SECURITY_DESCRIPTOR_REVISION = 1;

        /// SECURITY_DELEGATION -> ( SecurityDelegation     << 16 )
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_DELEGATION = SECURITY_IMPERSONATION_LEVEL.SecurityDelegation;

        /// SECURITY_CREATOR_OWNER_SERVER_RID -> (0x00000002L)
        public const int SECURITY_CREATOR_OWNER_SERVER_RID = 2;

        /// SECURITY_CREATOR_OWNER_RID -> (0x00000000L)
        public const int SECURITY_CREATOR_OWNER_RID = 0;

        /// SECURITY_CREATOR_GROUP_SERVER_RID -> (0x00000003L)
        public const int SECURITY_CREATOR_GROUP_SERVER_RID = 3;

        /// SECURITY_CREATOR_GROUP_RID -> (0x00000001L)
        public const int SECURITY_CREATOR_GROUP_RID = 1;

        /// SECURITY_CONTEXT_TRACKING -> 0x00040000
        public const int SECURITY_CONTEXT_TRACKING = 262144;

        /// SECURITY_BUILTIN_DOMAIN_RID -> (0x00000020L)
        public const int SECURITY_BUILTIN_DOMAIN_RID = 32;

        /// SECURITY_BATCH_RID -> (0x00000003L)
        public const int SECURITY_BATCH_RID = 3;

        /// SECURITY_AUTHENTICATED_USER_RID -> (0x0000000BL)
        public const int SECURITY_AUTHENTICATED_USER_RID = 11;

        /// SECURITY_ANONYMOUS_LOGON_RID -> (0x00000007L)
        public const int SECURITY_ANONYMOUS_LOGON_RID = 7;

        /// SECURITY_ANONYMOUS -> ( SecurityAnonymous      << 16 )
        public const SECURITY_IMPERSONATION_LEVEL SECURITY_ANONYMOUS = SECURITY_IMPERSONATION_LEVEL.SecurityAnonymous;

        /// SecureZeroMemory -> RtlSecureZeroMemory
        /// Error generating expression: Value RtlSecureZeroMemory is not resolved
        public const string SecureZeroMemory = "RtlSecureZeroMemory";

        /// SECTION_QUERY -> 0x0001
        public const int SECTION_QUERY = 1;

        /// SECTION_MAP_WRITE -> 0x0002
        public const int SECTION_MAP_WRITE = 2;

        /// SECTION_MAP_READ -> 0x0004
        public const int SECTION_MAP_READ = 4;

        /// SECTION_MAP_EXECUTE_EXPLICIT -> 0x0020
        public const int SECTION_MAP_EXECUTE_EXPLICIT = 32;

        /// SECTION_MAP_EXECUTE -> 0x0008
        public const int SECTION_MAP_EXECUTE = 8;

        /// SECTION_EXTEND_SIZE -> 0x0010
        public const int SECTION_EXTEND_SIZE = 16;

        /// SECTION_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED|SECTION_QUERY|                            SECTION_MAP_WRITE |                                  SECTION_MAP_READ |                                   SECTION_MAP_EXECUTE |                                SECTION_EXTEND_SIZE)
        public const int SECTION_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SECTION_QUERY
                    | (NativeConstants.SECTION_MAP_WRITE
                    | (NativeConstants.SECTION_MAP_READ
                    | (NativeConstants.SECTION_MAP_EXECUTE | NativeConstants.SECTION_EXTEND_SIZE)))));

        /// SEARCH_PRI_NO_SEQ -> 0x5
        public const int SEARCH_PRI_NO_SEQ = 5;

        /// SEARCH_PRIMARY -> 0x1
        public const int SEARCH_PRIMARY = 1;

        /// SEARCH_ALT_NO_SEQ -> 0x6
        public const int SEARCH_ALT_NO_SEQ = 6;

        /// SEARCH_ALTERNATE -> 0x2
        public const int SEARCH_ALTERNATE = 2;

        /// SEARCH_ALL_NO_SEQ -> 0x4
        public const int SEARCH_ALL_NO_SEQ = 4;

        /// SEARCH_ALL -> 0x0
        public const int SEARCH_ALL = 0;

        /// SearchPath -> SearchPathW
        /// Error generating expression: Value SearchPathW is not resolved
        public const string SearchPath = "SearchPathW";

        /// SC_ZOOM -> SC_MAXIMIZE
        public const int SC_ZOOM = NativeConstants.SC_MAXIMIZE;

        /// SC_VSCROLL -> 0xF070
        public const int SC_VSCROLL = 61552;

        /// SC_TASKLIST -> 0xF130
        public const int SC_TASKLIST = 61744;

        /// SC_SIZE -> 0xF000
        public const int SC_SIZE = 61440;

        /// SC_SEPARATOR -> 0xF00F
        public const int SC_SEPARATOR = 61455;

        /// SC_SCREENSAVE -> 0xF140
        public const int SC_SCREENSAVE = 61760;

        /// SC_RESTORE -> 0xF120
        public const int SC_RESTORE = 61728;

        /// SC_PREVWINDOW -> 0xF050
        public const int SC_PREVWINDOW = 61520;

        /// SC_NEXTWINDOW -> 0xF040
        public const int SC_NEXTWINDOW = 61504;

        /// SC_MOVE -> 0xF010
        public const int SC_MOVE = 61456;

        /// SC_MOUSEMENU -> 0xF090
        public const int SC_MOUSEMENU = 61584;

        /// SC_MONITORPOWER -> 0xF170
        public const int SC_MONITORPOWER = 61808;

        /// SC_MINIMIZE -> 0xF020
        public const int SC_MINIMIZE = 61472;

        /// SC_MAXIMIZE -> 0xF030
        public const int SC_MAXIMIZE = 61488;

        /// SC_MANAGER_QUERY_LOCK_STATUS -> 0x0010
        public const int SC_MANAGER_QUERY_LOCK_STATUS = 16;

        /// SC_MANAGER_MODIFY_BOOT_CONFIG -> 0x0020
        public const int SC_MANAGER_MODIFY_BOOT_CONFIG = 32;

        /// SC_MANAGER_LOCK -> 0x0008
        public const int SC_MANAGER_LOCK = 8;

        /// SC_MANAGER_ENUMERATE_SERVICE -> 0x0004
        public const int SC_MANAGER_ENUMERATE_SERVICE = 4;

        /// SC_MANAGER_CREATE_SERVICE -> 0x0002
        public const int SC_MANAGER_CREATE_SERVICE = 2;

        /// SC_MANAGER_CONNECT -> 0x0001
        public const int SC_MANAGER_CONNECT = 1;

        /// SC_MANAGER_ALL_ACCESS -> (STANDARD_RIGHTS_REQUIRED      |                                         SC_MANAGER_CONNECT            |                                         SC_MANAGER_CREATE_SERVICE     |                                         SC_MANAGER_ENUMERATE_SERVICE  |                                         SC_MANAGER_LOCK               |                                         SC_MANAGER_QUERY_LOCK_STATUS  |                                         SC_MANAGER_MODIFY_BOOT_CONFIG)
        public const int SC_MANAGER_ALL_ACCESS = (NativeConstants.STANDARD_RIGHTS_REQUIRED
                    | (NativeConstants.SC_MANAGER_CONNECT
                    | (NativeConstants.SC_MANAGER_CREATE_SERVICE
                    | (NativeConstants.SC_MANAGER_ENUMERATE_SERVICE
                    | (NativeConstants.SC_MANAGER_LOCK
                    | (NativeConstants.SC_MANAGER_QUERY_LOCK_STATUS | NativeConstants.SC_MANAGER_MODIFY_BOOT_CONFIG))))));

        /// SC_KEYMENU -> 0xF100
        public const int SC_KEYMENU = 61696;

        /// SC_ICON -> SC_MINIMIZE
        public const int SC_ICON = NativeConstants.SC_MINIMIZE;

        /// SC_HSCROLL -> 0xF080
        public const int SC_HSCROLL = 61568;

        /// SC_HOTKEY -> 0xF150
        public const int SC_HOTKEY = 61776;

        /// SC_GROUP_IDENTIFIERW -> L'+'
        public const char SC_GROUP_IDENTIFIERW = '+';

        /// SC_GROUP_IDENTIFIERA -> '+'
        public const char SC_GROUP_IDENTIFIERA = '+';

        /// SC_GROUP_IDENTIFIER -> SC_GROUP_IDENTIFIERW
        public const char SC_GROUP_IDENTIFIER = NativeConstants.SC_GROUP_IDENTIFIERW;

        /// SC_DLG_NO_UI -> 0x02
        public const int SC_DLG_NO_UI = 2;

        /// SC_DLG_MINIMAL_UI -> 0x01
        public const int SC_DLG_MINIMAL_UI = 1;

        /// SC_DLG_FORCE_UI -> 0x04
        public const int SC_DLG_FORCE_UI = 4;

        /// SC_DEFAULT -> 0xF160
        public const int SC_DEFAULT = 61792;

        /// SC_CONTEXTHELP -> 0xF180
        public const int SC_CONTEXTHELP = 61824;

        /// SC_CLOSE -> 0xF060
        public const int SC_CLOSE = 61536;

        /// SC_ARRANGE -> 0xF110
        public const int SC_ARRANGE = 61712;

        /// SCS_WOW_BINARY -> 2
        public const int SCS_WOW_BINARY = 2;

        /// SCS_THIS_PLATFORM_BINARY -> SCS_32BIT_BINARY
        public const int SCS_THIS_PLATFORM_BINARY = NativeConstants.SCS_32BIT_BINARY;

        /// SCS_SETSTR -> (GCS_COMPREADSTR|GCS_COMPSTR)
        public const int SCS_SETSTR = (NativeConstants.GCS_COMPREADSTR | NativeConstants.GCS_COMPSTR);

        /// SCS_SETRECONVERTSTRING -> 0x00010000
        public const int SCS_SETRECONVERTSTRING = 65536;

        /// SCS_QUERYRECONVERTSTRING -> 0x00020000
        public const int SCS_QUERYRECONVERTSTRING = 131072;

        /// SCS_POSIX_BINARY -> 4
        public const int SCS_POSIX_BINARY = 4;

        /// SCS_PIF_BINARY -> 3
        public const int SCS_PIF_BINARY = 3;

        /// SCS_OS216_BINARY -> 5
        public const int SCS_OS216_BINARY = 5;

        /// SCS_DOS_BINARY -> 1
        public const int SCS_DOS_BINARY = 1;

        /// SCS_CHANGECLAUSE -> (GCS_COMPREADCLAUSE|GCS_COMPCLAUSE)
        public const int SCS_CHANGECLAUSE = (NativeConstants.GCS_COMPREADCLAUSE | NativeConstants.GCS_COMPCLAUSE);

        /// SCS_CHANGEATTR -> (GCS_COMPREADATTR|GCS_COMPATTR)
        public const int SCS_CHANGEATTR = (NativeConstants.GCS_COMPREADATTR | NativeConstants.GCS_COMPATTR);

        /// SCS_CAP_SETRECONVERTSTRING -> 0x00000004
        public const int SCS_CAP_SETRECONVERTSTRING = 4;

        /// SCS_CAP_MAKEREAD -> 0x00000002
        public const int SCS_CAP_MAKEREAD = 2;

        /// SCS_CAP_COMPSTR -> 0x00000001
        public const int SCS_CAP_COMPSTR = 1;

        /// SCS_64BIT_BINARY -> 6
        public const int SCS_64BIT_BINARY = 6;

        /// SCS_32BIT_BINARY -> 0
        public const int SCS_32BIT_BINARY = 0;

        /// SCROLLLOCK_ON -> 0x0040
        public const int SCROLLLOCK_ON = 64;

        /// ScrollConsoleScreenBuffer -> ScrollConsoleScreenBufferW
        /// Error generating expression: Value ScrollConsoleScreenBufferW is not resolved
        public const string ScrollConsoleScreenBuffer = "ScrollConsoleScreenBufferW";

        /// SCREEN_FONTTYPE -> 0x2000
        public const int SCREEN_FONTTYPE = 8192;

        /// scr8 -> 0x0497
        public const int scr8 = 1175;

        /// scr7 -> 0x0496
        public const int scr7 = 1174;

        /// scr6 -> 0x0495
        public const int scr6 = 1173;

        /// scr5 -> 0x0494
        public const int scr5 = 1172;

        /// scr4 -> 0x0493
        public const int scr4 = 1171;

        /// scr3 -> 0x0492
        public const int scr3 = 1170;

        /// scr2 -> 0x0491
        public const int scr2 = 1169;

        /// scr1 -> 0x0490
        public const int scr1 = 1168;

        /// SCHEME_OID_RETRIEVE_ENCODED_OBJECT_FUNC -> "SchemeDllRetrieveEncodedObject"
        public const string SCHEME_OID_RETRIEVE_ENCODED_OBJECT_FUNC = "SchemeDllRetrieveEncodedObject";

        /// SCHEME_OID_RETRIEVE_ENCODED_OBJECTW_FUNC -> "SchemeDllRetrieveEncodedObjectW"
        public const string SCHEME_OID_RETRIEVE_ENCODED_OBJECTW_FUNC = "SchemeDllRetrieveEncodedObjectW";

        /// SCHED_E_SERVICE_NOT_LOCALSYSTEM -> 6200L
        public const int SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200;

        /// SCHAR_MIN -> (-128)
        public const int SCHAR_MIN = -128;

        /// SCHAR_MAX -> 127
        public const int SCHAR_MAX = 127;

        /// SCHANNEL_MAC_KEY -> 0x00000000
        public const int SCHANNEL_MAC_KEY = 0;

        /// SCHANNEL_ENC_KEY -> 0x00000001
        public const int SCHANNEL_ENC_KEY = 1;

        /// SCERR_NOGUIDS -> 0x8000
        public const int SCERR_NOGUIDS = 32768;

        /// SCERR_NOCARDNAME -> 0x4000
        public const int SCERR_NOCARDNAME = 16384;

        /// SCARD_WARM_RESET -> 2
        public const int SCARD_WARM_RESET = 2;

        /// SCARD_UNPOWER_CARD -> 2
        public const int SCARD_UNPOWER_CARD = 2;

        /// SCARD_UNKNOWN -> 0
        public const int SCARD_UNKNOWN = 0;

        /// SCARD_T1_PROLOGUE_LENGTH -> 3
        public const int SCARD_T1_PROLOGUE_LENGTH = 3;

        /// SCARD_T1_MAX_IFS -> 254
        public const int SCARD_T1_MAX_IFS = 254;

        /// SCARD_T1_EPILOGUE_LENGTH -> 2
        public const int SCARD_T1_EPILOGUE_LENGTH = 2;

        /// SCARD_T0_HEADER_LENGTH -> 7
        public const int SCARD_T0_HEADER_LENGTH = 7;

        /// SCARD_T0_CMD_LENGTH -> 5
        public const int SCARD_T0_CMD_LENGTH = 5;

        /// SCARD_S_SUCCESS -> NO_ERROR
        public const int SCARD_S_SUCCESS = NativeConstants.NO_ERROR;

        /// SCARD_SWALLOWED -> 3
        public const int SCARD_SWALLOWED = 3;

        /// SCARD_STATE_UNPOWERED -> 0x00000400
        public const int SCARD_STATE_UNPOWERED = 1024;

        /// SCARD_STATE_UNKNOWN -> 0x00000004
        public const int SCARD_STATE_UNKNOWN = 4;

        /// SCARD_STATE_UNAWARE -> 0x00000000
        public const int SCARD_STATE_UNAWARE = 0;

        /// SCARD_STATE_UNAVAILABLE -> 0x00000008
        public const int SCARD_STATE_UNAVAILABLE = 8;

        /// SCARD_STATE_PRESENT -> 0x00000020
        public const int SCARD_STATE_PRESENT = 32;

        /// SCARD_STATE_MUTE -> 0x00000200
        public const int SCARD_STATE_MUTE = 512;

        /// SCARD_STATE_INUSE -> 0x00000100
        public const int SCARD_STATE_INUSE = 256;

        /// SCARD_STATE_IGNORE -> 0x00000001
        public const int SCARD_STATE_IGNORE = 1;

        /// SCARD_STATE_EXCLUSIVE -> 0x00000080
        public const int SCARD_STATE_EXCLUSIVE = 128;

        /// SCARD_STATE_EMPTY -> 0x00000010
        public const int SCARD_STATE_EMPTY = 16;

        /// SCARD_STATE_CHANGED -> 0x00000002
        public const int SCARD_STATE_CHANGED = 2;

        /// SCARD_STATE_ATRMATCH -> 0x00000040
        public const int SCARD_STATE_ATRMATCH = 64;

        /// SCARD_SPECIFIC -> 6
        public const int SCARD_SPECIFIC = 6;

        /// SCARD_SHARE_SHARED -> 2
        public const int SCARD_SHARE_SHARED = 2;

        /// SCARD_SHARE_EXCLUSIVE -> 1
        public const int SCARD_SHARE_EXCLUSIVE = 1;

        /// SCARD_SHARE_DIRECT -> 3
        public const int SCARD_SHARE_DIRECT = 3;

        /// SCARD_SCOPE_USER -> 0
        public const int SCARD_SCOPE_USER = 0;

        /// SCARD_SCOPE_TERMINAL -> 1
        public const int SCARD_SCOPE_TERMINAL = 1;

        /// SCARD_SCOPE_SYSTEM -> 2
        public const int SCARD_SCOPE_SYSTEM = 2;

        /// SCARD_RESET_CARD -> 1
        public const int SCARD_RESET_CARD = 1;

        /// SCARD_READER_TYPE_VENDOR -> 0xF0
        public const int SCARD_READER_TYPE_VENDOR = 240;

        /// SCARD_READER_TYPE_USB -> 0x20
        public const int SCARD_READER_TYPE_USB = 32;

        /// SCARD_READER_TYPE_SERIAL -> 0x01
        public const int SCARD_READER_TYPE_SERIAL = 1;

        /// SCARD_READER_TYPE_SCSI -> 0x08
        public const int SCARD_READER_TYPE_SCSI = 8;

        /// SCARD_READER_TYPE_PCMCIA -> 0x40
        public const int SCARD_READER_TYPE_PCMCIA = 64;

        /// SCARD_READER_TYPE_PARALELL -> 0x02
        public const int SCARD_READER_TYPE_PARALELL = 2;

        /// SCARD_READER_TYPE_KEYBOARD -> 0x04
        public const int SCARD_READER_TYPE_KEYBOARD = 4;

        /// SCARD_READER_TYPE_IDE -> 0x10
        public const int SCARD_READER_TYPE_IDE = 16;

        /// SCARD_READER_SWALLOWS -> 0x00000001
        public const int SCARD_READER_SWALLOWS = 1;

        /// SCARD_READER_EJECTS -> 0x00000002
        public const int SCARD_READER_EJECTS = 2;

        /// SCARD_READER_CONFISCATES -> 0x00000004
        public const int SCARD_READER_CONFISCATES = 4;

        /// SCARD_READERSTATE_W -> SCARD_READERSTATEW
        /// Error generating expression: Value SCARD_READERSTATEW is not resolved
        public const string SCARD_READERSTATE_W = "SCARD_READERSTATEW";

        /// SCARD_READERSTATE_A -> SCARD_READERSTATEA
        /// Error generating expression: Value SCARD_READERSTATEA is not resolved
        public const string SCARD_READERSTATE_A = "SCARD_READERSTATEA";

        /// SCARD_PROVIDER_PRIMARY -> 1
        public const int SCARD_PROVIDER_PRIMARY = 1;

        /// SCARD_PROVIDER_CSP -> 2
        public const int SCARD_PROVIDER_CSP = 2;

        /// SCARD_PROTOCOL_UNDEFINED -> 0x00000000
        public const int SCARD_PROTOCOL_UNDEFINED = 0;

        /// SCARD_PROTOCOL_Tx -> (SCARD_PROTOCOL_T0 | SCARD_PROTOCOL_T1)
        public const int SCARD_PROTOCOL_Tx = (NativeConstants.SCARD_PROTOCOL_T0 | NativeConstants.SCARD_PROTOCOL_T1);

        /// SCARD_PROTOCOL_T1 -> 0x00000002
        public const int SCARD_PROTOCOL_T1 = 2;

        /// SCARD_PROTOCOL_T0 -> 0x00000001
        public const int SCARD_PROTOCOL_T0 = 1;

        /// SCARD_PROTOCOL_RAW -> 0x00010000
        public const int SCARD_PROTOCOL_RAW = 65536;

        /// SCARD_PROTOCOL_OPTIMAL -> 0x00000000
        public const int SCARD_PROTOCOL_OPTIMAL = 0;

        /// SCARD_PROTOCOL_DEFAULT -> 0x80000000
        public const int SCARD_PROTOCOL_DEFAULT = -2147483648;

        /// SCARD_PRESENT -> 2
        public const int SCARD_PRESENT = 2;

        /// SCARD_POWER_DOWN -> 0
        public const int SCARD_POWER_DOWN = 0;

        /// SCARD_POWERED -> 4
        public const int SCARD_POWERED = 4;

        /// SCARD_NEGOTIABLE -> 5
        public const int SCARD_NEGOTIABLE = 5;

        /// SCARD_LEAVE_CARD -> 0
        public const int SCARD_LEAVE_CARD = 0;

        /// SCARD_EJECT_CARD -> 3
        public const int SCARD_EJECT_CARD = 3;

        /// SCARD_COLD_RESET -> 1
        public const int SCARD_COLD_RESET = 1;

        /// SCARD_CLASS_VENDOR_INFO -> 1
        public const int SCARD_CLASS_VENDOR_INFO = 1;

        /// SCARD_CLASS_VENDOR_DEFINED -> 7
        public const int SCARD_CLASS_VENDOR_DEFINED = 7;

        /// SCARD_CLASS_SYSTEM -> 0x7fff
        public const int SCARD_CLASS_SYSTEM = 32767;

        /// SCARD_CLASS_SECURITY -> 5
        public const int SCARD_CLASS_SECURITY = 5;

        /// SCARD_CLASS_PROTOCOL -> 3
        public const int SCARD_CLASS_PROTOCOL = 3;

        /// SCARD_CLASS_POWER_MGMT -> 4
        public const int SCARD_CLASS_POWER_MGMT = 4;

        /// SCARD_CLASS_PERF -> 0x7ffe
        public const int SCARD_CLASS_PERF = 32766;

        /// SCARD_CLASS_MECHANICAL -> 6
        public const int SCARD_CLASS_MECHANICAL = 6;

        /// SCARD_CLASS_IFD_PROTOCOL -> 8
        public const int SCARD_CLASS_IFD_PROTOCOL = 8;

        /// SCARD_CLASS_ICC_STATE -> 9
        public const int SCARD_CLASS_ICC_STATE = 9;

        /// SCARD_CLASS_COMMUNICATIONS -> 2
        public const int SCARD_CLASS_COMMUNICATIONS = 2;

        /// SCARD_ATTR_DEVICE_SYSTEM_NAME -> SCARD_ATTR_DEVICE_SYSTEM_NAME_W
        public const string SCARD_ATTR_DEVICE_SYSTEM_NAME = NativeConstants.SCARD_ATTR_DEVICE_SYSTEM_NAME_W;

        /// SCARD_ATTR_DEVICE_FRIENDLY_NAME -> SCARD_ATTR_DEVICE_FRIENDLY_NAME_W
        public const string SCARD_ATTR_DEVICE_FRIENDLY_NAME = NativeConstants.SCARD_ATTR_DEVICE_FRIENDLY_NAME_W;

        /// SCARD_ATR_LENGTH -> 33
        public const int SCARD_ATR_LENGTH = 33;

        /// SCARD_ABSENT -> 1
        public const int SCARD_ABSENT = 1;

        /// SCardUIDlgSelectCard -> SCardUIDlgSelectCardW
        /// Error generating expression: Value SCardUIDlgSelectCardW is not resolved
        public const string SCardUIDlgSelectCard = "SCardUIDlgSelectCardW";

        /// SCardStatus -> SCardStatusW
        /// Error generating expression: Value SCardStatusW is not resolved
        public const string SCardStatus = "SCardStatusW";

        /// SCardSetReaderCapabilities -> SCardSetAttrib
        /// Error generating expression: Value SCardSetAttrib is not resolved
        public const string SCardSetReaderCapabilities = "SCardSetAttrib";

        /// SCardSetCardTypeProviderName -> SCardSetCardTypeProviderNameW
        /// Error generating expression: Value SCardSetCardTypeProviderNameW is not resolved
        public const string SCardSetCardTypeProviderName = "SCardSetCardTypeProviderNameW";

        /// SCardRemoveReaderFromGroup -> SCardRemoveReaderFromGroupW
        /// Error generating expression: Value SCardRemoveReaderFromGroupW is not resolved
        public const string SCardRemoveReaderFromGroup = "SCardRemoveReaderFromGroupW";

        /// SCardLocateCardsByATR -> SCardLocateCardsByATRW
        /// Error generating expression: Value SCardLocateCardsByATRW is not resolved
        public const string SCardLocateCardsByATR = "SCardLocateCardsByATRW";

        /// SCardLocateCards -> SCardLocateCardsW
        /// Error generating expression: Value SCardLocateCardsW is not resolved
        public const string SCardLocateCards = "SCardLocateCardsW";

        /// SCardListReaders -> SCardListReadersW
        /// Error generating expression: Value SCardListReadersW is not resolved
        public const string SCardListReaders = "SCardListReadersW";

        /// SCardListReaderGroups -> SCardListReaderGroupsW
        /// Error generating expression: Value SCardListReaderGroupsW is not resolved
        public const string SCardListReaderGroups = "SCardListReaderGroupsW";

        /// SCardListInterfaces -> SCardListInterfacesW
        /// Error generating expression: Value SCardListInterfacesW is not resolved
        public const string SCardListInterfaces = "SCardListInterfacesW";

        /// SCardListCardTypes -> SCardListCards
        public const string SCardListCardTypes = NativeConstants.SCardListCards;

        /// SCardListCards -> SCardListCardsW
        /// Error generating expression: Value SCardListCardsW is not resolved
        public const string SCardListCards = "SCardListCardsW";

        /// SCardIntroduceReaderGroup -> SCardIntroduceReaderGroupW
        /// Error generating expression: Value SCardIntroduceReaderGroupW is not resolved
        public const string SCardIntroduceReaderGroup = "SCardIntroduceReaderGroupW";

        /// SCardIntroduceReader -> SCardIntroduceReaderW
        /// Error generating expression: Value SCardIntroduceReaderW is not resolved
        public const string SCardIntroduceReader = "SCardIntroduceReaderW";

        /// SCardIntroduceCardType -> SCardIntroduceCardTypeW
        /// Error generating expression: Value SCardIntroduceCardTypeW is not resolved
        public const string SCardIntroduceCardType = "SCardIntroduceCardTypeW";

        /// SCardGetStatusChange -> SCardGetStatusChangeW
        /// Error generating expression: Value SCardGetStatusChangeW is not resolved
        public const string SCardGetStatusChange = "SCardGetStatusChangeW";

        /// SCardGetReaderCapabilities -> SCardGetAttrib
        /// Error generating expression: Value SCardGetAttrib is not resolved
        public const string SCardGetReaderCapabilities = "SCardGetAttrib";

        /// SCardGetProviderId -> SCardGetProviderIdW
        /// Error generating expression: Value SCardGetProviderIdW is not resolved
        public const string SCardGetProviderId = "SCardGetProviderIdW";

        /// SCardGetCardTypeProviderName -> SCardGetCardTypeProviderNameW
        /// Error generating expression: Value SCardGetCardTypeProviderNameW is not resolved
        public const string SCardGetCardTypeProviderName = "SCardGetCardTypeProviderNameW";

        /// SCardForgetReaderGroup -> SCardForgetReaderGroupW
        /// Error generating expression: Value SCardForgetReaderGroupW is not resolved
        public const string SCardForgetReaderGroup = "SCardForgetReaderGroupW";

        /// SCardForgetReader -> SCardForgetReaderW
        /// Error generating expression: Value SCardForgetReaderW is not resolved
        public const string SCardForgetReader = "SCardForgetReaderW";

        /// SCardForgetCardType -> SCardForgetCardTypeW
        /// Error generating expression: Value SCardForgetCardTypeW is not resolved
        public const string SCardForgetCardType = "SCardForgetCardTypeW";

        /// SCardConnect -> SCardConnectW
        /// Error generating expression: Value SCardConnectW is not resolved
        public const string SCardConnect = "SCardConnectW";

        /// SCardAddReaderToGroup -> SCardAddReaderToGroupW
        /// Error generating expression: Value SCardAddReaderToGroupW is not resolved
        public const string SCardAddReaderToGroup = "SCardAddReaderToGroupW";

        /// SCALINGFACTORY -> 115
        public const int SCALINGFACTORY = 115;

        /// SCALINGFACTORX -> 114
        public const int SCALINGFACTORX = 114;

        /// SB_VERT -> 1
        public const int SB_VERT = 1;

        /// SB_TOP -> 6
        public const int SB_TOP = 6;

        /// SB_THUMBTRACK -> 5
        public const int SB_THUMBTRACK = 5;

        /// SB_THUMBPOSITION -> 4
        public const int SB_THUMBPOSITION = 4;

        /// SB_RIGHT -> 7
        public const int SB_RIGHT = 7;

        /// SB_PREMULT_ALPHA -> 0x00000004
        public const int SB_PREMULT_ALPHA = 4;

        /// SB_PIXEL_ALPHA -> 0x00000002
        public const int SB_PIXEL_ALPHA = 2;

        /// SB_PAGEUP -> 2
        public const int SB_PAGEUP = 2;

        /// SB_PAGERIGHT -> 3
        public const int SB_PAGERIGHT = 3;

        /// SB_PAGELEFT -> 2
        public const int SB_PAGELEFT = 2;

        /// SB_PAGEDOWN -> 3
        public const int SB_PAGEDOWN = 3;

        /// SB_NONE -> 0x00000000
        public const int SB_NONE = 0;

        /// SB_LINEUP -> 0
        public const int SB_LINEUP = 0;

        /// SB_LINERIGHT -> 1
        public const int SB_LINERIGHT = 1;

        /// SB_LINELEFT -> 0
        public const int SB_LINELEFT = 0;

        /// SB_LINEDOWN -> 1
        public const int SB_LINEDOWN = 1;

        /// SB_LEFT -> 6
        public const int SB_LEFT = 6;

        /// SB_HORZ -> 0
        public const int SB_HORZ = 0;

        /// SB_GRAD_TRI -> 0x00000020
        public const int SB_GRAD_TRI = 32;

        /// SB_GRAD_RECT -> 0x00000010
        public const int SB_GRAD_RECT = 16;

        /// SB_ENDSCROLL -> 8
        public const int SB_ENDSCROLL = 8;

        /// SB_CTL -> 2
        public const int SB_CTL = 2;

        /// SB_CONST_ALPHA -> 0x00000001
        public const int SB_CONST_ALPHA = 1;

        /// SB_BOTTOM -> 7
        public const int SB_BOTTOM = 7;

        /// SB_BOTH -> 3
        public const int SB_BOTH = 3;

        /// SBS_VERT -> 0x0001L
        public const int SBS_VERT = 1;

        /// SBS_TOPALIGN -> 0x0002L
        public const int SBS_TOPALIGN = 2;

        /// SBS_SIZEGRIP -> 0x0010L
        public const int SBS_SIZEGRIP = 16;

        /// SBS_SIZEBOXTOPLEFTALIGN -> 0x0002L
        public const int SBS_SIZEBOXTOPLEFTALIGN = 2;

        /// SBS_SIZEBOXBOTTOMRIGHTALIGN -> 0x0004L
        public const int SBS_SIZEBOXBOTTOMRIGHTALIGN = 4;

        /// SBS_SIZEBOX -> 0x0008L
        public const int SBS_SIZEBOX = 8;

        /// SBS_RIGHTALIGN -> 0x0004L
        public const int SBS_RIGHTALIGN = 4;

        /// SBS_LEFTALIGN -> 0x0002L
        public const int SBS_LEFTALIGN = 2;

        /// SBS_HORZ -> 0x0000L
        public const int SBS_HORZ = 0;

        /// SBS_BOTTOMALIGN -> 0x0004L
        public const int SBS_BOTTOMALIGN = 4;

        /// SBM_SETSCROLLINFO -> 0x00E9
        public const int SBM_SETSCROLLINFO = 233;

        /// SBM_SETRANGEREDRAW -> 0x00E6
        public const int SBM_SETRANGEREDRAW = 230;

        /// SBM_SETRANGE -> 0x00E2
        public const int SBM_SETRANGE = 226;

        /// SBM_SETPOS -> 0x00E0
        public const int SBM_SETPOS = 224;

        /// SBM_GETSCROLLINFO -> 0x00EA
        public const int SBM_GETSCROLLINFO = 234;

        /// SBM_GETSCROLLBARINFO -> 0x00EB
        public const int SBM_GETSCROLLBARINFO = 235;

        /// SBM_GETRANGE -> 0x00E3
        public const int SBM_GETRANGE = 227;

        /// SBM_GETPOS -> 0x00E1
        public const int SBM_GETPOS = 225;

        /// SBM_ENABLE_ARROWS -> 0x00E4
        public const int SBM_ENABLE_ARROWS = 228;

        /// SAVE_CTM -> 4101
        public const int SAVE_CTM = 4101;

        /// SAVE_ATTRIBUTE_VALUES -> 0xD3
        public const int SAVE_ATTRIBUTE_VALUES = 211;

        /// SANDBOX_INERT -> 0x2
        public const int SANDBOX_INERT = 2;

        /// SACL_SECURITY_INFORMATION -> (0x00000008L)
        public const int SACL_SECURITY_INFORMATION = 8;

        /// STATUS_PENDING -> ((DWORD   )0x00000103L)
        /// Error generating expression: Cast expressions are not supported in constants
        public const string STATUS_PENDING = "((DWORD   )0x00000103L)";

        /// SEC_E_INTERNAL_ERROR -> _HRESULT_TYPEDEF_(0x80090304L)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string SEC_E_INTERNAL_ERROR = "_HRESULT_TYPEDEF_(0x80090304L)";

        /// SEC_E_UNSUPPORTED_FUNCTION -> _HRESULT_TYPEDEF_(0x80090302L)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string SEC_E_UNSUPPORTED_FUNCTION = "_HRESULT_TYPEDEF_(0x80090302L)";

        /// SCARD_ATTR_DEVICE_SYSTEM_NAME_W -> SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0006)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string SCARD_ATTR_DEVICE_SYSTEM_NAME_W = "SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0006)";

        /// SCARD_ATTR_DEVICE_FRIENDLY_NAME_W -> SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0005)
        /// Error generating expression: Error generating function call.  Operation not implemented
        public const string SCARD_ATTR_DEVICE_FRIENDLY_NAME_W = "SCARD_ATTR_VALUE(SCARD_CLASS_SYSTEM, 0x0005)";
    }

}
