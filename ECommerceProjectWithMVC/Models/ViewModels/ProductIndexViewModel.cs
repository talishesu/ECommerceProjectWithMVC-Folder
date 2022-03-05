using ECommerceProjectWithMVC.Models.Entities;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class ProductIndexViewModel
    {
        public Product Product { get; set; }
        public List<ProductImages> ProductImages { get; set; }
        public List<Specification> Specifications { get; set; }
        public List<SpecificationProductItem> SpecificationProductItems { get; set; }
        public List<ProductPricing> ProductPricings { get; set; }
    }
}
