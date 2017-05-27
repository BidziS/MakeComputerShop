using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeComputerShop.Web.Controllers
{
    public class PowerSupplyController : Controller
    {
        // GET: PowerSupply
        public ActionResult All()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}