using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Web.Controllers;
using NUnit.Framework;
using System.Web.Mvc;
using AutoMapper;
using MakeComputerShop.Bll;
using MakeComputerShop.Bll.Services;
using MakeComputerShop.Bll.Services.Impl;
using MakeComputerShop.Dal.Repositories;
using Moq;
using NUnit.Framework.Internal;
using MakeComputerShop.Bll.Dtos;
using WebGrease.Css.Extensions;
namespace MakeComputerShop.Tests
{
    [TestFixture]
    class GraphicCardServiceTest
    {
        [Test]
        public void GetGraphicCardTest()
        {
            MapperConfig.Configuration();

            Mock<IGraphicsCardRepository> mock = new Mock<IGraphicsCardRepository>();

            var graphicCard = new GraphicsCardDb[]
            {
                //new GraphicsCardDb{}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetGraphicCard()).Returns(graphicCard);

            var dto = Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicCardDto>>(graphicCard).ToList();

            IGraphicCardService service = new GraphicCardService(mock.Object);

            var actual = service.GetGraphicCard().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        [Test]
        public void GetGraphicCardByProducentIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGraphicsCardRepository> mock = new Mock<IGraphicsCardRepository>();

            var graphicCard = new GraphicsCardDb[]
            {
                //new GraphicsCardDb{}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetGraphicCardByProducentId(1)).Returns(graphicCard);

            var dto = Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicCardDto>>(graphicCard).ToList();

            IGraphicCardService service = new GraphicCardService(mock.Object);

            var actual = service.GetGraphicCardByProducentId(1).ToList();

            CollectionAssert.AreEqual(dto, actual);
        }


        [Test]
        public void GetGraphicCardByChipsetTest()
        {
            MapperConfig.Configuration();

            Mock<IGraphicsCardRepository> mock = new Mock<IGraphicsCardRepository>();

            var graphicCard = new GraphicsCardDb[]
            {
                //new GraphicsCardDb{}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetGraphicCardByChipset(1)).Returns(graphicCard);

            var dto = Mapper.Map<IEnumerable<GraphicsCardDb>, IEnumerable<GraphicCardDto>>(graphicCard).ToList();

            IGraphicCardService service = new GraphicCardService(mock.Object);

            var actual = service.GetGraphicCardByChipset(1).ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        [Test]
        public void GetGraphicCardByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGraphicsCardRepository> mock = new Mock<IGraphicsCardRepository>();

            mock.Setup(m => m.GetGraphicCardById(1)).Returns(new GraphicsCardDb());

            var dto = Mapper.Map<GraphicsCardDb, GraphicCardDto>(new GraphicsCardDb());

            IGraphicCardService service = new GraphicCardService(mock.Object);

            var actual = service.GetGraphicCardById(1);

            Assert.AreEqual(dto, actual);

        }
    }
}
