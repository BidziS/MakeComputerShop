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
    class UserServiceTest
    {
        [Test]
        public void GetuserTest()
        {
            MapperConfig.Configuration();

            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            var users = new UserDb[]
            {
                new UserDb{Email = "fsd",Id = 1},
                new UserDb{Email = "fdswfgds",Id = 2}
            }.AsEnumerable();

            mock.Setup(m => m.GetItemByEmail(It.IsAny<string>())).Returns((string i) => users.Where(u => u.Email == i).Single());

            var dto = Mapper.Map<IEnumerable<UserDb>, IEnumerable<UserDto>>(users).ToList();

            IUserService service = new UserService(mock.Object);

            var actual = service.GetItemByEmail("fsd");

            Assert.Contains(actual, dto);

        }
    }
}
