using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class NetworkCardRepository : IGenericRepository<NetworkCardDb>
    {
        private ShopContext context;

        public NetworkCardRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<NetworkCardDb> GetAll()
        {
            return context.NetworkCards.ToList();
        }

        public NetworkCardDb GetItemById(int itemId)
        {
            return context.NetworkCards.Include(n => n.Producent).FirstOrDefault(nc => nc.Id == itemId);
        }

        public void InsertItem(NetworkCardDb item)
        {
            context.NetworkCards.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            NetworkCardDb networkCard = context.NetworkCards.Find(itemId);
            if (networkCard != null) context.NetworkCards.Remove(networkCard);
        }

        public void UpdateItem(NetworkCardDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }


    }
}
