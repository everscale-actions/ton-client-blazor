using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor;
using ch1seL.TonClientBlazor.Mediator;
using MediatR;

namespace ch1seL.TonClientModules
{
    internal class TonConfigModule : ITonConfigModule
    {
        private readonly IMediator _mediator;

        public TonConfigModule(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> GetVersion(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<string>(TonClientMethods.Config.GetVersion), cancellationToken);
        }
    }
}