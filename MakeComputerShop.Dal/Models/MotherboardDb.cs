using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models.MotherboardElements;

namespace MakeComputerShop.Dal.Models
{
    public class MotherboardDb:BaseDb
    {
        public ProducentDb Producent { get; set; }

        [Required]
        public int ProducentId { get; set; }
        
        public SocketDb Socket { get; set; }

        [Required]
        public int SocketId { get; set; }
        
        public ChipsetDb Chipset { get; set; }

        [Required]
        public int ChipsetId { get; set; }

        [Required]
        public int MaxMemory { get; set; }

        public RamType RAMType { get; set; }
    }
}
