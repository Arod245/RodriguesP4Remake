using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RodriguesP4.Models;

namespace RodriguesP4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RodriguesP4.Models.Blog> Blog { get; set; }
        public DbSet<RodriguesP4.Models.Contact> Contact { get; set; }
        public DbSet<RodriguesP4.Models.Education> Education { get; set; }
        public DbSet<RodriguesP4.Models.Experience> Experience { get; set; }
        public DbSet<RodriguesP4.Models.Skill> Skill { get; set; }
        
    }
}
