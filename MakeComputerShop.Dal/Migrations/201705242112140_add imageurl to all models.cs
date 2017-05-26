namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimageurltoallmodels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ComputerCasingDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.DriveDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.GraphicsCardDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.HardDriveDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.MotherboardDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.NetworkCardDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.PowerSupplyDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.ProcesorDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.RamDbs", "ImageUrl", c => c.String());
            AddColumn("dbo.SoundCardDbs", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SoundCardDbs", "ImageUrl");
            DropColumn("dbo.RamDbs", "ImageUrl");
            DropColumn("dbo.ProcesorDbs", "ImageUrl");
            DropColumn("dbo.PowerSupplyDbs", "ImageUrl");
            DropColumn("dbo.NetworkCardDbs", "ImageUrl");
            DropColumn("dbo.MotherboardDbs", "ImageUrl");
            DropColumn("dbo.HardDriveDbs", "ImageUrl");
            DropColumn("dbo.GraphicsCardDbs", "ImageUrl");
            DropColumn("dbo.DriveDbs", "ImageUrl");
            DropColumn("dbo.ComputerCasingDbs", "ImageUrl");
        }
    }
}
