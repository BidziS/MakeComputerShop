using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;

namespace MakeComputerShop.Dal.Repositories.impl
{
    public class UserRepository : IUserRepository
    {
        ShopContext context;

        public UserRepository(ShopContext context)
        {
            this.context = context;
        }

        public void DeleteItem(int userId)
        {
            UserDb user = GetItemById(userId);
            context.Users.Remove(user);
        }

        public UserDb GetItemById(int userId)
        {
            return context.Users.Find(userId);
        }

        public IEnumerable<UserDb> GetAll()
        {
            return context.Users.ToList();
        }

        public void InsertItem(UserDb user)
        {
            context.Users.Add(user);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateItem(UserDb user)
        {
            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }

        public UserDb GetItemByEmail(string name)
        {
            var user = context.Users
                .Include(c => c.Computer)
                .FirstOrDefault(u => u.Email == name);

            if (user.Computer == null)
            {
                var newComputer = context.Computers.Add(new ComputerDb());
                context.Entry(newComputer).State = EntityState.Added;
                user.Computer = context.Computers.ToList().Last();
                context.SaveChanges();
            }

            return context.Users
                .Include(c => c.Computer)
                .Include(c => c.Computer.Drive.Producent)
                .Include(c => c.Computer.ComputerCasing.Producent).Include(c => c.Computer.GraphicsCard.Producent)
                .Include(c => c.Computer.HardDrive.Producent).Include(c => c.Computer.Motherboard)
                .Include(c => c.Computer.NetworkCard.Producent).Include(c => c.Computer.PowerSupply.Producent)
                .Include(c => c.Computer.Procesor).Include(c => c.Computer.Ram)
                .Include(c => c.Computer.SoundCard.Producent).Include(c => c.Computer.Procesor.Producent)
                .Include(c => c.Computer.Procesor.Socket)
                .Include(c => c.Computer.Motherboard.Socket).Include(c => c.Computer.Motherboard.Producent)
                .Include(c => c.Computer.Motherboard.Chipset)
                .FirstOrDefault(u => u.Email == name);
        }
    }
}
