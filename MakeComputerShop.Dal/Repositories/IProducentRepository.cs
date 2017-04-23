using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IProducentRepository:IDisposable
    {
        IEnumerable<ProducentDb> GetProducents();
        ProducentDb GetProducentById(int producentId);
        void InsertProducent(ProducentDb producent);
        void DeleteProducent(int producentId);
        void UpdateProducent(ProducentDb producent);
        void Save();
    }
}
