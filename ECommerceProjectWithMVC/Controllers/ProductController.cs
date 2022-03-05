using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        readonly ShopDbContext db;
        public ProductController(ShopDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index(int id)
        {
            if(id < 0)
            {
                return BadRequest();
            }
            var product = await db.Products.FirstOrDefaultAsync(p=>p.Id == id && p.DeletedTime == null);
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

            return View(vm);
        }
    }
}
