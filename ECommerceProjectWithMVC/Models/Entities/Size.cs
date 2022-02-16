using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class Size
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Bos Buraxila Bilmez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Qisa Ad Bos Buraxila Bilmez")]
        public string ShortName { get; set; }


        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
