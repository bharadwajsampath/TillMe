using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TillMe.Startup))]
namespace TillMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
