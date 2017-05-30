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
        private IGenericRepository<PowerSupplyDb> iHardDriveRepository;

        public PowerSupplyService(IGenericRepository<PowerSupplyDb> iHardDriveRepository)
        {
            this.iHardDriveRepository = iHardDriveRepository;
        }

        public IEnumerable<PowerSupplyDto> GetAll()
        {
            return Mapper.Map<IEnumerable<PowerSupplyDb>, IEnumerable<PowerSupplyDto>>(iHardDriveRepository.GetAll());
        }

        public PowerSupplyDto GetItemById(int itemId)
        {
            return Mapper.Map<PowerSupplyDb, PowerSupplyDto>(iHardDriveRepository.GetItemById(itemId));
        }
        public void InsertItem(PowerSupplyDto item)
        {
            iHardDriveRepository.InsertItem(Mapper.Map<PowerSupplyDto, PowerSupplyDb>(item));
            iHardDriveRepository.Save();
        }

        public void DeleteItem(int itemId)
        {
            iHardDriveRepository.DeleteItem(itemId);
            iHardDriveRepository.Save();
        }

        public void UpdateItem(PowerSupplyDto item)
        {
            iHardDriveRepository.UpdateItem(Mapper.Map<PowerSupplyDto, PowerSupplyDb>(item));
            iHardDriveRepository.Save();
        }
    }
}
