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
    public class HardDriveService:IGenericService<HardDriveDto>
    {
        private IGenericRepository<HardDriveDb> HardDriveRepository;

        public HardDriveService(IGenericRepository<HardDriveDb> HardDriveRepository)
        {
            this.HardDriveRepository = HardDriveRepository;
        }

        public IEnumerable<HardDriveDto> GetAll()
        {
            return Mapper.Map<IEnumerable<HardDriveDb>, IEnumerable<HardDriveDto>>(HardDriveRepository.GetAll());
        }

        public HardDriveDto GetItemById(int hard_driveId)
        {
            return Mapper.Map<HardDriveDb, HardDriveDto>(HardDriveRepository.GetItemById(hard_driveId));
        }
        public void InsertItem(HardDriveDto hard_drive)
        {
            HardDriveRepository.InsertItem(Mapper.Map<HardDriveDto, HardDriveDb>(hard_drive));
            HardDriveRepository.Save();
        }

        public void DeleteItem(int hard_driveId)
        {
            HardDriveRepository.DeleteItem(hard_driveId);
            HardDriveRepository.Save();
        }

        public void UpdateItem(HardDriveDto graphicCard)
        {
            HardDriveRepository.UpdateItem(Mapper.Map<HardDriveDto, HardDriveDb>(graphicCard));
            HardDriveRepository.Save();
        }
    }
}
