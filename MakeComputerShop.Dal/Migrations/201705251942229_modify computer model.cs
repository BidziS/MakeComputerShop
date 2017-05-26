namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifycomputermodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ComputerDbs", "HardDriveId", "dbo.HardDriveDbs");
            DropIndex("dbo.ComputerDbs", new[] { "HardDriveId" });
            AlterColumn("dbo.ComputerDbs", "HardDriveId", c => c.Int());
            CreateIndex("dbo.ComputerDbs", "HardDriveId");
            AddForeignKey("dbo.ComputerDbs", "HardDriveId", "dbo.HardDriveDbs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComputerDbs", "HardDriveId", "dbo.HardDriveDbs");
            DropIndex("dbo.ComputerDbs", new[] { "HardDriveId" });
            AlterColumn("dbo.ComputerDbs", "HardDriveId", c => c.Int(nullable: false));
            CreateIndex("dbo.ComputerDbs", "HardDriveId");
            AddForeignKey("dbo.ComputerDbs", "HardDriveId", "dbo.HardDriveDbs", "Id", cascadeDelete: true);
        }
    }
}
