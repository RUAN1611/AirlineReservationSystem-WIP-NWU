﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models.ViewModels
{
    public class TicketVM
    {
        public Ticket Ticket { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ReservationList { get; set; }
    }
}
