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
            Database.SetInitializer(new DBInitializer());
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<EmployeeShift> EmployeeShifts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<InOut> InOuts { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
    public class DBInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            IList<Employee> defaultStandards = new List<Employee>();
            defaultStandards.Add(new Employee()
            {
                Id = 1,
                Code = "NV-Admin",
                Name = "Admin",
                Address = "An Giang",
                Phone = "0362998278",
                Status = Status.Active,
                UserName = "admin",
                Password = "123qwe",
                BirthDay = DateTime.Now,
                IsDeleted = false,
                CreationTime = DateTime.Now,
            });
            context.Employee.AddRange(defaultStandards);
            base.Seed(context);
        }
    }
}
