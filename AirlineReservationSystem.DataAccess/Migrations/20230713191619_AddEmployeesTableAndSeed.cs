using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeesTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "City", "DateOfBirth", "Email", "FirstName", "Gender", "IDNumber", "LastName", "PhoneNumber", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Cape Town", new DateTime(1998, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "vodendaal@gmail.com", "Valushia", "Female", "9805031010085", "Odendaal", "0612446674", "52 Main Road" },
                    { 2, "Johannesburg", new DateTime(1992, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "tmoloi@example.com", "Thabo", "Male", "9208155678901", "Moloi", "0823456789", "123 Oak Street" },
                    { 3, "Durban", new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "zngwenya@example.com", "Zanele", "Female", "8511257890123", "Ngwenya", "0845678901", "456 Beach Road" },
                    { 4, "Pretoria", new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "sipho@example.com", "Sipho", "Male", "9203103456789", "Mbatha", "0712345678", "789 Pine Avenue" },
                    { 5, "Bloemfontein", new DateTime(1988, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "lmodise@example.com", "Lerato", "Female", "8807216789012", "Modise", "0834567890", "321 Main Street" },
                    { 6, "Port Elizabeth", new DateTime(1995, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "bmthembu@example.com", "Bongani", "Male", "9512054567890", "Mthembu", "0723456789", "987 Beach Road" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
