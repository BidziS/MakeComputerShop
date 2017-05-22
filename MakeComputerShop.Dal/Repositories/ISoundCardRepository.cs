using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface ISoundCardRepository : IDisposable
    {
        IEnumerable<SoundCardDb> GetSoundCard();
        IEnumerable<SoundCardDb> GetSoundCardByProducentId(int producentId);
        SoundCardDb GetSoundCardById(int soundCardId);
        void InsertSoundCard(SoundCardDb soundCard);
        void DeleteSoundCard(int soundCardId);
        void UpdateSoundCard(SoundCardDb soundCard);
        void Save();
    }
}