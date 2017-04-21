using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var users = new List<UserDb>()
            {
                new UserDb(){LastName = "Cudnik", FirstMidName = "Daniel"},
                new UserDb(){LastName = "Cybulski", FirstMidName = "Radosław"},
                new UserDb(){LastName = "Witka", FirstMidName = "Kamil"}
                
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}
