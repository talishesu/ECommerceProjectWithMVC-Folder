using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.CategoryModule
{
    public class CategorySingleQuery:IRequest<Category>
    {
        public int Id { get; set; }

        public class CategorySingleQueryHandler : IRequestHandler<CategorySingleQuery, Category>
        {
            readonly ShopDbContext db;
            public CategorySingleQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<Category> Handle(CategorySingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id < 1)
                {
                    return null;
                }

                var data = await db.Categories
                    .Include(c => c.Parent)
                    .FirstOrDefaultAsync(b => b.Id == request.Id);
                if (data == null)
                {
                    return null;
                }
                return data;

            }
        }
    }
}
