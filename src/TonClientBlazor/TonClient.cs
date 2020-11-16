using System;
using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor.Mediator;
using ch1seL.TonClientBlazor.Utils;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ch1seL.TonClientBlazor
{
    internal class TonClient : ITonClient, IDisposable, IAsyncDisposable
    {
        private readonly IMediator _mediator;
        private ServiceProvider _serviceProvider;

        public TonClient(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider.BuildTonClientServiceProvider();
            _mediator = _serviceProvider.GetRequiredService<IMediator>();
            Crypto = _serviceProvider.GetRequiredService<ITonCryptoModule>();
            Config = _serviceProvider.GetRequiredService<ITonConfigModule>();
            Contracts = _serviceProvider.GetRequiredService<ITonContractsModule>();
            Queries = _serviceProvider.GetRequiredService<ITonQueriesModule>();
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();

            Dispose(false);
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<TimeSpan> ServerTimeDelta(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<TimeSpan>(TonClientMethods.ServerTimeDelta), cancellationToken);
        }

        public async Task<DateTime> ServerNow(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<DateTime>(TonClientMethods.ServerNow), cancellationToken);
        }

        public ITonCryptoModule Crypto { get; }
        public ITonConfigModule Config { get; }
        public ITonContractsModule Contracts { get; }
        public ITonQueriesModule Queries { get; }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) _serviceProvider?.Dispose();

            _serviceProvider = null;
        }

        protected virtual async ValueTask DisposeAsyncCore()
        {
            if (_serviceProvider != null) await _serviceProvider.DisposeAsync();

            _serviceProvider = null;
        }
    }
}