using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IDriveRepository : IDisposable
    {
        IEnumerable<DriveDb> GetDrives();
        IEnumerable<DriveDb> GetDrivesByProducentId(int producentId);
        DriveDb GetDriveById(int driveId);
        void InsertDrive(DriveDb drive);
        void DeleteDrive(int driveId);
        void UpdateCrive(DriveDb drive);
        void Save();

    }
}