using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }

    }
}
