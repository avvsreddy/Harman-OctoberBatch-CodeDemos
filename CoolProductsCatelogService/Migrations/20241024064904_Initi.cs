using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoolProductsCatelogService.Migrations
{
    /// <inheritdoc />
    public partial class Initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "Country", "InStock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "BrandA", "Electronics", "USA", true, "Laptop", 1200 },
                    { 2, "BrandB", "Electronics", "China", true, "Smartphone", 800 },
                    { 3, "BrandC", "Accessories", "Germany", true, "Headphones", 150 },
                    { 4, "BrandD", "Home Appliances", "Italy", false, "Coffee Maker", 100 },
                    { 5, "BrandE", "Personal Care", "Japan", true, "Electric Toothbrush", 60 },
                    { 6, "BrandF", "Footwear", "Vietnam", true, "Running Shoes", 120 },
                    { 7, "BrandG", "Accessories", "India", true, "Backpack", 90 },
                    { 8, "BrandH", "Accessories", "Switzerland", false, "Wristwatch", 250 },
                    { 9, "BrandI", "Electronics", "South Korea", true, "Tablet", 600 },
                    { 10, "BrandJ", "Home Appliances", "Brazil", true, "Blender", 80 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
