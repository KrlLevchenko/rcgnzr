using Microsoft.AspNetCore.Mvc;

namespace Rcgnzr.Storage.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var version = typeof(HomeController).Assembly.GetName().Version;
            return Ok(new
            {
                version,
                api = $"{Request.Scheme}://{Request.Host}{Request.PathBase}/swagger"
            });
        }
    }
}