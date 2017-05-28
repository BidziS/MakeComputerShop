using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Dal.Models.MotherboardElements;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MakeComputerShop.Dal
{
    public class ShopContext:DbContext
    {
        public ShopContext() :base("ComputerShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        
        //public DbSet<BaseDb> BaseModel { get; set; }

        public DbSet<UserDb> Users { get; set; }
        public DbSet<MotherboardDb> Motherboards { get; set; }
        public DbSet<ProcesorDb> Procesors { get; set; }
        public DbSet<RamDb> Rams { get; set; }
        public DbSet<ProducentDb> Producents { get; set; }
        public DbSet<SocketDb> Sockets { get; set; }
        public DbSet<ChipsetDb> Chipsets { get; set; }
        public DbSet<ComputerCasingDb> ComputerCasings { get; set; }
        public DbSet<HardDriveDb> HardDrives { get; set; }
        public DbSet<PowerSupplyDb> PowerSupplies { get; set; }
        public DbSet<DriveDb> Drives { get ; set; }
        public DbSet<NetworkCardDb> NetworkCards {get; set; }
        public DbSet<SoundCardDb> SoundCards {get; set; }
        public DbSet<GraphicsCardDb> GraphicsCards { get; set; }
        public DbSet<ComputerDb> Computers { get; set; }




        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
        public static ShopContext Create()
        {
            return new ShopContext();
        }

    }
}
