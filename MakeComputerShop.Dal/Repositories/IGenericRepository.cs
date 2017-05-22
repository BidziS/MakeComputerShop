using MakeComputerShop.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Repositories
{
    public interface IGenericRepository<T> 
    {
        IEnumerable<T> GetAll();
        T GetItemById(int itemId);
        void InsertItem(T item);
        void DeleteItem(int itemId);
        void UpdateItem(T item);
        void Save();
    }
}
