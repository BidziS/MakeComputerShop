using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeComputerShop.Web.Controllers
{
    public class PowerSupplyController : Controller
    {
        private IGenericService<PowerSupplyDto> iPowerSupplyService;
        IGenericService<ComputerDto> iComputerService;
        IUserService iUserService;


        public PowerSupplyController(IGenericService<PowerSupplyDto> iPowerSupplyService,
                                        IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iPowerSupplyService = iPowerSupplyService;
            this.iUserService = iUserService;
            this.iComputerService = iComputerService;
        }

        // GET: PowerSupply
        public ActionResult All()
        {
            var powerSupplies = iPowerSupplyService.GetAll();

            return View(powerSupplies);
        }

        public ActionResult Details(int id)
        {
            var powerSupply = iPowerSupplyService.GetItemById(id);

            return View(powerSupply);
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

            computer.PowerSupply = iPowerSupplyService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart", "ShopCart");


        }
    }
}