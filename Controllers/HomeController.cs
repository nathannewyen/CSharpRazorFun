using Microsoft.AspNetCore.Mvc;

namespace Razor.Controllers {
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}