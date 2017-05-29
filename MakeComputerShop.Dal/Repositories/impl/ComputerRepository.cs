using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class ComputerRepository:IGenericRepository<ComputerDb>
    {
        private ShopContext context;

        public ComputerRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<ComputerDb> GetAll()
        {
            return context.Computers.Include(c => c.ComputerCasing).Include(c => c.Drive).Include(c => c.Motherboard).ToList();
        }

        public ComputerDb GetItemById(int itemId)
        {
            return context.Computers.Include(c => c.ComputerCasing)
                .Include(c => c.Drive)
                .Include(c => c.Motherboard.Producent)
                .SingleOrDefault(c => c.Id == itemId);
        }

        public void InsertItem(ComputerDb item)
        {
            context.Computers.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            ComputerDb computer = context.Computers.Find(itemId);
            if (computer != null) context.Computers.Remove(computer);
        }

        public void UpdateItem(ComputerDb item)
        {
            var entity = context.Computers.Where(c => c.Id == item.Id).AsQueryable().FirstOrDefault();
            if (entity == null)
            {
                context.Computers.Add(item);
            }
            else
            {
                context.Entry(entity).CurrentValues.SetValues(item);
            }
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
