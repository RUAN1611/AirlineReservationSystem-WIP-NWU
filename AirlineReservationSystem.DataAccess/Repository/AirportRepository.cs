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
    public class AirportRepository:Repository<Airport>, IAirportRepository
    {
        private readonly ApplicationDbContext _db;

        public AirportRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Airport airport)
        {
            _db.Update(airport);
        }
    }
}
