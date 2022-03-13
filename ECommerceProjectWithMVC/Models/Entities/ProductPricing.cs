using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class ProductPricing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }




        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


        public int ColorId { get; set; }
        public virtual Color Color { get; set; }


        public int SizeId { get; set; }
        public virtual Size Size { get; set; }


        public double Price { get; set; }








        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
