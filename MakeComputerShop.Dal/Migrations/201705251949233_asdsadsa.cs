namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdsadsa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ComputerDbs", "ComputerCasingId", "dbo.ComputerCasingDbs");
            DropForeignKey("dbo.ComputerDbs", "MotherboardId", "dbo.MotherboardDbs");
            DropForeignKey("dbo.ComputerDbs", "PowerSupplyId", "dbo.PowerSupplyDbs");
            DropForeignKey("dbo.ComputerDbs", "ProcesorId", "dbo.ProcesorDbs");
            DropForeignKey("dbo.ComputerDbs", "RamId", "dbo.RamDbs");
            DropIndex("dbo.ComputerDbs", new[] { "MotherboardId" });
            DropIndex("dbo.ComputerDbs", new[] { "ProcesorId" });
            DropIndex("dbo.ComputerDbs", new[] { "RamId" });
            DropIndex("dbo.ComputerDbs", new[] { "PowerSupplyId" });
            DropIndex("dbo.ComputerDbs", new[] { "ComputerCasingId" });
            AlterColumn("dbo.ComputerDbs", "MotherboardId", c => c.Int());
            AlterColumn("dbo.ComputerDbs", "ProcesorId", c => c.Int());
            AlterColumn("dbo.ComputerDbs", "RamId", c => c.Int());
            AlterColumn("dbo.ComputerDbs", "PowerSupplyId", c => c.Int());
            AlterColumn("dbo.ComputerDbs", "ComputerCasingId", c => c.Int());
            CreateIndex("dbo.ComputerDbs", "MotherboardId");
            CreateIndex("dbo.ComputerDbs", "ProcesorId");
            CreateIndex("dbo.ComputerDbs", "RamId");
            CreateIndex("dbo.ComputerDbs", "PowerSupplyId");
            CreateIndex("dbo.ComputerDbs", "ComputerCasingId");
            AddForeignKey("dbo.ComputerDbs", "ComputerCasingId", "dbo.ComputerCasingDbs", "Id");
            AddForeignKey("dbo.ComputerDbs", "MotherboardId", "dbo.MotherboardDbs", "Id");
            AddForeignKey("dbo.ComputerDbs", "PowerSupplyId", "dbo.PowerSupplyDbs", "Id");
            AddForeignKey("dbo.ComputerDbs", "ProcesorId", "dbo.ProcesorDbs", "Id");
            AddForeignKey("dbo.ComputerDbs", "RamId", "dbo.RamDbs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComputerDbs", "RamId", "dbo.RamDbs");
            DropForeignKey("dbo.ComputerDbs", "ProcesorId", "dbo.ProcesorDbs");
            DropForeignKey("dbo.ComputerDbs", "PowerSupplyId", "dbo.PowerSupplyDbs");
            DropForeignKey("dbo.ComputerDbs", "MotherboardId", "dbo.MotherboardDbs");
            DropForeignKey("dbo.ComputerDbs", "ComputerCasingId", "dbo.ComputerCasingDbs");
            DropIndex("dbo.ComputerDbs", new[] { "ComputerCasingId" });
            DropIndex("dbo.ComputerDbs", new[] { "PowerSupplyId" });
            DropIndex("dbo.ComputerDbs", new[] { "RamId" });
            DropIndex("dbo.ComputerDbs", new[] { "ProcesorId" });
            DropIndex("dbo.ComputerDbs", new[] { "MotherboardId" });
            AlterColumn("dbo.ComputerDbs", "ComputerCasingId", c => c.Int(nullable: false));
            AlterColumn("dbo.ComputerDbs", "PowerSupplyId", c => c.Int(nullable: false));
            AlterColumn("dbo.ComputerDbs", "RamId", c => c.Int(nullable: false));
            AlterColumn("dbo.ComputerDbs", "ProcesorId", c => c.Int(nullable: false));
            AlterColumn("dbo.ComputerDbs", "MotherboardId", c => c.Int(nullable: false));
            CreateIndex("dbo.ComputerDbs", "ComputerCasingId");
            CreateIndex("dbo.ComputerDbs", "PowerSupplyId");
            CreateIndex("dbo.ComputerDbs", "RamId");
            CreateIndex("dbo.ComputerDbs", "ProcesorId");
            CreateIndex("dbo.ComputerDbs", "MotherboardId");
            AddForeignKey("dbo.ComputerDbs", "RamId", "dbo.RamDbs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ComputerDbs", "ProcesorId", "dbo.ProcesorDbs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ComputerDbs", "PowerSupplyId", "dbo.PowerSupplyDbs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ComputerDbs", "MotherboardId", "dbo.MotherboardDbs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ComputerDbs", "ComputerCasingId", "dbo.ComputerCasingDbs", "Id", cascadeDelete: true);
        }
    }
}
