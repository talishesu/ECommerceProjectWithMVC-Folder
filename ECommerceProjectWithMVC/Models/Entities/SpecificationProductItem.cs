using System;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class SpecificationProductItem
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int SpecificationId { get; set; }
        public virtual Specification Specification { get; set; }

        public string Value { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedTime { get; set; }

    }
}
