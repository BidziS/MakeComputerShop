namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeusermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserDbs", "Email", c => c.String());
            DropColumn("dbo.UserDbs", "LastName");
            DropColumn("dbo.UserDbs", "FirstMidName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDbs", "FirstMidName", c => c.String());
            AddColumn("dbo.UserDbs", "LastName", c => c.String());
            DropColumn("dbo.UserDbs", "Email");
        }
    }
}
