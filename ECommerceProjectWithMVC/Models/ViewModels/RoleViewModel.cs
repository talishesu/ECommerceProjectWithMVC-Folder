using ECommerceProjectWithMVC.Models.Entities.Membership;
using System;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class RoleViewModel
    {
        public ShopRole Role { get; set; }
        public List<Tuple<string, bool>> Claims { get; set; }
    }
}
