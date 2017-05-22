using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Dal.Models;
using MakeComputerShop.Web.Controllers;
using NUnit.Framework;
using System.Web.Mvc;


namespace MakeComputerShop.Tests
{
    [TestFixture]
    public class ProducentControllerTest
    {
        [Test]
        public void Producents_ActionResult_Test()
        {
            ProducentController controller = new ProducentController();

            var actual = controller.Producents();

            Assert.IsInstanceOf<ActionResult>(actual);
        }
    }
}
