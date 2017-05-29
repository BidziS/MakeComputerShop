using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Bll.Dtos
{
    public class DriveDto : BaseDto
    {
        public ProducentDto Producent { get; set; }

        public DriveDb.DriverType DriverTypes { get; set; }

        public int AccessTime { get; set; }

        public string Interface { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as DriveDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                this.Name == toCompareWith.Name &&
                this.DriverTypes == toCompareWith.DriverTypes &&
                this.AccessTime == toCompareWith.AccessTime &&
                this.Interface == toCompareWith.Interface;
        }
    }
}
