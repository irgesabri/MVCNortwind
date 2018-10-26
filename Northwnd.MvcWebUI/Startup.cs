using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Northwnd.MvcWebUI.Startup))]
namespace Northwnd.MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
