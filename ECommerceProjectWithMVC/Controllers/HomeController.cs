using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ECommerceProjectWithMVC.Controllers
{
    public class HomeController : Controller
    {
        readonly ShopDbContext db;
        public HomeController(ShopDbContext db)
        {
            this.db = db;
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
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();

                ModelState.Clear();

                ViewBag.Message = "Sorgu Gonderildi.";
                return View();
            }
                return View(contact);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
