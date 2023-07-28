using AirlineReservationSystem.DataAccess.Data;
using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DataAccess.Repository
{
    public class FlightRepository:Repository<Flight>, IFlightRepository
    {
        private readonly ApplicationDbContext _db;

        public FlightRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Flight flight)
        {
            _db.Update(flight);
        }
    }
}
