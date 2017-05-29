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
    }
}
