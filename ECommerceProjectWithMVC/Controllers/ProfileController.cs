using Microsoft.AspNetCore.Mvc;

namespace ECommerceProjectWithMVC.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
