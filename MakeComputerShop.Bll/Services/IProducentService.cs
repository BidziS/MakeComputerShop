using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface IProducentService
    {
        IEnumerable<ProducentDto> GetProducents();
        ProducentDto GetProducentById(int producentId);
        void InsertProducent(ProducentDto producent);
        void DeleteProducent(int producentId);
        void UpdateProducent(ProducentDto producent);
    }
}
