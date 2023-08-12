using Microsoft.AspNetCore.Mvc;

namespace TimeZone.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
