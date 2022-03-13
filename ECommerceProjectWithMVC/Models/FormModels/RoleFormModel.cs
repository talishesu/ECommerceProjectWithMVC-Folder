using ECommerceProjectWithMVC.Models.Entities.Membership;
using System;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class RoleFormModel
    {
        public ShopRole Role { get; set; }
        public SelectedClaim[] SelectedClaims { get; set; }
    }
}
