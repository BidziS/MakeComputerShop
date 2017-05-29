using MakeComputerShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class PowerSupplyDto:BaseDto
    {
        public ProducentDb Producent { get; set; }
        
        public int ProducentId { get; set; }
        
        public byte Power { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as PowerSupplyDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.Producent == toCompareWith.Producent &&
                   this.ProducentId == toCompareWith.ProducentId &&
                   this.Power == toCompareWith.Power;

        }
    }
}
