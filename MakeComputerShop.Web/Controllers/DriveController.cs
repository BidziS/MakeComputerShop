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

        public DriveController(IGenericService<DriveDto> iDriveService)
        {
            this.iDriveService = iDriveService;
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
    }
}