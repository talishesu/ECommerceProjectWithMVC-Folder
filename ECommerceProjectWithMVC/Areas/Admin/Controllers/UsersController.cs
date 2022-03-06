using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    { 
    
        readonly ShopDbContext db;
        public UsersController(ShopDbContext db)
        {

            this.db = db;
        }


        [Authorize(Policy = "admin.users.index")]
        public async Task<IActionResult> Index()
        {
            var users = await db.Users.ToListAsync();
            return View(users);
        }





        [Authorize(Policy = "admin.users.detail")]
        public async Task<IActionResult> Detail(int id)
        {
            var user = await db.Users.FirstOrDefaultAsync(u=>u.Id == id);

            if(user == null)
            {
                return NotFound();
            }

            var vm = new UserViewModel
            {
                User = user
            };

            vm.Roles = await (from r in db.Roles
                              join ur in db.UserRoles.Where(_ => _.UserId == user.Id) on r.Id equals ur.RoleId into ljUr
                              from jUr in ljUr.DefaultIfEmpty()
                              select Tuple.Create(r, jUr != null)).ToListAsync();


            vm.Claims = (from p in Program.policies
                         join uc in db.UserClaims.Where(_ => _.UserId == user.Id && _.ClaimValue.Equals("1")) on p equals uc.ClaimType into ljUc
                         from jUc in ljUc.DefaultIfEmpty()
                         select Tuple.Create(p, jUc != null)).ToList();


            return View(vm);
        }


        [HttpPost]
        [Authorize(Policy = "admin.users.ban")]
        public IActionResult Ban()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "admin.users.unban")]
        public IActionResult Unban()
        {
            return View();
        }
    }
}
