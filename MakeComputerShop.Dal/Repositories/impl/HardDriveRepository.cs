using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using System.Data.Entity;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class HardDriveRepository : IHardDriveRepository
    {
        private ShopContext context;

        public HardDriveRepository(ShopContext context)
        {
            this.context = context;
        }

        public void DeleteHardDrive(int hardDriveId)
        {
            HardDriveDb hardDrive = GetHardDriveById(hardDriveId);
            if (hardDrive != null) context.HardDrives.Remove(hardDrive);
        }

        public HardDriveDb GetHardDriveById(int hardDriveId)
        {
            return context.HardDrives.Find(hardDriveId);
        }

        public IEnumerable<HardDriveDb> GetHardDrives()
        {
            return context.HardDrives.ToList();
        }

        public IEnumerable<HardDriveDb> GetHardDrivesByProducentId(int producentId)
        {
            return context.HardDrives.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public void InsertHardDrive(HardDriveDb hardDrive)
        {
            context.HardDrives.Add(hardDrive);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateHardDrive(HardDriveDb hardDrive)
        {
            context.Entry(hardDrive).State = EntityState.Modified;
        }
    }
}
