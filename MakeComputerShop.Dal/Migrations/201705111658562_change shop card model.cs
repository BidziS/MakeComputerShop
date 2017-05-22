namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeshopcardmodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShopCardItems", "ShopCardListDb_Id", "dbo.ShopCardListDbs");
            DropIndex("dbo.ShopCardItems", new[] { "ShopCardListDb_Id" });
            DropColumn("dbo.ShopCardItems", "ShopCardListDb_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShopCardItems", "ShopCardListDb_Id", c => c.Int());
            CreateIndex("dbo.ShopCardItems", "ShopCardListDb_Id");
            AddForeignKey("dbo.ShopCardItems", "ShopCardListDb_Id", "dbo.ShopCardListDbs", "Id");
        }
    }
}
