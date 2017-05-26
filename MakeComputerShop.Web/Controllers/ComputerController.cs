using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    [Authorize]
    public class ComputerController : Controller
    {

        private IGenericService<ComputerDto> iComputerService;

        public ComputerController(IGenericService<ComputerDto> iComputerService)
        {
            this.iComputerService = iComputerService;
        }

        // GET: Details
        public ActionResult All()
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var computers = iComputerService.GetAll();

            return View(computers);
        }

        public ActionResult Details(int id)
        {
            var computer = iComputerService.GetItemById(id);

            return View(computer);
        }
    }
}