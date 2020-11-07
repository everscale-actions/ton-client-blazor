using System;
using ch1seL.TonClientBlazor.Mediator;
using ch1seL.TonClientBlazor.Mediator.PipelineBehaviors;
using ch1seL.TonClientModules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;

namespace ch1seL.TonClientBlazor.Utils
{
    internal static class TonClientBuildServiceProviderExtensions
    {
        public static ServiceProvider BuildServiceProvider(this IServiceProvider serviceProvider)
        {
            return new ServiceCollection()
                .AddLogging()
                .AddSingleton(serviceProvider.GetService<ILoggerFactory>() ?? NullLoggerFactory.Instance)
                .AddTransient<ITonClientAdapter, TonClientAdapter>()
                .AddMediatR(typeof(GetByParametersRequest<>))
                .RegisterTonRequestHandlers()
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(TonClientInitPipelineBehavior<,>))
#if DEBUG
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(TonClientLoggerPipelineBehavior<,>))
#endif
                .AddTransient<ITonCryptoModule, TonCryptoModule>()
                .AddTransient<ITonConfigModule, TonConfigModule>()
                .AddTransient<ITonContractsModule, TonContractsModule>()
                .AddTransient<ITonQueriesModule, TonQueriesModule>()
                .AddTransient(typeof(ITonQCollection<>), typeof(TonQCollection<>))
                .AddSingleton(serviceProvider.GetService<IOptions<TonClientOptions>>() ??
                              new OptionsWrapper<TonClientOptions>(new TonClientOptions {Servers = new[] {"http://localhost/"}}))
                .AddSingleton(serviceProvider.GetRequiredService<IJSRuntime>())
                .BuildServiceProvider();
        }
    }
}