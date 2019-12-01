using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Models
{
    public class Skill
    {
        [Required]
        public string Description { get; set; }
        public int SkillID { get; set; }
        [Required]
        public string Title { get; set; }


    }
}
