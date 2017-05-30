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
    class ComputerServiceTest
    {
        [Test]
        public void GetComputersTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<ComputerDb>> mock = new Mock<IGenericRepository<ComputerDb>>();

            var computers = new ComputerDb[]
            {
                new ComputerDb
                {
                    ComputerCasingId = 1,DriveId = 1,GraphicsCardId = 1,
                    HardDriveId = 1, Id = 1, MotherboardId = 1,PowerSupplyId = 1,RamId = 1,NetworkCardId = 1,SoundCardId = 1,ProcesorId = 1},
                new ComputerDb
                {
                    ComputerCasingId = 2,DriveId = 2,GraphicsCardId = 2,
                    HardDriveId = 2, Id = 2, MotherboardId = 2,PowerSupplyId = 2,RamId = 2,NetworkCardId = 2,SoundCardId = 2,ProcesorId = 2}

            }.AsEnumerable();

            mock.Setup(m => m.GetAll()).Returns(computers);

            var dto = Mapper.Map<IEnumerable<ComputerDb>, IEnumerable<ComputerDto>>(computers).ToList();

            IGenericService<ComputerDto> service = new ComputerService(mock.Object);
            var actual = service.GetAll().ToList();

            CollectionAssert.AreEqual(dto, actual);
        }


        [Test]
        public void GetComputerByIdTest()
        {
            MapperConfig.Configuration();

            Mock<IGenericRepository<ComputerDb>> mock = new Mock<IGenericRepository<ComputerDb>>();

            var computers = new ComputerDb[]
            {
                new ComputerDb
                {
                    ComputerCasingId = 1,DriveId = 1,GraphicsCardId = 1,
                    HardDriveId = 1, Id = 1, MotherboardId = 1,PowerSupplyId = 1,RamId = 1,NetworkCardId = 1,SoundCardId = 1,ProcesorId = 1},
                new ComputerDb
                {
                    ComputerCasingId = 2,DriveId = 2,GraphicsCardId = 2,
                    HardDriveId = 2, Id = 2, MotherboardId = 2,PowerSupplyId = 2,RamId = 2,NetworkCardId = 2,SoundCardId = 2,ProcesorId = 2}



            }.AsEnumerable();

            mock.Setup(m => m.GetItemById(It.IsAny<int>())).Returns((int i) => computers.Where(u => u.Id == i).Single());

            var dto = Mapper.Map<IEnumerable<ComputerDb>, IEnumerable<ComputerDto>>(computers).ToList();

            IGenericService<ComputerDto> service = new ComputerService(mock.Object);

            var actual = service.GetItemById(1);

            Assert.Contains(actual, dto);

        }
    }
}
