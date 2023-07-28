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
    public class CustomerRepository:Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Customer customer)
        {
            _db.Update(customer);
        }
    }
}
