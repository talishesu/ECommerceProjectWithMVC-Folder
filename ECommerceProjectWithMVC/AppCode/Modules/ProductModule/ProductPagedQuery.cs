using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.ProductModule
{
    public class ProductPagedQuery: IRequest<List<Product>>
    {
        public class ProductPagedQueryHandler : IRequestHandler<ProductPagedQuery, List<Product>>
        {
            readonly ShopDbContext db;
            public ProductPagedQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Product>> Handle(ProductPagedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Products
                .Include(p => p.Images.Where(i => i.DeletedTime == null))
                .ToListAsync();
                return data;
            }
        }
    }
}
