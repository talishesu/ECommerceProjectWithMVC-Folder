using ECommerceProjectWithMVC.Models.Entities;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class SpecificationFormModel
    {
        public Specification Specification { get; set; }
        public SelectedSpecification[] SelectedCategories { get; set; }
    }
    public class SelectedSpecification 
    {
        public int Id { get; set; }
        public bool Selected { get; set; }
    }
}
