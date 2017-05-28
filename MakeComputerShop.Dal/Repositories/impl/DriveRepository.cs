using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class DriveRepository : IGenericRepository<DriveDb>
    {
        private ShopContext context;

        public DriveRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<DriveDb> GetAll()
        {
            return context.Drives.ToList();
        }

        public DriveDb GetItemById(int itemId)
        {
            return context.Drives.Include(d => d.Producent).FirstOrDefault();
        }

        public void InsertItem(DriveDb item)
        {
            context.Drives.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            DriveDb drive = context.Drives.Find(itemId);
            if (drive != null) context.Drives.Remove(drive);
        }

        public void UpdateItem(DriveDb item)
        {
            var entity = context.Drives.Where(c => c.Id == item.Id).AsQueryable().FirstOrDefault();
            if (entity == null)
            {
                context.Drives.Add(item);
            }
            else
            {
                context.Entry(entity).CurrentValues.SetValues(item);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
        
    }
}