using Microsoft.AspNetCore.Mvc;

namespace TimeZone.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
