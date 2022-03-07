using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.Modules.SpecificationModule
{
    public class SpecificationSingleQuery : IRequest<SpecificationViewModel>
    {
        public int Id { get; set; }
        public class SpecificationSingleQueryHandler : IRequestHandler<SpecificationSingleQuery, SpecificationViewModel>
        {
            readonly ShopDbContext db;
            public SpecificationSingleQueryHandler(ShopDbContext db)
            {
                this.db = db;
            }
            public async Task<SpecificationViewModel> Handle(SpecificationSingleQuery request, CancellationToken cancellationToken)
            {

                if (request.Id < 1)
                {
                    return null;
                }

                var specification = await db.Specifications.FirstOrDefaultAsync(b => b.Id == request.Id);
                if (specification == null)
                {
                    return null;
                }
                var vm = new SpecificationViewModel();

                var specificationCategoryItems = await db.SpecificationCategoryItems.Where(c => c.SpecificationId == request.Id).ToListAsync();

                vm.Specification = specification;
                vm.SpecificationCategoryItems = specificationCategoryItems;
                vm.Categories = await db.Categories
                    .Include(c => c.Children)
                    .Where(c => c.DeletedTime == null)
                    .ToListAsync();
                return vm;

            }
        }
    }
}
