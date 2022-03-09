﻿using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class SignupFormModel
    {
        [Required]
        public string Name { get; set; }


        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
