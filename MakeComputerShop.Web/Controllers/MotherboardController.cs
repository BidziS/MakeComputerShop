using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class MotherboardController : Controller
    {
        private IGenericService<MotherboardDto> iMotherboardService;
        private IGenericService<ComputerDto> iComputerService;
        private IUserService iUserService;

        public MotherboardController(IGenericService<MotherboardDto> iMotherboardService,
            IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iMotherboardService = iMotherboardService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
        }

        // GET: Motherboard
        public ActionResult All()
        {
            var motherboards = iMotherboardService.GetAll();

            return View(motherboards);
        }

        public ActionResult Details(int id)
        {
            var motherboard = iMotherboardService.GetItemById(id);

            return View(motherboard);
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

            computer.Motherboard = iMotherboardService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart", "ShopCart");
        }
    }
}