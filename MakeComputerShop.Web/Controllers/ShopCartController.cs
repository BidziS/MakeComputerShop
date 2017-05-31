using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakeComputerShop.Bll.Services;

namespace MakeComputerShop.Web.Controllers
{
    [Authorize]
    public class ShopCartController : Controller
    {
        private IUserService iUserService;

        public ShopCartController(IUserService iUserService)
        {
            this.iUserService = iUserService;
        }

        /// <summary>
        /// Zwraca komputer, który jest w koszyku
        /// </summary>
        /// <returns>ComputerDto</returns>
        public ActionResult ShopCart()
        {
            ViewBag.IsShop = true;

            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var shopCart = userFromBase.Computer;

            return View(shopCart);
        }

        /// <summary>
        /// Metoda generująca zamówienie w formie PDF
        /// </summary>
        /// <returns>plik PDF</returns>
        public ActionResult Invoice()
        {
            ViewBag.IsShop = true;

            var user = System.Web.HttpContext.Current.User.Identity.Name;

            var userFromBase = iUserService.GetItemByEmail(user);

            var shopCart = userFromBase.Computer;

            return new RazorPDF.PdfActionResult("Invoice", shopCart);
        }
    }
}