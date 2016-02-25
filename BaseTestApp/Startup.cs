using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseTestApp.Startup))]
namespace BaseTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
