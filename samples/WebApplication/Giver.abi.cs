using ch1seL.TonClientBlazor;

namespace ch1seL.WebApplication
{
    public static class Static
    {
        public const string GiverAddress = "0:841288ed3b55d9cdafa806807f02a0ae0c169aa5edfe88a789a6482429756a94";
        
        public static readonly TonAbi GiverAbi = new TonAbi()
        {
            AbiVersion = 1,
            Functions = new[]
            {
                new TonFunction("constructor"),
                new TonFunction("sendGrams")
                {
                    Inputs = new []
                    {
                        new TonNameTypePair("dest", "address"),
                        new TonNameTypePair("amount", "uint64")
                    }
                }
            }
        };
    }
}