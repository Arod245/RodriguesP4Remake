using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Models
{
    public class Experience
    {
        [Required]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime End { get; set; }
        public int ExperienceID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Start { get; set; }
        [Required]
        public string Title { get; set; }

       
    }
}
