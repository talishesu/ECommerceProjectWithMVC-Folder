using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SizesController : Controller
    {
        readonly ShopDbContext db;
        public SizesController(ShopDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await db.Sizes.ToListAsync();
            return View(data);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Size size)
        {

            var likeSizeName = await db.Sizes.FirstOrDefaultAsync(b => b.Name.ToLower() == size.Name.ToLower());
            if (likeSizeName != null)
            {
                ViewBag.Message = "Bu Adda Size Var!";
                return View(size);
            }


            var likeSizeShortName = await db.Sizes.FirstOrDefaultAsync(b => b.ShortName.ToLower() == size.ShortName.ToLower());
            if (likeSizeShortName != null)
            {
                ViewBag.Message = "Bu Qisa Adda Size Var!";
                return View(size);
            }



            if (ModelState.IsValid)
            {
                size.CreatedByUserId = 1;
                db.Sizes.Add(size);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(size);
        }




        public async Task<IActionResult> Detail(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var size = await db.Sizes.FirstOrDefaultAsync(b=>b.Id == id);
            if (size == null)
            {
                return NotFound();
            }

            

            return View(size);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var size = await db.Sizes.FirstOrDefaultAsync(b => b.Id == id);

            if (size == null)
            {
                return NotFound();
            }

            if (size.DeletedTime != null)
            {
                return NotFound();
            }

            

            return View(size);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, Size size)
        {

            if (!ModelState.IsValid)
            {
                return View(size);
            }

            if (id != size.Id || id<1)
            {
                return BadRequest();
            }

            var likeSizeName = await db.Sizes.FirstOrDefaultAsync(b => b.Name.ToLower() == size.Name.ToLower());
            if (likeSizeName != null && likeSizeName.Id != size.Id)
            {
                ViewBag.Message = "Bu Adda Size Var!";
                return View(size);
            }


            var likeSizeShortName = await db.Sizes.FirstOrDefaultAsync(b => b.ShortName.ToLower() == size.ShortName.ToLower());
            if (likeSizeShortName != null && likeSizeShortName.Id != size.Id)
            {
                ViewBag.Message = "Bu Qisa Adda Size Var!";
                return View(size);
            }

            var b = await db.Sizes.FirstOrDefaultAsync(size => size.Id == id);


            if(b == null)
            {
                return NotFound();
            }

            b.Name = size.Name;
            b.ShortName = size.ShortName;


            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete( int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var size = await db.Sizes.FirstOrDefaultAsync(b => b.Id == id);
            if (size == null)
            {
                return NotFound();
            }
            if (size.DeletedTime != null)
            {
                return NotFound();
            }

            size.DeletedTime = DateTime.Now;
            size.DeletedByUserId = 1;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Reverse(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var size = await db.Sizes.FirstOrDefaultAsync(b => b.Id == id);
            if (size == null)
            {
                return NotFound();
            }
            if (size.DeletedTime == null)
            {
                return NotFound();
            }

            size.DeletedTime = null;
            size.DeletedByUserId = null;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
