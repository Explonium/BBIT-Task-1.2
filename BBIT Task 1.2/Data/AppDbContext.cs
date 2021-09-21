using BBIT_Task_1._2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBIT_Task_1._2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            
        }
    }
}
