using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IMotherboardRepository:IDisposable
    {
        IEnumerable<MotherboardDb> GetMotherboards();
        IEnumerable<MotherboardDb> GetMotherboardsByProducentId(int producentId);
        IEnumerable<MotherboardDb> GetMotherboardsBySocket(int socketId);
        IEnumerable<MotherboardDb> GetMotherboardsByChipset(int chipsetId);
        MotherboardDb GetMotherboardById(int motherboardId);       
        void InsertMotherboard(MotherboardDb motherboard);
        void DeleteMotherboard(int motherboardId);
        void UpdateMotherboard(MotherboardDb motherboard);
        void Save();
    }
}
