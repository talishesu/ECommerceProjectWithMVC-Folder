using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using ECommerceProjectWithMVC.AppCode.Modules.CategoryModule;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using ECommerceProjectWithMVC.AppCode.Extensions;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        readonly ShopDbContext db;
        readonly IMediator mediator;
        public CategoriesController(ShopDbContext db,IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }
        [Authorize(Policy = "admin.categories.index")]
        public async Task<IActionResult> Index()
        {
            var query = new CategoryPagedQuery();
            
            var data = await mediator.Send(query);

            return View(data);
        }


        [Authorize(Policy = "admin.categories.create")]
        public async Task<IActionResult> Create()
        {
            var categories = await db.Categories.Where(c => c.DeletedTime == null).ToListAsync();
            var selectList = new SelectList(categories,"Id","Name");
            ViewBag.Categories = selectList;
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "admin.categories.create")]
        public async Task<IActionResult> Create(Category category)
        {
            var categories = db.Categories.Where(c => c.DeletedTime == null).ToList();
            var selectList = new SelectList(categories, "Id", "Name", category.ParentId);
            ViewBag.Categories = selectList;

            var likeCategory = await db.Categories.FirstOrDefaultAsync(b => b.Name.ToLower() == category.Name.ToLower());
            if (likeCategory != null)
            {
                if(likeCategory.ParentId == category.ParentId)
                {
                    ViewBag.Message = "Bu Adda  Category Var!";
                    return View(category);
                }
                ViewBag.Message = "Bu Adda Category Basqa Esas Category-da Var!";
                return View(category);
            }

            if (ModelState.IsValid)
            {
                category.CreatedByUserId = User.GetPrincipalId();
                db.Categories.Add(category);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            
            return View(category);
        }



        [Authorize(Policy = "admin.categories.detail")]
        public async Task<IActionResult> Detail(CategorySingleQuery query)
        {

            //var query = new CategoriesSingleQuery
            //{
            //    Id = id,
            //};


            var data = await mediator.Send(query);

            if(data == null)
            {
                return NotFound();
            }
            return View(data);
        }


        [Authorize(Policy = "admin.categories.edit")]
        public async Task<IActionResult> Edit(int id)
        {
                if (id < 1)
                {
                    return NotFound();
                }

                var category = await db.Categories.FirstOrDefaultAsync(b => b.Id == id);

                var categories = db.Categories.Where(c => c.DeletedTime == null).ToList();
                var selectList = new SelectList(categories, "Id", "Name", category.ParentId);
                ViewBag.Categories = selectList;

                if (category == null)
                {
                    return NotFound();
                }

                if (category.DeletedTime != null)
                {
                    return NotFound();
                }

                return View(category);
        }


        [Authorize(Policy = "admin.categories.edit")]
        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, Category category)
        {
                var categories = db.Categories
                    .Include(c=>c.Children)
                    .Where(c => c.DeletedTime == null).ToList();
                var selectList = new SelectList(categories, "Id", "Name", category.ParentId);
                ViewBag.Categories = selectList;

                if (!ModelState.IsValid)
                {
                    return View(category);
                }


                if (id != category.Id || id < 1)
                {
                    return BadRequest();
                }

                var likeCategory = await db.Categories.FirstOrDefaultAsync(b => b.Name.ToLower() == category.Name.ToLower());
                if (likeCategory != null && likeCategory.Id != category.Id)
                {
                    if (likeCategory.ParentId == category.ParentId)
                    {
                        ViewBag.Message = "Bu Adda  Category Var!";
                        return View(category);
                    }
                    ViewBag.Message = "Bu Adda Category Basqa Esas Category-da Var!";
                    return View(category);


                    //ViewBag.Message = "Bu Adda Category Var!";
                    //return View(category);


                }

                var b = await db.Categories.FirstOrDefaultAsync(category => category.Id == id);

                if (b == null)
                {
                    return NotFound();
                }



                b.Name = category.Name;
                b.ParentId = category.ParentId;
                b.Description = category.Description;


                await db.SaveChangesAsync();
                

                return RedirectToAction("Index");
        }

        [Authorize(Policy = "admin.categories.delete")]
        public async Task<IActionResult> Delete( int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var category = await db.Categories
                .Include(c => c.Children.Where(ch=>ch.DeletedTime ==null))
                .FirstOrDefaultAsync(b => b.Id == id);


            if(category.Children.Count()  >= 1 )
            {
                
                // ViewBag.Message = "Bu Kateqoriyanin Alt Kateqoriyasi Var";
                return Content("Bu Kateqoriyanin Alt Kateqoriyasi Var");
            }


            if (category == null)
            {
                return NotFound();
            }
            if (category.DeletedTime != null)
            {
                return NotFound();
            }

            category.DeletedTime = DateTime.Now;
            category.DeletedByUserId = User.GetPrincipalId();
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [Authorize(Policy = "admin.categories.reverse")]
        public async Task<IActionResult> Reverse(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var category = await db.Categories
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(b => b.Id == id);


            if(category.Parent != null)
            {
                if (category.Parent.DeletedTime != null)
                {
                    //ViewBag.Message = "Bu Kateqoriyanin Ust  Kateqoriyasi Silinib";


                    return Content("Bu Kateqoriyanin Ust  Kateqoriyasi Silinib");
                }
            }

            




            if (category == null)
            {
                return NotFound();
            }
            if (category.DeletedTime == null)
            {
                return NotFound();
            }

            category.DeletedTime = null;
            category.DeletedByUserId = null;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
