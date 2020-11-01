using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Rcgnzr.Storage.Web.Controllers
{
    [Route("api/[controller]")]
    public class StorageController: Controller
    {
        private readonly IMediator _mediator;

        public StorageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        /// <summary>
        ///     Получает содержимое конкретного файла
        /// </summary>
        /// <returns></returns>
        [HttpGet("{containerId}/{fileId}")]
        public Task<Stream> GetFile(Handlers.GetFile.Request request, CancellationToken ct) => _mediator.Send(request, ct);
        
        /// <summary>
        ///     Создаёт файл
        /// </summary>
        /// <returns></returns>
        [HttpPost("{containerId}/{fileId}")]
        public Task<Unit> SaveFile(Handlers.SaveFile.Request request)
        {
            request.Body = Request.Body;
            return _mediator.Send(request);
        }
    }
}