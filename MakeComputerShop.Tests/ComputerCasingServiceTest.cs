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
    class ComputerCasingServiceTest
    {
        [Test]
        public void GetComputerCasingsTest()
        {
            MapperConfig.Configuration();

            Mock<IComputerCasingRepository> mock = new Mock<IComputerCasingRepository>();

            var computerCasing = new ComputerCasingDb[]
            {
                //new ComputerCasingDb{}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetComputerCasings()).Returns(computerCasing);

            var dto = Mapper.Map<IEnumerable<ComputerCasingDb>, IEnumerable<ComputerCasingDto>>(computerCasing).ToList();

            IComputerCasingService service = new ComputerCasingService(mock.Object);

            var actual = service.GetComputerCasings().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }
        
        //[Test]
        //public void GetComputerCasingsByProducentIdTest()
        //{
        //    MapperConfig.Configuration();

        //    Mock<IComputerCasingRepository> mock = new Mock<IComputerCasingRepository>();

        //    var computerCasing = new ComputerCasingDb[]
        //    {
        //        //new ComputerCasingDb{},
        //    }.AsEnumerable();

        //    mock.Setup(m => m.GetComputerCasingsByProducentId(1)).Returns(computerCasing);

        //    var dto = Mapper.Map<IEnumerable<ComputerCasingDb>, IEnumerable<ComputerCasingDto>>(computerCasing).ToList();

        //    IComputerCasingService service = new ComputerCasingService(mock.Object);

        //    var actual = service.GetComputerCasingsByProducentId(1).ToList();

        //    CollectionAssert.AreEqual(dto,actual);
        //}

        [Test]
        public void GetComputerCasingByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IComputerCasingRepository> mock = new Mock<IComputerCasingRepository>();

            mock.Setup(m => m.GetComputerCasingById(3)).Returns(new ComputerCasingDb());

            var dto = Mapper.Map<ComputerCasingDb, ComputerCasingDto>(new ComputerCasingDb());

            IComputerCasingService service = new ComputerCasingService(mock.Object);

            var actual = service.GetComputerCasingById(3);

            Assert.AreEqual(dto, actual);

        }
    }
}
