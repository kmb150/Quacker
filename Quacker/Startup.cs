using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quacker.Startup))]
namespace Quacker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
