using ECommerceProjectWithMVC.AppCode.Extensions;
using ECommerceProjectWithMVC.Models.DataContexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        readonly ShopDbContext db;
        public OrdersController(ShopDbContext db)
        {
            this.db = db;
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
            return View(data);
        }
        [Authorize(Policy = "admin.orders.edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await db.Orders.FirstOrDefaultAsync(o=>o.Id == id);
            if(item == null)
            {
                return BadRequest();
            }

                item.ProductPricing = await db.ProductPricings.FirstOrDefaultAsync(pp => pp.Id == item.ProductPricingId);
                item.ProductPricing.Product = await db.Products
                    .Include(p => p.Images)
                    .FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ProductId);
                item.ProductPricing.Color = await db.Colors.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.ColorId);
                item.ProductPricing.Size = await db.Sizes.FirstOrDefaultAsync(p => p.Id == item.ProductPricing.SizeId);
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
            return View(item);
            
            
        }
    }
}
