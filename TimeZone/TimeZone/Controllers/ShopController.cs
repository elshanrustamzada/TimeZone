using Microsoft.AspNetCore.Mvc;

namespace TimeZone.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
