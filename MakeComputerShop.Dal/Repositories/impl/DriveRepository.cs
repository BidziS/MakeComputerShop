using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class DriveRepository : IDriveRepository
    {
        private ShopContext context;

        private IDriveRepository iDriveRepository;

        public DriveRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<DriveDb> GetDrives()
        {
            return context.Drives.ToList();
        }

        public IEnumerable<DriveDb> GetDrivesByProducentId(int producentId)
        {
            return context.Drives.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public DriveDb GetDriveById(int driveId)
        {
            return context.Drives.Find(driveId);
        }

        public void InsertDrive(DriveDb drive)
        {
            context.Drives.Add(drive);
        }

        public void DeleteDrive(int driveId)
        {
            DriveDb drive = context.Drives.Find(driveId);
            if (drive != null) context.Drives.Remove(drive);
        }

        public void UpdateDrive(DriveDb drive)
        {
            context.Entry(drive).State = EntityState.Modified;
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