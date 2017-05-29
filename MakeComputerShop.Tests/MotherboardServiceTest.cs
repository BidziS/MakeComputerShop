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
    class MotherboardServiceTest
    {
        [Test]
        public void GetMotherboardsTest()
        {
            MapperConfig.Configuration();

            Mock<IMotherboardRepository> mock = new Mock<IMotherboardRepository>();

            var motherboard = new MotherboardDb[]
            {
                //new MotherboardDb{}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetMotherboards()).Returns(motherboard);

            var dto = Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(motherboard).ToList();

            IMotherboardService service = new MotherboardService(mock.Object);

            var actual = service.GetMotherboards().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        //[Test]
        //public void GetMotherboardByProducentIdTest()
        //{
        //    MapperConfig.Configuration();

        //    Mock<IMotherboardRepository> mock = new Mock<IMotherboardRepository>();

        //    var motherboard = new MotherboardDb[]
        //    {
        //        //new MotherboardDb{}, 
        //    }.AsEnumerable();

        //    mock.Setup(m => m.GetMotherboardsByProducentId(1)).Returns(motherboard);

        //    var dto = Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(motherboard).ToList();

        //    IMotherboardService service = new MotherboardService(mock.Object);

        //    var actual = service.GetMotherboardsByProducentId(1).ToList();

        //    CollectionAssert.AreEqual(dto, actual);
        //}

        //[Test]
        //public void GetMotherboardBySocketTest()
        //{
        //    MapperConfig.Configuration();

        //    Mock<IMotherboardRepository> mock = new Mock<IMotherboardRepository>();

        //    var motherboard = new MotherboardDb[]
        //    {
        //        //new MotherboardDb{}, 
        //    }.AsEnumerable();

        //    mock.Setup(m => m.GetMotherboardsBySocket(1)).Returns(motherboard);

        //    var dto = Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(motherboard).ToList();

        //    IMotherboardService service = new MotherboardService(mock.Object);

        //    var actual = service.GetMotherboardsBySocket(1).ToList();

        //    CollectionAssert.AreEqual(dto, actual);
        //}

        //[Test]
        //public void GetMotherboardByChipset()
        //{
        //    MapperConfig.Configuration();

        //    Mock<IMotherboardRepository> mock = new Mock<IMotherboardRepository>();

        //    var motherboard = new MotherboardDb[]
        //    {
        //        //new MotherboardDb{}, 
        //    }.AsEnumerable();

        //    mock.Setup(m => m.GetMotherboardsByChipset(1)).Returns(motherboard);

        //    var dto = Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(motherboard).ToList();

        //    IMotherboardService service = new MotherboardService(mock.Object);

        //    var actual = service.GetMotherboardsByChipset(1).ToList();

        //    CollectionAssert.AreEqual(dto, actual);
        //}

        //[Test]
        //public void GetMotherboardByIdTest()
        //{
        //    MapperConfig.Configuration();

        //    Mock<IMotherboardRepository> mock = new Mock<IMotherboardRepository>();

        //    mock.Setup(m => m.GetMotherboardById(3)).Returns(new MotherboardDb());

        //    var dto = Mapper.Map<MotherboardDb, MotherboardDto>(new MotherboardDb());

        //    IMotherboardService service = new MotherboardService(mock.Object);

        //    var actual = service.GetMotherboardById(3);

        //    Assert.AreEqual(dto, actual);

        //}
    }
}
