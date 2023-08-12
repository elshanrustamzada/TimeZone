using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TimeZone.DAL;
using TimeZone.Models;
using TimeZone.ViewModels;

namespace TimeZone.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _db.Sliders.ToListAsync(),
            };
            return View(homeVM);
        }

        public IActionResult Error()
        {
            return View();
        }


    }
}
