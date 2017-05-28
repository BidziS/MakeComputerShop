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
            return Mapper.Map<MotherboardDb, MotherboardDto>(iMotherboardRepository.GetItemById(itemId));
        }

        public void InsertItem(MotherboardDto item)
        {
            iMotherboardRepository.InsertItem(Mapper.Map<MotherboardDto, MotherboardDb>(item));
            iMotherboardRepository.Save();
        }

        public void DeleteItem(int itemId)
        {
            iMotherboardRepository.DeleteItem(itemId);
            iMotherboardRepository.Save();
        }

        public void UpdateItem(MotherboardDto item)
        {
            iMotherboardRepository.UpdateItem(Mapper.Map<MotherboardDto, MotherboardDb>(item));
            iMotherboardRepository.Save();
        }
    }
}
