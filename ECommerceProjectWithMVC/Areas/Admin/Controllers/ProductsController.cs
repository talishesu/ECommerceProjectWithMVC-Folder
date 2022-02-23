using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        readonly ShopDbContext db;
        readonly IWebHostEnvironment env;
        public ProductsController(ShopDbContext db,IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }


        public async Task<IActionResult> Index()
        {
            var products = await db.Products
                .Include(p => p.Images)
                .ToListAsync();
            return View(products);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var brands = await db.Brands.Where(b => b.DeletedTime == null).ToListAsync();
            var selectList = new SelectList(brands, "Id", "Name");
            ViewBag.BrandId = selectList;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {

            var brands = await db.Brands.Where(b => b.DeletedTime == null).ToListAsync();
            var selectList = new SelectList(brands, "Id", "Name");
            ViewBag.BrandId = selectList;

            if (product.Files == null || !product.Files.Any())
            {
                ModelState.AddModelError("Files", "Add Photo!");
            }

            if (!ModelState.IsValid)
            {
                return View(product);
            }

            product.Images = new List<ProductImages>();

            foreach (var img in product.Files)
            {
                var extension = Path.GetExtension(img.File.FileName);
                var fileName = $"product-{Guid.NewGuid()}{extension}".ToLower();


                var phsicalPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "products", "images", fileName);
                using (var fs = new FileStream(phsicalPath, FileMode.Create, FileAccess.Write))
                {
                    await img.File.CopyToAsync(fs);
                }

                product.Images.Add(new ProductImages
                {
                    ImagePath = fileName,
                    IsMain = img.IsMain,
                    CreatedByUserId = 1
                });
            }
            product.CreatedByUserId = 1;

            db.Products.Add(product);
            await db.SaveChangesAsync();
            return RedirectToAction("Create");
        }
    }
}
