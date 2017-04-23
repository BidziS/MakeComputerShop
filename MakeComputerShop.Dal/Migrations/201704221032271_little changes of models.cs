namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class littlechangesofmodels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RamDb", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RamDb", "Name", c => c.Int(nullable: false));
        }
    }
}
