using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eUseControl.Web.Startup))]
namespace eUseControl.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
