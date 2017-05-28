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

        public GraphicsCardController(IGenericService<GraphicsCardDto> iGraphicsCardService)
        {
            this.iGraphicsCardService = iGraphicsCardService;
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
    }
}