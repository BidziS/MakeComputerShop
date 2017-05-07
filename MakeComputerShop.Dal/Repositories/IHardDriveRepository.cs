using MakeComputerShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IHardDriveRepository
    {
        IEnumerable<HardDriveDb> GetHardDrives();
        IEnumerable<HardDriveDb> GetHardDrivesByProducentId(int producentId);
        HardDriveDb GetHardDriveById(int hardDriveId);
        void InsertHardDrive(HardDriveDb hardDrive);
        void DeleteHardDrive(int hardDriveId);
        void UpdateHardDrive(HardDriveDb hardDrive);
        void Save();
    }
}
