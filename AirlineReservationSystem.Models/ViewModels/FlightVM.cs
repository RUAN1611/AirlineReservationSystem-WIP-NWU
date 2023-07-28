using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models.ViewModels
{
    public class FlightVM
    {
        public Flight Flight { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> AircraftList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> OriginAirportList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DestinationAirportList { get; set; }
        [ValidateNever]
        public Aircraft AircraftView { get; set; }
        [ValidateNever]
        public Airport OriginAirportView { get; set; }
        [ValidateNever]
        public Airport DestinationAirportView { get; set; }
        [ValidateNever]
        public int? CountEmployees { get; set; }
    }
}
