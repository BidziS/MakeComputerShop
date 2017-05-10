using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class RamController : Controller
    {
        private IRamService iRamService;

        public RamController(IRamService iRamService)
        {
            this.iRamService = iRamService;
        }
        // GET: Ram
        public ActionResult Rams()
        {
            var rams = iRamService.GetRams();
            return View(rams);
        }
    }
}