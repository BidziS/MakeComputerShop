namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodels : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.GraphicsCardDbs", "ChipsetId");
            AddForeignKey("dbo.GraphicsCardDbs", "ChipsetId", "dbo.ChipsetDbs", "Id", cascadeDelete: true);
            DropColumn("dbo.GraphicsCardDbs", "ChipsetName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GraphicsCardDbs", "ChipsetName", c => c.String(nullable: false));
            DropForeignKey("dbo.GraphicsCardDbs", "ChipsetId", "dbo.ChipsetDbs");
            DropIndex("dbo.GraphicsCardDbs", new[] { "ChipsetId" });
        }
    }
}
