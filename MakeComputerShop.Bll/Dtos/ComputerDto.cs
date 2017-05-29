using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class ComputerDto
    {
        public int Id { get; set; }

        public string Descripton { get; set; }

        public MotherboardDto Motherboard { get; set; }

        public ProcesorDto Procesor { get; set; }

        public RamDto Ram { get; set; }

        public PowerSupplyDto PowerSupply { get; set; }

        public HardDriveDto HardDrive { get; set; }

        public ComputerCasingDto ComputerCasing { get; set; }

        public DriveDto Drive { get; set; }

        public GraphicsCardDto GraphicsCard { get; set; }

        public NetworkCardDto NetworkCard { get; set; }

        public SoundCardDto SoundCard { get; set; }
    }
}
