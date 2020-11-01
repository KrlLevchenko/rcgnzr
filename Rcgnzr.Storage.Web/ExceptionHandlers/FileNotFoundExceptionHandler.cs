using System.Threading.Tasks;
using Rcgnzr.Storage.Web.ExceptionHandling;
using Rcgnzr.Storage.Web.Exceptions;

namespace Rcgnzr.Storage.Web.ExceptionHandlers
{
    public class FileNotFoundExceptionHandler: ExceptionHandlerBase<FileNotFoundException>
    {
        protected override Task<ExceptionHandleResult> HandleInternal(FileNotFoundException exception) =>
            Task.FromResult(new ExceptionHandleResult(404, exception.Message));
    }
}