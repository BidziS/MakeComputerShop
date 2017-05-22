using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class RamRepository:IGenericRepository<RamDb>
    {
        private ShopContext context;

        public RamRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<RamDb> GetAll()
        {
            return context.Rams.ToList();
        }

        public RamDb GetItemById(int ramId)
        {
            return context.Rams.Find(ramId);
        }

        public void InsertItem(RamDb ram)
        {
            context.Rams.Add(ram);
        }

        public void DeleteItem(int ramId)
        {
            RamDb ram = GetItemById(ramId);
            if (ram != null) context.Rams.Remove(ram);
        }

        public void UpdateItem(RamDb ram)
        {
            context.Entry(ram).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
