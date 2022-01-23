using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using _2organize.Models;

namespace _2organize.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<HomeTask> HomeTasks { get; set; }
        public DbSet<AssignedTask> AssignedTasks { get; set; }
        public DbSet<Disponibility> Disponibilities { get; set; }
        public DbSet<Family> Families { get; set; }
        //public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<UserExtension> UserExtensions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}
