using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcProject.Migrations
{
    public partial class MultipleReviewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 1,
                column: "ProductID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Content", "ProductID", "Rating", "UserName" },
                values: new object[] { "Very Expensive", 1, 1, "Janitor" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Content", "ProductID", "Rating", "UserName" },
                values: new object[] { "Guts, Glory, Ram", 2, 3, "Truck Fan" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Content", "ProductID", "Rating", "UserName" },
                values: new object[] { "It's a good truck. Good gas mileage.", 2, 3, "Tater.Mpeg" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Content", "ProductID", "Rating", "UserName" },
                values: new object[] { "Unparralled Performace", 3, 4, "Horse Breeder" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "Content", "ProductID", "Rating", "UserName" },
                values: new object[,]
                {
                    { 6, "Doesn't fit taller people.", 3, 2, "Too Tall For Life" },
                    { 7, "This car puts the thrill in every ride", 4, 4, "Bumblebee" },
                    { 8, "This car has transformed my life.", 4, 5, "Optimus Prime" },
                    { 9, "Sporty Coupe!", 5, 3, "Father Time" },
                    { 10, "This was my first car. It brings back memories.", 5, 5, "Nostalgia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductID",
                table: "Reviews",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductID",
                table: "Reviews",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ProductID",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Content", "Rating", "UserName" },
                values: new object[] { "Guts, Glory, Ram", 3, "Truck Fan" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Content", "Rating", "UserName" },
                values: new object[] { "Unparralled Performace", 4, "Horse Breeder" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Content", "Rating", "UserName" },
                values: new object[] { "This car puts the thrill in every ride", 4, "Bumblebee" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Content", "Rating", "UserName" },
                values: new object[] { "Sporty Coupe!", 3, "Father Time" });
        }
    }
}
