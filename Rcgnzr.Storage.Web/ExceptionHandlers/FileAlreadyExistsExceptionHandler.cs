using System.Threading.Tasks;
using Rcgnzr.Storage.Logic;
using Rcgnzr.Storage.Web.ExceptionHandling;

namespace Rcgnzr.Storage.Web.ExceptionHandlers
{
    public class FileAlreadyExistsExceptionHandler: ExceptionHandlerBase<FileAlreadyExistsException>
    {
        protected override Task<ExceptionHandleResult> HandleInternal(FileAlreadyExistsException exception) =>
            Task.FromResult(new ExceptionHandleResult(409, exception.Message));
    }
}