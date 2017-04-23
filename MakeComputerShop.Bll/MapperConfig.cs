using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Bll
{
    public class MapperConfig
    {
        public static void Configuration()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<ProducentDto, ProducentDb>();
                cfg.CreateMap<ProducentDb, ProducentDto>();
            });
        }
    }
}
