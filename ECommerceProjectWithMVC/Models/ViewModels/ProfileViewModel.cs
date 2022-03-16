using ECommerceProjectWithMVC.Models.Entities;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class ProfileViewModel
    {
        public ShopUser User { get; set; }
        public List<ProductComment> Comments { get; set; }
        public List<Order> Orders { get; set; }
    }
}
