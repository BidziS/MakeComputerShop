namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addshopcardandshopcarditemmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopCardListDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopCardItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        ShopCardListDb_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopCardListDbs", t => t.ShopCardListDb_Id)
                .Index(t => t.ShopCardListDb_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopCardItems", "ShopCardListDb_Id", "dbo.ShopCardListDbs");
            DropIndex("dbo.ShopCardItems", new[] { "ShopCardListDb_Id" });
            DropTable("dbo.ShopCardItems");
            DropTable("dbo.ShopCardListDbs");
        }
    }
}
