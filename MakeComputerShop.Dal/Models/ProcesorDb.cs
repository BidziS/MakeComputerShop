using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class ProcesorDb:BaseDb
    {
        public ProducentDb Producent { get; set; }

        [Required]
        public int ProducentId { get; set; }

        [Required]
        public byte NumberOfCores { get; set; }

        [Required]
        public byte NumberOfThreads { get; set; }

        [Required]
        public byte Cache { get; set; }

        [Required]
        public double Frequency { get; set; }


    }
}
