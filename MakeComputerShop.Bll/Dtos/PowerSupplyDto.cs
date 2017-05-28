using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class PowerSupplyDto:BaseDto
    {
        public ProducentDto Producent { get; set; }

        public int Power { get; set; }
    }
}
