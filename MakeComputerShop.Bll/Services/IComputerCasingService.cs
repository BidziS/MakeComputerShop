using MakeComputerShop.Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Services
{
    public interface IComputerCasingService
    {
        IEnumerable<ComputerCasingDto> GetComputerCasings();
        IEnumerable<ComputerCasingDto> GetComputerCasingsByProducentId(int producentId);
        ComputerCasingDto GetComputerCasingById(int computerCasingId);
        void InsertComputerCasing(ComputerCasingDto computerCasing);
        void DeleteComputerCasing(int computerCasingId);
        void UpdateComputerCasing(ComputerCasingDto computerCasing);
    }
}
