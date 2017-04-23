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
    public class ProducentService:IProducentService
    {
        private IProducentRepository iProducentRepository;

        public ProducentService(IProducentRepository iProducentRepository)
        {
            this.iProducentRepository = iProducentRepository;
        }

        public IEnumerable<ProducentDto> GetProducents()
        {
            IEnumerable<ProducentDto> producents =
                Mapper.Map<IEnumerable<ProducentDb>, IEnumerable<ProducentDto>>(iProducentRepository.GetProducents());
            return producents;
        }

        public ProducentDto GetProducentById(int producentId)
        {
            ProducentDto producentDto =
                Mapper.Map<ProducentDb, ProducentDto>(iProducentRepository.GetProducentById(producentId));

            return producentDto;
        }

        public void InsertProducent(ProducentDto producent)
        {
            iProducentRepository.InsertProducent(Mapper.Map<ProducentDto,ProducentDb>(producent));
            iProducentRepository.Save();
        }

        public void DeleteProducent(int producentId)
        {
            iProducentRepository.DeleteProducent(producentId);
            iProducentRepository.Save();
        }

        public void UpdateProducent(ProducentDto producent)
        {
            iProducentRepository.UpdateProducent(Mapper.Map<ProducentDto,ProducentDb>(producent));
            iProducentRepository.Save();
        }
    }
}
