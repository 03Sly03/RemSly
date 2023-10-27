using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemSlyApi.Migrations
{
    public partial class UpdatedDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "CapacityMax", "ClubId", "ImageUrl", "IsComplete", "Name", "Schedules", "Score", "UserId" },
                values: new object[,]
                {
                    { 1, 10, 1, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 2, 20, 1, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 3, 2, 1, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 5, 10, 2, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 6, 20, 2, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 7, 2, 2, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
