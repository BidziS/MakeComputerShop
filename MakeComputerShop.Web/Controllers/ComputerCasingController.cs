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
        private IGenericService<ComputerCasingDto> iComputerCasingService;
        IGenericService<ComputerDto> iComputerService;
        IUserService iUserService;
        IGenericService<DriveDto> iDriveService;

        public ComputerCasingController(IGenericService<ComputerCasingDto> iComputerCasingService,
            IGenericService<ComputerDto> iComputerService, IUserService iUserService,
            IGenericService<DriveDto> iDriveService)
        {
            this.iComputerCasingService = iComputerCasingService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
            this.iDriveService = iDriveService;
        }

        // GET: Processor
        public ActionResult All()
        {
            var computer_casings = iComputerCasingService.GetAll();

            return View(computer_casings);
        }

        public ActionResult Details(int id)
        {
            var computer_casing = iComputerCasingService.GetItemById(id);

            return View(computer_casing);
        }

        public RedirectToRouteResult AddToShopCart(ComputerCasingDto computer_casing)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            //var drive = iDriveService.GetItemById(1);

            //drive.Price = 123;

            //iDriveService.UpdateItem(drive);

            computer.ComputerCasing = computer_casing;

            iComputerService.UpdateItem(computer);

            return RedirectToAction("All");


        }
    }
}