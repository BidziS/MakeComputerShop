using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos.MotherboardElementsDto;

namespace MakeComputerShop.Bll.Dtos
{
    public class ProcesorDto:BaseDto
    {
        public ProducentDto Producent { get; set; }

        public byte NumberOfCores { get; set; }

        public byte NumberOfThreads { get; set; }

        public byte Cache { get; set; }

        public double Frequency { get; set; }

        public SocketDto Socket { get; set; }
    }
}
