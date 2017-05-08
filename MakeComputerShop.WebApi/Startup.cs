using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MakeComputerShop.WebApi.Startup))]
namespace MakeComputerShop.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
