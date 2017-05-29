using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class SoundCardDto : BaseDto
    {
        public ProducentDto Producent { get; set; }

        public string Interface { get; set; }

        public float SoundSystem { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as SoundCardDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.Interface == toCompareWith.Interface &&
                   this.SoundSystem == toCompareWith.SoundSystem;

        }
    }
}
