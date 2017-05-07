using MakeComputerShop.Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Services
{
    public interface IPowerSupplyService
    {
        IEnumerable<PowerSupplyDto> GetPowerSupplies();
        IEnumerable<PowerSupplyDto> GetPowerSupliesByProducentId(int producentId);
        PowerSupplyDto GetPowerSupplyById(int powerSupplyId);
        void InsertPowerSupply(PowerSupplyDto powerSupply);
        void DeletePowerSupply(int powerSupplyId);
        void UpdatePowerSupply(PowerSupplyDto powerSupply);
    }
}
