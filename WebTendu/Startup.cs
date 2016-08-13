using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTendu.Startup))]
namespace WebTendu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
