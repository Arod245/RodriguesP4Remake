using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Comments { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        public bool IsPhoneApp { get; set; }
        public bool IsWebApp { get; set; }
        public bool IsWindowsApp { get; set; }
        [Required]
        public string LastName { get; set; }
        public string TypeOfRequest { get; set; }



    }
}
