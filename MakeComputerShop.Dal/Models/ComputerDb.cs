using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class ComputerDb
    {
        public int Id { get; set; }
        
        public string Descripton { get; set; }

        public int? MotherboardId { get; set; }

        public MotherboardDb Motherboard { get; set; }

        public int? ProcesorId { get; set; }

        public ProcesorDb Procesor { get; set; }

        public int? RamId { get; set; }

        public RamDb Ram { get; set; }

        public int? PowerSupplyId { get; set; }

        public PowerSupplyDb PowerSupply { get; set; }

        public int? HardDriveId { get; set; }

        public HardDriveDb HardDrive { get; set; }

        public int? ComputerCasingId { get; set; }

        public ComputerCasingDb ComputerCasing { get; set; }

        public int? DriveId { get; set; }

        public DriveDb Drive { get; set; }

        public int? GraphicsCardId { get; set; }

        public GraphicsCardDb GraphicsCard { get; set; }

        public int? NetworkCardId { get; set; }

        public NetworkCardDb NetworkCard { get; set; }

        public int? SoundCardId { get; set; }

        public SoundCardDb SoundCard { get; set; }
    }
}
