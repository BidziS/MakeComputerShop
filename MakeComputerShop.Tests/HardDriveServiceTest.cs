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
    class HardDriveServiceTest
    {
        [Test]
        public void GetHardDrivesTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<HardDriveDb>> mock = new Mock<IGenericRepository<HardDriveDb>>();

            var hardDrives = new HardDriveDb[]
            {
                new HardDriveDb{CacheMemory = 64,Capacity = 100,HardDriveType = HardDriveType.magnetic,Id = 1,ImageUrl = "hgudfeihgf",Name = "dysk1",Price = 300,Producent = new ProducentDb(),ProducentId = 1,WidthFormat = 100},
                new HardDriveDb{CacheMemory = 64,Capacity = 40,HardDriveType = HardDriveType.SSD,Id = 2,ImageUrl = "hgufdsafdfeihgf",Name = "dysk2",Price = 350,Producent = new ProducentDb(),ProducentId = 2,WidthFormat = 100}
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(hardDrives);

            var dto = Mapper.Map<IEnumerable<HardDriveDb>, IEnumerable<HardDriveDto>>(hardDrives).ToList();

            IGenericService<HardDriveDto> service = new HardDriveService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }


        [Test]
        public void GetGraphicCardByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<HardDriveDb>> mock = new Mock<IGenericRepository<HardDriveDb>>();

            var hardDrives = new HardDriveDb[]
            {
                new HardDriveDb{CacheMemory = 64,Capacity = 100,HardDriveType = HardDriveType.magnetic,Id = 1,ImageUrl = "hgudfeihgf",Name = "dysk1",Price = 300,Producent = new ProducentDb(),ProducentId = 1,WidthFormat = 100},
                new HardDriveDb{CacheMemory = 64,Capacity = 40,HardDriveType = HardDriveType.SSD,Id = 2,ImageUrl = "hgufdsafdfeihgf",Name = "dysk2",Price = 350,Producent = new ProducentDb(),ProducentId = 2,WidthFormat = 100}
            }.AsEnumerable();


            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => hardDrives.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<HardDriveDb>, IEnumerable<HardDriveDto>>(hardDrives).ToList();

            IGenericService<HardDriveDto> service = new HardDriveService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
