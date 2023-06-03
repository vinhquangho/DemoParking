namespace DemoParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolisticket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payment", "isTicketMonth", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payment", "isTicketMonth");
        }
    }
}
