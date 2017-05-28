namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changerepo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PowerSupplyDbs", "Producent_Id", "dbo.ProducentDbs");
            DropIndex("dbo.PowerSupplyDbs", new[] { "Producent_Id" });
            RenameColumn(table: "dbo.PowerSupplyDbs", name: "Producent_Id", newName: "ProducentId");
            AlterColumn("dbo.PowerSupplyDbs", "ProducentId", c => c.Int(nullable: false));
            CreateIndex("dbo.PowerSupplyDbs", "ProducentId");
            AddForeignKey("dbo.PowerSupplyDbs", "ProducentId", "dbo.ProducentDbs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PowerSupplyDbs", "ProducentId", "dbo.ProducentDbs");
            DropIndex("dbo.PowerSupplyDbs", new[] { "ProducentId" });
            AlterColumn("dbo.PowerSupplyDbs", "ProducentId", c => c.Int());
            RenameColumn(table: "dbo.PowerSupplyDbs", name: "ProducentId", newName: "Producent_Id");
            CreateIndex("dbo.PowerSupplyDbs", "Producent_Id");
            AddForeignKey("dbo.PowerSupplyDbs", "Producent_Id", "dbo.ProducentDbs", "Id");
        }
    }
}
