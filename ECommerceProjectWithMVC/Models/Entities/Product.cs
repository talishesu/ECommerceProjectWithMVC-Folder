using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Bos Buraxila Bilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Desc Bos Buraxila Bilmez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Short Desc Bos Buraxila Bilmez")]
        public string ShortDescription { get; set; }


        [Required(ErrorMessage = "SKU Bos Buraxila Bilmez")]
        public int SKU { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }




        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
