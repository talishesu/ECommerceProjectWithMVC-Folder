using ECommerceProjectWithMVC.AppCode.Extensions;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using ECommerceProjectWithMVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Controllers
{
    
    public class ProductController : Controller
    {
        readonly ShopDbContext db;
        public ProductController(ShopDbContext db)
        {
            this.db = db;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(int id)
        {
            if(id < 0)
            {
                return BadRequest();
            }
            var product = await db.Products
                .Include(p=>p.Comments.Where(p=>p.Confirmed == true && p.DeletedTime == null))
                .FirstOrDefaultAsync(p=>p.Id == id && p.DeletedTime == null);
            if(product == null)
            {
                return NotFound();
            }
            var vm = new ProductIndexViewModel();

            vm.Product = product;
            vm.Product.Brand = await db.Brands.FirstOrDefaultAsync(b => b.Id == vm.Product.BrandId);
            vm.Product.Category = await db.Categories.FirstOrDefaultAsync(b => b.Id == vm.Product.CategoryId);
            vm.ProductImages = await db.ProductImages.Where(pi => pi.DeletedTime == null && pi.ProductId == id).ToListAsync();
            vm.SpecificationProductItems = await db.SpecificationProductItems.Where(spi => spi.ProductId == id && spi.DeletedTime == null).ToListAsync();
            vm.Specifications = await db.Specifications.Where(s => s.DeletedTime == null).ToListAsync();

            vm.ProductPricings = await db.ProductPricings
                
                .Include(p=>p.Color)
                .Include(p=>p.Size)
                .Where(pp => pp.ProductId == id && pp.DeletedTime == null).ToListAsync();


            vm.Users = await db.Users.ToListAsync();
            var seller = await db.Users.FirstOrDefaultAsync(u => u.Id == vm.Product.CreatedByUserId);
            //if(seller.Id == 1)
            //{
            //    vm.SellerName = "LOGI";
            //}
            //else
            //{
                if (seller.UserName.IsEmail())
                {
                    vm.SellerName = seller.Name;
                }
                else
                {
                    vm.SellerName = seller.UserName;
                }
            
            //}
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int id,string comment)
        {

            var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id && p.DeletedTime == null);
            if (product == null)
            {
                return BadRequest();
            }

            ProductComment comment1 = new ProductComment();
            comment1.ProductId = id;
            comment1.Comment = comment;
            comment1.CreatedByUserId = User.GetPrincipalId();
            comment1.Product = product;
            db.ProductComments.Add(comment1);
            await db.SaveChangesAsync();
            return RedirectToAction("Index",id);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCard(int colorId, int sizeId, int count,int productId)
        {

            var productPricing = await db.ProductPricings.FirstOrDefaultAsync(pp => pp.ColorId == colorId && pp.SizeId == sizeId&&pp.ProductId == productId && pp.DeletedTime == null);

            if (productPricing == null)
            {
                return BadRequest();
            }
            var userId = (int)User.GetPrincipalId();
            var userCard = await db.UserCardItems.FirstOrDefaultAsync(uc => uc.UserId == userId && uc.ProductPricingId == productPricing.Id);
            if(userCard == null)
            {
                UserCardItem userCardItem = new UserCardItem();
                userCardItem.ProductPricing = productPricing;
                userCardItem.UserId = userId;
                userCardItem.ProductPricingId = productPricing.Id;
                userCardItem.Count = count;
                db.UserCardItems.Add(userCardItem);
            }else
            {
                userCard.Count = userCard.Count + count;
            }
            
            await db.SaveChangesAsync();
            return RedirectToAction("Index","Card");
        }
    }
}
