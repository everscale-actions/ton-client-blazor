using System.Threading.Tasks;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApplication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");
            builder.Logging
                .SetMinimumLevel(LogLevel.Trace)
                .AddFilter("Microsoft", LogLevel.Warning);
                
            builder.Services.AddTonClient(options =>
            {
                options.Servers = new[] {"http://localhost/"};
                options.LogVerbose = true;
            });
            builder.Services.AddBlazoredToast();
            
            await builder.Build().RunAsync();
        }
    }
}