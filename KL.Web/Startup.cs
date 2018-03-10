using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KL.Web.Startup))]
namespace KL.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
