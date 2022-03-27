using ECommerceProjectWithMVC.AppCode.Extensions;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Controllers
{
    public class CardController : Controller
    {
        readonly ShopDbContext db;
        public CardController(ShopDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.GetPrincipalId();
            var userCardListProduct = await db.UserCardItems.Where(uc => uc.UserId == userId).ToListAsync();
            foreach (var item in userCardListProduct)
            {
                item.ProductPricing = await db.ProductPricings.FirstOrDefaultAsync(pp => pp.Id == item.ProductPricingId);
                item.ProductPricing.Product = await db.Products
                    .Include(p=>p.Images)
                    .FirstOrDefaultAsync(p=>p.Id ==item.ProductPricing.ProductId);
                item.ProductPricing.Color = await db.Colors.FirstOrDefaultAsync(p=>p.Id ==item.ProductPricing.ColorId);
                item.ProductPricing.Size = await db.Sizes.FirstOrDefaultAsync(p=>p.Id ==item.ProductPricing.SizeId);
            }
            return View(userCardListProduct);
        }

        public async Task<IActionResult> Delete(int colorId,int sizeId,int productId)
        {
            var productPricing = await db.ProductPricings.FirstOrDefaultAsync(pp=>pp.ColorId ==colorId && pp.ProductId ==productId && pp.SizeId == sizeId);
            if(productPricing == null)
            {
                return BadRequest();
            }
            var userCardItem = await db.UserCardItems.FirstOrDefaultAsync(uc => uc.ProductPricingId == productPricing.Id && uc.UserId == User.GetPrincipalId());
            db.UserCardItems.Remove(userCardItem);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAll()
        {
            var userCardItems = await db.UserCardItems.Where(uc=>uc.UserId == User.GetPrincipalId()).ToListAsync();
            if(userCardItems == null)
            {
                return RedirectToAction("Index","Shop");
            }
            foreach (var item in userCardItems)
            {
                db.UserCardItems.Remove(item);
            }
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Shop");
        }



        public async Task<IActionResult> Checkout()
        {
            var userCardItems = await db.UserCardItems.Where(uci=>uci.UserId == User.GetPrincipalId()).ToListAsync();
            if(userCardItems == null)
            {
                return RedirectToAction("Index", "Shop");
            }

            foreach (var userCardItem in userCardItems)
            {
               Order order = new Order();
                order.User = userCardItem.User;
                order.UserId = userCardItem.UserId;
                order.ProductPricing = await db.ProductPricings.FirstOrDefaultAsync(pp => pp.Id == userCardItem.ProductPricingId); 
                order.ProductPricingId = userCardItem.ProductPricingId;
                order.Count = userCardItem.Count;
                order.CreatedByUserId = userCardItem.UserId;
                order.OrderAction = "Waiting";
                db.Orders.Add(order);
            }
            foreach (var userCardItem in userCardItems)
            {
                db.UserCardItems.Remove(userCardItem);
            }
            await db.SaveChangesAsync();

            return RedirectToAction("Index","Shop");
        }

    }
}
