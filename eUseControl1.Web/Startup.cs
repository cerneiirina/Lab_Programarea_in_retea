using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eUseControl1.Web.Startup))]
namespace eUseControl1.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
