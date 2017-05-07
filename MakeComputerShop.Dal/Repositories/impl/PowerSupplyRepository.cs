using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using System.Data.Entity;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class PowerSupplyRepository : IPowerSupplyRepository
    {
        private ShopContext context;

        public PowerSupplyRepository(ShopContext context)
        {
            this.context = context;
        }

        public void DeletePowerSupply(int powerSupplyId)
        {
            PowerSupplyDb powerSupply = GetPowerSupplyById(powerSupplyId);
            if (powerSupply != null) context.PowerSupplies.Remove(powerSupply);
        }

        public IEnumerable<PowerSupplyDb> GetPowerSupliesByProducentId(int producentId)
        {
            return context.PowerSupplies.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public IEnumerable<PowerSupplyDb> GetPowerSupplies()
        {
            return context.PowerSupplies.ToList();
        }

        public PowerSupplyDb GetPowerSupplyById(int powerSupplyId)
        {
            return context.PowerSupplies.Find(powerSupplyId);
        }

        public void InsertPowerSupply(PowerSupplyDb powerSupply)
        {
            context.PowerSupplies.Add(powerSupply);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdatePowerSupply(PowerSupplyDb powerSupply)
        {
            context.Entry(powerSupply).State = EntityState.Modified;
        }
    }
}
