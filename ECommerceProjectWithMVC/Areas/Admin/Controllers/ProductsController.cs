using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using ECommerceProjectWithMVC.Models.FormModels;
using ECommerceProjectWithMVC.Models.ViewModels;
using ECommerceProjectWithMVC.AppCode.Modules.ProductModule;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
using ECommerceProjectWithMVC.AppCode.Extensions;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        readonly ShopDbContext db;
        readonly IWebHostEnvironment env;
        readonly IMediator mediator;
        readonly UserManager<ShopUser> userManager;
        public ProductsController(ShopDbContext db, IWebHostEnvironment env, IMediator mediator, UserManager<ShopUser> userManager)
        {
            this.db = db;
            this.env = env;
            this.mediator = mediator;
            this.userManager = userManager;
        }

        [Authorize(Policy = "admin.products.index")]
        public async Task<IActionResult> Index()
        {

            var query = new ProductPagedQuery();

            var data = await mediator.Send(query);

            var userId = User.GetPrincipalId();
                var user = await userManager.FindByIdAsync(userId.ToString());
                var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
                if (IsInRole == true)
                {
                    data = data.Where(d=>d.CreatedByUserId == userId).ToList();
                }

            return View(data);
        }



        [Authorize(Policy = "admin.products.detail")]
        public async Task<IActionResult> Detail(ProductSingleQuery query)
        {
            var data = await mediator.Send(query);

            if (data == null)
            {
                return NotFound();
            }

            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                if(data.Product.CreatedByUserId != userId)
                {
                    return BadRequest();
                }
            }

            return View(data);
        }


        [HttpGet]
        [Authorize(Policy = "admin.products.create")]
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.products.create")]
        public async Task<IActionResult> Create(ProductFormModel productFormModel)
        {

            if (productFormModel.Product.Files == null || !productFormModel.Product.Files.Any())
            {
                ModelState.AddModelError("Product.Files", "Add Photo!");
            }



            var selectSpec = productFormModel.SelectedSpecifications.Where(ss => ss.Value != null);


            var specListForCategory =await db.SpecificationCategoryItems.Where(spi => spi.CategoryId == productFormModel.Product.CategoryId).ToListAsync();



            foreach (var item in selectSpec)
            {
                var t = specListForCategory.Where(slc => slc.SpecificationId == item.Id);
                if (!t.Any())
                {
                    ModelState.AddModelError("Specifications", "An unspecified specification is written for the selected category!!");
                }
            }


            if (productFormModel.ProductPricings == null)
            {
                ModelState.AddModelError("Colors", "Please Create New Pricing!!");
            }
            else
            {
                foreach (var item in productFormModel.ProductPricings)
                {

                    var oldpp = productFormModel.ProductPricings.Where(pp => pp.ColorId == item.ColorId && pp.SizeId == item.SizeId).ToList();
                    if (oldpp.Count() > 1)
                    {
                        ModelState.AddModelError("Colors", "Size and Color Cannot Be Similar!!");
                    }
                    else
                    {
                        if (item.Price == 0 || item.Price == null)
                        {
                            ModelState.AddModelError("Colors", "Fill in all the fields!!");
                        }

                        if (item.ColorId == 0 || item.ColorId == null)
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
                newSCI.Specification = await db.Specifications.FirstOrDefaultAsync(s => s.Id == item.Id);
                newSCI.CreatedByUserId = User.GetPrincipalId();
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
                    CreatedByUserId = User.GetPrincipalId()
            });
            }
            productFormModel.Product.CreatedByUserId = User.GetPrincipalId();

            foreach (var item in productFormModel.ProductPricings)
            {
                ProductPricing newPP = new ProductPricing();
                newPP.ColorId = item.ColorId;
                newPP.Price = item.Price;
                newPP.ProductId = productFormModel.Product.Id;
                newPP.Product = productFormModel.Product;
                newPP.SizeId = item.SizeId;

                newPP.CreatedByUserId = User.GetPrincipalId();
                await db.ProductPricings.AddAsync(newPP);
                //await db.SaveChangesAsync();
            }


            await db.Products.AddAsync(productFormModel.Product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



        [HttpGet]
        [Authorize(Policy = "admin.products.edit")]

        public async Task<IActionResult> Edit(int id)
        {



            var vm = new ProductCreateViewModel();

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

            vm.AllSizes = await db.Sizes.Where(b => b.DeletedTime == null).ToListAsync();
            vm.AllColors = await db.Colors.Where(b => b.DeletedTime == null).ToListAsync();


            vm.Product = await db.Products.FirstOrDefaultAsync(pp => pp.Id == id);



            vm.SpecificationProductItems = await db.SpecificationProductItems.Where(SPI => SPI.ProductId == id).ToListAsync();
            vm.ProductImages = await db.ProductImages.Where(p => p.ProductId == id && p.DeletedTime == null).ToListAsync();
            vm.ProductPricings = await db.ProductPricings.Where(pp => pp.ProductId == id).ToListAsync();

            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                if (vm.Product.CreatedByUserId != userId)
                {
                    return BadRequest();
                }
            }

            return View(vm);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.products.edit")]

        public async Task<IActionResult> Edit([FromRoute] int id, ProductFormModel productFormModel)
        {
            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                if (productFormModel.Product.CreatedByUserId != userId)
                {
                    return BadRequest();
                }
            }


            if (id != productFormModel.Product.Id)
                {
                    return BadRequest();
                }


                if (productFormModel.Product.Files == null)
                {
                    ModelState.AddModelError("Product.Files", "Add Photo!");
                }





                var selectSpec = productFormModel.SelectedSpecifications.Where(ss => ss.Value != null);


                var specListForCategory = await db.SpecificationCategoryItems.Where(spi => spi.CategoryId == productFormModel.Product.CategoryId).ToListAsync();



                foreach (var item in selectSpec)
                {
                    var t = specListForCategory.Where(slc => slc.SpecificationId == item.Id);
                    if (!t.Any())
                    {
                        ModelState.AddModelError("Specifications", "An unspecified specification is written for the selected category!!");
                    }
                }


                if (productFormModel.ProductPricings == null)
                {
                    var propri = await db.ProductPricings.Where(p => p.ProductId == id && p.DeletedTime == null).ToListAsync();
                    if (propri == null)
                    {
                        ModelState.AddModelError("Colors", "Please Create New Pricing!!");
                    }
                }
                else
                {


                    foreach (var item in productFormModel.ProductPricings)
                    {

                        var oldpp = productFormModel.ProductPricings.Where(pp => pp.ColorId == item.ColorId && pp.SizeId == item.SizeId).ToList();



                        if (oldpp.Count() > 1)
                        {
                            ModelState.AddModelError("Colors", "Size and Color Cannot Be Similar!!");
                        }
                        else
                        {
                            if (item.Price == 0 || item.Price == null)
                            {
                                ModelState.AddModelError("Colors", "Fill in all the fields!!");
                            }

                            if (item.ColorId == 0 || item.ColorId == null)
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
                    var vm = new ProductCreateViewModel();

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

                    vm.AllSizes = await db.Sizes.Where(b => b.DeletedTime == null).ToListAsync();
                    vm.AllColors = await db.Colors.Where(b => b.DeletedTime == null).ToListAsync();


                    vm.Product = await db.Products.FirstOrDefaultAsync(pp => pp.Id == id);

                    vm.SpecificationProductItems = await db.SpecificationProductItems.Where(SPI => SPI.ProductId == id).ToListAsync();
                    vm.ProductImages = await db.ProductImages.Where(p => p.ProductId == id && p.DeletedTime == null).ToListAsync();
                    vm.ProductPricings = await db.ProductPricings.Where(pp => pp.ProductId == id).ToListAsync();



                    return View(vm);
                }


                if (productFormModel.ProductPricings != null)
                {
                    foreach (var item in db.ProductPricings.Where(p => p.ProductId == id))
                    {
                        db.ProductPricings.Remove(item);
                    }

                    foreach (var item in productFormModel.ProductPricings)
                    {


                        ProductPricing newPP = new ProductPricing();
                        newPP.ColorId = item.ColorId;
                        newPP.Price = item.Price;
                        newPP.ProductId = productFormModel.Product.Id;
                        //newPP.Product = productFormModel.Product;
                        newPP.SizeId = item.SizeId;

                        newPP.CreatedByUserId = User.GetPrincipalId();
                    await db.ProductPricings.AddAsync(newPP);
                        //await db.SaveChangesAsync();
                    }
                }



                foreach (var item in db.SpecificationProductItems.Where(p => p.ProductId == id))
                {
                     db.SpecificationProductItems.Remove(item);
                }


                foreach (var item in selectSpec)
                {
                    SpecificationProductItem newSCI = new SpecificationProductItem();
                    newSCI.SpecificationId = item.Id;
                    newSCI.ProductId = productFormModel.Product.Id;
                    newSCI.Value = item.Value;
                    //newSCI.Product = productFormModel.Product;
                    newSCI.Specification = await db.Specifications.FirstOrDefaultAsync(s => s.Id == item.Id);
                    newSCI.CreatedByUserId = User.GetPrincipalId();
                    await db.SpecificationProductItems.AddAsync(newSCI);
                    //await db.SaveChangesAsync();
                }





                var entity = await db.Products
                    .Include(p => p.Images.Where(i => i.DeletedTime == null))
                    .Include(p => p.SpecificationItems.Where(i => i.DeletedTime == null))
                    .Include(p => p.PriceList.Where(i => i.DeletedTime == null))
                    .FirstOrDefaultAsync(p => p.Id == id && p.DeletedTime == null);

                if (entity == null)
                {
                    return NotFound();
                }

                entity.SKU = productFormModel.Product.SKU;
                entity.Name = productFormModel.Product.Name;
                entity.ShortDescription = productFormModel.Product.ShortDescription;
                entity.BrandId = productFormModel.Product.BrandId;
                entity.Description = productFormModel.Product.Description;


                #region Compare Images
                foreach (var image in productFormModel.Product.Files)
                {

                    if (image.Id != null && image.Id > 0)
                    {
                        var current = entity.Images.FirstOrDefault(i => i.Id == image.Id);
                        if (current != null)
                        {
                            if (string.IsNullOrWhiteSpace(image.TempPath)) //viewde silinme kimi vurulub
                            {

                                current.DeletedByUserId = User.GetPrincipalId();
                                current.DeletedTime = DateTime.Now;

                            }
                            else //viewde oldugu kimi gelib,yada ismain deyishib
                            {
                                current.IsMain = image.IsMain;
                            }
                        }
                    }
                    else if (image.File != null) //yeni fayllar
                    {
                        var extension = Path.GetExtension(image.File.FileName); //.jpg
                        var fileName = $"product-{Guid.NewGuid()}{extension}".ToLower();
                        var phsicalPath = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "products", "images", fileName);

                        using (var fs = new FileStream(phsicalPath, FileMode.Create, FileAccess.Write))
                        {
                            await image.File.CopyToAsync(fs);
                        }

                        entity.Images.Add(new ProductImages
                        {
                            ImagePath = fileName,
                            IsMain = image.IsMain
                        });
                    }
                }
                #endregion


                await db.SaveChangesAsync();
               
            return RedirectToAction("Index");
        }


        [Authorize(Policy = "admin.products.delete")]

        public async Task<IActionResult> Delete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var product = await db.Products.FirstOrDefaultAsync(b => b.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            if (product.DeletedTime != null)
            {
                return NotFound();
            }

            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                if (product.CreatedByUserId != userId)
                {
                    return BadRequest();
                }
            }

            product.DeletedTime = DateTime.Now;
            product.DeletedByUserId = User.GetPrincipalId();
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [Authorize(Policy = "admin.products.reverse")]
        public async Task<IActionResult> Reverse(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var product = await db.Products.FirstOrDefaultAsync(b => b.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            if (product.DeletedTime == null)
            {
                return NotFound();
            }
            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                if (product.CreatedByUserId != userId)
                {
                    return BadRequest();
                }
            }
            product.DeletedTime = null;
            product.DeletedByUserId = null;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
