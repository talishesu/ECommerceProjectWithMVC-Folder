using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class SigninFormModel
    {
        [Required]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
