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

        public NetworkCardController(IGenericService<NetworkCardDto> iNetworkCardService)
        {
            this.iNetworkCardService = iNetworkCardService;
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
    }
}