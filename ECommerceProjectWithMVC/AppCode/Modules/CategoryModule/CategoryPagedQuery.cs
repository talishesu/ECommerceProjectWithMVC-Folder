using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.CategoryModule
{
    public class CategoryPagedQuery:IRequest<List<Category>>
    {
        public class CategoryPagedQueryHandler: IRequestHandler<CategoryPagedQuery, List<Category>>
        {
            readonly ShopDbContext db;
            public CategoryPagedQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Category>> Handle(CategoryPagedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Categories
                .Include(c => c.Children)
                .ToListAsync();

                return data;
            }
        }
    }
}
