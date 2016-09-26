using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBlogger.Startup))]
namespace MVCBlogger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
