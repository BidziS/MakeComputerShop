using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface IRamService
    {
        IEnumerable<RamDto> GetRams();
        RamDto GetRamById(int ramId);
        void InsertRam(RamDto ram);
        void DeleteRam(int ramId);
        void UpdateRam(RamDto ram);
    }
}
