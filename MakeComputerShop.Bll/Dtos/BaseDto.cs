using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }
        public override bool Equals(object obj)
        {
            var toCompareWith = obj as BaseDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.Price == toCompareWith.Price &&
                   this.ImageUrl == toCompareWith.ImageUrl;

        }
    }
}
