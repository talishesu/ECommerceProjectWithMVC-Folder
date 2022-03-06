using ECommerceProjectWithMVC.Models.Entities.Membership;
using System;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class UserViewModel
    {
        public ShopUser User { get; set; }
        public List<Tuple<ShopRole, bool>> Roles { get; set; }
        public List<Tuple<string, bool>> Claims { get; set; }
    }
}
