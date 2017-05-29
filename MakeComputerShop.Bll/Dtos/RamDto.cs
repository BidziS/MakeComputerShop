using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Bll.Dtos
{
    public class RamDto:BaseDto
    {
        public RamType RAMType { get; set; }

        public double Frequency { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as RamDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.RAMType == toCompareWith.RAMType &&
                   this.Frequency == toCompareWith.Frequency;
        }
    }
}
