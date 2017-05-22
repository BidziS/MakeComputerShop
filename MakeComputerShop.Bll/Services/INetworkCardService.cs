using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface INetworkCardService
    {
        IEnumerable<NetworkCardDto> GetNetworkCard();
        IEnumerable<NetworkCardDto> GetNetworkCardByProducentId(int producentId);
        NetworkCardDto GetNetworkCardById(int netowrkCardId);
        void InsertNetworkCard(NetworkCardDto networkCard);
        void DeleteNetworkCard(int networkCardId);
        void UpdateNetworkCard(NetworkCardDto networkCard);
        
    }
}
