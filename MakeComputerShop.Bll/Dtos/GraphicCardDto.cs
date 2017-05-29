using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class GraphicCardDto:BaseDto
    {
        public ProducentDto Producent { get; set; }

        public string ChipsetName { get; set; }

        public int MemorySize { get; set; }

        public int DataBusBit { get; set; }

        public string Connector { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as GraphicCardDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.ChipsetName == toCompareWith.ChipsetName &&
                   this.MemorySize == toCompareWith.MemorySize &&
                   this.DataBusBit == toCompareWith.DataBusBit &&
                   this.Connector == toCompareWith.Connector;
        }
    }
}
