using KnowledgeHubPortal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortal.Data
{
    public class KBPDbContext : DbContext
    {
        // configure the db



        // configure the tables
        public KBPDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // db config
                optionsBuilder.UseSqlServer("");
            }
        }

        public override int SaveChanges()
        {
            // validations : use ValidationContext class = TODO
            // if invalid thow exp
            // else save changes
            return base.SaveChanges();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent API for validation

            // data seeding

            List<Category> categories = new List<Category>()
            {
                new Category{CategoryID=1,Name=".Net Core", Description=".Net Core Articles", DateCreated=DateTime.Now },
                 new Category{CategoryID=1,Name="Education", Description=".Net Core Articles", DateCreated=DateTime.Now },
                  new Category{CategoryID=1,Name="AI Technology", Description=".Net Core Articles", DateCreated=DateTime.Now },
                   new Category{CategoryID=1,Name="Sports", Description=".Net Core Articles", DateCreated=DateTime.Now },

            };

            modelBuilder.Entity<Category>().HasData(categories);

            base.OnModelCreating(modelBuilder);
        }

        // configure tables

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
