using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class UserDb
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public List<ComputerDb> Computers { get; set; }

    }

}
