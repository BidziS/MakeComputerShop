using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class RamDb:BaseDb
    {
        public RamType RAMType { get; set; }

        [Required]
        public double Frequency { get; set; }
    }

    public enum RamType
    {
        DDR2,
        DDR3,
        DDR4
    }
}
