using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wepApp.Startup))]
namespace wepApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
