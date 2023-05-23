namespace DemoParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Status = c.Short(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeShifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        ShiftId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Shifts", t => t.ShiftId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ShiftId);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HourStart = c.DateTime(nullable: false),
                        HourEnd = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InOut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        DateIn = c.DateTime(nullable: false),
                        DateOut = c.DateTime(),
                        IsTicket = c.Boolean(nullable: false),
                        Status = c.Short(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeeId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Ticket",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeTicket = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ticket", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Payment", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.InOut", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.EmployeeShifts", "ShiftId", "dbo.Shifts");
            DropForeignKey("dbo.EmployeeShifts", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.Ticket", new[] { "EmployeeId" });
            DropIndex("dbo.Payment", new[] { "EmployeeId" });
            DropIndex("dbo.InOut", new[] { "EmployeeId" });
            DropIndex("dbo.EmployeeShifts", new[] { "ShiftId" });
            DropIndex("dbo.EmployeeShifts", new[] { "EmployeeId" });
            DropTable("dbo.Ticket");
            DropTable("dbo.Payment");
            DropTable("dbo.InOut");
            DropTable("dbo.Shifts");
            DropTable("dbo.EmployeeShifts");
            DropTable("dbo.Employee");
        }
    }
}
