using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public int AircraftId { get; set; }
        [ForeignKey(nameof(AircraftId))]
        [ValidateNever]
        public Aircraft Aircraft { get; set;}
        public int OriginAirportId { get; set; }
        [ForeignKey(nameof(OriginAirportId))]
        [ValidateNever]
        public Airport OriginAirport { get; set; }
        public int DestinationAirportId { get; set; }
        [ForeignKey(nameof(DestinationAirportId))]
        [ValidateNever]
        public Airport DestinationAirport { get; set;}
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string? Status { get; set; }
    }
}
