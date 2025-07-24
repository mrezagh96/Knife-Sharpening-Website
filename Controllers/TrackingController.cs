using Microsoft.AspNetCore.Mvc;

namespace KnifeSharpeningSite.Controllers
{
    public class TrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
