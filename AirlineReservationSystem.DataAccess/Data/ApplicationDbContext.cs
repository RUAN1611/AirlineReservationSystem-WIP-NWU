using AirlineReservationSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightEmployee> FlightEmployees { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FlightEmployee>().HasKey(u => new { u.FlightId, u.EmployeeId });

            modelBuilder.Entity<Airport>().HasData(
                new Airport { Id = 1, Name = "OR Tambo International Airport", City = "Johannesburg", Province = "Gauteng" },
                new Airport { Id = 2, Name = "Cape Town International Airport", City = "Cape Town", Province = "Western Cape" },
                new Airport { Id = 3, Name = "King Shaka International Airport", City = "Durban", Province = "KwaZulu-Natal" },
                new Airport { Id = 4, Name = "Lanseria International Airport", City = "Johannesburg", Province = "Gauteng" },
                new Airport { Id = 5, Name = "Port Elizabeth International Airport", City = "Port Elizabeth", Province = "Eastern Cape" },
                new Airport { Id = 6, Name = "Kruger Mpumalanga International Airport", City = "Nelspruit", Province = "Mpumalanga" },
                new Airport { Id = 7, Name = "East London Airport", City = "East London", Province = "Eastern Cape" },
                new Airport { Id = 8, Name = "Bram Fischer International Airport", City = "Bloemfontein", Province = "Free State" },
                new Airport { Id = 9, Name = "George Airport", City = "George", Province = "Western Cape" },
                new Airport { Id = 10, Name = "Kimberley Airport", City = "Kimberley", Province = "Northern Cape" },
                new Airport { Id = 11, Name = "Upington International Airport", City = "Upington", Province = "Northern Cape" },
                new Airport { Id = 12, Name = "Pilanesberg International Airport", City = "Pilanesberg", Province = "North West" },
                new Airport { Id = 13, Name = "Margate Airport", City = "Margate", Province = "KwaZulu-Natal" }
            );

            modelBuilder.Entity<Aircraft>().HasData(
                new Aircraft
                {
                    Id = 1,
                    Name = "Boeing 747",
                    Manufacturer = "Boeing",
                    DateRegistered = new DateTime(2020, 1, 1),
                    SerialNumber = "747-001",
                    OriginalPrice = 10000000, // ZAR
                    TravelRange = 21000, // km
                    MaxCruiseSpeed = 1480, // km/h
                    FuelEconomy = 2.5, // km/L 
                    TotalNoOfSeats = 400
                },
                new Aircraft
                {
                    Id = 2,
                    Name = "Airbus A380",
                    Manufacturer = "Airbus",
                    DateRegistered = new DateTime(2018, 5, 15),
                    SerialNumber = "A380-002",
                    OriginalPrice = 12000000, // ZAR
                    TravelRange = 24000, // km
                    MaxCruiseSpeed = 1520, // km/h
                    FuelEconomy = 2.3, // km/L
                    TotalNoOfSeats = 525
                },
                new Aircraft
                {
                    Id = 3,
                    Name = "Bombardier CRJ200",
                    Manufacturer = "Bombardier",
                    DateRegistered = new DateTime(2015, 11, 20),
                    SerialNumber = "CRJ200-003",
                    OriginalPrice = 2000000, // ZAR
                    TravelRange = 4800, // km
                    MaxCruiseSpeed = 1400, // km/h
                    FuelEconomy = 1.6, // km/L
                    TotalNoOfSeats = 50
                },
                new Aircraft
                {
                    Id = 4,
                    Name = "Cessna 172 Skyhawk",
                    Manufacturer = "Cessna",
                    DateRegistered = new DateTime(2017, 6, 1),
                    SerialNumber = "C172-004",
                    OriginalPrice = 300000, // ZAR
                    TravelRange = 2400, // km
                    MaxCruiseSpeed = 550, // km/h
                    FuelEconomy = 4, // km/L
                    TotalNoOfSeats = 4
                },
                new Aircraft
                {
                    Id = 5,
                    Name = "Pilatus PC-12",
                    Manufacturer = "Pilatus",
                    DateRegistered = new DateTime(2019, 3, 15),
                    SerialNumber = "PC12-005",
                    OriginalPrice = 4500000, // ZAR
                    TravelRange = 3840, // km
                    MaxCruiseSpeed = 900, // km/h
                    FuelEconomy = 2.6, // km/L
                    TotalNoOfSeats = 9
                },
                new Aircraft
                {
                    Id = 6,
                    Name = "Gulfstream G650",
                    Manufacturer = "Gulfstream",
                    DateRegistered = new DateTime(2021, 8, 30),
                    SerialNumber = "G650-006",
                    OriginalPrice = 60000000, // ZAR
                    TravelRange = 20000, // km
                    MaxCruiseSpeed = 1480, // km/h 
                    FuelEconomy = 1.6, // km/L
                    TotalNoOfSeats = 18
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    FirstName = "Ruan",
                    LastName = "Nagel",
                    DateOfBirth = new DateTime(2000, 1, 25),
                    Gender = "Male",
                    Email = "ruan.nagel4811@gmail.com",
                    PhoneNumber = "0818264321",
                    City = "Bethal",
                    StreetAddress = "17 Kalie Brits",
                    IDNumber = "0001255034512"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Zinhle",
                    LastName = "Mthembu",
                    DateOfBirth = new DateTime(1995, 6, 12),
                    Gender = "Female",
                    Email = "z.mthembu@gmail.com",
                    PhoneNumber = "0712345678",
                    City = "Durban",
                    StreetAddress = "23 Beach Road",
                    IDNumber = "9506120012087"
                },
                new Customer
                {
                    Id = 3,
                    FirstName = "Thabo",
                    LastName = "Mokwena",
                    DateOfBirth = new DateTime(1987, 3, 5),
                    Gender = "Male",
                    Email = "tmokwena@gmail.com",
                    PhoneNumber = "0823456789",
                    City = "Johannesburg",
                    StreetAddress = "14 Main Street",
                    IDNumber = "8703055034087"
                },
                new Customer
                {
                    Id = 4,
                    FirstName = "Nomthandazo",
                    LastName = "Mkhize",
                    DateOfBirth = new DateTime(1998, 11, 22),
                    Gender = "Female",
                    Email = "nmkhize22@hotmail.com",
                    PhoneNumber = "0734567890",
                    City = "Pietermaritzburg",
                    StreetAddress = "5 Victoria Road",
                    IDNumber = "9811220067088"
                },
                new Customer
                {
                    Id = 5,
                    FirstName = "Moses",
                    LastName = "Molefe",
                    DateOfBirth = new DateTime(1980, 9, 3),
                    Gender = "Male",
                    Email = "mmolefe@gmail.com",
                    PhoneNumber = "0834567891",
                    City = "Pretoria",
                    StreetAddress = "20 Church Street",
                    IDNumber = "8009035054080"
                },
                new Customer
                {
                    Id = 6,
                    FirstName = "Lindiwe",
                    LastName = "Nkosi",
                    DateOfBirth = new DateTime(1991, 7, 16),
                    Gender = "Female",
                    Email = "lnkosi@yahoo.com",
                    PhoneNumber = "0713456789",
                    City = "Nelspruit",
                    StreetAddress = "10 Riverside Drive",
                    IDNumber = "9107160014081"
                },
                new Customer
                {
                    Id = 7,
                    FirstName = "Sipho",
                    LastName = "Ngwenya",
                    DateOfBirth = new DateTime(1996, 2, 28),
                    Gender = "Male",
                    Email = "sngwenya@gmail.com",
                    PhoneNumber = "0834567892",
                    City = "Soweto",
                    StreetAddress = "15 Vilakazi Street",
                    IDNumber = "9602280026085"
                },
                new Customer
                {
                    Id = 8,
                    FirstName = "Nompumelelo",
                    LastName = "Dlamini",
                    DateOfBirth = new DateTime(1989, 12, 7),
                    Gender = "Female",
                    Email = "ndlamini@hotmail.com",
                    PhoneNumber = "0723456789",
                    City = "Cape Town",
                    StreetAddress = "7 Long Street",
                    IDNumber = "8912070030084"
                },
                new Customer
                {
                    Id = 9,
                    FirstName = "Thabiso",
                    LastName = "Mashigo",
                    DateOfBirth = new DateTime(1993, 4, 19),
                    Gender = "Male",
                    Email = "tmashigo@gmail.com",
                    PhoneNumber = "0812345678",
                    City = "Bloemfontein",
                    StreetAddress = "12 President Brand Street",
                    IDNumber = "9304195031082"
                },
                new Customer
                {
                    Id = 10,
                    FirstName = "Lerato",
                    LastName = "Moloi",
                    DateOfBirth = new DateTime(1986, 8, 9),
                    Gender = "Female",
                    Email = "lmoloi@yahoo.com",
                    PhoneNumber = "0734567892",
                    City = "Rustenburg",
                    StreetAddress = "9 Berg Street",
                    IDNumber = "8608090013085"
                },
                new Customer
                {
                    Id = 11,
                    FirstName = "Bongani",
                    LastName = "Mabasa",
                    DateOfBirth = new DateTime(1992, 5, 31),
                    Gender = "Male",
                    Email = "bmabasa@hotmail.com",
                    PhoneNumber = "0823456781",
                    City = "Polokwane",
                    StreetAddress = "6 Church Street",
                    IDNumber = "9205315033084"
                },
                new Customer
                {
                    Id = 12,
                    FirstName = "Nokubonga",
                    LastName = "Mbatha",
                    DateOfBirth = new DateTime(1997, 2, 15),
                    Gender = "Female",
                    Email = "nmbatha@gmail.com",
                    PhoneNumber = "0712345679",
                    City = "East London",
                    StreetAddress = "18 Oxford Road",
                    IDNumber = "9702150014086"
                },
                new Customer
                {
                    Id = 13,
                    FirstName = "Liezel",
                    LastName = "Van Zyl",
                    DateOfBirth = new DateTime(1988, 10, 11),
                    Gender = "Female",
                    Email = "liezelvz@gmail.com",
                    PhoneNumber = "0823456781",
                    City = "Pretoria",
                    StreetAddress = "7 Van Der Walt Street",
                    IDNumber = "8810110015088"
                },
                new Customer
                {
                    Id = 14,
                    FirstName = "Johan",
                    LastName = "Kruger",
                    DateOfBirth = new DateTime(1985, 4, 27),
                    Gender = "Male",
                    Email = "johankruger@yahoo.com",
                    PhoneNumber = "0834567892",
                    City = "Johannesburg",
                    StreetAddress = "12 Kruger Street",
                    IDNumber = "8504275022087"
                },
                new Customer
                {
                    Id = 15,
                    FirstName = "Elize",
                    LastName = "Botha",
                    DateOfBirth = new DateTime(1990, 7, 3),
                    Gender = "Female",
                    Email = "elizebotha@gmail.com",
                    PhoneNumber = "0712345678",
                    City = "Cape Town",
                    StreetAddress = "24 Main Road",
                    IDNumber = "9007030010085"
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "Valushia",
                    LastName = "Odendaal",
                    DateOfBirth = new DateTime(1998, 5, 3),
                    Gender = "Female",
                    Email = "vodendaal@gmail.com",
                    PhoneNumber = "0612446674",
                    City = "Cape Town",
                    StreetAddress = "52 Main Road",
                    IDNumber = "9805031010085"
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Thabo",
                    LastName = "Moloi",
                    DateOfBirth = new DateTime(1992, 8, 15),
                    Gender = "Male",
                    Email = "tmoloi@example.com",
                    PhoneNumber = "0823456789",
                    City = "Johannesburg",
                    StreetAddress = "123 Oak Street",
                    IDNumber = "9208155678901"
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Zanele",
                    LastName = "Ngwenya",
                    DateOfBirth = new DateTime(1985, 11, 25),
                    Gender = "Female",
                    Email = "zngwenya@example.com",
                    PhoneNumber = "0845678901",
                    City = "Durban",
                    StreetAddress = "456 Beach Road",
                    IDNumber = "8511257890123"
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Sipho",
                    LastName = "Mbatha",
                    DateOfBirth = new DateTime(1992, 3, 10),
                    Gender = "Male",
                    Email = "sipho@example.com",
                    PhoneNumber = "0712345678",
                    City = "Pretoria",
                    StreetAddress = "789 Pine Avenue",
                    IDNumber = "9203103456789"
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Lerato",
                    LastName = "Modise",
                    DateOfBirth = new DateTime(1988, 7, 21),
                    Gender = "Female",
                    Email = "lmodise@example.com",
                    PhoneNumber = "0834567890",
                    City = "Bloemfontein",
                    StreetAddress = "321 Main Street",
                    IDNumber = "8807216789012"
                },
                new Employee
                {
                    Id = 6,
                    FirstName = "Bongani",
                    LastName = "Mthembu",
                    DateOfBirth = new DateTime(1995, 12, 5),
                    Gender = "Male",
                    Email = "bmthembu@example.com",
                    PhoneNumber = "0723456789",
                    City = "Port Elizabeth",
                    StreetAddress = "987 Beach Road",
                    IDNumber = "9512054567890"
                }
            );

            modelBuilder.Entity<Flight>().HasData(
                new Flight
                {
                    Id = 1,
                    AircraftId = 2,
                    OriginAirportId = 3,
                    DestinationAirportId = 2,
                    DepartureTime = new DateTime(2023, 07, 23, 8, 0, 0),
                    ArrivalTime = new DateTime(2023, 07, 23, 9, 0, 0),
                    Status = "Scheduled"
                },
                new Flight
                {
                    Id = 2,
                    AircraftId = 4,
                    OriginAirportId = 6,
                    DestinationAirportId = 10,
                    DepartureTime = new DateTime(2023, 07, 24, 10, 0, 0),
                    ArrivalTime = new DateTime(2023, 07, 24, 12, 0, 0),
                    Status = "Scheduled"
                },
                new Flight
                {
                    Id = 3,
                    AircraftId = 1,
                    OriginAirportId = 5,
                    DestinationAirportId = 7,
                    DepartureTime = new DateTime(2023, 07, 25, 15, 0, 0),
                    ArrivalTime = new DateTime(2023, 07, 25, 17, 0, 0),
                    Status = "Scheduled"
                },
                new Flight
                {
                    Id = 4,
                    AircraftId = 6,
                    OriginAirportId = 9,
                    DestinationAirportId = 12,
                    DepartureTime = new DateTime(2023, 07, 26, 9, 30, 0),
                    ArrivalTime = new DateTime(2023, 07, 26, 11, 0, 0),
                    Status = "Scheduled"
                },
                new Flight
                {
                    Id = 5,
                    AircraftId = 3,
                    OriginAirportId = 4,
                    DestinationAirportId = 13,
                    DepartureTime = new DateTime(2023, 07, 27, 14, 0, 0),
                    ArrivalTime = new DateTime(2023, 07, 27, 16, 0, 0),
                    Status = "Scheduled"
                }
            );

            modelBuilder.Entity<FlightEmployee>().HasData(
                new FlightEmployee
                {
                    FlightId = 1,
                    EmployeeId = 1,
                    JobRole = "Pilot"
                },
                new FlightEmployee
                {
                    FlightId = 1,
                    EmployeeId = 3,
                    JobRole = "Co-Pilot"
                },
                new FlightEmployee
                {
                    FlightId = 1,
                    EmployeeId = 2,
                    JobRole = "Assistant"
                },
                new FlightEmployee
                {
                    FlightId = 1,
                    EmployeeId = 4,
                    JobRole = "Loader"
                },
                new FlightEmployee
                {
                    FlightId = 2,
                    EmployeeId = 1,
                    JobRole = "Pilot"
                },
                new FlightEmployee
                {
                    FlightId = 2,
                    EmployeeId = 3,
                    JobRole = "Co-Pilot"
                },
                new FlightEmployee
                {
                    FlightId = 2,
                    EmployeeId = 2,
                    JobRole = "Assistant"
                },
                new FlightEmployee
                {
                    FlightId = 2,
                    EmployeeId = 4,
                    JobRole = "Loader"
                }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    Id = 1,
                    CustomerId = 2,
                    FlightId = 3,
                    DateCreated = DateTime.Now,
                    Status = "Reserved"
                },
                new Reservation
                {
                    Id = 2,
                    CustomerId = 3,
                    FlightId = 1,
                    DateCreated = DateTime.Now,
                    Status = "Reserved"
                },
                new Reservation
                {
                    Id = 3,
                    CustomerId = 4,
                    FlightId = 2,
                    DateCreated = DateTime.Now,
                    Status = "Reserved"
                },
                new Reservation
                {
                    Id = 4,
                    CustomerId = 5,
                    FlightId = 4,
                    DateCreated = DateTime.Now,
                    Status = "Reserved"
                }
            );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    SeatNo = 14,
                    ReservationId = 1,
                    Price = 450M,
                    IsAdult = true
                },
                new Ticket
                {
                    Id = 2,
                    SeatNo = 20,
                    ReservationId = 2,
                    Price = 350M,
                    IsAdult = true
                },
                new Ticket
                {
                    Id = 3,
                    SeatNo = 25,
                    ReservationId = 3,
                    Price = 400M,
                    IsAdult = true
                },
                new Ticket
                {
                    Id = 4,
                    SeatNo = 30,
                    ReservationId = 4,
                    Price = 375M,
                    IsAdult = true
                },
                new Ticket
                {
                    Id = 5,
                    SeatNo = 35,
                    ReservationId = 1,
                    Price = 200M,
                    IsAdult = false
                },
                new Ticket
                {
                    Id = 6,
                    SeatNo = 40,
                    ReservationId = 2,
                    Price = 225M,
                    IsAdult = false
                },
                new Ticket
                {
                    Id = 7,
                    SeatNo = 45,
                    ReservationId = 3,
                    Price = 250M,
                    IsAdult = false
                },
                new Ticket
                {
                    Id = 8,
                    SeatNo = 50,
                    ReservationId = 4,
                    Price = 275M,
                    IsAdult = false
                },
                new Ticket
                {
                    Id = 9,
                    SeatNo = 55,
                    ReservationId = 1,
                    Price = 300M,
                    IsAdult = false
                }
            );
        }
    }
}
