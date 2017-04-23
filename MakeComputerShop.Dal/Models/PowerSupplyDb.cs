using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class PowerSupplyDb:BaseDb
    {
        public ProducentDb Producent { get; set; }

        [Required]
        public int ProducentId { get; set; }

        [Required]
        public byte Power { get; set; }

    }
}
