using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class RamController : Controller
    {
        private IGenericService<RamDto> iRamService;
        private IGenericService<ComputerDto> iComputerService;
        private IUserService iUserService;

        public RamController(IGenericService<RamDto> iRamService,
            IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iRamService = iRamService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
        }

        // GET: Ram
        public ActionResult All()
        {
            var rams = iRamService.GetAll();

            return View(rams);
        }

        public ActionResult Details(int id)
        {
            var ram = iRamService.GetItemById(id);

            return View(ram);
        }
        public RedirectToRouteResult AddToShopCart(int id)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            if (user == "")
            {
                return RedirectToAction("Login", "Account");
            }

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            computer.Ram = iRamService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart", "ShopCart");
        }
    }
}