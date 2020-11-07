using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor.Modules.Crypto;

namespace ch1seL.TonClientBlazor
{
    public interface ITonCryptoModule
    {
        Task<TonFactorizeResult> Factorize(string challengeHex, CancellationToken cancellationToken = default);
        Task<string> ModularPower(string baseHex, string exponentHex, string modulusHex, CancellationToken cancellationToken = default);

        Task<string> RandomGenerateBytes(sbyte length, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default);

        Task<TonPublicSecretPair> Ed25519Keypair(CancellationToken cancellationToken = default);

        Task<string> PublicKeyToString(string key, CancellationToken cancellationToken = default);

        Task<string> Sha512(TonInputMessage message, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default);

        Task<string> Sha256(TonInputMessage message, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default);

        Task<string> Scrypt(TonInputMessage password, TonInputMessage salt, sbyte logN = 15, uint r = 8, uint p = 1, sbyte dkLen = 10,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default);

        Task<TonPublicSecretPair> NaclBoxKeypair(CancellationToken cancellationToken = default);

        Task<TonPublicSecretPair> NaclBoxKeypairFromSecretKey(string secretKey, CancellationToken cancellationToken = default);

        Task<TonPublicSecretPair> NaclSignKeypair(CancellationToken cancellationToken = default);

        Task<TonPublicSecretPair> NaclSignKeypairFromSecretKey(string secretKey, CancellationToken cancellationToken = default);

        Task<string> NaclBox(TonInputMessage message, string nonce, string theirPublicKey, string secretKey,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default);

        Task<string> NaclBoxOpen(TonInputMessage message, string nonce, string theirPublicKey, string secretKey,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default);

        Task<string> NaclSecretBox(TonInputMessage message, string nonce, string key,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default);

        Task<string> NaclSecretBoxOpen(TonInputMessage message, string nonce, string key,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default);

        Task<string> NaclSign(TonInputMessage message, string key,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default);

        Task<string> NaclSignOpen(TonInputMessage message, string key,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default);

        Task<string> NaclSignDetached(TonInputMessage message, string key,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default);

        Task<string> MnemonicWords(TonMnemonicWordsParams @params,
            CancellationToken cancellationToken = default);

        Task<string> MnemonicWordsFromRandom(TonMnemonicFromRandomParams @params,
            CancellationToken cancellationToken = default);

        Task<string> MnemonicFromEntropy(TonMnemonicFromEntropyParams @params,
            CancellationToken cancellationToken = default);

        Task<bool> MnemonicIsValid(TonMnemonicIsValidParams @params,
            CancellationToken cancellationToken = default);

        Task<TonPublicSecretPair> MnemonicDeriveSignKeys(TonMnemonicDeriveSignKeysParams @params,
            CancellationToken cancellationToken = default);

        Task<string> HdkeyXPrvFromMnemonic(string phrase, TonMnemonicDictionary tonMnemonicDictionary = TonMnemonicDictionary.TonDictionary,
            TonMnemonicWordCount tonMnemonicWordCount = TonMnemonicWordCount.Words12,
            CancellationToken cancellationToken = default);

        Task<string> HdkeyXPrvDerive(string serialized, uint index, bool hardened, bool compliant, CancellationToken cancellationToken = default);
        Task<string> HdkeyXPrvDerivePath(string serialized, string path, bool compliant, CancellationToken cancellationToken = default);
        Task<string> HdkeyXPrvSecret(string serialized, CancellationToken cancellationToken = default);
        Task<string> HdkeyXPrvPublic(string serialized, CancellationToken cancellationToken = default);
        Task<TonCryptoChaCha20Result> Chacha20(TonCryptoChaCha20Params @params, CancellationToken cancellationToken = default);
    }
}