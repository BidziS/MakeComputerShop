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

        public HardDriveController(IGenericService<HardDriveDto> iHardDriveService)
        {
            this.iHardDriveService = iHardDriveService;
        }

        // GET: HardDrive
        public ActionResult All()
        {
            var hardDrives = iHardDriveService.GetAll();

            return View(hardDrives);
        }

        public ActionResult Details(int id)
        {
            var hardDrive = iHardDriveService.GetItemById(id);

            return View(hardDrive);
        }
    }
}