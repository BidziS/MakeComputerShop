using MakeComputerShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class HardDriveDto:BaseDto
    {
        public ProducentDb Producent { get; set; }
        
        public int ProducentId { get; set; }
        
        public byte Capacity { get; set; }
        
        public byte CacheMemory { get; set; }
        
        public HardDriveType HardDriveType { get; set; }
        
        public double WidthFormat { get; set; }
    }
}
