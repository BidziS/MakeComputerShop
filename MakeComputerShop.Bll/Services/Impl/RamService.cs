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
    public class RamService:IGenericService<RamDto>
    {
        private IGenericRepository<RamDb> iRamRepository;

        public RamService(IGenericRepository<RamDb> iRamRepository)
        {
            this.iRamRepository = iRamRepository;
        }

        public IEnumerable<RamDto> GetAll()
        {
            return Mapper.Map<IEnumerable<RamDb>, IEnumerable<RamDto>>(iRamRepository.GetAll());
        }

        public RamDto GetItemById(int ramId)
        {
            return Mapper.Map<RamDb, RamDto>(iRamRepository.GetItemById(ramId));
        }

        public void InsertItem(RamDto ram)
        {
            iRamRepository.InsertItem(Mapper.Map<RamDto,RamDb>(ram));
            iRamRepository.Save();
        }

        public void DeleteItem(int ramId)
        {
            iRamRepository.DeleteItem(ramId);
            iRamRepository.Save();
        }

        public void UpdateItem(RamDto ram)
        {
            iRamRepository.UpdateItem(Mapper.Map<RamDto, RamDb>(ram));
            iRamRepository.Save();
        }
    }
}
