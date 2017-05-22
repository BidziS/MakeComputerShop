using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using System.Data.Entity;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class PowerSupplyRepository : IGenericRepository<PowerSupplyDb>
    {
        private ShopContext context;

        public PowerSupplyRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<PowerSupplyDb> GetAll()
        {
            return context.PowerSupplies.ToList();
        }

        public PowerSupplyDb GetItemById(int itemId)
        {
            return context.PowerSupplies.Find(itemId);
        }

        public void InsertItem(PowerSupplyDb item)
        {
            context.PowerSupplies.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            PowerSupplyDb powerSupply = GetItemById(itemId);
            if (powerSupply != null) context.PowerSupplies.Remove(powerSupply);
        }

        public void UpdateItem(PowerSupplyDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
