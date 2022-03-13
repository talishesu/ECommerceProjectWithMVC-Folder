using ECommerceProjectWithMVC.AppCode.Providers;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using ECommerceProjectWithMVC.Models.FormModels;
using ECommerceProjectWithMVC.Models.ViewModels;
using ECommerceProjectWithMVC.AppCode.Modules.UserModule;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    { 
    
        readonly ShopDbContext db;
        readonly IMediator mediator;
        readonly UserManager<ShopUser> userManager;
        public UsersController(ShopDbContext db,IMediator mediator, UserManager<ShopUser> userManager)
        {

            this.db = db;
            this.mediator = mediator;
            this.userManager = userManager;
        }


        [Authorize(Policy = "admin.users.index")]
        public async Task<IActionResult> Index()
        {
            var query = new UserPagedQuery();

            var data = await mediator.Send(query);
            return View(data);
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


            vm.Claims = (from p in AppClaimProvider.policies
                         join uc in db.UserClaims.Where(_ => _.UserId == user.Id && _.ClaimValue.Equals("1")) on p equals uc.ClaimType into ljUc
                         from jUc in ljUc.DefaultIfEmpty()
                         select Tuple.Create(p, jUc != null)).ToList();


            return View(vm);
        }

        [HttpPost]
        [Authorize(Policy = "admin.users.detail")]
        public async Task<IActionResult> Detail([FromRoute]int id ,UserFormModel fm)
        {
            if(fm == null)
            {
                return BadRequest();
            }
            if(id < 0)
            {
                return BadRequest();
            }

            if(id != fm.User.Id)
            {
                return BadRequest();
            }


            if(fm.SelectedRoles == null)
            {
                return BadRequest();
            }
            if (fm.SelectedClaims == null)
            {
                return BadRequest();
            }

            var selectedRoles =  fm.SelectedRoles.Where(sr => sr.Selected == true).ToList();
            var selectedClaims = fm.SelectedClaims.Where(sr => sr.Selected == true).ToList();
            //if (selectedRoles.Count < 1)
            //{
            //    ModelState.AddModelError("Roles", "At least 1 role must be selected!");
            //}


            //if (!ModelState.IsValid)
            //{
            //    var user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

            //    if (user == null)
            //    {
            //        return NotFound();
            //    }

            //    var vm = new UserViewModel
            //    {
            //        User = user
            //    };

            //    vm.Roles = await (from r in db.Roles
            //                      join ur in db.UserRoles.Where(_ => _.UserId == user.Id) on r.Id equals ur.RoleId into ljUr
            //                      from jUr in ljUr.DefaultIfEmpty()
            //                      select Tuple.Create(r, jUr != null)).ToListAsync();


            //    vm.Claims = (from p in AppClaimProvider.policies
            //                 join uc in db.UserClaims.Where(_ => _.UserId == user.Id && _.ClaimValue.Equals("1")) on p equals uc.ClaimType into ljUc
            //                 from jUc in ljUc.DefaultIfEmpty()
            //                 select Tuple.Create(p, jUc != null)).ToList();


            //    return View(vm);
            //}


            var allUserRoles = await db.UserRoles.Where(ur=>ur.UserId == id).ToListAsync();
            //.Count > 0
            if (allUserRoles.Count > 0)
            {
                foreach (var item in allUserRoles)
                {
                    db.UserRoles.Remove(item);
                    await db.SaveChangesAsync();
                }
            }
            

            foreach (var item in selectedRoles)
            {
                ShopUserRole role = new ShopUserRole();
                role.UserId = fm.User.Id;
                role.RoleId = item.Id;
                await db.UserRoles.AddAsync(role);
                //await db.SaveChangesAsync();
            }




            var allUserClaims = await db.UserClaims.Where(ur => ur.UserId == id).ToListAsync();
            if(allUserClaims != null)
            {
                foreach (var item in allUserClaims)
                {
                    db.UserClaims.Remove(item);
                    //await db.SaveChangesAsync();
                }
            }
            
            if(selectedClaims.Count > 0)
            {
                foreach (var item in selectedClaims)
                {
                    ShopUserClaim claim =  new ShopUserClaim();
                    claim.UserId = fm.User.Id;
                    claim.ClaimType = item.ClaimType;
                    claim.ClaimValue = "1";
                    await db.UserClaims.AddAsync(claim);
                    //await db.SaveChangesAsync();
                }
            }


            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [Authorize(Policy = "admin.users.ban")]
        public async Task<IActionResult> Ban(int id)
        {
            var user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }



            var nowTime = DateTime.Now;
            nowTime = nowTime.AddDays(7);
            var result = await userManager.SetLockoutEnabledAsync(user,true);
            var result2 = await userManager.SetLockoutEndDateAsync(user, nowTime);



            if(result.Succeeded && result2.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [Authorize(Policy = "admin.users.unban")]
        public async Task<IActionResult> Unban(int id)
        {
            var user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }
            var nowTime = DateTime.Now;
            nowTime = nowTime.AddMilliseconds(1);
            


            var result2 = await userManager.SetLockoutEndDateAsync(user, null);


            if (result2.Succeeded)
            {
                var result = await userManager.SetLockoutEnabledAsync(user, false);
            }


            return RedirectToAction("Index");
        }
    }
}
