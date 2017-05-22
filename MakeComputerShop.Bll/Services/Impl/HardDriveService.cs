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
        private IGenericRepository<HardDriveDb> iGraphicCardRepository;

        public HardDriveService(IGenericRepository<HardDriveDb> iGraphicCardRepository)
        {
            this.iGraphicCardRepository = iGraphicCardRepository;
        }

        public IEnumerable<HardDriveDto> GetAll()
        {
            return Mapper.Map<IEnumerable<HardDriveDb>, IEnumerable<HardDriveDto>>(iGraphicCardRepository.GetAll());
        }

        public HardDriveDto GetItemById(int graphicCardId)
        {
            return Mapper.Map<HardDriveDb, HardDriveDto>(iGraphicCardRepository.GetItemById(graphicCardId));
        }
        public void InsertItem(HardDriveDto graphicCard)
        {
            iGraphicCardRepository.InsertItem(Mapper.Map<HardDriveDto, HardDriveDb>(graphicCard));
            iGraphicCardRepository.Save();
        }

        public void DeleteItem(int graphicCardId)
        {
            iGraphicCardRepository.DeleteItem(graphicCardId);
            iGraphicCardRepository.Save();
        }

        public void UpdateItem(HardDriveDto graphicCard)
        {
            iGraphicCardRepository.UpdateItem(Mapper.Map<HardDriveDto, HardDriveDb>(graphicCard));
            iGraphicCardRepository.Save();
        }
    }
}
