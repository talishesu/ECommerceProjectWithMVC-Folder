using ECommerceProjectWithMVC.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.ViewComponents
{
    public class TopSellProductsViewComponent:ViewComponent
    {
        readonly ShopDbContext db;
        public TopSellProductsViewComponent(ShopDbContext db)
        {
            this.db = db;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {


            var result = await db.Products
                .Include(p => p.Images.Where(i => i.DeletedTime == null && i.IsMain == true))
                .Include(p => p.PriceList.Where(i => i.DeletedTime == null))
                .OrderByDescending(p=>p.PriceList.Count)
                .Take(3)
                .ToListAsync();



            return View(result);
        }
    }
}
