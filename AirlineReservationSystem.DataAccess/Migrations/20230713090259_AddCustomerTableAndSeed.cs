using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirlineReservationSystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
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
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "City", "DateOfBirth", "Email", "FirstName", "Gender", "IDNumber", "LastName", "PhoneNumber", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Bethal", new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ruan.nagel1611@gmail.com", "Ruan", "Male", "0001255034512", "Meyer", "0818264321", "17 Kalie Brits" },
                    { 2, "Durban", new DateTime(1995, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "z.mthembu@gmail.com", "Zinhle", "Female", "9506120012087", "Mthembu", "0712345678", "23 Beach Road" },
                    { 3, "Johannesburg", new DateTime(1987, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tmokwena@gmail.com", "Thabo", "Male", "8703055034087", "Mokwena", "0823456789", "14 Main Street" },
                    { 4, "Pietermaritzburg", new DateTime(1998, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "nmkhize22@hotmail.com", "Nomthandazo", "Female", "9811220067088", "Mkhize", "0734567890", "5 Victoria Road" },
                    { 5, "Pretoria", new DateTime(1980, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmolefe@gmail.com", "Moses", "Male", "8009035054080", "Molefe", "0834567891", "20 Church Street" },
                    { 6, "Nelspruit", new DateTime(1991, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "lnkosi@yahoo.com", "Lindiwe", "Female", "9107160014081", "Nkosi", "0713456789", "10 Riverside Drive" },
                    { 7, "Soweto", new DateTime(1996, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "sngwenya@gmail.com", "Sipho", "Male", "9602280026085", "Ngwenya", "0834567892", "15 Vilakazi Street" },
                    { 8, "Cape Town", new DateTime(1989, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ndlamini@hotmail.com", "Nompumelelo", "Female", "8912070030084", "Dlamini", "0723456789", "7 Long Street" },
                    { 9, "Bloemfontein", new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "tmashigo@gmail.com", "Thabiso", "Male", "9304195031082", "Mashigo", "0812345678", "12 President Brand Street" },
                    { 10, "Rustenburg", new DateTime(1986, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "lmoloi@yahoo.com", "Lerato", "Female", "8608090013085", "Moloi", "0734567892", "9 Berg Street" },
                    { 11, "Polokwane", new DateTime(1992, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "bmabasa@hotmail.com", "Bongani", "Male", "9205315033084", "Mabasa", "0823456781", "6 Church Street" },
                    { 12, "East London", new DateTime(1997, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nmbatha@gmail.com", "Nokubonga", "Female", "9702150014086", "Mbatha", "0712345679", "18 Oxford Road" },
                    { 13, "Pretoria", new DateTime(1988, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "liezelvz@gmail.com", "Liezel", "Female", "8810110015088", "Van Zyl", "0823456781", "7 Van Der Walt Street" },
                    { 14, "Johannesburg", new DateTime(1985, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "johankruger@yahoo.com", "Johan", "Male", "8504275022087", "Kruger", "0834567892", "12 Kruger Street" },
                    { 15, "Cape Town", new DateTime(1990, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "elizebotha@gmail.com", "Elize", "Female", "9007030010085", "Botha", "0712345678", "24 Main Road" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
