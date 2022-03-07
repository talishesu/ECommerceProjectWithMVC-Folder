using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.UserModule
{
    public class UserPagedQuery : IRequest<List<ShopUser>>
    {
        public class UserPagedQueryHandler : IRequestHandler<UserPagedQuery, List<ShopUser>>
        {
            readonly ShopDbContext db;
            public UserPagedQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ShopUser>> Handle(UserPagedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Users.ToListAsync();
                return data;
            }
        }
    }
}
