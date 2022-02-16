﻿using ECommerceProjectWithMVC.Models.Entities;
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
        public DbSet<Product> Products { get; set; }
    }
}
