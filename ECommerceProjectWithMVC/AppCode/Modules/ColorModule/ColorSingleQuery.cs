using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.ColorModule
{
    public class ColorSingleQuery: IRequest<Color>
    {
        public int Id { get; set; }
        public class ColorSingleQueryHandler : IRequestHandler<ColorSingleQuery, Color>
        {
            readonly ShopDbContext db;
            public ColorSingleQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<Color> Handle(ColorSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id < 1)
                {
                    return null;
                }

                var data = await db.Colors.FirstOrDefaultAsync(b => b.Id == request.Id);
                if (data == null)
                {
                    return null;
                }
                return data;
            }
        }
    }
}
