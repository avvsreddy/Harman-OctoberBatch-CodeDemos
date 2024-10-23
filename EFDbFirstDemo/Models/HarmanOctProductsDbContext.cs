using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDbFirstDemo.Models;

public partial class HarmanOctProductsDbContext : DbContext
{
    public HarmanOctProductsDbContext()
    {
    }

    public HarmanOctProductsDbContext(DbContextOptions<HarmanOctProductsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HarmanOctProductsDb;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.PersonId);

            entity.Property(e => e.PersonId)
                .HasDefaultValueSql("(NEXT VALUE FOR [PersonSequence])")
                .HasColumnName("PersonID");
            entity.Property(e => e.AddressArea)
                .HasDefaultValue("")
                .HasColumnName("Address_Area");
            entity.Property(e => e.AddressCity)
                .HasDefaultValue("")
                .HasColumnName("Address_City");
            entity.Property(e => e.AddressLocation)
                .HasDefaultValue("")
                .HasColumnName("Address_Location");
            entity.Property(e => e.AddressPincode)
                .HasDefaultValue("")
                .HasColumnName("Address_Pincode");
            entity.Property(e => e.EmailId).HasDefaultValue("");
            entity.Property(e => e.Mobile).HasDefaultValue("");
            entity.Property(e => e.Name).HasDefaultValue("");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryID");

            entity.Property(e => e.Brand).HasDefaultValue("");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);

            entity.HasMany(d => d.SuppliersPeople).WithMany(p => p.ProductsProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductSupplier",
                    r => r.HasOne<Supplier>().WithMany().HasForeignKey("SuppliersPersonId"),
                    l => l.HasOne<Product>().WithMany().HasForeignKey("ProductsProductId"),
                    j =>
                    {
                        j.HasKey("ProductsProductId", "SuppliersPersonId");
                        j.ToTable("ProductSupplier");
                        j.HasIndex(new[] { "SuppliersPersonId" }, "IX_ProductSupplier_SuppliersPersonID");
                        j.IndexerProperty<int>("SuppliersPersonId").HasColumnName("SuppliersPersonID");
                    });
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.PersonId);

            entity.Property(e => e.PersonId)
                .HasDefaultValueSql("(NEXT VALUE FOR [PersonSequence])")
                .HasColumnName("PersonID");
            entity.Property(e => e.AddressArea)
                .HasDefaultValue("")
                .HasColumnName("Address_Area");
            entity.Property(e => e.AddressCity)
                .HasDefaultValue("")
                .HasColumnName("Address_City");
            entity.Property(e => e.AddressLocation)
                .HasDefaultValue("")
                .HasColumnName("Address_Location");
            entity.Property(e => e.AddressPincode)
                .HasDefaultValue("")
                .HasColumnName("Address_Pincode");
            entity.Property(e => e.EmailId).HasDefaultValue("");
            entity.Property(e => e.Gst).HasColumnName("GST");
            entity.Property(e => e.Mobile).HasDefaultValue("");
            entity.Property(e => e.Name).HasDefaultValue("");
        });
        modelBuilder.HasSequence("PersonSequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
