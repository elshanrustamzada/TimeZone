using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TimeZone.DAL;
using TimeZone.Models;

namespace TimeZone.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Footer footer = await _db.Footer.FirstOrDefaultAsync();
            return View(footer);
        }
    }
}
