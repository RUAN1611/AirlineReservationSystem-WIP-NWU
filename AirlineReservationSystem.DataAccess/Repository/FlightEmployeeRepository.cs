﻿using AirlineReservationSystem.DataAccess.Data;
using AirlineReservationSystem.DataAccess.Repository.IRepository;
using AirlineReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DataAccess.Repository
{
    public class FlightEmployeeRepository:Repository<FlightEmployee>, IFlightEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public FlightEmployeeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FlightEmployee flightEmployee) 
        {
            _db.Update(flightEmployee);
        }
    }
}
