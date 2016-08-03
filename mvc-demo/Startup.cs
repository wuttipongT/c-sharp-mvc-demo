using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WMS_Web_SCG_CDMA.Startup))]
namespace WMS_Web_SCG_CDMA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
