using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQueryAjaxInAsp.NETMVC.Startup))]
namespace jQueryAjaxInAsp.NETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
