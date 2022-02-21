using ECommerceProjectWithMVC.Models.Entities;

namespace ECommerceProjectWithMVC.Models.FormModels
{
    public class SpecificationFormModel
    {
        public Specification Specification { get; set; }
        public SelectedCategory[] SelectedCategories { get; set; }
    }
    public class SelectedCategory
    {
        public int Id { get; set; }
        public bool Selected { get; set; }
    }
}
