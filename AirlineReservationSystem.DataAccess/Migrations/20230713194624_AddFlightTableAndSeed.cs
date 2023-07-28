using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFlightTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(type: "int", nullable: false),
                    OriginAirportId = table.Column<int>(type: "int", nullable: false),
                    DestinationAirportId = table.Column<int>(type: "int", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flights_Airports_DestinationAirportId",
                        column: x => x.DestinationAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flights_Airports_OriginAirportId",
                        column: x => x.OriginAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AircraftId", "ArrivalTime", "DepartureTime", "DestinationAirportId", "OriginAirportId", "Status" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 7, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Scheduled" },
                    { 2, 4, new DateTime(2023, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, 6, "Scheduled" },
                    { 3, 1, new DateTime(2023, 7, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, 5, "Scheduled" },
                    { 4, 6, new DateTime(2023, 7, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 26, 9, 30, 0, 0, DateTimeKind.Unspecified), 12, 9, "Scheduled" },
                    { 5, 3, new DateTime(2023, 7, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 13, 4, "Scheduled" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AircraftId",
                table: "Flights",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DestinationAirportId",
                table: "Flights",
                column: "DestinationAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_OriginAirportId",
                table: "Flights",
                column: "OriginAirportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
