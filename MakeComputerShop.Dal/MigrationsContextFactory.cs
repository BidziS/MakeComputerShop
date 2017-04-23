using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal
{
    public class MigrationsContextFactory:IDbContextFactory<ShopContext>
    {
        public ShopContext Create()
        {
            return new ShopContext("ComputerShop");
        }
    }
}
