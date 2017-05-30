using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class NetworkCardDto : BaseDto
    {
        public ProducentDto Producent { get; set; }

        public string Standard { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as NetworkCardDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.Standard == toCompareWith.Standard;
        }
    }
}
