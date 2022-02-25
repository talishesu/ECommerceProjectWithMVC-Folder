using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using ECommerceProjectWithMVC.Models.FormModels;
using ECommerceProjectWithMVC.Models.ViewModels;
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

            var vm = new ProductViewModel();



            var brands = await db.Brands.Where(b => b.DeletedTime == null).ToListAsync();
            var selectList = new SelectList(brands, "Id", "Name");

            vm.Brands = selectList;


            var categories = await db.Categories
                .Include(c => c.Children)
                .Where(b => b.DeletedTime == null).ToListAsync();
            var selectList2 = new SelectList(categories, "Id", "Name");

            vm.Categories = selectList2;


            vm.Specifications = await db.Specifications.Where(s=>s.DeletedTime == null).ToListAsync();

            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductFormModel productFormModel)
        {

            if (productFormModel.Product.Files == null || !productFormModel.Product.Files.Any())
            {
                ModelState.AddModelError("Product.Files", "Add Photo!");
            }



            var t = productFormModel.SelectedSpecifications.Where(ss => ss.Value != null);
            

            var specListForCategory = db.SpecificationCategoryItems.Where(spi => spi.CategoryId == productFormModel.Product.CategoryId);

            

            foreach (var item in t)
            {
                foreach (var item2 in specListForCategory)
                {
                    if(item2.SpecificationId != item.Id)
                    {
                        ModelState.AddModelError("Specifications", "An unspecified specification is written for the selected category!!");
                    }
                }
            }





            if (!ModelState.IsValid)
            {
                var vm = new ProductViewModel();



                var brands = await db.Brands.Where(b => b.DeletedTime == null).ToListAsync();
                var selectList = new SelectList(brands, "Id", "Name");

                vm.Brands = selectList;


                var categories = await db.Categories
                    .Include(c => c.Children)
                    .Where(b => b.DeletedTime == null).ToListAsync();
                var selectList2 = new SelectList(categories, "Id", "Name");

                vm.Categories = selectList2;


                vm.Specifications = await db.Specifications.Where(s => s.DeletedTime == null).ToListAsync();

                return View(vm);
            }

            productFormModel.Product.Images = new List<ProductImages>();

            foreach (var img in productFormModel.Product.Files)
            {
                var extension = Path.GetExtension(img.File.FileName);
                var fileName = $"product-{Guid.NewGuid()}{extension}".ToLower();


                var phsicalPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "products", "images", fileName);
                using (var fs = new FileStream(phsicalPath, FileMode.Create, FileAccess.Write))
                {
                    await img.File.CopyToAsync(fs);
                }

                productFormModel.Product.Images.Add(new ProductImages
                {
                    ImagePath = fileName,
                    IsMain = img.IsMain,
                    CreatedByUserId = 1
                });
            }
            productFormModel.Product.CreatedByUserId = 1;

            db.Products.Add(productFormModel.Product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
