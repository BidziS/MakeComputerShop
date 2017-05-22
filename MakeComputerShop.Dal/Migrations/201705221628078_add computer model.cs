namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcomputermodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComputerDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MotherboardId = c.Int(nullable: false),
                        ProcesorId = c.Int(nullable: false),
                        RamId = c.Int(nullable: false),
                        PowerSupplyId = c.Int(nullable: false),
                        HardDriveId = c.Int(nullable: false),
                        ComputerCasingId = c.Int(nullable: false),
                        DriveId = c.Int(),
                        GraphicsCardId = c.Int(),
                        NetworkCardId = c.Int(),
                        SoundCardId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ComputerCasingDbs", t => t.ComputerCasingId)
                .ForeignKey("dbo.DriveDbs", t => t.DriveId)
                .ForeignKey("dbo.GraphicsCardDbs", t => t.GraphicsCardId)
                .ForeignKey("dbo.HardDriveDbs", t => t.HardDriveId)
                .ForeignKey("dbo.MotherboardDbs", t => t.MotherboardId)
                .ForeignKey("dbo.NetworkCardDbs", t => t.NetworkCardId)
                .ForeignKey("dbo.PowerSupplyDbs", t => t.PowerSupplyId)
                .ForeignKey("dbo.ProcesorDbs", t => t.ProcesorId)
                .ForeignKey("dbo.RamDbs", t => t.RamId)
                .ForeignKey("dbo.SoundCardDbs", t => t.SoundCardId)
                .Index(t => t.MotherboardId)
                .Index(t => t.ProcesorId)
                .Index(t => t.RamId)
                .Index(t => t.PowerSupplyId)
                .Index(t => t.HardDriveId)
                .Index(t => t.ComputerCasingId)
                .Index(t => t.DriveId)
                .Index(t => t.GraphicsCardId)
                .Index(t => t.NetworkCardId)
                .Index(t => t.SoundCardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComputerDbs", "SoundCardId", "dbo.SoundCardDbs");
            DropForeignKey("dbo.ComputerDbs", "RamId", "dbo.RamDbs");
            DropForeignKey("dbo.ComputerDbs", "ProcesorId", "dbo.ProcesorDbs");
            DropForeignKey("dbo.ComputerDbs", "PowerSupplyId", "dbo.PowerSupplyDbs");
            DropForeignKey("dbo.ComputerDbs", "NetworkCardId", "dbo.NetworkCardDbs");
            DropForeignKey("dbo.ComputerDbs", "MotherboardId", "dbo.MotherboardDbs");
            DropForeignKey("dbo.ComputerDbs", "HardDriveId", "dbo.HardDriveDbs");
            DropForeignKey("dbo.ComputerDbs", "GraphicsCardId", "dbo.GraphicsCardDbs");
            DropForeignKey("dbo.ComputerDbs", "DriveId", "dbo.DriveDbs");
            DropForeignKey("dbo.ComputerDbs", "ComputerCasingId", "dbo.ComputerCasingDbs");
            DropIndex("dbo.ComputerDbs", new[] { "SoundCardId" });
            DropIndex("dbo.ComputerDbs", new[] { "NetworkCardId" });
            DropIndex("dbo.ComputerDbs", new[] { "GraphicsCardId" });
            DropIndex("dbo.ComputerDbs", new[] { "DriveId" });
            DropIndex("dbo.ComputerDbs", new[] { "ComputerCasingId" });
            DropIndex("dbo.ComputerDbs", new[] { "HardDriveId" });
            DropIndex("dbo.ComputerDbs", new[] { "PowerSupplyId" });
            DropIndex("dbo.ComputerDbs", new[] { "RamId" });
            DropIndex("dbo.ComputerDbs", new[] { "ProcesorId" });
            DropIndex("dbo.ComputerDbs", new[] { "MotherboardId" });
            DropTable("dbo.ComputerDbs");
        }
    }
}
