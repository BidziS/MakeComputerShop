using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public ComputerDto Computer { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as UserDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Email == toCompareWith.Email &&
                   this.Computer == toCompareWith.Computer;
        }
    }
}
