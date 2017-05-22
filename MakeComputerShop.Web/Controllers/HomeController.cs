using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;
using MakeComputerShop.Bll.Services.Impl;
using MakeComputerShop.Web.Models;

namespace MakeComputerShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private IGenericService<ProducentDto> iProducentService;

        public HomeController(IGenericService<ProducentDto> iProducentService)
        {
            this.iProducentService = iProducentService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}