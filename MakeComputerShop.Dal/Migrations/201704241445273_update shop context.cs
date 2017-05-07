namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateshopcontext : DbMigration
    {
        public override void Up()
        {
        }

        public override void Down()
        {
            DropForeignKey("dbo.PowerSupplyDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.HardDriveDb", "ProducentId", "dbo.ProducentDb");
            DropForeignKey("dbo.ComputerCasingDb", "ProducentId", "dbo.ProducentDb");
            DropIndex("dbo.PowerSupplyDb", new[] { "ProducentId" });
            DropIndex("dbo.HardDriveDb", new[] { "ProducentId" });
            DropIndex("dbo.ComputerCasingDb", new[] { "ProducentId" });
            DropTable("dbo.PowerSupplyDb");
            DropTable("dbo.HardDriveDb");
            DropTable("dbo.ComputerCasingDb");
        }
    }
}
