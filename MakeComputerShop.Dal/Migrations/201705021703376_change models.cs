namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changemodels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ComputerCasingDb", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.HardDriveDb", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.MotherboardDb", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.PowerSupplyDb", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.ProcesorDb", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.RamDb", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RamDb", "Price");
            DropColumn("dbo.ProcesorDb", "Price");
            DropColumn("dbo.PowerSupplyDb", "Price");
            DropColumn("dbo.MotherboardDb", "Price");
            DropColumn("dbo.HardDriveDb", "Price");
            DropColumn("dbo.ComputerCasingDb", "Price");
        }
    }
}
