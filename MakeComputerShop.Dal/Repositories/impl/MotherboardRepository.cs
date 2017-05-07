using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class MotherboardRepository:DbContext,IMotherboardRepository
    {
        private ShopContext context;

        protected MotherboardRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<MotherboardDb> GetMotherboards()
        {
            return context.Motherboards.ToList();
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
    }
}
