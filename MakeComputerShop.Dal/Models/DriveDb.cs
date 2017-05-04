using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class DriveDb:BaseDb
    {
        public ProducentDb Producent { get; set; }
        
        [Required]
        public int ProducentId { get; set; }

        public DriverType DriverTypes { get; set; }

        public int AccessTime { get; set; }

        public string Interface { get; set; }

        public enum DriverType
        {
            Cd,
            Dvd,
            Bluray
        }
    }
}
