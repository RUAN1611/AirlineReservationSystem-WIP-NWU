using AirlineReservationSystem.DataAccess.Data;
using AirlineReservationSystem.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DataAccess.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IAirportRepository AirportRepository { get; private set; }
        public IAircraftRepository AircraftRepository { get; private set; }
        public ICustomerRepository CustomerRepository { get; private set; }
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IFlightRepository FlightRepository { get; private set; }
        public IFlightEmployeeRepository FlightEmployeeRepository { get; private set; }
        public IReservationRepository ReservationRepository { get; private set; }
        public ITicketRepository TicketRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            AirportRepository = new AirportRepository(_db);
            AircraftRepository = new AircraftRepository(_db);
            CustomerRepository = new CustomerRepository(_db);
            EmployeeRepository = new EmployeeRepository(_db);
            FlightRepository = new FlightRepository(_db);
            FlightEmployeeRepository = new FlightEmployeeRepository(_db);
            ReservationRepository = new ReservationRepository(_db);
            TicketRepository = new TicketRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
