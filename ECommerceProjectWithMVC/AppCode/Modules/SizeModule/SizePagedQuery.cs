using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.SizeModule
{
    public class SizePagedQuery: IRequest<List<Size>>
    {
        public class SizePagedQueryHandler : IRequestHandler<SizePagedQuery, List<Size>>
        {
            readonly ShopDbContext db;
            public SizePagedQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Size>> Handle(SizePagedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Sizes.ToListAsync();
                return data;
            }
        }
    }
}
