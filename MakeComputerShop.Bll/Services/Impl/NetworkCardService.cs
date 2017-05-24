using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Dal.Repositories;


namespace MakeComputerShop.Bll.Services.Impl
{
    public class NetworkCardService : INetworkCardService
    {
        private INetworkCardRepository iNetworkCardRepository;

        public NetworkCardService(INetworkCardRepository inetworkCardRepository)
        {
            this.iNetworkCardRepository = inetworkCardRepository;
        }

        public IEnumerable<NetworkCardDto> GetNetworkCard()
        {
            return Mapper.Map<IEnumerable<NetworkCardDb>, IEnumerable<NetworkCardDto>>(iNetworkCardRepository.GetNetworkCard());
        }

        public IEnumerable<NetworkCardDto> GetNetworkCardByProducentId(int producentId)
        {
            return Mapper.Map<IEnumerable<NetworkCardDb>, IEnumerable<NetworkCardDto>>(iNetworkCardRepository.GetNetworkCardByProducentId(producentId));
        }

        public NetworkCardDto GetNetworkCardById(int networkCardId)
        {
            return Mapper.Map<NetworkCardDb, NetworkCardDto>(iNetworkCardRepository.GetNetworkCardById(networkCardId));
        }
        public void InsertNetworkCard(NetworkCardDto networkCard)
        {
            iNetworkCardRepository.InsertNetworkCard(Mapper.Map<NetworkCardDto, NetworkCardDb>(networkCard));
            iNetworkCardRepository.Save();
        }

        public void DeleteNetworkCard(int networkCardId)
        {
            iNetworkCardRepository.DeleteNetworkCard(networkCardId);
            iNetworkCardRepository.Save();
        }

        public void UpdateNetworkCard(NetworkCardDto networkCard)
        {
            iNetworkCardRepository.UpdateNetworkCard(Mapper.Map<NetworkCardDto, NetworkCardDb>(networkCard));
            iNetworkCardRepository.Save();
        }



    }
}
