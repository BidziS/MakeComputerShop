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

        public ProducentDto GetProducent(int produucentId)
        {
            ProducentDto producentDto =
                Mapper.Map<ProducentDb, ProducentDto>(iProducentRepository.GetProducentById(produucentId));

            return producentDto;

        }
    }
}
