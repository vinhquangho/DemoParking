namespace DemoParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableinout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InOut", "TypeTicket", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InOut", "TypeTicket");
        }
    }
}
