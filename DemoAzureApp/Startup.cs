using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAzureApp.Startup))]
namespace DemoAzureApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
