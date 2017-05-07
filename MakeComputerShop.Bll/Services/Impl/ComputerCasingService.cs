using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Repositories;
using AutoMapper;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Bll.Services.Impl
{
    public class ComputerCasingService : IComputerCasingService
    {
        private IComputerCasingRepository iComputerCasingRepository;

        public ComputerCasingService(IComputerCasingRepository iComputerCasingRepository)
        {
            this.iComputerCasingRepository = iComputerCasingRepository;
        }

        public void DeleteComputerCasing(int computerCasingId)
        {
            iComputerCasingRepository.DeleteComputerCasing(computerCasingId);
            iComputerCasingRepository.Save();
        }

        public ComputerCasingDto GetComputerCasingById(int computerCasingId)
        {
            return Mapper.Map<ComputerCasingDb, ComputerCasingDto>(iComputerCasingRepository.GetComputerCasingById(computerCasingId));
        }

        public IEnumerable<ComputerCasingDto> GetComputerCasings()
        {
            return Mapper.Map<IEnumerable<ComputerCasingDb>, IEnumerable<ComputerCasingDto>>(iComputerCasingRepository.GetComputerCasings());
        }

        public IEnumerable<ComputerCasingDto> GetComputerCasingsByProducentId(int producentId)
        {
            throw new NotImplementedException();
        }

        public void InsertComputerCasing(ComputerCasingDto computerCasing)
        {
            iComputerCasingRepository.InsertComputerCasing(Mapper.Map<ComputerCasingDto, ComputerCasingDb>(computerCasing));
            iComputerCasingRepository.Save();
        }

        public void UpdateComputerCasing(ComputerCasingDto computerCasing)
        {
            iComputerCasingRepository.UpdateComputerCasing(Mapper.Map<ComputerCasingDto, ComputerCasingDb>(computerCasing));
            iComputerCasingRepository.Save();
        }
    }
}
