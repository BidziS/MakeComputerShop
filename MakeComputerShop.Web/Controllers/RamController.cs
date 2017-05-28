using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class RamController : Controller
    {
        private IGenericService<RamDto> iRamService;

        public RamController(IGenericService<RamDto> iRamService)
        {
            this.iRamService = iRamService;
        }

        // GET: Ram
        public ActionResult All()
        {
            var rams = iRamService.GetAll();

            return View(rams);
        }

        public ActionResult Details(int id)
        {
            var ram = iRamService.GetItemById(id);

            return View(ram);
        }
    }
}