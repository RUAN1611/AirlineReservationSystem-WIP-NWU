﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models.ViewModels
{
    public class FlightEmployeeVM
    {
        public FlightEmployee FlightEmployee { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeeList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> FlightList { get; set; }
    }
}
