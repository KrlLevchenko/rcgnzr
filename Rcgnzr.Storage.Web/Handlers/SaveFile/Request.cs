using System.IO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Rcgnzr.Storage.Web.Handlers.SaveFile
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Request : IRequest
    {
        [FromRoute] public string ContainerId { get; set; } = null!;
        [FromRoute] public string FileId { get; set; } = null!;
        public Stream Body { get; set; } = null!;
    }
}