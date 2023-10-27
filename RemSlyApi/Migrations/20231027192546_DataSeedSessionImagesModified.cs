using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemSlyApi.Migrations
{
    public partial class DataSeedSessionImagesModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/Images/Session/GroupClasses.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Images/Session/GroupClasses.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Images/Session/PersonalTrainer.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/session/GroupClasses.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/session/GroupClasses.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/session/PersonalTrainer.jpeg");
        }
    }
}
