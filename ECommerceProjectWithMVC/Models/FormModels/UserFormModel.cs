using ECommerceProjectWithMVC.Models.Entities.Membership;
using System;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class UserFormModel
    {
        public ShopUser User { get; set; }
        public SelectedRole[] SelectedRoles { get; set; }
        public SelectedClaim[] SelectedClaims { get; set; }
    }
    public class SelectedRole
    {
        public int Id { get; set; }
        public bool Selected { get; set; }
    }
    public class SelectedClaim
    {
        public string ClaimType { get; set; }
        public bool Selected { get; set; }
    }
}
