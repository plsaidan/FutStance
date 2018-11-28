using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FutStance.WebMVC.Startup))]
namespace FutStance.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
