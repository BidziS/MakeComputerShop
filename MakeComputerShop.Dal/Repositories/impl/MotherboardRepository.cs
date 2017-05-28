using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class MotherboardRepository:IGenericRepository<MotherboardDb>
    {
        private ShopContext context;

        public MotherboardRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<MotherboardDb> GetAll()
        {
            return context.Motherboards
                .Include(m => m.Socket)
                .Include(m => m.Chipset)
                .ToList();
        }

        public MotherboardDb GetItemById(int itemId)
        {
            return context.Motherboards
                .Include(m => m.Producent)
                .Include(m => m.Socket)
                .Include(m => m.Chipset)
                .SingleOrDefault(m => m.Id == itemId);
        }

        public void InsertItem(MotherboardDb item)
        {
            context.Motherboards.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            MotherboardDb motherboard = context.Motherboards.Find(itemId);
            if (motherboard != null) context.Motherboards.Remove(motherboard);
        }

        public void UpdateItem(MotherboardDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }       
    }
}
