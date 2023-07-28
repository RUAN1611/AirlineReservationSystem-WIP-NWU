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
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Status { get; set; }
        [ForeignKey("FlightId")]
        [ValidateNever]
        public Flight Flight { get; set; }
        [ForeignKey("CustomerId")]
        [ValidateNever]
        public Customer Customer { get; set; }
    }
}
