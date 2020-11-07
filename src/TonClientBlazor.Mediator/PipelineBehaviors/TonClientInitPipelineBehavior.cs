using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor.Mediator.Abstract;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ch1seL.TonClientBlazor.Mediator.PipelineBehaviors
{
    internal class TonClientInitPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : ITonClientRequest<TResponse>
    {
        private readonly ITonClientAdapter _tonClientAdapter;

        public TonClientInitPipelineBehavior(ITonClientAdapter tonClientAdapter, ILogger<TonClientInitPipelineBehavior<TRequest, TResponse>> logger)
        {
            _tonClientAdapter = tonClientAdapter;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            await _tonClientAdapter.Init();

            return await next();
        }
    }
}