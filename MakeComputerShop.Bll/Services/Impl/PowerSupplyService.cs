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
        private IGenericRepository<PowerSupplyDb> iGraphicCardRepository;

        public PowerSupplyService(IGenericRepository<PowerSupplyDb> iGraphicCardRepository)
        {
            this.iGraphicCardRepository = iGraphicCardRepository;
        }

        public IEnumerable<PowerSupplyDto> GetAll()
        {
            return Mapper.Map<IEnumerable<PowerSupplyDb>, IEnumerable<PowerSupplyDto>>(iGraphicCardRepository.GetAll());
        }

        public PowerSupplyDto GetItemById(int graphicCardId)
        {
            return Mapper.Map<PowerSupplyDb, PowerSupplyDto>(iGraphicCardRepository.GetItemById(graphicCardId));
        }
        public void InsertItem(PowerSupplyDto graphicCard)
        {
            iGraphicCardRepository.InsertItem(Mapper.Map<PowerSupplyDto, PowerSupplyDb>(graphicCard));
            iGraphicCardRepository.Save();
        }

        public void DeleteItem(int graphicCardId)
        {
            iGraphicCardRepository.DeleteItem(graphicCardId);
            iGraphicCardRepository.Save();
        }

        public void UpdateItem(PowerSupplyDto graphicCard)
        {
            iGraphicCardRepository.UpdateItem(Mapper.Map<PowerSupplyDto, PowerSupplyDb>(graphicCard));
            iGraphicCardRepository.Save();
        }
    }
}
