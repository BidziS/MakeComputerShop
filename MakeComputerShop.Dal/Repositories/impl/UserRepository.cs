using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class UserRepository : IGenericRepository<UserDb>
    {
        ShopContext context;

        public UserRepository(ShopContext context)
        {
            this.context = context;
        }

        public void DeleteItem(int userId)
        {
            UserDb user = GetItemById(userId);
            context.Users.Remove(user);
        }

        public UserDb GetItemById(int userId)
        {
            return context.Users.Find(userId);
        }

        public IEnumerable<UserDb> GetAll()
        {
            return context.Users.ToList();
        }

        public void InsertItem(UserDb user)
        {
            context.Users.Add(user);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateItem(UserDb user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
