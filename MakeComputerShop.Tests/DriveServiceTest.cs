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
    class DriveServiceTest
    {
        [Test]
        public void GetDrivesTest()
        {
            MapperConfig.Configuration();

            Mock<IDriveRepository> mock = new Mock<IDriveRepository>();

            var drive = new DriveDb[]
            {
               // new DriveDb {}, 
            }.AsEnumerable();

            mock.Setup(m => m.GetDrives()).Returns(drive);

            var dto = Mapper.Map<IEnumerable<DriveDb>, IEnumerable<DriveDto>>(drive).ToList();

            IDriveService service = new DriveService(mock.Object);

            var actual = service.GetDrives().ToList();

            CollectionAssert.AreEqual(dto,actual);
        }

        [Test]
        public void GetDriveByProducentIdTest()
        {
            MapperConfig.Configuration();

            Mock<IDriveRepository> mock = new Mock<IDriveRepository>();

            var drive = new DriveDb[]
            {
                //new ComputerCasingDb{},
            }.AsEnumerable();

            mock.Setup(m => m.GetDrivesByProducentId(1)).Returns(drive);

            var dto = Mapper.Map<IEnumerable<DriveDb>, IEnumerable<DriveDto>>(drive).ToList();

            IDriveService service = new DriveService(mock.Object);

            var actual = service.GetDrivesByProducentId(1).ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        [Test]
        public void GetDriveById()
        {
            MapperConfig.Configuration();

            Mock<IDriveRepository> mock = new Mock<IDriveRepository>();

            mock.Setup(m => m.GetDriveById(1)).Returns(new DriveDb());

            var dto = Mapper.Map<DriveDb, DriveDto>(new DriveDb());

            IDriveService service = new DriveService(mock.Object);

            var actual = service.GetDriveById(1);

            Assert.AreEqual(dto, actual);

        }
    }
}
