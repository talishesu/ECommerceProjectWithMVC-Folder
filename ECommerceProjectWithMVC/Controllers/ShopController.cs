using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProjectWithMVC.Controllers
{
    [AllowAnonymous]
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
