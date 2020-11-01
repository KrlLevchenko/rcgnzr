using System;

namespace Rcgnzr.Storage.Web.Exceptions
{
    public class FileNotFoundException: Exception
    {
        public FileNotFoundException(string containerId, string fileId): base($"File \"{fileId}\" already exists in container \"{containerId}\"")
        {
            
        }
    }
}