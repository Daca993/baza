using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Baza_Filmova.Startup))]
namespace Baza_Filmova
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
