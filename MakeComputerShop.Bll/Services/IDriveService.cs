using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface IDriveService
    {
        IEnumerable<DriveDto> GetDrives();
        IEnumerable<DriveDto> GetDrivesByProducentId(int producentId);
        DriveDto GetDriveById(int driveId);
        void InsertDrive(DriveDto drive);
        void DeleteDrive(int driveId);
        void UpdateDrive(DriveDto drive);
        

    }
}
