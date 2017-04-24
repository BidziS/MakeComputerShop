namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcomputerCasinghardDriveandpowerSupply : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.PowerSupplyDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Power = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PowerSupplyDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.HardDriveDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.ComputerCasingDb", "ProducentId", "dbo.ProducentDb");
            DropIndex("dbo.PowerSupplyDb", new[] { "ProducentId" });
            DropIndex("dbo.HardDriveDb", new[] { "ProducentId" });
            DropIndex("dbo.ComputerCasingDb", new[] { "ProducentId" });
            DropTable("dbo.PowerSupplyDb");
            DropTable("dbo.HardDriveDb");
            DropTable("dbo.ComputerCasingDb");
        }
    }
}
