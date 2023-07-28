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
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int SeatNo { get; set; }
        public int ReservationId { get; set; }
        public decimal Price { get; set; }
        public bool IsAdult { get; set; }
        [ForeignKey(nameof(ReservationId))]
        [ValidateNever]
        public Reservation Reservation { get; set; }
    }
}
