namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComputerDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripton = c.String(),
                        MotherboardId = c.Int(),
                        ProcesorId = c.Int(),
                        RamId = c.Int(),
                        PowerSupplyId = c.Int(),
                        HardDriveId = c.Int(),
                        ComputerCasingId = c.Int(),
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
            
            AddColumn("dbo.ComputerCasingDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.DriveDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.GraphicsCardDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.HardDriveDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.MotherboardDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.NetworkCardDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.PowerSupplyDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.ProcesorDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.RamDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.SoundCardDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.UserDbs", "Email", c => c.String());
            AddColumn("dbo.UserDbs", "Computer_Id", c => c.Int());
            CreateIndex("dbo.UserDbs", "Computer_Id");
            AddForeignKey("dbo.UserDbs", "Computer_Id", "dbo.ComputerDbs", "Id");
            DropColumn("dbo.UserDbs", "LastName");
            DropColumn("dbo.UserDbs", "FirstMidName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDbs", "FirstMidName", c => c.String());
            AddColumn("dbo.UserDbs", "LastName", c => c.String());
            DropForeignKey("dbo.UserDbs", "Computer_Id", "dbo.ComputerDbs");
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
            DropIndex("dbo.UserDbs", new[] { "Computer_Id" });
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
            DropColumn("dbo.UserDbs", "Computer_Id");
            DropColumn("dbo.UserDbs", "Email");
            DropColumn("dbo.SoundCardDbs", "ImageUrl");
            DropColumn("dbo.RamDbs", "ImageUrl");
            DropColumn("dbo.ProcesorDbs", "ImageUrl");
            DropColumn("dbo.PowerSupplyDbs", "ImageUrl");
            DropColumn("dbo.NetworkCardDbs", "ImageUrl");
            DropColumn("dbo.MotherboardDbs", "ImageUrl");
            DropColumn("dbo.HardDriveDbs", "ImageUrl");
            DropColumn("dbo.GraphicsCardDbs", "ImageUrl");
            DropColumn("dbo.DriveDbs", "ImageUrl");
            DropColumn("dbo.ComputerCasingDbs", "ImageUrl");
            DropTable("dbo.ComputerDbs");
        }
    }
}
