using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IUserRepository:IGenericRepository<UserDb>
    {
        UserDb GetItemByEmail(string name);
    }
}
