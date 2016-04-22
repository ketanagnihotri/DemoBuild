using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoBuild.Startup))]
namespace DemoBuild
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
