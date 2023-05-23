namespace DemoParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablepricelist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PriceList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateIn = c.DateTime(nullable: false),
                        DateOut = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeTicket = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PriceList");
        }
    }
}
