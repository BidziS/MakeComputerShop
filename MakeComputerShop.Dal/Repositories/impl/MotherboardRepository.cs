using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class MotherboardRepository:IMotherboardRepository
    {
        private ShopContext context;

        private IProducentRepository iProducentRepository;

        public MotherboardRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<MotherboardDb> GetMotherboards()
        {
            return context.Motherboards.ToList();
        }

        public IEnumerable<MotherboardDb> GetMotherboardsByProducentId(int producentId)
        {
            return context.Motherboards.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public IEnumerable<MotherboardDb> GetMotherboardsBySocket(int socketId)
        {
            return context.Motherboards.Include(m => m.Socket).Where(m => m.SocketId == socketId);
        }

        public IEnumerable<MotherboardDb> GetMotherboardsByChipset(int chipsetId)
        {
            return context.Motherboards.Include(m => m.Chipset).Where(m => m.ChipsetId == chipsetId);
        }

        public MotherboardDb GetMotherboardById(int motherboardId)
        {
            return context.Motherboards.Find(motherboardId);
        }

        public void InsertMotherboard(MotherboardDb motherboard)
        {
            context.Motherboards.Add(motherboard);
        }

        public void DeleteMotherboard(int motherboardId)
        {
            MotherboardDb motherboard = context.Motherboards.Find(motherboardId);
            if (motherboard != null) context.Motherboards.Remove(motherboard);
        }

        public void UpdateMotherboard(MotherboardDb motherboard)
        {
            context.Entry(motherboard).State = EntityState.Modified;
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
