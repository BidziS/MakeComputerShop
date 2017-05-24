using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class ComputerCasingController : Controller
    {
        private IComputerCasingService iComputerCasingService;

        public ComputerCasingController(IComputerCasingService iComputerCasingService)
        {
            this.iComputerCasingService = iComputerCasingService;
        }

        public ComputerCasingController()
        {
        }

        // GET: Producent
        public ActionResult ComputerCasings()
        {
            var computerCasings = iComputerCasingService.GetComputerCasings();
            return View(computerCasings);
        }

        public ActionResult ComputerCasing(int id)
        {
            var computerCasing = iComputerCasingService.GetComputerCasingById(id);
            return View(computerCasing);
        }
    }
}