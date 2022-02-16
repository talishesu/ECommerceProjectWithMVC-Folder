using Microsoft.AspNetCore.Mvc;

namespace ECommerceProjectWithMVC.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
