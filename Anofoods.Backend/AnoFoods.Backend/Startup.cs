using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Anofoods.Backend.Startup))]
namespace Anofoods.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
