using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemSlyApi.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLadiesOnly = table.Column<bool>(type: "bit", nullable: false),
                    Is24h = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClubMaterial",
                columns: table => new
                {
                    ClubsId = table.Column<int>(type: "int", nullable: false),
                    MaterialsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMaterial", x => new { x.ClubsId, x.MaterialsId });
                    table.ForeignKey(
                        name: "FK_ClubMaterial_Clubs_ClubsId",
                        column: x => x.ClubsId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubMaterial_Materials_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedules = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacityMax = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sessions_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Commentaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commentaries_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commentaries_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Address", "Description", "Email", "ImageUrl", "Is24h", "IsLadiesOnly", "Name", "OpeningHours", "PhoneNumber", "PostalCode", "UserId" },
                values: new object[,]
                {
                    { 1, "43 Bd de Valmy, 59650 Villeneuve-d'Ascq", "Bienvenu chez Sunstar! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.", "Sunstar@club.com", "/images/club/Abbeville.jpg", false, false, "Sunstar Club", "10h00 - 20h00", "0366333344", "59650", null },
                    { 2, "292 Rue des Fusillés, 59493 Villeneuve-d'Ascq", "Bienvenu chez Cortex! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.", "Cortex@club.com", "\"/images/club/Argentan.webp\"", false, false, "Cortex Club", "09h00 - 21h00", "0320597941", "59493", null },
                    { 3, "5 Pl. Pierre de Coubertin, 59790 Ronchin", "Bienvenu chez Cabana ! Adonnez-vous à votre activité sportive favorite chez Cabana Ladies et retrouvez la forme, sur nos appareils de fitness ou en suivant des cours collectifs.", "zumba@hotmail.com", "\"/images/club/Belgique.jpg\"", false, true, "Cabana Club", "08h00 - 22h00", "0359613012", "59790", null },
                    { 4, "124 Rue de Douai, 59000 Lille", "Bienvenu chez Kinetic ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.", "Kinetic@outlook.com", "\"/images/club/Bessines.jpg\"", false, false, "Kinetic Club", "09h30 - 21h00", "0320597941", "59000", null },
                    { 5, "20 Rue des Meuniers, 59810 Lesquin", "Bienvenu chez Optimum 24/7 ! Besoin de vous entrainer à toute heure, nous disposons de la solution d'entraînement qui répond à vos besoins : Notre club vous accueille 24h/24h !", "Optimum@yahoo.com", "\"/images/club/Bruay.jpg\"", true, false, "Optimum Club", "00h00 - 24h00", "0771630955", "59810", null },
                    { 6, "202 Rue Solférino, 59000 Lille", "Bienvenu chez Magellan ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.", "Magellan@gmail.com", "\"/images/club/Cambrai.jpg\"", false, false, "Magellan Club", "06h00 - 23h00", "0967583899", "59000", null },
                    { 7, "4 Rue Professeur Langevin, 59000 Lille", "Bienvenu chez Pixel ! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.", "Pixel@gmail.com", "\"/images/club/Courcelles.jpg\"", false, false, "Pixel Club", "07h00 - 22h00", "0320309838", "59000", null },
                    { 8, "3 bis Rue Edouard Delesalle, 59000 Lille", "Bienvenu chez Axion ! Quels que soient votre âge, votre niveau de pratique ou l'heure, nous serons à vos côtés pour répondre à vos besoins spécifiques.", "Axion@gmail.com", "\"/images/club/Dax.jpg\"", true, false, "Axion Club", "06h00 - 23h00", "0320550808", "59000", null },
                    { 9, "124 Rue de Douai, 59000 Lille", "Bienvenu chez Panda ! Notre club dédié au femme est là pour vous accompagner dans votre remise en forme en proposant de nombreux cours collectifs.", "Panda@gmail.com", "\"/images/club/Jodigne.jpg\"", false, true, "Panda Club", "09h30 - 21h00", "0320597941", "59000", null },
                    { 10, "124 Rue de Douai, 59000 Lille", "Bienvenu chez Vita ! Notre club vous accompagnes 24h/24 tous les jours de la semaine, dans vos besoins sportifs pour être plein de vitalité !", "Vita@gmail.com", "\"/images/club/Pau.jpg\"", true, false, "Vita Club", "00h00 - 24h00", "0320597941", "59000", null },
                    { 11, "62 Rue d'Iéna, 59000 Lille", "Bienvenu chez Luminous Club ! Venez découvrir le sport autrement dans notre salle sur les toits de la ville", "Luminous@gmail.com", "\"/images/club/Vesoul.jpg\"", false, false, "Luminous Club", "10h00 - 17h00", "0362859280", "59000", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubMaterial_MaterialsId",
                table: "ClubMaterial",
                column: "MaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_UserId",
                table: "Clubs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaries_SessionId",
                table: "Commentaries",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaries_UserId",
                table: "Commentaries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_ClubId",
                table: "Sessions",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubMaterial");

            migrationBuilder.DropTable(
                name: "Commentaries");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
