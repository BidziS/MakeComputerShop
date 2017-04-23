using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class MotherboardController : Controller
    {
        private IMotherboardService iMotherboardService;

        public MotherboardController(IMotherboardService iMotherboardService)
        {
            this.iMotherboardService = iMotherboardService;
        }

        // GET: Motherboard
        public ActionResult Motherboards()
        {
            var motherboards = iMotherboardService.GetMotherboards();
            return View();
        }
    }
}