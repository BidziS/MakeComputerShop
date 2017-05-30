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
    class NetworkCardServiceTest
    {
        [Test]
        public void GetNetowrkCardsTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<NetworkCardDb>> mock = new Mock<IGenericRepository<NetworkCardDb>>();

            var networkCards = new NetworkCardDb []
            {
                new NetworkCardDb{Id = 1,ImageUrl = "ghdfshg",Name = "karta",Price = 100,Producent = new ProducentDb(),ProducentId = 1,Standard = "802.11"},
                new NetworkCardDb{Id = 2,ImageUrl = "ghdfdsffshg",Name = "karta2",Price = 120,Producent = new ProducentDb(),ProducentId = 2,Standard = "802.11"}
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(networkCards);

            var dto = Mapper.Map<IEnumerable<NetworkCardDb>, IEnumerable<NetworkCardDto>>(networkCards).ToList();

            IGenericService<NetworkCardDto> service = new NetworkCardService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }
        [Test]
        public void GetNetworkCardByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<NetworkCardDb>> mock = new Mock<IGenericRepository<NetworkCardDb>>();

            var networkCards = new NetworkCardDb[]
            {
                new NetworkCardDb{Id = 1,ImageUrl = "ghdfshg",Name = "karta",Price = 100,Producent = new ProducentDb(),ProducentId = 1,Standard = "802.11"},
                new NetworkCardDb{Id = 2,ImageUrl = "ghdfdsffshg",Name = "karta2",Price = 120,Producent = new ProducentDb(),ProducentId = 2,Standard = "802.11"}
            }.AsEnumerable();


            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => networkCards.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<NetworkCardDb>, IEnumerable<NetworkCardDto>>(networkCards).ToList();

            IGenericService<NetworkCardDto> service = new NetworkCardService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
