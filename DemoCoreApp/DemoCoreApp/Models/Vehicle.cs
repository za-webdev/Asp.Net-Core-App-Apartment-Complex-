using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Models
{
    public class Vehicle
    {
        public int? VehicleId { get; set; }
        [Required(ErrorMessage = "*")]
        public string Color { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int? VehicleOwnerId { get; set; }
    }
}
