using System;
using ch1seL.TonClientBlazor;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class AddTonClientServiceCollectionExtensions
    {
        public static IServiceCollection AddTonClient(this IServiceCollection serviceCollection, Action<TonClientOptions> configureOptions = null)
        {
            return serviceCollection
                .AddTransient<ITonClient, TonClient>()
                .Configure<TonClientOptions>(options => configureOptions?.Invoke(options));
        }
    }
}