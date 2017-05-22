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
    }
}
