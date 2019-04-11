using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleMapsWeb.Startup))]
namespace GoogleMapsWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
