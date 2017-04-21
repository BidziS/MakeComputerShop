using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MakeComputerShop.Bll;

namespace MakeComputerShop.Web.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigurationAutofac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(WebApiApplication).Assembly);

            builder.RegisterModule(new ServicesModule());

            builder.RegisterControllers(typeof(WebApiApplication).Assembly);

            var container = builder.Build();


            // Set the dependency resolver for MVC.
            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);
        }
    }
}