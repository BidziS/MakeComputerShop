using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;
namespace MakeComputerShop.Bll.Services
{
    public interface ISoundCardService
    {
        IEnumerable<SoundCardDto> GetSoundCard();
        IEnumerable<SoundCardDto> GetSoundCardByProducentId(int producentId);
        SoundCardDto GetSoundCardById(int soundCardId);
        void InsertSoundCard(SoundCardDto soundCard);
        void DeleteSoundCard(int soundCardId);
        void UpdateSoundCard(SoundCardDto soundCard);

    }
}