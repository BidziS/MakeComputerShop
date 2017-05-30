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
    class MotherboardServiceTest
    {
        [Test]
        public void GetMotherboardTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<MotherboardDb>> mock = new Mock<IGenericRepository<MotherboardDb>>();

            var motherboard = new MotherboardDb[]
            {
                new MotherboardDb{Id = 1,MaxMemory = 16,Name = "płyta główna 1",ProducentId = 1,RAMType = RamType.DDR3,Price = 200,ImageUrl = "fdswfds"}
            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(motherboard);

            var dto = Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(motherboard).ToList();

            IGenericService<MotherboardDto> service = new MotherboardService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }


        [Test]
        public void GetMotherboardByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<MotherboardDb>> mock = new Mock<IGenericRepository<MotherboardDb>>();

            var motherboards = new MotherboardDb[]
            {
                new MotherboardDb{Id = 1,MaxMemory = 16,Name = "płyta główna 1",ProducentId = 1,RAMType = RamType.DDR3,Price = 200,ImageUrl = "fdswfds"},
                new MotherboardDb{Id = 2,MaxMemory = 16,Name = "płyta główna 2",ProducentId = 2,RAMType = RamType.DDR4,Price = 300,ImageUrl = "fgdfagdswfds"}
            }.AsEnumerable();

            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => motherboards.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<MotherboardDb>, IEnumerable<MotherboardDto>>(motherboards).ToList();

            IGenericService<MotherboardDto> service = new MotherboardService(mock.Object);



            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
