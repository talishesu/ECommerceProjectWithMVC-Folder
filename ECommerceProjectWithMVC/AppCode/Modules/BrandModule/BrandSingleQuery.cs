using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.BrandModule
{
    public class BrandSingleQuery: IRequest<Brand>
    {
        public int Id { get; set; }
        public class BrandSingleQueryHandler : IRequestHandler<BrandSingleQuery, Brand>
        {
            readonly ShopDbContext db;
            public BrandSingleQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<Brand> Handle(BrandSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id < 1)
                {
                    return null;
                }

                var data = await db.Brands.FirstOrDefaultAsync(b => b.Id == request.Id);
                if (data == null)
                {
                    return null;
                }

                return data;
            }
        }
    }
}
