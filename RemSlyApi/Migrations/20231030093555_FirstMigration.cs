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
                name: "Users",
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
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                        name: "FK_Clubs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                        name: "FK_Sessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                        name: "FK_Commentaries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Address", "Description", "Email", "ImageUrl", "Is24h", "IsLadiesOnly", "Name", "OpeningHours", "PhoneNumber", "PostalCode", "UserId" },
                values: new object[,]
                {
                    { 1, "43 Bd de Valmy, 59650 Villeneuve-d'Ascq", "Bienvenu chez Sunstar! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.", "Sunstar@club.com", "/Images/Club/Abbeville.jpg", false, false, "Sunstar Club", "10h00 - 20h00", "0366333344", "59650", null },
                    { 2, "292 Rue des Fusillés, 59493 Villeneuve-d'Ascq", "Bienvenu chez Cortex! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.", "Cortex@club.com", "/Images/Club/Argentan.webp", false, false, "Cortex Club", "09h00 - 21h00", "0320597941", "59493", null },
                    { 3, "5 Pl. Pierre de Coubertin, 59790 Ronchin", "Bienvenu chez Cabana ! Adonnez-vous à votre activité sportive favorite chez Cabana Ladies et retrouvez la forme, sur nos appareils de fitness ou en suivant des cours collectifs.", "zumba@hotmail.com", "/Images/Club/Belgique.jpg", false, true, "Cabana Club", "08h00 - 22h00", "0359613012", "59790", null },
                    { 4, "124 Rue de Douai, 59000 Lille", "Bienvenu chez Kinetic ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.", "Kinetic@outlook.com", "/Images/Club/Bessines.jpg", false, false, "Kinetic Club", "09h30 - 21h00", "0320597941", "59000", null },
                    { 5, "20 Rue des Meuniers, 59810 Lesquin", "Bienvenu chez Optimum 24/7 ! Besoin de vous entrainer à toute heure, nous disposons de la solution d'entraînement qui répond à vos besoins : Notre club vous accueille 24h/24h !", "Optimum@yahoo.com", "/Images/Club/Bruay.jpg", true, false, "Optimum Club", "00h00 - 24h00", "0771630955", "59810", null },
                    { 6, "202 Rue Solférino, 59000 Lille", "Bienvenu chez Magellan ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.", "Magellan@gmail.com", "/Images/Club/Cambrai.jpg", false, false, "Magellan Club", "06h00 - 23h00", "0967583899", "59000", null },
                    { 7, "4 Rue Professeur Langevin, 59000 Lille", "Bienvenu chez Pixel ! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.", "Pixel@gmail.com", "/Images/Club/Courcelles.jpg", false, false, "Pixel Club", "07h00 - 22h00", "0320309838", "59000", null },
                    { 8, "3 bis Rue Edouard Delesalle, 59000 Lille", "Bienvenu chez Axion ! Quels que soient votre âge, votre niveau de pratique ou l'heure, nous serons à vos côtés pour répondre à vos besoins spécifiques.", "Axion@gmail.com", "/Images/Club/Dax.jpg", true, false, "Axion Club", "06h00 - 23h00", "0320550808", "59000", null },
                    { 9, "124 Rue de Douai, 59000 Lille", "Bienvenu chez Panda ! Notre club dédié au femme est là pour vous accompagner dans votre remise en forme en proposant de nombreux cours collectifs.", "Panda@gmail.com", "/Images/Club/Jodoigne.jpeg", false, true, "Panda Club", "09h30 - 21h00", "0320597941", "59000", null },
                    { 10, "124 Rue de Douai, 59000 Lille", "Bienvenu chez Vita ! Notre club vous accompagnes 24h/24 tous les jours de la semaine, dans vos besoins sportifs pour être plein de vitalité !", "Vita@gmail.com", "/Images/Club/Pau.jpg", true, false, "Vita Club", "00h00 - 24h00", "0320597941", "59000", null },
                    { 11, "62 Rue d'Iéna, 59000 Lille", "Bienvenu chez Luminous Club ! Venez découvrir le sport autrement dans notre salle sur les toits de la ville", "Luminous@gmail.com", "/Images/Club/Vesoul.jpg", false, false, "Luminous Club", "10h00 - 17h00", "0362859280", "59000", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "AvatarUrl", "Email", "FirstName", "Gender", "IsAdmin", "LastName", "PassWord", "PhoneNumber", "PostalCode" },
                values: new object[,]
                {
                    { 1, "7 rue de la Paix, 59000 Lille", "/Images/Avatar/Christophe.jpg", "christophe@gmail.com", "Christophe", 0, true, "Chauveau", "christophe123", "0607019001", "59000" },
                    { 2, "41 rue de Calais, 59130 Lambersart", "/Images/Avatar/Anthony.jpg", "anthony@gmail.com", "Anthony", 0, false, "Boisselet", "anthony123", "0647911071", "59130" },
                    { 3, "33 rue des Fleurs, 59650 Villeneuve d'Ascq", "/Images/Avatar/Thomas.jpg", "thomas@gmail.com", "Thomas", 0, false, "Lavaud", "thomas123", "0741810974", "59650" },
                    { 4, "9 rue des plantes, 59200 Tourcoing", "/Images/Trainer/LauraTrainer.png", "laura@gmail.com", "Laura", 1, false, "Delcroix", "laura123", "0644810904", "59200" },
                    { 5, "14 avenue de Dunkerque, 59160 Lille", "/Images/Trainer/AmelieTrainer.jpg", "amelie@gmail.com", "Amelie", 1, false, "Duchemin", "amelie123", "0709749425", "59160" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "CapacityMax", "ClubId", "ImageUrl", "IsComplete", "Name", "Schedules", "Score", "UserId" },
                values: new object[,]
                {
                    { 1, 10, 1, "/Images/Session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 2, 20, 1, "/Images/Session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 3, 2, 1, "/Images/Session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 4, 10, 2, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 5, 20, 2, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 6, 2, 2, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 7, 10, 3, "/Images/Session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 8, 20, 3, "/Images/Session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 9, 2, 3, "/Images/Session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 10, 10, 4, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 11, 20, 4, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 12, 2, 4, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 13, 10, 5, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 14, 20, 5, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 15, 2, 5, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 16, 10, 6, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 17, 20, 6, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 18, 2, 6, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 19, 10, 7, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 20, 20, 7, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 21, 2, 7, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 22, 10, 8, "/Images/Session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 23, 20, 8, "/Images/Session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 24, 2, 8, "/Images/Session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 25, 10, 9, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 26, 20, 9, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 27, 2, 9, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 28, 10, 10, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 29, 20, 10, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 30, 2, 10, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null },
                    { 31, 10, 11, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Live", "10h00", 4, null },
                    { 32, 20, 11, "/images/session/GroupClasses.jpg", false, "Cours Collectifs Virtuel", "15h00", 3, null },
                    { 33, 2, 11, "/images/session/PersonalTrainer.jpeg", false, "Entraineur Personnel", "18h00", 5, null }
                });

            migrationBuilder.InsertData(
                table: "Commentaries",
                columns: new[] { "Id", "Content", "Created", "SessionId", "UserId" },
                values: new object[,]
                {
                    { 1, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 594, DateTimeKind.Local).AddTicks(7066), 1, 1 },
                    { 2, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3250), 1, 2 },
                    { 3, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3268), 2, 1 },
                    { 4, "Le cours est énergisant", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3271), 2, 4 },
                    { 5, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3272), 3, 3 },
                    { 6, "L'équipe est toujours présente pour nous aider si besoin.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3277), 3, 5 },
                    { 7, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3279), 4, 1 },
                    { 8, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3280), 4, 2 },
                    { 9, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3281), 5, 2 },
                    { 10, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3284), 5, 4 },
                    { 11, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3286), 6, 3 },
                    { 12, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3287), 6, 5 },
                    { 13, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3288), 7, 1 },
                    { 14, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3290), 7, 2 },
                    { 15, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3292), 8, 1 },
                    { 16, "L'équipe est toujours présente pour nous aider si besoin.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3293), 8, 4 },
                    { 17, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3294), 9, 3 },
                    { 18, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3296), 9, 5 },
                    { 19, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3298), 10, 1 },
                    { 20, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3299), 10, 2 },
                    { 21, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3300), 11, 2 },
                    { 22, "Le cours est énergisant", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3302), 11, 4 },
                    { 23, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3303), 12, 3 },
                    { 24, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3304), 12, 5 },
                    { 25, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3305), 13, 1 },
                    { 26, "L'équipe est toujours présente pour nous aider si besoin.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3308), 13, 5 },
                    { 27, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3337), 14, 1 },
                    { 28, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3339), 14, 2 },
                    { 29, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3341), 15, 2 },
                    { 30, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3343), 15, 4 },
                    { 31, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3345), 16, 3 },
                    { 32, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3347), 16, 5 },
                    { 33, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3348), 17, 1 },
                    { 34, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3350), 17, 2 },
                    { 35, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3351), 18, 1 },
                    { 36, "L'équipe est toujours présente pour nous aider si besoin.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3353), 18, 4 },
                    { 37, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3354), 19, 3 },
                    { 38, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3356), 19, 5 },
                    { 39, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3358), 20, 1 },
                    { 40, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3359), 20, 2 },
                    { 41, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3361), 21, 2 },
                    { 42, "Le cours est énergisant", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3362), 21, 4 }
                });

            migrationBuilder.InsertData(
                table: "Commentaries",
                columns: new[] { "Id", "Content", "Created", "SessionId", "UserId" },
                values: new object[,]
                {
                    { 43, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3363), 22, 3 },
                    { 44, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3364), 22, 5 },
                    { 45, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3366), 23, 1 },
                    { 46, "L'équipe est toujours présente pour nous aider si besoin.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3367), 23, 5 },
                    { 47, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3369), 24, 1 },
                    { 48, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3370), 24, 2 },
                    { 49, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3372), 25, 2 },
                    { 50, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3374), 25, 4 },
                    { 51, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3375), 26, 3 },
                    { 52, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3376), 26, 5 },
                    { 53, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3378), 27, 1 },
                    { 54, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3379), 27, 2 },
                    { 55, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3381), 28, 1 },
                    { 56, "L'équipe est toujours présente pour nous aider si besoin.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3382), 28, 4 },
                    { 57, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3384), 29, 3 },
                    { 58, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3385), 29, 5 },
                    { 59, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3386), 30, 1 },
                    { 60, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3388), 30, 2 },
                    { 61, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3389), 31, 2 },
                    { 62, "Le cours est énergisant", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3390), 31, 4 },
                    { 63, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3392), 32, 3 },
                    { 64, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3393), 32, 5 },
                    { 65, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3394), 33, 1 },
                    { 66, "L'équipe est toujours présente pour nous aider si besoin.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3398), 33, 5 },
                    { 67, "Super séance, le coach ambiance la séance et motive bien l'ensemble des participants.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3399), 7, 1 },
                    { 68, "J'ai adoré participé à ce cours collectifs.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3401), 3, 2 },
                    { 69, "Top! Hyper intense.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3402), 3, 2 },
                    { 70, "Ambiance conviviale. Je ne regrette pas mon choix, c’est top!!", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3403), 5, 4 },
                    { 71, "Top! Hyper pédagogue et super séance.", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3405), 1, 3 },
                    { 72, "Le cours est très complet", new DateTime(2023, 10, 30, 10, 35, 54, 596, DateTimeKind.Local).AddTicks(3406), 3, 5 }
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
                name: "Users");
        }
    }
}
