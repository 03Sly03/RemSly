using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemSlyApi.Migrations
{
    public partial class ReservationSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationSessions",
                columns: table => new
                {
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationSessions", x => new { x.SessionId, x.ReservationId });
                    table.ForeignKey(
                        name: "FK_ReservationSessions_Reservation_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationSessions_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 852, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Commentaries",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: new DateTime(2023, 10, 31, 11, 50, 12, 855, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationSessions_ReservationId",
                table: "ReservationSessions",
                column: "ReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationSessions");

            migrationBuilder.DropTable(
                name: "Reservation");

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
