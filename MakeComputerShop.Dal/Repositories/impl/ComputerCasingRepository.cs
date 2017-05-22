using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;


namespace MakeComputerShop.Dal.Repositories.impl
{
    public class ComputerCasingRepository : IGenericRepository<ComputerCasingDb>
    {
        private ShopContext context;

        public ComputerCasingRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<ComputerCasingDb> GetAll()
        {
            return context.ComputerCasings.ToList();
        }

        public ComputerCasingDb GetItemById(int itemId)
        {
            return context.ComputerCasings.Find(itemId);
        }

        public void InsertItem(ComputerCasingDb item)
        {
            context.ComputerCasings.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            ComputerCasingDb computerCasing = GetItemById(itemId);
            if (computerCasing != null) context.ComputerCasings.Remove(computerCasing);
        }

        public void UpdateItem(ComputerCasingDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
      
    }
}
