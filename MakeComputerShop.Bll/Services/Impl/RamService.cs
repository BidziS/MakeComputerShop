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
    public class RamService:IRamService
    {
        private IRamRepository iRamRepository;

        public RamService(IRamRepository iRamRepository)
        {
            this.iRamRepository = iRamRepository;
        }

        public IEnumerable<RamDto> GetRams()
        {
            return Mapper.Map<IEnumerable<RamDb>, IEnumerable<RamDto>>(iRamRepository.GetRams());
        }

        public RamDto GetRamById(int ramId)
        {
            return Mapper.Map<RamDb, RamDto>(iRamRepository.GetRamById(ramId));
        }

        public void InsertRam(RamDto ram)
        {
            iRamRepository.InsertRam(Mapper.Map<RamDto,RamDb>(ram));
            iRamRepository.Save();
        }

        public void DeleteRam(int ramId)
        {
            iRamRepository.DeleteRam(ramId);
            iRamRepository.Save();
        }

        public void UpdateRam(RamDto ram)
        {
            iRamRepository.UpdateRam(Mapper.Map<RamDto, RamDb>(ram));
            iRamRepository.Save();
        }
    }
}
