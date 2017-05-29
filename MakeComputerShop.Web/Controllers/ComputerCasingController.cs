using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeComputerShop.Web.Controllers
{
    public class ComputerCasingController : Controller
    {
        IGenericService<ComputerCasingDto> iComputerCaseService;
        private IGenericService<ComputerDto> iComputerService;
        private IUserService iUserService;


        public ComputerCasingController(IGenericService<ComputerCasingDto> iComputerCaseService, 
                                        IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iComputerCaseService = iComputerCaseService;
            this.iUserService = iUserService;
            this.iComputerService = iComputerService;
        }

        // GET: ComputerCasing
        public ActionResult All()
        {
            var computerCases = iComputerCaseService.GetAll();

            return View(computerCases);
        }

        public ActionResult Details(int id)
        {
            var computerCase = iComputerCaseService.GetItemById(id);

            return View(computerCase);
        }
        public RedirectToRouteResult AddToShopCart(int id)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            computer.ComputerCasing = iComputerCaseService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart","ShopCart");


        }
    }
}