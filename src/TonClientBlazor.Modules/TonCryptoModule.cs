using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor;
using ch1seL.TonClientBlazor.Mediator;
using ch1seL.TonClientBlazor.Modules.Crypto;
using MediatR;

namespace ch1seL.TonClientModules
{
    internal class TonCryptoModule : ITonCryptoModule
    {
        private readonly IMediator _mediator;

        public TonCryptoModule(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TonFactorizeResult> Factorize(string challengeHex, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonFactorizeResult>(TonClientMethods.Crypto.Factorize, challengeHex), cancellationToken);
        }

        public async Task<string> ModularPower(string baseHex, string exponentHex, string modulusHex, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.ModularPower, baseHex, exponentHex, modulusHex),
                cancellationToken);
        }

        public async Task<string> RandomGenerateBytes(sbyte length, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.RandomGenerateBytes, length, outputEncoding.ToString()),
                cancellationToken);
        }

        public async Task<TonPublicSecretPair> Ed25519Keypair(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonPublicSecretPair>(TonClientMethods.Crypto.Ed25519Keypair), cancellationToken);
        }

        public async Task<string> PublicKeyToString(string key, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.PublicKeyToString, key), cancellationToken);
        }

        public async Task<string> Sha512(TonInputMessage message, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.Sha512, message, outputEncoding.ToString()),
                cancellationToken);
        }

        public async Task<string> Sha256(TonInputMessage message, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.Sha256, message, outputEncoding.ToString()),
                cancellationToken);
        }

        public async Task<string> Scrypt(TonInputMessage password, TonInputMessage salt, sbyte logN = 15, uint r = 8, uint p = 1, sbyte dkLen = 10,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            var @params = new
            {
                password, salt, logN, r, p, dkLen
            };
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.Scrypt, @params), cancellationToken);
        }


        public async Task<TonPublicSecretPair> NaclBoxKeypair(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonPublicSecretPair>(TonClientMethods.Crypto.NaclBoxKeypair), cancellationToken);
        }

        public async Task<TonPublicSecretPair> NaclBoxKeypairFromSecretKey(string secretKey, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonPublicSecretPair>(TonClientMethods.Crypto.NaclBoxKeypairFromSecretKey, secretKey),
                cancellationToken);
        }

        public async Task<TonPublicSecretPair> NaclSignKeypair(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonPublicSecretPair>(TonClientMethods.Crypto.NaclSignKeypair), cancellationToken);
        }

        public async Task<TonPublicSecretPair> NaclSignKeypairFromSecretKey(string secretKey, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonPublicSecretPair>(TonClientMethods.Crypto.NaclSignKeypairFromSecretKey, secretKey),
                cancellationToken);
        }

        public async Task<string> NaclBox(TonInputMessage message, string nonce, string theirPublicKey, string secretKey,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            var @params = new
            {
                nonce, theirPublicKey, secretKey, outputEncoding = outputEncoding.ToString()
            };
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.NaclBox, @params), cancellationToken);
        }

        public async Task<string> NaclBoxOpen(TonInputMessage message, string nonce, string theirPublicKey, string secretKey,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex, CancellationToken cancellationToken = default)
        {
            var @params = new
            {
                nonce, theirPublicKey, secretKey, outputEncoding = outputEncoding.ToString()
            };
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.NaclBoxOpen, @params), cancellationToken);
        }

        public async Task<string> NaclSecretBox(TonInputMessage message, string nonce, string key,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            var @params = new
            {
                nonce, key, outputEncoding = outputEncoding.ToString()
            };
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.NaclSecretBox, @params), cancellationToken);
        }

        public async Task<string> NaclSecretBoxOpen(TonInputMessage message, string nonce, string key,
            TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            var @params = new
            {
                nonce, key, outputEncoding = outputEncoding.ToString()
            };
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.NaclSecretBoxOpen, @params), cancellationToken);
        }

        public async Task<string> NaclSign(TonInputMessage message, string key, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.NaclSign, message, key, outputEncoding.ToString()),
                cancellationToken);
        }

        public async Task<string> NaclSignOpen(TonInputMessage message, string key, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.NaclSignOpen, message, key, outputEncoding.ToString()),
                cancellationToken);
        }

        public async Task<string> NaclSignDetached(TonInputMessage message, string key, TonOutputEncodingType outputEncoding = TonOutputEncodingType.Hex,
            CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.NaclSignDetached, message, key, outputEncoding.ToString()),
                cancellationToken);
        }

        public async Task<string> MnemonicWords(TonMnemonicWordsParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.MnemonicWords, @params), cancellationToken);
        }

        public async Task<string> MnemonicWordsFromRandom(TonMnemonicFromRandomParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.MnemonicFromRandom, @params), cancellationToken);
        }

        public async Task<string> MnemonicFromEntropy(TonMnemonicFromEntropyParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.MnemonicFromEntropy, @params), cancellationToken);
        }

        public async Task<bool> MnemonicIsValid(TonMnemonicIsValidParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<bool>(TonClientMethods.Crypto.MnemonicIsValid, @params), cancellationToken);
        }

        public async Task<TonPublicSecretPair> MnemonicDeriveSignKeys(TonMnemonicDeriveSignKeysParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonPublicSecretPair>(TonClientMethods.Crypto.MnemonicDeriveSignKeys, @params),
                cancellationToken);
        }

        public async Task<string> HdkeyXPrvFromMnemonic(string phrase, TonMnemonicDictionary tonMnemonicDictionary = TonMnemonicDictionary.TonDictionary,
            TonMnemonicWordCount tonMnemonicWordCount = TonMnemonicWordCount.Words12, CancellationToken cancellationToken = default)
        {
            var @params = new
            {
                phrase,
                tonMnemonicDictionary,
                tonMnemonicWordCount
            };
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.HdkeyXPrvFromMnemonic, @params), cancellationToken);
        }

        public async Task<string> HdkeyXPrvDerive(string serialized, uint index, bool hardened, bool compliant, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.HdkeyXPrvDerive, serialized, index, hardened, compliant),
                cancellationToken);
        }

        public async Task<string> HdkeyXPrvDerivePath(string serialized, string path, bool compliant, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.HdkeyXPrvDerivePath, serialized, path, compliant),
                cancellationToken);
        }

        public async Task<string> HdkeyXPrvSecret(string serialized, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.HdkeyXPrvSecret, serialized), cancellationToken);
        }

        public async Task<string> HdkeyXPrvPublic(string serialized, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Crypto.HdkeyXPrvPublic, serialized), cancellationToken);
        }

        public async Task<TonCryptoChaCha20Result> Chacha20(TonCryptoChaCha20Params @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TonCryptoChaCha20Result>(TonClientMethods.Crypto.Chacha20, @params), cancellationToken);
        }
    }
}