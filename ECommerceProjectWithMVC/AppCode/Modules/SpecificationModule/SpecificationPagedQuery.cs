using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.SpecificationModule
{
    public class SpecificationPagedQuery: IRequest<List<Specification>>
    {
        public class SpecificationPagedQueryHandler : IRequestHandler<SpecificationPagedQuery, List<Specification>>
        {
            readonly ShopDbContext db;
            public SpecificationPagedQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Specification>> Handle(SpecificationPagedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Specifications.ToListAsync();
                return data;
            }
        }
    }
}
