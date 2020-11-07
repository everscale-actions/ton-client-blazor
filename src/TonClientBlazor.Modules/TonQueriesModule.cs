using ch1seL.TonClientBlazor;
using MediatR;

namespace ch1seL.TonClientModules
{
    internal class TonQueriesModule : ITonQueriesModule
    {
        private readonly IMediator _mediator;

        public TonQueriesModule(IMediator mediator,
            ITonQCollection<TonAccount> accounts,
            ITonQCollection<TonTransaction> transactions,
            ITonQCollection<TonBlock> blocks,
            ITonQCollection<TonMessage> messages)
        {
            Accounts = accounts;
            Transactions = transactions;
            Blocks = blocks;
            Messages = messages;
            _mediator = mediator;
        }

        public ITonQCollection<TonAccount> Accounts { get; }
        public ITonQCollection<TonTransaction> Transactions { get; }
        public ITonQCollection<TonBlock> Blocks { get; }
        public ITonQCollection<TonMessage> Messages { get; }
    }
}