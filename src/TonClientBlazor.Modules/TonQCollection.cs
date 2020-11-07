using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor;
using ch1seL.TonClientBlazor.Abstract;
using ch1seL.TonClientBlazor.Attributes;
using ch1seL.TonClientBlazor.Mediator;
using ch1seL.TonClientBlazor.Modules.Query;
using MediatR;

namespace ch1seL.TonClientModules
{
    internal class TonQCollection<T> : ITonQCollection<T> where T : ITonGraphQLResponseType
    {
        private readonly IMediator _mediator;
        private readonly string _namespace;

        public TonQCollection(IMediator mediator)
        {
            _mediator = mediator;
            _namespace = typeof(T).GetCustomAttribute<GraphQlNamespaceAttribute>()!.Namespace;
        }

        public async Task<IReadOnlyList<T>> Query(TonQueryParams @params, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetByParametersRequest<IReadOnlyList<T>>(string.Format(TonClientMethods.Queries.Query, _namespace), @params),
                cancellationToken);
        }
    }
}