using ch1seL.TonClientBlazor.Mediator.Abstract;

namespace ch1seL.TonClientBlazor.Mediator
{
    internal class GetByParametersRequest<TResponse> : ITonClientRequest<TResponse>
    {
        public GetByParametersRequest(string method, params object[] @params)
        {
            Params = @params.Length == 0 ? null : @params;
            Method = method;
        }

        public virtual string Method { get; }

        public virtual object[] Params { get; }
    }
}