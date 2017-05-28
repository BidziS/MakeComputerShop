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

                cfg.CreateMap<UserDto, UserDb>();
                cfg.CreateMap<UserDb, UserDto>();

                cfg.CreateMap<ComputerCasingDb, ComputerCasingDto>();
                cfg.CreateMap<ComputerCasingDto, ComputerCasingDb>();

                cfg.CreateMap<DriveDb, DriveDto>();
                cfg.CreateMap<DriveDto, DriveDb>();

                cfg.CreateMap<GraphicsCardDb, GraphicsCardDto>();
                cfg.CreateMap<GraphicsCardDto, GraphicsCardDb>();

                cfg.CreateMap<HardDriveDto, HardDriveDb>();
                cfg.CreateMap<HardDriveDb, HardDriveDto>();

                cfg.CreateMap<NetworkCardDb, NetworkCardDto>();
                cfg.CreateMap<NetworkCardDto, NetworkCardDb>();

                cfg.CreateMap<PowerSupplyDto, PowerSupplyDb>();
                cfg.CreateMap<PowerSupplyDb, PowerSupplyDto>();

                cfg.CreateMap<ProcesorDb, ProcesorDto>();
                cfg.CreateMap<ProcesorDto, ProcesorDb>();

                cfg.CreateMap<SoundCardDb, SoundCardDto>();
                cfg.CreateMap<SoundCardDto, SoundCardDb>();

                cfg.CreateMap<ComputerDb, ComputerDto>();
                cfg.CreateMap<ComputerDto, ComputerDb>()
                ;
            });
        }
    }
}
