using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_21_WCf_Client.Startup))]
namespace _21_WCf_Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
