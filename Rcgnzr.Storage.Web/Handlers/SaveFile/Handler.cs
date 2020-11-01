using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Rcgnzr.Storage.Logic.Storage;

namespace Rcgnzr.Storage.Web.Handlers.SaveFile
{
    public class Handler: AsyncRequestHandler<Request>
    {
        private readonly IStorage _storage;

        public Handler(IStorage storage)
        {
            _storage = storage;
        }
        protected override Task Handle(Request request, CancellationToken ct) => _storage.SaveFile(request.ContainerId, request.FileId, request.Body);
    }
}