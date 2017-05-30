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
    class RamServiceTest
    {
        [Test]
        public void GetRamsTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<RamDb>> mock = new Mock<IGenericRepository<RamDb>>();

            var rams = new RamDb[]
            {
                new RamDb{Frequency = 128,Id = 1,ImageUrl = "fgdsf",Name = "ram1",RAMType = RamType.DDR3,Price = 300},
                new RamDb{Frequency = 128,Id = 2,ImageUrl = "fgdsfdsfdsf",Name = "ram2",RAMType = RamType.DDR3,Price = 350},
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(rams);

            var dto = Mapper.Map<IEnumerable<RamDb>, IEnumerable<RamDto>>(rams).ToList();

            IGenericService<RamDto> service = new RamService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }

        [Test]
        public void GetRamByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<RamDb>> mock = new Mock<IGenericRepository<RamDb>>();

            var rams = new RamDb[]
            {
                new RamDb{Frequency = 128,Id = 1,ImageUrl = "fgdsf",Name = "ram1",RAMType = RamType.DDR3,Price = 300},
                new RamDb{Frequency = 128,Id = 2,ImageUrl = "fgdsfdsfdsf",Name = "ram2",RAMType = RamType.DDR3,Price = 350},
            }.AsEnumerable();


            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => rams.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<RamDb>, IEnumerable<RamDto>>(rams).ToList();

            IGenericService<RamDto> service = new RamService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
