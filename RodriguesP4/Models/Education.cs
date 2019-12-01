using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Models
{
    public class Education
    {
        [Required]
        public String Degree { get; set; }
        public int EducationId { get; set; }
        [DataType(DataType.Date)]
        public DateTime End { get; set; }
        [Required]
        public string School { get; set; }
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }    
    }
}
