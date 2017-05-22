using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Services;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Web.Models;

namespace MakeComputerShop.Web.Controllers
{
    public class ProducentController : Controller
    {
        private IGenericService<ProducentDto> iProducentService;

        public ProducentController(IGenericService<ProducentDto> iProducentService)
        {
            this.iProducentService = iProducentService;
        }
        // GET: Producent
        [Authorize]
        public ActionResult Producents()
        {
            var producents = iProducentService.GetAll();

            return View();
        }
        [Authorize]
        public ActionResult Producent(int id)
        {
            var producent = iProducentService.GetItemById(id);
            return View(producent);
        }
    }
}