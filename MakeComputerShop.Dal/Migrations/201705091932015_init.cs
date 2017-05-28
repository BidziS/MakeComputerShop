namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChipsetDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComputerCasingDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CasingType = c.Int(nullable: false),
                        ProducentId = c.Int(nullable: false),
                        Width = c.Byte(nullable: false),
                        Height = c.Byte(nullable: false),
                        Depth = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.ProducentDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DriveDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        DriverTypes = c.Int(nullable: false),
                        AccessTime = c.Int(nullable: false),
                        Interface = c.String(),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.GraphicsCardDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        ChipsetName = c.String(nullable: false),
                        ChipsetId = c.Int(nullable: false),
                        MemorySize = c.Int(nullable: false),
                        DataBusBit = c.Int(nullable: false),
                        Connector = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.HardDriveDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Capacity = c.Byte(nullable: false),
                        CacheMemory = c.Byte(nullable: false),
                        HardDriveType = c.Int(nullable: false),
                        WidthFormat = c.Double(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.MotherboardDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        SocketId = c.Int(nullable: false),
                        ChipsetId = c.Int(nullable: false),
                        MaxMemory = c.Int(nullable: false),
                        RAMType = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChipsetDbs", t => t.ChipsetId, cascadeDelete: true)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .ForeignKey("dbo.SocketDbs", t => t.SocketId, cascadeDelete: true)
                .Index(t => t.ProducentId)
                .Index(t => t.SocketId)
                .Index(t => t.ChipsetId);
            
            CreateTable(
                "dbo.SocketDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NetworkCardDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Standard = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.PowerSupplyDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Power = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.ProcesorDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        NumberOfCores = c.Byte(nullable: false),
                        NumberOfThreads = c.Byte(nullable: false),
                        Cache = c.Byte(nullable: false),
                        Frequency = c.Double(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Socket_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .ForeignKey("dbo.SocketDbs", t => t.Socket_Id, cascadeDelete: true)
                .Index(t => t.ProducentId)
                .Index(t => t.Socket_Id);
            
            CreateTable(
                "dbo.RamDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RAMType = c.Int(nullable: false),
                        Frequency = c.Double(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SoundCardDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Interface = c.String(nullable: false),
                        SoundSystem = c.Single(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDbs", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.UserDbs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoundCardDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.ProcesorDbs", "Socket_Id", "dbo.SocketDbs");
            DropForeignKey("dbo.ProcesorDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.PowerSupplyDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.NetworkCardDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.MotherboardDbs", "SocketId", "dbo.SocketDbs");
            DropForeignKey("dbo.MotherboardDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.MotherboardDbs", "ChipsetId", "dbo.ChipsetDbs");
            DropForeignKey("dbo.HardDriveDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.GraphicsCardDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.DriveDbs", "ProducentId", "dbo.ProducentDbs");
            DropForeignKey("dbo.ComputerCasingDbs", "ProducentId", "dbo.ProducentDbs");
            DropIndex("dbo.SoundCardDbs", new[] { "ProducentId" });
            DropIndex("dbo.ProcesorDbs", new[] { "Socket_Id" });
            DropIndex("dbo.ProcesorDbs", new[] { "ProducentId" });
            DropIndex("dbo.PowerSupplyDbs", new[] { "ProducentId" });
            DropIndex("dbo.NetworkCardDbs", new[] { "ProducentId" });
            DropIndex("dbo.MotherboardDbs", new[] { "ChipsetId" });
            DropIndex("dbo.MotherboardDbs", new[] { "SocketId" });
            DropIndex("dbo.MotherboardDbs", new[] { "ProducentId" });
            DropIndex("dbo.HardDriveDbs", new[] { "ProducentId" });
            DropIndex("dbo.GraphicsCardDbs", new[] { "ProducentId" });
            DropIndex("dbo.DriveDbs", new[] { "ProducentId" });
            DropIndex("dbo.ComputerCasingDbs", new[] { "ProducentId" });
            DropTable("dbo.UserDbs");
            DropTable("dbo.SoundCardDbs");
            DropTable("dbo.RamDbs");
            DropTable("dbo.ProcesorDbs");
            DropTable("dbo.PowerSupplyDbs");
            DropTable("dbo.NetworkCardDbs");
            DropTable("dbo.SocketDbs");
            DropTable("dbo.MotherboardDbs");
            DropTable("dbo.HardDriveDbs");
            DropTable("dbo.GraphicsCardDbs");
            DropTable("dbo.DriveDbs");
            DropTable("dbo.ProducentDbs");
            DropTable("dbo.ComputerCasingDbs");
            DropTable("dbo.ChipsetDbs");
        }
    }
}
