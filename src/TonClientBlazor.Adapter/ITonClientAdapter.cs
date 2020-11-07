using System.Threading;
using System.Threading.Tasks;

namespace ch1seL.TonClientBlazor
{
    internal interface ITonClientAdapter
    {
        Task Init();
        Task<TResponse> Request<TResponse>(string method, CancellationToken cancellationToken = default, params object[] requestObj);
    }
}