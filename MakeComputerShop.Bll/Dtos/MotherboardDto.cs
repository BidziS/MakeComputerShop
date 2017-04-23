using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos.MotherboardElementsDto;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Bll.Dtos
{
    public class MotherboardDto
    {
        public ProducentDto Producent { get; set; }

        public SocketDto Socket { get; set; }

        public ChipsetDto Chipset { get; set; }

        public int MaxMemory { get; set; }

        public RamType RAMType { get; set; }
    }
}
