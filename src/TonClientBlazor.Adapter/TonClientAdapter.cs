using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;

namespace ch1seL.TonClientBlazor
{
    internal class TonClientAdapter : ITonClientAdapter, IDisposable
    {
        private const string CreateClientMethod = "createTonClient";
        private const string CloseClientMethod = "closeTonClient";
        private const string TonClientInstanceName = "tonClient";

        private readonly IJSRuntime _jsRuntime;
        private readonly TonClientOptions _options;

        public TonClientAdapter(IJSRuntime jsRuntime, IOptions<TonClientOptions> tonClientOptionsAccessor)
        {
            _options = tonClientOptionsAccessor.Value;
            _jsRuntime = jsRuntime;
        }

        public async void Dispose()
        {
            await _jsRuntime.InvokeVoidAsync(CloseClientMethod);
        }

        public async Task Init()
        {
            await _jsRuntime.InvokeVoidAsync(CreateClientMethod, _options);
        }

        public async Task<TResponse> Request<TResponse>(string method, CancellationToken cancellationToken = default, params object[] requestObj)
        {
            if (string.IsNullOrWhiteSpace(method))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(method));

            var identifier = new StringBuilder(TonClientInstanceName)
                .Append(".")
                .Append(method)
                .ToString();

            var args = new List<object> {identifier};
            if (requestObj != null) args.AddRange(requestObj);

            return await _jsRuntime.InvokeAsync<TResponse>("execute", cancellationToken, args.ToArray());
        }
    }
}