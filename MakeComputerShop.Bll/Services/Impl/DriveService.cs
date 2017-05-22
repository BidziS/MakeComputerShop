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
    public class DriveService : IGenericService<DriveDto>
    {
        private IGenericRepository<DriveDb> iDriveRepository;

        public DriveService(IGenericRepository<DriveDb> iDriveRepository)
        {
            this.iDriveRepository = iDriveRepository;
        }

        public IEnumerable<DriveDto> GetAll()
        {
            return Mapper.Map<IEnumerable<DriveDb>, IEnumerable<DriveDto>>(iDriveRepository.GetAll());
        }

        public DriveDto GetItemById(int driveId)
        {
            return Mapper.Map<DriveDb, DriveDto>(iDriveRepository.GetItemById(driveId));
        }

        public void InsertItem(DriveDto drive)
        {
            iDriveRepository.InsertItem(Mapper.Map<DriveDto, DriveDb>(drive));
            iDriveRepository.Save();
        }

        public void DeleteItem(int driveId)
        {
            iDriveRepository.DeleteItem(driveId);
            iDriveRepository.Save();
        }

        public void UpdateItem(DriveDto drive)
        {
            iDriveRepository.UpdateItem(Mapper.Map<DriveDto, DriveDb>(drive));
            iDriveRepository.Save();
        }
    }
}
