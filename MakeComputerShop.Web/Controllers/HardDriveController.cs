using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeComputerShop.Web.Controllers
{
    public class HardDriveController : Controller
    {
        private IGenericService<HardDriveDto> iHardDriveService;
        IGenericService<ComputerDto> iComputerService;
        IUserService iUserService;
        IGenericService<DriveDto> iDriveService;

        public HardDriveController(IGenericService<HardDriveDto> iHardDriveService,
            IGenericService<ComputerDto> iComputerService, IUserService iUserService,
            IGenericService<DriveDto> iDriveService)
        {
            this.iHardDriveService = iHardDriveService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
            this.iDriveService = iDriveService;
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

        public RedirectToRouteResult AddToShopCart(HardDriveDto hard_drive)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            //var drive = iDriveService.GetItemById(1);

            //drive.Price = 123;

            //iDriveService.UpdateItem(drive);

            computer.HardDrive = hard_drive;

            iComputerService.UpdateItem(computer);

            return RedirectToAction("All");


        }
    }
}