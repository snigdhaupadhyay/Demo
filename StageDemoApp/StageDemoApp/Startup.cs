using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StageDemoApp.Startup))]
namespace StageDemoApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
