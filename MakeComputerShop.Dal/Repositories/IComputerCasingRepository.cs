using MakeComputerShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IComputerCasingRepository
    {
        IEnumerable<ComputerCasingDb> GetComputerCasings();
        IEnumerable<ComputerCasingDb> GetComputerCasingsByProducentId(int producentId);
        ComputerCasingDb GetComputerCasingById(int computerCasingId);
        void InsertComputerCasing(ComputerCasingDb computerCasing);
        void DeleteComputerCasing(int computerCasingId);
        void UpdateComputerCasing(ComputerCasingDb computerCasing);
        void Save();
    }
}
