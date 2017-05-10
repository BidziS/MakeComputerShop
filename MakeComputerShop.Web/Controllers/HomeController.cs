using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProducentService iProducentService;

        public HomeController(IProducentService iProducentService)
        {
            this.iProducentService = iProducentService;
        }

        public ActionResult Index()
        {
            ProducentDto producent = iProducentService.GetProducentById(1);

            ViewBag.Title = "Home Page " + producent.Name;

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