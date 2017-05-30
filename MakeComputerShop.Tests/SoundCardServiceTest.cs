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
    class SoundCardServiceTest
    {
        [Test]
        public void GetRamsTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<SoundCardDb>> mock = new Mock<IGenericRepository<SoundCardDb>>();

            var soundCards = new SoundCardDb[]
            {
                new SoundCardDb{Id = 1,ImageUrl = "fgdwf",Interface = "PCI",Name = "karta dźwiekowa",Price = 200,Producent = new ProducentDb(),ProducentId = 1,SoundSystem = 5},
                new SoundCardDb{Id = 2,ImageUrl = "fgfdsfddwf",Interface = "PCI16",Name = "karta dźwiekowa 1",Price = 220,Producent = new ProducentDb(),ProducentId = 2,SoundSystem = 5},
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(soundCards);

            var dto = Mapper.Map<IEnumerable<SoundCardDb>, IEnumerable<SoundCardDto>>(soundCards).ToList();

            IGenericService<SoundCardDto> service = new SoundCardService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }
        [Test]
        public void GetRamByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<SoundCardDb>> mock = new Mock<IGenericRepository<SoundCardDb>>();

            var soundCards = new SoundCardDb[]
            {
                new SoundCardDb{Id = 1,ImageUrl = "fgdwf",Interface = "PCI",Name = "karta dźwiekowa",Price = 200,Producent = new ProducentDb(),ProducentId = 1,SoundSystem = 5},
                new SoundCardDb{Id = 2,ImageUrl = "fgfdsfddwf",Interface = "PCI16",Name = "karta dźwiekowa 1",Price = 220,Producent = new ProducentDb(),ProducentId = 2,SoundSystem = 5},
            }.AsEnumerable();


            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => soundCards.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<SoundCardDb>, IEnumerable<SoundCardDto>>(soundCards).ToList();

            IGenericService<SoundCardDto> service = new SoundCardService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
