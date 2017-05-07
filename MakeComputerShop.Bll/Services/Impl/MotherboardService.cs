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
    public class MotherboardService:IMotherboardService
    {
        private IMotherboardRepository iMotherboardRepository;

        public MotherboardService(IMotherboardRepository iMotherboardRepository)
        {
            this.iMotherboardRepository = iMotherboardRepository;
        }

        public IEnumerable<MotherboardDto> GetMotherboards()
        {
            return Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(iMotherboardRepository
                .GetMotherboards());
        }

        public IEnumerable<MotherboardDto> GetMotherboardsByProducentId(int producentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MotherboardDto> GetMotherboardsBySocket(int socketId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MotherboardDto> GetMotherboardsByChipset(int chipsetId)
        {
            throw new NotImplementedException();
        }

        public MotherboardDto GetMotherboardById(int motherboardId)
        {
            throw new NotImplementedException();
        }

        public void InsertMotherboard(MotherboardDto motherboard)
        {
            throw new NotImplementedException();
        }

        public void DeleteMotherboard(int motherboardId)
        {
            throw new NotImplementedException();
        }

        public void UpdateMotherboard(MotherboardDto motherboard)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
