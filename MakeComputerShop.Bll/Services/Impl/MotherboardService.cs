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
    public class MotherboardService:IGenericService<MotherboardDto>
    {
        private IGenericRepository<MotherboardDb> iMotherboardRepository;

        public MotherboardService(IGenericRepository<MotherboardDb> iMotherboardRepository)
        {
            this.iMotherboardRepository = iMotherboardRepository;
        }

        public IEnumerable<MotherboardDto> GetAll()
        {
            return Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(iMotherboardRepository
                .GetAll());
        }

        public MotherboardDto GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }

        public void InsertItem(MotherboardDto item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(MotherboardDto item)
        {
            throw new NotImplementedException();
        }
    }
}
