using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemSlyApi.Migrations
{
    public partial class DataSeedClubImagesModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/Images/Club/Abbeville.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Images/Club/Argentan.webp");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Images/Club/Belgique.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/Images/Club/Bessines.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/Images/Club/Bruay.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/Images/Club/Cambrai.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/Images/Club/Courcelles.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/Images/Club/Dax.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/Images/Club/Jodoigne.jpeg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/Images/Club/Pau.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/Images/Club/Vesoul.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/club/Abbeville.jpg");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "\"/images/club/Argentan.webp\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "\"/images/club/Belgique.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "\"/images/club/Bessines.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "\"/images/club/Bruay.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "\"/images/club/Cambrai.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "\"/images/club/Courcelles.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "\"/images/club/Dax.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "\"/images/club/Jodigne.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "\"/images/club/Pau.jpg\"");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "\"/images/club/Vesoul.jpg\"");
        }
    }
}
