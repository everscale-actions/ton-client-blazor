using System;
using System.Diagnostics;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor.Mediator.Abstract;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ch1seL.TonClientBlazor.Mediator.PipelineBehaviors
{
    internal class TonClientLoggerPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : ITonClientRequest<TResponse>
    {
        private readonly ILogger<TonClientLoggerPipelineBehavior<TRequest, TResponse>> _logger;

        public TonClientLoggerPipelineBehavior(ILogger<TonClientLoggerPipelineBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            var requestBody = JsonSerializer.Serialize(request);
            _logger.LogDebug("Start request \nType:{requestType}\nBody:{requestBody}", typeof(TRequest), requestBody);

            var stopwatch = Stopwatch.StartNew();
            TResponse response = await next();
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            var responseBody = JsonSerializer.Serialize(response);

            _logger.LogDebug("Finish request \nType:{requestType}\nBody:{requestBody}\nResponse:{responseBody}\nFinished in:{elapsedTime}ms", typeof(TRequest),
                requestBody, responseBody, elapsedTime.TotalMilliseconds);
            return response;
        }
    }
}