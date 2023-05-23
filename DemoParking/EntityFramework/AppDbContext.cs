using DemoParking.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DemoParking.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnectionString")
        {
            
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<EmployeeShift> EmployeeShifts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<InOut> InOuts { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
