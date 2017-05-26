using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos;

namespace MakeComputerShop.Bll.Services
{
    public interface IGenericService<T>
    {
        IEnumerable<T> GetAll();
        T GetItemById(int itemId);
        void InsertItem(T item);
        void DeleteItem(int itemId);
        void UpdateItem(T item);
    }
}
