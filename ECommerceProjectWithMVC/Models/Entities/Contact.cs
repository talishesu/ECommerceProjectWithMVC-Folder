using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad Bos Buraxila Bilmez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Bos Buraxila Bilmez")]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime? EmailConfirmTime { get; set; }

        [Required(ErrorMessage = "Serh Bos Buraxila Bilmez")]
        public string Message { get; set; }
        public DateTime CreatedTime { get; set; }= DateTime.Now;
        public bool Answered { get; set; } = false;
        public string AnswerMessage { get; set; }
        public DateTime? AnswerTime { get; set; }
        public int? AnsweredByUserId { get; set; }
    }
}
