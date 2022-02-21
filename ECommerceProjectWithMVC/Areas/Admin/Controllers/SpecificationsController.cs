using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using ECommerceProjectWithMVC.Models.FormModels;
using ECommerceProjectWithMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecificationsController : Controller
    {
        readonly ShopDbContext db;
        public SpecificationsController(ShopDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await db.Specifications.ToListAsync();
            return View(data);
        }



        public async Task<IActionResult> Create()
        {
            var vm = new SpecificationCreateViewModel();
            vm.Categories = await db.Categories
                .Include(c => c.Children)
                .Where(c => c.DeletedTime == null)
                .ToListAsync();


            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SpecificationFormModel specificationFormModel)
        {

            //if (!ModelState.IsValid)
            //{
            //    return View(specificationFormModel);
            //}

            var likeSpecification = await db.Specifications.FirstOrDefaultAsync(b => b.Name.ToLower() == specificationFormModel.Specification.Name.ToLower());
            if (likeSpecification != null)
            {
                ViewBag.Message = "Bu Adda Specification Var!";
                return View(specificationFormModel);
            }



            specificationFormModel.Specification.CreatedByUserId = 1;
            db.Specifications.Add(specificationFormModel.Specification);
            await db.SaveChangesAsync();



            foreach (var item in specificationFormModel.SelectedCategories)
            {
                if (item.Selected == true)
                {
                    SpecificationCategoryItem newSCI = new SpecificationCategoryItem();
                    newSCI.SpecificationId = specificationFormModel.Specification.Id;
                    newSCI.CategoryId = item.Id;
                    await db.SpecificationCategoryItems.AddAsync(newSCI);
                    await db.SaveChangesAsync();
                }
            }







            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }




        public async Task<IActionResult> Detail(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var specification = await db.Specifications.FirstOrDefaultAsync(b=>b.Id == id);
            if (specification == null)
            {
                return NotFound();
            }
            var vm = new SpecificationViewModel();

            var specificationCategoryItems = await db.SpecificationCategoryItems.Where(c => c.SpecificationId == id).ToListAsync();

            vm.Specification = specification;
            vm.SpecificationCategoryItems = specificationCategoryItems;
            vm.Categories = await db.Categories
                .Include(c => c.Children)
                .Where(c => c.DeletedTime == null)
                .ToListAsync();


            return View(vm);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var specification = await db.Specifications.FirstOrDefaultAsync(b => b.Id == id);
            var specificationCategoryItems = await db.SpecificationCategoryItems.Where(c=>c.SpecificationId == id).ToListAsync();

            if (specification == null)
            {
                return NotFound();
            }

            if (specification.DeletedTime != null)
            {
                return NotFound();
            }
            var vm = new SpecificationViewModel();
            vm.Specification =  specification;
            vm.SpecificationCategoryItems = specificationCategoryItems;
            vm.Categories = await db.Categories
                .Include(c => c.Children)
                .Where(c => c.DeletedTime == null)
                .ToListAsync();
            

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, SpecificationFormModel specificationFormModel)
        {

            if (!ModelState.IsValid)
            {
                return View(specificationFormModel);
            }

            if (id != specificationFormModel.Specification.Id || id<1)
            {
                return BadRequest();
            }

            var likeSpecification = await db.Specifications.FirstOrDefaultAsync(b => b.Name.ToLower() == specificationFormModel.Specification.Name.ToLower());
            if (likeSpecification != null && likeSpecification.Id != specificationFormModel.Specification.Id)
            {
                ViewBag.Message = "Bu Adda Specification Var!";
                return View(specificationFormModel);
            }

            var b = await db.Specifications.FirstOrDefaultAsync(specification => specification.Id == id);


            if(b == null)
            {
                return NotFound();
            }

            b.Name = specificationFormModel.Specification.Name;
            b.Description = specificationFormModel.Specification.Description;







            foreach (var item in specificationFormModel.SelectedCategories)
            {
                if(item.Selected == false)
                {
                    var d= await db.SpecificationCategoryItems.Where(c => c.SpecificationId == id && c.CategoryId == item.Id).FirstOrDefaultAsync();
                    if (d != null)
                    {
                        db.SpecificationCategoryItems.Remove(d);
                        await db.SaveChangesAsync();
                    }
                }
                else
                {
                    var d = await db.SpecificationCategoryItems.Where(c => c.SpecificationId == id && c.CategoryId == item.Id).FirstOrDefaultAsync();
                    if(d == null)
                    {
                        SpecificationCategoryItem newSCI = new SpecificationCategoryItem();
                        newSCI.SpecificationId = id;
                        newSCI.CategoryId = item.Id;
                        await db.SpecificationCategoryItems.AddAsync(newSCI);
                        await db.SaveChangesAsync();
                    }
                    
                }
            }







            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete( int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var specification = await db.Specifications.FirstOrDefaultAsync(b => b.Id == id);
            if (specification == null)
            {
                return NotFound();
            }
            if (specification.DeletedTime != null)
            {
                return NotFound();
            }

            specification.DeletedTime = DateTime.Now;
            specification.DeletedByUserId = 1;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Reverse(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var specification = await db.Specifications.FirstOrDefaultAsync(b => b.Id == id);
            if (specification == null)
            {
                return NotFound();
            }
            if (specification.DeletedTime == null)
            {
                return NotFound();
            }

            specification.DeletedTime = null;
            specification.DeletedByUserId = null;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
