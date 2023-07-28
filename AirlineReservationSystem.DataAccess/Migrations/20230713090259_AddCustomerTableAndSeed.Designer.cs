﻿// <auto-generated />
using System;
using AirlineReservationSystem.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AirlineReservationSystem.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230713090259_AddCustomerTableAndSeed")]
    partial class AddCustomerTableAndSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AirlineReservationSystem.Models.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime2");

                    b.Property<double>("FuelEconomy")
                        .HasColumnType("float");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaxCruiseSpeed")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalNoOfSeats")
                        .HasColumnType("int");

                    b.Property<double>("TravelRange")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Aircrafts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateRegistered = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelEconomy = 2.5,
                            Manufacturer = "Boeing",
                            MaxCruiseSpeed = 1480.0,
                            Name = "Boeing 747",
                            OriginalPrice = 10000000m,
                            SerialNumber = "747-001",
                            TotalNoOfSeats = 400,
                            TravelRange = 21000.0
                        },
                        new
                        {
                            Id = 2,
                            DateRegistered = new DateTime(2018, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelEconomy = 2.2999999999999998,
                            Manufacturer = "Airbus",
                            MaxCruiseSpeed = 1520.0,
                            Name = "Airbus A380",
                            OriginalPrice = 12000000m,
                            SerialNumber = "A380-002",
                            TotalNoOfSeats = 525,
                            TravelRange = 24000.0
                        },
                        new
                        {
                            Id = 3,
                            DateRegistered = new DateTime(2015, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelEconomy = 1.6000000000000001,
                            Manufacturer = "Bombardier",
                            MaxCruiseSpeed = 1400.0,
                            Name = "Bombardier CRJ200",
                            OriginalPrice = 2000000m,
                            SerialNumber = "CRJ200-003",
                            TotalNoOfSeats = 50,
                            TravelRange = 4800.0
                        },
                        new
                        {
                            Id = 4,
                            DateRegistered = new DateTime(2017, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelEconomy = 4.0,
                            Manufacturer = "Cessna",
                            MaxCruiseSpeed = 550.0,
                            Name = "Cessna 172 Skyhawk",
                            OriginalPrice = 300000m,
                            SerialNumber = "C172-004",
                            TotalNoOfSeats = 4,
                            TravelRange = 2400.0
                        },
                        new
                        {
                            Id = 5,
                            DateRegistered = new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelEconomy = 2.6000000000000001,
                            Manufacturer = "Pilatus",
                            MaxCruiseSpeed = 900.0,
                            Name = "Pilatus PC-12",
                            OriginalPrice = 4500000m,
                            SerialNumber = "PC12-005",
                            TotalNoOfSeats = 9,
                            TravelRange = 3840.0
                        },
                        new
                        {
                            Id = 6,
                            DateRegistered = new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelEconomy = 1.6000000000000001,
                            Manufacturer = "Gulfstream",
                            MaxCruiseSpeed = 1480.0,
                            Name = "Gulfstream G650",
                            OriginalPrice = 60000000m,
                            SerialNumber = "G650-006",
                            TotalNoOfSeats = 18,
                            TravelRange = 20000.0
                        });
                });

            modelBuilder.Entity("AirlineReservationSystem.Models.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Johannesburg",
                            Name = "OR Tambo International Airport",
                            Province = "Gauteng"
                        },
                        new
                        {
                            Id = 2,
                            City = "Cape Town",
                            Name = "Cape Town International Airport",
                            Province = "Western Cape"
                        },
                        new
                        {
                            Id = 3,
                            City = "Durban",
                            Name = "King Shaka International Airport",
                            Province = "KwaZulu-Natal"
                        },
                        new
                        {
                            Id = 4,
                            City = "Johannesburg",
                            Name = "Lanseria International Airport",
                            Province = "Gauteng"
                        },
                        new
                        {
                            Id = 5,
                            City = "Port Elizabeth",
                            Name = "Port Elizabeth International Airport",
                            Province = "Eastern Cape"
                        },
                        new
                        {
                            Id = 6,
                            City = "Nelspruit",
                            Name = "Kruger Mpumalanga International Airport",
                            Province = "Mpumalanga"
                        },
                        new
                        {
                            Id = 7,
                            City = "East London",
                            Name = "East London Airport",
                            Province = "Eastern Cape"
                        },
                        new
                        {
                            Id = 8,
                            City = "Bloemfontein",
                            Name = "Bram Fischer International Airport",
                            Province = "Free State"
                        },
                        new
                        {
                            Id = 9,
                            City = "George",
                            Name = "George Airport",
                            Province = "Western Cape"
                        },
                        new
                        {
                            Id = 10,
                            City = "Kimberley",
                            Name = "Kimberley Airport",
                            Province = "Northern Cape"
                        },
                        new
                        {
                            Id = 11,
                            City = "Upington",
                            Name = "Upington International Airport",
                            Province = "Northern Cape"
                        },
                        new
                        {
                            Id = 12,
                            City = "Pilanesberg",
                            Name = "Pilanesberg International Airport",
                            Province = "North West"
                        },
                        new
                        {
                            Id = 13,
                            City = "Margate",
                            Name = "Margate Airport",
                            Province = "KwaZulu-Natal"
                        });
                });

            modelBuilder.Entity("AirlineReservationSystem.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Bethal",
                            DateOfBirth = new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ruan.nagel1611@gmail.com",
                            FirstName = "Ruan",
                            Gender = "Male",
                            IDNumber = "0001255034512",
                            LastName = "Meyer",
                            PhoneNumber = "0818264321",
                            StreetAddress = "17 Kalie Brits"
                        },
                        new
                        {
                            Id = 2,
                            City = "Durban",
                            DateOfBirth = new DateTime(1995, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "z.mthembu@gmail.com",
                            FirstName = "Zinhle",
                            Gender = "Female",
                            IDNumber = "9506120012087",
                            LastName = "Mthembu",
                            PhoneNumber = "0712345678",
                            StreetAddress = "23 Beach Road"
                        },
                        new
                        {
                            Id = 3,
                            City = "Johannesburg",
                            DateOfBirth = new DateTime(1987, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tmokwena@gmail.com",
                            FirstName = "Thabo",
                            Gender = "Male",
                            IDNumber = "8703055034087",
                            LastName = "Mokwena",
                            PhoneNumber = "0823456789",
                            StreetAddress = "14 Main Street"
                        },
                        new
                        {
                            Id = 4,
                            City = "Pietermaritzburg",
                            DateOfBirth = new DateTime(1998, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nmkhize22@hotmail.com",
                            FirstName = "Nomthandazo",
                            Gender = "Female",
                            IDNumber = "9811220067088",
                            LastName = "Mkhize",
                            PhoneNumber = "0734567890",
                            StreetAddress = "5 Victoria Road"
                        },
                        new
                        {
                            Id = 5,
                            City = "Pretoria",
                            DateOfBirth = new DateTime(1980, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mmolefe@gmail.com",
                            FirstName = "Moses",
                            Gender = "Male",
                            IDNumber = "8009035054080",
                            LastName = "Molefe",
                            PhoneNumber = "0834567891",
                            StreetAddress = "20 Church Street"
                        },
                        new
                        {
                            Id = 6,
                            City = "Nelspruit",
                            DateOfBirth = new DateTime(1991, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lnkosi@yahoo.com",
                            FirstName = "Lindiwe",
                            Gender = "Female",
                            IDNumber = "9107160014081",
                            LastName = "Nkosi",
                            PhoneNumber = "0713456789",
                            StreetAddress = "10 Riverside Drive"
                        },
                        new
                        {
                            Id = 7,
                            City = "Soweto",
                            DateOfBirth = new DateTime(1996, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sngwenya@gmail.com",
                            FirstName = "Sipho",
                            Gender = "Male",
                            IDNumber = "9602280026085",
                            LastName = "Ngwenya",
                            PhoneNumber = "0834567892",
                            StreetAddress = "15 Vilakazi Street"
                        },
                        new
                        {
                            Id = 8,
                            City = "Cape Town",
                            DateOfBirth = new DateTime(1989, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ndlamini@hotmail.com",
                            FirstName = "Nompumelelo",
                            Gender = "Female",
                            IDNumber = "8912070030084",
                            LastName = "Dlamini",
                            PhoneNumber = "0723456789",
                            StreetAddress = "7 Long Street"
                        },
                        new
                        {
                            Id = 9,
                            City = "Bloemfontein",
                            DateOfBirth = new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tmashigo@gmail.com",
                            FirstName = "Thabiso",
                            Gender = "Male",
                            IDNumber = "9304195031082",
                            LastName = "Mashigo",
                            PhoneNumber = "0812345678",
                            StreetAddress = "12 President Brand Street"
                        },
                        new
                        {
                            Id = 10,
                            City = "Rustenburg",
                            DateOfBirth = new DateTime(1986, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lmoloi@yahoo.com",
                            FirstName = "Lerato",
                            Gender = "Female",
                            IDNumber = "8608090013085",
                            LastName = "Moloi",
                            PhoneNumber = "0734567892",
                            StreetAddress = "9 Berg Street"
                        },
                        new
                        {
                            Id = 11,
                            City = "Polokwane",
                            DateOfBirth = new DateTime(1992, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bmabasa@hotmail.com",
                            FirstName = "Bongani",
                            Gender = "Male",
                            IDNumber = "9205315033084",
                            LastName = "Mabasa",
                            PhoneNumber = "0823456781",
                            StreetAddress = "6 Church Street"
                        },
                        new
                        {
                            Id = 12,
                            City = "East London",
                            DateOfBirth = new DateTime(1997, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nmbatha@gmail.com",
                            FirstName = "Nokubonga",
                            Gender = "Female",
                            IDNumber = "9702150014086",
                            LastName = "Mbatha",
                            PhoneNumber = "0712345679",
                            StreetAddress = "18 Oxford Road"
                        },
                        new
                        {
                            Id = 13,
                            City = "Pretoria",
                            DateOfBirth = new DateTime(1988, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "liezelvz@gmail.com",
                            FirstName = "Liezel",
                            Gender = "Female",
                            IDNumber = "8810110015088",
                            LastName = "Van Zyl",
                            PhoneNumber = "0823456781",
                            StreetAddress = "7 Van Der Walt Street"
                        },
                        new
                        {
                            Id = 14,
                            City = "Johannesburg",
                            DateOfBirth = new DateTime(1985, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "johankruger@yahoo.com",
                            FirstName = "Johan",
                            Gender = "Male",
                            IDNumber = "8504275022087",
                            LastName = "Kruger",
                            PhoneNumber = "0834567892",
                            StreetAddress = "12 Kruger Street"
                        },
                        new
                        {
                            Id = 15,
                            City = "Cape Town",
                            DateOfBirth = new DateTime(1990, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elizebotha@gmail.com",
                            FirstName = "Elize",
                            Gender = "Female",
                            IDNumber = "9007030010085",
                            LastName = "Botha",
                            PhoneNumber = "0712345678",
                            StreetAddress = "24 Main Road"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
