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
        private IHardDriveService iHardDriveService;

        public HardDriveController(IHardDriveService iHardDriveService)
        {
            this.iHardDriveService = iHardDriveService;
        }

        public HardDriveController()
        {
        }

        // GET: Producent
        public ActionResult HardDrives()
        {
            var hardDrive = iHardDriveService.GetHardDrives();
            return View(hardDrive);
        }

        public ActionResult HardDrives(int id)
        {
            var hardDrive = iHardDriveService.GetHardDriveById(id);
            return View(hardDrive);
        }
    }
}