using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Bll.Dtos
{
    public class ProducentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public override bool Equals(object obj)
        {
            var toCompareWith = obj as ProducentDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                 this.Name == toCompareWith.Name;
        }
}

}
