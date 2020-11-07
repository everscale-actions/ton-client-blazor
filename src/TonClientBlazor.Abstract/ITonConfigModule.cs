using System.Threading;
using System.Threading.Tasks;

namespace ch1seL.TonClientBlazor
{
    public interface ITonConfigModule
    {
        Task<string> GetVersion(CancellationToken cancellationToken = default);
    }
}