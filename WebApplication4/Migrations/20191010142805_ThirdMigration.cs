using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcProject.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "Content", "Image", "Make", "Manufacturer", "Model", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Sports Car", null, null, "McLaren", "McLaren Automotives", "570 Spyder", "MycLaren 570 Spyder", "2015 - Present" },
                    { 2, "Pick Up Truck", null, null, "Ram", "Fiat Chrysler Automobiles", "1500", "Ram 1500", "1981 - Present" },
                    { 3, "Sports Car", null, null, "Ford", "Ford Motor Company", "Mustang", "Ford Mustang", "1964 - Present" },
                    { 4, " Muscle Car", null, null, "Chevrolet", "General Motors", "Camaro", "Chevy Camaro", "1966 - Present" },
                    { 5, "90's Ricer Dream", null, null, "Honda", "Honda Motor Company Ltd.", "Prelude", "Honda Prelude", "1978 - 2001" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
