using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal
{
    public class ShopContext:DbContext
    {
        public ShopContext(string connectionString):base(connectionString)
        {
        }

        public DbSet<UserDb> Users { get; set; }
        public DbSet<MotherboardDb> Motherboards { get; set; }
        public DbSet<ProcesorDb> Procesors { get; set; }
        public DbSet<RamDb> Rams { get; set; }
        public DbSet<ProducentDb> Producents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
