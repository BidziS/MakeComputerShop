using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Dtos.MotherboardElementsDto;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Dal.Models.MotherboardElements;

namespace MakeComputerShop.Bll
{
    public class MapperConfig
    {
        public static void Configuration()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<ProducentDto, ProducentDb>();
                cfg.CreateMap<ProducentDb, ProducentDto>();

                cfg.CreateMap<SocketDto, SocketDb>();
                cfg.CreateMap<SocketDb, SocketDto>();

                cfg.CreateMap<ChipsetDto, ChipsetDb>();
                cfg.CreateMap<ChipsetDb, ChipsetDto>();

                cfg.CreateMap<MotherboardDto, MotherboardDb>();
                cfg.CreateMap<MotherboardDb, MotherboardDto>();

                cfg.CreateMap<RamDto, RamDb>();
                cfg.CreateMap<RamDb, RamDto>();

                cfg.CreateMap<DriveDto,DriveDb>();
                cfg.CreateMap<DriveDb, DriveDto>();

                cfg.CreateMap<GraphicCardDto, GraphicsCardDb>();
                cfg.CreateMap<GraphicsCardDb, GraphicCardDto>();

                cfg.CreateMap<NetworkCardDto, NetworkCardDb>();
                cfg.CreateMap<NetworkCardDb, NetworkCardDto>();

                cfg.CreateMap<SoundCardDto, SoundCardDb>();
                cfg.CreateMap<SoundCardDb, SoundCardDto>();

                cfg.CreateMap<ComputerCasingDto, ComputerCasingDb>();
                cfg.CreateMap<ComputerCasingDb,ComputerCasingDto>();
            });
        }
    }
}
