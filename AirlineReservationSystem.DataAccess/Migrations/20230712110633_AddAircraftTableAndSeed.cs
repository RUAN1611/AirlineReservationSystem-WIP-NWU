using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAircraftTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TravelRange = table.Column<double>(type: "float", nullable: false),
                    MaxCruiseSpeed = table.Column<double>(type: "float", nullable: false),
                    FuelEconomy = table.Column<double>(type: "float", nullable: false),
                    TotalNoOfSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "DateRegistered", "FuelEconomy", "Manufacturer", "MaxCruiseSpeed", "Name", "OriginalPrice", "SerialNumber", "TotalNoOfSeats", "TravelRange" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5, "Boeing", 1480.0, "Boeing 747", 10000000m, "747-001", 400, 21000.0 },
                    { 2, new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.2999999999999998, "Airbus", 1520.0, "Airbus A380", 12000000m, "A380-002", 525, 24000.0 },
                    { 3, new DateTime(2015, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6000000000000001, "Bombardier", 1400.0, "Bombardier CRJ200", 2000000m, "CRJ200-003", 50, 4800.0 },
                    { 4, new DateTime(2017, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, "Cessna", 550.0, "Cessna 172 Skyhawk", 300000m, "C172-004", 4, 2400.0 },
                    { 5, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.6000000000000001, "Pilatus", 900.0, "Pilatus PC-12", 4500000m, "PC12-005", 9, 3840.0 },
                    { 6, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.6000000000000001, "Gulfstream", 1480.0, "Gulfstream G650", 60000000m, "G650-006", 18, 20000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircrafts");
        }
    }
}
