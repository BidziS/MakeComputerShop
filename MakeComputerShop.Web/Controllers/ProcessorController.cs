using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class ProcessorController : Controller
    {
        private IGenericService<ProcesorDto> iProcessorService;
        IGenericService<ComputerDto> iComputerService;
        IUserService iUserService;

        public ProcessorController(IGenericService<ProcesorDto> iProcessorService, 
            IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iProcessorService = iProcessorService;
            this.iUserService = iUserService;
            this.iComputerService = iComputerService;
        }

        /// <summary>
        /// Metoda zwraca wszystkie dostępne w bazie procesory
        /// </summary>
        /// <returns>IEnumerable<ProcesorDto></returns>
        public ActionResult All()
        {
            var processors = iProcessorService.GetAll();

            return View(processors);
        }

        /// <summary>
        /// Metoda zwraca informacje szczegółowe o procesorze
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ProcesorDto</returns>
        public ActionResult Details(int id)
        {
            var processor = iProcessorService.GetItemById(id);

            return View(processor);
        }

        /// <summary>
        /// Metoda ta dodaje wybrany procesor do komputera zalogowanego użytkownika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RedirectToRouteResult AddToShopCart(int id)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            //var drive = iDriveService.GetItemById(1);

            //drive.Price = 123;

            //iDriveService.UpdateItem(drive);

            computer.Procesor = iProcessorService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart", "ShopCart");


        }
    }
}