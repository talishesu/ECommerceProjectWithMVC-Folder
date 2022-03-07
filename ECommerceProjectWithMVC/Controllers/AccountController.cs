using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using ECommerceProjectWithMVC.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceProjectWithMVC.AppCode.Extensions;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Controllers
{
    public class AccountController : Controller
    {
        readonly SignInManager<ShopUser> signinManager;
        readonly UserManager<ShopUser> userManager;
        readonly ShopDbContext db;
        public AccountController(SignInManager<ShopUser> signinManager, UserManager<ShopUser> userManager, ShopDbContext db)
        {
            this.signinManager = signinManager;
            this.userManager = userManager; 
            this.db = db;
        }
        [AllowAnonymous]
        [Route("signin.html")]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("signin.html")]
        public async Task<IActionResult> Signin(SigninFormModel model)
        {
            if (ModelState.IsValid)
            {
                ShopUser founded = null;
                bool appliedPhoneLogin = false;
                if (model.UserName.IsPhone())
                {
                    appliedPhoneLogin = true;
                    founded = await db.Users.FirstOrDefaultAsync(u=>u.PhoneNumber.Equals(model.UserName));
                }
                else if(model.UserName.IsEmail())
                {
                    founded = await userManager.FindByEmailAsync(model.UserName);
                }else{
                    founded = await userManager.FindByNameAsync(model.UserName);
                }

                if(founded == null)
                {
                    goto end;
                }

                if(appliedPhoneLogin && founded.PhoneNumberConfirmed == false)
                {
                    ViewBag.Message = "Your Phone Number Not Confirmed!";
                    return View(model);
                }else if(founded.EmailConfirmed == false)
                {
                    ViewBag.Message = "Your Email Address Not Confirmed!";
                    return View(model);
                }

                var signinResult = await signinManager.PasswordSignInAsync(founded, model.Password, true, true);


                if (signinResult.Succeeded)
                {

                    string callbackUrl = Request.Query["ReturnUrl"];

                    if (!string.IsNullOrEmpty(callbackUrl))
                    {
                        return Redirect(callbackUrl);
                    }
                    return Redirect("/admin");
                }

                if (signinResult.IsLockedOut)
                {
                    ViewBag.Message = "Please try again 5 minutes later";
                    return View(model);
                }


                if (signinResult.IsNotAllowed)
                {
                    ViewBag.Message = "Your account has been blocked, please contact Support";
                    return View(model);
                }
            }

            end:
            ViewBag.Message = "Username or Password is incorrect!";
            return View(model);
        }


        [AllowAnonymous]
        [Route("accessdenied.html")]
        public IActionResult Denied()
        {
            return View();
        }


        [Route("signout.html")]
        public async Task<IActionResult> Signout()
        {
            await signinManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
