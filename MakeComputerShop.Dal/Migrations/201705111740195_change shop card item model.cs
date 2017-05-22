namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeshopcarditemmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShopCardItems", "ItemId", c => c.Int(nullable: false));
            AddColumn("dbo.ShopCardItems", "ItemType", c => c.Int(nullable: false));
            DropColumn("dbo.ShopCardItems", "Name");
            DropColumn("dbo.ShopCardItems", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShopCardItems", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.ShopCardItems", "Name", c => c.String());
            DropColumn("dbo.ShopCardItems", "ItemType");
            DropColumn("dbo.ShopCardItems", "ItemId");
        }
    }
}
