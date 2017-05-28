using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class MotherboardController : Controller
    {
        private IGenericService<MotherboardDto> iMotherboardService;

        public MotherboardController(IGenericService<MotherboardDto> iMotherboardService)
        {
            this.iMotherboardService = iMotherboardService;
        }

        // GET: Motherboard
        public ActionResult All()
        {
            var motherboards = iMotherboardService.GetAll();

            return View(motherboards);
        }

        public ActionResult Details(int id)
        {
            var motherboard = iMotherboardService.GetItemById(id);

            return View(motherboard);
        }
    }
}