using Microsoft.AspNetCore.Mvc;

namespace TimeZone.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
