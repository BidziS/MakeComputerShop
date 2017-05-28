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
    public class PowerSupplyService:IGenericService<PowerSupplyDto>
    {
        private IGenericRepository<PowerSupplyDb> PowerSupplyRepository;

        public PowerSupplyService(IGenericRepository<PowerSupplyDb> PowerSupplyRepository)
        {
            this.PowerSupplyRepository = PowerSupplyRepository;
        }

        public IEnumerable<PowerSupplyDto> GetAll()
        {
            return Mapper.Map<IEnumerable<PowerSupplyDb>, IEnumerable<PowerSupplyDto>>(PowerSupplyRepository.GetAll());
        }

        public PowerSupplyDto GetItemById(int powerSupplyId)
        {
            return Mapper.Map<PowerSupplyDb, PowerSupplyDto>(PowerSupplyRepository.GetItemById(powerSupplyId));
        }
        public void InsertItem(PowerSupplyDto graphicCard)
        {
            PowerSupplyRepository.InsertItem(Mapper.Map<PowerSupplyDto, PowerSupplyDb>(graphicCard));
            PowerSupplyRepository.Save();
        }

        public void DeleteItem(int graphicCardId)
        {
            PowerSupplyRepository.DeleteItem(graphicCardId);
            PowerSupplyRepository.Save();
        }

        public void UpdateItem(PowerSupplyDto graphicCard)
        {
            PowerSupplyRepository.UpdateItem(Mapper.Map<PowerSupplyDto, PowerSupplyDb>(graphicCard));
            PowerSupplyRepository.Save();
        }
    }
}
