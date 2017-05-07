namespace MakeComputerShop.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addchipsetandsocketmodelsandchangemotherboardandprocesormodels : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.MotherboardDb", name: "Chipset_Id", newName: "ChipsetId");
            RenameColumn(table: "dbo.MotherboardDb", name: "Socket_Id", newName: "SocketId");
            RenameIndex(table: "dbo.MotherboardDb", name: "IX_Socket_Id", newName: "IX_SocketId");
            RenameIndex(table: "dbo.MotherboardDb", name: "IX_Chipset_Id", newName: "IX_ChipsetId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.MotherboardDb", name: "IX_ChipsetId", newName: "IX_Chipset_Id");
            RenameIndex(table: "dbo.MotherboardDb", name: "IX_SocketId", newName: "IX_Socket_Id");
            RenameColumn(table: "dbo.MotherboardDb", name: "SocketId", newName: "Socket_Id");
            RenameColumn(table: "dbo.MotherboardDb", name: "ChipsetId", newName: "Chipset_Id");
        }
    }
}
