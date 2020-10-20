using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaintenanceMaster.Startup))]
namespace MaintenanceMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
