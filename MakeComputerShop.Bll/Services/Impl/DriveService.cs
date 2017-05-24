using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Dal.Repositories;


namespace MakeComputerShop.Bll.Services.Impl
{
    public class DriveService:IDriveService
    {
        private IDriveRepository iDriveRepository; 

        public DriveService(IDriveRepository iDriveRepository)
        {
            this.iDriveRepository = iDriveRepository;
        }

        public IEnumerable<DriveDto> GetDrives()
        {
            return Mapper.Map<IEnumerable<DriveDb>, IEnumerable<DriveDto>>(iDriveRepository.GetDrives());
        }

        public IEnumerable<DriveDto> GetDrivesByProducentId(int producentId)
        {
            return Mapper.Map<IEnumerable<DriveDb>,IEnumerable <DriveDto>>(iDriveRepository.GetDrivesByProducentId(producentId));
        }

        public DriveDto GetDriveById(int driveId)
        {
            return Mapper.Map<DriveDb, DriveDto>(iDriveRepository.GetDriveById(driveId));
        }
        public void InsertDrive(DriveDto drive)
        {
            iDriveRepository.InsertDrive(Mapper.Map<DriveDto, DriveDb>(drive));
            iDriveRepository.Save();
        }

        public void DeleteDrive(int driveId)
        {
            iDriveRepository.DeleteDrive(driveId);
            iDriveRepository.Save();
        }

        public void UpdateDrive(DriveDto drive)
        {
            iDriveRepository.UpdateDrive(Mapper.Map<DriveDto, DriveDb>(drive));
            iDriveRepository.Save();
        }

        

    }
}
