using Microsoft.AspNetCore.Identity;

namespace ECommerceProjectWithMVC.Models.Entities.Membership
{
    public class ShopUser:IdentityUser<int>
    {
        public  string  Name { get; set; }
        public  string  Surname { get; set; }
    }
}
