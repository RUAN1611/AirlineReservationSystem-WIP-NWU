using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IAirportRepository AirportRepository { get; }
        IAircraftRepository AircraftRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IFlightRepository FlightRepository { get; }
        IFlightEmployeeRepository FlightEmployeeRepository { get; }
        IReservationRepository ReservationRepository { get; }
        ITicketRepository TicketRepository { get; }
        void Save();
    }
}
