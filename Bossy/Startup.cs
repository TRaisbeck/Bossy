using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bossy.Startup))]
namespace Bossy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
