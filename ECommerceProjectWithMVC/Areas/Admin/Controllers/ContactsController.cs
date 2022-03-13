using ECommerceProjectWithMVC.AppCode.Extensions;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactsController : Controller
    {
        readonly ShopDbContext db;
        readonly IConfiguration configuration;
        public ContactsController(ShopDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }
        [Authorize(Policy = "admin.contacts.index")]
        public async Task<IActionResult> Index()
        {
            var contacts = await db.Contacts.Where(c => c.EmailConfirmTime != null).ToListAsync();
            return View(contacts);
        }
        [Authorize(Policy = "admin.contacts.answer")]
        public async Task<IActionResult> Answer(int id)
        {
            var contact = await db.Contacts.FirstOrDefaultAsync(c => c.EmailConfirmTime != null && c.Answered == false &&c.Id == id);
            if(contact == null)
            {
                return NotFound();
            }


            return View(contact);
        }



        [Authorize(Policy = "admin.contacts.answer")]
        [HttpPost]
        public async Task<IActionResult> Answer(int id,Contact contact)
        {
            var contact2 = await db.Contacts.FirstOrDefaultAsync(c => c.EmailConfirmTime != null && c.Answered == false && c.Id == contact.Id);
            contact2.AnswerMessage = contact.AnswerMessage;
            if(contact2.AnswerMessage == null)
            {
                ModelState.AddModelError("AnswerMessage", "Please Write Answer Message!");
                return View(contact2);
            }

            if (id != contact2.Id || id < 1)
            {
                return BadRequest();
            }








            string userName = configuration["emailAccount:userName"];
            string password = configuration["emailAccount:password"];
            string displayName = configuration["emailAccount:displayName"];
            string smtpHost = configuration["emailAccount:smtpHost"];
            int port = Convert.ToInt32(configuration["emailAccount:port"]);

            MailAddress fromAddress = new MailAddress(userName, displayName);
            MailAddress toAddress = new MailAddress(contact2.Email);

            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = "Shop Support Team";



            

            message.Body = $"{contact2.AnswerMessage}";
            message.IsBodyHtml = true;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(userName, password);
            smtpClient.EnableSsl = true;
            smtpClient.Host = smtpHost;
            smtpClient.Port = port;

            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


            smtpClient.Send(message);

            contact2.AnswerTime = DateTime.Now;
            contact2.AnsweredByUserId = User.GetPrincipalId();
            contact2.Answered = true;
            await db.SaveChangesAsync();





            return RedirectToAction("Index");
        }


        [Authorize(Policy = "admin.contacts.detail")]
        public async Task<IActionResult> Detail(int id)
        {
            var contact = await db.Contacts.FirstOrDefaultAsync(c => c.EmailConfirmTime != null && c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }


            return View(contact);
        }
    }
}
