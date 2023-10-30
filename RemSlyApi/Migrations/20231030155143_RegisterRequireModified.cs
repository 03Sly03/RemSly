using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemSlyApi.Migrations
{
    public partial class RegisterRequireModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 914, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2023, 10, 30, 16, 51, 42, 916, DateTimeKind.Local).AddTicks(7192));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 594, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3406));
        }
    }
}
