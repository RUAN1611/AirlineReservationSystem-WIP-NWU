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
    public class FlightEmployee
    {
        [Key]
        public int FlightId { get; set; }
        [Key]
        public int EmployeeId { get; set;}
        public string JobRole { get; set; }
        [ForeignKey("FlightId")]
        [ValidateNever]
        public Flight Flight { get; set; }
        [ValidateNever]
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
