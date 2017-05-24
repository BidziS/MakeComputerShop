using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class GraphicsCardRepository : IGraphicsCardRepository
    {
        private ShopContext context;

        private IGraphicsCardRepository iGraphicsCardRepository;

        public GraphicsCardRepository(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<GraphicsCardDb> GetGraphicsCard()
        {
            return context.GraphicCards.ToList();
        }

        public IEnumerable<GraphicsCardDb> GetGraphicsCardByProducentId(int producentId)
        {
            return context.GraphicCards.Include(m => m.Producent).Where(m => m.ProducentId == producentId);
        }

        public IEnumerable<GraphicsCardDb> GetGraphicCardByChipset(int chipsetId)
        {
            return context.GraphicCard.Include(m => m.Chipset).Where(m => m.ChipsetId == chipsetId);
        }

        public GraphicsCardDb GetGetGraphicCardById(int graphicCardId)
        {
            return context.GraphicCards.Find(driveId);
        }

        public void InsertGraphicCard(GraphicsCardDb graphicCard)
        {
            context.GraphicCards.Add(graphicCard);
        }

        public void DeleteGraphicCard(int graphicCardId)
        {
            GraphicsCardDb graphicCard = context.graphicCards.Find(graphicCardId);
            if (graphicCard != null) context.graphicCards.Remove(graphicCard);
        }

        public void UpdateGraphicCard(GraphicsCardDb graphicCard)
        {
            context.Entry(graphicCard).State = EntityState.Modified;
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