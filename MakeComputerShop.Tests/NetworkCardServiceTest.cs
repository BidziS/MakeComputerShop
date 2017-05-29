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
    class NetworkCardServiceTest
    {
        [Test]
        public void GetNetworkCardTest()
        {
            MapperConfig.Configuration();

            Mock<INetworkCardRepository> mock = new Mock<INetworkCardRepository>();

            var networkCard = new NetworkCardDb[]
            {
                new NetworkCardDb{}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetNetworkCard()).Returns(networkCard);

            var dto = Mapper.Map<IEnumerable<NetworkCardDb>, IEnumerable<NetworkCardDto>>(networkCard).ToList();

            INetworkCardService service = new NetworkCardService(mock.Object);

            var actual = service.GetNetworkCard().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        [Test]
        public void GetNetworkCardByProducentIdTest()
        {
            MapperConfig.Configuration();

            Mock<INetworkCardRepository> mock = new Mock<INetworkCardRepository>();

            var networkCard = new NetworkCardDb[]
            {
                new NetworkCardDb{},
            }.AsEnumerable();

            mock.Setup(m => m.GetNetworkCardByProducentId(1)).Returns(networkCard);

            var dto = Mapper.Map<IEnumerable<NetworkCardDb>, IEnumerable<NetworkCardDto>>(networkCard).ToList();

            INetworkCardService service = new NetworkCardService(mock.Object);

            var actual = service.GetNetworkCardByProducentId(1).ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        [Test]
        public void GetNetworkCardByIdTest()
        {
            MapperConfig.Configuration();

            Mock<INetworkCardRepository> mock = new Mock<INetworkCardRepository>();

            mock.Setup(m => m.GetNetworkCardById(1)).Returns(new NetworkCardDb());

            var dto = Mapper.Map<NetworkCardDb, NetworkCardDto>(new NetworkCardDb());

            INetworkCardService service = new NetworkCardService(mock.Object);

            var actual = service.GetNetworkCardById(1);

            Assert.AreEqual(dto, actual);

        }
    }
}
