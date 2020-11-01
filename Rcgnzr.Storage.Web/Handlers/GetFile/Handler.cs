using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Rcgnzr.Storage.Logic.Storage;
using FileNotFoundException = Rcgnzr.Storage.Web.Exceptions.FileNotFoundException;

namespace Rcgnzr.Storage.Web.Handlers.GetFile
{
    // ReSharper disable once UnusedType.Global
    public class Handler: IRequestHandler<Request, Stream>
    {
        private readonly IStorage _storage;

        public Handler(IStorage storage)
        {
            _storage = storage;
        }
        public Task<Stream> Handle(Request request, CancellationToken cancellationToken)
        {
            var stream = _storage.GetFile(request.ContainerId, request.FileId) 
                         ?? throw new FileNotFoundException(request.ContainerId, request.FileId);
            return Task.FromResult(stream);
        }
    }
}