using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MOP.Startup))]
namespace MOP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
