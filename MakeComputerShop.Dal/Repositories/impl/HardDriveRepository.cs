using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using System.Data.Entity;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class HardDriveRepository : IGenericRepository<HardDriveDb>
    {
        private ShopContext context;

        public HardDriveRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<HardDriveDb> GetAll()
        {
            return context.HardDrives.ToList();
        }

        public HardDriveDb GetItemById(int itemId)
        {
            return context.HardDrives.Include(h => h.Producent).FirstOrDefault(hd => hd.Id == itemId);
        }

        public void InsertItem(HardDriveDb item)
        {
            context.HardDrives.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            HardDriveDb hardDrive = GetItemById(itemId);
            if (hardDrive != null) context.HardDrives.Remove(hardDrive);
        }

        public void UpdateItem(HardDriveDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
