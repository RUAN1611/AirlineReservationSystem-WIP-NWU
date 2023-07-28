using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFlightEmployeeTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightEmployees",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    JobRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightEmployees", x => new { x.FlightId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_FlightEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightEmployees_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FlightEmployees",
                columns: new[] { "EmployeeId", "FlightId", "JobRole" },
                values: new object[,]
                {
                    { 1, 1, "Pilot" },
                    { 2, 1, "Assistant" },
                    { 3, 1, "Co-Pilot" },
                    { 4, 1, "Loader" },
                    { 1, 2, "Pilot" },
                    { 2, 2, "Assistant" },
                    { 3, 2, "Co-Pilot" },
                    { 4, 2, "Loader" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightEmployees_EmployeeId",
                table: "FlightEmployees",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightEmployees");
        }
    }
}
