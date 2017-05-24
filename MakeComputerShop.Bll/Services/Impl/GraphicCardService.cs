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
    public class GraphicCardService:IGraphicCardService
    {
        private IGraphicsCardRepository iGraphicCardRepository;

        public GraphicCardService(IGraphicsCardRepository iGraphicCardRepository)
        {
            this.iGraphicCardRepository = iGraphicCardRepository;
        }

        public IEnumerable<GraphicCardDto> GetGraphicCard()
        {
            return Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicCardDto>>(iGraphicCardRepository.GetGraphicCard());
        }

        public IEnumerable<GraphicCardDto> GetGraphicCardByProducentId(int producentId)
        {
            return Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicCardDto>>(iGraphicCardRepository.GetGraphicCardByProducentId(producentId));
        }
        public IEnumerable<GraphicCardDto> GetGraphicCardByChipset(int chipsetId)
        {
            return Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicCardDto>>(iGraphicCardRepository.GetGraphicCardByChipset(chipsetId));
        }
        public GraphicCardDto GetGraphicCardById(int graphicCardId)
        {
            return Mapper.Map<GraphicsCardDb, GraphicCardDto>(iGraphicCardRepository.GetGraphicCardById(graphicCardId));
        }
        public void InsertGraphicCard(GraphicCardDto graphicCard)
        {
            iGraphicCardRepository.InsertGraphicCard(Mapper.Map<GraphicCardDto, GraphicsCardDb>(graphicCard));
            iGraphicCardRepository.Save();
        }

        public void DeleteGraphicCard(int graphicCardId)
        {
            iGraphicCardRepository.DeleteGraphicCard(graphicCardId);
            iGraphicCardRepository.Save();
        }

        public void UpdateGraphicCard(GraphicCardDto graphicCard)
        {
            iGraphicCardRepository.UpdateGraphicCard(Mapper.Map<GraphicCardDto, GraphicsCardDb>(graphicCard));
            iGraphicCardRepository.Save();
        }
    }
}
