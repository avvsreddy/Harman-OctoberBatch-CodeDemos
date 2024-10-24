﻿// <auto-generated />
using CoolProductsCatelogService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoolProductsCatelogService.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    [Migration("20241024064904_Initi")]
    partial class Initi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoolProductsCatelogService.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "BrandA",
                            Category = "Electronics",
                            Country = "USA",
                            InStock = true,
                            Name = "Laptop",
                            Price = 1200
                        },
                        new
                        {
                            Id = 2,
                            Brand = "BrandB",
                            Category = "Electronics",
                            Country = "China",
                            InStock = true,
                            Name = "Smartphone",
                            Price = 800
                        },
                        new
                        {
                            Id = 3,
                            Brand = "BrandC",
                            Category = "Accessories",
                            Country = "Germany",
                            InStock = true,
                            Name = "Headphones",
                            Price = 150
                        },
                        new
                        {
                            Id = 4,
                            Brand = "BrandD",
                            Category = "Home Appliances",
                            Country = "Italy",
                            InStock = false,
                            Name = "Coffee Maker",
                            Price = 100
                        },
                        new
                        {
                            Id = 5,
                            Brand = "BrandE",
                            Category = "Personal Care",
                            Country = "Japan",
                            InStock = true,
                            Name = "Electric Toothbrush",
                            Price = 60
                        },
                        new
                        {
                            Id = 6,
                            Brand = "BrandF",
                            Category = "Footwear",
                            Country = "Vietnam",
                            InStock = true,
                            Name = "Running Shoes",
                            Price = 120
                        },
                        new
                        {
                            Id = 7,
                            Brand = "BrandG",
                            Category = "Accessories",
                            Country = "India",
                            InStock = true,
                            Name = "Backpack",
                            Price = 90
                        },
                        new
                        {
                            Id = 8,
                            Brand = "BrandH",
                            Category = "Accessories",
                            Country = "Switzerland",
                            InStock = false,
                            Name = "Wristwatch",
                            Price = 250
                        },
                        new
                        {
                            Id = 9,
                            Brand = "BrandI",
                            Category = "Electronics",
                            Country = "South Korea",
                            InStock = true,
                            Name = "Tablet",
                            Price = 600
                        },
                        new
                        {
                            Id = 10,
                            Brand = "BrandJ",
                            Category = "Home Appliances",
                            Country = "Brazil",
                            InStock = true,
                            Name = "Blender",
                            Price = 80
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
