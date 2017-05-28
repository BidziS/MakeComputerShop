using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class ProcesorRepository:IGenericRepository<ProcesorDb>
    {
        private ShopContext context;

        public ProcesorRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<ProcesorDb> GetAll()
        {
            return context.Procesors.ToList();
        }

        public ProcesorDb GetItemById(int itemId)
        {
            return context.Procesors
                .Include(p => p.Producent)
                .Include(p => p.Socket)
                .FirstOrDefault();
        }

        public void InsertItem(ProcesorDb item)
        {
            context.Procesors.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            ProcesorDb procesor = GetItemById(itemId);
            if (procesor != null) context.Procesors.Remove(procesor);
        }

        public void UpdateItem(ProcesorDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
