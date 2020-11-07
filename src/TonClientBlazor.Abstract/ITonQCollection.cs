using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ch1seL.TonClientBlazor.Abstract;
using ch1seL.TonClientBlazor.Modules.Query;

namespace ch1seL.TonClientBlazor
{
    public interface ITonQCollection<T> where T : ITonGraphQLResponseType
    {
        Task<IReadOnlyList<T>> Query(TonQueryParams @params, CancellationToken cancellationToken = default);
    }
}