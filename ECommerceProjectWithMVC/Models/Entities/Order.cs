using ECommerceProjectWithMVC.Models.Entities.Membership;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }




        public int UserId { get; set; }
        public virtual ShopUser User { get; set; }


        public int ProductPricingId { get; set; }
        public virtual ProductPricing ProductPricing { get; set; }



        public string OrderAction { get; set; }


        public int Count { get; set; }


        public int? CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int? LastUpdateByUserId { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
