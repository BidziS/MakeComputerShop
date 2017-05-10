using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeComputerShop.Dal.Models
{
    public class ShopCardListDb
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        List<BaseDb> shopCardList = new List<BaseDb>();
    }
}
