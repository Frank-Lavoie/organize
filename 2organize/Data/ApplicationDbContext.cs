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

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}
