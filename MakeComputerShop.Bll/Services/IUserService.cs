using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface IUserService:IGenericService<UserDto>
    {
        UserDto GetItemByEmail(string name);
    }
}
