using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        [Required(ErrorMessage = "Stok Keeping Unit Bos Buraxila Bilmez")]
        public string SKU { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }


        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<ProductComment> Comments { get; set; }
        public virtual ICollection<ProductImages> Images { get; set; }
        public virtual ICollection<SpecificationProductItem> SpecificationItems { get; set; }
        public virtual ICollection<ProductPricing> PriceList { get; set; }


        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedTime { get; set; }
        [NotMapped]
        public ImageItem[] Files { get; set; }
    }
}
