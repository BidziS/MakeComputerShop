using MakeComputerShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IPowerSupplyRepository
    {
        IEnumerable<PowerSupplyDb> GetPowerSupplies();
        IEnumerable<PowerSupplyDb> GetPowerSupliesByProducentId(int producentId);
        PowerSupplyDb GetPowerSupplyById(int powerSupplyId);
        void InsertPowerSupply(PowerSupplyDb powerSupply);
        void DeletePowerSupply(int powerSupplyId);
        void UpdatePowerSupply(PowerSupplyDb powerSupply);
        void Save();
    }
}
