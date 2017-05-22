using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MakeComputerShop.Bll;
using MakeComputerShop.Web.Models;
using Module = Autofac.Module;

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

            builder.RegisterModule(new ApplicationDbModule());

            var container = builder.Build();


            // Set the dependency resolver for MVC.
            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);
        }

       
    }

    public class ApplicationDbModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly assembly = typeof(ApplicationDbContext).GetTypeInfo().Assembly;


            builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>();

        }
    }
}