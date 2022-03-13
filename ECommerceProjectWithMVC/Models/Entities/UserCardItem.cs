using ECommerceProjectWithMVC.Models.Entities.Membership;

namespace ECommerceProjectWithMVC.Models.Entities
{
    public class UserCardItem
    {
        public int UserId { get; set; }
        public virtual ShopUser User { get; set; }
        public int ProductPricingId { get; set; }
        public virtual ProductPricing ProductPricing { get; set; }

        public int Count { get; set; }
    }
}
