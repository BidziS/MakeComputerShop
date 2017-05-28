using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class GraphicsCardRepository : IGenericRepository<GraphicsCardDb>
    {
        private ShopContext context;


        public GraphicsCardRepository(ShopContext context)
        {
            this.context = context;
        }


        public IEnumerable<GraphicsCardDb> GetAll()
        {
            return context.GraphicsCards.ToList();
        }

        public GraphicsCardDb GetItemById(int itemId)
        {
            return context.GraphicsCards
                .Include(g => g.Chipset)
                .Include(g => g.Producent)
                .FirstOrDefault();
        }

        public void InsertItem(GraphicsCardDb item)
        {
            context.GraphicsCards.Add(item);
        }

        public void DeleteItem(int itemId)
        {
            GraphicsCardDb graphicsCard = GetItemById(itemId);
            if (graphicsCard != null) context.GraphicsCards.Remove(graphicsCard);
        }

        public void UpdateItem(GraphicsCardDb item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}