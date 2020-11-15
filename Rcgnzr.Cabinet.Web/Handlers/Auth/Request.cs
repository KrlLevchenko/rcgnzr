using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Rcgnzr.Cabinet.Web.Handlers.Auth
{
    public class Request: IRequest<Response>
    {
        [FromBody]public AuthData Data { get; set; }
    }
}