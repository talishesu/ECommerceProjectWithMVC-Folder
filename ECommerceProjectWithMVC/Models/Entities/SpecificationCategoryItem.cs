using System;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class SpecificationCategoryItem
    {
        public int SpecificationId { get; set; }
        public virtual Specification Specification { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        //public int? CreatedByUserId { get; set; }
        //public DateTime CreatedTime { get; set; } = DateTime.Now;

        //public int? DeletedByUserId { get; set; }
        //public DateTime? DeletedTime { get; set; }

    }
}
