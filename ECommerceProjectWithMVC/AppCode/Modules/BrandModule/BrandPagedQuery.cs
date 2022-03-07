using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.BrandModule
{
    public class BrandPagedQuery :IRequest<List<Brand>>
    {
        public class BrandPagedQueryHandler : IRequestHandler<BrandPagedQuery, List<Brand>>
        {
            readonly ShopDbContext db;
            public BrandPagedQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Brand>> Handle(BrandPagedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Brands.ToListAsync();
                return data;
            }
        }
    }
}
