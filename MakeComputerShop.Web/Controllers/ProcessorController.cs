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

        public ProcessorController(IGenericService<ProcesorDto> iProcessorService)
        {
            this.iProcessorService = iProcessorService;
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
    }
}