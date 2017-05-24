namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aftermergemigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DriveDb",
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
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.GraphicsCardDb",
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
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.NetworkCardDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducentId = c.Int(nullable: false),
                        Standard = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.SoundCardDb",
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
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoundCardDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.NetworkCardDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.GraphicsCardDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.DriveDb", "ProducentId", "dbo.ProducentDb");
            DropIndex("dbo.SoundCardDb", new[] { "ProducentId" });
            DropIndex("dbo.NetworkCardDb", new[] { "ProducentId" });
            DropIndex("dbo.GraphicsCardDb", new[] { "ProducentId" });
            DropIndex("dbo.DriveDb", new[] { "ProducentId" });
            DropTable("dbo.SoundCardDb");
            DropTable("dbo.NetworkCardDb");
            DropTable("dbo.GraphicsCardDb");
            DropTable("dbo.DriveDb");
        }
    }
}
