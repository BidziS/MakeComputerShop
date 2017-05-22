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
    public class ComputerCasingService : IGenericService<ComputerCasingDto>
    {
        private IGenericRepository<ComputerCasingDb> iComputerCasingRepository;

        public ComputerCasingService(IGenericRepository<ComputerCasingDb> iComputerCasingRepository)
        {
            this.iComputerCasingRepository = iComputerCasingRepository;
        }

        public void DeleteItem(int computerCasingId)
        {
            iComputerCasingRepository.DeleteItem(computerCasingId);
            iComputerCasingRepository.Save();
        }

        public ComputerCasingDto GetItemById(int computerCasingId)
        {
            return Mapper.Map<ComputerCasingDb, ComputerCasingDto>(iComputerCasingRepository.GetItemById(computerCasingId));
        }

        public IEnumerable<ComputerCasingDto> GetAll()
        {
            return Mapper.Map<IEnumerable<ComputerCasingDb>, IEnumerable<ComputerCasingDto>>(iComputerCasingRepository.GetAll());
        }


        public void InsertItem(ComputerCasingDto computerCasing)
        {
            iComputerCasingRepository.InsertItem(Mapper.Map<ComputerCasingDto, ComputerCasingDb>(computerCasing));
            iComputerCasingRepository.Save();
        }

        public void UpdateItem(ComputerCasingDto computerCasing)
        {
            iComputerCasingRepository.UpdateItem(Mapper.Map<ComputerCasingDto, ComputerCasingDb>(computerCasing));
            iComputerCasingRepository.Save();
        }
    }
}
