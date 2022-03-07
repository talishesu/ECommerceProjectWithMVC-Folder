
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.ProductModule
{
    public class ProductSingleQuery: IRequest<ProductDetailViewModel>
    {
        public int Id { get; set; }
        public class ProductSingleQueryHandler : IRequestHandler<ProductSingleQuery, ProductDetailViewModel>
        {
            readonly ShopDbContext db;
            public ProductSingleQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<ProductDetailViewModel> Handle(ProductSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id < 1)
                {
                    return null;
                }


                var vm = new ProductDetailViewModel();


                vm.Product = await db.Products
                    .Include(p => p.Images.Where(i => i.DeletedTime == null))
                    .FirstOrDefaultAsync(p => p.Id == request.Id && p.DeletedTime == null);
                if (vm.Product == null)
                {
                    return null;
                }
                vm.Product.Brand = await db.Brands.FirstOrDefaultAsync(b => b.Id == vm.Product.BrandId);
                vm.Product.Category = await db.Categories.FirstOrDefaultAsync(b => b.Id == vm.Product.CategoryId);
                vm.ProductImages = await db.ProductImages.Where(pi => pi.DeletedTime == null && pi.ProductId == request.Id).ToListAsync();
                vm.SpecificationProductItems = await db.SpecificationProductItems.Where(spi => spi.ProductId == request.Id && spi.DeletedTime == null).ToListAsync();
                vm.Specifications = await db.Specifications.Where(s => s.DeletedTime == null).ToListAsync();


                vm.AllSizes = await db.Sizes.Where(s => s.DeletedTime == null).ToListAsync();
                vm.AllColors = await db.Colors.Where(s => s.DeletedTime == null).ToListAsync();
                vm.ProductPricings = await db.ProductPricings.Where(pp => pp.ProductId == request.Id && pp.DeletedTime == null).ToListAsync();

                return vm;

            }
        }
    }
}
