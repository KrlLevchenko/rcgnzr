using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Rcgnzr.Storage.Client;

namespace Rcgnzr.Cabinet.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStorageClient _client;

        public HomeController(IStorageClient client)
        {
            _client = client;
        }
        public IActionResult Index()
        {
            var stream = _client.GetFile("foo", "bar", CancellationToken.None).Result;
            
            var version = typeof(HomeController).Assembly.GetName().Version;
            return Ok(new
            {
                version,
                api = $"{Request.Scheme}://{Request.Host}{Request.PathBase}/swagger"
            });
        }
    }
}