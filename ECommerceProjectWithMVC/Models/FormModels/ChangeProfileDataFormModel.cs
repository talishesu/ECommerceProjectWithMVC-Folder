using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class ChangeProfileDataFormModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }


        [Required]
        public string Password { get; set; }
    }
}
