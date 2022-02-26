using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class Color
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Bos Buraxila Bilmez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Hex Code Bos Buraxila Bilmez")]
        [RegularExpression("^#?([0-9a-f]{3}){1,2}$", ErrorMessage = ("Reng Hex Code Formatinda Olmalidir"))]
        public string ColorHexCode { get; set; }


        public virtual ICollection<ProductPricing> PriceList { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
