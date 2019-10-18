using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcProject.Migrations
{
    public partial class mclaren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "/Images/mclaren.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "/Images/mclaren-570s-spider-design-edition.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/mclaren-570s-spider-design-edition.jpg", "McLaren 570 Spyder" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/mclaren-570s-spider-design-edition.jpg", "McLaren 570 Spyder" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/ram.jpg", "Ram 1500" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/ram.jpg", "Ram 1500" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/mustang.jpg", "Ford Mustang" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/mustang.jpg", "Ford Mustang" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/camero.jpg", "Chevy Camaro" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/camero.jpg", "Chevy Camaro" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/prelude.jpg", "Honda Prelude" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Image", "Title" },
                values: new object[] { "/Images/prelude.jpg", "Honda Prelude" });
        }
    }
}
