using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Web.Controllers;
using NUnit.Framework;
using AutoMapper;
using MakeComputerShop.Bll;
using MakeComputerShop.Bll.Services;
using MakeComputerShop.Bll.Services.Impl;
using MakeComputerShop.Dal.Repositories;
using Moq;
using NUnit.Framework.Internal;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Repositories.impl;

namespace MakeComputerShop.Tests
{
    [TestFixture]
    public class ProducentServiceTest
    {
        [Test]
        public void GetProducentsTest()
        {
            MapperConfig.Configuration();
           
            Mock<IGenericRepository<ProducentDb>> mock = new Mock<IGenericRepository<ProducentDb>>();

            var producents = new ProducentDb[]
            {
                new ProducentDb {Id = 1, Name = "Intel"},
                new ProducentDb {Id = 2, Name = "Gigabyte"},

            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(producents);

            var dto = Mapper.Map<IEnumerable<ProducentDb>, IEnumerable<ProducentDto>>(producents).ToList();

            IGenericService<ProducentDto> service = new ProducentService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto,actual);
        }


        [Test]
        public void GetProducentByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<ProducentDb>> mock = new Mock<IGenericRepository<ProducentDb>>();

            var producents = new ProducentDb[]
            {
                new ProducentDb {Id = 1, Name = "Intel"},
                new ProducentDb {Id = 2, Name = "Gigabyte"},
            }.AsEnumerable();

            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => producents.Where(u=>u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<ProducentDb>, IEnumerable<ProducentDto>>(producents).ToList();

            IGenericService<ProducentDto> service = new ProducentService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }





        //[Test]
        //public void DeleteProducentTest()
        //{
        //    MapperConfig.Configuration();

        //    Mock<IProducentRepository> mock = new Mock<IProducentRepository>();

        //    mock.Setup(m => m.DeleteProducent(1));

        //    var dto = Mapper.Map<ProducentDb, ProducentDto>(new ProducentDb{Id = 1,Name = "Intel"});

        //    IProducentService service = new ProducentService(mock.Object);

        //    service.DeleteProducent(1);

        //    Assert.AreEqual(dto,se);




        //}
    }
}