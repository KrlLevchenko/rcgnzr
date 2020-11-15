using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Rcgnzr.Cabinet.Web.Controllers
{
    [Route("api/[controller]")]
    public class AuthController: Controller
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public Task<Handlers.Auth.Response> Auth(Handlers.Auth.Request request, CancellationToken ct) => _mediator.Send(request, ct);
    }
}