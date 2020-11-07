using System;
using System.Threading;
using System.Threading.Tasks;

namespace ch1seL.TonClientBlazor
{
    public interface ITonClient
    {
        ITonCryptoModule Crypto { get; }
        ITonConfigModule Config { get; }
        ITonContractsModule Contracts { get; }
        ITonQueriesModule Queries { get; }
        Task<TimeSpan> ServerTimeDelta(CancellationToken cancellationToken = default);
        Task<DateTime> ServerNow(CancellationToken cancellationToken = default);
    }
}