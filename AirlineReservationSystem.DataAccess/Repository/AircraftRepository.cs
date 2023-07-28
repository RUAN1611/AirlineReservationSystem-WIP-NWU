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
    public class AircraftRepository:Repository<Aircraft>, IAircraftRepository
    {
        private readonly ApplicationDbContext _db;

        public AircraftRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Aircraft aircraft)
        {
            _db.Update(aircraft);
        }
    }
}
