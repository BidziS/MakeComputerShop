using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeComputerShop.Web.Controllers
{
    public class GraphicsCardController : Controller
    {
        IGenericService<GraphicsCardDto> iGraphicsCardService;
        private IGenericService<ComputerDto> iComputerService;
        private IUserService iUserService;

        public GraphicsCardController(IGenericService<GraphicsCardDto> iGraphicsCardService, 
            IGenericService<ComputerDto> iComputerService, IUserService iUserService )
        {
            this.iGraphicsCardService = iGraphicsCardService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
        }

        // GET: GraphicsCard
        public ActionResult All()
        {
            var graphicsCards = iGraphicsCardService.GetAll();

            return View(graphicsCards);
        }

        public ActionResult Details(int id)
        {
            var graphicsCard = iGraphicsCardService.GetItemById(id);

            return View(graphicsCard);
        }
        public RedirectToRouteResult AddToShopCart(int id)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            computer.GraphicsCard = iGraphicsCardService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("All");


        }
    }
}