namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmotherboardprocessorramandproducentmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MotherboardDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProducentId = c.Int(nullable: false),
                        Socket = c.String(nullable: false),
                        Chipset = c.String(nullable: false),
                        MaxMemory = c.Int(nullable: false),
                        RAMType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.ProducentDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProcesorDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProducentId = c.Int(nullable: false),
                        NumberOfCores = c.Byte(nullable: false),
                        NumberOfThreads = c.Byte(nullable: false),
                        Cache = c.Byte(nullable: false),
                        Frequency = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProducentDb", t => t.ProducentId, cascadeDelete: true)
                .Index(t => t.ProducentId);
            
            CreateTable(
                "dbo.RamDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        RAMType = c.Int(nullable: false),
                        Frequency = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProcesorDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.MotherboardDb", "ProducentId", "dbo.ProducentDb");
            DropIndex("dbo.ProcesorDb", new[] { "ProducentId" });
            DropIndex("dbo.MotherboardDb", new[] { "ProducentId" });
            DropTable("dbo.RamDb");
            DropTable("dbo.ProcesorDb");
            DropTable("dbo.ProducentDb");
            DropTable("dbo.MotherboardDb");
        }
    }
}
