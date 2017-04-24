using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class HardDriveDb:BaseDb
    {
        public ProducentDb Producent { get; set; }

        [Required]
        public int ProducentId { get; set; }

        [Required]
        public byte Capacity { get; set; }

        [Required]
        public byte CacheMemory { get; set; }

        [Required]
        public HardDriveType HardDriveType { get; set; }

        [Required]
        public double WidthFormat { get; set; }

    }

    public enum HardDriveType
    {
        magnetic,
        SSD
    }

}
