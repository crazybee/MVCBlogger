using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BLOGGER.Startup))]
namespace BLOGGER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
