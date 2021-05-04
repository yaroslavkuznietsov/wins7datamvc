using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WinS7Data.Web.Startup))]
namespace WinS7Data.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
