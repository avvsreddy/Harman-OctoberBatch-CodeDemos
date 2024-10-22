using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCatelogApp.Migrations
{
    /// <inheritdoc />
    public partial class ProductChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "tbl_products");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "tbl_products",
                newName: "rate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_products",
                table: "tbl_products",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_products",
                table: "tbl_products");

            migrationBuilder.RenameTable(
                name: "tbl_products",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "rate",
                table: "Products",
                newName: "Price");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");
        }
    }
}
