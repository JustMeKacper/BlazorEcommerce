using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Who cares about Galaxy", "https://images.photowall.com/products/71364/milky-way-galaxy.jpg?h=699&q=85", 9.99m, "Galaxy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Mjód na moje serce", "https://www.winiary.pl/sites/default/files/styles/product_image_desktop_617_900/public/Winiary%20Majonez%20dekoracyjny%20400ml%203d_0.png?itok=dm9MOq3L", 7.99m, "Mayo" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Najlepszy portal z newsami o world of tanks", "https://rykoszet.info/wp-content/uploads/2022/02/MYhGBv2.png", 1113.99m, "Rykoszet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
