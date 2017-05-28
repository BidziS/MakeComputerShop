using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class ProducentRepository:IGenericRepository<ProducentDb>
    {
        private ShopContext context;

        public ProducentRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<ProducentDb> GetAll()
        {
            return context.Producents.ToList();
        }

        public ProducentDb GetItemById(int itemId)
        {
            return context.Producents.Find(itemId);
        }

        public void InsertItem(ProducentDb item)
        {
            context.Producents.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            ProducentDb producent = GetItemById(itemId);
            if (producent != null) context.Producents.Remove(producent);
        }

        public void UpdateItem(ProducentDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }     

    }
}
