using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class RamRepository:IRamRepository
    {
        private ShopContext context;

        public RamRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<RamDb> GetRams()
        {
            return context.Rams.ToList();
        }

        public RamDb GetRamById(int ramId)
        {
            return context.Rams.Find(ramId);
        }

        public void InsertRam(RamDb ram)
        {
            context.Rams.Add(ram);
        }

        public void DeleteRam(int ramId)
        {
            RamDb ram = GetRamById(ramId);
            if (ram != null) context.Rams.Remove(ram);
        }

        public void UpdateRam(RamDb ram)
        {
            context.Entry(ram).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
