using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.Entities.Membership
{
    public class ShopUser:IdentityUser<int>
    {
        [Required]
        public  string  Name { get; set; }
        [Required]
        public  string  Surname { get; set; }
    }
}
