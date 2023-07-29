using Microsoft.AspNetCore.Mvc;

namespace TimeZone.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
