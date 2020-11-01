using System.IO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Rcgnzr.Storage.Web.Handlers.GetFile
{
    public class Request: IRequest<Stream>
    {
        [FromRoute] public string ContainerId { get; set; }
        [FromRoute] public string FileId { get; set; }
    }
}