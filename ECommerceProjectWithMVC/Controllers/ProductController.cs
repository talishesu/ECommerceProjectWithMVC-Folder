using Microsoft.AspNetCore.Mvc;

namespace ECommerceProjectWithMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
