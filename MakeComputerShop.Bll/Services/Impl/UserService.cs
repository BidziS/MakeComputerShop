using AutoMapper;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Services.Impl
{
    public class UserService : IGenericService<UserDto>
    {
        IGenericRepository<UserDb> iUserRepository; 

        public UserService(IGenericRepository<UserDb> iUserRepository)
        {
            this.iUserRepository = iUserRepository;
        }

        public void DeleteItem(int itemId)
        {
            iUserRepository.DeleteItem(itemId);
            iUserRepository.Save();
        }

        public IEnumerable<UserDto> GetAll()
        {
            return Mapper.Map<IEnumerable<UserDb>, IEnumerable<UserDto>>(iUserRepository.GetAll());
        }

        public UserDto GetItemById(int itemId)
        {
            return Mapper.Map<UserDb, UserDto>(iUserRepository.GetItemById(itemId));
        }

        public void InsertItem(UserDto item)
        {
            iUserRepository.InsertItem(Mapper.Map<UserDto, UserDb>(item));
            iUserRepository.Save();
        }

        public void UpdateItem(UserDto item)
        {
            iUserRepository.UpdateItem(Mapper.Map<UserDto, UserDb>(item));
            iUserRepository.Save();
        }
    }
}
