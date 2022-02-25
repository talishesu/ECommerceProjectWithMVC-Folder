using ECommerceProjectWithMVC.Models.Entities;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class ProductFormModel
    {
        public Product Product { get; set; }
        public SelectedSpecification[] SelectedSpecifications { get; set; }
    }
    public class SelectedSpecification
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
