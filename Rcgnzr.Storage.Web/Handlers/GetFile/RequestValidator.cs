using FluentValidation;

namespace Rcgnzr.Storage.Web.Handlers.GetFile
{
    // ReSharper disable once UnusedType.Global
    public class RequestValidator: AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.FileId).NotEmpty();
            RuleFor(x => x.ContainerId).NotEmpty();
        }
    }
}