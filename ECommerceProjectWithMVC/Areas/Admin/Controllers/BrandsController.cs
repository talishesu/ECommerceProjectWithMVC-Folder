using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandsController : Controller
    {
        readonly ShopDbContext db;
        public BrandsController(ShopDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await db.Brands.ToListAsync();
            return View(data);
        }



        [Authorize(Policy ="admin.brands.create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[Authorize(Policy = "admin.brands.create")]
        public async Task<IActionResult> Create(Brand brand)
        {

            var likeBrand = await db.Brands.FirstOrDefaultAsync(b => b.Name.ToLower() == brand.Name.ToLower());
            if (likeBrand != null)
            {
                ViewBag.Message = "Bu Adda Brand Var!";
                return View(brand);
            }

            if (ModelState.IsValid)
            {
                brand.CreatedByUserId = 1;
                db.Brands.Add(brand);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(brand);
        }




        //[Authorize(Policy = "admin.brands.detail")]
        public async Task<IActionResult> Detail(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var brand = await db.Brands.FirstOrDefaultAsync(b=>b.Id == id);
            if (brand == null)
            {
                return NotFound();
            }

            

            return View(brand);
        }


        //[Authorize(Policy = "admin.brands.edit")]
        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var brand = await db.Brands.FirstOrDefaultAsync(b => b.Id == id);

            if (brand == null)
            {
                return NotFound();
            }

            if (brand.DeletedTime != null)
            {
                return NotFound();
            }

            

            return View(brand);
        }



        [HttpPost]
        //[Authorize(Policy = "admin.brands.edit")]
        public async Task<IActionResult> Edit([FromRoute] int id, Brand brand)
        {

            if (!ModelState.IsValid)
            {
                return View(brand);
            }

            if (id != brand.Id || id<1)
            {
                return BadRequest();
            }

            var likeBrand = await db.Brands.FirstOrDefaultAsync(b => b.Name.ToLower() == brand.Name.ToLower());
            if (likeBrand != null && likeBrand.Id != brand.Id)
            {
                ViewBag.Message = "Bu Adda Brand Var!";
                return View(brand);
            }

            var b = await db.Brands.FirstOrDefaultAsync(brand => brand.Id == id);


            if(b == null)
            {
                return NotFound();
            }

            b.Name = brand.Name;
            b.Description = brand.Description;


            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



        //[Authorize(Policy = "admin.brands.delete")]
        public async Task<IActionResult> Delete( int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var brand = await db.Brands.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            if (brand.DeletedTime != null)
            {
                return NotFound();
            }

            brand.DeletedTime = DateTime.Now;
            brand.DeletedByUserId = 1;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        //[Authorize(Policy = "admin.brands.reverse")]
        public async Task<IActionResult> Reverse(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var brand = await db.Brands.FirstOrDefaultAsync(b => b.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            if (brand.DeletedTime == null)
            {
                return NotFound();
            }

            brand.DeletedTime = null;
            brand.DeletedByUserId = null;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
