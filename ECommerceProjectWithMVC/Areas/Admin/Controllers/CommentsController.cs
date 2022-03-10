using ECommerceProjectWithMVC.AppCode.Extensions;
using ECommerceProjectWithMVC.Models.DataContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentsController : Controller
    {
        
        readonly ShopDbContext db;
        public CommentsController(ShopDbContext db)
        {
            this.db = db;
        }
        [Authorize(Policy = "admin.comments.index")]
        public async Task<IActionResult> Index()
        {
            var data = await db.ProductComments.ToListAsync();
            return View(data);
        }



        [Authorize(Policy = "admin.comments.delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var comment = await db.ProductComments.FirstOrDefaultAsync(b => b.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            if (comment.DeletedTime != null)
            {
                return NotFound();
            }

            comment.DeletedTime = DateTime.Now;
            comment.DeletedByUserId = User.GetPrincipalId();
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [Authorize(Policy = "admin.comments.reverse")]
        public async Task<IActionResult> Reverse(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var comment = await db.ProductComments.FirstOrDefaultAsync(b => b.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            if (comment.DeletedTime == null)
            {
                return NotFound();
            }

            comment.DeletedTime = null;
            comment.DeletedByUserId = null;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [Authorize(Policy = "admin.comments.confirm")]
        public async Task<IActionResult> Confirm(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var comment = await db.ProductComments.FirstOrDefaultAsync(b => b.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            if (comment.Confirmed == true)
            {
                return NotFound();
            }

            comment.Confirmed = true;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [Authorize(Policy = "admin.comments.unconfirm")]
        public async Task<IActionResult> UnConfirm(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var comment = await db.ProductComments.FirstOrDefaultAsync(b => b.Id == id);
            if (comment == null)
            {
                return NotFound();
            }
            if (comment.Confirmed == false)
            {
                return NotFound();
            }

            comment.Confirmed = false;
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
