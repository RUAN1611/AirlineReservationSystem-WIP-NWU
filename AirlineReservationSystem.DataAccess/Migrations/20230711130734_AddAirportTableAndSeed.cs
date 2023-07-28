using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAirportTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "City", "Name", "Province" },
                values: new object[,]
                {
                    { 1, "Johannesburg", "OR Tambo International Airport", "Gauteng" },
                    { 2, "Cape Town", "Cape Town International Airport", "Western Cape" },
                    { 3, "Durban", "King Shaka International Airport", "KwaZulu-Natal" },
                    { 4, "Johannesburg", "Lanseria International Airport", "Gauteng" },
                    { 5, "Port Elizabeth", "Port Elizabeth International Airport", "Eastern Cape" },
                    { 6, "Nelspruit", "Kruger Mpumalanga International Airport", "Mpumalanga" },
                    { 7, "East London", "East London Airport", "Eastern Cape" },
                    { 8, "Bloemfontein", "Bram Fischer International Airport", "Free State" },
                    { 9, "George", "George Airport", "Western Cape" },
                    { 10, "Kimberley", "Kimberley Airport", "Northern Cape" },
                    { 11, "Upington", "Upington International Airport", "Northern Cape" },
                    { 12, "Pilanesberg", "Pilanesberg International Airport", "North West" },
                    { 13, "Margate", "Margate Airport", "KwaZulu-Natal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");
        }
    }
}
