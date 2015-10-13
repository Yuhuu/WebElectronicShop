using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebElectronicShop.Startup))]
namespace WebElectronicShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
