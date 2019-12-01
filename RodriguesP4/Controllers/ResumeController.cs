using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RodriguesP4.Data;
using RodriguesP4.Models;

namespace RodriguesP4.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ResumeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(ResumeViewModel resume)
        {
            resume.EducationItems = await _context.Education.ToListAsync();
            resume.SkillItems = await _context.Skill.ToListAsync();
            resume.ExperienceItems = await _context.Experience.ToListAsync();

            return View(resume);
        }

    }
}