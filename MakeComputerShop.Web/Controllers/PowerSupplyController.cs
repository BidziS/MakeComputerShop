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
        IGenericService<DriveDto> iDriveService;

        public PowerSupplyController(IGenericService<PowerSupplyDto> iPowerSupplyService,
            IGenericService<ComputerDto> iComputerService, IUserService iUserService,
            IGenericService<DriveDto> iDriveService)
        {
            this.iPowerSupplyService = iPowerSupplyService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
            this.iDriveService = iDriveService;
        }

        // GET: Processor
        public ActionResult All()
        {
            var power_supplies = iPowerSupplyService.GetAll();
            
            return View(power_supplies);
            //return new RazorPDF.PdfActionResult("All", power_supplies);
        }


        public ActionResult Details(int id)
        {
            var power_supply = iPowerSupplyService.GetItemById(id);

            return View(power_supply);
        }
        

        public RedirectToRouteResult AddToShopCart(PowerSupplyDto power_supply)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            //var drive = iDriveService.GetItemById(1);

            //drive.Price = 123;

            //iDriveService.UpdateItem(drive);

            computer.PowerSupply = power_supply;

            iComputerService.UpdateItem(computer);

            return RedirectToAction("All");


        }
    }
}