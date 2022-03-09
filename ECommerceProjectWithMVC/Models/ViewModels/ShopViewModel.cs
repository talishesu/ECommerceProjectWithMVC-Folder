using ECommerceProjectWithMVC.Models.Entities;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class ShopViewModel
    {
        public PagedViewModel<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<Brand> Brands { get; set; }
        public List<ProductPricing> ProductPricings { get; set; }
        public int SelectedCategory { get; set; }
        public int SelectedBrand { get; set; }
    }
}
