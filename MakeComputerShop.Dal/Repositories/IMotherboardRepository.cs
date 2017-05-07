using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IMotherboardRepository
    {
        IEnumerable<MotherboardDb> GetMotherboards();
        MotherboardDb GetMotherboardById(int motherboardId);
        void InsertMotherboard(MotherboardDb motherboard);
        void DeleteMotherboard(int motherboardId);
        void UpdateMotherboard(MotherboardDb motherboard);
        void Save();
    }
}
