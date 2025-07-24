using Microsoft.AspNetCore.Mvc;

namespace KnifeSharpeningSite.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Place()
        {
            return View();
        }
    }
}
