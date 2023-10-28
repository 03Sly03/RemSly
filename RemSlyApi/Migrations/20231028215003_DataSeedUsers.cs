using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemSlyApi.Migrations
{
    public partial class DataSeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_User_UserId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentaries_User_UserId",
                table: "Commentaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_User_UserId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "AvatarUrl", "Email", "FirstName", "Gender", "IsAdmin", "LastName", "PassWord", "PhoneNumber", "PostalCode" },
                values: new object[,]
                {
                    { 1, "7 rue de la Paix, 59000 Lille", "/images/avatar/Christophe.jpg", "christophe@gmail.com", "Christophe", 0, true, "Chauveau", "christophe123", "0607019001", "59000" },
                    { 2, "41 rue de Calais, 59130 Lambersart", "/images/avatar/Anthony.jpg", "anthony@gmail.com", "Anthony", 0, false, "Boisselet", "anthony123", "0647911071", "59130" },
                    { 3, "33 rue des Fleurs, 59650 Villeneuve d'Ascq", "/images/avatar/Thomas.jpg", "thomas@gmail.com", "Thomas", 0, false, "Lavaud", "thomas123", "0741810974", "59650" },
                    { 4, "9 rue des plantes, 59200 Tourcoing", "/images/trainer/LauraTrainer.png", "laura@gmail.com", "Laura", 1, false, "Delcroix", "laura123", "0644810904", "59200" },
                    { 5, "14 avenue de Dunkerque, 59160 Lille", "/images/trainer/AmelieTrainer.jpg", "amelie@gmail.com", "Amelie", 1, false, "Duchemin", "amelie123", "0709749425", "59160" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Users_UserId",
                table: "Clubs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaries_Users_UserId",
                table: "Commentaries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Users_UserId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentaries_Users_UserId",
                table: "Commentaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Users_UserId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_User_UserId",
                table: "Clubs",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaries_User_UserId",
                table: "Commentaries",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_User_UserId",
                table: "Sessions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
