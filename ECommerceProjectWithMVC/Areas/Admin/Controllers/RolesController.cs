using ECommerceProjectWithMVC.AppCode.Providers;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using ECommerceProjectWithMVC.Models.FormModels;
using ECommerceProjectWithMVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesController : Controller
    {
        readonly ShopDbContext db;
        readonly RoleManager<ShopRole> roleManager;
        public RolesController(ShopDbContext db, RoleManager<ShopRole> roleManager)
        {
            this.db = db;
            this.roleManager = roleManager;
        }

        [Authorize(Policy = "admin.roles.index")]
        public async Task<IActionResult> Index()
        {
            var data = await db.Roles.ToListAsync();
            return View(data);
        }


        [Authorize(Policy = "admin.roles.create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "admin.roles.create")]
        public async Task<IActionResult> Create(ShopRole role)
        {
            if (role.Name == null)
            {
                ViewBag.Message = "Please Write Name!";
                return View(role);
            }
            var result = await roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Message = "ERROR!";
            return View(role);
        }

        [Authorize(Policy = "admin.roles.detail")]
        public async Task<IActionResult> Detail(int id)
        {
            var role = await db.Roles.FirstOrDefaultAsync(u => u.Id == id);

            if (role == null)
            {
                return NotFound();
            }

            var vm = new RoleViewModel
            {
                Role = role
            };

            vm.Claims = (from p in AppClaimProvider.policies
                         join uc in db.RoleClaims.Where(_ => _.RoleId == role.Id && _.ClaimValue.Equals("1")) on p equals uc.ClaimType into ljUc
                         from jUc in ljUc.DefaultIfEmpty()
                         select Tuple.Create(p, jUc != null)).ToList();

            return View(vm);
        }



        [HttpPost]
        [Authorize(Policy = "admin.roles.detail")]
        public async Task<IActionResult> Detail([FromRoute] int id, RoleFormModel fm)
        {
            if (fm == null)
            {
                return BadRequest();
            }
            if (id < 0)
            {
                return BadRequest();
            }

            if (id != fm.Role.Id)
            {
                return BadRequest();
            }
            if (fm.SelectedClaims == null)
            {
                return BadRequest();
            }
            var selectedClaims = fm.SelectedClaims.Where(sr => sr.Selected == true).ToList();


            var allRoleClaims = await db.RoleClaims.Where(ur => ur.RoleId == id).ToListAsync();
            if (allRoleClaims != null)
            {
                foreach (var item in allRoleClaims)
                {
                    db.RoleClaims.Remove(item);
                    //await db.SaveChangesAsync();
                }
            }

            if (selectedClaims.Count > 0)
            {
                foreach (var item in selectedClaims)
                {
                    ShopRoleClaim claim = new ShopRoleClaim();
                    claim.RoleId = fm.Role.Id;
                    claim.ClaimType = item.ClaimType;
                    claim.ClaimValue = "1";
                    await db.RoleClaims.AddAsync(claim);
                    //await db.SaveChangesAsync();
                }
            }


            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



        [Authorize(Policy = "admin.roles.delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }


            var role = await db.Roles.FirstOrDefaultAsync(r => r.Id == id);
            if(role == null)
            {
                return BadRequest();
            }
            var result = await roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
