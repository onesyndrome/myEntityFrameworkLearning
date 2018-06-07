using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppIdentity.Startup))]
namespace WebAppIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
