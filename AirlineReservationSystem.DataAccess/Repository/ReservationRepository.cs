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
    public class ReservationRepository:Repository<Reservation>,IReservationRepository
    {
        private readonly ApplicationDbContext _db;

        public ReservationRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Reservation reservation)
        {
            _db.Update(reservation);
        }
    }
}
