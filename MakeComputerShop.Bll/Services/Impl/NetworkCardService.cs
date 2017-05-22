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
    public class NetworkCardService : IGenericService<NetworkCardDto>
    {
        private IGenericRepository<NetworkCardDb> iNetworkCardRepository;

        public NetworkCardService(IGenericRepository<NetworkCardDb> iNetworkCardRepository)
        {
            this.iNetworkCardRepository = iNetworkCardRepository;
        }

        public IEnumerable<NetworkCardDto> GetAll()
        {
            return Mapper.Map<IEnumerable<NetworkCardDb>, IEnumerable<NetworkCardDto>>(iNetworkCardRepository.GetAll());
        }

        public NetworkCardDto GetItemById(int networkCardId)
        {
            return Mapper.Map<NetworkCardDb, NetworkCardDto>(iNetworkCardRepository.GetItemById(networkCardId));
        }
        public void InsertItem(NetworkCardDto networkCard)
        {
            iNetworkCardRepository.InsertItem(Mapper.Map<NetworkCardDto, NetworkCardDb>(networkCard));
            iNetworkCardRepository.Save();
        }

        public void DeleteItem(int networkCardId)
        {
            iNetworkCardRepository.DeleteItem(networkCardId);
            iNetworkCardRepository.Save();
        }

        public void UpdateItem(NetworkCardDto networkCard)
        {
            iNetworkCardRepository.UpdateItem(Mapper.Map<NetworkCardDto, NetworkCardDb>(networkCard));
            iNetworkCardRepository.Save();
        }

    }
}
