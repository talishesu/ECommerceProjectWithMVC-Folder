using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public SelectList Brands { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Colors { get; set; }
        public SelectList Sizes { get; set; }
        public List<Specification> Specifications { get; set; }
    }
}
