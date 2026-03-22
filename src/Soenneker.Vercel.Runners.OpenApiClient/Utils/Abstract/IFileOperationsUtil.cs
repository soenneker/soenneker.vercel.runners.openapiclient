using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Vercel.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
