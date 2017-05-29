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

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as HardDriveDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.Producent == toCompareWith.Producent &&
                   this.ProducentId == toCompareWith.ProducentId &&
                   this.Capacity == toCompareWith.Capacity &&
                   this.CacheMemory == toCompareWith.CacheMemory &&
                   this.HardDriveType == toCompareWith.HardDriveType &&
                   this.WidthFormat == toCompareWith.WidthFormat;
        }

    }
}
