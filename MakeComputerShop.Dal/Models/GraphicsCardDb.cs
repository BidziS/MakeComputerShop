using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class GraphicsCardDb:BaseDb
    {
        public ProducentDb Producent { get; set; }

        [Required]
        public int ProducentId { get; set; }

        [Required]
        public string ChipsetName { get; set; }
        [Required]
        public int ChipsetId { get; set; }

        [Required]
        public int MemorySize { get; set; }

        [Required]
        public int DataBusBit { get; set; }

        [Required]
        public string Connector { get; set; }

    }
}
