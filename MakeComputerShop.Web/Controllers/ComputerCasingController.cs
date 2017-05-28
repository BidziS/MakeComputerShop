using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeComputerShop.Web.Controllers
{
    public class ComputerCasingController : Controller
    {
        IGenericService<ComputerCasingDto> iComputerCaseService;

        public ComputerCasingController(IGenericService<ComputerCasingDto> iComputerCaseService)
        {
            this.iComputerCaseService = iComputerCaseService;
        }

        // GET: ComputerCasing
        public ActionResult All()
        {
            var computerCases = iComputerCaseService.GetAll();

            return View(computerCases);
        }

        public ActionResult Details(int id)
        {
            var computerCase = iComputerCaseService.GetItemById(id);

            return View(computerCase);
        }
    }
}