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
    public class GraphicsCardService : IGenericService<GraphicsCardDto>
    {
        private IGenericRepository<GraphicsCardDb> iGraphicCardRepository;

        public GraphicsCardService(IGenericRepository<GraphicsCardDb> iGraphicCardRepository)
        {
            this.iGraphicCardRepository = iGraphicCardRepository;
        }

        public IEnumerable<GraphicsCardDto> GetAll()
        {
            return Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicsCardDto>>(iGraphicCardRepository.GetAll());
        }

        public GraphicsCardDto GetItemById(int graphicCardId)
        {
            return Mapper.Map<GraphicsCardDb, GraphicsCardDto>(iGraphicCardRepository.GetItemById(graphicCardId));
        }
        public void InsertItem(GraphicsCardDto graphicCard)
        {
            iGraphicCardRepository.InsertItem(Mapper.Map<GraphicsCardDto, GraphicsCardDb>(graphicCard));
            iGraphicCardRepository.Save();
        }

        public void DeleteItem(int graphicCardId)
        {
            iGraphicCardRepository.DeleteItem(graphicCardId);
            iGraphicCardRepository.Save();
        }

        public void UpdateItem(GraphicsCardDto graphicCard)
        {
            iGraphicCardRepository.UpdateItem(Mapper.Map<GraphicsCardDto, GraphicsCardDb>(graphicCard));
            iGraphicCardRepository.Save();
        }
    }
}
