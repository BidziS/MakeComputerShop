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
    public class SoundCardService : ISoundCardService
    {
        private ISoundCardRepository iSoundCardRepository;

        public SoundCardService(ISoundCardRepository iSoundCardRepository)
        {
            this.iSoundCardRepository = iSoundCardRepository;
        }

        public IEnumerable<SoundCardDto> GetSoundCard()
        {
            return Mapper.Map<IEnumerable<SoundCardDb>, IEnumerable<SoundCardDto>>(iSoundCardRepository.GetSoundCard());
        }

        public IEnumerable<SoundCardDto> GetSoundCardByProducentId(int producentId)
        {
            return Mapper.Map<IEnumerable<SoundCardDb>, IEnumerable<SoundCardDto>>(iSoundCardRepository.GetSoundCardByProducentId(producentId));
        }

        public SoundCardDto GetSoundCardById(int soundCardId)
        {
            return Mapper.Map<SoundCardDb, SoundCardDto>(iSoundCardRepository.GetSoundCardById(soundCardId));
        }
        public void InsertSoundCard(SoundCardDto soundCard)
        {
            iSoundCardRepository.InsertSoundCard(Mapper.Map<SoundCardDto, SoundCardDb>(soundCard));
            iSoundCardRepository.Save();
        }

        public void DeleteSoundCard(int soundCardId)
        {
            iSoundCardRepository.DeleteSoundCard(soundCardId);
            iSoundCardRepository.Save();
        }

        public void UpdateSoundCard(SoundCardDto soundCard)
        {
            iSoundCardRepository.UpdateSoundCard(Mapper.Map<SoundCardDto, SoundCardDb>(soundCard));
            iSoundCardRepository.Save();
        }



    }
}
