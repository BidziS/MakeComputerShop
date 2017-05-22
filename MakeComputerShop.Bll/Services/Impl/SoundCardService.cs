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
    public class SoundCardService : IGenericService<SoundCardDto>
    {
        private IGenericRepository<SoundCardDb> iSoundCardRepository;

        public SoundCardService(IGenericRepository<SoundCardDb> iSoundCardRepository)
        {
            this.iSoundCardRepository = iSoundCardRepository;
        }

        public IEnumerable<SoundCardDto> GetAll()
        {
            return Mapper.Map<IEnumerable<SoundCardDb>, IEnumerable<SoundCardDto>>(iSoundCardRepository.GetAll());
        }

        public SoundCardDto GetItemById(int soundCardId)
        {
            return Mapper.Map<SoundCardDb, SoundCardDto>(iSoundCardRepository.GetItemById(soundCardId));
        }
        public void InsertItem(SoundCardDto soundCard)
        {
            iSoundCardRepository.InsertItem(Mapper.Map<SoundCardDto, SoundCardDb>(soundCard));
            iSoundCardRepository.Save();
        }

        public void DeleteItem(int soundCardId)
        {
            iSoundCardRepository.DeleteItem(soundCardId);
            iSoundCardRepository.Save();
        }

        public void UpdateItem(SoundCardDto soundCard)
        {
            iSoundCardRepository.UpdateItem(Mapper.Map<SoundCardDto, SoundCardDb>(soundCard));
            iSoundCardRepository.Save();
        }



    }
}
