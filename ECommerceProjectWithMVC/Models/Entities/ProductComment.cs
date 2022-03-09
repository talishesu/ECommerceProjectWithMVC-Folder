using System;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class ProductComment
    {
        public int Id { get; set; }

        public string Comment { get; set; }
        public bool Confirmed { get; set; } = false;
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
