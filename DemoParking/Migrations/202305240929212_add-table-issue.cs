namespace DemoParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtableissue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Reason = c.String(),
                        Content = c.String(),
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
            DropForeignKey("dbo.Issues", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.Issues", new[] { "EmployeeId" });
            DropTable("dbo.Issues");
        }
    }
}
