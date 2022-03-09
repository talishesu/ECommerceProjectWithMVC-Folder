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
    [AllowAnonymous]
    public class ShopController : Controller
    {
        readonly ShopDbContext db;
        public ShopController(ShopDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index(int CategoryId, int BrandId,int pageIndex=1,int pageSize = 12)
        {
            var vm = new ShopViewModel();
            if (CategoryId == 0 && BrandId == 0)
            {
                var products = await db.Products
                .Include(p => p.Images.Where(i => i.DeletedTime == null))
                .Where(b => b.DeletedTime == null).ToListAsync();
                vm.Products = new PagedViewModel<Product>(products, pageIndex, pageSize);
            }
            else if(CategoryId == 0)
            {
                var products = await db.Products
                .Include(p => p.Images.Where(i => i.DeletedTime == null))
                .Where(b => b.DeletedTime == null && b.BrandId == BrandId).ToListAsync();
                vm.Products = new PagedViewModel<Product>(products, pageIndex, pageSize);


                
            }else if(BrandId == 0)
            {
                var products = await db.Products
                .Include(p => p.Images.Where(i => i.DeletedTime == null))
                .Where(b => b.DeletedTime == null && b.CategoryId == CategoryId).ToListAsync();
                vm.Products = new PagedViewModel<Product>(products, pageIndex, pageSize);
                
            }
            else
            {
                var products = await db.Products
                .Include(p => p.Images.Where(i => i.DeletedTime == null))
                .Where(b => b.DeletedTime == null && b.CategoryId == CategoryId && b.BrandId == BrandId).ToListAsync();
                vm.Products = new PagedViewModel<Product>(products, pageIndex, pageSize);
            }


            
            vm.Brands = await db.Brands.Where(b => b.DeletedTime == null).ToListAsync();
            vm.Categories = await db.Categories
                .Include(c=>c.Children)
                .Where(b => b.DeletedTime == null).ToListAsync();
            


            vm.ProductPricings = await db.ProductPricings.Where(pp=> pp.DeletedTime == null).ToListAsync();
            vm.SelectedCategory = CategoryId;
            vm.SelectedBrand = BrandId;
            return View(vm);
        }
    }
}
