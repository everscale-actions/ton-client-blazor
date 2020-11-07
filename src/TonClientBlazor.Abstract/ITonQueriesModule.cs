namespace ch1seL.TonClientBlazor
{
    public interface ITonQueriesModule
    {
        ITonQCollection<TonAccount> Accounts { get; }
        ITonQCollection<TonTransaction> Transactions { get; }
        ITonQCollection<TonBlock> Blocks { get; }
        ITonQCollection<TonMessage> Messages { get; }
    }
}