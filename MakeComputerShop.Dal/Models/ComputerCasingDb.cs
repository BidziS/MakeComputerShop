using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class ComputerCasingDb:BaseDb
    {
        public ProducentDb Producent { get; set; }

        public CasingType CasingType { get; set; }

        [Required]
        public int ProducentId { get; set; }

        [Required]
        public byte Width { get; set; }

        [Required]
        public byte Height { get; set; }

        [Required]
        public byte Depth { get; set; }

    }

    public enum CasingType
    {
        MidiTower,
        MiniTower,
        FullTower
    }

}
