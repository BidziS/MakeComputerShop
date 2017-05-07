using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;


namespace MakeComputerShop.Dal.Repositories.impl
{
    public class ComputerCasingRepository : IComputerCasingRepository
    {
        private ShopContext context;

        public ComputerCasingRepository(ShopContext context)
        {
            this.context = context;
        }

        public void DeleteComputerCasing(int computerCasingId)
        {
            ComputerCasingDb computerCasing = GetComputerCasingById(computerCasingId);
            if (computerCasing != null) context.ComputerCasings.Remove(computerCasing);
        }

        public ComputerCasingDb GetComputerCasingById(int computerCasingId)
        {
            return context.ComputerCasings.Find(computerCasingId);
        }

        public IEnumerable<ComputerCasingDb> GetComputerCasings()
        {
            return context.ComputerCasings.ToList();
        }

        public IEnumerable<ComputerCasingDb> GetComputerCasingsByProducentId(int producentId)
        {
            return context.ComputerCasings.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public void InsertComputerCasing(ComputerCasingDb computerCasing)
        {
            context.ComputerCasings.Add(computerCasing);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateComputerCasing(ComputerCasingDb computerCasing)
        {
            context.Entry(computerCasing).State = EntityState.Modified;
        }
    }
}
