using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IRamRepository
    {
        IEnumerable<RamDb> GetRams();
        RamDb GetRamById(int ramId);
        void InsertRam(RamDb ram);
        void DeleteRam(int ramId);
        void UpdateRam(RamDb ram);
        void Save();
    }
}
