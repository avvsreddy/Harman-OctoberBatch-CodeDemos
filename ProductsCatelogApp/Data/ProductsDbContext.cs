using Microsoft.EntityFrameworkCore;
using ProductsCatelogApp.Entities;

namespace ProductsCatelogApp.Data
{
    public class ProductsDbContext : DbContext
    {
        //public ProductsDbContext(DbContextOptions options) : base(options)
        //{
        //}

        // Configure the Database



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HarmanOctProductsDb;Integrated Security=True;Trust Server Certificate=True;MultipleActiveResultSets=True").LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information).UseLazyLoadingProxies();
        }



        // Map the entities with tables
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
