using Microsoft.AspNetCore.Mvc;

namespace Uspeak.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index/{id?}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            return View();
        }
    }
}
