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

        /// <summary>
        /// Metoda zwraca wszystkie dostępne w bazie komputery
        /// </summary>
        /// <returns>IEnumerable<ComputerDto></returns>
        public ActionResult All()
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var computers = iComputerService.GetAll();

            return View(computers);
        }

        /// <summary>
        /// Metoda zwraca informacje szczegółowe o komputerze
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ComputerDto</returns>
        /// 
        public ActionResult Details(int id)
        {
            var computer = iComputerService.GetItemById(id);

            return View(computer);
        }
    }
}