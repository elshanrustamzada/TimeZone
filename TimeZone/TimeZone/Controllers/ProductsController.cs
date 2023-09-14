using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.DAL;
using TimeZone.Models;

namespace TimeZone.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.ProductsCount = await _db.Products.CountAsync();

            List<Product> products = await _db.Products.OrderByDescending(x=>x.Id).Take(6).ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> LoadMore(int skip)
        {
            int productsCount = await _db.Products.CountAsync();
            if (productsCount <= skip)
            {
                return Content("Get Out!");
            }
            List<Product> products = await _db.Products.OrderByDescending(x => x.Id).Skip(skip).Take(6).ToListAsync();

            return PartialView("_ProductsLoadMorePartial", products);  
        }
    }
}
