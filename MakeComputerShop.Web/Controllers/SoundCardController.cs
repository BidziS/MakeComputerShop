using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Dtos;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    public class SoundCardController : Controller
    {
        private IGenericService<SoundCardDto> iSoundCardService;
        private IGenericService<ComputerDto> iComputerService;
        private IUserService iUserService;

        public SoundCardController(IGenericService<SoundCardDto> iSoundCardService, 
            IGenericService<ComputerDto> iComputerService, IUserService iUserService)
        {
            this.iSoundCardService = iSoundCardService;
            this.iComputerService = iComputerService;
            this.iUserService = iUserService;
        }

        // GET: SoundCard
        public ActionResult All()
        {
            var soundCards = iSoundCardService.GetAll();

            return View(soundCards);
        }

        public ActionResult Details(int id)
        {
            var soundCard = iSoundCardService.GetItemById(id);

            return View(soundCard);
        }

        public RedirectToRouteResult AddToShopCart(int id)
        {
            var user = System.Web.HttpContext.Current.User.Identity.Name;

            if (user == "")
            {
                return RedirectToAction("Login", "Account");
            }

            var userFromBase = iUserService.GetItemByEmail(user);

            var computer = userFromBase.Computer;

            computer.SoundCard = iSoundCardService.GetItemById(id);

            iComputerService.UpdateItem(computer);

            return RedirectToAction("ShopCart", "ShopCart");
        }
    }
}