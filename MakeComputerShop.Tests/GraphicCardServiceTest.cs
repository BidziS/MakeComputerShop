using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using NUnit.Framework;
using AutoMapper;
using MakeComputerShop.Bll;
using MakeComputerShop.Bll.Services;
using MakeComputerShop.Bll.Services.Impl;
using MakeComputerShop.Dal.Repositories;
using Moq;
using NUnit.Framework.Internal;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Models.MotherboardElements;
using MakeComputerShop.Dal.Repositories.impl;


namespace MakeComputerShop.Tests
{
    class GraphicCardServiceTest
    {
        [Test]
        public void GetGraphicCardsTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<GraphicsCardDb>> mock = new Mock<IGenericRepository<GraphicsCardDb>>();

            var graphicCards = new GraphicsCardDb[]
            {
                new GraphicsCardDb{Chipset = new ChipsetDb(),ChipsetId = 3,Connector = "PCIExpres",DataBusBit = 128,Id = 1,ImageUrl = "fdswf",MemorySize = 4,Name = "geforce 1040",Price = 700,Producent = new ProducentDb(),ProducentId = 1},
                new GraphicsCardDb{Chipset = new ChipsetDb(),ChipsetId = 4,Connector = "PCIExpres",DataBusBit = 128,Id = 2,ImageUrl = "fdfdsafdswf",MemorySize = 4,Name = "geforce 1050",Price = 750,Producent = new ProducentDb(),ProducentId = 2}
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(graphicCards);

            var dto = Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicsCardDto>>(graphicCards).ToList();

            IGenericService<GraphicsCardDto> service = new GraphicsCardService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }


        [Test]
        public void GetGraphicCardByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<GraphicsCardDb>> mock = new Mock<IGenericRepository<GraphicsCardDb>>();

            var graphicCards = new GraphicsCardDb[]
            {
                new GraphicsCardDb{Chipset = new ChipsetDb(),ChipsetId = 3,Connector = "PCIExpres",DataBusBit = 128,Id = 1,ImageUrl = "fdswf",MemorySize = 4,Name = "geforce 1040",Price = 700,Producent = new ProducentDb(),ProducentId = 1},
                new GraphicsCardDb{Chipset = new ChipsetDb(),ChipsetId = 4,Connector = "PCIExpres",DataBusBit = 128,Id = 2,ImageUrl = "fdfdsafdswf",MemorySize = 4,Name = "geforce 1050",Price = 750,Producent = new ProducentDb(),ProducentId = 2}
            }.AsEnumerable();


            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => graphicCards.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicsCardDto>>(graphicCards).ToList();

            IGenericService<GraphicsCardDto> service = new GraphicsCardService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
