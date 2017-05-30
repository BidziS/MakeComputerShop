using MakeComputerShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class ComputerCasingDto:BaseDto
    {
        public ProducentDb Producent { get; set; }

        public CasingType CasingType { get; set; }
        
        public int ProducentId { get; set; }
        
        public byte Width { get; set; }
        
        public byte Height { get; set; }
        
        public byte Depth { get; set; }
        public override bool Equals(object obj)
        {
            var toCompareWith = obj as ComputerCasingDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.CasingType == toCompareWith.CasingType &&
                   this.ProducentId == toCompareWith.ProducentId &&
                   this.Width == toCompareWith.Width &&
                   this.Height == toCompareWith.Height &&
                   this.Depth == toCompareWith.Depth;

        }
    }
}
