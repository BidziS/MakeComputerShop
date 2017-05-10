using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MakeComputerShop.Web.Startup))]
namespace MakeComputerShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
