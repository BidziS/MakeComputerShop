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
    class PowerSupplyServiceTest
    {
        [Test]
        public void GetPowerSupplsTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<PowerSupplyDb>> mock = new Mock<IGenericRepository<PowerSupplyDb>>();

            var powerSuppls = new PowerSupplyDb[]
            {
                new PowerSupplyDb{Id = 1,ImageUrl = "fgdwsa",Name = "zasialacz",Power = 50,Price = 300,Producent = new ProducentDb(),ProducentId = 1},
                new PowerSupplyDb{Id = 2,ImageUrl = "fgdwfdfssa",Name = "zasialacz2",Power = 40,Price = 330,Producent = new ProducentDb(),ProducentId = 2}
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(powerSuppls);

            var dto = Mapper.Map<IEnumerable<PowerSupplyDb>, IEnumerable<PowerSupplyDto>>(powerSuppls).ToList();

            IGenericService<PowerSupplyDto> service = new PowerSupplyService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }
        [Test]
        public void GetPowerSupplyByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<PowerSupplyDb>> mock = new Mock<IGenericRepository<PowerSupplyDb>>();

            var powerSuppls = new PowerSupplyDb[]
            {
                new PowerSupplyDb{Id = 1,ImageUrl = "fgdwsa",Name = "zasialacz",Power = 50,Price = 300,Producent = new ProducentDb(),ProducentId = 1},
                new PowerSupplyDb{Id = 2,ImageUrl = "fgdwfdfssa",Name = "zasialacz2",Power = 40,Price = 330,Producent = new ProducentDb(),ProducentId = 2}
            }.AsEnumerable();

            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => powerSuppls.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<PowerSupplyDb>, IEnumerable<PowerSupplyDto>>(powerSuppls).ToList();

            IGenericService<PowerSupplyDto> service = new PowerSupplyService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
