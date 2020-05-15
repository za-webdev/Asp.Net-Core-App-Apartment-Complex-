using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Models
{
    public class Owner
    {
        public int? Id { get; set; }
        //[Required]
        //[MinLength(3, ErrorMessage = "Firt name cannot be less than 3 characters")]
        public string FirstName { get; set; }
        //[Required]
        //[MinLength(3, ErrorMessage = "Firt name cannot be less than 3 characters")]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        [RegularExpression (@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",ErrorMessage ="Invalid Email format") ]
        public string Email { get; set; }
        public string UnitNumber { get; set; }
        public string ApartmentNumber { get; set; }
        [Required]
        [MinLength(8,ErrorMessage ="Password cannot be less than 8 characters")]
        public string Password { get; set; }
    }
}
