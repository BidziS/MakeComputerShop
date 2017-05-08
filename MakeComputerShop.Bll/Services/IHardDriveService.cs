using MakeComputerShop.Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Services
{
    public interface IHardDriveService
    {
        IEnumerable<HardDriveDto> GetHardDrives();
        IEnumerable<HardDriveDto> GetHardDrivesByProducentId(int producentId);
        HardDriveDto GetHardDriveById(int hardDriveId);
        void InsertHardDrive(HardDriveDto hardDrive);
        void DeleteHardDrive(int hardDriveId);
        void UpdateHardDrive(HardDriveDto hardDrive);
    }
}
