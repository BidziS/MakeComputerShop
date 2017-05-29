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
    class RamServiceTest
    {
        [Test]
        public void GetRamsTest()
        {
            MapperConfig.Configuration();

            Mock<IRamRepository> mock = new Mock<IRamRepository>();

            var ram = new RamDb[]
            {
                //new RamDb{}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetRams()).Returns(ram);

            var dto = Mapper.Map<IEnumerable<RamDb>, IEnumerable<RamDto>>(ram).ToList();

            IRamService service = new RamService(mock.Object);

            var actual = service.GetRams().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        [Test]
        public void GetRamByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IRamRepository> mock = new Mock<IRamRepository>();

            mock.Setup(m => m.GetRamById(1)).Returns(new RamDb());

            var dto = Mapper.Map<RamDb, RamDto>(new RamDb());

            IRamService service = new RamService(mock.Object);

            var actual = service.GetRamById(1);

            Assert.AreEqual(dto, actual);

        }
    }
}
