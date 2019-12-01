using RodriguesP4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguesP4.Models
{
    public class ResumeViewModel
    {

        public List<Education> EducationItems { get;  set; }
        public List<Experience> ExperienceItems { get; set; }
        public List<Skill> SkillItems { get; set; }
        
        public ResumeViewModel() {
            
        }

    }
}
