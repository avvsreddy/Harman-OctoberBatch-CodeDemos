using CoolProductsCatelogService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatelogService.Data
{
    public class ProductsDbContext : DbContext
    {
        // db config
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("");
        }

        // seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Brand = "BrandA", Price = 1200, InStock = true, Country = "USA", Category = "Electronics" },
            new Product { Id = 2, Name = "Smartphone", Brand = "BrandB", Price = 800, InStock = true, Country = "China", Category = "Electronics" },
            new Product { Id = 3, Name = "Headphones", Brand = "BrandC", Price = 150, InStock = true, Country = "Germany", Category = "Accessories" },
            new Product { Id = 4, Name = "Coffee Maker", Brand = "BrandD", Price = 100, InStock = false, Country = "Italy", Category = "Home Appliances" },
            new Product { Id = 5, Name = "Electric Toothbrush", Brand = "BrandE", Price = 60, InStock = true, Country = "Japan", Category = "Personal Care" },
            new Product { Id = 6, Name = "Running Shoes", Brand = "BrandF", Price = 120, InStock = true, Country = "Vietnam", Category = "Footwear" },
            new Product { Id = 7, Name = "Backpack", Brand = "BrandG", Price = 90, InStock = true, Country = "India", Category = "Accessories" },
            new Product { Id = 8, Name = "Wristwatch", Brand = "BrandH", Price = 250, InStock = false, Country = "Switzerland", Category = "Accessories" },
            new Product { Id = 9, Name = "Tablet", Brand = "BrandI", Price = 600, InStock = true, Country = "South Korea", Category = "Electronics" },
            new Product { Id = 10, Name = "Blender", Brand = "BrandJ", Price = 80, InStock = true, Country = "Brazil", Category = "Home Appliances" }
        };


            modelBuilder.Entity<Product>().HasData(products);
        }

        // table mapping
        public DbSet<Product> Products { get; set; }

    }
}
