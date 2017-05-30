﻿using System;
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

        // GET: Processor
        public ActionResult All()
        {
            var processors = iProcessorService.GetAll();

            return View(processors);
        }

        public ActionResult Details(int id)
        {
            var processor = iProcessorService.GetItemById(id);

            return View(processor);
        }

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