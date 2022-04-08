using ECommerceProjectWithMVC.AppCode.Extensions;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        readonly ShopDbContext db;
        readonly UserManager<ShopUser> userManager;
        public OrdersController(ShopDbContext db, UserManager<ShopUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        [Authorize(Policy = "admin.orders.index")]
        public async Task<IActionResult> Index()
        {
            
            var data = await db.Orders.ToListAsync();
            foreach (var item in data)
            {
                item.ProductPricing = await db.ProductPricings.FirstOrDefaultAsync(pp => pp.Id == item.ProductPricingId);
                item.ProductPricing.Product = await db.Products
                    .Include(p => p.Images)
                    .FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ProductId);
                item.ProductPricing.Color = await db.Colors.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ColorId);
                item.ProductPricing.Size = await db.Sizes.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.SizeId);
            }

            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                data = data.Where(d=>d.ProductPricing.Product.CreatedByUserId == userId).ToList();
                return View(data);
            }
            return View(data);
        }
        [Authorize(Policy = "admin.orders.edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await db.Orders.FirstOrDefaultAsync(o=>o.Id == id);

            


            if (item == null)
            {
                return BadRequest();
            }

                item.ProductPricing = await db.ProductPricings.FirstOrDefaultAsync(pp => pp.Id == item.ProductPricingId);
                item.ProductPricing.Product = await db.Products
                    .Include(p => p.Images)
                    .FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ProductId);
                item.ProductPricing.Color = await db.Colors.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ColorId);
                item.ProductPricing.Size = await db.Sizes.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.SizeId);


            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                if (item.ProductPricing.Product.CreatedByUserId != userId)
                {
                    return BadRequest();
                }
            }


            return View(item);
        }

        [HttpPost]
        [Authorize(Policy = "admin.orders.edit")]
        public async Task<IActionResult> Edit(int id ,string orderAction)
        {
            var item = await db.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (item == null)
            {
                return BadRequest();
            }

            if(orderAction == null)
            {
                goto End;
            }
            else
            {
                item.LastUpdateByUserId = User.GetPrincipalId();
                item.LastUpdateTime = DateTime.Now;
                item.OrderAction = orderAction;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

        End:
            item.ProductPricing = await db.ProductPricings.FirstOrDefaultAsync(pp => pp.Id == item.ProductPricingId);
            item.ProductPricing.Product = await db.Products
                .Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ProductId);
            item.ProductPricing.Color = await db.Colors.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ColorId);
            item.ProductPricing.Size = await db.Sizes.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.SizeId);

            ViewBag.Message = "Enter Order Action";

            var userId = User.GetPrincipalId();
            var user = await userManager.FindByIdAsync(userId.ToString());
            var IsInRole = await userManager.IsInRoleAsync(user, "Seller");
            if (IsInRole == true)
            {
                if (item.ProductPricing.Product.CreatedByUserId != userId)
                {
                    return BadRequest();
                }
            }


            return View(item);
            
            
        }
    }
}
