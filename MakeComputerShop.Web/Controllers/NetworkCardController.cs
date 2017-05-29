using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class NetworkCardController : Controller
    {
        private IGenericService<NetworkCardDto> iNetworkCardService;
        private IGenericService<ComputerDto> iComputerService;
        private IUserService iUserService;

        public NetworkCardController(IGenericService<NetworkCardDto> iNetworkCardService,
            IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iNetworkCardService = iNetworkCardService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
        }

        // GET: NetworkCard
        public ActionResult All()
        {
            var networkCards = iNetworkCardService.GetAll();

            return View(networkCards);
        }

        public ActionResult Details(int id)
        {
            var networkCard = iNetworkCardService.GetItemById(id);

            return View(networkCard);
        }
        public RedirectToRouteResult AddToShopCart(int id)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            computer.NetworkCard = iNetworkCardService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("All");
        }
    }
}