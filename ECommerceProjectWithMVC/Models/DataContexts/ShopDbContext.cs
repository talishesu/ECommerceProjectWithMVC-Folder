using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProjectWithMVC.Models.DataContexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<SpecificationCategoryItem> SpecificationCategoryItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SpecificationProductItem> SpecificationProductItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SpecificationCategoryItem>(e =>
            {
                e.HasKey(k => new { k.SpecificationId, k.CategoryId });
            });







            modelBuilder.Entity<SpecificationProductItem>(e =>
            {
                e.HasKey(k => new { k.SpecificationId, k.ProductId });
            });
        }
    }
}
