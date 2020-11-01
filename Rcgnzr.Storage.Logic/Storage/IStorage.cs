using System.IO;
using System.Threading.Tasks;

namespace Rcgnzr.Storage.Logic.Storage
{
    public interface IStorage
    {
        public Stream? GetFile(string containerId, string fileId);

        public Task SaveFile(string containerId, string fileId, Stream content);
    }
}