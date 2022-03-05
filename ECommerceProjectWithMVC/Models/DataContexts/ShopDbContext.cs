using ECommerceProjectWithMVC.Models.Entities;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProjectWithMVC.Models.DataContexts
{
    public class ShopDbContext : IdentityDbContext<ShopUser,ShopRole,int,ShopUserClaim,ShopUserRole,ShopUserLogin,ShopRoleClaim,ShopUserToken>
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
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<SpecificationProductItem> SpecificationProductItems { get; set; }
        public DbSet<ProductPricing> ProductPricings { get; set; }


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

            modelBuilder.Entity<ProductPricing>(e =>
            {
                e.HasKey(k => new { k.SizeId, k.ProductId,k.ColorId });
            });

            #region Membership


            modelBuilder.Entity<ShopUser>(e =>
            {
                e.ToTable("Users", "Membership");
            });


            modelBuilder.Entity<ShopRole>(e =>
            {
                e.ToTable("Roles", "Membership");
            });


            modelBuilder.Entity<ShopUserClaim>(e =>
            {
                e.ToTable("UserClaims", "Membership");
            });


            modelBuilder.Entity<ShopUserToken>(e =>
            {
                e.ToTable("UserTokens", "Membership");
            });


            modelBuilder.Entity<ShopUserLogin>(e =>
            {
                e.ToTable("UserLogins", "Membership");
            });


            modelBuilder.Entity<ShopRoleClaim>(e =>
            {
                e.ToTable("RoleClaims", "Membership");
            });


            modelBuilder.Entity<ShopUserRole>(e =>
            {
                e.ToTable("UserRoles", "Membership");
            });


            #endregion
        }
    }
}
