using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class MotherboardDb
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ProducentDb Producent { get; set; }

        [Required]
        public int ProducentId { get; set; }

        [Required]
        public string Socket { get; set; }

        [Required]
        public string Chipset { get; set; }

        [Required]
        public int MaxMemory { get; set; }

        public RamType RAMType { get; set; }
    }
}
