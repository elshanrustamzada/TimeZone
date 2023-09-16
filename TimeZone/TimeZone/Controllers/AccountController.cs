using Microsoft.AspNetCore.Mvc;

namespace TimeZone.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }


    }
}
