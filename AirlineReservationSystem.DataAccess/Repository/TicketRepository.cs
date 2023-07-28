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
    public class TicketRepository:Repository<Ticket>, ITicketRepository
    {
        private readonly ApplicationDbContext _db;
        public TicketRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Ticket ticket)
        {
            _db.Update(ticket);
        }
    }
}
