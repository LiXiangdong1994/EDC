using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EDC.Startup))]
namespace EDC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
