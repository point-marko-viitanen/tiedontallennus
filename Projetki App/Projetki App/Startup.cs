using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projetki_App.Startup))]
namespace Projetki_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
