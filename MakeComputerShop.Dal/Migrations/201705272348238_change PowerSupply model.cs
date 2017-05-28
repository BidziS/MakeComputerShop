namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changePowerSupplymodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PowerSupplyDbs", "ProducentId", "dbo.ProducentDbs");
            DropIndex("dbo.PowerSupplyDbs", new[] { "ProducentId" });
            RenameColumn(table: "dbo.PowerSupplyDbs", name: "ProducentId", newName: "Producent_Id");
            AlterColumn("dbo.PowerSupplyDbs", "Producent_Id", c => c.Int());
            CreateIndex("dbo.PowerSupplyDbs", "Producent_Id");
            AddForeignKey("dbo.PowerSupplyDbs", "Producent_Id", "dbo.ProducentDbs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PowerSupplyDbs", "Producent_Id", "dbo.ProducentDbs");
            DropIndex("dbo.PowerSupplyDbs", new[] { "Producent_Id" });
            AlterColumn("dbo.PowerSupplyDbs", "Producent_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.PowerSupplyDbs", name: "Producent_Id", newName: "ProducentId");
            CreateIndex("dbo.PowerSupplyDbs", "ProducentId");
            AddForeignKey("dbo.PowerSupplyDbs", "ProducentId", "dbo.ProducentDbs", "Id", cascadeDelete: true);
        }
    }
}
