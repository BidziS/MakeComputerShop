namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsocketandchipsetmodelsandchangeprocesorandmotherboardmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChipsetDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SocketDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MotherboardDb", "Chipset_Id", c => c.Int(nullable: false));
            AddColumn("dbo.MotherboardDb", "Socket_Id", c => c.Int(nullable: false));
            AddColumn("dbo.ProcesorDb", "Socket_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MotherboardDb", "Chipset_Id");
            CreateIndex("dbo.MotherboardDb", "Socket_Id");
            CreateIndex("dbo.ProcesorDb", "Socket_Id");
            AddForeignKey("dbo.MotherboardDb", "Chipset_Id", "dbo.ChipsetDb", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MotherboardDb", "Socket_Id", "dbo.SocketDb", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProcesorDb", "Socket_Id", "dbo.SocketDb", "Id", cascadeDelete: true);
            DropColumn("dbo.MotherboardDb", "Socket");
            DropColumn("dbo.MotherboardDb", "Chipset");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MotherboardDb", "Chipset", c => c.String(nullable: false));
            AddColumn("dbo.MotherboardDb", "Socket", c => c.String(nullable: false));
            DropForeignKey("dbo.ProcesorDb", "Socket_Id", "dbo.SocketDb");
            DropForeignKey("dbo.MotherboardDb", "Socket_Id", "dbo.SocketDb");
            DropForeignKey("dbo.MotherboardDb", "Chipset_Id", "dbo.ChipsetDb");
            DropIndex("dbo.ProcesorDb", new[] { "Socket_Id" });
            DropIndex("dbo.MotherboardDb", new[] { "Socket_Id" });
            DropIndex("dbo.MotherboardDb", new[] { "Chipset_Id" });
            DropColumn("dbo.ProcesorDb", "Socket_Id");
            DropColumn("dbo.MotherboardDb", "Socket_Id");
            DropColumn("dbo.MotherboardDb", "Chipset_Id");
            DropTable("dbo.SocketDb");
            DropTable("dbo.ChipsetDb");
        }
    }
}
