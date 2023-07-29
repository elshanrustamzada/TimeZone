using Microsoft.AspNetCore.Mvc;

namespace TimeZone.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
