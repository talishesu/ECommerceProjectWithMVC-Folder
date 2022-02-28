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


            var sizes = await db.Sizes.Where(b => b.DeletedTime == null).ToListAsync();
            var selectList3 = new SelectList(sizes, "Id", "Name");
            vm.Sizes = selectList3;



            var colors = await db.Colors.Where(b => b.DeletedTime == null)
                .Select(c => new { Id = c.Id, Text = $"{c.Name}({c.ColorHexCode})" })
                .ToListAsync();
            var selectList4 = new SelectList(colors, "Id", "Text");
            vm.Colors = selectList4;

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



            var selectSpec = productFormModel.SelectedSpecifications.Where(ss => ss.Value != null);
            

            var specListForCategory = db.SpecificationCategoryItems.Where(spi => spi.CategoryId == productFormModel.Product.CategoryId);

            

            foreach (var item in selectSpec)
            {
                    var t = specListForCategory.Where(slc => slc.SpecificationId == item.Id);
                    if (!t.Any())
                    {
                        ModelState.AddModelError("Specifications", "An unspecified specification is written for the selected category!!");
                    }
            }


            if(productFormModel.ProductPricings == null)
            {
                ModelState.AddModelError("Colors", "Please Create New Pricing!!");
            }
            else
            {
                foreach (var item in productFormModel.ProductPricings)
                {

                    var oldpp =  productFormModel.ProductPricings.Where(pp=>pp.ColorId == item.ColorId && pp.SizeId == item.SizeId).ToList();
                    if(oldpp.Count() > 1)
                    {
                        ModelState.AddModelError("Colors", "Size and Color Cannot Be Similar!!");
                    }
                    else
                    {
                        if (  item.Price == 0 ||item.Price == null)
                        {
                            ModelState.AddModelError("Colors", "Fill in all the fields!!");
                        }

                        if (item.ColorId == 0 || item.ColorId == null )
                        {
                            ModelState.AddModelError("Colors", "Fill in all the fields!!");
                        }
                        if (item.SizeId == 0 || item.SizeId == null)
                        {
                            ModelState.AddModelError("Colors", "Fill in all the fields!!");
                        }
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


                var sizes = await db.Sizes.Where(b => b.DeletedTime == null).ToListAsync();
                var selectList3 = new SelectList(sizes, "Id", "Name");
                vm.Sizes = selectList3;



                var colors = await db.Colors.Where(b => b.DeletedTime == null)
                    .Select(c => new { Id = c.Id, Text = $"{c.Name}({c.ColorHexCode})" })
                    .ToListAsync();
                var selectList4 = new SelectList(colors, "Id", "Text");
                vm.Colors = selectList4;

                return View(vm);
            }



            foreach (var item in selectSpec)
            {
                SpecificationProductItem newSCI = new SpecificationProductItem();
                newSCI.SpecificationId = item.Id;
                newSCI.ProductId = productFormModel.Product.Id;
                newSCI.Value = item.Value;
                newSCI.Product = productFormModel.Product;
                newSCI.Specification = await db.Specifications.FirstOrDefaultAsync(s=> s.Id == item.Id);
                newSCI.CreatedByUserId = 1;
                await db.SpecificationProductItems.AddAsync(newSCI);
                //await db.SaveChangesAsync();
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

            foreach (var item in productFormModel.ProductPricings)
            {
                ProductPricing newPP = new ProductPricing();
                newPP.ColorId = item.ColorId;
                newPP.Price = item.Price;
                newPP.ProductId = productFormModel.Product.Id;
                newPP.Product = productFormModel.Product;
                newPP.SizeId = item.SizeId;
                
                newPP.CreatedByUserId = 1;
                await db.ProductPricings.AddAsync(newPP);
                //await db.SaveChangesAsync();
            }


            await db.Products.AddAsync(productFormModel.Product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
