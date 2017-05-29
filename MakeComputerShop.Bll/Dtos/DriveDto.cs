using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Bll.Dtos
{
    public class DriveDto : BaseDto
    {
        public ProducentDto Producent { get; set; }

        public DriveDb.DriverType DriverTypes { get; set; }

        public int AccessTime { get; set; }

        public string Interface { get; set; }


    }
}
