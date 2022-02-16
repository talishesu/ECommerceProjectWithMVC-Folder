using Microsoft.AspNetCore.Mvc;

namespace ECommerceProjectWithMVC.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
