using MakeComputerShop.Bll.Dtos.MotherboardElementsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class GraphicsCardDto : BaseDto
    {
        public ProducentDto Producent { get; set; }

        public ChipsetDto Chipset { get; set; }

        public int MemorySize { get; set; }

        public int DataBusBit { get; set; }

        public string Connector { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as GraphicsCardDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.MemorySize == toCompareWith.MemorySize &&
                   this.DataBusBit == toCompareWith.DataBusBit &&
                   this.Connector == toCompareWith.Connector;
        }
    }
}
