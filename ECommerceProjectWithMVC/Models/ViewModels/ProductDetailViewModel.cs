using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public List<ProductImages> ProductImages { get; set; }
        public List<Specification> Specifications { get; set; }
        public List<SpecificationProductItem> SpecificationProductItems { get; set; }
        public List<Color> AllColors { get; set; }
        public List<Size> AllSizes { get; set; }
        public List<ProductPricing> ProductPricings { get; set; }
    }
}
