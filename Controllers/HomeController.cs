using Microsoft.AspNetCore.Mvc;

namespace KnifeSharpeningSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
