namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeusermodelagain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ComputerDbs", "UserDb_Id", "dbo.UserDbs");
            DropIndex("dbo.ComputerDbs", new[] { "UserDb_Id" });
            AddColumn("dbo.UserDbs", "Computer_Id", c => c.Int());
            CreateIndex("dbo.UserDbs", "Computer_Id");
            AddForeignKey("dbo.UserDbs", "Computer_Id", "dbo.ComputerDbs", "Id");
            DropColumn("dbo.ComputerDbs", "UserDb_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ComputerDbs", "UserDb_Id", c => c.Int());
            DropForeignKey("dbo.UserDbs", "Computer_Id", "dbo.ComputerDbs");
            DropIndex("dbo.UserDbs", new[] { "Computer_Id" });
            DropColumn("dbo.UserDbs", "Computer_Id");
            CreateIndex("dbo.ComputerDbs", "UserDb_Id");
            AddForeignKey("dbo.ComputerDbs", "UserDb_Id", "dbo.UserDbs", "Id");
        }
    }
}
