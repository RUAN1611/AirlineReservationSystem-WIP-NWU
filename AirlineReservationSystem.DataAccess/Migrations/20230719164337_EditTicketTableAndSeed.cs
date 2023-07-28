using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditTicketTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticketes_Reservations_ReservationId",
                table: "Ticketes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticketes",
                table: "Ticketes");

            migrationBuilder.RenameTable(
                name: "Ticketes",
                newName: "Tickets");

            migrationBuilder.RenameIndex(
                name: "IX_Ticketes_ReservationId",
                table: "Tickets",
                newName: "IX_Tickets_ReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 43, 37, 181, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 43, 37, 181, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 43, 37, 181, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 19, 19, 43, 37, 181, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Reservations_ReservationId",
                table: "Tickets",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Reservations_ReservationId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticketes");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ReservationId",
                table: "Ticketes",
                newName: "IX_Ticketes_ReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticketes",
                table: "Ticketes",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ticketes_Reservations_ReservationId",
                table: "Ticketes",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
