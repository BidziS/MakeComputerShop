using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface INetworkCardRepository : IDisposable
    {
        IEnumerable<NetworkCardDb> GetNetworkCard();
        IEnumerable<NetworkCardDb> GetNetworkCardByProducentId(int producentId);
        NetworkCardDb GetNetworkCardById(int netowrkCardId);
        void InsertNetworkCard(NetworkCardDb networkCard);
        void DeleteNetworkCard(int networkCardId);
        void UpdateNetworkCard(NetworkCardDb networkCard);
        void Save();
    }
}
