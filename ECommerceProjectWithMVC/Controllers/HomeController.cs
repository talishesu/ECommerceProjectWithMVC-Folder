using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shop.Cryptolib;
using System;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        readonly ShopDbContext db;
        readonly IConfiguration configuration;
        public HomeController(ShopDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {

                    ModelState.Clear();

                

                    db.Contacts.Add(contact);
                    await db.SaveChangesAsync();


                    ViewBag.Message = "Check Email!";

                    string securityKey = configuration["securityKey"];

                    string userName = configuration["emailAccount:userName"];
                    string password = configuration["emailAccount:password"];
                    string displayName = configuration["emailAccount:displayName"];
                    string smtpHost = configuration["emailAccount:smtpHost"];
                    int port = Convert.ToInt32(configuration["emailAccount:port"]);

                    MailAddress fromAddress = new MailAddress(userName, displayName);
                    MailAddress toAddress = new MailAddress(contact.Email);

                    MailMessage message = new MailMessage(fromAddress, toAddress);
                    message.Subject = "Please verify with link...";

                    string token = Crypto.Encrypt($"{contact.Email}-{contact.CreatedTime.AddMinutes(20):yyyyMMddHHmm}-{contact.Id}", securityKey);


                    string requestLink = $"{Request.Scheme}://{Request.Host}/contact-confirm.html?token={token}";

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



                return View();
            }

            return View(contact);
        }

        [HttpGet("/contact-confirm.html")]
        public async Task<IActionResult> ContactConfirm(string token)
        {
            token = token.Replace(" ", "+");
            string securityKey = configuration["securityKey"];
            token =  Crypto.Decrypt(token, securityKey);


            Match match = Regex.Match(token, @"^(?<email>([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?))-(?<date>\d{12})-(?<id>\d+)$");
            if (!match.Success)
            {
                return BadRequest();
            }

            string email = match.Groups["email"].Value;
            string dateString = match.Groups["date"].Value;
            int id = int.Parse(match.Groups["id"].Value);

            if (!DateTime.TryParseExact(dateString, "yyyyMMddHHmm", null, DateTimeStyles.None, out DateTime expiredDate))
            {
                return BadRequest();
            }


            if (expiredDate < DateTime.Now)
            {
                var contact = await db.Contacts.FirstOrDefaultAsync(s => s.Id == id);
                if (contact != null)
                {
                    db.Contacts.Remove(contact);
                    await db.SaveChangesAsync();
                }
                return Ok("Email was not verified in time. Send your request again.");
                
            }
            var foundedContact = await db.Contacts.FirstOrDefaultAsync(s => s.Id == id);

            if (foundedContact == null)
            {
                return BadRequest();
            }

            if (!foundedContact.Email.Equals(email))
            {
                return BadRequest();
            }
            if (foundedContact.EmailConfirmTime != null)
            {
                return Ok("Email is very confirmed!");
            }

            foundedContact.EmailConfirmTime = DateTime.Now;
            await db.SaveChangesAsync();

            return Ok("Email Confirmed");
        }

        public IActionResult About()
        {
           return View();
        }
    }
}
