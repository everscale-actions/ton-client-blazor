namespace ch1seL.TonClientBlazor.Mediator
{
    public static class TonClientMethods
    {
        public const string ServerNow = "serverNow";
        public const string ServerTimeDelta = "serverTimeDelta";

        public static class Config
        {
            public const string GetVersion = "config.getVersion";
        }

        public static class Crypto
        {
            public const string Factorize = "crypto.factorize";
            public const string ModularPower = "crypto.modularPower";
            public const string RandomGenerateBytes = "crypto.randomGenerateBytes";
            public const string Ed25519Keypair = "crypto.ed25519Keypair";
            public const string PublicKeyToString = "crypto.publicKeyToString";
            public const string Sha512 = "crypto.sha512";
            public const string Sha256 = "crypto.sha256";
            public const string Scrypt = "crypto.scrypt";
            public const string NaclBoxKeypair = "crypto.naclBoxKeypair";
            public const string NaclBoxKeypairFromSecretKey = "crypto.naclBoxKeypairFromSecretKey";
            public const string NaclSignKeypair = "crypto.naclSignKeypair";
            public const string NaclSignKeypairFromSecretKey = "crypto.naclSignKeypairFromSecretKey";
            public const string NaclBox = "crypto.naclBox";
            public const string NaclBoxOpen = "crypto.naclBoxOpen";
            public const string NaclSecretBox = "crypto.naclSecretBox";
            public const string NaclSecretBoxOpen = "crypto.naclSecretBoxOpen";
            public const string NaclSign = "crypto.naclSign";
            public const string NaclSignOpen = "crypto.naclSignOpen";
            public const string NaclSignDetached = "crypto.naclSignDetached";
            public const string MnemonicWords = "crypto.mnemonicWords";
            public const string MnemonicFromRandom = "crypto.mnemonicFromRandom";
            public const string MnemonicFromEntropy = "crypto.mnemonicFromEntropy";
            public const string MnemonicIsValid = "crypto.mnemonicIsValid";
            public const string MnemonicDeriveSignKeys = "crypto.mnemonicDeriveSignKeys";
            public const string HdkeyXPrvFromMnemonic = "crypto.hdkeyXPrvFromMnemonic";
            public const string HdkeyXPrvDerive = "crypto.hdkeyXPrvDerive";
            public const string HdkeyXPrvDerivePath = "crypto.hdkeyXPrvDerivePath";
            public const string HdkeyXPrvSecret = "crypto.hdkeyXPrvSecret";
            public const string HdkeyXPrvPublic = "crypto.hdkeyXPrvPublic";
            public const string Chacha20 = "crypto.chacha20";
        }

        public static class Contract
        {
            public const string Load = "contracts.load";
            public const string Deploy = "contracts.deploy";
            public const string Run = "contracts.run";
            public const string RunLocal = "contracts.runLocal";
            public const string RunMessageLocal = "contracts.runMessageLocal";
            public const string RunGet = "contracts.runGet";
            public const string ArrayFromCons = "contracts.arrayFromCONS";
            public const string CreateDeployMessage = "contracts.createDeployMessage";
            public const string CreateRunMessage = "contracts.createRunMessage";
            public const string CreateUnsignedDeployMessage = "contracts.createUnsignedDeployMessage";
            public const string CreateUnsignedRunMessage = "contracts.createUnsignedRunMessage";
            public const string CreateSignedMessage = "contracts.createSignedMessage";
            public const string CreateSignedDeployMessage = "contracts.createSignedDeployMessage";
            public const string CreateSignedRunMessage = "contracts.createSignedRunMessage";
            public const string GetCodeFromImage = "contracts.getCodeFromImage";
            public const string GetDeployData = "contracts.getDeployData";
            public const string CreateRunBody = "contracts.createRunBody";
            public const string GetFunctionId = "contracts.getFunctionId";
            public const string GetBocHash = "contracts.getBocHash";
            public const string ParseMessage = "contracts.parseMessage";
            public const string DecodeRunOutput = "contracts.decodeRunOutput";
            public const string DecodeInputMessageBody = "contracts.decodeInputMessageBody";
            public const string DecodeOutputMessageBody = "contracts.decodeOutputMessageBody";
            public const string EnsureMessageId = "contracts.ensureMessageId";
            public const string SendMessage = "contracts.sendMessage";
            public const string WaitForTransaction = "contracts.waitForTransaction";
            public const string WaitForDeployTransaction = "contracts.waitForDeployTransaction";
            public const string WaitForRunTransaction = "contracts.waitForRunTransaction";
            public const string ProcessMessage = "contracts.processMessage";
            public const string ProcessDeployMessage = "contracts.processDeployMessage";
            public const string ProcessRunMessage = "contracts.processRunMessage";
            public const string CalcRunFees = "contracts.calcRunFees";
            public const string CalcDeployFees = "contracts.calcDeployFees";
            public const string CalcMsgProcessFees = "contracts.calcMsgProcessFees";
            public const string ConvertAddress = "contracts.convertAddress";
            public const string GetAccount = "contracts.getAccount";
        }

        public static class Queries
        {
            public const string Query = "queries.{0}.query";
        }
    }
}