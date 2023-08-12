using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeZone.DAL;
using TimeZone.Models;

namespace TimeZone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _db;
        public SlidersController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _db.Sliders.ToListAsync();
            return View(sliders);
        }

        #region Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            #region isExist
            bool isExist = await _db.Sliders.AnyAsync(x => x.Title == slider.Title);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This slider is already exist");
                return View();
            }
            #endregion

            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
            {
                return BadRequest();
            }
            return View(dbslider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
            {
                return BadRequest();
            }
            #region isExist
            bool isExist = await _db.Sliders.AnyAsync(x => x.Title == slider.Title && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This slider is already exist");
                return View();
            }
            #endregion

            dbslider.Title = slider.Title;
            dbslider.Description = slider.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        } 
        #endregion




    }
}
