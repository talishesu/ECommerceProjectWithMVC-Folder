using ECommerceProjectWithMVC.Models.Entities;
using System.Collections.Generic;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class SpecificationCreateViewModel
    {
        public Specification Specification { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
