using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class ProductCreateViewModel
    {
        public Product Product { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Colors { get; set; }
        public SelectList Sizes { get; set; }
        public List<ProductPricing> ProductPricings { get; set; }
        public List<Color> AllColors { get; set; }
        public List<Size> AllSizes { get; set; }
        public List<Specification> Specifications { get; set; }
        public List<SpecificationProductItem> SpecificationProductItems { get; set; }
        public List<ProductImages> ProductImages { get; set; }
    }
}
