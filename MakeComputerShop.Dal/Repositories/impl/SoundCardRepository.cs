using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class SoundCardRepository : IGenericRepository<SoundCardDb>
    {
        private ShopContext context;

        public SoundCardRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<SoundCardDb> GetAll()
        {
            return context.SoundCards.ToList();
        }

        public SoundCardDb GetItemById(int itemId)
        {
            return context.SoundCards.Include(sc => sc.Producent).SingleOrDefault(sc => sc.Id == itemId);
        }

        public void InsertItem(SoundCardDb item)
        {
            context.SoundCards.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            SoundCardDb soundCard = GetItemById(itemId);
            if (soundCard != null) context.SoundCards.Remove(soundCard);
        }

        public void UpdateItem(SoundCardDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
