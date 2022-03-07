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
    public class ColorsController : Controller
    {
        readonly ShopDbContext db;
        public ColorsController(ShopDbContext db)
        {
            this.db = db;
        }
        [Authorize(Policy = "admin.colors.index")]
        public async Task<IActionResult> Index()
        {
            var data = await db.Colors.ToListAsync();
            return View(data);
        }


        [Authorize(Policy = "admin.colors.create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "admin.colors.create")]
        public async Task<IActionResult> Create(Color color)
        {

            var likeColor = await db.Colors.FirstOrDefaultAsync(b => b.Name.ToLower() == color.Name.ToLower());
            if (likeColor != null)
            {
                ViewBag.Message = "Bu Adda color Var!";
                return View(color);
            }

            var likeColorHexCode = await db.Colors.FirstOrDefaultAsync(b => b.ColorHexCode == color.ColorHexCode);
            if (likeColorHexCode != null)
            {
                ViewBag.Message = "Bu Hex Code-a Sahib color Var!";
                return View(color);
            }

            if (ModelState.IsValid)
            {
                ViewBag.Message = null;
                color.CreatedByUserId = 1;
                db.Colors.Add(color);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(color);
        }



        [Authorize(Policy = "admin.colors.detail")]
        public async Task<IActionResult> Detail(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var color = await db.Colors.FirstOrDefaultAsync(b=>b.Id == id);
            if (color == null)
            {
                return NotFound();
            }

            

            return View(color);
        }

        [Authorize(Policy = "admin.colors.edit")]
        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var color = await db.Colors.FirstOrDefaultAsync(b => b.Id == id);

            if (color == null)
            {
                return NotFound();
            }

            if (color.DeletedTime != null)
            {
                return NotFound();
            }

            

            return View(color);
        }

        [HttpPost]
        [Authorize(Policy = "admin.colors.edit")]
        public async Task<IActionResult> Edit([FromRoute] int id, Color color)
        {

            if (!ModelState.IsValid)
            {
                return View(color);
            }

            if (id != color.Id || id<1)
            {
                return BadRequest();
            }

            var likeColor = await db.Colors.FirstOrDefaultAsync(b => b.Name.ToLower() == color.Name.ToLower());
            if (likeColor != null && likeColor.Id != color.Id)
            {
                ViewBag.Message = "Bu Adda color Var!";
                return View(color);
            }

            var likeColorHexCode = await db.Colors.FirstOrDefaultAsync(b => b.ColorHexCode == color.ColorHexCode);
            if (likeColorHexCode != null && likeColorHexCode.Id != color.Id)
            {
                ViewBag.Message = "Bu Hex Code-a Sahib color Var!";
                return View(color);
            }

            var b = await db.Colors.FirstOrDefaultAsync(color => color.Id == id);


            if(b == null)
            {
                return NotFound();
            }

            b.Name = color.Name;
            b.ColorHexCode = color.ColorHexCode;


            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [Authorize(Policy = "admin.colors.delete")]
        public async Task<IActionResult> Delete( int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var color = await db.Colors.FirstOrDefaultAsync(b => b.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            if (color.DeletedTime != null)
            {
                return NotFound();
            }

            color.DeletedTime = DateTime.Now;
            color.DeletedByUserId = 1;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [Authorize(Policy = "admin.colors.reverse")]
        public async Task<IActionResult> Reverse(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var color = await db.Colors.FirstOrDefaultAsync(b => b.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            if (color.DeletedTime == null)
            {
                return NotFound();
            }

            color.DeletedTime = null;
            color.DeletedByUserId = null;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
