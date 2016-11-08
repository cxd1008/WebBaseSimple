using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBaseSimple.Startup))]
namespace WebBaseSimple
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
