﻿using AirlineReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.DataAccess.Repository.IRepository
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        void Update(Customer customer);
    }
}
