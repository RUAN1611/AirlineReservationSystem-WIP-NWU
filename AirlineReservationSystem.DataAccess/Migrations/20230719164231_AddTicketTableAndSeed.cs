using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticketes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAdult = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticketes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticketes_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 42, 31, 716, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 42, 31, 716, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 42, 31, 716, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 42, 31, 716, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.InsertData(
                table: "Ticketes",
                columns: new[] { "Id", "IsAdult", "Price", "ReservationId", "SeatNo" },
                values: new object[,]
                {
                    { 1, true, 450m, 1, 14 },
                    { 2, true, 350m, 2, 20 },
                    { 3, true, 400m, 3, 25 },
                    { 4, true, 375m, 4, 30 },
                    { 5, false, 200m, 1, 35 },
                    { 6, false, 225m, 2, 40 },
                    { 7, false, 250m, 3, 45 },
                    { 8, false, 275m, 4, 50 },
                    { 9, false, 300m, 1, 55 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticketes_ReservationId",
                table: "Ticketes",
                column: "ReservationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticketes");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 18, 21, 16, 7, 853, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 18, 21, 16, 7, 853, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 18, 21, 16, 7, 853, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 18, 21, 16, 7, 853, DateTimeKind.Local).AddTicks(4282));
        }
    }
}
