using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        [DisplayName("Aircraft Name")]
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        [DisplayName("Date Registered")]
        public DateTime DateRegistered { get; set; }
        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }
        [DisplayName("Original Price (ZAR)")]
        public decimal OriginalPrice { get; set; }
        [DisplayName("Travel Range (km)")]
        public double TravelRange { get; set; }
        [DisplayName("Max Cruise Speed (km/h)")]
        public double MaxCruiseSpeed { get; set; }
        [DisplayName("Fuel Economy (l/km)")]
        public double FuelEconomy { get; set; }
        [DisplayName("Total No. Of Seats")]
        public int TotalNoOfSeats { get; set; }
    }
}
