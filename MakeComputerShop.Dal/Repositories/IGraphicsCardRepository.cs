﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IGraphicsCardRepository : IDisposable
    {
        IEnumerable<GraphicsCardDb> GetGraphicCard();
        IEnumerable<GraphicsCardDb> GetGraphicCardByProducentId(int producentId);
        IEnumerable<GraphicsCardDb> GetGraphicCardByChipset(int chipsetId);
        GraphicsCardDb GetGraphicCardById(int GraphicCardId);
        void InsertGraphicCard(GraphicsCardDb graphicCard);
        void DeleteGraphicCard(int GraphicCardId);
        void UpdateGraphicCard(GraphicsCardDb graphicCard);
        void Save();
    }
}
