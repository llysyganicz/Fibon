using Microsoft.AspNetCore.Mvc;

namespace Fibon.API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Content("Hello from Fibon.API");
        }
    }
}