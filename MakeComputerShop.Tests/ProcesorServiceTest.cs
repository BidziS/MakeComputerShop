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
using MakeComputerShop.Dal.Models.MotherboardElements;
using MakeComputerShop.Dal.Repositories.impl;

namespace MakeComputerShop.Tests
{
    class ProcesorServiceTest
    {
        [Test]
        public void GetProcesorsTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<ProcesorDb>> mock = new Mock<IGenericRepository<ProcesorDb>>();

            var procesors = new ProcesorDb[]
            {
                new ProcesorDb{Id = 1},
                new ProcesorDb{Id = 2}
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(procesors);

            var dto = Mapper.Map<IEnumerable<ProcesorDb>, IEnumerable<ProcesorDto>>(procesors).ToList();

            IGenericService<ProcesorDto> service = new ProcesorService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }
        [Test]
        public void GetProcesorByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<ProcesorDb>> mock = new Mock<IGenericRepository<ProcesorDb>>();

            var procesors = new ProcesorDb[]
            {
                new ProcesorDb{Cache = 128,Frequency = 3,Id = 1,ImageUrl = "gdsafg",Name = "procesor",NumberOfCores = 3,NumberOfThreads = 3,Price = 550,ProducentId = 1},
                new ProcesorDb{Cache = 128,Frequency = 3,Id = 2,ImageUrl = "gdsagfdsgfg",Name = "procesor1",NumberOfCores = 4,NumberOfThreads = 4,Price = 650,ProducentId = 2}
            }.AsEnumerable();


            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => procesors.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<ProcesorDb>, IEnumerable<ProcesorDto>>(procesors).ToList();

            IGenericService<ProcesorDto> service = new ProcesorService(mock.Object);
            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
