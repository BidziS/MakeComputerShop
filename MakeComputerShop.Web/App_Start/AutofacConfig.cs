using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MakeComputerShop.Bll;

namespace MakeComputerShop.Web
{
    public class AutofacConfig
    {
        public static void ConfigurationAutofac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule(new ServicesModule());

            builder.RegisterModule(new RepositoriesModule());

            var container = builder.Build();


            // Set the dependency resolver for MVC.
            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);
        }
    }
}