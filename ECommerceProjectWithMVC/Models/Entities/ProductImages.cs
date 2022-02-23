using System;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class ProductImages
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string ImagePath { get; set; }
        public bool IsMain { get; set; }


        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedTime { get; set; }

    }
}
