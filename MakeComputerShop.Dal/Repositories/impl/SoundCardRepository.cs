using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class SoundCardReposirtory : ISoundCardRepository
    {
        private ShopContext context;

        private ISoundCardRepository iSoundCardRepository;

        public SoundCardReposirtory(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<SoundCardDb> GetSoundCard()
        {
            return context.SoundCards.ToList();
        }

        public IEnumerable<SoundCardDb> GetSoundCardByProducentId(int producentId)
        {
            return context.NetworkCards.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public SoundCardDb GetSoundCardById(int soundCardId)
        {
            return context.NetworkCards.Find(soundCardId);
        }

        public void InsertSoundCard(SoundCardDb soundCard)
        {
            context.Drives.Add(soundCard);
        }

        public void DeleteSoundCard(int soundCardId)
        {
            SoundCardDb soundCard = context.SoundCards.Find(soundCardId);
            if (soundCard != null) context.SoundCards.Remove(soundCard);
        }

        public void UpdateSoundCard(SoundCardDb soundCard)
        {
            context.Entry(soundCard).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
