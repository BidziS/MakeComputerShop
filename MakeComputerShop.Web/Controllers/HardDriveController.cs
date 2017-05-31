using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class HardDriveController : Controller
    {
        private IGenericService<HardDriveDto> iHardDriveService;
        IGenericService<ComputerDto> iComputerService;
        IUserService iUserService;

        public HardDriveController(IGenericService<HardDriveDto> iHardDriveService,
            IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iHardDriveService = iHardDriveService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
        }

        // GET: Processor
        public ActionResult All()
        {
            var hard_drives = iHardDriveService.GetAll();

            return View(hard_drives);
        }

        public ActionResult Details(int id)
        {
            var hard_drive = iHardDriveService.GetItemById(id);

            return View(hard_drive);
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

            computer.HardDrive = iHardDriveService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart", "ShopCart");


        }
    }
}