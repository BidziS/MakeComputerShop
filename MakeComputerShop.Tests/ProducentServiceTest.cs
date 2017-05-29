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
    public class ProducentServiceTest
    {
        [Test]
        public void GetProducentsTest()
        {
            //ProducentController controller = new ProducentController();

            //var actual = controller.Producents();
            MapperConfig.Configuration();
            //Assert.IsInstanceOf<ActionResult>(actual);
            Mock<IProducentRepository> mock = new Mock<IProducentRepository>();

            var producents = new ProducentDb[]
            {
                new ProducentDb {Id = 1, Name = "Intel"},
                new ProducentDb {Id = 2, Name = "Gigabyte"},

            }.AsEnumerable();

            mock.Setup(m => m.GetProducents()).Returns(producents);

            var dto = Mapper.Map<IEnumerable<ProducentDb>, IEnumerable<ProducentDto>>(producents).ToList();

            IProducentService service = new ProducentService(mock.Object);
            var actual = service.GetProducents().ToList();

            CollectionAssert.AreEqual(dto,actual);
        }


        [Test]
        public void GetProducentByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IProducentRepository> mock = new Mock<IProducentRepository>();

            mock.Setup(m => m.GetProducentById(1)).Returns(new ProducentDb());

            var dto = Mapper.Map<ProducentDb, ProducentDto>(new ProducentDb());

            IProducentService service = new ProducentService(mock.Object);

            var actual = service.GetProducentById(1);

            Assert.AreEqual(dto, actual);

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
