using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos.MotherboardElementsDto;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Bll.Dtos
{
    public class MotherboardDto:BaseDto
    {
        public ProducentDto Producent { get; set; }

        public SocketDto Socket { get; set; }

        public ChipsetDto Chipset { get; set; }

        public int MaxMemory { get; set; }

        public RamType RAMType { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as MotherboardDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.Producent == toCompareWith.Producent &&
                   this.Socket == toCompareWith.Socket &&
                   this.Chipset == toCompareWith.Chipset &&
                   this.MaxMemory == toCompareWith.MaxMemory &&
                   this.RAMType == toCompareWith.RAMType &&
                   this.ImageUrl == toCompareWith.ImageUrl &&
                   this.Price == toCompareWith.Price;
        }
    }
}
