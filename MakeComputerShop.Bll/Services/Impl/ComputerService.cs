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
    public class ComputerService:IGenericService<ComputerDto>
    {
        private IGenericRepository<ComputerDb> iComputerRepository;

        public ComputerService(IGenericRepository<ComputerDb> iComputerRepository)
        {
            this.iComputerRepository = iComputerRepository;
        }

        public IEnumerable<ComputerDto> GetAll()
        {
            return Mapper.Map<IEnumerable<ComputerDb>, IEnumerable<ComputerDto>>(iComputerRepository.GetAll());
        }

        public ComputerDto GetItemById(int itemId)
        {
            return Mapper.Map<ComputerDb, ComputerDto>(iComputerRepository.GetItemById(itemId));
        }

        public void InsertItem(ComputerDto item)
        {
            iComputerRepository.InsertItem(Mapper.Map<ComputerDto,ComputerDb>(item));
            iComputerRepository.Save();
        }

        public void DeleteItem(int itemId)
        {
            iComputerRepository.DeleteItem(itemId);
            iComputerRepository.Save();
        }

        public void UpdateItem(ComputerDto item)
        {
            iComputerRepository.UpdateItem(Mapper.Map<ComputerDto,ComputerDb>(item));
        }
    }
}
