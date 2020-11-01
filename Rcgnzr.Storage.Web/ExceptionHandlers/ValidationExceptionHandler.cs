using System.Threading.Tasks;
using FluentValidation;
using Rcgnzr.Storage.Web.ExceptionHandling;

namespace Rcgnzr.Storage.Web.ExceptionHandlers
{
    public class ValidationExceptionHandler: ExceptionHandlerBase<ValidationException>
    {
        protected override Task<ExceptionHandleResult> HandleInternal(ValidationException exception) => Task.FromResult(new ExceptionHandleResult(429, exception.Message));
    }
}