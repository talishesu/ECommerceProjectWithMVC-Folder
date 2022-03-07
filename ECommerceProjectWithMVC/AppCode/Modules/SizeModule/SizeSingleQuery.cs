using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.SizeModule
{
    public class SizeSingleQuery: IRequest<Size>
    {
        public int Id { get; set; }
        public class SizeSingleQueryHandler : IRequestHandler<SizeSingleQuery, Size>
        {
            readonly ShopDbContext db;
            public SizeSingleQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<Size> Handle(SizeSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id < 1)
                {
                    return null;
                }

                var data = await db.Sizes.FirstOrDefaultAsync(b => b.Id == request.Id);
                if (data == null)
                {
                    return null;
                }
                return data;
            }
        }
    }
}
