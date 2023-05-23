namespace DemoParking.Migrations
{
    using DemoParking.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoParking.EntityFramework.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DemoParking.EntityFramework.AppDbContext context)
        {
            context.Employee.AddOrUpdate(x => x.Id, new Employee()
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
        }
    }
}
