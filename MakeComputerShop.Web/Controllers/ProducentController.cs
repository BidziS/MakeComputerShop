using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class ProducentController : Controller
    {
        private IProducentService iProducentService;

        public ProducentController(IProducentService iProducentService)
        {
            this.iProducentService = iProducentService;
        }
        // GET: Producent
        public ActionResult Producents()
        {
            var producents = iProducentService.GetProducents();
            return View(producents);
        }

        public ActionResult Producent(int id)
        {
            var producent = iProducentService.GetProducentById(id);
            return View(producent);
        }
    }
}