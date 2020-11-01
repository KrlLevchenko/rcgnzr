using System;
using System.IO;
using System.Threading.Tasks;

namespace Rcgnzr.Storage.Logic.Storage
{
    public class FileStorage: IStorage
    {
        private readonly string _basePath;

        public FileStorage(string basePath)
        {
            _basePath = basePath;
        }

        private string GetFilePath(string containerId, string fileId) => Path.Combine(_basePath, containerId, fileId);

        public Stream? GetFile(string containerId, string fileId)
        {
            if (string.IsNullOrEmpty(containerId))
                throw new ArgumentNullException(nameof(containerId));
            if (string.IsNullOrEmpty(fileId))
                throw new ArgumentNullException(nameof(fileId));

            var filePath = GetFilePath(containerId, fileId);
            return File.Exists(filePath) ? File.OpenRead(filePath) : null;
        }

        public async Task SaveFile(string containerId, string fileId, Stream content)
        {
            if (string.IsNullOrEmpty(containerId))
                throw new ArgumentNullException(nameof(containerId));
            if (string.IsNullOrEmpty(fileId))
                throw new ArgumentNullException(nameof(fileId));
            if (content == null)
                throw new ArgumentNullException(nameof(content));
           
            
            var folderPath = Path.Combine(_basePath, containerId);
            Directory.CreateDirectory(folderPath);

            var filePath = GetFilePath(containerId, fileId);
            if (File.Exists(filePath))
                throw new FileAlreadyExistsException(containerId, fileId);

            using var fileStream = File.OpenWrite(filePath);
            await content.CopyToAsync(fileStream);
        }
    }
}