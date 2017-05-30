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
using MakeComputerShop.Dal.Repositories.impl;
namespace MakeComputerShop.Tests
{
    class DriveServiceTest
    {
        [Test]
        public void GetDrivesTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<DriveDb>> mock = new Mock<IGenericRepository<DriveDb>>();

            var drives = new DriveDb[]
            {
                new DriveDb{AccessTime = 145,DriverTypes = DriveDb.DriverType.Cd,Id = 1,ImageUrl = "fdsf",Interface = "sata",Name = "LG20",Price = 100,Producent = new ProducentDb(),ProducentId = 1},
                new DriveDb{AccessTime = 145,DriverTypes = DriveDb.DriverType.Dvd,Id = 2,ImageUrl = "ffdsfdsaf",Interface = "sata",Name = "LG220",Price = 100,Producent = new ProducentDb(),ProducentId = 1}
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(drives);

            var dto = Mapper.Map<IEnumerable<DriveDb>, IEnumerable<DriveDto>>(drives).ToList();

            IGenericService<DriveDto> service = new DriveService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }


        [Test]
        public void GetDriveByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<DriveDb>> mock = new Mock<IGenericRepository<DriveDb>>();

            var drives = new DriveDb[]
            {
                new DriveDb{AccessTime = 145,DriverTypes = DriveDb.DriverType.Cd,Id = 1,ImageUrl = "fdsf",Interface = "sata",Name = "LG20",Price = 100,Producent = new ProducentDb(),ProducentId = 1},
                new DriveDb{AccessTime = 145,DriverTypes = DriveDb.DriverType.Dvd,Id = 2,ImageUrl = "ffdsfdsaf",Interface = "sata",Name = "LG220",Price = 100,Producent = new ProducentDb(),ProducentId = 1}
            }.AsEnumerable();


            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => drives.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<DriveDb>, IEnumerable<DriveDto>>(drives).ToList();

            IGenericService<DriveDto> service = new DriveService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
