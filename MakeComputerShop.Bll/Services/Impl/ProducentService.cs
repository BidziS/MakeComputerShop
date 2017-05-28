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
    public class ProducentService:IGenericService<ProducentDto>
    {
        private IGenericRepository<ProducentDb> iProducentRepository;

        public ProducentService(IGenericRepository<ProducentDb> iProducentRepository)
        {
            this.iProducentRepository = iProducentRepository;
        }

        public IEnumerable<ProducentDto> GetAll()
        {
            IEnumerable<ProducentDto> producents =
                Mapper.Map<IEnumerable<ProducentDb>, IEnumerable<ProducentDto>>(iProducentRepository.GetAll());
            return producents;
        }

        public ProducentDto GetItemById(int producentId)
        {
            ProducentDto producentDto =
                Mapper.Map<ProducentDb, ProducentDto>(iProducentRepository.GetItemById(producentId));

            return producentDto;
        }

        public void InsertItem(ProducentDto producent)
        {
            iProducentRepository.InsertItem(Mapper.Map<ProducentDto,ProducentDb>(producent));
            iProducentRepository.Save();
        }

        public void DeleteItem(int producentId)
        {
            iProducentRepository.DeleteItem(producentId);
            iProducentRepository.Save();
        }

        public void UpdateItem(ProducentDto producent)
        {
            iProducentRepository.UpdateItem(Mapper.Map<ProducentDto,ProducentDb>(producent));
            iProducentRepository.Save();
        }
    }
}
