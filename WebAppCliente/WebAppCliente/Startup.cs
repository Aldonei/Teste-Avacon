using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppCliente.Startup))]
namespace WebAppCliente
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
