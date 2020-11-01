using System;

namespace Rcgnzr.Storage.Logic
{
    public class FileAlreadyExistsException: Exception
    {
        public FileAlreadyExistsException(string containerId, string fileId): base($"File \"{fileId}\" already exists in container \"{containerId}\"")
        {
            
        }
    }
}