using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeComputerShop.Web.Controllers
{
    public class DriveController : Controller
    {
        IGenericService<DriveDto> iDriveService;
        private IGenericService<ComputerDto> iComputerService;
        private IUserService iUserService;

        public DriveController(IGenericService<DriveDto> iDriveService, IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iDriveService = iDriveService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
        }

        // GET: Drive
        public ActionResult All()
        {
            var drives = iDriveService.GetAll();

            return View(drives);
        }

        public ActionResult Details(int id)
        {
            var drive = iDriveService.GetItemById(id);

            return View(drive);
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

            computer.Drive = iDriveService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart", "ShopCart");


        }
    }
}