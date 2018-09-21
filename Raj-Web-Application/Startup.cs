using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Raj_Web_Application.Startup))]
namespace Raj_Web_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
