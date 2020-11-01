using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Rcgnzr.Storage.Client
{
    public interface IStorageClient
    {
        Task<Stream?> GetFile(string containerId, string fileId, CancellationToken ct);
        Task SaveFile(string containerId, string fileId, Stream content, CancellationToken ct);
    }
}