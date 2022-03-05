using ECommerceProjectWithMVC.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.ViewComponents
{
    public class LastAddedProductsViewComponent : ViewComponent 
    { 

        readonly ShopDbContext db;
        public LastAddedProductsViewComponent(ShopDbContext db)
        {
            this.db = db;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {


            var result = await db.Products
                .Include(p => p.Images.Where(i => i.DeletedTime == null && i.IsMain == true))
                .Include(p=>p.PriceList.Where(i => i.DeletedTime == null))
                .OrderByDescending(p => p.Id)
                .Take(3)
                .ToListAsync();



            return View(result);
        }
    }
}
