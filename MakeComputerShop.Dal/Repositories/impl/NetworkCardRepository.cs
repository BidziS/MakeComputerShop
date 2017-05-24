using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class NetworkCardRepository : INetworkCardRepository
    {
        private ShopContext context;

        private IDriveRepository iDriveRepository;

        public NetworkCardRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<NetworkCardDb> GetNetworkCard()
        {
            return context.NetworkCards.ToList();
        }

        public IEnumerable<NetworkCardDb> GetNetworkCardByProducentId(int producentId)
        {
            return context.NetworkCards.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public NetworkCardDb GetNetworkCardById(int netowrkCardId)
        {
            return context.NetworkCards.Find(netowrkCardId);
        }

        public void InsertNetworkCard(NetworkCardDb networkCard)
        {
            context.NetworkCards.Add(networkCard);
        }

        public void DeleteNetworkCard(int networkCardId)
        {
            NetworkCardDb networkCard = context.NetworkCards.Find(networkCardId);
            if (networkCard != null) context.NetworkCards.Remove(networkCard);
        }

        public void UpdateNetworkCard(NetworkCardDb networkCard)
        {
            context.Entry(networkCard).State = EntityState.Modified;
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
