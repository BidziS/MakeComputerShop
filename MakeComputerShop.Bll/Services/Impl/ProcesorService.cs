using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Dal.Repositories;

namespace MakeComputerShop.Bll.Services.Impl
{
    public class ProcesorService:IGenericService<ProcesorDto>
    {
        private IGenericRepository<ProcesorDb> procesorRepository;

        public ProcesorService(IGenericRepository<ProcesorDb> procesorRepository)
        {
            this.procesorRepository = procesorRepository;
        }

        public IEnumerable<ProcesorDto> GetAll()
        {
            return Mapper.Map<IEnumerable<ProcesorDb>, IEnumerable<ProcesorDto>>(procesorRepository.GetAll());
        }

        public ProcesorDto GetItemById(int itemId)
        {
            return Mapper.Map<ProcesorDb, ProcesorDto>(procesorRepository.GetItemById(itemId));
        }

        public void InsertItem(ProcesorDto item)
        {
            procesorRepository.InsertItem(Mapper.Map<ProcesorDto,ProcesorDb>(item));
        }

        public void DeleteItem(int itemId)
        {
            procesorRepository.DeleteItem(itemId);
            procesorRepository.Save();
        }

        public void UpdateItem(ProcesorDto item)
        {
            procesorRepository.UpdateItem(Mapper.Map<ProcesorDto, ProcesorDb>(item));
            procesorRepository.Save();
        }
    }
}
