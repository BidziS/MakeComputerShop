namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifycomputerandusermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ComputerDbs", "Descripton", c => c.String());
            AddColumn("dbo.ComputerDbs", "UserDb_Id", c => c.Int());
            CreateIndex("dbo.ComputerDbs", "UserDb_Id");
            AddForeignKey("dbo.ComputerDbs", "UserDb_Id", "dbo.UserDbs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComputerDbs", "UserDb_Id", "dbo.UserDbs");
            DropIndex("dbo.ComputerDbs", new[] { "UserDb_Id" });
            DropColumn("dbo.ComputerDbs", "UserDb_Id");
            DropColumn("dbo.ComputerDbs", "Descripton");
        }
    }
}
