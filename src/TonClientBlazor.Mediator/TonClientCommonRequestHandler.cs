using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor.Mediator.Abstract;
using ch1seL.TonClientBlazor.Mediator.Utils;
using MediatR;

namespace ch1seL.TonClientBlazor.Mediator
{
    internal class TonClientCommonRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : ITonClientRequest<TResponse>
    {
        private readonly ITonClientAdapter _tonClientAdapter;

        public TonClientCommonRequestHandler(ITonClientAdapter tonClientAdapter)
        {
            _tonClientAdapter = tonClientAdapter;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            if (!TryGetJsResponseTypeAndConverter(out Type jsResponseType, out var jsResponseConverter))
            {
                jsResponseType = typeof(TResponse);
                jsResponseConverter = null;
            }

            MethodInfo requestMethodInfo = typeof(ITonClientAdapter).GetMethod(nameof(_tonClientAdapter.Request))?.MakeGenericMethod(jsResponseType);
            Debug.Assert(requestMethodInfo != null, nameof(requestMethodInfo) + " != null");

            var task = (Task) requestMethodInfo.Invoke(_tonClientAdapter,
                new object[] {request.Method, cancellationToken, request.Params});
            Debug.Assert(task != null, nameof(task) + " != null");

            await task;

            PropertyInfo propertyInfo = typeof(Task<>).MakeGenericType(jsResponseType).GetProperty(nameof(Task<object>.Result));
            Debug.Assert(propertyInfo != null, nameof(propertyInfo) + " != null");

            object result = propertyInfo.GetValue(task);
            Debug.Assert(result != null, nameof(result) + " != null");

            return (TResponse) (jsResponseConverter?.Invoke(result) ?? result);
        }

        private static bool TryGetJsResponseTypeAndConverter(out Type jsResponseType, out Func<object, object> jsResponseConverter)
        {
            if (typeof(TResponse).IsEquivalentTo(typeof(DateTime)))
            {
                jsResponseType = typeof(double);
                jsResponseConverter = jsTimeStamp => ((double) jsTimeStamp).ToDateTime();
                return true;
            }

            if (typeof(TResponse).IsEquivalentTo(typeof(TimeSpan)))
            {
                jsResponseType = typeof(double);
                jsResponseConverter = milliseconds => ((double) milliseconds).ToTimeSpan();
                return true;
            }

            jsResponseConverter = null;
            jsResponseType = null;
            return false;
        }
    }
}