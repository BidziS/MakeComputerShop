using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface IMotherboardService
    {
        IEnumerable<MotherboardDto> GetMotherboards();
        IEnumerable<MotherboardDto> GetMotherboardsByProducentId(int producentId);
        IEnumerable<MotherboardDto> GetMotherboardsBySocket(int socketId);
        IEnumerable<MotherboardDto> GetMotherboardsByChipset(int chipsetId);
        MotherboardDto GetMotherboardById(int motherboardId);
        void InsertMotherboard(MotherboardDto motherboard);
        void DeleteMotherboard(int motherboardId);
        void UpdateMotherboard(MotherboardDto motherboard);
        void Save();
    }
}
