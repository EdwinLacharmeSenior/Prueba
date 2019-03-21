using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba_Git.Startup))]
namespace Prueba_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
