using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface IGraphicCardService
    {
        IEnumerable<GraphicCardDto> GetGraphicCard();
        IEnumerable<GraphicCardDto> GetGraphicCardByProducentId(int producentId);
        IEnumerable<GraphicCardDto> GetGraphicCardByChipset(int chipsetId);
        GraphicCardDto GetGraphicCardById(int graphicCardId);
        void InsertGraphicCard(GraphicCardDto graphicCard);
        void DeleteGraphicCard(int graphicCardId);
        void UpdateGraphicCard(GraphicCardDto graphicCard);
        
    }
}
