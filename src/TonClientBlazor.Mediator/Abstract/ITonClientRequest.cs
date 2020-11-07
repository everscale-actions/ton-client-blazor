using MediatR;

namespace ch1seL.TonClientBlazor.Mediator.Abstract
{
    internal interface ITonClientRequest<out TResponse> : IRequest<TResponse>
    {
        string Method { get; }
        object[] Params { get; }
    }
}