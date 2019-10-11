using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcProject.Migrations
{
    public partial class ReviewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ID", "Content", "Rating", "UserName" },
                values: new object[,]
                {
                    { 1, "This Car Is Super Fast", 5, "SpyderMan" },
                    { 2, "Guts, Glory, Ram", 3, "Truck Fan" },
                    { 3, "Unparralled Performace", 4, "Horse Breeder" },
                    { 4, "This car puts the thrill in every ride", 4, "Bumblebee" },
                    { 5, "Sporty Coupe!", 3, "Father Time" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
