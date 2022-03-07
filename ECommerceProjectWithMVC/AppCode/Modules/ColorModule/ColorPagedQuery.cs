using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.ColorModule
{
    public class ColorPagedQuery : IRequest<List<Color>>
    {
        public class ColorPagedQueryHandler : IRequestHandler<ColorPagedQuery, List<Color>>
        {
            readonly ShopDbContext db;
            public ColorPagedQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Color>> Handle(ColorPagedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Colors.ToListAsync();
                return data;
            }
        }
    }
}
