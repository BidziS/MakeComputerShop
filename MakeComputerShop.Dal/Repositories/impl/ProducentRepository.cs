using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class ProducentRepository:IProducentRepository
    {
        private ShopContext context;

        public ProducentRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<ProducentDb> GetProducents()
        {
            return context.Producents.ToList();
        }

        public ProducentDb GetProducentById(int producentId)
        {
            return context.Producents.Find(producentId);
        }

        public void InsertProducent(ProducentDb producent)
        {
            context.Producents.Add(producent);
        }

        public void DeleteProducent(int producentId)
        {
            ProducentDb producent = context.Producents.Find(producentId);
            if (producent != null) context.Producents.Remove(producent);
        }

        public void UpdateProducent(ProducentDb producent)
        {
            context.Entry(producent).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
