namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aftermerge : DbMigration
    {
        public override void Up()
        {

        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PowerSupplyDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Power = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HardDriveDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Capacity = c.Byte(nullable: false),
                        CacheMemory = c.Byte(nullable: false),
                        HardDriveType = c.Int(nullable: false),
                        WidthFormat = c.Double(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComputerCasingDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CasingType = c.Int(nullable: false),
                        ProducentId = c.Int(nullable: false),
                        Width = c.Byte(nullable: false),
                        Height = c.Byte(nullable: false),
                        Depth = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MotherboardDb", "Chipset", c => c.String(nullable: false));
            AddColumn("dbo.MotherboardDb", "Socket", c => c.String(nullable: false));
            DropForeignKey("dbo.ProcesorDb", "Socket_Id", "dbo.SocketDb");
            DropForeignKey("dbo.MotherboardDb", "SocketId", "dbo.SocketDb");
            DropForeignKey("dbo.MotherboardDb", "ChipsetId", "dbo.ChipsetDb");
            DropIndex("dbo.ProcesorDb", new[] { "Socket_Id" });
            DropIndex("dbo.MotherboardDb", new[] { "ChipsetId" });
            DropIndex("dbo.MotherboardDb", new[] { "SocketId" });
            DropColumn("dbo.ProcesorDb", "Socket_Id");
            DropColumn("dbo.MotherboardDb", "ChipsetId");
            DropColumn("dbo.MotherboardDb", "SocketId");
            DropTable("dbo.SocketDb");
            DropTable("dbo.ChipsetDb");
            CreateIndex("dbo.PowerSupplyDb", "ProducentId");
            CreateIndex("dbo.HardDriveDb", "ProducentId");
            CreateIndex("dbo.ComputerCasingDb", "ProducentId");
            AddForeignKey("dbo.PowerSupplyDb", "ProducentId", "dbo.ProducentDb", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HardDriveDb", "ProducentId", "dbo.ProducentDb", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ComputerCasingDb", "ProducentId", "dbo.ProducentDb", "Id", cascadeDelete: true);
        }
    }
}
