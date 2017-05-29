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
    class ComputerCasingServiceTest
    {
        [Test]
        public void GetComputerCasingsTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<ComputerCasingDb>> mock = new Mock<IGenericRepository<ComputerCasingDb>>();

            var computerCasings = new ComputerCasingDb[]
            {
                new ComputerCasingDb{CasingType = CasingType.MiniTower,Depth = 20,Height = 44,Id = 1,ImageUrl = "hfudhf",Name = "Obudowa1",Price = 150,
                    Producent = new ProducentDb{Id = 1,Name = "intel"} ,ProducentId = 1,Width = 44}, 
                new ComputerCasingDb{CasingType = CasingType.FullTower,Depth = 50,Height = 64,Id = 2,ImageUrl = "fdsaf",Name = "Obudowa2",Price = 150,
                    Producent = new ProducentDb{Id = 2,Name = "gigabyte"} ,ProducentId = 2,Width = 64}, 

            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(computerCasings);

            var dto = Mapper.Map<IEnumerable<ComputerCasingDb>, IEnumerable<ComputerCasingDto>>(computerCasings).ToList();

            IGenericService<ComputerCasingDto> service = new ComputerCasingService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }


        [Test]
        public void GetComputerCasingByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<ComputerCasingDb>> mock = new Mock<IGenericRepository<ComputerCasingDb>>();

            var computerCasings = new ComputerCasingDb[]
            {
                new ComputerCasingDb{CasingType = CasingType.MiniTower,Depth = 20,Height = 44,Id = 1,ImageUrl = "hfudhf",Name = "Obudowa1",Price = 150,
                    Producent = new ProducentDb{Id = 1,Name = "intel"} ,ProducentId = 1,Width = 44},
                new ComputerCasingDb{CasingType = CasingType.FullTower,Depth = 50,Height = 64,Id = 2,ImageUrl = "fdsaf",Name = "Obudowa2",Price = 150,
                    Producent = new ProducentDb{Id = 2,Name = "gigabyte"} ,ProducentId = 2,Width = 64},

            }.AsEnumerable();

            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => computerCasings.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<ComputerCasingDb>, IEnumerable<ComputerCasingDto>>(computerCasings).ToList();

            IGenericService<ComputerCasingDto> service = new ComputerCasingService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
