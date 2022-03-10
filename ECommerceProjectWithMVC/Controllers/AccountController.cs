using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using ECommerceProjectWithMVC.Models.FormModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceProjectWithMVC.AppCode.Extensions;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using Shop.Cryptolib;
using System;
using System.Net;

namespace ECommerceProjectWithMVC.Controllers
{
    public class AccountController : Controller
    {
        readonly SignInManager<ShopUser> signinManager;
        readonly UserManager<ShopUser> userManager;
        readonly ShopDbContext db;
        readonly IConfiguration configuration;
        public AccountController(SignInManager<ShopUser> signinManager, UserManager<ShopUser> userManager, ShopDbContext db, IConfiguration configuration)
        {
            this.signinManager = signinManager;
            this.userManager = userManager; 
            this.db = db;
            this.configuration = configuration;
        }
        [AllowAnonymous]
        [Route("/signin.html")]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("/signin.html")]
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
                    return Redirect("/");
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
        [Route("/signup.html")]
        public IActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("/signup.html")]
        public async Task<IActionResult> Signup(SignupFormModel model)
        {
            var NotConfirmedEmail = await db.Users.FirstOrDefaultAsync(u=>u.Email == model.Email && u.EmailConfirmed == false);
            if(NotConfirmedEmail != null)
            {
                var token = await userManager.GenerateEmailConfirmationTokenAsync(NotConfirmedEmail);



                string userName = configuration["emailAccount:userName"];
                string password = configuration["emailAccount:password"];
                string displayName = configuration["emailAccount:displayName"];
                string smtpHost = configuration["emailAccount:smtpHost"];
                int port = Convert.ToInt32(configuration["emailAccount:port"]);

                MailAddress fromAddress = new MailAddress(userName, displayName);
                MailAddress toAddress = new MailAddress(NotConfirmedEmail.Email);

                MailMessage message = new MailMessage(fromAddress, toAddress);
                message.Subject = "Please verify with link...";



                string requestLink = $"{Request.Scheme}://{Request.Host}/signup-confirm.html?email={NotConfirmedEmail.Email}&token={token}";

                message.Body = $"Please verify by <a href='{requestLink}' target='_blank'>Link</a>";
                message.IsBodyHtml = true;


                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new NetworkCredential(userName, password);
                smtpClient.EnableSsl = true;
                smtpClient.Host = smtpHost;
                smtpClient.Port = port;

                //smtpClient.UseDefaultCredentials = false;
                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


                smtpClient.Send(message);



                ViewBag.Message = "Verify Email!";

                return RedirectToAction("Signin");
            }
            if (ModelState.IsValid)
            {
                var user = new ShopUser();
                user.Email = model.Email;
                user.UserName = model.Email;
                user.Name = model.Name;
                user.Surname = model.Surname;
                //user.EmailConfirmed = true;



                var result = await userManager.CreateAsync(user,model.Password);



                if (result.Succeeded)
                {
                    var token  = await userManager.GenerateEmailConfirmationTokenAsync(user);



                    string userName = configuration["emailAccount:userName"];
                    string password = configuration["emailAccount:password"];
                    string displayName = configuration["emailAccount:displayName"];
                    string smtpHost = configuration["emailAccount:smtpHost"];
                    int port = Convert.ToInt32(configuration["emailAccount:port"]);

                    MailAddress fromAddress = new MailAddress(userName, displayName);
                    MailAddress toAddress = new MailAddress(user.Email);

                    MailMessage message = new MailMessage(fromAddress, toAddress);
                    message.Subject = "Please verify with link...";



                    string requestLink = $"{Request.Scheme}://{Request.Host}/signup-confirm.html?email={user.Email}&token={token}";

                    message.Body = $"Please verify by <a href='{requestLink}' target='_blank'>Link</a>";
                    message.IsBodyHtml = true;


                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new NetworkCredential(userName, password);
                    smtpClient.EnableSsl = true;
                    smtpClient.Host = smtpHost;
                    smtpClient.Port = port;

                    //smtpClient.UseDefaultCredentials = false;
                    //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


                    smtpClient.Send(message);



                    ViewBag.Message = "Verify Email!";

                    return RedirectToAction("Signin");
                }


                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        [Route("/signup-confirm.html")]
        public async Task<IActionResult> SignupConfirm(string email, string token)
        {
            token = token.Replace(" ", "+");
            var foundedUser = await userManager.FindByEmailAsync(email);

            if(foundedUser == null)
            {
                ViewBag.Message = "ERROR";
                goto end;
            }
           var result =  await userManager.ConfirmEmailAsync(foundedUser, token);

            if (!result.Succeeded)
            {
                ViewBag.Message = "ERROR";
                goto end;
            }
            ViewBag.Message = "Your Email Address Confirmed!";
        end:
            return RedirectToAction("Signin");
        }

        [AllowAnonymous]
        [Route("/forget-password.html")]
        public async Task<IActionResult> ForgetPassword()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("/forget-password.html")]
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            ShopUser founded = null;

            if(email == null)
            {
                ViewBag.Message = "Please Write Email Or Username!";
                return View();
            }
            if (email.IsEmail())
            {
                founded = await userManager.FindByEmailAsync(email);
            }
            else
            {
                founded = await userManager.FindByNameAsync(email);
            }

            if (founded == null)
            {
                ViewBag.Message = "User Not Founded";
                return View(email);
            }

            var token = await userManager.GeneratePasswordResetTokenAsync(founded);



            string userName = configuration["emailAccount:userName"];
            string password = configuration["emailAccount:password"];
            string displayName = configuration["emailAccount:displayName"];
            string smtpHost = configuration["emailAccount:smtpHost"];
            int port = Convert.ToInt32(configuration["emailAccount:port"]);

            MailAddress fromAddress = new MailAddress(userName, displayName);
            MailAddress toAddress = new MailAddress(email);

            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = "Please verify with link...";



            string requestLink = $"{Request.Scheme}://{Request.Host}/new-password.html?email={email}&token={token}";

            message.Body = $"Change Password by <a href='{requestLink}' target='_blank'>Link</a>";
            message.IsBodyHtml = true;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(userName, password);
            smtpClient.EnableSsl = true;
            smtpClient.Host = smtpHost;
            smtpClient.Port = port;

            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


            smtpClient.Send(message);



            ViewBag.Message = "Go To Email!";

            return RedirectToAction("Signin");
        }




        [AllowAnonymous]
        [Route("/new-password.html")]
        public async Task<IActionResult> NewPassword(string email, string token)
        {
            if (email == null || token == null)
            {
                return BadRequest();
            }
            return View();
        }



        [AllowAnonymous]
        [HttpPost]
        [Route("/new-password.html")]
        public async Task<IActionResult> NewPassword(string email, string token, string newPassword)
        {
            if(email == null||token == null || newPassword == null)
            {
                return BadRequest();
            }


            token = token.Replace(" ", "+");
            ShopUser foundedUser = null;
            if (email.IsEmail())
            {
                foundedUser = await userManager.FindByEmailAsync(email);
            }
            else
            {
                foundedUser = await userManager.FindByNameAsync(email);
            }


            if (foundedUser == null)
            {
                ViewBag.Message = "ERROR";
                goto end;
            }
            var result = await userManager.ResetPasswordAsync(foundedUser, token, newPassword);

            if (!result.Succeeded)
            {
                ViewBag.Message = "ERROR";
                goto end;
            }
            ViewBag.Message = "Your Password Changed!";
        end:
            return RedirectToAction("Signin");
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
